Imports DocumentFormat.OpenXml.Wordprocessing
Imports System.Runtime.InteropServices.ComTypes
Imports MySql.Data.MySqlClient

Public Class categorymanagementarchive
    'Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb ; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub CategoryArchieve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_load()
    End Sub

    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            Dim cmd As New MySqlCommand("SELECT * FROM tbl_category_archive", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ' Create a new row and add it to the DataGridView'
                Dim newRow As DataGridViewRow = New DataGridViewRow()
                newRow.CreateCells(DataGridView1, dr.Item("glaccount"), dr.Item("Particulars"), dr.Item("qty"), dr.Item("reference"), dr.Item("EULIY"), dr.Item("datepurchased"), dr.Item("startdate"), dr.Item("enddate"), dr.Item("costcenter"), dr.Item("costcenterdescription"), dr.Item("acquisitiontotal"), dr.Item("totaldepreciation"), dr.Item("destination"), dr.Item("identitynotag"), dr.Item("accountableperson"), dr.Item("june"), dr.Item("july"), dr.Item("august"), dr.Item("september"), dr.Item("october"), dr.Item("november"), dr.Item("december"), dr.Item("january"), dr.Item("february"), dr.Item("march"), dr.Item("april"), dr.Item("may"))
                DataGridView1.Rows.Add(newRow)

                ' Set DateTimePicker values
                categorymanagement.dateofpurchase.Value = dr.GetDateTime("datepurchased")
                categorymanagement.startdate.Value = dr.GetDateTime("startdate")
                categorymanagement.enddate.Value = dr.GetDateTime("enddate")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub recoverbtn_Click(sender As Object, e As EventArgs) Handles btn_recover.Click
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            If con.State = ConnectionState.Open Then
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

                        ' Insert the retrieved values into tbl_category
                        Using insertCmd As New MySqlCommand("INSERT INTO tbl_category (glaccount, Particulars, qty, reference, EULIY, datepurchased, startdate, enddate, costcenter, costcenterdescription, acquisitiontotal, totaldepreciation, destination, identitynotag, accountableperson, june, july, august, september, october, november, december, january, february, march, april, may) VALUES (@glaccount, @Particulars, @qty, @reference, @EULIY, @datepurchased, @startdate, @enddate, @costcenter, @costcenterdescription, @acquisitiontotal, @totaldepreciation, @destination, @identitynotag, @accountableperson, @june, @july, @august, @september, @october, @november, @december, @january, @february, @march, @april, @may)", con)
                            ' Add parameters
                            insertCmd.Parameters.AddWithValue("@glaccount", values(0))
                            insertCmd.Parameters.AddWithValue("@Particulars", values(1))
                            insertCmd.Parameters.AddWithValue("@qty", values(2))
                            insertCmd.Parameters.AddWithValue("@reference", values(3))
                            insertCmd.Parameters.AddWithValue("@EULIY", values(4))
                            insertCmd.Parameters.AddWithValue("@datepurchased", values(5))
                            insertCmd.Parameters.AddWithValue("@startdate", values(6))
                            insertCmd.Parameters.AddWithValue("@enddate", values(7))
                            insertCmd.Parameters.AddWithValue("@costcenter", values(8))
                            insertCmd.Parameters.AddWithValue("@costcenterdescription", values(9))
                            insertCmd.Parameters.AddWithValue("@acquisitiontotal", values(10))
                            insertCmd.Parameters.AddWithValue("@totaldepreciation", values(11))
                            insertCmd.Parameters.AddWithValue("@destination", values(12))
                            insertCmd.Parameters.AddWithValue("@identitynotag", values(13))
                            insertCmd.Parameters.AddWithValue("@accountableperson", values(14))
                            insertCmd.Parameters.AddWithValue("@june", values(15))
                            insertCmd.Parameters.AddWithValue("@july", values(16))
                            insertCmd.Parameters.AddWithValue("@august", values(17))
                            insertCmd.Parameters.AddWithValue("@september", values(18))
                            insertCmd.Parameters.AddWithValue("@october", values(19))
                            insertCmd.Parameters.AddWithValue("@november", values(20))
                            insertCmd.Parameters.AddWithValue("@december", values(21))
                            insertCmd.Parameters.AddWithValue("@january", values(22))
                            insertCmd.Parameters.AddWithValue("@february", values(23))
                            insertCmd.Parameters.AddWithValue("@march", values(24))
                            insertCmd.Parameters.AddWithValue("@april", values(25))
                            insertCmd.Parameters.AddWithValue("@may", values(26))

                            ' Execute the insert command
                            Dim i As Integer = insertCmd.ExecuteNonQuery()

                            ' Check if the insert operation was successful
                            If i > 0 Then
                                ' Delete the selected row from tbl_category_archive
                                Using deleteCmd As New MySqlCommand("DELETE FROM tbl_category_archive WHERE glaccount = @glaccount", con)
                                    deleteCmd.Parameters.AddWithValue("@glaccount", values(0))
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
            Else
                MessageBox.Show("Connection is not valid or open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub





    Private Sub btn_delpermanently_Click(sender As Object, e As EventArgs) Handles btn_delpermanently.Click
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            If DataGridView1.SelectedRows.Count > 0 Then
                Dim confirmation As DialogResult = MessageBox.Show("Are you sure you want to permanently delete the selected item(s)?", "NUFV-AMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If confirmation = DialogResult.Yes Then
                    For Each selectedRow As DataGridViewRow In DataGridView1.SelectedRows
                        Dim itemNumber As String = selectedRow.Cells(0).Value.ToString()

                        ' Delete the selected row from tbl_officesupply_archive
                        Dim deleteCmd As New MySqlCommand("DELETE FROM tbl_category_archive WHERE glaccount = @glaccount", con)
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
            con.Close()
        End Try
    End Sub



End Class