<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoOTEntry
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Active = New System.Windows.Forms.RadioButton()
        Me.Deactive = New System.Windows.Forms.RadioButton()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.LeaveTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DSPayRoll = New ERP_HRMS.DSPayRoll()
        Me.Tbl_HRM_CardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_CardTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_HRM_CardTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager()
        Me.View_All_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_All_EmployeesTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_All_EmployeesTableAdapter()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_AttTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Active)
        Me.GroupBox1.Controls.Add(Me.Deactive)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(17, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 48)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selection"
        '
        'Active
        '
        Me.Active.AutoSize = True
        Me.Active.Checked = True
        Me.Active.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Active.Location = New System.Drawing.Point(32, 19)
        Me.Active.Name = "Active"
        Me.Active.Size = New System.Drawing.Size(64, 17)
        Me.Active.TabIndex = 35
        Me.Active.TabStop = True
        Me.Active.Text = "Activate"
        Me.Active.UseVisualStyleBackColor = True
        '
        'Deactive
        '
        Me.Deactive.AutoSize = True
        Me.Deactive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Deactive.Location = New System.Drawing.Point(114, 19)
        Me.Deactive.Name = "Deactive"
        Me.Deactive.Size = New System.Drawing.Size(77, 17)
        Me.Deactive.TabIndex = 36
        Me.Deactive.Text = "Deactivate"
        Me.Deactive.UseVisualStyleBackColor = True
        '
        'tbFilePath
        '
        Me.tbFilePath.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tbFilePath.Location = New System.Drawing.Point(10, 62)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.ReadOnly = True
        Me.tbFilePath.Size = New System.Drawing.Size(354, 20)
        Me.tbFilePath.TabIndex = 45
        Me.tbFilePath.TabStop = False
        Me.tbFilePath.Text = "Browse Auto OverTime Entry text file here to upload (Only txt files)"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.White
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(370, 59)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(106, 27)
        Me.btnBrowse.TabIndex = 44
        Me.btnBrowse.Text = "Browse File"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'LeaveTypeComboBox
        '
        Me.LeaveTypeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.LeaveTypeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.LeaveTypeComboBox.FormattingEnabled = True
        Me.LeaveTypeComboBox.Items.AddRange(New Object() {"Normal", "Extra", "Special", "Travel"})
        Me.LeaveTypeComboBox.Location = New System.Drawing.Point(347, 19)
        Me.LeaveTypeComboBox.Name = "LeaveTypeComboBox"
        Me.LeaveTypeComboBox.Size = New System.Drawing.Size(129, 21)
        Me.LeaveTypeComboBox.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(254, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "OverTime Type:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(10, 20)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(82, 20)
        Me.lblDate.TabIndex = 41
        Me.lblDate.Text = "Select Date:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(95, 20)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(148, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 29)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(258, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 27)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Upload File"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DSPayRoll
        '
        Me.DSPayRoll.DataSetName = "DSPayRoll"
        Me.DSPayRoll.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_CardBindingSource
        '
        Me.Tbl_HRM_CardBindingSource.DataMember = "tbl_HRM_Card"
        Me.Tbl_HRM_CardBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_HRM_CardTableAdapter
        '
        Me.Tbl_HRM_CardTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Acc_AnnualLeaveTransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Att_DeviceSpecialTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Att_DeviceTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_AttTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_HolidaysTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Leave_ReasonTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Shift1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PayRoll_LongLeavesTableAdapter = Nothing
        Me.TableAdapterManager.tbl_PayRoll_ShortLeavesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'View_All_EmployeesBindingSource
        '
        Me.View_All_EmployeesBindingSource.DataMember = "View_All_Employees"
        Me.View_All_EmployeesBindingSource.DataSource = Me.DSPayRoll
        '
        'View_All_EmployeesTableAdapter
        '
        Me.View_All_EmployeesTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_AttBindingSource
        '
        Me.Tbl_Hrm_Emp_AttBindingSource.DataMember = "tbl_Hrm_Emp_Att"
        Me.Tbl_Hrm_Emp_AttBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_Hrm_Emp_AttTableAdapter
        '
        Me.Tbl_Hrm_Emp_AttTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(121, 166)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 289)
        Me.Panel1.TabIndex = 47
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbFilePath)
        Me.GroupBox2.Controls.Add(Me.LeaveTypeComboBox)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.lblDate)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(17, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 162)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Option Selection"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Normal", "Travel"})
        Me.ComboBox1.Location = New System.Drawing.Point(469, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(129, 21)
        Me.ComboBox1.TabIndex = 48
        Me.ComboBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(559, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Auto O/T Entry"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(784, 40)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Auto OveTime Entry"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAutoOTEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "frmAutoOTEntry"
        Me.Text = "Auto Ovetime Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_CardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Active As RadioButton
    Friend WithEvents Deactive As RadioButton
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents LeaveTypeComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DSPayRoll As DSPayRoll
    Friend WithEvents Tbl_HRM_CardBindingSource As BindingSource
    Friend WithEvents Tbl_HRM_CardTableAdapter As DSPayRollTableAdapters.tbl_HRM_CardTableAdapter
    Friend WithEvents TableAdapterManager As DSPayRollTableAdapters.TableAdapterManager
    Friend WithEvents View_All_EmployeesBindingSource As BindingSource
    Friend WithEvents View_All_EmployeesTableAdapter As DSPayRollTableAdapters.View_All_EmployeesTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
