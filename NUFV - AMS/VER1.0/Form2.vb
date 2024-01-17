
Imports MySql.Data.MySqlClient

Public Class Form2

    Dim str As String = "server=localhost; uid=root; pwd=; database=database1"
    Dim con As New MySqlConnection(str)


    Private Sub btn1_submit_Click(sender As Object, e As EventArgs) Handles btn1_submit.Click
        Dim msg As DialogResult


        msg = MessageBox.Show("Do you wish to submit?", "Prompt,", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim cmd As MySqlCommand
        If msg = DialogResult.Yes Then
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "insert into tbl_product(pname,pdesc,pprice,wprice,stocks)values(@pname,@pdesc,@pprice,@wprice,@stocks);"
            cmd.Parameters.AddWithValue("@pname", productnametxt.Text)
            cmd.Parameters.AddWithValue("@pdesc", productdesctxt.Text)
            cmd.Parameters.AddWithValue("@pprice", productpricetxt.Text)
            cmd.Parameters.AddWithValue("@wprice", wsaletxt.Text)
            cmd.Parameters.AddWithValue("@stocks", stockstxt.Text)






            cmd.ExecuteNonQuery()
            con.Close()
            Form14.Show()
            Me.Hide()

        Else

            productnametxt.Clear()
            productpricetxt.Clear()
            wsaletxt.Clear()
            productdesctxt.Clear()
            stockstxt.Clear()



        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Dim del As DialogResult
        del = MessageBox.Show("Are you sure you want do delete?", "Clear",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If del = DialogResult.OK Then

            productnametxt.Clear()
            wsaletxt.Clear()
            productpricetxt.Clear()
            productdesctxt.Clear()
            stockstxt.Clear()
            productpricetxt.Clear()


        Else
            Me.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        If DialogResult.OK Then

            productnametxt.Clear()
            wsaletxt.Clear()
            productpricetxt.Clear()
            productdesctxt.Clear()
            stockstxt.Clear()

            productpricetxt.Clear()

        Else
            Me.Show()
        End If

    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim YN As DialogResult
        YN = MessageBox.Show("Are you sure you want to Exit?", "Exit",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If YN = DialogResult.Yes Then
            Me.Close()
        Else
            MessageBox.Show("Canceled")
        End If
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Popuplogin As DialogResult
        Popuplogin = MessageBox.Show("Page Will Exit, you will be directed back to Login Page", "Warning",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Popuplogin = DialogResult.Yes Then
            Me.Close()
            LoginForm.Show()
        Else
            MessageBox.Show("Canceled")
        End If
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class