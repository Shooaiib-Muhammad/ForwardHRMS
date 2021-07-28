Public Class FrmFormacy
    Private Sub Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmFormacy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Medication_Pharmacy' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Medication_PharmacyTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_Pharmacy)

    End Sub

    Private Sub Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_HRM_Emp_Medication_PharmacyBindingSource.EndEdit()
            Me.Tbl_HRM_Emp_Medication_PharmacyTableAdapter.Update(Me.DSMedication.tbl_HRM_Emp_Medication_Pharmacy)

            Me.Tbl_HRM_Emp_Medication_PharmacyTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_Pharmacy)
            Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Enabled = False
            CancelToolStripButton.Visible = False
            Tbl_HRM_Emp_Medication_PharmacyDataGridView.ReadOnly = True
            BindingNavigatorAddNewItem.Enabled = True
            EditToolStripButton.Enabled = True
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        Tbl_HRM_Emp_Medication_PharmacyDataGridView.ReadOnly = False
    End Sub

    Private Sub Tbl_HRM_Emp_Medication_PharmacyDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_Emp_Medication_PharmacyDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_Emp_Medication_PharmacyDataGridView_DataMemberChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_Emp_Medication_PharmacyDataGridView.DataMemberChanged

    End Sub

    Private Sub Tbl_HRM_Emp_Medication_PharmacyDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_Emp_Medication_PharmacyDataGridView.DataError

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_HRM_Emp_Medication_PharmacyDataGridView.ReadOnly = False
        EditToolStripButton.Enabled = False
        Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_Emp_Medication_PharmacyBindingSource.Position
        Tbl_HRM_Emp_Medication_PharmacyTableAdapter.Fill(DSMedication.tbl_HRM_Emp_Medication_Pharmacy)
        Tbl_HRM_Emp_Medication_PharmacyBindingSource.Position = postion
        Tbl_HRM_Emp_Medication_PharmacyDataGridView.ReadOnly = True
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
    End Sub
End Class