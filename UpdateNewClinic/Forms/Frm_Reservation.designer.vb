<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Reservation
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_PatientName = New System.Windows.Forms.TextBox()
        Me.Dtp_ReserveDate = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_SortAsec = New System.Windows.Forms.Button()
        Me.Btn_SortDesc = New System.Windows.Forms.Button()
        Me.Cbo_SortAndSearch = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbo_ReserveType = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_SearchValue = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_VisitCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Num = New System.Windows.Forms.TextBox()
        Me.Dgv_Visits = New System.Windows.Forms.DataGridView()
        Me.PatientNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.Btn_SaveNewPatient = New System.Windows.Forms.Button()
        Me.Btn_DeletePatient = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_SelectAll = New System.Windows.Forms.Button()
        Me.Btn_NewPatient = New System.Windows.Forms.Button()
        Me.Dgv_Search = New System.Windows.Forms.DataGridView()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.ClinicDataSet = New UpdateNewClinic.ClinicDataSet()
        Me.PatientsDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PatientsDetailTableAdapter = New UpdateNewClinic.ClinicDataSetTableAdapters.PatientsDetailTableAdapter()
        Me.Panel1.SuspendLayout()
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
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(7, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 27)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Reserve Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_PatientName
        '
        Me.Txt_PatientName.BackColor = System.Drawing.Color.White
        Me.Txt_PatientName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_PatientName.Location = New System.Drawing.Point(116, 9)
        Me.Txt_PatientName.Name = "Txt_PatientName"
        Me.Txt_PatientName.ReadOnly = True
        Me.Txt_PatientName.Size = New System.Drawing.Size(409, 27)
        Me.Txt_PatientName.TabIndex = 4
        Me.Txt_PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Dtp_ReserveDate
        '
        Me.Dtp_ReserveDate.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_ReserveDate.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Dtp_ReserveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_ReserveDate.Location = New System.Drawing.Point(116, 65)
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
        Me.Btn_SortAsec.Location = New System.Drawing.Point(307, 8)
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
        Me.Btn_SortDesc.Location = New System.Drawing.Point(378, 8)
        Me.Btn_SortDesc.Name = "Btn_SortDesc"
        Me.Btn_SortDesc.Size = New System.Drawing.Size(57, 27)
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
        Me.Cbo_SortAndSearch.Size = New System.Drawing.Size(212, 27)
        Me.Cbo_SortAndSearch.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(9, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 27)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Sort / Search By"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(249, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 27)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Visit Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbo_ReserveType
        '
        Me.Cbo_ReserveType.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Cbo_ReserveType.FormattingEnabled = True
        Me.Cbo_ReserveType.Location = New System.Drawing.Point(334, 65)
        Me.Cbo_ReserveType.Name = "Cbo_ReserveType"
        Me.Cbo_ReserveType.Size = New System.Drawing.Size(152, 27)
        Me.Cbo_ReserveType.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(9, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 27)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Search Value"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_SearchValue
        '
        Me.Txt_SearchValue.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_SearchValue.Location = New System.Drawing.Point(122, 66)
        Me.Txt_SearchValue.Name = "Txt_SearchValue"
        Me.Txt_SearchValue.Size = New System.Drawing.Size(212, 27)
        Me.Txt_SearchValue.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Txt_VisitCost)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Txt_Num)
        Me.Panel1.Controls.Add(Me.Dgv_Visits)
        Me.Panel1.Controls.Add(Me.SeparatorControl2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Cbo_ReserveType)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Btn_SaveNewPatient)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Dtp_ReserveDate)
        Me.Panel1.Controls.Add(Me.Btn_DeletePatient)
        Me.Panel1.Controls.Add(Me.Txt_PatientName)
        Me.Panel1.Location = New System.Drawing.Point(495, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(851, 683)
        Me.Panel1.TabIndex = 38
        '
        'Txt_VisitCost
        '
        Me.Txt_VisitCost.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_VisitCost.Location = New System.Drawing.Point(585, 65)
        Me.Txt_VisitCost.Name = "Txt_VisitCost"
        Me.Txt_VisitCost.Size = New System.Drawing.Size(63, 27)
        Me.Txt_VisitCost.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(498, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 27)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Visit Cost"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Dgv_Visits.AllowUserToAddRows = False
        Me.Dgv_Visits.AllowUserToDeleteRows = False
        Me.Dgv_Visits.AllowUserToResizeRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        Me.Dgv_Visits.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.Dgv_Visits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Visits.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Visits.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Visits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.Dgv_Visits.ColumnHeadersHeight = 30
        Me.Dgv_Visits.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientNum, Me.PatientName, Me.ReserveDate, Me.VisitType, Me.VisitCost})
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Visits.DefaultCellStyle = DataGridViewCellStyle21
        Me.Dgv_Visits.Location = New System.Drawing.Point(11, 128)
        Me.Dgv_Visits.Name = "Dgv_Visits"
        Me.Dgv_Visits.ReadOnly = True
        Me.Dgv_Visits.RowHeadersVisible = False
        Me.Dgv_Visits.RowTemplate.Height = 25
        Me.Dgv_Visits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Visits.Size = New System.Drawing.Size(829, 548)
        Me.Dgv_Visits.TabIndex = 39
        '
        'PatientNum
        '
        Me.PatientNum.HeaderText = "Patient Num"
        Me.PatientNum.Name = "PatientNum"
        Me.PatientNum.ReadOnly = True
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "Patient Name"
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        '
        'ReserveDate
        '
        Me.ReserveDate.HeaderText = "Reserve Date"
        Me.ReserveDate.Name = "ReserveDate"
        Me.ReserveDate.ReadOnly = True
        '
        'VisitType
        '
        Me.VisitType.HeaderText = "Visit Type"
        Me.VisitType.Name = "VisitType"
        Me.VisitType.ReadOnly = True
        '
        'VisitCost
        '
        Me.VisitCost.HeaderText = "Visit Cost"
        Me.VisitCost.Name = "VisitCost"
        Me.VisitCost.ReadOnly = True
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl2.LineColor = System.Drawing.Color.Maroon
        Me.SeparatorControl2.Location = New System.Drawing.Point(3, 99)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(837, 23)
        Me.SeparatorControl2.TabIndex = 39
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
        Me.Btn_SaveNewPatient.Location = New System.Drawing.Point(539, 5)
        Me.Btn_SaveNewPatient.Name = "Btn_SaveNewPatient"
        Me.Btn_SaveNewPatient.Size = New System.Drawing.Size(46, 36)
        Me.Btn_SaveNewPatient.TabIndex = 13
        Me.Btn_SaveNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_SaveNewPatient.UseVisualStyleBackColor = False
        '
        'Btn_DeletePatient
        '
        Me.Btn_DeletePatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_DeletePatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_DeletePatient.FlatAppearance.BorderSize = 0
        Me.Btn_DeletePatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_DeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_DeletePatient.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_DeletePatient.ForeColor = System.Drawing.Color.White
        Me.Btn_DeletePatient.Image = Global.UpdateNewClinic.My.Resources.Resources.Delete_24x24
        Me.Btn_DeletePatient.Location = New System.Drawing.Point(601, 5)
        Me.Btn_DeletePatient.Name = "Btn_DeletePatient"
        Me.Btn_DeletePatient.Size = New System.Drawing.Size(47, 36)
        Me.Btn_DeletePatient.TabIndex = 15
        Me.Btn_DeletePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_DeletePatient.UseVisualStyleBackColor = False
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
        Me.Panel2.Size = New System.Drawing.Size(489, 683)
        Me.Panel2.TabIndex = 39
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
        Me.Btn_SelectAll.Location = New System.Drawing.Point(375, 66)
        Me.Btn_SelectAll.Name = "Btn_SelectAll"
        Me.Btn_SelectAll.Size = New System.Drawing.Size(60, 27)
        Me.Btn_SelectAll.TabIndex = 42
        Me.Btn_SelectAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.Btn_NewPatient.Location = New System.Drawing.Point(307, 66)
        Me.Btn_NewPatient.Name = "Btn_NewPatient"
        Me.Btn_NewPatient.Size = New System.Drawing.Size(60, 27)
        Me.Btn_NewPatient.TabIndex = 40
        Me.Btn_NewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_NewPatient.UseVisualStyleBackColor = False
        '
        'Dgv_Search
        '
        Me.Dgv_Search.AllowUserToAddRows = False
        Me.Dgv_Search.AllowUserToDeleteRows = False
        Me.Dgv_Search.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black
        Me.Dgv_Search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.Dgv_Search.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_Search.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Search.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.Dgv_Search.ColumnHeadersHeight = 30
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Search.DefaultCellStyle = DataGridViewCellStyle24
        Me.Dgv_Search.Location = New System.Drawing.Point(3, 128)
        Me.Dgv_Search.Name = "Dgv_Search"
        Me.Dgv_Search.ReadOnly = True
        Me.Dgv_Search.RowHeadersVisible = False
        Me.Dgv_Search.RowTemplate.Height = 25
        Me.Dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Search.Size = New System.Drawing.Size(475, 548)
        Me.Dgv_Search.TabIndex = 39
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.LineColor = System.Drawing.Color.Maroon
        Me.SeparatorControl1.Location = New System.Drawing.Point(-2, 99)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(489, 23)
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
        'Frm_Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1349, 685)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "Frm_Reservation"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "New Reserve"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Btn_DeletePatient As Button
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
    Friend WithEvents Label1 As Label
    Friend WithEvents PatientNum As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents ReserveDate As DataGridViewTextBoxColumn
    Friend WithEvents VisitType As DataGridViewTextBoxColumn
    Friend WithEvents VisitCost As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Num As TextBox
End Class
