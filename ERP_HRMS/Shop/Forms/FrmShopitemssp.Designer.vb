<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShopitems
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
        Dim LabelItem As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmShopitems))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Tbl_Shop_ItemBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Shop_ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSShop = New ERP_HRMS.DSShop()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_Shop_ItemBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EditToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CancelToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_Shop_ItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.BarCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Tbl_Shop_Item_Category_NEW_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSNEWShop = New ERP_HRMS.DSNEWShop()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_Shop_ItemTableAdapter = New ERP_HRMS.DSShopTableAdapters.tbl_Shop_ItemTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSShopTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel15 = New System.Windows.Forms.LinkLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Shop_Item_Category_NEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarcodeTxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaleTxt = New System.Windows.Forms.TextBox()
        Me.PurchaseTxt = New System.Windows.Forms.TextBox()
        Me.UOMTxt = New System.Windows.Forms.TextBox()
        Me.Itemtxt = New System.Windows.Forms.TextBox()
        Me.Tbl_Shop_Item_CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Shop_Item_CategoryTableAdapter = New ERP_HRMS.DSShopTableAdapters.tbl_Shop_Item_CategoryTableAdapter()
        Me.Tbl_Shop_Item_Category_NEWTableAdapter = New ERP_HRMS.DSNEWShopTableAdapters.tbl_Shop_Item_Category_NEWTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSNEWShopTableAdapters.TableAdapterManager()
        Me.Tbl_Shop_Item_Category_NEW_1TableAdapter = New ERP_HRMS.DSNEWShopTableAdapters.tbl_Shop_Item_Category_NEW_1TableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        LabelItem = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Shop_ItemBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Shop_ItemBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Shop_ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSShop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Shop_ItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Shop_Item_Category_NEW_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSNEWShop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Shop_Item_Category_NEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Shop_Item_CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelItem
        '
        LabelItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LabelItem.Location = New System.Drawing.Point(206, 27)
        LabelItem.Name = "LabelItem"
        LabelItem.Size = New System.Drawing.Size(230, 18)
        LabelItem.TabIndex = 53
        LabelItem.Text = "Item Name:"
        LabelItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(596, 28)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(103, 20)
        Label3.TabIndex = 58
        Label3.Text = "Purchase Price"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(719, 28)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(96, 20)
        Label4.TabIndex = 60
        Label4.Text = "Sale Price:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(829, 29)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(162, 20)
        Label5.TabIndex = 62
        Label5.Text = "Barcode:"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(17, 27)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(166, 21)
        Label6.TabIndex = 64
        Label6.Text = "Category"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(449, 27)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(128, 20)
        Label7.TabIndex = 65
        Label7.Text = "UOM"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1088, 39)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Items"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtsearch)
        Me.Panel1.Controls.Add(Me.Tbl_Shop_ItemBindingNavigator)
        Me.Panel1.Controls.Add(Me.Tbl_Shop_ItemDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(9, 176)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1033, 540)
        Me.Panel1.TabIndex = 14
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(309, 3)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(229, 20)
        Me.txtsearch.TabIndex = 7
        '
        'Tbl_Shop_ItemBindingNavigator
        '
        Me.Tbl_Shop_ItemBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Shop_ItemBindingNavigator.BindingSource = Me.Tbl_Shop_ItemBindingSource
        Me.Tbl_Shop_ItemBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Shop_ItemBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Shop_ItemBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Tbl_Shop_ItemBindingNavigatorSaveItem, Me.EditToolStripButton, Me.CancelToolStripButton})
        Me.Tbl_Shop_ItemBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Shop_ItemBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Shop_ItemBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Shop_ItemBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Shop_ItemBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Shop_ItemBindingNavigator.Name = "Tbl_Shop_ItemBindingNavigator"
        Me.Tbl_Shop_ItemBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Shop_ItemBindingNavigator.Size = New System.Drawing.Size(1031, 25)
        Me.Tbl_Shop_ItemBindingNavigator.TabIndex = 16
        Me.Tbl_Shop_ItemBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_Shop_ItemBindingSource
        '
        Me.Tbl_Shop_ItemBindingSource.DataMember = "tbl_Shop_Item"
        Me.Tbl_Shop_ItemBindingSource.DataSource = Me.DSShop
        '
        'DSShop
        '
        Me.DSShop.DataSetName = "DSShop"
        Me.DSShop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Tbl_Shop_ItemBindingNavigatorSaveItem
        '
        Me.Tbl_Shop_ItemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Shop_ItemBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Shop_ItemBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Shop_ItemBindingNavigatorSaveItem.Name = "Tbl_Shop_ItemBindingNavigatorSaveItem"
        Me.Tbl_Shop_ItemBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Shop_ItemBindingNavigatorSaveItem.Text = "Save Data"
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
        'Tbl_Shop_ItemDataGridView
        '
        Me.Tbl_Shop_ItemDataGridView.AllowUserToAddRows = False
        Me.Tbl_Shop_ItemDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tbl_Shop_ItemDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Tbl_Shop_ItemDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_Shop_ItemDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Tbl_Shop_ItemDataGridView.ColumnHeadersHeight = 32
        Me.Tbl_Shop_ItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BarCode, Me.DataGridViewTextBoxColumn2, Me.CategoryID, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3})
        Me.Tbl_Shop_ItemDataGridView.DataSource = Me.Tbl_Shop_ItemBindingSource
        Me.Tbl_Shop_ItemDataGridView.Location = New System.Drawing.Point(1, 27)
        Me.Tbl_Shop_ItemDataGridView.Name = "Tbl_Shop_ItemDataGridView"
        Me.Tbl_Shop_ItemDataGridView.RowHeadersWidth = 22
        Me.Tbl_Shop_ItemDataGridView.Size = New System.Drawing.Size(1027, 508)
        Me.Tbl_Shop_ItemDataGridView.TabIndex = 0
        '
        'BarCode
        '
        Me.BarCode.DataPropertyName = "BarCode"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.BarCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.BarCode.HeaderText = "Bar Code"
        Me.BarCode.Name = "BarCode"
        Me.BarCode.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ItemName"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'CategoryID
        '
        Me.CategoryID.DataPropertyName = "CategoryID"
        Me.CategoryID.DataSource = Me.Tbl_Shop_Item_Category_NEW_1BindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CategoryID.DefaultCellStyle = DataGridViewCellStyle5
        Me.CategoryID.DisplayMember = "CategoryName"
        Me.CategoryID.DisplayStyleForCurrentCellOnly = True
        Me.CategoryID.HeaderText = "Catagory Name"
        Me.CategoryID.Name = "CategoryID"
        Me.CategoryID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CategoryID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.CategoryID.ToolTipText = "Catagory Name"
        Me.CategoryID.ValueMember = "CategoryID"
        Me.CategoryID.Width = 200
        '
        'Tbl_Shop_Item_Category_NEW_1BindingSource
        '
        Me.Tbl_Shop_Item_Category_NEW_1BindingSource.DataMember = "tbl_Shop_Item_Category_NEW_1"
        Me.Tbl_Shop_Item_Category_NEW_1BindingSource.DataSource = Me.DSNEWShop
        '
        'DSNEWShop
        '
        Me.DSNEWShop.DataSetName = "DSNEWShop"
        Me.DSNEWShop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UOM"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PurchasePrice"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Retail Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SalePrice"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sale Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EntryDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'Tbl_Shop_ItemTableAdapter
        '
        Me.Tbl_Shop_ItemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_ShortTermAdvancesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_TranDateTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Shop_Inv_IDTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Shop_Item_CategoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Shop_Item_NEWTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Shop_ItemTableAdapter = Me.Tbl_Shop_ItemTableAdapter
        Me.TableAdapterManager.tbl_Shop_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Shop_Tran_INTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Shop_Tran_InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Shop_Tran_OutTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSShopTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_CardTableAdapter = Nothing
        Me.TableAdapterManager.View_Tran_OutTableAdapter = Nothing
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LinkLabel15)
        Me.Panel2.Controls.Add(Label7)
        Me.Panel2.Controls.Add(Label6)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.BarcodeTxt)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(LabelItem)
        Me.Panel2.Controls.Add(Me.SaleTxt)
        Me.Panel2.Controls.Add(Me.PurchaseTxt)
        Me.Panel2.Controls.Add(Me.UOMTxt)
        Me.Panel2.Controls.Add(Me.Itemtxt)
        Me.Panel2.Location = New System.Drawing.Point(7, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1034, 123)
        Me.Panel2.TabIndex = 15
        '
        'LinkLabel15
        '
        Me.LinkLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel15.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel15.Location = New System.Drawing.Point(187, 56)
        Me.LinkLabel15.Name = "LinkLabel15"
        Me.LinkLabel15.Size = New System.Drawing.Size(15, 11)
        Me.LinkLabel15.TabIndex = 67
        Me.LinkLabel15.TabStop = True
        Me.LinkLabel15.Text = "^"
        Me.LinkLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_Shop_Item_Category_NEWBindingSource
        Me.ComboBox1.DisplayMember = "CategoryName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(17, 51)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "CategoryID"
        '
        'Tbl_Shop_Item_Category_NEWBindingSource
        '
        Me.Tbl_Shop_Item_Category_NEWBindingSource.DataMember = "tbl_Shop_Item_Category_NEW"
        Me.Tbl_Shop_Item_Category_NEWBindingSource.DataSource = Me.DSNEWShop
        '
        'BarcodeTxt
        '
        Me.BarcodeTxt.Location = New System.Drawing.Point(829, 52)
        Me.BarcodeTxt.Name = "BarcodeTxt"
        Me.BarcodeTxt.Size = New System.Drawing.Size(162, 20)
        Me.BarcodeTxt.TabIndex = 5
        Me.BarcodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(832, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1032, 23)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Barcode Items"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaleTxt
        '
        Me.SaleTxt.Location = New System.Drawing.Point(719, 51)
        Me.SaleTxt.Name = "SaleTxt"
        Me.SaleTxt.Size = New System.Drawing.Size(96, 20)
        Me.SaleTxt.TabIndex = 4
        Me.SaleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PurchaseTxt
        '
        Me.PurchaseTxt.Location = New System.Drawing.Point(596, 51)
        Me.PurchaseTxt.Name = "PurchaseTxt"
        Me.PurchaseTxt.Size = New System.Drawing.Size(96, 20)
        Me.PurchaseTxt.TabIndex = 3
        Me.PurchaseTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UOMTxt
        '
        Me.UOMTxt.Location = New System.Drawing.Point(449, 51)
        Me.UOMTxt.Name = "UOMTxt"
        Me.UOMTxt.Size = New System.Drawing.Size(128, 20)
        Me.UOMTxt.TabIndex = 2
        Me.UOMTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Itemtxt
        '
        Me.Itemtxt.Location = New System.Drawing.Point(206, 51)
        Me.Itemtxt.Name = "Itemtxt"
        Me.Itemtxt.Size = New System.Drawing.Size(230, 20)
        Me.Itemtxt.TabIndex = 1
        Me.Itemtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tbl_Shop_Item_CategoryBindingSource
        '
        Me.Tbl_Shop_Item_CategoryBindingSource.DataSource = Me.DSShop
        Me.Tbl_Shop_Item_CategoryBindingSource.Position = 0
        '
        'Tbl_Shop_Item_CategoryTableAdapter
        '
        Me.Tbl_Shop_Item_CategoryTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Shop_Item_Category_NEWTableAdapter
        '
        Me.Tbl_Shop_Item_Category_NEWTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Shop_Item_Category_NEW_1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Shop_Item_Category_NEWTableAdapter = Me.Tbl_Shop_Item_Category_NEWTableAdapter
        Me.TableAdapterManager1.tbl_Shop_Item_SHOPTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSNEWShopTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Shop_Item_Category_NEW_1TableAdapter
        '
        Me.Tbl_Shop_Item_Category_NEW_1TableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'FrmShopitems
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1088, 832)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "FrmShopitems"
        Me.Text = "Shop Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Shop_ItemBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Shop_ItemBindingNavigator.ResumeLayout(False)
        Me.Tbl_Shop_ItemBindingNavigator.PerformLayout()
        CType(Me.Tbl_Shop_ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSShop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Shop_ItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Shop_Item_Category_NEW_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSNEWShop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Shop_Item_Category_NEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Shop_Item_CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DSShop As DSShop
    Friend WithEvents Tbl_Shop_ItemBindingSource As BindingSource
    Friend WithEvents Tbl_Shop_ItemTableAdapter As DSShopTableAdapters.tbl_Shop_ItemTableAdapter
    Friend WithEvents TableAdapterManager As DSShopTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Shop_ItemBindingNavigator As BindingNavigator
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
    Friend WithEvents Tbl_Shop_ItemBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_Shop_ItemDataGridView As DataGridView
    Friend WithEvents EditToolStripButton As ToolStripButton
    Friend WithEvents CancelToolStripButton As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Itemtxt As TextBox
    Friend WithEvents BarcodeTxt As TextBox
    Friend WithEvents SaleTxt As TextBox
    Friend WithEvents PurchaseTxt As TextBox
    Friend WithEvents UOMTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Tbl_Shop_Item_CategoryBindingSource As BindingSource
    Friend WithEvents Tbl_Shop_Item_CategoryTableAdapter As DSShopTableAdapters.tbl_Shop_Item_CategoryTableAdapter
    Friend WithEvents DSNEWShop As DSNEWShop
    Friend WithEvents Tbl_Shop_Item_Category_NEWBindingSource As BindingSource
    Friend WithEvents Tbl_Shop_Item_Category_NEWTableAdapter As DSNEWShopTableAdapters.tbl_Shop_Item_Category_NEWTableAdapter
    Friend WithEvents TableAdapterManager1 As DSNEWShopTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Shop_Item_Category_NEW_1BindingSource As BindingSource
    Friend WithEvents Tbl_Shop_Item_Category_NEW_1TableAdapter As DSNEWShopTableAdapters.tbl_Shop_Item_Category_NEW_1TableAdapter
    Friend WithEvents BarCode As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CategoryID As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel15 As LinkLabel
    Friend WithEvents Timer1 As Timer
End Class
