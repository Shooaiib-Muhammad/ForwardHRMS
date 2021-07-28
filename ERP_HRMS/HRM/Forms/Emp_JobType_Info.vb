Public Class Emp_JobType_Info


    Private Sub Emp_JobType_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_JobType' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_JobTypeTableAdapter.FillBy(Me.DSHRM.tbl_HRM_JobType)
        Tbl_HRM_JobTypeBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_JobTypeBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_JobTypeBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_JobTypeBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_JobTypeBindingSource.EndEdit()
            Me.Tbl_HRM_JobTypeTableAdapter.Update(Me.DSHRM.tbl_HRM_JobType)
            Me.Tbl_HRM_JobTypeTableAdapter.FillBy(Me.DSHRM.tbl_HRM_JobType)
            Me.Tbl_HRM_JobTypeBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.jobtypeflag = True
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_JobTypeBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_JobTypeDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_HRM_JobTypeTableAdapter.FillBy(Me.DSHRM.tbl_HRM_JobType)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_JobTypeBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_JobTypeDataGridView.ReadOnly = True
        End Try
    End Sub

    Private Sub Tbl_HRM_JobTypeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_JobTypeDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_JobTypeDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_JobTypeDataGridView.DataError

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_JobTypeBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_JobTypeDataGridView.ReadOnly = False
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = True
        Tbl_HRM_JobTypeBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_JobTypeDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_JobTypeBindingSource.Position
        Tbl_HRM_JobTypeTableAdapter.FillBy(DSHRM.tbl_HRM_JobType)
        Tbl_HRM_JobTypeBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_JobTypeBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_HRM_JobTypeDataGridView.ReadOnly = True
        Tbl_HRM_JobTypeBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        Tbl_HRM_JobTypeBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub Tbl_HRM_JobTypeDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_JobTypeDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            Me.Tbl_HRM_JobTypeDataGridView(0, e.RowIndex).ReadOnly = True
            Try
                Me.Tbl_HRM_JobTypeDataGridView(0, e.RowIndex).Value = Me.Tbl_HRM_JobTypeDataGridView(0, e.RowIndex - 1).Value + 1
            Catch ex As Exception
                Me.Tbl_HRM_JobTypeDataGridView(0, e.RowIndex).Value = 1
            End Try
        End If
    End Sub
End Class