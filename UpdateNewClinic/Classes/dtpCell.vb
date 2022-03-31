Public Class dtpCell
    Inherits DataGridViewTextBoxCell

    Public DisplayValue As String = Date.Now.ToString

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, _
    ByVal initialFormattedValue As Object, _
    ByVal dataGridViewCellStyle As DataGridViewCellStyle)

        MyBase.InitializeEditingControl(rowIndex, _
        initialFormattedValue, _
        dataGridViewCellStyle)

        'Cast the EditingControl to a variable we can work with
        Dim ctl As dtpEditingControl = _
        DirectCast(DataGridView.EditingControl, dtpEditingControl)

        'Cast the OwningColumn to a variable we can work with
        Dim col As dtpColumn = DirectCast(Me.OwningColumn, dtpColumn)

        'Important: Tell the DateTimePickerEditingControl that this is now 
        '           the owner cell for the control

        ctl.OwnerCell = Me

    End Sub

    Protected Overrides Function GetValue(ByVal rowIndex As Integer) As Object
        Return DisplayValue
    End Function

    Friend Sub SetDisplayValue(ByVal NewValue As String)
        DisplayValue = NewValue
    End Sub

    Public Overrides ReadOnly Property EditType() As Type
        Get
            ' Return the type of the editing contol that ComboBoxCell uses.
            Return GetType(dtpEditingControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As Type
        Get
            ' Return the type of the value that ComboBoxCell contains.
            Return GetType(Date)
        End Get
    End Property

    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            ' Use Date.Now as the default cell value.
            Return Date.Now
        End Get
    End Property

    Protected Overrides Sub Paint(ByVal graphics As System.Drawing.Graphics, _
                                    ByVal clipBounds As System.Drawing.Rectangle, _
                                    ByVal cellBounds As System.Drawing.Rectangle, ByVal rowIndex As Integer, _
                                    ByVal cellState As DataGridViewElementStates, _
                                    ByVal value As Object, ByVal formattedValue As Object, _
                                    ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, _
                                    ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, _
                                    ByVal paintParts As DataGridViewPaintParts)

        'The first time in, make sure that we get the initial DisplayValue
        If DisplayValue Is Nothing Then SetDisplayValue(CDate(value).ToString)
        'Override paint to pass DisplayValue instead of formattedValue
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, _
                        DisplayValue, errorText, cellStyle, advancedBorderStyle, paintParts)
    End Sub

End Class
