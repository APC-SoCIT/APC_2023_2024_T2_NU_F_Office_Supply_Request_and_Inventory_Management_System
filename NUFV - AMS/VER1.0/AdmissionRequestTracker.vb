Imports MySql.Data.MySqlClient

Public Class AdmissionRequestTracker
    ' Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub firstnamedisplay()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query1 As String = "SELECT Firstname FROM accountcredentials WHERE usertype = 'Admission'"

            Using cmd As New MySqlCommand(query1, connection)

                Dim reader1 As MySqlDataReader = cmd.ExecuteReader()

                If reader1.Read Then
                    Dim fname As String = reader1("firstname").ToString()
                    displayfname.Text = fname
                Else
                    displayfname.Text = "User not found"
                End If

                reader1.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        firstnamedisplay()
        DataGridView_load()
        PanelMenu.Hide()
        LoadFirstName()
    End Sub

    Private Sub LoadFirstName()
        Using connection As New MySqlConnection(str)
            connection.Open()

            Dim query As String = "SELECT firstname FROM accountcredentials WHERE usertype = 'Admission'"

            Using cmd As New MySqlCommand(query, connection)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    Dim firstName As String = reader("firstname").ToString()
                    lrcname.Text = firstName
                Else
                    lrcname.Text = "User not found"
                End If

                reader.Close()
                connection.Close()
            End Using
        End Using
    End Sub

    ' Data Viewing'
    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT
                                            tbl_osrequest.requestorName,
                                            tbl_osrequest.department,
                                            tbl_osrequest.date,
                                            tbl_reqstatus.status
                                         FROM
                                            tbl_osrequest
                                         JOIN
                                            tbl_reqstatus ON tbl_osrequest.requestID = tbl_reqstatus.requestID
                                         WHERE
                                            tbl_osrequest.department = 'Admission';", con)

            dr = cmd.ExecuteReader

            While dr.Read()
                DataGridView1.Rows.Add(dr("requestorName"), dr("department"), dr("date"), dr("status"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub

    'To serach in tracker within the database'
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT t1.requestorname, t1.department, t1.date, t2.status " &
                                         "FROM tbl_osrequest t1 " &
                                         "JOIN tbl_reqstatus t2 ON t1.requestId = t2.requestId " &
                                         "WHERE (t1.requestorname LIKE @SearchText OR t1.date LIKE @SearchText OR t2.status LIKE @SearchText) " &
                                         "AND t1.department = 'LRC'", con)
            cmd.Parameters.AddWithValue("@SearchText", "%" & txt_search.Text & "%")


            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                DataGridView1.Rows.Add(reader("requestorname"), reader("department"), reader("date"), reader("status"))
            End While

            reader.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PanelMenu.Show()
    End Sub

    Private Sub pcbmenuicon_Click(sender As Object, e As EventArgs) Handles pcbmenuicon.Click
        PanelMenu.Hide()

    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        PanelMenu.Hide()
        userdashboardadmission.Show()
        Me.Hide()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        LoginForm.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'time
        Label11.Text = Date.Now.ToString("dd MMM yyyy  hh:mm:ss")
    End Sub

End Class