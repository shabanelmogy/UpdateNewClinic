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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BtnStrp_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStrp_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStrp_VisitTypes = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStrp_PatientDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnStrp_ManagePatient = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btn_OpenManageVisits = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PatientVisitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1277, 87)
        Me.Panel2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStrp_File, Me.ToolStripMenuItem1, Me.BtnStrp_PatientDetail, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(1277, 87)
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
        Me.BtnStrp_File.Size = New System.Drawing.Size(94, 80)
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
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnStrp_VisitTypes})
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
        Me.BtnStrp_VisitTypes.Size = New System.Drawing.Size(173, 28)
        Me.BtnStrp_VisitTypes.Text = "Visits Types"
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
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(85, 83)
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
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.UpdateNewClinic.My.Resources.Resources.Health
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1277, 532)
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
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 87)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1277, 574)
        Me.XtraTabControl1.TabIndex = 7
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.PictureBox2)
        Me.XtraTabPage1.ImageOptions.Image = CType(resources.GetObject("XtraTabPage1.ImageOptions.Image"), System.Drawing.Image)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.XtraTabPage1.Size = New System.Drawing.Size(1275, 530)
        Me.XtraTabPage1.Text = "Home"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 661)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Home"
        Me.ShowIcon = False
        Me.Text = "برنامج إدارة العيادات الطبية"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
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
End Class
