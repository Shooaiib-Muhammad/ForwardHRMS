Public Class frmDriver



    Private Sub frmDriver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Driver' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_DriverTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Driver)

    End Sub

    Private Sub Tbl_Sec_DriverDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_DriverDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Sec_DriverDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Sec_DriverDataGridView.DataError

    End Sub

   

    Private Sub Tbl_Sec_DriverBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Sec_DriverBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Sec_DriverBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSMisSec)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'frmItemsINOUT.Driverflag = True
        'frmItemsOUT.Driverflag = True
        CancelToolStripButton.Visible = False
        BindingNavigatorDeleteItem.Enabled = True
        Tbl_Sec_DriverDataGridView.ReadOnly = True
        EditToolStripButton.Enabled = True
        Tbl_Sec_DriverBindingNavigatorSaveItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = True
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_Sec_DriverBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        Tbl_Sec_DriverDataGridView.ReadOnly = False
        BindingNavigatorDeleteItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorDeleteItem.Enabled = False
        Tbl_Sec_DriverDataGridView.ReadOnly = False
        EditToolStripButton.Enabled = False
        Tbl_Sec_DriverBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Sec_DriverBindingSource.Position
        Tbl_Sec_DriverTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Driver)
        Tbl_Sec_DriverBindingSource.Position = postion
        Tbl_Sec_DriverDataGridView.ReadOnly = True
        BindingNavigatorDeleteItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_Sec_DriverBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
    End Sub
End Class