<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
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
        Me.Btn_FormInTaskBar = New System.Windows.Forms.Button()
        Me.Btn_ExitApp = New System.Windows.Forms.Button()
        Me.Btn_MinimizeForm = New System.Windows.Forms.Button()
        Me.Btn_Maximize = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LBLnetavailable = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblsystem = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblComputerName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Date = New System.Windows.Forms.Label()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.Pnl_Home.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Home
        '
        Me.Pnl_Home.Controls.Add(Me.MenuStrip1)
        Me.Pnl_Home.Controls.Add(Me.Panel1)
        Me.Pnl_Home.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Home.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Home.Name = "Pnl_Home"
        Me.Pnl_Home.Size = New System.Drawing.Size(1277, 99)
        Me.Pnl_Home.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStrp_File, Me.ToolStripMenuItem1, Me.BtnStrp_PatientDetail, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 36)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1277, 69)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BtnStrp_File
        '
        Me.BtnStrp_File.AutoSize = False
        Me.BtnStrp_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStrp_Exit})
        Me.BtnStrp_File.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStrp_File.Image = Global.UpdateNewClinic.My.Resources.Resources.File_32
        Me.BtnStrp_File.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnStrp_File.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnStrp_File.Name = "BtnStrp_File"
        Me.BtnStrp_File.Size = New System.Drawing.Size(85, 64)
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
        Me.ToolStripMenuItem1.Image = Global.UpdateNewClinic.My.Resources.Resources.Visits_32
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(85, 64)
        Me.ToolStripMenuItem1.Text = "Visits"
        Me.ToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.BtnStrp_PatientDetail.Image = Global.UpdateNewClinic.My.Resources.Resources.Patient_32
        Me.BtnStrp_PatientDetail.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnStrp_PatientDetail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnStrp_PatientDetail.Name = "BtnStrp_PatientDetail"
        Me.BtnStrp_PatientDetail.Size = New System.Drawing.Size(85, 64)
        Me.BtnStrp_PatientDetail.Text = "Patients"
        Me.BtnStrp_PatientDetail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnStrp_PatientDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.ReportsToolStripMenuItem.Image = Global.UpdateNewClinic.My.Resources.Resources.Report_32
        Me.ReportsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ReportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(85, 65)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        Me.ReportsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ReportsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btn_FormInTaskBar)
        Me.Panel1.Controls.Add(Me.Btn_ExitApp)
        Me.Panel1.Controls.Add(Me.Btn_MinimizeForm)
        Me.Panel1.Controls.Add(Me.Btn_Maximize)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1277, 36)
        Me.Panel1.TabIndex = 1
        '
        'Btn_FormInTaskBar
        '
        Me.Btn_FormInTaskBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_FormInTaskBar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_FormInTaskBar.FlatAppearance.BorderSize = 0
        Me.Btn_FormInTaskBar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_FormInTaskBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_FormInTaskBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_FormInTaskBar.ForeColor = System.Drawing.Color.White
        Me.Btn_FormInTaskBar.Image = Global.UpdateNewClinic.My.Resources.Resources.Icono_Minimizar
        Me.Btn_FormInTaskBar.Location = New System.Drawing.Point(1162, 0)
        Me.Btn_FormInTaskBar.Name = "Btn_FormInTaskBar"
        Me.Btn_FormInTaskBar.Size = New System.Drawing.Size(40, 36)
        Me.Btn_FormInTaskBar.TabIndex = 9
        Me.Btn_FormInTaskBar.Text = ""
        Me.Btn_FormInTaskBar.UseVisualStyleBackColor = True
        '
        'Btn_ExitApp
        '
        Me.Btn_ExitApp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_ExitApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ExitApp.FlatAppearance.BorderSize = 0
        Me.Btn_ExitApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.Btn_ExitApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
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
        'Btn_MinimizeForm
        '
        Me.Btn_MinimizeForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_MinimizeForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_MinimizeForm.FlatAppearance.BorderSize = 0
        Me.Btn_MinimizeForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_MinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_MinimizeForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_MinimizeForm.ForeColor = System.Drawing.Color.White
        Me.Btn_MinimizeForm.Image = Global.UpdateNewClinic.My.Resources.Resources.Icono_Restaurar
        Me.Btn_MinimizeForm.Location = New System.Drawing.Point(1200, 0)
        Me.Btn_MinimizeForm.Name = "Btn_MinimizeForm"
        Me.Btn_MinimizeForm.Size = New System.Drawing.Size(40, 36)
        Me.Btn_MinimizeForm.TabIndex = 8
        Me.Btn_MinimizeForm.Text = ""
        Me.Btn_MinimizeForm.UseVisualStyleBackColor = True
        '
        'Btn_Maximize
        '
        Me.Btn_Maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Maximize.FlatAppearance.BorderSize = 0
        Me.Btn_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
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
        Me.PictureBox2.Size = New System.Drawing.Size(1275, 518)
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 99)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1277, 562)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel5)
        Me.XtraTabPage1.Controls.Add(Me.PictureBox2)
        Me.XtraTabPage1.ImageOptions.Image = CType(resources.GetObject("XtraTabPage1.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage1.Size = New System.Drawing.Size(1275, 518)
        Me.XtraTabPage1.Text = "Home"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.lbl_Time)
        Me.Panel5.Controls.Add(Me.lbl_Date)
        Me.Panel5.Controls.Add(Me.LBLnetavailable)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.lblsystem)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.LblComputerName)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 483)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1275, 35)
        Me.Panel5.TabIndex = 196
        '
        'LBLnetavailable
        '
        Me.LBLnetavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLnetavailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LBLnetavailable.Location = New System.Drawing.Point(851, 4)
        Me.LBLnetavailable.Name = "LBLnetavailable"
        Me.LBLnetavailable.Size = New System.Drawing.Size(116, 27)
        Me.LBLnetavailable.TabIndex = 25
        Me.LBLnetavailable.Text = "نظام التشغيل :"
        Me.LBLnetavailable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(633, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(213, 26)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Network connection status :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblsystem
        '
        Me.lblsystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsystem.Location = New System.Drawing.Point(404, 5)
        Me.lblsystem.Name = "lblsystem"
        Me.lblsystem.Size = New System.Drawing.Size(213, 26)
        Me.lblsystem.TabIndex = 23
        Me.lblsystem.Text = "نظام التشغيل :"
        Me.lblsystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(356, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 27)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "O.S :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblComputerName
        '
        Me.LblComputerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComputerName.ForeColor = System.Drawing.Color.Yellow
        Me.LblComputerName.Location = New System.Drawing.Point(138, 5)
        Me.LblComputerName.Name = "LblComputerName"
        Me.LblComputerName.Size = New System.Drawing.Size(213, 26)
        Me.LblComputerName.TabIndex = 21
        Me.LblComputerName.Text = "اسم الجهاز :"
        Me.LblComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 26)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Computer Name :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'lbl_Date
        '
        Me.lbl_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Date.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.ForeColor = System.Drawing.Color.White
        Me.lbl_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Date.Location = New System.Drawing.Point(878, 2)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(249, 33)
        Me.lbl_Date.TabIndex = 26
        Me.lbl_Date.Text = "التاريخ"
        Me.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Time
        '
        Me.lbl_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Time.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Time.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.ForeColor = System.Drawing.Color.White
        Me.lbl_Time.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_Time.Location = New System.Drawing.Point(1108, 2)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(164, 33)
        Me.lbl_Time.TabIndex = 27
        Me.lbl_Time.Text = "الوقت"
        Me.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 661)
        Me.ControlBox = False
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Pnl_Home)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Home"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "برنامج إدارة العيادات الطبية"
        Me.Pnl_Home.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
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
    Friend WithEvents Btn_MinimizeForm As Button
    Friend WithEvents Btn_FormInTaskBar As Button
    Friend WithEvents Panel5 As Panel
    Private WithEvents LBLnetavailable As Label
    Private WithEvents Label9 As Label
    Private WithEvents lblsystem As Label
    Private WithEvents Label19 As Label
    Private WithEvents LblComputerName As Label
    Private WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_Date As Label
    Friend WithEvents lbl_Time As Label
End Class
