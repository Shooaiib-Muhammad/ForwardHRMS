Public Class frmPayRollReportSelector3

    Private Sub frmPayRollReportSelector3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_EmpCatagory' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_EmpCatagoryTableAdapter.Fill(Me.DSHRM.tbl_HRM_EmpCatagory)
        'TODO: This line of code loads data into the 'DSHRM.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Employment' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_EmploymentTableAdapter.FillBy2(Me.DSHRM.tbl_Hrm_Employment)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Departments' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_SubDept1' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Working_Day' table. You can move, or remove it, as needed.
        'Me.Tbl_Working_DayTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Working_Day)
        'Me.Tbl_Acc_FinancialPeriodTableAdapter.FillBy(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)
        Try
            Me.Tbl_PayRoll_ShiftsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_PayRoll_Shifts)
        Catch ex As Exception
        End Try

        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        'Me.Tbl_Hrm_SubDept2TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept2)
        Try
            Me.Tbl_Working_DayTableAdapter.Insert(Now.Date)
        Catch ex As Exception
            Try
                Me.Tbl_Working_DayTableAdapter.Insert(Now.Date.AddDays(-1))
            Catch ex1 As Exception
                Try
                    Me.Tbl_Working_DayTableAdapter.Insert(Now.Date.AddDays(-2))
                Catch ex2 As Exception

                End Try
            End Try
        End Try
        If (Me.Tbl_Comp_InfoTableAdapter.FillBy(Me.DSUser.tbl_Comp_Info)) > 0 Then
            RadioButton25.Visible = False
            RadioButton21.Visible = False
            RadioButton5.Visible = False
            RadioButton8.Visible = False
            RadioButton10.Visible = False
        Else
            RadioButton10.Visible = True
            RadioButton25.Visible = True
            RadioButton21.Visible = True
            RadioButton5.Visible = True
            RadioButton8.Visible = True

        End If
        'RadioButton11.Visible = False
        'If frmLogin.DeptID = 3 Or frmLogin.DeptID = 1 Then
        '    RadioButton11.Visible = True
        'Else

        '    RadioButton11.Visible = True

        'End If
    End Sub
    'Private Sub SelectFP()
    '    'Here Obj.ReturnFP() function is a utility function that returns financial period by providing Year and Month
    '    Dim Obj As New UtilityClass()
    '    If Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) <> Nothing Then
    '        FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
    '    Else
    '        MsgBox("Selected year was beyond the running financial period")
    '        DateTimePicker1.Value = Now.Date
    '    End If
    'End Sub
    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        CatagoryNameComboBox.Enabled = False

        RadioButton13.Checked = True
        DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        If AbsnBtn.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False
        End If



        'DateTimePicker1.Enabled = True
        'DateTimePicker2.Enabled = True
        'DateTimePicker4.Enabled = False
        'TextBox3.Enabled = False
        'TextBox4.Enabled = False
        'ShiftNameComboBox.Enabled = False

        'TextBox1.Enabled = False
        'TextBox2.Enabled = False
    End Sub

    'Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
    '    DateTimePicker4.Enabled = True
    '    DateTimePicker1.Enabled = False
    '    DateTimePicker2.Enabled = False
    '    TextBox3.Enabled = False
    '    TextBox4.Enabled = False
    '    ShiftNameComboBox.Enabled = False
    '    TextBox1.Enabled = False
    '    TextBox2.Enabled = False

    'End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged
        RadioButton13.Checked = True
        CatagoryNameComboBox.Enabled = False
        If RadioButton31.Checked = True Then
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            RadioButton13.Checked = True
        Else
            TextBox3.Enabled = False
            TextBox4.Enabled = False
        End If
        If AbsWthSnap.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False
        End If

        If rbtShiftsAndDate.Checked = True Or DetailsAtt.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If

    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        CatagoryNameComboBox.Enabled = False
        RadioButton13.Checked = True
        If RadioButton32.Checked = True Then
            ShiftNameComboBox.Enabled = True

        Else
            ShiftNameComboBox.Enabled = False
        End If
        If rbtShiftsAndDate.Checked = True Or DetailsAtt.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
        BranchNameComboBox.Enabled = False
        If AbsWthSnap.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton33_CheckedChanged(sender As Object, e As EventArgs)
        Panel3.Enabled = True
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        DateTimePicker4.Enabled = False
        DateTimePicker1.Enabled = False
        DateTimePicker2.Enabled = False

        ShiftNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False

        'If RadioButton3.Checked = True Then
        '    BranchNameComboBox.Enabled = True
        '    ShiftNameComboBox.Enabled = True
        'End If
        'If ByBranch.Checked = True Then
        '    BranchNameComboBox.Enabled = True

        'End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False

    End Sub



    Private Sub rbtShiftsAndDate_CheckedChanged(sender As Object, e As EventArgs) Handles rbtShiftsAndDate.CheckedChanged
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        GroupBox5.Enabled = True
        RadioButton30.Checked = True
        RadioButton13.Checked = True
        RadioButton30.Enabled = True
        If rbtShiftsAndDate.Checked = True Then
            ComboBox1.Enabled = True
            RadioButton17.Enabled = True
        Else
            ComboBox1.Enabled = False
            RadioButton17.Enabled = False
        End If

    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        RadioButton13.Checked = True
        GroupBox5.Enabled = False

        If RadioButton25.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True

            RadioButton30.Checked = True
            RadioButton13.Enabled = True

        Else


            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
        End If

    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        GroupBox5.Enabled = False
        RadioButton13.Checked = True
        If RadioButton21.Checked = True Then
            RadioButton30.Checked = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True

        Else
            RadioButton30.Checked = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False

        End If


    End Sub

    Dim TimerFlag As Boolean = False
    Dim Entryflag As Boolean = False

    'Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
    '    If RadioButton18.Checked = True Then

    '        GroupBox5.Enabled = True

    '        RadioButton31.Checked = True
    '        RadioButton30.Enabled = False
    '        RadioButton13.Checked = True

    '    Else
    '        GroupBox5.Enabled = False

    '        RadioButton31.Checked = False
    '        RadioButton30.Enabled = True
    '        RadioButton13.Checked = False
    '    End If
    '    filterByMonth()
    '    'TextBox1.Enabled = False
    '    'TextBox2.Enabled = False
    '    'DateTimePicker1.Enabled = True
    '    'DateTimePicker2.Enabled = True
    '    'TextBox3.Enabled = True
    '    'TextBox4.Enabled = True
    'End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Param As String = ""
        Dim Path As String = ""
        Dim Obj As New UtilityClass
        Dim Empstatus As String

        If rbtShiftsAndDate.Checked = True Or DetailsAtt.Checked = True Or RadioButton10.Checked = True Or RadioButton11.Checked = True Then
            If ActiveBtn.Checked = True Then
                Empstatus = "{View_Rpt_Acc_PreSalary.empstatus} = true "
            ElseIf NonActiveBtn.Checked = True Then
                Empstatus = "{View_Rpt_Acc_PreSalary.empstatus} = false "
            ElseIf AllEmp.Checked = True Then
                Empstatus = "({View_Rpt_Acc_PreSalary.empstatus} = True or {View_Rpt_Acc_PreSalary.empstatus} = False)"
            End If
        End If

        If RadioButton1.Checked = True Or RadioButton16.Checked = True Then
            If ActiveBtn.Checked = True Then
                Empstatus = "{View_Rpt_Acc_PreSalary.empstatus}= true "
            ElseIf NonActiveBtn.Checked = True Then
                Empstatus = "{View_Rpt_Acc_PreSalary.empstatus}= False "
            ElseIf AllEmp.Checked = True Then
                Empstatus = "({View_Rpt_Acc_PreSalary.empstatus} = True or {View_Rpt_Acc_PreSalary.empstatus} = False)"
            End If
        End If

        If MonthAttBtn.Checked = True Then
            If ActiveBtn.Checked = True Then
                Empstatus = "{View_Rpt_Acc_AllEmployees.empstatus}= true "
            ElseIf NonActiveBtn.Checked = True Then
                Empstatus = "{View_Rpt_Acc_AllEmployees.empstatus}= False "
            ElseIf AllEmp.Checked = True Then
                Empstatus = "({View_Rpt_Acc_AllEmployees.empstatus} = True or {View_Rpt_Acc_AllEmployees.empstatus} = False)"
            End If
        End If

        If rbtShiftsAndDate.Checked = True Then 'Attendence rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptDailyAttendence.rpt"
            If RadioButton30.Checked = True Then ' by Date
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = Empstatus & "   And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton31.Checked = True Then 'by card 
                If RadioButton13.Checked = True Then ' ALl Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' by Shift
                Flag = False
                'Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "'"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "

                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "

                End If
            ElseIf RadioButton9.Checked = True Then ' By category
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                End If

            ElseIf RadioButton17.Checked = True Then ' By Shift Name
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & " And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "' And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & " And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "' And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "' And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = Empstatus & " And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "' And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "
                End If
            End If


        End If


        If RadioButton12.Checked = True Then

            Filter = " {Tbl_Audit_Employees.Date} = DateTime (" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", 01, 00, 00, 00)"
            Path = "" & frmLogin.ReportsPath & "\HR\AuditReports.rpt"

        End If

        If RadioButton15.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\AuditWorkingHoursReports.rpt"
            Filter = "{Tbl_Audit_Workig_Hours.Date} = DateTime (" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", 01, 00, 00, 00)"


        End If

        If RadioButton11.Checked = True Then 'manual Attendence rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptDailyAttendenceManual.rpt"
            If RadioButton30.Checked = True Then ' by Date
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = Empstatus & "   And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton31.Checked = True Then 'by card 
                If RadioButton13.Checked = True Then ' ALl Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' by Shift
                Flag = False
                'Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf RadioButton9.Checked = True Then ' By category
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If

        If RadioButton10.Checked = True Then '' Att New individual
            Path = "" & frmLogin.ReportsPath & "\PayRoll\Latecommercerpt.rpt"
            If RadioButton30.Checked = True Then ' by Date
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = Empstatus & "   And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton31.Checked = True Then 'by card 
                If RadioButton13.Checked = True Then ' ALl Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' by Shift
                Flag = False
                'Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf RadioButton9.Checked = True Then ' By category
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If




        If DetailsAtt.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollEachEmpAtt4Audit.rpt"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@HFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@HToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@EFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@EToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@MyYear=" & DateTimePicker1.Value.Year & "&@MyMonth=" & DateTimePicker1.Value.Month

            If RadioButton30.Checked = True Then ' by Date
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SubDept1} = '" & SectionNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 


                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                End If
            ElseIf RadioButton31.Checked = True Then 'by card 
                If RadioButton13.Checked = True Then ' ALl Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then

                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                    Else

                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' by Shift
                Flag = False
                'Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
                If RadioButton13.Checked = True Then ' All Emp
                    Flag = False
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SubDept1} = '" & SectionNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' and {View_Rpt_Acc_PreSalary.SubDept1} = '" & SectionNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"

                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' and {View_Rpt_Acc_PreSalary.SubDept1} = '" & SectionNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"

                End If
            ElseIf RadioButton9.Checked = True Then ' By Category
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SubDept1} = '" & SectionNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})"
                End If
            End If
        End If





        If RadioButton1.Checked = True Then ' Att Summary Rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptEmpAttSummary.rpt"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@HFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@HToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@EFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@EToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@MyYear=" & DateTimePicker1.Value.Year & "&@MyMonth=" & DateTimePicker1.Value.Month

            If RadioButton30.Checked = True Then ' By date
                Flag = False
                If RadioButton13.Checked = True Then ' Alii Emp
                    Flag = False
                    Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept Wise
                    Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then 'Section Wise

                    Filter = Empstatus & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And{View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise 

                    Filter = Empstatus & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"

                End If
            ElseIf RadioButton31.Checked = True Then 'By card 
                If RadioButton13.Checked = True Then ' All Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    Else
                        Filter = Empstatus & "  And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}= '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    Else
                        Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And   {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    Else
                        Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & "And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    Else
                        Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then 'by Shift
                Flag = False
                If RadioButton13.Checked = True Then ' All  Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName}= '" & SectionNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By branch
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "


                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_PreSalary.SectionName}  = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame}  = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "

                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "    And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "


                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_PreSalary.SectionName}  = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame}  = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "

                End If
            ElseIf RadioButton9.Checked = True Then ' By Category 
                If RadioButton13.Checked = True Then ' Alii Emp
                    Flag = False
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And    {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept Wise
                    Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then 'Section Wise

                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And{View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise 

                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"

                End If
            End If

        End If

        If RadioButton16.Checked = True Then ' New Att Summary Rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptEmpAttSummaryNormal.rpt"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@HFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@HToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@EFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@EToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@MyYear=" & DateTimePicker1.Value.Year & "&@MyMonth=" & DateTimePicker1.Value.Month

            If RadioButton30.Checked = True Then ' By date
                Flag = False
                If RadioButton13.Checked = True Then ' Alii Emp
                    Flag = False
                    Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept Wise
                    Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then 'Section Wise

                    Filter = Empstatus & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And{View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise 

                    Filter = Empstatus & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"

                End If
            ElseIf RadioButton31.Checked = True Then 'By card 
                If RadioButton13.Checked = True Then ' All Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    Else
                        Filter = Empstatus & "  And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}= '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    Else
                        Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And   {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    Else
                        Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & "And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    Else
                        Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then 'by Shift
                Flag = False
                If RadioButton13.Checked = True Then ' All  Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName}= '" & SectionNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By branch
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "


                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_PreSalary.SectionName}  = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame}  = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "

                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "    And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "


                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_PreSalary.SectionName}  = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame}  = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate}  In #" & Format(Me.DateTimePicker1.Value, "yyyy/MM/dd") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "# "

                End If
            ElseIf RadioButton9.Checked = True Then ' By Category 
                If RadioButton13.Checked = True Then ' Alii Emp
                    Flag = False
                    Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And    {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept Wise
                    Filter = Empstatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then 'Section Wise

                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And{View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise 

                    Filter = Empstatus & "  And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_InOutDifference.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "yyyy/MM/dd") & "#"

                End If
            End If

        End If


        If MonthAttBtn.Checked = True Then ' Complete Month Att Rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptFullMonthAttendance.rpt"
            Param = "FromDate=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "&ToDate=" & Format(Me.DateTimePicker2.Value, "dd/MM/yyyy") & "&AttFromDate=" & Format(Me.DateTimePicker1.Value, "dd/MM/yyyy") & "&AttToDate=" & Format(Me.DateTimePicker2.Value, "dd/MM/yyyy")
            If RadioButton30.Checked = True Then ' By date
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf RadioButton6.Checked = True Then 'By Dept

                    Filter = Empstatus & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section wise
                    Filter = Empstatus & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SubDept1}  = '" & SectionNameComboBox.Text & "' "
                ElseIf RadioButton2.Checked = True Then ' Desigtion Wise
                    Filter = Empstatus & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf RadioButton31.Checked = True Then 'By card 
                If RadioButton13.Checked = True Then ' All Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & "And  {View_Rpt_Acc_AllEmployees.CardNo} In  " & Me.TextBox3.Text & " to " & Me.TextBox3.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""
                    Else
                        Filter = Empstatus & "And  {View_Rpt_Acc_AllEmployees.CardNo} In  " & Me.TextBox3.Text & " to " & Me.TextBox4.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""

                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In  " & Me.TextBox3.Text & " to " & Me.TextBox3.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox3.Text & " to " & Me.TextBox4.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox3.Text & " to " & Me.TextBox3.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.subdept1}  = '" & SectionNameComboBox.Text & "' "
                    Else
                        Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox3.Text & " to " & Me.TextBox4.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.subdept1}  = '" & SectionNameComboBox.Text & "' "
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox3.Text & " to " & Me.TextBox3.Text & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.Designame}  = '" & DesigNameComboBox.Text & "'"
                    Else
                        Filter = Empstatus & "And {View_Rpt_Acc_AllEmployees.CardNo} in " & Me.TextBox3.Text & " to " & Me.TextBox4.Text & "   And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigNameComboBox.Text & "'"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then 'by Shift
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""

                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_AllEmployees.SubDept1}  = '" & SectionNameComboBox.Text & "'"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.Designame}  = '" & DesigNameComboBox.Text & "'"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch 
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""


                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_AllEmployees.SubDept1}  = '" & SectionNameComboBox.Text & "'"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.Designame}  = '" & DesigNameComboBox.Text & "'"

                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""


                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = Empstatus & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = Empstatus & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'   And {View_Rpt_Acc_AllEmployees.SubDept1}  = '" & SectionNameComboBox.Text & "'"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = Empstatus & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.Designame}  = '" & DesigNameComboBox.Text & "'"

                End If
            ElseIf RadioButton9.Checked = True Then ' By Category
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.EmpcatagoryID}=" & CatagoryNameComboBox.SelectedValue & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf RadioButton6.Checked = True Then 'By Dept

                    Filter = Empstatus & " And  {View_Rpt_Acc_AllEmployees.EmpcatagoryID}=" & CatagoryNameComboBox.SelectedValue & " And({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section wise
                    Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.EmpcatagoryID}=" & CatagoryNameComboBox.SelectedValue & " And ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SubDept1}  = '" & SectionNameComboBox.Text & "' "
                ElseIf RadioButton2.Checked = True Then ' Desigtion Wise
                    Filter = Empstatus & " And {View_Rpt_Acc_AllEmployees.EmpcatagoryID}=" & CatagoryNameComboBox.SelectedValue & " And  ({View_Rpt_PayRoll_AttList.AttDate}  in {?FromDate} to {?ToDate}) And {View_Rpt_Acc_AllEmployees.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigNameComboBox.Text & "'"
                End If

            End If
        End If









        If RadioButton25.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptLateCommers.rpt"
            If RadioButton30.Checked = True Then ' By date
                Flag = False
                If RadioButton13.Checked = True Then ' All 

                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = " {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton31.Checked = True Then ' card + late Commers 

                If RadioButton13.Checked = True Then
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton6.Checked = True Then ' Dept+ CardNo+latecommers 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section+ CardNo+latecommers 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig+ CardNo+latecommers 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' by Shift
                Flag = False
                If RadioButton13.Checked = True Then
                    ' Shift + late Commers 
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Shift + Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Shift + Section
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' shift+ Desig
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch 
                Flag = False
                If RadioButton13.Checked = True Then ' All 

                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = " {View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All 

                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & "   And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = " {View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton9.Checked = True Then ' by category
                Flag = False
                If RadioButton13.Checked = True Then ' All 

                    Filter = "{View_Rpt_PayRoll_LateCommers.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = "{View_Rpt_PayRoll_LateCommers.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And   {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_PayRoll_LateCommers.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If





        If RadioButton5.Checked = True Then 'IN Time attendence rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptDailyAttendence.rpt"
            If RadioButton30.Checked = True Then ' By date
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton6.Checked = True Then ' DepWise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                End If
            ElseIf RadioButton31.Checked = True Then ' By card
                If RadioButton13.Checked = True Then ' All EMp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    End If
                ElseIf RadioButton6.Checked = True Then ' Dept Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And{View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And{View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And{View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' by SHift
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' by Branch 
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton6.Checked = True Then ' DepWise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                End If
            ElseIf RadioButton3.Checked = True Then ' By shift And Branch 
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton6.Checked = True Then ' DepWise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                End If
            ElseIf RadioButton9.Checked = True Then ' By category
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = "{View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If



        If RadioButton8.Checked = True Then 'Out Time attendence rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptDailyAttendence.rpt"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@HFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@HToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@EFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@EToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@MyYear=" & DateTimePicker1.Value.Year & "&@MyMonth=" & DateTimePicker1.Value.Month
            If RadioButton30.Checked = True Then ' By date 
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton6.Checked = True Then ' DepWise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                End If
            ElseIf RadioButton31.Checked = True Then ' by Card
                If RadioButton13.Checked = True Then '  All Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    End If
                ElseIf RadioButton6.Checked = True Then ' MAin DEpt
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And{View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' by shift
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.OutTime} <=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton6.Checked = True Then ' DepWise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton6.Checked = True Then ' DepWise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} = #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy") & "# And {View_Att_DayGroup.InTime} >=  #" & Format(Me.DateTimePicker4.Value, "MM/dd/yyyy hh:mm tt") & "#"
                End If
            ElseIf RadioButton9.Checked = True Then ' By category
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = "{View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If



        If RadioButton21.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollEachEmpAttActualInOut.rpt"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@HFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@HToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@EFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@EToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@MyYear=" & DateTimePicker1.Value.Year & "&@MyMonth=" & DateTimePicker1.Value.Month

            If RadioButton30.Checked = True Then ''  By date
                Flag = False
                If RadioButton13.Checked = True Then 'All Emp
                    Filter = "({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And  ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = "{View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                End If
            ElseIf RadioButton31.Checked = True Then ' By card No
                Filter = "({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                If RadioButton13.Checked = True Then ' All Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "  And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wiese
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "  And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "  And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' BY shift

                Flag = False

                If RadioButton13.Checked = True Then ' Alll EMp

                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"

                End If
            ElseIf ByBranch.Checked = True Then ' bY Branch
                Flag = False
                If RadioButton13.Checked = True Then 'All Emp
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And  ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                End If
            ElseIf RadioButton3.Checked = True Then ' By SHift And Branch
                Flag = False
                If RadioButton13.Checked = True Then 'All Emp
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And  {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And  {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And  {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And  ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "   And  {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                End If
            ElseIf RadioButton9.Checked = True Then ' By category
                Flag = False
                If RadioButton13.Checked = True Then 'All Emp
                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & SectionNameComboBox.Text & "'And  ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})"
                End If
            End If
        End If





        If RadioButton4.Checked = True Then ' Early leaving Rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptEarlyLeaving.rpt"
            If RadioButton30.Checked = True Then ' By date 
                Flag = False
                If RadioButton13.Checked = True Then ' All 

                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And   {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton31.Checked = True Then ' card + late Commers 

                If RadioButton13.Checked = True Then
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton6.Checked = True Then ' Dept+ CardNo+latecommers 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section+ CardNo+latecommers 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig+ CardNo+latecommers 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' By Shift
                Flag = False
                If RadioButton13.Checked = True Then

                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Shift + Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Shift + Section
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' shift+ Desig
                    Filter = "{View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioButton13.Checked = True Then ' All 

                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And   {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton3.Checked = True Then  ' By shift And Branch 
                Flag = False
                If RadioButton13.Checked = True Then ' All 

                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = "{View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & "And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And   {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_PayRoll_LateCommers.BranchID} = " & BranchNameComboBox.SelectedValue & "And  {View_Rpt_PayRoll_LateCommers.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton9.Checked = True Then ' by category
                Flag = False
                If RadioButton13.Checked = True Then ' All 

                    Filter = "{View_Rpt_PayRoll_LateCommers.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then ' Dept
                    Filter = "{View_Rpt_PayRoll_LateCommers.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section
                    Filter = "{View_Rpt_PayRoll_LateCommers.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And   {View_Rpt_PayRoll_LateCommers.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then ' Desig
                    Filter = " {View_Rpt_PayRoll_LateCommers.EmpCatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LateCommers.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LateCommers.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If



        If AbsnBtn.Checked = True Then ' Daily Absent Report
            Path = "" & frmLogin.ReportsPath & "\PayRoll\Absent Rpt\rptEmpDailyAbsentListNEW.rpt"
            Param = "@AttYear=" & DateTimePicker1.Value.Year & "&@AttMon=" & DateTimePicker1.Value.Month & "&@AttDay=" & DateTimePicker1.Value.Day & ""

            If RadioButton30.Checked = True Then ' By date 
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Mail.SubDept1}= '" & SectionNameComboBox.Text & "'  "
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Designame}= '" & DesigNameComboBox.Text & "' "
                End If

            ElseIf RadioButton31.Checked = True Then ' By card 
                If RadioButton13.Checked = True Then
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " "
                    Else

                        Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " "
                    End If
                ElseIf RadioButton6.Checked = True Then ' Dept 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then

                        Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "    "
                    Else

                        Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Rpt_Emp_Mail.DeptName} = '" & DeptNameComboBox.Text & "' "
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And  {View_Rpt_Emp_Mail.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Mail.SubDept1} = '" & SectionNameComboBox.Text & "'  "
                    Else
                        Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And   {View_Rpt_Emp_Mail.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Mail.SubDept1} = '" & SectionNameComboBox.Text & "'  "
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then

                        Filter = " {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And  {View_Rpt_Emp_Mail.DesigName} = '" & DesigNameComboBox.Text & "' "
                    Else

                        Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And   {View_Rpt_Emp_Mail.DesigName} = '" & DesigNameComboBox.Text & "'  "
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' By Shift
                Flag = False ' 
                If RadioButton13.Checked = True Then


                    Filter = " {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {tbl_HRM_Shift.Shift} ='" & ComboBox1.Text & "'"
                ElseIf RadioButton6.Checked = True Then ' Shift + Dept

                    Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And   {View_Rpt_Emp_Mail.DeptName} = '" & DeptNameComboBox.Text & "' "

                ElseIf RadioButton7.Checked = True Then  ' Shift + Section

                    Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And   {View_Rpt_Emp_Mail.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Mail.SubDept1} = '" & SectionNameComboBox.Text & "' "

                ElseIf RadioButton2.Checked = True Then  ' shift+ Desig

                    Filter = " {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And   {View_Rpt_Emp_Mail.DesigName} = '" & DesigNameComboBox.Text & "'  And {tbl_HRM_Shift.Shift} =' " & ComboBox1.Text & "'"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch 
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = "{View_Rpt_Emp_Mail.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = "{View_Rpt_Emp_Mail.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "' "
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Emp_Mail.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Mail.SubDept1}= '" & SectionNameComboBox.Text & "'  "
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = "{View_Rpt_Emp_Mail.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Designame}= '" & DesigNameComboBox.Text & "' "
                End If
            ElseIf RadioButton3.Checked = True Then ' B Branch And Shift
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = "{View_Rpt_Emp_Mail.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_Emp_Mail.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = "{View_Rpt_Emp_Mail.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "' "
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Emp_Mail.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Mail.SubDept1}= '" & SectionNameComboBox.Text & "' "
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = "{View_Rpt_Emp_Mail.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Designame}= '" & DesigNameComboBox.Text & "' "
                End If
            ElseIf RadioButton9.Checked = True Then ' By catagory
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = "{View_Rpt_Emp_Mail.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " "
                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = "{View_Rpt_Emp_Mail.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "' "
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Emp_Mail.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Mail.SubDept1}= '" & SectionNameComboBox.Text & "' "
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = "{View_Rpt_Emp_Mail.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Designame}= '" & DesigNameComboBox.Text & "' "
                End If
            ElseIf RadioButton17.Checked = True Then ' By Shift Name
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = "{View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "'"
                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = " {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "'  And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = " {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Deptname}= '" & DeptNameComboBox.Text & "' And {View_Rpt_Emp_Mail.SubDept1}= '" & SectionNameComboBox.Text & "'  And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "'"
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = " {View_Rpt_Emp_Mail.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Rpt_Emp_Mail.Designame}= '" & DesigNameComboBox.Text & "'  And {tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "'"
                End If
            End If
        End If







        If AbsWthSnap.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAbsentEmpList.rpt"
            Param = "@AttYear=" & DateTimePicker1.Value.Year & "& @AttMon=" & DateTimePicker1.Value.Month & "&@AttDay=" & DateTimePicker1.Value.Day & ""

            If RadioButton30.Checked = True Then ' By date 
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = " {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""


                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = " {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {MissingAttendence1;1.DeptName}= '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = " {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.Deptname}= '" & DeptNameComboBox.Text & "' And {MissingAttendence1;1.SubDept1}= '" & SectionNameComboBox.Text & "' "
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = " {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.Designame}= '" & DesigNameComboBox.Text & "'"
                End If

            ElseIf RadioButton31.Checked = True Then ' By card 
                If RadioButton13.Checked = True Then
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " "
                    Else

                        Filter = "{View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & ""
                    End If
                ElseIf RadioButton6.Checked = True Then ' Dept 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then

                        Filter = "{View_Emp_Snaps_Info.EmploymentID}= " & EmploymentNameComboBox.SelectedValue & " And {MissingAttendence1;1.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And {MissingAttendence1;1.DeptName} = '" & DeptNameComboBox.Text & "' "
                    Else

                        Filter = "{View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {MissingAttendence1;1.DeptName} = '" & DeptNameComboBox.Text & "' "
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then

                        Filter = " {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And  {MissingAttendence1;1.DeptName} = '" & DeptNameComboBox.Text & "' And {MissingAttendence1;1.SubDept1} = '" & SectionNameComboBox.Text & "' "
                    Else

                        Filter = "{View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And   {MissingAttendence1;1.DeptName} = '" & DeptNameComboBox.Text & "' And {MissingAttendence1;1.SubDept1} = '" & SectionNameComboBox.Text & "' "
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig 
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then

                        Filter = " {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And  {MissingAttendence1;1.DesigName} = '" & DesigNameComboBox.Text & "' "
                    Else

                        Filter = "{View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And   {MissingAttendence1;1.DesigName} = '" & DesigNameComboBox.Text & "' "
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' By Shift
                Flag = False ' 
                If RadioButton13.Checked = True Then

                    Filter = "{View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Emp_Snaps_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & " "
                ElseIf RadioButton6.Checked = True Then ' Shift + Dept

                    Filter = "{View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Emp_Snaps_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And   {MissingAttendence1;1.DeptName} = '" & DeptNameComboBox.Text & "'"

                ElseIf RadioButton7.Checked = True Then ' Shift + Section

                    Filter = "{View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Emp_Snaps_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And   {MissingAttendence1;1.DeptName} = '" & DeptNameComboBox.Text & "' And {MissingAttendence1;1.SubDept1} = '" & SectionNameComboBox.Text & "'  "

                ElseIf RadioButton2.Checked = True Then ' shift+ Desig
                    Filter = "{View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Emp_Snaps_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And   {MissingAttendence1;1.DesigName} = '" & DesigNameComboBox.Text & "' "

                End If
            ElseIf ByBranch.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = "{View_Emp_Snaps_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = "{View_Emp_Snaps_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {MissingAttendence1;1.Deptname}= '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = "{View_Emp_Snaps_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.Deptname}= '" & DeptNameComboBox.Text & "' And {MissingAttendence1;1.SubDept1}= '" & SectionNameComboBox.Text & "' "
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = "{View_Emp_Snaps_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.Designame}= '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = "{View_Emp_Snaps_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Snaps_Info.BranchID} = " & BranchNameComboBox.SelectedValue & "  And   {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""
                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = "{View_Emp_Snaps_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Snaps_Info.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {MissingAttendence1;1.Deptname}= '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = "{View_Emp_Snaps_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Snaps_Info.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.Deptname}= '" & DeptNameComboBox.Text & "' And {MissingAttendence1;1.SubDept1}= '" & SectionNameComboBox.Text & "' "
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = "{View_Emp_Snaps_Info.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Snaps_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.Designame}= '" & DesigNameComboBox.Text & "'"
                End If
            ElseIf RadioButton9.Checked = True Then ' By catagory
                Flag = False
                If RadioButton13.Checked = True Then ' All Dept

                    Filter = " {View_Emp_Snaps_Info.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & ""


                ElseIf RadioButton6.Checked = True Then ' Main Dept 
                    Filter = " {View_Emp_Snaps_Info.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And {MissingAttendence1;1.DeptName}= '" & DeptNameComboBox.Text & "'"
                ElseIf RadioButton7.Checked = True Then ' Section 
                    Filter = " {View_Emp_Snaps_Info.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And  {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.Deptname}= '" & DeptNameComboBox.Text & "' And {MissingAttendence1;1.SubDept1}= '" & SectionNameComboBox.Text & "' "
                ElseIf RadioButton2.Checked = True Then ' By Desig 
                    Filter = "{View_Emp_Snaps_Info.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And   {View_Emp_Snaps_Info.EmploymentID} = " & EmploymentNameComboBox.SelectedValue & " And  {MissingAttendence1;1.Designame}= '" & DesigNameComboBox.Text & "'"
                End If
            End If
        End If

        If RadioButton14.Checked Then ''' Shorts Mints
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccPreShortMints.rpt"
            If RadioButton30.Checked = True Then ' by Date
                Flag = False
                If RadioButton13.Checked = True Then ' All EMp

                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And  {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = " {View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                End If
            ElseIf RadioButton31.Checked = True Then 'by card 
                If RadioButton13.Checked = True Then ' ALl Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    Else
                        Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    End If
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    Else
                        Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    End If
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Mian_OT_Late_Report.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    Else
                        Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Mian_OT_Late_Report.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    End If
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Mian_OT_Late_Report.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    Else
                        Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Mian_OT_Late_Report.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    End If
                End If
            ElseIf RadioButton32.Checked = True Then ' by Shift
                Flag = False
                'Filter = Empstatus & " And {View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = " {View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = " {View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""

                End If
            ElseIf RadioButton3.Checked = True Then
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = " {View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton6.Checked = True Then ' Main Dept
                    Filter = " {View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = " {View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.BranchID} = " & BranchNameComboBox.SelectedValue & "And {View_Mian_OT_Late_Report.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Mian_OT_Late_Report.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Mian_OT_Late_Report.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton2.Checked = True Then ' Desig Wise
                    Filter = "{View_Mian_OT_Late_Report.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.BranchID} = " & ShiftNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Mian_OT_Late_Report.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Mian_OT_Late_Report.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Mian_OT_Late_Report.Year} = " & Me.DateTimePicker1.Value.Year & ""

                End If

            End If


        End If



        If HiringBtn.Checked = True Then ' New Hiring Rpt
            Path = "" & frmLogin.ReportsPath & "\HR\NewHiringRpt.rpt"
            If RadioButton30.Checked = True Then ' by Date
                Flag = False
                If RadioButton13.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Emp_Info.DateOfJoning} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus}= True And {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.DateOfJoning} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If


        If TerListBtn.Checked = True Then '' Termination Lists
            Path = "" & frmLogin.ReportsPath & "\PayRoll\PayROllTermListRpt.rpt"
            If RadioButton13.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And   {tbl_Acc_Termination_Transactions.TerminationDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton6.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_Termination_Transactions.TerminationDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton7.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & "And  {tbl_HRM_Emp_Info.Subdept1ID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_Acc_Termination_Transactions.TerminationDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton2.Checked = True Then
                Filter = "{tbl_HRM_Emp_Info.EmpStatus}= false And  {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_Termination_Transactions.TerminationDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            End If
        End If


        If RadioButton18.Checked = True Then '' late Commerce
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptDailyAttendenceMail.rpt"
            If RadioButton30.Checked = True Then '' By Date
                Filter = "{View_Att_DayGroup.AttDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton32.Checked = True Then ' By Shift
                Filter = "{View_Att_DayGroup.ShiftID}= " & ShiftNameComboBox.SelectedValue & "  And   {View_Att_DayGroup.AttDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton17.Checked = True Then '' By Shift name
                Filter = "{tbl_HRM_Shift.Shift} = '" & ComboBox1.Text & "' And  {View_Att_DayGroup.AttDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            End If
        End If
        If RadioButton19.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\Rpt_PayRoll_Shortleaves.rpt"
            Flag = False
            If RadioButton30.Checked = True Then '' By Date

                Filter = "{View_Rpt_PayRoll_ShortLeave.Month} = " & Format(Me.DateTimePicker1.Value.Month) & " And {View_Rpt_PayRoll_ShortLeave.Year} = " & Format(Me.DateTimePicker1.Value.Year) & ""

            End If
        End If

        If RadioButton20.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptVisitAttendenceMail.rpt"
            Flag = False
            If RadioButton30.Checked = True Then '' By Date

                Filter = "{View_Att_DayGroup.AttDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

            End If
        End If
        If RadioButton22.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptOT.rpt"
            Flag = False
            If RadioButton30.Checked = True Then '' By Date


                If RadioButton13.Checked = True Then ' All EMp

                    Filter = "{View_Union_NE_OT.AttDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton6.Checked = True Then 'mani Dept
                    Filter = "{View_Rpt_Acc_AllEmployees_3.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Union_NE_OT.AttDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton7.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_AllEmployees_3.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees_3.SubDept1} = '" & SectionNameComboBox.Text & "' And {View_Union_NE_OT.AttDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf RadioButton2.Checked = True Then '  Deig Wise 
                    Filter = "{View_Rpt_Acc_AllEmployees_3.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Union_NE_OT.AttDate} In  #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If

        If Flag = True Then
            MessageBox.Show("Start Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If


    End Sub



    Dim Flag As Boolean = False

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DesigNameComboBox.Enabled = True
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False

    End Sub



    'Private Sub Tbl_Hrm_DepartmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
    '    Me.Validate()
    '    Me.Tbl_Hrm_DepartmentsBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DSDeptsForPayrollReport)

    'End Sub



    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        RadioButton13.Checked = True
        GroupBox5.Enabled = False
        If RadioButton5.Checked = True Then
            DateTimePicker4.Enabled = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False

            RadioButton30.Checked = True
            RadioButton13.Enabled = True

        Else
            DateTimePicker4.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True


        End If

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        GroupBox5.Enabled = False
        RadioButton13.Checked = True
        If RadioButton8.Checked = True Then
            DateTimePicker4.Enabled = True
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False

            RadioButton30.Checked = True
            RadioButton13.Enabled = True

        Else
            DateTimePicker4.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True


        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        RadioButton13.Checked = True
        GroupBox5.Enabled = False
        If RadioButton4.Checked = True Then
            RadioButton30.Checked = True

            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            RadioButton13.Enabled = True


        Else

            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False

        End If

    End Sub

    Private Sub AbsnBtn_CheckedChanged(sender As Object, e As EventArgs) Handles AbsnBtn.CheckedChanged
        GroupBox5.Enabled = False
        RadioButton13.Checked = True
        If AbsnBtn.Checked = True Then
            ComboBox1.Enabled = True
            RadioButton17.Enabled = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False
            RadioButton30.Enabled = True
            RadioButton30.Checked = True

        Else
            RadioButton17.Enabled = True
            ComboBox1.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = True

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton13.Checked = True
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True

            GroupBox5.Enabled = True
            RadioButton30.Checked = True
            RadioButton13.Checked = True
        RadioButton30.Enabled = True
    End Sub

    Private Sub ByBranch_CheckedChanged(sender As Object, e As EventArgs) Handles ByBranch.CheckedChanged
        CatagoryNameComboBox.Enabled = False

        RadioButton13.Checked = True

        If ByBranch.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
        End If
        If rbtShiftsAndDate.Checked = True Or DetailsAtt.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
        ShiftNameComboBox.Enabled = False
        If AbsWthSnap.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub MonthAttBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MonthAttBtn.CheckedChanged
        GroupBox5.Enabled = True
        RadioButton13.Checked = True
        If MonthAttBtn.Checked = True Then

            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            RadioButton31.Checked = True
            RadioButton30.Enabled = False

            RadioButton13.Checked = True

        Else

            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            RadioButton31.Checked = False
            RadioButton30.Enabled = True

            RadioButton13.Checked = False
        End If
    End Sub



    Private Sub DetailsAtt_CheckedChanged(sender As Object, e As EventArgs) Handles DetailsAtt.CheckedChanged

        GroupBox5.Enabled = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            RadioButton31.Checked = True
            RadioButton30.Enabled = False

            RadioButton13.Checked = True



    End Sub

    Private Sub AbsWthSnap_CheckedChanged(sender As Object, e As EventArgs) Handles AbsWthSnap.CheckedChanged
        GroupBox5.Enabled = False
        RadioButton13.Checked = True
        If AbsWthSnap.Checked = True Then

            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False
            RadioButton30.Checked = True


        Else

            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = True

        End If
    End Sub

    'Private Sub EmpAnual_CheckedChanged(sender As Object, e As EventArgs) Handles EmpAnual.CheckedChanged
    '    If EmpAnual.Checked = True Then
    '        EmploymentNameComboBox.Visible = False
    '        FinancialPeriodComboBox.Visible = True
    '        Label11.Text = "Financial Period:"
    '        RadioButton30.Enabled = False
    '        RadioButton31.Checked = True

    '        RadioButton32.Enabled = False
    '        ByBranch.Enabled = False

    '        DateTimePicker1.Enabled = False
    '        DateTimePicker2.Enabled = False

    '        RadioButton13.Checked = True
    '    Else
    '        Label11.Text = "Employment Type:"
    '        EmploymentNameComboBox.Visible = True
    '        FinancialPeriodComboBox.Visible = False
    '        RadioButton30.Enabled = True
    '        RadioButton31.Checked = False
    '        RadioButton32.Enabled = True
    '        ByBranch.Enabled = True

    '        DateTimePicker1.Enabled = True
    '        DateTimePicker2.Enabled = True

    '        RadioButton13.Checked = False
    '    End If
    'End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        CatagoryNameComboBox.Enabled = False
        RadioButton13.Checked = True
        If rbtShiftsAndDate.Checked = True Or DetailsAtt.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
        End If
        If RadioButton3.Checked = True Then
            BranchNameComboBox.Enabled = True
            ShiftNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
            ShiftNameComboBox.Enabled = False
        End If
        If AbsWthSnap.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        CatagoryNameComboBox.Enabled = True
        RadioButton13.Checked = True
        If AbsWthSnap.Checked = True Then
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True

        If RadioButton10.Checked = True Then
            RadioButton9.Enabled = False
        Else
            RadioButton9.Enabled = True
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        GroupBox5.Enabled = False

        If RadioButton14.Checked = True Then
            Label1.Text = "Selected Month"
            DateTimePicker1.CustomFormat = "MMM, yyyy"
            Label2.Visible = False
            DateTimePicker2.Visible = False
            RadioButton30.Text = "By Month"
            DateTimePicker1.Enabled = True
            GroupBox5.Enabled = False
            RadioButton9.Enabled = False
            RadioButton30.Checked = True
        Else
            Label1.Text = "From Date"
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            Label2.Visible = True
            DateTimePicker2.Visible = True
            RadioButton30.Text = "By Date"
            DateTimePicker1.Enabled = True
            GroupBox5.Enabled = True
            RadioButton9.Enabled = True
        End If
    End Sub

    Private Sub HiringBtn_CheckedChanged(sender As Object, e As EventArgs) Handles HiringBtn.CheckedChanged
        GroupBox5.Enabled = False
        If HiringBtn.Checked = True Then
            RadioButton31.Enabled = False
            RadioButton32.Enabled = False
            ByBranch.Enabled = False
            RadioButton3.Enabled = False
            RadioButton9.Enabled = False
            RadioButton30.Checked = True
        Else
            RadioButton31.Enabled = True
            RadioButton32.Enabled = True
            ByBranch.Enabled = True
            RadioButton3.Enabled = True
            RadioButton9.Enabled = True
        End If
    End Sub

    Private Sub TerListBtn_CheckedChanged(sender As Object, e As EventArgs) Handles TerListBtn.CheckedChanged
        GroupBox5.Enabled = False
        If TerListBtn.Checked = True Then
            RadioButton31.Enabled = False
            RadioButton32.Enabled = False
            ByBranch.Enabled = False
            RadioButton3.Enabled = False
            RadioButton9.Enabled = False
            RadioButton30.Checked = True
        Else
            RadioButton31.Enabled = True
            RadioButton32.Enabled = True
            ByBranch.Enabled = True
            RadioButton3.Enabled = True
            RadioButton9.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        DateTimePicker1.Enabled = True
        DateTimePicker2.Enabled = True
        GroupBox5.Enabled = True
        RadioButton30.Checked = True
        RadioButton13.Checked = True
        RadioButton30.Enabled = True
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        RadioButton30.Checked = True


        If RadioButton12.Checked = True Then
            Panel3.Enabled = False
            DateTimePicker1.Enabled = True

            RadioButton31.Enabled = False
            RadioButton32.Enabled = False
            RadioButton3.Enabled = False
            RadioButton9.Enabled = False
            ByBranch.Enabled = False
            DateTimePicker2.Visible = False
            Label2.Visible = False
            Label2.Text = "Select Month"
            DateTimePicker1.CustomFormat = "MMM, yyyy"

        Else
            DateTimePicker1.Enabled = False
            Panel3.Enabled = True
            RadioButton31.Enabled = True
            RadioButton32.Enabled = True
            RadioButton3.Enabled = True
            RadioButton9.Enabled = True
            ByBranch.Enabled = True
            DateTimePicker2.Visible = True
            Label2.Visible = True
            Label2.Text = "From Date"
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If

    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        RadioButton30.Checked = True
        If RadioButton15.Checked = True Then
            Panel3.Enabled = False
            RadioButton31.Enabled = False
            RadioButton32.Enabled = False
            RadioButton3.Enabled = False
            RadioButton9.Enabled = False
            ByBranch.Enabled = False
            DateTimePicker2.Visible = False
            Label2.Visible = False
            Label2.Text = "Select Month"
            DateTimePicker1.CustomFormat = "MMM, yyyy"
            DateTimePicker1.Enabled = True
        Else
            DateTimePicker1.Enabled = False
            Panel3.Enabled = True
            RadioButton31.Enabled = True
            RadioButton32.Enabled = True
            RadioButton3.Enabled = True
            RadioButton9.Enabled = True
            ByBranch.Enabled = True
            DateTimePicker2.Visible = True
            Label2.Visible = True
            Label2.Text = "From Date"
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        End If
    End Sub
    Dim TimerCOuner As Int16 = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Entryflag = True

        If Entryflag = True Then
            If TimerCOuner <= 2 Then

                TimerCOuner = TimerCOuner + 1

                Entryflag = False
                TimerFlag = True
            Else
                TimerCOuner = 0
                TimerFlag = False

                Entryflag = True

            End If
        Else

            TimerFlag = True
        End If

    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            RadioButton17.Enabled = True
            RadioButton30.Checked = True
            RadioButton31.Enabled = False
            RadioButton32.Enabled = True
            ByBranch.Enabled = False
            RadioButton3.Enabled = False
            RadioButton9.Enabled = False
        Else
            RadioButton17.Enabled = False
            RadioButton30.Enabled = False
            RadioButton31.Enabled = True
            RadioButton32.Enabled = False
            ByBranch.Enabled = True
            RadioButton3.Enabled = True
            RadioButton9.Enabled = True
        End If
    End Sub
End Class