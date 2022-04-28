<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ManageReservation
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dgv_MangeReservation = New System.Windows.Forms.DataGridView()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenVisit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.FirstDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Occupation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Height = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dtp_ReserveDate = New System.Windows.Forms.DateTimePicker()
        Me.Cbo_VisitType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Count = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Lbl_Booking = New System.Windows.Forms.Label()
        Me.Lbl_CountWaiting = New System.Windows.Forms.Label()
        Me.Lbl_CountEntry = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_CountInside = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Lbl_Exit = New System.Windows.Forms.Label()
        Me.Lbl_CountOut = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Btn_NewPatient = New System.Windows.Forms.Button()
        Me.Dgv_Search = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_SearchValue = New System.Windows.Forms.TextBox()
        Me.Cbo_SortAndSearch = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_EditPatient = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Txt_PatientName = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Btn_Reset = New System.Windows.Forms.Button()
        Me.Btn_SaveNewPatient = New System.Windows.Forms.Button()
        Me.Txt_VisitCost = New System.Windows.Forms.TextBox()
        Me.Txt_Num = New System.Windows.Forms.TextBox()
        CType(Me.Dgv_MangeReservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dgv_MangeReservation
        '
        Me.Dgv_MangeReservation.AllowUserToAddRows = False
        Me.Dgv_MangeReservation.AllowUserToDeleteRows = False
        Me.Dgv_MangeReservation.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Dgv_MangeReservation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Dgv_MangeReservation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dgv_MangeReservation.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_MangeReservation.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_MangeReservation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Dgv_MangeReservation.ColumnHeadersHeight = 30
        Me.Dgv_MangeReservation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientID, Me.PatientName, Me.PhoneNumber, Me.Code, Me.ReserveDate, Me.VisitName, Me.Status, Me.VisitCost, Me.OpenVisit, Me.Delete, Me.FirstDate, Me.Age, Me.Occupation, Me.Height, Me.StartWeight, Me.VisitType})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_MangeReservation.DefaultCellStyle = DataGridViewCellStyle9
        Me.Dgv_MangeReservation.Location = New System.Drawing.Point(378, 79)
        Me.Dgv_MangeReservation.Name = "Dgv_MangeReservation"
        Me.Dgv_MangeReservation.RowHeadersVisible = False
        Me.Dgv_MangeReservation.RowTemplate.Height = 25
        Me.Dgv_MangeReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_MangeReservation.Size = New System.Drawing.Size(974, 629)
        Me.Dgv_MangeReservation.TabIndex = 0
        '
        'PatientID
        '
        Me.PatientID.HeaderText = "PatientID"
        Me.PatientID.Name = "PatientID"
        '
        'PatientName
        '
        Me.PatientName.HeaderText = "PatientName"
        Me.PatientName.Name = "PatientName"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.HeaderText = "PhoneNumber"
        Me.PhoneNumber.Name = "PhoneNumber"
        '
        'Code
        '
        Me.Code.HeaderText = "Code"
        Me.Code.Name = "Code"
        '
        'ReserveDate
        '
        Me.ReserveDate.HeaderText = "ReserveDate"
        Me.ReserveDate.Name = "ReserveDate"
        '
        'VisitName
        '
        Me.VisitName.HeaderText = "VisitName"
        Me.VisitName.Name = "VisitName"
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'VisitCost
        '
        Me.VisitCost.HeaderText = "VisitCost"
        Me.VisitCost.Name = "VisitCost"
        '
        'OpenVisit
        '
        Me.OpenVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenVisit.HeaderText = "Open Visit"
        Me.OpenVisit.Name = "OpenVisit"
        Me.OpenVisit.Text = ""
        '
        'Delete
        '
        Me.Delete.HeaderText = "Delete"
        Me.Delete.Name = "Delete"
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'FirstDate
        '
        Me.FirstDate.HeaderText = "FirstDate"
        Me.FirstDate.Name = "FirstDate"
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        '
        'Occupation
        '
        Me.Occupation.HeaderText = "Occupation"
        Me.Occupation.Name = "Occupation"
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
        'VisitType
        '
        Me.VisitType.HeaderText = "VisitType"
        Me.VisitType.Name = "VisitType"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(377, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reserve Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(377, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Visit Type"
        '
        'Dtp_ReserveDate
        '
        Me.Dtp_ReserveDate.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Dtp_ReserveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_ReserveDate.Location = New System.Drawing.Point(489, 10)
        Me.Dtp_ReserveDate.Name = "Dtp_ReserveDate"
        Me.Dtp_ReserveDate.Size = New System.Drawing.Size(140, 25)
        Me.Dtp_ReserveDate.TabIndex = 3
        '
        'Cbo_VisitType
        '
        Me.Cbo_VisitType.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Cbo_VisitType.FormattingEnabled = True
        Me.Cbo_VisitType.Items.AddRange(New Object() {" "})
        Me.Cbo_VisitType.Location = New System.Drawing.Point(489, 47)
        Me.Cbo_VisitType.Name = "Cbo_VisitType"
        Me.Cbo_VisitType.Size = New System.Drawing.Size(140, 26)
        Me.Cbo_VisitType.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(49, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Count
        '
        Me.Lbl_Count.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Count.BackColor = System.Drawing.Color.Maroon
        Me.Lbl_Count.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Count.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Count.Location = New System.Drawing.Point(11, 17)
        Me.Lbl_Count.Name = "Lbl_Count"
        Me.Lbl_Count.Size = New System.Drawing.Size(173, 49)
        Me.Lbl_Count.TabIndex = 6
        Me.Lbl_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Lbl_Booking)
        Me.GroupBox1.Controls.Add(Me.Lbl_CountWaiting)
        Me.GroupBox1.Controls.Add(Me.Lbl_CountEntry)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_CountInside)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Lbl_Count)
        Me.GroupBox1.Location = New System.Drawing.Point(633, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 74)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(510, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 19)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Booking"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Wheat
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(361, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 19)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Waiting"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(215, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 19)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Entry"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Booking
        '
        Me.Lbl_Booking.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Booking.BackColor = System.Drawing.Color.White
        Me.Lbl_Booking.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Booking.Location = New System.Drawing.Point(529, 44)
        Me.Lbl_Booking.Name = "Lbl_Booking"
        Me.Lbl_Booking.Size = New System.Drawing.Size(59, 19)
        Me.Lbl_Booking.TabIndex = 14
        Me.Lbl_Booking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_CountWaiting
        '
        Me.Lbl_CountWaiting.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_CountWaiting.BackColor = System.Drawing.Color.White
        Me.Lbl_CountWaiting.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_CountWaiting.Location = New System.Drawing.Point(379, 44)
        Me.Lbl_CountWaiting.Name = "Lbl_CountWaiting"
        Me.Lbl_CountWaiting.Size = New System.Drawing.Size(59, 19)
        Me.Lbl_CountWaiting.TabIndex = 13
        Me.Lbl_CountWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_CountEntry
        '
        Me.Lbl_CountEntry.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_CountEntry.BackColor = System.Drawing.Color.White
        Me.Lbl_CountEntry.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_CountEntry.Location = New System.Drawing.Point(232, 44)
        Me.Lbl_CountEntry.Name = "Lbl_CountEntry"
        Me.Lbl_CountEntry.Size = New System.Drawing.Size(59, 19)
        Me.Lbl_CountEntry.TabIndex = 12
        Me.Lbl_CountEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(200, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 49)
        Me.Label6.TabIndex = 10
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(493, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 49)
        Me.Label5.TabIndex = 9
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Wheat
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(346, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 49)
        Me.Label4.TabIndex = 8
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_CountInside
        '
        Me.lbl_CountInside.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_CountInside.BackColor = System.Drawing.Color.White
        Me.lbl_CountInside.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_CountInside.Location = New System.Drawing.Point(12, 44)
        Me.lbl_CountInside.Name = "lbl_CountInside"
        Me.lbl_CountInside.Size = New System.Drawing.Size(170, 19)
        Me.lbl_CountInside.TabIndex = 7
        Me.lbl_CountInside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.LightCoral
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(47, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 19)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Out"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Exit
        '
        Me.Lbl_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Exit.BackColor = System.Drawing.Color.White
        Me.Lbl_Exit.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Exit.Location = New System.Drawing.Point(49, 44)
        Me.Lbl_Exit.Name = "Lbl_Exit"
        Me.Lbl_Exit.Size = New System.Drawing.Size(59, 19)
        Me.Lbl_Exit.TabIndex = 15
        Me.Lbl_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_CountOut
        '
        Me.Lbl_CountOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_CountOut.BackColor = System.Drawing.Color.LightCoral
        Me.Lbl_CountOut.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_CountOut.ForeColor = System.Drawing.Color.Black
        Me.Lbl_CountOut.Location = New System.Drawing.Point(14, 17)
        Me.Lbl_CountOut.Name = "Lbl_CountOut"
        Me.Lbl_CountOut.Size = New System.Drawing.Size(128, 49)
        Me.Lbl_CountOut.TabIndex = 11
        Me.Lbl_CountOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Lbl_Exit)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Lbl_CountOut)
        Me.GroupBox2.Location = New System.Drawing.Point(1192, -1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(157, 74)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
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
        Me.Btn_NewPatient.Location = New System.Drawing.Point(269, 66)
        Me.Btn_NewPatient.Name = "Btn_NewPatient"
        Me.Btn_NewPatient.Size = New System.Drawing.Size(83, 27)
        Me.Btn_NewPatient.TabIndex = 47
        Me.Btn_NewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_NewPatient.UseVisualStyleBackColor = False
        '
        'Dgv_Search
        '
        Me.Dgv_Search.AllowUserToAddRows = False
        Me.Dgv_Search.AllowUserToDeleteRows = False
        Me.Dgv_Search.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        Me.Dgv_Search.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.Dgv_Search.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Search.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Search.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Dgv_Search.ColumnHeadersHeight = 30
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Search.DefaultCellStyle = DataGridViewCellStyle12
        Me.Dgv_Search.Location = New System.Drawing.Point(3, 272)
        Me.Dgv_Search.Name = "Dgv_Search"
        Me.Dgv_Search.ReadOnly = True
        Me.Dgv_Search.RowHeadersVisible = False
        Me.Dgv_Search.RowTemplate.Height = 25
        Me.Dgv_Search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Search.Size = New System.Drawing.Size(362, 426)
        Me.Dgv_Search.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(6, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 27)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = " Search By"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_SearchValue
        '
        Me.Txt_SearchValue.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_SearchValue.Location = New System.Drawing.Point(102, 66)
        Me.Txt_SearchValue.Name = "Txt_SearchValue"
        Me.Txt_SearchValue.Size = New System.Drawing.Size(150, 27)
        Me.Txt_SearchValue.TabIndex = 44
        '
        'Cbo_SortAndSearch
        '
        Me.Cbo_SortAndSearch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Cbo_SortAndSearch.FormattingEnabled = True
        Me.Cbo_SortAndSearch.Items.AddRange(New Object() {"PatientName", "Phone"})
        Me.Cbo_SortAndSearch.Location = New System.Drawing.Point(102, 28)
        Me.Cbo_SortAndSearch.Name = "Cbo_SortAndSearch"
        Me.Cbo_SortAndSearch.Size = New System.Drawing.Size(150, 27)
        Me.Cbo_SortAndSearch.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(6, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 27)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Search Value"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.Dgv_Search)
        Me.Panel1.Controls.Add(Me.Txt_VisitCost)
        Me.Panel1.Controls.Add(Me.Txt_Num)
        Me.Panel1.Location = New System.Drawing.Point(3, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(368, 698)
        Me.Panel1.TabIndex = 48
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_EditPatient)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Txt_SearchValue)
        Me.GroupBox3.Controls.Add(Me.Cbo_SortAndSearch)
        Me.GroupBox3.Controls.Add(Me.Btn_NewPatient)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 109)
        Me.GroupBox3.TabIndex = 48
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search /AddNew"
        '
        'Btn_EditPatient
        '
        Me.Btn_EditPatient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_EditPatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_EditPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_EditPatient.FlatAppearance.BorderSize = 0
        Me.Btn_EditPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_EditPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_EditPatient.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_EditPatient.ForeColor = System.Drawing.Color.White
        Me.Btn_EditPatient.Image = Global.UpdateNewClinic.My.Resources.Resources.Edit_20
        Me.Btn_EditPatient.Location = New System.Drawing.Point(269, 28)
        Me.Btn_EditPatient.Name = "Btn_EditPatient"
        Me.Btn_EditPatient.Size = New System.Drawing.Size(83, 27)
        Me.Btn_EditPatient.TabIndex = 48
        Me.Btn_EditPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_EditPatient.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_Reset)
        Me.GroupBox4.Controls.Add(Me.Btn_SaveNewPatient)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Txt_PatientName)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox4.Location = New System.Drawing.Point(3, -1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(362, 145)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "New Booking"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(6, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 27)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "PatientName"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(6, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 27)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Booking Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.SteelBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(6, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 27)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Visit Type"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 27)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Value = New Date(2022, 4, 4, 0, 0, 0, 0)
        '
        'Txt_PatientName
        '
        Me.Txt_PatientName.BackColor = System.Drawing.Color.White
        Me.Txt_PatientName.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_PatientName.Location = New System.Drawing.Point(102, 24)
        Me.Txt_PatientName.Name = "Txt_PatientName"
        Me.Txt_PatientName.ReadOnly = True
        Me.Txt_PatientName.Size = New System.Drawing.Size(252, 27)
        Me.Txt_PatientName.TabIndex = 40
        Me.Txt_PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(102, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 27)
        Me.ComboBox1.TabIndex = 44
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
        Me.Btn_Reset.Location = New System.Drawing.Point(269, 108)
        Me.Btn_Reset.Name = "Btn_Reset"
        Me.Btn_Reset.Size = New System.Drawing.Size(83, 27)
        Me.Btn_Reset.TabIndex = 46
        Me.Btn_Reset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.Btn_SaveNewPatient.Location = New System.Drawing.Point(269, 66)
        Me.Btn_SaveNewPatient.Name = "Btn_SaveNewPatient"
        Me.Btn_SaveNewPatient.Size = New System.Drawing.Size(83, 27)
        Me.Btn_SaveNewPatient.TabIndex = 45
        Me.Btn_SaveNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_SaveNewPatient.UseVisualStyleBackColor = False
        '
        'Txt_VisitCost
        '
        Me.Txt_VisitCost.BackColor = System.Drawing.Color.White
        Me.Txt_VisitCost.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.Txt_VisitCost.Location = New System.Drawing.Point(74, 108)
        Me.Txt_VisitCost.Name = "Txt_VisitCost"
        Me.Txt_VisitCost.ReadOnly = True
        Me.Txt_VisitCost.Size = New System.Drawing.Size(63, 16)
        Me.Txt_VisitCost.TabIndex = 48
        Me.Txt_VisitCost.Visible = False
        '
        'Txt_Num
        '
        Me.Txt_Num.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.Txt_Num.Location = New System.Drawing.Point(143, 109)
        Me.Txt_Num.Name = "Txt_Num"
        Me.Txt_Num.Size = New System.Drawing.Size(100, 16)
        Me.Txt_Num.TabIndex = 47
        Me.Txt_Num.Visible = False
        '
        'frm_ManageReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1352, 708)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cbo_VisitType)
        Me.Controls.Add(Me.Dtp_ReserveDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dgv_MangeReservation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_ManageReservation"
        Me.Text = "Manage Reservation"
        CType(Me.Dgv_MangeReservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgv_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_MangeReservation As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dtp_ReserveDate As DateTimePicker
    Friend WithEvents Cbo_VisitType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_Count As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_CountInside As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_CountOut As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_Exit As Label
    Friend WithEvents Lbl_Booking As Label
    Friend WithEvents Lbl_CountWaiting As Label
    Friend WithEvents Lbl_CountEntry As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents ReserveDate As DataGridViewTextBoxColumn
    Friend WithEvents VisitName As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents VisitCost As DataGridViewTextBoxColumn
    Friend WithEvents OpenVisit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents FirstDate As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Occupation As DataGridViewTextBoxColumn
    Friend WithEvents Height As DataGridViewTextBoxColumn
    Friend WithEvents StartWeight As DataGridViewTextBoxColumn
    Friend WithEvents VisitType As DataGridViewTextBoxColumn
    Friend WithEvents Btn_NewPatient As Button
    Friend WithEvents Dgv_Search As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_SearchValue As TextBox
    Friend WithEvents Cbo_SortAndSearch As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_EditPatient As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Txt_PatientName As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Btn_Reset As Button
    Friend WithEvents Btn_SaveNewPatient As Button
    Friend WithEvents Txt_VisitCost As TextBox
    Friend WithEvents Txt_Num As TextBox
End Class
