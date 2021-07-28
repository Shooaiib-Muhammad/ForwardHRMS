Public Class frmTraingHead
    Private Sub Tbl_EMS_Traing_HeadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_EMS_Traing_HeadBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_EMS_Traing_HeadBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSEMS)
            MsgBox("Record has been Saved!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmTraingHead_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSEMS.tbl_EMS_Traing_Head' table. You can move, or remove it, as needed.
        Me.Tbl_EMS_Traing_HeadTableAdapter.Fill(Me.DSEMS.tbl_EMS_Traing_Head)

    End Sub

    Private Sub Tbl_EMS_Traing_HeadDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_EMS_Traing_HeadDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_EMS_Traing_HeadDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_EMS_Traing_HeadDataGridView.DataError

    End Sub
End Class