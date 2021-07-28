<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillingTran
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
        Dim BusCardNoLabel As System.Windows.Forms.Label
        Dim BusNoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBillingTran))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BusNoLabel1 = New System.Windows.Forms.Label()
        Me.View_BUS_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSTranCalc = New ERP_HRMS.DSTranCalc()
        Me.BUSOTLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OTCountLabel1 = New System.Windows.Forms.Label()
        Me.View_Bust_Att_OTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FareLabel1 = New System.Windows.Forms.Label()
        Me.HolidayCountLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AttCountLabel1 = New System.Windows.Forms.Label()
        Me.View_BUS_ATT_GroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TemAmtLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Bus_TempAdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddAmountLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Bus_AddAmountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FineLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Bus_FineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.View_BUS_InfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BusCardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.View_BUS_InfoTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.View_BUS_InfoTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSTranCalcTableAdapters.TableAdapterManager()
        Me.Tbl_Bus_FineTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_FineTableAdapter()
        Me.Tbl_Bus_AddAmountTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_AddAmountTableAdapter()
        Me.Tbl_Bus_TempAdvTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_TempAdvTableAdapter()
        Me.View_BUS_ATT_GroupTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.View_BUS_ATT_GroupTableAdapter()
        Me.Tbl_Hrm_HolidaysTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.tbl_Hrm_HolidaysTableAdapter()
        Me.View_Bust_Att_OTTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.View_Bust_Att_OTTableAdapter()
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.Tbl_Bus_Bill_TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Bus_Bill_TransTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_Bill_TransTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.View_Bus_Bill_TransDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LockStatus = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.View_Bus_Bill_TransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.View_Bus_Bill_TransTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.View_Bus_Bill_TransTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbl_Bus_Leave_EntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Bus_Leave_EntryTableAdapter = New ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_Leave_EntryTableAdapter()
        Me.PaidLabel1 = New System.Windows.Forms.Label()
        BusCardNoLabel = New System.Windows.Forms.Label()
        BusNoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.View_BUS_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTranCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Bust_Att_OTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_BUS_ATT_GroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bus_TempAdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bus_AddAmountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bus_FineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_BUS_InfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.View_BUS_InfoBindingNavigator.SuspendLayout()
        CType(Me.Tbl_Bus_Bill_TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.View_Bus_Bill_TransDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Bus_Bill_TransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_Bus_Leave_EntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BusCardNoLabel
        '
        BusCardNoLabel.AutoSize = True
        BusCardNoLabel.Location = New System.Drawing.Point(5, 38)
        BusCardNoLabel.Name = "BusCardNoLabel"
        BusCardNoLabel.Size = New System.Drawing.Size(70, 13)
        BusCardNoLabel.TabIndex = 0
        BusCardNoLabel.Text = "Bus Card No:"
        '
        'BusNoLabel
        '
        BusNoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        BusNoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        BusNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BusNoLabel.ForeColor = System.Drawing.Color.White
        BusNoLabel.Location = New System.Drawing.Point(7, 72)
        BusNoLabel.Name = "BusNoLabel"
        BusNoLabel.Size = New System.Drawing.Size(71, 34)
        BusNoLabel.TabIndex = 24
        BusNoLabel.Text = "Bus No.:"
        BusNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Monthly Trnasport Billing Calculation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMM-yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(83, 45)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker2.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Entry Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(BusNoLabel)
        Me.Panel1.Controls.Add(Me.BusNoLabel1)
        Me.Panel1.Controls.Add(Me.BUSOTLabel1)
        Me.Panel1.Controls.Add(Me.OTCountLabel1)
        Me.Panel1.Controls.Add(Me.FareLabel1)
        Me.Panel1.Controls.Add(Me.HolidayCountLabel1)
        Me.Panel1.Controls.Add(Me.AttCountLabel1)
        Me.Panel1.Controls.Add(Me.TemAmtLabel1)
        Me.Panel1.Controls.Add(Me.AddAmountLabel1)
        Me.Panel1.Controls.Add(Me.FineLabel1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.View_BUS_InfoBindingNavigator)
        Me.Panel1.Controls.Add(BusCardNoLabel)
        Me.Panel1.Controls.Add(Me.BusCardNoComboBox)
        Me.Panel1.Location = New System.Drawing.Point(4, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(388, 137)
        Me.Panel1.TabIndex = 23
        '
        'BusNoLabel1
        '
        Me.BusNoLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BusNoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BusNoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_BUS_InfoBindingSource, "BusNo", True))
        Me.BusNoLabel1.Font = New System.Drawing.Font("Cambria", 17.0!, System.Drawing.FontStyle.Bold)
        Me.BusNoLabel1.ForeColor = System.Drawing.Color.White
        Me.BusNoLabel1.Location = New System.Drawing.Point(85, 72)
        Me.BusNoLabel1.Name = "BusNoLabel1"
        Me.BusNoLabel1.Size = New System.Drawing.Size(153, 34)
        Me.BusNoLabel1.TabIndex = 25
        Me.BusNoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_BUS_InfoBindingSource
        '
        Me.View_BUS_InfoBindingSource.DataMember = "View_BUS_Info"
        Me.View_BUS_InfoBindingSource.DataSource = Me.DSTranCalc
        '
        'DSTranCalc
        '
        Me.DSTranCalc.DataSetName = "DSTranCalc"
        Me.DSTranCalc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BUSOTLabel1
        '
        Me.BUSOTLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Comp_InfoBindingSource, "BUSOT", True))
        Me.BUSOTLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.BUSOTLabel1.Location = New System.Drawing.Point(359, 25)
        Me.BUSOTLabel1.Name = "BUSOTLabel1"
        Me.BUSOTLabel1.Size = New System.Drawing.Size(3, 11)
        Me.BUSOTLabel1.TabIndex = 61
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        Me.Tbl_Comp_InfoBindingSource.DataSource = Me.DSTranCalc
        '
        'OTCountLabel1
        '
        Me.OTCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Bust_Att_OTBindingSource, "OTCount", True))
        Me.OTCountLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.OTCountLabel1.Location = New System.Drawing.Point(392, 53)
        Me.OTCountLabel1.Name = "OTCountLabel1"
        Me.OTCountLabel1.Size = New System.Drawing.Size(3, 16)
        Me.OTCountLabel1.TabIndex = 60
        '
        'View_Bust_Att_OTBindingSource
        '
        Me.View_Bust_Att_OTBindingSource.DataMember = "View_BUS_Info_View_Bust_Att_OT"
        Me.View_Bust_Att_OTBindingSource.DataSource = Me.View_BUS_InfoBindingSource
        '
        'FareLabel1
        '
        Me.FareLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_BUS_InfoBindingSource, "Fare", True))
        Me.FareLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.FareLabel1.Location = New System.Drawing.Point(562, 28)
        Me.FareLabel1.Name = "FareLabel1"
        Me.FareLabel1.Size = New System.Drawing.Size(13, 9)
        Me.FareLabel1.TabIndex = 59
        '
        'HolidayCountLabel1
        '
        Me.HolidayCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_HolidaysBindingSource, "HolidayCount", True))
        Me.HolidayCountLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.HolidayCountLabel1.Location = New System.Drawing.Point(513, 25)
        Me.HolidayCountLabel1.Name = "HolidayCountLabel1"
        Me.HolidayCountLabel1.Size = New System.Drawing.Size(4, 15)
        Me.HolidayCountLabel1.TabIndex = 25
        '
        'Tbl_Hrm_HolidaysBindingSource
        '
        Me.Tbl_Hrm_HolidaysBindingSource.DataMember = "tbl_Hrm_Holidays"
        Me.Tbl_Hrm_HolidaysBindingSource.DataSource = Me.DSTranCalc
        '
        'AttCountLabel1
        '
        Me.AttCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_BUS_ATT_GroupBindingSource, "AttCount", True))
        Me.AttCountLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.AttCountLabel1.Location = New System.Drawing.Point(472, 29)
        Me.AttCountLabel1.Name = "AttCountLabel1"
        Me.AttCountLabel1.Size = New System.Drawing.Size(14, 6)
        Me.AttCountLabel1.TabIndex = 58
        '
        'View_BUS_ATT_GroupBindingSource
        '
        Me.View_BUS_ATT_GroupBindingSource.DataMember = "View_BUS_Info_View_BUS_ATT_Group"
        Me.View_BUS_ATT_GroupBindingSource.DataSource = Me.View_BUS_InfoBindingSource
        '
        'TemAmtLabel1
        '
        Me.TemAmtLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_TempAdvBindingSource, "TemAmt", True))
        Me.TemAmtLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.TemAmtLabel1.Location = New System.Drawing.Point(424, 25)
        Me.TemAmtLabel1.Name = "TemAmtLabel1"
        Me.TemAmtLabel1.Size = New System.Drawing.Size(3, 10)
        Me.TemAmtLabel1.TabIndex = 25
        '
        'Tbl_Bus_TempAdvBindingSource
        '
        Me.Tbl_Bus_TempAdvBindingSource.DataMember = "View_BUS_Info_tbl_Bus_TempAdv"
        Me.Tbl_Bus_TempAdvBindingSource.DataSource = Me.View_BUS_InfoBindingSource
        '
        'AddAmountLabel1
        '
        Me.AddAmountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_AddAmountBindingSource, "AddAmount", True))
        Me.AddAmountLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.AddAmountLabel1.Location = New System.Drawing.Point(368, 28)
        Me.AddAmountLabel1.Name = "AddAmountLabel1"
        Me.AddAmountLabel1.Size = New System.Drawing.Size(11, 19)
        Me.AddAmountLabel1.TabIndex = 57
        '
        'Tbl_Bus_AddAmountBindingSource
        '
        Me.Tbl_Bus_AddAmountBindingSource.DataMember = "View_BUS_Info_tbl_Bus_AddAmount"
        Me.Tbl_Bus_AddAmountBindingSource.DataSource = Me.View_BUS_InfoBindingSource
        '
        'FineLabel1
        '
        Me.FineLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_FineBindingSource, "Fine", True))
        Me.FineLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.FineLabel1.Location = New System.Drawing.Point(317, 33)
        Me.FineLabel1.Name = "FineLabel1"
        Me.FineLabel1.Size = New System.Drawing.Size(6, 14)
        Me.FineLabel1.TabIndex = 56
        '
        'Tbl_Bus_FineBindingSource
        '
        Me.Tbl_Bus_FineBindingSource.DataMember = "View_BUS_Info_tbl_Bus_Fine"
        Me.Tbl_Bus_FineBindingSource.DataSource = Me.View_BUS_InfoBindingSource
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Cambria", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(261, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 54)
        Me.Button2.TabIndex = 55
        Me.Button2.TabStop = False
        Me.Button2.Text = "Save Bill"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'View_BUS_InfoBindingNavigator
        '
        Me.View_BUS_InfoBindingNavigator.AddNewItem = Nothing
        Me.View_BUS_InfoBindingNavigator.BindingSource = Me.View_BUS_InfoBindingSource
        Me.View_BUS_InfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.View_BUS_InfoBindingNavigator.DeleteItem = Nothing
        Me.View_BUS_InfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.View_BUS_InfoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.View_BUS_InfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.View_BUS_InfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.View_BUS_InfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.View_BUS_InfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.View_BUS_InfoBindingNavigator.Name = "View_BUS_InfoBindingNavigator"
        Me.View_BUS_InfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.View_BUS_InfoBindingNavigator.Size = New System.Drawing.Size(386, 25)
        Me.View_BUS_InfoBindingNavigator.TabIndex = 24
        Me.View_BUS_InfoBindingNavigator.Text = "BindingNavigator1"
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
        'BusCardNoComboBox
        '
        Me.BusCardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BusCardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BusCardNoComboBox.DataSource = Me.View_BUS_InfoBindingSource
        Me.BusCardNoComboBox.DisplayMember = "BusCardNo"
        Me.BusCardNoComboBox.FormattingEnabled = True
        Me.BusCardNoComboBox.Location = New System.Drawing.Point(85, 35)
        Me.BusCardNoComboBox.Name = "BusCardNoComboBox"
        Me.BusCardNoComboBox.Size = New System.Drawing.Size(182, 21)
        Me.BusCardNoComboBox.TabIndex = 1
        Me.BusCardNoComboBox.ValueMember = "BUSID"
        '
        'View_BUS_InfoTableAdapter
        '
        Me.View_BUS_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Bus_Bill_TransTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSTranCalcTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Bus_FineTableAdapter
        '
        Me.Tbl_Bus_FineTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Bus_AddAmountTableAdapter
        '
        Me.Tbl_Bus_AddAmountTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Bus_TempAdvTableAdapter
        '
        Me.Tbl_Bus_TempAdvTableAdapter.ClearBeforeFill = True
        '
        'View_BUS_ATT_GroupTableAdapter
        '
        Me.View_BUS_ATT_GroupTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_HolidaysTableAdapter
        '
        Me.Tbl_Hrm_HolidaysTableAdapter.ClearBeforeFill = True
        '
        'View_Bust_Att_OTTableAdapter
        '
        Me.View_Bust_Att_OTTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Bus_Bill_TransBindingSource
        '
        Me.Tbl_Bus_Bill_TransBindingSource.DataMember = "tbl_Bus_Bill_Trans"
        Me.Tbl_Bus_Bill_TransBindingSource.DataSource = Me.DSTranCalc
        '
        'Tbl_Bus_Bill_TransTableAdapter
        '
        Me.Tbl_Bus_Bill_TransTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.View_Bus_Bill_TransDataGridView)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(4, 209)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1253, 704)
        Me.Panel2.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(1085, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Lock Bill"
        '
        'View_Bus_Bill_TransDataGridView
        '
        Me.View_Bus_Bill_TransDataGridView.AllowUserToAddRows = False
        Me.View_Bus_Bill_TransDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.View_Bus_Bill_TransDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.View_Bus_Bill_TransDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_Bus_Bill_TransDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.View_Bus_Bill_TransDataGridView.ColumnHeadersHeight = 33
        Me.View_Bus_Bill_TransDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.LockStatus, Me.Column1})
        Me.View_Bus_Bill_TransDataGridView.DataSource = Me.View_Bus_Bill_TransBindingSource
        Me.View_Bus_Bill_TransDataGridView.Location = New System.Drawing.Point(2, 27)
        Me.View_Bus_Bill_TransDataGridView.Name = "View_Bus_Bill_TransDataGridView"
        Me.View_Bus_Bill_TransDataGridView.ReadOnly = True
        Me.View_Bus_Bill_TransDataGridView.Size = New System.Drawing.Size(1247, 671)
        Me.View_Bus_Bill_TransDataGridView.TabIndex = 25
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
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "BusCardNo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn21.HeaderText = "Bus Code#"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Width = 70
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "BusNo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn22.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn22.HeaderText = "BusNo"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fare"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fare"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PayableDays"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn8.HeaderText = "Payable Days"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "PayAbleAmt"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn9.HeaderText = "PayAble Amt"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OTRate"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn4.HeaderText = "OT Rate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 65
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "OTDays"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn10.HeaderText = "OT Days"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 60
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "OTAmt"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn11.HeaderText = "OT Amt"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 70
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "AddAmt"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn12.HeaderText = "Add Amt"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 70
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FineAmt"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn13.HeaderText = "Fine Amt"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 65
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "TempAmt"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn14.HeaderText = "Temp Amt"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 65
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "TotalAdds"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn15.HeaderText = "Total Adds"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 65
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TotalSubtract"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn16.HeaderText = "Total Subtract"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 65
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "NetPayable"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn17.HeaderText = "Net Payable"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 70
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "BillMonth"
        Me.DataGridViewTextBoxColumn18.HeaderText = "BillMonth"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "EntryDate"
        Me.DataGridViewTextBoxColumn19.HeaderText = "EntryDate"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'LockStatus
        '
        Me.LockStatus.DataPropertyName = "LockStatus"
        Me.LockStatus.HeaderText = "Lock Status"
        Me.LockStatus.Name = "LockStatus"
        Me.LockStatus.ReadOnly = True
        Me.LockStatus.Width = 70
        '
        'Column1
        '
        Me.Column1.HeaderText = "Undo Bill"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Undo Bill"
        Me.Column1.UseColumnTextForButtonValue = True
        Me.Column1.Width = 70
        '
        'View_Bus_Bill_TransBindingSource
        '
        Me.View_Bus_Bill_TransBindingSource.DataMember = "View_Bus_Bill_Trans"
        Me.View_Bus_Bill_TransBindingSource.DataSource = Me.DSTranCalc
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.View_Bus_Bill_TransBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton1
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton4
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton3
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton2
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.Size = New System.Drawing.Size(1251, 25)
        Me.BindingNavigator1.TabIndex = 25
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
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
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'View_Bus_Bill_TransTableAdapter
        '
        Me.View_Bus_Bill_TransTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(119, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "View Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(959, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 121)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selection "
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(122, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Monthly Bill Payment"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Bill Transaction Detail"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbl_Bus_Leave_EntryBindingSource
        '
        Me.Tbl_Bus_Leave_EntryBindingSource.DataMember = "View_BUS_Info_tbl_Bus_Leave_Entry"
        Me.Tbl_Bus_Leave_EntryBindingSource.DataSource = Me.View_BUS_InfoBindingSource
        '
        'Tbl_Bus_Leave_EntryTableAdapter
        '
        Me.Tbl_Bus_Leave_EntryTableAdapter.ClearBeforeFill = True
        '
        'PaidLabel1
        '
        Me.PaidLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Bus_Leave_EntryBindingSource, "Paid", True))
        Me.PaidLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.PaidLabel1.Location = New System.Drawing.Point(586, 84)
        Me.PaidLabel1.Name = "PaidLabel1"
        Me.PaidLabel1.Size = New System.Drawing.Size(100, 20)
        Me.PaidLabel1.TabIndex = 28
        Me.PaidLabel1.Text = "Label3"
        '
        'frmBillingTran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 1006)
        Me.Controls.Add(Me.PaidLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBillingTran"
        Me.Text = "Monthly Trnasport Billing Calculation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.View_BUS_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTranCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Bust_Att_OTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_BUS_ATT_GroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bus_TempAdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bus_AddAmountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bus_FineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_BUS_InfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.View_BUS_InfoBindingNavigator.ResumeLayout(False)
        Me.View_BUS_InfoBindingNavigator.PerformLayout()
        CType(Me.Tbl_Bus_Bill_TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.View_Bus_Bill_TransDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Bus_Bill_TransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_Bus_Leave_EntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DSTranCalc As ERP_HRMS.DSTranCalc
    Friend WithEvents View_BUS_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_BUS_InfoTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.View_BUS_InfoTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSTranCalcTableAdapters.TableAdapterManager
    Friend WithEvents View_BUS_InfoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BusCardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Tbl_Bus_FineBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_FineTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_FineTableAdapter
    Friend WithEvents FineLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Bus_AddAmountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_AddAmountTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_AddAmountTableAdapter
    Friend WithEvents AddAmountLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Bus_TempAdvBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_TempAdvTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_TempAdvTableAdapter
    Friend WithEvents TemAmtLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_BUS_ATT_GroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_BUS_ATT_GroupTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.View_BUS_ATT_GroupTableAdapter
    Friend WithEvents AttCountLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Hrm_HolidaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_HolidaysTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.tbl_Hrm_HolidaysTableAdapter
    Friend WithEvents HolidayCountLabel1 As System.Windows.Forms.Label
    Friend WithEvents FareLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Bust_Att_OTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Bust_Att_OTTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.View_Bust_Att_OTTableAdapter
    Friend WithEvents OTCountLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Comp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents BUSOTLabel1 As System.Windows.Forms.Label
    Friend WithEvents Tbl_Bus_Bill_TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_Bill_TransTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_Bill_TransTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents View_Bus_Bill_TransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Bus_Bill_TransTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.View_Bus_Bill_TransTableAdapter
    Friend WithEvents View_Bus_Bill_TransDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BusNoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LockStatus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_Bus_Leave_EntryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_Leave_EntryTableAdapter As ERP_HRMS.DSTranCalcTableAdapters.tbl_Bus_Leave_EntryTableAdapter
    Friend WithEvents PaidLabel1 As System.Windows.Forms.Label
End Class
