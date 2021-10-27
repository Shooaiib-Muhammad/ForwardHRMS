<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmpManagment
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
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim BankAccountNOLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim EOBINOLabel As System.Windows.Forms.Label
        Dim NTNNOLabel As System.Windows.Forms.Label
        Dim SSCNOLabel As System.Windows.Forms.Label
        Dim ReasonLabel As System.Windows.Forms.Label
        Dim LeaveDateLabel As System.Windows.Forms.Label
        Dim CatagoryNameLabel As System.Windows.Forms.Label
        Dim EmployeeExperianceLabel As System.Windows.Forms.Label
        Dim EmploymentNameLabel As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim GradeNameLabel As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim JobTypeNameLabel As System.Windows.Forms.Label
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim SectionNameLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim EmpProvinceLabel As System.Windows.Forms.Label
        Dim QualficationNameLabel As System.Windows.Forms.Label
        Dim PermanentAddressLabel As System.Windows.Forms.Label
        Dim EmpCityLabel As System.Windows.Forms.Label
        Dim ContactNoLabel As System.Windows.Forms.Label
        Dim DateOfBirthLabel As System.Windows.Forms.Label
        Dim MaritalStatusLabel As System.Windows.Forms.Label
        Dim BloodGroupLabel As System.Windows.Forms.Label
        Dim CNICNOLabel As System.Windows.Forms.Label
        Dim ReligionLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim MotherNameLabel As System.Windows.Forms.Label
        Dim FatherNameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim SalutationLabel As System.Windows.Forms.Label
        Dim JobTypeEffectiveDateLabel As System.Windows.Forms.Label
        Dim ShiftEffectiveDateLabel As System.Windows.Forms.Label
        Dim GradeEffectiveDateLabel As System.Windows.Forms.Label
        Dim BranchEffectiveDateLabel As System.Windows.Forms.Label
        Dim SectEffectiveDateLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim SalIDLabel As System.Windows.Forms.Label
        Dim BasicSalaryLabel As System.Windows.Forms.Label
        Dim MealAllowanceLabel As System.Windows.Forms.Label
        Dim TravelAllowanceLabel As System.Windows.Forms.Label
        Dim EducationAllowanceLabel As System.Windows.Forms.Label
        Dim SpecialAllowanceLabel As System.Windows.Forms.Label
        Dim EOBILabel As System.Windows.Forms.Label
        Dim TaxDeductionLabel As System.Windows.Forms.Label
        Dim RentDeductionLabel As System.Windows.Forms.Label
        Dim UnionFundLabel As System.Windows.Forms.Label
        Dim PaymentModeLabel As System.Windows.Forms.Label
        Dim FinancialPeriodLabel As System.Windows.Forms.Label
        Dim PESSIContLabel As System.Windows.Forms.Label
        Dim EffectedFromDateLabel As System.Windows.Forms.Label
        Dim ActivationDateLabel As System.Windows.Forms.Label
        Dim ActivationStatusLabel As System.Windows.Forms.Label
        Dim RefrenceLabel As System.Windows.Forms.Label
        Dim DateOfJoningLabel As System.Windows.Forms.Label
        Dim DateOfPermanentLabel As System.Windows.Forms.Label
        Dim GraduityDateLabel As System.Windows.Forms.Label
        Dim CardStatusLabel As System.Windows.Forms.Label
        Dim NoticeTypeLabel As System.Windows.Forms.Label
        Dim EmergencyContactNoLabel As System.Windows.Forms.Label
        Dim CurrentAddressLabel As System.Windows.Forms.Label
        Dim CopyNoLabel As System.Windows.Forms.Label
        Dim StartDateLabel As System.Windows.Forms.Label
        Dim EndDateLabel As System.Windows.Forms.Label
        Dim ConteenDeductLabel As System.Windows.Forms.Label
        Dim HiringCriteriaLabel As System.Windows.Forms.Label
        Dim HiringDescLabel As System.Windows.Forms.Label
        Dim IncrementStatusLabel As System.Windows.Forms.Label
        Dim AccommodationLabel As System.Windows.Forms.Label
        Dim AppIDLabel As System.Windows.Forms.Label
        Dim NetGrossSalaryLabel As System.Windows.Forms.Label
        Dim HODNameLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label25 As System.Windows.Forms.Label
        Dim Label26 As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpManagment))
        Dim Label31 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.LinkLabel13 = New System.Windows.Forms.LinkLabel()
        Me.CardStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LinkLabel19 = New System.Windows.Forms.LinkLabel()
        Me.DescriptionComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Emp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_disability_descptionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateOfBirthMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker14 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.CurrentAddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmergencyNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LinkLabel15 = New System.Windows.Forms.LinkLabel()
        Me.EmpProvinceComboBox = New System.Windows.Forms.ComboBox()
        Me.QualficationNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_QualficationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Uploadimage = New System.Windows.Forms.Button()
        Me.EmpPicPictureBox = New System.Windows.Forms.PictureBox()
        Me.PermanentAddressTextBox = New System.Windows.Forms.TextBox()
        Me.EmpCityTextBox = New System.Windows.Forms.TextBox()
        Me.MotherNameTextBox = New System.Windows.Forms.TextBox()
        Me.FatherNameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CMSEmpInfo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchByNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSName = New System.Windows.Forms.ToolStripTextBox()
        Me.RemoveFilterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactNoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MaritalStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.BloodGroupComboBox = New System.Windows.Forms.ComboBox()
        Me.CNICNOMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CMSSearchNIC = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtSearchNIC = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReligionComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.SalutationComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker15 = New System.Windows.Forms.DateTimePicker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.AddCopyBtn = New System.Windows.Forms.Button()
        Me.DateTimePicker9 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker8 = New System.Windows.Forms.DateTimePicker()
        Me.printbtn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.RadioButton()
        Me.frntbtn = New System.Windows.Forms.RadioButton()
        Me.EndDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.StartDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CopyNoTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.HiringDescTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker12 = New System.Windows.Forms.DateTimePicker()
        Me.HiringCriteriaComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker11 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker10 = New System.Windows.Forms.DateTimePicker()
        Me.GraduityDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DateOfPermanentMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DateOfJoning = New System.Windows.Forms.MaskedTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.View_Emp_Report_TO_NEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSRPTTO = New ERP_HRMS.DSRPTTO()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.RefrenceTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.View_Emp_Report_TOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSReportTo = New ERP_HRMS.DSReportTo()
        Me.CatagoryNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_EmpCatagoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmploymentNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_EmploymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.EmployeeExperianceTextBox = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.SenStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.LinkLabel14 = New System.Windows.Forms.LinkLabel()
        Me.BankNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankAccountNOTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.EOBINOTextBox = New System.Windows.Forms.TextBox()
        Me.NTNNOTextBox = New System.Windows.Forms.TextBox()
        Me.SSCNOTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker7 = New System.Windows.Forms.DateTimePicker()
        Me.EmpStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReasonComboBox = New System.Windows.Forms.ComboBox()
        Me.View_HRM_Leave_ReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSDept = New ERP_HRMS.DSDept()
        Me.LeaveDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.NoticeTypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Hrm_Emp_NoticesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddNoticeBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NoticeTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Leave_ReasonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel17 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.NoticeNo = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LinkLabel12 = New System.Windows.Forms.LinkLabel()
        Me.BranchEffectiveDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShiftEffectiveDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.LinkLabel10 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.LinkLabel11 = New System.Windows.Forms.LinkLabel()
        Me.GradeEffectiveDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GradeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.JobTypeEffectiveDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.JobTypeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_JobTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.LinkLabel16 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.SectEffectiveDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_Section_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Dept_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Bus_Route_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSBusInfo = New ERP_HRMS.DSBusInfo()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SalIDTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_Acc_SalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_Salary_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_App_AuthorityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncrementStatusLabel1 = New System.Windows.Forms.Label()
        Me.DateTimePicker13 = New System.Windows.Forms.DateTimePicker()
        Me.EffectedFromDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PaymentModeComboBox = New System.Windows.Forms.ComboBox()
        Me.FinancialPeriodComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_Acc_FinancialPeriodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActivationStatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.ActivationDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.NetGrossSalaryLabel1 = New System.Windows.Forms.Label()
        Me.AccommodationTextBox = New System.Windows.Forms.TextBox()
        Me.MealAllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.BasicSalaryTextBox = New System.Windows.Forms.TextBox()
        Me.TravelAllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.EducationAllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.SpecialAllowanceTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.ConteenDeductTextBox = New System.Windows.Forms.TextBox()
        Me.TaxDeductionTextBox = New System.Windows.Forms.TextBox()
        Me.EOBITextBox = New System.Windows.Forms.TextBox()
        Me.RentDeductionTextBox = New System.Windows.Forms.TextBox()
        Me.UnionFundTextBox = New System.Windows.Forms.TextBox()
        Me.PESSIContCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tbl_Acc_SalaryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.AddSalary = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox7 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveSalary = New System.Windows.Forms.ToolStripButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker17 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker18 = New System.Windows.Forms.DateTimePicker()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.NameLabel2 = New System.Windows.Forms.Label()
        Me.HODNameComboBox = New System.Windows.Forms.ComboBox()
        Me.View_HODBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_HOD_NewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Dept1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LinkLabel18 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CardStatusLabel1 = New System.Windows.Forms.Label()
        Me.CardNoLabel3 = New System.Windows.Forms.Label()
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpIDLabel3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.CardNoLabel2 = New System.Windows.Forms.Label()
        Me.EmpIDLabel2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.EmpIDTextBox = New System.Windows.Forms.TextBox()
        Me.Tbl_HRM_Dept_NewTableAdapter = New ERP_HRMS.DSDeptTableAdapters.tbl_HRM_Dept_NewTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSDeptTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Section_NewTableAdapter = New ERP_HRMS.DSDeptTableAdapters.tbl_HRM_Section_NewTableAdapter()
        Me.SectionIDLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.View_Inactive_EmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Inactive_EmpTableAdapter = New ERP_HRMS.DSDeptTableAdapters.View_Inactive_EmpTableAdapter()
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.Tbl_MIS_User_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MIS_User_DeptTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_MIS_User_DeptTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_CardTableAdapter()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_JobTypeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter()
        Me.Tbl_HRM_QualficationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_QualficationTableAdapter()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.Tbl_Hrm_EmploymentTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Hrm_EmploymentTableAdapter()
        Me.Tbl_HRM_EmpCatagoryTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_EmpCatagoryTableAdapter()
        Me.Tbl_HRM_Leave_ReasonTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_Leave_ReasonTableAdapter()
        Me.Tbl_HRM_BankTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BankTableAdapter()
        Me.Tbl_Acc_SalaryTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Acc_SalaryTableAdapter()
        Me.Tbl_Acc_FinancialPeriodTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Acc_FinancialPeriodTableAdapter()
        Me.Tbl_Hrm_Emp_NoticesTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Hrm_Emp_NoticesTableAdapter()
        Me.Tbl_HRM_Designation1TableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_Designation1TableAdapter()
        Me.Tbl_Acc_Salary1TableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Acc_Salary1TableAdapter()
        Me.Tbl_HRM_App_AuthorityTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_App_AuthorityTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Designation1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_Salary1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter = New ERP_HRMS.DSHRMTableAdapters.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_Emp_InfoTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_Emp_InfoTableAdapter()
        Me.Tbl_HRM_Dept1TableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_Dept1TableAdapter()
        Me.Tbl_Acc_Salary_NewTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Acc_Salary_NewTableAdapter()
        Me.Tbl_Acc_Salary2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Acc_Salary2TableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_Acc_Salary2TableAdapter()
        Me.View_HODTableAdapter = New ERP_HRMS.DSHRMTableAdapters.View_HODTableAdapter()
        Me.View_HOD_NewTableAdapter = New ERP_HRMS.DSHRMTableAdapters.View_HOD_NewTableAdapter()
        Me.EmploymentIDLabel1 = New System.Windows.Forms.Label()
        Me.View_HRM_Leave_ReasonTableAdapter = New ERP_HRMS.DSDeptTableAdapters.View_HRM_Leave_ReasonTableAdapter()
        Me.Tbl_Bus_Route_InfoTableAdapter = New ERP_HRMS.DSBusInfoTableAdapters.tbl_Bus_Route_InfoTableAdapter()
        Me.TableAdapterManager3 = New ERP_HRMS.DSBusInfoTableAdapters.TableAdapterManager()
        Me.Tbl_disability_descptionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_disability_descptionTableAdapter()
        Me.DSEMP = New ERP_HRMS.DSEMP()
        Me.Tbl_HRM_Emp_Info_SAVEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Info_SAVETableAdapter = New ERP_HRMS.DSEMPTableAdapters.tbl_HRM_Emp_Info_SAVETableAdapter()
        Me.TableAdapterManager4 = New ERP_HRMS.DSEMPTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_Emp_Info_SAVE_NEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Info_SAVE_NEWTableAdapter = New ERP_HRMS.DSEMPTableAdapters.tbl_HRM_Emp_Info_SAVE_NEWTableAdapter()
        Me.View_Emp_Report_TOTableAdapter = New ERP_HRMS.DSReportToTableAdapters.View_Emp_Report_TOTableAdapter()
        Me.TableAdapterManager5 = New ERP_HRMS.DSReportToTableAdapters.TableAdapterManager()
        Me.View_Emp_Report_TO_NEWTableAdapter = New ERP_HRMS.DSRPTTOTableAdapters.View_Emp_Report_TO_NEWTableAdapter()
        Me.TableAdapterManager6 = New ERP_HRMS.DSRPTTOTableAdapters.TableAdapterManager()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        CardNoLabel = New System.Windows.Forms.Label()
        BankNameLabel = New System.Windows.Forms.Label()
        BankAccountNOLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        EOBINOLabel = New System.Windows.Forms.Label()
        NTNNOLabel = New System.Windows.Forms.Label()
        SSCNOLabel = New System.Windows.Forms.Label()
        ReasonLabel = New System.Windows.Forms.Label()
        LeaveDateLabel = New System.Windows.Forms.Label()
        CatagoryNameLabel = New System.Windows.Forms.Label()
        EmployeeExperianceLabel = New System.Windows.Forms.Label()
        EmploymentNameLabel = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        GradeNameLabel = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        JobTypeNameLabel = New System.Windows.Forms.Label()
        DesigNameLabel = New System.Windows.Forms.Label()
        SectionNameLabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        EmpProvinceLabel = New System.Windows.Forms.Label()
        QualficationNameLabel = New System.Windows.Forms.Label()
        PermanentAddressLabel = New System.Windows.Forms.Label()
        EmpCityLabel = New System.Windows.Forms.Label()
        ContactNoLabel = New System.Windows.Forms.Label()
        DateOfBirthLabel = New System.Windows.Forms.Label()
        MaritalStatusLabel = New System.Windows.Forms.Label()
        BloodGroupLabel = New System.Windows.Forms.Label()
        CNICNOLabel = New System.Windows.Forms.Label()
        ReligionLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        MotherNameLabel = New System.Windows.Forms.Label()
        FatherNameLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        SalutationLabel = New System.Windows.Forms.Label()
        JobTypeEffectiveDateLabel = New System.Windows.Forms.Label()
        ShiftEffectiveDateLabel = New System.Windows.Forms.Label()
        GradeEffectiveDateLabel = New System.Windows.Forms.Label()
        BranchEffectiveDateLabel = New System.Windows.Forms.Label()
        SectEffectiveDateLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        SalIDLabel = New System.Windows.Forms.Label()
        BasicSalaryLabel = New System.Windows.Forms.Label()
        MealAllowanceLabel = New System.Windows.Forms.Label()
        TravelAllowanceLabel = New System.Windows.Forms.Label()
        EducationAllowanceLabel = New System.Windows.Forms.Label()
        SpecialAllowanceLabel = New System.Windows.Forms.Label()
        EOBILabel = New System.Windows.Forms.Label()
        TaxDeductionLabel = New System.Windows.Forms.Label()
        RentDeductionLabel = New System.Windows.Forms.Label()
        UnionFundLabel = New System.Windows.Forms.Label()
        PaymentModeLabel = New System.Windows.Forms.Label()
        FinancialPeriodLabel = New System.Windows.Forms.Label()
        PESSIContLabel = New System.Windows.Forms.Label()
        EffectedFromDateLabel = New System.Windows.Forms.Label()
        ActivationDateLabel = New System.Windows.Forms.Label()
        ActivationStatusLabel = New System.Windows.Forms.Label()
        RefrenceLabel = New System.Windows.Forms.Label()
        DateOfJoningLabel = New System.Windows.Forms.Label()
        DateOfPermanentLabel = New System.Windows.Forms.Label()
        GraduityDateLabel = New System.Windows.Forms.Label()
        CardStatusLabel = New System.Windows.Forms.Label()
        NoticeTypeLabel = New System.Windows.Forms.Label()
        EmergencyContactNoLabel = New System.Windows.Forms.Label()
        CurrentAddressLabel = New System.Windows.Forms.Label()
        CopyNoLabel = New System.Windows.Forms.Label()
        StartDateLabel = New System.Windows.Forms.Label()
        EndDateLabel = New System.Windows.Forms.Label()
        ConteenDeductLabel = New System.Windows.Forms.Label()
        HiringCriteriaLabel = New System.Windows.Forms.Label()
        HiringDescLabel = New System.Windows.Forms.Label()
        IncrementStatusLabel = New System.Windows.Forms.Label()
        AccommodationLabel = New System.Windows.Forms.Label()
        AppIDLabel = New System.Windows.Forms.Label()
        NetGrossSalaryLabel = New System.Windows.Forms.Label()
        HODNameLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label25 = New System.Windows.Forms.Label()
        Label26 = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_disability_descptionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_QualficationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSEmpInfo.SuspendLayout()
        Me.CMSSearchNIC.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.View_Emp_Report_TO_NEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSRPTTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Emp_Report_TOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSReportTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_EmpCatagoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_EmploymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Tbl_HRM_BankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.View_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSDept, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_Hrm_Emp_NoticesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Section_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Dept_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        CType(Me.Tbl_Bus_Route_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBusInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        CType(Me.Tbl_Acc_Salary_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_App_AuthorityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.Tbl_Acc_SalaryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Acc_SalaryBindingNavigator.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        CType(Me.View_HODBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_HOD_NewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Dept1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Inactive_EmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MIS_User_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Designation1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_Salary1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Acc_Salary2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSEMP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Info_SAVEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Info_SAVE_NEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CardNoLabel
        '
        CardNoLabel.Location = New System.Drawing.Point(26, 35)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(52, 13)
        CardNoLabel.TabIndex = 2
        CardNoLabel.Text = "Card No.:"
        CardNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BankNameLabel
        '
        BankNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BankNameLabel.ForeColor = System.Drawing.Color.Black
        BankNameLabel.Location = New System.Drawing.Point(9, 129)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(89, 20)
        BankNameLabel.TabIndex = 23232
        BankNameLabel.Text = "Bank:"
        BankNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BankAccountNOLabel
        '
        BankAccountNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BankAccountNOLabel.ForeColor = System.Drawing.Color.Black
        BankAccountNOLabel.Location = New System.Drawing.Point(9, 106)
        BankAccountNOLabel.Name = "BankAccountNOLabel"
        BankAccountNOLabel.Size = New System.Drawing.Size(89, 20)
        BankAccountNOLabel.TabIndex = 223232
        BankAccountNOLabel.Text = "Bank Acc No.:"
        BankAccountNOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailAddressLabel.ForeColor = System.Drawing.Color.Black
        EmailAddressLabel.Location = New System.Drawing.Point(9, 83)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(89, 20)
        EmailAddressLabel.TabIndex = 33333344
        EmailAddressLabel.Text = "Email Address:"
        EmailAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EOBINOLabel
        '
        EOBINOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EOBINOLabel.ForeColor = System.Drawing.Color.Black
        EOBINOLabel.Location = New System.Drawing.Point(9, 37)
        EOBINOLabel.Name = "EOBINOLabel"
        EOBINOLabel.Size = New System.Drawing.Size(89, 20)
        EOBINOLabel.TabIndex = 121212121
        EOBINOLabel.Text = "EOBI No.:"
        EOBINOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NTNNOLabel
        '
        NTNNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NTNNOLabel.ForeColor = System.Drawing.Color.Black
        NTNNOLabel.Location = New System.Drawing.Point(9, 60)
        NTNNOLabel.Name = "NTNNOLabel"
        NTNNOLabel.Size = New System.Drawing.Size(89, 20)
        NTNNOLabel.TabIndex = 12121233
        NTNNOLabel.Text = "NTN No.:"
        NTNNOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SSCNOLabel
        '
        SSCNOLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SSCNOLabel.ForeColor = System.Drawing.Color.Black
        SSCNOLabel.Location = New System.Drawing.Point(9, 14)
        SSCNOLabel.Name = "SSCNOLabel"
        SSCNOLabel.Size = New System.Drawing.Size(89, 20)
        SSCNOLabel.TabIndex = 12121
        SSCNOLabel.Text = "SSC No.:"
        SSCNOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReasonLabel
        '
        ReasonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReasonLabel.ForeColor = System.Drawing.Color.Black
        ReasonLabel.Location = New System.Drawing.Point(9, 20)
        ReasonLabel.Name = "ReasonLabel"
        ReasonLabel.Size = New System.Drawing.Size(89, 20)
        ReasonLabel.TabIndex = 12122323
        ReasonLabel.Text = "Reason:"
        ReasonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LeaveDateLabel
        '
        LeaveDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LeaveDateLabel.ForeColor = System.Drawing.Color.Black
        LeaveDateLabel.Location = New System.Drawing.Point(9, 66)
        LeaveDateLabel.Name = "LeaveDateLabel"
        LeaveDateLabel.Size = New System.Drawing.Size(89, 20)
        LeaveDateLabel.TabIndex = 23234545
        LeaveDateLabel.Text = "Leaving Date:"
        LeaveDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CatagoryNameLabel
        '
        CatagoryNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CatagoryNameLabel.ForeColor = System.Drawing.Color.Black
        CatagoryNameLabel.Location = New System.Drawing.Point(6, 14)
        CatagoryNameLabel.Name = "CatagoryNameLabel"
        CatagoryNameLabel.Size = New System.Drawing.Size(101, 20)
        CatagoryNameLabel.TabIndex = 121212
        CatagoryNameLabel.Text = "Employee Category:"
        CatagoryNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmployeeExperianceLabel
        '
        EmployeeExperianceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmployeeExperianceLabel.ForeColor = System.Drawing.Color.Black
        EmployeeExperianceLabel.Location = New System.Drawing.Point(6, 142)
        EmployeeExperianceLabel.Name = "EmployeeExperianceLabel"
        EmployeeExperianceLabel.Size = New System.Drawing.Size(101, 20)
        EmployeeExperianceLabel.TabIndex = 12121
        EmployeeExperianceLabel.Text = "Prev. Experience:"
        '
        'EmploymentNameLabel
        '
        EmploymentNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmploymentNameLabel.ForeColor = System.Drawing.Color.Black
        EmploymentNameLabel.Location = New System.Drawing.Point(6, 40)
        EmploymentNameLabel.Name = "EmploymentNameLabel"
        EmploymentNameLabel.Size = New System.Drawing.Size(101, 20)
        EmploymentNameLabel.TabIndex = 1212121
        EmploymentNameLabel.Text = "Employment Type:"
        EmploymentNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BranchNameLabel
        '
        BranchNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(4, 16)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(100, 20)
        BranchNameLabel.TabIndex = 121212
        BranchNameLabel.Text = "Branch:"
        BranchNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GradeNameLabel
        '
        GradeNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradeNameLabel.ForeColor = System.Drawing.Color.Black
        GradeNameLabel.Location = New System.Drawing.Point(4, 15)
        GradeNameLabel.Name = "GradeNameLabel"
        GradeNameLabel.Size = New System.Drawing.Size(96, 20)
        GradeNameLabel.TabIndex = 111100
        GradeNameLabel.Text = "Grade:"
        GradeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShiftNameLabel.ForeColor = System.Drawing.Color.Black
        ShiftNameLabel.Location = New System.Drawing.Point(4, 17)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(96, 20)
        ShiftNameLabel.TabIndex = 1212121
        ShiftNameLabel.Text = "Shift:"
        ShiftNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JobTypeNameLabel
        '
        JobTypeNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JobTypeNameLabel.ForeColor = System.Drawing.Color.Black
        JobTypeNameLabel.Location = New System.Drawing.Point(6, 13)
        JobTypeNameLabel.Name = "JobTypeNameLabel"
        JobTypeNameLabel.Size = New System.Drawing.Size(90, 20)
        JobTypeNameLabel.TabIndex = 1111111111
        JobTypeNameLabel.Text = "Job Type:"
        JobTypeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DesigNameLabel
        '
        DesigNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DesigNameLabel.ForeColor = System.Drawing.Color.Black
        DesigNameLabel.Location = New System.Drawing.Point(4, 71)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(95, 20)
        DesigNameLabel.TabIndex = 1115
        DesigNameLabel.Text = "Designation:"
        DesigNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SectionNameLabel
        '
        SectionNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SectionNameLabel.ForeColor = System.Drawing.Color.Black
        SectionNameLabel.Location = New System.Drawing.Point(4, 45)
        SectionNameLabel.Name = "SectionNameLabel"
        SectionNameLabel.Size = New System.Drawing.Size(97, 20)
        SectionNameLabel.TabIndex = 110002
        SectionNameLabel.Text = "Section:"
        SectionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DeptNameLabel
        '
        DeptNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeptNameLabel.ForeColor = System.Drawing.Color.Black
        DeptNameLabel.Location = New System.Drawing.Point(4, 19)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(97, 20)
        DeptNameLabel.TabIndex = 11110
        DeptNameLabel.Text = "Department:"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmpProvinceLabel
        '
        EmpProvinceLabel.Location = New System.Drawing.Point(366, 130)
        EmpProvinceLabel.Name = "EmpProvinceLabel"
        EmpProvinceLabel.Size = New System.Drawing.Size(102, 20)
        EmpProvinceLabel.TabIndex = 63
        EmpProvinceLabel.Text = "Employee Province:"
        EmpProvinceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QualficationNameLabel
        '
        QualficationNameLabel.Location = New System.Drawing.Point(6, 235)
        QualficationNameLabel.Name = "QualficationNameLabel"
        QualficationNameLabel.Size = New System.Drawing.Size(97, 20)
        QualficationNameLabel.TabIndex = 61
        QualficationNameLabel.Text = "Qualification:"
        QualficationNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PermanentAddressLabel
        '
        PermanentAddressLabel.Location = New System.Drawing.Point(366, 156)
        PermanentAddressLabel.Name = "PermanentAddressLabel"
        PermanentAddressLabel.Size = New System.Drawing.Size(117, 73)
        PermanentAddressLabel.TabIndex = 57
        PermanentAddressLabel.Text = "Permanent Address:"
        '
        'EmpCityLabel
        '
        EmpCityLabel.Location = New System.Drawing.Point(366, 103)
        EmpCityLabel.Name = "EmpCityLabel"
        EmpCityLabel.Size = New System.Drawing.Size(102, 20)
        EmpCityLabel.TabIndex = 55
        EmpCityLabel.Text = "Employee City:"
        EmpCityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContactNoLabel
        '
        ContactNoLabel.Location = New System.Drawing.Point(366, 52)
        ContactNoLabel.Name = "ContactNoLabel"
        ContactNoLabel.Size = New System.Drawing.Size(102, 20)
        ContactNoLabel.TabIndex = 53
        ContactNoLabel.Text = "Contact No:"
        ContactNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfBirthLabel
        '
        DateOfBirthLabel.Location = New System.Drawing.Point(6, 315)
        DateOfBirthLabel.Name = "DateOfBirthLabel"
        DateOfBirthLabel.Size = New System.Drawing.Size(97, 20)
        DateOfBirthLabel.TabIndex = 51
        DateOfBirthLabel.Text = "Date Of Birth:"
        DateOfBirthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MaritalStatusLabel
        '
        MaritalStatusLabel.Location = New System.Drawing.Point(6, 288)
        MaritalStatusLabel.Name = "MaritalStatusLabel"
        MaritalStatusLabel.Size = New System.Drawing.Size(97, 20)
        MaritalStatusLabel.TabIndex = 49
        MaritalStatusLabel.Text = "Marital Status:"
        MaritalStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BloodGroupLabel
        '
        BloodGroupLabel.Location = New System.Drawing.Point(6, 261)
        BloodGroupLabel.Name = "BloodGroupLabel"
        BloodGroupLabel.Size = New System.Drawing.Size(97, 20)
        BloodGroupLabel.TabIndex = 47
        BloodGroupLabel.Text = "Blood Group:"
        BloodGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CNICNOLabel
        '
        CNICNOLabel.Location = New System.Drawing.Point(6, 209)
        CNICNOLabel.Name = "CNICNOLabel"
        CNICNOLabel.Size = New System.Drawing.Size(97, 20)
        CNICNOLabel.TabIndex = 45
        CNICNOLabel.Text = "CNIC NO:"
        CNICNOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReligionLabel
        '
        ReligionLabel.Location = New System.Drawing.Point(6, 182)
        ReligionLabel.Name = "ReligionLabel"
        ReligionLabel.Size = New System.Drawing.Size(97, 20)
        ReligionLabel.TabIndex = 43
        ReligionLabel.Text = "Religion:"
        ReligionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenderLabel
        '
        GenderLabel.Location = New System.Drawing.Point(6, 156)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(97, 20)
        GenderLabel.TabIndex = 41
        GenderLabel.Text = "Gender:"
        GenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MotherNameLabel
        '
        MotherNameLabel.Location = New System.Drawing.Point(6, 129)
        MotherNameLabel.Name = "MotherNameLabel"
        MotherNameLabel.Size = New System.Drawing.Size(97, 20)
        MotherNameLabel.TabIndex = 39
        MotherNameLabel.Text = "Mother Name:"
        MotherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FatherNameLabel
        '
        FatherNameLabel.Location = New System.Drawing.Point(6, 79)
        FatherNameLabel.Name = "FatherNameLabel"
        FatherNameLabel.Size = New System.Drawing.Size(119, 20)
        FatherNameLabel.TabIndex = 37
        FatherNameLabel.Text = "Father Name:"
        FatherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameLabel
        '
        NameLabel.Location = New System.Drawing.Point(6, 54)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(97, 20)
        NameLabel.TabIndex = 35
        NameLabel.Text = "Employee Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SalutationLabel
        '
        SalutationLabel.Location = New System.Drawing.Point(6, 28)
        SalutationLabel.Name = "SalutationLabel"
        SalutationLabel.Size = New System.Drawing.Size(97, 20)
        SalutationLabel.TabIndex = 33
        SalutationLabel.Text = "Salutation:"
        SalutationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'JobTypeEffectiveDateLabel
        '
        JobTypeEffectiveDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        JobTypeEffectiveDateLabel.ForeColor = System.Drawing.Color.Black
        JobTypeEffectiveDateLabel.Location = New System.Drawing.Point(6, 39)
        JobTypeEffectiveDateLabel.Name = "JobTypeEffectiveDateLabel"
        JobTypeEffectiveDateLabel.Size = New System.Drawing.Size(94, 20)
        JobTypeEffectiveDateLabel.TabIndex = 81111
        JobTypeEffectiveDateLabel.Text = "Effective Date:"
        JobTypeEffectiveDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShiftEffectiveDateLabel
        '
        ShiftEffectiveDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ShiftEffectiveDateLabel.ForeColor = System.Drawing.Color.Black
        ShiftEffectiveDateLabel.Location = New System.Drawing.Point(4, 40)
        ShiftEffectiveDateLabel.Name = "ShiftEffectiveDateLabel"
        ShiftEffectiveDateLabel.Size = New System.Drawing.Size(95, 20)
        ShiftEffectiveDateLabel.TabIndex = 2121222
        ShiftEffectiveDateLabel.Text = "Effective Date:"
        ShiftEffectiveDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GradeEffectiveDateLabel
        '
        GradeEffectiveDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GradeEffectiveDateLabel.ForeColor = System.Drawing.Color.Black
        GradeEffectiveDateLabel.Location = New System.Drawing.Point(4, 38)
        GradeEffectiveDateLabel.Name = "GradeEffectiveDateLabel"
        GradeEffectiveDateLabel.Size = New System.Drawing.Size(95, 20)
        GradeEffectiveDateLabel.TabIndex = 1121212
        GradeEffectiveDateLabel.Text = "Effective Date:"
        GradeEffectiveDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BranchEffectiveDateLabel
        '
        BranchEffectiveDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BranchEffectiveDateLabel.ForeColor = System.Drawing.Color.Black
        BranchEffectiveDateLabel.Location = New System.Drawing.Point(4, 43)
        BranchEffectiveDateLabel.Name = "BranchEffectiveDateLabel"
        BranchEffectiveDateLabel.Size = New System.Drawing.Size(96, 20)
        BranchEffectiveDateLabel.TabIndex = 1212121
        BranchEffectiveDateLabel.Text = "Effective Date:"
        BranchEffectiveDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SectEffectiveDateLabel
        '
        SectEffectiveDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SectEffectiveDateLabel.ForeColor = System.Drawing.Color.Black
        SectEffectiveDateLabel.Location = New System.Drawing.Point(4, 97)
        SectEffectiveDateLabel.Name = "SectEffectiveDateLabel"
        SectEffectiveDateLabel.Size = New System.Drawing.Size(96, 20)
        SectEffectiveDateLabel.TabIndex = 11115
        SectEffectiveDateLabel.Text = "Effective Date:"
        SectEffectiveDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(6, 14)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(90, 20)
        Label2.TabIndex = 22222
        Label2.Text = "Notice No.:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.Color.Black
        Label3.Location = New System.Drawing.Point(6, 68)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(90, 20)
        Label3.TabIndex = 12121
        Label3.Text = "Notice Reason:"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.Color.Black
        Label4.Location = New System.Drawing.Point(6, 99)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(90, 20)
        Label4.TabIndex = 12121
        Label4.Text = "Issue Date:"
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.Color.Black
        Label5.Location = New System.Drawing.Point(6, 130)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(92, 58)
        Label5.TabIndex = 121212
        Label5.Text = "Description:"
        '
        'SalIDLabel
        '
        SalIDLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        SalIDLabel.Location = New System.Drawing.Point(479, 274)
        SalIDLabel.Name = "SalIDLabel"
        SalIDLabel.Size = New System.Drawing.Size(100, 20)
        SalIDLabel.TabIndex = 37
        SalIDLabel.Text = "Serial No:"
        SalIDLabel.Visible = False
        '
        'BasicSalaryLabel
        '
        BasicSalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BasicSalaryLabel.Location = New System.Drawing.Point(12, 22)
        BasicSalaryLabel.Name = "BasicSalaryLabel"
        BasicSalaryLabel.Size = New System.Drawing.Size(110, 20)
        BasicSalaryLabel.TabIndex = 38
        BasicSalaryLabel.Text = "Basic Salary:"
        BasicSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MealAllowanceLabel
        '
        MealAllowanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MealAllowanceLabel.Location = New System.Drawing.Point(12, 74)
        MealAllowanceLabel.Name = "MealAllowanceLabel"
        MealAllowanceLabel.Size = New System.Drawing.Size(110, 20)
        MealAllowanceLabel.TabIndex = 39
        MealAllowanceLabel.Text = "Meal Allowance:"
        MealAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TravelAllowanceLabel
        '
        TravelAllowanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TravelAllowanceLabel.Location = New System.Drawing.Point(12, 98)
        TravelAllowanceLabel.Name = "TravelAllowanceLabel"
        TravelAllowanceLabel.Size = New System.Drawing.Size(110, 20)
        TravelAllowanceLabel.TabIndex = 40
        TravelAllowanceLabel.Text = "Per Month Travel :"
        TravelAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EducationAllowanceLabel
        '
        EducationAllowanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EducationAllowanceLabel.Location = New System.Drawing.Point(12, 149)
        EducationAllowanceLabel.Name = "EducationAllowanceLabel"
        EducationAllowanceLabel.Size = New System.Drawing.Size(110, 20)
        EducationAllowanceLabel.TabIndex = 41
        EducationAllowanceLabel.Text = "Education Allowance:"
        EducationAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpecialAllowanceLabel
        '
        SpecialAllowanceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SpecialAllowanceLabel.Location = New System.Drawing.Point(12, 48)
        SpecialAllowanceLabel.Name = "SpecialAllowanceLabel"
        SpecialAllowanceLabel.Size = New System.Drawing.Size(110, 20)
        SpecialAllowanceLabel.TabIndex = 42
        SpecialAllowanceLabel.Text = "Special Allowance:"
        SpecialAllowanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EOBILabel
        '
        EOBILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EOBILabel.Location = New System.Drawing.Point(14, 131)
        EOBILabel.Name = "EOBILabel"
        EOBILabel.Size = New System.Drawing.Size(102, 20)
        EOBILabel.TabIndex = 43
        EOBILabel.Text = "EOBI Contribution:"
        EOBILabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TaxDeductionLabel
        '
        TaxDeductionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TaxDeductionLabel.Location = New System.Drawing.Point(14, 27)
        TaxDeductionLabel.Name = "TaxDeductionLabel"
        TaxDeductionLabel.Size = New System.Drawing.Size(102, 20)
        TaxDeductionLabel.TabIndex = 44
        TaxDeductionLabel.Text = "Tax Deduction:"
        TaxDeductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RentDeductionLabel
        '
        RentDeductionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RentDeductionLabel.Location = New System.Drawing.Point(14, 53)
        RentDeductionLabel.Name = "RentDeductionLabel"
        RentDeductionLabel.Size = New System.Drawing.Size(102, 20)
        RentDeductionLabel.TabIndex = 45
        RentDeductionLabel.Text = "Rent Deduction:"
        RentDeductionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UnionFundLabel
        '
        UnionFundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnionFundLabel.Location = New System.Drawing.Point(14, 79)
        UnionFundLabel.Name = "UnionFundLabel"
        UnionFundLabel.Size = New System.Drawing.Size(102, 20)
        UnionFundLabel.TabIndex = 46
        UnionFundLabel.Text = "Union Fund:"
        UnionFundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PaymentModeLabel
        '
        PaymentModeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaymentModeLabel.Location = New System.Drawing.Point(13, 49)
        PaymentModeLabel.Name = "PaymentModeLabel"
        PaymentModeLabel.Size = New System.Drawing.Size(93, 20)
        PaymentModeLabel.TabIndex = 47
        PaymentModeLabel.Text = "Payment Mode:"
        PaymentModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FinancialPeriodLabel
        '
        FinancialPeriodLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FinancialPeriodLabel.Location = New System.Drawing.Point(13, 22)
        FinancialPeriodLabel.Name = "FinancialPeriodLabel"
        FinancialPeriodLabel.Size = New System.Drawing.Size(93, 20)
        FinancialPeriodLabel.TabIndex = 48
        FinancialPeriodLabel.Text = "Financial Period:"
        FinancialPeriodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PESSIContLabel
        '
        PESSIContLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PESSIContLabel.Location = New System.Drawing.Point(14, 157)
        PESSIContLabel.Name = "PESSIContLabel"
        PESSIContLabel.Size = New System.Drawing.Size(102, 20)
        PESSIContLabel.TabIndex = 49
        PESSIContLabel.Text = "PESSI Cont:"
        PESSIContLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EffectedFromDateLabel
        '
        EffectedFromDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EffectedFromDateLabel.Location = New System.Drawing.Point(13, 123)
        EffectedFromDateLabel.Name = "EffectedFromDateLabel"
        EffectedFromDateLabel.Size = New System.Drawing.Size(93, 20)
        EffectedFromDateLabel.TabIndex = 51
        EffectedFromDateLabel.Text = "Effective Date:"
        EffectedFromDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActivationDateLabel
        '
        ActivationDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActivationDateLabel.Location = New System.Drawing.Point(13, 176)
        ActivationDateLabel.Name = "ActivationDateLabel"
        ActivationDateLabel.Size = New System.Drawing.Size(93, 20)
        ActivationDateLabel.TabIndex = 53
        ActivationDateLabel.Text = "Activation Date:"
        ActivationDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ActivationStatusLabel
        '
        ActivationStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActivationStatusLabel.Location = New System.Drawing.Point(13, 148)
        ActivationStatusLabel.Name = "ActivationStatusLabel"
        ActivationStatusLabel.Size = New System.Drawing.Size(93, 20)
        ActivationStatusLabel.TabIndex = 54
        ActivationStatusLabel.Text = "Activation Status:"
        ActivationStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'RefrenceLabel
        '
        RefrenceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RefrenceLabel.ForeColor = System.Drawing.Color.Black
        RefrenceLabel.Location = New System.Drawing.Point(6, 168)
        RefrenceLabel.Name = "RefrenceLabel"
        RefrenceLabel.Size = New System.Drawing.Size(101, 20)
        RefrenceLabel.TabIndex = 22222
        RefrenceLabel.Text = "Reference:"
        '
        'DateOfJoningLabel
        '
        DateOfJoningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfJoningLabel.ForeColor = System.Drawing.Color.Black
        DateOfJoningLabel.Location = New System.Drawing.Point(4, 15)
        DateOfJoningLabel.Name = "DateOfJoningLabel"
        DateOfJoningLabel.Size = New System.Drawing.Size(98, 20)
        DateOfJoningLabel.TabIndex = 100000
        DateOfJoningLabel.Text = "Date Of Joining:"
        DateOfJoningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateOfPermanentLabel
        '
        DateOfPermanentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfPermanentLabel.ForeColor = System.Drawing.Color.Black
        DateOfPermanentLabel.Location = New System.Drawing.Point(4, 39)
        DateOfPermanentLabel.Name = "DateOfPermanentLabel"
        DateOfPermanentLabel.Size = New System.Drawing.Size(101, 20)
        DateOfPermanentLabel.TabIndex = 100001
        DateOfPermanentLabel.Text = "Date Of Permanent:"
        DateOfPermanentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GraduityDateLabel
        '
        GraduityDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GraduityDateLabel.ForeColor = System.Drawing.Color.Black
        GraduityDateLabel.Location = New System.Drawing.Point(4, 65)
        GraduityDateLabel.Name = "GraduityDateLabel"
        GraduityDateLabel.Size = New System.Drawing.Size(91, 20)
        GraduityDateLabel.TabIndex = 100002
        GraduityDateLabel.Text = "Graduity Date:"
        GraduityDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CardStatusLabel
        '
        CardStatusLabel.AutoSize = True
        CardStatusLabel.Location = New System.Drawing.Point(230, 37)
        CardStatusLabel.Name = "CardStatusLabel"
        CardStatusLabel.Size = New System.Drawing.Size(65, 13)
        CardStatusLabel.TabIndex = 4
        CardStatusLabel.Text = "Card Status:"
        '
        'NoticeTypeLabel
        '
        NoticeTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoticeTypeLabel.ForeColor = System.Drawing.Color.Black
        NoticeTypeLabel.Location = New System.Drawing.Point(6, 44)
        NoticeTypeLabel.Name = "NoticeTypeLabel"
        NoticeTypeLabel.Size = New System.Drawing.Size(90, 20)
        NoticeTypeLabel.TabIndex = 21212
        NoticeTypeLabel.Text = "Notice Type:"
        NoticeTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmergencyContactNoLabel
        '
        EmergencyContactNoLabel.Location = New System.Drawing.Point(366, 79)
        EmergencyContactNoLabel.Name = "EmergencyContactNoLabel"
        EmergencyContactNoLabel.Size = New System.Drawing.Size(123, 20)
        EmergencyContactNoLabel.TabIndex = 68
        EmergencyContactNoLabel.Text = "Emergency Contact No.:"
        EmergencyContactNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CurrentAddressLabel
        '
        CurrentAddressLabel.Location = New System.Drawing.Point(366, 241)
        CurrentAddressLabel.Name = "CurrentAddressLabel"
        CurrentAddressLabel.Size = New System.Drawing.Size(116, 67)
        CurrentAddressLabel.TabIndex = 69
        CurrentAddressLabel.Text = "Present Address:"
        '
        'CopyNoLabel
        '
        CopyNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CopyNoLabel.ForeColor = System.Drawing.Color.Black
        CopyNoLabel.Location = New System.Drawing.Point(9, 17)
        CopyNoLabel.Name = "CopyNoLabel"
        CopyNoLabel.Size = New System.Drawing.Size(87, 20)
        CopyNoLabel.TabIndex = 4542232
        CopyNoLabel.Text = "Copy No:"
        CopyNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StartDateLabel
        '
        StartDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StartDateLabel.ForeColor = System.Drawing.Color.Black
        StartDateLabel.Location = New System.Drawing.Point(9, 43)
        StartDateLabel.Name = "StartDateLabel"
        StartDateLabel.Size = New System.Drawing.Size(90, 20)
        StartDateLabel.TabIndex = 2232323
        StartDateLabel.Text = "Start Date:"
        StartDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EndDateLabel
        '
        EndDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EndDateLabel.ForeColor = System.Drawing.Color.Black
        EndDateLabel.Location = New System.Drawing.Point(9, 70)
        EndDateLabel.Name = "EndDateLabel"
        EndDateLabel.Size = New System.Drawing.Size(88, 20)
        EndDateLabel.TabIndex = 232434
        EndDateLabel.Text = "End Date:"
        EndDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ConteenDeductLabel
        '
        ConteenDeductLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ConteenDeductLabel.Location = New System.Drawing.Point(14, 105)
        ConteenDeductLabel.Name = "ConteenDeductLabel"
        ConteenDeductLabel.Size = New System.Drawing.Size(102, 20)
        ConteenDeductLabel.TabIndex = 49
        ConteenDeductLabel.Text = "Canteen Deduction:"
        ConteenDeductLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HiringCriteriaLabel
        '
        HiringCriteriaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HiringCriteriaLabel.ForeColor = System.Drawing.Color.Black
        HiringCriteriaLabel.Location = New System.Drawing.Point(4, 89)
        HiringCriteriaLabel.Name = "HiringCriteriaLabel"
        HiringCriteriaLabel.Size = New System.Drawing.Size(92, 20)
        HiringCriteriaLabel.TabIndex = 100003
        HiringCriteriaLabel.Text = "Hiring Criteria:"
        HiringCriteriaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HiringDescLabel
        '
        HiringDescLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HiringDescLabel.ForeColor = System.Drawing.Color.Black
        HiringDescLabel.Location = New System.Drawing.Point(4, 116)
        HiringDescLabel.Name = "HiringDescLabel"
        HiringDescLabel.Size = New System.Drawing.Size(93, 30)
        HiringDescLabel.TabIndex = 111111115
        HiringDescLabel.Text = "Description:"
        '
        'IncrementStatusLabel
        '
        IncrementStatusLabel.AutoSize = True
        IncrementStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IncrementStatusLabel.Location = New System.Drawing.Point(13, 76)
        IncrementStatusLabel.Name = "IncrementStatusLabel"
        IncrementStatusLabel.Size = New System.Drawing.Size(90, 13)
        IncrementStatusLabel.TabIndex = 56
        IncrementStatusLabel.Text = "Increment Status:"
        '
        'AccommodationLabel
        '
        AccommodationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccommodationLabel.Location = New System.Drawing.Point(12, 174)
        AccommodationLabel.Name = "AccommodationLabel"
        AccommodationLabel.Size = New System.Drawing.Size(110, 20)
        AccommodationLabel.TabIndex = 42
        AccommodationLabel.Text = "Accod. Allowance:"
        AccommodationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AppIDLabel
        '
        AppIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AppIDLabel.Location = New System.Drawing.Point(13, 98)
        AppIDLabel.Name = "AppIDLabel"
        AppIDLabel.Size = New System.Drawing.Size(103, 20)
        AppIDLabel.TabIndex = 57
        AppIDLabel.Text = "Approving Authority:"
        AppIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NetGrossSalaryLabel
        '
        NetGrossSalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NetGrossSalaryLabel.Location = New System.Drawing.Point(12, 199)
        NetGrossSalaryLabel.Name = "NetGrossSalaryLabel"
        NetGrossSalaryLabel.Size = New System.Drawing.Size(107, 20)
        NetGrossSalaryLabel.TabIndex = 56
        NetGrossSalaryLabel.Text = "Gross Salary:"
        NetGrossSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HODNameLabel
        '
        HODNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HODNameLabel.Location = New System.Drawing.Point(6, 88)
        HODNameLabel.Name = "HODNameLabel"
        HODNameLabel.Size = New System.Drawing.Size(101, 20)
        HODNameLabel.TabIndex = 1212121
        HODNameLabel.Text = "Report To(1):"
        HODNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.Black
        Label10.Location = New System.Drawing.Point(9, 43)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(89, 20)
        Label10.TabIndex = 23234547
        Label10.Text = "Leave Desc.:"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label11.ForeColor = System.Drawing.Color.Black
        Label11.Location = New System.Drawing.Point(9, 96)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(88, 20)
        Label11.TabIndex = 4542234
        Label11.Text = "Duplicate Date:"
        Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label12.ForeColor = System.Drawing.Color.Black
        Label12.Location = New System.Drawing.Point(7, 19)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(47, 20)
        Label12.TabIndex = 111111115
        Label12.Text = "Reason:"
        '
        'Label15
        '
        Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.Color.Black
        Label15.Location = New System.Drawing.Point(381, 335)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(93, 20)
        Label15.TabIndex = 100001
        Label15.Text = "End Date:"
        Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label15.Visible = False
        '
        'Label16
        '
        Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.ForeColor = System.Drawing.Color.Black
        Label16.Location = New System.Drawing.Point(381, 311)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(93, 20)
        Label16.TabIndex = 100000
        Label16.Text = "Start Date:"
        Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Label16.Visible = False
        '
        'Label13
        '
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(7, 80)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(47, 20)
        Label13.TabIndex = 111111117
        Label13.Text = "Status:"
        Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label20.Location = New System.Drawing.Point(13, 28)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(103, 20)
        Label20.TabIndex = 51
        Label20.Text = "Bonuses:"
        Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.Location = New System.Drawing.Point(122, 8)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(25, 20)
        Label21.TabIndex = 53
        Label21.Text = "1"
        Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(13, 50)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(103, 20)
        Label22.TabIndex = 55
        Label22.Text = "Graduity:"
        Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label23.Location = New System.Drawing.Point(13, 69)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(103, 20)
        Label23.TabIndex = 57
        Label23.Text = "Annual 14 Leaves:"
        Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label24.Location = New System.Drawing.Point(13, 89)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(103, 20)
        Label24.TabIndex = 59
        Label24.Text = "Casual 10 Leaves:"
        Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label25.Location = New System.Drawing.Point(13, 109)
        Label25.Name = "Label25"
        Label25.Size = New System.Drawing.Size(103, 20)
        Label25.TabIndex = 61
        Label25.Text = "Medical 8 Leaves:"
        Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label26.Location = New System.Drawing.Point(199, 8)
        Label26.Name = "Label26"
        Label26.Size = New System.Drawing.Size(25, 20)
        Label26.TabIndex = 62
        Label26.Text = "2"
        Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label27.Location = New System.Drawing.Point(13, 129)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(103, 20)
        Label27.TabIndex = 64
        Label27.Text = "Dinner Allowance:"
        Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label28.Location = New System.Drawing.Point(13, 153)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(103, 20)
        Label28.TabIndex = 66
        Label28.Text = "Transport Facility:"
        Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.Location = New System.Drawing.Point(13, 178)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(103, 20)
        Label29.TabIndex = 68
        Label29.Text = "Bus Route:"
        Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.Location = New System.Drawing.Point(12, 123)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(110, 20)
        Label30.TabIndex = 61
        Label30.Text = "Per Day Travel:"
        Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Label14.Location = New System.Drawing.Point(6, 103)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(119, 20)
        Label14.TabIndex = 77
        Label14.Text = "Husband Name:"
        Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label17.Location = New System.Drawing.Point(6, 64)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(101, 20)
        Label17.TabIndex = 1212124
        Label17.Text = "Employee Type:"
        '
        'Label19
        '
        Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label19.Location = New System.Drawing.Point(6, 113)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(101, 20)
        Label19.TabIndex = 1212126
        Label19.Text = "Report To(2):"
        Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1293, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Management "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.Tbl_HRM_CardBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(81, 32)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CardNoComboBox.TabIndex = 31111
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BindingNavigator4)
        Me.Panel1.Controls.Add(Me.LinkLabel13)
        Me.Panel1.Controls.Add(CardStatusLabel)
        Me.Panel1.Controls.Add(Me.CardStatusCheckBox)
        Me.Panel1.Controls.Add(Me.CardNoComboBox)
        Me.Panel1.Controls.Add(CardNoLabel)
        Me.Panel1.Location = New System.Drawing.Point(142, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 61)
        Me.Panel1.TabIndex = 4
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Nothing
        Me.BindingNavigator4.BindingSource = Me.Tbl_HRM_CardBindingSource
        Me.BindingNavigator4.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator4.DeleteItem = Nothing
        Me.BindingNavigator4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5})
        Me.BindingNavigator4.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator4.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator4.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator4.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator4.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator4.Size = New System.Drawing.Size(341, 27)
        Me.BindingNavigator4.TabIndex = 31112
        Me.BindingNavigator4.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 24)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'LinkLabel13
        '
        Me.LinkLabel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel13.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel13.Location = New System.Drawing.Point(204, 36)
        Me.LinkLabel13.Name = "LinkLabel13"
        Me.LinkLabel13.Size = New System.Drawing.Size(15, 11)
        Me.LinkLabel13.TabIndex = 67
        Me.LinkLabel13.TabStop = True
        Me.LinkLabel13.Text = "^"
        Me.LinkLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel13, "Click For New Card")
        '
        'CardStatusCheckBox
        '
        Me.CardStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_CardBindingSource, "CardStatus", True))
        Me.CardStatusCheckBox.Enabled = False
        Me.CardStatusCheckBox.Location = New System.Drawing.Point(301, 32)
        Me.CardStatusCheckBox.Name = "CardStatusCheckBox"
        Me.CardStatusCheckBox.Size = New System.Drawing.Size(19, 24)
        Me.CardStatusCheckBox.TabIndex = 5
        Me.CardStatusCheckBox.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(3, 1)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1008, 530)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage1.Controls.Add(Me.Button12)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.LinkLabel19)
        Me.TabPage1.Controls.Add(Me.DescriptionComboBox)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Label14)
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.DateOfBirthMaskedTextBox)
        Me.TabPage1.Controls.Add(Me.DateTimePicker14)
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(CurrentAddressLabel)
        Me.TabPage1.Controls.Add(Me.CurrentAddressTextBox)
        Me.TabPage1.Controls.Add(EmergencyContactNoLabel)
        Me.TabPage1.Controls.Add(Me.EmergencyNoMaskedTextBox)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.LinkLabel15)
        Me.TabPage1.Controls.Add(EmpProvinceLabel)
        Me.TabPage1.Controls.Add(Me.EmpProvinceComboBox)
        Me.TabPage1.Controls.Add(QualficationNameLabel)
        Me.TabPage1.Controls.Add(Me.QualficationNameComboBox)
        Me.TabPage1.Controls.Add(Me.Uploadimage)
        Me.TabPage1.Controls.Add(Me.EmpPicPictureBox)
        Me.TabPage1.Controls.Add(PermanentAddressLabel)
        Me.TabPage1.Controls.Add(Me.PermanentAddressTextBox)
        Me.TabPage1.Controls.Add(Me.EmpCityTextBox)
        Me.TabPage1.Controls.Add(Me.MotherNameTextBox)
        Me.TabPage1.Controls.Add(Me.FatherNameTextBox)
        Me.TabPage1.Controls.Add(Me.NameTextBox)
        Me.TabPage1.Controls.Add(EmpCityLabel)
        Me.TabPage1.Controls.Add(ContactNoLabel)
        Me.TabPage1.Controls.Add(Me.ContactNoMaskedTextBox)
        Me.TabPage1.Controls.Add(DateOfBirthLabel)
        Me.TabPage1.Controls.Add(MaritalStatusLabel)
        Me.TabPage1.Controls.Add(Me.MaritalStatusComboBox)
        Me.TabPage1.Controls.Add(BloodGroupLabel)
        Me.TabPage1.Controls.Add(Me.BloodGroupComboBox)
        Me.TabPage1.Controls.Add(CNICNOLabel)
        Me.TabPage1.Controls.Add(Me.CNICNOMaskedTextBox)
        Me.TabPage1.Controls.Add(ReligionLabel)
        Me.TabPage1.Controls.Add(Me.ReligionComboBox)
        Me.TabPage1.Controls.Add(GenderLabel)
        Me.TabPage1.Controls.Add(Me.GenderComboBox)
        Me.TabPage1.Controls.Add(MotherNameLabel)
        Me.TabPage1.Controls.Add(FatherNameLabel)
        Me.TabPage1.Controls.Add(NameLabel)
        Me.TabPage1.Controls.Add(SalutationLabel)
        Me.TabPage1.Controls.Add(Me.SalutationComboBox)
        Me.TabPage1.ImageKey = "(none)"
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(981, 522)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "     Personal Data"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.Color.Black
        Me.Button12.Location = New System.Drawing.Point(601, 352)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(166, 33)
        Me.Button12.TabIndex = 81
        Me.Button12.Text = "Save As Employee"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 363)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 22)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "Description:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LinkLabel19
        '
        Me.LinkLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel19.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel19.Location = New System.Drawing.Point(346, 370)
        Me.LinkLabel19.Name = "LinkLabel19"
        Me.LinkLabel19.Size = New System.Drawing.Size(15, 11)
        Me.LinkLabel19.TabIndex = 79
        Me.LinkLabel19.TabStop = True
        Me.LinkLabel19.Text = "^"
        Me.LinkLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel19, "Click For Add New Qualfication Record")
        '
        'DescriptionComboBox
        '
        Me.DescriptionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DescriptionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DescriptionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "DisabilityID", True))
        Me.DescriptionComboBox.DataSource = Me.Tbl_disability_descptionBindingSource
        Me.DescriptionComboBox.DisplayMember = "Description"
        Me.DescriptionComboBox.Enabled = False
        Me.DescriptionComboBox.FormattingEnabled = True
        Me.DescriptionComboBox.Location = New System.Drawing.Point(125, 365)
        Me.DescriptionComboBox.Name = "DescriptionComboBox"
        Me.DescriptionComboBox.Size = New System.Drawing.Size(220, 21)
        Me.DescriptionComboBox.TabIndex = 78
        Me.DescriptionComboBox.ValueMember = "TID"
        '
        'Tbl_HRM_Emp_InfoBindingSource
        '
        Me.Tbl_HRM_Emp_InfoBindingSource.DataMember = "tbl_HRM_Card_tbl_HRM_Emp_Info"
        Me.Tbl_HRM_Emp_InfoBindingSource.DataSource = Me.Tbl_HRM_CardBindingSource
        '
        'Tbl_disability_descptionBindingSource
        '
        Me.Tbl_disability_descptionBindingSource.DataMember = "tbl_disability_descption"
        Me.Tbl_disability_descptionBindingSource.DataSource = Me.DSHRM
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "HusbandName", True))
        Me.TextBox3.Location = New System.Drawing.Point(125, 103)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(220, 20)
        Me.TextBox3.TabIndex = 6
        '
        'CheckBox2
        '
        Me.CheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "DisableStatus", True))
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Black
        Me.CheckBox2.Location = New System.Drawing.Point(6, 339)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(135, 20)
        Me.CheckBox2.TabIndex = 75
        Me.CheckBox2.Text = "Disabled (YES/NO):"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Snow
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Maroon
        Me.Button4.Location = New System.Drawing.Point(773, 113)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 27)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "Clear Image "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(773, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 28)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Image Save As "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateOfBirthMaskedTextBox
        '
        Me.DateOfBirthMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "DateOfBirth", True))
        Me.DateOfBirthMaskedTextBox.Location = New System.Drawing.Point(125, 315)
        Me.DateOfBirthMaskedTextBox.Mask = "00-00-0000"
        Me.DateOfBirthMaskedTextBox.Name = "DateOfBirthMaskedTextBox"
        Me.DateOfBirthMaskedTextBox.Size = New System.Drawing.Size(207, 20)
        Me.DateOfBirthMaskedTextBox.TabIndex = 13
        '
        'DateTimePicker14
        '
        Me.DateTimePicker14.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker14.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker14.Location = New System.Drawing.Point(330, 315)
        Me.DateTimePicker14.Name = "DateTimePicker14"
        Me.DateTimePicker14.Size = New System.Drawing.Size(15, 20)
        Me.DateTimePicker14.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.DateTimePicker14, "Click For Add Data of Birth")
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(489, 317)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(115, 30)
        Me.Button5.TabIndex = 71
        Me.Button5.Text = "&Refresh"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'CurrentAddressTextBox
        '
        Me.CurrentAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "CurrentAddress", True))
        Me.CurrentAddressTextBox.Location = New System.Drawing.Point(489, 240)
        Me.CurrentAddressTextBox.Multiline = True
        Me.CurrentAddressTextBox.Name = "CurrentAddressTextBox"
        Me.CurrentAddressTextBox.Size = New System.Drawing.Size(278, 71)
        Me.CurrentAddressTextBox.TabIndex = 19
        '
        'EmergencyNoMaskedTextBox
        '
        Me.EmergencyNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EmergencyContactNo", True))
        Me.EmergencyNoMaskedTextBox.Location = New System.Drawing.Point(489, 79)
        Me.EmergencyNoMaskedTextBox.Mask = "0000-0000000"
        Me.EmergencyNoMaskedTextBox.Name = "EmergencyNoMaskedTextBox"
        Me.EmergencyNoMaskedTextBox.Size = New System.Drawing.Size(153, 20)
        Me.EmergencyNoMaskedTextBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(773, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 37)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Image Size Should be 40 Kb or less"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(652, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 30)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "&Save Data "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'LinkLabel15
        '
        Me.LinkLabel15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel15.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel15.Location = New System.Drawing.Point(347, 237)
        Me.LinkLabel15.Name = "LinkLabel15"
        Me.LinkLabel15.Size = New System.Drawing.Size(15, 11)
        Me.LinkLabel15.TabIndex = 66
        Me.LinkLabel15.TabStop = True
        Me.LinkLabel15.Text = "^"
        Me.LinkLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel15, "Click For Add New Qualfication Record")
        '
        'EmpProvinceComboBox
        '
        Me.EmpProvinceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.EmpProvinceComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmpProvinceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EmpProvince", True))
        Me.EmpProvinceComboBox.FormattingEnabled = True
        Me.EmpProvinceComboBox.Items.AddRange(New Object() {"Azad Kashmir" & Global.Microsoft.VisualBasic.ChrW(9), "Balochistan", "Punjab", "Sindh", "KPK", "NWFP"})
        Me.EmpProvinceComboBox.Location = New System.Drawing.Point(489, 130)
        Me.EmpProvinceComboBox.Name = "EmpProvinceComboBox"
        Me.EmpProvinceComboBox.Size = New System.Drawing.Size(153, 21)
        Me.EmpProvinceComboBox.TabIndex = 17
        '
        'QualficationNameComboBox
        '
        Me.QualficationNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.QualficationNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.QualficationNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "QualficationID", True))
        Me.QualficationNameComboBox.DataSource = Me.Tbl_HRM_QualficationBindingSource
        Me.QualficationNameComboBox.DisplayMember = "QualficationName"
        Me.QualficationNameComboBox.FormattingEnabled = True
        Me.QualficationNameComboBox.Location = New System.Drawing.Point(125, 234)
        Me.QualficationNameComboBox.Name = "QualficationNameComboBox"
        Me.QualficationNameComboBox.Size = New System.Drawing.Size(220, 21)
        Me.QualficationNameComboBox.TabIndex = 10
        Me.QualficationNameComboBox.ValueMember = "QualficationID"
        '
        'Tbl_HRM_QualficationBindingSource
        '
        Me.Tbl_HRM_QualficationBindingSource.DataMember = "tbl_HRM_Qualfication"
        Me.Tbl_HRM_QualficationBindingSource.DataSource = Me.DSHRM
        '
        'Uploadimage
        '
        Me.Uploadimage.BackColor = System.Drawing.Color.White
        Me.Uploadimage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uploadimage.ForeColor = System.Drawing.Color.Black
        Me.Uploadimage.Location = New System.Drawing.Point(648, 131)
        Me.Uploadimage.Name = "Uploadimage"
        Me.Uploadimage.Size = New System.Drawing.Size(119, 23)
        Me.Uploadimage.TabIndex = 20
        Me.Uploadimage.Text = "Upload Image "
        Me.Uploadimage.UseVisualStyleBackColor = False
        '
        'EmpPicPictureBox
        '
        Me.EmpPicPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPicPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_HRM_Emp_InfoBindingSource, "EmpPic", True))
        Me.EmpPicPictureBox.Location = New System.Drawing.Point(648, 7)
        Me.EmpPicPictureBox.Name = "EmpPicPictureBox"
        Me.EmpPicPictureBox.Size = New System.Drawing.Size(119, 120)
        Me.EmpPicPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPicPictureBox.TabIndex = 59
        Me.EmpPicPictureBox.TabStop = False
        '
        'PermanentAddressTextBox
        '
        Me.PermanentAddressTextBox.BackColor = System.Drawing.Color.White
        Me.PermanentAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "PermanentAddress", True))
        Me.PermanentAddressTextBox.Location = New System.Drawing.Point(489, 157)
        Me.PermanentAddressTextBox.Multiline = True
        Me.PermanentAddressTextBox.Name = "PermanentAddressTextBox"
        Me.PermanentAddressTextBox.Size = New System.Drawing.Size(278, 77)
        Me.PermanentAddressTextBox.TabIndex = 18
        '
        'EmpCityTextBox
        '
        Me.EmpCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EmpCity", True))
        Me.EmpCityTextBox.Location = New System.Drawing.Point(489, 103)
        Me.EmpCityTextBox.Name = "EmpCityTextBox"
        Me.EmpCityTextBox.Size = New System.Drawing.Size(153, 20)
        Me.EmpCityTextBox.TabIndex = 16
        '
        'MotherNameTextBox
        '
        Me.MotherNameTextBox.BackColor = System.Drawing.Color.White
        Me.MotherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "MotherName", True))
        Me.MotherNameTextBox.Location = New System.Drawing.Point(125, 128)
        Me.MotherNameTextBox.Name = "MotherNameTextBox"
        Me.MotherNameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.MotherNameTextBox.TabIndex = 6
        '
        'FatherNameTextBox
        '
        Me.FatherNameTextBox.BackColor = System.Drawing.Color.White
        Me.FatherNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "FatherName", True))
        Me.FatherNameTextBox.Location = New System.Drawing.Point(125, 79)
        Me.FatherNameTextBox.Name = "FatherNameTextBox"
        Me.FatherNameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.FatherNameTextBox.TabIndex = 5
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.NameTextBox.ContextMenuStrip = Me.CMSEmpInfo
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(125, 54)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'CMSEmpInfo
        '
        Me.CMSEmpInfo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMSEmpInfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchByNameToolStripMenuItem, Me.RemoveFilterToolStripMenuItem1})
        Me.CMSEmpInfo.Name = "ContextMenuStrip1"
        Me.CMSEmpInfo.Size = New System.Drawing.Size(161, 48)
        '
        'SearchByNameToolStripMenuItem
        '
        Me.SearchByNameToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SearchByNameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSName})
        Me.SearchByNameToolStripMenuItem.Name = "SearchByNameToolStripMenuItem"
        Me.SearchByNameToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.SearchByNameToolStripMenuItem.Text = "Search By Name"
        '
        'txtSName
        '
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(100, 23)
        '
        'RemoveFilterToolStripMenuItem1
        '
        Me.RemoveFilterToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RemoveFilterToolStripMenuItem1.Name = "RemoveFilterToolStripMenuItem1"
        Me.RemoveFilterToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.RemoveFilterToolStripMenuItem1.Text = "Remove Filter"
        '
        'ContactNoMaskedTextBox
        '
        Me.ContactNoMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "ContactNo", True))
        Me.ContactNoMaskedTextBox.Location = New System.Drawing.Point(489, 52)
        Me.ContactNoMaskedTextBox.Mask = "0000-0000000"
        Me.ContactNoMaskedTextBox.Name = "ContactNoMaskedTextBox"
        Me.ContactNoMaskedTextBox.Size = New System.Drawing.Size(153, 20)
        Me.ContactNoMaskedTextBox.TabIndex = 14
        '
        'MaritalStatusComboBox
        '
        Me.MaritalStatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.MaritalStatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MaritalStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "MaritalStatus", True))
        Me.MaritalStatusComboBox.FormattingEnabled = True
        Me.MaritalStatusComboBox.Items.AddRange(New Object() {"Single", "Married", "Widow", "Divorced"})
        Me.MaritalStatusComboBox.Location = New System.Drawing.Point(125, 288)
        Me.MaritalStatusComboBox.Name = "MaritalStatusComboBox"
        Me.MaritalStatusComboBox.Size = New System.Drawing.Size(220, 21)
        Me.MaritalStatusComboBox.TabIndex = 12
        '
        'BloodGroupComboBox
        '
        Me.BloodGroupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BloodGroupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BloodGroupComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "BloodGroup", True))
        Me.BloodGroupComboBox.FormattingEnabled = True
        Me.BloodGroupComboBox.Items.AddRange(New Object() {"A+", "A-", "AB+", "AB-", "B+", "B-", "O+", "O-", "Not Set"})
        Me.BloodGroupComboBox.Location = New System.Drawing.Point(125, 261)
        Me.BloodGroupComboBox.Name = "BloodGroupComboBox"
        Me.BloodGroupComboBox.Size = New System.Drawing.Size(220, 21)
        Me.BloodGroupComboBox.TabIndex = 11
        '
        'CNICNOMaskedTextBox
        '
        Me.CNICNOMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.CNICNOMaskedTextBox.ContextMenuStrip = Me.CMSSearchNIC
        Me.CNICNOMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "CNICNO", True))
        Me.CNICNOMaskedTextBox.Location = New System.Drawing.Point(125, 208)
        Me.CNICNOMaskedTextBox.Mask = "00000-0000000-0"
        Me.CNICNOMaskedTextBox.Name = "CNICNOMaskedTextBox"
        Me.CNICNOMaskedTextBox.Size = New System.Drawing.Size(220, 20)
        Me.CNICNOMaskedTextBox.TabIndex = 9
        '
        'CMSSearchNIC
        '
        Me.CMSSearchNIC.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMSSearchNIC.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.CMSSearchNIC.Name = "ContextMenuStrip1"
        Me.CMSSearchNIC.Size = New System.Drawing.Size(171, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtSearchNIC})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem1.Text = "Search By NIC No."
        '
        'txtSearchNIC
        '
        Me.txtSearchNIC.Name = "txtSearchNIC"
        Me.txtSearchNIC.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem2.Text = "Remove Filter"
        '
        'ReligionComboBox
        '
        Me.ReligionComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ReligionComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ReligionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "Religion", True))
        Me.ReligionComboBox.FormattingEnabled = True
        Me.ReligionComboBox.Items.AddRange(New Object() {"Islam", "Christianity", "Hinduism", "Sikhism", "Other"})
        Me.ReligionComboBox.Location = New System.Drawing.Point(125, 181)
        Me.ReligionComboBox.Name = "ReligionComboBox"
        Me.ReligionComboBox.Size = New System.Drawing.Size(220, 21)
        Me.ReligionComboBox.TabIndex = 8
        '
        'GenderComboBox
        '
        Me.GenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.GenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GenderComboBox.BackColor = System.Drawing.Color.White
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(125, 154)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(220, 21)
        Me.GenderComboBox.TabIndex = 7
        '
        'SalutationComboBox
        '
        Me.SalutationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "Salutation", True))
        Me.SalutationComboBox.FormattingEnabled = True
        Me.SalutationComboBox.Items.AddRange(New Object() {"Mr.", "Mrs.", "Ms."})
        Me.SalutationComboBox.Location = New System.Drawing.Point(125, 27)
        Me.SalutationComboBox.Name = "SalutationComboBox"
        Me.SalutationComboBox.Size = New System.Drawing.Size(102, 21)
        Me.SalutationComboBox.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage5.Controls.Add(Me.GroupBox14)
        Me.TabPage5.Controls.Add(Me.GroupBox10)
        Me.TabPage5.Controls.Add(Me.Button6)
        Me.TabPage5.Controls.Add(Me.GroupBox7)
        Me.TabPage5.Controls.Add(Me.Save)
        Me.TabPage5.Controls.Add(Me.GroupBox5)
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Controls.Add(Me.GroupBox3)
        Me.TabPage5.Controls.Add(Me.GroupBox9)
        Me.TabPage5.Controls.Add(Me.GroupBox8)
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Controls.Add(Me.GroupBox2)
        Me.TabPage5.Controls.Add(Me.GroupBox1)
        Me.TabPage5.Location = New System.Drawing.Point(23, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(981, 522)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Official Data"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.DateTimePicker15)
        Me.GroupBox14.Controls.Add(Me.Panel5)
        Me.GroupBox14.Controls.Add(Label11)
        Me.GroupBox14.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox14.Controls.Add(Me.AddCopyBtn)
        Me.GroupBox14.Controls.Add(Me.DateTimePicker9)
        Me.GroupBox14.Controls.Add(Me.DateTimePicker8)
        Me.GroupBox14.Controls.Add(Me.printbtn)
        Me.GroupBox14.Controls.Add(Me.backbtn)
        Me.GroupBox14.Controls.Add(Me.frntbtn)
        Me.GroupBox14.Controls.Add(EndDateLabel)
        Me.GroupBox14.Controls.Add(Me.EndDateMaskedTextBox)
        Me.GroupBox14.Controls.Add(StartDateLabel)
        Me.GroupBox14.Controls.Add(Me.StartDateMaskedTextBox)
        Me.GroupBox14.Controls.Add(CopyNoLabel)
        Me.GroupBox14.Controls.Add(Me.CopyNoTextBox)
        Me.GroupBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.ForeColor = System.Drawing.Color.Black
        Me.GroupBox14.Location = New System.Drawing.Point(645, 293)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(323, 167)
        Me.GroupBox14.TabIndex = 8
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Card Copy Info.:"
        '
        'DateTimePicker15
        '
        Me.DateTimePicker15.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker15.Enabled = False
        Me.DateTimePicker15.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker15.Location = New System.Drawing.Point(192, 96)
        Me.DateTimePicker15.Name = "DateTimePicker15"
        Me.DateTimePicker15.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker15.TabIndex = 4542236
        Me.ToolTip1.SetToolTip(Me.DateTimePicker15, "Click For Add End Date")
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.RadioButton4)
        Me.Panel5.Controls.Add(Me.RadioButton5)
        Me.Panel5.Location = New System.Drawing.Point(33, 122)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(171, 30)
        Me.Panel5.TabIndex = 4542235
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(86, 5)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton4.TabIndex = 4542236
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Duplicate"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(12, 5)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton5.TabIndex = 4542237
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Original"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.BackColor = System.Drawing.Color.LightBlue
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "CardDupDate", True))
        Me.MaskedTextBox2.Enabled = False
        Me.MaskedTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(103, 96)
        Me.MaskedTextBox2.Mask = "00-00-0000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBox2.TabIndex = 4542233
        '
        'AddCopyBtn
        '
        Me.AddCopyBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.AddCopyBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCopyBtn.ForeColor = System.Drawing.Color.Black
        Me.AddCopyBtn.Location = New System.Drawing.Point(209, 12)
        Me.AddCopyBtn.Name = "AddCopyBtn"
        Me.AddCopyBtn.Size = New System.Drawing.Size(100, 31)
        Me.AddCopyBtn.TabIndex = 30
        Me.AddCopyBtn.Text = "Add Card Copy"
        Me.AddCopyBtn.UseVisualStyleBackColor = False
        '
        'DateTimePicker9
        '
        Me.DateTimePicker9.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker9.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker9.Location = New System.Drawing.Point(190, 42)
        Me.DateTimePicker9.Name = "DateTimePicker9"
        Me.DateTimePicker9.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker9.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.DateTimePicker9, "Click For Add Start Date")
        '
        'DateTimePicker8
        '
        Me.DateTimePicker8.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker8.Location = New System.Drawing.Point(191, 71)
        Me.DateTimePicker8.Name = "DateTimePicker8"
        Me.DateTimePicker8.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker8.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.DateTimePicker8, "Click For Add End Date")
        '
        'printbtn
        '
        Me.printbtn.BackColor = System.Drawing.Color.White
        Me.printbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printbtn.ForeColor = System.Drawing.Color.Black
        Me.printbtn.Location = New System.Drawing.Point(211, 109)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(97, 27)
        Me.printbtn.TabIndex = 7
        Me.printbtn.Text = "Print"
        Me.printbtn.UseVisualStyleBackColor = False
        '
        'backbtn
        '
        Me.backbtn.AutoSize = True
        Me.backbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtn.ForeColor = System.Drawing.Color.Black
        Me.backbtn.Location = New System.Drawing.Point(229, 73)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(74, 17)
        Me.backbtn.TabIndex = 6
        Me.backbtn.TabStop = True
        Me.backbtn.Text = "Back Side"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'frntbtn
        '
        Me.frntbtn.AutoSize = True
        Me.frntbtn.Checked = True
        Me.frntbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frntbtn.ForeColor = System.Drawing.Color.Black
        Me.frntbtn.Location = New System.Drawing.Point(229, 52)
        Me.frntbtn.Name = "frntbtn"
        Me.frntbtn.Size = New System.Drawing.Size(73, 17)
        Me.frntbtn.TabIndex = 31
        Me.frntbtn.TabStop = True
        Me.frntbtn.Text = "Front Side"
        Me.frntbtn.UseVisualStyleBackColor = True
        '
        'EndDateMaskedTextBox
        '
        Me.EndDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.EndDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EndDate", True))
        Me.EndDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateMaskedTextBox.Location = New System.Drawing.Point(103, 70)
        Me.EndDateMaskedTextBox.Mask = "00-00-0000"
        Me.EndDateMaskedTextBox.Name = "EndDateMaskedTextBox"
        Me.EndDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndDateMaskedTextBox.TabIndex = 33
        '
        'StartDateMaskedTextBox
        '
        Me.StartDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.StartDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "StartDate", True))
        Me.StartDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateMaskedTextBox.Location = New System.Drawing.Point(103, 43)
        Me.StartDateMaskedTextBox.Mask = "00-00-0000"
        Me.StartDateMaskedTextBox.Name = "StartDateMaskedTextBox"
        Me.StartDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StartDateMaskedTextBox.TabIndex = 32
        '
        'CopyNoTextBox
        '
        Me.CopyNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "CopyNo", True))
        Me.CopyNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyNoTextBox.Location = New System.Drawing.Point(103, 19)
        Me.CopyNoTextBox.Name = "CopyNoTextBox"
        Me.CopyNoTextBox.ReadOnly = True
        Me.CopyNoTextBox.Size = New System.Drawing.Size(42, 20)
        Me.CopyNoTextBox.TabIndex = 31
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Label31)
        Me.GroupBox10.Controls.Add(HiringDescLabel)
        Me.GroupBox10.Controls.Add(Me.TextBox6)
        Me.GroupBox10.Controls.Add(Me.HiringDescTextBox)
        Me.GroupBox10.Controls.Add(HiringCriteriaLabel)
        Me.GroupBox10.Controls.Add(Me.DateTimePicker12)
        Me.GroupBox10.Controls.Add(Me.HiringCriteriaComboBox)
        Me.GroupBox10.Controls.Add(Me.DateTimePicker11)
        Me.GroupBox10.Controls.Add(Me.DateTimePicker10)
        Me.GroupBox10.Controls.Add(GraduityDateLabel)
        Me.GroupBox10.Controls.Add(Me.GraduityDateMaskedTextBox)
        Me.GroupBox10.Controls.Add(DateOfPermanentLabel)
        Me.GroupBox10.Controls.Add(Me.DateOfPermanentMaskedTextBox)
        Me.GroupBox10.Controls.Add(DateOfJoningLabel)
        Me.GroupBox10.Controls.Add(Me.DateOfJoning)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Black
        Me.GroupBox10.Location = New System.Drawing.Point(6, 10)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(310, 152)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Joining Info:"
        '
        'HiringDescTextBox
        '
        Me.HiringDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "HiringDesc", True))
        Me.HiringDescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HiringDescTextBox.Location = New System.Drawing.Point(106, 114)
        Me.HiringDescTextBox.Multiline = True
        Me.HiringDescTextBox.Name = "HiringDescTextBox"
        Me.HiringDescTextBox.Size = New System.Drawing.Size(182, 32)
        Me.HiringDescTextBox.TabIndex = 4
        '
        'DateTimePicker12
        '
        Me.DateTimePicker12.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker12.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker12.Location = New System.Drawing.Point(274, 65)
        Me.DateTimePicker12.Name = "DateTimePicker12"
        Me.DateTimePicker12.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker12.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DateTimePicker12, "Click For Add Graduity Date")
        '
        'HiringCriteriaComboBox
        '
        Me.HiringCriteriaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.HiringCriteriaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HiringCriteriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.Tbl_HRM_Emp_InfoBindingSource, "HiringCriteria", True))
        Me.HiringCriteriaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HiringCriteriaComboBox.FormattingEnabled = True
        Me.HiringCriteriaComboBox.Items.AddRange(New Object() {"New Hiring", "Replacement "})
        Me.HiringCriteriaComboBox.Location = New System.Drawing.Point(106, 89)
        Me.HiringCriteriaComboBox.Name = "HiringCriteriaComboBox"
        Me.HiringCriteriaComboBox.Size = New System.Drawing.Size(86, 21)
        Me.HiringCriteriaComboBox.TabIndex = 3
        '
        'DateTimePicker11
        '
        Me.DateTimePicker11.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker11.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker11.Location = New System.Drawing.Point(274, 39)
        Me.DateTimePicker11.Name = "DateTimePicker11"
        Me.DateTimePicker11.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker11.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DateTimePicker11, "Click For Add Date Of Permanent")
        '
        'DateTimePicker10
        '
        Me.DateTimePicker10.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker10.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker10.Location = New System.Drawing.Point(274, 14)
        Me.DateTimePicker10.Name = "DateTimePicker10"
        Me.DateTimePicker10.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker10.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DateTimePicker10, "Click For Add Date Of Joning")
        '
        'GraduityDateMaskedTextBox
        '
        Me.GraduityDateMaskedTextBox.BackColor = System.Drawing.Color.MintCream
        Me.GraduityDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "GraduityDate", True))
        Me.GraduityDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GraduityDateMaskedTextBox.Location = New System.Drawing.Point(106, 65)
        Me.GraduityDateMaskedTextBox.Mask = "00-00-0000"
        Me.GraduityDateMaskedTextBox.Name = "GraduityDateMaskedTextBox"
        Me.GraduityDateMaskedTextBox.Size = New System.Drawing.Size(182, 20)
        Me.GraduityDateMaskedTextBox.TabIndex = 2
        '
        'DateOfPermanentMaskedTextBox
        '
        Me.DateOfPermanentMaskedTextBox.BackColor = System.Drawing.Color.MintCream
        Me.DateOfPermanentMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "DateOfPermanent", True))
        Me.DateOfPermanentMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfPermanentMaskedTextBox.Location = New System.Drawing.Point(106, 39)
        Me.DateOfPermanentMaskedTextBox.Mask = "00-00-0000"
        Me.DateOfPermanentMaskedTextBox.Name = "DateOfPermanentMaskedTextBox"
        Me.DateOfPermanentMaskedTextBox.Size = New System.Drawing.Size(182, 20)
        Me.DateOfPermanentMaskedTextBox.TabIndex = 1
        '
        'DateOfJoning
        '
        Me.DateOfJoning.BackColor = System.Drawing.Color.MintCream
        Me.DateOfJoning.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "DateOfJoning", True))
        Me.DateOfJoning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfJoning.Location = New System.Drawing.Point(106, 15)
        Me.DateOfJoning.Mask = "00-00-0000"
        Me.DateOfJoning.Name = "DateOfJoning"
        Me.DateOfJoning.Size = New System.Drawing.Size(182, 20)
        Me.DateOfJoning.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(747, 487)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 32)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Label19)
        Me.GroupBox7.Controls.Add(Me.ComboBox5)
        Me.GroupBox7.Controls.Add(Label17)
        Me.GroupBox7.Controls.Add(Me.ComboBox4)
        Me.GroupBox7.Controls.Add(HODNameLabel)
        Me.GroupBox7.Controls.Add(RefrenceLabel)
        Me.GroupBox7.Controls.Add(Me.RefrenceTextBox)
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Controls.Add(Me.CatagoryNameComboBox)
        Me.GroupBox7.Controls.Add(CatagoryNameLabel)
        Me.GroupBox7.Controls.Add(EmploymentNameLabel)
        Me.GroupBox7.Controls.Add(Me.EmploymentNameComboBox)
        Me.GroupBox7.Controls.Add(Me.LinkLabel6)
        Me.GroupBox7.Controls.Add(Me.LinkLabel7)
        Me.GroupBox7.Controls.Add(Me.EmployeeExperianceTextBox)
        Me.GroupBox7.Controls.Add(EmployeeExperianceLabel)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(323, 79)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(310, 194)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Employment info:"
        '
        'ComboBox5
        '
        Me.ComboBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "ReportTo1", True))
        Me.ComboBox5.DataSource = Me.View_Emp_Report_TO_NEWBindingSource
        Me.ComboBox5.DisplayMember = "Name"
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(107, 112)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox5.TabIndex = 1212127
        Me.ComboBox5.ValueMember = "CardNo"
        '
        'View_Emp_Report_TO_NEWBindingSource
        '
        Me.View_Emp_Report_TO_NEWBindingSource.DataMember = "View_Emp_Report_TO_NEW"
        Me.View_Emp_Report_TO_NEWBindingSource.DataSource = Me.DSRPTTO
        '
        'DSRPTTO
        '
        Me.DSRPTTO.DataSetName = "DSRPTTO"
        Me.DSRPTTO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EmployeeType", True))
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Direct", "In-Direct"})
        Me.ComboBox4.Location = New System.Drawing.Point(107, 63)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox4.TabIndex = 1212125
        '
        'RefrenceTextBox
        '
        Me.RefrenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "Refrence", True))
        Me.RefrenceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefrenceTextBox.Location = New System.Drawing.Point(107, 164)
        Me.RefrenceTextBox.Multiline = True
        Me.RefrenceTextBox.Name = "RefrenceTextBox"
        Me.RefrenceTextBox.Size = New System.Drawing.Size(182, 27)
        Me.RefrenceTextBox.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "ReportTo", True))
        Me.ComboBox1.DataSource = Me.View_Emp_Report_TOBindingSource
        Me.ComboBox1.DisplayMember = "Name"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.ComboBox1.TabIndex = 1212123
        Me.ComboBox1.ValueMember = "CardNo"
        '
        'View_Emp_Report_TOBindingSource
        '
        Me.View_Emp_Report_TOBindingSource.DataMember = "View_Emp_Report_TO"
        Me.View_Emp_Report_TOBindingSource.DataSource = Me.DSReportTo
        '
        'DSReportTo
        '
        Me.DSReportTo.DataSetName = "DSReportTo"
        Me.DSReportTo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CatagoryNameComboBox
        '
        Me.CatagoryNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CatagoryNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CatagoryNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "EmpCatagoryID", True))
        Me.CatagoryNameComboBox.DataSource = Me.Tbl_HRM_EmpCatagoryBindingSource
        Me.CatagoryNameComboBox.DisplayMember = "CatagoryName"
        Me.CatagoryNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CatagoryNameComboBox.FormattingEnabled = True
        Me.CatagoryNameComboBox.Location = New System.Drawing.Point(107, 13)
        Me.CatagoryNameComboBox.Name = "CatagoryNameComboBox"
        Me.CatagoryNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.CatagoryNameComboBox.TabIndex = 18
        Me.CatagoryNameComboBox.ValueMember = "EmpCatagoryID"
        '
        'Tbl_HRM_EmpCatagoryBindingSource
        '
        Me.Tbl_HRM_EmpCatagoryBindingSource.DataMember = "tbl_HRM_EmpCatagory"
        Me.Tbl_HRM_EmpCatagoryBindingSource.DataSource = Me.DSHRM
        '
        'EmploymentNameComboBox
        '
        Me.EmploymentNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.EmploymentNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.EmploymentNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "EmploymentID", True))
        Me.EmploymentNameComboBox.DataSource = Me.Tbl_Hrm_EmploymentBindingSource
        Me.EmploymentNameComboBox.DisplayMember = "EmploymentName"
        Me.EmploymentNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmploymentNameComboBox.FormattingEnabled = True
        Me.EmploymentNameComboBox.Location = New System.Drawing.Point(107, 39)
        Me.EmploymentNameComboBox.Name = "EmploymentNameComboBox"
        Me.EmploymentNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.EmploymentNameComboBox.TabIndex = 19
        Me.EmploymentNameComboBox.ValueMember = "EmploymentID"
        '
        'Tbl_Hrm_EmploymentBindingSource
        '
        Me.Tbl_Hrm_EmploymentBindingSource.DataMember = "tbl_Hrm_Employment"
        Me.Tbl_Hrm_EmploymentBindingSource.DataSource = Me.DSHRM
        '
        'LinkLabel6
        '
        Me.LinkLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel6.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel6.Location = New System.Drawing.Point(291, 16)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(15, 18)
        Me.LinkLabel6.TabIndex = 30
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "^"
        Me.LinkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel6, "Click For Add New Catagory Record")
        '
        'LinkLabel7
        '
        Me.LinkLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel7.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel7.Location = New System.Drawing.Point(291, 41)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(15, 18)
        Me.LinkLabel7.TabIndex = 31
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "^"
        Me.LinkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel7, "Click For Add  New Employment Record")
        '
        'EmployeeExperianceTextBox
        '
        Me.EmployeeExperianceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EmployeeExperiance", True))
        Me.EmployeeExperianceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeExperianceTextBox.Location = New System.Drawing.Point(107, 139)
        Me.EmployeeExperianceTextBox.Multiline = True
        Me.EmployeeExperianceTextBox.Name = "EmployeeExperianceTextBox"
        Me.EmployeeExperianceTextBox.Size = New System.Drawing.Size(182, 22)
        Me.EmployeeExperianceTextBox.TabIndex = 21
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.Color.Black
        Me.Save.Location = New System.Drawing.Point(865, 487)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(112, 32)
        Me.Save.TabIndex = 9
        Me.Save.Text = "Save Data"
        Me.Save.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.SenStatusCheckBox)
        Me.GroupBox5.Controls.Add(Me.LinkLabel14)
        Me.GroupBox5.Controls.Add(BankNameLabel)
        Me.GroupBox5.Controls.Add(Me.BankNameComboBox)
        Me.GroupBox5.Controls.Add(BankAccountNOLabel)
        Me.GroupBox5.Controls.Add(Me.BankAccountNOTextBox)
        Me.GroupBox5.Controls.Add(EmailAddressLabel)
        Me.GroupBox5.Controls.Add(Me.EmailAddressTextBox)
        Me.GroupBox5.Controls.Add(EOBINOLabel)
        Me.GroupBox5.Controls.Add(Me.EOBINOTextBox)
        Me.GroupBox5.Controls.Add(NTNNOLabel)
        Me.GroupBox5.Controls.Add(Me.NTNNOTextBox)
        Me.GroupBox5.Controls.Add(SSCNOLabel)
        Me.GroupBox5.Controls.Add(Me.SSCNOTextBox)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(639, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(323, 173)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Special Services:"
        '
        'SenStatusCheckBox
        '
        Me.SenStatusCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SenStatusCheckBox.Checked = True
        Me.SenStatusCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SenStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "SenStatus", True))
        Me.SenStatusCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SenStatusCheckBox.Location = New System.Drawing.Point(6, 150)
        Me.SenStatusCheckBox.Name = "SenStatusCheckBox"
        Me.SenStatusCheckBox.Size = New System.Drawing.Size(155, 21)
        Me.SenStatusCheckBox.TabIndex = 39
        Me.SenStatusCheckBox.Text = "Seniority Allowance Status:"
        Me.SenStatusCheckBox.UseVisualStyleBackColor = True
        Me.SenStatusCheckBox.Visible = False
        '
        'LinkLabel14
        '
        Me.LinkLabel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel14.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel14.Location = New System.Drawing.Point(299, 132)
        Me.LinkLabel14.Name = "LinkLabel14"
        Me.LinkLabel14.Size = New System.Drawing.Size(15, 18)
        Me.LinkLabel14.TabIndex = 38
        Me.LinkLabel14.TabStop = True
        Me.LinkLabel14.Text = "^"
        Me.LinkLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel14, "Click For Add New Bank Record")
        '
        'BankNameComboBox
        '
        Me.BankNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BankNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BankNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "BankID", True))
        Me.BankNameComboBox.DataSource = Me.Tbl_HRM_BankBindingSource
        Me.BankNameComboBox.DisplayMember = "BankName"
        Me.BankNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankNameComboBox.FormattingEnabled = True
        Me.BankNameComboBox.Location = New System.Drawing.Point(101, 128)
        Me.BankNameComboBox.Name = "BankNameComboBox"
        Me.BankNameComboBox.Size = New System.Drawing.Size(195, 21)
        Me.BankNameComboBox.TabIndex = 29
        Me.BankNameComboBox.ValueMember = "BankID"
        '
        'Tbl_HRM_BankBindingSource
        '
        Me.Tbl_HRM_BankBindingSource.DataMember = "tbl_HRM_Bank"
        Me.Tbl_HRM_BankBindingSource.DataSource = Me.DSHRM
        '
        'BankAccountNOTextBox
        '
        Me.BankAccountNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "BankAccountNO", True))
        Me.BankAccountNOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankAccountNOTextBox.Location = New System.Drawing.Point(101, 106)
        Me.BankAccountNOTextBox.Name = "BankAccountNOTextBox"
        Me.BankAccountNOTextBox.Size = New System.Drawing.Size(195, 20)
        Me.BankAccountNOTextBox.TabIndex = 28
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(101, 83)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(195, 20)
        Me.EmailAddressTextBox.TabIndex = 27
        '
        'EOBINOTextBox
        '
        Me.EOBINOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EOBINO", True))
        Me.EOBINOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EOBINOTextBox.Location = New System.Drawing.Point(101, 37)
        Me.EOBINOTextBox.Name = "EOBINOTextBox"
        Me.EOBINOTextBox.Size = New System.Drawing.Size(104, 20)
        Me.EOBINOTextBox.TabIndex = 24
        '
        'NTNNOTextBox
        '
        Me.NTNNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "NTNNO", True))
        Me.NTNNOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NTNNOTextBox.Location = New System.Drawing.Point(101, 60)
        Me.NTNNOTextBox.Name = "NTNNOTextBox"
        Me.NTNNOTextBox.Size = New System.Drawing.Size(104, 20)
        Me.NTNNOTextBox.TabIndex = 25
        '
        'SSCNOTextBox
        '
        Me.SSCNOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "SSCNO", True))
        Me.SSCNOTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SSCNOTextBox.Location = New System.Drawing.Point(101, 14)
        Me.SSCNOTextBox.Name = "SSCNOTextBox"
        Me.SSCNOTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SSCNOTextBox.TabIndex = 23
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.DateTimePicker7)
        Me.GroupBox4.Controls.Add(Me.EmpStatusCheckBox)
        Me.GroupBox4.Controls.Add(ReasonLabel)
        Me.GroupBox4.Controls.Add(Me.ReasonComboBox)
        Me.GroupBox4.Controls.Add(LeaveDateLabel)
        Me.GroupBox4.Controls.Add(Me.LeaveDateMaskedTextBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(639, 192)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(323, 95)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Job Leaving / Transfer Info.:"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "LeaveDesc", True))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(101, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 20)
        Me.Label9.TabIndex = 23234546
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker7
        '
        Me.DateTimePicker7.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker7.Location = New System.Drawing.Point(187, 65)
        Me.DateTimePicker7.Name = "DateTimePicker7"
        Me.DateTimePicker7.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker7.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.DateTimePicker7, "Click For Add Job leaving Date")
        Me.DateTimePicker7.Visible = False
        '
        'EmpStatusCheckBox
        '
        Me.EmpStatusCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EmpStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "EmpStatus", True))
        Me.EmpStatusCheckBox.Enabled = False
        Me.EmpStatusCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpStatusCheckBox.ForeColor = System.Drawing.Color.Black
        Me.EmpStatusCheckBox.Location = New System.Drawing.Point(207, 69)
        Me.EmpStatusCheckBox.Name = "EmpStatusCheckBox"
        Me.EmpStatusCheckBox.Size = New System.Drawing.Size(90, 20)
        Me.EmpStatusCheckBox.TabIndex = 5
        Me.EmpStatusCheckBox.Text = "Emp. Status:"
        Me.EmpStatusCheckBox.UseVisualStyleBackColor = True
        '
        'ReasonComboBox
        '
        Me.ReasonComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ReasonComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ReasonComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "ReasonID", True))
        Me.ReasonComboBox.DataSource = Me.View_HRM_Leave_ReasonBindingSource
        Me.ReasonComboBox.DisplayMember = "Reason"
        Me.ReasonComboBox.Enabled = False
        Me.ReasonComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReasonComboBox.FormattingEnabled = True
        Me.ReasonComboBox.Location = New System.Drawing.Point(101, 19)
        Me.ReasonComboBox.Name = "ReasonComboBox"
        Me.ReasonComboBox.Size = New System.Drawing.Size(195, 21)
        Me.ReasonComboBox.TabIndex = 29
        Me.ReasonComboBox.ValueMember = "ReasonID"
        '
        'View_HRM_Leave_ReasonBindingSource
        '
        Me.View_HRM_Leave_ReasonBindingSource.DataMember = "View_HRM_Leave_Reason"
        Me.View_HRM_Leave_ReasonBindingSource.DataSource = Me.DSDept
        '
        'DSDept
        '
        Me.DSDept.DataSetName = "DSDept"
        Me.DSDept.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeaveDateMaskedTextBox
        '
        Me.LeaveDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.LeaveDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "LeaveDate", True))
        Me.LeaveDateMaskedTextBox.Enabled = False
        Me.LeaveDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeaveDateMaskedTextBox.Location = New System.Drawing.Point(101, 66)
        Me.LeaveDateMaskedTextBox.Mask = "00-00-0000"
        Me.LeaveDateMaskedTextBox.Name = "LeaveDateMaskedTextBox"
        Me.LeaveDateMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LeaveDateMaskedTextBox.TabIndex = 31
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker6)
        Me.GroupBox3.Controls.Add(NoticeTypeLabel)
        Me.GroupBox3.Controls.Add(Me.NoticeTypeComboBox1)
        Me.GroupBox3.Controls.Add(Me.AddNoticeBtn)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.NoticeTypeComboBox)
        Me.GroupBox3.Controls.Add(Me.LinkLabel17)
        Me.GroupBox3.Controls.Add(Me.LinkLabel8)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Label5)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox3.Controls.Add(Label4)
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.NoticeNo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(323, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(310, 232)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Notice Entry:"
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker6.Location = New System.Drawing.Point(276, 99)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(12, 20)
        Me.DateTimePicker6.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.DateTimePicker6, "Click For Add Branch Effective Date")
        '
        'NoticeTypeComboBox1
        '
        Me.NoticeTypeComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NoticeTypeComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NoticeTypeComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "NoticeID", True))
        Me.NoticeTypeComboBox1.DataSource = Me.Tbl_Hrm_Emp_NoticesBindingSource
        Me.NoticeTypeComboBox1.DisplayMember = "NoticeType"
        Me.NoticeTypeComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoticeTypeComboBox1.FormattingEnabled = True
        Me.NoticeTypeComboBox1.Location = New System.Drawing.Point(106, 43)
        Me.NoticeTypeComboBox1.Name = "NoticeTypeComboBox1"
        Me.NoticeTypeComboBox1.Size = New System.Drawing.Size(182, 21)
        Me.NoticeTypeComboBox1.TabIndex = 39
        Me.NoticeTypeComboBox1.ValueMember = "NoticeID"
        '
        'Tbl_Hrm_Emp_NoticesBindingSource
        '
        Me.Tbl_Hrm_Emp_NoticesBindingSource.DataMember = "tbl_Hrm_Emp_Notices"
        Me.Tbl_Hrm_Emp_NoticesBindingSource.DataSource = Me.DSHRM
        '
        'AddNoticeBtn
        '
        Me.AddNoticeBtn.BackColor = System.Drawing.Color.OrangeRed
        Me.AddNoticeBtn.ForeColor = System.Drawing.Color.White
        Me.AddNoticeBtn.Location = New System.Drawing.Point(105, 197)
        Me.AddNoticeBtn.Name = "AddNoticeBtn"
        Me.AddNoticeBtn.Size = New System.Drawing.Size(91, 32)
        Me.AddNoticeBtn.TabIndex = 38
        Me.AddNoticeBtn.Text = "Add  Notice"
        Me.AddNoticeBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(202, 197)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 32)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Print Notice"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NoticeTypeComboBox
        '
        Me.NoticeTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NoticeTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NoticeTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "NoticeReasonID", True))
        Me.NoticeTypeComboBox.DataSource = Me.Tbl_HRM_Leave_ReasonBindingSource
        Me.NoticeTypeComboBox.DisplayMember = "Reason"
        Me.NoticeTypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoticeTypeComboBox.FormattingEnabled = True
        Me.NoticeTypeComboBox.Location = New System.Drawing.Point(106, 70)
        Me.NoticeTypeComboBox.Name = "NoticeTypeComboBox"
        Me.NoticeTypeComboBox.Size = New System.Drawing.Size(182, 21)
        Me.NoticeTypeComboBox.TabIndex = 24
        Me.NoticeTypeComboBox.ValueMember = "ReasonID"
        '
        'Tbl_HRM_Leave_ReasonBindingSource
        '
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataMember = "tbl_HRM_Leave_Reason"
        Me.Tbl_HRM_Leave_ReasonBindingSource.DataSource = Me.DSHRM
        '
        'LinkLabel17
        '
        Me.LinkLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel17.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel17.Location = New System.Drawing.Point(289, 46)
        Me.LinkLabel17.Name = "LinkLabel17"
        Me.LinkLabel17.Size = New System.Drawing.Size(14, 18)
        Me.LinkLabel17.TabIndex = 37
        Me.LinkLabel17.TabStop = True
        Me.LinkLabel17.Text = "^"
        Me.LinkLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel17, "Click For Add New Notice Type Record")
        '
        'LinkLabel8
        '
        Me.LinkLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel8.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel8.Location = New System.Drawing.Point(289, 74)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(14, 18)
        Me.LinkLabel8.TabIndex = 37
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "^"
        Me.LinkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel8, "Click For Add New Notice Reason Record")
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "NoticeDescription", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(106, 130)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(182, 54)
        Me.TextBox2.TabIndex = 26
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.LightBlue
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "NoticeIssueDate", True))
        Me.MaskedTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(106, 99)
        Me.MaskedTextBox1.Mask = "00-00-0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(182, 20)
        Me.MaskedTextBox1.TabIndex = 25
        '
        'NoticeNo
        '
        Me.NoticeNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "NoticeNo", True))
        Me.NoticeNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoticeNo.Location = New System.Drawing.Point(106, 14)
        Me.NoticeNo.Name = "NoticeNo"
        Me.NoticeNo.ReadOnly = True
        Me.NoticeNo.Size = New System.Drawing.Size(182, 20)
        Me.NoticeNo.TabIndex = 0
        Me.NoticeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox9.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox9.Controls.Add(Me.LinkLabel12)
        Me.GroupBox9.Controls.Add(BranchNameLabel)
        Me.GroupBox9.Controls.Add(Me.BranchEffectiveDateMaskedTextBox)
        Me.GroupBox9.Controls.Add(BranchEffectiveDateLabel)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(6, 440)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(310, 70)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Branch Info.:"
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(277, 44)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(12, 20)
        Me.DateTimePicker4.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.DateTimePicker4, "Click For Add Branch Effective Date")
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "BranchID", True))
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(106, 15)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.BranchNameComboBox.TabIndex = 0
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'LinkLabel12
        '
        Me.LinkLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel12.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel12.Location = New System.Drawing.Point(290, 19)
        Me.LinkLabel12.Name = "LinkLabel12"
        Me.LinkLabel12.Size = New System.Drawing.Size(15, 16)
        Me.LinkLabel12.TabIndex = 35
        Me.LinkLabel12.TabStop = True
        Me.LinkLabel12.Text = "^"
        Me.LinkLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel12, "Click For Add New Branch Record")
        '
        'BranchEffectiveDateMaskedTextBox
        '
        Me.BranchEffectiveDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.BranchEffectiveDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "BranchEffectiveDate", True))
        Me.BranchEffectiveDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BranchEffectiveDateMaskedTextBox.Location = New System.Drawing.Point(106, 43)
        Me.BranchEffectiveDateMaskedTextBox.Mask = "00-00-0000"
        Me.BranchEffectiveDateMaskedTextBox.Name = "BranchEffectiveDateMaskedTextBox"
        Me.BranchEffectiveDateMaskedTextBox.Size = New System.Drawing.Size(182, 20)
        Me.BranchEffectiveDateMaskedTextBox.TabIndex = 1
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox8.Controls.Add(Me.ShiftNameComboBox)
        Me.GroupBox8.Controls.Add(ShiftNameLabel)
        Me.GroupBox8.Controls.Add(Me.ShiftEffectiveDateMaskedTextBox)
        Me.GroupBox8.Controls.Add(ShiftEffectiveDateLabel)
        Me.GroupBox8.Controls.Add(Me.LinkLabel10)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(6, 368)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(310, 69)
        Me.GroupBox8.TabIndex = 3
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Shift Info.:"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(273, 40)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker3.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.DateTimePicker3, "Click For Add Shift Effective Date")
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ShiftNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShiftNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "ShiftID", True))
        Me.ShiftNameComboBox.DataSource = Me.Tbl_HRM_ShiftBindingSource
        Me.ShiftNameComboBox.DisplayMember = "ShiftName"
        Me.ShiftNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(106, 16)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.ShiftNameComboBox.TabIndex = 0
        Me.ShiftNameComboBox.ValueMember = "ShiftID"
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSHRM
        '
        'ShiftEffectiveDateMaskedTextBox
        '
        Me.ShiftEffectiveDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.ShiftEffectiveDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "ShiftEffectiveDate", True))
        Me.ShiftEffectiveDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShiftEffectiveDateMaskedTextBox.Location = New System.Drawing.Point(106, 40)
        Me.ShiftEffectiveDateMaskedTextBox.Mask = "00-00-0000"
        Me.ShiftEffectiveDateMaskedTextBox.Name = "ShiftEffectiveDateMaskedTextBox"
        Me.ShiftEffectiveDateMaskedTextBox.Size = New System.Drawing.Size(182, 20)
        Me.ShiftEffectiveDateMaskedTextBox.TabIndex = 1
        '
        'LinkLabel10
        '
        Me.LinkLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel10.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel10.Location = New System.Drawing.Point(290, 17)
        Me.LinkLabel10.Name = "LinkLabel10"
        Me.LinkLabel10.Size = New System.Drawing.Size(15, 20)
        Me.LinkLabel10.TabIndex = 33
        Me.LinkLabel10.TabStop = True
        Me.LinkLabel10.Text = "^"
        Me.LinkLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel10, "Click For Add New Shift Record")
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox6.Controls.Add(GradeNameLabel)
        Me.GroupBox6.Controls.Add(Me.LinkLabel11)
        Me.GroupBox6.Controls.Add(GradeEffectiveDateLabel)
        Me.GroupBox6.Controls.Add(Me.GradeEffectiveDateMaskedTextBox)
        Me.GroupBox6.Controls.Add(Me.GradeNameComboBox)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(6, 297)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(310, 65)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Grade Info.:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(275, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker2.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.DateTimePicker2, "Click For Add Grade Effective Date")
        '
        'LinkLabel11
        '
        Me.LinkLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel11.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel11.Location = New System.Drawing.Point(290, 19)
        Me.LinkLabel11.Name = "LinkLabel11"
        Me.LinkLabel11.Size = New System.Drawing.Size(15, 16)
        Me.LinkLabel11.TabIndex = 34
        Me.LinkLabel11.TabStop = True
        Me.LinkLabel11.Text = "^"
        Me.LinkLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel11, "Click For Add New Grade  Record")
        '
        'GradeEffectiveDateMaskedTextBox
        '
        Me.GradeEffectiveDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.GradeEffectiveDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "GradeEffectiveDate", True))
        Me.GradeEffectiveDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeEffectiveDateMaskedTextBox.Location = New System.Drawing.Point(106, 38)
        Me.GradeEffectiveDateMaskedTextBox.Mask = "00-00-0000"
        Me.GradeEffectiveDateMaskedTextBox.Name = "GradeEffectiveDateMaskedTextBox"
        Me.GradeEffectiveDateMaskedTextBox.Size = New System.Drawing.Size(182, 20)
        Me.GradeEffectiveDateMaskedTextBox.TabIndex = 1
        '
        'GradeNameComboBox
        '
        Me.GradeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.GradeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.GradeNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "GradeID", True))
        Me.GradeNameComboBox.DataSource = Me.Tbl_HRM_GradeBindingSource
        Me.GradeNameComboBox.DisplayMember = "GradeName"
        Me.GradeNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeNameComboBox.FormattingEnabled = True
        Me.GradeNameComboBox.Location = New System.Drawing.Point(106, 14)
        Me.GradeNameComboBox.Name = "GradeNameComboBox"
        Me.GradeNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.GradeNameComboBox.TabIndex = 0
        Me.GradeNameComboBox.ValueMember = "GradeID"
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSHRM
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.LinkLabel9)
        Me.GroupBox2.Controls.Add(JobTypeEffectiveDateLabel)
        Me.GroupBox2.Controls.Add(Me.JobTypeEffectiveDateMaskedTextBox)
        Me.GroupBox2.Controls.Add(JobTypeNameLabel)
        Me.GroupBox2.Controls.Add(Me.JobTypeNameComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(323, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 64)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "JobType Info.:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(275, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker1.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Click For Add  Job Type Effective Date")
        '
        'LinkLabel9
        '
        Me.LinkLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel9.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel9.Location = New System.Drawing.Point(289, 15)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(15, 18)
        Me.LinkLabel9.TabIndex = 32
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "^"
        Me.LinkLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel9, "Click For Add New Job Type Record")
        '
        'JobTypeEffectiveDateMaskedTextBox
        '
        Me.JobTypeEffectiveDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.JobTypeEffectiveDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "JobTypeEffectiveDate", True))
        Me.JobTypeEffectiveDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobTypeEffectiveDateMaskedTextBox.Location = New System.Drawing.Point(106, 39)
        Me.JobTypeEffectiveDateMaskedTextBox.Mask = "00-00-0000"
        Me.JobTypeEffectiveDateMaskedTextBox.Name = "JobTypeEffectiveDateMaskedTextBox"
        Me.JobTypeEffectiveDateMaskedTextBox.Size = New System.Drawing.Size(182, 20)
        Me.JobTypeEffectiveDateMaskedTextBox.TabIndex = 17
        '
        'JobTypeNameComboBox
        '
        Me.JobTypeNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.JobTypeNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.JobTypeNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "JobTypeID", True))
        Me.JobTypeNameComboBox.DataSource = Me.Tbl_HRM_JobTypeBindingSource
        Me.JobTypeNameComboBox.DisplayMember = "JobTypeName"
        Me.JobTypeNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobTypeNameComboBox.FormattingEnabled = True
        Me.JobTypeNameComboBox.Location = New System.Drawing.Point(106, 13)
        Me.JobTypeNameComboBox.Name = "JobTypeNameComboBox"
        Me.JobTypeNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.JobTypeNameComboBox.TabIndex = 16
        Me.JobTypeNameComboBox.ValueMember = "jobTypeID"
        '
        'Tbl_HRM_JobTypeBindingSource
        '
        Me.Tbl_HRM_JobTypeBindingSource.DataMember = "tbl_HRM_JobType"
        Me.Tbl_HRM_JobTypeBindingSource.DataSource = Me.DSHRM
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker5)
        Me.GroupBox1.Controls.Add(Me.LinkLabel16)
        Me.GroupBox1.Controls.Add(Me.LinkLabel5)
        Me.GroupBox1.Controls.Add(Me.LinkLabel4)
        Me.GroupBox1.Controls.Add(SectEffectiveDateLabel)
        Me.GroupBox1.Controls.Add(Me.SectEffectiveDateMaskedTextBox)
        Me.GroupBox1.Controls.Add(DesigNameLabel)
        Me.GroupBox1.Controls.Add(Me.DesigNameComboBox)
        Me.GroupBox1.Controls.Add(SectionNameLabel)
        Me.GroupBox1.Controls.Add(Me.SectionNameComboBox)
        Me.GroupBox1.Controls.Add(DeptNameLabel)
        Me.GroupBox1.Controls.Add(Me.DeptNameComboBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 166)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 126)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Department Info:"
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker5.Location = New System.Drawing.Point(274, 96)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker5.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.DateTimePicker5, "Click For Add Effective Date")
        '
        'LinkLabel16
        '
        Me.LinkLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel16.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel16.Location = New System.Drawing.Point(290, 48)
        Me.LinkLabel16.Name = "LinkLabel16"
        Me.LinkLabel16.Size = New System.Drawing.Size(16, 18)
        Me.LinkLabel16.TabIndex = 28
        Me.LinkLabel16.TabStop = True
        Me.LinkLabel16.Text = "^"
        Me.LinkLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel16, "Click For Add New Section Record")
        '
        'LinkLabel5
        '
        Me.LinkLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel5.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel5.Location = New System.Drawing.Point(290, 74)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(17, 16)
        Me.LinkLabel5.TabIndex = 29
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "^"
        Me.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel5, "Click For Add New Designation Record")
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel4.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel4.Location = New System.Drawing.Point(290, 21)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(17, 18)
        Me.LinkLabel4.TabIndex = 27
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "^"
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.LinkLabel4, "Click For Add New Department Record")
        '
        'SectEffectiveDateMaskedTextBox
        '
        Me.SectEffectiveDateMaskedTextBox.BackColor = System.Drawing.Color.LightBlue
        Me.SectEffectiveDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "SectEffectiveDate", True))
        Me.SectEffectiveDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectEffectiveDateMaskedTextBox.Location = New System.Drawing.Point(106, 97)
        Me.SectEffectiveDateMaskedTextBox.Mask = "00-00-0000"
        Me.SectEffectiveDateMaskedTextBox.Name = "SectEffectiveDateMaskedTextBox"
        Me.SectEffectiveDateMaskedTextBox.Size = New System.Drawing.Size(182, 20)
        Me.SectEffectiveDateMaskedTextBox.TabIndex = 3
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "DesignationID", True))
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(106, 70)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.DesigNameComboBox.TabIndex = 2
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'SectionNameComboBox
        '
        Me.SectionNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SectionNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectionNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "SectionID", True))
        Me.SectionNameComboBox.DataSource = Me.Tbl_HRM_Section_NewBindingSource
        Me.SectionNameComboBox.DisplayMember = "SectionName"
        Me.SectionNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(106, 44)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.SectionNameComboBox.TabIndex = 1
        Me.SectionNameComboBox.ValueMember = "SectionID"
        '
        'Tbl_HRM_Section_NewBindingSource
        '
        Me.Tbl_HRM_Section_NewBindingSource.DataMember = "tbl_HRM_Dept_tbl_HRM_Section"
        Me.Tbl_HRM_Section_NewBindingSource.DataSource = Me.Tbl_HRM_Dept_NewBindingSource
        '
        'Tbl_HRM_Dept_NewBindingSource
        '
        Me.Tbl_HRM_Dept_NewBindingSource.DataMember = "tbl_HRM_Dept_New"
        Me.Tbl_HRM_Dept_NewBindingSource.DataSource = Me.DSDept
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "DeptID", True))
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_Dept_NewBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(106, 18)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(182, 21)
        Me.DeptNameComboBox.TabIndex = 0
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage2.Controls.Add(Me.GroupBox17)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(SalIDLabel)
        Me.TabPage2.Controls.Add(Me.SalIDTextBox)
        Me.TabPage2.Controls.Add(Me.GroupBox13)
        Me.TabPage2.Controls.Add(Me.GroupBox12)
        Me.TabPage2.Controls.Add(Me.GroupBox11)
        Me.TabPage2.Controls.Add(Me.Tbl_Acc_SalaryBindingNavigator)
        Me.TabPage2.Location = New System.Drawing.Point(23, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(981, 522)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salary Data"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.Button11)
        Me.GroupBox17.Controls.Add(Label29)
        Me.GroupBox17.Controls.Add(Me.ComboBox3)
        Me.GroupBox17.Controls.Add(Label28)
        Me.GroupBox17.Controls.Add(Me.ComboBox2)
        Me.GroupBox17.Controls.Add(Me.TextBox4)
        Me.GroupBox17.Controls.Add(Label27)
        Me.GroupBox17.Controls.Add(Label26)
        Me.GroupBox17.Controls.Add(Me.CheckBox10)
        Me.GroupBox17.Controls.Add(Label25)
        Me.GroupBox17.Controls.Add(Me.CheckBox9)
        Me.GroupBox17.Controls.Add(Label24)
        Me.GroupBox17.Controls.Add(Me.CheckBox8)
        Me.GroupBox17.Controls.Add(Label23)
        Me.GroupBox17.Controls.Add(Me.CheckBox7)
        Me.GroupBox17.Controls.Add(Label22)
        Me.GroupBox17.Controls.Add(Me.CheckBox6)
        Me.GroupBox17.Controls.Add(Label21)
        Me.GroupBox17.Controls.Add(Me.CheckBox5)
        Me.GroupBox17.Controls.Add(Label20)
        Me.GroupBox17.Location = New System.Drawing.Point(640, 43)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(295, 240)
        Me.GroupBox17.TabIndex = 59
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Other Benifits"
        Me.GroupBox17.Visible = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.ForeColor = System.Drawing.Color.Black
        Me.Button11.Location = New System.Drawing.Point(121, 200)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(112, 30)
        Me.Button11.TabIndex = 69
        Me.Button11.Text = "Save Data"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'ComboBox3
        '
        Me.ComboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_HRM_Emp_InfoBindingSource, "BusRoute", True))
        Me.ComboBox3.DataSource = Me.Tbl_Bus_Route_InfoBindingSource
        Me.ComboBox3.DisplayMember = "RoutName"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(122, 177)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox3.TabIndex = 67
        Me.ComboBox3.ValueMember = "RoutID"
        '
        'Tbl_Bus_Route_InfoBindingSource
        '
        Me.Tbl_Bus_Route_InfoBindingSource.DataMember = "tbl_Bus_Route_Info"
        Me.Tbl_Bus_Route_InfoBindingSource.DataSource = Me.DSBusInfo
        '
        'DSBusInfo
        '
        Me.DSBusInfo.DataSetName = "DSBusInfo"
        Me.DSBusInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "TransportFacility", True))
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Regular", "Management", "Special", "Allowance"})
        Me.ComboBox2.Location = New System.Drawing.Point(122, 152)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(167, 21)
        Me.ComboBox2.TabIndex = 65
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "DinnerAllowance", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(122, 129)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(101, 20)
        Me.TextBox4.TabIndex = 63
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckBox10
        '
        Me.CheckBox10.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "Medical8", True))
        Me.CheckBox10.Location = New System.Drawing.Point(122, 109)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox10.TabIndex = 60
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "Casual10", True))
        Me.CheckBox9.Location = New System.Drawing.Point(122, 89)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox9.TabIndex = 58
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "AnnualLeaves", True))
        Me.CheckBox8.Location = New System.Drawing.Point(122, 69)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox8.TabIndex = 56
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "Graduity", True))
        Me.CheckBox7.Location = New System.Drawing.Point(122, 50)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(104, 20)
        Me.CheckBox7.TabIndex = 54
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "Bonus2", True))
        Me.CheckBox6.Location = New System.Drawing.Point(199, 28)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(48, 20)
        Me.CheckBox6.TabIndex = 52
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "Bonus1", True))
        Me.CheckBox5.Location = New System.Drawing.Point(122, 28)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(37, 20)
        Me.CheckBox5.TabIndex = 50
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(404, 277)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 32)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "Refresh"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(522, 276)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(112, 32)
        Me.Button8.TabIndex = 39
        Me.Button8.Text = "Save Data"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'SalIDTextBox
        '
        Me.SalIDTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SalIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SalIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_SalaryBindingSource, "SalID", True))
        Me.SalIDTextBox.Enabled = False
        Me.SalIDTextBox.Location = New System.Drawing.Point(835, 213)
        Me.SalIDTextBox.Name = "SalIDTextBox"
        Me.SalIDTextBox.ReadOnly = True
        Me.SalIDTextBox.Size = New System.Drawing.Size(100, 13)
        Me.SalIDTextBox.TabIndex = 38
        Me.SalIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SalIDTextBox.Visible = False
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(AppIDLabel)
        Me.GroupBox13.Controls.Add(Me.NameComboBox)
        Me.GroupBox13.Controls.Add(IncrementStatusLabel)
        Me.GroupBox13.Controls.Add(Me.IncrementStatusLabel1)
        Me.GroupBox13.Controls.Add(Me.DateTimePicker13)
        Me.GroupBox13.Controls.Add(Me.EffectedFromDateMaskedTextBox)
        Me.GroupBox13.Controls.Add(Me.PaymentModeComboBox)
        Me.GroupBox13.Controls.Add(PaymentModeLabel)
        Me.GroupBox13.Controls.Add(Me.FinancialPeriodComboBox)
        Me.GroupBox13.Controls.Add(FinancialPeriodLabel)
        Me.GroupBox13.Controls.Add(ActivationStatusLabel)
        Me.GroupBox13.Controls.Add(Me.ActivationStatusCheckBox)
        Me.GroupBox13.Controls.Add(ActivationDateLabel)
        Me.GroupBox13.Controls.Add(EffectedFromDateLabel)
        Me.GroupBox13.Controls.Add(Me.ActivationDateMaskedTextBox)
        Me.GroupBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(339, 43)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(295, 230)
        Me.GroupBox13.TabIndex = 2
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "General Info.:"
        '
        'NameComboBox
        '
        Me.NameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Acc_Salary_NewBindingSource, "AppID", True))
        Me.NameComboBox.DataSource = Me.Tbl_HRM_App_AuthorityBindingSource
        Me.NameComboBox.DisplayMember = "Name"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(121, 97)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(161, 21)
        Me.NameComboBox.TabIndex = 41
        Me.NameComboBox.ValueMember = "AppID"
        '
        'Tbl_Acc_Salary_NewBindingSource
        '
        Me.Tbl_Acc_Salary_NewBindingSource.DataMember = "tbl_HRM_Emp_Info_tbl_Acc_Salary_New"
        Me.Tbl_Acc_Salary_NewBindingSource.DataSource = Me.Tbl_HRM_Emp_InfoBindingSource
        '
        'Tbl_HRM_App_AuthorityBindingSource
        '
        Me.Tbl_HRM_App_AuthorityBindingSource.DataMember = "tbl_HRM_App_Authority"
        Me.Tbl_HRM_App_AuthorityBindingSource.DataSource = Me.DSHRM
        '
        'IncrementStatusLabel1
        '
        Me.IncrementStatusLabel1.BackColor = System.Drawing.Color.White
        Me.IncrementStatusLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "IncrementStatus", True))
        Me.IncrementStatusLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncrementStatusLabel1.Location = New System.Drawing.Point(121, 73)
        Me.IncrementStatusLabel1.Name = "IncrementStatusLabel1"
        Me.IncrementStatusLabel1.Size = New System.Drawing.Size(161, 20)
        Me.IncrementStatusLabel1.TabIndex = 16
        Me.IncrementStatusLabel1.Text = "Label7"
        Me.IncrementStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker13
        '
        Me.DateTimePicker13.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker13.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker13.Location = New System.Drawing.Point(266, 123)
        Me.DateTimePicker13.Name = "DateTimePicker13"
        Me.DateTimePicker13.Size = New System.Drawing.Size(16, 20)
        Me.DateTimePicker13.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.DateTimePicker13, "Click For Add Salary Effective Date")
        '
        'EffectedFromDateMaskedTextBox
        '
        Me.EffectedFromDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "EffectedFromDate", True))
        Me.EffectedFromDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EffectedFromDateMaskedTextBox.Location = New System.Drawing.Point(121, 123)
        Me.EffectedFromDateMaskedTextBox.Mask = "00-00-0000"
        Me.EffectedFromDateMaskedTextBox.Name = "EffectedFromDateMaskedTextBox"
        Me.EffectedFromDateMaskedTextBox.Size = New System.Drawing.Size(161, 20)
        Me.EffectedFromDateMaskedTextBox.TabIndex = 16
        '
        'PaymentModeComboBox
        '
        Me.PaymentModeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PaymentModeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PaymentModeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "PaymentMode", True))
        Me.PaymentModeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentModeComboBox.FormattingEnabled = True
        Me.PaymentModeComboBox.Items.AddRange(New Object() {"Cash", "Transfer"})
        Me.PaymentModeComboBox.Location = New System.Drawing.Point(121, 47)
        Me.PaymentModeComboBox.Name = "PaymentModeComboBox"
        Me.PaymentModeComboBox.Size = New System.Drawing.Size(161, 21)
        Me.PaymentModeComboBox.TabIndex = 15
        '
        'FinancialPeriodComboBox
        '
        Me.FinancialPeriodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FinancialPeriodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FinancialPeriodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Acc_Salary_NewBindingSource, "FinancialPeriod", True))
        Me.FinancialPeriodComboBox.DataSource = Me.Tbl_Acc_FinancialPeriodBindingSource
        Me.FinancialPeriodComboBox.DisplayMember = "FinancialPeriod"
        Me.FinancialPeriodComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinancialPeriodComboBox.FormattingEnabled = True
        Me.FinancialPeriodComboBox.Location = New System.Drawing.Point(121, 21)
        Me.FinancialPeriodComboBox.Name = "FinancialPeriodComboBox"
        Me.FinancialPeriodComboBox.Size = New System.Drawing.Size(161, 21)
        Me.FinancialPeriodComboBox.TabIndex = 14
        Me.FinancialPeriodComboBox.ValueMember = "FinancialPeriod"
        '
        'Tbl_Acc_FinancialPeriodBindingSource
        '
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataMember = "tbl_Acc_FinancialPeriod"
        Me.Tbl_Acc_FinancialPeriodBindingSource.DataSource = Me.DSHRM
        '
        'ActivationStatusCheckBox
        '
        Me.ActivationStatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Acc_Salary_NewBindingSource, "ActivationStatus", True))
        Me.ActivationStatusCheckBox.Enabled = False
        Me.ActivationStatusCheckBox.Location = New System.Drawing.Point(121, 148)
        Me.ActivationStatusCheckBox.Name = "ActivationStatusCheckBox"
        Me.ActivationStatusCheckBox.Size = New System.Drawing.Size(21, 20)
        Me.ActivationStatusCheckBox.TabIndex = 14
        Me.ActivationStatusCheckBox.UseVisualStyleBackColor = True
        '
        'ActivationDateMaskedTextBox
        '
        Me.ActivationDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "ActivationDate", True))
        Me.ActivationDateMaskedTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivationDateMaskedTextBox.Location = New System.Drawing.Point(121, 174)
        Me.ActivationDateMaskedTextBox.Mask = "00-00-0000"
        Me.ActivationDateMaskedTextBox.Name = "ActivationDateMaskedTextBox"
        Me.ActivationDateMaskedTextBox.ReadOnly = True
        Me.ActivationDateMaskedTextBox.Size = New System.Drawing.Size(161, 20)
        Me.ActivationDateMaskedTextBox.TabIndex = 15
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.TextBox5)
        Me.GroupBox12.Controls.Add(Label30)
        Me.GroupBox12.Controls.Add(NetGrossSalaryLabel)
        Me.GroupBox12.Controls.Add(AccommodationLabel)
        Me.GroupBox12.Controls.Add(Me.NetGrossSalaryLabel1)
        Me.GroupBox12.Controls.Add(Me.AccommodationTextBox)
        Me.GroupBox12.Controls.Add(Me.MealAllowanceTextBox)
        Me.GroupBox12.Controls.Add(Me.BasicSalaryTextBox)
        Me.GroupBox12.Controls.Add(MealAllowanceLabel)
        Me.GroupBox12.Controls.Add(BasicSalaryLabel)
        Me.GroupBox12.Controls.Add(Me.TravelAllowanceTextBox)
        Me.GroupBox12.Controls.Add(TravelAllowanceLabel)
        Me.GroupBox12.Controls.Add(Me.EducationAllowanceTextBox)
        Me.GroupBox12.Controls.Add(EducationAllowanceLabel)
        Me.GroupBox12.Controls.Add(Me.SpecialAllowanceTextBox)
        Me.GroupBox12.Controls.Add(SpecialAllowanceLabel)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(13, 43)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(318, 230)
        Me.GroupBox12.TabIndex = 0
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Salary And Allowances Info.:"
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "DailyTravelAllowance", True))
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(125, 123)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(165, 20)
        Me.TextBox5.TabIndex = 60
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'NetGrossSalaryLabel1
        '
        Me.NetGrossSalaryLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NetGrossSalaryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "NetGrossSalary", True))
        Me.NetGrossSalaryLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetGrossSalaryLabel1.Location = New System.Drawing.Point(125, 200)
        Me.NetGrossSalaryLabel1.Name = "NetGrossSalaryLabel1"
        Me.NetGrossSalaryLabel1.Size = New System.Drawing.Size(165, 20)
        Me.NetGrossSalaryLabel1.TabIndex = 7
        Me.NetGrossSalaryLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AccommodationTextBox
        '
        Me.AccommodationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "Accommodation", True))
        Me.AccommodationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccommodationTextBox.Location = New System.Drawing.Point(125, 174)
        Me.AccommodationTextBox.Name = "AccommodationTextBox"
        Me.AccommodationTextBox.Size = New System.Drawing.Size(165, 20)
        Me.AccommodationTextBox.TabIndex = 6
        Me.AccommodationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MealAllowanceTextBox
        '
        Me.MealAllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "MealAllowance", True))
        Me.MealAllowanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MealAllowanceTextBox.Location = New System.Drawing.Point(125, 74)
        Me.MealAllowanceTextBox.Name = "MealAllowanceTextBox"
        Me.MealAllowanceTextBox.Size = New System.Drawing.Size(165, 20)
        Me.MealAllowanceTextBox.TabIndex = 3
        Me.MealAllowanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BasicSalaryTextBox
        '
        Me.BasicSalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "BasicSalary", True))
        Me.BasicSalaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicSalaryTextBox.Location = New System.Drawing.Point(125, 22)
        Me.BasicSalaryTextBox.Name = "BasicSalaryTextBox"
        Me.BasicSalaryTextBox.Size = New System.Drawing.Size(165, 20)
        Me.BasicSalaryTextBox.TabIndex = 1
        Me.BasicSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TravelAllowanceTextBox
        '
        Me.TravelAllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "TravelAllowance", True))
        Me.TravelAllowanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TravelAllowanceTextBox.Location = New System.Drawing.Point(125, 98)
        Me.TravelAllowanceTextBox.Name = "TravelAllowanceTextBox"
        Me.TravelAllowanceTextBox.Size = New System.Drawing.Size(165, 20)
        Me.TravelAllowanceTextBox.TabIndex = 4
        Me.TravelAllowanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EducationAllowanceTextBox
        '
        Me.EducationAllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "EducationAllowance", True))
        Me.EducationAllowanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EducationAllowanceTextBox.Location = New System.Drawing.Point(125, 149)
        Me.EducationAllowanceTextBox.Name = "EducationAllowanceTextBox"
        Me.EducationAllowanceTextBox.Size = New System.Drawing.Size(165, 20)
        Me.EducationAllowanceTextBox.TabIndex = 5
        Me.EducationAllowanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SpecialAllowanceTextBox
        '
        Me.SpecialAllowanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "SpecialAllowance", True))
        Me.SpecialAllowanceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialAllowanceTextBox.Location = New System.Drawing.Point(125, 48)
        Me.SpecialAllowanceTextBox.Name = "SpecialAllowanceTextBox"
        Me.SpecialAllowanceTextBox.Size = New System.Drawing.Size(165, 20)
        Me.SpecialAllowanceTextBox.TabIndex = 2
        Me.SpecialAllowanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(ConteenDeductLabel)
        Me.GroupBox11.Controls.Add(Me.ConteenDeductTextBox)
        Me.GroupBox11.Controls.Add(Me.TaxDeductionTextBox)
        Me.GroupBox11.Controls.Add(Me.EOBITextBox)
        Me.GroupBox11.Controls.Add(EOBILabel)
        Me.GroupBox11.Controls.Add(TaxDeductionLabel)
        Me.GroupBox11.Controls.Add(Me.RentDeductionTextBox)
        Me.GroupBox11.Controls.Add(RentDeductionLabel)
        Me.GroupBox11.Controls.Add(Me.UnionFundTextBox)
        Me.GroupBox11.Controls.Add(UnionFundLabel)
        Me.GroupBox11.Controls.Add(Me.PESSIContCheckBox)
        Me.GroupBox11.Controls.Add(PESSIContLabel)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(13, 287)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(318, 212)
        Me.GroupBox11.TabIndex = 1
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Deduction Info.:"
        '
        'ConteenDeductTextBox
        '
        Me.ConteenDeductTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "ConteenDeduct", True))
        Me.ConteenDeductTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConteenDeductTextBox.Location = New System.Drawing.Point(125, 105)
        Me.ConteenDeductTextBox.Name = "ConteenDeductTextBox"
        Me.ConteenDeductTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ConteenDeductTextBox.TabIndex = 11
        Me.ConteenDeductTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TaxDeductionTextBox
        '
        Me.TaxDeductionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "TaxDeduction", True))
        Me.TaxDeductionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxDeductionTextBox.Location = New System.Drawing.Point(125, 27)
        Me.TaxDeductionTextBox.Name = "TaxDeductionTextBox"
        Me.TaxDeductionTextBox.Size = New System.Drawing.Size(165, 20)
        Me.TaxDeductionTextBox.TabIndex = 8
        Me.TaxDeductionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'EOBITextBox
        '
        Me.EOBITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "EOBI", True))
        Me.EOBITextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EOBITextBox.Location = New System.Drawing.Point(125, 131)
        Me.EOBITextBox.Name = "EOBITextBox"
        Me.EOBITextBox.Size = New System.Drawing.Size(165, 20)
        Me.EOBITextBox.TabIndex = 12
        Me.EOBITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RentDeductionTextBox
        '
        Me.RentDeductionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "RentDeduction", True))
        Me.RentDeductionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentDeductionTextBox.Location = New System.Drawing.Point(125, 53)
        Me.RentDeductionTextBox.Name = "RentDeductionTextBox"
        Me.RentDeductionTextBox.Size = New System.Drawing.Size(165, 20)
        Me.RentDeductionTextBox.TabIndex = 9
        Me.RentDeductionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'UnionFundTextBox
        '
        Me.UnionFundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Acc_Salary_NewBindingSource, "UnionFund", True))
        Me.UnionFundTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnionFundTextBox.Location = New System.Drawing.Point(125, 79)
        Me.UnionFundTextBox.Name = "UnionFundTextBox"
        Me.UnionFundTextBox.Size = New System.Drawing.Size(165, 20)
        Me.UnionFundTextBox.TabIndex = 10
        Me.UnionFundTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PESSIContCheckBox
        '
        Me.PESSIContCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_Acc_Salary_NewBindingSource, "PESSICont", True))
        Me.PESSIContCheckBox.Location = New System.Drawing.Point(125, 157)
        Me.PESSIContCheckBox.Name = "PESSIContCheckBox"
        Me.PESSIContCheckBox.Size = New System.Drawing.Size(104, 20)
        Me.PESSIContCheckBox.TabIndex = 13
        Me.PESSIContCheckBox.UseVisualStyleBackColor = True
        '
        'Tbl_Acc_SalaryBindingNavigator
        '
        Me.Tbl_Acc_SalaryBindingNavigator.AddNewItem = Me.AddSalary
        Me.Tbl_Acc_SalaryBindingNavigator.BindingSource = Me.Tbl_Acc_Salary_NewBindingSource
        Me.Tbl_Acc_SalaryBindingNavigator.CountItem = Me.ToolStripLabel2
        Me.Tbl_Acc_SalaryBindingNavigator.DeleteItem = Nothing
        Me.Tbl_Acc_SalaryBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Tbl_Acc_SalaryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton7, Me.ToolStripButton8, Me.ToolStripSeparator4, Me.ToolStripTextBox7, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator6, Me.AddSalary, Me.SaveSalary})
        Me.Tbl_Acc_SalaryBindingNavigator.Location = New System.Drawing.Point(3, 3)
        Me.Tbl_Acc_SalaryBindingNavigator.MoveFirstItem = Me.ToolStripButton7
        Me.Tbl_Acc_SalaryBindingNavigator.MoveLastItem = Me.ToolStripButton10
        Me.Tbl_Acc_SalaryBindingNavigator.MoveNextItem = Me.ToolStripButton9
        Me.Tbl_Acc_SalaryBindingNavigator.MovePreviousItem = Me.ToolStripButton8
        Me.Tbl_Acc_SalaryBindingNavigator.Name = "Tbl_Acc_SalaryBindingNavigator"
        Me.Tbl_Acc_SalaryBindingNavigator.PositionItem = Me.ToolStripTextBox7
        Me.Tbl_Acc_SalaryBindingNavigator.Size = New System.Drawing.Size(975, 27)
        Me.Tbl_Acc_SalaryBindingNavigator.TabIndex = 37
        Me.Tbl_Acc_SalaryBindingNavigator.Text = "BindingNavigator1"
        '
        'AddSalary
        '
        Me.AddSalary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddSalary.Enabled = False
        Me.AddSalary.Image = CType(resources.GetObject("AddSalary.Image"), System.Drawing.Image)
        Me.AddSalary.Name = "AddSalary"
        Me.AddSalary.RightToLeftAutoMirrorImage = True
        Me.AddSalary.Size = New System.Drawing.Size(24, 24)
        Me.AddSalary.Text = "Add new"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 24)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton7.Text = "Move first"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton8.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripTextBox7
        '
        Me.ToolStripTextBox7.AccessibleName = "Position"
        Me.ToolStripTextBox7.AutoSize = False
        Me.ToolStripTextBox7.Name = "ToolStripTextBox7"
        Me.ToolStripTextBox7.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox7.Text = "0"
        Me.ToolStripTextBox7.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton9.Text = "Move next"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(24, 24)
        Me.ToolStripButton10.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'SaveSalary
        '
        Me.SaveSalary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveSalary.Enabled = False
        Me.SaveSalary.Image = CType(resources.GetObject("SaveSalary.Image"), System.Drawing.Image)
        Me.SaveSalary.Name = "SaveSalary"
        Me.SaveSalary.Size = New System.Drawing.Size(24, 24)
        Me.SaveSalary.Text = "Save Data"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.TabPage3.Controls.Add(Me.Button9)
        Me.TabPage3.Controls.Add(Me.Button10)
        Me.TabPage3.Controls.Add(Me.GroupBox15)
        Me.TabPage3.Controls.Add(Me.MaskedTextBox5)
        Me.TabPage3.Controls.Add(Me.DateTimePicker17)
        Me.TabPage3.Controls.Add(Label16)
        Me.TabPage3.Controls.Add(Me.DateTimePicker18)
        Me.TabPage3.Controls.Add(Me.MaskedTextBox4)
        Me.TabPage3.Controls.Add(Label15)
        Me.TabPage3.Location = New System.Drawing.Point(23, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(981, 522)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Sleep"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(75, 132)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(112, 32)
        Me.Button9.TabIndex = 42
        Me.Button9.Text = "Refresh"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(197, 132)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(112, 32)
        Me.Button10.TabIndex = 41
        Me.Button10.Text = "Save Data"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.CheckBox3)
        Me.GroupBox15.Controls.Add(Label12)
        Me.GroupBox15.Controls.Add(Me.TextBox1)
        Me.GroupBox15.Controls.Add(Label13)
        Me.GroupBox15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.ForeColor = System.Drawing.Color.Black
        Me.GroupBox15.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(309, 103)
        Me.GroupBox15.TabIndex = 1
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Employee Sleep:"
        '
        'CheckBox3
        '
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "StruckStatus", True))
        Me.CheckBox3.Location = New System.Drawing.Point(53, 80)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(21, 20)
        Me.CheckBox3.TabIndex = 111111116
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "StruckReason", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(55, 19)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 60)
        Me.TextBox1.TabIndex = 4
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.BackColor = System.Drawing.Color.MintCream
        Me.MaskedTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "SuspendSTRTDate", True))
        Me.MaskedTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox5.Location = New System.Drawing.Point(480, 311)
        Me.MaskedTextBox5.Mask = "00-00-0000"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(234, 20)
        Me.MaskedTextBox5.TabIndex = 0
        Me.MaskedTextBox5.Visible = False
        '
        'DateTimePicker17
        '
        Me.DateTimePicker17.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker17.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker17.Location = New System.Drawing.Point(707, 335)
        Me.DateTimePicker17.Name = "DateTimePicker17"
        Me.DateTimePicker17.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker17.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DateTimePicker17, "Click For Add Date Of Permanent")
        Me.DateTimePicker17.Visible = False
        '
        'DateTimePicker18
        '
        Me.DateTimePicker18.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker18.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker18.Location = New System.Drawing.Point(707, 311)
        Me.DateTimePicker18.Name = "DateTimePicker18"
        Me.DateTimePicker18.Size = New System.Drawing.Size(14, 20)
        Me.DateTimePicker18.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DateTimePicker18, "Click For Add Date Of Joning")
        Me.DateTimePicker18.Visible = False
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.BackColor = System.Drawing.Color.MintCream
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "SuspendENDDate", True))
        Me.MaskedTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(480, 335)
        Me.MaskedTextBox4.Mask = "00-00-0000"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(234, 20)
        Me.MaskedTextBox4.TabIndex = 1
        Me.MaskedTextBox4.Visible = False
        '
        'NameLabel2
        '
        Me.NameLabel2.BackColor = System.Drawing.Color.White
        Me.NameLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_App_AuthorityBindingSource, "Name", True))
        Me.NameLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel2.Location = New System.Drawing.Point(1022, 68)
        Me.NameLabel2.Name = "NameLabel2"
        Me.NameLabel2.Size = New System.Drawing.Size(161, 20)
        Me.NameLabel2.TabIndex = 58
        Me.NameLabel2.Text = "Label7"
        Me.NameLabel2.Visible = False
        '
        'HODNameComboBox
        '
        Me.HODNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "DirectReportingTo", True))
        Me.HODNameComboBox.DataSource = Me.View_HODBindingSource
        Me.HODNameComboBox.DisplayMember = "HODName"
        Me.HODNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HODNameComboBox.FormattingEnabled = True
        Me.HODNameComboBox.Location = New System.Drawing.Point(1173, 462)
        Me.HODNameComboBox.Name = "HODNameComboBox"
        Me.HODNameComboBox.Size = New System.Drawing.Size(10, 21)
        Me.HODNameComboBox.TabIndex = 1212122
        Me.HODNameComboBox.ValueMember = "HODName"
        Me.HODNameComboBox.Visible = False
        '
        'View_HODBindingSource
        '
        Me.View_HODBindingSource.DataMember = "tbl_Hrm_Employment_View_HOD"
        Me.View_HODBindingSource.DataSource = Me.Tbl_Hrm_EmploymentBindingSource
        '
        'View_HOD_NewBindingSource
        '
        Me.View_HOD_NewBindingSource.DataMember = "View_HOD_New"
        Me.View_HOD_NewBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_Dept1BindingSource
        '
        Me.Tbl_HRM_Dept1BindingSource.DataMember = "tbl_HRM_Dept1"
        Me.Tbl_HRM_Dept1BindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_SectionBindingSource
        '
        Me.Tbl_HRM_SectionBindingSource.DataMember = "tbl_HRM_Dept_tbl_HRM_Section"
        Me.Tbl_HRM_SectionBindingSource.DataSource = Me.Tbl_HRM_DeptBindingSource
        '
        'Tbl_HRM_DeptBindingSource
        '
        Me.Tbl_HRM_DeptBindingSource.DataMember = "tbl_HRM_Dept"
        Me.Tbl_HRM_DeptBindingSource.DataSource = Me.DSHRM
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TabControl1)
        Me.Panel2.Location = New System.Drawing.Point(142, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1013, 533)
        Me.Panel2.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.LinkLabel18)
        Me.Panel3.Controls.Add(Me.LinkLabel3)
        Me.Panel3.Controls.Add(Me.LinkLabel2)
        Me.Panel3.Controls.Add(Me.LinkLabel1)
        Me.Panel3.Location = New System.Drawing.Point(5, 109)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(134, 107)
        Me.Panel3.TabIndex = 7
        '
        'LinkLabel18
        '
        Me.LinkLabel18.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel18.ForeColor = System.Drawing.Color.White
        Me.LinkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel18.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel18.Location = New System.Drawing.Point(2, 79)
        Me.LinkLabel18.Name = "LinkLabel18"
        Me.LinkLabel18.Size = New System.Drawing.Size(134, 22)
        Me.LinkLabel18.TabIndex = 10
        Me.LinkLabel18.TabStop = True
        Me.LinkLabel18.Text = "Suspension"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel3.ForeColor = System.Drawing.Color.White
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel3.Location = New System.Drawing.Point(2, 54)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(134, 22)
        Me.LinkLabel3.TabIndex = 9
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Salary Data"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.White
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(2, 30)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(134, 22)
        Me.LinkLabel2.TabIndex = 8
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Official Data"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Silver
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(2, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(134, 22)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Personal Data"
        '
        'Timer1
        '
        '
        'CardStatusLabel1
        '
        Me.CardStatusLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_CardBindingSource, "CardStatus", True))
        Me.CardStatusLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.CardStatusLabel1.Location = New System.Drawing.Point(1032, 54)
        Me.CardStatusLabel1.Name = "CardStatusLabel1"
        Me.CardStatusLabel1.Size = New System.Drawing.Size(100, 27)
        Me.CardStatusLabel1.TabIndex = 10
        Me.CardStatusLabel1.Text = "Label6"
        '
        'CardNoLabel3
        '
        Me.CardNoLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource, "CardNo", True))
        Me.CardNoLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.CardNoLabel3.Location = New System.Drawing.Point(1148, 64)
        Me.CardNoLabel3.Name = "CardNoLabel3"
        Me.CardNoLabel3.Size = New System.Drawing.Size(100, 23)
        Me.CardNoLabel3.TabIndex = 69
        Me.CardNoLabel3.Text = "Label7"
        '
        'View_Rpt_HR_EmpData_ActiveNonActiveBindingSource
        '
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource.DataMember = "View_Rpt_HR_EmpData_ActiveNonActive"
        Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource.DataSource = Me.DSHRM
        '
        'EmpIDLabel3
        '
        Me.EmpIDLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource, "EmpID", True))
        Me.EmpIDLabel3.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpIDLabel3.Location = New System.Drawing.Point(1083, 76)
        Me.EmpIDLabel3.Name = "EmpIDLabel3"
        Me.EmpIDLabel3.Size = New System.Drawing.Size(100, 23)
        Me.EmpIDLabel3.TabIndex = 69
        Me.EmpIDLabel3.Text = "Label7"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.RadioButton1)
        Me.Panel4.Controls.Add(Me.RadioButton3)
        Me.Panel4.Controls.Add(Me.RadioButton2)
        Me.Panel4.Location = New System.Drawing.Point(489, 68)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(204, 39)
        Me.Panel4.TabIndex = 70
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(159, 10)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(36, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "All"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(75, 10)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Non-Active"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 10)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Active"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'CardNoLabel2
        '
        Me.CardNoLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_CardBindingSource, "CardNo", True))
        Me.CardNoLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.CardNoLabel2.Location = New System.Drawing.Point(796, 70)
        Me.CardNoLabel2.Name = "CardNoLabel2"
        Me.CardNoLabel2.Size = New System.Drawing.Size(100, 18)
        Me.CardNoLabel2.TabIndex = 8
        Me.CardNoLabel2.Text = "Label6"
        '
        'EmpIDLabel2
        '
        Me.EmpIDLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "EmpID", True))
        Me.EmpIDLabel2.ForeColor = System.Drawing.SystemColors.Control
        Me.EmpIDLabel2.Location = New System.Drawing.Point(1019, 73)
        Me.EmpIDLabel2.Name = "EmpIDLabel2"
        Me.EmpIDLabel2.Size = New System.Drawing.Size(100, 23)
        Me.EmpIDLabel2.TabIndex = 9
        Me.EmpIDLabel2.Text = "Label6"
        '
        'SaveFileDialog1
        '
        '
        'EmpIDTextBox
        '
        Me.EmpIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.EmpIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpIDTextBox.Enabled = False
        Me.EmpIDTextBox.ForeColor = System.Drawing.Color.Black
        Me.EmpIDTextBox.Location = New System.Drawing.Point(1046, 54)
        Me.EmpIDTextBox.Name = "EmpIDTextBox"
        Me.EmpIDTextBox.ReadOnly = True
        Me.EmpIDTextBox.Size = New System.Drawing.Size(100, 13)
        Me.EmpIDTextBox.TabIndex = 2
        Me.EmpIDTextBox.Visible = False
        '
        'Tbl_HRM_Dept_NewTableAdapter
        '
        Me.Tbl_HRM_Dept_NewTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_HRM_Dept_NewTableAdapter = Me.Tbl_HRM_Dept_NewTableAdapter
        Me.TableAdapterManager1.tbl_HRM_Grade_NEW2TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Grade_NEWTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Section_NewTableAdapter = Me.Tbl_HRM_Section_NewTableAdapter
        Me.TableAdapterManager1.tbl_Pro_VendorTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSDeptTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.View_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager1.View_Inactive_EmpTableAdapter = Nothing
        '
        'Tbl_HRM_Section_NewTableAdapter
        '
        Me.Tbl_HRM_Section_NewTableAdapter.ClearBeforeFill = True
        '
        'SectionIDLabel
        '
        Me.SectionIDLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "SectionID", True))
        Me.SectionIDLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.SectionIDLabel.Location = New System.Drawing.Point(1156, 84)
        Me.SectionIDLabel.Name = "SectionIDLabel"
        Me.SectionIDLabel.Size = New System.Drawing.Size(100, 18)
        Me.SectionIDLabel.TabIndex = 39
        Me.SectionIDLabel.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "Name", True))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(699, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 20)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_HRM_Emp_InfoBindingSource, "EmpPic", True))
        Me.PictureBox1.Location = New System.Drawing.Point(913, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Tbl_HRM_Emp_InfoBindingSource, "EmpStatus", True))
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(699, 89)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox1.TabIndex = 76
        Me.CheckBox1.Text = "Emp. Status:"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'View_Inactive_EmpBindingSource
        '
        Me.View_Inactive_EmpBindingSource.DataMember = "View_Inactive_Emp"
        Me.View_Inactive_EmpBindingSource.DataSource = Me.DSDept
        '
        'View_Inactive_EmpTableAdapter
        '
        Me.View_Inactive_EmpTableAdapter.ClearBeforeFill = True
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_MIS_User_DeptBindingSource
        '
        Me.Tbl_MIS_User_DeptBindingSource.DataMember = "tbl_MIS_User_Dept"
        Me.Tbl_MIS_User_DeptBindingSource.DataSource = Me.DSUser
        '
        'Tbl_MIS_User_DeptTableAdapter
        '
        Me.Tbl_MIS_User_DeptTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager2.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_User_DeptTableAdapter = Me.Tbl_MIS_User_DeptTableAdapter
        Me.TableAdapterManager2.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.UsersTableAdapter = Nothing
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(20, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 77
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_JobTypeTableAdapter
        '
        Me.Tbl_HRM_JobTypeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_QualficationTableAdapter
        '
        Me.Tbl_HRM_QualficationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_ShiftTableAdapter
        '
        Me.Tbl_HRM_ShiftTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_GradeTableAdapter
        '
        Me.Tbl_HRM_GradeTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_EmploymentTableAdapter
        '
        Me.Tbl_Hrm_EmploymentTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_EmpCatagoryTableAdapter
        '
        Me.Tbl_HRM_EmpCatagoryTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Leave_ReasonTableAdapter
        '
        Me.Tbl_HRM_Leave_ReasonTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_BankTableAdapter
        '
        Me.Tbl_HRM_BankTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_SalaryTableAdapter
        '
        Me.Tbl_Acc_SalaryTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_FinancialPeriodTableAdapter
        '
        Me.Tbl_Acc_FinancialPeriodTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_NoticesTableAdapter
        '
        Me.Tbl_Hrm_Emp_NoticesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Designation1TableAdapter
        '
        Me.Tbl_HRM_Designation1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_Salary1TableAdapter
        '
        Me.Tbl_Acc_Salary1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_App_AuthorityTableAdapter
        '
        Me.Tbl_HRM_App_AuthorityTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.tbl_HRM_Emp_Info1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_Designation1BindingSource
        '
        Me.Tbl_HRM_Designation1BindingSource.DataMember = "tbl_HRM_Designation1"
        Me.Tbl_HRM_Designation1BindingSource.DataSource = Me.DSHRM
        '
        'Tbl_Acc_Salary1BindingSource
        '
        Me.Tbl_Acc_Salary1BindingSource.DataMember = "tbl_Acc_Salary1"
        Me.Tbl_Acc_Salary1BindingSource.DataSource = Me.DSHRM
        '
        'View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter
        '
        Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_DeptTableAdapter
        '
        Me.Tbl_HRM_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Emp_InfoTableAdapter
        '
        Me.Tbl_HRM_Emp_InfoTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_Dept1TableAdapter
        '
        Me.Tbl_HRM_Dept1TableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_Salary_NewTableAdapter
        '
        Me.Tbl_Acc_Salary_NewTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Acc_Salary2BindingSource
        '
        Me.Tbl_Acc_Salary2BindingSource.DataMember = "tbl_Acc_Salary2"
        Me.Tbl_Acc_Salary2BindingSource.DataSource = Me.DSHRM
        '
        'Tbl_Acc_Salary2TableAdapter
        '
        Me.Tbl_Acc_Salary2TableAdapter.ClearBeforeFill = True
        '
        'View_HODTableAdapter
        '
        Me.View_HODTableAdapter.ClearBeforeFill = True
        '
        'View_HOD_NewTableAdapter
        '
        Me.View_HOD_NewTableAdapter.ClearBeforeFill = True
        '
        'EmploymentIDLabel1
        '
        Me.EmploymentIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_EmploymentBindingSource, "EmploymentID", True))
        Me.EmploymentIDLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.EmploymentIDLabel1.Location = New System.Drawing.Point(430, 676)
        Me.EmploymentIDLabel1.Name = "EmploymentIDLabel1"
        Me.EmploymentIDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.EmploymentIDLabel1.TabIndex = 78
        Me.EmploymentIDLabel1.Text = "Label11"
        '
        'View_HRM_Leave_ReasonTableAdapter
        '
        Me.View_HRM_Leave_ReasonTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Bus_Route_InfoTableAdapter
        '
        Me.Tbl_Bus_Route_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.tbl_Bus_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Bus_OwnerTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Bus_Route_FareTableAdapter = Nothing
        Me.TableAdapterManager3.tbl_Bus_Route_InfoTableAdapter = Me.Tbl_Bus_Route_InfoTableAdapter
        Me.TableAdapterManager3.UpdateOrder = ERP_HRMS.DSBusInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_disability_descptionTableAdapter
        '
        Me.Tbl_disability_descptionTableAdapter.ClearBeforeFill = True
        '
        'DSEMP
        '
        Me.DSEMP.DataSetName = "DSEMP"
        Me.DSEMP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_Emp_Info_SAVEBindingSource
        '
        Me.Tbl_HRM_Emp_Info_SAVEBindingSource.DataMember = "tbl_HRM_Emp_Info_SAVE"
        Me.Tbl_HRM_Emp_Info_SAVEBindingSource.DataSource = Me.DSEMP
        '
        'Tbl_HRM_Emp_Info_SAVETableAdapter
        '
        Me.Tbl_HRM_Emp_Info_SAVETableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager4
        '
        Me.TableAdapterManager4.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager4.tbl_HRM_Emp_Info_SAVE_NEWTableAdapter = Nothing
        Me.TableAdapterManager4.tbl_HRM_Emp_Info_SAVETableAdapter = Me.Tbl_HRM_Emp_Info_SAVETableAdapter
        Me.TableAdapterManager4.UpdateOrder = ERP_HRMS.DSEMPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_Emp_Info_SAVE_NEWBindingSource
        '
        Me.Tbl_HRM_Emp_Info_SAVE_NEWBindingSource.DataMember = "tbl_HRM_Emp_Info_SAVE_NEW"
        Me.Tbl_HRM_Emp_Info_SAVE_NEWBindingSource.DataSource = Me.DSEMP
        '
        'Tbl_HRM_Emp_Info_SAVE_NEWTableAdapter
        '
        Me.Tbl_HRM_Emp_Info_SAVE_NEWTableAdapter.ClearBeforeFill = True
        '
        'View_Emp_Report_TOTableAdapter
        '
        Me.View_Emp_Report_TOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager5
        '
        Me.TableAdapterManager5.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager5.Connection = Nothing
        Me.TableAdapterManager5.UpdateOrder = ERP_HRMS.DSReportToTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_Emp_Report_TO_NEWTableAdapter
        '
        Me.View_Emp_Report_TO_NEWTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager6
        '
        Me.TableAdapterManager6.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager6.Connection = Nothing
        Me.TableAdapterManager6.UpdateOrder = ERP_HRMS.DSRPTTOTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label31
        '
        Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label31.ForeColor = System.Drawing.Color.Black
        Label31.Location = New System.Drawing.Point(195, 90)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(51, 20)
        Label31.TabIndex = 121212123
        Label31.Text = "Req No.:"
        Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_HRM_Emp_InfoBindingSource, "ReqNO", True))
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(246, 91)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(43, 20)
        Me.TextBox6.TabIndex = 121212122
        '
        'frmEmpManagment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1293, 719)
        Me.Controls.Add(Me.HODNameComboBox)
        Me.Controls.Add(Me.NameLabel2)
        Me.Controls.Add(Me.EmploymentIDLabel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SectionIDLabel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.EmpIDLabel3)
        Me.Controls.Add(Me.CardNoLabel3)
        Me.Controls.Add(Me.CardStatusLabel1)
        Me.Controls.Add(Me.EmpIDLabel2)
        Me.Controls.Add(Me.CardNoLabel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmpIDTextBox)
        Me.Name = "frmEmpManagment"
        Me.Text = " Employee Information"
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.Tbl_HRM_Emp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_disability_descptionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_QualficationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpPicPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSEmpInfo.ResumeLayout(False)
        Me.CMSSearchNIC.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.View_Emp_Report_TO_NEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSRPTTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Emp_Report_TOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSReportTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_EmpCatagoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_EmploymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Tbl_HRM_BankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.View_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSDept, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_Hrm_Emp_NoticesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Leave_ReasonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_HRM_JobTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Section_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Dept_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        CType(Me.Tbl_Bus_Route_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBusInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_SalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.Tbl_Acc_Salary_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_App_AuthorityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_FinancialPeriodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.Tbl_Acc_SalaryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Acc_SalaryBindingNavigator.ResumeLayout(False)
        Me.Tbl_Acc_SalaryBindingNavigator.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.View_HODBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_HOD_NewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Dept1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Inactive_EmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MIS_User_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Designation1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_Salary1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Acc_Salary2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSEMP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Info_SAVEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Info_SAVE_NEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSHRMTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents CardNoComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_JobTypeBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_JobTypeTableAdapter As DSHRMTableAdapters.tbl_HRM_JobTypeTableAdapter
    Friend WithEvents Tbl_HRM_QualficationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_QualficationTableAdapter As DSHRMTableAdapters.tbl_HRM_QualficationTableAdapter
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents Tbl_Hrm_EmploymentBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_EmploymentTableAdapter As DSHRMTableAdapters.tbl_Hrm_EmploymentTableAdapter
    Friend WithEvents Tbl_HRM_EmpCatagoryBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_EmpCatagoryTableAdapter As DSHRMTableAdapters.tbl_HRM_EmpCatagoryTableAdapter
    Friend WithEvents Tbl_HRM_Leave_ReasonBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Leave_ReasonTableAdapter As DSHRMTableAdapters.tbl_HRM_Leave_ReasonTableAdapter
    Friend WithEvents Tbl_HRM_BankBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BankTableAdapter As DSHRMTableAdapters.tbl_HRM_BankTableAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BankNameComboBox As ComboBox
    Friend WithEvents BankAccountNOTextBox As TextBox
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents EOBINOTextBox As TextBox
    Friend WithEvents NTNNOTextBox As TextBox
    Friend WithEvents SSCNOTextBox As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents EmpStatusCheckBox As CheckBox
    Friend WithEvents ReasonComboBox As ComboBox
    Friend WithEvents LeaveDateMaskedTextBox As MaskedTextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CatagoryNameComboBox As ComboBox
    Friend WithEvents EmploymentNameComboBox As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents GradeNameComboBox As ComboBox
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents JobTypeNameComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents EmpProvinceComboBox As ComboBox
    Friend WithEvents QualficationNameComboBox As ComboBox
    Friend WithEvents Uploadimage As Button
    Friend WithEvents PermanentAddressTextBox As TextBox
    Friend WithEvents EmpCityTextBox As TextBox
    Friend WithEvents MotherNameTextBox As TextBox
    Friend WithEvents FatherNameTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ContactNoMaskedTextBox As MaskedTextBox
    Friend WithEvents MaritalStatusComboBox As ComboBox
    Friend WithEvents BloodGroupComboBox As ComboBox
    Friend WithEvents CNICNOMaskedTextBox As MaskedTextBox
    Friend WithEvents ReligionComboBox As ComboBox
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents SalutationComboBox As ComboBox
    Friend WithEvents BranchEffectiveDateMaskedTextBox As MaskedTextBox
    Friend WithEvents GradeEffectiveDateMaskedTextBox As MaskedTextBox
    Friend WithEvents ShiftEffectiveDateMaskedTextBox As MaskedTextBox
    Friend WithEvents JobTypeEffectiveDateMaskedTextBox As MaskedTextBox
    Friend WithEvents EmpPicPictureBox As PictureBox
    Friend WithEvents Tbl_Acc_SalaryTableAdapter As DSHRMTableAdapters.tbl_Acc_SalaryTableAdapter
    Friend WithEvents Tbl_Acc_FinancialPeriodBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_FinancialPeriodTableAdapter As DSHRMTableAdapters.tbl_Acc_FinancialPeriodTableAdapter
    Friend WithEvents Tbl_Acc_SalaryBindingSource As BindingSource
    Friend WithEvents SectEffectiveDateMaskedTextBox As MaskedTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents LinkLabel6 As LinkLabel
    Friend WithEvents LinkLabel7 As LinkLabel
    Friend WithEvents NoticeNo As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LinkLabel8 As LinkLabel
    Friend WithEvents FinancialPeriodComboBox As ComboBox
    Friend WithEvents PaymentModeComboBox As ComboBox
    Friend WithEvents UnionFundTextBox As TextBox
    Friend WithEvents RentDeductionTextBox As TextBox
    Friend WithEvents TaxDeductionTextBox As TextBox
    Friend WithEvents EOBITextBox As TextBox
    Friend WithEvents SpecialAllowanceTextBox As TextBox
    Friend WithEvents EducationAllowanceTextBox As TextBox
    Friend WithEvents TravelAllowanceTextBox As TextBox
    Friend WithEvents MealAllowanceTextBox As TextBox
    Friend WithEvents BasicSalaryTextBox As TextBox
    Friend WithEvents SalIDTextBox As TextBox
    Friend WithEvents ActivationStatusCheckBox As CheckBox
    Friend WithEvents ActivationDateMaskedTextBox As MaskedTextBox
    Friend WithEvents EffectedFromDateMaskedTextBox As MaskedTextBox
    Friend WithEvents PESSIContCheckBox As CheckBox
    Friend WithEvents LinkLabel12 As LinkLabel
    Friend WithEvents LinkLabel11 As LinkLabel
    Friend WithEvents LinkLabel10 As LinkLabel
    Friend WithEvents LinkLabel9 As LinkLabel
    Friend WithEvents LinkLabel15 As LinkLabel
    Friend WithEvents Tbl_Hrm_Emp_NoticesBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_NoticesTableAdapter As DSHRMTableAdapters.tbl_Hrm_Emp_NoticesTableAdapter
    Friend WithEvents NoticeTypeComboBox As ComboBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LinkLabel16 As LinkLabel
    Friend WithEvents Button3 As Button
    Friend WithEvents Tbl_Acc_SalaryBindingNavigator As BindingNavigator
    Friend WithEvents AddSalary As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox7 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButton10 As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents SaveSalary As ToolStripButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LinkLabel14 As LinkLabel
    Friend WithEvents CMSEmpInfo As ContextMenuStrip
    Friend WithEvents SearchByNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSName As ToolStripTextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents CardStatusLabel1 As Label
    Friend WithEvents RefrenceTextBox As TextBox
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents GraduityDateMaskedTextBox As MaskedTextBox
    Friend WithEvents DateOfPermanentMaskedTextBox As MaskedTextBox
    Friend WithEvents DateOfJoning As MaskedTextBox
    Friend WithEvents EmployeeExperianceTextBox As TextBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents CardStatusCheckBox As CheckBox
    Friend WithEvents Save As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents View_Rpt_HR_EmpData_ActiveNonActiveBindingSource As BindingSource
    Friend WithEvents View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter As DSHRMTableAdapters.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter
    Friend WithEvents CardNoLabel3 As Label
    Friend WithEvents EmpIDLabel3 As Label
    Friend WithEvents RemoveFilterToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CMSSearchNIC As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtSearchNIC As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents LinkLabel13 As LinkLabel
    Friend WithEvents NoticeTypeComboBox1 As ComboBox
    Friend WithEvents EmergencyNoMaskedTextBox As MaskedTextBox
    Friend WithEvents CurrentAddressTextBox As TextBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents EndDateMaskedTextBox As MaskedTextBox
    Friend WithEvents StartDateMaskedTextBox As MaskedTextBox
    Friend WithEvents CopyNoTextBox As TextBox
    Friend WithEvents ConteenDeductTextBox As TextBox
    Friend WithEvents backbtn As RadioButton
    Friend WithEvents frntbtn As RadioButton
    Friend WithEvents printbtn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Tbl_HRM_Designation1BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Designation1TableAdapter As DSHRMTableAdapters.tbl_HRM_Designation1TableAdapter
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents DateTimePicker9 As DateTimePicker
    Friend WithEvents DateTimePicker8 As DateTimePicker
    Friend WithEvents DateTimePicker7 As DateTimePicker
    Friend WithEvents DateTimePicker12 As DateTimePicker
    Friend WithEvents DateTimePicker11 As DateTimePicker
    Friend WithEvents DateTimePicker10 As DateTimePicker
    Friend WithEvents DateTimePicker13 As DateTimePicker
    Friend WithEvents DateTimePicker14 As DateTimePicker
    Friend WithEvents HiringDescTextBox As TextBox
    Friend WithEvents HiringCriteriaComboBox As ComboBox
    Friend WithEvents DateOfBirthMaskedTextBox As MaskedTextBox
    Friend WithEvents AddCopyBtn As Button
    Friend WithEvents CardNoLabel2 As Label
    Friend WithEvents Tbl_Acc_Salary1BindingSource As BindingSource
    Friend WithEvents Tbl_Acc_Salary1TableAdapter As DSHRMTableAdapters.tbl_Acc_Salary1TableAdapter
    Friend WithEvents EmpIDLabel2 As Label
    Friend WithEvents Tbl_HRM_App_AuthorityBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_App_AuthorityTableAdapter As DSHRMTableAdapters.tbl_HRM_App_AuthorityTableAdapter
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SenStatusCheckBox As CheckBox
    Friend WithEvents IncrementStatusLabel1 As Label
    Friend WithEvents AccommodationTextBox As TextBox
    Friend WithEvents NetGrossSalaryLabel1 As Label
    Friend WithEvents AddNoticeBtn As Button
    Friend WithEvents BindingNavigator4 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents Button4 As Button
    Friend WithEvents NameLabel2 As Label
    Friend WithEvents EmpIDTextBox As TextBox
    Friend WithEvents LinkLabel17 As LinkLabel
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_Emp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_InfoTableAdapter As DSHRMTableAdapters.tbl_HRM_Emp_InfoTableAdapter
    Friend WithEvents Tbl_HRM_Dept1BindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Dept1TableAdapter As DSHRMTableAdapters.tbl_HRM_Dept1TableAdapter
    Friend WithEvents HODNameComboBox As ComboBox
    Friend WithEvents Tbl_Acc_Salary_NewBindingSource As BindingSource
    Friend WithEvents Tbl_Acc_Salary_NewTableAdapter As DSHRMTableAdapters.tbl_Acc_Salary_NewTableAdapter
    Friend WithEvents DSDept As DSDept
    Friend WithEvents Tbl_HRM_Dept_NewBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Dept_NewTableAdapter As DSDeptTableAdapters.tbl_HRM_Dept_NewTableAdapter
    Friend WithEvents TableAdapterManager1 As DSDeptTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_Section_NewTableAdapter As DSDeptTableAdapters.tbl_HRM_Section_NewTableAdapter
    Friend WithEvents Tbl_HRM_Section_NewBindingSource As BindingSource
    Friend WithEvents SectionIDLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Tbl_Acc_Salary2BindingSource As BindingSource
    Friend WithEvents Tbl_Acc_Salary2TableAdapter As DSHRMTableAdapters.tbl_Acc_Salary2TableAdapter
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents View_Inactive_EmpBindingSource As BindingSource
    Friend WithEvents View_Inactive_EmpTableAdapter As DSDeptTableAdapters.View_Inactive_EmpTableAdapter
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents DSUser As DSUser
    Friend WithEvents Tbl_MIS_User_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_MIS_User_DeptTableAdapter As DSUserTableAdapters.tbl_MIS_User_DeptTableAdapter
    Friend WithEvents TableAdapterManager2 As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents View_HODBindingSource As BindingSource
    Friend WithEvents View_HODTableAdapter As DSHRMTableAdapters.View_HODTableAdapter
    Friend WithEvents View_HOD_NewBindingSource As BindingSource
    Friend WithEvents View_HOD_NewTableAdapter As DSHRMTableAdapters.View_HOD_NewTableAdapter
    Friend WithEvents EmploymentIDLabel1 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents DateTimePicker15 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents View_HRM_Leave_ReasonBindingSource As BindingSource
    Friend WithEvents View_HRM_Leave_ReasonTableAdapter As DSDeptTableAdapters.View_HRM_Leave_ReasonTableAdapter
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker17 As DateTimePicker
    Friend WithEvents DateTimePicker18 As DateTimePicker
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents LinkLabel18 As LinkLabel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DSBusInfo As DSBusInfo
    Friend WithEvents Tbl_Bus_Route_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Bus_Route_InfoTableAdapter As DSBusInfoTableAdapters.tbl_Bus_Route_InfoTableAdapter
    Friend WithEvents TableAdapterManager3 As DSBusInfoTableAdapters.TableAdapterManager
    Friend WithEvents Button11 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Tbl_disability_descptionBindingSource As BindingSource
    Friend WithEvents Tbl_disability_descptionTableAdapter As DSHRMTableAdapters.tbl_disability_descptionTableAdapter
    Friend WithEvents LinkLabel19 As LinkLabel
    Friend WithEvents DescriptionComboBox As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents DSEMP As DSEMP
    Friend WithEvents Tbl_HRM_Emp_Info_SAVEBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Info_SAVETableAdapter As DSEMPTableAdapters.tbl_HRM_Emp_Info_SAVETableAdapter
    Friend WithEvents TableAdapterManager4 As DSEMPTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_Emp_Info_SAVE_NEWBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Info_SAVE_NEWTableAdapter As DSEMPTableAdapters.tbl_HRM_Emp_Info_SAVE_NEWTableAdapter
    Friend WithEvents Button12 As Button
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents DSReportTo As DSReportTo
    Friend WithEvents View_Emp_Report_TOBindingSource As BindingSource
    Friend WithEvents View_Emp_Report_TOTableAdapter As DSReportToTableAdapters.View_Emp_Report_TOTableAdapter
    Friend WithEvents TableAdapterManager5 As DSReportToTableAdapters.TableAdapterManager
    Friend WithEvents DSRPTTO As DSRPTTO
    Friend WithEvents View_Emp_Report_TO_NEWBindingSource As BindingSource
    Friend WithEvents View_Emp_Report_TO_NEWTableAdapter As DSRPTTOTableAdapters.View_Emp_Report_TO_NEWTableAdapter
    Friend WithEvents TableAdapterManager6 As DSRPTTOTableAdapters.TableAdapterManager
    Friend WithEvents TextBox6 As TextBox
End Class
