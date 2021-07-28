Public Class frmTranSactionIN
    Private Sub Tbl_HRM_TranDateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_TranDateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSShop)

    End Sub

    Private Sub frmTranSactionIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSNEWShop.tbl_Shop_Item' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_ItemTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item)
        'TODO: This line of code loads data into the 'DSNEWShop.tbl_Shop_Item' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_ItemTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item)
        'TODO: This line of code loads data into the 'DSNEWShop.tbl_Shop_Item_SHOP' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_Item_SHOPTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item_SHOP)
        'TODO: This line of code loads data into the 'DSNEWShop.tbl_Shop_Item_New' table. You can move, or remove it, as needed.
        'Me.Tbl_Shop_Item_NewTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item_New)
        'TODO: This line of code loads data into the 'DSNEWShop.tbl_Shop_Item' table. You can move, or remove it, as needed.
        'Me.Tb_Shop_ItemTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item)
        'TODO: This line of code loads data into the 'DSNEWShop.tbl_Shop_Item_Category_NEW' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_Item_Category_NEWTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item_Category_NEW)
        'TODO: This line of code loads data into the 'DSShop.tbl_Shop_Supplier' table. You can move, or remove it, as needed.
        'Me.Tbl_Shop_SupplierTableAdapter.FillBy(Me.DSShop.tbl_Shop_Supplier)

        'TODO: This line of code loads data into the 'DSShop.tbl_Shop_Tran_IN' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSShop.tbl_HRM_TranDate' table. You can move, or remove it, as needed.
        If Me.Tbl_HRM_TranDateTableAdapter.Fill(Me.DSShop.tbl_HRM_TranDate, Now.Date) > 0 Then
            Me.Tbl_HRM_TranDateTableAdapter.Fill(Me.DSShop.tbl_HRM_TranDate, Now.Date.AddDays(-90))
        Else
            Me.Tbl_HRM_TranDateTableAdapter.Insert(Now.Date)
            Me.Tbl_HRM_TranDateTableAdapter.Fill(Me.DSShop.tbl_HRM_TranDate, Now.Date.AddDays(-90))
        End If
        Tbl_HRM_TranDateBindingSource.MoveLast()
        Try
            Me.Tbl_Shop_Tran_INTableAdapter.FillBy(Me.DSShop.tbl_Shop_Tran_IN, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_Shop_Tran_INBindingSource.MoveLast()
            Me.Tbl_Shop_Tran_INTableAdapter.Update(Me.DSShop.tbl_Shop_Tran_IN)
            Try
                Me.Tbl_Shop_Tran_INTableAdapter.FillBy(Me.DSShop.tbl_Shop_Tran_IN, Me.DayNoLabel1.Text)
            Catch ex As Exception

            End Try
            MsgBox("Data Saved Successfully")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Tbl_Shop_Tran_INDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_Tran_INDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Shop_Tran_INDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Shop_Tran_INDataGridView.DataError

    End Sub

    Private Sub Tbl_Shop_Tran_INDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_Tran_INDataGridView.CellEnter
        If e.ColumnIndex = 1 Then

            'If Tbl_Shop_Tran_INDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
            '    Tbl_Shop_Tran_INDataGridView(2, e.RowIndex).Value = Label1.Text
            'End If
            'If Tbl_Shop_Tran_INDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
            '    Tbl_Shop_Tran_INDataGridView(3, e.RowIndex).Value = Label2.Text
            'End If



            'If Tbl_Shop_Tran_INDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
            '    Tbl_Shop_Tran_INDataGridView(3, e.RowIndex).Value = Val(Label2.Text)
            'End If
        End If

    End Sub

    Private Sub Tbl_Shop_Tran_INDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Shop_Tran_INDataGridView.EditingControlShowing

        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If

    End Sub

    Private Sub Tbl_HRM_TranDateBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_TranDateBindingSource.PositionChanged
        Try
            Me.Tbl_Shop_Tran_INTableAdapter.FillBy(Me.DSShop.tbl_Shop_Tran_IN, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If ItemComboBox.SelectedValue < 1 Then
            MsgBox("Please select an item", MsgBoxStyle.Critical, "Error")
            Return
        End If
        If QtyTextBox.Text <= 0 Then
            MsgBox("Quantity Should be greater than 0", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Try
            Me.Tbl_Shop_Tran_INTableAdapter.Insert(DayNoLabel1.Text, ItemComboBox.SelectedValue, Nothing, QtyTextBox.Text, PurchasePriceTextBox.Text, UOMTextBox.Text, Now.Date, Nothing, NarrationTextBox.Text, TransTypeComboBox.Text, SupplierTextBox.Text)
            QtyTextBox.Text = 0
            PurchasePriceTextBox.Text = 0
            Me.Tbl_Shop_ItemBindingSource.Position = 0
            SupplierTextBox.Text = ""
            NarrationTextBox.Text = ""
            MsgBox("Data saved successfully", MsgBoxStyle.Information, "Success")
            QtyTextBox.Text = 0
            BarcodeTextBox.Clear()

            BarcodeTextBox.Select()
            Me.Tbl_Shop_Tran_INTableAdapter.FillBy(Me.DSShop.tbl_Shop_Tran_IN, DayNoLabel1.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try


    End Sub


    Private Sub BarcodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles BarcodeTextBox.TextChanged
        If BarcodeTextBox.TextLength >= 1 Then
            Me.Tbl_Shop_ItemTableAdapter.FillBy(Me.DSNEWShop.tbl_Shop_Item, BarcodeTextBox.Text)
            QtyTextBox.Text = 1
        Else
            Me.Tbl_Shop_ItemTableAdapter.Fill(Me.DSNEWShop.tbl_Shop_Item)
        End If

    End Sub


    Private Sub QtyTextBox_KeyUp_1(sender As Object, e As KeyEventArgs) Handles QtyTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            SaveButton_Click(sender, e)
        End If
    End Sub
End Class