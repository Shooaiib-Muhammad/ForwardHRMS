Public Class frmLogin
    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal fRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer

    Public Shared ReportsPath As String = ""
    Public Shared DeptID As Integer
    Public Shared UserID As Integer
    Public Shared UserName As String
    Dim DomID As Integer
    Dim UserMgt As Boolean
    Dim dgResult As DialogResult
    Dim Employee As Boolean
    Dim HRSett As Boolean
    Dim HRRpt As Boolean
    Dim PayRoll As Boolean
    Dim PayRollSett As Boolean
    Dim PayRollRpt As Boolean
    Dim Accounts As Boolean
    Dim AccRpt As Boolean
    Dim AccSett As Boolean
    Dim Visitors As Boolean
    Dim Canteen As Boolean
    Dim COntt As Boolean
    Dim Status As Boolean
    Dim ResetStatus As Boolean
    Dim Counter As Integer
    Dim LockUser As Boolean
    Dim Travel As Boolean
    Dim vehicles As Boolean
    Dim Grievance As Boolean
    Dim Shop As Boolean
    Dim Medication As Boolean

    Dim Complaint As Boolean
    'Dim DeptID As Integer
    Dim CompanyTxt As String
    Dim DeptTxt As String
    Dim Traning As Boolean
    Dim Evo As Boolean
    Dim kaizen As Boolean
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.Tbl_Lock_Users' table. You can move, or remove it, as needed.
        'Me.Tbl_Lock_UsersTableAdapter.Fill(Me.DSUser.Tbl_Lock_Users)
        'TODO: This line of code loads data into the 'DSUser.Users' table. You can move, or remove it, as needed.
        'Me.UsersTableAdapter.Fill(Me.DSUser.Users)
        CreateSystemDSN()
        Dim MyIP As String = Nothing
        'Dim UserStatus As String = Nothing
        MyIP = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        Label5.Text = MyIP
        'Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)

        'Try
        '    Me.Tbl_MIS_UserTableAdapter.FillBy(Me.DSUser.tbl_MIS_User)
        'Catch ex As Exception

        'End Try


        Me.Tbl_MIS_User_DeptTableAdapter.Fill(Me.DSUser.tbl_MIS_User_Dept)

        'Dim MyIP As String = Nothing
        Dim UserStatus As String = Nothing
        MyIP = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        'UserStatus = Me.Tbl_MIS_UserTableAdapter.GetUserStatus(MyIP)
        'If UserStatus Is Nothing Then
        '    DeptID = 63
        '    UserID = 190
        '    'Me.DepartmentIDComboBox.SelectedValue = DeptID
        '    'Me.UserIDComboBox.SelectedValue = UserID
        'ElseIf Not UserStatus Is Nothing Then
        '    If Me.Tbl_MIS_UserTableAdapter.GetUserStatus(MyIP) = True Then
        '        UserID = Me.Tbl_MIS_UserTableAdapter.GetUserID(MyIP)
        '        DeptID = Me.Tbl_MIS_UserTableAdapter.LoginDeptID(UserID)
        '        Me.Usertxt.Select()
        '        'Me.DepartmentIDComboBox.SelectedValue = DeptID
        '        'Me.UserIDComboBox.SelectedValue = UserID
        '    Else
        '        MsgBox("User Account is Disabled." & vbCrLf & "Contact to ERP Administrator for More Detail", MsgBoxStyle.Critical)
        '    End If
        'End If
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        Try
            ReportsPath = Me.DSUser.tbl_Comp_Info.Rows(0).Item("ReportsPath")
        Catch ex As Exception
            MsgBox("Report Path Missing,Kindly Set Report Path From Company Profile")
        End Try


        If (Me.Tbl_Comp_InfoTableAdapter.FillBy(Me.DSUser.tbl_Comp_Info)) > 0 Then '''' Audit menu hide 


            frmMain.ToolStripMenuItem227.Visible = False
            frmMain.ToolStripMenuItem228.Visible = False
            frmMain.ToolStripMenuItem229.Visible = False
            frmMain.ToolStripMenuItem31.Visible = False
            frmMain.ToolStripMenuItem32.Visible = False
            frmMain.ToolStripMenuItem33.Visible = False
            frmMain.ToolStripMenuItem84.Visible = False
            frmMain.ToolStripMenuItem109.Visible = False
            frmMain.ToolStripMenuItem142.Visible = False
            frmMain.ToolStripMenuItem245.Visible = False
        Else
            frmMain.ToolStripMenuItem227.Visible = True
            frmMain.ToolStripMenuItem228.Visible = True
            frmMain.ToolStripMenuItem229.Visible = True
            frmMain.ToolStripMenuItem31.Visible = True
            frmMain.ToolStripMenuItem32.Visible = True
            frmMain.ToolStripMenuItem142.Visible = True
            frmMain.ToolStripMenuItem33.Visible = True
            frmMain.ToolStripMenuItem84.Visible = True
            frmMain.ToolStripMenuItem109.Visible = True
            frmMain.ToolStripMenuItem245.Visible = True
        End If
        'txtPswd.Focus()
        'Usertxt.Focus()

    End Sub
    Private Shared Sub CreateSystemDSN()
        Dim ReturnValue As Integer
        Dim Driver As String
        Dim Attributes As String
        Driver = "SQL Native Client"
        'Attributes = "SERVER=" & "Server" & Chr(0)

        'Try
        Attributes = "SERVER=" & "Server" & Chr(0)
        'Catch ex As Exception
        '    Attributes = "SERVER=" & "192.168.15.1" & Chr(0)
        'End Try

        'Attributes = Attributes & "DESCRIPTION=" & "HRMS" & Chr(0)
        Attributes = Attributes & "DSN=" & "HRMS" & Chr(0)
        Attributes = Attributes & "DATABASE=" & "HRMS" & Chr(0)
        Attributes = Attributes & "TRUSTED_CONNECTION=YES" & Chr(0)
        ReturnValue = SQLConfigDataSource(0, 1, Driver, Attributes)
        If ReturnValue <> 0 Then
            'MsgBox("DSN Created Gear")
        Else
            MsgBox("Please contact administrator. ODBC Connection failed.")
        End If
    End Sub
    Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In Me.MdiChildren
            If f.Name = childWindow Then
                f.Focus()
                Return True
            End If
        Next
        Return False
    End Function
    Dim ExpireLog As Boolean = False
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim DBPswd As String
        Dim PSWDate As Date
        Dim DateDiff1 As Integer
        Dim dgResult As DialogResult
        Dim SysIpAdd As String = Nothing
        Dim DBIpAdd As String = Nothing
        Dim SPStatus As String = Nothing
        Dim LogStatus As Integer = 0
        Dim UserPwd As String

        'SysIpAdd = IpAddr(0).ToString
        SysIpAdd = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        If Usertxt.Text = "" Or txtPswd.Text = "" Then
            MessageBox.Show("Please Enter user and Password", "Feilds Are Empty ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Counter = 0
        Else
            If Me.UsersTableAdapter.FillBy1(Me.DSUser.Users, Usertxt.Text) > 0 Then '' MAtch user NAme
                UserID = Me.DSUser.Users.Rows(0).Item("UserID")
                Status = Me.DSUser.Users.Rows(0).Item("UserSataus")
                UserMgt = Me.DSUser.Users.Rows(0).Item("UserMgt")
                UserName = Me.DSUser.Users.Rows(0).Item("LoginName")
                'UserPwd = UtilityClass.Decrypt(Me.DSUser.Users.Rows(0).Item("PasswordEncrypt"), 100)
                UserPwd = Me.DSUser.Users.Rows(0).Item("passwd")

                Employee = Me.DSUser.Users.Rows(0).Item("Employee")
                HRSett = Me.DSUser.Users.Rows(0).Item("HRSett")
                HRRpt = Me.DSUser.Users.Rows(0).Item("HRRpt")
                PayRoll = Me.DSUser.Users.Rows(0).Item("PayRoll")
                PayRollRpt = Me.DSUser.Users.Rows(0).Item("PayRollRpt")
                PayRollSett = Me.DSUser.Users.Rows(0).Item("PayRollSett")
                Accounts = Me.DSUser.Users.Rows(0).Item("Account")
                AccSett = Me.DSUser.Users.Rows(0).Item("AccSett")
                AccRpt = Me.DSUser.Users.Rows(0).Item("AccRpt")
                Canteen = Me.DSUser.Users.Rows(0).Item("Canteen")
                Visitors = Me.DSUser.Users.Rows(0).Item("Visitors")
                COntt = Me.DSUser.Users.Rows(0).Item("COntt")
                SPStatus = Me.DSUser.Users.Rows(0).Item("SPStatus")
                PSWDate = Me.DSUser.Users.Rows(0).Item("PSWDDate")
                ResetStatus = Me.DSUser.Users.Rows(0).Item("ResetStatus")
                DeptID = Me.DSUser.Users.Rows(0).Item("LoginDeptID")
                DBIpAdd = Me.UsersTableAdapter.GetUserIP(UserID)
                Travel = Me.DSUser.Users.Rows(0).Item("Transport")
                vehicles = Me.DSUser.Users.Rows(0).Item("vehicles")
                Grievance = Me.DSUser.Users.Rows(0).Item("Grievance")
                Shop = Me.DSUser.Users.Rows(0).Item("Shop")
                Medication = Me.DSUser.Users.Rows(0).Item("Medication")

                Complaint = Me.DSUser.Users.Rows(0).Item("Complaint")
                Evo = Me.DSUser.Users.Rows(0).Item("Evo")
                kaizen = Me.DSUser.Users.Rows(0).Item("Kaizen")
                Traning = Me.DSUser.Users.Rows(0).Item("Traning")
                If Status = True Then
                    If Me.Tbl_Lock_UsersTableAdapter.FillBy(Me.DSUser.Tbl_Lock_Users, UserID) > 0 Then
                        MessageBox.Show("Your Account has Been Locked  due to Enter Wrong Password Multiple Time To Unlock Please Contact to ERP Administrator", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()


                    Else

                        If DBIpAdd = SysIpAdd Or SPStatus = True Then '' IP  Match 


                            'DBPswd = Me.UsersTableAdapter.GetUserPassword(UserID)
                            DBPswd = UserPwd
                            'PSWDate = Me.UsersTableAdapter.PSWDDate(UserID)

                            If DBPswd = txtPswd.Text Then
                                DateDiff1 = DateDiff(DateInterval.Day, PSWDate, Now.Date)  '' PWD Date
                                If DateDiff1 >= 60 Then
                                    ExpireLog = True
                                    MsgBox("Your ERP Password has been Expired" & vbCrLf & " Please Change Your ERP Password")
                                    Me.Close()
                                    If ChildWindowOpen("change_Password") = False Then
                                        Dim objChngPswd As New change_Password
                                        'objChngPswd.MdiParent = Me
                                        objChngPswd.Show()
                                    End If

                                ElseIf DateDiff1 >= 50 Then
                                    Dim BtnMsg As DialogResult = MessageBox.Show("Your ERP Password will be Expired After " & 60 - DateDiff1 & " days. Please Change Your ERP Password " & vbCrLf & "Are You Sure Want To Change ERP Password Now ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                                    If BtnMsg = 6 Then

                                        Me.Close()
                                        If ChildWindowOpen("change_Password") = False Then
                                            Dim objChngPswd As New change_Password
                                            'objChngPswd.MdiParent = Me
                                            objChngPswd.Show()
                                        End If
                                    Else
                                        LogStatus = 0
                                    End If
                                End If

                                If ResetStatus = True Then
                                    UserPassword = DBPswd
                                    MsgBox("Please Change Your ERP Password")
                                    Me.Close()
                                    If ChildWindowOpen("frmResetPWd") = False Then
                                        Dim objChngPswd As New frmResetPWd
                                        'objChngPswd.MdiParent = Me
                                        objChngPswd.Show()
                                    End If
                                ElseIf ExpireLog = False Then


                                    login()

                                End If
                            Else
                                Counter = Counter + 1
                                Counter = Counter

                                MsgBox("User Password is Not Match.", MsgBoxStyle.Critical)
                                txtPswd.Clear()
                                'Usertxt.Clear()

                                txtPswd.Focus()
                                If Counter >= 5 Then

                                    Me.Tbl_Lock_UsersTableAdapter.InsertQuery(UserID, Now, True, "Due to multiple time attempting to Login")
                                    'MessageBox.Show("Your Account has Been Lock  Due to Enter Wrong Password Muliple Time Please Contact too Administration", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    'End If
                                End If
                            End If
                        Else
                            MsgBox("User Authentication failed.", MsgBoxStyle.Critical)
                            txtPswd.Clear()
                            Usertxt.Clear()
                            Usertxt.Focus()
                        End If
                    End If

                Else
                    MsgBox("User is Disable.", MsgBoxStyle.Critical)
                    txtPswd.Clear()
                    Usertxt.Clear()
                    Usertxt.Focus()
                End If
            Else
                MsgBox(" User Name is Not Found", MsgBoxStyle.Exclamation)
                txtPswd.Clear()
                Usertxt.Clear()
                Usertxt.Focus()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
    Public Shared UserPassword As String
    Sub login()
        Me.Tbl_MIS_User_LogTableAdapter.Insert(UserID, Now, Nothing)
        Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        Tbl_MIS_User_DeptTableAdapter.FillBy1(Me.DSUser.tbl_MIS_User_Dept, Val(DeptID))
        'MessageBox.Show("Welcome Mr' ", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Me.Close()
        UserName = Me.DSUser.Users.Rows(0).Item("LoginName")
        CompanyTxt = Me.DSUser.tbl_Comp_Info.Rows(0).Item("CompanyName")
        DeptTxt = Me.DSUser.tbl_MIS_User_Dept.Rows(0).Item("DeptName")
        frmMain.MainMenuStrip = frmMain.MenuStrip1
        frmMain.MenuStrip1.Show()
        frmMain.Show()
        If Employee = True Then
            frmMain.EmployeeManagementToolStripMenuItem.Visible = True
        Else
            frmMain.EmployeeManagementToolStripMenuItem.Visible = False
        End If
        If HRSett = True Then
            frmMain.ToolStripMenuItem198.Visible = True
        Else
            frmMain.ToolStripMenuItem198.Visible = False
        End If
        If HRRpt = True Then
            frmMain.ToolStripMenuItem213.Visible = True
        Else
            frmMain.ToolStripMenuItem213.Visible = False
        End If
        If Travel = True Then
            frmMain.EmployeeToolStripMenuItem.Visible = True
        Else
            frmMain.EmployeeToolStripMenuItem.Visible = False
        End If
        If PayRollSett = True Then
            frmMain.ToolStripMenuItem220.Visible = True
        Else
            frmMain.ToolStripMenuItem220.Visible = False
        End If
        If PayRollRpt = True Then
            frmMain.ToolStripMenuItem233.Visible = True
        Else
            frmMain.ToolStripMenuItem233.Visible = False
        End If
        If Accounts = True Then
            frmMain.ToolStripMenuItem240.Visible = True
        Else
            frmMain.ToolStripMenuItem240.Visible = False
        End If
        'If AccSett = True Then
        '    frmMain.ToolStripMenuItem247.Visible = True
        'Else
        '    frmMain.ToolStripMenuItem247.Visible = False
        'End If
        If AccRpt = True Then
            frmMain.ToolStripMenuItem255.Visible = True
        Else
            frmMain.ToolStripMenuItem255.Visible = False
        End If
        If Canteen = True Then
            frmMain.ToolStripMenuItem264.Visible = True
        Else
            frmMain.ToolStripMenuItem264.Visible = False
        End If
        If Visitors = True Then
            frmMain.VisitorsToolStripMenuItem3.Visible = True
        Else
            frmMain.VisitorsToolStripMenuItem3.Visible = False
        End If
        If Medication = True Then

            frmMain.ToolStripMenuItem359.Visible = True
        Else
            frmMain.ToolStripMenuItem359.Visible = False
        End If


        If Complaint = True Then

            frmMain.ToolStripMenuItem327.Visible = True
        Else
            frmMain.ToolStripMenuItem327.Visible = False
        End If
        If COntt = True Then
            frmMain.ToolStripMenuItem270.Visible = True
        Else
            frmMain.ToolStripMenuItem270.Visible = False
        End If
        If vehicles = True Then

            frmMain.FactoryVehiclesToolStripMenuItem.Visible = True
        Else
            frmMain.FactoryVehiclesToolStripMenuItem.Visible = False
        End If

        If Grievance = True Then

            frmMain.GrievanceToolStripMenuItem1.Visible = True
        Else
            frmMain.GrievanceToolStripMenuItem1.Visible = False
        End If


        If Shop = True Then
            frmMain.ToolStripMenuItem280.Visible = True
        Else
            frmMain.ToolStripMenuItem280.Visible = False
        End If





        If Evo = True Then
            frmMain.ToolStripMenuItem248.Visible = True
        Else
            frmMain.ToolStripMenuItem248.Visible = False
        End If
        If kaizen = True Then
            frmMain.ToolStripMenuItem372.Visible = True
        Else
            frmMain.ToolStripMenuItem372.Visible = False
        End If

        If Traning = True Then
            frmMain.TrainingManagmentToolStripMenuItem.Visible = True
        Else
            frmMain.TrainingManagmentToolStripMenuItem.Visible = False
        End If


        If UserMgt = True Then

            frmMain.UserManagementToolStripMenuItem1.Visible = True
        Else
            frmMain.UserManagementToolStripMenuItem1.Visible = False
        End If
        If DeptID = 3 Or DeptID = 1 Then '' HR admin Mane
            frmMain.SalaryManagementToolStripMenuItem.Visible = True 'Salarymanagemnt

            frmMain.EmployeeTerminationToolStripMenuItem2.Visible = True '' Employee Termination
            frmMain.ToolStripMenuItem219.Visible = True  ''UNdo termination
        Else
            frmMain.SalaryManagementToolStripMenuItem.Visible = False

            frmMain.EmployeeTerminationToolStripMenuItem2.Visible = False
            frmMain.ToolStripMenuItem219.Visible = False
        End If
        If DeptID = 1 Then
            frmMain.SalaryIncrementToolStripMenuItem.Visible = True ' Salary increment Excel
            frmMain.GradeUpgradeToolStripMenuItem.Visible = True   ' grage upgradation
        Else
            frmMain.SalaryIncrementToolStripMenuItem.Visible = False ' Salary increment Excel
            frmMain.GradeUpgradeToolStripMenuItem.Visible = False   ' grage upgradation
        End If

        If DeptID = 5 Or DeptID = 1 Then '' Accounts Admin
            frmMain.SalaryManagementToolStripMenuItem1.Visible = True 'salary Management
        Else
            frmMain.SalaryManagementToolStripMenuItem1.Visible = False
        End If

        frmMain.MainMenu.Hide()
        Me.Hide()
        'End If
        ToolStrip()
    End Sub
    Sub ToolStrip()
        frmMain.ToolStripDomain.Text = "Company Name: " & CompanyTxt
        'frmMain.ToolStripDept.Text = "Department: " & DeptTxt
        frmMain.ToolStripUN.Text = "User Name: " & UserName
        frmMain.ToolStripLoginDateTime.Text = "Login Date Time: " & Now
    End Sub
    Private Sub AnnualLeavesCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Usertxt_TextChanged(sender As Object, e As EventArgs) Handles Usertxt.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class