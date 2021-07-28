<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InCentive
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ErrorBtn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.F6 = New System.Windows.Forms.RadioButton()
        Me.F3QA = New System.Windows.Forms.RadioButton()
        Me.F3 = New System.Windows.Forms.RadioButton()
        Me.MAinQA = New System.Windows.Forms.RadioButton()
        Me.RadioButton30 = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(967, 40)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Incentive Reports"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ErrorBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(21, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 55)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Selection"
        '
        'ErrorBtn
        '
        Me.ErrorBtn.AutoSize = True
        Me.ErrorBtn.Checked = True
        Me.ErrorBtn.ForeColor = System.Drawing.Color.Black
        Me.ErrorBtn.Location = New System.Drawing.Point(11, 22)
        Me.ErrorBtn.Name = "ErrorBtn"
        Me.ErrorBtn.Size = New System.Drawing.Size(129, 21)
        Me.ErrorBtn.TabIndex = 50
        Me.ErrorBtn.TabStop = True
        Me.ErrorBtn.Text = "Incentive Report"
        Me.ErrorBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MAinQA)
        Me.GroupBox1.Controls.Add(Me.RadioButton30)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(21, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 74)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Option Selector"
        '
        'F6
        '
        Me.F6.AutoSize = True
        Me.F6.ForeColor = System.Drawing.Color.Black
        Me.F6.Location = New System.Drawing.Point(518, 202)
        Me.F6.Name = "F6"
        Me.F6.Size = New System.Drawing.Size(124, 17)
        Me.F6.TabIndex = 3
        Me.F6.TabStop = True
        Me.F6.Text = "F6 (Bladder Winding)"
        Me.F6.UseVisualStyleBackColor = True
        Me.F6.Visible = False
        '
        'F3QA
        '
        Me.F3QA.AutoSize = True
        Me.F3QA.ForeColor = System.Drawing.Color.Black
        Me.F3QA.Location = New System.Drawing.Point(518, 177)
        Me.F3QA.Name = "F3QA"
        Me.F3QA.Size = New System.Drawing.Size(131, 17)
        Me.F3QA.TabIndex = 2
        Me.F3QA.TabStop = True
        Me.F3QA.Text = "F3 (Quality Assurance)"
        Me.F3QA.UseVisualStyleBackColor = True
        Me.F3QA.Visible = False
        '
        'F3
        '
        Me.F3.AutoSize = True
        Me.F3.ForeColor = System.Drawing.Color.Black
        Me.F3.Location = New System.Drawing.Point(518, 152)
        Me.F3.Name = "F3"
        Me.F3.Size = New System.Drawing.Size(244, 17)
        Me.F3.TabIndex = 1
        Me.F3.Text = "F3 (Machine Stitch Production,TM Production)"
        Me.F3.UseVisualStyleBackColor = True
        Me.F3.Visible = False
        '
        'MAinQA
        '
        Me.MAinQA.AutoSize = True
        Me.MAinQA.ForeColor = System.Drawing.Color.Black
        Me.MAinQA.Location = New System.Drawing.Point(10, 44)
        Me.MAinQA.Name = "MAinQA"
        Me.MAinQA.Size = New System.Drawing.Size(176, 21)
        Me.MAinQA.TabIndex = 1
        Me.MAinQA.Text = "Main Unit QA(MS+AMB)"
        Me.MAinQA.UseVisualStyleBackColor = True
        '
        'RadioButton30
        '
        Me.RadioButton30.AutoSize = True
        Me.RadioButton30.Checked = True
        Me.RadioButton30.ForeColor = System.Drawing.Color.Black
        Me.RadioButton30.Location = New System.Drawing.Point(10, 19)
        Me.RadioButton30.Name = "RadioButton30"
        Me.RadioButton30.Size = New System.Drawing.Size(156, 21)
        Me.RadioButton30.TabIndex = 0
        Me.RadioButton30.TabStop = True
        Me.RadioButton30.Text = "Main Unit (MS+AMB)"
        Me.RadioButton30.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox6.Location = New System.Drawing.Point(191, 59)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(241, 54)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Select Month "
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(115, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(109, 23)
        Me.DateTimePicker1.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Select Month:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(219, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 45)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Show Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'InCentive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 710)
        Me.Controls.Add(Me.F6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.F3QA)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.F3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "InCentive"
        Me.Text = "Incentive Reports"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ErrorBtn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents F6 As RadioButton
    Friend WithEvents F3QA As RadioButton
    Friend WithEvents F3 As RadioButton
    Friend WithEvents MAinQA As RadioButton
    Friend WithEvents RadioButton30 As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
