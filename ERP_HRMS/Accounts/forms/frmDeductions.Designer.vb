<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeductions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim EmpStatusLabel As System.Windows.Forms.Label
        Dim AdvSumLabel As System.Windows.Forms.Label
        Dim TotalDedLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeductions))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Acc_PAdvDeductionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSLongTermAdv = New ERP_HRMS.DSLongTermAdv()
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
        Me.Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Acc_PAdvDeductionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tbl_Hrm_Emp_Info_H2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_H1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_PAdvLedgerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.View_Rpt_Acc_AllEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TotalDedLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_PAdvDeductions1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdvSumLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_PermanentAdvances1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EmpStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_AllEmployeesTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_PAdvDeductionsTableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductionsTableAdapter()
        Me.Tbl_Acc_PermanentAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_PermanentAdvancesTableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PermanentAdvancesTableAdapter()
        Me.View_Rpt_Acc_PAdvLedgerTableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.View_Rpt_Acc_PAdvLedgerTableAdapter()
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Hrm_Emp_Info_H1TableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_Hrm_Emp_Info_H2TableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Hrm_Emp_Info_H2TableAdapter()
        Me.Tbl_Acc_PAdvDeductions1TableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductions1TableAdapter()
        Me.Tbl_Acc_PermanentAdvances1TableAdapter = New ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PermanentAdvances1TableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinancialPeriod = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CardNoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        EmpStatusLabel = New System.Windows.Forms.Label()
        AdvSumLabel = New System.Windows.Forms.Label()
        TotalDedLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSLongTermAdv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PAdvDeductionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_H2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_PAdvLedgerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PAdvDeductions1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PermanentAdvances1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Tbl_Acc_PermanentAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CardNoLabel
        '
        CardNoLabel.Location = New System.Drawing.Point(15, 34)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(70, 20)
        CardNoLabel.TabIndex = 1
        CardNoLabel.Text = "Card No:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel
        '
        NameLabel.Location = New System.Drawing.Point(15, 57)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(70, 20)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        DesigNameLabel.Location = New System.Drawing.Point(15, 80)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(70, 20)
        DesigNameLabel.TabIndex = 5
        DesigNameLabel.Text = "Designation:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptNameLabel
        '
        DeptNameLabel.Location = New System.Drawing.Point(15, 105)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(70, 20)
        DeptNameLabel.TabIndex = 7
        DeptNameLabel.Text = "Department:"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpStatusLabel
        '
        EmpStatusLabel.Location = New System.Drawing.Point(273, 34)
        EmpStatusLabel.Name = "EmpStatusLabel"
        EmpStatusLabel.Size = New System.Drawing.Size(70, 20)
        EmpStatusLabel.TabIndex = 8
        EmpStatusLabel.Text = "Emp Status:"
        EmpStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvSumLabel
        '
        AdvSumLabel.Location = New System.Drawing.Point(273, 57)
        AdvSumLabel.Name = "AdvSumLabel"
        AdvSumLabel.Size = New System.Drawing.Size(80, 20)
        AdvSumLabel.TabIndex = 25
        AdvSumLabel.Text = "Total Advance:"
        AdvSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalDedLabel
        '
        TotalDedLabel.Location = New System.Drawing.Point(273, 80)
        TotalDedLabel.Name = "TotalDedLabel"
        TotalDedLabel.Size = New System.Drawing.Size(80, 20)
        TotalDedLabel.TabIndex = 26
        TotalDedLabel.Text = "Deducted:"
        TotalDedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Label9.Location = New System.Drawing.Point(273, 105)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(80, 20)
        Label9.TabIndex = 28
        Label9.Text = "Balance:"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1196, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Permanent Advance Deductions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Tbl_Acc_PAdvDeductionsBindingNavigator)
        Me.Panel2.Controls.Add(Me.Tbl_Acc_PAdvDeductionsDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(14, 188)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1092, 479)
        Me.Panel2.TabIndex = 11
        '
        'Tbl_Acc_PAdvDeductionsBindingNavigator
        '
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.BindingSource = Me.Tbl_Acc_PAdvDeductionsBindingSource
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem})
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.Name = "Tbl_Acc_PAdvDeductionsBindingNavigator"
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.Size = New System.Drawing.Size(1090, 27)
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.TabIndex = 12
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Tbl_Acc_PAdvDeductionsBindingSource
        '
        Me.Tbl_Acc_PAdvDeductionsBindingSource.DataMember = "tbl_Acc_PAdvDeductions"
        Me.Tbl_Acc_PAdvDeductionsBindingSource.DataSource = Me.DSLongTermAdv
        '
        'DSLongTermAdv
        '
        Me.DSLongTermAdv.DataSetName = "DSLongTermAdv"
        Me.DSLongTermAdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem
        '
        Me.Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem.Name = "Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem"
        Me.Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_Acc_PAdvDeductionsDataGridView
        '
        Me.Tbl_Acc_PAdvDeductionsDataGridView.AllowUserToAddRows = False
        Me.Tbl_Acc_PAdvDeductionsDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Acc_PAdvDeductionsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Acc_PAdvDeductionsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Acc_PAdvDeductionsDataGridView.ColumnHeadersHeight = 46
        Me.Tbl_Acc_PAdvDeductionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.FinancialPeriod, Me.DataGridViewTextBoxColumn6})
        Me.Tbl_Acc_PAdvDeductionsDataGridView.DataSource = Me.Tbl_Acc_PAdvDeductionsBindingSource
        Me.Tbl_Acc_PAdvDeductionsDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_Acc_PAdvDeductionsDataGridView.Name = "Tbl_Acc_PAdvDeductionsDataGridView"
        Me.Tbl_Acc_PAdvDeductionsDataGridView.RowHeadersWidth = 22
        Me.Tbl_Acc_PAdvDeductionsDataGridView.Size = New System.Drawing.Size(1084, 446)
        Me.Tbl_Acc_PAdvDeductionsDataGridView.TabIndex = 7
        '
        'Tbl_Hrm_Emp_Info_H2BindingSource
        '
        Me.Tbl_Hrm_Emp_Info_H2BindingSource.DataMember = "tbl_Hrm_Emp_Info_H2"
        Me.Tbl_Hrm_Emp_Info_H2BindingSource.DataSource = Me.HRMDBDataSet1
        '
        'HRMDBDataSet1
        '
        Me.HRMDBDataSet1.DataSetName = "HRMDBDataSet1"
        Me.HRMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.HRMDBDataSet1
        '
        'Tbl_Hrm_Emp_Info_H1BindingSource
        '
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataMember = "tbl_Hrm_Emp_Info_H1"
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataSource = Me.HRMDBDataSet1
        '
        'View_Rpt_Acc_PAdvLedgerBindingSource
        '
        Me.View_Rpt_Acc_PAdvLedgerBindingSource.DataMember = "View_Rpt_Acc_PAdvLedger"
        Me.View_Rpt_Acc_PAdvLedgerBindingSource.DataSource = Me.DSLongTermAdv
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(TotalDedLabel)
        Me.Panel1.Controls.Add(Me.TotalDedLabel1)
        Me.Panel1.Controls.Add(AdvSumLabel)
        Me.Panel1.Controls.Add(Me.AdvSumLabel1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(EmpStatusLabel)
        Me.Panel1.Controls.Add(Me.EmpStatusCheckBox)
        Me.Panel1.Controls.Add(DeptNameLabel)
        Me.Panel1.Controls.Add(Me.DeptNameLabel1)
        Me.Panel1.Controls.Add(DesigNameLabel)
        Me.Panel1.Controls.Add(Me.DesigNameLabel1)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.NameLabel1)
        Me.Panel1.Controls.Add(CardNoLabel)
        Me.Panel1.Controls.Add(Me.CardNoLabel1)
        Me.Panel1.Location = New System.Drawing.Point(558, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 138)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.View_Rpt_Acc_AllEmployeesBindingSource, "EmpPic", True))
        Me.PictureBox1.Location = New System.Drawing.Point(455, 32)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'View_Rpt_Acc_AllEmployeesBindingSource
        '
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataMember = "View_Rpt_Acc_AllEmployees"
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataSource = Me.HRMDBDataSet1
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(356, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 29
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalDedLabel1
        '
        Me.TotalDedLabel1.BackColor = System.Drawing.Color.White
        Me.TotalDedLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalDedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_PAdvDeductions1BindingSource, "TotalDed", True))
        Me.TotalDedLabel1.Location = New System.Drawing.Point(356, 80)
        Me.TotalDedLabel1.Name = "TotalDedLabel1"
        Me.TotalDedLabel1.Size = New System.Drawing.Size(88, 20)
        Me.TotalDedLabel1.TabIndex = 27
        Me.TotalDedLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_PAdvDeductions1BindingSource
        '
        Me.Tbl_Acc_PAdvDeductions1BindingSource.DataMember = "tbl_Acc_PAdvDeductions1"
        Me.Tbl_Acc_PAdvDeductions1BindingSource.DataSource = Me.DSLongTermAdv
        '
        'AdvSumLabel1
        '
        Me.AdvSumLabel1.BackColor = System.Drawing.Color.White
        Me.AdvSumLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AdvSumLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_PermanentAdvances1BindingSource, "AdvSum", True))
        Me.AdvSumLabel1.Location = New System.Drawing.Point(356, 57)
        Me.AdvSumLabel1.Name = "AdvSumLabel1"
        Me.AdvSumLabel1.Size = New System.Drawing.Size(88, 20)
        Me.AdvSumLabel1.TabIndex = 26
        Me.AdvSumLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_PermanentAdvances1BindingSource
        '
        Me.Tbl_Acc_PermanentAdvances1BindingSource.DataMember = "tbl_Acc_PermanentAdvances1"
        Me.Tbl_Acc_PermanentAdvances1BindingSource.DataSource = Me.DSLongTermAdv
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(546, 25)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Employee Bio Data"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpStatusCheckBox
        '
        Me.EmpStatusCheckBox.AutoCheck = False
        Me.EmpStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.View_Rpt_Acc_AllEmployeesBindingSource, "EmpStatus", True))
        Me.EmpStatusCheckBox.Location = New System.Drawing.Point(356, 37)
        Me.EmpStatusCheckBox.Name = "EmpStatusCheckBox"
        Me.EmpStatusCheckBox.Size = New System.Drawing.Size(16, 16)
        Me.EmpStatusCheckBox.TabIndex = 9
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DeptName", True))
        Me.DeptNameLabel1.Location = New System.Drawing.Point(91, 105)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(176, 20)
        Me.DeptNameLabel1.TabIndex = 8
        Me.DeptNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.Color.White
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DesigName", True))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(91, 80)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(176, 20)
        Me.DesigNameLabel1.TabIndex = 6
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel1
        '
        Me.NameLabel1.BackColor = System.Drawing.Color.White
        Me.NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(91, 57)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(176, 20)
        Me.NameLabel1.TabIndex = 4
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.BackColor = System.Drawing.Color.White
        Me.CardNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "CardNo", True))
        Me.CardNoLabel1.Location = New System.Drawing.Point(91, 34)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(78, 20)
        Me.CardNoLabel1.TabIndex = 2
        Me.CardNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_AllEmployeesTableAdapter
        '
        Me.View_Rpt_Acc_AllEmployeesTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.RadioButton10)
        Me.Panel3.Controls.Add(Me.RadioButton9)
        Me.Panel3.Controls.Add(Me.RadioButton8)
        Me.Panel3.Controls.Add(Me.RadioButton7)
        Me.Panel3.Controls.Add(Me.RadioButton6)
        Me.Panel3.Controls.Add(Me.RadioButton5)
        Me.Panel3.Controls.Add(Me.RadioButton4)
        Me.Panel3.Controls.Add(Me.RadioButton3)
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(13, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(147, 134)
        Me.Panel3.TabIndex = 13
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.Indigo
        Me.RadioButton10.Location = New System.Drawing.Point(186, 151)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton10.TabIndex = 10
        Me.RadioButton10.Text = "By Other Descriptions"
        Me.RadioButton10.UseVisualStyleBackColor = True
        Me.RadioButton10.Visible = False
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Indigo
        Me.RadioButton9.Location = New System.Drawing.Point(186, 128)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(258, 17)
        Me.RadioButton9.TabIndex = 9
        Me.RadioButton9.Text = "By Description LIKE 'Zero Deduction From Salary'"
        Me.RadioButton9.UseVisualStyleBackColor = True
        Me.RadioButton9.Visible = False
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Indigo
        Me.RadioButton8.Location = New System.Drawing.Point(223, 105)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(246, 17)
        Me.RadioButton8.TabIndex = 8
        Me.RadioButton8.Text = "By Description LIKE 'Deduction Against Bonus'"
        Me.RadioButton8.UseVisualStyleBackColor = True
        Me.RadioButton8.Visible = False
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Indigo
        Me.RadioButton7.Location = New System.Drawing.Point(223, 82)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(275, 17)
        Me.RadioButton7.TabIndex = 7
        Me.RadioButton7.Text = "By Description LIKE 'Deduction From Annual Leaves'"
        Me.RadioButton7.UseVisualStyleBackColor = True
        Me.RadioButton7.Visible = False
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Indigo
        Me.RadioButton6.Location = New System.Drawing.Point(223, 59)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(160, 17)
        Me.RadioButton6.TabIndex = 6
        Me.RadioButton6.Text = "By Description LIKE 'Closing'"
        Me.RadioButton6.UseVisualStyleBackColor = True
        Me.RadioButton6.Visible = False
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Indigo
        Me.RadioButton5.Location = New System.Drawing.Point(223, 36)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(269, 17)
        Me.RadioButton5.TabIndex = 5
        Me.RadioButton5.Text = "By Description LIKE 'Normal Deduction From Salary'"
        Me.RadioButton5.UseVisualStyleBackColor = True
        Me.RadioButton5.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton4.Location = New System.Drawing.Point(10, 102)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.Text = "By Financial Period"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton3.Location = New System.Drawing.Point(10, 80)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(122, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.Text = "By Transaction Date"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton2.Location = New System.Drawing.Point(10, 57)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.Text = "By Card No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Navy
        Me.RadioButton1.Location = New System.Drawing.Point(10, 33)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "All Records"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 25)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Filter Options"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_PAdvDeductionsTableAdapter
        '
        Me.Tbl_Acc_PAdvDeductionsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_PermanentAdvancesBindingSource
        '
        Me.Tbl_Acc_PermanentAdvancesBindingSource.DataMember = "tbl_Acc_PermanentAdvances"
        Me.Tbl_Acc_PermanentAdvancesBindingSource.DataSource = Me.DSLongTermAdv
        '
        'Tbl_Acc_PermanentAdvancesTableAdapter
        '
        Me.Tbl_Acc_PermanentAdvancesTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_PAdvLedgerTableAdapter
        '
        Me.View_Rpt_Acc_PAdvLedgerTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_H1TableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_H2TableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_H2TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_PAdvDeductions1TableAdapter
        '
        Me.Tbl_Acc_PAdvDeductions1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_PermanentAdvances1TableAdapter
        '
        Me.Tbl_Acc_PermanentAdvances1TableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Filter Information"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.Tbl_Hrm_Emp_Info_H1BindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(100, 80)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(178, 21)
        Me.CardNoComboBox.TabIndex = 11
        Me.CardNoComboBox.ValueMember = "EmpID"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Select CardNo:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(100, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "From Date:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.FinancialPeriodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(100, 55)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(178, 21)
        Me.FinancialPeriodComboBox.TabIndex = 12
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(267, 32)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(207, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "To Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Financial Period:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Normal Deduction From Salary", "Closing", "Deduction From Annual Leaves", "Deduction Against Bonus", "Zero Deduction From Salary"})
        Me.ComboBox1.Location = New System.Drawing.Point(100, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "By Description:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.DateTimePicker2)
        Me.Panel4.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.CardNoComboBox)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(164, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(392, 136)
        Me.Panel4.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DedID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serial No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.Tbl_Hrm_Emp_Info_H2BindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.DisplayMember = "CardNo"
        Me.DataGridViewTextBoxColumn2.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Card No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "EmpID"
        Me.DataGridViewTextBoxColumn2.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DedAmount"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Deduction Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 90
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TransactionDate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Transaction Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'FinancialPeriod
        '
        Me.FinancialPeriod.DataPropertyName = "FinancialPeriod"
        Me.FinancialPeriod.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FinancialPeriod.DefaultCellStyle = DataGridViewCellStyle6
        Me.FinancialPeriod.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriod.DisplayStyleForCurrentCellOnly = True
        Me.FinancialPeriod.HeaderText = "Financial Period"
        Me.FinancialPeriod.Name = "FinancialPeriod"
        Me.FinancialPeriod.ReadOnly = True
        Me.FinancialPeriod.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FinancialPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FinancialPeriod.ValueMember = "FinancialPeriod"
        Me.FinancialPeriod.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 450
        '
        'frmDeductions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1196, 733)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDeductions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Deductions"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.ResumeLayout(False)
        Me.Tbl_Acc_PAdvDeductionsBindingNavigator.PerformLayout()
        CType(Me.Tbl_Acc_PAdvDeductionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSLongTermAdv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PAdvDeductionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_H2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_PAdvLedgerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PAdvDeductions1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PermanentAdvances1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Tbl_Acc_PermanentAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DSLongTermAdv As ERP_HRMS.DSLongTermAdv
    Friend WithEvents Tbl_Acc_PAdvDeductionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PAdvDeductionsTableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductionsTableAdapter
    Friend WithEvents Tbl_Acc_PAdvDeductionsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Acc_PAdvDeductionsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Tbl_Acc_PermanentAdvancesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PermanentAdvancesTableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PermanentAdvancesTableAdapter
    Friend WithEvents View_Rpt_Acc_PAdvLedgerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_PAdvLedgerTableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.View_Rpt_Acc_PAdvLedgerTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HRMDBDataSet1 As ERP_HRMS.HRMDBDataset1
    Friend WithEvents View_Rpt_Acc_AllEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployeesTableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter
    Friend WithEvents DeptNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DesigNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents CardNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents EmpStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AdvSumLabel1 As System.Windows.Forms.Label
    Friend WithEvents TotalDedLabel1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_Hrm_Emp_Info_H1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_H1TableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Hrm_Emp_Info_H1TableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_Hrm_Emp_Info_H2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_H2TableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.tbl_Hrm_Emp_Info_H2TableAdapter
    Friend WithEvents Tbl_Acc_PAdvDeductions1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PAdvDeductions1TableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PAdvDeductions1TableAdapter
    Friend WithEvents Tbl_Acc_PermanentAdvances1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_PermanentAdvances1TableAdapter As ERP_HRMS.DSLongTermAdvTableAdapters.tbl_Acc_PermanentAdvances1TableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents CardNoComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents FinancialPeriodComboBox As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents FinancialPeriod As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
