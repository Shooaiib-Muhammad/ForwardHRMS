Public Class frmTransDate

    Private Sub Tbl_Sec_Vehicle_HeadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Sec_Vehicle_HeadBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Sec_Vehicle_HeadBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSMisSec)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CancelToolStripButton.Visible = False
        BindingNavigatorDeleteItem.Enabled = True
        Tbl_Sec_Vehicle_HeadDataGridView.ReadOnly = True
        EditToolStripButton.Enabled = True
        Tbl_Sec_Vehicle_HeadBindingNavigatorSaveItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = True

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub Tbl_Sec_Vehicle_HeadDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_Vehicle_HeadDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Sec_Vehicle_HeadDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_Vehicle_HeadDataGridView.CellEnter
        If Me.Tbl_Sec_Vehicle_HeadDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
            Me.Tbl_Sec_Vehicle_HeadDataGridView(1, e.RowIndex).Value = Now.Date
        End If
    End Sub

    Private Sub Tbl_Sec_Vehicle_HeadDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Sec_Vehicle_HeadDataGridView.DataError

    End Sub

    Private Sub frmTransDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Sec_Vehicle_HeadTableAdapter.FillBy(Me.DSMisSec.tbl_Sec_Vehicle_Head)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_Sec_Vehicle_HeadBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        Tbl_Sec_Vehicle_HeadDataGridView.ReadOnly = False
        BindingNavigatorDeleteItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorDeleteItem.Enabled = False
        Tbl_Sec_Vehicle_HeadDataGridView.ReadOnly = False
        EditToolStripButton.Enabled = False
        Tbl_Sec_Vehicle_HeadBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Sec_Vehicle_HeadBindingSource.Position
        Tbl_Sec_Vehicle_HeadTableAdapter.FillBy(Me.DSMisSec.tbl_Sec_Vehicle_Head)
        Tbl_Sec_Vehicle_HeadBindingSource.Position = postion
        Tbl_Sec_Vehicle_HeadDataGridView.ReadOnly = True
        BindingNavigatorDeleteItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_Sec_Vehicle_HeadBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
    End Sub
End Class