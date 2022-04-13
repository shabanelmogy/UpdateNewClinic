Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Server
Imports Microsoft.SqlServer.Management.Smo.ServerProxyAccount
Imports Microsoft.SqlServer.Management.Common
Imports System.IO

Public Class Frm_Sql_Setting
    Public cmd As SqlCommand
    Public rdr As SqlDataReader = Nothing
    Dim st As String
    Dim SqlConnStr As String

    Public Sub loadserver(ByVal combo As ComboBox)
        combo.Items.Clear()
        Try
            Dim localmachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
            Dim rk = localmachine.OpenSubKey("SOFTWARE\microsoft\microsoft sql server")
            Dim instances = CType(rk.GetValue("installedinstances"), String())
            If instances.Length > 0 Then
                For Each element As String In instances
                    If element = "MSSQLSERVER" Then
                        combo.Items.Add(System.Environment.MachineName)
                    Else
                        combo.Items.Add(System.Environment.MachineName + "\" + element)
                    End If
                Next element
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Frm_Sql_Setting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadserver(cmbServerName)
    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        If lblSet.Text = "Main Form" Then
            Me.Close()
        Else
            If MsgBox("Do you want to close the application....", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                End
            End If
        End If
    End Sub

    Private Sub btnTestConnection_Click(sender As System.Object, e As System.EventArgs) Handles btnTestConnection.Click
        If cmbServerName.Text = "" Then
            MsgBox("الرجاء اختيار اسم السيرفر", MsgBoxStyle.Information)
            cmbServerName.Focus()
            Exit Sub
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            If txtUserName.Text.Length = 0 Then
                MsgBox("الرجاء ادخال اسم المستخدم", MsgBoxStyle.Information)
                txtUserName.Focus()
                Exit Sub
            End If
            If txtPassword.Text.Length = 0 Then
                MsgBox("الرجاء ادخال كلمة المرور", MsgBoxStyle.Information)
                txtPassword.Focus()
                Exit Sub
            End If
        End If
        Cursor = Cursors.WaitCursor
        Timer2.Enabled = True
        Dim SqlConn As New SqlConnection

        If cmbAuthentication.SelectedIndex = 0 Then
            SqlConnStr = "Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;Integrated Security=True"
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            SqlConnStr = "Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ""
        End If
        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.ConnectionString = SqlConnStr
            Try
                SqlConn.Open()
                MessageBox.Show("تمت عملية الاتصال بنجاح", "فحص الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("فشل الاتصال بالسيرفر" + vbCrLf + Err.Description, "فحص الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If cmbServerName.Text = "" Then
                MsgBox("الرجاء اختيار اسم السيرفر", MsgBoxStyle.Information)
                cmbServerName.Focus()
                Exit Sub
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                If txtUserName.Text.Length = 0 Then
                    MsgBox("الرجاء ادخال اسم المستخدم", MsgBoxStyle.Information)
                    txtUserName.Focus()
                    Exit Sub
                End If
                If txtPassword.Text.Length = 0 Then
                    MsgBox("الرجاء ادخال كلمة المرور", MsgBoxStyle.Information)
                    txtPassword.Focus()
                    Exit Sub
                End If
            End If
            Cursor = Cursors.WaitCursor
            Timer2.Enabled = True
            If cmbAuthentication.SelectedIndex = 0 Then
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True") 'MultipleActiveResultSets=True
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                con = New SqlConnection("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & "") 'MultipleActiveResultSets=True
            End If
            Con.Open()
            If (Con.State = ConnectionState.Open) Then
                If MsgBox("اذا اخترت نعم سيتم انشاء قاعدة البيانات بالسيرفر, هل تريد الاستمرار ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then


                    CreateBlankDB()
                    MessageBox.Show("تم انشاء قاعدة البيانات بالسيرفر بنجاح..." & vbCrLf & "الرجاء اغلاق البرنامج وفتحه من جديد", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("فشل بالاتصال بالسيرفرr" + vbCrLf + Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Finally
            If (Con.State = ConnectionState.Open) Then
                Con.Close()
            End If
        End Try
    End Sub

    Sub CreateBlankDB()
        Try
            con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True")
            con.Open()
            Dim sql As String = "Select * from sysdatabases where name='Clinic'"
                cmd = New SqlCommand(sql)
            cmd.Connection = Con
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True")
                con.Open()
                Dim cb1 As String = "Drop Database Clinic"
                cmd = New SqlCommand(cb1)
                cmd.Connection = Con
                cmd.ExecuteNonQuery()
                Con.Close()
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True")
                con.Open()
                Dim sql2 As String = "Create Database Clinic"
                cmd = New SqlCommand(sql2)
                cmd.Connection = Con
                cmd.ExecuteNonQuery()
                Con.Close()
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DBscript.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(Con))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            Else
                con = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True")
                con.Open()
                Dim cb3 As String = "Create Database Clinic"
                cmd = New SqlCommand(cb3)
                cmd.Connection = Con
                cmd.ExecuteNonQuery()
                Con.Close()
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DBscript.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(Con))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (Con.State = ConnectionState.Open) Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Cursor = Cursors.Default
        Timer2.Enabled = False
    End Sub

    Private Sub cmbAuthentication_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbAuthentication.SelectedIndexChanged
        If cmbAuthentication.SelectedIndex = 0 Then
            txtUserName.ReadOnly = True
            txtPassword.ReadOnly = True
            txtUserName.Text = ""
            txtPassword.Text = ""
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            txtUserName.ReadOnly = False
            txtPassword.ReadOnly = False
        End If
    End Sub

    Private Sub cmbServerName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbServerName.SelectedIndexChanged
        cmbAuthentication.Enabled = True
    End Sub
    Sub Reset()
        txtPassword.Text = ""
        txtUserName.Text = ""

        cmbAuthentication.SelectedIndex = 0

    End Sub
End Class