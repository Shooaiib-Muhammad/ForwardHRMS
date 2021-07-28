<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBonus
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
        Dim Label1 As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim PercentOfSalaryLabel As System.Windows.Forms.Label
        Dim ActivationStatusLabel As System.Windows.Forms.Label
        Dim BonusNoLabel As System.Windows.Forms.Label
        Dim FinancialPeriodLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim EmploymentTypeLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBonus))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBonus = New ERP_HRMS.DSBonus()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_BonusNoSettingsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PercentOfSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivationStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tbl_Acc_BonusNoSettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Acc_BonusTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_BonusNoSettings2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Acc_BonusTransactionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewComboBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Hrm_Emp_Info_H1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfMonths = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtDedAsLTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.View_Rpt_Acc_AllEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.EmpStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.EmploymentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_EmploymentTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PercentOfSalaryLabel1 = New System.Windows.Forms.Label()
        Me.ActivationStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.BonusNoLabel2 = New System.Windows.Forms.Label()
        Me.FinancialPeriodLabel2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSBonusTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSBonusTableAdapters.TableAdapterManager()
        Me.Tbl_Acc_BonusNoSettingsTableAdapter = New ERP_HRMS.DSBonusTableAdapters.tbl_Acc_BonusNoSettingsTableAdapter()
        Me.Tbl_Acc_BonusTransactionsTableAdapter = New ERP_HRMS.DSBonusTableAdapters.tbl_Acc_BonusTransactionsTableAdapter()
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Hrm_Emp_Info_H1TableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.HRMDBDataset1TableAdapters.TableAdapterManager()
        Me.View_Rpt_Acc_AllEmployeesTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter()
        Me.Tbl_Hrm_EmploymentTypeTableAdapter = New ERP_HRMS.DSBonusTableAdapters.tbl_Hrm_EmploymentTypeTableAdapter()
        Me.View_Rpt_Acc_PreSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_PreSalaryTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.View_Rpt_Acc_PreSalaryTableAdapter()
        Me.View_Rpt_Acc_EmpList4BonusTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_EmpList4BonusTransactionsTableAdapter = New ERP_HRMS.DSBonusTableAdapters.View_Rpt_Acc_EmpList4BonusTransactionsTableAdapter()
        Me.Tbl_Acc_BonusNoSettings2TableAdapter1 = New ERP_HRMS.DSBonusTableAdapters.tbl_Acc_BonusNoSettings2TableAdapter()
        Me.DSLongTermAdv = New ERP_HRMS.DSLongTermAdv()
        Me.Tbl_Acc_PAdvDeductionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_PAdvDeductionsTableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductionsTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.DSLongTermAdvTableAdapters.TableAdapterManager()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Label1 = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        CardNoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        PercentOfSalaryLabel = New System.Windows.Forms.Label()
        ActivationStatusLabel = New System.Windows.Forms.Label()
        BonusNoLabel = New System.Windows.Forms.Label()
        FinancialPeriodLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        EmploymentTypeLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.Tbl_Acc_BonusNoSettingsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_BonusNoSettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.Tbl_Acc_BonusTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_BonusNoSettings2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_BonusTransactionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Tbl_Hrm_EmploymentTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_BonusNoSettingsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.SuspendLayout()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_EmpList4BonusTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSLongTermAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(214, 5)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 18)
        Label1.TabIndex = 25
        Label1.Text = "Emp Status:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptNameLabel
        '
        DeptNameLabel.Location = New System.Drawing.Point(5, 77)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(74, 18)
        DeptNameLabel.TabIndex = 36
        DeptNameLabel.Text = "Section :"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel
        '
        CardNoLabel.Location = New System.Drawing.Point(5, 5)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(74, 18)
        CardNoLabel.TabIndex = 31
        CardNoLabel.Text = "Card No:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel
        '
        NameLabel.Location = New System.Drawing.Point(5, 30)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(74, 18)
        NameLabel.TabIndex = 32
        NameLabel.Text = "Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        DesigNameLabel.Location = New System.Drawing.Point(5, 101)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(74, 18)
        DesigNameLabel.TabIndex = 34
        DesigNameLabel.Text = "Designation:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PercentOfSalaryLabel
        '
        PercentOfSalaryLabel.Location = New System.Drawing.Point(5, 80)
        PercentOfSalaryLabel.Name = "PercentOfSalaryLabel"
        PercentOfSalaryLabel.Size = New System.Drawing.Size(106, 20)
        PercentOfSalaryLabel.TabIndex = 22
        PercentOfSalaryLabel.Text = "Percent Of Salary:"
        PercentOfSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActivationStatusLabel
        '
        ActivationStatusLabel.Location = New System.Drawing.Point(232, 32)
        ActivationStatusLabel.Name = "ActivationStatusLabel"
        ActivationStatusLabel.Size = New System.Drawing.Size(82, 20)
        ActivationStatusLabel.TabIndex = 17
        ActivationStatusLabel.Text = "Bonus Status:"
        ActivationStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BonusNoLabel
        '
        BonusNoLabel.Location = New System.Drawing.Point(5, 56)
        BonusNoLabel.Name = "BonusNoLabel"
        BonusNoLabel.Size = New System.Drawing.Size(90, 20)
        BonusNoLabel.TabIndex = 18
        BonusNoLabel.Text = "Bonus No:"
        BonusNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FinancialPeriodLabel
        '
        FinancialPeriodLabel.Location = New System.Drawing.Point(5, 32)
        FinancialPeriodLabel.Name = "FinancialPeriodLabel"
        FinancialPeriodLabel.Size = New System.Drawing.Size(99, 20)
        FinancialPeriodLabel.TabIndex = 15
        FinancialPeriodLabel.Text = "Financial Period:"
        FinancialPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(7, 41)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(102, 20)
        Label3.TabIndex = 14
        Label3.Text = "Financial Period:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.ForeColor = System.Drawing.Color.Maroon
        Label4.Location = New System.Drawing.Point(290, 39)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(75, 23)
        Label4.TabIndex = 13
        Label4.Text = "% Of Salary:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmploymentTypeLabel
        '
        EmploymentTypeLabel.Location = New System.Drawing.Point(5, 107)
        EmploymentTypeLabel.Name = "EmploymentTypeLabel"
        EmploymentTypeLabel.Size = New System.Drawing.Size(117, 20)
        EmploymentTypeLabel.TabIndex = 40
        EmploymentTypeLabel.Text = "Select Employment Type:"
        EmploymentTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(5, 53)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(74, 18)
        Label7.TabIndex = 39
        Label7.Text = "Dept Name:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1196, 39)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Bonus Calculation"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Location = New System.Drawing.Point(1, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 59)
        Me.Panel3.TabIndex = 16
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(2, 30)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(154, 22)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Bonus Transactions"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(2, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(154, 22)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Define Bonus"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(163, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(887, 651)
        Me.Panel2.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(880, 651)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.StatusStrip1)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Controls.Add(Me.Panel8)
        Me.TabPage1.Location = New System.Drawing.Point(24, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(852, 643)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Define Bonus"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 618)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(846, 22)
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 16)
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Label3)
        Me.Panel5.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Panel5.Controls.Add(Me.BindingNavigator2)
        Me.Panel5.Controls.Add(Label4)
        Me.Panel5.Controls.Add(Me.ComboBox1)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Location = New System.Drawing.Point(3, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(578, 84)
        Me.Panel5.TabIndex = 7
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(109, 41)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(159, 23)
        Me.FinancialPeriodComboBox.TabIndex = 1
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSBonus
        '
        'DSBonus
        '
        Me.DSBonus.DataSetName = "DSBonus"
        Me.DSBonus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator2.BindingSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(576, 27)
        Me.BindingNavigator2.TabIndex = 14
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"100", "90", "80", "75", "50", "25"})
        Me.ComboBox1.Location = New System.Drawing.Point(368, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(85, 23)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "100"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(466, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add New Bonus"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Controls.Add(Me.Tbl_Acc_BonusNoSettingsDataGridView)
        Me.Panel8.Controls.Add(Me.BindingNavigator1)
        Me.Panel8.Location = New System.Drawing.Point(3, 91)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(578, 274)
        Me.Panel8.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(3, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(570, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "List of already defined bonuses for the selected financial period"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_BonusNoSettingsDataGridView
        '
        Me.Tbl_Acc_BonusNoSettingsDataGridView.AllowUserToAddRows = False
        Me.Tbl_Acc_BonusNoSettingsDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Acc_BonusNoSettingsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Acc_BonusNoSettingsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Acc_BonusNoSettingsDataGridView.ColumnHeadersHeight = 46
        Me.Tbl_Acc_BonusNoSettingsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.PercentOfSalary, Me.DataGridViewTextBoxColumn3, Me.ActivationStatus})
        Me.Tbl_Acc_BonusNoSettingsDataGridView.DataSource = Me.Tbl_Acc_BonusNoSettingsBindingSource
        Me.Tbl_Acc_BonusNoSettingsDataGridView.Location = New System.Drawing.Point(2, 49)
        Me.Tbl_Acc_BonusNoSettingsDataGridView.Name = "Tbl_Acc_BonusNoSettingsDataGridView"
        Me.Tbl_Acc_BonusNoSettingsDataGridView.RowHeadersWidth = 22
        Me.Tbl_Acc_BonusNoSettingsDataGridView.Size = New System.Drawing.Size(571, 221)
        Me.Tbl_Acc_BonusNoSettingsDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "FinancialPeriod"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Financial Period"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 140
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BonusNo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bonus No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'PercentOfSalary
        '
        Me.PercentOfSalary.DataPropertyName = "PercentOfSalary"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PercentOfSalary.DefaultCellStyle = DataGridViewCellStyle4
        Me.PercentOfSalary.HeaderText = "Percent Of Salary"
        Me.PercentOfSalary.Name = "PercentOfSalary"
        Me.PercentOfSalary.ReadOnly = True
        Me.PercentOfSalary.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TransactionDate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Transaction Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'ActivationStatus
        '
        Me.ActivationStatus.DataPropertyName = "ActivationStatus"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.NullValue = False
        Me.ActivationStatus.DefaultCellStyle = DataGridViewCellStyle6
        Me.ActivationStatus.HeaderText = "Calculation Status"
        Me.ActivationStatus.Name = "ActivationStatus"
        Me.ActivationStatus.ReadOnly = True
        Me.ActivationStatus.Width = 90
        '
        'Tbl_Acc_BonusNoSettingsBindingSource
        '
        Me.Tbl_Acc_BonusNoSettingsBindingSource.DataMember = "tbl_Acc_FinancialPeriod_tbl_Acc_BonusNoSettings"
        Me.Tbl_Acc_BonusNoSettingsBindingSource.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(576, 27)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        Me.BindingNavigatorAddNewItem1.Visible = False
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        Me.BindingNavigatorDeleteItem1.Visible = False
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.SaveToolStripButton.Text = "&Save"
        Me.SaveToolStripButton.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(24, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(852, 643)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bonus Transactions"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Controls.Add(Me.BindingNavigator3)
        Me.Panel7.Controls.Add(Me.Tbl_Acc_BonusTransactionsDataGridView)
        Me.Panel7.Location = New System.Drawing.Point(3, 172)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(842, 465)
        Me.Panel7.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(687, 1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Click to Pay Bonus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.BindingNavigator3.BindingSource = Me.Tbl_Acc_BonusTransactionsBindingSource
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator3.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem2, Me.BindingNavigatorDeleteItem2, Me.SaveToolStripButton1})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator3.Size = New System.Drawing.Size(840, 25)
        Me.BindingNavigator3.TabIndex = 4
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem2"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem2.Text = "Add new"
        Me.BindingNavigatorAddNewItem2.Visible = False
        '
        'Tbl_Acc_BonusTransactionsBindingSource
        '
        Me.Tbl_Acc_BonusTransactionsBindingSource.DataMember = "tbl_Acc_BonusNoSettings2_tbl_Acc_BonusTransactions"
        Me.Tbl_Acc_BonusTransactionsBindingSource.DataSource = Me.Tbl_Acc_BonusNoSettings2BindingSource
        '
        'Tbl_Acc_BonusNoSettings2BindingSource
        '
        Me.Tbl_Acc_BonusNoSettings2BindingSource.DataMember = "tbl_Acc_BonusNoSettings2"
        Me.Tbl_Acc_BonusNoSettings2BindingSource.DataSource = Me.DSBonus
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem2"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem2.Text = "Delete"
        Me.BindingNavigatorDeleteItem2.Visible = False
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton1
        '
        Me.SaveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton1.Image = CType(resources.GetObject("SaveToolStripButton1.Image"), System.Drawing.Image)
        Me.SaveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton1.Name = "SaveToolStripButton1"
        Me.SaveToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton1.Text = "&Save"
        Me.SaveToolStripButton1.Visible = False
        '
        'Tbl_Acc_BonusTransactionsDataGridView
        '
        Me.Tbl_Acc_BonusTransactionsDataGridView.AllowUserToAddRows = False
        Me.Tbl_Acc_BonusTransactionsDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Acc_BonusTransactionsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Tbl_Acc_BonusTransactionsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Acc_BonusTransactionsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Tbl_Acc_BonusTransactionsDataGridView.ColumnHeadersHeight = 46
        Me.Tbl_Acc_BonusTransactionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewComboBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.NoOfMonths, Me.GrossSalary, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.AmtDedAsLTA, Me.TransactionDate, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_Acc_BonusTransactionsDataGridView.DataSource = Me.Tbl_Acc_BonusTransactionsBindingSource
        Me.Tbl_Acc_BonusTransactionsDataGridView.Location = New System.Drawing.Point(0, 26)
        Me.Tbl_Acc_BonusTransactionsDataGridView.Name = "Tbl_Acc_BonusTransactionsDataGridView"
        Me.Tbl_Acc_BonusTransactionsDataGridView.Size = New System.Drawing.Size(837, 436)
        Me.Tbl_Acc_BonusTransactionsDataGridView.TabIndex = 3
        '
        'DataGridViewComboBoxColumn1
        '
        Me.DataGridViewComboBoxColumn1.DataPropertyName = "EmpID"
        Me.DataGridViewComboBoxColumn1.DataSource = Me.Tbl_Hrm_Emp_Info_H1BindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewComboBoxColumn1.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewComboBoxColumn1.DisplayMember = "CardNo"
        Me.DataGridViewComboBoxColumn1.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewComboBoxColumn1.HeaderText = "Card No"
        Me.DataGridViewComboBoxColumn1.Name = "DataGridViewComboBoxColumn1"
        Me.DataGridViewComboBoxColumn1.ReadOnly = True
        Me.DataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewComboBoxColumn1.ValueMember = "EmpID"
        Me.DataGridViewComboBoxColumn1.Width = 65
        '
        'Tbl_Hrm_Emp_Info_H1BindingSource
        '
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataMember = "tbl_Hrm_Emp_Info_H1"
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataSource = Me.HRMDBDataSet1
        '
        'HRMDBDataSet1
        '
        Me.HRMDBDataSet1.DataSetName = "HRMDBDataSet1"
        Me.HRMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FinancialPeriod"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn4.HeaderText = "Financial Period"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "BonusNo"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "Bonus No"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'NoOfMonths
        '
        Me.NoOfMonths.DataPropertyName = "NoOfMonths"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.NoOfMonths.DefaultCellStyle = DataGridViewCellStyle12
        Me.NoOfMonths.HeaderText = "No. Of Days"
        Me.NoOfMonths.Name = "NoOfMonths"
        Me.NoOfMonths.ReadOnly = True
        Me.NoOfMonths.Width = 60
        '
        'GrossSalary
        '
        Me.GrossSalary.DataPropertyName = "GrossSalary"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.GrossSalary.DefaultCellStyle = DataGridViewCellStyle13
        Me.GrossSalary.HeaderText = "Basic Salary"
        Me.GrossSalary.Name = "GrossSalary"
        Me.GrossSalary.ReadOnly = True
        Me.GrossSalary.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PercentOfSalary"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn6.HeaderText = "Percent Of Salary"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 65
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DueAmt"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn7.HeaderText = "Due Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'AmtDedAsLTA
        '
        Me.AmtDedAsLTA.DataPropertyName = "AmtDedAsLTA"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.AmtDedAsLTA.DefaultCellStyle = DataGridViewCellStyle16
        Me.AmtDedAsLTA.HeaderText = "Advance Amount"
        Me.AmtDedAsLTA.Name = "AmtDedAsLTA"
        Me.AmtDedAsLTA.ReadOnly = True
        Me.AmtDedAsLTA.Width = 70
        '
        'TransactionDate
        '
        Me.TransactionDate.DataPropertyName = "TransactionDate"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.Format = "d"
        Me.TransactionDate.DefaultCellStyle = DataGridViewCellStyle17
        Me.TransactionDate.HeaderText = "Transaction Date"
        Me.TransactionDate.Name = "TransactionDate"
        Me.TransactionDate.ReadOnly = True
        Me.TransactionDate.Width = 90
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "PaidUnpaidStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Paid Unpaid Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 90
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 168)
        Me.Panel1.TabIndex = 13
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Label7)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(DesigNameLabel)
        Me.Panel6.Controls.Add(Me.DesigNameLabel1)
        Me.Panel6.Controls.Add(Label1)
        Me.Panel6.Controls.Add(Me.EmpStatusCheckBox)
        Me.Panel6.Controls.Add(DeptNameLabel)
        Me.Panel6.Controls.Add(Me.DeptNameLabel1)
        Me.Panel6.Controls.Add(Me.NameLabel1)
        Me.Panel6.Controls.Add(Me.CardNoLabel1)
        Me.Panel6.Controls.Add(CardNoLabel)
        Me.Panel6.Controls.Add(NameLabel)
        Me.Panel6.Location = New System.Drawing.Point(345, 29)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(493, 134)
        Me.Panel6.TabIndex = 42
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.View_Rpt_Acc_AllEmployeesBindingSource, "EmpPic", True))
        Me.PictureBox1.Location = New System.Drawing.Point(342, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'View_Rpt_Acc_AllEmployeesBindingSource
        '
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataMember = "View_Rpt_Acc_AllEmployees"
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataSource = Me.HRMDBDataSet1
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DeptName", True))
        Me.Label9.Location = New System.Drawing.Point(82, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 20)
        Me.Label9.TabIndex = 40
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.Color.White
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DesigName", True))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(82, 99)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(244, 20)
        Me.DesigNameLabel1.TabIndex = 37
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpStatusCheckBox
        '
        Me.EmpStatusCheckBox.AutoCheck = False
        Me.EmpStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.View_Rpt_Acc_AllEmployeesBindingSource, "EmpStatus", True))
        Me.EmpStatusCheckBox.Location = New System.Drawing.Point(308, 8)
        Me.EmpStatusCheckBox.Name = "EmpStatusCheckBox"
        Me.EmpStatusCheckBox.Size = New System.Drawing.Size(17, 17)
        Me.EmpStatusCheckBox.TabIndex = 26
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "SectionName", True))
        Me.DeptNameLabel1.Location = New System.Drawing.Point(82, 75)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(244, 20)
        Me.DeptNameLabel1.TabIndex = 38
        Me.DeptNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel1
        '
        Me.NameLabel1.BackColor = System.Drawing.Color.White
        Me.NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(82, 28)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(244, 20)
        Me.NameLabel1.TabIndex = 35
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.BackColor = System.Drawing.Color.White
        Me.CardNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "CardNo", True))
        Me.CardNoLabel1.Location = New System.Drawing.Point(82, 5)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(60, 18)
        Me.CardNoLabel1.TabIndex = 33
        Me.CardNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.Controls.Add(EmploymentTypeLabel)
        Me.Panel4.Controls.Add(Me.EmploymentTypeComboBox)
        Me.Panel4.Controls.Add(Me.Tbl_Acc_BonusNoSettingsBindingNavigator)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(PercentOfSalaryLabel)
        Me.Panel4.Controls.Add(Me.PercentOfSalaryLabel1)
        Me.Panel4.Controls.Add(Me.ActivationStatusCheckBox)
        Me.Panel4.Controls.Add(ActivationStatusLabel)
        Me.Panel4.Controls.Add(Me.BonusNoLabel2)
        Me.Panel4.Controls.Add(Me.FinancialPeriodLabel2)
        Me.Panel4.Controls.Add(BonusNoLabel)
        Me.Panel4.Controls.Add(FinancialPeriodLabel)
        Me.Panel4.Location = New System.Drawing.Point(-1, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(346, 135)
        Me.Panel4.TabIndex = 41
        '
        'EmploymentTypeComboBox
        '
        Me.EmploymentTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmploymentTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmploymentTypeComboBox.DataSource = Me.Tbl_Hrm_EmploymentTypeBindingSource
        Me.EmploymentTypeComboBox.DisplayMember = "EmploymentType"
        Me.EmploymentTypeComboBox.FormattingEnabled = True
        Me.EmploymentTypeComboBox.Location = New System.Drawing.Point(124, 104)
        Me.EmploymentTypeComboBox.Name = "EmploymentTypeComboBox"
        Me.EmploymentTypeComboBox.Size = New System.Drawing.Size(198, 23)
        Me.EmploymentTypeComboBox.TabIndex = 39
        Me.EmploymentTypeComboBox.ValueMember = "ETID"
        '
        'Tbl_Hrm_EmploymentTypeBindingSource
        '
        Me.Tbl_Hrm_EmploymentTypeBindingSource.DataMember = "tbl_Hrm_EmploymentType"
        Me.Tbl_Hrm_EmploymentTypeBindingSource.DataSource = Me.DSBonus
        '
        'Tbl_Acc_BonusNoSettingsBindingNavigator
        '
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.BindingSource = Me.Tbl_Acc_BonusNoSettings2BindingSource
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.DeleteItem = Me.ToolStripButton2
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem})
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.Name = "Tbl_Acc_BonusNoSettingsBindingNavigator"
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.Size = New System.Drawing.Size(346, 27)
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.TabIndex = 25
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton1.Text = "Add new"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 24)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton2.Text = "Delete"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem
        '
        Me.Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem.Name = "Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem"
        Me.Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem.Text = "Save Data"
        Me.Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(236, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Save Transactions"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PercentOfSalaryLabel1
        '
        Me.PercentOfSalaryLabel1.BackColor = System.Drawing.Color.White
        Me.PercentOfSalaryLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PercentOfSalaryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_BonusNoSettings2BindingSource, "PercentOfSalary", True))
        Me.PercentOfSalaryLabel1.Location = New System.Drawing.Point(122, 80)
        Me.PercentOfSalaryLabel1.Name = "PercentOfSalaryLabel1"
        Me.PercentOfSalaryLabel1.Size = New System.Drawing.Size(106, 20)
        Me.PercentOfSalaryLabel1.TabIndex = 24
        Me.PercentOfSalaryLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActivationStatusCheckBox
        '
        Me.ActivationStatusCheckBox.AutoCheck = False
        Me.ActivationStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Acc_BonusNoSettings2BindingSource, "ActivationStatus", True))
        Me.ActivationStatusCheckBox.Location = New System.Drawing.Point(317, 32)
        Me.ActivationStatusCheckBox.Name = "ActivationStatusCheckBox"
        Me.ActivationStatusCheckBox.Size = New System.Drawing.Size(19, 20)
        Me.ActivationStatusCheckBox.TabIndex = 20
        '
        'BonusNoLabel2
        '
        Me.BonusNoLabel2.BackColor = System.Drawing.Color.White
        Me.BonusNoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BonusNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_BonusNoSettings2BindingSource, "BonusNo", True))
        Me.BonusNoLabel2.Location = New System.Drawing.Point(101, 56)
        Me.BonusNoLabel2.Name = "BonusNoLabel2"
        Me.BonusNoLabel2.Size = New System.Drawing.Size(127, 20)
        Me.BonusNoLabel2.TabIndex = 23
        Me.BonusNoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FinancialPeriodLabel2
        '
        Me.FinancialPeriodLabel2.BackColor = System.Drawing.Color.White
        Me.FinancialPeriodLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FinancialPeriodLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_BonusNoSettings2BindingSource, "FinancialPeriod", True))
        Me.FinancialPeriodLabel2.Location = New System.Drawing.Point(101, 32)
        Me.FinancialPeriodLabel2.Name = "FinancialPeriodLabel2"
        Me.FinancialPeriodLabel2.Size = New System.Drawing.Size(127, 20)
        Me.FinancialPeriodLabel2.TabIndex = 21
        Me.FinancialPeriodLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(841, 25)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Select Appropriate Option to Filter Records"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(777, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_BonusDistributionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_BonusNoSettings1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_BonusNoSettings2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_BonusNoSettingsTableAdapter = Me.Tbl_Acc_BonusNoSettingsTableAdapter
        Me.TableAdapterManager.tbl_Acc_BonusNoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_BonusTransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Me.Tbl_Acc_FinancialPeriodTableAdapter
        Me.TableAdapterManager.tbl_Hrm_EmploymentTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSBonusTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Acc_BonusNoSettingsTableAdapter
        '
        Me.Tbl_Acc_BonusNoSettingsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_BonusTransactionsTableAdapter
        '
        Me.Tbl_Acc_BonusTransactionsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_H1TableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_BranchTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_CardTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_GradesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.HRMDBDataset1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_Rpt_Acc_AllEmployeesTableAdapter
        '
        Me.View_Rpt_Acc_AllEmployeesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_EmploymentTypeTableAdapter
        '
        Me.Tbl_Hrm_EmploymentTypeTableAdapter.ClearBeforeFill = True
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
        'View_Rpt_Acc_EmpList4BonusTransactionsBindingSource
        '
        Me.View_Rpt_Acc_EmpList4BonusTransactionsBindingSource.DataMember = "View_Rpt_Acc_EmpList4BonusTransactions"
        Me.View_Rpt_Acc_EmpList4BonusTransactionsBindingSource.DataSource = Me.DSBonus
        '
        'View_Rpt_Acc_EmpList4BonusTransactionsTableAdapter
        '
        Me.View_Rpt_Acc_EmpList4BonusTransactionsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_BonusNoSettings2TableAdapter1
        '
        Me.Tbl_Acc_BonusNoSettings2TableAdapter1.ClearBeforeFill = True
        '
        'DSLongTermAdv
        '
        Me.DSLongTermAdv.DataSetName = "DSLongTermAdv"
        Me.DSLongTermAdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.tbl_Acc_PAdvDeductionsTableAdapter = Me.Tbl_Acc_PAdvDeductionsTableAdapter
        Me.TableAdapterManager2.tbl_Acc_PermanentAdvancesTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Fin_DebitCredit_Entry1TableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Fin_DebitCredit_EntryTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Fin_Journal_HeadTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Fin_Layer4TableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.DSLongTermAdvTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StatusStrip2
        '
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar2})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 700)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1196, 36)
        Me.StatusStrip2.TabIndex = 101
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripProgressBar2.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(990, 30)
        Me.ToolStripProgressBar2.Step = 1
        '
        'frmBonus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 736)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Name = "frmBonus"
        Me.Text = "Bonus Transactions"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBonus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.Tbl_Acc_BonusNoSettingsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_BonusNoSettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.Tbl_Acc_BonusTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_BonusNoSettings2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_BonusTransactionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Tbl_Hrm_EmploymentTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_BonusNoSettingsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.ResumeLayout(False)
        Me.Tbl_Acc_BonusNoSettingsBindingNavigator.PerformLayout()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_EmpList4BonusTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSLongTermAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents EmpStatusCheckBox As CheckBox
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents CardNoLabel1 As Label
    Friend WithEvents DeptNameLabel1 As Label
    Friend WithEvents DesigNameLabel1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents PercentOfSalaryLabel1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ActivationStatusCheckBox As CheckBox
    Friend WithEvents BonusNoLabel2 As Label
    Friend WithEvents FinancialPeriodLabel2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DSBonus As DSBonus
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSBonusTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents TableAdapterManager As DSBonusTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Acc_BonusNoSettingsTableAdapter As DSBonusTableAdapters.tbl_Acc_BonusNoSettingsTableAdapter
    Friend WithEvents Tbl_Acc_BonusNoSettingsBindingSource As BindingSource
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FinancialPeriodComboBox As ComboBox
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Tbl_Acc_BonusNoSettingsDataGridView As DataGridView
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents Tbl_Acc_BonusNoSettings2BindingSource As BindingSource
    Friend WithEvents Tbl_Acc_BonusNoSettings2TableAdapter As DSBonusTableAdapters.tbl_Acc_BonusNoSettings1TableAdapter
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents FinancialPeriodToolStripLabel As ToolStripLabel
    Friend WithEvents FinancialPeriodToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents Tbl_Acc_BonusNoSettingsBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents Tbl_Acc_BonusNoSettingsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_Acc_BonusTransactionsBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_BonusTransactionsTableAdapter As DSBonusTableAdapters.tbl_Acc_BonusTransactionsTableAdapter
    Friend WithEvents HRMDBDataSet1 As HRMDBDataset1
    Friend WithEvents Tbl_Hrm_Emp_Info_H1BindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_H1TableAdapter As HRMDBDataset1TableAdapters.tbl_Hrm_Emp_Info_H1TableAdapter
    Friend WithEvents TableAdapterManager1 As HRMDBDataset1TableAdapters.TableAdapterManager
    Friend WithEvents View_Rpt_Acc_AllEmployeesBindingSource As BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployeesTableAdapter As HRMDBDataset1TableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter
    Friend WithEvents Tbl_Hrm_EmploymentTypeBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_EmploymentTypeTableAdapter As DSBonusTableAdapters.tbl_Hrm_EmploymentTypeTableAdapter
    Friend WithEvents Label9 As Label
    Friend WithEvents EmploymentTypeComboBox As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Tbl_Acc_BonusTransactionsDataGridView As DataGridView
    Friend WithEvents View_Rpt_Acc_PreSalaryBindingSource As BindingSource
    Friend WithEvents View_Rpt_Acc_PreSalaryTableAdapter As HRMDBDataset1TableAdapters.View_Rpt_Acc_PreSalaryTableAdapter
    Friend WithEvents View_Rpt_Acc_EmpList4BonusTransactionsBindingSource As BindingSource
    Friend WithEvents View_Rpt_Acc_EmpList4BonusTransactionsTableAdapter As DSBonusTableAdapters.View_Rpt_Acc_EmpList4BonusTransactionsTableAdapter
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Tbl_Acc_BonusNoSettings2TableAdapter1 As DSBonusTableAdapters.tbl_Acc_BonusNoSettings2TableAdapter
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As ToolStripSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents SaveToolStripButton1 As ToolStripButton
    Friend WithEvents DSLongTermAdv As DSLongTermAdv
    Friend WithEvents Tbl_Acc_PAdvDeductionsBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_PAdvDeductionsTableAdapter As DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductionsTableAdapter
    Friend WithEvents TableAdapterManager2 As DSLongTermAdvTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PercentOfSalary As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ActivationStatus As DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents ToolStripProgressBar2 As ToolStripProgressBar
    Friend WithEvents DataGridViewComboBoxColumn1 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents NoOfMonths As DataGridViewTextBoxColumn
    Friend WithEvents GrossSalary As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents AmtDedAsLTA As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
