<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptEmpEvaluation
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
        Dim BusNoLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim SectionNameLabel As System.Windows.Forms.Label
        Dim GradeNameLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GradeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.BusNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Emp_Evaluation_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSEmpEvaluation = New ERP_HRMS.DSEmpEvaluation()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Emp_Evaluation_HeadTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_Evaluation_HeadTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSEmpEvaluationTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Deptpanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.DepBTn = New System.Windows.Forms.RadioButton()
        Me.AllDept = New System.Windows.Forms.RadioButton()
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.SecBtn = New System.Windows.Forms.RadioButton()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.BBtn = New System.Windows.Forms.RadioButton()
        Me.GBtn = New System.Windows.Forms.RadioButton()
        Me.All = New System.Windows.Forms.RadioButton()
        BusNoLabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        SectionNameLabel = New System.Windows.Forms.Label()
        GradeNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Emp_Evaluation_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSEmpEvaluation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Deptpanel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BusNoLabel
        '
        BusNoLabel.Location = New System.Drawing.Point(7, 19)
        BusNoLabel.Name = "BusNoLabel"
        BusNoLabel.Size = New System.Drawing.Size(111, 20)
        BusNoLabel.TabIndex = 1
        BusNoLabel.Text = "Evaluation Period:"
        BusNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DeptNameLabel
        '
        DeptNameLabel.AutoSize = True
        DeptNameLabel.ForeColor = System.Drawing.Color.Black
        DeptNameLabel.Location = New System.Drawing.Point(13, 44)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(65, 13)
        DeptNameLabel.TabIndex = 0
        DeptNameLabel.Text = "Depatrment:"
        '
        'DesigNameLabel
        '
        DesigNameLabel.AutoSize = True
        DesigNameLabel.ForeColor = System.Drawing.Color.Black
        DesigNameLabel.Location = New System.Drawing.Point(13, 101)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(66, 13)
        DesigNameLabel.TabIndex = 4
        DesigNameLabel.Text = "Designation:"
        '
        'SectionNameLabel
        '
        SectionNameLabel.AutoSize = True
        SectionNameLabel.ForeColor = System.Drawing.Color.Black
        SectionNameLabel.Location = New System.Drawing.Point(13, 72)
        SectionNameLabel.Name = "SectionNameLabel"
        SectionNameLabel.Size = New System.Drawing.Size(46, 13)
        SectionNameLabel.TabIndex = 2
        SectionNameLabel.Text = "Section:"
        '
        'GradeNameLabel
        '
        GradeNameLabel.AutoSize = True
        GradeNameLabel.ForeColor = System.Drawing.Color.Black
        GradeNameLabel.Location = New System.Drawing.Point(79, 50)
        GradeNameLabel.Name = "GradeNameLabel"
        GradeNameLabel.Size = New System.Drawing.Size(39, 13)
        GradeNameLabel.TabIndex = 10
        GradeNameLabel.Text = "Grade:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1028, 40)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Employees Annual Evaluation Reports"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(GradeNameLabel)
        Me.GroupBox2.Controls.Add(Me.GradeNameComboBox)
        Me.GroupBox2.Controls.Add(BusNoLabel)
        Me.GroupBox2.Controls.Add(Me.BusNoComboBox)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(319, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 102)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter Criteria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(228, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "To Card:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(60, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "From Card:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(294, 72)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(123, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GradeNameComboBox
        '
        Me.GradeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GradeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GradeNameComboBox.DataSource = Me.Tbl_HRM_GradeBindingSource
        Me.GradeNameComboBox.DisplayMember = "GradeName"
        Me.GradeNameComboBox.Enabled = False
        Me.GradeNameComboBox.FormattingEnabled = True
        Me.GradeNameComboBox.Location = New System.Drawing.Point(123, 45)
        Me.GradeNameComboBox.Name = "GradeNameComboBox"
        Me.GradeNameComboBox.Size = New System.Drawing.Size(191, 21)
        Me.GradeNameComboBox.TabIndex = 11
        Me.GradeNameComboBox.ValueMember = "GradeID"
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusNoComboBox
        '
        Me.BusNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BusNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BusNoComboBox.DataSource = Me.Tbl_Emp_Evaluation_HeadBindingSource
        Me.BusNoComboBox.DisplayMember = "EvaluationPeriod"
        Me.BusNoComboBox.FormattingEnabled = True
        Me.BusNoComboBox.Location = New System.Drawing.Point(123, 18)
        Me.BusNoComboBox.Name = "BusNoComboBox"
        Me.BusNoComboBox.Size = New System.Drawing.Size(191, 21)
        Me.BusNoComboBox.TabIndex = 2
        Me.BusNoComboBox.ValueMember = "EvalID"
        '
        'Tbl_Emp_Evaluation_HeadBindingSource
        '
        Me.Tbl_Emp_Evaluation_HeadBindingSource.DataMember = "tbl_Emp_Evaluation_Head"
        Me.Tbl_Emp_Evaluation_HeadBindingSource.DataSource = Me.DSEmpEvaluation
        '
        'DSEmpEvaluation
        '
        Me.DSEmpEvaluation.DataSetName = "DSEmpEvaluation"
        Me.DSEmpEvaluation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(-304, 122)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(224, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Employees Annual Evaluation Reports List"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(628, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(185, 57)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selection"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(116, 328)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 41)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Check State On for Active Eval.Status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Checked State Off for Non-Active Eval.Stat" &
    "us" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In Intermediate State for All Records" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label5.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(365, 353)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Check State"
        Me.CheckBox1.ThreeState = True
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(155, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Employees Evaluation Form"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Tbl_Emp_Evaluation_HeadTableAdapter
        '
        Me.Tbl_Emp_Evaluation_HeadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Emp_Evaluation_HeadTableAdapter = Me.Tbl_Emp_Evaluation_HeadTableAdapter
        Me.TableAdapterManager.tbl_Emp_Evaluation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Emp_Evaluation2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Emp_EvaluationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSEmpEvaluationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_DeptBindingSource
        '
        Me.Tbl_HRM_DeptBindingSource.DataMember = "tbl_HRM_Dept"
        Me.Tbl_HRM_DeptBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_DeptTableAdapter
        '
        Me.Tbl_HRM_DeptTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager1.tbl_HRM_BankTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_BranchTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_DeptTableAdapter = Me.Tbl_HRM_DeptTableAdapter
        Me.TableAdapterManager1.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_DesignationTableAdapter = Me.Tbl_HRM_DesignationTableAdapter
        Me.TableAdapterManager1.tbl_HRM_Emp_Info1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_GradeTableAdapter = Me.Tbl_HRM_GradeTableAdapter
        Me.TableAdapterManager1.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_SectionTableAdapter = Me.Tbl_HRM_SectionTableAdapter
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_GradeTableAdapter
        '
        Me.Tbl_HRM_GradeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionBindingSource
        '
        Me.Tbl_HRM_SectionBindingSource.DataMember = "tbl_HRM_Dept_tbl_HRM_Section"
        Me.Tbl_HRM_SectionBindingSource.DataSource = Me.Tbl_HRM_DeptBindingSource
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'Deptpanel
        '
        Me.Deptpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Deptpanel.Controls.Add(Me.Label1)
        Me.Deptpanel.Controls.Add(Me.DeptNameComboBox)
        Me.Deptpanel.Controls.Add(DeptNameLabel)
        Me.Deptpanel.Controls.Add(Me.DesigBtn)
        Me.Deptpanel.Controls.Add(DesigNameLabel)
        Me.Deptpanel.Controls.Add(Me.DepBTn)
        Me.Deptpanel.Controls.Add(Me.AllDept)
        Me.Deptpanel.Controls.Add(Me.SectionNameComboBox)
        Me.Deptpanel.Controls.Add(Me.SecBtn)
        Me.Deptpanel.Controls.Add(SectionNameLabel)
        Me.Deptpanel.Controls.Add(Me.DesigNameComboBox)
        Me.Deptpanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deptpanel.Location = New System.Drawing.Point(318, 151)
        Me.Deptpanel.Name = "Deptpanel"
        Me.Deptpanel.Size = New System.Drawing.Size(395, 182)
        Me.Deptpanel.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Appropriate Option"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(117, 39)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(260, 21)
        Me.DeptNameComboBox.TabIndex = 1
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.ForeColor = System.Drawing.Color.Black
        Me.DesigBtn.Location = New System.Drawing.Point(13, 153)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(81, 17)
        Me.DesigBtn.TabIndex = 0
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'DepBTn
        '
        Me.DepBTn.AutoSize = True
        Me.DepBTn.ForeColor = System.Drawing.Color.Black
        Me.DepBTn.Location = New System.Drawing.Point(117, 126)
        Me.DepBTn.Name = "DepBTn"
        Me.DepBTn.Size = New System.Drawing.Size(80, 17)
        Me.DepBTn.TabIndex = 0
        Me.DepBTn.Text = "Department"
        Me.DepBTn.UseVisualStyleBackColor = True
        '
        'AllDept
        '
        Me.AllDept.AutoSize = True
        Me.AllDept.Checked = True
        Me.AllDept.ForeColor = System.Drawing.Color.Black
        Me.AllDept.Location = New System.Drawing.Point(13, 126)
        Me.AllDept.Name = "AllDept"
        Me.AllDept.Size = New System.Drawing.Size(36, 17)
        Me.AllDept.TabIndex = 0
        Me.AllDept.TabStop = True
        Me.AllDept.Text = "All"
        Me.AllDept.UseVisualStyleBackColor = True
        '
        'SectionNameComboBox
        '
        Me.SectionNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SectionNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectionNameComboBox.DataSource = Me.Tbl_HRM_SectionBindingSource
        Me.SectionNameComboBox.DisplayMember = "SectionName"
        Me.SectionNameComboBox.Enabled = False
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(117, 67)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(260, 21)
        Me.SectionNameComboBox.TabIndex = 3
        Me.SectionNameComboBox.ValueMember = "SectionID"
        '
        'SecBtn
        '
        Me.SecBtn.AutoSize = True
        Me.SecBtn.ForeColor = System.Drawing.Color.Black
        Me.SecBtn.Location = New System.Drawing.Point(117, 153)
        Me.SecBtn.Name = "SecBtn"
        Me.SecBtn.Size = New System.Drawing.Size(61, 17)
        Me.SecBtn.TabIndex = 0
        Me.SecBtn.Text = "Section"
        Me.SecBtn.UseVisualStyleBackColor = True
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(117, 96)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(260, 21)
        Me.DesigNameComboBox.TabIndex = 5
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.BBtn)
        Me.GroupBox6.Controls.Add(Me.GBtn)
        Me.GroupBox6.Controls.Add(Me.All)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(128, 106)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(185, 108)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Option Selector"
        '
        'BBtn
        '
        Me.BBtn.AutoSize = True
        Me.BBtn.ForeColor = System.Drawing.Color.Black
        Me.BBtn.Location = New System.Drawing.Point(14, 47)
        Me.BBtn.Name = "BBtn"
        Me.BBtn.Size = New System.Drawing.Size(69, 17)
        Me.BBtn.TabIndex = 1
        Me.BBtn.Text = "By Grade"
        Me.BBtn.UseVisualStyleBackColor = True
        '
        'GBtn
        '
        Me.GBtn.AutoSize = True
        Me.GBtn.ForeColor = System.Drawing.Color.Black
        Me.GBtn.Location = New System.Drawing.Point(14, 72)
        Me.GBtn.Name = "GBtn"
        Me.GBtn.Size = New System.Drawing.Size(97, 17)
        Me.GBtn.TabIndex = 2
        Me.GBtn.Text = "By Card Range"
        Me.GBtn.UseVisualStyleBackColor = True
        '
        'All
        '
        Me.All.AutoSize = True
        Me.All.Checked = True
        Me.All.ForeColor = System.Drawing.Color.Black
        Me.All.Location = New System.Drawing.Point(14, 22)
        Me.All.Name = "All"
        Me.All.Size = New System.Drawing.Size(36, 17)
        Me.All.TabIndex = 0
        Me.All.TabStop = True
        Me.All.Text = "All"
        Me.All.UseVisualStyleBackColor = True
        '
        'frmRptEmpEvaluation
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 431)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Deptpanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmRptEmpEvaluation"
        Me.Text = "Employees Annual Evaluation Reports"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Emp_Evaluation_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSEmpEvaluation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Deptpanel.ResumeLayout(False)
        Me.Deptpanel.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BusNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents DSEmpEvaluation As ERP_HRMS.DSEmpEvaluation
    Friend WithEvents Tbl_Emp_Evaluation_HeadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Emp_Evaluation_HeadTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_Evaluation_HeadTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSEmpEvaluationTableAdapters.TableAdapterManager
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents TableAdapterManager1 As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Deptpanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents DesigBtn As RadioButton
    Friend WithEvents DepBTn As RadioButton
    Friend WithEvents AllDept As RadioButton
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents SecBtn As RadioButton
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BBtn As RadioButton
    Friend WithEvents GBtn As RadioButton
    Friend WithEvents All As RadioButton
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents GradeNameComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
