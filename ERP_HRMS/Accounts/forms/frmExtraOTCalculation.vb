Imports System.Threading

Public Class frmExtraOTCalculation

    Private Sub frmExtraOTCalculation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Hrm_Emp_Info_H2TableAdapter.Fill(Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H2)
        Catch ex As Exception
        End Try
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.Fill(Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H1)
        FilterByDateRangeUnPaid()
        Button1.Enabled = False
        DateTimePicker1.Focus()
    End Sub

    Private Sub FilterByDateRangeAll()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.Fill(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByCardRangeAll()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByBothRangeAll()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy1(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByDateRangePaid()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy3(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByCardRangePaid()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy4(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByBothRangePaid()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy5(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByDateRangeUnPaid()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy6(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByCardRangeUnPaid()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy7(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByBothRangeUnPaid()
        If Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy8(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date, CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            CardNoComboBox.Enabled = False
            CardNoComboBox1.Enabled = False
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByDateRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByDateRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByDateRangeAll()
            End If
            DateTimePicker1.Focus()
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            CardNoComboBox.Enabled = True
            CardNoComboBox1.Enabled = True
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByCardRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByCardRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByCardRangeAll()
            End If
            CardNoComboBox1.Focus()
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True

            CardNoComboBox.Enabled = True
            CardNoComboBox1.Enabled = True
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByBothRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByBothRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByBothRangeAll()
            End If
            DateTimePicker1.Focus()
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If RadioButton1.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByDateRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByDateRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByDateRangeAll()
            End If
        ElseIf RadioButton3.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByBothRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByBothRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByBothRangeAll()
            End If
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If RadioButton1.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByDateRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByDateRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByDateRangeAll()
            End If
        ElseIf RadioButton3.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByBothRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByBothRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByBothRangeAll()
            End If
        End If

    End Sub

    Private Sub CardNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardNoComboBox.SelectedIndexChanged
        If RadioButton2.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByCardRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByCardRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByCardRangeAll()
            End If
        ElseIf RadioButton3.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByBothRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByBothRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByBothRangeAll()
            End If
        End If

    End Sub

    Private Sub CardNoComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardNoComboBox1.SelectedIndexChanged
        If RadioButton2.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByCardRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByCardRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByCardRangeAll()
            End If
        ElseIf RadioButton3.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByBothRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByBothRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByBothRangeAll()
            End If
        End If

    End Sub

    Private Sub Tbl_Acc_ExtraOverTime_TransactionsDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Acc_ExtraOverTime_TransactionsDataGridView.DataError

    End Sub

    Private Function ReturnBasicSal(ByVal MyEmpID As Integer) As Integer
        'This function returns Basic Salary of employee.
        Dim BasicSal As Integer
        If Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.DSCalculateSalary.tbl_Acc_Salary, MyEmpID) = 1 Then
            If DBNull.Value.Equals(Me.DSCalculateSalary.tbl_Acc_Salary(0).Item(2)) = False Then
                BasicSal = Me.DSCalculateSalary.tbl_Acc_Salary(0).Item(2)
            Else
                BasicSal = 0
            End If
        Else
            BasicSal = 0
        End If
        Return BasicSal
    End Function


    Private Sub CalculateAndInsert(ByVal MyEmp As Integer, ByVal MyFP As String, ByVal MyOTDate As Date, ByVal MyMinutes As Integer, ByVal SPStatus As Boolean, ByVal GradeId As Integer)
        'This function calculates OverTime and Insert to the ExtraOverTime_Transactions table
        Dim BasicSalary As Integer
        Dim PerHourSalary As Double
        Dim OTHours As Double
        Dim OTAmount As Double

        BasicSalary = ReturnBasicSal(MyEmp)
        PerHourSalary = Math.Round(BasicSalary / 26 / 8, 2)
        OTHours = RoundOTHours(MyMinutes)
        'If GradeId = 1 Or GradeId = 2 Or GradeId = 3 Or GradeId = 7 Then
        '    'OTAmount = ((OTHours * PerHourSalary))
        'Else
        OTAmount = ((OTHours * PerHourSalary) * 2)
        'End If
        If Me.Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.FillBy2(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions, MyEmp, MyOTDate) = 0 Then
            If BasicSalary > 0 Then
                If OTHours > 0 Then
                    Me.Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.Insert(MyEmp, BasicSalary, PerHourSalary, MyFP, MyOTDate, OTHours, OTAmount, Now.Date, Nothing, False, Nothing, Nothing, SPStatus, Nothing)
                End If
            End If
        End If
    End Sub

    Private Function RoundOTHours(ByVal OTMinutes As Double) As Double
        'Roung Over Time Minutes
        Dim OTHours As Double
        Dim i As Double
        Dim j As Double
        Dim Diff As Double

        i = Math.Truncate(OTMinutes / 60)
        j = OTMinutes / 60
        Diff = j - i
        Diff = (Math.Truncate(Diff * 100)) / 100
        If Diff >= 0 And Diff <= 0.41 Then
            OTHours = i
        ElseIf Diff > 0.41 And Diff <= 0.5 Then
            OTHours = i + 0.5
        ElseIf Diff > 0.5 And Diff <= 0.91 Then
            OTHours = i + 0.5
        ElseIf Diff > 0.91 And Diff <= 0.99 Then
            OTHours = i + 1
        Else
            OTHours = i
        End If
        Return OTHours

    End Function

    Private Sub EnableDisablePanels(ByVal Status As Boolean)
        Panel1.Enabled = Status
        Panel2.Enabled = Status
        GroupBox1.Enabled = Status
        Button1.Enabled = Status
        Button2.Enabled = Status
    End Sub

    Private Sub CalculateNow()
        'This funtion loop up all records available for OverTime Calculation
        Dim EmpID, GradeId As Integer
        Dim FP As String
        Dim OTDate As Date
        Dim Difference_Min As Integer

        EnableDisablePanels(False)
        If RadioButton4.Checked Then
            'Overtime Calculation more than 2 hours on Normal Days
            'This piece of code uses View_Rpt_Acc_ExtraOTCalculation to get overtime minutes
            Try
                Me.View_Rpt_Acc_ExtraOTCalculationTableAdapter.Fill(Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Catch ex As Exception
            End Try

            If Me.View_Rpt_Acc_ExtraOTCalculationBindingSource.Count > 0 Then
                ProgressBar1.Maximum = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation.Count + 1
                For i As Integer = 0 To Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation.Count - 1
                    If DBNull.Value.Equals(Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation(i).Item(0)) = False Then
                        EmpID = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation(i).Item(0)
                        FP = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation(i).Item(1)
                        'GradeId = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation(i).Item("GradeID")
                        GradeId = 10
                        OTDate = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation(i).Item(2)
                        Difference_Min = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalculation(i).Item(7)
                        CalculateAndInsert(EmpID, FP, OTDate, Difference_Min, False, GradeId)
                    End If
                    Thread.Sleep(50)
                    Application.DoEvents()
                    ProgressBar1.Value += 1
                Next
                ProgressBar1.Value = 0
            Else
                MsgBox("No record(s) found for due overtime to calculate between selected date range")
            End If
        ElseIf RadioButton5.Checked Then
            'Overtime Calculation Swap Days(Special Overtime on Sundays, Holidays etc)
            'This piece of code uses View_Rpt_Acc_ExtraOTCalcSpecial to get overtime minutes
            Try
                Me.View_Rpt_Acc_ExtraOTCalcSpecialTableAdapter.Fill(Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date)
            Catch ex As Exception

            End Try
            If Me.View_Rpt_Acc_ExtraOTCalcSpecialBindingSource.Count > 0 Then
                ProgressBar1.Maximum = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial.Count + 1
                For i As Integer = 0 To Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial.Count - 1
                    If DBNull.Value.Equals(Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial(i).Item(0)) = False Then
                        EmpID = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial(i).Item(0)
                        FP = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial(i).Item(1)
                        OTDate = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial(i).Item(2)
                        'GradeId = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial(i).Item("GradeID")
                        GradeId = 10
                        Difference_Min = Me.DSManageOverTime.View_Rpt_Acc_ExtraOTCalcSpecial(i).Item(6)
                        CalculateAndInsert(EmpID, FP, OTDate, Difference_Min, True, GradeId)
                    End If
                    Thread.Sleep(50)
                    Application.DoEvents()
                    ProgressBar1.Value += 1
                Next
                ProgressBar1.Value = 0
            Else
                MsgBox("No record found from attendance for Special Overtime b/w Selected date range")
            End If
        End If
        EnableDisablePanels(True)
        RadioButton6.Checked = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'This Button Click Alert the user about date check before calculation started, if satisfying then call function CalculateNow()
        Dim DgResult As DialogResult
        DgResult = MessageBox.Show("Are You Sure, You Want To Calculate Overtime", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If DgResult = 6 Then
            DgResult = MessageBox.Show("Are You Sure, You have Selected correct date range and correct OT option to save overtime", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If DgResult = 6 Then
                FilterByDateRangeUnPaid()
                If Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions.Count > 0 Then
                    DgResult = MessageBox.Show(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions.Count & " Records were found whose 'Paid/Unpaid Status' is unchecked between " & DateTimePicker1.Value.Date & " And " & DateTimePicker2.Value.Date & ". It means overtime payments are still pending to selected record." & vbCrLf & "If you want to calculate new records, then previous " & Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions.Count & " records will be mixed-up with new calculated records, so both records will be shown in payment reports." & vbCrLf & "Are You Sure, you want to save new records anyway?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If DgResult = 6 Then
                        CalculateNow()
                    End If
                Else
                    CalculateNow()
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'This button click check all the statuses of selected records, if over time have been paid to employees.
        Dim DgResult As DialogResult
        DgResult = MessageBox.Show("Are You Sure, You have paid overtime to Selected employees," & vbCrLf & "If you press 'Yes' then 'Paid If Payment Made' status will be checked for all selected records" & vbCrLf & " Remember Records will not be saved untill you will done it Manually", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DgResult = 6 Then
            For i As Integer = 0 To Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView.Rows.Count - 1
                Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(9, i).Value = True
                Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(6, i).Value = Now.Date
            Next
            DgResult = MessageBox.Show("Do you Want to save Changes," & vbCrLf & "If 'YES' then it will save changes Else you can save changes manually after further modifications in Status", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DgResult = 6 Then
                Try
                    Me.Validate()
                    Me.Tbl_Acc_ExtraOverTime_TransactionsBindingSource.EndEdit()
                    Me.Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.Update(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions)
                    MsgBox("Record Saved")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Tbl_Acc_ExtraOverTime_TransactionsDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_ExtraOverTime_TransactionsDataGridView.RowEnter
        If Tbl_Acc_ExtraOverTime_TransactionsDataGridView(0, e.RowIndex).Value IsNot DBNull.Value Then
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, Tbl_Acc_ExtraOverTime_TransactionsDataGridView(0, e.RowIndex).Value)
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub ClearLabels()
        CardNoLabel1.Text = ""
        NameLabel1.Text = ""
        DesigNameLabel1.Text = ""
        DeptNameLabel1.Text = ""
        EmpStatusCheckBox.CheckState = CheckState.Indeterminate
        PictureBox1.Image = Nothing

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        'Try
        '    Me.Validate()
        '    Me.Tbl_Acc_ExtraOverTime_TransactionsBindingSource.EndEdit()
        '    Me.Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.Update(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions)
        '    MsgBox("Record Saved")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Button1.Enabled = True
            Button2.Enabled = False

            RadioButton1.Checked = False
            RadioButton1.Checked = True

            CheckBox1.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            DateTimePicker1.Focus()
        End If

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Button1.Enabled = True
            Button2.Enabled = False

            RadioButton1.Checked = False
            RadioButton1.Checked = True

            CheckBox1.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Button1.Enabled = False
            Button2.Enabled = True

            CheckBox1.Enabled = True
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True

            RadioButton1.Checked = False
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub Tbl_Acc_ExtraOverTime_TransactionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_ExtraOverTime_TransactionsDataGridView.CellContentClick
        'This function is used to check or uncheck the Paid-Unpaid status manually
        If e.ColumnIndex = 9 Then
            If Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(9, e.RowIndex).Value = True Then
                Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(9, e.RowIndex).Value = False
                Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(6, e.RowIndex).Value = Nothing
            ElseIf Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(9, e.RowIndex).Value = False Then
                Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(9, e.RowIndex).Value = True
                Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(6, e.RowIndex).Value = Now.Date
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckStateChanged
        'This is just to filter records
        If RadioButton1.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByDateRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByDateRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByDateRangeAll()
            End If
            DateTimePicker1.Focus()
        ElseIf RadioButton2.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByCardRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByCardRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByCardRangeAll()
            End If
            CardNoComboBox1.Focus()
        ElseIf RadioButton3.Checked Then
            If CheckBox1.CheckState = CheckState.Checked Then
                FilterByBothRangePaid()
            ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
                FilterByBothRangeUnPaid()
            ElseIf CheckBox1.CheckState = CheckState.Indeterminate Then
                FilterByBothRangeAll()
            End If
            DateTimePicker1.Focus()
        End If
    End Sub
    Dim dgResult As DialogResult
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dgResult = MessageBox.Show("Are you sure  Lock Calculated Over Time Records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dgResult = 6 Then
            'For k As Int16 = 0 To Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView.RowCount - 1
            '    Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(9, k).Value = True
            '    Me.Tbl_Acc_ExtraOverTime_TransactionsDataGridView(10, k).Value = Now.Date
            Me.Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.UpdateQuery(Now.Date, DateTimePicker1.Text, Me.DateTimePicker2.Text)
            FilterByDateRangePaid()
            'Next
            MsgBox("Record Locked Successfully")
            'Try
            '    Me.Validate()
            '    Me.Tbl_Acc_ExtraOverTime_TransactionsBindingSource.EndEdit()
            '    Me.Tbl_Acc_ExtraOverTime_TransactionsTableAdapter.Update(Me.DSManageOverTime.tbl_Acc_ExtraOverTime_Transactions)
            '    MsgBox("Record Saved")
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try

        End If
    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub
End Class