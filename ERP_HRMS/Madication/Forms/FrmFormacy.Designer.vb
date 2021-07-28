<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFormacy
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFormacy))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMedication = New ERP_HRMS.DSMedication()
        Me.Tbl_HRM_Emp_Medication_PharmacyTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Medication_PharmacyTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSMedicationTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.SuspendLayout()
        CType(Me.Tbl_HRM_Emp_Medication_PharmacyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1147, 40)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Pharmaceutical Company"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_HRM_Emp_Medication_PharmacyDataGridView
        '
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1})
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.DataSource = Me.Tbl_HRM_Emp_Medication_PharmacyBindingSource
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.Name = "Tbl_HRM_Emp_Medication_PharmacyDataGridView"
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.ReadOnly = True
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.RowHeadersWidth = 20
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.Size = New System.Drawing.Size(959, 641)
        Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(44, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 674)
        Me.Panel1.TabIndex = 14
        '
        'Tbl_HRM_Emp_Medication_PharmacyBindingNavigator
        '
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.BindingSource = Me.Tbl_HRM_Emp_Medication_PharmacyBindingSource
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.DeleteItem = Nothing
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem, Me.EditToolStripButton, Me.CancelToolStripButton})
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.Name = "Tbl_HRM_Emp_Medication_PharmacyBindingNavigator"
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.Size = New System.Drawing.Size(962, 25)
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.TabIndex = 14
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem
        '
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Enabled = False
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Name = "Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem"
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.edit_29
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "ToolStripButton1"
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.images__1_
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelToolStripButton.Text = "ToolStripButton2"
        Me.CancelToolStripButton.Visible = False
        '
        'Tbl_HRM_Emp_Medication_PharmacyBindingSource
        '
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingSource.DataMember = "tbl_HRM_Emp_Medication_Pharmacy"
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingSource.DataSource = Me.DSMedication
        '
        'DSMedication
        '
        Me.DSMedication.DataSetName = "DSMedication"
        Me.DSMedication.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_Emp_Medication_PharmacyTableAdapter
        '
        Me.Tbl_HRM_Emp_Medication_PharmacyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Med_Item_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Med_ItemTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_INTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_PharmacyTableAdapter = Me.Tbl_HRM_Emp_Medication_PharmacyTableAdapter
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
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PharmacyName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Pharmacy Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ContactPerson"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contact Person"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Mobile"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Mobile"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Width = 80
        '
        'FrmFormacy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 766)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmFormacy"
        Me.Text = "FrmFormacy"
        CType(Me.Tbl_HRM_Emp_Medication_PharmacyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.ResumeLayout(False)
        Me.Tbl_HRM_Emp_Medication_PharmacyBindingNavigator.PerformLayout()
        CType(Me.Tbl_HRM_Emp_Medication_PharmacyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents DSMedication As DSMedication
    Friend WithEvents Tbl_HRM_Emp_Medication_PharmacyBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Medication_PharmacyTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Medication_PharmacyTableAdapter
    Friend WithEvents TableAdapterManager As DSMedicationTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_Emp_Medication_PharmacyDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Tbl_HRM_Emp_Medication_PharmacyBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_HRM_Emp_Medication_PharmacyBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents CancelToolStripButton As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
