Public Class frmUndoTermination

    Private Sub frmUndoTermination_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.tbl_Acc_Termination_Transactions11' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_Termination_Transactions11TableAdapter.Fill(Me.DataSet1.tbl_Acc_Termination_Transactions11)
        RefreshNow()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim TerminationDate As Date
        Dim DialogRes As DialogResult
        'If TerminationDateMaskedTextBox.Text <> "  /  /" Then
        'TerminationDate = CType(TerminationDateMaskedTextBox.Text, Date)
        If PaymentStatusCheckBox.CheckState = CheckState.Checked Then
            MsgBox("Sorry, Undo fail because Payments have been made to this Employee (Paid Unpaid Status is checked)")
        Else
            DialogRes = MessageBox.Show("Are you Sure you want To Undo Termination for selected employee", "Undo Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DialogRes = 6 Then
                Dim TermID As Int16 = Val(Me.TermIDLabel.Text)
                Dim UndoReason As String = InputBox("Enter Undo Reason")
                If UndoReason.Length > 0 Then
                    Try
                        Me.Tbl_Hrm_Emp_Info_HTableAdapter.SetCardStatus(CardNoComboBox.SelectedValue)
                        Me.Tbl_Hrm_Emp_InfoTableAdapter.SetEmpStatus(Val(EmpIDLabel1.Text))
                    Catch ex As Exception
                        MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
                        Exit Sub
                    End Try
                    Try
                        'Me.Tbl_ApprovingAthorityTableAdapter.UpdateStatus(True, True, Val(EmpIDLabel1.Text))
                    Catch ex As Exception
                        'MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
                        Exit Sub
                    End Try
                    Try
                        Me.Tbl_Acc_PAdvDeductionsTableAdapter.DeleteDedForTermination(Val(EmpIDLabel1.Text))
                    Catch ex As Exception
                        MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
                        Exit Sub
                    End Try
                    Try
                        UndoBonus(CType(TerminationDateMaskedTextBox.Text, Date))
                    Catch ex As Exception
                        MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
                        Exit Sub
                    End Try
                    Try
                        Me.Tbl_Acc_Salary_TransactionsTableAdapter.DeleteSalaryTrans(Val(EmpIDLabel1.Text))
                    Catch ex As Exception
                        MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
                        Exit Sub
                    End Try
                    Try
                        Me.Tbl_Acc_Termination_Transactions11TableAdapter.DeleteQuery(Val(EmpIDLabel1.Text))
                    Catch ex As Exception
                        MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
                        Exit Sub
                    End Try
                    Me.Tbl_Acc_Termination_Transactions11TableAdapter.UpdateQuery(UndoReason, TermID)
                    MsgBox("Termination Undo Successfully")
                    RefreshNow()
                Else
                    MsgBox("Enter Undo Reason To Continue")
                End If

            End If
        End If
        'Else
        'MsgBox("Termination Date is Missing, So Without Termination Date System Can't Undo Termiantion Transaction")
        'End If

        'Dim TerminationDate As Date
        'Dim DialogRes As DialogResult

        'If TerminationDateMaskedTextBox.Text <> "  /  /" Then
        '    TerminationDate = CType(TerminationDateMaskedTextBox.Text, Date)
        '    If PaymentStatusCheckBox.CheckState = CheckState.Checked Then
        '        MsgBox("Sorry, Undo fail because Payments have been made to this employee (Paid Unpaid Status is checked)")
        '    Else
        '        DialogRes = MessageBox.Show("Are you Sure you want to Undo Termination for selected employee", "Undo Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        '        If DialogRes = DialogResult.Yes Then
        '            Try
        '                Me.Tbl_Hrm_Emp_Info_HTableAdapter.SetCardStatus(CardNoComboBox.SelectedValue)
        '                Me.Tbl_Hrm_Emp_InfoTableAdapter.SetEmpStatus(Val(EmpIDLabel1.Text))
        '            Catch ex As Exception
        '                MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
        '                Exit Sub
        '            End Try
        '            Try
        '                Me.Tbl_ApprovingAthorityTableAdapter.UpdateStatus(True, True, Val(EmpIDLabel1.Text))
        '            Catch ex As Exception
        '                MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
        '                Exit Sub
        '            End Try
        '            Try
        '                Me.Tbl_Acc_PAdvDeductionsTableAdapter.DeleteDedForTermination(Val(EmpIDLabel1.Text), TerminationDate)
        '            Catch ex As Exception
        '                MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
        '                Exit Sub
        '            End Try
        '            Try
        '                UndoBonus(TerminationDate)
        '            Catch ex As Exception
        '                MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
        '                Exit Sub
        '            End Try
        '            Try
        '                Me.Tbl_Acc_Salary_TransactionsTableAdapter.DeleteSalaryTrans(Val(EmpIDLabel1.Text), TerminationDate)
        '            Catch ex As Exception
        '                MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
        '                Exit Sub
        '            End Try
        '            Try
        '                Me.Tbl_Acc_Termination_TransactionsTableAdapter.DeleteTerminationTrans(Val(EmpIDLabel1.Text), TerminationDate)
        '            Catch ex As Exception
        '                MsgBox("Exception Occurred; Please contact system administrator. Error Msg = " & ex.Message)
        '                Exit Sub
        '            End Try

        '            MsgBox("Termination Undo Successfully")
        '            RefreshNow()
        '        End If
        '    End If
        'Else
        '    MsgBox("Termination Date is Missing, So Without Termination Date System Can't Undo Termiantion Transaction")
        'End If

    End Sub

    Private Sub RefreshNow()
        'Me.Tbl_Acc_Termination_TransactionsTableAdapter.Fill(Me.DataSet1.tbl_Acc_Termination_Transactions)
        Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DataSet1.tbl_Hrm_Emp_Info)
        Me.Tbl_Hrm_Emp_Info_HTableAdapter.FillBy(Me.DataSet1.tbl_Hrm_Emp_Info_H)
    End Sub

    Private Sub Tbl_Hrm_Emp_Info_HBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_Emp_Info_HBindingSource.PositionChanged
        Me.Tbl_Hrm_Emp_InfoBindingSource.Position = Me.Tbl_Hrm_Emp_InfoBindingSource.Count
        If Me.Tbl_Hrm_Emp_InfoBindingSource.Count > 0 Then
            If Me.Tbl_Acc_Termination_Transactions11BindingSource.Count > 0 Then
                If PaymentStatusCheckBox.CheckState = CheckState.Checked Then
                    Button1.Enabled = False
                Else
                    Button1.Enabled = True
                End If
            Else
                Button1.Enabled = False
            End If
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub UndoBonus(ByVal TransactionDate As Date)
        Dim FP As String = ""
        Dim BonusNo As Integer = 0
        'If Me.Tbl_Acc_BonusDistributionTableAdapter.FillBy2(Me.DSBonus.tbl_Acc_BonusDistribution, Val(EmpIDLabel1.Text)) > 0 Then
        '    For loopcount As Integer = 0 To Me.DSBonus.tbl_Acc_BonusDistribution.Rows.Count - 1
        '        FP = Me.DSBonus.tbl_Acc_BonusDistribution(loopcount).Item(0)
        '        BonusNo = Me.DSBonus.tbl_Acc_BonusDistribution(loopcount).Item(1)
        '        If Me.Tbl_Acc_BonusTransactionsTableAdapter.FillBy3(Me.DSBonus.tbl_Acc_BonusTransactions, FP, BonusNo, Val(EmpIDLabel1.Text), TransactionDate) > 0 Then
        '            'Delete Bonus Transaction And Delete Distribution Transactions
        '            Me.Tbl_Acc_BonusDistributionTableAdapter.DeleteDistTrans4Undo(Val(EmpIDLabel1.Text))
        '            Me.Tbl_Acc_BonusTransactionsTableAdapter.DeleteTrans4Undo(FP, BonusNo, Val(EmpIDLabel1.Text), TransactionDate)
        '        Else
        '            'Update Bonus Transaction And Delete Distribution Transactions
        '            Me.Tbl_Acc_BonusDistributionTableAdapter.DeleteDistTrans4Undo(Val(EmpIDLabel1.Text))
        '            Me.Tbl_Acc_BonusTransactionsTableAdapter.UpdatePaidUnpaidStatus(False, FP, BonusNo, Val(EmpIDLabel1.Text))
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        RefreshNow()
    End Sub
End Class