﻿Imports System.Data.SqlClient

Public Class Frm_PatientVisit

#Region "Declaration"
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dr As SqlDataAdapter
    Dim DtVisits As New DataTable
#End Region

    Sub Fill_DataTableVisitDetails(Query As String, frm As Form)

        cmd = New SqlCommand(Query, con)
        da = New SqlDataAdapter(cmd)
        dtvisitDetail = New DataTable("VisitDetails")
        dtvisitDetail.Clear()
        da.Fill(dtvisitDetail)

        For Each row As DataRow In dtvisitDetail.Rows
            For columnindex = 0 To dtvisitDetail.Columns.Count - 1
                If row.IsNull(columnindex) Then
                    Dim t = dtvisitDetail.Columns(columnindex).DataType
                    row(columnindex) = If(t Is GetType(String), String.Empty, Activator.CreateInstance(t))
                End If
            Next
        Next

        dv = New DataView(dtvisitDetail)
        cur = CType(frm.BindingContext(dv), CurrencyManager)

    End Sub

    Sub LoadCost()

        cmd = New SqlCommand("Select Amount From VisitsTypes Where Num=" & Cbo_VisitType.SelectedValue, con)
        con.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader
        dr.Read()
        Txt_VisitCost.Text = dr(0)
        con.Close()

    End Sub

    Sub FillGrdVisitDetails(Query As String)

        Fill_DataTableVisitDetails(Query, Me)
        dgvColumnWidth()

        Dgv_VisitDetail.Rows.Clear()
        For i = 0 To cur.Count - 1
            Dgv_VisitDetail.Rows.Add(New String() {cur.Current("VisitDate"), cur.Current("VisitKind"), cur.Current("VisitCost"), cur.Current("NewWeight"),
                                     cur.Current("NewWaist"), cur.Current("PlanOfTreatment"), cur.Current("EatingHabits"), cur.Current("Notes")})
            cur.Position += 1
        Next
    End Sub

    Sub DgvColumnWidth()
        Try
            Dgv_VisitDetail.Columns("VisitDate").Width = 100
            Dgv_VisitDetail.Columns("VisitType").Width = 130
            Dgv_VisitDetail.Columns("VisitCost").Width = 80
            Dgv_VisitDetail.Columns("NewWeight").Width = 100
            Dgv_VisitDetail.Columns("NewWaist").Width = 100
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
                    Txt_Phone1.Text = dr("PhoneNumber").ToString
                    Txt_FirstVisit.Text = CDate(dr("FirstDate").ToString).ToString("dd/MM/yyyy")
                    Txt_Height.Text = dr("Height").ToString
                    Txt_StartWeight.Text = dr("StartWeight").ToString

                End While
                dr.Close()
                con.Close()
                Dtp_VisitDate.Focus()
                FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewWaist,PlanOfTreatment,EatingHabits,Notes from ClinicDays 
                                inner join VisitsTypes on ClinicDays.VisitType = VisitsTypes.Num Where PatientID=" & Val(Txt_PatientNum.Text))
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
        dgvColumnWidth()
        FillCmb(Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
        Cbo_VisitType.SelectedIndex = -1
        Dtp_VisitDate.Value = Date.Now.ToString("dd-MM-yyyy")
    End Sub

    Private Sub Cbo_VisitType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_VisitType.SelectionChangeCommitted
        LoadCost()
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
            cmd = New SqlCommand("Insert Into ClinicDays (VisitDate,PatientID,PatientName,VisitType,VisitCost,NewWeight,NewWaist,PlanOfTreatment,EatingHabits,Notes)
                                   Values(@VisitDate,@PatientID,@PatientName,@VisitType,@VisitCost,@NewWeight,@NewWaist,@PlanOfTreatment,@EatingHabits,@Notes)", con)
        Else
            cmd = New SqlCommand("Update ClinicDays Set VisitType=@VisitType,VisitCost=@VisitCost,NewWeight=@NewWeight,NewWaist=@NewWaist,
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
            .AddWithValue("@NewWaist", Val(Txt_NewWaist.Text)).DbType = DbType.Int16
            .AddWithValue("@PlanOfTreatment", Txt_PlanOfTreatment.Text).DbType = DbType.String
            .AddWithValue("@EatingHabits", Txt_EatingHabits.Text).DbType = DbType.String
            .AddWithValue("@Notes", Txt_Notes.Text).DbType = DbType.String
        End With

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        MsgBox("Done")
        FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewWaist,PlanOfTreatment,EatingHabits,Notes From ClinicDays 
                             Inner Join VisitsTypes On ClinicDays.VisitType = VisitsTypes.Num Where PatientID=" & Val(Txt_PatientNum.Text))
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
        Dtp_VisitDate.Value = Dgv_VisitDetail.CurrentRow.Cells(0).Value
        Cbo_VisitType.Text = Dgv_VisitDetail.CurrentRow.Cells(1).Value
        Txt_VisitCost.Text = Dgv_VisitDetail.CurrentRow.Cells(2).Value
        Txt_NewWeight.Text = Dgv_VisitDetail.CurrentRow.Cells(3).Value
        Txt_NewWaist.Text = Dgv_VisitDetail.CurrentRow.Cells(4).Value
        Txt_PlanOfTreatment.Text = Dgv_VisitDetail.CurrentRow.Cells(5).Value
        Txt_EatingHabits.Text = Dgv_VisitDetail.CurrentRow.Cells(6).Value
        Txt_Notes.Text = Dgv_VisitDetail.CurrentRow.Cells(7).Value
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

                FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewWaist,PlanOfTreatment,EatingHabits,Notes From ClinicDays 
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

End Class