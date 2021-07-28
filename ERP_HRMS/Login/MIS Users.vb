Public Class MIS_Users
    Private Sub MIS_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_MIS_User' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_MIS_UserTableAdapter.Fill(Me.DSUser.tbl_MIS_User)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DSUser.tbl_MIS_User_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_MIS_User_DeptTableAdapter.Fill(Me.DSUser.tbl_MIS_User_Dept)
        Tbl_MIS_UserBindingNavigatorSaveItem.Enabled = False

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ValidateChildren()
            Me.Tbl_MIS_UserBindingSource.EndEdit()
            Me.Tbl_MIS_UserTableAdapter.Update(Me.DSUser.tbl_MIS_User)
            Me.Tbl_MIS_UserTableAdapter.Fill(Me.DSUser.tbl_MIS_User)
            MsgBox("Added")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Tbl_MIS_UserDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_MIS_UserDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_MIS_UserDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_MIS_UserDataGridView.CellEnter
        If e.ColumnIndex = 2 Then
            Tbl_MIS_UserDataGridView(2, e.RowIndex).Value = Date.Now

        End If
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_MIS_UserBindingNavigatorSaveItem.Enabled = True
        Tbl_MIS_UserDataGridView.ReadOnly = False
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_MIS_UserBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_MIS_UserDataGridView.ReadOnly = False
    End Sub

    Private Sub Tbl_MIS_UserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_MIS_UserBindingNavigatorSaveItem.Click


        Dim j As Int16 = Me.Tbl_MIS_UserBindingSource.Position
        Try
                Me.ValidateChildren()
                Me.Tbl_MIS_UserBindingSource.EndEdit()
                Me.Tbl_MIS_UserTableAdapter.Update(Me.DSUser.tbl_MIS_User)
                Me.Tbl_MIS_UserTableAdapter.Fill(Me.DSUser.tbl_MIS_User)
            Me.Tbl_MIS_UserBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            BindingNavigatorAddNewItem.Enabled = True
                CancelToolStripButton.Visible = False

                EditToolStripButton.Enabled = True
                Tbl_MIS_UserBindingNavigatorSaveItem.Enabled = False
                Tbl_MIS_UserDataGridView.ReadOnly = True


            Catch ex As Exception
            Me.Tbl_MIS_UserTableAdapter.Fill(Me.DSUser.tbl_MIS_User)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False

            EditToolStripButton.Enabled = True
            Tbl_MIS_UserBindingNavigatorSaveItem.Enabled = False
            Tbl_MIS_UserDataGridView.ReadOnly = True


        End Try
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_MIS_UserBindingSource.Position
        Tbl_MIS_UserTableAdapter.Fill(DSUser.tbl_MIS_User)
        Tbl_MIS_UserBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True

        CancelToolStripButton.Visible = False
        Tbl_MIS_UserBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_MIS_UserDataGridView.ReadOnly = True
        Tbl_MIS_UserBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_MIS_UserDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_MIS_UserDataGridView.DataError

    End Sub
End Class
