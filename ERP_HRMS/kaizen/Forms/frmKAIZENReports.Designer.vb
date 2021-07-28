<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKAIZENReports
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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnRemove = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lstCards = New System.Windows.Forms.ListBox
        Me.cmbSelectCard = New System.Windows.Forms.ComboBox
        Me.Tbl_Hrm_kaizen_activity_recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSKAIZENRpt = New ERP_HRMS.DSKAIZENRpt
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.RadioOverAll = New System.Windows.Forms.RadioButton
        Me.RadioInternal = New System.Windows.Forms.RadioButton
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.RadioNotApproved = New System.Windows.Forms.RadioButton
        Me.radioapproved = New System.Windows.Forms.RadioButton
        'Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        'Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        'Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        'Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.DTPicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Tbl_Hrm_kaizen_activity_recordTableAdapter = New ERP_HRMS.DSKAIZENRptTableAdapters.tbl_Hrm_kaizen_activity_recordTableAdapter
        Me.TableAdapterManager = New ERP_HRMS.DSKAIZENRptTableAdapters.TableAdapterManager
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Hrm_kaizen_activity_recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSKAIZENRpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(784, 37)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "KAIZEN Activity Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton6)
        Me.Panel1.Controls.Add(Me.RadioButton5)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(36, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 407)
        Me.Panel1.TabIndex = 9
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(18, 103)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(204, 17)
        Me.RadioButton6.TabIndex = 49
        Me.RadioButton6.Text = "Monthly KAIZEN  Submision Summary"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(18, 80)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(201, 17)
        Me.RadioButton5.TabIndex = 48
        Me.RadioButton5.Text = "KAIZEN  Evaluation Summery Report"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(18, 298)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(172, 17)
        Me.RadioButton4.TabIndex = 44
        Me.RadioButton4.Text = "List of KAIZEN by Special Filter"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(299, 19)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Miscellaneous Reports"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(18, 166)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(146, 17)
        Me.RadioButton3.TabIndex = 46
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "KAIZEN Saving Summary"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(299, 19)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Yearly Reports"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(299, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Monthly Reports"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(18, 57)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(189, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Monthly Submission Detail by dept."
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(18, 33)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(181, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "List of Applied KAIZEN Activities "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.DTPicker1)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(434, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 410)
        Me.Panel2.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnRemove)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.lstCards)
        Me.GroupBox2.Controls.Add(Me.cmbSelectCard)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 205)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Special Filters"
        Me.GroupBox2.Visible = False
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Brown
        Me.btnRemove.Location = New System.Drawing.Point(178, 43)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(104, 23)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnAdd.Location = New System.Drawing.Point(10, 43)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(104, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstCards
        '
        Me.lstCards.FormattingEnabled = True
        Me.lstCards.Location = New System.Drawing.Point(10, 72)
        Me.lstCards.Name = "lstCards"
        Me.lstCards.Size = New System.Drawing.Size(272, 121)
        Me.lstCards.TabIndex = 4
        '
        'cmbSelectCard
        '
        Me.cmbSelectCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbSelectCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSelectCard.DataSource = Me.Tbl_Hrm_kaizen_activity_recordBindingSource
        Me.cmbSelectCard.DisplayMember = "KARCode"
        Me.cmbSelectCard.FormattingEnabled = True
        Me.cmbSelectCard.Location = New System.Drawing.Point(98, 16)
        Me.cmbSelectCard.Name = "cmbSelectCard"
        Me.cmbSelectCard.Size = New System.Drawing.Size(184, 21)
        Me.cmbSelectCard.TabIndex = 1
        Me.cmbSelectCard.ValueMember = "KARCode"
        '
        'Tbl_Hrm_kaizen_activity_recordBindingSource
        '
        Me.Tbl_Hrm_kaizen_activity_recordBindingSource.DataMember = "tbl_Hrm_kaizen_activity_record"
        Me.Tbl_Hrm_kaizen_activity_recordBindingSource.DataSource = Me.DSKAIZENRpt
        '
        'DSKAIZENRpt
        '
        Me.DSKAIZENRpt.DataSetName = "DSKAIZENRpt"
        Me.DSKAIZENRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(10, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 20)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "KAIZEN Code:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel4)
        'Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(186, 65)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KAIZEN Nature"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.RadioOverAll)
        Me.Panel5.Controls.Add(Me.RadioInternal)
        Me.Panel5.Location = New System.Drawing.Point(6, 37)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(174, 25)
        Me.Panel5.TabIndex = 2
        '
        'RadioOverAll
        '
        Me.RadioOverAll.AutoSize = True
        Me.RadioOverAll.Location = New System.Drawing.Point(80, 4)
        Me.RadioOverAll.Name = "RadioOverAll"
        Me.RadioOverAll.Size = New System.Drawing.Size(58, 17)
        Me.RadioOverAll.TabIndex = 2
        Me.RadioOverAll.TabStop = True
        Me.RadioOverAll.Text = "Overall"
        Me.RadioOverAll.UseVisualStyleBackColor = True
        '
        'RadioInternal
        '
        Me.RadioInternal.AutoSize = True
        Me.RadioInternal.Location = New System.Drawing.Point(3, 4)
        Me.RadioInternal.Name = "RadioInternal"
        Me.RadioInternal.Size = New System.Drawing.Size(60, 17)
        Me.RadioInternal.TabIndex = 1
        Me.RadioInternal.TabStop = True
        Me.RadioInternal.Text = "Internal"
        Me.RadioInternal.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.RadioNotApproved)
        Me.Panel4.Controls.Add(Me.radioapproved)
        'Me.Panel4.Controls.Add(Me.ShapeContainer2)
        Me.Panel4.Location = New System.Drawing.Point(6, 13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(174, 25)
        Me.Panel4.TabIndex = 1
        '
        'RadioNotApproved
        '
        Me.RadioNotApproved.AutoSize = True
        Me.RadioNotApproved.Location = New System.Drawing.Point(80, 4)
        Me.RadioNotApproved.Name = "RadioNotApproved"
        Me.RadioNotApproved.Size = New System.Drawing.Size(91, 17)
        Me.RadioNotApproved.TabIndex = 2
        Me.RadioNotApproved.TabStop = True
        Me.RadioNotApproved.Text = "Not Approved"
        Me.RadioNotApproved.UseVisualStyleBackColor = True
        '
        'radioapproved
        '
        Me.radioapproved.AutoSize = True
        Me.radioapproved.Location = New System.Drawing.Point(3, 4)
        Me.radioapproved.Name = "radioapproved"
        Me.radioapproved.Size = New System.Drawing.Size(71, 17)
        Me.radioapproved.TabIndex = 1
        Me.radioapproved.TabStop = True
        Me.radioapproved.Text = "Approved"
        Me.radioapproved.UseVisualStyleBackColor = True
        '
        'ShapeContainer2
        '
        'Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        'Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        'Me.ShapeContainer2.Name = "ShapeContainer2"
        ''Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3})
        'Me.ShapeContainer2.Size = New System.Drawing.Size(172, 23)
        'Me.ShapeContainer2.TabIndex = 3
        'Me.ShapeContainer2.TabStop = False
        ''
        ''LineShape3
        ''
        'Me.LineShape3.Name = "LineShape3"
        'Me.LineShape3.X1 = 70
        'Me.LineShape3.X2 = 90
        'Me.LineShape3.Y1 = 27
        'Me.LineShape3.Y2 = 27
        ''
        ''ShapeContainer1
        ''
        'Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        'Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        'Me.ShapeContainer1.Name = "ShapeContainer1"
        ''Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2})
        'Me.ShapeContainer1.Size = New System.Drawing.Size(180, 46)
        'Me.ShapeContainer1.TabIndex = 3
        'Me.ShapeContainer1.TabStop = False
        ''
        ''LineShape2
        ''
        'Me.LineShape2.Name = "LineShape2"
        'Me.LineShape2.X1 = 181
        'Me.LineShape2.X2 = 256
        'Me.LineShape2.Y1 = 27
        'Me.LineShape2.Y2 = 50
        '
        'DTPicker1
        '
        Me.DTPicker1.CustomFormat = "MMM-yyyy"
        Me.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPicker1.Location = New System.Drawing.Point(76, 14)
        Me.DTPicker1.Name = "DTPicker1"
        Me.DTPicker1.Size = New System.Drawing.Size(119, 20)
        Me.DTPicker1.TabIndex = 46
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM-yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(9, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "To Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(9, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "From Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(658, 512)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 29)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(540, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 29)
        Me.Button1.TabIndex = 42
        Me.Button1.Text = "View Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Tbl_Hrm_kaizen_activity_recordTableAdapter
        '
        Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Hrm_kaizen_activity_recordTableAdapter = Me.Tbl_Hrm_kaizen_activity_recordTableAdapter
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSKAIZENRptTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmKAIZENReports
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmKAIZENReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKAIZENReports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Tbl_Hrm_kaizen_activity_recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSKAIZENRpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DTPicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents RadioOverAll As System.Windows.Forms.RadioButton
    Friend WithEvents RadioInternal As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents RadioNotApproved As System.Windows.Forms.RadioButton
    Friend WithEvents radioapproved As System.Windows.Forms.RadioButton
    'Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    'Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    'Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lstCards As System.Windows.Forms.ListBox
    Friend WithEvents cmbSelectCard As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DSKAIZENRpt As ERP_HRMS.DSKAIZENRpt
    Friend WithEvents Tbl_Hrm_kaizen_activity_recordBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_kaizen_activity_recordTableAdapter As ERP_HRMS.DSKAIZENRptTableAdapters.tbl_Hrm_kaizen_activity_recordTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSKAIZENRptTableAdapters.TableAdapterManager
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
End Class
