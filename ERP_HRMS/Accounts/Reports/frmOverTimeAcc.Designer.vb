<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOverTimeAcc
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
        Dim DesigNameLabel As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Dim ShiftNameLabel As System.Windows.Forms.Label
        Dim CatagoryNameLabel As System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PTPaymentDetails = New System.Windows.Forms.RadioButton()
        Me.RadioTravel = New System.Windows.Forms.RadioButton()
        Me.Radio_Meal = New System.Windows.Forms.RadioButton()
        Me.RadioDTA = New System.Windows.Forms.RadioButton()
        Me.PndStatus = New System.Windows.Forms.RadioButton()
        Me.Radio_OT = New System.Windows.Forms.RadioButton()
        Me.NormalExtraSpecial = New System.Windows.Forms.RadioButton()
        Me.OTPymtSummBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.ByShift = New System.Windows.Forms.RadioButton()
        Me.ByBranch = New System.Windows.Forms.RadioButton()
        Me.RadioDateCard = New System.Windows.Forms.RadioButton()
        Me.RadioSpecial = New System.Windows.Forms.RadioButton()
        Me.RadioByDate = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.Tbl_HRM_ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpecialFilterBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstCards = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cmbSelectCard = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSPayRoll = New ERP_HRMS.DSPayRoll()
        Me.DeptPanel = New System.Windows.Forms.Panel()
        Me.DesigBTn = New System.Windows.Forms.RadioButton()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RadioDeptAll = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Section = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MainDept = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_CardTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_ShiftTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CatagoryNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_EmpCatagoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ShiftNameComboBox = New System.Windows.Forms.ComboBox()
        Me.OT_Type = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tocard = New System.Windows.Forms.TextBox()
        Me.Frmcard = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.NonActiveBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_EmpCatagoryTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_EmpCatagoryTableAdapter()
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.TableAdapterManager2 = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        DesigNameLabel = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        ShiftNameLabel = New System.Windows.Forms.Label()
        CatagoryNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpecialFilterBox.SuspendLayout()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeptPanel.SuspendLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Tbl_HRM_EmpCatagoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DesigNameLabel
        '
        DesigNameLabel.AutoSize = True
        DesigNameLabel.Location = New System.Drawing.Point(21, 90)
        DesigNameLabel.Name = "DesigNameLabel"
        DesigNameLabel.Size = New System.Drawing.Size(87, 17)
        DesigNameLabel.TabIndex = 29
        DesigNameLabel.Text = "Designation:"
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(9, 119)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(89, 20)
        BranchNameLabel.TabIndex = 58
        BranchNameLabel.Text = "Branch:"
        '
        'ShiftNameLabel
        '
        ShiftNameLabel.ForeColor = System.Drawing.Color.Black
        ShiftNameLabel.Location = New System.Drawing.Point(9, 149)
        ShiftNameLabel.Name = "ShiftNameLabel"
        ShiftNameLabel.Size = New System.Drawing.Size(89, 20)
        ShiftNameLabel.TabIndex = 57
        ShiftNameLabel.Text = "Shift:"
        '
        'CatagoryNameLabel
        '
        CatagoryNameLabel.ForeColor = System.Drawing.Color.Black
        CatagoryNameLabel.Location = New System.Drawing.Point(9, 180)
        CatagoryNameLabel.Name = "CatagoryNameLabel"
        CatagoryNameLabel.Size = New System.Drawing.Size(89, 17)
        CatagoryNameLabel.TabIndex = 60
        CatagoryNameLabel.Text = "Catagory:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1094, 40)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Over Time Reports"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton10)
        Me.GroupBox2.Controls.Add(Me.RadioButton9)
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton8)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.PTPaymentDetails)
        Me.GroupBox2.Controls.Add(Me.RadioTravel)
        Me.GroupBox2.Controls.Add(Me.Radio_Meal)
        Me.GroupBox2.Controls.Add(Me.RadioDTA)
        Me.GroupBox2.Controls.Add(Me.PndStatus)
        Me.GroupBox2.Controls.Add(Me.Radio_OT)
        Me.GroupBox2.Controls.Add(Me.NormalExtraSpecial)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(28, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(313, 375)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Selector"
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(17, 257)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(250, 21)
        Me.RadioButton10.TabIndex = 44
        Me.RadioButton10.Text = "OverTime Pre Calculation Summary"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Black
        Me.RadioButton9.Location = New System.Drawing.Point(17, 278)
        Me.RadioButton9.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(188, 21)
        Me.RadioButton9.TabIndex = 43
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "OverTime Pre Calculated "
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(17, 215)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(152, 21)
        Me.RadioButton7.TabIndex = 42
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Monthlly Over Time "
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(17, 152)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(182, 21)
        Me.RadioButton3.TabIndex = 41
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Over Tme Payment Slips"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(17, 341)
        Me.RadioButton6.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(158, 21)
        Me.RadioButton6.TabIndex = 40
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "OverTime Calculated"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(17, 194)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(214, 21)
        Me.RadioButton5.TabIndex = 39
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Over Time Payment Summary"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(17, 173)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(213, 21)
        Me.RadioButton2.TabIndex = 38
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Pending Over Time Activation"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(17, 47)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(198, 21)
        Me.RadioButton8.TabIndex = 36
        Me.RadioButton8.Text = "Employee Over Time Detail"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(17, 299)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(184, 21)
        Me.RadioButton1.TabIndex = 37
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Staff Over Time Payment"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PTPaymentDetails
        '
        Me.PTPaymentDetails.AutoSize = True
        Me.PTPaymentDetails.ForeColor = System.Drawing.Color.Black
        Me.PTPaymentDetails.Location = New System.Drawing.Point(17, 131)
        Me.PTPaymentDetails.Name = "PTPaymentDetails"
        Me.PTPaymentDetails.Size = New System.Drawing.Size(198, 21)
        Me.PTPaymentDetails.TabIndex = 35
        Me.PTPaymentDetails.TabStop = True
        Me.PTPaymentDetails.Text = "Over Time Payment Details"
        Me.PTPaymentDetails.UseVisualStyleBackColor = True
        '
        'RadioTravel
        '
        Me.RadioTravel.AutoSize = True
        Me.RadioTravel.ForeColor = System.Drawing.Color.Black
        Me.RadioTravel.Location = New System.Drawing.Point(17, 89)
        Me.RadioTravel.Name = "RadioTravel"
        Me.RadioTravel.Size = New System.Drawing.Size(200, 21)
        Me.RadioTravel.TabIndex = 27
        Me.RadioTravel.TabStop = True
        Me.RadioTravel.Text = "Travel Allowance Summary "
        Me.RadioTravel.UseVisualStyleBackColor = True
        '
        'Radio_Meal
        '
        Me.Radio_Meal.AutoSize = True
        Me.Radio_Meal.ForeColor = System.Drawing.Color.Black
        Me.Radio_Meal.Location = New System.Drawing.Point(17, 110)
        Me.Radio_Meal.Name = "Radio_Meal"
        Me.Radio_Meal.Size = New System.Drawing.Size(123, 21)
        Me.Radio_Meal.TabIndex = 26
        Me.Radio_Meal.TabStop = True
        Me.Radio_Meal.Text = "Meal Allowance"
        Me.Radio_Meal.UseVisualStyleBackColor = True
        '
        'RadioDTA
        '
        Me.RadioDTA.AutoSize = True
        Me.RadioDTA.ForeColor = System.Drawing.Color.Black
        Me.RadioDTA.Location = New System.Drawing.Point(17, 68)
        Me.RadioDTA.Name = "RadioDTA"
        Me.RadioDTA.Size = New System.Drawing.Size(190, 21)
        Me.RadioDTA.TabIndex = 25
        Me.RadioDTA.TabStop = True
        Me.RadioDTA.Text = "Daily Travelling Allowance"
        Me.RadioDTA.UseVisualStyleBackColor = True
        '
        'PndStatus
        '
        Me.PndStatus.AutoSize = True
        Me.PndStatus.ForeColor = System.Drawing.Color.Black
        Me.PndStatus.Location = New System.Drawing.Point(17, 320)
        Me.PndStatus.Name = "PndStatus"
        Me.PndStatus.Size = New System.Drawing.Size(181, 21)
        Me.PndStatus.TabIndex = 28
        Me.PndStatus.TabStop = True
        Me.PndStatus.Text = "Late Leaving Employees"
        Me.PndStatus.UseVisualStyleBackColor = True
        '
        'Radio_OT
        '
        Me.Radio_OT.AutoSize = True
        Me.Radio_OT.Checked = True
        Me.Radio_OT.ForeColor = System.Drawing.Color.Black
        Me.Radio_OT.Location = New System.Drawing.Point(17, 26)
        Me.Radio_OT.Name = "Radio_OT"
        Me.Radio_OT.Size = New System.Drawing.Size(127, 21)
        Me.Radio_OT.TabIndex = 1
        Me.Radio_OT.TabStop = True
        Me.Radio_OT.Text = "Daily Over Time"
        Me.Radio_OT.UseVisualStyleBackColor = True
        '
        'NormalExtraSpecial
        '
        Me.NormalExtraSpecial.AutoSize = True
        Me.NormalExtraSpecial.ForeColor = System.Drawing.Color.Black
        Me.NormalExtraSpecial.Location = New System.Drawing.Point(17, 236)
        Me.NormalExtraSpecial.Name = "NormalExtraSpecial"
        Me.NormalExtraSpecial.Size = New System.Drawing.Size(161, 21)
        Me.NormalExtraSpecial.TabIndex = 1
        Me.NormalExtraSpecial.TabStop = True
        Me.NormalExtraSpecial.Text = "All Types of Overtime"
        Me.NormalExtraSpecial.UseVisualStyleBackColor = True
        '
        'OTPymtSummBtn
        '
        Me.OTPymtSummBtn.AutoSize = True
        Me.OTPymtSummBtn.Location = New System.Drawing.Point(731, 706)
        Me.OTPymtSummBtn.Name = "OTPymtSummBtn"
        Me.OTPymtSummBtn.Size = New System.Drawing.Size(160, 17)
        Me.OTPymtSummBtn.TabIndex = 29
        Me.OTPymtSummBtn.Text = "Overtime Payment Summary "
        Me.OTPymtSummBtn.UseVisualStyleBackColor = True
        Me.OTPymtSummBtn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.ByShift)
        Me.GroupBox1.Controls.Add(Me.ByBranch)
        Me.GroupBox1.Controls.Add(Me.RadioDateCard)
        Me.GroupBox1.Controls.Add(Me.RadioSpecial)
        Me.GroupBox1.Controls.Add(Me.RadioByDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(29, 479)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 163)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selector"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(21, 137)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(103, 21)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.Text = "By Category"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'ByShift
        '
        Me.ByShift.AutoSize = True
        Me.ByShift.ForeColor = System.Drawing.Color.Black
        Me.ByShift.Location = New System.Drawing.Point(21, 115)
        Me.ByShift.Name = "ByShift"
        Me.ByShift.Size = New System.Drawing.Size(74, 21)
        Me.ByShift.TabIndex = 4
        Me.ByShift.Text = "By Shift"
        Me.ByShift.UseVisualStyleBackColor = True
        '
        'ByBranch
        '
        Me.ByBranch.AutoSize = True
        Me.ByBranch.ForeColor = System.Drawing.Color.Black
        Me.ByBranch.Location = New System.Drawing.Point(21, 91)
        Me.ByBranch.Name = "ByBranch"
        Me.ByBranch.Size = New System.Drawing.Size(91, 21)
        Me.ByBranch.TabIndex = 3
        Me.ByBranch.Text = "By Branch"
        Me.ByBranch.UseVisualStyleBackColor = True
        '
        'RadioDateCard
        '
        Me.RadioDateCard.AutoSize = True
        Me.RadioDateCard.ForeColor = System.Drawing.Color.Black
        Me.RadioDateCard.Location = New System.Drawing.Point(21, 43)
        Me.RadioDateCard.Name = "RadioDateCard"
        Me.RadioDateCard.Size = New System.Drawing.Size(185, 21)
        Me.RadioDateCard.TabIndex = 2
        Me.RadioDateCard.Text = "By Date And Card Range"
        Me.RadioDateCard.UseVisualStyleBackColor = True
        '
        'RadioSpecial
        '
        Me.RadioSpecial.AutoSize = True
        Me.RadioSpecial.ForeColor = System.Drawing.Color.Black
        Me.RadioSpecial.Location = New System.Drawing.Point(21, 67)
        Me.RadioSpecial.Name = "RadioSpecial"
        Me.RadioSpecial.Size = New System.Drawing.Size(280, 21)
        Me.RadioSpecial.TabIndex = 1
        Me.RadioSpecial.Text = "By Special Filter (Card And Date Range)"
        Me.RadioSpecial.UseVisualStyleBackColor = True
        '
        'RadioByDate
        '
        Me.RadioByDate.AutoSize = True
        Me.RadioByDate.Checked = True
        Me.RadioByDate.ForeColor = System.Drawing.Color.Black
        Me.RadioByDate.Location = New System.Drawing.Point(21, 19)
        Me.RadioByDate.Name = "RadioByDate"
        Me.RadioByDate.Size = New System.Drawing.Size(76, 21)
        Me.RadioByDate.TabIndex = 0
        Me.RadioByDate.TabStop = True
        Me.RadioByDate.Text = "By Date"
        Me.RadioByDate.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_ShiftBindingSource
        '
        Me.Tbl_HRM_ShiftBindingSource.DataMember = "tbl_HRM_Shift"
        Me.Tbl_HRM_ShiftBindingSource.DataSource = Me.DSHRM
        '
        'SpecialFilterBox
        '
        Me.SpecialFilterBox.Controls.Add(Me.Label4)
        Me.SpecialFilterBox.Controls.Add(Me.btnRemove)
        Me.SpecialFilterBox.Controls.Add(Me.lstCards)
        Me.SpecialFilterBox.Controls.Add(Me.btnAdd)
        Me.SpecialFilterBox.Controls.Add(Me.cmbSelectCard)
        Me.SpecialFilterBox.Enabled = False
        Me.SpecialFilterBox.Location = New System.Drawing.Point(104, 209)
        Me.SpecialFilterBox.Name = "SpecialFilterBox"
        Me.SpecialFilterBox.Size = New System.Drawing.Size(294, 166)
        Me.SpecialFilterBox.TabIndex = 44
        Me.SpecialFilterBox.TabStop = False
        Me.SpecialFilterBox.Text = "Special Filter"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "From Card:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.White
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(186, 121)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(94, 34)
        Me.btnRemove.TabIndex = 38
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'lstCards
        '
        Me.lstCards.BackColor = System.Drawing.Color.Gainsboro
        Me.lstCards.FormattingEnabled = True
        Me.lstCards.ItemHeight = 16
        Me.lstCards.Location = New System.Drawing.Point(41, 71)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.Size = New System.Drawing.Size(139, 84)
        Me.lstCards.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(186, 87)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 34)
        Me.btnAdd.TabIndex = 37
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cmbSelectCard
        '
        Me.cmbSelectCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSelectCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSelectCard.DataSource = Me.Tbl_HRM_CardBindingSource
        Me.cmbSelectCard.DisplayMember = "CardNo"
        Me.cmbSelectCard.FormattingEnabled = True
        Me.cmbSelectCard.Location = New System.Drawing.Point(41, 45)
        Me.cmbSelectCard.Name = "cmbSelectCard"
        Me.cmbSelectCard.Size = New System.Drawing.Size(139, 24)
        Me.cmbSelectCard.TabIndex = 1
        Me.cmbSelectCard.ValueMember = "CardNo"
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSPayRoll
        '
        'DSPayRoll
        '
        Me.DSPayRoll.DataSetName = "DSPayRoll"
        Me.DSPayRoll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeptPanel
        '
        Me.DeptPanel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DeptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptPanel.Controls.Add(Me.DesigBTn)
        Me.DeptPanel.Controls.Add(DesigNameLabel)
        Me.DeptPanel.Controls.Add(Me.DesigNameComboBox)
        Me.DeptPanel.Controls.Add(Me.RadioDeptAll)
        Me.DeptPanel.Controls.Add(Me.Label9)
        Me.DeptPanel.Controls.Add(Me.Section)
        Me.DeptPanel.Controls.Add(Me.Label11)
        Me.DeptPanel.Controls.Add(Me.MainDept)
        Me.DeptPanel.Controls.Add(Me.Label5)
        Me.DeptPanel.Controls.Add(Me.NameComboBox)
        Me.DeptPanel.Controls.Add(Me.DeptNameComboBox)
        Me.DeptPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptPanel.Location = New System.Drawing.Point(348, 500)
        Me.DeptPanel.Name = "DeptPanel"
        Me.DeptPanel.Size = New System.Drawing.Size(413, 177)
        Me.DeptPanel.TabIndex = 29
        '
        'DesigBTn
        '
        Me.DesigBTn.AutoSize = True
        Me.DesigBTn.Location = New System.Drawing.Point(21, 146)
        Me.DesigBTn.Name = "DesigBTn"
        Me.DesigBTn.Size = New System.Drawing.Size(101, 21)
        Me.DesigBTn.TabIndex = 31
        Me.DesigBTn.TabStop = True
        Me.DesigBTn.Text = "Designation"
        Me.DesigBTn.UseVisualStyleBackColor = True
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(124, 87)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(263, 24)
        Me.DesigNameComboBox.TabIndex = 30
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'RadioDeptAll
        '
        Me.RadioDeptAll.AutoSize = True
        Me.RadioDeptAll.Checked = True
        Me.RadioDeptAll.Location = New System.Drawing.Point(21, 119)
        Me.RadioDeptAll.Name = "RadioDeptAll"
        Me.RadioDeptAll.Size = New System.Drawing.Size(45, 21)
        Me.RadioDeptAll.TabIndex = 29
        Me.RadioDeptAll.TabStop = True
        Me.RadioDeptAll.Text = "All "
        Me.RadioDeptAll.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(411, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Select Appropriate Department"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Section
        '
        Me.Section.AutoSize = True
        Me.Section.Location = New System.Drawing.Point(144, 146)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(73, 21)
        Me.Section.TabIndex = 27
        Me.Section.Text = "Section"
        Me.Section.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(21, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Section:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainDept
        '
        Me.MainDept.AutoSize = True
        Me.MainDept.Location = New System.Drawing.Point(144, 119)
        Me.MainDept.Name = "MainDept"
        Me.MainDept.Size = New System.Drawing.Size(100, 21)
        Me.MainDept.TabIndex = 26
        Me.MainDept.Text = "Department"
        Me.MainDept.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(21, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Department :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DataSource = Me.Tbl_HRM_SectionBindingSource
        Me.NameComboBox.DisplayMember = "SectionName"
        Me.NameComboBox.Enabled = False
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(124, 59)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(263, 24)
        Me.NameComboBox.TabIndex = 24
        Me.NameComboBox.ValueMember = "SectionID"
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
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(124, 31)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(263, 24)
        Me.DeptNameComboBox.TabIndex = 23
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(216, 663)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 47)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary_NewTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_Salary2TableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_SalaryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_BankTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_BranchTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_CardTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Dept1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DeptTableAdapter = Me.Tbl_HRM_DeptTableAdapter
        Me.TableAdapterManager.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Me.Tbl_HRM_DesignationTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_JobTypeTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_QualficationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_SectionTableAdapter = Me.Tbl_HRM_SectionTableAdapter
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSHRMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_DeptTableAdapter
        '
        Me.Tbl_HRM_DeptTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tbl_Acc_AnnualLeaveTransactionsTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Att_DeviceSpecialTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Att_DeviceTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Cont_AttTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_Att_VisitTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_Emp_AttTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_Shift1TableAdapter = Nothing
        Me.TableAdapterManager1.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_PayRoll_LongLeavesTableAdapter = Nothing
        Me.TableAdapterManager1.tbl_PayRoll_ShortLeavesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_HRM_ShiftTableAdapter
        '
        Me.Tbl_HRM_ShiftTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(CatagoryNameLabel)
        Me.GroupBox3.Controls.Add(Me.CatagoryNameComboBox)
        Me.GroupBox3.Controls.Add(BranchNameLabel)
        Me.GroupBox3.Controls.Add(ShiftNameLabel)
        Me.GroupBox3.Controls.Add(Me.SpecialFilterBox)
        Me.GroupBox3.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox3.Controls.Add(Me.ShiftNameComboBox)
        Me.GroupBox3.Controls.Add(Me.OT_Type)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.tocard)
        Me.GroupBox3.Controls.Add(Me.Frmcard)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(348, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(419, 392)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selector"
        '
        'CatagoryNameComboBox
        '
        Me.CatagoryNameComboBox.DataSource = Me.Tbl_HRM_EmpCatagoryBindingSource
        Me.CatagoryNameComboBox.DisplayMember = "CatagoryName"
        Me.CatagoryNameComboBox.Enabled = False
        Me.CatagoryNameComboBox.FormattingEnabled = True
        Me.CatagoryNameComboBox.Location = New System.Drawing.Point(102, 174)
        Me.CatagoryNameComboBox.Name = "CatagoryNameComboBox"
        Me.CatagoryNameComboBox.Size = New System.Drawing.Size(295, 24)
        Me.CatagoryNameComboBox.TabIndex = 61
        Me.CatagoryNameComboBox.ValueMember = "EmpCatagoryID"
        '
        'Tbl_HRM_EmpCatagoryBindingSource
        '
        Me.Tbl_HRM_EmpCatagoryBindingSource.DataMember = "tbl_HRM_EmpCatagory"
        Me.Tbl_HRM_EmpCatagoryBindingSource.DataSource = Me.DSHRM
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BranchNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(102, 116)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(295, 24)
        Me.BranchNameComboBox.TabIndex = 60
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'ShiftNameComboBox
        '
        Me.ShiftNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ShiftNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShiftNameComboBox.DataSource = Me.Tbl_HRM_ShiftBindingSource
        Me.ShiftNameComboBox.DisplayMember = "ShiftName"
        Me.ShiftNameComboBox.Enabled = False
        Me.ShiftNameComboBox.FormattingEnabled = True
        Me.ShiftNameComboBox.Location = New System.Drawing.Point(102, 145)
        Me.ShiftNameComboBox.Name = "ShiftNameComboBox"
        Me.ShiftNameComboBox.Size = New System.Drawing.Size(295, 24)
        Me.ShiftNameComboBox.TabIndex = 59
        Me.ShiftNameComboBox.ValueMember = "ShiftID"
        '
        'OT_Type
        '
        Me.OT_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.OT_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.OT_Type.FormattingEnabled = True
        Me.OT_Type.Location = New System.Drawing.Point(102, 87)
        Me.OT_Type.Name = "OT_Type"
        Me.OT_Type.Size = New System.Drawing.Size(295, 24)
        Me.OT_Type.TabIndex = 56
        Me.OT_Type.Text = "Over Time"
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 89)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 20)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "OT Type:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tocard
        '
        Me.tocard.Enabled = False
        Me.tocard.Location = New System.Drawing.Point(297, 59)
        Me.tocard.Name = "tocard"
        Me.tocard.Size = New System.Drawing.Size(100, 23)
        Me.tocard.TabIndex = 52
        Me.tocard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frmcard
        '
        Me.Frmcard.Enabled = False
        Me.Frmcard.Location = New System.Drawing.Point(102, 59)
        Me.Frmcard.Multiline = True
        Me.Frmcard.Name = "Frmcard"
        Me.Frmcard.Size = New System.Drawing.Size(101, 23)
        Me.Frmcard.TabIndex = 51
        Me.Frmcard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 20)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "From Card:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(229, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "To Card:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(101, 23)
        Me.DateTimePicker1.TabIndex = 49
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(297, 30)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 23)
        Me.DateTimePicker2.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "From Date:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(230, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "To Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.NonActiveBtn)
        Me.GroupBox5.Controls.Add(Me.ActiveBtn)
        Me.GroupBox5.Controls.Add(Me.AllEmp)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(27, 43)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(253, 60)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Active/Non Active Employees"
        '
        'NonActiveBtn
        '
        Me.NonActiveBtn.AutoSize = True
        Me.NonActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActiveBtn.Location = New System.Drawing.Point(88, 22)
        Me.NonActiveBtn.Name = "NonActiveBtn"
        Me.NonActiveBtn.Size = New System.Drawing.Size(98, 21)
        Me.NonActiveBtn.TabIndex = 0
        Me.NonActiveBtn.Text = "Non Active "
        Me.NonActiveBtn.UseVisualStyleBackColor = True
        '
        'ActiveBtn
        '
        Me.ActiveBtn.AutoSize = True
        Me.ActiveBtn.Checked = True
        Me.ActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.ActiveBtn.Location = New System.Drawing.Point(18, 22)
        Me.ActiveBtn.Name = "ActiveBtn"
        Me.ActiveBtn.Size = New System.Drawing.Size(64, 21)
        Me.ActiveBtn.TabIndex = 0
        Me.ActiveBtn.TabStop = True
        Me.ActiveBtn.Text = "Active"
        Me.ActiveBtn.UseVisualStyleBackColor = True
        '
        'AllEmp
        '
        Me.AllEmp.AutoSize = True
        Me.AllEmp.ForeColor = System.Drawing.Color.Black
        Me.AllEmp.Location = New System.Drawing.Point(192, 22)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_EmpCatagoryTableAdapter
        '
        Me.Tbl_HRM_EmpCatagoryTableAdapter.ClearBeforeFill = True
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        Me.Tbl_Comp_InfoBindingSource.DataSource = Me.DSUser
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Comp_InfoTableAdapter = Me.Tbl_Comp_InfoTableAdapter
        Me.TableAdapterManager2.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager2.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_User_DeptTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager2.tbl_MIS_UserTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager2.UsersTableAdapter = Nothing
        '
        'frmOverTimeAcc
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1094, 746)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.OTPymtSummBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DeptPanel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "frmOverTimeAcc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OverTime Report"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpecialFilterBox.ResumeLayout(False)
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeptPanel.ResumeLayout(False)
        Me.DeptPanel.PerformLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Tbl_HRM_EmpCatagoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents NormalExtraSpecial As RadioButton
    Friend WithEvents Radio_OT As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioDateCard As RadioButton
    Friend WithEvents RadioSpecial As RadioButton
    Friend WithEvents RadioByDate As RadioButton
    Friend WithEvents lstCards As ListBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents cmbSelectCard As ComboBox
    Friend WithEvents RadioTravel As RadioButton
    Friend WithEvents Radio_Meal As RadioButton
    Friend WithEvents RadioDTA As RadioButton
    Friend WithEvents DeptPanel As Panel
    Friend WithEvents DesigBTn As RadioButton
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents RadioDeptAll As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Section As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents MainDept As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents SpecialFilterBox As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents DSPayRoll As DSPayRoll
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSPayRollTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents TableAdapterManager1 As DSPayRollTableAdapters.TableAdapterManager
    Friend WithEvents ByShift As RadioButton
    Friend WithEvents ByBranch As RadioButton
    Friend WithEvents Tbl_HRM_ShiftBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_ShiftTableAdapter As DSHRMTableAdapters.tbl_HRM_ShiftTableAdapter
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents ShiftNameComboBox As ComboBox
    Friend WithEvents OT_Type As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tocard As TextBox
    Friend WithEvents Frmcard As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PndStatus As RadioButton
    Friend WithEvents OTPymtSummBtn As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents NonActiveBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents PTPaymentDetails As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Tbl_HRM_EmpCatagoryBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_EmpCatagoryTableAdapter As DSHRMTableAdapters.tbl_HRM_EmpCatagoryTableAdapter
    Friend WithEvents CatagoryNameComboBox As ComboBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents DSUser As DSUser
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents TableAdapterManager2 As DSUserTableAdapters.TableAdapterManager
End Class
