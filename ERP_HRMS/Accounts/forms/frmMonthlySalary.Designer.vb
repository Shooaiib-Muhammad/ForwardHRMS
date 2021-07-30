<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlySalary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NameLabel As System.Windows.Forms.Label
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim GrossSalaryLabel As System.Windows.Forms.Label
        Dim TaxDeductionLabel As System.Windows.Forms.Label
        Dim EOBILabel As System.Windows.Forms.Label
        Dim TravelAllowanceLabel As System.Windows.Forms.Label
        Dim EducationAllowanceLabel As System.Windows.Forms.Label
        Dim SpecialAllowanceLabel As System.Windows.Forms.Label
        Dim MealAllowanceLabel As System.Windows.Forms.Label
        Dim ShortTermAdvanceAmoutLabel As System.Windows.Forms.Label
        Dim PaidLeavesLabel As System.Windows.Forms.Label
        Dim UnpaidLeavesLabel As System.Windows.Forms.Label
        Dim CasualLeavesLabel As System.Windows.Forms.Label
        Dim MedicalLeavesLabel As System.Windows.Forms.Label
        Dim SpecialLeavesLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim ShortLeavesHoursLabel As System.Windows.Forms.Label
        Dim DedRateLabel As System.Windows.Forms.Label
        Dim EmpIDLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim TotalPayableHoursLabel As System.Windows.Forms.Label
        Dim M2Label As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim RentDeductionLabel As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim MainDeptLabel As System.Windows.Forms.Label
        Dim SubDept1Label As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim DateOfJoiningLabel As System.Windows.Forms.Label
        Dim EndOfProbationDateLabel As System.Windows.Forms.Label
        Dim GradeLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim ExtraDayCountLabel As System.Windows.Forms.Label
        Dim AccommodationLabel As System.Windows.Forms.Label
        Dim ConteenDeductLabel As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label41 As System.Windows.Forms.Label
        Dim Label44 As System.Windows.Forms.Label
        Dim Label43 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_Emp_Info_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSCalculateSalary = New ERP_HRMS.DSCalculateSalary()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CanteenLabel = New System.Windows.Forms.Label()
        Me.AccommodationLabel2 = New System.Windows.Forms.Label()
        Me.GradeLabel1 = New System.Windows.Forms.Label()
        Me.View_Acc_EmpDeptsAndJoiningsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.DateOfJoiningLabel1 = New System.Windows.Forms.Label()
        Me.SubDept1Label1 = New System.Windows.Forms.Label()
        Me.MainDeptLabel1 = New System.Windows.Forms.Label()
        Me.OTALLabel1 = New System.Windows.Forms.Label()
        Me.RentDeductionLabel1 = New System.Windows.Forms.Label()
        Me.MealAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.SpecialAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.EducationAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.TravelAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.TaxDeductionLabel2 = New System.Windows.Forms.Label()
        Me.GrossSalaryLabel2 = New System.Windows.Forms.Label()
        Me.EmpPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.EOBILabel2 = New System.Windows.Forms.Label()
        Me.FatherNameLabel2 = New System.Windows.Forms.Label()
        Me.NameLabel2 = New System.Windows.Forms.Label()
        Me.EmpIDLabel2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PerDTA = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.EndOfProbationDateLabel1 = New System.Windows.Forms.Label()
        Me.AmountLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_ShortTermAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PerDTAPayable = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TotalHalfDaysLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalFullDaysLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblTotalMeal = New System.Windows.Forms.Label()
        Me.lblTotalPayableDays = New System.Windows.Forms.Label()
        Me.lblTotalDaysWorked = New System.Windows.Forms.Label()
        Me.lblAbsents = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblHalfDays = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lblAdds = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblBeforeFinal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.FullMinutesWorkedLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_OverTimeSumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PAdvDedRateLabel1 = New System.Windows.Forms.Label()
        Me.RFAMTLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_RFD_PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdvSumLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_PermanentAdvances1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSLongTermAdv = New ERP_HRMS.DSLongTermAdv()
        Me.lblRemaining = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TotalLeavesLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_PAdvDeductions1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DayDeductionLabel1 = New System.Windows.Forms.Label()
        Me.View_Emp_Deduction_DaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblExtraDays = New System.Windows.Forms.Label()
        Me.lblWorkingDays = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.HolidayCountLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSundays = New System.Windows.Forms.Label()
        Me.lblMonthDays = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_Info_HTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_Info_HTableAdapter()
        Me.Tbl_Hrm_Emp_InfoTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_InfoTableAdapter()
        Me.Tbl_Acc_SalaryTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_SalaryTableAdapter()
        Me.Tbl_Hrm_HolidaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_HolidaysTableAdapter()
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter()
        Me.Tbl_PayRoll_LongLeavesTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeavesTableAdapter()
        Me.Tbl_PayRoll_LongLeaves1TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves1TableAdapter()
        Me.Tbl_PayRoll_LongLeaves4TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves4TableAdapter()
        Me.Tbl_Acc_Salary_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_Salary_TransactionsTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.EveningShortMinsLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_EveningShortMinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblTotalShortMinutes = New System.Windows.Forms.Label()
        Me.lblShortAmt = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblShortDeducted = New System.Windows.Forms.Label()
        Me.txtSLeaveDeduct = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.MorningShortMinsLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_MorningShortMinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lblOverTimeHours = New System.Windows.Forms.Label()
        Me.lblOverTime = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves5TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves5TableAdapter()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves7TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves7TableAdapter()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.View_Acc_EmpDeptsAndJoiningsTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Acc_EmpDeptsAndJoiningsTableAdapter()
        Me.Tbl_PayRoll_LongLeaves6TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves6TableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.View_Rpt_Acc_OverTimeSumTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_OverTimeSumTableAdapter()
        Me.Tbl_Acc_PAdvDeductions1TableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductions1TableAdapter()
        Me.Tbl_Acc_PermanentAdvances1TableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PermanentAdvances1TableAdapter()
        Me.Tbl_Acc_PAdvDeductionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_PAdvDeductionsTableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductionsTableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_Hrm_ExtraWorkingDaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_ExtraWorkingDaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_ExtraWorkingDaysTableAdapter()
        Me.Tbl_Acc_SalaryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_SalaryTableAdapter1 = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_SalaryTableAdapter()
        Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecordTableAdapter()
        Me.View_Rpt_PayRoll_EmpAttRecord1TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecord1TableAdapter()
        Me.View_Rpt_Acc_MorningShortMinsTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_MorningShortMinsTableAdapter()
        Me.View_Rpt_Acc_EveningShortMinsTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_EveningShortMinsTableAdapter()
        Me.PESSIStatus = New System.Windows.Forms.Label()
        Me.View_Emp_Deduction_DaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Deduction_DaysTableAdapter()
        Me.View_Emp_Meal_AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_Meal_AttendanceTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Meal_AttendanceTableAdapter()
        Me.EmpCountLabel1 = New System.Windows.Forms.Label()
        Me.LblTotalMealDeduction = New System.Windows.Forms.Label()
        Me.SenStatusLabel3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.TableAdapterManager1 = New ERP_HRMS.DSCalculateSalaryTableAdapters.TableAdapterManager()
        Me.TotalDedLabel1 = New System.Windows.Forms.Label()
        Me.View_Emp_Month_Zero_LeaveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_Month_Zero_LeaveTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Month_Zero_LeaveTableAdapter()
        Me.IncStatusLabel = New System.Windows.Forms.Label()
        Me.DSSP = New ERP_HRMS.DSSP()
        Me.View_SP_OTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_SP_OTTableAdapter = New ERP_HRMS.DSSPTableAdapters.View_SP_OTTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.DSSPTableAdapters.TableAdapterManager()
        Me.SPLabel1 = New System.Windows.Forms.Label()
        Me.View_Acc_FairShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Acc_FairShopTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Acc_FairShopTableAdapter()
        Me.FairAmountLabel3 = New System.Windows.Forms.Label()
        Me.DailyTA = New System.Windows.Forms.Label()
        Me.PaymentModeLabel2 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_RFD_PayTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_RFD_PayTableAdapter()
        Me.View_Bonus_SalaryTableAdapter = New ERP_HRMS.DataSet5TableAdapters.View_Bonus_SalaryTableAdapter()
        Me.DataSet5 = New ERP_HRMS.DataSet5()
        Me.View_Bonus_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label45 = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        GrossSalaryLabel = New System.Windows.Forms.Label()
        TaxDeductionLabel = New System.Windows.Forms.Label()
        EOBILabel = New System.Windows.Forms.Label()
        TravelAllowanceLabel = New System.Windows.Forms.Label()
        EducationAllowanceLabel = New System.Windows.Forms.Label()
        SpecialAllowanceLabel = New System.Windows.Forms.Label()
        MealAllowanceLabel = New System.Windows.Forms.Label()
        ShortTermAdvanceAmoutLabel = New System.Windows.Forms.Label()
        PaidLeavesLabel = New System.Windows.Forms.Label()
        UnpaidLeavesLabel = New System.Windows.Forms.Label()
        CasualLeavesLabel = New System.Windows.Forms.Label()
        MedicalLeavesLabel = New System.Windows.Forms.Label()
        SpecialLeavesLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        ShortLeavesHoursLabel = New System.Windows.Forms.Label()
        DedRateLabel = New System.Windows.Forms.Label()
        EmpIDLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        TotalPayableHoursLabel = New System.Windows.Forms.Label()
        M2Label = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        RentDeductionLabel = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        MainDeptLabel = New System.Windows.Forms.Label()
        SubDept1Label = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        DateOfJoiningLabel = New System.Windows.Forms.Label()
        EndOfProbationDateLabel = New System.Windows.Forms.Label()
        GradeLabel = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        ExtraDayCountLabel = New System.Windows.Forms.Label()
        AccommodationLabel = New System.Windows.Forms.Label()
        ConteenDeductLabel = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label41 = New System.Windows.Forms.Label()
        Label44 = New System.Windows.Forms.Label()
        Label43 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCalculateSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_EmpDeptsAndJoiningsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.Tbl_PayRoll_LongLeaves5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.View_Rpt_Acc_OverTimeSumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Tbl_Acc_RFD_PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PermanentAdvances1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSLongTermAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PAdvDeductions1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Deduction_DaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.View_Rpt_Acc_EveningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_MorningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_ExtraWorkingDaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_SalaryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Meal_AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Month_Zero_LeaveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_SP_OTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_FairShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Bonus_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.Location = New System.Drawing.Point(9, 59)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(74, 20)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Emp Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FatherNameLabel
        '
        FatherNameLabel.Location = New System.Drawing.Point(9, 82)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(74, 20)
        FatherNameLabel.TabIndex = 6
        FatherNameLabel.Text = "Father Name:"
        FatherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GrossSalaryLabel
        '
        GrossSalaryLabel.Location = New System.Drawing.Point(260, 36)
        GrossSalaryLabel.Name = "GrossSalaryLabel"
        GrossSalaryLabel.Size = New System.Drawing.Size(97, 20)
        GrossSalaryLabel.TabIndex = 0
        GrossSalaryLabel.Text = "Gross Salary:"
        GrossSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TaxDeductionLabel
        '
        TaxDeductionLabel.Location = New System.Drawing.Point(488, 82)
        TaxDeductionLabel.Name = "TaxDeductionLabel"
        TaxDeductionLabel.Size = New System.Drawing.Size(107, 20)
        TaxDeductionLabel.TabIndex = 2
        TaxDeductionLabel.Text = "Tax Deduction:"
        TaxDeductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EOBILabel
        '
        EOBILabel.Location = New System.Drawing.Point(488, 59)
        EOBILabel.Name = "EOBILabel"
        EOBILabel.Size = New System.Drawing.Size(107, 20)
        EOBILabel.TabIndex = 4
        EOBILabel.Text = "EOBI:"
        EOBILabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TravelAllowanceLabel
        '
        TravelAllowanceLabel.Location = New System.Drawing.Point(260, 105)
        TravelAllowanceLabel.Name = "TravelAllowanceLabel"
        TravelAllowanceLabel.Size = New System.Drawing.Size(97, 20)
        TravelAllowanceLabel.TabIndex = 6
        TravelAllowanceLabel.Text = "Travel Allowance:"
        TravelAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EducationAllowanceLabel
        '
        EducationAllowanceLabel.Location = New System.Drawing.Point(260, 129)
        EducationAllowanceLabel.Name = "EducationAllowanceLabel"
        EducationAllowanceLabel.Size = New System.Drawing.Size(97, 20)
        EducationAllowanceLabel.TabIndex = 8
        EducationAllowanceLabel.Text = "Edu. Allowance:"
        EducationAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpecialAllowanceLabel
        '
        SpecialAllowanceLabel.Location = New System.Drawing.Point(260, 59)
        SpecialAllowanceLabel.Name = "SpecialAllowanceLabel"
        SpecialAllowanceLabel.Size = New System.Drawing.Size(97, 20)
        SpecialAllowanceLabel.TabIndex = 10
        SpecialAllowanceLabel.Text = "Special Allowance:"
        SpecialAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MealAllowanceLabel
        '
        MealAllowanceLabel.Location = New System.Drawing.Point(260, 82)
        MealAllowanceLabel.Name = "MealAllowanceLabel"
        MealAllowanceLabel.Size = New System.Drawing.Size(97, 20)
        MealAllowanceLabel.TabIndex = 12
        MealAllowanceLabel.Text = "Meal Allowance:"
        MealAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShortTermAdvanceAmoutLabel
        '
        ShortTermAdvanceAmoutLabel.Location = New System.Drawing.Point(9, 84)
        ShortTermAdvanceAmoutLabel.Name = "ShortTermAdvanceAmoutLabel"
        ShortTermAdvanceAmoutLabel.Size = New System.Drawing.Size(99, 20)
        ShortTermAdvanceAmoutLabel.TabIndex = 2
        ShortTermAdvanceAmoutLabel.Text = "Temparary Adv.:"
        ShortTermAdvanceAmoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PaidLeavesLabel
        '
        PaidLeavesLabel.Location = New System.Drawing.Point(362, 35)
        PaidLeavesLabel.Name = "PaidLeavesLabel"
        PaidLeavesLabel.Size = New System.Drawing.Size(89, 20)
        PaidLeavesLabel.TabIndex = 0
        PaidLeavesLabel.Text = "Total Paid:"
        PaidLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UnpaidLeavesLabel
        '
        UnpaidLeavesLabel.Location = New System.Drawing.Point(362, 59)
        UnpaidLeavesLabel.Name = "UnpaidLeavesLabel"
        UnpaidLeavesLabel.Size = New System.Drawing.Size(89, 20)
        UnpaidLeavesLabel.TabIndex = 2
        UnpaidLeavesLabel.Text = "Total Unpaid:"
        UnpaidLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CasualLeavesLabel
        '
        CasualLeavesLabel.Location = New System.Drawing.Point(9, 35)
        CasualLeavesLabel.Name = "CasualLeavesLabel"
        CasualLeavesLabel.Size = New System.Drawing.Size(80, 20)
        CasualLeavesLabel.TabIndex = 4
        CasualLeavesLabel.Text = "Paid Casual:"
        CasualLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MedicalLeavesLabel
        '
        MedicalLeavesLabel.Location = New System.Drawing.Point(179, 35)
        MedicalLeavesLabel.Name = "MedicalLeavesLabel"
        MedicalLeavesLabel.Size = New System.Drawing.Size(95, 20)
        MedicalLeavesLabel.TabIndex = 8
        MedicalLeavesLabel.Text = "Paid M1/Sick:"
        MedicalLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpecialLeavesLabel
        '
        SpecialLeavesLabel.Location = New System.Drawing.Point(9, 59)
        SpecialLeavesLabel.Name = "SpecialLeavesLabel"
        SpecialLeavesLabel.Size = New System.Drawing.Size(78, 20)
        SpecialLeavesLabel.TabIndex = 10
        SpecialLeavesLabel.Text = "Paid Special:"
        SpecialLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(220, 10)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(87, 20)
        Label4.TabIndex = 3
        Label4.Text = "Card No:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShortLeavesHoursLabel
        '
        ShortLeavesHoursLabel.Location = New System.Drawing.Point(488, 175)
        ShortLeavesHoursLabel.Name = "ShortLeavesHoursLabel"
        ShortLeavesHoursLabel.Size = New System.Drawing.Size(107, 20)
        ShortLeavesHoursLabel.TabIndex = 0
        ShortLeavesHoursLabel.Text = "OT Adjusted Leaves:"
        ShortLeavesHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DedRateLabel
        '
        DedRateLabel.Location = New System.Drawing.Point(264, 33)
        DedRateLabel.Name = "DedRateLabel"
        DedRateLabel.Size = New System.Drawing.Size(96, 20)
        DedRateLabel.TabIndex = 0
        DedRateLabel.Text = "Deduction Rate:"
        DedRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpIDLabel
        '
        EmpIDLabel.Location = New System.Drawing.Point(9, 36)
        EmpIDLabel.Name = "EmpIDLabel"
        EmpIDLabel.Size = New System.Drawing.Size(74, 20)
        EmpIDLabel.TabIndex = 26
        EmpIDLabel.Text = "Serial No:"
        EmpIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AmountLabel
        '
        AmountLabel.Location = New System.Drawing.Point(9, 34)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(94, 20)
        AmountLabel.TabIndex = 25
        AmountLabel.Text = "Permanent Adv.:"
        AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalPayableHoursLabel
        '
        TotalPayableHoursLabel.Location = New System.Drawing.Point(6, 33)
        TotalPayableHoursLabel.Name = "TotalPayableHoursLabel"
        TotalPayableHoursLabel.Size = New System.Drawing.Size(89, 20)
        TotalPayableHoursLabel.TabIndex = 0
        TotalPayableHoursLabel.Text = "OverTime Hours:"
        TotalPayableHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M2Label
        '
        M2Label.Location = New System.Drawing.Point(179, 59)
        M2Label.Name = "M2Label"
        M2Label.Size = New System.Drawing.Size(95, 20)
        M2Label.TabIndex = 35
        M2Label.Text = "Paid M2 Leaves:"
        M2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Label25.Location = New System.Drawing.Point(12, 83)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(61, 20)
        Label25.TabIndex = 0
        Label25.Text = "OT Hours:"
        Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RentDeductionLabel
        '
        RentDeductionLabel.Location = New System.Drawing.Point(488, 105)
        RentDeductionLabel.Name = "RentDeductionLabel"
        RentDeductionLabel.Size = New System.Drawing.Size(107, 20)
        RentDeductionLabel.TabIndex = 0
        RentDeductionLabel.Text = "Rent Amount:"
        RentDeductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Label23.Location = New System.Drawing.Point(9, 59)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(96, 20)
        Label23.TabIndex = 42
        Label23.Text = "P Adv. Remaining:"
        Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainDeptLabel
        '
        MainDeptLabel.Location = New System.Drawing.Point(9, 129)
        MainDeptLabel.Name = "MainDeptLabel"
        MainDeptLabel.Size = New System.Drawing.Size(74, 20)
        MainDeptLabel.TabIndex = 53
        MainDeptLabel.Text = "Department:"
        MainDeptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SubDept1Label
        '
        SubDept1Label.Location = New System.Drawing.Point(9, 152)
        SubDept1Label.Name = "SubDept1Label"
        SubDept1Label.Size = New System.Drawing.Size(74, 20)
        SubDept1Label.TabIndex = 54
        SubDept1Label.Text = "Section:"
        SubDept1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        DesigNameLabel.Location = New System.Drawing.Point(9, 175)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(74, 20)
        DesigNameLabel.TabIndex = 55
        DesigNameLabel.Text = "Designation:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfJoiningLabel
        '
        DateOfJoiningLabel.BackColor = System.Drawing.Color.Transparent
        DateOfJoiningLabel.Location = New System.Drawing.Point(488, 36)
        DateOfJoiningLabel.Name = "DateOfJoiningLabel"
        DateOfJoiningLabel.Size = New System.Drawing.Size(107, 20)
        DateOfJoiningLabel.TabIndex = 56
        DateOfJoiningLabel.Text = "Date Of Joining:"
        DateOfJoiningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EndOfProbationDateLabel
        '
        EndOfProbationDateLabel.BackColor = System.Drawing.Color.Transparent
        EndOfProbationDateLabel.Location = New System.Drawing.Point(268, 674)
        EndOfProbationDateLabel.Name = "EndOfProbationDateLabel"
        EndOfProbationDateLabel.Size = New System.Drawing.Size(101, 20)
        EndOfProbationDateLabel.TabIndex = 57
        EndOfProbationDateLabel.Text = "Date Of Permanent"
        EndOfProbationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        EndOfProbationDateLabel.Visible = False
        '
        'GradeLabel
        '
        GradeLabel.Location = New System.Drawing.Point(9, 105)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New System.Drawing.Size(74, 20)
        GradeLabel.TabIndex = 59
        GradeLabel.Text = "Grade:"
        GradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Label13.Location = New System.Drawing.Point(264, 59)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(96, 20)
        Label13.TabIndex = 62
        Label13.Text = "P Adv. To Deduct:"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExtraDayCountLabel
        '
        ExtraDayCountLabel.Location = New System.Drawing.Point(299, 32)
        ExtraDayCountLabel.Name = "ExtraDayCountLabel"
        ExtraDayCountLabel.Size = New System.Drawing.Size(50, 46)
        ExtraDayCountLabel.TabIndex = 62
        ExtraDayCountLabel.Text = "Extra Working Days:"
        ExtraDayCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AccommodationLabel
        '
        AccommodationLabel.Location = New System.Drawing.Point(260, 152)
        AccommodationLabel.Name = "AccommodationLabel"
        AccommodationLabel.Size = New System.Drawing.Size(97, 20)
        AccommodationLabel.TabIndex = 62
        AccommodationLabel.Text = "Acc. Allowance:"
        AccommodationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConteenDeductLabel
        '
        ConteenDeductLabel.Location = New System.Drawing.Point(488, 152)
        ConteenDeductLabel.Name = "ConteenDeductLabel"
        ConteenDeductLabel.Size = New System.Drawing.Size(107, 20)
        ConteenDeductLabel.TabIndex = 63
        ConteenDeductLabel.Text = "Canteen Deduct:"
        ConteenDeductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Label14.Location = New System.Drawing.Point(488, 129)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(107, 20)
        Label14.TabIndex = 65
        Label14.Text = "Fair Price Amount :"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label41.Location = New System.Drawing.Point(6, 80)
        Label41.Name = "Label41"
        Label41.Size = New System.Drawing.Size(90, 20)
        Label41.TabIndex = 83
        Label41.Text = "OTT Allowance:"
        Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Label44.Location = New System.Drawing.Point(260, 175)
        Label44.Name = "Label44"
        Label44.Size = New System.Drawing.Size(97, 20)
        Label44.TabIndex = 117
        Label44.Text = "Payment Mode :"
        Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Label43.Location = New System.Drawing.Point(453, 60)
        Label43.Name = "Label43"
        Label43.Size = New System.Drawing.Size(38, 20)
        Label43.TabIndex = 121
        Label43.Text = "RFD.:"
        Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1199, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Monthly Salary Manually Calculation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.CardNoComboBox)
        Me.Panel1.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(5, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 72)
        Me.Panel1.TabIndex = 9
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Maroon
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.Yellow
        Me.CheckBox3.Location = New System.Drawing.Point(19, 38)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(195, 20)
        Me.CheckBox3.TabIndex = 46
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.Text = "Un-Check For Zero Meal Allowance"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(114, 10)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 28
        Me.DateTimePicker1.TabStop = False
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(220, 36)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(87, 20)
        Me.Label34.TabIndex = 26
        Me.Label34.Text = "Financial Period:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(313, 9)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CardNoComboBox.TabIndex = 1
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
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinancialPeriodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(313, 35)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(121, 21)
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
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(21, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Month:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(927, 132)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 40)
        Me.btnSave.TabIndex = 8
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label45)
        Me.Panel3.Controls.Add(Me.Label42)
        Me.Panel3.Controls.Add(Label44)
        Me.Panel3.Controls.Add(Label14)
        Me.Panel3.Controls.Add(Me.CanteenLabel)
        Me.Panel3.Controls.Add(Me.AccommodationLabel2)
        Me.Panel3.Controls.Add(ConteenDeductLabel)
        Me.Panel3.Controls.Add(AccommodationLabel)
        Me.Panel3.Controls.Add(GradeLabel)
        Me.Panel3.Controls.Add(Me.GradeLabel1)
        Me.Panel3.Controls.Add(DesigNameLabel)
        Me.Panel3.Controls.Add(Me.DesigNameLabel1)
        Me.Panel3.Controls.Add(DateOfJoiningLabel)
        Me.Panel3.Controls.Add(SubDept1Label)
        Me.Panel3.Controls.Add(Me.DateOfJoiningLabel1)
        Me.Panel3.Controls.Add(Me.SubDept1Label1)
        Me.Panel3.Controls.Add(MainDeptLabel)
        Me.Panel3.Controls.Add(Me.MainDeptLabel1)
        Me.Panel3.Controls.Add(Me.OTALLabel1)
        Me.Panel3.Controls.Add(Me.RentDeductionLabel1)
        Me.Panel3.Controls.Add(ShortLeavesHoursLabel)
        Me.Panel3.Controls.Add(RentDeductionLabel)
        Me.Panel3.Controls.Add(Me.MealAllowanceLabel2)
        Me.Panel3.Controls.Add(Me.SpecialAllowanceLabel2)
        Me.Panel3.Controls.Add(Me.EducationAllowanceLabel2)
        Me.Panel3.Controls.Add(Me.TravelAllowanceLabel2)
        Me.Panel3.Controls.Add(Me.TaxDeductionLabel2)
        Me.Panel3.Controls.Add(Me.GrossSalaryLabel2)
        Me.Panel3.Controls.Add(Me.EmpPicPictureBox)
        Me.Panel3.Controls.Add(Me.EOBILabel2)
        Me.Panel3.Controls.Add(EOBILabel)
        Me.Panel3.Controls.Add(Me.FatherNameLabel2)
        Me.Panel3.Controls.Add(Me.NameLabel2)
        Me.Panel3.Controls.Add(Me.EmpIDLabel2)
        Me.Panel3.Controls.Add(EmpIDLabel)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(GrossSalaryLabel)
        Me.Panel3.Controls.Add(TaxDeductionLabel)
        Me.Panel3.Controls.Add(FatherNameLabel)
        Me.Panel3.Controls.Add(TravelAllowanceLabel)
        Me.Panel3.Controls.Add(EducationAllowanceLabel)
        Me.Panel3.Controls.Add(NameLabel)
        Me.Panel3.Controls.Add(SpecialAllowanceLabel)
        Me.Panel3.Controls.Add(MealAllowanceLabel)
        Me.Panel3.Location = New System.Drawing.Point(5, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(918, 203)
        Me.Panel3.TabIndex = 11
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.White
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "PaymentMode", True))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(358, 175)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(125, 20)
        Me.Label42.TabIndex = 118
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_SalaryBindingSource
        '
        Me.Tbl_Acc_SalaryBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_Salary"
        Me.Tbl_Acc_SalaryBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Tbl_Hrm_Emp_InfoBindingSource
        '
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataMember = "tbl_Hrm_Emp_Info_H_tbl_Hrm_Emp_Info"
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves7BindingSource, "OTAL", True))
        Me.Label3.Location = New System.Drawing.Point(997, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 66
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Tbl_PayRoll_LongLeaves7BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves7BindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_PayRoll_LongLeaves7"
        Me.Tbl_PayRoll_LongLeaves7BindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'CanteenLabel
        '
        Me.CanteenLabel.BackColor = System.Drawing.Color.White
        Me.CanteenLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CanteenLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "ConteenDeduct", True))
        Me.CanteenLabel.Location = New System.Drawing.Point(600, 152)
        Me.CanteenLabel.Name = "CanteenLabel"
        Me.CanteenLabel.Size = New System.Drawing.Size(137, 20)
        Me.CanteenLabel.TabIndex = 64
        Me.CanteenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccommodationLabel2
        '
        Me.AccommodationLabel2.BackColor = System.Drawing.Color.White
        Me.AccommodationLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AccommodationLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "Accommodation", True))
        Me.AccommodationLabel2.Location = New System.Drawing.Point(358, 152)
        Me.AccommodationLabel2.Name = "AccommodationLabel2"
        Me.AccommodationLabel2.Size = New System.Drawing.Size(125, 20)
        Me.AccommodationLabel2.TabIndex = 64
        Me.AccommodationLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GradeLabel1
        '
        Me.GradeLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.GradeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_EmpDeptsAndJoiningsBindingSource, "Grade", True))
        Me.GradeLabel1.Location = New System.Drawing.Point(87, 105)
        Me.GradeLabel1.Name = "GradeLabel1"
        Me.GradeLabel1.Size = New System.Drawing.Size(167, 20)
        Me.GradeLabel1.TabIndex = 60
        Me.GradeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'View_Acc_EmpDeptsAndJoiningsBindingSource
        '
        Me.View_Acc_EmpDeptsAndJoiningsBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Acc_EmpDeptsAndJoinings"
        Me.View_Acc_EmpDeptsAndJoiningsBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_EmpDeptsAndJoiningsBindingSource, "DesigName", True))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(87, 175)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(167, 20)
        Me.DesigNameLabel1.TabIndex = 56
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfJoiningLabel1
        '
        Me.DateOfJoiningLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.DateOfJoiningLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateOfJoiningLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_EmpDeptsAndJoiningsBindingSource, "DateOfJoining", True))
        Me.DateOfJoiningLabel1.Location = New System.Drawing.Point(600, 36)
        Me.DateOfJoiningLabel1.Name = "DateOfJoiningLabel1"
        Me.DateOfJoiningLabel1.Size = New System.Drawing.Size(137, 20)
        Me.DateOfJoiningLabel1.TabIndex = 57
        Me.DateOfJoiningLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubDept1Label1
        '
        Me.SubDept1Label1.BackColor = System.Drawing.SystemColors.Window
        Me.SubDept1Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubDept1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_EmpDeptsAndJoiningsBindingSource, "SubDept1", True))
        Me.SubDept1Label1.Location = New System.Drawing.Point(87, 152)
        Me.SubDept1Label1.Name = "SubDept1Label1"
        Me.SubDept1Label1.Size = New System.Drawing.Size(167, 20)
        Me.SubDept1Label1.TabIndex = 55
        Me.SubDept1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainDeptLabel1
        '
        Me.MainDeptLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.MainDeptLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainDeptLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_EmpDeptsAndJoiningsBindingSource, "MainDept", True))
        Me.MainDeptLabel1.Location = New System.Drawing.Point(87, 129)
        Me.MainDeptLabel1.Name = "MainDeptLabel1"
        Me.MainDeptLabel1.Size = New System.Drawing.Size(167, 20)
        Me.MainDeptLabel1.TabIndex = 54
        Me.MainDeptLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OTALLabel1
        '
        Me.OTALLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.OTALLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OTALLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves7BindingSource, "OTAL", True))
        Me.OTALLabel1.Location = New System.Drawing.Point(600, 175)
        Me.OTALLabel1.Name = "OTALLabel1"
        Me.OTALLabel1.Size = New System.Drawing.Size(137, 20)
        Me.OTALLabel1.TabIndex = 53
        Me.OTALLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RentDeductionLabel1
        '
        Me.RentDeductionLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.RentDeductionLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RentDeductionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "RentDeduction", True))
        Me.RentDeductionLabel1.Location = New System.Drawing.Point(600, 105)
        Me.RentDeductionLabel1.Name = "RentDeductionLabel1"
        Me.RentDeductionLabel1.Size = New System.Drawing.Size(137, 20)
        Me.RentDeductionLabel1.TabIndex = 1
        Me.RentDeductionLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MealAllowanceLabel2
        '
        Me.MealAllowanceLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.MealAllowanceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MealAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "MealAllowance", True))
        Me.MealAllowanceLabel2.Location = New System.Drawing.Point(358, 82)
        Me.MealAllowanceLabel2.Name = "MealAllowanceLabel2"
        Me.MealAllowanceLabel2.Size = New System.Drawing.Size(125, 20)
        Me.MealAllowanceLabel2.TabIndex = 48
        Me.MealAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SpecialAllowanceLabel2
        '
        Me.SpecialAllowanceLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.SpecialAllowanceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpecialAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "SpecialAllowance", True))
        Me.SpecialAllowanceLabel2.Location = New System.Drawing.Point(358, 59)
        Me.SpecialAllowanceLabel2.Name = "SpecialAllowanceLabel2"
        Me.SpecialAllowanceLabel2.Size = New System.Drawing.Size(125, 20)
        Me.SpecialAllowanceLabel2.TabIndex = 47
        Me.SpecialAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EducationAllowanceLabel2
        '
        Me.EducationAllowanceLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.EducationAllowanceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EducationAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "EducationAllowance", True))
        Me.EducationAllowanceLabel2.Location = New System.Drawing.Point(358, 129)
        Me.EducationAllowanceLabel2.Name = "EducationAllowanceLabel2"
        Me.EducationAllowanceLabel2.Size = New System.Drawing.Size(125, 20)
        Me.EducationAllowanceLabel2.TabIndex = 46
        Me.EducationAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TravelAllowanceLabel2
        '
        Me.TravelAllowanceLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.TravelAllowanceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TravelAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "TravelAllowance", True))
        Me.TravelAllowanceLabel2.Location = New System.Drawing.Point(358, 105)
        Me.TravelAllowanceLabel2.Name = "TravelAllowanceLabel2"
        Me.TravelAllowanceLabel2.Size = New System.Drawing.Size(125, 20)
        Me.TravelAllowanceLabel2.TabIndex = 44
        Me.TravelAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TaxDeductionLabel2
        '
        Me.TaxDeductionLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.TaxDeductionLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaxDeductionLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "TaxDeduction", True))
        Me.TaxDeductionLabel2.Location = New System.Drawing.Point(600, 82)
        Me.TaxDeductionLabel2.Name = "TaxDeductionLabel2"
        Me.TaxDeductionLabel2.Size = New System.Drawing.Size(137, 20)
        Me.TaxDeductionLabel2.TabIndex = 42
        Me.TaxDeductionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GrossSalaryLabel2
        '
        Me.GrossSalaryLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.GrossSalaryLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrossSalaryLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "GrossSalary", True))
        Me.GrossSalaryLabel2.Location = New System.Drawing.Point(358, 36)
        Me.GrossSalaryLabel2.Name = "GrossSalaryLabel2"
        Me.GrossSalaryLabel2.Size = New System.Drawing.Size(125, 20)
        Me.GrossSalaryLabel2.TabIndex = 41
        Me.GrossSalaryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmpPicPictureBox
        '
        Me.EmpPicPictureBox.BackColor = System.Drawing.SystemColors.Window
        Me.EmpPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpPic", True))
        Me.EmpPicPictureBox.Location = New System.Drawing.Point(743, 36)
        Me.EmpPicPictureBox.Name = "EmpPicPictureBox"
        Me.EmpPicPictureBox.Size = New System.Drawing.Size(153, 159)
        Me.EmpPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPicPictureBox.TabIndex = 40
        Me.EmpPicPictureBox.TabStop = False
        '
        'EOBILabel2
        '
        Me.EOBILabel2.BackColor = System.Drawing.SystemColors.Window
        Me.EOBILabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EOBILabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "EOBI", True))
        Me.EOBILabel2.Location = New System.Drawing.Point(600, 59)
        Me.EOBILabel2.Name = "EOBILabel2"
        Me.EOBILabel2.Size = New System.Drawing.Size(137, 20)
        Me.EOBILabel2.TabIndex = 43
        Me.EOBILabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FatherNameLabel2
        '
        Me.FatherNameLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.FatherNameLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FatherNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "FatherName", True))
        Me.FatherNameLabel2.Location = New System.Drawing.Point(87, 82)
        Me.FatherNameLabel2.Name = "FatherNameLabel2"
        Me.FatherNameLabel2.Size = New System.Drawing.Size(167, 20)
        Me.FatherNameLabel2.TabIndex = 39
        Me.FatherNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel2
        '
        Me.NameLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.NameLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "Name", True))
        Me.NameLabel2.Location = New System.Drawing.Point(87, 59)
        Me.NameLabel2.Name = "NameLabel2"
        Me.NameLabel2.Size = New System.Drawing.Size(167, 20)
        Me.NameLabel2.TabIndex = 38
        Me.NameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpIDLabel2
        '
        Me.EmpIDLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.EmpIDLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpID", True))
        Me.EmpIDLabel2.Location = New System.Drawing.Point(87, 36)
        Me.EmpIDLabel2.Name = "EmpIDLabel2"
        Me.EmpIDLabel2.Size = New System.Drawing.Size(61, 20)
        Me.EmpIDLabel2.TabIndex = 37
        Me.EmpIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(916, 25)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Employees BioData And Salary Record"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PerDTA
        '
        Me.PerDTA.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PerDTA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "DailyTravelAllowance", True))
        Me.PerDTA.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PerDTA.Location = New System.Drawing.Point(929, 268)
        Me.PerDTA.Name = "PerDTA"
        Me.PerDTA.Size = New System.Drawing.Size(51, 20)
        Me.PerDTA.TabIndex = 116
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Window
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.ForeColor = System.Drawing.Color.Red
        Me.Label33.Location = New System.Drawing.Point(366, 59)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(85, 20)
        Me.Label33.TabIndex = 61
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EndOfProbationDateLabel1
        '
        Me.EndOfProbationDateLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.EndOfProbationDateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EndOfProbationDateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_EmpDeptsAndJoiningsBindingSource, "DateOfPermanent", True))
        Me.EndOfProbationDateLabel1.Location = New System.Drawing.Point(381, 674)
        Me.EndOfProbationDateLabel1.Name = "EndOfProbationDateLabel1"
        Me.EndOfProbationDateLabel1.Size = New System.Drawing.Size(137, 20)
        Me.EndOfProbationDateLabel1.TabIndex = 58
        Me.EndOfProbationDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.EndOfProbationDateLabel1.Visible = False
        '
        'AmountLabel1
        '
        Me.AmountLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.AmountLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_ShortTermAdvancesBindingSource, "Amount", True))
        Me.AmountLabel1.Location = New System.Drawing.Point(111, 84)
        Me.AmountLabel1.Name = "AmountLabel1"
        Me.AmountLabel1.Size = New System.Drawing.Size(131, 20)
        Me.AmountLabel1.TabIndex = 25
        Me.AmountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_Acc_ShortTermAdvancesBindingSource
        '
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_ShortTermAdvances"
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_Info_HBindingSource, "CardNo", True))
        Me.CardNoLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.CardNoLabel1.Location = New System.Drawing.Point(894, 446)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(34, 18)
        Me.CardNoLabel1.TabIndex = 50
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.PerDTAPayable)
        Me.Panel6.Controls.Add(Me.Label51)
        Me.Panel6.Controls.Add(Me.TotalHalfDaysLabel1)
        Me.Panel6.Controls.Add(Me.TotalFullDaysLabel1)
        Me.Panel6.Controls.Add(Me.lblTotalMeal)
        Me.Panel6.Controls.Add(Me.lblTotalPayableDays)
        Me.Panel6.Controls.Add(Me.lblTotalDaysWorked)
        Me.Panel6.Controls.Add(Me.lblAbsents)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.lblHalfDays)
        Me.Panel6.Controls.Add(Me.lblTotalDays)
        Me.Panel6.Location = New System.Drawing.Point(5, 435)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(568, 119)
        Me.Panel6.TabIndex = 14
        '
        'PerDTAPayable
        '
        Me.PerDTAPayable.BackColor = System.Drawing.SystemColors.Window
        Me.PerDTAPayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PerDTAPayable.Location = New System.Drawing.Point(178, 81)
        Me.PerDTAPayable.Name = "PerDTAPayable"
        Me.PerDTAPayable.Size = New System.Drawing.Size(70, 20)
        Me.PerDTAPayable.TabIndex = 88
        Me.PerDTAPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(9, 75)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(169, 33)
        Me.Label51.TabIndex = 87
        Me.Label51.Text = "Daily Travel Allowance Payable:"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalHalfDaysLabel1
        '
        Me.TotalHalfDaysLabel1.BackColor = System.Drawing.Color.White
        Me.TotalHalfDaysLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalHalfDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource, "TotalHalfDays", True))
        Me.TotalHalfDaysLabel1.Location = New System.Drawing.Point(280, 30)
        Me.TotalHalfDaysLabel1.Name = "TotalHalfDaysLabel1"
        Me.TotalHalfDaysLabel1.Size = New System.Drawing.Size(70, 20)
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
        Me.TotalFullDaysLabel1.BackColor = System.Drawing.Color.White
        Me.TotalFullDaysLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalFullDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, "TotalFullDays", True))
        Me.TotalFullDaysLabel1.Location = New System.Drawing.Point(87, 30)
        Me.TotalFullDaysLabel1.Name = "TotalFullDaysLabel1"
        Me.TotalFullDaysLabel1.Size = New System.Drawing.Size(81, 20)
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
        Me.lblTotalMeal.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalMeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalMeal.Location = New System.Drawing.Point(457, 55)
        Me.lblTotalMeal.Name = "lblTotalMeal"
        Me.lblTotalMeal.Size = New System.Drawing.Size(81, 20)
        Me.lblTotalMeal.TabIndex = 33
        Me.lblTotalMeal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalPayableDays
        '
        Me.lblTotalPayableDays.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalPayableDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPayableDays.Location = New System.Drawing.Point(87, 55)
        Me.lblTotalPayableDays.Name = "lblTotalPayableDays"
        Me.lblTotalPayableDays.Size = New System.Drawing.Size(80, 20)
        Me.lblTotalPayableDays.TabIndex = 32
        Me.lblTotalPayableDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalDaysWorked
        '
        Me.lblTotalDaysWorked.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalDaysWorked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDaysWorked.Location = New System.Drawing.Point(457, 30)
        Me.lblTotalDaysWorked.Name = "lblTotalDaysWorked"
        Me.lblTotalDaysWorked.Size = New System.Drawing.Size(81, 20)
        Me.lblTotalDaysWorked.TabIndex = 31
        Me.lblTotalDaysWorked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAbsents
        '
        Me.lblAbsents.BackColor = System.Drawing.SystemColors.Window
        Me.lblAbsents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAbsents.Location = New System.Drawing.Point(280, 55)
        Me.lblAbsents.Name = "lblAbsents"
        Me.lblAbsents.Size = New System.Drawing.Size(70, 20)
        Me.lblAbsents.TabIndex = 30
        Me.lblAbsents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label17.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(0, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(566, 25)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Employees Attendence Record"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(362, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Meal Payable:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(9, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Payable Days:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(179, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total Absentees:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(362, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Full + Half Days"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHalfDays
        '
        Me.lblHalfDays.Location = New System.Drawing.Point(179, 30)
        Me.lblHalfDays.Name = "lblHalfDays"
        Me.lblHalfDays.Size = New System.Drawing.Size(95, 20)
        Me.lblHalfDays.TabIndex = 2
        Me.lblHalfDays.Text = "Total Half Days:"
        Me.lblHalfDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalDays
        '
        Me.lblTotalDays.Location = New System.Drawing.Point(9, 30)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(82, 20)
        Me.lblTotalDays.TabIndex = 0
        Me.lblTotalDays.Text = "Total Full Days: "
        Me.lblTotalDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.UnPaidLeavesLabel2)
        Me.Panel7.Controls.Add(M2Label)
        Me.Panel7.Controls.Add(Me.M2Label1)
        Me.Panel7.Controls.Add(Me.M1Label1)
        Me.Panel7.Controls.Add(Me.PaidLeavesLabel2)
        Me.Panel7.Controls.Add(Me.SpecialLeaveLabel1)
        Me.Panel7.Controls.Add(Me.CasualLeaveLabel1)
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(SpecialLeavesLabel)
        Me.Panel7.Controls.Add(MedicalLeavesLabel)
        Me.Panel7.Controls.Add(CasualLeavesLabel)
        Me.Panel7.Controls.Add(UnpaidLeavesLabel)
        Me.Panel7.Controls.Add(PaidLeavesLabel)
        Me.Panel7.Location = New System.Drawing.Point(5, 559)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(568, 96)
        Me.Panel7.TabIndex = 15
        '
        'UnPaidLeavesLabel2
        '
        Me.UnPaidLeavesLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.UnPaidLeavesLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UnPaidLeavesLabel2.Location = New System.Drawing.Point(457, 59)
        Me.UnPaidLeavesLabel2.Name = "UnPaidLeavesLabel2"
        Me.UnPaidLeavesLabel2.Size = New System.Drawing.Size(81, 20)
        Me.UnPaidLeavesLabel2.TabIndex = 37
        Me.UnPaidLeavesLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'M2Label1
        '
        Me.M2Label1.BackColor = System.Drawing.SystemColors.Window
        Me.M2Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves5BindingSource, "M2", True))
        Me.M2Label1.Location = New System.Drawing.Point(280, 59)
        Me.M2Label1.Name = "M2Label1"
        Me.M2Label1.Size = New System.Drawing.Size(70, 20)
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
        Me.M1Label1.BackColor = System.Drawing.SystemColors.Window
        Me.M1Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves1BindingSource, "M1", True))
        Me.M1Label1.Location = New System.Drawing.Point(280, 35)
        Me.M1Label1.Name = "M1Label1"
        Me.M1Label1.Size = New System.Drawing.Size(70, 20)
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
        Me.PaidLeavesLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.PaidLeavesLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaidLeavesLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves4BindingSource, "PaidLeaves", True))
        Me.PaidLeavesLabel2.Location = New System.Drawing.Point(457, 35)
        Me.PaidLeavesLabel2.Name = "PaidLeavesLabel2"
        Me.PaidLeavesLabel2.Size = New System.Drawing.Size(81, 20)
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
        Me.SpecialLeaveLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.SpecialLeaveLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpecialLeaveLabel1.Location = New System.Drawing.Point(87, 59)
        Me.SpecialLeaveLabel1.Name = "SpecialLeaveLabel1"
        Me.SpecialLeaveLabel1.Size = New System.Drawing.Size(81, 20)
        Me.SpecialLeaveLabel1.TabIndex = 29
        Me.SpecialLeaveLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CasualLeaveLabel1
        '
        Me.CasualLeaveLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.CasualLeaveLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CasualLeaveLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeavesBindingSource, "CasualLeave", True))
        Me.CasualLeaveLabel1.Location = New System.Drawing.Point(87, 35)
        Me.CasualLeaveLabel1.Name = "CasualLeaveLabel1"
        Me.CasualLeaveLabel1.Size = New System.Drawing.Size(81, 20)
        Me.CasualLeaveLabel1.TabIndex = 26
        Me.CasualLeaveLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_PayRoll_LongLeavesBindingSource
        '
        Me.Tbl_PayRoll_LongLeavesBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_PayRoll_LongLeaves"
        Me.Tbl_PayRoll_LongLeavesBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(566, 25)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Employees Leaves Record"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(275, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 23)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Final Amt :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSalary
        '
        Me.lblSalary.BackColor = System.Drawing.SystemColors.Window
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.ForeColor = System.Drawing.Color.Purple
        Me.lblSalary.Location = New System.Drawing.Point(385, 10)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(120, 23)
        Me.lblSalary.TabIndex = 19
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.lblAdds)
        Me.Panel9.Controls.Add(Me.Label35)
        Me.Panel9.Controls.Add(Me.lblBeforeFinal)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Controls.Add(Me.Label26)
        Me.Panel9.Controls.Add(Me.lblSalary)
        Me.Panel9.Controls.Add(Me.Label9)
        Me.Panel9.Location = New System.Drawing.Point(461, 33)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(539, 72)
        Me.Panel9.TabIndex = 20
        '
        'lblAdds
        '
        Me.lblAdds.BackColor = System.Drawing.SystemColors.Window
        Me.lblAdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdds.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdds.ForeColor = System.Drawing.Color.Purple
        Me.lblAdds.Location = New System.Drawing.Point(149, 9)
        Me.lblAdds.Name = "lblAdds"
        Me.lblAdds.Size = New System.Drawing.Size(112, 23)
        Me.lblAdds.TabIndex = 24
        Me.lblAdds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(4, 9)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(109, 23)
        Me.Label35.TabIndex = 23
        Me.Label35.Text = "Total Add :"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeforeFinal
        '
        Me.lblBeforeFinal.BackColor = System.Drawing.SystemColors.Window
        Me.lblBeforeFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeforeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeforeFinal.ForeColor = System.Drawing.Color.Purple
        Me.lblBeforeFinal.Location = New System.Drawing.Point(149, 36)
        Me.lblBeforeFinal.Name = "lblBeforeFinal"
        Me.lblBeforeFinal.Size = New System.Drawing.Size(112, 23)
        Me.lblBeforeFinal.TabIndex = 22
        Me.lblBeforeFinal.Tag = "Sum of P Adv, T Adv, EOBI, Tax, Rent"
        Me.lblBeforeFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(273, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 24)
        Me.Label5.TabIndex = 20
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(4, 36)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(147, 23)
        Me.Label26.TabIndex = 21
        Me.Label26.Tag = "Sum of P Adv, T Adv, EOBI, Tax, Rent"
        Me.Label26.Text = "Total Subtracts :"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FullMinutesWorkedLabel1
        '
        Me.FullMinutesWorkedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_OverTimeSumBindingSource, "FullMinutesWorked", True))
        Me.FullMinutesWorkedLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.FullMinutesWorkedLabel1.Location = New System.Drawing.Point(578, 445)
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
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckBox1.Location = New System.Drawing.Point(268, 82)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(299, 20)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Want to Deduct? (Cecked = Yes And UnChecked = No)"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Label43)
        Me.Panel5.Controls.Add(Me.PAdvDedRateLabel1)
        Me.Panel5.Controls.Add(Me.RFAMTLabel1)
        Me.Panel5.Controls.Add(Me.AdvSumLabel1)
        Me.Panel5.Controls.Add(Label23)
        Me.Panel5.Controls.Add(Label13)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.lblRemaining)
        Me.Panel5.Controls.Add(AmountLabel)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.CheckBox1)
        Me.Panel5.Controls.Add(DedRateLabel)
        Me.Panel5.Controls.Add(Me.AmountLabel1)
        Me.Panel5.Controls.Add(ShortTermAdvanceAmoutLabel)
        Me.Panel5.Controls.Add(Me.TotalLeavesLabel1)
        Me.Panel5.Location = New System.Drawing.Point(5, 319)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(567, 110)
        Me.Panel5.TabIndex = 29
        '
        'PAdvDedRateLabel1
        '
        Me.PAdvDedRateLabel1.BackColor = System.Drawing.Color.White
        Me.PAdvDedRateLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PAdvDedRateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "PAdvDedRate", True))
        Me.PAdvDedRateLabel1.Location = New System.Drawing.Point(366, 33)
        Me.PAdvDedRateLabel1.Name = "PAdvDedRateLabel1"
        Me.PAdvDedRateLabel1.Size = New System.Drawing.Size(131, 20)
        Me.PAdvDedRateLabel1.TabIndex = 45
        Me.PAdvDedRateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RFAMTLabel1
        '
        Me.RFAMTLabel1.BackColor = System.Drawing.Color.White
        Me.RFAMTLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RFAMTLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_RFD_PayBindingSource, "RFAMT", True))
        Me.RFAMTLabel1.Location = New System.Drawing.Point(491, 59)
        Me.RFAMTLabel1.Name = "RFAMTLabel1"
        Me.RFAMTLabel1.Size = New System.Drawing.Size(71, 23)
        Me.RFAMTLabel1.TabIndex = 120
        Me.RFAMTLabel1.Text = "Label43"
        Me.RFAMTLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tbl_Acc_RFD_PayBindingSource
        '
        Me.Tbl_Acc_RFD_PayBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_RFD_Pay"
        Me.Tbl_Acc_RFD_PayBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'AdvSumLabel1
        '
        Me.AdvSumLabel1.BackColor = System.Drawing.Color.White
        Me.AdvSumLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdvSumLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_PermanentAdvances1BindingSource, "AdvSum", True))
        Me.AdvSumLabel1.Location = New System.Drawing.Point(111, 34)
        Me.AdvSumLabel1.Name = "AdvSumLabel1"
        Me.AdvSumLabel1.Size = New System.Drawing.Size(131, 20)
        Me.AdvSumLabel1.TabIndex = 44
        Me.AdvSumLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'lblRemaining
        '
        Me.lblRemaining.BackColor = System.Drawing.SystemColors.Window
        Me.lblRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemaining.Location = New System.Drawing.Point(111, 59)
        Me.lblRemaining.Name = "lblRemaining"
        Me.lblRemaining.Size = New System.Drawing.Size(131, 20)
        Me.lblRemaining.TabIndex = 40
        Me.lblRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(565, 25)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Employee Advances Record"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalLeavesLabel1
        '
        Me.TotalLeavesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_PayRoll_LongLeaves6BindingSource, "TotalLeaves", True))
        Me.TotalLeavesLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.TotalLeavesLabel1.Location = New System.Drawing.Point(285, 79)
        Me.TotalLeavesLabel1.Name = "TotalLeavesLabel1"
        Me.TotalLeavesLabel1.Size = New System.Drawing.Size(49, 19)
        Me.TotalLeavesLabel1.TabIndex = 56
        '
        'Tbl_PayRoll_LongLeaves6BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves6BindingSource.DataMember = "tbl_PayRoll_LongLeaves6"
        Me.Tbl_PayRoll_LongLeaves6BindingSource.DataSource = Me.DSCalculateSalary
        '
        'Tbl_Acc_PAdvDeductions1BindingSource
        '
        Me.Tbl_Acc_PAdvDeductions1BindingSource.DataMember = "tbl_Acc_PAdvDeductions1"
        Me.Tbl_Acc_PAdvDeductions1BindingSource.DataSource = Me.DSLongTermAdv
        '
        'DayDeductionLabel1
        '
        Me.DayDeductionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Emp_Deduction_DaysBindingSource, "DayDeduction", True))
        Me.DayDeductionLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.DayDeductionLabel1.Location = New System.Drawing.Point(578, 456)
        Me.DayDeductionLabel1.Name = "DayDeductionLabel1"
        Me.DayDeductionLabel1.Size = New System.Drawing.Size(45, 13)
        Me.DayDeductionLabel1.TabIndex = 74
        Me.DayDeductionLabel1.Text = "Label3"
        '
        'View_Emp_Deduction_DaysBindingSource
        '
        Me.View_Emp_Deduction_DaysBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Emp_Deduction_Days"
        Me.View_Emp_Deduction_DaysBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblExtraDays)
        Me.Panel4.Controls.Add(ExtraDayCountLabel)
        Me.Panel4.Controls.Add(Me.lblWorkingDays)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.HolidayCountLabel1)
        Me.Panel4.Controls.Add(Me.lblSundays)
        Me.Panel4.Controls.Add(Me.lblMonthDays)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(578, 435)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(421, 86)
        Me.Panel4.TabIndex = 30
        '
        'lblExtraDays
        '
        Me.lblExtraDays.BackColor = System.Drawing.SystemColors.Window
        Me.lblExtraDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblExtraDays.Location = New System.Drawing.Point(355, 31)
        Me.lblExtraDays.Name = "lblExtraDays"
        Me.lblExtraDays.Size = New System.Drawing.Size(51, 47)
        Me.lblExtraDays.TabIndex = 63
        Me.lblExtraDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWorkingDays
        '
        Me.lblWorkingDays.BackColor = System.Drawing.SystemColors.Window
        Me.lblWorkingDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWorkingDays.Location = New System.Drawing.Point(98, 55)
        Me.lblWorkingDays.Name = "lblWorkingDays"
        Me.lblWorkingDays.Size = New System.Drawing.Size(65, 20)
        Me.lblWorkingDays.TabIndex = 32
        Me.lblWorkingDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(12, 55)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 20)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Working Days:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HolidayCountLabel1
        '
        Me.HolidayCountLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.HolidayCountLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HolidayCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_HolidaysBindingSource, "HolidayCount", True))
        Me.HolidayCountLabel1.Location = New System.Drawing.Point(228, 55)
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
        Me.lblSundays.BackColor = System.Drawing.SystemColors.Window
        Me.lblSundays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSundays.Location = New System.Drawing.Point(228, 30)
        Me.lblSundays.Name = "lblSundays"
        Me.lblSundays.Size = New System.Drawing.Size(65, 20)
        Me.lblSundays.TabIndex = 29
        Me.lblSundays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonthDays
        '
        Me.lblMonthDays.BackColor = System.Drawing.SystemColors.Window
        Me.lblMonthDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthDays.Location = New System.Drawing.Point(98, 30)
        Me.lblMonthDays.Name = "lblMonthDays"
        Me.lblMonthDays.Size = New System.Drawing.Size(65, 20)
        Me.lblMonthDays.TabIndex = 28
        Me.lblMonthDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(169, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 20)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Holidays:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(169, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 20)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "Sundays:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(12, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 20)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Total Days:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(419, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Selected Months Information"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Tbl_Acc_Salary_TransactionsBindingSource
        '
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_Salary_Transactions"
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Tbl_Acc_Salary_TransactionsTableAdapter
        '
        Me.Tbl_Acc_Salary_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.Label22)
        Me.Panel10.Controls.Add(Me.EveningShortMinsLabel1)
        Me.Panel10.Controls.Add(Me.Label32)
        Me.Panel10.Controls.Add(Me.Label31)
        Me.Panel10.Controls.Add(Me.lblTotalShortMinutes)
        Me.Panel10.Controls.Add(Me.lblShortAmt)
        Me.Panel10.Controls.Add(Me.Label30)
        Me.Panel10.Controls.Add(Me.lblShortDeducted)
        Me.Panel10.Controls.Add(Me.txtSLeaveDeduct)
        Me.Panel10.Controls.Add(Me.CheckBox2)
        Me.Panel10.Controls.Add(Me.Label36)
        Me.Panel10.Controls.Add(Me.Label37)
        Me.Panel10.Controls.Add(Me.MorningShortMinsLabel1)
        Me.Panel10.Controls.Add(Me.Label38)
        Me.Panel10.Location = New System.Drawing.Point(578, 528)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(422, 135)
        Me.Panel10.TabIndex = 31
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(420, 25)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Short Minutes Deduction"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EveningShortMinsLabel1
        '
        Me.EveningShortMinsLabel1.BackColor = System.Drawing.Color.White
        Me.EveningShortMinsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EveningShortMinsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_EveningShortMinsBindingSource, "EveningShortMins", True))
        Me.EveningShortMinsLabel1.Location = New System.Drawing.Point(134, 54)
        Me.EveningShortMinsLabel1.Name = "EveningShortMinsLabel1"
        Me.EveningShortMinsLabel1.Size = New System.Drawing.Size(65, 20)
        Me.EveningShortMinsLabel1.TabIndex = 71
        Me.EveningShortMinsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_EveningShortMinsBindingSource
        '
        Me.View_Rpt_Acc_EveningShortMinsBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Rpt_Acc_EveningShortMins"
        Me.View_Rpt_Acc_EveningShortMinsBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(11, 79)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 20)
        Me.Label32.TabIndex = 60
        Me.Label32.Text = "Total Short Minutes:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(209, 30)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 20)
        Me.Label31.TabIndex = 61
        Me.Label31.Text = "Amount:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalShortMinutes
        '
        Me.lblTotalShortMinutes.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalShortMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalShortMinutes.Location = New System.Drawing.Point(134, 79)
        Me.lblTotalShortMinutes.Name = "lblTotalShortMinutes"
        Me.lblTotalShortMinutes.Size = New System.Drawing.Size(65, 20)
        Me.lblTotalShortMinutes.TabIndex = 62
        Me.lblTotalShortMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblShortAmt
        '
        Me.lblShortAmt.BackColor = System.Drawing.SystemColors.Window
        Me.lblShortAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShortAmt.Location = New System.Drawing.Point(278, 30)
        Me.lblShortAmt.Name = "lblShortAmt"
        Me.lblShortAmt.Size = New System.Drawing.Size(80, 20)
        Me.lblShortAmt.TabIndex = 63
        Me.lblShortAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(228, 79)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 20)
        Me.Label30.TabIndex = 64
        Me.Label30.Text = "Edit:"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShortDeducted
        '
        Me.lblShortDeducted.BackColor = System.Drawing.SystemColors.Window
        Me.lblShortDeducted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShortDeducted.ForeColor = System.Drawing.Color.Red
        Me.lblShortDeducted.Location = New System.Drawing.Point(278, 54)
        Me.lblShortDeducted.Name = "lblShortDeducted"
        Me.lblShortDeducted.Size = New System.Drawing.Size(80, 20)
        Me.lblShortDeducted.TabIndex = 73
        Me.lblShortDeducted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSLeaveDeduct
        '
        Me.txtSLeaveDeduct.BackColor = System.Drawing.Color.MistyRose
        Me.txtSLeaveDeduct.Location = New System.Drawing.Point(278, 79)
        Me.txtSLeaveDeduct.Name = "txtSLeaveDeduct"
        Me.txtSLeaveDeduct.Size = New System.Drawing.Size(80, 20)
        Me.txtSLeaveDeduct.TabIndex = 65
        Me.txtSLeaveDeduct.TabStop = False
        Me.txtSLeaveDeduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox2
        '
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(110, 109)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox2.Size = New System.Drawing.Size(299, 20)
        Me.CheckBox2.TabIndex = 66
        Me.CheckBox2.TabStop = False
        Me.CheckBox2.Text = "Want to Deduct? (Checked = Yes And UnChecked = No)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(11, 54)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(119, 20)
        Me.Label36.TabIndex = 67
        Me.Label36.Text = "Evening Short Minutes:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(205, 54)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(59, 20)
        Me.Label37.TabIndex = 72
        Me.Label37.Text = "Deducted:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MorningShortMinsLabel1
        '
        Me.MorningShortMinsLabel1.BackColor = System.Drawing.Color.White
        Me.MorningShortMinsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MorningShortMinsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_MorningShortMinsBindingSource, "MorningShortMins", True))
        Me.MorningShortMinsLabel1.Location = New System.Drawing.Point(134, 30)
        Me.MorningShortMinsLabel1.Name = "MorningShortMinsLabel1"
        Me.MorningShortMinsLabel1.Size = New System.Drawing.Size(65, 20)
        Me.MorningShortMinsLabel1.TabIndex = 70
        Me.MorningShortMinsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_MorningShortMinsBindingSource
        '
        Me.View_Rpt_Acc_MorningShortMinsBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Rpt_Acc_MorningShortMins"
        Me.View_Rpt_Acc_MorningShortMinsBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(11, 30)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(118, 20)
        Me.Label38.TabIndex = 69
        Me.Label38.Text = "Morning Short Minutes:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOverTimeHours
        '
        Me.lblOverTimeHours.BackColor = System.Drawing.SystemColors.Window
        Me.lblOverTimeHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOverTimeHours.Location = New System.Drawing.Point(104, 33)
        Me.lblOverTimeHours.Name = "lblOverTimeHours"
        Me.lblOverTimeHours.Size = New System.Drawing.Size(54, 20)
        Me.lblOverTimeHours.TabIndex = 36
        Me.lblOverTimeHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverTime
        '
        Me.lblOverTime.BackColor = System.Drawing.SystemColors.Window
        Me.lblOverTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOverTime.Location = New System.Drawing.Point(104, 56)
        Me.lblOverTime.Name = "lblOverTime"
        Me.lblOverTime.Size = New System.Drawing.Size(54, 20)
        Me.lblOverTime.TabIndex = 35
        Me.lblOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(6, 58)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 20)
        Me.Label24.TabIndex = 34
        Me.Label24.Text = "OverTime Payable:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_PayRoll_LongLeaves5TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves5TableAdapter.ClearBeforeFill = True
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.TextBox4)
        Me.Panel11.Controls.Add(Me.MaskedTextBox2)
        Me.Panel11.Controls.Add(Me.MaskedTextBox1)
        Me.Panel11.Controls.Add(Label25)
        Me.Panel11.Controls.Add(Me.Label27)
        Me.Panel11.Controls.Add(Me.Label28)
        Me.Panel11.Controls.Add(Me.Label29)
        Me.Panel11.Location = New System.Drawing.Point(578, 320)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(164, 110)
        Me.Panel11.TabIndex = 32
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.MistyRose
        Me.TextBox4.Location = New System.Drawing.Point(69, 83)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(75, 20)
        Me.TextBox4.TabIndex = 16
        Me.TextBox4.TabStop = False
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.MistyRose
        Me.MaskedTextBox2.Location = New System.Drawing.Point(69, 58)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(75, 20)
        Me.MaskedTextBox2.TabIndex = 8
        Me.MaskedTextBox2.TabStop = False
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.MistyRose
        Me.MaskedTextBox1.Location = New System.Drawing.Point(69, 33)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(75, 20)
        Me.MaskedTextBox1.TabIndex = 2
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label27.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label27.Location = New System.Drawing.Point(0, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(162, 25)
        Me.Label27.TabIndex = 6
        Me.Label27.Text = "Manual Fields"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(12, 33)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(61, 20)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Full Days: "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(12, 58)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 20)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Half Days:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_PayRoll_LongLeaves7TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves7TableAdapter.ClearBeforeFill = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(927, 176)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(113, 40)
        Me.btnRefresh.TabIndex = 54
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'View_Acc_EmpDeptsAndJoiningsTableAdapter
        '
        Me.View_Acc_EmpDeptsAndJoiningsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves6TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves6TableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(927, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 43)
        Me.Button1.TabIndex = 57
        Me.Button1.TabStop = False
        Me.Button1.Text = "Undo"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'View_Rpt_Acc_OverTimeSumTableAdapter
        '
        Me.View_Rpt_Acc_OverTimeSumTableAdapter.ClearBeforeFill = True
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
        'Tbl_Hrm_ExtraWorkingDaysBindingSource
        '
        Me.Tbl_Hrm_ExtraWorkingDaysBindingSource.DataMember = "tbl_Hrm_ExtraWorkingDays"
        Me.Tbl_Hrm_ExtraWorkingDaysBindingSource.DataSource = Me.DSCalculateSalary
        '
        'Tbl_Hrm_ExtraWorkingDaysTableAdapter
        '
        Me.Tbl_Hrm_ExtraWorkingDaysTableAdapter.ClearBeforeFill = True
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
        'PESSIStatus
        '
        Me.PESSIStatus.BackColor = System.Drawing.Color.Gainsboro
        Me.PESSIStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "PESSICont", True))
        Me.PESSIStatus.ForeColor = System.Drawing.Color.Gainsboro
        Me.PESSIStatus.Location = New System.Drawing.Point(994, 364)
        Me.PESSIStatus.Name = "PESSIStatus"
        Me.PESSIStatus.Size = New System.Drawing.Size(25, 20)
        Me.PESSIStatus.TabIndex = 63
        Me.PESSIStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Emp_Deduction_DaysTableAdapter
        '
        Me.View_Emp_Deduction_DaysTableAdapter.ClearBeforeFill = True
        '
        'View_Emp_Meal_AttendanceBindingSource
        '
        Me.View_Emp_Meal_AttendanceBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Emp_Meal_Attendance"
        Me.View_Emp_Meal_AttendanceBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'View_Emp_Meal_AttendanceTableAdapter
        '
        Me.View_Emp_Meal_AttendanceTableAdapter.ClearBeforeFill = True
        '
        'EmpCountLabel1
        '
        Me.EmpCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Emp_Meal_AttendanceBindingSource, "EmpCount", True))
        Me.EmpCountLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EmpCountLabel1.Location = New System.Drawing.Point(1006, 364)
        Me.EmpCountLabel1.Name = "EmpCountLabel1"
        Me.EmpCountLabel1.Size = New System.Drawing.Size(100, 15)
        Me.EmpCountLabel1.TabIndex = 76
        Me.EmpCountLabel1.Text = "Label3"
        '
        'LblTotalMealDeduction
        '
        Me.LblTotalMealDeduction.AutoSize = True
        Me.LblTotalMealDeduction.ForeColor = System.Drawing.Color.Gainsboro
        Me.LblTotalMealDeduction.Location = New System.Drawing.Point(1026, 478)
        Me.LblTotalMealDeduction.Name = "LblTotalMealDeduction"
        Me.LblTotalMealDeduction.Size = New System.Drawing.Size(39, 13)
        Me.LblTotalMealDeduction.TabIndex = 77
        Me.LblTotalMealDeduction.Text = "Label3"
        '
        'SenStatusLabel3
        '
        Me.SenStatusLabel3.BackColor = System.Drawing.Color.Gainsboro
        Me.SenStatusLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "SenStatus", True))
        Me.SenStatusLabel3.ForeColor = System.Drawing.Color.Gainsboro
        Me.SenStatusLabel3.Location = New System.Drawing.Point(975, 344)
        Me.SenStatusLabel3.Name = "SenStatusLabel3"
        Me.SenStatusLabel3.Size = New System.Drawing.Size(25, 20)
        Me.SenStatusLabel3.TabIndex = 64
        Me.SenStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Label41)
        Me.Panel8.Controls.Add(Me.lblOverTimeHours)
        Me.Panel8.Controls.Add(Me.Label40)
        Me.Panel8.Controls.Add(Me.lblOverTime)
        Me.Panel8.Controls.Add(Me.Label39)
        Me.Panel8.Controls.Add(Me.Label24)
        Me.Panel8.Controls.Add(TotalPayableHoursLabel)
        Me.Panel8.Location = New System.Drawing.Point(748, 321)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(173, 109)
        Me.Panel8.TabIndex = 33
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Location = New System.Drawing.Point(104, 79)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(54, 20)
        Me.Label40.TabIndex = 83
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label39.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label39.Location = New System.Drawing.Point(0, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(171, 25)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "Over Time Info."
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Comp_InfoTableAdapter = Me.Tbl_Comp_InfoTableAdapter
        Me.TableAdapterManager.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Acc_Salary_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Emp_Salary_Calculation_AdjTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_Info_Cards_InfoTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_Info_HTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSCalculateSalaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TotalDedLabel1
        '
        Me.TotalDedLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TotalDedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_PAdvDeductions1BindingSource, "TotalDed", True))
        Me.TotalDedLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.TotalDedLabel1.Location = New System.Drawing.Point(941, 395)
        Me.TotalDedLabel1.Name = "TotalDedLabel1"
        Me.TotalDedLabel1.Size = New System.Drawing.Size(78, 20)
        Me.TotalDedLabel1.TabIndex = 44
        Me.TotalDedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'IncStatusLabel
        '
        Me.IncStatusLabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.IncStatusLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "IncStatus", True))
        Me.IncStatusLabel.ForeColor = System.Drawing.Color.Gainsboro
        Me.IncStatusLabel.Location = New System.Drawing.Point(1015, 583)
        Me.IncStatusLabel.Name = "IncStatusLabel"
        Me.IncStatusLabel.Size = New System.Drawing.Size(25, 20)
        Me.IncStatusLabel.TabIndex = 111
        Me.IncStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.DSSPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SPLabel1
        '
        Me.SPLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_SP_OTBindingSource, "SP", True))
        Me.SPLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.SPLabel1.Location = New System.Drawing.Point(1006, 641)
        Me.SPLabel1.Name = "SPLabel1"
        Me.SPLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SPLabel1.TabIndex = 113
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
        Me.FairAmountLabel3.Location = New System.Drawing.Point(1005, 529)
        Me.FairAmountLabel3.Name = "FairAmountLabel3"
        Me.FairAmountLabel3.Size = New System.Drawing.Size(49, 19)
        Me.FairAmountLabel3.TabIndex = 115
        Me.FairAmountLabel3.Text = "Label40"
        '
        'DailyTA
        '
        Me.DailyTA.AutoSize = True
        Me.DailyTA.ForeColor = System.Drawing.SystemColors.Control
        Me.DailyTA.Location = New System.Drawing.Point(1071, 450)
        Me.DailyTA.Name = "DailyTA"
        Me.DailyTA.Size = New System.Drawing.Size(45, 13)
        Me.DailyTA.TabIndex = 117
        Me.DailyTA.Text = "Label40"
        '
        'PaymentModeLabel2
        '
        Me.PaymentModeLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PaymentModeLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "PaymentMode", True))
        Me.PaymentModeLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.PaymentModeLabel2.Location = New System.Drawing.Point(929, 110)
        Me.PaymentModeLabel2.Name = "PaymentModeLabel2"
        Me.PaymentModeLabel2.Size = New System.Drawing.Size(71, 20)
        Me.PaymentModeLabel2.TabIndex = 118
        '
        'Tbl_Acc_RFD_PayTableAdapter
        '
        Me.Tbl_Acc_RFD_PayTableAdapter.ClearBeforeFill = True
        '
        'View_Bonus_SalaryTableAdapter
        '
        Me.View_Bonus_SalaryTableAdapter.ClearBeforeFill = True
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
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.White
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_FairShopBindingSource, "Amount", True))
        Me.Label45.Location = New System.Drawing.Point(600, 128)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(137, 20)
        Me.Label45.TabIndex = 25
        Me.Label45.Text = "Label45"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMonthlySalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1199, 714)
        Me.Controls.Add(Me.DailyTA)
        Me.Controls.Add(Me.PaymentModeLabel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PerDTA)
        Me.Controls.Add(Me.FairAmountLabel3)
        Me.Controls.Add(Me.SPLabel1)
        Me.Controls.Add(Me.IncStatusLabel)
        Me.Controls.Add(Me.TotalDedLabel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.SenStatusLabel3)
        Me.Controls.Add(Me.LblTotalMealDeduction)
        Me.Controls.Add(EndOfProbationDateLabel)
        Me.Controls.Add(Me.EmpCountLabel1)
        Me.Controls.Add(Me.EndOfProbationDateLabel1)
        Me.Controls.Add(Me.DayDeductionLabel1)
        Me.Controls.Add(Me.PESSIStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FullMinutesWorkedLabel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.CardNoLabel1)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMonthlySalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Salary Calculation"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Tbl_Hrm_Emp_Info_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCalculateSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_EmpDeptsAndJoiningsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        CType(Me.Tbl_PayRoll_LongLeaves5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.View_Rpt_Acc_OverTimeSumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.Tbl_Acc_RFD_PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PermanentAdvances1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSLongTermAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PAdvDeductions1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Deduction_DaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.View_Rpt_Acc_EveningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_MorningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_ExtraWorkingDaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_SalaryBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Meal_AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Month_Zero_LeaveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_SP_OTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_FairShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Bonus_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalDays As System.Windows.Forms.Label
    Friend WithEvents lblHalfDays As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblAbsents As System.Windows.Forms.Label
    Friend WithEvents lblTotalDaysWorked As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayableDays As System.Windows.Forms.Label
    Friend WithEvents lblTotalMeal As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblSundays As System.Windows.Forms.Label
    Friend WithEvents lblMonthDays As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DSCalculateSalary As ERP_HRMS.DSCalculateSalary
    Friend WithEvents Tbl_Hrm_Emp_Info_HBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_HTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_Info_HTableAdapter
    Friend WithEvents CardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Hrm_Emp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_InfoTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_Emp_InfoTableAdapter
    Friend WithEvents EmpIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents EmpPicPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents FatherNameLabel2 As System.Windows.Forms.Label
    Friend WithEvents NameLabel2 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_SalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_SalaryTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_SalaryTableAdapter
    Friend WithEvents GrossSalaryLabel2 As System.Windows.Forms.Label
    Friend WithEvents TravelAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents EOBILabel2 As System.Windows.Forms.Label
    Friend WithEvents TaxDeductionLabel2 As System.Windows.Forms.Label
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
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblWorkingDays As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_Salary_TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_Salary_TransactionsTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents lblOverTime As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents M1Label1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_PayRoll_LongLeaves5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves5TableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves5TableAdapter
    Friend WithEvents M2Label1 As System.Windows.Forms.Label
    Friend WithEvents UnPaidLeavesLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblBeforeFinal As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
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
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblRemaining As System.Windows.Forms.Label
    Friend WithEvents View_Acc_EmpDeptsAndJoiningsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Acc_EmpDeptsAndJoiningsTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Acc_EmpDeptsAndJoiningsTableAdapter
    Friend WithEvents DesigNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents SubDept1Label1 As System.Windows.Forms.Label
    Friend WithEvents MainDeptLabel1 As System.Windows.Forms.Label
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
    Friend WithEvents Tbl_Acc_PermanentAdvances1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PermanentAdvances1TableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PermanentAdvances1TableAdapter
    Friend WithEvents AdvSumLabel1 As System.Windows.Forms.Label
    Friend WithEvents PAdvDedRateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_PAdvDeductionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PAdvDeductionsTableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductionsTableAdapter
    Friend WithEvents lblAdds As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
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
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtSLeaveDeduct As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents MorningShortMinsLabel1 As System.Windows.Forms.Label
    Friend WithEvents EveningShortMinsLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Rpt_Acc_MorningShortMinsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_MorningShortMinsTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_MorningShortMinsTableAdapter
    Friend WithEvents View_Rpt_Acc_EveningShortMinsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_EveningShortMinsTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_EveningShortMinsTableAdapter
    Friend WithEvents lblShortDeducted As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents PESSIStatus As System.Windows.Forms.Label
    Friend WithEvents View_Emp_Deduction_DaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Emp_Deduction_DaysTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Deduction_DaysTableAdapter
    Friend WithEvents DayDeductionLabel1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents View_Emp_Meal_AttendanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Emp_Meal_AttendanceTableAdapter As ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Meal_AttendanceTableAdapter
    Friend WithEvents EmpCountLabel1 As System.Windows.Forms.Label
    Friend WithEvents LblTotalMealDeduction As System.Windows.Forms.Label
    Friend WithEvents SenStatusLabel3 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents DSUser As DSUser
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents TableAdapterManager As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager1 As DSCalculateSalaryTableAdapters.TableAdapterManager
    Friend WithEvents AccommodationLabel2 As Label
    Friend WithEvents CanteenLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TotalDedLabel1 As Label
    Friend WithEvents View_Emp_Month_Zero_LeaveBindingSource As BindingSource
    Friend WithEvents View_Emp_Month_Zero_LeaveTableAdapter As DSCalculateSalaryTableAdapters.View_Emp_Month_Zero_LeaveTableAdapter
    Friend WithEvents IncStatusLabel As Label
    Friend WithEvents DSSP As DSSP
    Friend WithEvents View_SP_OTBindingSource As BindingSource
    Friend WithEvents View_SP_OTTableAdapter As DSSPTableAdapters.View_SP_OTTableAdapter
    Friend WithEvents TableAdapterManager2 As DSSPTableAdapters.TableAdapterManager
    Friend WithEvents SPLabel1 As Label
    Friend WithEvents View_Acc_FairShopBindingSource As BindingSource
    Friend WithEvents View_Acc_FairShopTableAdapter As DSCalculateSalaryTableAdapters.View_Acc_FairShopTableAdapter
    Friend WithEvents FairAmountLabel3 As Label
    Friend WithEvents PerDTAPayable As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents PerDTA As Label
    Friend WithEvents DailyTA As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents PaymentModeLabel2 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Tbl_Acc_RFD_PayBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_RFD_PayTableAdapter As DSCalculateSalaryTableAdapters.tbl_Acc_RFD_PayTableAdapter
    Friend WithEvents RFAMTLabel1 As Label
    Friend WithEvents View_Bonus_SalaryTableAdapter As DataSet5TableAdapters.View_Bonus_SalaryTableAdapter
    Friend WithEvents DataSet5 As DataSet5
    Friend WithEvents View_Bonus_SalaryBindingSource As BindingSource
    Friend WithEvents Label45 As Label
End Class
