Public Class frmAnnualLeavesReports
    Private Sub CrdRange_CheckedChanged(sender As Object, e As EventArgs) Handles CrdRange.CheckedChanged

        TextBox1.Enabled = True
            TextBox2.Enabled = True

    End Sub



    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SecBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SecBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = True
        NameComboBox1.Enabled = False
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        NameComboBox1.Enabled = True
    End Sub
    Private Sub SelectFP()
        'Here Obj.ReturnFP() function is a utility function that returns financial period by providing Year and Month
        Dim Obj As New UtilityClass()
        If Obj.ReturnFP(DateTimePicker2.Value.Month, DateTimePicker2.Value.Year) <> Nothing Then
            FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker2.Value.Month, DateTimePicker2.Value.Year)
        Else
            MsgBox("Selected year was beyond the running financial period")
            DateTimePicker2.Value = Now.Date
        End If
    End Sub


    Private Sub frmAnnualLeavesReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSHRM.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'DSHRM.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSHRM.tbl_Acc_FinancialPeriod)
        'TODO:   This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Branches' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_BranchesTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Branches)
        'Me.Tbl_Acc_FinancialPeriodTableAdapter.FillBy(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)
        Me.FinancialPeriodComboBox.SelectedIndex = Me.FinancialPeriodComboBox.Items.Count - 1
        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        'Me.Tbl_Hrm_SubDept2TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept2)
        Try
            SelectFP()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PAdvDed_CheckedChanged(sender As Object, e As EventArgs) Handles PAdvDed.CheckedChanged
        ByMonth.Checked = True
        DateTimePicker2.Enabled = True
        GroupBox1.Enabled = True
        If PAdvDed.Checked = True Then

            FinancialPeriodComboBox.Enabled = True

        Else

            FinancialPeriodComboBox.Enabled = False

        End If
    End Sub









    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim Obj As New UtilityClass()
        Dim EmpStatus As String
        If PAdvDed.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.empstatus}= true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.empstatus}= False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_AllEmployees.empstatus} = True or {View_Rpt_Acc_AllEmployees.empstatus} = False)"
            End If
        End If
        If RadioButton1.Checked = True Or RadioButton2.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.empstatus}= true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.empstatus}= False "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_PreSalary.empstatus} = True or {View_Rpt_Acc_PreSalary.empstatus} = False)"
            End If
        End If


        If RadioButton1.Checked = True Then ' Annual Leave REceived
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccAnnualLeavesRec.rpt"
            If ByMonth.Checked = True Then   ' By month 
                If All.Checked = True Then ' Main Dept
                    Filter = EmpStatus & "  And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & ""
                ElseIf DeptBtn.Checked = True Then ' By Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID}= " & DeptNameComboBox.SelectedValue & "   And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & ""
                ElseIf SecBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID}= " & NameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID}= " & NameComboBox1.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & ""
                End If
            ElseIf CrdRange.Checked = True Then ' by card range
                If All.Checked = True Then ' All Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And  Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf ByMonth.Checked = True ' Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & "   And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & "   And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf SecBtn.Checked = True ' Section 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf DesigBtn.Checked = True ' Desig 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DEsignationID} = " & NameComboBox1.SelectedValue & " And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DEsignationID} = " & NameComboBox1.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                End If
            ElseIf RadioButton3.Checked = True Then ' By branch
                If All.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & ""
                ElseIf DeptBtn.Checked = True Then ' By Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID}= " & DeptNameComboBox.SelectedValue & "    And Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & ""
                ElseIf SecBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID}= " & NameComboBox.SelectedValue & " And  Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DesignationID}= " & NameComboBox1.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Month & " and Year({View_Rpt_Acc_ActiveAnnualLeaves.CalculationMonth}) = " & DateTimePicker2.Value.Year & ""

                End If
            End If
        End If


        If RadioButton2.Checked = True Then ' Annual Leave Slip
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccAnnualLeavesSlip.rpt"
            If ByMonth.Checked = True Then   ' By month 
                If All.Checked = True Then ' Main Dept
                    Filter = EmpStatus & "  And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & " "
                ElseIf DeptBtn.Checked = True Then ' By Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID}= " & DeptNameComboBox.SelectedValue & "   And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & ""
                ElseIf SecBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID}= " & NameComboBox.SelectedValue & " And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID}= " & NameComboBox1.SelectedValue & "  And  {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & ""

                End If
            ElseIf CrdRange.Checked = True Then ' by card range
                If All.Checked = True Then ' All Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And  {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf ByMonth.Checked = True ' Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & "   And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & "   And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf SecBtn.Checked = True ' Section 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf DesigBtn.Checked = True ' Desig 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DEsignationID} = " & NameComboBox1.SelectedValue & " And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DEsignationID} = " & NameComboBox1.SelectedValue & "  And  {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                End If
            ElseIf RadioButton3.Checked = True Then ' By branch
                If All.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & ""
                ElseIf DeptBtn.Checked = True Then ' By Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID}= " & DeptNameComboBox.SelectedValue & "    And {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & ""
                ElseIf SecBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID}= " & NameComboBox.SelectedValue & " And  {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DesignationID}= " & NameComboBox1.SelectedValue & "  And  {@Yr} = " & DateTimePicker2.Value.Year & " and {@Mon} = " & DateTimePicker2.Value.Month & ""

                End If
            End If
        End If


        If RadioButton4.Checked = True Then ' list of Employee Elogable for Annual leaves 
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccEmpGoingonLeaves.rpt"
            Filter = "{@LeaveMonth} = " & DateTimePicker2.Value.Year & " And {@Mon} =" & DateTimePicker2.Value.Month & ""
            If ByMonth.Checked = True Then ' By Month 
                Flag = False
                If All.Checked = True Then ' By Emp
                    Filter = "{View_Rpt_Acc_PreSalary.Empstatus}= True  "
                ElseIf DeptBtn.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.DeptID} =" & DeptNameComboBox.SelectedValue & " "
                ElseIf SecBtn.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_Acc_PreSalary.DeptID} =" & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.DesigID} =" & NameComboBox1.SelectedValue & " "
                End If
            ElseIf CrdRange.Checked = True ' By Card Number
                If All.Checked = True Then ' By Emp
                    If TextBox1.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & ""
                    End If

                ElseIf DeptBtn.Checked = True Then ' main Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = "{View_Rpt_Acc_PreSalary.DeptID} =" & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = "{View_Rpt_Acc_PreSalary.DeptID} =" & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf SecBtn.Checked = True Then ' Section Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = "{View_Rpt_Acc_PreSalary.DeptID} =" & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.subdept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = "{View_Rpt_Acc_PreSalary.DeptID} =" & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.subdept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf DesigBtn.Checked = True ' Desig Wise
                    If TextBox1.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = "{View_Rpt_Acc_PreSalary.DesigID} =" & NameComboBox1.SelectedValue & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = "{View_Rpt_Acc_PreSalary.DesigID} =" & NameComboBox1.SelectedValue & "   And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & ""
                    End If
                End If
            ElseIf RadioButton3.Checked = True Then ' By Branch 
                Flag = False
                If All.Checked = True Then ' By All Dept
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DeptBtn.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptID} =" & DeptNameComboBox.SelectedValue & "  "
                ElseIf SecBtn.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptID} =" & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} =" & NameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DesigID} =" & NameComboBox1.SelectedValue & ""
                End If


            End If
        End If





        ''' Annual Leave Dues 
        'If RadioButton10.Checked = True Then
        '    Param = "@MyYear=" & DateTimePicker2.Value.Year & "&@MyMonth=" & DateTimePicker2.Value.Month
        '    Path = "" & frmLogin.ReportsPath & "\HR\rptAnnualLeavesDue.rpt"
        '    If ByMonth.Checked = True Then ' All EMp
        '        Flag = False
        '        If All.Checked = True Then
        '            Filter = "{spAnnualLeavesDue;1.Cardno} > 0"
        '        ElseIf DeptBtn.Checked = True Then
        '            Filter = "{spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' "
        '        ElseIf SecBtn.Checked = True Then
        '            Filter = " {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' And  {spAnnualLeavesDue;1.SectionName} = '" & NameComboBox.Text & "'  "
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = " {spAnnualLeavesDue;1.Designame} = '" & NameComboBox1.Text & "' "
        '        End If

        '    ElseIf CrdRange.Checked = True Then ' By card range

        '        If All.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False
        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
        '            Else
        '                Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
        '            End If

        '        ElseIf DeptBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False
        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' "
        '            Else
        '                Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' "
        '            End If

        '        ElseIf SecBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False

        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = " {spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "'  And {spAnnualLeavesDue;1.SectionName} = '" & NameComboBox.Text & "'"
        '            Else
        '                Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "'   And {spAnnualLeavesDue;1.SectionName} = '" & NameComboBox.Text & "' "
        '            End If

        '        ElseIf DesigBtn.Checked = True Then
        '            If TextBox1.Text.Length = 0 Then
        '                Flag = True
        '            Else
        '                Flag = False

        '            End If
        '            If TextBox2.Text = "" Then
        '                Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {spAnnualLeavesDue;1.Designame} = '" & NameComboBox1.Text & "'"
        '            Else
        '                Filter = "{spAnnualLeavesDue;1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {spAnnualLeavesDue;1.Designame} = '" & NameComboBox1.Text & "' "
        '            End If
        '        End If
        '    ElseIf RadioButton3.Checked = True Then ' By Branch 
        '        Flag = False
        '        If All.Checked = True Then
        '            Filter = "{spAnnualLeavesDue;1.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
        '        ElseIf DeptBtn.Checked = True Then
        '            Filter = "{spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' And {spAnnualLeavesDue;1.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
        '        ElseIf SecBtn.Checked = True Then
        '            Filter = " {spAnnualLeavesDue;1.DeptName} = '" & DeptNameComboBox.Text & "' And  {spAnnualLeavesDue;1.SectionName} = '" & NameComboBox.Text & "' And {spAnnualLeavesDue;1.BranchID} = " & Me.BranchNameComboBox.SelectedValue & " "
        '        ElseIf DesigBtn.Checked = True Then
        '            Filter = " {spAnnualLeavesDue;1.Designame} = '" & NameComboBox1.Text & "'  And {spAnnualLeavesDue;1.BranchID} = " & Me.BranchNameComboBox.SelectedValue & ""
        '        End If
        '    End If
        'End If


        If PAdvDed.Checked = True Then ' P Adv Ded Againt Annul leaves 
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptALeaveAgainstLTA.rpt"
            If ByMonth.Checked = True Then   ' By month 
                If All.Checked = True Then ' Main Dept
                    Filter = EmpStatus & "   And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0  "
                ElseIf DeptBtn.Checked = True Then ' By Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & "    And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & "And {@DedAsLTA} > 0  "
                ElseIf SecBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0  "
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.Designame}= '" & NameComboBox1.Text & "'    And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & "And {@DedAsLTA} > 0  "

                End If
            ElseIf CrdRange.Checked = True Then ' by card range
                If All.Checked = True Then ' All Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0    And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0   And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf ByMonth.Checked = True ' Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0    And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0    And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf SecBtn.Checked = True ' Section 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0    And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0    And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                ElseIf DesigBtn.Checked = True ' Desig 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.Designame} = '" & NameComboBox1.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0    And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.Designame} = '" & NameComboBox1.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0   And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                End If
            ElseIf RadioButton3.Checked = True Then ' By branch
                If All.Checked = True Then ' Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0  "
                ElseIf DeptBtn.Checked = True Then ' By Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & "    And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & "And {@DedAsLTA} > 0  "
                ElseIf SecBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & " And {@DedAsLTA} > 0  "
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.Designame}= '" & NameComboBox1.Text & "'    And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@Year}= " & DateTimePicker2.Value.Year & " And {@Mon} = " & DateTimePicker2.Value.Month & "And {@DedAsLTA} > 0  "

                End If
            End If
        End If




        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Flag = False
            Obj.LoadSalaryReports(Path, Filter, Param)
        End If

    End Sub
    Private Flag As Boolean = False

    Private Sub ByMonth_CheckedChanged(sender As Object, e As EventArgs) Handles ByMonth.CheckedChanged

        TextBox1.Enabled = False
        TextBox2.Enabled = False



    End Sub

    Private Sub All_CheckedChanged(sender As Object, e As EventArgs) Handles All.CheckedChanged

        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        NameComboBox1.Enabled = False

    End Sub

    Private Sub DeptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DeptBtn.CheckedChanged

        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = False
        NameComboBox1.Enabled = False
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DateTimePicker2.Enabled = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DateTimePicker2.Enabled = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
        End If
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        DateTimePicker2.Enabled = True
        GroupBox1.Enabled = False
    End Sub

    Private Sub RadioButton5_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        DateTimePicker2.Enabled = True
    End Sub
End Class