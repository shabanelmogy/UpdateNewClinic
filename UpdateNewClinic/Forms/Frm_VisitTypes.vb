Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Frm_VisitTypes

#Region "Declaration"
    Dim Dt_VisitType As DataTable
    Dim curid As Integer
#End Region

#Region "Events"

#Region "Buttons"

    Private Sub Btn_AddNewVisit_Click(sender As Object, e As EventArgs) Handles Btn_AddNewVisit.Click
        Try
            Dgv_VisitType.Rows.Add(GetMaxId("Num", "VisitsTypes") + 1)
            Dgv_VisitType.CurrentCell = Dgv_VisitType.Rows(Dgv_VisitType.Rows.Count - 1).Cells(1)

            'Cursor inside cell datagridview 
            Dgv_VisitType.BeginEdit(False)
            Btn_AddNewVisit.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Btn_SaveNewVisit_Click(sender As Object, e As EventArgs) Handles Btn_SaveNewVisit.Click
        Try
            If con.State = 1 Then con.Close()

            For Each row As DataGridViewRow In Dgv_VisitType.Rows

                If String.IsNullOrWhiteSpace(row.Cells("VisitKind").Value) Then
                    MsgBox("You must Enter VisitKind", MsgBoxStyle.Information, "Stop")
                    Dgv_VisitType.CurrentCell = Dgv_VisitType.Rows(Dgv_VisitType.Rows.Count - 1).Cells("VisitKind")
                    Dgv_VisitType.BeginEdit(False)
                    Exit Sub
                ElseIf String.IsNullOrWhiteSpace(row.Cells("Amount").Value) Then
                    MsgBox("You must Enter Amount", MsgBoxStyle.Information, "Stop")
                    Dgv_VisitType.CurrentCell = Dgv_VisitType.Rows(Dgv_VisitType.Rows.Count - 1).Cells("Amount")
                    Dgv_VisitType.BeginEdit(False)
                    Exit Sub
                End If

                Cmd = New SqlCommand("Select Num From VisitsTypes Where Num=@Num", con)
                Cmd.Parameters.AddWithValue("@Num", row.Cells("Num").Value).DbType = DbType.Int32
                Da = New SqlDataAdapter(Cmd)
                DtEditPatient = New DataTable
                Da.Fill(DtEditPatient)
                con.Close()

                If DtEditPatient.Rows.Count = 0 Then
                    Query = "Insert Into VisitsTypes (Num,VisitKind,Amount) Values(@Num,@VisitKind,@Amount)"
                Else
                    Query = "Update VisitsTypes Set VisitKind=@VisitKind,Amount=@Amount Where Num=@Num"
                End If

                Cmd = New SqlCommand(Query, con)

                With Cmd.Parameters
                    .AddWithValue("Num", row.Cells(0).Value).DbType = DbType.Int64

                    If Not String.IsNullOrEmpty(row.Cells(1).Value) Then
                        .AddWithValue("VisitKind", row.Cells(1).Value).DbType = DbType.String
                    Else
                        .AddWithValue("VisitKind", DBNull.Value)
                    End If

                    .AddWithValue("Amount", row.Cells(2).Value).DbType = DbType.Double
                End With

                con.Open()
                Cmd.ExecuteNonQuery()
            Next
            Frm_VisitTypes_Load(Nothing, Nothing)
            Dgv_VisitType.Sort(Dgv_VisitType.Columns("Num"), System.ComponentModel.ListSortDirection.Ascending)
            Btn_AddNewVisit.Enabled = True
            Fill_Combobox(Frm_Reservation.Cbo_ReserveType, "VisitsTypes", "VisitKind", "Num")
            Fill_Combobox(frm_ManageReservation.Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
            Fill_Combobox(Frm_PatientVisit.Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_DeleteVisitType_Click(sender As Object, e As EventArgs) Handles Btn_DeleteVisitType.Click
        Try
            If con.State = 1 Then con.Close()

            If Dgv_VisitType.Rows.Count > 0 Then

                If MsgBox("Do You Want To Delete This Record ?", MsgBoxStyle.Information + vbYesNo, "Attention") = vbYes Then

                    curid = Dgv_VisitType.CurrentRow.Cells(0).Value

                    'التأكد من عدم وجود نوع الزيارة فى جدول الحجز وجدول الزيارات
                    Dim checkVisitType_ClinicDays As Integer = Check("Select VisitType From ClinicDays Where VisitType=" & curid & " ")
                    Dim checkVisitType_Reservation As Integer = Check("Select VisitType From Reservation Where VisitType=" & curid & " ")

                    If checkVisitType_ClinicDays = 0 And checkVisitType_Reservation = 0 Then
                        Cmd = New SqlCommand("Delete From VisitsTypes Where Num=" & curid & "", con)
                        con.Open()
                        Cmd.ExecuteNonQuery()

                        Dgv_VisitType.CurrentCell = Dgv_VisitType.Rows(Dgv_VisitType.Rows.Count - 1).Cells(0)
                        Dgv_VisitType.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        Dgv_VisitType.DefaultCellStyle.SelectionBackColor = Color.OldLace
                    Else
                        MsgBox("You Canot Delete Visit Type " & Environment.NewLine & "Visit Type Used In PatientVisits", MsgBoxStyle.Information, "Info")
                    End If

                    Frm_VisitTypes_Load(Nothing, Nothing)
                    Btn_AddNewVisit.Enabled = True
                    Fill_Combobox(Frm_Reservation.Cbo_ReserveType, "VisitsTypes", "VisitKind", "Num")
                    Fill_Combobox(frm_ManageReservation.Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
                    Fill_Combobox(Frm_PatientVisit.Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Deleted")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_ExitNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_ExitNewPatient.Click
        closeTabPage(Me)
    End Sub

    Private Sub Btn_ExportExcel_Click(sender As Object, e As EventArgs) Handles Btn_ExportExcel.Click
        Try

            ExportExcel(Dt_VisitType, "VisitType")
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

#End Region

#Region "Forms"

    Private Sub Frm_VisitTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillDgvVisits()

        If Dgv_VisitType.Rows.Count > 0 Then
            Dgv_VisitType.Sort(Dgv_VisitType.Columns("Num"), System.ComponentModel.ListSortDirection.Ascending)
            Dgv_VisitType.CurrentCell = Dgv_VisitType.Rows(Dgv_VisitType.Rows.Count - 1).Cells(0)
        End If
    End Sub

    Private Sub Frm_VisitTypes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then
            Btn_DeleteVisitType_Click(Nothing, Nothing)
            Frm_VisitTypes_Load(Nothing, Nothing)
        End If
    End Sub

#End Region

#Region "Datagridview"

    Sub FillDgvVisits()
        Try
            Dgv_VisitType.Columns.Clear()
            Dt_VisitType = SelectWithDataTable("Select * From VisitsTypes", "VisitType")

            With Dgv_VisitType
                .Columns.Add("Num", "VisitNum")
                .Columns.Add("VisitKind", "VisitKind")
                .Columns.Add("Amount", "Amount")
            End With

            Dgv_VisitType.Columns(0).Width = 70
            Dgv_VisitType.Columns(1).Width = 245
            Dgv_VisitType.Columns(2).Width = 70

            Dgv_VisitType.Columns(0).ReadOnly = True

            For i As Integer = 0 To Dt_VisitType.Rows.Count - 1
                Dgv_VisitType.Rows.Add()
                Dgv_VisitType(0, i).Value = Dt_VisitType(i)(0)
                Dgv_VisitType(1, i).Value = Dt_VisitType(i)(1)
                Dgv_VisitType(2, i).Value = Dt_VisitType(i)(2)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub DgvVisits_KeyDown(sender As Object, e As KeyEventArgs) Handles Dgv_VisitType.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{right}")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub DgvVisits_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_VisitType.CellEndEdit
        Try
            SendKeys.Send("{right}")

            Me.Dgv_VisitType.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            Me.Dgv_VisitType.DefaultCellStyle.SelectionBackColor = Color.LightPink
            Me.Dgv_VisitType.DefaultCellStyle.SelectionForeColor = Color.Black

            If e.ColumnIndex = 2 Then
                Btn_SaveNewVisit.PerformClick()
                Me.Dgv_VisitType.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Me.Dgv_VisitType.DefaultCellStyle.SelectionBackColor = Color.OldLace
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

#End Region

#End Region

End Class