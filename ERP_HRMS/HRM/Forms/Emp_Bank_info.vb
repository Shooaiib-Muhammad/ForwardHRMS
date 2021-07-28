Public Class Emp_Bank_info
    Private Sub Emp_Bank_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAdvance.tbl_Fin_Layer4_New' table. You can move, or remove it, as needed.
        ''Me.Tbl_Fin_Layer4_NewTableAdapter.FillBy(Me.DSAdvance.tbl_Fin_Layer4_New)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Bank' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BankTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Bank)
        Tbl_HRM_BankBindingNavigatorSaveItem.Enabled = False
    End Sub
    Private Sub Tbl_HRM_BankBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_BankBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_BankBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_BankBindingSource.EndEdit()
            Me.Tbl_HRM_BankTableAdapter.Update(Me.DSHRM.tbl_HRM_Bank)
            Me.Tbl_HRM_BankTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Bank)
            Me.Tbl_HRM_BankBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Bankflag = True
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_BankBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_BankDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_HRM_BankTableAdapter.Fill(Me.DSHRM.tbl_HRM_Bank)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            Tbl_HRM_BankBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_BankDataGridView.ReadOnly = True
        End Try
    End Sub

    Private Sub Tbl_HRM_BankDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_BankDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_BankDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_BankDataGridView.DataError

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_BankBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_BankDataGridView.ReadOnly = False
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_BankBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_BankDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_BankBindingSource.Position
        Tbl_HRM_BankTableAdapter.FillBy(DSHRM.tbl_HRM_Bank)
        Tbl_HRM_BankBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_BankBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_HRM_BankDataGridView.ReadOnly = True
        Tbl_HRM_BankBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_BankDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_BankDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            Me.Tbl_HRM_BankDataGridView(0, e.RowIndex).ReadOnly = True
            Try
                Me.Tbl_HRM_BankDataGridView(0, e.RowIndex).Value = Me.Tbl_HRM_BankDataGridView(0, e.RowIndex - 1).Value + 1
            Catch ex As Exception
                Me.Tbl_HRM_BankDataGridView(0, e.RowIndex).Value = 1
            End Try
        End If
    End Sub

    Private Sub Tbl_HRM_BankDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_HRM_BankDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub
End Class