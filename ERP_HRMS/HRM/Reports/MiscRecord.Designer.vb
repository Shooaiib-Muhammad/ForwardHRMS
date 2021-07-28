<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MiscRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim SectionNameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim FinancialPeriodLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.SalaryRecivingBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.SalarySlipBTn = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.PSSCNO = New System.Windows.Forms.RadioButton()
        Me.ASSCNO = New System.Windows.Forms.RadioButton()
        Me.pendEOBICrd = New System.Windows.Forms.RadioButton()
        Me.RejoiningBtn = New System.Windows.Forms.RadioButton()
        Me.InAcvtivePESSi = New System.Windows.Forms.RadioButton()
        Me.EOBIEmp = New System.Windows.Forms.RadioButton()
        Me.PESSIlistBtn = New System.Windows.Forms.RadioButton()
        Me.UnionBtn = New System.Windows.Forms.RadioButton()
        Me.EOBiEmpBtn = New System.Windows.Forms.RadioButton()
        Me.PESSIEmpBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.UFBtn = New System.Windows.Forms.RadioButton()
        Me.btnRptShow = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SecBTn = New System.Windows.Forms.RadioButton()
        Me.DepartmentBtn = New System.Windows.Forms.RadioButton()
        Me.AllBtn = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDBDataset1 = New ERP_HRMS.HRMDBDataset1()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bymonth = New System.Windows.Forms.DateTimePicker()
        Me.Tbl_Hrm_EmploymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.NonActiveBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.Tbl_Hrm_EmploymentTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Hrm_EmploymentTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.TableAdapterManager3 = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.HRMDBDataset1TableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton20 = New System.Windows.Forms.RadioButton()
        DeptNameLabel = New System.Windows.Forms.Label()
        SectionNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        FinancialPeriodLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_EmploymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeptNameLabel
        '
        DeptNameLabel.AutoSize = True
        DeptNameLabel.ForeColor = System.Drawing.Color.Black
        DeptNameLabel.Location = New System.Drawing.Point(6, 43)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(86, 17)
        DeptNameLabel.TabIndex = 0
        DeptNameLabel.Text = "Department:"
        '
        'SectionNameLabel
        '
        SectionNameLabel.AutoSize = True
        SectionNameLabel.ForeColor = System.Drawing.Color.Black
        SectionNameLabel.Location = New System.Drawing.Point(6, 73)
        SectionNameLabel.Name = "SectionNameLabel"
        SectionNameLabel.Size = New System.Drawing.Size(59, 17)
        SectionNameLabel.TabIndex = 2
        SectionNameLabel.Text = "Section:"
        '
        'DesigNameLabel
        '
        DesigNameLabel.AutoSize = True
        DesigNameLabel.ForeColor = System.Drawing.Color.Black
        DesigNameLabel.Location = New System.Drawing.Point(6, 103)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(87, 17)
        DesigNameLabel.TabIndex = 4
        DesigNameLabel.Text = "Designation:"
        '
        'BranchNameLabel
        '
        BranchNameLabel.AutoSize = True
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(4, 122)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(57, 17)
        BranchNameLabel.TabIndex = 59
        BranchNameLabel.Text = "Branch:"
        '
        'FinancialPeriodLabel
        '
        FinancialPeriodLabel.AutoSize = True
        FinancialPeriodLabel.ForeColor = System.Drawing.Color.Black
        FinancialPeriodLabel.Location = New System.Drawing.Point(6, 23)
        FinancialPeriodLabel.Name = "FinancialPeriodLabel"
        FinancialPeriodLabel.Size = New System.Drawing.Size(113, 17)
        FinancialPeriodLabel.TabIndex = 64
        FinancialPeriodLabel.Text = "Financial Period:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1153, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MISC. Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton16)
        Me.GroupBox1.Controls.Add(Me.RadioButton15)
        Me.GroupBox1.Controls.Add(Me.RadioButton14)
        Me.GroupBox1.Controls.Add(Me.RadioButton13)
        Me.GroupBox1.Controls.Add(Me.SalaryRecivingBtn)
        Me.GroupBox1.Controls.Add(Me.RadioButton12)
        Me.GroupBox1.Controls.Add(Me.SalarySlipBTn)
        Me.GroupBox1.Controls.Add(Me.RadioButton11)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.PSSCNO)
        Me.GroupBox1.Controls.Add(Me.ASSCNO)
        Me.GroupBox1.Controls.Add(Me.pendEOBICrd)
        Me.GroupBox1.Controls.Add(Me.RejoiningBtn)
        Me.GroupBox1.Controls.Add(Me.InAcvtivePESSi)
        Me.GroupBox1.Controls.Add(Me.EOBIEmp)
        Me.GroupBox1.Controls.Add(Me.PESSIlistBtn)
        Me.GroupBox1.Controls.Add(Me.UnionBtn)
        Me.GroupBox1.Controls.Add(Me.EOBiEmpBtn)
        Me.GroupBox1.Controls.Add(Me.PESSIEmpBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(43, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 362)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Select "
        '
        'RadioButton16
        '
        Me.RadioButton16.AutoSize = True
        Me.RadioButton16.ForeColor = System.Drawing.Color.Black
        Me.RadioButton16.Location = New System.Drawing.Point(278, 259)
        Me.RadioButton16.Name = "RadioButton16"
        Me.RadioButton16.Size = New System.Drawing.Size(188, 21)
        Me.RadioButton16.TabIndex = 49
        Me.RadioButton16.Text = "Pessi Contribution Format"
        Me.RadioButton16.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.ForeColor = System.Drawing.Color.Black
        Me.RadioButton15.Location = New System.Drawing.Point(28, 182)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(159, 21)
        Me.RadioButton15.TabIndex = 48
        Me.RadioButton15.Text = "EOBI Format Monthly"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.ForeColor = System.Drawing.Color.Black
        Me.RadioButton14.Location = New System.Drawing.Point(28, 156)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(186, 21)
        Me.RadioButton14.TabIndex = 47
        Me.RadioButton14.Text = "P.E.S.S.I. Format Monthly"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.ForeColor = System.Drawing.Color.Black
        Me.RadioButton13.Location = New System.Drawing.Point(28, 52)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(209, 21)
        Me.RadioButton13.TabIndex = 46
        Me.RadioButton13.Text = "EOBI Report(EOBI WEb Site)"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'SalaryRecivingBtn
        '
        Me.SalaryRecivingBtn.AutoSize = True
        Me.SalaryRecivingBtn.ForeColor = System.Drawing.Color.Black
        Me.SalaryRecivingBtn.Location = New System.Drawing.Point(235, 112)
        Me.SalaryRecivingBtn.Name = "SalaryRecivingBtn"
        Me.SalaryRecivingBtn.Size = New System.Drawing.Size(158, 21)
        Me.SalaryRecivingBtn.TabIndex = 43
        Me.SalaryRecivingBtn.Text = "Salary Receiving List"
        Me.SalaryRecivingBtn.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.ForeColor = System.Drawing.Color.Black
        Me.RadioButton12.Location = New System.Drawing.Point(235, 64)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(220, 21)
        Me.RadioButton12.TabIndex = 42
        Me.RadioButton12.Text = "Employee Monthlly Attendance"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'SalarySlipBTn
        '
        Me.SalarySlipBTn.AutoSize = True
        Me.SalarySlipBTn.ForeColor = System.Drawing.Color.Black
        Me.SalarySlipBTn.Location = New System.Drawing.Point(235, 88)
        Me.SalarySlipBTn.Name = "SalarySlipBTn"
        Me.SalarySlipBTn.Size = New System.Drawing.Size(100, 21)
        Me.SalarySlipBTn.TabIndex = 42
        Me.SalarySlipBTn.Text = "Salary Slips"
        Me.SalarySlipBTn.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.ForeColor = System.Drawing.Color.Black
        Me.RadioButton11.Location = New System.Drawing.Point(235, 40)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(178, 21)
        Me.RadioButton11.TabIndex = 41
        Me.RadioButton11.Text = "Employee Hygiene Card"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(235, 16)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(269, 21)
        Me.RadioButton8.TabIndex = 40
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Employees Age at The Time of Joining"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(28, 312)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(388, 21)
        Me.RadioButton7.TabIndex = 39
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Employee List having Different Joining And Graduity Date"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(235, 184)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(305, 21)
        Me.RadioButton5.TabIndex = 38
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Annual Leaves Due For the Selected Month "
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(235, 160)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(267, 21)
        Me.RadioButton4.TabIndex = 37
        Me.RadioButton4.Text = "Employee List for Inssurance Removal"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Black
        Me.RadioButton9.Location = New System.Drawing.Point(235, 136)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(212, 21)
        Me.RadioButton9.TabIndex = 36
        Me.RadioButton9.Text = "Employee List for Inssurance "
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'PSSCNO
        '
        Me.PSSCNO.AutoSize = True
        Me.PSSCNO.ForeColor = System.Drawing.Color.Black
        Me.PSSCNO.Location = New System.Drawing.Point(28, 286)
        Me.PSSCNO.Name = "PSSCNO"
        Me.PSSCNO.Size = New System.Drawing.Size(249, 21)
        Me.PSSCNO.TabIndex = 12
        Me.PSSCNO.Text = "Employee List missing PESSI Cards"
        Me.PSSCNO.UseVisualStyleBackColor = True
        '
        'ASSCNO
        '
        Me.ASSCNO.AutoSize = True
        Me.ASSCNO.ForeColor = System.Drawing.Color.Black
        Me.ASSCNO.Location = New System.Drawing.Point(28, 260)
        Me.ASSCNO.Name = "ASSCNO"
        Me.ASSCNO.Size = New System.Drawing.Size(244, 21)
        Me.ASSCNO.TabIndex = 11
        Me.ASSCNO.Text = "Employee List having PESSI Cards"
        Me.ASSCNO.UseVisualStyleBackColor = True
        '
        'pendEOBICrd
        '
        Me.pendEOBICrd.AutoSize = True
        Me.pendEOBICrd.ForeColor = System.Drawing.Color.Black
        Me.pendEOBICrd.Location = New System.Drawing.Point(28, 104)
        Me.pendEOBICrd.Name = "pendEOBICrd"
        Me.pendEOBICrd.Size = New System.Drawing.Size(137, 21)
        Me.pendEOBICrd.TabIndex = 10
        Me.pendEOBICrd.Text = "InActive EOBI List"
        Me.pendEOBICrd.UseVisualStyleBackColor = True
        '
        'RejoiningBtn
        '
        Me.RejoiningBtn.AutoSize = True
        Me.RejoiningBtn.ForeColor = System.Drawing.Color.Black
        Me.RejoiningBtn.Location = New System.Drawing.Point(235, 232)
        Me.RejoiningBtn.Name = "RejoiningBtn"
        Me.RejoiningBtn.Size = New System.Drawing.Size(177, 21)
        Me.RejoiningBtn.TabIndex = 4
        Me.RejoiningBtn.Text = "Rejoining Employee List"
        Me.RejoiningBtn.UseVisualStyleBackColor = True
        '
        'InAcvtivePESSi
        '
        Me.InAcvtivePESSi.AutoSize = True
        Me.InAcvtivePESSi.ForeColor = System.Drawing.Color.Black
        Me.InAcvtivePESSi.Location = New System.Drawing.Point(28, 234)
        Me.InAcvtivePESSi.Name = "InAcvtivePESSi"
        Me.InAcvtivePESSi.Size = New System.Drawing.Size(144, 21)
        Me.InAcvtivePESSi.TabIndex = 8
        Me.InAcvtivePESSi.Text = "InActive PESSI List"
        Me.InAcvtivePESSi.UseVisualStyleBackColor = True
        '
        'EOBIEmp
        '
        Me.EOBIEmp.AutoSize = True
        Me.EOBIEmp.ForeColor = System.Drawing.Color.Black
        Me.EOBIEmp.Location = New System.Drawing.Point(28, 78)
        Me.EOBIEmp.Name = "EOBIEmp"
        Me.EOBIEmp.Size = New System.Drawing.Size(126, 21)
        Me.EOBIEmp.TabIndex = 5
        Me.EOBIEmp.Text = "Active EOBI List"
        Me.EOBIEmp.UseVisualStyleBackColor = True
        '
        'PESSIlistBtn
        '
        Me.PESSIlistBtn.AutoSize = True
        Me.PESSIlistBtn.ForeColor = System.Drawing.Color.Black
        Me.PESSIlistBtn.Location = New System.Drawing.Point(28, 208)
        Me.PESSIlistBtn.Name = "PESSIlistBtn"
        Me.PESSIlistBtn.Size = New System.Drawing.Size(137, 21)
        Me.PESSIlistBtn.TabIndex = 5
        Me.PESSIlistBtn.Text = "Active PESSI List "
        Me.PESSIlistBtn.UseVisualStyleBackColor = True
        '
        'UnionBtn
        '
        Me.UnionBtn.AutoSize = True
        Me.UnionBtn.ForeColor = System.Drawing.Color.Black
        Me.UnionBtn.Location = New System.Drawing.Point(235, 208)
        Me.UnionBtn.Name = "UnionBtn"
        Me.UnionBtn.Size = New System.Drawing.Size(242, 21)
        Me.UnionBtn.TabIndex = 1
        Me.UnionBtn.Text = "Union Fund Contribution (Monthly)"
        Me.UnionBtn.UseVisualStyleBackColor = True
        '
        'EOBiEmpBtn
        '
        Me.EOBiEmpBtn.AutoSize = True
        Me.EOBiEmpBtn.Checked = True
        Me.EOBiEmpBtn.ForeColor = System.Drawing.Color.Black
        Me.EOBiEmpBtn.Location = New System.Drawing.Point(28, 26)
        Me.EOBiEmpBtn.Name = "EOBiEmpBtn"
        Me.EOBiEmpBtn.Size = New System.Drawing.Size(201, 21)
        Me.EOBiEmpBtn.TabIndex = 3
        Me.EOBiEmpBtn.TabStop = True
        Me.EOBiEmpBtn.Text = "EOBI Contribution (Monthly)"
        Me.EOBiEmpBtn.UseVisualStyleBackColor = True
        '
        'PESSIEmpBtn
        '
        Me.PESSIEmpBtn.AutoSize = True
        Me.PESSIEmpBtn.ForeColor = System.Drawing.Color.Black
        Me.PESSIEmpBtn.Location = New System.Drawing.Point(28, 130)
        Me.PESSIEmpBtn.Name = "PESSIEmpBtn"
        Me.PESSIEmpBtn.Size = New System.Drawing.Size(208, 21)
        Me.PESSIEmpBtn.TabIndex = 2
        Me.PESSIEmpBtn.Text = "PESSI Contribution (Monthly)"
        Me.PESSIEmpBtn.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(580, 605)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(177, 17)
        Me.RadioButton10.TabIndex = 41
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "OverTime PreCalculation Report"
        Me.RadioButton10.UseVisualStyleBackColor = True
        Me.RadioButton10.Visible = False
        '
        'UFBtn
        '
        Me.UFBtn.AutoSize = True
        Me.UFBtn.ForeColor = System.Drawing.Color.Black
        Me.UFBtn.Location = New System.Drawing.Point(801, 541)
        Me.UFBtn.Name = "UFBtn"
        Me.UFBtn.Size = New System.Drawing.Size(102, 17)
        Me.UFBtn.TabIndex = 7
        Me.UFBtn.Text = "Union Fund List "
        Me.UFBtn.UseVisualStyleBackColor = True
        Me.UFBtn.Visible = False
        '
        'btnRptShow
        '
        Me.btnRptShow.BackColor = System.Drawing.Color.Green
        Me.btnRptShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptShow.ForeColor = System.Drawing.Color.White
        Me.btnRptShow.Location = New System.Drawing.Point(878, 454)
        Me.btnRptShow.Name = "btnRptShow"
        Me.btnRptShow.Size = New System.Drawing.Size(127, 47)
        Me.btnRptShow.TabIndex = 22
        Me.btnRptShow.Text = "Show Report"
        Me.btnRptShow.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SectionNameComboBox)
        Me.Panel1.Controls.Add(Me.DesigNameComboBox)
        Me.Panel1.Controls.Add(Me.DeptNameComboBox)
        Me.Panel1.Controls.Add(Me.DesigBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SecBTn)
        Me.Panel1.Controls.Add(Me.DepartmentBtn)
        Me.Panel1.Controls.Add(Me.AllBtn)
        Me.Panel1.Controls.Add(DeptNameLabel)
        Me.Panel1.Controls.Add(SectionNameLabel)
        Me.Panel1.Controls.Add(DesigNameLabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(583, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 194)
        Me.Panel1.TabIndex = 23
        '
        'SectionNameComboBox
        '
        Me.SectionNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SectionNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectionNameComboBox.DataSource = Me.Tbl_HRM_SectionBindingSource
        Me.SectionNameComboBox.DisplayMember = "SectionName"
        Me.SectionNameComboBox.Enabled = False
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(126, 70)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(255, 24)
        Me.SectionNameComboBox.TabIndex = 25
        Me.SectionNameComboBox.ValueMember = "SectionID"
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
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(126, 98)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(255, 24)
        Me.DesigNameComboBox.TabIndex = 11
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(126, 42)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(255, 24)
        Me.DeptNameComboBox.TabIndex = 9
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.ForeColor = System.Drawing.Color.Black
        Me.DesigBtn.Location = New System.Drawing.Point(14, 160)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBtn.TabIndex = 3
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(421, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select Appropriate Option"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SecBTn
        '
        Me.SecBTn.AutoSize = True
        Me.SecBTn.ForeColor = System.Drawing.Color.Black
        Me.SecBTn.Location = New System.Drawing.Point(126, 160)
        Me.SecBTn.Name = "SecBTn"
        Me.SecBTn.Size = New System.Drawing.Size(81, 21)
        Me.SecBTn.TabIndex = 4
        Me.SecBTn.Text = "Section  "
        Me.SecBTn.UseVisualStyleBackColor = True
        '
        'DepartmentBtn
        '
        Me.DepartmentBtn.AutoSize = True
        Me.DepartmentBtn.ForeColor = System.Drawing.Color.Black
        Me.DepartmentBtn.Location = New System.Drawing.Point(126, 135)
        Me.DepartmentBtn.Name = "DepartmentBtn"
        Me.DepartmentBtn.Size = New System.Drawing.Size(108, 21)
        Me.DepartmentBtn.TabIndex = 1
        Me.DepartmentBtn.Text = "Deptartment "
        Me.DepartmentBtn.UseVisualStyleBackColor = True
        '
        'AllBtn
        '
        Me.AllBtn.AutoSize = True
        Me.AllBtn.Checked = True
        Me.AllBtn.ForeColor = System.Drawing.Color.Black
        Me.AllBtn.Location = New System.Drawing.Point(14, 135)
        Me.AllBtn.Name = "AllBtn"
        Me.AllBtn.Size = New System.Drawing.Size(41, 21)
        Me.AllBtn.TabIndex = 0
        Me.AllBtn.TabStop = True
        Me.AllBtn.Text = "All"
        Me.AllBtn.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_DeptTableAdapter
        '
        Me.Tbl_HRM_DeptTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DeptTableAdapter = Me.Tbl_HRM_DeptTableAdapter
        Me.TableAdapterManager.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Me.Tbl_HRM_DesignationTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Me.Tbl_HRM_SectionTableAdapter
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(FinancialPeriodLabel)
        Me.GroupBox7.Controls.Add(Me.FinancialPeriodComboBox)
        Me.GroupBox7.Controls.Add(BranchNameLabel)
        Me.GroupBox7.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox7.Controls.Add(Me.TextBox2)
        Me.GroupBox7.Controls.Add(Me.TextBox1)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Bymonth)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(583, 89)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(423, 148)
        Me.GroupBox7.TabIndex = 24
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Option Selector"
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.Enabled = False
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(125, 20)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(257, 24)
        Me.FinancialPeriodComboBox.TabIndex = 65
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.HRMDBDataset1
        '
        'HRMDBDataset1
        '
        Me.HRMDBDataset1.DataSetName = "HRMDBDataset1"
        Me.HRMDBDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(125, 120)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(257, 24)
        Me.BranchNameComboBox.TabIndex = 60
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(307, 88)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 23)
        Me.TextBox2.TabIndex = 57
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(127, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(68, 23)
        Me.TextBox1.TabIndex = 56
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(234, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "To Card:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "From Card:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(296, 59)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(86, 23)
        Me.DateTimePicker2.TabIndex = 54
        Me.DateTimePicker2.Visible = False
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(234, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "To Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Select Month:"
        '
        'Bymonth
        '
        Me.Bymonth.CustomFormat = "MMM, yyyy"
        Me.Bymonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Bymonth.Location = New System.Drawing.Point(127, 57)
        Me.Bymonth.Name = "Bymonth"
        Me.Bymonth.Size = New System.Drawing.Size(106, 23)
        Me.Bymonth.TabIndex = 0
        '
        'Tbl_Hrm_EmploymentBindingSource
        '
        Me.Tbl_Hrm_EmploymentBindingSource.DataMember = "tbl_Hrm_Employment"
        Me.Tbl_Hrm_EmploymentBindingSource.DataSource = Me.DSHRM
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.NonActiveBtn)
        Me.GroupBox6.Controls.Add(Me.ActiveBtn)
        Me.GroupBox6.Controls.Add(Me.AllEmp)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(43, 37)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(308, 46)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Active/Non Active Employees"
        '
        'NonActiveBtn
        '
        Me.NonActiveBtn.AutoSize = True
        Me.NonActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActiveBtn.Location = New System.Drawing.Point(88, 22)
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
        Me.ActiveBtn.Location = New System.Drawing.Point(22, 22)
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
        Me.AllEmp.Location = New System.Drawing.Point(192, 22)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'Tbl_Hrm_EmploymentTableAdapter
        '
        Me.Tbl_Hrm_EmploymentTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(44, 456)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 98)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection Option "
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(23, 73)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(95, 21)
        Me.RadioButton6.TabIndex = 3
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "By Branch "
        Me.RadioButton6.UseVisualStyleBackColor = True
        Me.RadioButton6.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(23, 48)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(126, 21)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "By Card Range "
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(28, 74)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(144, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "By Date Of Joining"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(23, 24)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(45, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "All "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Comp_InfoTableAdapter = Me.Tbl_Comp_InfoTableAdapter
        Me.TableAdapterManager3.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager3.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager3.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager3.UsersTableAdapter = Nothing
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        Me.Tbl_Comp_InfoBindingSource.DataSource = Me.DSUser
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Me.Tbl_Acc_FinancialPeriodTableAdapter
        Me.TableAdapterManager1.tbl_Hrm_BranchTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_CardTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_GradesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.HRMDBDataset1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_FinancialPeriodBindingSource, "Status", True))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Location = New System.Drawing.Point(1117, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Label3"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton18)
        Me.GroupBox3.Controls.Add(Me.RadioButton20)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(53, 560)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(237, 98)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Selection Option "
        Me.GroupBox3.Visible = False
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.ForeColor = System.Drawing.Color.Black
        Me.RadioButton18.Location = New System.Drawing.Point(23, 48)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(117, 21)
        Me.RadioButton18.TabIndex = 2
        Me.RadioButton18.TabStop = True
        Me.RadioButton18.Text = "By Age Range"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton20
        '
        Me.RadioButton20.AutoSize = True
        Me.RadioButton20.Checked = True
        Me.RadioButton20.ForeColor = System.Drawing.Color.Black
        Me.RadioButton20.Location = New System.Drawing.Point(23, 24)
        Me.RadioButton20.Name = "RadioButton20"
        Me.RadioButton20.Size = New System.Drawing.Size(45, 21)
        Me.RadioButton20.TabIndex = 0
        Me.RadioButton20.TabStop = True
        Me.RadioButton20.Text = "All "
        Me.RadioButton20.UseVisualStyleBackColor = True
        '
        'MiscRecord
        '
        Me.AcceptButton = Me.btnRptShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1153, 742)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRptShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UFBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MiscRecord"
        Me.Text = "Misc Reports "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_EmploymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRptShow As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DesigBtn As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents SecBTn As RadioButton
    Friend WithEvents DepartmentBtn As RadioButton
    Friend WithEvents AllBtn As RadioButton
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents UnionBtn As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Bymonth As DateTimePicker
    Friend WithEvents EOBiEmpBtn As RadioButton
    Friend WithEvents PESSIEmpBtn As RadioButton
    Friend WithEvents RejoiningBtn As RadioButton
    Friend WithEvents PESSIlistBtn As RadioButton
    Friend WithEvents EOBIEmp As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents NonActiveBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents UFBtn As RadioButton
    Friend WithEvents InAcvtivePESSi As RadioButton
    Friend WithEvents pendEOBICrd As RadioButton
    Friend WithEvents Tbl_Hrm_EmploymentBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_EmploymentTableAdapter As DSHRMTableAdapters.tbl_Hrm_EmploymentTableAdapter
    Friend WithEvents PSSCNO As RadioButton
    Friend WithEvents ASSCNO As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents TableAdapterManager3 As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents DSUser As DSUser
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents SalaryRecivingBtn As RadioButton
    Friend WithEvents SalarySlipBTn As RadioButton
    Friend WithEvents HRMDBDataset1 As HRMDBDataset1
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents TableAdapterManager1 As HRMDBDataset1TableAdapters.TableAdapterManager
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents FinancialPeriodComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton20 As RadioButton
End Class
