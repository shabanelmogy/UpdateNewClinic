<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Windows = New System.Windows.Forms.TextBox()
        Me.Txt_CompName = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Txt_Validate = New System.Windows.Forms.TextBox()
        Me.Txt_CheckKey = New System.Windows.Forms.TextBox()
        Me.Btn_Validate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(339, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "إصدار نسخة الويندز"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(339, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "إسم الجهاز"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(339, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "رقم التسجيل"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(339, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "رقم التفعيل"
        '
        'Txt_Windows
        '
        Me.Txt_Windows.Location = New System.Drawing.Point(12, 12)
        Me.Txt_Windows.Name = "Txt_Windows"
        Me.Txt_Windows.Size = New System.Drawing.Size(321, 20)
        Me.Txt_Windows.TabIndex = 6
        '
        'Txt_CompName
        '
        Me.Txt_CompName.Location = New System.Drawing.Point(12, 57)
        Me.Txt_CompName.Name = "Txt_CompName"
        Me.Txt_CompName.Size = New System.Drawing.Size(321, 20)
        Me.Txt_CompName.TabIndex = 6
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(12, 103)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(321, 20)
        Me.TxtID.TabIndex = 6
        Me.TxtID.Text = " "
        '
        'Txt_Validate
        '
        Me.Txt_Validate.Location = New System.Drawing.Point(12, 148)
        Me.Txt_Validate.Name = "Txt_Validate"
        Me.Txt_Validate.Size = New System.Drawing.Size(321, 20)
        Me.Txt_Validate.TabIndex = 6
        '
        'Txt_CheckKey
        '
        Me.Txt_CheckKey.Location = New System.Drawing.Point(12, 190)
        Me.Txt_CheckKey.Name = "Txt_CheckKey"
        Me.Txt_CheckKey.Size = New System.Drawing.Size(321, 20)
        Me.Txt_CheckKey.TabIndex = 7
        '
        'Btn_Validate
        '
        Me.Btn_Validate.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn_Validate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Validate.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Validate.ForeColor = System.Drawing.Color.White
        Me.Btn_Validate.Location = New System.Drawing.Point(12, 231)
        Me.Btn_Validate.Name = "Btn_Validate"
        Me.Btn_Validate.Size = New System.Drawing.Size(321, 37)
        Me.Btn_Validate.TabIndex = 8
        Me.Btn_Validate.Text = "تفعيل البرنامج"
        Me.Btn_Validate.UseVisualStyleBackColor = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(476, 280)
        Me.Controls.Add(Me.Btn_Validate)
        Me.Controls.Add(Me.Txt_CheckKey)
        Me.Controls.Add(Me.Txt_Validate)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Txt_CompName)
        Me.Controls.Add(Me.Txt_Windows)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_Windows As TextBox
    Friend WithEvents Txt_CompName As TextBox
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Txt_Validate As TextBox
    Friend WithEvents Txt_CheckKey As TextBox
    Friend WithEvents Btn_Validate As Button
End Class
