Public Class Purchase_Order

    Public Sub PopulateDataGridView(selectedRow As DataGridViewRow)
        ' Clear existing data in DataGridView2
        DataGridView2.Rows.Clear()

        ' Loop through columns 7 to 46 (inclusive) which contains item and quantity information
        For i As Integer = 7 To 46 Step 4
            Dim itemName As String = selectedRow.Cells(i).Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(selectedRow.Cells(i + 1).Value)
            Dim unitPrice As Decimal = Convert.ToDecimal(selectedRow.Cells(i + 2).Value)
            Dim amount As Decimal = Convert.ToDecimal(selectedRow.Cells(i + 3).Value)

            ' Add data to DataGridView2 only if amount is not 0.00 and itemName is not empty
            If amount <> 0 AndAlso Not String.IsNullOrEmpty(itemName) Then
                DataGridView2.Rows.Add(itemName, quantity, unitPrice, amount)
            End If
        Next

        ' Calculate total amount and display it in TextBox
        Dim totalAmount As Decimal = 0
        For Each row As DataGridViewRow In DataGridView2.Rows
            totalAmount += Convert.ToDecimal(row.Cells(3).Value)
        Next
        amount.Text = totalAmount.ToString()
    End Sub

    Private Sub Purchase_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class