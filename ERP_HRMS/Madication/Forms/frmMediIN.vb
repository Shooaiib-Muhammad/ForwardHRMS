Public Class frmMediIN
    Private Sub Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_HRM_Emp_Medication_INBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSMedication)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.Tbl_HRM_Emp_Medication_INTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_IN, CType(TranDateToolStripTextBox.Text, Date))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmMediIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Med_Item' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item)

    End Sub

    Private Sub Tbl_HRM_Emp_Medication_INDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_Emp_Medication_INDataGridView.CellContentClick
        If Tbl_HRM_Emp_Medication_INDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
            Tbl_HRM_Emp_Medication_INDataGridView(1, e.RowIndex).Value = Now.Date
        End If
    End Sub

    Private Sub Tbl_HRM_Emp_Medication_INDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_Emp_Medication_INDataGridView.DataError

    End Sub
End Class