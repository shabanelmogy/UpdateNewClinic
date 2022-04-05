Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Btn_ShowReport

    Dim Con As New SqlConnection("Server=.;DataBase=Clinic;Integrated Security=True")
    Dim SQL As String = ""
    Dim ParaDateFrom As New ReportParameter
    Dim ParaDateTo As New ReportParameter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If DateFrom.CustomFormat <> " " And DateTo.CustomFormat <> " " Then
            SQL = "SELECT ClinicDays.VisitDate, ClinicDays.PatientID, ClinicDays.PatientName, ClinicDays.VisitCost, ClinicDays.NewWeight,
                                 ClinicDays.NewWaist, ClinicDays.PlanOfTreatment, ClinicDays.EatingHabits, ClinicDays.Notes, 
                                 VisitsTypes.VisitKind FROM ClinicDays INNER JOIN VisitsTypes ON ClinicDays.VisitType = VisitsTypes.Num
                                 Where ClinicDays.VisitDate Between @VisitFrom And @VisitTo"
        Else
            SQL = "SELECT ClinicDays.VisitDate, ClinicDays.PatientID, ClinicDays.PatientName, ClinicDays.VisitCost, ClinicDays.NewWeight,
                                 ClinicDays.NewWaist, ClinicDays.PlanOfTreatment, ClinicDays.EatingHabits, ClinicDays.Notes, 
                                 VisitsTypes.VisitKind FROM ClinicDays INNER JOIN VisitsTypes ON ClinicDays.VisitType = VisitsTypes.Num"
        End If

        Dim cmd As New SqlCommand(SQL, Con)
        With cmd.Parameters
            If Not String.IsNullOrWhiteSpace(DateFrom.Value) Then
                .AddWithValue("@VisitFrom", DateFrom.Value).DbType = DbType.Date
            Else
                .AddWithValue("@VisitFrom", DBNull.Value)
            End If

            If Not String.IsNullOrWhiteSpace(DateTo.Value) Then
                .AddWithValue("@VisitTo", DateTo.Value).DbType = DbType.Date
            Else
                .AddWithValue("@VisitTo", DBNull.Value)
            End If
        End With
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, 0)

        If DateFrom.CustomFormat <> " " And DateTo.CustomFormat <> " " Then
            ParaDateFrom = New ReportParameter("DateFrom", DateTo.Value)
            ParaDateTo = New ReportParameter("DateTo", DateFrom.Value)
        End If

        Dim Rd As New ReportDataSource("DataSet1", ds.Tables(0))
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(Rd)

        Dim newPageSettings As New System.Drawing.Printing.PageSettings
        newPageSettings.Margins = New System.Drawing.Printing.Margins(15, 15, 15, 15)
        ReportViewer1.SetPageSettings(newPageSettings)

        ReportViewer1.LocalReport.ReportEmbeddedResource = "UpdateNewClinic.DailyPays.rdlc"

        ReportViewer1.LocalReport.SetParameters(ParaDateFrom)
        ReportViewer1.LocalReport.SetParameters(ParaDateTo)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DailyPays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateFrom.Value = Today.ToString("dd/MM/yyyy")
        DateTo.Value = Today.ToString("dd/MM/yyyy")
    End Sub


End Class