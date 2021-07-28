<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBoofeMealAttendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBoofeMealAttendance))
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeviceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_Meal_Att_Management_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBuffetAttendance = New ERP_HRMS.DSBuffetAttendance()
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
        Me.View_Meal_Att_ManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CHECKINOUT_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DSDisplayEI = New ERP_HRMS.DSDisplayEI()
        Me.View_Att_EmpVerifyTableAdapter = New ERP_HRMS.DSDisplayEITableAdapters.View_Att_EmpVerifyTableAdapter()
        Me.View_Att_EmpVerifyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Display_EmpInfoTableAdapter = New ERP_HRMS.DSDisplayEITableAdapters.View_Display_EmpInfoTableAdapter()
        Me.View_Display_EmpInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAutoAtt = New ERP_HRMS.DSAutoAtt()
        Me.Tbl_Hrm_Emp_Att1TableAdapter = New ERP_HRMS.DSAutoAttTableAdapters.tbl_Hrm_Emp_Att1TableAdapter()
        Me.Tbl_Hrm_Emp_Att1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_AttTableAdapter = New ERP_HRMS.DSAutoAttTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.View_Rpt_HR_ActiveCardCopyTableAdapter = New ERP_HRMS.DSAutoAttTableAdapters.View_Rpt_HR_ActiveCardCopyTableAdapter()
        Me.View_Rpt_HR_ActiveCardCopyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Att_Client1_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Att_MealBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Att_MealTableAdapter = New ERP_HRMS.DSAutoAttTableAdapters.tbl_HRM_Emp_Att_MealTableAdapter()
        Me.CheckinoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Meal_Att_Management_NewTableAdapter = New ERP_HRMS.DSBuffetAttendanceTableAdapters.View_Meal_Att_Management_NewTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSBuffetAttendanceTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Emp_Att_MealBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Att_MealTableAdapter1 = New ERP_HRMS.DSBuffetAttendanceTableAdapters.tbl_HRM_Emp_Att_MealTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Meal_Att_Management_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBuffetAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckinoutBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CheckinoutBindingNavigator.SuspendLayout()
        CType(Me.View_Meal_Att_ManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CHECKINOUT_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DSDisplayEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Att_EmpVerifyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Display_EmpInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAutoAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Att1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_HR_ActiveCardCopyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Att_Client1_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Att_MealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckinoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Att_MealBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(426, 45)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(167, 20)
        Me.DateTimePicker2.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(344, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "To Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy "
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(171, 45)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(167, 20)
        Me.DateTimePicker1.TabIndex = 88
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(78, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 20)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "From Date:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1023, 40)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Buffet Attendance Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.CheckinoutBindingNavigator)
        Me.Panel1.Location = New System.Drawing.Point(6, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 597)
        Me.Panel1.TabIndex = 94
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.USERID, Me.AttDate, Me.AttTime, Me.Type, Me.DeviceNo, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.UserIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.View_Meal_Att_Management_NewBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Location = New System.Drawing.Point(1, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(680, 567)
        Me.DataGridView1.TabIndex = 64
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ID.HeaderText = "Sr.No."
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 70
        '
        'USERID
        '
        Me.USERID.DataPropertyName = "USERID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.USERID.DefaultCellStyle = DataGridViewCellStyle3
        Me.USERID.HeaderText = "Card No."
        Me.USERID.Name = "USERID"
        Me.USERID.ReadOnly = True
        '
        'AttDate
        '
        Me.AttDate.DataPropertyName = "AttDate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        Me.AttDate.DefaultCellStyle = DataGridViewCellStyle4
        Me.AttDate.HeaderText = "Att Date"
        Me.AttDate.Name = "AttDate"
        Me.AttDate.ReadOnly = True
        Me.AttDate.Width = 110
        '
        'AttTime
        '
        Me.AttTime.DataPropertyName = "AttTime"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AttTime.DefaultCellStyle = DataGridViewCellStyle5
        Me.AttTime.HeaderText = "Att Time"
        Me.AttTime.Name = "AttTime"
        Me.AttTime.ReadOnly = True
        Me.AttTime.Width = 130
        '
        'Type
        '
        Me.Type.DataPropertyName = "Type"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Type.DefaultCellStyle = DataGridViewCellStyle6
        Me.Type.HeaderText = "In/Out Status"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'DeviceNo
        '
        Me.DeviceNo.DataPropertyName = "DeviceNo"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DeviceNo.DefaultCellStyle = DataGridViewCellStyle7
        Me.DeviceNo.HeaderText = "System #"
        Me.DeviceNo.Name = "DeviceNo"
        Me.DeviceNo.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AttTime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AttTime"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DeviceNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DeviceNo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AttDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "AttDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'View_Meal_Att_Management_NewBindingSource
        '
        Me.View_Meal_Att_Management_NewBindingSource.DataMember = "View_Meal_Att_Management_New"
        Me.View_Meal_Att_Management_NewBindingSource.DataSource = Me.DSBuffetAttendance
        '
        'DSBuffetAttendance
        '
        Me.DSBuffetAttendance.DataSetName = "DSBuffetAttendance"
        Me.DSBuffetAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckinoutBindingNavigator
        '
        Me.CheckinoutBindingNavigator.AddNewItem = Nothing
        Me.CheckinoutBindingNavigator.BindingSource = Me.View_Meal_Att_Management_NewBindingSource
        Me.CheckinoutBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CheckinoutBindingNavigator.DeleteItem = Nothing
        Me.CheckinoutBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.CheckinoutBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CheckinoutBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CheckinoutBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CheckinoutBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CheckinoutBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CheckinoutBindingNavigator.Name = "CheckinoutBindingNavigator"
        Me.CheckinoutBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CheckinoutBindingNavigator.Size = New System.Drawing.Size(683, 25)
        Me.CheckinoutBindingNavigator.TabIndex = 64
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
        'View_Meal_Att_ManagementBindingSource
        '
        Me.View_Meal_Att_ManagementBindingSource.DataMember = "View_Meal_Att_Management"
        '
        'CHECKINOUT_1BindingSource
        '
        Me.CHECKINOUT_1BindingSource.DataMember = "CHECKINOUT_1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(697, 154)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(217, 229)
        Me.Panel2.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.ForestGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(10, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(9, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 38)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "If Any Error Check Log file at C:\Sports Canteen Access Attendance Log Files\"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(10, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(195, 69)
        Me.Button2.TabIndex = 92
        Me.Button2.Text = "Transfer Canteen Attendance"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(36, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Saved Records"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(10, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(36, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 20)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Error Records"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Maroon
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(10, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 20)
        Me.Label6.TabIndex = 83
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(36, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 20)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Already Saved Records"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(697, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 69)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Transfer Attendance"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Maroon
        Me.RadioButton2.ForeColor = System.Drawing.Color.Yellow
        Me.RadioButton2.Location = New System.Drawing.Point(709, 487)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(100, 17)
        Me.RadioButton2.TabIndex = 91
        Me.RadioButton2.Text = "Attendance Out"
        Me.RadioButton2.UseVisualStyleBackColor = False
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Maroon
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(709, 464)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton1.TabIndex = 90
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Attendance In"
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'DSDisplayEI
        '
        Me.DSDisplayEI.DataSetName = "DSDisplayEI"
        Me.DSDisplayEI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Att_EmpVerifyTableAdapter
        '
        Me.View_Att_EmpVerifyTableAdapter.ClearBeforeFill = True
        '
        'View_Att_EmpVerifyBindingSource
        '
        Me.View_Att_EmpVerifyBindingSource.DataMember = "View_Att_EmpVerify"
        Me.View_Att_EmpVerifyBindingSource.DataSource = Me.DSDisplayEI
        '
        'View_Display_EmpInfoTableAdapter
        '
        Me.View_Display_EmpInfoTableAdapter.ClearBeforeFill = True
        '
        'View_Display_EmpInfoBindingSource
        '
        Me.View_Display_EmpInfoBindingSource.DataMember = "View_Display_EmpInfo"
        Me.View_Display_EmpInfoBindingSource.DataSource = Me.DSDisplayEI
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 820)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1023, 22)
        Me.StatusStrip1.TabIndex = 98
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(250, 16)
        Me.ToolStripProgressBar1.Step = 1
        '
        'Tbl_Hrm_Emp_AttBindingSource
        '
        Me.Tbl_Hrm_Emp_AttBindingSource.DataMember = "tbl_Hrm_Emp_Att"
        Me.Tbl_Hrm_Emp_AttBindingSource.DataSource = Me.DSAutoAtt
        '
        'DSAutoAtt
        '
        Me.DSAutoAtt.DataSetName = "DSAutoAtt"
        Me.DSAutoAtt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Hrm_Emp_Att1TableAdapter
        '
        Me.Tbl_Hrm_Emp_Att1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Att1BindingSource
        '
        Me.Tbl_Hrm_Emp_Att1BindingSource.DataMember = "tbl_Hrm_Emp_Att1"
        Me.Tbl_Hrm_Emp_Att1BindingSource.DataSource = Me.DSAutoAtt
        '
        'Tbl_Hrm_Emp_AttTableAdapter
        '
        Me.Tbl_Hrm_Emp_AttTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_HR_ActiveCardCopyTableAdapter
        '
        Me.View_Rpt_HR_ActiveCardCopyTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_HR_ActiveCardCopyBindingSource
        '
        Me.View_Rpt_HR_ActiveCardCopyBindingSource.DataMember = "View_Rpt_HR_ActiveCardCopy"
        Me.View_Rpt_HR_ActiveCardCopyBindingSource.DataSource = Me.DSAutoAtt
        '
        'Tbl_Hrm_Emp_Att_Client1_1BindingSource
        '
        Me.Tbl_Hrm_Emp_Att_Client1_1BindingSource.DataMember = "tbl_Hrm_Emp_Att_Client1_1"
        Me.Tbl_Hrm_Emp_Att_Client1_1BindingSource.DataSource = Me.DSAutoAtt
        '
        'Tbl_HRM_Emp_Att_MealBindingSource
        '
        Me.Tbl_HRM_Emp_Att_MealBindingSource.DataMember = "tbl_HRM_Emp_Att_Meal"
        Me.Tbl_HRM_Emp_Att_MealBindingSource.DataSource = Me.DSAutoAtt
        '
        'Tbl_HRM_Emp_Att_MealTableAdapter
        '
        Me.Tbl_HRM_Emp_Att_MealTableAdapter.ClearBeforeFill = True
        '
        'CheckinoutBindingSource
        '
        Me.CheckinoutBindingSource.DataMember = "Checkinout"
        '
        'View_Meal_Att_Management_NewTableAdapter
        '
        Me.View_Meal_Att_Management_NewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_Att_MealTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSBuffetAttendanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_Emp_Att_MealBindingSource1
        '
        Me.Tbl_HRM_Emp_Att_MealBindingSource1.DataMember = "tbl_HRM_Emp_Att_Meal"
        Me.Tbl_HRM_Emp_Att_MealBindingSource1.DataSource = Me.DSBuffetAttendance
        '
        'Tbl_HRM_Emp_Att_MealTableAdapter1
        '
        Me.Tbl_HRM_Emp_Att_MealTableAdapter1.ClearBeforeFill = True
        '
        'frmBoofeMealAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 842)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label13)
        Me.Name = "frmBoofeMealAttendance"
        Me.Text = "Buffet Attendance Entry"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Meal_Att_Management_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBuffetAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckinoutBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CheckinoutBindingNavigator.ResumeLayout(False)
        Me.CheckinoutBindingNavigator.PerformLayout()
        CType(Me.View_Meal_Att_ManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CHECKINOUT_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DSDisplayEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Att_EmpVerifyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Display_EmpInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAutoAtt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Att1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_HR_ActiveCardCopyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Att_Client1_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Att_MealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckinoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Att_MealBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSAccessToDB As ERP_HRMS.DsAccessToDB
    Friend WithEvents CheckinoutBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckinoutTableAdapter As ERP_HRMS.DsAccessToDBTableAdapters.CheckinoutTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DsAccessToDBTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CheckinoutBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DSDisplayEI As ERP_HRMS.DSDisplayEI
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSAutoAtt As ERP_HRMS.DSAutoAtt
    Friend WithEvents Tbl_Hrm_Emp_Att1TableAdapter As ERP_HRMS.DSAutoAttTableAdapters.tbl_Hrm_Emp_Att1TableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Att1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As ERP_HRMS.DSAutoAttTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents View_Att_EmpVerifyTableAdapter As ERP_HRMS.DSDisplayEITableAdapters.View_Att_EmpVerifyTableAdapter
    Friend WithEvents View_Att_EmpVerifyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_HR_ActiveCardCopyTableAdapter As ERP_HRMS.DSAutoAttTableAdapters.View_Rpt_HR_ActiveCardCopyTableAdapter
    Friend WithEvents View_Rpt_HR_ActiveCardCopyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Display_EmpInfoTableAdapter As ERP_HRMS.DSDisplayEITableAdapters.View_Display_EmpInfoTableAdapter
    Friend WithEvents View_Display_EmpInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Tbl_Hrm_Emp_Att_Client1_1BindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents Tbl_Hrm_Emp_Att_Client1_1TableAdapter As ERP_HRMS.DSAutoAttTableAdapters.tbl_Hrm_Emp_Att_Client1_1TableAdapter
    Friend WithEvents CHECKINOUT_1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CHECKINOUT_1TableAdapter As ERP_HRMS.DsAccessToDBTableAdapters.CHECKINOUT_1TableAdapter
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeviceNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AttDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Tbl_HRM_Emp_Att_MealBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_HRM_Emp_Att_MealTableAdapter As ERP_HRMS.DSAutoAttTableAdapters.tbl_HRM_Emp_Att_MealTableAdapter
    Friend WithEvents View_Meal_Att_ManagementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Meal_Att_ManagementTableAdapter As ERP_HRMS.DsAccessToDBTableAdapters.View_Meal_Att_ManagementTableAdapter
    Friend WithEvents DSBuffetAttendance As DSBuffetAttendance
    Friend WithEvents View_Meal_Att_Management_NewBindingSource As BindingSource
    Friend WithEvents View_Meal_Att_Management_NewTableAdapter As DSBuffetAttendanceTableAdapters.View_Meal_Att_Management_NewTableAdapter
    Friend WithEvents TableAdapterManager1 As DSBuffetAttendanceTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_HRM_Emp_Att_MealBindingSource1 As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Att_MealTableAdapter1 As DSBuffetAttendanceTableAdapters.tbl_HRM_Emp_Att_MealTableAdapter
End Class
