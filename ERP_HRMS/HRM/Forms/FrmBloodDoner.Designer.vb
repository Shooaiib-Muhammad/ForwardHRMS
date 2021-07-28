<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBloodDoner
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
        Dim CardNoLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBloodDoner))
        Dim Label10 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BloodDoner = New ERP_HRMS.BloodDoner()
        Me.View_Blood_DonerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_Blood_DonerTableAdapter = New ERP_HRMS.BloodDonerTableAdapters.View_Blood_DonerTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.BloodDonerTableAdapters.TableAdapterManager()
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DeptNameLabel1 = New System.Windows.Forms.Label()
        Me.View_Blood_DonerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label11 = New System.Windows.Forms.Label()
        CardNoLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DeptNameLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.BloodDoner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Blood_DonerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Blood_DonerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.View_Blood_DonerBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CardNoLabel
        '
        CardNoLabel.AutoSize = True
        CardNoLabel.Location = New System.Drawing.Point(20, 82)
        CardNoLabel.Name = "CardNoLabel"
        CardNoLabel.Size = New System.Drawing.Size(49, 13)
        CardNoLabel.TabIndex = 3
        CardNoLabel.Text = "Card No:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(31, 110)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'DeptNameLabel
        '
        DeptNameLabel.AutoSize = True
        DeptNameLabel.Location = New System.Drawing.Point(5, 138)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(65, 13)
        DeptNameLabel.TabIndex = 5
        DeptNameLabel.Text = "Department:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(23, 166)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(46, 13)
        Label3.TabIndex = 8
        Label3.Text = "Section:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(3, 194)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(69, 13)
        Label5.TabIndex = 10
        Label5.Text = "Designation :"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(199, 84)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(28, 13)
        Label7.TabIndex = 13
        Label7.Text = "DOJ"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1046, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Employee Blood Donation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BloodDoner
        '
        Me.BloodDoner.DataSetName = "BloodDoner"
        Me.BloodDoner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_Blood_DonerBindingSource
        '
        Me.View_Blood_DonerBindingSource.DataMember = "View_Blood_Doner"
        Me.View_Blood_DonerBindingSource.DataSource = Me.BloodDoner
        '
        'View_Blood_DonerTableAdapter
        '
        Me.View_Blood_DonerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tbl_HRMS_Blood_DonerTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.BloodDonerTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataSource = Me.View_Blood_DonerBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(75, 79)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CardNoComboBox.TabIndex = 4
        Me.CardNoComboBox.ValueMember = "EmpID"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(DeptNameLabel)
        Me.Panel1.Controls.Add(Me.DeptNameLabel1)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.View_Blood_DonerBindingNavigator)
        Me.Panel1.Controls.Add(CardNoLabel)
        Me.Panel1.Controls.Add(Me.CardNoComboBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 283)
        Me.Panel1.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(0, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(489, 38)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Blood Doner"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Blood_DonerBindingSource, "DateOFJoining", True))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(233, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.View_Blood_DonerBindingSource, "EmpPic", True))
        Me.PictureBox1.Location = New System.Drawing.Point(368, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(97, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Blood_DonerBindingSource, "DesigName", True))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(75, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(287, 23)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Blood_DonerBindingSource, "SectionName", True))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Blood_DonerBindingSource, "Name", True))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(75, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Blood_DonerBindingSource, "DeptName", True))
        Me.DeptNameLabel1.ForeColor = System.Drawing.Color.White
        Me.DeptNameLabel1.Location = New System.Drawing.Point(75, 133)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(287, 23)
        Me.DeptNameLabel1.TabIndex = 6
        Me.DeptNameLabel1.Text = "Label2"
        '
        'View_Blood_DonerBindingNavigator
        '
        Me.View_Blood_DonerBindingNavigator.AddNewItem = Nothing
        Me.View_Blood_DonerBindingNavigator.BindingSource = Me.View_Blood_DonerBindingSource
        Me.View_Blood_DonerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.View_Blood_DonerBindingNavigator.DeleteItem = Nothing
        Me.View_Blood_DonerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.View_Blood_DonerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.View_Blood_DonerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.View_Blood_DonerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.View_Blood_DonerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.View_Blood_DonerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.View_Blood_DonerBindingNavigator.Name = "View_Blood_DonerBindingNavigator"
        Me.View_Blood_DonerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.View_Blood_DonerBindingNavigator.Size = New System.Drawing.Size(489, 25)
        Me.View_Blood_DonerBindingNavigator.TabIndex = 4
        Me.View_Blood_DonerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(-1, 222)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(72, 13)
        Label10.TabIndex = 16
        Label10.Text = "Blood Group :"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Blood_DonerBindingSource, "BloodGroup", True))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(75, 217)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 23)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Label2"
        '
        'FrmBloodDoner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 699)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmBloodDoner"
        Me.Text = "Blood Doner"
        CType(Me.BloodDoner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Blood_DonerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Blood_DonerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.View_Blood_DonerBindingNavigator.ResumeLayout(False)
        Me.View_Blood_DonerBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BloodDoner As BloodDoner
    Friend WithEvents View_Blood_DonerBindingSource As BindingSource
    Friend WithEvents View_Blood_DonerTableAdapter As BloodDonerTableAdapters.View_Blood_DonerTableAdapter
    Friend WithEvents TableAdapterManager As BloodDonerTableAdapters.TableAdapterManager
    Friend WithEvents CardNoComboBox As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents View_Blood_DonerBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DeptNameLabel1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
End Class
