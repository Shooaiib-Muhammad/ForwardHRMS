<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrivanceReports
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
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboStatus = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_EAP_Grievance_Category_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSGrievance = New ERP_HRMS.DSGrievance()
        Me.Tocrd = New System.Windows.Forms.TextBox()
        Me.MonthPicker = New System.Windows.Forms.DateTimePicker()
        Me.FrmCrd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tbl_EAP_Grievance_CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ByCatagery = New System.Windows.Forms.RadioButton()
        Me.All = New System.Windows.Forms.RadioButton()
        Me.CrdRange = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioGrievStatus = New System.Windows.Forms.RadioButton()
        Me.RadioGriev = New System.Windows.Forms.RadioButton()
        Me.RadioGrievSummary = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioDeptAll = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DesigComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDeptBtn = New System.Windows.Forms.RadioButton()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.SectBtn = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RptViewer = New System.Windows.Forms.Button()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_EAP_Grievance_CategoryTableAdapter = New ERP_HRMS.DSGrievanceTableAdapters.tbl_EAP_Grievance_CategoryTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSGrievanceTableAdapters.TableAdapterManager()
        Me.Tbl_EAP_Grievance_Category_HeadTableAdapter = New ERP_HRMS.DSGrievanceTableAdapters.tbl_EAP_Grievance_Category_HeadTableAdapter()
        BranchNameLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_EAP_Grievance_Category_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSGrievance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_EAP_Grievance_CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(16, 79)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(100, 20)
        BranchNameLabel.TabIndex = 30
        BranchNameLabel.Text = "Catagory"
        BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(16, 107)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(100, 20)
        Label7.TabIndex = 37
        Label7.Text = "Status"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(837, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Grievance Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label7)
        Me.GroupBox3.Controls.Add(Me.ComboStatus)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(BranchNameLabel)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox3.Controls.Add(Me.Tocrd)
        Me.GroupBox3.Controls.Add(Me.MonthPicker)
        Me.GroupBox3.Controls.Add(Me.FrmCrd)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(365, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(405, 150)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selection"
        '
        'ComboStatus
        '
        Me.ComboStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboStatus.Enabled = False
        Me.ComboStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ComboStatus.FormattingEnabled = True
        Me.ComboStatus.Items.AddRange(New Object() {"Completed", "Pending"})
        Me.ComboStatus.Location = New System.Drawing.Point(121, 105)
        Me.ComboStatus.Name = "ComboStatus"
        Me.ComboStatus.Size = New System.Drawing.Size(137, 21)
        Me.ComboStatus.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(218, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "To Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(287, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 23)
        Me.DateTimePicker1.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "From Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_EAP_Grievance_Category_HeadBindingSource
        Me.BranchNameComboBox.DisplayMember = "Category"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(121, 76)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(262, 24)
        Me.BranchNameComboBox.TabIndex = 31
        Me.BranchNameComboBox.ValueMember = "GCID"
        '
        'Tbl_EAP_Grievance_Category_HeadBindingSource
        '
        Me.Tbl_EAP_Grievance_Category_HeadBindingSource.DataMember = "tbl_EAP_Grievance_Category_Head"
        Me.Tbl_EAP_Grievance_Category_HeadBindingSource.DataSource = Me.DSGrievance
        '
        'DSGrievance
        '
        Me.DSGrievance.DataSetName = "DSGrievance"
        Me.DSGrievance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tocrd
        '
        Me.Tocrd.Enabled = False
        Me.Tocrd.Location = New System.Drawing.Point(287, 48)
        Me.Tocrd.Name = "Tocrd"
        Me.Tocrd.Size = New System.Drawing.Size(95, 23)
        Me.Tocrd.TabIndex = 21
        Me.Tocrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MonthPicker
        '
        Me.MonthPicker.CustomFormat = ""
        Me.MonthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MonthPicker.Location = New System.Drawing.Point(121, 20)
        Me.MonthPicker.Name = "MonthPicker"
        Me.MonthPicker.Size = New System.Drawing.Size(95, 23)
        Me.MonthPicker.TabIndex = 19
        '
        'FrmCrd
        '
        Me.FrmCrd.Enabled = False
        Me.FrmCrd.Location = New System.Drawing.Point(121, 48)
        Me.FrmCrd.Name = "FrmCrd"
        Me.FrmCrd.Size = New System.Drawing.Size(95, 23)
        Me.FrmCrd.TabIndex = 20
        Me.FrmCrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "From Card:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(222, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "To Card:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_EAP_Grievance_CategoryBindingSource
        '
        Me.Tbl_EAP_Grievance_CategoryBindingSource.DataMember = "tbl_EAP_Grievance_Category"
        Me.Tbl_EAP_Grievance_CategoryBindingSource.DataSource = Me.DSGrievance
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ByCatagery)
        Me.GroupBox2.Controls.Add(Me.All)
        Me.GroupBox2.Controls.Add(Me.CrdRange)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(39, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(315, 108)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selection"
        '
        'ByCatagery
        '
        Me.ByCatagery.AutoSize = True
        Me.ByCatagery.ForeColor = System.Drawing.Color.Black
        Me.ByCatagery.Location = New System.Drawing.Point(22, 73)
        Me.ByCatagery.Name = "ByCatagery"
        Me.ByCatagery.Size = New System.Drawing.Size(103, 21)
        Me.ByCatagery.TabIndex = 2
        Me.ByCatagery.TabStop = True
        Me.ByCatagery.Text = "By Category"
        Me.ByCatagery.UseVisualStyleBackColor = True
        '
        'All
        '
        Me.All.AutoSize = True
        Me.All.Checked = True
        Me.All.ForeColor = System.Drawing.Color.Black
        Me.All.Location = New System.Drawing.Point(20, 22)
        Me.All.Name = "All"
        Me.All.Size = New System.Drawing.Size(41, 21)
        Me.All.TabIndex = 0
        Me.All.TabStop = True
        Me.All.Text = "All"
        Me.All.UseVisualStyleBackColor = True
        '
        'CrdRange
        '
        Me.CrdRange.AutoSize = True
        Me.CrdRange.ForeColor = System.Drawing.Color.Black
        Me.CrdRange.Location = New System.Drawing.Point(20, 46)
        Me.CrdRange.Name = "CrdRange"
        Me.CrdRange.Size = New System.Drawing.Size(122, 21)
        Me.CrdRange.TabIndex = 0
        Me.CrdRange.Text = "By Card Range"
        Me.CrdRange.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioGrievStatus)
        Me.GroupBox4.Controls.Add(Me.RadioGriev)
        Me.GroupBox4.Controls.Add(Me.RadioGrievSummary)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(39, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(315, 99)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report Selection"
        '
        'RadioGrievStatus
        '
        Me.RadioGrievStatus.AutoSize = True
        Me.RadioGrievStatus.ForeColor = System.Drawing.Color.Black
        Me.RadioGrievStatus.Location = New System.Drawing.Point(22, 69)
        Me.RadioGrievStatus.Name = "RadioGrievStatus"
        Me.RadioGrievStatus.Size = New System.Drawing.Size(135, 21)
        Me.RadioGrievStatus.TabIndex = 4
        Me.RadioGrievStatus.Text = "Grievance Status"
        Me.RadioGrievStatus.UseVisualStyleBackColor = True
        '
        'RadioGriev
        '
        Me.RadioGriev.AutoSize = True
        Me.RadioGriev.Checked = True
        Me.RadioGriev.ForeColor = System.Drawing.Color.Black
        Me.RadioGriev.Location = New System.Drawing.Point(22, 21)
        Me.RadioGriev.Name = "RadioGriev"
        Me.RadioGriev.Size = New System.Drawing.Size(138, 21)
        Me.RadioGriev.TabIndex = 2
        Me.RadioGriev.TabStop = True
        Me.RadioGriev.Text = "Grievance Report"
        Me.RadioGriev.UseVisualStyleBackColor = True
        '
        'RadioGrievSummary
        '
        Me.RadioGrievSummary.AutoSize = True
        Me.RadioGrievSummary.ForeColor = System.Drawing.Color.Black
        Me.RadioGrievSummary.Location = New System.Drawing.Point(22, 45)
        Me.RadioGrievSummary.Name = "RadioGrievSummary"
        Me.RadioGrievSummary.Size = New System.Drawing.Size(154, 21)
        Me.RadioGrievSummary.TabIndex = 3
        Me.RadioGrievSummary.Text = "Grievance Summary"
        Me.RadioGrievSummary.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RadioDeptAll)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.DesigComboBox)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.NameComboBox)
        Me.Panel2.Controls.Add(Me.MainDeptBtn)
        Me.Panel2.Controls.Add(Me.DeptNameComboBox)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.DesigBtn)
        Me.Panel2.Controls.Add(Me.SectBtn)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(365, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 181)
        Me.Panel2.TabIndex = 16
        '
        'RadioDeptAll
        '
        Me.RadioDeptAll.Checked = True
        Me.RadioDeptAll.Location = New System.Drawing.Point(18, 125)
        Me.RadioDeptAll.Name = "RadioDeptAll"
        Me.RadioDeptAll.Size = New System.Drawing.Size(93, 20)
        Me.RadioDeptAll.TabIndex = 30
        Me.RadioDeptAll.TabStop = True
        Me.RadioDeptAll.Text = "All"
        Me.RadioDeptAll.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(393, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Select Appropriate Option"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesigComboBox
        '
        Me.DesigComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DesigComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigComboBox.DisplayMember = "DesigName"
        Me.DesigComboBox.Enabled = False
        Me.DesigComboBox.FormattingEnabled = True
        Me.DesigComboBox.Location = New System.Drawing.Point(111, 96)
        Me.DesigComboBox.Name = "DesigComboBox"
        Me.DesigComboBox.Size = New System.Drawing.Size(268, 24)
        Me.DesigComboBox.TabIndex = 25
        Me.DesigComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(18, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 20)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Department:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.Tbl_HRM_SectionBindingSource
        Me.NameComboBox.DisplayMember = "SectionName"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(111, 66)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(268, 24)
        Me.NameComboBox.TabIndex = 24
        Me.NameComboBox.ValueMember = "SectionID"
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
        'MainDeptBtn
        '
        Me.MainDeptBtn.AutoSize = True
        Me.MainDeptBtn.Location = New System.Drawing.Point(136, 126)
        Me.MainDeptBtn.Name = "MainDeptBtn"
        Me.MainDeptBtn.Size = New System.Drawing.Size(100, 21)
        Me.MainDeptBtn.TabIndex = 26
        Me.MainDeptBtn.Text = "Department"
        Me.MainDeptBtn.UseVisualStyleBackColor = True
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(111, 36)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(268, 24)
        Me.DeptNameComboBox.TabIndex = 23
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(18, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 20)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Section:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.Location = New System.Drawing.Point(18, 151)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBtn.TabIndex = 28
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'SectBtn
        '
        Me.SectBtn.AutoSize = True
        Me.SectBtn.Location = New System.Drawing.Point(136, 150)
        Me.SectBtn.Name = "SectBtn"
        Me.SectBtn.Size = New System.Drawing.Size(73, 21)
        Me.SectBtn.TabIndex = 27
        Me.SectBtn.Text = "Section"
        Me.SectBtn.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(18, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 20)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Designation:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RptViewer
        '
        Me.RptViewer.BackColor = System.Drawing.Color.Green
        Me.RptViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RptViewer.ForeColor = System.Drawing.Color.White
        Me.RptViewer.Location = New System.Drawing.Point(633, 426)
        Me.RptViewer.Name = "RptViewer"
        Me.RptViewer.Size = New System.Drawing.Size(127, 47)
        Me.RptViewer.TabIndex = 17
        Me.RptViewer.Text = "Show Report"
        Me.RptViewer.UseVisualStyleBackColor = False
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
        'Me.TableAdapterManager.tbl_HRM_Leave_Reason1TableAdapter = Nothing
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
        'Tbl_EAP_Grievance_CategoryTableAdapter
        '
        Me.Tbl_EAP_Grievance_CategoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_EAP_Grievance_Category_HeadTableAdapter = Me.Tbl_EAP_Grievance_Category_HeadTableAdapter
        Me.TableAdapterManager1.tbl_EAP_Grievance_CategoryTableAdapter = Me.Tbl_EAP_Grievance_CategoryTableAdapter
        Me.TableAdapterManager1.tbl_EAP_GrievanceTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Section1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Section2TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Section3TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSGrievanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_EAP_Grievance_Category_HeadTableAdapter
        '
        Me.Tbl_EAP_Grievance_Category_HeadTableAdapter.ClearBeforeFill = True
        '
        'GrivanceReports
        '
        Me.AcceptButton = Me.RptViewer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 712)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RptViewer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GrivanceReports"
        Me.Text = "GrivanceReports"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_EAP_Grievance_Category_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSGrievance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_EAP_Grievance_CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents Tocrd As TextBox
    Friend WithEvents MonthPicker As DateTimePicker
    Friend WithEvents FrmCrd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents All As RadioButton
    Friend WithEvents CrdRange As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioGriev As RadioButton
    Friend WithEvents RadioGrievSummary As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioDeptAll As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents DesigComboBox As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents MainDeptBtn As RadioButton
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents DesigBtn As RadioButton
    Friend WithEvents SectBtn As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents RptViewer As Button
    Friend WithEvents ByCatagery As RadioButton
    Friend WithEvents RadioGrievStatus As RadioButton
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents DSGrievance As DSGrievance
    Friend WithEvents Tbl_EAP_Grievance_CategoryBindingSource As BindingSource
    Friend WithEvents Tbl_EAP_Grievance_CategoryTableAdapter As DSGrievanceTableAdapters.tbl_EAP_Grievance_CategoryTableAdapter
    Friend WithEvents TableAdapterManager1 As DSGrievanceTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_EAP_Grievance_Category_HeadTableAdapter As DSGrievanceTableAdapters.tbl_EAP_Grievance_Category_HeadTableAdapter
    Friend WithEvents Tbl_EAP_Grievance_Category_HeadBindingSource As BindingSource
    Friend WithEvents ComboStatus As ComboBox
End Class
