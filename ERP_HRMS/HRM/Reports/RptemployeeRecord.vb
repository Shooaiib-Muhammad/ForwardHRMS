Public Class RptemployeeRecord
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass

    Private Sub btnRptShow_Click(sender As Object, e As EventArgs) Handles btnRptShow.Click
        Dim EmpStatus As String
        If RadioButton1.Checked = True Or ChrBtn.Checked = True Or RadioButton10.Checked = True Or RadioButton9.Checked = True Or SalaryBtn.Checked = True Or RadioButton5.Checked = True Or RadioButton2.Checked = True Or CrdCPBTBtn.Checked = True Or RadioButton4.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{tbl_HRM_Emp_Info.EmpStatus} = True"
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{tbl_HRM_Emp_Info.EmpStatus} = False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{tbl_HRM_Emp_Info.CardNo} > 0 "
            End If
        ElseIf ExperBtn.Checked = True Or RadioButton3.Checked = True Or RadioButton7.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = True"
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.CardNo} > 0"
            End If
        ElseIf EmpBtn.Checked = True Or RadioButton8.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus} = True"
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus} = False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.CardNo} > 0"
            End If
        End If



        If RadioButton1.Checked = True Then
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpProfRpt.rpt"
            If AllButton.Checked = True Then ' All
                If AllDept.Checked = True Then ' All Dept
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " and{tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " and {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " and{tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " and {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then

                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " and{tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " and{tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " and{tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " and {tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "'  And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If







        If RadioButton7.Checked = True Then ''  Graduity Log report
            Path = "" & frmLogin.ReportsPath & "\HR\GraduityLogRpt.rpt"

            If AllButton.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf Bybranch.Checked = True Then

                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If

        End If






        If SalaryBtn.Checked = True Then '' Salary Log Reports

            Path = "" & frmLogin.ReportsPath & "\HR\EmpSalaryRpt.rpt"
            If AllButton.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.DesigID} = " & DesigNameComboBox.SelectedValue & ""

                End If
            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & "  And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & "  And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf Bybranch.Checked = True Then

                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If




        If RadioButton2.Checked = True Then  ' Tracking record 

            Path = "" & frmLogin.ReportsPath & "\HR\EmpTrackingRpt.rpt"

            If AllButton.Checked = True Then

                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf Bybranch.Checked = True Then

                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " and {tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " and {tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " and {tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And   {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " and {tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And    {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            End If
        End If



        If RadioButton3.Checked = True Then ' Dept Log 
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\DeptLogRpt.rpt"
            If AllButton.Checked = True Then

                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If

                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " and  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If

                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If
                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If

                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If
                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If



        If CrdCPBTBtn.Checked = True Then   ' Card Log Reports
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpCrdCLogRpt.rpt"
            If AllButton.Checked = True Then

                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If



        If RadioButton4.Checked = True Then   ' Grade Log reports
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\GradelogRpt.rpt"
            If AllButton.Checked = True Then

                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " and {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If

            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus

                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If


        If RadioButton5.Checked = True Then   ' Shift Log reports

            Path = "" & frmLogin.ReportsPath & "\HR\ShiftLogRpt.rpt"
            If AllButton.Checked = True Then

                If AllDept.Checked = True Then
                    Flag = False
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If


            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If







        If RadioButton9.Checked = True Then   ' Job Type Log reports
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\JobTypeLogRpt.rpt"
            If AllButton.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And   {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If

        End If





        If RadioButton10.Checked = True Then   ' Branch Log reports
            Path = "" & frmLogin.ReportsPath & "\HR\BrnchLogRpt.rpt"
            If AllButton.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If


        If ChrBtn.Checked = True Then     ' Character certificate 
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpCharCertRpt.rpt"
            If AllButton.Checked = True Then

                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " And{tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And{tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = true "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " And{tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " And{tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " And{tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If

        End If

        If RadioButton11.Checked = True Then    ' Appointment Form 
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\AppoinmentRpt.rpt"
            If AllButton.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True "
                ElseIf MainDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = "{tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And   {tbl_HRM_Emp_Info.EmpStatus} = true"
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = "{tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And {tbl_HRM_Emp_Info.EmpStatus} = true  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And  {tbl_HRM_Emp_Info.EmpStatus} = true And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{tbl_HRM_Branch.BranchName}= '" & BranchNameComboBox.Text & "' And  {tbl_HRM_Emp_Info.EmpStatus} = true  And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf SpecialBtn.Checked = True Then
                Flag = False
                Filter = "{tbl_HRM_Emp_Info.CardNo} In  [" & GetCardsInString() & "]"
                If AllButton.Checked = True Then
                    If AllDept.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                    ElseIf MainDept.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    ElseIf MainDeptandSection.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    ElseIf Deigantionbtn.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            End If

        End If



        If CardPrinting.Checked = True And Frontside.Checked = True Then
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpCrdFSRpt.rpt"
            If AllButton.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                ElseIf MainDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf SpecialBtn.Checked = True Then
                Flag = False
                Filter = "{tbl_HRM_Emp_Info.CardNo} In  [" & GetCardsInString() & "]"
                If AllButton.Checked = True Then
                    If AllDept.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                    ElseIf MainDept.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    ElseIf MainDeptandSection.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    ElseIf Deigantionbtn.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf Bybranch.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDept.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf RadioButton12.Checked = True Then
                Flag = False


                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Grade.GradeName} In  [" & GetGradeInString() & "] "
                ElseIf MainDept.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetGradeInString() & "]"
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetGradeInString() & "]"
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetGradeInString() & "]"
                End If

            End If
        End If



        If EmpBtn.Checked = True Then   ' Employee List 

            Path = "" & frmLogin.ReportsPath & "\HR\EmployeeList.rpt"

            If AllButton.Checked = True Then ' All Btn
                Flag = False
                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If


            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If



        If CardPrinting.Checked = True And BackSide.Checked = True Then ' Card printing Back Side 
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\EmpCrdBSRpt.rpt"
            If AllButton.Checked = True Then
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True  "
                ElseIf MainDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf SpecialBtn.Checked = True Then
                Flag = False
                'Filter = "{tbl_HRM_Emp_Info.CardNo} In  [" & GetCardsInString() & "]"
                Filter = "{tbl_HRM_Emp_Info.CardNo} In  [" & GetCardsInString() & "]"
                If AllButton.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                    If AllDept.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True"
                    ElseIf MainDept.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    ElseIf MainDeptandSection.Checked = True Then
                        Filter = " {tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    ElseIf Deigantionbtn.Checked = True Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " and {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf RadioButton12.Checked = True Then
                Flag = False


                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Grade.GradeName}  In  [" & GetGradeInString() & "] "
                ElseIf MainDept.Checked = True Then
                    Filter = " {tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetGradeInString() & "]"
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetGradeInString() & "]"
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetGradeInString() & "]"
                End If

            End If
        End If






        If ExperBtn.Checked = True Then '' Experiance Letter
            Path = "" & frmLogin.ReportsPath & "\HR\EmpExpLettrRpt.rpt"
            If AllButton.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then
                    Filter = EmpStatus

                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then

                If AllDept.Checked = True Then

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If

                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "{View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If







        If RadioButton6.Checked = True Then ' max Info Rpt
            Path = "" & frmLogin.ReportsPath & "\HR\RptEmpMexInfo.rpt"
            If AllButton.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo} > 0"

                ElseIf MainDept.Checked = True Then
                    Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then

                If AllDept.Checked = True Then

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If

                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "{View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = " {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If






        If RadioButton8.Checked = True Then '' Section Wise EMployee Count list 

            Path = "" & frmLogin.ReportsPath & "\HR\SectionWiseEmployeeList.rpt"

            If AllButton.Checked = True Then ' All Btn
                Flag = False
                If AllDept.Checked = True Then
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""

                End If


            ElseIf CardRange.Checked = True Then
                Filter = EmpStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf Bybranch.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If



        ''' termination letter 
        If RadioButton18.Checked = True Then ' termination List 
            Path = "" & frmLogin.ReportsPath & "\Accounts\Terminationletter.rpt"

            If CardRange.Checked = True Then ' Card Range 

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = "{View_Rpt_Acc_InActiveEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                Else
                    Filter = "{View_Rpt_Acc_InActiveEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If
            End If
        End If



        If Ntc.Checked = True Then   ' EMp Noticce Log reports
            Path = "" & frmLogin.ReportsPath & "\HR\EmpNoticLogRpt.rpt"
            If CardRange.Checked = True Then

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                Else
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If




            End If
        End If


        If RadioButton24.Checked = True Then
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\RptDispableperson.rpt"
            Filter = "{View_Rpt_HR_Info.CardNo} > 0"

        End If


        If RadioButton13.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\HR\permamenrletter.rpt"
            If CardRange.Checked = True Then

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} and  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                Else
                    Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} and {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If
            ElseIf SpecialBtn.Checked = True Then
                Flag = False
                Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In  [" & GetCardsInString() & "]"



            End If
        End If
        If RadioButton14.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\HR\serverletter.rpt"

            Param = "Date=" & Me.DateTimePicker2.Text & ""
            If CardRange.Checked = True Then

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                Else
                    Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If
            ElseIf SpecialBtn.Checked = True Then
                Flag = False
                Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In  [" & GetCardsInString() & "]"



            End If
        End If
        If RadioButton15.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\HR\marriagecase.rpt"
            If CardRange.Checked = True Then

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                Else
                    Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If
            ElseIf SpecialBtn.Checked = True Then
                Flag = False
                Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In  [" & GetCardsInString() & "]"



            End If
        End If
        If RadioButton17.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\HR\Deathgrant.rpt"
            If CardRange.Checked = True Then

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                Else
                    Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If
            ElseIf SpecialBtn.Checked = True Then
                Flag = False
                Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In  [" & GetCardsInString() & "]"



            End If
        End If

        If Flag = True Then
            MessageBox.Show("Start Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If

    End Sub
    Private Function GetCardsInString() As String
        Dim Str As String = ""
        For i As Integer = 0 To lstCards.Items.Count - 1
            If i = 0 Then
                Str = Str & lstCards.Items.Item(i).ToString()
            Else
                Str = Str & ", " & lstCards.Items.Item(i).ToString()
            End If
        Next
        Return Str
    End Function



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Tbl_HRM_DeptBindingNavigator1SaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_DeptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)

    End Sub
    Dim Flag As Boolean = False
    Private Sub RptemployeeRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Card' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_CardTableAdapter.Fill(Me.DSHRM.tbl_HRM_Card)


        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

    End Sub

    Private Sub CardRange_CheckedChanged(sender As Object, e As EventArgs) Handles CardRange.CheckedChanged
        AllDept.Checked = True
        BranchNameComboBox.Enabled = False
        DeptPanel.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        DeptPanel.Enabled = True
        GroupBox5.Enabled = False
        GroupBox4.Enabled = False
        If CardPrinting.Checked = True Then
            GroupBox4.Enabled = True
        End If

    End Sub

    Private Sub AllDept_CheckedChanged(sender As Object, e As EventArgs)
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        GroupBox5.Enabled = False
        GroupBox4.Enabled = False
        If CardPrinting.Checked = True Then
            GroupBox4.Enabled = True
        End If
    End Sub
    Private Function GetGradeInString() As String
        Dim Str As String = ""
        Dim Grade As String
        For i As Integer = 0 To ListBox1.Items.Count - 1
            If i = 0 Then
                Grade = "'" & ListBox1.Items.Item(i).ToString() & "'"
                Str = Str & Grade

            Else
                Grade = "'" & ListBox1.Items.Item(i).ToString() & "'"
                Str = Str & ", " & Grade
            End If
        Next
        Return Str
    End Function
    Private Sub MainDept_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        DesigNameComboBox.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        GroupBox5.Enabled = False
        GroupBox4.Enabled = False
        If CardPrinting.Checked = True Then
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub MainDeptandSection_CheckedChanged(sender As Object, e As EventArgs)
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        GroupBox5.Enabled = False
        GroupBox4.Enabled = False
        If CardPrinting.Checked = True Then
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub Deigantionbtn_CheckedChanged(sender As Object, e As EventArgs)
        DesigNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        DeptNameComboBox.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        GroupBox5.Enabled = False
        GroupBox4.Enabled = False
        If CardPrinting.Checked = True Then
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs)
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        DeptNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
        GroupBox5.Enabled = False
        GroupBox4.Enabled = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CardPrinting_CheckedChanged(sender As Object, e As EventArgs) Handles CardPrinting.CheckedChanged
        AllButton.Checked = True
        Frontside.Checked = True
        GroupBox4.Enabled = True
        GroupBox5.Enabled = False
        Bybranch.Enabled = True
        GroupBox6.Enabled = False

        If CardPrinting.Checked = True Then
            RadioButton12.Enabled = True
            SpecialBtn.Enabled = True
        Else
            RadioButton12.Enabled = False
            SpecialBtn.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbSelectCard.SelectedIndex >= 0 Then
            lstCards.Items.Add(cmbSelectCard.SelectedValue)
            lstCards.SelectedIndex = lstCards.Items.Count - 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lstCards.Items.Count > 0 Then
            If lstCards.SelectedIndex >= 0 Then
                lstCards.Items.RemoveAt(lstCards.SelectedIndex)
                lstCards.SelectedIndex = lstCards.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles SpecialBtn.CheckedChanged
        Me.AcceptButton = Button1
        BranchNameComboBox.Enabled = False
        DeptPanel.Enabled = False
        GroupBox5.Enabled = True
        'DeptPanel.Enabled = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        If CardPrinting.Checked = True Then
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        GroupBox4.Enabled = False
        Bybranch.Enabled = True
        GroupBox6.Enabled = False
        If RadioButton11.Checked = True Then

            SpecialBtn.Enabled = True
        Else

            SpecialBtn.Enabled = False
        End If
    End Sub



    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        GroupBox4.Enabled = False
        Bybranch.Enabled = True
        SpecialBtn.Enabled = False
        GroupBox6.Enabled = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        GroupBox4.Enabled = False
        SpecialBtn.Enabled = False
        Bybranch.Enabled = True
        GroupBox6.Enabled = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        GroupBox4.Enabled = False
        SpecialBtn.Enabled = False
        Bybranch.Enabled = True
        GroupBox6.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        GroupBox4.Enabled = False
        SpecialBtn.Enabled = False
        Bybranch.Enabled = True
        GroupBox6.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GroupBox4.Enabled = False
        SpecialBtn.Enabled = False
        Bybranch.Enabled = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox4.Enabled = False
        SpecialBtn.Enabled = False
        Bybranch.Enabled = True
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub CnclBtn_Click(sender As Object, e As EventArgs)
        cmbSelectCard.SelectedValue = DBNull.Value



    End Sub

    Private Sub ChrBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ChrBtn.CheckedChanged
        If ChrBtn.Checked = True Then
            GroupBox4.Enabled = False


        Else
            GroupBox4.Enabled = False



        End If
        GroupBox6.Enabled = True
        Bybranch.Enabled = True
        SpecialBtn.Enabled = False
    End Sub

    Private Sub MainDept_CheckedChanged_1(sender As Object, e As EventArgs) Handles MainDept.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub AllDept_CheckedChanged_1(sender As Object, e As EventArgs) Handles AllDept.CheckedChanged
        If AllButton.Checked = True And Bybranch.Checked = True Then
            BranchNameComboBox.Enabled = True
        ElseIf MainDept.Checked = True And Bybranch.Checked = True Then
            BranchNameComboBox.Enabled = True
        ElseIf MainDeptandSection.Checked = True And Bybranch.Checked = True Then
            BranchNameComboBox.Enabled = True
        ElseIf Deigantionbtn.Checked = True And Bybranch.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False

        End If


        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub Deigantionbtn_CheckedChanged_1(sender As Object, e As EventArgs) Handles Deigantionbtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True
    End Sub

    Private Sub MainDeptandSection_CheckedChanged_1(sender As Object, e As EventArgs) Handles MainDeptandSection.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles AllButton.CheckedChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        DeptPanel.Enabled = True
        DeptPanel.Enabled = True
        TextBox1.Clear()
        TextBox2.Clear()
        AllDept.Checked = True
        If CardPrinting.Checked = True Then
            GroupBox4.Enabled = True
        End If
        GroupBox5.Enabled = False
        BranchNameComboBox.Enabled = False

    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub CrdCPBTBtn_CheckedChanged(sender As Object, e As EventArgs) Handles CrdCPBTBtn.CheckedChanged
        GroupBox4.Enabled = False
        SpecialBtn.Enabled = False



        GroupBox6.Enabled = True

        Bybranch.Enabled = True

    End Sub

    Private Sub Bybranch_CheckedChanged(sender As Object, e As EventArgs) Handles Bybranch.CheckedChanged
        AllDept.Checked = True
        GroupBox5.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        BranchNameComboBox.Enabled = True
        DeptPanel.Enabled = True

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Bybranch.Enabled = True
        SpecialBtn.Enabled = False
        GroupBox6.Enabled = True
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        SpecialBtn.Enabled = False
        GroupBox6.Enabled = False
        If RadioButton18.Checked = True Then
            AllButton.Enabled = False
            MainDept.Enabled = False
            MainDeptandSection.Enabled = False
            Deigantionbtn.Enabled = False
            Bybranch.Enabled = False
            CardRange.Enabled = True
            CardRange.Checked = True
        Else
            AllButton.Enabled = True
            AllButton.Checked = True
            MainDept.Enabled = True
            MainDeptandSection.Enabled = True
            Deigantionbtn.Enabled = True
            CardRange.Enabled = True
            DeptPanel.Enabled = True
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Bybranch.Enabled = True
        SpecialBtn.Enabled = False
        GroupBox6.Enabled = False
    End Sub

    Private Sub EmpBtn_CheckedChanged(sender As Object, e As EventArgs) Handles EmpBtn.CheckedChanged
        Bybranch.Enabled = True
        SpecialBtn.Enabled = False
        GroupBox6.Enabled = True
    End Sub

    Private Sub ExperBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ExperBtn.CheckedChanged
        Bybranch.Enabled = True
        SpecialBtn.Enabled = False
        GroupBox6.Enabled = True
    End Sub

    Private Sub SalaryBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SalaryBtn.CheckedChanged
        Bybranch.Enabled = True
        SpecialBtn.Enabled = False
        GroupBox6.Enabled = True
    End Sub

    Private Sub cmbSelectCard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectCard.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        GroupBox6.Enabled = True
    End Sub

    Private Sub Ntc_CheckedChanged(sender As Object, e As EventArgs) Handles Ntc.CheckedChanged
        If Ntc.Checked = True Then
            AllButton.Enabled = False
            SpecialBtn.Enabled = False
            Bybranch.Enabled = False
            MainDept.Enabled = False
            MainDeptandSection.Enabled = False
            Deigantionbtn.Enabled = False
            CardRange.Checked = True
        Else
            AllButton.Enabled = True
            SpecialBtn.Enabled = True
            Bybranch.Enabled = True
            MainDept.Enabled = True
            MainDeptandSection.Enabled = True
            Deigantionbtn.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox1.SelectedIndex >= 0 Then
            ListBox1.Items.Add(ComboBox1.SelectedValue)
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.Items.Count > 0 Then
            If ListBox1.SelectedIndex >= 0 Then
                ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            GroupBox5.Visible = False
            GroupBox7.Visible = True
        Else
            GroupBox5.Visible = True
            GroupBox7.Visible = False
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked = True Then
            GroupBox2.Enabled = False

            DeptPanel.Enabled = False
            GroupBox3.Enabled = False
        Else
            GroupBox2.Enabled = True

            DeptPanel.Enabled = True
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            CardRange.Checked = True
            SpecialBtn.Enabled = True
        Else
            SpecialBtn.Enabled = False
            CardRange.Checked = False
            AllButton.Checked = True
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            CardRange.Checked = True
            SpecialBtn.Enabled = True
            DateTimePicker2.Visible = True
            Label12.Visible = True
        Else
            SpecialBtn.Enabled = False
            CardRange.Checked = False
            AllButton.Checked = True
            DateTimePicker2.Visible = False
            Label12.Visible = True
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            CardRange.Checked = True
            SpecialBtn.Enabled = True
        Else
            SpecialBtn.Enabled = False
            CardRange.Checked = False
            AllButton.Checked = True
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            CardRange.Checked = True
            SpecialBtn.Enabled = True
            DateTimePicker2.Visible = True
            Label12.Visible = True
        Else
            SpecialBtn.Enabled = False
            CardRange.Checked = False
            AllButton.Checked = True
            DateTimePicker2.Visible = False
            Label12.Visible = True
        End If
    End Sub
End Class