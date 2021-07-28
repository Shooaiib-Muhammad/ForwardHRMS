Public Class Emp_Leaving_Reason
    Private Sub Emp_Leaving_Reason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Leave_Reason' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Leave_ReasonTableAdapter.Fill(Me.DSHRM.tbl_HRM_Leave_Reason)
        Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_Leave_ReasonDataGridView.ReadOnly = False
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_Leave_ReasonDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_Leave_ReasonBindingSource.Position
        Tbl_HRM_Leave_ReasonTableAdapter.Fill(DSHRM.tbl_HRM_Leave_Reason)
        Tbl_HRM_Leave_ReasonBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_Leave_ReasonDataGridView.ReadOnly = True
        Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
    End Sub

    Private Sub Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_Leave_ReasonBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_Leave_ReasonBindingSource.EndEdit()
            Me.Tbl_HRM_Leave_ReasonTableAdapter.Update(Me.DSHRM.tbl_HRM_Leave_Reason)
            Me.Tbl_HRM_Leave_ReasonTableAdapter.Fill(Me.DSHRM.tbl_HRM_Leave_Reason)
            Me.Tbl_HRM_Leave_ReasonBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_Leave_ReasonDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_HRM_Leave_ReasonTableAdapter.Fill(Me.DSHRM.tbl_HRM_Leave_Reason)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_Leave_ReasonDataGridView.ReadOnly = True
        End Try
    End Sub

    Private Sub Tbl_HRM_Leave_ReasonDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_Leave_ReasonDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_Leave_ReasonDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_Leave_ReasonDataGridView.CellEnter
        Me.Tbl_HRM_Leave_ReasonDataGridView(0, e.RowIndex).ReadOnly = True
        Try
            Me.Tbl_HRM_Leave_ReasonDataGridView(0, e.RowIndex).Value = Me.Tbl_HRM_Leave_ReasonDataGridView(0, e.RowIndex - 1).Value + 1
        Catch ex As Exception
            Me.Tbl_HRM_Leave_ReasonDataGridView(0, e.RowIndex).Value = 1
        End Try

    End Sub

    Private Sub Tbl_HRM_Leave_ReasonDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_Leave_ReasonDataGridView.DataError

    End Sub
End Class