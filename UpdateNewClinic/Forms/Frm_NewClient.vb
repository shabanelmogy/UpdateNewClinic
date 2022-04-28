Imports System.Data.SqlClient
Imports System.Drawing

Public Class Frm_NewClient

    Dim cmd As New SqlCommand
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Dim dt As New DataTable
    Dim da As New SqlDataAdapter


    Private Sub Btn_ExitNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_ExitNewPatient.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Frm_NewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Txt_PatientName.Select()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        End Try
    End Sub

    Private Sub Btn_AddNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_AddNewPatient.Click
        Try
            If con.State = 1 Then con.Close()
            Btn_SaveNewPatient.Enabled = True
            Btn_AddNewPatient.Enabled = False
            ResetControls(Me)
            Txt_PatientNum.Text = GetMaxId("PatientNum", "PatientsDetail") + 1
            Txt_PatientName.Select()
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Sub InsertNewPatient()

        If con.State = 1 Then con.Close()
        If Txt_PatientName.Text = vbNullString Then
            MsgBox("لم يتم إدخال إسم المريض", MsgBoxStyle.Information, "تنبيه")
            Exit Sub
        End If
        Try
            Dim cmd As New SqlCommand
            With cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into PatientsDetail(PatientNum,PatientName,Code,Age,Occupation,PhoneNumber,FirstDate,Height,StartWeight)
                                          Values(@PatientNum,@PatientName,@Code,@Age,@Occupation,@PhoneNumber,@FirstDate,@Height,@StartWeight)"

                .Parameters.AddWithValue("@PatientNum", Txt_PatientNum.Text).DbType = DbType.Int32
                .Parameters.AddWithValue("@PatientName", Txt_PatientName.Text).DbType = DbType.String
                .Parameters.AddWithValue("@Code", Txt_Code.Text).DbType = DbType.String
                .Parameters.AddWithValue("@Age", Txt_Age.Text).DbType = DbType.String
                .Parameters.AddWithValue("@Occupation", Txt_Occupation.Text).DbType = DbType.String
                If Not String.IsNullOrWhiteSpace(Txt_PhoneNumber.Text) Then
                    .Parameters.AddWithValue("@PhoneNumber", Txt_PhoneNumber.Text).DbType = DbType.String
                Else
                    .Parameters.AddWithValue("@PhoneNumber", DBNull.Value)
                End If
                .Parameters.AddWithValue("@FirstDate", Dtp_PatientFirstDate.Value).DbType = DbType.Date
                .Parameters.AddWithValue("@Height", Txt_Height.Text).DbType = DbType.String
                .Parameters.AddWithValue("@StartWeight", Txt_StartWeight.Text).DbType = DbType.String
            End With

            If con.State = 1 Then con.Close()
            con.Open()
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            ResetControls(Me)

            Btn_SaveNewPatient.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Btn_SaveNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_SaveNewPatient.Click

        InsertNewPatient()

        Frm_Booking.FillDataGridviewWithDataSource("Select Top 20 PatientNum,PatientName,PhoneNumber,Code,Age,Occupation,FirstDate,Height,StartWeight 
                                                    From PatientsDetail Order By PatientNum Desc")
        frm_ManageReservation.FillDataGridviewWithDataSource("Select Top 20 PatientNum,PatientName,PhoneNumber,Code,Age,Occupation,FirstDate,Height,StartWeight 
                                                    From PatientsDetail Order By PatientNum Desc")
    End Sub

    Private Sub Txt_PhoneNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_PhoneNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_Age.Select()
        End If
    End Sub

    Private Sub Txt_PatientName_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_PatientName.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                'التأكد من أن إسم المريض غير مكرر
                cmd = New SqlCommand("Select PatientName From PatientsDetail Where PatientName=@PatientName", con)
                cmd.Parameters.AddWithValue("@PatientName", Txt_PatientName.Text).Value.ToString()
                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                If dt.Rows.Count > 0 Then
                    MsgBox("إسم المريض مكرر")
                Else
                    Txt_Occupation.Select()
                End If
                cmd.Dispose()
                dt.Dispose()
                da.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, MessageBoxIcon.Error, "Error")
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Txt_Code_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Code.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_PhoneNumber.Select()
        End If
    End Sub

    Private Sub Txt_Occupation_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Occupation.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_Code.Select()
        End If
    End Sub

    Private Sub Txt_Age_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Age.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dtp_PatientFirstDate.Select()
        End If
    End Sub

    Private Sub Dtp_PatientFirstDate_KeyDown(sender As Object, e As KeyEventArgs) Handles Dtp_PatientFirstDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_Height.Select()
        End If
    End Sub

    Private Sub Txt_Height_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Height.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_StartWeight.Select()
        End If
    End Sub

    Private Sub Frm_NewClient_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.F2
                Btn_AddNewPatient.PerformClick()
            Case Keys.F3
                Btn_SaveNewPatient.PerformClick()
        End Select
    End Sub

    Private Sub Txt_Occupation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Occupation.KeyPress
        If (Char.IsControl(e.KeyChar) = False And Char.IsLetter(e.KeyChar) = False And Not e.KeyChar = " ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_PhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_PhoneNumber.KeyPress
        If (Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_PatientName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_PatientName.KeyPress
        If (Char.IsControl(e.KeyChar) = False And Char.IsLetter(e.KeyChar) = False And Not e.KeyChar = " ") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_StartWeight_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_StartWeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            Btn_SaveNewPatient.PerformClick()
            Txt_PatientNum.Text = GetMaxId("PatientNum", "PatientsDetail") + 1
            Txt_PatientName.Select()
            Btn_SaveNewPatient.Enabled = True
            Btn_AddNewPatient.Enabled = True
        End If
    End Sub
End Class