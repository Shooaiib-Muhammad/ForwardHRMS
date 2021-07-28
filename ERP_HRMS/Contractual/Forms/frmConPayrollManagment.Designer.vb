<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConPayrollManagment
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
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConPayrollManagment))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tbl_HRM_Shift1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPayRoll = New ERP_HRMS.DSPayRoll()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Tbl_Hrm_Emp_AttBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Hrm_Cont_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Hrm_Emp_AttBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Hrm_Cont_AttDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttDeviceNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_LongLeavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_ShortLeavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Leave_ReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.View_All_ContBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EmpStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CardNoComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.View_All_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_LongLeaves_SickBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_LongLeaves_CasualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_AttTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager()
        Me.View_All_EmployeesTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_All_EmployeesTableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_CardTableAdapter()
        Me.Tbl_HRM_Card1TableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_Card1TableAdapter()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.Tbl_PayRoll_LongLeavesTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_PayRoll_LongLeavesTableAdapter()
        Me.View_Rpt_PayRoll_PaidCasualSumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_PayRoll_PaidCasualSumTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_Rpt_PayRoll_PaidCasualSumTableAdapter()
        Me.View_Rpt_PayRoll_PaidMadicalSumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_PayRoll_PaidMadicalSumTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_Rpt_PayRoll_PaidMadicalSumTableAdapter()
        Me.Tbl_PayRoll_ShortLeavesTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_PayRoll_ShortLeavesTableAdapter()
        Me.Tbl_HRM_Leave_ReasonTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_Leave_ReasonTableAdapter()
        Me.Tbl_HRM_Card2TableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_Card2TableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tbl_HRM_Shift1TableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_Shift1TableAdapter()
        Me.AttEmpIDLabel = New System.Windows.Forms.Label()
        Me.Tbl_PayRoll_LongLeaves_CasualTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_PayRoll_LongLeaves_CasualTableAdapter()
        Me.Tbl_PayRoll_LongLeaves_SickTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_PayRoll_LongLeaves_SickTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Cont_AttTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Hrm_Cont_AttTableAdapter()
        Me.View_All_ContTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_All_ContTableAdapter()
        DeptNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CardNoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_HRM_Shift1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_AttBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Hrm_Emp_AttBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Hrm_Cont_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Cont_AttDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_ShortLeavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_All_ContBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves_SickBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeaves_CasualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_PayRoll_PaidCasualSumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_PayRoll_PaidMadicalSumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DeptNameLabel
        '
        DeptNameLabel.Location = New System.Drawing.Point(5, 51)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(66, 18)
        DeptNameLabel.TabIndex = 36
        DeptNameLabel.Text = "Department:"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        DesigNameLabel.Location = New System.Drawing.Point(5, 74)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(66, 18)
        DesigNameLabel.TabIndex = 34
        DesigNameLabel.Text = "Section:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel
        '
        NameLabel.Location = New System.Drawing.Point(5, 28)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(66, 18)
        NameLabel.TabIndex = 32
        NameLabel.Text = "Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel
        '
        CardNoLabel.Location = New System.Drawing.Point(5, 7)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(66, 18)
        CardNoLabel.TabIndex = 31
        CardNoLabel.Text = "Card No:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Label1.Location = New System.Drawing.Point(284, 7)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(70, 18)
        Label1.TabIndex = 25
        Label1.Text = "Emp Status:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.Location = New System.Drawing.Point(6, 90)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(61, 20)
        ShiftNameLabel.TabIndex = 50
        ShiftNameLabel.Text = "Shift:"
        '
        'Tbl_HRM_Shift1BindingSource
        '
        Me.Tbl_HRM_Shift1BindingSource.DataMember = "tbl_HRM_Shift1"
        Me.Tbl_HRM_Shift1BindingSource.DataSource = Me.DSPayRoll
        '
        'DSPayRoll
        '
        Me.DSPayRoll.DataSetName = "DSPayRoll"
        Me.DSPayRoll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Tbl_Hrm_Emp_AttBindingNavigator)
        Me.Panel8.Controls.Add(Me.Tbl_Hrm_Cont_AttDataGridView)
        Me.Panel8.Location = New System.Drawing.Point(3, 27)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1147, 494)
        Me.Panel8.TabIndex = 0
        '
        'Tbl_Hrm_Emp_AttBindingNavigator
        '
        Me.Tbl_Hrm_Emp_AttBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Hrm_Emp_AttBindingNavigator.BindingSource = Me.Tbl_Hrm_Cont_AttBindingSource
        Me.Tbl_Hrm_Emp_AttBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Hrm_Emp_AttBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Hrm_Emp_AttBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tbl_Hrm_Emp_AttBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_Hrm_Emp_AttBindingNavigatorSaveItem, Me.ToolStripSeparator7, Me.ToolStripButton14})
        Me.Tbl_Hrm_Emp_AttBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Hrm_Emp_AttBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Hrm_Emp_AttBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Hrm_Emp_AttBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Hrm_Emp_AttBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Hrm_Emp_AttBindingNavigator.Name = "Tbl_Hrm_Emp_AttBindingNavigator"
        Me.Tbl_Hrm_Emp_AttBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Hrm_Emp_AttBindingNavigator.Size = New System.Drawing.Size(1147, 27)
        Me.Tbl_Hrm_Emp_AttBindingNavigator.TabIndex = 13
        Me.Tbl_Hrm_Emp_AttBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Hrm_Cont_AttBindingSource
        '
        Me.Tbl_Hrm_Cont_AttBindingSource.DataMember = "tbl_Hrm_Cont_Att"
        Me.Tbl_Hrm_Cont_AttBindingSource.DataSource = Me.DSPayRoll
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'Tbl_Hrm_Emp_AttBindingNavigatorSaveItem
        '
        Me.Tbl_Hrm_Emp_AttBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Hrm_Emp_AttBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Hrm_Emp_AttBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Hrm_Emp_AttBindingNavigatorSaveItem.Name = "Tbl_Hrm_Emp_AttBindingNavigatorSaveItem"
        Me.Tbl_Hrm_Emp_AttBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.Tbl_Hrm_Emp_AttBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton14.Text = "Enter Log File to DB Attendance Transfer"
        '
        'Tbl_Hrm_Cont_AttDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tbl_Hrm_Cont_AttDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Hrm_Cont_AttDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Hrm_Cont_AttDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_Hrm_Cont_AttDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Hrm_Cont_AttDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewTextBoxColumn14, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.AttDeviceNo})
        Me.Tbl_Hrm_Cont_AttDataGridView.DataSource = Me.Tbl_Hrm_Cont_AttBindingSource
        Me.Tbl_Hrm_Cont_AttDataGridView.Location = New System.Drawing.Point(0, 29)
        Me.Tbl_Hrm_Cont_AttDataGridView.Name = "Tbl_Hrm_Cont_AttDataGridView"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Hrm_Cont_AttDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.Tbl_Hrm_Cont_AttDataGridView.Size = New System.Drawing.Size(1144, 461)
        Me.Tbl_Hrm_Cont_AttDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "AttID"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serial No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CardNo"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Card No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "AttDate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Attendence Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AttTime"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "g"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Attendence Time"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "OTStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "OTStatus"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "AttStatus"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Auto/Manual Status"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ShiftID"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn7.HeaderText = "Shift No."
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 55
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SystemIP"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "System IP"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ShiftST"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "t"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn9.HeaderText = "Start Time"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 80
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ShiftET"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "t"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn10.HeaderText = "End Time"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 80
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ShiftBST"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "t"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn11.HeaderText = "Brk Strt Time"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 80
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ShiftBET"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "t"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn12.HeaderText = "Brk End Time"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 80
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FinancialPeriod"
        Me.DataGridViewTextBoxColumn13.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.DataGridViewTextBoxColumn13.DisplayMember = "FinancialPeriod"
        Me.DataGridViewTextBoxColumn13.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn13.HeaderText = "FinancialPeriod"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn13.ValueMember = "FinancialPeriod"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSPayRoll
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "SpecialOTStatus"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "SpecialOTStatus"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "RecPostTime"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn14.HeaderText = "RecPostTime"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 120
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "SOTPayment"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "SOTPayment"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Narration"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Narration"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Ded"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Ded"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'AttDeviceNo
        '
        Me.AttDeviceNo.DataPropertyName = "AttDeviceNo"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.AttDeviceNo.DefaultCellStyle = DataGridViewCellStyle13
        Me.AttDeviceNo.HeaderText = "Device No"
        Me.AttDeviceNo.Name = "AttDeviceNo"
        Me.AttDeviceNo.ReadOnly = True
        Me.AttDeviceNo.Width = 65
        '
        'Tbl_Hrm_Emp_AttBindingSource
        '
        Me.Tbl_Hrm_Emp_AttBindingSource.DataMember = "tbl_Hrm_Emp_Att"
        Me.Tbl_Hrm_Emp_AttBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_PayRoll_LongLeavesBindingSource
        '
        Me.Tbl_PayRoll_LongLeavesBindingSource.DataMember = "tbl_PayRoll_LongLeaves"
        Me.Tbl_PayRoll_LongLeavesBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_Card2BindingSource
        '
        Me.Tbl_HRM_Card2BindingSource.DataMember = "tbl_HRM_Card2"
        Me.Tbl_HRM_Card2BindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_PayRoll_ShortLeavesBindingSource
        '
        Me.Tbl_PayRoll_ShortLeavesBindingSource.DataMember = "tbl_PayRoll_ShortLeaves"
        Me.Tbl_PayRoll_ShortLeavesBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_Leave_ReasonBindingSource
        '
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataMember = "tbl_HRM_Leave_Reason"
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_Card1BindingSource
        '
        Me.Tbl_HRM_Card1BindingSource.DataMember = "tbl_HRM_Card1"
        Me.Tbl_HRM_Card1BindingSource.DataSource = Me.DSPayRoll
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(5, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1156, 161)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.View_All_ContBindingSource, "EmpPic", True))
        Me.PictureBox1.Location = New System.Drawing.Point(1032, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'View_All_ContBindingSource
        '
        Me.View_All_ContBindingSource.DataMember = "View_All_Cont"
        Me.View_All_ContBindingSource.DataSource = Me.DSPayRoll
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Label1)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.EmpStatusCheckBox)
        Me.Panel6.Controls.Add(Me.NameLabel1)
        Me.Panel6.Controls.Add(DesigNameLabel)
        Me.Panel6.Controls.Add(DeptNameLabel)
        Me.Panel6.Controls.Add(Me.CardNoLabel1)
        Me.Panel6.Controls.Add(CardNoLabel)
        Me.Panel6.Controls.Add(Me.DeptNameLabel1)
        Me.Panel6.Controls.Add(NameLabel)
        Me.Panel6.Controls.Add(Me.DesigNameLabel1)
        Me.Panel6.Location = New System.Drawing.Point(632, 32)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(396, 122)
        Me.Panel6.TabIndex = 42
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_ContBindingSource, "GradeName", True))
        Me.Label20.Location = New System.Drawing.Point(214, 7)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 18)
        Me.Label20.TabIndex = 45
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(147, 5)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 20)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Grade:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(252, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 20)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "D.O.J:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_ContBindingSource, "DateOfJoning", True))
        Me.Label16.Location = New System.Drawing.Point(293, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 20)
        Me.Label16.TabIndex = 42
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(5, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Designation:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_ContBindingSource, "DesigName", True))
        Me.Label13.Location = New System.Drawing.Point(73, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 20)
        Me.Label13.TabIndex = 40
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpStatusCheckBox
        '
        Me.EmpStatusCheckBox.AutoCheck = False
        Me.EmpStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.View_All_ContBindingSource, "EmpStatus", True))
        Me.EmpStatusCheckBox.Location = New System.Drawing.Point(355, 9)
        Me.EmpStatusCheckBox.Name = "EmpStatusCheckBox"
        Me.EmpStatusCheckBox.Size = New System.Drawing.Size(17, 17)
        Me.EmpStatusCheckBox.TabIndex = 26
        '
        'NameLabel1
        '
        Me.NameLabel1.BackColor = System.Drawing.Color.White
        Me.NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_ContBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(73, 28)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(309, 20)
        Me.NameLabel1.TabIndex = 35
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.BackColor = System.Drawing.Color.White
        Me.CardNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_ContBindingSource, "CardNo", True))
        Me.CardNoLabel1.Location = New System.Drawing.Point(73, 7)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(60, 18)
        Me.CardNoLabel1.TabIndex = 33
        Me.CardNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_ContBindingSource, "SectionName", True))
        Me.DeptNameLabel1.Location = New System.Drawing.Point(73, 74)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(309, 20)
        Me.DeptNameLabel1.TabIndex = 38
        Me.DeptNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.Color.White
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_All_ContBindingSource, "DeptName", True))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(73, 51)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(309, 20)
        Me.DesigNameLabel1.TabIndex = 37
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ShiftNameComboBox)
        Me.Panel4.Controls.Add(ShiftNameLabel)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.DateTimePicker2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.CardNoComboBox1)
        Me.Panel4.Controls.Add(Me.CardNoComboBox)
        Me.Panel4.Controls.Add(Me.DateTimePicker1)
        Me.Panel4.Location = New System.Drawing.Point(185, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(442, 124)
        Me.Panel4.TabIndex = 41
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.DataSource = Me.Tbl_HRM_Shift1BindingSource
        Me.ShiftNameComboBox.DisplayMember = "ShiftName"
        Me.ShiftNameComboBox.Enabled = False
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(74, 85)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(357, 21)
        Me.ShiftNameComboBox.TabIndex = 51
        Me.ShiftNameComboBox.ValueMember = "ShiftID"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "From Card:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "From Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(289, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker2.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(225, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "To Date:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(225, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "To Card:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoComboBox1
        '
        Me.CardNoComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox1.DataSource = Me.Tbl_HRM_Card1BindingSource
        Me.CardNoComboBox1.DisplayMember = "CardNo"
        Me.CardNoComboBox1.FormattingEnabled = True
        Me.CardNoComboBox1.Location = New System.Drawing.Point(289, 45)
        Me.CardNoComboBox1.Name = "CardNoComboBox1"
        Me.CardNoComboBox1.Size = New System.Drawing.Size(142, 21)
        Me.CardNoComboBox1.TabIndex = 40
        Me.CardNoComboBox1.ValueMember = "CardNo"
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.Tbl_HRM_CardBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(74, 46)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(142, 21)
        Me.CardNoComboBox.TabIndex = 39
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(74, 7)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker1.TabIndex = 41
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1154, 25)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Select Appropriate Option to Filter Records"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.RadioButton5)
        Me.Panel5.Controls.Add(Me.RadioButton1)
        Me.Panel5.Controls.Add(Me.RadioButton2)
        Me.Panel5.Controls.Add(Me.RadioButton3)
        Me.Panel5.Controls.Add(Me.RadioButton6)
        Me.Panel5.Location = New System.Drawing.Point(4, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 124)
        Me.Panel5.TabIndex = 40
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(12, 76)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(143, 17)
        Me.RadioButton5.TabIndex = 43
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "By Shift and Date Range"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 7)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(95, 17)
        Me.RadioButton1.TabIndex = 40
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "By Single Date"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 99)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton2.TabIndex = 41
        Me.RadioButton2.Text = "By Date Range"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(12, 30)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(144, 17)
        Me.RadioButton3.TabIndex = 42
        Me.RadioButton3.Text = "By Card and Date Range"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(12, 53)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(144, 17)
        Me.RadioButton6.TabIndex = 39
        Me.RadioButton6.Text = "By Single Card and Date "
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'View_All_EmployeesBindingSource
        '
        Me.View_All_EmployeesBindingSource.DataMember = "View_All_Employees"
        Me.View_All_EmployeesBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_PayRoll_LongLeaves_SickBindingSource
        '
        Me.Tbl_PayRoll_LongLeaves_SickBindingSource.DataMember = "tbl_PayRoll_LongLeaves_Sick"
        Me.Tbl_PayRoll_LongLeaves_SickBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_PayRoll_LongLeaves_CasualBindingSource
        '
        Me.Tbl_PayRoll_LongLeaves_CasualBindingSource.DataMember = "tbl_PayRoll_LongLeaves_Casual"
        Me.Tbl_PayRoll_LongLeaves_CasualBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSPayRoll
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 638)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "From Time:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(4, 671)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(107, 20)
        Me.DateTimePicker3.TabIndex = 43
        Me.DateTimePicker3.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(220, 704)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "To Time:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Visible = False
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CustomFormat = "dd/MM/yyyy hh:mm tt"
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(284, 704)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker4.TabIndex = 44
        Me.DateTimePicker4.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1303, 39)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Contractual Payroll Management"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Hrm_Emp_AttTableAdapter
        '
        Me.Tbl_Hrm_Emp_AttTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_AnnualLeaveTransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Att_DeviceSpecialTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Att_DeviceTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Cont_AttTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_AttTableAdapter = Me.Tbl_Hrm_Emp_AttTableAdapter
        Me.TableAdapterManager.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Shift1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PayRoll_LongLeavesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PayRoll_ShortLeavesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_All_EmployeesTableAdapter
        '
        Me.View_All_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Card1TableAdapter
        '
        Me.Tbl_HRM_Card1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_ShiftTableAdapter
        '
        Me.Tbl_HRM_ShiftTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeavesTableAdapter
        '
        Me.Tbl_PayRoll_LongLeavesTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_PayRoll_PaidCasualSumBindingSource
        '
        Me.View_Rpt_PayRoll_PaidCasualSumBindingSource.DataSource = Me.DSPayRoll
        Me.View_Rpt_PayRoll_PaidCasualSumBindingSource.Position = 0
        '
        'View_Rpt_PayRoll_PaidCasualSumTableAdapter
        '
        Me.View_Rpt_PayRoll_PaidCasualSumTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_PayRoll_PaidMadicalSumBindingSource
        '
        Me.View_Rpt_PayRoll_PaidMadicalSumBindingSource.DataSource = Me.DSPayRoll
        Me.View_Rpt_PayRoll_PaidMadicalSumBindingSource.Position = 0
        '
        'View_Rpt_PayRoll_PaidMadicalSumTableAdapter
        '
        Me.View_Rpt_PayRoll_PaidMadicalSumTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_ShortLeavesTableAdapter
        '
        Me.Tbl_PayRoll_ShortLeavesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Leave_ReasonTableAdapter
        '
        Me.Tbl_HRM_Leave_ReasonTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Card2TableAdapter
        '
        Me.Tbl_HRM_Card2TableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Shift1TableAdapter
        '
        Me.Tbl_HRM_Shift1TableAdapter.ClearBeforeFill = True
        '
        'AttEmpIDLabel
        '
        Me.AttEmpIDLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_AttBindingSource, "EmpID", True))
        Me.AttEmpIDLabel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AttEmpIDLabel.Location = New System.Drawing.Point(21, 359)
        Me.AttEmpIDLabel.Name = "AttEmpIDLabel"
        Me.AttEmpIDLabel.Size = New System.Drawing.Size(100, 23)
        Me.AttEmpIDLabel.TabIndex = 51
        Me.AttEmpIDLabel.Text = "Label16"
        '
        'Tbl_PayRoll_LongLeaves_CasualTableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves_CasualTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LongLeaves_SickTableAdapter
        '
        Me.Tbl_PayRoll_LongLeaves_SickTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Location = New System.Drawing.Point(4, 206)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1156, 526)
        Me.Panel2.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1154, 25)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Mannual Attendance"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Hrm_Cont_AttTableAdapter
        '
        Me.Tbl_Hrm_Cont_AttTableAdapter.ClearBeforeFill = True
        '
        'View_All_ContTableAdapter
        '
        Me.View_All_ContTableAdapter.ClearBeforeFill = True
        '
        'frmConPayrollManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1303, 885)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.AttEmpIDLabel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Name = "frmConPayrollManagment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Payroll Management"
        CType(Me.Tbl_HRM_Shift1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.Tbl_Hrm_Emp_AttBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Hrm_Emp_AttBindingNavigator.ResumeLayout(False)
        Me.Tbl_Hrm_Emp_AttBindingNavigator.PerformLayout()
        CType(Me.Tbl_Hrm_Cont_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Cont_AttDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_ShortLeavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_All_ContBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves_SickBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeaves_CasualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_PayRoll_PaidCasualSumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_PayRoll_PaidMadicalSumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents EmpStatusCheckBox As CheckBox
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents CardNoLabel1 As Label
    Friend WithEvents DeptNameLabel1 As Label
    Friend WithEvents DesigNameLabel1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CardNoComboBox1 As ComboBox
    Friend WithEvents CardNoComboBox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents DSPayRoll As DSPayRoll
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents TableAdapterManager As DSPayRollTableAdapters.TableAdapterManager
    Friend WithEvents View_All_EmployeesBindingSource As BindingSource
    Friend WithEvents View_All_EmployeesTableAdapter As DSPayRollTableAdapters.View_All_EmployeesTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSPayRollTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSPayRollTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents Tbl_HRM_Card1BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card1TableAdapter As DSPayRollTableAdapters.tbl_HRM_Card1TableAdapter
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSPayRollTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn10 As DataGridViewCheckBoxColumn
    Friend WithEvents Tbl_PayRoll_LongLeavesBindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeavesTableAdapter As DSPayRollTableAdapters.tbl_PayRoll_LongLeavesTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents View_Rpt_PayRoll_PaidCasualSumBindingSource As BindingSource
    Friend WithEvents View_Rpt_PayRoll_PaidCasualSumTableAdapter As DSPayRollTableAdapters.View_Rpt_PayRoll_PaidCasualSumTableAdapter
    Friend WithEvents View_Rpt_PayRoll_PaidMadicalSumBindingSource As BindingSource
    Friend WithEvents View_Rpt_PayRoll_PaidMadicalSumTableAdapter As DSPayRollTableAdapters.View_Rpt_PayRoll_PaidMadicalSumTableAdapter
    Friend WithEvents Tbl_PayRoll_ShortLeavesBindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_ShortLeavesTableAdapter As DSPayRollTableAdapters.tbl_PayRoll_ShortLeavesTableAdapter
    Friend WithEvents Tbl_HRM_Leave_ReasonBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Leave_ReasonTableAdapter As DSPayRollTableAdapters.tbl_HRM_Leave_ReasonTableAdapter
    Friend WithEvents Tbl_HRM_Card2BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card2TableAdapter As DSPayRollTableAdapters.tbl_HRM_Card2TableAdapter
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Tbl_HRM_Shift1BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Shift1TableAdapter As DSPayRollTableAdapters.tbl_HRM_Shift1TableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents AttEmpIDLabel As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Tbl_PayRoll_LongLeaves_CasualBindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves_CasualTableAdapter As DSPayRollTableAdapters.tbl_PayRoll_LongLeaves_CasualTableAdapter
    Friend WithEvents Tbl_PayRoll_LongLeaves_SickBindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeaves_SickTableAdapter As DSPayRollTableAdapters.tbl_PayRoll_LongLeaves_SickTableAdapter
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Tbl_Hrm_Emp_AttBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_Hrm_Emp_AttBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents Tbl_Hrm_Cont_AttDataGridView As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Tbl_Hrm_Cont_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Cont_AttTableAdapter As DSPayRollTableAdapters.tbl_Hrm_Cont_AttTableAdapter
    Friend WithEvents View_All_ContBindingSource As BindingSource
    Friend WithEvents View_All_ContTableAdapter As DSPayRollTableAdapters.View_All_ContTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents AttDeviceNo As DataGridViewTextBoxColumn
End Class
