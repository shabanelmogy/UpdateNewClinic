Imports System.IO
Imports System.Globalization
Imports System.Data.SqlClient
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Public Class Home

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
End Class
