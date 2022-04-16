<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_VisitTypes
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_ExportExcel = New System.Windows.Forms.Button()
        Me.Btn_DeleteVisitType = New System.Windows.Forms.Button()
        Me.Btn_ExitNewPatient = New System.Windows.Forms.Button()
        Me.Btn_SaveNewVisit = New System.Windows.Forms.Button()
        Me.Btn_AddNewVisit = New System.Windows.Forms.Button()
        Me.Dgv_VisitType = New System.Windows.Forms.DataGridView()
        Me.Info = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3.SuspendLayout()
        CType(Me.Dgv_VisitType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Btn_ExportExcel)
        Me.Panel3.Controls.Add(Me.Btn_DeleteVisitType)
        Me.Panel3.Controls.Add(Me.Btn_ExitNewPatient)
        Me.Panel3.Controls.Add(Me.Btn_SaveNewVisit)
        Me.Panel3.Controls.Add(Me.Btn_AddNewVisit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 326)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(457, 66)
        Me.Panel3.TabIndex = 27
        '
        'Btn_ExportExcel
        '
        Me.Btn_ExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_ExportExcel.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_ExportExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ExportExcel.FlatAppearance.BorderSize = 0
        Me.Btn_ExportExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_ExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ExportExcel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ExportExcel.ForeColor = System.Drawing.Color.White
        Me.Btn_ExportExcel.Image = Global.UpdateNewClinic.My.Resources.Resources.ExportToExcel
        Me.Btn_ExportExcel.Location = New System.Drawing.Point(282, 13)
        Me.Btn_ExportExcel.Name = "Btn_ExportExcel"
        Me.Btn_ExportExcel.Size = New System.Drawing.Size(71, 37)
        Me.Btn_ExportExcel.TabIndex = 21
        Me.Btn_ExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Info.SetToolTip(Me.Btn_ExportExcel, "Export Excel")
        Me.Btn_ExportExcel.UseVisualStyleBackColor = False
        '
        'Btn_DeleteVisitType
        '
        Me.Btn_DeleteVisitType.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_DeleteVisitType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_DeleteVisitType.FlatAppearance.BorderSize = 0
        Me.Btn_DeleteVisitType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_DeleteVisitType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_DeleteVisitType.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_DeleteVisitType.ForeColor = System.Drawing.Color.White
        Me.Btn_DeleteVisitType.Image = Global.UpdateNewClinic.My.Resources.Resources.Delete
        Me.Btn_DeleteVisitType.Location = New System.Drawing.Point(191, 13)
        Me.Btn_DeleteVisitType.Name = "Btn_DeleteVisitType"
        Me.Btn_DeleteVisitType.Size = New System.Drawing.Size(71, 37)
        Me.Btn_DeleteVisitType.TabIndex = 15
        Me.Btn_DeleteVisitType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Info.SetToolTip(Me.Btn_DeleteVisitType, "Delete Visit Type")
        Me.Btn_DeleteVisitType.UseVisualStyleBackColor = False
        '
        'Btn_ExitNewPatient
        '
        Me.Btn_ExitNewPatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_ExitNewPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_ExitNewPatient.FlatAppearance.BorderSize = 0
        Me.Btn_ExitNewPatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_ExitNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ExitNewPatient.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_ExitNewPatient.ForeColor = System.Drawing.Color.White
        Me.Btn_ExitNewPatient.Image = Global.UpdateNewClinic.My.Resources.Resources.ExitFrm
        Me.Btn_ExitNewPatient.Location = New System.Drawing.Point(373, 13)
        Me.Btn_ExitNewPatient.Name = "Btn_ExitNewPatient"
        Me.Btn_ExitNewPatient.Size = New System.Drawing.Size(71, 37)
        Me.Btn_ExitNewPatient.TabIndex = 13
        Me.Btn_ExitNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Info.SetToolTip(Me.Btn_ExitNewPatient, "Exit ")
        Me.Btn_ExitNewPatient.UseVisualStyleBackColor = False
        '
        'Btn_SaveNewVisit
        '
        Me.Btn_SaveNewVisit.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_SaveNewVisit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_SaveNewVisit.FlatAppearance.BorderSize = 0
        Me.Btn_SaveNewVisit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_SaveNewVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_SaveNewVisit.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_SaveNewVisit.ForeColor = System.Drawing.Color.White
        Me.Btn_SaveNewVisit.Image = Global.UpdateNewClinic.My.Resources.Resources.Save
        Me.Btn_SaveNewVisit.Location = New System.Drawing.Point(100, 13)
        Me.Btn_SaveNewVisit.Name = "Btn_SaveNewVisit"
        Me.Btn_SaveNewVisit.Size = New System.Drawing.Size(71, 37)
        Me.Btn_SaveNewVisit.TabIndex = 13
        Me.Btn_SaveNewVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Info.SetToolTip(Me.Btn_SaveNewVisit, "Save Visit Type")
        Me.Btn_SaveNewVisit.UseVisualStyleBackColor = False
        '
        'Btn_AddNewVisit
        '
        Me.Btn_AddNewVisit.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_AddNewVisit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_AddNewVisit.FlatAppearance.BorderSize = 0
        Me.Btn_AddNewVisit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_AddNewVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AddNewVisit.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_AddNewVisit.ForeColor = System.Drawing.Color.White
        Me.Btn_AddNewVisit.Image = Global.UpdateNewClinic.My.Resources.Resources.AddNew
        Me.Btn_AddNewVisit.Location = New System.Drawing.Point(9, 13)
        Me.Btn_AddNewVisit.Name = "Btn_AddNewVisit"
        Me.Btn_AddNewVisit.Size = New System.Drawing.Size(71, 37)
        Me.Btn_AddNewVisit.TabIndex = 13
        Me.Btn_AddNewVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Info.SetToolTip(Me.Btn_AddNewVisit, "Add New Visit Type")
        Me.Btn_AddNewVisit.UseVisualStyleBackColor = False
        '
        'Dgv_VisitType
        '
        Me.Dgv_VisitType.AllowUserToAddRows = False
        Me.Dgv_VisitType.AllowUserToDeleteRows = False
        Me.Dgv_VisitType.AllowUserToResizeColumns = False
        Me.Dgv_VisitType.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.Dgv_VisitType.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_VisitType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_VisitType.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Dgv_VisitType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_VisitType.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_VisitType.ColumnHeadersHeight = 27
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Linen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_VisitType.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_VisitType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_VisitType.EnableHeadersVisualStyles = False
        Me.Dgv_VisitType.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_VisitType.Name = "Dgv_VisitType"
        Me.Dgv_VisitType.RowHeadersVisible = False
        Me.Dgv_VisitType.RowTemplate.Height = 25
        Me.Dgv_VisitType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_VisitType.Size = New System.Drawing.Size(457, 326)
        Me.Dgv_VisitType.TabIndex = 31
        '
        'Frm_VisitTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 392)
        Me.Controls.Add(Me.Dgv_VisitType)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frm_VisitTypes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Visits Types"
        Me.Panel3.ResumeLayout(False)
        CType(Me.Dgv_VisitType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_DeleteVisitType As Button
    Friend WithEvents Btn_ExitNewPatient As Button
    Friend WithEvents Btn_SaveNewVisit As Button
    Friend WithEvents Btn_AddNewVisit As Button
    Friend WithEvents Dgv_VisitType As DataGridView
    Friend WithEvents Btn_ExportExcel As Button
    Friend WithEvents Info As ToolTip
End Class
