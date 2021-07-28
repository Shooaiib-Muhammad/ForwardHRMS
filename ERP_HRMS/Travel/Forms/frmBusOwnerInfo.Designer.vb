<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusOwnerInfo
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
        Dim OwnerIDLabel As System.Windows.Forms.Label
        Dim OwnerNameLabel As System.Windows.Forms.Label
        Dim CNICLabel As System.Windows.Forms.Label
        Dim MobileNoLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBusOwnerInfo))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Bus_OwnerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Bus_OwnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBusInfo = New ERP_HRMS.DSBusInfo()
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
        Me.Tbl_Bus_OwnerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Bus_OwnerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmpPic = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnUploadPic = New System.Windows.Forms.Button()
        Me.ArtSnapPictureBox = New System.Windows.Forms.PictureBox()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.MobileNoTextBox = New System.Windows.Forms.TextBox()
        Me.CNICTextBox = New System.Windows.Forms.TextBox()
        Me.OwnerNameTextBox = New System.Windows.Forms.TextBox()
        Me.CMModelName = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchModelName = New System.Windows.Forms.ToolStripTextBox()
        Me.RFModelName = New System.Windows.Forms.ToolStripMenuItem()
        Me.OwnerIDLabel1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Tbl_Bus_OwnerTableAdapter = New ERP_HRMS.DSBusInfoTableAdapters.tbl_Bus_OwnerTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSBusInfoTableAdapters.TableAdapterManager()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        OwnerIDLabel = New System.Windows.Forms.Label()
        OwnerNameLabel = New System.Windows.Forms.Label()
        CNICLabel = New System.Windows.Forms.Label()
        MobileNoLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CType(Me.Tbl_Bus_OwnerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Bus_OwnerBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Bus_OwnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBusInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bus_OwnerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ArtSnapPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMModelName.SuspendLayout()
        Me.SuspendLayout()
        '
        'OwnerIDLabel
        '
        OwnerIDLabel.Location = New System.Drawing.Point(19, 35)
        OwnerIDLabel.Name = "OwnerIDLabel"
        OwnerIDLabel.Size = New System.Drawing.Size(59, 20)
        OwnerIDLabel.TabIndex = 5
        OwnerIDLabel.Text = "Sr. No.:"
        OwnerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OwnerNameLabel
        '
        OwnerNameLabel.Location = New System.Drawing.Point(4, 60)
        OwnerNameLabel.Name = "OwnerNameLabel"
        OwnerNameLabel.Size = New System.Drawing.Size(74, 20)
        OwnerNameLabel.TabIndex = 6
        OwnerNameLabel.Text = "Owner Name:"
        OwnerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CNICLabel
        '
        CNICLabel.Location = New System.Drawing.Point(19, 85)
        CNICLabel.Name = "CNICLabel"
        CNICLabel.Size = New System.Drawing.Size(59, 20)
        CNICLabel.TabIndex = 7
        CNICLabel.Text = "CNIC:"
        CNICLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MobileNoLabel
        '
        MobileNoLabel.Location = New System.Drawing.Point(14, 110)
        MobileNoLabel.Name = "MobileNoLabel"
        MobileNoLabel.Size = New System.Drawing.Size(64, 20)
        MobileNoLabel.TabIndex = 8
        MobileNoLabel.Text = "Mobile No:"
        MobileNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressLabel
        '
        AddressLabel.Location = New System.Drawing.Point(19, 135)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(59, 20)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bus Owners Info."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Bus_OwnerBindingNavigator
        '
        Me.Tbl_Bus_OwnerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Bus_OwnerBindingNavigator.BindingSource = Me.Tbl_Bus_OwnerBindingSource
        Me.Tbl_Bus_OwnerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Bus_OwnerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Bus_OwnerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Bus_OwnerBindingNavigatorSaveItem})
        Me.Tbl_Bus_OwnerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Bus_OwnerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Bus_OwnerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Bus_OwnerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Bus_OwnerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Bus_OwnerBindingNavigator.Name = "Tbl_Bus_OwnerBindingNavigator"
        Me.Tbl_Bus_OwnerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Bus_OwnerBindingNavigator.Size = New System.Drawing.Size(754, 25)
        Me.Tbl_Bus_OwnerBindingNavigator.TabIndex = 5
        Me.Tbl_Bus_OwnerBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Bus_OwnerBindingSource
        '
        Me.Tbl_Bus_OwnerBindingSource.DataMember = "tbl_Bus_Owner"
        Me.Tbl_Bus_OwnerBindingSource.DataSource = Me.DSBusInfo
        '
        'DSBusInfo
        '
        Me.DSBusInfo.DataSetName = "DSBusInfo"
        Me.DSBusInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Tbl_Bus_OwnerBindingNavigatorSaveItem
        '
        Me.Tbl_Bus_OwnerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Bus_OwnerBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Bus_OwnerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Bus_OwnerBindingNavigatorSaveItem.Name = "Tbl_Bus_OwnerBindingNavigatorSaveItem"
        Me.Tbl_Bus_OwnerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Bus_OwnerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_Bus_OwnerDataGridView
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Bus_OwnerDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.Tbl_Bus_OwnerDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Bus_OwnerDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.Tbl_Bus_OwnerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_Bus_OwnerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn1, Me.EmpPic})
        Me.Tbl_Bus_OwnerDataGridView.DataSource = Me.Tbl_Bus_OwnerBindingSource
        Me.Tbl_Bus_OwnerDataGridView.Location = New System.Drawing.Point(93, 305)
        Me.Tbl_Bus_OwnerDataGridView.Name = "Tbl_Bus_OwnerDataGridView"
        Me.Tbl_Bus_OwnerDataGridView.Size = New System.Drawing.Size(844, 135)
        Me.Tbl_Bus_OwnerDataGridView.TabIndex = 5
        Me.Tbl_Bus_OwnerDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OwnerID"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sr.No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OwnerName"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn2.HeaderText = "Owner Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CNIC"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn3.HeaderText = "CNIC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MobileNo"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mobile No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 650
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'EmpPic
        '
        Me.EmpPic.DataPropertyName = "EmpPic"
        Me.EmpPic.HeaderText = "EmpPic"
        Me.EmpPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.EmpPic.Name = "EmpPic"
        Me.EmpPic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EmpPic.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnUploadPic)
        Me.Panel1.Controls.Add(Me.ArtSnapPictureBox)
        Me.Panel1.Controls.Add(Me.StatusCheckBox)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.AddressTextBox)
        Me.Panel1.Controls.Add(MobileNoLabel)
        Me.Panel1.Controls.Add(Me.MobileNoTextBox)
        Me.Panel1.Controls.Add(CNICLabel)
        Me.Panel1.Controls.Add(Me.CNICTextBox)
        Me.Panel1.Controls.Add(OwnerNameLabel)
        Me.Panel1.Controls.Add(Me.OwnerNameTextBox)
        Me.Panel1.Controls.Add(OwnerIDLabel)
        Me.Panel1.Controls.Add(Me.OwnerIDLabel1)
        Me.Panel1.Controls.Add(Me.Tbl_Bus_OwnerBindingNavigator)
        Me.Panel1.Location = New System.Drawing.Point(220, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 220)
        Me.Panel1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1098, 193)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnUploadPic
        '
        Me.btnUploadPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadPic.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnUploadPic.Location = New System.Drawing.Point(473, 164)
        Me.btnUploadPic.Name = "btnUploadPic"
        Me.btnUploadPic.Size = New System.Drawing.Size(94, 39)
        Me.btnUploadPic.TabIndex = 58
        Me.btnUploadPic.Text = "Upload Image"
        Me.btnUploadPic.UseVisualStyleBackColor = True
        '
        'ArtSnapPictureBox
        '
        Me.ArtSnapPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ArtSnapPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ArtSnapPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_Bus_OwnerBindingSource, "EmpPic", True))
        Me.ArtSnapPictureBox.InitialImage = Nothing
        Me.ArtSnapPictureBox.Location = New System.Drawing.Point(573, 16)
        Me.ArtSnapPictureBox.Name = "ArtSnapPictureBox"
        Me.ArtSnapPictureBox.Size = New System.Drawing.Size(157, 187)
        Me.ArtSnapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ArtSnapPictureBox.TabIndex = 57
        Me.ArtSnapPictureBox.TabStop = False
        Me.ArtSnapPictureBox.WaitOnLoad = True
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Bus_OwnerBindingSource, "Status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(45, 164)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(56, 20)
        Me.StatusCheckBox.TabIndex = 13
        Me.StatusCheckBox.Text = "Status"
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_OwnerBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(78, 135)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(431, 20)
        Me.AddressTextBox.TabIndex = 11
        '
        'MobileNoTextBox
        '
        Me.MobileNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_OwnerBindingSource, "MobileNo", True))
        Me.MobileNoTextBox.Location = New System.Drawing.Point(79, 110)
        Me.MobileNoTextBox.Name = "MobileNoTextBox"
        Me.MobileNoTextBox.Size = New System.Drawing.Size(226, 20)
        Me.MobileNoTextBox.TabIndex = 9
        Me.MobileNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CNICTextBox
        '
        Me.CNICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_OwnerBindingSource, "CNIC", True))
        Me.CNICTextBox.Location = New System.Drawing.Point(78, 85)
        Me.CNICTextBox.Name = "CNICTextBox"
        Me.CNICTextBox.Size = New System.Drawing.Size(227, 20)
        Me.CNICTextBox.TabIndex = 8
        Me.CNICTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OwnerNameTextBox
        '
        Me.OwnerNameTextBox.ContextMenuStrip = Me.CMModelName
        Me.OwnerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_OwnerBindingSource, "OwnerName", True))
        Me.OwnerNameTextBox.Location = New System.Drawing.Point(79, 60)
        Me.OwnerNameTextBox.Name = "OwnerNameTextBox"
        Me.OwnerNameTextBox.Size = New System.Drawing.Size(333, 20)
        Me.OwnerNameTextBox.TabIndex = 7
        '
        'CMModelName
        '
        Me.CMModelName.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchModelName, Me.RFModelName})
        Me.CMModelName.Name = "CMModelCode"
        Me.CMModelName.Size = New System.Drawing.Size(161, 51)
        '
        'SearchModelName
        '
        Me.SearchModelName.Name = "SearchModelName"
        Me.SearchModelName.Size = New System.Drawing.Size(100, 23)
        '
        'RFModelName
        '
        Me.RFModelName.Name = "RFModelName"
        Me.RFModelName.Size = New System.Drawing.Size(160, 22)
        Me.RFModelName.Text = "Remove Filter"
        '
        'OwnerIDLabel1
        '
        Me.OwnerIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OwnerIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_OwnerBindingSource, "OwnerID", True))
        Me.OwnerIDLabel1.Location = New System.Drawing.Point(79, 35)
        Me.OwnerIDLabel1.Name = "OwnerIDLabel1"
        Me.OwnerIDLabel1.Size = New System.Drawing.Size(68, 20)
        Me.OwnerIDLabel1.TabIndex = 6
        Me.OwnerIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tbl_Bus_OwnerTableAdapter
        '
        Me.Tbl_Bus_OwnerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Bus_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Bus_OwnerTableAdapter = Me.Tbl_Bus_OwnerTableAdapter
        Me.TableAdapterManager.tbl_Bus_Route_FareTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Bus_Route_InfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSBusInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.png;)|*.jpg;*.jpeg;*.gif;*.png;"
        '
        'frmBusOwnerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 1006)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tbl_Bus_OwnerDataGridView)
        Me.Name = "frmBusOwnerInfo"
        Me.Text = "Bus Owners Info."
        CType(Me.Tbl_Bus_OwnerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Bus_OwnerBindingNavigator.ResumeLayout(False)
        Me.Tbl_Bus_OwnerBindingNavigator.PerformLayout()
        CType(Me.Tbl_Bus_OwnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBusInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bus_OwnerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ArtSnapPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMModelName.ResumeLayout(False)
        Me.CMModelName.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSBusInfo As ERP_HRMS.DSBusInfo
    Friend WithEvents Tbl_Bus_OwnerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_OwnerTableAdapter As ERP_HRMS.DSBusInfoTableAdapters.tbl_Bus_OwnerTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSBusInfoTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Bus_OwnerBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Tbl_Bus_OwnerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tbl_Bus_OwnerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CNICTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OwnerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OwnerIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents btnUploadPic As System.Windows.Forms.Button
    Friend WithEvents ArtSnapPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CMModelName As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SearchModelName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents RFModelName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents EmpPic As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
