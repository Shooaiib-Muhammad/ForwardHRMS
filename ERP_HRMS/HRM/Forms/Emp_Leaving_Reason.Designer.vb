﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emp_Leaving_Reason
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_Leaving_Reason))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_HRM_Leave_ReasonBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_HRM_Leave_ReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_HRM_Leave_ReasonDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tbl_HRM_Leave_ReasonTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_Leave_ReasonTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_HRM_Leave_ReasonBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.SuspendLayout()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Leave_ReasonDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_HRM_Leave_ReasonBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_HRM_Leave_ReasonDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(200, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 535)
        Me.Panel1.TabIndex = 0
        '
        'Tbl_HRM_Leave_ReasonBindingNavigator
        '
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.BindingSource = Me.Tbl_HRM_Leave_ReasonBindingSource
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.DeleteItem = Nothing
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem, Me.EditToolStripButton, Me.CancelToolStripButton})
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.Name = "Tbl_HRM_Leave_ReasonBindingNavigator"
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.Size = New System.Drawing.Size(524, 25)
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.TabIndex = 2
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add New Leaving Reason"
        '
        'Tbl_HRM_Leave_ReasonBindingSource
        '
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataMember = "tbl_HRM_Leave_Reason"
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(49, 22)
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
        'Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem
        '
        Me.Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Name = "Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem"
        Me.Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem.Text = "Save Leaving Reason"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.edit_29
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "&Edit Leaving Reason"
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
        'Tbl_HRM_Leave_ReasonDataGridView
        '
        Me.Tbl_HRM_Leave_ReasonDataGridView.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tbl_HRM_Leave_ReasonDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_HRM_Leave_ReasonDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_HRM_Leave_ReasonDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_HRM_Leave_ReasonDataGridView.ColumnHeadersHeight = 32
        Me.Tbl_HRM_Leave_ReasonDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_HRM_Leave_ReasonDataGridView.DataSource = Me.Tbl_HRM_Leave_ReasonBindingSource
        Me.Tbl_HRM_Leave_ReasonDataGridView.Location = New System.Drawing.Point(1, 28)
        Me.Tbl_HRM_Leave_ReasonDataGridView.Name = "Tbl_HRM_Leave_ReasonDataGridView"
        Me.Tbl_HRM_Leave_ReasonDataGridView.ReadOnly = True
        Me.Tbl_HRM_Leave_ReasonDataGridView.RowHeadersWidth = 22
        Me.Tbl_HRM_Leave_ReasonDataGridView.Size = New System.Drawing.Size(520, 502)
        Me.Tbl_HRM_Leave_ReasonDataGridView.TabIndex = 0
        '
        'Tbl_HRM_Leave_ReasonTableAdapter
        '
        Me.Tbl_HRM_Leave_ReasonTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Me.Tbl_HRM_Leave_ReasonTableAdapter
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(931, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee Leaving Reasons"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ReasonID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Serial No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Reason"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Reasons"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'Emp_Leaving_Reason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 860)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Emp_Leaving_Reason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leaving Reason"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_HRM_Leave_ReasonBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.ResumeLayout(False)
        Me.Tbl_HRM_Leave_ReasonBindingNavigator.PerformLayout()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Leave_ReasonDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_Leave_ReasonBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Leave_ReasonTableAdapter As DSHRMTableAdapters.tbl_HRM_Leave_ReasonTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_Leave_ReasonBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_HRM_Leave_ReasonBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_HRM_Leave_ReasonDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents CancelToolStripButton As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
