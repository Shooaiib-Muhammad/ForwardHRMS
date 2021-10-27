<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoAbsent
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet8 = New ERP_HRMS.DataSet8()
        Me.MissingAttendence1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MissingAttendence1TableAdapter = New ERP_HRMS.DataSet8TableAdapters.MissingAttendence1TableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DataSet8TableAdapters.TableAdapterManager()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MissingAttendence1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(26, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(574, 115)
        Me.Panel2.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(571, 110)
        Me.Panel1.TabIndex = 7
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yy HH:mm"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(291, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(148, 20)
        Me.DateTimePicker2.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(235, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "To Date :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yy HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(148, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(320, 64)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 30)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save Record"
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
        Me.Label14.Size = New System.Drawing.Size(569, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Select Date Range to Generate Absents"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "From Date :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(655, 40)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Auto Absent Generation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet8
        '
        Me.DataSet8.DataSetName = "DataSet8"
        Me.DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MissingAttendence1BindingSource
        '
        Me.MissingAttendence1BindingSource.DataMember = "MissingAttendence1"
        Me.MissingAttendence1BindingSource.DataSource = Me.DataSet8
        '
        'MissingAttendence1TableAdapter
        '
        Me.MissingAttendence1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmAutoAbsent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 227)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmAutoAbsent"
        Me.Text = "frmAutoAbsent"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MissingAttendence1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet8 As DataSet8
    Friend WithEvents MissingAttendence1BindingSource As BindingSource
    Friend WithEvents MissingAttendence1TableAdapter As DataSet8TableAdapters.MissingAttendence1TableAdapter
    Friend WithEvents TableAdapterManager As DataSet8TableAdapters.TableAdapterManager
End Class
