Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class DailyTotals

    Dim SQL As String = ""

    Private Sub Btn_ShowReport_Click(sender As Object, e As EventArgs) Handles Btn_ShowReport.Click

        If DateFrom.CustomFormat <> " " And DateTo.CustomFormat <> " " Then
            SQL = "SELECT VisitsTypes.VisitKind, ClinicDays.VisitDate, ClinicDays.PatientID, ClinicDays.PatientName, ClinicDays.VisitCost 
               FROM ClinicDays INNER JOIN VisitsTypes ON ClinicDays.VisitType = VisitsTypes.Num Where ClinicDays.VisitDate Between @VisitFrom And @VisitTo"
        Else
            SQL = "SELECT VisitsTypes.VisitKind, ClinicDays.VisitDate, ClinicDays.PatientID, ClinicDays.PatientName, ClinicDays.VisitCost 
               FROM ClinicDays INNER JOIN VisitsTypes ON ClinicDays.VisitType = VisitsTypes.Num"
        End If

        Dim cmd As New SqlCommand(SQL, con)
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

        Dim Rd As New ReportDataSource("DataSet2", ds.Tables(0))
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(Rd)

        'ضبط هوامش التقرير الافتراضية
        Dim newPageSettings As New System.Drawing.Printing.PageSettings
        newPageSettings.Margins = New System.Drawing.Printing.Margins(15, 15, 15, 15)

        ReportViewer1.SetPageSettings(newPageSettings)


        ReportViewer1.LocalReport.ReportEmbeddedResource = "UpdateNewClinic.DailyTotals.rdlc"

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DailyTotals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateFrom.Value = Today.ToString("dd/MM/yyyy")
        DateTo.Value = Today.ToString("dd/MM/yyyy")
    End Sub
End Class