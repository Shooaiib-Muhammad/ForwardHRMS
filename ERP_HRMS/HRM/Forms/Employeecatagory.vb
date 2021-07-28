Public Class Employee_catagory


    Private Sub Employee_catagory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_EmpCatagory' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_EmpCatagoryTableAdapter.FillBy(Me.DSHRM.tbl_HRM_EmpCatagory)
        Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem.Enabled = False

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_EmpCatagoryDataGridView.ReadOnly = False

    End Sub

    Private Sub Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem.Click



        Dim j As Int16 = Me.Tbl_HRM_EmpCatagoryBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_EmpCatagoryBindingSource.EndEdit()
            Me.Tbl_HRM_EmpCatagoryTableAdapter.Update(Me.DSHRM.tbl_HRM_EmpCatagory)
            Me.Tbl_HRM_EmpCatagoryTableAdapter.FillBy(Me.DSHRM.tbl_HRM_EmpCatagory)
            Me.Tbl_HRM_EmpCatagoryBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.catagoryflag = True
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_EmpCatagoryDataGridView.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Tbl_HRM_EmpCatagoryTableAdapter.FillBy(Me.DSHRM.tbl_HRM_EmpCatagory)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_EmpCatagoryDataGridView.ReadOnly = True
        End Try
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_EmpCatagoryDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim Empcatagpostion As Integer = Tbl_HRM_EmpCatagoryBindingSource.Position
        Tbl_HRM_EmpCatagoryTableAdapter.FillBy(DSHRM.tbl_HRM_EmpCatagory)
        Tbl_HRM_EmpCatagoryBindingSource.Position = Empcatagpostion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_HRM_EmpCatagoryDataGridView.ReadOnly = True
        Tbl_HRM_EmpCatagoryBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_EmpCatagoryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_EmpCatagoryDataGridView.CellContentClick
    End Sub

    Private Sub Tbl_HRM_EmpCatagoryDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_EmpCatagoryDataGridView.DataError

    End Sub

    Private Sub Tbl_HRM_EmpCatagoryDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_EmpCatagoryDataGridView.CellEnter
        Me.Tbl_HRM_EmpCatagoryDataGridView(0, e.RowIndex).ReadOnly = True
        Try
            Me.Tbl_HRM_EmpCatagoryDataGridView(0, e.RowIndex).Value = Me.Tbl_HRM_EmpCatagoryDataGridView(0, e.RowIndex - 1).Value + 1
        Catch ex As Exception
            Me.Tbl_HRM_EmpCatagoryDataGridView(0, e.RowIndex).Value = 1
        End Try

    End Sub
End Class