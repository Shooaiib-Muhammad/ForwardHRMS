Public Class frmBusFine

    Private Sub Tbl_Bus_FineBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Bus_FineBindingNavigatorSaveItem.Click
        Dim j As Integer = Me.Tbl_Bus_FineBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Bus_FineBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSBusChages)
            Me.Tbl_Bus_FineTableAdapter.Fill(Me.DSBusChages.tbl_Bus_Fine, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
            Me.Tbl_Bus_FineBindingSource.Position = j
            MsgBox("Record Saved Successfully")
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

    Private Sub frmBusFine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBusAtt.tbl_Bus_Comp_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Bus_Comp_InfoTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Comp_Info)
        'TODO: This line of code loads data into the 'DSBusChages.tbl_Bus_Fine' table. You can move, or remove it, as needed.
        Me.Tbl_Bus_FineTableAdapter.Fill(Me.DSBusChages.tbl_Bus_Fine, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
    End Sub
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Me.Tbl_Bus_FineTableAdapter.Fill(Me.DSBusChages.tbl_Bus_Fine, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
    End Sub

    Private Sub Tbl_Bus_FineDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_FineDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Bus_FineDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_FineDataGridView.CellEnter
        If e.ColumnIndex > 2 Then
            If Me.Tbl_Bus_FineDataGridView(3, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Bus_FineDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
                Me.Tbl_Bus_FineDataGridView(3, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub Tbl_Bus_FineDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bus_FineDataGridView.DataError

    End Sub

    Private Sub Tbl_Bus_FineDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Bus_FineDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class