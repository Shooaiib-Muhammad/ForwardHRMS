Public Class Newmaterial


    Private Sub Newmaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Medication_Pharmacy' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Medication_PharmacyTableAdapter.FillBy(Me.DSMedication.tbl_HRM_Emp_Medication_Pharmacy)


        Me.Tbl_HRM_Emp_Med_ItemTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Med_Item_Head' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Med_Item_HeadTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item_Head)

    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Try
            Me.Validate()
            Me.Tbl_HRM_Emp_Med_Item_HeadBindingSource.EndEdit()
            Me.Tbl_HRM_Emp_Med_Item_HeadTableAdapter.Update(Me.DSMedication.tbl_HRM_Emp_Med_Item_Head)
            Me.Tbl_HRM_Emp_Med_Item_HeadTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item_Head)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_HRM_Emp_Med_ItemDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_Emp_Med_ItemDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_HRM_Emp_Med_ItemDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_Emp_Med_ItemDataGridView.DataError

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try

            Me.Validate()
            Me.Tbl_HRM_Emp_Med_ItemBindingSource.EndEdit()
            Me.Tbl_HRM_Emp_Med_ItemTableAdapter.Update(Me.DSMedication.tbl_HRM_Emp_Med_Item)
            Me.Tbl_HRM_Emp_Med_ItemTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item)
            ToolStripButton7.Enabled = False
            CancelToolStripButton.Visible = False
            Tbl_HRM_Emp_Med_ItemDataGridView.ReadOnly = True
            ToolStripButton1.Enabled = True
            EditToolStripButton.Enabled = True
            MsgBox("Record Saved Successfully")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        ToolStripButton7.Enabled = True
        EditToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_Emp_Med_ItemDataGridView.ReadOnly = False
        ToolStripButton1.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_HRM_Emp_Med_ItemDataGridView.ReadOnly = False
        EditToolStripButton.Enabled = False
        ToolStripButton1.Enabled = False
        ToolStripButton7.Enabled = True
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_Emp_Med_ItemBindingSource.Position
        Tbl_HRM_Emp_Med_ItemTableAdapter.Fill(DSMedication.tbl_HRM_Emp_Med_Item)
        Tbl_HRM_Emp_Med_ItemBindingSource.Position = postion
        Tbl_HRM_Emp_Med_ItemDataGridView.ReadOnly = True
        ToolStripButton1.Enabled = True
        CancelToolStripButton.Visible = False
        ToolStripButton7.Enabled = False
        EditToolStripButton.Enabled = True

    End Sub
End Class