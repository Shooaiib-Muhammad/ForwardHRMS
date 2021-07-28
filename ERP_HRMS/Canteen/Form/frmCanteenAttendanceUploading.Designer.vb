<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCanteenAttendanceUploading
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalRowLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DSDisplayEI = New ERP_HRMS.DSDisplayEI()
        Me.View_Display_EmpInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Display_EmpInfoTableAdapter = New ERP_HRMS.DSDisplayEITableAdapters.View_Display_EmpInfoTableAdapter()
        Me.View_Att_EmpVerifyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Att_EmpVerifyTableAdapter = New ERP_HRMS.DSDisplayEITableAdapters.View_Att_EmpVerifyTableAdapter()
        Me.DSAutoAtt = New ERP_HRMS.DSAutoAtt()
        Me.View_Rpt_HR_ActiveCardCopyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Rpt_HR_ActiveCardCopyTableAdapter = New ERP_HRMS.DSAutoAttTableAdapters.View_Rpt_HR_ActiveCardCopyTableAdapter()
        Me.Tbl_Hrm_Emp_AttTableAdapter = New ERP_HRMS.DSAutoAttTableAdapters.tbl_Hrm_Emp_AttTableAdapter()
        Me.Tbl_Hrm_Emp_AttBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Att_MealBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Att_MealTableAdapter = New ERP_HRMS.DSAutoAttTableAdapters.tbl_HRM_Emp_Att_MealTableAdapter()
        Me.Tbl_Hrm_Emp_Att1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Hrm_Emp_Att1TableAdapter = New ERP_HRMS.DSAutoAttTableAdapters.tbl_Hrm_Emp_Att1TableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSAutoAttTableAdapters.TableAdapterManager()
        Me.DSBuffetAttendance = New ERP_HRMS.DSBuffetAttendance()
        Me.Tbl_HRM_Emp_Att_MealBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_HRM_Emp_Att_MealTableAdapter1 = New ERP_HRMS.DSBuffetAttendanceTableAdapters.tbl_HRM_Emp_Att_MealTableAdapter()
        Me.TableAdapterManager1 = New ERP_HRMS.DSBuffetAttendanceTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DSDisplayEI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Display_EmpInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Att_EmpVerifyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSAutoAtt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_HR_ActiveCardCopyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Att_MealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Emp_Att1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSBuffetAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_HRM_Emp_Att_MealBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.tbFilePath)
        Me.Panel1.Controls.Add(Me.btnOpenFile)
        Me.Panel1.Location = New System.Drawing.Point(3, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 591)
        Me.Panel1.TabIndex = 43
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(4, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(835, 558)
        Me.DataGridView1.TabIndex = 28
        '
        'tbFilePath
        '
        Me.tbFilePath.ForeColor = System.Drawing.SystemColors.GrayText
        Me.tbFilePath.Location = New System.Drawing.Point(8, 4)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(418, 20)
        Me.tbFilePath.TabIndex = 26
        Me.tbFilePath.TabStop = False
        Me.tbFilePath.Text = "Browse an Excel File Here to Upload Data..."
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnOpenFile.Location = New System.Drawing.Point(434, 1)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(92, 23)
        Me.btnOpenFile.TabIndex = 27
        Me.btnOpenFile.Text = "Browse File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSave.Location = New System.Drawing.Point(855, 78)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 51)
        Me.btnSave.TabIndex = 60
        Me.btnSave.Text = "Upload"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnExit.Location = New System.Drawing.Point(855, 135)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 51)
        Me.btnExit.TabIndex = 61
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(879, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 20)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Saved Records"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(879, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 20)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Successfully Uploaded Data"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.ForestGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(853, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Sienna
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(853, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 19)
        Me.Label3.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1096, 40)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Canteen Attendance Excel to DB"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.ForeColor = System.Drawing.Color.Brown
        Me.Label2.Location = New System.Drawing.Point(8, 639)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Total No. Of Rows"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalRowLabel
        '
        Me.TotalRowLabel.BackColor = System.Drawing.Color.White
        Me.TotalRowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalRowLabel.Location = New System.Drawing.Point(120, 639)
        Me.TotalRowLabel.Name = "TotalRowLabel"
        Me.TotalRowLabel.Size = New System.Drawing.Size(100, 20)
        Me.TotalRowLabel.TabIndex = 64
        Me.TotalRowLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 788)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1096, 25)
        Me.ToolStrip1.TabIndex = 68
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 22)
        Me.ToolStripProgressBar1.Step = 1
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(879, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 20)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Error Records"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Red
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(853, 247)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 20)
        Me.Label13.TabIndex = 69
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Maroon
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(853, 286)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 17)
        Me.RadioButton1.TabIndex = 71
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Attendance In"
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Maroon
        Me.RadioButton2.ForeColor = System.Drawing.Color.Yellow
        Me.RadioButton2.Location = New System.Drawing.Point(853, 309)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(100, 17)
        Me.RadioButton2.TabIndex = 72
        Me.RadioButton2.Text = "Attendance Out"
        Me.RadioButton2.UseVisualStyleBackColor = False
        Me.RadioButton2.Visible = False
        '
        'DSDisplayEI
        '
        Me.DSDisplayEI.DataSetName = "DSDisplayEI"
        Me.DSDisplayEI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Display_EmpInfoBindingSource
        '
        Me.View_Display_EmpInfoBindingSource.DataMember = "View_Display_EmpInfo"
        Me.View_Display_EmpInfoBindingSource.DataSource = Me.DSDisplayEI
        '
        'View_Display_EmpInfoTableAdapter
        '
        Me.View_Display_EmpInfoTableAdapter.ClearBeforeFill = True
        '
        'View_Att_EmpVerifyBindingSource
        '
        Me.View_Att_EmpVerifyBindingSource.DataMember = "View_Att_EmpVerify"
        Me.View_Att_EmpVerifyBindingSource.DataSource = Me.DSDisplayEI
        '
        'View_Att_EmpVerifyTableAdapter
        '
        Me.View_Att_EmpVerifyTableAdapter.ClearBeforeFill = True
        '
        'DSAutoAtt
        '
        Me.DSAutoAtt.DataSetName = "DSAutoAtt"
        Me.DSAutoAtt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Rpt_HR_ActiveCardCopyBindingSource
        '
        Me.View_Rpt_HR_ActiveCardCopyBindingSource.DataMember = "View_Rpt_HR_ActiveCardCopy"
        Me.View_Rpt_HR_ActiveCardCopyBindingSource.DataSource = Me.DSAutoAtt
        '
        'View_Rpt_HR_ActiveCardCopyTableAdapter
        '
        Me.View_Rpt_HR_ActiveCardCopyTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_AttTableAdapter
        '
        Me.Tbl_Hrm_Emp_AttTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_AttBindingSource
        '
        Me.Tbl_Hrm_Emp_AttBindingSource.DataMember = "tbl_Hrm_Emp_Att"
        Me.Tbl_Hrm_Emp_AttBindingSource.DataSource = Me.DSAutoAtt
        '
        'Tbl_HRM_Emp_Att_MealBindingSource
        '
        Me.Tbl_HRM_Emp_Att_MealBindingSource.DataMember = "tbl_HRM_Emp_Att_Meal"
        Me.Tbl_HRM_Emp_Att_MealBindingSource.DataSource = Me.DSAutoAtt
        '
        'Tbl_HRM_Emp_Att_MealTableAdapter
        '
        Me.Tbl_HRM_Emp_Att_MealTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Hrm_Emp_Att1BindingSource
        '
        Me.Tbl_Hrm_Emp_Att1BindingSource.DataMember = "tbl_Hrm_Emp_Att1"
        Me.Tbl_Hrm_Emp_Att1BindingSource.DataSource = Me.DSAutoAtt
        '
        'Tbl_Hrm_Emp_Att1TableAdapter
        '
        Me.Tbl_Hrm_Emp_Att1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Att_Client1_1TableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_Emp_Att_MealTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Hrm_Emp_Att1TableAdapter = Me.Tbl_Hrm_Emp_Att1TableAdapter
        Me.TableAdapterManager.tbl_Hrm_Emp_AttTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSAutoAttTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.View_Rpt_HR_ActiveCardCopyTableAdapter = Nothing
        '
        'DSBuffetAttendance
        '
        Me.DSBuffetAttendance.DataSetName = "DSBuffetAttendance"
        Me.DSBuffetAttendance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_HRM_Emp_Att_MealBindingSource1
        '
        Me.Tbl_HRM_Emp_Att_MealBindingSource1.DataMember = "tbl_HRM_Emp_Att_Meal"
        Me.Tbl_HRM_Emp_Att_MealBindingSource1.DataSource = Me.DSBuffetAttendance
        '
        'Tbl_HRM_Emp_Att_MealTableAdapter1
        '
        Me.Tbl_HRM_Emp_Att_MealTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_HRM_Emp_Att_MealTableAdapter = Me.Tbl_HRM_Emp_Att_MealTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = ERP_HRMS.DSBuffetAttendanceTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmCanteenAttendanceUploading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 813)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TotalRowLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCanteenAttendanceUploading"
        Me.Text = "Canteen Attendance Excel to DB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DSDisplayEI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Display_EmpInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Att_EmpVerifyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSAutoAtt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_HR_ActiveCardCopyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_AttBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Att_MealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Emp_Att1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSBuffetAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_HRM_Emp_Att_MealBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tbFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSAutoAtt As ERP_HRMS.DSAutoAtt
    Friend WithEvents View_Rpt_HR_ActiveCardCopyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_HR_ActiveCardCopyTableAdapter As ERP_HRMS.DSAutoAttTableAdapters.View_Rpt_HR_ActiveCardCopyTableAdapter
    Friend WithEvents DSDisplayEI As ERP_HRMS.DSDisplayEI
    Friend WithEvents View_Display_EmpInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Display_EmpInfoTableAdapter As ERP_HRMS.DSDisplayEITableAdapters.View_Display_EmpInfoTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TotalRowLabel As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Tbl_Hrm_Emp_AttTableAdapter As ERP_HRMS.DSAutoAttTableAdapters.tbl_Hrm_Emp_AttTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_AttBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents View_Att_EmpVerifyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Att_EmpVerifyTableAdapter As ERP_HRMS.DSDisplayEITableAdapters.View_Att_EmpVerifyTableAdapter
    Friend WithEvents Tbl_HRM_Emp_Att_MealBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_HRM_Emp_Att_MealTableAdapter As ERP_HRMS.DSAutoAttTableAdapters.tbl_HRM_Emp_Att_MealTableAdapter
    Friend WithEvents Tbl_Hrm_Emp_Att1BindingSource As BindingSource
    Friend WithEvents Tbl_Hrm_Emp_Att1TableAdapter As DSAutoAttTableAdapters.tbl_Hrm_Emp_Att1TableAdapter
    Friend WithEvents TableAdapterManager As DSAutoAttTableAdapters.TableAdapterManager
    Friend WithEvents DSBuffetAttendance As DSBuffetAttendance
    Friend WithEvents Tbl_HRM_Emp_Att_MealBindingSource1 As BindingSource
    Friend WithEvents Tbl_HRM_Emp_Att_MealTableAdapter1 As DSBuffetAttendanceTableAdapters.tbl_HRM_Emp_Att_MealTableAdapter
    Friend WithEvents TableAdapterManager1 As DSBuffetAttendanceTableAdapters.TableAdapterManager
End Class
