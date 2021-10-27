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
    'Function SaniorityValue() As Integer
    '    Dim SaniorityAllowance, YearValue As Integer
    '    Try
    '        SaniorityAllowance = 0
    '        YearValue = DateDiff(DateInterval.Day, CType(DateOfJoiningLabel1.Text, Date), CType("#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Date))
    '        YearValue = Fix(YearValue / 365)
    '        If SenStatusLabel3.Text = True Or GradeLabel2.Text.Trim = "A+" Or GradeLabel2.Text.Trim = "S-2" Or GradeLabel2.Text.Trim = "A" Or GradeLabel2.Text.Trim = "B" Or GradeLabel2.Text.Trim = "C" Or GradeLabel2.Text.Trim = "D" Then
    '            If YearValue <= 5 And YearValue > 0 Then
    '                SaniorityAllowance = YearValue * 250
    '            ElseIf YearValue = 0 Then
    '                SaniorityAllowance = 0
    '            Else
    '                SaniorityAllowance = 1250
    '            End If
    '        Else
    '            SaniorityAllowance = 0
    '        End If
    '    Catch ex As Exception
    '        SaniorityAllowance = 0
    '    End Try

    '    Return SaniorityAllowance
    'End Function
    Private Sub frmMonthlySalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAutoCalc.tbl_Emp_Salary_Calculation_Adj' table. You can move, or remove it, as needed.
        'Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter.Fill(Me.DSAutoCalc.tbl_Emp_Salary_Calculation_Adj)
        'TODO: This line of code loads data into the 'DSAutoCalc.tbl_Acc_Salary_Transactions' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSAutoCalc.View_HRMS' table. You can move, or remove it, as needed.
        Me.View_HRMSTableAdapter.Fill(Me.DSAutoCalc.View_HRMS)
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        Try
            'Me.Tbl_Hrm_Emp_Info_Cards_InfoTableAdapter.FillBy(Me.DSCalculateSalary.tbl_Hrm_Emp_Info_Cards_Info)
        Catch ex As Exception

        End Try

        'Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)

        Try
            'Me.Tbl_Hrm_Emp_Info_HTableAdapter.FillBy(Me.DSCalculateSalary.View_HRMS)
        Catch ex As Exception

        End Try

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
        ToolStripProgressBar1.Maximum = Me.View_HRMSBindingSource.Count - 1

    End Sub
    Dim BStatus As Boolean = False

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


    Dim IntDedduction As Integer = 0




    'Private Sub LoadData()
    '    'This function loads data from tableadapters on each navigation.
    '    Try

    '        Me.View_Emp_Deduction_DaysTableAdapter.Fill(Me.DSCalculateSalary.View_Emp_Deduction_Days, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year, Val(Me.EmpIDLabel2.Text))
    '    Catch ex As Exception
    '    End Try

    'End Sub

    Private Sub InsertSalaryTransaction()



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
                    'Me.FinancialPeriodComboBox.Enabled = False
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
        StartFlag = True
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
    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function

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
            If i < Me.View_HRMSBindingSource.Count Then
                Me.View_HRMSBindingSource.Position = i
                SaveRecord()
                'Thread.Sleep(100)
                'Application.DoEvents()
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
                Me.View_HRMSBindingSource.Position = i
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

    Private Sub Tbl_Hrm_Emp_Info_Cards_InfoBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs)

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
                        'Returns = Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DSCalculateSalary.tbl_Hrm_Emp_Info, ExcelCard)
                    Catch ex As Exception
                    End Try
                    If Returns = 1 Then
                        Dim EmpID As Int16 = Me.DSCalculateSalary.tbl_Hrm_Emp_Info.Rows(0).Item("EmpID")
                        'Me.Tbl_Acc_Salary_TransactionsTableAdapter.UpdateArrears(ExcelArrears, Salalrymonth, EmpID)
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
    Dim StartFlag As Boolean = False
    Dim FP As String
    Private Sub View_HRMSBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles View_HRMSBindingSource.PositionChanged

        i = Me.View_HRMSBindingSource.Position

    End Sub
    Private Sub SaveRecord()
        'If StartFlag = True Then
        Try
                Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy2(Me.DSAutoCalc.tbl_Acc_Salary_Transactions, Me.EmpIDLabel1.Text, Me.DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
            Catch ex As Exception

            End Try

        If Me.Tbl_Acc_Salary_TransactionsBindingSource.Count > 0 Then

            ErrorFileWriter(FilePath, "CardNo: [" & Me.CardNoComboBox.Text & "] , Message: [Salary Already Saved or Values are Over Flowing]")
        Else
            Try
                    Me.View_Salary_PaidLeavesTableAdapter.Fill(Me.DSAutoCalc.View_Salary_PaidLeaves, EmpIDLabel1.Text, Me.DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                Catch ex As System.Exception

                End Try
                Try
                    Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter.Fill(Me.DSAutoCalc.View_Rpt_PayRoll_EmpAttRecord, EmpIDLabel1.Text, Me.DateTimePicker1.Value.Year, Me.DateTimePicker1.Value.Month)
                Catch ex As System.Exception

                End Try
                Try
                    Me.View_Rpt_Acc_OverTimeSumTableAdapter.Fill(Me.DSAutoCalc.View_Rpt_Acc_OverTimeSum, Me.EmpIDLabel1.Text, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
                Catch ex As System.Exception

                End Try
                Try
                    Me.View_Acc_RFD_PayTableAdapter.Fill(Me.DSAUTO.View_Acc_RFD_Pay, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year, EmpIDLabel1.Text)
                Catch ex As System.Exception

                End Try

                Try
                    Me.View_Emp_Meal_AttendanceTableAdapter.Fill(Me.DSAUTO.View_Emp_Meal_Attendance, EmpIDLabel1.Text, DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
                Catch ex As System.Exception

                End Try

                Try
                    Me.View_Acc_FairShopTableAdapter.Fill(Me.DSAUTO.View_Acc_FairShop, Me.EmpIDLabel1.Text, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                Catch ex As System.Exception

                End Try
                Try
                    Me.View_Acc_Emp_MaxAdvance_DedRateTableAdapter.Fill(Me.DSAUTO.View_Acc_Emp_MaxAdvance_DedRate, EmpIDLabel1.Text)
                Catch ex As System.Exception

                End Try

                Try
                    Me.View_Acc_Adv_BalanceTableAdapter.Fill(Me.DSAUTO.View_Acc_Adv_Balance, EmpIDLabel1.Text)
                Catch ex As System.Exception

                End Try

                Try
                    Me.Tbl_Acc_ShortTermAdvancesTableAdapter.Fill(Me.DSAUTO.tbl_Acc_ShortTermAdvances, Me.DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, Me.EmpIDLabel1.Text)
                Catch ex As System.Exception

                End Try
                Try
                    Me.View_SP_OTTableAdapter.Fill(Me.DSSP.View_SP_OT, EmpIDLabel1.Text, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                Catch ex As System.Exception

                End Try
            Dim TotalAdds As Integer = 0
            Dim Incentive As Double = 0
            Dim TotalSub As Integer = 0
                Dim TWorkingdays As Int16 = SundayCount
                Dim TSundays As Int16 = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month) - CalculateWorkingDays()
                Dim HolidayCount As Int16 = Val(Me.HolidayCountLabel1.Text)
            Dim TotalWorkingDays As Int16 = SundayCount - HolidayCount
            Try
                If Me.Tbl_Acc_INCTableAdapter.Fill(Me.DSCalculateSalary.tbl_Acc_INC, Me.EmpIDLabel1.Text, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) > 0 Then
                    Incentive = Me.DSCalculateSalary.tbl_Acc_INC.Rows(0).Item("Amt")
                Else
                    Incentive = 0
                End If
            Catch ex As System.Exception
                Incentive = 0
            End Try


            Dim Payabledays As Double = 26 - (TotalWorkingDays - (Val(FullDaysLabel1.Text) + Val(HalfDaysLabel1.Text) + Val(PaidLabel1.Text)))
            If CType(DateOfJoningLabel1.Text, Date).Month = Me.DateTimePicker1.Value.Month And CType(DateOfJoningLabel1.Text, Date).Year = Me.DateTimePicker1.Value.Year Then
                Try
                    Me.View_Emp_Deduction_Days_NEWTableAdapter.Fill(Me.DSAutoCalc.View_Emp_Deduction_Days_NEW, Me.DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, Me.EmpIDLabel1.Text)
                Catch ex As System.Exception

                End Try
                Payabledays = Val(FullDaysLabel1.Text) + Val(HalfDaysLabel1.Text) + Val(PaidLabel1.Text) + Val(HolidayCountLabel1.Text) - Val(DayDeductionLabel1.Text)
            End If
            If Payabledays > 26 Then
                Payabledays = 26
            End If

            Dim DueSalary As Double = Val(BasicSalaryLabel1.Text) / 26 * Payabledays
            Dim NormalOTHRS As Double = Val(FullMinutesWorkedLabel1.Text) / 60
            Dim NormalOTAmt As Integer = ((Val(BasicSalaryLabel1.Text) / 26 / 8) * NormalOTHRS) * 2
            Dim SpOt As Double = Val(Me.SPLabel1.Text) / 60
            Dim SPAmt As Integer = ((Val(BasicSalaryLabel1.Text) / 26 / 8) * SpOt) * 2
                Dim MealPayable As Double = (Val(FullDaysLabel1.Text) + Val(HalfDaysLabel1.Text)) * Val(MealAllowanceLabel1.Text)

                Dim CanteenDed As Double = Val(Me.EmpCountLabel2.Text) * Val(ConteenDeductLabel1.Text)

                Dim DedRate As Double = 0
                If Val(PBalanceLabel1.Text) > Val(DedRateLabel1.Text) Then
                    DedRate = Val(DedRateLabel1.Text)
                Else
                    DedRate = Val(PBalanceLabel1.Text)
                End If
                Dim RFDPay As Double = Val(RFAMTLabel1.Text)

            TotalAdds = DueSalary + SaniorityValue(LabelSenAll.Text) + Val(SpecialAllowanceLabel1.Text) + Val(EducationAllowanceLabel1.Text) + Val(TravelAllowanceLabel1.Text) + Val(AccommodationLabel1.Text) + MealPayable + NormalOTAmt + 0

            TotalSub = RFDPay + Val(TaxDeductionLabel1.Text) + Val(RentDeductionLabel1.Text) + Val(EOBILabel1.Text) + Val(UnionFundLabel1.Text) + Val(TempAdvLabel1.Text) + Val(FairPriceLabel1.Text) + CanteenDed + DedRate
                Dim TotalPAdv, PayBack, Remaining As Double
                Try
                    TotalPAdv = Me.DSAUTO.View_Acc_Adv_Balance.Rows(0).Item("TotalAdvance")

                Catch ex As Exception
                    TotalPAdv = 0
                End Try
                Try
                    Remaining = Me.DSAUTO.View_Acc_Adv_Balance.Rows(0).Item("TotalAdvance") - Me.DSAUTO.View_Acc_Adv_Balance.Rows(0).Item("DedAmount") - DedRate
                Catch ex As Exception
                    Remaining = 0
                End Try
                Try
                    PayBack = Me.DSAUTO.View_Acc_Adv_Balance.Rows(0).Item("DedAmount") + DedRate
                Catch ex As Exception

                End Try

            Dim total As Double = TotalAdds - TotalSub + SPAmt + Incentive
            Dim FinalRFD As Double = total Mod 500
            If FinalRFD > 0 And PaymentModeLabel1.Text = "Cash" Then
                FinalRFD = 500 - FinalRFD
            Else
                FinalRFD = 0
            End If
            Dim PessISalary As Integer
            Dim PessiCont As Int16
            lblAdds.Text = TotalAdds
            lblBeforeFinal.Text = TotalSub
            lblSalary.Text = TotalAdds - TotalSub
            'Dim PAdv As Int16 = Val(AdvSumLabel1.Text)
            'Me.Tbl_Acc_Salary_TransactionsTableAdapter.Insert(Me.EmpIDLabel1.Text, Me.BasicSalaryLabel1.Text, Me.TaxDeductionLabel1.Text, Me.RentDeductionLabel1.Text, Me.UnionFundLabel1.Text, Me.EOBILabel1.Text, Me.SpecialAllowanceLabel1.Text, Me.TravelAllowanceLabel1.Text, Me.EducationAllowanceLabel1.Text, Me.MealAllowanceLabel1.Text, Me.AccommodationLabel1.Text, Me.PaymentModeLabel1.Text, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, False, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,)
            If Payabledays < 5 Then
                Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter.Insert(Me.EmpIDLabel1.Text, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Me.BasicSalaryLabel1.Text, Nothing, Now.Date, 0, 0, GradeNameLabel1.Text, DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month), Me.HolidayCountLabel1.Text, Val(FullDaysLabel1.Text) + Val(HalfDaysLabel1.Text))
                ErrorFileWriter(FilePath, "CardNo: [" & Me.CardNoComboBox.Text & "] , Message: [Number of Working Days are Less than 5.]")
            Else
                If TotalAdds - TotalSub > 0 Then
                    If PESSIContLabel1.Text = True Then
                        PessISalary = CInt(Me.DSUser.tbl_Comp_Info.Rows(0).Item("PEESIFIX"))
                        If Val(BasicSalaryLabel1.Text) > PessISalary Then
                        Else
                            PessISalary = Val(BasicSalaryLabel1.Text)
                        End If
                        PessiCont = (PessISalary / 26) * (Val(FullDaysLabel1.Text) + Val(HalfDaysLabel1.Text)) * 0.06
                    End If
                    Try
                        Me.Tbl_Acc_Salary_TransactionsTableAdapter.Insert(Val(EmpIDLabel1.Text), Val(BasicSalaryLabel1.Text), Val(TaxDeductionLabel1.Text), Val(RentDeductionLabel1.Text), Val(EOBILabel1.Text), Val(TravelAllowanceLabel1.Text), Val(EducationAllowanceLabel1.Text), Val(SpecialAllowanceLabel1.Text), Val(MealAllowanceLabel1.Text), PaymentModeLabel1.Text, TotalPAdv, DedRate, PayBack, Remaining, Val(TempAdvLabel1.Text), Nothing, Val(CasualLabel1.Text), Val(SickLabel1.Text), Val(M2Label1.Text), Val(SpecialLabel1.Text), 0, Val(PaidLabel1.Text), 0, Val(FullDaysLabel1.Text), Val(HalfDaysLabel1.Text), NormalOTHRS, NormalOTAmt, 26 - Payabledays, Val(FullDaysLabel1.Text) + Val(HalfDaysLabel1.Text), Payabledays, MealPayable, Val(BasicSalaryLabel1.Text) / 26, DueSalary, TotalAdds - TotalSub, FP, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month), TSundays, Val(HolidayCountLabel1.Text), 0, TotalWorkingDays, Now.Date, "Normal", "False", "True", TotalAdds, TotalSub, Val(FullDaysLabel1.Text) + Val(HalfDaysLabel1.Text), 0, 0, 0, 0, PessiCont, PessISalary, PessISalary, Val(DayDeductionLabel1.Text), SaniorityValue(LabelSenAll.Text), Val(Me.EmpCountLabel1.Text), CanteenDed, Val(AccommodationLabel1.Text), 0, Val(Me.HalfDaysLabel1.Text), 0, Me.GradeNameLabel1.Text, Me.DesigNameLabel1.Text, Me.DeptNameLabel1.Text, SectionNameLabel1.Text, SpOt, SPAmt, Val(FairPriceLabel1.Text), RFDPay, FinalRFD, 0, 0, Val(AnnualLabel1.Text), Incentive, "Auto")
                    Catch ex As Exception

                    End Try
                Else
                    Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter.Insert(Me.EmpIDLabel1.Text, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Me.BasicSalaryLabel1.Text, Nothing, Now.Date, 0, 0, GradeNameLabel1.Text, DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month), Me.HolidayCountLabel1.Text, Val(FullDaysLabel1.Text) + Val(HalfDaysLabel1.Text))
                    ErrorFileWriter(FilePath, "CardNo: [" & Me.CardNoComboBox.Text & "] , Message: [Value Over Flow]")
                End If

                If DedRate > 0 Then
                    ' Me.Tbl_Acc_PAdvDeductionsTableAdapter.Insert(Val(EmpIDLabel2.Text), Val(Label33.Text) + BPA, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", "Normal Deduction from Salary", FinancialPeriodComboBox.SelectedValue)
                    Me.View_Acc_RFD_PayTableAdapter.InsertQuery1(Val(EmpIDLabel1.Text), DedRate, "Normal Deduction from Salary", False, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", FP)
                End If
                If SaniorityValue(LabelSenAll.Text) > 0 Then
                    'Me.View_HRMSTableAdapter.UpdateQuery(Me.EmpIDLabel1.Text)
                End If
                If FinalRFD > 0 Then
                    Me.Tbl_Acc_RFD_PayTableAdapter.InsertQuery(Me.EmpIDLabel1.Text, FinalRFD, Now.Date)
                End If

            End If



        End If
    End Sub
    Dim obj As New UtilityClass
    Function SaniorityValue(Sen As Integer) As Integer
        'Dim SaniorityAllowance, YearValue As Integer
        'Try
        '    SaniorityAllowance = 0
        '    YearValue = DateDiff(DateInterval.Day, CType(DateOfJoningLabel1.Text, Date), CType("#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Date))
        '    YearValue = Fix(YearValue / 365)
        '    If SenStatusLabel1.Text = True Or GradeNameLabel1.Text.Trim = "A+" Or GradeNameLabel1.Text.Trim = "S-2" Or GradeNameLabel1.Text.Trim = "A" Or GradeNameLabel1.Text.Trim = "B" Or GradeNameLabel1.Text.Trim = "C" Or GradeNameLabel1.Text.Trim = "D" Then
        '        If YearValue <= 5 And YearValue > 0 Then
        '            SaniorityAllowance = YearValue * 250
        '        ElseIf YearValue = 0 Then
        '            SaniorityAllowance = 0
        '        Else
        '            SaniorityAllowance = 1250
        '        End If
        '    Else
        '        SaniorityAllowance = 0
        '    End If
        'Catch ex As Exception
        '    SaniorityAllowance = 0
        'End Try

        'Return SaniorityAllowance
        Return Sen
    End Function
    Dim SundayCount As Int16
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Me.Tbl_Hrm_HolidaysTableAdapter.Fill(Me.DSAUTO.tbl_Hrm_Holidays, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        Catch ex As System.Exception

        End Try
        SundayCount = CalculateWorkingDays()
        FP = obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
    End Sub


End Class
