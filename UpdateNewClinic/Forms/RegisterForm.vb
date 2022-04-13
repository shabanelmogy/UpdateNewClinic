Imports System.Management
Imports Microsoft.Win32
Imports System.Security.AccessControl
Imports System.Text
Imports System.Security.Cryptography


Public Class RegisterForm
    ' سنقوم بإنشاء دالة تحمل قيمة ترجع لنا بالرقم التعريفي للمعالج
    ' علما أن الرقم التعريفي لا يتكرر في أي معالج آخر فهو بمثابة البصمة
    Public Function Board_Serial()
        Dim bval As String = ""
        Dim mos As New ManagementObjectSearcher("Select * from Win32_BaseBoard")
        Dim mo As New ManagementObject
        For Each mo In mos.Get
            bval = mo("SerialNumber").ToString
        Next
        Return bval
        ' هذه الدالة ترجع لنا الرقم التسلسلي للوحة الأم
    End Function

    Public Function Hard_Serial()
        Dim bval As String = ""
        Dim mos As New ManagementObjectSearcher("Select * from Win32_DiskDrive")
        Dim mo As New ManagementObject
        For Each mo In mos.Get
            bval = mo("SerialNumber").ToString
        Next
        Return bval
        ' هذه الدالة ترجع لنا الرقم التسلسلي للقرص الصلب
    End Function

    Public Function Get_ID()
        Dim val As String = ""
        Dim mos As New ManagementObjectSearcher("Select * from Win32_Processor")
        Dim mo As New ManagementObject
        For Each mo In mos.Get
            val = mo("ProcessorID").ToString
        Next
        ' سنقوم بالتعديل على القيمة التي ترجعها لنا هذه الدالة حيث سنضيف لها الرقم التسلسلي للوحة الأم
        Return md5hash(val + Board_Serial() + Hard_Serial()) ' هذه القيمة تحمل الرقم التسلسلي للمعالج واللوحة الأم والقرص الصلب
        ' نفس النتيجة إذن المعادلة صحيحة
    End Function

    Private Sub FrmGetID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' سنقوم بعرض الرقم التعريفي للمعالج عند تحميل الفورم
        TxtID.Clear()
        TxtID.Text = Get_ID()
        Txt_CheckKey.Text = md5hash(TxtID.Text + "Shaban")
        Txt_Windows.Text = My.Computer.Info.OSFullName
        Txt_CompName.Text = System.Environment.MachineName

    End Sub

    ' سنقوم بإنشاء الدالة التي نستخدمها في توليد المفتاح
    Public Function md5hash(txt As String)
        Dim md5 As MD5 = New MD5CryptoServiceProvider
        md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(txt))
        Dim reslt As Byte() = md5.Hash
        Dim strbuilder As New StringBuilder
        For i As Integer = 0 To reslt.Length - 1
            strbuilder.Append(reslt(i).ToString("x2"))
        Next
        ' كذلك نستطيع أن نقسم الرقم التعريفي إلى عدة أجزاء لجعله أكثر احترافية وتعقيدا
        Dim ss As String = strbuilder.ToString
        Dim newss As String = ss.Substring(0, 4) + "-" + ss.Substring(4, 4) + "-" + ss.Substring(8, 4) + "-" + ss.Substring(12, 4) + "-" + ss.Substring(16, 4)
        'الحروف الصغيرة هذه نحولها لأحرف كبيرة
        Return newss.ToUpper
        ' نفس المعادلة السابقة نستخدمها في توليد المفتاح
    End Function

    Private Sub Btn_Validate_Click(sender As Object, e As EventArgs) Handles Btn_Validate.Click

        If Txt_Validate.Text = Txt_CheckKey.Text Then
            Dim x As String = Txt_Validate.Text
            Dim Activekey As RegistryKey
            Activekey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
            Activekey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Sys", True)
            If Activekey Is Nothing Then
                Activekey = Registry.LocalMachine.OpenSubKey("SOFTWARE", True)
                Activekey.CreateSubKey("Sys")

                Activekey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Sys", True)
                Activekey.SetValue("System_Key", x)
                Activekey.Close()
            End If
            MsgBox("Registered Successfuly" & Environment.NewLine & "Open Apllication Again", MsgBoxStyle.Information, "Info")
            Me.Close()
        Else
            MsgBox("Invalid Key Register", MsgBoxStyle.Information, "Info")
            Application.Exit()
        End If
    End Sub
End Class