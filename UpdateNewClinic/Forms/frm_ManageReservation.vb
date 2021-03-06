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
    Dim Dt_Search As DataTable

#End Region

    Public Function count_Out() As Integer
        Cmd = New SqlCommand("Select Status From Reservation Where Status='Out' And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'", con)
        con.Open()
        rdr = Cmd.ExecuteReader
        Dim countout As Integer = 0
        While rdr.Read
            countout += 1
        End While
        con.Close()
        Return countout
    End Function

    Sub CountVisits()
        Dim Count As Integer = Dgv_MangeReservation.Rows.Count
        If Count > 0 Then
            lbl_CountInside.Text = Count
        Else
            lbl_CountInside.Text = "No Reservations"
        End If

        Dim EntryCount, BookingCount, WaitingCount As Integer
        For i As Integer = 0 To Dgv_MangeReservation.Rows.Count - 1

            If Dgv_MangeReservation.Rows(i).Cells("Status").Value = "Entry" Then
                EntryCount += 1

            ElseIf Dgv_MangeReservation.Rows(i).Cells("Status").Value = "Booking" Then
                BookingCount += 1

            ElseIf Dgv_MangeReservation.Rows(i).Cells("Status").Value = "Waiting" Then
                WaitingCount += 1
            End If
        Next

        Lbl_CountEntry.Text = EntryCount
        Lbl_Booking.Text = BookingCount
        Lbl_CountWaiting.Text = WaitingCount
        Lbl_Exit.Text = count_Out()

    End Sub

    Sub GetAllPatient(Query As String)
        Try
            If con.State = 1 Then con.Close()
            Dim cmd As New SqlCommand(Query, con)
            con.Open()
            rdr = cmd.ExecuteReader
            Dgv_MangeReservation.Rows.Clear()
            While rdr.Read
                Dgv_MangeReservation.Rows.Add(rdr("PatientID").ToString, rdr("PatientName").ToString, rdr("PhoneNumber").ToString, rdr("Code").ToString,
                                             Format(rdr("ReserveDate"), "dd/MM/yyyy"), rdr("VisitName").ToString, rdr("Status").ToString, rdr("VisitCost").ToString, "", "",
                                             Format(rdr("Firstdate"), "dd/MM/yyyy"), rdr("Age").ToString, rdr("Occupation").ToString,
                                             rdr("Height").ToString, rdr("StartWeight").ToString, rdr("VisitType").ToString)

            End While
            rdr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Sub FormatDgv_SearchVisit()
        '===========ضبط مقاسات الاعمدة=============================================================
        Dgv_MangeReservation.Columns("PatientID").Width = 77
        Dgv_MangeReservation.Columns("PatientName").Width = 215
        Dgv_MangeReservation.Columns("PhoneNumber").Width = 120
        Dgv_MangeReservation.Columns("Code").Width = 55
        Dgv_MangeReservation.Columns("VisitCost").Width = 40
        Dgv_MangeReservation.Columns("ReserveDate").Width = 100
        Dgv_MangeReservation.Columns("VisitName").Width = 100
        Dgv_MangeReservation.Columns("VisitCost").Width = 95
        '=================================================
        Dgv_MangeReservation.Columns("Firstdate").Visible = False
        Dgv_MangeReservation.Columns("Age").Visible = False
        Dgv_MangeReservation.Columns("Occupation").Visible = False
        Dgv_MangeReservation.Columns("Height").Visible = False
        Dgv_MangeReservation.Columns("StartWeight").Visible = False
        Dgv_MangeReservation.Columns("VisitType").Visible = False
    End Sub

    Sub FormatDgv_Search()

        Dgv_Search.Columns("PatientNum").Width = 70
        Dgv_Search.Columns("PatientName").Width = 170
        Dgv_Search.Columns("PhoneNumber").Width = 100
        '=========================================================
        Dgv_Search.Columns("Code").Visible = False
        Dgv_Search.Columns("Age").Visible = False
        Dgv_Search.Columns("Occupation").Visible = False
        Dgv_Search.Columns("FirstDate").Visible = False
        Dgv_Search.Columns("Height").Visible = False
        Dgv_Search.Columns("StartWeight").Visible = False
        '========================================================
        Dgv_Search.Columns("PatientNum").HeaderText = "Patient ID"
        Dgv_Search.Columns("PatientName").HeaderText = "Patient Name"
        Dgv_Search.Columns("PhoneNumber").HeaderText = "Phone Number"

    End Sub


    Sub FillDataGridviewWithDataSource(Query As String)
        Try
            Dim cmd As New SqlCommand(Query, con)

            Dt_Search = New DataTable
            Da = New SqlDataAdapter(cmd)
            Da.Fill(Dt_Search)

            Dgv_Search.DataSource = Nothing
            Dgv_Search.DataSource = Dt_Search
            FormatDgv_Search()

            Da.Dispose()
            Dtsearch.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Frm_ManageVisits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,Occupation,
                       Height,StartWeight,VisitType,Status
                       From Reservation Inner Join PatientsDetail 
                       On Reservation.PatientID=PatientsDetail.PatientNum
                       Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'
                       Order By Case 
                       When status='Entry' then 1 
                       When status='Waiting' then 2
                       When status='Booking' then 3
                       When status='Out' then 4
                       End")

        FillDataGridviewWithDataSource("Select PatientNum,PatientName,PhoneNumber,Code,Age,Occupation,FirstDate,Height,StartWeight
                                        From PatientsDetail")

        Fill_Combobox(Cbo_ReserveType, "VisitsTypes", "VisitKind", "Num")
        Cbo_SortAndSearch.SelectedIndex = 0

        Dtp_ReserveDate.Value = Date.Now.ToString("dd-MM-yyyy")
        CountVisits()
        '===================ملء الكومبوكس
        FillCombobox = False
        Fill_Combobox(Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
        Cbo_VisitType.SelectedIndex = -1
        FillCombobox = True
        '==================================================================
        FormatDgv_SearchVisit()
    End Sub

    Private Sub Dtp_ReserveDate_KeyDown(sender As Object, e As KeyEventArgs) Handles Dtp_ReserveDate.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,Occupation,Height,
                               StartWeight,VisitType,status From Reservation Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                               Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "' 
                               Order By Case 
                               When status='Entry' then 1 
                               When status='Waiting' then 2
                               When status='Booking' then 3
                               When status='Out' then 4
                               End")
                FormatDgv_SearchVisit()
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
            GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,Occupation,Height,StartWeight,
                           VisitType,status From Reservation Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum Where CheckOk = 0 
                           And VisitType=" & Cbo_VisitType.SelectedValue & " And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'
                           Order By Case 
                           When status='Entry' then 1 
                           When status='Waiting' then 2
                           When status='Booking' then 3
                           When status='Out' then 4
                           End")
            FormatDgv_SearchVisit()
            CountVisits()
        End If
    End Sub

    Private Sub Cbo_VisitType_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_VisitType.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            If FillCombobox = True Then
                GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,Occupation,Height,StartWeight,
                               VisitType,Status From Reservation Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                               Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "' 
                               Order By Case 
                               When status='Entry' then 1 
                               When status='Waiting' then 2
                               When status='Booking' then 3
                               When status='Out' then 4
                               End")
                FormatDgv_SearchVisit()
                CountVisits()
            End If
        End If
    End Sub

    Private Sub Dgv_Reservation_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Dgv_MangeReservation.CellPainting
        If e.ColumnIndex = 8 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = My.Resources.Open_16_16
            e.Graphics.DrawImage(img, e.CellBounds.Left + 45, e.CellBounds.Top + 7, 10, 10)
            e.Handled = True
        ElseIf e.ColumnIndex = 9 AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = My.Resources.Delete_16x16
            e.Graphics.DrawImage(img, e.CellBounds.Left + 45, e.CellBounds.Top + 7, 10, 10)
            e.Handled = True
        End If
    End Sub

    Private Sub Dgv_Reservation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_MangeReservation.CellContentClick

#Region "Delete Button"
        If e.ColumnIndex = 9 And e.RowIndex >= 0 Then
            Try
                If Dgv_MangeReservation.Rows.Count > 0 Then
                    CurId = Dgv_MangeReservation.CurrentRow.Cells(0).Value
                    CurDate = Dgv_MangeReservation.CurrentRow.Cells(4).Value
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

                'Frm_Booking.FilldatagridviewComboBox_DataReader()
                Frm_Booking.GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost,status From Reservation Where Checkok=0 
                               And ReserveDate='" & Format(Today, "yyyy-MM-dd") & "' 
                               Order By Case 
                               When status='Entry' then 1 
                               When status='Waiting' then 2
                               When status='Booking' then 3
                               When status='Out' then 4
                               End")
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Delete")
            Finally
                If con.State = 1 Then con.Close()
            End Try
#End Region
        ElseIf e.ColumnIndex = 8 And e.RowIndex >= 0 Then
            Dim PatientName As String = Dgv_MangeReservation.Rows(e.RowIndex).Cells(1).Value.ToString
            Dim PatientNum As String = Dgv_MangeReservation.Rows(e.RowIndex).Cells(0).Value

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
                    frm.Txt_PatientNum.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("PatientID").Value
                    frm.Txt_PatientName.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("PatientName").Value
                    frm.Txt_Phone.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("PhoneNumber").Value
                    frm.Txt_Code.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("Code").Value
                    frm.Txt_Age.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("Age").Value
                    frm.Txt_Occupation.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("Occupation").Value
                    frm.Txt_FirstVisit.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("Firstdate").Value
                    frm.Txt_Height.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("Height").Value
                    frm.Txt_StartWeight.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("StartWeight").Value
                    frm.Dtp_VisitDate.Value = Dgv_MangeReservation.Rows(e.RowIndex).Cells("ReserveDate").Value

#End Region

                    frm.Dgv_VisitDetail.ClearSelection()
                    Fill_Combobox(frm.Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
                    frm.Cbo_VisitType.SelectedIndex = -1
                    frm.Cbo_VisitType.SelectedValue = Dgv_MangeReservation.Rows(e.RowIndex).Cells("VisitType").Value
                    frm.Txt_VisitCost.Text = Dgv_MangeReservation.Rows(e.RowIndex).Cells("VisitCost").Value

                    '=======================================================================================================================
                    frm.FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewBmi,PlanOfTreatment,EatingHabits,Notes from ClinicDays
                                             Inner Join VisitsTypes on ClinicDays.VisitType = VisitsTypes.Num Where PatientID = " & PatientNum)
                End If
            Next
            frm.Show()
        End If
    End Sub

    Private Sub Dgv_Reservation_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Dgv_MangeReservation.CellFormatting
        For Each row As DataGridViewRow In Dgv_MangeReservation.Rows
            If Not row.IsNewRow Then
                Select Case row.Cells("Status").Value.ToString
                    Case "Waiting"
                        row.DefaultCellStyle.BackColor = Color.Wheat
                    Case "Booking"
                        row.DefaultCellStyle.BackColor = Color.LightSteelBlue
                    Case "Entry"
                        row.DefaultCellStyle.BackColor = Color.FromArgb(78, 236, 145)
                    Case "Out"
                        row.DefaultCellStyle.BackColor = Color.LightCoral
                End Select
            End If
        Next
    End Sub

    Private Sub Btn_EditPatient_Click(sender As Object, e As EventArgs) Handles Btn_EditPatient.Click

        Checkfrm = 1

        With frm_ModifyPatient
            .Txt_PatientNum.Text = Dgv_Search.CurrentRow.Cells("PatientNum").Value
            .Txt_PatientName.Text = Dgv_Search.CurrentRow.Cells("PatientName").Value
            .Txt_PhoneNumber.Text = Dgv_Search.CurrentRow.Cells("PhoneNumber").Value.ToString
            .Txt_Code.Text = Dgv_Search.CurrentRow.Cells("Code").Value.ToString
            .Txt_Age.Text = Dgv_Search.CurrentRow.Cells("Age").Value
            .Txt_Occupation.Text = Dgv_Search.CurrentRow.Cells("Occupation").Value
            .Dtp_PatientFirstDate.Value = Dgv_Search.CurrentRow.Cells("FirstDate").Value
            .Txt_Height.Text = Dgv_Search.CurrentRow.Cells("Height").Value
            .Txt_StartWeight.Text = Dgv_Search.CurrentRow.Cells("StartWeight").Value

            .StartPosition = FormStartPosition.CenterScreen
            .Show()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Txt_SearchValue_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_SearchValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dv = Dt_Search.DefaultView
            If Cbo_SortAndSearch.Text = "PatientName" Then
                Dv.RowFilter = "PatientName like '" & Txt_SearchValue.Text & "%'"
            ElseIf Cbo_SortAndSearch.Text = "Phone" Then
                Dv.RowFilter = "PhoneNumber = '" & Txt_SearchValue.Text & "'"
            End If
        End If
        If e.KeyCode = Keys.Delete Then
            FillDataGridviewWithDataSource("Select PatientNum,PatientName,PhoneNumber,Code,Age,Occupation,FirstDate,Height,StartWeight
                                            From PatientsDetail")
            Txt_SearchValue.Text = ""
        End If
    End Sub

    Private Sub Txt_SearchValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SearchValue.KeyPress
        If Cbo_SortAndSearch.Text = "PatientName" And (Char.IsControl(e.KeyChar) = False And Char.IsLetter(e.KeyChar) = False And Not e.KeyChar = " ") Then
            e.Handled = True
        ElseIf Cbo_SortAndSearch.Text = "Phone" And Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub Btn_NewPatient_Click(sender As Object, e As EventArgs) Handles Btn_NewPatient.Click
        Dim frm As New Frm_NewClient
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Txt_PatientNum.Text = GetMaxId("PatientNum", "PatientsDetail") + 1
        frm.Dtp_PatientFirstDate.Value = Date.Now.ToString("dd-MM-yyyy")
        frm.Show()
    End Sub
End Class