Imports System.Data.SqlClient

Public Class frm_ManageReservation

#Region "Declaration"
    Dim dt_AllVisits As New DataTable
    Dim Query As String
    'لتحميل الكومبوبوكس بعد إكتمال تحميل العناصر 
    Dim FillCombobox As Boolean = False
    Dim CurId As Integer
    Dim CurDate As Date
    Dim rdr As SqlDataReader
#End Region

    Sub CountVisits()
        Dim Count As Integer = Dgv_Reservation.Rows.Count
        If Count > 0 Then
            Lbl_Count.Text = Count
        Else
            Lbl_Count.Text = "No Reservations"
        End If
    End Sub

    Sub GetAllPatient(Query As String)
        Try
            If con.State = 1 Then con.Close()
            Dim cmd As New SqlCommand(Query, con)
            con.Open()
            rdr = cmd.ExecuteReader
            Dgv_Reservation.Rows.Clear()
            While rdr.Read
                Dgv_Reservation.Rows.Add(rdr("PatientID"), rdr("PatientName"), rdr("PhoneNumber"), rdr("Code"),
                                              Format(rdr("ReserveDate"), "dd/MM/yyyy"), rdr("VisitName"), rdr("VisitCost"))
            End While
            rdr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub FormatDgv_Search()
        Dgv_Reservation.Columns("PatientID").Width = 77
        Dgv_Reservation.Columns("PatientName").Width = 300
        Dgv_Reservation.Columns("PhoneNumber").Width = 120
        Dgv_Reservation.Columns("Code").Width = 75
        Dgv_Reservation.Columns("ReserveDate").Width = 140
        Dgv_Reservation.Columns("VisitName").Width = 150
        Dgv_Reservation.Columns("VisitCost").Width = 95
    End Sub

    Private Sub Frm_ManageVisits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost From Reservation
                        Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                        Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "' ")

        Dtp_ReserveDate.Value = Date.Now.ToString("dd-MM-yyyy")
        FormatDgv_Search()
        CountVisits()
        '===================ملء الكومبوكس
        FillCombobox = False
        Fill_Combobox(Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
        Cbo_VisitType.SelectedIndex = -1
        FillCombobox = True
        '==================================================================
    End Sub

    Private Sub Dtp_ReserveDate_KeyDown(sender As Object, e As KeyEventArgs) Handles Dtp_ReserveDate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost From Reservation
                        Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                        Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'")
                FormatDgv_Search()
                CountVisits()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Cbo_VisitType_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cbo_VisitType.SelectedValueChanged

        If FillCombobox = True Then
            GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost From Reservation
                           Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum Where CheckOk = 0 
                           And VisitType=" & Cbo_VisitType.SelectedValue & " And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'")
            FormatDgv_Search()
            CountVisits()
        End If
    End Sub

    Private Sub Cbo_VisitType_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_VisitType.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            If FillCombobox = True Then
                GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost From Reservation
                           Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum Where CheckOk = 0 
                           And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'")
                FormatDgv_Search()
                CountVisits()
            End If
        End If
    End Sub

    Private Sub Dgv_Reservation_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Dgv_Reservation.CellPainting
        If e.ColumnIndex = 7 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = My.Resources.Open_16_16
            e.Graphics.DrawImage(img, e.CellBounds.Left + 45, e.CellBounds.Top + 7, 10, 10)
            e.Handled = True
        ElseIf e.ColumnIndex = 8 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = My.Resources.Delete_16x16
            e.Graphics.DrawImage(img, e.CellBounds.Left + 45, e.CellBounds.Top + 7, 10, 10)
            e.Handled = True
        End If
    End Sub

    Private Sub Dgv_Reservation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Reservation.CellContentClick
        If e.ColumnIndex = 8 And e.RowIndex >= 0 Then
            Try

                If Dgv_Reservation.Rows.Count > 0 Then
                    CurId = Dgv_Reservation.CurrentRow.Cells(0).Value
                    CurDate = Dgv_Reservation.CurrentRow.Cells(4).Value
                Else Exit Sub
                End If

                If MsgBox("Do You Want To Delete This Record ?", MsgBoxStyle.Information + vbYesNo + MsgBoxStyle.DefaultButton2, "Attention") = vbYes Then


                    Cmd = New SqlCommand("Delete From Reservation Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
                    Cmd.Parameters.AddWithValue("@PatientID", CurId)
                    Cmd.Parameters.AddWithValue("@ReserveDate", CurDate)

                    If con.State = 1 Then con.Close()
                    con.Open()
                    Cmd.ExecuteNonQuery()

                End If

                Frm_ManageVisits_Load(Nothing, Nothing)
                Frm_Reservation.GetAllReservation()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Delete")
            Finally
                If con.State = 1 Then con.Close()
            End Try
        End If
    End Sub
End Class