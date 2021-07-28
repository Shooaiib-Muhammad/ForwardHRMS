Public Class FrmLockUser
    Private Sub FrmLockUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.Tbl_Lock_Users' table. You can move, or remove it, as needed.
        Me.Tbl_Lock_UsersTableAdapter.Fill(Me.DSUser.Tbl_Lock_Users)

    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Lock_UsersBindingSource.EndEdit()
            Me.Tbl_Lock_UsersTableAdapter.Update(Me.DSUser.Tbl_Lock_Users)
            Me.Tbl_Lock_UsersTableAdapter.Fill(Me.DSUser.Tbl_Lock_Users)

            MessageBox.Show("User Unlocked Successfully", "Unlock Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Tbl_Lock_UsersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Lock_UsersDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Lock_UsersDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Lock_UsersDataGridView.DataError

    End Sub
End Class