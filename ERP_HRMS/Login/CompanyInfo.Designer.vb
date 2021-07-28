<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompanyInfo
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
        Dim PhoneNoLabel As System.Windows.Forms.Label
        Dim SalayTypeLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim OverTimeTypeLabel As System.Windows.Forms.Label
        Dim CompanyStartYearLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim SignLabel As System.Windows.Forms.Label
        Dim PEESIFIXLabel As System.Windows.Forms.Label
        Dim EOBIFixLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim BuffetMealDedLabel As System.Windows.Forms.Label
        Dim LabourMealDedLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyInfo))
        Dim Label9 As System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AnnualLeavesCheckBox = New System.Windows.Forms.CheckBox()
        Me.CasualLeavesCheckBox = New System.Windows.Forms.CheckBox()
        Me.MedicalLeavesCheckBox = New System.Windows.Forms.CheckBox()
        Me.LabourMealDedTextBox = New System.Windows.Forms.TextBox()
        Me.BuffetMealDedTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EOBIFixTextBox = New System.Windows.Forms.TextBox()
        Me.PEESIFIXTextBox = New System.Windows.Forms.TextBox()
        Me.SignTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SalayTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.PhoneNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.OverTimeTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyStartYearTextBox = New System.Windows.Forms.TextBox()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_Comp_InfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Comp_InfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.PerDayTravel = New System.Windows.Forms.TextBox()
        PhoneNoLabel = New System.Windows.Forms.Label()
        SalayTypeLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        OverTimeTypeLabel = New System.Windows.Forms.Label()
        CompanyStartYearLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        SignLabel = New System.Windows.Forms.Label()
        PEESIFIXLabel = New System.Windows.Forms.Label()
        EOBIFixLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        BuffetMealDedLabel = New System.Windows.Forms.Label()
        LabourMealDedLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Comp_InfoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PhoneNoLabel
        '
        PhoneNoLabel.Location = New System.Drawing.Point(18, 272)
        PhoneNoLabel.Name = "PhoneNoLabel"
        PhoneNoLabel.Size = New System.Drawing.Size(117, 20)
        PhoneNoLabel.TabIndex = 29
        PhoneNoLabel.Text = "Phone No:"
        PhoneNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalayTypeLabel
        '
        SalayTypeLabel.Location = New System.Drawing.Point(18, 299)
        SalayTypeLabel.Name = "SalayTypeLabel"
        SalayTypeLabel.Size = New System.Drawing.Size(117, 20)
        SalayTypeLabel.TabIndex = 20
        SalayTypeLabel.Text = "Salay Criteria"
        SalayTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.Location = New System.Drawing.Point(18, 245)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(117, 20)
        EmailAddressLabel.TabIndex = 27
        EmailAddressLabel.Text = "Email Address:"
        EmailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OverTimeTypeLabel
        '
        OverTimeTypeLabel.Location = New System.Drawing.Point(18, 327)
        OverTimeTypeLabel.Name = "OverTimeTypeLabel"
        OverTimeTypeLabel.Size = New System.Drawing.Size(117, 20)
        OverTimeTypeLabel.TabIndex = 23
        OverTimeTypeLabel.Text = "Over Time Criteria:"
        '
        'CompanyStartYearLabel
        '
        CompanyStartYearLabel.Location = New System.Drawing.Point(18, 62)
        CompanyStartYearLabel.Name = "CompanyStartYearLabel"
        CompanyStartYearLabel.Size = New System.Drawing.Size(117, 20)
        CompanyStartYearLabel.TabIndex = 25
        CompanyStartYearLabel.Text = "Start Year:"
        '
        'AddressLabel
        '
        AddressLabel.Location = New System.Drawing.Point(18, 353)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(117, 20)
        AddressLabel.TabIndex = 18
        AddressLabel.Text = "Address:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.Location = New System.Drawing.Point(18, 36)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(117, 20)
        CompanyNameLabel.TabIndex = 16
        CompanyNameLabel.Text = "Name:"
        '
        'SignLabel
        '
        SignLabel.AutoSize = True
        SignLabel.Location = New System.Drawing.Point(65, 91)
        SignLabel.Name = "SignLabel"
        SignLabel.Size = New System.Drawing.Size(31, 13)
        SignLabel.TabIndex = 31
        SignLabel.Text = "Sign:"
        '
        'PEESIFIXLabel
        '
        PEESIFIXLabel.Location = New System.Drawing.Point(18, 117)
        PEESIFIXLabel.Name = "PEESIFIXLabel"
        PEESIFIXLabel.Size = New System.Drawing.Size(117, 20)
        PEESIFIXLabel.TabIndex = 31
        PEESIFIXLabel.Text = "PEESI Fix Amt.:"
        PEESIFIXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EOBIFixLabel
        '
        EOBIFixLabel.Location = New System.Drawing.Point(18, 140)
        EOBIFixLabel.Name = "EOBIFixLabel"
        EOBIFixLabel.Size = New System.Drawing.Size(117, 20)
        EOBIFixLabel.TabIndex = 32
        EOBIFixLabel.Text = "EOBI Fix Amt.:"
        EOBIFixLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.Location = New System.Drawing.Point(18, 35)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(117, 20)
        Label3.TabIndex = 1
        Label3.Text = "Company Name:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(18, 352)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(117, 20)
        Label4.TabIndex = 18
        Label4.Text = "Address:"
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(18, 61)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(117, 20)
        Label5.TabIndex = 25
        Label5.Text = "Start Year:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(18, 326)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(117, 20)
        Label6.TabIndex = 23
        Label6.Text = "Over Time Criteria:"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(18, 90)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(117, 20)
        Label7.TabIndex = 31
        Label7.Text = "Employee Card Sign:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BuffetMealDedLabel
        '
        BuffetMealDedLabel.Location = New System.Drawing.Point(18, 168)
        BuffetMealDedLabel.Name = "BuffetMealDedLabel"
        BuffetMealDedLabel.Size = New System.Drawing.Size(117, 20)
        BuffetMealDedLabel.TabIndex = 33
        BuffetMealDedLabel.Text = "Buffet Meal Ded:"
        BuffetMealDedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabourMealDedLabel
        '
        LabourMealDedLabel.Location = New System.Drawing.Point(18, 194)
        LabourMealDedLabel.Name = "LabourMealDedLabel"
        LabourMealDedLabel.Size = New System.Drawing.Size(117, 20)
        LabourMealDedLabel.TabIndex = 34
        LabourMealDedLabel.Text = "Labour Meal Ded:"
        LabourMealDedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Label8.Location = New System.Drawing.Point(18, 426)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(110, 20)
        Label8.TabIndex = 44
        Label8.Text = "Reports Locations:"
        Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Label8)
        Me.Panel1.Controls.Add(Me.PerDayTravel)
        Me.Panel1.Controls.Add(Me.tbFilePath)
        Me.Panel1.Controls.Add(Me.btnOpenFile)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(LabourMealDedLabel)
        Me.Panel1.Controls.Add(Me.LabourMealDedTextBox)
        Me.Panel1.Controls.Add(BuffetMealDedLabel)
        Me.Panel1.Controls.Add(Me.BuffetMealDedTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(EOBIFixLabel)
        Me.Panel1.Controls.Add(Me.EOBIFixTextBox)
        Me.Panel1.Controls.Add(PEESIFIXLabel)
        Me.Panel1.Controls.Add(Me.PEESIFIXTextBox)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(SignLabel)
        Me.Panel1.Controls.Add(Me.SignTextBox)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(PhoneNoLabel)
        Me.Panel1.Controls.Add(Me.SalayTypeComboBox)
        Me.Panel1.Controls.Add(SalayTypeLabel)
        Me.Panel1.Controls.Add(Me.PhoneNoMaskedTextBox)
        Me.Panel1.Controls.Add(Me.OverTimeTypeComboBox)
        Me.Panel1.Controls.Add(EmailAddressLabel)
        Me.Panel1.Controls.Add(Label6)
        Me.Panel1.Controls.Add(OverTimeTypeLabel)
        Me.Panel1.Controls.Add(Me.EmailAddressTextBox)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(CompanyStartYearLabel)
        Me.Panel1.Controls.Add(Me.CompanyStartYearTextBox)
        Me.Panel1.Controls.Add(Me.LogoPictureBox)
        Me.Panel1.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(CompanyNameLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(Me.Tbl_Comp_InfoBindingNavigator)
        Me.Panel1.Location = New System.Drawing.Point(101, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 631)
        Me.Panel1.TabIndex = 6
        '
        'tbFilePath
        '
        Me.tbFilePath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "ReportsPath", True))
        Me.tbFilePath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tbFilePath.Location = New System.Drawing.Point(137, 426)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.ReadOnly = True
        Me.tbFilePath.Size = New System.Drawing.Size(303, 20)
        Me.tbFilePath.TabIndex = 42
        Me.tbFilePath.TabStop = False
        Me.tbFilePath.Text = "Browse Reports Location Here."
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
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.White
        Me.btnOpenFile.Enabled = False
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.Color.DarkRed
        Me.btnOpenFile.Location = New System.Drawing.Point(446, 423)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(86, 24)
        Me.btnOpenFile.TabIndex = 43
        Me.btnOpenFile.Text = "Browse Folder"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AnnualLeavesCheckBox)
        Me.GroupBox1.Controls.Add(Me.CasualLeavesCheckBox)
        Me.GroupBox1.Controls.Add(Me.MedicalLeavesCheckBox)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(60, 455)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 76)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Yearly Leaves Calculation"
        '
        'AnnualLeavesCheckBox
        '
        Me.AnnualLeavesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Comp_InfoBindingSource, "AnnualLeaves", True))
        Me.AnnualLeavesCheckBox.Location = New System.Drawing.Point(16, 29)
        Me.AnnualLeavesCheckBox.Name = "AnnualLeavesCheckBox"
        Me.AnnualLeavesCheckBox.Size = New System.Drawing.Size(118, 24)
        Me.AnnualLeavesCheckBox.TabIndex = 7
        Me.AnnualLeavesCheckBox.Text = "Annual Leaves (14)"
        Me.AnnualLeavesCheckBox.UseVisualStyleBackColor = True
        '
        'CasualLeavesCheckBox
        '
        Me.CasualLeavesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Comp_InfoBindingSource, "CasualLeaves", True))
        Me.CasualLeavesCheckBox.Location = New System.Drawing.Point(152, 29)
        Me.CasualLeavesCheckBox.Name = "CasualLeavesCheckBox"
        Me.CasualLeavesCheckBox.Size = New System.Drawing.Size(126, 24)
        Me.CasualLeavesCheckBox.TabIndex = 5
        Me.CasualLeavesCheckBox.Text = "Casual Leaves (10)"
        Me.CasualLeavesCheckBox.UseVisualStyleBackColor = True
        '
        'MedicalLeavesCheckBox
        '
        Me.MedicalLeavesCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Comp_InfoBindingSource, "MedicalLeaves", True))
        Me.MedicalLeavesCheckBox.Location = New System.Drawing.Point(284, 29)
        Me.MedicalLeavesCheckBox.Name = "MedicalLeavesCheckBox"
        Me.MedicalLeavesCheckBox.Size = New System.Drawing.Size(124, 24)
        Me.MedicalLeavesCheckBox.TabIndex = 4
        Me.MedicalLeavesCheckBox.Text = "Medical Leaves (8)"
        Me.MedicalLeavesCheckBox.UseVisualStyleBackColor = True
        '
        'LabourMealDedTextBox
        '
        Me.LabourMealDedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "LabourMealDed", True))
        Me.LabourMealDedTextBox.Location = New System.Drawing.Point(141, 191)
        Me.LabourMealDedTextBox.Name = "LabourMealDedTextBox"
        Me.LabourMealDedTextBox.ReadOnly = True
        Me.LabourMealDedTextBox.Size = New System.Drawing.Size(119, 20)
        Me.LabourMealDedTextBox.TabIndex = 6
        Me.LabourMealDedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BuffetMealDedTextBox
        '
        Me.BuffetMealDedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "BuffetMealDed", True))
        Me.BuffetMealDedTextBox.Location = New System.Drawing.Point(141, 165)
        Me.BuffetMealDedTextBox.Name = "BuffetMealDedTextBox"
        Me.BuffetMealDedTextBox.ReadOnly = True
        Me.BuffetMealDedTextBox.Size = New System.Drawing.Size(119, 20)
        Me.BuffetMealDedTextBox.TabIndex = 5
        Me.BuffetMealDedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(263, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Enter Single Sign For BarCode"
        '
        'EOBIFixTextBox
        '
        Me.EOBIFixTextBox.BackColor = System.Drawing.Color.White
        Me.EOBIFixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "EOBIFix", True))
        Me.EOBIFixTextBox.Location = New System.Drawing.Point(141, 139)
        Me.EOBIFixTextBox.Name = "EOBIFixTextBox"
        Me.EOBIFixTextBox.ReadOnly = True
        Me.EOBIFixTextBox.Size = New System.Drawing.Size(119, 20)
        Me.EOBIFixTextBox.TabIndex = 4
        Me.EOBIFixTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PEESIFIXTextBox
        '
        Me.PEESIFIXTextBox.BackColor = System.Drawing.Color.White
        Me.PEESIFIXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "PEESIFIX", True))
        Me.PEESIFIXTextBox.Location = New System.Drawing.Point(141, 113)
        Me.PEESIFIXTextBox.Name = "PEESIFIXTextBox"
        Me.PEESIFIXTextBox.ReadOnly = True
        Me.PEESIFIXTextBox.Size = New System.Drawing.Size(119, 20)
        Me.PEESIFIXTextBox.TabIndex = 3
        Me.PEESIFIXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SignTextBox
        '
        Me.SignTextBox.BackColor = System.Drawing.Color.White
        Me.SignTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "Sign", True))
        Me.SignTextBox.Location = New System.Drawing.Point(141, 87)
        Me.SignTextBox.MaxLength = 1
        Me.SignTextBox.Name = "SignTextBox"
        Me.SignTextBox.ReadOnly = True
        Me.SignTextBox.Size = New System.Drawing.Size(119, 20)
        Me.SignTextBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.SignTextBox, "Enter Single Sign For BarCode ")
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(464, 155)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Upload Logo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SalayTypeComboBox
        '
        Me.SalayTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "SalayType", True))
        Me.SalayTypeComboBox.Enabled = False
        Me.SalayTypeComboBox.FormattingEnabled = True
        Me.SalayTypeComboBox.Items.AddRange(New Object() {"26 Days", "Month Days"})
        Me.SalayTypeComboBox.Location = New System.Drawing.Point(141, 295)
        Me.SalayTypeComboBox.Name = "SalayTypeComboBox"
        Me.SalayTypeComboBox.Size = New System.Drawing.Size(227, 21)
        Me.SalayTypeComboBox.TabIndex = 9
        '
        'PhoneNoMaskedTextBox
        '
        Me.PhoneNoMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.PhoneNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "PhoneNo", True))
        Me.PhoneNoMaskedTextBox.Location = New System.Drawing.Point(141, 269)
        Me.PhoneNoMaskedTextBox.Name = "PhoneNoMaskedTextBox"
        Me.PhoneNoMaskedTextBox.ReadOnly = True
        Me.PhoneNoMaskedTextBox.Size = New System.Drawing.Size(227, 20)
        Me.PhoneNoMaskedTextBox.TabIndex = 8
        '
        'OverTimeTypeComboBox
        '
        Me.OverTimeTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "OverTimeType", True))
        Me.OverTimeTypeComboBox.Enabled = False
        Me.OverTimeTypeComboBox.FormattingEnabled = True
        Me.OverTimeTypeComboBox.Items.AddRange(New Object() {"Single", "One And Half ", "Double"})
        Me.OverTimeTypeComboBox.Location = New System.Drawing.Point(141, 322)
        Me.OverTimeTypeComboBox.Name = "OverTimeTypeComboBox"
        Me.OverTimeTypeComboBox.Size = New System.Drawing.Size(227, 21)
        Me.OverTimeTypeComboBox.TabIndex = 10
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.BackColor = System.Drawing.Color.White
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(141, 243)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.ReadOnly = True
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(227, 20)
        Me.EmailAddressTextBox.TabIndex = 7
        '
        'CompanyStartYearTextBox
        '
        Me.CompanyStartYearTextBox.BackColor = System.Drawing.Color.White
        Me.CompanyStartYearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "CompanyStartYear", True))
        Me.CompanyStartYearTextBox.Location = New System.Drawing.Point(141, 61)
        Me.CompanyStartYearTextBox.Name = "CompanyStartYearTextBox"
        Me.CompanyStartYearTextBox.ReadOnly = True
        Me.CompanyStartYearTextBox.Size = New System.Drawing.Size(119, 20)
        Me.CompanyStartYearTextBox.TabIndex = 1
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_Comp_InfoBindingSource, "Logo", True))
        Me.LogoPictureBox.Location = New System.Drawing.Point(464, 35)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(122, 116)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 21
        Me.LogoPictureBox.TabStop = False
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.BackColor = System.Drawing.Color.White
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(141, 35)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.ReadOnly = True
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(299, 20)
        Me.CompanyNameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.White
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(141, 350)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(299, 70)
        Me.AddressTextBox.TabIndex = 11
        '
        'Tbl_Comp_InfoBindingNavigator
        '
        Me.Tbl_Comp_InfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Comp_InfoBindingNavigator.BindingSource = Me.Tbl_Comp_InfoBindingSource
        Me.Tbl_Comp_InfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Comp_InfoBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Comp_InfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_Comp_InfoBindingNavigatorSaveItem, Me.EditToolStripButton, Me.CancelToolStripButton})
        Me.Tbl_Comp_InfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Comp_InfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Comp_InfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Comp_InfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Comp_InfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Comp_InfoBindingNavigator.Name = "Tbl_Comp_InfoBindingNavigator"
        Me.Tbl_Comp_InfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Comp_InfoBindingNavigator.Size = New System.Drawing.Size(650, 25)
        Me.Tbl_Comp_InfoBindingNavigator.TabIndex = 6
        Me.Tbl_Comp_InfoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add New Compnay Information"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'Tbl_Comp_InfoBindingNavigatorSaveItem
        '
        Me.Tbl_Comp_InfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Comp_InfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Comp_InfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Comp_InfoBindingNavigatorSaveItem.Name = "Tbl_Comp_InfoBindingNavigatorSaveItem"
        Me.Tbl_Comp_InfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Comp_InfoBindingNavigatorSaveItem.Text = "Save Company Information"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.edit_29
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "&Edit Compnay Information"
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.images__1_
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelToolStripButton.Text = "&Cancel"
        Me.CancelToolStripButton.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(981, 42)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Company Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Comp_InfoTableAdapter = Me.Tbl_Comp_InfoTableAdapter
        Me.TableAdapterManager.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Label9
        '
        Label9.Location = New System.Drawing.Point(18, 220)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(117, 20)
        Label9.TabIndex = 44
        Label9.Text = "Per Day Travel:"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PerDayTravel
        '
        Me.PerDayTravel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "DailyTravelAllowance", True))
        Me.PerDayTravel.Location = New System.Drawing.Point(141, 217)
        Me.PerDayTravel.Name = "PerDayTravel"
        Me.PerDayTravel.ReadOnly = True
        Me.PerDayTravel.Size = New System.Drawing.Size(119, 20)
        Me.PerDayTravel.TabIndex = 45
        Me.PerDayTravel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CompanyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(981, 712)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CompanyInfo"
        Me.Text = "Company Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Comp_InfoBindingNavigator.ResumeLayout(False)
        Me.Tbl_Comp_InfoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSUser As DSUser
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents TableAdapterManager As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_Comp_InfoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_Comp_InfoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents SalayTypeComboBox As ComboBox
    Friend WithEvents PhoneNoMaskedTextBox As MaskedTextBox
    Friend WithEvents OverTimeTypeComboBox As ComboBox
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents CompanyStartYearTextBox As TextBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CancelToolStripButton As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents SignTextBox As TextBox
    Friend WithEvents EOBIFixTextBox As TextBox
    Friend WithEvents PEESIFIXTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label2 As Label
    Friend WithEvents LabourMealDedTextBox As TextBox
    Friend WithEvents BuffetMealDedTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AnnualLeavesCheckBox As CheckBox
    Friend WithEvents CasualLeavesCheckBox As CheckBox
    Friend WithEvents MedicalLeavesCheckBox As CheckBox
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents PerDayTravel As TextBox
End Class
