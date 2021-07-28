<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutoCompleteCombo
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DSBusInfo = New ERP_HRMS.DSBusInfo
        Me.Tbl_Bus_OwnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Bus_OwnerTableAdapter = New ERP_HRMS.DSBusInfoTableAdapters.tbl_Bus_OwnerTableAdapter
        Me.TableAdapterManager = New ERP_HRMS.DSBusInfoTableAdapters.TableAdapterManager
        Me.ListBox1 = New System.Windows.Forms.ListBox
        CType(Me.DSBusInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Bus_OwnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.ComboBox1.DataSource = Me.Tbl_Bus_OwnerBindingSource
        Me.ComboBox1.DisplayMember = "OwnerName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(371, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(306, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "OwnerID"
        '
        'TextBox1
        '
        Me.TextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl
        Me.TextBox1.Location = New System.Drawing.Point(371, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 20)
        Me.TextBox1.TabIndex = 1
        '
        'DSBusInfo
        '
        Me.DSBusInfo.DataSetName = "DSBusInfo"
        Me.DSBusInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Bus_OwnerBindingSource
        '
        Me.Tbl_Bus_OwnerBindingSource.DataMember = "tbl_Bus_Owner"
        Me.Tbl_Bus_OwnerBindingSource.DataSource = Me.DSBusInfo
        '
        'Tbl_Bus_OwnerTableAdapter
        '
        Me.Tbl_Bus_OwnerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Bus_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Bus_OwnerTableAdapter = Me.Tbl_Bus_OwnerTableAdapter
        Me.TableAdapterManager.tbl_Bus_Route_FareTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Bus_Route_InfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSBusInfoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.Tbl_Bus_OwnerBindingSource
        Me.ListBox1.DisplayMember = "OwnerName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(371, 106)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(306, 95)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.ValueMember = "OwnerID"
        '
        'frmAutoCompleteCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 569)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frmAutoCompleteCombo"
        Me.Text = "frmAutoCompleteCombo"
        CType(Me.DSBusInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Bus_OwnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DSBusInfo As ERP_HRMS.DSBusInfo
    Friend WithEvents Tbl_Bus_OwnerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Bus_OwnerTableAdapter As ERP_HRMS.DSBusInfoTableAdapters.tbl_Bus_OwnerTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DSBusInfoTableAdapters.TableAdapterManager
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
