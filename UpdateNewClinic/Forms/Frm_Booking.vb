﻿Imports System.Data.SqlClient
Imports System.Drawing

Public Class Frm_Booking

#Region "Declaration"
    Dim cmd, cmd1 As New SqlCommand
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Dim Dt_Search, Dt_Visits, dt As New DataTable
    Dim da As New SqlDataAdapter
    Dim rdr As SqlDataReader
    Dim Query As String
    Dim check As Boolean = False
    Dim curid As Integer
    Dim curdate As Date

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
        frm_ManageReservation.GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,Occupation,Height,StartWeight,
                               VisitType From Reservation Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                               Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'")
        frm_ManageReservation.FormatDgv_Search()
    End Sub

    Sub GetAllReservation(Query As String)
        Try
            Dgv_Visits.Rows.Clear()
            If con.State = 1 Then con.Close()
            con.Open()
            Dim cmd As New SqlCommand(Query, con)
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
        Else
            MsgBox("The Patient Is Already Checked", MsgBoxStyle.Information, "Info")
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
        Dgv_Search.Columns("PatientNum").Width = 100
        Dgv_Search.Columns("PatientName").Width = 290
        Dgv_Search.Columns("PhoneNumber").Width = 159

        Dgv_Search.Columns("PatientNum").HeaderText = "Patient ID"
        Dgv_Search.Columns("PatientName").HeaderText = "Patient Name"
        Dgv_Search.Columns("PhoneNumber").HeaderText = "Phone Number"
    End Sub

    Sub FormatDgv_Visits()
        Dgv_Visits.Columns(0).Width = 100
        Dgv_Visits.Columns(1).Width = 300
        Dgv_Visits.Columns(2).Width = 120
        Dgv_Visits.Columns(3).Width = 156
        Dgv_Visits.Columns(4).Width = 80
    End Sub

    Private Sub Dgv_Search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Search.CellClick
        Txt_PatientName.Text = Dgv_Search.CurrentRow.Cells(1).Value.ToString
        Txt_Num.Text = Dgv_Search.CurrentRow.Cells(0).Value.ToString
        check = False
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
        'Frm_Reservation_Load(Nothing, Nothing)
        GetAllPatient("Select PatientNum,PatientName,PhoneNumber From PatientsDetail")
        Txt_SearchValue.Text = ""
    End Sub

    Private Sub Btn_SaveNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_SaveNewPatient.Click

        If Txt_Num.Text = "" Then
            MsgBox("You Must Select Patient", MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        If Cbo_ReserveType.Text = "" Then
            MsgBox("You Must Select Visit Type", MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

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

        GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost From Reservation Where Checkok=0 
                           And ReserveDate='" & Format(Today, "yyyy-MM-dd") & "'")
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
        If Cbo_SortAndSearch.Text = "PatientName" And Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "z")) Then
            e.Handled = True
            CType(sender, TextBox).Clear()

        ElseIf Cbo_SortAndSearch.Text = "Phone" And Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Sub Txt_SearchValue_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_SearchValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            dv = Dt_Search.DefaultView
            If Cbo_SortAndSearch.Text = "PatientName" Then
                dv.RowFilter = "PatientName like '" & Txt_SearchValue.Text & "%'"
            ElseIf Cbo_SortAndSearch.Text = "Phone" Then
                dv.RowFilter = "PhoneNumber = '" & Txt_SearchValue.Text & "'"
            End If
        End If
    End Sub

#End Region

#Region "ComboBox"

    Private Sub Cbo_SortAndSearch_TextChanged(sender As Object, e As EventArgs) Handles Cbo_SortAndSearch.TextChanged
        Txt_SearchValue.Text = ""
    End Sub

    Private Sub Dgv_Visits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Visits.CellContentClick

        If e.ColumnIndex = 5 And e.RowIndex >= 0 Then
            Try
                If Dgv_Visits.Rows.Count > 0 Then
                    curid = Dgv_Visits.CurrentRow.Cells(0).Value
                    curdate = Dgv_Visits.CurrentRow.Cells(2).Value
                Else Exit Sub
                End If

                If MsgBox("Do You Want To Delete This Record ?", MsgBoxStyle.Information + vbYesNo + MsgBoxStyle.DefaultButton2, "Attention") = vbYes Then


                    cmd = New SqlCommand("Delete From Reservation Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
                    cmd.Parameters.AddWithValue("@PatientID", curid)
                    cmd.Parameters.AddWithValue("@ReserveDate", curdate)

                    If con.State = 1 Then con.Close()
                    con.Open()
                    cmd.ExecuteNonQuery()
                End If

                Frm_Reservation_Load(Nothing, Nothing)
                frm_ManageReservation.GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,
                                                     Occupation,Height,StartWeight,VisitType From Reservation Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                                                     Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "' ")
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Delete")
            Finally
                If con.State = 1 Then con.Close()
            End Try
        End If
    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click
        Txt_Num.Text = ""
        Txt_PatientName.Text = ""
        Cbo_ReserveType.SelectedIndex = -1
        check = False
    End Sub

    Private Sub Btn_ShowToday_Click(sender As Object, e As EventArgs) Handles Btn_ShowToday.Click
        GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost From Reservation Where Checkok=0 
                           And ReserveDate='" & Format(Today, "yyyy-MM-dd") & "'")
    End Sub

    Private Sub Btn_ShowAll_Click(sender As Object, e As EventArgs) Handles Btn_ShowAll.Click
        GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost From Reservation Where Checkok=0")
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost From Reservation Where Checkok=0 
                           And ReserveDate='" & Format(Dtp_Search.Value, "yyyy-MM-dd") & "'")
    End Sub

    Private Sub Dgv_Visits_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Visits.CellDoubleClick
        Txt_Num.Text = Dgv_Visits.CurrentRow.Cells(0).Value
        Txt_PatientName.Text = Dgv_Visits.CurrentRow.Cells(1).Value
        Dtp_ReserveDate.Text = Dgv_Visits.CurrentRow.Cells(2).Value
        Cbo_ReserveType.Text = Dgv_Visits.CurrentRow.Cells(3).Value
        Txt_VisitCost.Text = Dgv_Visits.CurrentRow.Cells(4).Value
        check = True
    End Sub

    Private Sub Dgv_Visits_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Dgv_Visits.CellPainting
        If e.ColumnIndex = 5 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = My.Resources.Delete_16x16
            e.Graphics.DrawImage(img, e.CellBounds.Left + 45, e.CellBounds.Top + 7, 10, 10)
            e.Handled = True
        End If
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
            GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost From Reservation Where Checkok=0 
                           And ReserveDate='" & Format(Today, "yyyy-MM-dd") & "'")
            TextBoxDepndOnCombobox(Txt_VisitCost, Cbo_ReserveType, "Select Amount From VisitsTypes", "Num")
            Dtp_ReserveDate.Value = Date.Now.ToString("dd-MM-yyyy")
            Dtp_Search.Value = Date.Now.ToString("dd-MM-yyyy")
            check = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

#End Region

#End Region

End Class