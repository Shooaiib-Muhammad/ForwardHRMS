Public Class DateWiseFrm
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass


    Private Sub DateWiseFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Leave_Reason' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Leave_ReasonTableAdapter.Fill(Me.DSHRM.tbl_HRM_Leave_Reason)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_JobType' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_JobTypeTableAdapter.Fill(Me.DSHRM.tbl_HRM_JobType)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

        starttime.Text = Date.Now
        If (Me.Tbl_Comp_InfoTableAdapter.FillBy(Me.DSUser.tbl_Comp_Info)) > 0 Then
            Me.RadioButton3.Visible = False
            Me.RadioButton10.Visible = False
            Me.RadioButton2.Visible = False

        Else
            Me.RadioButton3.Visible = True
            Me.RadioButton10.Visible = True
            Me.RadioButton2.Visible = True
        End If
    End Sub



    Private Sub DepBTn_CheckedChanged(sender As Object, e As EventArgs) Handles DepBTn.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False



    End Sub



    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True


    End Sub

    Private Sub SBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SBtn.CheckedChanged

        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = True
        BranchNameComboBox.Enabled = False
        HiringCriteriaComboBox.Enabled = False
        ReasonComboBox.Enabled = False
        COmboxbyter.Enabled = False

    End Sub

    Private Sub GBtn_CheckedChanged(sender As Object, e As EventArgs) Handles GBtn.CheckedChanged

        GradeNameComboBox.Enabled = True
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        HiringCriteriaComboBox.Enabled = False
        ReasonComboBox.Enabled = False
        COmboxbyter.Enabled = False


    End Sub

    Private Sub BBtn_CheckedChanged(sender As Object, e As EventArgs) Handles BBtn.CheckedChanged

        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = True
        ReasonComboBox.Enabled = False
        HiringCriteriaComboBox.Enabled = False
        COmboxbyter.Enabled = False

    End Sub

    Private Sub JBtn_CheckedChanged(sender As Object, e As EventArgs) Handles JBtn.CheckedChanged

        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = True
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        HiringCriteriaComboBox.Enabled = False
        ReasonComboBox.Enabled = False
        COmboxbyter.Enabled = False


    End Sub

    Private Sub SecBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SecBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False


    End Sub

    Private Sub BtnRptShower_Click(sender As Object, e As EventArgs) Handles BtnRptShower.Click




        If EmpList.Checked = True Then '' Employee Turn Over reports
            Path = "" & frmLogin.ReportsPath & "\HR\RptEmpLedger.rpt"
            'Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
            Param = "FirstDate = " & starttime.Value.Day & "/" & starttime.Value.Month & "/" & starttime.Value.Year & ""
            If All.Checked = True Then
                'Filter = "{tbl_HRM_Emp_Info.EmpStatus}=true "
                If AllDept.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And  {tbl_Hrm_Emp_Info.SectionName} = '" & SectionNameComboBox.Text & "'  And {View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {tbl_Hrm_Emp_Info.DesigName} = '" & DesigNameComboBox.Text & "'"
                End If
            End If

            If SBtn.Checked = True Then

                If AllDept.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.shiftName} = '" & ShiftNameComboBox.Text & "'"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.shiftName} = '" & ShiftNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.shiftName} = '" & ShiftNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And  {tbl_Hrm_Emp_Info.SectionName} = '" & SectionNameComboBox.Text & "' "
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.shiftName} = '" & ShiftNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DesigName} = '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf GBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.GradeName} = '" & GradeNameComboBox.Text & "'"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.GradeName} = '" & GradeNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.GradeName} = '" & GradeNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And  {tbl_Hrm_Emp_Info.SectionName} = '" & SectionNameComboBox.Text & "' "
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.GradeName} = '" & GradeNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DesigName} = '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf JBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.Jobtype} = '" & JobTypeNameComboBox.Text & "'"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.Jobtype} = '" & JobTypeNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.Jobtype} = '" & JobTypeNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And  {tbl_Hrm_Emp_Info.SectionName} = '" & SectionNameComboBox.Text & "' "
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.Jobtype} = '" & JobTypeNameComboBox.Text & "'  And {tbl_Hrm_Emp_Info.DesigName} = '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf BBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {tbl_Hrm_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And  {tbl_Hrm_Emp_Info.SectionName} = '" & SectionNameComboBox.Text & "' "
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Union_Emp_INOUT.HiringDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {tbl_Hrm_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {tbl_Hrm_Emp_Info.DesigName} = '" & DesigNameComboBox.Text & "'"
                End If
            End If
        End If

        If HiringBtn.Checked = True Then ' New Hiring Rpt
            Path = "" & frmLogin.ReportsPath & "\HR\NewHiringRpt.rpt"
            If All.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000 and  {tbl_HRM_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000 and  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000 And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000 And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf BBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000 And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf GBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000 And{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And{tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf SBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf JBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.CardNo} < 50000  And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            End If
        End If
        '{View_Rpt_Acc_AllEmployees.CardNo} = 450









        ' Hirig Criteria 
        If HiringBtn.Checked = True Then
            If HirCritBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\HirngCriteriaRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Emp_Info.HiringCriteria} = '" & HiringCriteriaComboBox.SelectedItem & "' And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Emp_Info.HiringCriteria} = '" & HiringCriteriaComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Emp_Info.HiringCriteria} = '" & HiringCriteriaComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Emp_Info.HiringCriteria} = '" & HiringCriteriaComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If









        If CrdExpry.Checked = True Then    '' EMmployee card Expiry
            Path = "" & frmLogin.ReportsPath & "\HR\EmpCrdExpRpt.rpt"
            If All.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Emp_Info.EndDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf BBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf GBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf SBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf JBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EndDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            End If
        End If


        If Ntc.Checked = True Then   ' EMp Noticce Log reports

            If All.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\EmpNoticLogRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Emp_Info.NoticeIssueDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf BBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\EmpNoticLogRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf GBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\EmpNoticLogRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf SBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\EmpNoticLogRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDates} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf JBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\EmpNoticLogRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And  {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton1.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\RptnoticeByReason.rpt"
                If AllDept.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.ReasonID} = " & ReasonComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.ReasonID} = " & ReasonComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = " {View_Rpt_Acc_AllEmployees.ReasonID} = " & ReasonComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Acc_AllEmployees.SuBDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.ReasonID} = " & ReasonComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.NoticeIssueDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            End If



        End If

        If TerListBtn.Checked = True Then ' Terminiation List 

            If All.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\TermListRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.leavingDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.Subdept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf BBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\TermListRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.Subdept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf GBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\TermListRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.Gradename} = '" & GradeNameComboBox.Text & "'  And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.Gradename} = '" & GradeNameComboBox.Text & "'  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.Gradename} = '" & GradeNameComboBox.Text & "'  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.Subdept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.Gradename} = '" & GradeNameComboBox.Text & "'  And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf SBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\TermListRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.Subdept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf JBtn.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\TermListRpt.rpt"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.JTID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.JTID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.JTID} = " & JobTypeNameComboBox.SelectedValue & " And{tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.Subdept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And {tbl_HRM_Emp_Info.JTID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.leavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton1.Checked = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\RptterByReason.rpt"
                If AllDept.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.LeaveDesc} = '" & COmboxbyter.Text & "' And {View_Rpt_Acc_AllEmployees.LeavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.LeaveDesc} = '" & COmboxbyter.Text & "' And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.LeavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = " {View_Rpt_Acc_AllEmployees.LeaveDesc} = '" & COmboxbyter.Text & "' And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Acc_AllEmployees.SuBDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.LeavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Rpt_Acc_AllEmployees.LeaveDesc} = '" & COmboxbyter.Text & "' And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.LeavingDate} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If

        End If

        '' Probabition ENd List 
        If ProbEndBtn.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\ProbabitionEndRpt.rpt"
            If All.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Emp_Info.DateOfPermanent} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf BBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf GBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & "  And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf SBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf JBtn.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= true And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfPermanent} In  #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            End If

        End If

        If PendingStatus.Checked = True Then ' Pending Status 

            Path = "" & frmLogin.ReportsPath & "\HR\EmpPendingSalaryStatus.rpt"
            If All.Checked = True Then ' All 

                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_Hrm_Emp_Info.DateOfJoning}  In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & "And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf BBtn.Checked = True
                If AllDept.Checked = True Then ' All Dept

                    Filter = "{tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And   {tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then ' Main Dept
                    Filter = "{tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.EmpStatus} = True  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then ' MAni Secttion
                    Filter = " {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And  {tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then ' ' Designation
                    Filter = "{tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And  {tbl_HRM_Emp_Info.EmpStatus} = True  And   {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & "And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                End If

            End If
        End If
        'termination Latter 
        If RadioButton18.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\Terminationletter.rpt"
            If AllDept.Checked = True Then
                Filter = "  {tbl_Acc_Termination_Transactions.TerminationDate} in Date(" & starttime.Value.Year & " , " & starttime.Value.Month & " , " & starttime.Value.Day & ") to Date(" & EndTime.Value.Year & " , " & EndTime.Value.Month & " , " & EndTime.Value.Day & ") "
            ElseIf DepBTn.Checked = True Then
                Filter = "{View_Rpt_Acc_InActiveEmployees.DeptID}=" & DeptNameComboBox.SelectedValue & "  And {tbl_Acc_Termination_Transactions.TerminationDate} in Date(" & starttime.Value.Year & " , " & starttime.Value.Month & " , " & starttime.Value.Day & ") to Date(" & EndTime.Value.Year & " , " & EndTime.Value.Month & " , " & EndTime.Value.Day & ") "
            ElseIf SecBtn.Checked = True Then
                Filter = "{View_Rpt_Acc_InActiveEmployees.DeptID}=" & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_InActiveEmployees.SubDept1ID}=" & SectionNameComboBox.SelectedValue & "  And  {tbl_Acc_Termination_Transactions.TerminationDate} in Date(" & starttime.Value.Year & " , " & starttime.Value.Month & " , " & starttime.Value.Day & ") to Date(" & EndTime.Value.Year & " , " & EndTime.Value.Month & " , " & EndTime.Value.Day & ") "
            ElseIf DesigBtn.Checked = True Then
                Filter = "{View_Rpt_Acc_InActiveEmployees.DesignationID}=" & DesigNameComboBox.SelectedValue & "  And  {tbl_Acc_Termination_Transactions.TerminationDate} in Date(" & starttime.Value.Year & " , " & starttime.Value.Month & " , " & starttime.Value.Day & ") to Date(" & EndTime.Value.Year & " , " & EndTime.Value.Month & " , " & EndTime.Value.Day & ") "
            End If
        End If






        ' OT Per Calculation Month Wise 
        If RadioButton10.Checked = True Then
            Param = ""
            Path = "" & frmLogin.ReportsPath & "\Accounts\OTPrecalculation.rpt"
            If All.Checked = True Then ' All
                If AllDept.Checked = True Then ' All EMp
                    Filter = "{View_Union_OT_Calc.Year} = " & starttime.Value.Year & " And {View_Union_OT_Calc.Month} = " & starttime.Value.Month & ""
                ElseIf DepBTn.Checked = True Then '  Main Dept
                    Filter = "{View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Union_OT_Calc.Month}= " & starttime.Value.Month & " And {View_Union_OT_Calc.Year}= " & starttime.Value.Year & " "
                ElseIf SecBtn.Checked = True Then ' SecBTn Wise
                    Filter = "{View_Union_OT_Calc.Month}= " & starttime.Value.Month & " And {View_Union_OT_Calc.Year}= " & starttime.Value.Year & "  And {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Union_OT_Calc.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Desig Wise
                    Filter = "{View_Union_OT_Calc.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Union_OT_Calc.Month}= " & starttime.Value.Month & " And {View_Union_OT_Calc.Year}= " & starttime.Value.Year & " "

                End If


            ElseIf BBtn.Checked = True Then ' By Branch

                If AllDept.Checked = True Then ' All EMp
                    Filter = " {View_Union_OT_Calc.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & starttime.Value.Year & " And {View_Union_OT_Calc.Month} = " & starttime.Value.Month & ""
                ElseIf DepBTn.Checked = True Then '  Main Dept
                    Filter = "{View_Union_OT_Calc.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & starttime.Value.Year & " And {View_Union_OT_Calc.Month} = " & starttime.Value.Month & ""

                ElseIf SecBtn.Checked = True Then ' SecBTn Wise
                    Filter = " {View_Union_OT_Calc.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Union_OT_Calc.SectionID} = " & SectionNameComboBox.SelectedValue & "   And  {View_Union_OT_Calc.Year} = " & starttime.Value.Year & " And {View_Union_OT_Calc.Month} = " & starttime.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then ' Desig Wise
                    Filter = "{View_Union_OT_Calc.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Union_OT_Calc.DesignationID} = " & DesigNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & starttime.Value.Year & " And {View_Union_OT_Calc.Month} = " & starttime.Value.Month & ""

                End If

            End If
        End If



        '''' OT Per Calculation Summary  Date Wise \
        If RadioButton2.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\OTPrecalculationDeptWise.rpt"
            Param = "FromDate=#" & Format(starttime.Value, "dd/MM/yyyy") & "#&ToDate=#" & Format(EndTime.Value, "dd/MM/yyyy") & "#"
            If All.Checked = True Then ' All 

                If AllDept.Checked = True Then
                    Filter = "{View_OT_DateWise_DeptWise_AmtSum.AttDate}  In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_OT_DateWise_DeptWise_AmtSum.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_DateWise_DeptWise_AmtSum.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = " {View_OT_DateWise_DeptWise_AmtSum.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_DateWise_DeptWise_AmtSum.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_OT_DateWise_DeptWise_AmtSum.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf BBtn.Checked = True
                If AllDept.Checked = True Then ' All Dept

                    Filter = "{View_OT_DateWise_DeptWise_AmtSum.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_OT_DateWise_DeptWise_AmtSum.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then ' Main Dept
                    Filter = "{View_OT_DateWise_DeptWise_AmtSum.BranchID}= " & BranchNameComboBox.SelectedValue & "    And {View_OT_DateWise_DeptWise_AmtSum.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_DateWise_DeptWise_AmtSum.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then ' MAni Secttion
                    Filter = " {View_OT_DateWise_DeptWise_AmtSum.BranchID}= " & BranchNameComboBox.SelectedValue & "  And  {View_OT_DateWise_DeptWise_AmtSum.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_DateWise_DeptWise_AmtSum.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_OT_DateWise_DeptWise_AmtSum.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"

                End If

            End If
        End If
        ''' Late Sitters 




        If RadioButton3.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptOTMail.rpt"
            If All.Checked = True Then ' All
                If AllDept.Checked = True Then ' All EMp
                    Filter = "{View_Att_DayGroup.AttDate}  In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"

                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If


            ElseIf BBtn.Checked = True Then ' By Branch

                If AllDept.Checked = True Then ' All EMp
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}  In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"

                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If


            End If
        End If


        If pendEOBICrd.Checked = True Then 'EMployee  EOBI List 


            Path = "" & frmLogin.ReportsPath & "\HR\InActiveEOBICard.rpt"
            If All.Checked = True Then '' All Btn 
                If AllDept.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true And {View_Rpt_Emp_List.DateOfJoining}  In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DepBTn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DateOfJoining}  In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And   {View_Rpt_Emp_List.DateOfJoining}  In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true  And {View_Rpt_Emp_List.DesigID} =" & DesigNameComboBox.SelectedValue & " And  {View_Rpt_Emp_List.DateOfJoining}  In #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If
        If RadioButton4.Checked Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\SalaryAnalysis.rpt"
            Param = "@FromDate=" & starttime.Value.Date & "&@ToDate=" & EndTime.Value.Date & ""
        End If
        If RadioButton5.Checked Then
            Path = "" & frmLogin.ReportsPath & "\HR\hrmonthlyreport.rpt"
            Filter = "{View_HR_Monthly_Data.SalaryMonth} = #" & Format(Me.starttime.Value, "MM/dd/yyyy") & "#"
        End If
        Obj.LoadDateWiseReports(Path, Filter, Param)
    End Sub



    Private Sub TerListBtn_CheckedChanged(sender As Object, e As EventArgs) Handles TerListBtn.CheckedChanged
        HiringCriteriaComboBox.Enabled = False
        HirCritBtn.Enabled = False
        COmboxbyter.Enabled = False

        All.Checked = True
        If TerListBtn.Checked = True Then
            RadioButton1.Enabled = True
        Else
            RadioButton1.Enabled = False
        End If
        GBtn.Enabled = True
        SBtn.Enabled = True
        BBtn.Enabled = True
        JBtn.Enabled = True
        ReasonComboBox.Visible = False
        COmboxbyter.Visible = True
    End Sub

    Private Sub CrdExpry_CheckedChanged(sender As Object, e As EventArgs) Handles CrdExpry.CheckedChanged
        HiringCriteriaComboBox.Enabled = False
        HirCritBtn.Enabled = False
        All.Checked = True
        GBtn.Enabled = True
        SBtn.Enabled = True
        BBtn.Enabled = True
        JBtn.Enabled = True
    End Sub

    Private Sub ProbEndBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ProbEndBtn.CheckedChanged
        HiringCriteriaComboBox.Enabled = False
        HirCritBtn.Enabled = False
        All.Checked = True
        GBtn.Enabled = True
        SBtn.Enabled = True
        BBtn.Enabled = True
        JBtn.Enabled = True
    End Sub

    Private Sub HirCritBtn_CheckedChanged(sender As Object, e As EventArgs) Handles HirCritBtn.CheckedChanged
        HiringCriteriaComboBox.Enabled = True

        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        ReasonComboBox.Enabled = False



    End Sub

    Private Sub Ntc_CheckedChanged(sender As Object, e As EventArgs) Handles Ntc.CheckedChanged
        HiringCriteriaComboBox.Enabled = False
        HirCritBtn.Enabled = False
        All.Checked = True
        If Ntc.Checked = True Then
            RadioButton1.Enabled = True
        Else
            RadioButton1.Enabled = False
        End If
        GBtn.Enabled = True
        SBtn.Enabled = True
        BBtn.Enabled = True
        JBtn.Enabled = True
        ReasonComboBox.Visible = True
        COmboxbyter.Visible = False
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub All_CheckedChanged(sender As Object, e As EventArgs) Handles All.CheckedChanged

        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        HiringCriteriaComboBox.Enabled = False
        ReasonComboBox.Enabled = False
        COmboxbyter.Enabled = False
    End Sub

    Private Sub AllDept_CheckedChanged(sender As Object, e As EventArgs) Handles AllDept.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub HiringBtn_CheckedChanged(sender As Object, e As EventArgs) Handles HiringBtn.CheckedChanged
        HirCritBtn.Enabled = True
        All.Checked = True
        GBtn.Enabled = True
        SBtn.Enabled = True
        BBtn.Enabled = True
        JBtn.Enabled = True
    End Sub

    Private Sub EmpList_CheckedChanged(sender As Object, e As EventArgs) Handles EmpList.CheckedChanged
        HirCritBtn.Enabled = False
        All.Checked = True
        GBtn.Enabled = False
        SBtn.Enabled = False
        BBtn.Enabled = False
        JBtn.Enabled = False

    End Sub

    Private Sub EndTime_ValueChanged(sender As Object, e As EventArgs) Handles EndTime.ValueChanged

    End Sub

    Private Sub PendingStatus_CheckedChanged(sender As Object, e As EventArgs) Handles PendingStatus.CheckedChanged
        If PendingStatus.Checked = True Then
            GBtn.Enabled = False
            SBtn.Enabled = False
            HirCritBtn.Enabled = False
            JBtn.Enabled = False
        Else
            GBtn.Enabled = True
            SBtn.Enabled = True
            HirCritBtn.Enabled = True
            JBtn.Enabled = True
        End If
        All.Checked = True
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            BBtn.Enabled = False
            GBtn.Enabled = False
            JBtn.Enabled = False
            SBtn.Enabled = False
            HirCritBtn.Enabled = False

        Else
            BBtn.Enabled = True
            GBtn.Enabled = True
            JBtn.Enabled = True
            SBtn.Enabled = True
            HirCritBtn.Enabled = True
        End If
        All.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        HiringCriteriaComboBox.Enabled = False
        ReasonComboBox.Enabled = True
        COmboxbyter.Enabled = True


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GBtn.Enabled = False
            JBtn.Enabled = False
            SBtn.Enabled = False
            HirCritBtn.Enabled = False
            RadioButton1.Enabled = False
            DesigBtn.Enabled = False

            BBtn.Enabled = True
        Else
            GBtn.Enabled = True
            JBtn.Enabled = True
            SBtn.Enabled = True
            HirCritBtn.Enabled = True
            RadioButton1.Enabled = True
            DesigBtn.Enabled = True

            BBtn.Enabled = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            GBtn.Enabled = False
            JBtn.Enabled = False
            SBtn.Enabled = False
            HirCritBtn.Enabled = False


            BBtn.Enabled = True
            Label5.Text = "Selected Month"
            starttime.CustomFormat = "MMM, yyyy"

            Label6.Visible = False
            EndTime.Visible = False

        Else
            Label5.Text = "Start Date:"
            starttime.CustomFormat = "MM/dd/yyyy"
            Label6.Visible = True
            EndTime.Visible = True
            GBtn.Enabled = True
            JBtn.Enabled = True
            SBtn.Enabled = True
            HirCritBtn.Enabled = True
            RadioButton1.Enabled = True

            BBtn.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            GBtn.Enabled = False
            JBtn.Enabled = False
            SBtn.Enabled = False
            HirCritBtn.Enabled = False
            RadioButton1.Enabled = False
            All.Checked = True

            BBtn.Enabled = True
        Else
            GBtn.Enabled = True
            JBtn.Enabled = True
            SBtn.Enabled = True
            HirCritBtn.Enabled = True
            RadioButton1.Enabled = True


            BBtn.Enabled = False
        End If
    End Sub

    Private Sub pendEOBICrd_CheckedChanged(sender As Object, e As EventArgs) Handles pendEOBICrd.CheckedChanged
        If pendEOBICrd.Checked = True Then
            BBtn.Enabled = False
            GBtn.Enabled = False
            SBtn.Enabled = False
            JBtn.Enabled = False
            HirCritBtn.Enabled = False
            RadioButton1.Enabled = False
        Else

            BBtn.Enabled = True
            GBtn.Enabled = True
            SBtn.Enabled = True
            JBtn.Enabled = True
            HirCritBtn.Enabled = True
            RadioButton1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        If RadioButton5.Checked = True Then
            Label5.Text = "Selected Month"
            starttime.CustomFormat = "MMM, yyyy"
            Label6.Visible = False
            EndTime.Visible = False

        Else
            Label5.Text = "From Date"
            starttime.CustomFormat = "dd/MM/yyyy"
            Label6.Visible = True
            EndTime.Visible = True

        End If
    End Sub
End Class