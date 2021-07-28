<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserMgt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUserMgt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UsersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_MIS_User_MgtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUM = New ERP_HRMS.DSUM()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UsersDataGridView = New System.Windows.Forms.DataGridView()
        Me.Tbl_MIS_User_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.SupplierContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New ERP_HRMS.DSUserTableAdapters.UsersTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.Tbl_MIS_User_NEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MIS_User_NEWTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_MIS_User_NEWTableAdapter()
        Me.Tbl_MIS_User_NEWBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_MIS_User_DeptTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_MIS_User_DeptTableAdapter()
        Me.Tbl_MIS_User_MgtTableAdapter = New ERP_HRMS.DSUMTableAdapters.tbl_MIS_User_MgtTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSUMTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginDeptID = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IpAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PSWDDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UserMgt = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn13 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.COntt = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Transport = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.vehicles = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Grievance = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Shop = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Complaint = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Medication = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Evo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Kaizen = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Traning = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UsersBindingNavigator.SuspendLayout()
        CType(Me.Tbl_MIS_User_MgtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MIS_User_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SupplierContextMenuStrip.SuspendLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MIS_User_NEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MIS_User_NEWBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1512, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Management"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.UsersBindingNavigator)
        Me.Panel1.Controls.Add(Me.UsersDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(2, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1498, 618)
        Me.Panel1.TabIndex = 2
        '
        'UsersBindingNavigator
        '
        Me.UsersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UsersBindingNavigator.BindingSource = Me.Tbl_MIS_User_MgtBindingSource
        Me.UsersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UsersBindingNavigator.DeleteItem = Nothing
        Me.UsersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.UsersBindingNavigatorSaveItem})
        Me.UsersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UsersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UsersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UsersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UsersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UsersBindingNavigator.Name = "UsersBindingNavigator"
        Me.UsersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UsersBindingNavigator.Size = New System.Drawing.Size(1496, 25)
        Me.UsersBindingNavigator.TabIndex = 4
        Me.UsersBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_MIS_User_MgtBindingSource
        '
        Me.Tbl_MIS_User_MgtBindingSource.DataMember = "tbl_MIS_User_Mgt"
        Me.Tbl_MIS_User_MgtBindingSource.DataSource = Me.DSUM
        '
        'DSUM
        '
        Me.DSUM.DataSetName = "DSUM"
        Me.DSUM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'UsersBindingNavigatorSaveItem
        '
        Me.UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UsersBindingNavigatorSaveItem.Image = CType(resources.GetObject("UsersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UsersBindingNavigatorSaveItem.Name = "UsersBindingNavigatorSaveItem"
        Me.UsersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.UsersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UsersDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UsersDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.UsersDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UsersDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.LoginDeptID, Me.IpAddress, Me.DataGridViewTextBoxColumn3, Me.PSWDDate, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.UserMgt, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewCheckBoxColumn10, Me.DataGridViewCheckBoxColumn9, Me.DataGridViewCheckBoxColumn11, Me.DataGridViewCheckBoxColumn12, Me.DataGridViewCheckBoxColumn13, Me.COntt, Me.Transport, Me.vehicles, Me.Grievance, Me.Shop, Me.Complaint, Me.Medication, Me.Evo, Me.Kaizen, Me.Traning, Me.Column1})
        Me.UsersDataGridView.ContextMenuStrip = Me.SupplierContextMenuStrip
        Me.UsersDataGridView.DataSource = Me.Tbl_MIS_User_MgtBindingSource
        Me.UsersDataGridView.Location = New System.Drawing.Point(2, 27)
        Me.UsersDataGridView.Name = "UsersDataGridView"
        Me.UsersDataGridView.RowHeadersWidth = 22
        Me.UsersDataGridView.Size = New System.Drawing.Size(1491, 586)
        Me.UsersDataGridView.TabIndex = 0
        '
        'Tbl_MIS_User_DeptBindingSource
        '
        Me.Tbl_MIS_User_DeptBindingSource.DataMember = "tbl_MIS_User_Dept"
        Me.Tbl_MIS_User_DeptBindingSource.DataSource = Me.DSUser
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SupplierContextMenuStrip
        '
        Me.SupplierContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.RemoveFilterToolStripMenuItem})
        Me.SupplierContextMenuStrip.Name = "SupplierContextMenuStrip"
        Me.SupplierContextMenuStrip.Size = New System.Drawing.Size(161, 51)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'RemoveFilterToolStripMenuItem
        '
        Me.RemoveFilterToolStripMenuItem.Name = "RemoveFilterToolStripMenuItem"
        Me.RemoveFilterToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.RemoveFilterToolStripMenuItem.Text = "Remove &Filter"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.DSUser
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        '
        'Tbl_MIS_User_NEWBindingSource
        '
        Me.Tbl_MIS_User_NEWBindingSource.DataSource = Me.DSUser
        Me.Tbl_MIS_User_NEWBindingSource.Position = 0
        '
        'Tbl_MIS_User_NEWTableAdapter
        '
        Me.Tbl_MIS_User_NEWTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MIS_User_NEWBindingSource1
        '
        Me.Tbl_MIS_User_NEWBindingSource1.DataSource = Me.DSUser
        Me.Tbl_MIS_User_NEWBindingSource1.Position = 0
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(9, 58)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Active"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(79, 58)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "Non-Active"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(163, 58)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.Text = "Active And Non-Active"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbl_MIS_User_DeptTableAdapter
        '
        Me.Tbl_MIS_User_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MIS_User_MgtTableAdapter
        '
        Me.Tbl_MIS_User_MgtTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_MIS_User_MgtTableAdapter = Me.Tbl_MIS_User_MgtTableAdapter
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSUMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LoginName"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "User Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 130
        '
        'LoginDeptID
        '
        Me.LoginDeptID.DataPropertyName = "LoginDeptID"
        Me.LoginDeptID.DataSource = Me.Tbl_MIS_User_DeptBindingSource
        Me.LoginDeptID.DisplayMember = "DeptName"
        Me.LoginDeptID.DisplayStyleForCurrentCellOnly = True
        Me.LoginDeptID.HeaderText = "Department"
        Me.LoginDeptID.Name = "LoginDeptID"
        Me.LoginDeptID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LoginDeptID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.LoginDeptID.ValueMember = "LoginDeptID"
        Me.LoginDeptID.Width = 120
        '
        'IpAddress
        '
        Me.IpAddress.DataPropertyName = "IpAddress"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IpAddress.DefaultCellStyle = DataGridViewCellStyle4
        Me.IpAddress.HeaderText = "IP Address"
        Me.IpAddress.Name = "IpAddress"
        Me.IpAddress.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "passwd"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'PSWDDate
        '
        Me.PSWDDate.DataPropertyName = "PSWDDate"
        Me.PSWDDate.HeaderText = "PSWDDate"
        Me.PSWDDate.Name = "PSWDDate"
        Me.PSWDDate.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "UserSataus"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "User Sataus"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 65
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "SPStatus"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "SP Status"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Width = 65
        '
        'UserMgt
        '
        Me.UserMgt.DataPropertyName = "UserMgt"
        Me.UserMgt.HeaderText = "User Mgt"
        Me.UserMgt.Name = "UserMgt"
        Me.UserMgt.Width = 65
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "HRSett"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "HR Setting"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 65
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Employee"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Employee Mgt"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 65
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "HRRpt"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "HR Reports"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.Width = 65
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.DataPropertyName = "PayRollsett"
        Me.DataGridViewCheckBoxColumn7.HeaderText = "PayRoll Setting"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        Me.DataGridViewCheckBoxColumn7.Width = 65
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.DataPropertyName = "PayRoll"
        Me.DataGridViewCheckBoxColumn6.HeaderText = "PayRoll"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.Visible = False
        Me.DataGridViewCheckBoxColumn6.Width = 65
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.DataPropertyName = "PayRollRpt"
        Me.DataGridViewCheckBoxColumn8.HeaderText = "PayRoll Reports"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.Width = 65
        '
        'DataGridViewCheckBoxColumn10
        '
        Me.DataGridViewCheckBoxColumn10.DataPropertyName = "AccSett"
        Me.DataGridViewCheckBoxColumn10.HeaderText = "Accounts Setting"
        Me.DataGridViewCheckBoxColumn10.Name = "DataGridViewCheckBoxColumn10"
        Me.DataGridViewCheckBoxColumn10.Visible = False
        Me.DataGridViewCheckBoxColumn10.Width = 65
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.DataPropertyName = "Account"
        Me.DataGridViewCheckBoxColumn9.HeaderText = "Account Calculation"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        Me.DataGridViewCheckBoxColumn9.Width = 65
        '
        'DataGridViewCheckBoxColumn11
        '
        Me.DataGridViewCheckBoxColumn11.DataPropertyName = "AccRpt"
        Me.DataGridViewCheckBoxColumn11.HeaderText = "Account Reports"
        Me.DataGridViewCheckBoxColumn11.Name = "DataGridViewCheckBoxColumn11"
        Me.DataGridViewCheckBoxColumn11.Width = 65
        '
        'DataGridViewCheckBoxColumn12
        '
        Me.DataGridViewCheckBoxColumn12.DataPropertyName = "Canteen"
        Me.DataGridViewCheckBoxColumn12.HeaderText = "Canteen"
        Me.DataGridViewCheckBoxColumn12.Name = "DataGridViewCheckBoxColumn12"
        Me.DataGridViewCheckBoxColumn12.Width = 65
        '
        'DataGridViewCheckBoxColumn13
        '
        Me.DataGridViewCheckBoxColumn13.DataPropertyName = "Visitors"
        Me.DataGridViewCheckBoxColumn13.HeaderText = "Visitors"
        Me.DataGridViewCheckBoxColumn13.Name = "DataGridViewCheckBoxColumn13"
        Me.DataGridViewCheckBoxColumn13.Width = 65
        '
        'COntt
        '
        Me.COntt.DataPropertyName = "COntt"
        Me.COntt.HeaderText = "Contractors"
        Me.COntt.Name = "COntt"
        Me.COntt.Width = 70
        '
        'Transport
        '
        Me.Transport.DataPropertyName = "Transport"
        Me.Transport.HeaderText = "Transport"
        Me.Transport.Name = "Transport"
        Me.Transport.Width = 65
        '
        'vehicles
        '
        Me.vehicles.DataPropertyName = "vehicles"
        Me.vehicles.HeaderText = "Vehicles"
        Me.vehicles.Name = "vehicles"
        Me.vehicles.Width = 65
        '
        'Grievance
        '
        Me.Grievance.DataPropertyName = "Grievance"
        Me.Grievance.HeaderText = "Grievance"
        Me.Grievance.Name = "Grievance"
        Me.Grievance.Width = 65
        '
        'Shop
        '
        Me.Shop.DataPropertyName = "Shop"
        Me.Shop.HeaderText = "Shop"
        Me.Shop.Name = "Shop"
        Me.Shop.Width = 65
        '
        'Complaint
        '
        Me.Complaint.DataPropertyName = "Complaint"
        Me.Complaint.HeaderText = "Complaint"
        Me.Complaint.Name = "Complaint"
        Me.Complaint.Width = 65
        '
        'Medication
        '
        Me.Medication.DataPropertyName = "Medication"
        Me.Medication.HeaderText = "Medication"
        Me.Medication.Name = "Medication"
        Me.Medication.Width = 65
        '
        'Evo
        '
        Me.Evo.DataPropertyName = "Evo"
        Me.Evo.HeaderText = "Evo"
        Me.Evo.Name = "Evo"
        Me.Evo.Width = 65
        '
        'Kaizen
        '
        Me.Kaizen.DataPropertyName = "Kaizen"
        Me.Kaizen.HeaderText = "Kaizen"
        Me.Kaizen.Name = "Kaizen"
        Me.Kaizen.Width = 65
        '
        'Traning
        '
        Me.Traning.DataPropertyName = "Traning"
        Me.Traning.HeaderText = "Traning"
        Me.Traning.Name = "Traning"
        Me.Traning.Width = 65
        '
        'Column1
        '
        Me.Column1.HeaderText = "Generate Password"
        Me.Column1.Name = "Column1"
        Me.Column1.Text = "^"
        Me.Column1.ToolTipText = "Generate Password"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 70
        '
        'FrmUserMgt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1512, 857)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUserMgt"
        Me.Text = "User Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UsersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UsersBindingNavigator.ResumeLayout(False)
        Me.UsersBindingNavigator.PerformLayout()
        CType(Me.Tbl_MIS_User_MgtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MIS_User_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SupplierContextMenuStrip.ResumeLayout(False)
        Me.SupplierContextMenuStrip.PerformLayout()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MIS_User_NEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MIS_User_NEWBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DSUser As DSUser
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As DSUserTableAdapters.UsersTableAdapter
    Friend WithEvents TableAdapterManager As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents UsersBindingNavigator As BindingNavigator
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
    Friend WithEvents UsersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UsersDataGridView As DataGridView
    Friend WithEvents Tbl_MIS_User_NEWBindingSource As BindingSource
    Friend WithEvents Tbl_MIS_User_NEWTableAdapter As DSUserTableAdapters.tbl_MIS_User_NEWTableAdapter
    Friend WithEvents Tbl_MIS_User_NEWBindingSource1 As BindingSource
    Friend WithEvents DSUM As DSUM
    Friend WithEvents Tbl_MIS_User_MgtBindingSource As BindingSource
    Friend WithEvents Tbl_MIS_User_MgtTableAdapter As DSUMTableAdapters.tbl_MIS_User_MgtTableAdapter
    Friend WithEvents TableAdapterManager1 As DSUMTableAdapters.TableAdapterManager
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents SupplierContextMenuStrip As ContextMenuStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents RemoveFilterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tbl_MIS_User_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_MIS_User_DeptTableAdapter As DSUserTableAdapters.tbl_MIS_User_DeptTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents LoginDeptID As DataGridViewComboBoxColumn
    Friend WithEvents IpAddress As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents PSWDDate As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents UserMgt As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn10 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn11 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn12 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn13 As DataGridViewCheckBoxColumn
    Friend WithEvents COntt As DataGridViewCheckBoxColumn
    Friend WithEvents Transport As DataGridViewCheckBoxColumn
    Friend WithEvents vehicles As DataGridViewCheckBoxColumn
    Friend WithEvents Grievance As DataGridViewCheckBoxColumn
    Friend WithEvents Shop As DataGridViewCheckBoxColumn
    Friend WithEvents Complaint As DataGridViewCheckBoxColumn
    Friend WithEvents Medication As DataGridViewCheckBoxColumn
    Friend WithEvents Evo As DataGridViewCheckBoxColumn
    Friend WithEvents Kaizen As DataGridViewCheckBoxColumn
    Friend WithEvents Traning As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
End Class
