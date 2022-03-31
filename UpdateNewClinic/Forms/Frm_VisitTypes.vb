Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Frm_VisitTypes

    Sub FillDgvVisits()

        DgvVisits.Columns.Clear()
        Fill_DataTableVisits("Select * From VisitsTypes", Me)

        With DgvVisits
            .Columns.Add("Num", "Num")
            .Columns.Add("VisitKind", "VisitKind")
            .Columns.Add("Amount", "Amount")
        End With

        DgvVisits.Columns(0).Width = 70
        DgvVisits.Columns(1).Width = 245
        DgvVisits.Columns(2).Width = 70

        DgvVisits.Columns(0).ReadOnly = True

        For i As Integer = 0 To cur.Count - 1
            DgvVisits.Rows.Add(New String() {cur.Current("Num"), cur.Current("VisitKind"), cur.Current("Amount")})
            cur.Position += 1
        Next

    End Sub

    Private Sub Btn_AddNewVisit_Click(sender As Object, e As EventArgs) Handles Btn_AddNewVisit.Click
        Try
            DgvVisits.Rows.Add(GetMaxId("Num", "VisitsTypes") + 1)
            DgvVisits.CurrentCell = DgvVisits.Rows(DgvVisits.Rows.Count - 1).Cells(1)

            'Cursor inside cell datagridview 
            DgvVisits.BeginEdit(False)
            Btn_AddNewVisit.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Frm_VisitTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDgvVisits()
        DgvVisits.CurrentCell = DgvVisits.Rows(DgvVisits.Rows.Count - 1).Cells(0)
    End Sub

    Private Sub Frm_VisitTypes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then
            Btn_DeletePatient_Click(Nothing, Nothing)
            Frm_VisitTypes_Load(Nothing, Nothing)
        End If
    End Sub

    Private Sub Btn_ExitNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_ExitNewPatient.Click
        Me.Close()
    End Sub

    Private Sub Btn_ExportExcel_Click(sender As Object, e As EventArgs) Handles Btn_ExportExcel.Click
        ExportExcel(dtVisitsType, "Details")
    End Sub

    Private Sub DgvVisits_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvVisits.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{right}")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Attention")
        End Try
    End Sub

    Private Sub DgvVisits_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVisits.CellEndEdit
        Try
            SendKeys.Send("{right}")
            Me.DgvVisits.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            Me.DgvVisits.DefaultCellStyle.SelectionBackColor = Color.LightPink
            Me.DgvVisits.DefaultCellStyle.SelectionForeColor = Color.Black

            If e.ColumnIndex = 2 Then
                Btn_SaveNewVisit.PerformClick()
                Me.DgvVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                Me.DgvVisits.DefaultCellStyle.SelectionBackColor = Color.OldLace
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Exclamation, "Attention")
        End Try
    End Sub

    Private Sub Btn_SaveNewVisit_Click(sender As Object, e As EventArgs) Handles Btn_SaveNewVisit.Click
        Try
            If con.State = 1 Then con.Close()

            For Each row As DataGridViewRow In DgvVisits.Rows

                If String.IsNullOrWhiteSpace(row.Cells("VisitKind").Value) Then
                    MsgBox("You must Enter VisitKind", MsgBoxStyle.Information, "Stop")
                    DgvVisits.CurrentCell = DgvVisits.Rows(DgvVisits.Rows.Count - 1).Cells("VisitKind")
                    DgvVisits.BeginEdit(False)
                    Exit Sub
                ElseIf String.IsNullOrWhiteSpace(row.Cells("Amount").Value) Then
                    MsgBox("You must Enter Amount", MsgBoxStyle.Information, "Stop")
                    DgvVisits.CurrentCell = DgvVisits.Rows(DgvVisits.Rows.Count - 1).Cells("Amount")
                    DgvVisits.BeginEdit(False)
                    Exit Sub
                End If

                cmd = New SqlCommand("Select Num From VisitsTypes Where Num=@Num", con)
                cmd.Parameters.AddWithValue("@Num", row.Cells("Num").Value).DbType = DbType.Int32
                da = New SqlDataAdapter(cmd)
                dtEditPatient = New DataTable
                da.Fill(dtEditPatient)
                con.Close()

                If dtEditPatient.Rows.Count = 0 Then
                    query = "Insert Into VisitsTypes (Num,VisitKind,Amount) Values(@Num,@VisitKind,@Amount)"
                Else
                    query = "Update VisitsTypes Set VisitKind=@VisitKind,Amount=@Amount Where Num=@Num"
                End If

                cmd = New SqlCommand(query, con)

                With cmd.Parameters
                    .AddWithValue("Num", row.Cells(0).Value).DbType = DbType.Int64

                    If Not String.IsNullOrEmpty(row.Cells(1).Value) Then
                        .AddWithValue("VisitKind", row.Cells(1).Value).DbType = DbType.String
                    Else
                        .AddWithValue("VisitKind", DBNull.Value)
                    End If

                    .AddWithValue("Amount", row.Cells(2).Value).DbType = DbType.Double
                End With

                con.Open()
                cmd.ExecuteNonQuery()
            Next
            Frm_VisitTypes_Load(Nothing, Nothing)
            Btn_AddNewVisit.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_DeletePatient_Click(sender As Object, e As EventArgs) Handles Btn_DeletePatient.Click
        Try
            If con.State = 1 Then con.Close()
            If MsgBox("Do You Want To Delete This Record ?", MsgBoxStyle.Information + vbYesNo, "Attention") = vbYes Then

                cmd = New SqlCommand("Delete From VisitsTypes Where Num=@Num", con)
                cmd.Parameters.AddWithValue("Num", DgvVisits.CurrentRow.Cells(0).Value)

                con.Open()
                cmd.ExecuteNonQuery()

                If DgvVisits.Rows.Count > 0 Then
                    DgvVisits.CurrentCell = DgvVisits.Rows(DgvVisits.Rows.Count - 1).Cells(0)
                    DgvVisits.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    DgvVisits.DefaultCellStyle.SelectionBackColor = Color.OldLace
                End If

                Frm_VisitTypes_Load(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Deleted")
        Finally
            If con.State = 1 Then con.Close()
        End Try

    End Sub
End Class