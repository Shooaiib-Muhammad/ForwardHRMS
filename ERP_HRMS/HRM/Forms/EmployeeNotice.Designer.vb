<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee_Notice
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee_Notice))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tbl_Hrm_Emp_NoticesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tbl_Hrm_Emp_NoticesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Emp_NoticesTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Hrm_Emp_NoticesTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Tbl_Hrm_Emp_NoticesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_NoticesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_NoticesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tbl_Hrm_Emp_NoticesDataGridView
        '
        Me.Tbl_Hrm_Emp_NoticesDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tbl_Hrm_Emp_NoticesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Hrm_Emp_NoticesDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Hrm_Emp_NoticesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_Hrm_Emp_NoticesDataGridView.ColumnHeadersHeight = 32
        Me.Tbl_Hrm_Emp_NoticesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_Hrm_Emp_NoticesDataGridView.DataSource = Me.Tbl_Hrm_Emp_NoticesBindingSource
        Me.Tbl_Hrm_Emp_NoticesDataGridView.Location = New System.Drawing.Point(5, 26)
        Me.Tbl_Hrm_Emp_NoticesDataGridView.Name = "Tbl_Hrm_Emp_NoticesDataGridView"
        Me.Tbl_Hrm_Emp_NoticesDataGridView.ReadOnly = True
        Me.Tbl_Hrm_Emp_NoticesDataGridView.RowHeadersWidth = 22
        Me.Tbl_Hrm_Emp_NoticesDataGridView.Size = New System.Drawing.Size(390, 698)
        Me.Tbl_Hrm_Emp_NoticesDataGridView.TabIndex = 1
        '
        'Tbl_Hrm_Emp_NoticesBindingSource
        '
        Me.Tbl_Hrm_Emp_NoticesBindingSource.DataMember = "tbl_Hrm_Emp_Notices"
        Me.Tbl_Hrm_Emp_NoticesBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Hrm_Emp_NoticesBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_Hrm_Emp_NoticesDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(267, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 729)
        Me.Panel1.TabIndex = 2
        '
        'Tbl_Hrm_Emp_NoticesBindingNavigator
        '
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.BindingSource = Me.Tbl_Hrm_Emp_NoticesBindingSource
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem, Me.EditToolStripButton, Me.CancelToolStripButton})
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.Name = "Tbl_Hrm_Emp_NoticesBindingNavigator"
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.Size = New System.Drawing.Size(398, 27)
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.TabIndex = 2
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem
        '
        Me.Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Name = "Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem"
        Me.Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.edit_29
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(24, 24)
        Me.EditToolStripButton.Text = "&Edit"
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.images__1_
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Size = New System.Drawing.Size(24, 24)
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
        Me.Label1.Size = New System.Drawing.Size(931, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Notice Types"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Hrm_Emp_NoticesTableAdapter
        '
        Me.Tbl_Hrm_Emp_NoticesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_HRM_DeptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_NoticesTableAdapter = Me.Tbl_Hrm_Emp_NoticesTableAdapter
        Me.TableAdapterManager.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NoticeID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serial No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NoticeType"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Notice Types"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 250
        '
        'Employee_Notice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 778)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Employee_Notice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notice Types"
        CType(Me.Tbl_Hrm_Emp_NoticesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_NoticesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Hrm_Emp_NoticesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.ResumeLayout(False)
        Me.Tbl_Hrm_Emp_NoticesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_Hrm_Emp_NoticesBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_NoticesTableAdapter As DSHRMTableAdapters.tbl_Hrm_Emp_NoticesTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Hrm_Emp_NoticesDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_Hrm_Emp_NoticesBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_Hrm_Emp_NoticesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents CancelToolStripButton As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
