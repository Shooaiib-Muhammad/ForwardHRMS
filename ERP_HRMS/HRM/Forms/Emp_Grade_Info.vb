Public Class Emp_Grade_Info


    Private Sub Emp_Grade_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Grade)
        Tbl_HRM_GradeBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_GradeBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_GradeBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_GradeBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_GradeBindingSource.EndEdit()
            Me.Tbl_HRM_GradeTableAdapter.Update(Me.DSHRM.tbl_HRM_Grade)
            Me.Tbl_HRM_GradeTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Grade)
            Me.Tbl_HRM_GradeBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Gradeflag = True
            Tbl_HRM_GradeDataGridView.ReadOnly = True
            Tbl_HRM_GradeBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True

        Catch ex As Exception
            Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tbl_HRM_GradeDataGridView.ReadOnly = True
            Tbl_HRM_GradeBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True

        End Try
    End Sub

    Private Sub Tbl_HRM_GradeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_GradeDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_GradeDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_GradeDataGridView.DataError

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        Tbl_HRM_GradeBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_GradeDataGridView.ReadOnly = False


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_GradeBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_GradeDataGridView.ReadOnly = False

    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_GradeBindingSource.Position
        Tbl_HRM_GradeTableAdapter.FillBy(DSHRM.tbl_HRM_Grade)
        Tbl_HRM_GradeBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_GradeBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_HRM_GradeDataGridView.ReadOnly = True
        Tbl_HRM_GradeBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        Tbl_HRM_GradeBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub Tbl_HRM_GradeDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_GradeDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            Me.Tbl_HRM_GradeDataGridView(0, e.RowIndex).ReadOnly = True
            Try
                Me.Tbl_HRM_GradeDataGridView(0, e.RowIndex).Value = Me.Tbl_HRM_GradeDataGridView(0, e.RowIndex - 1).Value + 1
            Catch ex As Exception
                Me.Tbl_HRM_GradeDataGridView(0, e.RowIndex).Value = 1
            End Try
        End If
    End Sub
End Class