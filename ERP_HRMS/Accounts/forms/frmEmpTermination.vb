
Imports System.Data
Imports System.Data.Odbc

Public Class frmEmpTermination
    Dim intAbsentees As Double
    Dim intWorkingDays As Double
    Dim Count As Integer

    Dim FPYear As String = Nothing
    Private Sub LoadRecords()
        Try
            Me.View_Rpt_Acc_OverTimeSumTableAdapter.Fill(Me.DSEmpTermination.View_Rpt_Acc_OverTimeSum, Val(CardNoLabel2.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.View_Rpt_Acc_TAdvSumTableAdapter.Fill(Me.DSEmpTermination.View_Rpt_Acc_TAdvSum, Val(EmpIDLabel1.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.DataTable1TableAdapter.Fill(Me.DSEmpTermination.DataTable1, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, DateTimePicker1.Value.Day)
            Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter.Fill(Me.DSEmpTermination.View_Rpt_PayRoll_EmpAttRecord, Val(CardNoLabel2.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.View_Rpt_PayRoll_EmpAttRecord1TableAdapter.Fill(Me.DSEmpTermination.View_Rpt_PayRoll_EmpAttRecord1, Val(CardNoLabel2.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.Tbl_Acc_PAdvDeductions1TableAdapter.Fill(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions1, Val(EmpIDLabel1.Text))
            Me.Tbl_Acc_PermanentAdvances1TableAdapter.Fill(Me.DSLongTermAdv.tbl_Acc_PermanentAdvances1, Val(EmpIDLabel1.Text))
            Me.Tbl_PayRoll_LongLeavesTableAdapter.FillBy(Me.DSEmpTermination.tbl_PayRoll_LongLeaves, Val(EmpIDLabel1.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.Tbl_PayRoll_LongLeaves1TableAdapter.Fill(Me.DSEmpTermination.tbl_PayRoll_LongLeaves1, Val(EmpIDLabel1.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.Tbl_PayRoll_LongLeaves2TableAdapter.Fill(Me.DSEmpTermination.tbl_PayRoll_LongLeaves2, Val(EmpIDLabel1.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.Tbl_PayRoll_LongLeaves3TableAdapter.Fill(Me.DSEmpTermination.tbl_PayRoll_LongLeaves3, Val(EmpIDLabel1.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.Tbl_PayRoll_LongLeaves4TableAdapter.Fill(Me.DSEmpTermination.tbl_PayRoll_LongLeaves4, Val(EmpIDLabel1.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.Tbl_PayRoll_LongLeaves5TableAdapter.Fill(Me.DSEmpTermination.tbl_PayRoll_LongLeaves5, Val(EmpIDLabel1.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Try
                Me.View_Emp_Deduction_DaysTableAdapter.Fill(Me.DSEmpTermination.View_Emp_Deduction_Days, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, Val(EmpIDLabel1.Text))
            Catch ex As System.Exception
                'System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            Try
                Me.View_Acc_FairShopTableAdapter.Fill(Me.DSEmpTermination.View_Acc_FairShop, Val(EmpIDLabel1.Text), Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As System.Exception
                'System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception

        End Try
        Try
            Me.Tbl_Acc_RFD_PayTableAdapter.Fill(Me.DSEmpTermination.tbl_Acc_RFD_Pay, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year, Me.EmpIDLabel1.Text)
        Catch ex As System.Exception

        End Try

        FPYear = obj.ReturnFP(Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Try
            Me.Tbl_Acc_BonusTransactionsTableAdapter1.Fill(Me.DSEmpTermination.tbl_Acc_BonusTransactions, FPYear, Val(EmpIDLabel1.Text))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        'AccessLeaves()
        AnnualLeaves()
        If RadioButton9.Checked Then
            DisplayBonus(1)
        ElseIf RadioButton8.Checked Then
            DisplayBonus(1.5)
        ElseIf RadioButton4.Checked Then
            DisplayBonus(2)
        End If
        Dim MyMonth As Integer = DateTimePicker1.Value.Month
        Dim MyYear As Integer = DateTimePicker1.Value.Year
        If MyMonth = 1 Then
            MyMonth = 12
            MyYear -= 1
        Else
            MyMonth -= 1
        End If
        Try
            Me.View_Emp_Meal_AttendanceTableAdapter.Fill(Me.DSEmpTermination.View_Emp_Meal_Attendance, Val(EmpIDLabel1.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.Tbl_Acc_Salary_Transactions1TableAdapter.Fill(Me.DSEmpTermination.tbl_Acc_Salary_Transactions1, Val(EmpIDLabel1.Text), MyMonth, MyYear)
        RadioButton3.Checked = True
        Calculations()

    End Sub
    Dim obj As New UtilityClass
    Private Sub SaveBonus()
        Dim PercentOfSalary As Integer = 0
        Dim FP As String = Nothing
        Dim BonusNo As Integer = 0
        Dim MaxDistributionNo As Integer = 0
        Dim RemainingDistributionAmt As Integer = 0
        Dim PercentDistributedSum As Integer = 0
        Dim GrossPayableBonusAmt As Integer = 0
        Dim NoOfMonths As Integer = 0
        Dim BonusDueAmt As Integer = 0
        Dim IPAddress As String = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        Dim EmpID As Integer = 0
        'Dim Obj As New UtilityClass()

        'If ETIDLabel1.Text = "" Or JTIDLabel1.Text = "" Then
        'Else
        '    If ETIDLabel1.Text = 1 And JTIDLabel1.Text = 5 Then
        '    Else
        '        If Val(Me.Label53.Text) > 0 Then
        '            'This part of code demonstrate the distribution of bonus for previous FP (If Due Any) on termination of the employee
        'If Me.Tbl_Acc_BonusTransactionsTableAdapter.FillBy2(Me.DSBonus.tbl_Acc_BonusTransactions, Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year - 1), CardNoComboBox.SelectedValue) > 0 Then
        '    For i As Integer = 0 To Me.DSBonus.tbl_Acc_BonusTransactions.Rows.Count - 1
        '        PercentDistributedSum = 0
        '        MaxDistributionNo = 0
        '        FP = Me.DSBonus.tbl_Acc_BonusTransactions(i).Item(0)
        '        BonusNo = Me.DSBonus.tbl_Acc_BonusTransactions(i).Item(1)
        '        EmpID = Me.DSBonus.tbl_Acc_BonusTransactions(i).Item(2)
        '        If Me.Tbl_Acc_BonusDistributionTableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusDistribution, FP, BonusNo, EmpID) > 0 Then
        '            For j As Integer = 0 To Me.DSBonus.tbl_Acc_BonusDistribution.Rows.Count - 1
        '                PercentDistributedSum += Me.DSBonus.tbl_Acc_BonusDistribution(j).Item(4)
        '                MaxDistributionNo = Me.DSBonus.tbl_Acc_BonusDistribution(j).Item(3)
        '            Next
        '            If 100 - PercentDistributedSum > 0 Then
        '                'insert remaining distribution with description "Closing" and check paid unpaid status in Bonus transactions
        '                RemainingDistributionAmt = (Me.DSBonus.tbl_Acc_BonusTransactions(0).Item(3) * (100 - PercentDistributedSum)) / 100
        '                If RemainingDistributionAmt > 0 Then
        '                    Me.Tbl_Acc_BonusDistributionTableAdapter.Insert(FP, BonusNo, EmpID, MaxDistributionNo + 1, 100 - PercentDistributedSum, RemainingDistributionAmt, 0, DateTimePicker1.Value.Date, "Closing", True)
        '                End If
        '                Me.Tbl_Acc_BonusTransactionsTableAdapter.UpdateBTransStatus(FP, BonusNo, EmpID)
        '            End If
        '        Else
        '            'insert 100 % distribution with description "Closing" and check paid unpaid status is Bonus transactions
        '            RemainingDistributionAmt = Me.DSBonus.tbl_Acc_BonusTransactions(0).Item(3)
        '            If RemainingDistributionAmt > 0 Then
        '                Me.Tbl_Acc_BonusDistributionTableAdapter.Insert(FP, BonusNo, EmpID, 1, 100, RemainingDistributionAmt, 0, DateTimePicker1.Value.Date, "Closing", True)
        '            End If
        '            Me.Tbl_Acc_BonusTransactionsTableAdapter.UpdateBTransStatus(FP, BonusNo, EmpID)
        '        End If
        '    Next
        'End If
        'This part of code demonstrate the distribution of bonus for current FP (If Due Any) on termination of the employee
        '            If Me.Tbl_Acc_BonusNoSettingsTableAdapter.FillBy4(Me.DSBonus.tbl_Acc_BonusNoSettings, Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)) > 0 Then
        '                For i As Integer = 0 To Me.DSBonus.tbl_Acc_BonusNoSettings.Rows.Count - 1
        '                    NoOfMonths = 0
        '                    BonusDueAmt = 0
        '                    GrossPayableBonusAmt = 0
        '                    FP = Me.DSBonus.tbl_Acc_BonusNoSettings(i).Item(0)
        '                    BonusNo = Me.DSBonus.tbl_Acc_BonusNoSettings(i).Item(1)
        '                    PercentOfSalary = Me.DSBonus.tbl_Acc_BonusNoSettings(i).Item(4)
        '                    GrossPayableBonusAmt = (Val(GrossSalaryLabel1.Text) * PercentOfSalary) / 100

        '                    If DateOfJoiningLabel1.Text <> "" Then
        '                        If CType(DateOfJoiningLabel1.Text, Date) < CType("01/07/" & FP.Substring(3, 4), Date) Then
        '                            'Give bonus to all of its due months between 01 July to Date of termination
        '                            If DateTimePicker1.Value.Date > CType(EndOfProbationDateLabel1.Text, Date) Then
        '                                If DateTimePicker1.Value.Day > 15 And CType(DateOfJoiningLabel1.Text, Date).Day < 15 Then
        '                                    NoOfMonths = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date) + 1
        '                                    'BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                                    'If BonusDueAmt > 0 Then
        '                                    '    Me.Tbl_Acc_BonusTransactionsTableAdapter.Insert(FP, BonusNo, CardNoComboBox.SelectedValue, BonusDueAmt, True, DateTimePicker1.Value.Date, NoOfMonths, Val(GrossSalaryLabel1.Text), PercentOfSalary, GrossPayableBonusAmt, frmLogin.LoginId, frmLogin.UserId, IPAddress, Now)
        '                                    '    Me.Tbl_Acc_BonusDistributionTableAdapter.Insert(FP, BonusNo, CardNoComboBox.SelectedValue, 1, 100, BonusDueAmt, 0, DateTimePicker1.Value.Date, "Closing", True)
        '                                    '    Me.Tbl_Acc_BonusTransactionsTableAdapter.UpdateBTransStatus(FP, BonusNo, CardNoComboBox.SelectedValue)
        '                                    'End If
        '                                Else
        '                                    NoOfMonths = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date)
        '                                    BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                                    'If BonusDueAmt > 0 Then
        '                                    '    Me.Tbl_Acc_BonusTransactionsTableAdapter.Insert(FP, BonusNo, CardNoComboBox.SelectedValue, BonusDueAmt, True, DateTimePicker1.Value.Date, NoOfMonths, Val(GrossSalaryLabel1.Text), PercentOfSalary, GrossPayableBonusAmt, frmLogin.LoginId, frmLogin.UserId, IPAddress, Now)
        '                                    '    Me.Tbl_Acc_BonusDistributionTableAdapter.Insert(FP, BonusNo, CardNoComboBox.SelectedValue, 1, 100, BonusDueAmt, 0, DateTimePicker1.Value.Date, "Closing", True)
        '                                    '    Me.Tbl_Acc_BonusTransactionsTableAdapter.UpdateBTransStatus(FP, BonusNo, CardNoComboBox.SelectedValue)
        '                                    'End If
        '                                End If
        '                            End If
        '                        Else
        '                            'Give bonus to all of its due months between Date of Joining to Date of termination if his/her services have been exceeded three months
        '                            If DateTimePicker1.Value.Date > CType(EndOfProbationDateLabel1.Text, Date) Then
        '                                If DateTimePicker1.Value.Day > 15 And CType(DateOfJoiningLabel1.Text, Date).Day < 15 Then
        '                                    'NoOfMonths = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date) + 1
        '                                    'BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                                    NoOfMonths = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date) + 1
        '                                    BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                                    'If BonusDueAmt > 0 Then
        '                                    '    Me.Tbl_Acc_BonusTransactionsTableAdapter.Insert(FP, BonusNo, CardNoComboBox.SelectedValue, BonusDueAmt, True, DateTimePicker1.Value.Date, NoOfMonths, Val(GrossSalaryLabel1.Text), PercentOfSalary, GrossPayableBonusAmt, frmLogin.LoginId, frmLogin.UserId, IPAddress, Now)
        '                                    '    Me.Tbl_Acc_BonusDistributionTableAdapter.Insert(FP, BonusNo, CardNoComboBox.SelectedValue, 1, 100, BonusDueAmt, 0, DateTimePicker1.Value.Date, "Closing", True)
        '                                    '    Me.Tbl_Acc_BonusTransactionsTableAdapter.UpdateBTransStatus(FP, BonusNo, CardNoComboBox.SelectedValue)
        '                                    'End If
        '                                Else
        '                                    'NoOfMonths = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date)
        '                                    'BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                                    NoOfMonths = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
        '                                    BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                                    'If BonusDueAmt > 0 Then
        '                                    '    Me.Tbl_Acc_BonusTransactionsTableAdapter.Insert(FP, BonusNo, CardNoComboBox.SelectedValue, BonusDueAmt, True, DateTimePicker1.Value.Date, NoOfMonths, Val(GrossSalaryLabel1.Text), PercentOfSalary, GrossPayableBonusAmt, frmLogin.LoginId, frmLogin.UserId, IPAddress, Now)
        '                                    '    Me.Tbl_Acc_BonusDistributionTableAdapter.Insert(FP, BonusNo, CardNoComboBox.SelectedValue, 1, 100, BonusDueAmt, 0, DateTimePicker1.Value.Date, "Closing", True)
        '                                    '    Me.Tbl_Acc_BonusTransactionsTableAdapter.UpdateBTransStatus(FP, BonusNo, CardNoComboBox.SelectedValue)
        '                                    'End If
        '                                End If
        '                            End If
        '                        End If
        '                    End If
        '                Next
        '            End If
        '        End If
        '    End If
        'End If
    End Sub
    Dim Monthflag As Boolean = False
    Dim Anflag As Boolean = False
    Private Sub AnnualLeaves()
        Dim GS As Double
        Dim AnLPayment As Integer
        Dim Months As Double
        Dim obj As New UtilityClass
        Dim MonthDiff As Integer = 0
        Dim JoiningDate As Date
        Dim EOPDate As Date
        Dim YearDiff As Integer
        Try
            If DateDiff(DateInterval.Month, CDate(Me.DateOfJoiningLabel1.Text), Me.DateTimePicker1.Value) >= 12 Then
                Try
                    JoiningDate = CDate(CDate(Me.DateOfJoiningLabel1.Text).Day & "/" & CDate(Me.DateOfJoiningLabel1.Text).Month & "/" & Me.DateTimePicker1.Value.Year)
                    YearDiff = CDate(Me.DateOfJoiningLabel1.Text).Year - CDate(Me.EndOfProbationDateLabel1.Text).Year
                Catch ex As Exception
                End Try
                JoiningDate = JoiningDate.AddYears(YearDiff)
                Dim FP As String
                Try
                    EOPDate = CDate(CDate(Me.EndOfProbationDateLabel1.Text).Day & "/" & CDate(Me.EndOfProbationDateLabel1.Text).Month & "/" & Me.DateTimePicker1.Value.Year)
                Catch ex As Exception
                End Try
                If CheckBox1.Checked = True Then
                    If Me.DateOfJoiningLabel1.Text <> "" Then
                        FP = obj.ReturnFP(DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
                        Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
                        MonthDiff = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), CType(EndOfProbationDateLabel1.Text, Date))
                        If Me.DateTimePicker1.Value.Day < CDate(Me.DateOfJoiningLabel1.Text).Day And Me.DateTimePicker1.Value.Month = CDate(Me.DateOfJoiningLabel1.Text).Month Then
                            AnLPayment = 0
                        ElseIf Me.Tbl_Acc_BonusTransactionsTableAdapter.TotalLeaves(EmpIDLabel1.Text, JoiningDate, EOPDate) > 0 Then
                            AnLPayment = 0
                        Else
                            'MsgBox(Me.Tbl_Acc_BonusDistributionTableAdapter.TotalLeaves(EmpIDLabel1.Text, Me.DateOfJoiningLabel1.Text, Me.EndOfProbationDateLabel1.Text))
                            If Months Mod 12 <= MonthDiff And Months / 12 >= 1 Then
                                If MonthDiff > 0 Then
                                    'If Me.Tbl_Acc_BonusTransactionsTableAdapter.AnnualLeavePayment(EmpIDLabel1.Text, CType(Me.EndOfProbationDateLabel1.Text, Date).Month, DateTimePicker1.Value.Year + DateDiff(DateInterval.Year, CType(DateOfJoiningLabel1.Text, Date), CType(EndOfProbationDateLabel1.Text, Date))) = True Then
                                    'MsgBox(Me.Tbl_Acc_BonusTransactionsTableAdapter.AnnualLeavePayment(EmpIDLabel1.Text, CType(Me.EndOfProbationDateLabel1.Text, Date).Month, Me.DateTimePicker1.Value.Year))
                                    If Me.Tbl_Acc_BonusTransactionsTableAdapter.AnnualLeavePayment(EmpIDLabel1.Text, CType(Me.DateTimePicker1.Text, Date).Month, Me.DateTimePicker1.Value.Year) = True Then
                                        AnLPayment = 0
                                    Else
                                        GS = Val(GrossSalaryLabel1.Text) / 26
                                        AnLPayment = GS * 14
                                    End If
                                Else
                                    If Me.Tbl_Acc_BonusTransactionsTableAdapter.AnnualLeavePayment(EmpIDLabel1.Text, CType(DateOfJoiningLabel1.Text, Date).Month, DateTimePicker1.Value.Year) = True Then
                                        AnLPayment = 0
                                    Else
                                        GS = Val(GrossSalaryLabel1.Text) / 26
                                        AnLPayment = GS * 14
                                    End If
                                End If
                            Else
                                'Here is New Code
                                Dim MyDtPickerDate As Date = Me.DateTimePicker1.Value.AddMonths(-1)
                                Dim MyNewDateDiff As Integer = DateDiff(DateInterval.Month, CType(Me.EndOfProbationDateLabel1.Text, Date), DateTimePicker1.Value.Date)
                                If MyNewDateDiff Mod 12 = 1 Then
                                    If Me.Tbl_Acc_BonusTransactionsTableAdapter.AnnualLeavePayment(EmpIDLabel1.Text, MyDtPickerDate.Month, MyDtPickerDate.Year) = True Then
                                        AnLPayment = 0
                                    Else
                                        GS = Val(GrossSalaryLabel1.Text) / 26
                                        AnLPayment = GS * 14
                                    End If
                                End If
                                'AnLPayment = 0
                            End If
                        End If
                    End If
                Else
                    AnLPayment = 0
                End If
            Else
                AnLPayment = 0
            End If


            ' Casual Medical  Leaves

            Dim TotalLeaves As Double = 0
            Try
                TotalLeaves = Me.Tbl_PayRoll_LongLeaves2TableAdapter.PaidLeaves(Val(Me.EmpIDLabel1.Text), FPYear)
            Catch ex3 As Exception

            End Try
            Dim ApplicableLeaves As Double
            If CDate(DateOfJoiningLabel1.Text) <= CType("31/07/" + FPYear.Substring(3, 4), Date) Then
                ApplicableLeaves = (DateDiff(DateInterval.Month, CType("01/07/" + FPYear.Substring(3, 4), Date), CDate(DateTimePicker1.Text)) + 1) * 1.5
            Else
                ApplicableLeaves = (DateDiff(DateInterval.Month, CDate(DateOfJoiningLabel1.Text), CDate(Me.DateTimePicker1.Text)) + 1) * 1.5
            End If
            Dim LeaveBalance As Double = ApplicableLeaves - TotalLeaves

            AvailLeavesLabel.Text = TotalLeaves
            DueLeavesLabel.Text = ApplicableLeaves
            If LeaveBalance >= 0 Then
                ExcessiveLeavesLabel.Text = 0
            Else
                ExcessiveLeavesLabel.Text = LeaveBalance * -1
            End If
            ExcessiveLeavesAmt.Text = CInt(Val(ExcessiveLeavesLabel.Text) * (Val(GrossSalaryLabel1.Text) / 26))



        Catch ex As Exception

        End Try

        Label18.Text = AnLPayment




        Try
            Label35.Text = Me.View_Rpt_Acc_PreSalaryTableAdapter.PrevBonus(EmpIDLabel1.Text)
            If Label35.Text = "" Then
                Label35.Text = 0
            End If
        Catch ex As Exception
            Label35.Text = 0
        End Try
    End Sub

    Private Sub DisplayBonus(ByVal Number As Double)
        'Dim PercentOfSalary As Integer = 0
        'Dim FP As String
        'Dim BonusNo As Integer = 0
        'Dim MaxDistributionNo As Integer = 0
        'Dim RemainingDistributionAmt As Integer = 0
        'Dim PercentDistributedSum As Integer = 0
        'Dim GrossPayableBonusAmt As Integer = 0
        'Dim NoOfMonths As Integer = 0
        'Dim BonusDueAmt As Integer = 0
        'Dim CurrentBonusAmt As Integer = 0
        'Dim EmpID As Integer = 0
        'Dim Obj As New UtilityClass()
        'Dim FPstr1 As String
        'Dim FPstr2 As String

        'If ETIDLabel1.Text = "" Or JTIDLabel1.Text = "" Then
        'Else
        '    If ETIDLabel1.Text = 1 And JTIDLabel1.Text = 5 Then
        '        Label53.Text = 0
        '    Else
        '        'This part of code demonstrate the distribution of bonus for previous FP (If Due Any) on termination of the employee
        '        FPstr1 = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year - 1)
        '        If Me.Tbl_Acc_BonusTransactionsTableAdapter.FillBy2(Me.DSBonus.tbl_Acc_BonusTransactions, FPstr1, CardNoComboBox.SelectedValue) > 0 Then
        '            For i As Integer = 0 To Me.DSBonus.tbl_Acc_BonusTransactions.Rows.Count - 1
        '                PercentDistributedSum = 0
        '                MaxDistributionNo = 0
        '                FP = Me.DSBonus.tbl_Acc_BonusTransactions(i).Item(0)
        '                BonusNo = Me.DSBonus.tbl_Acc_BonusTransactions(i).Item(1)
        '                EmpID = Me.DSBonus.tbl_Acc_BonusTransactions(i).Item(2)

        '                If Me.Tbl_Acc_BonusDistributionTableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusDistribution, FP, BonusNo, EmpID) > 0 Then
        '                    For j As Integer = 0 To Me.DSBonus.tbl_Acc_BonusDistribution.Rows.Count - 1
        '                        PercentDistributedSum += Me.DSBonus.tbl_Acc_BonusDistribution(j).Item(4)
        '                        MaxDistributionNo = Me.DSBonus.tbl_Acc_BonusDistribution(j).Item(3)
        '                    Next
        '                    If 100 - PercentDistributedSum > 0 Then
        '                        'Calculate remaining distribution amount
        '                        RemainingDistributionAmt = (Me.DSBonus.tbl_Acc_BonusTransactions(0).Item(3) * (100 - PercentDistributedSum)) / 100
        '                    End If
        '                Else
        '                    'Calculate 100 % distribution amount
        '                    RemainingDistributionAmt = Me.DSBonus.tbl_Acc_BonusTransactions(0).Item(3)
        '                End If
        '            Next
        '        End If
        '        'This part of code demonstrate the distribution of bonus for current FP (If Due Any) on termination of the employee
        '        FPstr2 = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        '        If Me.Tbl_Acc_BonusNoSettingsTableAdapter.FillBy4(Me.DSBonus.tbl_Acc_BonusNoSettings, FPstr2) > 0 Then
        '            For i As Integer = 0 To Me.DSBonus.tbl_Acc_BonusNoSettings.Rows.Count - 1
        '                NoOfMonths = 0
        '                BonusDueAmt = 0
        '                GrossPayableBonusAmt = 0
        '                FP = Me.DSBonus.tbl_Acc_BonusNoSettings(i).Item(0)
        '                BonusNo = Me.DSBonus.tbl_Acc_BonusNoSettings(i).Item(1)
        '                PercentOfSalary = Me.DSBonus.tbl_Acc_BonusNoSettings(i).Item(4)
        '                GrossPayableBonusAmt = (Val(GrossSalaryLabel1.Text) * PercentOfSalary) / 100

        '                If DateOfJoiningLabel1.Text <> "" Then
        '                    If CType(DateOfJoiningLabel1.Text, Date) < CType("01/07/" & FP.Substring(3, 4), Date) Then
        '                        'Give bonus to all of its due months between 01 July to Date of termination
        '                        If DateTimePicker1.Value.Date > CType(EndOfProbationDateLabel1.Text, Date) Then
        '                            If DateTimePicker1.Value.Day > 15 And CType(DateOfJoiningLabel1.Text, Date).Day < 15 Then
        '                                NoOfMonths = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date) + 1
        '                                BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                            Else
        '                                NoOfMonths = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date)
        '                                BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                            End If
        '                        End If
        '                    Else
        '                        'Give bonus to all of its due months between 01 July to Date of termination if his/her services have been exceeded three months
        '                        If DateTimePicker1.Value.Date > CType(EndOfProbationDateLabel1.Text, Date) Then
        '                            If DateTimePicker1.Value.Day > 15 And CType(DateOfJoiningLabel1.Text, Date).Day < 15 Then
        '                                'NoOfMonths = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date) + 1
        '                                'BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                                NoOfMonths = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date) + 1
        '                                BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                            Else
        '                                'NoOfMonths = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date)
        '                                'BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                                NoOfMonths = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
        '                                BonusDueAmt = NoOfMonths * (GrossPayableBonusAmt / 12)
        '                            End If
        '                        End If
        '                    End If
        '                End If
        '                CurrentBonusAmt += BonusDueAmt
        '            Next
        '        End If
        '        If CheckBox1.Checked Then
        '            Label53.Text = RemainingDistributionAmt + CurrentBonusAmt
        '        Else
        '            Label53.Text = 0
        '        End If
        '    End If
        'End If
        Dim GS As Double
        Dim Bonus As Integer
        Dim Months As Integer
        Dim obj As New UtilityClass
        Dim FP As String
        Dim NewCalc As Integer = 0
        Dim Days As Int16
        Dim PreFP As String = obj.ReturnFP(DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        'If EndOfProbationDateLabel1.Text <> "" Then
        If Me.DateOfJoiningLabel1.Text <> "" Then
            FP = obj.ReturnFP(DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            'Dim MDate As Date = CType("01/07/" & FP.Substring(3, 4), Date)
            If FP <> "" Then
                'If CType(DateOfJoiningLabel1.Text, Date) < CType("01/07/" & FP.Substring(3, 4), Date) Then
                '    Monthflag = True
                '    Months = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date)
                'Else
                '    Monthflag = False
                '    Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
                'End If


                If CType(DateOfJoiningLabel1.Text, Date) < CType("01/07/" & FP.Substring(3, 4), Date) Then
                    Monthflag = True
                    If DateTimePicker1.Value.Date.Day <= 15 Then
                        Months = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date)
                    ElseIf DateTimePicker1.Value.Date.Day > 15 Then
                        Months = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date) + 1
                    End If
                    'Months = DateDiff(DateInterval.Month, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date)
                    Days = DateDiff(DateInterval.Day, CType("01/07/" & FP.Substring(3, 4), Date), DateTimePicker1.Value.Date)
                Else
                    Monthflag = False
                    If CType(DateOfJoiningLabel1.Text, Date).Day <= 15 And DateTimePicker1.Value.Date.Day <= 15 Then
                        Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
                    ElseIf CType(DateOfJoiningLabel1.Text, Date).Day <= 15 And DateTimePicker1.Value.Date.Day > 15 Then
                        Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date) + 1
                    ElseIf CType(DateOfJoiningLabel1.Text, Date).Day > 15 And DateTimePicker1.Value.Date.Day <= 15 Then
                        Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date) - 1
                    ElseIf CType(DateOfJoiningLabel1.Text, Date).Day > 15 And DateTimePicker1.Value.Date.Day > 15 Then
                        Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
                    End If
                    'Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
                    Days = DateDiff(DateInterval.Day, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
                End If


            Else

            End If

            'Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
            'If Months > 3 Then
            '    If Me.DateTimePicker1.Value.Day > 20 Then
            '        Months = Months + 1
            '    End If
            '    Monthflag = False
            '    GS = Val(GrossSalaryLabel1.Text) / 12
            '    Bonus = GS * Months * Number
            '    'ElseIf Months >= 12 Then
            '    '    Graduaty = (Math.Truncate((Months - 9) / 12) + 1) * Val(GrossSalaryLabel1.Text)
            '    '    NoOfGraduaties = Math.Truncate((Months - 9) / 12) + 1
            'ElseIf Monthflag = True And Months <= 3 Then
            '    If Me.DateTimePicker1.Value.Day > 20 Then
            '        Months = Months + 1
            '    End If
            '    Monthflag = False
            '    GS = Val(GrossSalaryLabel1.Text) / 12
            '    Bonus = GS * Months * Number
            'Else
            '    Bonus = 0
            'End If

            If DateTimePicker1.Value.Date >= CType(EndOfProbationDateLabel1.Text, Date) Then
                'If Days > 91 Then
                If Months > 3 Then
                    'If Me.DateTimePicker1.Value.Day > 20 Then
                    '    Months = Months + 1
                    'End If
                    Monthflag = False
                    GS = Val(GrossSalaryLabel1.Text) / 365
                    'GS = Val(GrossSalaryLabel1.Text) / 12
                    Bonus = GS * Days * Number
                    'ElseIf Months >= 12 Then
                    '    Graduaty = (Math.Truncate((Months - 9) / 12) + 1) * Val(GrossSalaryLabel1.Text)
                    '    NoOfGraduaties = Math.Truncate((Months - 9) / 12) + 1
                    'ElseIf Monthflag = True And Months <= 3 Then
                ElseIf Months <= 3 Then
                    'If Me.DateTimePicker1.Value.Day > 20 Then
                    '    Months = Months + 1
                    'End If
                    Monthflag = False
                    GS = Val(GrossSalaryLabel1.Text) / 365

                    'GS = Val(GrossSalaryLabel1.Text) / 12
                    Bonus = GS * Days * Number
                Else
                    Bonus = 0
                End If
            Else
                Bonus = 0
            End If





        End If
        Label53.Text = Bonus
    End Sub

    Private Sub Calculations()
        Dim OTHours As Double
        Dim OTAmt As Double
        Dim PayableDays As Double
        Dim MealPayable As Double
        Dim SalaryPayable As Double
        Dim Holidays As Double
        Dim ConteenDed As Double
        Dim Excbonus As Integer
        Dim bonusDays As Integer
        Dim BonusDate As Integer
        AssignDefaults()


        Holidays = Val(HolidayCountLabel1.Text)
        OTHours = (Val(FullMinutesWorkedLabel1.Text) / 60) '+ Val(TextBox5.Text)
        OTAmt = (OTHours * CalculatePerHourSal()) * 2

        If Val(TotalFullDaysLabel1.Text) + Math.Round(Val(TotalHalfDaysLabel1.Text) / 2, 1) + Holidays + Val(PaidLeavesLabel1.Text) > 26 Then
            PayableDays = 26 - Val(OTALLabel1.Text)
        Else
            PayableDays = Val(TotalFullDaysLabel1.Text) + Math.Round(Val(TotalHalfDaysLabel1.Text) / 2, 1) + Holidays + Val(PaidLeavesLabel1.Text) - Val(OTALLabel1.Text)
        End If
        ConteenDed = (Val(EmpCountLabel1.Text) + 0) * Val(ConteenDeductLabel1.Text)
        'ConteenDed = (Val(ConteenDeductLabel1.Text) * Val(TotalFullDaysLabel1.Text)) - (Val(PaidLeavesLabel1.Text) * Val(ConteenDeductLabel1.Text))
        MealPayable = (Val(MealAllowanceLabel1.Text) * PayableDays) - (Val(PaidLeavesLabel1.Text) * Val(MealAllowanceLabel1.Text))
        SalaryPayable = CalculatePerDaySal() * PayableDays

        'ExcessiveBonusLabel.Text = Me.DSEmpTermination.tbl_Acc_BonusTransactions.Rows(0).Item("")

        Try
            bonusDays = DateDiff(DateInterval.Day, CType(Me.TransactionDateLabel1.Text, Date), CType(Me.DateTimePicker1.Value.Date, Date))
            bonusDays = NoOfMonthsLabel1.Text
        Catch ex As Exception

        End Try
        'FPYear = Strings.Right(FPYear, 4)

        If bonusDays > 0 Then
            'BonusDate = DateDiff(DateInterval.Day, CType(Me.TransactionDateLabel1.Text, Date), CType("30/06/" & Strings.Right(FPYear, 4), Date))
            'CType(Me.DateTimePicker1.Value.Date, Date)
            BonusDate = DateDiff(DateInterval.Day, CType(Me.DateTimePicker1.Value.Date, Date), CType("30/06/" & Strings.Right(FPYear, 4), Date))
            'ExcessiveBonusLabel.Text = CInt((DueAmtLabel1.Text / NoOfMonthsLabel1.Text) * (BonusDate - bonusDays))
            ExcessiveBonusLabel.Text = CInt((DueAmtLabel1.Text / NoOfMonthsLabel1.Text) * (BonusDate - 0))
        Else
            ExcessiveBonusLabel.Text = 0
        End If
        Label42.Text = Val(AdvSumLabel1.Text) - Val(TotalDedLabel1.Text)
        Label3.Text = Math.Round(OTHours, 1)
        Label6.Text = Math.Round(OTAmt)
        Label66.Text = Math.Round(ConteenDed)
        Label14.Text = Math.Round(PayableDays, 1)
        Label9.Text = Math.Round(MealPayable)
        Label11.Text = Math.Round(SalaryPayable)
        Label23.Text = CalculateGraduaty()
        Label52.Text = Math.Round(TACount(Val(TravelAllowanceLabel1.Text), Val(Label14.Text)))
        Label48.Text = Math.Round(SACount(Val(SpecialAllowanceLabel1.Text), Val(Label14.Text)))
        Label50.Text = Math.Round(EACount(Val(EducationAllowanceLabel1.Text), Val(Label14.Text)))
        Label71.Text = Math.Round(TACount(Val(AccommodationLabel1.Text), Val(Label14.Text)))
        Label65.Text = Math.Round(TACount(Val(DTAllowance.Text), Val(Label14.Text)))
        Label26.Text = CalculateAdds()
        Label28.Text = CalculateSubtracts()
        Label29.Text = CalculateAdds() - CalculateSubtracts()
        lblSundays.Text = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month) - CalculateWorkingDays()
        intAbsentees = CalculteAbsentees(CalculateWorkingDays() - Val(HolidayCountLabel1.Text), PayableDays)
        intWorkingDays = CalculateWorkingDays() - Val(HolidayCountLabel1.Text)

    End Sub

    Private Sub AssignDefaults()
        If TotalTAdvLabel1.Text = "" Then
            TotalTAdvLabel1.Text = 0
        End If
        If FullMinutesWorkedLabel1.Text = "" Then
            FullMinutesWorkedLabel1.Text = 0
        End If
        If MealAllowanceLabel1.Text = "" Then
            MealAllowanceLabel1.Text = 0
        End If
        If DueSalaryLabel1.Text = "" Then
            DueSalaryLabel1.Text = 0
        End If
        If TotalFullDaysLabel1.Text = "" Then
            TotalFullDaysLabel1.Text = 0
        End If
        If TotalHalfDaysLabel1.Text = "" Then
            TotalHalfDaysLabel1.Text = 0
        End If
        If PaidLeavesLabel1.Text = "" Then
            PaidLeavesLabel1.Text = 0
        End If
        If TotalLongTermDeductionsLabel1.Text = "" Then
            TotalLongTermDeductionsLabel1.Text = 0
        End If
        If TotalShortTermAdvanceLabel1.Text = "" Then
            TotalShortTermAdvanceLabel1.Text = 0
        End If
        If TravelAllowanceLabel1.Text = "" Then
            TravelAllowanceLabel1.Text = 0
        End If
        If SpecialAllowanceLabel1.Text = "" Then
            SpecialAllowanceLabel1.Text = 0
        End If
        If EducationAllowanceLabel1.Text = "" Then
            EducationAllowanceLabel1.Text = 0
        End If
        If CasualLeaveLabel1.Text = "" Then
            CasualLeaveLabel1.Text = 0
        End If
        If M1Label1.Text = "" Then
            M1Label1.Text = 0
        End If
        If M2Label1.Text = "" Then
            M2Label1.Text = 0
        End If
        If SpecialLeaveLabel1.Text = "" Then
            SpecialLeaveLabel1.Text = 0
        End If
        If OTALLabel1.Text = "" Then
            OTALLabel1.Text = 0
        End If
        If HolidayCountLabel1.Text = "" Then
            HolidayCountLabel1.Text = 0
        End If
        If AdvSumLabel1.Text = "" Then
            AdvSumLabel1.Text = 0
        End If

        If TotalDedLabel1.Text = "" Then
            TotalDedLabel1.Text = 0
        End If
        If DTAllowance.Text = "" Then
            DTAllowance.Text = 0
        End If
    End Sub

    Private Function CalculatePerHourSal() As Double
        Dim SalRatePerHr As Double = Val(GrossSalaryLabel1.Text) / 26 / 8
        Return SalRatePerHr
    End Function

    Private Function CalculatePerDaySal() As Double
        Dim SalRatePerDay As Double = Val(GrossSalaryLabel1.Text) / 26
        Return SalRatePerDay
    End Function

    Private Function CalculateGraduaty() As Double
        Dim Graduaty As Integer
        Dim Months, Days As Integer
        Dim NoOfGraduaties As Integer
        'If GraduityLabel.Text.ToString = "True" Then
        If Me.DateOfJoiningLabel1.Text <> "" Then
            'Months = DateDiff(DateInterval.Month, CType(EndOfProbationDateLabel1.Text, Date), DateTimePicker1.Value.Date)
            Months = DateDiff(DateInterval.Month, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date)
            Days = DateDiff(DateInterval.Day, CType(DateOfJoiningLabel1.Text, Date), DateTimePicker1.Value.Date) + 1
            'If Months >= 6 And Months < 12 Then
            '    Graduaty = Val(GrossSalaryLabel1.Text)
            '    NoOfGraduaties = 1
            'ElseIf Months >= 12 Then
            '    Graduaty = (Math.Truncate((Months - 6) / 12) + 1) * Val(GrossSalaryLabel1.Text)
            '    NoOfGraduaties = Math.Truncate((Months - 6) / 12) + 1
            'Else
            '    Graduaty = 0
            '    NoOfGraduaties = 0
            'End If
            If Months >= 6 And Months < 12 And Days >= 180 Then
                'Graduaty = Val(GrossSalaryLabel1.Text)
                NoOfGraduaties = 1
                Graduaty = NoOfGraduaties * ((Val(GrossSalaryLabel1.Text) / 26) * 30)
            ElseIf Months >= 12 Then
                'NoOfGraduaties = Math.Truncate((Months - 6) / 12) + 1
                'Graduaty = NoOfGraduaties * Val(GrossSalaryLabel1.Text)
                NoOfGraduaties = Days / 365
                Graduaty = NoOfGraduaties * ((Val(GrossSalaryLabel1.Text) / 26) * 30)
            Else
                Graduaty = 0
                NoOfGraduaties = 0
            End If
        End If
        'Else
        '    NoOfGraduaties = 0
        'End If
        'If EndOfProbationDateLabel1.Text <> "" Then

        Label21.Text = NoOfGraduaties
        Return Graduaty
    End Function
    Private Function DTACount(ByVal DTAllowance As Double, ByVal Days As Double) As Double
        Dim TReturn As Double
        TReturn = (DTAllowance / 26) * Days
        Return TReturn
    End Function
    Private Function TACount(ByVal TAllowance As Double, ByVal Days As Double) As Double
        Dim TReturn As Double
        TReturn = (TAllowance / 26) * Days
        Return TReturn
    End Function

    Private Function SACount(ByVal SAllowance As Double, ByVal Days As Double) As Double
        Dim SReturn As Double
        SReturn = (SAllowance / 26) * Days
        Return SReturn
    End Function

    Private Function EACount(ByVal EAllowance As Double, ByVal Days As Double) As Double
        Dim EReturn As Double
        EReturn = (EAllowance / 26) * Days
        Return EReturn
    End Function

    Private Function CalculateAdds() As Double
        Dim Adds As Double
        If RadioButton1.Checked Then
            Adds = Val(Label52.Text) + Val(Label48.Text) + Val(Label50.Text) + Val(Label71.Text) + Val(DueSalaryLabel1.Text) + Val(Label6.Text) + Val(Label9.Text) + Val(Label11.Text) + Val(Label23.Text) + Val(Label35.Text) + 0 + Val(Label53.Text) + Val(Label18.Text) + Val(Label57.Text) + Val(Label65.Text)
        Else
            Adds = Val(Label52.Text) + Val(Label48.Text) + Val(Label50.Text) + Val(Label71.Text) + Val(DueSalaryLabel1.Text) + Val(Label6.Text) + Val(Label9.Text) + Val(Label11.Text) + Val(Label23.Text) + 0 + Val(Label35.Text) + Val(Label53.Text) + Val(Label18.Text) + Val(Label65.Text)
        End If
        'If RadioButton1.Checked Then
        '    Adds = Val(Label52.Text) + Val(Label48.Text) + Val(Label50.Text) + Val(DueSalaryLabel1.Text) + Val(Label6.Text) + Val(Label9.Text) + Val(Label11.Text) + Val(Label23.Text) + Val(TextBox2.Text) + Val(Label18.Text)+ Val(Label53.Text) + ((Val(GrossSalaryLabel1.Text) * ComboBox3.SelectedItem) / 100)
        '    Label57.Text = Val(GrossSalaryLabel1.Text) * (ComboBox3.SelectedItem / 100)
        'Else
        '    Adds = Val(Label52.Text) + Val(Label48.Text) + Val(Label50.Text) + Val(DueSalaryLabel1.Text) + Val(Label6.Text) + Val(Label9.Text) + Val(Label11.Text) + Val(Label23.Text) + Val(TextBox2.Text) + Val(Label53.Text)+ Val(Label18.Text)
        '    Label57.Text = 0
        'End If
        Return Adds
    End Function

    Private Function CalculateSubtracts() As Double
        Dim Subtracts As Double
        If RadioButton2.Checked Then
            Subtracts = Val(AmountLabel4.Text) + Val(TotalShortTermAdvanceLabel1.Text) + Val(TotalLongTermDeductionsLabel1.Text) + Val(Label42.Text) + Val(TotalTAdvLabel1.Text) + 0 + Val(Label57.Text) + Val(Label66.Text) + Val(ExcessiveLeavesAmt.Text) + Val(AmountLabel2.Text) + Val(ExcessiveBonusLabel.Text)
        Else
            Subtracts = Val(AmountLabel4.Text) + Val(TotalShortTermAdvanceLabel1.Text) + Val(TotalLongTermDeductionsLabel1.Text) + Val(Label42.Text) + Val(TotalTAdvLabel1.Text) + 0 + Val(Label66.Text) + Val(ExcessiveLeavesAmt.Text) + Val(AmountLabel2.Text) + Val(ExcessiveBonusLabel.Text)
        End If
        'If RadioButton2.Checked Then
        '    Subtracts = Val(TotalShortTermAdvanceLabel1.Text) + Val(TotalLongTermDeductionsLabel1.Text) + Val(Label42.Text) + Val(TotalTAdvLabel1.Text) + Val(TextBox1.Text) + ((Val(GrossSalaryLabel1.Text) * ComboBox3.SelectedItem) / 100)
        '    Label57.Text = Val(GrossSalaryLabel1.Text) * (ComboBox3.SelectedItem / 100)
        'Else
        '    Subtracts = Val(TotalShortTermAdvanceLabel1.Text) + Val(TotalLongTermDeductionsLabel1.Text) + Val(Label42.Text) + Val(TotalTAdvLabel1.Text) + Val(TextBox1.Text)
        '    Label57.Text = 0
        'End If
        Return Subtracts
    End Function

    Private Sub frmEmpTermination_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Leave_Reason' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Leave_ReasonTableAdapter.Fill(Me.DSHRM.tbl_HRM_Leave_Reason)
        Try
            Me.View_Rpt_Acc_PreSalaryTableAdapter.Fill(Me.DSEmpTermination.View_Rpt_Acc_PreSalary)
        Catch ex As Exception
        End Try
        Me.View_Rpt_Acc_PreSalaryBindingSource.Sort = "CardNo ASc"



        'LoadRecords()


        'VerifyDuplication()


        ComboBox1.SelectedItem = ComboBox1.Items.Item(0)
        ComboBox2.SelectedItem = ComboBox2.Items.Item(0)



        'DisplayBonus(1)




        'If Tbl_Acc_Termination_TransactionsBindingSource.Count > 0 Then

        'End If
    End Sub
    'Private Function AccessLeaves() As Double
    '    Dim TotalLeaves As Double = Me.Tbl_PayRoll_LongLeaves2TableAdapter.PaidLeaves(Val(Me.EmpIDLabel1.Text), FPYear)
    '    Dim ApplicableLeaves As Double
    '    If CDate(DateOfJoiningLabel1.Text) <= CType("31/07/" + FPYear.Substring(3, 4), Date) Then
    '        ApplicableLeaves = (DateDiff(DateInterval.Month, CType("01/07/" + FPYear.Substring(3, 4), Date), CDate(DateTimePicker1.Text)) + 1) * 1.5
    '    Else
    '        ApplicableLeaves = (DateDiff(DateInterval.Month, CDate(DateOfJoiningLabel1.Text), CDate(Me.DateTimePicker1.Text)) + 1) * 1.5
    '    End If
    '    Dim LeaveBalance As Double = ApplicableLeaves - TotalLeaves
    '    Return LeaveBalance
    'End Function
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadRecords()
        VerifyDuplication()
        'MsgBox(AccessLeaves)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calculations()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ComboBox3.Enabled = True
            ComboBox3.SelectedItem = ComboBox3.Items.Item(0)
            Label57.Text = Val(GrossSalaryLabel1.Text)
        End If
        Calculations()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ComboBox3.Enabled = True
            ComboBox3.SelectedItem = ComboBox3.Items.Item(0)
            Label57.Text = Val(GrossSalaryLabel1.Text)
        End If
        Calculations()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim PreSalReturns As Integer
        Dim VerifyPreReturns As Integer
        Dim VerifyFirst As Integer
        Dim dgRes As DialogResult
        Dim MyPreviousMonthDate As Date = DateAdd(DateInterval.Month, -1, DateTimePicker1.Value.Date)
        VerifyFirst = Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy2(Me.DSEmpTermination.tbl_Acc_Salary_Transactions, Val(EmpIDLabel1.Text))
        If VerifyFirst > 0 Then
            VerifyPreReturns = Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy1(Me.DSEmpTermination.tbl_Acc_Salary_Transactions, Val(EmpIDLabel1.Text), MyPreviousMonthDate.Month, MyPreviousMonthDate.Year)
            If VerifyPreReturns = 0 Then
                dgRes = MessageBox.Show("No Previous Month Salary Found." & vbCrLf & " If you want to calculate press Yes else Press No to Proceed Without calculating previous salary", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dgRes = 6 Then
                    CalculateRecord(0)
                End If
            Else
                PreSalReturns = Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy(Me.DSEmpTermination.tbl_Acc_Salary_Transactions, Val(EmpIDLabel1.Text), MyPreviousMonthDate.Month, MyPreviousMonthDate.Year)
                If PreSalReturns = 1 Then
                    dgRes = MessageBox.Show("Previous month salary is still not paid or 'Paid UnPaid Status' is Still Unckecked, so it is going to be added in termination amount." & vbCrLf & "If you are sure that you have paid previous month salary to this employee," & vbCrLf & "then go to salary transaction form and check 'paid or unpaid status' to True," & vbCrLf & "then continue to the termination form by refreshing it." & vbCrLf & "Yes = Continue Without 'Paid Unpaid Status' Check (Add Previous Salary)" & vbCrLf & "No = Continue With Paid Unpaid Status Check (Don't Add Previous Salary)", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If dgRes = 6 Then
                        CalculateRecord(1)
                    End If
                Else
                    CalculateRecord(0)
                End If
            End If
        Else
            CalculateRecord(0)
        End If
    End Sub

    Private Sub CalculateRecord(ByVal status As Integer)
        Dim Obj As New UtilityClass()
        Dim IPAddress As String = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        Dim FP As String
        Dim MyDate As Date
        Dim dgResult As DialogResult
        Dim TotalAdds As Double

        MyDate = DateAdd(DateInterval.Month, -1, DateTimePicker1.Value.Date)
        If Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) <> "" Then
            FP = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        Else
            FP = "Not Set"
        End If
        If Count > 0 Then
            MsgBox("You Must Refresh This Form Before Termination to Retrieve Previous Month Salary")
        Else
            If ComboBox1.SelectedItem = "Transfer...." Then
                dgResult = MessageBox.Show("Are You Sure You Want To Terminate ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If dgResult = 6 Then
                    'Try
                    '    If RadioButton1.Checked Then
                    '        'Me.Tbl_Acc_Termination_TransactionsTableAdapter.Insert(Val(EmpIDLabel1.Text), DateTimePicker1.Value.Date, Val(Label14.Text), Val(Label11.Text), Val(Label9.Text), Val(Label6.Text), Val(Label21.Text), Val(Label23.Text), Val(Label53.Text), "Add", Val(GrossSalaryLabel1.Text), Val(TextBox2.Text), Val(Label42.Text), Val(TotalTAdvLabel1.Text), Val(Label26.Text), Val(Label28.Text), Val(Label29.Text), Now.Date, Val(DueSalaryLabel1.Text), Val(TotalShortTermAdvanceLabel1.Text), Val(TotalLongTermDeductionsLabel1.Text), "false", ComboBox1.SelectedItem, ComboBox2.SelectedItem, TextBox3.Text)
                    '        Me.Tbl_Acc_Termination_TransactionsTableAdapter.Insert(Val(EmpIDLabel1.Text), DateTimePicker1.Value.Date, Val(Label14.Text), Val(Label11.Text), Val(Label9.Text), Val(Label6.Text), Val(Label21.Text), Val(Label23.Text), Val(Label53.Text), "Add", Val(Label57.Text), 0, Val(Label42.Text), Val(TotalTAdvLabel1.Text), Val(Label26.Text), Val(Label28.Text), Val(Label29.Text), Now.Date, Val(DueSalaryLabel1.Text), Val(TotalShortTermAdvanceLabel1.Text), Val(TotalLongTermDeductionsLabel1.Text), False, ComboBox1.SelectedItem, ComboBox2.SelectedItem, TextBox3.Text, Val(Label3.Text), Val(GrossSalaryLabel1.Text), Val(Label18.Text), Val(Label52.Text) + Val(Label48.Text), frmLogin.LoginId, frmLogin.UserId, IPAddress, Now)
                    '    ElseIf RadioButton2.Checked Then
                    '        Me.Tbl_Acc_Termination_TransactionsTableAdapter.Insert(Val(EmpIDLabel1.Text), DateTimePicker1.Value.Date, Val(Label14.Text), Val(Label11.Text), Val(Label9.Text), Val(Label6.Text), Val(Label21.Text), Val(Label23.Text), Val(Label53.Text), "Subtract", Val(Label57.Text), 0, Val(Label42.Text), Val(TotalTAdvLabel1.Text), Val(Label26.Text), Val(Label28.Text), Val(Label29.Text), Now.Date, Val(DueSalaryLabel1.Text), Val(TotalShortTermAdvanceLabel1.Text), Val(TotalLongTermDeductionsLabel1.Text), False, ComboBox1.SelectedItem, ComboBox2.SelectedItem, TextBox3.Text, Val(Label3.Text), Val(GrossSalaryLabel1.Text), Val(Label18.Text), Val(Label52.Text) + Val(Label48.Text), frmLogin.LoginId, frmLogin.UserId, IPAddress, Now)
                    '    ElseIf RadioButton3.Checked Then
                    '        Me.Tbl_Acc_Termination_TransactionsTableAdapter.Insert(Val(EmpIDLabel1.Text), DateTimePicker1.Value.Date, Val(Label14.Text), Val(Label11.Text), Val(Label9.Text), Val(Label6.Text), Val(Label21.Text), Val(Label23.Text), Val(Label53.Text), "Do Nothing", Val(Label57.Text), 0, Val(Label42.Text), Val(TotalTAdvLabel1.Text), Val(Label26.Text), Val(Label28.Text), Val(Label29.Text), Now.Date, Val(DueSalaryLabel1.Text), Val(TotalShortTermAdvanceLabel1.Text), Val(TotalLongTermDeductionsLabel1.Text), "false", ComboBox1.SelectedItem, ComboBox2.SelectedItem, TextBox3.Text, Val(Label3.Text), Val(GrossSalaryLabel1.Text), Val(Label18.Text), Val(Label52.Text) + Val(Label48.Text), frmLogin.LoginId, frmLogin.UserId, IPAddress, Now)
                    '    End If
                    '    TotalAdds = Val(Label9.Text) + Val(Label11.Text) + Val(Label52.Text) + Val(Label50.Text) + Val(Label48.Text)
                    '    'Me.Tbl_Acc_Salary_TransactionsTableAdapter.Insert(Val(EmpIDLabel1.Text), Val(GrossSalaryLabel1.Text), 0, 0, 0, Val(Label52.Text), Val(Label50.Text), Val(Label48.Text), Val(MealAllowanceLabel1.Text), "Cash", Val(AdvSumLabel1.Text), Val(Label42.Text), Val(TotalDedLabel1.Text), 0, Val(TotalTAdvLabel1.Text), Nothing, Val(CasualLeaveLabel1.Text), Val(M1Label1.Text), Val(M2Label1.Text), Val(SpecialLeaveLabel1.Text), Val(OTALLabel1.Text), Val(PaidLeavesLabel1.Text), Val(UnPaidLabel1.Text), Val(TotalFullDaysLabel1.Text), Val(TotalHalfDaysLabel1.Text) / 2, Val(Label3.Text), Val(Label6.Text), intAbsentees, Math.Round(Val(TotalFullDaysLabel1.Text) + (Val(TotalHalfDaysLabel1.Text) / 2), 1), Val(Label14.Text), Val(Label9.Text), Math.Round(CalculatePerDaySal(), 1), Val(Label11.Text), Val(Label9.Text) + Val(Label11.Text), DateTimePicker1.Value.Date, DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month), Val(lblSundays.Text), Val(HolidayCountLabel1.Text), intWorkingDays, Now.Date, "Closing", "True", "False")
                    '    Me.Tbl_Acc_Salary_TransactionsTableAdapter.Insert(Val(EmpIDLabel1.Text), Val(GrossSalaryLabel1.Text), Nothing, Nothing, Nothing, Val(Label52.Text), Val(Label50.Text), Val(Label48.Text), Val(MealAllowanceLabel1.Text), "Cash", Val(AdvSumLabel1.Text), Val(Label42.Text), Val(TotalDedLabel1.Text), 0, Val(TotalTAdvLabel1.Text), Nothing, Nothing, Nothing, Nothing, Nothing, Val(CasualLeaveLabel1.Text), Val(M1Label1.Text), Val(M2Label1.Text), Val(SpecialLeaveLabel1.Text), Val(OTALLabel1.Text), Val(PaidLeavesLabel1.Text), Val(UnPaidLabel1.Text), Val(TotalFullDaysLabel1.Text), Val(TotalHalfDaysLabel1.Text) / 2, Val(Label3.Text), Val(Label6.Text), intAbsentees, Val(TotalFullDaysLabel1.Text) + (Val(TotalHalfDaysLabel1.Text) / 2), Val(TotalFullDaysLabel1.Text) + (Val(TotalHalfDaysLabel1.Text) / 2) + Val(HolidayCountLabel1.Text), Val(Label14.Text), Val(Label9.Text), Math.Round(CalculatePerDaySal(), 1), Val(Label11.Text), TotalAdds, 0, TotalAdds, FP, DateTimePicker1.Value.Date, DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month), Val(lblSundays.Text), Val(HolidayCountLabel1.Text), 0, intWorkingDays, Now.Date, "Closing", True, False)
                    '    InsertDeductions()
                    '    SaveBonus()
                    '    If status = 1 Then
                    '        Me.Tbl_Acc_Salary_TransactionsTableAdapter.SalUpdateStatus(Val(EmpIDLabel1.Text), MyDate.Month, MyDate.Year)
                    '        'Me.Tbl_Acc_PAdvDeductionsTableAdapter.UpdateDescription4Term(Val(EmpIDLabel1.Text), MyDate.Year, MyDate.Month)
                    '    End If
                    '    Me.Tbl_Hrm_Emp_Info_HTableAdapter.CardUpdateQuery(Val(CardNoLabel2.Text))
                    '    Me.Tbl_Hrm_Emp_InfoTableAdapter.EmpUpdateQuery(DateTimePicker1.Value.Date, ComboBox1.Text, TextBox3.Text, Val(EmpIDLabel1.Text))
                    '    Me.Tbl_ApprovingAthorityTableAdapter.UpdateStatus(False, False, Val(EmpIDLabel1.Text))
                    '    MsgBox("Employee Transferred Successfully")
                    'Catch ex As Exception
                    '    MsgBox(ex.Message)
                    'End Try
                End If
            Else
                dgResult = MessageBox.Show("Are You Sure You Want To Terminate ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If dgResult = 6 Then
                    Try
                        If RadioButton1.Checked Then
                            Me.Tbl_Acc_Termination_TransactionsTableAdapter.Insert(Val(EmpIDLabel2.Text), DateTimePicker1.Value.Date, Val(Label14.Text), Val(Label11.Text), Val(Label9.Text), Val(Label6.Text), Val(Label21.Text), Val(Label23.Text), Val(Label53.Text) + Val(Label35.Text), "Add", Val(Label57.Text), 0, Val(Label42.Text), Val(TotalTAdvLabel1.Text), Val(Label26.Text), Val(Label28.Text), Val(Label29.Text), Now.Date, Val(DueSalaryLabel1.Text), Val(TotalShortTermAdvanceLabel1.Text), Val(TotalLongTermDeductionsLabel1.Text), "false", ComboBox1.SelectedItem, Nothing, TextBox3.Text, Val(Label3.Text), Val(GrossSalaryLabel1.Text), Val(Label18.Text), Val(Label52.Text) + Val(Label48.Text), Nothing, Nothing, Nothing, Now, Me.ComboBox2.SelectedValue, Val(Label66.Text), Val(AvailLeavesLabel.Text), Val(ExcessiveLeavesLabel.Text), Val(ExcessiveLeavesAmt.Text), Val(AmountLabel2.Text), Val(AmountLabel4.Text), Val(ExcessiveBonusLabel.Text))
                        ElseIf RadioButton2.Checked Then
                            Me.Tbl_Acc_Termination_TransactionsTableAdapter.Insert(Val(EmpIDLabel2.Text), DateTimePicker1.Value.Date, Val(Label14.Text), Val(Label11.Text), Val(Label9.Text), Val(Label6.Text), Val(Label21.Text), Val(Label23.Text), Val(Label53.Text) + Val(Label35.Text), "Subtract", Val(Label57.Text), 0, Val(Label42.Text), Val(TotalTAdvLabel1.Text), Val(Label26.Text), Val(Label28.Text), Val(Label29.Text), Now.Date, Val(DueSalaryLabel1.Text), Val(TotalShortTermAdvanceLabel1.Text), Val(TotalLongTermDeductionsLabel1.Text), "false", ComboBox1.SelectedItem, Nothing, TextBox3.Text, Val(Label3.Text), Val(GrossSalaryLabel1.Text), Val(Label18.Text), Val(Label52.Text) + Val(Label48.Text), Nothing, Nothing, Nothing, Now, Me.ComboBox2.SelectedValue, Val(Label66.Text), Val(AvailLeavesLabel.Text), Val(ExcessiveLeavesLabel.Text), Val(ExcessiveLeavesAmt.Text), Val(AmountLabel2.Text), Val(AmountLabel4.Text), Val(ExcessiveBonusLabel.Text))
                        ElseIf RadioButton3.Checked Then
                            Me.Tbl_Acc_Termination_TransactionsTableAdapter.Insert(Val(EmpIDLabel2.Text), DateTimePicker1.Value.Date, Val(Label14.Text), Val(Label11.Text), Val(Label9.Text), Val(Label6.Text), Val(Label21.Text), Val(Label23.Text), Val(Label53.Text) + Val(Label35.Text), "Do Nothing", Val(Label57.Text), 0, Val(Label42.Text), Val(TotalTAdvLabel1.Text), Val(Label26.Text), Val(Label28.Text), Val(Label29.Text), Now.Date, Val(DueSalaryLabel1.Text), Val(TotalShortTermAdvanceLabel1.Text), Val(TotalLongTermDeductionsLabel1.Text), "false", ComboBox1.SelectedItem, Nothing, TextBox3.Text, Val(Label3.Text), Val(GrossSalaryLabel1.Text), Val(Label18.Text), Val(Label52.Text) + Val(Label48.Text), Nothing, Nothing, Nothing, Now, Me.ComboBox2.SelectedValue, Val(Label66.Text), Val(AvailLeavesLabel.Text), Val(ExcessiveLeavesLabel.Text), Val(ExcessiveLeavesAmt.Text), Val(AmountLabel2.Text), Val(AmountLabel4.Text), Val(ExcessiveBonusLabel.Text))
                        End If
                        'Me.Tbl_Acc_Salary_TransactionsTableAdapter.Insert(Val(EmpIDLabel1.Text), Val(GrossSalaryLabel1.Text), 0, 0, 0, Val(Label52.Text), Val(Label50.Text), Val(Label48.Text), Val(MealAllowanceLabel1.Text), "Cash", Val(AdvSumLabel1.Text), Val(Label42.Text), Val(TotalDedLabel1.Text), 0, Val(TotalTAdvLabel1.Text), Nothing, Val(CasualLeaveLabel1.Text), Val(M1Label1.Text), Val(M2Label1.Text), Val(SpecialLeaveLabel1.Text), Val(OTALLabel1.Text), Val(PaidLeavesLabel1.Text), Val(UnPaidLabel1.Text), Val(TotalFullDaysLabel1.Text), Val(TotalHalfDaysLabel1.Text), Val(Label3.Text), Val(Label6.Text), intAbsentees, Math.Round(Val(TotalFullDaysLabel1.Text) + (Val(TotalHalfDaysLabel1.Text) / 2), 1), Val(Label14.Text), Val(Label9.Text), Math.Round(CalculatePerDaySal(), 1), Val(Label11.Text), Val(Label9.Text) + Val(Label11.Text), DateTimePicker1.Value.Date, DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month), Val(lblSundays.Text), Val(HolidayCountLabel1.Text), intWorkingDays, Now.Date, "Closing", "True", "False")
                        Me.Tbl_Acc_Salary_TransactionsTableAdapter.Insert(Val(EmpIDLabel2.Text), Val(GrossSalaryLabel1.Text), Nothing, Nothing, Nothing, Val(Label52.Text), Val(Label50.Text), Val(Label48.Text), Val(MealAllowanceLabel1.Text), "Cash", Val(AdvSumLabel1.Text), Val(Label42.Text), Val(TotalDedLabel1.Text), 0, Val(TotalTAdvLabel1.Text), Nothing, Nothing, Nothing, Nothing, Nothing, Val(CasualLeaveLabel1.Text), Val(M1Label1.Text), Val(M2Label1.Text), Val(SpecialLeaveLabel1.Text), Nothing, Val(PaidLeavesLabel1.Text), Val(UnPaidLabel1.Text), Val(TotalFullDaysLabel1.Text), Val(TotalHalfDaysLabel1.Text) / 2, Val(Label3.Text), Val(Label6.Text), intAbsentees, Val(TotalFullDaysLabel1.Text) + (Val(TotalHalfDaysLabel1.Text) / 2), Val(TotalFullDaysLabel1.Text) + (Val(TotalHalfDaysLabel1.Text) / 2) + Val(HolidayCountLabel1.Text), Val(Label14.Text), Val(Label9.Text), Math.Round(CalculatePerDaySal(), 1), Val(Label11.Text), TotalAdds, 0, TotalAdds, FP, DateTimePicker1.Value.Date, DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month), Val(lblSundays.Text), Val(HolidayCountLabel1.Text), 0, intWorkingDays, Now.Date, "Closing", True, False, Val(AmountLabel2.Text))
                        InsertDeductions()
                        SaveBonus()
                        If status = 1 Then
                            Me.Tbl_Acc_Salary_TransactionsTableAdapter.SalUpdateStatus(Val(EmpIDLabel2.Text), MyDate.Month, MyDate.Year)
                            'Me.Tbl_Acc_PAdvDeductionsTableAdapter.UpdateDescription4Term(Val(EmpIDLabel1.Text), MyDate.Year, MyDate.Month)
                        End If
                        'Me.Tbl_Hrm_Emp_Info_HTableAdapter.CardUpdateQuery(Val(CardNoLabel2.Text))
                        'Me.Tbl_Hrm_Emp_InfoTableAdapter.EmpUpdateQuery(CDate(DateTimePicker1.Value.Date), CInt(ComboBox2.SelectedItem), ComboBox1.Text.ToString, Val(EmpIDLabel1.Text))
                        Me.Tbl_Hrm_Emp_InfoTableAdapter.EmpUpdateQuery(CDate(DateTimePicker1.Value.Date), Me.ComboBox2.SelectedValue, ComboBox1.Text, Val(EmpIDLabel2.Text))
                        'Me.Tbl_Hrm_Emp_InfoTableAdapter.EmpUpdateQuery()
                        'Me.Tbl_ApprovingAthorityTableAdapter.UpdateStatus(False, False, Val(EmpIDLabel1.Text))

                        MsgBox("Employee " & ComboBox1.SelectedItem & " Successfully")
                        Me.View_Rpt_Acc_PreSalaryTableAdapter.Fill(Me.DSEmpTermination.View_Rpt_Acc_PreSalary)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub InsertDeductions()
        Dim Obj As New UtilityClass()
        If Val(AdvSumLabel1.Text) = 0 Then
        Else
            If Val(Label42.Text) = 0 Then
            Else
                Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(Val(EmpIDLabel1.Text), Val(Label42.Text), DateTimePicker1.Value.Date, "Closing", Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year))
            End If
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calculations()
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Dim Filter As String = ""
    '    Dim Path As String = ""
    '    Dim Param As String = ""
    '    Dim Obj As New UtilityClass()

    '    Path = "" & frmLogin.ReportsPath & "\Accounts\Terminationletter.rpt"
    '    Filter = "{View_Rpt_Acc_InActiveEmployees.EmpID} = " & Val(EmpIDLabel1.Text) & ""


    '    Obj.LoadReports(Path, Filter, Param)
    'End Sub

    'Function ChildWindowOpen(ByVal childWindow As String)
    '    For Each f As Form In frmHRMMain.MdiChildren
    '        If f.Name = childWindow Then
    '            f.WindowState = FormWindowState.Maximized
    '            Return True
    '        End If
    '    Next
    '    Return False
    'End Function

    Private Sub VerifyDuplication()
        Dim RowCount As Integer = 0
        Try
            RowCount = Me.Tbl_Acc_Termination_TransactionsTableAdapter.FillBy(Me.DSEmpTermination.tbl_Acc_Termination_Transactions, Val(CardNoComboBox.SelectedValue))
        Catch ex As Exception
        End Try
        If RowCount = 0 Then
            Button1.Enabled = True
            Label33.Text = ""
        Else
            Button1.Enabled = False
            Label33.Text = "Selected Employee have Already been Terminated/Transferred/Laid Off/Resigned"
        End If
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    If ChildWindowOpen("frmMonthlySalary") = False Then
    '        Try
    '            Dim frmMonthlySalaryObj As New frmMonthlySalary
    '            frmMonthlySalaryObj.MdiParent = frmHRMMain
    '            frmMonthlySalaryObj.Show()
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LoadRecords()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            ComboBox3.Enabled = False
            Label57.Text = 0
        End If
        Calculations()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calculations()
    End Sub

    Private Function CalculateWorkingDays() As Integer
        Dim NoOfDaysinMonth As Integer
        Dim j As Int16
        Dim c As Int16 = 0
        NoOfDaysinMonth = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        For j = 1 To NoOfDaysinMonth
            Dim MyWeekDay = Weekday(CType(CType(j, String) + "/" + CType(DateTimePicker1.Value.Month, String) + "/" + CType(DateTimePicker1.Value.Year, String), Date))
            If MyWeekDay = 1 Then
            Else
                c += 1
            End If
        Next
        Return c
    End Function

    Private Function CalculteAbsentees(ByVal WorkingDays As Double, ByVal DaysWorked As Double) As Double
        Dim Absentees As Double
        Absentees = WorkingDays - DaysWorked
        If Absentees < 0 Then
            Absentees = 0
        End If
        Return Absentees
    End Function

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Calculations()
    End Sub

    Private Sub View_Rpt_Acc_PreSalaryBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View_Rpt_Acc_PreSalaryBindingSource.PositionChanged
        LoadRecords()
        VerifyDuplication()
        'MsgBox(AccessLeaves)
        CheckBox1.CheckState = CheckState.Checked
        CheckBox2.CheckState = CheckState.Checked
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        'If ComboBox1.SelectedItem = "Transfer" Then
        '    ComboBox2.Enabled = True
        'Else
        '    ComboBox2.Enabled = False
        'End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        Label57.Text = Val(GrossSalaryLabel1.Text) * (ComboBox3.SelectedItem / 100)
        Calculations()
    End Sub

    Private Sub TextBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Enter
        If TextBox3.Text = "None" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            TextBox3.Text = "None"
            TextBox3.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DisplayBonus()
        Calculations()
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If CheckBox2.Checked = False Then
            DisplayBonus(0)
            Calculations()
        Else
            DisplayBonus(1)
            Calculations()
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If CheckBox2.Checked = False Then
            DisplayBonus(0)
            Calculations()
        Else
            DisplayBonus(1.5)
            Calculations()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If CheckBox2.Checked = False Then
            DisplayBonus(0)
            Calculations()
        Else
            DisplayBonus(2)
            Calculations()
        End If
    End Sub

    Private Sub Tbl_Hrm_Emp_Info_HBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_Emp_Info_HBindingSource.PositionChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        AnnualLeaves()
        Calculations()
    End Sub

    'Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
    '    If CheckBox2.Checked = False Then
    '        DisplayBonus(0)
    '        Calculations()
    '    ElseIf CheckBox2.Checked = True Then
    '        If RadioButton9.Checked Then
    '            DisplayBonus(1)
    '            Calculations()
    '        ElseIf RadioButton8.Checked Then
    '            DisplayBonus(1.5)
    '            Calculations()
    '        ElseIf RadioButton4.Checked Then
    '            DisplayBonus(2)
    '            Calculations()
    '        End If
    '    End If
    'End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label60_Click(sender As Object, e As EventArgs) Handles Label60.Click

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = False Then
            DisplayBonus(0)
            Calculations()
        Else
            DisplayBonus(0)
            Calculations()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub







    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    'If ChildWindowOpen("frmMonthlySalary") = False Then
    '    '    Dim frmChngPswdObj1115 As New frmMonthlySalary
    '    '    'frmChngPswdObj1115.MdiParent = Me
    '    '    'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
    '    '    frmChngPswdObj1115.ShowDialog()

    '    'End If

    'End Sub
End Class