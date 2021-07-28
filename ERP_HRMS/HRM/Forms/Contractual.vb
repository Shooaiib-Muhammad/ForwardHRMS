Public Class Contractual




    Private Sub Contractual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSContractual.tbl_HRM_Contractor' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ContractorTableAdapter.Fill(Me.DSContractual.tbl_HRM_Contractor)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_ContractorBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_ContractorDataGridView.ReadOnly = False
    End Sub



    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        Tbl_HRM_ContractorBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_ContractorDataGridView.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_ContractorBindingSource.Position
        Tbl_HRM_ContractorTableAdapter.Fill(DSContractual.tbl_HRM_Contractor)
        Tbl_HRM_ContractorBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_ContractorBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = True
        Tbl_HRM_ContractorDataGridView.ReadOnly = True
        Tbl_HRM_ContractorBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_ContractorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_HRM_ContractorBindingNavigatorSaveItem.Click

        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_ContractorBindingSource.EndEdit()
            Me.Tbl_HRM_ContractorTableAdapter.Update(Me.DSContractual.tbl_HRM_Contractor)
            Me.Tbl_HRM_ContractorTableAdapter.Fill(Me.DSContractual.tbl_HRM_Contractor)

            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Tbl_HRM_ContractorDataGridView.ReadOnly = True
            Tbl_HRM_ContractorBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_HRM_ContractorDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_ContractorDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_ContractorDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_ContractorDataGridView.DataError

    End Sub
End Class