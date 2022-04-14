Imports System.IO
Imports System.Globalization
Imports System.Data.SqlClient
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class Home

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        AdjustFormSize(0, 40, Me)

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim x As String
        x = Check_Key()

        If x = String.Empty Then
            MsgBox("Need Active")
            Me.Close()
            RegisterForm.Show()
        End If

        LblComputerName.Text = My.Computer.Name
        lblsystem.Text = My.Computer.Info.OSFullName

        If My.Computer.Network.IsAvailable Then
            LBLnetavailable.Text = "Connected"
            LBLnetavailable.ForeColor = Color.GreenYellow
        Else
            LBLnetavailable.Text = "Disconnected"
            LBLnetavailable.ForeColor = Color.Gray
        End If

        Timer1.Start()
    End Sub

    Public Function Check_Key() As String
        Try
            Dim checkkey As RegistryKey
            Dim Ch_Key As String
            checkkey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Sys", True)
            Ch_Key = checkkey.GetValue("System_Key")
            Return Ch_Key
        Catch ex As Exception
            Return ""
        End Try
    End Function

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

    End Sub

    Private Sub Btn_ExitApp_Click(sender As Object, e As EventArgs) Handles Btn_ExitApp.Click
        If MsgBox("هل تريد الخروج ؟", MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.YesNo, "Exit") = vbYes Then
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub Btn_Maximize_Click(sender As Object, e As EventArgs) Handles Btn_Maximize.Click

        Btn_Maximize.Visible = False
        Btn_MinimizeForm.Visible = True

        AdjustFormSize(0, 40, Me)

    End Sub

    Private Sub Btn_MinimizeForm_Click(sender As Object, e As EventArgs) Handles Btn_MinimizeForm.Click

        Btn_MinimizeForm.Visible = False
        Btn_Maximize.Visible = True

        AdjustFormSize(200, 200, Me)
    End Sub

    Private Sub Btn_FormInTaskBar_Click(sender As Object, e As EventArgs) Handles Btn_FormInTaskBar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_Date.Text = Now.Date.ToString("dddd d/MMMM/yyyy")
        lbl_Time.Text = TimeOfDay.ToString("T")
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        openFormInTab(Frm_Reservation)
    End Sub
End Class
