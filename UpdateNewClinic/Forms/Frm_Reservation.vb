Imports System.Data.SqlClient
Imports System.Drawing

Public Class Frm_Reservation

    Dim cmd As New SqlCommand
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Dim dt As New DataTable
    Dim da As New SqlDataAdapter

    Sub FormatDatagridview()

        Dgv_Search.Columns(0).Width = 100
        Dgv_Search.Columns(1).Width = 250
        Dgv_Search.Columns(2).Width = 150

        'store Len of datagridview columns
        Dim countgridcolumn As Integer = Dgv_Search.Columns.Count
        Dim DgvBtnReserve As New DataGridViewButtonColumn

        'عند اضافة الزر يكون رقمه صفر حتى لو ظهر فى الاخر
        DgvBtnReserve.Width = 90
        DgvBtnReserve.Name = "checkboxcol1"
        DgvBtnReserve.HeaderText = "Reserve"
        Dgv_Search.Columns.Insert(countgridcolumn, DgvBtnReserve)


    End Sub

    Private Sub Frm_NewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillCmb(Cbo_ReserveType, "VisitsTypes", "VisitKind", "Num")
            Cbo_SortAndSearch.SelectedIndex = 0
            GetAllPatient("Select PatientNum,PatientName,PhoneNumber From PatientsDetail")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub InsertNewPatient()

        If Txt_PatientName.Text = vbNullString Then
            MsgBox("لم يتم إدخال إسم المريض أو رقم الهاتف ", MsgBoxStyle.Information, "تنبيه")
            Exit Sub
        End If
        Try
            Dim cmdcheck As New SqlCommand("Select PatientName From PatientsDetail Where PatientName=@PatientName", con)
            cmdcheck.Parameters.AddWithValue("@PatientName", Txt_PatientName.Text).Value.ToString()
            Dim da As New SqlDataAdapter(cmdcheck)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                MsgBox("إسم المريض مكرر سبق ادخاله من قبل", MsgBoxStyle.Information, "تنبيه")
                Exit Sub
            Else
                Dim cmd As New SqlCommand
                With cmd
                    .Connection = con
                    .CommandType = CommandType.Text
                    .CommandText = "Insert Into PatientsDetail (PatientNum,PatientName,Code,Birthdate,Occupation,PhoneNumber,TheFirstDate,Height,StartWeight,
                                    StartBmi,StartFat,StartWaist,StartHip) 
                                    Values(@PatientNum,@PatientName,@Code,@Birthdate,@Occupation,@PhoneNumber,@TheFirstDate,@Height,@StartWeight,
                                    @StartBmi,@StartFat,@StartWaist,@StartHip)"

                    .Parameters.Clear()
                    .Parameters.AddWithValue("@PatientName", SqlDbType.NVarChar).Value = Txt_PatientName.Text
                    .Parameters.AddWithValue("@TheFirstDate", SqlDbType.Date).Value = Dtp_PatientFirstDate.Value

                End With

                If con.State = 1 Then con.Close()
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("تم تسجيل بيانات المريض بنجاح")
                cmd = Nothing

                ResetControls(Me)
                Frm_NewClient_Load(Nothing, Nothing)
                cur.Position = cur.Count - 1
                Btn_SaveNewPatient.Enabled = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Sub UpdatePatient()
        Try
            Dim CurPosit As Integer = cur.Position
            Dim cmd As New SqlCommand("Update PatientsDetail Set PatientName=@PatientName,Code=@Code,BirthDate=@BirthDate,
                                   Occupation=@Occupation,PhoneNumber=@PhoneNumber,TheFirstDate=@TheFirstDate,Height=@Height,StartWeight=@StartWeight,
                                   StartBmi=@StartBmi,StartFat=@StartFat,StartWaist=@StartWaist,StartHip=@StartHip
                                   Where PatientNum=@PatientNum", con)
            With cmd.Parameters
                .AddWithValue("@PatientName", SqlDbType.NVarChar).Value = Txt_PatientName.Text
                .AddWithValue("@TheFirstDate", SqlDbType.Date).Value = Dtp_PatientFirstDate.Value
            End With

            If con.State = 1 Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            Frm_NewClient_Load(Nothing, Nothing)
            cur.Position = CurPosit
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    'Sub DeletePatient()
    '    Try
    '        Dim cmd As New SqlCommand("Delete From PatientsDetail Where PatientNum=@PatientNum", con)
    '        cmd.Parameters.AddWithValue("@PatientNum", SqlDbType.Int).Value = Txt_PatientCode.Text

    '        If con.State = 1 Then con.Close()
    '        con.Open()
    '        Dim CurName As String = Txt_PatientName.Text
    '        If MsgBox("سيتم حذف بيانات المريض رقم " & Environment.NewLine & CurNum & "\" & CurName, MsgBoxStyle.Exclamation + vbYesNo, "Delete") = vbNo Then
    '            Exit Sub
    '        Else
    '            cmd.ExecuteNonQuery()
    '        End If
    '        cmd.ExecuteNonQuery()
    '        con.Close()

    '        Frm_NewClient_Load(Nothing, Nothing)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Information)
    '    End Try
    'End Sub

    Sub GetAllPatient(Query As String)
        Try
            Dim cmd As New SqlCommand(Query, con)

            dt = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)

            Dgv_Search.DataSource = dt
            FormatDatagridview()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Btn_SaveNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_SaveNewPatient.Click
        InsertNewPatient()
    End Sub

    Private Sub Btn_SortAsec_Click(sender As Object, e As EventArgs) Handles Btn_SortAsec.Click
        Try
            Dim ColumnText As String = ""
            Select Case Cbo_SortAndSearch.Text

                Case "PatientName"
                    ColumnText = "PatientName"
                Case "Phone"
                    ColumnText = "PhoneNumber"
            End Select

            dv.Sort = ColumnText
            cur.Position = 0
        Catch ex As Exception
            MsgBox("You Must Select Sort Value", MsgBoxStyle.Information, "Attention")
            Cbo_SortAndSearch.Select()
        End Try
    End Sub

    Private Sub Btn_SortDesc_Click(sender As Object, e As EventArgs) Handles Btn_SortDesc.Click
        Try
            Dim ColumnText As String = ""
            Select Case Cbo_SortAndSearch.Text
                Case "PatientNumber"
                    ColumnText = "PatientNum Desc"
                Case "PatientName"
                    ColumnText = "PatientName Desc"
                Case "Phone"
                    ColumnText = "PhoneNumber Desc "
            End Select

            dv.Sort = ColumnText
            cur.Position = 0
        Catch ex As Exception
            MsgBox("You Must Select Sort Value", MsgBoxStyle.Information, "Attention")
            Cbo_SortAndSearch.Select()
        End Try
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs)

        'GetAllPatient("Select PatientNum,PatientName,PhoneNumber From PatientsDetail Where PatientName Like '" & Txt_SearchValue.Text & "%'")
        'Dgv_Search.DataSource = dt

        'dv = dt.DefaultView
        'If Cbo_SortAndSearch.Text = "PatientName" Then
        '    dv.RowFilter = "PatientName like '" & Txt_SearchValue.Text & "%'"
        'ElseIf Cbo_SortAndSearch.Text = "PhoneNumber" Then
        '    dv.RowFilter = "PhoneNumber = '" & Txt_SearchValue.Text & "'"
        'End If
    End Sub

    Private Sub Cbo_SortAndSearch_TextChanged(sender As Object, e As EventArgs) Handles Cbo_SortAndSearch.TextChanged
        Txt_SearchValue.Text = ""
    End Sub

    Private Sub Frm_NewClient_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.F3
                Btn_SaveNewPatient.PerformClick()
            Case Keys.Delete
                Btn_DeletePatient.PerformClick()
        End Select
    End Sub

    Private Sub Txt_SearchValue_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_SearchValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            dv = dt.DefaultView
            If Cbo_SortAndSearch.Text = "PatientName" Then
                dv.RowFilter = "PatientName like '" & Txt_SearchValue.Text & "%'"
            ElseIf Cbo_SortAndSearch.Text = "PhoneNumber" Then
                dv.RowFilter = "PhoneNumber = '" & Txt_SearchValue.Text & "'"
            End If
        End If
    End Sub

    Private Sub Dgv_Search_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Dgv_Search.CellPainting

        If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = My.Resources.Open_16_16
            e.Graphics.DrawImage(img, e.CellBounds.Left + 40, e.CellBounds.Top + 7, 10, 10)

            e.Handled = True
        End If
    End Sub

    Private Sub Dgv_Search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Search.CellContentClick

        'استثناء الظغطات البعيدة عن الازرار
        If e.RowIndex < 0 Then Return
        Dim PatientNum As String = Dgv_Search.Rows(e.RowIndex).Cells(1).Value
        Dim patientName As String = Dgv_Search.Rows(e.RowIndex).Cells(2).Value

        If e.ColumnIndex = Dgv_Search.Columns(0).Index Then
            Txt_PatientName.Text = patientName
            Txt_Num.Text = PatientNum
        End If

    End Sub
End Class