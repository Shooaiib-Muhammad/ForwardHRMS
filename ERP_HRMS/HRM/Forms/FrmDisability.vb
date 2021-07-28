Public Class FrmDisability
    Private Sub Tbl_disability_descptionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmDisability_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_disability_descption' table. You can move, or remove it, as needed.
        Me.Tbl_disability_descptionTableAdapter.Fill(Me.DSHRM.tbl_disability_descption)

    End Sub

    Private Sub Tbl_disability_descptionBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_disability_descptionBindingNavigatorSaveItem.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_disability_descptionBindingSource.EndEdit()
            Me.Tbl_disability_descptionTableAdapter.Update(Me.DSHRM.tbl_disability_descption)
            Me.Tbl_disability_descptionTableAdapter.Fill(Me.DSHRM.tbl_disability_descption)
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.DisabilityFlag = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_disability_descptionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_disability_descptionDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_disability_descptionDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_disability_descptionDataGridView.DataError

    End Sub
End Class