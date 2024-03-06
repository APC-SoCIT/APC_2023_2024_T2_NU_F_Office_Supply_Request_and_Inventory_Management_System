Imports MySql.Data.MySqlClient

Public Class requeshisotryclient


    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Private Sub requeshisotryclient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_load()
    End Sub

    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT *
                                  FROM
                                    table_requesthistory
                                    ORDER BY date", con)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()

            While dr.Read()
                Dim dateValue As Date = dr.GetDateTime("date")
                DataGridView1.Rows.Add(dr("requestID"), dr("requestorName"), dr("department"), dr("branch"), dr("purpose"), dr("total"), dateValue.ToString("yyyy-MM-dd"), dr("item1"), dr("quantity1"), dr("unitPrice1"), dr("amount1"),
                                                                                                                                          dr("item2"), dr("quantity2"), dr("unitPrice2"), dr("amount2"),
                                                                                                                                           dr("item3"), dr("quantity3"), dr("unitPrice3"), dr("amount3"),
                                                                                                                                           dr("item4"), dr("quantity4"), dr("unitPrice4"), dr("amount4"),
                                                                                                                                           dr("item5"), dr("quantity5"), dr("unitPrice5"), dr("amount5"),
                                                                                                                                           dr("item6"), dr("quantity6"), dr("unitPrice6"), dr("amount6"),
                                                                                                                                           dr("item7"), dr("quantity7"), dr("unitPrice7"), dr("amount7"),
                                                                                                                                           dr("item8"), dr("quantity8"), dr("unitPrice8"), dr("amount8"),
                                                                                                                                           dr("item9"), dr("quantity9"), dr("unitPrice9"), dr("amount9"),
                                                                                                                                           dr("item10"), dr("quantity10"), dr("unitPrice10"), dr("amount10"),
                                                                                                                                           dr("approved_date_1"), dr("rejected_date_1"), dr("approved_date_2"), dr("rejected_date_2"), dr("approved_date_3"), dr("rejected_date_3"),
                                                                                                                                           dr("status1"), dr("status2"), dr("status3"))

                ' Check if status2 is "Rejected" and change the text color to red
                If dr("status2").ToString().ToLower() = "rejected" Then
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).DefaultCellStyle.ForeColor = Color.Red
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
        End Try
        ' Hiding columns
        DataGridView1.Columns("Column5").Visible = False
        DataGridView1.Columns("Column4").Visible = False
        DataGridView1.Columns("Column8").Visible = False
        DataGridView1.Columns("Column9").Visible = False
        DataGridView1.Columns("Column10").Visible = False
        DataGridView1.Columns("Column11").Visible = False
        DataGridView1.Columns("Column12").Visible = False
        DataGridView1.Columns("Column13").Visible = False
        DataGridView1.Columns("Column14").Visible = False
        DataGridView1.Columns("Column15").Visible = False
        DataGridView1.Columns("Column16").Visible = False
        DataGridView1.Columns("Column17").Visible = False
        DataGridView1.Columns("Column18").Visible = False
        DataGridView1.Columns("Column19").Visible = False
        DataGridView1.Columns("Column20").Visible = False
        DataGridView1.Columns("Column21").Visible = False
        DataGridView1.Columns("Column22").Visible = False
        DataGridView1.Columns("Column23").Visible = False
        DataGridView1.Columns("Column24").Visible = False
        DataGridView1.Columns("Column25").Visible = False
        DataGridView1.Columns("Column26").Visible = False
        DataGridView1.Columns("Column27").Visible = False
        DataGridView1.Columns("Column28").Visible = False
        DataGridView1.Columns("Column29").Visible = False
        DataGridView1.Columns("Column30").Visible = False
        DataGridView1.Columns("Column31").Visible = False
        DataGridView1.Columns("Column32").Visible = False
        DataGridView1.Columns("Column33").Visible = False
        DataGridView1.Columns("Column34").Visible = False
        DataGridView1.Columns("Column35").Visible = False
        DataGridView1.Columns("Column36").Visible = False
        DataGridView1.Columns("Column37").Visible = False
        DataGridView1.Columns("Column38").Visible = False
        DataGridView1.Columns("Column39").Visible = False
        DataGridView1.Columns("Column40").Visible = False
        DataGridView1.Columns("Column41").Visible = False
        DataGridView1.Columns("Column42").Visible = False
        DataGridView1.Columns("Column43").Visible = False
        DataGridView1.Columns("Column44").Visible = False
        DataGridView1.Columns("Column45").Visible = False
        DataGridView1.Columns("Column46").Visible = False
        DataGridView1.Columns("Column47").Visible = False
        DataGridView1.Columns("Column48").Visible = False
        DataGridView1.Columns("Column49").Visible = False
        DataGridView1.Columns("Column50").Visible = False
        DataGridView1.Columns("Column51").Visible = False
        DataGridView1.Columns("Column52").Visible = False
        DataGridView1.Columns("Column53").Visible = False
        DataGridView1.Columns("Column54").Visible = False
        DataGridView1.Columns("Column56").Visible = False
    End Sub


    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim searchKeyword As String = txt_search.Text.Trim()

        If String.IsNullOrEmpty(searchKeyword) Then
            ' If the search text is empty, reload all data
            DataGridView_load()
        Else
            ' If the search text is not empty, filter the data
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If

                Using cmd As New MySqlCommand("SELECT * FROM table_requesthistory WHERE AND (requestID LIKE @search OR requestorName LIKE @search OR total LIKE @search OR status2 LIKE @search)", con)
                    cmd.Parameters.AddWithValue("@search", "%" & searchKeyword & "%")
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        DataGridView1.Rows.Clear()

                        While dr.Read()
                            Dim dateValue As Date = dr.GetDateTime("date")
                            DataGridView1.Rows.Add(dr("requestID"), dr("requestorName"), dr("department"), dr("branch"), dr("purpose"), dr("total"), dateValue.ToString("yyyy-MM-dd"), dr("item1"), dr("quantity1"), dr("unitPrice1"), dr("amount1"),
                                                                                                                                          dr("item2"), dr("quantity2"), dr("unitPrice2"), dr("amount2"),
                                                                                                                                           dr("item3"), dr("quantity3"), dr("unitPrice3"), dr("amount3"),
                                                                                                                                           dr("item4"), dr("quantity4"), dr("unitPrice4"), dr("amount4"),
                                                                                                                                           dr("item5"), dr("quantity5"), dr("unitPrice5"), dr("amount5"),
                                                                                                                                           dr("item6"), dr("quantity6"), dr("unitPrice6"), dr("amount6"),
                                                                                                                                           dr("item7"), dr("quantity7"), dr("unitPrice7"), dr("amount7"),
                                                                                                                                           dr("item8"), dr("quantity8"), dr("unitPrice8"), dr("amount8"),
                                                                                                                                           dr("item9"), dr("quantity9"), dr("unitPrice9"), dr("amount9"),
                                                                                                                                           dr("item10"), dr("quantity10"), dr("unitPrice10"), dr("amount10"),
                                                                                                                                           dr("approved_date_1"), dr("rejected_date_1"), dr("approved_date_2"), dr("rejected_date_2"), dr("approved_date_3"), dr("rejected_date_3"),
                                                                                                                                           dr("status1"), dr("status1"), dr("status1"))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        ' Check if the cell belongs to the "status2" column and if the value is "Rejected"
        If e.ColumnIndex = DataGridView1.Columns(54).Index AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString().ToLower() = "rejected" Then
            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        End If
    End Sub

    Public purchaseOrderForm As Purchase_Order ' Instance of the Purchase_Order form
    Public termsAndCondForm As Term_and_Cond ' Instance of the Terms_and_Cond form
    Public currentPage As Integer = 1 ' Track the current page number



    Public Sub printPO_Click(sender As Object, e As EventArgs) Handles printPO.Click

        Try
            ' Check if a row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Fetch the requestor's name from the first column of the DataGridView
                Dim requestorName As String = DataGridView1.Rows(selectedRow.Index).Cells(1).Value.ToString()
                Dim requestordepartment As String = DataGridView1.Rows(selectedRow.Index).Cells(2).Value.ToString()

                ' Open or create an instance of the Purchase_Order form
                Dim purchaseOrderForm As New Purchase_Order()

                ' Pass the selected row to the Purchase_Order form
                purchaseOrderForm.PopulateDataGridView(selectedRow)

                ' Set the requestor's name in the Purchase_Order form


                purchaseOrderForm.txtbxname.Text = requestorName
                purchaseOrderForm.txtbxdept.Text = requestordepartment

                ' Show the Purchase_Order form
                purchaseOrderForm.Show()

                ' Allow the user to choose a file destination
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*"
                saveFileDialog.FilterIndex = 1
                saveFileDialog.RestoreDirectory = True

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Dim filePath As String = saveFileDialog.FileName
                    SaveFormsAsImages(purchaseOrderForm, filePath)
                End If
            Else
                MessageBox.Show("Please select a row to print.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while printing: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveFormsAsImages(purchaseOrderForm As Purchase_Order, filePath As String)
        Try
            ' Ensure purchaseOrderForm is not Nothing
            If purchaseOrderForm IsNot Nothing Then
                ' Create a bitmap of the form's display area
                Dim bitmapPurchaseOrder As New Bitmap(purchaseOrderForm.Width, purchaseOrderForm.Height)

                ' Draw the form onto the bitmap
                purchaseOrderForm.DrawToBitmap(bitmapPurchaseOrder, New Rectangle(0, 0, purchaseOrderForm.Width, purchaseOrderForm.Height))

                ' Save the bitmap as an image file to the specified destination
                bitmapPurchaseOrder.Save(filePath, Imaging.ImageFormat.Png)

                ' Dispose the bitmap
                bitmapPurchaseOrder.Dispose()

                MessageBox.Show("Purchase Order form saved as an image successfully.")
                purchaseOrderForm.Close()
            Else
                MessageBox.Show("The Purchase Order form is not initialized.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the Purchase Order form as an image: " & ex.Message)
        End Try
    End Sub
End Class