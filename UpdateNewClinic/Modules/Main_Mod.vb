Imports System.Data.SqlClient
Imports ClosedXML.Excel
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Module Main_Mod

    Public Cmd As New SqlCommand
    Public Query As String
    Public Da As New SqlDataAdapter
    Public Dr As SqlDataReader
    Public DtEditPatient, dtvisitDetail As New DataTable
    Public Dv As New DataView
    Public Cur As CurrencyManager

    'Public con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & newdir & "\NewClinic.mdf;Integrated Security=True;Connect Timeout=30")
    Public con As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("con").ConnectionString)


    Function GetMaxId(MaxColumn As String, TableName As String)
        Dim Maxid As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(" & MaxColumn & ") From " & TableName & "", con)
            If con.State = 1 Then con.Close()
            con.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                Maxid = If(dr.IsDBNull(0), 0, dr.GetValue(0))
                dr.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = 1 Then con.Close()
        End Try
        Return Maxid
    End Function

    Sub ResetControls(f As Object)
        For Each obj As Control In f.Controls
            If TypeOf obj Is TextBox Then
                CType(obj, TextBox).Clear()
            ElseIf TypeOf obj Is DateTimePicker Then
                CType(obj, DateTimePicker).Value = Today.ToString("dd/MM/yyyy")
            ElseIf TypeOf obj Is ComboBox Then
                CType(obj, ComboBox).SelectedIndex = -1
            End If
        Next
    End Sub

    Public Sub OpenFormInPanel(ByVal Form As Object, Pnl As Object)
        'لغلق أى شاشات أخرى تم فتحها من قبل
        'If pnl.Controls.Count > 0 Then pnl.Controls.RemoveAt(0)

        Dim fh As Form = TryCast(Form, Form)
        fh.TopLevel = False
        'fh.FormBorderStyle = FormBorderStyle.None
        'fh.Dock = DockStyle.Fill
        Pnl.Controls.Add(fh)
        'Pnl.Tag = fh
        fh.Show()
    End Sub

    Sub Fill_DataTablePatients(Query As String, frm As Form)

        cmd = New SqlCommand(Query, con)
        da = New SqlDataAdapter(cmd)
        dtEditPatient = New DataTable("Patients")
        dtEditPatient.Clear()
        Da.Fill(DtEditPatient)

        DtEditPatient.Dispose()
        da.Dispose()

        For Each row As DataRow In dtEditPatient.Rows
            For columnindex = 0 To dtEditPatient.Columns.Count - 1
                If row.IsNull(columnindex) Then
                    Dim t = dtEditPatient.Columns(columnindex).DataType
                    row(columnindex) = If(t Is GetType(String), String.Empty, Activator.CreateInstance(t))
                End If
            Next
        Next
        dv = New DataView(dtEditPatient)
        cur = CType(frm.BindingContext(dv), CurrencyManager)
    End Sub

    Sub Fill_DataTableVisitDetails(Query As String, frm As Form)

        cmd = New SqlCommand(Query, con)
        da = New SqlDataAdapter(cmd)
        dtvisitDetail = New DataTable("VisitDetails")
        dtvisitDetail.Clear()
        da.Fill(dtvisitDetail)

        dtvisitDetail.Dispose()
        da.Dispose()

        For Each row As DataRow In dtvisitDetail.Rows
            For columnindex = 0 To dtvisitDetail.Columns.Count - 1
                If row.IsNull(columnindex) Then
                    Dim t = dtvisitDetail.Columns(columnindex).DataType
                    row(columnindex) = If(t Is GetType(String), String.Empty, Activator.CreateInstance(t))
                End If
            Next
        Next
        dv = New DataView(dtvisitDetail)
        cur = CType(frm.BindingContext(dv), CurrencyManager)
    End Sub

    Public Function SelectWithDataTable(Query As String, Sheet As String) As DataTable
        Try
            cmd = New SqlCommand(Query, con)
            da = New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            dt = New DataTable(Sheet)
            dt.Clear()
            da.Fill(dt)
            Return dt

            dt.Dispose()
            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
            Return Nothing
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Function

    Sub ExportExcel(Dt As DataTable, Sheet As String)
        Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
            If sfd.ShowDialog = DialogResult.OK Then
                Try
                    Using workbook As XLWorkbook = New XLWorkbook
                        workbook.Worksheets.Add(Dt, Sheet)
                        workbook.SaveAs(sfd.FileName)
                    End Using
                    MsgBox("Exported Done")
                    If MsgBox("Do you Want To Open File", MessageBoxIcon.Question + vbYesNo, "Question") = vbYes Then
                        Process.Start(sfd.FileName)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
                End Try
            End If
        End Using
    End Sub

    Sub openFormInTab(F As Form)

        Try
            Dim frm As Form = TryCast(F, Form)
            frm.TopLevel = False
            For Each tab As XtraTabPage In Home.XtraTabControl1.TabPages
                'لمنع فتح الفورم أكثر من مرة
                If tab.Name = frm.Name Then
                    Exit Sub
                End If
            Next
            Home.XtraTabControl1.TabPages.Add(New XtraTabPage With {.Text = frm.Text, .Name = frm.Name})
            For Each tab As XtraTabPage In Home.XtraTabControl1.TabPages
                If tab.Name = frm.Name Then
                    tab.ImageOptions.Image = frm.Icon.ToBitmap
                    tab.Controls.Add(frm)
                    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    frm.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
                    frm.Dock = DockStyle.Fill
                    Home.XtraTabControl1.SelectedTabPage = tab
                    frm.Show()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Public Sub FillCmb(ByVal cmb As ComboBox, TableName As String, Display As String, Value As Object)
        Try
            Dim DT As New DataTable
            Dim DA As New SqlDataAdapter
            DT.Clear()
            DA = New SqlDataAdapter("Select * FROM " & TableName & " ", con)
            DA.Fill(DT)

            DT.Dispose()
            DA.Dispose()

            If DT.Rows.Count > 0 Then
                cmb.DataSource = DT
                cmb.DisplayMember = Display
                cmb.ValueMember = Value
            Else
                cmb.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    'إظهار شريط المهام عندما تكون الشاشة بدون إطار 
    Public Sub AdjustFormSize(W As Integer, H As Integer, f As Form)
        f.Width = Screen.PrimaryScreen.Bounds.Width - W
        f.Height = Screen.PrimaryScreen.Bounds.Height - H
        f.Location = New Point()
        f.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Sub TextBoxDepndOnCombobox(txt As TextBox, cbo As ComboBox)
        Cmd = New SqlCommand("Select Amount From VisitsTypes Where Num=" & cbo.SelectedValue, con)
        con.Open()
        Dim dr As SqlDataReader = Cmd.ExecuteReader
        dr.Read()
        txt.Text = dr(0)
        con.Close()
    End Sub

End Module
