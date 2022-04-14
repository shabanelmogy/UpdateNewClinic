Imports System.Data.SqlClient

Public Class frm_ManageVisits

    Dim dt_AllVisits As New DataTable

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
    End Sub

    Private Sub ManageVisits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllPatient("Select PatientID,Reservation.PatientName,FirstDate,Code,ReserveDate,VisitName,VisitCost From Reservation
                        Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                        Where CheckOk = 0")

        FormatDgv_Search()
    End Sub
End Class