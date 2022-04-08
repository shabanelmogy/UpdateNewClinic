Imports System.IO
Imports System.Globalization
Imports System.Data.SqlClient
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports System.Runtime.InteropServices

Public Class Home

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnStrp_ManagePatient_Click(sender As Object, e As EventArgs) Handles BtnStrp_ManagePatient.Click
        openFormInTab(Frm_EditPatients)
    End Sub

    Private Sub BtnStrp_VisitTypes_Click(sender As Object, e As EventArgs) Handles BtnStrp_VisitTypes.Click
        Dim frm As New Frm_VisitTypes
        frm.TopLevel = False
        For Each tab As XtraTabPage In XtraTabControl1.TabPages
            If tab.Name = frm.Name Then
                Exit Sub
            End If
        Next
        XtraTabControl1.TabPages.Add(New XtraTabPage With {.Text = frm.Text, .Name = frm.Name})
        For Each tab As XtraTabPage In XtraTabControl1.TabPages
            If tab.Name = frm.Name Then
                tab.ImageOptions.Image = frm.Icon.ToBitmap
                tab.Controls.Add(frm)
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frm.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
                'frm.Dock = DockStyle.Fill
                XtraTabControl1.SelectedTabPage = tab
                frm.Show()
            End If
        Next
    End Sub

    Private Sub BtnStrp_Exit_Click(sender As Object, e As EventArgs) Handles BtnStrp_Exit.Click
        Application.Exit()
    End Sub

    Private Sub XtraTabControl1_CloseButtonClick(sender As Object, e As EventArgs) Handles XtraTabControl1.CloseButtonClick
        Dim arg As ClosePageButtonEventArgs = TryCast(e, ClosePageButtonEventArgs)
        TryCast(arg.Page, XtraTabPage).Dispose()
        XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(XtraTabControl1.TabPages.Count - 1)
    End Sub

    Private Sub Btn_OpenManageVisits_Click(sender As Object, e As EventArgs) Handles Btn_OpenManageVisits.Click
        Dim frm As New Frm_PatientVisit
        frm.TopLevel = False
        XtraTabControl1.TabPages.Add(New XtraTabPage With {.Text = frm.Text, .Name = frm.Name})

        For Each tab As XtraTabPage In XtraTabControl1.TabPages
            If tab.Name = frm.Name Then
                tab.ImageOptions.Image = frm.Icon.ToBitmap
                tab.Controls.Add(frm)
                frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                frm.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
                frm.Dock = DockStyle.Fill
                XtraTabControl1.SelectedTabPage = tab
            End If
        Next
        frm.Show()
    End Sub

    Private Sub PatientDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientDataToolStripMenuItem.Click
        openFormInTab(Btn_ShowReport)
    End Sub

    Private Sub PatientVisitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientVisitsToolStripMenuItem.Click
        openFormInTab(DailyTotals)
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        openFormInTab(Frm_Reservation)
    End Sub

    Private Sub Btn_ExitApp_Click(sender As Object, e As EventArgs) Handles Btn_ExitApp.Click
        If MsgBox("هل تريد الخروج ؟", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "Exit") = vbYes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub Btn_Maximize_Click(sender As Object, e As EventArgs) Handles Btn_Maximize.Click
        Btn_Maximize.Visible = False
        Btn_RestoreForm.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Btn_RestoreForm_Click(sender As Object, e As EventArgs) Handles Btn_RestoreForm.Click
        Me.WindowState = FormWindowState.Normal

        Btn_RestoreForm.Visible = False
        Btn_Maximize.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
