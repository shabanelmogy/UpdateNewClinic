Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraTab

Public Class Frm_Booking

#Region "Declaration"
    Dim cmd, cmd1 As New SqlCommand
    Dim dv As New DataView
    Dim cur As CurrencyManager
    Dim Dt_Search, Dt_Visits, dt As New DataTable
    Dim da As New SqlDataAdapter
    Dim rdr As SqlDataReader
    Dim Query As String
    Dim check As Boolean = False
    Dim curid As Integer
    Dim curstatus As String = ""
    Dim curdate As Date
    Dim maxrow As Integer

#End Region

#Region "Sub Procedures"

    Sub FillDataGridviewWithDataSource(Query As String)
        Try
            Dim cmd As New SqlCommand(Query, con)

            Dt_Search = New DataTable
            da = New SqlDataAdapter(cmd)
            da.Fill(Dt_Search)

            Dgv_Search.DataSource = Nothing
            Dgv_Search.DataSource = Dt_Search
            FormatDgv_Search()

            da.Dispose()
            Dt_Search.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Sub FilldatagridviewComboBox_DataReader()
        Try
            cmd = New SqlCommand("Select StatusID,StatusName From Status", con)
            con.Open()
            rdr = cmd.ExecuteReader
            Status1.Items.Clear()

            While rdr.Read
                Status1.Items.Add(rdr("StatusName").ToString)
            End While
            con.Close()
            rdr.Close()
            cmd.Dispose()
        Catch ex As Exception
            'تم تجاهل رسالة الخطأ لظهور خطأ أن الإتصال مفتوح
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "1")
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Private Sub Auto_Save(sql As String)
        Try
            con.Open()
            cmd = New SqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Function numrows(sql)
        Try
            con.Open()
            cmd = New SqlCommand
            da = New SqlDataAdapter
            dt = New DataTable

            With cmd
                .Connection = con
                .CommandText = sql
            End With

            da.SelectCommand = cmd
            da.Fill(dt)

            maxrow = dt.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

        Return maxrow
    End Function

    Sub GetAllReservation(Query As String)
        Try
            Dgv_Visits.Rows.Clear()
            If con.State = 1 Then con.Close()
            con.Open()
            Dim cmd As New SqlCommand(Query, con)
            rdr = cmd.ExecuteReader

            While rdr.Read
                Dgv_Visits.Rows.Add(rdr("PatientID"), rdr("PatientName"), Format(rdr("ReserveDate"), "dd/MM/yyyy"), rdr("VisitName"),
                                     rdr("VisitCost"), rdr("status"))
            End While
            rdr.Close()
            con.Close()
            cmd.Dispose()
            FormatDgv_Visits()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

    Public Sub Insert_Reservation()

        If con.State = 1 Then con.Close()

        cmd = New SqlCommand("Select PatientID From Reservation Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
        cmd.Parameters.AddWithValue("@PatientID", Val(Txt_Num.Text)).DbType = DbType.Int32
        cmd.Parameters.AddWithValue("@ReserveDate", Dtp_ReserveDate.Value).DbType = DbType.Date
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        da.Dispose()
        If dt.Rows.Count = 0 Then

            cmd = New SqlCommand("Insert Into Reservation(PatientID,PatientName,ReserveDate,VisitType,VisitName,VisitCost,Status)
                                 Values(@PatientID,@PatientName,@ReserveDate,@VisitType,@VisitName,@VisitCost,'Waiting')", con)
            With cmd
                .Parameters.AddWithValue("@PatientID", Val(Txt_Num.Text)).DbType = DbType.Int32
                .Parameters.AddWithValue("@PatientName", Txt_PatientName.Text).DbType = DbType.String
                .Parameters.AddWithValue("@ReserveDate", Dtp_ReserveDate.Value).DbType = DbType.Date
                .Parameters.AddWithValue("@VisitType", Cbo_ReserveType.SelectedValue).DbType = DbType.Int32
                .Parameters.AddWithValue("@VisitName", Cbo_ReserveType.Text).DbType = DbType.String
                .Parameters.AddWithValue("@VisitCost", Val(Txt_VisitCost.Text)).DbType = DbType.Decimal

            End With

            If con.State = 1 Then con.Close()

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Else
            MsgBox("The Patient Is Already Checked", MsgBoxStyle.Information, "Info")
        End If
    End Sub

    Public Sub Update_Reservation()

        If con.State = 1 Then con.Close()

        cmd = New SqlCommand("Update Reservation Set ReserveDate=@ReserveDate,VisitType=@VisitType,VisitName=@VisitName,VisitCost=@VisitCost
                              Where PatientID=@PatientID And ReserveDate=@ReserveDate", con)
        With cmd
            .Parameters.AddWithValue("@PatientID", Val(Txt_Num.Text)).DbType = DbType.Int32
            .Parameters.AddWithValue("@PatientName", Txt_PatientName.Text).DbType = DbType.String
            .Parameters.AddWithValue("@ReserveDate", Dtp_ReserveDate.Value).DbType = DbType.Date
            .Parameters.AddWithValue("@VisitType", Cbo_ReserveType.SelectedValue).DbType = DbType.Int32
            .Parameters.AddWithValue("@VisitName", Cbo_ReserveType.Text).DbType = DbType.String
            .Parameters.AddWithValue("@VisitCost", Txt_VisitCost.Text).DbType = DbType.Double
        End With

        If con.State = 1 Then con.Close()

        con.Open()
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        con.Close()
    End Sub

#End Region

#Region "Datagridview"

#Region "Dgv_Search"

    Sub FormatDgv_Search()

        Dgv_Search.Columns("PatientNum").Width = 100
        Dgv_Search.Columns("PatientName").Width = 200
        Dgv_Search.Columns("PhoneNumber").Width = 132
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

    Private Sub Dgv_Search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Search.CellClick
        Txt_PatientName.Text = Dgv_Search.CurrentRow.Cells("PatientName").Value.ToString
        Txt_Num.Text = Dgv_Search.CurrentRow.Cells("PatientNum").Value.ToString
        check = False
    End Sub

#End Region

#Region "Dgv_Visits"

    Sub FormatDgv_Visits()

        Dgv_Visits.Columns("PatientNum").Width = 100
        Dgv_Visits.Columns("PatientName").Width = 250
        Dgv_Visits.Columns("ReserveDate").Width = 120
        Dgv_Visits.Columns("VisitType").Width = 150
        Dgv_Visits.Columns("VisitCost").Width = 100

    End Sub

    Private Sub Dgv_Visits_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Visits.CellContentClick

        'PatientNum,PatientName,PhoneNumber,Code,Age,Occupation,FirstDate,Height,StartWeight

        If e.ColumnIndex = 6 And e.RowIndex >= 0 Then

            Dim PatientNum As String = Dgv_Visits.Rows(e.RowIndex).Cells(0).Value
            Dim PatientName As String = Dgv_Visits.Rows(e.RowIndex).Cells(1).Value
            Dim Resrvedate As String = Dgv_Visits.Rows(e.RowIndex).Cells(2).Value
            Dim VisitType As String = Dgv_Visits.Rows(e.RowIndex).Cells(3).Value
            Dim VisitCost As String = Dgv_Visits.Rows(e.RowIndex).Cells(4).Value

            Dim dt As DataTable = GetDatatable("Select PatientName,PhoneNumber,Code,Age,Occupation,FirstDate,Height,StartWeight From PatientsDetail
                                                Where PatientNum=" & PatientNum & " ")

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
                    frm.Txt_PatientNum.Text = PatientNum
                    frm.Txt_PatientName.Text = dt(0)("PatientName").ToString
                    frm.Txt_Phone.Text = dt(0)("PhoneNumber").ToString
                    frm.Txt_Code.Text = dt(0)("Code").ToString
                    frm.Txt_Age.Text = dt(0)("Age").ToString
                    frm.Txt_Occupation.Text = dt(0)("Occupation").ToString
                    frm.Txt_FirstVisit.Text = CDate(dt(0)("FirstDate")).ToString("dd/MM/yyyy")
                    frm.Txt_Height.Text = dt(0)("Height").ToString
                    frm.Txt_StartWeight.Text = dt(0)("StartWeight").ToString
                    frm.Dtp_VisitDate.Value = Resrvedate

#End Region

                    frm.Dgv_VisitDetail.ClearSelection()
                    Fill_Combobox(frm.Cbo_VisitType, "VisitsTypes", "VisitKind", "Num")
                    frm.Cbo_VisitType.SelectedIndex = -1
                    frm.Cbo_VisitType.Text = VisitType
                    frm.Txt_VisitCost.Text = VisitCost

                    '=======================================================================================================================
                    frm.FillGrdVisitDetails("Select VisitDate,VisitKind,VisitCost,NewWeight,NewBmi,PlanOfTreatment,EatingHabits,Notes from ClinicDays
                                             Inner Join VisitsTypes on ClinicDays.VisitType = VisitsTypes.Num Where PatientID = " & PatientNum)
                End If
            Next
            frm.Show()
        End If

    End Sub

    Private Sub Dgv_Visits_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Visits.CellEndEdit
        'حفظ التغييرات عند تغيير الحالة 
        Dim sql As String
        maxrow = Dgv_Visits.RowCount
        Dgv_Visits.Rows(Dgv_Visits.RowCount - 1).Cells(0).Value = maxrow

        For i As Integer = 0 To Dgv_Visits.Rows.Count - 2
            With Dgv_Visits.Rows(i)
                sql = "SELECT * FROM Reservation WHERE PatientID=" & .Cells(0).Value
                maxrow = numrows(sql)

                If maxrow >= 0 Then
                    sql = "UPDATE Reservation SET Status='" & .Cells(5).Value & "' WHERE PatientID=" & .Cells(0).FormattedValue
                    Auto_Save(sql)
                    LoadFrm_ManageReservation()
                End If
            End With
        Next

    End Sub

    Private Sub Dgv_Visits_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles Dgv_Visits.CellFormatting
        For Each row As DataGridViewRow In Dgv_Visits.Rows
            If Not row.IsNewRow Then
                Select Case row.Cells(5).Value.ToString
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

    Private Sub Dgv_Visits_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Visits.CellClick
        Txt_Num.Text = Dgv_Visits.CurrentRow.Cells(0).Value
        Txt_PatientName.Text = Dgv_Visits.CurrentRow.Cells(1).Value
        Dtp_ReserveDate.Text = Dgv_Visits.CurrentRow.Cells(2).Value
        Cbo_ReserveType.Text = Dgv_Visits.CurrentRow.Cells(3).Value
        Txt_VisitCost.Text = Dgv_Visits.CurrentRow.Cells(4).Value
        check = True
    End Sub

    Private Sub Dgv_Visits_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles Dgv_Visits.CellPainting
        'If e.ColumnIndex = 6 AndAlso e.RowIndex >= 0 Then
        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    Dim img As Image = My.Resources.Open2_16x16
        '    e.Graphics.DrawImage(img, e.CellBounds.Left + 45, e.CellBounds.Top + 7, 10, 10)
        '    e.Handled = True
        'End If
    End Sub

#End Region

#End Region

#Region "Events"

#Region "Buttons"

    Private Sub Btn_NewPatient_Click(sender As Object, e As EventArgs) Handles Btn_NewPatient.Click
        Dim frm As New Frm_NewClient
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.Txt_PatientNum.Text = GetMaxId("PatientNum", "PatientsDetail") + 1
        frm.Dtp_PatientFirstDate.Value = Date.Now.ToString("dd-MM-yyyy")
        frm.Show()
    End Sub

    Private Sub Btn_EditPatient_Click(sender As Object, e As EventArgs) Handles Btn_EditPatient.Click

        Checkfrm = 2

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

    Private Sub Btn_SaveNewPatient_Click(sender As Object, e As EventArgs) Handles Btn_SaveNewPatient.Click

        If Txt_Num.Text = "" Then
            MsgBox("You Must Select Patient", MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        If Cbo_ReserveType.Text = "" Then
            MsgBox("You Must Select Visit Type", MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        If check = False Then

            Insert_Reservation()
        Else
            Update_Reservation()
        End If

        'load_FrmManageReservation()

        Txt_Num.Text = ""
        Txt_PatientName.Text = ""
        Cbo_ReserveType.Text = ""
        Txt_VisitCost.Text = ""
        Txt_SearchValue.Select()

        LoadFrm_ManageReservation()
        GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost,status From Reservation Where Checkok=0 
                           And ReserveDate='" & Format(Today, "yyyy-MM-dd") & "' 
                           Order By Case 
                           When status='Entry' then 1 
                           When status='Waiting' then 2
                           When status='Booking' then 3
                           When status='Out' then 4
                           End")
    End Sub

    Private Sub Btn_SortDesc_Click(sender As Object, e As EventArgs)
        Dgv_Search.Sort(Dgv_Search.Columns(Cbo_SortAndSearch.Text), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Btn_SortAsec_Click(sender As Object, e As EventArgs)
        Dgv_Search.Sort(Dgv_Search.Columns(Cbo_SortAndSearch.Text), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub Btn_Reset_Click(sender As Object, e As EventArgs) Handles Btn_Reset.Click
        Txt_Num.Text = ""
        Txt_PatientName.Text = ""
        Cbo_ReserveType.SelectedIndex = -1
        check = False
    End Sub

    Private Sub Btn_ShowToday_Click(sender As Object, e As EventArgs) Handles Btn_ShowToday.Click
        GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost,Status From Reservation Where Checkok=0 
                           And ReserveDate='" & Format(Today, "yyyy-MM-dd") & "' 
                           Order By Case 
                           When status='Entry' then 1 
                           When status='Waiting' then 2
                           When status='Booking' then 3
                           When status='Out' then 4
                           End")
    End Sub

    Private Sub Btn_ShowAll_Click(sender As Object, e As EventArgs) Handles Btn_ShowAll.Click
        GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost,Status From Reservation Where Checkok=0
                           Order By Case 
                           When status='Entry' then 1 
                           When status='Waiting' then 2
                           When status='Booking' then 3
                           When status='Out' then 4
                           End")
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost,Status From Reservation Where Checkok=0 
                           And ReserveDate='" & Format(Dtp_Search.Value, "yyyy-MM-dd") & "' 
                           Order By Case 
                           When status='Entry' then 1 
                           When status='Waiting' then 2
                           When status='Booking' then 3
                           When status='Out' then 4
                           End")
    End Sub

#End Region

#Region "TextBox"

    Private Sub Txt_SearchValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SearchValue.KeyPress
        If Cbo_SortAndSearch.Text = "PatientName" And (Char.IsControl(e.KeyChar) = False And Char.IsLetter(e.KeyChar) = False And Not e.KeyChar = " ") Then
            e.Handled = True
        ElseIf Cbo_SortAndSearch.Text = "Phone" And Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Sub Txt_SearchValue_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_SearchValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            dv = Dt_Search.DefaultView
            If Cbo_SortAndSearch.Text = "PatientName" Then
                dv.RowFilter = "PatientName like '" & Txt_SearchValue.Text & "%'"
            ElseIf Cbo_SortAndSearch.Text = "Phone" Then
                dv.RowFilter = "PhoneNumber = '" & Txt_SearchValue.Text & "'"
            End If
        End If
        If e.KeyCode = Keys.Delete Then
            FillDataGridviewWithDataSource("Select PatientNum,PatientName,PhoneNumber,Code,Age,Occupation,FirstDate,Height,StartWeight
                                            From PatientsDetail")
            Txt_SearchValue.Text = ""
        End If
    End Sub

#End Region

#Region "ComboBox"



    Private Sub Cbo_SortAndSearch_TextChanged(sender As Object, e As EventArgs) Handles Cbo_SortAndSearch.TextChanged
        Txt_SearchValue.Text = ""
    End Sub

    Private Sub Cbo_ReserveType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles Cbo_ReserveType.SelectionChangeCommitted
        TextBoxDepndOnCombobox(Txt_VisitCost, Cbo_ReserveType, "Select Amount From VisitsTypes", "Num")
    End Sub

#End Region

#Region "Forms"
    Private Sub Frm_Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FilldatagridviewComboBox_DataReader()
            Fill_Combobox(Cbo_ReserveType, "VisitsTypes", "VisitKind", "Num")
            Cbo_SortAndSearch.SelectedIndex = 0

            FillDataGridviewWithDataSource("Select PatientNum,PatientName,PhoneNumber,Code,Age,Occupation,FirstDate,Height,StartWeight
                                            From PatientsDetail")

            GetAllReservation("Select PatientID,PatientName,ReserveDate,VisitName,VisitCost,status From Reservation Where Checkok=0 
                               And ReserveDate='" & Format(Today, "yyyy-MM-dd") & "' 
                               Order By Case 
                               When status='Entry' then 1 
                               When status='Waiting' then 2
                               When status='Booking' then 3
                               When status='Out' then 4
                               End")

            TextBoxDepndOnCombobox(Txt_VisitCost, Cbo_ReserveType, "Select Amount From VisitsTypes", "Num")
            Dtp_ReserveDate.Value = Date.Now.ToString("dd-MM-yyyy")
            Dtp_Search.Value = Date.Now.ToString("dd-MM-yyyy")
            Dgv_Search.CurrentCell = Dgv_Search.Rows(Dgv_Search.Rows.Count - 1).Cells(0)
            check = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
            If con.State = 1 Then con.Close()
        End Try
    End Sub

#Region "LoadOtherForms"
    Sub LoadFrm_ManageReservation()
        frm_ManageReservation.GetAllPatient("Select PatientID,Reservation.PatientName,PhoneNumber,Code,ReserveDate,VisitName,VisitCost,FirstDate,Age,
                                             Occupation,Height,StartWeight,VisitType,Status From Reservation 
                                             Inner Join PatientsDetail On Reservation.PatientID=PatientsDetail.PatientNum
                                             Where CheckOk = 0 And ReserveDate='" & Format(Dtp_ReserveDate.Value, "yyyy-MM-dd") & "'
                                             Order By Case 
                                             When status='Entry' then 1 
                                             When status='Waiting' then 2
                                             When status='Booking' then 3
                                             When status='Out' then 4
                                             End")
        frm_ManageReservation.CountVisits()
    End Sub


#End Region

#End Region

#End Region

End Class