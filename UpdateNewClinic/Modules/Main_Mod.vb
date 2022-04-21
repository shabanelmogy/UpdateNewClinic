Imports System.Data.SqlClient
Imports ClosedXML.Excel
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Module Main_Mod

#Region "Declare Variables"

    Public Cmd As New SqlCommand
    Public Query As String
    Public Da As New SqlDataAdapter
    Public Dr As SqlDataReader
    Public DtEditPatient, dtvisitDetail, dtsearch As New DataTable
    Public Dv As New DataView
    Public Cur As CurrencyManager
    Public FillCombobox As Boolean = False
    'Public con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=" & newdir & "\NewClinic.mdf;Integrated Security=True;Connect Timeout=30")
    Public con As New SqlConnection(Configuration.ConfigurationManager.ConnectionStrings("con").ConnectionString)
    Public build As SqlCommandBuilder

#End Region

#Region "General Function And Subs"

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

    Function Check(Query As String) As Integer

        Dim cmd As New SqlCommand(Query, con)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.fill(dt)
        If dt.Rows.Count > 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function
#End Region

#Region "General Subs"

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
        Pnl.Controls.Add(fh)
        fh.Show()
    End Sub

    Sub TextBoxDepndOnCombobox(txt As TextBox, cbo As ComboBox, Query As String, SeacrhValue As String)

        If cbo.SelectedValue > 0 Then
            Cmd = New SqlCommand("" & Query & " Where " & SeacrhValue & " =" & cbo.SelectedValue, con)
            con.Open()
            Dim dr As SqlDataReader = Cmd.ExecuteReader

            If dr.HasRows Then
                dr.Read()
                txt.Text = dr(0)
            End If
            con.Close()
        End If
    End Sub

    Sub FilterDatagridview_Combobox(dgv As DataGridView, cbo As ComboBox, Query As String)

        If cbo.SelectedValue > 0 Then
            Cmd = New SqlCommand(Query, con)
            Da = New SqlDataAdapter(Cmd)
            dtsearch = New DataTable
            Da.Fill(dtsearch)
            dgv.DataSource = dtsearch
        End If

    End Sub

    'إظهار شريط المهام عندما تكون الشاشة بدون إطار 
    Public Sub AdjustFormSize(W As Integer, H As Integer, f As Form)
        f.Width = Screen.PrimaryScreen.Bounds.Width - W
        f.Height = Screen.PrimaryScreen.Bounds.Height - H
        f.Location = New Point()
        f.StartPosition = FormStartPosition.CenterScreen
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

    Sub openFormInTab_DockNone(F As Form)

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

                    Home.XtraTabControl1.SelectedTabPage = tab
                    frm.Show()
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Sub closeTabPage(frm As Form)
        Try
            Home.XtraTabControl1.TabPages.Remove(Home.XtraTabControl1.SelectedTabPage)
            Home.XtraTabControl1.SelectedTabPage = Home.XtraTabControl1.TabPages(Home.XtraTabControl1.TabPages.Count - 1)
            frm.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

#End Region

#Region "Fill Functions And Subs"

    Sub Fill_DataTablePatients(Query As String, frm As Form)

        Cmd = New SqlCommand(Query, con)
        Da = New SqlDataAdapter(Cmd)
        DtEditPatient = New DataTable("Patients")
        DtEditPatient.Clear()
        Da.Fill(DtEditPatient)

        DtEditPatient.Dispose()
        Da.Dispose()

        For Each row As DataRow In DtEditPatient.Rows
            For columnindex = 0 To DtEditPatient.Columns.Count - 1
                If row.IsNull(columnindex) Then
                    Dim t = DtEditPatient.Columns(columnindex).DataType
                    row(columnindex) = If(t Is GetType(String), String.Empty, Activator.CreateInstance(t))
                End If
            Next
        Next
        Dv = New DataView(DtEditPatient)
        Cur = CType(frm.BindingContext(Dv), CurrencyManager)
    End Sub

    Public Function GetDatatable(Query As String) As DataTable

        Cmd = New SqlCommand(Query, con)
        Dim dt As New DataTable
        Da = New SqlDataAdapter(Cmd)

        dt.Clear()
        Da.Fill(dt)

        Return dt
    End Function

    Sub Fill_DataTableVisitDetails(Query As String, frm As Form)

        Cmd = New SqlCommand(Query, con)
        Da = New SqlDataAdapter(Cmd)
        dtvisitDetail = New DataTable("VisitDetails")
        dtvisitDetail.Clear()
        Da.Fill(dtvisitDetail)

        dtvisitDetail.Dispose()
        Da.Dispose()

        For Each row As DataRow In dtvisitDetail.Rows
            For columnindex = 0 To dtvisitDetail.Columns.Count - 1
                If row.IsNull(columnindex) Then
                    Dim t = dtvisitDetail.Columns(columnindex).DataType
                    row(columnindex) = If(t Is GetType(String), String.Empty, Activator.CreateInstance(t))
                End If
            Next
        Next
        Dv = New DataView(dtvisitDetail)
        Cur = CType(frm.BindingContext(Dv), CurrencyManager)
    End Sub

    Public Function SelectWithDataTable(Query As String, Sheet As String) As DataTable
        Try
            Cmd = New SqlCommand(Query, con)
            Da = New SqlDataAdapter(Cmd)
            Dim dt As New DataTable
            dt = New DataTable(Sheet)
            dt.Clear()
            Da.Fill(dt)
            Return dt

            dt.Dispose()
            Da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
            Return Nothing
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Function

    Public Sub Fill_Combobox(ByVal cmb As ComboBox, TableName As String, Display As String, Value As Object)
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
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

#End Region

End Module
