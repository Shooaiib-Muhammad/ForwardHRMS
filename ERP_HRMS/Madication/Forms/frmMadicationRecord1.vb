Public Class frmMadicationRecord1
    Private Sub Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem.Click
        Try


            Me.Validate()
            Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSMedication)
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_Rec_Head)
            DeptNameTextBox.ReadOnly = True


        Catch ex As Exception
            MessageBox.Show("No Record Saved " & ex.Message, "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub frmMadicationRecord1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Medication_Rec_Details' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_Rec_Details)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Medication_Rec_Head' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_Rec_Head)

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try

            Me.Validate()
            Me.Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource.EndEdit()
            Me.Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter.Update(Me.DSMedication.tbl_HRM_Emp_Medication_Rec_Details)
            Me.Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_Rec_Details)

            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            EditToolStripButton.Enabled = True
            ToolStripButton7.Enabled = False
            Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.ReadOnly = True
            ToolStripButton1.Enabled = True
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("No Record Saved " & ex.Message, "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.DataError

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        BindingNavigatorAddNewItem.Enabled = False
        ToolStripButton7.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.ReadOnly = False
        ToolStripButton1.Enabled = False

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        ToolStripButton7.Enabled = True
        Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.ReadOnly = False
        ToolStripButton1.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource.Position
        Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter.Fill(DSMedication.tbl_HRM_Emp_Medication_Rec_Details)
        Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        ToolStripButton7.Enabled = False
        EditToolStripButton.Enabled = True
        Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.ReadOnly = True
        ToolStripButton1.Enabled = True

    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        DeptNameTextBox.ReadOnly = False

        ToolStripButton9.Visible = True
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Dim postion As Integer = Tbl_HRM_Emp_Medication_Rec_HeadBindingSource.Position
        Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter.Fill(DSMedication.tbl_HRM_Emp_Medication_Rec_Head)
        Tbl_HRM_Emp_Medication_Rec_HeadBindingSource.Position = postion
        DeptNameTextBox.ReadOnly = True

        ToolStripButton9.Visible = False
    End Sub
End Class