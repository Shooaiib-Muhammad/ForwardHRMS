<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RptemployeeRecord
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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton14 = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.RadioButton24 = New System.Windows.Forms.RadioButton()
        Me.Ntc = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton18 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.ExperBtn = New System.Windows.Forms.RadioButton()
        Me.EmpBtn = New System.Windows.Forms.RadioButton()
        Me.ChrBtn = New System.Windows.Forms.RadioButton()
        Me.CardPrinting = New System.Windows.Forms.RadioButton()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.CrdCPBTBtn = New System.Windows.Forms.RadioButton()
        Me.SalaryBtn = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRptShow = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.Bybranch = New System.Windows.Forms.RadioButton()
        Me.AllButton = New System.Windows.Forms.RadioButton()
        Me.SpecialBtn = New System.Windows.Forms.RadioButton()
        Me.CardRange = New System.Windows.Forms.RadioButton()
        Me.AllDept = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BackSide = New System.Windows.Forms.RadioButton()
        Me.Frontside = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstCards = New System.Windows.Forms.ListBox()
        Me.cmbSelectCard = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_CardTableAdapter()
        Me.DeptPanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Deigantionbtn = New System.Windows.Forms.RadioButton()
        Me.MainDept = New System.Windows.Forms.RadioButton()
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.MainDeptandSection = New System.Windows.Forms.RadioButton()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.NonActiveBtn = New System.Windows.Forms.RadioButton()
        Me.ActiveBtn = New System.Windows.Forms.RadioButton()
        Me.AllEmp = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeptPanel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(6, 43)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(89, 17)
        Label7.TabIndex = 0
        Label7.Text = "Depatrment:"
        '
        'Label8
        '
        Label8.ForeColor = System.Drawing.Color.Black
        Label8.Location = New System.Drawing.Point(6, 97)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(89, 17)
        Label8.TabIndex = 4
        Label8.Text = "Designation:"
        '
        'Label9
        '
        Label9.ForeColor = System.Drawing.Color.Black
        Label9.Location = New System.Drawing.Point(6, 70)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(89, 17)
        Label9.TabIndex = 2
        Label9.Text = "Section:"
        '
        'BranchNameLabel
        '
        BranchNameLabel.ForeColor = System.Drawing.Color.Black
        BranchNameLabel.Location = New System.Drawing.Point(16, 55)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(81, 17)
        BranchNameLabel.TabIndex = 34
        BranchNameLabel.Text = "Branch :"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1161, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Employee Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton15)
        Me.GroupBox1.Controls.Add(Me.RadioButton14)
        Me.GroupBox1.Controls.Add(Me.RadioButton13)
        Me.GroupBox1.Controls.Add(Me.RadioButton24)
        Me.GroupBox1.Controls.Add(Me.Ntc)
        Me.GroupBox1.Controls.Add(Me.RadioButton8)
        Me.GroupBox1.Controls.Add(Me.RadioButton7)
        Me.GroupBox1.Controls.Add(Me.RadioButton18)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.ExperBtn)
        Me.GroupBox1.Controls.Add(Me.EmpBtn)
        Me.GroupBox1.Controls.Add(Me.ChrBtn)
        Me.GroupBox1.Controls.Add(Me.CardPrinting)
        Me.GroupBox1.Controls.Add(Me.RadioButton11)
        Me.GroupBox1.Controls.Add(Me.CrdCPBTBtn)
        Me.GroupBox1.Controls.Add(Me.SalaryBtn)
        Me.GroupBox1.Controls.Add(Me.RadioButton10)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton9)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(58, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 306)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selector :"
        '
        'RadioButton15
        '
        Me.RadioButton15.AutoSize = True
        Me.RadioButton15.ForeColor = System.Drawing.Color.Black
        Me.RadioButton15.Location = New System.Drawing.Point(19, 266)
        Me.RadioButton15.Name = "RadioButton15"
        Me.RadioButton15.Size = New System.Drawing.Size(158, 21)
        Me.RadioButton15.TabIndex = 55
        Me.RadioButton15.Text = "Marriage Grant Case"
        Me.RadioButton15.UseVisualStyleBackColor = True
        '
        'RadioButton14
        '
        Me.RadioButton14.AutoSize = True
        Me.RadioButton14.ForeColor = System.Drawing.Color.Black
        Me.RadioButton14.Location = New System.Drawing.Point(20, 244)
        Me.RadioButton14.Name = "RadioButton14"
        Me.RadioButton14.Size = New System.Drawing.Size(140, 21)
        Me.RadioButton14.TabIndex = 54
        Me.RadioButton14.Text = "Service Certificate"
        Me.RadioButton14.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.ForeColor = System.Drawing.Color.Black
        Me.RadioButton13.Location = New System.Drawing.Point(240, 244)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(163, 21)
        Me.RadioButton13.TabIndex = 53
        Me.RadioButton13.Text = "Job Permanent Letter"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'RadioButton24
        '
        Me.RadioButton24.AutoSize = True
        Me.RadioButton24.ForeColor = System.Drawing.Color.Black
        Me.RadioButton24.Location = New System.Drawing.Point(244, 220)
        Me.RadioButton24.Name = "RadioButton24"
        Me.RadioButton24.Size = New System.Drawing.Size(165, 21)
        Me.RadioButton24.TabIndex = 52
        Me.RadioButton24.Text = "Disable Employee List"
        Me.RadioButton24.UseVisualStyleBackColor = True
        '
        'Ntc
        '
        Me.Ntc.AutoSize = True
        Me.Ntc.ForeColor = System.Drawing.Color.Black
        Me.Ntc.Location = New System.Drawing.Point(19, 221)
        Me.Ntc.Name = "Ntc"
        Me.Ntc.Size = New System.Drawing.Size(73, 21)
        Me.Ntc.TabIndex = 41
        Me.Ntc.Text = "Notices"
        Me.Ntc.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.Black
        Me.RadioButton8.Location = New System.Drawing.Point(244, 176)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(241, 21)
        Me.RadioButton8.TabIndex = 40
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "Section Wise Employee Count List"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.Black
        Me.RadioButton7.Location = New System.Drawing.Point(244, 44)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(178, 21)
        Me.RadioButton7.TabIndex = 39
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "Employee Graduity Log "
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton18
        '
        Me.RadioButton18.AutoSize = True
        Me.RadioButton18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton18.ForeColor = System.Drawing.Color.Black
        Me.RadioButton18.Location = New System.Drawing.Point(244, 198)
        Me.RadioButton18.Name = "RadioButton18"
        Me.RadioButton18.Size = New System.Drawing.Size(142, 21)
        Me.RadioButton18.TabIndex = 38
        Me.RadioButton18.Text = "Termination Letter"
        Me.RadioButton18.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.Black
        Me.RadioButton6.Location = New System.Drawing.Point(244, 154)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(192, 21)
        Me.RadioButton6.TabIndex = 6
        Me.RadioButton6.Text = "Employee List with All Info."
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'ExperBtn
        '
        Me.ExperBtn.AutoSize = True
        Me.ExperBtn.ForeColor = System.Drawing.Color.Black
        Me.ExperBtn.Location = New System.Drawing.Point(244, 110)
        Me.ExperBtn.Name = "ExperBtn"
        Me.ExperBtn.Size = New System.Drawing.Size(137, 21)
        Me.ExperBtn.TabIndex = 4
        Me.ExperBtn.Text = "Experience Letter"
        Me.ExperBtn.UseVisualStyleBackColor = True
        '
        'EmpBtn
        '
        Me.EmpBtn.AutoSize = True
        Me.EmpBtn.ForeColor = System.Drawing.Color.Black
        Me.EmpBtn.Location = New System.Drawing.Point(244, 132)
        Me.EmpBtn.Name = "EmpBtn"
        Me.EmpBtn.Size = New System.Drawing.Size(114, 21)
        Me.EmpBtn.TabIndex = 3
        Me.EmpBtn.Text = "Employee List"
        Me.EmpBtn.UseVisualStyleBackColor = True
        '
        'ChrBtn
        '
        Me.ChrBtn.AutoSize = True
        Me.ChrBtn.ForeColor = System.Drawing.Color.Black
        Me.ChrBtn.Location = New System.Drawing.Point(244, 88)
        Me.ChrBtn.Name = "ChrBtn"
        Me.ChrBtn.Size = New System.Drawing.Size(155, 21)
        Me.ChrBtn.TabIndex = 2
        Me.ChrBtn.Text = "Character Certificate"
        Me.ChrBtn.UseVisualStyleBackColor = True
        '
        'CardPrinting
        '
        Me.CardPrinting.AutoSize = True
        Me.CardPrinting.ForeColor = System.Drawing.Color.Black
        Me.CardPrinting.Location = New System.Drawing.Point(19, 89)
        Me.CardPrinting.Name = "CardPrinting"
        Me.CardPrinting.Size = New System.Drawing.Size(174, 21)
        Me.CardPrinting.TabIndex = 1
        Me.CardPrinting.Text = "Employee Card Printing"
        Me.CardPrinting.UseVisualStyleBackColor = True
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.ForeColor = System.Drawing.Color.Black
        Me.RadioButton11.Location = New System.Drawing.Point(19, 67)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(175, 21)
        Me.RadioButton11.TabIndex = 1
        Me.RadioButton11.Text = "Employee Appointment "
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'CrdCPBTBtn
        '
        Me.CrdCPBTBtn.AutoSize = True
        Me.CrdCPBTBtn.ForeColor = System.Drawing.Color.Black
        Me.CrdCPBTBtn.Location = New System.Drawing.Point(244, 66)
        Me.CrdCPBTBtn.Name = "CrdCPBTBtn"
        Me.CrdCPBTBtn.Size = New System.Drawing.Size(186, 21)
        Me.CrdCPBTBtn.TabIndex = 1
        Me.CrdCPBTBtn.Text = "Employee Card Copy Log"
        Me.CrdCPBTBtn.UseVisualStyleBackColor = True
        '
        'SalaryBtn
        '
        Me.SalaryBtn.AutoSize = True
        Me.SalaryBtn.ForeColor = System.Drawing.Color.Black
        Me.SalaryBtn.Location = New System.Drawing.Point(244, 22)
        Me.SalaryBtn.Name = "SalaryBtn"
        Me.SalaryBtn.Size = New System.Drawing.Size(164, 21)
        Me.SalaryBtn.TabIndex = 1
        Me.SalaryBtn.Text = "Employee Salary Log "
        Me.SalaryBtn.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.Black
        Me.RadioButton10.Location = New System.Drawing.Point(19, 199)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(169, 21)
        Me.RadioButton10.TabIndex = 1
        Me.RadioButton10.Text = "Employee Branch Log "
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(19, 45)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(151, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Employee Tracking "
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(19, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(136, 21)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Employee Profile "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.Black
        Me.RadioButton9.Location = New System.Drawing.Point(19, 177)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(183, 21)
        Me.RadioButton9.TabIndex = 1
        Me.RadioButton9.Text = "Employee Job Type Log "
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(19, 111)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(198, 21)
        Me.RadioButton3.TabIndex = 1
        Me.RadioButton3.Text = "Employee Department Log "
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.Black
        Me.RadioButton4.Location = New System.Drawing.Point(19, 133)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(164, 21)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.Text = "Employee Grade Log "
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.Black
        Me.RadioButton5.Location = New System.Drawing.Point(19, 155)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(152, 21)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.Text = "Employee Shift Log "
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(BranchNameLabel)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.BranchNameComboBox)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(563, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 87)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selector :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(211, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "To Card:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "From Card:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(277, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(106, 52)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(271, 24)
        Me.BranchNameComboBox.TabIndex = 35
        Me.BranchNameComboBox.ValueMember = "BranchID"
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
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(106, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_DeptBindingSource
        '
        Me.Tbl_HRM_DeptBindingSource.DataMember = "tbl_HRM_Dept"
        Me.Tbl_HRM_DeptBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_SectionBindingSource
        '
        Me.Tbl_HRM_SectionBindingSource.DataMember = "tbl_HRM_Dept_tbl_HRM_Section"
        Me.Tbl_HRM_SectionBindingSource.DataSource = Me.Tbl_HRM_DeptBindingSource
        '
        'btnRptShow
        '
        Me.btnRptShow.BackColor = System.Drawing.Color.Green
        Me.btnRptShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptShow.ForeColor = System.Drawing.Color.White
        Me.btnRptShow.Location = New System.Drawing.Point(816, 327)
        Me.btnRptShow.Name = "btnRptShow"
        Me.btnRptShow.Size = New System.Drawing.Size(164, 62)
        Me.btnRptShow.TabIndex = 14
        Me.btnRptShow.Text = "Show Report"
        Me.btnRptShow.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton12)
        Me.GroupBox3.Controls.Add(Me.Bybranch)
        Me.GroupBox3.Controls.Add(Me.AllButton)
        Me.GroupBox3.Controls.Add(Me.SpecialBtn)
        Me.GroupBox3.Controls.Add(Me.CardRange)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(58, 424)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(275, 174)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Option Selector :"
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Enabled = False
        Me.RadioButton12.ForeColor = System.Drawing.Color.Black
        Me.RadioButton12.Location = New System.Drawing.Point(23, 98)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(151, 21)
        Me.RadioButton12.TabIndex = 25
        Me.RadioButton12.Text = "Special Grade Filter"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'Bybranch
        '
        Me.Bybranch.AutoSize = True
        Me.Bybranch.ForeColor = System.Drawing.Color.Black
        Me.Bybranch.Location = New System.Drawing.Point(23, 122)
        Me.Bybranch.Name = "Bybranch"
        Me.Bybranch.Size = New System.Drawing.Size(91, 21)
        Me.Bybranch.TabIndex = 22
        Me.Bybranch.TabStop = True
        Me.Bybranch.Text = "By Branch"
        Me.Bybranch.UseVisualStyleBackColor = True
        '
        'AllButton
        '
        Me.AllButton.AutoSize = True
        Me.AllButton.Checked = True
        Me.AllButton.ForeColor = System.Drawing.Color.Black
        Me.AllButton.Location = New System.Drawing.Point(23, 26)
        Me.AllButton.Name = "AllButton"
        Me.AllButton.Size = New System.Drawing.Size(41, 21)
        Me.AllButton.TabIndex = 21
        Me.AllButton.TabStop = True
        Me.AllButton.Text = "All"
        Me.AllButton.UseVisualStyleBackColor = True
        '
        'SpecialBtn
        '
        Me.SpecialBtn.AutoSize = True
        Me.SpecialBtn.ForeColor = System.Drawing.Color.Black
        Me.SpecialBtn.Location = New System.Drawing.Point(23, 74)
        Me.SpecialBtn.Name = "SpecialBtn"
        Me.SpecialBtn.Size = New System.Drawing.Size(141, 21)
        Me.SpecialBtn.TabIndex = 20
        Me.SpecialBtn.Text = "Special Card Filter"
        Me.SpecialBtn.UseVisualStyleBackColor = True
        '
        'CardRange
        '
        Me.CardRange.AutoSize = True
        Me.CardRange.ForeColor = System.Drawing.Color.Black
        Me.CardRange.Location = New System.Drawing.Point(23, 50)
        Me.CardRange.Name = "CardRange"
        Me.CardRange.Size = New System.Drawing.Size(122, 21)
        Me.CardRange.TabIndex = 19
        Me.CardRange.Text = "By Card Range"
        Me.CardRange.UseVisualStyleBackColor = True
        '
        'AllDept
        '
        Me.AllDept.AutoSize = True
        Me.AllDept.Checked = True
        Me.AllDept.ForeColor = System.Drawing.Color.Black
        Me.AllDept.Location = New System.Drawing.Point(6, 134)
        Me.AllDept.Name = "AllDept"
        Me.AllDept.Size = New System.Drawing.Size(41, 21)
        Me.AllDept.TabIndex = 0
        Me.AllDept.TabStop = True
        Me.AllDept.Text = "All"
        Me.AllDept.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_DeptTableAdapter
        '
        Me.Tbl_HRM_DeptTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.tbl_HRM_DeptTableAdapter = Me.Tbl_HRM_DeptTableAdapter
        Me.TableAdapterManager.tbl_HRM_Designation1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Me.Tbl_HRM_DesignationTableAdapter
        Me.TableAdapterManager.tbl_HRM_Emp_Info1TableAdapter = Nothing
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
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'Tbl_HRM_SectionTableAdapter
        '
        Me.Tbl_HRM_SectionTableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BackSide)
        Me.GroupBox4.Controls.Add(Me.Frontside)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(563, 326)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(222, 56)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Card Printing Side:"
        '
        'BackSide
        '
        Me.BackSide.AutoSize = True
        Me.BackSide.ForeColor = System.Drawing.Color.Black
        Me.BackSide.Location = New System.Drawing.Point(111, 23)
        Me.BackSide.Name = "BackSide"
        Me.BackSide.Size = New System.Drawing.Size(89, 21)
        Me.BackSide.TabIndex = 0
        Me.BackSide.TabStop = True
        Me.BackSide.Text = "Back Side"
        Me.BackSide.UseVisualStyleBackColor = True
        '
        'Frontside
        '
        Me.Frontside.AutoSize = True
        Me.Frontside.Checked = True
        Me.Frontside.ForeColor = System.Drawing.Color.Black
        Me.Frontside.Location = New System.Drawing.Point(10, 23)
        Me.Frontside.Name = "Frontside"
        Me.Frontside.Size = New System.Drawing.Size(95, 21)
        Me.Frontside.TabIndex = 0
        Me.Frontside.TabStop = True
        Me.Frontside.Text = "Front Side "
        Me.Frontside.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.lstCards)
        Me.GroupBox5.Controls.Add(Me.cmbSelectCard)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(563, 151)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(398, 163)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Special Filter:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Card List:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Select Card#:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(253, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(253, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lstCards
        '
        Me.lstCards.FormattingEnabled = True
        Me.lstCards.ItemHeight = 16
        Me.lstCards.Location = New System.Drawing.Point(105, 59)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.Size = New System.Drawing.Size(142, 84)
        Me.lstCards.TabIndex = 1
        '
        'cmbSelectCard
        '
        Me.cmbSelectCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSelectCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSelectCard.DataSource = Me.Tbl_HRM_CardBindingSource
        Me.cmbSelectCard.DisplayMember = "CardNo"
        Me.cmbSelectCard.FormattingEnabled = True
        Me.cmbSelectCard.Location = New System.Drawing.Point(105, 29)
        Me.cmbSelectCard.Name = "cmbSelectCard"
        Me.cmbSelectCard.Size = New System.Drawing.Size(142, 24)
        Me.cmbSelectCard.TabIndex = 0
        Me.cmbSelectCard.ValueMember = "CardNo"
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'DeptPanel
        '
        Me.DeptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptPanel.Controls.Add(Me.Label6)
        Me.DeptPanel.Controls.Add(Me.DeptNameComboBox)
        Me.DeptPanel.Controls.Add(Label7)
        Me.DeptPanel.Controls.Add(Me.AllDept)
        Me.DeptPanel.Controls.Add(Me.Deigantionbtn)
        Me.DeptPanel.Controls.Add(Label8)
        Me.DeptPanel.Controls.Add(Me.MainDept)
        Me.DeptPanel.Controls.Add(Me.SectionNameComboBox)
        Me.DeptPanel.Controls.Add(Me.MainDeptandSection)
        Me.DeptPanel.Controls.Add(Label9)
        Me.DeptPanel.Controls.Add(Me.DesigNameComboBox)
        Me.DeptPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptPanel.Location = New System.Drawing.Point(565, 394)
        Me.DeptPanel.Name = "DeptPanel"
        Me.DeptPanel.Size = New System.Drawing.Size(398, 207)
        Me.DeptPanel.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(396, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Select Appropriate Option"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DeptNameComboBox
        '
        Me.DeptNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DeptNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DeptNameComboBox.DataSource = Me.Tbl_HRM_DeptBindingSource
        Me.DeptNameComboBox.DisplayMember = "DeptName"
        Me.DeptNameComboBox.Enabled = False
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(96, 39)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(293, 24)
        Me.DeptNameComboBox.TabIndex = 1
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'Deigantionbtn
        '
        Me.Deigantionbtn.AutoSize = True
        Me.Deigantionbtn.ForeColor = System.Drawing.Color.Black
        Me.Deigantionbtn.Location = New System.Drawing.Point(6, 161)
        Me.Deigantionbtn.Name = "Deigantionbtn"
        Me.Deigantionbtn.Size = New System.Drawing.Size(101, 21)
        Me.Deigantionbtn.TabIndex = 0
        Me.Deigantionbtn.Text = "Designation"
        Me.Deigantionbtn.UseVisualStyleBackColor = True
        '
        'MainDept
        '
        Me.MainDept.AutoSize = True
        Me.MainDept.ForeColor = System.Drawing.Color.Black
        Me.MainDept.Location = New System.Drawing.Point(133, 134)
        Me.MainDept.Name = "MainDept"
        Me.MainDept.Size = New System.Drawing.Size(100, 21)
        Me.MainDept.TabIndex = 0
        Me.MainDept.Text = "Department"
        Me.MainDept.UseVisualStyleBackColor = True
        '
        'SectionNameComboBox
        '
        Me.SectionNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SectionNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SectionNameComboBox.DataSource = Me.Tbl_HRM_SectionBindingSource
        Me.SectionNameComboBox.DisplayMember = "SectionName"
        Me.SectionNameComboBox.Enabled = False
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(96, 67)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(293, 24)
        Me.SectionNameComboBox.TabIndex = 3
        Me.SectionNameComboBox.ValueMember = "SectionID"
        '
        'MainDeptandSection
        '
        Me.MainDeptandSection.AutoSize = True
        Me.MainDeptandSection.ForeColor = System.Drawing.Color.Black
        Me.MainDeptandSection.Location = New System.Drawing.Point(133, 161)
        Me.MainDeptandSection.Name = "MainDeptandSection"
        Me.MainDeptandSection.Size = New System.Drawing.Size(73, 21)
        Me.MainDeptandSection.TabIndex = 0
        Me.MainDeptandSection.Text = "Section"
        Me.MainDeptandSection.UseVisualStyleBackColor = True
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(96, 95)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(293, 24)
        Me.DesigNameComboBox.TabIndex = 5
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.NonActiveBtn)
        Me.GroupBox6.Controls.Add(Me.ActiveBtn)
        Me.GroupBox6.Controls.Add(Me.AllEmp)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(58, 49)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(275, 60)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Active/Non Active Employees"
        '
        'NonActiveBtn
        '
        Me.NonActiveBtn.AutoSize = True
        Me.NonActiveBtn.ForeColor = System.Drawing.Color.Black
        Me.NonActiveBtn.Location = New System.Drawing.Point(90, 22)
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
        Me.ActiveBtn.Location = New System.Drawing.Point(19, 22)
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
        Me.AllEmp.Location = New System.Drawing.Point(196, 22)
        Me.AllEmp.Name = "AllEmp"
        Me.AllEmp.Size = New System.Drawing.Size(41, 21)
        Me.AllEmp.TabIndex = 0
        Me.AllEmp.Text = "All"
        Me.AllEmp.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.Button3)
        Me.GroupBox7.Controls.Add(Me.Button4)
        Me.GroupBox7.Controls.Add(Me.ListBox1)
        Me.GroupBox7.Controls.Add(Me.ComboBox1)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox7.Location = New System.Drawing.Point(566, 148)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(390, 169)
        Me.GroupBox7.TabIndex = 42
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Special Filter:"
        Me.GroupBox7.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(21, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Grade List:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Select Grade:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(260, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(260, 87)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 29)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(112, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(142, 100)
        Me.ListBox1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_HRM_GradeBindingSource
        Me.ComboBox1.DisplayMember = "GradeName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(112, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(142, 24)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "GradeName"
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_GradeTableAdapter
        '
        Me.Tbl_HRM_GradeTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(447, 435)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(115, 20)
        Me.DateTimePicker2.TabIndex = 54
        Me.DateTimePicker2.Visible = False
        '
        'Label12
        '
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(372, 435)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 20)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Select Date:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'RptemployeeRecord
        '
        Me.AcceptButton = Me.btnRptShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1161, 770)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.DeptPanel)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnRptShow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RptemployeeRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Reports"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeptPanel.ResumeLayout(False)
        Me.DeptPanel.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRptShow As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton11 As RadioButton
    Friend WithEvents Tbl_HRM_DeptBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_HRM_DeptBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents SpecialBtn As RadioButton
    Friend WithEvents CardRange As RadioButton
    Friend WithEvents CardPrinting As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Frontside As RadioButton
    Friend WithEvents BackSide As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lstCards As ListBox
    Friend WithEvents cmbSelectCard As ComboBox
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSHRMTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SalaryBtn As RadioButton
    Friend WithEvents CrdCPBTBtn As RadioButton
    Friend WithEvents ChrBtn As RadioButton
    Friend WithEvents DeptPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents Deigantionbtn As RadioButton
    Friend WithEvents MainDept As RadioButton
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents MainDeptandSection As RadioButton
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents AllDept As RadioButton
    Friend WithEvents AllButton As RadioButton
    Friend WithEvents EmpBtn As RadioButton
    Friend WithEvents ExperBtn As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents NonActiveBtn As RadioButton
    Friend WithEvents ActiveBtn As RadioButton
    Friend WithEvents AllEmp As RadioButton
    Friend WithEvents Bybranch As RadioButton
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents BranchNameComboBox As ComboBox
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton18 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents Ntc As RadioButton
    Friend WithEvents RadioButton12 As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents RadioButton24 As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents RadioButton14 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label12 As Label
End Class
