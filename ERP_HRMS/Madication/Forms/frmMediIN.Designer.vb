<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMediIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMediIN))
        Me.DSMedication = New ERP_HRMS.DSMedication()
        Me.Tbl_HRM_Emp_Medication_INBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Medication_INTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Medication_INTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSMedicationTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Med_ItemTableAdapter()
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TranDateToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TranDateToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_HRM_Emp_Medication_INDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_HRM_Emp_Med_ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Medication_INBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Medication_INBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.Tbl_HRM_Emp_Medication_INDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Med_ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DSMedication
        '
        Me.DSMedication.DataSetName = "DSMedication"
        Me.DSMedication.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_Emp_Medication_INBindingSource
        '
        Me.Tbl_HRM_Emp_Medication_INBindingSource.DataMember = "tbl_HRM_Emp_Medication_IN"
        Me.Tbl_HRM_Emp_Medication_INBindingSource.DataSource = Me.DSMedication
        '
        'Tbl_HRM_Emp_Medication_INTableAdapter
        '
        Me.Tbl_HRM_Emp_Medication_INTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Med_Item_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Med_ItemTableAdapter = Me.Tbl_HRM_Emp_Med_ItemTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_INTableAdapter = Me.Tbl_HRM_Emp_Medication_INTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_PharmacyTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_Rec_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_MedicationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSMedicationTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_Diagnosis_Category_1TableAdapter = Nothing
        Me.TableAdapterManager.View_Diagnosis_Category_2TableAdapter = Nothing
        Me.TableAdapterManager.View_Diagnosis_Category_3TableAdapter = Nothing
        Me.TableAdapterManager.View_Diagnosis_Category_4TableAdapter = Nothing
        Me.TableAdapterManager.View_Diagnosis_Category_5TableAdapter = Nothing
        Me.TableAdapterManager.View_Recommended_Test_1TableAdapter = Nothing
        Me.TableAdapterManager.View_Recommended_Test_2TableAdapter = Nothing
        Me.TableAdapterManager.View_Recommended_Test_3TableAdapter = Nothing
        Me.TableAdapterManager.View_Recommended_Test_41TableAdapter = Nothing
        Me.TableAdapterManager.View_Recommended_Test_4TableAdapter = Nothing
        Me.TableAdapterManager.View_Refer_ToTableAdapter = Nothing
        Me.TableAdapterManager.View_Treatment_Category_1TableAdapter = Nothing
        Me.TableAdapterManager.View_Treatment_Category_2TableAdapter = Nothing
        Me.TableAdapterManager.View_Treatment_Category_3TableAdapter = Nothing
        Me.TableAdapterManager.View_Treatment_Category_4TableAdapter = Nothing
        Me.TableAdapterManager.View_Treatment_Category_5TableAdapter = Nothing
        '
        'Tbl_HRM_Emp_Med_ItemTableAdapter
        '
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Emp_Medication_INBindingNavigator
        '
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.BindingSource = Me.Tbl_HRM_Emp_Medication_INBindingSource
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem})
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.Name = "Tbl_HRM_Emp_Medication_INBindingNavigator"
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.Size = New System.Drawing.Size(764, 25)
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.TabIndex = 0
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem
        '
        Me.Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Name = "Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem"
        Me.Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TranDateToolStripLabel, Me.TranDateToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(764, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'TranDateToolStripLabel
        '
        Me.TranDateToolStripLabel.Name = "TranDateToolStripLabel"
        Me.TranDateToolStripLabel.Size = New System.Drawing.Size(58, 22)
        Me.TranDateToolStripLabel.Text = "TranDate:"
        '
        'TranDateToolStripTextBox
        '
        Me.TranDateToolStripTextBox.Name = "TranDateToolStripTextBox"
        Me.TranDateToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'Tbl_HRM_Emp_Medication_INDataGridView
        '
        Me.Tbl_HRM_Emp_Medication_INDataGridView.AutoGenerateColumns = False
        Me.Tbl_HRM_Emp_Medication_INDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_HRM_Emp_Medication_INDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_HRM_Emp_Medication_INDataGridView.DataSource = Me.Tbl_HRM_Emp_Medication_INBindingSource
        Me.Tbl_HRM_Emp_Medication_INDataGridView.Location = New System.Drawing.Point(28, 80)
        Me.Tbl_HRM_Emp_Medication_INDataGridView.Name = "Tbl_HRM_Emp_Medication_INDataGridView"
        Me.Tbl_HRM_Emp_Medication_INDataGridView.Size = New System.Drawing.Size(216, 220)
        Me.Tbl_HRM_Emp_Medication_INDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TransInID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TransInID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TranDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TranDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.Tbl_HRM_Emp_Med_ItemBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "L2Name"
        Me.DataGridViewTextBoxColumn3.DisplayStyleForCurrentCellOnly = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "L2ID"
        '
        'Tbl_HRM_Emp_Med_ItemBindingSource
        '
        Me.Tbl_HRM_Emp_Med_ItemBindingSource.DataMember = "tbl_HRM_Emp_Med_Item"
        Me.Tbl_HRM_Emp_Med_ItemBindingSource.DataSource = Me.DSMedication
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Madication"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Madication"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UOM"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'frmMediIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 609)
        Me.Controls.Add(Me.Tbl_HRM_Emp_Medication_INDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.Tbl_HRM_Emp_Medication_INBindingNavigator)
        Me.Name = "frmMediIN"
        Me.Text = "frmMediIN"
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Medication_INBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Medication_INBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.ResumeLayout(False)
        Me.Tbl_HRM_Emp_Medication_INBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.Tbl_HRM_Emp_Medication_INDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Med_ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSMedication As DSMedication
    Friend WithEvents Tbl_HRM_Emp_Medication_INBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Medication_INTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Medication_INTableAdapter
    Friend WithEvents TableAdapterManager As DSMedicationTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_Emp_Medication_INBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_HRM_Emp_Medication_INBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FillToolStrip As ToolStrip
    Friend WithEvents TranDateToolStripLabel As ToolStripLabel
    Friend WithEvents TranDateToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillToolStripButton As ToolStripButton
    Friend WithEvents Tbl_HRM_Emp_Medication_INDataGridView As DataGridView
    Friend WithEvents Tbl_HRM_Emp_Med_ItemTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Med_ItemTableAdapter
    Friend WithEvents Tbl_HRM_Emp_Med_ItemBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
