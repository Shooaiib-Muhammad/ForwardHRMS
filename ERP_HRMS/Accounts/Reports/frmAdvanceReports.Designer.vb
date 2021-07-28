<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdvanceReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
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
        Dim BankNameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PADvLedger = New System.Windows.Forms.RadioButton()
        Me.PAdvBlnc = New System.Windows.Forms.RadioButton()
        Me.padvAnnlLeave = New System.Windows.Forms.RadioButton()
        Me.PADvZeroDed = New System.Windows.Forms.RadioButton()
        Me.TADvRecv = New System.Windows.Forms.RadioButton()
        Me.PAdvRec = New System.Windows.Forms.RadioButton()
        Me.PADvDed = New System.Windows.Forms.RadioButton()
        Me.TAdvpaid = New System.Windows.Forms.RadioButton()
        Me.RptViewer = New System.Windows.Forms.Button()
        Me.Tocrd = New System.Windows.Forms.TextBox()
        Me.FrmCrd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MonthPicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DesigComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_DesignationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDeptsForPayrollReport = New ERP_HRMS.DSDeptsForPayrollReport()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_SubDept1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_DepartmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDeptBtn = New System.Windows.Forms.RadioButton()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.SectBtn = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Tbl_Hrm_DepartmentsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter()
        Me.Tbl_Hrm_SubDept1TableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter()
        Me.Tbl_Hrm_DesignationsTableAdapter = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSDeptsForPayrollReportTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NonActivrBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Blance = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ByBranch = New System.Windows.Forms.RadioButton()
        Me.All = New System.Windows.Forms.RadioButton()
        Me.CrdRange = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TransferBtn = New System.Windows.Forms.RadioButton()
        Me.AllBtn = New System.Windows.Forms.RadioButton()
        Me.CashBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_BankTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BankTableAdapter()
        Me.BankNameComboBox = New System.Windows.Forms.ComboBox()
        BranchNameLabel = New System.Windows.Forms.Label()
        BankNameLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Tbl_HRM_BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(20, 114)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(100, 20)
        BranchNameLabel.TabIndex = 30
        BranchNameLabel.Text = "Branch:"
        BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1051, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Advance Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PADvLedger
        '
        Me.PADvLedger.AutoSize = True
        Me.PADvLedger.ForeColor = System.Drawing.Color.Black
        Me.PADvLedger.Location = New System.Drawing.Point(20, 197)
        Me.PADvLedger.Name = "PADvLedger"
        Me.PADvLedger.Size = New System.Drawing.Size(143, 21)
        Me.PADvLedger.TabIndex = 19
        Me.PADvLedger.Text = "P.Advance Ledger"
        Me.PADvLedger.UseVisualStyleBackColor = True
        '
        'PAdvBlnc
        '
        Me.PAdvBlnc.AutoSize = True
        Me.PAdvBlnc.ForeColor = System.Drawing.Color.Black
        Me.PAdvBlnc.Location = New System.Drawing.Point(20, 175)
        Me.PAdvBlnc.Name = "PAdvBlnc"
        Me.PAdvBlnc.Size = New System.Drawing.Size(153, 21)
        Me.PAdvBlnc.TabIndex = 7
        Me.PAdvBlnc.Text = "P. Advance Balance"
        Me.PAdvBlnc.UseVisualStyleBackColor = True
        '
        'padvAnnlLeave
        '
        Me.padvAnnlLeave.AutoSize = True
        Me.padvAnnlLeave.ForeColor = System.Drawing.Color.Black
        Me.padvAnnlLeave.Location = New System.Drawing.Point(20, 219)
        Me.padvAnnlLeave.Name = "padvAnnlLeave"
        Me.padvAnnlLeave.Size = New System.Drawing.Size(285, 21)
        Me.padvAnnlLeave.TabIndex = 11
        Me.padvAnnlLeave.Text = "P Adv. Deducted Against Annual Leaves "
        Me.padvAnnlLeave.UseVisualStyleBackColor = True
        '
        'PADvZeroDed
        '
        Me.PADvZeroDed.AutoSize = True
        Me.PADvZeroDed.ForeColor = System.Drawing.Color.Black
        Me.PADvZeroDed.Location = New System.Drawing.Point(20, 263)
        Me.PADvZeroDed.Name = "PADvZeroDed"
        Me.PADvZeroDed.Size = New System.Drawing.Size(274, 21)
        Me.PADvZeroDed.TabIndex = 10
        Me.PADvZeroDed.Text = "P Adv. Employees With Zero Deduction"
        Me.PADvZeroDed.UseVisualStyleBackColor = True
        '
        'TADvRecv
        '
        Me.TADvRecv.AutoSize = True
        Me.TADvRecv.ForeColor = System.Drawing.Color.Black
        Me.TADvRecv.Location = New System.Drawing.Point(20, 43)
        Me.TADvRecv.Name = "TADvRecv"
        Me.TADvRecv.Size = New System.Drawing.Size(225, 21)
        Me.TADvRecv.TabIndex = 3
        Me.TADvRecv.Text = "T Adv. Received Against Salary"
        Me.TADvRecv.UseVisualStyleBackColor = True
        '
        'PAdvRec
        '
        Me.PAdvRec.AutoSize = True
        Me.PAdvRec.ForeColor = System.Drawing.Color.Black
        Me.PAdvRec.Location = New System.Drawing.Point(20, 153)
        Me.PAdvRec.Name = "PAdvRec"
        Me.PAdvRec.Size = New System.Drawing.Size(161, 21)
        Me.PAdvRec.TabIndex = 9
        Me.PAdvRec.Text = "P. Advance Received"
        Me.PAdvRec.UseVisualStyleBackColor = True
        '
        'PADvDed
        '
        Me.PADvDed.AutoSize = True
        Me.PADvDed.ForeColor = System.Drawing.Color.Black
        Me.PADvDed.Location = New System.Drawing.Point(20, 241)
        Me.PADvDed.Name = "PADvDed"
        Me.PADvDed.Size = New System.Drawing.Size(176, 21)
        Me.PADvDed.TabIndex = 6
        Me.PADvDed.Text = "P Adv. Expected Return"
        Me.PADvDed.UseVisualStyleBackColor = True
        '
        'TAdvpaid
        '
        Me.TAdvpaid.AutoSize = True
        Me.TAdvpaid.Checked = True
        Me.TAdvpaid.ForeColor = System.Drawing.Color.Black
        Me.TAdvpaid.Location = New System.Drawing.Point(20, 21)
        Me.TAdvpaid.Name = "TAdvpaid"
        Me.TAdvpaid.Size = New System.Drawing.Size(103, 21)
        Me.TAdvpaid.TabIndex = 2
        Me.TAdvpaid.TabStop = True
        Me.TAdvpaid.Text = "T Adv. Paid "
        Me.TAdvpaid.UseVisualStyleBackColor = True
        '
        'RptViewer
        '
        Me.RptViewer.BackColor = System.Drawing.Color.Green
        Me.RptViewer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RptViewer.ForeColor = System.Drawing.Color.White
        Me.RptViewer.Location = New System.Drawing.Point(371, 519)
        Me.RptViewer.Name = "RptViewer"
        Me.RptViewer.Size = New System.Drawing.Size(135, 47)
        Me.RptViewer.TabIndex = 12
        Me.RptViewer.Text = "Show Report"
        Me.RptViewer.UseVisualStyleBackColor = False
        '
        'Tocrd
        '
        Me.Tocrd.Enabled = False
        Me.Tocrd.Location = New System.Drawing.Point(307, 55)
        Me.Tocrd.Name = "Tocrd"
        Me.Tocrd.Size = New System.Drawing.Size(75, 23)
        Me.Tocrd.TabIndex = 21
        Me.Tocrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmCrd
        '
        Me.FrmCrd.Enabled = False
        Me.FrmCrd.Location = New System.Drawing.Point(121, 54)
        Me.FrmCrd.Name = "FrmCrd"
        Me.FrmCrd.Size = New System.Drawing.Size(84, 23)
        Me.FrmCrd.TabIndex = 20
        Me.FrmCrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(239, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "To Card:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(20, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "From Card:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(20, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Select Month:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MonthPicker
        '
        Me.MonthPicker.CustomFormat = "MMM, yyyy"
        Me.MonthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MonthPicker.Location = New System.Drawing.Point(121, 29)
        Me.MonthPicker.Name = "MonthPicker"
        Me.MonthPicker.Size = New System.Drawing.Size(95, 23)
        Me.MonthPicker.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RadioButton2)
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
        Me.Panel2.Location = New System.Drawing.Point(374, 304)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 192)
        Me.Panel2.TabIndex = 12
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(18, 125)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(93, 20)
        Me.RadioButton2.TabIndex = 30
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "All"
        Me.RadioButton2.UseVisualStyleBackColor = True
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
        Me.DesigComboBox.DataSource = Me.Tbl_Hrm_DesignationsBindingSource
        Me.DesigComboBox.DisplayMember = "DesigName"
        Me.DesigComboBox.Enabled = False
        Me.DesigComboBox.FormattingEnabled = True
        Me.DesigComboBox.Location = New System.Drawing.Point(111, 96)
        Me.DesigComboBox.Name = "DesigComboBox"
        Me.DesigComboBox.Size = New System.Drawing.Size(268, 24)
        Me.DesigComboBox.TabIndex = 25
        Me.DesigComboBox.ValueMember = "DesignationID"
        '
        'Tbl_Hrm_DesignationsBindingSource
        '
        Me.Tbl_Hrm_DesignationsBindingSource.DataMember = "tbl_Hrm_Designations"
        Me.Tbl_Hrm_DesignationsBindingSource.DataSource = Me.DSDeptsForPayrollReport
        '
        'DSDeptsForPayrollReport
        '
        Me.DSDeptsForPayrollReport.DataSetName = "DSDeptsForPayrollReport"
        Me.DSDeptsForPayrollReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.NameComboBox.DataSource = Me.Tbl_Hrm_SubDept1BindingSource
        Me.NameComboBox.DisplayMember = "SectionName"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(111, 66)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(268, 24)
        Me.NameComboBox.TabIndex = 24
        Me.NameComboBox.ValueMember = "SectionID"
        '
        'Tbl_Hrm_SubDept1BindingSource
        '
        Me.Tbl_Hrm_SubDept1BindingSource.DataMember = "tbl_Hrm_Departments_tbl_Hrm_SubDept1"
        Me.Tbl_Hrm_SubDept1BindingSource.DataSource = Me.Tbl_Hrm_DepartmentsBindingSource
        '
        'Tbl_Hrm_DepartmentsBindingSource
        '
        Me.Tbl_Hrm_DepartmentsBindingSource.DataMember = "tbl_Hrm_Departments"
        Me.Tbl_Hrm_DepartmentsBindingSource.DataSource = Me.DSDeptsForPayrollReport
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
        Me.DeptNameComboBox.DataSource = Me.Tbl_Hrm_DepartmentsBindingSource
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
        Me.DesigBtn.Location = New System.Drawing.Point(18, 154)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBtn.TabIndex = 28
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'SectBtn
        '
        Me.SectBtn.AutoSize = True
        Me.SectBtn.Location = New System.Drawing.Point(136, 153)
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
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(120, 110)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(262, 24)
        Me.BranchNameComboBox.TabIndex = 31
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
        'Tbl_Hrm_DepartmentsTableAdapter
        '
        Me.Tbl_Hrm_DepartmentsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_SubDept1TableAdapter
        '
        Me.Tbl_Hrm_SubDept1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_DesignationsTableAdapter
        '
        Me.Tbl_Hrm_DesignationsTableAdapter.ClearBeforeFill = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NonActivrBtn)
        Me.GroupBox1.Controls.Add(Me.ActiveBtn)
        Me.GroupBox1.Controls.Add(Me.AllEmp)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(46, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 60)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Active/Non Active Employees"
        '
        'NonActivrBtn
        '
        Me.NonActivrBtn.AutoSize = True
        Me.NonActivrBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActivrBtn.Location = New System.Drawing.Point(101, 22)
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
        Me.ActiveBtn.Location = New System.Drawing.Point(20, 22)
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
        Me.AllEmp.Location = New System.Drawing.Point(210, 22)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(20, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Balance :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Blance
        '
        Me.Blance.Enabled = False
        Me.Blance.FormattingEnabled = True
        Me.Blance.Items.AddRange(New Object() {">0", "=0"})
        Me.Blance.Location = New System.Drawing.Point(121, 80)
        Me.Blance.Name = "Blance"
        Me.Blance.Size = New System.Drawing.Size(84, 24)
        Me.Blance.TabIndex = 22
        Me.Blance.Text = ">0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ByBranch)
        Me.GroupBox2.Controls.Add(Me.All)
        Me.GroupBox2.Controls.Add(Me.CrdRange)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(55, 500)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 94)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selection"
        '
        'ByBranch
        '
        Me.ByBranch.AutoSize = True
        Me.ByBranch.ForeColor = System.Drawing.Color.Black
        Me.ByBranch.Location = New System.Drawing.Point(20, 70)
        Me.ByBranch.Name = "ByBranch"
        Me.ByBranch.Size = New System.Drawing.Size(95, 21)
        Me.ByBranch.TabIndex = 1
        Me.ByBranch.TabStop = True
        Me.ByBranch.Text = "By Branch "
        Me.ByBranch.UseVisualStyleBackColor = True
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(BankNameLabel)
        Me.GroupBox3.Controls.Add(Me.BankNameComboBox)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(BranchNameLabel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox3.Controls.Add(Me.Tocrd)
        Me.GroupBox3.Controls.Add(Me.MonthPicker)
        Me.GroupBox3.Controls.Add(Me.FrmCrd)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Blance)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(367, 111)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 179)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selection"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(218, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "To Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(287, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 23)
        Me.DateTimePicker1.TabIndex = 34
        Me.DateTimePicker1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton15)
        Me.GroupBox4.Controls.Add(Me.RadioButton8)
        Me.GroupBox4.Controls.Add(Me.RadioButton7)
        Me.GroupBox4.Controls.Add(Me.RadioButton6)
        Me.GroupBox4.Controls.Add(Me.RadioButton5)
        Me.GroupBox4.Controls.Add(Me.RadioButton4)
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Controls.Add(Me.PADvLedger)
        Me.GroupBox4.Controls.Add(Me.TAdvpaid)
        Me.GroupBox4.Controls.Add(Me.PADvDed)
        Me.GroupBox4.Controls.Add(Me.PAdvBlnc)
        Me.GroupBox4.Controls.Add(Me.PAdvRec)
        Me.GroupBox4.Controls.Add(Me.TADvRecv)
        Me.GroupBox4.Controls.Add(Me.PADvZeroDed)
        Me.GroupBox4.Controls.Add(Me.padvAnnlLeave)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(46, 107)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(314, 379)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Report Selection"
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(20, 307)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(117, 21)
        Me.RadioButton7.TabIndex = 25
        Me.RadioButton7.Text = "RFD Advance "
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(20, 285)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(224, 21)
        Me.RadioButton6.TabIndex = 24
        Me.RadioButton6.Text = "P. Advance Paid against Bonus"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(20, 131)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(277, 21)
        Me.RadioButton5.TabIndex = 23
        Me.RadioButton5.Text = "P. Advance Paid against Annual leaves "
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(20, 87)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(156, 21)
        Me.RadioButton4.TabIndex = 22
        Me.RadioButton4.Text = "T Adv. Received List"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(20, 65)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(101, 21)
        Me.RadioButton3.TabIndex = 21
        Me.RadioButton3.Text = "T Adv. Slips"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(20, 109)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(126, 21)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.Text = "P.Advance Paid"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager1.tbl_HRM_BranchTableAdapter = Me.Tbl_HRM_BranchTableAdapter
        Me.TableAdapterManager1.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_DeptTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_DesignationTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_Info1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(18, 329)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(150, 21)
        Me.RadioButton8.TabIndex = 26
        Me.RadioButton8.Text = "T Adv Receiving list"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TransferBtn)
        Me.GroupBox5.Controls.Add(Me.AllBtn)
        Me.GroupBox5.Controls.Add(Me.CashBtn)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(52, 492)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(310, 114)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Select Appropriate Option     "
        Me.GroupBox5.Visible = False
        '
        'TransferBtn
        '
        Me.TransferBtn.AutoSize = True
        Me.TransferBtn.ForeColor = System.Drawing.Color.Black
        Me.TransferBtn.Location = New System.Drawing.Point(19, 65)
        Me.TransferBtn.Name = "TransferBtn"
        Me.TransferBtn.Size = New System.Drawing.Size(80, 21)
        Me.TransferBtn.TabIndex = 8
        Me.TransferBtn.Text = "Transfer"
        Me.TransferBtn.UseVisualStyleBackColor = True
        '
        'AllBtn
        '
        Me.AllBtn.AutoSize = True
        Me.AllBtn.Checked = True
        Me.AllBtn.ForeColor = System.Drawing.Color.Black
        Me.AllBtn.Location = New System.Drawing.Point(19, 21)
        Me.AllBtn.Name = "AllBtn"
        Me.AllBtn.Size = New System.Drawing.Size(41, 21)
        Me.AllBtn.TabIndex = 6
        Me.AllBtn.TabStop = True
        Me.AllBtn.Text = "All"
        Me.AllBtn.UseVisualStyleBackColor = True
        '
        'CashBtn
        '
        Me.CashBtn.AutoSize = True
        Me.CashBtn.ForeColor = System.Drawing.Color.Black
        Me.CashBtn.Location = New System.Drawing.Point(19, 44)
        Me.CashBtn.Name = "CashBtn"
        Me.CashBtn.Size = New System.Drawing.Size(58, 21)
        Me.CashBtn.TabIndex = 7
        Me.CashBtn.Text = "Cash"
        Me.CashBtn.UseVisualStyleBackColor = True
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.ForeColor = System.Drawing.Color.Black
        Me.RadioButton15.Location = New System.Drawing.Point(18, 356)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(157, 21)
        Me.RadioButton15.TabIndex = 47
        Me.RadioButton15.TabStop = True
        Me.RadioButton15.Text = "T Adv Transfer letter"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_BankBindingSource
        '
        Me.Tbl_HRM_BankBindingSource.DataMember = "tbl_HRM_Bank"
        Me.Tbl_HRM_BankBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_BankTableAdapter
        '
        Me.Tbl_HRM_BankTableAdapter.ClearBeforeFill = True
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.ForeColor = System.Drawing.Color.Black
        BankNameLabel.Location = New System.Drawing.Point(20, 140)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(85, 17)
        BankNameLabel.TabIndex = 35
        BankNameLabel.Text = "Bank Name:"
        '
        'BankNameComboBox
        '
        Me.BankNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BankNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BankNameComboBox.DataSource = Me.Tbl_HRM_BankBindingSource
        Me.BankNameComboBox.DisplayMember = "BankName"
        Me.BankNameComboBox.Enabled = False
        Me.BankNameComboBox.FormattingEnabled = True
        Me.BankNameComboBox.Location = New System.Drawing.Point(120, 137)
        Me.BankNameComboBox.Name = "BankNameComboBox"
        Me.BankNameComboBox.Size = New System.Drawing.Size(262, 24)
        Me.BankNameComboBox.TabIndex = 36
        Me.BankNameComboBox.ValueMember = "BankID"
        '
        'frmAdvanceReports
        '
        Me.AcceptButton = Me.RptViewer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1051, 733)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RptViewer)
        Me.Name = "frmAdvanceReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Reports"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Hrm_DesignationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDeptsForPayrollReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_SubDept1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_DepartmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Tbl_HRM_BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PADvDed As System.Windows.Forms.RadioButton
    Friend WithEvents TAdvpaid As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MonthPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RptViewer As System.Windows.Forms.Button
    Friend WithEvents PAdvRec As System.Windows.Forms.RadioButton
    Friend WithEvents TADvRecv As System.Windows.Forms.RadioButton
    Friend WithEvents PADvZeroDed As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents padvAnnlLeave As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DesigComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents NameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MainDeptBtn As System.Windows.Forms.RadioButton
    Friend WithEvents DeptNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents SectBtn As System.Windows.Forms.RadioButton
    Friend WithEvents DesigBtn As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DSDeptsForPayrollReport As ERP_HRMS.DSDeptsForPayrollReport
    Friend WithEvents Tbl_Hrm_DepartmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_DepartmentsTableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DepartmentsTableAdapter
    Friend WithEvents Tbl_Hrm_SubDept1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_SubDept1TableAdapter As ERP_HRMS.DSDeptsForPayrollReportTableAdapters.tbl_Hrm_SubDept1TableAdapter
    Friend WithEvents PAdvBlnc As System.Windows.Forms.RadioButton
    Friend WithEvents Tocrd As System.Windows.Forms.TextBox
    Friend WithEvents FrmCrd As System.Windows.Forms.TextBox
    Friend WithEvents PADvLedger As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_Hrm_DesignationsBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_DesignationsTableAdapter As DSDeptsForPayrollReportTableAdapters.tbl_Hrm_DesignationsTableAdapter
    Friend WithEvents TableAdapterManager As DSDeptsForPayrollReportTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NonActivrBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Blance As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents All As RadioButton
    Friend WithEvents CrdRange As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ByBranch As RadioButton
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents TableAdapterManager1 As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TransferBtn As RadioButton
    Friend WithEvents AllBtn As RadioButton
    Friend WithEvents CashBtn As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents Tbl_HRM_BankBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BankTableAdapter As DSHRMTableAdapters.tbl_HRM_BankTableAdapter
    Friend WithEvents BankNameComboBox As ComboBox
End Class
