<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalaryAdjustment
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
        Dim Label4 As System.Windows.Forms.Label
        Dim EmpIDLabel As System.Windows.Forms.Label
        Dim GrossSalaryLabel As System.Windows.Forms.Label
        Dim TaxDeductionLabel As System.Windows.Forms.Label
        Dim EOBILabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim TravelAllowanceLabel As System.Windows.Forms.Label
        Dim EducationAllowanceLabel As System.Windows.Forms.Label
        Dim SpecialAllowanceLabel As System.Windows.Forms.Label
        Dim MealAllowanceLabel As System.Windows.Forms.Label
        Dim TotalPayableHoursLabel As System.Windows.Forms.Label
        Dim PaymentModeLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim TotalLongTermDeductionsLabel As System.Windows.Forms.Label
        Dim TotalShortTermAdvanceLabel As System.Windows.Forms.Label
        Dim CasualLeavesLabel As System.Windows.Forms.Label
        Dim M1LeavesLabel As System.Windows.Forms.Label
        Dim M2LeavesLabel As System.Windows.Forms.Label
        Dim SpecialLeavesLabel As System.Windows.Forms.Label
        Dim PaidLeavesLabel As System.Windows.Forms.Label
        Dim UnpaidLeavesLabel As System.Windows.Forms.Label
        Dim FullDaysLabel As System.Windows.Forms.Label
        Dim HalfDaysLabel As System.Windows.Forms.Label
        Dim TotalDaysWorkedLabel As System.Windows.Forms.Label
        Dim TotalPayableDaysLabel As System.Windows.Forms.Label
        Dim OverTimeHoursLabel As System.Windows.Forms.Label
        Dim OverTimePaidLabel As System.Windows.Forms.Label
        Dim TotalAbsenteesLabel As System.Windows.Forms.Label
        Dim TotalMealAllowanceLabel As System.Windows.Forms.Label
        Dim PayableSalaryLabel As System.Windows.Forms.Label
        Dim LTAPayBackLabel As System.Windows.Forms.Label
        Dim LTARemainingLabel As System.Windows.Forms.Label
        Dim LongTermAdvAmountLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalaryAdjustment))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblFinalSalary = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_Salary_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSSalaryAdjustment = New ERP_HRMS.DSSalaryAdjustment()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PaymentModeLabel1 = New System.Windows.Forms.Label()
        Me.EmpPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.MealAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.SpecialAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.PaidLeavesLabel1 = New System.Windows.Forms.Label()
        Me.EducationAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.TravelAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.EOBILabel2 = New System.Windows.Forms.Label()
        Me.TaxDeductionLabel2 = New System.Windows.Forms.Label()
        Me.GrossSalaryLabel2 = New System.Windows.Forms.Label()
        Me.NameLabel2 = New System.Windows.Forms.Label()
        Me.SpecialLeavesLabel1 = New System.Windows.Forms.Label()
        Me.M2LeavesLabel1 = New System.Windows.Forms.Label()
        Me.EmpIDLabel1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CasualLeavesLabel1 = New System.Windows.Forms.Label()
        Me.M1LeavesLabel1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.OverTimeHoursTextBox = New System.Windows.Forms.TextBox()
        Me.HalfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.FullDaysTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalDays = New System.Windows.Forms.Label()
        Me.lblHalfDays = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_Info_HTableAdapter = New ERP_HRMS.DSSalaryAdjustmentTableAdapters.tbl_Hrm_Emp_Info_HTableAdapter()
        Me.Tbl_Hrm_Emp_InfoTableAdapter = New ERP_HRMS.DSSalaryAdjustmentTableAdapters.tbl_Hrm_Emp_InfoTableAdapter()
        Me.Tbl_Acc_Salary_TransactionsTableAdapter = New ERP_HRMS.DSSalaryAdjustmentTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblDueSal = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.OTHours = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblTotalDay = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblHalfDay = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblFullDays = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblMealPayable = New System.Windows.Forms.Label()
        Me.lblOverTimePayable = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LongTermAdvAmountLabel1 = New System.Windows.Forms.Label()
        Me.TotalPayableDaysLabel1 = New System.Windows.Forms.Label()
        Me.PayableSalaryLabel1 = New System.Windows.Forms.Label()
        Me.UnpaidLeavesLabel1 = New System.Windows.Forms.Label()
        Me.LTARemainingLabel1 = New System.Windows.Forms.Label()
        Me.LTAPayBackLabel1 = New System.Windows.Forms.Label()
        Me.FullDaysLabel1 = New System.Windows.Forms.Label()
        Me.TotalMealAllowanceLabel1 = New System.Windows.Forms.Label()
        Me.TotalAbsenteesLabel1 = New System.Windows.Forms.Label()
        Me.OverTimePaidLabel1 = New System.Windows.Forms.Label()
        Me.OverTimeHoursLabel1 = New System.Windows.Forms.Label()
        Me.TotalDaysWorkedLabel1 = New System.Windows.Forms.Label()
        Me.HalfDaysLabel1 = New System.Windows.Forms.Label()
        Me.TotalShortTermAdvanceLabel1 = New System.Windows.Forms.Label()
        Me.TotalLongTermDeductionsLabel1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_CardTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Label4 = New System.Windows.Forms.Label()
        EmpIDLabel = New System.Windows.Forms.Label()
        GrossSalaryLabel = New System.Windows.Forms.Label()
        TaxDeductionLabel = New System.Windows.Forms.Label()
        EOBILabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        TravelAllowanceLabel = New System.Windows.Forms.Label()
        EducationAllowanceLabel = New System.Windows.Forms.Label()
        SpecialAllowanceLabel = New System.Windows.Forms.Label()
        MealAllowanceLabel = New System.Windows.Forms.Label()
        TotalPayableHoursLabel = New System.Windows.Forms.Label()
        PaymentModeLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        TotalLongTermDeductionsLabel = New System.Windows.Forms.Label()
        TotalShortTermAdvanceLabel = New System.Windows.Forms.Label()
        CasualLeavesLabel = New System.Windows.Forms.Label()
        M1LeavesLabel = New System.Windows.Forms.Label()
        M2LeavesLabel = New System.Windows.Forms.Label()
        SpecialLeavesLabel = New System.Windows.Forms.Label()
        PaidLeavesLabel = New System.Windows.Forms.Label()
        UnpaidLeavesLabel = New System.Windows.Forms.Label()
        FullDaysLabel = New System.Windows.Forms.Label()
        HalfDaysLabel = New System.Windows.Forms.Label()
        TotalDaysWorkedLabel = New System.Windows.Forms.Label()
        TotalPayableDaysLabel = New System.Windows.Forms.Label()
        OverTimeHoursLabel = New System.Windows.Forms.Label()
        OverTimePaidLabel = New System.Windows.Forms.Label()
        TotalAbsenteesLabel = New System.Windows.Forms.Label()
        TotalMealAllowanceLabel = New System.Windows.Forms.Label()
        PayableSalaryLabel = New System.Windows.Forms.Label()
        LTAPayBackLabel = New System.Windows.Forms.Label()
        LTARemainingLabel = New System.Windows.Forms.Label()
        LongTermAdvAmountLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSalaryAdjustment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(40, 36)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(54, 20)
        Label4.TabIndex = 3
        Label4.Text = "Card No:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpIDLabel
        '
        EmpIDLabel.Location = New System.Drawing.Point(2, 36)
        EmpIDLabel.Name = "EmpIDLabel"
        EmpIDLabel.Size = New System.Drawing.Size(60, 20)
        EmpIDLabel.TabIndex = 24
        EmpIDLabel.Text = "Serial No."
        EmpIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GrossSalaryLabel
        '
        GrossSalaryLabel.Location = New System.Drawing.Point(2, 86)
        GrossSalaryLabel.Name = "GrossSalaryLabel"
        GrossSalaryLabel.Size = New System.Drawing.Size(94, 20)
        GrossSalaryLabel.TabIndex = 0
        GrossSalaryLabel.Text = "Gross Salary:"
        GrossSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TaxDeductionLabel
        '
        TaxDeductionLabel.Location = New System.Drawing.Point(290, 33)
        TaxDeductionLabel.Name = "TaxDeductionLabel"
        TaxDeductionLabel.Size = New System.Drawing.Size(99, 20)
        TaxDeductionLabel.TabIndex = 2
        TaxDeductionLabel.Text = "Tax Deduction:"
        TaxDeductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EOBILabel
        '
        EOBILabel.Location = New System.Drawing.Point(290, 86)
        EOBILabel.Name = "EOBILabel"
        EOBILabel.Size = New System.Drawing.Size(99, 20)
        EOBILabel.TabIndex = 4
        EOBILabel.Text = "EOBI:"
        EOBILabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel
        '
        NameLabel.Location = New System.Drawing.Point(2, 61)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 20)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TravelAllowanceLabel
        '
        TravelAllowanceLabel.Location = New System.Drawing.Point(290, 144)
        TravelAllowanceLabel.Name = "TravelAllowanceLabel"
        TravelAllowanceLabel.Size = New System.Drawing.Size(94, 20)
        TravelAllowanceLabel.TabIndex = 6
        TravelAllowanceLabel.Text = "Travel Allowance:"
        TravelAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EducationAllowanceLabel
        '
        EducationAllowanceLabel.Location = New System.Drawing.Point(2, 140)
        EducationAllowanceLabel.Name = "EducationAllowanceLabel"
        EducationAllowanceLabel.Size = New System.Drawing.Size(94, 20)
        EducationAllowanceLabel.TabIndex = 8
        EducationAllowanceLabel.Text = "Edu Allowance:"
        EducationAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpecialAllowanceLabel
        '
        SpecialAllowanceLabel.Location = New System.Drawing.Point(290, 61)
        SpecialAllowanceLabel.Name = "SpecialAllowanceLabel"
        SpecialAllowanceLabel.Size = New System.Drawing.Size(99, 20)
        SpecialAllowanceLabel.TabIndex = 10
        SpecialAllowanceLabel.Text = "Special Allowance:"
        SpecialAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MealAllowanceLabel
        '
        MealAllowanceLabel.Location = New System.Drawing.Point(2, 112)
        MealAllowanceLabel.Name = "MealAllowanceLabel"
        MealAllowanceLabel.Size = New System.Drawing.Size(94, 20)
        MealAllowanceLabel.TabIndex = 12
        MealAllowanceLabel.Text = "Meal Allowance:"
        MealAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalPayableHoursLabel
        '
        TotalPayableHoursLabel.Location = New System.Drawing.Point(321, 34)
        TotalPayableHoursLabel.Name = "TotalPayableHoursLabel"
        TotalPayableHoursLabel.Size = New System.Drawing.Size(91, 20)
        TotalPayableHoursLabel.TabIndex = 0
        TotalPayableHoursLabel.Text = "OverTime Hours:"
        TotalPayableHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PaymentModeLabel
        '
        PaymentModeLabel.BackColor = System.Drawing.Color.Transparent
        PaymentModeLabel.Location = New System.Drawing.Point(290, 112)
        PaymentModeLabel.Name = "PaymentModeLabel"
        PaymentModeLabel.Size = New System.Drawing.Size(99, 20)
        PaymentModeLabel.TabIndex = 36
        PaymentModeLabel.Text = "Payment Mode:"
        PaymentModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(494, 34)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(91, 20)
        Label6.TabIndex = 46
        Label6.Text = "Amount (If Any):"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalLongTermDeductionsLabel
        '
        TotalLongTermDeductionsLabel.BackColor = System.Drawing.Color.Transparent
        TotalLongTermDeductionsLabel.Location = New System.Drawing.Point(179, 91)
        TotalLongTermDeductionsLabel.Name = "TotalLongTermDeductionsLabel"
        TotalLongTermDeductionsLabel.Size = New System.Drawing.Size(99, 20)
        TotalLongTermDeductionsLabel.TabIndex = 24
        TotalLongTermDeductionsLabel.Text = "P Adv. Deduction:"
        TotalLongTermDeductionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalShortTermAdvanceLabel
        '
        TotalShortTermAdvanceLabel.BackColor = System.Drawing.Color.Transparent
        TotalShortTermAdvanceLabel.Location = New System.Drawing.Point(179, 39)
        TotalShortTermAdvanceLabel.Name = "TotalShortTermAdvanceLabel"
        TotalShortTermAdvanceLabel.Size = New System.Drawing.Size(99, 20)
        TotalShortTermAdvanceLabel.TabIndex = 25
        TotalShortTermAdvanceLabel.Text = "T Advance:"
        TotalShortTermAdvanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CasualLeavesLabel
        '
        CasualLeavesLabel.Location = New System.Drawing.Point(503, 33)
        CasualLeavesLabel.Name = "CasualLeavesLabel"
        CasualLeavesLabel.Size = New System.Drawing.Size(50, 20)
        CasualLeavesLabel.TabIndex = 26
        CasualLeavesLabel.Text = "Casual:"
        CasualLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M1LeavesLabel
        '
        M1LeavesLabel.Location = New System.Drawing.Point(503, 86)
        M1LeavesLabel.Name = "M1LeavesLabel"
        M1LeavesLabel.Size = New System.Drawing.Size(50, 20)
        M1LeavesLabel.TabIndex = 27
        M1LeavesLabel.Text = "M1:"
        M1LeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'M2LeavesLabel
        '
        M2LeavesLabel.Location = New System.Drawing.Point(503, 112)
        M2LeavesLabel.Name = "M2LeavesLabel"
        M2LeavesLabel.Size = New System.Drawing.Size(50, 20)
        M2LeavesLabel.TabIndex = 28
        M2LeavesLabel.Text = "M2:"
        M2LeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpecialLeavesLabel
        '
        SpecialLeavesLabel.Location = New System.Drawing.Point(503, 61)
        SpecialLeavesLabel.Name = "SpecialLeavesLabel"
        SpecialLeavesLabel.Size = New System.Drawing.Size(50, 20)
        SpecialLeavesLabel.TabIndex = 29
        SpecialLeavesLabel.Text = "Special:"
        SpecialLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PaidLeavesLabel
        '
        PaidLeavesLabel.Location = New System.Drawing.Point(503, 143)
        PaidLeavesLabel.Name = "PaidLeavesLabel"
        PaidLeavesLabel.Size = New System.Drawing.Size(50, 20)
        PaidLeavesLabel.TabIndex = 30
        PaidLeavesLabel.Text = "Paid:"
        PaidLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UnpaidLeavesLabel
        '
        UnpaidLeavesLabel.Location = New System.Drawing.Point(585, 91)
        UnpaidLeavesLabel.Name = "UnpaidLeavesLabel"
        UnpaidLeavesLabel.Size = New System.Drawing.Size(83, 20)
        UnpaidLeavesLabel.TabIndex = 31
        UnpaidLeavesLabel.Text = "Unpaid Leaves:"
        UnpaidLeavesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FullDaysLabel
        '
        FullDaysLabel.BackColor = System.Drawing.Color.Transparent
        FullDaysLabel.Location = New System.Drawing.Point(2, 39)
        FullDaysLabel.Name = "FullDaysLabel"
        FullDaysLabel.Size = New System.Drawing.Size(94, 20)
        FullDaysLabel.TabIndex = 25
        FullDaysLabel.Text = "Full Days:"
        FullDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HalfDaysLabel
        '
        HalfDaysLabel.BackColor = System.Drawing.Color.Transparent
        HalfDaysLabel.Location = New System.Drawing.Point(2, 65)
        HalfDaysLabel.Name = "HalfDaysLabel"
        HalfDaysLabel.Size = New System.Drawing.Size(94, 20)
        HalfDaysLabel.TabIndex = 26
        HalfDaysLabel.Text = "Half Days:"
        HalfDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalDaysWorkedLabel
        '
        TotalDaysWorkedLabel.BackColor = System.Drawing.Color.Transparent
        TotalDaysWorkedLabel.Location = New System.Drawing.Point(2, 91)
        TotalDaysWorkedLabel.Name = "TotalDaysWorkedLabel"
        TotalDaysWorkedLabel.Size = New System.Drawing.Size(94, 20)
        TotalDaysWorkedLabel.TabIndex = 27
        TotalDaysWorkedLabel.Text = "Days Worked:"
        TotalDaysWorkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalPayableDaysLabel
        '
        TotalPayableDaysLabel.BackColor = System.Drawing.Color.Transparent
        TotalPayableDaysLabel.Location = New System.Drawing.Point(585, 39)
        TotalPayableDaysLabel.Name = "TotalPayableDaysLabel"
        TotalPayableDaysLabel.Size = New System.Drawing.Size(60, 20)
        TotalPayableDaysLabel.TabIndex = 28
        TotalPayableDaysLabel.Text = "Days Paid:"
        TotalPayableDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OverTimeHoursLabel
        '
        OverTimeHoursLabel.BackColor = System.Drawing.Color.Transparent
        OverTimeHoursLabel.Location = New System.Drawing.Point(384, 65)
        OverTimeHoursLabel.Name = "OverTimeHoursLabel"
        OverTimeHoursLabel.Size = New System.Drawing.Size(97, 20)
        OverTimeHoursLabel.TabIndex = 29
        OverTimeHoursLabel.Text = "Over Time Hours:"
        OverTimeHoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OverTimePaidLabel
        '
        OverTimePaidLabel.BackColor = System.Drawing.Color.Transparent
        OverTimePaidLabel.Location = New System.Drawing.Point(384, 91)
        OverTimePaidLabel.Name = "OverTimePaidLabel"
        OverTimePaidLabel.Size = New System.Drawing.Size(97, 20)
        OverTimePaidLabel.TabIndex = 30
        OverTimePaidLabel.Text = "Paid OverTime:"
        OverTimePaidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalAbsenteesLabel
        '
        TotalAbsenteesLabel.BackColor = System.Drawing.Color.Transparent
        TotalAbsenteesLabel.Location = New System.Drawing.Point(2, 118)
        TotalAbsenteesLabel.Name = "TotalAbsenteesLabel"
        TotalAbsenteesLabel.Size = New System.Drawing.Size(94, 20)
        TotalAbsenteesLabel.TabIndex = 31
        TotalAbsenteesLabel.Text = "Absentees:"
        TotalAbsenteesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalMealAllowanceLabel
        '
        TotalMealAllowanceLabel.BackColor = System.Drawing.Color.Transparent
        TotalMealAllowanceLabel.Location = New System.Drawing.Point(384, 118)
        TotalMealAllowanceLabel.Name = "TotalMealAllowanceLabel"
        TotalMealAllowanceLabel.Size = New System.Drawing.Size(97, 20)
        TotalMealAllowanceLabel.TabIndex = 32
        TotalMealAllowanceLabel.Text = "Paid Meal:"
        TotalMealAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PayableSalaryLabel
        '
        PayableSalaryLabel.BackColor = System.Drawing.Color.Transparent
        PayableSalaryLabel.Location = New System.Drawing.Point(585, 65)
        PayableSalaryLabel.Name = "PayableSalaryLabel"
        PayableSalaryLabel.Size = New System.Drawing.Size(99, 20)
        PayableSalaryLabel.TabIndex = 33
        PayableSalaryLabel.Text = "Salary Paid:"
        PayableSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LTAPayBackLabel
        '
        LTAPayBackLabel.BackColor = System.Drawing.Color.Transparent
        LTAPayBackLabel.Location = New System.Drawing.Point(179, 118)
        LTAPayBackLabel.Name = "LTAPayBackLabel"
        LTAPayBackLabel.Size = New System.Drawing.Size(99, 20)
        LTAPayBackLabel.TabIndex = 34
        LTAPayBackLabel.Text = "P Adv. Pay Back:"
        LTAPayBackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LTARemainingLabel
        '
        LTARemainingLabel.BackColor = System.Drawing.Color.Transparent
        LTARemainingLabel.Location = New System.Drawing.Point(384, 39)
        LTARemainingLabel.Name = "LTARemainingLabel"
        LTARemainingLabel.Size = New System.Drawing.Size(97, 20)
        LTARemainingLabel.TabIndex = 35
        LTARemainingLabel.Text = "P Adv. Remaining:"
        LTARemainingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LongTermAdvAmountLabel
        '
        LongTermAdvAmountLabel.BackColor = System.Drawing.Color.Transparent
        LongTermAdvAmountLabel.Location = New System.Drawing.Point(179, 65)
        LongTermAdvAmountLabel.Name = "LongTermAdvAmountLabel"
        LongTermAdvAmountLabel.Size = New System.Drawing.Size(99, 20)
        LongTermAdvAmountLabel.TabIndex = 36
        LongTermAdvAmountLabel.Text = "P Adv. Amount:"
        LongTermAdvAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(13, 33)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(136, 20)
        Label2.TabIndex = 55
        Label2.Text = "Select Appropriate Month:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(12, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 67)
        Me.Panel1.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(155, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(273, 25)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Select Appropriate Month"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1153, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Adjustment Salary After Calculation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(542, 77)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(203, 41)
        Me.btnSave.TabIndex = 5
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save Adjustment"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Controls.Add(Me.lblFinalSalary)
        Me.Panel9.Controls.Add(Me.Label5)
        Me.Panel9.Location = New System.Drawing.Point(786, 391)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(185, 95)
        Me.Panel9.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(0, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(183, 25)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Adjusted Final Amount"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalSalary
        '
        Me.lblFinalSalary.BackColor = System.Drawing.SystemColors.Window
        Me.lblFinalSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFinalSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalSalary.ForeColor = System.Drawing.Color.Red
        Me.lblFinalSalary.Location = New System.Drawing.Point(87, 33)
        Me.lblFinalSalary.Name = "lblFinalSalary"
        Me.lblFinalSalary.Size = New System.Drawing.Size(88, 52)
        Me.lblFinalSalary.TabIndex = 2
        Me.lblFinalSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(11, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 52)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Final Amount:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Acc_Salary_TransactionsBindingSource
        '
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_Salary_Transactions"
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Tbl_Hrm_Emp_InfoBindingSource
        '
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataMember = "tbl_Hrm_Emp_Info_H_tbl_Hrm_Emp_Info"
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        '
        'Tbl_Hrm_Emp_Info_HBindingSource
        '
        Me.Tbl_Hrm_Emp_Info_HBindingSource.DataMember = "tbl_Hrm_Emp_Info_H"
        Me.Tbl_Hrm_Emp_Info_HBindingSource.DataSource = Me.DSSalaryAdjustment
        '
        'DSSalaryAdjustment
        '
        Me.DSSalaryAdjustment.DataSetName = "DSSalaryAdjustment"
        Me.DSSalaryAdjustment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.CardNoComboBox)
        Me.Panel5.Controls.Add(Me.Tbl_Hrm_Emp_Info_HBindingNavigator)
        Me.Panel5.Controls.Add(Label4)
        Me.Panel5.Location = New System.Drawing.Point(293, 54)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(243, 67)
        Me.Panel5.TabIndex = 35
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(100, 36)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CardNoComboBox.TabIndex = 40
        Me.CardNoComboBox.TabStop = False
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'Tbl_Hrm_Emp_Info_HBindingNavigator
        '
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.BindingSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem})
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Name = "Tbl_Hrm_Emp_Info_HBindingNavigator"
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Size = New System.Drawing.Size(241, 25)
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.TabIndex = 46
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem
        '
        Me.Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem.Name = "Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem"
        Me.Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem.Text = "Save Data"
        Me.Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(PaymentModeLabel)
        Me.Panel4.Controls.Add(Me.PaymentModeLabel1)
        Me.Panel4.Controls.Add(PaidLeavesLabel)
        Me.Panel4.Controls.Add(Me.EmpPicPictureBox)
        Me.Panel4.Controls.Add(Me.MealAllowanceLabel2)
        Me.Panel4.Controls.Add(Me.SpecialAllowanceLabel2)
        Me.Panel4.Controls.Add(Me.PaidLeavesLabel1)
        Me.Panel4.Controls.Add(Me.EducationAllowanceLabel2)
        Me.Panel4.Controls.Add(Me.TravelAllowanceLabel2)
        Me.Panel4.Controls.Add(Me.EOBILabel2)
        Me.Panel4.Controls.Add(SpecialLeavesLabel)
        Me.Panel4.Controls.Add(Me.TaxDeductionLabel2)
        Me.Panel4.Controls.Add(Me.GrossSalaryLabel2)
        Me.Panel4.Controls.Add(Me.NameLabel2)
        Me.Panel4.Controls.Add(EmpIDLabel)
        Me.Panel4.Controls.Add(M2LeavesLabel)
        Me.Panel4.Controls.Add(Me.SpecialLeavesLabel1)
        Me.Panel4.Controls.Add(Me.M2LeavesLabel1)
        Me.Panel4.Controls.Add(Me.EmpIDLabel1)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.CasualLeavesLabel1)
        Me.Panel4.Controls.Add(Me.M1LeavesLabel1)
        Me.Panel4.Controls.Add(GrossSalaryLabel)
        Me.Panel4.Controls.Add(TaxDeductionLabel)
        Me.Panel4.Controls.Add(M1LeavesLabel)
        Me.Panel4.Controls.Add(EOBILabel)
        Me.Panel4.Controls.Add(NameLabel)
        Me.Panel4.Controls.Add(CasualLeavesLabel)
        Me.Panel4.Controls.Add(TravelAllowanceLabel)
        Me.Panel4.Controls.Add(EducationAllowanceLabel)
        Me.Panel4.Controls.Add(SpecialAllowanceLabel)
        Me.Panel4.Controls.Add(MealAllowanceLabel)
        Me.Panel4.Location = New System.Drawing.Point(12, 128)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(769, 192)
        Me.Panel4.TabIndex = 39
        '
        'PaymentModeLabel1
        '
        Me.PaymentModeLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.PaymentModeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaymentModeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "PaymentMode", True))
        Me.PaymentModeLabel1.Location = New System.Drawing.Point(395, 116)
        Me.PaymentModeLabel1.Name = "PaymentModeLabel1"
        Me.PaymentModeLabel1.Size = New System.Drawing.Size(108, 20)
        Me.PaymentModeLabel1.TabIndex = 37
        Me.PaymentModeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpPicPictureBox
        '
        Me.EmpPicPictureBox.BackColor = System.Drawing.SystemColors.Window
        Me.EmpPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpPic", True))
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpPic", True))
        Me.EmpPicPictureBox.Location = New System.Drawing.Point(625, 35)
        Me.EmpPicPictureBox.Name = "EmpPicPictureBox"
        Me.EmpPicPictureBox.Size = New System.Drawing.Size(115, 130)
        Me.EmpPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPicPictureBox.TabIndex = 36
        Me.EmpPicPictureBox.TabStop = False
        '
        'MealAllowanceLabel2
        '
        Me.MealAllowanceLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.MealAllowanceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MealAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "MealAllowance", True))
        Me.MealAllowanceLabel2.Location = New System.Drawing.Point(102, 113)
        Me.MealAllowanceLabel2.Name = "MealAllowanceLabel2"
        Me.MealAllowanceLabel2.Size = New System.Drawing.Size(102, 20)
        Me.MealAllowanceLabel2.TabIndex = 34
        Me.MealAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpecialAllowanceLabel2
        '
        Me.SpecialAllowanceLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.SpecialAllowanceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpecialAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "SpecialAllowance", True))
        Me.SpecialAllowanceLabel2.Location = New System.Drawing.Point(395, 62)
        Me.SpecialAllowanceLabel2.Name = "SpecialAllowanceLabel2"
        Me.SpecialAllowanceLabel2.Size = New System.Drawing.Size(107, 20)
        Me.SpecialAllowanceLabel2.TabIndex = 33
        Me.SpecialAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PaidLeavesLabel1
        '
        Me.PaidLeavesLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.PaidLeavesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaidLeavesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "PaidLeaves", True))
        Me.PaidLeavesLabel1.Location = New System.Drawing.Point(559, 143)
        Me.PaidLeavesLabel1.Name = "PaidLeavesLabel1"
        Me.PaidLeavesLabel1.Size = New System.Drawing.Size(60, 20)
        Me.PaidLeavesLabel1.TabIndex = 31
        Me.PaidLeavesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EducationAllowanceLabel2
        '
        Me.EducationAllowanceLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.EducationAllowanceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EducationAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "EducationAllowance", True))
        Me.EducationAllowanceLabel2.Location = New System.Drawing.Point(102, 139)
        Me.EducationAllowanceLabel2.Name = "EducationAllowanceLabel2"
        Me.EducationAllowanceLabel2.Size = New System.Drawing.Size(102, 20)
        Me.EducationAllowanceLabel2.TabIndex = 32
        Me.EducationAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TravelAllowanceLabel2
        '
        Me.TravelAllowanceLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.TravelAllowanceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TravelAllowanceLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "TravelAllowance", True))
        Me.TravelAllowanceLabel2.Location = New System.Drawing.Point(395, 143)
        Me.TravelAllowanceLabel2.Name = "TravelAllowanceLabel2"
        Me.TravelAllowanceLabel2.Size = New System.Drawing.Size(108, 20)
        Me.TravelAllowanceLabel2.TabIndex = 31
        Me.TravelAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EOBILabel2
        '
        Me.EOBILabel2.BackColor = System.Drawing.SystemColors.Window
        Me.EOBILabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EOBILabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "EOBI", True))
        Me.EOBILabel2.Location = New System.Drawing.Point(395, 89)
        Me.EOBILabel2.Name = "EOBILabel2"
        Me.EOBILabel2.Size = New System.Drawing.Size(107, 20)
        Me.EOBILabel2.TabIndex = 30
        Me.EOBILabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaxDeductionLabel2
        '
        Me.TaxDeductionLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.TaxDeductionLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TaxDeductionLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "TaxDeductions", True))
        Me.TaxDeductionLabel2.Location = New System.Drawing.Point(395, 35)
        Me.TaxDeductionLabel2.Name = "TaxDeductionLabel2"
        Me.TaxDeductionLabel2.Size = New System.Drawing.Size(107, 20)
        Me.TaxDeductionLabel2.TabIndex = 29
        Me.TaxDeductionLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrossSalaryLabel2
        '
        Me.GrossSalaryLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.GrossSalaryLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrossSalaryLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "GrossSalary", True))
        Me.GrossSalaryLabel2.Location = New System.Drawing.Point(101, 87)
        Me.GrossSalaryLabel2.Name = "GrossSalaryLabel2"
        Me.GrossSalaryLabel2.Size = New System.Drawing.Size(102, 20)
        Me.GrossSalaryLabel2.TabIndex = 28
        Me.GrossSalaryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameLabel2
        '
        Me.NameLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.NameLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "Name", True))
        Me.NameLabel2.Location = New System.Drawing.Point(101, 61)
        Me.NameLabel2.Name = "NameLabel2"
        Me.NameLabel2.Size = New System.Drawing.Size(185, 20)
        Me.NameLabel2.TabIndex = 26
        Me.NameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpecialLeavesLabel1
        '
        Me.SpecialLeavesLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.SpecialLeavesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpecialLeavesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "SpecialLeaves", True))
        Me.SpecialLeavesLabel1.Location = New System.Drawing.Point(559, 62)
        Me.SpecialLeavesLabel1.Name = "SpecialLeavesLabel1"
        Me.SpecialLeavesLabel1.Size = New System.Drawing.Size(60, 20)
        Me.SpecialLeavesLabel1.TabIndex = 30
        Me.SpecialLeavesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'M2LeavesLabel1
        '
        Me.M2LeavesLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.M2LeavesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M2LeavesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "M2Leaves", True))
        Me.M2LeavesLabel1.Location = New System.Drawing.Point(559, 116)
        Me.M2LeavesLabel1.Name = "M2LeavesLabel1"
        Me.M2LeavesLabel1.Size = New System.Drawing.Size(60, 20)
        Me.M2LeavesLabel1.TabIndex = 29
        Me.M2LeavesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpIDLabel1
        '
        Me.EmpIDLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.EmpIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpID", True))
        Me.EmpIDLabel1.Location = New System.Drawing.Point(101, 35)
        Me.EmpIDLabel1.Name = "EmpIDLabel1"
        Me.EmpIDLabel1.Size = New System.Drawing.Size(70, 20)
        Me.EmpIDLabel1.TabIndex = 25
        Me.EmpIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label16.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(0, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(767, 25)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "Employees BioData And Salary Record"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CasualLeavesLabel1
        '
        Me.CasualLeavesLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.CasualLeavesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CasualLeavesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "CasualLeaves", True))
        Me.CasualLeavesLabel1.Location = New System.Drawing.Point(559, 35)
        Me.CasualLeavesLabel1.Name = "CasualLeavesLabel1"
        Me.CasualLeavesLabel1.Size = New System.Drawing.Size(60, 20)
        Me.CasualLeavesLabel1.TabIndex = 27
        Me.CasualLeavesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'M1LeavesLabel1
        '
        Me.M1LeavesLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.M1LeavesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.M1LeavesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "M1Leaves", True))
        Me.M1LeavesLabel1.Location = New System.Drawing.Point(559, 89)
        Me.M1LeavesLabel1.Name = "M1LeavesLabel1"
        Me.M1LeavesLabel1.Size = New System.Drawing.Size(60, 20)
        Me.M1LeavesLabel1.TabIndex = 28
        Me.M1LeavesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.CardNoLabel1)
        Me.Panel7.Controls.Add(Me.AmountTextBox)
        Me.Panel7.Controls.Add(Label6)
        Me.Panel7.Controls.Add(Me.OverTimeHoursTextBox)
        Me.Panel7.Controls.Add(Me.HalfDaysTextBox)
        Me.Panel7.Controls.Add(Me.FullDaysTextBox)
        Me.Panel7.Controls.Add(TotalPayableHoursLabel)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.lblTotalDays)
        Me.Panel7.Controls.Add(Me.lblHalfDays)
        Me.Panel7.Location = New System.Drawing.Point(12, 326)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(768, 71)
        Me.Panel7.TabIndex = 45
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_Info_HBindingSource, "CardNo", True))
        Me.CardNoLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.CardNoLabel1.Location = New System.Drawing.Point(667, 38)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(39, 15)
        Me.CardNoLabel1.TabIndex = 50
        Me.CardNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AmountTextBox
        '
        Me.AmountTextBox.BackColor = System.Drawing.Color.MistyRose
        Me.AmountTextBox.Location = New System.Drawing.Point(591, 34)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(70, 20)
        Me.AmountTextBox.TabIndex = 4
        Me.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OverTimeHoursTextBox
        '
        Me.OverTimeHoursTextBox.BackColor = System.Drawing.Color.MistyRose
        Me.OverTimeHoursTextBox.Location = New System.Drawing.Point(418, 34)
        Me.OverTimeHoursTextBox.Name = "OverTimeHoursTextBox"
        Me.OverTimeHoursTextBox.Size = New System.Drawing.Size(70, 20)
        Me.OverTimeHoursTextBox.TabIndex = 3
        Me.OverTimeHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HalfDaysTextBox
        '
        Me.HalfDaysTextBox.BackColor = System.Drawing.Color.MistyRose
        Me.HalfDaysTextBox.Location = New System.Drawing.Point(245, 34)
        Me.HalfDaysTextBox.Name = "HalfDaysTextBox"
        Me.HalfDaysTextBox.Size = New System.Drawing.Size(70, 20)
        Me.HalfDaysTextBox.TabIndex = 2
        Me.HalfDaysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FullDaysTextBox
        '
        Me.FullDaysTextBox.BackColor = System.Drawing.Color.MistyRose
        Me.FullDaysTextBox.Location = New System.Drawing.Point(102, 34)
        Me.FullDaysTextBox.Name = "FullDaysTextBox"
        Me.FullDaysTextBox.Size = New System.Drawing.Size(70, 20)
        Me.FullDaysTextBox.TabIndex = 1
        Me.FullDaysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(766, 25)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Enter Values Here"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalDays
        '
        Me.lblTotalDays.Location = New System.Drawing.Point(2, 34)
        Me.lblTotalDays.Name = "lblTotalDays"
        Me.lblTotalDays.Size = New System.Drawing.Size(60, 20)
        Me.lblTotalDays.TabIndex = 0
        Me.lblTotalDays.Text = "Full Days: "
        Me.lblTotalDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHalfDays
        '
        Me.lblHalfDays.Location = New System.Drawing.Point(179, 34)
        Me.lblHalfDays.Name = "lblHalfDays"
        Me.lblHalfDays.Size = New System.Drawing.Size(60, 20)
        Me.lblHalfDays.TabIndex = 0
        Me.lblHalfDays.Text = "Half Days:"
        Me.lblHalfDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Hrm_Emp_Info_HTableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_HTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_InfoTableAdapter
        '
        Me.Tbl_Hrm_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_Salary_TransactionsTableAdapter
        '
        Me.Tbl_Acc_Salary_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblDueSal)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.lblAmt)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.OTHours)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.lblTotalDay)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.lblHalfDay)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.lblFullDays)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.lblMealPayable)
        Me.Panel2.Controls.Add(Me.lblOverTimePayable)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(787, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(185, 257)
        Me.Panel2.TabIndex = 46
        '
        'lblDueSal
        '
        Me.lblDueSal.BackColor = System.Drawing.SystemColors.Window
        Me.lblDueSal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDueSal.ForeColor = System.Drawing.Color.Red
        Me.lblDueSal.Location = New System.Drawing.Point(99, 113)
        Me.lblDueSal.Name = "lblDueSal"
        Me.lblDueSal.Size = New System.Drawing.Size(70, 20)
        Me.lblDueSal.TabIndex = 66
        Me.lblDueSal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label21.Location = New System.Drawing.Point(14, 113)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 21)
        Me.Label21.TabIndex = 65
        Me.Label21.Text = "Due Salary:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAmt
        '
        Me.lblAmt.BackColor = System.Drawing.SystemColors.Window
        Me.lblAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmt.ForeColor = System.Drawing.Color.Red
        Me.lblAmt.Location = New System.Drawing.Point(99, 221)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(70, 20)
        Me.lblAmt.TabIndex = 64
        Me.lblAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label20.Location = New System.Drawing.Point(14, 221)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 20)
        Me.Label20.TabIndex = 63
        Me.Label20.Text = "Amt (If Any):"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OTHours
        '
        Me.OTHours.BackColor = System.Drawing.SystemColors.Window
        Me.OTHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OTHours.Location = New System.Drawing.Point(99, 139)
        Me.OTHours.Name = "OTHours"
        Me.OTHours.Size = New System.Drawing.Size(70, 20)
        Me.OTHours.TabIndex = 62
        Me.OTHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label19.Location = New System.Drawing.Point(14, 139)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 21)
        Me.Label19.TabIndex = 61
        Me.Label19.Text = "OverTime Hrs:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalDay
        '
        Me.lblTotalDay.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDay.Location = New System.Drawing.Point(99, 88)
        Me.lblTotalDay.Name = "lblTotalDay"
        Me.lblTotalDay.Size = New System.Drawing.Size(70, 20)
        Me.lblTotalDay.TabIndex = 60
        Me.lblTotalDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(14, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 21)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "Total Days:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHalfDay
        '
        Me.lblHalfDay.BackColor = System.Drawing.SystemColors.Window
        Me.lblHalfDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHalfDay.Location = New System.Drawing.Point(99, 61)
        Me.lblHalfDay.Name = "lblHalfDay"
        Me.lblHalfDay.Size = New System.Drawing.Size(70, 20)
        Me.lblHalfDay.TabIndex = 58
        Me.lblHalfDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label17.Location = New System.Drawing.Point(14, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 21)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Half Days:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFullDays
        '
        Me.lblFullDays.BackColor = System.Drawing.SystemColors.Window
        Me.lblFullDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFullDays.Location = New System.Drawing.Point(99, 35)
        Me.lblFullDays.Name = "lblFullDays"
        Me.lblFullDays.Size = New System.Drawing.Size(70, 20)
        Me.lblFullDays.TabIndex = 56
        Me.lblFullDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(14, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 21)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Full Days:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMealPayable
        '
        Me.lblMealPayable.BackColor = System.Drawing.SystemColors.Window
        Me.lblMealPayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMealPayable.ForeColor = System.Drawing.Color.Red
        Me.lblMealPayable.Location = New System.Drawing.Point(99, 194)
        Me.lblMealPayable.Name = "lblMealPayable"
        Me.lblMealPayable.Size = New System.Drawing.Size(70, 20)
        Me.lblMealPayable.TabIndex = 53
        Me.lblMealPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverTimePayable
        '
        Me.lblOverTimePayable.BackColor = System.Drawing.SystemColors.Window
        Me.lblOverTimePayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOverTimePayable.ForeColor = System.Drawing.Color.Red
        Me.lblOverTimePayable.Location = New System.Drawing.Point(99, 166)
        Me.lblOverTimePayable.Name = "lblOverTimePayable"
        Me.lblOverTimePayable.Size = New System.Drawing.Size(70, 20)
        Me.lblOverTimePayable.TabIndex = 54
        Me.lblOverTimePayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.Location = New System.Drawing.Point(14, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Meal Amt:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label24.Location = New System.Drawing.Point(14, 166)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 21)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "OverTime Amt:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 25)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Adjusted Values"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(LongTermAdvAmountLabel)
        Me.Panel3.Controls.Add(TotalPayableDaysLabel)
        Me.Panel3.Controls.Add(Me.LongTermAdvAmountLabel1)
        Me.Panel3.Controls.Add(UnpaidLeavesLabel)
        Me.Panel3.Controls.Add(Me.TotalPayableDaysLabel1)
        Me.Panel3.Controls.Add(LTARemainingLabel)
        Me.Panel3.Controls.Add(Me.PayableSalaryLabel1)
        Me.Panel3.Controls.Add(Me.UnpaidLeavesLabel1)
        Me.Panel3.Controls.Add(PayableSalaryLabel)
        Me.Panel3.Controls.Add(Me.LTARemainingLabel1)
        Me.Panel3.Controls.Add(LTAPayBackLabel)
        Me.Panel3.Controls.Add(Me.LTAPayBackLabel1)
        Me.Panel3.Controls.Add(FullDaysLabel)
        Me.Panel3.Controls.Add(Me.FullDaysLabel1)
        Me.Panel3.Controls.Add(TotalMealAllowanceLabel)
        Me.Panel3.Controls.Add(Me.TotalMealAllowanceLabel1)
        Me.Panel3.Controls.Add(TotalAbsenteesLabel)
        Me.Panel3.Controls.Add(Me.TotalAbsenteesLabel1)
        Me.Panel3.Controls.Add(OverTimePaidLabel)
        Me.Panel3.Controls.Add(Me.OverTimePaidLabel1)
        Me.Panel3.Controls.Add(OverTimeHoursLabel)
        Me.Panel3.Controls.Add(Me.OverTimeHoursLabel1)
        Me.Panel3.Controls.Add(TotalDaysWorkedLabel)
        Me.Panel3.Controls.Add(Me.TotalDaysWorkedLabel1)
        Me.Panel3.Controls.Add(HalfDaysLabel)
        Me.Panel3.Controls.Add(Me.HalfDaysLabel1)
        Me.Panel3.Controls.Add(TotalShortTermAdvanceLabel)
        Me.Panel3.Controls.Add(Me.TotalShortTermAdvanceLabel1)
        Me.Panel3.Controls.Add(TotalLongTermDeductionsLabel)
        Me.Panel3.Controls.Add(Me.TotalLongTermDeductionsLabel1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(12, 403)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(769, 150)
        Me.Panel3.TabIndex = 47
        '
        'LongTermAdvAmountLabel1
        '
        Me.LongTermAdvAmountLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.LongTermAdvAmountLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LongTermAdvAmountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "LongTermAdvAmount", True))
        Me.LongTermAdvAmountLabel1.Location = New System.Drawing.Point(288, 65)
        Me.LongTermAdvAmountLabel1.Name = "LongTermAdvAmountLabel1"
        Me.LongTermAdvAmountLabel1.Size = New System.Drawing.Size(87, 20)
        Me.LongTermAdvAmountLabel1.TabIndex = 37
        Me.LongTermAdvAmountLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalPayableDaysLabel1
        '
        Me.TotalPayableDaysLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.TotalPayableDaysLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalPayableDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "TotalPayableDays", True))
        Me.TotalPayableDaysLabel1.Location = New System.Drawing.Point(670, 39)
        Me.TotalPayableDaysLabel1.Name = "TotalPayableDaysLabel1"
        Me.TotalPayableDaysLabel1.Size = New System.Drawing.Size(87, 20)
        Me.TotalPayableDaysLabel1.TabIndex = 29
        Me.TotalPayableDaysLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PayableSalaryLabel1
        '
        Me.PayableSalaryLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.PayableSalaryLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PayableSalaryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "PayableSalary", True))
        Me.PayableSalaryLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayableSalaryLabel1.ForeColor = System.Drawing.Color.DarkRed
        Me.PayableSalaryLabel1.Location = New System.Drawing.Point(670, 65)
        Me.PayableSalaryLabel1.Name = "PayableSalaryLabel1"
        Me.PayableSalaryLabel1.Size = New System.Drawing.Size(87, 20)
        Me.PayableSalaryLabel1.TabIndex = 34
        Me.PayableSalaryLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnpaidLeavesLabel1
        '
        Me.UnpaidLeavesLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.UnpaidLeavesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UnpaidLeavesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "UnpaidLeaves", True))
        Me.UnpaidLeavesLabel1.Location = New System.Drawing.Point(670, 91)
        Me.UnpaidLeavesLabel1.Name = "UnpaidLeavesLabel1"
        Me.UnpaidLeavesLabel1.Size = New System.Drawing.Size(87, 20)
        Me.UnpaidLeavesLabel1.TabIndex = 32
        Me.UnpaidLeavesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTARemainingLabel1
        '
        Me.LTARemainingLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.LTARemainingLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LTARemainingLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "LTARemaining", True))
        Me.LTARemainingLabel1.Location = New System.Drawing.Point(487, 39)
        Me.LTARemainingLabel1.Name = "LTARemainingLabel1"
        Me.LTARemainingLabel1.Size = New System.Drawing.Size(84, 20)
        Me.LTARemainingLabel1.TabIndex = 36
        Me.LTARemainingLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTAPayBackLabel1
        '
        Me.LTAPayBackLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.LTAPayBackLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LTAPayBackLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "LTAPayBack", True))
        Me.LTAPayBackLabel1.Location = New System.Drawing.Point(288, 118)
        Me.LTAPayBackLabel1.Name = "LTAPayBackLabel1"
        Me.LTAPayBackLabel1.Size = New System.Drawing.Size(87, 20)
        Me.LTAPayBackLabel1.TabIndex = 35
        Me.LTAPayBackLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FullDaysLabel1
        '
        Me.FullDaysLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.FullDaysLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FullDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "FullDays", True))
        Me.FullDaysLabel1.Location = New System.Drawing.Point(102, 39)
        Me.FullDaysLabel1.Name = "FullDaysLabel1"
        Me.FullDaysLabel1.Size = New System.Drawing.Size(70, 20)
        Me.FullDaysLabel1.TabIndex = 26
        Me.FullDaysLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalMealAllowanceLabel1
        '
        Me.TotalMealAllowanceLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.TotalMealAllowanceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalMealAllowanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "MealAllowance", True))
        Me.TotalMealAllowanceLabel1.Location = New System.Drawing.Point(487, 118)
        Me.TotalMealAllowanceLabel1.Name = "TotalMealAllowanceLabel1"
        Me.TotalMealAllowanceLabel1.Size = New System.Drawing.Size(84, 20)
        Me.TotalMealAllowanceLabel1.TabIndex = 33
        Me.TotalMealAllowanceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalAbsenteesLabel1
        '
        Me.TotalAbsenteesLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.TotalAbsenteesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAbsenteesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "TotalAbsentees", True))
        Me.TotalAbsenteesLabel1.Location = New System.Drawing.Point(102, 118)
        Me.TotalAbsenteesLabel1.Name = "TotalAbsenteesLabel1"
        Me.TotalAbsenteesLabel1.Size = New System.Drawing.Size(70, 20)
        Me.TotalAbsenteesLabel1.TabIndex = 32
        Me.TotalAbsenteesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OverTimePaidLabel1
        '
        Me.OverTimePaidLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.OverTimePaidLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OverTimePaidLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "OverTimePaid", True))
        Me.OverTimePaidLabel1.Location = New System.Drawing.Point(487, 91)
        Me.OverTimePaidLabel1.Name = "OverTimePaidLabel1"
        Me.OverTimePaidLabel1.Size = New System.Drawing.Size(84, 20)
        Me.OverTimePaidLabel1.TabIndex = 31
        Me.OverTimePaidLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OverTimeHoursLabel1
        '
        Me.OverTimeHoursLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.OverTimeHoursLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OverTimeHoursLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "OverTimeHours", True))
        Me.OverTimeHoursLabel1.Location = New System.Drawing.Point(487, 65)
        Me.OverTimeHoursLabel1.Name = "OverTimeHoursLabel1"
        Me.OverTimeHoursLabel1.Size = New System.Drawing.Size(84, 20)
        Me.OverTimeHoursLabel1.TabIndex = 30
        Me.OverTimeHoursLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalDaysWorkedLabel1
        '
        Me.TotalDaysWorkedLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.TotalDaysWorkedLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalDaysWorkedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "TotalDaysWorked", True))
        Me.TotalDaysWorkedLabel1.Location = New System.Drawing.Point(102, 91)
        Me.TotalDaysWorkedLabel1.Name = "TotalDaysWorkedLabel1"
        Me.TotalDaysWorkedLabel1.Size = New System.Drawing.Size(70, 20)
        Me.TotalDaysWorkedLabel1.TabIndex = 28
        Me.TotalDaysWorkedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HalfDaysLabel1
        '
        Me.HalfDaysLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.HalfDaysLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HalfDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "HalfDays", True))
        Me.HalfDaysLabel1.Location = New System.Drawing.Point(102, 65)
        Me.HalfDaysLabel1.Name = "HalfDaysLabel1"
        Me.HalfDaysLabel1.Size = New System.Drawing.Size(70, 20)
        Me.HalfDaysLabel1.TabIndex = 27
        Me.HalfDaysLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalShortTermAdvanceLabel1
        '
        Me.TotalShortTermAdvanceLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.TotalShortTermAdvanceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalShortTermAdvanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "TotalShortTermAdvance", True))
        Me.TotalShortTermAdvanceLabel1.Location = New System.Drawing.Point(288, 39)
        Me.TotalShortTermAdvanceLabel1.Name = "TotalShortTermAdvanceLabel1"
        Me.TotalShortTermAdvanceLabel1.Size = New System.Drawing.Size(87, 20)
        Me.TotalShortTermAdvanceLabel1.TabIndex = 26
        Me.TotalShortTermAdvanceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalLongTermDeductionsLabel1
        '
        Me.TotalLongTermDeductionsLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.TotalLongTermDeductionsLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalLongTermDeductionsLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_TransactionsBindingSource, "TotalLongTermDeductions", True))
        Me.TotalLongTermDeductionsLabel1.Location = New System.Drawing.Point(288, 91)
        Me.TotalLongTermDeductionsLabel1.Name = "TotalLongTermDeductionsLabel1"
        Me.TotalLongTermDeductionsLabel1.Size = New System.Drawing.Size(87, 20)
        Me.TotalLongTermDeductionsLabel1.TabIndex = 25
        Me.TotalLongTermDeductionsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(767, 25)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Normal Transaction Values"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(783, 489)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(202, 80)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Note: Before Starting Adjustments, please verify that 'paid or unpaid status' hav" &
    "e been checked, if it is un-checked then you can't save adjustments."
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(774, 77)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(203, 41)
        Me.btnRefresh.TabIndex = 49
        Me.btnRefresh.TabStop = False
        Me.btnRefresh.Text = "Reset Fields"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary_NewTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_BankTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_BranchTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_CardTableAdapter = Me.Tbl_HRM_CardTableAdapter
        Me.TableAdapterManager.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DeptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmSalaryAdjustment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1153, 854)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSalaryAdjustment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salary Adjustment Form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSalaryAdjustment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.ResumeLayout(False)
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents CardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents EmpPicPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents MealAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents SpecialAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents EducationAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents TravelAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents EOBILabel2 As System.Windows.Forms.Label
    Friend WithEvents TaxDeductionLabel2 As System.Windows.Forms.Label
    Friend WithEvents GrossSalaryLabel2 As System.Windows.Forms.Label
    Friend WithEvents NameLabel2 As System.Windows.Forms.Label
    Friend WithEvents EmpIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDays As System.Windows.Forms.Label
    Friend WithEvents lblHalfDays As System.Windows.Forms.Label
    Friend WithEvents DSSalaryAdjustment As ERP_HRMS.DSSalaryAdjustment
    Friend WithEvents Tbl_Hrm_Emp_Info_HBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_HTableAdapter As ERP_HRMS.DSSalaryAdjustmentTableAdapters.tbl_Hrm_Emp_Info_HTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Info_HBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_Hrm_Emp_Info_HBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Hrm_Emp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_InfoTableAdapter As ERP_HRMS.DSSalaryAdjustmentTableAdapters.tbl_Hrm_Emp_InfoTableAdapter
    Friend WithEvents Tbl_Acc_Salary_TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_Salary_TransactionsTableAdapter As ERP_HRMS.DSSalaryAdjustmentTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter
    Friend WithEvents OverTimeHoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HalfDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FullDaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblFinalSalary As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblMealPayable As System.Windows.Forms.Label
    Friend WithEvents lblOverTimePayable As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PaymentModeLabel1 As System.Windows.Forms.Label
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TotalShortTermAdvanceLabel1 As System.Windows.Forms.Label
    Friend WithEvents TotalLongTermDeductionsLabel1 As System.Windows.Forms.Label
    Friend WithEvents CasualLeavesLabel1 As System.Windows.Forms.Label
    Friend WithEvents M1LeavesLabel1 As System.Windows.Forms.Label
    Friend WithEvents M2LeavesLabel1 As System.Windows.Forms.Label
    Friend WithEvents SpecialLeavesLabel1 As System.Windows.Forms.Label
    Friend WithEvents PaidLeavesLabel1 As System.Windows.Forms.Label
    Friend WithEvents UnpaidLeavesLabel1 As System.Windows.Forms.Label
    Friend WithEvents TotalAbsenteesLabel1 As System.Windows.Forms.Label
    Friend WithEvents OverTimePaidLabel1 As System.Windows.Forms.Label
    Friend WithEvents OverTimeHoursLabel1 As System.Windows.Forms.Label
    Friend WithEvents TotalPayableDaysLabel1 As System.Windows.Forms.Label
    Friend WithEvents TotalDaysWorkedLabel1 As System.Windows.Forms.Label
    Friend WithEvents HalfDaysLabel1 As System.Windows.Forms.Label
    Friend WithEvents FullDaysLabel1 As System.Windows.Forms.Label
    Friend WithEvents LTARemainingLabel1 As System.Windows.Forms.Label
    Friend WithEvents LTAPayBackLabel1 As System.Windows.Forms.Label
    Friend WithEvents PayableSalaryLabel1 As System.Windows.Forms.Label
    Friend WithEvents TotalMealAllowanceLabel1 As System.Windows.Forms.Label
    Friend WithEvents LongTermAdvAmountLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents HRMDBDataSet1 As ERP_HRMS.HRMDBDataset1
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents OTHours As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDay As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblHalfDay As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblFullDays As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents CardNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents lblDueSal As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSHRMTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
End Class
