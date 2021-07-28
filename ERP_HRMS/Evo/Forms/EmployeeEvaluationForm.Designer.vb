<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeEvaluationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FNameLabel As System.Windows.Forms.Label
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim DateOfJoiningLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim LateComingLabel As System.Windows.Forms.Label
        Dim AbsentLabel As System.Windows.Forms.Label
        Dim WarningNoticesLabel As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeEvaluationForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSEmpEval = New ERP_HRMS.DSEmpEval()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.ComboBox18 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_EmpEvalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.ComboBox19 = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.ComboBox20 = New System.Windows.Forms.ComboBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.ComboBox21 = New System.Windows.Forms.ComboBox()
        Me.ComboBox22 = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.View_EmpEval_Self_AssessmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.ESADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyObjectivesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EffectiveDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AchievedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CardLabel = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_PreSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.SubDept2Label1 = New System.Windows.Forms.Label()
        Me.DateOfJoiningLabel1 = New System.Windows.Forms.Label()
        Me.FatherNameLabel1 = New System.Windows.Forms.Label()
        Me.FNameLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.WarningNoticesLabel1 = New System.Windows.Forms.Label()
        Me.AbsentLabel1 = New System.Windows.Forms.Label()
        Me.LateComingLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ComboBox15 = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ComboBox14 = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox9 = New System.Windows.Forms.ComboBox()
        Me.ComboBox10 = New System.Windows.Forms.ComboBox()
        Me.ComboBox12 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.ComboBox17 = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ComboBox16 = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.ComboBox13 = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ComboBox8 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CardNo1 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_InfoTableAdapter = New ERP_HRMS.DSEmpEvalTableAdapters.tbl_Hrm_Emp_InfoTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSEmpEvalTableAdapters.TableAdapterManager()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSEmpEvalTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_Hrm_Emp_Info_NoticesTableAdapter = New ERP_HRMS.DSEmpEvalTableAdapters.tbl_Hrm_Emp_Info_NoticesTableAdapter()
        Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter = New ERP_HRMS.DSEmpEvalTableAdapters.tbl_Hrm_EmpEval_Self_AssessmentTableAdapter()
        Me.Tbl_Hrm_EmpEvalTableAdapter = New ERP_HRMS.DSEmpEvalTableAdapters.tbl_Hrm_EmpEvalTableAdapter()
        Me.Tbl_Acc_Salary_TransactionsTableAdapter = New ERP_HRMS.DSEmpEvalTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter()
        Me.Tbl_Acc_Salary_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_NoticesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSEmpEvalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_PreSalaryTableAdapter = New ERP_HRMS.DSEmpEvalTableAdapters.View_Rpt_Acc_PreSalaryTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label74 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        FNameLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        DateOfJoiningLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        LateComingLabel = New System.Windows.Forms.Label()
        AbsentLabel = New System.Windows.Forms.Label()
        WarningNoticesLabel = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSEmpEval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Tbl_Hrm_EmpEvalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_EmpEval_Self_AssessmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_NoticesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSEmpEvalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FNameLabel
        '
        FNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        FNameLabel.ForeColor = System.Drawing.Color.Black
        FNameLabel.Location = New System.Drawing.Point(363, 16)
        FNameLabel.Name = "FNameLabel"
        FNameLabel.Size = New System.Drawing.Size(91, 23)
        FNameLabel.TabIndex = 4
        FNameLabel.Text = "Employee Name:"
        FNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FatherNameLabel
        '
        FatherNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        FatherNameLabel.ForeColor = System.Drawing.Color.Black
        FatherNameLabel.Location = New System.Drawing.Point(696, 16)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(91, 23)
        FatherNameLabel.TabIndex = 5
        FatherNameLabel.Text = "Father Name:"
        FatherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfJoiningLabel
        '
        DateOfJoiningLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DateOfJoiningLabel.ForeColor = System.Drawing.Color.Black
        DateOfJoiningLabel.Location = New System.Drawing.Point(696, 45)
        DateOfJoiningLabel.Name = "DateOfJoiningLabel"
        DateOfJoiningLabel.Size = New System.Drawing.Size(91, 23)
        DateOfJoiningLabel.TabIndex = 6
        DateOfJoiningLabel.Text = "Date Of Joining:"
        DateOfJoiningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        DesigNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DesigNameLabel.ForeColor = System.Drawing.Color.Black
        DesigNameLabel.Location = New System.Drawing.Point(363, 45)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(91, 23)
        DesigNameLabel.TabIndex = 10
        DesigNameLabel.Text = "Desig Name:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LateComingLabel
        '
        LateComingLabel.ForeColor = System.Drawing.Color.Black
        LateComingLabel.Location = New System.Drawing.Point(10, 22)
        LateComingLabel.Name = "LateComingLabel"
        LateComingLabel.Size = New System.Drawing.Size(265, 19)
        LateComingLabel.TabIndex = 0
        LateComingLabel.Text = "Late Coming :"
        LateComingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AbsentLabel
        '
        AbsentLabel.ForeColor = System.Drawing.Color.Black
        AbsentLabel.Location = New System.Drawing.Point(10, 49)
        AbsentLabel.Name = "AbsentLabel"
        AbsentLabel.Size = New System.Drawing.Size(265, 19)
        AbsentLabel.TabIndex = 4
        AbsentLabel.Text = "Absent/Leaves:"
        AbsentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WarningNoticesLabel
        '
        WarningNoticesLabel.ForeColor = System.Drawing.Color.Black
        WarningNoticesLabel.Location = New System.Drawing.Point(9, 79)
        WarningNoticesLabel.Name = "WarningNoticesLabel"
        WarningNoticesLabel.Size = New System.Drawing.Size(266, 19)
        WarningNoticesLabel.TabIndex = 6
        WarningNoticesLabel.Text = "Warning Notices :"
        '
        'Label29
        '
        Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label29.ForeColor = System.Drawing.Color.Black
        Label29.Location = New System.Drawing.Point(14, 16)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(91, 23)
        Label29.TabIndex = 6
        Label29.Text = "Employee No:"
        Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cardNoComboBox)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Controls.Add(Me.cmbMonth)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(34, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(631, 88)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(233, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Employee:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Ivory
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "FName", True))
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(310, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Hrm_Emp_InfoBindingSource
        '
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataMember = "tbl_Hrm_Emp_Info"
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataSource = Me.DSEmpEval
        '
        'DSEmpEval
        '
        Me.DSEmpEval.DataSetName = "DSEmpEval"
        Me.DSEmpEval.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(428, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Card No:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cardNoComboBox
        '
        Me.cardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cardNoComboBox.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        Me.cardNoComboBox.DisplayMember = "CardNo"
        Me.cardNoComboBox.Enabled = False
        Me.cardNoComboBox.FormattingEnabled = True
        Me.cardNoComboBox.Location = New System.Drawing.Point(511, 60)
        Me.cardNoComboBox.Name = "cardNoComboBox"
        Me.cardNoComboBox.Size = New System.Drawing.Size(103, 21)
        Me.cardNoComboBox.TabIndex = 45
        Me.cardNoComboBox.ValueMember = "EmpID"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(15, 65)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(161, 17)
        Me.CheckBox2.TabIndex = 44
        Me.CheckBox2.Text = "Filter by Month and Card No:"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(233, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Select Year:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(428, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 20)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Select Month:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbYear
        '
        Me.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(310, 34)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(103, 21)
        Me.cmbYear.TabIndex = 37
        Me.cmbYear.TabStop = False
        '
        'cmbMonth
        '
        Me.cmbMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "Feburary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(511, 33)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(102, 21)
        Me.cmbMonth.TabIndex = 36
        Me.cmbMonth.TabStop = False
        '
        'Label34
        '
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Location = New System.Drawing.Point(11, 34)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(87, 20)
        Me.Label34.TabIndex = 34
        Me.Label34.Text = "Financial Period:"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinancialPeriodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(106, 34)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FinancialPeriodComboBox.TabIndex = 33
        Me.FinancialPeriodComboBox.TabStop = False
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSEmpEval
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(629, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Select Appropriate Option to Filter Records"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(33, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1054, 632)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(224, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 25)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Save Record"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(805, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 25)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Submit"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(924, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "View Result"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox7)
        Me.Panel3.Controls.Add(Me.GroupBox6)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.GroupBox5)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Location = New System.Drawing.Point(12, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1026, 586)
        Me.Panel3.TabIndex = 4
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label68)
        Me.GroupBox7.Controls.Add(Me.Label69)
        Me.GroupBox7.Controls.Add(Me.Label66)
        Me.GroupBox7.Controls.Add(Me.Label67)
        Me.GroupBox7.Controls.Add(Me.Label64)
        Me.GroupBox7.Controls.Add(Me.Label65)
        Me.GroupBox7.Controls.Add(Me.Label62)
        Me.GroupBox7.Controls.Add(Me.Label63)
        Me.GroupBox7.Controls.Add(Me.Label61)
        Me.GroupBox7.Controls.Add(Me.Label60)
        Me.GroupBox7.Controls.Add(Me.Label59)
        Me.GroupBox7.Controls.Add(Me.Label58)
        Me.GroupBox7.Controls.Add(Me.Label57)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox7.Location = New System.Drawing.Point(707, 240)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(310, 159)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Note"
        '
        'Label68
        '
        Me.Label68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(159, 134)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(128, 18)
        Me.Label68.TabIndex = 15
        Me.Label68.Text = "Conditional to reports "
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label69
        '
        Me.Label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(15, 134)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(145, 18)
        Me.Label69.TabIndex = 14
        Me.Label69.Text = "4.     Severely bad health"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label66
        '
        Me.Label66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(159, 117)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(128, 18)
        Me.Label66.TabIndex = 13
        Me.Label66.Text = "15 days"
        Me.Label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label67
        '
        Me.Label67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(15, 117)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(145, 18)
        Me.Label67.TabIndex = 12
        Me.Label67.Text = "3.     Umrah"
        Me.Label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label64
        '
        Me.Label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(159, 100)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(128, 18)
        Me.Label64.TabIndex = 11
        Me.Label64.Text = "4 Days"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label65
        '
        Me.Label65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(15, 100)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(145, 18)
        Me.Label65.TabIndex = 10
        Me.Label65.Text = "2.     Death of Blood Relation"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label62
        '
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(159, 85)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(128, 16)
        Me.Label62.TabIndex = 9
        Me.Label62.Text = "6 Days"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label63
        '
        Me.Label63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(15, 85)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(145, 16)
        Me.Label63.TabIndex = 8
        Me.Label63.Text = "1.     Own Marriage"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label61
        '
        Me.Label61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(159, 67)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(128, 19)
        Me.Label61.TabIndex = 7
        Me.Label61.Text = "No. of Days"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label60
        '
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(15, 67)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(145, 19)
        Me.Label60.TabIndex = 6
        Me.Label60.Text = "Reason"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label59
        '
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(12, 40)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(288, 26)
        Me.Label59.TabIndex = 5
        Me.Label59.Text = "2.     Special leaves* will be awarded for following exceptional cases: "
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(13, 27)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(274, 12)
        Me.Label58.TabIndex = 4
        Me.Label58.Text = "a) Full Attendance: 6     b) No late comings: 2     c) EAP Trainings: 5"
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(12, 13)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(290, 14)
        Me.Label57.TabIndex = 0
        Me.Label57.Text = "1.     Bonus marks to be awarded annually: "
        '
        'GroupBox6
        '
        Me.GroupBox6.AccessibleDescription = ""
        Me.GroupBox6.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.GroupBox6.Controls.Add(Me.Label73)
        Me.GroupBox6.Controls.Add(Me.Label46)
        Me.GroupBox6.Controls.Add(Me.ComboBox18)
        Me.GroupBox6.Controls.Add(Me.Label47)
        Me.GroupBox6.Controls.Add(Me.Label48)
        Me.GroupBox6.Controls.Add(Me.TextBox4)
        Me.GroupBox6.Controls.Add(Me.Label49)
        Me.GroupBox6.Controls.Add(Me.Label50)
        Me.GroupBox6.Controls.Add(Me.Label51)
        Me.GroupBox6.Controls.Add(Me.Label52)
        Me.GroupBox6.Controls.Add(Me.Label53)
        Me.GroupBox6.Controls.Add(Me.ComboBox19)
        Me.GroupBox6.Controls.Add(Me.Label54)
        Me.GroupBox6.Controls.Add(Me.Label55)
        Me.GroupBox6.Controls.Add(Me.ComboBox20)
        Me.GroupBox6.Controls.Add(Me.Label56)
        Me.GroupBox6.Controls.Add(Me.ComboBox21)
        Me.GroupBox6.Controls.Add(Me.ComboBox22)
        Me.GroupBox6.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox6.Enabled = False
        Me.GroupBox6.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox6.Location = New System.Drawing.Point(706, 79)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(310, 159)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Supervisory skills"
        Me.ToolTip1.SetToolTip(Me.GroupBox6, resources.GetString("GroupBox6.ToolTip"))
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Maroon
        Me.Label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Yellow
        Me.Label73.Location = New System.Drawing.Point(264, 133)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(37, 19)
        Me.Label73.TabIndex = 26
        Me.Label73.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label46
        '
        Me.Label46.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(10, 109)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(166, 19)
        Me.Label46.TabIndex = 25
        Me.Label46.Text = "5- Team Management"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label46, resources.GetString("Label46.ToolTip"))
        '
        'ComboBox18
        '
        Me.ComboBox18.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox18.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "SupervisorySkills4", True))
        Me.ComboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox18.FormattingEnabled = True
        Me.ComboBox18.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox18.Location = New System.Drawing.Point(181, 109)
        Me.ComboBox18.Name = "ComboBox18"
        Me.ComboBox18.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox18.TabIndex = 23
        '
        'Tbl_Hrm_EmpEvalBindingSource
        '
        Me.Tbl_Hrm_EmpEvalBindingSource.DataMember = "tbl_Hrm_EmpEval"
        Me.Tbl_Hrm_EmpEvalBindingSource.DataSource = Me.DSEmpEval
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.White
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label47.Location = New System.Drawing.Point(264, 109)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(37, 19)
        Me.Label47.TabIndex = 24
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(10, 133)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(49, 19)
        Me.Label48.TabIndex = 22
        Me.Label48.Text = "Remarks"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "SupervisorySkillsRemark", True))
        Me.TextBox4.Location = New System.Drawing.Point(64, 133)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(196, 20)
        Me.TextBox4.TabIndex = 21
        '
        'Label49
        '
        Me.Label49.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(10, 85)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(166, 19)
        Me.Label49.TabIndex = 20
        Me.Label49.Text = "4-Supervising Staff Relations"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label49, resources.GetString("Label49.ToolTip"))
        '
        'Label50
        '
        Me.Label50.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(10, 62)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(166, 19)
        Me.Label50.TabIndex = 19
        Me.Label50.Text = "3-Delegation and Leadership skills"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label50, resources.GetString("Label50.ToolTip"))
        '
        'Label51
        '
        Me.Label51.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(10, 38)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(166, 19)
        Me.Label51.TabIndex = 18
        Me.Label51.Text = "2-Development of Subordinates"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label51, resources.GetString("Label51.ToolTip"))
        '
        'Label52
        '
        Me.Label52.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(10, 15)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(166, 19)
        Me.Label52.TabIndex = 17
        Me.Label52.Text = "1-Performance Appraisals"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label52, "Performance Appraisals" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "·" & Global.Microsoft.VisualBasic.ChrW(9) & "Provides informal performance feedback on a regular bas" &
        "is" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "·" & Global.Microsoft.VisualBasic.ChrW(9) & "Acknowledges good performance and discusses performance problems" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "·" & Global.Microsoft.VisualBasic.ChrW(9) & "Prepar" &
        "es precise written annual evaluations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.White
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label53.Location = New System.Drawing.Point(264, 15)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(37, 19)
        Me.Label53.TabIndex = 16
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox19
        '
        Me.ComboBox19.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox19.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "SupervisorySkills3", True))
        Me.ComboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox19.FormattingEnabled = True
        Me.ComboBox19.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox19.Location = New System.Drawing.Point(181, 85)
        Me.ComboBox19.Name = "ComboBox19"
        Me.ComboBox19.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox19.TabIndex = 3
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.White
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Location = New System.Drawing.Point(264, 38)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(37, 19)
        Me.Label54.TabIndex = 15
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.White
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label55.Location = New System.Drawing.Point(264, 62)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(37, 19)
        Me.Label55.TabIndex = 14
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox20
        '
        Me.ComboBox20.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox20.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "SupervisorySkills1", True))
        Me.ComboBox20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox20.FormattingEnabled = True
        Me.ComboBox20.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox20.Location = New System.Drawing.Point(181, 38)
        Me.ComboBox20.Name = "ComboBox20"
        Me.ComboBox20.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox20.TabIndex = 1
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.White
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Location = New System.Drawing.Point(264, 85)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(37, 19)
        Me.Label56.TabIndex = 13
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox21
        '
        Me.ComboBox21.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox21.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "SupervisorySkills", True))
        Me.ComboBox21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox21.FormattingEnabled = True
        Me.ComboBox21.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox21.Location = New System.Drawing.Point(181, 15)
        Me.ComboBox21.Name = "ComboBox21"
        Me.ComboBox21.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox21.TabIndex = 0
        '
        'ComboBox22
        '
        Me.ComboBox22.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox22.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "SupervisorySkills2", True))
        Me.ComboBox22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox22.FormattingEnabled = True
        Me.ComboBox22.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox22.Location = New System.Drawing.Point(181, 62)
        Me.ComboBox22.Name = "ComboBox22"
        Me.ComboBox22.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox22.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BindingNavigator2)
        Me.Panel4.Controls.Add(Me.View_EmpEval_Self_AssessmentDataGridView)
        Me.Panel4.Location = New System.Drawing.Point(14, 408)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1007, 170)
        Me.Panel4.TabIndex = 6
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Nothing
        Me.BindingNavigator2.BindingSource = Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Nothing
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(1005, 25)
        Me.BindingNavigator2.TabIndex = 1
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'Tbl_Hrm_EmpEval_Self_AssessmentBindingSource
        '
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource.DataMember = "tbl_Hrm_EmpEval_tbl_Hrm_EmpEval_Self_Assessment"
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource.DataSource = Me.Tbl_Hrm_EmpEvalBindingSource
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'View_EmpEval_Self_AssessmentDataGridView
        '
        Me.View_EmpEval_Self_AssessmentDataGridView.AllowUserToAddRows = False
        Me.View_EmpEval_Self_AssessmentDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.View_EmpEval_Self_AssessmentDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.View_EmpEval_Self_AssessmentDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_EmpEval_Self_AssessmentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.View_EmpEval_Self_AssessmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_EmpEval_Self_AssessmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ESADataGridViewTextBoxColumn, Me.EmpIDDataGridViewTextBoxColumn, Me.MonthlyObjectivesDataGridViewTextBoxColumn, Me.PStatusDataGridViewTextBoxColumn, Me.ReasonDataGridViewTextBoxColumn, Me.EffectiveDateDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn, Me.EndTimeDataGridViewTextBoxColumn, Me.AchievedDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn})
        Me.View_EmpEval_Self_AssessmentDataGridView.DataSource = Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource
        Me.View_EmpEval_Self_AssessmentDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.View_EmpEval_Self_AssessmentDataGridView.Name = "View_EmpEval_Self_AssessmentDataGridView"
        Me.View_EmpEval_Self_AssessmentDataGridView.ReadOnly = True
        Me.View_EmpEval_Self_AssessmentDataGridView.Size = New System.Drawing.Size(996, 136)
        Me.View_EmpEval_Self_AssessmentDataGridView.TabIndex = 0
        '
        'ESADataGridViewTextBoxColumn
        '
        Me.ESADataGridViewTextBoxColumn.DataPropertyName = "ESA"
        Me.ESADataGridViewTextBoxColumn.HeaderText = "Sr. No."
        Me.ESADataGridViewTextBoxColumn.Name = "ESADataGridViewTextBoxColumn"
        Me.ESADataGridViewTextBoxColumn.ReadOnly = True
        Me.ESADataGridViewTextBoxColumn.Width = 40
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "EmpID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        Me.EmpIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmpIDDataGridViewTextBoxColumn.Visible = False
        '
        'MonthlyObjectivesDataGridViewTextBoxColumn
        '
        Me.MonthlyObjectivesDataGridViewTextBoxColumn.DataPropertyName = "MonthlyObjectives"
        Me.MonthlyObjectivesDataGridViewTextBoxColumn.HeaderText = "Monthly Objectives"
        Me.MonthlyObjectivesDataGridViewTextBoxColumn.Name = "MonthlyObjectivesDataGridViewTextBoxColumn"
        Me.MonthlyObjectivesDataGridViewTextBoxColumn.ReadOnly = True
        Me.MonthlyObjectivesDataGridViewTextBoxColumn.Width = 200
        '
        'PStatusDataGridViewTextBoxColumn
        '
        Me.PStatusDataGridViewTextBoxColumn.DataPropertyName = "PStatus"
        Me.PStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.PStatusDataGridViewTextBoxColumn.Name = "PStatusDataGridViewTextBoxColumn"
        Me.PStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReasonDataGridViewTextBoxColumn
        '
        Me.ReasonDataGridViewTextBoxColumn.DataPropertyName = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.HeaderText = "Reason"
        Me.ReasonDataGridViewTextBoxColumn.Name = "ReasonDataGridViewTextBoxColumn"
        Me.ReasonDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReasonDataGridViewTextBoxColumn.Width = 200
        '
        'EffectiveDateDataGridViewTextBoxColumn
        '
        Me.EffectiveDateDataGridViewTextBoxColumn.DataPropertyName = "EffectiveDate"
        Me.EffectiveDateDataGridViewTextBoxColumn.HeaderText = "Effective Date"
        Me.EffectiveDateDataGridViewTextBoxColumn.Name = "EffectiveDateDataGridViewTextBoxColumn"
        Me.EffectiveDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.EffectiveDateDataGridViewTextBoxColumn.Visible = False
        '
        'StartTimeDataGridViewTextBoxColumn
        '
        Me.StartTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.HeaderText = "Start Time"
        Me.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn"
        Me.StartTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.StartTimeDataGridViewTextBoxColumn.Width = 90
        '
        'EndTimeDataGridViewTextBoxColumn
        '
        Me.EndTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime"
        Me.EndTimeDataGridViewTextBoxColumn.HeaderText = "End Time"
        Me.EndTimeDataGridViewTextBoxColumn.Name = "EndTimeDataGridViewTextBoxColumn"
        Me.EndTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.EndTimeDataGridViewTextBoxColumn.Width = 90
        '
        'AchievedDataGridViewTextBoxColumn
        '
        Me.AchievedDataGridViewTextBoxColumn.DataPropertyName = "achieved"
        Me.AchievedDataGridViewTextBoxColumn.HeaderText = "Achieved"
        Me.AchievedDataGridViewTextBoxColumn.Name = "AchievedDataGridViewTextBoxColumn"
        Me.AchievedDataGridViewTextBoxColumn.ReadOnly = True
        Me.AchievedDataGridViewTextBoxColumn.Width = 200
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LinkLabel1)
        Me.GroupBox5.Controls.Add(Label29)
        Me.GroupBox5.Controls.Add(DesigNameLabel)
        Me.GroupBox5.Controls.Add(Me.CardLabel)
        Me.GroupBox5.Controls.Add(Me.DesigNameLabel1)
        Me.GroupBox5.Controls.Add(Me.SubDept2Label1)
        Me.GroupBox5.Controls.Add(DateOfJoiningLabel)
        Me.GroupBox5.Controls.Add(Me.DateOfJoiningLabel1)
        Me.GroupBox5.Controls.Add(FatherNameLabel)
        Me.GroupBox5.Controls.Add(Me.FatherNameLabel1)
        Me.GroupBox5.Controls.Add(FNameLabel)
        Me.GroupBox5.Controls.Add(Me.FNameLabel1)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox5.Location = New System.Drawing.Point(14, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1001, 75)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Employee Info"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(14, 45)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(90, 23)
        Me.LinkLabel1.TabIndex = 12
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Department:"
        Me.ToolTip1.SetToolTip(Me.LinkLabel1, "Click to view Department Progress")
        '
        'CardLabel
        '
        Me.CardLabel.BackColor = System.Drawing.Color.White
        Me.CardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CardLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "CardNo", True))
        Me.CardLabel.ForeColor = System.Drawing.Color.Black
        Me.CardLabel.Location = New System.Drawing.Point(109, 16)
        Me.CardLabel.Name = "CardLabel"
        Me.CardLabel.Size = New System.Drawing.Size(183, 23)
        Me.CardLabel.TabIndex = 7
        Me.CardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_PreSalaryBindingSource
        '
        Me.View_Rpt_Acc_PreSalaryBindingSource.DataMember = "tbl_Hrm_EmpEval_View_Rpt_Acc_PreSalary"
        Me.View_Rpt_Acc_PreSalaryBindingSource.DataSource = Me.Tbl_Hrm_EmpEvalBindingSource
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.Color.White
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "DesigName", True))
        Me.DesigNameLabel1.ForeColor = System.Drawing.Color.Black
        Me.DesigNameLabel1.Location = New System.Drawing.Point(458, 45)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(183, 23)
        Me.DesigNameLabel1.TabIndex = 11
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubDept2Label1
        '
        Me.SubDept2Label1.BackColor = System.Drawing.Color.White
        Me.SubDept2Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubDept2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "SubDept2", True))
        Me.SubDept2Label1.ForeColor = System.Drawing.Color.Black
        Me.SubDept2Label1.Location = New System.Drawing.Point(109, 45)
        Me.SubDept2Label1.Name = "SubDept2Label1"
        Me.SubDept2Label1.Size = New System.Drawing.Size(183, 23)
        Me.SubDept2Label1.TabIndex = 9
        Me.SubDept2Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateOfJoiningLabel1
        '
        Me.DateOfJoiningLabel1.BackColor = System.Drawing.Color.White
        Me.DateOfJoiningLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateOfJoiningLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "DateOfJoining", True))
        Me.DateOfJoiningLabel1.ForeColor = System.Drawing.Color.Black
        Me.DateOfJoiningLabel1.Location = New System.Drawing.Point(791, 45)
        Me.DateOfJoiningLabel1.Name = "DateOfJoiningLabel1"
        Me.DateOfJoiningLabel1.Size = New System.Drawing.Size(183, 23)
        Me.DateOfJoiningLabel1.TabIndex = 7
        Me.DateOfJoiningLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FatherNameLabel1
        '
        Me.FatherNameLabel1.BackColor = System.Drawing.Color.White
        Me.FatherNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FatherNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "FatherName", True))
        Me.FatherNameLabel1.ForeColor = System.Drawing.Color.Black
        Me.FatherNameLabel1.Location = New System.Drawing.Point(791, 16)
        Me.FatherNameLabel1.Name = "FatherNameLabel1"
        Me.FatherNameLabel1.Size = New System.Drawing.Size(183, 23)
        Me.FatherNameLabel1.TabIndex = 6
        Me.FatherNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FNameLabel1
        '
        Me.FNameLabel1.BackColor = System.Drawing.Color.White
        Me.FNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "FName", True))
        Me.FNameLabel1.ForeColor = System.Drawing.Color.Black
        Me.FNameLabel1.Location = New System.Drawing.Point(458, 16)
        Me.FNameLabel1.Name = "FNameLabel1"
        Me.FNameLabel1.Size = New System.Drawing.Size(183, 23)
        Me.FNameLabel1.TabIndex = 5
        Me.FNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(WarningNoticesLabel)
        Me.GroupBox4.Controls.Add(Me.WarningNoticesLabel1)
        Me.GroupBox4.Controls.Add(AbsentLabel)
        Me.GroupBox4.Controls.Add(Me.AbsentLabel1)
        Me.GroupBox4.Controls.Add(LateComingLabel)
        Me.GroupBox4.Controls.Add(Me.LateComingLabel1)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(358, 292)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(342, 107)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Attendance and  Warning Notice"
        '
        'WarningNoticesLabel1
        '
        Me.WarningNoticesLabel1.BackColor = System.Drawing.Color.White
        Me.WarningNoticesLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WarningNoticesLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "WarningNotices", True))
        Me.WarningNoticesLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningNoticesLabel1.Location = New System.Drawing.Point(288, 79)
        Me.WarningNoticesLabel1.Name = "WarningNoticesLabel1"
        Me.WarningNoticesLabel1.Size = New System.Drawing.Size(37, 19)
        Me.WarningNoticesLabel1.TabIndex = 7
        Me.WarningNoticesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AbsentLabel1
        '
        Me.AbsentLabel1.BackColor = System.Drawing.Color.White
        Me.AbsentLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AbsentLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "Absent", True))
        Me.AbsentLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbsentLabel1.Location = New System.Drawing.Point(288, 49)
        Me.AbsentLabel1.Name = "AbsentLabel1"
        Me.AbsentLabel1.Size = New System.Drawing.Size(37, 19)
        Me.AbsentLabel1.TabIndex = 5
        Me.AbsentLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LateComingLabel1
        '
        Me.LateComingLabel1.BackColor = System.Drawing.Color.White
        Me.LateComingLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LateComingLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "LateComing", True))
        Me.LateComingLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LateComingLabel1.Location = New System.Drawing.Point(288, 22)
        Me.LateComingLabel1.Name = "LateComingLabel1"
        Me.LateComingLabel1.Size = New System.Drawing.Size(37, 19)
        Me.LateComingLabel1.TabIndex = 1
        Me.LateComingLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.AccessibleDescription = ""
        Me.GroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.GroupBox1.Controls.Add(Me.Label70)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.ComboBox11)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(14, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 159)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Knowledge"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, resources.GetString("GroupBox1.ToolTip"))
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.Maroon
        Me.Label70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Yellow
        Me.Label70.Location = New System.Drawing.Point(296, 133)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(37, 19)
        Me.Label70.TabIndex = 26
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(10, 109)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(205, 19)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "5- Adaptability"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label30, resources.GetString("Label30.ToolTip"))
        '
        'ComboBox11
        '
        Me.ComboBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobKnowledge4", True))
        Me.ComboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox11.Location = New System.Drawing.Point(215, 109)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox11.TabIndex = 23
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.Location = New System.Drawing.Point(297, 109)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 19)
        Me.Label31.TabIndex = 24
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Remarks"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobKnowledgeRemark", True))
        Me.TextBox1.Location = New System.Drawing.Point(64, 133)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(230, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(10, 86)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(205, 19)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "4-Dependability (Overall Growth)"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label22, resources.GetString("Label22.ToolTip"))
        '
        'Label21
        '
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(10, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(205, 19)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "3-Shows improvement on repetitive tasks"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label21, "When doing something continuously (daily job routine tasks) take initiative to im" &
        "prove them in some way or other. ")
        '
        'Label20
        '
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(10, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(205, 19)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "2-Requires min. Supervision for every task"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label20, resources.GetString("Label20.ToolTip"))
        '
        'Label19
        '
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(10, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(205, 19)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "1-Sets appropriate priorities for tasks"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label19, "The ability to put first thing first in accordance with the importance and nature" &
        " of the task")
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(297, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 19)
        Me.Label10.TabIndex = 16
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox4
        '
        Me.ComboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobKnowledge3", True))
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox4.Location = New System.Drawing.Point(215, 86)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox4.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(297, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 19)
        Me.Label11.TabIndex = 15
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(297, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 19)
        Me.Label12.TabIndex = 14
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobKnowledge1", True))
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox3.Location = New System.Drawing.Point(215, 38)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox3.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(297, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 19)
        Me.Label13.TabIndex = 13
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobKnowledge", True))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox2.Location = New System.Drawing.Point(215, 15)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox2.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobKnowledge2", True))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox1.Location = New System.Drawing.Point(215, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label71)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Controls.Add(Me.ComboBox15)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.ComboBox14)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label38)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label39)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.ComboBox9)
        Me.GroupBox3.Controls.Add(Me.ComboBox10)
        Me.GroupBox3.Controls.Add(Me.ComboBox12)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox3.Location = New System.Drawing.Point(14, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(342, 159)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Job Attitude"
        Me.ToolTip1.SetToolTip(Me.GroupBox3, "The manner in which an employee conducts his or herself in the working environmen" &
        "t including personal habits and attitude towards the job & Organization")
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.Maroon
        Me.Label71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Yellow
        Me.Label71.Location = New System.Drawing.Point(297, 136)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(37, 19)
        Me.Label71.TabIndex = 38
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(6, 111)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(204, 19)
        Me.Label36.TabIndex = 37
        Me.Label36.Text = "5. Desire to excel in job"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label36, resources.GetString("Label36.ToolTip"))
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Location = New System.Drawing.Point(297, 111)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(37, 19)
        Me.Label41.TabIndex = 36
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox15
        '
        Me.ComboBox15.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox15.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobAttitude4", True))
        Me.ComboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox15.FormattingEnabled = True
        Me.ComboBox15.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox15.Location = New System.Drawing.Point(215, 111)
        Me.ComboBox15.Name = "ComboBox15"
        Me.ComboBox15.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox15.TabIndex = 35
        '
        'Label28
        '
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(6, 87)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(204, 19)
        Me.Label28.TabIndex = 34
        Me.Label28.Text = "4. Recognize strengths & limitations of self"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label28, resources.GetString("Label28.ToolTip"))
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label35.Location = New System.Drawing.Point(297, 87)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(37, 19)
        Me.Label35.TabIndex = 33
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox14
        '
        Me.ComboBox14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox14.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobAttitude", True))
        Me.ComboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox14.FormattingEnabled = True
        Me.ComboBox14.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox14.Location = New System.Drawing.Point(215, 87)
        Me.ComboBox14.Name = "ComboBox14"
        Me.ComboBox14.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox14.TabIndex = 32
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(6, 136)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(49, 19)
        Me.Label40.TabIndex = 31
        Me.Label40.Text = "Remarks"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(297, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(6, 62)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(204, 19)
        Me.Label37.TabIndex = 28
        Me.Label37.Text = "3. Consenses Building "
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label37, resources.GetString("Label37.ToolTip"))
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobAttitudeRemark", True))
        Me.TextBox3.Location = New System.Drawing.Point(64, 136)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(230, 20)
        Me.TextBox3.TabIndex = 23
        '
        'Label38
        '
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(6, 37)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(204, 19)
        Me.Label38.TabIndex = 27
        Me.Label38.Text = "2- Team Work"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label38, resources.GetString("Label38.ToolTip"))
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(297, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(6, 13)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(204, 19)
        Me.Label39.TabIndex = 26
        Me.Label39.Text = "1. Initiativeness"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label39, resources.GetString("Label39.ToolTip"))
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(297, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox9
        '
        Me.ComboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobAttitude3", True))
        Me.ComboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox9.Location = New System.Drawing.Point(215, 62)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox9.TabIndex = 3
        '
        'ComboBox10
        '
        Me.ComboBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobAttitude1", True))
        Me.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox10.Location = New System.Drawing.Point(215, 13)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox10.TabIndex = 1
        '
        'ComboBox12
        '
        Me.ComboBox12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox12.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "JobAttitude2", True))
        Me.ComboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox12.FormattingEnabled = True
        Me.ComboBox12.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox12.Location = New System.Drawing.Point(215, 37)
        Me.ComboBox12.Name = "ComboBox12"
        Me.ComboBox12.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox12.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label72)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.ComboBox17)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.ComboBox16)
        Me.GroupBox2.Controls.Add(Me.Label43)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.ComboBox13)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.ComboBox6)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.ComboBox8)
        Me.GroupBox2.Controls.Add(Me.ComboBox7)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox2.Location = New System.Drawing.Point(358, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 211)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tasks Achievement"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "Level of satisfactory output generated per unit of time & Capacity to make reason" &
        "able decisions")
        '
        'Label72
        '
        Me.Label72.BackColor = System.Drawing.Color.Maroon
        Me.Label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Yellow
        Me.Label72.Location = New System.Drawing.Point(296, 184)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(37, 19)
        Me.Label72.TabIndex = 34
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label44
        '
        Me.Label44.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(6, 157)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(190, 19)
        Me.Label44.TabIndex = 33
        Me.Label44.Text = "7- Resourcefulness"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label44, resources.GetString("Label44.ToolTip"))
        '
        'ComboBox17
        '
        Me.ComboBox17.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox17.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "TasksAchievement6", True))
        Me.ComboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox17.FormattingEnabled = True
        Me.ComboBox17.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox17.Location = New System.Drawing.Point(213, 157)
        Me.ComboBox17.Name = "ComboBox17"
        Me.ComboBox17.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox17.TabIndex = 31
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.White
        Me.Label45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label45.Location = New System.Drawing.Point(296, 157)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(37, 19)
        Me.Label45.TabIndex = 32
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label42
        '
        Me.Label42.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(6, 133)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(190, 19)
        Me.Label42.TabIndex = 30
        Me.Label42.Text = "6- Quality of Work"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label42, resources.GetString("Label42.ToolTip"))
        '
        'Label23
        '
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(6, 109)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(190, 19)
        Me.Label23.TabIndex = 24
        Me.Label23.Text = "5- Planning and Organizing"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label23, resources.GetString("Label23.ToolTip"))
        '
        'ComboBox16
        '
        Me.ComboBox16.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox16.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "TasksAchievement5", True))
        Me.ComboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox16.FormattingEnabled = True
        Me.ComboBox16.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox16.Location = New System.Drawing.Point(213, 133)
        Me.ComboBox16.Name = "ComboBox16"
        Me.ComboBox16.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox16.TabIndex = 28
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.White
        Me.Label43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label43.Location = New System.Drawing.Point(296, 133)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(37, 19)
        Me.Label43.TabIndex = 29
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(6, 86)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(190, 19)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "4- Proactive Behavior"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label32, "The ability to foresee things, analyze problems and provide solutions, readiness " &
        "and willingness for change with positive attitude." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "§" & Global.Microsoft.VisualBasic.ChrW(9) & "Assesses and takes steps t" &
        "o improve work " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'ComboBox13
        '
        Me.ComboBox13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox13.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "TasksAchievement4", True))
        Me.ComboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox13.FormattingEnabled = True
        Me.ComboBox13.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox13.Location = New System.Drawing.Point(213, 109)
        Me.ComboBox13.Name = "ComboBox13"
        Me.ComboBox13.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox13.TabIndex = 25
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label33.Location = New System.Drawing.Point(296, 109)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(37, 19)
        Me.Label33.TabIndex = 26
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(6, 184)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 19)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Remarks"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "TasksAchievementRemark", True))
        Me.TextBox2.Location = New System.Drawing.Point(62, 184)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(230, 20)
        Me.TextBox2.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Location = New System.Drawing.Point(296, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 19)
        Me.Label15.TabIndex = 20
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(6, 62)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(190, 19)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "3-Problem Solving"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label24, resources.GetString("Label24.ToolTip"))
        '
        'ComboBox5
        '
        Me.ComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "TasksAchievement3", True))
        Me.ComboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox5.Location = New System.Drawing.Point(213, 86)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox5.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(6, 38)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(190, 19)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "2-Follow SOP / Follow Protocol"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label25, resources.GetString("Label25.ToolTip"))
        '
        'Label26
        '
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Help
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(6, 15)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(190, 19)
        Me.Label26.TabIndex = 21
        Me.Label26.Text = "1-Meets Deadlines"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.Label26, "The ability to adhere to one's responsibilities in a timely manner." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "·" & Global.Microsoft.VisualBasic.ChrW(9) & "Meets dead" &
        "lines" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "·" & Global.Microsoft.VisualBasic.ChrW(9) & "Manages multiple tasks with accuracy and efficiency" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(296, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 19)
        Me.Label16.TabIndex = 19
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(296, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 19)
        Me.Label17.TabIndex = 18
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox6
        '
        Me.ComboBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "TasksAchievement1", True))
        Me.ComboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox6.Location = New System.Drawing.Point(213, 38)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox6.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(296, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 19)
        Me.Label18.TabIndex = 17
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox8
        '
        Me.ComboBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "TasksAchievement2", True))
        Me.ComboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox8.Location = New System.Drawing.Point(213, 62)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox8.TabIndex = 2
        '
        'ComboBox7
        '
        Me.ComboBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "TasksAchievement", True))
        Me.ComboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"", "Never", "Rare", "Often", "Mostly ", "Always"})
        Me.ComboBox7.Location = New System.Drawing.Point(213, 15)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox7.TabIndex = 0
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_Hrm_EmpEvalBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.SaveToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1052, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
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
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "Save Data"
        Me.SaveToolStripButton.Visible = False
        '
        'CardNo1
        '
        Me.CardNo1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEvalBindingSource, "ETRID", True))
        Me.CardNo1.Location = New System.Drawing.Point(12, 9)
        Me.CardNo1.Name = "CardNo1"
        Me.CardNo1.Size = New System.Drawing.Size(10, 10)
        Me.CardNo1.TabIndex = 3
        '
        'Tbl_Hrm_Emp_InfoTableAdapter
        '
        Me.Tbl_Hrm_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_BonusNoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Me.Tbl_Acc_FinancialPeriodTableAdapter
        Me.TableAdapterManager.tbl_Hrm_DepartmentsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_HTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_NoticesTableAdapter = Me.Tbl_Hrm_Emp_Info_NoticesTableAdapter
        Me.TableAdapterManager.tbl_Hrm_Emp_Info1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_InfoTableAdapter = Me.Tbl_Hrm_Emp_InfoTableAdapter
        Me.TableAdapterManager.tbl_Hrm_EmpEval_MonthTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmpEval_Self_AssessmentTableAdapter = Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter
        Me.TableAdapterManager.tbl_Hrm_EmpEvalTableAdapter = Me.Tbl_Hrm_EmpEvalTableAdapter
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSEmpEvalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_NoticesTableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_NoticesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter
        '
        Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_EmpEvalTableAdapter
        '
        Me.Tbl_Hrm_EmpEvalTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_Salary_TransactionsTableAdapter
        '
        Me.Tbl_Acc_Salary_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_Salary_TransactionsBindingSource
        '
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataMember = "tbl_Acc_Salary_Transactions"
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataSource = Me.DSEmpEval
        '
        'Tbl_Hrm_Emp_Info_NoticesBindingSource
        '
        Me.Tbl_Hrm_Emp_Info_NoticesBindingSource.DataMember = "tbl_Hrm_Emp_Info_Notices"
        Me.Tbl_Hrm_Emp_Info_NoticesBindingSource.DataSource = Me.DSEmpEval
        '
        'DSEmpEvalBindingSource
        '
        Me.DSEmpEvalBindingSource.DataSource = Me.DSEmpEval
        Me.DSEmpEvalBindingSource.Position = 0
        '
        'View_Rpt_Acc_PreSalaryTableAdapter
        '
        Me.View_Rpt_Acc_PreSalaryTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(904, 46)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(182, 51)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Send Email To All"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Maroon
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Yellow
        Me.Button5.Location = New System.Drawing.Point(716, 45)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(182, 51)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Employees Evaluation Summary"
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 50000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 500
        Me.ToolTip1.ShowAlways = True
        '
        'Label74
        '
        Me.Label74.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label74.Location = New System.Drawing.Point(0, 736)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(1160, 44)
        Me.Label74.TabIndex = 16
        Me.Label74.Text = resources.GetString("Label74.Text")
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "SubDept2ID", True))
        Me.TextBox5.Location = New System.Drawing.Point(1008, 6)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 13)
        Me.TextBox5.TabIndex = 17
        '
        'EmployeeEvaluationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1177, 742)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CardNo1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EmployeeEvaluationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  EmployeeEvaluationForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSEmpEval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Tbl_Hrm_EmpEvalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_EmpEval_Self_AssessmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_NoticesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSEmpEvalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents FinancialPeriodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DSEmpEval As ERP_HRMS.DSEmpEval
    Friend WithEvents Tbl_Hrm_Emp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_InfoTableAdapter As ERP_HRMS.DSEmpEvalTableAdapters.tbl_Hrm_Emp_InfoTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSEmpEvalTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Acc_Salary_TransactionsTableAdapter As ERP_HRMS.DSEmpEvalTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter
    Friend WithEvents Tbl_Acc_Salary_TransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As ERP_HRMS.DSEmpEvalTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_NoticesTableAdapter As ERP_HRMS.DSEmpEvalTableAdapters.tbl_Hrm_Emp_Info_NoticesTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Info_NoticesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_EmpEvalTableAdapter As ERP_HRMS.DSEmpEvalTableAdapters.tbl_Hrm_EmpEvalTableAdapter
    Friend WithEvents Tbl_Hrm_EmpEvalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSEmpEvalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents View_Rpt_Acc_PreSalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_PreSalaryTableAdapter As ERP_HRMS.DSEmpEvalTableAdapters.View_Rpt_Acc_PreSalaryTableAdapter
    Friend WithEvents FNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents FatherNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DesigNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents SubDept2Label1 As System.Windows.Forms.Label
    Friend WithEvents DateOfJoiningLabel1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox12 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents AbsentLabel1 As System.Windows.Forms.Label
    Friend WithEvents LateComingLabel1 As System.Windows.Forms.Label
    Friend WithEvents WarningNoticesLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CardNo1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CardLabel As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents View_EmpEval_Self_AssessmentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Tbl_Hrm_EmpEval_Self_AssessmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter As ERP_HRMS.DSEmpEvalTableAdapters.tbl_Hrm_EmpEval_Self_AssessmentTableAdapter
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents ComboBox11 As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents ComboBox13 As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents ComboBox15 As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ComboBox14 As System.Windows.Forms.ComboBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ComboBox17 As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents ComboBox16 As System.Windows.Forms.ComboBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents ComboBox18 As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents ComboBox19 As System.Windows.Forms.ComboBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents ComboBox20 As System.Windows.Forms.ComboBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents ComboBox21 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox22 As System.Windows.Forms.ComboBox
    Friend WithEvents ESADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthlyObjectivesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReasonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EffectiveDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AchievedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox5 As TextBox
End Class
