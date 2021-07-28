<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAllowanceReports
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBtn = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RebtBtn = New System.Windows.Forms.RadioButton()
        Me.EduAll = New System.Windows.Forms.RadioButton()
        Me.SPcAll = New System.Windows.Forms.RadioButton()
        Me.TravelBtn = New System.Windows.Forms.RadioButton()
        Me.MealAll = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Allowancepanel = New System.Windows.Forms.GroupBox()
        Me.Sinrity = New System.Windows.Forms.RadioButton()
        Me.AccAllow = New System.Windows.Forms.RadioButton()
        Me.Dedpanel = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.PESSiBTN = New System.Windows.Forms.RadioButton()
        Me.EOBIBTn = New System.Windows.Forms.RadioButton()
        Me.CantBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DedBtn = New System.Windows.Forms.RadioButton()
        Me.AllowanceBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.All = New System.Windows.Forms.RadioButton()
        Me.CrdRange = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DesigComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDeptBtn = New System.Windows.Forms.RadioButton()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.SectBtn = New System.Windows.Forms.RadioButton()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.NonActivrBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        BranchNameLabel = New System.Windows.Forms.Label()
        Me.Allowancepanel.SuspendLayout()
        Me.Dedpanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(13, 57)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(78, 20)
        BranchNameLabel.TabIndex = 23
        BranchNameLabel.Text = "Branch:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(951, 40)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Allowance And Deductions Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBtn
        '
        Me.TxtBtn.AutoSize = True
        Me.TxtBtn.Checked = True
        Me.TxtBtn.ForeColor = System.Drawing.Color.Black
        Me.TxtBtn.Location = New System.Drawing.Point(16, 29)
        Me.TxtBtn.Name = "TxtBtn"
        Me.TxtBtn.Size = New System.Drawing.Size(117, 21)
        Me.TxtBtn.TabIndex = 6
        Me.TxtBtn.TabStop = True
        Me.TxtBtn.Text = "Tax Deduction"
        Me.TxtBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(139, 459)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RebtBtn
        '
        Me.RebtBtn.AutoSize = True
        Me.RebtBtn.ForeColor = System.Drawing.Color.Black
        Me.RebtBtn.Location = New System.Drawing.Point(16, 53)
        Me.RebtBtn.Name = "RebtBtn"
        Me.RebtBtn.Size = New System.Drawing.Size(124, 21)
        Me.RebtBtn.TabIndex = 5
        Me.RebtBtn.TabStop = True
        Me.RebtBtn.Text = "Rent Deduction"
        Me.RebtBtn.UseVisualStyleBackColor = True
        '
        'EduAll
        '
        Me.EduAll.AutoSize = True
        Me.EduAll.ForeColor = System.Drawing.Color.Black
        Me.EduAll.Location = New System.Drawing.Point(20, 88)
        Me.EduAll.Name = "EduAll"
        Me.EduAll.Size = New System.Drawing.Size(156, 21)
        Me.EduAll.TabIndex = 4
        Me.EduAll.TabStop = True
        Me.EduAll.Text = "Education Allowance"
        Me.EduAll.UseVisualStyleBackColor = True
        '
        'SPcAll
        '
        Me.SPcAll.AutoSize = True
        Me.SPcAll.Checked = True
        Me.SPcAll.ForeColor = System.Drawing.Color.Black
        Me.SPcAll.Location = New System.Drawing.Point(20, 22)
        Me.SPcAll.Name = "SPcAll"
        Me.SPcAll.Size = New System.Drawing.Size(139, 21)
        Me.SPcAll.TabIndex = 3
        Me.SPcAll.TabStop = True
        Me.SPcAll.Text = "Special Allowance"
        Me.SPcAll.UseVisualStyleBackColor = True
        '
        'TravelBtn
        '
        Me.TravelBtn.AutoSize = True
        Me.TravelBtn.ForeColor = System.Drawing.Color.Black
        Me.TravelBtn.Location = New System.Drawing.Point(20, 66)
        Me.TravelBtn.Name = "TravelBtn"
        Me.TravelBtn.Size = New System.Drawing.Size(133, 21)
        Me.TravelBtn.TabIndex = 2
        Me.TravelBtn.TabStop = True
        Me.TravelBtn.Text = "Travel Allowance"
        Me.TravelBtn.UseVisualStyleBackColor = True
        '
        'MealAll
        '
        Me.MealAll.AutoSize = True
        Me.MealAll.ForeColor = System.Drawing.Color.Black
        Me.MealAll.Location = New System.Drawing.Point(20, 44)
        Me.MealAll.Name = "MealAll"
        Me.MealAll.Size = New System.Drawing.Size(123, 21)
        Me.MealAll.TabIndex = 1
        Me.MealAll.Text = "Meal Allowance"
        Me.MealAll.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(255, 26)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(80, 23)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(91, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 23)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(174, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "To Card:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "From Card:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Allowancepanel
        '
        Me.Allowancepanel.Controls.Add(Me.Sinrity)
        Me.Allowancepanel.Controls.Add(Me.MealAll)
        Me.Allowancepanel.Controls.Add(Me.TravelBtn)
        Me.Allowancepanel.Controls.Add(Me.AccAllow)
        Me.Allowancepanel.Controls.Add(Me.EduAll)
        Me.Allowancepanel.Controls.Add(Me.SPcAll)
        Me.Allowancepanel.Enabled = False
        Me.Allowancepanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Allowancepanel.ForeColor = System.Drawing.Color.Blue
        Me.Allowancepanel.Location = New System.Drawing.Point(20, 166)
        Me.Allowancepanel.Name = "Allowancepanel"
        Me.Allowancepanel.Size = New System.Drawing.Size(244, 160)
        Me.Allowancepanel.TabIndex = 11
        Me.Allowancepanel.TabStop = False
        Me.Allowancepanel.Text = "Allowance Selection"
        '
        'Sinrity
        '
        Me.Sinrity.AutoSize = True
        Me.Sinrity.ForeColor = System.Drawing.Color.Black
        Me.Sinrity.Location = New System.Drawing.Point(20, 132)
        Me.Sinrity.Name = "Sinrity"
        Me.Sinrity.Size = New System.Drawing.Size(148, 21)
        Me.Sinrity.TabIndex = 5
        Me.Sinrity.TabStop = True
        Me.Sinrity.Text = "Seniority Allowance"
        Me.Sinrity.UseVisualStyleBackColor = True
        '
        'AccAllow
        '
        Me.AccAllow.AutoSize = True
        Me.AccAllow.ForeColor = System.Drawing.Color.Black
        Me.AccAllow.Location = New System.Drawing.Point(20, 110)
        Me.AccAllow.Name = "AccAllow"
        Me.AccAllow.Size = New System.Drawing.Size(193, 21)
        Me.AccAllow.TabIndex = 4
        Me.AccAllow.TabStop = True
        Me.AccAllow.Text = "Accommodation Allowance"
        Me.AccAllow.UseVisualStyleBackColor = True
        '
        'Dedpanel
        '
        Me.Dedpanel.Controls.Add(Me.RadioButton5)
        Me.Dedpanel.Controls.Add(Me.RadioButton4)
        Me.Dedpanel.Controls.Add(Me.RadioButton3)
        Me.Dedpanel.Controls.Add(Me.PESSiBTN)
        Me.Dedpanel.Controls.Add(Me.EOBIBTn)
        Me.Dedpanel.Controls.Add(Me.CantBtn)
        Me.Dedpanel.Controls.Add(Me.RebtBtn)
        Me.Dedpanel.Controls.Add(Me.TxtBtn)
        Me.Dedpanel.Enabled = False
        Me.Dedpanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dedpanel.ForeColor = System.Drawing.Color.Blue
        Me.Dedpanel.Location = New System.Drawing.Point(271, 104)
        Me.Dedpanel.Name = "Dedpanel"
        Me.Dedpanel.Size = New System.Drawing.Size(226, 228)
        Me.Dedpanel.TabIndex = 11
        Me.Dedpanel.TabStop = False
        Me.Dedpanel.Text = "Deduction Selection"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(16, 125)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(106, 21)
        Me.RadioButton5.TabIndex = 38
        Me.RadioButton5.Text = "EOBI Format"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(16, 173)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(133, 21)
        Me.RadioButton4.TabIndex = 37
        Me.RadioButton4.Text = "P.E.S.S.I. Format"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(16, 197)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(99, 21)
        Me.RadioButton3.TabIndex = 36
        Me.RadioButton3.Text = "Union Fund"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'PESSiBTN
        '
        Me.PESSiBTN.AutoSize = True
        Me.PESSiBTN.ForeColor = System.Drawing.Color.Black
        Me.PESSiBTN.Location = New System.Drawing.Point(16, 149)
        Me.PESSiBTN.Name = "PESSiBTN"
        Me.PESSiBTN.Size = New System.Drawing.Size(85, 21)
        Me.PESSiBTN.TabIndex = 35
        Me.PESSiBTN.Text = "P.E.S.S.I."
        Me.PESSiBTN.UseVisualStyleBackColor = True
        '
        'EOBIBTn
        '
        Me.EOBIBTn.AutoSize = True
        Me.EOBIBTn.ForeColor = System.Drawing.Color.Black
        Me.EOBIBTn.Location = New System.Drawing.Point(16, 101)
        Me.EOBIBTn.Name = "EOBIBTn"
        Me.EOBIBTn.Size = New System.Drawing.Size(126, 21)
        Me.EOBIBTn.TabIndex = 5
        Me.EOBIBTn.TabStop = True
        Me.EOBIBTn.Text = "EOBI Deduction"
        Me.EOBIBTn.UseVisualStyleBackColor = True
        '
        'CantBtn
        '
        Me.CantBtn.AutoSize = True
        Me.CantBtn.ForeColor = System.Drawing.Color.Black
        Me.CantBtn.Location = New System.Drawing.Point(16, 77)
        Me.CantBtn.Name = "CantBtn"
        Me.CantBtn.Size = New System.Drawing.Size(147, 21)
        Me.CantBtn.TabIndex = 5
        Me.CantBtn.TabStop = True
        Me.CantBtn.Text = "Canteen Deduction"
        Me.CantBtn.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DedBtn)
        Me.GroupBox3.Controls.Add(Me.AllowanceBtn)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(20, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 61)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Selection"
        '
        'DedBtn
        '
        Me.DedBtn.AutoSize = True
        Me.DedBtn.ForeColor = System.Drawing.Color.Black
        Me.DedBtn.Location = New System.Drawing.Point(110, 22)
        Me.DedBtn.Name = "DedBtn"
        Me.DedBtn.Size = New System.Drawing.Size(90, 21)
        Me.DedBtn.TabIndex = 5
        Me.DedBtn.TabStop = True
        Me.DedBtn.Text = "Deduction"
        Me.DedBtn.UseVisualStyleBackColor = True
        '
        'AllowanceBtn
        '
        Me.AllowanceBtn.AutoSize = True
        Me.AllowanceBtn.Checked = True
        Me.AllowanceBtn.ForeColor = System.Drawing.Color.Black
        Me.AllowanceBtn.Location = New System.Drawing.Point(17, 22)
        Me.AllowanceBtn.Name = "AllowanceBtn"
        Me.AllowanceBtn.Size = New System.Drawing.Size(93, 21)
        Me.AllowanceBtn.TabIndex = 5
        Me.AllowanceBtn.TabStop = True
        Me.AllowanceBtn.Text = "Allowance "
        Me.AllowanceBtn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(BranchNameLabel)
        Me.GroupBox2.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(271, 340)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 88)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option  Selection"
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(91, 56)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(244, 24)
        Me.BranchNameComboBox.TabIndex = 24
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.All)
        Me.GroupBox1.Controls.Add(Me.CrdRange)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(21, 336)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(245, 102)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selection"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(24, 71)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "By Branch "
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'All
        '
        Me.All.AutoSize = True
        Me.All.Checked = True
        Me.All.ForeColor = System.Drawing.Color.Black
        Me.All.Location = New System.Drawing.Point(24, 22)
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
        Me.CrdRange.Location = New System.Drawing.Point(24, 46)
        Me.CrdRange.Name = "CrdRange"
        Me.CrdRange.Size = New System.Drawing.Size(122, 21)
        Me.CrdRange.TabIndex = 0
        Me.CrdRange.Text = "By Card Range"
        Me.CrdRange.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.DesigComboBox)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.NameComboBox)
        Me.Panel2.Controls.Add(Me.MainDeptBtn)
        Me.Panel2.Controls.Add(Me.DeptNameComboBox)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.SectBtn)
        Me.Panel2.Controls.Add(Me.DesigBtn)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(271, 438)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 175)
        Me.Panel2.TabIndex = 25
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 118)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 29
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "All"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(371, 25)
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
        Me.DesigComboBox.Location = New System.Drawing.Point(113, 88)
        Me.DesigComboBox.Name = "DesigComboBox"
        Me.DesigComboBox.Size = New System.Drawing.Size(244, 24)
        Me.DesigComboBox.TabIndex = 25
        Me.DesigComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(19, 34)
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
        Me.NameComboBox.Location = New System.Drawing.Point(113, 61)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(244, 24)
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
        Me.MainDeptBtn.Location = New System.Drawing.Point(124, 118)
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
        Me.DeptNameComboBox.Location = New System.Drawing.Point(113, 34)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(244, 24)
        Me.DeptNameComboBox.TabIndex = 23
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(19, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 20)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Section:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SectBtn
        '
        Me.SectBtn.AutoSize = True
        Me.SectBtn.Location = New System.Drawing.Point(126, 145)
        Me.SectBtn.Name = "SectBtn"
        Me.SectBtn.Size = New System.Drawing.Size(73, 21)
        Me.SectBtn.TabIndex = 27
        Me.SectBtn.Text = "Section"
        Me.SectBtn.UseVisualStyleBackColor = True
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.Location = New System.Drawing.Point(19, 143)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBtn.TabIndex = 28
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(19, 90)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(95, 20)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "Designation:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Me.Tbl_HRM_SectionTableAdapter
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_DeptTableAdapter
        '
        Me.Tbl_HRM_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Select Month:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(375, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(117, 23)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.NonActivrBtn)
        Me.GroupBox5.Controls.Add(Me.ActiveBtn)
        Me.GroupBox5.Controls.Add(Me.AllEmp)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(21, 43)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(243, 58)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Active/Non Active Employees"
        '
        'NonActivrBtn
        '
        Me.NonActivrBtn.AutoSize = True
        Me.NonActivrBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActivrBtn.Location = New System.Drawing.Point(81, 27)
        Me.NonActivrBtn.Name = "NonActivrBtn"
        Me.NonActivrBtn.Size = New System.Drawing.Size(98, 21)
        Me.NonActivrBtn.TabIndex = 0
        Me.NonActivrBtn.Text = "Non Active "
        Me.NonActivrBtn.UseVisualStyleBackColor = True
        '
        'ActiveBtn
        '
        Me.ActiveBtn.AutoSize = True
        Me.ActiveBtn.Checked = True
        Me.ActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.ActiveBtn.Location = New System.Drawing.Point(16, 27)
        Me.ActiveBtn.Name = "ActiveBtn"
        Me.ActiveBtn.Size = New System.Drawing.Size(64, 21)
        Me.ActiveBtn.TabIndex = 0
        Me.ActiveBtn.TabStop = True
        Me.ActiveBtn.Text = "Active"
        Me.ActiveBtn.UseVisualStyleBackColor = True
        '
        'AllEmp
        '
        Me.AllEmp.AutoSize = True
        Me.AllEmp.ForeColor = System.Drawing.Color.Black
        Me.AllEmp.Location = New System.Drawing.Point(182, 27)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'frmAllowanceReports
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(951, 682)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Dedpanel)
        Me.Controls.Add(Me.Allowancepanel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAllowanceReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allowance And Deductions Reports"
        Me.Allowancepanel.ResumeLayout(False)
        Me.Allowancepanel.PerformLayout()
        Me.Dedpanel.ResumeLayout(False)
        Me.Dedpanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RebtBtn As System.Windows.Forms.RadioButton
    Friend WithEvents EduAll As System.Windows.Forms.RadioButton
    Friend WithEvents SPcAll As System.Windows.Forms.RadioButton
    Friend WithEvents TravelBtn As System.Windows.Forms.RadioButton
    Friend WithEvents MealAll As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtBtn As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Allowancepanel As GroupBox
    Friend WithEvents AccAllow As RadioButton
    Friend WithEvents Dedpanel As GroupBox
    Friend WithEvents CantBtn As RadioButton
    Friend WithEvents EOBIBTn As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AllowanceBtn As RadioButton
    Friend WithEvents DedBtn As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents All As RadioButton
    Friend WithEvents CrdRange As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DesigComboBox As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents MainDeptBtn As RadioButton
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents SectBtn As RadioButton
    Friend WithEvents DesigBtn As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents PESSiBTN As RadioButton
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents Sinrity As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents NonActivrBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
End Class
