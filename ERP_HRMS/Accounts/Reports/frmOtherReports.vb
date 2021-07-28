Public Class frmOtherReports


    Private Sub AllDept_CheckedChanged(sender As Object, e As EventArgs) Handles AllDept.CheckedChanged
        If AllDept.Checked = True Then
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False
            DesigComboBox.Enabled = False
        Else
            DeptNameComboBox.Enabled = True
            NameComboBox.Enabled = True
            DesigComboBox.Enabled = True
        End If
        If RadioButton4.Checked = True Then
            MonthPicker.Enabled = True

        ElseIf RadioButton8.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True


        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            MonthPicker.Enabled = True
        Else
            MonthPicker.Enabled = False
        End If



        If RadioButton4.Checked = True And RadioButton9.Checked = True Then
            Label2.Text = "From Date:"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
            Label5.Visible = True
            DateTimePicker2.Visible = True

        Else
            MonthPicker.CustomFormat = "MMM, yyyy"
            Label5.Visible = False
            DateTimePicker2.Visible = False

            Label2.Text = "Select Date"

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If

    End Sub

    Private Sub RadioButton12_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub MainDeptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MainDeptBtn.CheckedChanged
        If MainDeptBtn.Checked = True Then
            DeptNameComboBox.Enabled = True
            NameComboBox.Enabled = False
            DesigComboBox.Enabled = False
        Else
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False
            DesigComboBox.Enabled = False
        End If

        If RadioButton4.Checked = True Then
            MonthPicker.Enabled = True

        ElseIf RadioButton8.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True


        End If
    End Sub

    Private Sub SectBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SectBtn.CheckedChanged
        If SectBtn.Checked = True Then
            DeptNameComboBox.Enabled = True
            NameComboBox.Enabled = True
            DesigComboBox.Enabled = False
        Else
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False
            DesigComboBox.Enabled = False
        End If

        If RadioButton4.Checked = True Then

        ElseIf RadioButton8.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True

        End If
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        If DesigBtn.Checked = True Then
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False
            DesigComboBox.Enabled = True
        Else
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False
            DesigComboBox.Enabled = False

        End If

        If RadioButton4.Checked = True Then
            MonthPicker.Enabled = True

        ElseIf RadioButton8.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True


        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        MonthPicker.Enabled = True
        GroupBox1.Enabled = True
        If RadioButton1.Checked = True Then
            RadioButton8.Enabled = False
            RadioButton4.Enabled = True
            AllEmp.Enabled = False
            RadioButton3.Enabled = True
            RadioButton4.Checked = True
            BankNameComboBox.Enabled = True

        Else
            RadioButton8.Enabled = True
            RadioButton4.Enabled = True
            AllEmp.Enabled = True
            RadioButton3.Enabled = True
            AllEmp.Checked = True
            BankNameComboBox.Enabled = False

        End If
    End Sub

    Private Sub frmOtherReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Employment' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_EmploymentTableAdapter.FillBy(Me.DSHRM.tbl_Hrm_Employment)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSHRM.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'HRMDBDataSet1.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        'Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'HRMDBDataSet1.tbl_Hrm_Card' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_CardTableAdapter.Fill(Me.HRMDBDataSet1.tbl_Hrm_Card)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Bank' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BankTableAdapter.Fill(Me.DSHRM.tbl_HRM_Bank)
        'Me.Tbl_Acc_FinancialPeriodTableAdapter.FillBy(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)
        RadioButton4.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim Obj As New UtilityClass()
        Dim empStatus As String
        If RadioButton13.Checked = True Then
            If ActiveBtn.Checked = True Then
                empStatus = "{tbl_HRM_Emp_Info.EmpStatus} = True"
            ElseIf NonActiveBtn.Checked = True Then
                empStatus = "{tbl_HRM_Emp_Info.EmpStatus} = False"
            ElseIf All.Checked = True Then
                empStatus = "({tbl_HRM_Emp_Info.EmpStatus} = True Or {tbl_HRM_Emp_Info.EmpStatus} = False)"
            End If
        ElseIf RadioButton10.Checked = True Or RadioButton7.Checked = True Or RadioButton1.Checked = True Then
            If ActiveBtn.Checked = True Then
                empStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = True"
            ElseIf NonActiveBtn.Checked = True Then
                empStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = False"
            ElseIf All.Checked = True Then
                empStatus = "({View_Rpt_Acc_PreSalary.EmpStatus} = True Or {View_Rpt_Acc_PreSalary.EmpStatus} = False)"
            End If
        ElseIf RadioButton5.Checked = True Or RadioButton12.checked Then
            If ActiveBtn.Checked = True Then
                empStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus} = True"
            ElseIf NonActiveBtn.Checked = True Then
                empStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus} = False"
            ElseIf All.Checked = True Then
                empStatus = "({View_Rpt_Acc_AllEmployees.EmpStatus} = True Or {View_Rpt_Acc_AllEmployees.EmpStatus} = False)"
            End If
        End If


        If RadioButton10.Checked = True Then ' salary  calculation Transaction 
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccSalaryTransactions.rpt"
            If RadioButton4.Checked = True Then ' By month  
                Flag = False
                If AllDept.Checked = True Then   ' All Dept
                    Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & ""
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = empStatus & "  And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = empStatus & "  And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " "
                End If
            ElseIf RadioButton8.Checked = True Then ' Card Range 
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SectBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf RadioButton3.Checked = True Then ' By Branch 
                Flag = False
                If AllDept.Checked = True Then   ' All Dept

                    Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & ""

                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigComboBox.SelectedValue & " "
                End If
            End If
        End If

        If RadioButton2.Checked = True Then '  Salary  Not calculate 
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccMissingSalary.rpt"
            Param = "@MyMonth=" & MonthPicker.Value.Month & "&@MyYear=" & MonthPicker.Value.Year

            If RadioButton4.Checked = True Then ' By month  
                Flag = False
                If AllDept.Checked = True Then   ' All Dept

                    Filter = "{MissingSalary;1.CardNo} > 0"

                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{MissingSalary;1.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{MissingSalary;1.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {MissingSalary;1.SectionID} = " & NameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{MissingSalary;1.Designame} = '" & DesigComboBox.Text & "' "
                End If
            ElseIf RadioButton8.Checked = True Then ' Card Range 
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {MissingSalary;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{MissingSalary;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{MissingSalary;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {MissingSalary;1.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{MissingSalary;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {MissingSalary;1.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SectBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{MissingSalary;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {MissingSalary;1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {MissingSalary;1.SectionID} = " & NameComboBox.SelectedValue & ""
                    Else
                        Filter = "{MissingSalary;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {MissingSalary;1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {MissingSalary;1.SectionID} = " & NameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{MissingSalary;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And   {MissingSalary;1.Designame} = '" & DesigComboBox.Text & "'"
                    Else
                        Filter = "{MissingSalary;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And   {MissingSalary;1.Designame} = '" & DesigComboBox.Text & "'"
                    End If
                End If

            ElseIf RadioButton3.Checked = True Then ' By Branch 
                Flag = False
                If AllDept.Checked = True Then   ' All Dept
                    Filter = "{MissingSalary;1.BranchID}= " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{MissingSalary;1.BranchID}= " & BranchNameComboBox.SelectedValue & " And {MissingSalary;1.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{MissingSalary;1.BranchID}= " & BranchNameComboBox.SelectedValue & " And {MissingSalary;1.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {MissingSalary;1.SectionID} = " & NameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{MissingSalary;1.BranchID}= " & BranchNameComboBox.SelectedValue & " And {MissingSalary;1.Designame} = '" & DesigComboBox.Text & "' "
                End If
            End If
        End If

        '''' iNsurance List 

        If RadioButton9.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\Accounts\RptEmpList4Insurance.rpt"
            If AllEmp.Checked = True Then ' All EMp
                Flag = False
                If AllDept.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empStatus} = True And   {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""


                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Emp_List.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                End If
            ElseIf RadioButton4.Checked = True Then ' By date Of Joining
                If AllDept.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.empStatus} = True And {View_Rpt_Emp_List.DOJ} In Date(" & MonthPicker.Value.Year & "," & MonthPicker.Value.Month & "," & MonthPicker.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DOJ} In Date(" & MonthPicker.Value.Year & "," & MonthPicker.Value.Month & "," & MonthPicker.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ")And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_Emp_List.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DOJ} In Date(" & MonthPicker.Value.Year & "," & MonthPicker.Value.Month & "," & MonthPicker.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Emp_List.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Emp_List.DOJ} In Date(" & MonthPicker.Value.Year & "," & MonthPicker.Value.Month & "," & MonthPicker.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ") And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                End If

            ElseIf RadioButton8.Checked = True Then ' By card range

                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                    End If

                ElseIf SectBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Emp_List.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Emp_List.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Emp_List.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                    End If
                End If



            ElseIf RadioButton3.Checked = True Then ' By Branch 
                Flag = False
                If AllDept.Checked = True Then   ' All Dept
                    Filter = "{View_Rpt_Emp_List.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Emp_List.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Emp_List.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Emp_List.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{View_Rpt_Emp_List.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Emp_List.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Emp_List.ETID} = " & EmploymentNameComboBox.SelectedValue & " "
                End If
            End If
        End If



        '''

        '''' Bak Transfer 



        If RadioButton1.Checked = True Then
            If BankNameComboBox.Text = "HABIB METROPOLITAN" Then
                Path = "" & frmLogin.ReportsPath & "\Accounts\ListHabibMetro.rpt"
                If RadioButton4.Checked = True Then ' By month  
                    Flag = False
                    If AllDept.Checked = True Then   ' All Dept

                        Filter = empStatus & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = empStatus & " And  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal'And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    End If


                ElseIf RadioButton3.Checked = True Then ' By Branch 
                    Flag = False
                    If AllDept.Checked = True Then   ' All Dept

                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    End If

                End If
            ElseIf BankNameComboBox.Text = "MEEZAN BANK" Then
                Path = "" & frmLogin.ReportsPath & "\Accounts\ListMeezanbank.rpt"
                If RadioButton4.Checked = True Then ' By month  
                    Flag = False
                    If AllDept.Checked = True Then   ' All Dept

                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal'And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    End If


                ElseIf RadioButton3.Checked = True Then ' By Branch 
                    Flag = False
                    If AllDept.Checked = True Then   ' All Dept
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    End If

                End If
            ElseIf BankNameComboBox.Text = "UNITED BANK LIMITED" Then
                Path = "" & frmLogin.ReportsPath & "\Accounts\ListUBL.rpt"
                If RadioButton4.Checked = True Then ' By month  
                    Flag = False
                    If AllDept.Checked = True Then   ' All Dept
                        Filter = empStatus & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal'And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    End If
                ElseIf RadioButton3.Checked = True Then ' By Branch 
                    Flag = False
                    If AllDept.Checked = True Then   ' All Dept
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & " "
                    End If

                End If
            End If

        End If



        If RadioButton18.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\Terminationletter.rpt"
            If AllEmp.Checked = True Then ' By month  
                Flag = False
                Filter = "{tbl_Acc_Termination_Transactions.TerminationDate} in Date(" & MonthPicker.Value.Year & " , " & MonthPicker.Value.Month & " , " & MonthPicker.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
            ElseIf RadioButton8.Checked = True Then ' Card Range 
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








        If PendingStatus.Checked = True Then ' Pending Status 
            Path = "" & frmLogin.ReportsPath & "\HR\EmpPendingSalaryStatus.rpt"
            If AllEmp.Checked = True Then ' All 
                Flag = False
                If AllDept.Checked = True Then ' Alll
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then ' By Deptt
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " and {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then ' By section
                    Filter = " {tbl_HRM_Emp_Info.EmpStatus} = True And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then ' By Designation
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigComboBox.SelectedValue & " And  {tbl_Hrm_Emp_Info.DateOfJoning} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If

        '''' EMployee Salary Analysis 

        If RadioButton5.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\SalaryAnalysis.rpt"
            Param = "@FromDate=" & MonthPicker.Value.Date & "&@ToDate=" & DateTimePicker2.Value.Date & ""
            If AllEmp.Checked = True Then
                Flag = False
                Filter = empStatus
            End If
        End If





        ''''''''''''
        ''''' Graduity List 

        If RadioButton7.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccGraduatyList.rpt"
            Param = "PromptDate=" & MonthPicker.Value.Day & "/" & MonthPicker.Value.Month & "/" & MonthPicker.Value.Year
            If RadioButton4.Checked = True Then ' By month  
                Flag = False
                If AllDept.Checked = True Then   ' All Dept

                    Filter = empStatus

                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = empStatus & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " "
                End If
            ElseIf RadioButton8.Checked = True Then ' Card Range 
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SectBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & ""
                    End If
                End If

            ElseIf RadioButton3.Checked = True Then ' By Branch 
                Flag = False
                If AllDept.Checked = True Then   ' All Dept

                    Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & ""

                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = empStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " "
                End If
            End If
        End If



        '''Terminated EMp list 

        If RadioButton17.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\TermListRpt.rpt"
            If AllEmp.Checked = True Then ' All EMp
                Flag = False
                If AllDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.LeavingDate} In  #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.SubDept1ID} = " & NameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.LeavingDate} In  #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.LeavingDate} In  #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton8.Checked = True Then ' By card range

                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And  {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SectBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigComboBox.SelectedValue & ""
                    Else
                        Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigComboBox.SelectedValue & ""
                    End If
                End If



            ElseIf RadioButton3.Checked = True Then ' By Branch 
                Flag = False
                If AllDept.Checked = True Then   ' All Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And  {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_HRM_Emp_Info.LeavingDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And  {tbl_HRM_Emp_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DesignationID} = " & DesigComboBox.SelectedValue & " "
                End If
            End If
        End If




        '''''



        '''' Employee Profile 

        If RadioButton13.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\HR\EmpProfRpt.rpt"

            If RadioButton8.Checked = True Then ' By card range 

                Filter = empStatus

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = empStatus & " And{tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                Else
                    Filter = empStatus & " And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If
            End If
        End If


        ''''
        '' Annula leaves 


        If EmpAnual.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptEmpRecord.rpt"
            Param = "FP=" & Me.FinancialPeriodComboBox.Text & ""
            If RadioButton8.Checked = True Then

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = "   {View_Rpt_PayRoll_EmpInfo.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & ""
                Else
                    Filter = " {View_Rpt_PayRoll_EmpInfo.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                End If

            End If
        End If

        If RadioButton6.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\AccHolderEmployeeList.rpt"
            If AllEmp.Checked = True Then

                Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = True and  {View_Rpt_Acc_AllEmployees.PaymentMode} = 'Transfer' "
            ElseIf RadioButton11.Checked = True Then
                Filter = "{View_Rpt_Acc_AllEmployees.EmpStatus} = True and  {View_Rpt_Acc_AllEmployees.PaymentMode} = 'Transfer' And {View_Rpt_Acc_AllEmployees.BankName} = '" & BankNameComboBox1.Text & "'"


            End If
        End If




        If RadioButton12.Checked = True Then   ' Employee List 

            Path = "" & frmLogin.ReportsPath & "\HR\EmployeeList.rpt"

            If AllEmp.Checked = True Then ' All Btn
                Flag = False
                If AllDept.Checked = True Then
                    Filter = empStatus
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = empStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf SectBtn.Checked = True Then
                    Filter = empStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = empStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigComboBox.SelectedValue & ""

                End If


            ElseIf RadioButton8.Checked = True Then
                Filter = empStatus
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = empStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    End If

                ElseIf SectBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = empStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigComboBox.SelectedValue & ""
                    Else
                        Filter = empStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigComboBox.SelectedValue & ""
                    End If
                End If
                'ElseIf RadioButton3.Checked = True
                '    Flag = False
                '    If AllDept.Checked = True Then ' All Dept

                '        Filter = empStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " "
                '    ElseIf MainDeptBtn.Checked = True Then ' Main Dept

                '        Filter = empStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                '    ElseIf SectBtn.Checked = True Then ' MAni Secttion
                '        Filter = empStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & ""
                '    ElseIf DesigBtn.Checked = True Then ' ' Designation
                '        Filter = empStatus & " And  {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigComboBox.SelectedValue & ""
                '    End If
            End If
        End If





        If RadioButton14.Checked = True Then   ' Employee List 
            If TextBox4.Text.Length > 0 And TextBox3.Text.Length > 0 Then


                Path = "" & frmLogin.ReportsPath & "\Accounts\RptEmpbasicSalary.rpt"

                If AllEmp.Checked = True Then ' All Btn
                    Flag = False
                    If AllDept.Checked = True Then
                        Filter = "{View_Rpt_Acc_PreSalary.GrossSalary} In " & TextBox4.Text & " To " & TextBox3.Text & " "
                    ElseIf MainDeptBtn.Checked = True Then
                        Filter = "{View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.GrossSalary} In " & TextBox4.Text & " To " & TextBox3.Text & ""
                    ElseIf SectBtn.Checked = True Then
                        Filter = "{View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.GrossSalary} In " & TextBox4.Text & " To " & TextBox3.Text & ""
                    ElseIf DesigBtn.Checked = True Then
                        Filter = "{View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.GrossSalary} In " & TextBox4.Text & " To " & TextBox3.Text & ""

                    End If
                End If
            Else
                  Flag = False
                MessageBox.Show("please Enter Salary", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        GroupBox1.Enabled = False
        MonthPicker.Enabled = True

        If RadioButton2.Checked = True Then

            RadioButton4.Checked = True
            AllEmp.Enabled = False

        Else


            AllEmp.Enabled = True

        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        MonthPicker.Enabled = True

        GroupBox1.Enabled = True
        If RadioButton10.Checked = True Then
            AllEmp.Enabled = False
            RadioButton4.Checked = True
        Else
            AllEmp.Checked = True
            AllEmp.Enabled = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
        End If
        If RadioButton12.Checked = True Then
            MonthPicker.Enabled = False
        Else
            MonthPicker.Enabled = True
        End If
        If RadioButton3.Checked = True And RadioButton9.Checked = True Then
            MonthPicker.Enabled = False
        Else
            MonthPicker.Enabled = True
        End If
    End Sub



    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        MonthPicker.Enabled = False
        Me.AllEmp.Checked = True
        GroupBox1.Enabled = False
        If RadioButton9.Checked = True Then
            Label8.Visible = True
            RadioButton4.Text = "By Date Of joining"
            EmploymentNameComboBox.Visible = True
        Else
            EmploymentNameComboBox.Visible = False
            RadioButton4.Text = "By Month"
            Label8.Visible = False
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs)
        MonthPicker.Enabled = False

    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs)
        MonthPicker.Enabled = False

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        GroupBox1.Enabled = True
        MonthPicker.Enabled = True
        If RadioButton5.Checked = True Then
            RadioButton4.Enabled = False

            RadioButton8.Enabled = False
            RadioButton3.Enabled = False
            AllEmp.Text = "By Date Range"
            Label2.Text = "From Date:"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
            Label5.Visible = True
            DateTimePicker2.Visible = True

            Panel2.Enabled = False

        Else
            RadioButton4.Enabled = True

            RadioButton8.Enabled = True
            AllEmp.Text = " All"
            MonthPicker.CustomFormat = "MMM, yyyy"
            Label5.Visible = False
            DateTimePicker2.Visible = False

            Panel2.Enabled = True
            RadioButton3.Enabled = True

        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        GroupBox1.Enabled = True
        MonthPicker.Enabled = True
        If RadioButton7.Checked = True Then
            MonthPicker.Enabled = True
            MonthPicker.CustomFormat = "dd/MM/yyyy"
            AllEmp.Enabled = False
            RadioButton4.Checked = True
        Else
            MonthPicker.CustomFormat = "MMM, yyyy"
            MonthPicker.Enabled = False
            AllEmp.Checked = True
            AllEmp.Enabled = True
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        GroupBox1.Enabled = False
        MonthPicker.Enabled = True

        If RadioButton18.Checked = True Then
            RadioButton4.Enabled = False

            RadioButton3.Enabled = False
            AllEmp.Text = "By Date Range"
            Label2.Text = "From Date:"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
            Label5.Visible = True
            DateTimePicker2.Visible = True

            Panel2.Enabled = False
        Else
            RadioButton4.Enabled = True

            RadioButton3.Enabled = True
            AllEmp.Text = " All"
            MonthPicker.CustomFormat = "MMM, yyyy"
            Label5.Visible = False
            DateTimePicker2.Visible = False
            MonthPicker.Enabled = False
            Panel2.Enabled = True
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        MonthPicker.Enabled = True
        GroupBox1.Enabled = False
        If RadioButton17.Checked = True Then
            RadioButton4.Enabled = False
            AllEmp.Text = "By Date Range"
            Label2.Text = "From Date:"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
            Label5.Visible = True
            DateTimePicker2.Visible = True


        Else
            RadioButton4.Enabled = True
            AllEmp.Text = " All"
            MonthPicker.CustomFormat = "MMM, yyyy"
            Label5.Visible = False
            DateTimePicker2.Visible = False


        End If
    End Sub



    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs)
        MonthPicker.Enabled = False

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        GroupBox1.Enabled = True
        MonthPicker.Enabled = False
        If RadioButton13.Checked = True Then
            AllEmp.Enabled = False
            RadioButton4.Enabled = False
            RadioButton3.Enabled = False

            RadioButton8.Checked = True


            Panel2.Enabled = False
        Else
            AllEmp.Enabled = True
            RadioButton4.Enabled = True
            RadioButton3.Enabled = True
            Panel2.Enabled = True
            AllEmp.Checked = True
        End If
    End Sub

    Private Sub EmpAnual_CheckedChanged(sender As Object, e As EventArgs) Handles EmpAnual.CheckedChanged
        GroupBox1.Enabled = False
        MonthPicker.Enabled = False
        If EmpAnual.Checked = True Then
            AllEmp.Enabled = False
            RadioButton4.Enabled = False
            RadioButton3.Enabled = False
            Panel2.Enabled = False
            RadioButton8.Checked = True


            FinancialPeriodComboBox.Visible = True
            Label4.Visible = True
            GroupBox1.Enabled = False
        Else
            AllEmp.Enabled = True
            RadioButton4.Enabled = True
            RadioButton3.Enabled = True
            FinancialPeriodComboBox.Visible = False
            Label4.Visible = False
            AllEmp.Checked = True
            Panel2.Enabled = True
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub PendingStatus_CheckedChanged(sender As Object, e As EventArgs) Handles PendingStatus.CheckedChanged
        GroupBox1.Enabled = False
        MonthPicker.Enabled = True
        If PendingStatus.Checked = True Then
            RadioButton4.Enabled = False

            RadioButton3.Enabled = False
            RadioButton8.Enabled = False
            AllEmp.Text = "By Date Of Joining"
            Label2.Text = "From Date:"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
            Label5.Visible = True
            DateTimePicker2.Visible = True


            AllEmp.Checked = True
        Else
            RadioButton4.Enabled = True

            RadioButton3.Enabled = True
            RadioButton8.Enabled = True

            AllEmp.Text = " All"
            MonthPicker.CustomFormat = "MMM, yyyy"
            Label5.Visible = False
            DateTimePicker2.Visible = False


        End If
    End Sub

    Private Sub AllEmp_CheckedChanged(sender As Object, e As EventArgs) Handles AllEmp.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            RadioButton4.Enabled = False
            Panel2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton8.Enabled = False
            GroupBox1.Enabled = False
            RadioButton11.Enabled = True
        Else

            RadioButton11.Enabled = False
            Panel2.Enabled = True
            RadioButton4.Enabled = True
            RadioButton3.Enabled = True
            RadioButton8.Enabled = True
            GroupBox1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            BankNameComboBox1.Enabled = True

        Else
            BankNameComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        MonthPicker.Enabled = False

        If RadioButton12.Checked = True Then
            RadioButton4.Enabled = False

            RadioButton11.Enabled = False
            RadioButton3.Enabled = False
        Else
            RadioButton4.Enabled = True

            RadioButton11.Enabled = True
            RadioButton3.Enabled = True
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        MonthPicker.Enabled = False
        AllEmp.Checked = True
        If RadioButton14.Checked = True Then
            RadioButton4.Enabled = False
            RadioButton8.Enabled = False
            RadioButton11.Enabled = False
            RadioButton3.Enabled = False
            TextBox3.Enabled = True
            TextBox4.Enabled = True

        Else
            RadioButton4.Enabled = False
            RadioButton8.Enabled = False
            RadioButton11.Enabled = False
            RadioButton3.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
        End If
    End Sub


End Class