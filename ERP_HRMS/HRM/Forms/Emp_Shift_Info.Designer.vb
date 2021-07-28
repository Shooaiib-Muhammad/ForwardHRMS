<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Emp_Shift_Info
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
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim ShiftSTLabel As System.Windows.Forms.Label
        Dim ShiftETLabel As System.Windows.Forms.Label
        Dim BreakSTLabel As System.Windows.Forms.Label
        Dim BreakETLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ShiftIDLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Emp_Shift_Info))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NormalRadioButton = New System.Windows.Forms.RadioButton()
        Me.NightAndFridayRadioButton = New System.Windows.Forms.RadioButton()
        Me.FridayBreakStatusRadioButton = New System.Windows.Forms.RadioButton()
        Me.ShiftIDTextBox = New System.Windows.Forms.TextBox()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.BreakSTDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ShiftSTDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BreakETDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ShiftETDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tbl_HRM_ShiftBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Tbl_HRM_ShiftBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ShiftNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        ShiftNameLabel = New System.Windows.Forms.Label()
        ShiftSTLabel = New System.Windows.Forms.Label()
        ShiftETLabel = New System.Windows.Forms.Label()
        BreakSTLabel = New System.Windows.Forms.Label()
        BreakETLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        ShiftIDLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_HRM_ShiftBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_HRM_ShiftBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.Location = New System.Drawing.Point(24, 135)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(62, 20)
        ShiftNameLabel.TabIndex = 3
        ShiftNameLabel.Text = "Shift Title:"
        '
        'ShiftSTLabel
        '
        ShiftSTLabel.Location = New System.Drawing.Point(24, 167)
        ShiftSTLabel.Name = "ShiftSTLabel"
        ShiftSTLabel.Size = New System.Drawing.Size(85, 20)
        ShiftSTLabel.TabIndex = 5
        ShiftSTLabel.Text = "Shift Start Time:"
        '
        'ShiftETLabel
        '
        ShiftETLabel.AutoSize = True
        ShiftETLabel.Location = New System.Drawing.Point(249, 167)
        ShiftETLabel.Name = "ShiftETLabel"
        ShiftETLabel.Size = New System.Drawing.Size(79, 13)
        ShiftETLabel.TabIndex = 7
        ShiftETLabel.Text = "Shift End Time:"
        '
        'BreakSTLabel
        '
        BreakSTLabel.AutoSize = True
        BreakSTLabel.Location = New System.Drawing.Point(24, 196)
        BreakSTLabel.Name = "BreakSTLabel"
        BreakSTLabel.Size = New System.Drawing.Size(89, 13)
        BreakSTLabel.TabIndex = 9
        BreakSTLabel.Text = "Break Start Time:"
        '
        'BreakETLabel
        '
        BreakETLabel.AutoSize = True
        BreakETLabel.Location = New System.Drawing.Point(249, 197)
        BreakETLabel.Name = "BreakETLabel"
        BreakETLabel.Size = New System.Drawing.Size(86, 13)
        BreakETLabel.TabIndex = 11
        BreakETLabel.Text = "Break End Time:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(24, 232)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 13
        StatusLabel.Text = "Status:"
        '
        'ShiftIDLabel
        '
        ShiftIDLabel.AutoSize = True
        ShiftIDLabel.Location = New System.Drawing.Point(24, 106)
        ShiftIDLabel.Name = "ShiftIDLabel"
        ShiftIDLabel.Size = New System.Drawing.Size(53, 13)
        ShiftIDLabel.TabIndex = 14
        ShiftIDLabel.Text = "Serial No:"
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(314, 106)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 20)
        Label2.TabIndex = 19
        Label2.Text = "Shift Name :"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(ShiftIDLabel)
        Me.Panel1.Controls.Add(Me.ShiftIDTextBox)
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(Me.StatusCheckBox)
        Me.Panel1.Controls.Add(Me.BreakSTDateTimePicker)
        Me.Panel1.Controls.Add(Me.ShiftSTDateTimePicker)
        Me.Panel1.Controls.Add(Me.BreakETDateTimePicker)
        Me.Panel1.Controls.Add(BreakSTLabel)
        Me.Panel1.Controls.Add(BreakETLabel)
        Me.Panel1.Controls.Add(ShiftSTLabel)
        Me.Panel1.Controls.Add(Me.ShiftETDateTimePicker)
        Me.Panel1.Controls.Add(ShiftETLabel)
        Me.Panel1.Controls.Add(Me.Tbl_HRM_ShiftBindingNavigator)
        Me.Panel1.Controls.Add(Me.ShiftNameTextBox)
        Me.Panel1.Controls.Add(ShiftNameLabel)
        Me.Panel1.Location = New System.Drawing.Point(247, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 271)
        Me.Panel1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_ShiftBindingSource, "Shift", True))
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Day", "Night"})
        Me.ComboBox1.Location = New System.Drawing.Point(380, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(72, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NormalRadioButton)
        Me.GroupBox1.Controls.Add(Me.NightAndFridayRadioButton)
        Me.GroupBox1.Controls.Add(Me.FridayBreakStatusRadioButton)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(52, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 49)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Friday Break Adjustment"
        '
        'NormalRadioButton
        '
        Me.NormalRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Tbl_HRM_ShiftBindingSource, "Normal", True))
        Me.NormalRadioButton.Location = New System.Drawing.Point(189, 17)
        Me.NormalRadioButton.Name = "NormalRadioButton"
        Me.NormalRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.NormalRadioButton.TabIndex = 5
        Me.NormalRadioButton.Text = "Non-Adjustment"
        Me.NormalRadioButton.UseVisualStyleBackColor = True
        '
        'NightAndFridayRadioButton
        '
        Me.NightAndFridayRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Tbl_HRM_ShiftBindingSource, "NightAndFriday", True))
        Me.NightAndFridayRadioButton.Location = New System.Drawing.Point(109, 17)
        Me.NightAndFridayRadioButton.Name = "NightAndFridayRadioButton"
        Me.NightAndFridayRadioButton.Size = New System.Drawing.Size(107, 24)
        Me.NightAndFridayRadioButton.TabIndex = 3
        Me.NightAndFridayRadioButton.Text = "Night Shift"
        Me.NightAndFridayRadioButton.UseVisualStyleBackColor = True
        '
        'FridayBreakStatusRadioButton
        '
        Me.FridayBreakStatusRadioButton.Checked = True
        Me.FridayBreakStatusRadioButton.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.Tbl_HRM_ShiftBindingSource, "FridayBreakStatus", True))
        Me.FridayBreakStatusRadioButton.Location = New System.Drawing.Point(8, 17)
        Me.FridayBreakStatusRadioButton.Name = "FridayBreakStatusRadioButton"
        Me.FridayBreakStatusRadioButton.Size = New System.Drawing.Size(88, 24)
        Me.FridayBreakStatusRadioButton.TabIndex = 1
        Me.FridayBreakStatusRadioButton.TabStop = True
        Me.FridayBreakStatusRadioButton.Text = "Day Shift"
        Me.FridayBreakStatusRadioButton.UseVisualStyleBackColor = True
        '
        'ShiftIDTextBox
        '
        Me.ShiftIDTextBox.BackColor = System.Drawing.Color.White
        Me.ShiftIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_ShiftBindingSource, "ShiftID", True))
        Me.ShiftIDTextBox.Location = New System.Drawing.Point(114, 103)
        Me.ShiftIDTextBox.Name = "ShiftIDTextBox"
        Me.ShiftIDTextBox.ReadOnly = True
        Me.ShiftIDTextBox.Size = New System.Drawing.Size(71, 20)
        Me.ShiftIDTextBox.TabIndex = 15
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_ShiftBindingSource, "Status", True))
        Me.StatusCheckBox.Enabled = False
        Me.StatusCheckBox.Location = New System.Drawing.Point(113, 227)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(21, 24)
        Me.StatusCheckBox.TabIndex = 14
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'BreakSTDateTimePicker
        '
        Me.BreakSTDateTimePicker.CustomFormat = "hh:mm tt"
        Me.BreakSTDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_HRM_ShiftBindingSource, "BreakST", True))
        Me.BreakSTDateTimePicker.Enabled = False
        Me.BreakSTDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.BreakSTDateTimePicker.Location = New System.Drawing.Point(114, 193)
        Me.BreakSTDateTimePicker.Name = "BreakSTDateTimePicker"
        Me.BreakSTDateTimePicker.Size = New System.Drawing.Size(110, 20)
        Me.BreakSTDateTimePicker.TabIndex = 10
        '
        'ShiftSTDateTimePicker
        '
        Me.ShiftSTDateTimePicker.CustomFormat = "hh:mm tt"
        Me.ShiftSTDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_HRM_ShiftBindingSource, "ShiftST", True))
        Me.ShiftSTDateTimePicker.Enabled = False
        Me.ShiftSTDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ShiftSTDateTimePicker.Location = New System.Drawing.Point(114, 164)
        Me.ShiftSTDateTimePicker.Name = "ShiftSTDateTimePicker"
        Me.ShiftSTDateTimePicker.Size = New System.Drawing.Size(110, 20)
        Me.ShiftSTDateTimePicker.TabIndex = 6
        '
        'BreakETDateTimePicker
        '
        Me.BreakETDateTimePicker.CustomFormat = "hh:mm tt"
        Me.BreakETDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_HRM_ShiftBindingSource, "BreakET", True))
        Me.BreakETDateTimePicker.Enabled = False
        Me.BreakETDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.BreakETDateTimePicker.Location = New System.Drawing.Point(342, 193)
        Me.BreakETDateTimePicker.Name = "BreakETDateTimePicker"
        Me.BreakETDateTimePicker.Size = New System.Drawing.Size(110, 20)
        Me.BreakETDateTimePicker.TabIndex = 12
        '
        'ShiftETDateTimePicker
        '
        Me.ShiftETDateTimePicker.CustomFormat = "hh:mm tt"
        Me.ShiftETDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_HRM_ShiftBindingSource, "ShiftET", True))
        Me.ShiftETDateTimePicker.Enabled = False
        Me.ShiftETDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ShiftETDateTimePicker.Location = New System.Drawing.Point(342, 164)
        Me.ShiftETDateTimePicker.Name = "ShiftETDateTimePicker"
        Me.ShiftETDateTimePicker.Size = New System.Drawing.Size(110, 20)
        Me.ShiftETDateTimePicker.TabIndex = 8
        '
        'Tbl_HRM_ShiftBindingNavigator
        '
        Me.Tbl_HRM_ShiftBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_HRM_ShiftBindingNavigator.BindingSource = Me.Tbl_HRM_ShiftBindingSource
        Me.Tbl_HRM_ShiftBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_HRM_ShiftBindingNavigator.DeleteItem = Nothing
        Me.Tbl_HRM_ShiftBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_HRM_ShiftBindingNavigatorSaveItem, Me.EditToolStripButton, Me.CancelToolStripButton})
        Me.Tbl_HRM_ShiftBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_HRM_ShiftBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_HRM_ShiftBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_HRM_ShiftBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_HRM_ShiftBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_HRM_ShiftBindingNavigator.Name = "Tbl_HRM_ShiftBindingNavigator"
        Me.Tbl_HRM_ShiftBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_HRM_ShiftBindingNavigator.Size = New System.Drawing.Size(476, 25)
        Me.Tbl_HRM_ShiftBindingNavigator.TabIndex = 3
        Me.Tbl_HRM_ShiftBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add New Shift"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'Tbl_HRM_ShiftBindingNavigatorSaveItem
        '
        Me.Tbl_HRM_ShiftBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_HRM_ShiftBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_HRM_ShiftBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_HRM_ShiftBindingNavigatorSaveItem.Name = "Tbl_HRM_ShiftBindingNavigatorSaveItem"
        Me.Tbl_HRM_ShiftBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_HRM_ShiftBindingNavigatorSaveItem.Text = "Save  Shift"
        '
        'EditToolStripButton
        '
        Me.EditToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditToolStripButton.Image = Global.ERP_HRMS.My.Resources.Resources.edit_29
        Me.EditToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditToolStripButton.Name = "EditToolStripButton"
        Me.EditToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EditToolStripButton.Text = "&Edit Shift"
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
        'ShiftNameTextBox
        '
        Me.ShiftNameTextBox.BackColor = System.Drawing.Color.White
        Me.ShiftNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_ShiftBindingSource, "ShiftName", True))
        Me.ShiftNameTextBox.Location = New System.Drawing.Point(113, 132)
        Me.ShiftNameTextBox.Name = "ShiftNameTextBox"
        Me.ShiftNameTextBox.ReadOnly = True
        Me.ShiftNameTextBox.Size = New System.Drawing.Size(339, 20)
        Me.ShiftNameTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(931, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Shift Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_HRM_ShiftTableAdapter
        '
        Me.Tbl_HRM_ShiftTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary_NewTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_disability_descptionTableAdapter = Nothing
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
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Me.Tbl_HRM_ShiftTableAdapter
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Emp_Shift_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(931, 425)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Emp_Shift_Info"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shift Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Tbl_HRM_ShiftBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_HRM_ShiftBindingNavigator.ResumeLayout(False)
        Me.Tbl_HRM_ShiftBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents BreakETDateTimePicker As DateTimePicker
    Friend WithEvents BreakSTDateTimePicker As DateTimePicker
    Friend WithEvents ShiftETDateTimePicker As DateTimePicker
    Friend WithEvents ShiftSTDateTimePicker As DateTimePicker
    Friend WithEvents ShiftNameTextBox As TextBox
    Friend WithEvents Tbl_HRM_ShiftBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_HRM_ShiftBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents CancelToolStripButton As ToolStripButton
    Friend WithEvents StatusCheckBox As CheckBox
    Friend WithEvents ShiftIDTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NormalRadioButton As RadioButton
    Friend WithEvents NightAndFridayRadioButton As RadioButton
    Friend WithEvents FridayBreakStatusRadioButton As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
End Class
