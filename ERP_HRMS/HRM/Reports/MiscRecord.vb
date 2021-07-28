Public Class MiscRecord
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Dim EmpStatus As String
    Private Sub btnRptShow_Click(sender As Object, e As EventArgs) Handles btnRptShow.Click




        If EOBiEmpBtn.Checked = True Or PESSIEmpBtn.Checked = True Or UnionBtn.Checked = True Or SalarySlipBTn.Checked = True Or SalaryRecivingBtn.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = " {View_Rpt_Acc_PreSalary.EmpStatus}= True "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = " {View_Rpt_Acc_PreSalary.EmpStatus}= False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = " {View_Rpt_Acc_PreSalary.cardno} > 0 "
            End If

        End If


        If RadioButton7.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = " {tbl_HRM_Emp_Info.EmpStatus}= True "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = " {tbl_HRM_Emp_Info.EmpStatus}= False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = " {tbl_HRM_Emp_Info.cardno} > 0 "
            End If
        End If

        If RadioButton10.Checked = True Then

            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Union_OT_Calc.EmpStatus} = True "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Union_OT_Calc.EmpStatus} = False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Union_OT_Calc.CardNo} > 0"
            End If
        End If

        If PESSIEmpBtn.Checked = True Then ' EMp PESSI COnt

            Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\rptAccPESSI.rpt"
            If RadioButton1.Checked = True Then '' All Btn 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  "
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' "
                    Else
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' "
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'  And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " "
                    Else
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' "
                    Else
                        Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' "
                    End If
                End If
            ElseIf RadioButton6.Checked = True Then ' By Branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                End If
            End If
        End If

        If RadioButton13.Checked = True Then
            If Label3.Text = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\RptEOBINew.rpt"
            Else
                Path = "" & frmLogin.ReportsPath & "\HR\RptEOBI.rpt"
            End If
            If TextBox1.Text.Length = 0 Then
                Flag = True
            Else
                Flag = False
            End If
            If TextBox2.Text = "" Then
                Filter = " {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} ='" & FinancialPeriodComboBox.Text & "' And {tbl_Hrm_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & ""
            Else
                Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} ='" & FinancialPeriodComboBox.Text & "' And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
            End If

        End If

        If EOBIEmp.Checked = True Then 'EMployee  EOBI List 


            Path = "" & frmLogin.ReportsPath & "\HR\RptEOBIEmpList.rpt"
            Flag = False
            If RadioButton1.Checked = True Then '' All Btn 
                If AllBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true  And {View_Rpt_Emp_List.DesigID} =" & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And { View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Emp_List.Designame} = '" & DesigNameComboBox.Text & "'"
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.Designame} = '" & DesigNameComboBox.Text & "'"
                    End If
                End If
            ElseIf RadioButton6.Checked = True
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Rpt_Emp_List.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Rpt_Emp_List.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If



        If pendEOBICrd.Checked = True Then 'EMployee  EOBI List 
            Flag = False

            Path = "" & frmLogin.ReportsPath & "\HR\InActiveEOBICard.rpt"
            If RadioButton1.Checked = True Then '' All Btn 
                If AllBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true  And {View_Rpt_Emp_List.DesigID} =" & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Emp_List.empstatus} = true and {View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{View_Rpt_Emp_List.empstatus} = true and {View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.empstatus} = true and  {View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.empstatus} = true and {View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And { View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.empstatus} = true and  {View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Emp_List.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.empstatus} = true and  {View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf RadioButton6.Checked = True ' By branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true and  {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empstatus} = true and  {View_Rpt_Emp_List.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Rpt_Emp_List.empstatus} = true and  {View_Rpt_Emp_List.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Rpt_Emp_List.empstatus} = true and  {View_Rpt_Emp_List.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If




        'If EOBIEmp.Checked = True Then 'COntracts  EOBI List 


        '    Path = "" & frmLogin.ReportsPath & "\HR\RptEOBIEmpList.rpt"
        '    Flag = False
        '    If RadioButton1.Checked = True Then '' All Btn 
        '        If AllBtn.Checked = True Then
        '            Filter = "{View_Rpt_Emp_List.ETID} = 2"
        '        ElseIf DepartmentBtn.Checked = True Then
        '            Filter = "{View_Rpt_Emp_List.ETID} = 2 And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
        '        ElseIf SecBTn.Checked = True Then
        '            Filter = "{View_Rpt_Emp_List.ETID} = 2 And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = "{View_Rpt_Emp_List.ETID} = 2  And {View_Rpt_Emp_List.DesigID} =" & DesigNameComboBox.SelectedValue & ""
        '        End If
        '    ElseIf RadioButton3.Checked = True Then ' By card range

        '        If AllBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False
        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
        '            Else
        '                Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
        '            End If

        '        ElseIf DepartmentBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False
        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
        '            Else
        '                Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
        '            End If

        '        ElseIf SecBTn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False

        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And { View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
        '            Else
        '                Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
        '            End If

        '        ElseIf DesigBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False

        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Emp_List.DesigID} = " & DesigNameComboBox.SelectedValue & ""
        '            Else
        '                Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DesigID} = " & DesigNameComboBox.SelectedValue & ""
        '            End If
        '        End If
        '    ElseIf RadioButton6.Checked = True
        '        Flag = False
        '        If AllBtn.Checked = True Then
        '            Filter = "{View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
        '        ElseIf DepartmentBtn.Checked = True Then
        '            Filter = "{View_Rpt_Emp_List.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
        '        ElseIf SecBTn.Checked = True Then
        '            Filter = " {View_Rpt_Emp_List.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Emp_List.SubDept1ID} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = " {View_Rpt_Emp_List.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Emp_List.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
        '        End If
        '    End If
        'End If



        If EOBiEmpBtn.Checked = True Then ' EMp EOBI CONT


            Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\rptAccEOBIPayable.rpt"
            If RadioButton1.Checked = True Then '' All Btn 
                Flag = False

                If AllBtn.Checked = True Then
                    Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & "And {@SalYear} = " & Me.Bymonth.Value.Year & ""

                ElseIf DepartmentBtn.Checked = True Then
                    Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & "And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.deptname} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBTn.Checked = True Then
                    Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & "And {@SalYear} = " & Me.Bymonth.Value.Year & "  And {View_Rpt_Acc_PreSalary.deptname} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & "And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.designame} = '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' "
                    Else
                        Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' "
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'  And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'"
                    Else
                        Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'"
                    Else
                        Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' "
                    End If
                End If
            ElseIf RadioButton6.Checked = True Then ' By Branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And{View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {@SalMon} = " & Me.Bymonth.Value.Month & " And {@SalYear} = " & Me.Bymonth.Value.Year & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If









        'If PESSIEmpBtn.Checked = True Then ' COntractors PESSI COnt
        '    Flag = False

        '    Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\rptAccPESSI.rpt"
        '    If RadioButton1.Checked = True Then '' All Btn 

        '        If AllBtn.Checked = True Then
        '            Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0 "
        '        ElseIf DepartmentBtn.Checked = True Then
        '            Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '        ElseIf SecBTn.Checked = True Then
        '            Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0 "
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '        End If
        '    ElseIf RadioButton3.Checked = True Then ' By card range

        '        If AllBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False
        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '            Else
        '                Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '            End If

        '        ElseIf DepartmentBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False
        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '            Else
        '                Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '            End If

        '        ElseIf SecBTn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False

        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'  And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '            Else
        '                Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '            End If

        '        ElseIf DesigBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False

        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '            Else
        '                Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '            End If
        '        End If
        '    ElseIf RadioButton6.Checked = True Then ' By Branch 
        '        Flag = False
        '        If AllBtn.Checked = True Then
        '            Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And{View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '        ElseIf DepartmentBtn.Checked = True Then
        '            Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '        ElseIf SecBTn.Checked = True Then
        '            Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTran}) = " & Bymonth.Value.Month & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.PessiContribution} > 0"
        '        End If
        '    End If
        'End If


        'If EOBiEmpBtn.Checked = True Then ' COntractors EOBI CONT


        '    Path = "" & frmLogin.ReportsPath & "\HR\rptAccContEOBI.rpt"
        '    If RadioButton1.Checked = True Then '' All Btn 
        '        Flag = False
        '    End If
        '    If AllBtn.Checked = True Then
        '        Filter = "{View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.Bymonth.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.Bymonth.Value, "MM")
        '    ElseIf DepartmentBtn.Checked = True Then
        '        Filter = "{View_Rpt_HR_ContractualEmp.DeptNAme} = '" & DeptNameComboBox.Text & "'"
        '    ElseIf SecBTn.Checked = True Then
        '        Filter = "{View_Rpt_HR_ContractualEmp.DeptNAme} = '" & DeptNameComboBox.Text & "' And {View_Rpt_HR_ContractualEmp.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
        '    ElseIf DesigBtn.Checked = True Then
        '        Filter = "{View_Rpt_HR_ContractualEmp.DesigID} =" & DesigNameComboBox.SelectedValue & ""
        '    End If
        'ElseIf RadioButton3.Checked = True Then ' By crad Range 
        'ElseIf RadioButton6.Checked = True Then ' By Branch
        'End If



        If PESSIlistBtn.Checked = True Then '  EMployee Pessi List


            Path = "" & frmLogin.ReportsPath & "\HR\EmpPESSiList.rpt"
            If RadioButton1.Checked = True Then '' All Btn    

                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.empstatus} = true And {View_Inactive_PESSi_Status.ETID} = 1"

                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.empstatus} = true And {View_Inactive_PESSi_Status.ETID} = 1 And {View_Inactive_PESSi_Status.DeptNAme} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.empstatus} = true And {View_Inactive_PESSi_Status.ETID} = 1 And {View_Inactive_PESSi_Status.DeptNAme} = '" & DeptNameComboBox.Text & "' And {View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.empstatus} = true And {View_Inactive_PESSi_Status.ETID} = 1 And {View_Inactive_PESSi_Status.DesigID} =" & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Inactive_PESSi_Status.empstatus} = true and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{View_Inactive_PESSi_Status.empstatus} = true and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Inactive_PESSi_Status.empstatus} = true and  {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Inactive_PESSi_Status.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Inactive_PESSi_Status.empstatus} = true and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Inactive_PESSi_Status.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Inactive_PESSi_Status.empstatus} = true and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Inactive_PESSi_Status.DeptID} = " & DeptNameComboBox.SelectedValue & " And { View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Inactive_PESSi_Status.empstatus} = true and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Inactive_PESSi_Status.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Inactive_PESSi_Status.empstatus} = true and  {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Inactive_PESSi_Status.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Inactive_PESSi_Status.empstatus} = true and  {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Inactive_PESSi_Status.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf RadioButton6.Checked = True ' By branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.empstatus} = true and  {View_Inactive_PESSi_Status.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.empstatus} = true and  {View_Inactive_PESSi_Status.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Inactive_PESSi_Status.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Inactive_PESSi_Status.empstatus} = true and  {View_Inactive_PESSi_Status.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Inactive_PESSi_Status.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Inactive_PESSi_Status.empstatus} = true and  {View_Inactive_PESSi_Status.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Inactive_PESSi_Status.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If


        'If PESSIlistBtn.Checked = True Then '  Contractors Pessi List


        '    Path = "" & frmLogin.ReportsPath & "\HR\EmpPESSiList.rpt"
        '    If RadioButton1.Checked = True Then '' All Btn 
        '        Flag = False

        '        If AllBtn.Checked = True Then
        '            Filter = "{View_Inactive_PESSi_Status.ETID} = 2"

        '        ElseIf DepartmentBtn.Checked = True Then
        '            Filter = "{View_Inactive_PESSi_Status.ETID} = 2 And {View_Inactive_PESSi_Status.DeptNAme} = '" & DeptNameComboBox.Text & "'"
        '        ElseIf SecBTn.Checked = True Then
        '            Filter = "{View_Inactive_PESSi_Status.ETID} = 2 And {View_Inactive_PESSi_Status.DeptNAme} = '" & DeptNameComboBox.Text & "' And {View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = "{View_Inactive_PESSi_Status.ETID} = 2 And {View_Inactive_PESSi_Status.DesigID} =" & DesigNameComboBox.SelectedValue & ""
        '        End If
        '    ElseIf RadioButton3.Checked = True Then ' By crad Range 
        '    ElseIf RadioButton6.Checked = True Then ' By Branch
        '    End If
        'End If


        If InAcvtivePESSi.Checked = True Then ' EMployee Inactive Pessi Status


            Path = "" & frmLogin.ReportsPath & "\HR\InactivePESSi.rpt"
            Flag = False
            If RadioButton1.Checked = True Then '' All Btn 
                If AllBtn.Checked = True Then
                    'Filter = "{View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.Bymonth.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.Bymonth.Value, "MM")
                    Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false And  {View_Inactive_PESSi_Status.ETID} = 1"

                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false And  {View_Inactive_PESSi_Status.ETID} = 1 And  {View_Inactive_PESSi_Status.DeptNAme} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false And {View_Inactive_PESSi_Status.ETID} = 1 And  {View_Inactive_PESSi_Status.DeptNAme} = '" & DeptNameComboBox.Text & "' And {View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false And {View_Inactive_PESSi_Status.ETID} = 1 And  {View_Inactive_PESSi_Status.DesigID} =" & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Inactive_PESSi_Status.PESSiCOnt} = false and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and  {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Inactive_PESSi_Status.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Inactive_PESSi_Status.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Inactive_PESSi_Status.DeptID} = " & DeptNameComboBox.SelectedValue & " And { View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Inactive_PESSi_Status.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and  {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Inactive_PESSi_Status.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and  {View_Inactive_PESSi_Status.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Inactive_PESSi_Status.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf RadioButton6.Checked = True ' By branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and  {View_Inactive_PESSi_Status.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false and  {View_Inactive_PESSi_Status.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Inactive_PESSi_Status.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Inactive_PESSi_Status.PESSiCOnt} = false and  {View_Inactive_PESSi_Status.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Inactive_PESSi_Status.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Inactive_PESSi_Status.PESSiCOnt} = false and  {View_Inactive_PESSi_Status.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Inactive_PESSi_Status.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If


        'If InAcvtivePESSi.Checked = True Then ' COntracors Inactive Pessi Status
        '    Flag = False

        '    Path = "" & frmLogin.ReportsPath & "\HR\InactivePESSi.rpt"
        '    If RadioButton1.Checked = True Then '' All Btn 
        '        If AllBtn.Checked = True Then
        '            'Filter = "{View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.Bymonth.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.Bymonth.Value, "MM")
        '            Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false And {View_Inactive_PESSi_Status.ETID} = 2"

        '        ElseIf DepartmentBtn.Checked = True Then
        '            Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false And {View_Inactive_PESSi_Status.ETID} = 2 And {View_Inactive_PESSi_Status.DeptNAme} = '" & DeptNameComboBox.Text & "'"
        '        ElseIf SecBTn.Checked = True Then
        '            Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false And {View_Inactive_PESSi_Status.ETID} = 2  and  {View_Inactive_PESSi_Status.DeptNAme} = '" & DeptNameComboBox.Text & "' And {View_Inactive_PESSi_Status.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = "{View_Inactive_PESSi_Status.PESSiCOnt} = false And {View_Inactive_PESSi_Status.ETID} = 2 And  {View_Inactive_PESSi_Status.DesigID} =" & DesigNameComboBox.SelectedValue & ""
        '        End If
        '    ElseIf RadioButton3.Checked = True Then ' By crad Range 
        '    ElseIf RadioButton6.Checked = True Then ' By Branch
        '    End If
        'End If


        'If pendEOBICrd.Checked = True Then    ' Pending EOBI Card 
        '    Flag = False
        '    
        '        Path = "" & frmLogin.ReportsPath & "\HR\InActiveEOBICard.rpt"
        '        If AllBtn.Checked = True Then
        '            Filter = "{View_Pending_EOBI_card.EmpStatus} = True"

        '        ElseIf DepartmentBtn.Checked = True Then
        '            Filter = "{View_Pending_EOBI_card.EmpStatus} = True And {View_Pending_EOBI_card.DeptName} = '" & DeptNameComboBox.Text & "'"
        '        ElseIf SecBTn.Checked = True Then
        '            Filter = "{View_Pending_EOBI_card.EmpStatus} = True And {View_Pending_EOBI_card.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Pending_EOBI_card.SectionName} = '" & SectionNameComboBox.Text & "'"
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = "{View_Pending_EOBI_card.EmpStatus} = True And {View_Pending_EOBI_card.DesigName} ='" & DesigNameComboBox.Text & "'"
        '        End If
        '    End If
        'End If







        If UnionBtn.Checked = True Then ' union fund 
            Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptUFDed.rpt"
            If RadioButton1.Checked = True Then '' All Btn 
                Flag = False
                If AllBtn.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ")"
                ElseIf DepartmentBtn.Checked = True Then ' Main Dept 
                    Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ")"
                ElseIf SecBTn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And  {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ")"
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ")"
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And { View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf RadioButton6.Checked = True ' By branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and  {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {@UFDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & Bymonth.Value.Year & ") and  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If






        If RejoiningBtn.Checked = True Then ' Rejoning List 
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\RptEmpRejoining.rpt"
            If RadioButton1.Checked = True Then '' All Btn 
                If AllBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_Rejoining.EmpStatus} = True"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_Rejoining.EmpStatus} = True And {View_Rpt_Emp_Rejoining.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Rpt_Emp_Rejoining.EmpStatus} = True And {View_Rpt_Emp_Rejoining.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Rejoining.SubDept1} = '" & SectionNameComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_Rejoining.EmpStatus} = True And {View_Rpt_Emp_Rejoining.DesigName} ='" & DesigNameComboBox.Text & "'"
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Emp_Rejoining.empstatus} = true and {View_Rpt_Emp_Rejoining.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{View_Rpt_Emp_Rejoining.empstatus} = true and {View_Rpt_Emp_Rejoining.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_Rejoining.empstatus} = true and  {View_Rpt_Emp_Rejoining.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Emp_Rejoining.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_Rejoining.empstatus} = true and {View_Rpt_Emp_Rejoining.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Emp_Rejoining.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_Rejoining.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Emp_Rejoining.DeptID} = " & DeptNameComboBox.SelectedValue & " And { View_Rpt_Emp_Rejoining.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_Rejoining.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_Rejoining.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_Rejoining.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_Rejoining.empstatus} = true and  {View_Rpt_Emp_Rejoining.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Emp_Rejoining.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_Rejoining.empstatus} = true and  {View_Rpt_Emp_Rejoining.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_Rejoining.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf RadioButton6.Checked = True ' By branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_Rejoining.empstatus} = true and  {View_Rpt_Emp_Rejoining.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_Rejoining.empstatus} = true and  {View_Rpt_Emp_Rejoining.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Rejoining.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Rpt_Emp_Rejoining.empstatus} = true and  {View_Rpt_Emp_Rejoining.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Emp_Rejoining.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Emp_Rejoining.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Rpt_Emp_Rejoining.empstatus} = true and  {View_Rpt_Emp_Rejoining.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Emp_Rejoining.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If

        If ASSCNO.Checked = True Then ' Active Social Security 

            Path = "" & frmLogin.ReportsPath & "\HR\ActiveSSCNO.rpt"

            If RadioButton1.Checked = True Then '' All Btn 
                Flag = False

                If AllBtn.Checked = True Then
                Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.SCLength} > 0"
            ElseIf DepartmentBtn.Checked = True Then
                Filter = "{View_Active_SSCNO.EmpStatus} = True And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' and {View_Active_SSCNO.SCLength} > 0"
            ElseIf SecBTn.Checked = True Then
                Filter = "{View_Active_SSCNO.EmpStatus} = True And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
            ElseIf DesigBtn.Checked = True Then
                Filter = "{View_Active_SSCNO.EmpStatus} = True And {View_Active_SSCNO.DesignationID} =" & DesigNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
            End If
        ElseIf RadioButton3.Checked = True Then ' By card range

            If AllBtn.Checked = True Then
                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                        Filter = " {View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " and {View_Active_SSCNO.SCLength} > 0"
                    Else
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " and {View_Active_SSCNO.SCLength} > 0"
                    End If

            ElseIf DepartmentBtn.Checked = True Then
                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {Tbl_Hrm_dept.DeptID} = " & DeptNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
                    Else
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {Tbl_Hrm_dept.DeptID} = " & DeptNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
                    End If

            ElseIf SecBTn.Checked = True Then
                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False

                End If
                If TextBox2.Text = "" Then
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
                    Else
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
                    End If

            ElseIf DesigBtn.Checked = True Then
                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False

                End If
                If TextBox2.Text = "" Then
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Active_SSCNO.DesignationID} =" & DesigNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
                    Else
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Active_SSCNO.DesignationID} =" & DesigNameComboBox.SelectedValue & "and {View_Active_SSCNO.SCLength} > 0"
                    End If
            End If
        ElseIf RadioButton6.Checked = True ' By branch 
            Flag = False
            If AllBtn.Checked = True Then
                    Filter = "{View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Active_SSCNO.EmpStatus} = True And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0 And {View_Active_SSCNO.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0 "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Active_SSCNO.EmpStatus} = True and  {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Active_SSCNO.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.DesignationID} =" & DesigNameComboBox.SelectedValue & "  And {View_Active_SSCNO.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " and {View_Active_SSCNO.SCLength} > 0"
                End If
        End If
        End If


        If PSSCNO.Checked = True Then ' Pending Social Security Cards 

            Path = "" & frmLogin.ReportsPath & "\HR\NonActiveSSCNO.rpt"
            If RadioButton1.Checked = True Then '' All Btn 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Active_SSCNO.EmpStatus} = True"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Active_SSCNO.EmpStatus} = True And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Active_SSCNO.EmpStatus} = True And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Active_SSCNO.EmpStatus} = True And {View_Active_SSCNO.DesignationID} =" & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Active_SSCNO.EmpStatus} = True  and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & ""
                    Else
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {Tbl_Hrm_dept.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                    Else
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {Tbl_Hrm_dept.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Active_SSCNO.DesignationID} =" & DesigNameComboBox.SelectedValue & " "
                    Else
                        Filter = "{View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Active_SSCNO.DesignationID} =" & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf RadioButton6.Checked = True ' By branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Active_SSCNO.EmpStatus} = True And {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Active_SSCNO.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Active_SSCNO.EmpStatus} = True and  {Tbl_Hrm_dept.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Active_SSCNO.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Active_SSCNO.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Active_SSCNO.EmpStatus} = True and  {View_Active_SSCNO.DesignationID} =" & DesigNameComboBox.SelectedValue & "  And {View_Active_SSCNO.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If



        If RadioButton9.Checked = True Then ' Insurance List 

            Path = "" & frmLogin.ReportsPath & "\Accounts\RptEmpList4Insurance.rpt"
            If RadioButton1.Checked = True Then ' All EMp
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empStatus} = True"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DesigID} = " & DesigNameComboBox.SelectedValue & " "
                End If
            ElseIf RadioButton2.Checked = True Then ' By date Of Joining
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empStatus} = True And {View_Rpt_Emp_List.DOJ} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DOJ} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") "
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DOJ} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") "
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DOJ} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Emp_List.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If



            End If
        End If






        ''' Insurance Removal List 

        If RadioButton4.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\insurRemovList.rpt"
            If RadioButton1.Checked = True Then ' All EMp
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "  {View_Rpt_Acc_AllEmployees.empStatus} = False"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " "
                End If
            ElseIf RadioButton2.Checked = True Then ' By Termination date 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "  {tbl_Acc_Termination_Transactions.TerminationDate} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "  {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_Termination_Transactions.TerminationDate} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                ElseIf SecBTn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {tbl_Acc_Termination_Transactions.TerminationDate} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_Termination_Transactions.TerminationDate} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")"
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If
            End If
        End If


        '' Annual Leaves Dues for Selected Month

        If RadioButton5.Checked = True Then
            Param = "@MyYear=" & Bymonth.Value.Year & "&@MyMonth=" & Bymonth.Value.Month
            Path = "" & frmLogin.ReportsPath & "\HR\rptAnnualLeavesDue.rpt"
            If RadioButton1.Checked = True Then ' All EMp
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{spAnnualLeavesDue;1.Cardno} > 0"
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' And  {spAnnualLeavesDue;1.SectionName} = '" & SectionNameComboBox.Text & "'  "
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {spAnnualLeavesDue;1.Designame} = '" & DesigNameComboBox.Text & "' "
                End If

            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' "
                    Else
                        Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' "
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "'  And {spAnnualLeavesDue;1.SectionName} = '" & SectionNameComboBox.Text & "'"
                    Else
                        Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "'   And {spAnnualLeavesDue;1.SectionName} = '" & SectionNameComboBox.Text & "' "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {spAnnualLeavesDue;1.Designame} = '" & DesigNameComboBox.Text & "'"
                    Else
                        Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {spAnnualLeavesDue;1.Designame} = '" & DesigNameComboBox.Text & "' "
                    End If
                End If
            ElseIf RadioButton6.Checked = True Then ' By Branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = "{spAnnualLeavesDue;1.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' And {spAnnualLeavesDue;1.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' And  {spAnnualLeavesDue;1.SectionName} = '" & SectionNameComboBox.Text & "' And {spAnnualLeavesDue;1.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = " {spAnnualLeavesDue;1.Designame} = '" & DesigNameComboBox.Text & "'  And {spAnnualLeavesDue;1.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If
        End If


        If RadioButton7.Checked = True Then '' Graduity List 
            Path = "" & frmLogin.ReportsPath & "\HR\RptDoJDifferDoG.rpt"
            If RadioButton1.Checked = True Then '' All Btn 
                Flag = False

                If AllBtn.Checked = True Then
                    Filter = EmpStatus & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOFJoining} <> {tbl_HRM_Emp_Info.GraduityDate}"
                ElseIf SecBTn.Checked = True Then
                    Filter = EmpStatus & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate}"
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate}"
                End If
            ElseIf RadioButton3.Checked = True Then ' By card range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And   {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                    Else
                        Filter = EmpStatus & "  and {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "   And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate}  "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  and  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate}  "
                    Else
                        Filter = EmpStatus & " and {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                    Else
                        Filter = EmpStatus & "  and {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  and  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_HRM_Emp_Info.DesignationID} =" & DesigNameComboBox.SelectedValue & "   And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate}  "
                    Else
                        Filter = EmpStatus & "  and  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DesignationID} =" & DesigNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                    End If
                End If
            ElseIf RadioButton6.Checked = True ' By branch 
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = EmpStatus & "  and  {tbl_HRM_Emp_Info.BranchID} = " & Me.BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = EmpStatus & "  And {tbl_HRM_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And  {tbl_HRM_Emp_Info.BranchID} = " & Me.BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                ElseIf SecBTn.Checked = True Then
                    Filter = EmpStatus & "  and  {tbl_HRM_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "' And  {tbl_HRM_Emp_Info.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.BranchID} = " & Me.BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & "  and  {tbl_HRM_Emp_Info.DesignationID} =" & DesigNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.BranchID} = " & Me.BranchNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOFJoining} <>{tbl_HRM_Emp_Info.GraduityDate} "
                End If
            End If

        End If





        If RadioButton8.Checked = True Then ''' Emp Age At the time of Joining
            Path = "" & frmLogin.ReportsPath & "\HR\RptAgeatjoining.rpt"
            If RadioButton20.Checked = True Then ''By Age Range
                Flag = False
                If AllBtn.Checked = True Then
                    Filter = " {View_Rpt_Acc_PreSalary.CardNo} > 0  "
                ElseIf DepartmentBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SecBTn.Checked = True Then
                    Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If


            ElseIf RadioButton18.Checked = True Then ''By Age Range

                If AllBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{@Age} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = "{@Age} In " & TextBox1.Text & " To " & TextBox2.Text & "   "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{@Age} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  "
                    Else
                        Filter = "{@Age} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  "
                    End If

                ElseIf SecBTn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@Age} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  "
                    Else
                        Filter = "{@Age} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{@Age} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_PreSalary.DesigID} =" & DesigNameComboBox.SelectedValue & "  "
                    Else
                        Filter = "{@Age} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DesigID} =" & DesigNameComboBox.SelectedValue & "  "
                    End If
                End If

            End If
        End If



        '''OT Pre Calculation
        If RadioButton10.Checked = True Then

            If RadioButton1.Checked = True Then ' All
                Flag = False
                If AllBtn.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""

                ElseIf DepartmentBtn.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Union_OT_Calc.Month}= " & Bymonth.Value.Month & " And {View_Union_OT_Calc.Year}= " & Bymonth.Value.Year & " "

                ElseIf SecBTn.Checked = True Then ' SecBTn Wise
                    Filter = EmpStatus & " And {View_Union_OT_Calc.Month}= " & Bymonth.Value.Month & " And {View_Union_OT_Calc.Year}= " & Bymonth.Value.Year & "  And {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Union_OT_Calc.SectionID} = " & SectionNameComboBox.SelectedValue & ""

                ElseIf DesigBtn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Union_OT_Calc.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Union_OT_Calc.Month}= " & Bymonth.Value.Month & " And {View_Union_OT_Calc.Year}= " & Bymonth.Value.Year & " "

                End If
            ElseIf RadioButton3.Checked = True ' By card
                If AllBtn.Checked = True Then ' By Emp
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And  {View_Union_OT_Calc.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""
                    Else
                        Filter = EmpStatus & " And  {View_Union_OT_Calc.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""
                    End If

                ElseIf DepartmentBtn.Checked = True Then ' main Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Union_OT_Calc.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""
                    Else

                        Filter = EmpStatus & " And {View_Union_OT_Calc.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf SecBTn.Checked = True Then ' SecBTn Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And  {View_Union_OT_Calc.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Union_OT_Calc.SectionID} = " & SectionNameComboBox.SelectedValue & "   And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""

                    Else

                        Filter = EmpStatus & " And {View_Union_OT_Calc.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Union_OT_Calc.SectionID} = " & SectionNameComboBox.SelectedValue & "  And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""

                    End If
                    'Filter = Empstatus & " And  {View_Union_OT_Calc.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Union_OT_Calc.SecBTnName} = '" & NameComboBox.Text & "' And {View_Union_OT_Calc.Month} In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True ' Desig Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And  {View_Union_OT_Calc.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Union_OT_Calc.DesignationID} = " & DesigNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""
                    Else

                        Filter = EmpStatus & " And {View_Union_OT_Calc.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Union_OT_Calc.DesignationID} = " & DesigNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""
                    End If
                End If



            ElseIf RadioButton6.Checked = True Then ' By Branch
                Flag = False
                If AllBtn.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And  {View_Union_OT_Calc.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""
                ElseIf DepartmentBtn.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Union_OT_Calc.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""

                ElseIf SecBTn.Checked = True Then ' SecBTn Wise
                    Filter = EmpStatus & " And {View_Union_OT_Calc.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Union_OT_Calc.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Union_OT_Calc.SectionID} = " & SectionNameComboBox.SelectedValue & "   And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Union_OT_Calc.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Union_OT_Calc.DesignationID} = " & DesigNameComboBox.SelectedValue & " And  {View_Union_OT_Calc.Year} = " & Bymonth.Value.Year & " And {View_Union_OT_Calc.Month} = " & Bymonth.Value.Month & ""

                End If

            End If
        End If

        If RadioButton11.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\HYgniccard.rpt"
            'Filter = "{View_Rpt_Acc_PreSalary.CardNo} in 6 to 21"


            If RadioButton3.Checked = True Then '' By CArd Range
                If AllBtn.Checked = True Then ' All
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = "{View_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = "{View_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf DepartmentBtn.Checked = True Then
                    Flag = False
                    Filter = "{View_Emp_Info.DeptName} = '" & DeptNameComboBox.Text & "'"

                End If

            End If

        End If

        If RadioButton12.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptEXCELDATA.rpt"
            Filter = "Month({tbl_EXCEL_Data.Month})  = " & Me.Bymonth.Value.Month & " And Year({tbl_EXCEL_Data.Month})  = " & Me.Bymonth.Value.Year & ""

        End If


        If SalarySlipBTn.Checked = True Then '  Salary Rpt 

            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccSalarySlipNormalShiftAll.rpt"
            If RadioButton1.Checked = True Then ' All Cash And Transfer 

                If AllBtn.Checked = True Then ' All Dept 
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                ElseIf DepartmentBtn.Checked = True Then ' By Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And   Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                ElseIf SecBTn.Checked = True Then ' By Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And   Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""

                ElseIf DesigBtn.Checked = True Then ' By Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And    Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                End If
            ElseIf RadioButton3.Checked = True Then ' All Dept 
                If AllBtn.Checked = True Then ' All Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf DepartmentBtn.Checked = True Then ' Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf SecBTn.Checked = True Then ' Section 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf DesigBtn.Checked = True Then ' Desig 
                    If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
            End If
        End If
        End If


        If SalaryRecivingBtn.Checked = True Then '  Salary receiving Rpt 

            Path = "" & frmLogin.ReportsPath & "\Accounts\Rptsalaryreclist.rpt"
            If RadioButton1.Checked = True Then ' All Cash And Transfer 

                If AllBtn.Checked = True Then ' All Dept 
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                ElseIf DepartmentBtn.Checked = True Then ' By Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And   Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                ElseIf SecBTn.Checked = True Then ' By Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And   Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""

                ElseIf DesigBtn.Checked = True Then ' By Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And    Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                End If
            ElseIf RadioButton3.Checked = True Then ' All Dept 
                If AllBtn.Checked = True Then ' All Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf DepartmentBtn.Checked = True Then ' Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf SecBTn.Checked = True Then ' Section 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf DesigBtn.Checked = True Then ' Desig 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                End If
            End If
        End If

        If RadioButton14.Checked Then
            Flag = False

            Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptPESSIFormat.rpt"
            'If All.Checked = True Then ' All 
            '    Flag = False
            '    If RadioButton1.Checked = True Then ' All Dept
            Filter = "Year({View_Rpt_PESSI.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_PESSI.SalaryMonth}) = " & Bymonth.Value.Month & " "
            '    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
            '    ElseIf SectBtn.Checked = True Then ' Section 
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
            '    ElseIf DesigBtn.Checked = True Then ' Desig
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
            '    End If
            'End If

        End If

        If RadioButton15.Checked Then
            Flag = False

            Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptEOBIFormat.rpt"
            'If All.Checked = True Then ' All 
            '    Flag = False
            '    If RadioButton1.Checked = True Then ' All Dept
            Filter = "Year({View_Rpt_PESSI.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Rpt_PESSI.SalaryMonth}) = " & Bymonth.Value.Month & " "
            '    ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
            '    ElseIf SectBtn.Checked = True Then ' Section 
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ") "
            '    ElseIf DesigBtn.Checked = True Then ' Desig
            '        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & "  And (Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & ")  "
            '    End If
            'End If

        End If


        If RadioButton16.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\HR\RptPessiSalary.rpt"


            If RadioButton1.Checked = True Then
                Flag = False
                Filter = "Year({View_Hrms_Pessi_Salary.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Hrms_Pessi_Salary.SalaryMonth}) = " & Bymonth.Value.Month & " "

            ElseIf RadioButton3.Checked = True Then ' By card range
                If TextBox2.Text = "" Then
                    Filter = "Year({View_Hrms_Pessi_Salary.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Hrms_Pessi_Salary.SalaryMonth}) = " & Bymonth.Value.Month & "  and {View_Hrms_Pessi_Salary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                Else
                    Filter = "Year({View_Hrms_Pessi_Salary.SalaryMonth}) = " & Bymonth.Value.Year & " and Month({View_Hrms_Pessi_Salary.SalaryMonth}) = " & Bymonth.Value.Month & "  and  {View_Hrms_Pessi_Salary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If

            End If

        End If

        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If

    End Sub
    Private Flag As Boolean = False

    Private Sub DepartmentBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DepartmentBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
    End Sub

    Private Sub SecBTn_CheckedChanged(sender As Object, e As EventArgs) Handles SecBTn.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged


        DesigNameComboBox.Enabled = True
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False


    End Sub

    Private Sub MiscRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HRMDBDataset1.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.HRMDBDataset1.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Employment' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_EmploymentTableAdapter.FillBy(Me.DSHRM.tbl_Hrm_Employment)
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Employment' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        RadioButton2.Visible = False
        RadioButton6.Visible = True
        If (Me.Tbl_Comp_InfoTableAdapter.FillBy(Me.DSUser.tbl_Comp_Info)) > 0 Then
            RejoiningBtn.Visible = False
            RadioButton12.Visible = True
        Else
            RejoiningBtn.Visible = True
            RadioButton12.Visible = False
        End If
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CrdExpry_CheckedChanged(sender As Object, e As EventArgs)
        GroupBox7.Enabled = True

    End Sub

    Private Sub InactiveBtn_CheckedChanged(sender As Object, e As EventArgs)
        GroupBox7.Enabled = False
    End Sub



    Private Sub UnionBtn_CheckedChanged(sender As Object, e As EventArgs) Handles UnionBtn.CheckedChanged
        Bymonth.Enabled = True

        RadioButton2.Visible = False
        RadioButton6.Visible = True
        GroupBox6.Enabled = True

    End Sub



    Private Sub RejoiningBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RejoiningBtn.CheckedChanged
        Bymonth.Enabled = False

        RadioButton2.Visible = False
        RadioButton6.Visible = True
        Bymonth.CustomFormat = "MMM, yyyy"
        GroupBox6.Enabled = False

    End Sub



    Private Sub PESSIEmpBtn_CheckedChanged(sender As Object, e As EventArgs) Handles PESSIEmpBtn.CheckedChanged, RadioButton14.CheckedChanged
        Bymonth.Enabled = True

        'GroupBox2.Visible = False
        GroupBox6.Enabled = True
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub







    Private Sub InAcvtivePESSi_CheckedChanged(sender As Object, e As EventArgs) Handles InAcvtivePESSi.CheckedChanged
        Bymonth.Enabled = False
        'GroupBox2.Visible = False

        GroupBox6.Enabled = False
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub



    Private Sub pendEOBICrd_CheckedChanged(sender As Object, e As EventArgs) Handles pendEOBICrd.CheckedChanged
        Bymonth.Enabled = False

        'GroupBox2.Visible = False
        GroupBox6.Enabled = False
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub

    Private Sub EOBIEmpList_CheckedChanged(sender As Object, e As EventArgs) Handles EOBIEmp.CheckedChanged
        Bymonth.Enabled = False

        'GroupBox2.Visible = False
        GroupBox6.Enabled = False
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub

    Private Sub PESSIlistBtn_CheckedChanged(sender As Object, e As EventArgs) Handles PESSIlistBtn.CheckedChanged
        Bymonth.Enabled = False

        'GroupBox2.Visible = False
        GroupBox6.Enabled = False
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub





    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub UFBtn_CheckedChanged(sender As Object, e As EventArgs) Handles UFBtn.CheckedChanged
        Bymonth.Enabled = False

        GroupBox2.Visible = False
        GroupBox6.Enabled = False
    End Sub

    Private Sub ASSCNO_CheckedChanged(sender As Object, e As EventArgs) Handles ASSCNO.CheckedChanged

        RadioButton2.Visible = False
        RadioButton6.Visible = True
        Bymonth.Enabled = False
        GroupBox6.Enabled = False
        'GroupBox2.Visible = False

    End Sub

    Private Sub PSSCNO_CheckedChanged(sender As Object, e As EventArgs) Handles PSSCNO.CheckedChanged
        Bymonth.Enabled = False

        RadioButton2.Visible = False
        RadioButton6.Visible = True
        GroupBox6.Enabled = False
        If PSSCNO.Checked = True Then
            GroupBox6.Enabled = False
            GroupBox7.Enabled = True
        Else
            GroupBox6.Enabled = True
            GroupBox7.Enabled = True
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        GroupBox6.Enabled = False

        GroupBox2.Visible = True
        RadioButton2.Visible = True
        RadioButton6.Visible = False
        If RadioButton2.Checked = True Then
            Bymonth.Enabled = True
        Else
            Bymonth.Enabled = False
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            Label5.Text = "From Date:"
            Bymonth.CustomFormat = "dd/MM/yyyy"
            Label4.Visible = True
            DateTimePicker2.Visible = True
            Bymonth.Enabled = True
        Else
            Label5.Text = "Select Month"
            Bymonth.CustomFormat = "MMM, yyyy"
            Label4.Visible = False
            DateTimePicker2.Visible = False
            Bymonth.Enabled = False

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged


        If RadioButton3.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub AllBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AllBtn.CheckedChanged
        DesigNameComboBox.Enabled = False
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        GroupBox6.Enabled = False

        GroupBox2.Visible = True
        RadioButton2.Visible = True
        RadioButton6.Visible = False
        If RadioButton2.Checked = True Then
            Bymonth.Enabled = True
        Else
            Bymonth.Enabled = False
        End If

        If RadioButton4.Checked = True Then
            RadioButton2.Text = "By Date Of Termination"
        Else
            RadioButton2.Text = "By Date Of joining"


        End If
    End Sub

    Private Sub EOBiEmpBtn_CheckedChanged(sender As Object, e As EventArgs) Handles EOBiEmpBtn.CheckedChanged
        Bymonth.Enabled = True

        GroupBox6.Enabled = True
        'GroupBox2.Visible = False
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Bymonth.Enabled = True
        GroupBox2.Visible = True

        GroupBox6.Enabled = False
        RadioButton1.Checked = True
        If RadioButton5.Checked = True Then
            RadioButton2.Visible = False
            RadioButton6.Visible = True
        Else
            RadioButton6.Visible = False
            RadioButton2.Visible = True
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        GroupBox6.Enabled = True

        Bymonth.Enabled = False
        'GroupBox2.Visible = False
        RadioButton1.Checked = True
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Bymonth.Enabled = False
            GroupBox2.Visible = False
            GroupBox3.Visible = True
        Else
            Bymonth.Enabled = True
            GroupBox2.Visible = True
            GroupBox3.Visible = False
        End If
        'GroupBox2.Visible = False
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            Bymonth.Enabled = True
            GroupBox6.Enabled = True
            GroupBox2.Visible = True
            RadioButton2.Visible = False
            RadioButton6.Visible = True

        Else
            Bymonth.Enabled = False
            GroupBox6.Enabled = False
            GroupBox2.Visible = False
            RadioButton2.Visible = True
            RadioButton6.Visible = False

        End If

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        RadioButton2.Visible = False
        RadioButton6.Visible = True
        If RadioButton11.Checked = True Then
            RadioButton1.Enabled = False
            RadioButton3.Checked = True
            RadioButton6.Enabled = False
            Bymonth.Enabled = False
            Panel1.Enabled = True
            DesigBtn.Enabled = False
            SecBTn.Enabled = False
        Else
            RadioButton1.Enabled = True
            RadioButton3.Checked = False
            RadioButton6.Enabled = True
            Bymonth.Enabled = True
            Panel1.Enabled = False
            DesigBtn.Enabled = True
            SecBTn.Enabled = True
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        Bymonth.Enabled = True
    End Sub

    Private Sub SalarySlipBTn_CheckedChanged(sender As Object, e As EventArgs) Handles SalarySlipBTn.CheckedChanged
        If SalarySlipBTn.Checked = True Then

            Bymonth.Enabled = True
            GroupBox6.Enabled = True
            RadioButton6.Enabled = False
        Else

            Bymonth.Enabled = False
            GroupBox6.Enabled = False
            RadioButton6.Enabled = True
        End If
    End Sub

    Private Sub SalaryRecivingBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SalaryRecivingBtn.CheckedChanged
        If SalaryRecivingBtn.Checked = True Then
            Bymonth.Enabled = True
            GroupBox6.Enabled = True
            RadioButton6.Enabled = False

        Else
            Bymonth.Enabled = False
            RadioButton6.Enabled = True
            GroupBox6.Enabled = False

        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            FinancialPeriodComboBox.Enabled = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            GroupBox2.Enabled = False
            Panel1.Enabled = False
            Bymonth.Enabled = False
        Else
            FinancialPeriodComboBox.Enabled = False
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            GroupBox2.Enabled = True
            Panel1.Enabled = True
            Bymonth.Enabled = True
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        Bymonth.Enabled = True

        'GroupBox2.Visible = False
        GroupBox6.Enabled = True
        RadioButton2.Visible = False
        RadioButton6.Visible = True
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        Bymonth.Enabled = True
        Panel1.Enabled = False
        GroupBox6.Enabled = True
        'GroupBox2.Visible = False
        RadioButton2.Visible = False
        RadioButton6.Visible = False
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            Label7.Text = "From Age"
            Label6.Text = "To Age"
        Else
            Label7.Text = "From Card"
            Label6.Text = "To Card"
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub
End Class