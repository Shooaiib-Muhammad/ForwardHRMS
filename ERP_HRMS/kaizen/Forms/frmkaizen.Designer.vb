<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmkaizen
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
        Dim EffectLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim FNameLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim SavingAmtLabel As System.Windows.Forms.Label
        Dim TenureLabel As System.Windows.Forms.Label
        Dim SavingManPLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmkaizen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Tbl_Hrm_kaizen_activity_recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet6 = New ERP_HRMS.DataSet6()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.FNameLabel1 = New System.Windows.Forms.Label()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.EffectTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.CMSEmpInfo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSName = New System.Windows.Forms.ToolStripTextBox()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EmpPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.BeforeTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBrowse1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AfterTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.KARIDLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_kaizen_activity_recordTableAdapter = New ERP_HRMS.DataSet6TableAdapters.tbl_Hrm_kaizen_activity_recordTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DataSet6TableAdapters.TableAdapterManager()
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter = New ERP_HRMS.DataSet6TableAdapters.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.LockBtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SavingManPTextBox = New System.Windows.Forms.TextBox()
        Me.TenureTextBox = New System.Windows.Forms.TextBox()
        Me.SavingAmtTextBox = New System.Windows.Forms.TextBox()
        Me.ImpCat = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Category = New System.Windows.Forms.ComboBox()
        Me.ECRS = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        'Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        'Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        'Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        'Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.View_Rpt_Acc_AllEmployees_ActiveSalary1TableAdapter = New ERP_HRMS.DataSet6TableAdapters.View_Rpt_Acc_AllEmployees_ActiveSalary1TableAdapter()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        EffectLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        CardNoLabel = New System.Windows.Forms.Label()
        FNameLabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        SavingAmtLabel = New System.Windows.Forms.Label()
        TenureLabel = New System.Windows.Forms.Label()
        SavingManPLabel = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Hrm_kaizen_activity_recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSEmpInfo.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'EffectLabel
        '
        EffectLabel.BackColor = System.Drawing.Color.LightGray
        EffectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        EffectLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EffectLabel.Location = New System.Drawing.Point(3, 466)
        EffectLabel.Name = "EffectLabel"
        EffectLabel.Size = New System.Drawing.Size(90, 44)
        EffectLabel.TabIndex = 11
        EffectLabel.Text = "Effect:"
        EffectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemarksLabel
        '
        RemarksLabel.BackColor = System.Drawing.Color.LightGray
        RemarksLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        RemarksLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RemarksLabel.Location = New System.Drawing.Point(3, 544)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(90, 38)
        RemarksLabel.TabIndex = 12
        RemarksLabel.Text = "Remarks:"
        RemarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CardNoLabel
        '
        CardNoLabel.BackColor = System.Drawing.Color.LightGray
        CardNoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        CardNoLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CardNoLabel.Location = New System.Drawing.Point(3, 515)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(90, 25)
        CardNoLabel.TabIndex = 13
        CardNoLabel.Text = "Card No:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FNameLabel
        '
        FNameLabel.BackColor = System.Drawing.Color.LightGray
        FNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        FNameLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FNameLabel.Location = New System.Drawing.Point(187, 515)
        FNameLabel.Name = "FNameLabel"
        FNameLabel.Size = New System.Drawing.Size(90, 25)
        FNameLabel.TabIndex = 14
        FNameLabel.Text = "Name:"
        FNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeptNameLabel
        '
        DeptNameLabel.BackColor = System.Drawing.Color.LightGray
        DeptNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DeptNameLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeptNameLabel.Location = New System.Drawing.Point(415, 515)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(97, 25)
        DeptNameLabel.TabIndex = 15
        DeptNameLabel.Text = "Dept Name:"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DesigNameLabel
        '
        DesigNameLabel.BackColor = System.Drawing.Color.LightGray
        DesigNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DesigNameLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesigNameLabel.Location = New System.Drawing.Point(642, 515)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(101, 25)
        DesigNameLabel.TabIndex = 16
        DesigNameLabel.Text = "Desig Name:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SavingAmtLabel
        '
        SavingAmtLabel.AutoSize = True
        SavingAmtLabel.Location = New System.Drawing.Point(5, 259)
        SavingAmtLabel.Name = "SavingAmtLabel"
        SavingAmtLabel.Size = New System.Drawing.Size(64, 13)
        SavingAmtLabel.TabIndex = 12
        SavingAmtLabel.Text = "Saving Amt:"
        '
        'TenureLabel
        '
        TenureLabel.AutoSize = True
        TenureLabel.Location = New System.Drawing.Point(25, 278)
        TenureLabel.Name = "TenureLabel"
        TenureLabel.Size = New System.Drawing.Size(44, 13)
        TenureLabel.TabIndex = 13
        TenureLabel.Text = "Tenure:"
        '
        'SavingManPLabel
        '
        SavingManPLabel.Location = New System.Drawing.Point(5, 301)
        SavingManPLabel.Name = "SavingManPLabel"
        SavingManPLabel.Size = New System.Drawing.Size(64, 27)
        SavingManPLabel.TabIndex = 15
        SavingManPLabel.Text = "Saving Man Power:"
        SavingManPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Label13.BackColor = System.Drawing.Color.LightGray
        Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(-1, 0)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(158, 22)
        Label13.TabIndex = 16
        Label13.Text = "Supporting Card No:"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Label16.BackColor = System.Drawing.Color.LightGray
        Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label16.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.Location = New System.Drawing.Point(267, 0)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(103, 22)
        Label16.TabIndex = 17
        Label16.Text = "Name:"
        Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Label18.BackColor = System.Drawing.Color.LightGray
        Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label18.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.Location = New System.Drawing.Point(494, 0)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(107, 22)
        Label18.TabIndex = 21
        Label18.Text = "Desig Name:"
        Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1146, 33)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "KAIZEN Activity Record"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.MaskedTextBox2)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(DesigNameLabel)
        Me.Panel1.Controls.Add(Me.DesigNameLabel1)
        Me.Panel1.Controls.Add(DeptNameLabel)
        Me.Panel1.Controls.Add(Me.DeptNameLabel1)
        Me.Panel1.Controls.Add(FNameLabel)
        Me.Panel1.Controls.Add(Me.FNameLabel1)
        Me.Panel1.Controls.Add(CardNoLabel)
        Me.Panel1.Controls.Add(Me.CardNoComboBox)
        Me.Panel1.Controls.Add(RemarksLabel)
        Me.Panel1.Controls.Add(Me.RemarksTextBox)
        Me.Panel1.Controls.Add(EffectLabel)
        Me.Panel1.Controls.Add(Me.EffectTextBox)
        Me.Panel1.Controls.Add(Me.TitleTextBox)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(25, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 616)
        Me.Panel1.TabIndex = 8
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "TWStatus", True))
        Me.CheckBox2.Location = New System.Drawing.Point(9, 588)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(96, 17)
        Me.CheckBox2.TabIndex = 13
        Me.CheckBox2.Text = "Team Working"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Tbl_Hrm_kaizen_activity_recordBindingSource
        '
        Me.Tbl_Hrm_kaizen_activity_recordBindingSource.DataMember = "tbl_Hrm_kaizen_activity_record"
        Me.Tbl_Hrm_kaizen_activity_recordBindingSource.DataSource = Me.DataSet6
        '
        'DataSet6
        '
        Me.DataSet6.DataSetName = "DataSet6"
        Me.DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "KARID", True))
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(64, -1)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(65, 33)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem1.Text = "&Search By Sr No."
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem2.Text = "&Refresh"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightGray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, -1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 33)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Title:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "KaizenDate", True))
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(748, 488)
        Me.MaskedTextBox2.Mask = "00/00/0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(130, 20)
        Me.MaskedTextBox2.TabIndex = 12
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource, "FName", True))
        Me.Label17.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(511, 587)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 22)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Label6"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource
        '
        Me.View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource.DataMember = "View_Rpt_Acc_AllEmployees_ActiveSalary1"
        Me.View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource.DataSource = Me.DataSet6
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(748, 467)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Label13)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Label18)
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Controls.Add(Label16)
        Me.Panel6.Enabled = False
        Me.Panel6.Location = New System.Drawing.Point(141, 586)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(736, 24)
        Me.Panel6.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource, "DesigName", True))
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(600, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(134, 22)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Label6"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "TWCard", True))
        Me.ComboBox1.DataSource = Me.View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource
        Me.ComboBox1.DisplayMember = "CardNo"
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(156, -2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(110, 27)
        Me.ComboBox1.TabIndex = 15
        Me.ComboBox1.ValueMember = "CardNo"
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource, "DesigName", True))
        Me.DesigNameLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(754, 515)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(121, 25)
        Me.DesigNameLabel1.TabIndex = 17
        Me.DesigNameLabel1.Text = "Label6"
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource
        '
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource.DataMember = "View_Rpt_Acc_AllEmployees_ActiveSalary"
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource.DataSource = Me.DataSet6
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource, "SubDept2", True))
        Me.DeptNameLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptNameLabel1.Location = New System.Drawing.Point(517, 515)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(121, 25)
        Me.DeptNameLabel1.TabIndex = 16
        Me.DeptNameLabel1.Text = "Label6"
        Me.DeptNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FNameLabel1
        '
        Me.FNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource, "FName", True))
        Me.FNameLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameLabel1.Location = New System.Drawing.Point(283, 515)
        Me.FNameLabel1.Name = "FNameLabel1"
        Me.FNameLabel1.Size = New System.Drawing.Size(131, 25)
        Me.FNameLabel1.TabIndex = 15
        Me.FNameLabel1.Text = "Label6"
        Me.FNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "CardNo", True))
        Me.CardNoComboBox.DataSource = Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(101, 514)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(78, 27)
        Me.CardNoComboBox.TabIndex = 4
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Remarks", True))
        Me.RemarksTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemarksTextBox.Location = New System.Drawing.Point(99, 544)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(779, 38)
        Me.RemarksTextBox.TabIndex = 5
        '
        'EffectTextBox
        '
        Me.EffectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EffectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Effect", True))
        Me.EffectTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EffectTextBox.Location = New System.Drawing.Point(99, 467)
        Me.EffectTextBox.Multiline = True
        Me.EffectTextBox.Name = "EffectTextBox"
        Me.EffectTextBox.Size = New System.Drawing.Size(643, 43)
        Me.EffectTextBox.TabIndex = 3
        '
        'TitleTextBox
        '
        Me.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitleTextBox.ContextMenuStrip = Me.CMSEmpInfo
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(187, -1)
        Me.TitleTextBox.Multiline = True
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(490, 33)
        Me.TitleTextBox.TabIndex = 0
        Me.TitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CMSEmpInfo
        '
        Me.CMSEmpInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.CMSEmpInfo.Name = "ContextMenuStrip1"
        Me.CMSEmpInfo.Size = New System.Drawing.Size(152, 48)
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSName})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SearchToolStripMenuItem.Text = "&Search By Title"
        '
        'txtSName
        '
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(100, 23)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.White
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "KARCode", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(740, 1)
        Me.MaskedTextBox1.Mask = "IMS-AAAAA-000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(142, 31)
        Me.MaskedTextBox1.TabIndex = 1
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(674, -1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 33)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Code:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 35)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnBrowse)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EmpPicPictureBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BeforeTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnBrowse1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AfterTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Size = New System.Drawing.Size(874, 428)
        Me.SplitContainer1.SplitterDistance = 434
        Me.SplitContainer1.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Maroon
        Me.btnBrowse.Location = New System.Drawing.Point(223, 396)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(207, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Upload Image"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Brown
        Me.Button1.Location = New System.Drawing.Point(5, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 23)
        Me.Button1.TabIndex = 129
        Me.Button1.Text = "Save Photo As"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EmpPicPictureBox
        '
        Me.EmpPicPictureBox.BackColor = System.Drawing.Color.White
        Me.EmpPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "BeforeVisual", True))
        Me.EmpPicPictureBox.Location = New System.Drawing.Point(3, 93)
        Me.EmpPicPictureBox.Name = "EmpPicPictureBox"
        Me.EmpPicPictureBox.Size = New System.Drawing.Size(426, 300)
        Me.EmpPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPicPictureBox.TabIndex = 114
        Me.EmpPicPictureBox.TabStop = False
        '
        'BeforeTextBox
        '
        Me.BeforeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BeforeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Before", True))
        Me.BeforeTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeforeTextBox.Location = New System.Drawing.Point(3, 28)
        Me.BeforeTextBox.Multiline = True
        Me.BeforeTextBox.Name = "BeforeTextBox"
        Me.BeforeTextBox.Size = New System.Drawing.Size(426, 65)
        Me.BeforeTextBox.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(432, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Before"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBrowse1
        '
        Me.btnBrowse1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBrowse1.Location = New System.Drawing.Point(221, 396)
        Me.btnBrowse1.Name = "btnBrowse1"
        Me.btnBrowse1.Size = New System.Drawing.Size(207, 23)
        Me.btnBrowse1.TabIndex = 1
        Me.btnBrowse1.Text = "Upload Image"
        Me.btnBrowse1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(4, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 23)
        Me.Button2.TabIndex = 130
        Me.Button2.Text = "Save Photo As"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "AfterVisual", True))
        Me.PictureBox1.Location = New System.Drawing.Point(3, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 115
        Me.PictureBox1.TabStop = False
        '
        'AfterTextBox
        '
        Me.AfterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AfterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "After", True))
        Me.AfterTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AfterTextBox.Location = New System.Drawing.Point(3, 28)
        Me.AfterTextBox.Multiline = True
        Me.AfterTextBox.Name = "AfterTextBox"
        Me.AfterTextBox.Size = New System.Drawing.Size(426, 65)
        Me.AfterTextBox.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(434, 28)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "After"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sr No."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Hrm_kaizen_activity_recordBindingNavigator
        '
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.BindingSource = Me.Tbl_Hrm_kaizen_activity_recordBindingSource
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem, Me.ToolStripLabel1})
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.Name = "Tbl_Hrm_kaizen_activity_recordBindingNavigator"
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.Size = New System.Drawing.Size(880, 25)
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.TabIndex = 9
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
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
        'Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem
        '
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem.Name = "Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem"
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(92, 22)
        Me.ToolStripLabel1.Text = "Search By Code:"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "*.jpg"
        Me.SaveFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;*.gif;*.png;"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'KARIDLabel1
        '
        Me.KARIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "KARID", True))
        Me.KARIDLabel1.Location = New System.Drawing.Point(1011, 42)
        Me.KARIDLabel1.Name = "KARIDLabel1"
        Me.KARIDLabel1.Size = New System.Drawing.Size(4, 2)
        Me.KARIDLabel1.TabIndex = 10
        Me.KARIDLabel1.Text = "Label7"
        '
        'Tbl_Hrm_kaizen_activity_recordTableAdapter
        '
        Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Hrm_Formal_Kaizen_DetailTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Formal_Kaizen_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_kaizen_activity_recordTableAdapter = Me.Tbl_Hrm_kaizen_activity_recordTableAdapter
        'Me.TableAdapterManager.tbl_Hrm_kaizen_IdeasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter
        '
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Controls.Add(Me.LockBtn)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator)
        Me.Panel2.Location = New System.Drawing.Point(26, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(882, 28)
        Me.Panel2.TabIndex = 11
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSearch.Location = New System.Drawing.Point(396, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(178, 20)
        Me.txtSearch.TabIndex = 48
        '
        'LockBtn
        '
        Me.LockBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LockBtn.ForeColor = System.Drawing.Color.Yellow
        Me.LockBtn.Location = New System.Drawing.Point(579, 2)
        Me.LockBtn.Name = "LockBtn"
        Me.LockBtn.Size = New System.Drawing.Size(69, 23)
        Me.LockBtn.TabIndex = 13
        Me.LockBtn.Text = "Lock"
        Me.LockBtn.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(655, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "View Report"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Location = New System.Drawing.Point(758, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Submit Kaizen"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(SavingManPLabel)
        Me.Panel3.Controls.Add(Me.SavingManPTextBox)
        Me.Panel3.Controls.Add(TenureLabel)
        Me.Panel3.Controls.Add(Me.TenureTextBox)
        Me.Panel3.Controls.Add(SavingAmtLabel)
        Me.Panel3.Controls.Add(Me.SavingAmtTextBox)
        Me.Panel3.Controls.Add(Me.ImpCat)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.Category)
        Me.Panel3.Controls.Add(Me.ECRS)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Location = New System.Drawing.Point(914, 241)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(196, 410)
        Me.Panel3.TabIndex = 12
        '
        'SavingManPTextBox
        '
        Me.SavingManPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "SavingManP", True))
        Me.SavingManPTextBox.Location = New System.Drawing.Point(75, 303)
        Me.SavingManPTextBox.Name = "SavingManPTextBox"
        Me.SavingManPTextBox.Size = New System.Drawing.Size(110, 20)
        Me.SavingManPTextBox.TabIndex = 16
        '
        'TenureTextBox
        '
        Me.TenureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Tenure", True))
        Me.TenureTextBox.Location = New System.Drawing.Point(75, 277)
        Me.TenureTextBox.Name = "TenureTextBox"
        Me.TenureTextBox.Size = New System.Drawing.Size(110, 20)
        Me.TenureTextBox.TabIndex = 14
        '
        'SavingAmtTextBox
        '
        Me.SavingAmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "SavingAmt", True))
        Me.SavingAmtTextBox.Location = New System.Drawing.Point(75, 253)
        Me.SavingAmtTextBox.Name = "SavingAmtTextBox"
        Me.SavingAmtTextBox.Size = New System.Drawing.Size(110, 20)
        Me.SavingAmtTextBox.TabIndex = 13
        '
        'ImpCat
        '
        Me.ImpCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ImpCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ImpCat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "ImprovmentCat", True))
        Me.ImpCat.FormattingEnabled = True
        Me.ImpCat.Items.AddRange(New Object() {"Paper Wastage Reduction", "Usage of Recycled Paper", "Poly Bags Wastage Reduction", "Paper Usgae Reduction", "Carton Wastage Reduction", "Carton Usage Reduction", "Reduction in Fabric / Accessories Missing", "ERP Improvement", "Effective Space Utilization", "Process Improvement", "Reduction in Reworking", "Effective Information Flow", "Reduction in Material Re-Supply", "Optimized Usage of Man Power", "Effective Usage of Resources", "Reduction in Chemical Usage", "Material Sourcing"})
        Me.ImpCat.Location = New System.Drawing.Point(5, 380)
        Me.ImpCat.Name = "ImpCat"
        Me.ImpCat.Size = New System.Drawing.Size(183, 21)
        Me.ImpCat.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Maroon
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Yellow
        Me.Label11.Location = New System.Drawing.Point(5, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(185, 23)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Production Benefit"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "ProdBenefit", True))
        Me.TextBox5.Location = New System.Drawing.Point(5, 194)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(186, 53)
        Me.TextBox5.TabIndex = 8
        '
        'Category
        '
        Me.Category.AutoCompleteCustomSource.AddRange(New String() {"Formal KAIZEN", "Informal KAIZEN"})
        Me.Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Category.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Catagory", True))
        Me.Category.FormattingEnabled = True
        Me.Category.Items.AddRange(New Object() {"Formal KAIZEN", "Informal KAIZEN"})
        Me.Category.Location = New System.Drawing.Point(5, 329)
        Me.Category.Name = "Category"
        Me.Category.Size = New System.Drawing.Size(183, 21)
        Me.Category.TabIndex = 11
        '
        'ECRS
        '
        Me.ECRS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ECRS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ECRS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "ECRS", True))
        Me.ECRS.FormattingEnabled = True
        Me.ECRS.Items.AddRange(New Object() {"Eliminate", "Combine", "Re-Arrange", "Simplify", "Not Applicable"})
        Me.ECRS.Location = New System.Drawing.Point(5, 355)
        Me.ECRS.Name = "ECRS"
        Me.ECRS.Size = New System.Drawing.Size(183, 21)
        Me.ECRS.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Yellow
        Me.Label10.Location = New System.Drawing.Point(5, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(185, 23)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "After Activivty Detail"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "AfterADetail", True))
        Me.TextBox4.Location = New System.Drawing.Point(5, 110)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(185, 58)
        Me.TextBox4.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(5, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 23)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Short Description (Yearly)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "SDesYearly", True))
        Me.TextBox3.Location = New System.Drawing.Point(5, 26)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(185, 58)
        Me.TextBox3.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Maroon
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(923, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Short Description (Monthly)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "SDesMonthly", True))
        Me.TextBox2.Location = New System.Drawing.Point(923, 164)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(185, 58)
        Me.TextBox2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        'Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(917, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(193, 65)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KAIZEN Nature"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.RadioButton3)
        Me.Panel5.Controls.Add(Me.RadioButton4)
        Me.Panel5.Location = New System.Drawing.Point(6, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(184, 25)
        Me.Panel5.TabIndex = 2
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "NotShared", True))
        Me.RadioButton3.Location = New System.Drawing.Point(88, 4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Overall"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Shared", True))
        Me.RadioButton4.Location = New System.Drawing.Point(3, 4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Internal"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.RadioButton2)
        Me.Panel4.Controls.Add(Me.RadioButton1)
        'Me.Panel4.Controls.Add(Me.ShapeContainer2)
        Me.Panel4.Location = New System.Drawing.Point(6, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(184, 25)
        Me.Panel4.TabIndex = 1
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "NotApproved", True))
        Me.RadioButton2.Location = New System.Drawing.Point(88, 4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(91, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Not Approved"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Approved", True))
        Me.RadioButton1.Location = New System.Drawing.Point(3, 4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Approved"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        'Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        'Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        'Me.ShapeContainer2.Name = "ShapeContainer2"
        'Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        'Me.ShapeContainer2.Size = New System.Drawing.Size(182, 23)
        'Me.ShapeContainer2.TabIndex = 3
        'Me.ShapeContainer2.TabStop = False
        '
        'LineShape3
        '
        'Me.LineShape3.Name = "LineShape3"
        'Me.LineShape3.X1 = 70
        'Me.LineShape3.X2 = 90
        'Me.LineShape3.Y1 = 27
        'Me.LineShape3.Y2 = 27
        ''
        'ShapeContainer1
        '
        'Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        'Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        'Me.ShapeContainer1.Name = "ShapeContainer1"
        'Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        'Me.ShapeContainer1.Size = New System.Drawing.Size(187, 46)
        'Me.ShapeContainer1.TabIndex = 3
        'Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        'Me.LineShape2.Name = "LineShape2"
        'Me.LineShape2.X1 = 181
        'Me.LineShape2.X2 = 256
        'Me.LineShape2.Y1 = 27
        'Me.LineShape2.Y2 = 50
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "SStatuse", True))
        Me.CheckBox1.Location = New System.Drawing.Point(924, 225)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(124, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Included in Summary"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Maroon
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Yellow
        Me.Label12.Location = New System.Drawing.Point(912, 653)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Comments on KAIZEN for ME"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label12.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_kaizen_activity_recordBindingSource, "Coments", True))
        Me.TextBox6.Location = New System.Drawing.Point(912, 671)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(198, 46)
        Me.TextBox6.TabIndex = 10
        Me.TextBox6.Visible = False
        '
        'View_Rpt_Acc_AllEmployees_ActiveSalary1TableAdapter
        '
        Me.View_Rpt_Acc_AllEmployees_ActiveSalary1TableAdapter.ClearBeforeFill = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.DateTimePicker2)
        Me.Panel7.Controls.Add(Me.DateTimePicker1)
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Location = New System.Drawing.Point(26, 36)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(366, 30)
        Me.Panel7.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(200, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 20)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "To Date:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(255, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(73, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 20)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "From Date:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmkaizen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 728)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.KARIDLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label8)
        Me.KeyPreview = True
        Me.Name = "frmkaizen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Hrm_kaizen_activity_recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSEmpInfo.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.ResumeLayout(False)
        Me.Tbl_Hrm_kaizen_activity_recordBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataSet6 As ERP_HRMS.DataSet6
    Friend WithEvents Tbl_Hrm_kaizen_activity_recordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_kaizen_activity_recordTableAdapter As ERP_HRMS.DataSet6TableAdapters.tbl_Hrm_kaizen_activity_recordTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DataSet6TableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Hrm_kaizen_activity_recordBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BeforeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AfterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpPicPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents KARIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowse1 As System.Windows.Forms.Button
    Friend WithEvents EffectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DesigNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DeptNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents FNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter As ERP_HRMS.DataSet6TableAdapters.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LockBtn As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Category As System.Windows.Forms.ComboBox
    Friend WithEvents ECRS As System.Windows.Forms.ComboBox
    Friend WithEvents ImpCat As System.Windows.Forms.ComboBox
    Friend WithEvents SavingManPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TenureTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SavingAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CMSEmpInfo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    'Private WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Private WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Private WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label19 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents View_Rpt_Acc_AllEmployees_ActiveSalary1BindingSource As BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployees_ActiveSalary1TableAdapter As DataSet6TableAdapters.View_Rpt_Acc_AllEmployees_ActiveSalary1TableAdapter
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label15 As Label
End Class
