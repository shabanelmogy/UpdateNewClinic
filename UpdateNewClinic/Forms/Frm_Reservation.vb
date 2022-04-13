Imports System.Data.SqlClient
Imports System.Drawing

Public Class Frm_Reservation

#Region "Declaration"
    Dim cmd As New SqlCommand
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Dim Dt_Search, Dt_Visits, dt As New DataTable
    Dim da As New SqlDataAdapter
    Dim rdr As SqlDataReader
    Dim Query As String

#End Region

    Sub FormatDgv_Search()
        Dgv_Search.Columns(0).Width = 100
        Dgv_Search.Columns(1).Width = 280
        Dgv_Search.Columns(2).Width = 170
    End Sub

    Sub FormatDgv_Visits()
        Dgv_Visits.Columns(0).Width = 100
        Dgv_Visits.Columns(1).Width = 300
        Dgv_Visits.Columns(2).Width = 100
        Dgv_Visits.Columns(3).Width = 100
        Dgv_Visits.Columns(4).Width = 100
        'Dgv_Visits.Columns(3).HeaderText = "ReserveType"
        'Dgv_Visits.Columns(0).HeaderText = "PatientNum"
    End Sub

    Private Sub Frm_Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FillCmb(Cbo_ReserveType, "VisitsTypes", "VisitKind", "Num")
            Cbo_SortAndSearch.SelectedIndex = 0
            GetAllPatient("Select PatientNum,PatientName,PhoneNumber From PatientsDetail")
            GetAllReservation()
            TextBoxDepndOnCombobox(Txt_VisitCost, Cbo_ReserveType)
            Dtp_ReserveDate.Value = Date.Now.ToString("dd-MM-yyyy")
        Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub GetAllPatient(Query As String)
        Try
            Dim cmd As New SqlCommand(Query, con)

            Dt_Search = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(Dt_Search)

            Dgv_Search.DataSource = Nothing
            Dgv_Search.DataSource = Dt_Search
            FormatDgv_Search()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub GetAllReservation()
        Try
            Dgv_Visits.Rows.Clear()
            If con.State = 1 Then con.Close()
            con.Open()
            Dim cmd As New SqlCommand("Select PatientID,PatientName,ReserveDate,ReserveName,ReserveValue From Reservation", con)
            rdr = cmd.ExecuteReader
            While rdr.Read
                Dgv_Visits.Rows.Add(rdr("PatientID"), rdr("PatientName"), Format(rdr("ReserveDate"), "dd/MM/yyyy"), rdr("ReserveName"), rdr("ReserveValue"))
            End While
            rdr.Close()
            con.Close()
            FormatDgv_Visits()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Public Sub Insert_Reservation()

        cmd = New SqlCommand("Select PatientID,ReserveDate From Reservation Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
        cmd.Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = Txt_Num.Text
        cmd.Parameters.AddWithValue("@ReserveDate", SqlDbType.Date).Value = Dtp_ReserveDate.Value.ToString("yyyy-MM-dd")

        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then

            cmd = New SqlCommand("Insert Into Reservation (PatientID,PatientName,ReserveDate,ReserveType,ReserveName,ReserveValue)
                             Values(@PatientID,@PatientName,@ReserveDate,@ReserveType,@ReserveName,@ReserveValue)", con)
            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = Txt_Num.Text
                .Parameters.AddWithValue("@PatientName", SqlDbType.VarChar).Value = Txt_PatientName.Text
                .Parameters.AddWithValue("@ReserveDate", SqlDbType.Date).Value = Dtp_ReserveDate.Value.ToString("yyyy-MM-dd")
                .Parameters.AddWithValue("@ReserveType", SqlDbType.VarChar).Value = Cbo_ReserveType.SelectedValue
                .Parameters.AddWithValue("@ReserveName", SqlDbType.VarChar).Value = Cbo_ReserveType.Text
                .Parameters.AddWithValue("@ReserveValue", SqlDbType.VarChar).Value = Txt_VisitCost.Text
            End With

        Else
            cmd = New SqlCommand("Update Reservation Set PatientName=@PatientName,ReserveType=@ReserveType,ReserveName=@ReserveName,
                                  ReserveValue=@ReserveValue Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)

            With cmd
                .Parameters.Clear()
                .Parameters.AddWithValue("@PatientID", SqlDbType.Int).Value = Txt_Num.Text
                .Parameters.AddWithValue("@PatientName", SqlDbType.VarChar).Value = Txt_PatientName.Text
                .Parameters.AddWithValue("@ReserveDate", SqlDbType.Date).Value = Dtp_ReserveDate.Value.ToString("yyyy-MM-dd")
                .Parameters.AddWithValue("@ReserveType", SqlDbType.VarChar).Value = Cbo_ReserveType.SelectedValue
                .Parameters.AddWithValue("@ReserveName", SqlDbType.VarChar).Value = Cbo_ReserveType.Text
                .Parameters.AddWithValue("@ReserveValue", SqlDbType.VarChar).Value = Txt_VisitCost.Text
            End With

            If con.State = 1 Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            cmd = Nothing

        End If
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
            dv = Dt_Search.DefaultView
            If Cbo_SortAndSearch.Text = "PatientName" Then
                dv.RowFilter = "PatientName like '" & Txt_SearchValue.Text & "%'"
            ElseIf Cbo_SortAndSearch.Text = "PhoneNumber" Then
            dv.RowFilter = "PhoneNumber = '" & Txt_SearchValue.Text & "'"
            End If
            End If
    End Sub

    'Private Sub Dgv_Search_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Dgv_Search.CellPainting

    '    If e.ColumnIndex = 0 AndAlso e.RowIndex >= 0 Then
    '        e.Paint(e.CellBounds, DataGridViewPaintParts.All)
    '        Dim img As Image = My.Resources.Open_16_16
    '        e.Graphics.DrawImage(img, e.CellBounds.Left + 40, e.CellBounds.Top + 7, 10, 10)

    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub Dgv_Search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Search.CellContentClick

    '    'استثناء الظغطات البعيدة عن الازرار
    '    If e.RowIndex < 0 Then Return
    '    Dim PatientNum As String = Dgv_Search.Rows(e.RowIndex).Cells(1).Value
    '    Dim patientName As String = Dgv_Search.Rows(e.RowIndex).Cells(2).Value

    '    If e.ColumnIndex = Dgv_Search.Columns(0).Index Then
    '        Txt_PatientName.Text = patientName
    '        Txt_Num.Text = PatientNum
    '    End If

    'End Sub

    Private Sub Btn_NewPatient_Click(sender As Object, e As EventArgs) Handles Btn_NewPatient.Click
        Dim frm As New Frm_NewClient
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Txt_PatientNum.Text = GetMaxId("PatientNum", "PatientsDetail") + 1
        frm.Show()
    End Sub

    Private Sub Dgv_Search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Search.CellClick
        Txt_PatientName.Text = Dgv_Search.CurrentRow.Cells(1).Value.ToString
        Txt_Num.Text = Dgv_Search.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub Btn_SelectAll_Click(sender As Object, e As EventArgs) Handles Btn_SelectAll.Click
        Frm_Reservation_Load(Nothing, Nothing)
    End Sub

    Private Sub Btn_SortDesc_Click(sender As Object, e As EventArgs) Handles Btn_SortDesc.Click
        Dgv_Search.Sort(Dgv_Search.Columns(Cbo_SortAndSearch.Text), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Btn_SaveNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_SaveNewPatient.Click
        Insert_Reservation()
        GetAllReservation()
    End Sub

    Private Sub Txt_SearchValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SearchValue.KeyPress
        If Cbo_SortAndSearch.Text = "PatientName" And Char.IsControl(e.KeyChar) = False And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        ElseIf Cbo_SortAndSearch.Text = "Phone" And Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub Cbo_ReserveType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_ReserveType.SelectionChangeCommitted
        TextBoxDepndOnCombobox(Txt_VisitCost, Cbo_ReserveType)
    End Sub

    Private Sub Btn_SortAsec_Click(sender As Object, e As EventArgs) Handles Btn_SortAsec.Click
        Dgv_Search.Sort(Dgv_Search.Columns(Cbo_SortAndSearch.Text), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
End Class