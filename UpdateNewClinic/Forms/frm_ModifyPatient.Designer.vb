<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ModifyPatient
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
        Me.components = New System.ComponentModel.Container()
        Me.Txt_Age = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txt_StartWeight = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Dtp_PatientFirstDate = New System.Windows.Forms.DateTimePicker()
        Me.Txt_Height = New System.Windows.Forms.TextBox()
        Me.Txt_PhoneNumber = New System.Windows.Forms.TextBox()
        Me.Txt_Occupation = New System.Windows.Forms.TextBox()
        Me.Txt_Code = New System.Windows.Forms.TextBox()
        Me.Txt_PatientNum = New System.Windows.Forms.TextBox()
        Me.Txt_PatientName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Lbl_Age = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_SaveNewPatient = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Age
        '
        Me.Txt_Age.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Txt_Age.Location = New System.Drawing.Point(118, 192)
        Me.Txt_Age.Name = "Txt_Age"
        Me.Txt_Age.Size = New System.Drawing.Size(140, 25)
        Me.Txt_Age.TabIndex = 39
        Me.Txt_Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.Controls.Add(Me.Btn_SaveNewPatient)
        Me.Panel3.Location = New System.Drawing.Point(1, 272)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(536, 56)
        Me.Panel3.TabIndex = 45
        '
        'Txt_StartWeight
        '
        Me.Txt_StartWeight.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Txt_StartWeight.Location = New System.Drawing.Point(378, 238)
        Me.Txt_StartWeight.Name = "Txt_StartWeight"
        Me.Txt_StartWeight.Size = New System.Drawing.Size(150, 25)
        Me.Txt_StartWeight.TabIndex = 43
        Me.Txt_StartWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.SteelBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(274, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 25)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "StartWeight"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dtp_PatientFirstDate
        '
        Me.Dtp_PatientFirstDate.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_PatientFirstDate.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Dtp_PatientFirstDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_PatientFirstDate.Location = New System.Drawing.Point(378, 192)
        Me.Dtp_PatientFirstDate.Name = "Dtp_PatientFirstDate"
        Me.Dtp_PatientFirstDate.Size = New System.Drawing.Size(150, 25)
        Me.Dtp_PatientFirstDate.TabIndex = 40
        Me.Dtp_PatientFirstDate.Value = New Date(2022, 4, 7, 0, 0, 0, 0)
        '
        'Txt_Height
        '
        Me.Txt_Height.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Txt_Height.Location = New System.Drawing.Point(118, 238)
        Me.Txt_Height.Name = "Txt_Height"
        Me.Txt_Height.Size = New System.Drawing.Size(140, 25)
        Me.Txt_Height.TabIndex = 41
        Me.Txt_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_PhoneNumber
        '
        Me.Txt_PhoneNumber.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Txt_PhoneNumber.Location = New System.Drawing.Point(378, 146)
        Me.Txt_PhoneNumber.MaxLength = 11
        Me.Txt_PhoneNumber.Name = "Txt_PhoneNumber"
        Me.Txt_PhoneNumber.Size = New System.Drawing.Size(150, 25)
        Me.Txt_PhoneNumber.TabIndex = 29
        Me.Txt_PhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Occupation
        '
        Me.Txt_Occupation.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Txt_Occupation.Location = New System.Drawing.Point(116, 100)
        Me.Txt_Occupation.Name = "Txt_Occupation"
        Me.Txt_Occupation.Size = New System.Drawing.Size(412, 25)
        Me.Txt_Occupation.TabIndex = 38
        Me.Txt_Occupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Code
        '
        Me.Txt_Code.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Txt_Code.Location = New System.Drawing.Point(118, 146)
        Me.Txt_Code.Name = "Txt_Code"
        Me.Txt_Code.Size = New System.Drawing.Size(140, 25)
        Me.Txt_Code.TabIndex = 37
        Me.Txt_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_PatientNum
        '
        Me.Txt_PatientNum.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Txt_PatientNum.Location = New System.Drawing.Point(117, 8)
        Me.Txt_PatientNum.Name = "Txt_PatientNum"
        Me.Txt_PatientNum.ReadOnly = True
        Me.Txt_PatientNum.Size = New System.Drawing.Size(141, 25)
        Me.Txt_PatientNum.TabIndex = 27
        Me.Txt_PatientNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_PatientName
        '
        Me.Txt_PatientName.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Txt_PatientName.Location = New System.Drawing.Point(117, 54)
        Me.Txt_PatientName.Name = "Txt_PatientName"
        Me.Txt_PatientName.Size = New System.Drawing.Size(411, 25)
        Me.Txt_PatientName.TabIndex = 31
        Me.Txt_PatientName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(12, 238)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 25)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Height"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(274, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 25)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "TheFirstDate"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(274, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Phone"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.SteelBlue
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(12, 100)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 25)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Occupation"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Code"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Age
        '
        Me.Lbl_Age.BackColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Age.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Age.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_Age.Location = New System.Drawing.Point(12, 192)
        Me.Lbl_Age.Name = "Lbl_Age"
        Me.Lbl_Age.Size = New System.Drawing.Size(106, 25)
        Me.Lbl_Age.TabIndex = 32
        Me.Lbl_Age.Text = "Age"
        Me.Lbl_Age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "PatientNum"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "PatientName"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Btn_SaveNewPatient.Location = New System.Drawing.Point(377, 9)
        Me.Btn_SaveNewPatient.Name = "Btn_SaveNewPatient"
        Me.Btn_SaveNewPatient.Size = New System.Drawing.Size(148, 35)
        Me.Btn_SaveNewPatient.TabIndex = 13
        Me.Btn_SaveNewPatient.Text = "Save"
        Me.Btn_SaveNewPatient.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_SaveNewPatient.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 328)
        Me.Splitter1.TabIndex = 46
        Me.Splitter1.TabStop = False
        '
        'frm_ModifyPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(538, 328)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Txt_Age)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Txt_StartWeight)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Dtp_PatientFirstDate)
        Me.Controls.Add(Me.Txt_Height)
        Me.Controls.Add(Me.Txt_PhoneNumber)
        Me.Controls.Add(Me.Txt_Occupation)
        Me.Controls.Add(Me.Txt_Code)
        Me.Controls.Add(Me.Txt_PatientNum)
        Me.Controls.Add(Me.Txt_PatientName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lbl_Age)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "frm_ModifyPatient"
        Me.Text = "frm_ModifyPatient"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Age As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_SaveNewPatient As Button
    Friend WithEvents Txt_StartWeight As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Dtp_PatientFirstDate As DateTimePicker
    Friend WithEvents Txt_Height As TextBox
    Friend WithEvents Txt_PhoneNumber As TextBox
    Friend WithEvents Txt_Occupation As TextBox
    Friend WithEvents Txt_Code As TextBox
    Friend WithEvents Txt_PatientNum As TextBox
    Friend WithEvents Txt_PatientName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_Age As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Splitter1 As Splitter
End Class
