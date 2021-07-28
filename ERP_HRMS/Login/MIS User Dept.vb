Public Class MIS_User_Dept


    Private Sub MIS_User_Dept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_MIS_User_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_MIS_User_DeptTableAdapter.FillBy(Me.DSUser.tbl_MIS_User_Dept)
        Tbl_MIS_User_DeptBindingNavigatorSaveItem.Enabled = False


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Tbl_MIS_User_DeptBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_MIS_User_DeptDataGridView.ReadOnly = False

    End Sub

    Private Sub Tbl_MIS_User_DeptBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_MIS_User_DeptBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_MIS_User_DeptBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_MIS_User_DeptBindingSource.EndEdit()
            Me.Tbl_MIS_User_DeptTableAdapter.Update(Me.DSUser.tbl_MIS_User_Dept)
            Me.Tbl_MIS_User_DeptTableAdapter.FillBy(Me.DSUser.tbl_MIS_User_Dept)
            Me.Tbl_MIS_User_DeptBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tbl_MIS_User_DeptBindingNavigatorSaveItem.Enabled = False
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            BindingNavigatorAddNewItem.Enabled = True
            Tbl_MIS_User_DeptDataGridView.ReadOnly = True



        Catch ex As Exception
            Me.Tbl_MIS_User_DeptTableAdapter.Fill(Me.DSUser.tbl_MIS_User_Dept)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tbl_MIS_User_DeptBindingNavigatorSaveItem.Enabled = False
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            BindingNavigatorAddNewItem.Enabled = True
            Tbl_MIS_User_DeptDataGridView.ReadOnly = True

        End Try
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_MIS_User_DeptBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_MIS_User_DeptDataGridView.ReadOnly = False


    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_MIS_User_DeptBindingSource.Position
        Tbl_MIS_User_DeptTableAdapter.Fill(DSUser.tbl_MIS_User_Dept)
        Tbl_MIS_User_DeptBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True

        CancelToolStripButton.Visible = False
        Tbl_MIS_User_DeptBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_MIS_User_DeptDataGridView.ReadOnly = True
        Tbl_MIS_User_DeptBindingNavigatorSaveItem.Enabled = False

        BindingNavigatorAddNewItem.Enabled = True

    End Sub

    Private Sub Tbl_MIS_User_DeptDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_MIS_User_DeptDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_MIS_User_DeptDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_MIS_User_DeptDataGridView.DataError

    End Sub
End Class