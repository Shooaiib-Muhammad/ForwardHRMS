Public Class frmCatagory
    Private Sub Tbl_Shop_Item_Category_NEWBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Shop_Item_Category_NEWBindingNavigatorSaveItem.Click
        Dim k As Int16 = Me.Tbl_Shop_Item_Category_NEWBindingSource.Position
        Try
            Me.Validate()
            Me.Tbl_Shop_Item_Category_NEWBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSNEWShop)
            Me.Tbl_Shop_Item_Category_NEWTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item_Category_NEW)
            Me.Tbl_Shop_Item_Category_NEWBindingSource.Position = k
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub frmCatagory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSNEWShop.tbl_Shop_Item_Category_NEW' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_Item_Category_NEWTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item_Category_NEW)

    End Sub

    Private Sub Tbl_Shop_Item_Category_NEWDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_Item_Category_NEWDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Shop_Item_Category_NEWDataGridView_DragEnter(sender As Object, e As DragEventArgs) Handles Tbl_Shop_Item_Category_NEWDataGridView.DragEnter

    End Sub

    Private Sub Tbl_Shop_Item_Category_NEWDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Shop_Item_Category_NEWDataGridView.DataError

    End Sub

    Private Sub frmCatagory_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        FrmShopitems.Categoryflag = True
    End Sub
End Class