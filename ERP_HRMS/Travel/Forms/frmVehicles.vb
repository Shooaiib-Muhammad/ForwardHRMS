Public Class frmVehicles

    Private Sub Tbl_Sec_VehicleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Sec_VehicleBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Sec_VehicleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSMisSec)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'frmItemsINOUT.Vehicleflag = True
        'frmItemsOUT.Vehicleflag = True
        CancelToolStripButton.Visible = False
        BindingNavigatorDeleteItem.Enabled = True
        Tbl_Sec_VehicleDataGridView.ReadOnly = True
        EditToolStripButton.Enabled = True
        Tbl_Sec_VehicleBindingNavigatorSaveItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = True
    End Sub

    Private Sub frmVehicles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Vehicle' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_VehicleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle)

    End Sub

    Private Sub Tbl_Sec_VehicleDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_VehicleDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Sec_VehicleDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Sec_VehicleDataGridView.DataError

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_Sec_VehicleBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        Tbl_Sec_VehicleDataGridView.ReadOnly = False
        BindingNavigatorDeleteItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorDeleteItem.Enabled = False
        Tbl_Sec_VehicleDataGridView.ReadOnly = False
        EditToolStripButton.Enabled = False
        Tbl_Sec_VehicleBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Sec_VehicleBindingSource.Position
        Tbl_Sec_VehicleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle)
        Tbl_Sec_VehicleBindingSource.Position = postion
        Tbl_Sec_VehicleDataGridView.ReadOnly = True
        BindingNavigatorDeleteItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_Sec_VehicleBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
    End Sub
End Class