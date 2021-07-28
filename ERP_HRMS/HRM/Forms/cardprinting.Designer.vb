<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cardprinting
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
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim BranchNameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstCards = New System.Windows.Forms.ListBox()
        Me.cmbSelectCard = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_GradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSHRM = New ERP_HRMS.DSHRM()
        Me.DeptPanel = New System.Windows.Forms.Panel()
        Me.Deigantionbtn = New System.Windows.Forms.RadioButton()
        Me.AllButton = New System.Windows.Forms.RadioButton()
        Me.DesigNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DesignationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeptNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDept = New System.Windows.Forms.RadioButton()
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_HRM_SectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainDeptandSection = New System.Windows.Forms.RadioButton()
        Me.btnRptShow = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BackSide = New System.Windows.Forms.RadioButton()
        Me.Frontside = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_GradeTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_GradeTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSHRMTableAdapters.TableAdapterManager()
        Me.Tbl_HRM_DeptTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DeptTableAdapter()
        Me.Tbl_HRM_SectionTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_SectionTableAdapter()
        Me.Tbl_HRM_DesignationTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ByBranch = New System.Windows.Forms.RadioButton()
        Me.AllDept = New System.Windows.Forms.RadioButton()
        Me.Tbl_HRM_BranchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_BranchTableAdapter = New ERP_HRMS.DSHRMTableAdapters.tbl_HRM_BranchTableAdapter()
        Me.BranchNameComboBox = New System.Windows.Forms.ComboBox()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        BranchNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeptPanel.SuspendLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Label7.ForeColor = System.Drawing.Color.Black
        Label7.Location = New System.Drawing.Point(14, 34)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(89, 17)
        Label7.TabIndex = 0
        Label7.Text = "Depatrment:"
        '
        'Label9
        '
        Label9.ForeColor = System.Drawing.Color.Black
        Label9.Location = New System.Drawing.Point(14, 61)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(89, 17)
        Label9.TabIndex = 2
        Label9.Text = "Section:"
        '
        'Label8
        '
        Label8.ForeColor = System.Drawing.Color.Black
        Label8.Location = New System.Drawing.Point(14, 90)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(89, 17)
        Label8.TabIndex = 8
        Label8.Text = "Designation:"
        '
        'BranchNameLabel
        '
        BranchNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BranchNameLabel.Location = New System.Drawing.Point(283, 82)
        BranchNameLabel.Name = "BranchNameLabel"
        BranchNameLabel.Size = New System.Drawing.Size(77, 19)
        BranchNameLabel.TabIndex = 37
        BranchNameLabel.Text = "Branch:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(819, 40)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Special Card Printing Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(18, 35)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(174, 21)
        Me.RadioButton1.TabIndex = 12
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Employee Card Printing"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(57, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(212, 72)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Selection"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.lstCards)
        Me.GroupBox5.Controls.Add(Me.cmbSelectCard)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(278, 131)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(374, 169)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Special Filter:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(21, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Grade List:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Select Grade:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(260, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(260, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lstCards
        '
        Me.lstCards.FormattingEnabled = True
        Me.lstCards.ItemHeight = 16
        Me.lstCards.Location = New System.Drawing.Point(112, 57)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.Size = New System.Drawing.Size(142, 100)
        Me.lstCards.TabIndex = 1
        '
        'cmbSelectCard
        '
        Me.cmbSelectCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSelectCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSelectCard.DataSource = Me.Tbl_HRM_GradeBindingSource
        Me.cmbSelectCard.DisplayMember = "GradeName"
        Me.cmbSelectCard.FormattingEnabled = True
        Me.cmbSelectCard.Location = New System.Drawing.Point(112, 27)
        Me.cmbSelectCard.Name = "cmbSelectCard"
        Me.cmbSelectCard.Size = New System.Drawing.Size(142, 24)
        Me.cmbSelectCard.TabIndex = 0
        Me.cmbSelectCard.ValueMember = "GradeName"
        '
        'Tbl_HRM_GradeBindingSource
        '
        Me.Tbl_HRM_GradeBindingSource.DataMember = "tbl_HRM_Grade"
        Me.Tbl_HRM_GradeBindingSource.DataSource = Me.DSHRM
        '
        'DSHRM
        '
        Me.DSHRM.DataSetName = "DSHRM"
        Me.DSHRM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeptPanel
        '
        Me.DeptPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptPanel.Controls.Add(Me.Deigantionbtn)
        Me.DeptPanel.Controls.Add(Me.AllButton)
        Me.DeptPanel.Controls.Add(Label8)
        Me.DeptPanel.Controls.Add(Me.DesigNameComboBox)
        Me.DeptPanel.Controls.Add(Me.Label6)
        Me.DeptPanel.Controls.Add(Me.DeptNameComboBox)
        Me.DeptPanel.Controls.Add(Label7)
        Me.DeptPanel.Controls.Add(Me.MainDept)
        Me.DeptPanel.Controls.Add(Me.SectionNameComboBox)
        Me.DeptPanel.Controls.Add(Me.MainDeptandSection)
        Me.DeptPanel.Controls.Add(Label9)
        Me.DeptPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeptPanel.Location = New System.Drawing.Point(277, 306)
        Me.DeptPanel.Name = "DeptPanel"
        Me.DeptPanel.Size = New System.Drawing.Size(375, 193)
        Me.DeptPanel.TabIndex = 22
        '
        'Deigantionbtn
        '
        Me.Deigantionbtn.AutoSize = True
        Me.Deigantionbtn.ForeColor = System.Drawing.Color.Black
        Me.Deigantionbtn.Location = New System.Drawing.Point(14, 144)
        Me.Deigantionbtn.Name = "Deigantionbtn"
        Me.Deigantionbtn.Size = New System.Drawing.Size(101, 21)
        Me.Deigantionbtn.TabIndex = 7
        Me.Deigantionbtn.Text = "Designation"
        Me.Deigantionbtn.UseVisualStyleBackColor = True
        '
        'AllButton
        '
        Me.AllButton.AutoSize = True
        Me.AllButton.Checked = True
        Me.AllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllButton.ForeColor = System.Drawing.Color.Black
        Me.AllButton.Location = New System.Drawing.Point(16, 119)
        Me.AllButton.Name = "AllButton"
        Me.AllButton.Size = New System.Drawing.Size(41, 21)
        Me.AllButton.TabIndex = 26
        Me.AllButton.TabStop = True
        Me.AllButton.Text = "All"
        Me.AllButton.UseVisualStyleBackColor = True
        '
        'DesigNameComboBox
        '
        Me.DesigNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DesigNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DesigNameComboBox.DataSource = Me.Tbl_HRM_DesignationBindingSource
        Me.DesigNameComboBox.DisplayMember = "DesigName"
        Me.DesigNameComboBox.Enabled = False
        Me.DesigNameComboBox.FormattingEnabled = True
        Me.DesigNameComboBox.Location = New System.Drawing.Point(105, 88)
        Me.DesigNameComboBox.Name = "DesigNameComboBox"
        Me.DesigNameComboBox.Size = New System.Drawing.Size(258, 24)
        Me.DesigNameComboBox.TabIndex = 9
        Me.DesigNameComboBox.ValueMember = "DesignationID"
        '
        'Tbl_HRM_DesignationBindingSource
        '
        Me.Tbl_HRM_DesignationBindingSource.DataMember = "tbl_HRM_Designation"
        Me.Tbl_HRM_DesignationBindingSource.DataSource = Me.DSHRM
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(373, 23)
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
        Me.DeptNameComboBox.FormattingEnabled = True
        Me.DeptNameComboBox.Location = New System.Drawing.Point(105, 30)
        Me.DeptNameComboBox.Name = "DeptNameComboBox"
        Me.DeptNameComboBox.Size = New System.Drawing.Size(258, 24)
        Me.DeptNameComboBox.TabIndex = 1
        Me.DeptNameComboBox.ValueMember = "DeptID"
        '
        'Tbl_HRM_DeptBindingSource
        '
        Me.Tbl_HRM_DeptBindingSource.DataMember = "tbl_HRM_Dept"
        Me.Tbl_HRM_DeptBindingSource.DataSource = Me.DSHRM
        '
        'MainDept
        '
        Me.MainDept.AutoSize = True
        Me.MainDept.ForeColor = System.Drawing.Color.Black
        Me.MainDept.Location = New System.Drawing.Point(131, 119)
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
        Me.SectionNameComboBox.Location = New System.Drawing.Point(105, 58)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(258, 24)
        Me.SectionNameComboBox.TabIndex = 3
        Me.SectionNameComboBox.ValueMember = "SectionID"
        '
        'Tbl_HRM_SectionBindingSource
        '
        Me.Tbl_HRM_SectionBindingSource.DataMember = "tbl_HRM_Dept_tbl_HRM_Section"
        Me.Tbl_HRM_SectionBindingSource.DataSource = Me.Tbl_HRM_DeptBindingSource
        '
        'MainDeptandSection
        '
        Me.MainDeptandSection.AutoSize = True
        Me.MainDeptandSection.ForeColor = System.Drawing.Color.Black
        Me.MainDeptandSection.Location = New System.Drawing.Point(131, 144)
        Me.MainDeptandSection.Name = "MainDeptandSection"
        Me.MainDeptandSection.Size = New System.Drawing.Size(73, 21)
        Me.MainDeptandSection.TabIndex = 0
        Me.MainDeptandSection.Text = "Section"
        Me.MainDeptandSection.UseVisualStyleBackColor = True
        '
        'btnRptShow
        '
        Me.btnRptShow.BackColor = System.Drawing.Color.Green
        Me.btnRptShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRptShow.ForeColor = System.Drawing.Color.White
        Me.btnRptShow.Location = New System.Drawing.Point(101, 346)
        Me.btnRptShow.Name = "btnRptShow"
        Me.btnRptShow.Size = New System.Drawing.Size(170, 58)
        Me.btnRptShow.TabIndex = 23
        Me.btnRptShow.Text = "Show Report"
        Me.btnRptShow.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BackSide)
        Me.GroupBox4.Controls.Add(Me.Frontside)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(57, 152)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(212, 56)
        Me.GroupBox4.TabIndex = 24
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
        'Tbl_HRM_GradeTableAdapter
        '
        Me.Tbl_HRM_GradeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tbl_HRM_DesignationTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_NoticesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_EmpCatagoryTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_EmploymentTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_GradeTableAdapter = Me.Tbl_HRM_GradeTableAdapter
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
        'Tbl_HRM_DesignationTableAdapter
        '
        Me.Tbl_HRM_DesignationTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ByBranch)
        Me.GroupBox2.Controls.Add(Me.AllDept)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(57, 247)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(201, 84)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selection Option "
        '
        'ByBranch
        '
        Me.ByBranch.AutoSize = True
        Me.ByBranch.ForeColor = System.Drawing.Color.Black
        Me.ByBranch.Location = New System.Drawing.Point(13, 50)
        Me.ByBranch.Name = "ByBranch"
        Me.ByBranch.Size = New System.Drawing.Size(95, 21)
        Me.ByBranch.TabIndex = 3
        Me.ByBranch.TabStop = True
        Me.ByBranch.Text = "By Branch "
        Me.ByBranch.UseVisualStyleBackColor = True
        '
        'AllDept
        '
        Me.AllDept.AutoSize = True
        Me.AllDept.Checked = True
        Me.AllDept.ForeColor = System.Drawing.Color.Black
        Me.AllDept.Location = New System.Drawing.Point(13, 24)
        Me.AllDept.Name = "AllDept"
        Me.AllDept.Size = New System.Drawing.Size(45, 21)
        Me.AllDept.TabIndex = 0
        Me.AllDept.TabStop = True
        Me.AllDept.Text = "All "
        Me.AllDept.UseVisualStyleBackColor = True
        '
        'Tbl_HRM_BranchBindingSource
        '
        Me.Tbl_HRM_BranchBindingSource.DataMember = "tbl_HRM_Branch"
        Me.Tbl_HRM_BranchBindingSource.DataSource = Me.DSHRM
        '
        'Tbl_HRM_BranchTableAdapter
        '
        Me.Tbl_HRM_BranchTableAdapter.ClearBeforeFill = True
        '
        'BranchNameComboBox
        '
        Me.BranchNameComboBox.DataSource = Me.Tbl_HRM_BranchBindingSource
        Me.BranchNameComboBox.DisplayMember = "BranchName"
        Me.BranchNameComboBox.Enabled = False
        Me.BranchNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BranchNameComboBox.FormattingEnabled = True
        Me.BranchNameComboBox.Location = New System.Drawing.Point(364, 80)
        Me.BranchNameComboBox.Name = "BranchNameComboBox"
        Me.BranchNameComboBox.Size = New System.Drawing.Size(288, 24)
        Me.BranchNameComboBox.TabIndex = 38
        Me.BranchNameComboBox.ValueMember = "BranchID"
        '
        'cardprinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 617)
        Me.Controls.Add(BranchNameLabel)
        Me.Controls.Add(Me.BranchNameComboBox)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnRptShow)
        Me.Controls.Add(Me.DeptPanel)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cardprinting"
        Me.Text = "Card Printing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Tbl_HRM_GradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSHRM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeptPanel.ResumeLayout(False)
        Me.DeptPanel.PerformLayout()
        CType(Me.Tbl_HRM_DesignationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_SectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_HRM_BranchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lstCards As ListBox
    Friend WithEvents cmbSelectCard As ComboBox
    Friend WithEvents DeptPanel As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DeptNameComboBox As ComboBox
    Friend WithEvents MainDept As RadioButton
    Friend WithEvents SectionNameComboBox As ComboBox
    Friend WithEvents MainDeptandSection As RadioButton
    Friend WithEvents btnRptShow As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BackSide As RadioButton
    Friend WithEvents Frontside As RadioButton
    Friend WithEvents DSHRM As DSHRM
    Friend WithEvents Tbl_HRM_GradeBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_GradeTableAdapter As DSHRMTableAdapters.tbl_HRM_GradeTableAdapter
    Friend WithEvents TableAdapterManager As DSHRMTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_HRM_DeptTableAdapter As DSHRMTableAdapters.tbl_HRM_DeptTableAdapter
    Friend WithEvents Tbl_HRM_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_SectionTableAdapter As DSHRMTableAdapters.tbl_HRM_SectionTableAdapter
    Friend WithEvents Tbl_HRM_SectionBindingSource As BindingSource
    Friend WithEvents AllButton As RadioButton
    Friend WithEvents Deigantionbtn As RadioButton
    Friend WithEvents DesigNameComboBox As ComboBox
    Friend WithEvents Tbl_HRM_DesignationBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_DesignationTableAdapter As DSHRMTableAdapters.tbl_HRM_DesignationTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ByBranch As RadioButton
    Friend WithEvents AllDept As RadioButton
    Friend WithEvents Tbl_HRM_BranchBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_BranchTableAdapter As DSHRMTableAdapters.tbl_HRM_BranchTableAdapter
    Friend WithEvents BranchNameComboBox As ComboBox
End Class
