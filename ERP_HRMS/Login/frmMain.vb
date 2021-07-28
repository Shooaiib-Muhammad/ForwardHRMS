Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_Comp_Info' table. You can move, or remove it, as needed.
        'Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        'Me.PRMenu.Hide()
        'Me.HRMenu.Hide()
        'Me.AccMenu.Hide()
        Me.Admin.Hide()
        'Me.AccAdmin.Hide()

        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
        End If
    End Sub
    Function ChildWindowOpen(ByVal childWindow As String) As Boolean
        Try
            For Each f As Form In Me.MdiChildren
                If f.Name = childWindow Then
                    f.WindowState = FormWindowState.Maximized
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub AddBankToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBankToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Bank_info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Bank_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddBranchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBranchToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Branch_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Branch_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ManageEmployeesBioDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageEmployeesBioDataToolStripMenuItem.Click
        If ChildWindowOpen("frmEmpManagment") = False Then
            Dim frmEmployee As New frmEmpManagment
            frmEmployee.MdiParent = Me
            frmEmployee.WindowState = FormWindowState.Maximized
            frmEmployee.Show()
        End If
    End Sub
    Sub logout()
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        Me.Admin.Hide()
        'Me.MenuStripMMITAdmin.Hide()
        'Me.MenuStripAudit.Hide()
        'Me.MenuStripDispatch.Hide()
        'Me.MenuStripInventory.Hide()
        'Me.Export.Hide()
        'Me.MenuStripInventoryAdmin.Hide()
        'Me.MenuStripMMNonAdidas.Hide()
        'Me.MenuStripMatDemand.Hide()
        'Me.MenuStripMaterialVerification.Hide()
        'Me.MenuStripMatPurchase.Hide()
        'Me.MenuStripRawMaterial.Hide()
        'Me.MenuStripVerification.Hide()
        'Me.MenuStripInventoryReports.Hide()
        Me.ConMenu.Hide()
        Me.HRReportsMenu.Hide()
        Me.MainMenu.Show()
        Me.GatePassMenuStrip.Hide()
        Me.MenuStrip1.Hide()
        ToolStripDomain.Text = "Company Name: "
        'ToolStripDept.Text = "Department: "
        ToolStripUN.Text = "User Name: "
        ToolStripLoginDateTime.Text = "Login Date Time: "
        'If (Me.Tbl_User_LogTableAdapter.GetUserStatus(CModID, CDomID, CUserID) > 0) Then
        '    Me.Tbl_User_LogTableAdapter.UserLogOut(Now, CModID, CDomID, CUserID)
        'End If
        'CExitStatus = True

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
        End If
    End Sub
    Private Sub ChangePasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem1.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub
    Private Sub ExitToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem4.Click
        Me.Close()
    End Sub

    Private Sub CardNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CardNoToolStripMenuItem.Click
        If ChildWindowOpen("emp_card_info") = False Then
            Dim frmChngPswdObj1115 As New emp_card_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddDepartnmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDepartnmentToolStripMenuItem.Click
        If ChildWindowOpen("Emp_dept_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_dept_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddDesignationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDesignationToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Designation_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Designation_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub EmployeeCatagoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeCatagoryToolStripMenuItem.Click
        If ChildWindowOpen("Employee_catagory") = False Then
            Dim frmChngPswdObj1115 As New Employee_catagory
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddEmploymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmploymentToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Employment_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Employment_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddGradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddGradeToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Grade_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Grade_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddJobTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddJobTypeToolStripMenuItem.Click
        If ChildWindowOpen("Emp_JobType_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_JobType_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddLaevingReasonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddLaevingReasonToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Leaving_Reason") = False Then
            Dim frmChngPswdObj1115 As New Emp_Leaving_Reason
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddNoticeTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNoticeTypeToolStripMenuItem.Click
        If ChildWindowOpen("Employee_Notice") = False Then
            Dim frmChngPswdObj1115 As New Employee_Notice

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddQualficationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddQualficationToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Qualfication_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Qualfication_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddShiftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddShiftToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub CompnayProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompnayProfileToolStripMenuItem.Click
        If ChildWindowOpen("CompanyInfo") = False Then
            Dim frmChngPswdObj1115 As New CompanyInfo
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AddDomainsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDomainsToolStripMenuItem.Click

        If ChildWindowOpen("MIS_User_Dept") = False Then
            Dim frmChngPswdObj1115 As New MIS_User_Dept
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If

    End Sub

    Private Sub AddUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUsersToolStripMenuItem.Click
        If ChildWindowOpen("MIS_Users") = False Then
            Dim frmChngPswdObj1115 As New MIS_Users
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If


    End Sub



    Private Sub ContractualWagesReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MISCReportsToolStripMenuItem.Click
        If ChildWindowOpen("MiscRecord") = False Then
            Dim frmChngPswdObj1115 As New MiscRecord
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If

    End Sub

    Private Sub EvaluationReportToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem1.Click
        If ChildWindowOpen("SalaryManagnment") = False Then
            Dim frmChngPswdObj1115 As New SalaryManagnment

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub



    Private Sub EmployeesProfileReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeesProfileReportsToolStripMenuItem1.Click
        If ChildWindowOpen("RptemployeeRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptemployeeRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub HRReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentWiseReportsToolStripMenuItem.Click
        If ChildWindowOpen("RptDepartRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptDepartRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub EmpPreTerminationAssesmentReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateWiseReportsToolStripMenuItem.Click
        If ChildWindowOpen("DateWiseFrm ") = False Then
            Dim AnalysisRecordObj As New DateWiseFrm

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If



    End Sub

    Private Sub AppAuthourityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppAuthourityToolStripMenuItem.Click
        If ChildWindowOpen("App Authourity ") = False Then
            Dim AnalysisRecordObj As New App_Authourity

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AnalysisReportsToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("FrmAnalysisRcd") = False Then
            Dim AnalysisRecordObj As New FrmAnalysisRcd

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoCalculation1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoCalculation1ToolStripMenuItem.Click
        If ChildWindowOpen("frmAutoSalCalculation") = False Then
            Dim AnalysisRecordObj As New frmAutoSalCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AdjustmentAfterCalculationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdjustmentAfterCalculationToolStripMenuItem.Click
        If ChildWindowOpen("frmSalaryAdjustment") = False Then
            Dim AnalysisRecordObj As New frmSalaryAdjustment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ManualCalculationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualCalculationToolStripMenuItem.Click

        If ChildWindowOpen("frmMonthlySalary") = False Then
            Dim AnalysisRecordObj As New frmMonthlySalary

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub BounusTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs)


        If ChildWindowOpen("frmBonus") = False Then
            Dim AnalysisRecordObj As New frmBonus

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub BonusToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'If ChildWindowOpen("frmBonusDistribution") = False Then
        '    Dim AnalysisRecordObj As New frmBonusDistribution

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub DefineBonusNoToolStripMenuItem1_Click(sender As Object, e As EventArgs)


        'If ChildWindowOpen("frmBonusesCriteria") = False Then
        '    Dim AnalysisRecordObj As New frmBonusesCriteria

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub SalaryTransactionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalaryTransactionsToolStripMenuItem1.Click

        If ChildWindowOpen("frmSalaryTransactions") = False Then
            Dim AnalysisRecordObj As New frmSalaryTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub TerminatedEmployeesListToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub DedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DedToolStripMenuItem.Click

        If ChildWindowOpen("frmDeductions") = False Then
            Dim AnalysisRecordObj As New frmDeductions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub



    Private Sub ExtraOverTimeCalculationToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmployeeTerminationToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'If ChildWindowOpen("frmEmpTermination") = False Then
        '    Dim AnalysisRecordObj As New frmEmpTermination

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub UndoTerminatedEmployeesToolStripMenuItem1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TemporaryAdvancesToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'If ChildWindowOpen("ShortTermAdvances") = False Then
        '    Dim AnalysisRecordObj As New ShortTermAdvances

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub PermanentAdvancesToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'If ChildWindowOpen("LongTermAdvances") = False Then
        '    Dim AnalysisRecordObj As New LongTermAdvances

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub OtherSettingsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ApprovingAuthoritiesToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub payRollManagnmentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles payRollManagnmentToolStripMenuItem1.Click

        If ChildWindowOpen("frmPayrollManagment") = False Then
            Dim AnalysisRecordObj As New frmPayrollManagment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub HolidaysToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HolidaysToolStripMenuItem.Click

        If ChildWindowOpen("frmHolidays") = False Then
            Dim AnalysisRecordObj As New frmHolidays

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AttendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendaToolStripMenuItem.Click

        If ChildWindowOpen("frmAttDevice") = False Then
            Dim AnalysisRecordObj As New frmAttDevice

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AttendanceExcelToDBToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AttendanceExcelToDBToolStripMenuItem2.Click

        If ChildWindowOpen("frmAttAcessToDB") = False Then
            Dim AnalysisRecordObj As New frmAttAcessToDB

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoOvertimeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutoOvertimeToolStripMenuItem1.Click

        If ChildWindowOpen("frmAutoOTEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoOTEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoAttendanceToolStripMenuItem.Click

        If ChildWindowOpen("frmAutoAttEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoAttEmpEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoLeavesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoLeavesToolStripMenuItem.Click

        If ChildWindowOpen("frmAutoLeaves") = False Then
            Dim AnalysisRecordObj As New frmAutoLeaves

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EmployeesSalaryReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeesSalaryReportsToolStripMenuItem1.Click

        If ChildWindowOpen("frmSalaryReports") = False Then
            Dim AnalysisRecordObj As New frmSalaryReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EmployeesAdvanceReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeesAdvanceReportsToolStripMenuItem1.Click

        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim AnalysisRecordObj As New frmAdvanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AllowanceReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllowanceReportsToolStripMenuItem.Click

        If ChildWindowOpen("frmAllowanceReports") = False Then
            Dim AnalysisRecordObj As New frmAllowanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub BonusReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonusReportsToolStripMenuItem.Click

        If ChildWindowOpen("frmBonusReport") = False Then
            Dim AnalysisRecordObj As New frmBonusReport

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EmployeesEOBIReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeesEOBIReportsToolStripMenuItem1.Click

        'If ChildWindowOpen("frmEOBIReports") = False Then
        '    Dim AnalysisRecordObj As New frmEOBIReports

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub EmployeesOverTimeReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeesOverTimeReportsToolStripMenuItem1.Click
        If ChildWindowOpen("frmOverTimeAcc") = False Then
            Dim AnalysisRecordObj As New frmOverTimeAcc

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
        'If ChildWindowOpen("frmOverTimeReports") = False Then
        '    Dim AnalysisRecordObj As New frmOverTimeReports

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub TerminatedEmployeeReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

        'If ChildWindowOpen("frmTerminatedEmpFilter") = False Then
        '    Dim AnalysisRecordObj As New frmTerminatedEmpFilter

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub SalaryAnalysisReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

        'If ChildWindowOpen("frmSalaryAnalysisReports") = False Then
        '    Dim AnalysisRecordObj As New frmSalaryAnalysisReports

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub OtherReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OtherReportsToolStripMenuItem1.Click

        If ChildWindowOpen("frmOtherReports") = False Then
            Dim AnalysisRecordObj As New frmOtherReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AdvanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdvanceToolStripMenuItem.Click
        If ChildWindowOpen("frmAdvance") = False Then
            Dim AnalysisRecordObj As New frmAdvance
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AnnualLeavesToolStripMenuItem_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmAccAnnualLeaveTransactions") = False Then
            Dim AnalysisRecordObj As New frmAccAnnualLeaveTransactions
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AnnualLeaveReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AnnualLeaveReportsToolStripMenuItem1.Click

        If ChildWindowOpen("frmAnnualLeavesReports") = False Then
            Dim AnalysisRecordObj As New frmAnnualLeavesReports
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub CompnyProfile_Click(sender As Object, e As EventArgs) Handles CompnyProfile.Click
        If ChildWindowOpen("CompanyInfo") = False Then
            Dim frmChngPswdObj1115 As New CompanyInfo
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub changepwd_Click(sender As Object, e As EventArgs) Handles changepwd.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub LogoutMenu_Click(sender As Object, e As EventArgs) Handles LogoutMenu.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
            HRMenu.Hide()
        End If
    End Sub

    Private Sub ExitMenu_Click(sender As Object, e As EventArgs) Handles ExitMenu.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmEmpManagment") = False Then
            Dim frmEmployee As New frmEmpManagment
            frmEmployee.MdiParent = Me
            frmEmployee.WindowState = FormWindowState.Maximized
            frmEmployee.Show()
        End If
    End Sub

    Private Sub AppAuthority_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("App Authourity ") = False Then
            Dim AnalysisRecordObj As New App_Authourity

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub bank_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Bank_info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Bank_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Branch_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Branch_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Branch_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub CardNO_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("emp_card_info") = False Then
            Dim frmChngPswdObj1115 As New emp_card_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Dept_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_dept_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_dept_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Desig_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Designation_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Designation_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Empcatagory_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Employee_catagory") = False Then
            Dim frmChngPswdObj1115 As New Employee_catagory
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Employment_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Employment_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Employment_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Grade_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Grade_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Grade_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub JobType_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_JobType_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_JobType_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Noticereason_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Employee_Notice") = False Then
            Dim frmChngPswdObj1115 As New Employee_Notice

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub LeavingReason_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Leaving_Reason") = False Then
            Dim frmChngPswdObj1115 As New Emp_Leaving_Reason
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Qualfication_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Qualfication_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Qualfication_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub Shift_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem21_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("RptemployeeRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptemployeeRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("RptDepartRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptDepartRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem23_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("DateWiseFrm ") = False Then
            Dim AnalysisRecordObj As New DateWiseFrm

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem25_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("MiscRecord") = False Then
            Dim frmChngPswdObj1115 As New MiscRecord
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem24_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("FrmAnalysisRcd") = False Then
            Dim AnalysisRecordObj As New FrmAnalysisRcd

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmPayrollManagment") = False Then
            Dim payRollObj As New frmPayrollManagment

            payRollObj.MdiParent = Me
            payRollObj.WindowState = FormWindowState.Maximized
            payRollObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmAutoOTEntry") = False Then
            Dim payRollObj As New frmAutoOTEntry

            payRollObj.MdiParent = Me
            payRollObj.WindowState = FormWindowState.Maximized
            payRollObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmHolidays") = False Then
            Dim payRollObj As New frmHolidays

            payRollObj.MdiParent = Me
            payRollObj.WindowState = FormWindowState.Maximized
            payRollObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem27_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAttAcessToDB") = False Then
            Dim payRollObj As New frmAttAcessToDB

            payRollObj.MdiParent = Me
            payRollObj.WindowState = FormWindowState.Maximized
            payRollObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem31_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAttDevice") = False Then
            Dim payRollObj As New frmAttDevice

            payRollObj.MdiParent = Me
            payRollObj.WindowState = FormWindowState.Maximized
            payRollObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem32_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAutoAttEntry") = False Then
            Dim payRollObj As New frmAutoAttEmpEntry

            payRollObj.MdiParent = Me
            payRollObj.WindowState = FormWindowState.Maximized
            payRollObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem33_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAutoLeaves") = False Then
            Dim payRollObj As New frmAutoLeaves

            payRollObj.MdiParent = Me
            payRollObj.WindowState = FormWindowState.Maximized
            payRollObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
            PayRollMenu.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem53_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem53.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem54_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem54.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
            AccMenu.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem55_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem55.Click
        Me.Close()

    End Sub

    'Private Sub ToolStripMenuItem109_Click(sender As Object, e As EventArgs)
    '    If ChildWindowOpen("frmMonthlySalary") = False Then
    '        Dim AnalysisRecordObj As New frmMonthlySalary254

    '        AnalysisRecordObj.MdiParent = Me
    '        AnalysisRecordObj.WindowState = FormWindowState.Maximized
    '        AnalysisRecordObj.Show()
    '    End If
    'End Sub

    Private Sub ToolStripMenuItem110_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmSalaryAdjustment") = False Then
            Dim AnalysisRecordObj As New frmSalaryAdjustment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem111_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAutoSalCalculation") = False Then
            Dim AnalysisRecordObj As New frmAutoSalCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem113_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmBonus") = False Then
            Dim AnalysisRecordObj As New frmBonus

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem115_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("SalaryManagnment") = False Then
            Dim frmChngPswdObj1115 As New SalaryManagnment

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem116_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmSalaryTransactions") = False Then
            Dim AnalysisRecordObj As New frmSalaryTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem120_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmDeductions") = False Then
            Dim AnalysisRecordObj As New frmDeductions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem124_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAdvance") = False Then
            Dim AnalysisRecordObj As New frmAdvance
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem125_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAccAnnualLeaveTransactions") = False Then
            Dim AnalysisRecordObj As New frmAccAnnualLeaveTransactions
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem127_Click(sender As Object, e As EventArgs)
        'If ChildWindowOpen("frmEmpTermination") = False Then
        '    Dim AnalysisRecordObj As New frmEmpTermination

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub AnnualLeavesCalculationToolStripMenuItem1_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmAccAnnualLeaveTransactions") = False Then
            Dim AnalysisRecordObj As New frmAccAnnualLeaveTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem128_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAccAnnualLeaveTransactions") = False Then
            Dim AnalysisRecordObj As New frmAccAnnualLeaveTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem129_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmExtraOTCalculation") = False Then
            Dim AnalysisRecordObj As New frmExtraOTCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem130_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmUndoTermination") = False Then
            Dim AnalysisRecordObj As New frmUndoTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem135_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmSalaryReports") = False Then
            Dim AnalysisRecordObj As New frmSalaryReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem136_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim AnalysisRecordObj As New frmAdvanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem137_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAllowanceReports") = False Then
            Dim AnalysisRecordObj As New frmAllowanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem138_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmBonusReport") = False Then
            Dim AnalysisRecordObj As New frmBonusReport

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem139_Click(sender As Object, e As EventArgs)
        'If ChildWindowOpen("frmEOBIReports") = False Then
        '    Dim AnalysisRecordObj As New frmEOBIReports

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub ToolStripMenuItem140_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmAnnualLeavesReports") = False Then
            Dim AnalysisRecordObj As New frmAnnualLeavesReports
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem141_Click(sender As Object, e As EventArgs)
        'If ChildWindowOpen("frmOverTimeReports") = False Then
        '    Dim AnalysisRecordObj As New frmOverTimeReports

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub ToolStripMenuItem142_Click(sender As Object, e As EventArgs)
        'If ChildWindowOpen("frmTerminatedEmpFilter") = False Then
        '    Dim AnalysisRecordObj As New frmTerminatedEmpFilter

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub ToolStripMenuItem144_Click(sender As Object, e As EventArgs)
        'If ChildWindowOpen("frmSalaryAnalysisReports") = False Then
        '    Dim AnalysisRecordObj As New frmSalaryAnalysisReports

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub ToolStripMenuItem145_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmOtherReports") = False Then
            Dim AnalysisRecordObj As New frmOtherReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoAttendenceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutoAttendenceToolStripMenuItem1.Click

        If ChildWindowOpen("frmAutoAttendence") = False Then
            Dim AnalysisRecordObj As New frmAutoAttendence

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAutoAttendence") = False Then
            Dim AnalysisRecordObj As New frmAutoAttendence

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AttendenceErrorReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AttendenceErrorReportsToolStripMenuItem1.Click

        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub FullAttendenceReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FullAttendenceReportsToolStripMenuItem1.Click


        If ChildWindowOpen("frmLeavesPR") = False Then
            Dim AnalysisRecordObj As New frmLeavesPR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem35_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    'Private Sub ToolStripMenuItem36_Click(sender As Object, e As EventArgs)
    '    If ChildWindowOpen("frmHRMLeaveReports") = False Then
    '        Dim AnalysisRecordObj As New frmHRMLeaveReports

    '        AnalysisRecordObj.MdiParent = Me
    '        AnalysisRecordObj.WindowState = FormWindowState.Maximized
    '        AnalysisRecordObj.Show()
    '    End If
    'End Sub

    Private Sub OverTimeReportsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OverTimeReportsToolStripMenuItem2.Click

        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem173_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmExtraOTCalculation") = False Then
            Dim AnalysisRecordObj As New frmExtraOTCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem174_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem174.Click
        If ChildWindowOpen("frmUndoTermination") = False Then
            Dim AnalysisRecordObj As New frmUndoTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem64_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem64.Click
        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem65_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem65.Click
        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem67_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem67.Click
        If ChildWindowOpen("frmSalaryReports") = False Then
            Dim AnalysisRecordObj As New frmSalaryReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem68_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem68.Click
        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim AnalysisRecordObj As New frmAdvanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem69_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem69.Click
        If ChildWindowOpen("frmAllowanceReports") = False Then
            Dim AnalysisRecordObj As New frmAllowanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem70_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem70.Click
        If ChildWindowOpen("frmBonusReport") = False Then
            Dim AnalysisRecordObj As New frmBonusReport

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem78_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem78.Click
        If ChildWindowOpen("frmOtherReports") = False Then
            Dim AnalysisRecordObj As New frmOtherReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub



    Private Sub ShiftToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShiftToolStripMenuItem1.Click
        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem63_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem63.Click
        If ChildWindowOpen("RptDepartRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptDepartRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem80_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAdvance") = False Then
            Dim AnalysisRecordObj As New frmAdvance
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem81_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmAccAnnualLeaveTransactions") = False Then
            Dim AnalysisRecordObj As New frmAccAnnualLeaveTransactions
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem82_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmDeductions") = False Then
            Dim AnalysisRecordObj As New frmDeductions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem83_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("SalaryManagnment") = False Then
            Dim frmChngPswdObj1115 As New SalaryManagnment

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem84_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmSalaryTransactions") = False Then
            Dim AnalysisRecordObj As New frmSalaryTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem172_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem172.Click

        If ChildWindowOpen("frmEmpTermination") = False Then
            Dim AnalysisRecordObj As New frmEmpTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem87_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmUndoTermination") = False Then
            Dim AnalysisRecordObj As New frmUndoTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoPermanentAdvanceDeductionsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem95_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem95.Click
        If ChildWindowOpen("frmEmpManagment") = False Then
            Dim frmEmployee As New frmEmpManagment
            frmEmployee.MdiParent = Me
            frmEmployee.WindowState = FormWindowState.Maximized
            frmEmployee.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If ChildWindowOpen("App Authourity ") = False Then
            Dim AnalysisRecordObj As New App_Authourity

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        If ChildWindowOpen("Emp_Bank_info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Bank_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem20_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem20.Click
        If ChildWindowOpen("Emp_Branch_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Branch_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem21_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem21.Click
        If ChildWindowOpen("emp_card_info") = False Then
            Dim frmChngPswdObj1115 As New emp_card_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem22_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem22.Click
        If ChildWindowOpen("Emp_dept_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_dept_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem23_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem23.Click
        If ChildWindowOpen("Emp_Designation_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Designation_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem25_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem25.Click
        If ChildWindowOpen("Emp_Employment_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Employment_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem24_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem24.Click
        If ChildWindowOpen("Employee_catagory") = False Then
            Dim frmChngPswdObj1115 As New Employee_catagory
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem96_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem96.Click
        If ChildWindowOpen("Emp_Grade_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Grade_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem97_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem97.Click
        If ChildWindowOpen("Emp_JobType_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_JobType_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem98_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem98.Click
        If ChildWindowOpen("Emp_Leaving_Reason") = False Then
            Dim frmChngPswdObj1115 As New Emp_Leaving_Reason
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem99_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem99.Click
        If ChildWindowOpen("Employee_Notice") = False Then
            Dim frmChngPswdObj1115 As New Employee_Notice

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem100_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem100.Click
        If ChildWindowOpen("Emp_Qualfication_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Qualfication_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem101_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem101.Click
        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem119_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem119.Click
        If ChildWindowOpen("RptemployeeRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptemployeeRecord
            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem120_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem120.Click
        If ChildWindowOpen("RptDepartRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptDepartRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem121_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem121.Click
        If ChildWindowOpen("DateWiseFrm ") = False Then
            Dim AnalysisRecordObj As New DateWiseFrm

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem123_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem123.Click
        If ChildWindowOpen("MiscRecord") = False Then
            Dim frmChngPswdObj1115 As New MiscRecord
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        If ChildWindowOpen("frmAutoAttendence") = False Then
            Dim AnalysisRecordObj As New frmAutoAttendence

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click

        If ChildWindowOpen("frmPayrollManagment") = False Then
            Dim AnalysisRecordObj As New frmPayrollManagment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem17_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        If ChildWindowOpen("frmHolidays") = False Then
            Dim AnalysisRecordObj As New frmHolidays

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem18_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem18.Click
        If ChildWindowOpen("frmAttDevice") = False Then
            Dim AnalysisRecordObj As New frmAttDevice

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem19_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem19.Click
        If ChildWindowOpen("frmAttAcessToDB") = False Then
            Dim AnalysisRecordObj As New frmAttAcessToDB

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem27_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem27.Click
        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem31_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem31.Click
        If ChildWindowOpen("frmAutoOTEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoOTEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem32_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem32.Click
        If ChildWindowOpen("frmAutoAttEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoAttEmpEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem33_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem33.Click
        If ChildWindowOpen("frmAutoLeaves") = False Then
            Dim AnalysisRecordObj As New frmAutoLeaves

            AnalysisRecordObj.MdiParent = Me
            'AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub



    Private Sub ToolStripMenuItem34_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info

            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem36_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem36.Click
        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem37_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem37.Click
        If ChildWindowOpen("frmLeavesPR") = False Then
            Dim AnalysisRecordObj As New frmLeavesPR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem102_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem102.Click
        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub BonusCalculationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BonusCalculationToolStripMenuItem.Click
        If ChildWindowOpen("frmBonus") = False Then
            Dim AnalysisRecordObj As New frmBonus

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem34_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem34.Click

        If ChildWindowOpen("frmAccAnnualLeaveTransactions") = False Then
            Dim AnalysisRecordObj As New frmAccAnnualLeaveTransactions
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem103_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem103.Click
        If ChildWindowOpen("frmExtraOTCalculation") = False Then
            Dim AnalysisRecordObj As New frmExtraOTCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem79_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem79.Click
        If ChildWindowOpen("frmAutoSalCalculation") = False Then
            Dim AnalysisRecordObj As New frmAutoSalCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem80_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem80.Click
        If ChildWindowOpen("frmMonthlySalary") = False Then
            Dim AnalysisRecordObj As New frmMonthlySalary

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem84_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem84.Click
        If ChildWindowOpen("frmExtraOTCalculation") = False Then
            Dim AnalysisRecordObj As New frmExtraOTCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem83_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem83.Click
        If ChildWindowOpen("frmAccAnnualLeaveTransactions") = False Then
            Dim AnalysisRecordObj As New frmAccAnnualLeaveTransactions
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem81_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem81.Click
        If ChildWindowOpen("frmSalaryAdjustment") = False Then
            Dim AnalysisRecordObj As New frmSalaryAdjustment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem86_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem86.Click
        If ChildWindowOpen("frmAdvance") = False Then
            Dim AnalysisRecordObj As New frmAdvance
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem87_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem87.Click
        If ChildWindowOpen("frmDeductions") = False Then
            Dim AnalysisRecordObj As New frmDeductions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem88_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem88.Click
        If ChildWindowOpen("SalaryManagnment") = False Then
            Dim frmChngPswdObj1115 As New SalaryManagnment

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem89_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem89.Click
        If ChildWindowOpen("frmSalaryTransactions") = False Then
            Dim AnalysisRecordObj As New frmSalaryTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem90_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem90.Click
        If ChildWindowOpen("frmEmpTermination") = False Then
            Dim AnalysisRecordObj As New frmEmpTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem91_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem91.Click
        If ChildWindowOpen("frmUndoTermination") = False Then
            Dim AnalysisRecordObj As New frmUndoTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem109_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem111_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem111.Click
        If ChildWindowOpen("frmOtherReports") = False Then
            Dim AnalysisRecordObj As New frmOtherReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem109_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem109.Click
        If ChildWindowOpen("frmOverTimeAcc") = False Then
            Dim AnalysisRecordObj As New frmOverTimeAcc

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If

        'If ChildWindowOpen("frmOverTimeReports") = False Then
        '    Dim AnalysisRecordObj As New frmOverTimeReports

        '    AnalysisRecordObj.MdiParent = Me
        '    AnalysisRecordObj.WindowState = FormWindowState.Maximized
        '    AnalysisRecordObj.Show()
        'End If
    End Sub

    Private Sub ToolStripMenuItem108_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem108.Click
        If ChildWindowOpen("frmAnnualLeavesReports") = False Then
            Dim AnalysisRecordObj As New frmAnnualLeavesReports
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem106_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem106.Click
        If ChildWindowOpen("frmBonusReport") = False Then
            Dim AnalysisRecordObj As New frmBonusReport

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem105_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem105.Click
        If ChildWindowOpen("frmAllowanceReports") = False Then
            Dim AnalysisRecordObj As New frmAllowanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem104_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem104.Click
        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim AnalysisRecordObj As New frmAdvanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem93_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem93.Click
        If ChildWindowOpen("frmSalaryReports") = False Then
            Dim AnalysisRecordObj As New frmSalaryReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) 

    End Sub

    Private Sub EmployeeTerminationToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles EmployeeTerminationToolStripMenuItem1.Click
        If ChildWindowOpen("frmEmpTermination") = False Then
            Dim AnalysisRecordObj As New frmEmpTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EmployeeTerminationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeTerminationToolStripMenuItem.Click
        If ChildWindowOpen("frmEmpTermination") = False Then
            Dim AnalysisRecordObj As New frmEmpTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub





    Private Sub AttendanceExcelToDBTransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceExcelToDBTransferToolStripMenuItem.Click
        If ChildWindowOpen("frmExcelAttendanceUploading") = False Then
            Dim AnalysisRecordObj As New CanteenAttendanceUploading

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem112_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem112.Click
        If ChildWindowOpen("frmExcelAttendanceUploading") = False Then
            Dim AnalysisRecordObj As New CanteenAttendanceUploading

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AttendenceCorrectionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AttendenceCorrectionToolStripMenuItem1.Click
        If ChildWindowOpen("frmAttCorrection") = False Then
            Dim AnalysisRecordObj As New frmAttCorrection

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AttendenceCorrectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendenceCorrectionToolStripMenuItem.Click
        If ChildWindowOpen("frmAttCorrection") = False Then
            Dim AnalysisRecordObj As New frmAttCorrection

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem114_Click(sender As Object, e As EventArgs) 
        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem115_Click_1(sender As Object, e As EventArgs) 
        If ChildWindowOpen("frmLeavesPR") = False Then
            Dim AnalysisRecordObj As New frmLeavesPR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem116_Click_1(sender As Object, e As EventArgs) 
        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem126_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem126.Click
        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem125_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem125.Click
        If ChildWindowOpen("frmLeavesPR") = False Then
            Dim AnalysisRecordObj As New frmLeavesPR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem124_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem124.Click
        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem127_Click_1(sender As Object, e As EventArgs) 
        If ChildWindowOpen("DateWiseFrm ") = False Then
            Dim AnalysisRecordObj As New DateWiseFrm

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem128_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem128.Click
        If ChildWindowOpen("frmEmpDataToExcel ") = False Then
            Dim AnalysisRecordObj As New frmEmpDataToExcel

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ManualMealAttendenceToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManualMealAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualMealAttendanceToolStripMenuItem.Click
        If ChildWindowOpen("frmEmpMealAtt ") = False Then
            Dim AnalysisRecordObj As New frmEmpMealAtt

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem129_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem129.Click
        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim AnalysisRecordObj As New frmAdvanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub









    Private Sub ToolStripMenuItem107_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem107.Click
        If ChildWindowOpen("SalaryManagnment") = False Then
            Dim frmChngPswdObj1115 As New SalaryManagnment

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AttendanceAccessToDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceAccessToDBToolStripMenuItem.Click
        If ChildWindowOpen("frmCanteenAttAcessToDB") = False Then
            Dim frmChngPswdObj1115 As New frmCanteenAttAcessToDB

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub CanteenAttendanceExcelToDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanteenAttendanceExcelToDBToolStripMenuItem.Click
        'If ChildWindowOpen("frmCanteenAttendanceUploading") = False Then
        '    Dim frmChngPswdObj1115 As New frmCanteenAttendanceUploading

        '    frmChngPswdObj1115.MdiParent = Me
        '    frmChngPswdObj1115.WindowState = FormWindowState.Maximized
        '    frmChngPswdObj1115.Show()
        'End If

        If ChildWindowOpen("frmCanteenAttendanceUploadingBarCode") = False Then
            Dim FrmEmpEvalObj1 As New frmCanteenAttendanceUploadingBarCode
            FrmEmpEvalObj1.MdiParent = Me
            FrmEmpEvalObj1.WindowState = FormWindowState.Maximized
            FrmEmpEvalObj1.Show()
        End If
    End Sub

    Private Sub ManagementBoofeAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManagementBoofeAttendanceToolStripMenuItem.Click
        If ChildWindowOpen("frmBoofeMealAttendance") = False Then
            Dim frmChngPswdObj1115 As New frmBoofeMealAttendance

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem127_Click_2(sender As Object, e As EventArgs) Handles ToolStripMenuItem127.Click
        If ChildWindowOpen("frmEmpMealAtt ") = False Then
            Dim AnalysisRecordObj As New frmEmpMealAtt

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem130_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem130.Click
        If ChildWindowOpen("frmCanteenAttAcessToDB") = False Then
            Dim frmChngPswdObj1115 As New frmCanteenAttAcessToDB

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem131_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem131.Click
        If ChildWindowOpen("frmCanteenAttendanceUploading") = False Then
            Dim frmChngPswdObj1115 As New frmCanteenAttendanceUploading

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem135_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem135.Click
        If ChildWindowOpen("frmBoofeMealAttendance") = False Then
            Dim frmChngPswdObj1115 As New frmBoofeMealAttendance

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem132_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem132.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem133_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem133.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
            CanteenMenu.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem134_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem134.Click
        Me.Close()
    End Sub

    Private Sub CanteenMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles CanteenMenu.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem44_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem44.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
            AuditMenu.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem43_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem43.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub EmployeesReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("RptDepartRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptDepartRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem45_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem45.Click
        Me.Close()
    End Sub

    Private Sub AttendanceReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub OvertimeReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub GradeManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradeManagementToolStripMenuItem.Click
        If ChildWindowOpen("frmGradeUpG") = False Then
            Dim AnalysisRecordObj As New frmGradeUpG1

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub SalaryUpgradeManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryUpgradeManagementToolStripMenuItem.Click
        If ChildWindowOpen("frmSalaryUpgrade") = False Then
            Dim AnalysisRecordObj As New frmSalaryUpgrade

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ReportsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem2.Click
        If ChildWindowOpen("CanteenRepots") = False Then
            Dim AnalysisRecordObj As New CanteenRepots

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub CanteenReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanteenReportsToolStripMenuItem.Click
        If ChildWindowOpen("CanteenRepots") = False Then
            Dim AnalysisRecordObj As New CanteenRepots

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AttendenceCorrectionReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendenceCorrectionReportsToolStripMenuItem.Click
        If ChildWindowOpen("AttCorr") = False Then
            Dim AnalysisRecordObj As New frmAttCorr

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem71_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem71.Click
        If ChildWindowOpen("AttCorr") = False Then
            Dim AnalysisRecordObj As New frmAttCorr

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub SepcialCardPrintingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SepcialCardPrintingToolStripMenuItem.Click
        If ChildWindowOpen("cardprinting") = False Then
            Dim AnalysisRecordObj As New cardprinting

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EmployeeDataExportToExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeDataExportToExcelToolStripMenuItem.Click
        If ChildWindowOpen("frmEmpDataToExcel") = False Then
            Dim AnalysisRecordObj As New frmEmpDataToExcel

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub



    Private Sub ShiftManagementToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ShiftManagementToolStripMenuItem.Click
        If ChildWindowOpen("frmShiftUpgrade") = False Then
            Dim AnalysisRecordObj As New frmShiftUpgrade

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem74_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem74.Click
        If ChildWindowOpen("frmShiftUpgrade") = False Then
            Dim AnalysisRecordObj As New frmShiftUpgrade

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem76_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem76.Click
        If ChildWindowOpen("HRAllowance") = False Then
            Dim AnalysisRecordObj As New HRAllowance

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem75_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem75.Click
        If ChildWindowOpen("HRAllowance") = False Then
            Dim AnalysisRecordObj As New HRAllowance

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub IncentiveManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncentiveManagementToolStripMenuItem.Click
        If ChildWindowOpen("frmInenstive") = False Then
            Dim AnalysisRecordObj As New frmInenstive

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem77_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem77.Click
        If ChildWindowOpen("frmInenstive") = False Then
            Dim AnalysisRecordObj As New frmInenstive

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem46_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmBonusReport") = False Then
            Dim AnalysisRecordObj As New frmBonusReport

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem113_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem113.Click
        If ChildWindowOpen("frmEmpDataToExcel") = False Then
            Dim AnalysisRecordObj As New frmEmpDataToExcel

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem114_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem114.Click
        If ChildWindowOpen("frmEmpDataToExcel") = False Then
            Dim AnalysisRecordObj As New frmEmpDataToExcel

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem39_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem39.Click
        If ChildWindowOpen("RptemployeeRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptemployeeRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem46_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem46.Click
        If ChildWindowOpen("RptDepartRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptDepartRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem41_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem41.Click
        If ChildWindowOpen("DateWiseFrm ") = False Then
            Dim AnalysisRecordObj As New DateWiseFrm

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem42_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem42.Click
        If ChildWindowOpen("HRAllowance") = False Then
            Dim AnalysisRecordObj As New HRAllowance

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem40_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem40.Click
        If ChildWindowOpen("MiscRecord") = False Then
            Dim frmChngPswdObj1115 As New MiscRecord
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem56_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem56.Click

        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem57_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem57.Click
        If ChildWindowOpen("frmLeavesPR") = False Then
            Dim AnalysisRecordObj As New frmLeavesPR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem58_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem58.Click
        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem59_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmEmpDataToExcel") = False Then
            Dim AnalysisRecordObj As New frmEmpDataToExcel

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem60_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem60.Click
        If ChildWindowOpen("AttCorr") = False Then
            Dim AnalysisRecordObj As New frmAttCorr

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem136_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem136.Click
        If ChildWindowOpen("frmSalaryReports") = False Then
            Dim AnalysisRecordObj As New frmSalaryReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem138_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem138.Click
        If ChildWindowOpen("frmAllowanceReports") = False Then
            Dim AnalysisRecordObj As New frmAllowanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem137_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem137.Click
        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim AnalysisRecordObj As New frmAdvanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem139_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem139.Click
        If ChildWindowOpen("frmBonusReport") = False Then
            Dim AnalysisRecordObj As New frmBonusReport

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem141_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem141.Click
        If ChildWindowOpen("frmAnnualLeavesReports") = False Then
            Dim AnalysisRecordObj As New frmAnnualLeavesReports
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem142_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem142.Click
        If ChildWindowOpen("frmOverTimeAcc") = False Then
            Dim AnalysisRecordObj As New frmOverTimeAcc

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem144_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem144.Click
        If ChildWindowOpen("frmOtherReports") = False Then
            Dim AnalysisRecordObj As New frmOtherReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        If ChildWindowOpen("CanteenRepots") = False Then
            Dim AnalysisRecordObj As New CanteenRepots

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem143_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem143.Click
        If ChildWindowOpen("Emp_Bank_info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Bank_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub BanksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BanksToolStripMenuItem.Click
        If ChildWindowOpen("Emp_Bank_info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Bank_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem59_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem59.Click
        If ChildWindowOpen("frmUndoTermination") = False Then
            Dim AnalysisRecordObj As New frmUndoTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem150_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem150.Click
        If ChildWindowOpen("RptemployeeRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptemployeeRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem151_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem151.Click
        If ChildWindowOpen("RptDepartRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptDepartRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem152_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem152.Click
        If ChildWindowOpen("DateWiseFrm ") = False Then
            Dim AnalysisRecordObj As New DateWiseFrm

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If

    End Sub

    Private Sub ToolStripMenuItem153_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem153.Click
        If ChildWindowOpen("HRAllowance") = False Then
            Dim AnalysisRecordObj As New HRAllowance

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem154_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem154.Click
        If ChildWindowOpen("MiscRecord") = False Then
            Dim frmChngPswdObj1115 As New MiscRecord
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem146_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem146.Click
        changepwd_Click(Nothing, Nothing)
    End Sub

    Private Sub ToolStripMenuItem147_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem147.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
            HRMenu.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem148_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem148.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem171_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem171.Click
        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem173_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem173.Click
        If ChildWindowOpen("frmLeavesPR") = False Then
            Dim AnalysisRecordObj As New frmLeavesPR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub OverTimeReportsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OverTimeReportsToolStripMenuItem.Click

        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem156_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem156.Click
        If ChildWindowOpen("frmEmpManagment") = False Then
            Dim frmEmployee As New frmEmpManagment
            frmEmployee.MdiParent = Me
            frmEmployee.WindowState = FormWindowState.Maximized
            frmEmployee.Show()
        End If
    End Sub

    Private Sub IncentiveReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncentiveReportsToolStripMenuItem.Click
        If ChildWindowOpen("InCentive") = False Then
            Dim frmEmployee As New InCentive

            frmEmployee.MdiParent = Me
            frmEmployee.WindowState = FormWindowState.Maximized
            frmEmployee.Show()
        End If
    End Sub

    Private Sub IncentiveReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IncentiveReportsToolStripMenuItem1.Click
        If ChildWindowOpen("InCentive") = False Then
            Dim frmEmployee As New InCentive

            frmEmployee.MdiParent = Me
            frmEmployee.WindowState = FormWindowState.Maximized
            frmEmployee.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem82_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem82.Click
        If ChildWindowOpen("frmBonus") = False Then
            Dim AnalysisRecordObj As New frmBonus

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EOBIReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EOBIReportsToolStripMenuItem.Click

        If ChildWindowOpen("EOBIReports") = False Then
            Dim AnalysisRecordObj As New EOBIReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ContractualInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Contractual") = False Then
            Dim AnalysisRecordObj As New Contractual

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem160_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem160.Click
        If ChildWindowOpen("Contractual") = False Then
            Dim AnalysisRecordObj As New Contractual

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub COntractualReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("Contractualinfo") = False Then
            Dim AnalysisRecordObj As New Contractualinfo

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ContractualInformationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmContManagment") = False Then
            Dim AnalysisRecordObj As New frmContManagment


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem161_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem161.Click
        If ChildWindowOpen("frmContManagment") = False Then
            Dim AnalysisRecordObj As New frmContManagment


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem162_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem162.Click
        If ChildWindowOpen("Contractualinfo") = False Then
            Dim AnalysisRecordObj As New Contractualinfo

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem190_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem190.Click
        If ChildWindowOpen("frmContManagment") = False Then
            Dim AnalysisRecordObj As New frmContManagment


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem168_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem168.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem169_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem169.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem175_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem175.Click
        Me.Close()

    End Sub

    Private Sub ToolStripMenuItem177_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem177.Click
        If ChildWindowOpen("Contractual") = False Then
            Dim AnalysisRecordObj As New Contractual

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub PayRollManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayRollManagementToolStripMenuItem.Click
        If ChildWindowOpen("frmConPayrollManagment") = False Then
            Dim AnalysisRecordObj As New frmConPayrollManagment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem178_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem178.Click
        If ChildWindowOpen("frmConAttAcessToDB") = False Then
            Dim AnalysisRecordObj As New frmConAttAcessToDB

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem179_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem179.Click
        If ChildWindowOpen("frmConAttCorrection") = False Then
            Dim AnalysisRecordObj As New frmConAttCorrection

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem180_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem180.Click
        If ChildWindowOpen("Contractualinfo") = False Then
            Dim AnalysisRecordObj As New Contractualinfo

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem182_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem182.Click
        If ChildWindowOpen("frmContManagment") = False Then
            Dim AnalysisRecordObj As New frmContManagment


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem183_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem183.Click
        If ChildWindowOpen("Contractual") = False Then
            Dim AnalysisRecordObj As New Contractual

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem184_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem184.Click
        If ChildWindowOpen("frmConPayrollManagment") = False Then
            Dim AnalysisRecordObj As New frmConPayrollManagment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem185_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem185.Click
        If ChildWindowOpen("frmConAttAcessToDB") = False Then
            Dim AnalysisRecordObj As New frmConAttAcessToDB

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem186_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem186.Click
        If ChildWindowOpen("frmConAttCorrection") = False Then
            Dim AnalysisRecordObj As New frmConAttCorrection

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem187_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem187.Click
        If ChildWindowOpen("Contractualinfo") = False Then
            Dim AnalysisRecordObj As New Contractualinfo

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem189_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem189.Click
        If ChildWindowOpen("frmContManagment") = False Then
            Dim AnalysisRecordObj As New frmContManagment


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem191_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem191.Click
        If ChildWindowOpen("Contractual") = False Then
            Dim AnalysisRecordObj As New Contractual

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem195_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem195.Click
        If ChildWindowOpen("Contractualinfo") = False Then
            Dim AnalysisRecordObj As New Contractualinfo

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ContractualPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContractualPaymentToolStripMenuItem.Click
        If ChildWindowOpen("frmContPayment") = False Then
            Dim AnalysisRecordObj As New frmContPayment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem192_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem192.Click
        If ChildWindowOpen("frmContPayment") = False Then
            Dim AnalysisRecordObj As New frmContPayment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EvoluvationEmailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvoluvationEmailToolStripMenuItem.Click
        If ChildWindowOpen("EvoEmail") = False Then
            Dim AnalysisRecordObj As New EvoEmail

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoAttendanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutoAttendanceToolStripMenuItem1.Click

        If ChildWindowOpen("frmAutoAttConnEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoAttConnEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoAttendanceToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AutoAttendanceToolStripMenuItem2.Click
        If ChildWindowOpen("frmAutoAttConnEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoAttConnEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub VisitorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitorsToolStripMenuItem.Click
        If ChildWindowOpen("frmGateVisitors") = False Then
            Dim AnalysisRecordObj As New frmGateVisitors


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            'frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        logout()
        If ChildWindowOpen("frmLogin") = False Then     'For MainMenu
            Dim login As New frmLogin
            login.MdiParent = Me
            login.Show()
        End If
    End Sub

    Private Sub VisitorsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles VisitorsToolStripMenuItem2.Click
        If ChildWindowOpen("frmGateVisitors") = False Then
            Dim AnalysisRecordObj As New frmGateVisitors


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem193_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem193.Click

        If ChildWindowOpen("VisitiorsReports") = False Then
            Dim AnalysisRecordObj As New VisitiorsReports


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ReportsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem3.Click
        If ChildWindowOpen("VisitiorsReports") = False Then
            Dim AnalysisRecordObj As New VisitiorsReports


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub CompnayProfileToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("CompanyInfo") = False Then
            Dim frmChngPswdObj1115 As New CompanyInfo
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("FrmUserMgt") = False Then
            Dim frmChngPswdObj1115 As New FrmUserMgt
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem196_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem196.Click
        logout()
    End Sub

    Private Sub ToolStripMenuItem197_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem197.Click
        Me.Close()

    End Sub

    Private Sub EmployeeManagementToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeeManagementToolStripMenuItem1.Click
        If ChildWindowOpen("frmEmpManagment") = False Then
            Dim frmEmployee As New frmEmpManagment
            frmEmployee.MdiParent = Me
            frmEmployee.WindowState = FormWindowState.Maximized
            frmEmployee.Show()
        End If
    End Sub

    Private Sub EmployeeTerminationToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EmployeeTerminationToolStripMenuItem2.Click
        If ChildWindowOpen("frmEmpTermination") = False Then
            Dim AnalysisRecordObj As New frmEmpTermination
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub SalaryIncrementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryIncrementToolStripMenuItem.Click
        If ChildWindowOpen("frmSalaryUpgrade") = False Then
            Dim AnalysisRecordObj As New frmSalaryUpgrade
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub GradeUpgradeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradeUpgradeToolStripMenuItem.Click
        If ChildWindowOpen("frmGradeUpG") = False Then
            Dim AnalysisRecordObj As New frmGradeUpG1
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem219_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem219.Click
        If ChildWindowOpen("frmUndoTermination") = False Then
            Dim AnalysisRecordObj As New frmUndoTermination
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem199_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem199.Click
        If ChildWindowOpen("App Authourity ") = False Then
            Dim AnalysisRecordObj As New App_Authourity

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem200_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem200.Click
        If ChildWindowOpen("Emp_Bank_info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Bank_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem201_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem201.Click
        If ChildWindowOpen("Emp_Branch_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Branch_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem202_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem202.Click
        If ChildWindowOpen("emp_card_info") = False Then
            Dim frmChngPswdObj1115 As New emp_card_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem203_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem203.Click
        If ChildWindowOpen("Emp_dept_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_dept_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem204_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem204.Click
        If ChildWindowOpen("Emp_Designation_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Designation_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem205_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem205.Click
        If ChildWindowOpen("Employee_catagory") = False Then
            Dim frmChngPswdObj1115 As New Employee_catagory
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem206_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem206.Click
        If ChildWindowOpen("Emp_Employment_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Employment_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem207_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem207.Click
        If ChildWindowOpen("Emp_Grade_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Grade_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem208_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem208.Click
        If ChildWindowOpen("Emp_JobType_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_JobType_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem209_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem209.Click
        If ChildWindowOpen("Emp_Leaving_Reason") = False Then
            Dim frmChngPswdObj1115 As New Emp_Leaving_Reason
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem210_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem210.Click
        If ChildWindowOpen("Employee_Notice") = False Then
            Dim frmChngPswdObj1115 As New Employee_Notice
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem211_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem211.Click
        If ChildWindowOpen("Emp_Qualfication_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Qualfication_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem212_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem212.Click
        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem214_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem214.Click
        If ChildWindowOpen("RptemployeeRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptemployeeRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem215_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem215.Click
        If ChildWindowOpen("RptDepartRecord ") = False Then
            Dim fRptemployeeRecordObj As New RptDepartRecord

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem216_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem216.Click
        If ChildWindowOpen("DateWiseFrm ") = False Then
            Dim fRptemployeeRecordObj As New DateWiseFrm

            fRptemployeeRecordObj.MdiParent = Me
            fRptemployeeRecordObj.WindowState = FormWindowState.Maximized
            fRptemployeeRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem217_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem217.Click
        If ChildWindowOpen("HRAllowance") = False Then
            Dim AnalysisRecordObj As New HRAllowance

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem218_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem218.Click
        If ChildWindowOpen("MiscRecord") = False Then
            Dim frmChngPswdObj1115 As New MiscRecord
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub AutoAttendanceToolStripMenuItem3_Click(sender As Object, e As EventArgs) 
        If ChildWindowOpen("frmAutoAttendence") = False Then
            Dim AnalysisRecordObj As New frmAutoAttendence

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem221_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem221.Click
        If ChildWindowOpen("frmPayrollManagment") = False Then
            Dim AnalysisRecordObj As New frmPayrollManagment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem222_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem222.Click
        If ChildWindowOpen("frmHolidays") = False Then
            Dim AnalysisRecordObj As New frmHolidays

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem223_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem223.Click
        If ChildWindowOpen("frmAttDevice") = False Then
            Dim AnalysisRecordObj As New frmAttDevice

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem224_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem224.Click
        If ChildWindowOpen("frmAttAcessToDBold") = False Then
            Dim AnalysisRecordObj As New frmAttAcessToDBOld

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem225_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem225.Click
        If ChildWindowOpen("frmAttCorrection") = False Then
            Dim AnalysisRecordObj As New frmAttCorrection

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem227_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem227.Click

        If ChildWindowOpen("frmAutoOTEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoOTEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem228_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem228.Click
        If ChildWindowOpen("frmAutoAttEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoAttEmpEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem229_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem229.Click
        If ChildWindowOpen("frmAutoLeaves") = False Then
            Dim AnalysisRecordObj As New frmAutoLeaves

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem230_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem230.Click
        If ChildWindowOpen("Emp_Shift_Info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Shift_Info

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem231_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem231.Click
        If ChildWindowOpen("frmShiftUpgrade") = False Then
            Dim AnalysisRecordObj As New frmShiftUpgrade

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem232_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem232.Click
        If ChildWindowOpen("frmInenstive") = False Then
            Dim AnalysisRecordObj As New frmInenstive

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem234_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem234.Click

        If ChildWindowOpen("frmPayRollReportSelector3") = False Then
            Dim AnalysisRecordObj As New frmPayRollReportSelector3

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem235_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem235.Click


        If ChildWindowOpen("frmLeavesPR") = False Then
            Dim AnalysisRecordObj As New frmLeavesPR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem236_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem236.Click
        If ChildWindowOpen("frmOverTimePR") = False Then
            Dim AnalysisRecordObj As New frmOverTimePR

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem238_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem238.Click
        If ChildWindowOpen("AttCorr") = False Then
            Dim AnalysisRecordObj As New frmAttCorr

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem239_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem239.Click
        If ChildWindowOpen("InCentive") = False Then
            Dim frmEmployee As New InCentive

            frmEmployee.MdiParent = Me
            frmEmployee.WindowState = FormWindowState.Maximized
            frmEmployee.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem241_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem241.Click
        If ChildWindowOpen("frmAutoSalCalculation") = False Then
            Dim AnalysisRecordObj As New frmAutoSalCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem242_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem242.Click
        If ChildWindowOpen("frmMonthlySalary") = False Then
            Dim AnalysisRecordObj As New frmMonthlySalary

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem243_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem243.Click
        If ChildWindowOpen("frmBonus") = False Then
            Dim AnalysisRecordObj As New frmBonus

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem244_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem244.Click

        If ChildWindowOpen("frmAccAnnualLeaveTransactions") = False Then
            Dim AnalysisRecordObj As New frmAccAnnualLeaveTransactions
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem245_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem245.Click
        If ChildWindowOpen("frmExtraOTCalculation") = False Then
            Dim AnalysisRecordObj As New frmExtraOTCalculation

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem246_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem246.Click
        If ChildWindowOpen("frmSalaryAdjustment") = False Then
            Dim AnalysisRecordObj As New frmSalaryAdjustment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem248_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("SalaryManagnment") = False Then
            Dim frmChngPswdObj1115 As New SalaryManagnment

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem249_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem250_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmDeductions") = False Then
            Dim AnalysisRecordObj As New frmDeductions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem251_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmSalaryTransactions") = False Then
            Dim AnalysisRecordObj As New frmSalaryTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem252_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("frmEmpTermination") = False Then
            Dim AnalysisRecordObj As New frmEmpTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem253_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmUndoTermination") = False Then
            Dim AnalysisRecordObj As New frmUndoTermination

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem254_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Emp_Bank_info") = False Then
            Dim frmChngPswdObj1115 As New Emp_Bank_info
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem256_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem256.Click

        If ChildWindowOpen("frmSalaryReports") = False Then
            Dim AnalysisRecordObj As New frmSalaryReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem257_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem257.Click

        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim AnalysisRecordObj As New frmAdvanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem258_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem258.Click

        If ChildWindowOpen("frmAllowanceReports") = False Then
            Dim AnalysisRecordObj As New frmAllowanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem259_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem259.Click

        If ChildWindowOpen("frmBonusReport") = False Then
            Dim AnalysisRecordObj As New frmBonusReport

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem261_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem261.Click

        If ChildWindowOpen("frmAnnualLeavesReports") = False Then
            Dim AnalysisRecordObj As New frmAnnualLeavesReports
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem262_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem262.Click
        If ChildWindowOpen("frmOverTimeAcc") = False Then
            Dim AnalysisRecordObj As New frmOverTimeAcc

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem263_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem263.Click

        If ChildWindowOpen("frmOtherReports") = False Then
            Dim AnalysisRecordObj As New frmOtherReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem265_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem265.Click
        If ChildWindowOpen("frmEmpMealAtt ") = False Then
            Dim AnalysisRecordObj As New frmEmpMealAtt

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem266_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem266.Click
        If ChildWindowOpen("frmCanteenAttAcessToDB") = False Then
            Dim frmChngPswdObj1115 As New frmCanteenAttAcessToDB

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem267_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem267.Click
        If ChildWindowOpen("frmCanteenAttendanceUploading") = False Then
            Dim frmChngPswdObj1115 As New frmCanteenAttendanceUploading

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem268_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem268.Click
        If ChildWindowOpen("frmBoofeMealAttendance") = False Then
            Dim frmChngPswdObj1115 As New frmBoofeMealAttendance

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub VisitorsToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles VisitorsToolStripMenuItem4.Click
        If ChildWindowOpen("frmGateVisitors") = False Then
            Dim AnalysisRecordObj As New frmGateVisitors


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ReportsToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem4.Click
        If ChildWindowOpen("VisitiorsReports") = False Then
            Dim AnalysisRecordObj As New VisitiorsReports


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem271_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem271.Click
        If ChildWindowOpen("frmContManagment") = False Then
            Dim AnalysisRecordObj As New frmContManagment


            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem272_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem272.Click
        If ChildWindowOpen("Contractual") = False Then
            Dim AnalysisRecordObj As New Contractual

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem273_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem273.Click
        If ChildWindowOpen("frmConPayrollManagment") = False Then
            Dim AnalysisRecordObj As New frmConPayrollManagment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem274_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem274.Click
        If ChildWindowOpen("frmConAttAcessToDB") = False Then
            Dim AnalysisRecordObj As New frmConAttAcessToDB

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem276_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem276.Click
        If ChildWindowOpen("Contractualinfo") = False Then
            Dim AnalysisRecordObj As New Contractualinfo

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem275_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem275.Click
        If ChildWindowOpen("frmConAttCorrection") = False Then
            Dim AnalysisRecordObj As New frmConAttCorrection

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem277_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem277.Click
        If ChildWindowOpen("frmContPayment") = False Then
            Dim AnalysisRecordObj As New frmContPayment

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem278_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem278.Click
        If ChildWindowOpen("frmAutoAttConnEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoAttConnEntry

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ContractualHeadInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("Contractual") = False Then
            Dim AnalysisRecordObj As New Contractual

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EOBIReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs)

        If ChildWindowOpen("EOBIReports") = False Then
            Dim AnalysisRecordObj As New EOBIReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AllowanceReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim AnalysisRecordObj As New frmAdvanceReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub SpecialCardPrintingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ChildWindowOpen("cardprinting") = False Then
            Dim AnalysisRecordObj As New cardprinting

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem110_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem110.Click

    End Sub

    Private Sub UserManagementToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles UserManagementToolStripMenuItem2.Click
        If ChildWindowOpen("FrmUserMgt") = False Then
            Dim frmChngPswdObj1115 As New FrmUserMgt
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ComppanyProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComppanyProfileToolStripMenuItem.Click
        If ChildWindowOpen("CompanyInfo") = False Then
            Dim frmChngPswdObj1115 As New CompanyInfo
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem2.Click
        If ChildWindowOpen("change_Password") = False Then
            Dim frmChngPswdObj1115 As New change_Password
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub RestPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestPasswordToolStripMenuItem.Click
        If ChildWindowOpen("FrmReset") = False Then
            Dim frmChngPswdObj1115 As New FrmReset
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub LockUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockUsersToolStripMenuItem.Click
        If ChildWindowOpen("FrmLockUser") = False Then
            Dim frmChngPswdObj1115 As New FrmLockUser
            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem279_Click(sender As Object, e As EventArgs) 
        If ChildWindowOpen("frmAdvance") = False Then
            Dim AnalysisRecordObj As New frmAdvance
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem280_Click(sender As Object, e As EventArgs) 
        If ChildWindowOpen("frmDeductions") = False Then
            Dim AnalysisRecordObj As New frmDeductions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem281_Click(sender As Object, e As EventArgs) 
        If ChildWindowOpen("frmSalaryTransactions") = False Then
            Dim AnalysisRecordObj As New frmSalaryTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem269_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem269.Click
        If ChildWindowOpen("CanteenRepots") = False Then
            Dim AnalysisRecordObj As New CanteenRepots

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub SalaryManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryManagementToolStripMenuItem.Click
        If ChildWindowOpen("SalaryManagnment") = False Then
            Dim frmChngPswdObj1115 As New SalaryManagnment

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem279_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem279.Click
        If ChildWindowOpen("frmAdvanceReports") = False Then
            Dim frmChngPswdObj11115 As New frmAdvanceReports

            frmChngPswdObj11115.MdiParent = Me
            frmChngPswdObj11115.WindowState = FormWindowState.Maximized
            frmChngPswdObj11115.Show()
        End If
    End Sub

    Private Sub SalaryManagementToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalaryManagementToolStripMenuItem1.Click
        If ChildWindowOpen("SalaryManagnment") = False Then
            Dim frmChngPswdObj1115 As New SalaryManagnment

            frmChngPswdObj1115.MdiParent = Me
            frmChngPswdObj1115.WindowState = FormWindowState.Maximized
            frmChngPswdObj1115.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem237_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem237.Click
        If ChildWindowOpen("frmEmpDataToExcel") = False Then
            Dim AnalysisRecordObj As New frmEmpDataToExcel

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoAttendanceToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles AutoAttendanceToolStripMenuItem4.Click
        If ChildWindowOpen("frmAutoAttendence") = False Then
            Dim AnalysisRecordObj As New frmAutoAttendence

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ManageEmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageEmployeesToolStripMenuItem.Click
        If ChildWindowOpen("frmBusInfo") = False Then
            Dim objPurchaseReturn11 As New frmBusInfo
            objPurchaseReturn11.MdiParent = Me
            objPurchaseReturn11.WindowState = FormWindowState.Maximized
            objPurchaseReturn11.Show()
        End If
    End Sub

    Private Sub ManualTransportAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualTransportAttendanceToolStripMenuItem.Click
        Try     'For HRMenu
            If ChildWindowOpen("frmBusAtt") = False Then
                Dim frmChngPswdObj1 As New frmBusAtt
                frmChngPswdObj1.MdiParent = Me
                frmChngPswdObj1.WindowState = FormWindowState.Maximized
                'frmChngPswd.Location = New Point(920, 20)
                frmChngPswdObj1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AdditionalAmountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdditionalAmountToolStripMenuItem.Click
        Try     'For HRMenu
            If ChildWindowOpen("frmBusAddAmout") = False Then
                Dim frmChngPswdObj11 As New FrmBusAddAmout
                frmChngPswdObj11.MdiParent = Me
                frmChngPswdObj11.WindowState = FormWindowState.Maximized
                'frmChngPswd.L1ocation = New Point(920, 20)
                frmChngPswdObj11.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TempEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TempEntryToolStripMenuItem.Click
        Try     'For HRMenu
            If ChildWindowOpen("frmBusTempAdv") = False Then
                Dim frmChngPswdObj1111 As New frmBusTempAdv
                frmChngPswdObj1111.MdiParent = Me
                frmChngPswdObj1111.WindowState = FormWindowState.Maximized
                'frmChngPswd.L1o11cation = New Point(920, 20)
                frmChngPswdObj1111.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FineEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FineEntryToolStripMenuItem.Click
        Try     'For HRMenu
            If ChildWindowOpen("frmBusFine") = False Then
                Dim frmChngPswdObj111 As New frmBusFine
                frmChngPswdObj111.MdiParent = Me
                frmChngPswdObj111.WindowState = FormWindowState.Maximized
                'frmChngPswd.L1o1cation = New Point(920, 20)
                frmChngPswdObj111.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LeaveEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveEntryToolStripMenuItem.Click
        Try     'For HRMenu
            If ChildWindowOpen("frmBusLeaveEntry") = False Then
                Dim frmChngPswdObj111111 As New frmBusLeaveEntry
                frmChngPswdObj111111.MdiParent = Me
                frmChngPswdObj111111.WindowState = FormWindowState.Maximized
                'frmChngPswd.L1o111cation = New Point(920, 20)
                frmChngPswdObj111111.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BillCalculationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillCalculationToolStripMenuItem.Click
        Try     'For HRMenu
            If ChildWindowOpen("frmBillingTran") = False Then
                Dim frmChngPswdObj11111 As New frmBillingTran
                frmChngPswdObj11111.MdiParent = Me
                frmChngPswdObj11111.WindowState = FormWindowState.Maximized
                'frmChngPswd.L1o11cation = New Point(920, 20)
                frmChngPswdObj11111.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem226_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem226.Click
        If ChildWindowOpen("frmTransDate") = False Then
            Dim frmChngPswdObj1 As New frmTransDate
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub DriversToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DriversToolStripMenuItem.Click
        If ChildWindowOpen("frmDriver") = False Then
            Dim frmChngPswdObj1 As New frmDriver
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub VehiclesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiclesToolStripMenuItem.Click
        If ChildWindowOpen("frmVehicles") = False Then
            Dim frmChngPswdObj1 As New frmVehicles
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub DailyVehicleMovementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyVehicleMovementToolStripMenuItem.Click
        If ChildWindowOpen("frmDailyVehicleMove") = False Then
            Dim frmChngPswdObj1 As New frmDailyVehicleMove
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub VehicleDailyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleDailyReportToolStripMenuItem.Click
        If ChildWindowOpen("frmSecReports") = False Then
            Dim frmChngPswdObj1 As New frmSecReports
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub ManualTransportAttendanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ManualTransportAttendanceToolStripMenuItem1.Click
        Try     'For HRMenu
            If ChildWindowOpen("frmBusAtt") = False Then
                Dim frmChngPswdObj1 As New frmBusAtt
                frmChngPswdObj1.MdiParent = Me
                frmChngPswdObj1.WindowState = FormWindowState.Maximized
                'frmChngPswd.Location = New Point(920, 20)
                frmChngPswdObj1.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TransportReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransportReportsToolStripMenuItem.Click
        Try     'For HRMenu
            If ChildWindowOpen("frmRptTransportInfo") = False Then
                Dim frmChngPswdObj As New frmRptTransportInfo
                frmChngPswdObj.MdiParent = Me
                frmChngPswdObj.WindowState = FormWindowState.Maximized
                'frmChngPswd.Location = New Point(920, 20)
                frmChngPswdObj.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RootInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RootInfoToolStripMenuItem.Click
        If ChildWindowOpen("frmRoutesInfo") = False Then
            Dim frmChngPswdObj As New frmRoutesInfo
            frmChngPswdObj.MdiParent = Me
            frmChngPswdObj.WindowState = FormWindowState.Maximized
            'frmChngPswd.Location = New Point(920, 20)
            frmChngPswdObj.Show()
        End If
    End Sub

    Private Sub DriversToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DriversToolStripMenuItem1.Click
        If ChildWindowOpen("frmDriver") = False Then
            Dim frmChngPswdObj1 As New frmDriver
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub VehicleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehicleToolStripMenuItem.Click
        If ChildWindowOpen("frmVehicles") = False Then
            Dim frmChngPswdObj1 As New frmVehicles
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub TransactionDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionDateToolStripMenuItem.Click
        If ChildWindowOpen("frmTransDate") = False Then
            Dim frmChngPswdObj1 As New frmTransDate
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub DailyVehicleMovementToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DailyVehicleMovementToolStripMenuItem1.Click
        If ChildWindowOpen("frmDailyVehicleMove") = False Then
            Dim frmChngPswdObj1 As New frmDailyVehicleMove
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub







    Private Sub GrievanceCatagoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GrievanceCatagoryToolStripMenuItem1.Click
        If ChildWindowOpen("frmGrievanceCategory") = False Then
            Dim frmChngPswdObj1 As New frmGrievanceCategory
            frmChngPswdObj1.MdiParent = Me
            'frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub GrievanceManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrievanceManagementToolStripMenuItem.Click

        If ChildWindowOpen("EmployeeGrievanceSystem") = False Then
            Dim frmChngPswdObj1 As New EmployeeGrievanceSystem
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem282_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub ToolStripMenuItem281_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem281.Click
        If ChildWindowOpen("FrmSupplier") = False Then
            Dim frmChngPswdObj1 As New FrmSupplier
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem282_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem282.Click
        If ChildWindowOpen("FrmShopitems") = False Then
            Dim frmChngPswdObj1 As New FrmShopitems
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub TransactionINToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransactionINToolStripMenuItem1.Click
        If ChildWindowOpen("frmTranSactionIN") = False Then
            Dim frmChngPswdObj1 As New frmTranSactionIN
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub AdvanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AdvanceToolStripMenuItem1.Click
        If ChildWindowOpen("frmAdvance") = False Then
            Dim AnalysisRecordObj As New frmAdvance
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub DedicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DedicationToolStripMenuItem.Click
        If ChildWindowOpen("frmDeductions") = False Then
            Dim AnalysisRecordObj As New frmDeductions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryToolStripMenuItem.Click

        If ChildWindowOpen("frmSalaryTransactions") = False Then
            Dim AnalysisRecordObj As New frmSalaryTransactions

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub TransactionOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionOutToolStripMenuItem.Click
        If ChildWindowOpen("FrmTransactionOut") = False Then
            Dim AnalysisRecordObj As New FrmTransactionOut

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ReportsToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem9.Click
        If ChildWindowOpen("FrmShopReports") = False Then
            Dim AnalysisRecordObj As New FrmShopReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem360_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem360.Click
        If ChildWindowOpen("frmMadication") = False Then
            Dim frmChngPswdObj1 As New frmMadication
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem364_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem364.Click
        If ChildWindowOpen("frmMadicationRecord1") = False Then
            Dim frmChngPswdObj1 As New frmMadicationRecord1
            frmChngPswdObj1.MdiParent = Me
            frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub MedicinesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicinesToolStripMenuItem.Click
        If ChildWindowOpen("Newmaterial") = False Then
            Dim AnalysisRecordObj As New Newmaterial

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub MedicationINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicationINToolStripMenuItem.Click
        If ChildWindowOpen("frmMadicationIN") = False Then
            Dim AnalysisRecordObj As New frmMadicationIN

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub PharmaceuticalCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PharmaceuticalCompanyToolStripMenuItem.Click
        If ChildWindowOpen("FrmFormacy") = False Then
            Dim frmChngPswdObj1 As New FrmFormacy
            frmChngPswdObj1.MdiParent = Me
            'frmChngPswdObj1.WindowState = FormWindowState.Maximized
            frmChngPswdObj1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem247_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem247.Click
        If ChildWindowOpen("mediReports") = False Then
            Dim AnalysisRecordObj As New mediReports

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub BonusReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BonusReportsToolStripMenuItem1.Click
        If ChildWindowOpen("frmBonusReport") = False Then
            Dim AnalysisRecordObj As New frmBonusReport

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub
    Private Sub ToolStripMenuItem365_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem365.Click

        If ChildWindowOpen("FrmShopReports") = False Then
            Dim AnalysisRecordObj As New EmployeeEvaluationForm

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem366_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem366.Click
        If ChildWindowOpen("frmSelfAssessment") = False Then
            Dim Obj As New frmSelfAssessment
            Obj.MdiParent = Me
            Obj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem371_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem371.Click
        If ChildWindowOpen("FrmEmpEval") = False Then
            Dim FrmEmpEvalObj As New FrmEmpEval()
            FrmEmpEvalObj.MdiParent = Me
            FrmEmpEvalObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem373_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem373.Click
        If ChildWindowOpen("frmFormalKaizenWalk") = False Then
            Dim Obj As New frmFormalKaizenWalk
            Obj.MdiParent = Me
            Obj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem374_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem374.Click
        If ChildWindowOpen("frmKAIZENideas") = False Then
            Dim Obj As New frmKAIZENideas
            Obj.MdiParent = Me
            Obj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem375_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem375.Click
        If ChildWindowOpen("frmkaizen") = False Then
            Dim frmEmployeesObj As New frmkaizen
            frmEmployeesObj.MdiParent = Me
            frmEmployeesObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem376_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem376.Click
        'If ChildWindowOpen("EmployeeKaizenEvaluation") = False Then
        '    Dim Obj As New EmployeeKaizenEvaluation
        '    Obj.MdiParent = Me
        '    Obj.Show()
        'End If
    End Sub

    Private Sub ToolStripMenuItem377_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem377.Click
        If ChildWindowOpen("frmKAIZENReports") = False Then
            Dim Obj As New frmKAIZENReports
            Obj.MdiParent = Me
            Obj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem378_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem378.Click
        If ChildWindowOpen("frmTraing") = False Then
            Dim LamCode As New frmTraing
            LamCode.MdiParent = Me
            LamCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem379_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem379.Click
        If ChildWindowOpen("frmTraingData") = False Then
            Dim LamCode As New frmTraingData
            LamCode.MdiParent = Me
            LamCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem380_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem380.Click
        If ChildWindowOpen("frmTraingHead") = False Then
            Dim LamCode As New frmTraingHead
            LamCode.MdiParent = Me
            LamCode.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem249_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem249.Click
        If ChildWindowOpen("FrmShopReports") = False Then
            Dim AnalysisRecordObj As New EmployeeEvaluationForm

            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem250_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem250.Click
        If ChildWindowOpen("frmSelfAssessment") = False Then
            Dim Obj As New frmSelfAssessment
            Obj.MdiParent = Me
            Obj.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem252_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem252.Click
        If ChildWindowOpen("FrmEmpEval") = False Then
            Dim FrmEmpEvalObj As New FrmEmpEval()
            FrmEmpEvalObj.MdiParent = Me
            FrmEmpEvalObj.Show()
        End If
    End Sub

    Private Sub VistisAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VistisAttendanceToolStripMenuItem.Click
        If ChildWindowOpen("frmAttAcessToDB") = False Then
            Dim FrmEmpEvalObj As New frmAttAcessToDB
            FrmEmpEvalObj.MdiParent = Me
            FrmEmpEvalObj.Show()
        End If
    End Sub

    Private Sub SMSPortalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SMSPortalToolStripMenuItem.Click
        If ChildWindowOpen("frmSMSPortal") = False Then
            Dim FrmEmpEvalObj As New frmSMSPortal
            FrmEmpEvalObj.MdiParent = Me
            FrmEmpEvalObj.Show()
        End If
    End Sub

    Private Sub CanteenAttendanceExcelToDBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CanteenAttendanceExcelToDBToolStripMenuItem1.Click
        If ChildWindowOpen("frmCanteenAttendanceUploadingBarCode") = False Then
            Dim FrmEmpEvalObj1 As New frmCanteenAttendanceUploadingBarCode
            FrmEmpEvalObj1.MdiParent = Me
            FrmEmpEvalObj1.WindowState = FormWindowState.Maximized
            FrmEmpEvalObj1.Show()
        End If
    End Sub

    Private Sub BarCodeCanteenAttendanceExcelToDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarCodeCanteenAttendanceExcelToDBToolStripMenuItem.Click
        If ChildWindowOpen("frmCanteenAttendanceUploadingBarCode") = False Then
            Dim FrmEmpEvalObj1 As New frmCanteenAttendanceUploadingBarCode
            FrmEmpEvalObj1.MdiParent = Me
            FrmEmpEvalObj1.WindowState = FormWindowState.Maximized
            FrmEmpEvalObj1.Show()
        End If
    End Sub

    Private Sub TerminatedEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminatedEmployeeToolStripMenuItem.Click
        If ChildWindowOpen("frmtermination") = False Then
            Dim FrmEmpEvalObj1 As New frmtermination
            FrmEmpEvalObj1.MdiParent = Me
            FrmEmpEvalObj1.WindowState = FormWindowState.Maximized
            FrmEmpEvalObj1.Show()
        End If
    End Sub

    Private Sub DisabilityDescriptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisabilityDescriptionsToolStripMenuItem.Click
        If ChildWindowOpen("FrmDisability") = False Then
            Dim FrmEmpEvalObj1 As New FrmDisability
            FrmEmpEvalObj1.MdiParent = Me
            FrmEmpEvalObj1.WindowState = FormWindowState.Maximized
            FrmEmpEvalObj1.Show()
        End If
    End Sub

    Private Sub ToolStripMenuItem254_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem254.Click
        If ChildWindowOpen("frmAnnualLeavesReports") = False Then
            Dim AnalysisRecordObj As New frmAnnualLeavesReports
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EmployeeBloodDonationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeBloodDonationToolStripMenuItem.Click
        If ChildWindowOpen("FrmDoner") = False Then
            Dim AnalysisRecordObj As New FrmDoner
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub AutoAttendanceEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoAttendanceEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmAutoAttEntry") = False Then
            Dim AnalysisRecordObj As New frmAutoAttEntry
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub INTDailySaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTDailySaleToolStripMenuItem.Click
        If ChildWindowOpen("FrmTransout") = False Then
            Dim AnalysisRecordObj As New FrmTransout
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub INTItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INTItemsToolStripMenuItem.Click
        If ChildWindowOpen("FrmIntIntems") = False Then
            Dim AnalysisRecordObj As New FrmIntIntems
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub ShortLeaveEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShortLeaveEntryToolStripMenuItem.Click
        If ChildWindowOpen("frmPayRollShortLeave") = False Then
            Dim AnalysisRecordObj As New frmPayRollShortLeave
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EmployeeEvaluationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeEvaluationToolStripMenuItem.Click
        If ChildWindowOpen("frmEmpEvaluation") = False Then
            Dim AnalysisRecordObj As New frmEmpEvaluation
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub

    Private Sub EvaluationReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluationReportsToolStripMenuItem.Click
        If ChildWindowOpen("frmRptEmpEvaluation") = False Then
            Dim AnalysisRecordObj As New frmRptEmpEvaluation
            AnalysisRecordObj.MdiParent = Me
            AnalysisRecordObj.WindowState = FormWindowState.Maximized
            AnalysisRecordObj.Show()
        End If
    End Sub
End Class