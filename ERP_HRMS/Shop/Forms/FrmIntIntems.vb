Public Class FrmIntIntems

    Public Shared Categoryflag As Boolean = False
    Private Sub FrmIntIntems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSint.tbl_Shop_Item_Category_NEW' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_Item_Category_NEWTableAdapter.Fill(Me.DSint.tbl_Shop_Item_Category_NEW)
        'TODO: This line of code loads data into the 'DSint.tbl_Shop_Item' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_ItemTableAdapter.Fill(Me.DSint.tbl_Shop_Item)
        'TODO: This line of code loads data into the 'DSint.tbl_Shop_Item_Category' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_Item_CategoryTableAdapter.Fill(Me.DSint.tbl_Shop_Item_Category)
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Itemtxt.TextLength > 1 And UOMTxt.TextLength > 1 And PurchaseTxt.TextLength > 0 And SaleTxt.TextLength > 0 And BarcodeTxt.TextLength Then
            Me.Tbl_Shop_ItemTableAdapter.Insert(BarcodeTxt.Text, Itemtxt.Text, Now.Date, SaleTxt.Text, PurchaseTxt.Text, UOMTxt.Text, 1, Me.ComboBox1.SelectedValue)
            Me.Tbl_Shop_ItemTableAdapter.Fill(Me.DSint.tbl_Shop_Item)
            Clear()
        Else
            MsgBox("Missing Information")
        End If
    End Sub

    Private Sub Tbl_Shop_ItemBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Shop_ItemBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Shop_ItemBindingSource.EndEdit()
            Me.Tbl_Shop_ItemTableAdapter.Update(Me.DSint.tbl_Shop_Item)
            Me.Tbl_Shop_ItemTableAdapter.Fill(Me.DSint.tbl_Shop_Item)
            MsgBox("Data Saved Successfully")
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_Shop_ItemBindingNavigatorSaveItem.Enabled = False
            Tbl_Shop_ItemDataGridView.ReadOnly = True
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_Shop_ItemBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_Shop_ItemDataGridView.ReadOnly = False
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_Shop_ItemBindingNavigatorSaveItem.Enabled = True
        Tbl_Shop_ItemDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Shop_ItemBindingSource.Position
        Tbl_Shop_ItemTableAdapter.Fill(DSint.tbl_Shop_Item)
        Tbl_Shop_ItemBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_Shop_ItemBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        Tbl_Shop_ItemDataGridView.ReadOnly = True
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Categoryflag = True Then
            Me.Tbl_Shop_Item_Category_NEWTableAdapter.Fill(Me.DSint.tbl_Shop_Item_Category_NEW)
            Categoryflag = False
        End If
    End Sub
    Private Sub Clear()
        Itemtxt.Clear()
        UOMTxt.Clear()
        PurchaseTxt.Clear()
        SaleTxt.Clear()
        BarcodeTxt.Clear()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If Me.txtsearch.TextLength = 0 Then
                Tbl_Shop_ItemBindingSource.RemoveFilter()
            Else

                Tbl_Shop_ItemBindingSource.Filter = String.Format("ItemName Like '*" & txtsearch.Text) & "*'"

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Shop_ItemDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_ItemDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Shop_ItemDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Shop_ItemDataGridView.DataError

    End Sub
End Class