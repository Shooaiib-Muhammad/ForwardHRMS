Public Class Emp_Employment_Info


    Private Sub Emp_Employment_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Employment' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_EmploymentTableAdapter.FillBy(Me.DSHRM.tbl_Hrm_Employment)
        Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_Hrm_EmploymentBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_Hrm_EmploymentBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Hrm_EmploymentBindingSource.EndEdit()
            Me.Tbl_Hrm_EmploymentTableAdapter.Update(Me.DSHRM.tbl_Hrm_Employment)
            Me.Tbl_Hrm_EmploymentTableAdapter.FillBy(Me.DSHRM.tbl_Hrm_Employment)
            Me.Tbl_Hrm_EmploymentBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Employmentflag = True
            Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_Hrm_EmploymentDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_Hrm_EmploymentTableAdapter.Fill(Me.DSHRM.tbl_Hrm_Employment)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_Hrm_EmploymentDataGridView.ReadOnly = True
        End Try
    End Sub

    Private Sub Tbl_Hrm_EmploymentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_EmploymentDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Hrm_EmploymentDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Hrm_EmploymentDataGridView.DataError

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Enabled = True
        Tbl_Hrm_EmploymentDataGridView.ReadOnly = False

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_Hrm_EmploymentDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Hrm_EmploymentBindingSource.Position
        Tbl_Hrm_EmploymentTableAdapter.FillBy(DSHRM.tbl_Hrm_Employment)
        Tbl_Hrm_EmploymentBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_Hrm_EmploymentDataGridView.ReadOnly = True
        Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        Tbl_Hrm_EmploymentBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub Tbl_Hrm_EmploymentDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_EmploymentDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            Me.Tbl_Hrm_EmploymentDataGridView(0, e.RowIndex).ReadOnly = True
            Try
                Me.Tbl_Hrm_EmploymentDataGridView(0, e.RowIndex).Value = Me.Tbl_Hrm_EmploymentDataGridView(0, e.RowIndex - 1).Value + 1
            Catch ex As Exception
                Me.Tbl_Hrm_EmploymentDataGridView(0, e.RowIndex).Value = 1
            End Try
        End If

    End Sub
End Class