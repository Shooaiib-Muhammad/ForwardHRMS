<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoSalCalculation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label25 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RFAMTLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_RFD_PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSCalculateSalary = New ERP_HRMS.DSCalculateSalary()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.lblBeforeFinal = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.lblAdds = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.IncStatusLabel = New System.Windows.Forms.Label()
        Me.View_Acc_EmpDeptsAndJoiningsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradeLabel2 = New System.Windows.Forms.Label()
        Me.DayDeductionLabel1 = New System.Windows.Forms.Label()
        Me.View_Emp_Deduction_DaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PESSIStatus = New System.Windows.Forms.Label()
        Me.Tbl_Acc_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label33 = New System.Windows.Forms.Label()
        Me.SpecialAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.GradeLabel1 = New System.Windows.Forms.Label()
        Me.EndOfContractDateLabel1 = New System.Windows.Forms.Label()
        Me.EndOfProbationDateLabel1 = New System.Windows.Forms.Label()
        Me.DateOfJoiningLabel1 = New System.Windows.Forms.Label()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.SubDept1Label1 = New System.Windows.Forms.Label()
        Me.MainDeptLabel1 = New System.Windows.Forms.Label()
        Me.OTALLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentDeductionLabel1 = New System.Windows.Forms.Label()
        Me.PaymentModeLabel2 = New System.Windows.Forms.Label()
        Me.MealAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.AmountLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_ShortTermAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EducationAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.TravelAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.EOBILabel2 = New System.Windows.Forms.Label()
        Me.TaxDeductionLabel2 = New System.Windows.Forms.Label()
        Me.GrossSalaryLabel2 = New System.Windows.Forms.Label()
        Me.FatherNameLabel2 = New System.Windows.Forms.Label()
        Me.NameLabel2 = New System.Windows.Forms.Label()
        Me.EmpIDLabel2 = New System.Windows.Forms.Label()
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.TotalHalfDaysLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalFullDaysLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTotalMeal = New System.Windows.Forms.Label()
        Me.lblTotalPayableDays = New System.Windows.Forms.Label()
        Me.lblTotalDaysWorked = New System.Windows.Forms.Label()
        Me.lblAbsents = New System.Windows.Forms.Label()
        Me.UnPaidLeavesLabel2 = New System.Windows.Forms.Label()
        Me.M2Label1 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.M1Label1 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaidLeavesLabel2 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpecialLeaveLabel1 = New System.Windows.Forms.Label()
        Me.CasualLeaveLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FullMinutesWorkedLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_OverTimeSumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PAdvDedRateLabel1 = New System.Windows.Forms.Label()
        Me.AdvSumLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_PermanentAdvances1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSLongTermAdv = New ERP_HRMS.DSLongTermAdv()
        Me.TotalDedLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_PAdvDeductions1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.lblExtraDays = New System.Windows.Forms.Label()
        Me.lblWorkingDays = New System.Windows.Forms.Label()
        Me.HolidayCountLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSundays = New System.Windows.Forms.Label()
        Me.lblMonthDays = New System.Windows.Forms.Label()
        Me.Tbl_Acc_Salary_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblOverTimeHours = New System.Windows.Forms.Label()
        Me.lblOverTime = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TotalLeavesLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tbl_Acc_PAdvDeductions1TableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductions1TableAdapter()
        Me.Tbl_Acc_PermanentAdvances1TableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PermanentAdvances1TableAdapter()
        Me.Tbl_Acc_PAdvDeductionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_PAdvDeductionsTableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductionsTableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_Acc_SalaryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_SalaryTableAdapter1 = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_SalaryTableAdapter()
        Me.lblShortAmt = New System.Windows.Forms.Label()
        Me.lblTotalShortMinutes = New System.Windows.Forms.Label()
        Me.txtSLeaveDeduct = New System.Windows.Forms.TextBox()
        Me.MorningShortMinsLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_MorningShortMinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EveningShortMinsLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_EveningShortMinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblShortDeducted = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.View_Emp_Meal_AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblTotalMealDeduction = New System.Windows.Forms.Label()
        Me.EmpCountLabel1 = New System.Windows.Forms.Label()
        Me.SenStatusLabel3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.AccommodationLabel2 = New System.Windows.Forms.Label()
        Me.CanteenLabel = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_Info_HTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_Info_HTableAdapter()
        Me.Tbl_Hrm_Emp_InfoTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_InfoTableAdapter()
        Me.Tbl_Acc_SalaryTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_SalaryTableAdapter()
        Me.Tbl_Hrm_HolidaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_HolidaysTableAdapter()
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter()
        Me.Tbl_PayRoll_LongLeavesTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeavesTableAdapter()
        Me.Tbl_PayRoll_LongLeaves1TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves1TableAdapter()
        Me.Tbl_PayRoll_LongLeaves4TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves4TableAdapter()
        Me.Tbl_Acc_Salary_TransactionsTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter()
        Me.Tbl_PayRoll_LongLeaves5TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves5TableAdapter()
        Me.Tbl_PayRoll_LongLeaves7TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves7TableAdapter()
        Me.Tbl_PayRoll_LongLeaves6TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves6TableAdapter()
        Me.View_Rpt_Acc_OverTimeSumTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_OverTimeSumTableAdapter()
        Me.Tbl_Hrm_ExtraWorkingDaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_ExtraWorkingDaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_ExtraWorkingDaysTableAdapter()
        Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecordTableAdapter()
        Me.View_Rpt_PayRoll_EmpAttRecord1TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecord1TableAdapter()
        Me.View_Rpt_Acc_MorningShortMinsTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_MorningShortMinsTableAdapter()
        Me.View_Rpt_Acc_EveningShortMinsTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_EveningShortMinsTableAdapter()
        Me.Tbl_Hrm_Emp_Info_Cards_InfoTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_Info_Cards_InfoTableAdapter()
        Me.View_Emp_Deduction_DaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Deduction_DaysTableAdapter()
        Me.View_Emp_Meal_AttendanceTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Meal_AttendanceTableAdapter()
        Me.View_Acc_EmpDeptsAndJoiningsTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Acc_EmpDeptsAndJoiningsTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSCalculateSalaryTableAdapters.TableAdapterManager()
        Me.EmpIDLabel1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.View_Emp_Month_Zero_LeaveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_Month_Zero_LeaveTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Month_Zero_LeaveTableAdapter()
        Me.SectionNameLabel = New System.Windows.Forms.Label()
        Me.Tbl_Emp_Salary_Calculation_AdjBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Emp_Salary_Calculation_AdjTableAdapter()
        Me.DSSP = New ERP_HRMS.DSSP()
        Me.View_SP_OTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_SP_OTTableAdapter = New ERP_HRMS.DSSPTableAdapters.View_SP_OTTableAdapter()
        Me.SPLabel1 = New System.Windows.Forms.Label()
        Me.View_Acc_FairShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Acc_FairShopTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Acc_FairShopTableAdapter()
        Me.FairAmountLabel3 = New System.Windows.Forms.Label()
        Me.DailyTA = New System.Windows.Forms.Label()
        Me.PerDTA = New System.Windows.Forms.Label()
        Me.PerDTAPayable = New System.Windows.Forms.Label()
        Me.Tbl_Acc_RFD_PayTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_RFD_PayTableAdapter()
        Me.DataSet5 = New ERP_HRMS.DataSet5()
        Me.View_Bonus_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Bonus_SalaryTableAdapter = New ERP_HRMS.DataSet5TableAdapters.View_Bonus_SalaryTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.DataSet5TableAdapters.TableAdapterManager()
        Label25 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Acc_RFD_PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCalculateSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_EmpDeptsAndJoiningsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Deduction_DaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_OverTimeSumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PermanentAdvances1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSLongTermAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PAdvDeductions1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.Tbl_PayRoll_LongLeaves6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_SalaryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_MorningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_EveningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.View_Emp_Meal_AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_ExtraWorkingDaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Month_Zero_LeaveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Emp_Salary_Calculation_AdjBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_SP_OTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_FairShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Bonus_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label25
        '
        Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label25.Location = New System.Drawing.Point(17, 89)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(61, 20)
        Label25.TabIndex = 0
        Label25.Text = "OT Hours:"
        Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(11, 119)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(117, 30)
        Label4.TabIndex = 3
        Label4.Text = "Card No.:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Label10.BackColor = System.Drawing.Color.Transparent
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.Black
        Label10.Location = New System.Drawing.Point(11, 94)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(117, 20)
        Label10.TabIndex = 105
        Label10.Text = "Starting Card No.:"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RFAMTLabel1)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.CardNoComboBox)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.lblBeforeFinal)
        Me.Panel1.Controls.Add(Me.lblSalary)
        Me.Panel1.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Panel1.Controls.Add(Me.lblAdds)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 395)
        Me.Panel1.TabIndex = 9
        '
        'RFAMTLabel1
        '
        Me.RFAMTLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RFAMTLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_RFD_PayBindingSource, "RFAMT", True))
        Me.RFAMTLabel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RFAMTLabel1.Location = New System.Drawing.Point(333, 64)
        Me.RFAMTLabel1.Name = "RFAMTLabel1"
        Me.RFAMTLabel1.Size = New System.Drawing.Size(71, 23)
        Me.RFAMTLabel1.TabIndex = 121
        Me.RFAMTLabel1.Text = "Label43"
        Me.RFAMTLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_Acc_RFD_PayBindingSource
        '
        Me.Tbl_Acc_RFD_PayBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_RFD_Pay"
        Me.Tbl_Acc_RFD_PayBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Tbl_Hrm_Emp_InfoBindingSource
        '
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataMember = "tbl_Hrm_Emp_Info_H_tbl_Hrm_Emp_Info"
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        '
        'Tbl_Hrm_Emp_Info_HBindingSource
        '
        Me.Tbl_Hrm_Emp_Info_HBindingSource.DataMember = "tbl_Hrm_Emp_Info_H"
        Me.Tbl_Hrm_Emp_Info_HBindingSource.DataSource = Me.DSCalculateSalary
        '
        'DSCalculateSalary
        '
        Me.DSCalculateSalary.DataSetName = "DSCalculateSalary"
        Me.DSCalculateSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(10, 266)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(295, 21)
        Me.CheckBox3.TabIndex = 108
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.Text = "Un-Check For Zero Meal Allowance"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.BackColor = System.Drawing.Color.White
        Me.CardNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_Info_HBindingSource, "CardNo", True))
        Me.CardNoComboBox.DataSource = Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(129, 93)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(128, 21)
        Me.CardNoComboBox.TabIndex = 104
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'Tbl_Hrm_Emp_Info_Cards_InfoBindingSource
        '
        Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource.DataMember = "tbl_Hrm_Emp_Info_Cards_Info"
        Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource.DataSource = Me.DSCalculateSalary
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(11, 233)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 30)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Final Amt :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(11, 195)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 30)
        Me.Label26.TabIndex = 102
        Me.Label26.Tag = "Sum of P Adv, T Adv, EOBI, Tax, Rent"
        Me.Label26.Text = "Total Subtracts"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label35.Location = New System.Drawing.Point(11, 157)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(117, 30)
        Me.Label35.TabIndex = 101
        Me.Label35.Text = "Total Adds"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_Info_HBindingSource, "CardNo", True))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(129, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 79
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(271, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 137)
        Me.Label8.TabIndex = 77
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(537, 25)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Select Appropriate Month To Calculate Auto Salary"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(537, 14)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Stoped!"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(129, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 28
        Me.DateTimePicker1.TabStop = False
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(11, 64)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(117, 20)
        Me.Label34.TabIndex = 26
        Me.Label34.Text = "Financial Period:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeforeFinal
        '
        Me.lblBeforeFinal.BackColor = System.Drawing.Color.White
        Me.lblBeforeFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeforeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeforeFinal.ForeColor = System.Drawing.Color.Black
        Me.lblBeforeFinal.Location = New System.Drawing.Point(129, 195)
        Me.lblBeforeFinal.Name = "lblBeforeFinal"
        Me.lblBeforeFinal.Size = New System.Drawing.Size(128, 30)
        Me.lblBeforeFinal.TabIndex = 22
        Me.lblBeforeFinal.Tag = "Sum of P Adv, T Adv, EOBI, Tax, Rent"
        Me.lblBeforeFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalary
        '
        Me.lblSalary.BackColor = System.Drawing.Color.Green
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblSalary.ForeColor = System.Drawing.Color.White
        Me.lblSalary.Location = New System.Drawing.Point(129, 233)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(128, 30)
        Me.lblSalary.TabIndex = 19
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_FinancialPeriodBindingSource, "FinancialPeriod", True))
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(129, 63)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(176, 21)
        Me.FinancialPeriodComboBox.TabIndex = 25
        Me.FinancialPeriodComboBox.TabStop = False
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.HRMDBDataSet1
        '
        'HRMDBDataSet1
        '
        Me.HRMDBDataSet1.DataSetName = "HRMDBDataSet1"
        Me.HRMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblAdds
        '
        Me.lblAdds.BackColor = System.Drawing.Color.White
        Me.lblAdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdds.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblAdds.ForeColor = System.Drawing.Color.Black
        Me.lblAdds.Location = New System.Drawing.Point(129, 157)
        Me.lblAdds.Name = "lblAdds"
        Me.lblAdds.Size = New System.Drawing.Size(128, 30)
        Me.lblAdds.TabIndex = 24
        Me.lblAdds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Month:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Cambria", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(214, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(243, 76)
        Me.Button2.TabIndex = 54
        Me.Button2.TabStop = False
        Me.Button2.Text = "Start To Calculate Salary"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'IncStatusLabel
        '
        Me.IncStatusLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IncStatusLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "IncStatus", True))
        Me.IncStatusLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.IncStatusLabel.Location = New System.Drawing.Point(75, 483)
        Me.IncStatusLabel.Name = "IncStatusLabel"
        Me.IncStatusLabel.Size = New System.Drawing.Size(25, 20)
        Me.IncStatusLabel.TabIndex = 110
        Me.IncStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Acc_EmpDeptsAndJoiningsBindingSource
        '
        Me.View_Acc_EmpDeptsAndJoiningsBindingSource.DataMember = "View_Acc_EmpDeptsAndJoinings"
        Me.View_Acc_EmpDeptsAndJoiningsBindingSource.DataSource = Me.DSCalculateSalary
        '
        'GradeLabel2
        '
        Me.GradeLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GradeLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "Grade", True))
        Me.GradeLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.GradeLabel2.Location = New System.Drawing.Point(12, 176)
        Me.GradeLabel2.Name = "GradeLabel2"
        Me.GradeLabel2.Size = New System.Drawing.Size(76, 20)
        Me.GradeLabel2.TabIndex = 109
        Me.GradeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DayDeductionLabel1
        '
        Me.DayDeductionLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DayDeductionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Emp_Deduction_DaysBindingSource, "DayDeduction", True))
        Me.DayDeductionLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DayDeductionLabel1.Location = New System.Drawing.Point(875, 327)
        Me.DayDeductionLabel1.Name = "DayDeductionLabel1"
        Me.DayDeductionLabel1.Size = New System.Drawing.Size(45, 13)
        Me.DayDeductionLabel1.TabIndex = 107
        '
        'View_Emp_Deduction_DaysBindingSource
        '
        Me.View_Emp_Deduction_DaysBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Emp_Deduction_Days"
        Me.View_Emp_Deduction_DaysBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'PESSIStatus
        '
        Me.PESSIStatus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PESSIStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "PESSICont", True))
        Me.PESSIStatus.ForeColor = System.Drawing.Color.Gainsboro
        Me.PESSIStatus.Location = New System.Drawing.Point(813, 348)
        Me.PESSIStatus.Name = "PESSIStatus"
        Me.PESSIStatus.Size = New System.Drawing.Size(25, 20)
        Me.PESSIStatus.TabIndex = 106
        Me.PESSIStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_SalaryBindingSource
        '
        Me.Tbl_Acc_SalaryBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_Salary"
        Me.Tbl_Acc_SalaryBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Gainsboro
        Me.Label33.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label33.Location = New System.Drawing.Point(12, 114)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(10, 10)
        Me.Label33.TabIndex = 61
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label33.Visible = False
        '
        'SpecialAllowanceLabel2
        '
        Me.SpecialAllowanceLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SpecialAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "SpecialAllowance", True))
        Me.SpecialAllowanceLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.SpecialAllowanceLabel2.Location = New System.Drawing.Point(501, 428)
        Me.SpecialAllowanceLabel2.Name = "SpecialAllowanceLabel2"
        Me.SpecialAllowanceLabel2.Size = New System.Drawing.Size(10, 10)
        Me.SpecialAllowanceLabel2.TabIndex = 47
        Me.SpecialAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GradeLabel1
        '
        Me.GradeLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GradeLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.GradeLabel1.Location = New System.Drawing.Point(322, 492)
        Me.GradeLabel1.Name = "GradeLabel1"
        Me.GradeLabel1.Size = New System.Drawing.Size(30, 20)
        Me.GradeLabel1.TabIndex = 60
        Me.GradeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndOfContractDateLabel1
        '
        Me.EndOfContractDateLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EndOfContractDateLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EndOfContractDateLabel1.Location = New System.Drawing.Point(396, 492)
        Me.EndOfContractDateLabel1.Name = "EndOfContractDateLabel1"
        Me.EndOfContractDateLabel1.Size = New System.Drawing.Size(30, 20)
        Me.EndOfContractDateLabel1.TabIndex = 59
        Me.EndOfContractDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndOfProbationDateLabel1
        '
        Me.EndOfProbationDateLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EndOfProbationDateLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EndOfProbationDateLabel1.Location = New System.Drawing.Point(638, 428)
        Me.EndOfProbationDateLabel1.Name = "EndOfProbationDateLabel1"
        Me.EndOfProbationDateLabel1.Size = New System.Drawing.Size(25, 20)
        Me.EndOfProbationDateLabel1.TabIndex = 58
        Me.EndOfProbationDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateOfJoiningLabel1
        '
        Me.DateOfJoiningLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DateOfJoiningLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "DateOfJoning", True))
        Me.DateOfJoiningLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DateOfJoiningLabel1.Location = New System.Drawing.Point(374, 579)
        Me.DateOfJoiningLabel1.Name = "DateOfJoiningLabel1"
        Me.DateOfJoiningLabel1.Size = New System.Drawing.Size(89, 20)
        Me.DateOfJoiningLabel1.TabIndex = 57
        Me.DateOfJoiningLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "DesigName", True))
        Me.DesigNameLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DesigNameLabel1.Location = New System.Drawing.Point(12, 222)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(44, 20)
        Me.DesigNameLabel1.TabIndex = 56
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SubDept1Label1
        '
        Me.SubDept1Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SubDept1Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.SubDept1Label1.Location = New System.Drawing.Point(354, 579)
        Me.SubDept1Label1.Name = "SubDept1Label1"
        Me.SubDept1Label1.Size = New System.Drawing.Size(44, 20)
        Me.SubDept1Label1.TabIndex = 55
        Me.SubDept1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainDeptLabel1
        '
        Me.MainDeptLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MainDeptLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "DeptName", True))
        Me.MainDeptLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.MainDeptLabel1.Location = New System.Drawing.Point(12, 278)
        Me.MainDeptLabel1.Name = "MainDeptLabel1"
        Me.MainDeptLabel1.Size = New System.Drawing.Size(44, 20)
        Me.MainDeptLabel1.TabIndex = 54
        Me.MainDeptLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OTALLabel1
        '
        Me.OTALLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.OTALLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves7BindingSource, "OTAL", True))
        Me.OTALLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.OTALLabel1.Location = New System.Drawing.Point(371, 492)
        Me.OTALLabel1.Name = "OTALLabel1"
        Me.OTALLabel1.Size = New System.Drawing.Size(10, 20)
        Me.OTALLabel1.TabIndex = 53
        Me.OTALLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_PayRoll_LongLeaves7BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves7BindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_PayRoll_LongLeaves7"
        Me.Tbl_PayRoll_LongLeaves7BindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'RentDeductionLabel1
        '
        Me.RentDeductionLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RentDeductionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "RentDeduction", True))
        Me.RentDeductionLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.RentDeductionLabel1.Location = New System.Drawing.Point(318, 492)
        Me.RentDeductionLabel1.Name = "RentDeductionLabel1"
        Me.RentDeductionLabel1.Size = New System.Drawing.Size(34, 20)
        Me.RentDeductionLabel1.TabIndex = 1
        Me.RentDeductionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PaymentModeLabel2
        '
        Me.PaymentModeLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PaymentModeLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "PaymentMode", True))
        Me.PaymentModeLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.PaymentModeLabel2.Location = New System.Drawing.Point(208, 581)
        Me.PaymentModeLabel2.Name = "PaymentModeLabel2"
        Me.PaymentModeLabel2.Size = New System.Drawing.Size(49, 20)
        Me.PaymentModeLabel2.TabIndex = 49
        Me.PaymentModeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MealAllowanceLabel2
        '
        Me.MealAllowanceLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MealAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "MealAllowance", True))
        Me.MealAllowanceLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.MealAllowanceLabel2.Location = New System.Drawing.Point(361, 461)
        Me.MealAllowanceLabel2.Name = "MealAllowanceLabel2"
        Me.MealAllowanceLabel2.Size = New System.Drawing.Size(61, 20)
        Me.MealAllowanceLabel2.TabIndex = 48
        Me.MealAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AmountLabel1
        '
        Me.AmountLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AmountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_ShortTermAdvancesBindingSource, "Amount", True))
        Me.AmountLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.AmountLabel1.Location = New System.Drawing.Point(374, 492)
        Me.AmountLabel1.Name = "AmountLabel1"
        Me.AmountLabel1.Size = New System.Drawing.Size(35, 20)
        Me.AmountLabel1.TabIndex = 25
        Me.AmountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_ShortTermAdvancesBindingSource
        '
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_ShortTermAdvances"
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'EducationAllowanceLabel2
        '
        Me.EducationAllowanceLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EducationAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "EducationAllowance", True))
        Me.EducationAllowanceLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.EducationAllowanceLabel2.Location = New System.Drawing.Point(296, 500)
        Me.EducationAllowanceLabel2.Name = "EducationAllowanceLabel2"
        Me.EducationAllowanceLabel2.Size = New System.Drawing.Size(10, 10)
        Me.EducationAllowanceLabel2.TabIndex = 46
        Me.EducationAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TravelAllowanceLabel2
        '
        Me.TravelAllowanceLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TravelAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "TravelAllowance", True))
        Me.TravelAllowanceLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.TravelAllowanceLabel2.Location = New System.Drawing.Point(602, 446)
        Me.TravelAllowanceLabel2.Name = "TravelAllowanceLabel2"
        Me.TravelAllowanceLabel2.Size = New System.Drawing.Size(61, 20)
        Me.TravelAllowanceLabel2.TabIndex = 44
        Me.TravelAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EOBILabel2
        '
        Me.EOBILabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EOBILabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "EOBI", True))
        Me.EOBILabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.EOBILabel2.Location = New System.Drawing.Point(387, 483)
        Me.EOBILabel2.Name = "EOBILabel2"
        Me.EOBILabel2.Size = New System.Drawing.Size(61, 20)
        Me.EOBILabel2.TabIndex = 43
        Me.EOBILabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaxDeductionLabel2
        '
        Me.TaxDeductionLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TaxDeductionLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "TaxDeduction", True))
        Me.TaxDeductionLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.TaxDeductionLabel2.Location = New System.Drawing.Point(278, 560)
        Me.TaxDeductionLabel2.Name = "TaxDeductionLabel2"
        Me.TaxDeductionLabel2.Size = New System.Drawing.Size(10, 10)
        Me.TaxDeductionLabel2.TabIndex = 42
        Me.TaxDeductionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrossSalaryLabel2
        '
        Me.GrossSalaryLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GrossSalaryLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "GrossSalary", True))
        Me.GrossSalaryLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.GrossSalaryLabel2.Location = New System.Drawing.Point(361, 404)
        Me.GrossSalaryLabel2.Name = "GrossSalaryLabel2"
        Me.GrossSalaryLabel2.Size = New System.Drawing.Size(61, 20)
        Me.GrossSalaryLabel2.TabIndex = 41
        Me.GrossSalaryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FatherNameLabel2
        '
        Me.FatherNameLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FatherNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "FatherName", True))
        Me.FatherNameLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.FatherNameLabel2.Location = New System.Drawing.Point(513, 512)
        Me.FatherNameLabel2.Name = "FatherNameLabel2"
        Me.FatherNameLabel2.Size = New System.Drawing.Size(49, 20)
        Me.FatherNameLabel2.TabIndex = 39
        Me.FatherNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel2
        '
        Me.NameLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "Name", True))
        Me.NameLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.NameLabel2.Location = New System.Drawing.Point(283, 533)
        Me.NameLabel2.Name = "NameLabel2"
        Me.NameLabel2.Size = New System.Drawing.Size(10, 10)
        Me.NameLabel2.TabIndex = 38
        Me.NameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpIDLabel2
        '
        Me.EmpIDLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EmpIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpID", True))
        Me.EmpIDLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.EmpIDLabel2.Location = New System.Drawing.Point(428, 391)
        Me.EmpIDLabel2.Name = "EmpIDLabel2"
        Me.EmpIDLabel2.Size = New System.Drawing.Size(61, 20)
        Me.EmpIDLabel2.TabIndex = 37
        Me.EmpIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_Info_HBindingSource, "CardNo", True))
        Me.CardNoLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.CardNoLabel1.Location = New System.Drawing.Point(333, 586)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(10, 3)
        Me.CardNoLabel1.TabIndex = 50
        '
        'TotalHalfDaysLabel1
        '
        Me.TotalHalfDaysLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TotalHalfDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource, "TotalHalfDays", True))
        Me.TotalHalfDaysLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.TotalHalfDaysLabel1.Location = New System.Drawing.Point(312, 500)
        Me.TotalHalfDaysLabel1.Name = "TotalHalfDaysLabel1"
        Me.TotalHalfDaysLabel1.Size = New System.Drawing.Size(33, 20)
        Me.TotalHalfDaysLabel1.TabIndex = 55
        Me.TotalHalfDaysLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_PayRoll_EmpAttRecord1BindingSource
        '
        Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource.DataMember = "View_Rpt_PayRoll_EmpAttRecord1"
        Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource.DataSource = Me.DSCalculateSalary
        '
        'TotalFullDaysLabel1
        '
        Me.TotalFullDaysLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TotalFullDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, "TotalFullDays", True))
        Me.TotalFullDaysLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.TotalFullDaysLabel1.Location = New System.Drawing.Point(356, 500)
        Me.TotalFullDaysLabel1.Name = "TotalFullDaysLabel1"
        Me.TotalFullDaysLabel1.Size = New System.Drawing.Size(47, 20)
        Me.TotalFullDaysLabel1.TabIndex = 54
        Me.TotalFullDaysLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_PayRoll_EmpAttRecordBindingSource
        '
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource.DataMember = "View_Rpt_PayRoll_EmpAttRecord"
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource.DataSource = Me.DSCalculateSalary
        '
        'lblTotalMeal
        '
        Me.lblTotalMeal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotalMeal.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTotalMeal.Location = New System.Drawing.Point(250, 526)
        Me.lblTotalMeal.Name = "lblTotalMeal"
        Me.lblTotalMeal.Size = New System.Drawing.Size(32, 20)
        Me.lblTotalMeal.TabIndex = 33
        Me.lblTotalMeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPayableDays
        '
        Me.lblTotalPayableDays.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotalPayableDays.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTotalPayableDays.Location = New System.Drawing.Point(417, 550)
        Me.lblTotalPayableDays.Name = "lblTotalPayableDays"
        Me.lblTotalPayableDays.Size = New System.Drawing.Size(46, 20)
        Me.lblTotalPayableDays.TabIndex = 32
        Me.lblTotalPayableDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalDaysWorked
        '
        Me.lblTotalDaysWorked.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotalDaysWorked.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTotalDaysWorked.Location = New System.Drawing.Point(250, 500)
        Me.lblTotalDaysWorked.Name = "lblTotalDaysWorked"
        Me.lblTotalDaysWorked.Size = New System.Drawing.Size(32, 20)
        Me.lblTotalDaysWorked.TabIndex = 31
        Me.lblTotalDaysWorked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAbsents
        '
        Me.lblAbsents.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblAbsents.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblAbsents.Location = New System.Drawing.Point(513, 605)
        Me.lblAbsents.Name = "lblAbsents"
        Me.lblAbsents.Size = New System.Drawing.Size(33, 20)
        Me.lblAbsents.TabIndex = 30
        Me.lblAbsents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnPaidLeavesLabel2
        '
        Me.UnPaidLeavesLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UnPaidLeavesLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.UnPaidLeavesLabel2.Location = New System.Drawing.Point(679, 364)
        Me.UnPaidLeavesLabel2.Name = "UnPaidLeavesLabel2"
        Me.UnPaidLeavesLabel2.Size = New System.Drawing.Size(10, 5)
        Me.UnPaidLeavesLabel2.TabIndex = 37
        Me.UnPaidLeavesLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'M2Label1
        '
        Me.M2Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.M2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves5BindingSource, "M2", True))
        Me.M2Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.M2Label1.Location = New System.Drawing.Point(254, 498)
        Me.M2Label1.Name = "M2Label1"
        Me.M2Label1.Size = New System.Drawing.Size(10, 5)
        Me.M2Label1.TabIndex = 36
        Me.M2Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_PayRoll_LongLeaves5BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves5BindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_PayRoll_LongLeaves5"
        Me.Tbl_PayRoll_LongLeaves5BindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'M1Label1
        '
        Me.M1Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.M1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves1BindingSource, "M1", True))
        Me.M1Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.M1Label1.Location = New System.Drawing.Point(458, 364)
        Me.M1Label1.Name = "M1Label1"
        Me.M1Label1.Size = New System.Drawing.Size(10, 5)
        Me.M1Label1.TabIndex = 35
        Me.M1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_PayRoll_LongLeaves1BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves1BindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_PayRoll_LongLeaves1"
        Me.Tbl_PayRoll_LongLeaves1BindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'PaidLeavesLabel2
        '
        Me.PaidLeavesLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PaidLeavesLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves4BindingSource, "PaidLeaves", True))
        Me.PaidLeavesLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.PaidLeavesLabel2.Location = New System.Drawing.Point(554, 364)
        Me.PaidLeavesLabel2.Name = "PaidLeavesLabel2"
        Me.PaidLeavesLabel2.Size = New System.Drawing.Size(10, 5)
        Me.PaidLeavesLabel2.TabIndex = 30
        Me.PaidLeavesLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_PayRoll_LongLeaves4BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves4BindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_PayRoll_LongLeaves4"
        Me.Tbl_PayRoll_LongLeaves4BindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'SpecialLeaveLabel1
        '
        Me.SpecialLeaveLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SpecialLeaveLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.SpecialLeaveLabel1.Location = New System.Drawing.Point(554, 400)
        Me.SpecialLeaveLabel1.Name = "SpecialLeaveLabel1"
        Me.SpecialLeaveLabel1.Size = New System.Drawing.Size(10, 5)
        Me.SpecialLeaveLabel1.TabIndex = 29
        Me.SpecialLeaveLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CasualLeaveLabel1
        '
        Me.CasualLeaveLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CasualLeaveLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeavesBindingSource, "CasualLeave", True))
        Me.CasualLeaveLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.CasualLeaveLabel1.Location = New System.Drawing.Point(679, 401)
        Me.CasualLeaveLabel1.Name = "CasualLeaveLabel1"
        Me.CasualLeaveLabel1.Size = New System.Drawing.Size(10, 5)
        Me.CasualLeaveLabel1.TabIndex = 26
        Me.CasualLeaveLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_PayRoll_LongLeavesBindingSource
        '
        Me.Tbl_PayRoll_LongLeavesBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_PayRoll_LongLeaves"
        Me.Tbl_PayRoll_LongLeavesBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(554, 507)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FullMinutesWorkedLabel1
        '
        Me.FullMinutesWorkedLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FullMinutesWorkedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_OverTimeSumBindingSource, "FullMinutesWorked", True))
        Me.FullMinutesWorkedLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.FullMinutesWorkedLabel1.Location = New System.Drawing.Point(298, 455)
        Me.FullMinutesWorkedLabel1.Name = "FullMinutesWorkedLabel1"
        Me.FullMinutesWorkedLabel1.Size = New System.Drawing.Size(49, 19)
        Me.FullMinutesWorkedLabel1.TabIndex = 52
        '
        'View_Rpt_Acc_OverTimeSumBindingSource
        '
        Me.View_Rpt_Acc_OverTimeSumBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Rpt_Acc_OverTimeSum"
        Me.View_Rpt_Acc_OverTimeSumBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckBox1.Location = New System.Drawing.Point(211, 404)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(22, 20)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Want to Deduct? (Cecked = Yes And UnChecked = No)"
        Me.CheckBox1.UseVisualStyleBackColor = False
        Me.CheckBox1.Visible = False
        '
        'PAdvDedRateLabel1
        '
        Me.PAdvDedRateLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PAdvDedRateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "PAdvDedRate", True))
        Me.PAdvDedRateLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.PAdvDedRateLabel1.Location = New System.Drawing.Point(298, 406)
        Me.PAdvDedRateLabel1.Name = "PAdvDedRateLabel1"
        Me.PAdvDedRateLabel1.Size = New System.Drawing.Size(90, 20)
        Me.PAdvDedRateLabel1.TabIndex = 45
        Me.PAdvDedRateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdvSumLabel1
        '
        Me.AdvSumLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AdvSumLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_PermanentAdvances1BindingSource, "AdvSum", True))
        Me.AdvSumLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.AdvSumLabel1.Location = New System.Drawing.Point(388, 572)
        Me.AdvSumLabel1.Name = "AdvSumLabel1"
        Me.AdvSumLabel1.Size = New System.Drawing.Size(10, 10)
        Me.AdvSumLabel1.TabIndex = 44
        Me.AdvSumLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_PermanentAdvances1BindingSource
        '
        Me.Tbl_Acc_PermanentAdvances1BindingSource.DataMember = "tbl_Acc_PermanentAdvances1"
        Me.Tbl_Acc_PermanentAdvances1BindingSource.DataSource = Me.DSLongTermAdv
        '
        'DSLongTermAdv
        '
        Me.DSLongTermAdv.DataSetName = "DSLongTermAdv"
        Me.DSLongTermAdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TotalDedLabel1
        '
        Me.TotalDedLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TotalDedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_PAdvDeductions1BindingSource, "TotalDed", True))
        Me.TotalDedLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.TotalDedLabel1.Location = New System.Drawing.Point(279, 598)
        Me.TotalDedLabel1.Name = "TotalDedLabel1"
        Me.TotalDedLabel1.Size = New System.Drawing.Size(10, 10)
        Me.TotalDedLabel1.TabIndex = 43
        Me.TotalDedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_PAdvDeductions1BindingSource
        '
        Me.Tbl_Acc_PAdvDeductions1BindingSource.DataMember = "tbl_Acc_PAdvDeductions1"
        Me.Tbl_Acc_PAdvDeductions1BindingSource.DataSource = Me.DSLongTermAdv
        '
        'lblRemaining
        '
        Me.lblRemaining.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRemaining.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblRemaining.Location = New System.Drawing.Point(309, 465)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(10, 10)
        Me.lblRemaining.TabIndex = 40
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExtraDays
        '
        Me.lblExtraDays.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblExtraDays.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblExtraDays.Location = New System.Drawing.Point(297, 517)
        Me.lblExtraDays.Name = "lblExtraDays"
        Me.lblExtraDays.Size = New System.Drawing.Size(10, 10)
        Me.lblExtraDays.TabIndex = 63
        Me.lblExtraDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWorkingDays
        '
        Me.lblWorkingDays.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblWorkingDays.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblWorkingDays.Location = New System.Drawing.Point(536, 431)
        Me.lblWorkingDays.Name = "lblWorkingDays"
        Me.lblWorkingDays.Size = New System.Drawing.Size(10, 10)
        Me.lblWorkingDays.TabIndex = 32
        Me.lblWorkingDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HolidayCountLabel1
        '
        Me.HolidayCountLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.HolidayCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_HolidaysBindingSource, "HolidayCount", True))
        Me.HolidayCountLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.HolidayCountLabel1.Location = New System.Drawing.Point(316, 451)
        Me.HolidayCountLabel1.Name = "HolidayCountLabel1"
        Me.HolidayCountLabel1.Size = New System.Drawing.Size(65, 20)
        Me.HolidayCountLabel1.TabIndex = 30
        Me.HolidayCountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Hrm_HolidaysBindingSource
        '
        Me.Tbl_Hrm_HolidaysBindingSource.DataMember = "tbl_Hrm_Holidays"
        Me.Tbl_Hrm_HolidaysBindingSource.DataSource = Me.DSCalculateSalary
        '
        'lblSundays
        '
        Me.lblSundays.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSundays.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblSundays.Location = New System.Drawing.Point(223, 500)
        Me.lblSundays.Name = "lblSundays"
        Me.lblSundays.Size = New System.Drawing.Size(65, 20)
        Me.lblSundays.TabIndex = 29
        Me.lblSundays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthDays
        '
        Me.lblMonthDays.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMonthDays.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblMonthDays.Location = New System.Drawing.Point(393, 471)
        Me.lblMonthDays.Name = "lblMonthDays"
        Me.lblMonthDays.Size = New System.Drawing.Size(10, 10)
        Me.lblMonthDays.TabIndex = 28
        Me.lblMonthDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_Salary_TransactionsBindingSource
        '
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_Salary_Transactions"
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'lblOverTimeHours
        '
        Me.lblOverTimeHours.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblOverTimeHours.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblOverTimeHours.Location = New System.Drawing.Point(278, 560)
        Me.lblOverTimeHours.Name = "lblOverTimeHours"
        Me.lblOverTimeHours.Size = New System.Drawing.Size(10, 10)
        Me.lblOverTimeHours.TabIndex = 36
        Me.lblOverTimeHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverTime
        '
        Me.lblOverTime.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblOverTime.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblOverTime.Location = New System.Drawing.Point(388, 533)
        Me.lblOverTime.Name = "lblOverTime"
        Me.lblOverTime.Size = New System.Drawing.Size(10, 10)
        Me.lblOverTime.TabIndex = 35
        Me.lblOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.TextBox4)
        Me.Panel11.Controls.Add(Me.MaskedTextBox2)
        Me.Panel11.Controls.Add(Me.MaskedTextBox1)
        Me.Panel11.Controls.Add(Label25)
        Me.Panel11.Controls.Add(Me.Label27)
        Me.Panel11.Controls.Add(Me.Label28)
        Me.Panel11.Controls.Add(Me.Label29)
        Me.Panel11.Location = New System.Drawing.Point(857, 431)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(64, 39)
        Me.Panel11.TabIndex = 32
        Me.Panel11.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.MistyRose
        Me.TextBox4.Location = New System.Drawing.Point(84, 89)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(60, 20)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.TabStop = False
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.MistyRose
        Me.MaskedTextBox2.Location = New System.Drawing.Point(84, 63)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(60, 20)
        Me.MaskedTextBox2.TabIndex = 8
        Me.MaskedTextBox2.TabStop = False
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.MistyRose
        Me.MaskedTextBox1.Location = New System.Drawing.Point(84, 37)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(60, 20)
        Me.MaskedTextBox1.TabIndex = 2
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label27.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label27.Location = New System.Drawing.Point(0, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 22)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Manual Fields"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label27.Visible = False
        '
        'Label28
        '
        Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label28.Location = New System.Drawing.Point(17, 37)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 20)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Full Days: "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.Location = New System.Drawing.Point(17, 63)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 20)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Half Days:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalLeavesLabel1
        '
        Me.TotalLeavesLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TotalLeavesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves6BindingSource, "TotalLeaves", True))
        Me.TotalLeavesLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.TotalLeavesLabel1.Location = New System.Drawing.Point(373, 585)
        Me.TotalLeavesLabel1.Name = "TotalLeavesLabel1"
        Me.TotalLeavesLabel1.Size = New System.Drawing.Size(10, 3)
        Me.TotalLeavesLabel1.TabIndex = 56
        '
        'Tbl_PayRoll_LongLeaves6BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves6BindingSource.DataMember = "tbl_PayRoll_LongLeaves6"
        Me.Tbl_PayRoll_LongLeaves6BindingSource.DataSource = Me.DSCalculateSalary
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Purple
        Me.Button1.Location = New System.Drawing.Point(378, 548)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(10, 12)
        Me.Button1.TabIndex = 57
        Me.Button1.TabStop = False
        Me.Button1.Text = "Undo"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Tbl_Acc_PAdvDeductions1TableAdapter
        '
        Me.Tbl_Acc_PAdvDeductions1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_PermanentAdvances1TableAdapter
        '
        Me.Tbl_Acc_PermanentAdvances1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_PAdvDeductionsBindingSource
        '
        Me.Tbl_Acc_PAdvDeductionsBindingSource.DataMember = "tbl_Acc_PAdvDeductions"
        Me.Tbl_Acc_PAdvDeductionsBindingSource.DataSource = Me.DSLongTermAdv
        '
        'Tbl_Acc_PAdvDeductionsTableAdapter
        '
        Me.Tbl_Acc_PAdvDeductionsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_SalaryBindingSource1
        '
        Me.Tbl_Acc_SalaryBindingSource1.DataMember = "tbl_Acc_Salary"
        Me.Tbl_Acc_SalaryBindingSource1.DataSource = Me.DSLongTermAdv
        '
        'Tbl_Acc_SalaryTableAdapter1
        '
        Me.Tbl_Acc_SalaryTableAdapter1.ClearBeforeFill = True
        '
        'lblShortAmt
        '
        Me.lblShortAmt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblShortAmt.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblShortAmt.Location = New System.Drawing.Point(239, 555)
        Me.lblShortAmt.Name = "lblShortAmt"
        Me.lblShortAmt.Size = New System.Drawing.Size(62, 20)
        Me.lblShortAmt.TabIndex = 63
        Me.lblShortAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalShortMinutes
        '
        Me.lblTotalShortMinutes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotalShortMinutes.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTotalShortMinutes.Location = New System.Drawing.Point(239, 528)
        Me.lblTotalShortMinutes.Name = "lblTotalShortMinutes"
        Me.lblTotalShortMinutes.Size = New System.Drawing.Size(69, 20)
        Me.lblTotalShortMinutes.TabIndex = 62
        Me.lblTotalShortMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSLeaveDeduct
        '
        Me.txtSLeaveDeduct.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSLeaveDeduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSLeaveDeduct.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtSLeaveDeduct.Location = New System.Drawing.Point(289, 535)
        Me.txtSLeaveDeduct.Name = "txtSLeaveDeduct"
        Me.txtSLeaveDeduct.Size = New System.Drawing.Size(10, 13)
        Me.txtSLeaveDeduct.TabIndex = 65
        Me.txtSLeaveDeduct.TabStop = False
        Me.txtSLeaveDeduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSLeaveDeduct.WordWrap = False
        '
        'MorningShortMinsLabel1
        '
        Me.MorningShortMinsLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MorningShortMinsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_MorningShortMinsBindingSource, "MorningShortMins", True))
        Me.MorningShortMinsLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.MorningShortMinsLabel1.Location = New System.Drawing.Point(223, 559)
        Me.MorningShortMinsLabel1.Name = "MorningShortMinsLabel1"
        Me.MorningShortMinsLabel1.Size = New System.Drawing.Size(10, 3)
        Me.MorningShortMinsLabel1.TabIndex = 70
        Me.MorningShortMinsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_MorningShortMinsBindingSource
        '
        Me.View_Rpt_Acc_MorningShortMinsBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Rpt_Acc_MorningShortMins"
        Me.View_Rpt_Acc_MorningShortMinsBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'EveningShortMinsLabel1
        '
        Me.EveningShortMinsLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EveningShortMinsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_EveningShortMinsBindingSource, "EveningShortMins", True))
        Me.EveningShortMinsLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EveningShortMinsLabel1.Location = New System.Drawing.Point(702, 378)
        Me.EveningShortMinsLabel1.Name = "EveningShortMinsLabel1"
        Me.EveningShortMinsLabel1.Size = New System.Drawing.Size(10, 33)
        Me.EveningShortMinsLabel1.TabIndex = 71
        Me.EveningShortMinsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_EveningShortMinsBindingSource
        '
        Me.View_Rpt_Acc_EveningShortMinsBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Rpt_Acc_EveningShortMins"
        Me.View_Rpt_Acc_EveningShortMinsBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'lblShortDeducted
        '
        Me.lblShortDeducted.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblShortDeducted.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblShortDeducted.Location = New System.Drawing.Point(364, 656)
        Me.lblShortDeducted.Name = "lblShortDeducted"
        Me.lblShortDeducted.Size = New System.Drawing.Size(62, 20)
        Me.lblShortDeducted.TabIndex = 73
        Me.lblShortDeducted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1021, 40)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Monthly Salary Auto Calculation"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(0, 722)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1021, 24)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Note: Select Appropriate Month To Calculate Auto Salary"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 686)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1021, 36)
        Me.StatusStrip1.TabIndex = 100
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(990, 30)
        Me.ToolStripProgressBar1.Step = 1
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnSave.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSave.Location = New System.Drawing.Point(679, 525)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 101
        '
        'View_Emp_Meal_AttendanceBindingSource
        '
        Me.View_Emp_Meal_AttendanceBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Emp_Meal_Attendance"
        Me.View_Emp_Meal_AttendanceBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'LblTotalMealDeduction
        '
        Me.LblTotalMealDeduction.AutoSize = True
        Me.LblTotalMealDeduction.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblTotalMealDeduction.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblTotalMealDeduction.Location = New System.Drawing.Point(769, 411)
        Me.LblTotalMealDeduction.Name = "LblTotalMealDeduction"
        Me.LblTotalMealDeduction.Size = New System.Drawing.Size(39, 13)
        Me.LblTotalMealDeduction.TabIndex = 110
        Me.LblTotalMealDeduction.Text = "Label3"
        '
        'EmpCountLabel1
        '
        Me.EmpCountLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EmpCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Emp_Meal_AttendanceBindingSource, "EmpCount", True))
        Me.EmpCountLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EmpCountLabel1.Location = New System.Drawing.Point(638, 413)
        Me.EmpCountLabel1.Name = "EmpCountLabel1"
        Me.EmpCountLabel1.Size = New System.Drawing.Size(100, 15)
        Me.EmpCountLabel1.TabIndex = 109
        Me.EmpCountLabel1.Text = "Label3"
        '
        'SenStatusLabel3
        '
        Me.SenStatusLabel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SenStatusLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "SenStatus", True))
        Me.SenStatusLabel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.SenStatusLabel3.Location = New System.Drawing.Point(874, 356)
        Me.SenStatusLabel3.Name = "SenStatusLabel3"
        Me.SenStatusLabel3.Size = New System.Drawing.Size(25, 20)
        Me.SenStatusLabel3.TabIndex = 109
        Me.SenStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(182, 49)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 409)
        Me.TabControl1.TabIndex = 111
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(542, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Auto Salary Calculate "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.DateTimePicker5)
        Me.TabPage2.Controls.Add(Me.tbFilePath)
        Me.TabPage2.Controls.Add(Me.btnOpenFile)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(542, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Arrears"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 86)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(532, 309)
        Me.DataGridView1.TabIndex = 33
        Me.DataGridView1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Location = New System.Drawing.Point(255, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 26)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Save Now"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(11, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 20)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Select Transaction Date:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(147, 35)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker5.TabIndex = 35
        '
        'tbFilePath
        '
        Me.tbFilePath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tbFilePath.Location = New System.Drawing.Point(11, 62)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(422, 20)
        Me.tbFilePath.TabIndex = 37
        Me.tbFilePath.TabStop = False
        Me.tbFilePath.Text = "Browse an Excel File Here to Upload Data..."
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.White
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.Color.DarkRed
        Me.btnOpenFile.Location = New System.Drawing.Point(439, 59)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(86, 24)
        Me.btnOpenFile.TabIndex = 38
        Me.btnOpenFile.Text = "Browse File"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(3, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(536, 25)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Arrears"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Location = New System.Drawing.Point(3, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(174, 57)
        Me.Panel2.TabIndex = 112
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(6, 29)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(162, 21)
        Me.LinkLabel2.TabIndex = 113
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Arrears"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(162, 21)
        Me.LinkLabel1.TabIndex = 113
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Auto Salary Calculate "
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        Me.Tbl_Comp_InfoBindingSource.DataSource = Me.DSUser
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Comp_InfoTableAdapter = Me.Tbl_Comp_InfoTableAdapter
        Me.TableAdapterManager1.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager1.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        '
        'AccommodationLabel2
        '
        Me.AccommodationLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.AccommodationLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "Accommodation", True))
        Me.AccommodationLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.AccommodationLabel2.Location = New System.Drawing.Point(891, 349)
        Me.AccommodationLabel2.Name = "AccommodationLabel2"
        Me.AccommodationLabel2.Size = New System.Drawing.Size(130, 20)
        Me.AccommodationLabel2.TabIndex = 109
        Me.AccommodationLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CanteenLabel
        '
        Me.CanteenLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CanteenLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "ConteenDeduct", True))
        Me.CanteenLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.CanteenLabel.Location = New System.Drawing.Point(642, 507)
        Me.CanteenLabel.Name = "CanteenLabel"
        Me.CanteenLabel.Size = New System.Drawing.Size(137, 20)
        Me.CanteenLabel.TabIndex = 109
        Me.CanteenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_Hrm_Emp_Info_HTableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_HTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_InfoTableAdapter
        '
        Me.Tbl_Hrm_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_SalaryTableAdapter
        '
        Me.Tbl_Acc_SalaryTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_HolidaysTableAdapter
        '
        Me.Tbl_Hrm_HolidaysTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_ShortTermAdvancesTableAdapter
        '
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeavesTableAdapter
        '
        Me.Tbl_PayRoll_LongLeavesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves1TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves4TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves4TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_Salary_TransactionsTableAdapter
        '
        Me.Tbl_Acc_Salary_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves5TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves5TableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves7TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves7TableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves6TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves6TableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_OverTimeSumTableAdapter
        '
        Me.View_Rpt_Acc_OverTimeSumTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_ExtraWorkingDaysBindingSource
        '
        Me.Tbl_Hrm_ExtraWorkingDaysBindingSource.DataMember = "tbl_Hrm_ExtraWorkingDays"
        Me.Tbl_Hrm_ExtraWorkingDaysBindingSource.DataSource = Me.DSCalculateSalary
        '
        'Tbl_Hrm_ExtraWorkingDaysTableAdapter
        '
        Me.Tbl_Hrm_ExtraWorkingDaysTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_PayRoll_EmpAttRecordTableAdapter
        '
        Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_PayRoll_EmpAttRecord1TableAdapter
        '
        Me.View_Rpt_PayRoll_EmpAttRecord1TableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_MorningShortMinsTableAdapter
        '
        Me.View_Rpt_Acc_MorningShortMinsTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_EveningShortMinsTableAdapter
        '
        Me.View_Rpt_Acc_EveningShortMinsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_Cards_InfoTableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_Cards_InfoTableAdapter.ClearBeforeFill = True
        '
        'View_Emp_Deduction_DaysTableAdapter
        '
        Me.View_Emp_Deduction_DaysTableAdapter.ClearBeforeFill = True
        '
        'View_Emp_Meal_AttendanceTableAdapter
        '
        Me.View_Emp_Meal_AttendanceTableAdapter.ClearBeforeFill = True
        '
        'View_Acc_EmpDeptsAndJoiningsTableAdapter
        '
        Me.View_Acc_EmpDeptsAndJoiningsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_Salary_TransactionsTableAdapter = Me.Tbl_Acc_Salary_TransactionsTableAdapter
        Me.TableAdapterManager.tbl_Emp_Salary_Calculation_AdjTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_Cards_InfoTableAdapter = Me.Tbl_Hrm_Emp_Info_Cards_InfoTableAdapter
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_HTableAdapter = Me.Tbl_Hrm_Emp_Info_HTableAdapter
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSCalculateSalaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpIDLabel1
        '
        Me.EmpIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "EmpID", True))
        Me.EmpIDLabel1.Location = New System.Drawing.Point(918, 214)
        Me.EmpIDLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EmpIDLabel1.Name = "EmpIDLabel1"
        Me.EmpIDLabel1.Size = New System.Drawing.Size(75, 19)
        Me.EmpIDLabel1.TabIndex = 113
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(40, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 20)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Error Records"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Red
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(9, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 20)
        Me.Label11.TabIndex = 120
        Me.Label11.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(41, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 20)
        Me.Label16.TabIndex = 119
        Me.Label16.Text = "Saved Records"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.ForestGreen
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(9, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 20)
        Me.Label17.TabIndex = 118
        Me.Label17.Visible = False
        '
        'View_Emp_Month_Zero_LeaveBindingSource
        '
        Me.View_Emp_Month_Zero_LeaveBindingSource.DataMember = "View_Emp_Month_Zero_Leave"
        Me.View_Emp_Month_Zero_LeaveBindingSource.DataSource = Me.DSCalculateSalary
        '
        'View_Emp_Month_Zero_LeaveTableAdapter
        '
        Me.View_Emp_Month_Zero_LeaveTableAdapter.ClearBeforeFill = True
        '
        'SectionNameLabel
        '
        Me.SectionNameLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SectionNameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "SectionName", True))
        Me.SectionNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SectionNameLabel.Location = New System.Drawing.Point(62, 300)
        Me.SectionNameLabel.Name = "SectionNameLabel"
        Me.SectionNameLabel.Size = New System.Drawing.Size(38, 20)
        Me.SectionNameLabel.TabIndex = 109
        Me.SectionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Emp_Salary_Calculation_AdjBindingSource
        '
        Me.Tbl_Emp_Salary_Calculation_AdjBindingSource.DataMember = "tbl_Emp_Salary_Calculation_Adj"
        Me.Tbl_Emp_Salary_Calculation_AdjBindingSource.DataSource = Me.DSCalculateSalary
        '
        'Tbl_Emp_Salary_Calculation_AdjTableAdapter
        '
        Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter.ClearBeforeFill = True
        '
        'DSSP
        '
        Me.DSSP.DataSetName = "DSSP"
        Me.DSSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_SP_OTBindingSource
        '
        Me.View_SP_OTBindingSource.DataMember = "View_SP_OT"
        Me.View_SP_OTBindingSource.DataSource = Me.DSSP
        '
        'View_SP_OTTableAdapter
        '
        Me.View_SP_OTTableAdapter.ClearBeforeFill = True
        '
        'SPLabel1
        '
        Me.SPLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_SP_OTBindingSource, "SP", True))
        Me.SPLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.SPLabel1.Location = New System.Drawing.Point(356, 660)
        Me.SPLabel1.Name = "SPLabel1"
        Me.SPLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SPLabel1.TabIndex = 114
        Me.SPLabel1.Text = "Label40"
        '
        'View_Acc_FairShopBindingSource
        '
        Me.View_Acc_FairShopBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Acc_FairShop"
        Me.View_Acc_FairShopBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'View_Acc_FairShopTableAdapter
        '
        Me.View_Acc_FairShopTableAdapter.ClearBeforeFill = True
        '
        'FairAmountLabel3
        '
        Me.FairAmountLabel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FairAmountLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_FairShopBindingSource, "Amount", True))
        Me.FairAmountLabel3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FairAmountLabel3.Location = New System.Drawing.Point(813, 113)
        Me.FairAmountLabel3.Name = "FairAmountLabel3"
        Me.FairAmountLabel3.Size = New System.Drawing.Size(49, 19)
        Me.FairAmountLabel3.TabIndex = 116
        Me.FairAmountLabel3.Text = "Label40"
        '
        'DailyTA
        '
        Me.DailyTA.AutoSize = True
        Me.DailyTA.ForeColor = System.Drawing.SystemColors.Control
        Me.DailyTA.Location = New System.Drawing.Point(878, 252)
        Me.DailyTA.Name = "DailyTA"
        Me.DailyTA.Size = New System.Drawing.Size(45, 13)
        Me.DailyTA.TabIndex = 122
        Me.DailyTA.Text = "Label18"
        '
        'PerDTA
        '
        Me.PerDTA.AutoSize = True
        Me.PerDTA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "DailyTravelAllowance", True))
        Me.PerDTA.ForeColor = System.Drawing.SystemColors.Control
        Me.PerDTA.Location = New System.Drawing.Point(942, 362)
        Me.PerDTA.Name = "PerDTA"
        Me.PerDTA.Size = New System.Drawing.Size(45, 13)
        Me.PerDTA.TabIndex = 123
        Me.PerDTA.Text = "Label18"
        '
        'PerDTAPayable
        '
        Me.PerDTAPayable.AutoSize = True
        Me.PerDTAPayable.ForeColor = System.Drawing.SystemColors.Control
        Me.PerDTAPayable.Location = New System.Drawing.Point(947, 333)
        Me.PerDTAPayable.Name = "PerDTAPayable"
        Me.PerDTAPayable.Size = New System.Drawing.Size(45, 13)
        Me.PerDTAPayable.TabIndex = 124
        Me.PerDTAPayable.Text = "Label18"
        '
        'Tbl_Acc_RFD_PayTableAdapter
        '
        Me.Tbl_Acc_RFD_PayTableAdapter.ClearBeforeFill = True
        '
        'DataSet5
        '
        Me.DataSet5.DataSetName = "DataSet5"
        Me.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Bonus_SalaryBindingSource
        '
        Me.View_Bonus_SalaryBindingSource.DataMember = "View_Bonus_Salary"
        Me.View_Bonus_SalaryBindingSource.DataSource = Me.DataSet5
        '
        'View_Bonus_SalaryTableAdapter
        '
        Me.View_Bonus_SalaryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.DataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmAutoSalCalculation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1013, 763)
        Me.Controls.Add(Me.PerDTAPayable)
        Me.Controls.Add(Me.PerDTA)
        Me.Controls.Add(Me.DailyTA)
        Me.Controls.Add(Me.FairAmountLabel3)
        Me.Controls.Add(Me.SPLabel1)
        Me.Controls.Add(Me.SectionNameLabel)
        Me.Controls.Add(Me.IncStatusLabel)
        Me.Controls.Add(Me.GradeLabel2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.EmpIDLabel1)
        Me.Controls.Add(Me.CanteenLabel)
        Me.Controls.Add(Me.AccommodationLabel2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.SenStatusLabel3)
        Me.Controls.Add(Me.DayDeductionLabel1)
        Me.Controls.Add(Me.PESSIStatus)
        Me.Controls.Add(Me.LblTotalMealDeduction)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.EmpCountLabel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CasualLeaveLabel1)
        Me.Controls.Add(Me.SpecialLeaveLabel1)
        Me.Controls.Add(Me.M1Label1)
        Me.Controls.Add(Me.M2Label1)
        Me.Controls.Add(Me.PaidLeavesLabel2)
        Me.Controls.Add(Me.UnPaidLeavesLabel2)
        Me.Controls.Add(Me.TotalHalfDaysLabel1)
        Me.Controls.Add(Me.TotalFullDaysLabel1)
        Me.Controls.Add(Me.HolidayCountLabel1)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lblTotalMeal)
        Me.Controls.Add(Me.lblWorkingDays)
        Me.Controls.Add(Me.lblTotalPayableDays)
        Me.Controls.Add(Me.lblSundays)
        Me.Controls.Add(Me.SpecialAllowanceLabel2)
        Me.Controls.Add(Me.lblTotalDaysWorked)
        Me.Controls.Add(Me.lblExtraDays)
        Me.Controls.Add(Me.lblAbsents)
        Me.Controls.Add(Me.MealAllowanceLabel2)
        Me.Controls.Add(Me.PaymentModeLabel2)
        Me.Controls.Add(Me.lblMonthDays)
        Me.Controls.Add(Me.TravelAllowanceLabel2)
        Me.Controls.Add(Me.RentDeductionLabel1)
        Me.Controls.Add(Me.EOBILabel2)
        Me.Controls.Add(Me.DesigNameLabel1)
        Me.Controls.Add(Me.GrossSalaryLabel2)
        Me.Controls.Add(Me.EmpIDLabel2)
        Me.Controls.Add(Me.EndOfContractDateLabel1)
        Me.Controls.Add(Me.EducationAllowanceLabel2)
        Me.Controls.Add(Me.AmountLabel1)
        Me.Controls.Add(Me.SubDept1Label1)
        Me.Controls.Add(Me.GradeLabel1)
        Me.Controls.Add(Me.TaxDeductionLabel2)
        Me.Controls.Add(Me.MainDeptLabel1)
        Me.Controls.Add(Me.EndOfProbationDateLabel1)
        Me.Controls.Add(Me.NameLabel2)
        Me.Controls.Add(Me.lblOverTimeHours)
        Me.Controls.Add(Me.PAdvDedRateLabel1)
        Me.Controls.Add(Me.OTALLabel1)
        Me.Controls.Add(Me.DateOfJoiningLabel1)
        Me.Controls.Add(Me.lblOverTime)
        Me.Controls.Add(Me.lblShortDeducted)
        Me.Controls.Add(Me.lblRemaining)
        Me.Controls.Add(Me.AdvSumLabel1)
        Me.Controls.Add(Me.FatherNameLabel2)
        Me.Controls.Add(Me.TotalDedLabel1)
        Me.Controls.Add(Me.EveningShortMinsLabel1)
        Me.Controls.Add(Me.MorningShortMinsLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtSLeaveDeduct)
        Me.Controls.Add(Me.lblShortAmt)
        Me.Controls.Add(Me.lblTotalShortMinutes)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalLeavesLabel1)
        Me.Controls.Add(Me.FullMinutesWorkedLabel1)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.CardNoLabel1)
        Me.Name = "frmAutoSalCalculation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Monthly Salary Calculations"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Tbl_Acc_RFD_PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCalculateSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_Cards_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_EmpDeptsAndJoiningsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Deduction_DaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_OverTimeSumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PermanentAdvances1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSLongTermAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PAdvDeductions1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.Tbl_PayRoll_LongLeaves6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_SalaryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_MorningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_EveningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.View_Emp_Meal_AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_ExtraWorkingDaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Month_Zero_LeaveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Emp_Salary_Calculation_AdjBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_SP_OTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_FairShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Bonus_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents lblAbsents As System.Windows.Forms.Label
    Friend WithEvents lblTotalDaysWorked As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayableDays As System.Windows.Forms.Label
    Friend WithEvents lblTotalMeal As System.Windows.Forms.Label
    Friend WithEvents lblSundays As System.Windows.Forms.Label
    Friend WithEvents lblMonthDays As System.Windows.Forms.Label
    Friend WithEvents DSCalculateSalary As ERP_HRMS.DSCalculateSalary
    Friend WithEvents Tbl_Hrm_Emp_Info_HBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_HTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_Info_HTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_InfoTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_InfoTableAdapter
    Friend WithEvents EmpIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents FatherNameLabel2 As System.Windows.Forms.Label
    Friend WithEvents NameLabel2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_SalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_SalaryTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_SalaryTableAdapter
    Friend WithEvents GrossSalaryLabel2 As System.Windows.Forms.Label
    Friend WithEvents TravelAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents EOBILabel2 As System.Windows.Forms.Label
    Friend WithEvents TaxDeductionLabel2 As System.Windows.Forms.Label
    Friend WithEvents PaymentModeLabel2 As System.Windows.Forms.Label
    Friend WithEvents MealAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents SpecialAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents EducationAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents CardNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Hrm_HolidaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_HolidaysTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_HolidaysTableAdapter
    Friend WithEvents HolidayCountLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_ShortTermAdvancesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_ShortTermAdvancesTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter
    Friend WithEvents AmountLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_PayRoll_LongLeavesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeavesTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeavesTableAdapter
    Friend WithEvents CasualLeaveLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_PayRoll_LongLeaves1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves1TableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves1TableAdapter
    Friend WithEvents SpecialLeaveLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_PayRoll_LongLeaves4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves4TableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves4TableAdapter
    Friend WithEvents PaidLeavesLabel2 As System.Windows.Forms.Label
    Friend WithEvents lblWorkingDays As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_Salary_TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_Salary_TransactionsTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter
    Friend WithEvents lblOverTime As System.Windows.Forms.Label
    Friend WithEvents M1Label1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_PayRoll_LongLeaves5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves5TableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves5TableAdapter
    Friend WithEvents M2Label1 As System.Windows.Forms.Label
    Friend WithEvents UnPaidLeavesLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblBeforeFinal As System.Windows.Forms.Label
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Tbl_PayRoll_LongLeaves7BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves7TableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves7TableAdapter
    Friend WithEvents OTALLabel1 As System.Windows.Forms.Label
    Friend WithEvents RentDeductionLabel1 As System.Windows.Forms.Label
    Friend WithEvents FullMinutesWorkedLabel1 As System.Windows.Forms.Label
    Friend WithEvents lblOverTimeHours As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents DesigNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents SubDept1Label1 As System.Windows.Forms.Label
    Friend WithEvents MainDeptLabel1 As System.Windows.Forms.Label
    Friend WithEvents EndOfContractDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents EndOfProbationDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents DateOfJoiningLabel1 As System.Windows.Forms.Label
    Friend WithEvents GradeLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_PayRoll_LongLeaves6BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves6TableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves6TableAdapter
    Friend WithEvents TotalLeavesLabel1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents View_Rpt_Acc_OverTimeSumBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_OverTimeSumTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_OverTimeSumTableAdapter
    Friend WithEvents DSLongTermAdv As ERP_HRMS.DSLongTermAdv
    Friend WithEvents Tbl_Acc_PAdvDeductions1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PAdvDeductions1TableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductions1TableAdapter
    Friend WithEvents TotalDedLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_PermanentAdvances1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PermanentAdvances1TableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PermanentAdvances1TableAdapter
    Friend WithEvents AdvSumLabel1 As System.Windows.Forms.Label
    Friend WithEvents PAdvDedRateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_PAdvDeductionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PAdvDeductionsTableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductionsTableAdapter
    Friend WithEvents lblAdds As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents FinancialPeriodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HRMDBDataSet1 As ERP_HRMS.HRMDBDataset1
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents lblExtraDays As System.Windows.Forms.Label
    Friend WithEvents Tbl_Hrm_ExtraWorkingDaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_ExtraWorkingDaysTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_ExtraWorkingDaysTableAdapter
    Friend WithEvents Tbl_Acc_SalaryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_SalaryTableAdapter1 As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_SalaryTableAdapter
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecordTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecordTableAdapter
    Friend WithEvents TotalFullDaysLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecord1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecord1TableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecord1TableAdapter
    Friend WithEvents TotalHalfDaysLabel1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblShortAmt As System.Windows.Forms.Label
    Friend WithEvents lblTotalShortMinutes As System.Windows.Forms.Label
    Friend WithEvents txtSLeaveDeduct As System.Windows.Forms.TextBox
    Friend WithEvents MorningShortMinsLabel1 As System.Windows.Forms.Label
    Friend WithEvents EveningShortMinsLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Rpt_Acc_MorningShortMinsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_MorningShortMinsTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_MorningShortMinsTableAdapter
    Friend WithEvents View_Rpt_Acc_EveningShortMinsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_EveningShortMinsTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_EveningShortMinsTableAdapter
    Friend WithEvents lblShortDeducted As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Label
    Friend WithEvents Tbl_Hrm_Emp_Info_Cards_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_Cards_InfoTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_Info_Cards_InfoTableAdapter
    Friend WithEvents CardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents PESSIStatus As System.Windows.Forms.Label
    Friend WithEvents View_Emp_Deduction_DaysTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Deduction_DaysTableAdapter
    Friend WithEvents View_Emp_Deduction_DaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DayDeductionLabel1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents View_Emp_Meal_AttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Emp_Meal_AttendanceTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Meal_AttendanceTableAdapter
    Friend WithEvents LblTotalMealDeduction As System.Windows.Forms.Label
    Friend WithEvents EmpCountLabel1 As System.Windows.Forms.Label
    Friend WithEvents SenStatusLabel3 As System.Windows.Forms.Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents View_Acc_EmpDeptsAndJoiningsBindingSource As BindingSource
    Friend WithEvents View_Acc_EmpDeptsAndJoiningsTableAdapter As DSCalculateSalaryTableAdapters.View_Acc_EmpDeptsAndJoiningsTableAdapter
    Friend WithEvents TableAdapterManager As DSCalculateSalaryTableAdapters.TableAdapterManager
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents DSUser As DSUser
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents TableAdapterManager1 As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents AccommodationLabel2 As Label
    Friend WithEvents CanteenLabel As Label
    Friend WithEvents EmpIDLabel1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GradeLabel2 As Label
    Friend WithEvents View_Emp_Month_Zero_LeaveBindingSource As BindingSource
    Friend WithEvents View_Emp_Month_Zero_LeaveTableAdapter As DSCalculateSalaryTableAdapters.View_Emp_Month_Zero_LeaveTableAdapter
    Friend WithEvents IncStatusLabel As Label
    Friend WithEvents SectionNameLabel As Label
    Friend WithEvents Tbl_Emp_Salary_Calculation_AdjBindingSource As BindingSource
    Friend WithEvents Tbl_Emp_Salary_Calculation_AdjTableAdapter As DSCalculateSalaryTableAdapters.tbl_Emp_Salary_Calculation_AdjTableAdapter
    Friend WithEvents DSSP As DSSP
    Friend WithEvents View_SP_OTBindingSource As BindingSource
    Friend WithEvents View_SP_OTTableAdapter As DSSPTableAdapters.View_SP_OTTableAdapter
    Friend WithEvents SPLabel1 As Label
    Friend WithEvents View_Acc_FairShopBindingSource As BindingSource
    Friend WithEvents View_Acc_FairShopTableAdapter As DSCalculateSalaryTableAdapters.View_Acc_FairShopTableAdapter
    Friend WithEvents FairAmountLabel3 As Label
    Friend WithEvents DailyTA As Label
    Friend WithEvents PerDTA As Label
    Friend WithEvents PerDTAPayable As Label
    Friend WithEvents Tbl_Acc_RFD_PayTableAdapter As DSCalculateSalaryTableAdapters.tbl_Acc_RFD_PayTableAdapter
    Friend WithEvents Tbl_Acc_RFD_PayBindingSource As BindingSource
    Friend WithEvents RFAMTLabel1 As Label
    Friend WithEvents DataSet5 As DataSet5
    Friend WithEvents View_Bonus_SalaryBindingSource As BindingSource
    Friend WithEvents View_Bonus_SalaryTableAdapter As DataSet5TableAdapters.View_Bonus_SalaryTableAdapter
    Friend WithEvents TableAdapterManager2 As DataSet5TableAdapters.TableAdapterManager
End Class
