<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeUpG1
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
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAdvance = New ERP_HRMS.DSAdvance()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Card_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_ShortTermAdvances11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card_New123BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardAdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_FinancialPeriodAdvBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fin_Layer4_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_FinancialPeriod11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_BonusNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_PermanentAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Acc_Fin_Ded_VouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Card_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_ShortTermAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_CardTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSAdvanceTableAdapters.TableAdapterManager()
        Me.View_Card_InfoTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.View_Card_InfoTableAdapter()
        Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter()
        Me.Tbl_HRM_Card11TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_Card11TableAdapter()
        Me.CardNoLabel5 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter()
        Me.Tbl_Acc_ShortTermAdvances11TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_ShortTermAdvances11TableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Tbl_Hrm_Emp_Info_H1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.Tbl_Hrm_Emp_Info_H1TableAdapter()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_Acc_PermanentAdvancesTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_PermanentAdvancesTableAdapter()
        Me.Tbl_HRM_CardAdvTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_CardAdvTableAdapter()
        Me.Tbl_Fin_Layer4_NewTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Fin_Layer4_NewTableAdapter()
        Me.Tbl_Acc_FinancialPeriod11TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_FinancialPeriod11TableAdapter()
        Me.Tbl_Acc_BonusNoTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_BonusNoTableAdapter()
        Me.Tbl_Acc_FinancialPeriodAdvTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Acc_FinancialPeriodAdvTableAdapter()
        Me.View_Acc_Fin_Ded_VouchersTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.View_Acc_Fin_Ded_VouchersTableAdapter()
        Me.Tbl_Fin_Journal_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fin_Journal_HeadTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Fin_Journal_HeadTableAdapter()
        Me.Tbl_Fin_DebitCredit_EntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fin_DebitCredit_EntryTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_Fin_DebitCredit_EntryTableAdapter()
        Me.Tbl_Fin_DebitCredit_Entry1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Fin_DebitCredit_Entry1TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.Tbl_Fin_DebitCredit_Entry1TableAdapter()
        Me.Tbl_HRM_Card_NewTableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_Card_NewTableAdapter()
        Me.CardNoLabel3 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_Card_New123TableAdapter = New ERP_HRMS.DSAdvanceTableAdapters.tbl_HRM_Card_New123TableAdapter()
        Me.DSDept = New ERP_HRMS.DSDept()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSDeptTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSDeptTableAdapters.TableAdapterManager()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Card_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.Tbl_Acc_ShortTermAdvances11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card_New123BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardAdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodAdvBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fin_Layer4_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriod11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_BonusNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_PermanentAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_Fin_Ded_VouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Card_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fin_Journal_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fin_DebitCredit_EntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Fin_DebitCredit_Entry1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_Rpt_HR_EmpData_ActiveNonActiveBindingSource
        '
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource.DataMember = "View_Rpt_HR_EmpData_ActiveNonActive"
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource.DataSource = Me.DSAdvance
        '
        'DSAdvance
        '
        Me.DSAdvance.DataSetName = "DSAdvance"
        Me.DSAdvance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_Card11BindingSource
        '
        Me.Tbl_HRM_Card11BindingSource.DataMember = "tbl_HRM_Card11"
        Me.Tbl_HRM_Card11BindingSource.DataSource = Me.DSAdvance
        '
        'View_Card_InfoBindingSource
        '
        Me.View_Card_InfoBindingSource.DataMember = "View_Card_Info"
        Me.View_Card_InfoBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSAdvance
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(299, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 602)
        Me.Panel2.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(1, 90)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(534, 506)
        Me.DataGridView1.TabIndex = 9
        Me.DataGridView1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.btnSave)
        Me.Panel8.Controls.Add(Me.Label11)
        Me.Panel8.Controls.Add(Me.DateTimePicker5)
        Me.Panel8.Controls.Add(Me.tbFilePath)
        Me.Panel8.Controls.Add(Me.btnOpenFile)
        Me.Panel8.Controls.Add(Me.Label10)
        Me.Panel8.Location = New System.Drawing.Point(299, 42)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(536, 89)
        Me.Panel8.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(284, 28)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 30)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "Save Now"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(37, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 20)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Grade Effective Date:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(178, 34)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker5.TabIndex = 27
        '
        'tbFilePath
        '
        Me.tbFilePath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tbFilePath.Location = New System.Drawing.Point(3, 61)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(420, 20)
        Me.tbFilePath.TabIndex = 29
        Me.tbFilePath.TabStop = False
        Me.tbFilePath.Text = "Browse an Excel File Here to Upload Data..."
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.White
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.Color.Black
        Me.btnOpenFile.Location = New System.Drawing.Point(429, 57)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(86, 24)
        Me.btnOpenFile.TabIndex = 30
        Me.btnOpenFile.Text = "Browse File"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label10.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(532, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Grade Upgrade Management"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Acc_ShortTermAdvances11BindingSource
        '
        Me.Tbl_Acc_ShortTermAdvances11BindingSource.DataMember = "tbl_Acc_ShortTermAdvances11"
        Me.Tbl_Acc_ShortTermAdvances11BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_Card_New123BindingSource
        '
        Me.Tbl_HRM_Card_New123BindingSource.DataMember = "tbl_HRM_Card_New123"
        Me.Tbl_HRM_Card_New123BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_CardAdvBindingSource
        '
        Me.Tbl_HRM_CardAdvBindingSource.DataMember = "tbl_HRM_CardAdv"
        Me.Tbl_HRM_CardAdvBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_FinancialPeriodAdvBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodAdvBindingSource.DataMember = "tbl_Acc_FinancialPeriodAdv"
        Me.Tbl_Acc_FinancialPeriodAdvBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Fin_Layer4_NewBindingSource
        '
        Me.Tbl_Fin_Layer4_NewBindingSource.DataMember = "tbl_Fin_Layer4_New"
        Me.Tbl_Fin_Layer4_NewBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_FinancialPeriod11BindingSource
        '
        Me.Tbl_Acc_FinancialPeriod11BindingSource.DataMember = "tbl_Acc_FinancialPeriod11"
        Me.Tbl_Acc_FinancialPeriod11BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_BonusNoBindingSource
        '
        Me.Tbl_Acc_BonusNoBindingSource.DataMember = "tbl_Acc_BonusNo"
        Me.Tbl_Acc_BonusNoBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Acc_PermanentAdvancesBindingSource
        '
        Me.Tbl_Acc_PermanentAdvancesBindingSource.DataMember = "tbl_Acc_PermanentAdvances"
        Me.Tbl_Acc_PermanentAdvancesBindingSource.DataSource = Me.DSAdvance
        '
        'View_Acc_Fin_Ded_VouchersBindingSource
        '
        Me.View_Acc_Fin_Ded_VouchersBindingSource.DataMember = "View_Acc_Fin_Ded_Vouchers"
        Me.View_Acc_Fin_Ded_VouchersBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_HRM_Card_NewBindingSource
        '
        Me.Tbl_HRM_Card_NewBindingSource.DataSource = Me.DSAdvance
        Me.Tbl_HRM_Card_NewBindingSource.Position = 0
        '
        'Tbl_Acc_ShortTermAdvancesBindingSource
        '
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataMember = "View_Rpt_HR_EmpData_ActiveNonActive_tbl_Acc_ShortTermAdvances"
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataSource = Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1203, 39)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Grade Upgrade Management "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Acc_BonusNoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriod11TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodAdvTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_PermanentAdvancesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_ShortTermAdvances11TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_ShortTermAdvancesTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Fin_DebitCredit_Entry1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Fin_DebitCredit_EntryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Fin_Journal_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Fin_Layer4_NewTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSAdvanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_Card_InfoTableAdapter
        '
        Me.View_Card_InfoTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter
        '
        Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Card11TableAdapter
        '
        Me.Tbl_HRM_Card11TableAdapter.ClearBeforeFill = True
        '
        'CardNoLabel5
        '
        Me.CardNoLabel5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Card_InfoBindingSource, "EmpID", True))
        Me.CardNoLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.CardNoLabel5.Location = New System.Drawing.Point(7, 334)
        Me.CardNoLabel5.Name = "CardNoLabel5"
        Me.CardNoLabel5.Size = New System.Drawing.Size(100, 10)
        Me.CardNoLabel5.TabIndex = 16
        Me.CardNoLabel5.Text = "Label9"
        '
        'Tbl_Acc_ShortTermAdvancesTableAdapter
        '
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_ShortTermAdvances11TableAdapter
        '
        Me.Tbl_Acc_ShortTermAdvances11TableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tbl_Hrm_Emp_Info_H1BindingSource
        '
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataMember = "Tbl_Hrm_Emp_Info_H1"
        Me.Tbl_Hrm_Emp_Info_H1BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Hrm_Emp_Info_H1TableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_PermanentAdvancesTableAdapter
        '
        Me.Tbl_Acc_PermanentAdvancesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_CardAdvTableAdapter
        '
        Me.Tbl_HRM_CardAdvTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fin_Layer4_NewTableAdapter
        '
        Me.Tbl_Fin_Layer4_NewTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriod11TableAdapter
        '
        Me.Tbl_Acc_FinancialPeriod11TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_BonusNoTableAdapter
        '
        Me.Tbl_Acc_BonusNoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodAdvTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodAdvTableAdapter.ClearBeforeFill = True
        '
        'View_Acc_Fin_Ded_VouchersTableAdapter
        '
        Me.View_Acc_Fin_Ded_VouchersTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fin_Journal_HeadBindingSource
        '
        Me.Tbl_Fin_Journal_HeadBindingSource.DataMember = "tbl_Fin_Journal_Head"
        Me.Tbl_Fin_Journal_HeadBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Fin_Journal_HeadTableAdapter
        '
        Me.Tbl_Fin_Journal_HeadTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fin_DebitCredit_EntryBindingSource
        '
        Me.Tbl_Fin_DebitCredit_EntryBindingSource.DataMember = "tbl_Fin_DebitCredit_Entry"
        Me.Tbl_Fin_DebitCredit_EntryBindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Fin_DebitCredit_EntryTableAdapter
        '
        Me.Tbl_Fin_DebitCredit_EntryTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Fin_DebitCredit_Entry1BindingSource
        '
        Me.Tbl_Fin_DebitCredit_Entry1BindingSource.DataMember = "Tbl_Fin_DebitCredit_Entry1"
        Me.Tbl_Fin_DebitCredit_Entry1BindingSource.DataSource = Me.DSAdvance
        '
        'Tbl_Fin_DebitCredit_Entry1TableAdapter
        '
        Me.Tbl_Fin_DebitCredit_Entry1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Card_NewTableAdapter
        '
        Me.Tbl_HRM_Card_NewTableAdapter.ClearBeforeFill = True
        '
        'CardNoLabel3
        '
        Me.CardNoLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_CardBindingSource, "EmpID", True))
        Me.CardNoLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.CardNoLabel3.Location = New System.Drawing.Point(17, 304)
        Me.CardNoLabel3.Name = "CardNoLabel3"
        Me.CardNoLabel3.Size = New System.Drawing.Size(100, 16)
        Me.CardNoLabel3.TabIndex = 14
        Me.CardNoLabel3.Text = "Label9"
        '
        'Tbl_HRM_Card_New123TableAdapter
        '
        Me.Tbl_HRM_Card_New123TableAdapter.ClearBeforeFill = True
        '
        'DSDept
        '
        Me.DSDept.DataSetName = "DSDept"
        Me.DSDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSDept
        '
        'Tbl_HRM_GradeTableAdapter
        '
        Me.Tbl_HRM_GradeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_HRM_Dept_NewTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_GradeTableAdapter = Me.Tbl_HRM_GradeTableAdapter
        Me.TableAdapterManager1.tbl_HRM_Section_NewTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSDeptTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.View_Inactive_EmpTableAdapter = Nothing
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(888, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 20)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Error Records"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(857, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(889, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Saved Records"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.ForestGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(857, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 87
        '
        'frmGradeUpG1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 838)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CardNoLabel5)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.CardNoLabel3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmGradeUpG1"
        Me.Text = "Grade Upgrade Management"
        CType(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAdvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Card_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.Tbl_Acc_ShortTermAdvances11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card_New123BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardAdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodAdvBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fin_Layer4_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriod11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_BonusNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_PermanentAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_Fin_Ded_VouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Card_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_H1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fin_Journal_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fin_DebitCredit_EntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Fin_DebitCredit_Entry1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DSAdvance As DSAdvance
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSAdvanceTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents TableAdapterManager As DSAdvanceTableAdapters.TableAdapterManager
    Friend WithEvents View_Card_InfoBindingSource As BindingSource
    Friend WithEvents View_Card_InfoTableAdapter As DSAdvanceTableAdapters.View_Card_InfoTableAdapter
    Friend WithEvents View_Rpt_HR_EmpData_ActiveNonActiveBindingSource As BindingSource
    Friend WithEvents View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter As DSAdvanceTableAdapters.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter
    Friend WithEvents Tbl_HRM_Card11BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card11TableAdapter As DSAdvanceTableAdapters.tbl_HRM_Card11TableAdapter
    Friend WithEvents CardNoLabel5 As Label
    Friend WithEvents Tbl_Acc_ShortTermAdvancesBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_ShortTermAdvancesTableAdapter As DSAdvanceTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter
    Friend WithEvents Tbl_Acc_ShortTermAdvances11BindingSource As BindingSource
    Friend WithEvents Tbl_Acc_ShortTermAdvances11TableAdapter As DSAdvanceTableAdapters.tbl_Acc_ShortTermAdvances11TableAdapter
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Tbl_Hrm_Emp_Info_H1BindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_H1TableAdapter As DSAdvanceTableAdapters.Tbl_Hrm_Emp_Info_H1TableAdapter
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSAdvanceTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents Tbl_Acc_PermanentAdvancesBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_PermanentAdvancesTableAdapter As DSAdvanceTableAdapters.tbl_Acc_PermanentAdvancesTableAdapter
    Friend WithEvents Tbl_HRM_CardAdvBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardAdvTableAdapter As DSAdvanceTableAdapters.tbl_HRM_CardAdvTableAdapter
    Friend WithEvents Tbl_Fin_Layer4_NewBindingSource As BindingSource
    Friend WithEvents Tbl_Fin_Layer4_NewTableAdapter As DSAdvanceTableAdapters.tbl_Fin_Layer4_NewTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriod11BindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriod11TableAdapter As DSAdvanceTableAdapters.tbl_Acc_FinancialPeriod11TableAdapter
    Friend WithEvents Tbl_Acc_BonusNoBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_BonusNoTableAdapter As DSAdvanceTableAdapters.tbl_Acc_BonusNoTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodAdvBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodAdvTableAdapter As DSAdvanceTableAdapters.tbl_Acc_FinancialPeriodAdvTableAdapter
    Friend WithEvents View_Acc_Fin_Ded_VouchersBindingSource As BindingSource
    Friend WithEvents View_Acc_Fin_Ded_VouchersTableAdapter As DSAdvanceTableAdapters.View_Acc_Fin_Ded_VouchersTableAdapter
    Friend WithEvents Tbl_Fin_Journal_HeadBindingSource As BindingSource
    Friend WithEvents Tbl_Fin_Journal_HeadTableAdapter As DSAdvanceTableAdapters.tbl_Fin_Journal_HeadTableAdapter
    Friend WithEvents Tbl_Fin_DebitCredit_EntryBindingSource As BindingSource
    Friend WithEvents Tbl_Fin_DebitCredit_EntryTableAdapter As DSAdvanceTableAdapters.tbl_Fin_DebitCredit_EntryTableAdapter
    Friend WithEvents Tbl_Fin_DebitCredit_Entry1BindingSource As BindingSource
    Friend WithEvents Tbl_Fin_DebitCredit_Entry1TableAdapter As DSAdvanceTableAdapters.Tbl_Fin_DebitCredit_Entry1TableAdapter
    Friend WithEvents Tbl_HRM_Card_NewBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card_NewTableAdapter As DSAdvanceTableAdapters.tbl_HRM_Card_NewTableAdapter
    Friend WithEvents CardNoLabel3 As Label
    Friend WithEvents Tbl_HRM_Card_New123BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Card_New123TableAdapter As DSAdvanceTableAdapters.tbl_HRM_Card_New123TableAdapter
    Friend WithEvents DSDept As DSDept
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSDeptTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents TableAdapterManager1 As DSDeptTableAdapters.TableAdapterManager
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
