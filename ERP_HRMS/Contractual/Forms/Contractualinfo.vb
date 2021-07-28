Public Class Contractualinfo


    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass

    Private Sub Tbl_HRM_DeptBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_DeptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)

    End Sub

    Private Sub Contractualinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

    End Sub

    Private Sub MainDept_CheckedChanged(sender As Object, e As EventArgs) Handles MainDept.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub Deigantionbtn_CheckedChanged(sender As Object, e As EventArgs) Handles Deigantionbtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True
    End Sub

    Private Sub MainDeptandSection_CheckedChanged(sender As Object, e As EventArgs)
        DeptNameComboBox.Enabled = True

        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Bymonth.Enabled = False
    End Sub

    Private Sub btnRptShow_Click(sender As Object, e As EventArgs) Handles btnRptShow.Click
        Dim EmpStatus As String
        If RadioButton1.Checked = True Or rbtShiftsAndDate.Checked = True Or AllButton.Checked = True Then

            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = True"
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.CardNo} >=60000"
            End If
        End If
        If PESSIEmpBtn.Checked = True Or EOBiEmpBtn.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_HR_ContractualEmp.EmpStatus} = True"
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_HR_ContractualEmp.EmpStatus} = False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_HR_ContractualEmp.CardNo} >= 60000"
            End If
        End If
        If MonthAttBtn.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.empstatus}= true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.empstatus}= False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_AllEmployees.empstatus} = True or {View_Rpt_Acc_AllEmployees.empstatus} = False)"
            End If
        End If
        If RadioButton3.Checked = True Then
            If ActiveBtn.Checked = True Then

                EmpStatus = "{View_Rpt_Acc_ActiveSalaryTransactions.EmpStatus}= true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_ActiveSalaryTransactions.EmpStatus}= False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_ActiveSalaryTransactions.EmpStatus} = True or {View_Rpt_Acc_ActiveSalaryTransactions.EmpStatus} = False)"
            End If
        End If
        If RadioButton5.Checked = True Then
            If ActiveBtn.Checked = True Then

                EmpStatus = "{View_Rpt_Acc_ActiveSalaryTransactions.EmpStatus}= true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_ActiveSalaryTransactions.EmpStatus}= False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_ActiveSalaryTransactions.EmpStatus} = True or {View_Rpt_Acc_ActiveSalaryTransactions.EmpStatus} = False)"
            End If
        End If
        If RadioButton9.Checked Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Emp_List.empStatus} = True "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Emp_List.empStatus} = False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Emp_List.empStatus} = True or {View_Rpt_Emp_List.empStatus} = False)"
            End If
        End If

        If RadioButton1.Checked = True Then ' Max Info COntractual 
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\RptConMexInfoo.rpt"
            If AllButton.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf Section.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf CardRange.Checked = True Then ' By Card Range 
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
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
                ElseIf Section.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If
                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            End If

        End If
        If RadioButton9.Checked Then
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\RptEmpList4Insurance.rpt"
            If AllButton.Checked Then
                Filter = EmpStatus & " And {View_Rpt_Emp_List.DOJ} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ")"
            ElseIf CardRange.Checked Then
                Filter = EmpStatus & " And {View_Rpt_Emp_List.DOJ} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ")"
            End If

        End If
        If RadioButton4.Checked Then
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\insurRemovList.rpt"
            Filter = "  {View_Rpt_Acc_AllEmployees.LeavingDate} IN Date(" & Bymonth.Value.Year & "," & Bymonth.Value.Month & "," & Bymonth.Value.Day & ") to Date(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ")"
        End If

        ''' COntactual Setting report
        If RadioButton2.Checked = True Then ' Max Info COntractual 
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\RptEmpDeptSetting.rpt"
            If AllButton.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = EmpStatus
                ElseIf MainDept.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf Section.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf CardRange.Checked = True Then ' By Card Range 
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
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
                ElseIf Section.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    End If
                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If

            End If

        End If
        If EOBiEmpBtn.Checked = True Then
            ''Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\rptContEOBI.rpt"
            If AllButton.Checked = True Then ' by Date
                Flag = False
                If AllDept.Checked = True Then ' All EMp
                    Filter = EmpStatus & "  And {View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.DateTimePicker1.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.DateTimePicker1.Value, "MM")
                ElseIf MainDept.Checked = True 'mani Dept
                    Filter = EmpStatus & "  And  {View_Rpt_HR_ContractualEmp.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.DateTimePicker1.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.DateTimePicker1.Value, "MM")
                ElseIf Section.Checked = True ' Section Wise
                    Filter = EmpStatus & " And  {View_Rpt_HR_ContractualEmp.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_HR_ContractualEmp.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.DateTimePicker1.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.DateTimePicker1.Value, "MM")
                ElseIf Deigantionbtn.Checked = True '  Deig Wise 
                    Filter = EmpStatus & "   And {View_Rpt_HR_ContractualEmp.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.DateTimePicker1.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.DateTimePicker1.Value, "MM")
                End If
            End If
        End If
        If PESSIEmpBtn.Checked = True Then
            '' Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\rptPESSICon.rpt"
            If AllButton.Checked = True Then ' by Date
                Flag = False
                If AllDept.Checked = True Then ' All EMp
                    Filter = EmpStatus & "  And {View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.DateTimePicker1.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.DateTimePicker1.Value, "MM")
                ElseIf MainDept.Checked = True 'mani Dept
                    Filter = EmpStatus & "  And  {View_Rpt_HR_ContractualEmp.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.DateTimePicker1.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.DateTimePicker1.Value, "MM")
                ElseIf Section.Checked = True ' Section Wise
                    Filter = EmpStatus & " And  {View_Rpt_HR_ContractualEmp.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_HR_ContractualEmp.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.DateTimePicker1.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.DateTimePicker1.Value, "MM")
                ElseIf Deigantionbtn.Checked = True '  Deig Wise 
                    Filter = EmpStatus & "   And {View_Rpt_HR_ContractualEmp.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Acc_Att_FinalDayCount.YearOfAtt} = " & Format(Me.DateTimePicker1.Value, "yyyy") & " AND {View_Acc_Att_FinalDayCount.MonthOfAtt} = " & Format(Me.DateTimePicker1.Value, "MM")
                End If
            End If
        End If
            If rbtShiftsAndDate.Checked = True Then 'Attendence rpt
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\RptDailyAttendence.rpt"
            If AllButton.Checked = True Then ' by Date
                Flag = False
                If AllDept.Checked = True Then ' All EMp
                    Filter = EmpStatus & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True 'mani Dept
                    Filter = EmpStatus & "  And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True ' Section Wise
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf Deigantionbtn.Checked = True '  Deig Wise 
                    Filter = EmpStatus & "   And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf CardRange.Checked = True 'by card 
                If AllDept.Checked = True Then ' ALl Emp
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf MainDept.Checked = True ' Main Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf Section.Checked = True ' Section Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf Deigantionbtn.Checked = True ' Desig Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.Bymonth.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            End If
        End If

        If MonthAttBtn.Checked = True Then ' Complete Month Att Rpt
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\rptFullMonthAttendance.rpt"
            Param = "FromDate=" & Format(Me.Bymonth.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "&AttFromDate=" & Format(Me.Bymonth.Value, "dd/MM/yyyy") & "&AttToDate=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy")
            If AllButton.Checked = True Then ' By date
                Flag = False
                If AllDept.Checked = True Then ' All Emp

                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) "
                ElseIf MainDept.Checked = True Then 'By Dept

                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf Section.Checked = True ' Section wise
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SubDept1}  = '" & SectionNameComboBox.Text & "' "
                ElseIf Deigantionbtn.Checked = True ' Desigtion Wise
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf CardRange.Checked = True 'By card 
                If AllDept.Checked = True Then ' All Emp
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "And  {View_Rpt_Acc_AllEmployees.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) "
                    Else
                        Filter = EmpStatus & "And  {View_Rpt_Acc_AllEmployees.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) "

                    End If
                ElseIf MainDept.Checked = True Then ' Main Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    End If
                ElseIf Section.Checked = True ' Section Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.subdept1}  = '" & SectionNameComboBox.Text & "' "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.subdept1}  = '" & SectionNameComboBox.Text & "' "
                    End If
                ElseIf Deigantionbtn.Checked = True ' Desig Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.Designame}  = '" & DesigNameComboBox.Text & "'"
                    Else
                        Filter = EmpStatus & "And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "   And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate})   And {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigNameComboBox.Text & "'"
                    End If
                End If




            End If
        End If
        If RadioButton6.Checked Then
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\RptMissingContData.rpt"
            Filter = "{ContractorData;1.CardNo} >= 50000"
            Param = "@AttYear=" & Me.Bymonth.Value.Year & " &@AttMon=" & Me.Bymonth.Value.Month & ""
        End If
        ''' Missing Pictures
        If MissBtn.Checked = True Then ' Missing pic RPT

            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\rptPayRolCOnWithoutPics.rpt"
            If AllButton.Checked = True Then ' All EMp
                If AllDept.Checked = True Then ' Alll Dept
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true"
                ElseIf MainDept.Checked = True Then ' Main Dept
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf Section.Checked = True Then ' Section 
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {View_Rpt_PayRoll_EmpWithoutPicture.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then 'by Designation 
                    Filter = "{View_Rpt_PayRoll_EmpWithoutPicture.empstatus} = true and {View_Rpt_PayRoll_EmpWithoutPicture.DesignationID} = " & DesigNameComboBox.SelectedValue & ""
                End If
            End If
        End If
        If RadioButton5.Checked Then
            'Path = "" & frmLogin.ReportsPath & "\Accounts\Contractors\RptContPaymentOLD.rpt"
            Path = "" & frmLogin.ReportsPath & "\Accounts\Contractors\RptContPayment.rpt"
            Filter = EmpStatus & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""

        End If

        If RadioButton7.Checked Then
            'Path = "" & frmLogin.ReportsPath & "\Accounts\Contractors\rptAccCotractorPayeeSlip.rpt"
            'Filter = ""

            '''''''''''''''''''''''''''''''''''''''''

            Path = "" & frmLogin.ReportsPath & "\Accounts\Contractors\rptAccCotractorPayeeSlip.rpt"
            If AllButton.Checked = True Then ' By date
                    Flag = False
                    If AllDept.Checked = True Then ' All Emp

                        Filter = "Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                    ElseIf MainDept.Checked = True Then 'By Dept

                    Filter = "Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf Section.Checked = True Then ' Section wise
                    Filter = "Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' Desigtion Wise
                        Filter = "Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                    End If
                ElseIf CardRange.Checked = True Then 'By card 
                    If AllDept.Checked = True Then ' All Emp
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " "

                    End If
                    ElseIf MainDept.Checked = True Then ' Main Dept
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    End If
                    ElseIf Section.Checked = True Then ' Section Wise
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & " "
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & ""
                    End If
                    ElseIf Deigantionbtn.Checked = True Then ' Desig Wise
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "   And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                    End If
                    End If




                End If
            End If



        ''''''''''''''''''''''''''''''''''''''''''''


        If RadioButton3.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\Accounts\Contractors\RptContPaymentMarch.rpt"
            If AllButton.Checked = True Then ' By date
                Flag = False
                If AllDept.Checked = True Then ' All Emp

                    Filter = EmpStatus & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                ElseIf MainDept.Checked = True Then 'By Dept

                    Filter = EmpStatus & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf Section.Checked = True ' Section wise
                    Filter = EmpStatus & " and  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True ' Desigtion Wise
                    Filter = EmpStatus & " and Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf CardRange.Checked = True 'By card 
                If AllDept.Checked = True Then ' All Emp
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_ActiveSalaryTransactions.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " "
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_ActiveSalaryTransactions.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " "

                    End If
                ElseIf MainDept.Checked = True Then ' Main Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_ActiveSalaryTransactions.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    End If
                ElseIf Section.Checked = True ' Section Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & " "
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & ""
                    End If
                ElseIf Deigantionbtn.Checked = True ' Desig Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " and {View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " and {View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "   And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If




            End If
        End If
        Dim COnID = 2
        If AbsnBtn.Checked = True Then ' Daily Absent Report
            Path = "" & frmLogin.ReportsPath & "\HR\Contractual\rptConDailyAbsentList.rpt"
            Param = "@AttYear=" & Bymonth.Value.Year & "&@AttMon=" & Bymonth.Value.Month & "&@AttDay=" & Bymonth.Value.Day & ""

            If AllButton.Checked = True Then ' By date 
                Flag = False
                If AllDept.Checked = True Then ' All Dept

                    Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & ""
                ElseIf MainDept.Checked = True Then ' Main Dept 
                    Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & " And {MissingAttendence;1.Deptname}= '" & DeptNameComboBox.Text & "'"
                ElseIf Section.Checked = True Then ' Section 
                    Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.Deptname}= '" & DeptNameComboBox.Text & "' And {MissingAttendence;1.SubDept1}= '" & SectionNameComboBox.Text & "' "
                ElseIf Deigantionbtn.Checked = True Then ' By Desig 
                    Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.Designame}= '" & DesigNameComboBox.Text & "'"
                End If

            ElseIf CardRange.Checked = True ' By card 
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & ""
                    End If
                ElseIf MainDept.Checked = True ' Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & " And {MissingAttendence;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {MissingAttendence;1.DeptName} = '" & DeptNameComboBox.Text & "' "
                    Else

                        Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {MissingAttendence;1.DeptName} = '" & DeptNameComboBox.Text & "' "
                    End If
                ElseIf Section.Checked = True ' Section 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And  {MissingAttendence;1.DeptName} = '" & DeptNameComboBox.Text & "' And {MissingAttendence;1.SubDept1} = '" & SectionNameComboBox.Text & "' "
                    Else
                        Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And   {MissingAttendence;1.DeptName} = '" & DeptNameComboBox.Text & "' And {MissingAttendence;1.SubDept1} = '" & SectionNameComboBox.Text & "' "
                    End If
                ElseIf Deigantionbtn.Checked = True ' Desig 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = " {MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And  {MissingAttendence;1.DesigName} = '" & DesigNameComboBox.Text & "' "
                    Else

                        Filter = "{MissingAttendence;1.EmploymentID} = " & COnID & " And  {MissingAttendence;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And   {MissingAttendence;1.DesigName} = '" & DesigNameComboBox.Text & "' "
                    End If
                End If

            End If
        End If

        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If




        If RadioButton5.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\Accounts\Contractors\RptContPayment.rpt"
            If AllButton.Checked = True Then ' By date
                Flag = False
                If AllDept.Checked = True Then ' All Emp

                    Filter = "Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & ""
                ElseIf MainDept.Checked = True Then 'By Dept

                    Filter = "Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf Section.Checked = True Then ' Section wise
                    Filter = "Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' Desigtion Wise
                    Filter = "Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                End If
            ElseIf CardRange.Checked = True Then 'By card 
                If AllDept.Checked = True Then ' All Emp
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & " "

                    End If
                ElseIf MainDept.Checked = True Then ' Main Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.CardNo} In  " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    Else
                        Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    End If
                ElseIf Section.Checked = True Then ' Section Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & " "
                    Else
                        Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.SectioniD}  = " & SectionNameComboBox.SelectedValue & ""
                    End If
                ElseIf Deigantionbtn.Checked = True Then ' Desig Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox1.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                    Else
                        Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.CardNo} in " & Me.TextBox1.Text & " to " & Me.TextBox2.Text & "   And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & Bymonth.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & Bymonth.Value.Month & "   And {View_Rpt_Acc_ActiveSalaryTransactions.DesignationID}  = " & DesigNameComboBox.SelectedValue & ""
                    End If
                End If




            End If
        End If

    End Sub
    Private Flag As Boolean = False

    Private Sub AllDept_CheckedChanged(sender As Object, e As EventArgs) Handles AllDept.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub CardRange_CheckedChanged(sender As Object, e As EventArgs) Handles CardRange.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Enabled = True
    End Sub

    Private Sub AllButton_CheckedChanged(sender As Object, e As EventArgs) Handles AllButton.CheckedChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub EOBiEmpBtn_CheckedChanged(sender As Object, e As EventArgs) Handles EOBiEmpBtn.CheckedChanged, RadioButton3.CheckedChanged, RadioButton5.CheckedChanged, RadioButton7.CheckedChanged
        Bymonth.Enabled = True
        'If EOBiEmpBtn.Checked = True Then
        AllButton.Text = "Select Month "
        'Section.Enabled = False
        'RadioButton3.Enabled = False
        CardRange.Enabled = False
        'Else
        AllButton.Text = "All"
        'Section.Enabled = True
        'RadioButton3.Enabled = True
        CardRange.Enabled = True
        'End If
    End Sub

    Private Sub PESSIEmpBtn_CheckedChanged(sender As Object, e As EventArgs) Handles PESSIEmpBtn.CheckedChanged
        Bymonth.Enabled = True
        If PESSIEmpBtn.Checked = True Then
            AllButton.Text = "Select Month "
            'Section.Enabled = False
            'RadioButton3.Enabled = False
            CardRange.Enabled = False
        Else
            AllButton.Text = "All"
            'Section.Enabled = True
            'RadioButton3.Enabled = True
            CardRange.Enabled = True
        End If
    End Sub

    Private Sub UnionBtn_CheckedChanged(sender As Object, e As EventArgs)
        Bymonth.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        'If RadioButton3.Checked = True Then
        '    ShiftNameComboBox.Enabled = True
        'Else
        '    ShiftNameComboBox.Enabled = False
        'End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        'If Section.Checked = True Then
        '    GradeNameComboBox.Enabled = True
        'Else
        '    GradeNameComboBox.Enabled = False
        'End If
    End Sub

    Private Sub Section_CheckedChanged(sender As Object, e As EventArgs) Handles Section.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub rbtShiftsAndDate_CheckedChanged(sender As Object, e As EventArgs) Handles rbtShiftsAndDate.CheckedChanged
        Bymonth.Enabled = True
        If rbtShiftsAndDate.Checked = True Then
            AllButton.Text = "By Date "
            Bymonth.CustomFormat = "dd/MM/yyyy"
            Label5.Text = "From Date:"
            DateTimePicker1.Enabled = True
        Else
            AllButton.Text = "All"
            Bymonth.CustomFormat = "MMM, yyyy"
            Label5.Text = "Select Month:"
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub MonthAttBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MonthAttBtn.CheckedChanged, RadioButton4.CheckedChanged, RadioButton9.CheckedChanged, RadioButton6.CheckedChanged
        Bymonth.Enabled = True
        If MonthAttBtn.Checked = True Or RadioButton4.Checked Or RadioButton9.Checked Then
            AllButton.Text = "By Date "
            Bymonth.CustomFormat = "dd/MM/yyyy"
            Label5.Text = "From Date:"
            DateTimePicker1.Enabled = True
        Else
            AllButton.Text = "All"
            Bymonth.CustomFormat = "MMM, yyyy"
            Label5.Text = "Select Month:"
            DateTimePicker1.Enabled = False
        End If
    End Sub

    Private Sub MissBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MissBtn.CheckedChanged
        If MissBtn.Checked = True Then
            CardRange.Enabled = False

        Else
            CardRange.Enabled = True

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub AbsnBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AbsnBtn.CheckedChanged
        If AbsnBtn.Checked = True Then
            Bymonth.CustomFormat = "dd/MM/yyyy"
            DateTimePicker1.Enabled = False
            Bymonth.Enabled = True

        Else

            ''DateTimePicker1.Enabled = True
            Bymonth.CustomFormat = "MMM, yyyy"
            ''Bymonth.Enabled = F
        End If
    End Sub
End Class