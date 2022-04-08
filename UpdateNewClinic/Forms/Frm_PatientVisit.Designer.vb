<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_PatientVisit
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Dgv_VisitDetail = New System.Windows.Forms.DataGridView()
        Me.VisitDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewWaist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanOfTreatment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EatingHabits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_PatientName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_PatientNum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Phone1 = New System.Windows.Forms.TextBox()
        Me.Lbl_Phone1 = New System.Windows.Forms.Label()
        Me.Txt_StartWeight = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Height = New System.Windows.Forms.TextBox()
        Me.Txt_FirstVisit = New System.Windows.Forms.TextBox()
        Me.Lbl_FirstVisit = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Occupation = New System.Windows.Forms.TextBox()
        Me.Txt_Age = New System.Windows.Forms.TextBox()
        Me.Txt_Code = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Cbo_VisitType = New System.Windows.Forms.ComboBox()
        Me.Pnl_VisitDetails = New System.Windows.Forms.Panel()
        Me.Dtp_VisitDate = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Notes = New System.Windows.Forms.TextBox()
        Me.Txt_EatingHabits = New System.Windows.Forms.TextBox()
        Me.Txt_PlanOfTreatment = New System.Windows.Forms.TextBox()
        Me.Txt_NewWeight = New System.Windows.Forms.TextBox()
        Me.Txt_VisitCost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_NewWaist = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Pnl_PatientDetail = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BtnStrip_Save = New System.Windows.Forms.ToolStripButton()
        Me.BtnStrp_Delete = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.Dgv_VisitDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_VisitDetails.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Pnl_PatientDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Dgv_VisitDetail)
        Me.Panel1.Location = New System.Drawing.Point(2, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1322, 364)
        Me.Panel1.TabIndex = 33
        '
        'Dgv_VisitDetail
        '
        Me.Dgv_VisitDetail.AllowUserToAddRows = False
        Me.Dgv_VisitDetail.AllowUserToDeleteRows = False
        Me.Dgv_VisitDetail.AllowUserToResizeColumns = False
        Me.Dgv_VisitDetail.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.AliceBlue
        Me.Dgv_VisitDetail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.Dgv_VisitDetail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_VisitDetail.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Dgv_VisitDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_VisitDetail.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.Dgv_VisitDetail.ColumnHeadersHeight = 30
        Me.Dgv_VisitDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_VisitDetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VisitDate, Me.VisitType, Me.VisitCost, Me.NewWeight, Me.NewWaist, Me.PlanOfTreatment, Me.EatingHabits, Me.Notes})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.NullValue = Nothing
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_VisitDetail.DefaultCellStyle = DataGridViewCellStyle18
        Me.Dgv_VisitDetail.EnableHeadersVisualStyles = False
        Me.Dgv_VisitDetail.GridColor = System.Drawing.Color.Gainsboro
        Me.Dgv_VisitDetail.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_VisitDetail.Name = "Dgv_VisitDetail"
        Me.Dgv_VisitDetail.RowHeadersVisible = False
        Me.Dgv_VisitDetail.RowTemplate.Height = 30
        Me.Dgv_VisitDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_VisitDetail.Size = New System.Drawing.Size(1322, 360)
        Me.Dgv_VisitDetail.TabIndex = 0
        '
        'VisitDate
        '
        Me.VisitDate.DataPropertyName = "VisitDate"
        Me.VisitDate.HeaderText = "VisitDate"
        Me.VisitDate.Name = "VisitDate"
        '
        'VisitType
        '
        Me.VisitType.DataPropertyName = "VisitType"
        Me.VisitType.HeaderText = "Visit Type"
        Me.VisitType.Name = "VisitType"
        '
        'VisitCost
        '
        Me.VisitCost.DataPropertyName = "VisitCost"
        Me.VisitCost.HeaderText = "Visit Cost"
        Me.VisitCost.Name = "VisitCost"
        '
        'NewWeight
        '
        Me.NewWeight.DataPropertyName = "NewWeight"
        Me.NewWeight.HeaderText = "New Weight"
        Me.NewWeight.Name = "NewWeight"
        '
        'NewWaist
        '
        Me.NewWaist.DataPropertyName = "NewWaist"
        Me.NewWaist.HeaderText = "New Waist"
        Me.NewWaist.Name = "NewWaist"
        '
        'PlanOfTreatment
        '
        Me.PlanOfTreatment.DataPropertyName = "PlanOfTreatment"
        Me.PlanOfTreatment.HeaderText = "Plan Of Treatment"
        Me.PlanOfTreatment.Name = "PlanOfTreatment"
        '
        'EatingHabits
        '
        Me.EatingHabits.DataPropertyName = "EatingHabits"
        Me.EatingHabits.HeaderText = "Eating Habits"
        Me.EatingHabits.Name = "EatingHabits"
        '
        'Notes
        '
        Me.Notes.DataPropertyName = "Notes"
        Me.Notes.HeaderText = "Notes"
        Me.Notes.Name = "Notes"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(320, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 24)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Age"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_PatientName
        '
        Me.Txt_PatientName.BackColor = System.Drawing.Color.White
        Me.Txt_PatientName.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_PatientName.Location = New System.Drawing.Point(106, 53)
        Me.Txt_PatientName.Name = "Txt_PatientName"
        Me.Txt_PatientName.ReadOnly = True
        Me.Txt_PatientName.Size = New System.Drawing.Size(507, 24)
        Me.Txt_PatientName.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Occupation"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_PatientNum
        '
        Me.Txt_PatientNum.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_PatientNum.Location = New System.Drawing.Point(107, 8)
        Me.Txt_PatientNum.Name = "Txt_PatientNum"
        Me.Txt_PatientNum.Size = New System.Drawing.Size(64, 24)
        Me.Txt_PatientNum.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 24)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "PatientNum"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Phone1
        '
        Me.Txt_Phone1.BackColor = System.Drawing.Color.White
        Me.Txt_Phone1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_Phone1.Location = New System.Drawing.Point(417, 142)
        Me.Txt_Phone1.Name = "Txt_Phone1"
        Me.Txt_Phone1.ReadOnly = True
        Me.Txt_Phone1.Size = New System.Drawing.Size(196, 24)
        Me.Txt_Phone1.TabIndex = 42
        '
        'Lbl_Phone1
        '
        Me.Lbl_Phone1.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Phone1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Phone1.ForeColor = System.Drawing.Color.White
        Me.Lbl_Phone1.Location = New System.Drawing.Point(320, 142)
        Me.Lbl_Phone1.Name = "Lbl_Phone1"
        Me.Lbl_Phone1.Size = New System.Drawing.Size(97, 24)
        Me.Lbl_Phone1.TabIndex = 41
        Me.Lbl_Phone1.Text = "Phone"
        Me.Lbl_Phone1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_StartWeight
        '
        Me.Txt_StartWeight.BackColor = System.Drawing.Color.White
        Me.Txt_StartWeight.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_StartWeight.Location = New System.Drawing.Point(417, 187)
        Me.Txt_StartWeight.Name = "Txt_StartWeight"
        Me.Txt_StartWeight.ReadOnly = True
        Me.Txt_StartWeight.Size = New System.Drawing.Size(196, 24)
        Me.Txt_StartWeight.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(320, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 24)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "StartWeight"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Height
        '
        Me.Txt_Height.BackColor = System.Drawing.Color.White
        Me.Txt_Height.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_Height.Location = New System.Drawing.Point(107, 188)
        Me.Txt_Height.Name = "Txt_Height"
        Me.Txt_Height.ReadOnly = True
        Me.Txt_Height.Size = New System.Drawing.Size(196, 24)
        Me.Txt_Height.TabIndex = 38
        '
        'Txt_FirstVisit
        '
        Me.Txt_FirstVisit.AcceptsTab = True
        Me.Txt_FirstVisit.BackColor = System.Drawing.Color.White
        Me.Txt_FirstVisit.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_FirstVisit.Location = New System.Drawing.Point(417, 7)
        Me.Txt_FirstVisit.Name = "Txt_FirstVisit"
        Me.Txt_FirstVisit.ReadOnly = True
        Me.Txt_FirstVisit.Size = New System.Drawing.Size(196, 24)
        Me.Txt_FirstVisit.TabIndex = 37
        '
        'Lbl_FirstVisit
        '
        Me.Lbl_FirstVisit.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_FirstVisit.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_FirstVisit.ForeColor = System.Drawing.Color.White
        Me.Lbl_FirstVisit.Location = New System.Drawing.Point(320, 7)
        Me.Lbl_FirstVisit.Name = "Lbl_FirstVisit"
        Me.Lbl_FirstVisit.Size = New System.Drawing.Size(97, 24)
        Me.Lbl_FirstVisit.TabIndex = 36
        Me.Lbl_FirstVisit.Text = "FirstVisit"
        Me.Lbl_FirstVisit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(10, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 24)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Height"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Occupation
        '
        Me.Txt_Occupation.BackColor = System.Drawing.Color.White
        Me.Txt_Occupation.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_Occupation.Location = New System.Drawing.Point(107, 143)
        Me.Txt_Occupation.Name = "Txt_Occupation"
        Me.Txt_Occupation.ReadOnly = True
        Me.Txt_Occupation.Size = New System.Drawing.Size(197, 24)
        Me.Txt_Occupation.TabIndex = 34
        '
        'Txt_Age
        '
        Me.Txt_Age.BackColor = System.Drawing.Color.White
        Me.Txt_Age.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_Age.Location = New System.Drawing.Point(417, 97)
        Me.Txt_Age.Name = "Txt_Age"
        Me.Txt_Age.ReadOnly = True
        Me.Txt_Age.Size = New System.Drawing.Size(196, 24)
        Me.Txt_Age.TabIndex = 33
        '
        'Txt_Code
        '
        Me.Txt_Code.BackColor = System.Drawing.Color.White
        Me.Txt_Code.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_Code.Location = New System.Drawing.Point(107, 98)
        Me.Txt_Code.Name = "Txt_Code"
        Me.Txt_Code.ReadOnly = True
        Me.Txt_Code.Size = New System.Drawing.Size(196, 24)
        Me.Txt_Code.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 24)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Code"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(265, 46)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 24)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "New Waist"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(3, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 24)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "New Weight"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SteelBlue
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(3, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 24)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Visit Date"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.SteelBlue
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(418, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(108, 24)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Visit Type"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.SteelBlue
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(3, 159)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(132, 53)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "Notes"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.SteelBlue
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(3, 119)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(132, 24)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "EatingHabits"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.SteelBlue
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(3, 81)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(132, 24)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "PlanOfTreatment"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbo_VisitType
        '
        Me.Cbo_VisitType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cbo_VisitType.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Cbo_VisitType.FormattingEnabled = True
        Me.Cbo_VisitType.Location = New System.Drawing.Point(526, 9)
        Me.Cbo_VisitType.Name = "Cbo_VisitType"
        Me.Cbo_VisitType.Size = New System.Drawing.Size(136, 24)
        Me.Cbo_VisitType.TabIndex = 52
        '
        'Pnl_VisitDetails
        '
        Me.Pnl_VisitDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pnl_VisitDetails.AutoScroll = True
        Me.Pnl_VisitDetails.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Pnl_VisitDetails.Controls.Add(Me.Dtp_VisitDate)
        Me.Pnl_VisitDetails.Controls.Add(Me.Txt_Notes)
        Me.Pnl_VisitDetails.Controls.Add(Me.Txt_EatingHabits)
        Me.Pnl_VisitDetails.Controls.Add(Me.Txt_PlanOfTreatment)
        Me.Pnl_VisitDetails.Controls.Add(Me.Txt_NewWeight)
        Me.Pnl_VisitDetails.Controls.Add(Me.Txt_VisitCost)
        Me.Pnl_VisitDetails.Controls.Add(Me.Label1)
        Me.Pnl_VisitDetails.Controls.Add(Me.Cbo_VisitType)
        Me.Pnl_VisitDetails.Controls.Add(Me.Label21)
        Me.Pnl_VisitDetails.Controls.Add(Me.Txt_NewWaist)
        Me.Pnl_VisitDetails.Controls.Add(Me.Label19)
        Me.Pnl_VisitDetails.Controls.Add(Me.Label18)
        Me.Pnl_VisitDetails.Controls.Add(Me.Label22)
        Me.Pnl_VisitDetails.Controls.Add(Me.Label16)
        Me.Pnl_VisitDetails.Controls.Add(Me.Label23)
        Me.Pnl_VisitDetails.Controls.Add(Me.Label15)
        Me.Pnl_VisitDetails.Location = New System.Drawing.Point(644, 35)
        Me.Pnl_VisitDetails.Name = "Pnl_VisitDetails"
        Me.Pnl_VisitDetails.Size = New System.Drawing.Size(680, 231)
        Me.Pnl_VisitDetails.TabIndex = 38
        '
        'Dtp_VisitDate
        '
        Me.Dtp_VisitDate.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Dtp_VisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_VisitDate.Location = New System.Drawing.Point(135, 11)
        Me.Dtp_VisitDate.Name = "Dtp_VisitDate"
        Me.Dtp_VisitDate.Size = New System.Drawing.Size(116, 24)
        Me.Dtp_VisitDate.TabIndex = 58
        Me.Dtp_VisitDate.Value = New Date(2022, 3, 26, 0, 0, 0, 0)
        '
        'Txt_Notes
        '
        Me.Txt_Notes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Notes.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_Notes.Location = New System.Drawing.Point(135, 159)
        Me.Txt_Notes.Multiline = True
        Me.Txt_Notes.Name = "Txt_Notes"
        Me.Txt_Notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Notes.Size = New System.Drawing.Size(529, 53)
        Me.Txt_Notes.TabIndex = 57
        '
        'Txt_EatingHabits
        '
        Me.Txt_EatingHabits.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_EatingHabits.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_EatingHabits.Location = New System.Drawing.Point(135, 119)
        Me.Txt_EatingHabits.Name = "Txt_EatingHabits"
        Me.Txt_EatingHabits.Size = New System.Drawing.Size(529, 24)
        Me.Txt_EatingHabits.TabIndex = 56
        '
        'Txt_PlanOfTreatment
        '
        Me.Txt_PlanOfTreatment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_PlanOfTreatment.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_PlanOfTreatment.Location = New System.Drawing.Point(135, 81)
        Me.Txt_PlanOfTreatment.Name = "Txt_PlanOfTreatment"
        Me.Txt_PlanOfTreatment.Size = New System.Drawing.Size(529, 24)
        Me.Txt_PlanOfTreatment.TabIndex = 55
        '
        'Txt_NewWeight
        '
        Me.Txt_NewWeight.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_NewWeight.Location = New System.Drawing.Point(135, 46)
        Me.Txt_NewWeight.MaxLength = 3
        Me.Txt_NewWeight.Name = "Txt_NewWeight"
        Me.Txt_NewWeight.Size = New System.Drawing.Size(116, 24)
        Me.Txt_NewWeight.TabIndex = 55
        Me.Txt_NewWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_VisitCost
        '
        Me.Txt_VisitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_VisitCost.BackColor = System.Drawing.Color.White
        Me.Txt_VisitCost.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_VisitCost.Location = New System.Drawing.Point(526, 46)
        Me.Txt_VisitCost.Name = "Txt_VisitCost"
        Me.Txt_VisitCost.ReadOnly = True
        Me.Txt_VisitCost.Size = New System.Drawing.Size(136, 24)
        Me.Txt_VisitCost.TabIndex = 54
        Me.Txt_VisitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(418, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 24)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Visit Cost"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_NewWaist
        '
        Me.Txt_NewWaist.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_NewWaist.Location = New System.Drawing.Point(346, 46)
        Me.Txt_NewWaist.MaxLength = 3
        Me.Txt_NewWaist.Name = "Txt_NewWaist"
        Me.Txt_NewWaist.Size = New System.Drawing.Size(90, 24)
        Me.Txt_NewWaist.TabIndex = 51
        Me.Txt_NewWaist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.BtnStrip_Save, Me.BtnStrp_Delete})
        Me.ToolStrip1.Location = New System.Drawing.Point(644, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(500, 36)
        Me.ToolStrip1.TabIndex = 59
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Pnl_PatientDetail
        '
        Me.Pnl_PatientDetail.AutoScroll = True
        Me.Pnl_PatientDetail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Pnl_PatientDetail.Controls.Add(Me.Lbl_Phone1)
        Me.Pnl_PatientDetail.Controls.Add(Me.Label4)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_Phone1)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_PatientName)
        Me.Pnl_PatientDetail.Controls.Add(Me.Label2)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_StartWeight)
        Me.Pnl_PatientDetail.Controls.Add(Me.Label3)
        Me.Pnl_PatientDetail.Controls.Add(Me.Label9)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_PatientNum)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_Height)
        Me.Pnl_PatientDetail.Controls.Add(Me.Label5)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_FirstVisit)
        Me.Pnl_PatientDetail.Controls.Add(Me.Label6)
        Me.Pnl_PatientDetail.Controls.Add(Me.Lbl_FirstVisit)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_Code)
        Me.Pnl_PatientDetail.Controls.Add(Me.Label7)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_Age)
        Me.Pnl_PatientDetail.Controls.Add(Me.Txt_Occupation)
        Me.Pnl_PatientDetail.Location = New System.Drawing.Point(3, 35)
        Me.Pnl_PatientDetail.Name = "Pnl_PatientDetail"
        Me.Pnl_PatientDetail.Size = New System.Drawing.Size(635, 231)
        Me.Pnl_PatientDetail.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(642, 35)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Patient Detail"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(903, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(421, 35)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Visit Detail"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VisitDate"
        Me.DataGridViewTextBoxColumn1.HeaderText = "VisitDate"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PatientID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PatientNum"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PatientName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PatientName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "VisitType"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Visit Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VisitCost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Visit Cost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "NewWeight"
        Me.DataGridViewTextBoxColumn6.HeaderText = "New Weight"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NewWaist"
        Me.DataGridViewTextBoxColumn7.HeaderText = "New Waist"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PlanOfTreatment"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PlanOfTreatment"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EatingHabits"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Eating Habits"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.UpdateNewClinic.My.Resources.Resources.New_32_32
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 33)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'BtnStrip_Save
        '
        Me.BtnStrip_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnStrip_Save.Image = Global.UpdateNewClinic.My.Resources.Resources.Save_32_32
        Me.BtnStrip_Save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnStrip_Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStrip_Save.Name = "BtnStrip_Save"
        Me.BtnStrip_Save.Size = New System.Drawing.Size(36, 33)
        Me.BtnStrip_Save.Text = "ToolStripButton1"
        '
        'BtnStrp_Delete
        '
        Me.BtnStrp_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnStrp_Delete.Image = Global.UpdateNewClinic.My.Resources.Resources.Delete
        Me.BtnStrp_Delete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnStrp_Delete.Name = "BtnStrp_Delete"
        Me.BtnStrp_Delete.Size = New System.Drawing.Size(23, 33)
        Me.BtnStrp_Delete.Text = "ToolStripButton2"
        '
        'Frm_PatientVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1324, 636)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Pnl_PatientDetail)
        Me.Controls.Add(Me.Pnl_VisitDetails)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(1340, 675)
        Me.Name = "Frm_PatientVisit"
        Me.Text = "PatientVisit"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Dgv_VisitDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_VisitDetails.ResumeLayout(False)
        Me.Pnl_VisitDetails.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Pnl_PatientDetail.ResumeLayout(False)
        Me.Pnl_PatientDetail.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Dgv_VisitDetail As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_PatientName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_PatientNum As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Occupation As TextBox
    Friend WithEvents Txt_Age As TextBox
    Friend WithEvents Txt_Code As TextBox
    Friend WithEvents Txt_Phone1 As TextBox
    Friend WithEvents Lbl_Phone1 As Label
    Friend WithEvents Txt_StartWeight As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Height As TextBox
    Friend WithEvents Txt_FirstVisit As TextBox
    Friend WithEvents Lbl_FirstVisit As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Cbo_VisitType As ComboBox
    Friend WithEvents Pnl_VisitDetails As Panel
    Friend WithEvents Txt_Notes As TextBox
    Friend WithEvents Txt_EatingHabits As TextBox
    Friend WithEvents Txt_PlanOfTreatment As TextBox
    Friend WithEvents Txt_NewWeight As TextBox
    Friend WithEvents Txt_VisitCost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_NewWaist As TextBox
    Friend WithEvents Pnl_PatientDetail As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnStrip_Save As ToolStripButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BtnStrp_Delete As ToolStripButton
    Friend WithEvents Dtp_VisitDate As DateTimePicker
    Friend WithEvents VisitDate As DataGridViewTextBoxColumn
    Friend WithEvents VisitType As DataGridViewTextBoxColumn
    Friend WithEvents VisitCost As DataGridViewTextBoxColumn
    Friend WithEvents NewWeight As DataGridViewTextBoxColumn
    Friend WithEvents NewWaist As DataGridViewTextBoxColumn
    Friend WithEvents PlanOfTreatment As DataGridViewTextBoxColumn
    Friend WithEvents EatingHabits As DataGridViewTextBoxColumn
    Friend WithEvents Notes As DataGridViewTextBoxColumn
End Class
