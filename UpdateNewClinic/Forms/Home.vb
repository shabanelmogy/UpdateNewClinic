Imports System.IO
Imports System.Globalization
Imports System.Data.SqlClient
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Public Class Home

    Dim cmd1 As New SqlCommand
    Dim Filename As String
    Dim i1, i2 As Integer

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        AdjustFormSize(0, 40, Me)
        'DataStructure()
    End Sub

    Sub Backup()
        Try
            Dim dt As DateTime = Today
            Dim destdir As String = "My_Clinic " & System.DateTime.Now.ToString("dd-MM-yyyy_h-mm-ss") & ".bak"
            Dim objdlg As New SaveFileDialog
            objdlg.FileName = destdir

            If objdlg.ShowDialog() = DialogResult.OK Then
                Filename = objdlg.FileName
                Cursor = Cursors.WaitCursor
                Timer2.Enabled = True

                con.Open()
                Dim sql As String = "Backup Database Clinic To Disk='" & Filename & "'With init,Stats=10"
                Dim cmd As New SqlCommand(sql)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()

                MsgBox("تم حفظ النسخة الاحتياطية من قاعدة البيانات", MsgBoxStyle.Information, "Backup")
                Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RestoreDatabase()
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer2.Enabled = True
                SqlConnection.ClearAllPools()
                con.Open()
                Dim sql As String = "USE Master ALTER DATABASE Clinic SET Single_User WITH Rollback Immediate 
                                     Restore Database Clinic FROM Disk='" & OpenFileDialog1.FileName & "' 
                                     WITH Replace ALTER DATABASE Clinic SET Multi_User "
                Dim cmd As New SqlCommand(sql)
                cmd.Connection = con
                cmd.ExecuteReader()
                con.Close()
                MessageBox.Show("تمت استعادة قاعدة البيانات بنجاح", "استعادة القاعدة ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cursor = Cursors.Arrow
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub AddColumn(TableName As String, ColumnName As String, DataType As String, Constraint As String, Defaultvalue As String)
        On Error Resume Next
        Dim Query As String
        Query = "Alter Table " & TableName & " Add " & ColumnName & " " & DataType & " Not Null CONSTRAINT " & Constraint & " Default " & Defaultvalue & ""
        Cmd = New SqlCommand(Query, con)
        con.Open()
        Cmd.ExecuteNonQuery()
        cmd1.ExecuteNonQuery()
        con.Close()
    End Sub

    Sub DataStructure()
        AddColumn("ClinicDays", "test", "Nvarchar(100)", "DF_Test", "''")
        AddColumn("ClinicDays", "test2", "Nvarchar(100)", "DF_Test2", "''")
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim x As String
        x = Check_Key()

        If x = String.Empty Then
            MsgBox("Need Active")
            Me.Enabled = False
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
        openFormInTab_DockNone(Frm_VisitTypes)
    End Sub

    Private Sub BtnStrp_Exit_Click(sender As Object, e As EventArgs) Handles BtnStrp_Exit.Click
        Application.Exit()
    End Sub

    Private Sub XtraTabControl1_CloseButtonClick(sender As Object, e As EventArgs) Handles XtraTabControl1.CloseButtonClick
        Dim arg As ClosePageButtonEventArgs = TryCast(e, ClosePageButtonEventArgs)
        TryCast(arg.Page, XtraTabPage).Dispose()
        XtraTabControl1.SelectedTabPage = XtraTabControl1.TabPages(XtraTabControl1.TabPages.Count - 1)
    End Sub

    Private Sub Btn_OpenManageVisits_Click(sender As Object, e As EventArgs)
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
        openFormInTab(Frm_ReportPatientDetails)
    End Sub

    Private Sub PatientVisitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientVisitsToolStripMenuItem.Click
        openFormInTab(DailyTotals)
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs)

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
        openFormInTab(Frm_Booking)
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        openFormInTab(Frm_PatientVisit)
    End Sub

    Private Sub ManageReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageReservationsToolStripMenuItem.Click
        openFormInTab(frm_ManageReservation)
    End Sub

    Private Sub BtnStrp_RestoreData_Click_1(sender As Object, e As EventArgs) Handles BtnStrp_RestoreData.Click
        RestoreDatabase()
    End Sub

    Private Sub CalculatorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalculatorToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
    End Sub

    Private Sub BtnStrp_Backup_Click_1(sender As Object, e As EventArgs) Handles BtnStrp_Backup.Click
        Backup()
    End Sub
End Class
