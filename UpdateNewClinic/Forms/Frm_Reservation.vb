Imports System.Data.SqlClient
Imports System.Drawing

Public Class Frm_Reservation

#Region "Declaration"
    Dim cmd, cmd1 As New SqlCommand
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Dim Dt_Search, Dt_Visits, dt As New DataTable
    Dim da As New SqlDataAdapter
    Dim rdr As SqlDataReader
    Dim Query As String
    Dim check As Boolean = False

#End Region

#Region "Sub Procedures"

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

    'تحديث شاشة الحجز باى إضافة جديدة
    Sub load_FrmManageReservation()
        frm_ManageReservation.GetAllPatient("Select PatientID,Reservation.PatientName,FirstDate,Code,ReserveDate,VisitName,VisitCost From Reservation
                        Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                        Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'")
        frm_ManageReservation.FormatDgv_Search()
    End Sub

    Sub GetAllReservation()
        Try
            Dgv_Visits.Rows.Clear()
            If con.State = 1 Then con.Close()
            con.Open()
            Dim cmd As New SqlCommand("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost From Reservation", con)
            rdr = cmd.ExecuteReader
            While rdr.Read
                Dgv_Visits.Rows.Add(rdr("PatientID"), rdr("PatientName"), Format(rdr("ReserveDate"), "dd/MM/yyyy"), rdr("VisitName"),
                                     rdr("VisitCost"))
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

        If con.State = 1 Then con.Close()

        cmd = New SqlCommand("Select PatientID From Reservation Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
        cmd.Parameters.AddWithValue("@PatientID", Val(Txt_Num.Text)).DbType = DbType.Int32
        cmd.Parameters.AddWithValue("@ReserveDate", Dtp_ReserveDate.Value).DbType = DbType.Date
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 0 Then

            cmd = New SqlCommand("Insert Into Reservation(PatientID,PatientName,ReserveDate,VisitType,VisitName,VisitCost)
                                 Values(@PatientID,@PatientName,@ReserveDate,@VisitType,@VisitName,@VisitCost)", con)
            With cmd
                .Parameters.AddWithValue("@PatientID", Val(Txt_Num.Text)).DbType = DbType.Int32
                .Parameters.AddWithValue("@PatientName", Txt_PatientName.Text).DbType = DbType.String
                .Parameters.AddWithValue("@ReserveDate", Dtp_ReserveDate.Value).DbType = DbType.Date
                .Parameters.AddWithValue("@VisitType", Cbo_ReserveType.SelectedValue).DbType = DbType.Int32
                .Parameters.AddWithValue("@VisitName", Cbo_ReserveType.Text).DbType = DbType.String
                .Parameters.AddWithValue("@VisitCost", Val(Txt_VisitCost.Text)).DbType = DbType.Decimal
            End With

            If con.State = 1 Then con.Close()

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If
    End Sub

    Public Sub Update_Reservation()

        If con.State = 1 Then con.Close()

        cmd = New SqlCommand("Update Reservation set ReserveDate=@ReserveDate,VisitType=@VisitType,VisitName=@VisitName,VisitCost=@VisitCost
                                Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
        With cmd
            .Parameters.AddWithValue("@PatientID", Val(Txt_Num.Text)).DbType = DbType.Int32
            .Parameters.AddWithValue("@PatientName", Txt_PatientName.Text).DbType = DbType.String
            .Parameters.AddWithValue("@ReserveDate", Dtp_ReserveDate.Value).DbType = DbType.Date
            .Parameters.AddWithValue("@VisitType", Cbo_ReserveType.SelectedValue).DbType = DbType.Int32
            .Parameters.AddWithValue("@VisitName", Cbo_ReserveType.Text).DbType = DbType.String
            .Parameters.AddWithValue("@VisitCost", Txt_VisitCost.Text).DbType = DbType.Double
        End With

        If con.State = 1 Then con.Close()

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

#End Region

#Region "Datagridview"

    Sub FormatDgv_Search()
        Dgv_Search.Columns(0).Width = 100
        Dgv_Search.Columns(1).Width = 290
        Dgv_Search.Columns(2).Width = 170
    End Sub

    Sub FormatDgv_Visits()
        Dgv_Visits.Columns(0).Width = 100
        Dgv_Visits.Columns(1).Width = 300
        Dgv_Visits.Columns(2).Width = 120
        Dgv_Visits.Columns(3).Width = 100
        Dgv_Visits.Columns(4).Width = 100
        Dgv_Visits.Columns(3).HeaderText = "ReserveType"
        Dgv_Visits.Columns(0).HeaderText = "PatientNum"
    End Sub

    Private Sub Dgv_Search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Search.CellClick
        Txt_PatientName.Text = Dgv_Search.CurrentRow.Cells(1).Value.ToString
        Txt_Num.Text = Dgv_Search.CurrentRow.Cells(0).Value.ToString
        check = False
    End Sub

    Private Sub Dgv_Visits_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Visits.CellClick
        Txt_Num.Text = Dgv_Visits.CurrentRow.Cells(0).Value
        Txt_PatientName.Text = Dgv_Visits.CurrentRow.Cells(1).Value
        Dtp_ReserveDate.Text = Dgv_Visits.CurrentRow.Cells(2).Value
        Cbo_ReserveType.Text = Dgv_Visits.CurrentRow.Cells(3).Value
        Txt_VisitCost.Text = Dgv_Visits.CurrentRow.Cells(4).Value
        check = True
    End Sub

#End Region

#Region "Events"

#Region "Buttons"

    Private Sub Btn_NewPatient_Click(sender As Object, e As EventArgs) Handles Btn_NewPatient.Click
        Dim frm As New Frm_NewClient
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Txt_PatientNum.Text = GetMaxId("PatientNum", "PatientsDetail") + 1
        frm.Show()
    End Sub

    Private Sub Btn_SelectAll_Click(sender As Object, e As EventArgs) Handles Btn_SelectAll.Click
        Frm_Reservation_Load(Nothing, Nothing)
    End Sub

    Private Sub Btn_SaveNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_SaveNewPatient.Click

        If Not String.IsNullOrWhiteSpace(Txt_Num.Text) And Not String.IsNullOrWhiteSpace(Cbo_ReserveType.Text) Then
            If check = False Then

                Insert_Reservation()
            Else
                Update_Reservation()
            End If

            load_FrmManageReservation()

            Txt_Num.Text = ""
            Txt_PatientName.Text = ""
            Cbo_ReserveType.Text = ""
            Txt_VisitCost.Text = ""
            Txt_SearchValue.Select()

            GetAllReservation()
        End If

    End Sub

    Private Sub Btn_DeletePatient_Click(sender As Object, e As EventArgs) Handles Btn_DeletePatient.Click
        Try
            If MsgBox("Do You Want To Delete This Record ?", MsgBoxStyle.Information + vbYesNo + MsgBoxStyle.DefaultButton2, "Attention") = vbYes Then

                cmd = New SqlCommand("Delete From Reservation Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
                cmd.Parameters.AddWithValue("@PatientID", Val(Txt_Num.Text))
                cmd.Parameters.AddWithValue("@ReserveDate", Dtp_ReserveDate.Value)

                con.Open()
                cmd.ExecuteNonQuery()

                GetAllReservation()
                load_FrmManageReservation()
                Dgv_Visits.CurrentCell = Dgv_Visits.Rows(Dgv_Visits.Rows.Count - 1).Cells(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Delete")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_SortDesc_Click(sender As Object, e As EventArgs) Handles Btn_SortDesc.Click
        Dgv_Search.Sort(Dgv_Search.Columns(Cbo_SortAndSearch.Text), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Btn_SortAsec_Click(sender As Object, e As EventArgs) Handles Btn_SortAsec.Click
        Dgv_Search.Sort(Dgv_Search.Columns(Cbo_SortAndSearch.Text), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

#End Region

#Region "TextBox"

    Private Sub Txt_SearchValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SearchValue.KeyPress
        If Cbo_SortAndSearch.Text = "PatientName" And Char.IsControl(e.KeyChar) = False And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True

        ElseIf Cbo_SortAndSearch.Text = "Phone" And Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Sub Txt_SearchValue_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_SearchValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            dv = Dt_Search.DefaultView
            If Cbo_SortAndSearch.Text = "PatientName" Then
                dv.RowFilter = "PatientName like '" & Txt_SearchValue.Text & "%'"
            ElseIf Cbo_SortAndSearch.Text = "PhoneNumber" Then
                dv.RowFilter = "PhoneNumber = '" & Txt_SearchValue.Text & "'"
            End If
        End If
    End Sub

#End Region

#Region "ComboBox"

    Private Sub Cbo_SortAndSearch_TextChanged(sender As Object, e As EventArgs) Handles Cbo_SortAndSearch.TextChanged
        Txt_SearchValue.Text = ""
    End Sub



    Private Sub Cbo_ReserveType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_ReserveType.SelectionChangeCommitted
        TextBoxDepndOnCombobox(Txt_VisitCost, Cbo_ReserveType, "Select Amount From VisitsTypes", "Num")
    End Sub

#End Region

#Region "Forms"

    Private Sub Frm_Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Fill_Combobox(Cbo_ReserveType, "VisitsTypes", "VisitKind", "Num")
            Cbo_SortAndSearch.SelectedIndex = 0
            GetAllPatient("Select PatientNum,PatientName,PhoneNumber From PatientsDetail")
            GetAllReservation()
            TextBoxDepndOnCombobox(Txt_VisitCost, Cbo_ReserveType, "Select Amount From VisitsTypes", "Num")
            Dtp_ReserveDate.Value = Date.Now.ToString("dd-MM-yyyy")
            check = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Frm_NewClient_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.F3
                Btn_SaveNewPatient.PerformClick()
            Case Keys.Delete
                Btn_DeletePatient.PerformClick()
        End Select
    End Sub

#End Region

#End Region

End Class