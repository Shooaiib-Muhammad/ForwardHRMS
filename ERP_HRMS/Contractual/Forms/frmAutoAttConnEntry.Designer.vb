<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoAttConnEntry
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DSPayRoll = New ERP_HRMS.DSPayRoll()
        Me.View_Active_CardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Active_CardsTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_Active_CardsTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSPayRollTableAdapters.TableAdapterManager()
        Me.View_All_EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_All_EmployeesTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.View_All_EmployeesTableAdapter()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_AttTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tbl_Hrm_Cont_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Cont_AttTableAdapter = New ERP_HRMS.DSPayRollTableAdapters.tbl_Hrm_Cont_AttTableAdapter()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Active_CardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Cont_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel2)
        Me.Panel4.Location = New System.Drawing.Point(76, 96)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(633, 371)
        Me.Panel4.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(607, 341)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton3)
        Me.Panel3.Location = New System.Drawing.Point(23, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 100)
        Me.Panel3.TabIndex = 13
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(16, 24)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(350, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Card No's Notepad file uploading i.e [S000202,S000302,S015802....]"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(16, 54)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(289, 17)
        Me.RadioButton3.TabIndex = 12
        Me.RadioButton3.Text = "Manual Card No's Notepad file uploading i.e [2,3,158....]"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tbFilePath)
        Me.Panel1.Controls.Add(Me.btnOpenFile)
        Me.Panel1.Location = New System.Drawing.Point(22, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 147)
        Me.Panel1.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 78)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(361, 78)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(175, 30)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Log File Now"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(0, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(557, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Select Attendance Log File to Upload"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Attendance Date :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'tbFilePath
        '
        Me.tbFilePath.BackColor = System.Drawing.SystemColors.Control
        Me.tbFilePath.Location = New System.Drawing.Point(12, 35)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.ReadOnly = True
        Me.tbFilePath.Size = New System.Drawing.Size(423, 20)
        Me.tbFilePath.TabIndex = 1
        Me.tbFilePath.TabStop = False
        Me.tbFilePath.Text = "Browse attendance log file here to upload (Only txt files)"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.BackColor = System.Drawing.Color.White
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.Location = New System.Drawing.Point(441, 35)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(95, 28)
        Me.btnOpenFile.TabIndex = 2
        Me.btnOpenFile.Text = "Browse File"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 544)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(802, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 22)
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
        'View_Active_CardsBindingSource
        '
        Me.View_Active_CardsBindingSource.DataMember = "View_Active_Cards"
        Me.View_Active_CardsBindingSource.DataSource = Me.DSPayRoll
        '
        'View_Active_CardsTableAdapter
        '
        Me.View_Active_CardsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_Acc_AnnualLeaveTransactionsTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Att_DeviceSpecialTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Att_DeviceTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Cont_AttTableAdapter = Nothing
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(802, 40)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Auto Contractual Attendance Entry "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_Hrm_Cont_AttBindingSource
        '
        Me.Tbl_Hrm_Cont_AttBindingSource.DataMember = "tbl_Hrm_Cont_Att"
        Me.Tbl_Hrm_Cont_AttBindingSource.DataSource = Me.DSPayRoll
        '
        'Tbl_Hrm_Cont_AttTableAdapter
        '
        Me.Tbl_Hrm_Cont_AttTableAdapter.ClearBeforeFill = True
        '
        'frmAutoAttConnEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 569)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmAutoAttConnEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Attendance Entry"
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DSPayRoll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Active_CardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_All_EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Cont_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DSPayRoll As DSPayRoll
    Friend WithEvents View_Active_CardsBindingSource As BindingSource
    Friend WithEvents View_Active_CardsTableAdapter As DSPayRollTableAdapters.View_Active_CardsTableAdapter
    Friend WithEvents TableAdapterManager As DSPayRollTableAdapters.TableAdapterManager
    Friend WithEvents View_All_EmployeesBindingSource As BindingSource
    Friend WithEvents View_All_EmployeesTableAdapter As DSPayRollTableAdapters.View_All_EmployeesTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As DSPayRollTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Tbl_Hrm_Cont_AttBindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Cont_AttTableAdapter As DSPayRollTableAdapters.tbl_Hrm_Cont_AttTableAdapter
End Class
