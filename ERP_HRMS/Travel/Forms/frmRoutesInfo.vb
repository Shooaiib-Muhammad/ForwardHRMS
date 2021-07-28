Public Class frmRoutesInfo

    Private Sub Tbl_Bus_Route_InfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Bus_Route_InfoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Bus_Route_InfoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSBusInfo)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmRoutesInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBusInfo.tbl_Bus_Route_Fare' table. You can move, or remove it, as needed.
        Me.Tbl_Bus_Route_FareTableAdapter.Fill(Me.DSBusInfo.tbl_Bus_Route_Fare)
        'TODO: This line of code loads data into the 'DSBusInfo.tbl_Bus_Route_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Bus_Route_InfoTableAdapter.Fill(Me.DSBusInfo.tbl_Bus_Route_Info)
    End Sub

    Private Sub Tbl_Bus_Route_FareDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_Route_FareDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Bus_Route_FareDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_Route_FareDataGridView.CellEnter
        If e.ColumnIndex >= 2 Then
            If Me.Tbl_Bus_Route_FareDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Bus_Route_FareDataGridView(3, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub Tbl_Bus_Route_FareDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bus_Route_FareDataGridView.DataError

    End Sub

    Private Sub Tbl_Bus_Route_FareDataGridView_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Tbl_Bus_Route_FareDataGridView.DragEnter

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Bus_Route_FareBindingSource.EndEdit()
            Me.Tbl_Bus_Route_FareTableAdapter.Update(Me.DSBusInfo.tbl_Bus_Route_Fare)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class