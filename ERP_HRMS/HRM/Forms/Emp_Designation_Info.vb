Public Class Emp_Designation_Info


    Private Sub Emp_Designation_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Designation)
        Tbl_HRM_DesignationBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_DesignationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_DesignationBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_DesignationBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_DesignationBindingSource.EndEdit()
            Me.Tbl_HRM_DesignationTableAdapter.Update(Me.DSHRM.tbl_HRM_Designation)
            Me.Tbl_HRM_DesignationTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Designation)
            Me.Tbl_HRM_DesignationBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Designationflag = True
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_DesignationBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_DesignationDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_HRM_DesignationTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Designation)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_DesignationBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_DesignationDataGridView.ReadOnly = True
        End Try
    End Sub

    Private Sub Tbl_HRM_DesignationDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_DesignationDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_DesignationDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_DesignationDataGridView.DataError

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_DesignationBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_DesignationDataGridView.ReadOnly = False
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_DesignationBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_DesignationDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_DesignationBindingSource.Position
        Tbl_HRM_DesignationTableAdapter.FillBy(DSHRM.tbl_HRM_Designation)
        Tbl_HRM_DesignationBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_DesignationBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_HRM_DesignationDataGridView.ReadOnly = True
        Tbl_HRM_DesignationBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        Tbl_HRM_DesignationBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub Tbl_HRM_DesignationDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_DesignationDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            Me.Tbl_HRM_DesignationDataGridView(0, e.RowIndex).ReadOnly = True
        End If
    End Sub
End Class