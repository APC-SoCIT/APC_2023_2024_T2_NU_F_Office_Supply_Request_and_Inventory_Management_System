Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Office2010.CustomUI

Public Class Form15

    Dim connection As New SqlConnection("Data Source=LAPTOP-PJK8KVEG\SQLEXPRESS;Initial Catalog=dbprofile;Integrated Security=True")
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedItem.ToString() = "Card") Then
            lblcrdnumber.Visible = True
            txtboxcard.Visible = True


        Else
            lblcrdnumber.Visible = False
            txtboxcard.Visible = False
        End If

    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblcrdnumber.Visible = False
        txtboxcard.Visible = False
    End Sub

    Private Sub btn1submit_Click(sender As Object, e As EventArgs) Handles btn1submit.Click

        If (txtboxpaaymentid.Text = "") Then
            MessageBox.Show("Please Input all fields")
        Else
            connection.Open()
            Dim command As New SqlCommand("insert into tbl_paymentinfos(paymentid, paymentoption, cardnum, value) values(@paymentid, @paymentoption, @cardnum, @value)", connection)

            command.Parameters.Add("@paymentid", SqlDbType.Int).Value = txtboxpaaymentid.Text
            command.Parameters.Add("@paymentoption", SqlDbType.VarChar).Value = ComboBox1.Text
            command.Parameters.Add("@cardnum", SqlDbType.VarChar).Value = txtboxcard.Text
            command.Parameters.Add("@value", SqlDbType.Float).Value = txtboxamountvalue.Text

            MessageBox.Show("Input Success!")
            command.ExecuteNonQuery()
            Form16.Show()
            Me.Hide()
        End If
        connection.Close()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs)
        txtboxpaaymentid.Clear()
        txtboxcard.Clear()
        txtboxamountvalue.Clear()
    End Sub
End Class