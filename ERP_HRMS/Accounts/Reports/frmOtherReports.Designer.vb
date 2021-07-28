<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOtherReports
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
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim BankNameLabel1 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NonActiveBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.All = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BankNameComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthPicker = New System.Windows.Forms.DateTimePicker()
        Me.BankNameComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.EmpAnual = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.PendingStatus = New System.Windows.Forms.RadioButton()
        Me.RadioButton17 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_BankTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BankTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AllDept = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DesigComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDeptBtn = New System.Windows.Forms.RadioButton()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SectBtn = New System.Windows.Forms.RadioButton()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_EmploymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_EmploymentTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Hrm_EmploymentTableAdapter()
        Me.EmploymentNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        BankNameLabel = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        BankNameLabel1 = New System.Windows.Forms.Label()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_HRM_BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.Tbl_Hrm_EmploymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BankNameLabel
        '
        BankNameLabel.Location = New System.Drawing.Point(434, 637)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(107, 20)
        BankNameLabel.TabIndex = 30
        BankNameLabel.Text = "Bank:"
        BankNameLabel.Visible = False
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(14, 88)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(107, 20)
        BranchNameLabel.TabIndex = 31
        BranchNameLabel.Text = "Branch:"
        '
        'BankNameLabel1
        '
        BankNameLabel1.ForeColor = System.Drawing.Color.Black
        BankNameLabel1.Location = New System.Drawing.Point(15, 118)
        BankNameLabel1.Name = "BankNameLabel1"
        BankNameLabel1.Size = New System.Drawing.Size(85, 17)
        BankNameLabel1.TabIndex = 53
        BankNameLabel1.Text = "Bank :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(931, 40)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Misc. Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(314, 55)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 23)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(127, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "From Card:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(239, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "To Card:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(343, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 47)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NonActiveBtn)
        Me.GroupBox1.Controls.Add(Me.ActiveBtn)
        Me.GroupBox1.Controls.Add(Me.All)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(20, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 60)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Active/Non Active Employees"
        '
        'NonActiveBtn
        '
        Me.NonActiveBtn.AutoSize = True
        Me.NonActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActiveBtn.Location = New System.Drawing.Point(93, 26)
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
        Me.ActiveBtn.Location = New System.Drawing.Point(18, 26)
        Me.ActiveBtn.Name = "ActiveBtn"
        Me.ActiveBtn.Size = New System.Drawing.Size(64, 21)
        Me.ActiveBtn.TabIndex = 0
        Me.ActiveBtn.TabStop = True
        Me.ActiveBtn.Text = "Active"
        Me.ActiveBtn.UseVisualStyleBackColor = True
        '
        'All
        '
        Me.All.AutoSize = True
        Me.All.ForeColor = System.Drawing.Color.Black
        Me.All.Location = New System.Drawing.Point(208, 26)
        Me.All.Name = "All"
        Me.All.Size = New System.Drawing.Size(41, 21)
        Me.All.TabIndex = 0
        Me.All.Text = "All"
        Me.All.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(BankNameLabel1)
        Me.GroupBox2.Controls.Add(Me.BankNameComboBox1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(BranchNameLabel)
        Me.GroupBox2.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.MonthPicker)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(343, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 208)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selection"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(317, 152)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(115, 23)
        Me.TextBox3.TabIndex = 56
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(130, 154)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 23)
        Me.TextBox4.TabIndex = 55
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(242, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "To Salary:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 20)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "From Salary:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BankNameComboBox1
        '
        Me.BankNameComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BankNameComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BankNameComboBox1.DataSource = Me.Tbl_HRM_BankBindingSource
        Me.BankNameComboBox1.DisplayMember = "BankName"
        Me.BankNameComboBox1.Enabled = False
        Me.BankNameComboBox1.FormattingEnabled = True
        Me.BankNameComboBox1.Location = New System.Drawing.Point(127, 115)
        Me.BankNameComboBox1.Name = "BankNameComboBox1"
        Me.BankNameComboBox1.Size = New System.Drawing.Size(302, 24)
        Me.BankNameComboBox1.TabIndex = 54
        Me.BankNameComboBox1.ValueMember = "BankID"
        '
        'Tbl_HRM_BankBindingSource
        '
        Me.Tbl_HRM_BankBindingSource.DataMember = "tbl_HRM_Bank"
        Me.Tbl_HRM_BankBindingSource.DataSource = Me.DSHRM
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(314, 26)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(115, 23)
        Me.DateTimePicker2.TabIndex = 52
        Me.DateTimePicker2.Visible = False
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(239, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "To Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Visible = False
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(127, 85)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(302, 24)
        Me.BranchNameComboBox.TabIndex = 32
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Select Month:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MonthPicker
        '
        Me.MonthPicker.CustomFormat = "MMM, yyyy"
        Me.MonthPicker.Enabled = False
        Me.MonthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MonthPicker.Location = New System.Drawing.Point(127, 26)
        Me.MonthPicker.Name = "MonthPicker"
        Me.MonthPicker.Size = New System.Drawing.Size(100, 23)
        Me.MonthPicker.TabIndex = 29
        '
        'BankNameComboBox
        '
        Me.BankNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BankNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BankNameComboBox.DataSource = Me.Tbl_HRM_BankBindingSource
        Me.BankNameComboBox.DisplayMember = "BankName"
        Me.BankNameComboBox.Enabled = False
        Me.BankNameComboBox.FormattingEnabled = True
        Me.BankNameComboBox.Location = New System.Drawing.Point(547, 636)
        Me.BankNameComboBox.Name = "BankNameComboBox"
        Me.BankNameComboBox.Size = New System.Drawing.Size(302, 21)
        Me.BankNameComboBox.TabIndex = 31
        Me.BankNameComboBox.ValueMember = "BankID"
        Me.BankNameComboBox.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton14)
        Me.GroupBox3.Controls.Add(Me.RadioButton12)
        Me.GroupBox3.Controls.Add(Me.RadioButton6)
        Me.GroupBox3.Controls.Add(Me.EmpAnual)
        Me.GroupBox3.Controls.Add(Me.RadioButton13)
        Me.GroupBox3.Controls.Add(Me.PendingStatus)
        Me.GroupBox3.Controls.Add(Me.RadioButton17)
        Me.GroupBox3.Controls.Add(Me.RadioButton18)
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton10)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton9)
        Me.GroupBox3.Controls.Add(Me.RadioButton7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(20, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 330)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Selection"
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.ForeColor = System.Drawing.Color.Black
        Me.RadioButton14.Location = New System.Drawing.Point(25, 272)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(162, 21)
        Me.RadioButton14.TabIndex = 45
        Me.RadioButton14.TabStop = True
        Me.RadioButton14.Text = "Employee Salary List "
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.ForeColor = System.Drawing.Color.Black
        Me.RadioButton12.Location = New System.Drawing.Point(25, 251)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(118, 21)
        Me.RadioButton12.TabIndex = 44
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Employee List "
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(25, 230)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(258, 21)
        Me.RadioButton6.TabIndex = 43
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Employee List having Bank Accounts"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'EmpAnual
        '
        Me.EmpAnual.AutoSize = True
        Me.EmpAnual.ForeColor = System.Drawing.Color.Black
        Me.EmpAnual.Location = New System.Drawing.Point(25, 209)
        Me.EmpAnual.Name = "EmpAnual"
        Me.EmpAnual.Size = New System.Drawing.Size(186, 21)
        Me.EmpAnual.TabIndex = 42
        Me.EmpAnual.TabStop = True
        Me.EmpAnual.Text = "Employee Annual Record"
        Me.EmpAnual.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.ForeColor = System.Drawing.Color.Black
        Me.RadioButton13.Location = New System.Drawing.Point(25, 188)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(136, 21)
        Me.RadioButton13.TabIndex = 41
        Me.RadioButton13.Text = "Employee Profile "
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'PendingStatus
        '
        Me.PendingStatus.AutoSize = True
        Me.PendingStatus.ForeColor = System.Drawing.Color.Black
        Me.PendingStatus.Location = New System.Drawing.Point(25, 83)
        Me.PendingStatus.Name = "PendingStatus"
        Me.PendingStatus.Size = New System.Drawing.Size(232, 21)
        Me.PendingStatus.TabIndex = 40
        Me.PendingStatus.Text = "Employee Pending Salary Status"
        Me.PendingStatus.UseVisualStyleBackColor = True
        '
        'RadioButton17
        '
        Me.RadioButton17.AutoSize = True
        Me.RadioButton17.ForeColor = System.Drawing.Color.Black
        Me.RadioButton17.Location = New System.Drawing.Point(25, 167)
        Me.RadioButton17.Name = "RadioButton17"
        Me.RadioButton17.Size = New System.Drawing.Size(197, 21)
        Me.RadioButton17.TabIndex = 37
        Me.RadioButton17.Text = "Terminated Employees List"
        Me.RadioButton17.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.ForeColor = System.Drawing.Color.Black
        Me.RadioButton18.Location = New System.Drawing.Point(25, 146)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(142, 21)
        Me.RadioButton18.TabIndex = 36
        Me.RadioButton18.Text = "Termination Letter"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(25, 104)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(195, 21)
        Me.RadioButton5.TabIndex = 35
        Me.RadioButton5.Text = "Employees Salary Analysis"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Checked = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(25, 20)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(225, 21)
        Me.RadioButton10.TabIndex = 27
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Salary Calculation Transactions"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(25, 41)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(292, 21)
        Me.RadioButton2.TabIndex = 26
        Me.RadioButton2.Text = "Employees Whose Salaries not Calculated"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Black
        Me.RadioButton9.Location = New System.Drawing.Point(25, 62)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(216, 21)
        Me.RadioButton9.TabIndex = 29
        Me.RadioButton9.Text = "Employee List For Inssurance "
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(25, 125)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(111, 21)
        Me.RadioButton7.TabIndex = 32
        Me.RadioButton7.Text = "Graduaty List"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(711, 589)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton1.TabIndex = 33
        Me.RadioButton1.Text = "Bank Transfer "
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'Tbl_HRM_BankTableAdapter
        '
        Me.Tbl_HRM_BankTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary_NewTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_disability_descptionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_BankTableAdapter = Me.Tbl_HRM_BankTableAdapter
        Me.TableAdapterManager.tbl_HRM_BranchTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DeptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Info1TableAdapter = Nothing
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.AllDept)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DesigComboBox)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.NameComboBox)
        Me.Panel2.Controls.Add(Me.MainDeptBtn)
        Me.Panel2.Controls.Add(Me.DeptNameComboBox)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.SectBtn)
        Me.Panel2.Controls.Add(Me.DesigBtn)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(343, 328)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(446, 177)
        Me.Panel2.TabIndex = 31
        '
        'AllDept
        '
        Me.AllDept.AutoSize = True
        Me.AllDept.Checked = True
        Me.AllDept.Location = New System.Drawing.Point(14, 115)
        Me.AllDept.Name = "AllDept"
        Me.AllDept.Size = New System.Drawing.Size(45, 21)
        Me.AllDept.TabIndex = 29
        Me.AllDept.TabStop = True
        Me.AllDept.Text = "All "
        Me.AllDept.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(444, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Select Department"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesigComboBox
        '
        Me.DesigComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DesigComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigComboBox.DisplayMember = "DesigName"
        Me.DesigComboBox.Enabled = False
        Me.DesigComboBox.FormattingEnabled = True
        Me.DesigComboBox.Location = New System.Drawing.Point(127, 88)
        Me.DesigComboBox.Name = "DesigComboBox"
        Me.DesigComboBox.Size = New System.Drawing.Size(301, 24)
        Me.DesigComboBox.TabIndex = 25
        Me.DesigComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(14, 34)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Department:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.Tbl_HRM_SectionBindingSource
        Me.NameComboBox.DisplayMember = "SectionName"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(127, 61)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(301, 24)
        Me.NameComboBox.TabIndex = 24
        Me.NameComboBox.ValueMember = "SectionID"
        '
        'Tbl_HRM_SectionBindingSource
        '
        Me.Tbl_HRM_SectionBindingSource.DataMember = "tbl_HRM_Dept_tbl_HRM_Section"
        Me.Tbl_HRM_SectionBindingSource.DataSource = Me.Tbl_HRM_DeptBindingSource
        '
        'Tbl_HRM_DeptBindingSource
        '
        Me.Tbl_HRM_DeptBindingSource.DataMember = "tbl_HRM_Dept"
        Me.Tbl_HRM_DeptBindingSource.DataSource = Me.DSHRM
        '
        'MainDeptBtn
        '
        Me.MainDeptBtn.AutoSize = True
        Me.MainDeptBtn.Location = New System.Drawing.Point(144, 118)
        Me.MainDeptBtn.Name = "MainDeptBtn"
        Me.MainDeptBtn.Size = New System.Drawing.Size(100, 21)
        Me.MainDeptBtn.TabIndex = 26
        Me.MainDeptBtn.Text = "Department"
        Me.MainDeptBtn.UseVisualStyleBackColor = True
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(127, 34)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(301, 24)
        Me.DeptNameComboBox.TabIndex = 23
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(14, 61)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 20)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Section:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SectBtn
        '
        Me.SectBtn.AutoSize = True
        Me.SectBtn.Location = New System.Drawing.Point(144, 141)
        Me.SectBtn.Name = "SectBtn"
        Me.SectBtn.Size = New System.Drawing.Size(73, 21)
        Me.SectBtn.TabIndex = 27
        Me.SectBtn.Text = "Section"
        Me.SectBtn.UseVisualStyleBackColor = True
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.Location = New System.Drawing.Point(14, 141)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBtn.TabIndex = 28
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(14, 88)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 20)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Designation:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton11)
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton8)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Controls.Add(Me.AllEmp)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(45, 447)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(274, 150)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Option Selection"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Enabled = False
        Me.RadioButton11.ForeColor = System.Drawing.Color.Black
        Me.RadioButton11.Location = New System.Drawing.Point(20, 118)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(78, 21)
        Me.RadioButton11.TabIndex = 2
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "By Bank"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(20, 94)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(95, 21)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "By Branch "
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(20, 70)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(122, 21)
        Me.RadioButton8.TabIndex = 0
        Me.RadioButton8.Text = "By Card Range"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(20, 46)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(85, 21)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.Text = "By Month"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'AllEmp
        '
        Me.AllEmp.AutoSize = True
        Me.AllEmp.Checked = True
        Me.AllEmp.ForeColor = System.Drawing.Color.Black
        Me.AllEmp.Location = New System.Drawing.Point(20, 22)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.TabStop = True
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_DeptTableAdapter
        '
        Me.Tbl_HRM_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(508, 76)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(208, 24)
        Me.FinancialPeriodComboBox.TabIndex = 32
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 23)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Financial Period:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Tbl_Hrm_EmploymentBindingSource
        '
        Me.Tbl_Hrm_EmploymentBindingSource.DataMember = "tbl_Hrm_Employment"
        Me.Tbl_Hrm_EmploymentBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_Hrm_EmploymentTableAdapter
        '
        Me.Tbl_Hrm_EmploymentTableAdapter.ClearBeforeFill = True
        '
        'EmploymentNameComboBox
        '
        Me.EmploymentNameComboBox.DataSource = Me.Tbl_Hrm_EmploymentBindingSource
        Me.EmploymentNameComboBox.DisplayMember = "EmploymentName"
        Me.EmploymentNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmploymentNameComboBox.FormattingEnabled = True
        Me.EmploymentNameComboBox.Location = New System.Drawing.Point(454, 79)
        Me.EmploymentNameComboBox.Name = "EmploymentNameComboBox"
        Me.EmploymentNameComboBox.Size = New System.Drawing.Size(208, 24)
        Me.EmploymentNameComboBox.TabIndex = 34
        Me.EmploymentNameComboBox.ValueMember = "EmploymentID"
        Me.EmploymentNameComboBox.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(363, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 23)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Employment:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Visible = False
        '
        'frmOtherReports
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(931, 689)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EmploymentNameComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Controls.Add(BankNameLabel)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BankNameComboBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmOtherReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MISC Reports"
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_HRM_BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.Tbl_Hrm_EmploymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NonActiveBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthPicker As DateTimePicker
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_BankBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BankTableAdapter As DSHRMTableAdapters.tbl_HRM_BankTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents BankNameComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AllDept As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents DesigComboBox As ComboBox
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents MainDeptBtn As RadioButton
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents SectBtn As RadioButton
    Friend WithEvents DesigBtn As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents All As RadioButton
    Friend WithEvents RadioButton17 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSHRMTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents Label20 As Label
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents PendingStatus As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents EmpAnual As RadioButton
    Friend WithEvents FinancialPeriodComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents Tbl_Hrm_EmploymentBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_EmploymentTableAdapter As DSHRMTableAdapters.tbl_Hrm_EmploymentTableAdapter
    Friend WithEvents EmploymentNameComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents BankNameComboBox1 As ComboBox
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
