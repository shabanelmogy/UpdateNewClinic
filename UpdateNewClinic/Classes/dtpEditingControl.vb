Public Class dtpEditingControl
    Inherits DateTimePicker
    Implements IDataGridViewEditingControl

    Private dataGridViewControl As DataGridView
    Private valueIsChanged As Boolean = False
    Private rowIndexNum As Integer
    Private currentCell As dtpCell = Nothing

    Protected Overrides Sub OnValueChanged(ByVal eventargs As System.EventArgs)
        If currentCell IsNot Nothing Then
            currentCell.SetDisplayValue(MyBase.Value.ToString)
        End If
        MyBase.OnValueChanged(eventargs)
    End Sub

    Public Property OwnerCell() As dtpCell
        Get
            Return currentCell
        End Get
        Set(ByVal value As dtpCell)
            'Clear currentCell so DoSelectedValueChanged doesn't cause an endless loop
            currentCell = Nothing
            'Set Value
            MyBase.Value = CDate(value.DisplayValue)
            'Show that the value hasn't changed yet
            valueIsChanged = False
            'Finally remember the new Owner Cell
            currentCell = value
        End Set
    End Property

    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle) Implements System.Windows.Forms.IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.ForeColor = dataGridViewCellStyle.ForeColor
        Me.BackColor = dataGridViewCellStyle.BackColor
    End Sub

    Public Property EditingControlDataGridView() As System.Windows.Forms.DataGridView Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlDataGridView
        Get
            Return dataGridViewControl
        End Get
        Set(ByVal value As System.Windows.Forms.DataGridView)
            dataGridViewControl = value
        End Set
    End Property

    Public Property EditingControlFormattedValue() As Object Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return MyBase.Value
        End Get
        Set(ByVal value As Object)
            MyBase.Value = CDate(value)
        End Set
    End Property

    Public Property EditingControlRowIndex() As Integer Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlRowIndex
        Get
            Return rowIndexNum
        End Get
        Set(ByVal value As Integer)
            rowIndexNum = value
        End Set
    End Property

    Public Property EditingControlValueChanged() As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return valueIsChanged
        End Get
        Set(ByVal value As Boolean)
            valueIsChanged = value
        End Set
    End Property

    Public Function EditingControlWantsInputKey(ByVal keyData As System.Windows.Forms.Keys, ByVal dataGridViewWantsInputKey As Boolean) As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlWantsInputKey
        Return True
    End Function

    Public ReadOnly Property EditingPanelCursor() As System.Windows.Forms.Cursor Implements System.Windows.Forms.IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    Public Function GetEditingControlFormattedValue(ByVal context As System.Windows.Forms.DataGridViewDataErrorContexts) As Object Implements System.Windows.Forms.IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return MyBase.Value
    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) Implements System.Windows.Forms.IDataGridViewEditingControl.PrepareEditingControlForEdit

    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property
End Class
