<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_EditPatients
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dgv_EditPatient = New System.Windows.Forms.DataGridView()
        Me.PatientNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Open = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Txt_SearchNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_SearchName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Telephone = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Dtp_SearchVisit = New System.Windows.Forms.DateTimePicker()
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
        Me.Btn_ShowAllPatients = New System.Windows.Forms.Button()
        Me.Btn_AddNewPatient = New System.Windows.Forms.Button()
        Me.Btn_ExportExcel = New System.Windows.Forms.Button()
        Me.Btn_SavePatient = New System.Windows.Forms.Button()
        Me.Btn_DelPatient = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        CType(Me.Dgv_EditPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_EditPatient
        '
        Me.Dgv_EditPatient.AllowUserToAddRows = False
        Me.Dgv_EditPatient.AllowUserToDeleteRows = False
        Me.Dgv_EditPatient.AllowUserToResizeColumns = False
        Me.Dgv_EditPatient.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue
        Me.Dgv_EditPatient.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dgv_EditPatient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_EditPatient.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_EditPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_EditPatient.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Dgv_EditPatient.ColumnHeadersHeight = 30
        Me.Dgv_EditPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_EditPatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientNum, Me.PatientName, Me.Code, Me.Age, Me.Occupation, Me.PhoneNumber, Me.FirstDate, Me.Height, Me.StartWeight, Me.Open})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.NullValue = Nothing
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_EditPatient.DefaultCellStyle = DataGridViewCellStyle9
        Me.Dgv_EditPatient.EnableHeadersVisualStyles = False
        Me.Dgv_EditPatient.GridColor = System.Drawing.Color.Gainsboro
        Me.Dgv_EditPatient.Location = New System.Drawing.Point(3, 0)
        Me.Dgv_EditPatient.Name = "Dgv_EditPatient"
        Me.Dgv_EditPatient.RowHeadersVisible = False
        Me.Dgv_EditPatient.RowTemplate.Height = 30
        Me.Dgv_EditPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_EditPatient.Size = New System.Drawing.Size(1098, 464)
        Me.Dgv_EditPatient.TabIndex = 0
        '
        'PatientNum
        '
        Me.PatientNum.DataPropertyName = "PatientNum"
        Me.PatientNum.HeaderText = "PatientNum"
        Me.PatientNum.Name = "PatientNum"
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "PatientName"
        Me.PatientName.Name = "PatientName"
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.MaxInputLength = 100
        Me.Age.Name = "Age"
        '
        'Occupation
        '
        Me.Occupation.HeaderText = "Occupation"
        Me.Occupation.Name = "Occupation"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.HeaderText = "PhoneNumber"
        Me.PhoneNumber.Name = "PhoneNumber"
        '
        'FirstDate
        '
        Me.FirstDate.HeaderText = "FirstDate"
        Me.FirstDate.Name = "FirstDate"
        '
        'Height
        '
        Me.Height.HeaderText = "Height"
        Me.Height.Name = "Height"
        '
        'StartWeight
        '
        Me.StartWeight.HeaderText = "StartWeight"
        Me.StartWeight.Name = "StartWeight"
        '
        'Open
        '
        Me.Open.HeaderText = "Open"
        Me.Open.Name = "Open"
        '
        'Txt_SearchNum
        '
        Me.Txt_SearchNum.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_SearchNum.Location = New System.Drawing.Point(523, 9)
        Me.Txt_SearchNum.Name = "Txt_SearchNum"
        Me.Txt_SearchNum.Size = New System.Drawing.Size(177, 24)
        Me.Txt_SearchNum.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(405, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PatientNum"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_SearchName
        '
        Me.Txt_SearchName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Txt_SearchName.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_SearchName.Location = New System.Drawing.Point(135, 9)
        Me.Txt_SearchName.Name = "Txt_SearchName"
        Me.Txt_SearchName.Size = New System.Drawing.Size(216, 24)
        Me.Txt_SearchName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(405, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FirstVisitDate"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TelePhone"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Telephone
        '
        Me.Txt_Telephone.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Txt_Telephone.Location = New System.Drawing.Point(135, 45)
        Me.Txt_Telephone.Name = "Txt_Telephone"
        Me.Txt_Telephone.Size = New System.Drawing.Size(216, 24)
        Me.Txt_Telephone.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Dgv_EditPatient)
        Me.Panel1.Location = New System.Drawing.Point(2, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1101, 467)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_ShowAllPatients)
        Me.Panel2.Controls.Add(Me.Btn_AddNewPatient)
        Me.Panel2.Controls.Add(Me.Btn_ExportExcel)
        Me.Panel2.Controls.Add(Me.Btn_SavePatient)
        Me.Panel2.Controls.Add(Me.Btn_DelPatient)
        Me.Panel2.Controls.Add(Me.Btn_Exit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 558)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1103, 59)
        Me.Panel2.TabIndex = 5
        '
        'Dtp_SearchVisit
        '
        Me.Dtp_SearchVisit.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Dtp_SearchVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_SearchVisit.Location = New System.Drawing.Point(523, 45)
        Me.Dtp_SearchVisit.Name = "Dtp_SearchVisit"
        Me.Dtp_SearchVisit.Size = New System.Drawing.Size(177, 24)
        Me.Dtp_SearchVisit.TabIndex = 3
        Me.Dtp_SearchVisit.Value = New Date(2001, 1, 1, 0, 0, 0, 0)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PatientNum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "PatientNum"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "PatientName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn4.MaxInputLength = 100
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Occupation"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "PhoneNumber1"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "PhoneNumber2"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "FirstDate"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Height"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "StartWeight"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Btn_ShowAllPatients
        '
        Me.Btn_ShowAllPatients.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_ShowAllPatients.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_ShowAllPatients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ShowAllPatients.FlatAppearance.BorderSize = 0
        Me.Btn_ShowAllPatients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_ShowAllPatients.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ShowAllPatients.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ShowAllPatients.ForeColor = System.Drawing.Color.White
        Me.Btn_ShowAllPatients.Image = Global.UpdateNewClinic.My.Resources.Resources.ShowAll
        Me.Btn_ShowAllPatients.Location = New System.Drawing.Point(3, 10)
        Me.Btn_ShowAllPatients.Name = "Btn_ShowAllPatients"
        Me.Btn_ShowAllPatients.Size = New System.Drawing.Size(176, 39)
        Me.Btn_ShowAllPatients.TabIndex = 0
        Me.Btn_ShowAllPatients.Text = "Show Today   F2"
        Me.Btn_ShowAllPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_ShowAllPatients.UseVisualStyleBackColor = False
        '
        'Btn_AddNewPatient
        '
        Me.Btn_AddNewPatient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_AddNewPatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_AddNewPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AddNewPatient.FlatAppearance.BorderSize = 0
        Me.Btn_AddNewPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_AddNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_AddNewPatient.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_AddNewPatient.ForeColor = System.Drawing.Color.White
        Me.Btn_AddNewPatient.Image = Global.UpdateNewClinic.My.Resources.Resources.AddNew
        Me.Btn_AddNewPatient.Location = New System.Drawing.Point(264, 10)
        Me.Btn_AddNewPatient.Name = "Btn_AddNewPatient"
        Me.Btn_AddNewPatient.Size = New System.Drawing.Size(126, 39)
        Me.Btn_AddNewPatient.TabIndex = 1
        Me.Btn_AddNewPatient.Text = "New       F3"
        Me.Btn_AddNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_AddNewPatient.UseVisualStyleBackColor = False
        '
        'Btn_ExportExcel
        '
        Me.Btn_ExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_ExportExcel.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_ExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ExportExcel.FlatAppearance.BorderSize = 0
        Me.Btn_ExportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_ExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ExportExcel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ExportExcel.ForeColor = System.Drawing.Color.White
        Me.Btn_ExportExcel.Image = Global.UpdateNewClinic.My.Resources.Resources.ExportToExcel
        Me.Btn_ExportExcel.Location = New System.Drawing.Point(728, 10)
        Me.Btn_ExportExcel.Name = "Btn_ExportExcel"
        Me.Btn_ExportExcel.Size = New System.Drawing.Size(126, 39)
        Me.Btn_ExportExcel.TabIndex = 4
        Me.Btn_ExportExcel.Text = "Export Excel"
        Me.Btn_ExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_ExportExcel.UseVisualStyleBackColor = False
        '
        'Btn_SavePatient
        '
        Me.Btn_SavePatient.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_SavePatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_SavePatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SavePatient.FlatAppearance.BorderSize = 0
        Me.Btn_SavePatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_SavePatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_SavePatient.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SavePatient.ForeColor = System.Drawing.Color.White
        Me.Btn_SavePatient.Image = Global.UpdateNewClinic.My.Resources.Resources.Save
        Me.Btn_SavePatient.Location = New System.Drawing.Point(365, 10)
        Me.Btn_SavePatient.Name = "Btn_SavePatient"
        Me.Btn_SavePatient.Size = New System.Drawing.Size(126, 39)
        Me.Btn_SavePatient.TabIndex = 2
        Me.Btn_SavePatient.Text = "Save        F4"
        Me.Btn_SavePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_SavePatient.UseVisualStyleBackColor = False
        '
        'Btn_DelPatient
        '
        Me.Btn_DelPatient.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_DelPatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_DelPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_DelPatient.FlatAppearance.BorderSize = 0
        Me.Btn_DelPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_DelPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_DelPatient.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_DelPatient.ForeColor = System.Drawing.Color.White
        Me.Btn_DelPatient.Image = Global.UpdateNewClinic.My.Resources.Resources.Delete
        Me.Btn_DelPatient.Location = New System.Drawing.Point(637, 10)
        Me.Btn_DelPatient.Name = "Btn_DelPatient"
        Me.Btn_DelPatient.Size = New System.Drawing.Size(126, 39)
        Me.Btn_DelPatient.TabIndex = 3
        Me.Btn_DelPatient.Text = "Delete "
        Me.Btn_DelPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_DelPatient.UseVisualStyleBackColor = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Exit.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Exit.FlatAppearance.BorderSize = 0
        Me.Btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Exit.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Exit.ForeColor = System.Drawing.Color.White
        Me.Btn_Exit.Image = Global.UpdateNewClinic.My.Resources.Resources.ExitFrm
        Me.Btn_Exit.Location = New System.Drawing.Point(970, 10)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(122, 39)
        Me.Btn_Exit.TabIndex = 5
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'Btn_Reset
        '
        Me.Btn_Reset.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Reset.FlatAppearance.BorderSize = 0
        Me.Btn_Reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Reset.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Reset.ForeColor = System.Drawing.Color.White
        Me.Btn_Reset.Image = Global.UpdateNewClinic.My.Resources.Resources.Undo
        Me.Btn_Reset.Location = New System.Drawing.Point(729, 9)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(108, 60)
        Me.Btn_Reset.TabIndex = 4
        Me.Btn_Reset.Text = "Undo"
        Me.Btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Reset.UseVisualStyleBackColor = False
        '
        'Frm_EditPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1103, 617)
        Me.Controls.Add(Me.Dtp_SearchVisit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btn_Reset)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Telephone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_SearchName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_SearchNum)
        Me.KeyPreview = True
        Me.Name = "Frm_EditPatients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "EditPatient"
        CType(Me.Dgv_EditPatient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_EditPatient As DataGridView
#Disable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
#Enable Warning BC40004 ' Member conflicts with member in the base type and should be declared 'Shadows'
    Friend WithEvents Txt_SearchNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_SearchName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Telephone As TextBox
    Friend WithEvents Btn_AddNewPatient As Button
    Friend WithEvents Btn_SavePatient As Button
    Friend WithEvents Btn_DelPatient As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_ShowAllPatients As Button
    Friend WithEvents Btn_ExportExcel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dtp_SearchVisit As DateTimePicker
    Friend WithEvents Btn_Reset As Button
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
    Friend WithEvents PatientNum As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Occupation As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents FirstDate As DataGridViewTextBoxColumn
    Friend WithEvents Height As DataGridViewTextBoxColumn
    Friend WithEvents StartWeight As DataGridViewTextBoxColumn
    Friend WithEvents Open As DataGridViewButtonColumn
End Class
