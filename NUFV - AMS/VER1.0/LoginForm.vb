Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Diagnostics.Eventing

Public Class LoginForm





    Private Sub btn1_Submit_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles btn1_Submit.Click
        ConnDB()
        Try
            'Sql Query to fetch the username and password
            sqllogin = "select * from accountcredentials where username = '" & textboxusername.Text & "' and passwd = '" & textboxpassword.Text & "'"

            'sql fetch command
            cmdlogin = New MySqlCommand(sqllogin, connlogin)
            Dim drlogin As MySqlDataReader = cmdlogin.ExecuteReader
            drlogin.Read()
            If textboxpassword.Text = "" Or textboxusername.Text = "" Then
                MsgBox("Please Fill up empty Fields!", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If

            If drlogin.HasRows = True Then
                Dim usertype As String = drlogin("usertype").ToString

                If usertype = "Admin" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    admindashboardclient.Show()
                    Me.Hide()

                ElseIf usertype = "Faculty" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    dashboardfaculty.Show()
                    Me.Hide()

                ElseIf usertype = "LRC" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    userdashboardlrc.Show()
                    Me.Hide()

                ElseIf usertype = "Accounting" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    userdashboardaccounting.Show()
                    Me.Hide()

                ElseIf usertype = "Admission" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    userdashboardadmission.Show()
                    Me.Hide()

                ElseIf usertype = "ITSO" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    userdashboardITSO.Show()
                    Me.Hide()


                ElseIf usertype = "Approver" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    admindashboardapprover.Show()
                    Me.Hide()


                ElseIf usertype = "SuperAdmin" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    SuperAdminDashboard.Show()
                    SuperAdminDashboard.PanelMenu.Hide()
                    Me.Hide()

                End If
            Else
                MsgBox("LOGIN FAILED, Incorrect Username or Password", MsgBoxStyle.Critical, "Notification")

                textboxpassword.Clear()
                textboxusername.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub



    Private Sub Button2_Click_3(sender As Object, e As EventArgs) Handles Button2.Click
        InventoryManagement.Show()
        Me.Hide()

    End Sub
End Class