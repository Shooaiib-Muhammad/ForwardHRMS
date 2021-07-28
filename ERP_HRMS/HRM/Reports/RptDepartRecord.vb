Public Class RptDepartRecord
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Private Sub RptDepartRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDept.tbl_HRM_Grade_NEW2' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Grade_NEW2TableAdapter.Fill(Me.DSDept.tbl_HRM_Grade_NEW2)
        'TODO: This line of code loads data into the 'DSDept.tbl_HRM_Grade_NEW' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Grade_NEWTableAdapter.Fill(Me.DSDept.tbl_HRM_Grade_NEW)
        'TODO: This line of code loads data into the 'DSUser.View_HRM_Section' table. You can move, or remove it, as needed.
        Me.View_HRM_SectionTableAdapter.Fill(Me.DSUser.View_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section1' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_Section1TableAdapter.Fill(Me.DSHRM.tbl_HRM_Section1)
        ''TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section1' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_Section1TableAdapter.Fill(Me.DSHRM.tbl_HRM_Section1)
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Employment' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_EmploymentTableAdapter.FillBy(Me.DSHRM.tbl_Hrm_Employment)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_EmpCatagory' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_EmpCatagoryTableAdapter.Fill(Me.DSHRM.tbl_HRM_EmpCatagory)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Qualfication' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_QualficationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Qualfication)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_JobType' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_JobTypeTableAdapter.Fill(Me.DSHRM.tbl_HRM_JobType)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

        If GroupBox1.Visible = True Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False
        End If


    End Sub

    Private Sub BtnRptShower_Click(sender As Object, e As EventArgs) Handles BtnRptShower.Click





        If EmpBtn.Checked = True Then ' Emp List Rpt
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmployeeList.rpt"
            If AllEmp.Checked = True Then ' All EMp 
                If AllBtn.Checked = True Then ' All Dept
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true"
                ElseIf DepartmentBtn.Checked = True Then ' Main Dept
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf ByBranch.Checked = True Then ' By Branch 
                If AllBtn.Checked = True Then ' All Dept
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then ' Main Dept
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true And  {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true And  {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true And  {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            End If
        End If


        ' Shift Report
        If ShiftBtn.Checked = True Then ' Shift Wise Rpt
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\ShiftWiseRpt.rpt"
            If AllEmp.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
                End If
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""

            End If
        End If


        If ShiftBtn.Checked = True And DepartmentBtn.Checked = True Then
            flag = False

            Path = "" & frmLogin.ReportsPath & "\HR\DeptWiseShiftRpt.rpt"
            If AllEmp.Checked = True Then


                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
            End If
        End If

            If ShiftBtn.Checked = True And SecBTn.Checked = True Then
            flag = False

            If AllEmp.Checked = True Then


                Path = "" & frmLogin.ReportsPath & "\HR\SectionwsieShiftRpt.rpt"
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""

            End If


        End If

        If ShiftBtn.Checked = True And DesigBtn.Checked = True Then
            flag = False
            If AllEmp.Checked = True Then


                Path = "" & frmLogin.ReportsPath & "\HR\desigWiseShiftRpt.rpt"
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then

                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Shift.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""


            End If
        End If


        ' Grda Report
        If GradeBtn.Checked = True Then
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\GradeWiseRpt.rpt"
            If AllBtn.Checked = True Then
                If AllEmp.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & ""
                ElseIf ByBranch.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & ""

                End If

            End If
        End If


        If GradeBtn.Checked = True And DepartmentBtn.Checked = True Then
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\DeptWiseGradeRpt.rpt"
            If AllEmp.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""

            End If

        End If

        If GradeBtn.Checked = True And SecBTn.Checked = True Then
            flag = False
                    Path = "" & frmLogin.ReportsPath & "\HR\SectionWiseGradeRpt.rpt"
            If AllEmp.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""

            End If

        End If


            If GradeBtn.Checked = True And DesigBtn.Checked = True Then
            flag = False
                        Path = "" & frmLogin.ReportsPath & "\HR\desigWiseGradeRpt.rpt"
            If AllEmp.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Grade.GradeID} = " & GradeNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

            End If


        End If

        ' Job Type report

        If JobTypeBtn.Checked = True Then
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\JobTypeWiseRpt.rpt"
            If AllBtn.Checked = True Then
                If AllEmp.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & ""
                ElseIf ByBranch.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & ""


                End If

            End If
            End If

        If JobTypeBtn.Checked = True And DepartmentBtn.Checked = True Then
                flag = False
                Path = "" & frmLogin.ReportsPath & "\HR\DeptWiseJobTypeRpt.rpt"
            If AllEmp.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""

            End If
        End If


        If JobTypeBtn.Checked = True And SecBTn.Checked = True Then
            flag = False
                    Path = "" & frmLogin.ReportsPath & "\HR\SectionWiseJobtypeRpt.rpt"
            If AllEmp.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""

            End If

        End If



        If JobTypeBtn.Checked = True And DesigBtn.Checked = True Then
            flag = False
                        Path = "" & frmLogin.ReportsPath & "\HR\desigWiseJobTypeRpt.rpt"
            If AllEmp.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
            ElseIf ByBranch.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_JobType.JobTypeID} = " & JobTypeNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

            End If

        End If

        If BGBtn.Checked = True Then ' Blood Group RPT
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpBGRpt.rpt"
            If AllEmp.Checked = True Then
                If AllBtn.Checked = True Then ' All Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BloodGroup} = '" & BloodGroupComboBox.SelectedItem & "'"
                ElseIf DepartmentBtn.Checked = True Then ' Main Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BloodGroup} = '" & BloodGroupComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then ' by Section 
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BloodGroup} = '" & BloodGroupComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' By desig
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BloodGroup} = '" & BloodGroupComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then ' All Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.BloodGroup} = '" & BloodGroupComboBox.SelectedItem & "'"
                ElseIf DepartmentBtn.Checked = True Then ' Main Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.BloodGroup} = '" & BloodGroupComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then ' by Section 
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.BloodGroup} = '" & BloodGroupComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' By desig
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.BloodGroup} = '" & BloodGroupComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If

        If MSBtn.Checked = True Then 'marital Status RPT
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpMartialStatus.rpt"
            If AllEmp.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.MaritalStatus} = '" & MaritalStatusComboBox.SelectedItem & "'"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.MaritalStatus} = '" & MaritalStatusComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.MaritalStatus} = '" & MaritalStatusComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.MaritalStatus} = '" & MaritalStatusComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.MaritalStatus} = '" & MaritalStatusComboBox.SelectedItem & "'"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.MaritalStatus} = '" & MaritalStatusComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.MaritalStatus} = '" & MaritalStatusComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.MaritalStatus} = '" & MaritalStatusComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            End If
        End If



        If Genderbtn.Checked = True Then ' Gender RPT
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpGenderReport.rpt"
            If AllEmp.Checked = True Then


                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Gender} = '" & GenderComboBox.SelectedItem & "'"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Gender} = '" & GenderComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Gender} = '" & GenderComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Gender} = '" & GenderComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Gender} = '" & GenderComboBox.SelectedItem & "'"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Gender} = '" & GenderComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Gender} = '" & GenderComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Gender} = '" & GenderComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            End If
        End If



        If ReligBtn.Checked = True Then ' Religion RPT
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpReligRpt.rpt"
            If AllEmp.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Religion} = '" & ReligionComboBox.SelectedItem & "'"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Religion} = '" & ReligionComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Religion} = '" & ReligionComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Religion} = '" & ReligionComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Religion} = '" & ReligionComboBox.SelectedItem & "'"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Religion} = '" & ReligionComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Religion} = '" & ReligionComboBox.SelectedItem & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.Religion} = '" & ReligionComboBox.SelectedItem & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            End If
        End If



        If EmploymeyBtn.Checked = True Then   ' EMployment RPT
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmploymentWiseRpt.rpt"
            If AllEmp.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedItem & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            End If
        End If




        If EmpcatBtn.Checked = True Then ' EMp Catagory RPT
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmployeeCatagoryRpt.rpt"
            If AllEmp.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedItem & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            End If
        End If


        If QualfBtn.Checked = True Then ' Qualfication RPT
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\QualfRpt.rpt"
            If AllEmp.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.QualficationID} = " & QualficationNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.QualficationID} = " & QualficationNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.QualficationID} = " & QualficationNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.QualficationID} = " & QualficationNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.QualficationID} = " & QualficationNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.QualficationID} = " & QualficationNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.QualficationID} = " & QualficationNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.QualficationID} = " & QualficationNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            End If
        End If

        If MissBtn.Checked = True Then ' Missing pic RPT
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\rptPayRollEmpWithoutPics.rpt"
            If AllEmp.Checked = True Then ' All EMp
                If AllBtn.Checked = True Then ' Alll Dept
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true"
                ElseIf DepartmentBtn.Checked = True Then ' Main Dept
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then ' Section 
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_PayRoll_EmpWithoutPicture.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then 'by Designation 
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                If AllBtn.Checked = True Then ' All Dept
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.EmpStatus} = true And {View_Rpt_PayRoll_EmpWithoutPicture.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then ' MAin Dept
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.EmpStatus} = true And {View_Rpt_PayRoll_EmpWithoutPicture.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then ' by Section 
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.EmpStatus} = true And {View_Rpt_PayRoll_EmpWithoutPicture.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_PayRoll_EmpWithoutPicture.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' By Designation 
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.EmpStatus} = true And {View_Rpt_PayRoll_EmpWithoutPicture.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If


        If SinBtn.Checked = True Then ' Simerity List
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\SincerityListRpt.rpt"
            If AllEmp.Checked = True Then


                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = True"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If

        End If











        If BranchBtn.Checked = True Then ' branch Rpt
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\BrnchWiseRpt.rpt"
            If AllBtn.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & ""
            End If
        End If

        If BranchBtn.Checked = True And DepartmentBtn.Checked = True Then
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\DeptwisebrchRpt.rpt"
            Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
        End If
        If BranchBtn.Checked = True And SecBTn.Checked = True Then
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\SectionWiseBranchRpt.rpt"
            Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
        End If

        If BranchBtn.Checked = True And DesigBtn.Checked = True Then
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\DesigWiseBrnchRpt.rpt"
            Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Branch.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
        End If












        If RadioButton1.Checked = True Then ' Section COde
            flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\SectCodeRpt.rpt"
            If AllEmp.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Section.SectionCode} = '" & SectionCodeComboBox.Text & "' And {tbl_HRM_Emp_Info.EmpStatus} = true"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Section.SectionCode} = '" & SectionCodeComboBox.Text & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Section.SectionCode} = '" & SectionCodeComboBox.Text & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf ByBranch.Checked = True Then
                If AllBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Section.SectionCode} = '" & SectionCodeComboBox.Text & "' And {tbl_HRM_Emp_Info.EmpStatus} = true"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Section.SectionCode} = '" & SectionCodeComboBox.Text & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Section.SectionCode} = '" & SectionCodeComboBox.Text & "' And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            End If
        End If





        If PerBtn.Checked = True Then '' Performance Apporisal FOrm Senior management

            Path = "" & frmLogin.ReportsPath & "\HR\RptAppraisalForm.rpt"
            If Bycard.Checked = True Then ' By card Range 
                If AllBtn.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        flag = True

                    Else
                        flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                    'If TextBox1.Text = "" And TextBox2.Text = "" Then
                    '    MessageBox.Show("Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End If

                ElseIf DepartmentBtn.Checked = True Then ' by Dept
                    If TextBox1.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then ' By Section 
                    If TextBox1.Text.Length = 0 Then
                        flag = True

                    Else
                        flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then 'By Desig 
                    If TextBox1.Text.Length = 0 Then
                        flag = True

                    Else
                        flag = False

                    End If

                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_HRM_Emp_Info.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bygrade.Checked = True Then
                flag = False
                If AllBtn.Checked = True Then ' by All Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.GradeName} in '" & ComboBox1.Text & "' To '" & ComboBox2.Text & "'"
                ElseIf DepartmentBtn.Checked = True Then ' by Main Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.GradeName} in '" & ComboBox1.Text & "' To '" & ComboBox2.Text & "' And {tbl_HRM_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' "
                ElseIf SecBTn.Checked = True Then ' By Section 
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.GradeName} in '" & ComboBox1.Text & "' To '" & ComboBox2.Text & "' And {tbl_HRM_Emp_Info.DeptName}= '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Info.SectionName}= '" & SectionCodeComboBox.Text & "' "
                ElseIf DesigBtn.Checked = True Then ' By Designation 
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.GradeName} in '" & ComboBox1.Text & "' To '" & ComboBox2.Text & "' And {tbl_HRM_Emp_Info.Designame}= '" & DesigNameComboBox.Text & "'"
                End If
            End If
        End If




        If RadioButton2.Checked = True Then    '' Performance Apporisal FOrm Junior management
            Path = "" & frmLogin.ReportsPath & "\HR\RptAppraisalFormSuper.rpt"
            If Bycard.Checked = True Then ' By card Range 
                If AllBtn.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        flag = True

                    Else
                        flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                    'If TextBox1.Text = "" And TextBox2.Text = "" Then
                    '    MessageBox.Show("Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'End If

                ElseIf DepartmentBtn.Checked = True Then ' by Dept
                    If TextBox1.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then ' By Section 
                    If TextBox1.Text.Length = 0 Then
                        flag = True

                    Else
                        flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then 'By Desig 
                    If TextBox1.Text.Length = 0 Then
                        flag = True

                    Else
                        flag = False

                    End If

                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_HRM_Emp_Info.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bygrade.Checked = True Then
                flag = False
                If AllBtn.Checked = True Then ' by All Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.GradeName} in '" & ComboBox1.Text & "' To '" & ComboBox2.Text & "'"
                ElseIf DepartmentBtn.Checked = True Then ' by Main Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.GradeName} in '" & ComboBox1.Text & "' To '" & ComboBox2.Text & "' And {tbl_HRM_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' "
                ElseIf SecBTn.Checked = True Then ' By Section 
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.GradeName} in '" & ComboBox1.Text & "' To '" & ComboBox2.Text & "' And {tbl_HRM_Emp_Info.DeptName}= '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Info.SectionName}= '" & SectionCodeComboBox.Text & "' "
                ElseIf DesigBtn.Checked = True Then ' By Designation 
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Emp_Info.GradeName} in '" & ComboBox1.Text & "' To '" & ComboBox2.Text & "' And {tbl_HRM_Emp_Info.Designame}= '" & DesigNameComboBox.Text & "'"
                End If
            End If
        End If

        If flag = True Then
            MessageBox.Show("Start Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            flag = False
            Obj.LoadDeptReports(Path, Filter, Param)
        End If


    End Sub
    Dim flag As Boolean = False
    Private Sub DeptBtn_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True
        GradeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub GradeBtn_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = True
        ShiftNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub ShiftBtn_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = True
        JobTypeNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub JobTypeBtn_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = True
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub BranchBtn_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = True
    End Sub

    Private Sub SectionBtn_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
    End Sub



    Private Sub sectionbtn_CheckedChanged_1(sender As Object, e As EventArgs)
        AllBtn.Checked = True
        DepartmentBtn.Enabled = False
        SecBTn.Enabled = False
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub DesigBtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True



    End Sub

    Private Sub ShiftBtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles ShiftBtn.CheckedChanged
        AllBtn.Checked = True

        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = True
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False

        AllEmp.Checked = True
    End Sub

    Private Sub GradeBtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles GradeBtn.CheckedChanged
        AllBtn.Checked = True
        GradeNameComboBox.Enabled = True
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False



        AllEmp.Checked = True
    End Sub

    Private Sub BranchBtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles BranchBtn.CheckedChanged
        AllBtn.Checked = True
        BranchNameComboBox.Enabled = True
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False

        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False


        TextBox1.Enabled = False
        TextBox2.Enabled = False


        AllEmp.Checked = True

    End Sub

    Private Sub JobTypeBtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles JobTypeBtn.CheckedChanged
        AllBtn.Checked = True
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = True
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False

        AllEmp.Checked = True

    End Sub

    Private Sub DepartmentBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DepartmentBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False


    End Sub

    Private Sub SecBTn_CheckedChanged(sender As Object, e As EventArgs) Handles SecBTn.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False


    End Sub

    Private Sub AllBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AllBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub EmpBtn_CheckedChanged(sender As Object, e As EventArgs) Handles EmpBtn.CheckedChanged

        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False


        AllEmp.Checked = True
    End Sub

    Private Sub BGBtn_CheckedChanged(sender As Object, e As EventArgs) Handles BGBtn.CheckedChanged
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = True
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False

        AllEmp.Checked = True


    End Sub

    Private Sub MSBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MSBtn.CheckedChanged
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = True
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False

        AllEmp.Checked = True

    End Sub

    Private Sub Genderbtn_CheckedChanged(sender As Object, e As EventArgs) Handles Genderbtn.CheckedChanged
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = True
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False

        AllEmp.Checked = True

    End Sub

    Private Sub ReligBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ReligBtn.CheckedChanged
        AllEmp.Checked = True
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = True
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False


    End Sub

    Private Sub EmploymeyBtn_CheckedChanged(sender As Object, e As EventArgs) Handles EmploymeyBtn.CheckedChanged
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = True
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False
        AllEmp.Checked = True
    End Sub

    Private Sub EmpcatBtn_CheckedChanged(sender As Object, e As EventArgs) Handles EmpcatBtn.CheckedChanged
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = True
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False
        AllEmp.Checked = True
    End Sub

    Private Sub QualfBtn_CheckedChanged(sender As Object, e As EventArgs) Handles QualfBtn.CheckedChanged
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = True
        SectionCodeComboBox.Enabled = False

        AllBtn.Checked = True
        AllEmp.Checked = True
    End Sub

    Private Sub MissBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MissBtn.CheckedChanged

        GradeNameComboBox.Enabled = False
            JobTypeNameComboBox.Enabled = False
            ShiftNameComboBox.Enabled = False
            BranchNameComboBox.Enabled = False
            GenderComboBox.Enabled = False
            MaritalStatusComboBox.Enabled = False
            BloodGroupComboBox.Enabled = False
            ReligionComboBox.Enabled = False
            EmploymentNameComboBox.Enabled = False
            CatagoryNameComboBox.Enabled = False
            QualficationNameComboBox.Enabled = False
            SectionCodeComboBox.Enabled = False

    End Sub

    Private Sub SinBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SinBtn.CheckedChanged
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False
        AllEmp.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        AllEmp.Checked = True
        AllBtn.Checked = True
        If RadioButton1.Checked = True Then
            DepartmentBtn.Enabled = False
            SecBTn.Enabled = False
            DesigBtn.Enabled = False
        Else
            DepartmentBtn.Enabled = True
            SecBTn.Enabled = True
            DesigBtn.Enabled = True
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub PerBtn_CheckedChanged(sender As Object, e As EventArgs) Handles PerBtn.CheckedChanged


        SectionCodeComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False
        If PerBtn.Checked = True Then
            GroupBox1.Visible = True
            GroupBox3.Visible = True
            GroupBox4.Visible = False

        Else
            GroupBox1.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = True
        End If
    End Sub

    Private Sub Bygrade_CheckedChanged(sender As Object, e As EventArgs) Handles Bygrade.CheckedChanged
        If Bygrade.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        Else

            TextBox1.Enabled = True
            TextBox2.Enabled = True
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
        End If

    End Sub

    Private Sub ByBranch_CheckedChanged(sender As Object, e As EventArgs) Handles ByBranch.CheckedChanged

        BranchNameComboBox.Enabled = True

    End Sub

    Private Sub Bycard_CheckedChanged(sender As Object, e As EventArgs) Handles Bycard.CheckedChanged
        If Bygrade.Checked = True Then
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            ComboBox1.Enabled = True
            ComboBox2.Enabled = True
        Else

            TextBox1.Enabled = True
            TextBox2.Enabled = True
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub AllEmp_CheckedChanged(sender As Object, e As EventArgs) Handles AllEmp.CheckedChanged
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        SectionCodeComboBox.Enabled = False
        GradeNameComboBox.Enabled = False
        JobTypeNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
        BranchNameComboBox.Enabled = False
        GenderComboBox.Enabled = False
        MaritalStatusComboBox.Enabled = False
        BloodGroupComboBox.Enabled = False
        ReligionComboBox.Enabled = False
        EmploymentNameComboBox.Enabled = False
        CatagoryNameComboBox.Enabled = False
        QualficationNameComboBox.Enabled = False
        SectionCodeComboBox.Enabled = False
        If RadioButton2.Checked = True Then
            GroupBox1.Visible = True
            GroupBox3.Visible = True
            GroupBox4.Visible = False

        Else
            GroupBox1.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = True
        End If
    End Sub
End Class