Public Class frmBusLeaveEntry

    Private Sub Tbl_Bus_Leave_EntryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Bus_Leave_EntryBindingNavigatorSaveItem.Click
        Dim j As Integer = Me.Tbl_Bus_Leave_EntryBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Bus_Leave_EntryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSBusChages)
            Me.Tbl_Bus_Leave_EntryTableAdapter.Fill(Me.DSBusChages.tbl_Bus_Leave_Entry, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
            Me.Tbl_Bus_Leave_EntryBindingSource.Position = j
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function
    Private Sub frmBusLeaveEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBusChages.tbl_Bus_Leave_Entry' table. You can move, or remove it, as needed.
        Me.Tbl_Bus_Leave_EntryTableAdapter.Fill(Me.DSBusChages.tbl_Bus_Leave_Entry, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
        Me.Tbl_Bus_Comp_InfoTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Comp_Info)
    End Sub

    Private Sub Tbl_Bus_Leave_EntryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_Leave_EntryDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Bus_Leave_EntryDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_Leave_EntryDataGridView.CellEnter
        If e.ColumnIndex > 2 Then
            If Me.Tbl_Bus_Leave_EntryDataGridView(4, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Bus_Leave_EntryDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
                Me.Tbl_Bus_Leave_EntryDataGridView(4, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub Tbl_Bus_Leave_EntryDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bus_Leave_EntryDataGridView.DataError

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Me.Tbl_Bus_Leave_EntryTableAdapter.Fill(Me.DSBusChages.tbl_Bus_Leave_Entry, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
    End Sub

    Private Sub Tbl_Bus_Leave_EntryDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Bus_Leave_EntryDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class