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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_PatientName = New System.Windows.Forms.TextBox()
        Me.Dtp_PatientFirstDate = New System.Windows.Forms.DateTimePicker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_SortAsec = New System.Windows.Forms.Button()
        Me.Cbo_SortAndSearch = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cbo_ReserveType = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Btn_SaveNewPatient = New System.Windows.Forms.Button()
        Me.Btn_SortDesc = New System.Windows.Forms.Button()
        Me.Btn_DeletePatient = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 28)
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
        Me.Label7.Location = New System.Drawing.Point(11, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 27)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Reserve Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_PatientName
        '
        Me.Txt_PatientName.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.Txt_PatientName.Location = New System.Drawing.Point(127, 9)
        Me.Txt_PatientName.Name = "Txt_PatientName"
        Me.Txt_PatientName.Size = New System.Drawing.Size(401, 28)
        Me.Txt_PatientName.TabIndex = 4
        Me.Txt_PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Dtp_PatientFirstDate
        '
        Me.Dtp_PatientFirstDate.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_PatientFirstDate.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Dtp_PatientFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_PatientFirstDate.Location = New System.Drawing.Point(127, 65)
        Me.Dtp_PatientFirstDate.Name = "Dtp_PatientFirstDate"
        Me.Dtp_PatientFirstDate.Size = New System.Drawing.Size(122, 27)
        Me.Dtp_PatientFirstDate.TabIndex = 12
        Me.Dtp_PatientFirstDate.Value = New Date(2022, 4, 4, 0, 0, 0, 0)
        '
        'Btn_SortAsec
        '
        Me.Btn_SortAsec.BackColor = System.Drawing.Color.White
        Me.Btn_SortAsec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SortAsec.FlatAppearance.BorderSize = 0
        Me.Btn_SortAsec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell
        Me.Btn_SortAsec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SortAsec.Image = Global.UpdateNewClinic.My.Resources.Resources.SortAscending_24
        Me.Btn_SortAsec.Location = New System.Drawing.Point(441, 8)
        Me.Btn_SortAsec.Name = "Btn_SortAsec"
        Me.Btn_SortAsec.Size = New System.Drawing.Size(60, 27)
        Me.Btn_SortAsec.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.Btn_SortAsec, "Sort Asc")
        Me.Btn_SortAsec.UseVisualStyleBackColor = False
        '
        'Cbo_SortAndSearch
        '
        Me.Cbo_SortAndSearch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Cbo_SortAndSearch.FormattingEnabled = True
        Me.Cbo_SortAndSearch.Items.AddRange(New Object() {"PatientName", "Phone"})
        Me.Cbo_SortAndSearch.Location = New System.Drawing.Point(158, 8)
        Me.Cbo_SortAndSearch.Name = "Cbo_SortAndSearch"
        Me.Cbo_SortAndSearch.Size = New System.Drawing.Size(235, 27)
        Me.Cbo_SortAndSearch.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.SteelBlue
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(19, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 27)
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
        Me.Label4.Location = New System.Drawing.Point(257, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 27)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Reserve Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cbo_ReserveType
        '
        Me.Cbo_ReserveType.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Cbo_ReserveType.FormattingEnabled = True
        Me.Cbo_ReserveType.Location = New System.Drawing.Point(373, 65)
        Me.Cbo_ReserveType.Name = "Cbo_ReserveType"
        Me.Cbo_ReserveType.Size = New System.Drawing.Size(156, 27)
        Me.Cbo_ReserveType.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(19, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 27)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Search Value"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Search.FlatAppearance.BorderSize = 0
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Search.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Search.ForeColor = System.Drawing.Color.White
        Me.Btn_Search.Image = Global.UpdateNewClinic.My.Resources.Resources.searching
        Me.Btn_Search.Location = New System.Drawing.Point(441, 64)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(123, 29)
        Me.Btn_Search.TabIndex = 37
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Txt_Search.Location = New System.Drawing.Point(158, 66)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(235, 27)
        Me.Txt_Search.TabIndex = 36
        '
        'Btn_SaveNewPatient
        '
        Me.Btn_SaveNewPatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_SaveNewPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SaveNewPatient.Enabled = False
        Me.Btn_SaveNewPatient.FlatAppearance.BorderSize = 0
        Me.Btn_SaveNewPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_SaveNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_SaveNewPatient.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SaveNewPatient.ForeColor = System.Drawing.Color.White
        Me.Btn_SaveNewPatient.Image = Global.UpdateNewClinic.My.Resources.Resources.Save
        Me.Btn_SaveNewPatient.Location = New System.Drawing.Point(600, 8)
        Me.Btn_SaveNewPatient.Name = "Btn_SaveNewPatient"
        Me.Btn_SaveNewPatient.Size = New System.Drawing.Size(131, 36)
        Me.Btn_SaveNewPatient.TabIndex = 13
        Me.Btn_SaveNewPatient.Text = "Save"
        Me.Btn_SaveNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_SaveNewPatient.UseVisualStyleBackColor = False
        '
        'Btn_SortDesc
        '
        Me.Btn_SortDesc.BackColor = System.Drawing.Color.White
        Me.Btn_SortDesc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SortDesc.FlatAppearance.BorderSize = 0
        Me.Btn_SortDesc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell
        Me.Btn_SortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SortDesc.Image = Global.UpdateNewClinic.My.Resources.Resources.SortDesc_24
        Me.Btn_SortDesc.Location = New System.Drawing.Point(507, 8)
        Me.Btn_SortDesc.Name = "Btn_SortDesc"
        Me.Btn_SortDesc.Size = New System.Drawing.Size(57, 27)
        Me.Btn_SortDesc.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.Btn_SortDesc, "Sort Desc")
        Me.Btn_SortDesc.UseVisualStyleBackColor = False
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
        Me.Btn_DeletePatient.Location = New System.Drawing.Point(600, 55)
        Me.Btn_DeletePatient.Name = "Btn_DeletePatient"
        Me.Btn_DeletePatient.Size = New System.Drawing.Size(131, 36)
        Me.Btn_DeletePatient.TabIndex = 15
        Me.Btn_DeletePatient.Text = "Delete"
        Me.Btn_DeletePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_DeletePatient.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.SeparatorControl2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Cbo_ReserveType)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Btn_SaveNewPatient)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Dtp_PatientFirstDate)
        Me.Panel1.Controls.Add(Me.Btn_DeletePatient)
        Me.Panel1.Controls.Add(Me.Txt_PatientName)
        Me.Panel1.Location = New System.Drawing.Point(583, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 683)
        Me.Panel1.TabIndex = 38
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.SeparatorControl1)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Btn_SortAsec)
        Me.Panel2.Controls.Add(Me.Txt_Search)
        Me.Panel2.Controls.Add(Me.Btn_Search)
        Me.Panel2.Controls.Add(Me.Btn_SortDesc)
        Me.Panel2.Controls.Add(Me.Cbo_SortAndSearch)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(577, 683)
        Me.Panel2.TabIndex = 39
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.LineColor = System.Drawing.Color.Maroon
        Me.SeparatorControl1.Location = New System.Drawing.Point(10, 99)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(560, 23)
        Me.SeparatorControl1.TabIndex = 38
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl2.LineColor = System.Drawing.Color.Maroon
        Me.SeparatorControl2.Location = New System.Drawing.Point(3, 99)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(728, 23)
        Me.SeparatorControl2.TabIndex = 39
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(567, 548)
        Me.DataGridView1.TabIndex = 39
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(-2, 128)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(742, 548)
        Me.DataGridView2.TabIndex = 40
        '
        'Frm_Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1328, 685)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Name = "Frm_Reservation"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "New Reserve"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_PatientName As TextBox
    Friend WithEvents Dtp_PatientFirstDate As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Btn_SortAsec As Button
    Friend WithEvents Cbo_SortAndSearch As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cbo_ReserveType As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Btn_SaveNewPatient As Button
    Friend WithEvents Btn_SortDesc As Button
    Friend WithEvents Btn_DeletePatient As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
End Class
