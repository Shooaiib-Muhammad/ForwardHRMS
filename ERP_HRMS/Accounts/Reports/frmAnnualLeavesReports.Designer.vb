<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnnualLeavesReports
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
        Dim BranchNameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_BranchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDeptsForPayrollReport = New ERP_HRMS.DSDeptsForPayrollReport()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_DepartmentsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter()
        Me.Tbl_Hrm_SubDept1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_SubDept1TableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.All = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SecBtn = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DeptBtn = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.NameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_DesignationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_BranchesTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_BranchesTableAdapter()
        Me.Tbl_Hrm_DesignationsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NonActiveBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PAdvDed = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.CrdRange = New System.Windows.Forms.RadioButton()
        Me.ByMonth = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        BranchNameLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_Hrm_BranchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(9, 85)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(98, 17)
        BranchNameLabel.TabIndex = 33
        BranchNameLabel.Text = "Branch:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(863, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Annual Leaves Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(253, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 47)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_Hrm_BranchesBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(131, 84)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(272, 24)
        Me.BranchNameComboBox.TabIndex = 34
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_Hrm_BranchesBindingSource
        '
        Me.Tbl_Hrm_BranchesBindingSource.DataMember = "tbl_Hrm_Branches"
        Me.Tbl_Hrm_BranchesBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'DSDeptsForPayrollReport
        '
        Me.DSDeptsForPayrollReport.DataSetName = "DSDeptsForPayrollReport"
        Me.DSDeptsForPayrollReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(308, 53)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(95, 23)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(131, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(92, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(395, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Financial Period:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinancialPeriodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.Enabled = False
        Me.FinancialPeriodComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(517, 76)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(208, 24)
        Me.FinancialPeriodComboBox.TabIndex = 1
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMM,yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(131, 23)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(92, 23)
        Me.DateTimePicker2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Selected Month:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(9, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "From Card:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(238, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "To Card:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Hrm_DepartmentsBindingSource
        '
        Me.Tbl_Hrm_DepartmentsBindingSource.DataMember = "tbl_Hrm_Departments"
        Me.Tbl_Hrm_DepartmentsBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'Tbl_Hrm_DepartmentsTableAdapter
        '
        Me.Tbl_Hrm_DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_SubDept1BindingSource
        '
        Me.Tbl_Hrm_SubDept1BindingSource.DataMember = "tbl_Hrm_Departments_tbl_Hrm_SubDept1"
        Me.Tbl_Hrm_SubDept1BindingSource.DataSource = Me.Tbl_Hrm_DepartmentsBindingSource
        '
        'Tbl_Hrm_SubDept1TableAdapter
        '
        Me.Tbl_Hrm_SubDept1TableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.All)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.DesigBtn)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.SecBtn)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.DeptBtn)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.NameComboBox1)
        Me.Panel3.Controls.Add(Me.NameComboBox)
        Me.Panel3.Controls.Add(Me.DeptNameComboBox)
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(386, 268)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(416, 180)
        Me.Panel3.TabIndex = 17
        '
        'All
        '
        Me.All.AutoSize = True
        Me.All.Checked = True
        Me.All.Location = New System.Drawing.Point(12, 115)
        Me.All.Name = "All"
        Me.All.Size = New System.Drawing.Size(41, 21)
        Me.All.TabIndex = 0
        Me.All.TabStop = True
        Me.All.Text = "All"
        Me.All.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(414, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Select Appropriate Department"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.Location = New System.Drawing.Point(12, 142)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBtn.TabIndex = 28
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 86)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Designation:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SecBtn
        '
        Me.SecBtn.AutoSize = True
        Me.SecBtn.Location = New System.Drawing.Point(132, 142)
        Me.SecBtn.Name = "SecBtn"
        Me.SecBtn.Size = New System.Drawing.Size(73, 21)
        Me.SecBtn.TabIndex = 27
        Me.SecBtn.Text = "Section"
        Me.SecBtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(12, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Section:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptBtn
        '
        Me.DeptBtn.AutoSize = True
        Me.DeptBtn.Location = New System.Drawing.Point(129, 115)
        Me.DeptBtn.Name = "DeptBtn"
        Me.DeptBtn.Size = New System.Drawing.Size(104, 21)
        Me.DeptBtn.TabIndex = 26
        Me.DeptBtn.Text = "Department "
        Me.DeptBtn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(12, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Department:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameComboBox1
        '
        Me.NameComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox1.DataSource = Me.Tbl_Hrm_DesignationsBindingSource
        Me.NameComboBox1.DisplayMember = "DesigName"
        Me.NameComboBox1.Enabled = False
        Me.NameComboBox1.FormattingEnabled = True
        Me.NameComboBox1.Location = New System.Drawing.Point(128, 85)
        Me.NameComboBox1.Name = "NameComboBox1"
        Me.NameComboBox1.Size = New System.Drawing.Size(274, 24)
        Me.NameComboBox1.TabIndex = 25
        Me.NameComboBox1.ValueMember = "DesignationID"
        '
        'Tbl_Hrm_DesignationsBindingSource
        '
        Me.Tbl_Hrm_DesignationsBindingSource.DataMember = "tbl_Hrm_Designations"
        Me.Tbl_Hrm_DesignationsBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.Tbl_Hrm_SubDept1BindingSource
        Me.NameComboBox.DisplayMember = "SectionName"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(128, 58)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(274, 24)
        Me.NameComboBox.TabIndex = 24
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
        Me.DeptNameComboBox.Location = New System.Drawing.Point(128, 31)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(274, 24)
        Me.DeptNameComboBox.TabIndex = 23
        Me.DeptNameComboBox.ValueMember = "DeptID"
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
        Me.TableAdapterManager.tbl_Hrm_BranchesTableAdapter = Me.Tbl_Hrm_BranchesTableAdapter
        Me.TableAdapterManager.tbl_Hrm_DepartmentsTableAdapter = Me.Tbl_Hrm_DepartmentsTableAdapter
        Me.TableAdapterManager.tbl_Hrm_DesignationsTableAdapter = Me.Tbl_Hrm_DesignationsTableAdapter
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_H1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_H2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_SubDept1TableAdapter = Me.Tbl_Hrm_SubDept1TableAdapter
        Me.TableAdapterManager.tbl_PayRoll_ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Working_DayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NonActiveBtn)
        Me.GroupBox1.Controls.Add(Me.ActiveBtn)
        Me.GroupBox1.Controls.Add(Me.AllEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(53, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 60)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Active/Non Active Employees"
        '
        'NonActiveBtn
        '
        Me.NonActiveBtn.AutoSize = True
        Me.NonActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActiveBtn.Location = New System.Drawing.Point(105, 22)
        Me.NonActiveBtn.Name = "NonActiveBtn"
        Me.NonActiveBtn.Size = New System.Drawing.Size(98, 21)
        Me.NonActiveBtn.TabIndex = 0
        Me.NonActiveBtn.Text = "Non Active "
        Me.NonActiveBtn.UseVisualStyleBackColor = True
        '
        'ActiveBtn
        '
        Me.ActiveBtn.AutoSize = True
        Me.ActiveBtn.Checked = True
        Me.ActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.ActiveBtn.Location = New System.Drawing.Point(17, 22)
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
        Me.AllEmp.Location = New System.Drawing.Point(209, 22)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.PAdvDed)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(53, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 125)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Selection"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(13, 68)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(304, 21)
        Me.RadioButton4.TabIndex = 43
        Me.RadioButton4.Text = "List of Employees eligible for Annual Leaves"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(13, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(146, 21)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Annual Leaves List"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(13, 45)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(154, 21)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.Text = "Annual Leaves Slips"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'PAdvDed
        '
        Me.PAdvDed.AutoSize = True
        Me.PAdvDed.ForeColor = System.Drawing.Color.Black
        Me.PAdvDed.Location = New System.Drawing.Point(13, 93)
        Me.PAdvDed.Name = "PAdvDed"
        Me.PAdvDed.Size = New System.Drawing.Size(139, 21)
        Me.PAdvDed.TabIndex = 26
        Me.PAdvDed.Text = "P Adv. Deduction "
        Me.PAdvDed.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(481, 532)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(236, 17)
        Me.RadioButton10.TabIndex = 39
        Me.RadioButton10.Text = "Annual Leaves Due For the Selected Month "
        Me.RadioButton10.UseVisualStyleBackColor = True
        Me.RadioButton10.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(BranchNameLabel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(386, 125)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 136)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selection"
        '
        'HRMDBDataSet1
        '
        Me.HRMDBDataSet1.DataSetName = "HRMDBDataSet1"
        Me.HRMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CrdRange
        '
        Me.CrdRange.AutoSize = True
        Me.CrdRange.ForeColor = System.Drawing.Color.Black
        Me.CrdRange.Location = New System.Drawing.Point(17, 42)
        Me.CrdRange.Name = "CrdRange"
        Me.CrdRange.Size = New System.Drawing.Size(122, 21)
        Me.CrdRange.TabIndex = 0
        Me.CrdRange.Text = "By Card Range"
        Me.CrdRange.UseVisualStyleBackColor = True
        '
        'ByMonth
        '
        Me.ByMonth.AutoSize = True
        Me.ByMonth.Checked = True
        Me.ByMonth.ForeColor = System.Drawing.Color.Black
        Me.ByMonth.Location = New System.Drawing.Point(17, 20)
        Me.ByMonth.Name = "ByMonth"
        Me.ByMonth.Size = New System.Drawing.Size(85, 21)
        Me.ByMonth.TabIndex = 0
        Me.ByMonth.TabStop = True
        Me.ByMonth.Text = "By Month"
        Me.ByMonth.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.ByMonth)
        Me.GroupBox4.Controls.Add(Me.CrdRange)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(54, 255)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(327, 105)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Option Selection"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(17, 64)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(95, 21)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "By Branch "
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Me.Tbl_Acc_FinancialPeriodTableAdapter
        Me.TableAdapterManager1.tbl_Acc_Salary_NewTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_Salary1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_Salary2TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_BankTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_BranchTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_DeptTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_DesignationTableAdapter = Nothing
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
        'frmAnnualLeavesReports
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(863, 612)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Name = "frmAnnualLeavesReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Annual Leaves Reports"
        CType(Me.Tbl_Hrm_BranchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FinancialPeriodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DSDeptsForPayrollReport As ERP_HRMS.DSDeptsForPayrollReport
    Friend WithEvents Tbl_Hrm_DepartmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_DepartmentsTableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter
    Friend WithEvents Tbl_Hrm_SubDept1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_SubDept1TableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter
    'Friend WithEvents Tbl_Hrm_SubDept2TableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept2TableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DesigBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SecBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DeptBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents NameComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeptNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Hrm_BranchesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_BranchesTableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_BranchesTableAdapter
    Friend WithEvents BranchNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Hrm_DesignationsBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_DesignationsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter
    Friend WithEvents TableAdapterManager As DSDeptsForPayrollReportTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NonActiveBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PAdvDed As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents HRMDBDataSet1 As HRMDBDataset1
    Friend WithEvents CrdRange As RadioButton
    Friend WithEvents ByMonth As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSHRMTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents TableAdapterManager1 As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents All As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
End Class
