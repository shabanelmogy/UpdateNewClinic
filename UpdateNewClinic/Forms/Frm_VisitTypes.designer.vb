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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_ExportExcel = New System.Windows.Forms.Button()
        Me.Btn_DeletePatient = New System.Windows.Forms.Button()
        Me.Btn_ExitNewPatient = New System.Windows.Forms.Button()
        Me.Btn_SaveNewVisit = New System.Windows.Forms.Button()
        Me.Btn_AddNewVisit = New System.Windows.Forms.Button()
        Me.DgvVisits = New System.Windows.Forms.DataGridView()
        Me.Panel3.SuspendLayout()
        CType(Me.DgvVisits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Btn_ExportExcel)
        Me.Panel3.Controls.Add(Me.Btn_DeletePatient)
        Me.Panel3.Controls.Add(Me.Btn_ExitNewPatient)
        Me.Panel3.Controls.Add(Me.Btn_SaveNewVisit)
        Me.Panel3.Controls.Add(Me.Btn_AddNewVisit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 376)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(654, 66)
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
        Me.Btn_ExportExcel.Location = New System.Drawing.Point(403, 13)
        Me.Btn_ExportExcel.Name = "Btn_ExportExcel"
        Me.Btn_ExportExcel.Size = New System.Drawing.Size(112, 37)
        Me.Btn_ExportExcel.TabIndex = 21
        Me.Btn_ExportExcel.Text = "Export Excel"
        Me.Btn_ExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_ExportExcel.UseVisualStyleBackColor = False
        '
        'Btn_DeletePatient
        '
        Me.Btn_DeletePatient.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_DeletePatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_DeletePatient.FlatAppearance.BorderSize = 0
        Me.Btn_DeletePatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_DeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_DeletePatient.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_DeletePatient.ForeColor = System.Drawing.Color.White
        Me.Btn_DeletePatient.Image = Global.UpdateNewClinic.My.Resources.Resources.Delete
        Me.Btn_DeletePatient.Location = New System.Drawing.Point(276, 13)
        Me.Btn_DeletePatient.Name = "Btn_DeletePatient"
        Me.Btn_DeletePatient.Size = New System.Drawing.Size(102, 37)
        Me.Btn_DeletePatient.TabIndex = 15
        Me.Btn_DeletePatient.Text = "Del"
        Me.Btn_DeletePatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_DeletePatient.UseVisualStyleBackColor = False
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
        Me.Btn_ExitNewPatient.Location = New System.Drawing.Point(540, 13)
        Me.Btn_ExitNewPatient.Name = "Btn_ExitNewPatient"
        Me.Btn_ExitNewPatient.Size = New System.Drawing.Size(99, 37)
        Me.Btn_ExitNewPatient.TabIndex = 13
        Me.Btn_ExitNewPatient.Text = "Exit"
        Me.Btn_ExitNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.Btn_SaveNewVisit.Location = New System.Drawing.Point(144, 13)
        Me.Btn_SaveNewVisit.Name = "Btn_SaveNewVisit"
        Me.Btn_SaveNewVisit.Size = New System.Drawing.Size(107, 37)
        Me.Btn_SaveNewVisit.TabIndex = 13
        Me.Btn_SaveNewVisit.Text = "Save"
        Me.Btn_SaveNewVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        Me.Btn_AddNewVisit.Size = New System.Drawing.Size(110, 37)
        Me.Btn_AddNewVisit.TabIndex = 13
        Me.Btn_AddNewVisit.Text = "New"
        Me.Btn_AddNewVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_AddNewVisit.UseVisualStyleBackColor = False
        '
        'DgvVisits
        '
        Me.DgvVisits.AllowUserToAddRows = False
        Me.DgvVisits.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.AliceBlue
        Me.DgvVisits.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvVisits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVisits.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DgvVisits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvVisits.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DgvVisits.ColumnHeadersHeight = 27
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Snow
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvVisits.DefaultCellStyle = DataGridViewCellStyle15
        Me.DgvVisits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvVisits.EnableHeadersVisualStyles = False
        Me.DgvVisits.Location = New System.Drawing.Point(0, 0)
        Me.DgvVisits.Name = "DgvVisits"
        Me.DgvVisits.RowHeadersVisible = False
        Me.DgvVisits.RowTemplate.Height = 25
        Me.DgvVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVisits.Size = New System.Drawing.Size(654, 376)
        Me.DgvVisits.TabIndex = 31
        '
        'Frm_VisitTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 442)
        Me.Controls.Add(Me.DgvVisits)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Frm_VisitTypes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Visits Types"
        Me.Panel3.ResumeLayout(False)
        CType(Me.DgvVisits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_DeletePatient As Button
    Friend WithEvents Btn_ExitNewPatient As Button
    Friend WithEvents Btn_SaveNewVisit As Button
    Friend WithEvents Btn_AddNewVisit As Button
    Friend WithEvents DgvVisits As DataGridView
    Friend WithEvents Btn_ExportExcel As Button
End Class
