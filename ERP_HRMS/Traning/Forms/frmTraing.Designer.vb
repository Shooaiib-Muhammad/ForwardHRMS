<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraing
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
        Dim Label2 As System.Windows.Forms.Label
        Dim TIDLabel As System.Windows.Forms.Label
        Dim TopicLabel As System.Windows.Forms.Label
        Dim VenueLabel As System.Windows.Forms.Label
        Dim TrainerLabel As System.Windows.Forms.Label
        Dim TParticipantsLabel As System.Windows.Forms.Label
        Dim TTParticipantsLabel As System.Windows.Forms.Label
        Dim TDateTimeLabel As System.Windows.Forms.Label
        Dim ObjectiveLabel As System.Windows.Forms.Label
        Dim ContentsLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTraing))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ClientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_EMS_Traing_HeadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSEMS = New ERP_HRMS.DSEMS()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PatialRecDateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Tbl_EMS_TraingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AttSheetBox1 = New System.Windows.Forms.PictureBox()
        Me.ContentsTextBox = New System.Windows.Forms.TextBox()
        Me.ObjectiveTextBox = New System.Windows.Forms.TextBox()
        Me.TTParticipantsTextBox = New System.Windows.Forms.TextBox()
        Me.TParticipantsTextBox = New System.Windows.Forms.TextBox()
        Me.TrainerTextBox = New System.Windows.Forms.TextBox()
        Me.VenueTextBox = New System.Windows.Forms.TextBox()
        Me.TopicTextBox = New System.Windows.Forms.TextBox()
        Me.TIDLabel1 = New System.Windows.Forms.Label()
        Me.Tbl_EMS_Traing_HeadBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tbl_EMS_Traing_HeadBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Tbl_EMS_Traing_HeadTableAdapter = New ERP_HRMS.DSEMSTableAdapters.tbl_EMS_Traing_HeadTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSEMSTableAdapters.TableAdapterManager()
        Me.Tbl_EMS_TraingTableAdapter = New ERP_HRMS.DSEMSTableAdapters.tbl_EMS_TraingTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button6 = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        TIDLabel = New System.Windows.Forms.Label()
        TopicLabel = New System.Windows.Forms.Label()
        VenueLabel = New System.Windows.Forms.Label()
        TrainerLabel = New System.Windows.Forms.Label()
        TParticipantsLabel = New System.Windows.Forms.Label()
        TTParticipantsLabel = New System.Windows.Forms.Label()
        TDateTimeLabel = New System.Windows.Forms.Label()
        ObjectiveLabel = New System.Windows.Forms.Label()
        ContentsLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Tbl_EMS_Traing_HeadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSEMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Tbl_EMS_TraingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AttSheetBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_EMS_Traing_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tbl_EMS_Traing_HeadBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(7, 12)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(153, 21)
        Label2.TabIndex = 27
        Label2.Text = "Training Type:"
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TIDLabel
        '
        TIDLabel.AutoSize = True
        TIDLabel.Location = New System.Drawing.Point(26, 45)
        TIDLabel.Name = "TIDLabel"
        TIDLabel.Size = New System.Drawing.Size(28, 13)
        TIDLabel.TabIndex = 33
        TIDLabel.Text = "TID:"
        '
        'TopicLabel
        '
        TopicLabel.AutoSize = True
        TopicLabel.Location = New System.Drawing.Point(222, 45)
        TopicLabel.Name = "TopicLabel"
        TopicLabel.Size = New System.Drawing.Size(37, 13)
        TopicLabel.TabIndex = 34
        TopicLabel.Text = "Topic:"
        '
        'VenueLabel
        '
        VenueLabel.AutoSize = True
        VenueLabel.Location = New System.Drawing.Point(567, 45)
        VenueLabel.Name = "VenueLabel"
        VenueLabel.Size = New System.Drawing.Size(41, 13)
        VenueLabel.TabIndex = 35
        VenueLabel.Text = "Venue:"
        '
        'TrainerLabel
        '
        TrainerLabel.AutoSize = True
        TrainerLabel.Location = New System.Drawing.Point(11, 81)
        TrainerLabel.Name = "TrainerLabel"
        TrainerLabel.Size = New System.Drawing.Size(43, 13)
        TrainerLabel.TabIndex = 36
        TrainerLabel.Text = "Trainer:"
        '
        'TParticipantsLabel
        '
        TParticipantsLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        TParticipantsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        TParticipantsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TParticipantsLabel.Location = New System.Drawing.Point(29, 111)
        TParticipantsLabel.Name = "TParticipantsLabel"
        TParticipantsLabel.Size = New System.Drawing.Size(192, 20)
        TParticipantsLabel.TabIndex = 37
        TParticipantsLabel.Text = "Training Participants"
        TParticipantsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TTParticipantsLabel
        '
        TTParticipantsLabel.AutoSize = True
        TTParticipantsLabel.Location = New System.Drawing.Point(177, 81)
        TTParticipantsLabel.Name = "TTParticipantsLabel"
        TTParticipantsLabel.Size = New System.Drawing.Size(92, 13)
        TTParticipantsLabel.TabIndex = 38
        TTParticipantsLabel.Text = "Total Participants:"
        '
        'TDateTimeLabel
        '
        TDateTimeLabel.AutoSize = True
        TDateTimeLabel.Location = New System.Drawing.Point(542, 82)
        TDateTimeLabel.Name = "TDateTimeLabel"
        TDateTimeLabel.Size = New System.Drawing.Size(66, 13)
        TDateTimeLabel.TabIndex = 39
        TDateTimeLabel.Text = "TDate Time:"
        '
        'ObjectiveLabel
        '
        ObjectiveLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ObjectiveLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ObjectiveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObjectiveLabel.Location = New System.Drawing.Point(238, 111)
        ObjectiveLabel.Name = "ObjectiveLabel"
        ObjectiveLabel.Size = New System.Drawing.Size(192, 20)
        ObjectiveLabel.TabIndex = 40
        ObjectiveLabel.Text = "Objective"
        ObjectiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContentsLabel
        '
        ContentsLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        ContentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        ContentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContentsLabel.Location = New System.Drawing.Point(448, 111)
        ContentsLabel.Name = "ContentsLabel"
        ContentsLabel.Size = New System.Drawing.Size(192, 20)
        ContentsLabel.TabIndex = 41
        ContentsLabel.Text = "Contents"
        ContentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(29, 467)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(825, 19)
        Label3.TabIndex = 55
        Label3.Text = "Summary"
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1004, 42)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Training Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ClientIDComboBox)
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Controls.Add(Label2)
        Me.Panel1.Location = New System.Drawing.Point(29, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 46)
        Me.Panel1.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(407, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Select Year:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ClientIDComboBox
        '
        Me.ClientIDComboBox.DataSource = Me.Tbl_EMS_Traing_HeadBindingSource
        Me.ClientIDComboBox.DisplayMember = "TrainType"
        Me.ClientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClientIDComboBox.FormattingEnabled = True
        Me.ClientIDComboBox.Location = New System.Drawing.Point(162, 12)
        Me.ClientIDComboBox.Name = "ClientIDComboBox"
        Me.ClientIDComboBox.Size = New System.Drawing.Size(228, 21)
        Me.ClientIDComboBox.TabIndex = 26
        Me.ClientIDComboBox.ValueMember = "THID"
        '
        'Tbl_EMS_Traing_HeadBindingSource
        '
        Me.Tbl_EMS_Traing_HeadBindingSource.DataMember = "tbl_EMS_Traing_Head"
        Me.Tbl_EMS_Traing_HeadBindingSource.DataSource = Me.DSEMS
        '
        'DSEMS
        '
        Me.DSEMS.DataSetName = "DSEMS"
        Me.DSEMS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbYear
        '
        Me.cmbYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(537, 12)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(103, 24)
        Me.cmbYear.TabIndex = 43
        Me.cmbYear.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.PatialRecDateMaskedTextBox)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.AttSheetBox1)
        Me.Panel2.Controls.Add(ContentsLabel)
        Me.Panel2.Controls.Add(Me.ContentsTextBox)
        Me.Panel2.Controls.Add(ObjectiveLabel)
        Me.Panel2.Controls.Add(Me.ObjectiveTextBox)
        Me.Panel2.Controls.Add(TDateTimeLabel)
        Me.Panel2.Controls.Add(TTParticipantsLabel)
        Me.Panel2.Controls.Add(Me.TTParticipantsTextBox)
        Me.Panel2.Controls.Add(TParticipantsLabel)
        Me.Panel2.Controls.Add(Me.TParticipantsTextBox)
        Me.Panel2.Controls.Add(TrainerLabel)
        Me.Panel2.Controls.Add(Me.TrainerTextBox)
        Me.Panel2.Controls.Add(VenueLabel)
        Me.Panel2.Controls.Add(Me.VenueTextBox)
        Me.Panel2.Controls.Add(TopicLabel)
        Me.Panel2.Controls.Add(Me.TopicTextBox)
        Me.Panel2.Controls.Add(TIDLabel)
        Me.Panel2.Controls.Add(Me.TIDLabel1)
        Me.Panel2.Controls.Add(Me.Tbl_EMS_Traing_HeadBindingNavigator)
        Me.Panel2.Location = New System.Drawing.Point(29, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(916, 586)
        Me.Panel2.TabIndex = 32
        '
        'PatialRecDateMaskedTextBox
        '
        Me.PatialRecDateMaskedTextBox.BackColor = System.Drawing.Color.Linen
        Me.PatialRecDateMaskedTextBox.CausesValidation = False
        Me.PatialRecDateMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "TDateTime", True))
        Me.PatialRecDateMaskedTextBox.Location = New System.Drawing.Point(614, 79)
        Me.PatialRecDateMaskedTextBox.Mask = "00/00/0000"
        Me.PatialRecDateMaskedTextBox.Name = "PatialRecDateMaskedTextBox"
        Me.PatialRecDateMaskedTextBox.Size = New System.Drawing.Size(282, 20)
        Me.PatialRecDateMaskedTextBox.TabIndex = 57
        Me.PatialRecDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PatialRecDateMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Tbl_EMS_TraingBindingSource
        '
        Me.Tbl_EMS_TraingBindingSource.DataMember = "tbl_EMS_Traing_Head_tbl_EMS_Traing"
        Me.Tbl_EMS_TraingBindingSource.DataSource = Me.Tbl_EMS_Traing_HeadBindingSource
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "Summary", True))
        Me.TextBox1.Location = New System.Drawing.Point(29, 488)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(825, 84)
        Me.TextBox1.TabIndex = 56
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(662, 290)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(192, 20)
        Me.Button5.TabIndex = 54
        Me.Button5.Text = "Upload Feedback Form"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(448, 290)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(192, 20)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "Upload Picture 3"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(238, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 20)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "Upload Picture 2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(29, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 20)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Upload Picture 1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(662, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 20)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Upload Attendence Sheet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_EMS_TraingBindingSource, "Feedback", True))
        Me.PictureBox5.Location = New System.Drawing.Point(662, 316)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(192, 144)
        Me.PictureBox5.TabIndex = 47
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_EMS_TraingBindingSource, "Pic3", True))
        Me.PictureBox3.Location = New System.Drawing.Point(448, 316)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(192, 144)
        Me.PictureBox3.TabIndex = 46
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_EMS_TraingBindingSource, "Pic2", True))
        Me.PictureBox2.Location = New System.Drawing.Point(238, 316)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 144)
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_EMS_TraingBindingSource, "Pic1", True))
        Me.PictureBox1.Location = New System.Drawing.Point(29, 316)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 144)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'AttSheetBox1
        '
        Me.AttSheetBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttSheetBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_EMS_TraingBindingSource, "AttSheet", True))
        Me.AttSheetBox1.Location = New System.Drawing.Point(662, 134)
        Me.AttSheetBox1.Name = "AttSheetBox1"
        Me.AttSheetBox1.Size = New System.Drawing.Size(192, 144)
        Me.AttSheetBox1.TabIndex = 43
        Me.AttSheetBox1.TabStop = False
        '
        'ContentsTextBox
        '
        Me.ContentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "Contents", True))
        Me.ContentsTextBox.Location = New System.Drawing.Point(448, 135)
        Me.ContentsTextBox.Multiline = True
        Me.ContentsTextBox.Name = "ContentsTextBox"
        Me.ContentsTextBox.Size = New System.Drawing.Size(192, 144)
        Me.ContentsTextBox.TabIndex = 42
        '
        'ObjectiveTextBox
        '
        Me.ObjectiveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "Objective", True))
        Me.ObjectiveTextBox.Location = New System.Drawing.Point(238, 135)
        Me.ObjectiveTextBox.Multiline = True
        Me.ObjectiveTextBox.Name = "ObjectiveTextBox"
        Me.ObjectiveTextBox.Size = New System.Drawing.Size(192, 144)
        Me.ObjectiveTextBox.TabIndex = 41
        '
        'TTParticipantsTextBox
        '
        Me.TTParticipantsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "TTParticipants", True))
        Me.TTParticipantsTextBox.Location = New System.Drawing.Point(270, 78)
        Me.TTParticipantsTextBox.Name = "TTParticipantsTextBox"
        Me.TTParticipantsTextBox.Size = New System.Drawing.Size(260, 20)
        Me.TTParticipantsTextBox.TabIndex = 39
        '
        'TParticipantsTextBox
        '
        Me.TParticipantsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "TParticipants", True))
        Me.TParticipantsTextBox.Location = New System.Drawing.Point(29, 134)
        Me.TParticipantsTextBox.Multiline = True
        Me.TParticipantsTextBox.Name = "TParticipantsTextBox"
        Me.TParticipantsTextBox.Size = New System.Drawing.Size(192, 144)
        Me.TParticipantsTextBox.TabIndex = 38
        '
        'TrainerTextBox
        '
        Me.TrainerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "Trainer", True))
        Me.TrainerTextBox.Location = New System.Drawing.Point(60, 78)
        Me.TrainerTextBox.Name = "TrainerTextBox"
        Me.TrainerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TrainerTextBox.TabIndex = 37
        '
        'VenueTextBox
        '
        Me.VenueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "Venue", True))
        Me.VenueTextBox.Location = New System.Drawing.Point(614, 41)
        Me.VenueTextBox.Name = "VenueTextBox"
        Me.VenueTextBox.Size = New System.Drawing.Size(282, 20)
        Me.VenueTextBox.TabIndex = 36
        '
        'TopicTextBox
        '
        Me.TopicTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "Topic", True))
        Me.TopicTextBox.Location = New System.Drawing.Point(270, 41)
        Me.TopicTextBox.Name = "TopicTextBox"
        Me.TopicTextBox.Size = New System.Drawing.Size(260, 20)
        Me.TopicTextBox.TabIndex = 35
        '
        'TIDLabel1
        '
        Me.TIDLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_EMS_TraingBindingSource, "TID", True))
        Me.TIDLabel1.Location = New System.Drawing.Point(60, 41)
        Me.TIDLabel1.Name = "TIDLabel1"
        Me.TIDLabel1.Size = New System.Drawing.Size(100, 18)
        Me.TIDLabel1.TabIndex = 34
        Me.TIDLabel1.Text = "Label3"
        Me.TIDLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tbl_EMS_Traing_HeadBindingNavigator
        '
        Me.Tbl_EMS_Traing_HeadBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Tbl_EMS_Traing_HeadBindingNavigator.BindingSource = Me.Tbl_EMS_TraingBindingSource
        Me.Tbl_EMS_Traing_HeadBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tbl_EMS_Traing_HeadBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Tbl_EMS_Traing_HeadBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Tbl_EMS_Traing_HeadBindingNavigatorSaveItem})
        Me.Tbl_EMS_Traing_HeadBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tbl_EMS_Traing_HeadBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tbl_EMS_Traing_HeadBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tbl_EMS_Traing_HeadBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tbl_EMS_Traing_HeadBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tbl_EMS_Traing_HeadBindingNavigator.Name = "Tbl_EMS_Traing_HeadBindingNavigator"
        Me.Tbl_EMS_Traing_HeadBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tbl_EMS_Traing_HeadBindingNavigator.Size = New System.Drawing.Size(914, 25)
        Me.Tbl_EMS_Traing_HeadBindingNavigator.TabIndex = 33
        Me.Tbl_EMS_Traing_HeadBindingNavigator.Text = "BindingNavigator1"
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
        'Tbl_EMS_Traing_HeadBindingNavigatorSaveItem
        '
        Me.Tbl_EMS_Traing_HeadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tbl_EMS_Traing_HeadBindingNavigatorSaveItem.Image = CType(resources.GetObject("Tbl_EMS_Traing_HeadBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Tbl_EMS_Traing_HeadBindingNavigatorSaveItem.Name = "Tbl_EMS_Traing_HeadBindingNavigatorSaveItem"
        Me.Tbl_EMS_Traing_HeadBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Tbl_EMS_Traing_HeadBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Tbl_EMS_Traing_HeadTableAdapter
        '
        Me.Tbl_EMS_Traing_HeadTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        'Me.TableAdapterManager.tbl_EMS_Corrective_Action_PlanTableAdapter = Nothing
        'Me.TableAdapterManager.tbl_EMS_LocationTableAdapter = Nothing
        'Me.TableAdapterManager.tbl_EMS_Meters_CheckListTableAdapter = Nothing
        'Me.TableAdapterManager.tbl_EMS_MetersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_EMS_Traing_HeadTableAdapter = Me.Tbl_EMS_Traing_HeadTableAdapter
        Me.TableAdapterManager.tbl_EMS_Traing_ScheduleTableAdapter = Nothing
        Me.TableAdapterManager.tbl_EMS_TraingTableAdapter = Me.Tbl_EMS_TraingTableAdapter
        'Me.TableAdapterManager.tbl_EMS_Waste_RecordTableAdapter = Nothing
        'Me.TableAdapterManager.tbl_EMS_WRM_ChecklistTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSEMSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tbl_EMS_TraingTableAdapter
        '
        Me.Tbl_EMS_TraingTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Maroon
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Yellow
        Me.Button6.Location = New System.Drawing.Point(812, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 22)
        Me.Button6.TabIndex = 46
        Me.Button6.Text = "View Report"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'frmTraing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 728)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTraing"
        Me.Text = "frmTraing"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Tbl_EMS_Traing_HeadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSEMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Tbl_EMS_TraingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AttSheetBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_EMS_Traing_HeadBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tbl_EMS_Traing_HeadBindingNavigator.ResumeLayout(False)
        Me.Tbl_EMS_Traing_HeadBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClientIDComboBox As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DSEMS As DSEMS
    Friend WithEvents Tbl_EMS_Traing_HeadBindingSource As BindingSource
    Friend WithEvents Tbl_EMS_Traing_HeadTableAdapter As DSEMSTableAdapters.tbl_EMS_Traing_HeadTableAdapter
    Friend WithEvents TableAdapterManager As DSEMSTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_EMS_Traing_HeadBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Tbl_EMS_Traing_HeadBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Tbl_EMS_TraingTableAdapter As DSEMSTableAdapters.tbl_EMS_TraingTableAdapter
    Friend WithEvents Tbl_EMS_TraingBindingSource As BindingSource
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AttSheetBox1 As PictureBox
    Friend WithEvents ContentsTextBox As TextBox
    Friend WithEvents ObjectiveTextBox As TextBox
    Friend WithEvents TTParticipantsTextBox As TextBox
    Friend WithEvents TParticipantsTextBox As TextBox
    Friend WithEvents TrainerTextBox As TextBox
    Friend WithEvents VenueTextBox As TextBox
    Friend WithEvents TopicTextBox As TextBox
    Friend WithEvents TIDLabel1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents PatialRecDateMaskedTextBox As MaskedTextBox
    Friend WithEvents Button6 As Button
End Class
