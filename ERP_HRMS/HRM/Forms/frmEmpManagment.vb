Imports System.ComponentModel

Public Class frmEmpManagment

    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    'Dim Objj As New frmLogin
    Dim SalaryStatus As Boolean
    Private Sub Tbl_HRM_CardBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_CardBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)
    End Sub
    Private Sub txtSName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSName.KeyDown

        If e.KeyCode = Keys.Enter Then
            'FilterRecords(0)
            If txtSName.Text.Length = 0 Then
                MsgBox("Invalid String was Given for Search")
            Else
                FilterRecords(0, txtSName.Text)
            End If
            txtSName.Clear()
            CMSEmpInfo.Hide()
        End If
    End Sub
    Private Sub Navigation_EmpInfoHead()
        Dim CardValue As Integer = 0

        If BindingNavigator4.BindingSource.Equals(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource) Then
            If CardNoLabel3.Text <> "" Then
                CardValue = Val(CardNoLabel3.Text)
            End If
        Else
            If CardNoLabel2.Text <> "" Then
                CardValue = Val(CardNoLabel2.Text)
            End If
        End If
        If Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, CardNoLabel3.Text) > 0 Then
            Me.Tbl_HRM_Emp_InfoBindingSource.Position = Me.Tbl_HRM_Emp_InfoBindingSource.Count
        End If

    End Sub
    Private Sub FilterRecords(ByVal Flag As Integer, ByVal SearchingString As String)
        Dim Res As Integer = 0
        If BindingNavigator4.BindingSource.Equals(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource) Then
            MsgBox("For a New Search, Refresh Data")
        Else
            If Flag = 0 Then
                Res = Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.Fill(Me.DSHRM.View_Rpt_HR_EmpData_ActiveNonActive, SearchingString)
                'CMSEmpInfo.Text = ""
                'CMSEmpInfo.Hide()
            ElseIf Flag = 1 Then
                Res = Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.FillBy(Me.DSHRM.View_Rpt_HR_EmpData_ActiveNonActive, SearchingString)
            ElseIf Flag = 2 Then
                'Res = Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.FillBy1(Me.DSHRM.View_Rpt_HR_EmpData_ActiveNonActive, SearchingString)
                'CMSSearchNIC.Text = ""
                'CMSSearchNIC.Hide()
            End If
            If Res = 0 Then
                MsgBox("No Match Found")
            Else
                Me.Tbl_HRM_CardTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Card, Val(CardNoLabel3.Text))
                BindingNavigator4.BindingSource = Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource
                'LoadAtFormLoad()
                Navigation_EmpInfoHead()
                'Navigation_EmpInfo(Val(EmpIDLabel2.Text))
                Try
                    'Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.EmpIDLabel3.Text)
                Catch ex As Exception

                End Try

            End If
        End If

    End Sub

    Dim AdminFlag As Boolean = False
    Private Sub emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSRPTTO.View_Emp_Report_TO_NEW' table. You can move, or remove it, as needed.
        Me.View_Emp_Report_TO_NEWTableAdapter.Fill(Me.DSRPTTO.View_Emp_Report_TO_NEW)
        'TODO: This line of code loads data into the 'DSReportTo.View_Emp_Report_TO' table. You can move, or remove it, as needed.
        Me.View_Emp_Report_TOTableAdapter.Fill(Me.DSReportTo.View_Emp_Report_TO)
        'TODO: This line of code loads data into the 'DSHRM.tbl_disability_descption' table. You can move, or remove it, as needed.
        Me.Tbl_disability_descptionTableAdapter.FillBy(Me.DSHRM.tbl_disability_descption)
        If frmLogin.UserID = 1034 Then
            Me.Button3.Visible = False
            Me.Save.Visible = False
            Me.Button8.Visible = False
            Me.Button10.Visible = False
            Button11.Visible = False
        Else
            Me.Button3.Visible = True
            Me.Save.Visible = True
            Me.Button8.Visible = True
            Me.Button10.Visible = True
            Button11.Visible = True
        End If
        'TODO: This line of code loads data into the 'DSBusInfo.tbl_Bus_Route_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Bus_Route_InfoTableAdapter.Fill(Me.DSBusInfo.tbl_Bus_Route_Info)
        'TODO: This line of code loads data into the 'DSDept.View_HRM_Leave_Reason' table. You can move, or remove it, as needed.
        Me.View_HRM_Leave_ReasonTableAdapter.Fill(Me.DSDept.View_HRM_Leave_Reason)
        'TODO: This line of code loads data into the 'DSHRM.View_HOD_New' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSHRM.View_HOD' table. You can move, or remove it, as needed.
        'Me.View_HODTableAdapter.Fill(Me.DSHRM.View_HOD)

        Try
            Me.View_HOD_NewTableAdapter.Fill(Me.DSHRM.View_HOD_New, 1)
        Catch ex As Exception

        End Try


        If frmLogin.DeptID = 1 Or frmLogin.DeptID = 3 Then

            AdminFlag = True

        Else
            AdminFlag = False

        End If

        'TODO: This line of code loads data into the 'DSDept.tbl_HRM_Section_New' table. You can move, or remove it, as needed.


        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept1' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Dept1TableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept1)

        Me.Tbl_HRM_App_AuthorityTableAdapter.Fill(Me.DSHRM.tbl_HRM_App_Authority)


        Me.Tbl_Hrm_Emp_NoticesTableAdapter.Fill(Me.DSHRM.tbl_Hrm_Emp_Notices)

        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSHRM.tbl_Acc_FinancialPeriod)

        Me.Tbl_HRM_BankTableAdapter.Fill(Me.DSHRM.tbl_HRM_Bank)

        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Leave_Reason' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Leave_ReasonTableAdapter.Fill(Me.DSHRM.tbl_HRM_Leave_Reason)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_EmpCatagory' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_EmpCatagoryTableAdapter.Fill(Me.DSHRM.tbl_HRM_EmpCatagory)
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Employment' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_EmploymentTableAdapter.Fill(Me.DSHRM.tbl_Hrm_Employment)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Qualfication' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_QualficationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Qualfication)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_JobType' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_JobTypeTableAdapter.Fill(Me.DSHRM.tbl_HRM_JobType)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)


        Try
            If Me.View_Inactive_EmpTableAdapter.Fill(DSDept.View_Inactive_Emp, CardNoLabel2.Text) > 0 And AdminFlag = False Then
                EnableDisableBtn(False)
            Else
                EnableDisableBtn(True)
            End If

        Catch ex As Exception

        End Try

        Me.Tbl_HRM_CardTableAdapter.FillBy1(Me.DSHRM.tbl_HRM_Card)

        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
        Catch ex As Exception

        End Try
        Me.Tbl_HRM_Section_NewTableAdapter.Fill(Me.DSDept.tbl_HRM_Section_New)
        Me.Tbl_HRM_Dept_NewTableAdapter.Fill(Me.DSDept.tbl_HRM_Dept_New)

        Try
            Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, EmpIDLabel2.Text)
            Me.Tbl_Acc_Salary_NewBindingSource.MoveLast()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        GrupActive()

        If EmpPicPictureBox.Image IsNot Nothing Then
            Button1.Enabled = True
            Button4.Enabled = True
        Else
            Button1.Enabled = False
            Button4.Enabled = False
        End If






        Try
            If Me.Tbl_Acc_Salary2TableAdapter.Fill(DSHRM.tbl_Acc_Salary2, EmpIDLabel2.Text) > 0 And AdminFlag = False Then
                'GroupBox10.Enabled = False
                EnableDisable(True, False)
            Else
                'GroupBox10.Enabled = True
                EnableDisable(False, True)
            End If
        Catch ex As Exception

        End Try
        If Me.Tbl_Acc_Salary2BindingSource.Count > 0 Then

            Button8.Enabled = False
            Refference(True)
        Else
            Button8.Enabled = True
            Refference(False)
        End If

        Timer1.Start()

        If frmLogin.UserID = 1034 Then

            Panel4.Enabled = False
            HRReportsoption(False)
        Else
            Panel4.Enabled = True
            HRReportsoption(True)
        End If

        loardReportTo()





    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdminGroup(Enable As Boolean)
        GroupBox10.Enabled = Enable
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim TheSize As Long = Long.Parse(My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Length)
        If TheSize < 40000 Then


            EmpPicPictureBox.ImageLocation = OpenFileDialog1.FileName

            Refresh()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Uploadimage.Click
        OpenFileDialog1.Filter = "JPEG Files(*.jpg;)|*.jpg;"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim TheSize As Long = Long.Parse(My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Length)


            If TheSize > 40000 Then
                MessageBox.Show("Selected Pic Size is Large Plese Select pic with in the Size of 40 Kb ", "Picture Size Exceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        End If
    End Sub

    Private Sub Refference(Readvalue As Boolean)

        RefrenceTextBox.ReadOnly = Readvalue

    End Sub



    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TabControl1.SelectedTab = TabPage1
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TabControl1.SelectedTab = TabPage5
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked

        If ChildWindowOpen("Emp_dept_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_dept_Info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        If ChildWindowOpen("Emp_Designation_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Designation_Info

            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked

        If ChildWindowOpen("Employee_catagory") = False Then
            Dim frmChngPswdObj1115 As New Employee_catagory
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If

    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked


        If ChildWindowOpen("Emp_Employment_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Employment_Info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked

        If ChildWindowOpen("Emp_JobType_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_JobType_Info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked


        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked

        If ChildWindowOpen("Emp_Grade_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Grade_Info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked


        If ChildWindowOpen("Emp_Branch_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Branch_Info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub
    Dim BankID As Int16
    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked

        BankID = Me.BankNameComboBox.SelectedValue
        If ChildWindowOpen("Emp_Bank_info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Bank_info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub



    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        If ChildWindowOpen("Emp_Leaving_Reason") = False Then
            Dim frmChngPswdObj1115 As New Emp_Leaving_Reason
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked

        If ChildWindowOpen("Emp_Qualfication_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Qualfication_Info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()

        End If
    End Sub

    Private Sub LinkLabel1_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub
    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub
    Private Sub LinkLabel2_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel2.MouseEnter
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub
    Private Sub LinkLabel2_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel2.MouseLeave
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub
    Private Sub LinkLabel3_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel3.MouseEnter
        Me.LinkLabel3.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel3_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel3.MouseLeave
        Me.LinkLabel3.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub


    Private Sub LinkLabel16_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        If ChildWindowOpen("Emp_dept_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_dept_Info

            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Year As Integer
        Dim Day As Integer = DateDiff(DateInterval.Day, CDate(Me.DateOfBirthMaskedTextBox.Text), Now)
        Year = Day / 365
        If Year <= 15 Then
            MessageBox.Show("Employee Age is Less Then 18 Years", "Employee Age ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                Me.ValidateChildren()
                Me.Tbl_HRM_Emp_InfoBindingSource.EndEdit()
                'Me.Tbl_HRM_Emp_InfoTableAdapter.Update(Me.DSHRM.tbl_HRM_Emp_Info)
                Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, -55)

                Me.Tbl_HRM_CardTableAdapter.UpdateQuery(-55)
                'Me.CardStatusCheckBox.CheckState = Me.Tbl_HRM_CardTableAdapter.CardStatuss(Me.CardNoLabel2.Text)
                'Me.Tbl_HRM_Emp_InfoBindingSource.Position = j
                MessageBox.Show("Record Not Saved because Employee Age is Less Then 15 Years", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        Else
            Dim dgResult As DialogResult = MessageBox.Show("Are you sure, you want Save", "Save", MessageBoxButtons.YesNo)
            If dgResult = 6 Then


                Dim j As Int16 = Me.Tbl_HRM_Emp_InfoBindingSource.Position
                Try
                    Me.ValidateChildren()
                    Me.Tbl_HRM_Emp_InfoBindingSource.EndEdit()
                    Me.Tbl_HRM_Emp_InfoTableAdapter.Update(Me.DSHRM.tbl_HRM_Emp_Info)
                    Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)

                    Me.Tbl_HRM_CardTableAdapter.UpdateQuery(Me.CardNoLabel2.Text)
                    'Me.CardStatusCheckBox.CheckState = Me.Tbl_HRM_CardTableAdapter.CardStatuss(Me.CardNoLabel2.Text)
                    Me.Tbl_HRM_Emp_InfoBindingSource.Position = j
                    MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception

                    MessageBox.Show(ex.Message)

                End Try
            End If
        End If
        'If Day Then

        'End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tbl_Acc_SalaryBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles SaveSalary.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are you sure, you want to Save The Salary ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dgResult = 6 Then
            Dim j As Int16 = Me.Tbl_Acc_Salary_NewBindingSource.Position
            Try
                Me.ValidateChildren()
                Me.Tbl_Acc_Salary_NewBindingSource.EndEdit()
                Me.Tbl_Acc_Salary_NewTableAdapter.Update(Me.DSHRM.tbl_Acc_Salary_New)
                Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, Me.EmpIDLabel2.Text)
                Me.Tbl_Acc_Salary_NewBindingSource.Position = j
                MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmEmpManagment.Salaryflag = True
                AddSalary.Enabled = False

                SaveSalary.Enabled = False
                If Me.Tbl_Acc_Salary2BindingSource.Count > 0 Then

                    Button8.Enabled = False
                    Refference(True)
                Else
                    Button8.Enabled = True
                    Refference(False)
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, Me.EmpIDLabel2.Text)
                MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                AddSalary.Enabled = True

                SaveSalary.Enabled = True
                If Me.Tbl_Acc_Salary2BindingSource.Count > 0 Then

                    Button8.Enabled = False
                    Refference(True)
                Else
                    Button8.Enabled = True
                    Refference(False)
                End If
            End Try
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles AddSalary.Click

        AddSalary.Enabled = False


    End Sub
    Public Shared Deptflag As Boolean = False
    Public Shared Sectionflag As Boolean = False
    Public Shared Designationflag As Boolean = False
    Public Shared catagoryflag As Boolean = False
    Public Shared Employmentflag As Boolean = False
    Public Shared jobtypeflag As Boolean = False
    Public Shared Shiftflag As Boolean = False
    Public Shared Gradeflag As Boolean = False
    Public Shared Branchflag As Boolean = False
    Public Shared Bankflag As Boolean = False
    Public Shared Notesflag As Boolean = False
    Public Shared Qualficationflag As Boolean = False
    Public Shared Salaryflag As Boolean = False
    Public Shared Cardflag As Boolean = False
    Public Shared DisabilityFlag As Boolean = False


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Deptflag = True Then
            Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Deptflag = False
        ElseIf Sectionflag = True Then
            Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Sectionflag = False
        ElseIf Designationflag = True Then
            Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Designationflag = False
        ElseIf catagoryflag = True Then
            Me.Tbl_HRM_EmpCatagoryTableAdapter.Fill(Me.DSHRM.tbl_HRM_EmpCatagory)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            catagoryflag = False
        ElseIf Employmentflag = True Then
            Me.Tbl_Hrm_EmploymentTableAdapter.Fill(Me.DSHRM.tbl_Hrm_Employment)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Employmentflag = False
        ElseIf jobtypeflag = True Then
            Me.Tbl_HRM_JobTypeTableAdapter.Fill(Me.DSHRM.tbl_HRM_JobType)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            jobtypeflag = False
        ElseIf Shiftflag = True Then
            Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Shiftflag = False
        ElseIf Gradeflag = True Then
            Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Gradeflag = False
        ElseIf Branchflag = True Then
            Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)

            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Branchflag = False
        ElseIf Bankflag = True Then
            Me.Tbl_HRM_BankTableAdapter.Fill(Me.DSHRM.tbl_HRM_Bank)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Bankflag = False
        ElseIf Notesflag = True Then
            Me.Tbl_Hrm_Emp_NoticesTableAdapter.Fill(Me.DSHRM.tbl_Hrm_Emp_Notices)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Notesflag = False
        ElseIf Qualficationflag = True Then
            Me.Tbl_HRM_QualficationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Qualfication)
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            Qualficationflag = False
        ElseIf Cardflag = True Then
            Me.Tbl_HRM_CardTableAdapter.Fill(Me.DSHRM.tbl_HRM_Card)
            Me.Tbl_HRM_CardBindingSource.ResetBindings(True)
            Cardflag = False
        ElseIf DisabilityFlag = True Then
            Me.Tbl_disability_descptionTableAdapter.Fill(Me.DSHRM.tbl_disability_descption)
            Me.Tbl_disability_descptionBindingSource.ResetBindings(True)
            DisabilityFlag = False
        ElseIf Salaryflag = True Then
            Try
                Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, Me.EmpIDLabel2.Text)
            Catch ex As Exception

            End Try
            Me.Tbl_Acc_Salary_NewBindingSource.ResetBindings(True)
            Salaryflag = False
            If Me.Tbl_Acc_Salary2BindingSource.Count > 0 Then

                Button8.Enabled = False
                Refference(True)
            Else
                Button8.Enabled = True
                Refference(False)
            End If
        End If


    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub NameTextBox_GotFocus(sender As Object, e As EventArgs) Handles NameTextBox.GotFocus
        If Me.NameTextBox.Text.Length = 0 And CardStatusLabel1.Text = False And Me.SalutationComboBox.Text.Length = 0 Then
            Try
                Me.Tbl_HRM_Emp_InfoBindingSource.AddNew()
                'If Me.ActivationStatusCheckBox.Text = Nothing Then
                Me.SalutationComboBox.Text = "Mr."
                'End If
                EnableDisable(False, True)
                GrupActive()
            Catch ex As Exception

            End Try


        End If
    End Sub



    Private Sub NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameTextBox.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FatherNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FatherNameTextBox.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MotherNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MotherNameTextBox.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub EmpCityTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmpCityTextBox.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CNICNOMaskedTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CNICNOMaskedTextBox.KeyPress

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_HRM_Emp_InfoBindingSource.Filter = "Name Like '%" & Me.txtSName.Text & "%'"
        End If
    End Sub

    Private Sub RemoveFilterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Tbl_HRM_Emp_InfoBindingSource.RemoveFilter()
    End Sub

    Private Sub SectEffectiveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles SectEffectiveDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub SectEffectiveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles SectEffectiveDateMaskedTextBox.GotFocus
        If SectEffectiveDateMaskedTextBox.Text = "  -  -" Then
            SectEffectiveDateMaskedTextBox.Text = Now.Date
        End If
    End Sub

    Private Sub JobTypeEffectiveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles JobTypeEffectiveDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub JobTypeEffectiveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles JobTypeEffectiveDateMaskedTextBox.GotFocus
        If JobTypeEffectiveDateMaskedTextBox.Text = "  -  -" Then
            If DateOfPermanentMaskedTextBox.Text <> "  -  -" Then
                JobTypeEffectiveDateMaskedTextBox.Text = DateOfPermanentMaskedTextBox.Text
            End If

        End If
    End Sub


    Private Sub GradeEffectiveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles GradeEffectiveDateMaskedTextBox.GotFocus
        If GradeEffectiveDateMaskedTextBox.Text = "  -  -" Then
            GradeEffectiveDateMaskedTextBox.Text = Now.Date
        End If
    End Sub

    Private Sub ShiftEffectiveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles ShiftEffectiveDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub ShiftEffectiveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles ShiftEffectiveDateMaskedTextBox.GotFocus
        If ShiftEffectiveDateMaskedTextBox.Text = "  -  -" Then
            ShiftEffectiveDateMaskedTextBox.Text = Now.Date
        End If
    End Sub

    Private Sub BranchEffectiveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles BranchEffectiveDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub BranchEffectiveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles BranchEffectiveDateMaskedTextBox.GotFocus
        If BranchEffectiveDateMaskedTextBox.Text = "  -  -" Then
            BranchEffectiveDateMaskedTextBox.Text = Now.Date
        End If
    End Sub

    Private Sub LeaveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles LeaveDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub LeaveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles LeaveDateMaskedTextBox.GotFocus
        If LeaveDateMaskedTextBox.Text = "  -  -" Then
            LeaveDateMaskedTextBox.Text = Now.Date
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
    'Dim Loadflag As Boolean = False
    Private Sub Tbl_HRM_CardBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_CardBindingSource.PositionChanged


        Try
            If Me.View_Inactive_EmpTableAdapter.Fill(DSDept.View_Inactive_Emp, CardNoLabel2.Text) > 0 And AdminFlag = False Then
                EnableDisableBtn(False)
            Else
                EnableDisableBtn(True)
            End If

        Catch ex As Exception

        End Try




        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
        Catch ex As Exception

        End Try

        SaveSalary.Enabled = False
        GrupActive()

        If EmpPicPictureBox.Image IsNot Nothing Then
            Button1.Enabled = True
            Button4.Enabled = True
        Else
            Button1.Enabled = False
            Button4.Enabled = False
        End If



        Try
            If Me.Tbl_Acc_Salary2TableAdapter.Fill(DSHRM.tbl_Acc_Salary2, EmpIDLabel2.Text) > 0 And AdminFlag = False Then

                EnableDisable(True, False)
            Else

                EnableDisable(False, True)
            End If
        Catch ex As Exception

        End Try





        Try
            Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, EmpIDLabel2.Text)
            Me.Tbl_Acc_Salary_NewBindingSource.MoveLast()

            If Me.Tbl_Acc_Salary2BindingSource.Count > 0 Then

                Button8.Enabled = False
                Refference(True)
            Else

                Button8.Enabled = True
                Refference(False)
            End If
        Catch ex As Exception

        End Try
        If frmLogin.DeptID = 11 Then

            Panel4.Enabled = False
            HRReportsoption(False)
        Else
            Panel4.Enabled = True
            HRReportsoption(True)
        End If
        Try
            'Me.View_HOD_NewTableAdapter.Fill(Me.DSHRM.View_HOD_New, Val(Me.EmploymentIDLabel1.Text))
        Catch ex As Exception

        End Try

        Try
            HODNameComboBox.SelectedValue = Me.View_HODTableAdapter.HOD(EmpIDLabel2.Text)
        Catch ex As Exception
            'HODNameComboBox.SelectedValue = Nothing
        End Try


        If CheckBox1.Checked = False Then
            Save.Enabled = False
            Button3.Enabled = False
        End If
        loardReportTo()


    End Sub

    Private Sub EnableDisableBtn(EnabledValue1 As Boolean)
        Save.Enabled = EnabledValue1
        Button3.Enabled = EnabledValue1
        Uploadimage.Enabled = EnabledValue1
        AddSalary.Enabled = EnabledValue1
        SaveSalary.Enabled = EnabledValue1
        GroupBox12.Enabled = EnabledValue1
        GroupBox11.Enabled = EnabledValue1
        GroupBox13.Enabled = EnabledValue1
        AddNoticeBtn.Enabled = EnabledValue1
        printbtn.Enabled = EnabledValue1
        AddCopyBtn.Enabled = EnabledValue1
        Button2.Enabled = EnabledValue1

    End Sub

    Private Sub EnableDisableGroup(EnabledValue As Boolean)
        GroupBox12.Enabled = EnabledValue

        GroupBox12.Enabled = EnabledValue
        GroupBox12.Enabled = EnabledValue
        GroupBox11.Enabled = EnabledValue
        GroupBox13.Enabled = EnabledValue
        AddSalary.Enabled = EnabledValue
        SaveSalary.Enabled = EnabledValue
        AddNoticeBtn.Enabled = EnabledValue
        printbtn.Enabled = EnabledValue
        AddCopyBtn.Enabled = EnabledValue
        Button2.Enabled = EnabledValue

    End Sub
    Private Sub EnableDisable(ReadValue As Boolean, EnableValue1 As Boolean)
        SalutationComboBox.Enabled = EnableValue1
        NameTextBox.ReadOnly = ReadValue
        FatherNameTextBox.ReadOnly = ReadValue

        GenderComboBox.Enabled = EnableValue1
        ReligionComboBox.Enabled = EnableValue1
        DateOfJoning.ReadOnly = ReadValue

        DateOfBirthMaskedTextBox.ReadOnly = ReadValue
        EmpCityTextBox.ReadOnly = ReadValue
        EmpProvinceComboBox.Enabled = EnableValue1
        PermanentAddressTextBox.ReadOnly = ReadValue

        DateTimePicker14.Enabled = EnableValue1
        DateTimePicker10.Enabled = EnableValue1
        GroupBox10.Enabled = EnableValue1

        GroupBox6.Enabled = EnableValue1


        Button8.Enabled = EnableValue1
    End Sub



    Private Sub EnabledDOJ(EnableVal As Boolean)
        'GroupBox10.Enabled = EnableVal
        GroupBox1.Enabled = EnableVal
        GroupBox6.Enabled = EnableVal
        GroupBox9.Enabled = EnableVal
    End Sub

    Private Sub HRReportsoption(Enabled As Boolean) ''' HR Reports RIghts 
        'Save.Enabled = Enabled
        Button3.Enabled = Enabled
        'Button8.Enabled = Enabled
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected

        If Me.TabControl1.SelectedTab.Text = "Salary Data" Then



            Try
                Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, EmpIDLabel2.Text)
                Me.Tbl_Acc_Salary_NewBindingSource.MoveLast()
                GrupActive()

            Catch ex As Exception
            End Try
            If Me.Tbl_Acc_Salary_NewBindingSource.Count = 0 Then
                AddSalary.Enabled = True
                SaveSalary.Enabled = True
            Else
                AddSalary.Enabled = False
                SaveSalary.Enabled = False
            End If
        ElseIf Me.TabControl1.SelectedTab.Text = "Official Data" Then
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            'Try
            '    HODNameComboBox.SelectedValue = Me.View_HODTableAdapter.HOD(EmpIDLabel2.Text)
            'Catch ex As Exception
            '    'HODNameComboBox.SelectedValue = Nothing
            'End Try
            GrupActive()
        ElseIf Me.TabControl1.SelectedTab.Text = "Personal Data" Then
            Me.Tbl_HRM_Emp_InfoBindingSource.ResetBindings(True)
            'Try
            '    HODNameComboBox.SelectedValue = Me.View_HODTableAdapter.HOD(EmpIDLabel2.Text)
            'Catch ex As Exception
            '    'HODNameComboBox.SelectedValue = Nothing
            'End Try
            'Me.SectionNameComboBox.SelectedValue = Val(Me.SectionIDLabel.Text)
            GrupActive()

        End If

        Try
            If Me.Tbl_Acc_Salary2TableAdapter.Fill(DSHRM.tbl_Acc_Salary2, EmpIDLabel2.Text) > 0 And AdminFlag = False Then

                EnableDisable(True, False)
            Else

                EnableDisable(False, True)
            End If
        Catch ex As Exception

        End Try

        If Me.Tbl_Acc_Salary2BindingSource.Count > 0 Then

            Button8.Enabled = False
            Refference(True)
        Else
            Button8.Enabled = True
            Refference(False)
        End If

        If frmLogin.DeptID = 11 Then

            Panel4.Enabled = False
            HRReportsoption(False)
        Else
            Panel4.Enabled = True
            HRReportsoption(True)
        End If

        If CheckBox1.Checked = False Then
            Save.Enabled = False
            Button3.Enabled = False
        End If
    End Sub

    Private Sub CardStatusLabel1_Click(sender As Object, e As EventArgs) Handles CardStatusLabel1.Click

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click
    End Sub

    Private Sub GroupBox10_Enter(sender As Object, e As EventArgs) Handles GroupBox10.Enter
    End Sub

    Private Sub DateOfJoningMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles DateOfJoning.MaskInputRejected
    End Sub

    Private Sub DateOfJoningMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles DateOfJoning.GotFocus
        If DateOfJoning.Text = "  -  -" Then
            DateOfJoning.Text = Now.Date
        End If
    End Sub

    Private Sub GraduityDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles GraduityDateMaskedTextBox.MaskInputRejected
    End Sub



    Private Sub ActivationDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles ActivationDateMaskedTextBox.MaskInputRejected
    End Sub

    Private Sub ActivationDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles ActivationDateMaskedTextBox.GotFocus
    End Sub

    Private Sub EffectedFromDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles EffectedFromDateMaskedTextBox.MaskInputRejected
    End Sub
    Private Sub EffectedFromDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles EffectedFromDateMaskedTextBox.GotFocus
        If EffectedFromDateMaskedTextBox.Text = "  -  -" Then
            EffectedFromDateMaskedTextBox.Text = Now.Date
        End If
    End Sub
    Private Sub GraduityDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles GraduityDateMaskedTextBox.GotFocus
        If GraduityDateMaskedTextBox.Text = "  -  -" Then
            GraduityDateMaskedTextBox.Text = DateOfJoning.Text
        End If
    End Sub
    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs)
        'Dim postion As Integer = Tbl_Acc_Salary_NewBindingSource.Position
        'Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, Me.EmpIDLabel2.Text)
        'Tbl_Acc_Salary_NewBindingSource.Position = postion
        'AddSalary.Enabled = True
        'CancelToolStripButton.Visible = False
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SaveRecord()
        Dim dgResult As DialogResult = MessageBox.Show("Are you sure, you want Save", "Save", MessageBoxButtons.YesNo)
        If dgResult = 6 Then
            Dim j As Int16 = Me.Tbl_HRM_Emp_InfoBindingSource.Position
            Dim K As Int16 = Me.Tbl_Acc_Salary_NewBindingSource.Position
            Try
                Me.ValidateChildren()
                Me.Tbl_HRM_Emp_InfoBindingSource.EndEdit()
                Me.Tbl_HRM_Emp_InfoTableAdapter.Update(Me.DSHRM.tbl_HRM_Emp_Info)

                Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
                Me.Tbl_HRM_Emp_InfoBindingSource.Position = j
                Me.Tbl_Acc_Salary_NewBindingSource.Position = j
                MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        SaveRecord()
    End Sub
    Private Sub RefreshNow()
        RadioButton5.Checked = True
        Dim j As Int16 = Tbl_HRM_CardBindingSource.Position
        Dim LocalCard As Integer
        If BindingNavigator4.BindingSource.Equals(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource) Then
            LocalCard = Val(CardNoLabel3.Text)
        Else
            LocalCard = Val(CardNoLabel2.Text)
        End If
        Try
            BindingNavigator4.BindingSource = Me.Tbl_HRM_CardBindingSource
            Me.Tbl_HRM_CardTableAdapter.FillBy1(Me.DSHRM.tbl_HRM_Card)
            Navigation_EmpInfoHead()
            Me.CardNoComboBox.SelectedValue = LocalCard
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        GroupBox10.Enabled = False
        Tbl_HRM_CardBindingSource.Position = j

    End Sub
    Private Sub RemoveFilterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveFilterToolStripMenuItem1.Click

        RefreshNow()

    End Sub
    Private Sub txtSearchNIC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchNIC.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearchNIC.Text.Length = 0 Then
                MsgBox("Invalid String was Given for Search")
            Else
                FilterRecords(1, txtSearchNIC.Text)
            End If
            txtSearchNIC.Clear()
            CMSEmpInfo.Hide()
        End If
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        RefreshNow()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        Me.Tbl_HRM_CardBindingSource.Filter = "CardStatus=True"
        Me.Tbl_HRM_CardBindingSource.MoveFirst()

        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
        Catch ex As Exception

        End Try
        GrupActive()
        Try
            If Me.Tbl_Acc_Salary2TableAdapter.Fill(DSHRM.tbl_Acc_Salary2, EmpIDLabel2.Text) > 0 And AdminFlag = False Then

                EnableDisable(True, False)
            Else

                EnableDisable(False, True)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GrupActive()

        If CheckBox1.CheckState = CheckState.Unchecked Or CheckBox1.CheckState = CheckState.Indeterminate Then
            GroupBox12.Enabled = False
            GroupBox11.Enabled = False
            GroupBox13.Enabled = False
            AddNoticeBtn.Enabled = False
            printbtn.Enabled = False
            AddCopyBtn.Enabled = False
            Button2.Enabled = False
            AddSalary.Enabled = False
            Save.Enabled = False
            GroupBox10.Enabled = False
            GroupBox1.Enabled = False
            GroupBox6.Enabled = False
            GroupBox8.Enabled = False
            GroupBox9.Enabled = False
            Button3.Enabled = False
            Button6.Enabled = False
            Button7.Enabled = False
            Button8.Enabled = False

            Tbl_Acc_SalaryBindingNavigator.Enabled = False
        Else
            GroupBox12.Enabled = True
            GroupBox11.Enabled = True
            GroupBox10.Enabled = True
            GroupBox13.Enabled = True
            AddNoticeBtn.Enabled = True
            printbtn.Enabled = True
            AddCopyBtn.Enabled = True
            Button2.Enabled = True
            Button6.Enabled = True
            AddSalary.Enabled = False
            Save.Enabled = True
            Button3.Enabled = True
            GroupBox1.Enabled = True
            GroupBox6.Enabled = True
            GroupBox8.Enabled = True
            GroupBox9.Enabled = True
            Button7.Enabled = True
            Button8.Enabled = True

            Tbl_Acc_SalaryBindingNavigator.Enabled = True
        End If



        If frmLogin.DeptID = 11 Then

            Panel4.Enabled = False
            HRReportsoption(False)
        Else
            Panel4.Enabled = True
            HRReportsoption(True)
        End If



    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Me.Tbl_HRM_CardBindingSource.Filter = "CardStatus=false and CardNo>=3000"
        Me.Tbl_HRM_CardBindingSource.MoveFirst()
        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
        Catch ex As Exception

        End Try
        GrupActive()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Me.Tbl_HRM_CardBindingSource.RemoveFilter()
        Me.Tbl_HRM_CardBindingSource.MoveFirst()
        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
        Catch ex As Exception

        End Try

        GrupActive()
        Try
            If Me.Tbl_Acc_Salary2TableAdapter.Fill(DSHRM.tbl_Acc_Salary2, EmpIDLabel2.Text) > 0 And AdminFlag = False Then

                EnableDisable(True, False)
            Else

                EnableDisable(False, True)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub LinkLabel13_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        If ChildWindowOpen("emp_card_info") = False Then
            Dim frmChngPswdObj1115 As New emp_card_info
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()

        End If
    End Sub

    Private Sub CardNoLabel2_Click(sender As Object, e As EventArgs) Handles CardNoLabel2.Click

    End Sub

    Private Sub DateOfPermanentMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles DateOfPermanentMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub DateOfPermanentMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles DateOfPermanentMaskedTextBox.GotFocus

        If DateOfPermanentMaskedTextBox.Text = "  -  -" Then

            DateOfPermanentMaskedTextBox.Text = DateAdd(DateInterval.Month, 3, CDate(Me.DateOfJoning.Text))
            ' DateOfPermanentMaskedTextBox.Text = DateAdd(DateInterval.Day, -1, CDate(Me.DateOfPermanentMaskedTextBox.Text))
        End If
    End Sub




    Private Sub EndDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles EndDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub EndDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles EndDateMaskedTextBox.GotFocus
        If EndDateMaskedTextBox.Text = "  -  -" Then
            EndDateMaskedTextBox.Text = DateAdd(DateInterval.Year, 2, CDate(Me.StartDateMaskedTextBox.Text))
        End If

    End Sub

    Private Sub StartDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles StartDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub StartDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles StartDateMaskedTextBox.GotFocus

        If StartDateMaskedTextBox.Text = "  -  -" Then
            StartDateMaskedTextBox.Text = CDate(DateOfJoning.Text)
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RefreshNow()
        GrupActive()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RefreshNow()


        'Catch ex As Exception

        'End Try
        GrupActive()
        Try
            If Me.Tbl_Acc_Salary2TableAdapter.Fill(DSHRM.tbl_Acc_Salary2, EmpIDLabel2.Text) > 0 And AdminFlag = False Then

                EnableDisable(True, False)
            Else

                EnableDisable(False, True)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged


    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged

    End Sub

    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.ValueChanged

    End Sub

    Private Sub DateTimePicker6_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker7_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker7.ValueChanged
        LeaveDateMaskedTextBox.Text = Me.DateTimePicker7.Text
    End Sub

    Private Sub DateTimePicker9_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker9.ValueChanged

    End Sub

    Private Sub DateTimePicker8_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker8.ValueChanged

    End Sub

    Private Sub DateTimePicker10_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker10.ValueChanged

    End Sub

    Private Sub DateTimePicker11_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker11.ValueChanged

    End Sub

    Private Sub DateTimePicker12_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker12.ValueChanged

    End Sub

    Private Sub DateTimePicker13_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker13.ValueChanged

    End Sub

    Private Sub DateTimePicker14_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker14.ValueChanged

    End Sub

    Private Sub AddCopyBtn_Click(sender As Object, e As EventArgs) Handles AddCopyBtn.Click
        Dim Copy_No As Integer = Me.Tbl_HRM_Emp_InfoTableAdapter.MaxCopyNo(Me.EmpIDLabel2.Text)
        Dim dgResult As DialogResult = MessageBox.Show("Are you sure, you want to Add " & Copy_No & " Copy Number", "Warning", MessageBoxButtons.YesNo)

        If dgResult = 6 Then
            MaskedTextBox2.Text = Nothing
            Try
                Me.CopyNoTextBox.Text = Copy_No
                Me.StartDateMaskedTextBox.Text = CDate("#" & CDate(Me.DateOfJoning.Text).Day & "-" & CDate(Me.DateOfJoning.Text).Month & "-" & Now.Date.Year & "#")
                If CDate(Me.StartDateMaskedTextBox.Text) > Now.Date Then
                    Me.StartDateMaskedTextBox.Text = DateAdd(DateInterval.Year, -1, CDate(StartDateMaskedTextBox.Text))
                Else
                    Me.StartDateMaskedTextBox.Text = CDate("#" & CDate(Me.DateOfJoning.Text).Day & "-" & CDate(Me.DateOfJoning.Text).Month & "-" & Now.Date.Year & "#")
                End If
                Me.EndDateMaskedTextBox.Text = DateAdd(DateInterval.Year, 2, CDate(Me.StartDateMaskedTextBox.Text))
                Me.EndDateMaskedTextBox.Text = DateAdd(DateInterval.Day, -1, CDate(Me.EndDateMaskedTextBox.Text))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim j As Int16 = Me.Tbl_HRM_Emp_InfoBindingSource.Position
            Try
                Me.CopyNoTextBox.Text = Copy_No
                'Me.ValidateChildren()
                'Me.Tbl_HRM_Emp_InfoBindingSource.EndEdit()
                'Me.Tbl_HRM_Emp_InfoTableAdapter.Update(Me.DSHRM.tbl_HRM_Emp_Info)
                If RadioButton5.Checked Then
                    Me.Tbl_HRM_CardTableAdapter.UpdateCopyNo(CopyNoTextBox.Text, "Original", Me.StartDateMaskedTextBox.Text, Me.EndDateMaskedTextBox.Text, Me.CardNoLabel2.Text)
                ElseIf RadioButton4.Checked Then
                    Me.Tbl_HRM_CardTableAdapter.UpdateCopyNo(CopyNoTextBox.Text, "Duplicate", Me.StartDateMaskedTextBox.Text, Me.EndDateMaskedTextBox.Text, Me.CardNoLabel2.Text)
                End If

                Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
                Me.Tbl_HRM_Emp_InfoBindingSource.Position = j
                MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub BasicSalaryTextBox_TextChanged(sender As Object, e As EventArgs) Handles BasicSalaryTextBox.TextChanged

    End Sub

    Private Sub BasicSalaryTextBox_Leave(sender As Object, e As EventArgs) Handles BasicSalaryTextBox.Leave
        'Me.BasicSalaryTextBox.Text = FormatNumber(Me.BasicSalaryTextBox.Text, 1, TriState.UseDefault, TriState.UseDefault, TriState.True)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        If CopyNoTextBox.Text.Length = 0 Then
            Flag = True
        ElseIf CopyNoTextBox.Text.Length > 0 Then
            Flag = False
            If frntbtn.Checked = True Then

                Path = "" & frmLogin.ReportsPath & "\HR\EmpCrdFSRpt.rpt"
                Filter = "{tbl_HRM_Emp_Info.EmpID} = " & EmpIDLabel2.Text & ""
            ElseIf backbtn.Checked = True Then

                Path = "" & frmLogin.ReportsPath & "\HR\EmpCrdBSRpt.rpt"
                Filter = "{tbl_HRM_Emp_Info.EmpID} = " & EmpIDLabel2.Text & " ANd {tbl_HRM_Emp_Info.CopyNo} = " & CopyNoTextBox.Text & ""
            End If
        End If


        If Flag = True Then

            MessageBox.Show("Please Assign Card Copy", "No card Copy Assign", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadCardReports(Path, Filter, Param)
        End If

    End Sub
    Dim Flag As Boolean = False




    Private Sub GroupBox14_Enter(sender As Object, e As EventArgs) Handles GroupBox14.Enter

    End Sub

    Private Sub GroupBox14_MouseEnter(sender As Object, e As EventArgs) Handles GroupBox14.MouseEnter

    End Sub

    Private Sub CopyNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles CopyNoTextBox.TextChanged

    End Sub

    Private Sub MaskedTextBox1_GotFocus(sender As Object, e As EventArgs) Handles MaskedTextBox1.GotFocus
        If MaskedTextBox1.Text = "  -  -" Then
            MaskedTextBox1.Text = Now.Date
        End If

    End Sub

    Private Sub DateTimePicker6_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker6.ValueChanged

    End Sub

    Private Sub PESSIContCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles PESSIContCheckBox.CheckedChanged

    End Sub

    Private Sub PESSIContCheckBox_GotFocus(sender As Object, e As EventArgs) Handles PESSIContCheckBox.GotFocus

    End Sub

    Private Sub BindingNavigator4_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk
        EmpPicPictureBox.Image.Save(SaveFileDialog1.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

    End Sub

    Private Sub CMSEmpInfo_Opening(sender As Object, e As CancelEventArgs) Handles CMSEmpInfo.Opening

    End Sub

    Private Sub BankNameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NetTotalLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IncrementStatusLabel1_Click(sender As Object, e As EventArgs) Handles IncrementStatusLabel1.Click

    End Sub

    Private Sub PaymentModeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PaymentModeComboBox.SelectedIndexChanged

    End Sub

    Private Sub PaymentModeComboBox_GotFocus(sender As Object, e As EventArgs) Handles PaymentModeComboBox.GotFocus

    End Sub

    Private Sub NetGrossSalaryLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccommodationTextBox_TextChanged(sender As Object, e As EventArgs) Handles AccommodationTextBox.TextChanged

    End Sub



    Private Sub GroupBox12_Enter(sender As Object, e As EventArgs) Handles GroupBox12.Enter

    End Sub
    Private Sub GrossSalary()
        'MsgBox(Val(AccommodationTextBox.Text))
        Try
            'NetGrossSalaryLabel1.Text = Val(BasicSalaryTextBox.Text) + Val(SpecialAllowanceTextBox.Text) + Val(MealAllowanceTextBox.Text * 26) + Val(TravelAllowanceTextBox.Text) + Val(EducationAllowanceTextBox.Text) + Val(AccommodationTextBox.Text)
        Catch ex As Exception
            'NetGrossSalaryLabel1.Text = 0
        End Try

    End Sub
    Private Sub AccommodationTextBox_GotFocus(sender As Object, e As EventArgs) Handles AccommodationTextBox.GotFocus
        GrossSalary()
    End Sub

    Private Sub AccommodationTextBox_LostFocus(sender As Object, e As EventArgs) Handles AccommodationTextBox.LostFocus
        GrossSalary()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub AddNoticeBtn_Click(sender As Object, e As EventArgs) Handles AddNoticeBtn.Click
        Dim Notice_NO As Integer = Tbl_HRM_Emp_InfoTableAdapter.MaxNoticeNo(Me.EmpIDLabel2.Text)
        Dim dgResult As DialogResult = MessageBox.Show("Are you sure, You Want To Add " & Notice_NO & " Notice No ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If dgResult = 6 Then

            Me.NoticeNo.Text = Notice_NO
            MaskedTextBox1.Text = Date.Now
            NoticeTypeComboBox1.Text = ""
            NoticeTypeComboBox.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub SpecialAllowanceTextBox_TextChanged(sender As Object, e As EventArgs) Handles SpecialAllowanceTextBox.TextChanged

    End Sub

    Private Sub SpecialAllowanceTextBox_GotFocus(sender As Object, e As EventArgs) Handles SpecialAllowanceTextBox.GotFocus
        GrossSalary()
    End Sub

    Private Sub MealAllowanceTextBox_TextChanged(sender As Object, e As EventArgs) Handles MealAllowanceTextBox.TextChanged

    End Sub

    Private Sub MealAllowanceTextBox_GotFocus(sender As Object, e As EventArgs) Handles MealAllowanceTextBox.GotFocus
        GrossSalary()
    End Sub

    Private Sub TravelAllowanceTextBox_TextChanged(sender As Object, e As EventArgs) Handles TravelAllowanceTextBox.TextChanged

    End Sub

    Private Sub TravelAllowanceTextBox_GotFocus(sender As Object, e As EventArgs) Handles TravelAllowanceTextBox.GotFocus
        GrossSalary()
    End Sub

    Private Sub EducationAllowanceTextBox_TextChanged(sender As Object, e As EventArgs) Handles EducationAllowanceTextBox.TextChanged

    End Sub

    Private Sub EducationAllowanceTextBox_GotFocus(sender As Object, e As EventArgs) Handles EducationAllowanceTextBox.GotFocus
        GrossSalary()
    End Sub

    Private Sub GradeEffectiveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles GradeEffectiveDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub LeaveDateMaskedTextBox_Invalidated(sender As Object, e As InvalidateEventArgs) Handles LeaveDateMaskedTextBox.Invalidated

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)
        Me.Tbl_HRM_CardBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim dgResult As DialogResult = MessageBox.Show("Are you sure, Your Want To Clear Image ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If dgResult = 6 Then
            EmpPicPictureBox.Image = Nothing
            Try
                Me.ValidateChildren()
                Me.Tbl_HRM_Emp_InfoBindingSource.EndEdit()
                Me.Tbl_HRM_Emp_InfoTableAdapter.Update(Me.DSHRM.tbl_HRM_Emp_Info)
                Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
                Me.Tbl_HRM_CardTableAdapter.UpdateQuery(Me.CardNoLabel2.Text)
                MessageBox.Show("Image Successfully Clear  ", "Image Clear", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Refresh()
            Catch ex As Exception

            End Try



        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click



        If NoticeNo.Text.Length = 0 Then
            Flag = True
        ElseIf NoticeNo.Text.Length > 0 Then
            Flag = False
            If frntbtn.Checked = True Then

                Path = "" & frmLogin.ReportsPath & "\HR\RptNotice.rpt"
                Filter = "{tbl_HRM_Emp_Info.EmpID} = " & EmpIDLabel2.Text & ""
            End If
        End If


        If Flag = True Then

            MessageBox.Show("Please Add Notice Number ", "No Notice Number Assign", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadCardReports(Path, Filter, Param)
        End If
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked



        If ChildWindowOpen("Emp_Leaving_Reason") = False Then
            Dim frmChngPswdObj1115 As New Emp_Leaving_Reason
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        If ChildWindowOpen("Employee_Notice") = False Then
            Dim frmChngPswdObj1115 As New Employee_Notice
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()
        End If
    End Sub

    Private Sub EmpIDLabel3_Click(sender As Object, e As EventArgs) Handles EmpIDLabel3.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RefreshNow()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are you sure, you want to Save The Salary ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dgResult = 6 Then
            Dim j As Int16 = Me.Tbl_Acc_Salary_NewBindingSource.Position
            Try
                Me.ValidateChildren()
                Me.Tbl_Acc_Salary_NewBindingSource.EndEdit()
                Me.Tbl_Acc_Salary_NewTableAdapter.Update(Me.DSHRM.tbl_Acc_Salary_New)
                Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, Me.EmpIDLabel2.Text)
                Me.Tbl_Acc_Salary_NewBindingSource.Position = j
                MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmEmpManagment.Salaryflag = True
                AddSalary.Enabled = False

                SaveSalary.Enabled = False

            Catch ex As Exception
                'MsgBox(ex.Message)
                Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, Me.EmpIDLabel2.Text)
                MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                AddSalary.Enabled = True

                SaveSalary.Enabled = True

            End Try
        End If
    End Sub

    Private Sub CardNoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CardNoComboBox.SelectedIndexChanged

    End Sub

    Private Sub Tbl_HRM_Emp_InfoBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_Emp_InfoBindingSource.PositionChanged

    End Sub

    Private Sub View_Rpt_HR_EmpData_ActiveNonActiveBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles View_Rpt_HR_EmpData_ActiveNonActiveBindingSource.PositionChanged
        Try
            Me.Tbl_HRM_CardTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Card, Val(CardNoLabel3.Text))
        Catch ex As Exception

        End Try



        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Val(CardNoLabel3.Text))
        Catch ex As Exception

        End Try

        SaveSalary.Enabled = False
        GrupActive()

        If EmpPicPictureBox.Image IsNot Nothing Then
            Button1.Enabled = True
            Button4.Enabled = True
        Else
            Button1.Enabled = False
            Button4.Enabled = False
        End If



        Try
            If Me.Tbl_Acc_Salary2TableAdapter.Fill(DSHRM.tbl_Acc_Salary2, EmpIDLabel2.Text) > 0 And AdminFlag = False Then

                EnableDisable(True, False)
            Else

                EnableDisable(False, True)
            End If
        Catch ex As Exception

        End Try





        Try
            Me.Tbl_Acc_Salary_NewTableAdapter.Fill(Me.DSHRM.tbl_Acc_Salary_New, EmpIDLabel2.Text)
            Me.Tbl_Acc_Salary_NewBindingSource.MoveLast()

            If Me.Tbl_Acc_Salary_NewBindingSource.Count > 0 Then

                Button8.Enabled = False
                Refference(True)
            Else

                Button8.Enabled = True
                Refference(False)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DateTimePicker5_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.TextChanged
        SectEffectiveDateMaskedTextBox.Text = Me.DateTimePicker5.Text
    End Sub

    Private Sub DateTimePicker10_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker10.TextChanged
        DateOfJoning.Text = Me.DateTimePicker10.Text
    End Sub

    Private Sub DateTimePicker11_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker11.TextChanged
        DateOfPermanentMaskedTextBox.Text = Me.DateTimePicker11.Text
    End Sub

    Private Sub DateTimePicker12_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker12.TextChanged
        GraduityDateMaskedTextBox.Text = Me.DateTimePicker12.Text
    End Sub

    Private Sub DateTimePicker2_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.TextChanged
        GradeEffectiveDateMaskedTextBox.Text = Me.DateTimePicker2.Text
    End Sub

    Private Sub DateTimePicker3_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.TextChanged
        ShiftEffectiveDateMaskedTextBox.Text = Me.DateTimePicker3.Text
    End Sub

    Private Sub DateTimePicker4_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.TextChanged
        BranchEffectiveDateMaskedTextBox.Text = Me.DateTimePicker4.Text
    End Sub

    Private Sub DateTimePicker1_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.TextChanged
        JobTypeEffectiveDateMaskedTextBox.Text = Me.DateTimePicker1.Text
    End Sub

    Private Sub DateTimePicker6_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker6.TextChanged
        MaskedTextBox1.Text = DateTimePicker6.Text
    End Sub

    Private Sub DateTimePicker9_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker9.TextChanged
        StartDateMaskedTextBox.Text = Me.DateTimePicker9.Text
    End Sub

    Private Sub DateTimePicker8_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker8.TextChanged
        EndDateMaskedTextBox.Text = Me.DateTimePicker8.Text
    End Sub

    Private Sub DateTimePicker14_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker14.TextChanged
        DateOfBirthMaskedTextBox.Text = Me.DateTimePicker14.Text
    End Sub

    Private Sub DateTimePicker13_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker13.TextChanged
        EffectedFromDateMaskedTextBox.Text = Me.DateTimePicker13.Text
    End Sub

    Private Sub DateOfBirthMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles DateOfBirthMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub DateOfBirthMaskedTextBox_ModifiedChanged(sender As Object, e As EventArgs) Handles DateOfBirthMaskedTextBox.ModifiedChanged

    End Sub

    Private Sub Tbl_Hrm_EmploymentBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Hrm_EmploymentBindingSource.PositionChanged
        Try
            'Me.View_HOD_NewTableAdapter.Fill(Me.DSHRM.View_HOD_New, Val(Me.EmploymentIDLabel1.Text))
        Catch ex As Exception
        End Try
        Try
            'HODNameComboBox.SelectedValue = Me.View_HODTableAdapter.HOD(EmpIDLabel2.Text)
        Catch ex As Exception
            'HODNameComboBox.SelectedValue = Nothing
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            HODNameComboBox.SelectedValue = Me.View_HODTableAdapter.HOD(EmpIDLabel2.Text)
        Catch ex As Exception
            HODNameComboBox.SelectedValue = 0
        End Try
        Try
            Me.SectionNameComboBox.SelectedValue = Val(Me.SectionIDLabel.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalutationComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SalutationComboBox.SelectedIndexChanged

    End Sub




    Private Sub DateTimePicker15_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker15.ValueChanged

    End Sub

    Private Sub DateTimePicker15_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker15.TextChanged
        MaskedTextBox2.Text = Me.DateTimePicker15.Text
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            MaskedTextBox2.Text = Now.Date
            StartDateMaskedTextBox.Enabled = False
            MaskedTextBox2.Enabled = True
            DateTimePicker15.Enabled = True
            DateTimePicker9.Enabled = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            StartDateMaskedTextBox.Enabled = True
            MaskedTextBox2.Enabled = False
            DateTimePicker9.Enabled = True
            DateTimePicker15.Enabled = False
        End If
    End Sub
    Private Sub loardReportTo()
        'If frmLogin.DeptID = 3 Then
        '    Button3.Enabled = True
        '    Save.Enabled = True
        'Else
        '    Button3.Enabled = False
        '    Save.Enabled = False
        'End If

        'Dim ReportTo As String
        'Dim Str As String = ""

        'ComboBox1.Items.Clear()
        'Me.View_HODTableAdapter.Fill(Me.DSHRM.View_HOD)

        ''For i As Integer = 0 To 10

        'For i As Integer = 0 To Me.DSHRM.View_HOD.Count - 1
        '    If i = 0 Then
        '        ReportTo = Me.DSHRM.View_HOD(i).Item("HODName")


        '        'ReportTo = "'" & Me.DSHRMS.View_HOD(i).Item("HODName").ToString & "'"
        '        'ReportTo = "'" & lstCards.Items.Item(i).ToString & "'"
        '        Str = Str & ReportTo
        '    Else
        '        ReportTo = Me.DSHRM.View_HOD(i).Item("HODName")
        '        'Str = Str & ", " & lstCards.Items.Item(i).ToString()
        '        'ReportTo = "'" & Me.DSHRMS.View_HOD(i).Item("HODName").ToString & "'"
        '        Str = Str & "," & ReportTo

        '    End If
        'Next
        'Dim s As String = Str
        ''Dim s As String = TextBox1.Text
        'Dim parts As String() = s.Split(New Char() {","c})
        'Dim part As String

        'For Each part In parts
        '    ComboBox1.Items.Add(part)

        'Next
    End Sub

    Private Sub DateTimePicker18_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker18.ValueChanged

    End Sub

    Private Sub DateTimePicker18_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker18.TextChanged
        MaskedTextBox5.Text = Me.DateTimePicker18.Text
    End Sub
    Private Sub DateTimePicker17_TextChanged(sender As Object, e As EventArgs) Handles DateTimePicker17.TextChanged
        MaskedTextBox4.Text = Me.DateTimePicker17.Text
    End Sub

    Private Sub DateTimePicker19_ValueChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub DateTimePicker16_ValueChanged(sender As Object, e As EventArgs)

    End Sub





    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are you sure, you want Save", "Save", MessageBoxButtons.YesNo)
        If dgResult = 6 Then
            Dim j As Int16 = Me.Tbl_HRM_Emp_InfoBindingSource.Position
            Try
                Me.ValidateChildren()
                Me.Tbl_HRM_Emp_InfoBindingSource.EndEdit()
                Me.Tbl_HRM_Emp_InfoTableAdapter.Update(Me.DSHRM.tbl_HRM_Emp_Info)

                Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
                Me.Tbl_HRM_Emp_InfoBindingSource.Position = j
                MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RefreshNow()
    End Sub

    Private Sub GroupBox15_Enter(sender As Object, e As EventArgs) Handles GroupBox15.Enter

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SaveRecord()
    End Sub

    Private Sub txtSName_Click(sender As Object, e As EventArgs) Handles txtSName.Click

    End Sub

    Private Sub LinkLabel18_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub LinkLabel19_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel19.LinkClicked
        If ChildWindowOpen("FrmDisability") = False Then
            Dim frmChngPswdObj1115 As New FrmDisability
            'frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.ShowDialog()

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label18.Visible = True
            DescriptionComboBox.Enabled = True
            LinkLabel19.Enabled = True
        Else
            Label18.Visible = True
            DescriptionComboBox.Enabled = False
            LinkLabel19.Enabled = False
        End If
    End Sub



    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Me.Tbl_HRM_Emp_Info_SAVE_NEWTableAdapter.Fill(Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW, CardNoComboBox.Text) > 0 Then
            Dim NewCard As Int16 = InputBox("Enter New Card No.")

            If Me.Tbl_HRM_Emp_Info_SAVETableAdapter.Fill(Me.DSEMP.tbl_HRM_Emp_Info_SAVE, NewCard) > 0 Then
                MsgBox("Already Entered Card Assigned to another Employee ")
            Else

                Dim CardNo As Int64 = NewCard
                Dim Salutation As String = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("Salutation")
                Dim Name As String = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("Name")
                Dim FatherName As String = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("FatherName")
                Dim MotherName As String
                Dim Gender As String
                Dim Religion As String
                Dim CNICNO As String
                Dim BloodGroup As String
                Dim MaritalStatus As String
                Dim DateOfBirth As Date
                Dim ContactNo As String
                Dim EmergencyContactNo As String
                Dim EmpCity As String
                Dim EmpProvince As String
                Dim CurrentAddress As String
                Dim PermanentAddress As String
                Dim EmpCatagoryID As Int64
                Dim EmployeeExperiance As String
                Dim EmployeeCatagory As String
                Dim SSCNO As String
                Dim NTNNO As String
                Dim EOBINO As String
                Dim StateLifeNo As String
                Dim Refrence As String
                Dim DirectReportingTo As String
                Dim InDirectReportingTo As String
                Dim DeptID As Int64
                Dim SectionID As Int64
                Dim SectEffectiveDate As Date
                Dim DesignationID As Int64
                Dim GradeID As Int64
                Dim GradeEffectiveDate As Date
                Dim BranchID As Int64
                Dim BranchEffectiveDate As Date
                Dim QualficationID As Int64
                Dim JobTypeID As Int64
                Dim JobTypeEffectiveDate As Date
                Dim EmploymentID As Int64
                Dim ShiftID As Int64
                Dim ShiftEffectiveDate As Date
                Dim EmployeePic As Image
                Dim EmailAddress As String
                Dim AccJobType As String
                Dim DisableStatus As Boolean
                Dim HusbandName As String
                Dim EmployeeType As String
                Dim DisabilityID As Int64

                Try
                        MotherName = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("MotherName")
                    Catch ex As Exception

                    End Try
                Try
                    Gender = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("Gender")
                Catch ex As Exception

                End Try

                Try
                    Religion = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("Religion")
                Catch ex As Exception

                End Try
                Try
                    CNICNO = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("CNICNO")
                Catch ex As Exception

                End Try

                Try
                    BloodGroup = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("BloodGroup")
                Catch ex As Exception

                End Try
                Try
                    MaritalStatus = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("MaritalStatus")
                Catch ex As Exception

                End Try
                Try '
                    DateOfBirth = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("DateOfBirth")
                Catch ex As Exception

                End Try
                Try
                    ContactNo = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("ContactNo")
                Catch ex As Exception

                End Try
                Try
                    EmergencyContactNo = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmergencyContactNo")
                Catch ex As Exception

                End Try
                Try
                    EmpCity = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmpCity")
                Catch ex As Exception

                End Try
                Try
                    EmpProvince = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmpProvince")
                Catch ex As Exception

                End Try
                Try
                    CurrentAddress = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("CurrentAddress")
                Catch ex As Exception

                End Try
                Try
                    PermanentAddress = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("PermanentAddress")
                Catch ex As Exception

                End Try
                Try
                    EmpCatagoryID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmpCatagoryID")
                Catch ex As Exception

                End Try
                Try
                    EmployeeExperiance = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmployeeExperiance")
                Catch ex As Exception

                End Try
                Try
                    EmployeeCatagory = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmployeeCatagory")
                Catch ex As Exception

                End Try
                Try
                    SSCNO = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("SSCNO")
                Catch ex As Exception

                End Try
                Try
                    NTNNO = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("NTNNO")
                Catch ex As Exception

                End Try
                Try
                    EOBINO = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EOBINO")
                Catch ex As Exception

                End Try
                Try
                    StateLifeNo = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("StateLifeNo")
                Catch ex As Exception

                End Try
                Try
                    Refrence = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("Refrence")
                Catch ex As Exception

                End Try
                Try
                    DirectReportingTo = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("DirectReportingTo")
                Catch ex As Exception

                End Try
                Try
                    InDirectReportingTo = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("InDirectReportingTo")
                Catch ex As Exception

                End Try
                Try
                    DeptID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("DeptID")
                Catch ex As Exception

                End Try
                Try
                    SectionID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("SectionID")
                Catch ex As Exception

                End Try
                Try
                    SectEffectiveDate = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("SectEffectiveDate")
                Catch ex As Exception

                End Try
                Try
                    DesignationID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("DesignationID")
                Catch ex As Exception

                End Try
                Try
                    GradeID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("GradeID")
                Catch ex As Exception

                End Try
                Try
                    GradeEffectiveDate = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("GradeEffectiveDate")
                Catch ex As Exception

                End Try
                Try
                    BranchID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("BranchID")
                Catch ex As Exception

                End Try
                Try
                    BranchEffectiveDate = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("BranchEffectiveDate")
                Catch ex As Exception

                End Try
                Try
                    QualficationID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("QualficationID")
                Catch ex As Exception

                End Try
                Try
                    JobTypeID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("JobTypeID")
                Catch ex As Exception

                End Try
                Try
                    JobTypeEffectiveDate = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("JobTypeEffectiveDate")
                Catch ex As Exception

                End Try
                Try
                    EmploymentID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmploymentID")
                Catch ex As Exception

                End Try
                Try
                    ShiftID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("ShiftID")
                Catch ex As Exception

                End Try
                Try
                    ShiftEffectiveDate = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("ShiftEffectiveDate")
                Catch ex As Exception

                End Try
                Try
                    EmployeePic = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmpPic")
                Catch ex As Exception

                End Try
                Try
                    EmailAddress = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmailAddress")
                Catch ex As Exception

                End Try
                Try
                    AccJobType = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("AccJobType")
                Catch ex As Exception

                End Try
                Try
                    DisableStatus = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("DisableStatus")
                Catch ex As Exception

                End Try
                Try
                    HusbandName = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("HusbandName")
                Catch ex As Exception

                End Try
                Try
                    EmployeeType = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("EmployeeType")
                Catch ex As Exception

                End Try
                Try
                    DisabilityID = Me.DSEMP.tbl_HRM_Emp_Info_SAVE_NEW.Rows(0).Item("DisabilityID")
                Catch ex As Exception

                End Try




                Try
                    Me.Tbl_HRM_Emp_Info_SAVETableAdapter.Insert(CardNo, Salutation, Name,
                                                           FatherName,
                                                           MotherName, Gender,
                                                           Religion, CNICNO,
                                                           BloodGroup, MaritalStatus,
                                                           DateOfBirth, ContactNo,
                                                           EmergencyContactNo, EmpCity,
                                                           EmpProvince, CurrentAddress,
                                                           PermanentAddress, EmpCatagoryID,
                                                           Nothing, Nothing,
                                                           Nothing, EmployeeExperiance,
                                                           EmployeeCatagory, SSCNO,
                                                           NTNNO, EOBINO,
                                                           StateLifeNo, Refrence,
                                                           DirectReportingTo, InDirectReportingTo,
                                                           DeptID, SectionID,
                                                           Now.Date, DesignationID,
                                                           GradeID, Now.Date,
                                                           BranchID, Now.Date,
                                                           QualficationID, JobTypeID,
                                                           Now.Date,
                                                           EmploymentID, ShiftID,
                                                           Now.Date,
                                                           Nothing, Nothing, Nothing, Nothing, Nothing,
                                                            Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True,
                                                            Nothing, Nothing, Nothing, Nothing, 1, "Original", Nothing, Nothing, Nothing, Nothing, Nothing,
                                                           AccJobType,
                                                            False, Nothing, Nothing, Nothing,
                                                           DisableStatus,
                                                           Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, True, True,
                                                           True,
                                                           True, True, 0, Nothing, Nothing, Nothing, HusbandName,
                                                           Nothing, EmployeeType, DisabilityID)
                    Me.Tbl_HRM_CardTableAdapter.UpdateQuery(CardNo)
                    Me.Tbl_HRM_CardTableAdapter.FillBy1(Me.DSHRM.tbl_HRM_Card)
                    Me.Tbl_HRM_CardBindingSource.Filter = "CardStatus=True"
                    Tbl_HRM_CardBindingSource.MoveLast()
                    Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, CardNo)
                    MsgBox("Employee Data Transfer Successfully")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If

            'If Tbl_HRM_CardTableAdapter.FillBy3(DSHRM.tbl_HRM_Card, TextBox6.Text) > 0 Then
            '    Tbl_HRM_Emp_InfoTableAdapter.Insert(TextBox6.Text, SalutationComboBox.Text, NameTextBox.Text, FatherNameTextBox.Text, MotherNameTextBox.Text, GenderComboBox.Text, ReligionComboBox.Text, CNICNOMaskedTextBox.Text, BloodGroupComboBox.Text, MaritalStatusComboBox.Text, DateOfBirthMaskedTextBox.Text, ContactNoMaskedTextBox.Text, EmpCityTextBox.Text, EmpProvinceComboBox.Text, PermanentAddressTextBox.Text, CurrentAddressTextBox.Text, DateOfPermanentMaskedTextBox.Text, GradeEffectiveDateMaskedTextBox.Text, EmployeeExperianceTextBox.Text, CatagoryNameComboBox.Text, SSCNOTextBox.Text, NTNNOTextBox.Text, EOBINOTextBox.Text, Nothing, RefrenceTextBox.Text,)
            '    MsgBox("Employee information   is Successfully Assign to New Card no")
            'Else
            '    MsgBox("Select Card  is already Assign")
            'End If
        Else
            MsgBox("Select Employee is Not Terminated")

        End If

    End Sub





    'Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
    '    loardReportTo()
    'End Sub
End Class