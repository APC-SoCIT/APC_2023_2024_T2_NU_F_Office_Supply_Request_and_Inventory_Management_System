Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Drawing.Diagrams

Public Class Form14

    Dim connection As New SqlConnection("Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True")

    Private Sub btn1submit_Click(sender As Object, e As EventArgs) Handles btn1submit.Click



        If (txtboxcustoid.Text = "" Or txtboxfname.Text = "" Or txtboxlname.Text = "" Or txtboxmname.Text = "" Or txtboxcontactinfo.Text = "" Or txtboxaddress.Text = "" Or txtboxemailaddress.Text = "") Then
            MessageBox.Show("Please Input all fields")
        Else
            connection.Open()
            Dim command As New SqlCommand("insert into tbl_customers(customerid, customername, customerlname, customermname, contactinfo, customeraddress, email) values(@customerid, @customername, @customerlname, @customermname, @contactinfo, @customeraddress, @email)", connection)

            command.Parameters.Add("@customerid", SqlDbType.Int).Value = txtboxcustoid.Text
            command.Parameters.Add("@customername", SqlDbType.VarChar).Value = txtboxfname.Text
            command.Parameters.Add("@customerlname", SqlDbType.VarChar).Value = txtboxlname.Text
            command.Parameters.Add("@customermname", SqlDbType.VarChar).Value = txtboxmname.Text
            command.Parameters.Add("@contactinfo", SqlDbType.VarChar).Value = txtboxcontactinfo.Text
            command.Parameters.Add("@customeraddress", SqlDbType.VarChar).Value = txtboxaddress.Text
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = txtboxemailaddress.Text

            MessageBox.Show("Input Success! Proceeding to Payment Option")
            command.ExecuteNonQuery()
            Form15.Show()
            Me.Hide()
        End If
        connection.Close()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs)
        txtboxcustoid.Clear()
        txtboxfname.Clear()
        txtboxlname.Clear()
        txtboxmname.Clear()
        txtboxcontactinfo.Clear()
        txtboxaddress.Clear()
        txtboxemailaddress.Clear()
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class