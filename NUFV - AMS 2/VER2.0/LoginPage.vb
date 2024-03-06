
Imports MySql.Data.MySqlClient
Public Class FormLoginPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConnDB()
        Try
            sqllogin = "select * from accountdetails where username = '" & TextBox1.Text * "' and passwd = '" & TextBox2.Text & "'"
            cmdlogin = New MySqlCommand(sqllogin, connlogin)
            Dim dr As MySqlDataReader = cmdlogin.ExecuteReader
            dr.Read()
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                Exit Sub

            End If

            If dr.HasRows = True Then
                Dim usertype As String = dr("accounttype").ToString
                If usertype = "admin" Or "Admin" Then
                    MsgBox("welcome administrator", MsgBoxStyle.Information)

                ElseIf usertype = "user" Or "User" Then
                    MsgBox("welcome user", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Welcome")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub FormLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
