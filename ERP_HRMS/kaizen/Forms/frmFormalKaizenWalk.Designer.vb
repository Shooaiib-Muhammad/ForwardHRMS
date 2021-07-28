<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFormalKaizenWalk
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
        Dim FKWIDLabel As System.Windows.Forms.Label
        Dim VisitDateLabel As System.Windows.Forms.Label
        Dim VisitTimeLabel As System.Windows.Forms.Label
        Dim VisitLocationLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim DeptNameLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim FKWDIDLabel As System.Windows.Forms.Label
        Dim CardNoLabel2 As System.Windows.Forms.Label
        Dim AgendaLabel As System.Windows.Forms.Label
        Dim ObservationLabel As System.Windows.Forms.Label
        Dim SolutionLabel As System.Windows.Forms.Label
        Dim ReleventDeptLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFormalKaizenWalk))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CommentsTextBox = New System.Windows.Forms.TextBox
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet6 = New ERP_HRMS.DataSet6
        Me.VisitLocationTextBox = New System.Windows.Forms.TextBox
        Me.VisitTimeDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.VisitDateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.FKWIDLabel1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.StatusComboBox = New System.Windows.Forms.ComboBox
        Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReleventDeptTextBox = New System.Windows.Forms.TextBox
        Me.DeptNameLabel1 = New System.Windows.Forms.Label
        Me.View_Rpt_Acc_PreSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolutionTextBox = New System.Windows.Forms.TextBox
        Me.ObservationTextBox = New System.Windows.Forms.TextBox
        Me.NameLabel1 = New System.Windows.Forms.Label
        Me.AgendaTextBox = New System.Windows.Forms.TextBox
        Me.CardNoComboBox = New System.Windows.Forms.ComboBox
        Me.FKWDIDLabel1 = New System.Windows.Forms.Label
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.UserIDLabel1 = New System.Windows.Forms.Label
        Me.Tbl_Hrm_Formal_Kaizen_HeadTableAdapter = New ERP_HRMS.DataSet6TableAdapters.tbl_Hrm_Formal_Kaizen_HeadTableAdapter
        Me.TableAdapterManager = New ERP_HRMS.DataSet6TableAdapters.TableAdapterManager
        Me.Tbl_Hrm_Formal_Kaizen_DetailTableAdapter = New ERP_HRMS.DataSet6TableAdapters.tbl_Hrm_Formal_Kaizen_DetailTableAdapter
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter = New ERP_HRMS.DataSet6TableAdapters.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter
        Me.View_Rpt_Acc_PreSalaryTableAdapter = New ERP_HRMS.DataSet6TableAdapters.View_Rpt_Acc_PreSalaryTableAdapter
        'Me.Clock1 = New AnalogClock.Clock
        FKWIDLabel = New System.Windows.Forms.Label
        VisitDateLabel = New System.Windows.Forms.Label
        VisitTimeLabel = New System.Windows.Forms.Label
        VisitLocationLabel = New System.Windows.Forms.Label
        CommentsLabel = New System.Windows.Forms.Label
        DeptNameLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        FKWDIDLabel = New System.Windows.Forms.Label
        CardNoLabel2 = New System.Windows.Forms.Label
        AgendaLabel = New System.Windows.Forms.Label
        ObservationLabel = New System.Windows.Forms.Label
        SolutionLabel = New System.Windows.Forms.Label
        ReleventDeptLabel = New System.Windows.Forms.Label
        StatusLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FKWIDLabel
        '
        FKWIDLabel.BackColor = System.Drawing.Color.LightGray
        FKWIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        FKWIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FKWIDLabel.Location = New System.Drawing.Point(8, 35)
        FKWIDLabel.Name = "FKWIDLabel"
        FKWIDLabel.Size = New System.Drawing.Size(99, 20)
        FKWIDLabel.TabIndex = 0
        FKWIDLabel.Text = "FKWID:"
        FKWIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VisitDateLabel
        '
        VisitDateLabel.BackColor = System.Drawing.Color.LightGray
        VisitDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        VisitDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VisitDateLabel.Location = New System.Drawing.Point(187, 35)
        VisitDateLabel.Name = "VisitDateLabel"
        VisitDateLabel.Size = New System.Drawing.Size(99, 20)
        VisitDateLabel.TabIndex = 12
        VisitDateLabel.Text = "Visit Date:"
        VisitDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VisitTimeLabel
        '
        VisitTimeLabel.BackColor = System.Drawing.Color.LightGray
        VisitTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        VisitTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VisitTimeLabel.Location = New System.Drawing.Point(397, 35)
        VisitTimeLabel.Name = "VisitTimeLabel"
        VisitTimeLabel.Size = New System.Drawing.Size(90, 20)
        VisitTimeLabel.TabIndex = 13
        VisitTimeLabel.Text = "Visit Time:"
        VisitTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'VisitLocationLabel
        '
        VisitLocationLabel.BackColor = System.Drawing.Color.LightGray
        VisitLocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        VisitLocationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VisitLocationLabel.Location = New System.Drawing.Point(9, 66)
        VisitLocationLabel.Name = "VisitLocationLabel"
        VisitLocationLabel.Size = New System.Drawing.Size(99, 20)
        VisitLocationLabel.TabIndex = 14
        VisitLocationLabel.Text = "Location:"
        VisitLocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CommentsLabel
        '
        CommentsLabel.BackColor = System.Drawing.Color.LightGray
        CommentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        CommentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CommentsLabel.Location = New System.Drawing.Point(8, 95)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(99, 20)
        CommentsLabel.TabIndex = 15
        CommentsLabel.Text = "Comments:"
        CommentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DeptNameLabel
        '
        DeptNameLabel.BackColor = System.Drawing.Color.LightGray
        DeptNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DeptNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeptNameLabel.Location = New System.Drawing.Point(632, 37)
        DeptNameLabel.Name = "DeptNameLabel"
        DeptNameLabel.Size = New System.Drawing.Size(90, 20)
        DeptNameLabel.TabIndex = 27
        DeptNameLabel.Text = "Dept Name:"
        DeptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameLabel
        '
        NameLabel.BackColor = System.Drawing.Color.LightGray
        NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(397, 37)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(90, 20)
        NameLabel.TabIndex = 25
        NameLabel.Text = "Name:"
        NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FKWDIDLabel
        '
        FKWDIDLabel.BackColor = System.Drawing.Color.LightGray
        FKWDIDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        FKWDIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FKWDIDLabel.Location = New System.Drawing.Point(8, 37)
        FKWDIDLabel.Name = "FKWDIDLabel"
        FKWDIDLabel.Size = New System.Drawing.Size(99, 20)
        FKWDIDLabel.TabIndex = 1
        FKWDIDLabel.Text = "FKWDID:"
        FKWDIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CardNoLabel2
        '
        CardNoLabel2.BackColor = System.Drawing.Color.LightGray
        CardNoLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        CardNoLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CardNoLabel2.Location = New System.Drawing.Point(187, 37)
        CardNoLabel2.Name = "CardNoLabel2"
        CardNoLabel2.Size = New System.Drawing.Size(99, 20)
        CardNoLabel2.TabIndex = 3
        CardNoLabel2.Text = "Card No:"
        '
        'AgendaLabel
        '
        AgendaLabel.BackColor = System.Drawing.Color.LightGray
        AgendaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        AgendaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgendaLabel.Location = New System.Drawing.Point(8, 69)
        AgendaLabel.Name = "AgendaLabel"
        AgendaLabel.Size = New System.Drawing.Size(99, 130)
        AgendaLabel.TabIndex = 5
        AgendaLabel.Text = "Agenda:"
        AgendaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ObservationLabel
        '
        ObservationLabel.BackColor = System.Drawing.Color.LightGray
        ObservationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ObservationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObservationLabel.Location = New System.Drawing.Point(311, 69)
        ObservationLabel.Name = "ObservationLabel"
        ObservationLabel.Size = New System.Drawing.Size(99, 130)
        ObservationLabel.TabIndex = 7
        ObservationLabel.Text = "Observation:"
        ObservationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SolutionLabel
        '
        SolutionLabel.BackColor = System.Drawing.Color.LightGray
        SolutionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        SolutionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SolutionLabel.Location = New System.Drawing.Point(614, 69)
        SolutionLabel.Name = "SolutionLabel"
        SolutionLabel.Size = New System.Drawing.Size(99, 130)
        SolutionLabel.TabIndex = 9
        SolutionLabel.Text = "Solution:"
        SolutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ReleventDeptLabel
        '
        ReleventDeptLabel.BackColor = System.Drawing.Color.LightGray
        ReleventDeptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ReleventDeptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReleventDeptLabel.Location = New System.Drawing.Point(9, 210)
        ReleventDeptLabel.Name = "ReleventDeptLabel"
        ReleventDeptLabel.Size = New System.Drawing.Size(99, 130)
        ReleventDeptLabel.TabIndex = 11
        ReleventDeptLabel.Text = "Relevent Dept:"
        ReleventDeptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'StatusLabel
        '
        StatusLabel.BackColor = System.Drawing.Color.LightGray
        StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(312, 210)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(97, 129)
        StatusLabel.TabIndex = 28
        StatusLabel.Text = "Status:"
        StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(998, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Formal KAIZEN Walk"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(CommentsLabel)
        Me.Panel1.Controls.Add(Me.CommentsTextBox)
        Me.Panel1.Controls.Add(VisitLocationLabel)
        Me.Panel1.Controls.Add(Me.VisitLocationTextBox)
        Me.Panel1.Controls.Add(VisitTimeLabel)
        Me.Panel1.Controls.Add(Me.VisitTimeDateTimePicker)
        Me.Panel1.Controls.Add(VisitDateLabel)
        Me.Panel1.Controls.Add(Me.VisitDateDateTimePicker)
        Me.Panel1.Controls.Add(Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator)
        Me.Panel1.Controls.Add(FKWIDLabel)
        Me.Panel1.Controls.Add(Me.FKWIDLabel1)
        Me.Panel1.Location = New System.Drawing.Point(39, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 131)
        Me.Panel1.TabIndex = 10
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(113, 95)
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(484, 20)
        Me.CommentsTextBox.TabIndex = 3
        '
        'Tbl_Hrm_Formal_Kaizen_HeadBindingSource
        '
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource.DataMember = "tbl_Hrm_Formal_Kaizen_Head"
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource.DataSource = Me.DataSet6
        '
        'DataSet6
        '
        Me.DataSet6.DataSetName = "DataSet6"
        Me.DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitLocationTextBox
        '
        Me.VisitLocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource, "VisitLocation", True))
        Me.VisitLocationTextBox.Location = New System.Drawing.Point(113, 66)
        Me.VisitLocationTextBox.Name = "VisitLocationTextBox"
        Me.VisitLocationTextBox.Size = New System.Drawing.Size(484, 20)
        Me.VisitLocationTextBox.TabIndex = 2
        '
        'VisitTimeDateTimePicker
        '
        Me.VisitTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource, "VisitTime", True))
        Me.VisitTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.VisitTimeDateTimePicker.Location = New System.Drawing.Point(493, 35)
        Me.VisitTimeDateTimePicker.Name = "VisitTimeDateTimePicker"
        Me.VisitTimeDateTimePicker.Size = New System.Drawing.Size(104, 20)
        Me.VisitTimeDateTimePicker.TabIndex = 1
        '
        'VisitDateDateTimePicker
        '
        Me.VisitDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource, "VisitDate", True))
        Me.VisitDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.VisitDateDateTimePicker.Location = New System.Drawing.Point(293, 35)
        Me.VisitDateDateTimePicker.Name = "VisitDateDateTimePicker"
        Me.VisitDateDateTimePicker.Size = New System.Drawing.Size(98, 20)
        Me.VisitDateDateTimePicker.TabIndex = 0
        '
        'Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator
        '
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.BindingSource = Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem})
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.Name = "Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator"
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.Size = New System.Drawing.Size(611, 25)
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.TabIndex = 12
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
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
        'Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem
        '
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem.Name = "Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem"
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem.Text = "Save Data"
        '
        'FKWIDLabel1
        '
        Me.FKWIDLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FKWIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FKWIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource, "FKWID", True))
        Me.FKWIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FKWIDLabel1.Location = New System.Drawing.Point(113, 35)
        Me.FKWIDLabel1.Name = "FKWIDLabel1"
        Me.FKWIDLabel1.Size = New System.Drawing.Size(60, 20)
        Me.FKWIDLabel1.TabIndex = 1
        Me.FKWIDLabel1.Text = "Label2"
        Me.FKWIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(StatusLabel)
        Me.Panel2.Controls.Add(Me.StatusComboBox)
        Me.Panel2.Controls.Add(ReleventDeptLabel)
        Me.Panel2.Controls.Add(DeptNameLabel)
        Me.Panel2.Controls.Add(Me.ReleventDeptTextBox)
        Me.Panel2.Controls.Add(SolutionLabel)
        Me.Panel2.Controls.Add(Me.DeptNameLabel1)
        Me.Panel2.Controls.Add(Me.SolutionTextBox)
        Me.Panel2.Controls.Add(ObservationLabel)
        Me.Panel2.Controls.Add(Me.ObservationTextBox)
        Me.Panel2.Controls.Add(NameLabel)
        Me.Panel2.Controls.Add(AgendaLabel)
        Me.Panel2.Controls.Add(Me.NameLabel1)
        Me.Panel2.Controls.Add(Me.AgendaTextBox)
        Me.Panel2.Controls.Add(CardNoLabel2)
        Me.Panel2.Controls.Add(Me.CardNoComboBox)
        Me.Panel2.Controls.Add(FKWDIDLabel)
        Me.Panel2.Controls.Add(Me.FKWDIDLabel1)
        Me.Panel2.Controls.Add(Me.BindingNavigator1)
        Me.Panel2.Location = New System.Drawing.Point(39, 200)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(931, 357)
        Me.Panel2.TabIndex = 11
        '
        'StatusComboBox
        '
        Me.StatusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StatusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Not Started", "Droppped", "Completed", "Under Process"})
        Me.StatusComboBox.Location = New System.Drawing.Point(415, 244)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(193, 21)
        Me.StatusComboBox.TabIndex = 7
        '
        'Tbl_Hrm_Formal_Kaizen_DetailBindingSource
        '
        Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource.DataMember = "tbl_Hrm_Formal_Kaizen_Head_tbl_Hrm_Formal_Kaizen_Detail"
        Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource.DataSource = Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource
        '
        'ReleventDeptTextBox
        '
        Me.ReleventDeptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, "ReleventDept", True))
        Me.ReleventDeptTextBox.Location = New System.Drawing.Point(113, 210)
        Me.ReleventDeptTextBox.Multiline = True
        Me.ReleventDeptTextBox.Name = "ReleventDeptTextBox"
        Me.ReleventDeptTextBox.Size = New System.Drawing.Size(193, 130)
        Me.ReleventDeptTextBox.TabIndex = 6
        '
        'DeptNameLabel1
        '
        Me.DeptNameLabel1.BackColor = System.Drawing.Color.White
        Me.DeptNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeptNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "SubDept2", True))
        Me.DeptNameLabel1.Location = New System.Drawing.Point(728, 37)
        Me.DeptNameLabel1.Name = "DeptNameLabel1"
        Me.DeptNameLabel1.Size = New System.Drawing.Size(180, 20)
        Me.DeptNameLabel1.TabIndex = 2
        Me.DeptNameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'View_Rpt_Acc_PreSalaryBindingSource
        '
        Me.View_Rpt_Acc_PreSalaryBindingSource.DataMember = "View_Rpt_Acc_PreSalary"
        Me.View_Rpt_Acc_PreSalaryBindingSource.DataSource = Me.DataSet6
        '
        'SolutionTextBox
        '
        Me.SolutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, "Solution", True))
        Me.SolutionTextBox.Location = New System.Drawing.Point(716, 69)
        Me.SolutionTextBox.Multiline = True
        Me.SolutionTextBox.Name = "SolutionTextBox"
        Me.SolutionTextBox.Size = New System.Drawing.Size(193, 130)
        Me.SolutionTextBox.TabIndex = 5
        '
        'ObservationTextBox
        '
        Me.ObservationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, "Observation", True))
        Me.ObservationTextBox.Location = New System.Drawing.Point(415, 69)
        Me.ObservationTextBox.Multiline = True
        Me.ObservationTextBox.Name = "ObservationTextBox"
        Me.ObservationTextBox.Size = New System.Drawing.Size(193, 130)
        Me.ObservationTextBox.TabIndex = 4
        '
        'NameLabel1
        '
        Me.NameLabel1.BackColor = System.Drawing.Color.White
        Me.NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_Rpt_Acc_PreSalaryBindingSource, "FName", True))
        Me.NameLabel1.Location = New System.Drawing.Point(493, 37)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(119, 20)
        Me.NameLabel1.TabIndex = 1
        Me.NameLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AgendaTextBox
        '
        Me.AgendaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, "Agenda", True))
        Me.AgendaTextBox.Location = New System.Drawing.Point(113, 69)
        Me.AgendaTextBox.Multiline = True
        Me.AgendaTextBox.Name = "AgendaTextBox"
        Me.AgendaTextBox.Size = New System.Drawing.Size(193, 130)
        Me.AgendaTextBox.TabIndex = 3
        '
        'CardNoComboBox
        '
        Me.CardNoComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CardNoComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CardNoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, "CardNo", True))
        Me.CardNoComboBox.DataSource = Me.View_Rpt_Acc_PreSalaryBindingSource
        Me.CardNoComboBox.DisplayMember = "CardNo"
        Me.CardNoComboBox.FormattingEnabled = True
        Me.CardNoComboBox.Location = New System.Drawing.Point(293, 37)
        Me.CardNoComboBox.Name = "CardNoComboBox"
        Me.CardNoComboBox.Size = New System.Drawing.Size(89, 21)
        Me.CardNoComboBox.TabIndex = 0
        Me.CardNoComboBox.ValueMember = "CardNo"
        '
        'FKWDIDLabel1
        '
        Me.FKWDIDLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FKWDIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FKWDIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, "FKWDID", True))
        Me.FKWDIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FKWDIDLabel1.Location = New System.Drawing.Point(113, 37)
        Me.FKWDIDLabel1.Name = "FKWDIDLabel1"
        Me.FKWDIDLabel1.Size = New System.Drawing.Size(60, 20)
        Me.FKWDIDLabel1.TabIndex = 2
        Me.FKWDIDLabel1.Text = "Label3"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(929, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        Me.BindingNavigatorDeleteItem1.Visible = False
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Save Data"
        '
        'View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource
        '
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource.DataMember = "View_Rpt_Acc_AllEmployees_ActiveSalary"
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource.DataSource = Me.DataSet6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 10)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'UserIDLabel1
        '
        Me.UserIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource, "UserID", True))
        Me.UserIDLabel1.Location = New System.Drawing.Point(19, 48)
        Me.UserIDLabel1.Name = "UserIDLabel1"
        Me.UserIDLabel1.Size = New System.Drawing.Size(10, 10)
        Me.UserIDLabel1.TabIndex = 16
        '
        'Tbl_Hrm_Formal_Kaizen_HeadTableAdapter
        '
        Me.Tbl_Hrm_Formal_Kaizen_HeadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Hrm_Formal_Kaizen_DetailTableAdapter = Me.Tbl_Hrm_Formal_Kaizen_DetailTableAdapter
        Me.TableAdapterManager.tbl_Hrm_Formal_Kaizen_HeadTableAdapter = Me.Tbl_Hrm_Formal_Kaizen_HeadTableAdapter
        Me.TableAdapterManager.tbl_Hrm_kaizen_activity_recordTableAdapter = Nothing
        'Me.TableAdapterManager.tbl_Hrm_kaizen_IdeasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_Hrm_Formal_Kaizen_DetailTableAdapter
        '
        Me.Tbl_Hrm_Formal_Kaizen_DetailTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter
        '
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.ClearBeforeFill = True
        '
        'View_Rpt_Acc_PreSalaryTableAdapter
        '
        Me.View_Rpt_Acc_PreSalaryTableAdapter.ClearBeforeFill = True
        '
        'Clock1
        ''
        'Me.Clock1.BackgroundImage = CType(resources.GetObject("Clock1.BackgroundImage"), System.Drawing.Image)
        'Me.Clock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        'Me.Clock1.BigMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("BigMarker90", 90.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker60", 60.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker30", 30.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker0", 0.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker330", 330.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker300", 300.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker270", 270.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker240", 240.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker210", 210.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker180", 180.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker150", 150.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("BigMarker120", 120.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.06!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        'Me.Clock1.BorderStyle = AnalogClock.BorderStyles.Round
        'Me.Clock1.CenterPoint.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        'Me.Clock1.CenterPoint.RelativeRadius = 0.03!
        'Me.Clock1.CenterPoint.Tag = Nothing
        'Me.Clock1.HourHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        'Me.Clock1.HourHand.RelativeRadius = 0.65!
        'Me.Clock1.HourHand.Tag = Nothing
        'Me.Clock1.HourHand.Width = 5.0!
        'Me.Clock1.Location = New System.Drawing.Point(798, 40)
        'Me.Clock1.MinuteHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        'Me.Clock1.MinuteHand.RelativeRadius = 0.8!
        'Me.Clock1.MinuteHand.Tag = Nothing
        'Me.Clock1.MinuteHand.Width = 5.0!
        'Me.Clock1.Name = "Clock1"
        'Me.Clock1.SecondHand.PaintAttributes = New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!)
        'Me.Clock1.SecondHand.RelativeRadius = 0.9!
        'Me.Clock1.SecondHand.Tag = Nothing
        'Me.Clock1.SecondHand.Width = 1.0!
        'Me.Clock1.Size = New System.Drawing.Size(168, 158)
        'Me.Clock1.SmallMarkers = New AnalogClock.Marker() {New AnalogClock.Marker("SmallMarker90", 90.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker84", 84.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker78", 78.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker72", 72.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker66", 66.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker60", 60.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker54", 54.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker48", 48.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker42", 42.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker36", 36.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker30", 30.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker24", 24.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker18", 18.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker12", 12.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker6", 6.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker0", 0.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker354", 354.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker348", 348.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker342", 342.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker336", 336.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker330", 330.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker324", 324.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker318", 318.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker312", 312.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker306", 306.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker300", 300.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker294", 294.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker288", 288.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker282", 282.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker276", 276.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker270", 270.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker264", 264.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker258", 258.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker252", 252.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker246", 246.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker240", 240.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker234", 234.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker228", 228.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker222", 222.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker216", 216.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker210", 210.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker204", 204.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker198", 198.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker192", 192.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker186", 186.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker180", 180.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker174", 174.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker168", 168.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker162", 162.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker156", 156.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker150", 150.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker144", 144.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker138", 138.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker132", 132.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker126", 126.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker120", 120.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker114", 114.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker108", 108.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker102", 102.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing), New AnalogClock.Marker("SmallMarker96", 96.0!, System.Drawing.Color.Black, AnalogClock.MarkerStyle.Regular, True, 79.0!, 1.0!, 0.03!, 1.0!, New AnalogClock.PaintAttributes(AnalogClock.PaintObject.Brush, 1.0!), AnalogClock.SmoothMode.AntiAlias, Nothing)}
        'Me.Clock1.Symbols = New AnalogClock.Symbol() {New AnalogClock.Symbol("Symbol90", 90.0!, "12", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 0, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol60", 60.0!, "1", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 1, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol30", 30.0!, "2", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 2, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol0", 0.0!, "3", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 3, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol330", 330.0!, "4", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 4, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol300", 300.0!, "5", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 5, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol270", 270.0!, "6", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 6, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol240", 240.0!, "7", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 7, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol210", 210.0!, "8", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 8, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol180", 180.0!, "9", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 9, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol150", 150.0!, "10", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 10, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing), New AnalogClock.Symbol("Symbol120", 120.0!, "11", New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold), System.Drawing.Color.Black, New System.Drawing.Point(1, 1), 11, True, True, AnalogClock.SymbolStyle.Numeric, 79.0!, 0.82!, System.Drawing.Text.TextRenderingHint.SystemDefault, Nothing)}
        'Me.Clock1.TabIndex = 17
        'Me.Clock1.UtcOffset = System.TimeSpan.Parse("11:02:00")
        '
        'frmFormalKaizenWalk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 569)
        'Me.Controls.Add(Me.Clock1)
        Me.Controls.Add(Me.UserIDLabel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "frmFormalKaizenWalk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmFormalKaizenWalk"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.ResumeLayout(False)
        Me.Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_Rpt_Acc_PreSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataSet6 As ERP_HRMS.DataSet6
    Friend WithEvents Tbl_Hrm_Formal_Kaizen_HeadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_Hrm_Formal_Kaizen_HeadTableAdapter As ERP_HRMS.DataSet6TableAdapters.tbl_Hrm_Formal_Kaizen_HeadTableAdapter
    Friend WithEvents TableAdapterManager As ERP_HRMS.DataSet6TableAdapters.TableAdapterManager
    Friend WithEvents Tbl_Hrm_Formal_Kaizen_HeadBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VisitLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VisitTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents VisitDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents FKWIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents CommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tbl_Hrm_Formal_Kaizen_DetailTableAdapter As ERP_HRMS.DataSet6TableAdapters.tbl_Hrm_Formal_Kaizen_DetailTableAdapter
    Friend WithEvents Tbl_Hrm_Formal_Kaizen_DetailBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents View_Rpt_Acc_AllEmployees_ActiveSalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter As ERP_HRMS.DataSet6TableAdapters.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter
    Friend WithEvents DeptNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents NameLabel1 As System.Windows.Forms.Label
    Friend WithEvents View_Rpt_Acc_PreSalaryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents View_Rpt_Acc_PreSalaryTableAdapter As ERP_HRMS.DataSet6TableAdapters.View_Rpt_Acc_PreSalaryTableAdapter
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents UserIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents ReleventDeptTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SolutionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObservationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CardNoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FKWDIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents StatusComboBox As System.Windows.Forms.ComboBox
    'Friend WithEvents Clock1 As AnalogClock.Clock
End Class
