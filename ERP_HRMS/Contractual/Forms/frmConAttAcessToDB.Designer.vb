<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConAttAcessToDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConAttAcessToDB))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Att_DeviceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPayRoll = New ERP_HRMS.DSPayRoll()
        Me.Tbl_Att_DeviceTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Att_DeviceTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager()
        Me.View_All_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_All_EmployeesTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_All_EmployeesTableAdapter()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_AttTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.Att2003DataSet = New ERP_HRMS.Att2003DataSet()
        Me.CheckinoutBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckinoutTableAdapter1 = New ERP_HRMS.Att2003DataSetTableAdapters.CheckinoutTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.Att2003DataSetTableAdapters.TableAdapterManager()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckinoutBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripProgressBar2 = New System.Windows.Forms.ToolStripProgressBar()
        Me.CHECKINOUTDataGridView = New System.Windows.Forms.DataGridView()
        Me.UseridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CHECKINOUTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Att2000DataSet = New ERP_HRMS.att2000DataSet()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CHECKINOUTTableAdapter = New ERP_HRMS.att2000DataSetTableAdapters.CHECKINOUTTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.att2000DataSetTableAdapters.TableAdapterManager()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Att_DeviceSpecialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Att_DeviceSpecialTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Att_DeviceSpecialTableAdapter()
        Me.DSDevice = New ERP_HRMS.DSDevice()
        Me.Tbl_Att_DeviceSpecial_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Att_DeviceSpecial_NewTableAdapter = New ERP_HRMS.DSDeviceTableAdapters.tbl_Att_DeviceSpecial_NewTableAdapter()
        Me.TableAdapterManager3 = New ERP_HRMS.DSDeviceTableAdapters.TableAdapterManager()
        Me.Tbl_Hrm_Cont_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Cont_AttTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Hrm_Cont_AttTableAdapter()
        Me.View_All_ContBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_All_ContTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_All_ContTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Tbl_Att_DeviceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Att2003DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckinoutBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.CheckinoutBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CheckinoutBindingNavigator.SuspendLayout()
        CType(Me.CHECKINOUTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.CHECKINOUTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Att2000DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Tbl_Att_DeviceSpecialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Att_DeviceSpecial_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Cont_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_All_ContBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(722, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(211, 629)
        Me.Panel2.TabIndex = 94
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 514)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 20)
        Me.Label14.TabIndex = 88
        Me.Label14.Text = "C:\standard\Att2003"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 498)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Source Path:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Location = New System.Drawing.Point(12, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(179, 59)
        Me.Panel3.TabIndex = 84
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(3, 30)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(167, 22)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "ZKTeco"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(3, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(167, 22)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Anviz"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 45)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Transfer Attendance"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(52, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 20)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Error Records"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(21, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(53, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Saved Records"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.ForestGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(21, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(21, 239)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 39)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Log file at C:\Access Attendance Log Files\"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(363, 54)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePicker2.TabIndex = 93
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(10, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "From Date Time:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(280, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "To Date Time:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(154, 20)
        Me.DateTimePicker1.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1256, 40)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Attendance Access To DB Transfer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(523, 56)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 97
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "By Divice No:"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(1049, 216)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton3.TabIndex = 96
        Me.RadioButton3.Text = "All Record"
        Me.RadioButton3.UseVisualStyleBackColor = True
        Me.RadioButton3.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_Att_DeviceBindingSource
        Me.ComboBox1.DisplayMember = "DeviceNo"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Maroon
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(617, 54)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox1.TabIndex = 95
        Me.ComboBox1.ValueMember = "DeviceNo"
        '
        'Tbl_Att_DeviceBindingSource
        '
        Me.Tbl_Att_DeviceBindingSource.DataMember = "tbl_Att_Device"
        Me.Tbl_Att_DeviceBindingSource.DataSource = Me.DSPayRoll
        '
        'DSPayRoll
        '
        Me.DSPayRoll.DataSetName = "DSPayRoll"
        Me.DSPayRoll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Att_DeviceTableAdapter
        '
        Me.Tbl_Att_DeviceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Acc_AnnualLeaveTransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Att_DeviceSpecialTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Att_DeviceTableAdapter = Me.Tbl_Att_DeviceTableAdapter
        Me.TableAdapterManager1.tbl_Hrm_Cont_AttTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_AttTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Shift1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_PayRoll_LongLeavesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_PayRoll_ShortLeavesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_All_EmployeesBindingSource
        '
        Me.View_All_EmployeesBindingSource.DataMember = "View_All_Employees"
        Me.View_All_EmployeesBindingSource.DataSource = Me.DSPayRoll
        '
        'View_All_EmployeesTableAdapter
        '
        Me.View_All_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_AttBindingSource
        '
        Me.Tbl_Hrm_Emp_AttBindingSource.DataMember = "tbl_Hrm_Emp_Att"
        Me.Tbl_Hrm_Emp_AttBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_Hrm_Emp_AttTableAdapter
        '
        Me.Tbl_Hrm_Emp_AttTableAdapter.ClearBeforeFill = True
        '
        'Att2003DataSet
        '
        Me.Att2003DataSet.DataSetName = "Att2003DataSet"
        Me.Att2003DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckinoutBindingSource1
        '
        Me.CheckinoutBindingSource1.DataMember = "Checkinout"
        Me.CheckinoutBindingSource1.DataSource = Me.Att2003DataSet
        '
        'CheckinoutTableAdapter1
        '
        Me.CheckinoutTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.CheckinoutTableAdapter = Me.CheckinoutTableAdapter1
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.Att2003DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(697, 626)
        Me.TabControl1.TabIndex = 98
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(670, 618)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Anviz"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(664, 22)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "ANVIZ "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Sienna
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckinoutBindingNavigator)
        Me.Panel1.Controls.Add(Me.CHECKINOUTDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(4, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 590)
        Me.Panel1.TabIndex = 90
        '
        'CheckinoutBindingNavigator
        '
        Me.CheckinoutBindingNavigator.AddNewItem = Nothing
        Me.CheckinoutBindingNavigator.BindingSource = Me.CheckinoutBindingSource1
        Me.CheckinoutBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CheckinoutBindingNavigator.DeleteItem = Nothing
        Me.CheckinoutBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripProgressBar2})
        Me.CheckinoutBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CheckinoutBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CheckinoutBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CheckinoutBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CheckinoutBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CheckinoutBindingNavigator.Name = "CheckinoutBindingNavigator"
        Me.CheckinoutBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CheckinoutBindingNavigator.Size = New System.Drawing.Size(661, 25)
        Me.CheckinoutBindingNavigator.TabIndex = 65
        Me.CheckinoutBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'ToolStripProgressBar2
        '
        Me.ToolStripProgressBar2.AutoSize = False
        Me.ToolStripProgressBar2.Name = "ToolStripProgressBar2"
        Me.ToolStripProgressBar2.Size = New System.Drawing.Size(420, 22)
        '
        'CHECKINOUTDataGridView
        '
        Me.CHECKINOUTDataGridView.AllowUserToAddRows = False
        Me.CHECKINOUTDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHECKINOUTDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.CHECKINOUTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CHECKINOUTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UseridDataGridViewTextBoxColumn, Me.AttDate, Me.CheckTime, Me.DeviceNoDataGridViewTextBoxColumn, Me.Remarks})
        Me.CHECKINOUTDataGridView.DataSource = Me.CheckinoutBindingSource1
        Me.CHECKINOUTDataGridView.Location = New System.Drawing.Point(-1, 25)
        Me.CHECKINOUTDataGridView.Name = "CHECKINOUTDataGridView"
        Me.CHECKINOUTDataGridView.Size = New System.Drawing.Size(662, 564)
        Me.CHECKINOUTDataGridView.TabIndex = 0
        '
        'UseridDataGridViewTextBoxColumn
        '
        Me.UseridDataGridViewTextBoxColumn.DataPropertyName = "Userid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.UseridDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.UseridDataGridViewTextBoxColumn.HeaderText = "Card No"
        Me.UseridDataGridViewTextBoxColumn.Name = "UseridDataGridViewTextBoxColumn"
        '
        'AttDate
        '
        Me.AttDate.DataPropertyName = "AttDate"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AttDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.AttDate.HeaderText = "Date"
        Me.AttDate.Name = "AttDate"
        Me.AttDate.ReadOnly = True
        '
        'CheckTime
        '
        Me.CheckTime.DataPropertyName = "CheckTime"
        Me.CheckTime.HeaderText = "Time"
        Me.CheckTime.Name = "CheckTime"
        '
        'DeviceNoDataGridViewTextBoxColumn
        '
        Me.DeviceNoDataGridViewTextBoxColumn.DataPropertyName = "DeviceNo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DeviceNoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DeviceNoDataGridViewTextBoxColumn.HeaderText = "Device No"
        Me.DeviceNoDataGridViewTextBoxColumn.Name = "DeviceNoDataGridViewTextBoxColumn"
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Width = 200
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(670, 618)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ZkTeco"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(664, 22)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "ZKTeco"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.BindingNavigator1)
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Location = New System.Drawing.Point(4, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(663, 629)
        Me.Panel4.TabIndex = 0
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.CHECKINOUTBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripProgressBar1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton1
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton4
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton3
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton2
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(661, 25)
        Me.BindingNavigator1.TabIndex = 68
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'CHECKINOUTBindingSource
        '
        Me.CHECKINOUTBindingSource.DataMember = "CHECKINOUT"
        Me.CHECKINOUTBindingSource.DataSource = Me.Att2000DataSet
        '
        'Att2000DataSet
        '
        Me.Att2000DataSet.DataSetName = "att2000DataSet"
        Me.Att2000DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.AutoSize = False
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(420, 22)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.AttTime, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.DataSource = Me.CHECKINOUTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-1, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(663, 567)
        Me.DataGridView1.TabIndex = 67
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "USERID"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "Card No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AttDate"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'AttTime
        '
        Me.AttTime.DataPropertyName = "AttTime"
        Me.AttTime.HeaderText = "Time"
        Me.AttTime.Name = "AttTime"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DeviceNo"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn7.HeaderText = "Device No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TabControl1)
        Me.Panel5.Location = New System.Drawing.Point(13, 81)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(705, 633)
        Me.Panel5.TabIndex = 99
        '
        'CHECKINOUTTableAdapter
        '
        Me.CHECKINOUTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.att2000DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(1049, 308)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton1.TabIndex = 101
        Me.RadioButton1.Text = "Special Devices"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'Tbl_Att_DeviceSpecialBindingSource
        '
        Me.Tbl_Att_DeviceSpecialBindingSource.DataSource = Me.DSPayRoll
        Me.Tbl_Att_DeviceSpecialBindingSource.Position = 0
        '
        'Tbl_Att_DeviceSpecialTableAdapter
        '
        Me.Tbl_Att_DeviceSpecialTableAdapter.ClearBeforeFill = True
        '
        'DSDevice
        '
        Me.DSDevice.DataSetName = "DSDevice"
        Me.DSDevice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Att_DeviceSpecial_NewBindingSource
        '
        Me.Tbl_Att_DeviceSpecial_NewBindingSource.DataMember = "tbl_Att_DeviceSpecial_New"
        Me.Tbl_Att_DeviceSpecial_NewBindingSource.DataSource = Me.DSDevice
        '
        'Tbl_Att_DeviceSpecial_NewTableAdapter
        '
        Me.Tbl_Att_DeviceSpecial_NewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.tbl_Att_DeviceSpecial_NewTableAdapter = Me.Tbl_Att_DeviceSpecial_NewTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ERP_HRMS.DSDeviceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Hrm_Cont_AttBindingSource
        '
        Me.Tbl_Hrm_Cont_AttBindingSource.DataMember = "tbl_Hrm_Cont_Att"
        Me.Tbl_Hrm_Cont_AttBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_Hrm_Cont_AttTableAdapter
        '
        Me.Tbl_Hrm_Cont_AttTableAdapter.ClearBeforeFill = True
        '
        'View_All_ContBindingSource
        '
        Me.View_All_ContBindingSource.DataMember = "View_All_Cont"
        Me.View_All_ContBindingSource.DataSource = Me.DSPayRoll
        '
        'View_All_ContTableAdapter
        '
        Me.View_All_ContTableAdapter.ClearBeforeFill = True
        '
        'frmConAttAcessToDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1256, 817)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmConAttAcessToDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendence Acess To DB"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.Tbl_Att_DeviceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Att2003DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckinoutBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CheckinoutBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CheckinoutBindingNavigator.ResumeLayout(False)
        Me.CheckinoutBindingNavigator.PerformLayout()
        CType(Me.CHECKINOUTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.CHECKINOUTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Att2000DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.Tbl_Att_DeviceSpecialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDevice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Att_DeviceSpecial_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Cont_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_All_ContBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Att2000DataSet As att2000DataSet
    Friend WithEvents CHECKINOUTBindingSource As BindingSource
    Friend WithEvents CHECKINOUTTableAdapter As att2000DataSetTableAdapters.CHECKINOUTTableAdapter
    Friend WithEvents TableAdapterManager As att2000DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DSPayRoll As DSPayRoll
    Friend WithEvents Tbl_Att_DeviceBindingSource As BindingSource
    Friend WithEvents Tbl_Att_DeviceTableAdapter As DSPayRollTableAdapters.tbl_Att_DeviceTableAdapter
    Friend WithEvents TableAdapterManager1 As DSPayRollTableAdapters.TableAdapterManager
    Friend WithEvents View_All_EmployeesBindingSource As BindingSource
    Friend WithEvents View_All_EmployeesTableAdapter As DSPayRollTableAdapters.View_All_EmployeesTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Att2003DataSet As Att2003DataSet
    Friend WithEvents CheckinoutBindingSource1 As BindingSource
    Friend WithEvents CheckinoutTableAdapter1 As Att2003DataSetTableAdapters.CheckinoutTableAdapter
    Friend WithEvents TableAdapterManager2 As Att2003DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckinoutBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripProgressBar2 As ToolStripProgressBar
    Friend WithEvents CHECKINOUTDataGridView As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttDate As DataGridViewTextBoxColumn
    Friend WithEvents CheckTime As DataGridViewTextBoxColumn
    Friend WithEvents DeviceNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents AttTime As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Tbl_Att_DeviceSpecialBindingSource As BindingSource
    Friend WithEvents Tbl_Att_DeviceSpecialTableAdapter As DSPayRollTableAdapters.tbl_Att_DeviceSpecialTableAdapter
    Friend WithEvents DSDevice As DSDevice
    Friend WithEvents Tbl_Att_DeviceSpecial_NewBindingSource As BindingSource
    Friend WithEvents Tbl_Att_DeviceSpecial_NewTableAdapter As DSDeviceTableAdapters.tbl_Att_DeviceSpecial_NewTableAdapter
    Friend WithEvents TableAdapterManager3 As DSDeviceTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Hrm_Cont_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Cont_AttTableAdapter As DSPayRollTableAdapters.tbl_Hrm_Cont_AttTableAdapter
    Friend WithEvents View_All_ContBindingSource As BindingSource
    Friend WithEvents View_All_ContTableAdapter As DSPayRollTableAdapters.View_All_ContTableAdapter
End Class
