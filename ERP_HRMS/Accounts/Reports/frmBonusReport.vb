Imports System.Net.Mail
Imports System.IO

Public Class frmBonusReport

    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Dim EmpStatus As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If BonusSlipBTn.Checked = True Or BonusRecivingBtn.Checked = True Or SalarySumm.Checked = True Or RadioButton18.Checked = True Or PAdvDed.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus} = True"
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus} = False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_AllEmployees.EmpStatus} = True Or {View_Rpt_Acc_AllEmployees.EmpStatus} = False)"
            End If

        End If



        If RadioButton2.Checked Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = True"
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_PreSalary.EmpStatus} = True Or {View_Rpt_Acc_PreSalary.EmpStatus} = False)"
            End If
        End If

        If BonusSlipBTn.Checked = True Then ' Normal Salary Rpt 

            If CheckBox1.CheckState = CheckState.Checked Then
                Path = "" & frmLogin.ReportsPath & "\Accounts\Bonus\rptBonusSlipNightShift.rpt"
            Else
                Path = "" & frmLogin.ReportsPath & "\Accounts\Bonus\rptBonusSlipNormalShift.rpt"
            End If


            If AllBtn.Checked = True Then ' All Cash And Transfer 
                If MonthBtn.Checked = True Then 'By Month 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "

                    End If
                ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                    If RadioButton16.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "   And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton19.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        Else
                            Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else

                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    End If

                ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    End If
                End If
            ElseIf CashBtn.Checked = True Then ' By cash 
                If MonthBtn.Checked = True Then 'By Month 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'  and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'   And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "

                    End If
                ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                    If RadioButton16.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton19.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        Else
                            Filter = EmpStatus & "   And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    End If

                ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    End If
                End If
            ElseIf TransferBtn.Checked = True Then ' By transfer

                If MonthBtn.Checked = True Then 'By Month 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'  and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'   And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "

                    End If
                ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                    If RadioButton16.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton19.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        Else
                            Filter = EmpStatus & "   And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    End If

                ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "
                    End If
                End If
            End If
        End If


        If BonusRecivingBtn.Checked = True Then ' Salary receiving List 
            Path = "" & frmLogin.ReportsPath & "\Accounts\Bonus\rptBonusReceivingList.rpt"
            If AllBtn.Checked = True Then ' All Cash And Transfer 
                If MonthBtn.Checked = True Then 'By Month 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "

                    End If
                ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                    If RadioButton16.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "   And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton19.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        Else
                            Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else

                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    End If

                ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf CashBtn.Checked = True Then ' By cash 
                If MonthBtn.Checked = True Then 'By Month 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'  and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'   And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "

                    End If
                ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                    If RadioButton16.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton19.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        Else
                            Filter = EmpStatus & "   And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    End If

                ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    End If
                End If
            ElseIf TransferBtn.Checked = True Then ' By transfer

                If MonthBtn.Checked = True Then 'By Month 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'  and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'   And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "

                    End If
                ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                    If RadioButton16.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton19.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        Else
                            Filter = EmpStatus & "   And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    End If

                ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton19.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "    "
                    End If
                End If
            End If
        End If

        If SalarySumm.Checked = True Then 'Bonus  Summary report

            Path = "" & frmLogin.ReportsPath & "\Accounts\Bonus\rptBonusSum.rpt"

            If MonthBtn.Checked = True Then 'By Month 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                ElseIf RadioButton19.Checked = True Then ' main Dept
                    Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                ElseIf RadioButton9.Checked = True Then ' Section 
                    Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                ElseIf RadioButton8.Checked = True Then ' Designation
                    Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "

                End If
                ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                    If RadioButton16.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                        Filter = EmpStatus & "   And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    Else
                        Filter = EmpStatus & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    End If
                    ElseIf RadioButton19.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    Else
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                        Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    Else

                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    End If
                    End If

                ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton16.Checked = True Then ' All Dept
                    Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                ElseIf RadioButton19.Checked = True Then ' main Dept
                    Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                ElseIf RadioButton9.Checked = True Then ' Section 
                    Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                ElseIf RadioButton8.Checked = True Then ' Designation
                    Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                End If
                End If
            End If





        '''''' Salary Slip email




        If RadioButton1.Checked Then
            Flag = True
            Dim dgResult As DialogResult
            Dim frmReportViewerObj As New frmReportViewer()
            Dim ExportFlag As Integer = 0
            Dim ErrorCount As Integer = 0
            Dim CardNo As Integer
            Dim ToAddress As String = Nothing
            Dim MangPath As String = "" & frmLogin.ReportsPath & "\Accounts\Bonus\rptBonusSlip.rpt"
            Dim LabourPath As String = "" & frmLogin.ReportsPath & "\Accounts\Bonus\rptBonusSlip.rpt"
            Dim RptPath As String = ""
            'Dim FromTime As DateTime
            'Dim ToTime As DateTime

            ArrList.Clear()
            LBArrList.Clear()
            Dim Grade As String = ""

            Dim PDFPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Bonus Slips PDF\"
            If Directory.Exists(PDFPath) Then
            Else
                Directory.CreateDirectory(PDFPath)
            End If
            dgResult = MessageBox.Show("Are You sure you want to Bonus slips via email?", "Exclamation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dgResult = DialogResult.Yes Then
                'If MonthndCedBtn.Checked = True Then
                Me.View_Rpt_Acc_SalarySlipEmailTableAdapter.FillBy1(Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail, Me.FinancialPeriodComboBox.Text, Me.BonusNoComboBox.Text)
                'ElseIf MonthBtn.Checked = True Then
                '    Me.View_Rpt_Acc_SalarySlipEmailTableAdapter.Fill(Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                'End If
                If Me.View_Rpt_Acc_SalarySlipEmailBindingSource.Count > 0 Then
                    'FromTime = Now
                    'Me.View_Rpt_Acc_SalarySlipEmailBindingSource.Filter = "CardNo=158"
                    ToolStripProgressBar1.Maximum = View_Rpt_Acc_SalarySlipEmailBindingSource.Count - 1
                    For i As Integer = 0 To Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail.Count - 1
                        CardNo = Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item(0)
                        Grade = Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item("Grade").ToString.Trim

                        If Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item(2) IsNot DBNull.Value Then
                            If Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item(2) <> "" Then
                                Filter = "{tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {tbl_Acc_BonusTransactions.BonusNo} = " & Me.BonusNoComboBox.Text & " And {View_Rpt_Acc_AllEmployees.CardNo} = " & CardNo & " And {View_Rpt_Acc_AllEmployees.EmpStatus}"
                                ToAddress = Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item(2)
                                If Grade = "E-1" Or Grade = "E-2" Or Grade = "E-3" Or Grade = "M-1" Or Grade = "M-2" Or Grade = "M-3" Or Grade = "M-4" Or Grade = "M-5" Then
                                    RptPath = "" & frmLogin.ReportsPath & "\Accounts\Bonus\rptBonusSlip.rpt"
                                Else
                                    RptPath = "" & frmLogin.ReportsPath & "\Accounts\Bonus\rptBonusSlip.rpt"
                                End If
                                If frmReportViewerObj.ViewReport(3, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, RptPath, PDFPath, CardNo, Filter, Param) Then
                                    If SendMail(CardNo, PDFPath, ToAddress, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) Then
                                        LogFileWriter(PDFPath & "Email Log File Creation Date " & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day, "Bonus Slip of Card Number = " & CardNo & " Sent to Email Address = " & ToAddress & "")
                                    Else
                                        LogFileWriter(PDFPath & "Email Error Log Files" & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day, "Card No. = " & CardNo & " Error Mail Sending Failed ")
                                        'MsgBox("Mail Sending Failed")
                                    End If
                                Else
                                    LogFileWriter(PDFPath & "Error Email Log File.txt" & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day, "Card No. = " & CardNo & " Error Export to PDF Failed")
                                End If
                            Else
                                If Grade = "E-1" Or Grade = "E-2" Or Grade = "E-3" Or Grade = "M-1" Or Grade = "M-2" Or Grade = "M-3" Or Grade = "M-4" Or Grade = "M-5" Then
                                    ArrList.Add(CardNo)
                                Else
                                    LBArrList.Add(CardNo)
                                End If
                            End If
                        Else
                            If Grade = "E-1" Or Grade = "E-2" Or Grade = "E-3" Or Grade = "M-1" Or Grade = "M-2" Or Grade = "M-3" Or Grade = "M-4" Or Grade = "M-5" Then
                                ArrList.Add(CardNo)
                            Else
                                LBArrList.Add(CardNo)
                            End If
                        End If
                        Try
                            ToolStripProgressBar1.Value += 1
                        Catch ex As Exception
                        End Try
                    Next
                    'ToTime = Now
                    If ArrList.Count > 0 Then
                        Filter = "{tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.CardNo} IN [" & GetCardsInString() & "]"
                        If frmReportViewerObj.ViewReport(1, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, "" & frmLogin.ReportsPath & "\Accounts\rptBonusSlip.rpt", PDFPath, CardNo, Filter, Param) Then
                        Else
                            'MsgBox("Export to PDF Failed")
                        End If
                    End If
                    If LBArrList.Count > 0 Then
                        Filter = "{tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.CardNo} IN [" & GetCardsInString() & "]"
                        If frmReportViewerObj.ViewReport(1, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, "" & frmLogin.ReportsPath & "\Accounts\rptBonusSlip.rpt", PDFPath, CardNo, Filter, Param) Then
                        Else
                            'MsgBox("Export to PDF Failed")
                        End If
                    End If
                    MsgBox("Done")



                End If

            End If
        End If


        If RadioButton2.Checked Then
            Path = "" & frmLogin.ReportsPath & "\Accounts\Bonus\RptBonusTransferLetter.rpt"
            Flag = False
            If RadioButton16.Checked = True Then ' All Dept
                Filter = EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
            ElseIf RadioButton19.Checked = True Then ' main Dept
                Filter = EmpStatus & "   And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
            ElseIf RadioButton9.Checked = True Then ' Section 
                Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
            ElseIf RadioButton8.Checked = True Then ' Designation
                Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & DesigNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""

            End If
        End If



        ''''''permanent Advance ded Aganinst Bonus 
        If PAdvDed.Checked = True Then ' P Adv Ded Againt Annul leaves 
            Path = "" & frmLogin.ReportsPath & "\Accounts\Bonus\RptPADvDedAgnstBonus.rpt"
            Filter = EmpStatus & " And  {tbl_Acc_AnnualLeaveTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And {tbl_Acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {@DedAsLTA} > 0"
            'Filter = EmpStatus & "   And {tbl_acc_AnnualLeaveTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {tbl_acc_AnnualLeaveTransactions.BonusNo} = '" & BonusNoComboBox.SelectedValue & "' And  {@DedAsLTA} > 0  "
        End If




        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Flag = False
            Obj.LoadSalaryReports(Path, Filter, Param)
        End If

    End Sub
    Private Flag As Boolean = False
    Private Function GetCardsInString() As String
        Dim Str As String = ""
        If ArrList.Count > 0 Then
            For i As Integer = 0 To ArrList.Count - 1
                If i = 0 Then
                    Str = Str & ArrList.Item(i).ToString()
                Else
                    Str = Str & ", " & ArrList.Item(i).ToString()
                End If
            Next
        End If
        Return Str
    End Function
    Private Function GetCardsInString1() As String
        Dim Str As String = ""
        If LBArrList.Count > 0 Then
            For i As Integer = 0 To LBArrList.Count - 1
                If i = 0 Then
                    Str = Str & LBArrList.Item(i).ToString()
                Else
                    Str = Str & ", " & LBArrList.Item(i).ToString()
                End If
            Next
        End If
        Return Str
    End Function
    Dim ArrList As New ArrayList()
    Dim LBArrList As New ArrayList
    Private Function SendMail(ByVal CardNo As Integer, ByVal pdfPath As String, ByVal ToAddress As String, ByVal MyMonth As Integer, ByVal MyYear As Integer) As Boolean
        Dim Bool As Boolean = True
        Dim BonusID As String
        If BonusNoComboBox.Text = "1" Then
            BonusID = BonusNoComboBox.Text + "st"
        Else
            BonusID = BonusNoComboBox.Text + "nd"
        End If
        Dim MailBody As String = "Please find attached here with " & BonusID & " Bonus slip of " & FinancialPeriodComboBox.Text & " Year. Your Bonus will be transferred in your account on dated " & DateTimePicker2.Value.Date & "." & vbCrLf & "In case of any query please contact Finance Department Forward Sports (Pvt) Ltd. at Extention Nos. 209, 210" & vbCrLf & "Regards," & vbCrLf & "Manager Finance, " & vbCrLf & "Forward Sports (Pvt) Ltd."
        Try
            Dim MyMessage As New MailMessage("ERP Scheduled Mail <no-reply@forward.pk>", ToAddress, "Online Bonus Slip - Card No. " & CardNo, MailBody)
            Dim MyAttachements As New Attachment(pdfPath & "Bonus_Slip_Card_No=" & CardNo & ".pdf")
            MyMessage.Attachments.Add(MyAttachements)

            Dim emailClient As New SmtpClient("192.168.10.200")
            emailClient.Send(MyMessage)
            Bool = True
        Catch ex As Exception
            Bool = False
        End Try
        Return Bool
        'Return True

    End Function
    Private Sub LogFileWriter(ByVal FilePath As String, ByVal Message As String)
        Dim oStreamWriter As StreamWriter = New StreamWriter(FilePath, True)
        Try
            If Message <> "" Then
                oStreamWriter.WriteLine(Message)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oStreamWriter.Close()
        End Try
    End Sub

    Private Sub SelectFP()
        'Here Obj.ReturnFP() function is a utility function that returns financial period by providing Year and Month
        Dim Obj As New UtilityClass()
        If Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) <> Nothing Then
            FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        Else
            MsgBox("Selected year was beyond the running financial period")
            DateTimePicker1.Value = Now.Date
        End If
    End Sub

    Private Sub frmSalaryReports_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Acc_BonusNoSettings' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_BonusNoSettingsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Acc_BonusNoSettings)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Bank' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BankTableAdapter.FillBy1(Me.DSHRM.tbl_HRM_Bank)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_PayRoll_Shifts' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_PayRoll_ShiftsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_PayRoll_Shifts)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter1.Fill(Me.DSDeptsForPayrollReport.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Branches' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_BranchesTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Branches)
        Me.Tbl_Acc_FinancialPeriodTableAdapter.FillBy(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)
        'Me.Tbl_Hrm_SubDept2TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept2)
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)
        Me.Tbl_Acc_FinancialPeriodBindingSource.MoveLast()
        Try
            SelectFP()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub MonthBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MonthBtn.CheckedChanged

        TextBox1.Enabled = False
        TextBox2.Enabled = False

        BranchNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False
    End Sub

    Private Sub MonthndCedBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MonthndCedBtn.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        BranchNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = False

    End Sub



    Private Sub MonthndShift_CheckedChanged(sender As Object, e As EventArgs) Handles MonthndShift.CheckedChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = False

        BranchNameComboBox.Enabled = False
        ShiftNameComboBox.Enabled = True
    End Sub

    Private Sub MonthndBrnch_CheckedChanged(sender As Object, e As EventArgs) Handles MonthndBrnch.CheckedChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = False

        BranchNameComboBox.Enabled = True
        ShiftNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True
    End Sub

    Private Sub OtherBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SalarySumm.CheckedChanged
        GroupBox7.Enabled = True
        GroupBox3.Enabled = True
        CheckBox1.Enabled = False
        GroupBox9.Enabled = False

        If SalarySumm.Checked = True Then
            DeptSummPanel.Enabled = True
            GroupBox9.Enabled = False
            GroupBox2.Enabled = False
            GroupBox4.Enabled = False
        Else
            DeptSummPanel.Enabled = False
            GroupBox9.Enabled = True
            GroupBox2.Enabled = True
            GroupBox4.Enabled = True
        End If
        Me.DateTimePicker2.Visible = False
        Me.Label4.Visible = False
        MonthndShift.Enabled = True
        MonthndBrnch.Enabled = True
        BankComboBox.Enabled = False
        Button1.Text = "Show Report"
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox7.Enabled = True
        GroupBox3.Enabled = True
        CheckBox1.Enabled = False
        GroupBox9.Enabled = True

        If RadioButton1.Checked = True Then

            GroupBox2.Enabled = False
            GroupBox4.Enabled = False
        Else

            GroupBox2.Enabled = True
            GroupBox4.Enabled = True
        End If
        Me.DateTimePicker2.Visible = True
        Me.Label4.Visible = True
        MonthndShift.Enabled = False
        MonthndBrnch.Enabled = False
        BankComboBox.Enabled = False
        Button1.Text = "Send Email"
    End Sub

    Private Sub SalarySummary_CheckedChanged(sender As Object, e As EventArgs) Handles SalarySummary.CheckedChanged

    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SalaryRecivingBtn_CheckedChanged(sender As Object, e As EventArgs) Handles BonusRecivingBtn.CheckedChanged
        GroupBox7.Enabled = True
        GroupBox3.Enabled = True
        GroupBox9.Enabled = False
        Me.DateTimePicker2.Visible = False
        Me.Label4.Visible = False
        CheckBox1.Enabled = False
        MonthndShift.Enabled = True
        MonthndBrnch.Enabled = True
        BankComboBox.Enabled = False
        Button1.Text = "Show Report"
    End Sub

    Private Sub SalarySlipBTn_CheckedChanged(sender As Object, e As EventArgs) Handles BonusSlipBTn.CheckedChanged
        MonthBtn.Checked = True
        GroupBox7.Enabled = True
        GroupBox3.Enabled = True
        GroupBox9.Enabled = False
        Me.DateTimePicker2.Visible = False
        Me.Label4.Visible = False
        CheckBox1.Enabled = True
        MonthndShift.Enabled = True
        MonthndBrnch.Enabled = True
        BankComboBox.Enabled = False
        Button1.Text = "Show Report"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        CheckBox1.Enabled = False
        GroupBox9.Enabled = True

        'If RadioButton1.Checked = True Then

        GroupBox2.Enabled = False
        GroupBox4.Enabled = False
        If RadioButton2.Checked Then
            GroupBox7.Enabled = True
            Me.TextBox1.Enabled = False
            Me.TextBox2.Enabled = False
            BranchNameComboBox.Enabled = False
            BankComboBox.Enabled = True
        Else
            'GroupBox7.Enabled = False

        End If
        'Else

        '    GroupBox2.Enabled = True
        '    GroupBox4.Enabled = True
        'End If
        GroupBox3.Enabled = False
        Me.DateTimePicker2.Visible = False
        Me.Label4.Visible = False
        MonthndShift.Enabled = False
        MonthndBrnch.Enabled = False
        'BankComboBox.Enabled = False

        Button1.Text = "Show Report"
    End Sub

    Private Sub PAdvDed_CheckedChanged(sender As Object, e As EventArgs) Handles PAdvDed.CheckedChanged

        If PAdvDed.Checked = True Then
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            GroupBox7.Enabled = False
            Panel1.Enabled = False
            CheckBox1.Enabled = False
        Else
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            GroupBox7.Enabled = True
            Panel1.Enabled = True
            CheckBox1.Enabled = True
        End If
    End Sub


    '    If RadioButton18.Checked = True Then
    '        GroupBox1.Enabled = False
    '        GroupBox2.Enabled = False
    '        GroupBox4.Enabled = False
    '    Else
    '        GroupBox1.Enabled = True
    '        GroupBox2.Enabled = True
    '        GroupBox4.Enabled = True

    '    End If
    'End Sub
End Class