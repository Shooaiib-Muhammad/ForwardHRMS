Public Class Form1
    Private Sub Tbl_HRM_DeptBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_HRM_DeptBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_HRM_DeptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet7)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet7.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DataSet7.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DataSet7.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DataSet7.tbl_HRM_Dept)

    End Sub
End Class