Public Class frmMadicationIN
    Private Sub Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Click
        Try

            Me.Validate()
            Me.Tbl_HRM_Emp_Medication_INBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSMedication)
            'Me.Validate()
            'Me.Tbl_HRM_Emp_Medication_INBindingSource.EndEdit()
            'Me.Tbl_HRM_Emp_Medication_INTableAdapter.Update(Me.DSMedication.tbl_HRM_Emp_Medication_IN)
            Me.Tbl_HRM_Emp_Medication_INTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_IN, Now.Date)
            Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Enabled = False
            CancelToolStripButton.Visible = False
            Tbl_HRM_Emp_Medication_INDataGridView.ReadOnly = True
            BindingNavigatorAddNewItem.Enabled = True
            EditToolStripButton.Enabled = True
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmMadicationIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Med_Item' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Medication_Rec_Details' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter.FillBy(Me.DSMedication.tbl_HRM_Emp_Medication_Rec_Details)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Medication_IN' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Medication_INTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_IN, Now.Date)

    End Sub

    Private Sub Tbl_HRM_Emp_Medication_INDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub




    Private Sub Tbl_HRM_Emp_Medication_INDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        Tbl_HRM_Emp_Medication_INDataGridView.ReadOnly = False
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_HRM_Emp_Medication_INDataGridView.ReadOnly = False
        EditToolStripButton.Enabled = False
        Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_Emp_Medication_INBindingSource.Position
        Me.Tbl_HRM_Emp_Medication_INTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_IN, Now.Date)
        Tbl_HRM_Emp_Medication_INBindingSource.Position = postion
        Tbl_HRM_Emp_Medication_INDataGridView.ReadOnly = True
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
    End Sub

    Private Sub Tbl_HRM_Emp_Medication_INDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_Emp_Medication_INDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_Emp_Medication_INDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_Emp_Medication_INDataGridView.DataError

    End Sub

    Private Sub Tbl_HRM_Emp_Medication_INDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_Emp_Medication_INDataGridView.CellEnter
        If Tbl_HRM_Emp_Medication_INDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
            Tbl_HRM_Emp_Medication_INDataGridView(1, e.RowIndex).Value = Now.Date
        End If
        If e.ColumnIndex = 4 Then
            If Tbl_HRM_Emp_Medication_INDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Tbl_HRM_Emp_Medication_INDataGridView(4, e.RowIndex).Value = 0
            End If
        End If
        If e.ColumnIndex = 5 Then
            If Tbl_HRM_Emp_Medication_INDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                Tbl_HRM_Emp_Medication_INDataGridView(5, e.RowIndex).Value = 0
            End If
        End If
        If e.ColumnIndex = 6 Then
            If Tbl_HRM_Emp_Medication_INDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Tbl_HRM_Emp_Medication_INDataGridView(6, e.RowIndex).Value = "PCS"
            End If
        End If
    End Sub
End Class