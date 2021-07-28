<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMadication
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
        Dim Label1 As System.Windows.Forms.Label
        Dim NextVisitLabel As System.Windows.Forms.Label
        Dim SeverityLabel As System.Windows.Forms.Label
        Dim NarrationLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim BloodGroupLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMadication))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Tbl_HRM_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMedication = New ERP_HRMS.DSMedication()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CheckTimeLabel1 = New System.Windows.Forms.Label()
        Me.AgeLabel1 = New System.Windows.Forms.Label()
        Me.CheckDateLabel1 = New System.Windows.Forms.Label()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.cardNo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboDiagnose5 = New System.Windows.Forms.ComboBox()
        Me.View_Diagnosis_Category_5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboDiagnose4 = New System.Windows.Forms.ComboBox()
        Me.View_Diagnosis_Category_4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboDiagnose3 = New System.Windows.Forms.ComboBox()
        Me.View_Diagnosis_Category_3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboDiagnose2 = New System.Windows.Forms.ComboBox()
        Me.View_Diagnosis_Category_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboDiagnose1 = New System.Windows.Forms.ComboBox()
        Me.View_Diagnosis_Category_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_MedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboDes5 = New System.Windows.Forms.ComboBox()
        Me.ComboDes4 = New System.Windows.Forms.ComboBox()
        Me.ComboDes3 = New System.Windows.Forms.ComboBox()
        Me.ComboDes2 = New System.Windows.Forms.ComboBox()
        Me.ComboDes1 = New System.Windows.Forms.ComboBox()
        Me.TextQty5 = New System.Windows.Forms.TextBox()
        Me.TextQty4 = New System.Windows.Forms.TextBox()
        Me.TextQty3 = New System.Windows.Forms.TextBox()
        Me.TextQty2 = New System.Windows.Forms.TextBox()
        Me.TextQty1 = New System.Windows.Forms.TextBox()
        Me.ComboTreatment5 = New System.Windows.Forms.ComboBox()
        Me.View_Treatment_ID4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboTreatment4 = New System.Windows.Forms.ComboBox()
        Me.View_Treatment_ID3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboTreatment3 = New System.Windows.Forms.ComboBox()
        Me.View_Treatment_ID2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboTreatment2 = New System.Windows.Forms.ComboBox()
        Me.View_Treatment_ID1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboTreatment1 = New System.Windows.Forms.ComboBox()
        Me.View_Treatment_IDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Treatment_Category_5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Treatment_Category_4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Treatment_Category_3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Treatment_Category_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Treatment_Category_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_InfoTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_InfoTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSMedicationTableAdapters.TableAdapterManager()
        Me.View_Diagnosis_Category_1TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Diagnosis_Category_1TableAdapter()
        Me.View_Diagnosis_Category_2TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Diagnosis_Category_2TableAdapter()
        Me.View_Diagnosis_Category_3TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Diagnosis_Category_3TableAdapter()
        Me.View_Diagnosis_Category_4TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Diagnosis_Category_4TableAdapter()
        Me.View_Diagnosis_Category_5TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Diagnosis_Category_5TableAdapter()
        Me.View_Treatment_Category_1TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_Category_1TableAdapter()
        Me.View_Treatment_Category_2TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_Category_2TableAdapter()
        Me.View_Treatment_Category_3TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_Category_3TableAdapter()
        Me.View_Treatment_Category_4TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_Category_4TableAdapter()
        Me.View_Treatment_Category_5TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_Category_5TableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboTest4 = New System.Windows.Forms.ComboBox()
        Me.View_Recommended_Test_4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboTest3 = New System.Windows.Forms.ComboBox()
        Me.View_Recommended_Test_3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboTest2 = New System.Windows.Forms.ComboBox()
        Me.View_Recommended_Test_2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboTest1 = New System.Windows.Forms.ComboBox()
        Me.View_Recommended_Test_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_MedicationTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_MedicationTableAdapter()
        Me.View_Recommended_Test_1TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Recommended_Test_1TableAdapter()
        Me.View_Recommended_Test_2TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Recommended_Test_2TableAdapter()
        Me.View_Recommended_Test_3TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Recommended_Test_3TableAdapter()
        Me.View_Recommended_Test_4TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Recommended_Test_4TableAdapter()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LeaveCombo = New System.Windows.Forms.ComboBox()
        Me.ComboReferTo = New System.Windows.Forms.ComboBox()
        Me.View_Refer_ToBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SeverityComboBox = New System.Windows.Forms.ComboBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.View_MadicationDataGridView = New System.Windows.Forms.DataGridView()
        Me.SrNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DesigName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.View_MadicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_AllEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_AllEmployeesTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BloodGroupLabel2 = New System.Windows.Forms.Label()
        Me.Agelabel = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DateOfJoinging = New System.Windows.Forms.Label()
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tbl_PayRoll_LongLeavesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tbl_PayRoll_LongLeavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_PayRoll_LongLeavesTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_PayRoll_LongLeavesTableAdapter()
        Me.View_MadicationTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_MadicationTableAdapter()
        Me.View_Refer_ToTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Refer_ToTableAdapter()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.Tbl_HRM_Emp_Med_ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.tbl_HRM_Emp_Med_ItemTableAdapter()
        Me.View_Treatment_IDTableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_IDTableAdapter()
        Me.View_Treatment_ID1TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_ID1TableAdapter()
        Me.View_Treatment_ID2TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_ID2TableAdapter()
        Me.View_Treatment_ID3TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_ID3TableAdapter()
        Me.View_Treatment_ID4TableAdapter = New ERP_HRMS.DSMedicationTableAdapters.View_Treatment_ID4TableAdapter()
        Label1 = New System.Windows.Forms.Label()
        NextVisitLabel = New System.Windows.Forms.Label()
        SeverityLabel = New System.Windows.Forms.Label()
        NarrationLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        BloodGroupLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.View_Diagnosis_Category_5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Diagnosis_Category_4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Diagnosis_Category_3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Diagnosis_Category_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Diagnosis_Category_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_MedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.View_Treatment_ID4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_ID3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_ID2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_ID1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_IDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_Category_5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_Category_4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_Category_3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_Category_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Treatment_Category_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.View_Recommended_Test_4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Recommended_Test_3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Recommended_Test_2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Recommended_Test_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.View_Refer_ToBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.View_MadicationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MadicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_PayRoll_LongLeavesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PayRoll_LongLeavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Med_ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Black
        Label1.Location = New System.Drawing.Point(9, 41)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(49, 13)
        Label1.TabIndex = 16
        Label1.Text = "Card No:"
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NextVisitLabel
        '
        NextVisitLabel.AutoSize = True
        NextVisitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NextVisitLabel.ForeColor = System.Drawing.Color.Black
        NextVisitLabel.Location = New System.Drawing.Point(181, 21)
        NextVisitLabel.Name = "NextVisitLabel"
        NextVisitLabel.Size = New System.Drawing.Size(54, 13)
        NextVisitLabel.TabIndex = 13
        NextVisitLabel.Text = "Next Visit:"
        '
        'SeverityLabel
        '
        SeverityLabel.AutoSize = True
        SeverityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SeverityLabel.ForeColor = System.Drawing.Color.Black
        SeverityLabel.Location = New System.Drawing.Point(7, 21)
        SeverityLabel.Name = "SeverityLabel"
        SeverityLabel.Size = New System.Drawing.Size(48, 13)
        SeverityLabel.TabIndex = 11
        SeverityLabel.Text = "Severity:"
        '
        'NarrationLabel
        '
        NarrationLabel.AutoSize = True
        NarrationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NarrationLabel.ForeColor = System.Drawing.Color.Black
        NarrationLabel.Location = New System.Drawing.Point(7, 44)
        NarrationLabel.Name = "NarrationLabel"
        NarrationLabel.Size = New System.Drawing.Size(48, 13)
        NarrationLabel.TabIndex = 11
        NarrationLabel.Text = "Refer to:"
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(5, 3)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(66, 18)
        Label7.TabIndex = 32
        Label7.Text = "Name:"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptNameLabel
        '
        DeptNameLabel.Location = New System.Drawing.Point(5, 26)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(66, 18)
        DeptNameLabel.TabIndex = 36
        DeptNameLabel.Text = "Department:"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        DesigNameLabel.Location = New System.Drawing.Point(5, 49)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(66, 18)
        DesigNameLabel.TabIndex = 34
        DesigNameLabel.Text = "Section:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BloodGroupLabel
        '
        BloodGroupLabel.AutoSize = True
        BloodGroupLabel.ForeColor = System.Drawing.Color.Black
        BloodGroupLabel.Location = New System.Drawing.Point(236, 30)
        BloodGroupLabel.Name = "BloodGroupLabel"
        BloodGroupLabel.Size = New System.Drawing.Size(69, 13)
        BloodGroupLabel.TabIndex = 18
        BloodGroupLabel.Text = "Blood Group:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(236, 53)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(29, 13)
        Label4.TabIndex = 20
        Label4.Text = "Age:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Black
        Label3.Location = New System.Drawing.Point(7, 69)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(40, 13)
        Label3.TabIndex = 17
        Label3.Text = "Leave:"
        '
        'Tbl_HRM_Emp_InfoBindingSource
        '
        Me.Tbl_HRM_Emp_InfoBindingSource.DataMember = "tbl_HRM_Emp_Info"
        Me.Tbl_HRM_Emp_InfoBindingSource.DataSource = Me.DSMedication
        '
        'DSMedication
        '
        Me.DSMedication.DataSetName = "DSMedication"
        Me.DSMedication.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CheckTimeLabel1)
        Me.Panel3.Controls.Add(Me.AgeLabel1)
        Me.Panel3.Controls.Add(Me.CheckDateLabel1)
        Me.Panel3.Controls.Add(Label1)
        Me.Panel3.Controls.Add(Me.BindingNavigator3)
        Me.Panel3.Controls.Add(Me.cardNo)
        Me.Panel3.Location = New System.Drawing.Point(18, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(219, 72)
        Me.Panel3.TabIndex = 0
        '
        'CheckTimeLabel1
        '
        Me.CheckTimeLabel1.Location = New System.Drawing.Point(392, 78)
        Me.CheckTimeLabel1.Name = "CheckTimeLabel1"
        Me.CheckTimeLabel1.Size = New System.Drawing.Size(10, 10)
        Me.CheckTimeLabel1.TabIndex = 8
        '
        'AgeLabel1
        '
        Me.AgeLabel1.Location = New System.Drawing.Point(353, 75)
        Me.AgeLabel1.Name = "AgeLabel1"
        Me.AgeLabel1.Size = New System.Drawing.Size(10, 10)
        Me.AgeLabel1.TabIndex = 9
        '
        'CheckDateLabel1
        '
        Me.CheckDateLabel1.Location = New System.Drawing.Point(369, 72)
        Me.CheckDateLabel1.Name = "CheckDateLabel1"
        Me.CheckDateLabel1.Size = New System.Drawing.Size(11, 10)
        Me.CheckDateLabel1.TabIndex = 7
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.ToolStripButton9
        Me.BindingNavigator3.BindingSource = Me.Tbl_HRM_Emp_InfoBindingSource
        Me.BindingNavigator3.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator3.DeleteItem = Me.ToolStripButton10
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton13, Me.ToolStripButton14, Me.ToolStripSeparator6, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripButton15})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.ToolStripButton11
        Me.BindingNavigator3.MoveLastItem = Me.ToolStripButton14
        Me.BindingNavigator3.MoveNextItem = Me.ToolStripButton13
        Me.BindingNavigator3.MovePreviousItem = Me.ToolStripButton12
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator3.Size = New System.Drawing.Size(217, 25)
        Me.BindingNavigator3.TabIndex = 2
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton9.Text = "Add new"
        Me.ToolStripButton9.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton10.Text = "Delete"
        Me.ToolStripButton10.Visible = False
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move first"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Move next"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripButton15.Text = "Save Data"
        Me.ToolStripButton15.Visible = False
        '
        'cardNo
        '
        Me.cardNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cardNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cardNo.BackColor = System.Drawing.Color.White
        Me.cardNo.DataSource = Me.Tbl_HRM_Emp_InfoBindingSource
        Me.cardNo.DisplayMember = "CardNo"
        Me.cardNo.ForeColor = System.Drawing.Color.Black
        Me.cardNo.FormattingEnabled = True
        Me.cardNo.Location = New System.Drawing.Point(64, 37)
        Me.cardNo.Name = "cardNo"
        Me.cardNo.Size = New System.Drawing.Size(94, 21)
        Me.cardNo.TabIndex = 0
        Me.cardNo.ValueMember = "EmpID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboDiagnose5)
        Me.GroupBox2.Controls.Add(Me.ComboDiagnose4)
        Me.GroupBox2.Controls.Add(Me.ComboDiagnose3)
        Me.GroupBox2.Controls.Add(Me.ComboDiagnose2)
        Me.GroupBox2.Controls.Add(Me.ComboDiagnose1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 160)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Diagnosis"
        '
        'ComboDiagnose5
        '
        Me.ComboDiagnose5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDiagnose5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDiagnose5.DataSource = Me.View_Diagnosis_Category_5BindingSource
        Me.ComboDiagnose5.DisplayMember = "Madication"
        Me.ComboDiagnose5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDiagnose5.FormattingEnabled = True
        Me.ComboDiagnose5.Location = New System.Drawing.Point(7, 127)
        Me.ComboDiagnose5.Name = "ComboDiagnose5"
        Me.ComboDiagnose5.Size = New System.Drawing.Size(357, 21)
        Me.ComboDiagnose5.TabIndex = 4
        Me.ComboDiagnose5.ValueMember = "Madication"
        '
        'View_Diagnosis_Category_5BindingSource
        '
        Me.View_Diagnosis_Category_5BindingSource.DataMember = "View_Diagnosis Category 5"
        Me.View_Diagnosis_Category_5BindingSource.DataSource = Me.DSMedication
        '
        'ComboDiagnose4
        '
        Me.ComboDiagnose4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDiagnose4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDiagnose4.DataSource = Me.View_Diagnosis_Category_4BindingSource
        Me.ComboDiagnose4.DisplayMember = "Madication"
        Me.ComboDiagnose4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDiagnose4.FormattingEnabled = True
        Me.ComboDiagnose4.Location = New System.Drawing.Point(6, 100)
        Me.ComboDiagnose4.Name = "ComboDiagnose4"
        Me.ComboDiagnose4.Size = New System.Drawing.Size(357, 21)
        Me.ComboDiagnose4.TabIndex = 3
        Me.ComboDiagnose4.ValueMember = "Madication"
        '
        'View_Diagnosis_Category_4BindingSource
        '
        Me.View_Diagnosis_Category_4BindingSource.DataMember = "View_Diagnosis Category 4"
        Me.View_Diagnosis_Category_4BindingSource.DataSource = Me.DSMedication
        '
        'ComboDiagnose3
        '
        Me.ComboDiagnose3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDiagnose3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDiagnose3.DataSource = Me.View_Diagnosis_Category_3BindingSource
        Me.ComboDiagnose3.DisplayMember = "Madication"
        Me.ComboDiagnose3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDiagnose3.FormattingEnabled = True
        Me.ComboDiagnose3.Location = New System.Drawing.Point(7, 73)
        Me.ComboDiagnose3.Name = "ComboDiagnose3"
        Me.ComboDiagnose3.Size = New System.Drawing.Size(357, 21)
        Me.ComboDiagnose3.TabIndex = 2
        Me.ComboDiagnose3.ValueMember = "Madication"
        '
        'View_Diagnosis_Category_3BindingSource
        '
        Me.View_Diagnosis_Category_3BindingSource.DataMember = "View_Diagnosis Category 3"
        Me.View_Diagnosis_Category_3BindingSource.DataSource = Me.DSMedication
        '
        'ComboDiagnose2
        '
        Me.ComboDiagnose2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDiagnose2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDiagnose2.DataSource = Me.View_Diagnosis_Category_2BindingSource
        Me.ComboDiagnose2.DisplayMember = "Madication"
        Me.ComboDiagnose2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDiagnose2.FormattingEnabled = True
        Me.ComboDiagnose2.Location = New System.Drawing.Point(7, 46)
        Me.ComboDiagnose2.Name = "ComboDiagnose2"
        Me.ComboDiagnose2.Size = New System.Drawing.Size(357, 21)
        Me.ComboDiagnose2.TabIndex = 1
        Me.ComboDiagnose2.ValueMember = "Madication"
        '
        'View_Diagnosis_Category_2BindingSource
        '
        Me.View_Diagnosis_Category_2BindingSource.DataMember = "View_Diagnosis Category 2"
        Me.View_Diagnosis_Category_2BindingSource.DataSource = Me.DSMedication
        '
        'ComboDiagnose1
        '
        Me.ComboDiagnose1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDiagnose1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDiagnose1.DataSource = Me.View_Diagnosis_Category_1BindingSource
        Me.ComboDiagnose1.DisplayMember = "Madication"
        Me.ComboDiagnose1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDiagnose1.FormattingEnabled = True
        Me.ComboDiagnose1.Location = New System.Drawing.Point(7, 19)
        Me.ComboDiagnose1.Name = "ComboDiagnose1"
        Me.ComboDiagnose1.Size = New System.Drawing.Size(357, 21)
        Me.ComboDiagnose1.TabIndex = 0
        Me.ComboDiagnose1.ValueMember = "Madication"
        '
        'View_Diagnosis_Category_1BindingSource
        '
        Me.View_Diagnosis_Category_1BindingSource.DataMember = "View_Diagnosis Category 1"
        Me.View_Diagnosis_Category_1BindingSource.DataSource = Me.DSMedication
        '
        'Tbl_HRM_Emp_MedicationBindingSource
        '
        Me.Tbl_HRM_Emp_MedicationBindingSource.DataMember = "tbl_HRM_Emp_Medication"
        Me.Tbl_HRM_Emp_MedicationBindingSource.DataSource = Me.DSMedication
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboDes5)
        Me.GroupBox3.Controls.Add(Me.ComboDes4)
        Me.GroupBox3.Controls.Add(Me.ComboDes3)
        Me.GroupBox3.Controls.Add(Me.ComboDes2)
        Me.GroupBox3.Controls.Add(Me.ComboDes1)
        Me.GroupBox3.Controls.Add(Me.TextQty5)
        Me.GroupBox3.Controls.Add(Me.TextQty4)
        Me.GroupBox3.Controls.Add(Me.TextQty3)
        Me.GroupBox3.Controls.Add(Me.TextQty2)
        Me.GroupBox3.Controls.Add(Me.TextQty1)
        Me.GroupBox3.Controls.Add(Me.ComboTreatment5)
        Me.GroupBox3.Controls.Add(Me.ComboTreatment4)
        Me.GroupBox3.Controls.Add(Me.ComboTreatment3)
        Me.GroupBox3.Controls.Add(Me.ComboTreatment2)
        Me.GroupBox3.Controls.Add(Me.ComboTreatment1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(388, 157)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 156)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Treatments"
        '
        'ComboDes5
        '
        Me.ComboDes5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDes5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDes5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_MedicationBindingSource, "TreatmentName", True))
        Me.ComboDes5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDes5.FormattingEnabled = True
        Me.ComboDes5.Items.AddRange(New Object() {"1 ", "1 + 1", "1 + 1 +1", "2", "2 + 2 ", "2 + 2 +2", "3", "3 + 3", "3 + 3 +3"})
        Me.ComboDes5.Location = New System.Drawing.Point(259, 127)
        Me.ComboDes5.Name = "ComboDes5"
        Me.ComboDes5.Size = New System.Drawing.Size(103, 21)
        Me.ComboDes5.TabIndex = 14
        '
        'ComboDes4
        '
        Me.ComboDes4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDes4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDes4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_MedicationBindingSource, "TreatmentName", True))
        Me.ComboDes4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDes4.FormattingEnabled = True
        Me.ComboDes4.Items.AddRange(New Object() {"1 ", "1 + 1", "1 + 1 +1", "2", "2 + 2 ", "2 + 2 +2", "3", "3 + 3", "3 + 3 +3"})
        Me.ComboDes4.Location = New System.Drawing.Point(259, 100)
        Me.ComboDes4.Name = "ComboDes4"
        Me.ComboDes4.Size = New System.Drawing.Size(103, 21)
        Me.ComboDes4.TabIndex = 13
        '
        'ComboDes3
        '
        Me.ComboDes3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDes3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDes3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_MedicationBindingSource, "TreatmentName", True))
        Me.ComboDes3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDes3.FormattingEnabled = True
        Me.ComboDes3.Items.AddRange(New Object() {"1 ", "1 + 1", "1 + 1 +1", "2", "2 + 2 ", "2 + 2 +2", "3", "3 + 3", "3 + 3 +3"})
        Me.ComboDes3.Location = New System.Drawing.Point(259, 73)
        Me.ComboDes3.Name = "ComboDes3"
        Me.ComboDes3.Size = New System.Drawing.Size(103, 21)
        Me.ComboDes3.TabIndex = 12
        '
        'ComboDes2
        '
        Me.ComboDes2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDes2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDes2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_MedicationBindingSource, "TreatmentName", True))
        Me.ComboDes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDes2.FormattingEnabled = True
        Me.ComboDes2.Items.AddRange(New Object() {"1 ", "1 + 1", "1 + 1 +1", "2", "2 + 2 ", "2 + 2 +2", "3", "3 + 3", "3 + 3 +3"})
        Me.ComboDes2.Location = New System.Drawing.Point(259, 46)
        Me.ComboDes2.Name = "ComboDes2"
        Me.ComboDes2.Size = New System.Drawing.Size(103, 21)
        Me.ComboDes2.TabIndex = 11
        '
        'ComboDes1
        '
        Me.ComboDes1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDes1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDes1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_MedicationBindingSource, "TreatmentName", True))
        Me.ComboDes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDes1.FormattingEnabled = True
        Me.ComboDes1.Items.AddRange(New Object() {"1 ", "1 + 1", "1 + 1 +1", "2", "2 + 2 ", "2 + 2 +2", "3", "3 + 3", "3 + 3 +3"})
        Me.ComboDes1.Location = New System.Drawing.Point(259, 19)
        Me.ComboDes1.Name = "ComboDes1"
        Me.ComboDes1.Size = New System.Drawing.Size(103, 21)
        Me.ComboDes1.TabIndex = 10
        '
        'TextQty5
        '
        Me.TextQty5.Location = New System.Drawing.Point(192, 127)
        Me.TextQty5.Name = "TextQty5"
        Me.TextQty5.Size = New System.Drawing.Size(61, 20)
        Me.TextQty5.TabIndex = 9
        Me.TextQty5.Text = "0"
        Me.TextQty5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextQty4
        '
        Me.TextQty4.Location = New System.Drawing.Point(192, 100)
        Me.TextQty4.Name = "TextQty4"
        Me.TextQty4.Size = New System.Drawing.Size(61, 20)
        Me.TextQty4.TabIndex = 8
        Me.TextQty4.Text = "0"
        Me.TextQty4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextQty3
        '
        Me.TextQty3.Location = New System.Drawing.Point(192, 73)
        Me.TextQty3.Name = "TextQty3"
        Me.TextQty3.Size = New System.Drawing.Size(61, 20)
        Me.TextQty3.TabIndex = 7
        Me.TextQty3.Text = "0"
        Me.TextQty3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextQty2
        '
        Me.TextQty2.Location = New System.Drawing.Point(192, 46)
        Me.TextQty2.Name = "TextQty2"
        Me.TextQty2.Size = New System.Drawing.Size(61, 20)
        Me.TextQty2.TabIndex = 6
        Me.TextQty2.Text = "0"
        Me.TextQty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextQty1
        '
        Me.TextQty1.Location = New System.Drawing.Point(192, 19)
        Me.TextQty1.Name = "TextQty1"
        Me.TextQty1.Size = New System.Drawing.Size(61, 20)
        Me.TextQty1.TabIndex = 5
        Me.TextQty1.Text = "0"
        Me.TextQty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ComboTreatment5
        '
        Me.ComboTreatment5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTreatment5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTreatment5.DataSource = Me.View_Treatment_ID4BindingSource
        Me.ComboTreatment5.DisplayMember = "L2Name"
        Me.ComboTreatment5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTreatment5.FormattingEnabled = True
        Me.ComboTreatment5.Location = New System.Drawing.Point(7, 127)
        Me.ComboTreatment5.Name = "ComboTreatment5"
        Me.ComboTreatment5.Size = New System.Drawing.Size(180, 21)
        Me.ComboTreatment5.TabIndex = 4
        Me.ComboTreatment5.ValueMember = "L2ID"
        '
        'View_Treatment_ID4BindingSource
        '
        Me.View_Treatment_ID4BindingSource.DataMember = "View_Treatment_ID4"
        Me.View_Treatment_ID4BindingSource.DataSource = Me.DSMedication
        '
        'ComboTreatment4
        '
        Me.ComboTreatment4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTreatment4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTreatment4.DataSource = Me.View_Treatment_ID3BindingSource
        Me.ComboTreatment4.DisplayMember = "L2Name"
        Me.ComboTreatment4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTreatment4.FormattingEnabled = True
        Me.ComboTreatment4.Location = New System.Drawing.Point(6, 100)
        Me.ComboTreatment4.Name = "ComboTreatment4"
        Me.ComboTreatment4.Size = New System.Drawing.Size(180, 21)
        Me.ComboTreatment4.TabIndex = 3
        Me.ComboTreatment4.ValueMember = "L2ID"
        '
        'View_Treatment_ID3BindingSource
        '
        Me.View_Treatment_ID3BindingSource.DataMember = "View_Treatment_ID3"
        Me.View_Treatment_ID3BindingSource.DataSource = Me.DSMedication
        '
        'ComboTreatment3
        '
        Me.ComboTreatment3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTreatment3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTreatment3.DataSource = Me.View_Treatment_ID2BindingSource
        Me.ComboTreatment3.DisplayMember = "L2Name"
        Me.ComboTreatment3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTreatment3.FormattingEnabled = True
        Me.ComboTreatment3.Location = New System.Drawing.Point(7, 73)
        Me.ComboTreatment3.Name = "ComboTreatment3"
        Me.ComboTreatment3.Size = New System.Drawing.Size(180, 21)
        Me.ComboTreatment3.TabIndex = 2
        Me.ComboTreatment3.ValueMember = "L2ID"
        '
        'View_Treatment_ID2BindingSource
        '
        Me.View_Treatment_ID2BindingSource.DataMember = "View_Treatment_ID2"
        Me.View_Treatment_ID2BindingSource.DataSource = Me.DSMedication
        '
        'ComboTreatment2
        '
        Me.ComboTreatment2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTreatment2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTreatment2.DataSource = Me.View_Treatment_ID1BindingSource
        Me.ComboTreatment2.DisplayMember = "L2Name"
        Me.ComboTreatment2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTreatment2.FormattingEnabled = True
        Me.ComboTreatment2.Location = New System.Drawing.Point(7, 46)
        Me.ComboTreatment2.Name = "ComboTreatment2"
        Me.ComboTreatment2.Size = New System.Drawing.Size(180, 21)
        Me.ComboTreatment2.TabIndex = 1
        Me.ComboTreatment2.ValueMember = "L2ID"
        '
        'View_Treatment_ID1BindingSource
        '
        Me.View_Treatment_ID1BindingSource.DataMember = "View_Treatment_ID1"
        Me.View_Treatment_ID1BindingSource.DataSource = Me.DSMedication
        '
        'ComboTreatment1
        '
        Me.ComboTreatment1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTreatment1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTreatment1.DataSource = Me.View_Treatment_IDBindingSource
        Me.ComboTreatment1.DisplayMember = "L2Name"
        Me.ComboTreatment1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTreatment1.FormattingEnabled = True
        Me.ComboTreatment1.Location = New System.Drawing.Point(7, 19)
        Me.ComboTreatment1.Name = "ComboTreatment1"
        Me.ComboTreatment1.Size = New System.Drawing.Size(180, 21)
        Me.ComboTreatment1.TabIndex = 0
        Me.ComboTreatment1.ValueMember = "L2ID"
        '
        'View_Treatment_IDBindingSource
        '
        Me.View_Treatment_IDBindingSource.DataMember = "View_Treatment_ID"
        Me.View_Treatment_IDBindingSource.DataSource = Me.DSMedication
        '
        'View_Treatment_Category_5BindingSource
        '
        Me.View_Treatment_Category_5BindingSource.DataMember = "View_Treatment Category 5"
        Me.View_Treatment_Category_5BindingSource.DataSource = Me.DSMedication
        '
        'View_Treatment_Category_4BindingSource
        '
        Me.View_Treatment_Category_4BindingSource.DataMember = "View_Treatment Category 4"
        Me.View_Treatment_Category_4BindingSource.DataSource = Me.DSMedication
        '
        'View_Treatment_Category_3BindingSource
        '
        Me.View_Treatment_Category_3BindingSource.DataMember = "View_Treatment Category 3"
        Me.View_Treatment_Category_3BindingSource.DataSource = Me.DSMedication
        '
        'View_Treatment_Category_2BindingSource
        '
        Me.View_Treatment_Category_2BindingSource.DataMember = "View_Treatment Category 2"
        Me.View_Treatment_Category_2BindingSource.DataSource = Me.DSMedication
        '
        'View_Treatment_Category_1BindingSource
        '
        Me.View_Treatment_Category_1BindingSource.DataMember = "View_Treatment Category 1"
        Me.View_Treatment_Category_1BindingSource.DataSource = Me.DSMedication
        '
        'Tbl_HRM_Emp_InfoTableAdapter
        '
        Me.Tbl_HRM_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Me.Tbl_HRM_Emp_InfoTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_Med_Item_HeadTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Med_ItemTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Medication_INTableAdapter = Nothing
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
        'View_Diagnosis_Category_1TableAdapter
        '
        Me.View_Diagnosis_Category_1TableAdapter.ClearBeforeFill = True
        '
        'View_Diagnosis_Category_2TableAdapter
        '
        Me.View_Diagnosis_Category_2TableAdapter.ClearBeforeFill = True
        '
        'View_Diagnosis_Category_3TableAdapter
        '
        Me.View_Diagnosis_Category_3TableAdapter.ClearBeforeFill = True
        '
        'View_Diagnosis_Category_4TableAdapter
        '
        Me.View_Diagnosis_Category_4TableAdapter.ClearBeforeFill = True
        '
        'View_Diagnosis_Category_5TableAdapter
        '
        Me.View_Diagnosis_Category_5TableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_Category_1TableAdapter
        '
        Me.View_Treatment_Category_1TableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_Category_2TableAdapter
        '
        Me.View_Treatment_Category_2TableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_Category_3TableAdapter
        '
        Me.View_Treatment_Category_3TableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_Category_4TableAdapter
        '
        Me.View_Treatment_Category_4TableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_Category_5TableAdapter
        '
        Me.View_Treatment_Category_5TableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboTest4)
        Me.GroupBox4.Controls.Add(Me.ComboTest3)
        Me.GroupBox4.Controls.Add(Me.ComboTest2)
        Me.GroupBox4.Controls.Add(Me.ComboTest1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(12, 320)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(370, 126)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recommended Test"
        '
        'ComboTest4
        '
        Me.ComboTest4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTest4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTest4.DataSource = Me.View_Recommended_Test_4BindingSource
        Me.ComboTest4.DisplayMember = "Madication"
        Me.ComboTest4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTest4.FormattingEnabled = True
        Me.ComboTest4.Location = New System.Drawing.Point(6, 100)
        Me.ComboTest4.Name = "ComboTest4"
        Me.ComboTest4.Size = New System.Drawing.Size(357, 21)
        Me.ComboTest4.TabIndex = 3
        Me.ComboTest4.ValueMember = "Madication"
        '
        'View_Recommended_Test_4BindingSource
        '
        Me.View_Recommended_Test_4BindingSource.DataMember = "View_Recommended Test 4"
        Me.View_Recommended_Test_4BindingSource.DataSource = Me.DSMedication
        '
        'ComboTest3
        '
        Me.ComboTest3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTest3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTest3.DataSource = Me.View_Recommended_Test_3BindingSource
        Me.ComboTest3.DisplayMember = "Madication"
        Me.ComboTest3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTest3.FormattingEnabled = True
        Me.ComboTest3.Location = New System.Drawing.Point(7, 73)
        Me.ComboTest3.Name = "ComboTest3"
        Me.ComboTest3.Size = New System.Drawing.Size(357, 21)
        Me.ComboTest3.TabIndex = 2
        Me.ComboTest3.ValueMember = "Madication"
        '
        'View_Recommended_Test_3BindingSource
        '
        Me.View_Recommended_Test_3BindingSource.DataMember = "View_Recommended Test 3"
        Me.View_Recommended_Test_3BindingSource.DataSource = Me.DSMedication
        '
        'ComboTest2
        '
        Me.ComboTest2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTest2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTest2.DataSource = Me.View_Recommended_Test_2BindingSource
        Me.ComboTest2.DisplayMember = "Madication"
        Me.ComboTest2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTest2.FormattingEnabled = True
        Me.ComboTest2.Location = New System.Drawing.Point(7, 46)
        Me.ComboTest2.Name = "ComboTest2"
        Me.ComboTest2.Size = New System.Drawing.Size(357, 21)
        Me.ComboTest2.TabIndex = 1
        Me.ComboTest2.ValueMember = "Madication"
        '
        'View_Recommended_Test_2BindingSource
        '
        Me.View_Recommended_Test_2BindingSource.DataMember = "View_Recommended Test 2"
        Me.View_Recommended_Test_2BindingSource.DataSource = Me.DSMedication
        '
        'ComboTest1
        '
        Me.ComboTest1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboTest1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboTest1.DataSource = Me.View_Recommended_Test_1BindingSource
        Me.ComboTest1.DisplayMember = "Madication"
        Me.ComboTest1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTest1.FormattingEnabled = True
        Me.ComboTest1.Location = New System.Drawing.Point(7, 19)
        Me.ComboTest1.Name = "ComboTest1"
        Me.ComboTest1.Size = New System.Drawing.Size(357, 21)
        Me.ComboTest1.TabIndex = 0
        Me.ComboTest1.ValueMember = "Madication"
        '
        'View_Recommended_Test_1BindingSource
        '
        Me.View_Recommended_Test_1BindingSource.DataMember = "View_Recommended Test 1"
        Me.View_Recommended_Test_1BindingSource.DataSource = Me.DSMedication
        '
        'Tbl_HRM_Emp_MedicationTableAdapter
        '
        Me.Tbl_HRM_Emp_MedicationTableAdapter.ClearBeforeFill = True
        '
        'View_Recommended_Test_1TableAdapter
        '
        Me.View_Recommended_Test_1TableAdapter.ClearBeforeFill = True
        '
        'View_Recommended_Test_2TableAdapter
        '
        Me.View_Recommended_Test_2TableAdapter.ClearBeforeFill = True
        '
        'View_Recommended_Test_3TableAdapter
        '
        Me.View_Recommended_Test_3TableAdapter.ClearBeforeFill = True
        '
        'View_Recommended_Test_4TableAdapter
        '
        Me.View_Recommended_Test_4TableAdapter.ClearBeforeFill = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LeaveCombo)
        Me.GroupBox5.Controls.Add(Label3)
        Me.GroupBox5.Controls.Add(Me.ComboReferTo)
        Me.GroupBox5.Controls.Add(NarrationLabel)
        Me.GroupBox5.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.SeverityComboBox)
        Me.GroupBox5.Controls.Add(NextVisitLabel)
        Me.GroupBox5.Controls.Add(SeverityLabel)
        Me.GroupBox5.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(391, 320)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(370, 122)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Any Comments"
        '
        'LeaveCombo
        '
        Me.LeaveCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeaveCombo.FormattingEnabled = True
        Me.LeaveCombo.Items.AddRange(New Object() {"", "Short Leave", "Half Day", "Full Day"})
        Me.LeaveCombo.Location = New System.Drawing.Point(60, 66)
        Me.LeaveCombo.Name = "LeaveCombo"
        Me.LeaveCombo.Size = New System.Drawing.Size(109, 21)
        Me.LeaveCombo.TabIndex = 16
        '
        'ComboReferTo
        '
        Me.ComboReferTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboReferTo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboReferTo.DataSource = Me.View_Refer_ToBindingSource
        Me.ComboReferTo.DisplayMember = "Madication"
        Me.ComboReferTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboReferTo.FormattingEnabled = True
        Me.ComboReferTo.Location = New System.Drawing.Point(60, 42)
        Me.ComboReferTo.Name = "ComboReferTo"
        Me.ComboReferTo.Size = New System.Drawing.Size(300, 21)
        Me.ComboReferTo.TabIndex = 2
        Me.ComboReferTo.ValueMember = "Madication"
        '
        'View_Refer_ToBindingSource
        '
        Me.View_Refer_ToBindingSource.DataMember = "View_Refer_To"
        Me.View_Refer_ToBindingSource.DataSource = Me.DSMedication
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(343, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(15, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(184, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save Record"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SeverityComboBox
        '
        Me.SeverityComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SeverityComboBox.FormattingEnabled = True
        Me.SeverityComboBox.Items.AddRange(New Object() {"Critical", "High", "Moderate", "Low"})
        Me.SeverityComboBox.Location = New System.Drawing.Point(60, 18)
        Me.SeverityComboBox.Name = "SeverityComboBox"
        Me.SeverityComboBox.Size = New System.Drawing.Size(109, 21)
        Me.SeverityComboBox.TabIndex = 0
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(236, 18)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(107, 20)
        Me.MaskedTextBox1.TabIndex = 1
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.View_MadicationDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 450)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 266)
        Me.Panel1.TabIndex = 11
        '
        'View_MadicationDataGridView
        '
        Me.View_MadicationDataGridView.AllowUserToAddRows = False
        Me.View_MadicationDataGridView.AllowUserToDeleteRows = False
        Me.View_MadicationDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_MadicationDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_MadicationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_MadicationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrNo, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DeptName, Me.DesigName, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn14, Me.Column1, Me.Delete})
        Me.View_MadicationDataGridView.DataSource = Me.View_MadicationBindingSource
        Me.View_MadicationDataGridView.Location = New System.Drawing.Point(4, 3)
        Me.View_MadicationDataGridView.Name = "View_MadicationDataGridView"
        Me.View_MadicationDataGridView.ReadOnly = True
        Me.View_MadicationDataGridView.RowHeadersWidth = 21
        Me.View_MadicationDataGridView.Size = New System.Drawing.Size(868, 258)
        Me.View_MadicationDataGridView.TabIndex = 1
        '
        'SrNo
        '
        Me.SrNo.DataPropertyName = "SrNo"
        Me.SrNo.HeaderText = "SrNo"
        Me.SrNo.Name = "SrNo"
        Me.SrNo.ReadOnly = True
        Me.SrNo.Width = 60
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CardNo"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CardNo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DeptName
        '
        Me.DeptName.DataPropertyName = "DeptName"
        Me.DeptName.HeaderText = "Department"
        Me.DeptName.Name = "DeptName"
        Me.DeptName.ReadOnly = True
        '
        'DesigName
        '
        Me.DesigName.DataPropertyName = "DesigName"
        Me.DesigName.HeaderText = "Designation"
        Me.DesigName.Name = "DesigName"
        Me.DesigName.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Severity"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Severity"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "NextVisit"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn14.HeaderText = "Next Visit"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Show Report"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = "Show Report"
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'Delete
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        Me.Delete.DefaultCellStyle = DataGridViewCellStyle3
        Me.Delete.HeaderText = "Delete Record"
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Text = "Delete Record"
        Me.Delete.UseColumnTextForButtonValue = True
        '
        'View_MadicationBindingSource
        '
        Me.View_MadicationBindingSource.DataMember = "View_Madication"
        Me.View_MadicationBindingSource.DataSource = Me.DSMedication
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1031, 40)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Patient Medication"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_Rpt_Acc_AllEmployeesBindingSource
        '
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataMember = "View_Rpt_Acc_AllEmployees"
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataSource = Me.DSMedication
        '
        'View_Rpt_Acc_AllEmployeesTableAdapter
        '
        Me.View_Rpt_Acc_AllEmployeesTableAdapter.ClearBeforeFill = True
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(5, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Designation:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(236, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 20)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "D.O.J:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BloodGroupLabel2
        '
        Me.BloodGroupLabel2.BackColor = System.Drawing.Color.White
        Me.BloodGroupLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BloodGroupLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "BloodGroup", True))
        Me.BloodGroupLabel2.ForeColor = System.Drawing.Color.Black
        Me.BloodGroupLabel2.Location = New System.Drawing.Point(309, 26)
        Me.BloodGroupLabel2.Name = "BloodGroupLabel2"
        Me.BloodGroupLabel2.Size = New System.Drawing.Size(90, 20)
        Me.BloodGroupLabel2.TabIndex = 19
        Me.BloodGroupLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Agelabel
        '
        Me.Agelabel.BackColor = System.Drawing.Color.White
        Me.Agelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Agelabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "Age", True))
        Me.Agelabel.ForeColor = System.Drawing.Color.Black
        Me.Agelabel.Location = New System.Drawing.Point(309, 49)
        Me.Agelabel.Name = "Agelabel"
        Me.Agelabel.Size = New System.Drawing.Size(90, 20)
        Me.Agelabel.TabIndex = 21
        Me.Agelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Controls.Add(Me.DateOfJoinging)
        Me.Panel6.Controls.Add(Label4)
        Me.Panel6.Controls.Add(Me.DeptNameLabel1)
        Me.Panel6.Controls.Add(Me.NameLabel1)
        Me.Panel6.Controls.Add(Me.DesigNameLabel1)
        Me.Panel6.Controls.Add(Me.Agelabel)
        Me.Panel6.Controls.Add(Me.BloodGroupLabel2)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(BloodGroupLabel)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(DesigNameLabel)
        Me.Panel6.Controls.Add(DeptNameLabel)
        Me.Panel6.Controls.Add(Label7)
        Me.Panel6.Location = New System.Drawing.Point(243, 51)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(506, 100)
        Me.Panel6.TabIndex = 44
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DesigName", True))
        Me.Label13.Location = New System.Drawing.Point(74, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.View_Rpt_Acc_AllEmployeesBindingSource, "EmpPic", True))
        Me.PictureBox2.Location = New System.Drawing.Point(413, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 86)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'DateOfJoinging
        '
        Me.DateOfJoinging.BackColor = System.Drawing.Color.White
        Me.DateOfJoinging.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DateOfJoinging.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DateOFJoining", True))
        Me.DateOfJoinging.Location = New System.Drawing.Point(309, 72)
        Me.DateOfJoinging.Name = "DateOfJoinging"
        Me.DateOfJoinging.Size = New System.Drawing.Size(90, 20)
        Me.DateOfJoinging.TabIndex = 49
        Me.DateOfJoinging.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "SectionName", True))
        Me.DeptNameLabel1.Location = New System.Drawing.Point(74, 49)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(154, 20)
        Me.DeptNameLabel1.TabIndex = 47
        Me.DeptNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel1
        '
        Me.NameLabel1.BackColor = System.Drawing.Color.White
        Me.NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(74, 3)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(325, 20)
        Me.NameLabel1.TabIndex = 45
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.BackColor = System.Drawing.Color.White
        Me.DesigNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_AllEmployeesBindingSource, "DeptName", True))
        Me.DesigNameLabel1.Location = New System.Drawing.Point(74, 26)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(154, 20)
        Me.DesigNameLabel1.TabIndex = 46
        Me.DesigNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tbl_PayRoll_LongLeavesDataGridView)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(764, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 144)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leaves Record"
        '
        'Tbl_PayRoll_LongLeavesDataGridView
        '
        Me.Tbl_PayRoll_LongLeavesDataGridView.AllowUserToAddRows = False
        Me.Tbl_PayRoll_LongLeavesDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Tbl_PayRoll_LongLeavesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Tbl_PayRoll_LongLeavesDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tbl_PayRoll_LongLeavesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Tbl_PayRoll_LongLeavesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tbl_PayRoll_LongLeavesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Tbl_PayRoll_LongLeavesDataGridView.DataSource = Me.Tbl_PayRoll_LongLeavesBindingSource
        Me.Tbl_PayRoll_LongLeavesDataGridView.Location = New System.Drawing.Point(8, 15)
        Me.Tbl_PayRoll_LongLeavesDataGridView.Name = "Tbl_PayRoll_LongLeavesDataGridView"
        Me.Tbl_PayRoll_LongLeavesDataGridView.ReadOnly = True
        Me.Tbl_PayRoll_LongLeavesDataGridView.RowHeadersWidth = 10
        Me.Tbl_PayRoll_LongLeavesDataGridView.Size = New System.Drawing.Size(223, 123)
        Me.Tbl_PayRoll_LongLeavesDataGridView.TabIndex = 58
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LeaveType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LeaveType"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TotalDays"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Avail Leaves"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'Tbl_PayRoll_LongLeavesBindingSource
        '
        Me.Tbl_PayRoll_LongLeavesBindingSource.DataMember = "tbl_PayRoll_LongLeaves"
        Me.Tbl_PayRoll_LongLeavesBindingSource.DataSource = Me.DSMedication
        '
        'Tbl_PayRoll_LongLeavesTableAdapter
        '
        Me.Tbl_PayRoll_LongLeavesTableAdapter.ClearBeforeFill = True
        '
        'View_MadicationTableAdapter
        '
        Me.View_MadicationTableAdapter.ClearBeforeFill = True
        '
        'View_Refer_ToTableAdapter
        '
        Me.View_Refer_ToTableAdapter.ClearBeforeFill = True
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'Tbl_HRM_Emp_Med_ItemBindingSource
        '
        Me.Tbl_HRM_Emp_Med_ItemBindingSource.DataMember = "tbl_HRM_Emp_Med_Item"
        Me.Tbl_HRM_Emp_Med_ItemBindingSource.DataSource = Me.DSMedication
        '
        'Tbl_HRM_Emp_Med_ItemTableAdapter
        '
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_IDTableAdapter
        '
        Me.View_Treatment_IDTableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_ID1TableAdapter
        '
        Me.View_Treatment_ID1TableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_ID2TableAdapter
        '
        Me.View_Treatment_ID2TableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_ID3TableAdapter
        '
        Me.View_Treatment_ID3TableAdapter.ClearBeforeFill = True
        '
        'View_Treatment_ID4TableAdapter
        '
        Me.View_Treatment_ID4TableAdapter.ClearBeforeFill = True
        '
        'frmMadication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 736)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMadication"
        Me.Text = "frmMadication"
        CType(Me.Tbl_HRM_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMedication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.View_Diagnosis_Category_5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Diagnosis_Category_4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Diagnosis_Category_3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Diagnosis_Category_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Diagnosis_Category_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_MedicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.View_Treatment_ID4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_ID3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_ID2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_ID1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_IDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_Category_5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_Category_4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_Category_3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_Category_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Treatment_Category_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.View_Recommended_Test_4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Recommended_Test_3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Recommended_Test_2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Recommended_Test_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.View_Refer_ToBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.View_MadicationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MadicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Tbl_PayRoll_LongLeavesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PayRoll_LongLeavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Med_ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckTimeLabel1 As Label
    Friend WithEvents AgeLabel1 As Label
    Friend WithEvents CheckDateLabel1 As Label
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripButton11 As ToolStripButton
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton13 As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripButton15 As ToolStripButton
    Friend WithEvents cardNo As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DSMedication As DSMedication
    Friend WithEvents Tbl_HRM_Emp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_InfoTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_InfoTableAdapter
    Friend WithEvents TableAdapterManager As DSMedicationTableAdapters.TableAdapterManager
    Friend WithEvents View_Diagnosis_Category_1BindingSource As BindingSource
    Friend WithEvents View_Diagnosis_Category_1TableAdapter As DSMedicationTableAdapters.View_Diagnosis_Category_1TableAdapter
    Friend WithEvents View_Diagnosis_Category_2BindingSource As BindingSource
    Friend WithEvents View_Diagnosis_Category_2TableAdapter As DSMedicationTableAdapters.View_Diagnosis_Category_2TableAdapter
    Friend WithEvents View_Diagnosis_Category_3BindingSource As BindingSource
    Friend WithEvents View_Diagnosis_Category_3TableAdapter As DSMedicationTableAdapters.View_Diagnosis_Category_3TableAdapter
    Friend WithEvents View_Diagnosis_Category_4BindingSource As BindingSource
    Friend WithEvents View_Diagnosis_Category_4TableAdapter As DSMedicationTableAdapters.View_Diagnosis_Category_4TableAdapter
    Friend WithEvents View_Diagnosis_Category_5BindingSource As BindingSource
    Friend WithEvents View_Diagnosis_Category_5TableAdapter As DSMedicationTableAdapters.View_Diagnosis_Category_5TableAdapter
    Friend WithEvents View_Treatment_Category_1BindingSource As BindingSource
    Friend WithEvents View_Treatment_Category_1TableAdapter As DSMedicationTableAdapters.View_Treatment_Category_1TableAdapter
    Friend WithEvents View_Treatment_Category_2BindingSource As BindingSource
    Friend WithEvents View_Treatment_Category_2TableAdapter As DSMedicationTableAdapters.View_Treatment_Category_2TableAdapter
    Friend WithEvents View_Treatment_Category_3BindingSource As BindingSource
    Friend WithEvents View_Treatment_Category_3TableAdapter As DSMedicationTableAdapters.View_Treatment_Category_3TableAdapter
    Friend WithEvents View_Treatment_Category_4BindingSource As BindingSource
    Friend WithEvents View_Treatment_Category_4TableAdapter As DSMedicationTableAdapters.View_Treatment_Category_4TableAdapter
    Friend WithEvents View_Treatment_Category_5BindingSource As BindingSource
    Friend WithEvents View_Treatment_Category_5TableAdapter As DSMedicationTableAdapters.View_Treatment_Category_5TableAdapter
    Friend WithEvents ComboDiagnose1 As ComboBox
    Friend WithEvents ComboDiagnose5 As ComboBox
    Friend WithEvents ComboDiagnose4 As ComboBox
    Friend WithEvents ComboDiagnose3 As ComboBox
    Friend WithEvents ComboDiagnose2 As ComboBox
    Friend WithEvents ComboTreatment5 As ComboBox
    Friend WithEvents ComboTreatment4 As ComboBox
    Friend WithEvents ComboTreatment3 As ComboBox
    Friend WithEvents ComboTreatment2 As ComboBox
    Friend WithEvents ComboTreatment1 As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ComboTest4 As ComboBox
    Friend WithEvents ComboTest3 As ComboBox
    Friend WithEvents ComboTest2 As ComboBox
    Friend WithEvents Tbl_HRM_Emp_MedicationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_MedicationTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_MedicationTableAdapter
    Friend WithEvents ComboTest1 As ComboBox
    Friend WithEvents View_Recommended_Test_1BindingSource As BindingSource
    Friend WithEvents View_Recommended_Test_1TableAdapter As DSMedicationTableAdapters.View_Recommended_Test_1TableAdapter
    Friend WithEvents View_Recommended_Test_2BindingSource As BindingSource
    Friend WithEvents View_Recommended_Test_2TableAdapter As DSMedicationTableAdapters.View_Recommended_Test_2TableAdapter
    Friend WithEvents View_Recommended_Test_3BindingSource As BindingSource
    Friend WithEvents View_Recommended_Test_3TableAdapter As DSMedicationTableAdapters.View_Recommended_Test_3TableAdapter
    Friend WithEvents View_Recommended_Test_4BindingSource As BindingSource
    Friend WithEvents View_Recommended_Test_4TableAdapter As DSMedicationTableAdapters.View_Recommended_Test_4TableAdapter
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents SeverityComboBox As ComboBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents View_Rpt_Acc_AllEmployeesBindingSource As BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployeesTableAdapter As DSMedicationTableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents BloodGroupLabel2 As Label
    Friend WithEvents Agelabel As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents DateOfJoinging As Label
    Friend WithEvents DeptNameLabel1 As Label
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents DesigNameLabel1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tbl_PayRoll_LongLeavesBindingSource As BindingSource
    Friend WithEvents Tbl_PayRoll_LongLeavesTableAdapter As DSMedicationTableAdapters.tbl_PayRoll_LongLeavesTableAdapter
    Friend WithEvents Tbl_PayRoll_LongLeavesDataGridView As DataGridView
    Friend WithEvents View_MadicationBindingSource As BindingSource
    Friend WithEvents View_MadicationTableAdapter As DSMedicationTableAdapters.View_MadicationTableAdapter
    Friend WithEvents ComboReferTo As ComboBox
    Friend WithEvents View_Refer_ToBindingSource As BindingSource
    Friend WithEvents View_Refer_ToTableAdapter As DSMedicationTableAdapters.View_Refer_ToTableAdapter
    Friend WithEvents LeaveCombo As ComboBox
    Friend WithEvents ComboDes5 As ComboBox
    Friend WithEvents ComboDes4 As ComboBox
    Friend WithEvents ComboDes3 As ComboBox
    Friend WithEvents ComboDes2 As ComboBox
    Friend WithEvents ComboDes1 As ComboBox
    Friend WithEvents TextQty5 As TextBox
    Friend WithEvents TextQty4 As TextBox
    Friend WithEvents TextQty3 As TextBox
    Friend WithEvents TextQty2 As TextBox
    Friend WithEvents TextQty1 As TextBox
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Tbl_HRM_Emp_Med_ItemBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Med_ItemTableAdapter As DSMedicationTableAdapters.tbl_HRM_Emp_Med_ItemTableAdapter
    Friend WithEvents View_Treatment_IDBindingSource As BindingSource
    Friend WithEvents View_Treatment_IDTableAdapter As DSMedicationTableAdapters.View_Treatment_IDTableAdapter
    Friend WithEvents View_Treatment_ID1BindingSource As BindingSource
    Friend WithEvents View_Treatment_ID1TableAdapter As DSMedicationTableAdapters.View_Treatment_ID1TableAdapter
    Friend WithEvents View_Treatment_ID2BindingSource As BindingSource
    Friend WithEvents View_Treatment_ID2TableAdapter As DSMedicationTableAdapters.View_Treatment_ID2TableAdapter
    Friend WithEvents View_Treatment_ID3BindingSource As BindingSource
    Friend WithEvents View_Treatment_ID3TableAdapter As DSMedicationTableAdapters.View_Treatment_ID3TableAdapter
    Friend WithEvents View_Treatment_ID4BindingSource As BindingSource
    Friend WithEvents View_Treatment_ID4TableAdapter As DSMedicationTableAdapters.View_Treatment_ID4TableAdapter
    Friend WithEvents View_MadicationDataGridView As DataGridView
    Friend WithEvents SrNo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DeptName As DataGridViewTextBoxColumn
    Friend WithEvents DesigName As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
End Class
