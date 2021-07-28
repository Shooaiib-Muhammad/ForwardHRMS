Public Class frmAdvanceReports
    Private Sub frmAdvanceReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Bank' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BankTableAdapter.Fill(Me.DSHRM.tbl_HRM_Bank)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO:   This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'Me.Tbl_Hrm_SubDept2TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept2)
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)

    End Sub

    Private Sub All_CheckedChanged(sender As Object, e As EventArgs) Handles All.CheckedChanged
        'If All.Checked = True Then
        '    MothPicker.Enabled = True
        '    FrmCrd.Clear()
        '    Tocrd.Clear()

        'Else
        '    MothPicker.Enabled = False
        'End If

    End Sub

    Private Sub CrdRange_CheckedChanged(sender As Object, e As EventArgs) Handles CrdRange.CheckedChanged
        If CrdRange.Checked = True Then
            FrmCrd.Enabled = True
            Tocrd.Enabled = True
        Else
            FrmCrd.Enabled = False
            Tocrd.Enabled = False
        End If
    End Sub

    Private Sub MainDeptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MainDeptBtn.CheckedChanged

        If CrdRange.Checked = True Then
            FrmCrd.Enabled = True
            Tocrd.Enabled = True
        Else
            FrmCrd.Enabled = False
            Tocrd.Enabled = False
        End If
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = False
        DesigComboBox.Enabled = False
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged

        If CrdRange.Checked = True Then
            FrmCrd.Enabled = True
            Tocrd.Enabled = True
        Else
            FrmCrd.Enabled = False
            Tocrd.Enabled = False
        End If
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        DesigComboBox.Enabled = True
    End Sub

    Private Sub SectBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SectBtn.CheckedChanged

        If CrdRange.Checked = True Then
            FrmCrd.Enabled = True
            Tocrd.Enabled = True
        Else
            FrmCrd.Enabled = False
            Tocrd.Enabled = False
        End If
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = True
        DesigComboBox.Enabled = False
    End Sub

    Private Sub AllDept_CheckedChanged(sender As Object, e As EventArgs)
        If All.Checked = True Then
            MonthPicker.Enabled = True
        Else
            MonthPicker.Enabled = False
        End If
        If CrdRange.Checked = True Then
            FrmCrd.Enabled = True
            Tocrd.Enabled = True
        Else
            FrmCrd.Enabled = False
            Tocrd.Enabled = False
        End If


    End Sub

    'Private Sub TADvPreDisc_CheckedChanged(sender As Object, e As EventArgs) Handles TADvPreDisc.CheckedChanged

    '    If TADvPreDisc.Checked = True Then
    '        percntage.Enabled = True
    '        MothPicker.Enabled = True
    '    Else
    '        percntage.Enabled = False
    '        MothPicker.Enabled = False
    '    End If
    'End Sub

    Private Sub RptViewer_Click(sender As Object, e As EventArgs) Handles RptViewer.Click

        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim Obj As New UtilityClass()
        Dim EmpStatus As String

        If TAdvpaid.Checked = True Or RadioButton3.Checked = True Or RadioButton4.Checked = True Or RadioButton5.Checked = True Or RadioButton1.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_ShortTermAdvances.EmpStatus} = true "
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_ShortTermAdvances.EmpStatus} = false "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_ShortTermAdvances.CardNo} > 0"

            End If
        End If
        If RadioButton6.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Per_Adv_Against_Bonus .EmpStatus} = true "
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Per_Adv_Against_Bonus .EmpStatus} = false "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Per_Adv_Against_Bonus .CardNo} > 0"

            End If
        End If

        If PADvZeroDed.Checked = True Or PADvDed.Checked = True Or PAdvRec.Checked = True Or TADvRecv.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = true "
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = false "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_PreSalary.EmpStatus} = false or {View_Rpt_Acc_PreSalary.EmpStatus} = True)"

            End If
        End If


        If padvAnnlLeave.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus} = true "
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus} = false "
            ElseIf All.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_AllEmployees.EmpStatus} = false or {View_Rpt_Acc_ShortTermAdvances.EmpStatus} = True)"
            End If
        End If

        If PAdvBlnc.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{spPAdvLedger;1.EmpStatus} = true "
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{spPAdvLedger;1.EmpStatus} = false "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({spPAdvLedger;1.EmpStatus} = false or {spPAdvLedger;1 .EmpStatus} = True)"
            End If
        End If
        If RadioButton7.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_ShortTermAdvances.EmpStatus} = true "
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_ShortTermAdvances.EmpStatus} = false "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_ShortTermAdvances.EmpStatus} = false or {View_Rpt_Acc_ShortTermAdvances.EmpStatus} = True)"
            End If
        End If

        If TAdvpaid.Checked = True Then ' T Adv paid 

            Path = "" & frmLogin.ReportsPath & "\Accounts\RptTadvpaid.rpt"
            Param = "Date = " & Format(Me.MonthPicker.Value, "dd/MM/yyyy")
            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf SectBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                End If
            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And   Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "'And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "'And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "

                End If
            End If

        End If





        If RadioButton5.Checked = True Then ' T Adv paid against Annual Leaves

            Path = "" & frmLogin.ReportsPath & "\Accounts\RptLadvPaidagnstannual.rpt"
            Param = "Date = " & Format(Me.MonthPicker.Value, "dd/MM/yyyy")
            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf SectBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                End If
            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And   Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "'And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "'And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "

                End If
            End If

        End If

        '' Long Term adv

        If RadioButton1.Checked = True Then ' T Adv paid 

            Path = "" & frmLogin.ReportsPath & "\Accounts\RptLadvPaid.rpt"
            Param = "Date = " & Format(Me.MonthPicker.Value, "dd/MM/yyyy")
            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf SectBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                End If
            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And   Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "'And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "'And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "

                End If
            End If

        End If


        If RadioButton4.Checked = True Then ' T Adv Rec List 

            Path = "" & frmLogin.ReportsPath & "\Accounts\rptTempAdvReceivingList.rpt"
            Param = "FromDate=#" & Format(MonthPicker.Value, "dd/MM/yyyy") & "#&ToDate=#" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "#"

            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "'And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "'And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"

                End If
            End If

        End If


        If RadioButton3.Checked = True Then ' T Adv Slips 

            Path = "" & frmLogin.ReportsPath & "\Accounts\RptTempAdvReceivingSlip.rpt"
            Param = "FromDate=#" & Format(MonthPicker.Value, "dd/MM/yyyy") & "#&ToDate=#" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "#"

            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "'And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.Subdept1} = '" & NameComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SubDept1} = '" & NameComboBox.Text & "'And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And   {View_Rpt_Acc_ShortTermAdvances.TransactionDate}In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"

                End If
            End If

        End If



        If PADvDed.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccLongTermAdvList.rpt"
            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & "And {@Balance} > 0 "
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {@Balance} > 0"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {@Balance} > 0"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DesigName}  = '" & DesigComboBox.Text & "' And {@Balance} > 0"
                End If

            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & "And {@Balance} > 0 "
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And {@Balance} > 0 "
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {@Balance} > 0 "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {@Balance} > 0"
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {@Balance} > 0"
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {@Balance} > 0"
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.Sectionname} = '" & NameComboBox.Text & "' And {@Balance} > 0 "
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigComboBox.Text & "'And {@Balance} > 0 "
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigComboBox.Text & "'And {@Balance} > 0 "
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@Balance} > 0"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'And {@Balance} > 0"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'And {@Balance} > 0 "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And    {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName}  = '" & DesigComboBox.Text & "'And {@Balance} > 0"
                End If

            End If
        End If


        If TADvRecv.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptTADVRec.rpt"
            If All.Checked = True Then ' All 
                flag = False

                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And {@EmpStatus} = 'Active' "
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And {@EmpStatus} = 'Active' "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And {@EmpStatus} = 'Active'  "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName}  = '" & DesigComboBox.Text & "'  And  Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And {@EmpStatus} = 'Active' "
                End If

            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And  {@EmpStatus} = 'Active'"

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And  {@EmpStatus} = 'Active' "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0  And {@EmpStatus} = 'Active'  "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0  And {@EmpStatus} = 'Active'"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0  And {@EmpStatus} = 'Active' "
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And  {@EmpStatus} = 'Active' "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.Sectionname} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0  And {@EmpStatus} = 'Active' "
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0  And {@EmpStatus} = 'Active'"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0  And {@EmpStatus} = 'Active' "
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And {@EmpStatus} = 'Active'"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0  And {@EmpStatus} = 'Active'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0  And {@EmpStatus} = 'Active'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName}  = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " And {View_Rpt_Acc_ActiveSalaryTransactions.TotalShortTermAdvance} > 0 And  {@EmpStatus} = 'Active' "

                End If
            End If
        End If


        If PADvLedger.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\RptAdvLedger.rpt"
            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = "{@EmpStatus} = 'Active'"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{@EmpStatus} = 'Active' And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{@EmpStatus} = 'Active'  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SectionName} = '" & NameComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{@EmpStatus} = 'Active'  And  {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigComboBox.Text & "'"
                End If

            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "'"
                    Else
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "'"
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SectionName} = '" & NameComboBox.Text & "'"
                    Else
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.Sectionname} = '" & NameComboBox.Text & "'"
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "'"
                    Else
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "'"
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = " {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SectionName} = '" & NameComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigComboBox.Text & "'"
                End If

            End If
        End If




        If PAdvRec.Checked = True Then ' p Adv Receoved 
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccPAdvReceived.rpt"
            If All.Checked = True Then ' All 
                flag = False

                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And   Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & ""
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active' "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And    {View_Rpt_Acc_PreSalary.DesigName}  = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active' "
                End If

            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And    Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active' "
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active' "
                    Else
                        Filter = EmpStatus & " And    {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.Sectionname} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And    {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And    {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName}  = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & MonthPicker.Value.Month & " and {@EmpStatus} = 'Active'"
                End If

            End If
        End If


        If PAdvBlnc.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccPAdvBalanceNew.rpt"
            If Blance.Text = "=0" Then
                If All.Checked = True Then ' All 
                    flag = False
                    If RadioButton2.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@Balance} = 0"
                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "'  {@Balance} = 0 "
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "' And {spPAdvLedger;1.SectionName} = '" & NameComboBox.Text & "'  And {@Balance} = 0 "
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = EmpStatus & "And {spPAdvLedger;1.DesigName}  = '" & DesigComboBox.Text & "'  And {@Balance} = 0 "
                    End If
                ElseIf CrdRange.Checked = True Then ' By Card Range 
                    If RadioButton2.Checked = True Then
                        Filter = EmpStatus & " And {@Balance} = 0"
                        If FrmCrd.Text.Length = 0 Then
                            flag = True
                        Else
                            flag = False
                        End If
                        If Tocrd.Text = "" Then
                            Filter = EmpStatus & " And  {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {@Balance} = 0  "
                        Else
                            Filter = EmpStatus & " And  {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "And {@Balance} = 0  "
                        End If
                    ElseIf MainDeptBtn.Checked = True Then
                        If FrmCrd.Text.Length = 0 Then
                            flag = True
                        Else
                            flag = False
                        End If
                        If Tocrd.Text = "" Then
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "' And {@Balance} = 0"
                        Else
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "'And {@Balance} = 0 "
                        End If
                    ElseIf SectBtn.Checked = True Then
                        If FrmCrd.Text.Length = 0 Then
                            flag = True
                        Else
                            flag = False

                        End If
                        If Tocrd.Text = "" Then
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "' And {spPAdvLedger;1.SectionName} = '" & NameComboBox.Text & "' And {@Balance} = 0 "
                        Else
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "' And {spPAdvLedger;1.Sectionname} = '" & NameComboBox.Text & "' And {@Balance} = 0 "
                        End If
                    ElseIf DesigBtn.Checked = True Then
                        If FrmCrd.Text.Length = 0 Then
                            flag = True
                        Else
                            flag = False
                        End If
                        If Tocrd.Text = "" Then
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {spPAdvLedger;1.DesigName} = '" & DesigComboBox.Text & "' And {@Balance} = 0 "
                        Else
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {spPAdvLedger;1.DesigName} = '" & DesigComboBox.Text & "' And {@Balance} = 0 "
                        End If
                    End If
                ElseIf ByBranch.Checked = True Then

                    flag = False
                    If RadioButton2.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {spPAdvLedger;1.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@Balance} = 0 "
                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And   {spPAdvLedger;1.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "'And {@Balance} = 0 "
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And  {spPAdvLedger;1.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {spPAdvLedger;1.DeptName}  = '" & DeptNameComboBox.Text & "' And {spPAdvLedger;1.SectionName} = '" & NameComboBox.Text & "' And {@Balance} = 0 "
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = EmpStatus & " And    {spPAdvLedger;1.BranchID} = " & BranchNameComboBox.SelectedValue & " And {spPAdvLedger;1.DesigName}  = '" & DesigComboBox.Text & "' And {@Balance} = 0 "
                    End If

                End If

            ElseIf Blance.Text = ">0" Then
                If All.Checked = True Then ' All 
                    flag = False
                    If RadioButton2.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {@Balance} > 0"
                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "'  And {@Balance} > 0"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {spPAdvLedger;1.DeptName}  = '" & DeptNameComboBox.Text & "' And {spPAdvLedger;1.SectionName} = '" & NameComboBox.Text & "'  And {@Balance} > 0"
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = EmpStatus & "And {spPAdvLedger;1.DesigName}  = '" & DesigComboBox.Text & "'  And {@Balance} > 0"
                    End If
                ElseIf CrdRange.Checked = True Then ' By Card Range 
                    If RadioButton2.Checked = True Then
                        Filter = EmpStatus & " And {@Balance} > 0"
                        If FrmCrd.Text.Length = 0 Then
                            flag = True
                        Else
                            flag = False
                        End If
                        If Tocrd.Text = "" Then
                            Filter = EmpStatus & " And  {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {@Balance} > 0 "
                        Else
                            Filter = EmpStatus & " And  {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "And {@Balance} > 0 "
                        End If
                    ElseIf MainDeptBtn.Checked = True Then
                        If FrmCrd.Text.Length = 0 Then
                            flag = True
                        Else
                            flag = False
                        End If
                        If Tocrd.Text = "" Then
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "' And {@Balance} > 0"
                        Else
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "'And {@Balance} > 0"
                        End If
                    ElseIf SectBtn.Checked = True Then
                        If FrmCrd.Text.Length = 0 Then
                            flag = True
                        Else
                            flag = False

                        End If
                        If Tocrd.Text = "" Then
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "' And {spPAdvLedger;1.SectionName} = '" & NameComboBox.Text & "' And {@Balance} > 0"
                        Else
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "' And {spPAdvLedger;1.Sectionname} = '" & NameComboBox.Text & "' And {@Balance} > 0"
                        End If
                    ElseIf DesigBtn.Checked = True Then
                        If FrmCrd.Text.Length = 0 Then
                            flag = True
                        Else
                            flag = False
                        End If
                        If Tocrd.Text = "" Then
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {spPAdvLedger;1.DesigName} = '" & DesigComboBox.Text & "' And {@Balance} > 0"
                        Else
                            Filter = EmpStatus & " And   {spPAdvLedger;1.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {spPAdvLedger;1.DesigName} = '" & DesigComboBox.Text & "' And {@Balance} > 0"
                        End If
                    End If
                ElseIf ByBranch.Checked = True Then

                    flag = False
                    If RadioButton2.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {spPAdvLedger;1.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@Balance} > 0"
                    ElseIf MainDeptBtn.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And   {spPAdvLedger;1.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {spPAdvLedger;1.DeptName} = '" & DeptNameComboBox.Text & "'And {@Balance} > 0"
                    ElseIf SectBtn.Checked = True Then ' Section 
                        Filter = EmpStatus & " And  {spPAdvLedger;1.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {spPAdvLedger;1.DeptName}  = '" & DeptNameComboBox.Text & "' And {spPAdvLedger;1.SectionName} = '" & NameComboBox.Text & "' And {@Balance} > 0"
                    ElseIf DesigBtn.Checked = True Then ' Designation 
                        Filter = EmpStatus & " And    {spPAdvLedger;1.BranchID} = " & BranchNameComboBox.SelectedValue & " And {spPAdvLedger;1.DesigName}  = '" & DesigComboBox.Text & "' And {@Balance} > 0"
                    End If

                End If
            End If

        End If


        If PADvZeroDed.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\RptEmpWithZeroDed.rpt"
            If All.Checked = True Then ' All 
                flag = False

                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DesigName}  = '" & DesigComboBox.Text & "'"
                End If

            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'"
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'"
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'"
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.Sectionname} = '" & NameComboBox.Text & "'"
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigComboBox.Text & "'"
                    Else
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigComboBox.Text & "'"
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And    {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName}  = '" & DesigComboBox.Text & "'"
                End If

            End If
        End If

        If padvAnnlLeave.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\PAdvDedAgAnnlLeave.rpt"
            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0 "
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SectionName} = '" & NameComboBox.Text & "' And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0 "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And   {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigComboBox.Text & "' And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0"
                End If

            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0"
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0"
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "'And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0 "
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0"
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SectionName} = '" & NameComboBox.Text & "' And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0 "
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.Sectionname} = '" & NameComboBox.Text & "'And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & "  and {@DedAsLTA} > 0"
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "'And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & "  and {@DedAsLTA} > 0"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "'And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0 "
                    End If
                End If
            ElseIf ByBranch.Checked = True Then
                flag = False


                If RadioButton2.Checked = True Then ' All Dept

                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0 "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SectionName} = '" & NameComboBox.Text & "'And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & "  and {@DedAsLTA} > 0"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DesigName}  = '" & DesigComboBox.Text & "' And {@Year}= " & MonthPicker.Value.Year & " And {@Mon} = " & MonthPicker.Value.Month & " and {@DedAsLTA} > 0 "
                End If
            End If
        End If

        If RadioButton6.Checked = True Then ' T Adv paid against Bonus

            Path = "" & frmLogin.ReportsPath & "\Accounts\RptLadvPaidagnstbonus.rpt"
            Param = "Date = " & Format(Me.MonthPicker.Value, "dd/MM/yyyy")
            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Per_Adv_Against_Bonus.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf SectBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Per_Adv_Against_Bonus.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Per_Adv_Against_Bonus.SectionName} = '" & NameComboBox.Text & "' And Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And {View_Rpt_Per_Adv_Against_Bonus.DesigName}  = '" & DesigComboBox.Text & "' And Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                End If
            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & ""

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Per_Adv_Against_Bonus.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And   Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Per_Adv_Against_Bonus.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Per_Adv_Against_Bonus.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Per_Adv_Against_Bonus.DeptName} = '" & DeptNameComboBox.Text & "'And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Per_Adv_Against_Bonus.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Per_Adv_Against_Bonus.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Per_Adv_Against_Bonus.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Per_Adv_Against_Bonus.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Per_Adv_Against_Bonus.SectionName} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = "{View_Rpt_Per_Adv_Against_Bonus.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Per_Adv_Against_Bonus.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Per_Adv_Against_Bonus.SectionName} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Per_Adv_Against_Bonus.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Per_Adv_Against_Bonus.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & ""
                    Else
                        Filter = "{View_Rpt_Per_Adv_Against_Bonus.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Per_Adv_Against_Bonus.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                End If
            ElseIf ByBranch.Checked = True Then

                flag = False
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Per_Adv_Against_Bonus.BranchID} = " & BranchNameComboBox.SelectedValue & " And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Per_Adv_Against_Bonus.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Per_Adv_Against_Bonus.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = EmpStatus & " And {View_Rpt_Per_Adv_Against_Bonus.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Per_Adv_Against_Bonus.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Per_Adv_Against_Bonus.SectionName} = '" & NameComboBox.Text & "'And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = EmpStatus & " And {View_Rpt_Per_Adv_Against_Bonus.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Per_Adv_Against_Bonus.DesigName}  = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Per_Adv_Against_Bonus.TransactionDate}) = " & MonthPicker.Value.Month & " "

                End If
            End If

        End If

        If RadioButton7.Checked = True Then ' RFD  Adv paid 

            Path = "" & frmLogin.ReportsPath & "\Accounts\RptRFDAdv.rpt"
            Param = "Date = " & Format(Me.MonthPicker.Value, "dd/MM/yyyy")
            If All.Checked = True Then ' All 
                flag = False
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = EmpStatus & " And  {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf SectBtn.Checked = True Then
                    Filter = EmpStatus & " And  {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                ElseIf DesigBtn.Checked = True Then
                    Filter = EmpStatus & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName}  = '" & DesigComboBox.Text & "' And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " and Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                End If
            ElseIf CrdRange.Checked = True Then ' By Card Range 
                If RadioButton2.Checked = True Then
                    Filter = EmpStatus & " And Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""

                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And   Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "'And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False

                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & "   And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        flag = True
                    Else
                        flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & ""
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "' And  Year({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Year & " And Month({View_Rpt_Acc_ShortTermAdvances.TransactionDate}) = " & MonthPicker.Value.Month & " "
                    End If
                End If

            End If

        End If
        If RadioButton8.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\rptTempAdvReceivingListSP.rpt"


            Param = "FromDate=" & MonthPicker.Value.Day & "/" & MonthPicker.Value.Month & "/" & MonthPicker.Value.Year & "&ToDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & ""

            flag = False

            If AllBtn.Checked = True Then
                If RadioButton2.Checked = True Then ' All Dept
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_ShortTermAdvances.SubDept1}= '" & NameComboBox.Text & "' and {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "'"
                End If
            ElseIf CashBtn.Checked = True Then

                If RadioButton2.Checked = True Then ' All Dept
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Acc_ShortTermAdvances.PaymentMode} = 'Cash'"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.PaymentMode} = 'Cash'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_ShortTermAdvances.SubDept1}= '" & NameComboBox.Text & "' and {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.PaymentMode} = 'Cash'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.PaymentMode} = 'Cash'"
                End If
            ElseIf TransferBtn.Checked = True Then

                If RadioButton2.Checked = True Then ' All Dept
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Acc_ShortTermAdvances.PaymentMode} = 'Transfer'"
                ElseIf MainDeptBtn.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.PaymentMode} = 'Transfer'"
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_ShortTermAdvances.SubDept1}= '" & NameComboBox.Text & "' and {View_Rpt_Acc_ShortTermAdvances.DeptName}  = '" & DeptNameComboBox.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.PaymentMode} = 'Transfer'"
                ElseIf DesigBtn.Checked = True Then ' Designation 
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_ShortTermAdvances.DesigName} = '" & DesigComboBox.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.PaymentMode} = 'Transfer'"
                End If
            End If
        End If

        If RadioButton15.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\RptTempAdvTransferLetterSP.rpt"
            flag = False
            If All.Checked = True Then ' All Dept 
                Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Acc_PreSalary.BankAccNo} <> 'null'   And {View_Rpt_Acc_PreSalary.PaymentMode} = 'Transfer' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

            End If
        End If
        If flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            flag = False
            Obj.LoadAllowanceReports(Path, Filter, Param)
        End If




    End Sub
    Dim flag As Boolean = False
    Private Sub PAdvBlnc_CheckedChanged(sender As Object, e As EventArgs) Handles PAdvBlnc.CheckedChanged
        If PAdvBlnc.Checked = True Then
            Blance.Enabled = True
            MonthPicker.Enabled = False


        Else
            Blance.Enabled = False
            MonthPicker.Enabled = True

        End If
    End Sub

    Private Sub TAdvpaid_CheckedChanged(sender As Object, e As EventArgs) Handles TAdvpaid.CheckedChanged

    End Sub

    Private Sub TADvRecv_CheckedChanged(sender As Object, e As EventArgs) Handles TADvRecv.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PAdvRec_CheckedChanged(sender As Object, e As EventArgs) Handles PAdvRec.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False
            DesigComboBox.Enabled = False
        Else
            DeptNameComboBox.Enabled = True
            NameComboBox.Enabled = True
            DesigComboBox.Enabled = True
        End If
    End Sub

    Private Sub ByBranch_CheckedChanged(sender As Object, e As EventArgs) Handles ByBranch.CheckedChanged
        If ByBranch.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub PADvLedger_CheckedChanged(sender As Object, e As EventArgs) Handles PADvLedger.CheckedChanged
        If PADvLedger.Checked = True Then
            MonthPicker.Enabled = False
            All.Checked = True
        Else
            MonthPicker.Enabled = True

        End If
    End Sub

    Private Sub PADvZeroDed_CheckedChanged(sender As Object, e As EventArgs) Handles PADvZeroDed.CheckedChanged
        If PADvZeroDed.Checked = True Then
            MonthPicker.Enabled = False
            All.Checked = True
        Else
            MonthPicker.Enabled = True

        End If
    End Sub

    Private Sub PADvDed_CheckedChanged(sender As Object, e As EventArgs) Handles PADvDed.CheckedChanged
        If PADvDed.Checked = True Then
            MonthPicker.Enabled = False
            All.Checked = True
        Else
            MonthPicker.Enabled = True

        End If
    End Sub

    Private Sub FrmCrd_TextChanged(sender As Object, e As EventArgs) Handles FrmCrd.TextChanged

    End Sub

    Private Sub FrmCrd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FrmCrd.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Tocrd_TextChanged(sender As Object, e As EventArgs) Handles Tocrd.TextChanged

    End Sub

    Private Sub Tocrd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tocrd.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ActiveBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ActiveBtn.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        If RadioButton3.Checked = True Then
            Label4.Text = "From Date:"
            Label3.Visible = "True"
            DateTimePicker1.Visible = "true"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
        Else
            Label4.Text = "Selected Month:"
            Label3.Visible = "False"
            DateTimePicker1.Visible = "False"
            MonthPicker.CustomFormat = "MMM, yyyy"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            Label4.Text = "From Date:"
            Label3.Visible = "True"
            DateTimePicker1.Visible = "true"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
        Else
            Label4.Text = "Selected Month:"
            Label3.Visible = "False"
            DateTimePicker1.Visible = "False"
            MonthPicker.CustomFormat = "MMM, yyyy"
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            ByBranch.Enabled = False
        Else
            ByBranch.Enabled = True

        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            Label4.Text = "From Date:"
            Label3.Visible = "True"
            DateTimePicker1.Visible = "true"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
            GroupBox5.Visible = True
            GroupBox2.Visible = False
        Else
            Label4.Text = "Selected Month:"
            Label3.Visible = "False"
            DateTimePicker1.Visible = "False"
            MonthPicker.CustomFormat = "MMM, yyyy"
            GroupBox5.Visible = False
            GroupBox2.Visible = True
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            Label4.Text = "From Date:"
            Label3.Visible = "True"
            DateTimePicker1.Visible = "true"
            MonthPicker.CustomFormat = "dd/MM/yyyy"
            GroupBox5.Visible = False
            GroupBox2.Visible = True
            BankNameComboBox.Enabled = True
        Else
            BankNameComboBox.Enabled = False
            Label4.Text = "Selected Month:"
            Label3.Visible = "False"
            DateTimePicker1.Visible = "False"
            MonthPicker.CustomFormat = "MMM, yyyy"
            GroupBox5.Visible = True
            GroupBox2.Visible = False
        End If
    End Sub
End Class