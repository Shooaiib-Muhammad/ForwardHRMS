<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contractualinfo
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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim SectionNameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeptPanel = New System.Windows.Forms.Panel()
        Me.Section = New System.Windows.Forms.RadioButton()
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.AllDept = New System.Windows.Forms.RadioButton()
        Me.Deigantionbtn = New System.Windows.Forms.RadioButton()
        Me.MainDept = New System.Windows.Forms.RadioButton()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRptShow = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AbsnBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.MonthAttBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbtShiftsAndDate = New System.Windows.Forms.RadioButton()
        Me.PESSIEmpBtn = New System.Windows.Forms.RadioButton()
        Me.EOBiEmpBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.MissBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.NonActiveBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bymonth = New System.Windows.Forms.DateTimePicker()
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AllButton = New System.Windows.Forms.RadioButton()
        Me.CardRange = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        SectionNameLabel = New System.Windows.Forms.Label()
        Me.DeptPanel.SuspendLayout()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(8, 43)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(89, 17)
        Label7.TabIndex = 0
        Label7.Text = "Depatrment:"
        '
        'Label8
        '
        Label8.ForeColor = System.Drawing.Color.Black
        Label8.Location = New System.Drawing.Point(8, 99)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(89, 17)
        Label8.TabIndex = 4
        Label8.Text = "Designation:"
        '
        'SectionNameLabel
        '
        SectionNameLabel.AutoSize = True
        SectionNameLabel.Location = New System.Drawing.Point(8, 73)
        SectionNameLabel.Name = "SectionNameLabel"
        SectionNameLabel.Size = New System.Drawing.Size(63, 17)
        SectionNameLabel.TabIndex = 8
        SectionNameLabel.Text = "Section :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1161, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Contractual Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeptPanel
        '
        Me.DeptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptPanel.Controls.Add(Me.Section)
        Me.DeptPanel.Controls.Add(SectionNameLabel)
        Me.DeptPanel.Controls.Add(Me.SectionNameComboBox)
        Me.DeptPanel.Controls.Add(Me.Label6)
        Me.DeptPanel.Controls.Add(Me.DeptNameComboBox)
        Me.DeptPanel.Controls.Add(Label7)
        Me.DeptPanel.Controls.Add(Me.AllDept)
        Me.DeptPanel.Controls.Add(Me.Deigantionbtn)
        Me.DeptPanel.Controls.Add(Label8)
        Me.DeptPanel.Controls.Add(Me.MainDept)
        Me.DeptPanel.Controls.Add(Me.DesigNameComboBox)
        Me.DeptPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptPanel.Location = New System.Drawing.Point(334, 157)
        Me.DeptPanel.Name = "DeptPanel"
        Me.DeptPanel.Size = New System.Drawing.Size(426, 215)
        Me.DeptPanel.TabIndex = 24
        '
        'Section
        '
        Me.Section.AutoSize = True
        Me.Section.ForeColor = System.Drawing.Color.Black
        Me.Section.Location = New System.Drawing.Point(115, 157)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(73, 21)
        Me.Section.TabIndex = 10
        Me.Section.Text = "Section"
        Me.Section.UseVisualStyleBackColor = True
        '
        'SectionNameComboBox
        '
        Me.SectionNameComboBox.DataSource = Me.Tbl_HRM_SectionBindingSource
        Me.SectionNameComboBox.DisplayMember = "SectionName"
        Me.SectionNameComboBox.Enabled = False
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(105, 70)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(284, 24)
        Me.SectionNameComboBox.TabIndex = 9
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
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(424, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Select Appropriate Option"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(105, 39)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(284, 24)
        Me.DeptNameComboBox.TabIndex = 1
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'AllDept
        '
        Me.AllDept.AutoSize = True
        Me.AllDept.Checked = True
        Me.AllDept.ForeColor = System.Drawing.Color.Black
        Me.AllDept.Location = New System.Drawing.Point(8, 130)
        Me.AllDept.Name = "AllDept"
        Me.AllDept.Size = New System.Drawing.Size(41, 21)
        Me.AllDept.TabIndex = 0
        Me.AllDept.TabStop = True
        Me.AllDept.Text = "All"
        Me.AllDept.UseVisualStyleBackColor = True
        '
        'Deigantionbtn
        '
        Me.Deigantionbtn.AutoSize = True
        Me.Deigantionbtn.ForeColor = System.Drawing.Color.Black
        Me.Deigantionbtn.Location = New System.Drawing.Point(8, 157)
        Me.Deigantionbtn.Name = "Deigantionbtn"
        Me.Deigantionbtn.Size = New System.Drawing.Size(101, 21)
        Me.Deigantionbtn.TabIndex = 0
        Me.Deigantionbtn.Text = "Designation"
        Me.Deigantionbtn.UseVisualStyleBackColor = True
        '
        'MainDept
        '
        Me.MainDept.AutoSize = True
        Me.MainDept.ForeColor = System.Drawing.Color.Black
        Me.MainDept.Location = New System.Drawing.Point(115, 130)
        Me.MainDept.Name = "MainDept"
        Me.MainDept.Size = New System.Drawing.Size(100, 21)
        Me.MainDept.TabIndex = 0
        Me.MainDept.Text = "Department"
        Me.MainDept.UseVisualStyleBackColor = True
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(105, 97)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(284, 24)
        Me.DesigNameComboBox.TabIndex = 5
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'btnRptShow
        '
        Me.btnRptShow.BackColor = System.Drawing.Color.Green
        Me.btnRptShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptShow.ForeColor = System.Drawing.Color.White
        Me.btnRptShow.Location = New System.Drawing.Point(596, 387)
        Me.btnRptShow.Name = "btnRptShow"
        Me.btnRptShow.Size = New System.Drawing.Size(164, 47)
        Me.btnRptShow.TabIndex = 23
        Me.btnRptShow.Text = "Show Report"
        Me.btnRptShow.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AbsnBtn)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.MonthAttBtn)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbtShiftsAndDate)
        Me.GroupBox1.Controls.Add(Me.PESSIEmpBtn)
        Me.GroupBox1.Controls.Add(Me.EOBiEmpBtn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 318)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector :"
        '
        'AbsnBtn
        '
        Me.AbsnBtn.AutoSize = True
        Me.AbsnBtn.ForeColor = System.Drawing.Color.Black
        Me.AbsnBtn.Location = New System.Drawing.Point(10, 102)
        Me.AbsnBtn.Name = "AbsnBtn"
        Me.AbsnBtn.Size = New System.Drawing.Size(105, 21)
        Me.AbsnBtn.TabIndex = 38
        Me.AbsnBtn.TabStop = True
        Me.AbsnBtn.Text = "Daily Absent"
        Me.AbsnBtn.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(6, 281)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(208, 21)
        Me.RadioButton7.TabIndex = 46
        Me.RadioButton7.Text = "Monthly Payment Slip Report"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(6, 255)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(181, 21)
        Me.RadioButton3.TabIndex = 43
        Me.RadioButton3.Text = "Monthly Payment Report"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(6, 231)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(278, 21)
        Me.RadioButton4.TabIndex = 42
        Me.RadioButton4.Text = "Contractors List for Inssurance Removal"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Black
        Me.RadioButton9.Location = New System.Drawing.Point(6, 205)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(223, 21)
        Me.RadioButton9.TabIndex = 41
        Me.RadioButton9.Text = "Contractors List for Inssurance "
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(10, 49)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(184, 21)
        Me.RadioButton2.TabIndex = 38
        Me.RadioButton2.Text = "Contractors Departments"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'MonthAttBtn
        '
        Me.MonthAttBtn.AutoSize = True
        Me.MonthAttBtn.ForeColor = System.Drawing.Color.Black
        Me.MonthAttBtn.Location = New System.Drawing.Point(6, 127)
        Me.MonthAttBtn.Name = "MonthAttBtn"
        Me.MonthAttBtn.Size = New System.Drawing.Size(155, 21)
        Me.MonthAttBtn.TabIndex = 39
        Me.MonthAttBtn.Text = "Monthly Attendance "
        Me.MonthAttBtn.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(10, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(119, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Contractor Info"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'rbtShiftsAndDate
        '
        Me.rbtShiftsAndDate.AutoSize = True
        Me.rbtShiftsAndDate.ForeColor = System.Drawing.Color.Black
        Me.rbtShiftsAndDate.Location = New System.Drawing.Point(10, 75)
        Me.rbtShiftsAndDate.Name = "rbtShiftsAndDate"
        Me.rbtShiftsAndDate.Size = New System.Drawing.Size(133, 21)
        Me.rbtShiftsAndDate.TabIndex = 38
        Me.rbtShiftsAndDate.Text = "Daily Attendance"
        Me.rbtShiftsAndDate.UseVisualStyleBackColor = True
        '
        'PESSIEmpBtn
        '
        Me.PESSIEmpBtn.AutoSize = True
        Me.PESSIEmpBtn.ForeColor = System.Drawing.Color.Black
        Me.PESSIEmpBtn.Location = New System.Drawing.Point(6, 179)
        Me.PESSIEmpBtn.Name = "PESSIEmpBtn"
        Me.PESSIEmpBtn.Size = New System.Drawing.Size(208, 21)
        Me.PESSIEmpBtn.TabIndex = 37
        Me.PESSIEmpBtn.Text = "PESSI Contribution (Monthly)"
        Me.PESSIEmpBtn.UseVisualStyleBackColor = True
        '
        'EOBiEmpBtn
        '
        Me.EOBiEmpBtn.AutoSize = True
        Me.EOBiEmpBtn.ForeColor = System.Drawing.Color.Black
        Me.EOBiEmpBtn.Location = New System.Drawing.Point(6, 153)
        Me.EOBiEmpBtn.Name = "EOBiEmpBtn"
        Me.EOBiEmpBtn.Size = New System.Drawing.Size(201, 21)
        Me.EOBiEmpBtn.TabIndex = 38
        Me.EOBiEmpBtn.Text = "EOBI Contribution (Monthly)"
        Me.EOBiEmpBtn.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(414, 574)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(226, 17)
        Me.RadioButton5.TabIndex = 44
        Me.RadioButton5.Text = "Monthly Contractual Payment Report OLD "
        Me.RadioButton5.UseVisualStyleBackColor = True
        Me.RadioButton5.Visible = False
        '
        'MissBtn
        '
        Me.MissBtn.AutoSize = True
        Me.MissBtn.ForeColor = System.Drawing.Color.Black
        Me.MissBtn.Location = New System.Drawing.Point(414, 597)
        Me.MissBtn.Name = "MissBtn"
        Me.MissBtn.Size = New System.Drawing.Size(97, 17)
        Me.MissBtn.TabIndex = 40
        Me.MissBtn.Text = "Missing Pic List"
        Me.MissBtn.UseVisualStyleBackColor = True
        Me.MissBtn.Visible = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(414, 531)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(148, 17)
        Me.RadioButton6.TabIndex = 45
        Me.RadioButton6.Text = "Missing Data Entry Report"
        Me.RadioButton6.UseVisualStyleBackColor = True
        Me.RadioButton6.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.NonActiveBtn)
        Me.GroupBox6.Controls.Add(Me.ActiveBtn)
        Me.GroupBox6.Controls.Add(Me.AllEmp)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(293, 60)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Active/Non Active Employees"
        '
        'NonActiveBtn
        '
        Me.NonActiveBtn.AutoSize = True
        Me.NonActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActiveBtn.Location = New System.Drawing.Point(90, 22)
        Me.NonActiveBtn.Name = "NonActiveBtn"
        Me.NonActiveBtn.Size = New System.Drawing.Size(98, 21)
        Me.NonActiveBtn.TabIndex = 0
        Me.NonActiveBtn.Text = "Non Active "
        Me.NonActiveBtn.UseVisualStyleBackColor = True
        '
        'ActiveBtn
        '
        Me.ActiveBtn.AutoSize = True
        Me.ActiveBtn.Checked = True
        Me.ActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.ActiveBtn.Location = New System.Drawing.Point(19, 22)
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
        Me.AllEmp.Location = New System.Drawing.Point(196, 22)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Me.Tbl_HRM_GradeTableAdapter
        Me.TableAdapterManager.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Me.Tbl_HRM_SectionTableAdapter
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Me.Tbl_HRM_ShiftTableAdapter
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Tbl_HRM_ShiftTableAdapter
        '
        Me.Tbl_HRM_ShiftTableAdapter.ClearBeforeFill = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox7.Controls.Add(Me.TextBox2)
        Me.GroupBox7.Controls.Add(Me.TextBox1)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Bymonth)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(334, 56)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(426, 97)
        Me.GroupBox7.TabIndex = 36
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Option Selector"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(216, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "To Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(288, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 23)
        Me.DateTimePicker1.TabIndex = 64
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(288, 59)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 23)
        Me.TextBox2.TabIndex = 61
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(110, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 60
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(216, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "To Card:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 20)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "From Card:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 18)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Select Month:"
        '
        'Bymonth
        '
        Me.Bymonth.CustomFormat = "MMM, yyyy"
        Me.Bymonth.Enabled = False
        Me.Bymonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Bymonth.Location = New System.Drawing.Point(110, 32)
        Me.Bymonth.Name = "Bymonth"
        Me.Bymonth.Size = New System.Drawing.Size(100, 23)
        Me.Bymonth.TabIndex = 0
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSHRM
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AllButton)
        Me.GroupBox3.Controls.Add(Me.CardRange)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(12, 428)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 81)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selector :"
        '
        'AllButton
        '
        Me.AllButton.AutoSize = True
        Me.AllButton.Checked = True
        Me.AllButton.ForeColor = System.Drawing.Color.Black
        Me.AllButton.Location = New System.Drawing.Point(19, 26)
        Me.AllButton.Name = "AllButton"
        Me.AllButton.Size = New System.Drawing.Size(41, 21)
        Me.AllButton.TabIndex = 21
        Me.AllButton.TabStop = True
        Me.AllButton.Text = "All"
        Me.AllButton.UseVisualStyleBackColor = True
        '
        'CardRange
        '
        Me.CardRange.AutoSize = True
        Me.CardRange.ForeColor = System.Drawing.Color.Black
        Me.CardRange.Location = New System.Drawing.Point(19, 53)
        Me.CardRange.Name = "CardRange"
        Me.CardRange.Size = New System.Drawing.Size(122, 21)
        Me.CardRange.TabIndex = 19
        Me.CardRange.Text = "By Card Range"
        Me.CardRange.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(371, 462)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(157, 17)
        Me.RadioButton8.TabIndex = 47
        Me.RadioButton8.Text = "Terminated Contractors  List"
        Me.RadioButton8.UseVisualStyleBackColor = True
        Me.RadioButton8.Visible = False
        '
        'Contractualinfo
        '
        Me.AcceptButton = Me.btnRptShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 770)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.MissBtn)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.DeptPanel)
        Me.Controls.Add(Me.btnRptShow)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Contractualinfo"
        Me.Text = "Contractualinfo"
        Me.DeptPanel.ResumeLayout(False)
        Me.DeptPanel.PerformLayout()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DeptPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents AllDept As RadioButton
    Friend WithEvents Deigantionbtn As RadioButton
    Friend WithEvents MainDept As RadioButton
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents btnRptShow As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents NonActiveBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents PESSIEmpBtn As RadioButton
    Friend WithEvents EOBiEmpBtn As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Bymonth As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AllButton As RadioButton
    Friend WithEvents CardRange As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents Section As RadioButton
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MonthAttBtn As RadioButton
    Friend WithEvents rbtShiftsAndDate As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents MissBtn As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents AbsnBtn As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
End Class
