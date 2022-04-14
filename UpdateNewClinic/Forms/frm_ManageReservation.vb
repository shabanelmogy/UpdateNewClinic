Imports System.Data.SqlClient

Public Class frm_ManageReservation


    Dim dt_AllVisits As New DataTable
    Dim Query As String
    'لتحميل الكومبوبوكس بعد إكتمال تحميل العناصر 
    Dim FillCombobox As Boolean = False

    Sub GetAllPatient(Query As String)
        Try
            Dim cmd As New SqlCommand(Query, con)

            dt_AllVisits = New DataTable
            Da = New SqlDataAdapter(cmd)
            Da.Fill(dt_AllVisits)

            Dgv_Reservation.DataSource = Nothing
            Dgv_Reservation.DataSource = dt_AllVisits

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub FormatDgv_Search()
        Dgv_Reservation.Columns("PatientName").Width = 300
        Dgv_Reservation.Columns("Code").Width = 75
        Dgv_Reservation.Columns("PatientID").Width = 80
        Dgv_Reservation.Columns("ReserveDate").Width = 140
        Dgv_Reservation.Columns("VisitName").Width = 150
        Dgv_Reservation.Columns("VisitCost").Width = 95
    End Sub

    Private Sub ManageVisits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllPatient("Select PatientID,Reservation.PatientName,FirstDate,Code,ReserveDate,VisitName,VisitCost From Reservation
                        Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                        Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'")
        Dtp_ReserveDate.Value = Date.Now.ToString("dd-MM-yyyy")
        FormatDgv_Search()
        '===================ملء الكومبوكس
        FillCombobox = False
        Fill_Combobox(Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
        FillCombobox = True
        Cbo_VisitType.SelectedIndex = -1
    End Sub

    Private Sub Dtp_ReserveDate_KeyDown(sender As Object, e As KeyEventArgs) Handles Dtp_ReserveDate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GetAllPatient("Select PatientID,Reservation.PatientName,FirstDate,Code,ReserveDate,VisitName,VisitCost From Reservation
                        Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                        Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'")
                FormatDgv_Search()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Cbo_VisitType_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cbo_VisitType.SelectedValueChanged

        If FillCombobox = True Then
            Query = "Select PatientID,Reservation.PatientName,FirstDate,Code,ReserveDate,VisitName,VisitCost From Reservation
                        Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                        Where CheckOk = 0 And VisitType=" & Cbo_VisitType.SelectedValue & " 
                        And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'"

            FilterDatagridview_Combobox(Dgv_Reservation, Cbo_VisitType, Query)
            FormatDgv_Search()
        End If
    End Sub

    Private Sub Cbo_VisitType_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_VisitType.KeyDown

        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            If FillCombobox = True Then
                Query = "Select PatientID,Reservation.PatientName,FirstDate,Code,ReserveDate,VisitName,VisitCost From Reservation
                        Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                        Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'"

                FilterDatagridview_Combobox(Dgv_Reservation, Cbo_VisitType, Query)
                FormatDgv_Search()
            End If
        End If

    End Sub
End Class