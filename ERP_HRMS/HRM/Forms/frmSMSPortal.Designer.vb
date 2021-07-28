<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSMSPortal
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
        Dim Label4 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSMSPortal))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MonthBtn = New System.Windows.Forms.RadioButton()
        Me.MonthndCedBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComposeMsgBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DSDeptsForPayrollReport = New ERP_HRMS.DSDeptsForPayrollReport()
        Me.Tbl_Hrm_DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_DepartmentsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager()
        Me.Tbl_Hrm_DesignationsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter()
        Me.Tbl_Hrm_SubDept1TableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter()
        Me.Tbl_Hrm_SubDept1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_DesignationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RadioButton16 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.RadioButton19 = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.View_Rpt_Acc_PreSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_PreSalaryTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.View_Rpt_Acc_PreSalaryTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CardNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesigNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RadioUrdu = New System.Windows.Forms.RadioButton()
        Me.RadioEnglish = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.DSCalculateSalary = New ERP_HRMS.DSCalculateSalary()
        Me.View_Rpt_Acc_OverTimeSumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_OverTimeSumTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_Acc_OverTimeSumTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSCalculateSalaryTableAdapters.TableAdapterManager()
        Me.Tbl_PayRoll_LongLeaves4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_LongLeaves4TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves4TableAdapter()
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecordTableAdapter()
        Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_PayRoll_EmpAttRecord1TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecord1TableAdapter()
        Me.Tbl_Hrm_HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_HolidaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Hrm_HolidaysTableAdapter()
        Me.View_Emp_Deduction_DaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_Deduction_DaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Deduction_DaysTableAdapter()
        Me.Tbl_PayRoll_LongLeaves6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_LongLeaves6TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves6TableAdapter()
        Me.Tbl_PayRoll_LongLeaves8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_LongLeaves8TableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves8TableAdapter()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCalculateSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_OverTimeSumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Deduction_DaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(763, 103)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(113, 20)
        Label4.TabIndex = 45
        Label4.Text = "Financial Period:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1195, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SMS Portal"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MonthBtn)
        Me.GroupBox3.Controls.Add(Me.MonthndCedBtn)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(355, 120)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(386, 44)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Appropriate Filter"
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
        Me.MonthndCedBtn.Location = New System.Drawing.Point(191, 19)
        Me.MonthndCedBtn.Name = "MonthndCedBtn"
        Me.MonthndCedBtn.Size = New System.Drawing.Size(122, 21)
        Me.MonthndCedBtn.TabIndex = 10
        Me.MonthndCedBtn.Text = "By Card Range"
        Me.MonthndCedBtn.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextBox2)
        Me.GroupBox7.Controls.Add(Me.TextBox1)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Enabled = False
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(355, 171)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(397, 66)
        Me.GroupBox7.TabIndex = 34
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Option Selection"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(290, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(97, 23)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(123, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(86, 23)
        Me.TextBox1.TabIndex = 16
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'ComposeMsgBox
        '
        Me.ComposeMsgBox.Location = New System.Drawing.Point(13, 81)
        Me.ComposeMsgBox.Multiline = True
        Me.ComposeMsgBox.Name = "ComposeMsgBox"
        Me.ComposeMsgBox.Size = New System.Drawing.Size(312, 335)
        Me.ComposeMsgBox.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(13, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(312, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Compose Message"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(766, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(297, 59)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Send SMS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DSDeptsForPayrollReport
        '
        Me.DSDeptsForPayrollReport.DataSetName = "DSDeptsForPayrollReport"
        Me.DSDeptsForPayrollReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_BonusNoSettingsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_BranchesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_DepartmentsTableAdapter = Me.Tbl_Hrm_DepartmentsTableAdapter
        Me.TableAdapterManager.tbl_Hrm_DesignationsTableAdapter = Me.Tbl_Hrm_DesignationsTableAdapter
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_H1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Info_H2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_SubDept1TableAdapter = Me.Tbl_Hrm_SubDept1TableAdapter
        Me.TableAdapterManager.tbl_PayRoll_ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Working_DayTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Hrm_DesignationsTableAdapter
        '
        Me.Tbl_Hrm_DesignationsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_SubDept1TableAdapter
        '
        Me.Tbl_Hrm_SubDept1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_SubDept1BindingSource
        '
        Me.Tbl_Hrm_SubDept1BindingSource.DataMember = "tbl_Hrm_Departments_tbl_Hrm_SubDept1"
        Me.Tbl_Hrm_SubDept1BindingSource.DataSource = Me.Tbl_Hrm_DepartmentsBindingSource
        '
        'Tbl_Hrm_DesignationsBindingSource
        '
        Me.Tbl_Hrm_DesignationsBindingSource.DataMember = "tbl_Hrm_Designations"
        Me.Tbl_Hrm_DesignationsBindingSource.DataSource = Me.DSDeptsForPayrollReport
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
        Me.Panel1.Location = New System.Drawing.Point(350, 244)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 172)
        Me.Panel1.TabIndex = 38
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
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(17, 91)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 20)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Designation:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(17, 37)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 20)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "Department:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 717)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1195, 25)
        Me.ToolStrip1.TabIndex = 39
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripProgressBar1.Step = 1
        '
        'View_Rpt_Acc_PreSalaryBindingSource
        '
        Me.View_Rpt_Acc_PreSalaryBindingSource.DataMember = "View_Rpt_Acc_PreSalary"
        Me.View_Rpt_Acc_PreSalaryBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'View_Rpt_Acc_PreSalaryTableAdapter
        '
        Me.View_Rpt_Acc_PreSalaryTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(13, 424)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(743, 311)
        Me.Panel2.TabIndex = 40
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardNoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DeptNameDataGridViewTextBoxColumn, Me.SectionNameDataGridViewTextBoxColumn, Me.DesigNameDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.View_Rpt_Acc_PreSalaryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 21
        Me.DataGridView1.Size = New System.Drawing.Size(735, 278)
        Me.DataGridView1.TabIndex = 1
        '
        'CardNoDataGridViewTextBoxColumn
        '
        Me.CardNoDataGridViewTextBoxColumn.DataPropertyName = "CardNo"
        Me.CardNoDataGridViewTextBoxColumn.HeaderText = "Card No"
        Me.CardNoDataGridViewTextBoxColumn.Name = "CardNoDataGridViewTextBoxColumn"
        Me.CardNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeptNameDataGridViewTextBoxColumn
        '
        Me.DeptNameDataGridViewTextBoxColumn.DataPropertyName = "DeptName"
        Me.DeptNameDataGridViewTextBoxColumn.HeaderText = "Dept. Name"
        Me.DeptNameDataGridViewTextBoxColumn.Name = "DeptNameDataGridViewTextBoxColumn"
        Me.DeptNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeptNameDataGridViewTextBoxColumn.Width = 150
        '
        'SectionNameDataGridViewTextBoxColumn
        '
        Me.SectionNameDataGridViewTextBoxColumn.DataPropertyName = "SectionName"
        Me.SectionNameDataGridViewTextBoxColumn.HeaderText = "Section Name"
        Me.SectionNameDataGridViewTextBoxColumn.Name = "SectionNameDataGridViewTextBoxColumn"
        Me.SectionNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SectionNameDataGridViewTextBoxColumn.Width = 150
        '
        'DesigNameDataGridViewTextBoxColumn
        '
        Me.DesigNameDataGridViewTextBoxColumn.DataPropertyName = "DesigName"
        Me.DesigNameDataGridViewTextBoxColumn.HeaderText = "Designation Name"
        Me.DesigNameDataGridViewTextBoxColumn.Name = "DesigNameDataGridViewTextBoxColumn"
        Me.DesigNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.DesigNameDataGridViewTextBoxColumn.Width = 170
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        Me.ContactNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContactNoDataGridViewTextBoxColumn.Visible = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.View_Rpt_Acc_PreSalaryBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(741, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'RadioUrdu
        '
        Me.RadioUrdu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioUrdu.AutoSize = True
        Me.RadioUrdu.ForeColor = System.Drawing.Color.Black
        Me.RadioUrdu.Location = New System.Drawing.Point(327, 22)
        Me.RadioUrdu.Name = "RadioUrdu"
        Me.RadioUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioUrdu.Size = New System.Drawing.Size(47, 21)
        Me.RadioUrdu.TabIndex = 1
        Me.RadioUrdu.Text = "اردو"
        Me.RadioUrdu.UseVisualStyleBackColor = True
        '
        'RadioEnglish
        '
        Me.RadioEnglish.AutoSize = True
        Me.RadioEnglish.Checked = True
        Me.RadioEnglish.ForeColor = System.Drawing.Color.Black
        Me.RadioEnglish.Location = New System.Drawing.Point(6, 22)
        Me.RadioEnglish.Name = "RadioEnglish"
        Me.RadioEnglish.Size = New System.Drawing.Size(72, 21)
        Me.RadioEnglish.TabIndex = 0
        Me.RadioEnglish.TabStop = True
        Me.RadioEnglish.Text = "English"
        Me.RadioEnglish.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioEnglish)
        Me.GroupBox1.Controls.Add(Me.RadioUrdu)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(355, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 56)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Appropriate Language"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FinancialPeriodComboBox)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(760, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 109)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Appropriate Message"
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinancialPeriodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(120, 46)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(148, 24)
        Me.FinancialPeriodComboBox.TabIndex = 46
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(177, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Leave Record"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 79)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 23)
        Me.DateTimePicker1.TabIndex = 43
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(6, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(146, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Compose Message"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 20)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Select Month:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'DSCalculateSalary
        '
        Me.DSCalculateSalary.DataSetName = "DSCalculateSalary"
        Me.DSCalculateSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Rpt_Acc_OverTimeSumBindingSource
        '
        Me.View_Rpt_Acc_OverTimeSumBindingSource.DataMember = "View_Rpt_Acc_OverTimeSum"
        Me.View_Rpt_Acc_OverTimeSumBindingSource.DataSource = Me.DSCalculateSalary
        '
        'View_Rpt_Acc_OverTimeSumTableAdapter
        '
        Me.View_Rpt_Acc_OverTimeSumTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Acc_Salary_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Emp_Salary_Calculation_AdjTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_Info_Cards_InfoTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_Info_HTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSCalculateSalaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_PayRoll_LongLeaves4BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves4BindingSource.DataMember = "tbl_PayRoll_LongLeaves4"
        Me.Tbl_PayRoll_LongLeaves4BindingSource.DataSource = Me.DSCalculateSalary
        '
        'Tbl_PayRoll_LongLeaves4TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves4TableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_PayRoll_EmpAttRecordBindingSource
        '
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource.DataMember = "View_Rpt_PayRoll_EmpAttRecord"
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource.DataSource = Me.DSCalculateSalary
        '
        'View_Rpt_PayRoll_EmpAttRecordTableAdapter
        '
        Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_PayRoll_EmpAttRecord1BindingSource
        '
        Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource.DataMember = "View_Rpt_PayRoll_EmpAttRecord1"
        Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource.DataSource = Me.DSCalculateSalary
        '
        'View_Rpt_PayRoll_EmpAttRecord1TableAdapter
        '
        Me.View_Rpt_PayRoll_EmpAttRecord1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_HolidaysBindingSource
        '
        Me.Tbl_Hrm_HolidaysBindingSource.DataMember = "tbl_Hrm_Holidays"
        Me.Tbl_Hrm_HolidaysBindingSource.DataSource = Me.DSCalculateSalary
        '
        'Tbl_Hrm_HolidaysTableAdapter
        '
        Me.Tbl_Hrm_HolidaysTableAdapter.ClearBeforeFill = True
        '
        'View_Emp_Deduction_DaysBindingSource
        '
        Me.View_Emp_Deduction_DaysBindingSource.DataMember = "View_Emp_Deduction_Days"
        Me.View_Emp_Deduction_DaysBindingSource.DataSource = Me.DSCalculateSalary
        '
        'View_Emp_Deduction_DaysTableAdapter
        '
        Me.View_Emp_Deduction_DaysTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves6BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves6BindingSource.DataMember = "tbl_PayRoll_LongLeaves6"
        Me.Tbl_PayRoll_LongLeaves6BindingSource.DataSource = Me.DSCalculateSalary
        '
        'Tbl_PayRoll_LongLeaves6TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves6TableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves8BindingSource
        '
        Me.Tbl_PayRoll_LongLeaves8BindingSource.DataSource = Me.DSCalculateSalary
        Me.Tbl_PayRoll_LongLeaves8BindingSource.Position = 0
        '
        'Tbl_PayRoll_LongLeaves8TableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves8TableAdapter.ClearBeforeFill = True
        '
        'frmSMSPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1195, 742)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComposeMsgBox)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSMSPortal"
        Me.Text = "frmSMSPortal"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCalculateSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_OverTimeSumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecord1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Deduction_DaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MonthBtn As RadioButton
    Friend WithEvents MonthndCedBtn As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComposeMsgBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DSDeptsForPayrollReport As DSDeptsForPayrollReport
    Friend WithEvents Tbl_Hrm_DepartmentsBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_DepartmentsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter
    Friend WithEvents TableAdapterManager As DSDeptsForPayrollReportTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Hrm_SubDept1TableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter
    Friend WithEvents Tbl_Hrm_SubDept1BindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_DesignationsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter
    Friend WithEvents Tbl_Hrm_DesignationsBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents RadioButton16 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents RadioButton19 As RadioButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents View_Rpt_Acc_PreSalaryBindingSource As BindingSource
    Friend WithEvents View_Rpt_Acc_PreSalaryTableAdapter As DSDeptsForPayrollReportTableAdapters.View_Rpt_Acc_PreSalaryTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CardNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeptNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DesigNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RadioUrdu As RadioButton
    Friend WithEvents RadioEnglish As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents DSCalculateSalary As DSCalculateSalary
    Friend WithEvents View_Rpt_Acc_OverTimeSumBindingSource As BindingSource
    Friend WithEvents View_Rpt_Acc_OverTimeSumTableAdapter As DSCalculateSalaryTableAdapters.View_Rpt_Acc_OverTimeSumTableAdapter
    Friend WithEvents TableAdapterManager1 As DSCalculateSalaryTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_PayRoll_LongLeaves4BindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves4TableAdapter As DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves4TableAdapter
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents EmpIDToolStripLabel As ToolStripLabel
    Friend WithEvents EmpIDToolStripTextBox As ToolStripTextBox
    Friend WithEvents FinancialPeriodToolStripLabel As ToolStripLabel
    Friend WithEvents FinancialPeriodToolStripTextBox As ToolStripTextBox
    Friend WithEvents Param3ToolStripLabel As ToolStripLabel
    Friend WithEvents Param3ToolStripTextBox As ToolStripTextBox
    Friend WithEvents Param4ToolStripLabel As ToolStripLabel
    Friend WithEvents Param4ToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecordBindingSource As BindingSource
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecordTableAdapter As DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecordTableAdapter
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecord1BindingSource As BindingSource
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecord1TableAdapter As DSCalculateSalaryTableAdapters.View_Rpt_PayRoll_EmpAttRecord1TableAdapter
    Friend WithEvents Tbl_Hrm_HolidaysBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_HolidaysTableAdapter As DSCalculateSalaryTableAdapters.tbl_Hrm_HolidaysTableAdapter
    Friend WithEvents View_Emp_Deduction_DaysBindingSource As BindingSource
    Friend WithEvents View_Emp_Deduction_DaysTableAdapter As DSCalculateSalaryTableAdapters.View_Emp_Deduction_DaysTableAdapter
    Friend WithEvents FinancialPeriodComboBox As ComboBox
    Friend WithEvents Tbl_PayRoll_LongLeaves6BindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves6TableAdapter As DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves6TableAdapter
    Friend WithEvents Tbl_PayRoll_LongLeaves8BindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves8TableAdapter As DSCalculateSalaryTableAdapters.tbl_PayRoll_LongLeaves8TableAdapter
End Class
