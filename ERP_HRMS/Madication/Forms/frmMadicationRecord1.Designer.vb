<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMadicationRecord1
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
        Dim DeptIDLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMadicationRecord1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DeptIDTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMedication = New ERP_HRMS.DSMedication()
        Me.DeptNameTextBox = New System.Windows.Forms.TextBox()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Medication_Rec_HeadTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSMedicationTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        DeptIDLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeptIDLabel
        '
        DeptIDLabel.AutoSize = True
        DeptIDLabel.Location = New System.Drawing.Point(8, 45)
        DeptIDLabel.Name = "DeptIDLabel"
        DeptIDLabel.Size = New System.Drawing.Size(53, 13)
        DeptIDLabel.TabIndex = 15
        DeptIDLabel.Text = "Serial No:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(659, 46)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 13
        StatusLabel.Text = "Status:"
        '
        'DeptNameLabel
        '
        DeptNameLabel.Location = New System.Drawing.Point(133, 45)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(70, 13)
        DeptNameLabel.TabIndex = 12
        DeptNameLabel.Text = "Category :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(DeptIDLabel)
        Me.Panel1.Controls.Add(Me.DeptIDTextBox)
        Me.Panel1.Controls.Add(Me.DeptNameTextBox)
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(Me.StatusCheckBox)
        Me.Panel1.Controls.Add(DeptNameLabel)
        Me.Panel1.Controls.Add(Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator)
        Me.Panel1.Location = New System.Drawing.Point(35, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 81)
        Me.Panel1.TabIndex = 0
        '
        'DeptIDTextBox
        '
        Me.DeptIDTextBox.BackColor = System.Drawing.Color.White
        Me.DeptIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource, "IDH", True))
        Me.DeptIDTextBox.Location = New System.Drawing.Point(63, 41)
        Me.DeptIDTextBox.Name = "DeptIDTextBox"
        Me.DeptIDTextBox.ReadOnly = True
        Me.DeptIDTextBox.Size = New System.Drawing.Size(60, 20)
        Me.DeptIDTextBox.TabIndex = 16
        Me.DeptIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tbl_HRM_Emp_Medication_Rec_HeadBindingSource
        '
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource.DataMember = "tbl_HRM_Emp_Medication_Rec_Head"
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource.DataSource = Me.DSMedication
        '
        'DSMedication
        '
        Me.DSMedication.DataSetName = "DSMedication"
        Me.DSMedication.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeptNameTextBox
        '
        Me.DeptNameTextBox.BackColor = System.Drawing.Color.White
        Me.DeptNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource, "MadicationHead", True))
        Me.DeptNameTextBox.Location = New System.Drawing.Point(202, 41)
        Me.DeptNameTextBox.Name = "DeptNameTextBox"
        Me.DeptNameTextBox.ReadOnly = True
        Me.DeptNameTextBox.Size = New System.Drawing.Size(359, 20)
        Me.DeptNameTextBox.TabIndex = 11
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.Enabled = False
        Me.StatusCheckBox.Location = New System.Drawing.Point(705, 41)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.StatusCheckBox.TabIndex = 14
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator
        '
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.BindingSource = Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.DeleteItem = Nothing
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem, Me.ToolStripButton8, Me.ToolStripButton9})
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.Name = "Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator"
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.Size = New System.Drawing.Size(582, 25)
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.TabIndex = 2
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
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
        'Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem
        '
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem.Name = "Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem"
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.ERP_HRMS.My.Resources.Resources.edit_29
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        Me.ToolStripButton8.ToolTipText = "Edit Date"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = Global.ERP_HRMS.My.Resources.Resources.images__1_
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "ToolStripButton9"
        Me.ToolStripButton9.ToolTipText = "Cancel"
        Me.ToolStripButton9.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Controls.Add(Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView)
        Me.Panel2.Location = New System.Drawing.Point(35, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 636)
        Me.Panel2.TabIndex = 1
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton1
        Me.BindingNavigator1.BindingSource = Me.Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton7, Me.EditToolStripButton, Me.CancelToolStripButton})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton3
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton6
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton5
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton4
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(582, 25)
        Me.BindingNavigator1.TabIndex = 3
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        '
        'Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource
        '
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource.DataMember = "tbl_HRM_Emp_Medication_Rec_Head_tbl_HRM_Emp_Medication_Rec_Details"
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource.DataSource = Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Enabled = False
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Save Data"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.edit_29
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "ToolStripButton10"
        Me.EditToolStripButton.ToolTipText = "Edit Date"
        '
        'CancelToolStripButton
        '
        Me.CancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.images__1_
        Me.CancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelToolStripButton.Name = "CancelToolStripButton"
        Me.CancelToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.CancelToolStripButton.Text = "ToolStripButton11"
        Me.CancelToolStripButton.ToolTipText = "Cancel"
        Me.CancelToolStripButton.Visible = False
        '
        'Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Status})
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.DataSource = Me.Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.Name = "Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView"
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.ReadOnly = True
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.RowHeadersWidth = 20
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.Size = New System.Drawing.Size(576, 603)
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDH"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDH"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Madication"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Madication"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 400
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 80
        '
        'Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter
        '
        Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Med_Item_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Med_ItemTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_INTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter = Me.Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_Rec_HeadTableAdapter = Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter
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
        'Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter
        '
        Me.Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(931, 40)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Treatment Category Setting"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMadicationRecord1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 796)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMadicationRecord1"
        Me.Text = "frmMadicationRecord1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.ResumeLayout(False)
        Me.Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DSMedication As DSMedication
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_HeadBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Medication_Rec_HeadTableAdapter
    Friend WithEvents TableAdapterManager As DSMedicationTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_HeadBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Medication_Rec_DetailsTableAdapter
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_DetailsBindingSource As BindingSource
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents Tbl_HRM_Emp_Medication_Rec_DetailsDataGridView As DataGridView
    Friend WithEvents DeptIDTextBox As TextBox
    Friend WithEvents DeptNameTextBox As TextBox
    Friend WithEvents StatusCheckBox As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents CancelToolStripButton As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewCheckBoxColumn
End Class
