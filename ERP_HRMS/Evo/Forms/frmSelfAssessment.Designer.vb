<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelfAssessment
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
        Dim ESALabel As System.Windows.Forms.Label
        Dim EmpIDLabel As System.Windows.Forms.Label
        Dim FNameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim MonthlyObjectivesLabel As System.Windows.Forms.Label
        Dim PStatusLabel As System.Windows.Forms.Label
        Dim ReasonLabel As System.Windows.Forms.Label
        Dim StartTimeLabel As System.Windows.Forms.Label
        Dim EndTimeLabel As System.Windows.Forms.Label
        Dim AchievedLabel As System.Windows.Forms.Label
        Dim EffectiveDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelfAssessment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EffectiveDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSemployeeSelfAss = New ERP_HRMS.DSemployeeSelfAss()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.AchievedTextBox = New System.Windows.Forms.TextBox()
        Me.ReasonTextBox = New System.Windows.Forms.TextBox()
        Me.PStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.MonthlyObjectivesTextBox = New System.Windows.Forms.TextBox()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_AllEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FNameLabel1 = New System.Windows.Forms.Label()
        Me.EmpIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ESALabel1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.View_EmpEval_Self_AssessmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.View_EmpEval_Self_AssessmentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter = New ERP_HRMS.DSemployeeSelfAssTableAdapters.tbl_Hrm_EmpEval_Self_AssessmentTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSemployeeSelfAssTableAdapters.TableAdapterManager()
        Me.View_Rpt_Acc_AllEmployeesTableAdapter = New ERP_HRMS.DSemployeeSelfAssTableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter()
        Me.View_EmpEval_Self_AssessmentTableAdapter = New ERP_HRMS.DSemployeeSelfAssTableAdapters.View_EmpEval_Self_AssessmentTableAdapter()
        Me.UserIDLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        ESALabel = New System.Windows.Forms.Label()
        EmpIDLabel = New System.Windows.Forms.Label()
        FNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        MonthlyObjectivesLabel = New System.Windows.Forms.Label()
        PStatusLabel = New System.Windows.Forms.Label()
        ReasonLabel = New System.Windows.Forms.Label()
        StartTimeLabel = New System.Windows.Forms.Label()
        EndTimeLabel = New System.Windows.Forms.Label()
        AchievedLabel = New System.Windows.Forms.Label()
        EffectiveDateLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSemployeeSelfAss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_EmpEval_Self_AssessmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_EmpEval_Self_AssessmentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ESALabel
        '
        ESALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ESALabel.Location = New System.Drawing.Point(14, 37)
        ESALabel.Name = "ESALabel"
        ESALabel.Size = New System.Drawing.Size(68, 23)
        ESALabel.TabIndex = 0
        ESALabel.Text = "ESA No:"
        ESALabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpIDLabel
        '
        EmpIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        EmpIDLabel.Location = New System.Drawing.Point(148, 37)
        EmpIDLabel.Name = "EmpIDLabel"
        EmpIDLabel.Size = New System.Drawing.Size(52, 23)
        EmpIDLabel.TabIndex = 11
        EmpIDLabel.Text = "Card No:"
        EmpIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FNameLabel
        '
        FNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        FNameLabel.Location = New System.Drawing.Point(299, 37)
        FNameLabel.Name = "FNameLabel"
        FNameLabel.Size = New System.Drawing.Size(53, 23)
        FNameLabel.TabIndex = 12
        FNameLabel.Text = "Name:"
        FNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        DesigNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DesigNameLabel.Location = New System.Drawing.Point(516, 37)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(68, 23)
        DesigNameLabel.TabIndex = 13
        DesigNameLabel.Text = "Designation:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MonthlyObjectivesLabel
        '
        MonthlyObjectivesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        MonthlyObjectivesLabel.Location = New System.Drawing.Point(14, 69)
        MonthlyObjectivesLabel.Name = "MonthlyObjectivesLabel"
        MonthlyObjectivesLabel.Size = New System.Drawing.Size(68, 40)
        MonthlyObjectivesLabel.TabIndex = 14
        MonthlyObjectivesLabel.Text = "Monthly Objectives:"
        MonthlyObjectivesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PStatusLabel
        '
        PStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        PStatusLabel.Location = New System.Drawing.Point(14, 116)
        PStatusLabel.Name = "PStatusLabel"
        PStatusLabel.Size = New System.Drawing.Size(68, 32)
        PStatusLabel.TabIndex = 15
        PStatusLabel.Text = "Perform Status:"
        PStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReasonLabel
        '
        ReasonLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ReasonLabel.Location = New System.Drawing.Point(215, 116)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(68, 32)
        ReasonLabel.TabIndex = 16
        ReasonLabel.Text = "Reason:"
        ReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StartTimeLabel
        '
        StartTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        StartTimeLabel.Location = New System.Drawing.Point(215, 155)
        StartTimeLabel.Name = "StartTimeLabel"
        StartTimeLabel.Size = New System.Drawing.Size(68, 28)
        StartTimeLabel.TabIndex = 17
        StartTimeLabel.Text = "Start Date:"
        StartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EndTimeLabel
        '
        EndTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        EndTimeLabel.Location = New System.Drawing.Point(499, 155)
        EndTimeLabel.Name = "EndTimeLabel"
        EndTimeLabel.Size = New System.Drawing.Size(68, 28)
        EndTimeLabel.TabIndex = 18
        EndTimeLabel.Text = "End Time:"
        EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        EndTimeLabel.Visible = False
        '
        'AchievedLabel
        '
        AchievedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        AchievedLabel.Location = New System.Drawing.Point(14, 190)
        AchievedLabel.Name = "AchievedLabel"
        AchievedLabel.Size = New System.Drawing.Size(68, 32)
        AchievedLabel.TabIndex = 19
        AchievedLabel.Text = "If Achieve any Goal:"
        AchievedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EffectiveDateLabel
        '
        EffectiveDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        EffectiveDateLabel.Location = New System.Drawing.Point(14, 155)
        EffectiveDateLabel.Name = "EffectiveDateLabel"
        EffectiveDateLabel.Size = New System.Drawing.Size(68, 28)
        EffectiveDateLabel.TabIndex = 22
        EffectiveDateLabel.Text = "Effective Date:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1216, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Employee Self Assessment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(EffectiveDateLabel)
        Me.Panel1.Controls.Add(Me.EffectiveDateMaskedTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.MaskedTextBox2)
        Me.Panel1.Controls.Add(Me.MaskedTextBox1)
        Me.Panel1.Controls.Add(AchievedLabel)
        Me.Panel1.Controls.Add(Me.AchievedTextBox)
        Me.Panel1.Controls.Add(EndTimeLabel)
        Me.Panel1.Controls.Add(StartTimeLabel)
        Me.Panel1.Controls.Add(ReasonLabel)
        Me.Panel1.Controls.Add(Me.ReasonTextBox)
        Me.Panel1.Controls.Add(PStatusLabel)
        Me.Panel1.Controls.Add(Me.PStatusComboBox)
        Me.Panel1.Controls.Add(MonthlyObjectivesLabel)
        Me.Panel1.Controls.Add(Me.MonthlyObjectivesTextBox)
        Me.Panel1.Controls.Add(DesigNameLabel)
        Me.Panel1.Controls.Add(Me.DesigNameLabel1)
        Me.Panel1.Controls.Add(FNameLabel)
        Me.Panel1.Controls.Add(Me.FNameLabel1)
        Me.Panel1.Controls.Add(EmpIDLabel)
        Me.Panel1.Controls.Add(Me.EmpIDComboBox)
        Me.Panel1.Controls.Add(Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator)
        Me.Panel1.Controls.Add(ESALabel)
        Me.Panel1.Controls.Add(Me.ESALabel1)
        Me.Panel1.Location = New System.Drawing.Point(25, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(751, 231)
        Me.Panel1.TabIndex = 9
        '
        'EffectiveDateMaskedTextBox
        '
        Me.EffectiveDateMaskedTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.EffectiveDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "EffectiveDate", True))
        Me.EffectiveDateMaskedTextBox.Location = New System.Drawing.Point(88, 160)
        Me.EffectiveDateMaskedTextBox.Mask = "00/00/0000"
        Me.EffectiveDateMaskedTextBox.Name = "EffectiveDateMaskedTextBox"
        Me.EffectiveDateMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EffectiveDateMaskedTextBox.TabIndex = 23
        Me.EffectiveDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EffectiveDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Tbl_Hrm_EmpEval_Self_AssessmentBindingSource
        '
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource.DataMember = "tbl_Hrm_EmpEval_Self_Assessment"
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource.DataSource = Me.DSemployeeSelfAss
        '
        'DSemployeeSelfAss
        '
        Me.DSemployeeSelfAss.DataSetName = "DSemployeeSelfAss"
        Me.DSemployeeSelfAss.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(713, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Label2"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "EndTime", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(573, 160)
        Me.MaskedTextBox2.Mask = "00/00/0000 90:00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(154, 20)
        Me.MaskedTextBox2.TabIndex = 22
        Me.MaskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox2.ValidatingType = GetType(Date)
        Me.MaskedTextBox2.Visible = False
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "StartTime", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(291, 160)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.MaskedTextBox1.TabIndex = 21
        Me.MaskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'AchievedTextBox
        '
        Me.AchievedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "achieved", True))
        Me.AchievedTextBox.Location = New System.Drawing.Point(88, 190)
        Me.AchievedTextBox.Multiline = True
        Me.AchievedTextBox.Name = "AchievedTextBox"
        Me.AchievedTextBox.Size = New System.Drawing.Size(641, 32)
        Me.AchievedTextBox.TabIndex = 20
        '
        'ReasonTextBox
        '
        Me.ReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "Reason", True))
        Me.ReasonTextBox.Location = New System.Drawing.Point(291, 116)
        Me.ReasonTextBox.Multiline = True
        Me.ReasonTextBox.Name = "ReasonTextBox"
        Me.ReasonTextBox.Size = New System.Drawing.Size(438, 32)
        Me.ReasonTextBox.TabIndex = 17
        '
        'PStatusComboBox
        '
        Me.PStatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PStatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PStatusComboBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "PStatus", True))
        Me.PStatusComboBox.FormattingEnabled = True
        Me.PStatusComboBox.Items.AddRange(New Object() {"Acomplished", "Under process", "Not Accomplished"})
        Me.PStatusComboBox.Location = New System.Drawing.Point(88, 123)
        Me.PStatusComboBox.Name = "PStatusComboBox"
        Me.PStatusComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PStatusComboBox.TabIndex = 16
        '
        'MonthlyObjectivesTextBox
        '
        Me.MonthlyObjectivesTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MonthlyObjectivesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "MonthlyObjectives", True))
        Me.MonthlyObjectivesTextBox.Location = New System.Drawing.Point(88, 69)
        Me.MonthlyObjectivesTextBox.Multiline = True
        Me.MonthlyObjectivesTextBox.Name = "MonthlyObjectivesTextBox"
        Me.MonthlyObjectivesTextBox.Size = New System.Drawing.Size(641, 40)
        Me.MonthlyObjectivesTextBox.TabIndex = 15
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DesigName", True))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(588, 37)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(139, 23)
        Me.DesigNameLabel1.TabIndex = 14
        Me.DesigNameLabel1.Text = "Label2"
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_AllEmployeesBindingSource
        '
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataMember = "View_Rpt_Acc_AllEmployees"
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataSource = Me.DSemployeeSelfAss
        '
        'FNameLabel1
        '
        Me.FNameLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "FName", True))
        Me.FNameLabel1.Location = New System.Drawing.Point(357, 37)
        Me.FNameLabel1.Name = "FNameLabel1"
        Me.FNameLabel1.Size = New System.Drawing.Size(146, 23)
        Me.FNameLabel1.TabIndex = 13
        Me.FNameLabel1.Text = "Label2"
        Me.FNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpIDComboBox
        '
        Me.EmpIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EmpIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "EmpID", True))
        Me.EmpIDComboBox.DataSource = Me.View_Rpt_Acc_AllEmployeesBindingSource
        Me.EmpIDComboBox.DisplayMember = "CardNo"
        Me.EmpIDComboBox.FormattingEnabled = True
        Me.EmpIDComboBox.Location = New System.Drawing.Point(206, 37)
        Me.EmpIDComboBox.Name = "EmpIDComboBox"
        Me.EmpIDComboBox.Size = New System.Drawing.Size(83, 21)
        Me.EmpIDComboBox.TabIndex = 12
        Me.EmpIDComboBox.ValueMember = "EmpID"
        '
        'Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator
        '
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.BindingSource = Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem})
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.Name = "Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator"
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.Size = New System.Drawing.Size(749, 25)
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.TabIndex = 11
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem
        '
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem.Name = "Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem"
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ESALabel1
        '
        Me.ESALabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ESALabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ESALabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "ESA", True))
        Me.ESALabel1.Location = New System.Drawing.Point(88, 37)
        Me.ESALabel1.Name = "ESALabel1"
        Me.ESALabel1.Size = New System.Drawing.Size(50, 23)
        Me.ESALabel1.TabIndex = 1
        Me.ESALabel1.Text = "Label2"
        Me.ESALabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.View_EmpEval_Self_AssessmentDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(25, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 309)
        Me.Panel2.TabIndex = 10
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.View_EmpEval_Self_AssessmentBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1011, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'View_EmpEval_Self_AssessmentBindingSource
        '
        Me.View_EmpEval_Self_AssessmentBindingSource.DataMember = "View_EmpEval_Self_Assessment"
        Me.View_EmpEval_Self_AssessmentBindingSource.DataSource = Me.DSemployeeSelfAss
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'View_EmpEval_Self_AssessmentDataGridView
        '
        Me.View_EmpEval_Self_AssessmentDataGridView.AllowUserToAddRows = False
        Me.View_EmpEval_Self_AssessmentDataGridView.AllowUserToDeleteRows = False
        Me.View_EmpEval_Self_AssessmentDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_EmpEval_Self_AssessmentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_EmpEval_Self_AssessmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_EmpEval_Self_AssessmentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.View_EmpEval_Self_AssessmentDataGridView.DataSource = Me.View_EmpEval_Self_AssessmentBindingSource
        Me.View_EmpEval_Self_AssessmentDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.View_EmpEval_Self_AssessmentDataGridView.Name = "View_EmpEval_Self_AssessmentDataGridView"
        Me.View_EmpEval_Self_AssessmentDataGridView.ReadOnly = True
        Me.View_EmpEval_Self_AssessmentDataGridView.Size = New System.Drawing.Size(1005, 276)
        Me.View_EmpEval_Self_AssessmentDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ESA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ESA No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CardNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Card No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MonthlyObjectives"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Monthly Objectives"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PStatus"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Perform Status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Reason"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Reason"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "StartTime"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn7.HeaderText = "Start Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EndTime"
        Me.DataGridViewTextBoxColumn8.HeaderText = "EndTime"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 115
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "achieved"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Achieved"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "UploadBy"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Upload By"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter
        '
        Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Hrm_EmpEval_Self_AssessmentTableAdapter = Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSemployeeSelfAssTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_Rpt_Acc_AllEmployeesTableAdapter
        '
        Me.View_Rpt_Acc_AllEmployeesTableAdapter.ClearBeforeFill = True
        '
        'View_EmpEval_Self_AssessmentTableAdapter
        '
        Me.View_EmpEval_Self_AssessmentTableAdapter.ClearBeforeFill = True
        '
        'UserIDLabel1
        '
        Me.UserIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, "UserID", True))
        Me.UserIDLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.UserIDLabel1.Location = New System.Drawing.Point(745, 39)
        Me.UserIDLabel1.Name = "UserIDLabel1"
        Me.UserIDLabel1.Size = New System.Drawing.Size(31, 13)
        Me.UserIDLabel1.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Self-Assessment"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 32)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "•" & Global.Microsoft.VisualBasic.ChrW(9) & "The ability to self-assess is a valuable skill to  develop."
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 33)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "•" & Global.Microsoft.VisualBasic.ChrW(9) & "Self-assessment is a building block for setting goals and making positive chang" &
    "es."
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 54)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "•" & Global.Microsoft.VisualBasic.ChrW(9) & "Self-assessment can help you decide if you are doing alright. It doesn't have t" &
    "o be about change. It can be about affirming what you are already doing."
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(782, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(255, 230)
        Me.Panel3.TabIndex = 22
        '
        'frmSelfAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 629)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.UserIDLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSelfAssessment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSelfAssessment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSemployeeSelfAss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.ResumeLayout(False)
        Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_EmpEval_Self_AssessmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_EmpEval_Self_AssessmentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DSemployeeSelfAss As ERP_HRMS.DSemployeeSelfAss
    Friend WithEvents Tbl_Hrm_EmpEval_Self_AssessmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter As ERP_HRMS.DSemployeeSelfAssTableAdapters.tbl_Hrm_EmpEval_Self_AssessmentTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSemployeeSelfAssTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ESALabel1 As System.Windows.Forms.Label
    Friend WithEvents EmpIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReasonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PStatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MonthlyObjectivesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DesigNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents FNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents AchievedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents View_Rpt_Acc_AllEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployeesTableAdapter As ERP_HRMS.DSemployeeSelfAssTableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EffectiveDateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents View_EmpEval_Self_AssessmentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_EmpEval_Self_AssessmentTableAdapter As ERP_HRMS.DSemployeeSelfAssTableAdapters.View_EmpEval_Self_AssessmentTableAdapter
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents View_EmpEval_Self_AssessmentDataGridView As System.Windows.Forms.DataGridView
    'Friend WithEvents Clock1 As AnalogClock.Clock
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UserIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
