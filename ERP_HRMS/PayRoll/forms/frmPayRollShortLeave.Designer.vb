<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayRollShortLeave
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
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPayRollShortLeave))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.View_All_EmployeesTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_All_EmployeesTableAdapter()
        Me.DSPayRoll = New ERP_HRMS.DSPayRoll()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_All_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_AttTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_CardTableAdapter()
        Me.Tbl_HRM_Card1TableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_Card1TableAdapter()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.Tbl_HRM_Card2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card2TableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_Card2TableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EmpStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CardNoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_PayRoll_ShortLeavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_ShortLeavesTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_PayRoll_ShortLeavesTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.CanclToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_PayRoll_ShortLeavesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_HRM_Leave_ReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_Leave_ReasonTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_Leave_ReasonTableAdapter()
        Me.EmpIDLabel1 = New System.Windows.Forms.Label()
        Me.ShiftIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        CardNoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Tbl_PayRoll_ShortLeavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.Tbl_PayRoll_ShortLeavesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(284, 7)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(70, 18)
        Label1.TabIndex = 25
        Label1.Text = "Emp Status:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DesigNameLabel
        '
        DesigNameLabel.Location = New System.Drawing.Point(5, 74)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(66, 18)
        DesigNameLabel.TabIndex = 34
        DesigNameLabel.Text = "Section:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptNameLabel
        '
        DeptNameLabel.Location = New System.Drawing.Point(5, 51)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(66, 18)
        DeptNameLabel.TabIndex = 36
        DeptNameLabel.Text = "Department:"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel
        '
        CardNoLabel.Location = New System.Drawing.Point(5, 7)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(66, 18)
        CardNoLabel.TabIndex = 31
        CardNoLabel.Text = "Card No:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel
        '
        NameLabel.Location = New System.Drawing.Point(5, 28)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(66, 18)
        NameLabel.TabIndex = 32
        NameLabel.Text = "Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'View_All_EmployeesTableAdapter
        '
        Me.View_All_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'DSPayRoll
        '
        Me.DSPayRoll.DataSetName = "DSPayRoll"
        Me.DSPayRoll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Hrm_Emp_AttBindingSource
        '
        Me.Tbl_Hrm_Emp_AttBindingSource.DataMember = "tbl_Hrm_Emp_Att"
        Me.Tbl_Hrm_Emp_AttBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_Card1BindingSource
        '
        Me.Tbl_HRM_Card1BindingSource.DataMember = "tbl_HRM_Card1"
        Me.Tbl_HRM_Card1BindingSource.DataSource = Me.DSPayRoll
        '
        'View_All_EmployeesBindingSource
        '
        Me.View_All_EmployeesBindingSource.DataMember = "View_All_Employees"
        Me.View_All_EmployeesBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_Hrm_Emp_AttTableAdapter
        '
        Me.Tbl_Hrm_Emp_AttTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_AnnualLeaveTransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Att_DeviceSpecialTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Att_DeviceTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Cont_AttTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Att_VisitTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_AttTableAdapter = Me.Tbl_Hrm_Emp_AttTableAdapter
        Me.TableAdapterManager.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Shift1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PayRoll_LongLeavesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PayRoll_ShortLeavesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Card1TableAdapter
        '
        Me.Tbl_HRM_Card1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_ShiftTableAdapter
        '
        Me.Tbl_HRM_ShiftTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Card2BindingSource
        '
        Me.Tbl_HRM_Card2BindingSource.DataMember = "tbl_HRM_Card2"
        Me.Tbl_HRM_Card2BindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_Card2TableAdapter
        '
        Me.Tbl_HRM_Card2TableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(2, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 161)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.View_All_EmployeesBindingSource, "EmpPic", True))
        Me.PictureBox1.Location = New System.Drawing.Point(853, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Label1)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.EmpStatusCheckBox)
        Me.Panel6.Controls.Add(Me.NameLabel1)
        Me.Panel6.Controls.Add(DesigNameLabel)
        Me.Panel6.Controls.Add(DeptNameLabel)
        Me.Panel6.Controls.Add(Me.CardNoLabel1)
        Me.Panel6.Controls.Add(CardNoLabel)
        Me.Panel6.Controls.Add(Me.DeptNameLabel1)
        Me.Panel6.Controls.Add(NameLabel)
        Me.Panel6.Controls.Add(Me.DesigNameLabel1)
        Me.Panel6.Location = New System.Drawing.Point(451, 28)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(396, 122)
        Me.Panel6.TabIndex = 42
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_EmployeesBindingSource, "GradeName", True))
        Me.Label20.Location = New System.Drawing.Point(214, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 18)
        Me.Label20.TabIndex = 45
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(147, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 20)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Grade:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(252, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 20)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "D.O.J:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_EmployeesBindingSource, "DateOfJoning", True))
        Me.Label16.Location = New System.Drawing.Point(293, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 20)
        Me.Label16.TabIndex = 42
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(5, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Designation:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_EmployeesBindingSource, "DesigName", True))
        Me.Label13.Location = New System.Drawing.Point(73, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 20)
        Me.Label13.TabIndex = 40
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpStatusCheckBox
        '
        Me.EmpStatusCheckBox.AutoCheck = False
        Me.EmpStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.View_All_EmployeesBindingSource, "EmpStatus", True))
        Me.EmpStatusCheckBox.Location = New System.Drawing.Point(355, 9)
        Me.EmpStatusCheckBox.Name = "EmpStatusCheckBox"
        Me.EmpStatusCheckBox.Size = New System.Drawing.Size(17, 17)
        Me.EmpStatusCheckBox.TabIndex = 26
        '
        'NameLabel1
        '
        Me.NameLabel1.BackColor = System.Drawing.Color.White
        Me.NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_EmployeesBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(73, 28)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(309, 20)
        Me.NameLabel1.TabIndex = 35
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.BackColor = System.Drawing.Color.White
        Me.CardNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_EmployeesBindingSource, "CardNo", True))
        Me.CardNoLabel1.Location = New System.Drawing.Point(73, 7)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(60, 18)
        Me.CardNoLabel1.TabIndex = 33
        Me.CardNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_EmployeesBindingSource, "SectionName", True))
        Me.DeptNameLabel1.Location = New System.Drawing.Point(73, 74)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(309, 20)
        Me.DeptNameLabel1.TabIndex = 38
        Me.DeptNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.Color.White
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_EmployeesBindingSource, "DeptName", True))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(73, 51)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(309, 20)
        Me.DesigNameLabel1.TabIndex = 37
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.DateTimePicker3)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.DateTimePicker2)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.CardNoComboBox)
        Me.Panel4.Location = New System.Drawing.Point(3, 28)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(442, 105)
        Me.Panel4.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(215, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Entry Date:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(282, 7)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker3.TabIndex = 53
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(249, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(175, 30)
        Me.btnSave.TabIndex = 52
        Me.btnSave.Text = "Save Entry"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yy HH:mm"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(282, 33)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker2.TabIndex = 51
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(75, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(134, 20)
        Me.DateTimePicker1.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Card No.:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "From Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(215, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "To Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.Tbl_HRM_CardBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(75, 6)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(134, 21)
        Me.CardNoComboBox.TabIndex = 39
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1073, 25)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Select Appropriate Option to Filter Records"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(1083, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "To Card:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'CardNoComboBox1
        '
        Me.CardNoComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox1.FormattingEnabled = True
        Me.CardNoComboBox1.Location = New System.Drawing.Point(1083, 71)
        Me.CardNoComboBox1.Name = "CardNoComboBox1"
        Me.CardNoComboBox1.Size = New System.Drawing.Size(142, 21)
        Me.CardNoComboBox1.TabIndex = 40
        Me.CardNoComboBox1.Visible = False
        '
        'Tbl_PayRoll_ShortLeavesBindingSource
        '
        Me.Tbl_PayRoll_ShortLeavesBindingSource.DataMember = "tbl_PayRoll_ShortLeaves"
        Me.Tbl_PayRoll_ShortLeavesBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_PayRoll_ShortLeavesTableAdapter
        '
        Me.Tbl_PayRoll_ShortLeavesTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator3)
        Me.Panel2.Controls.Add(Me.Tbl_PayRoll_ShortLeavesDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(2, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 620)
        Me.Panel2.TabIndex = 11
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.ToolStripButton15
        Me.BindingNavigator3.BindingSource = Me.Tbl_PayRoll_ShortLeavesBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel3
        Me.BindingNavigator3.DeleteItem = Nothing
        Me.BindingNavigator3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton16, Me.ToolStripButton17, Me.ToolStripSeparator10, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator11, Me.ToolStripButton18, Me.ToolStripButton19, Me.ToolStripSeparator12, Me.ToolStripButton15, Me.ToolStripButton20, Me.ToolStripSeparator13, Me.CanclToolStripButton})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton16
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton19
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton18
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton17
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox3
        Me.BindingNavigator3.Size = New System.Drawing.Size(1073, 27)
        Me.BindingNavigator3.TabIndex = 16
        Me.BindingNavigator3.Text = "BindingNavigator1"
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton15.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton15.Text = "Add new"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(35, 24)
        Me.ToolStripLabel3.Text = "of {0}"
        Me.ToolStripLabel3.ToolTipText = "Total number of items"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton16.Text = "Move first"
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton17.Text = "Move previous"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Position"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Current position"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton18.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton18.Text = "Move next"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton19.Text = "Move last"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton20.Text = "Save Data"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 27)
        '
        'CanclToolStripButton
        '
        Me.CanclToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CanclToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.images__1_
        Me.CanclToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CanclToolStripButton.Name = "CanclToolStripButton"
        Me.CanclToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.CanclToolStripButton.Text = "&New"
        Me.CanclToolStripButton.Visible = False
        '
        'Tbl_PayRoll_ShortLeavesDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tbl_PayRoll_ShortLeavesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_PayRoll_ShortLeavesDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_PayRoll_ShortLeavesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_PayRoll_ShortLeavesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_PayRoll_ShortLeavesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37, Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42, Me.DataGridViewTextBoxColumn43})
        Me.Tbl_PayRoll_ShortLeavesDataGridView.DataSource = Me.Tbl_PayRoll_ShortLeavesBindingSource
        Me.Tbl_PayRoll_ShortLeavesDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_PayRoll_ShortLeavesDataGridView.Name = "Tbl_PayRoll_ShortLeavesDataGridView"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_PayRoll_ShortLeavesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.Tbl_PayRoll_ShortLeavesDataGridView.RowHeadersWidth = 22
        Me.Tbl_PayRoll_ShortLeavesDataGridView.Size = New System.Drawing.Size(1067, 587)
        Me.Tbl_PayRoll_ShortLeavesDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "SLID"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Serial No"
        Me.DataGridViewTextBoxColumn35.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        Me.DataGridViewTextBoxColumn35.Visible = False
        Me.DataGridViewTextBoxColumn35.Width = 2
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn34.DataSource = Me.Tbl_HRM_Card2BindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewTextBoxColumn34.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn34.DisplayMember = "CardNo"
        Me.DataGridViewTextBoxColumn34.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn34.HeaderText = "Card No"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn34.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn34.ValueMember = "EmpID"
        Me.DataGridViewTextBoxColumn34.Width = 90
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "CardNo"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Card No"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "LeaveDate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn37.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn37.HeaderText = "Leave Date"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "StartTime"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Format = "t"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn38.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn38.HeaderText = "Start Time"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "EndTime"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Format = "t"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn39.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn39.HeaderText = "End Time"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "ShiftID"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn40.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn40.HeaderText = "Shift No."
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        Me.DataGridViewTextBoxColumn40.Visible = False
        Me.DataGridViewTextBoxColumn40.Width = 70
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "HOD"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn41.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn41.HeaderText = "Approved By"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        Me.DataGridViewTextBoxColumn41.Width = 150
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "ReasonID"
        Me.DataGridViewTextBoxColumn42.DataSource = Me.Tbl_HRM_Leave_ReasonBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn42.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn42.DisplayMember = "Reason"
        Me.DataGridViewTextBoxColumn42.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn42.HeaderText = "Reason"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        Me.DataGridViewTextBoxColumn42.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn42.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn42.ValueMember = "ReasonID"
        Me.DataGridViewTextBoxColumn42.Width = 150
        '
        'Tbl_HRM_Leave_ReasonBindingSource
        '
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataMember = "tbl_HRM_Leave_Reason"
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataSource = Me.DSPayRoll
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn43.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 250
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1290, 39)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Employee Short Leave Management"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_HRM_Leave_ReasonTableAdapter
        '
        Me.Tbl_HRM_Leave_ReasonTableAdapter.ClearBeforeFill = True
        '
        'EmpIDLabel1
        '
        Me.EmpIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_CardBindingSource, "EmpID", True))
        Me.EmpIDLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EmpIDLabel1.Location = New System.Drawing.Point(1083, 126)
        Me.EmpIDLabel1.Name = "EmpIDLabel1"
        Me.EmpIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.EmpIDLabel1.TabIndex = 46
        Me.EmpIDLabel1.Text = "Label6"
        '
        'ShiftIDLabel
        '
        Me.ShiftIDLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_EmployeesBindingSource, "ShiftID", True))
        Me.ShiftIDLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ShiftIDLabel.Location = New System.Drawing.Point(1080, 180)
        Me.ShiftIDLabel.Name = "ShiftIDLabel"
        Me.ShiftIDLabel.Size = New System.Drawing.Size(100, 23)
        Me.ShiftIDLabel.TabIndex = 47
        Me.ShiftIDLabel.Text = "Label6"
        '
        'frmPayRollShortLeave
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1290, 919)
        Me.Controls.Add(Me.ShiftIDLabel)
        Me.Controls.Add(Me.EmpIDLabel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CardNoComboBox1)
        Me.Name = "frmPayRollShortLeave"
        Me.Text = "frmPayRollShortLeave"
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.Tbl_PayRoll_ShortLeavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.Tbl_PayRoll_ShortLeavesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents View_All_EmployeesTableAdapter As DSPayRollTableAdapters.View_All_EmployeesTableAdapter
    Friend WithEvents DSPayRoll As DSPayRoll
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card1BindingSource As BindingSource
    Friend WithEvents View_All_EmployeesBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents TableAdapterManager As DSPayRollTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSPayRollTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSPayRollTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents Tbl_HRM_Card1TableAdapter As DSPayRollTableAdapters.tbl_HRM_Card1TableAdapter
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSPayRollTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents Tbl_HRM_Card2BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card2TableAdapter As DSPayRollTableAdapters.tbl_HRM_Card2TableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents EmpStatusCheckBox As CheckBox
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents CardNoLabel1 As Label
    Friend WithEvents DeptNameLabel1 As Label
    Friend WithEvents DesigNameLabel1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CardNoComboBox1 As ComboBox
    Friend WithEvents CardNoComboBox As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Tbl_PayRoll_ShortLeavesBindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_ShortLeavesTableAdapter As DSPayRollTableAdapters.tbl_PayRoll_ShortLeavesTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tbl_PayRoll_ShortLeavesDataGridView As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripButton16 As ToolStripButton
    Friend WithEvents ToolStripButton17 As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripButton18 As ToolStripButton
    Friend WithEvents ToolStripButton19 As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripButton20 As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents CanclToolStripButton As ToolStripButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewComboBoxColumn
    Friend WithEvents Tbl_HRM_Leave_ReasonBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_HRM_Leave_ReasonTableAdapter As DSPayRollTableAdapters.tbl_HRM_Leave_ReasonTableAdapter
    Friend WithEvents EmpIDLabel1 As Label
    Friend WithEvents ShiftIDLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
End Class
