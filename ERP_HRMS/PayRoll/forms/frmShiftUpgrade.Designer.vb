<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShiftUpgrade
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
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim AccJobTypeLabel As System.Windows.Forms.Label
        Dim DateOfPermanentLabel As System.Windows.Forms.Label
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim JobTypeNameLabel As System.Windows.Forms.Label
        Dim AttLockStatusLabel As System.Windows.Forms.Label
        Me.DSAdvance = New ERP_HRMS.DSAdvance()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.Tbl_Acc_ShortTermAdvances11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card_New123BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New ERP_HRMS.DSAdvanceTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Card11TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_Card11TableAdapter()
        Me.CardNoLabel5 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter()
        Me.Tbl_Acc_ShortTermAdvances11TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_ShortTermAdvances11TableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Tbl_Hrm_Emp_Info_H1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.Tbl_Hrm_Emp_Info_H1TableAdapter()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Tbl_HRM_Card_NewTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_Card_NewTableAdapter()
        Me.CardNoLabel3 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_Card_New123TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_Card_New123TableAdapter()
        Me.DSDept = New ERP_HRMS.DSDept()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSDeptTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSDeptTableAdapters.TableAdapterManager()
        Me.TableAdapterManager2 = New ERP_HRMS.UpGradeSalaryTableAdapters.TableAdapterManager()
        Me.Tbl_Fin_DebitCredit_Entry1TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.Tbl_Fin_DebitCredit_Entry1TableAdapter()
        Me.Tbl_Fin_Journal_HeadTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Fin_Journal_HeadTableAdapter()
        Me.Tbl_Fin_DebitCredit_EntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fin_DebitCredit_EntryTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Fin_DebitCredit_EntryTableAdapter()
        Me.Tbl_Fin_DebitCredit_Entry1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fin_Journal_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Acc_Fin_Ded_VouchersTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.View_Acc_Fin_Ded_VouchersTableAdapter()
        Me.View_Acc_Fin_Ded_VouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_FinancialPeriodAdvTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_FinancialPeriodAdvTableAdapter()
        Me.Tbl_Acc_FinancialPeriod11TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_FinancialPeriod11TableAdapter()
        Me.Tbl_Acc_BonusNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_BonusNoTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_BonusNoTableAdapter()
        Me.Tbl_Acc_FinancialPeriodAdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_FinancialPeriod11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fin_Layer4_NewTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Fin_Layer4_NewTableAdapter()
        Me.Tbl_Fin_Layer4_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardAdvTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_CardAdvTableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_Acc_PermanentAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_PermanentAdvancesTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_PermanentAdvancesTableAdapter()
        Me.Tbl_HRM_CardAdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_ShortTermAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter()
        Me.Tbl_HRM_Card11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Card_InfoTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.View_Card_InfoTableAdapter()
        Me.View_Card_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_CardTableAdapter()
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpGradeSalary = New ERP_HRMS.UpGradeSalary()
        Me.Salary_UpgradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Salary_UpgradeTableAdapter = New ERP_HRMS.UpGradeSalaryTableAdapters.Salary_UpgradeTableAdapter()
        Me.EmpIDLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_SalaryTableAdapter = New ERP_HRMS.UpGradeSalaryTableAdapters.tbl_Acc_SalaryTableAdapter()
        Me.EmpIDLabel2 = New System.Windows.Forms.Label()
        Me.Tbl_HRm_Shift_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRm_Shift_InfoTableAdapter = New ERP_HRMS.UpGradeSalaryTableAdapters.tbl_HRm_Shift_InfoTableAdapter()
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpIDLabel3 = New System.Windows.Forms.Label()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CardNoLabel4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AttLockStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.SHiftComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.DateOfJoningLabel2 = New System.Windows.Forms.Label()
        Me.FatherNameLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BranchNameLabel2 = New System.Windows.Forms.Label()
        Me.JobTypeNameLabel2 = New System.Windows.Forms.Label()
        Me.DesigNameLabel2 = New System.Windows.Forms.Label()
        Me.SectionNameLabel2 = New System.Windows.Forms.Label()
        Me.DeptNameLabel2 = New System.Windows.Forms.Label()
        Me.EmpStatusLabel = New System.Windows.Forms.Label()
        Me.EmpStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.EmpPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.SectionNameLabel = New System.Windows.Forms.Label()
        Me.DesigNameLabel = New System.Windows.Forms.Label()
        Me.DeptNameLabel = New System.Windows.Forms.Label()
        Me.DateOfJoningLabel = New System.Windows.Forms.Label()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_CardBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_InfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_ShiftBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_JobTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_GradeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRm_Shift_InfoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.TableAdapterManager3 = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tbl_HRM_Emp_InfoTableAdapter = New ERP_HRMS.UpGradeSalaryTableAdapters.tbl_HRM_Emp_InfoTableAdapter()
        Me.Tbl_HRM_ShiftTableAdapter1 = New ERP_HRMS.UpGradeSalaryTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.Tbl_HRM_CardTableAdapter1 = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_CardTableAdapter()
        Me.Tbl_HRM_Emp_InfoTableAdapter1 = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_Emp_InfoTableAdapter()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_JobTypeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter()
        Me.Tbl_HRM_GradeTableAdapter1 = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.DataTable1TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.DataTable1TableAdapter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CardNoLabel = New System.Windows.Forms.Label()
        AccJobTypeLabel = New System.Windows.Forms.Label()
        DateOfPermanentLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        JobTypeNameLabel = New System.Windows.Forms.Label()
        AttLockStatusLabel = New System.Windows.Forms.Label()
        CType(Me.DSAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.Tbl_Acc_ShortTermAdvances11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card_New123BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fin_DebitCredit_EntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fin_DebitCredit_Entry1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fin_Journal_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_Fin_Ded_VouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_BonusNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodAdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriod11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fin_Layer4_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PermanentAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardAdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Card_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpGradeSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salary_UpgradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRm_Shift_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_ShiftBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_GradeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRm_Shift_InfoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CardNoLabel
        '
        CardNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CardNoLabel.Location = New System.Drawing.Point(12, 39)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(74, 20)
        CardNoLabel.TabIndex = 7
        CardNoLabel.Text = "Card No:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AccJobTypeLabel
        '
        AccJobTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccJobTypeLabel.Location = New System.Drawing.Point(5, 259)
        AccJobTypeLabel.Name = "AccJobTypeLabel"
        AccJobTypeLabel.Size = New System.Drawing.Size(102, 17)
        AccJobTypeLabel.TabIndex = 35
        AccJobTypeLabel.Text = "Shift:"
        AccJobTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfPermanentLabel
        '
        DateOfPermanentLabel.Location = New System.Drawing.Point(5, 95)
        DateOfPermanentLabel.Name = "DateOfPermanentLabel"
        DateOfPermanentLabel.Size = New System.Drawing.Size(100, 20)
        DateOfPermanentLabel.TabIndex = 34
        DateOfPermanentLabel.Text = "D.O.P:"
        DateOfPermanentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FatherNameLabel
        '
        FatherNameLabel.Location = New System.Drawing.Point(5, 42)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(100, 20)
        FatherNameLabel.TabIndex = 32
        FatherNameLabel.Text = "Father Name:"
        FatherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JobTypeNameLabel
        '
        JobTypeNameLabel.Location = New System.Drawing.Point(5, 121)
        JobTypeNameLabel.Name = "JobTypeNameLabel"
        JobTypeNameLabel.Size = New System.Drawing.Size(100, 20)
        JobTypeNameLabel.TabIndex = 19
        JobTypeNameLabel.Text = "Job Type:"
        JobTypeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AttLockStatusLabel
        '
        AttLockStatusLabel.Location = New System.Drawing.Point(5, 283)
        AttLockStatusLabel.Name = "AttLockStatusLabel"
        AttLockStatusLabel.Size = New System.Drawing.Size(115, 21)
        AttLockStatusLabel.TabIndex = 117
        AttLockStatusLabel.Text = "Lock  Att Status:"
        '
        'DSAdvance
        '
        Me.DSAdvance.DataSetName = "DSAdvance"
        Me.DSAdvance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 550)
        Me.Panel2.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 91)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(777, 454)
        Me.DataGridView1.TabIndex = 9
        Me.DataGridView1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.btnSave)
        Me.Panel8.Controls.Add(Me.tbFilePath)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.btnOpenFile)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Controls.Add(Me.DateTimePicker5)
        Me.Panel8.Location = New System.Drawing.Point(3, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(776, 85)
        Me.Panel8.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(643, 35)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(116, 36)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save Now"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tbFilePath
        '
        Me.tbFilePath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tbFilePath.Location = New System.Drawing.Point(3, 57)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(450, 20)
        Me.tbFilePath.TabIndex = 29
        Me.tbFilePath.TabStop = False
        Me.tbFilePath.Text = "Browse an Excel File Here to Upload Data..."
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 20)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Shift Effective Date:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.White
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.Color.Black
        Me.btnOpenFile.Location = New System.Drawing.Point(459, 55)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(86, 24)
        Me.btnOpenFile.TabIndex = 30
        Me.btnOpenFile.Text = "Browse File"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(772, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Manage Shift By Excel File"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(132, 32)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker5.TabIndex = 27
        '
        'Tbl_Acc_ShortTermAdvances11BindingSource
        '
        Me.Tbl_Acc_ShortTermAdvances11BindingSource.DataMember = "tbl_Acc_ShortTermAdvances11"
        Me.Tbl_Acc_ShortTermAdvances11BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_Card_New123BindingSource
        '
        Me.Tbl_HRM_Card_New123BindingSource.DataMember = "tbl_HRM_Card_New123"
        Me.Tbl_HRM_Card_New123BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_Card_NewBindingSource
        '
        Me.Tbl_HRM_Card_NewBindingSource.DataSource = Me.DSAdvance
        Me.Tbl_HRM_Card_NewBindingSource.Position = 0
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1203, 39)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Employee Shift Management "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Acc_BonusNoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriod11TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodAdvTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_PermanentAdvancesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_ShortTermAdvances11TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_ShortTermAdvancesTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Fin_DebitCredit_Entry1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Fin_DebitCredit_EntryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Fin_Journal_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Fin_Layer4_NewTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSAdvanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_Card11TableAdapter
        '
        Me.Tbl_HRM_Card11TableAdapter.ClearBeforeFill = True
        '
        'CardNoLabel5
        '
        Me.CardNoLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.CardNoLabel5.Location = New System.Drawing.Point(7, 334)
        Me.CardNoLabel5.Name = "CardNoLabel5"
        Me.CardNoLabel5.Size = New System.Drawing.Size(100, 10)
        Me.CardNoLabel5.TabIndex = 16
        Me.CardNoLabel5.Text = "Label9"
        '
        'Tbl_Acc_ShortTermAdvancesTableAdapter
        '
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_ShortTermAdvances11TableAdapter
        '
        Me.Tbl_Acc_ShortTermAdvances11TableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tbl_Hrm_Emp_Info_H1BindingSource
        '
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataMember = "Tbl_Hrm_Emp_Info_H1"
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Hrm_Emp_Info_H1TableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Tbl_HRM_Card_NewTableAdapter
        '
        Me.Tbl_HRM_Card_NewTableAdapter.ClearBeforeFill = True
        '
        'CardNoLabel3
        '
        Me.CardNoLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.CardNoLabel3.Location = New System.Drawing.Point(17, 304)
        Me.CardNoLabel3.Name = "CardNoLabel3"
        Me.CardNoLabel3.Size = New System.Drawing.Size(100, 16)
        Me.CardNoLabel3.TabIndex = 14
        Me.CardNoLabel3.Text = "Label9"
        '
        'Tbl_HRM_Card_New123TableAdapter
        '
        Me.Tbl_HRM_Card_New123TableAdapter.ClearBeforeFill = True
        '
        'DSDept
        '
        Me.DSDept.DataSetName = "DSDept"
        Me.DSDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSDept
        '
        'Tbl_HRM_GradeTableAdapter
        '
        Me.Tbl_HRM_GradeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_HRM_Dept_NewTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_GradeTableAdapter = Me.Tbl_HRM_GradeTableAdapter
        Me.TableAdapterManager1.tbl_HRM_Section_NewTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSDeptTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.View_Inactive_EmpTableAdapter = Nothing
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.UpGradeSalaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Fin_DebitCredit_Entry1TableAdapter
        '
        Me.Tbl_Fin_DebitCredit_Entry1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fin_Journal_HeadTableAdapter
        '
        Me.Tbl_Fin_Journal_HeadTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fin_DebitCredit_EntryBindingSource
        '
        Me.Tbl_Fin_DebitCredit_EntryBindingSource.DataMember = "tbl_Fin_DebitCredit_Entry"
        Me.Tbl_Fin_DebitCredit_EntryBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Fin_DebitCredit_EntryTableAdapter
        '
        Me.Tbl_Fin_DebitCredit_EntryTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fin_DebitCredit_Entry1BindingSource
        '
        Me.Tbl_Fin_DebitCredit_Entry1BindingSource.DataMember = "Tbl_Fin_DebitCredit_Entry1"
        Me.Tbl_Fin_DebitCredit_Entry1BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Fin_Journal_HeadBindingSource
        '
        Me.Tbl_Fin_Journal_HeadBindingSource.DataMember = "tbl_Fin_Journal_Head"
        Me.Tbl_Fin_Journal_HeadBindingSource.DataSource = Me.DSAdvance
        '
        'View_Acc_Fin_Ded_VouchersTableAdapter
        '
        Me.View_Acc_Fin_Ded_VouchersTableAdapter.ClearBeforeFill = True
        '
        'View_Acc_Fin_Ded_VouchersBindingSource
        '
        Me.View_Acc_Fin_Ded_VouchersBindingSource.DataMember = "View_Acc_Fin_Ded_Vouchers"
        Me.View_Acc_Fin_Ded_VouchersBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_FinancialPeriodAdvTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodAdvTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriod11TableAdapter
        '
        Me.Tbl_Acc_FinancialPeriod11TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_BonusNoBindingSource
        '
        Me.Tbl_Acc_BonusNoBindingSource.DataMember = "tbl_Acc_BonusNo"
        Me.Tbl_Acc_BonusNoBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_BonusNoTableAdapter
        '
        Me.Tbl_Acc_BonusNoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodAdvBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodAdvBindingSource.DataMember = "tbl_Acc_FinancialPeriodAdv"
        Me.Tbl_Acc_FinancialPeriodAdvBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_FinancialPeriod11BindingSource
        '
        Me.Tbl_Acc_FinancialPeriod11BindingSource.DataMember = "tbl_Acc_FinancialPeriod11"
        Me.Tbl_Acc_FinancialPeriod11BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Fin_Layer4_NewTableAdapter
        '
        Me.Tbl_Fin_Layer4_NewTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fin_Layer4_NewBindingSource
        '
        Me.Tbl_Fin_Layer4_NewBindingSource.DataMember = "tbl_Fin_Layer4_New"
        Me.Tbl_Fin_Layer4_NewBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_CardAdvTableAdapter
        '
        Me.Tbl_HRM_CardAdvTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_PermanentAdvancesBindingSource
        '
        Me.Tbl_Acc_PermanentAdvancesBindingSource.DataMember = "tbl_Acc_PermanentAdvances"
        Me.Tbl_Acc_PermanentAdvancesBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_PermanentAdvancesTableAdapter
        '
        Me.Tbl_Acc_PermanentAdvancesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_CardAdvBindingSource
        '
        Me.Tbl_HRM_CardAdvBindingSource.DataMember = "tbl_HRM_CardAdv"
        Me.Tbl_HRM_CardAdvBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_ShortTermAdvancesBindingSource
        '
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataMember = "View_Rpt_HR_EmpData_ActiveNonActive_tbl_Acc_ShortTermAdvances"
        '
        'View_Rpt_HR_EmpData_ActiveNonActiveBindingSource
        '
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource.DataMember = "View_Rpt_HR_EmpData_ActiveNonActive"
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource.DataSource = Me.DSAdvance
        '
        'View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter
        '
        Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Card11BindingSource
        '
        Me.Tbl_HRM_Card11BindingSource.DataMember = "tbl_HRM_Card11"
        Me.Tbl_HRM_Card11BindingSource.DataSource = Me.DSAdvance
        '
        'View_Card_InfoTableAdapter
        '
        Me.View_Card_InfoTableAdapter.ClearBeforeFill = True
        '
        'View_Card_InfoBindingSource
        '
        Me.View_Card_InfoBindingSource.DataMember = "View_Card_Info"
        Me.View_Card_InfoBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSAdvance
        '
        'UpGradeSalary
        '
        Me.UpGradeSalary.DataSetName = "UpGradeSalary"
        Me.UpGradeSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Salary_UpgradeBindingSource
        '
        Me.Salary_UpgradeBindingSource.DataMember = "Salary_Upgrade"
        Me.Salary_UpgradeBindingSource.DataSource = Me.UpGradeSalary
        '
        'Salary_UpgradeTableAdapter
        '
        Me.Salary_UpgradeTableAdapter.ClearBeforeFill = True
        '
        'EmpIDLabel1
        '
        Me.EmpIDLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpIDLabel1.Location = New System.Drawing.Point(113, 297)
        Me.EmpIDLabel1.Name = "EmpIDLabel1"
        Me.EmpIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.EmpIDLabel1.TabIndex = 18
        '
        'Tbl_Acc_SalaryBindingSource
        '
        Me.Tbl_Acc_SalaryBindingSource.DataMember = "tbl_Acc_Salary"
        Me.Tbl_Acc_SalaryBindingSource.DataSource = Me.UpGradeSalary
        '
        'Tbl_Acc_SalaryTableAdapter
        '
        Me.Tbl_Acc_SalaryTableAdapter.ClearBeforeFill = True
        '
        'EmpIDLabel2
        '
        Me.EmpIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "EmpID", True))
        Me.EmpIDLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpIDLabel2.Location = New System.Drawing.Point(206, 356)
        Me.EmpIDLabel2.Name = "EmpIDLabel2"
        Me.EmpIDLabel2.Size = New System.Drawing.Size(100, 23)
        Me.EmpIDLabel2.TabIndex = 19
        Me.EmpIDLabel2.Text = "Label1"
        '
        'Tbl_HRm_Shift_InfoBindingSource
        '
        Me.Tbl_HRm_Shift_InfoBindingSource.DataSource = Me.UpGradeSalary
        Me.Tbl_HRm_Shift_InfoBindingSource.Position = 0
        '
        'Tbl_HRm_Shift_InfoTableAdapter
        '
        Me.Tbl_HRm_Shift_InfoTableAdapter.ClearBeforeFill = True
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRm_Shift_InfoBindingSource, "CardNo", True))
        Me.CardNoLabel1.Location = New System.Drawing.Point(1066, 63)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CardNoLabel1.TabIndex = 33
        Me.CardNoLabel1.Text = "Label1"
        Me.CardNoLabel1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(820, 567)
        Me.TabControl1.TabIndex = 34
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(793, 559)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manage Shift By Excel File"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.EmpIDLabel3)
        Me.TabPage2.Controls.Add(Me.CardNoLabel4)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(CardNoLabel)
        Me.TabPage2.Controls.Add(Me.CardNoComboBox)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(793, 559)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Manage Shift By Card No"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(787, 25)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Manage Shift By Card No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpIDLabel3
        '
        Me.EmpIDLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "EmpID", True))
        Me.EmpIDLabel3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.EmpIDLabel3.Location = New System.Drawing.Point(495, 45)
        Me.EmpIDLabel3.Name = "EmpIDLabel3"
        Me.EmpIDLabel3.Size = New System.Drawing.Size(100, 23)
        Me.EmpIDLabel3.TabIndex = 11
        Me.EmpIDLabel3.Text = "Label1"
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "View_Card_Info_DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.View_Card_InfoBindingSource
        '
        'CardNoLabel4
        '
        Me.CardNoLabel4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Card_InfoBindingSource, "CardNo", True))
        Me.CardNoLabel4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CardNoLabel4.Location = New System.Drawing.Point(390, 45)
        Me.CardNoLabel4.Name = "CardNoLabel4"
        Me.CardNoLabel4.Size = New System.Drawing.Size(100, 15)
        Me.CardNoLabel4.TabIndex = 10
        Me.CardNoLabel4.Text = "Label1"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.NameLabel1)
        Me.Panel4.Controls.Add(AttLockStatusLabel)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.AttLockStatusCheckBox)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(AccJobTypeLabel)
        Me.Panel4.Controls.Add(Me.saveBtn)
        Me.Panel4.Controls.Add(Me.SHiftComboBox)
        Me.Panel4.Controls.Add(DateOfPermanentLabel)
        Me.Panel4.Controls.Add(Me.DateOfJoningLabel2)
        Me.Panel4.Controls.Add(FatherNameLabel)
        Me.Panel4.Controls.Add(Me.FatherNameLabel1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.BranchNameLabel2)
        Me.Panel4.Controls.Add(Me.JobTypeNameLabel2)
        Me.Panel4.Controls.Add(Me.DesigNameLabel2)
        Me.Panel4.Controls.Add(Me.SectionNameLabel2)
        Me.Panel4.Controls.Add(Me.DeptNameLabel2)
        Me.Panel4.Controls.Add(JobTypeNameLabel)
        Me.Panel4.Controls.Add(Me.EmpStatusLabel)
        Me.Panel4.Controls.Add(Me.EmpStatusCheckBox)
        Me.Panel4.Controls.Add(Me.EmpPicPictureBox)
        Me.Panel4.Controls.Add(Me.SectionNameLabel)
        Me.Panel4.Controls.Add(Me.DesigNameLabel)
        Me.Panel4.Controls.Add(Me.DeptNameLabel)
        Me.Panel4.Controls.Add(Me.DateOfJoningLabel)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(6, 69)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(774, 480)
        Me.Panel4.TabIndex = 9
        '
        'NameLabel1
        '
        Me.NameLabel1.BackColor = System.Drawing.Color.White
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(128, 15)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(178, 20)
        Me.NameLabel1.TabIndex = 120
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "DateOfPermanent", True))
        Me.Label7.Location = New System.Drawing.Point(128, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AttLockStatusCheckBox
        '
        Me.AttLockStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DataTable1BindingSource, "AttLockStatus", True))
        Me.AttLockStatusCheckBox.Location = New System.Drawing.Point(128, 280)
        Me.AttLockStatusCheckBox.Name = "AttLockStatusCheckBox"
        Me.AttLockStatusCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AttLockStatusCheckBox.TabIndex = 118
        Me.AttLockStatusCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(536, 283)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 34)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DataTable1BindingSource, "EmpPic", True))
        Me.PictureBox1.Location = New System.Drawing.Point(536, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 123)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.White
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.Color.Black
        Me.saveBtn.Location = New System.Drawing.Point(800, 97)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 34)
        Me.saveBtn.TabIndex = 37
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'SHiftComboBox
        '
        Me.SHiftComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SHiftComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataTable1BindingSource, "ShiftID", True))
        Me.SHiftComboBox.DataSource = Me.Tbl_HRM_ShiftBindingSource
        Me.SHiftComboBox.DisplayMember = "ShiftName"
        Me.SHiftComboBox.FormattingEnabled = True
        Me.SHiftComboBox.Location = New System.Drawing.Point(128, 250)
        Me.SHiftComboBox.Name = "SHiftComboBox"
        Me.SHiftComboBox.Size = New System.Drawing.Size(295, 24)
        Me.SHiftComboBox.TabIndex = 36
        Me.SHiftComboBox.ValueMember = "ShiftID"
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateOfJoningLabel2
        '
        Me.DateOfJoningLabel2.BackColor = System.Drawing.Color.White
        Me.DateOfJoningLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "DateOfJoning", True))
        Me.DateOfJoningLabel2.Location = New System.Drawing.Point(128, 68)
        Me.DateOfJoningLabel2.Name = "DateOfJoningLabel2"
        Me.DateOfJoningLabel2.Size = New System.Drawing.Size(178, 20)
        Me.DateOfJoningLabel2.TabIndex = 34
        Me.DateOfJoningLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FatherNameLabel1
        '
        Me.FatherNameLabel1.BackColor = System.Drawing.Color.White
        Me.FatherNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "FatherName", True))
        Me.FatherNameLabel1.Location = New System.Drawing.Point(128, 42)
        Me.FatherNameLabel1.Name = "FatherNameLabel1"
        Me.FatherNameLabel1.Size = New System.Drawing.Size(178, 20)
        Me.FatherNameLabel1.TabIndex = 33
        Me.FatherNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Branch:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BranchNameLabel2
        '
        Me.BranchNameLabel2.BackColor = System.Drawing.Color.White
        Me.BranchNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "BranchName", True))
        Me.BranchNameLabel2.Location = New System.Drawing.Point(128, 224)
        Me.BranchNameLabel2.Name = "BranchNameLabel2"
        Me.BranchNameLabel2.Size = New System.Drawing.Size(628, 20)
        Me.BranchNameLabel2.TabIndex = 28
        Me.BranchNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JobTypeNameLabel2
        '
        Me.JobTypeNameLabel2.BackColor = System.Drawing.Color.White
        Me.JobTypeNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "JobTypeName", True))
        Me.JobTypeNameLabel2.Location = New System.Drawing.Point(128, 120)
        Me.JobTypeNameLabel2.Name = "JobTypeNameLabel2"
        Me.JobTypeNameLabel2.Size = New System.Drawing.Size(178, 20)
        Me.JobTypeNameLabel2.TabIndex = 27
        Me.JobTypeNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel2
        '
        Me.DesigNameLabel2.BackColor = System.Drawing.Color.White
        Me.DesigNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "DesigName", True))
        Me.DesigNameLabel2.Location = New System.Drawing.Point(128, 198)
        Me.DesigNameLabel2.Name = "DesigNameLabel2"
        Me.DesigNameLabel2.Size = New System.Drawing.Size(368, 20)
        Me.DesigNameLabel2.TabIndex = 25
        Me.DesigNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SectionNameLabel2
        '
        Me.SectionNameLabel2.BackColor = System.Drawing.Color.White
        Me.SectionNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "SectionName", True))
        Me.SectionNameLabel2.Location = New System.Drawing.Point(128, 172)
        Me.SectionNameLabel2.Name = "SectionNameLabel2"
        Me.SectionNameLabel2.Size = New System.Drawing.Size(368, 20)
        Me.SectionNameLabel2.TabIndex = 24
        Me.SectionNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptNameLabel2
        '
        Me.DeptNameLabel2.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "DeptName", True))
        Me.DeptNameLabel2.Location = New System.Drawing.Point(128, 146)
        Me.DeptNameLabel2.Name = "DeptNameLabel2"
        Me.DeptNameLabel2.Size = New System.Drawing.Size(368, 20)
        Me.DeptNameLabel2.TabIndex = 23
        Me.DeptNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpStatusLabel
        '
        Me.EmpStatusLabel.Location = New System.Drawing.Point(533, 147)
        Me.EmpStatusLabel.Name = "EmpStatusLabel"
        Me.EmpStatusLabel.Size = New System.Drawing.Size(84, 17)
        Me.EmpStatusLabel.TabIndex = 15
        Me.EmpStatusLabel.Text = "Emp Status:"
        Me.EmpStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpStatusCheckBox
        '
        Me.EmpStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DataTable1BindingSource, "EmpStatus", True))
        Me.EmpStatusCheckBox.Enabled = False
        Me.EmpStatusCheckBox.Location = New System.Drawing.Point(632, 146)
        Me.EmpStatusCheckBox.Name = "EmpStatusCheckBox"
        Me.EmpStatusCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.EmpStatusCheckBox.TabIndex = 16
        Me.EmpStatusCheckBox.UseVisualStyleBackColor = True
        '
        'EmpPicPictureBox
        '
        Me.EmpPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.DataTable1BindingSource, "EmpPic", True))
        Me.EmpPicPictureBox.Location = New System.Drawing.Point(881, 8)
        Me.EmpPicPictureBox.Name = "EmpPicPictureBox"
        Me.EmpPicPictureBox.Size = New System.Drawing.Size(119, 123)
        Me.EmpPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPicPictureBox.TabIndex = 15
        Me.EmpPicPictureBox.TabStop = False
        '
        'SectionNameLabel
        '
        Me.SectionNameLabel.Location = New System.Drawing.Point(5, 173)
        Me.SectionNameLabel.Name = "SectionNameLabel"
        Me.SectionNameLabel.Size = New System.Drawing.Size(100, 20)
        Me.SectionNameLabel.TabIndex = 12
        Me.SectionNameLabel.Text = "Section:"
        Me.SectionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        Me.DesigNameLabel.Location = New System.Drawing.Point(5, 198)
        Me.DesigNameLabel.Name = "DesigNameLabel"
        Me.DesigNameLabel.Size = New System.Drawing.Size(100, 20)
        Me.DesigNameLabel.TabIndex = 10
        Me.DesigNameLabel.Text = "Designation:"
        Me.DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptNameLabel
        '
        Me.DeptNameLabel.Location = New System.Drawing.Point(5, 147)
        Me.DeptNameLabel.Name = "DeptNameLabel"
        Me.DeptNameLabel.Size = New System.Drawing.Size(100, 20)
        Me.DeptNameLabel.TabIndex = 8
        Me.DeptNameLabel.Text = "Department:"
        Me.DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfJoningLabel
        '
        Me.DateOfJoningLabel.Location = New System.Drawing.Point(5, 69)
        Me.DateOfJoningLabel.Name = "DateOfJoningLabel"
        Me.DateOfJoningLabel.Size = New System.Drawing.Size(100, 20)
        Me.DateOfJoningLabel.TabIndex = 6
        Me.DateOfJoningLabel.Text = "D.O.J:"
        Me.DateOfJoningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.View_Card_InfoBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(118, 38)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(110, 21)
        Me.CardNoComboBox.TabIndex = 8
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'Tbl_HRM_CardBindingSource1
        '
        Me.Tbl_HRM_CardBindingSource1.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource1.DataSource = Me.DSHRM
        '
        'Tbl_HRM_Emp_InfoBindingSource1
        '
        Me.Tbl_HRM_Emp_InfoBindingSource1.DataMember = "tbl_HRM_Card_tbl_HRM_Emp_Info"
        Me.Tbl_HRM_Emp_InfoBindingSource1.DataSource = Me.Tbl_HRM_CardBindingSource1
        '
        'Tbl_HRM_ShiftBindingSource1
        '
        Me.Tbl_HRM_ShiftBindingSource1.DataMember = "tbl_HRM_Emp_Info_tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource1.DataSource = Me.Tbl_HRM_Emp_InfoBindingSource
        '
        'Tbl_HRM_Emp_InfoBindingSource
        '
        Me.Tbl_HRM_Emp_InfoBindingSource.DataMember = "tbl_HRM_Emp_Info"
        Me.Tbl_HRM_Emp_InfoBindingSource.DataSource = Me.UpGradeSalary
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_JobTypeBindingSource
        '
        Me.Tbl_HRM_JobTypeBindingSource.DataMember = "tbl_HRM_JobType"
        Me.Tbl_HRM_JobTypeBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_GradeBindingSource1
        '
        Me.Tbl_HRM_GradeBindingSource1.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource1.DataSource = Me.DSHRM
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
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
        'Tbl_HRm_Shift_InfoBindingSource1
        '
        Me.Tbl_HRm_Shift_InfoBindingSource1.DataMember = "tbl_HRm_Shift_Info"
        Me.Tbl_HRm_Shift_InfoBindingSource1.DataSource = Me.UpGradeSalary
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Location = New System.Drawing.Point(234, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(826, 572)
        Me.Panel1.TabIndex = 35
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Location = New System.Drawing.Point(20, 49)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(209, 57)
        Me.Panel3.TabIndex = 113
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(6, 29)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(198, 21)
        Me.LinkLabel2.TabIndex = 113
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Manage Shift By Card No"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(198, 21)
        Me.LinkLabel1.TabIndex = 113
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Manage Shift By Excel File"
        '
        'Tbl_HRM_ShiftTableAdapter
        '
        Me.Tbl_HRM_ShiftTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Acc_Salary_NewTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Acc_Salary1TableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Acc_Salary2TableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_BankTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_BranchTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_DeptTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_DesignationTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_HRM_ShiftTableAdapter = Me.Tbl_HRM_ShiftTableAdapter
        Me.TableAdapterManager3.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager3.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_Emp_InfoTableAdapter
        '
        Me.Tbl_HRM_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_ShiftTableAdapter1
        '
        Me.Tbl_HRM_ShiftTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_HRM_CardTableAdapter1
        '
        Me.Tbl_HRM_CardTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_HRM_Emp_InfoTableAdapter1
        '
        Me.Tbl_HRM_Emp_InfoTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_HRM_DeptTableAdapter
        '
        Me.Tbl_HRM_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_JobTypeTableAdapter
        '
        Me.Tbl_HRM_JobTypeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_GradeTableAdapter1
        '
        Me.Tbl_HRM_GradeTableAdapter1.ClearBeforeFill = True
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(88, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 20)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "Error Records"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(57, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 20)
        Me.Label4.TabIndex = 116
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(89, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Saved Records"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.ForestGreen
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(57, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 20)
        Me.Label6.TabIndex = 114
        '
        'frmShiftUpgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 838)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CardNoLabel1)
        Me.Controls.Add(Me.EmpIDLabel2)
        Me.Controls.Add(Me.EmpIDLabel1)
        Me.Controls.Add(Me.CardNoLabel5)
        Me.Controls.Add(Me.CardNoLabel3)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmShiftUpgrade"
        Me.Text = "Employee Shift Management "
        CType(Me.DSAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.Tbl_Acc_ShortTermAdvances11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card_New123BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fin_DebitCredit_EntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fin_DebitCredit_Entry1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fin_Journal_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_Fin_Ded_VouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_BonusNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodAdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriod11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fin_Layer4_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PermanentAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardAdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Card_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpGradeSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salary_UpgradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRm_Shift_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_ShiftBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_GradeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRm_Shift_InfoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DSAdvance As DSAdvance
    Friend WithEvents TableAdapterManager As DSAdvanceTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_Card11TableAdapter As DSAdvanceTableAdapters.tbl_HRM_Card11TableAdapter
    Friend WithEvents CardNoLabel5 As Label
    Friend WithEvents Tbl_Acc_ShortTermAdvancesTableAdapter As DSAdvanceTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter
    Friend WithEvents Tbl_Acc_ShortTermAdvances11BindingSource As BindingSource
    Friend WithEvents Tbl_Acc_ShortTermAdvances11TableAdapter As DSAdvanceTableAdapters.tbl_Acc_ShortTermAdvances11TableAdapter
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Tbl_Hrm_Emp_Info_H1BindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_H1TableAdapter As DSAdvanceTableAdapters.Tbl_Hrm_Emp_Info_H1TableAdapter
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Tbl_HRM_Card_NewBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card_NewTableAdapter As DSAdvanceTableAdapters.tbl_HRM_Card_NewTableAdapter
    Friend WithEvents CardNoLabel3 As Label
    Friend WithEvents Tbl_HRM_Card_New123BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card_New123TableAdapter As DSAdvanceTableAdapters.tbl_HRM_Card_New123TableAdapter
    Friend WithEvents DSDept As DSDept
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSDeptTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents TableAdapterManager1 As DSDeptTableAdapters.TableAdapterManager
    Friend WithEvents TableAdapterManager2 As UpGradeSalaryTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Fin_DebitCredit_Entry1TableAdapter As DSAdvanceTableAdapters.Tbl_Fin_DebitCredit_Entry1TableAdapter
    Friend WithEvents Tbl_Fin_Journal_HeadTableAdapter As DSAdvanceTableAdapters.tbl_Fin_Journal_HeadTableAdapter
    Friend WithEvents Tbl_Fin_DebitCredit_EntryBindingSource As BindingSource
    Friend WithEvents Tbl_Fin_DebitCredit_EntryTableAdapter As DSAdvanceTableAdapters.tbl_Fin_DebitCredit_EntryTableAdapter
    Friend WithEvents Tbl_Fin_DebitCredit_Entry1BindingSource As BindingSource
    Friend WithEvents Tbl_Fin_Journal_HeadBindingSource As BindingSource
    Friend WithEvents View_Acc_Fin_Ded_VouchersTableAdapter As DSAdvanceTableAdapters.View_Acc_Fin_Ded_VouchersTableAdapter
    Friend WithEvents View_Acc_Fin_Ded_VouchersBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodAdvTableAdapter As DSAdvanceTableAdapters.tbl_Acc_FinancialPeriodAdvTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriod11TableAdapter As DSAdvanceTableAdapters.tbl_Acc_FinancialPeriod11TableAdapter
    Friend WithEvents Tbl_Acc_BonusNoBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_BonusNoTableAdapter As DSAdvanceTableAdapters.tbl_Acc_BonusNoTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodAdvBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriod11BindingSource As BindingSource
    Friend WithEvents Tbl_Fin_Layer4_NewTableAdapter As DSAdvanceTableAdapters.tbl_Fin_Layer4_NewTableAdapter
    Friend WithEvents Tbl_Fin_Layer4_NewBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardAdvTableAdapter As DSAdvanceTableAdapters.tbl_HRM_CardAdvTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSAdvanceTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents Tbl_Acc_PermanentAdvancesBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_PermanentAdvancesTableAdapter As DSAdvanceTableAdapters.tbl_Acc_PermanentAdvancesTableAdapter
    Friend WithEvents Tbl_HRM_CardAdvBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_ShortTermAdvancesBindingSource As BindingSource
    Friend WithEvents View_Rpt_HR_EmpData_ActiveNonActiveBindingSource As BindingSource
    Friend WithEvents View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter As DSAdvanceTableAdapters.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter
    Friend WithEvents Tbl_HRM_Card11BindingSource As BindingSource
    Friend WithEvents View_Card_InfoTableAdapter As DSAdvanceTableAdapters.View_Card_InfoTableAdapter
    Friend WithEvents View_Card_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSAdvanceTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents UpGradeSalary As UpGradeSalary
    Friend WithEvents Salary_UpgradeBindingSource As BindingSource
    Friend WithEvents Salary_UpgradeTableAdapter As UpGradeSalaryTableAdapters.Salary_UpgradeTableAdapter
    Friend WithEvents EmpIDLabel1 As Label
    Friend WithEvents Tbl_Acc_SalaryBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_SalaryTableAdapter As UpGradeSalaryTableAdapters.tbl_Acc_SalaryTableAdapter
    Friend WithEvents EmpIDLabel2 As Label
    Friend WithEvents Tbl_HRm_Shift_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_HRm_Shift_InfoTableAdapter As UpGradeSalaryTableAdapters.tbl_HRm_Shift_InfoTableAdapter
    Friend WithEvents CardNoLabel1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents TableAdapterManager3 As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Tbl_HRm_Shift_InfoBindingSource1 As BindingSource
    Friend WithEvents Tbl_HRM_Emp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_InfoTableAdapter As UpGradeSalaryTableAdapters.tbl_HRM_Emp_InfoTableAdapter
    Friend WithEvents Tbl_HRM_ShiftBindingSource1 As BindingSource
    Friend WithEvents Tbl_HRM_ShiftTableAdapter1 As UpGradeSalaryTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents Tbl_HRM_CardBindingSource1 As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter1 As DSHRMTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents CardNoComboBox As ComboBox
    Friend WithEvents Tbl_HRM_Emp_InfoBindingSource1 As BindingSource
    Friend WithEvents Tbl_HRM_Emp_InfoTableAdapter1 As DSHRMTableAdapters.tbl_HRM_Emp_InfoTableAdapter
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_JobTypeBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_JobTypeTableAdapter As DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter
    Friend WithEvents Tbl_HRM_GradeBindingSource1 As BindingSource
    Friend WithEvents Tbl_HRM_GradeTableAdapter1 As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DSAdvanceTableAdapters.DataTable1TableAdapter
    Friend WithEvents Panel4 As Panel
    Friend WithEvents saveBtn As Button
    Friend WithEvents SHiftComboBox As ComboBox
    Friend WithEvents DateOfJoningLabel2 As Label
    Friend WithEvents FatherNameLabel1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BranchNameLabel2 As Label
    Friend WithEvents JobTypeNameLabel2 As Label
    Friend WithEvents DesigNameLabel2 As Label
    Friend WithEvents SectionNameLabel2 As Label
    Friend WithEvents DeptNameLabel2 As Label
    Friend WithEvents EmpStatusLabel As Label
    Friend WithEvents EmpStatusCheckBox As CheckBox
    Friend WithEvents EmpPicPictureBox As PictureBox
    Friend WithEvents SectionNameLabel As Label
    Friend WithEvents DesigNameLabel As Label
    Friend WithEvents DeptNameLabel As Label
    Friend WithEvents DateOfJoningLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmpIDLabel3 As Label
    Friend WithEvents CardNoLabel4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AttLockStatusCheckBox As CheckBox
    Friend WithEvents NameLabel1 As Label
End Class
