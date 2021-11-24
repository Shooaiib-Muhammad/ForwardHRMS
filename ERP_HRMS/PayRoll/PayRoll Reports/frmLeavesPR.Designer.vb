<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLeavesPR
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
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton32 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.EmpAnual = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.ShtleavBtn = New System.Windows.Forms.RadioButton()
        Me.DetlLeavRcd = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.LeavBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ByShift = New System.Windows.Forms.RadioButton()
        Me.BrnchBtn = New System.Windows.Forms.RadioButton()
        Me.RadioDateCard = New System.Windows.Forms.RadioButton()
        Me.Specialbtn = New System.Windows.Forms.RadioButton()
        Me.RadioByDate = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPayRoll = New ERP_HRMS.DSPayRoll()
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_PayRoll_ShiftsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDeptsForPayrollReport = New ERP_HRMS.DSDeptsForPayrollReport()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_BranchesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpecialFilterBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstCards = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbSelectCard = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_Emp_Info_H1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.L_Type = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Tocardtxt = New System.Windows.Forms.TextBox()
        Me.frmcardtxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StrtTime = New System.Windows.Forms.DateTimePicker()
        Me.EndTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeptPanel = New System.Windows.Forms.Panel()
        Me.Desig = New System.Windows.Forms.RadioButton()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_DesignationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllEMp = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Section = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ByDept = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_SubDept1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tbl_Hrm_DesignationsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager()
        Me.Tbl_Hrm_BranchesTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_BranchesTableAdapter()
        Me.Tbl_Hrm_DepartmentsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter()
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_Emp_Info_H1TableAdapter()
        Me.Tbl_Hrm_SubDept1TableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter()
        Me.Tbl_PayRoll_ShiftsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_PayRoll_ShiftsTableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.NonActiveBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        DesigNameLabel = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_ShiftsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_BranchesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpecialFilterBox.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeptPanel.SuspendLayout()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DesigNameLabel
        '
        DesigNameLabel.AutoSize = True
        DesigNameLabel.Location = New System.Drawing.Point(14, 90)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(87, 17)
        DesigNameLabel.TabIndex = 29
        DesigNameLabel.Text = "Designation:"
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(12, 170)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(92, 20)
        BranchNameLabel.TabIndex = 48
        BranchNameLabel.Text = "Branch:"
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.ForeColor = System.Drawing.Color.Black
        ShiftNameLabel.Location = New System.Drawing.Point(10, 197)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(94, 20)
        ShiftNameLabel.TabIndex = 47
        ShiftNameLabel.Text = "Shift:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1040, 40)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Leaves Reports"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton12)
        Me.GroupBox2.Controls.Add(Me.RadioButton11)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton32)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.EmpAnual)
        Me.GroupBox2.Controls.Add(Me.RadioButton18)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.ShtleavBtn)
        Me.GroupBox2.Controls.Add(Me.DetlLeavRcd)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.LeavBtn)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 425)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Selector"
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.ForeColor = System.Drawing.Color.Black
        Me.RadioButton11.Location = New System.Drawing.Point(10, 362)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(182, 21)
        Me.RadioButton11.TabIndex = 49
        Me.RadioButton11.Text = "Employee Leave Details "
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(11, 340)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(131, 21)
        Me.RadioButton10.TabIndex = 48
        Me.RadioButton10.Text = "Employee Leave"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Black
        Me.RadioButton9.Location = New System.Drawing.Point(11, 316)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(213, 21)
        Me.RadioButton9.TabIndex = 47
        Me.RadioButton9.Text = "Month Wise Leaves Summary"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(11, 193)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(243, 21)
        Me.RadioButton8.TabIndex = 46
        Me.RadioButton8.Text = "Employee Monthly Absent Reports"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(11, 289)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(192, 21)
        Me.RadioButton7.TabIndex = 45
        Me.RadioButton7.Text = "Date Wise Leaves Details "
        Me.RadioButton7.UseVisualStyleBackColor = True
        Me.RadioButton7.Visible = False
        '
        'RadioButton32
        '
        Me.RadioButton32.AutoSize = True
        Me.RadioButton32.ForeColor = System.Drawing.Color.Black
        Me.RadioButton32.Location = New System.Drawing.Point(11, 145)
        Me.RadioButton32.Name = "RadioButton32"
        Me.RadioButton32.Size = New System.Drawing.Size(194, 21)
        Me.RadioButton32.TabIndex = 32
        Me.RadioButton32.Text = "List of Paid Annual Leaves"
        Me.RadioButton32.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(11, 121)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(304, 21)
        Me.RadioButton1.TabIndex = 42
        Me.RadioButton1.Text = "List of Employees eligible for Annual Leaves"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'EmpAnual
        '
        Me.EmpAnual.AutoSize = True
        Me.EmpAnual.ForeColor = System.Drawing.Color.Black
        Me.EmpAnual.Location = New System.Drawing.Point(11, 97)
        Me.EmpAnual.Name = "EmpAnual"
        Me.EmpAnual.Size = New System.Drawing.Size(212, 21)
        Me.EmpAnual.TabIndex = 41
        Me.EmpAnual.Text = "Employee List Annual Record"
        Me.EmpAnual.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.ForeColor = System.Drawing.Color.Black
        Me.RadioButton18.Location = New System.Drawing.Point(11, 73)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(217, 21)
        Me.RadioButton18.TabIndex = 40
        Me.RadioButton18.Text = "Employee List Monthly Record"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(11, 265)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(135, 21)
        Me.RadioButton6.TabIndex = 44
        Me.RadioButton6.Text = "Leaves Summary"
        Me.RadioButton6.UseVisualStyleBackColor = True
        Me.RadioButton6.Visible = False
        '
        'ShtleavBtn
        '
        Me.ShtleavBtn.AutoSize = True
        Me.ShtleavBtn.ForeColor = System.Drawing.Color.Black
        Me.ShtleavBtn.Location = New System.Drawing.Point(11, 169)
        Me.ShtleavBtn.Name = "ShtleavBtn"
        Me.ShtleavBtn.Size = New System.Drawing.Size(160, 21)
        Me.ShtleavBtn.TabIndex = 4
        Me.ShtleavBtn.Text = "Short Leaves Record"
        Me.ShtleavBtn.UseVisualStyleBackColor = True
        '
        'DetlLeavRcd
        '
        Me.DetlLeavRcd.AutoSize = True
        Me.DetlLeavRcd.ForeColor = System.Drawing.Color.Black
        Me.DetlLeavRcd.Location = New System.Drawing.Point(11, 49)
        Me.DetlLeavRcd.Name = "DetlLeavRcd"
        Me.DetlLeavRcd.Size = New System.Drawing.Size(182, 21)
        Me.DetlLeavRcd.TabIndex = 3
        Me.DetlLeavRcd.Text = "Detailed Leaves Record "
        Me.DetlLeavRcd.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(11, 217)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(228, 21)
        Me.RadioButton3.TabIndex = 43
        Me.RadioButton3.Text = "Employee Leaves Detail Record"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'LeavBtn
        '
        Me.LeavBtn.AutoSize = True
        Me.LeavBtn.Checked = True
        Me.LeavBtn.ForeColor = System.Drawing.Color.Black
        Me.LeavBtn.Location = New System.Drawing.Point(11, 25)
        Me.LeavBtn.Name = "LeavBtn"
        Me.LeavBtn.Size = New System.Drawing.Size(111, 21)
        Me.LeavBtn.TabIndex = 1
        Me.LeavBtn.TabStop = True
        Me.LeavBtn.Text = "Daily Leaves "
        Me.LeavBtn.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(11, 241)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(205, 21)
        Me.RadioButton2.TabIndex = 42
        Me.RadioButton2.Text = "Leaves Against Special O.T "
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(854, 99)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton5.TabIndex = 44
        Me.RadioButton5.Text = "All Type Daily Leaves"
        Me.RadioButton5.UseVisualStyleBackColor = True
        Me.RadioButton5.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ByShift)
        Me.GroupBox1.Controls.Add(Me.BrnchBtn)
        Me.GroupBox1.Controls.Add(Me.RadioDateCard)
        Me.GroupBox1.Controls.Add(Me.Specialbtn)
        Me.GroupBox1.Controls.Add(Me.RadioByDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 541)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 136)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selector"
        '
        'ByShift
        '
        Me.ByShift.AutoSize = True
        Me.ByShift.ForeColor = System.Drawing.Color.Black
        Me.ByShift.Location = New System.Drawing.Point(11, 111)
        Me.ByShift.Name = "ByShift"
        Me.ByShift.Size = New System.Drawing.Size(74, 21)
        Me.ByShift.TabIndex = 4
        Me.ByShift.Text = "By Shift"
        Me.ByShift.UseVisualStyleBackColor = True
        '
        'BrnchBtn
        '
        Me.BrnchBtn.AutoSize = True
        Me.BrnchBtn.ForeColor = System.Drawing.Color.Black
        Me.BrnchBtn.Location = New System.Drawing.Point(11, 88)
        Me.BrnchBtn.Name = "BrnchBtn"
        Me.BrnchBtn.Size = New System.Drawing.Size(91, 21)
        Me.BrnchBtn.TabIndex = 3
        Me.BrnchBtn.Text = "By Branch"
        Me.BrnchBtn.UseVisualStyleBackColor = True
        '
        'RadioDateCard
        '
        Me.RadioDateCard.AutoSize = True
        Me.RadioDateCard.ForeColor = System.Drawing.Color.Black
        Me.RadioDateCard.Location = New System.Drawing.Point(11, 42)
        Me.RadioDateCard.Name = "RadioDateCard"
        Me.RadioDateCard.Size = New System.Drawing.Size(122, 21)
        Me.RadioDateCard.TabIndex = 1
        Me.RadioDateCard.Text = "By Card Range"
        Me.RadioDateCard.UseVisualStyleBackColor = True
        '
        'Specialbtn
        '
        Me.Specialbtn.AutoSize = True
        Me.Specialbtn.ForeColor = System.Drawing.Color.Black
        Me.Specialbtn.Location = New System.Drawing.Point(11, 65)
        Me.Specialbtn.Name = "Specialbtn"
        Me.Specialbtn.Size = New System.Drawing.Size(131, 21)
        Me.Specialbtn.TabIndex = 2
        Me.Specialbtn.Text = "By Special Filter "
        Me.Specialbtn.UseVisualStyleBackColor = True
        '
        'RadioByDate
        '
        Me.RadioByDate.AutoSize = True
        Me.RadioByDate.Checked = True
        Me.RadioByDate.ForeColor = System.Drawing.Color.Black
        Me.RadioByDate.Location = New System.Drawing.Point(11, 19)
        Me.RadioByDate.Name = "RadioByDate"
        Me.RadioByDate.Size = New System.Drawing.Size(76, 21)
        Me.RadioByDate.TabIndex = 0
        Me.RadioByDate.TabStop = True
        Me.RadioByDate.Text = "By Date"
        Me.RadioByDate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(BranchNameLabel)
        Me.Panel1.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Panel1.Controls.Add(ShiftNameLabel)
        Me.Panel1.Controls.Add(Me.ShiftNameComboBox)
        Me.Panel1.Controls.Add(Me.BranchNameComboBox)
        Me.Panel1.Controls.Add(Me.SpecialFilterBox)
        Me.Panel1.Controls.Add(Me.L_Type)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Tocardtxt)
        Me.Panel1.Controls.Add(Me.frmcardtxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.StrtTime)
        Me.Panel1.Controls.Add(Me.EndTime)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(337, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 403)
        Me.Panel1.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(11, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 20)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Financial Period:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinancialPeriodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(129, 34)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(196, 24)
        Me.FinancialPeriodComboBox.TabIndex = 44
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSPayRoll
        '
        'DSPayRoll
        '
        Me.DSPayRoll.DataSetName = "DSPayRoll"
        Me.DSPayRoll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ShiftNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShiftNameComboBox.DataSource = Me.Tbl_PayRoll_ShiftsBindingSource
        Me.ShiftNameComboBox.DisplayMember = "ShiftName"
        Me.ShiftNameComboBox.Enabled = False
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(109, 193)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(296, 24)
        Me.ShiftNameComboBox.TabIndex = 49
        Me.ShiftNameComboBox.ValueMember = "ShiftID"
        '
        'Tbl_PayRoll_ShiftsBindingSource
        '
        Me.Tbl_PayRoll_ShiftsBindingSource.DataMember = "tbl_PayRoll_Shifts"
        Me.Tbl_PayRoll_ShiftsBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'DSDeptsForPayrollReport
        '
        Me.DSDeptsForPayrollReport.DataSetName = "DSDeptsForPayrollReport"
        Me.DSDeptsForPayrollReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_Hrm_BranchesBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(109, 164)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(296, 24)
        Me.BranchNameComboBox.TabIndex = 50
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_Hrm_BranchesBindingSource
        '
        Me.Tbl_Hrm_BranchesBindingSource.DataMember = "tbl_Hrm_Branches"
        Me.Tbl_Hrm_BranchesBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'SpecialFilterBox
        '
        Me.SpecialFilterBox.Controls.Add(Me.Label4)
        Me.SpecialFilterBox.Controls.Add(Me.btnRemove)
        Me.SpecialFilterBox.Controls.Add(Me.lstCards)
        Me.SpecialFilterBox.Controls.Add(Me.btnAdd)
        Me.SpecialFilterBox.Controls.Add(Me.cmbSelectCard)
        Me.SpecialFilterBox.Enabled = False
        Me.SpecialFilterBox.Location = New System.Drawing.Point(109, 223)
        Me.SpecialFilterBox.Name = "SpecialFilterBox"
        Me.SpecialFilterBox.Size = New System.Drawing.Size(295, 167)
        Me.SpecialFilterBox.TabIndex = 44
        Me.SpecialFilterBox.TabStop = False
        Me.SpecialFilterBox.Text = "Special Filter"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "From Card:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.White
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(181, 134)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(94, 30)
        Me.btnRemove.TabIndex = 38
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lstCards
        '
        Me.lstCards.BackColor = System.Drawing.Color.Gainsboro
        Me.lstCards.FormattingEnabled = True
        Me.lstCards.ItemHeight = 16
        Me.lstCards.Location = New System.Drawing.Point(31, 80)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.Size = New System.Drawing.Size(145, 84)
        Me.lstCards.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(181, 96)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 34)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmbSelectCard
        '
        Me.cmbSelectCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSelectCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSelectCard.DataSource = Me.Tbl_Hrm_Emp_Info_H1BindingSource
        Me.cmbSelectCard.DisplayMember = "CardNo"
        Me.cmbSelectCard.FormattingEnabled = True
        Me.cmbSelectCard.Location = New System.Drawing.Point(31, 53)
        Me.cmbSelectCard.Name = "cmbSelectCard"
        Me.cmbSelectCard.Size = New System.Drawing.Size(145, 24)
        Me.cmbSelectCard.TabIndex = 1
        Me.cmbSelectCard.ValueMember = "CardNo"
        '
        'Tbl_Hrm_Emp_Info_H1BindingSource
        '
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataMember = "tbl_Hrm_Emp_Info_H1"
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'L_Type
        '
        Me.L_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.L_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L_Type.FormattingEnabled = True
        Me.L_Type.Location = New System.Drawing.Point(109, 135)
        Me.L_Type.Name = "L_Type"
        Me.L_Type.Size = New System.Drawing.Size(296, 24)
        Me.L_Type.TabIndex = 43
        Me.L_Type.Text = "Casual"
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Leave Type:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tocardtxt
        '
        Me.Tocardtxt.Enabled = False
        Me.Tocardtxt.Location = New System.Drawing.Point(305, 104)
        Me.Tocardtxt.Name = "Tocardtxt"
        Me.Tocardtxt.Size = New System.Drawing.Size(100, 23)
        Me.Tocardtxt.TabIndex = 18
        Me.Tocardtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmcardtxt
        '
        Me.frmcardtxt.Enabled = False
        Me.frmcardtxt.Location = New System.Drawing.Point(109, 102)
        Me.frmcardtxt.Name = "frmcardtxt"
        Me.frmcardtxt.Size = New System.Drawing.Size(100, 23)
        Me.frmcardtxt.TabIndex = 17
        Me.frmcardtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "From Card:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(235, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "To Card:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(423, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Select Appropriate Filter Value"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StrtTime
        '
        Me.StrtTime.CustomFormat = "dd/MM/yyyy"
        Me.StrtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StrtTime.Location = New System.Drawing.Point(109, 73)
        Me.StrtTime.Name = "StrtTime"
        Me.StrtTime.Size = New System.Drawing.Size(100, 23)
        Me.StrtTime.TabIndex = 15
        '
        'EndTime
        '
        Me.EndTime.CustomFormat = "dd/MM/yyyy"
        Me.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndTime.Location = New System.Drawing.Point(305, 72)
        Me.EndTime.Name = "EndTime"
        Me.EndTime.Size = New System.Drawing.Size(100, 23)
        Me.EndTime.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(235, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "To Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptPanel
        '
        Me.DeptPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DeptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptPanel.Controls.Add(Me.Desig)
        Me.DeptPanel.Controls.Add(DesigNameLabel)
        Me.DeptPanel.Controls.Add(Me.DesigNameComboBox)
        Me.DeptPanel.Controls.Add(Me.AllEMp)
        Me.DeptPanel.Controls.Add(Me.Label9)
        Me.DeptPanel.Controls.Add(Me.Section)
        Me.DeptPanel.Controls.Add(Me.Label11)
        Me.DeptPanel.Controls.Add(Me.ByDept)
        Me.DeptPanel.Controls.Add(Me.Label5)
        Me.DeptPanel.Controls.Add(Me.NameComboBox)
        Me.DeptPanel.Controls.Add(Me.DeptNameComboBox)
        Me.DeptPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptPanel.Location = New System.Drawing.Point(337, 453)
        Me.DeptPanel.Name = "DeptPanel"
        Me.DeptPanel.Size = New System.Drawing.Size(425, 179)
        Me.DeptPanel.TabIndex = 29
        '
        'Desig
        '
        Me.Desig.AutoSize = True
        Me.Desig.Location = New System.Drawing.Point(14, 146)
        Me.Desig.Name = "Desig"
        Me.Desig.Size = New System.Drawing.Size(101, 21)
        Me.Desig.TabIndex = 31
        Me.Desig.TabStop = True
        Me.Desig.Text = "Designation"
        Me.Desig.UseVisualStyleBackColor = True
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_Hrm_DesignationsBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(117, 87)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(288, 24)
        Me.DesigNameComboBox.TabIndex = 30
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_Hrm_DesignationsBindingSource
        '
        Me.Tbl_Hrm_DesignationsBindingSource.DataMember = "tbl_Hrm_Designations"
        Me.Tbl_Hrm_DesignationsBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'AllEMp
        '
        Me.AllEMp.AutoSize = True
        Me.AllEMp.Checked = True
        Me.AllEMp.Location = New System.Drawing.Point(14, 119)
        Me.AllEMp.Name = "AllEMp"
        Me.AllEMp.Size = New System.Drawing.Size(45, 21)
        Me.AllEMp.TabIndex = 29
        Me.AllEMp.TabStop = True
        Me.AllEMp.Text = "All "
        Me.AllEMp.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(423, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Select Appropriate Option"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Section
        '
        Me.Section.AutoSize = True
        Me.Section.Location = New System.Drawing.Point(140, 146)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(73, 21)
        Me.Section.TabIndex = 27
        Me.Section.Text = "Section"
        Me.Section.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(14, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Section:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ByDept
        '
        Me.ByDept.AutoSize = True
        Me.ByDept.Location = New System.Drawing.Point(140, 119)
        Me.ByDept.Name = "ByDept"
        Me.ByDept.Size = New System.Drawing.Size(100, 21)
        Me.ByDept.TabIndex = 26
        Me.ByDept.Text = "Department"
        Me.ByDept.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Department :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.Tbl_Hrm_SubDept1BindingSource
        Me.NameComboBox.DisplayMember = "SectionName"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(117, 59)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(288, 24)
        Me.NameComboBox.TabIndex = 24
        Me.NameComboBox.ValueMember = "SectionID"
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
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_Hrm_DepartmentsBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(117, 31)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(288, 24)
        Me.DeptNameComboBox.TabIndex = 23
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(768, 586)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 47)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_H1TableAdapter = Me.Tbl_Hrm_Emp_Info_H1TableAdapter
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_H2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_SubDept1TableAdapter = Me.Tbl_Hrm_SubDept1TableAdapter
        Me.TableAdapterManager.tbl_PayRoll_ShiftsTableAdapter = Me.Tbl_PayRoll_ShiftsTableAdapter
        Me.TableAdapterManager.tbl_Working_DayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Hrm_BranchesTableAdapter
        '
        Me.Tbl_Hrm_BranchesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_DepartmentsTableAdapter
        '
        Me.Tbl_Hrm_DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_H1TableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_SubDept1TableAdapter
        '
        Me.Tbl_Hrm_SubDept1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_ShiftsTableAdapter
        '
        Me.Tbl_PayRoll_ShiftsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Acc_AnnualLeaveTransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Me.Tbl_Acc_FinancialPeriodTableAdapter
        Me.TableAdapterManager1.tbl_Att_DeviceSpecialTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Att_DeviceTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Cont_AttTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_Att_VisitTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_AttTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Shift1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_PayRoll_LongLeavesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_PayRoll_ShortLeavesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.NonActiveBtn)
        Me.GroupBox5.Controls.Add(Me.ActiveBtn)
        Me.GroupBox5.Controls.Add(Me.RadioButton4)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(309, 46)
        Me.GroupBox5.TabIndex = 35
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Active/Non Active Employees"
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
        Me.ActiveBtn.Location = New System.Drawing.Point(18, 22)
        Me.ActiveBtn.Name = "ActiveBtn"
        Me.ActiveBtn.Size = New System.Drawing.Size(64, 21)
        Me.ActiveBtn.TabIndex = 0
        Me.ActiveBtn.TabStop = True
        Me.ActiveBtn.Text = "Active"
        Me.ActiveBtn.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(192, 22)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(41, 21)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.Text = "All"
        Me.RadioButton4.UseVisualStyleBackColor = True
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Comp_InfoTableAdapter = Me.Tbl_Comp_InfoTableAdapter
        Me.TableAdapterManager2.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager2.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.UsersTableAdapter = Nothing
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.ForeColor = System.Drawing.Color.Black
        Me.RadioButton12.Location = New System.Drawing.Point(11, 389)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(172, 21)
        Me.RadioButton12.TabIndex = 50
        Me.RadioButton12.Text = "Monthly Leaves Report"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'frmLeavesPR
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1040, 677)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DeptPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmLeavesPR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaves Reports"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_ShiftsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_BranchesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpecialFilterBox.ResumeLayout(False)
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeptPanel.ResumeLayout(False)
        Me.DeptPanel.PerformLayout()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioDateCard As RadioButton
    Friend WithEvents Specialbtn As RadioButton
    Friend WithEvents RadioByDate As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tocardtxt As TextBox
    Friend WithEvents frmcardtxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents StrtTime As DateTimePicker
    Friend WithEvents EndTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstCards As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbSelectCard As ComboBox
    Friend WithEvents DeptPanel As Panel
    Friend WithEvents Desig As RadioButton
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents AllEMp As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Section As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents ByDept As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents L_Type As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents SpecialFilterBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ByShift As RadioButton
    Friend WithEvents BrnchBtn As RadioButton
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents DetlLeavRcd As RadioButton
    Friend WithEvents DSDeptsForPayrollReport As DSDeptsForPayrollReport
    Friend WithEvents Tbl_Hrm_DesignationsBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_DesignationsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter
    Friend WithEvents TableAdapterManager As DSDeptsForPayrollReportTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Hrm_DepartmentsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter
    Friend WithEvents Tbl_Hrm_DepartmentsBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_SubDept1TableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter
    Friend WithEvents Tbl_Hrm_SubDept1BindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_H1TableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_Emp_Info_H1TableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Info_H1BindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_ShiftsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_PayRoll_ShiftsTableAdapter
    Friend WithEvents Tbl_PayRoll_ShiftsBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_BranchesTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_BranchesTableAdapter
    Friend WithEvents Tbl_Hrm_BranchesBindingSource As BindingSource
    Friend WithEvents ShtleavBtn As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents FinancialPeriodComboBox As ComboBox
    Friend WithEvents DSPayRoll As DSPayRoll
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSPayRollTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents TableAdapterManager1 As DSPayRollTableAdapters.TableAdapterManager
    Friend WithEvents EmpAnual As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton32 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents NonActiveBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents DSUser As DSUser
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents TableAdapterManager2 As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents LeavBtn As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
End Class
