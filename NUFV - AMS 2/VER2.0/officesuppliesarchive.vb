Imports MySql.Data.MySqlClient

Public Class officesuppliesarchive
    'Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb ; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub InventoryArchieve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_load()
    End Sub

    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            OpenConnection()

            Dim cmd As New MySqlCommand("SELECT * FROM tbl_officesupply_archive", con)
            dr = cmd.ExecuteReader
            While dr.Read
                'Format the DatePurchase for without time format'
                Dim datePurchaseFormatted As String = If(dr.IsDBNull(dr.GetOrdinal("DatePurchase")), "", CDate(dr.Item("DatePurchase")).ToString("yyyy-MM-dd"))

                ' Get the value in the Item Stock'
                Dim itemStock As Integer
                If Not Integer.TryParse(dr.Item("ItemStock").ToString(), itemStock) Then
                    Continue While
                End If

                ' Create a new row and add it to the DataGridView'
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(DataGridView1, dr.Item("ItemNumber"), dr.Item("ItemName"), dr.Item("ItemStock"), dr.Item("ItemUnit"), dr.Item("ItemStatus"), datePurchaseFormatted, dr.Item("ItemAmount"), dr.Item("ReorderPoint"))

                DataGridView1.Rows.Add(newRow)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub recoverbtn_Click(sender As Object, e As EventArgs) Handles btn_recover.Click
        Try
            OpenConnection()

            If DataGridView1.SelectedRows.Count > 0 Then
                ' Prompt the user for confirmation
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to recover this item?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Retrieve the selected row
                    Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                    ' Retrieve all the values from the selected row
                    Dim values As New List(Of Object)
                    For Each cell As DataGridViewCell In selectedRow.Cells
                        values.Add(cell.Value)
                    Next

                    ' Insert the retrieved values into tbl_officesupply
                    Using insertCmd As New MySqlCommand("INSERT INTO tbl_officesupply (ItemNumber, ItemName, ItemStock, ItemUnit, ItemStatus, DatePurchase, ItemAmount, ReorderPoint) VALUES (@ItemNumber, @ItemName, @ItemStock, @ItemUnit, @ItemStatus, @DatePurchase, @ItemAmount, @ReorderPoint)", con)
                        insertCmd.Parameters.AddWithValue("@ItemNumber", values(0))
                        insertCmd.Parameters.AddWithValue("@ItemName", values(1))
                        insertCmd.Parameters.AddWithValue("@ItemStock", values(2))
                        insertCmd.Parameters.AddWithValue("@ItemUnit", values(3))
                        insertCmd.Parameters.AddWithValue("@ItemStatus", values(4))
                        insertCmd.Parameters.AddWithValue("@DatePurchase", values(5))
                        insertCmd.Parameters.AddWithValue("@ItemAmount", values(6))
                        insertCmd.Parameters.AddWithValue("@ReorderPoint", values(7))

                        ' Execute the insert command
                        i = insertCmd.ExecuteNonQuery()

                        ' Check if the insert operation was successful
                        If i > 0 Then
                            ' Delete the selected row from tbl_officesupply_archive
                            Using deleteCmd As New MySqlCommand("DELETE FROM tbl_officesupply_archive WHERE ItemNumber = @ItemNumber", con)
                                deleteCmd.Parameters.AddWithValue("@ItemNumber", values(0))
                                deleteCmd.ExecuteNonQuery()
                            End Using

                            ' Display success message
                            MessageBox.Show("Item successfully recovered", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the DataGridView
                            DataGridView_load()
                        Else
                            MessageBox.Show("Failed to recover item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End If
            Else
                MessageBox.Show("Please select an item to recover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btn_delpermanently_Click(sender As Object, e As EventArgs) Handles btn_delpermanently.Click
        Try
            OpenConnection()

            If DataGridView1.SelectedRows.Count > 0 Then
                Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to permanently delete the selected item(s)?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmation = DialogResult.Yes Then
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        Dim itemNumber As String = selectedRow.Cells(0).Value.ToString()

                        ' Delete the selected row from tbl_officesupply_archive
                        Dim deleteCmd As New MySqlCommand("DELETE FROM tbl_officesupply_archive WHERE ItemNumber = @ItemNumber", con)
                        deleteCmd.Parameters.AddWithValue("@ItemNumber", itemNumber)
                        deleteCmd.ExecuteNonQuery()
                    Next

                    ' Refresh the DataGridView
                    DataGridView_load()

                    MessageBox.Show("Selected items deleted permanently.")
                End If
            Else
                MessageBox.Show("Please select a row to delete permanently.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub OpenConnection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub CloseConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
End Class