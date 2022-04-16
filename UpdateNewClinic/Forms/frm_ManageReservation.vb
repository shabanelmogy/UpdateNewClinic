Imports System.Data.SqlClient
Imports DevExpress.XtraTab

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
                Dgv_Reservation.Rows.Add(rdr("PatientID"), rdr("PatientName"), rdr("PhoneNumber"), rdr("Code"), Format(rdr("ReserveDate"), "dd/MM/yyyy"),
                                             rdr("VisitName"), rdr("VisitCost"), "", "", Format(rdr("Firstdate"), "dd/MM/yyyy"), rdr("Age"), rdr("Occupation"),
                                             rdr("Height"), rdr("StartWeight"), rdr("VisitType"))

            End While
            rdr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub FormatDgv_Search()
        '===========ضبط مقاسات الاعمدة=============================================================
        Dgv_Reservation.Columns("PatientID").Width = 77
        Dgv_Reservation.Columns("PatientName").Width = 300
        Dgv_Reservation.Columns("PhoneNumber").Width = 120
        Dgv_Reservation.Columns("Code").Width = 75
        Dgv_Reservation.Columns("ReserveDate").Width = 140
        Dgv_Reservation.Columns("VisitName").Width = 150
        Dgv_Reservation.Columns("VisitCost").Width = 95
        '=================================================
        Dgv_Reservation.Columns("Firstdate").Visible = False
        Dgv_Reservation.Columns("Age").Visible = False
        Dgv_Reservation.Columns("Occupation").Visible = False
        Dgv_Reservation.Columns("Height").Visible = False
        Dgv_Reservation.Columns("StartWeight").Visible = False
        'Dgv_Reservation.Columns("VisitType").Visible = False
    End Sub

    Private Sub Frm_ManageVisits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,Occupation,Height,StartWeight,VisitType
                       From Reservation Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                       Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "' ")

        Dtp_ReserveDate.Value = Date.Now.ToString("dd-MM-yyyy")
        CountVisits()
        '===================ملء الكومبوكس
        FillCombobox = False
        Fill_Combobox(Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
        Cbo_VisitType.SelectedIndex = -1
        FillCombobox = True
        '==================================================================
        FormatDgv_Search()
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

#Region "Delete Button"
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
#End Region
        ElseIf e.ColumnIndex = 7 And e.RowIndex >= 0 Then
            Dim PatientName As String = Dgv_Reservation.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim PatientNum As String = Dgv_Reservation.Rows(e.RowIndex).Cells(0).Value

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
#Region "OldCode"
                    frm.Txt_PatientNum.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("PatientID").Value
                    frm.Txt_PatientName.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("PatientName").Value
                    frm.Txt_Phone.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("PhoneNumber").Value
                    frm.Txt_Code.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("Code").Value
                    frm.Txt_Age.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("Age").Value
                    frm.Txt_Occupation.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("Occupation").Value
                    frm.Txt_FirstVisit.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("Firstdate").Value
                    frm.Txt_Height.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("Height").Value
                    frm.Txt_StartWeight.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("StartWeight").Value
                    frm.Dtp_VisitDate.Value = Dgv_Reservation.Rows(e.RowIndex).Cells("ReserveDate").Value

#End Region

                    frm.Dgv_VisitDetail.ClearSelection()
                    Fill_Combobox(frm.Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
                    frm.Cbo_VisitType.SelectedIndex = -1
                    frm.Cbo_VisitType.SelectedValue = Dgv_Reservation.Rows(e.RowIndex).Cells("VisitType").Value
                    frm.Txt_VisitCost.Text = Dgv_Reservation.Rows(e.RowIndex).Cells("VisitCost").Value

                    '=======================================================================================================================
                    frm.FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewWaist,PlanOfTreatment,EatingHabits,Notes from ClinicDays
                                             Inner Join VisitsTypes on ClinicDays.VisitType = VisitsTypes.Num Where PatientID = " & PatientNum)

                End If
            Next
            frm.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Reservedate As Date = Dgv_Reservation.CurrentRow.Cells("ReserveDate").Value
        MsgBox(Reservedate)
    End Sub
End Class