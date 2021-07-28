Public Class App_Authourity


    Private Sub App_Authourity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSUser.tbl_HRM_App_Authority' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_App_AuthorityTableAdapter.Fill(Me.DSUser.tbl_HRM_App_Authority)
        Tbl_HRM_App_AuthorityBindingNavigatorSaveItem.Enabled = False


    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_App_AuthorityBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_App_AuthorityDataGridView.ReadOnly = False


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_App_AuthorityBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_App_AuthorityDataGridView.ReadOnly = False


    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_App_AuthorityBindingSource.Position
        Tbl_HRM_App_AuthorityTableAdapter.Fill(DSUser.tbl_HRM_App_Authority)
        Tbl_HRM_App_AuthorityBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True

        CancelToolStripButton.Visible = False
        Tbl_HRM_App_AuthorityBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_HRM_App_AuthorityDataGridView.ReadOnly = True
        Tbl_HRM_App_AuthorityBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_App_AuthorityBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_App_AuthorityBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_App_AuthorityBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_App_AuthorityBindingSource.EndEdit()
            Me.Tbl_HRM_App_AuthorityTableAdapter.Update(Me.DSUser.tbl_HRM_App_Authority)
            Me.Tbl_HRM_App_AuthorityTableAdapter.Fill(Me.DSUser.tbl_HRM_App_Authority)
            Me.Tbl_HRM_App_AuthorityBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Tbl_HRM_App_AuthorityBindingNavigatorSaveItem.Enabled = False
            EditToolStripButton.Enabled = True
            CancelToolStripButton.Visible = False
            BindingNavigatorAddNewItem.Enabled = True
        Catch ex As Exception

            MessageBox.Show("Record Not Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Tbl_HRM_App_AuthorityBindingNavigatorSaveItem.Enabled = False
            EditToolStripButton.Enabled = True
            CancelToolStripButton.Visible = False
            BindingNavigatorAddNewItem.Enabled = True
        End Try
    End Sub

    Private Sub Tbl_HRM_App_AuthorityDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_App_AuthorityDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_App_AuthorityDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_App_AuthorityDataGridView.DataError

    End Sub

    Private Sub Tbl_HRM_App_AuthorityDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_HRM_App_AuthorityDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class