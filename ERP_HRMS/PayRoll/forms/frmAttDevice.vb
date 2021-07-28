Public Class frmAttDevice
    Private Sub Tbl_Att_DeviceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Att_DeviceBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Att_DeviceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSPayRoll)
            MsgBox("Record Saved")
            CancelToolStripButton.Visible = False
            Tbl_Att_DeviceBindingNavigatorSaveItem.Enabled = False
            EditToolStripButton.Enabled = True
            BindingNavigatorAddNewItem.Enabled = True
            Tbl_Att_DeviceDataGridView.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub frmAttDevice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_Att_Device' table. You can move, or remove it, as needed.
        Me.Tbl_Att_DeviceTableAdapter.Fill(Me.DSPayRoll.tbl_Att_Device)

    End Sub

    Private Sub Tbl_Att_DeviceDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Att_DeviceDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Att_DeviceDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Att_DeviceDataGridView.DataError

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Tbl_Att_DeviceDataGridView.ReadOnly = False
        CancelToolStripButton.Visible = True
        Tbl_Att_DeviceBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        Tbl_Att_DeviceDataGridView.ReadOnly = False
        CancelToolStripButton.Visible = True
        Tbl_Att_DeviceBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Att_DeviceBindingSource.Position
        Tbl_Att_DeviceTableAdapter.Fill(DSPayRoll.tbl_Att_Device)
        Tbl_Att_DeviceBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        Tbl_Att_DeviceDataGridView.ReadOnly = True
        CancelToolStripButton.Visible = False
        Tbl_Att_DeviceBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
    End Sub
End Class