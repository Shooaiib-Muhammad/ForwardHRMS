Public Class frmGrievanceCategory
    Private Sub Tbl_EAP_Grievance_Category_HeadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_EAP_Grievance_Category_HeadBindingNavigatorSaveItem.Click

        Try
            Me.ValidateChildren()
            Me.Tbl_EAP_Grievance_Category_HeadBindingSource.EndEdit()
            Me.Tbl_EAP_Grievance_Category_HeadTableAdapter.Update(Me.DSGrievance.tbl_EAP_Grievance_Category_Head)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmGrievanceCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSGrievance.tbl_EAP_Grievance_Category' table. You can move, or remove it, as needed.
        Me.Tbl_EAP_Grievance_CategoryTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance_Category)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_EAP_Grievance_Category_Head' table. You can move, or remove it, as needed.
        Me.Tbl_EAP_Grievance_Category_HeadTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance_Category_Head)

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_EAP_Grievance_CategoryBindingSource.EndEdit()
            Me.Tbl_EAP_Grievance_CategoryTableAdapter.Update(Me.DSGrievance.tbl_EAP_Grievance_Category)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_EAP_Grievance_CategoryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_EAP_Grievance_CategoryDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_EAP_Grievance_CategoryDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_EAP_Grievance_CategoryDataGridView.DataError

    End Sub
End Class