Public Class frmUndoTermination1
    Private Sub Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Hrm_Emp_Info_HBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSet2)

    End Sub

    Private Sub frmUndoTermination1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.tbl_Acc_Termination_Transactions11' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_Termination_Transactions11TableAdapter.Fill(Me.DataSet2.tbl_Acc_Termination_Transactions11)
        'TODO: This line of code loads data into the 'DataSet2.tbl_Acc_Termination_Transactions' table. You can move, or remove it, as needed.
        'Me.Tbl_Acc_Termination_TransactionsTableAdapter.Fill(Me.DataSet2.tbl_Acc_Termination_Transactions)
        'TODO: This line of code loads data into the 'DataSet2.tbl_Hrm_Emp_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DataSet2.tbl_Hrm_Emp_Info)
        'TODO: This line of code loads data into the 'DataSet2.tbl_Hrm_Emp_Info_H' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_Emp_Info_HTableAdapter.Fill(Me.DataSet2.tbl_Hrm_Emp_Info_H)

    End Sub
End Class