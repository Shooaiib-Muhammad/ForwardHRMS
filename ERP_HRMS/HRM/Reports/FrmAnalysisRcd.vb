Public Class FrmAnalysisRcd


    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        If All.Checked = True Then
            Filter = "{tbl_HRM_Emp_Info.EmpPic} is null"

        ElseIf DepBTn.Checked = True Then
            Filter = "{tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
        ElseIf SecBtn.Checked = True Then
            Filter = "{tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
        ElseIf SBtn.Checked = True Then
            Filter = "{tbl_HRM_Emp_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
        ElseIf GBtn.Checked = True Then
            Filter = "{tbl_HRM_Emp_Info.GradeID} = " & GradeNameComboBox.SelectedValue & ""
        ElseIf DesigBtn.Checked = True Then
            Filter = "{tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
        ElseIf BBtn.Checked = True Then
            Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
        ElseIf JBtn.Checked = True Then
            Filter = "{tbl_HRM_Emp_Info.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & ""
        End If


        Obj.LoadAnalysisReports(Path, Filter, Param)
    End Sub

    Private Sub Tbl_HRM_DeptBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_DeptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)

    End Sub

    Private Sub FrmAnalysisRcd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Emp_Notices' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_Emp_NoticesTableAdapter.Fill(Me.DSHRM.tbl_Hrm_Emp_Notices)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Leave_Reason' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_JobType' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_JobTypeTableAdapter.Fill(Me.DSHRM.tbl_HRM_JobType)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

    End Sub

    Private Sub All_CheckedChanged(sender As Object, e As EventArgs) Handles All.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False

        NoticeTypeComboBox.Enabled = False
        starttime.Enabled = True
        EndTime.Enabled = True
    End Sub

    Private Sub BBtn_CheckedChanged(sender As Object, e As EventArgs) Handles BBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = True

        NoticeTypeComboBox.Enabled = False
        starttime.Enabled = True
        EndTime.Enabled = True
    End Sub

    Private Sub DepBTn_CheckedChanged(sender As Object, e As EventArgs) Handles DepBTn.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        If BBtn.Checked = True Then
            BranchNameComboBox.Enabled = True
        ElseIf GBtn.Checked = True Then
            GradeNameComboBox.Enabled = True
        ElseIf JBtn.Checked = True Then
            JobTypeNameComboBox.Enabled = True
        ElseIf SBtn.Checked = True Then
            ShiftNameComboBox.Enabled = True

        End If
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        If BBtn.Checked = True Then
            BranchNameComboBox.Enabled = True
        ElseIf GBtn.Checked = True Then
            GradeNameComboBox.Enabled = True
        ElseIf JBtn.Checked = True Then
            JobTypeNameComboBox.Enabled = True
        ElseIf SBtn.Checked = True Then
            ShiftNameComboBox.Enabled = True

        End If
    End Sub

    Private Sub GBtn_CheckedChanged(sender As Object, e As EventArgs) Handles GBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = True
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False

        NoticeTypeComboBox.Enabled = False
        starttime.Enabled = True
        EndTime.Enabled = True
    End Sub

    Private Sub JBtn_CheckedChanged(sender As Object, e As EventArgs) Handles JBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = True
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False

        NoticeTypeComboBox.Enabled = False
        starttime.Enabled = True
        EndTime.Enabled = True
    End Sub

    Private Sub SBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = True
        BranchNameComboBox.Enabled = False

        NoticeTypeComboBox.Enabled = False
        starttime.Enabled = True
        EndTime.Enabled = True
    End Sub

    Private Sub SecBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SecBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        If BBtn.Checked = True Then
            BranchNameComboBox.Enabled = True
        ElseIf GBtn.Checked = True Then
            GradeNameComboBox.Enabled = True
        ElseIf JBtn.Checked = True Then
            JobTypeNameComboBox.Enabled = True
        ElseIf SBtn.Checked = True Then
            ShiftNameComboBox.Enabled = True

        End If
    End Sub

    Private Sub BtnRptShower_Click(sender As Object, e As EventArgs) Handles BtnRptShower.Click
        If HiringBtn.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\NewHiringRpt.rpt"
            If All.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If

            If RadioButton1.Checked = True Then
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SBtn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If

            If GBtn.Checked = True Then
                Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
            If BBtn.Checked = True Then
                Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
            If JBtn.Checked = True Then
                Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
            If SBtn.Checked = True Then
                Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
        End If

        If HiringBtn.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\NewHiringRpt.rpt"
            If BBtn.Checked = True Then
                Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
            If SBtn.Checked = True Then
                Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
            If JBtn.Checked = True Then
                Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
            If GBtn.Checked = True Then
                Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If



            If Ntc.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\EmpNoticLogRpt.rpt"
            If All.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.NoticeIssueDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
            If RadioButton1.Checked = True Then
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.NoticeIssueDate} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SBtn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
            If GBtn.Checked = True Then
                Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
            If BBtn.Checked = True Then
                Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
            If JBtn.Checked = True Then
                Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
            If SBtn.Checked = True Then
                Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            End If
            If ReasonBtn.Checked = True Then
                Filter = "{tbl_Hrm_Emp_Notices.NoticeID} = " & NoticeTypeComboBox.SelectedValue & ""
            End If
        End If






        If TerListBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\TermListRpt.rpt"
                If All.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
                If RadioButton1.Checked = True Then
                    If DepBTn.Checked = True Then
                        Filter = "{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    ElseIf SecBtn.Checked = True Then
                        Filter = "{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.DateOfJoning} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    ElseIf SBtn.Checked = True Then
                        Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBtn.Checked = True Then
                        Filter = "{tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
                If GBtn.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
                If BBtn.Checked = True Then
                    Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
                If JBtn.Checked = True Then
                    Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
                If SBtn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            End If
        If TerListBtn.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\TermListRpt.rpt"
            If BBtn.Checked = True Then
                Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
            If SBtn.Checked = True Then
                Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
            If JBtn.Checked = True Then
                Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
            If GBtn.Checked = True Then
                Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If



        Obj.LoadAnalysisReports(Path, Filter, Param)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DeptNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False

        NoticeTypeComboBox.Enabled = False

        starttime.Enabled = True
        EndTime.Enabled = True
    End Sub

    Private Sub ReasonBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ReasonBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        NoticeTypeComboBox.Enabled = True

        starttime.Enabled = False
        EndTime.Enabled = False
    End Sub

    Private Sub HiringBtn_CheckedChanged(sender As Object, e As EventArgs) Handles HiringBtn.CheckedChanged
        ReasonBtn.Enabled = False
    End Sub

    Private Sub Ntc_CheckedChanged(sender As Object, e As EventArgs) Handles Ntc.CheckedChanged
        ReasonBtn.Enabled = True
    End Sub

    Private Sub TerListBtn_CheckedChanged(sender As Object, e As EventArgs) Handles TerListBtn.CheckedChanged
        ReasonBtn.Enabled = False
    End Sub
End Class