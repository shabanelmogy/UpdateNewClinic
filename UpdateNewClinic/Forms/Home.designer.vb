﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Pnl_Home = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BtnStrp_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStrp_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStrp_VisitTypes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStrp_PatientDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStrp_ManagePatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_OpenManageVisits = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientVisitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.Btn_ExitApp = New System.Windows.Forms.Button()
        Me.Btn_RestoreForm = New System.Windows.Forms.Button()
        Me.Btn_Maximize = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Pnl_Home.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Home
        '
        Me.Pnl_Home.Controls.Add(Me.MenuStrip1)
        Me.Pnl_Home.Controls.Add(Me.Panel1)
        Me.Pnl_Home.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Home.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Home.Name = "Pnl_Home"
        Me.Pnl_Home.Size = New System.Drawing.Size(1277, 127)
        Me.Pnl_Home.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStrp_File, Me.ToolStripMenuItem1, Me.BtnStrp_PatientDetail, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(7, 39)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(415, 84)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BtnStrp_File
        '
        Me.BtnStrp_File.AutoSize = False
        Me.BtnStrp_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStrp_Exit})
        Me.BtnStrp_File.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStrp_File.Image = Global.UpdateNewClinic.My.Resources.Resources.File
        Me.BtnStrp_File.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnStrp_File.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnStrp_File.Name = "BtnStrp_File"
        Me.BtnStrp_File.Size = New System.Drawing.Size(122, 80)
        Me.BtnStrp_File.Text = "File"
        Me.BtnStrp_File.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnStrp_File.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BtnStrp_Exit
        '
        Me.BtnStrp_Exit.Name = "BtnStrp_Exit"
        Me.BtnStrp_Exit.Size = New System.Drawing.Size(110, 28)
        Me.BtnStrp_Exit.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.AutoSize = False
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStrp_VisitTypes, Me.ReservationToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = Global.UpdateNewClinic.My.Resources.Resources.Visit
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(100, 80)
        Me.ToolStripMenuItem1.Text = "Visits"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'BtnStrp_VisitTypes
        '
        Me.BtnStrp_VisitTypes.Name = "BtnStrp_VisitTypes"
        Me.BtnStrp_VisitTypes.Size = New System.Drawing.Size(175, 28)
        Me.BtnStrp_VisitTypes.Text = "Visits Types"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(175, 28)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'BtnStrp_PatientDetail
        '
        Me.BtnStrp_PatientDetail.AutoSize = False
        Me.BtnStrp_PatientDetail.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStrp_ManagePatient, Me.Btn_OpenManageVisits})
        Me.BtnStrp_PatientDetail.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStrp_PatientDetail.Image = Global.UpdateNewClinic.My.Resources.Resources.Patient
        Me.BtnStrp_PatientDetail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnStrp_PatientDetail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnStrp_PatientDetail.Name = "BtnStrp_PatientDetail"
        Me.BtnStrp_PatientDetail.Size = New System.Drawing.Size(100, 80)
        Me.BtnStrp_PatientDetail.Text = "Patients"
        Me.BtnStrp_PatientDetail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnStrp_PatientDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'BtnStrp_ManagePatient
        '
        Me.BtnStrp_ManagePatient.Name = "BtnStrp_ManagePatient"
        Me.BtnStrp_ManagePatient.Size = New System.Drawing.Size(213, 28)
        Me.BtnStrp_ManagePatient.Text = "Manage Patients"
        '
        'Btn_OpenManageVisits
        '
        Me.Btn_OpenManageVisits.Name = "Btn_OpenManageVisits"
        Me.Btn_OpenManageVisits.Size = New System.Drawing.Size(213, 28)
        Me.Btn_OpenManageVisits.Text = "Manage Visits"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientDataToolStripMenuItem, Me.PatientVisitsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Image = Global.UpdateNewClinic.My.Resources.Resources.Reporting
        Me.ReportsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(85, 80)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        Me.ReportsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ReportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'PatientDataToolStripMenuItem
        '
        Me.PatientDataToolStripMenuItem.Name = "PatientDataToolStripMenuItem"
        Me.PatientDataToolStripMenuItem.Size = New System.Drawing.Size(240, 28)
        Me.PatientDataToolStripMenuItem.Text = "Daily Visits Detailed"
        '
        'PatientVisitsToolStripMenuItem
        '
        Me.PatientVisitsToolStripMenuItem.Name = "PatientVisitsToolStripMenuItem"
        Me.PatientVisitsToolStripMenuItem.Size = New System.Drawing.Size(240, 28)
        Me.PatientVisitsToolStripMenuItem.Text = "Daily Visits Totals"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.btnMinimizar)
        Me.Panel1.Controls.Add(Me.Btn_ExitApp)
        Me.Panel1.Controls.Add(Me.Btn_RestoreForm)
        Me.Panel1.Controls.Add(Me.Btn_Maximize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1277, 36)
        Me.Panel1.TabIndex = 1
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Image = Global.UpdateNewClinic.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1162, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 36)
        Me.btnMinimizar.TabIndex = 9
        Me.btnMinimizar.Text = ""
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'Btn_ExitApp
        '
        Me.Btn_ExitApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_ExitApp.FlatAppearance.BorderSize = 0
        Me.Btn_ExitApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_ExitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Btn_ExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ExitApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ExitApp.ForeColor = System.Drawing.Color.White
        Me.Btn_ExitApp.Image = CType(resources.GetObject("Btn_ExitApp.Image"), System.Drawing.Image)
        Me.Btn_ExitApp.Location = New System.Drawing.Point(1236, 0)
        Me.Btn_ExitApp.Name = "Btn_ExitApp"
        Me.Btn_ExitApp.Size = New System.Drawing.Size(40, 36)
        Me.Btn_ExitApp.TabIndex = 5
        Me.Btn_ExitApp.UseVisualStyleBackColor = True
        '
        'Btn_RestoreForm
        '
        Me.Btn_RestoreForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_RestoreForm.FlatAppearance.BorderSize = 0
        Me.Btn_RestoreForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_RestoreForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_RestoreForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_RestoreForm.ForeColor = System.Drawing.Color.White
        Me.Btn_RestoreForm.Image = Global.UpdateNewClinic.My.Resources.Resources.Icono_Restaurar
        Me.Btn_RestoreForm.Location = New System.Drawing.Point(1200, -2)
        Me.Btn_RestoreForm.Name = "Btn_RestoreForm"
        Me.Btn_RestoreForm.Size = New System.Drawing.Size(40, 40)
        Me.Btn_RestoreForm.TabIndex = 8
        Me.Btn_RestoreForm.Text = ""
        Me.Btn_RestoreForm.UseVisualStyleBackColor = True
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximize.FlatAppearance.BorderSize = 0
        Me.Btn_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Maximize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Maximize.ForeColor = System.Drawing.Color.White
        Me.Btn_Maximize.Image = Global.UpdateNewClinic.My.Resources.Resources.Icono_Maximizar
        Me.Btn_Maximize.Location = New System.Drawing.Point(1200, 0)
        Me.Btn_Maximize.Name = "Btn_Maximize"
        Me.Btn_Maximize.Size = New System.Drawing.Size(40, 36)
        Me.Btn_Maximize.TabIndex = 6
        Me.Btn_Maximize.UseVisualStyleBackColor = True
        Me.Btn_Maximize.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UpdateNewClinic.My.Resources.Resources.Health
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1284, 557)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.UpdateNewClinic.My.Resources.Resources.Health
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1275, 490)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AllowDrop = True
        Me.XtraTabControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.XtraTabControl1.Appearance.Options.UseBackColor = True
        Me.XtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 127)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1277, 534)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PictureBox2)
        Me.XtraTabPage1.ImageOptions.Image = CType(resources.GetObject("XtraTabPage1.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage1.Size = New System.Drawing.Size(1275, 490)
        Me.XtraTabPage1.Text = "Home"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 661)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Pnl_Home)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Home"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "برنامج إدارة العيادات الطبية"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Pnl_Home.ResumeLayout(False)
        Me.Pnl_Home.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl_Home As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BtnStrp_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnStrp_PatientDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnStrp_ManagePatient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BtnStrp_VisitTypes As ToolStripMenuItem
    Friend WithEvents BtnStrp_Exit As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Btn_OpenManageVisits As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PatientVisitsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_ExitApp As Button
    Friend WithEvents Btn_Maximize As Button
    Friend WithEvents Btn_RestoreForm As Button
    Friend WithEvents btnMinimizar As Button
End Class
