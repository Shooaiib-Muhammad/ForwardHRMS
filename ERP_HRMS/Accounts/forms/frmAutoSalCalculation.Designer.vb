<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoSalCalculation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Label4 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.View_HRMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSAutoCalc = New ERP_HRMS.DSAutoCalc()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblBeforeFinal = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblAdds = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DSCalculateSalary = New ERP_HRMS.DSCalculateSalary()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.SpecialAllowanceLabel2 = New System.Windows.Forms.Label()
        Me.EndOfProbationDateLabel1 = New System.Windows.Forms.Label()
        Me.GrossSalaryLabel2 = New System.Windows.Forms.Label()
        Me.EmpIDLabel2 = New System.Windows.Forms.Label()
        Me.UnPaidLeavesLabel2 = New System.Windows.Forms.Label()
        Me.M1Label1 = New System.Windows.Forms.Label()
        Me.PaidLeavesLabel2 = New System.Windows.Forms.Label()
        Me.SpecialLeaveLabel1 = New System.Windows.Forms.Label()
        Me.CasualLeaveLabel1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.PAdvDedRateLabel1 = New System.Windows.Forms.Label()
        Me.lblWorkingDays = New System.Windows.Forms.Label()
        Me.EveningShortMinsLabel1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.EmpCountLabel1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.View_Emp_Deduction_DaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_Deduction_DaysTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.View_Emp_Deduction_DaysTableAdapter()
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.HRMDBDataSet1 = New ERP_HRMS.HRMDBDataset1()
        Me.View_HRMSTableAdapter = New ERP_HRMS.DSAutoCalcTableAdapters.View_HRMSTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSAutoCalcTableAdapters.TableAdapterManager()
        Me.EmpIDLabel1 = New System.Windows.Forms.Label()
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.DesigNameLabel1 = New System.Windows.Forms.Label()
        Me.GradeNameLabel1 = New System.Windows.Forms.Label()
        Me.SectionNameLabel1 = New System.Windows.Forms.Label()
        Me.BasicSalaryLabel1 = New System.Windows.Forms.Label()
        Me.MealAllowanceLabel1 = New System.Windows.Forms.Label()
        Me.TravelAllowanceLabel1 = New System.Windows.Forms.Label()
        Me.EducationAllowanceLabel1 = New System.Windows.Forms.Label()
        Me.SpecialAllowanceLabel1 = New System.Windows.Forms.Label()
        Me.EOBILabel1 = New System.Windows.Forms.Label()
        Me.TaxDeductionLabel1 = New System.Windows.Forms.Label()
        Me.ConteenDeductLabel1 = New System.Windows.Forms.Label()
        Me.UnionFundLabel1 = New System.Windows.Forms.Label()
        Me.PaymentModeLabel1 = New System.Windows.Forms.Label()
        Me.PESSIContLabel1 = New System.Windows.Forms.Label()
        Me.AccommodationLabel1 = New System.Windows.Forms.Label()
        Me.DateOfJoningLabel1 = New System.Windows.Forms.Label()
        Me.SenStatusLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_Salary_TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_Salary_TransactionsTableAdapter = New ERP_HRMS.DSAutoCalcTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter()
        Me.RentDeductionLabel1 = New System.Windows.Forms.Label()
        Me.View_Salary_PaidLeavesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Salary_PaidLeavesTableAdapter = New ERP_HRMS.DSAutoCalcTableAdapters.View_Salary_PaidLeavesTableAdapter()
        Me.PaidLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter = New ERP_HRMS.DSAutoCalcTableAdapters.View_Rpt_PayRoll_EmpAttRecordTableAdapter()
        Me.FullDaysLabel1 = New System.Windows.Forms.Label()
        Me.HalfDaysLabel1 = New System.Windows.Forms.Label()
        Me.View_Rpt_Acc_OverTimeSumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_Acc_OverTimeSumTableAdapter = New ERP_HRMS.DSAutoCalcTableAdapters.View_Rpt_Acc_OverTimeSumTableAdapter()
        Me.FullMinutesWorkedLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Emp_Salary_Calculation_AdjBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter = New ERP_HRMS.DSAutoCalcTableAdapters.tbl_Emp_Salary_Calculation_AdjTableAdapter()
        Me.Tbl_Acc_RFD_PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_RFD_PayTableAdapter = New ERP_HRMS.DSAutoCalcTableAdapters.tbl_Acc_RFD_PayTableAdapter()
        Me.DSAUTO = New ERP_HRMS.DSAUTO()
        Me.View_Acc_RFD_PayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Acc_RFD_PayTableAdapter = New ERP_HRMS.DSAUTOTableAdapters.View_Acc_RFD_PayTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.DSAUTOTableAdapters.TableAdapterManager()
        Me.RFAMTLabel1 = New System.Windows.Forms.Label()
        Me.View_Emp_Meal_AttendanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_Meal_AttendanceTableAdapter = New ERP_HRMS.DSAUTOTableAdapters.View_Emp_Meal_AttendanceTableAdapter()
        Me.MealEmpCountLabel1 = New System.Windows.Forms.Label()
        Me.View_Acc_FairShopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Acc_FairShopTableAdapter = New ERP_HRMS.DSAUTOTableAdapters.View_Acc_FairShopTableAdapter()
        Me.FairPriceLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_HolidaysTableAdapter = New ERP_HRMS.DSAUTOTableAdapters.tbl_Hrm_HolidaysTableAdapter()
        Me.HolidayCountLabel1 = New System.Windows.Forms.Label()
        Me.View_Acc_Emp_MaxAdvance_DedRateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Acc_Emp_MaxAdvance_DedRateTableAdapter = New ERP_HRMS.DSAUTOTableAdapters.View_Acc_Emp_MaxAdvance_DedRateTableAdapter()
        Me.DedRateLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_ShortTermAdvancesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter = New ERP_HRMS.DSAUTOTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter()
        Me.TempAdvLabel1 = New System.Windows.Forms.Label()
        Me.View_Acc_Adv_BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Acc_Adv_BalanceTableAdapter = New ERP_HRMS.DSAUTOTableAdapters.View_Acc_Adv_BalanceTableAdapter()
        Me.PBalanceLabel1 = New System.Windows.Forms.Label()
        Me.DSSP = New ERP_HRMS.DSSP()
        Me.View_SP_OTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_SP_OTTableAdapter = New ERP_HRMS.DSSPTableAdapters.View_SP_OTTableAdapter()
        Me.TableAdapterManager3 = New ERP_HRMS.DSSPTableAdapters.TableAdapterManager()
        Me.SPLabel1 = New System.Windows.Forms.Label()
        Me.AnnualLabel1 = New System.Windows.Forms.Label()
        Me.M2Label1 = New System.Windows.Forms.Label()
        Me.SpecialLabel1 = New System.Windows.Forms.Label()
        Me.CasualLabel1 = New System.Windows.Forms.Label()
        Me.SickLabel1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmpCountLabel2 = New System.Windows.Forms.Label()
        Me.View_Emp_Deduction_Days_NEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Emp_Deduction_Days_NEWTableAdapter = New ERP_HRMS.DSAutoCalcTableAdapters.View_Emp_Deduction_Days_NEWTableAdapter()
        Me.DayDeductionLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_Acc_INCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_INCTableAdapter = New ERP_HRMS.DSCalculateSalaryTableAdapters.tbl_Acc_INCTableAdapter()
        Me.TableAdapterManager4 = New ERP_HRMS.DSCalculateSalaryTableAdapters.TableAdapterManager()
        Me.LabelSenAll = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.View_HRMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAutoCalc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSCalculateSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Deduction_DaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Salary_PaidLeavesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_OverTimeSumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Emp_Salary_Calculation_AdjBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_RFD_PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAUTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_RFD_PayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Meal_AttendanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_FairShopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_Emp_MaxAdvance_DedRateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Acc_Adv_BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSSP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_SP_OTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Deduction_Days_NEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_INCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(11, 85)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(117, 30)
        Label4.TabIndex = 3
        Label4.Text = "Card No.:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Label10.BackColor = System.Drawing.Color.Transparent
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.Black
        Label10.Location = New System.Drawing.Point(11, 60)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(117, 20)
        Label10.TabIndex = 105
        Label10.Text = "Starting Card No.:"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.CardNoComboBox)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.lblBeforeFinal)
        Me.Panel1.Controls.Add(Me.lblSalary)
        Me.Panel1.Controls.Add(Me.lblAdds)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 395)
        Me.Panel1.TabIndex = 9
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CheckBox3.ForeColor = System.Drawing.Color.White
        Me.CheckBox3.Location = New System.Drawing.Point(10, 232)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(295, 21)
        Me.CheckBox3.TabIndex = 108
        Me.CheckBox3.TabStop = False
        Me.CheckBox3.Text = "Un-Check For Zero Meal Allowance"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.BackColor = System.Drawing.Color.White
        Me.CardNoComboBox.DataSource = Me.View_HRMSBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(129, 59)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(128, 21)
        Me.CardNoComboBox.TabIndex = 104
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'View_HRMSBindingSource
        '
        Me.View_HRMSBindingSource.DataMember = "View_HRMS"
        Me.View_HRMSBindingSource.DataSource = Me.DSAutoCalc
        '
        'DSAutoCalc
        '
        Me.DSAutoCalc.DataSetName = "DSAutoCalc"
        Me.DSAutoCalc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(11, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 30)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Final Amt :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(11, 161)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 30)
        Me.Label26.TabIndex = 102
        Me.Label26.Tag = "Sum of P Adv, T Adv, EOBI, Tax, Rent"
        Me.Label26.Text = "Total Subtracts"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label35.Location = New System.Drawing.Point(11, 123)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(117, 30)
        Me.Label35.TabIndex = 101
        Me.Label35.Text = "Total Adds"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "CardNo", True))
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(129, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 29)
        Me.Label1.TabIndex = 79
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(271, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(254, 137)
        Me.Label8.TabIndex = 77
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label15.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(0, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(537, 25)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Select Appropriate Month To Calculate Auto Salary"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(0, 379)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(537, 14)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Stoped!"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(129, 34)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 28
        Me.DateTimePicker1.TabStop = False
        '
        'lblBeforeFinal
        '
        Me.lblBeforeFinal.BackColor = System.Drawing.Color.White
        Me.lblBeforeFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBeforeFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeforeFinal.ForeColor = System.Drawing.Color.Black
        Me.lblBeforeFinal.Location = New System.Drawing.Point(129, 161)
        Me.lblBeforeFinal.Name = "lblBeforeFinal"
        Me.lblBeforeFinal.Size = New System.Drawing.Size(128, 30)
        Me.lblBeforeFinal.TabIndex = 22
        Me.lblBeforeFinal.Tag = "Sum of P Adv, T Adv, EOBI, Tax, Rent"
        Me.lblBeforeFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSalary
        '
        Me.lblSalary.BackColor = System.Drawing.Color.Green
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblSalary.ForeColor = System.Drawing.Color.White
        Me.lblSalary.Location = New System.Drawing.Point(129, 199)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(128, 30)
        Me.lblSalary.TabIndex = 19
        Me.lblSalary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdds
        '
        Me.lblAdds.BackColor = System.Drawing.Color.White
        Me.lblAdds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdds.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblAdds.ForeColor = System.Drawing.Color.Black
        Me.lblAdds.Location = New System.Drawing.Point(129, 123)
        Me.lblAdds.Name = "lblAdds"
        Me.lblAdds.Size = New System.Drawing.Size(128, 30)
        Me.lblAdds.TabIndex = 24
        Me.lblAdds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Month:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Cambria", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(214, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(243, 76)
        Me.Button2.TabIndex = 54
        Me.Button2.TabStop = False
        Me.Button2.Text = "Start To Calculate Salary"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'DSCalculateSalary
        '
        Me.DSCalculateSalary.DataSetName = "DSCalculateSalary"
        Me.DSCalculateSalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Gainsboro
        Me.Label33.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label33.Location = New System.Drawing.Point(12, 114)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(10, 10)
        Me.Label33.TabIndex = 61
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label33.Visible = False
        '
        'SpecialAllowanceLabel2
        '
        Me.SpecialAllowanceLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SpecialAllowanceLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.SpecialAllowanceLabel2.Location = New System.Drawing.Point(501, 428)
        Me.SpecialAllowanceLabel2.Name = "SpecialAllowanceLabel2"
        Me.SpecialAllowanceLabel2.Size = New System.Drawing.Size(10, 10)
        Me.SpecialAllowanceLabel2.TabIndex = 47
        Me.SpecialAllowanceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EndOfProbationDateLabel1
        '
        Me.EndOfProbationDateLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EndOfProbationDateLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EndOfProbationDateLabel1.Location = New System.Drawing.Point(638, 428)
        Me.EndOfProbationDateLabel1.Name = "EndOfProbationDateLabel1"
        Me.EndOfProbationDateLabel1.Size = New System.Drawing.Size(25, 20)
        Me.EndOfProbationDateLabel1.TabIndex = 58
        Me.EndOfProbationDateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrossSalaryLabel2
        '
        Me.GrossSalaryLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GrossSalaryLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.GrossSalaryLabel2.Location = New System.Drawing.Point(361, 404)
        Me.GrossSalaryLabel2.Name = "GrossSalaryLabel2"
        Me.GrossSalaryLabel2.Size = New System.Drawing.Size(61, 20)
        Me.GrossSalaryLabel2.TabIndex = 41
        Me.GrossSalaryLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpIDLabel2
        '
        Me.EmpIDLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EmpIDLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.EmpIDLabel2.Location = New System.Drawing.Point(428, 391)
        Me.EmpIDLabel2.Name = "EmpIDLabel2"
        Me.EmpIDLabel2.Size = New System.Drawing.Size(61, 20)
        Me.EmpIDLabel2.TabIndex = 37
        Me.EmpIDLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnPaidLeavesLabel2
        '
        Me.UnPaidLeavesLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UnPaidLeavesLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.UnPaidLeavesLabel2.Location = New System.Drawing.Point(679, 364)
        Me.UnPaidLeavesLabel2.Name = "UnPaidLeavesLabel2"
        Me.UnPaidLeavesLabel2.Size = New System.Drawing.Size(10, 5)
        Me.UnPaidLeavesLabel2.TabIndex = 37
        Me.UnPaidLeavesLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'M1Label1
        '
        Me.M1Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.M1Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.M1Label1.Location = New System.Drawing.Point(458, 364)
        Me.M1Label1.Name = "M1Label1"
        Me.M1Label1.Size = New System.Drawing.Size(10, 5)
        Me.M1Label1.TabIndex = 35
        Me.M1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PaidLeavesLabel2
        '
        Me.PaidLeavesLabel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PaidLeavesLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.PaidLeavesLabel2.Location = New System.Drawing.Point(554, 364)
        Me.PaidLeavesLabel2.Name = "PaidLeavesLabel2"
        Me.PaidLeavesLabel2.Size = New System.Drawing.Size(10, 5)
        Me.PaidLeavesLabel2.TabIndex = 30
        Me.PaidLeavesLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpecialLeaveLabel1
        '
        Me.SpecialLeaveLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SpecialLeaveLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.SpecialLeaveLabel1.Location = New System.Drawing.Point(554, 400)
        Me.SpecialLeaveLabel1.Name = "SpecialLeaveLabel1"
        Me.SpecialLeaveLabel1.Size = New System.Drawing.Size(10, 5)
        Me.SpecialLeaveLabel1.TabIndex = 29
        Me.SpecialLeaveLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CasualLeaveLabel1
        '
        Me.CasualLeaveLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CasualLeaveLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.CasualLeaveLabel1.Location = New System.Drawing.Point(679, 401)
        Me.CasualLeaveLabel1.Name = "CasualLeaveLabel1"
        Me.CasualLeaveLabel1.Size = New System.Drawing.Size(10, 5)
        Me.CasualLeaveLabel1.TabIndex = 26
        Me.CasualLeaveLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.CheckBox1.Location = New System.Drawing.Point(211, 404)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(22, 20)
        Me.CheckBox1.TabIndex = 22
        Me.CheckBox1.TabStop = False
        Me.CheckBox1.Text = "Want to Deduct? (Cecked = Yes And UnChecked = No)"
        Me.CheckBox1.UseVisualStyleBackColor = False
        Me.CheckBox1.Visible = False
        '
        'PAdvDedRateLabel1
        '
        Me.PAdvDedRateLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PAdvDedRateLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.PAdvDedRateLabel1.Location = New System.Drawing.Point(298, 406)
        Me.PAdvDedRateLabel1.Name = "PAdvDedRateLabel1"
        Me.PAdvDedRateLabel1.Size = New System.Drawing.Size(90, 20)
        Me.PAdvDedRateLabel1.TabIndex = 45
        Me.PAdvDedRateLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWorkingDays
        '
        Me.lblWorkingDays.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblWorkingDays.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblWorkingDays.Location = New System.Drawing.Point(536, 431)
        Me.lblWorkingDays.Name = "lblWorkingDays"
        Me.lblWorkingDays.Size = New System.Drawing.Size(10, 10)
        Me.lblWorkingDays.TabIndex = 32
        Me.lblWorkingDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EveningShortMinsLabel1
        '
        Me.EveningShortMinsLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EveningShortMinsLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EveningShortMinsLabel1.Location = New System.Drawing.Point(702, 378)
        Me.EveningShortMinsLabel1.Name = "EveningShortMinsLabel1"
        Me.EveningShortMinsLabel1.Size = New System.Drawing.Size(10, 33)
        Me.EveningShortMinsLabel1.TabIndex = 71
        Me.EveningShortMinsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1013, 40)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Monthly Salary Auto Calculation"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(0, 584)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1013, 24)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Note: Select Appropriate Month To Calculate Auto Salary"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1013, 36)
        Me.StatusStrip1.TabIndex = 100
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripProgressBar1.ForeColor = System.Drawing.Color.Yellow
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(990, 30)
        Me.ToolStripProgressBar1.Step = 1
        '
        'EmpCountLabel1
        '
        Me.EmpCountLabel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.EmpCountLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.EmpCountLabel1.Location = New System.Drawing.Point(638, 413)
        Me.EmpCountLabel1.Name = "EmpCountLabel1"
        Me.EmpCountLabel1.Size = New System.Drawing.Size(100, 15)
        Me.EmpCountLabel1.TabIndex = 109
        Me.EmpCountLabel1.Text = "Label3"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(182, 49)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 409)
        Me.TabControl1.TabIndex = 111
        '
        'TabPage1
        '
        Me.TabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(542, 401)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Auto Salary Calculate "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.DateTimePicker5)
        Me.TabPage2.Controls.Add(Me.tbFilePath)
        Me.TabPage2.Controls.Add(Me.btnOpenFile)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(542, 401)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Arrears"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 86)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(532, 309)
        Me.DataGridView1.TabIndex = 33
        Me.DataGridView1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button3.Location = New System.Drawing.Point(255, 33)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 26)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Save Now"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(11, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 20)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Select Transaction Date:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(147, 35)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker5.TabIndex = 35
        '
        'tbFilePath
        '
        Me.tbFilePath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tbFilePath.Location = New System.Drawing.Point(11, 62)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(422, 20)
        Me.tbFilePath.TabIndex = 37
        Me.tbFilePath.TabStop = False
        Me.tbFilePath.Text = "Browse an Excel File Here to Upload Data..."
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.White
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.Color.DarkRed
        Me.btnOpenFile.Location = New System.Drawing.Point(439, 59)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(86, 24)
        Me.btnOpenFile.TabIndex = 38
        Me.btnOpenFile.Text = "Browse File"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(3, 3)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(536, 25)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Arrears"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Location = New System.Drawing.Point(3, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(174, 57)
        Me.Panel2.TabIndex = 112
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(6, 29)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(162, 21)
        Me.LinkLabel2.TabIndex = 113
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Arrears"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(162, 21)
        Me.LinkLabel1.TabIndex = 113
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Auto Salary Calculate "
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Comp_InfoTableAdapter = Me.Tbl_Comp_InfoTableAdapter
        Me.TableAdapterManager1.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager1.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(40, 137)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 20)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Error Records"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Red
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(9, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 20)
        Me.Label11.TabIndex = 120
        Me.Label11.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(41, 114)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 20)
        Me.Label16.TabIndex = 119
        Me.Label16.Text = "Saved Records"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label16.Visible = False
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.ForestGreen
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.Location = New System.Drawing.Point(9, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 20)
        Me.Label17.TabIndex = 118
        Me.Label17.Visible = False
        '
        'View_Emp_Deduction_DaysTableAdapter
        '
        Me.View_Emp_Deduction_DaysTableAdapter.ClearBeforeFill = True
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HRMDBDataSet1
        '
        Me.HRMDBDataSet1.DataSetName = "HRMDBDataSet1"
        Me.HRMDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_HRMSTableAdapter
        '
        Me.View_HRMSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Emp_Salary_Calculation_AdjTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSAutoCalcTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpIDLabel1
        '
        Me.EmpIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "EmpID", True))
        Me.EmpIDLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EmpIDLabel1.Location = New System.Drawing.Point(769, 64)
        Me.EmpIDLabel1.Name = "EmpIDLabel1"
        Me.EmpIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.EmpIDLabel1.TabIndex = 122
        Me.EmpIDLabel1.Text = "Label5"
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "DeptName", True))
        Me.DeptNameLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DeptNameLabel1.Location = New System.Drawing.Point(769, 134)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DeptNameLabel1.TabIndex = 123
        Me.DeptNameLabel1.Text = "Label5"
        '
        'DesigNameLabel1
        '
        Me.DesigNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "DesigName", True))
        Me.DesigNameLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DesigNameLabel1.Location = New System.Drawing.Point(769, 157)
        Me.DesigNameLabel1.Name = "DesigNameLabel1"
        Me.DesigNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DesigNameLabel1.TabIndex = 124
        Me.DesigNameLabel1.Text = "Label5"
        '
        'GradeNameLabel1
        '
        Me.GradeNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "GradeName", True))
        Me.GradeNameLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GradeNameLabel1.Location = New System.Drawing.Point(875, 57)
        Me.GradeNameLabel1.Name = "GradeNameLabel1"
        Me.GradeNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.GradeNameLabel1.TabIndex = 125
        Me.GradeNameLabel1.Text = "Label5"
        '
        'SectionNameLabel1
        '
        Me.SectionNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "SectionName", True))
        Me.SectionNameLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SectionNameLabel1.Location = New System.Drawing.Point(875, 102)
        Me.SectionNameLabel1.Name = "SectionNameLabel1"
        Me.SectionNameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SectionNameLabel1.TabIndex = 126
        Me.SectionNameLabel1.Text = "Label5"
        '
        'BasicSalaryLabel1
        '
        Me.BasicSalaryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "BasicSalary", True))
        Me.BasicSalaryLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.BasicSalaryLabel1.Location = New System.Drawing.Point(769, 180)
        Me.BasicSalaryLabel1.Name = "BasicSalaryLabel1"
        Me.BasicSalaryLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BasicSalaryLabel1.TabIndex = 127
        Me.BasicSalaryLabel1.Text = "Label5"
        '
        'MealAllowanceLabel1
        '
        Me.MealAllowanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "MealAllowance", True))
        Me.MealAllowanceLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MealAllowanceLabel1.Location = New System.Drawing.Point(769, 83)
        Me.MealAllowanceLabel1.Name = "MealAllowanceLabel1"
        Me.MealAllowanceLabel1.Size = New System.Drawing.Size(100, 23)
        Me.MealAllowanceLabel1.TabIndex = 128
        Me.MealAllowanceLabel1.Text = "Label5"
        '
        'TravelAllowanceLabel1
        '
        Me.TravelAllowanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "TravelAllowance", True))
        Me.TravelAllowanceLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TravelAllowanceLabel1.Location = New System.Drawing.Point(769, 201)
        Me.TravelAllowanceLabel1.Name = "TravelAllowanceLabel1"
        Me.TravelAllowanceLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TravelAllowanceLabel1.TabIndex = 129
        Me.TravelAllowanceLabel1.Text = "Label5"
        '
        'EducationAllowanceLabel1
        '
        Me.EducationAllowanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "EducationAllowance", True))
        Me.EducationAllowanceLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EducationAllowanceLabel1.Location = New System.Drawing.Point(875, 125)
        Me.EducationAllowanceLabel1.Name = "EducationAllowanceLabel1"
        Me.EducationAllowanceLabel1.Size = New System.Drawing.Size(100, 23)
        Me.EducationAllowanceLabel1.TabIndex = 130
        Me.EducationAllowanceLabel1.Text = "Label5"
        '
        'SpecialAllowanceLabel1
        '
        Me.SpecialAllowanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "SpecialAllowance", True))
        Me.SpecialAllowanceLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SpecialAllowanceLabel1.Location = New System.Drawing.Point(769, 113)
        Me.SpecialAllowanceLabel1.Name = "SpecialAllowanceLabel1"
        Me.SpecialAllowanceLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SpecialAllowanceLabel1.TabIndex = 131
        Me.SpecialAllowanceLabel1.Text = "Label5"
        '
        'EOBILabel1
        '
        Me.EOBILabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "EOBI", True))
        Me.EOBILabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EOBILabel1.Location = New System.Drawing.Point(875, 155)
        Me.EOBILabel1.Name = "EOBILabel1"
        Me.EOBILabel1.Size = New System.Drawing.Size(100, 23)
        Me.EOBILabel1.TabIndex = 132
        Me.EOBILabel1.Text = "Label5"
        '
        'TaxDeductionLabel1
        '
        Me.TaxDeductionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "TaxDeduction", True))
        Me.TaxDeductionLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TaxDeductionLabel1.Location = New System.Drawing.Point(875, 79)
        Me.TaxDeductionLabel1.Name = "TaxDeductionLabel1"
        Me.TaxDeductionLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TaxDeductionLabel1.TabIndex = 133
        Me.TaxDeductionLabel1.Text = "Label5"
        '
        'ConteenDeductLabel1
        '
        Me.ConteenDeductLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "ConteenDeduct", True))
        Me.ConteenDeductLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.ConteenDeductLabel1.Location = New System.Drawing.Point(769, 226)
        Me.ConteenDeductLabel1.Name = "ConteenDeductLabel1"
        Me.ConteenDeductLabel1.Size = New System.Drawing.Size(100, 23)
        Me.ConteenDeductLabel1.TabIndex = 134
        Me.ConteenDeductLabel1.Text = "Label5"
        '
        'UnionFundLabel1
        '
        Me.UnionFundLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "UnionFund", True))
        Me.UnionFundLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.UnionFundLabel1.Location = New System.Drawing.Point(875, 177)
        Me.UnionFundLabel1.Name = "UnionFundLabel1"
        Me.UnionFundLabel1.Size = New System.Drawing.Size(100, 23)
        Me.UnionFundLabel1.TabIndex = 135
        Me.UnionFundLabel1.Text = "Label5"
        '
        'PaymentModeLabel1
        '
        Me.PaymentModeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "PaymentMode", True))
        Me.PaymentModeLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PaymentModeLabel1.Location = New System.Drawing.Point(875, 201)
        Me.PaymentModeLabel1.Name = "PaymentModeLabel1"
        Me.PaymentModeLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PaymentModeLabel1.TabIndex = 136
        Me.PaymentModeLabel1.Text = "Label5"
        '
        'PESSIContLabel1
        '
        Me.PESSIContLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "PESSICont", True))
        Me.PESSIContLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PESSIContLabel1.Location = New System.Drawing.Point(769, 259)
        Me.PESSIContLabel1.Name = "PESSIContLabel1"
        Me.PESSIContLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PESSIContLabel1.TabIndex = 137
        Me.PESSIContLabel1.Text = "Label5"
        '
        'AccommodationLabel1
        '
        Me.AccommodationLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "Accommodation", True))
        Me.AccommodationLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AccommodationLabel1.Location = New System.Drawing.Point(769, 282)
        Me.AccommodationLabel1.Name = "AccommodationLabel1"
        Me.AccommodationLabel1.Size = New System.Drawing.Size(100, 23)
        Me.AccommodationLabel1.TabIndex = 138
        Me.AccommodationLabel1.Text = "Label5"
        '
        'DateOfJoningLabel1
        '
        Me.DateOfJoningLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "DateOfJoning", True))
        Me.DateOfJoningLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DateOfJoningLabel1.Location = New System.Drawing.Point(875, 226)
        Me.DateOfJoningLabel1.Name = "DateOfJoningLabel1"
        Me.DateOfJoningLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DateOfJoningLabel1.TabIndex = 139
        Me.DateOfJoningLabel1.Text = "Label5"
        '
        'SenStatusLabel1
        '
        Me.SenStatusLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "SenStatus", True))
        Me.SenStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SenStatusLabel1.Location = New System.Drawing.Point(875, 259)
        Me.SenStatusLabel1.Name = "SenStatusLabel1"
        Me.SenStatusLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SenStatusLabel1.TabIndex = 140
        Me.SenStatusLabel1.Text = "Label5"
        '
        'Tbl_Acc_Salary_TransactionsBindingSource
        '
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataMember = "tbl_Acc_Salary_Transactions"
        Me.Tbl_Acc_Salary_TransactionsBindingSource.DataSource = Me.DSAutoCalc
        '
        'Tbl_Acc_Salary_TransactionsTableAdapter
        '
        Me.Tbl_Acc_Salary_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'RentDeductionLabel1
        '
        Me.RentDeductionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "RentDeduction", True))
        Me.RentDeductionLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RentDeductionLabel1.Location = New System.Drawing.Point(875, 290)
        Me.RentDeductionLabel1.Name = "RentDeductionLabel1"
        Me.RentDeductionLabel1.Size = New System.Drawing.Size(100, 23)
        Me.RentDeductionLabel1.TabIndex = 141
        Me.RentDeductionLabel1.Text = "Label5"
        '
        'View_Salary_PaidLeavesBindingSource
        '
        Me.View_Salary_PaidLeavesBindingSource.DataMember = "View_Salary_PaidLeaves"
        Me.View_Salary_PaidLeavesBindingSource.DataSource = Me.DSAutoCalc
        '
        'View_Salary_PaidLeavesTableAdapter
        '
        Me.View_Salary_PaidLeavesTableAdapter.ClearBeforeFill = True
        '
        'PaidLabel1
        '
        Me.PaidLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Salary_PaidLeavesBindingSource, "Paid", True))
        Me.PaidLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PaidLabel1.Location = New System.Drawing.Point(809, 336)
        Me.PaidLabel1.Name = "PaidLabel1"
        Me.PaidLabel1.Size = New System.Drawing.Size(100, 10)
        Me.PaidLabel1.TabIndex = 143
        Me.PaidLabel1.Text = "Label5"
        '
        'View_Rpt_PayRoll_EmpAttRecordBindingSource
        '
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource.DataMember = "View_Rpt_PayRoll_EmpAttRecord"
        Me.View_Rpt_PayRoll_EmpAttRecordBindingSource.DataSource = Me.DSAutoCalc
        '
        'View_Rpt_PayRoll_EmpAttRecordTableAdapter
        '
        Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter.ClearBeforeFill = True
        '
        'FullDaysLabel1
        '
        Me.FullDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, "FullDays", True))
        Me.FullDaysLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FullDaysLabel1.Location = New System.Drawing.Point(769, 360)
        Me.FullDaysLabel1.Name = "FullDaysLabel1"
        Me.FullDaysLabel1.Size = New System.Drawing.Size(100, 23)
        Me.FullDaysLabel1.TabIndex = 145
        Me.FullDaysLabel1.Text = "Label5"
        '
        'HalfDaysLabel1
        '
        Me.HalfDaysLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, "HalfDays", True))
        Me.HalfDaysLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.HalfDaysLabel1.Location = New System.Drawing.Point(769, 391)
        Me.HalfDaysLabel1.Name = "HalfDaysLabel1"
        Me.HalfDaysLabel1.Size = New System.Drawing.Size(100, 23)
        Me.HalfDaysLabel1.TabIndex = 146
        Me.HalfDaysLabel1.Text = "Label5"
        '
        'View_Rpt_Acc_OverTimeSumBindingSource
        '
        Me.View_Rpt_Acc_OverTimeSumBindingSource.DataMember = "View_Rpt_Acc_OverTimeSum"
        Me.View_Rpt_Acc_OverTimeSumBindingSource.DataSource = Me.DSAutoCalc
        '
        'View_Rpt_Acc_OverTimeSumTableAdapter
        '
        Me.View_Rpt_Acc_OverTimeSumTableAdapter.ClearBeforeFill = True
        '
        'FullMinutesWorkedLabel1
        '
        Me.FullMinutesWorkedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_OverTimeSumBindingSource, "FullMinutesWorked", True))
        Me.FullMinutesWorkedLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FullMinutesWorkedLabel1.Location = New System.Drawing.Point(769, 448)
        Me.FullMinutesWorkedLabel1.Name = "FullMinutesWorkedLabel1"
        Me.FullMinutesWorkedLabel1.Size = New System.Drawing.Size(100, 23)
        Me.FullMinutesWorkedLabel1.TabIndex = 148
        Me.FullMinutesWorkedLabel1.Text = "Label5"
        '
        'Tbl_Emp_Salary_Calculation_AdjBindingSource
        '
        Me.Tbl_Emp_Salary_Calculation_AdjBindingSource.DataMember = "tbl_Emp_Salary_Calculation_Adj"
        Me.Tbl_Emp_Salary_Calculation_AdjBindingSource.DataSource = Me.DSAutoCalc
        '
        'Tbl_Emp_Salary_Calculation_AdjTableAdapter
        '
        Me.Tbl_Emp_Salary_Calculation_AdjTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_RFD_PayBindingSource
        '
        Me.Tbl_Acc_RFD_PayBindingSource.DataSource = Me.DSAutoCalc
        Me.Tbl_Acc_RFD_PayBindingSource.Position = 0
        '
        'Tbl_Acc_RFD_PayTableAdapter
        '
        Me.Tbl_Acc_RFD_PayTableAdapter.ClearBeforeFill = True
        '
        'DSAUTO
        '
        Me.DSAUTO.DataSetName = "DSAUTO"
        Me.DSAUTO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Acc_RFD_PayBindingSource
        '
        Me.View_Acc_RFD_PayBindingSource.DataMember = "View_Acc_RFD_Pay"
        Me.View_Acc_RFD_PayBindingSource.DataSource = Me.DSAUTO
        '
        'View_Acc_RFD_PayTableAdapter
        '
        Me.View_Acc_RFD_PayTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.DSAUTOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RFAMTLabel1
        '
        Me.RFAMTLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_RFD_PayBindingSource, "RFAMT", True))
        Me.RFAMTLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.RFAMTLabel1.Location = New System.Drawing.Point(12, 293)
        Me.RFAMTLabel1.Name = "RFAMTLabel1"
        Me.RFAMTLabel1.Size = New System.Drawing.Size(83, 23)
        Me.RFAMTLabel1.TabIndex = 150
        Me.RFAMTLabel1.Text = "Label5"
        '
        'View_Emp_Meal_AttendanceBindingSource
        '
        Me.View_Emp_Meal_AttendanceBindingSource.DataMember = "View_Emp_Meal_Attendance"
        Me.View_Emp_Meal_AttendanceBindingSource.DataSource = Me.DSAUTO
        '
        'View_Emp_Meal_AttendanceTableAdapter
        '
        Me.View_Emp_Meal_AttendanceTableAdapter.ClearBeforeFill = True
        '
        'MealEmpCountLabel1
        '
        Me.MealEmpCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Emp_Meal_AttendanceBindingSource, "EmpCount", True))
        Me.MealEmpCountLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.MealEmpCountLabel1.Location = New System.Drawing.Point(12, 261)
        Me.MealEmpCountLabel1.Name = "MealEmpCountLabel1"
        Me.MealEmpCountLabel1.Size = New System.Drawing.Size(83, 23)
        Me.MealEmpCountLabel1.TabIndex = 152
        Me.MealEmpCountLabel1.Text = "Label5"
        '
        'View_Acc_FairShopBindingSource
        '
        Me.View_Acc_FairShopBindingSource.DataMember = "View_Acc_FairShop"
        Me.View_Acc_FairShopBindingSource.DataSource = Me.DSAUTO
        '
        'View_Acc_FairShopTableAdapter
        '
        Me.View_Acc_FairShopTableAdapter.ClearBeforeFill = True
        '
        'FairPriceLabel1
        '
        Me.FairPriceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_FairShopBindingSource, "FairPrice", True))
        Me.FairPriceLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FairPriceLabel1.Location = New System.Drawing.Point(12, 315)
        Me.FairPriceLabel1.Name = "FairPriceLabel1"
        Me.FairPriceLabel1.Size = New System.Drawing.Size(83, 18)
        Me.FairPriceLabel1.TabIndex = 154
        Me.FairPriceLabel1.Text = "Label5"
        '
        'Tbl_Hrm_HolidaysBindingSource
        '
        Me.Tbl_Hrm_HolidaysBindingSource.DataMember = "tbl_Hrm_Holidays"
        Me.Tbl_Hrm_HolidaysBindingSource.DataSource = Me.DSAUTO
        '
        'Tbl_Hrm_HolidaysTableAdapter
        '
        Me.Tbl_Hrm_HolidaysTableAdapter.ClearBeforeFill = True
        '
        'HolidayCountLabel1
        '
        Me.HolidayCountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_HolidaysBindingSource, "HolidayCount", True))
        Me.HolidayCountLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.HolidayCountLabel1.Location = New System.Drawing.Point(769, 425)
        Me.HolidayCountLabel1.Name = "HolidayCountLabel1"
        Me.HolidayCountLabel1.Size = New System.Drawing.Size(100, 23)
        Me.HolidayCountLabel1.TabIndex = 156
        Me.HolidayCountLabel1.Text = "Label5"
        '
        'View_Acc_Emp_MaxAdvance_DedRateBindingSource
        '
        Me.View_Acc_Emp_MaxAdvance_DedRateBindingSource.DataMember = "View_Acc_Emp_MaxAdvance_DedRate"
        Me.View_Acc_Emp_MaxAdvance_DedRateBindingSource.DataSource = Me.DSAUTO
        '
        'View_Acc_Emp_MaxAdvance_DedRateTableAdapter
        '
        Me.View_Acc_Emp_MaxAdvance_DedRateTableAdapter.ClearBeforeFill = True
        '
        'DedRateLabel1
        '
        Me.DedRateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_Emp_MaxAdvance_DedRateBindingSource, "DedRate", True))
        Me.DedRateLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DedRateLabel1.Location = New System.Drawing.Point(12, 360)
        Me.DedRateLabel1.Name = "DedRateLabel1"
        Me.DedRateLabel1.Size = New System.Drawing.Size(83, 23)
        Me.DedRateLabel1.TabIndex = 158
        Me.DedRateLabel1.Text = "Label5"
        '
        'Tbl_Acc_ShortTermAdvancesBindingSource
        '
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataMember = "tbl_Acc_ShortTermAdvances"
        Me.Tbl_Acc_ShortTermAdvancesBindingSource.DataSource = Me.DSAUTO
        '
        'Tbl_Acc_ShortTermAdvancesTableAdapter
        '
        Me.Tbl_Acc_ShortTermAdvancesTableAdapter.ClearBeforeFill = True
        '
        'TempAdvLabel1
        '
        Me.TempAdvLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_ShortTermAdvancesBindingSource, "TempAdv", True))
        Me.TempAdvLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.TempAdvLabel1.Location = New System.Drawing.Point(12, 336)
        Me.TempAdvLabel1.Name = "TempAdvLabel1"
        Me.TempAdvLabel1.Size = New System.Drawing.Size(83, 23)
        Me.TempAdvLabel1.TabIndex = 160
        Me.TempAdvLabel1.Text = "Label5"
        '
        'View_Acc_Adv_BalanceBindingSource
        '
        Me.View_Acc_Adv_BalanceBindingSource.DataMember = "View_Acc_Adv_Balance"
        Me.View_Acc_Adv_BalanceBindingSource.DataSource = Me.DSAUTO
        '
        'View_Acc_Adv_BalanceTableAdapter
        '
        Me.View_Acc_Adv_BalanceTableAdapter.ClearBeforeFill = True
        '
        'PBalanceLabel1
        '
        Me.PBalanceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Acc_Adv_BalanceBindingSource, "PBalance", True))
        Me.PBalanceLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.PBalanceLabel1.Location = New System.Drawing.Point(12, 383)
        Me.PBalanceLabel1.Name = "PBalanceLabel1"
        Me.PBalanceLabel1.Size = New System.Drawing.Size(83, 23)
        Me.PBalanceLabel1.TabIndex = 162
        Me.PBalanceLabel1.Text = "Label5"
        '
        'DSSP
        '
        Me.DSSP.DataSetName = "DSSP"
        Me.DSSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_SP_OTBindingSource
        '
        Me.View_SP_OTBindingSource.DataMember = "View_SP_OT"
        Me.View_SP_OTBindingSource.DataSource = Me.DSSP
        '
        'View_SP_OTTableAdapter
        '
        Me.View_SP_OTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = ERP_HRMS.DSSPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SPLabel1
        '
        Me.SPLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_SP_OTBindingSource, "SP", True))
        Me.SPLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SPLabel1.Location = New System.Drawing.Point(11, 453)
        Me.SPLabel1.Name = "SPLabel1"
        Me.SPLabel1.Size = New System.Drawing.Size(83, 23)
        Me.SPLabel1.TabIndex = 164
        Me.SPLabel1.Text = "Label5"
        '
        'AnnualLabel1
        '
        Me.AnnualLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Salary_PaidLeavesBindingSource, "Annual", True))
        Me.AnnualLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.AnnualLabel1.Location = New System.Drawing.Point(11, 432)
        Me.AnnualLabel1.Name = "AnnualLabel1"
        Me.AnnualLabel1.Size = New System.Drawing.Size(83, 14)
        Me.AnnualLabel1.TabIndex = 175
        Me.AnnualLabel1.Text = "Label5"
        '
        'M2Label1
        '
        Me.M2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Salary_PaidLeavesBindingSource, "M2", True))
        Me.M2Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.M2Label1.Location = New System.Drawing.Point(11, 408)
        Me.M2Label1.Name = "M2Label1"
        Me.M2Label1.Size = New System.Drawing.Size(83, 18)
        Me.M2Label1.TabIndex = 174
        Me.M2Label1.Text = "Label5"
        '
        'SpecialLabel1
        '
        Me.SpecialLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Salary_PaidLeavesBindingSource, "Special", True))
        Me.SpecialLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SpecialLabel1.Location = New System.Drawing.Point(618, 465)
        Me.SpecialLabel1.Name = "SpecialLabel1"
        Me.SpecialLabel1.Size = New System.Drawing.Size(100, 11)
        Me.SpecialLabel1.TabIndex = 173
        Me.SpecialLabel1.Text = "Label5"
        '
        'CasualLabel1
        '
        Me.CasualLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Salary_PaidLeavesBindingSource, "Casual", True))
        Me.CasualLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.CasualLabel1.Location = New System.Drawing.Point(464, 466)
        Me.CasualLabel1.Name = "CasualLabel1"
        Me.CasualLabel1.Size = New System.Drawing.Size(100, 15)
        Me.CasualLabel1.TabIndex = 172
        Me.CasualLabel1.Text = "Label5"
        '
        'SickLabel1
        '
        Me.SickLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Salary_PaidLeavesBindingSource, "Sick", True))
        Me.SickLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.SickLabel1.Location = New System.Drawing.Point(295, 470)
        Me.SickLabel1.Name = "SickLabel1"
        Me.SickLabel1.Size = New System.Drawing.Size(100, 18)
        Me.SickLabel1.TabIndex = 171
        Me.SickLabel1.Text = "Label5"
        '
        'Label5
        '
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_SP_OTBindingSource, "SP", True))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.Location = New System.Drawing.Point(12, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Label5"
        '
        'EmpCountLabel2
        '
        Me.EmpCountLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Emp_Meal_AttendanceBindingSource, "EmpCount", True))
        Me.EmpCountLabel2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.EmpCountLabel2.Location = New System.Drawing.Point(618, 483)
        Me.EmpCountLabel2.Name = "EmpCountLabel2"
        Me.EmpCountLabel2.Size = New System.Drawing.Size(100, 23)
        Me.EmpCountLabel2.TabIndex = 176
        Me.EmpCountLabel2.Text = "Label18"
        '
        'View_Emp_Deduction_Days_NEWBindingSource
        '
        Me.View_Emp_Deduction_Days_NEWBindingSource.DataMember = "View_Emp_Deduction_Days_NEW"
        Me.View_Emp_Deduction_Days_NEWBindingSource.DataSource = Me.DSAutoCalc
        '
        'View_Emp_Deduction_Days_NEWTableAdapter
        '
        Me.View_Emp_Deduction_Days_NEWTableAdapter.ClearBeforeFill = True
        '
        'DayDeductionLabel1
        '
        Me.DayDeductionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Emp_Deduction_Days_NEWBindingSource, "DayDeduction", True))
        Me.DayDeductionLabel1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DayDeductionLabel1.Location = New System.Drawing.Point(295, 488)
        Me.DayDeductionLabel1.Name = "DayDeductionLabel1"
        Me.DayDeductionLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DayDeductionLabel1.TabIndex = 178
        Me.DayDeductionLabel1.Text = "Label18"
        '
        'Tbl_Acc_INCBindingSource
        '
        Me.Tbl_Acc_INCBindingSource.DataMember = "tbl_Acc_INC"
        Me.Tbl_Acc_INCBindingSource.DataSource = Me.DSCalculateSalary
        '
        'Tbl_Acc_INCTableAdapter
        '
        Me.Tbl_Acc_INCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.tbl_Acc_INCTableAdapter = Me.Tbl_Acc_INCTableAdapter
        Me.TableAdapterManager4.tbl_Acc_Salary_TransactionsTableAdapter = Nothing
        Me.TableAdapterManager4.tbl_Emp_Salary_Calculation_AdjTableAdapter = Nothing
        Me.TableAdapterManager4.tbl_Hrm_Emp_Info_Cards_InfoTableAdapter = Nothing
        Me.TableAdapterManager4.tbl_Hrm_Emp_Info_HTableAdapter = Nothing
        Me.TableAdapterManager4.UpdateOrder = ERP_HRMS.DSCalculateSalaryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LabelSenAll
        '
        Me.LabelSenAll.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_HRMSBindingSource, "SenAllowance", True))
        Me.LabelSenAll.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.LabelSenAll.Location = New System.Drawing.Point(651, 465)
        Me.LabelSenAll.Name = "LabelSenAll"
        Me.LabelSenAll.Size = New System.Drawing.Size(100, 23)
        Me.LabelSenAll.TabIndex = 141
        Me.LabelSenAll.Text = "Label5"
        '
        'frmAutoSalCalculation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1013, 608)
        Me.Controls.Add(Me.LabelSenAll)
        Me.Controls.Add(Me.DayDeductionLabel1)
        Me.Controls.Add(Me.EmpCountLabel2)
        Me.Controls.Add(Me.AnnualLabel1)
        Me.Controls.Add(Me.M2Label1)
        Me.Controls.Add(Me.SpecialLabel1)
        Me.Controls.Add(Me.CasualLabel1)
        Me.Controls.Add(Me.SickLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SPLabel1)
        Me.Controls.Add(Me.PBalanceLabel1)
        Me.Controls.Add(Me.TempAdvLabel1)
        Me.Controls.Add(Me.DedRateLabel1)
        Me.Controls.Add(Me.HolidayCountLabel1)
        Me.Controls.Add(Me.FairPriceLabel1)
        Me.Controls.Add(Me.MealEmpCountLabel1)
        Me.Controls.Add(Me.RFAMTLabel1)
        Me.Controls.Add(Me.FullMinutesWorkedLabel1)
        Me.Controls.Add(Me.HalfDaysLabel1)
        Me.Controls.Add(Me.FullDaysLabel1)
        Me.Controls.Add(Me.PaidLabel1)
        Me.Controls.Add(Me.RentDeductionLabel1)
        Me.Controls.Add(Me.SenStatusLabel1)
        Me.Controls.Add(Me.DateOfJoningLabel1)
        Me.Controls.Add(Me.AccommodationLabel1)
        Me.Controls.Add(Me.PESSIContLabel1)
        Me.Controls.Add(Me.PaymentModeLabel1)
        Me.Controls.Add(Me.UnionFundLabel1)
        Me.Controls.Add(Me.ConteenDeductLabel1)
        Me.Controls.Add(Me.TaxDeductionLabel1)
        Me.Controls.Add(Me.EOBILabel1)
        Me.Controls.Add(Me.SpecialAllowanceLabel1)
        Me.Controls.Add(Me.EducationAllowanceLabel1)
        Me.Controls.Add(Me.TravelAllowanceLabel1)
        Me.Controls.Add(Me.MealAllowanceLabel1)
        Me.Controls.Add(Me.BasicSalaryLabel1)
        Me.Controls.Add(Me.SectionNameLabel1)
        Me.Controls.Add(Me.GradeNameLabel1)
        Me.Controls.Add(Me.DesigNameLabel1)
        Me.Controls.Add(Me.DeptNameLabel1)
        Me.Controls.Add(Me.EmpIDLabel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.EmpCountLabel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CasualLeaveLabel1)
        Me.Controls.Add(Me.SpecialLeaveLabel1)
        Me.Controls.Add(Me.M1Label1)
        Me.Controls.Add(Me.PaidLeavesLabel2)
        Me.Controls.Add(Me.UnPaidLeavesLabel2)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lblWorkingDays)
        Me.Controls.Add(Me.SpecialAllowanceLabel2)
        Me.Controls.Add(Me.GrossSalaryLabel2)
        Me.Controls.Add(Me.EmpIDLabel2)
        Me.Controls.Add(Me.EndOfProbationDateLabel1)
        Me.Controls.Add(Me.PAdvDedRateLabel1)
        Me.Controls.Add(Me.EveningShortMinsLabel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Name = "frmAutoSalCalculation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Monthly Salary Calculations"
        Me.Panel1.ResumeLayout(False)
        CType(Me.View_HRMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAutoCalc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSCalculateSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Deduction_DaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HRMDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_Salary_TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Salary_PaidLeavesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_PayRoll_EmpAttRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_OverTimeSumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Emp_Salary_Calculation_AdjBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_RFD_PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAUTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_RFD_PayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Meal_AttendanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_FairShopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_Emp_MaxAdvance_DedRateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_ShortTermAdvancesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Acc_Adv_BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSSP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_SP_OTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Deduction_Days_NEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_INCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DSCalculateSalary As ERP_HRMS.DSCalculateSalary
    Friend WithEvents EmpIDLabel2 As System.Windows.Forms.Label
    Friend WithEvents GrossSalaryLabel2 As System.Windows.Forms.Label
    Friend WithEvents SpecialAllowanceLabel2 As System.Windows.Forms.Label
    Friend WithEvents CasualLeaveLabel1 As System.Windows.Forms.Label
    Friend WithEvents SpecialLeaveLabel1 As System.Windows.Forms.Label
    Friend WithEvents PaidLeavesLabel2 As System.Windows.Forms.Label
    Friend WithEvents lblWorkingDays As System.Windows.Forms.Label
    Friend WithEvents M1Label1 As System.Windows.Forms.Label
    Friend WithEvents UnPaidLeavesLabel2 As System.Windows.Forms.Label
    Friend WithEvents lblBeforeFinal As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents EndOfProbationDateLabel1 As System.Windows.Forms.Label
    Friend WithEvents PAdvDedRateLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents lblAdds As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents EveningShortMinsLabel1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents EmpCountLabel1 As System.Windows.Forms.Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents TableAdapterManager1 As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents View_Emp_Deduction_DaysBindingSource As BindingSource
    Friend WithEvents View_Emp_Deduction_DaysTableAdapter As DSCalculateSalaryTableAdapters.View_Emp_Deduction_DaysTableAdapter
    Friend WithEvents DSUser As DSUser
    Friend WithEvents HRMDBDataSet1 As HRMDBDataset1
    Friend WithEvents DSAutoCalc As DSAutoCalc
    Friend WithEvents View_HRMSBindingSource As BindingSource
    Friend WithEvents View_HRMSTableAdapter As DSAutoCalcTableAdapters.View_HRMSTableAdapter
    Friend WithEvents TableAdapterManager As DSAutoCalcTableAdapters.TableAdapterManager
    Friend WithEvents EmpIDLabel1 As Label
    Friend WithEvents DeptNameLabel1 As Label
    Friend WithEvents DesigNameLabel1 As Label
    Friend WithEvents GradeNameLabel1 As Label
    Friend WithEvents SectionNameLabel1 As Label
    Friend WithEvents BasicSalaryLabel1 As Label
    Friend WithEvents MealAllowanceLabel1 As Label
    Friend WithEvents TravelAllowanceLabel1 As Label
    Friend WithEvents EducationAllowanceLabel1 As Label
    Friend WithEvents SpecialAllowanceLabel1 As Label
    Friend WithEvents EOBILabel1 As Label
    Friend WithEvents TaxDeductionLabel1 As Label
    Friend WithEvents ConteenDeductLabel1 As Label
    Friend WithEvents UnionFundLabel1 As Label
    Friend WithEvents PaymentModeLabel1 As Label
    Friend WithEvents PESSIContLabel1 As Label
    Friend WithEvents AccommodationLabel1 As Label
    Friend WithEvents DateOfJoningLabel1 As Label
    Friend WithEvents SenStatusLabel1 As Label
    Friend WithEvents Tbl_Acc_Salary_TransactionsBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_Salary_TransactionsTableAdapter As DSAutoCalcTableAdapters.tbl_Acc_Salary_TransactionsTableAdapter
    Friend WithEvents RentDeductionLabel1 As Label
    Friend WithEvents View_Salary_PaidLeavesBindingSource As BindingSource
    Friend WithEvents View_Salary_PaidLeavesTableAdapter As DSAutoCalcTableAdapters.View_Salary_PaidLeavesTableAdapter
    Friend WithEvents PaidLabel1 As Label
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecordBindingSource As BindingSource
    Friend WithEvents View_Rpt_PayRoll_EmpAttRecordTableAdapter As DSAutoCalcTableAdapters.View_Rpt_PayRoll_EmpAttRecordTableAdapter
    Friend WithEvents FullDaysLabel1 As Label
    Friend WithEvents HalfDaysLabel1 As Label
    Friend WithEvents View_Rpt_Acc_OverTimeSumBindingSource As BindingSource
    Friend WithEvents View_Rpt_Acc_OverTimeSumTableAdapter As DSAutoCalcTableAdapters.View_Rpt_Acc_OverTimeSumTableAdapter
    Friend WithEvents FullMinutesWorkedLabel1 As Label
    Friend WithEvents Tbl_Emp_Salary_Calculation_AdjBindingSource As BindingSource
    Friend WithEvents Tbl_Emp_Salary_Calculation_AdjTableAdapter As DSAutoCalcTableAdapters.tbl_Emp_Salary_Calculation_AdjTableAdapter
    Friend WithEvents Tbl_Acc_RFD_PayBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_RFD_PayTableAdapter As DSAutoCalcTableAdapters.tbl_Acc_RFD_PayTableAdapter
    Friend WithEvents DSAUTO As DSAUTO
    Friend WithEvents View_Acc_RFD_PayBindingSource As BindingSource
    Friend WithEvents View_Acc_RFD_PayTableAdapter As DSAUTOTableAdapters.View_Acc_RFD_PayTableAdapter
    Friend WithEvents TableAdapterManager2 As DSAUTOTableAdapters.TableAdapterManager
    Friend WithEvents RFAMTLabel1 As Label
    Friend WithEvents View_Emp_Meal_AttendanceBindingSource As BindingSource
    Friend WithEvents View_Emp_Meal_AttendanceTableAdapter As DSAUTOTableAdapters.View_Emp_Meal_AttendanceTableAdapter
    Friend WithEvents MealEmpCountLabel1 As Label
    Friend WithEvents View_Acc_FairShopBindingSource As BindingSource
    Friend WithEvents View_Acc_FairShopTableAdapter As DSAUTOTableAdapters.View_Acc_FairShopTableAdapter
    Friend WithEvents FairPriceLabel1 As Label
    Friend WithEvents Tbl_Hrm_HolidaysBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_HolidaysTableAdapter As DSAUTOTableAdapters.tbl_Hrm_HolidaysTableAdapter
    Friend WithEvents HolidayCountLabel1 As Label
    Friend WithEvents View_Acc_Emp_MaxAdvance_DedRateBindingSource As BindingSource
    Friend WithEvents View_Acc_Emp_MaxAdvance_DedRateTableAdapter As DSAUTOTableAdapters.View_Acc_Emp_MaxAdvance_DedRateTableAdapter
    Friend WithEvents DedRateLabel1 As Label
    Friend WithEvents Tbl_Acc_ShortTermAdvancesBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_ShortTermAdvancesTableAdapter As DSAUTOTableAdapters.tbl_Acc_ShortTermAdvancesTableAdapter
    Friend WithEvents TempAdvLabel1 As Label
    Friend WithEvents View_Acc_Adv_BalanceBindingSource As BindingSource
    Friend WithEvents View_Acc_Adv_BalanceTableAdapter As DSAUTOTableAdapters.View_Acc_Adv_BalanceTableAdapter
    Friend WithEvents PBalanceLabel1 As Label
    Friend WithEvents DSSP As DSSP
    Friend WithEvents View_SP_OTBindingSource As BindingSource
    Friend WithEvents View_SP_OTTableAdapter As DSSPTableAdapters.View_SP_OTTableAdapter
    Friend WithEvents TableAdapterManager3 As DSSPTableAdapters.TableAdapterManager
    Friend WithEvents SPLabel1 As Label
    Friend WithEvents AnnualLabel1 As Label
    Friend WithEvents M2Label1 As Label
    Friend WithEvents SpecialLabel1 As Label
    Friend WithEvents CasualLabel1 As Label
    Friend WithEvents SickLabel1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EmpCountLabel2 As Label
    Friend WithEvents View_Emp_Deduction_Days_NEWBindingSource As BindingSource
    Friend WithEvents View_Emp_Deduction_Days_NEWTableAdapter As DSAutoCalcTableAdapters.View_Emp_Deduction_Days_NEWTableAdapter
    Friend WithEvents DayDeductionLabel1 As Label
    Friend WithEvents Tbl_Acc_INCBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_INCTableAdapter As DSCalculateSalaryTableAdapters.tbl_Acc_INCTableAdapter
    Friend WithEvents TableAdapterManager4 As DSCalculateSalaryTableAdapters.TableAdapterManager
    Friend WithEvents LabelSenAll As Label
End Class
