Public Class Emp_Branch_Info
    Private Sub Tbl_HRM_BranchBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_BranchBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)
    End Sub

    Private Sub Emp_Branch_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        Tbl_HRM_BranchBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_BranchBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_BranchBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_BranchBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_BranchBindingSource.EndEdit()
            Me.Tbl_HRM_BranchTableAdapter.Update(Me.DSHRM.tbl_HRM_Branch)
            Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
            Me.Tbl_HRM_BranchBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Branchflag = True
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_BranchBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_BranchDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_BranchBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_BranchDataGridView.ReadOnly = True
        End Try
    End Sub

    Private Sub Tbl_HRM_BranchDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_BranchDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_BranchDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_BranchDataGridView.DataError

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_BranchBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_BranchDataGridView.ReadOnly = False
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_BranchBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_BranchDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_BranchBindingSource.Position
        Tbl_HRM_BranchTableAdapter.FillBy(DSHRM.tbl_HRM_Branch)
        Tbl_HRM_BranchBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_BranchBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        Tbl_HRM_BranchDataGridView.ReadOnly = True

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        Tbl_HRM_BranchBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub Tbl_HRM_BranchDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_BranchDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            Me.Tbl_HRM_BranchDataGridView(0, e.RowIndex).ReadOnly = True
            Try
                Me.Tbl_HRM_BranchDataGridView(0, e.RowIndex).Value = Me.Tbl_HRM_BranchDataGridView(0, e.RowIndex - 1).Value + 1
            Catch ex As Exception
                Me.Tbl_HRM_BranchDataGridView(0, e.RowIndex).Value = 1
            End Try
        End If
    End Sub

    Private Sub Tbl_HRM_BranchDataGridView_CellToolTipTextChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_BranchDataGridView.CellToolTipTextChanged

    End Sub
End Class