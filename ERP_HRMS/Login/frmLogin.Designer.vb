<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Tbl_MIS_UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MIS_User_DeptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUser = New ERP_HRMS.DSUser()
        Me.txtPswd = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Usertxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tbl_MIS_User_LogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_MIS_User_DeptTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_MIS_User_DeptTableAdapter()
        Me.TableAdapterManager = New ERP_HRMS.DSUserTableAdapters.TableAdapterManager()
        Me.Tbl_MIS_UserTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_MIS_UserTableAdapter()
        Me.Tbl_MIS_User_LogTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_MIS_User_LogTableAdapter()
        Me.Tbl_Comp_InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Comp_InfoTableAdapter = New ERP_HRMS.DSUserTableAdapters.tbl_Comp_InfoTableAdapter()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New ERP_HRMS.DSUserTableAdapters.UsersTableAdapter()
        Me.Tbl_Lock_UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Lock_UsersTableAdapter = New ERP_HRMS.DSUserTableAdapters.Tbl_Lock_UsersTableAdapter()
        CType(Me.Tbl_MIS_UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MIS_User_DeptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_MIS_User_LogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Lock_UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tbl_MIS_UserBindingSource
        '
        Me.Tbl_MIS_UserBindingSource.DataMember = "tbl_MIS_User_Dept_tbl_MIS_User"
        Me.Tbl_MIS_UserBindingSource.DataSource = Me.Tbl_MIS_User_DeptBindingSource
        '
        'Tbl_MIS_User_DeptBindingSource
        '
        Me.Tbl_MIS_User_DeptBindingSource.DataMember = "tbl_MIS_User_Dept"
        Me.Tbl_MIS_User_DeptBindingSource.DataSource = Me.DSUser
        '
        'DSUser
        '
        Me.DSUser.DataSetName = "DSUser"
        Me.DSUser.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPswd
        '
        Me.txtPswd.BackColor = System.Drawing.Color.White
        Me.txtPswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPswd.Location = New System.Drawing.Point(248, 259)
        Me.txtPswd.Name = "txtPswd"
        Me.txtPswd.Size = New System.Drawing.Size(223, 22)
        Me.txtPswd.TabIndex = 1
        Me.txtPswd.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(248, 297)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(99, 30)
        Me.btnLogin.TabIndex = 14
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(372, 298)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 30)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(197, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Label5"
        '
        'Usertxt
        '
        Me.Usertxt.BackColor = System.Drawing.Color.White
        Me.Usertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usertxt.Location = New System.Drawing.Point(248, 218)
        Me.Usertxt.Name = "Usertxt"
        Me.Usertxt.Size = New System.Drawing.Size(223, 22)
        Me.Usertxt.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "User Name :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(149, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Password :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(99, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "System IPAddress:"
        '
        'PictureBox1
        '
        Me.PictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Tbl_MIS_User_LogBindingSource, "LID", True))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(630, 509)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Tbl_MIS_User_LogBindingSource
        '
        Me.Tbl_MIS_User_LogBindingSource.DataMember = "tbl_MIS_User_Log"
        Me.Tbl_MIS_User_LogBindingSource.DataSource = Me.DSUser
        '
        'Tbl_MIS_User_DeptTableAdapter
        '
        Me.Tbl_MIS_User_DeptTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Acc_FinancialPeriodTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Comp_InfoTableAdapter = Nothing
        Me.TableAdapterManager.tbl_HRM_App_AuthorityTableAdapter = Nothing
        Me.TableAdapterManager.Tbl_Lock_UsersTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Log_ShiftTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_DeptTableAdapter = Me.Tbl_MIS_User_DeptTableAdapter
        Me.TableAdapterManager.tbl_MIS_User_LogTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_User_NEWTableAdapter = Nothing
        Me.TableAdapterManager.tbl_MIS_UserTableAdapter = Me.Tbl_MIS_UserTableAdapter
        Me.TableAdapterManager.UpdateOrder = ERP_HRMS.DSUserTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        '
        'Tbl_MIS_UserTableAdapter
        '
        Me.Tbl_MIS_UserTableAdapter.ClearBeforeFill = True
        '
        'Tbl_MIS_User_LogTableAdapter
        '
        Me.Tbl_MIS_User_LogTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Comp_InfoBindingSource
        '
        Me.Tbl_Comp_InfoBindingSource.DataMember = "tbl_Comp_Info"
        Me.Tbl_Comp_InfoBindingSource.DataSource = Me.DSUser
        '
        'Tbl_Comp_InfoTableAdapter
        '
        Me.Tbl_Comp_InfoTableAdapter.ClearBeforeFill = True
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.DSUser
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Lock_UsersBindingSource
        '
        Me.Tbl_Lock_UsersBindingSource.DataSource = Me.DSUser
        Me.Tbl_Lock_UsersBindingSource.Position = 0
        '
        'Tbl_Lock_UsersTableAdapter
        '
        Me.Tbl_Lock_UsersTableAdapter.ClearBeforeFill = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(624, 504)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Usertxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPswd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "     "
        CType(Me.Tbl_MIS_UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MIS_User_DeptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_MIS_User_LogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Comp_InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Lock_UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPswd As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents DSUser As DSUser
    Friend WithEvents Tbl_MIS_User_DeptBindingSource As BindingSource
    Friend WithEvents Tbl_MIS_User_DeptTableAdapter As DSUserTableAdapters.tbl_MIS_User_DeptTableAdapter
    Friend WithEvents TableAdapterManager As DSUserTableAdapters.TableAdapterManager
    Friend WithEvents Tbl_MIS_UserTableAdapter As DSUserTableAdapters.tbl_MIS_UserTableAdapter
    Friend WithEvents Tbl_MIS_UserBindingSource As BindingSource
    Friend WithEvents Tbl_MIS_User_LogBindingSource As BindingSource
    Friend WithEvents Tbl_MIS_User_LogTableAdapter As DSUserTableAdapters.tbl_MIS_User_LogTableAdapter
    Friend WithEvents Tbl_Comp_InfoBindingSource As BindingSource
    Friend WithEvents Tbl_Comp_InfoTableAdapter As DSUserTableAdapters.tbl_Comp_InfoTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents Usertxt As TextBox
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As DSUserTableAdapters.UsersTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tbl_Lock_UsersBindingSource As BindingSource
    Friend WithEvents Tbl_Lock_UsersTableAdapter As DSUserTableAdapters.Tbl_Lock_UsersTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
End Class
