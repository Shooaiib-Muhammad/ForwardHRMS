<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalaryReports
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
        Dim Label2 As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_SubDept1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDeptsForPayrollReport = New ERP_HRMS.DSDeptsForPayrollReport()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_DepartmentsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter()
        Me.Tbl_Hrm_SubDept1TableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter()
        Me.SalaryRecivingBtn = New System.Windows.Forms.RadioButton()
        Me.SalarySlipBTn = New System.Windows.Forms.RadioButton()
        Me.TransferBtn = New System.Windows.Forms.RadioButton()
        Me.AllBtn = New System.Windows.Forms.RadioButton()
        Me.CashBtn = New System.Windows.Forms.RadioButton()
        Me.MonthBtn = New System.Windows.Forms.RadioButton()
        Me.MonthndCedBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.OtherBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MonthndBrnch = New System.Windows.Forms.RadioButton()
        Me.MonthndShift = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_DesignationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.BankComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_BranchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_PayRoll_ShiftsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DSSalaryTrans = New ERP_HRMS.DSSalaryTrans()
        Me.Tbl_Acc_Salary_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_Salary_TransactionsTableAdapter = New ERP_HRMS.DSSalaryTransTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter()
        Me.Tbl_Hrm_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_InfoTableAdapter = New ERP_HRMS.DSSalaryTransTableAdapters.tbl_Hrm_Emp_InfoTableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.View_Rpt_Acc_PreSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_PreSalaryTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.View_Rpt_Acc_PreSalaryTableAdapter()
        Me.View_Rpt_Acc_SalarySlipEmailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_SalarySlipEmailTableAdapter = New ERP_HRMS.DSSalaryTransTableAdapters.View_Rpt_Acc_SalarySlipEmailTableAdapter()
        Me.Tbl_Hrm_BranchesTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_BranchesTableAdapter()
        Me.Tbl_Hrm_DesignationsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager()
        Me.Tbl_Acc_FinancialPeriodTableAdapter1 = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_PayRoll_ShiftsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_PayRoll_ShiftsTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.NonActivrBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.SalarySummary = New System.Windows.Forms.RadioButton()
        Me.DeptSummPanel = New System.Windows.Forms.GroupBox()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.NrmlBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AdjBtn = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_BankTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BankTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.NonPrd = New System.Windows.Forms.RadioButton()
        Me.Allprd = New System.Windows.Forms.RadioButton()
        Me.prd = New System.Windows.Forms.RadioButton()
        Me.View_Emp_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_DataTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.View_Emp_DataTableAdapter()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Label2 = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Tbl_HRM_BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_BranchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_ShiftsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DSSalaryTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_SalarySlipEmailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.DeptSummPanel.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.View_Emp_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(10, 28)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(113, 20)
        Label2.TabIndex = 27
        Label2.Text = "Financial Period:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(11, 53)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(107, 20)
        BranchNameLabel.TabIndex = 30
        BranchNameLabel.Text = "Branch:"
        BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.Location = New System.Drawing.Point(870, 558)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(107, 20)
        ShiftNameLabel.TabIndex = 31
        ShiftNameLabel.Text = "Shift:"
        ShiftNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ShiftNameLabel.Visible = False
        '
        'Label8
        '
        Label8.ForeColor = System.Drawing.Color.Black
        Label8.Location = New System.Drawing.Point(11, 81)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(107, 20)
        Label8.TabIndex = 33
        Label8.Text = "Bank Name:"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1229, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Employees Salary Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(140, 503)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 58)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(287, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Select Month:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(386, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 23)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "From Card:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(217, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "To Card:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Hrm_SubDept1BindingSource
        '
        Me.Tbl_Hrm_SubDept1BindingSource.DataMember = "tbl_Hrm_Departments_tbl_Hrm_SubDept1"
        Me.Tbl_Hrm_SubDept1BindingSource.DataSource = Me.Tbl_Hrm_DepartmentsBindingSource
        '
        'Tbl_Hrm_DepartmentsBindingSource
        '
        Me.Tbl_Hrm_DepartmentsBindingSource.DataMember = "tbl_Hrm_Departments"
        Me.Tbl_Hrm_DepartmentsBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'DSDeptsForPayrollReport
        '
        Me.DSDeptsForPayrollReport.DataSetName = "DSDeptsForPayrollReport"
        Me.DSDeptsForPayrollReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.Tbl_Hrm_SubDept1BindingSource
        Me.NameComboBox.DisplayMember = "SectionName"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(108, 64)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(282, 24)
        Me.NameComboBox.TabIndex = 23
        Me.NameComboBox.ValueMember = "SectionID"
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_Hrm_DepartmentsBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(108, 37)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(282, 24)
        Me.DeptNameComboBox.TabIndex = 22
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(16, 145)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(101, 21)
        Me.RadioButton8.TabIndex = 27
        Me.RadioButton8.Text = "Designation"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(17, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 20)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Designation:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(120, 145)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(73, 21)
        Me.RadioButton9.TabIndex = 26
        Me.RadioButton9.Text = "Section"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(17, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 20)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Section :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RadioButton19
        '
        Me.RadioButton19.AutoSize = True
        Me.RadioButton19.Location = New System.Drawing.Point(120, 122)
        Me.RadioButton19.Name = "RadioButton19"
        Me.RadioButton19.Size = New System.Drawing.Size(100, 21)
        Me.RadioButton19.TabIndex = 25
        Me.RadioButton19.Text = "Department"
        Me.RadioButton19.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(17, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 20)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Department:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Hrm_DepartmentsTableAdapter
        '
        Me.Tbl_Hrm_DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_SubDept1TableAdapter
        '
        Me.Tbl_Hrm_SubDept1TableAdapter.ClearBeforeFill = True
        '
        'SalaryRecivingBtn
        '
        Me.SalaryRecivingBtn.AutoSize = True
        Me.SalaryRecivingBtn.ForeColor = System.Drawing.Color.Black
        Me.SalaryRecivingBtn.Location = New System.Drawing.Point(18, 44)
        Me.SalaryRecivingBtn.Name = "SalaryRecivingBtn"
        Me.SalaryRecivingBtn.Size = New System.Drawing.Size(92, 21)
        Me.SalaryRecivingBtn.TabIndex = 2
        Me.SalaryRecivingBtn.Text = "Salary List"
        Me.SalaryRecivingBtn.UseVisualStyleBackColor = True
        '
        'SalarySlipBTn
        '
        Me.SalarySlipBTn.AutoSize = True
        Me.SalarySlipBTn.Checked = True
        Me.SalarySlipBTn.ForeColor = System.Drawing.Color.Black
        Me.SalarySlipBTn.Location = New System.Drawing.Point(18, 22)
        Me.SalarySlipBTn.Name = "SalarySlipBTn"
        Me.SalarySlipBTn.Size = New System.Drawing.Size(100, 21)
        Me.SalarySlipBTn.TabIndex = 1
        Me.SalarySlipBTn.TabStop = True
        Me.SalarySlipBTn.Text = "Salary Slips"
        Me.SalarySlipBTn.UseVisualStyleBackColor = True
        '
        'TransferBtn
        '
        Me.TransferBtn.AutoSize = True
        Me.TransferBtn.ForeColor = System.Drawing.Color.Black
        Me.TransferBtn.Location = New System.Drawing.Point(19, 65)
        Me.TransferBtn.Name = "TransferBtn"
        Me.TransferBtn.Size = New System.Drawing.Size(80, 21)
        Me.TransferBtn.TabIndex = 8
        Me.TransferBtn.Text = "Transfer"
        Me.TransferBtn.UseVisualStyleBackColor = True
        '
        'AllBtn
        '
        Me.AllBtn.AutoSize = True
        Me.AllBtn.Checked = True
        Me.AllBtn.ForeColor = System.Drawing.Color.Black
        Me.AllBtn.Location = New System.Drawing.Point(19, 21)
        Me.AllBtn.Name = "AllBtn"
        Me.AllBtn.Size = New System.Drawing.Size(41, 21)
        Me.AllBtn.TabIndex = 6
        Me.AllBtn.TabStop = True
        Me.AllBtn.Text = "All"
        Me.AllBtn.UseVisualStyleBackColor = True
        '
        'CashBtn
        '
        Me.CashBtn.AutoSize = True
        Me.CashBtn.ForeColor = System.Drawing.Color.Black
        Me.CashBtn.Location = New System.Drawing.Point(19, 44)
        Me.CashBtn.Name = "CashBtn"
        Me.CashBtn.Size = New System.Drawing.Size(58, 21)
        Me.CashBtn.TabIndex = 7
        Me.CashBtn.Text = "Cash"
        Me.CashBtn.UseVisualStyleBackColor = True
        '
        'MonthBtn
        '
        Me.MonthBtn.AutoSize = True
        Me.MonthBtn.Checked = True
        Me.MonthBtn.ForeColor = System.Drawing.Color.Black
        Me.MonthBtn.Location = New System.Drawing.Point(17, 19)
        Me.MonthBtn.Name = "MonthBtn"
        Me.MonthBtn.Size = New System.Drawing.Size(41, 21)
        Me.MonthBtn.TabIndex = 9
        Me.MonthBtn.TabStop = True
        Me.MonthBtn.Text = "All"
        Me.MonthBtn.UseVisualStyleBackColor = True
        '
        'MonthndCedBtn
        '
        Me.MonthndCedBtn.AutoSize = True
        Me.MonthndCedBtn.ForeColor = System.Drawing.Color.Black
        Me.MonthndCedBtn.Location = New System.Drawing.Point(17, 40)
        Me.MonthndCedBtn.Name = "MonthndCedBtn"
        Me.MonthndCedBtn.Size = New System.Drawing.Size(122, 21)
        Me.MonthndCedBtn.TabIndex = 10
        Me.MonthndCedBtn.Text = "By Card Range"
        Me.MonthndCedBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.OtherBtn)
        Me.GroupBox1.Controls.Add(Me.SalaryRecivingBtn)
        Me.GroupBox1.Controls.Add(Me.SalarySlipBTn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(17, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 219)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Appropriate Option          "
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(18, 66)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(190, 21)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Salary List Day and Night "
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(18, 132)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(198, 21)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Bank Salary Receiving List "
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(18, 110)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(157, 21)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Bank Transfer Letter"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(135, 27)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "Check For Night Shift"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(18, 154)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(112, 21)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "E-Mail Report"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'OtherBtn
        '
        Me.OtherBtn.AutoSize = True
        Me.OtherBtn.ForeColor = System.Drawing.Color.Black
        Me.OtherBtn.Location = New System.Drawing.Point(18, 88)
        Me.OtherBtn.Name = "OtherBtn"
        Me.OtherBtn.Size = New System.Drawing.Size(129, 21)
        Me.OtherBtn.TabIndex = 3
        Me.OtherBtn.Text = "Salary Summary"
        Me.OtherBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MonthndBrnch)
        Me.GroupBox3.Controls.Add(Me.MonthBtn)
        Me.GroupBox3.Controls.Add(Me.MonthndCedBtn)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(29, 381)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 116)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Appropriate Filter"
        '
        'MonthndBrnch
        '
        Me.MonthndBrnch.AutoSize = True
        Me.MonthndBrnch.BackColor = System.Drawing.Color.Transparent
        Me.MonthndBrnch.ForeColor = System.Drawing.Color.Black
        Me.MonthndBrnch.Location = New System.Drawing.Point(17, 65)
        Me.MonthndBrnch.Name = "MonthndBrnch"
        Me.MonthndBrnch.Size = New System.Drawing.Size(91, 21)
        Me.MonthndBrnch.TabIndex = 32
        Me.MonthndBrnch.Text = "By Branch"
        Me.MonthndBrnch.UseVisualStyleBackColor = False
        '
        'MonthndShift
        '
        Me.MonthndShift.AutoSize = True
        Me.MonthndShift.BackColor = System.Drawing.Color.Transparent
        Me.MonthndShift.Location = New System.Drawing.Point(803, 558)
        Me.MonthndShift.Name = "MonthndShift"
        Me.MonthndShift.Size = New System.Drawing.Size(61, 17)
        Me.MonthndShift.TabIndex = 32
        Me.MonthndShift.Text = "By Shift"
        Me.MonthndShift.UseVisualStyleBackColor = False
        Me.MonthndShift.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TransferBtn)
        Me.GroupBox4.Controls.Add(Me.AllBtn)
        Me.GroupBox4.Controls.Add(Me.CashBtn)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(295, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(239, 110)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Select Appropriate Option     "
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_Hrm_DesignationsBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(108, 90)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(282, 24)
        Me.DesigNameComboBox.TabIndex = 29
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_Hrm_DesignationsBindingSource
        '
        Me.Tbl_Hrm_DesignationsBindingSource.DataMember = "tbl_Hrm_Designations"
        Me.Tbl_Hrm_DesignationsBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.Checked = True
        Me.RadioButton16.Location = New System.Drawing.Point(17, 122)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(41, 21)
        Me.RadioButton16.TabIndex = 28
        Me.RadioButton16.TabStop = True
        Me.RadioButton16.Text = "All"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(290, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(97, 23)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(123, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 23)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Label8)
        Me.GroupBox7.Controls.Add(Me.BankComboBox)
        Me.GroupBox7.Controls.Add(Me.TextBox2)
        Me.GroupBox7.Controls.Add(Me.TextBox1)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(BranchNameLabel)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(293, 241)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(402, 115)
        Me.GroupBox7.TabIndex = 26
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Option Selection"
        '
        'BankComboBox
        '
        Me.BankComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BankComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BankComboBox.DataSource = Me.Tbl_HRM_BankBindingSource
        Me.BankComboBox.DisplayMember = "BankName"
        Me.BankComboBox.Enabled = False
        Me.BankComboBox.FormattingEnabled = True
        Me.BankComboBox.Location = New System.Drawing.Point(123, 79)
        Me.BankComboBox.Name = "BankComboBox"
        Me.BankComboBox.Size = New System.Drawing.Size(265, 24)
        Me.BankComboBox.TabIndex = 34
        Me.BankComboBox.ValueMember = "BankID"
        '
        'Tbl_HRM_BankBindingSource
        '
        Me.Tbl_HRM_BankBindingSource.DataMember = "tbl_HRM_Bank"
        Me.Tbl_HRM_BankBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_Hrm_BranchesBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(123, 51)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(265, 24)
        Me.BranchNameComboBox.TabIndex = 31
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_Hrm_BranchesBindingSource
        '
        Me.Tbl_Hrm_BranchesBindingSource.DataMember = "tbl_Hrm_Branches"
        Me.Tbl_Hrm_BranchesBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ShiftNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShiftNameComboBox.DataSource = Me.Tbl_PayRoll_ShiftsBindingSource
        Me.ShiftNameComboBox.DisplayMember = "ShiftName"
        Me.ShiftNameComboBox.Enabled = False
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(803, 531)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(265, 21)
        Me.ShiftNameComboBox.TabIndex = 32
        Me.ShiftNameComboBox.ValueMember = "ShiftID"
        Me.ShiftNameComboBox.Visible = False
        '
        'Tbl_PayRoll_ShiftsBindingSource
        '
        Me.Tbl_PayRoll_ShiftsBindingSource.DataMember = "tbl_PayRoll_Shifts"
        Me.Tbl_PayRoll_ShiftsBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinancialPeriodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource1
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(126, 24)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(148, 24)
        Me.FinancialPeriodComboBox.TabIndex = 30
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource1
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource1.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource1.DataSource = Me.DSDeptsForPayrollReport
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
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 717)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1229, 25)
        Me.ToolStrip1.TabIndex = 29
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripProgressBar1.Step = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(25, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Salary Transfer Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(140, 355)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 21
        '
        'DSSalaryTrans
        '
        Me.DSSalaryTrans.DataSetName = "DSSalaryTrans"
        Me.DSSalaryTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Acc_Salary_TransactionsBindingSource
        '
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataMember = "tbl_Acc_Salary_Transactions"
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataSource = Me.DSSalaryTrans
        '
        'Tbl_Acc_Salary_TransactionsTableAdapter
        '
        Me.Tbl_Acc_Salary_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_InfoBindingSource
        '
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataMember = "tbl_Hrm_Emp_Info"
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataSource = Me.DSSalaryTrans
        '
        'Tbl_Hrm_Emp_InfoTableAdapter
        '
        Me.Tbl_Hrm_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_PreSalaryBindingSource
        '
        Me.View_Rpt_Acc_PreSalaryBindingSource.DataMember = "View_Rpt_Acc_PreSalary"
        Me.View_Rpt_Acc_PreSalaryBindingSource.DataSource = Me.HRMDBDataSet1
        '
        'View_Rpt_Acc_PreSalaryTableAdapter
        '
        Me.View_Rpt_Acc_PreSalaryTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_SalarySlipEmailBindingSource
        '
        Me.View_Rpt_Acc_SalarySlipEmailBindingSource.DataMember = "View_Rpt_Acc_SalarySlipEmail"
        Me.View_Rpt_Acc_SalarySlipEmailBindingSource.DataSource = Me.DSSalaryTrans
        '
        'View_Rpt_Acc_SalarySlipEmailTableAdapter
        '
        Me.View_Rpt_Acc_SalarySlipEmailTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_BranchesTableAdapter
        '
        Me.Tbl_Hrm_BranchesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_DesignationsTableAdapter
        '
        Me.Tbl_Hrm_DesignationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_BonusNoSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_BranchesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_DepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_DesignationsTableAdapter = Me.Tbl_Hrm_DesignationsTableAdapter
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_H1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_H2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_SubDept1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_PayRoll_ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Working_DayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Acc_FinancialPeriodTableAdapter1
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_PayRoll_ShiftsTableAdapter
        '
        Me.Tbl_PayRoll_ShiftsTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DesigNameComboBox)
        Me.Panel1.Controls.Add(Me.DeptNameComboBox)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.RadioButton16)
        Me.Panel1.Controls.Add(Me.RadioButton8)
        Me.Panel1.Controls.Add(Me.RadioButton9)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.NameComboBox)
        Me.Panel1.Controls.Add(Me.RadioButton19)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(293, 369)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 194)
        Me.Panel1.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(404, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Select Department"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.NonActivrBtn)
        Me.GroupBox5.Controls.Add(Me.ActiveBtn)
        Me.GroupBox5.Controls.Add(Me.AllEmp)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(17, 51)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(269, 66)
        Me.GroupBox5.TabIndex = 32
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Active/Non Active Employees"
        '
        'NonActivrBtn
        '
        Me.NonActivrBtn.AutoSize = True
        Me.NonActivrBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActivrBtn.Location = New System.Drawing.Point(81, 27)
        Me.NonActivrBtn.Name = "NonActivrBtn"
        Me.NonActivrBtn.Size = New System.Drawing.Size(98, 21)
        Me.NonActivrBtn.TabIndex = 0
        Me.NonActivrBtn.Text = "Non Active "
        Me.NonActivrBtn.UseVisualStyleBackColor = True
        '
        'ActiveBtn
        '
        Me.ActiveBtn.AutoSize = True
        Me.ActiveBtn.Checked = True
        Me.ActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.ActiveBtn.Location = New System.Drawing.Point(16, 27)
        Me.ActiveBtn.Name = "ActiveBtn"
        Me.ActiveBtn.Size = New System.Drawing.Size(64, 21)
        Me.ActiveBtn.TabIndex = 0
        Me.ActiveBtn.TabStop = True
        Me.ActiveBtn.Text = "Active"
        Me.ActiveBtn.UseVisualStyleBackColor = True
        '
        'AllEmp
        '
        Me.AllEmp.AutoSize = True
        Me.AllEmp.ForeColor = System.Drawing.Color.Black
        Me.AllEmp.Location = New System.Drawing.Point(182, 27)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.FinancialPeriodComboBox)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Label2)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(295, 52)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(513, 65)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Select Financial Period And Month "
        '
        'SalarySummary
        '
        Me.SalarySummary.AutoSize = True
        Me.SalarySummary.Checked = True
        Me.SalarySummary.Location = New System.Drawing.Point(27, 25)
        Me.SalarySummary.Name = "SalarySummary"
        Me.SalarySummary.Size = New System.Drawing.Size(121, 21)
        Me.SalarySummary.TabIndex = 18
        Me.SalarySummary.TabStop = True
        Me.SalarySummary.Text = "Salary Summry"
        Me.SalarySummary.UseVisualStyleBackColor = True
        '
        'DeptSummPanel
        '
        Me.DeptSummPanel.Controls.Add(Me.SalarySummary)
        Me.DeptSummPanel.Enabled = False
        Me.DeptSummPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptSummPanel.Location = New System.Drawing.Point(784, 433)
        Me.DeptSummPanel.Name = "DeptSummPanel"
        Me.DeptSummPanel.Size = New System.Drawing.Size(278, 61)
        Me.DeptSummPanel.TabIndex = 27
        Me.DeptSummPanel.TabStop = False
        Me.DeptSummPanel.Text = "Other Salary Related Reports"
        Me.DeptSummPanel.Visible = False
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Checked = True
        Me.RadioButton18.Location = New System.Drawing.Point(16, 28)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(304, 21)
        Me.RadioButton18.TabIndex = 20
        Me.RadioButton18.TabStop = True
        Me.RadioButton18.Text = "Send Salary Slip Via Email (Salary Transfer)"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.RadioButton18)
        Me.GroupBox9.Enabled = False
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(787, 205)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(332, 117)
        Me.GroupBox9.TabIndex = 30
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Email Sending Options"
        Me.GroupBox9.Visible = False
        '
        'NrmlBtn
        '
        Me.NrmlBtn.AutoSize = True
        Me.NrmlBtn.Checked = True
        Me.NrmlBtn.Location = New System.Drawing.Point(26, 27)
        Me.NrmlBtn.Name = "NrmlBtn"
        Me.NrmlBtn.Size = New System.Drawing.Size(71, 21)
        Me.NrmlBtn.TabIndex = 4
        Me.NrmlBtn.TabStop = True
        Me.NrmlBtn.Text = "Normal"
        Me.NrmlBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NrmlBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(762, 330)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(230, 62)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Appropriate Option      "
        Me.GroupBox2.Visible = False
        '
        'AdjBtn
        '
        Me.AdjBtn.AutoSize = True
        Me.AdjBtn.Location = New System.Drawing.Point(840, 267)
        Me.AdjBtn.Name = "AdjBtn"
        Me.AdjBtn.Size = New System.Drawing.Size(77, 17)
        Me.AdjBtn.TabIndex = 5
        Me.AdjBtn.Text = "Adjustment"
        Me.AdjBtn.UseVisualStyleBackColor = True
        Me.AdjBtn.Visible = False
        '
        'Tbl_HRM_BankTableAdapter
        '
        Me.Tbl_HRM_BankTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_Salary_NewTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_Salary1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_Salary2TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_disability_descptionTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_BankTableAdapter = Me.Tbl_HRM_BankTableAdapter
        Me.TableAdapterManager1.tbl_HRM_BranchTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_DeptTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_DesignationTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_Info1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.NonPrd)
        Me.GroupBox8.Controls.Add(Me.Allprd)
        Me.GroupBox8.Controls.Add(Me.prd)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox8.Location = New System.Drawing.Point(540, 135)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(219, 110)
        Me.GroupBox8.TabIndex = 34
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Select Appropriate Option     "
        '
        'NonPrd
        '
        Me.NonPrd.AutoSize = True
        Me.NonPrd.ForeColor = System.Drawing.Color.Black
        Me.NonPrd.Location = New System.Drawing.Point(19, 65)
        Me.NonPrd.Name = "NonPrd"
        Me.NonPrd.Size = New System.Drawing.Size(124, 21)
        Me.NonPrd.TabIndex = 8
        Me.NonPrd.Text = "Non Production"
        Me.NonPrd.UseVisualStyleBackColor = True
        '
        'Allprd
        '
        Me.Allprd.AutoSize = True
        Me.Allprd.Checked = True
        Me.Allprd.ForeColor = System.Drawing.Color.Black
        Me.Allprd.Location = New System.Drawing.Point(19, 21)
        Me.Allprd.Name = "Allprd"
        Me.Allprd.Size = New System.Drawing.Size(41, 21)
        Me.Allprd.TabIndex = 6
        Me.Allprd.TabStop = True
        Me.Allprd.Text = "All"
        Me.Allprd.UseVisualStyleBackColor = True
        '
        'prd
        '
        Me.prd.AutoSize = True
        Me.prd.ForeColor = System.Drawing.Color.Black
        Me.prd.Location = New System.Drawing.Point(19, 44)
        Me.prd.Name = "prd"
        Me.prd.Size = New System.Drawing.Size(94, 21)
        Me.prd.TabIndex = 7
        Me.prd.Text = "Production"
        Me.prd.UseVisualStyleBackColor = True
        '
        'View_Emp_DataBindingSource
        '
        Me.View_Emp_DataBindingSource.DataMember = "View_Emp_Data"
        Me.View_Emp_DataBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'View_Emp_DataTableAdapter
        '
        Me.View_Emp_DataTableAdapter.ClearBeforeFill = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(19, 178)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(157, 21)
        Me.RadioButton5.TabIndex = 10
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "T Adv Transfer letter"
        Me.RadioButton5.UseVisualStyleBackColor = True
        Me.RadioButton5.Visible = False
        '
        'frmSalaryReports
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1229, 742)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MonthndShift)
        Me.Controls.Add(ShiftNameLabel)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.AdjBtn)
        Me.Controls.Add(Me.ShiftNameComboBox)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DeptSummPanel)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSalaryReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees Salary Reports"
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Tbl_HRM_BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_BranchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_ShiftsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DSSalaryTrans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_SalarySlipEmailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.DeptSummPanel.ResumeLayout(False)
        Me.DeptSummPanel.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.View_Emp_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents RadioButton19 As System.Windows.Forms.RadioButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DSDeptsForPayrollReport As ERP_HRMS.DSDeptsForPayrollReport
    Friend WithEvents Tbl_Hrm_DepartmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_DepartmentsTableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter
    Friend WithEvents DeptNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Hrm_SubDept1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_SubDept1TableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SalaryRecivingBtn As System.Windows.Forms.RadioButton
    Friend WithEvents SalarySlipBTn As System.Windows.Forms.RadioButton
    Friend WithEvents TransferBtn As System.Windows.Forms.RadioButton
    Friend WithEvents AllBtn As System.Windows.Forms.RadioButton
    Friend WithEvents CashBtn As System.Windows.Forms.RadioButton
    Friend WithEvents MonthBtn As System.Windows.Forms.RadioButton
    Friend WithEvents MonthndCedBtn As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents OtherBtn As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton16 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DSSalaryTrans As ERP_HRMS.DSSalaryTrans
    Friend WithEvents Tbl_Acc_Salary_TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_Salary_TransactionsTableAdapter As ERP_HRMS.DSSalaryTransTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter
    Friend WithEvents HRMDBDataSet1 As ERP_HRMS.HRMDBDataset1
    Friend WithEvents Tbl_Hrm_Emp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_InfoTableAdapter As ERP_HRMS.DSSalaryTransTableAdapters.tbl_Hrm_Emp_InfoTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents View_Rpt_Acc_PreSalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_PreSalaryTableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.View_Rpt_Acc_PreSalaryTableAdapter
    Friend WithEvents View_Rpt_Acc_SalarySlipEmailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_SalarySlipEmailTableAdapter As ERP_HRMS.DSSalaryTransTableAdapters.View_Rpt_Acc_SalarySlipEmailTableAdapter
    Friend WithEvents Tbl_Hrm_BranchesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_BranchesTableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_BranchesTableAdapter
    Friend WithEvents BranchNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MonthndShift As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_Hrm_DesignationsBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_DesignationsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter
    Friend WithEvents TableAdapterManager As DSDeptsForPayrollReportTableAdapters.TableAdapterManager
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents FinancialPeriodComboBox As ComboBox
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter1 As DSDeptsForPayrollReportTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource1 As BindingSource
    Friend WithEvents Tbl_PayRoll_ShiftsBindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_ShiftsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_PayRoll_ShiftsTableAdapter
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents MonthndBrnch As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents NonActivrBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents SalarySummary As RadioButton
    Friend WithEvents DeptSummPanel As GroupBox
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents NrmlBtn As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AdjBtn As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents BankComboBox As ComboBox
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_BankBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BankTableAdapter As DSHRMTableAdapters.tbl_HRM_BankTableAdapter
    Friend WithEvents TableAdapterManager1 As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents NonPrd As RadioButton
    Friend WithEvents Allprd As RadioButton
    Friend WithEvents prd As RadioButton
    Friend WithEvents View_Emp_DataBindingSource As BindingSource
    Friend WithEvents View_Emp_DataTableAdapter As DSDeptsForPayrollReportTableAdapters.View_Emp_DataTableAdapter
    Friend WithEvents RadioButton5 As RadioButton
End Class
