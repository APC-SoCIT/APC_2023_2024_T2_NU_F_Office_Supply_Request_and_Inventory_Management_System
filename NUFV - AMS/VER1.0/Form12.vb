Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DocumentFormat.OpenXml.Bibliography

Public Class Form12


    Dim connection As New SqlConnection("Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True")

    Public Sub Datarefresh()
        Dim query As String = "select tbl_customers.customername, tbl_customers.customerlname, tbl_customers.contactinfo, tbl_customers.email, tbl_product.pname,tbl_product.pprice, tbl_paymentinfos.paymentoption, tbl_paymentinfos.value AS 'Payment Amount'
	from tbl_customers
	INNER JOIN tbl_paymentinfos on tbl_customers.customerid = tbl_paymentinfos.paymentid
	INNER JOIN tbl_product on tbl_customers.customerid = tbl_product.productid"
        Using connectdb As SqlConnection = New SqlConnection("Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True")
            Using cmnd As SqlCommand = New SqlCommand(query, connectdb)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmnd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView2.DataSource = dt
                    End Using

                End Using

            End Using
        End Using
    End Sub




    Public Sub Datarefresh2()
        Dim query As String = "select * from tbl_customers"
        Using connectdb As SqlConnection = New SqlConnection("Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True")
            Using cmnd As SqlCommand = New SqlCommand(query, connectdb)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmnd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView4.DataSource = dt
                    End Using

                End Using

            End Using
        End Using
    End Sub


    Public Sub Datarefresh3()
        Dim query As String = "select * from tbl_product"
        Using connectdb As SqlConnection = New SqlConnection("Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True")
            Using cmnd As SqlCommand = New SqlCommand(query, connectdb)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmnd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView3.DataSource = dt
                    End Using

                End Using

            End Using
        End Using
    End Sub
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbprofileDataSet7.tbl_paymentinfos' table. You can move, or remove it, as needed.
        Me.Tbl_paymentinfosTableAdapter1.Fill(Me.DbprofileDataSet7.tbl_paymentinfos)
        'TODO: This line of code loads data into the 'DbprofileDataSet4.tbl_customers' table. You can move, or remove it, as needed.
        Me.Tbl_customersTableAdapter.Fill(Me.DbprofileDataSet4.tbl_customers)
        'TODO: This line of code loads data into the 'DbprofileDataSet3.tbl_payments' table. You can move, or remove it, as needed.
        Me.Tbl_productTableAdapter.Fill(Me.DbprofileDataSet1.tbl_product)

        Me.HorizontalScroll.Maximum = 0
        Me.AutoScroll = True

        Timer1.Enabled = True





        connection.Open()
        Dim cmd2 As New SqlCommand("select count(*) from tbl_product", connection)
        Dim count2 = Convert.ToString(cmd2.ExecuteScalar)
        Label24.Text = count2
        connection.Close()


        connection.Open()
        Dim cmd3 As New SqlCommand("select SUM(value) from tbl_paymentinfos", connection)
        Dim count3 = Convert.ToString(cmd3.ExecuteScalar)
        Label25.Text = count3
        connection.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim command As New SqlCommand("insert into tbl_customers(customerid, customername, customerlname, customermname, contactinfo, customeraddress, email) values(@customerid, @customername, @customerlname, @customermname, @contactinfo, @customeraddress, @email)", connection)

        command.Parameters.Add("@customerid", SqlDbType.Int).Value = txtboxcustoid.Text
        command.Parameters.Add("@customername", SqlDbType.VarChar).Value = txtbxcustoname.Text
        command.Parameters.Add("@customerlname", SqlDbType.VarChar).Value = txtboxcustolname.Text
        command.Parameters.Add("@customermname", SqlDbType.VarChar).Value = txtboxcustomname.Text
        command.Parameters.Add("@contactinfo", SqlDbType.VarChar).Value = txtboxcontactinfo.Text
        command.Parameters.Add("@customeraddress", SqlDbType.VarChar).Value = txtboxcustoaddress.Text
        command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtboxcustoemail.Text

        connection.Open()
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New User Added")

        Else

            MessageBox.Show("User Not Added")

        End If

        connection.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, Button11.Click
        Datarefresh()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label11.Text = TimeString
        Label12.Text = DateString

    End Sub

    Private Sub btnimport_Click(sender As Object, e As EventArgs) Handles btnimport.Click, Button8.Click
        Form9.Show()
        Me.Close()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button10.Click
        Form10.Show()
        Me.Hide()
    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick
        Dim row As DataGridViewRow = DataGridView4.CurrentRow
        Try
            txtboxcustoid.Text = row.Cells(0).Value.ToString()
            txtbxcustoname.Text = row.Cells(1).Value.ToString()
            txtboxcustolname.Text = row.Cells(2).Value.ToString()
            txtboxcustomname.Text = row.Cells(3).Value.ToString()
            txtboxcontactinfo.Text = row.Cells(4).Value.ToString()
            txtboxcustoaddress.Text = row.Cells(5).Value.ToString()
            txtboxcustoemail.Text = row.Cells(6).Value.ToString()




        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Dim query As String = "select * tbl_paymentinfos"
        Using connectdb As SqlConnection = New SqlConnection("Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True")
            Using cmnd As SqlCommand = New SqlCommand(query, connectdb)
                Using da As New SqlDataAdapter()
                    da.SelectCommand = cmnd
                    Using dt As New DataTable()
                        da.Fill(dt)
                        DataGridView4.DataSource = dt
                    End Using

                End Using

            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        connection.Open()

        Dim customeriddel As Integer = txtboxcustoid.Text
        Dim command As New SqlCommand("DELETE FROM tbl_customers where customerid ='" & customeriddel & "'", connection)
        command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Successfully Deleted!")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        connection.Open()

        Dim command As New SqlCommand("Update tbl_customers SET customername='" & txtbxcustoname.Text & "', customerlname='" & txtboxcustolname.Text & "', customermname='" & txtboxcustomname.Text & "', contactinfo='" & txtboxcontactinfo.Text & "', customeraddress='" & txtboxcustoaddress.Text & "', email='" & txtboxcustoemail.Text & "' where customerid ='" & txtboxcustoid.Text & "'", connection)
        command.ExecuteNonQuery()
        MessageBox.Show("successfully updated!")
        connection.Close()


    End Sub



    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        connection.Open()
        Dim command As New SqlCommand("Update tbl_product SET pname='" & pname.Text & "', pdesc='" & pdesc.Text & "', pprice='" & pprice.Text & "', wprice='" & wprice.Text & "', stocks='" & stocks.Text & "' where customerid ='" & productid.Text & "'", connection)
        command.ExecuteNonQuery()
        MessageBox.Show("successfully updated!")
        connection.Close()

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        Dim row As DataGridViewRow = DataGridView3.CurrentRow
        Try
            productid.Text = row.Cells(0).Value.ToString()
            pname.Text = row.Cells(1).Value.ToString()
            pdesc.Text = row.Cells(2).Value.ToString()
            pprice.Text = row.Cells(3).Value.ToString()
            wprice.Text = row.Cells(4).Value.ToString()
            stocks.Text = row.Cells(5).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim command As New SqlCommand("DELETE FROM tbl_product where customerid ='" & productid.Text & "'", connection)
        command.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("Successfully Deleted!")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Datarefresh3()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Datarefresh2()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub
End Class