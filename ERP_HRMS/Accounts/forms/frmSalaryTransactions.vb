Public Class frmSalaryTransactions

    Private Sub frmSalaryTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Hrm_Emp_Info1TableAdapter.Fill(Me.DSSalaryTrans.tbl_Hrm_Emp_Info1)
        Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DSSalaryTrans.tbl_Hrm_Emp_Info)
        Fill()




    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label2.Enabled = True
            DateTimePicker1.Enabled = True
            Label3.Enabled = True
            DateTimePicker2.Enabled = True

            Label6.Enabled = False
            Label7.Enabled = False
            CardNoComboBox.Enabled = False
            CardNoComboBox1.Enabled = False
            If DateTimePicker1.Value <= DateTimePicker2.Value Then
                Fill()
            End If

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label2.Enabled = True
            DateTimePicker1.Enabled = True
            Label3.Enabled = False
            DateTimePicker2.Enabled = False

            Label6.Enabled = True
            Label7.Enabled = True
            CardNoComboBox.Enabled = True
            CardNoComboBox1.Enabled = True
            FillBy()
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If RadioButton1.Checked Then
            If DateTimePicker1.Value <= DateTimePicker2.Value Then
                Fill()
            End If
        ElseIf RadioButton2.Checked Then
            FillBy()
        End If



    End Sub

    Private Sub CardNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardNoComboBox.SelectedIndexChanged
        If CardNoComboBox.SelectedIndex <= CardNoComboBox1.SelectedIndex Then
            If RadioButton1.Checked Then
                Fill()
            ElseIf RadioButton2.Checked Then
                FillBy()
            End If
        End If
    End Sub

    Private Sub CardNoComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardNoComboBox1.SelectedIndexChanged
        If CardNoComboBox.SelectedIndex <= CardNoComboBox1.SelectedIndex Then
            If RadioButton1.Checked Then
                Fill()
            ElseIf RadioButton2.Checked Then
                FillBy()
            End If
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        SaveRecord()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If RadioButton1.Checked Then
            If DateTimePicker1.Value <= DateTimePicker2.Value Then
                Fill()
            End If
        ElseIf RadioButton2.Checked Then
            FillBy()
        End If
    End Sub

    Private Sub Tbl_Acc_Salary_TransactionsDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Acc_Salary_TransactionsDataGridView.DataError

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'For i As Integer = 0 To Tbl_Acc_Salary_TransactionsDataGridView.RowCount - 1
        '    If Me.Tbl_Acc_Salary_TransactionsDataGridView(0, i).Value Is DBNull.Value Then
        '        Me.Tbl_Acc_Salary_TransactionsDataGridView(0, i).Value = True
        '        Me.Tbl_Acc_Salary_TransactionsDataGridView(1, i).Value = False
        '    Else
        '        If Me.Tbl_Acc_Salary_TransactionsDataGridView(0, i).Value = False Then
        '            Me.Tbl_Acc_Salary_TransactionsDataGridView(0, i).Value = True
        '            Me.Tbl_Acc_Salary_TransactionsDataGridView(1, i).Value = False
        '        End If
        '    End If
        'Next
        'SaveRecord()
        Dim DialogRes As DialogResult
        DialogRes = MessageBox.Show("Are You Sure Your Want To Checkecked and Saved", "Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DialogRes = 6 Then
            Me.Tbl_Acc_Salary_TransactionsTableAdapter.UpdateQuery(Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        End If

        Fill()

    End Sub

    Private Sub SaveRecord()
        Try
            Me.Validate()
            Me.Tbl_Acc_Salary_TransactionsBindingSource.EndEdit()
            Me.Tbl_Acc_Salary_TransactionsTableAdapter.Update(Me.DSSalaryTrans.tbl_Acc_Salary_Transactions)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Acc_Salary_TransactionsDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_Salary_TransactionsDataGridView.RowEnter
        If Tbl_Acc_Salary_TransactionsDataGridView(3, e.RowIndex).Value IsNot DBNull.Value Then
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, Val(Tbl_Acc_Salary_TransactionsDataGridView(3, e.RowIndex).Value))
        End If
    End Sub

    Private Sub Fill()
        If Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy3(Me.DSSalaryTrans.tbl_Acc_Salary_Transactions, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) > 0 Then
        Else
            ClearTextBox()
        End If


    End Sub

    Private Sub FillBy()
        If Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy(Me.DSSalaryTrans.tbl_Acc_Salary_Transactions, CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) > 0 Then
        Else
            ClearTextBox()
        End If


    End Sub

    Private Sub ClearTextBox()
        CardNoLabel1.Text = ""
        NameLabel1.Text = ""
        DeptNameLabel1.Text = ""
        DesigNameLabel1.Text = ""
        EmpStatusCheckBox.CheckState = CheckState.Indeterminate
    End Sub

    Private Sub Tbl_Acc_Salary_TransactionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_Salary_TransactionsDataGridView.CellContentClick
        If e.ColumnIndex = 0 Then
            If Me.Tbl_Acc_Salary_TransactionsDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Acc_Salary_TransactionsDataGridView(0, e.RowIndex).Value = True
                Me.Tbl_Acc_Salary_TransactionsDataGridView(1, e.RowIndex).Value = False
            Else
                If Me.Tbl_Acc_Salary_TransactionsDataGridView(0, e.RowIndex).Value = False Then
                    Me.Tbl_Acc_Salary_TransactionsDataGridView(0, e.RowIndex).Value = True
                    Me.Tbl_Acc_Salary_TransactionsDataGridView(1, e.RowIndex).Value = False
                End If
            End If
        End If
    End Sub


End Class