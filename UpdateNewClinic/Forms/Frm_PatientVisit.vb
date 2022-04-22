Imports System.Data.SqlClient

Public Class Frm_PatientVisit

#Region "Declaration"
    Dim cmd, cmd1 As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dr As SqlDataAdapter
    Dim DtVisits As New DataTable
#End Region

    Sub FillGrdVisitDetails(Query As String)

        Fill_DataTableVisitDetails(Query, Me)
        dgvColumnWidth()

        Dgv_VisitDetail.Rows.Clear()
        For i = 0 To cur.Count - 1
            Dgv_VisitDetail.Rows.Add(New String() {Cur.Current("VisitDate"), Cur.Current("VisitKind"), Cur.Current("VisitCost"), Cur.Current("NewWeight"),
                                     Cur.Current("NewBmi"), Cur.Current("PlanOfTreatment"), Cur.Current("EatingHabits"), Cur.Current("Notes")})
            Cur.Position += 1
        Next
    End Sub

    Sub DgvColumnWidth()
        Try
            Dgv_VisitDetail.Columns("VisitDate").Width = 100
            Dgv_VisitDetail.Columns("VisitType").Width = 130
            Dgv_VisitDetail.Columns("VisitCost").Width = 80
            Dgv_VisitDetail.Columns("NewWeight").Width = 100
            Dgv_VisitDetail.Columns("NewBmi").Width = 100
            Dgv_VisitDetail.Columns("PlanOfTreatment").Width = 235
            Dgv_VisitDetail.Columns("EatingHabits").Width = 235
            Dgv_VisitDetail.Columns("Notes").Width = 450
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Info")
        End Try
    End Sub

    Public Sub Get_PatientDetail()
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            Dim cmd As New SqlCommand("Select * From PatientsDetail Where PatientNum=@PatientNum", con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PatientNum", Val(Txt_PatientNum.Text)).Value.ToString()
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    Txt_PatientNum.Text = dr("PatientNum").ToString
                    Txt_PatientName.Text = dr("PatientName").ToString
                    Txt_Code.Text = dr("Code").ToString
                    Txt_Age.Text = dr("Age").ToString
                    Txt_Occupation.Text = dr("Occupation").ToString
                    Txt_Phone.Text = dr("PhoneNumber").ToString
                    Txt_FirstVisit.Text = CDate(dr("FirstDate").ToString).ToString("dd/MM/yyyy")
                    Txt_Height.Text = dr("Height").ToString
                    Txt_StartWeight.Text = dr("StartWeight").ToString
                End While
                dr.Close()
                con.Close()
                Dtp_VisitDate.Focus()

                FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewBmi,PlanOfTreatment,EatingHabits,Notes from ClinicDays 
                                     Inner Join VisitsTypes on ClinicDays.VisitType = VisitsTypes.Num 
                                     Where PatientID=" & Val(Txt_PatientNum.Text) & " order By VisitDate Desc ")
            Else
                Dgv_VisitDetail.Rows.Clear()
                ResetControls(Pnl_VisitDetails)
                ResetControls(Pnl_PatientDetail)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Exit Sub
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Txt_PatientNum_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_PatientNum.KeyDown
        If e.KeyCode = Keys.Enter And Txt_PatientNum.TextLength > 0 Then
            Get_PatientDetail()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Frm_PatientVisit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvColumnWidth()
        Txt_NewWeight.Select()
        'Fill_Combobox(Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
        'Cbo_VisitType.SelectedIndex = -1
        'Dtp_VisitDate.Value = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Cbo_VisitType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_VisitType.SelectionChangeCommitted
        TextBoxDepndOnCombobox(Txt_VisitCost, Cbo_VisitType, "Select Amount From VisitsTypes", "Num")
    End Sub

    Private Sub BtnStrip_Save_Click(sender As Object, e As EventArgs) Handles BtnStrip_Save.Click

        If String.IsNullOrWhiteSpace(Txt_NewWeight.Text) Then
            MsgBox("You must Enter New Weight", MsgBoxStyle.Information, "Stop")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(Txt_NewWaist.Text) Then
            MsgBox("You must Enter New Waist", MsgBoxStyle.Information, "Stop")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(Txt_PlanOfTreatment.Text) Then
            MsgBox("You must Enter Plan Of Treatment", MsgBoxStyle.Information, "Stop")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(Txt_EatingHabits.Text) Then
            MsgBox("You must Enter Eating Habits", MsgBoxStyle.Information, "Stop")
            Exit Sub
        ElseIf String.IsNullOrWhiteSpace(Txt_VisitCost.Text) Then
            MsgBox("You must Enter Visit Cost", MsgBoxStyle.Information, "Stop")
            Exit Sub
        End If

        cmd = New SqlCommand("Select PatientID From ClinicDays Where PatientID=@PatientID And VisitDate=@VisitDate ", con)
        cmd.Parameters.AddWithValue("@PatientID", Val(Txt_PatientNum.Text)).DbType = DbType.Int32
        cmd.Parameters.AddWithValue("@VisitDate", Dtp_VisitDate.Value).DbType = DbType.Date

        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        dr.Read()

        If Not dr.HasRows Then
            cmd = New SqlCommand("Insert Into ClinicDays (VisitDate,PatientID,PatientName,VisitType,VisitCost,NewWeight,NewBmi,PlanOfTreatment,EatingHabits,Notes)
                                   Values(@VisitDate,@PatientID,@PatientName,@VisitType,@VisitCost,@NewWeight,@NewBmi,@PlanOfTreatment,@EatingHabits,@Notes)", con)

        Else
            cmd = New SqlCommand("Update ClinicDays Set VisitType=@VisitType,VisitCost=@VisitCost,NewWeight=@NewWeight,NewBmi=@NewBmi,
                                  PlanOfTreatment=@PlanOfTreatment,EatingHabits=@EatingHabits,Notes=@Notes Where PatientName=@PatientName And VisitDate=@VisitDate ", con)
        End If

        con.Close()

        With cmd.Parameters
            .AddWithValue("@PatientID", Val(Txt_PatientNum.Text)).DbType = DbType.Int64
            .AddWithValue("@VisitDate", Dtp_VisitDate.Value).DbType = DbType.Date
            .AddWithValue("@PatientName", Txt_PatientName.Text).DbType = DbType.String
            .AddWithValue("@VisitType", Cbo_VisitType.SelectedValue).DbType = DbType.Int16
            .AddWithValue("@VisitCost", Val(Txt_VisitCost.Text)).DbType = DbType.Double
            .AddWithValue("@NewWeight", Val(Txt_NewWeight.Text)).DbType = DbType.Int16
            .AddWithValue("@NewBmi", Val(Txt_NewWaist.Text)).DbType = DbType.Int16
            .AddWithValue("@PlanOfTreatment", Txt_PlanOfTreatment.Text).DbType = DbType.String
            .AddWithValue("@EatingHabits", Txt_EatingHabits.Text).DbType = DbType.String
            .AddWithValue("@Notes", Txt_Notes.Text).DbType = DbType.String
        End With

        'تحديث حالة المرضى الذين تم الكشف عليهم 
        cmd1 = New SqlCommand("Update Reservation Set Checkok = 1,Status='Out' Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
        With cmd1.Parameters
            .AddWithValue("@PatientID", Val(Txt_PatientNum.Text)).DbType = DbType.Int64
            .AddWithValue("@ReserveDate", Dtp_VisitDate.Value).DbType = DbType.Date
        End With

        con.Open()
        cmd.ExecuteNonQuery()
        cmd1.ExecuteNonQuery()
        con.Close()

        MsgBox("Visit Added", MsgBoxStyle.Information, "Info")
        '======================================================================================================================================================
        'تحديث شاشة من أتم الكشف
        FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewBmi,PlanOfTreatment,EatingHabits,Notes From ClinicDays 
                             Inner Join VisitsTypes On ClinicDays.VisitType = VisitsTypes.Num 
                             Where PatientID=" & Val(Txt_PatientNum.Text) & " Order By VisitDate Desc")
        'تحديث شاشة حجز الدكتور
        frm_ManageReservation.GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,
                                             Occupation,Height,StartWeight,VisitType,status From Reservation 
                                             Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                                             Where CheckOk = 0 And ReserveDate='" & Format(frm_ManageReservation.Dtp_ReserveDate.Value, "yyyy-MM-dd") & "' 
                                             Order By Case 
                                             When status='Entry' then 1 
                                             When status='Waiting' then 2
                                             When status='Booking' then 3
                                             When status='Out' then 4
                                             End")
        'تحديث شاشة حجز السكرتارية
        Frm_Booking.GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost,status From Reservation Where Checkok=0 
                                       Order By Case 
                                       When status='Entry' then 1 
                                       When status='Waiting' then 2
                                       When status='Booking' then 3
                                       When status='Out' then 4
                                       End")

        Txt_PatientNum.Select()
    End Sub

    Private Sub Cbo_VisitType_KeyDown(sender As Object, e As KeyEventArgs) Handles Cbo_VisitType.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_NewWeight.Select()
        End If
    End Sub

    Private Sub Txt_NewWeight_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_NewWeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_NewWaist.Select()
        End If
    End Sub

    Private Sub Txt_NewWaist_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_NewWaist.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_PlanOfTreatment.Select()
        End If
    End Sub

    Private Sub Txt_PlanOfTreatment_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_PlanOfTreatment.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_EatingHabits.Select()
        End If
    End Sub

    Private Sub Txt_EatingHabits_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_EatingHabits.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_Notes.Select()
        End If
    End Sub

    Private Sub Txt_Notes_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Notes.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnStrip_Save.PerformClick()
        End If
    End Sub

    Private Sub Txt_NewWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NewWeight.KeyPress, Txt_NewWaist.KeyPress
        'Numeric Textbox
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Dgv_VisitDetail_SelectionChanged(sender As Object, e As EventArgs) Handles Dgv_VisitDetail.SelectionChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ResetControls(Pnl_VisitDetails)
        Dtp_VisitDate.Focus()
    End Sub

    Private Sub BtnStrp_Delete_Click(sender As Object, e As EventArgs) Handles BtnStrp_Delete.Click
        Try
            If MsgBox("Do You Want To Delete This Record ?", MsgBoxStyle.Information + vbYesNo + MsgBoxStyle.DefaultButton2, "Attention") = vbYes Then

                cmd = New SqlCommand("Delete From ClinicDays Where PatientID=@PatientID And VisitDate=@VisitDate", con)
                cmd.Parameters.AddWithValue("@PatientID", Val(Txt_PatientNum.Text))
                cmd.Parameters.AddWithValue("@VisitDate", Dtp_VisitDate.Value)

                con.Open()
                cmd.ExecuteNonQuery()

                FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewBmi,PlanOfTreatment,EatingHabits,Notes From ClinicDays 
                                 Inner Join VisitsTypes On ClinicDays.VisitType = VisitsTypes.Num Where PatientID=" & Val(Txt_PatientNum.Text))

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Delete")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Dtp_VisitDate_KeyDown(sender As Object, e As KeyEventArgs) Handles Dtp_VisitDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_VisitType.Select()
        End If
    End Sub

    Private Sub Cbo_VisitType_DropDown(sender As Object, e As EventArgs) Handles Cbo_VisitType.DropDown
        Fill_Combobox(Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
    End Sub

    Private Sub Dgv_VisitDetail_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_VisitDetail.DoubleClick
        Dtp_VisitDate.Value = Dgv_VisitDetail.CurrentRow.Cells(0).Value
        Cbo_VisitType.Text = Dgv_VisitDetail.CurrentRow.Cells(1).Value
        Txt_VisitCost.Text = Dgv_VisitDetail.CurrentRow.Cells(2).Value
        Txt_NewWeight.Text = Dgv_VisitDetail.CurrentRow.Cells(3).Value
        Txt_NewWaist.Text = Dgv_VisitDetail.CurrentRow.Cells(4).Value
        Txt_PlanOfTreatment.Text = Dgv_VisitDetail.CurrentRow.Cells(5).Value
        Txt_EatingHabits.Text = Dgv_VisitDetail.CurrentRow.Cells(6).Value
        Txt_Notes.Text = Dgv_VisitDetail.CurrentRow.Cells(7).Value
    End Sub

    Private Sub Txt_PatientNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_PatientNum.KeyPress
        If (Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False) Then
            e.Handled = True
        End If
    End Sub
End Class