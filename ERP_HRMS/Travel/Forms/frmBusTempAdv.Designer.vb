<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusTempAdv
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusTempAdv))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Tbl_Bus_TempAdvBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.Tbl_Bus_TempAdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBusChages = New ERP_HRMS.DSBusChages
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Tbl_Bus_TempAdvBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Tbl_Bus_TempAdvDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.Tbl_Bus_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBusAtt = New ERP_HRMS.DSBusAtt
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.Tbl_Bus_Comp_InfoTableAdapter = New ERP_HRMS.DSBusAttTableAdapters.tbl_Bus_Comp_InfoTableAdapter
        Me.TableAdapterManager1 = New ERP_HRMS.DSBusAttTableAdapters.TableAdapterManager
        Me.Tbl_Bus_TempAdvTableAdapter = New ERP_HRMS.DSBusChagesTableAdapters.tbl_Bus_TempAdvTableAdapter
        Me.TableAdapterManager = New ERP_HRMS.DSBusChagesTableAdapters.TableAdapterManager
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Bus_TempAdvBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Bus_TempAdvBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Bus_TempAdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBusChages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bus_TempAdvDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bus_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBusAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_Bus_TempAdvBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_Bus_TempAdvDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(6, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1017, 801)
        Me.Panel1.TabIndex = 0
        '
        'Tbl_Bus_TempAdvBindingNavigator
        '
        Me.Tbl_Bus_TempAdvBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Bus_TempAdvBindingNavigator.BindingSource = Me.Tbl_Bus_TempAdvBindingSource
        Me.Tbl_Bus_TempAdvBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Bus_TempAdvBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Bus_TempAdvBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Bus_TempAdvBindingNavigatorSaveItem})
        Me.Tbl_Bus_TempAdvBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Bus_TempAdvBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Bus_TempAdvBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Bus_TempAdvBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Bus_TempAdvBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Bus_TempAdvBindingNavigator.Name = "Tbl_Bus_TempAdvBindingNavigator"
        Me.Tbl_Bus_TempAdvBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Bus_TempAdvBindingNavigator.Size = New System.Drawing.Size(1015, 25)
        Me.Tbl_Bus_TempAdvBindingNavigator.TabIndex = 1
        Me.Tbl_Bus_TempAdvBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Bus_TempAdvBindingSource
        '
        Me.Tbl_Bus_TempAdvBindingSource.DataMember = "tbl_Bus_TempAdv"
        Me.Tbl_Bus_TempAdvBindingSource.DataSource = Me.DSBusChages
        '
        'DSBusChages
        '
        Me.DSBusChages.DataSetName = "DSBusChages"
        Me.DSBusChages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Tbl_Bus_TempAdvBindingNavigatorSaveItem
        '
        Me.Tbl_Bus_TempAdvBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Bus_TempAdvBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Bus_TempAdvBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Bus_TempAdvBindingNavigatorSaveItem.Name = "Tbl_Bus_TempAdvBindingNavigatorSaveItem"
        Me.Tbl_Bus_TempAdvBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Bus_TempAdvBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_Bus_TempAdvDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tbl_Bus_TempAdvDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Bus_TempAdvDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Bus_TempAdvDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_Bus_TempAdvDataGridView.ColumnHeadersHeight = 32
        Me.Tbl_Bus_TempAdvDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Tbl_Bus_TempAdvDataGridView.DataSource = Me.Tbl_Bus_TempAdvBindingSource
        Me.Tbl_Bus_TempAdvDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_Bus_TempAdvDataGridView.Name = "Tbl_Bus_TempAdvDataGridView"
        Me.Tbl_Bus_TempAdvDataGridView.Size = New System.Drawing.Size(1009, 768)
        Me.Tbl_Bus_TempAdvDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TranID"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BusID"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.Tbl_Bus_Comp_InfoBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.DisplayMember = "BusCardNo"
        Me.DataGridViewTextBoxColumn2.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bus Code#"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "BUSID"
        '
        'Tbl_Bus_Comp_InfoBindingSource
        '
        Me.Tbl_Bus_Comp_InfoBindingSource.DataMember = "tbl_Bus_Comp_Info"
        Me.Tbl_Bus_Comp_InfoBindingSource.DataSource = Me.DSBusAtt
        '
        'DSBusAtt
        '
        Me.DSBusAtt.DataSetName = "DSBusAtt"
        Me.DSBusAtt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Amt"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amt"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EntryDate"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "d"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "EntryDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Description"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 500
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1284, 40)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Transport Temporary Advance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Bus_Comp_InfoTableAdapter
        '
        Me.Tbl_Bus_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Bus_AttTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSBusAttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Bus_TempAdvTableAdapter
        '
        Me.Tbl_Bus_TempAdvTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Bus_AddAmountTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Bus_FineTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Bus_TempAdvTableAdapter = Me.Tbl_Bus_TempAdvTableAdapter
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSBusChagesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(84, 44)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker2.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Entry Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmBusTempAdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 1006)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmBusTempAdv"
        Me.Text = "Transport Temporary Advance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Bus_TempAdvBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Bus_TempAdvBindingNavigator.ResumeLayout(False)
        Me.Tbl_Bus_TempAdvBindingNavigator.PerformLayout()
        CType(Me.Tbl_Bus_TempAdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBusChages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bus_TempAdvDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bus_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBusAtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DSBusChages As ERP_HRMS.DSBusChages
    Friend WithEvents Tbl_Bus_TempAdvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_TempAdvTableAdapter As ERP_HRMS.DSBusChagesTableAdapters.tbl_Bus_TempAdvTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSBusChagesTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Bus_TempAdvBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Bus_TempAdvBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Bus_TempAdvDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSBusAtt As ERP_HRMS.DSBusAtt
    Friend WithEvents Tbl_Bus_Comp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_Comp_InfoTableAdapter As ERP_HRMS.DSBusAttTableAdapters.tbl_Bus_Comp_InfoTableAdapter
    Friend WithEvents TableAdapterManager1 As ERP_HRMS.DSBusAttTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
