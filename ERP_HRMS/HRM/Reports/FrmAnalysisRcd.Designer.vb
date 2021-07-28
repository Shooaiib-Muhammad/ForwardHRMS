<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAnalysisRcd
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
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim GradeNameLabel As System.Windows.Forms.Label
        Dim JobTypeNameLabel As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim ReasonLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TerListBtn = New System.Windows.Forms.RadioButton()
        Me.Ntc = New System.Windows.Forms.RadioButton()
        Me.HiringBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ReasonBtn = New System.Windows.Forms.RadioButton()
        Me.JBtn = New System.Windows.Forms.RadioButton()
        Me.BBtn = New System.Windows.Forms.RadioButton()
        Me.GBtn = New System.Windows.Forms.RadioButton()
        Me.SBtn = New System.Windows.Forms.RadioButton()
        Me.All = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.SecBtn = New System.Windows.Forms.RadioButton()
        Me.DepBTn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NoticeTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_Emp_NoticesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobTypeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_JobTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.Tbl_HRM_JobTypeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EndTime = New System.Windows.Forms.DateTimePicker()
        Me.starttime = New System.Windows.Forms.DateTimePicker()
        Me.BtnRptShower = New System.Windows.Forms.Button()
        Me.DeptPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_Emp_NoticesTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Hrm_Emp_NoticesTableAdapter()
        BranchNameLabel = New System.Windows.Forms.Label()
        GradeNameLabel = New System.Windows.Forms.Label()
        JobTypeNameLabel = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        ReasonLabel = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_NoticesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.DeptPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BranchNameLabel
        '
        BranchNameLabel.AutoSize = True
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(17, 24)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(57, 17)
        BranchNameLabel.TabIndex = 6
        BranchNameLabel.Text = "Branch:"
        BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GradeNameLabel
        '
        GradeNameLabel.AutoSize = True
        GradeNameLabel.ForeColor = System.Drawing.Color.Black
        GradeNameLabel.Location = New System.Drawing.Point(17, 54)
        GradeNameLabel.Name = "GradeNameLabel"
        GradeNameLabel.Size = New System.Drawing.Size(52, 17)
        GradeNameLabel.TabIndex = 8
        GradeNameLabel.Text = "Grade:"
        GradeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JobTypeNameLabel
        '
        JobTypeNameLabel.AutoSize = True
        JobTypeNameLabel.ForeColor = System.Drawing.Color.Black
        JobTypeNameLabel.Location = New System.Drawing.Point(17, 84)
        JobTypeNameLabel.Name = "JobTypeNameLabel"
        JobTypeNameLabel.Size = New System.Drawing.Size(71, 17)
        JobTypeNameLabel.TabIndex = 10
        JobTypeNameLabel.Text = "Job Type:"
        JobTypeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.AutoSize = True
        ShiftNameLabel.ForeColor = System.Drawing.Color.Black
        ShiftNameLabel.Location = New System.Drawing.Point(17, 114)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(40, 17)
        ShiftNameLabel.TabIndex = 12
        ShiftNameLabel.Text = "Shift:"
        ShiftNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(19, 33)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(86, 17)
        Label7.TabIndex = 0
        Label7.Text = "Depatrment:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.ForeColor = System.Drawing.Color.Black
        Label8.Location = New System.Drawing.Point(19, 87)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(87, 17)
        Label8.TabIndex = 4
        Label8.Text = "Designation:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.ForeColor = System.Drawing.Color.Black
        Label9.Location = New System.Drawing.Point(19, 60)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(59, 17)
        Label9.TabIndex = 2
        Label9.Text = "Section:"
        '
        'ReasonLabel
        '
        ReasonLabel.AutoSize = True
        ReasonLabel.ForeColor = System.Drawing.Color.Black
        ReasonLabel.Location = New System.Drawing.Point(17, 145)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(105, 17)
        ReasonLabel.TabIndex = 13
        ReasonLabel.Text = "Notice Reason:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1063, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Analysis Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TerListBtn)
        Me.GroupBox5.Controls.Add(Me.Ntc)
        Me.GroupBox5.Controls.Add(Me.HiringBtn)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(44, 58)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(192, 139)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Report Selector"
        '
        'TerListBtn
        '
        Me.TerListBtn.AutoSize = True
        Me.TerListBtn.ForeColor = System.Drawing.Color.Black
        Me.TerListBtn.Location = New System.Drawing.Point(20, 88)
        Me.TerListBtn.Name = "TerListBtn"
        Me.TerListBtn.Size = New System.Drawing.Size(127, 21)
        Me.TerListBtn.TabIndex = 8
        Me.TerListBtn.Text = "Termination List"
        Me.TerListBtn.UseVisualStyleBackColor = True
        '
        'Ntc
        '
        Me.Ntc.AutoSize = True
        Me.Ntc.ForeColor = System.Drawing.Color.Black
        Me.Ntc.Location = New System.Drawing.Point(20, 59)
        Me.Ntc.Name = "Ntc"
        Me.Ntc.Size = New System.Drawing.Size(73, 21)
        Me.Ntc.TabIndex = 9
        Me.Ntc.Text = "Notices"
        Me.Ntc.UseVisualStyleBackColor = True
        '
        'HiringBtn
        '
        Me.HiringBtn.AutoSize = True
        Me.HiringBtn.Checked = True
        Me.HiringBtn.ForeColor = System.Drawing.Color.Black
        Me.HiringBtn.Location = New System.Drawing.Point(20, 31)
        Me.HiringBtn.Name = "HiringBtn"
        Me.HiringBtn.Size = New System.Drawing.Size(94, 21)
        Me.HiringBtn.TabIndex = 10
        Me.HiringBtn.TabStop = True
        Me.HiringBtn.Text = "New Hiring"
        Me.HiringBtn.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ReasonBtn)
        Me.GroupBox6.Controls.Add(Me.JBtn)
        Me.GroupBox6.Controls.Add(Me.BBtn)
        Me.GroupBox6.Controls.Add(Me.GBtn)
        Me.GroupBox6.Controls.Add(Me.SBtn)
        Me.GroupBox6.Controls.Add(Me.All)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(44, 203)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(192, 178)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Option Selector"
        '
        'ReasonBtn
        '
        Me.ReasonBtn.AutoSize = True
        Me.ReasonBtn.ForeColor = System.Drawing.Color.Black
        Me.ReasonBtn.Location = New System.Drawing.Point(20, 141)
        Me.ReasonBtn.Name = "ReasonBtn"
        Me.ReasonBtn.Size = New System.Drawing.Size(95, 21)
        Me.ReasonBtn.TabIndex = 4
        Me.ReasonBtn.Text = "By Reason"
        Me.ReasonBtn.UseVisualStyleBackColor = True
        '
        'JBtn
        '
        Me.JBtn.AutoSize = True
        Me.JBtn.ForeColor = System.Drawing.Color.Black
        Me.JBtn.Location = New System.Drawing.Point(20, 93)
        Me.JBtn.Name = "JBtn"
        Me.JBtn.Size = New System.Drawing.Size(105, 21)
        Me.JBtn.TabIndex = 1
        Me.JBtn.Text = "By Job Type"
        Me.JBtn.UseVisualStyleBackColor = True
        '
        'BBtn
        '
        Me.BBtn.AutoSize = True
        Me.BBtn.ForeColor = System.Drawing.Color.Black
        Me.BBtn.Location = New System.Drawing.Point(20, 45)
        Me.BBtn.Name = "BBtn"
        Me.BBtn.Size = New System.Drawing.Size(91, 21)
        Me.BBtn.TabIndex = 1
        Me.BBtn.Text = "By Branch"
        Me.BBtn.UseVisualStyleBackColor = True
        '
        'GBtn
        '
        Me.GBtn.AutoSize = True
        Me.GBtn.ForeColor = System.Drawing.Color.Black
        Me.GBtn.Location = New System.Drawing.Point(20, 69)
        Me.GBtn.Name = "GBtn"
        Me.GBtn.Size = New System.Drawing.Size(86, 21)
        Me.GBtn.TabIndex = 2
        Me.GBtn.Text = "By Grade"
        Me.GBtn.UseVisualStyleBackColor = True
        '
        'SBtn
        '
        Me.SBtn.AutoSize = True
        Me.SBtn.ForeColor = System.Drawing.Color.Black
        Me.SBtn.Location = New System.Drawing.Point(20, 117)
        Me.SBtn.Name = "SBtn"
        Me.SBtn.Size = New System.Drawing.Size(74, 21)
        Me.SBtn.TabIndex = 3
        Me.SBtn.Text = "By Shift"
        Me.SBtn.UseVisualStyleBackColor = True
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
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(19, 115)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(41, 21)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "All"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.ForeColor = System.Drawing.Color.Black
        Me.DesigBtn.Location = New System.Drawing.Point(19, 142)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBtn.TabIndex = 0
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'SecBtn
        '
        Me.SecBtn.AutoSize = True
        Me.SecBtn.ForeColor = System.Drawing.Color.Black
        Me.SecBtn.Location = New System.Drawing.Point(126, 142)
        Me.SecBtn.Name = "SecBtn"
        Me.SecBtn.Size = New System.Drawing.Size(73, 21)
        Me.SecBtn.TabIndex = 0
        Me.SecBtn.Text = "Section"
        Me.SecBtn.UseVisualStyleBackColor = True
        '
        'DepBTn
        '
        Me.DepBTn.AutoSize = True
        Me.DepBTn.ForeColor = System.Drawing.Color.Black
        Me.DepBTn.Location = New System.Drawing.Point(126, 115)
        Me.DepBTn.Name = "DepBTn"
        Me.DepBTn.Size = New System.Drawing.Size(100, 21)
        Me.DepBTn.TabIndex = 0
        Me.DepBTn.Text = "Department"
        Me.DepBTn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NoticeTypeComboBox)
        Me.GroupBox1.Controls.Add(ReasonLabel)
        Me.GroupBox1.Controls.Add(ShiftNameLabel)
        Me.GroupBox1.Controls.Add(Me.ShiftNameComboBox)
        Me.GroupBox1.Controls.Add(JobTypeNameLabel)
        Me.GroupBox1.Controls.Add(Me.JobTypeNameComboBox)
        Me.GroupBox1.Controls.Add(GradeNameLabel)
        Me.GroupBox1.Controls.Add(Me.GradeNameComboBox)
        Me.GroupBox1.Controls.Add(BranchNameLabel)
        Me.GroupBox1.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(248, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 187)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selector"
        '
        'NoticeTypeComboBox
        '
        Me.NoticeTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NoticeTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NoticeTypeComboBox.DataSource = Me.Tbl_Hrm_Emp_NoticesBindingSource
        Me.NoticeTypeComboBox.DisplayMember = "NoticeType"
        Me.NoticeTypeComboBox.FormattingEnabled = True
        Me.NoticeTypeComboBox.Location = New System.Drawing.Point(126, 142)
        Me.NoticeTypeComboBox.Name = "NoticeTypeComboBox"
        Me.NoticeTypeComboBox.Size = New System.Drawing.Size(278, 24)
        Me.NoticeTypeComboBox.TabIndex = 14
        Me.NoticeTypeComboBox.ValueMember = "NoticeID"
        '
        'Tbl_Hrm_Emp_NoticesBindingSource
        '
        Me.Tbl_Hrm_Emp_NoticesBindingSource.DataMember = "tbl_Hrm_Emp_Notices"
        Me.Tbl_Hrm_Emp_NoticesBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ShiftNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShiftNameComboBox.DataSource = Me.Tbl_HRM_ShiftBindingSource
        Me.ShiftNameComboBox.DisplayMember = "ShiftName"
        Me.ShiftNameComboBox.Enabled = False
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(126, 112)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(278, 24)
        Me.ShiftNameComboBox.TabIndex = 13
        Me.ShiftNameComboBox.ValueMember = "ShiftID"
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSHRM
        '
        'JobTypeNameComboBox
        '
        Me.JobTypeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.JobTypeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.JobTypeNameComboBox.DataSource = Me.Tbl_HRM_JobTypeBindingSource
        Me.JobTypeNameComboBox.DisplayMember = "JobTypeName"
        Me.JobTypeNameComboBox.Enabled = False
        Me.JobTypeNameComboBox.FormattingEnabled = True
        Me.JobTypeNameComboBox.Location = New System.Drawing.Point(126, 82)
        Me.JobTypeNameComboBox.Name = "JobTypeNameComboBox"
        Me.JobTypeNameComboBox.Size = New System.Drawing.Size(278, 24)
        Me.JobTypeNameComboBox.TabIndex = 11
        Me.JobTypeNameComboBox.ValueMember = "jobTypeID"
        '
        'Tbl_HRM_JobTypeBindingSource
        '
        Me.Tbl_HRM_JobTypeBindingSource.DataMember = "tbl_HRM_JobType"
        Me.Tbl_HRM_JobTypeBindingSource.DataSource = Me.DSHRM
        '
        'GradeNameComboBox
        '
        Me.GradeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GradeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GradeNameComboBox.DataSource = Me.Tbl_HRM_GradeBindingSource
        Me.GradeNameComboBox.DisplayMember = "GradeName"
        Me.GradeNameComboBox.Enabled = False
        Me.GradeNameComboBox.FormattingEnabled = True
        Me.GradeNameComboBox.Location = New System.Drawing.Point(126, 52)
        Me.GradeNameComboBox.Name = "GradeNameComboBox"
        Me.GradeNameComboBox.Size = New System.Drawing.Size(278, 24)
        Me.GradeNameComboBox.TabIndex = 9
        Me.GradeNameComboBox.ValueMember = "GradeID"
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSHRM
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(126, 22)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(278, 24)
        Me.BranchNameComboBox.TabIndex = 7
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
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
        Me.TableAdapterManager.tbl_HRM_BranchTableAdapter = Me.Tbl_HRM_BranchTableAdapter
        Me.TableAdapterManager.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DeptTableAdapter = Me.Tbl_HRM_DeptTableAdapter
        Me.TableAdapterManager.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Me.Tbl_HRM_DesignationTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Me.Tbl_HRM_GradeTableAdapter
        Me.TableAdapterManager.tbl_HRM_JobTypeTableAdapter = Me.Tbl_HRM_JobTypeTableAdapter
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Me.Tbl_HRM_SectionTableAdapter
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Me.Tbl_HRM_ShiftTableAdapter
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_GradeTableAdapter
        '
        Me.Tbl_HRM_GradeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_JobTypeTableAdapter
        '
        Me.Tbl_HRM_JobTypeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_ShiftTableAdapter
        '
        Me.Tbl_HRM_ShiftTableAdapter.ClearBeforeFill = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.EndTime)
        Me.GroupBox7.Controls.Add(Me.starttime)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(248, 58)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(420, 90)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Date Selector"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(17, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "End Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(17, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Start Date:"
        '
        'EndTime
        '
        Me.EndTime.CustomFormat = "MM/dd/yyyy"
        Me.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndTime.Location = New System.Drawing.Point(126, 56)
        Me.EndTime.Name = "EndTime"
        Me.EndTime.Size = New System.Drawing.Size(278, 23)
        Me.EndTime.TabIndex = 0
        '
        'starttime
        '
        Me.starttime.CustomFormat = "MM/dd/yyyy"
        Me.starttime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.starttime.Location = New System.Drawing.Point(126, 30)
        Me.starttime.Name = "starttime"
        Me.starttime.Size = New System.Drawing.Size(278, 23)
        Me.starttime.TabIndex = 0
        '
        'BtnRptShower
        '
        Me.BtnRptShower.BackColor = System.Drawing.Color.Green
        Me.BtnRptShower.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRptShower.ForeColor = System.Drawing.Color.White
        Me.BtnRptShower.Location = New System.Drawing.Point(424, 392)
        Me.BtnRptShower.Name = "BtnRptShower"
        Me.BtnRptShower.Size = New System.Drawing.Size(147, 54)
        Me.BtnRptShower.TabIndex = 4
        Me.BtnRptShower.Text = "Show Report"
        Me.BtnRptShower.UseVisualStyleBackColor = False
        '
        'DeptPanel
        '
        Me.DeptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptPanel.Controls.Add(Me.RadioButton1)
        Me.DeptPanel.Controls.Add(Me.Label2)
        Me.DeptPanel.Controls.Add(Me.DeptNameComboBox)
        Me.DeptPanel.Controls.Add(Label7)
        Me.DeptPanel.Controls.Add(Label8)
        Me.DeptPanel.Controls.Add(Me.SectionNameComboBox)
        Me.DeptPanel.Controls.Add(Me.DesigBtn)
        Me.DeptPanel.Controls.Add(Label9)
        Me.DeptPanel.Controls.Add(Me.DesigNameComboBox)
        Me.DeptPanel.Controls.Add(Me.SecBtn)
        Me.DeptPanel.Controls.Add(Me.DepBTn)
        Me.DeptPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptPanel.Location = New System.Drawing.Point(44, 395)
        Me.DeptPanel.Name = "DeptPanel"
        Me.DeptPanel.Size = New System.Drawing.Size(321, 175)
        Me.DeptPanel.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Select Department"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(126, 28)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(182, 24)
        Me.DeptNameComboBox.TabIndex = 1
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'SectionNameComboBox
        '
        Me.SectionNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SectionNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectionNameComboBox.DataSource = Me.Tbl_HRM_SectionBindingSource
        Me.SectionNameComboBox.DisplayMember = "SectionName"
        Me.SectionNameComboBox.Enabled = False
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(126, 56)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(182, 24)
        Me.SectionNameComboBox.TabIndex = 3
        Me.SectionNameComboBox.ValueMember = "SectionID"
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(126, 85)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(182, 24)
        Me.DesigNameComboBox.TabIndex = 5
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_Hrm_Emp_NoticesTableAdapter
        '
        Me.Tbl_Hrm_Emp_NoticesTableAdapter.ClearBeforeFill = True
        '
        'FrmAnalysisRcd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1063, 697)
        Me.Controls.Add(Me.BtnRptShower)
        Me.Controls.Add(Me.DeptPanel)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmAnalysisRcd"
        Me.Text = "Analysis Report"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_Hrm_Emp_NoticesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.DeptPanel.ResumeLayout(False)
        Me.DeptPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents JBtn As RadioButton
    Friend WithEvents BBtn As RadioButton
    Friend WithEvents GBtn As RadioButton
    Friend WithEvents SBtn As RadioButton
    Friend WithEvents DesigBtn As RadioButton
    Friend WithEvents SecBtn As RadioButton
    Friend WithEvents DepBTn As RadioButton
    Friend WithEvents All As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents GradeNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_JobTypeTableAdapter As DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter
    Friend WithEvents Tbl_HRM_JobTypeBindingSource As BindingSource
    Friend WithEvents JobTypeNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents TerListBtn As RadioButton
    Friend WithEvents Ntc As RadioButton
    Friend WithEvents HiringBtn As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnRptShower As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EndTime As DateTimePicker
    Friend WithEvents starttime As DateTimePicker
    Friend WithEvents ReasonBtn As RadioButton
    Friend WithEvents DeptPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Tbl_Hrm_Emp_NoticesBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_NoticesTableAdapter As DSHRMTableAdapters.tbl_Hrm_Emp_NoticesTableAdapter
    Friend WithEvents NoticeTypeComboBox As ComboBox
End Class
