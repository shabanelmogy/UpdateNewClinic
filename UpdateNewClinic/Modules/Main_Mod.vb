Imports System.Data.SqlClient
Imports ClosedXML.Excel
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Module Main_Mod

    Public cmd As New SqlCommand
    Public query As String
    Public da As New SqlDataAdapter
    Public dr As SqlDataReader
    Public dtEditPatient, dtVisitsType, dtvisitDetail As New DataTable
    Public dv, dv1 As New DataView
    Public cur As CurrencyManager

    'Public newdir As String = System.Windows.Forms.Application.StartupPath
    Public con As New SqlConnection("Server=.;DataBase=Clinic;Integrated Security=True")
    'Public con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DataBase\NewClinic.mdf;Integrated Security=True;Connect Timeout=30")
    'Public con1 As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & newdir & "\NewClinic.mdf;Integrated Security=True;Connect Timeout=30")
    'Public con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & newdir & "\NewClinic.mdf;Integrated Security=True;Connect Timeout=30")
    'Public con As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("con").ConnectionString)

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

    Public Sub OpenForm(ByVal Form As Object, Pnl As Object)
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
        da.Fill(dtEditPatient)

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

    Sub Fill_DataTableVisits(Query As String, frm As Form)
        Try
            cmd = New SqlCommand(Query, con)
            da = New SqlDataAdapter(cmd)
            dtVisitsType = New DataTable("Details")
            dtVisitsType.Clear()
            da.Fill(dtVisitsType)

            For Each row As DataRow In dtVisitsType.Rows
                For columnindex = 0 To dtVisitsType.Columns.Count - 1
                    If row.IsNull(columnindex) Then
                        Dim t = dtVisitsType.Columns(columnindex).DataType
                        row(columnindex) = If(t Is GetType(String), String.Empty, Activator.CreateInstance(t))
                    End If
                Next
            Next

            dv = New DataView(dtVisitsType)
            cur = CType(frm.BindingContext(dv), CurrencyManager)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Info")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Sub Fill_DataTableVisitDetails(Query As String, frm As Form)

        cmd = New SqlCommand(Query, con)
        da = New SqlDataAdapter(cmd)
        dtvisitDetail = New DataTable("VisitDetails")
        dtvisitDetail.Clear()
        da.Fill(dtvisitDetail)

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
                    MsgBox(ex.Message)
                End Try
            End If
        End Using
    End Sub

    Sub openFormInTab(F As Form)

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
    End Sub

    Public Sub DelDgvRow(ByVal DGV As DataGridView, CellName As Integer, Tablename As String, FieldName As String)
        Dim Position As Integer = DGV.CurrentRow.Index
        Dim ID_Position As Integer = DGV.Rows(Position).Cells(CellName).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From " & Tablename & " Where " & FieldName & " = " & ID_Position
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف بيانات السجل بنجاح.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Public Sub FillCmb(ByVal cmb As ComboBox, TableName As String, Display As String, Value As Object)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM " & TableName & " ", con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = Display
            cmb.ValueMember = Value
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
End Module
