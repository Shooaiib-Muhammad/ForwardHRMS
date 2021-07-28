Public Class FrmEmployeeSaveAs


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Me.Tbl_HRM_Emp_Info1TableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info1, CType(TextBox1.Text, Integer)) > 0 Then

            Else
                MsgBox("Employee  Status is Disable")

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class