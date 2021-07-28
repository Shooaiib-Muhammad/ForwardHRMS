<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpEvaluation
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
        Dim EvaluationPeriodLabel As System.Windows.Forms.Label
        Dim FinancialPeriodLabel As System.Windows.Forms.Label
        Dim EvaluationDateLabel As System.Windows.Forms.Label
        Dim MonthNOLabel As System.Windows.Forms.Label
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpEvaluation))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSEmpEvaluation = New ERP_HRMS.DSEmpEvaluation()
        Me.Tbl_Emp_Evaluation_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Emp_Evaluation_HeadTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_Evaluation_HeadTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSEmpEvaluationTableAdapters.TableAdapterManager()
        Me.Tbl_Emp_EvaluationTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_EvaluationTableAdapter()
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EvaluationPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MonthNOTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EvaluationDateTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Tbl_Emp_EvaluationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Emp_EvaluationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSLongLeaves = New ERP_HRMS.DSLongLeaves()
        Me.Status = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GrossSalary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMSSearchNIC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EnterGradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ActiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NonActiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryGreaterTextbox = New System.Windows.Forms.ToolStripTextBox()
        Me.SalaryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalaryLessEqualTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Emp_DojBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Emp_DojTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_DojTableAdapter()
        Me.Tbl_Hrm_Emp_Info_NoticesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_NoticesTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Hrm_Emp_Info_NoticesTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_AllEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.CardNoLabel1 = New System.Windows.Forms.Label()
        Me.EavalID = New System.Windows.Forms.Label()
        Me.EmpIDLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_AllEmployeesTableAdapter = New ERP_HRMS.HRMDBDataset1TableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter()
        Me.DataTable1TableAdapter = New ERP_HRMS.DSLongLeavesTableAdapters.DataTable1TableAdapter()
        Me.Tbl_Emp_Evaluation1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Emp_Evaluation1TableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_Evaluation1TableAdapter()
        Me.Tbl_Emp_Evaluation2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Emp_Evaluation2TableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_Evaluation2TableAdapter()
        Me.Tbl_PayRoll_AbsentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_AbsentsTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_PayRoll_AbsentsTableAdapter()
        Me.View_Rpt_Acc_MorningShortMinsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_MorningShortMinsTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.View_Rpt_Acc_MorningShortMinsTableAdapter()
        Me.Tbl_PayRoll_LeavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_LeavesTableAdapter = New ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_PayRoll_LeavesTableAdapter()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        EvaluationPeriodLabel = New System.Windows.Forms.Label()
        FinancialPeriodLabel = New System.Windows.Forms.Label()
        EvaluationDateLabel = New System.Windows.Forms.Label()
        MonthNOLabel = New System.Windows.Forms.Label()
        CardNoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.DSEmpEvaluation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Emp_Evaluation_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Emp_Evaluation_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Emp_EvaluationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Emp_EvaluationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSLongLeaves, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSSearchNIC.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_Emp_DojBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_NoticesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Emp_Evaluation1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Emp_Evaluation2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_AbsentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_MorningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LeavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EvaluationPeriodLabel
        '
        EvaluationPeriodLabel.AutoSize = True
        EvaluationPeriodLabel.Location = New System.Drawing.Point(223, 37)
        EvaluationPeriodLabel.Name = "EvaluationPeriodLabel"
        EvaluationPeriodLabel.Size = New System.Drawing.Size(93, 13)
        EvaluationPeriodLabel.TabIndex = 1
        EvaluationPeriodLabel.Text = "Evaluation Period:"
        EvaluationPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FinancialPeriodLabel
        '
        FinancialPeriodLabel.AutoSize = True
        FinancialPeriodLabel.Location = New System.Drawing.Point(4, 35)
        FinancialPeriodLabel.Name = "FinancialPeriodLabel"
        FinancialPeriodLabel.Size = New System.Drawing.Size(85, 13)
        FinancialPeriodLabel.TabIndex = 3
        FinancialPeriodLabel.Text = "Financial Period:"
        '
        'EvaluationDateLabel
        '
        EvaluationDateLabel.AutoSize = True
        EvaluationDateLabel.Location = New System.Drawing.Point(4, 62)
        EvaluationDateLabel.Name = "EvaluationDateLabel"
        EvaluationDateLabel.Size = New System.Drawing.Size(86, 13)
        EvaluationDateLabel.TabIndex = 5
        EvaluationDateLabel.Text = "Evaluation Date:"
        '
        'MonthNOLabel
        '
        MonthNOLabel.AutoSize = True
        MonthNOLabel.Location = New System.Drawing.Point(243, 63)
        MonthNOLabel.Name = "MonthNOLabel"
        MonthNOLabel.Size = New System.Drawing.Size(73, 13)
        MonthNOLabel.TabIndex = 7
        MonthNOLabel.Text = "NO Of Month:"
        MonthNOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CardNoLabel
        '
        CardNoLabel.Location = New System.Drawing.Point(0, 5)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(69, 20)
        CardNoLabel.TabIndex = 19
        CardNoLabel.Text = "Card No:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameLabel
        '
        NameLabel.Location = New System.Drawing.Point(0, 28)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(69, 20)
        NameLabel.TabIndex = 21
        NameLabel.Text = "Emp.Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DesigNameLabel
        '
        DesigNameLabel.Location = New System.Drawing.Point(0, 51)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(69, 20)
        DesigNameLabel.TabIndex = 23
        DesigNameLabel.Text = "Designation:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DeptNameLabel
        '
        DeptNameLabel.Location = New System.Drawing.Point(189, 51)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(67, 20)
        DeptNameLabel.TabIndex = 25
        DeptNameLabel.Text = "Department:"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(259, 28)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(40, 20)
        Label2.TabIndex = 104
        Label2.Text = "DOJ:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Label4.Location = New System.Drawing.Point(142, 5)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(40, 20)
        Label4.TabIndex = 106
        Label4.Text = "Grade:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DSEmpEvaluation
        '
        Me.DSEmpEvaluation.DataSetName = "DSEmpEvaluation"
        Me.DSEmpEvaluation.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Emp_Evaluation_HeadBindingSource
        '
        Me.Tbl_Emp_Evaluation_HeadBindingSource.DataMember = "tbl_Emp_Evaluation_Head"
        Me.Tbl_Emp_Evaluation_HeadBindingSource.DataSource = Me.DSEmpEvaluation
        '
        'Tbl_Emp_Evaluation_HeadTableAdapter
        '
        Me.Tbl_Emp_Evaluation_HeadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Emp_Evaluation_HeadTableAdapter = Me.Tbl_Emp_Evaluation_HeadTableAdapter
        Me.TableAdapterManager.tbl_Emp_Evaluation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Emp_Evaluation2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Emp_EvaluationTableAdapter = Me.Tbl_Emp_EvaluationTableAdapter
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSEmpEvaluationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Emp_EvaluationTableAdapter
        '
        Me.Tbl_Emp_EvaluationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Emp_Evaluation_HeadBindingNavigator
        '
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.BindingSource = Me.Tbl_Emp_Evaluation_HeadBindingSource
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem})
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.Name = "Tbl_Emp_Evaluation_HeadBindingNavigator"
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.Size = New System.Drawing.Size(460, 25)
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.TabIndex = 0
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem
        '
        Me.Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem.Name = "Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem"
        Me.Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EvaluationPeriodTextBox
        '
        Me.EvaluationPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Emp_Evaluation_HeadBindingSource, "EvaluationPeriod", True))
        Me.EvaluationPeriodTextBox.Location = New System.Drawing.Point(319, 33)
        Me.EvaluationPeriodTextBox.Name = "EvaluationPeriodTextBox"
        Me.EvaluationPeriodTextBox.Size = New System.Drawing.Size(123, 20)
        Me.EvaluationPeriodTextBox.TabIndex = 2
        Me.EvaluationPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Emp_Evaluation_HeadBindingSource, "FinancialPeriod", True))
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(90, 32)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(129, 21)
        Me.FinancialPeriodComboBox.TabIndex = 4
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSEmpEvaluation
        '
        'MonthNOTextBox
        '
        Me.MonthNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Emp_Evaluation_HeadBindingSource, "MonthNO", True))
        Me.MonthNOTextBox.Location = New System.Drawing.Point(319, 58)
        Me.MonthNOTextBox.Name = "MonthNOTextBox"
        Me.MonthNOTextBox.Size = New System.Drawing.Size(123, 20)
        Me.MonthNOTextBox.TabIndex = 8
        Me.MonthNOTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.EvaluationDateTextBox)
        Me.Panel1.Controls.Add(Me.Tbl_Emp_Evaluation_HeadBindingNavigator)
        Me.Panel1.Controls.Add(MonthNOLabel)
        Me.Panel1.Controls.Add(Me.MonthNOTextBox)
        Me.Panel1.Controls.Add(FinancialPeriodLabel)
        Me.Panel1.Controls.Add(Me.FinancialPeriodComboBox)
        Me.Panel1.Controls.Add(EvaluationDateLabel)
        Me.Panel1.Controls.Add(EvaluationPeriodLabel)
        Me.Panel1.Controls.Add(Me.EvaluationPeriodTextBox)
        Me.Panel1.Location = New System.Drawing.Point(5, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 86)
        Me.Panel1.TabIndex = 9
        '
        'EvaluationDateTextBox
        '
        Me.EvaluationDateTextBox.BackColor = System.Drawing.Color.White
        Me.EvaluationDateTextBox.CausesValidation = False
        Me.EvaluationDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Emp_Evaluation_HeadBindingSource, "EvaluationDate", True))
        Me.EvaluationDateTextBox.Location = New System.Drawing.Point(90, 58)
        Me.EvaluationDateTextBox.Mask = "00/00/0000"
        Me.EvaluationDateTextBox.Name = "EvaluationDateTextBox"
        Me.EvaluationDateTextBox.Size = New System.Drawing.Size(129, 20)
        Me.EvaluationDateTextBox.TabIndex = 15
        Me.EvaluationDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1086, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Employees Annual Evaluation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(880, 61)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(104, 69)
        Me.btnExport.TabIndex = 36
        Me.btnExport.Text = "Load Employees Record"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'Tbl_Emp_EvaluationBindingSource
        '
        Me.Tbl_Emp_EvaluationBindingSource.DataMember = "tbl_Emp_Evaluation_Head_tbl_Emp_Evaluation"
        Me.Tbl_Emp_EvaluationBindingSource.DataSource = Me.Tbl_Emp_Evaluation_HeadBindingSource
        '
        'Tbl_Emp_EvaluationDataGridView
        '
        Me.Tbl_Emp_EvaluationDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Emp_EvaluationDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.Tbl_Emp_EvaluationDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Emp_EvaluationDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.Tbl_Emp_EvaluationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Emp_EvaluationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.Status, Me.Grade, Me.GrossSalary, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Tbl_Emp_EvaluationDataGridView.ContextMenuStrip = Me.CMSSearchNIC
        Me.Tbl_Emp_EvaluationDataGridView.DataSource = Me.Tbl_Emp_EvaluationBindingSource
        Me.Tbl_Emp_EvaluationDataGridView.Location = New System.Drawing.Point(2, 27)
        Me.Tbl_Emp_EvaluationDataGridView.Name = "Tbl_Emp_EvaluationDataGridView"
        Me.Tbl_Emp_EvaluationDataGridView.RowHeadersWidth = 10
        Me.Tbl_Emp_EvaluationDataGridView.Size = New System.Drawing.Size(974, 486)
        Me.Tbl_Emp_EvaluationDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TranID"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EmpId"
        Me.DataGridViewTextBoxColumn5.DataSource = Me.DataTable1BindingSource
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn5.DisplayMember = "CardNo"
        Me.DataGridViewTextBoxColumn5.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Card No."
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn5.ValueMember = "EmpID"
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DSLongLeaves
        '
        'DSLongLeaves
        '
        Me.DSLongLeaves.DataSetName = "DSLongLeaves"
        Me.DSLongLeaves.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.Frozen = True
        Me.Status.HeaderText = "Eval.Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 70
        '
        'Grade
        '
        Me.Grade.DataPropertyName = "Grade"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Grade.DefaultCellStyle = DataGridViewCellStyle20
        Me.Grade.Frozen = True
        Me.Grade.HeaderText = "Grade"
        Me.Grade.Name = "Grade"
        Me.Grade.Width = 60
        '
        'GrossSalary
        '
        Me.GrossSalary.DataPropertyName = "GrossSalary"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.GrossSalary.DefaultCellStyle = DataGridViewCellStyle21
        Me.GrossSalary.Frozen = True
        Me.GrossSalary.HeaderText = "Gross Salary"
        Me.GrossSalary.Name = "GrossSalary"
        Me.GrossSalary.ReadOnly = True
        Me.GrossSalary.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Leaves"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn6.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn6.HeaderText = "Leaves"
        Me.DataGridViewTextBoxColumn6.Items.AddRange(New Object() {"No Leave in a year 100", "Avail all legal leaves 090", "Avail 25% of total 098", "Avail 50% of total 095", "Avail 75% of total 092"})
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn6.Width = 145
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Absents"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridViewTextBoxColumn7.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn7.HeaderText = "Absents"
        Me.DataGridViewTextBoxColumn7.Items.AddRange(New Object() {"No Absent  100", "Absent < 4  080", "Absent > 4 and <8  060", "Absent > 8 and <12  040", "Absent > 12  020"})
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn7.Width = 140
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Late"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn8.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn8.HeaderText = "Late"
        Me.DataGridViewTextBoxColumn8.Items.AddRange(New Object() {"Less Than 8 Hrs 100", "Late > 8 and < 24 Hrs 080", "Late > 24 and < 48 Hrs 060", "Late > 48 Hrs 040"})
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn8.Width = 140
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Notice"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle25
        Me.DataGridViewTextBoxColumn9.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn9.HeaderText = "Notice"
        Me.DataGridViewTextBoxColumn9.Items.AddRange(New Object() {"No Notice 100", "Verbal 080", "1st Warning 060", "2nd Warning 040", "3rd Warning 020"})
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn9.Width = 110
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "WorkProgress"
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle26
        Me.DataGridViewTextBoxColumn10.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn10.HeaderText = "Work Progress"
        Me.DataGridViewTextBoxColumn10.Items.AddRange(New Object() {"Poor 020", "Satisfactory 040", "Good 060", "Very Good 080", "Excellent 100"})
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Attitude"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridViewTextBoxColumn11.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn11.HeaderText = "Attitude"
        Me.DataGridViewTextBoxColumn11.Items.AddRange(New Object() {"Poor 020", "Satisfactory 040", "Good 060", "Very Good 080", "Excellent 100"})
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Knowledge"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridViewTextBoxColumn12.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn12.HeaderText = "Professinal Knowledge"
        Me.DataGridViewTextBoxColumn12.Items.AddRange(New Object() {"Poor 020", "Satisfactory 040", "Good 060", "Very Good 080", "Excellent 100"})
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "SPIncrement"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle29
        Me.DataGridViewTextBoxColumn13.HeaderText = "Special Increment"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 80
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Remarks"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn14.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 200
        '
        'CMSSearchNIC
        '
        Me.CMSSearchNIC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterGradeToolStripMenuItem, Me.ActiveToolStripMenuItem, Me.NonActiveToolStripMenuItem, Me.SalaryToolStripMenuItem, Me.SalaryToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.CMSSearchNIC.Name = "ContextMenuStrip1"
        Me.CMSSearchNIC.Size = New System.Drawing.Size(171, 136)
        '
        'EnterGradeToolStripMenuItem
        '
        Me.EnterGradeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradeTextBox})
        Me.EnterGradeToolStripMenuItem.Name = "EnterGradeToolStripMenuItem"
        Me.EnterGradeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EnterGradeToolStripMenuItem.Text = "Enter Grade"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'ActiveToolStripMenuItem
        '
        Me.ActiveToolStripMenuItem.Name = "ActiveToolStripMenuItem"
        Me.ActiveToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ActiveToolStripMenuItem.Text = "Active Status"
        '
        'NonActiveToolStripMenuItem
        '
        Me.NonActiveToolStripMenuItem.Name = "NonActiveToolStripMenuItem"
        Me.NonActiveToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NonActiveToolStripMenuItem.Text = "Non-Active Status"
        '
        'SalaryToolStripMenuItem
        '
        Me.SalaryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalaryGreaterTextbox})
        Me.SalaryToolStripMenuItem.Name = "SalaryToolStripMenuItem"
        Me.SalaryToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SalaryToolStripMenuItem.Text = "Salary>="
        '
        'SalaryGreaterTextbox
        '
        Me.SalaryGreaterTextbox.Name = "SalaryGreaterTextbox"
        Me.SalaryGreaterTextbox.Size = New System.Drawing.Size(100, 23)
        '
        'SalaryToolStripMenuItem1
        '
        Me.SalaryToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalaryLessEqualTextBox})
        Me.SalaryToolStripMenuItem1.Name = "SalaryToolStripMenuItem1"
        Me.SalaryToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.SalaryToolStripMenuItem1.Text = "Salary<="
        '
        'SalaryLessEqualTextBox
        '
        Me.SalaryLessEqualTextBox.Name = "SalaryLessEqualTextBox"
        Me.SalaryLessEqualTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem2.Text = "&Refresh"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.Tbl_Emp_EvaluationDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(4, 134)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(980, 515)
        Me.Panel2.TabIndex = 37
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Tbl_Emp_EvaluationBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.SaveToolStripButton, Me.ToolStripSeparator1, Me.ToolStripSeparator7, Me.ToolStripSeparator6, Me.ToolStripSeparator5, Me.ToolStripSeparator4, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.ToolStripLabel1, Me.ToolStripSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(978, 25)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
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
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Navy
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel2.Text = "Check All"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.Maroon
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(77, 22)
        Me.ToolStripLabel1.Text = "View Report"
        Me.ToolStripLabel1.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Tbl_Emp_DojBindingSource
        '
        Me.Tbl_Emp_DojBindingSource.DataMember = "tbl_Emp_Doj"
        Me.Tbl_Emp_DojBindingSource.DataSource = Me.DSEmpEvaluation
        '
        'Tbl_Emp_DojTableAdapter
        '
        Me.Tbl_Emp_DojTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_NoticesBindingSource
        '
        Me.Tbl_Hrm_Emp_Info_NoticesBindingSource.DataMember = "tbl_Hrm_Emp_Info_Notices"
        Me.Tbl_Hrm_Emp_Info_NoticesBindingSource.DataSource = Me.DSEmpEvaluation
        '
        'Tbl_Hrm_Emp_Info_NoticesTableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_NoticesTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 714)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1086, 36)
        Me.StatusStrip1.TabIndex = 100
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(800, 30)
        Me.ToolStripProgressBar1.Step = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(DeptNameLabel)
        Me.Panel3.Controls.Add(Me.DeptNameLabel1)
        Me.Panel3.Controls.Add(DesigNameLabel)
        Me.Panel3.Controls.Add(Me.DesigNameLabel1)
        Me.Panel3.Controls.Add(NameLabel)
        Me.Panel3.Controls.Add(Me.NameLabel1)
        Me.Panel3.Controls.Add(CardNoLabel)
        Me.Panel3.Controls.Add(Me.CardNoLabel1)
        Me.Panel3.Location = New System.Drawing.Point(470, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(404, 86)
        Me.Panel3.TabIndex = 101
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "Grade", True))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(184, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'View_Rpt_Acc_AllEmployeesBindingSource
        '
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataMember = "View_Rpt_Acc_AllEmployees"
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataSource = Me.HRMDBDataSet1
        '
        'HRMDBDataSet1
        '
        Me.HRMDBDataSet1.DataSetName = "HRMDBDataSet1"
        Me.HRMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DateOfJoining", True))
        Me.Label3.Location = New System.Drawing.Point(304, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 105
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DeptName", True))
        Me.DeptNameLabel1.Location = New System.Drawing.Point(262, 51)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(136, 20)
        Me.DeptNameLabel1.TabIndex = 26
        Me.DeptNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.Color.White
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DesigName", True))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(71, 51)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(112, 20)
        Me.DesigNameLabel1.TabIndex = 24
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel1
        '
        Me.NameLabel1.BackColor = System.Drawing.Color.White
        Me.NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(71, 28)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(185, 20)
        Me.NameLabel1.TabIndex = 22
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardNoLabel1
        '
        Me.CardNoLabel1.BackColor = System.Drawing.Color.White
        Me.CardNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CardNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "CardNo", True))
        Me.CardNoLabel1.Location = New System.Drawing.Point(71, 5)
        Me.CardNoLabel1.Name = "CardNoLabel1"
        Me.CardNoLabel1.Size = New System.Drawing.Size(66, 20)
        Me.CardNoLabel1.TabIndex = 20
        Me.CardNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EavalID
        '
        Me.EavalID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Emp_Evaluation_HeadBindingSource, "EvalID", True))
        Me.EavalID.ForeColor = System.Drawing.SystemColors.Control
        Me.EavalID.Location = New System.Drawing.Point(880, 48)
        Me.EavalID.Name = "EavalID"
        Me.EavalID.Size = New System.Drawing.Size(26, 10)
        Me.EavalID.TabIndex = 103
        Me.EavalID.Tag = "12,12"
        '
        'EmpIDLabel1
        '
        Me.EmpIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Emp_EvaluationBindingSource, "EmpId", True))
        Me.EmpIDLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpIDLabel1.Location = New System.Drawing.Point(932, 48)
        Me.EmpIDLabel1.Name = "EmpIDLabel1"
        Me.EmpIDLabel1.Size = New System.Drawing.Size(17, 10)
        Me.EmpIDLabel1.TabIndex = 102
        Me.EmpIDLabel1.Tag = "12,12"
        '
        'View_Rpt_Acc_AllEmployeesTableAdapter
        '
        Me.View_Rpt_Acc_AllEmployeesTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Emp_Evaluation1BindingSource
        '
        Me.Tbl_Emp_Evaluation1BindingSource.DataMember = "tbl_Emp_Evaluation1"
        Me.Tbl_Emp_Evaluation1BindingSource.DataSource = Me.DSEmpEvaluation
        '
        'Tbl_Emp_Evaluation1TableAdapter
        '
        Me.Tbl_Emp_Evaluation1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Emp_Evaluation2BindingSource
        '
        Me.Tbl_Emp_Evaluation2BindingSource.DataMember = "tbl_Emp_Evaluation2"
        Me.Tbl_Emp_Evaluation2BindingSource.DataSource = Me.DSEmpEvaluation
        '
        'Tbl_Emp_Evaluation2TableAdapter
        '
        Me.Tbl_Emp_Evaluation2TableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_AbsentsBindingSource
        '
        Me.Tbl_PayRoll_AbsentsBindingSource.DataMember = "tbl_PayRoll_Absents"
        Me.Tbl_PayRoll_AbsentsBindingSource.DataSource = Me.DSEmpEvaluation
        '
        'Tbl_PayRoll_AbsentsTableAdapter
        '
        Me.Tbl_PayRoll_AbsentsTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_MorningShortMinsBindingSource
        '
        Me.View_Rpt_Acc_MorningShortMinsBindingSource.DataMember = "View_Rpt_Acc_MorningShortMins"
        Me.View_Rpt_Acc_MorningShortMinsBindingSource.DataSource = Me.DSEmpEvaluation
        '
        'View_Rpt_Acc_MorningShortMinsTableAdapter
        '
        Me.View_Rpt_Acc_MorningShortMinsTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PayRoll_LeavesBindingSource
        '
        Me.Tbl_PayRoll_LeavesBindingSource.DataMember = "tbl_PayRoll_Leaves"
        Me.Tbl_PayRoll_LeavesBindingSource.DataSource = Me.DSEmpEvaluation
        '
        'Tbl_PayRoll_LeavesTableAdapter
        '
        Me.Tbl_PayRoll_LeavesTableAdapter.ClearBeforeFill = True
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'frmEmpEvaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1086, 750)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.EavalID)
        Me.Controls.Add(Me.EmpIDLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEmpEvaluation"
        Me.Text = "Employees Annual Evaluation"
        CType(Me.DSEmpEvaluation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Emp_Evaluation_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Emp_Evaluation_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.ResumeLayout(False)
        Me.Tbl_Emp_Evaluation_HeadBindingNavigator.PerformLayout()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Emp_EvaluationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Emp_EvaluationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSLongLeaves, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSSearchNIC.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_Emp_DojBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_NoticesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Emp_Evaluation1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Emp_Evaluation2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_AbsentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_MorningShortMinsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LeavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DSEmpEvaluation As ERP_HRMS.DSEmpEvaluation
    Friend WithEvents Tbl_Emp_Evaluation_HeadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Emp_Evaluation_HeadTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_Evaluation_HeadTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSEmpEvaluationTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Emp_Evaluation_HeadBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EvaluationPeriodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FinancialPeriodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MonthNOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents Tbl_Emp_EvaluationTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_EvaluationTableAdapter
    Friend WithEvents Tbl_Emp_EvaluationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Emp_EvaluationDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Emp_DojBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Emp_DojTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_DojTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Info_NoticesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_NoticesTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Hrm_Emp_Info_NoticesTableAdapter
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    'Friend WithEvents TableAdapterManager1 As ERP_HRMS.DSContractPrdTableAdapters.TableAdapterManager
    Friend WithEvents HRMDBDataSet1 As ERP_HRMS.HRMDBDataset1
    Friend WithEvents View_Rpt_Acc_AllEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployeesTableAdapter As ERP_HRMS.HRMDBDataset1TableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter
    Friend WithEvents CardNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DesigNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DeptNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents DSLongLeaves As ERP_HRMS.DSLongLeaves
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As ERP_HRMS.DSLongLeavesTableAdapters.DataTable1TableAdapter
    Friend WithEvents EmpIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Emp_Evaluation1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Emp_Evaluation1TableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_Evaluation1TableAdapter
    Friend WithEvents EavalID As System.Windows.Forms.Label
    Friend WithEvents Tbl_Emp_Evaluation2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Emp_Evaluation2TableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_Emp_Evaluation2TableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Tbl_PayRoll_AbsentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_AbsentsTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_PayRoll_AbsentsTableAdapter
    Friend WithEvents View_Rpt_Acc_MorningShortMinsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_MorningShortMinsTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.View_Rpt_Acc_MorningShortMinsTableAdapter
    Friend WithEvents Tbl_PayRoll_LeavesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_PayRoll_LeavesTableAdapter As ERP_HRMS.DSEmpEvaluationTableAdapters.tbl_PayRoll_LeavesTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CMSSearchNIC As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ActiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NonActiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GrossSalary As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnterGradeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradeTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SalaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalaryGreaterTextbox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SalaryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalaryLessEqualTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EvaluationDateTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
