Public Class Employee_Notice


    Private Sub Employee_Notice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Emp_Notices' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_Emp_NoticesTableAdapter.FillBy(Me.DSHRM.tbl_Hrm_Emp_Notices)
        Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Enabled = False

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Enabled = True
        Tbl_Hrm_Emp_NoticesDataGridView.ReadOnly = False
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_Hrm_Emp_NoticesDataGridView.ReadOnly = False
    End Sub

    Private Sub Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_Hrm_Emp_NoticesBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Hrm_Emp_NoticesBindingSource.EndEdit()
            Me.Tbl_Hrm_Emp_NoticesTableAdapter.Update(Me.DSHRM.tbl_Hrm_Emp_Notices)
            Me.Tbl_Hrm_Emp_NoticesTableAdapter.FillBy(Me.DSHRM.tbl_Hrm_Emp_Notices)
            Me.Tbl_Hrm_Emp_NoticesBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Notesflag = True
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Enabled = False
            Tbl_Hrm_Emp_NoticesDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_Hrm_Emp_NoticesTableAdapter.Fill(Me.DSHRM.tbl_Hrm_Emp_Notices)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Enabled = False
            Tbl_Hrm_Emp_NoticesDataGridView.ReadOnly = True
        End Try

    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Hrm_Emp_NoticesBindingSource.Position
        Tbl_Hrm_Emp_NoticesTableAdapter.FillBy(DSHRM.tbl_Hrm_Emp_Notices)
        Tbl_Hrm_Emp_NoticesBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        EditToolStripButton.Enabled = True
        Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Enabled = False
        Tbl_Hrm_Emp_NoticesDataGridView.ReadOnly = True
        Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_Hrm_Emp_NoticesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Emp_NoticesDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Hrm_Emp_NoticesDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Emp_NoticesDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            Me.Tbl_Hrm_Emp_NoticesDataGridView(0, e.RowIndex).ReadOnly = True
            Try
                Me.Tbl_Hrm_Emp_NoticesDataGridView(0, e.RowIndex).Value = Me.Tbl_Hrm_Emp_NoticesDataGridView(0, e.RowIndex - 1).Value + 1
            Catch ex As Exception
                Me.Tbl_Hrm_Emp_NoticesDataGridView(0, e.RowIndex).Value = 1
            End Try
        End If
    End Sub

    Private Sub Tbl_Hrm_Emp_NoticesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Hrm_Emp_NoticesDataGridView.DataError

    End Sub
End Class