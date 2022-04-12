Imports System.Data.SqlClient
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo

Public Class Frm_EditPatients

    Dim CurNum As Integer
    Dim CurName As String
    Dim currow As Integer
    Dim rdr As SqlDataReader
    Dim pname() As String

    Sub DgvColumnWidth()
        Try
            Dgv_EditPatient.Columns("PatientNum").Width = 100
            Dgv_EditPatient.Columns("PatientName").Width = 330
            Dgv_EditPatient.Columns("Code").Width = 90
            Dgv_EditPatient.Columns("Age").Width = 90
            Dgv_EditPatient.Columns("Occupation").Width = 250
            Dgv_EditPatient.Columns("PhoneNumber").Width = 140
            Dgv_EditPatient.Columns("FirstDate").Width = 130
            Dgv_EditPatient.Columns("Height").Width = 90
            Dgv_EditPatient.Columns("StartWeight").Width = 100
            Dgv_EditPatient.Columns(8).DefaultCellStyle.Format = "dd/MM/yyyy"
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Sub FillDataGRidview(Query As String)
        Try
            Fill_DataTablePatients(Query, Me)
            dgvColumnWidth()
            Dgv_EditPatient.Rows.Clear()
            For i = 0 To cur.Count - 1
                Dgv_EditPatient.Rows.Add(New String() {cur.Current("PatientNum"), cur.Current("PatientName"), cur.Current("Code"), cur.Current("Age"), cur.Current("Occupation"),
                                                   cur.Current("PhoneNumber"), cur.Current("FirstDate"), cur.Current("Height"), cur.Current("StartWeight")})
                cur.Position += 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Dgv_EditPatient_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgv_EditPatient.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{right}")
        End If
    End Sub

    Private Sub Dgv_EditPatient_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_EditPatient.CellEndEdit
        Try

            If e.ColumnIndex = 1 Then
                Cmd = New SqlCommand("Select PatientName From PatientsDetail Where PatientName=@PatientName", con)
                Cmd.Parameters.AddWithValue("@PatientName", Dgv_EditPatient.CurrentRow.Cells(1).Value).Value.ToString()
                Dim da As New SqlDataAdapter(Cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MsgBox("إسم المريض مكرر")
                    SendKeys.Send("{Left}")
                    RemoveHandler Dgv_EditPatient.KeyDown, AddressOf Dgv_EditPatient_KeyDown
                End If
            End If

            SendKeys.Send("{right}")
            Me.Dgv_EditPatient.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            Me.Dgv_EditPatient.DefaultCellStyle.SelectionBackColor = Color.LightPink
            Me.Dgv_EditPatient.DefaultCellStyle.SelectionForeColor = Color.Black

            If e.ColumnIndex = 8 Then
                Btn_SavePatient.PerformClick()
                Me.Dgv_EditPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Me.Dgv_EditPatient.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Frm_EditPatient_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.F2
                    Btn_ShowAllPatients.PerformClick()
                Case Keys.F3
                    Btn_AddNewPatient.PerformClick()
                Case Keys.F4
                    Btn_SavePatient.PerformClick()
                Case Keys.Delete
                    Btn_DelPatient.PerformClick()
                Case Keys.Escape
                    Btn_Exit.PerformClick()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Dgv_EditPatient_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles Dgv_EditPatient.CellValidating

        'Validate PatientName
        If e.ColumnIndex = 1 Then
            If Dgv_EditPatient.IsCurrentCellDirty Then
                If Not Char.IsLetter(e.FormattedValue) Then
                    e.Cancel = True
                End If
            End If
        End If

        'Validate Code
        If e.ColumnIndex = 2 Then
            If Dgv_EditPatient.IsCurrentCellDirty Then
                If Not IsNumeric(e.FormattedValue) Then
                    e.Cancel = True
                End If
            End If
        End If

        'Validate Age
        If e.ColumnIndex = 3 Then
            If Dgv_EditPatient.IsCurrentCellDirty Then
                If Not IsNumeric(e.FormattedValue) Then
                    e.Cancel = True
                End If
            End If
        End If

        'Validate Occupation
        If e.ColumnIndex = 4 Then
            If Dgv_EditPatient.IsCurrentCellDirty Then
                If Not Char.IsLetter(e.FormattedValue) Then
                    e.Cancel = True
                End If
            End If
        End If

        'Validate PhoneNumber
        If e.ColumnIndex = 5 Then
            If Dgv_EditPatient.IsCurrentCellDirty Then
                If Not IsNumeric(e.FormattedValue) Then
                    e.Cancel = True
                End If
            End If
        End If

        'Validate FirstDate
        If e.ColumnIndex = 6 Then
            Dim dt As DateTime
            If e.FormattedValue.ToString <> String.Empty AndAlso Not DateTime.TryParse(e.FormattedValue.ToString, dt) Then
                e.Cancel = True
            End If
        End If

        'Validate Height
        If e.ColumnIndex = 7 Then
            If e.FormattedValue.ToString <> String.Empty AndAlso Not Char.IsNumber(e.FormattedValue) Then
                e.Cancel = True
            End If
        End If

        'Validate StartWeight
        If e.ColumnIndex = 8 Then
            If e.FormattedValue.ToString <> String.Empty AndAlso Not Char.IsNumber(e.FormattedValue) Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Try
            Home.XtraTabControl1.TabPages.Remove(Home.XtraTabControl1.SelectedTabPage)
            Home.XtraTabControl1.SelectedTabPage = Home.XtraTabControl1.TabPages(Home.XtraTabControl1.TabPages.Count - 1)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Frm_EditPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dgvColumnWidth()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Btn_ExportExcel_Click(sender As Object, e As EventArgs) Handles Btn_ExportExcel.Click
        Try
            ExportExcel(dtEditPatient, "Patients")
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click
        Try
            Txt_SearchName.Text = ""
            Txt_SearchNum.Text = ""
            Txt_Telephone.Text = ""
            Dtp_SearchVisit.Value = "2001-1-1"
            FillDataGRidview("Select * From PatientsDetail where FirstDate='" & Format(Today, "yyyy-MM-dd") & "'")
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Dgv_EditPatient_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Dgv_EditPatient.CellPainting
        If e.ColumnIndex = 9 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = My.Resources.Open_16_16
            e.Graphics.DrawImage(img, e.CellBounds.Left + 45, e.CellBounds.Top + 7, 10, 10)

            e.Handled = True
        End If
    End Sub

    Private Sub Dgv_EditPatient_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_EditPatient.CellContentClick
        'لتجنب الضغط فى اى مكان
        Try
            If e.RowIndex < 0 Then Return
            Dim PatientName As String = Dgv_EditPatient.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim PatientNum As String = Dgv_EditPatient.Rows(e.RowIndex).Cells(0).Value
            If e.ColumnIndex = 9 Then

                Dim frm As New Frm_PatientVisit
                frm.TopLevel = False
                Home.XtraTabControl1.TabPages.Add(New XtraTabPage With {.Text = PatientName, .Name = frm.Name})

                For Each tab As XtraTabPage In Home.XtraTabControl1.TabPages
                    If tab.Name = frm.Name Then
                        tab.ImageOptions.Image = frm.Icon.ToBitmap
                        tab.Controls.Add(frm)
                        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                        frm.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
                        frm.Dock = DockStyle.Fill
                        Home.XtraTabControl1.SelectedTabPage = tab
                        frm.Txt_PatientNum.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(0).Value
                        frm.Txt_PatientName.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(1).Value
                        frm.Txt_Code.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(2).Value
                        frm.Txt_Age.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(3).Value
                        frm.Txt_Occupation.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(4).Value
                        frm.Txt_Phone1.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(5).Value
                        frm.Txt_FirstVisit.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(6).Value
                        frm.Txt_Height.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(7).Value
                        frm.Txt_StartWeight.Text = Dgv_EditPatient.Rows(e.RowIndex).Cells(8).Value
                        'ملئ بيانات الزيارات الخاصة بالمريض
                        frm.FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewWaist,PlanOfTreatment,EatingHabits,Notes from ClinicDays
                                                inner join VisitsTypes on ClinicDays.VisitType = VisitsTypes.Num Where PatientID = " & PatientNum)
                        frm.Dgv_VisitDetail.ClearSelection()
                    End If
                Next
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try

    End Sub

    Private Sub Dgv_EditPatient_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Dgv_EditPatient.EditingControlShowing

        If Dgv_EditPatient.CurrentCell.ColumnIndex = 3 Then
            If Dgv_EditPatient.CurrentCell.EditType Is GetType(DataGridViewTextBoxEditingControl) Then
                Dim mytb As TextBox = CType(e.Control, TextBox)
                mytb.MaxLength = 2
            End If
        End If

        If Dgv_EditPatient.CurrentCell.ColumnIndex = 5 Then
            If Dgv_EditPatient.CurrentCell.EditType Is GetType(DataGridViewTextBoxEditingControl) Then
                Dim mytb As TextBox = CType(e.Control, TextBox)
                mytb.MaxLength = 11
            End If
        End If

        If Dgv_EditPatient.CurrentCell.ColumnIndex = 7 Then
            If Dgv_EditPatient.CurrentCell.EditType Is GetType(DataGridViewTextBoxEditingControl) Then
                Dim mytb As TextBox = CType(e.Control, TextBox)
                mytb.MaxLength = 3
            End If
        End If

        If Dgv_EditPatient.CurrentCell.ColumnIndex = 8 Then
            If Dgv_EditPatient.CurrentCell.EditType Is GetType(DataGridViewTextBoxEditingControl) Then
                Dim mytb As TextBox = CType(e.Control, TextBox)
                mytb.MaxLength = 3
            End If
        End If

    End Sub

    Private Sub Txt_Telephone_TextChanged(sender As Object, e As EventArgs) Handles Txt_Telephone.TextChanged
        Try
            If Txt_Telephone.TextLength > 0 Then
                FillDataGRidview("Select * From PatientsDetail Where PhoneNumber like '%" & Txt_Telephone.Text & "%'")
            Else
                FillDataGRidview("Select  * From PatientsDetail where FirstDate='" & Format(Today, "yyyy-MM-dd") & "'")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Txt_SearchNum_TextChanged(sender As Object, e As EventArgs) Handles Txt_SearchNum.TextChanged
        Try
            If Txt_SearchNum.TextLength > 0 Then
                FillDataGRidview("Select * From PatientsDetail Where PatientNum =  " & CInt(Txt_SearchNum.Text) & "")
            Else
                FillDataGRidview("Select  * From PatientsDetail where FirstDate='" & Format(Today, "yyyy-MM-dd") & "'")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Dtp_SearchVisit_KeyDown(sender As Object, e As KeyEventArgs) Handles Dtp_SearchVisit.KeyDown
        Try
            If e.KeyCode = Keys.Enter And Dtp_SearchVisit.Value.Date <> "2001-1-1" Then
                FillDataGRidview("Select * From PatientsDetail Where FirstDate='" & Format(Dtp_SearchVisit.Value, "yyyy-MM-dd") & "'")
            ElseIf Dtp_SearchVisit.Value.Date = "2001-1-1" And e.KeyCode = Keys.Enter Then
                FillDataGRidview("Select  * From PatientsDetail where FirstDate='" & Format(Today, "yyyy-MM-dd") & "'")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Txt_SearchName_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_SearchName.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If Txt_SearchName.TextLength > 0 Then
                    FillDataGRidview("Select * From PatientsDetail Where PatientName like '" & Txt_SearchName.Text & "%'")
                Else
                    FillDataGRidview("Select  * From PatientsDetail where FirstDate='" & Format(Today, "yyyy-MM-dd") & "'")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_DelPatient_Click(sender As Object, e As EventArgs) Handles Btn_DelPatient.Click
        Try
            If con.State = 1 Then con.Close()

            If Dgv_EditPatient.Rows.Count > 0 Then
                CurNum = Dgv_EditPatient.CurrentRow.Cells(0).Value
                CurName = Dgv_EditPatient.CurrentRow.Cells(1).Value
            Else Exit Sub
            End If

            If MsgBox("Do You Want To Delete This Record ?" & Environment.NewLine & CurNum & " \ " & CurName, MsgBoxStyle.Information + vbYesNo +
                          MsgBoxStyle.DefaultButton2, "Attention") = vbYes Then

                Cmd = New SqlCommand("Delete From PatientsDetail Where PatientNum=@PatientNum", con)
                Cmd.Parameters.AddWithValue("PatientNum", Dgv_EditPatient.CurrentRow.Cells(0).Value)

                con.Open()
                Cmd.ExecuteNonQuery()

                FillDataGRidview("Select  * From PatientsDetail where FirstDate='" & Format(Today, "yyyy-MM-dd") & "'")

                Btn_AddNewPatient.Enabled = True
                Btn_ShowAllPatients.Enabled = True

                If Dgv_EditPatient.Rows.Count > 0 Then
                    Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells(1)
                    Me.Dgv_EditPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    Me.Dgv_EditPatient.DefaultCellStyle.SelectionBackColor = Color.OldLace
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_SavePatient_Click(sender As Object, e As EventArgs) Handles Btn_SavePatient.Click
        Try

            If con.State = 1 Then con.Close()

            For Each row As DataGridViewRow In Dgv_EditPatient.Rows

                currow = Dgv_EditPatient.CurrentRow.Index

                If con.State = 1 Then con.Close()

                If String.IsNullOrWhiteSpace(row.Cells("PatientName").Value) Then
                    MsgBox("You must Enter PatientName", MsgBoxStyle.Information, "Stop")
                    Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells("PatientName")
                    Dgv_EditPatient.BeginEdit(False)
                    Exit Sub
                ElseIf String.IsNullOrWhiteSpace(row.Cells("Code").Value) Then
                    MsgBox("You must Enter Code", MsgBoxStyle.Information, "Stop")
                    Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells("Code")
                    Dgv_EditPatient.BeginEdit(False)
                    Exit Sub
                ElseIf String.IsNullOrWhiteSpace(row.Cells("Age").Value) Then
                    MsgBox("You must Enter Age", MsgBoxStyle.Information, "Stop")
                    Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells("Age")
                    Dgv_EditPatient.BeginEdit(False)
                    Exit Sub
                ElseIf String.IsNullOrWhiteSpace(row.Cells("Occupation").Value) Then
                    MsgBox("You must Enter Occupation", MsgBoxStyle.Information, "Stop")
                    Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells("Occupation")
                    Dgv_EditPatient.BeginEdit(False)
                    Exit Sub
                ElseIf String.IsNullOrWhiteSpace(row.Cells("FirstDate").Value) Then
                    MsgBox("You must Enter FirstVisit", MsgBoxStyle.Information, "Stop")
                    Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells("FirstDate")
                    Dgv_EditPatient.BeginEdit(False)
                    Exit Sub
                ElseIf String.IsNullOrWhiteSpace(row.Cells("Height").Value) Then
                    MsgBox("You must Enter Height", MsgBoxStyle.Information, "Stop")
                    Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells("Height")
                    Dgv_EditPatient.BeginEdit(False)
                    Exit Sub
                ElseIf String.IsNullOrWhiteSpace(row.Cells("StartWeight").Value) Then
                    MsgBox("You must Enter StartWeight", MsgBoxStyle.Information, "Stop")
                    Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells("StartWeight")
                    Dgv_EditPatient.BeginEdit(False)
                    Exit Sub
                End If
                '==============================لاختبار اذا كان رقم المريض مكرر ==============================================

                Cmd = New SqlCommand("Select PatientNum From PatientsDetail Where PatientNum=@PatientNum", con)
                Cmd.Parameters.AddWithValue("@PatientNum", row.Cells("PatientNum").Value).DbType = DbType.Int32
                Da = New SqlDataAdapter(Cmd)
                DtEditPatient = New DataTable
                Da.Fill(DtEditPatient)

                DtEditPatient.Dispose()
                Da.Dispose()

                If DtEditPatient.Rows.Count = 0 Then
                    Cmd = New SqlCommand("Insert Into PatientsDetail(PatientNum,PatientName,Code,Age,Occupation,PhoneNumber,FirstDate,Height,StartWeight)
                                          values(@PatientNum,@PatientName,@Code,@Age,@Occupation,@PhoneNumber,@FirstDate,@Height,@StartWeight)", con)
                Else
                    Cmd = New SqlCommand("Update PatientsDetail Set PatientName=@PatientName,Code=@Code,Age=@Age,Occupation=@Occupation,PhoneNumber=@PhoneNumber,
                                         FirstDate=@FirstDate,Height=@Height,StartWeight=@StartWeight where Patientnum=@PatientNum", con)
                End If

                With Cmd.Parameters
                    .AddWithValue("@PatientNum", row.Cells("PatientNum").Value).DbType = DbType.Int32
                    .AddWithValue("@PatientName", row.Cells("PatientName").Value).DbType = DbType.String
                    .AddWithValue("@Code", row.Cells("Code").Value).DbType = DbType.String
                    .AddWithValue("@Age", row.Cells("Age").Value).DbType = DbType.String
                    .AddWithValue("@Occupation", row.Cells("Occupation").Value).DbType = DbType.String
                    If Not String.IsNullOrWhiteSpace(row.Cells("PhoneNumber").Value) Then
                        .AddWithValue("@PhoneNumber", row.Cells("PhoneNumber").Value).DbType = DbType.String
                    Else
                        .AddWithValue("@PhoneNumber", DBNull.Value)
                    End If
                    .AddWithValue("@FirstDate", row.Cells("FirstDate").Value).DbType = DbType.Date
                    .AddWithValue("@Height", row.Cells("Height").Value).DbType = DbType.String
                    .AddWithValue("@StartWeight", row.Cells("StartWeight").Value).DbType = DbType.String
                End With

                con.Open()
                Cmd.ExecuteNonQuery()
            Next
            'FillDataGRidview("Select  * From PatientsDetail where FirstDate='" & Format(Today, "yyyy-MM-dd") & "'")


            Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(currow).Cells(0)
            Me.Dgv_EditPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect


            Btn_AddNewPatient.Enabled = True
            Btn_ShowAllPatients.Enabled = True

            If Dgv_EditPatient.Rows.Count - 1 > 0 Then
                Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells(9)
            End If

        Catch ex As Exception
            'لتجنب ظهور خطأ عند الضغط على حواف الخلية
            If ex.Message = "Operation is not valid because it results in a reentrant call to the SetCurrentCellAddressCore function." Then
            End If
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_AddNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_AddNewPatient.Click
        Try
            If con.State = 1 Then con.Close()

            Btn_ShowAllPatients.Enabled = False
            Dgv_EditPatient.Rows.Add(GetMaxId("PatientNum", "PatientsDetail") + 1)
            Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells("FirstDate").Value = Date.Now.ToString("dd/MM/yyyy")
            Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells(1)

            'Cursor inside cell datagridview 
            Dgv_EditPatient.BeginEdit(False)
            Btn_AddNewPatient.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_ShowAllPatients_Click(sender As Object, e As EventArgs) Handles Btn_ShowAllPatients.Click
        Try
            If con.State = 1 Then con.Close()
            FillDataGRidview("Select * From PatientsDetail Where FirstDate='" & Format(Today, "yyyy-MM-dd") & "'")
            If Dgv_EditPatient.Rows.Count - 1 > 0 Then
                Dgv_EditPatient.CurrentCell = Dgv_EditPatient.Rows(Dgv_EditPatient.Rows.Count - 1).Cells(1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Attention")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Txt_SearchNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SearchNum.KeyPress
        If (Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_SearchName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SearchName.KeyPress
        If (Char.IsControl(e.KeyChar) = False And Char.IsLetter(e.KeyChar) = False) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_Telephone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Telephone.KeyPress
        If (Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False) Then
            e.Handled = True
        End If
    End Sub

End Class