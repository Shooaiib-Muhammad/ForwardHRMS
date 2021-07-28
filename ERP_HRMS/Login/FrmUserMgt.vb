Public Class FrmUserMgt
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSUser)

    End Sub
    Public Shared NewLoginname As String
    Private Sub FrmUserMgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_MIS_User_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_MIS_User_DeptTableAdapter.Fill(Me.DSUser.tbl_MIS_User_Dept)
        'TODO: This line of code loads data into the 'DSUM.tbl_MIS_User_Mgt' table. You can move, or remove it, as needed.
        Me.Tbl_MIS_User_MgtTableAdapter.FillBy(Me.DSUM.tbl_MIS_User_Mgt)
        'TODO: This line of code loads data into the 'DSUser.tbl_MIS_User_NEW' table. You can move, or remove it, as needed.
        'Me.Tbl_MIS_User_NEWTableAdapter.Fill(Me.DSUser.tbl_MIS_User_NEW)
        ''TODO: This line of code loads data into the 'DSUser.Users' table. You can move, or remove it, as needed.
        'Me.UsersTableAdapter.Fill(Me.DSUser.Users)

    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_MIS_User_MgtBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_MIS_User_MgtBindingSource.EndEdit()
            Me.Tbl_MIS_User_MgtTableAdapter.Update(Me.DSUM.tbl_MIS_User_Mgt)
            Me.Tbl_MIS_User_MgtTableAdapter.FillBy(Me.DSUM.tbl_MIS_User_Mgt)
            Me.Tbl_MIS_User_MgtBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)




        Catch ex As Exception
            'Me.UsersTableAdapter.Fill(Me.DSUser.Users)
            MessageBox.Show(ex.Message + "No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)



        End Try
    End Sub
    Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In Me.MdiChildren
            If f.Name = childWindow Then
                f.Focus()
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub UsersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDataGridView.CellContentClick
        If e.ColumnIndex = 29 Then
            NewLoginname = Me.UsersDataGridView(0, e.RowIndex).Value
            If ChildWindowOpen("FrmReset") = False Then
                Dim frmChngPswdObj1115 As New FrmReset
                'frmChngPswdObj1115.MdiParent = Me
                'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
                frmChngPswdObj1115.ShowDialog()

            End If
        End If
    End Sub

    Private Sub UsersDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles UsersDataGridView.DataError

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            Me.Tbl_MIS_User_MgtTableAdapter.Fill(Me.DSUM.tbl_MIS_User_Mgt)
        ElseIf RadioButton2.Checked Then
            Me.Tbl_MIS_User_MgtTableAdapter.FillBy1(Me.DSUM.tbl_MIS_User_Mgt)
        ElseIf RadioButton3.Checked Then
            Me.Tbl_MIS_User_MgtTableAdapter.FillBy(Me.DSUM.tbl_MIS_User_Mgt)

        End If


    End Sub
    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_MIS_User_MgtBindingSource.Filter = "LoginName like'%" & Me.ToolStripTextBox1.Text & "%'"
            Me.ToolStripTextBox1.Clear()
            Me.SupplierContextMenuStrip.Hide()
        End If
    End Sub
    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveFilterToolStripMenuItem.Click
        Me.Tbl_MIS_User_MgtBindingSource.RemoveFilter()
    End Sub
End Class