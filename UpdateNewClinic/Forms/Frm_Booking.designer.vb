<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Booking
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_PatientName = New System.Windows.Forms.TextBox()
        Me.Dtp_ReserveDate = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_SortAsec = New System.Windows.Forms.Button()
        Me.Btn_SortDesc = New System.Windows.Forms.Button()
        Me.Cbo_SortAndSearch = New System.Windows.Forms.ComboBox()
        Me.Txt_SearchValue = New System.Windows.Forms.TextBox()
        Me.Btn_ShowAll = New System.Windows.Forms.Button()
        Me.Btn_ShowToday = New System.Windows.Forms.Button()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        Me.Btn_SaveNewPatient = New System.Windows.Forms.Button()
        Me.Btn_SelectAll = New System.Windows.Forms.Button()
        Me.Btn_NewPatient = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Cbo_ReserveType = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Dtp_Search = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Grp_Buttons = New System.Windows.Forms.GroupBox()
        Me.Txt_VisitCost = New System.Windows.Forms.TextBox()
        Me.Txt_Num = New System.Windows.Forms.TextBox()
        Me.Dgv_Visits = New System.Windows.Forms.DataGridView()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dgv_Search = New System.Windows.Forms.DataGridView()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.ClinicDataSet = New UpdateNewClinic.ClinicDataSet()
        Me.PatientsDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsDetailTableAdapter = New UpdateNewClinic.ClinicDataSetTableAdapters.PatientsDetailTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PatientNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Grp_Buttons.SuspendLayout()
        CType(Me.Dgv_Visits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Dgv_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientsDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PatientName"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(7, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 27)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Booking Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_PatientName
        '
        Me.Txt_PatientName.BackColor = System.Drawing.Color.White
        Me.Txt_PatientName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_PatientName.Location = New System.Drawing.Point(112, 9)
        Me.Txt_PatientName.Name = "Txt_PatientName"
        Me.Txt_PatientName.ReadOnly = True
        Me.Txt_PatientName.Size = New System.Drawing.Size(373, 27)
        Me.Txt_PatientName.TabIndex = 4
        Me.Txt_PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Dtp_ReserveDate
        '
        Me.Dtp_ReserveDate.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_ReserveDate.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Dtp_ReserveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_ReserveDate.Location = New System.Drawing.Point(115, 68)
        Me.Dtp_ReserveDate.Name = "Dtp_ReserveDate"
        Me.Dtp_ReserveDate.Size = New System.Drawing.Size(122, 27)
        Me.Dtp_ReserveDate.TabIndex = 12
        Me.Dtp_ReserveDate.Value = New Date(2022, 4, 4, 0, 0, 0, 0)
        '
        'Btn_SortAsec
        '
        Me.Btn_SortAsec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_SortAsec.BackColor = System.Drawing.Color.White
        Me.Btn_SortAsec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SortAsec.FlatAppearance.BorderSize = 0
        Me.Btn_SortAsec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell
        Me.Btn_SortAsec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SortAsec.Image = Global.UpdateNewClinic.My.Resources.Resources.SortAscending_24
        Me.Btn_SortAsec.Location = New System.Drawing.Point(216, 8)
        Me.Btn_SortAsec.Name = "Btn_SortAsec"
        Me.Btn_SortAsec.Size = New System.Drawing.Size(60, 27)
        Me.Btn_SortAsec.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.Btn_SortAsec, "Sort Asc")
        Me.Btn_SortAsec.UseVisualStyleBackColor = False
        '
        'Btn_SortDesc
        '
        Me.Btn_SortDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_SortDesc.BackColor = System.Drawing.Color.White
        Me.Btn_SortDesc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SortDesc.FlatAppearance.BorderSize = 0
        Me.Btn_SortDesc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell
        Me.Btn_SortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SortDesc.Image = Global.UpdateNewClinic.My.Resources.Resources.SortDesc_24
        Me.Btn_SortDesc.Location = New System.Drawing.Point(288, 8)
        Me.Btn_SortDesc.Name = "Btn_SortDesc"
        Me.Btn_SortDesc.Size = New System.Drawing.Size(60, 27)
        Me.Btn_SortDesc.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.Btn_SortDesc, "Sort Desc")
        Me.Btn_SortDesc.UseVisualStyleBackColor = False
        '
        'Cbo_SortAndSearch
        '
        Me.Cbo_SortAndSearch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Cbo_SortAndSearch.FormattingEnabled = True
        Me.Cbo_SortAndSearch.Items.AddRange(New Object() {"PatientName", "Phone"})
        Me.Cbo_SortAndSearch.Location = New System.Drawing.Point(122, 8)
        Me.Cbo_SortAndSearch.Name = "Cbo_SortAndSearch"
        Me.Cbo_SortAndSearch.Size = New System.Drawing.Size(175, 27)
        Me.Cbo_SortAndSearch.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.Cbo_SortAndSearch, "Select Search Item")
        '
        'Txt_SearchValue
        '
        Me.Txt_SearchValue.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_SearchValue.Location = New System.Drawing.Point(122, 66)
        Me.Txt_SearchValue.Name = "Txt_SearchValue"
        Me.Txt_SearchValue.Size = New System.Drawing.Size(175, 27)
        Me.Txt_SearchValue.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.Txt_SearchValue, "Select Search Item And Then Enter Search Value")
        '
        'Btn_ShowAll
        '
        Me.Btn_ShowAll.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_ShowAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ShowAll.FlatAppearance.BorderSize = 0
        Me.Btn_ShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_ShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ShowAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ShowAll.ForeColor = System.Drawing.Color.White
        Me.Btn_ShowAll.Location = New System.Drawing.Point(6, 59)
        Me.Btn_ShowAll.Name = "Btn_ShowAll"
        Me.Btn_ShowAll.Size = New System.Drawing.Size(163, 31)
        Me.Btn_ShowAll.TabIndex = 15
        Me.Btn_ShowAll.Text = "Show All"
        Me.Btn_ShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Btn_ShowAll, "Show All Bookings")
        Me.Btn_ShowAll.UseVisualStyleBackColor = False
        '
        'Btn_ShowToday
        '
        Me.Btn_ShowToday.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_ShowToday.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ShowToday.FlatAppearance.BorderSize = 0
        Me.Btn_ShowToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_ShowToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ShowToday.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ShowToday.ForeColor = System.Drawing.Color.White
        Me.Btn_ShowToday.Location = New System.Drawing.Point(6, 18)
        Me.Btn_ShowToday.Name = "Btn_ShowToday"
        Me.Btn_ShowToday.Size = New System.Drawing.Size(163, 31)
        Me.Btn_ShowToday.TabIndex = 14
        Me.Btn_ShowToday.Text = "Show Today"
        Me.Btn_ShowToday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Btn_ShowToday, "Show Today Bookings")
        Me.Btn_ShowToday.UseVisualStyleBackColor = False
        '
        'Btn_Reset
        '
        Me.Btn_Reset.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Reset.FlatAppearance.BorderSize = 0
        Me.Btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Reset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Reset.ForeColor = System.Drawing.Color.White
        Me.Btn_Reset.Image = Global.UpdateNewClinic.My.Resources.Resources.Undo_24
        Me.Btn_Reset.Location = New System.Drawing.Point(13, 60)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(84, 30)
        Me.Btn_Reset.TabIndex = 14
        Me.Btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Btn_Reset, "Reset All Selections")
        Me.Btn_Reset.UseVisualStyleBackColor = False
        '
        'Btn_SaveNewPatient
        '
        Me.Btn_SaveNewPatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_SaveNewPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SaveNewPatient.FlatAppearance.BorderSize = 0
        Me.Btn_SaveNewPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_SaveNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_SaveNewPatient.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SaveNewPatient.ForeColor = System.Drawing.Color.White
        Me.Btn_SaveNewPatient.Image = Global.UpdateNewClinic.My.Resources.Resources.Save
        Me.Btn_SaveNewPatient.Location = New System.Drawing.Point(13, 18)
        Me.Btn_SaveNewPatient.Name = "Btn_SaveNewPatient"
        Me.Btn_SaveNewPatient.Size = New System.Drawing.Size(84, 30)
        Me.Btn_SaveNewPatient.TabIndex = 13
        Me.Btn_SaveNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Btn_SaveNewPatient, "Save And Edit")
        Me.Btn_SaveNewPatient.UseVisualStyleBackColor = False
        '
        'Btn_SelectAll
        '
        Me.Btn_SelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_SelectAll.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_SelectAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SelectAll.FlatAppearance.BorderSize = 0
        Me.Btn_SelectAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_SelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_SelectAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SelectAll.ForeColor = System.Drawing.Color.White
        Me.Btn_SelectAll.Image = Global.UpdateNewClinic.My.Resources.Resources.Refresh1
        Me.Btn_SelectAll.Location = New System.Drawing.Point(288, 66)
        Me.Btn_SelectAll.Name = "Btn_SelectAll"
        Me.Btn_SelectAll.Size = New System.Drawing.Size(60, 27)
        Me.Btn_SelectAll.TabIndex = 42
        Me.Btn_SelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Btn_SelectAll, "Show All Patients")
        Me.Btn_SelectAll.UseVisualStyleBackColor = False
        '
        'Btn_NewPatient
        '
        Me.Btn_NewPatient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_NewPatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_NewPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_NewPatient.FlatAppearance.BorderSize = 0
        Me.Btn_NewPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_NewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_NewPatient.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_NewPatient.ForeColor = System.Drawing.Color.White
        Me.Btn_NewPatient.Image = Global.UpdateNewClinic.My.Resources.Resources._New
        Me.Btn_NewPatient.Location = New System.Drawing.Point(216, 66)
        Me.Btn_NewPatient.Name = "Btn_NewPatient"
        Me.Btn_NewPatient.Size = New System.Drawing.Size(60, 27)
        Me.Btn_NewPatient.TabIndex = 40
        Me.Btn_NewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Btn_NewPatient, "Add New Patient")
        Me.Btn_NewPatient.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.FlatAppearance.BorderSize = 0
        Me.Btn_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Search.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Search.ForeColor = System.Drawing.Color.White
        Me.Btn_Search.Image = Global.UpdateNewClinic.My.Resources.Resources.Search_16
        Me.Btn_Search.Location = New System.Drawing.Point(10, 59)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(114, 31)
        Me.Btn_Search.TabIndex = 15
        Me.Btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.Btn_Search, "Search By Date")
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Cbo_ReserveType
        '
        Me.Cbo_ReserveType.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Cbo_ReserveType.FormattingEnabled = True
        Me.Cbo_ReserveType.Location = New System.Drawing.Point(330, 68)
        Me.Cbo_ReserveType.Name = "Cbo_ReserveType"
        Me.Cbo_ReserveType.Size = New System.Drawing.Size(155, 27)
        Me.Cbo_ReserveType.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.Cbo_ReserveType, "Select Visit Type")
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(3, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 27)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Sort / Search By"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(249, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 27)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Visit Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(3, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 27)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Search Value"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Grp_Buttons)
        Me.Panel1.Controls.Add(Me.Txt_VisitCost)
        Me.Panel1.Controls.Add(Me.Txt_Num)
        Me.Panel1.Controls.Add(Me.Dgv_Visits)
        Me.Panel1.Controls.Add(Me.SeparatorControl2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Cbo_ReserveType)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Dtp_ReserveDate)
        Me.Panel1.Controls.Add(Me.Txt_PatientName)
        Me.Panel1.Location = New System.Drawing.Point(378, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 683)
        Me.Panel1.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Dtp_Search)
        Me.GroupBox1.Controls.Add(Me.Btn_Search)
        Me.GroupBox1.Location = New System.Drawing.Point(800, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 97)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'Dtp_Search
        '
        Me.Dtp_Search.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Dtp_Search.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Search.Location = New System.Drawing.Point(10, 18)
        Me.Dtp_Search.Name = "Dtp_Search"
        Me.Dtp_Search.Size = New System.Drawing.Size(114, 25)
        Me.Dtp_Search.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_ShowAll)
        Me.GroupBox2.Controls.Add(Me.Btn_ShowToday)
        Me.GroupBox2.Location = New System.Drawing.Point(613, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 97)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        '
        'Grp_Buttons
        '
        Me.Grp_Buttons.Controls.Add(Me.Btn_Reset)
        Me.Grp_Buttons.Controls.Add(Me.Btn_SaveNewPatient)
        Me.Grp_Buttons.Location = New System.Drawing.Point(492, -2)
        Me.Grp_Buttons.Name = "Grp_Buttons"
        Me.Grp_Buttons.Size = New System.Drawing.Size(107, 97)
        Me.Grp_Buttons.TabIndex = 44
        Me.Grp_Buttons.TabStop = False
        '
        'Txt_VisitCost
        '
        Me.Txt_VisitCost.BackColor = System.Drawing.Color.White
        Me.Txt_VisitCost.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_VisitCost.Location = New System.Drawing.Point(113, 40)
        Me.Txt_VisitCost.Name = "Txt_VisitCost"
        Me.Txt_VisitCost.ReadOnly = True
        Me.Txt_VisitCost.Size = New System.Drawing.Size(63, 24)
        Me.Txt_VisitCost.TabIndex = 43
        Me.Txt_VisitCost.Visible = False
        '
        'Txt_Num
        '
        Me.Txt_Num.Location = New System.Drawing.Point(7, 42)
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Num.TabIndex = 41
        Me.Txt_Num.Visible = False
        '
        'Dgv_Visits
        '
        Me.Dgv_Visits.AllowUserToDeleteRows = False
        Me.Dgv_Visits.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Dgv_Visits.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Visits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Visits.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Visits.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Visits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Visits.ColumnHeadersHeight = 30
        Me.Dgv_Visits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientNum, Me.PatientName, Me.ReserveDate, Me.VisitType, Me.VisitCost, Me.Status1, Me.Delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Visits.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Visits.Location = New System.Drawing.Point(7, 126)
        Me.Dgv_Visits.Name = "Dgv_Visits"
        Me.Dgv_Visits.RowHeadersVisible = False
        Me.Dgv_Visits.RowTemplate.Height = 25
        Me.Dgv_Visits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Visits.Size = New System.Drawing.Size(953, 551)
        Me.Dgv_Visits.TabIndex = 39
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl2.LineColor = System.Drawing.Color.Maroon
        Me.SeparatorControl2.Location = New System.Drawing.Point(-1, 99)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(967, 23)
        Me.SeparatorControl2.TabIndex = 39
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Btn_SelectAll)
        Me.Panel2.Controls.Add(Me.Btn_NewPatient)
        Me.Panel2.Controls.Add(Me.Dgv_Search)
        Me.Panel2.Controls.Add(Me.SeparatorControl1)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Btn_SortAsec)
        Me.Panel2.Controls.Add(Me.Txt_SearchValue)
        Me.Panel2.Controls.Add(Me.Btn_SortDesc)
        Me.Panel2.Controls.Add(Me.Cbo_SortAndSearch)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(372, 683)
        Me.Panel2.TabIndex = 39
        '
        'Dgv_Search
        '
        Me.Dgv_Search.AllowUserToAddRows = False
        Me.Dgv_Search.AllowUserToDeleteRows = False
        Me.Dgv_Search.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Dgv_Search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_Search.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Search.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Search.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv_Search.ColumnHeadersHeight = 30
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Search.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv_Search.Location = New System.Drawing.Point(3, 126)
        Me.Dgv_Search.Name = "Dgv_Search"
        Me.Dgv_Search.ReadOnly = True
        Me.Dgv_Search.RowHeadersVisible = False
        Me.Dgv_Search.RowTemplate.Height = 25
        Me.Dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Search.Size = New System.Drawing.Size(362, 551)
        Me.Dgv_Search.TabIndex = 39
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.LineColor = System.Drawing.Color.Maroon
        Me.SeparatorControl1.Location = New System.Drawing.Point(-2, 99)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(372, 23)
        Me.SeparatorControl1.TabIndex = 38
        '
        'ClinicDataSet
        '
        Me.ClinicDataSet.DataSetName = "ClinicDataSet"
        Me.ClinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientsDetailBindingSource
        '
        Me.PatientsDetailBindingSource.DataMember = "PatientsDetail"
        Me.PatientsDetailBindingSource.DataSource = Me.ClinicDataSet
        '
        'PatientsDetailTableAdapter
        '
        Me.PatientsDetailTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'PatientNum
        '
        Me.PatientNum.HeaderText = "Patient ID"
        Me.PatientNum.Name = "PatientNum"
        Me.PatientNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'ReserveDate
        '
        Me.ReserveDate.HeaderText = "Booking Date"
        Me.ReserveDate.Name = "ReserveDate"
        Me.ReserveDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'VisitType
        '
        Me.VisitType.HeaderText = "Visit Type"
        Me.VisitType.Name = "VisitType"
        Me.VisitType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'VisitCost
        '
        Me.VisitCost.HeaderText = "Visit Cost"
        Me.VisitCost.Name = "VisitCost"
        Me.VisitCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Status1
        '
        Me.Status1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Status1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Status1.HeaderText = "Status"
        Me.Status1.Name = "Status1"
        Me.Status1.Sorted = True
        Me.Status1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Status1.Width = 120
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete "
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Delete "
        Me.Delete.UseColumnTextForButtonValue = True
        Me.Delete.Width = 109
        '
        'Frm_Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1349, 685)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "Frm_Booking"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "New Reserve"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Grp_Buttons.ResumeLayout(False)
        CType(Me.Dgv_Visits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Dgv_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientsDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_PatientName As TextBox
    Friend WithEvents Dtp_ReserveDate As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Cbo_SortAndSearch As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbo_ReserveType As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Txt_SearchValue As TextBox
    Friend WithEvents Btn_SaveNewPatient As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dgv_Visits As DataGridView
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents Dgv_Search As DataGridView
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents ClinicDataSet As ClinicDataSet
    Friend WithEvents PatientsDetailBindingSource As BindingSource
    Friend WithEvents PatientsDetailTableAdapter As ClinicDataSetTableAdapters.PatientsDetailTableAdapter
    Friend WithEvents Btn_NewPatient As Button
    Friend WithEvents Btn_SelectAll As Button
    Friend WithEvents Btn_SortAsec As Button
    Friend WithEvents Btn_SortDesc As Button
    Friend WithEvents Txt_VisitCost As TextBox
    Friend WithEvents Txt_Num As TextBox
    Friend WithEvents Grp_Buttons As GroupBox
    Friend WithEvents Btn_Reset As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_ShowToday As Button
    Friend WithEvents Btn_ShowAll As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Dtp_Search As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PatientNum As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents ReserveDate As DataGridViewTextBoxColumn
    Friend WithEvents VisitType As DataGridViewTextBoxColumn
    Friend WithEvents VisitCost As DataGridViewTextBoxColumn
    Friend WithEvents Status1 As DataGridViewComboBoxColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
