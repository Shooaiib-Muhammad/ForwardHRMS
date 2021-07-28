<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RptDepartRecord
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
        Dim GradeNameLabel As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim JobTypeNameLabel As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim QualficationNameLabel As System.Windows.Forms.Label
        Dim CatagoryNameLabel As System.Windows.Forms.Label
        Dim EmploymentNameLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim MaritalStatusLabel As System.Windows.Forms.Label
        Dim BloodGroupLabel As System.Windows.Forms.Label
        Dim SectionCodeLabel2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OptionSelect = New System.Windows.Forms.GroupBox()
        Me.EmploymentNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_EmploymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.SectionCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.View_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.CatagoryNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_EmpCatagoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualficationNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_QualficationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReligionComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.MaritalStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.BloodGroupComboBox = New System.Windows.Forms.ComboBox()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JobTypeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_JobTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.BtnRptShower = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.PerBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SinBtn = New System.Windows.Forms.RadioButton()
        Me.MissBtn = New System.Windows.Forms.RadioButton()
        Me.QualfBtn = New System.Windows.Forms.RadioButton()
        Me.EmpcatBtn = New System.Windows.Forms.RadioButton()
        Me.EmploymeyBtn = New System.Windows.Forms.RadioButton()
        Me.ReligBtn = New System.Windows.Forms.RadioButton()
        Me.Genderbtn = New System.Windows.Forms.RadioButton()
        Me.MSBtn = New System.Windows.Forms.RadioButton()
        Me.BGBtn = New System.Windows.Forms.RadioButton()
        Me.EmpBtn = New System.Windows.Forms.RadioButton()
        Me.JobTypeBtn = New System.Windows.Forms.RadioButton()
        Me.GradeBtn = New System.Windows.Forms.RadioButton()
        Me.ShiftBtn = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DesigBtn = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SecBTn = New System.Windows.Forms.RadioButton()
        Me.DepartmentBtn = New System.Windows.Forms.RadioButton()
        Me.AllBtn = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_QualficationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_QualficationTableAdapter()
        Me.Tbl_HRM_EmpCatagoryTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_EmpCatagoryTableAdapter()
        Me.Tbl_Hrm_EmploymentTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Hrm_EmploymentTableAdapter()
        Me.View_HRM_SectionTableAdapter = New ERP_HRMS.DSUserTableAdapters.View_HRM_SectionTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Bygrade = New System.Windows.Forms.RadioButton()
        Me.Bycard = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Grade_NEW2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDept = New ERP_HRMS.DSDept()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Grade_NEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ByBranch = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.BranchBtn = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_Grade_NEWTableAdapter = New ERP_HRMS.DSDeptTableAdapters.tbl_HRM_Grade_NEWTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.DSDeptTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Grade_NEW2TableAdapter = New ERP_HRMS.DSDeptTableAdapters.tbl_HRM_Grade_NEW2TableAdapter()
        DeptNameLabel = New System.Windows.Forms.Label()
        SectionNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        GradeNameLabel = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        JobTypeNameLabel = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        QualficationNameLabel = New System.Windows.Forms.Label()
        CatagoryNameLabel = New System.Windows.Forms.Label()
        EmploymentNameLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        MaritalStatusLabel = New System.Windows.Forms.Label()
        BloodGroupLabel = New System.Windows.Forms.Label()
        SectionCodeLabel2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.OptionSelect.SuspendLayout()
        CType(Me.Tbl_Hrm_EmploymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_EmpCatagoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_QualficationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_HRM_Grade_NEW2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Grade_NEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeptNameLabel
        '
        DeptNameLabel.AutoSize = True
        DeptNameLabel.ForeColor = System.Drawing.Color.Black
        DeptNameLabel.Location = New System.Drawing.Point(17, 35)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(86, 17)
        DeptNameLabel.TabIndex = 0
        DeptNameLabel.Text = "Department:"
        '
        'SectionNameLabel
        '
        SectionNameLabel.AutoSize = True
        SectionNameLabel.ForeColor = System.Drawing.Color.Black
        SectionNameLabel.Location = New System.Drawing.Point(17, 65)
        SectionNameLabel.Name = "SectionNameLabel"
        SectionNameLabel.Size = New System.Drawing.Size(59, 17)
        SectionNameLabel.TabIndex = 2
        SectionNameLabel.Text = "Section:"
        '
        'DesigNameLabel
        '
        DesigNameLabel.AutoSize = True
        DesigNameLabel.ForeColor = System.Drawing.Color.Black
        DesigNameLabel.Location = New System.Drawing.Point(17, 95)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(87, 17)
        DesigNameLabel.TabIndex = 4
        DesigNameLabel.Text = "Designation:"
        '
        'GradeNameLabel
        '
        GradeNameLabel.AutoSize = True
        GradeNameLabel.ForeColor = System.Drawing.Color.Black
        GradeNameLabel.Location = New System.Drawing.Point(11, 54)
        GradeNameLabel.Name = "GradeNameLabel"
        GradeNameLabel.Size = New System.Drawing.Size(52, 17)
        GradeNameLabel.TabIndex = 6
        GradeNameLabel.Text = "Grade:"
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.AutoSize = True
        ShiftNameLabel.ForeColor = System.Drawing.Color.Black
        ShiftNameLabel.Location = New System.Drawing.Point(11, 82)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(40, 17)
        ShiftNameLabel.TabIndex = 8
        ShiftNameLabel.Text = "Shift:"
        '
        'JobTypeNameLabel
        '
        JobTypeNameLabel.AutoSize = True
        JobTypeNameLabel.ForeColor = System.Drawing.Color.Black
        JobTypeNameLabel.Location = New System.Drawing.Point(11, 114)
        JobTypeNameLabel.Name = "JobTypeNameLabel"
        JobTypeNameLabel.Size = New System.Drawing.Size(71, 17)
        JobTypeNameLabel.TabIndex = 10
        JobTypeNameLabel.Text = "Job Type:"
        '
        'BranchNameLabel
        '
        BranchNameLabel.AutoSize = True
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(11, 23)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(57, 17)
        BranchNameLabel.TabIndex = 12
        BranchNameLabel.Text = "Branch:"
        '
        'QualficationNameLabel
        '
        QualficationNameLabel.AutoSize = True
        QualficationNameLabel.ForeColor = System.Drawing.Color.Black
        QualficationNameLabel.Location = New System.Drawing.Point(11, 324)
        QualficationNameLabel.Name = "QualficationNameLabel"
        QualficationNameLabel.Size = New System.Drawing.Size(90, 17)
        QualficationNameLabel.TabIndex = 34
        QualficationNameLabel.Text = "Qualification:"
        '
        'CatagoryNameLabel
        '
        CatagoryNameLabel.AutoSize = True
        CatagoryNameLabel.ForeColor = System.Drawing.Color.Black
        CatagoryNameLabel.Location = New System.Drawing.Point(11, 293)
        CatagoryNameLabel.Name = "CatagoryNameLabel"
        CatagoryNameLabel.Size = New System.Drawing.Size(69, 17)
        CatagoryNameLabel.TabIndex = 32
        CatagoryNameLabel.Text = "Catagory:"
        '
        'EmploymentNameLabel
        '
        EmploymentNameLabel.AutoSize = True
        EmploymentNameLabel.ForeColor = System.Drawing.Color.Black
        EmploymentNameLabel.Location = New System.Drawing.Point(11, 265)
        EmploymentNameLabel.Name = "EmploymentNameLabel"
        EmploymentNameLabel.Size = New System.Drawing.Size(89, 17)
        EmploymentNameLabel.TabIndex = 30
        EmploymentNameLabel.Text = "Employment:"
        '
        'ReligionLabel
        '
        ReligionLabel.AutoSize = True
        ReligionLabel.ForeColor = System.Drawing.Color.Black
        ReligionLabel.Location = New System.Drawing.Point(11, 235)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(63, 17)
        ReligionLabel.TabIndex = 28
        ReligionLabel.Text = "Religion:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.ForeColor = System.Drawing.Color.Black
        GenderLabel.Location = New System.Drawing.Point(11, 204)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(60, 17)
        GenderLabel.TabIndex = 26
        GenderLabel.Text = "Gender:"
        '
        'MaritalStatusLabel
        '
        MaritalStatusLabel.AutoSize = True
        MaritalStatusLabel.ForeColor = System.Drawing.Color.Black
        MaritalStatusLabel.Location = New System.Drawing.Point(11, 173)
        MaritalStatusLabel.Name = "MaritalStatusLabel"
        MaritalStatusLabel.Size = New System.Drawing.Size(98, 17)
        MaritalStatusLabel.TabIndex = 24
        MaritalStatusLabel.Text = "Marital Status:"
        '
        'BloodGroupLabel
        '
        BloodGroupLabel.AutoSize = True
        BloodGroupLabel.ForeColor = System.Drawing.Color.Black
        BloodGroupLabel.Location = New System.Drawing.Point(11, 142)
        BloodGroupLabel.Name = "BloodGroupLabel"
        BloodGroupLabel.Size = New System.Drawing.Size(92, 17)
        BloodGroupLabel.TabIndex = 22
        BloodGroupLabel.Text = "Blood Group:"
        '
        'SectionCodeLabel2
        '
        SectionCodeLabel2.AutoSize = True
        SectionCodeLabel2.ForeColor = System.Drawing.Color.Black
        SectionCodeLabel2.Location = New System.Drawing.Point(11, 351)
        SectionCodeLabel2.Name = "SectionCodeLabel2"
        SectionCodeLabel2.Size = New System.Drawing.Size(96, 17)
        SectionCodeLabel2.TabIndex = 6
        SectionCodeLabel2.Text = "Section Code:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.ForeColor = System.Drawing.Color.Black
        Label5.Location = New System.Drawing.Point(15, 94)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(88, 17)
        Label5.TabIndex = 38
        Label5.Text = "From Grade:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.ForeColor = System.Drawing.Color.Black
        Label6.Location = New System.Drawing.Point(15, 124)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(73, 17)
        Label6.TabIndex = 40
        Label6.Text = "To Grade:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1261, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Department Wise Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OptionSelect
        '
        Me.OptionSelect.Controls.Add(SectionCodeLabel2)
        Me.OptionSelect.Controls.Add(Me.EmploymentNameComboBox)
        Me.OptionSelect.Controls.Add(Me.SectionCodeComboBox)
        Me.OptionSelect.Controls.Add(Me.CatagoryNameComboBox)
        Me.OptionSelect.Controls.Add(Me.QualficationNameComboBox)
        Me.OptionSelect.Controls.Add(QualficationNameLabel)
        Me.OptionSelect.Controls.Add(CatagoryNameLabel)
        Me.OptionSelect.Controls.Add(EmploymentNameLabel)
        Me.OptionSelect.Controls.Add(ShiftNameLabel)
        Me.OptionSelect.Controls.Add(Me.ShiftNameComboBox)
        Me.OptionSelect.Controls.Add(ReligionLabel)
        Me.OptionSelect.Controls.Add(Me.ReligionComboBox)
        Me.OptionSelect.Controls.Add(GenderLabel)
        Me.OptionSelect.Controls.Add(Me.GenderComboBox)
        Me.OptionSelect.Controls.Add(MaritalStatusLabel)
        Me.OptionSelect.Controls.Add(Me.MaritalStatusComboBox)
        Me.OptionSelect.Controls.Add(BloodGroupLabel)
        Me.OptionSelect.Controls.Add(Me.BloodGroupComboBox)
        Me.OptionSelect.Controls.Add(BranchNameLabel)
        Me.OptionSelect.Controls.Add(Me.BranchNameComboBox)
        Me.OptionSelect.Controls.Add(JobTypeNameLabel)
        Me.OptionSelect.Controls.Add(Me.JobTypeNameComboBox)
        Me.OptionSelect.Controls.Add(GradeNameLabel)
        Me.OptionSelect.Controls.Add(Me.GradeNameComboBox)
        Me.OptionSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionSelect.ForeColor = System.Drawing.Color.Blue
        Me.OptionSelect.Location = New System.Drawing.Point(429, 45)
        Me.OptionSelect.Name = "OptionSelect"
        Me.OptionSelect.Size = New System.Drawing.Size(399, 381)
        Me.OptionSelect.TabIndex = 2
        Me.OptionSelect.TabStop = False
        Me.OptionSelect.Text = "Option Selector :"
        '
        'EmploymentNameComboBox
        '
        Me.EmploymentNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EmploymentNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmploymentNameComboBox.DataSource = Me.Tbl_Hrm_EmploymentBindingSource
        Me.EmploymentNameComboBox.DisplayMember = "EmploymentName"
        Me.EmploymentNameComboBox.FormattingEnabled = True
        Me.EmploymentNameComboBox.Location = New System.Drawing.Point(136, 262)
        Me.EmploymentNameComboBox.Name = "EmploymentNameComboBox"
        Me.EmploymentNameComboBox.Size = New System.Drawing.Size(240, 24)
        Me.EmploymentNameComboBox.TabIndex = 37
        Me.EmploymentNameComboBox.ValueMember = "EmploymentID"
        '
        'Tbl_Hrm_EmploymentBindingSource
        '
        Me.Tbl_Hrm_EmploymentBindingSource.DataMember = "tbl_Hrm_Employment"
        Me.Tbl_Hrm_EmploymentBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SectionCodeComboBox
        '
        Me.SectionCodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SectionCodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectionCodeComboBox.DataSource = Me.View_HRM_SectionBindingSource
        Me.SectionCodeComboBox.DisplayMember = "SectionCode"
        Me.SectionCodeComboBox.FormattingEnabled = True
        Me.SectionCodeComboBox.Location = New System.Drawing.Point(136, 349)
        Me.SectionCodeComboBox.Name = "SectionCodeComboBox"
        Me.SectionCodeComboBox.Size = New System.Drawing.Size(240, 24)
        Me.SectionCodeComboBox.TabIndex = 7
        Me.SectionCodeComboBox.ValueMember = "SectionCode"
        '
        'View_HRM_SectionBindingSource
        '
        Me.View_HRM_SectionBindingSource.DataMember = "View_HRM_Section"
        Me.View_HRM_SectionBindingSource.DataSource = Me.DSUser
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CatagoryNameComboBox
        '
        Me.CatagoryNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CatagoryNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CatagoryNameComboBox.DataSource = Me.Tbl_HRM_EmpCatagoryBindingSource
        Me.CatagoryNameComboBox.DisplayMember = "CatagoryName"
        Me.CatagoryNameComboBox.FormattingEnabled = True
        Me.CatagoryNameComboBox.Location = New System.Drawing.Point(136, 290)
        Me.CatagoryNameComboBox.Name = "CatagoryNameComboBox"
        Me.CatagoryNameComboBox.Size = New System.Drawing.Size(240, 24)
        Me.CatagoryNameComboBox.TabIndex = 36
        Me.CatagoryNameComboBox.ValueMember = "EmpCatagoryID"
        '
        'Tbl_HRM_EmpCatagoryBindingSource
        '
        Me.Tbl_HRM_EmpCatagoryBindingSource.DataMember = "tbl_HRM_EmpCatagory"
        Me.Tbl_HRM_EmpCatagoryBindingSource.DataSource = Me.DSHRM
        '
        'QualficationNameComboBox
        '
        Me.QualficationNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.QualficationNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.QualficationNameComboBox.DataSource = Me.Tbl_HRM_QualficationBindingSource
        Me.QualficationNameComboBox.DisplayMember = "QualficationName"
        Me.QualficationNameComboBox.FormattingEnabled = True
        Me.QualficationNameComboBox.Location = New System.Drawing.Point(136, 321)
        Me.QualficationNameComboBox.Name = "QualficationNameComboBox"
        Me.QualficationNameComboBox.Size = New System.Drawing.Size(240, 24)
        Me.QualficationNameComboBox.TabIndex = 35
        Me.QualficationNameComboBox.ValueMember = "QualficationID"
        '
        'Tbl_HRM_QualficationBindingSource
        '
        Me.Tbl_HRM_QualficationBindingSource.DataMember = "tbl_HRM_Qualfication"
        Me.Tbl_HRM_QualficationBindingSource.DataSource = Me.DSHRM
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ShiftNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShiftNameComboBox.DataSource = Me.Tbl_HRM_ShiftBindingSource
        Me.ShiftNameComboBox.DisplayMember = "ShiftName"
        Me.ShiftNameComboBox.Enabled = False
        Me.ShiftNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(136, 81)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(240, 24)
        Me.ShiftNameComboBox.TabIndex = 9
        Me.ShiftNameComboBox.ValueMember = "ShiftID"
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSHRM
        '
        'ReligionComboBox
        '
        Me.ReligionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ReligionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ReligionComboBox.Enabled = False
        Me.ReligionComboBox.FormattingEnabled = True
        Me.ReligionComboBox.Items.AddRange(New Object() {"Islam", "Christianity", "Hinduism", "Sikhism", "Other"})
        Me.ReligionComboBox.Location = New System.Drawing.Point(136, 232)
        Me.ReligionComboBox.Name = "ReligionComboBox"
        Me.ReligionComboBox.Size = New System.Drawing.Size(240, 24)
        Me.ReligionComboBox.TabIndex = 29
        Me.ReligionComboBox.Text = "Islam"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderComboBox.Enabled = False
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(136, 201)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(240, 24)
        Me.GenderComboBox.TabIndex = 27
        Me.GenderComboBox.Text = "Male"
        '
        'MaritalStatusComboBox
        '
        Me.MaritalStatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MaritalStatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MaritalStatusComboBox.Enabled = False
        Me.MaritalStatusComboBox.FormattingEnabled = True
        Me.MaritalStatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Widow", "Divorced"})
        Me.MaritalStatusComboBox.Location = New System.Drawing.Point(136, 170)
        Me.MaritalStatusComboBox.Name = "MaritalStatusComboBox"
        Me.MaritalStatusComboBox.Size = New System.Drawing.Size(240, 24)
        Me.MaritalStatusComboBox.TabIndex = 25
        Me.MaritalStatusComboBox.Text = "Single"
        '
        'BloodGroupComboBox
        '
        Me.BloodGroupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BloodGroupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BloodGroupComboBox.Enabled = False
        Me.BloodGroupComboBox.FormattingEnabled = True
        Me.BloodGroupComboBox.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-", "Not Set"})
        Me.BloodGroupComboBox.Location = New System.Drawing.Point(136, 139)
        Me.BloodGroupComboBox.Name = "BloodGroupComboBox"
        Me.BloodGroupComboBox.Size = New System.Drawing.Size(240, 24)
        Me.BloodGroupComboBox.TabIndex = 23
        Me.BloodGroupComboBox.Text = "A+"
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(136, 20)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(240, 24)
        Me.BranchNameComboBox.TabIndex = 13
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'JobTypeNameComboBox
        '
        Me.JobTypeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.JobTypeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.JobTypeNameComboBox.DataSource = Me.Tbl_HRM_JobTypeBindingSource
        Me.JobTypeNameComboBox.DisplayMember = "JobTypeName"
        Me.JobTypeNameComboBox.Enabled = False
        Me.JobTypeNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.JobTypeNameComboBox.FormattingEnabled = True
        Me.JobTypeNameComboBox.Location = New System.Drawing.Point(136, 111)
        Me.JobTypeNameComboBox.Name = "JobTypeNameComboBox"
        Me.JobTypeNameComboBox.Size = New System.Drawing.Size(240, 24)
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
        Me.GradeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GradeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GradeNameComboBox.DataSource = Me.Tbl_HRM_GradeBindingSource
        Me.GradeNameComboBox.DisplayMember = "GradeName"
        Me.GradeNameComboBox.Enabled = False
        Me.GradeNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.GradeNameComboBox.FormattingEnabled = True
        Me.GradeNameComboBox.Location = New System.Drawing.Point(136, 51)
        Me.GradeNameComboBox.Name = "GradeNameComboBox"
        Me.GradeNameComboBox.Size = New System.Drawing.Size(240, 24)
        Me.GradeNameComboBox.TabIndex = 7
        Me.GradeNameComboBox.ValueMember = "GradeID"
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSHRM
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "End Card:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Start Card:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(103, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 21
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(103, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 22
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(103, 92)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(272, 24)
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
        Me.SectionNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(103, 62)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(272, 24)
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
        Me.DeptNameComboBox.ForeColor = System.Drawing.Color.Black
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(103, 32)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(272, 24)
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
        'BtnRptShower
        '
        Me.BtnRptShower.BackColor = System.Drawing.Color.Green
        Me.BtnRptShower.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRptShower.ForeColor = System.Drawing.Color.White
        Me.BtnRptShower.Location = New System.Drawing.Point(297, 559)
        Me.BtnRptShower.Name = "BtnRptShower"
        Me.BtnRptShower.Size = New System.Drawing.Size(127, 47)
        Me.BtnRptShower.TabIndex = 3
        Me.BtnRptShower.Text = "Show Report"
        Me.BtnRptShower.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.PerBtn)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.SinBtn)
        Me.GroupBox2.Controls.Add(Me.MissBtn)
        Me.GroupBox2.Controls.Add(Me.QualfBtn)
        Me.GroupBox2.Controls.Add(Me.EmpcatBtn)
        Me.GroupBox2.Controls.Add(Me.EmploymeyBtn)
        Me.GroupBox2.Controls.Add(Me.ReligBtn)
        Me.GroupBox2.Controls.Add(Me.Genderbtn)
        Me.GroupBox2.Controls.Add(Me.MSBtn)
        Me.GroupBox2.Controls.Add(Me.BGBtn)
        Me.GroupBox2.Controls.Add(Me.EmpBtn)
        Me.GroupBox2.Controls.Add(Me.JobTypeBtn)
        Me.GroupBox2.Controls.Add(Me.GradeBtn)
        Me.GroupBox2.Controls.Add(Me.ShiftBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(43, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 430)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Selector:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(11, 396)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(370, 21)
        Me.RadioButton2.TabIndex = 15
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Performance Appraisal From (Junior Managemnt/Staff)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'PerBtn
        '
        Me.PerBtn.AutoSize = True
        Me.PerBtn.ForeColor = System.Drawing.Color.Black
        Me.PerBtn.Location = New System.Drawing.Point(11, 372)
        Me.PerBtn.Name = "PerBtn"
        Me.PerBtn.Size = New System.Drawing.Size(347, 21)
        Me.PerBtn.TabIndex = 14
        Me.PerBtn.TabStop = True
        Me.PerBtn.Text = "Performance Appraisal From (Senior Management)"
        Me.PerBtn.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(11, 297)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(110, 21)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.Text = "Section Code"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'SinBtn
        '
        Me.SinBtn.AutoSize = True
        Me.SinBtn.ForeColor = System.Drawing.Color.Black
        Me.SinBtn.Location = New System.Drawing.Point(11, 347)
        Me.SinBtn.Name = "SinBtn"
        Me.SinBtn.Size = New System.Drawing.Size(111, 21)
        Me.SinBtn.TabIndex = 13
        Me.SinBtn.Text = "Seniority List "
        Me.SinBtn.UseVisualStyleBackColor = True
        '
        'MissBtn
        '
        Me.MissBtn.AutoSize = True
        Me.MissBtn.ForeColor = System.Drawing.Color.Black
        Me.MissBtn.Location = New System.Drawing.Point(11, 322)
        Me.MissBtn.Name = "MissBtn"
        Me.MissBtn.Size = New System.Drawing.Size(122, 21)
        Me.MissBtn.TabIndex = 12
        Me.MissBtn.Text = "Missing Pic List"
        Me.MissBtn.UseVisualStyleBackColor = True
        '
        'QualfBtn
        '
        Me.QualfBtn.AutoSize = True
        Me.QualfBtn.ForeColor = System.Drawing.Color.Black
        Me.QualfBtn.Location = New System.Drawing.Point(11, 272)
        Me.QualfBtn.Name = "QualfBtn"
        Me.QualfBtn.Size = New System.Drawing.Size(104, 21)
        Me.QualfBtn.TabIndex = 4
        Me.QualfBtn.Text = "Qualification"
        Me.QualfBtn.UseVisualStyleBackColor = True
        '
        'EmpcatBtn
        '
        Me.EmpcatBtn.AutoSize = True
        Me.EmpcatBtn.ForeColor = System.Drawing.Color.Black
        Me.EmpcatBtn.Location = New System.Drawing.Point(11, 247)
        Me.EmpcatBtn.Name = "EmpcatBtn"
        Me.EmpcatBtn.Size = New System.Drawing.Size(149, 21)
        Me.EmpcatBtn.TabIndex = 5
        Me.EmpcatBtn.Text = "Employee Catagory"
        Me.EmpcatBtn.UseVisualStyleBackColor = True
        '
        'EmploymeyBtn
        '
        Me.EmploymeyBtn.AutoSize = True
        Me.EmploymeyBtn.ForeColor = System.Drawing.Color.Black
        Me.EmploymeyBtn.Location = New System.Drawing.Point(11, 222)
        Me.EmploymeyBtn.Name = "EmploymeyBtn"
        Me.EmploymeyBtn.Size = New System.Drawing.Size(103, 21)
        Me.EmploymeyBtn.TabIndex = 6
        Me.EmploymeyBtn.Text = "Employment"
        Me.EmploymeyBtn.UseVisualStyleBackColor = True
        '
        'ReligBtn
        '
        Me.ReligBtn.AutoSize = True
        Me.ReligBtn.ForeColor = System.Drawing.Color.Black
        Me.ReligBtn.Location = New System.Drawing.Point(11, 197)
        Me.ReligBtn.Name = "ReligBtn"
        Me.ReligBtn.Size = New System.Drawing.Size(77, 21)
        Me.ReligBtn.TabIndex = 7
        Me.ReligBtn.Text = "Religion"
        Me.ReligBtn.UseVisualStyleBackColor = True
        '
        'Genderbtn
        '
        Me.Genderbtn.AutoSize = True
        Me.Genderbtn.ForeColor = System.Drawing.Color.Black
        Me.Genderbtn.Location = New System.Drawing.Point(11, 172)
        Me.Genderbtn.Name = "Genderbtn"
        Me.Genderbtn.Size = New System.Drawing.Size(78, 21)
        Me.Genderbtn.TabIndex = 8
        Me.Genderbtn.Text = "Gender "
        Me.Genderbtn.UseVisualStyleBackColor = True
        '
        'MSBtn
        '
        Me.MSBtn.AutoSize = True
        Me.MSBtn.ForeColor = System.Drawing.Color.Black
        Me.MSBtn.Location = New System.Drawing.Point(11, 147)
        Me.MSBtn.Name = "MSBtn"
        Me.MSBtn.Size = New System.Drawing.Size(116, 21)
        Me.MSBtn.TabIndex = 9
        Me.MSBtn.Text = "Marital Status "
        Me.MSBtn.UseVisualStyleBackColor = True
        '
        'BGBtn
        '
        Me.BGBtn.AutoSize = True
        Me.BGBtn.ForeColor = System.Drawing.Color.Black
        Me.BGBtn.Location = New System.Drawing.Point(11, 122)
        Me.BGBtn.Name = "BGBtn"
        Me.BGBtn.Size = New System.Drawing.Size(106, 21)
        Me.BGBtn.TabIndex = 10
        Me.BGBtn.Text = "Blood Group"
        Me.BGBtn.UseVisualStyleBackColor = True
        '
        'EmpBtn
        '
        Me.EmpBtn.AutoSize = True
        Me.EmpBtn.Checked = True
        Me.EmpBtn.ForeColor = System.Drawing.Color.Black
        Me.EmpBtn.Location = New System.Drawing.Point(11, 22)
        Me.EmpBtn.Name = "EmpBtn"
        Me.EmpBtn.Size = New System.Drawing.Size(114, 21)
        Me.EmpBtn.TabIndex = 1
        Me.EmpBtn.TabStop = True
        Me.EmpBtn.Text = "Employee List"
        Me.EmpBtn.UseVisualStyleBackColor = True
        '
        'JobTypeBtn
        '
        Me.JobTypeBtn.AutoSize = True
        Me.JobTypeBtn.ForeColor = System.Drawing.Color.Black
        Me.JobTypeBtn.Location = New System.Drawing.Point(11, 97)
        Me.JobTypeBtn.Name = "JobTypeBtn"
        Me.JobTypeBtn.Size = New System.Drawing.Size(85, 21)
        Me.JobTypeBtn.TabIndex = 0
        Me.JobTypeBtn.Text = "Job Type"
        Me.JobTypeBtn.UseVisualStyleBackColor = True
        '
        'GradeBtn
        '
        Me.GradeBtn.AutoSize = True
        Me.GradeBtn.ForeColor = System.Drawing.Color.Black
        Me.GradeBtn.Location = New System.Drawing.Point(11, 47)
        Me.GradeBtn.Name = "GradeBtn"
        Me.GradeBtn.Size = New System.Drawing.Size(66, 21)
        Me.GradeBtn.TabIndex = 0
        Me.GradeBtn.Text = "Grade"
        Me.GradeBtn.UseVisualStyleBackColor = True
        '
        'ShiftBtn
        '
        Me.ShiftBtn.AutoSize = True
        Me.ShiftBtn.ForeColor = System.Drawing.Color.Black
        Me.ShiftBtn.Location = New System.Drawing.Point(11, 72)
        Me.ShiftBtn.Name = "ShiftBtn"
        Me.ShiftBtn.Size = New System.Drawing.Size(54, 21)
        Me.ShiftBtn.TabIndex = 0
        Me.ShiftBtn.Text = "Shift"
        Me.ShiftBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DesigBtn)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.SecBTn)
        Me.Panel1.Controls.Add(Me.DesigNameComboBox)
        Me.Panel1.Controls.Add(Me.DepartmentBtn)
        Me.Panel1.Controls.Add(Me.DeptNameComboBox)
        Me.Panel1.Controls.Add(Me.AllBtn)
        Me.Panel1.Controls.Add(DeptNameLabel)
        Me.Panel1.Controls.Add(Me.SectionNameComboBox)
        Me.Panel1.Controls.Add(SectionNameLabel)
        Me.Panel1.Controls.Add(DesigNameLabel)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(429, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(399, 183)
        Me.Panel1.TabIndex = 4
        '
        'DesigBtn
        '
        Me.DesigBtn.AutoSize = True
        Me.DesigBtn.ForeColor = System.Drawing.Color.Black
        Me.DesigBtn.Location = New System.Drawing.Point(20, 152)
        Me.DesigBtn.Name = "DesigBtn"
        Me.DesigBtn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBtn.TabIndex = 3
        Me.DesigBtn.Text = "Designation"
        Me.DesigBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select Appropriate Option"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SecBTn
        '
        Me.SecBTn.AutoSize = True
        Me.SecBTn.ForeColor = System.Drawing.Color.Black
        Me.SecBTn.Location = New System.Drawing.Point(135, 152)
        Me.SecBTn.Name = "SecBTn"
        Me.SecBTn.Size = New System.Drawing.Size(73, 21)
        Me.SecBTn.TabIndex = 4
        Me.SecBTn.Text = "Section"
        Me.SecBTn.UseVisualStyleBackColor = True
        '
        'DepartmentBtn
        '
        Me.DepartmentBtn.AutoSize = True
        Me.DepartmentBtn.ForeColor = System.Drawing.Color.Black
        Me.DepartmentBtn.Location = New System.Drawing.Point(135, 125)
        Me.DepartmentBtn.Name = "DepartmentBtn"
        Me.DepartmentBtn.Size = New System.Drawing.Size(104, 21)
        Me.DepartmentBtn.TabIndex = 1
        Me.DepartmentBtn.Text = "Deptartment"
        Me.DepartmentBtn.UseVisualStyleBackColor = True
        '
        'AllBtn
        '
        Me.AllBtn.AutoSize = True
        Me.AllBtn.Checked = True
        Me.AllBtn.ForeColor = System.Drawing.Color.Black
        Me.AllBtn.Location = New System.Drawing.Point(20, 125)
        Me.AllBtn.Name = "AllBtn"
        Me.AllBtn.Size = New System.Drawing.Size(41, 21)
        Me.AllBtn.TabIndex = 0
        Me.AllBtn.TabStop = True
        Me.AllBtn.Text = "All"
        Me.AllBtn.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_QualficationTableAdapter
        '
        Me.Tbl_HRM_QualficationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_EmpCatagoryTableAdapter
        '
        Me.Tbl_HRM_EmpCatagoryTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_EmploymentTableAdapter
        '
        Me.Tbl_Hrm_EmploymentTableAdapter.ClearBeforeFill = True
        '
        'View_HRM_SectionTableAdapter
        '
        Me.View_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager1.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Bygrade)
        Me.GroupBox1.Controls.Add(Me.Bycard)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(834, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 88)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection Option"
        Me.GroupBox1.Visible = False
        '
        'Bygrade
        '
        Me.Bygrade.AutoSize = True
        Me.Bygrade.ForeColor = System.Drawing.Color.Black
        Me.Bygrade.Location = New System.Drawing.Point(27, 46)
        Me.Bygrade.Name = "Bygrade"
        Me.Bygrade.Size = New System.Drawing.Size(132, 21)
        Me.Bygrade.TabIndex = 1
        Me.Bygrade.Text = "By Grade Range"
        Me.Bygrade.UseVisualStyleBackColor = True
        '
        'Bycard
        '
        Me.Bycard.AutoSize = True
        Me.Bycard.Checked = True
        Me.Bycard.ForeColor = System.Drawing.Color.Black
        Me.Bycard.Location = New System.Drawing.Point(27, 19)
        Me.Bycard.Name = "Bycard"
        Me.Bycard.Size = New System.Drawing.Size(122, 21)
        Me.Bycard.TabIndex = 0
        Me.Bycard.TabStop = True
        Me.Bycard.Text = "By Card Range"
        Me.Bycard.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Label6)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(834, 147)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(236, 165)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Card Selection"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataSource = Me.Tbl_HRM_Grade_NEW2BindingSource
        Me.ComboBox2.DisplayMember = "GradeName"
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.ForeColor = System.Drawing.Color.Black
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(103, 120)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox2.TabIndex = 41
        Me.ComboBox2.ValueMember = "GradeID"
        '
        'Tbl_HRM_Grade_NEW2BindingSource
        '
        Me.Tbl_HRM_Grade_NEW2BindingSource.DataMember = "tbl_HRM_Grade_NEW2"
        Me.Tbl_HRM_Grade_NEW2BindingSource.DataSource = Me.DSDept
        '
        'DSDept
        '
        Me.DSDept.DataSetName = "DSDept"
        Me.DSDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_HRM_Grade_NEWBindingSource
        Me.ComboBox1.DisplayMember = "GradeName"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(103, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 24)
        Me.ComboBox1.TabIndex = 39
        Me.ComboBox1.ValueMember = "GradeID"
        '
        'Tbl_HRM_Grade_NEWBindingSource
        '
        Me.Tbl_HRM_Grade_NEWBindingSource.DataMember = "tbl_HRM_Grade_NEW"
        Me.Tbl_HRM_Grade_NEWBindingSource.DataSource = Me.DSDept
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ByBranch)
        Me.GroupBox4.Controls.Add(Me.AllEmp)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(57, 473)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(267, 72)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selection Option "
        '
        'ByBranch
        '
        Me.ByBranch.AutoSize = True
        Me.ByBranch.ForeColor = System.Drawing.Color.Black
        Me.ByBranch.Location = New System.Drawing.Point(27, 42)
        Me.ByBranch.Name = "ByBranch"
        Me.ByBranch.Size = New System.Drawing.Size(95, 21)
        Me.ByBranch.TabIndex = 1
        Me.ByBranch.Text = "By Branch "
        Me.ByBranch.UseVisualStyleBackColor = True
        '
        'AllEmp
        '
        Me.AllEmp.AutoSize = True
        Me.AllEmp.Checked = True
        Me.AllEmp.ForeColor = System.Drawing.Color.Black
        Me.AllEmp.Location = New System.Drawing.Point(27, 19)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.TabStop = True
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'BranchBtn
        '
        Me.BranchBtn.AutoSize = True
        Me.BranchBtn.ForeColor = System.Drawing.Color.Black
        Me.BranchBtn.Location = New System.Drawing.Point(963, 403)
        Me.BranchBtn.Name = "BranchBtn"
        Me.BranchBtn.Size = New System.Drawing.Size(59, 17)
        Me.BranchBtn.TabIndex = 0
        Me.BranchBtn.Text = "Branch"
        Me.BranchBtn.UseVisualStyleBackColor = True
        Me.BranchBtn.Visible = False
        '
        'Tbl_HRM_Grade_NEWTableAdapter
        '
        Me.Tbl_HRM_Grade_NEWTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.tbl_HRM_Dept_NewTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_HRM_Grade_NEW2TableAdapter = Me.Tbl_HRM_Grade_NEW2TableAdapter
        Me.TableAdapterManager2.tbl_HRM_Grade_NEWTableAdapter = Me.Tbl_HRM_Grade_NEWTableAdapter
        Me.TableAdapterManager2.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_HRM_Section_NewTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Pro_VendorTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.DSDeptTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.View_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager2.View_Inactive_EmpTableAdapter = Nothing
        '
        'Tbl_HRM_Grade_NEW2TableAdapter
        '
        Me.Tbl_HRM_Grade_NEW2TableAdapter.ClearBeforeFill = True
        '
        'RptDepartRecord
        '
        Me.AcceptButton = Me.BtnRptShower
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1261, 731)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnRptShower)
        Me.Controls.Add(Me.OptionSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BranchBtn)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RptDepartRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department Report"
        Me.OptionSelect.ResumeLayout(False)
        Me.OptionSelect.PerformLayout()
        CType(Me.Tbl_Hrm_EmploymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_EmpCatagoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_QualficationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_HRM_Grade_NEW2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Grade_NEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents OptionSelect As GroupBox
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
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents GradeNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_JobTypeTableAdapter As DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter
    Friend WithEvents Tbl_HRM_JobTypeBindingSource As BindingSource
    Friend WithEvents JobTypeNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents BtnRptShower As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents JobTypeBtn As RadioButton
    Friend WithEvents GradeBtn As RadioButton
    Friend WithEvents ShiftBtn As RadioButton
    Friend WithEvents EmpBtn As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DesigBtn As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents SecBTn As RadioButton
    Friend WithEvents DepartmentBtn As RadioButton
    Friend WithEvents AllBtn As RadioButton
    Friend WithEvents SinBtn As RadioButton
    Friend WithEvents MissBtn As RadioButton
    Friend WithEvents QualfBtn As RadioButton
    Friend WithEvents EmpcatBtn As RadioButton
    Friend WithEvents EmploymeyBtn As RadioButton
    Friend WithEvents ReligBtn As RadioButton
    Friend WithEvents Genderbtn As RadioButton
    Friend WithEvents MSBtn As RadioButton
    Friend WithEvents BGBtn As RadioButton
    Friend WithEvents ReligionComboBox As ComboBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents MaritalStatusComboBox As ComboBox
    Friend WithEvents BloodGroupComboBox As ComboBox
    Friend WithEvents Tbl_HRM_QualficationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_QualficationTableAdapter As DSHRMTableAdapters.tbl_HRM_QualficationTableAdapter
    Friend WithEvents QualficationNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_EmpCatagoryBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_EmpCatagoryTableAdapter As DSHRMTableAdapters.tbl_HRM_EmpCatagoryTableAdapter
    Friend WithEvents CatagoryNameComboBox As ComboBox
    Friend WithEvents Tbl_Hrm_EmploymentBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_EmploymentTableAdapter As DSHRMTableAdapters.tbl_Hrm_EmploymentTableAdapter
    Friend WithEvents EmploymentNameComboBox As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DSUser As DSUser
    Friend WithEvents View_HRM_SectionBindingSource As BindingSource
    Friend WithEvents View_HRM_SectionTableAdapter As DSUserTableAdapters.View_HRM_SectionTableAdapter
    Friend WithEvents TableAdapterManager1 As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents SectionCodeComboBox As ComboBox
    Friend WithEvents PerBtn As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bygrade As RadioButton
    Friend WithEvents Bycard As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ByBranch As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents BranchBtn As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DSDept As DSDept
    Friend WithEvents Tbl_HRM_Grade_NEWBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Grade_NEWTableAdapter As DSDeptTableAdapters.tbl_HRM_Grade_NEWTableAdapter
    Friend WithEvents TableAdapterManager2 As DSDeptTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_Grade_NEW2TableAdapter As DSDeptTableAdapters.tbl_HRM_Grade_NEW2TableAdapter
    Friend WithEvents Tbl_HRM_Grade_NEW2BindingSource As BindingSource
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
