Public Class frmAllowanceReports

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim Obj As New UtilityClass()
        Dim EmpStatus As String




        If AllowanceBtn.Checked = True Or DedBtn.Checked = True Or CantBtn.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} =True "
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} =False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = " {View_Rpt_Acc_PreSalary.CardNo} >0 "
            End If
        End If

        If AllowanceBtn.Checked = True Then

            If SPcAll.Checked = True Then '' Special Allowance
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptSpecialAll.rpt"
                If All.Checked = True Then
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal'  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And  {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@SpecialAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If


            ElseIf MealAll.Checked = True Then '' Meal Allowance
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\MealAllowance.rpt"
                If All.Checked = True Then
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By branch 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@MealAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If
            ElseIf TravelBtn.Checked = True Then '' Travel Allowance
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptTravalAll.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@TravelAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If
            ElseIf EduAll.Checked = True Then '' Education Allowance
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptEduAll.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@EduAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If
            ElseIf AccAllow.Checked = True Then '' Accomodation Allowance
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptAccAll.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@AccAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If
            ElseIf Sinrity.Checked = True Then '' Sinority  Allowance
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\SeniorityAllowanceRpt.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@SeniorityAllowance} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If
            End If



        End If

        If DedBtn.Checked = True Then
            If TxtBtn.Checked = True Then '' Tex Deduction
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptTaxDedd.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@TexDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If

            ElseIf RebtBtn.Checked = True Then '' Rent Deduction
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptRentDed.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@rentDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If
            ElseIf CantBtn.Checked = True Then '' Canteen Deduction
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptcanteenDed.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If


            ElseIf EOBIBTn.Checked = True Then '' EOBi Deduction
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\rptAccEOBIPayable.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState}  = 'Normal'  And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & "And  {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState}  = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & "And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState}  = 'Normal'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState}  = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState}  = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState}  = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "   And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "   And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "     And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "   And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@SalMon} = " & DateTimePicker1.Value.Month & " And {@SalYear} = " & DateTimePicker1.Value.Year & ""
                    End If

                End If


                ' Union Fund


            ElseIf RadioButton3.Checked = True Then '' UF Deduction
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptUFDed.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "And {@EOBIDed} > 0 And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {@EOBIDed} > 0 And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@EOBIDed} > 0 And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@EOBIDed} > 0 And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {@EOBIDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")"
                    End If

                End If

            ElseIf PESSiBTN.Checked = True Then '' PESSi Deduction
                Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\rptAccPESSI.rpt"
                If All.Checked = True Then ' All 
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                    End If

                ElseIf CrdRange.Checked = True Then ' By card range 
                    If RadioButton1.Checked = True Then ' All Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                        Else
                            Filter = EmpStatus & " And  {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                        End If

                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                        End If

                    ElseIf SectBtn.Checked = True Then ' Section

                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "     And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
                        End If

                    ElseIf DesigBtn.Checked = True Then ' Desig
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                        End If
                    End If
                ElseIf RadioButton2.Checked = True Then ' By Branch
                    Flag = False
                    If RadioButton1.Checked = True Then ' All Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0 "
                    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                    ElseIf DesigBtn.Checked = True Then ' Desig
                        Filter = EmpStatus & "  And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
                    End If

                End If
            End If
        End If
        If RadioButton4.Checked Then
            Flag = False

            Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptPESSIFormat.rpt"
            'If All.Checked = True Then ' All 
            '    Flag = False
            '    If RadioButton1.Checked = True Then ' All Dept
            Filter = "Year({View_Rpt_PESSI.SalaryMonth}) = " & DateTimePicker1.Value.Year & " and Month({View_Rpt_PESSI.SalaryMonth}) = " & DateTimePicker1.Value.Month & " "
            '    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
            '    ElseIf SectBtn.Checked = True Then ' Section 
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
            '    ElseIf DesigBtn.Checked = True Then ' Desig
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
            '    End If
            'End If

        End If

        If RadioButton5.Checked Then
            Flag = False

            Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptEOBIFormat.rpt"
            'If All.Checked = True Then ' All 
            '    Flag = False
            '    If RadioButton1.Checked = True Then ' All Dept
            Filter = "Year({View_Rpt_PESSI.SalaryMonth}) = " & DateTimePicker1.Value.Year & " and Month({View_Rpt_PESSI.SalaryMonth}) = " & DateTimePicker1.Value.Month & " "
            '    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
            '    ElseIf SectBtn.Checked = True Then ' Section 
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
            '    ElseIf DesigBtn.Checked = True Then ' Desig
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
            '    End If
            'End If

        End If

        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If

    End Sub
    Dim Flag As Boolean = False
    Private Sub AllowanceBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AllowanceBtn.CheckedChanged

        If AllowanceBtn.Checked = True Then
            Allowancepanel.Enabled = True
        Else
            Allowancepanel.Enabled = False
        End If
    End Sub

    Private Sub DedBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DedBtn.CheckedChanged
        If DedBtn.Checked = True Then
            Dedpanel.Enabled = True
        Else
            Dedpanel.Enabled = False
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub frmAllowanceReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)

    End Sub

    Private Sub Allowancepanel_Enter(sender As Object, e As EventArgs) Handles Allowancepanel.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CrdRange_CheckedChanged(sender As Object, e As EventArgs) Handles CrdRange.CheckedChanged
        If CrdRange.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False

        End If
        BranchNameComboBox.Enabled = False
    End Sub



    Private Sub MainDeptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MainDeptBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = False
        DesigComboBox.Enabled = False
    End Sub

    Private Sub SectBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SectBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = True
        DesigComboBox.Enabled = False
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        DesigComboBox.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        Me.DateTimePicker1.Enabled = True
    End Sub

    Private Sub All_CheckedChanged(sender As Object, e As EventArgs) Handles All.CheckedChanged
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DesigComboBox.Enabled = False
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

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

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        BranchNameComboBox.Enabled = True
    End Sub

    Private Sub SPcAll_CheckedChanged(sender As Object, e As EventArgs) Handles SPcAll.CheckedChanged

    End Sub

    Private Sub TxtBtn_CheckedChanged(sender As Object, e As EventArgs) Handles TxtBtn.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub
End Class