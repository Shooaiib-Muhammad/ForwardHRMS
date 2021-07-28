<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mediReports
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
        Dim MadicationHeadLabel As System.Windows.Forms.Label
        Dim L1IDLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ByMedican = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.ByCatagery = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.byDaterange = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Emp_Med_ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMedication = New ERP_HRMS.DSMedication()
        Me.L1IDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Emp_Med_Item_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MadicationHeadComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tocrd = New System.Windows.Forms.TextBox()
        Me.MonthPicker = New System.Windows.Forms.DateTimePicker()
        Me.FrmCrd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioDeptAll = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DesigComboBox = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.MainDeptBtn = New System.Windows.Forms.RadioButton()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.SectBtn = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.RptViewer = New System.Windows.Forms.Button()
        Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Medication_Rec_HeadTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSMedicationTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Emp_Med_Item_HeadTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Med_Item_HeadTableAdapter()
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Med_ItemTableAdapter()
        MadicationHeadLabel = New System.Windows.Forms.Label()
        L1IDLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_HRM_Emp_Med_ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Med_Item_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MadicationHeadLabel
        '
        MadicationHeadLabel.ForeColor = System.Drawing.Color.Black
        MadicationHeadLabel.Location = New System.Drawing.Point(6, 89)
        MadicationHeadLabel.Name = "MadicationHeadLabel"
        MadicationHeadLabel.Size = New System.Drawing.Size(91, 17)
        MadicationHeadLabel.TabIndex = 43
        MadicationHeadLabel.Text = "Category :"
        '
        'L1IDLabel
        '
        L1IDLabel.AutoSize = True
        L1IDLabel.ForeColor = System.Drawing.Color.Black
        L1IDLabel.Location = New System.Drawing.Point(6, 124)
        L1IDLabel.Name = "L1IDLabel"
        L1IDLabel.Size = New System.Drawing.Size(106, 17)
        L1IDLabel.TabIndex = 44
        L1IDLabel.Text = "Product Name :"
        '
        'Label7
        '
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(6, 155)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(93, 17)
        Label7.TabIndex = 46
        Label7.Text = "Medicine :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1129, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Medication Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton12)
        Me.GroupBox1.Controls.Add(Me.RadioButton11)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(46, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 266)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reports Selection"
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton12.Location = New System.Drawing.Point(14, 114)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(144, 21)
        Me.RadioButton12.TabIndex = 9
        Me.RadioButton12.Text = "Medicines Balance"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton11.Location = New System.Drawing.Point(14, 180)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(152, 21)
        Me.RadioButton11.TabIndex = 8
        Me.RadioButton11.Text = "Patient Visit History "
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton8.Location = New System.Drawing.Point(14, 224)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(163, 21)
        Me.RadioButton8.TabIndex = 7
        Me.RadioButton8.Text = "Medicines Names List"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton7.Location = New System.Drawing.Point(14, 158)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(178, 21)
        Me.RadioButton7.TabIndex = 6
        Me.RadioButton7.Text = "Patient Medicine History"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton6.Location = New System.Drawing.Point(14, 202)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(152, 21)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.Text = "Treatment Category"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton5.Location = New System.Drawing.Point(14, 136)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(153, 21)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.Text = "Patient Appointment"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton4.Location = New System.Drawing.Point(14, 92)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(138, 21)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.Text = "Medicines Ledger"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton3.Location = New System.Drawing.Point(14, 70)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(128, 21)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Transaction Out"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton2.Location = New System.Drawing.Point(14, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(116, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Transaction In"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton1.Location = New System.Drawing.Point(14, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Patient Slip "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ByMedican)
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Controls.Add(Me.ByCatagery)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.byDaterange)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(46, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 147)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option  Selection"
        '
        'ByMedican
        '
        Me.ByMedican.AutoSize = True
        Me.ByMedican.Enabled = False
        Me.ByMedican.ForeColor = System.Drawing.Color.Black
        Me.ByMedican.Location = New System.Drawing.Point(14, 114)
        Me.ByMedican.Name = "ByMedican"
        Me.ByMedican.Size = New System.Drawing.Size(102, 21)
        Me.ByMedican.TabIndex = 12
        Me.ByMedican.TabStop = True
        Me.ByMedican.Text = "By Medicine"
        Me.ByMedican.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Enabled = False
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(14, 91)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(136, 21)
        Me.RadioButton10.TabIndex = 11
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "By Product Name"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'ByCatagery
        '
        Me.ByCatagery.AutoSize = True
        Me.ByCatagery.Enabled = False
        Me.ByCatagery.ForeColor = System.Drawing.Color.Black
        Me.ByCatagery.Location = New System.Drawing.Point(14, 68)
        Me.ByCatagery.Name = "ByCatagery"
        Me.ByCatagery.Size = New System.Drawing.Size(103, 21)
        Me.ByCatagery.TabIndex = 10
        Me.ByCatagery.TabStop = True
        Me.ByCatagery.Text = "By Category"
        Me.ByCatagery.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadioButton9.Location = New System.Drawing.Point(14, 45)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(122, 21)
        Me.RadioButton9.TabIndex = 9
        Me.RadioButton9.Text = "By Card Range"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'byDaterange
        '
        Me.byDaterange.AutoSize = True
        Me.byDaterange.Checked = True
        Me.byDaterange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.byDaterange.Location = New System.Drawing.Point(14, 22)
        Me.byDaterange.Name = "byDaterange"
        Me.byDaterange.Size = New System.Drawing.Size(122, 21)
        Me.byDaterange.TabIndex = 8
        Me.byDaterange.TabStop = True
        Me.byDaterange.Text = "By Date Range"
        Me.byDaterange.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label7)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(L1IDLabel)
        Me.GroupBox3.Controls.Add(Me.L1IDComboBox)
        Me.GroupBox3.Controls.Add(MadicationHeadLabel)
        Me.GroupBox3.Controls.Add(Me.MadicationHeadComboBox)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Tocrd)
        Me.GroupBox3.Controls.Add(Me.MonthPicker)
        Me.GroupBox3.Controls.Add(Me.FrmCrd)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(276, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(395, 192)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option  Selection"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_HRM_Emp_Med_ItemBindingSource
        Me.ComboBox1.DisplayMember = "L2Name"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(113, 152)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(262, 24)
        Me.ComboBox1.TabIndex = 47
        Me.ComboBox1.ValueMember = "L2ID"
        '
        'Tbl_HRM_Emp_Med_ItemBindingSource
        '
        Me.Tbl_HRM_Emp_Med_ItemBindingSource.DataMember = "tbl_HRM_Emp_Med_Item"
        Me.Tbl_HRM_Emp_Med_ItemBindingSource.DataSource = Me.DSMedication
        '
        'DSMedication
        '
        Me.DSMedication.DataSetName = "DSMedication"
        Me.DSMedication.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'L1IDComboBox
        '
        Me.L1IDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.L1IDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.L1IDComboBox.DataSource = Me.Tbl_HRM_Emp_Med_Item_HeadBindingSource
        Me.L1IDComboBox.DisplayMember = "L1Name"
        Me.L1IDComboBox.Enabled = False
        Me.L1IDComboBox.FormattingEnabled = True
        Me.L1IDComboBox.Location = New System.Drawing.Point(113, 119)
        Me.L1IDComboBox.Name = "L1IDComboBox"
        Me.L1IDComboBox.Size = New System.Drawing.Size(262, 24)
        Me.L1IDComboBox.TabIndex = 45
        Me.L1IDComboBox.ValueMember = "L1ID"
        '
        'Tbl_HRM_Emp_Med_Item_HeadBindingSource
        '
        Me.Tbl_HRM_Emp_Med_Item_HeadBindingSource.DataMember = "tbl_HRM_Emp_Med_Item_Head"
        Me.Tbl_HRM_Emp_Med_Item_HeadBindingSource.DataSource = Me.DSMedication
        '
        'MadicationHeadComboBox
        '
        Me.MadicationHeadComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MadicationHeadComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MadicationHeadComboBox.DataSource = Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource
        Me.MadicationHeadComboBox.DisplayMember = "MadicationHead"
        Me.MadicationHeadComboBox.Enabled = False
        Me.MadicationHeadComboBox.FormattingEnabled = True
        Me.MadicationHeadComboBox.Location = New System.Drawing.Point(113, 85)
        Me.MadicationHeadComboBox.Name = "MadicationHeadComboBox"
        Me.MadicationHeadComboBox.Size = New System.Drawing.Size(262, 24)
        Me.MadicationHeadComboBox.TabIndex = 44
        Me.MadicationHeadComboBox.ValueMember = "MadicationHead"
        '
        'Tbl_HRM_Emp_Medication_Rec_HeadBindingSource
        '
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource.DataMember = "tbl_HRM_Emp_Medication_Rec_Head"
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource.DataSource = Me.DSMedication
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(205, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "To Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(274, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 23)
        Me.DateTimePicker1.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "From Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tocrd
        '
        Me.Tocrd.Enabled = False
        Me.Tocrd.Location = New System.Drawing.Point(274, 52)
        Me.Tocrd.Name = "Tocrd"
        Me.Tocrd.Size = New System.Drawing.Size(95, 23)
        Me.Tocrd.TabIndex = 39
        Me.Tocrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MonthPicker
        '
        Me.MonthPicker.CustomFormat = ""
        Me.MonthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MonthPicker.Location = New System.Drawing.Point(113, 22)
        Me.MonthPicker.Name = "MonthPicker"
        Me.MonthPicker.Size = New System.Drawing.Size(95, 23)
        Me.MonthPicker.TabIndex = 36
        '
        'FrmCrd
        '
        Me.FrmCrd.Enabled = False
        Me.FrmCrd.Location = New System.Drawing.Point(113, 52)
        Me.FrmCrd.Name = "FrmCrd"
        Me.FrmCrd.Size = New System.Drawing.Size(95, 23)
        Me.FrmCrd.TabIndex = 37
        Me.FrmCrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "From Card:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(209, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "To Card:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Tbl_HRM_SectionBindingSource
        '
        Me.Tbl_HRM_SectionBindingSource.DataMember = "tbl_HRM_Dept_tbl_HRM_Section"
        Me.Tbl_HRM_SectionBindingSource.DataSource = Me.Tbl_HRM_DeptBindingSource
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
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
        Me.Panel2.Location = New System.Drawing.Point(276, 269)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 181)
        Me.Panel2.TabIndex = 18
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
        Me.RptViewer.Location = New System.Drawing.Point(543, 456)
        Me.RptViewer.Name = "RptViewer"
        Me.RptViewer.Size = New System.Drawing.Size(127, 47)
        Me.RptViewer.TabIndex = 19
        Me.RptViewer.Text = "Show Report"
        Me.RptViewer.UseVisualStyleBackColor = False
        '
        'Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter
        '
        Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_Med_Item_HeadTableAdapter = Me.Tbl_HRM_Emp_Med_Item_HeadTableAdapter
        Me.TableAdapterManager1.tbl_HRM_Emp_Med_ItemTableAdapter = Me.Tbl_HRM_Emp_Med_ItemTableAdapter
        Me.TableAdapterManager1.tbl_HRM_Emp_Medication_INTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_Medication_PharmacyTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Emp_Medication_Rec_HeadTableAdapter = Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter
        Me.TableAdapterManager1.tbl_HRM_Emp_MedicationTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSMedicationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.View_Diagnosis_Category_1TableAdapter = Nothing
        Me.TableAdapterManager1.View_Diagnosis_Category_2TableAdapter = Nothing
        Me.TableAdapterManager1.View_Diagnosis_Category_3TableAdapter = Nothing
        Me.TableAdapterManager1.View_Diagnosis_Category_4TableAdapter = Nothing
        Me.TableAdapterManager1.View_Diagnosis_Category_5TableAdapter = Nothing
        Me.TableAdapterManager1.View_Recommended_Test_1TableAdapter = Nothing
        Me.TableAdapterManager1.View_Recommended_Test_2TableAdapter = Nothing
        Me.TableAdapterManager1.View_Recommended_Test_3TableAdapter = Nothing
        Me.TableAdapterManager1.View_Recommended_Test_41TableAdapter = Nothing
        Me.TableAdapterManager1.View_Recommended_Test_4TableAdapter = Nothing
        Me.TableAdapterManager1.View_Refer_ToTableAdapter = Nothing
        Me.TableAdapterManager1.View_Treatment_Category_1TableAdapter = Nothing
        Me.TableAdapterManager1.View_Treatment_Category_2TableAdapter = Nothing
        Me.TableAdapterManager1.View_Treatment_Category_3TableAdapter = Nothing
        Me.TableAdapterManager1.View_Treatment_Category_4TableAdapter = Nothing
        Me.TableAdapterManager1.View_Treatment_Category_5TableAdapter = Nothing
        '
        'Tbl_HRM_Emp_Med_Item_HeadTableAdapter
        '
        Me.Tbl_HRM_Emp_Med_Item_HeadTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Emp_Med_ItemTableAdapter
        '
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter.ClearBeforeFill = True
        '
        'mediReports
        '
        Me.AcceptButton = Me.RptViewer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1129, 775)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.RptViewer)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "mediReports"
        Me.Text = "mediReports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_HRM_Emp_Med_ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Med_Item_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents byDaterange As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Tocrd As TextBox
    Friend WithEvents MonthPicker As DateTimePicker
    Friend WithEvents FrmCrd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
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
    Friend WithEvents DSMedication As DSMedication
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_HeadBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Medication_Rec_HeadTableAdapter
    Friend WithEvents TableAdapterManager1 As DSMedicationTableAdapters.TableAdapterManager
    Friend WithEvents MadicationHeadComboBox As ComboBox
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents Tbl_HRM_Emp_Med_Item_HeadTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Med_Item_HeadTableAdapter
    Friend WithEvents Tbl_HRM_Emp_Med_Item_HeadBindingSource As BindingSource
    Friend WithEvents L1IDComboBox As ComboBox
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents ByMedican As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Tbl_HRM_Emp_Med_ItemTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Med_ItemTableAdapter
    Friend WithEvents Tbl_HRM_Emp_Med_ItemBindingSource As BindingSource
    Friend WithEvents RadioButton12 As RadioButton
End Class
