Public Class FrmSupplier


    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSShop.tbl_Shop_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_SupplierTableAdapter.Fill(Me.DSShop.tbl_Shop_Supplier)

    End Sub

    Private Sub Tbl_Shop_SupplierDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_SupplierDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Shop_SupplierDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_SupplierDataGridView.CellEnter
        If e.ColumnIndex = 3 Then
            If Tbl_Shop_SupplierDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Shop_SupplierDataGridView(3, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub Tbl_Shop_SupplierDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Shop_SupplierDataGridView.DataError

    End Sub

    Private Sub Tbl_Shop_SupplierBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Shop_SupplierBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Shop_SupplierBindingSource.EndEdit()
            Me.Tbl_Shop_SupplierTableAdapter.Update(Me.DSShop.tbl_Shop_Supplier)
            Me.Tbl_Shop_SupplierTableAdapter.Fill(Me.DSShop.tbl_Shop_Supplier)
            MsgBox("Data Saved Successfully")
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_Shop_SupplierBindingNavigatorSaveItem.Enabled = False
            Tbl_Shop_SupplierDataGridView.ReadOnly = True
        Catch ex As Exception
            MsgBox("Data Not Saved")


        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_Shop_SupplierBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_Shop_SupplierDataGridView.ReadOnly = False
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_Shop_SupplierBindingNavigatorSaveItem.Enabled = True
        Tbl_Shop_SupplierDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Shop_SupplierBindingSource.Position
        Tbl_Shop_SupplierTableAdapter.Fill(DSShop.tbl_Shop_Supplier)
        Tbl_Shop_SupplierBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_Shop_SupplierBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        Tbl_Shop_SupplierDataGridView.ReadOnly = True
    End Sub
End Class