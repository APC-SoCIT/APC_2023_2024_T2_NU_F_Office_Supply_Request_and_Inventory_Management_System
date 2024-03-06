Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class officesupplyviewer
    'Connection to the database'
    Dim str As String = "server=localhost; uid=root; pwd=; database=nufvdb ; convert zero datetime=True"
    Dim con As New MySqlConnection(str)
    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_load()
    End Sub

    'Data Viewing'
    Public Sub DataGridView_load()
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_officesupply WHERE ItemStock > ReorderPoint", con)
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
            con.Close()
        End Try

        DataGridView1.Columns("Column1").Visible = False
        DataGridView1.Columns("Column5").Visible = False
        DataGridView1.Columns("Column8").Visible = False
    End Sub

    'Dropdown button control'

    Public Sub New()
        InitializeComponent()

        dropdownpanel2.Visible = False
        dropdownpanel3.Visible = False
        dropdownpanel4.Visible = False

    End Sub

    Private Sub termrepbtn_Click(sender As Object, e As EventArgs) Handles termrepbtn.Click
        showdd(dropdownpanel2)
    End Sub

    Private Sub monthrepbtn_Click(sender As Object, e As EventArgs) Handles monthrepbtn.Click
        showdd(dropdownpanel3)
    End Sub

    Private Sub annualrepbtn_Click(sender As Object, e As EventArgs) Handles annualrepbtn.Click
        showdd(dropdownpanel4)
    End Sub

    Private Sub hidebutton()
        dropdownpanel2.Visible = False
        dropdownpanel3.Visible = False
        dropdownpanel4.Visible = False
        ' Hide other content as needed
    End Sub

    Private Sub showdd(subbutton As Panel)
        If subbutton.Visible = False Then
            hidebutton()
            subbutton.Visible = True
        Else
            subbutton.Visible = False
        End If
    End Sub

    Private Sub toggleVisibility()
        dropdownpanel2.Visible = Not dropdownpanel2.Visible
        dropdownpanel3.Visible = Not dropdownpanel3.Visible
        dropdownpanel4.Visible = Not dropdownpanel4.Visible
        ' Toggle visibility of other content as needed
    End Sub

    'To serach an item within the database'
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()

        Try
            con.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM tbl_officesupply WHERE ItemNumber LIKE @SearchText OR ItemName LIKE @SearchText", con)
            cmd.Parameters.AddWithValue("@SearchText", "%" & txt_search.Text & "%")

            dr = cmd.ExecuteReader
            While dr.Read
                ' Format the DatePurchase value to display only the date part without the time'
                Dim datePurchaseFormatted As String = If(dr.IsDBNull(dr.GetOrdinal("DatePurchase")), "", CDate(dr.Item("DatePurchase")).ToString("yyyy-MM-dd"))

                DataGridView1.Rows.Add(dr.Item("ItemNumber"), dr.Item("ItemName"), dr.Item("ItemStock"), dr.Item("ItemUnit"), dr.Item("ItemStatus"), datePurchaseFormatted, dr.Item("ItemAmount"), dr.Item("ReorderPoint"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.SaveAs("C:\Downloads\TermOSReport.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MessageBox.Show("You can find the file at C:\Downloads\")
    End Sub

    Private Sub excelrepbtn_Click(sender As Object, e As EventArgs) Handles excelrepbtn.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.SaveAs("C:\Downloads\MonthlyOSReport.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MessageBox.Show("You can find the file at C:\Downloads\")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        For i = 0 To DataGridView1.RowCount - 2
            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.SaveAs("C:\foldexcel\YearlyOSReport.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MessageBox.Show("You can find the file at C:\foldexcel\")
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GenerateReport("Term")
    End Sub


    Private Sub GenerateReport(reportType As String)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
        saveFileDialog.FilterIndex = 1
        saveFileDialog.RestoreDirectory = True

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim pdfFilePath As String = saveFileDialog.FileName

            ' Get date range based on report type
            Dim startDate As Date
            Dim endDate As Date = Date.Now ' Default to current date

            Select Case reportType
                Case "Monthly"
                    startDate = Date.Now.AddMonths(-1).Date ' Start of last month
                Case "Yearly"
                    startDate = New Date(Date.Now.Year, 1, 1) ' Start of current year
                Case "Term"
                    ' Define your custom term start and end dates here
                    startDate = New Date(2024, 1, 1) ' Example start date for term
                    endDate = New Date(2024, 3, 31) ' Example end date for term
            End Select

            ' Get the current date as the "Date Created"
            Dim dateCreated As Date = Date.Now

            ' Create a new PDF document
            Dim doc As New Document()
            Dim fs As New FileStream(pdfFilePath, FileMode.Create)
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, fs)
            doc.Open()

            ' Add "Date Created" to the document
            Dim dateCreatedParagraph As New Paragraph($"Date Created: {dateCreated.ToString("MMMM dd, yyyy")}")
            dateCreatedParagraph.Alignment = Element.ALIGN_RIGHT
            doc.Add(dateCreatedParagraph)

            ' Add title to the document
            Dim titleFont As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 24, iTextSharp.text.Font.BOLD)
            Dim title As New Paragraph($"{reportType} Office Supplies Report", titleFont)
            title.Alignment = Element.ALIGN_CENTER
            doc.Add(title)

            ' Add date range to the document
            Dim dateRange As New Paragraph($"Date Range: {startDate.ToString("MMMM dd, yyyy")} - {endDate.ToString("MMMM dd, yyyy")}")
            dateRange.Alignment = Element.ALIGN_CENTER
            doc.Add(dateRange)

            ' Add some space between title and date range
            doc.Add(New Paragraph(" "))

            ' Add a table to the document
            Dim table As New PdfPTable(DataGridView1.ColumnCount)
            table.WidthPercentage = 100

            ' Add column headers
            For Each column As DataGridViewColumn In DataGridView1.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.BackgroundColor = New BaseColor(240, 240, 240)
                table.AddCell(cell)
            Next

            ' Add data rows
            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    table.AddCell(cell.Value.ToString())
                Next
            Next

            ' Add the table to the document
            doc.Add(table)

            ' Close the document
            doc.Close()
            fs.Close()

            MessageBox.Show("PDF report generated successfully!")
        End If
    End Sub
End Class