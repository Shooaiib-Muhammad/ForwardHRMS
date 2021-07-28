<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpDataToExcel
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
        Me.btnExport = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DSExcelEmpData = New ERP_HRMS.DSExcelEmpData()
        Me.View_AgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_AgeTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_AgeTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSExcelEmpDataTableAdapters.TableAdapterManager()
        Me.View_DOJ_AgeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_DOJ_AgeTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Doj_AgeTableAdapter()
        Me.View_DOJ_Age1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_DOJ_Age1TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Doj_Age1TableAdapter()
        Me.View_DOJ_Age11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_DOJ_Age11TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_DOJ_Age11TableAdapter()
        Me.View_Age1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Age1TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Age1TableAdapter()
        Me.View_Rpt_Acc_AllEmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_AllEmployeesTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter()
        Me.View_Rpt_Acc_AllEmployees111BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_AllEmployees111TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Acc_AllEmployees111TableAdapter()
        Me.View_Excel_Emp_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Excel_Emp_DataTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_DataTableAdapter()
        Me.View_Excel_Emp_DurationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Excel_Emp_DurationTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_DurationTableAdapter()
        Me.Tbl_Hrm_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_InfoTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_HRM_Emp_InfoTableAdapter()
        Me.View_Excel_Emp_Job_TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Excel_Emp_Job_TypeTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_Job_TypeTableAdapter()
        Me.View_Excel_Emp_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Excel_Emp_SalaryTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_SalaryTableAdapter()
        Me.View_Excel_Emp_Job_LevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Excel_Emp_Job_LevelTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_Job_LevelTableAdapter()
        Me.View_Excel_Emp_Job_Level11BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Excel_Emp_Job_Level11TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_Job_Level11TableAdapter()
        Me.View_Rpt_Current_Month_EducationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Current_Month_EducationTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Current_Month_EducationTableAdapter()
        Me.View_Rpt_Out_Month_EducationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Out_Month_EducationTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Out_Month_EducationTableAdapter()
        Me.View_Rpt_Out_Month_MaritalStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Out_Month_MaritalStatusTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Out_Month_MaritalStatusTableAdapter()
        Me.View_Rpt_Current_Month_MaritalStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Current_Month_MaritalStatusTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Current_Month_MaritalStatusTableAdapter()
        Me.View_Current_Month_DurationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Current_Month_DurationTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Current_Month_DurationTableAdapter()
        Me.View_Out_Month_DurationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Out_Month_DurationTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Out_Month_DurationTableAdapter()
        Me.View_OUT_Month_Salary1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_OUT_Month_Salary1TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_OUT_Month_Salary1TableAdapter()
        Me.View_Current_Month_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Current_Month_SalaryTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Current_Month_SalaryTableAdapter()
        Me.View_Current_Month_JobLevelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Current_Month_JobLevelTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Current_Month_JobLevelTableAdapter()
        Me.View_OUT_Month_JobLevel1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_OUT_Month_JobLevel1TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_OUT_Month_JobLevel1TableAdapter()
        Me.View_OUT_Month_Employee_Status1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_OUT_Month_Employee_Status1TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_OUT_Month_Employee_Status1TableAdapter()
        Me.View_Current_Month_Employee_StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Current_Month_Employee_StatusTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Current_Month_Employee_StatusTableAdapter()
        Me.Tbl_Hrm_Emp_Info_INBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_INTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Hrm_Emp_Info_INTableAdapter()
        Me.Tbl_Hrm_Emp_Info_LeavingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Info_LeavingTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Hrm_Emp_Info_LeavingTableAdapter()
        Me.View_Age_MaritalStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Age_MaritalStatusTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Age_MaritalStatusTableAdapter()
        Me.View_Emp_Data_Duration_GradeWiseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_Data_Duration_GradeWiseTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Emp_Data_Duration_GradeWiseTableAdapter()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_AttTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.Tbl_Hrm_Emp_New_Att1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_New_Att1TableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Hrm_Emp_New_Att1TableAdapter()
        Me.Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter()
        Me.View_Att_Emp_CountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Att_Emp_CountTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Att_Emp_CountTableAdapter()
        Me.Tbl_Holiday_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Holiday_DetailTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Holiday_DetailTableAdapter()
        Me.View_Att_Emp_OTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Att_Emp_OTTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Att_Emp_OTTableAdapter()
        Me.View_Att_Emp_ValueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Att_Emp_ValueTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Att_Emp_ValueTableAdapter()
        Me.View_Att_Emp_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Att_Emp_DeptTableAdapter = New ERP_HRMS.DSExcelEmpDataTableAdapters.View_Att_Emp_DeptTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DSExcelEmpData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_AgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_DOJ_AgeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_DOJ_Age1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_DOJ_Age11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Age1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_AllEmployees111BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Excel_Emp_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Excel_Emp_DurationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Excel_Emp_Job_TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Excel_Emp_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Excel_Emp_Job_LevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Excel_Emp_Job_Level11BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Current_Month_EducationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Out_Month_EducationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Out_Month_MaritalStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Current_Month_MaritalStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Current_Month_DurationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Out_Month_DurationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_OUT_Month_Salary1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Current_Month_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Current_Month_JobLevelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_OUT_Month_JobLevel1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_OUT_Month_Employee_Status1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Current_Month_Employee_StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_INBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Info_LeavingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Age_MaritalStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Data_Duration_GradeWiseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_New_Att1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Att_Emp_CountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Holiday_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Att_Emp_OTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Att_Emp_ValueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Att_Emp_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.Green
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Location = New System.Drawing.Point(134, 62)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(133, 47)
        Me.btnExport.TabIndex = 35
        Me.btnExport.Text = "Export To Excel"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(152, 20)
        Me.DateTimePicker1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Select Month:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1028, 40)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Employee Data To Excel"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(460, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 127)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export Employee Data To Excel"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(248, 213)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(187, 20)
        Me.RadioButton2.TabIndex = 39
        Me.RadioButton2.Text = "Employees Working Hours"
        Me.RadioButton2.UseVisualStyleBackColor = False
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(6, 30)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(152, 20)
        Me.RadioButton1.TabIndex = 38
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Employee Profile List"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 706)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1028, 36)
        Me.StatusStrip1.TabIndex = 99
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(800, 30)
        Me.ToolStripProgressBar1.Step = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(215, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 127)
        Me.GroupBox2.TabIndex = 100
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Type Selection"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(6, 56)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(225, 20)
        Me.RadioButton3.TabIndex = 40
        Me.RadioButton3.Text = "Employees Working Hours Detail"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 23)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'DSExcelEmpData
        '
        Me.DSExcelEmpData.DataSetName = "DSExcelEmpData"
        Me.DSExcelEmpData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_AgeBindingSource
        '
        Me.View_AgeBindingSource.DataMember = "View_Age"
        Me.View_AgeBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_AgeTableAdapter
        '
        Me.View_AgeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSExcelEmpDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_DOJ_AgeBindingSource
        '
        Me.View_DOJ_AgeBindingSource.DataSource = Me.DSExcelEmpData
        Me.View_DOJ_AgeBindingSource.Position = 0
        '
        'View_DOJ_AgeTableAdapter
        '
        Me.View_DOJ_AgeTableAdapter.ClearBeforeFill = True
        '
        'View_DOJ_Age1BindingSource
        '
        Me.View_DOJ_Age1BindingSource.DataMember = "View_DOJ_Age1"
        Me.View_DOJ_Age1BindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_DOJ_Age1TableAdapter
        '
        Me.View_DOJ_Age1TableAdapter.ClearBeforeFill = True
        '
        'View_DOJ_Age11BindingSource
        '
        Me.View_DOJ_Age11BindingSource.DataMember = "View_DOJ_Age11"
        Me.View_DOJ_Age11BindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_DOJ_Age11TableAdapter
        '
        Me.View_DOJ_Age11TableAdapter.ClearBeforeFill = True
        '
        'View_Age1BindingSource
        '
        Me.View_Age1BindingSource.DataSource = Me.DSExcelEmpData
        Me.View_Age1BindingSource.Position = 0
        '
        'View_Age1TableAdapter
        '
        Me.View_Age1TableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_AllEmployeesBindingSource
        '
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataMember = "View_Rpt_Acc_AllEmployees"
        Me.View_Rpt_Acc_AllEmployeesBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Rpt_Acc_AllEmployeesTableAdapter
        '
        Me.View_Rpt_Acc_AllEmployeesTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_AllEmployees111BindingSource
        '
        Me.View_Rpt_Acc_AllEmployees111BindingSource.DataMember = "View_Rpt_Acc_AllEmployees111"
        Me.View_Rpt_Acc_AllEmployees111BindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Rpt_Acc_AllEmployees111TableAdapter
        '
        Me.View_Rpt_Acc_AllEmployees111TableAdapter.ClearBeforeFill = True
        '
        'View_Excel_Emp_DataBindingSource
        '
        Me.View_Excel_Emp_DataBindingSource.DataMember = "View_Excel_Emp_Data"
        Me.View_Excel_Emp_DataBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Excel_Emp_DataTableAdapter
        '
        Me.View_Excel_Emp_DataTableAdapter.ClearBeforeFill = True
        '
        'View_Excel_Emp_DurationBindingSource
        '
        Me.View_Excel_Emp_DurationBindingSource.DataMember = "View_Excel_Emp_Duration"
        Me.View_Excel_Emp_DurationBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Excel_Emp_DurationTableAdapter
        '
        Me.View_Excel_Emp_DurationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_InfoBindingSource
        '
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataMember = "tbl_Hrm_Emp_Info"
        Me.Tbl_Hrm_Emp_InfoBindingSource.DataSource = Me.DSExcelEmpData
        '
        'Tbl_Hrm_Emp_InfoTableAdapter
        '
        Me.Tbl_Hrm_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'View_Excel_Emp_Job_TypeBindingSource
        '
        Me.View_Excel_Emp_Job_TypeBindingSource.DataMember = "View_Excel_Emp_Job_Type"
        Me.View_Excel_Emp_Job_TypeBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Excel_Emp_Job_TypeTableAdapter
        '
        Me.View_Excel_Emp_Job_TypeTableAdapter.ClearBeforeFill = True
        '
        'View_Excel_Emp_SalaryBindingSource
        '
        Me.View_Excel_Emp_SalaryBindingSource.DataMember = "View_Excel_Emp_Salary"
        Me.View_Excel_Emp_SalaryBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Excel_Emp_SalaryTableAdapter
        '
        Me.View_Excel_Emp_SalaryTableAdapter.ClearBeforeFill = True
        '
        'View_Excel_Emp_Job_LevelBindingSource
        '
        Me.View_Excel_Emp_Job_LevelBindingSource.DataSource = Me.DSExcelEmpData
        Me.View_Excel_Emp_Job_LevelBindingSource.Position = 0
        '
        'View_Excel_Emp_Job_LevelTableAdapter
        '
        Me.View_Excel_Emp_Job_LevelTableAdapter.ClearBeforeFill = True
        '
        'View_Excel_Emp_Job_Level11BindingSource
        '
        Me.View_Excel_Emp_Job_Level11BindingSource.DataMember = "View_Excel_Emp_Job_Level11"
        Me.View_Excel_Emp_Job_Level11BindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Excel_Emp_Job_Level11TableAdapter
        '
        Me.View_Excel_Emp_Job_Level11TableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Current_Month_EducationBindingSource
        '
        Me.View_Rpt_Current_Month_EducationBindingSource.DataMember = "View_Rpt_Current_Month_Education"
        Me.View_Rpt_Current_Month_EducationBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Rpt_Current_Month_EducationTableAdapter
        '
        Me.View_Rpt_Current_Month_EducationTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Out_Month_EducationBindingSource
        '
        Me.View_Rpt_Out_Month_EducationBindingSource.DataMember = "View_Rpt_Out_Month_Education"
        Me.View_Rpt_Out_Month_EducationBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Rpt_Out_Month_EducationTableAdapter
        '
        Me.View_Rpt_Out_Month_EducationTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Out_Month_MaritalStatusBindingSource
        '
        Me.View_Rpt_Out_Month_MaritalStatusBindingSource.DataMember = "View_Rpt_Out_Month_MaritalStatus"
        Me.View_Rpt_Out_Month_MaritalStatusBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Rpt_Out_Month_MaritalStatusTableAdapter
        '
        Me.View_Rpt_Out_Month_MaritalStatusTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Current_Month_MaritalStatusBindingSource
        '
        Me.View_Rpt_Current_Month_MaritalStatusBindingSource.DataMember = "View_Rpt_Current_Month_MaritalStatus"
        Me.View_Rpt_Current_Month_MaritalStatusBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Rpt_Current_Month_MaritalStatusTableAdapter
        '
        Me.View_Rpt_Current_Month_MaritalStatusTableAdapter.ClearBeforeFill = True
        '
        'View_Current_Month_DurationBindingSource
        '
        Me.View_Current_Month_DurationBindingSource.DataMember = "View_Current_Month_Duration"
        Me.View_Current_Month_DurationBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Current_Month_DurationTableAdapter
        '
        Me.View_Current_Month_DurationTableAdapter.ClearBeforeFill = True
        '
        'View_Out_Month_DurationBindingSource
        '
        Me.View_Out_Month_DurationBindingSource.DataMember = "View_Out_Month_Duration"
        Me.View_Out_Month_DurationBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Out_Month_DurationTableAdapter
        '
        Me.View_Out_Month_DurationTableAdapter.ClearBeforeFill = True
        '
        'View_OUT_Month_Salary1BindingSource
        '
        Me.View_OUT_Month_Salary1BindingSource.DataMember = "View_OUT_Month_Salary1"
        Me.View_OUT_Month_Salary1BindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_OUT_Month_Salary1TableAdapter
        '
        Me.View_OUT_Month_Salary1TableAdapter.ClearBeforeFill = True
        '
        'View_Current_Month_SalaryBindingSource
        '
        Me.View_Current_Month_SalaryBindingSource.DataMember = "View_Current_Month_Salary"
        Me.View_Current_Month_SalaryBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Current_Month_SalaryTableAdapter
        '
        Me.View_Current_Month_SalaryTableAdapter.ClearBeforeFill = True
        '
        'View_Current_Month_JobLevelBindingSource
        '
        Me.View_Current_Month_JobLevelBindingSource.DataMember = "View_Current_Month_JobLevel"
        Me.View_Current_Month_JobLevelBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Current_Month_JobLevelTableAdapter
        '
        Me.View_Current_Month_JobLevelTableAdapter.ClearBeforeFill = True
        '
        'View_OUT_Month_JobLevel1BindingSource
        '
        Me.View_OUT_Month_JobLevel1BindingSource.DataMember = "View_OUT_Month_JobLevel1"
        Me.View_OUT_Month_JobLevel1BindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_OUT_Month_JobLevel1TableAdapter
        '
        Me.View_OUT_Month_JobLevel1TableAdapter.ClearBeforeFill = True
        '
        'View_OUT_Month_Employee_Status1BindingSource
        '
        Me.View_OUT_Month_Employee_Status1BindingSource.DataMember = "View_OUT_Month_Employee_Status1"
        Me.View_OUT_Month_Employee_Status1BindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_OUT_Month_Employee_Status1TableAdapter
        '
        Me.View_OUT_Month_Employee_Status1TableAdapter.ClearBeforeFill = True
        '
        'View_Current_Month_Employee_StatusBindingSource
        '
        Me.View_Current_Month_Employee_StatusBindingSource.DataMember = "View_Current_Month_Employee_Status"
        Me.View_Current_Month_Employee_StatusBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Current_Month_Employee_StatusTableAdapter
        '
        Me.View_Current_Month_Employee_StatusTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_INBindingSource
        '
        Me.Tbl_Hrm_Emp_Info_INBindingSource.DataMember = "tbl_Hrm_Emp_Info_IN"
        Me.Tbl_Hrm_Emp_Info_INBindingSource.DataSource = Me.DSExcelEmpData
        '
        'Tbl_Hrm_Emp_Info_INTableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_INTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Info_LeavingBindingSource
        '
        Me.Tbl_Hrm_Emp_Info_LeavingBindingSource.DataMember = "tbl_Hrm_Emp_Info_Leaving"
        Me.Tbl_Hrm_Emp_Info_LeavingBindingSource.DataSource = Me.DSExcelEmpData
        '
        'Tbl_Hrm_Emp_Info_LeavingTableAdapter
        '
        Me.Tbl_Hrm_Emp_Info_LeavingTableAdapter.ClearBeforeFill = True
        '
        'View_Age_MaritalStatusBindingSource
        '
        Me.View_Age_MaritalStatusBindingSource.DataMember = "View_Age_MaritalStatus"
        Me.View_Age_MaritalStatusBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Age_MaritalStatusTableAdapter
        '
        Me.View_Age_MaritalStatusTableAdapter.ClearBeforeFill = True
        '
        'View_Emp_Data_Duration_GradeWiseBindingSource
        '
        Me.View_Emp_Data_Duration_GradeWiseBindingSource.DataMember = "View_Emp_Data_Duration_GradeWise"
        Me.View_Emp_Data_Duration_GradeWiseBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Emp_Data_Duration_GradeWiseTableAdapter
        '
        Me.View_Emp_Data_Duration_GradeWiseTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_AttBindingSource
        '
        Me.Tbl_Hrm_Emp_AttBindingSource.DataMember = "tbl_Hrm_Emp_Att"
        Me.Tbl_Hrm_Emp_AttBindingSource.DataSource = Me.DSExcelEmpData
        '
        'Tbl_Hrm_Emp_AttTableAdapter
        '
        Me.Tbl_Hrm_Emp_AttTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_New_Att1BindingSource
        '
        Me.Tbl_Hrm_Emp_New_Att1BindingSource.DataMember = "tbl_Hrm_Emp_New_Att1"
        Me.Tbl_Hrm_Emp_New_Att1BindingSource.DataSource = Me.DSExcelEmpData
        '
        'Tbl_Hrm_Emp_New_Att1TableAdapter
        '
        Me.Tbl_Hrm_Emp_New_Att1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource
        '
        Me.Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource.DataMember = "tbl_Acc_Salary_Transactions_WorkingDays"
        Me.Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource.DataSource = Me.DSExcelEmpData
        '
        'Tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter
        '
        Me.Tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter.ClearBeforeFill = True
        '
        'View_Att_Emp_CountBindingSource
        '
        Me.View_Att_Emp_CountBindingSource.DataMember = "View_Att_Emp_Count"
        Me.View_Att_Emp_CountBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Att_Emp_CountTableAdapter
        '
        Me.View_Att_Emp_CountTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Holiday_DetailBindingSource
        '
        Me.Tbl_Holiday_DetailBindingSource.DataMember = "tbl_Holiday_Detail"
        Me.Tbl_Holiday_DetailBindingSource.DataSource = Me.DSExcelEmpData
        '
        'Tbl_Holiday_DetailTableAdapter
        '
        Me.Tbl_Holiday_DetailTableAdapter.ClearBeforeFill = True
        '
        'View_Att_Emp_OTBindingSource
        '
        Me.View_Att_Emp_OTBindingSource.DataMember = "View_Att_Emp_OT"
        Me.View_Att_Emp_OTBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Att_Emp_OTTableAdapter
        '
        Me.View_Att_Emp_OTTableAdapter.ClearBeforeFill = True
        '
        'View_Att_Emp_ValueBindingSource
        '
        Me.View_Att_Emp_ValueBindingSource.DataMember = "View_Att_Emp_Value"
        Me.View_Att_Emp_ValueBindingSource.DataSource = Me.DSExcelEmpData
        '
        'View_Att_Emp_ValueTableAdapter
        '
        Me.View_Att_Emp_ValueTableAdapter.ClearBeforeFill = True
        '
        'View_Att_Emp_DeptBindingSource
        '
        Me.View_Att_Emp_DeptBindingSource.DataSource = Me.DSExcelEmpData
        Me.View_Att_Emp_DeptBindingSource.Position = 0
        '
        'View_Att_Emp_DeptTableAdapter
        '
        Me.View_Att_Emp_DeptTableAdapter.ClearBeforeFill = True
        '
        'frmEmpDataToExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 742)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "frmEmpDataToExcel"
        Me.Text = "Employee Data To Excel"
        Me.GroupBox1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DSExcelEmpData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_AgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_DOJ_AgeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_DOJ_Age1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_DOJ_Age11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Age1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_AllEmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_AllEmployees111BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Excel_Emp_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Excel_Emp_DurationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Excel_Emp_Job_TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Excel_Emp_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Excel_Emp_Job_LevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Excel_Emp_Job_Level11BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Current_Month_EducationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Out_Month_EducationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Out_Month_MaritalStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Current_Month_MaritalStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Current_Month_DurationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Out_Month_DurationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_OUT_Month_Salary1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Current_Month_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Current_Month_JobLevelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_OUT_Month_JobLevel1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_OUT_Month_Employee_Status1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Current_Month_Employee_StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_INBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Info_LeavingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Age_MaritalStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Data_Duration_GradeWiseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_New_Att1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Att_Emp_CountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Holiday_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Att_Emp_OTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Att_Emp_ValueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Att_Emp_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DSExcelEmpData As ERP_HRMS.DSExcelEmpData
    Friend WithEvents View_AgeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_AgeTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_AgeTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSExcelEmpDataTableAdapters.TableAdapterManager
    Friend WithEvents View_DOJ_AgeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_DOJ_AgeTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_DOJ_AgeTableAdapter
    Friend WithEvents View_DOJ_Age1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_DOJ_Age1TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_DOJ_Age1TableAdapter
    Friend WithEvents View_DOJ_Age11BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_DOJ_Age11TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_DOJ_Age11TableAdapter
    Friend WithEvents View_Age1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Age1TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Age1TableAdapter
    Friend WithEvents View_Rpt_Acc_AllEmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployeesTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Acc_AllEmployeesTableAdapter
    Friend WithEvents View_Rpt_Acc_AllEmployees111BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployees111TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Acc_AllEmployees111TableAdapter
    Friend WithEvents View_Excel_Emp_DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Excel_Emp_DataTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_DataTableAdapter
    Friend WithEvents View_Excel_Emp_DurationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Excel_Emp_DurationTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_DurationTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_InfoTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_HRM_Emp_InfoTableAdapter
    Friend WithEvents View_Excel_Emp_Job_TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Excel_Emp_Job_TypeTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_Job_TypeTableAdapter
    Friend WithEvents View_Excel_Emp_SalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Excel_Emp_SalaryTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_SalaryTableAdapter
    Friend WithEvents View_Excel_Emp_Job_LevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Excel_Emp_Job_LevelTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_Job_LevelTableAdapter
    Friend WithEvents View_Excel_Emp_Job_Level11BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Excel_Emp_Job_Level11TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Excel_Emp_Job_Level11TableAdapter
    Friend WithEvents View_Rpt_Current_Month_EducationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Current_Month_EducationTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Current_Month_EducationTableAdapter
    Friend WithEvents View_Rpt_Out_Month_EducationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Out_Month_EducationTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Out_Month_EducationTableAdapter
    Friend WithEvents View_Rpt_Out_Month_MaritalStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Out_Month_MaritalStatusTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Out_Month_MaritalStatusTableAdapter
    Friend WithEvents View_Rpt_Current_Month_MaritalStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Current_Month_MaritalStatusTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Rpt_Current_Month_MaritalStatusTableAdapter
    Friend WithEvents View_Current_Month_DurationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Current_Month_DurationTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Current_Month_DurationTableAdapter
    Friend WithEvents View_Out_Month_DurationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Out_Month_DurationTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Out_Month_DurationTableAdapter
    Friend WithEvents View_OUT_Month_Salary1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_OUT_Month_Salary1TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_OUT_Month_Salary1TableAdapter
    Friend WithEvents View_Current_Month_SalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Current_Month_SalaryTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Current_Month_SalaryTableAdapter
    Friend WithEvents View_Current_Month_JobLevelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Current_Month_JobLevelTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Current_Month_JobLevelTableAdapter
    Friend WithEvents View_OUT_Month_JobLevel1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_OUT_Month_JobLevel1TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_OUT_Month_JobLevel1TableAdapter
    Friend WithEvents View_OUT_Month_Employee_Status1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_OUT_Month_Employee_Status1TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_OUT_Month_Employee_Status1TableAdapter
    Friend WithEvents View_Current_Month_Employee_StatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Current_Month_Employee_StatusTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Current_Month_Employee_StatusTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Info_INBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_INTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Hrm_Emp_Info_INTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Info_LeavingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Info_LeavingTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Hrm_Emp_Info_LeavingTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents View_Age_MaritalStatusBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Age_MaritalStatusTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Age_MaritalStatusTableAdapter
    Friend WithEvents View_Emp_Data_Duration_GradeWiseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Emp_Data_Duration_GradeWiseTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Emp_Data_Duration_GradeWiseTableAdapter
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_New_Att1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Emp_New_Att1TableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Hrm_Emp_New_Att1TableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents View_Att_Emp_CountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Att_Emp_CountTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Att_Emp_CountTableAdapter
    Friend WithEvents Tbl_Holiday_DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Holiday_DetailTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.tbl_Holiday_DetailTableAdapter
    Friend WithEvents View_Att_Emp_OTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Att_Emp_OTTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Att_Emp_OTTableAdapter
    Friend WithEvents View_Att_Emp_ValueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Att_Emp_ValueTableAdapter As ERP_HRMS.DSExcelEmpDataTableAdapters.View_Att_Emp_ValueTableAdapter
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents View_Att_Emp_DeptBindingSource As BindingSource
    Friend WithEvents View_Att_Emp_DeptTableAdapter As DSExcelEmpDataTableAdapters.View_Att_Emp_DeptTableAdapter
End Class
