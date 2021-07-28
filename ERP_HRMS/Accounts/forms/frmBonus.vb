Public Class frmBonus
    Private Sub frmBonus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_Hrm_EmploymentTypeTableAdapter.Fill(Me.DSBonus.tbl_Hrm_EmploymentType)
        Try
            Me.Tbl_Hrm_Emp_Info_H1TableAdapter.Fill(Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H1)
        Catch ex As Exception
        End Try

        Me.Tbl_Acc_BonusNoSettingsTableAdapter.FillBy(Me.DSBonus.tbl_Acc_BonusNoSettings)
        'FillBonusTransactions()
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSBonus.tbl_Acc_FinancialPeriod)
        'Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSBonus.View_Rpt_Acc_AllEmployees)
    End Sub
    Dim Count As Integer

    Private Sub FillBonusNo()
        If FinancialPeriodComboBox.SelectedValue <> Nothing Then
            Count = Me.Tbl_Acc_BonusNoSettingsTableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusNoSettings, FinancialPeriodComboBox.SelectedValue)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim EmpID As Integer
        Dim JoiningDate As Date
        Dim NoOfMonths As Integer = 0
        Dim FP As String
        Dim BNo As Integer
        Dim CardNo As Integer
        Dim CalBonus As Boolean = False
        'Bonus is given on the basis of joining date
        If ActivationStatusCheckBox.CheckState = CheckState.Unchecked Then
            ToolStripProgressBar2.Maximum = Me.View_Rpt_Acc_PreSalaryTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary) + 1
            'MsgBox(Me.View_Rpt_Acc_PreSalaryBindingSource.Count)
            If FinancialPeriodLabel2.Text <> "" Or BonusNoLabel2.Text <> "" Then
                Dim dgResult As DialogResult = MessageBox.Show("Are you sure," & vbCrLf & "You want to Calculate bonus transactions of Bonus No = " & BonusNoLabel2.Text & " for Financial Period = " & FinancialPeriodLabel2.Text & " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If dgResult = 6 Then
                    FP = FinancialPeriodLabel2.Text.Trim
                    BNo = Val(BonusNoLabel2.Text)
                    'Loop up to navigate through all emoloyees for bonus calculation
                    For i As Integer = 0 To Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary.Rows.Count - 1
                        NoOfMonths = 0
                        ToolStripProgressBar2.Value += 1
                        'If Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(i).Item(14) = EmploymentTypeComboBox.SelectedValue Then     'For ETID =1 which is for Employees only
                        EmpID = Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(i).Item(4)
                        JoiningDate = Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(i).Item("DateOfJoining")
                        CardNo = Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(i).Item(3)
                        'If BNo = 1 Then
                        '    If Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(i).Item("Bonus1") = True Then
                        '        CalBonus = True
                        '    Else
                        CalBonus = True
                        '    End If
                        'ElseIf BNo = 2 Then
                        '    If Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(i).Item("Bonus2") = True Then
                        '        CalBonus = True
                        '    Else
                        '        CalBonus = False
                        '    End If
                        'End If
                        If CalBonus = True Then
                            If Me.View_Rpt_Acc_EmpList4BonusTransactionsTableAdapter.Fill(Me.DSBonus.View_Rpt_Acc_EmpList4BonusTransactions, EmpID, FP) = 1 Then
                                If JoiningDate < CType("01/07/" + FP.Substring(3, 4), Date) Then
                                    NoOfMonths = 365
                                Else
                                    If JoiningDate.Month = 4 Or JoiningDate.Month = 5 Or JoiningDate.Month = 6 Then
                                        'Those employees will be skipped whose joining date in any of the months of April, May, June.
                                    ElseIf JoiningDate.Month = 1 Or JoiningDate.Month = 2 Or JoiningDate.Month = 3 Then
                                        'Those employees whose joining date in any of the months of January, Feburary, March. In these months year of Second part of the financial period will be used e.g in Jul2009-Jun2010, 2010 will be used as datedifference
                                        'If JoiningDate.Day >= 1 And JoiningDate.Day <= 15 Then
                                        '    NoOfMonths = DateDiff(DateInterval.Month, CType(JoiningDate.Day & "/" & JoiningDate.Month & "/" & FinancialPeriodLabel2.Text.Substring(11, 4), Date), CType("30/06/" + FinancialPeriodLabel2.Text.Substring(11, 4), Date)) + 1
                                        'Else
                                        '    NoOfMonths = DateDiff(DateInterval.Month, CType(JoiningDate.Day & "/" & JoiningDate.Month & "/" & FinancialPeriodLabel2.Text.Substring(11, 4), Date), CType("30/06/" + FinancialPeriodLabel2.Text.Substring(11, 4), Date))
                                        'End If
                                        NoOfMonths = DateDiff(DateInterval.Day, CType(JoiningDate.Day & "/" & JoiningDate.Month & "/" & FinancialPeriodLabel2.Text.Substring(11, 4), Date), CType("30/06/" + FinancialPeriodLabel2.Text.Substring(11, 4), Date)) + 1
                                    Else
                                        'If JoiningDate.Day >= 1 And JoiningDate.Day <= 15 Then
                                        '    NoOfMonths = DateDiff(DateInterval.Month, CType(JoiningDate.Day & "/" & JoiningDate.Month & "/" & FinancialPeriodLabel2.Text.Substring(3, 4), Date), CType("30/06/" + FinancialPeriodLabel2.Text.Substring(11, 4), Date)) + 1
                                        'Else
                                        '    NoOfMonths = DateDiff(DateInterval.Month, CType(JoiningDate.Day & "/" & JoiningDate.Month & "/" & FinancialPeriodLabel2.Text.Substring(3, 4), Date), CType("30/06/" + FinancialPeriodLabel2.Text.Substring(11, 4), Date))
                                        'End If
                                        NoOfMonths = DateDiff(DateInterval.Day, CType(JoiningDate.Day & "/" & JoiningDate.Month & "/" & FinancialPeriodLabel2.Text.Substring(3, 4), Date), CType("30/06/" + FinancialPeriodLabel2.Text.Substring(11, 4), Date)) + 1
                                        'If NoOfMonths >= 9 Then
                                        '    NoOfMonths = 12
                                        'End If
                                    End If
                                End If
                                If NoOfMonths > 0 Then
                                    CalculateBonus(NoOfMonths, Me.DSBonus.View_Rpt_Acc_EmpList4BonusTransactions(0).Item(4), FP, BNo, EmpID, Me.HRMDBDataSet1.View_Rpt_Acc_PreSalary(i).Item("PaymentMode"), 0)
                                End If
                            End If
                        End If

                        'End If
                    Next
                    ToolStripProgressBar2.Value = 0
                    Me.Tbl_Acc_BonusNoSettingsTableAdapter.SetStatusFalse(FinancialPeriodLabel2.Text, BonusNoLabel2.Text)
                    MsgBox("Record Saved Successfully...")
                    FillBonusTransactions()
                    Me.Tbl_Acc_BonusNoSettings2TableAdapter1.Fill(DSBonus.tbl_Acc_BonusNoSettings2)
                End If
            End If
        Else
            MsgBox("Transactions already been saved")
        End If

    End Sub
    Private Sub CalculateBonus(ByVal NoOfMonths As Integer, ByVal Salary As Integer, ByVal FP As String, ByVal BNo As Integer, ByVal EID As Integer, ByVal PayMode As String, ByVal Advance As Integer)

        'This function calculates bonus amount due for pay
        Dim BonusAmt As Integer
        'Dim IPAddress As String = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        If Me.Tbl_Acc_BonusTransactionsTableAdapter.FillBy(Me.DSBonus.tbl_Acc_BonusTransactions, FP, BNo, EID) = 0 Then
            BonusAmt = (((Salary * Val(PercentOfSalaryLabel1.Text)) / 100) / 365) * NoOfMonths
            Dim BonusAdv As Integer
            Try
                BonusAdv = Me.Tbl_Acc_BonusTransactionsTableAdapter.BonusPAdv(EID, FP, BNo)
            Catch ex As Exception
                BonusAdv = 0
            End Try
            If BonusAdv > BonusAmt Then
                BonusAdv = BonusAmt
            Else

            End If
            Me.Tbl_Acc_BonusTransactionsTableAdapter.Insert(FP, BNo, EID, BonusAmt, False, Now.Date, NoOfMonths, Salary, Val(PercentOfSalaryLabel1.Text), ((Salary * Val(PercentOfSalaryLabel1.Text)) / 100), PayMode, BonusAdv)
            If BonusAdv > 0 Then
                Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(EID, BonusAdv, Now.Date, "Deduction from Bonus No." & Me.BonusNoLabel2.Text & "", FP)
            End If
        End If

    End Sub
    Private Sub FinancialPeriodComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancialPeriodComboBox.SelectedIndexChanged
        FillBonusNo()
    End Sub

    Private Sub Tbl_Acc_BonusNoSettingsDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Acc_BonusNoSettingsDataGridView.DataError

    End Sub
    Private Sub ClearLabels()
        CardNoLabel1.Text = ""
        NameLabel1.Text = ""
        DesigNameLabel1.Text = ""
        DeptNameLabel1.Text = ""
        EmpStatusCheckBox.CheckState = CheckState.Indeterminate
    End Sub
    Private Sub FillBonusTransactions()
        Try
            If Me.Tbl_Acc_BonusTransactionsTableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusTransactions, FinancialPeriodLabel2.Text, Val(BonusNoLabel2.Text)) > 0 Then

            Else
                'Me.Tbl_Acc_BonusNoSettings2TableAdapter1.Fill(DSBonus.tbl_Acc_BonusNoSettings2)
                Me.Tbl_Acc_BonusTransactionsTableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusTransactions, Me.DSBonus.tbl_Acc_BonusNoSettings2.Rows(0).Item("FinancialPeriod"), Me.DSBonus.tbl_Acc_BonusNoSettings2.Rows(0).Item("BonusNo"))

                ClearLabels()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BonusNo As Integer
        Dim DgResult As DialogResult
        If Count = 0 Then
            BonusNo = 1
        Else
            Dim Temp = Me.DSBonus.tbl_Acc_BonusNoSettings(Count - 1).Item(1)
            BonusNo = Temp + 1
        End If
        DgResult = MessageBox.Show("Are you sure you want to define Bonus No = " & BonusNo & " for the Financial period = " & FinancialPeriodComboBox.SelectedValue & " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If DgResult = 6 Then
            Me.Tbl_Acc_BonusNoSettingsTableAdapter.Insert(FinancialPeriodComboBox.SelectedValue, BonusNo, Now.ToShortDateString(), False, Me.ComboBox1.Text)
            'note: ActivationStatus should be true if Bonus is Active for 'Transaction Calculations and Distribution' Status Should be True if it is Distributed Fully otherwise False;
            MsgBox("Record Saved")
            FillBonusNo()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TabControl1.SelectedTab = TabPage1

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TabControl1.SelectedTab = TabPage2

    End Sub



    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub LinkLabel1_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel2_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel2.MouseEnter
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel2_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel2.MouseLeave
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub Tbl_Acc_BonusNoSettings2BindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Acc_BonusNoSettings2BindingSource.PositionChanged
        FillBonusTransactions()
        If Me.Tbl_Acc_BonusTransactionsBindingSource.Count = 0 Then
            Try
                Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, 0)
            Catch ex As Exception

            End Try
        End If
    End Sub
    Dim DgResult As DialogResult
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DgResult = MessageBox.Show("Are you sure want to Pay Selected Bonus?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dgResult = 6 Then
            'For k As Int16 = 0 To Me.Tbl_Acc_BonusTransactionsDataGridView.RowCount - 1
            '    Me.Tbl_Acc_BonusTransactionsDataGridView(9, k).Value = True
            'Next
            Me.Tbl_Acc_BonusTransactionsTableAdapter.UpdateQuery(FinancialPeriodLabel2.Text, Val(BonusNoLabel2.Text))
            Try
                Me.Tbl_Acc_BonusTransactionsTableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusTransactions, FinancialPeriodLabel2.Text, Val(BonusNoLabel2.Text))
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub SaveToolStripButton1_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton1.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Acc_BonusTransactionsBindingSource.EndEdit()
            Me.Tbl_Acc_BonusTransactionsTableAdapter.Update(Me.DSBonus.tbl_Acc_BonusTransactions)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedTab.Text = "Define Bonus" Then

        ElseIf Me.TabControl1.SelectedTab.Text = "Bonus Transactions" Then
            Me.Tbl_Acc_BonusNoSettings2TableAdapter1.Fill(DSBonus.tbl_Acc_BonusNoSettings2)
            Me.Tbl_Acc_BonusNoSettings2BindingSource.MoveLast()
            FillBonusTransactions()
        End If

    End Sub

    Private Sub Tbl_Acc_BonusTransactionsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_BonusTransactionsDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Acc_BonusTransactionsDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_BonusTransactionsDataGridView.RowEnter
        Try
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, Tbl_Acc_BonusTransactionsDataGridView(0, e.RowIndex).Value)
        Catch ex As Exception

        End Try
    End Sub
End Class