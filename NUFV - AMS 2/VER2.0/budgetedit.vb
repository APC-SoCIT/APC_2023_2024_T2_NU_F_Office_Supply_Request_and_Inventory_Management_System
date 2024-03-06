Imports System.Web.UI.WebControls
Imports DocumentFormat.OpenXml.Bibliography
Imports Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient

Public Class budgetedit
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb"
    Dim con As New MySqlConnection(str)




    Sub loadbudget()
        Dim query As String = "select department AS Department, budgetamount AS Budget from budget"
        Dim adpt As New MySqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        con.Close()
    End Sub


    Private Sub budgetedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadbudget()
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        Try

            Label3.Text = row.Cells(0).Value.ToString()
            TextBox1.Text = row.Cells(1).Value.ToString()



        Catch ex As Exception

        End Try
    End Sub


    Private Sub UpdateBudget()
        Dim connectionString As String = "server=localhost; uid=root; pwd=; database=nufvdb" ' Replace with your connection string
        Dim query As String = "UPDATE budget SET budgetamount = @budgetamount WHERE department = @department"

        Dim budgetAmount As Double = Convert.ToDouble(TextBox1.Text)
        Dim department As String = Label3.Text

        Using connection As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@budgetamount", budgetAmount)
                cmd.Parameters.AddWithValue("@department", department)
                connection.Open()
                cmd.ExecuteNonQuery()
                loadbudget()
                connection.Close()

            End Using
        End Using
    End Sub

    Private Sub AddBudget()
        Dim connectionString As String = "server=localhost; uid=root; pwd=; database=nufvdb" ' Replace with your connection string
        Dim query As String = "INSERT INTO budget (department, budgetamount) VALUES (@department, @budgetamount)"

        Dim budgetAmount As Double = Convert.ToDouble(TextBox1.Text)
        Dim department As String = Label3.Text

        Using connection As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@budgetamount", budgetAmount)
                cmd.Parameters.AddWithValue("@department", department)
                connection.Open()
                cmd.ExecuteNonQuery()
                loadbudget() ' Assuming this method reloads the budget data
                connection.Close()
            End Using
        End Using
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateBudget()
        MessageBox.Show("Budget Updated!")
        admindashboardclient.budgetforaccounting()
        admindashboardclient.budgetforitso()
        admindashboardclient.budgetforadmission()
        admindashboardclient.budgetforlrc()
    End Sub
End Class