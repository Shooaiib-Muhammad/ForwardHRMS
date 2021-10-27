Public Class frmAccAnnualLeaveTransactions

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DateOfPermanent As DateTime
        Dim Amt As Double
        Dim PayDays As Double
        Dim EmpID, GradeID As Integer
        Dim LTAReturns As Integer
        Dim DOJ, DOP As Date
        Dim LTABalance As Integer
        Dim DedRateAgainstLongLeaves As Integer
        Dim Verify2 As Integer
        Dim AnnualLeaves As Integer

        Dim IPAddress As String = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        ToolStripProgressBar1.Value = 0
        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You want to save Annual Leaves", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dgResult = 6 Then
            Me.View_Rpt_Acc_PreSalaryTableAdapter1.Fill(Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary, DateTimePicker1.Value.Month)
            ToolStripProgressBar1.Maximum = Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Count + 1
            For i As Integer = 0 To Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Count - 1
                Dim CardNo As Integer = Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary(i).Item(0)
                DOJ = Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("dateofjoining")
                DOP = Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("DateOfPermanent")
                GradeID = Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GradeID")

                If Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary(i).Item(0) <= 40000 Then
                    EmpID = Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("EmpID")
                    If Me.Tbl_PayRoll_LongLeaves1TableAdapter.SelectQuery2(EmpID, FinancialPeriodComboBox.SelectedValue) = 0 Then
                        Verify2 = Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.FillBy1(Me.DSAnnualLeavesTransactions.tbl_Acc_AnnualLeaveTransactions, Val(EmpID), FinancialPeriodComboBox.SelectedValue)
                        If Verify2 = 0 Then 'This condition will check, if Annual leave calculated in any month of the a financial period then no transaction will be saved again.
                            Dim Verify As Integer = Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.FillBy(Me.DSAnnualLeavesTransactions.tbl_Acc_AnnualLeaveTransactions, Val(EmpID), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
                            If Verify = 0 Then 'This condition will check, if Annual leave calculated in selected month of the a financial period then no transaction will be saved for that particular month again.
                                DateOfPermanent = Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("dateofjoining")
                                If DateTimePicker1.Value.Year > DateOfPermanent.Year Then
                                    'Dim Value As Integer = DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date)
                                    'If CardNo = 486 Then
                                    '    MsgBox("Yes")
                                    'End If
                                    If DateTimePicker1.Value.Month = DateOfPermanent.Month Then
                                        PayDays = 14
                                        Amt = Math.Round((Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary") / 26) * 14)
                                        'If GradeID <= 6 Then
                                        '    PayDays = 7
                                        '    Amt = Amt / 2
                                        'End If
                                        LTAReturns = Me.View_Rpt_Acc_PAdvLedgerTableAdapter.Fill(Me.DSLongTermAdv.View_Rpt_Acc_PAdvLedger, EmpID)
                                        If LTAReturns > 0 Then
                                            LTABalance = Me.DSLongTermAdv.View_Rpt_Acc_PAdvLedger.Rows(0).Item(4)
                                            If LTABalance > 0 Then
                                                Me.Tbl_Acc_PermanentAdvances2TableAdapter.Fill(Me.DSLongTermAdv.tbl_Acc_PermanentAdvances2, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year, EmpID)
                                                Try
                                                    DedRateAgainstLongLeaves = Me.DSLongTermAdv.tbl_Acc_PermanentAdvances2.Rows(0).Item(1)
                                                Catch ex As Exception
                                                    DedRateAgainstLongLeaves = 0
                                                End Try
                                                If DedRateAgainstLongLeaves > 0 Then
                                                    If DedRateAgainstLongLeaves <= LTABalance Then
                                                        If Amt > DedRateAgainstLongLeaves Then
                                                            'Deductable Amt = DedRateAgainstLongLeaves
                                                            Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(EmpID, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), Amt, DedRateAgainstLongLeaves, Nothing, True, False, Nothing, DOJ, DOP, PayDays, Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary"))
                                                            Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(EmpID, DedRateAgainstLongLeaves, DateTimePicker1.Value.Date, "Deduction From Annual Leaves", FinancialPeriodComboBox.SelectedValue)
                                                        Else
                                                            'Deductable Amt = Amt
                                                            Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(EmpID, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), Amt, Amt, Nothing, True, False, Nothing, DOJ, DOP, PayDays, Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary"))
                                                            Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(EmpID, Amt, DateTimePicker1.Value.Date, "Deduction From Annual Leaves", FinancialPeriodComboBox.SelectedValue)
                                                        End If
                                                    Else
                                                        'Deductable Amt = LTABalance
                                                        If Amt > LTABalance Then
                                                            'Deductable Amt = LTABalance
                                                            Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(EmpID, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), Amt, LTABalance, Nothing, True, False, Nothing, DOJ, DOP, PayDays, Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary"))
                                                            Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(EmpID, LTABalance, DateTimePicker1.Value.Date, "Deduction From Annual Leaves", FinancialPeriodComboBox.SelectedValue)
                                                        Else
                                                            'Deductable Amt = Amt
                                                            Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(EmpID, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), Amt, Amt, Nothing, True, False, Nothing, DOJ, DOP, PayDays, Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary"))
                                                            Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(EmpID, Amt, DateTimePicker1.Value.Date, "Deduction From Annual Leaves", FinancialPeriodComboBox.SelectedValue)
                                                        End If
                                                    End If
                                                Else
                                                    Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(EmpID, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), Amt, Nothing, Nothing, True, False, Nothing, DOJ, DOP, PayDays, Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary"))
                                                End If
                                            Else
                                                Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(EmpID, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), Amt, Nothing, Nothing, True, False, Nothing, DOJ, DOP, PayDays, Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary"))
                                            End If
                                        Else
                                            Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(EmpID, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), Amt, Nothing, Nothing, True, False, Nothing, DOJ, DOP, PayDays, Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary"))
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    Else
                        PayDays = 14
                        Amt = Math.Round((Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary") / 26) * 14)
                        If GradeID <= 6 Then
                            PayDays = 7
                            Amt = Amt / 2
                        End If
                        Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(EmpID, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), Amt, Nothing, Nothing, False, False, Nothing, DOJ, DOP, PayDays, Me.DSAnnualLeavesTransactions.View_Rpt_Acc_PreSalary.Rows(i).Item("GrossSalary"))
                    End If
                End If
                ToolStripProgressBar1.Value += 1
            Next
            MsgBox("Record Successfully Saved")
            ReturnCount()
            ToolStripProgressBar1.Value = 0
        End If

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.Validate()
            Me.Tbl_Acc_AnnualLeaveTransactionsBindingSource.EndEdit()
            Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Update(Me.DSAnnualLeavesTransactions.tbl_Acc_AnnualLeaveTransactions)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmAccAnnualLeaveTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadAll()
        ReturnCount()
        Dim dt As Date = Now.Date
        dt = dt.Subtract(New TimeSpan(dt.Day - 1, 0, 0, 0))
        DateTimePicker1.Value = dt
        ReturnCount()
        'Dim AnualLeaves As Boolean



    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        SelectFP()
        ReturnCount()
        Try
            Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        Catch ex As Exception
        End Try
        If AnnualLeavesCheckBox.Checked = True Then

            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub ReturnCount()
        Dim Count As Integer
        Count = Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Fill(Me.DSAnnualLeavesTransactions.tbl_Acc_AnnualLeaveTransactions, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        If Count = 0 Then
            CardNoLabel1.Text = ""
            NameLabel1.Text = ""
            DesigNameLabel1.Text = ""
            DeptNameLabel1.Text = ""
            Label9.Text = ""
            Label14.Text = ""
            EmpStatusCheckBox.CheckState = CheckState.Indeterminate

        End If

    End Sub

    Private Sub Tbl_Acc_AnnualLeaveTransactionsDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Acc_AnnualLeaveTransactionsDataGridView.DataError

    End Sub
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function
    Public Function GetLastDayOfMonth(intMonth, intYear) As Date
        GetLastDayOfMonth = DateSerial(intYear, intMonth + 1, 0)
    End Function

    Private Sub Tbl_Acc_AnnualLeaveTransactionsDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_AnnualLeaveTransactionsDataGridView.CellContentClick
        Dim myDate As Date = FirstDayOfMonth(CDate(Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(3, e.RowIndex).Value))
        Dim TillDate As Date = myDate.AddMonths(4)
        TillDate = GetLastDayOfMonth(TillDate.Month, TillDate.Year)
        'MsgBox(TillDate)
        Dim dgResult As DialogResult
        If e.ColumnIndex = 7 Then
            If Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(6, e.RowIndex).Value = True Then
                If Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(7, e.RowIndex).Value = True
                    If Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                        Try
                            Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(5, e.RowIndex).Value = Now.Date
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                ElseIf Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(7, e.RowIndex).Value = False Then
                    Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(7, e.RowIndex).Value = True
                    If Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                        Try
                            Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(5, e.RowIndex).Value = Now.Date
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    End If
                Else
                    MsgBox("Once Checked, it is not allowed to Uncheck Again")
                End If
            Else
                MsgBox("Check to Pay Status was off, so you can't check this status")
            End If
        ElseIf e.ColumnIndex = 6 Then
            If Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(7, e.RowIndex).Value = False Then
                If Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(6, e.RowIndex).Value = True Then
                    dgResult = MessageBox.Show("Are You Sure! You are not interested to pay against annual leaves?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If dgResult = 6 Then
                        Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(6, e.RowIndex).Value = False
                        Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(8, e.RowIndex).Value = DBNull.Value
                        Me.Tbl_Acc_PAdvDeductionsTableAdapter.DeleteForLongLeaves(Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(1, e.RowIndex).Value, Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(3, e.RowIndex).Value, "Deduction From Annual Leaves")
                    End If
                ElseIf Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(6, e.RowIndex).Value = False Then
                    If Me.Tbl_PayRoll_LongLeaves1TableAdapter.SelectedQuery(Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(1, e.RowIndex).Value, myDate, TillDate) = 0 Then
                        Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(6, e.RowIndex).Value = True
                    Else
                        MsgBox("This Employee has Got Annual Leaves,Its Imposible To Pay ", MsgBoxStyle.Critical)
                    End If
                End If
            Else
                MsgBox("Record Lockded, it is not allowed to Uncheck Again")
            End If

        End If

    End Sub
    Sub LoadAll()
        'Me.View_Rpt_Acc_PreSalaryTableAdapter2.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary)


        Try
            Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        Catch ex As Exception
        End Try
        If AnnualLeavesCheckBox.Checked = True Then

            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
        Try
            Me.Tbl_Hrm_Emp_Info_H1TableAdapter.Fill(Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H1)
        Catch ex As Exception
        End Try
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSAnnualLeavesTransactions.tbl_Acc_FinancialPeriod)



    End Sub
    Private Sub Tbl_Acc_AnnualLeaveTransactionsDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_AnnualLeaveTransactionsDataGridView.RowEnter
        If Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, Val(Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(1, e.RowIndex).Value))
        End If
    End Sub

    Private Sub FinancialPeriodComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancialPeriodComboBox.SelectedIndexChanged
        Dim Obj As New UtilityClass()
        If FinancialPeriodComboBox.SelectedValue <> Nothing Then
            If FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) Then
            Else
                MsgBox("Invalid financial period as per selected annual leave month")
                FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            End If
        End If
    End Sub
    Dim dgResult As DialogResult
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim JoiningDate As Date
        Dim BasicSalary As Integer
        'Dim dgResult As DialogResult
        Dim Period As Integer
        Dim DueAmt As Integer

        Dim IPAddress As String = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        If Me.View_Rpt_Acc_PreSalaryTableAdapter2.FillBy(Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary, CardNoComboBox.SelectedValue) = 1 Then
            BasicSalary = Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(0).Item(5)
            JoiningDate = Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(0).Item(8)
        End If

        If Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.FillBy1(Me.DSAnnualLeavesTransactions.tbl_Acc_AnnualLeaveTransactions, CardNoComboBox.SelectedValue, FinancialPeriodComboBox.SelectedValue) = 0 Then
            If Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.FillBy(Me.DSAnnualLeavesTransactions.tbl_Acc_AnnualLeaveTransactions, CardNoComboBox.SelectedValue, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month) = 0 Then
                Period = DateDiff(DateInterval.Month, JoiningDate, DateTimePicker1.Value)
                DueAmt = (BasicSalary / 26) * 14
                Try
                    dgResult = MessageBox.Show("Are you sure about the action you are going to perform?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If dgResult = 6 Then
                        'NewMethod(Period, DueAmt)
                        MsgBox("Record Saved")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Record Already Saved for the Selected Financial Period and Month")
            End If
        Else
            MsgBox("Record Already Saved for the Selected Financial Period")
        End If
    End Sub

    'Private Sub NewMethod(Period As Integer, DueAmt As Integer)
    '    Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Insert(CardNoComboBox.SelectedValue, FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Date, DateDiff(DateInterval.Month, DateOfPermanent, DateTimePicker1.Value.Date), DueAmt, Nothing, Nothing, True, False, Nothing, DOJ, DOP)

    'End Sub

    Private Sub SelectFP()
        Dim Obj As New UtilityClass()
        If Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) <> Nothing Then
            FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        Else
            MsgBox("Selected year was beyond the running financial period")
            DateTimePicker1.Value = Now.Date
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_Acc_AnnualLeaveTransactionsBindingSource.EndEdit()
            Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.Update(Me.DSAnnualLeavesTransactions.tbl_Acc_AnnualLeaveTransactions)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tbl_Acc_AnnualLeaveTransactionsDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_AnnualLeaveTransactionsDataGridView.CellEnter
        If Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(7, e.RowIndex).Value = True Then

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dgResult = MessageBox.Show("Are you sure  Lock All Records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dgResult = 6 Then
            For k As Int16 = 0 To Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView.RowCount - 1
                Me.Tbl_Acc_AnnualLeaveTransactionsDataGridView(7, k).Value = True
            Next

        End If

    End Sub
End Class