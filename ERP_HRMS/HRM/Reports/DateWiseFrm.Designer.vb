<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DateWiseFrm
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
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim SectionNameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim GradeNameLabel As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim JobTypeNameLabel As System.Windows.Forms.Label
        Dim HiringCriteriaLabel As System.Windows.Forms.Label
        Dim ReasonLabel As System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.HirCritBtn = New System.Windows.Forms.RadioButton()
        Me.JBtn = New System.Windows.Forms.RadioButton()
        Me.BBtn = New System.Windows.Forms.RadioButton()
        Me.GBtn = New System.Windows.Forms.RadioButton()
        Me.SBtn = New System.Windows.Forms.RadioButton()
        Me.All = New System.Windows.Forms.RadioButton()
        Me.AllDept = New System.Windows.Forms.RadioButton()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.SecBtn = New System.Windows.Forms.RadioButton()
        Me.DepBTn = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.starttime = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EndTime = New System.Windows.Forms.DateTimePicker()
        Me.BtnRptShower = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.pendEOBICrd = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.PendingStatus = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.EmpList = New System.Windows.Forms.RadioButton()
        Me.ProbEndBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TerListBtn = New System.Windows.Forms.RadioButton()
        Me.CrdExpry = New System.Windows.Forms.RadioButton()
        Me.Ntc = New System.Windows.Forms.RadioButton()
        Me.HiringBtn = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.COmboxbyter = New System.Windows.Forms.ComboBox()
        Me.ReasonComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Leave_ReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.HiringCriteriaComboBox = New System.Windows.Forms.ComboBox()
        Me.JobTypeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_JobTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.Tbl_HRM_JobTypeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.Tbl_HRM_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_InfoTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_Emp_InfoTableAdapter()
        Me.Deptpanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_Leave_ReasonTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_Leave_ReasonTableAdapter()
        Me.TableAdapterManager3 = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        DeptNameLabel = New System.Windows.Forms.Label()
        SectionNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        GradeNameLabel = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        JobTypeNameLabel = New System.Windows.Forms.Label()
        HiringCriteriaLabel = New System.Windows.Forms.Label()
        ReasonLabel = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Deptpanel.SuspendLayout()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeptNameLabel
        '
        DeptNameLabel.AutoSize = True
        DeptNameLabel.ForeColor = System.Drawing.Color.Black
        DeptNameLabel.Location = New System.Drawing.Point(13, 44)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(86, 17)
        DeptNameLabel.TabIndex = 0
        DeptNameLabel.Text = "Depatrment:"
        '
        'SectionNameLabel
        '
        SectionNameLabel.AutoSize = True
        SectionNameLabel.ForeColor = System.Drawing.Color.Black
        SectionNameLabel.Location = New System.Drawing.Point(13, 72)
        SectionNameLabel.Name = "SectionNameLabel"
        SectionNameLabel.Size = New System.Drawing.Size(59, 17)
        SectionNameLabel.TabIndex = 2
        SectionNameLabel.Text = "Section:"
        '
        'DesigNameLabel
        '
        DesigNameLabel.AutoSize = True
        DesigNameLabel.ForeColor = System.Drawing.Color.Black
        DesigNameLabel.Location = New System.Drawing.Point(13, 101)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(87, 17)
        DesigNameLabel.TabIndex = 4
        DesigNameLabel.Text = "Designation:"
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.AutoSize = True
        ShiftNameLabel.ForeColor = System.Drawing.Color.Black
        ShiftNameLabel.Location = New System.Drawing.Point(14, 111)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(40, 17)
        ShiftNameLabel.TabIndex = 6
        ShiftNameLabel.Text = "Shift:"
        '
        'GradeNameLabel
        '
        GradeNameLabel.AutoSize = True
        GradeNameLabel.ForeColor = System.Drawing.Color.Black
        GradeNameLabel.Location = New System.Drawing.Point(14, 55)
        GradeNameLabel.Name = "GradeNameLabel"
        GradeNameLabel.Size = New System.Drawing.Size(52, 17)
        GradeNameLabel.TabIndex = 8
        GradeNameLabel.Text = "Grade:"
        '
        'BranchNameLabel
        '
        BranchNameLabel.AutoSize = True
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(14, 27)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(57, 17)
        BranchNameLabel.TabIndex = 10
        BranchNameLabel.Text = "Branch:"
        '
        'JobTypeNameLabel
        '
        JobTypeNameLabel.AutoSize = True
        JobTypeNameLabel.ForeColor = System.Drawing.Color.Black
        JobTypeNameLabel.Location = New System.Drawing.Point(14, 83)
        JobTypeNameLabel.Name = "JobTypeNameLabel"
        JobTypeNameLabel.Size = New System.Drawing.Size(71, 17)
        JobTypeNameLabel.TabIndex = 12
        JobTypeNameLabel.Text = "Job Type:"
        '
        'HiringCriteriaLabel
        '
        HiringCriteriaLabel.AutoSize = True
        HiringCriteriaLabel.ForeColor = System.Drawing.Color.Black
        HiringCriteriaLabel.Location = New System.Drawing.Point(14, 139)
        HiringCriteriaLabel.Name = "HiringCriteriaLabel"
        HiringCriteriaLabel.Size = New System.Drawing.Size(98, 17)
        HiringCriteriaLabel.TabIndex = 14
        HiringCriteriaLabel.Text = "Hiring Criteria:"
        '
        'ReasonLabel
        '
        ReasonLabel.ForeColor = System.Drawing.Color.Black
        ReasonLabel.Location = New System.Drawing.Point(14, 167)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(98, 17)
        ReasonLabel.TabIndex = 15
        ReasonLabel.Text = "Reason:"
        ReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.RadioButton1)
        Me.GroupBox6.Controls.Add(Me.HirCritBtn)
        Me.GroupBox6.Controls.Add(Me.JBtn)
        Me.GroupBox6.Controls.Add(Me.BBtn)
        Me.GroupBox6.Controls.Add(Me.GBtn)
        Me.GroupBox6.Controls.Add(Me.SBtn)
        Me.GroupBox6.Controls.Add(Me.All)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(18, 421)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(318, 202)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Option Selector"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(14, 169)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 21)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "By Reason"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'HirCritBtn
        '
        Me.HirCritBtn.AutoSize = True
        Me.HirCritBtn.ForeColor = System.Drawing.Color.Black
        Me.HirCritBtn.Location = New System.Drawing.Point(14, 147)
        Me.HirCritBtn.Name = "HirCritBtn"
        Me.HirCritBtn.Size = New System.Drawing.Size(112, 21)
        Me.HirCritBtn.TabIndex = 1
        Me.HirCritBtn.Text = "Hiring Criteria"
        Me.HirCritBtn.UseVisualStyleBackColor = True
        '
        'JBtn
        '
        Me.JBtn.AutoSize = True
        Me.JBtn.ForeColor = System.Drawing.Color.Black
        Me.JBtn.Location = New System.Drawing.Point(14, 97)
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
        Me.BBtn.Location = New System.Drawing.Point(14, 47)
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
        Me.GBtn.Location = New System.Drawing.Point(14, 72)
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
        Me.SBtn.Location = New System.Drawing.Point(14, 122)
        Me.SBtn.Name = "SBtn"
        Me.SBtn.Size = New System.Drawing.Size(74, 21)
        Me.SBtn.TabIndex = 3
        Me.SBtn.Text = "By Shift"
        Me.SBtn.UseVisualStyleBackColor = True
        '
        'All
        '
        Me.All.AutoSize = True
        Me.All.ForeColor = System.Drawing.Color.Black
        Me.All.Location = New System.Drawing.Point(14, 22)
        Me.All.Name = "All"
        Me.All.Size = New System.Drawing.Size(41, 21)
        Me.All.TabIndex = 0
        Me.All.Text = "All"
        Me.All.UseVisualStyleBackColor = True
        '
        'AllDept
        '
        Me.AllDept.AutoSize = True
        Me.AllDept.Checked = True
        Me.AllDept.ForeColor = System.Drawing.Color.Black
        Me.AllDept.Location = New System.Drawing.Point(13, 126)
        Me.AllDept.Name = "AllDept"
        Me.AllDept.Size = New System.Drawing.Size(41, 21)
        Me.AllDept.TabIndex = 0
        Me.AllDept.TabStop = True
        Me.AllDept.Text = "All"
        Me.AllDept.UseVisualStyleBackColor = True
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.ForeColor = System.Drawing.Color.Black
        Me.DesigBtn.Location = New System.Drawing.Point(13, 153)
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
        Me.SecBtn.Location = New System.Drawing.Point(117, 153)
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
        Me.DepBTn.Location = New System.Drawing.Point(117, 126)
        Me.DepBTn.Name = "DepBTn"
        Me.DepBTn.Size = New System.Drawing.Size(100, 21)
        Me.DepBTn.TabIndex = 0
        Me.DepBTn.Text = "Department"
        Me.DepBTn.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.starttime)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.EndTime)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(340, 51)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(403, 63)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Date Selector"
        '
        'starttime
        '
        Me.starttime.CustomFormat = "dd/MM/yyyy"
        Me.starttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.starttime.Location = New System.Drawing.Point(117, 22)
        Me.starttime.Name = "starttime"
        Me.starttime.Size = New System.Drawing.Size(96, 23)
        Me.starttime.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(219, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "End Date:"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Start Date:"
        '
        'EndTime
        '
        Me.EndTime.CustomFormat = "MM/dd/yyyy"
        Me.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EndTime.Location = New System.Drawing.Point(293, 22)
        Me.EndTime.Name = "EndTime"
        Me.EndTime.Size = New System.Drawing.Size(96, 23)
        Me.EndTime.TabIndex = 0
        '
        'BtnRptShower
        '
        Me.BtnRptShower.BackColor = System.Drawing.Color.Green
        Me.BtnRptShower.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRptShower.ForeColor = System.Drawing.Color.White
        Me.BtnRptShower.Location = New System.Drawing.Point(616, 513)
        Me.BtnRptShower.Name = "BtnRptShower"
        Me.BtnRptShower.Size = New System.Drawing.Size(127, 47)
        Me.BtnRptShower.TabIndex = 4
        Me.BtnRptShower.Text = "Show Report"
        Me.BtnRptShower.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RadioButton5)
        Me.GroupBox5.Controls.Add(Me.RadioButton4)
        Me.GroupBox5.Controls.Add(Me.pendEOBICrd)
        Me.GroupBox5.Controls.Add(Me.RadioButton3)
        Me.GroupBox5.Controls.Add(Me.RadioButton18)
        Me.GroupBox5.Controls.Add(Me.PendingStatus)
        Me.GroupBox5.Controls.Add(Me.RadioButton10)
        Me.GroupBox5.Controls.Add(Me.EmpList)
        Me.GroupBox5.Controls.Add(Me.ProbEndBtn)
        Me.GroupBox5.Controls.Add(Me.RadioButton2)
        Me.GroupBox5.Controls.Add(Me.TerListBtn)
        Me.GroupBox5.Controls.Add(Me.CrdExpry)
        Me.GroupBox5.Controls.Add(Me.Ntc)
        Me.GroupBox5.Controls.Add(Me.HiringBtn)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(322, 371)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Report Selector"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(18, 318)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(169, 21)
        Me.RadioButton4.TabIndex = 45
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Salary Analysis Report"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'pendEOBICrd
        '
        Me.pendEOBICrd.AutoSize = True
        Me.pendEOBICrd.ForeColor = System.Drawing.Color.Black
        Me.pendEOBICrd.Location = New System.Drawing.Point(18, 294)
        Me.pendEOBICrd.Name = "pendEOBICrd"
        Me.pendEOBICrd.Size = New System.Drawing.Size(141, 21)
        Me.pendEOBICrd.TabIndex = 44
        Me.pendEOBICrd.Text = "In Active EOBI List"
        Me.pendEOBICrd.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(18, 267)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(302, 21)
        Me.RadioButton3.TabIndex = 43
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Daily List of Workers Who Left after 8 hours"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton18.ForeColor = System.Drawing.Color.Black
        Me.RadioButton18.Location = New System.Drawing.Point(18, 192)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(164, 21)
        Me.RadioButton18.TabIndex = 38
        Me.RadioButton18.Text = "Left Employees Letter"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'PendingStatus
        '
        Me.PendingStatus.AutoSize = True
        Me.PendingStatus.ForeColor = System.Drawing.Color.Black
        Me.PendingStatus.Location = New System.Drawing.Point(18, 168)
        Me.PendingStatus.Name = "PendingStatus"
        Me.PendingStatus.Size = New System.Drawing.Size(166, 21)
        Me.PendingStatus.TabIndex = 6
        Me.PendingStatus.Text = "Pending Salary Status"
        Me.PendingStatus.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(18, 243)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(191, 21)
        Me.RadioButton10.TabIndex = 42
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "OverTime Pre Calculation "
        Me.RadioButton10.UseVisualStyleBackColor = True
        Me.RadioButton10.Visible = False
        '
        'EmpList
        '
        Me.EmpList.AutoSize = True
        Me.EmpList.Checked = True
        Me.EmpList.ForeColor = System.Drawing.Color.Black
        Me.EmpList.Location = New System.Drawing.Point(18, 24)
        Me.EmpList.Name = "EmpList"
        Me.EmpList.Size = New System.Drawing.Size(161, 21)
        Me.EmpList.TabIndex = 1
        Me.EmpList.TabStop = True
        Me.EmpList.Text = "Employee Turn Over "
        Me.EmpList.UseVisualStyleBackColor = True
        '
        'ProbEndBtn
        '
        Me.ProbEndBtn.AutoSize = True
        Me.ProbEndBtn.ForeColor = System.Drawing.Color.Black
        Me.ProbEndBtn.Location = New System.Drawing.Point(18, 144)
        Me.ProbEndBtn.Name = "ProbEndBtn"
        Me.ProbEndBtn.Size = New System.Drawing.Size(120, 21)
        Me.ProbEndBtn.TabIndex = 0
        Me.ProbEndBtn.Text = "Probation End "
        Me.ProbEndBtn.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(18, 219)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(250, 21)
        Me.RadioButton2.TabIndex = 39
        Me.RadioButton2.Text = "OverTime Pre Calculation Summary"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'TerListBtn
        '
        Me.TerListBtn.AutoSize = True
        Me.TerListBtn.ForeColor = System.Drawing.Color.Black
        Me.TerListBtn.Location = New System.Drawing.Point(18, 120)
        Me.TerListBtn.Name = "TerListBtn"
        Me.TerListBtn.Size = New System.Drawing.Size(160, 21)
        Me.TerListBtn.TabIndex = 0
        Me.TerListBtn.Text = "List of left Employees"
        Me.TerListBtn.UseVisualStyleBackColor = True
        '
        'CrdExpry
        '
        Me.CrdExpry.AutoSize = True
        Me.CrdExpry.ForeColor = System.Drawing.Color.Black
        Me.CrdExpry.Location = New System.Drawing.Point(18, 72)
        Me.CrdExpry.Name = "CrdExpry"
        Me.CrdExpry.Size = New System.Drawing.Size(98, 21)
        Me.CrdExpry.TabIndex = 0
        Me.CrdExpry.Text = "Card Expiry"
        Me.CrdExpry.UseVisualStyleBackColor = True
        '
        'Ntc
        '
        Me.Ntc.AutoSize = True
        Me.Ntc.ForeColor = System.Drawing.Color.Black
        Me.Ntc.Location = New System.Drawing.Point(18, 96)
        Me.Ntc.Name = "Ntc"
        Me.Ntc.Size = New System.Drawing.Size(73, 21)
        Me.Ntc.TabIndex = 0
        Me.Ntc.Text = "Notices"
        Me.Ntc.UseVisualStyleBackColor = True
        '
        'HiringBtn
        '
        Me.HiringBtn.AutoSize = True
        Me.HiringBtn.ForeColor = System.Drawing.Color.Black
        Me.HiringBtn.Location = New System.Drawing.Point(18, 48)
        Me.HiringBtn.Name = "HiringBtn"
        Me.HiringBtn.Size = New System.Drawing.Size(102, 21)
        Me.HiringBtn.TabIndex = 0
        Me.HiringBtn.Text = "New Joining"
        Me.HiringBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(820, 34)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date Wise Reports"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.COmboxbyter)
        Me.GroupBox8.Controls.Add(ReasonLabel)
        Me.GroupBox8.Controls.Add(Me.ReasonComboBox)
        Me.GroupBox8.Controls.Add(HiringCriteriaLabel)
        Me.GroupBox8.Controls.Add(Me.HiringCriteriaComboBox)
        Me.GroupBox8.Controls.Add(JobTypeNameLabel)
        Me.GroupBox8.Controls.Add(Me.JobTypeNameComboBox)
        Me.GroupBox8.Controls.Add(BranchNameLabel)
        Me.GroupBox8.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox8.Controls.Add(GradeNameLabel)
        Me.GroupBox8.Controls.Add(Me.GradeNameComboBox)
        Me.GroupBox8.Controls.Add(ShiftNameLabel)
        Me.GroupBox8.Controls.Add(Me.ShiftNameComboBox)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox8.Location = New System.Drawing.Point(340, 115)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(403, 193)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Option Selector"
        '
        'COmboxbyter
        '
        Me.COmboxbyter.Enabled = False
        Me.COmboxbyter.FormattingEnabled = True
        Me.COmboxbyter.Items.AddRange(New Object() {"Resign", "Lay Off", "Terminate", "Retire", "Transfer", "Death"})
        Me.COmboxbyter.Location = New System.Drawing.Point(118, 162)
        Me.COmboxbyter.Name = "COmboxbyter"
        Me.COmboxbyter.Size = New System.Drawing.Size(262, 24)
        Me.COmboxbyter.TabIndex = 17
        Me.COmboxbyter.Visible = False
        '
        'ReasonComboBox
        '
        Me.ReasonComboBox.DataSource = Me.Tbl_HRM_Leave_ReasonBindingSource
        Me.ReasonComboBox.DisplayMember = "Reason"
        Me.ReasonComboBox.Enabled = False
        Me.ReasonComboBox.FormattingEnabled = True
        Me.ReasonComboBox.Location = New System.Drawing.Point(118, 164)
        Me.ReasonComboBox.Name = "ReasonComboBox"
        Me.ReasonComboBox.Size = New System.Drawing.Size(262, 24)
        Me.ReasonComboBox.TabIndex = 16
        Me.ReasonComboBox.ValueMember = "ReasonID"
        '
        'Tbl_HRM_Leave_ReasonBindingSource
        '
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataMember = "tbl_HRM_Leave_Reason"
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HiringCriteriaComboBox
        '
        Me.HiringCriteriaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.HiringCriteriaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HiringCriteriaComboBox.Enabled = False
        Me.HiringCriteriaComboBox.FormattingEnabled = True
        Me.HiringCriteriaComboBox.Items.AddRange(New Object() {"New Hiring", "Replacement "})
        Me.HiringCriteriaComboBox.Location = New System.Drawing.Point(118, 134)
        Me.HiringCriteriaComboBox.Name = "HiringCriteriaComboBox"
        Me.HiringCriteriaComboBox.Size = New System.Drawing.Size(262, 24)
        Me.HiringCriteriaComboBox.TabIndex = 15
        Me.HiringCriteriaComboBox.Text = "New Hiring"
        '
        'JobTypeNameComboBox
        '
        Me.JobTypeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.JobTypeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.JobTypeNameComboBox.DataSource = Me.Tbl_HRM_JobTypeBindingSource
        Me.JobTypeNameComboBox.DisplayMember = "JobTypeName"
        Me.JobTypeNameComboBox.Enabled = False
        Me.JobTypeNameComboBox.FormattingEnabled = True
        Me.JobTypeNameComboBox.Location = New System.Drawing.Point(118, 78)
        Me.JobTypeNameComboBox.Name = "JobTypeNameComboBox"
        Me.JobTypeNameComboBox.Size = New System.Drawing.Size(262, 24)
        Me.JobTypeNameComboBox.TabIndex = 13
        Me.JobTypeNameComboBox.ValueMember = "jobTypeID"
        '
        'Tbl_HRM_JobTypeBindingSource
        '
        Me.Tbl_HRM_JobTypeBindingSource.DataMember = "tbl_HRM_JobType"
        Me.Tbl_HRM_JobTypeBindingSource.DataSource = Me.DSHRM
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(118, 22)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(262, 24)
        Me.BranchNameComboBox.TabIndex = 11
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'GradeNameComboBox
        '
        Me.GradeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GradeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GradeNameComboBox.DataSource = Me.Tbl_HRM_GradeBindingSource
        Me.GradeNameComboBox.DisplayMember = "GradeName"
        Me.GradeNameComboBox.Enabled = False
        Me.GradeNameComboBox.FormattingEnabled = True
        Me.GradeNameComboBox.Location = New System.Drawing.Point(118, 50)
        Me.GradeNameComboBox.Name = "GradeNameComboBox"
        Me.GradeNameComboBox.Size = New System.Drawing.Size(262, 24)
        Me.GradeNameComboBox.TabIndex = 9
        Me.GradeNameComboBox.ValueMember = "GradeID"
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSHRM
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ShiftNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShiftNameComboBox.DataSource = Me.Tbl_HRM_ShiftBindingSource
        Me.ShiftNameComboBox.DisplayMember = "ShiftName"
        Me.ShiftNameComboBox.Enabled = False
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(118, 106)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(262, 24)
        Me.ShiftNameComboBox.TabIndex = 7
        Me.ShiftNameComboBox.ValueMember = "ShiftID"
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSHRM
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
        Me.DesigNameComboBox.Size = New System.Drawing.Size(260, 24)
        Me.DesigNameComboBox.TabIndex = 5
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
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
        Me.SectionNameComboBox.Size = New System.Drawing.Size(260, 24)
        Me.SectionNameComboBox.TabIndex = 3
        Me.SectionNameComboBox.ValueMember = "SectionID"
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
        Me.DeptNameComboBox.Size = New System.Drawing.Size(260, 24)
        Me.DeptNameComboBox.TabIndex = 1
        Me.DeptNameComboBox.ValueMember = "DeptID"
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
        Me.TableAdapterManager.tbl_disability_descptionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_BankTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_BranchTableAdapter = Me.Tbl_HRM_BranchTableAdapter
        Me.TableAdapterManager.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DeptTableAdapter = Me.Tbl_HRM_DeptTableAdapter
        Me.TableAdapterManager.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Me.Tbl_HRM_DesignationTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_Info1TableAdapter = Nothing
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
        'Tbl_HRM_Emp_InfoBindingSource
        '
        Me.Tbl_HRM_Emp_InfoBindingSource.DataMember = "tbl_HRM_Emp_Info"
        Me.Tbl_HRM_Emp_InfoBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_Emp_InfoTableAdapter
        '
        Me.Tbl_HRM_Emp_InfoTableAdapter.ClearBeforeFill = True
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
        Me.Deptpanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deptpanel.Location = New System.Drawing.Point(340, 311)
        Me.Deptpanel.Name = "Deptpanel"
        Me.Deptpanel.Size = New System.Drawing.Size(401, 196)
        Me.Deptpanel.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Select Appropriate Option"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Tbl_HRM_Leave_ReasonTableAdapter
        '
        Me.Tbl_HRM_Leave_ReasonTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Comp_InfoTableAdapter = Me.Tbl_Comp_InfoTableAdapter
        Me.TableAdapterManager3.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager3.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager3.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager3.UsersTableAdapter = Nothing
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        Me.Tbl_Comp_InfoBindingSource.DataSource = Me.DSUser
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(18, 344)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(188, 21)
        Me.RadioButton5.TabIndex = 46
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Employee Monthly Report"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'DateWiseFrm
        '
        Me.AcceptButton = Me.BtnRptShower
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(820, 742)
        Me.Controls.Add(Me.Deptpanel)
        Me.Controls.Add(Me.BtnRptShower)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "DateWiseFrm"
        Me.Text = "Date Wise Report"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Deptpanel.ResumeLayout(False)
        Me.Deptpanel.PerformLayout()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents JBtn As RadioButton
    Friend WithEvents BBtn As RadioButton
    Friend WithEvents GBtn As RadioButton
    Friend WithEvents SBtn As RadioButton
    Friend WithEvents DesigBtn As RadioButton
    Friend WithEvents SecBtn As RadioButton
    Friend WithEvents DepBTn As RadioButton
    Friend WithEvents All As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents BtnRptShower As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EndTime As DateTimePicker
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TerListBtn As RadioButton
    Friend WithEvents CrdExpry As RadioButton
    Friend WithEvents Ntc As RadioButton
    Friend WithEvents HiringBtn As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents GradeNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_JobTypeTableAdapter As DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter
    Friend WithEvents Tbl_HRM_JobTypeBindingSource As BindingSource
    Friend WithEvents JobTypeNameComboBox As ComboBox
    Friend WithEvents ProbEndBtn As RadioButton
    Friend WithEvents Tbl_HRM_Emp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_InfoTableAdapter As DSHRMTableAdapters.tbl_HRM_Emp_InfoTableAdapter
    Friend WithEvents HiringCriteriaComboBox As ComboBox
    Friend WithEvents AllDept As RadioButton
    Friend WithEvents Deptpanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpList As RadioButton
    Friend WithEvents starttime As DateTimePicker
    Friend WithEvents PendingStatus As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Tbl_HRM_Leave_ReasonBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Leave_ReasonTableAdapter As DSHRMTableAdapters.tbl_HRM_Leave_ReasonTableAdapter
    Friend WithEvents ReasonComboBox As ComboBox
    Friend WithEvents COmboxbyter As ComboBox
    Friend WithEvents HirCritBtn As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TableAdapterManager3 As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents DSUser As DSUser
    Friend WithEvents pendEOBICrd As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
End Class
