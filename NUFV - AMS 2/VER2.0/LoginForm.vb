Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Diagnostics.Eventing

Public Class LoginForm





    Private Sub btn1_Submit_Click(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles btn1_Submit.Click
        ConnDB()
        Try
            'Sql Query to fetch the username and password
            sqllogin = "select * from accountcredentials where username = '" & textboxusername.Text & "' and passwd = '" & textboxpassword.Text & "'"

            'sql fetch command
            cmdlogin = New MySqlCommand(sqllogin, connlogin)
            Dim drlogin As MySqlDataReader = cmdlogin.ExecuteReader
            drlogin.Read()
            If textboxpassword.Text = "" Or textboxusername.Text = "" Then
                MsgBox("Please Fill up empty Fields!", MsgBoxStyle.Information, "Notification")
                Exit Sub
            End If

            If drlogin.HasRows = True Then
                Dim usertype As String = drlogin("usertype").ToString

                If usertype = "Admin" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    admindashboardclient.Show()
                    admindashboardclient.Loadtotalpending()
                    admindashboardclient.LoadtotalRequest()
                    admindashboardclient.budgetforaccounting()
                    admindashboardclient.budgetforitso()
                    admindashboardclient.budgetforadmission()
                    admindashboardclient.budgetforlrc()

                    Me.Hide()

                ElseIf usertype = "Faculty" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    dashboardfaculty.Show()
                    dashboardfaculty.Loadtotalpending()
                    dashboardfaculty.LoadtotalRequest()
                    Me.Hide()

                ElseIf usertype = "LRC" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    userdashboardlrc.Show()
                    userdashboardlrc.Loadtotalpending()
                    userdashboardlrc.LoadtotalRequest()
                    Me.Hide()

                ElseIf usertype = "Accounting" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    userdashboardaccounting.Show()
                    userdashboardaccounting.Loadtotalpending()
                    userdashboardaccounting.LoadtotalRequest()
                    Me.Hide()

                ElseIf usertype = "Admission" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    userdashboardadmission.Show()
                    userdashboardadmission.Loadtotalpending()
                    userdashboardadmission.LoadtotalRequest()
                    Me.Hide()

                ElseIf usertype = "ITSO" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    userdashboardITSO.Show()
                    userdashboardITSO.Loadtotalpending()
                    userdashboardITSO.LoadtotalRequest()
                    Me.Hide()


                ElseIf usertype = "SuperAdmin" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    SuperAdminDashboard.Show()
                    Me.Hide()

                ElseIf usertype = "Approver_LRC" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    LRC_Approver_dashboard.Show()
                    LRC_Approver_dashboard.Loadtotalpending()
                    LRC_Approver_dashboard.LoadtotalRequest()
                    Me.Hide()

                ElseIf usertype = "Approver_Accounting" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    Accounting_Approver_dashboard.Show()
                    Accounting_Approver_dashboard.Loadtotalpending()
                    Accounting_Approver_dashboard.LoadtotalRequest()
                    Me.Hide()

                ElseIf usertype = "Approver_Admission" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    Admission_Approver_dashboard.Show()
                    Admission_Approver_dashboard.LoadtotalRequest()
                    Admission_Approver_dashboard.Loadtotalpending()
                    Me.Hide()


                ElseIf usertype = "Approver_Faculty" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    Faculty_Approver_dashboard.Show()
                    Me.Hide()


                ElseIf usertype = "Approver_ITSO" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    ITSO_Approver_dashboard.Show()
                    Me.Hide()

                ElseIf usertype = "HeadApproval1" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    Approver_Dashboard_Sirjed.Show()
                    Approver_Dashboard_Sirjed.Loadtotalpending()
                    Approver_Dashboard_Sirjed.LoadtotalRequest()
                    Me.Hide()


                ElseIf usertype = "Approvalrelease_Accounting" Then
                    MsgBox("Login Successfully!", MsgBoxStyle.Information, "Notification")
                    textboxpassword.Clear()
                    textboxusername.Clear()
                    Dashboard_AccountingRelease.Show()
                    ApproverRelease_RequestTracker.DataGridView_load()
                    Me.Hide()



                End If
            Else
                MsgBox("LOGIN FAILED, Incorrect Username or Password", MsgBoxStyle.Critical, "Notification")

                textboxpassword.Clear()
                textboxusername.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub



    Private Sub Button2_Click_3(sender As Object, e As EventArgs) Handles Button2.Click
        HeadApproval1_RequestTrackerr.Show()
        Me.Hide()

    End Sub


    Private Sub textboxusername_TextChanged(sender As Object, e As EventArgs) Handles textboxusername.TextChanged

    End Sub
End Class