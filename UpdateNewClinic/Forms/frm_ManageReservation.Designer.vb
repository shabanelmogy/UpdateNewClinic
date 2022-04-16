﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ManageReservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Dgv_Reservation = New System.Windows.Forms.DataGridView()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReserveDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenVisit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dtp_ReserveDate = New System.Windows.Forms.DateTimePicker()
        Me.Cbo_VisitType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Count = New System.Windows.Forms.Label()
        CType(Me.Dgv_Reservation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgv_Reservation
        '
        Me.Dgv_Reservation.AllowUserToAddRows = False
        Me.Dgv_Reservation.AllowUserToDeleteRows = False
        Me.Dgv_Reservation.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Dgv_Reservation.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Reservation.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Reservation.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Reservation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Reservation.ColumnHeadersHeight = 30
        Me.Dgv_Reservation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientID, Me.PatientName, Me.PhoneNumber, Me.Code, Me.ReserveDate, Me.VisitName, Me.VisitCost, Me.OpenVisit, Me.Delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Reservation.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Reservation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Dgv_Reservation.Location = New System.Drawing.Point(0, 68)
        Me.Dgv_Reservation.Name = "Dgv_Reservation"
        Me.Dgv_Reservation.RowHeadersVisible = False
        Me.Dgv_Reservation.RowTemplate.Height = 25
        Me.Dgv_Reservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Reservation.Size = New System.Drawing.Size(1159, 640)
        Me.Dgv_Reservation.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reserve Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(460, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Visit Type"
        '
        'Dtp_ReserveDate
        '
        Me.Dtp_ReserveDate.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Dtp_ReserveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_ReserveDate.Location = New System.Drawing.Point(137, 20)
        Me.Dtp_ReserveDate.Name = "Dtp_ReserveDate"
        Me.Dtp_ReserveDate.Size = New System.Drawing.Size(171, 25)
        Me.Dtp_ReserveDate.TabIndex = 3
        '
        'Cbo_VisitType
        '
        Me.Cbo_VisitType.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Cbo_VisitType.FormattingEnabled = True
        Me.Cbo_VisitType.Items.AddRange(New Object() {" "})
        Me.Cbo_VisitType.Location = New System.Drawing.Point(554, 20)
        Me.Cbo_VisitType.Name = "Cbo_VisitType"
        Me.Cbo_VisitType.Size = New System.Drawing.Size(209, 26)
        Me.Cbo_VisitType.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(895, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Visit Count"
        '
        'Lbl_Count
        '
        Me.Lbl_Count.BackColor = System.Drawing.Color.Maroon
        Me.Lbl_Count.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Lbl_Count.ForeColor = System.Drawing.Color.White
        Me.Lbl_Count.Location = New System.Drawing.Point(999, 17)
        Me.Lbl_Count.Name = "Lbl_Count"
        Me.Lbl_Count.Size = New System.Drawing.Size(148, 33)
        Me.Lbl_Count.TabIndex = 6
        Me.Lbl_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_ManageReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1159, 708)
        Me.Controls.Add(Me.Lbl_Count)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cbo_VisitType)
        Me.Controls.Add(Me.Dtp_ReserveDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dgv_Reservation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_ManageReservation"
        Me.Text = "Manage Reservation"
        CType(Me.Dgv_Reservation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgv_Reservation As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Dtp_ReserveDate As DateTimePicker
    Friend WithEvents Cbo_VisitType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_Count As Label
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumber As DataGridViewTextBoxColumn
    Friend WithEvents Code As DataGridViewTextBoxColumn
    Friend WithEvents ReserveDate As DataGridViewTextBoxColumn
    Friend WithEvents VisitName As DataGridViewTextBoxColumn
    Friend WithEvents VisitCost As DataGridViewTextBoxColumn
    Friend WithEvents OpenVisit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
