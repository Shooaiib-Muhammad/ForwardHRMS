Imports System.IO
Imports System.Threading
Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Office.Core

Imports Microsoft.VisualBasic
Public Class frmAutoSalCalculation
    Dim GlobalPathStr As String
    Dim OStremWriter As StreamWriter
    Dim FilePath As String = Nothing
    Dim OT As Double
    Dim DayCalc As Int16
    Dim flag26 As Boolean = False
    Dim MonthFlag As Boolean = False
    Dim DTAAmount As Integer = 0
    'Dim FileFlag As Boolean = False
    Sub ErrorFileWriter(ByVal Path As String, ByVal Str As String)
        If Str <> "" Then
            Try
                OStremWriter = New StreamWriter(Path, True)
                OStremWriter.Write(Str)
                OStremWriter.WriteLine("")
                OStremWriter.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Dim PDFPath As String
    Function SaniorityValue() As Integer
        Dim SaniorityAllowance, YearValue As Integer
        Try
            SaniorityAllowance = 0
            YearValue = DateDiff(DateInterval.Day, CType(DateOfJoiningLabel1.Text, Date), CType("#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Date))
            YearValue = Fix(YearValue / 365)
            If SenStatusLabel3.Text = True Or GradeLabel2.Text.Trim = "A+" Or GradeLabel2.Text.Trim = "S-2" Or GradeLabel2.Text.Trim = "A" Or GradeLabel2.Text.Trim = "B" Or GradeLabel2.Text.Trim = "C" Or GradeLabel2.Text.Trim = "D" Then
                If YearValue <= 5 And YearValue > 0 Then
                    SaniorityAllowance = YearValue * 250
                ElseIf YearValue = 0 Then
                    SaniorityAllowance = 0
                Else
                    SaniorityAllowance = 1250
                End If
            Else
                SaniorityAllowance = 0
            End If
        Catch ex As Exception
            SaniorityAllowance = 0
        End Try

        Return SaniorityAllowance
    End Function
    Private Sub frmMonthlySalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        Try
            Me.Tbl_Hrm_Emp_Info_Cards_InfoTableAdapter.FillBy(Me.DSCalculateSalary.tbl_Hrm_Emp_Info_Cards_Info)
        Catch ex As Exception

        End Try

        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)

        Try
            Me.Tbl_Hrm_Emp_Info_HTableAdapter.FillBy(Me.DSCalculateSalary.tbl_Hrm_Emp_Info_H)
        Catch ex As Exception

        End Try
        DTAAmount = Me.DSUser.tbl_Comp_Info.Rows(0).Item("DailyTravelAllowance")
        Try
            SelectFP()
        Catch ex As Exception
        End Try
        NavigationFunction()
        PDFPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Auto Salary Error"
        If Directory.Exists(PDFPath) Then
        Else
            Directory.CreateDirectory(PDFPath)
        End If
        If Me.DSUser.tbl_Comp_Info.Rows(0).Item("SalayType") = "Monthly Days" Then
            MonthFlag = True
            flag26 = False
        ElseIf Me.DSUser.tbl_Comp_Info.Rows(0).Item("SalayType") = "26 Days" Then
            MonthFlag = False
            flag26 = True
        End If
        If MonthFlag = True And flag26 = False Then
            DayCalc = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        ElseIf MonthFlag = False And flag26 = True Then
            DayCalc = 26
        End If
        If Me.DSUser.tbl_Comp_Info.Rows(0).Item("OverTimeType") = "Single" Then
            OT = 1
        ElseIf Me.DSUser.tbl_Comp_Info.Rows(0).Item("OverTimeType") = "One And Half " Then
            OT = 1.5
        ElseIf Me.DSUser.tbl_Comp_Info.Rows(0).Item("OverTimeType") = "Double" Then
            OT = 2
        End If
        BStatus = Me.DSUser.tbl_Comp_Info.Rows(0).Item("BStatus")
        Label6.Text = "Stoped!"
        Timer1.Interval = 100
        Timer2.Interval = 200

        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = Me.Tbl_Hrm_Emp_Info_HBindingSource.Count - 1

    End Sub
    Dim BStatus As Boolean = False
    Private Sub AssignZeros()
        'Assign Zeros to all the labels on navigation of records
        If GrossSalaryLabel2.Text = "" Then
            GrossSalaryLabel2.Text = 0
        End If
        If TaxDeductionLabel2.Text = "" Then
            TaxDeductionLabel2.Text = 0
        End If
        If TravelAllowanceLabel2.Text = "" Then
            TravelAllowanceLabel2.Text = 0
        End If
        If EducationAllowanceLabel2.Text = "" Then
            EducationAllowanceLabel2.Text = 0
        End If
        If MealAllowanceLabel2.Text = "" Then
            MealAllowanceLabel2.Text = 0
        End If
        If SpecialAllowanceLabel2.Text = "" Then
            SpecialAllowanceLabel2.Text = 0
        End If
        If EOBILabel2.Text = "" Then
            EOBILabel2.Text = 0
        End If
        If PerDTAPayable.Text = "" Then
            PerDTAPayable.Text = 0
        End If
        If DailyTA.Text = "" Then
            DailyTA.Text = 0
        End If
        If PaidLeavesLabel2.Text = "" Then
            PaidLeavesLabel2.Text = 0
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
        If TotalFullDaysLabel1.Text = "" Then
            TotalFullDaysLabel1.Text = 0
        End If
        If TotalHalfDaysLabel1.Text = "" Then
            TotalHalfDaysLabel1.Text = 0
        End If
        If HolidayCountLabel1.Text = "" Then
            HolidayCountLabel1.Text = 0
        End If
        If AmountLabel1.Text = "" Then
            AmountLabel1.Text = 0
        End If
        If TotalLeavesLabel1.Text = "" Then
            TotalLeavesLabel1.Text = 0
        End If
        If OTALLabel1.Text = "" Then
            OTALLabel1.Text = 0
        End If
        If RentDeductionLabel1.Text = "" Then
            RentDeductionLabel1.Text = 0
        End If
        If FullMinutesWorkedLabel1.Text = "" Then
            FullMinutesWorkedLabel1.Text = 0
        End If
        If AdvSumLabel1.Text = "" Then
            AdvSumLabel1.Text = 0
        End If
        If TotalDedLabel1.Text = "" Then
            TotalDedLabel1.Text = 0
        End If
        If PAdvDedRateLabel1.Text = "" Then
            PAdvDedRateLabel1.Text = 0
        End If
        If EveningShortMinsLabel1.Text = "" Then
            EveningShortMinsLabel1.Text = 0
        End If
        If MorningShortMinsLabel1.Text = "" Then
            MorningShortMinsLabel1.Text = 0
        End If

    End Sub

    'Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
    '    'SaveNow()
    '    Timer1.Stop()
    'End Sub

    Private Sub SaveNow()
        'This function call InsertSalaryTransactions and refresh after saving.
        If GrossSalaryLabel2.Text > 0 Then
            If btnSave.Enabled = False Then
                'MsgBox("Record Already Saved or Values are Over Flowing")
                Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter.Insert(Me.EmpIDLabel2.Text, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", GrossSalaryLabel2.Text, Nothing, Nothing, Val(UnPaidLeavesLabel2.Text), Val(M2Label1.Text), Me.GradeLabel1.Text, Val(lblMonthDays.Text), Val(HolidayCountLabel1.Text), Val(lblTotalDaysWorked.Text))
                ErrorFileWriter(FilePath, "CardNo: [" & Me.Label1.Text & "] , Message: [Salary Already Saved or Values are Over Flowing]")
            Else
                If Val(lblTotalDaysWorked.Text) < 5 And Val(PaidLeavesLabel2.Text) <= 5 Then
                    'Dim DgResult As DialogResult = MessageBox.Show("Number of Working Days are Less than 5." & vbCrLf & "Are you sure you want to save Salary", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    'If DgResult = Windows.Forms.DialogResult.Yes Then
                    '    InsertSalaryTransaction()
                    '    NavigationFunction()
                    'End If
                    Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter.Insert(Me.EmpIDLabel2.Text, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", GrossSalaryLabel2.Text, Nothing, Nothing, Val(UnPaidLeavesLabel2.Text), Val(M2Label1.Text), Me.GradeLabel1.Text, Val(lblMonthDays.Text), Val(HolidayCountLabel1.Text), Val(lblTotalDaysWorked.Text))
                    ErrorFileWriter(FilePath, "CardNo: [" & Me.Label1.Text & "] , Message: [Number of Working Days are Less than 5.]")
                Else
                    InsertSalaryTransaction()
                    'NavigationFunction()
                End If
            End If
        Else
            'MsgBox("Employees Gross Salary Was Inactive or Zero, " & vbCrLf & " So Salary Calculation is terminated")
            Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter.Insert(Me.EmpIDLabel2.Text, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", 0, Nothing, Nothing, Val(UnPaidLeavesLabel2.Text), Val(M2Label1.Text), Me.GradeLabel1.Text, Val(lblMonthDays.Text), Val(HolidayCountLabel1.Text), Val(lblTotalDaysWorked.Text))
            ErrorFileWriter(FilePath, "CardNo: [" & Me.Label1.Text & "] , Message: [Employees Gross Salary Was Inactive or Zero]")
        End If

    End Sub

    Private Function CalculateSubtracts(ByVal ShortTermDeduct As Double, ByVal LongTermDeduct As Double, ByVal eobi As Double, ByVal tax As Double, ByVal RentDed As Double, ByVal ShortLeaveDed As Double, ByVal MealDeduction As Integer, FairShop As Double, RFDAdv As Double) As Double
        Dim TotalD As Double
        TotalD = ShortTermDeduct + RentDed + LongTermDeduct + eobi + tax + ShortLeaveDed + MealDeduction + FairShop + RFDAdv
        Return TotalD
    End Function

    Private Function CalculatePerHourSalary(ByVal sal1 As Double) As Double
        Dim PerHalfHourSalary As Double = sal1 / DayCalc / 8
        Return PerHalfHourSalary
    End Function

    Private Function CalculteAbsentees(ByVal WorkingDays As Double, ByVal DaysWorked As Double, ByVal MaskedDays As Double, ByVal PaidLeaves As Double, ByVal Deductions As Double) As Double
        Dim Absentees As Double
        Absentees = WorkingDays - (DaysWorked + MaskedDays + PaidLeaves - Deductions)
        If Absentees < 0 Then
            Absentees = 0
        End If
        Return Absentees
    End Function

    Private Function CalculateAdds(ByVal dueSal As Double, ByVal travelA As Double, ByVal educationA As Double, ByVal mealA As Double, ByVal specialA As Double, ByVal OverTime As Double, ByVal SN As Integer, AccomAllowance As Double, ByVal TAllowance As Double, ByVal PerDTAPayable As Double) As Double
        Dim TotalAdds As Double = dueSal + travelA + educationA + mealA + specialA + OverTime + SN + AccomAllowance + TAllowance + PerDTAPayable
        Return TotalAdds
    End Function

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged, CheckBox3.CheckedChanged
        If Label5.Text = "" Or Label5.Text = "Values Over Flow..." Then
            CalculateAllRecords()
        End If
    End Sub

    Private Function CalculateWorkingDays() As Integer
        Dim NoOfDaysinMonth As Integer
        Dim j As Int16
        Dim c As Int16 = 0
        NoOfDaysinMonth = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        For j = 1 To NoOfDaysinMonth
            Dim MyWeekDay = Weekday(CType(j & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year, Date))
            If MyWeekDay = 1 Then
                'Do nothing if weekday is Sunday
            Else
                c += 1
            End If
        Next
        Return c
    End Function

    Private Function RoundOTHours(ByVal OTMinutes As Double) As Double
        'This is also great peace of working.
        'In this function over time minutes are distributed over 30 minutes or multiple of 30 minutes
        If OTMinutes Mod 30 >= 0 And OTMinutes Mod 30 <= 20 Then
            OTMinutes = OTMinutes - (OTMinutes Mod 30)
        Else
            OTMinutes = OTMinutes - (OTMinutes Mod 30) + 30
        End If
        Return OTMinutes / 60
    End Function

    Private Sub NavigationFunction()
        'This is navigation function, which is called on navigation of each record.
        Dim TransCount As Integer
        Dim PaidCount As Integer = 0

        LoadData()
        AssignZeros()
        CalculateAllRecords()

        TransCount = Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy(Me.DSCalculateSalary.tbl_Acc_Salary_Transactions, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        'PaidCount = Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy1(Me.DSCalculateSalary.tbl_Acc_Salary_Transactions, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)

        If PaidCount = 0 Then
            If TransCount = 0 Then
                ChangeColor()
            Else
                'Label5.Text = "Salary Have Been Saved But Not Paid To The Employee..."
                btnSave.Enabled = False
                'lblAdds.BackColor = Color.White
                'lblAdds.ForeColor = Color.Black
                'lblBeforeFinal.BackColor = Color.White
                'lblBeforeFinal.ForeColor = Color.Black
                'lblAbsents.BackColor = Color.White
                'lblAbsents.ForeColor = Color.Black
                lblSalary.BackColor = Color.Red
                'lblSalary.ForeColor = Color.White
                'lblTotalPayableDays.BackColor = Color.White
                'lblTotalPayableDays.ForeColor = Color.Black
            End If
        Else
            'Label5.Text = "Salary Have Been Saved And Also Paid..."
            btnSave.Enabled = False
            'lblAdds.BackColor = Color.White
            'lblAdds.ForeColor = Color.Black
            'lblBeforeFinal.BackColor = Color.White
            'lblBeforeFinal.ForeColor = Color.Black
            'lblAbsents.BackColor = Color.White
            'lblAbsents.ForeColor = Color.Black
            lblSalary.BackColor = Color.Red
            'lblSalary.ForeColor = Color.White
            'lblTotalPayableDays.BackColor = Color.White
            'lblTotalPayableDays.ForeColor = Color.Black
        End If

        MaskedTextBox1.Clear()
        MaskedTextBox2.Clear()
        TextBox4.Clear()

        If CheckBox1.Checked = False Then
            CheckBox1.Checked = True
        End If
        'If CheckBox2.Checked = True Then
        '    CheckBox2.Checked = False
        'End If
        'CardNoComboBox.Focus()

    End Sub
    Dim IntDedduction As Integer = 0
    Private Sub ChangeColor()
        'This function changes the color of labels if values are over flowing.
        If Val(lblAdds.Text) < 0 Or Val(lblBeforeFinal.Text) < 0 Or Val(lblSalary.Text) < 0 Or Val(lblAbsents.Text) < 0 Or Val(lblTotalPayableDays.Text) > DayCalc Or Val(lblTotalPayableDays.Text) <= 0 Then
            btnSave.Enabled = False
            Label5.Text = "Values Over Flow..."
            'lblAdds.BackColor = Color.Red
            'lblAdds.ForeColor = Color.White
            'lblBeforeFinal.BackColor = Color.Red
            'lblBeforeFinal.ForeColor = Color.White
            'lblAbsents.BackColor = Color.Red
            'lblAbsents.ForeColor = Color.White
            lblSalary.BackColor = Color.Red
            'lblSalary.ForeColor = Color.White
            'lblTotalPayableDays.BackColor = Color.Red
            'lblTotalPayableDays.ForeColor = Color.White
        Else
            btnSave.Enabled = True
            Label5.Text = ""
            'lblAdds.BackColor = Color.White
            'lblAdds.ForeColor = Color.Black
            'lblBeforeFinal.BackColor = Color.White
            'lblBeforeFinal.ForeColor = Color.Black
            'lblAbsents.BackColor = Color.White
            'lblAbsents.ForeColor = Color.Black
            lblSalary.BackColor = Color.DarkGreen
            'lblSalary.ForeColor = Color.Purple
            'lblTotalPayableDays.BackColor = Color.White
            'lblTotalPayableDays.ForeColor = Color.Black
        End If
    End Sub

    Private Sub CalculateAllRecords()
        'This is main function that calculate all the values and assign these values to their respective labels.
        'This function's most critical point to understand is its calculation of records in hierarchy.
        Dim intUnpaidLeaves As Double
        Dim intPerDaySalary As Double

        Dim intTotalSubtracts As Double
        Dim intTotalAdds As Double

        Dim intSumOfHalfAndFullDays As Double
        Dim intAbsentees As Double
        Dim intTotalPayableDays As Double
        Dim intMealPayable As Double
        Dim intDueSalary As Double

        Dim intFinalSalary As Double
        Dim intOverTimePayable As Double
        Dim intLTARemaining As Double
        Dim intMaskedDays As Double
        Dim intMaskedOTHours As Double
        Dim intExtraDays As Integer
        Dim FinalWorkingDays As Double
        Dim IntDeduction As Integer
        Dim IntMealDeduction As Integer
        Dim IntMealDeductionValue As Integer


        Dim DTA As Integer



        DTA = Me.Tbl_Acc_Salary_TransactionsTableAdapter.TADays(Val(EmpIDLabel2.Text), FinancialPeriodComboBox.Text, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        DailyTA.Text = DTAAmount * Val(DTA)
        'DailyTA.Text = 50 * Val(DTA)


        If TextBox4.Text <> "" And IsNumeric(TextBox4.Text) = True Then
            If TextBox4.Text = "." Then
                intMaskedOTHours = 0
            Else
                intMaskedOTHours = CType(TextBox4.Text, Double)
            End If
        End If
        Try
            IntDeduction = Val(Me.DayDeductionLabel1.Text)
        Catch ex As Exception
            IntDeduction = 0
        End Try
        Try
            IntMealDeduction = Val(Me.EmpCountLabel1.Text)
        Catch ex As Exception
            IntMealDeduction = 0
        End Try
        intMaskedDays = Val(MaskedTextBox1.Text) + (Val(MaskedTextBox2.Text) / 2)
        intUnpaidLeaves = Val(TotalLeavesLabel1.Text) - Val(PaidLeavesLabel2.Text)
        intLTARemaining = Val(AdvSumLabel1.Text) - Val(TotalDedLabel1.Text)
        intSumOfHalfAndFullDays = Val(TotalFullDaysLabel1.Text) + (Val(TotalHalfDaysLabel1.Text) / 2)
        intPerDaySalary = Val(GrossSalaryLabel2.Text) / DayCalc
        'If GradeLabel1.Text.Trim = "I" Or GradeLabel1.Text.Trim = "II" Or GradeLabel1.Text.Trim = "III" Or GradeLabel1.Text.Trim = "A" Then
        '    intOverTimePayable = (Val(FullMinutesWorkedLabel1.Text) / 60 + RoundOTHours(intMaskedOTHours * 60)) * CalculatePerHourSalary(Val(GrossSalaryLabel2.Text))
        'Else
        intOverTimePayable = (Val(FullMinutesWorkedLabel1.Text) / 60 + RoundOTHours(intMaskedOTHours * 60)) * CalculatePerHourSalary(Val(GrossSalaryLabel2.Text)) * OT
        'End If
        If Me.DSCalculateSalary.tbl_Hrm_ExtraWorkingDays.Count = 1 Then
            intExtraDays = Me.DSCalculateSalary.tbl_Hrm_ExtraWorkingDays(0).Item(0)
        End If

        FinalWorkingDays = (CalculateWorkingDays() - Val(HolidayCountLabel1.Text)) + intExtraDays
        intAbsentees = CalculteAbsentees(FinalWorkingDays, intSumOfHalfAndFullDays, intMaskedDays, Val(PaidLeavesLabel2.Text), IntDeduction)
        'intTotalPayableDays = DayCalc - intAbsentees
        Try
            If CType(DateOfJoiningLabel1.Text, Date) > CType(1 & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year, Date) Then
                intTotalPayableDays = intSumOfHalfAndFullDays + intMaskedDays + Val(PaidLeavesLabel2.Text) + Val(HolidayCountLabel1.Text) - IntDeduction
                If intTotalPayableDays > 26 Then
                    intTotalPayableDays = 26
                End If
            Else
                intTotalPayableDays = DayCalc - intAbsentees
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        intDueSalary = intPerDaySalary * intTotalPayableDays

        If CheckBox1.Checked Then
            If intLTARemaining = 0 Then
                Label33.Text = 0
            Else
                If intLTARemaining < Val(PAdvDedRateLabel1.Text) Then
                    Label33.Text = intLTARemaining
                Else
                    Label33.Text = Val(PAdvDedRateLabel1.Text)
                End If
            End If
        Else
            Label33.Text = 0
        End If

        '/////////////Short Leave Area////////
        lblTotalShortMinutes.Text = Val(MorningShortMinsLabel1.Text) + Val(EveningShortMinsLabel1.Text)
        lblShortAmt.Text = Math.Round(Val(lblTotalShortMinutes.Text) / 60 * CalculatePerHourSalary(Val(GrossSalaryLabel2.Text)))
        'If CheckBox2.Checked = False Then
        txtSLeaveDeduct.Text = 0 '//Val(lblShortAmt.Text)
        lblShortDeducted.Text = Val(txtSLeaveDeduct.Text)
        txtSLeaveDeduct.Enabled = False
        'Else
        '    txtSLeaveDeduct.Text = Val(lblShortAmt.Text)
        '    lblShortDeducted.Text = Val(txtSLeaveDeduct.Text)
        '    txtSLeaveDeduct.Enabled = True
        'End If
        '/////////////Short Leave Area////////

        lblRemaining.Text = intLTARemaining
        UnPaidLeavesLabel2.Text = intUnpaidLeaves
        lblTotalDaysWorked.Text = intSumOfHalfAndFullDays
        lblAbsents.Text = intAbsentees
        lblTotalPayableDays.Text = intTotalPayableDays
        If Val(CanteenLabel.Text) > 0 Then
            IntMealDeductionValue = (Val(CanteenLabel.Text) * IntMealDeduction)
        Else
            IntMealDeductionValue = 0
        End If
        If CheckBox3.CheckState = CheckState.Unchecked Then
            intMealPayable = 0
        ElseIf CheckBox3.CheckState = CheckState.Checked Then
            If Val(MealAllowanceLabel2.Text) <= 0 Then
                intMealPayable = 0
            Else
                intMealPayable = Val(MealAllowanceLabel2.Text) * (Val(lblTotalPayableDays.Text) - (Val(HolidayCountLabel1.Text)) - (Val(PaidLeavesLabel2.Text)))
                If intMealPayable < 0 Then
                    intMealPayable = 0

                End If
            End If

        End If
        Try
            If Val(PerDTA.Text) <= 0 Then
                PerDTAPayable.Text = 0
            Else
                PerDTAPayable.Text = Math.Round(Val(PerDTA.Text) * (Val(lblTotalDaysWorked.Text)))
            End If
        Catch ex As Exception
            PerDTA.Text = 0
            PerDTAPayable.Text = 0
        End Try

        'intMealPayable = Val(MealAllowanceLabel2.Text) * (Val(lblTotalPayableDays.Text) - (Val(PaidLeavesLabel2.Text)))

        lblOverTimeHours.Text = Val(FullMinutesWorkedLabel1.Text) / 60 + RoundOTHours(intMaskedOTHours * 60)
        lblWorkingDays.Text = FinalWorkingDays

        lblMonthDays.Text = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        lblSundays.Text = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month) - CalculateWorkingDays()

        intTotalSubtracts = CalculateSubtracts(Val(AmountLabel1.Text), Val(Label33.Text), Val(EOBILabel2.Text), Val(TaxDeductionLabel2.Text), Val(RentDeductionLabel1.Text), Val(lblShortDeducted.Text), IntMealDeductionValue, Val(FairAmountLabel3.Text), Val(RFAMTLabel1.Text))
        'intTotalSubtracts = CalculateSubtracts(Val(AmountLabel1.Text), Val(Label33.Text), Val(EOBILabel2.Text), Val(TaxDeductionLabel2.Text), Val(RentDeductionLabel1.Text), 0)
        intTotalAdds = CalculateAdds(intDueSalary, Val(TravelAllowanceLabel2.Text), Val(EducationAllowanceLabel2.Text), intMealPayable, Val(SpecialAllowanceLabel2.Text), intOverTimePayable, SaniorityValue, Val(Me.AccommodationLabel2.Text), Val(DailyTA.Text), Val(PerDTAPayable.Text))
        intFinalSalary = intTotalAdds - intTotalSubtracts

        LblTotalMealDeduction.Text = Math.Round(IntMealDeductionValue)
        lblTotalMeal.Text = Math.Round(intMealPayable)
        lblOverTime.Text = Math.Round(intOverTimePayable)
        lblAdds.Text = Math.Round(intTotalAdds)
        lblBeforeFinal.Text = Math.Round(intTotalSubtracts)
        lblSalary.Text = Math.Round(intFinalSalary)
        lblExtraDays.Text = intExtraDays
        ChangeColor()

    End Sub

    Private Sub LoadData()
        'This function loads data from tableadapters on each navigation.
        Try
            Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DSCalculateSalary.tbl_Hrm_Emp_Info, Val(CardNoLabel1.Text))

            Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter.Fill(Me.DSCalculateSalary.View_Rpt_PayRoll_EmpAttRecord, Val(EmpIDLabel2.Text), DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            Me.View_Rpt_PayRoll_EmpAttRecord1TableAdapter.Fill(Me.DSCalculateSalary.View_Rpt_PayRoll_EmpAttRecord1, Val(EmpIDLabel2.Text), DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)

            Me.View_Rpt_Acc_OverTimeSumTableAdapter.Fill(Me.DSCalculateSalary.View_Rpt_Acc_OverTimeSum, Val(EmpIDLabel2.Text), DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            Me.Tbl_Hrm_HolidaysTableAdapter.Fill(Me.DSCalculateSalary.tbl_Hrm_Holidays, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.Tbl_Acc_ShortTermAdvancesTableAdapter.Fill(Me.DSCalculateSalary.tbl_Acc_ShortTermAdvances, Val(EmpIDLabel2.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)

            Me.Tbl_PayRoll_LongLeavesTableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            Me.Tbl_PayRoll_LongLeaves1TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves1, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            Me.Tbl_PayRoll_LongLeaves5TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves5, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            'Me.Tbl_PayRoll_LongLeaves3TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves3, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            Me.Tbl_PayRoll_LongLeaves4TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves4, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            Me.Tbl_PayRoll_LongLeaves6TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves6, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            Me.Tbl_PayRoll_LongLeaves7TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves7, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)

            Me.View_Rpt_Acc_MorningShortMinsTableAdapter.Fill(Me.DSCalculateSalary.View_Rpt_Acc_MorningShortMins, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
            Me.View_Rpt_Acc_EveningShortMinsTableAdapter.Fill(Me.DSCalculateSalary.View_Rpt_Acc_EveningShortMins, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)


            Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.DSCalculateSalary.tbl_Acc_Salary, Val(EmpIDLabel2.Text))
            Me.Tbl_Acc_PAdvDeductions1TableAdapter.Fill(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions1, Val(EmpIDLabel2.Text))
            Me.Tbl_Acc_PermanentAdvances1TableAdapter.Fill(Me.DSLongTermAdv.tbl_Acc_PermanentAdvances1, Val(EmpIDLabel2.Text))
            Me.Tbl_Hrm_ExtraWorkingDaysTableAdapter.Fill(Me.DSCalculateSalary.tbl_Hrm_ExtraWorkingDays, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Me.View_Emp_Deduction_DaysTableAdapter.Fill(Me.DSCalculateSalary.View_Emp_Deduction_Days, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year, Val(Me.EmpIDLabel2.Text))
            Try
                Me.Tbl_Acc_RFD_PayTableAdapter.Fill(Me.DSCalculateSalary.tbl_Acc_RFD_Pay, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year, Me.EmpIDLabel2.Text)
            Catch ex As System.Exception
                'System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            Try
                Me.View_Acc_FairShopTableAdapter.Fill(Me.DSCalculateSalary.View_Acc_FairShop, Val(Me.EmpIDLabel2.Text), Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As System.Exception
                'System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            Try
                Me.View_Emp_Meal_AttendanceTableAdapter.Fill(Me.DSCalculateSalary.View_Emp_Meal_Attendance, Val(Me.EmpIDLabel2.Text), Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As System.Exception
                'System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        Try
            Me.View_SP_OTTableAdapter.Fill(Me.DSSP.View_SP_OT, Val(EmpIDLabel2.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InsertSalaryTransaction()
        'This is salary transaction insert funtion
        Dim PessiGrossSalary, PessiSalary, PessiCont, DueSalary As Integer
        If PESSIStatus.Text = False Then
            PessiGrossSalary = 0
            PessiSalary = 0
            PessiCont = 0
        Else
            Dim totaldays As Double = Val(lblTotalDaysWorked.Text) + HolidayCountLabel1.Text
            'DueSalary = Math.Round((Val(GrossSalaryLabel2.Text) / DayCalc) * Val(lblTotalPayableDays.Text))
            DueSalary = Math.Round((Val(GrossSalaryLabel2.Text) / DayCalc) * totaldays)
            If Val(GrossSalaryLabel2.Text) > CInt(Me.DSUser.tbl_Comp_Info.Rows(0).Item("PEESIFIX")) Then
                PessiGrossSalary = CInt(Me.DSUser.tbl_Comp_Info.Rows(0).Item("PEESIFIX"))
            Else
                PessiGrossSalary = Val(GrossSalaryLabel2.Text)
            End If
            If DueSalary > CInt(Me.DSUser.tbl_Comp_Info.Rows(0).Item("PEESIFIX")) Then
                PessiSalary = CInt(Me.DSUser.tbl_Comp_Info.Rows(0).Item("PEESIFIX"))
            Else
                PessiSalary = DueSalary
            End If
            PessiCont = PessiSalary * 0.06
        End If
        'DueSalary = Math.Round((Val(GrossSalaryLabel2.Text) / 26) * Val(lblTotalPayableDays.Text))
        'If Val(GrossSalaryLabel2.Text) > 18000 Then
        '    PessiGrossSalary = 18000
        'Else
        '    PessiGrossSalary = Val(GrossSalaryLabel2.Text)
        'End If
        'If DueSalary > 18000 Then
        '    PessiSalary = 18000
        'Else
        '    PessiSalary = DueSalary
        'End If
        'PessiCont = PessiSalary * 0.06
        'YearValue = DateDiff(DateInterval.Day, CType(DateOfJoiningLabel1.Text, Date), CType("#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Date))
        'If YearValue <= 5 And YearValue > 0 Then
        '    SaniorityAllowance = YearValue * 100
        'Else
        '    SaniorityAllowance = 500
        'End If
        'SaniorityAllowance = 0
        'YearValue = DateDiff(DateInterval.Day, CType(DateOfJoiningLabel1.Text, Date), CType("#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Date))
        'YearValue = Fix(YearValue / 365)
        'If GradeLabel1.Text.Trim = "V" Or GradeLabel1.Text.Trim = "VI" Then
        '    If YearValue <= 5 And YearValue > 0 Then
        '        SaniorityAllowance = YearValue * 100
        '    ElseIf YearValue = 0 Then
        '        SaniorityAllowance = 0
        '    Else
        '        SaniorityAllowance = 500
        '    End If
        'Else
        '    SaniorityAllowance = 0
        'End If

        Dim BasicSalary As Integer
        Dim PerHourSalary As Double
        Dim OTHours As Double
        Dim SPOTAmount As Integer
        Dim Bonus, BADV As Integer

        BasicSalary = Val(GrossSalaryLabel2.Text)
        PerHourSalary = Math.Round(BasicSalary / 26 / 8, 2)
        OTHours = RoundSPOTHours(Val(SPLabel1.Text))
        Dim SPLeave As Double

        If BStatus = True Then
            'Try
            '    Bonus = Tbl_Hrm_Emp_InfoTableAdapter.Bonus(EmpIDLabel2.Text, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            'Catch ex As Exception
            '    Bonus = 0
            'End Try
            Try
                If Me.View_Bonus_SalaryTableAdapter.Fill(Me.DataSet5.View_Bonus_Salary, EmpIDLabel2.Text, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year) > 0 Then
                    Bonus = Me.DataSet5.View_Bonus_Salary.Rows(0).Item("PayableBonus")
                    BADV = Me.DataSet5.View_Bonus_Salary.Rows(0).Item("AmtDedAsLTA")
                Else
                    Bonus = 0
                    BADV = 0
                End If


            Catch ex As System.Exception
                'System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            Bonus = 0
            BADV = 0
        End If


        Try
            SPLeave = Me.Tbl_Hrm_Emp_InfoTableAdapter.SPLeave(Me.EmpIDLabel2.Text, Me.DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        Catch ex As Exception
            SPLeave = 0
        End Try

        'If GradeId = 1 Or GradeId = 2 Or GradeId = 3 Or GradeId = 7 Then
        '    'OTAmount = ((OTHours * PerHourSalary))
        'Else
        SPOTAmount = ((OTHours * PerHourSalary) * 2)
        Dim total As Double = Val(lblSalary.Text) + SPOTAmount + Bonus - BADV
        Dim FinalRFD As Double = total Mod 500
        If FinalRFD > 0 And PaymentModeLabel2.Text = "Cash" Then
            FinalRFD = 500 - FinalRFD
        Else
            FinalRFD = 0
        End If

        Dim RFDPay As Double = Val(RFAMTLabel1.Text)
        Try
            Me.Tbl_Acc_Salary_TransactionsTableAdapter.Insert(Val(EmpIDLabel2.Text), Val(GrossSalaryLabel2.Text), Val(TaxDeductionLabel2.Text), Val(RentDeductionLabel1.Text), Val(EOBILabel2.Text), Val(TravelAllowanceLabel2.Text), Val(EducationAllowanceLabel2.Text), Val(SpecialAllowanceLabel2.Text), Val(MealAllowanceLabel2.Text), PaymentModeLabel2.Text, Val(AdvSumLabel1.Text), Val(Label33.Text), Val(TotalDedLabel1.Text) + Val(Label33.Text), Val(lblRemaining.Text) - Val(Label33.Text) - BADV, Val(AmountLabel1.Text), Nothing, Val(CasualLeaveLabel1.Text), Val(M1Label1.Text), Val(M2Label1.Text), SPLeave, Val(OTALLabel1.Text), Val(PaidLeavesLabel2.Text), Val(UnPaidLeavesLabel2.Text), Val(TotalFullDaysLabel1.Text), Val(TotalHalfDaysLabel1.Text), Val(lblOverTimeHours.Text), Val(lblOverTime.Text), Val(lblAbsents.Text), Val(lblTotalDaysWorked.Text), Val(lblTotalPayableDays.Text), Val(lblTotalMeal.Text), Math.Round(Val(GrossSalaryLabel2.Text) / DayCalc), Math.Round((Val(GrossSalaryLabel2.Text) / DayCalc) * Val(lblTotalPayableDays.Text)), Val(lblSalary.Text), FinancialPeriodComboBox.SelectedValue, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Val(lblMonthDays.Text), Val(lblSundays.Text), Val(HolidayCountLabel1.Text), Val(lblExtraDays.Text), Val(lblWorkingDays.Text), Now.Date, "Normal", "False", "True", Val(lblAdds.Text), Val(lblBeforeFinal.Text) + BADV, Val(lblTotalPayableDays.Text) - Val(PaidLeavesLabel2.Text), Val(MorningShortMinsLabel1.Text), Val(EveningShortMinsLabel1.Text), Val(lblShortAmt.Text), Val(lblShortDeducted.Text), PessiCont, PessiSalary, PessiGrossSalary, IntDedduction, SaniorityValue, Val(Me.EmpCountLabel1.Text), Val(LblTotalMealDeduction.Text), Val(AccommodationLabel2.Text), 0, 0, 0, GradeLabel2.Text, DesigNameLabel1.Text, MainDeptLabel1.Text, SectionNameLabel.Text, OTHours, SPOTAmount, Val(FairAmountLabel3.Text), RFDPay, FinalRFD, Bonus, BADV)
            If SaniorityValue() > 0 Then
                Me.Tbl_Hrm_Emp_InfoTableAdapter.UpdateQuery(Me.EmpIDLabel2.Text)
            End If
            If FinalRFD > 0 Then
                Me.Tbl_Acc_RFD_PayTableAdapter.InsertQuery(Me.EmpIDLabel2.Text, FinalRFD, Now.Date)
            End If
            If Me.IncStatusLabel.Text = True Then
                'Try
                '    If Me.View_Emp_Month_Zero_LeaveTableAdapter.Fill(Me.DSCalculateSalary.View_Emp_Month_Zero_Leave, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Val(lblWorkingDays.Text), Val(EmpIDLabel2.Text)) > 0 Then
                '        Me.Tbl_Hrm_Emp_InfoTableAdapter.UpdateQuery1(Math.Round(Val(GrossSalaryLabel2.Text) / DayCalc), Val(EmpIDLabel2.Text), "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#")
                '    End If
                'Catch ex3 As Exception

                'End Try
            End If
            InsertDeductions(BADV)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function RoundSPOTHours(ByVal OTMinutes As Double) As Double
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
    Private Sub InsertDeductions(BPA As Double)
        'This is deduction insert funtion against long term advances
        If Val(AdvSumLabel1.Text) > 0 Then
            If Val(lblRemaining.Text) > 0 Then
                If CheckBox1.Checked = False Then
                    Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(Val(EmpIDLabel2.Text), Val(Label33.Text) + BPA, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", "Zero Deduction from Salary (Checkbox was Unchecked)", FinancialPeriodComboBox.SelectedValue)
                Else
                    If Val(lblRemaining.Text) - Val(Label33.Text) = 0 Then
                        Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(Val(EmpIDLabel2.Text), Val(Label33.Text) + BPA, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", "Normal Deduction from Salary", FinancialPeriodComboBox.SelectedValue)
                    ElseIf Val(lblRemaining.Text) - Val(Label33.Text) < 0 Then
                        Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(Val(EmpIDLabel2.Text), Val(lblRemaining.Text) + BPA, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", "Normal Deduction from Salary", FinancialPeriodComboBox.SelectedValue)
                    Else
                        Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(Val(EmpIDLabel2.Text), Val(Label33.Text) + BPA, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", "Normal Deduction from Salary", FinancialPeriodComboBox.SelectedValue)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Tbl_Hrm_Emp_Info_HBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_Emp_Info_HBindingSource.PositionChanged
        NavigationFunction()
    End Sub

    Private Sub MaskedTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.TextChanged
        If Label5.Text = "" Or Label5.Text = "Values Over Flow..." Then
            CalculateAllRecords()
        End If
    End Sub

    Private Sub MaskedTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.TextChanged
        If Label5.Text = "" Or Label5.Text = "Values Over Flow..." Then
            CalculateAllRecords()
        End If
    End Sub
    Dim flag As Boolean = False


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'here
        If Button2.Text = "Start To Calculate Salary" Then
            FilePath = PDFPath + "\" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + ".txt"
            If File.Exists(FilePath) Then
            Else
                File.Create(FilePath).Dispose()
            End If
            If Me.CardNoComboBox.Enabled = False Then
                Dim dgResult As DialogResult = MessageBox.Show("Are you sure," & vbCrLf & "You want to Calculate Salary of  [" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + "] With Starting Card No.[" + Me.Label1.Text + " ]?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If dgResult = 6 Then
                    Label6.Text = "Running"
                    Timer1.Start()
                    Timer2.Start()
                    'Thread.Sleep(1000)
                    'Application.DoEvents()
                    flag = True
                End If
            Else
                Dim dgResult As DialogResult = MessageBox.Show("Are you sure," & vbCrLf & "You want to Calculate Salary of  [" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + "] With Starting Card No.[" + Me.CardNoComboBox.Text + " ]?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If dgResult = 6 Then
                    Me.DateTimePicker1.Enabled = False
                    Me.FinancialPeriodComboBox.Enabled = False
                    Me.CardNoComboBox.Enabled = False
                    Label6.Text = "Running"
                    Timer1.Start()
                    Timer2.Start()
                    flag = True
                End If
            End If

        End If
        If Button2.Text = "Stop To Calculate Salary" Then
            flag = False
            Label6.Text = "Stoped!"
        End If
        'Dim I As Integer = Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource.Position
        'For I As Integer = Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource.Position To Me.Tbl_Hrm_Emp_Info_HBindingSource.Count - 1
        '    Me.Tbl_Hrm_Emp_Info_HBindingSource.Position = I
        '    SaveNow()
        '    Thread.Sleep(10)
        '    Application.DoEvents()
        '    ToolStripProgressBar1.Value = I
        'Next
        'End here
    End Sub

    Public Sub frmMonthlySalary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'This function controls navigation of records through key board keys
        'If (e.Control) Then
        '    SaveNow()
        'ElseIf e.KeyCode = Keys.Down Then
        '    Tbl_Hrm_Emp_Info_HBindingSource.Position += 1
        'ElseIf e.KeyCode = Keys.Up Then
        '    Tbl_Hrm_Emp_Info_HBindingSource.Position -= 1
        'End If
    End Sub

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        'This function controls navigation of records through key board keys
        If (e.Control) Then
            SaveNow()
        ElseIf e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position -= 1
        End If
    End Sub

    Private Sub MaskedTextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox2.KeyDown
        'This function controls navigation of records through key board keys
        If (e.Control) Then
            SaveNow()
        ElseIf e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position -= 1
        End If
    End Sub

    Private Sub CheckBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CheckBox1.KeyDown
        'This function controls navigation of records through key board keys
        If (e.Control) Then
            SaveNow()
        ElseIf e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position -= 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'This funtion is used to undo salary transactions.
        Dim PaidCount As Integer
        Dim TransCount As Integer

        'PaidCount = Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy1(Me.DSCalculateSalary.tbl_Acc_Salary_Transactions, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        PaidCount = 0

        TransCount = Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy(Me.DSCalculateSalary.tbl_Acc_Salary_Transactions, Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)

        If PaidCount = 0 Then
            If TransCount = 0 Then
                MsgBox("No Active Salary For This Month, So Undo Fail")
            Else
                Dim dgResults As DialogResult = MessageBox.Show("Are You Sure About the Action You Are Going to Perform?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dgResults = Windows.Forms.DialogResult.Yes Then
                    Try
                        Me.Tbl_Acc_PAdvDeductionsTableAdapter.DeleteDedForSalUndo(Val(EmpIDLabel2.Text), DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                        Me.Tbl_Acc_Salary_TransactionsTableAdapter.DeleteSalTrans(Val(EmpIDLabel2.Text), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                        MsgBox("Record Undo Successfully")
                        NavigationFunction()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        Else
            MsgBox("Salary Have Been Paid Or Not Calculated For this Employee, So Undo Fail")
        End If

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If Label5.Text = "" Or Label5.Text = "Values Over Flow..." Then
            CalculateAllRecords()
        End If
    End Sub

    Private Sub FinancialPeriodComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancialPeriodComboBox.SelectedIndexChanged
        'This function check either valid financial period was selected for salary calculation
        'If invalid is selected then it is reset to the current financial period.
        'Actually Financial Period was not required here to set or reset, it should be automatically selected in beckground
        'So, It can be removed from here in future
        Dim Obj As New UtilityClass()
        If FinancialPeriodComboBox.SelectedValue <> Nothing Then
            If FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) Then
            Else
                MsgBox("Invalid financial period as Per Selected Month or Year")
                FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            End If
        Else
            FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        End If
        NavigationFunction()
    End Sub

    Private Sub FinancialPeriodComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FinancialPeriodComboBox.KeyDown
        'This function controls navigation of records through key board keys
        If e.Control Then
            SaveNow()
        ElseIf e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position -= 1
        End If
    End Sub

    Private Sub TextBox4_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox4.KeyDown
        'This function controls navigation of records through key board keys
        If (e.Control) Then
            SaveNow()
        ElseIf e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position -= 1
        End If
    End Sub

    'Private Sub CardNoComboBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    'This function controls navigation of records through key board keys
    '    If (e.Control) Then
    '        SaveNow()
    '    End If
    'End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            SelectFP()
        Catch ex As Exception
        End Try
        NavigationFunction()
        If MonthFlag = True And flag26 = False Then
            DayCalc = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        ElseIf MonthFlag = False And flag26 = True Then
            DayCalc = 26
        End If
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        'This function controls navigation of records through key board keys
        If (e.Control) Then
            SaveNow()
        ElseIf e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position -= 1
        End If
    End Sub

    Private Sub SelectFP()
        'Here Obj.ReturnFP() function is a utility function that returns financial period by providing Year and Month
        Dim Obj As New UtilityClass()
        If Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) <> Nothing Then
            FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        Else
            MsgBox("Selected year was beyond the running financial period")
            DateTimePicker1.Value = Now.Date
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Label5.Text = "" Or Label5.Text = "Values Over Flow..." Then
            CalculateAllRecords()
        End If
    End Sub

    Private Sub txtSLeaveDeduct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSLeaveDeduct.TextChanged
        'This funtion set or reset short leave deduction amount.
        'i.e either the user wants to deduct short leave amount or not for the selected employee
        If txtSLeaveDeduct.TextLength = 0 Then
            lblBeforeFinal.Text = Val(lblBeforeFinal.Text) - (Val(lblShortDeducted.Text) - Val(txtSLeaveDeduct.Text))
            lblSalary.Text = Val(lblAdds.Text) - Val(lblBeforeFinal.Text)
            lblShortDeducted.Text = Val(txtSLeaveDeduct.Text)
            'CardNoComboBox.Focus()
        Else
            lblBeforeFinal.Text = Val(lblBeforeFinal.Text) - (Val(lblShortDeducted.Text) - Val(txtSLeaveDeduct.Text))
            lblSalary.Text = Val(lblAdds.Text) - Val(lblBeforeFinal.Text)
            lblShortDeducted.Text = Val(txtSLeaveDeduct.Text)
        End If
    End Sub
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function
    Private Sub txtSLeaveDeduct_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSLeaveDeduct.KeyDown
        'This function controls navigation of records through key board keys
        If (e.Control) Then
            SaveNow()
        ElseIf e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_Info_HBindingSource.Position -= 1
        End If
    End Sub
    Dim i As Integer = 0
    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        '
        If flag = True Then
            If Label6.Text.Length = 13 Then
                Label6.Text = "Running"
            Else
                Label6.Text = Label6.Text + "."
            End If
            If Label8.Text = "............." Then
                Label8.Text = "."
            Else
                Label8.Text = Label8.Text + "."
            End If
        Else
            Label6.Text = "Stoped!"
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If flag = True Then
            Button2.BackColor = Color.Maroon
            Button2.ForeColor = Color.Yellow
            Button2.Text = "Stop To Calculate Salary"
            If i < Me.Tbl_Hrm_Emp_Info_HBindingSource.Count Then
                Me.Tbl_Hrm_Emp_Info_HBindingSource.Position = i
                SaveNow()
                ToolStripProgressBar1.Value = i
                i = i + 1
            Else
                ToolStripProgressBar1.Value = 0
                flag = False
                Timer1.Stop()
                Timer2.Stop()
                Label6.Text = "Stoped!"
                Me.Label8.Text = ""
                MsgBox("Auto Monthly Salary Calculated and Saved Successfully", MsgBoxStyle.Information)
                i = 0
                Me.Tbl_Hrm_Emp_Info_HBindingSource.Position = i
                Button2.BackColor = Color.Black
                Button2.ForeColor = Color.Red
                Button2.Text = "Start To Calculate Salary"
            End If

        ElseIf flag = False Then
            Button2.BackColor = Color.Black
            Button2.ForeColor = Color.Red
            Button2.Text = "Start To Calculate Salary"
        End If
    End Sub

    Private Sub Tbl_Hrm_Emp_Info_Cards_InfoBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_Emp_Info_Cards_InfoBindingSource.PositionChanged
        i = Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource.Position
    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TabControl1.SelectedTab = TabPage1
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TabControl1.SelectedTab = TabPage2
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel1_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel2_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel2.MouseEnter
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub LinkLabel2_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel2.MouseLeave
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        'This function opens excel file, update and load into table adapter
        Dim Excelquery As String
        Dim OLEDBConString As String
        Dim OpenFileDialog2 As New OpenFileDialog

        OpenFileDialog2.Filter = "Microsoft Office Excel WorkSheet(*.xls;)|*.xls;|All Files(*.*)|*.*"
        OpenFileDialog2.FilterIndex = 1

        If OpenFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            DataGridView1.DataSource = Nothing
            GlobalPathStr = OpenFileDialog2.FileName.Trim()
            tbFilePath.Text = GlobalPathStr
            'Me.Label12.Text = Nothing
            If GlobalPathStr <> "" Then
                Dim FileExt1 As String = GlobalPathStr.Substring(GlobalPathStr.LastIndexOf(".") + 1)
                If UCase(FileExt1) = "XLS" Or UCase(FileExt1) = "XLSX" Then
                    'Dim result As Int16 = ModifyExcelRecords(GlobalPathStr)
                    Dim result As Integer = 1
                    If result = 1 Then
                        Try
                            OLEDBConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & GlobalPathStr & ";Extended Properties=Excel 8.0;"
                            'OLEDBConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GlobalPathStr & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=2"""
                            'OLEDBConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GlobalPathStr & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=2"""
                            Excelquery = "SELECT CardNo,Arrears from [Sheet1$]"
                            'Excelquery = "SELECT CardNo,EOBI from [Sheet3$]"
                            Dim LoadExcelAdapter As New OleDbDataAdapter(Excelquery, OLEDBConString)
                            Dim DSLoadExcel As DataSet = New DataSet()
                            LoadExcelAdapter.Fill(DSLoadExcel)
                            DataGridView1.DataSource = DSLoadExcel.Tables(0)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    ElseIf result = 0 Then
                        MessageBox.Show("Invalid Excel File Selected")
                    End If
                Else
                    MessageBox.Show("Open Excel File only")
                End If
            Else
                MessageBox.Show("No File Selected")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Salalrymonth As Date = FirstDayOfMonth(Me.DateTimePicker5.Text)
        Dim LoadCount As Integer
        Dim ExcelCard As Integer
        Dim ExcelArrears As Integer
        'Dim EOBI As String
        Dim Returns As Integer

        LoadCount = Me.DataGridView1.RowCount

        If LoadCount = 0 Then
            MsgBox("Select Valid Excel File and Then Continue")
        Else
            Dim DResult As DialogResult = MessageBox.Show("Are You Sure About The Action!", "Salary Upgrade", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If DResult = 6 Then
                For i As Integer = 0 To LoadCount - 1
                    ExcelCard = Me.DataGridView1(0, i).Value
                    ExcelArrears = Me.DataGridView1(1, i).Value
                    Dim obj As New UtilityClass
                    'Dim FP As String = obj.ReturnFP(Now.Date.Month, Now.Date.Year)
                    Try
                        Returns = Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DSCalculateSalary.tbl_Hrm_Emp_Info, ExcelCard)
                    Catch ex As Exception
                    End Try
                    If Returns = 1 Then
                        Dim EmpID As Int16 = Me.DSCalculateSalary.tbl_Hrm_Emp_Info.Rows(0).Item("EmpID")
                        Me.Tbl_Acc_Salary_TransactionsTableAdapter.UpdateArrears(ExcelArrears, Salalrymonth, EmpID)
                        PaintGrid(0, i, Color.DarkGreen, Color.White)
                        PaintGrid(1, i, Color.DarkGreen, Color.White)
                    Else
                        PaintGrid(0, i, Color.Red, Color.White)
                        PaintGrid(1, i, Color.Red, Color.White)

                    End If
                Next

                MsgBox("Record Saved")
            End If
        End If
    End Sub
    Sub PaintGrid(ByVal i As Int16, ByVal j As Int16, ByVal BackColor As System.Drawing.Color, ByVal ForeColored As System.Drawing.Color)

        Me.DataGridView1(i, j).Style.BackColor = BackColor
        Me.DataGridView1(i, j).Style.ForeColor = ForeColored


    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab.Text = "Arrears" Then
            Label16.Visible = True
            Label17.Visible = True
            Label11.Visible = True
            Label12.Visible = True

        Else
            Label16.Visible = False
            Label17.Visible = False
            Label11.Visible = False
            Label12.Visible = False
        End If
    End Sub


End Class