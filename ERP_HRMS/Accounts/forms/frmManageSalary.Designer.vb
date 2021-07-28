<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageSalary
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
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim NICLabel As System.Windows.Forms.Label
        Dim CardStatusLabel As System.Windows.Forms.Label
        Dim EmpStatusLabel As System.Windows.Forms.Label
        Dim GradeIDLabel As System.Windows.Forms.Label
        Dim SubDept2IDLabel As System.Windows.Forms.Label
        Dim DesigIDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageSalary))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Acc_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSManageSalary = New ERP_HRMS.DSManageSalary()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Tbl_Acc_SalaryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RentDeduction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PAdvDedRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_ApprovingAthorityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinancialPeriod = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UnionFund = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PESSICont = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.IncrementStatus = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.UserId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IPAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CardStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.EmpPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.NICLabel1 = New System.Windows.Forms.Label()
        Me.DateOfBirthLabel2 = New System.Windows.Forms.Label()
        Me.FatherNameLabel2 = New System.Windows.Forms.Label()
        Me.NameLabel2 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_Info_HTableAdapter = New ERP_HRMS.DSManageSalaryTableAdapters.tbl_Hrm_Emp_Info_HTableAdapter()
        Me.Tbl_Hrm_Emp_InfoTableAdapter = New ERP_HRMS.DSManageSalaryTableAdapters.tbl_Hrm_Emp_InfoTableAdapter()
        Me.EmpIDLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_SalaryTableAdapter = New ERP_HRMS.DSManageSalaryTableAdapters.tbl_Acc_SalaryTableAdapter()
        Me.CardNoLabel2 = New System.Windows.Forms.Label()
        Me.Tbl_ApprovingAthorityTableAdapter = New ERP_HRMS.DSManageSalaryTableAdapters.tbl_ApprovingAthorityTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SubDept2Label1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_DesigGradeDeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.GradeLabel1 = New System.Windows.Forms.Label()
        Me.EmpStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.View_Rpt_Acc_DesigGradeDeptTableAdapter = New ERP_HRMS.DSManageSalaryTableAdapters.View_Rpt_Acc_DesigGradeDeptTableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSManageSalaryTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.TblAccFinancialPeriodtblAccSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSManageSalaryTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.MealLabel1 = New System.Windows.Forms.Label()
        Me.BasicSalaryLabel1 = New System.Windows.Forms.Label()
        Me.EOBILabel1 = New System.Windows.Forms.Label()
        CardNoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        NICLabel = New System.Windows.Forms.Label()
        CardStatusLabel = New System.Windows.Forms.Label()
        EmpStatusLabel = New System.Windows.Forms.Label()
        GradeIDLabel = New System.Windows.Forms.Label()
        SubDept2IDLabel = New System.Windows.Forms.Label()
        DesigIDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSManageSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_SalaryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_ApprovingAthorityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.SuspendLayout()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.View_Rpt_Acc_DesigGradeDeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.TblAccFinancialPeriodtblAccSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardNoLabel
        '
        CardNoLabel.Location = New System.Drawing.Point(20, 30)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(73, 20)
        CardNoLabel.TabIndex = 4
        CardNoLabel.Text = "Card No:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel
        '
        NameLabel.Cursor = System.Windows.Forms.Cursors.Default
        NameLabel.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(6, 29)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(73, 20)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Emp Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FatherNameLabel
        '
        FatherNameLabel.Cursor = System.Windows.Forms.Cursors.Default
        FatherNameLabel.Location = New System.Drawing.Point(484, 29)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(73, 20)
        FatherNameLabel.TabIndex = 2
        FatherNameLabel.Text = "Father Name:"
        FatherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.Location = New System.Drawing.Point(239, 29)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(85, 20)
        DateOfBirthLabel.TabIndex = 7
        DateOfBirthLabel.Text = "Date Of Birth:"
        DateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NICLabel
        '
        NICLabel.Location = New System.Drawing.Point(484, 53)
        NICLabel.Name = "NICLabel"
        NICLabel.Size = New System.Drawing.Size(73, 20)
        NICLabel.TabIndex = 9
        NICLabel.Text = "NIC No:"
        NICLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardStatusLabel
        '
        CardStatusLabel.Location = New System.Drawing.Point(205, 30)
        CardStatusLabel.Name = "CardStatusLabel"
        CardStatusLabel.Size = New System.Drawing.Size(70, 20)
        CardStatusLabel.TabIndex = 9
        CardStatusLabel.Text = "Card Status:"
        CardStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpStatusLabel
        '
        EmpStatusLabel.Location = New System.Drawing.Point(631, 77)
        EmpStatusLabel.Name = "EmpStatusLabel"
        EmpStatusLabel.Size = New System.Drawing.Size(78, 20)
        EmpStatusLabel.TabIndex = 14
        EmpStatusLabel.Text = "Emp Status:"
        EmpStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GradeIDLabel
        '
        GradeIDLabel.Location = New System.Drawing.Point(484, 77)
        GradeIDLabel.Name = "GradeIDLabel"
        GradeIDLabel.Size = New System.Drawing.Size(73, 20)
        GradeIDLabel.TabIndex = 15
        GradeIDLabel.Text = "Emp Grade:"
        GradeIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SubDept2IDLabel
        '
        SubDept2IDLabel.Location = New System.Drawing.Point(239, 77)
        SubDept2IDLabel.Name = "SubDept2IDLabel"
        SubDept2IDLabel.Size = New System.Drawing.Size(85, 20)
        SubDept2IDLabel.TabIndex = 16
        SubDept2IDLabel.Text = "Department:"
        SubDept2IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigIDLabel
        '
        DesigIDLabel.Location = New System.Drawing.Point(6, 77)
        DesigIDLabel.Name = "DesigIDLabel"
        DesigIDLabel.Size = New System.Drawing.Size(73, 20)
        DesigIDLabel.TabIndex = 17
        DesigIDLabel.Text = "Designation:"
        DesigIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(239, 53)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(85, 20)
        Label2.TabIndex = 22
        Label2.Text = "D.O.Permanent:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.Cursor = System.Windows.Forms.Cursors.Default
        Label3.Location = New System.Drawing.Point(6, 53)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(73, 20)
        Label3.TabIndex = 21
        Label3.Text = "D.O.Joining:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1179, 40)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Manage Employees Salary"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.Tbl_Acc_SalaryDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(3, 209)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1140, 360)
        Me.Panel2.TabIndex = 8
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.Tbl_Acc_SalaryBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem, Me.SaveToolStripButton, Me.toolStripSeparator1, Me.ToolStripLabel1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1138, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'Tbl_Acc_SalaryBindingSource
        '
        Me.Tbl_Acc_SalaryBindingSource.DataMember = "tbl_Hrm_Emp_Info_tbl_Acc_Salary"
        Me.Tbl_Acc_SalaryBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'Tbl_Hrm_Emp_InfoBindingSource
        '
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataMember = "tbl_Hrm_Emp_Info_H_tbl_Hrm_Emp_Info"
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        '
        'Tbl_Hrm_Emp_Info_HBindingSource
        '
        Me.Tbl_Hrm_Emp_Info_HBindingSource.DataMember = "tbl_Hrm_Emp_Info_H"
        Me.Tbl_Hrm_Emp_Info_HBindingSource.DataSource = Me.DSManageSalary
        '
        'DSManageSalary
        '
        Me.DSManageSalary.DataSetName = "DSManageSalary"
        Me.DSManageSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(88, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'Tbl_Acc_SalaryDataGridView
        '
        Me.Tbl_Acc_SalaryDataGridView.AllowUserToAddRows = False
        Me.Tbl_Acc_SalaryDataGridView.AllowUserToDeleteRows = False
        Me.Tbl_Acc_SalaryDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Acc_SalaryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Acc_SalaryDataGridView.ColumnHeadersHeight = 50
        Me.Tbl_Acc_SalaryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.RentDeduction, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.PAdvDedRate, Me.DataGridViewTextBoxColumn12, Me.FinancialPeriod, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn1, Me.UnionFund, Me.PESSICont, Me.IncrementStatus, Me.UserId, Me.IPAddress, Me.DeptId})
        Me.Tbl_Acc_SalaryDataGridView.DataSource = Me.Tbl_Acc_SalaryBindingSource
        Me.Tbl_Acc_SalaryDataGridView.Location = New System.Drawing.Point(2, 27)
        Me.Tbl_Acc_SalaryDataGridView.Name = "Tbl_Acc_SalaryDataGridView"
        Me.Tbl_Acc_SalaryDataGridView.RowHeadersWidth = 20
        Me.Tbl_Acc_SalaryDataGridView.Size = New System.Drawing.Size(1135, 328)
        Me.Tbl_Acc_SalaryDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SalID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sr. No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GrossSalary"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Gross Salary"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TaxDeduction"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tax"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'RentDeduction
        '
        Me.RentDeduction.DataPropertyName = "RentDeduction"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.RentDeduction.DefaultCellStyle = DataGridViewCellStyle5
        Me.RentDeduction.HeaderText = "Rent Deduction"
        Me.RentDeduction.Name = "RentDeduction"
        Me.RentDeduction.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EOBI"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "EOBI"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 55
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TravelAllowance"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Travel Allowance"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 65
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "EducationAllowance"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn7.HeaderText = "Education Allowance"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 65
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SpecialAllowance"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn8.HeaderText = "Special Allowance"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 65
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "MealAllowance"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn9.HeaderText = "Meal Allowance"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 60
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PaymentMode"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn10.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn10.HeaderText = "Payment Mode"
        Me.DataGridViewTextBoxColumn10.Items.AddRange(New Object() {"Cash", "Transfer"})
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.Width = 65
        '
        'PAdvDedRate
        '
        Me.PAdvDedRate.DataPropertyName = "PAdvDedRate"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.PAdvDedRate.DefaultCellStyle = DataGridViewCellStyle12
        Me.PAdvDedRate.HeaderText = "PAdv Ded Rate"
        Me.PAdvDedRate.Name = "PAdvDedRate"
        Me.PAdvDedRate.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "AppID"
        Me.DataGridViewTextBoxColumn12.DataSource = Me.Tbl_ApprovingAthorityBindingSource
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn12.DisplayMember = "AppName"
        Me.DataGridViewTextBoxColumn12.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn12.HeaderText = "Approved By"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn12.ValueMember = "AppID"
        '
        'Tbl_ApprovingAthorityBindingSource
        '
        Me.Tbl_ApprovingAthorityBindingSource.DataMember = "tbl_ApprovingAthority"
        Me.Tbl_ApprovingAthorityBindingSource.DataSource = Me.DSManageSalary
        '
        'FinancialPeriod
        '
        Me.FinancialPeriod.DataPropertyName = "FinancialPeriod"
        Me.FinancialPeriod.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FinancialPeriod.DefaultCellStyle = DataGridViewCellStyle14
        Me.FinancialPeriod.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriod.DisplayStyleForCurrentCellOnly = True
        Me.FinancialPeriod.HeaderText = "Financial Period"
        Me.FinancialPeriod.Name = "FinancialPeriod"
        Me.FinancialPeriod.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FinancialPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FinancialPeriod.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSManageSalary
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ActivationDate"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Format = "d"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn13.HeaderText = "Date of Activation"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Description"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn11.HeaderText = "Any Comments"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 110
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "ActivationStatus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activation Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'UnionFund
        '
        Me.UnionFund.DataPropertyName = "UnionFund"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UnionFund.DefaultCellStyle = DataGridViewCellStyle17
        Me.UnionFund.HeaderText = "Union Fund"
        Me.UnionFund.Name = "UnionFund"
        Me.UnionFund.Width = 55
        '
        'PESSICont
        '
        Me.PESSICont.DataPropertyName = "PESSICont"
        Me.PESSICont.HeaderText = "PESSI Contribution"
        Me.PESSICont.Name = "PESSICont"
        Me.PESSICont.Width = 70
        '
        'IncrementStatus
        '
        Me.IncrementStatus.DataPropertyName = "IncrementStatus"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IncrementStatus.DefaultCellStyle = DataGridViewCellStyle18
        Me.IncrementStatus.DisplayStyleForCurrentCellOnly = True
        Me.IncrementStatus.HeaderText = "Increment Status"
        Me.IncrementStatus.Items.AddRange(New Object() {"Starting", "Annual", "Special"})
        Me.IncrementStatus.Name = "IncrementStatus"
        Me.IncrementStatus.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IncrementStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IncrementStatus.Width = 70
        '
        'UserId
        '
        Me.UserId.DataPropertyName = "UserId"
        Me.UserId.HeaderText = "UserId"
        Me.UserId.Name = "UserId"
        Me.UserId.Visible = False
        '
        'IPAddress
        '
        Me.IPAddress.DataPropertyName = "IPAddress"
        Me.IPAddress.HeaderText = "IPAddress"
        Me.IPAddress.Name = "IPAddress"
        Me.IPAddress.Visible = False
        '
        'DeptId
        '
        Me.DeptId.DataPropertyName = "DeptId"
        Me.DeptId.HeaderText = "DeptId"
        Me.DeptId.Name = "DeptId"
        Me.DeptId.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(CardStatusLabel)
        Me.Panel1.Controls.Add(Me.CardStatusCheckBox)
        Me.Panel1.Controls.Add(Me.Tbl_Hrm_Emp_Info_HBindingNavigator)
        Me.Panel1.Controls.Add(Me.CardNoComboBox)
        Me.Panel1.Controls.Add(CardNoLabel)
        Me.Panel1.Location = New System.Drawing.Point(3, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 56)
        Me.Panel1.TabIndex = 0
        '
        'CardStatusCheckBox
        '
        Me.CardStatusCheckBox.AutoCheck = False
        Me.CardStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Hrm_Emp_Info_HBindingSource, "CardStatus", True))
        Me.CardStatusCheckBox.Location = New System.Drawing.Point(281, 30)
        Me.CardStatusCheckBox.Name = "CardStatusCheckBox"
        Me.CardStatusCheckBox.Size = New System.Drawing.Size(21, 20)
        Me.CardStatusCheckBox.TabIndex = 2
        '
        'Tbl_Hrm_Emp_Info_HBindingNavigator
        '
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.AddNewItem = Nothing
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.BindingSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.SaveToolStripButton1})
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Name = "Tbl_Hrm_Emp_Info_HBindingNavigator"
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Size = New System.Drawing.Size(327, 25)
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.TabIndex = 9
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'SaveToolStripButton1
        '
        Me.SaveToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton1.Image = CType(resources.GetObject("SaveToolStripButton1.Image"), System.Drawing.Image)
        Me.SaveToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton1.Name = "SaveToolStripButton1"
        Me.SaveToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton1.Text = "&Save"
        Me.SaveToolStripButton1.Visible = False
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.Tbl_Hrm_Emp_Info_HBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(99, 29)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(100, 21)
        Me.CardNoComboBox.TabIndex = 1
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'EmpPicPictureBox
        '
        Me.EmpPicPictureBox.BackColor = System.Drawing.SystemColors.Window
        Me.EmpPicPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.EmpPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpPic", True))
        Me.EmpPicPictureBox.Location = New System.Drawing.Point(761, 28)
        Me.EmpPicPictureBox.Name = "EmpPicPictureBox"
        Me.EmpPicPictureBox.Size = New System.Drawing.Size(70, 69)
        Me.EmpPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPicPictureBox.TabIndex = 13
        Me.EmpPicPictureBox.TabStop = False
        '
        'NICLabel1
        '
        Me.NICLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.NICLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NICLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "NIC", True))
        Me.NICLabel1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NICLabel1.Location = New System.Drawing.Point(562, 53)
        Me.NICLabel1.Name = "NICLabel1"
        Me.NICLabel1.Size = New System.Drawing.Size(169, 20)
        Me.NICLabel1.TabIndex = 10
        Me.NICLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfBirthLabel2
        '
        Me.DateOfBirthLabel2.BackColor = System.Drawing.Color.Gainsboro
        Me.DateOfBirthLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateOfBirthLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "DateOfBirth", True))
        Me.DateOfBirthLabel2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DateOfBirthLabel2.Location = New System.Drawing.Point(348, 59)
        Me.DateOfBirthLabel2.Name = "DateOfBirthLabel2"
        Me.DateOfBirthLabel2.Size = New System.Drawing.Size(10, 20)
        Me.DateOfBirthLabel2.TabIndex = 12
        Me.DateOfBirthLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DateOfBirthLabel2.Visible = False
        '
        'FatherNameLabel2
        '
        Me.FatherNameLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.FatherNameLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FatherNameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "FatherName", True))
        Me.FatherNameLabel2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FatherNameLabel2.Location = New System.Drawing.Point(562, 29)
        Me.FatherNameLabel2.Name = "FatherNameLabel2"
        Me.FatherNameLabel2.Size = New System.Drawing.Size(169, 20)
        Me.FatherNameLabel2.TabIndex = 11
        Me.FatherNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel2
        '
        Me.NameLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.NameLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "Name", True))
        Me.NameLabel2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.NameLabel2.Location = New System.Drawing.Point(83, 29)
        Me.NameLabel2.Name = "NameLabel2"
        Me.NameLabel2.Size = New System.Drawing.Size(150, 20)
        Me.NameLabel2.TabIndex = 10
        Me.NameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_Hrm_Emp_Info_HTableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_HTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_InfoTableAdapter
        '
        Me.Tbl_Hrm_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'EmpIDLabel1
        '
        Me.EmpIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpID", True))
        Me.EmpIDLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EmpIDLabel1.Location = New System.Drawing.Point(678, 56)
        Me.EmpIDLabel1.Name = "EmpIDLabel1"
        Me.EmpIDLabel1.Size = New System.Drawing.Size(100, 12)
        Me.EmpIDLabel1.TabIndex = 9
        '
        'Tbl_Acc_SalaryTableAdapter
        '
        Me.Tbl_Acc_SalaryTableAdapter.ClearBeforeFill = True
        '
        'CardNoLabel2
        '
        Me.CardNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_Info_HBindingSource, "CardNo", True))
        Me.CardNoLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.CardNoLabel2.Location = New System.Drawing.Point(462, 82)
        Me.CardNoLabel2.Name = "CardNoLabel2"
        Me.CardNoLabel2.Size = New System.Drawing.Size(100, 23)
        Me.CardNoLabel2.TabIndex = 10
        '
        'Tbl_ApprovingAthorityTableAdapter
        '
        Me.Tbl_ApprovingAthorityTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Label2)
        Me.Panel3.Controls.Add(Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.SubDept2Label1)
        Me.Panel3.Controls.Add(Me.DesigNameLabel1)
        Me.Panel3.Controls.Add(Me.GradeLabel1)
        Me.Panel3.Controls.Add(DesigIDLabel)
        Me.Panel3.Controls.Add(SubDept2IDLabel)
        Me.Panel3.Controls.Add(GradeIDLabel)
        Me.Panel3.Controls.Add(EmpStatusLabel)
        Me.Panel3.Controls.Add(Me.EmpStatusCheckBox)
        Me.Panel3.Controls.Add(Me.BindingNavigator2)
        Me.Panel3.Controls.Add(NameLabel)
        Me.Panel3.Controls.Add(Me.EmpPicPictureBox)
        Me.Panel3.Controls.Add(NICLabel)
        Me.Panel3.Controls.Add(FatherNameLabel)
        Me.Panel3.Controls.Add(DateOfBirthLabel)
        Me.Panel3.Controls.Add(Me.NICLabel1)
        Me.Panel3.Controls.Add(Me.NameLabel2)
        Me.Panel3.Controls.Add(Me.FatherNameLabel2)
        Me.Panel3.Location = New System.Drawing.Point(3, 101)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(850, 105)
        Me.Panel3.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "DateOfBirth", True))
        Me.TextBox1.Location = New System.Drawing.Point(330, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(148, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "DateOfPermanent", True))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label4.Location = New System.Drawing.Point(330, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Emp_InfoBindingSource, "DateOfJoining", True))
        Me.Label5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label5.Location = New System.Drawing.Point(83, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SubDept2Label1
        '
        Me.SubDept2Label1.BackColor = System.Drawing.SystemColors.Window
        Me.SubDept2Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SubDept2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_DesigGradeDeptBindingSource, "SubDept2", True))
        Me.SubDept2Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SubDept2Label1.Location = New System.Drawing.Point(330, 77)
        Me.SubDept2Label1.Name = "SubDept2Label1"
        Me.SubDept2Label1.Size = New System.Drawing.Size(148, 20)
        Me.SubDept2Label1.TabIndex = 20
        Me.SubDept2Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'View_Rpt_Acc_DesigGradeDeptBindingSource
        '
        Me.View_Rpt_Acc_DesigGradeDeptBindingSource.DataMember = "tbl_Hrm_Emp_Info_View_Rpt_Acc_DesigGradeDept"
        Me.View_Rpt_Acc_DesigGradeDeptBindingSource.DataSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_DesigGradeDeptBindingSource, "DesigName", True))
        Me.DesigNameLabel1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DesigNameLabel1.Location = New System.Drawing.Point(83, 77)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(150, 20)
        Me.DesigNameLabel1.TabIndex = 19
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GradeLabel1
        '
        Me.GradeLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.GradeLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GradeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_DesigGradeDeptBindingSource, "Grade", True))
        Me.GradeLabel1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GradeLabel1.Location = New System.Drawing.Point(562, 77)
        Me.GradeLabel1.Name = "GradeLabel1"
        Me.GradeLabel1.Size = New System.Drawing.Size(63, 20)
        Me.GradeLabel1.TabIndex = 18
        Me.GradeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpStatusCheckBox
        '
        Me.EmpStatusCheckBox.AutoCheck = False
        Me.EmpStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Hrm_Emp_InfoBindingSource, "EmpStatus", True))
        Me.EmpStatusCheckBox.Location = New System.Drawing.Point(715, 77)
        Me.EmpStatusCheckBox.Name = "EmpStatusCheckBox"
        Me.EmpStatusCheckBox.Size = New System.Drawing.Size(16, 22)
        Me.EmpStatusCheckBox.TabIndex = 3
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator2.BindingSource = Me.Tbl_Hrm_Emp_InfoBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton2})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator2.Size = New System.Drawing.Size(850, 25)
        Me.BindingNavigator2.TabIndex = 14
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        Me.BindingNavigatorAddNewItem1.Visible = False
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        Me.BindingNavigatorDeleteItem1.Visible = False
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'SaveToolStripButton2
        '
        Me.SaveToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton2.Image = CType(resources.GetObject("SaveToolStripButton2.Image"), System.Drawing.Image)
        Me.SaveToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton2.Name = "SaveToolStripButton2"
        Me.SaveToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.SaveToolStripButton2.Text = "&Save"
        Me.SaveToolStripButton2.Visible = False
        '
        'View_Rpt_Acc_DesigGradeDeptTableAdapter
        '
        Me.View_Rpt_Acc_DesigGradeDeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'TblAccFinancialPeriodtblAccSalaryBindingSource
        '
        Me.TblAccFinancialPeriodtblAccSalaryBindingSource.DataMember = "tbl_Acc_FinancialPeriod_tbl_Acc_Salary"
        Me.TblAccFinancialPeriodtblAccSalaryBindingSource.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(385, 52)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Manual Save"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(385, 75)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(75, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Auto Save"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(466, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Press F5 To Refresh Record"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(479, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Press Ctrl+S To Save Record"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        Me.Tbl_Comp_InfoBindingSource.DataSource = Me.DSManageSalary
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'MealLabel1
        '
        Me.MealLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "Meal", True))
        Me.MealLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.MealLabel1.Location = New System.Drawing.Point(944, 75)
        Me.MealLabel1.Name = "MealLabel1"
        Me.MealLabel1.Size = New System.Drawing.Size(100, 23)
        Me.MealLabel1.TabIndex = 17
        Me.MealLabel1.Text = "Label8"
        '
        'BasicSalaryLabel1
        '
        Me.BasicSalaryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "BasicSalary", True))
        Me.BasicSalaryLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.BasicSalaryLabel1.Location = New System.Drawing.Point(944, 98)
        Me.BasicSalaryLabel1.Name = "BasicSalaryLabel1"
        Me.BasicSalaryLabel1.Size = New System.Drawing.Size(65, 23)
        Me.BasicSalaryLabel1.TabIndex = 18
        Me.BasicSalaryLabel1.Text = "Label8"
        '
        'EOBILabel1
        '
        Me.EOBILabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "EOBI", True))
        Me.EOBILabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EOBILabel1.Location = New System.Drawing.Point(929, 144)
        Me.EOBILabel1.Name = "EOBILabel1"
        Me.EOBILabel1.Size = New System.Drawing.Size(100, 23)
        Me.EOBILabel1.TabIndex = 19
        Me.EOBILabel1.Text = "Label8"
        '
        'frmManageSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1179, 642)
        Me.Controls.Add(Me.EOBILabel1)
        Me.Controls.Add(Me.BasicSalaryLabel1)
        Me.Controls.Add(Me.MealLabel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.CardNoLabel2)
        Me.Controls.Add(Me.EmpIDLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateOfBirthLabel2)
        Me.Name = "frmManageSalary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Salary"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSManageSalary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_SalaryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_ApprovingAthorityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Hrm_Emp_Info_HBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.ResumeLayout(False)
        Me.Tbl_Hrm_Emp_Info_HBindingNavigator.PerformLayout()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.View_Rpt_Acc_DesigGradeDeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.TblAccFinancialPeriodtblAccSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DSManageSalary As ERP_HRMS.DSManageSalary
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Tbl_Hrm_Emp_Info_HBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_HTableAdapter As ERP_HRMS.DSManageSalaryTableAdapters.tbl_Hrm_Emp_Info_HTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Info_HBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tbl_Hrm_Emp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_InfoTableAdapter As ERP_HRMS.DSManageSalaryTableAdapters.tbl_Hrm_Emp_InfoTableAdapter
    Friend WithEvents DateOfBirthLabel2 As System.Windows.Forms.Label
    Friend WithEvents FatherNameLabel2 As System.Windows.Forms.Label
    Friend WithEvents NameLabel2 As System.Windows.Forms.Label
    Friend WithEvents EmpIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents NICLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_SalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_SalaryTableAdapter As ERP_HRMS.DSManageSalaryTableAdapters.tbl_Acc_SalaryTableAdapter
    Friend WithEvents Tbl_Acc_SalaryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmpPicPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CardNoLabel2 As System.Windows.Forms.Label
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_ApprovingAthorityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_ApprovingAthorityTableAdapter As ERP_HRMS.DSManageSalaryTableAdapters.tbl_ApprovingAthorityTableAdapter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CardStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaveToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmpStatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents View_Rpt_Acc_DesigGradeDeptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_DesigGradeDeptTableAdapter As ERP_HRMS.DSManageSalaryTableAdapters.View_Rpt_Acc_DesigGradeDeptTableAdapter
    Friend WithEvents SubDept2Label1 As System.Windows.Forms.Label
    Friend WithEvents DesigNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents GradeLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As ERP_HRMS.DSManageSalaryTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents TblAccFinancialPeriodtblAccSalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RentDeduction As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PAdvDedRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FinancialPeriod As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents UnionFund As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PESSICont As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents IncrementStatus As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents UserId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IPAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tbl_Comp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As ERP_HRMS.DSManageSalaryTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents MealLabel1 As System.Windows.Forms.Label
    Friend WithEvents BasicSalaryLabel1 As System.Windows.Forms.Label
    Friend WithEvents EOBILabel1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
End Class
