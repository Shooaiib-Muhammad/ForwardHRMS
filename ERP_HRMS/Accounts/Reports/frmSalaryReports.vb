Imports System.Net.Mail
Imports System.IO
Imports System.Net
Imports System.Threading

Public Class frmSalaryReports

    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Dim EmpStatus As String
    Dim Prdvalue As String
    Function Convert_Date_Str2Int(Date_Str As Integer) As String

        Select Case Date_Str
            Case 1
                Convert_Date_Str2Int = "January"
            Case 2
                Convert_Date_Str2Int = "February"
            Case 3
                Convert_Date_Str2Int = "March"
            Case 4
                Convert_Date_Str2Int = "April"
            Case 5
                Convert_Date_Str2Int = "May"
            Case 6
                Convert_Date_Str2Int = "June"
            Case 7
                Convert_Date_Str2Int = "July"
            Case 8
                Convert_Date_Str2Int = "August"
            Case 9
                Convert_Date_Str2Int = "September"
            Case 10
                Convert_Date_Str2Int = "October"
            Case 11
                Convert_Date_Str2Int = "November"
            Case 12
                Convert_Date_Str2Int = "December"
        End Select
        Return Convert_Date_Str2Int
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton5.Checked Then
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse
            Dim Msg As String
            Dim PHoneNo As String
            Dim url As String
            Dim dgResult As DialogResult = MessageBox.Show("Are You sure you want To send salary Info. via SMS?", "Exclamation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dgResult = DialogResult.Yes Then
                If Me.View_Emp_DataTableAdapter.Fill(Me.DSDeptsForPayrollReport.View_Emp_Data, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) > 0 Then
                    ToolStripProgressBar1.Maximum = Me.View_Emp_DataBindingSource.Count - 1
                    For k As Int16 = 0 To Me.View_Emp_DataBindingSource.Count - 1
                        'Msg = "Card#=" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("CardNo") & " Name=" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("Name") & " GrossSalary=" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("Name") & " DaysWorked=" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("TotalDaysWorked") & " PaidLeaves=" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("PaidLeaves") & " PayableDays=" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("TotalPayableDays") & " NetPayableAmt=" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("PayableSalary") & ""
                        Msg = "Dear Employee " & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("CardNo") & "/" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("Name") & "," & vbCrLf & "salary calculated for the month " & Convert_Date_Str2Int(Me.DateTimePicker1.Value.Month) & "-" & Me.DateTimePicker1.Value.Year & "." & vbCrLf & "Basic Salary:" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("GrossSalary") & " " & vbCrLf & "Payable Days:" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("TotalPayableDays") & " " & vbCrLf & "Net Payable Salary:" & CInt(Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("PayableSalary")) & " " & vbCrLf & "Thank You"

                        PHoneNo = Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("ContactNo").ToString
                        'MsgBox(Msg)
                        url = "https://connect.jazzcmt.com/sendsms_url.html?Username=03051882139&Password=Jazz@1234&From=Fsports&To=" & PHoneNo & " &Message=" & Msg & ""
                        request = DirectCast(WebRequest.Create(url), WebRequest)
                        Try
                            response = DirectCast(request.GetResponse, HttpWebResponse)
                            response.Dispose()

                        Catch ex As Exception

                        End Try

                        Thread.Sleep(1500)
                        Application.DoEvents()
                        Try
                            ToolStripProgressBar1.Value += 1
                        Catch ex As Exception
                        End Try

                    Next

                End If
            End If


        Else

            ToolStripProgressBar1.Value = 0
            If SalarySlipBTn.Checked = True Or SalaryRecivingBtn.Checked = True Or OtherBtn.Checked = True Or RadioButton4.Checked = True Or RadioButton18.Checked = True Or RadioButton2.Checked = True Or RadioButton3.Checked = True Then

                If ActiveBtn.Checked = True Then
                    EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = True"
                ElseIf NonActivrBtn.Checked = True Then
                    EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus} = False"
                ElseIf AllEmp.Checked = True Then
                    EmpStatus = "({View_Rpt_Acc_PreSalary.EmpStatus} = True Or {View_Rpt_Acc_PreSalary.EmpStatus} = False)"
                End If

            End If
            If Allprd.Checked = True Then
                Prdvalue = "{View_Rpt_Acc_PreSalary.CardNo} >= 1 "
            ElseIf prd.Checked = True Then
                Prdvalue = "{View_Rpt_Acc_PreSalary.AccJobType} = 'Production'"
            ElseIf NonPrd.Checked = True Then
                Prdvalue = "{View_Rpt_Acc_PreSalary.AccJobType} = 'Non Production'"
            End If
            If SalarySlipBTn.Checked = True Then ' Normal Salary Rpt 
                If NrmlBtn.Checked = True Then ' Normal btn 
                    If CheckBox1.CheckState = CheckState.Checked Then
                        Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccSalarySlipNightShift.rpt"
                    Else
                        Path = "" & frmLogin.ReportsPath & "\Accounts\rptAccSalarySlipNormalShift.rpt"
                    End If

                    If AllBtn.Checked = True Then ' All Cash And Transfer 
                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then ' All Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    ElseIf CashBtn.Checked = True Then ' By cash 
                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And   {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    ElseIf TransferBtn.Checked = True Then ' By transfer

                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And   {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    End If
                End If
            End If

            If SalaryRecivingBtn.Checked = True Then ' Salary receiving List 
                If NrmlBtn.Checked = True Then ' Normal 
                    If CheckBox1.CheckState = CheckState.Checked Then
                        Path = "" & frmLogin.ReportsPath & "\Accounts\RptsalaryreclistNightShift.rpt"
                    Else
                        Path = "" & frmLogin.ReportsPath & "\Accounts\Rptsalaryreclist.rpt"
                    End If

                    If AllBtn.Checked = True Then ' All Cash And Transfer 
                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then ' All Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    ElseIf CashBtn.Checked = True Then ' By cash 
                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And   {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    ElseIf TransferBtn.Checked = True Then ' By transfer
                        '''' For Bank Transfer Check
                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And   {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    End If
                End If
            End If






            If RadioButton4.Checked = True Then ' Salary receiving List  Day And Night 
                If NrmlBtn.Checked = True Then ' Normal 

                    Path = "" & frmLogin.ReportsPath & "\Accounts\RptsalaryreclistAll.rpt"
                    If AllBtn.Checked = True Then ' All Cash And Transfer 
                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then ' All Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    ElseIf CashBtn.Checked = True Then ' By cash 
                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And   {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Cash'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    ElseIf TransferBtn.Checked = True Then ' By transfer
                        '''' For Bank Transfer Check
                        If MonthBtn.Checked = True Then 'By Month 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                            If RadioButton16.Checked = True Then
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton19.Checked = True Then ' Dept 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton9.Checked = True Then ' Section 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And   {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else
                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            ElseIf RadioButton8.Checked = True Then ' Desig 
                                If TextBox1.Text.Length = 0 Then
                                    Flag = True
                                Else
                                    Flag = False
                                End If
                                If TextBox2.Text = "" Then

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                                Else

                                    Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                                End If
                            End If
                        ElseIf MonthndShift.Checked = True Then ' By shift 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                            Flag = False
                            If RadioButton16.Checked = True Then ' All Dept 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton19.Checked = True Then ' By Main Dept
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton9.Checked = True Then ' By Section 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            ElseIf RadioButton8.Checked = True Then ' By Designation 
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer'  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                            End If
                        End If
                    End If
                End If
            End If








            If OtherBtn.Checked = True Then ' Other report
                If SalarySummary.Checked = True Then ' Salary Summary 
                    Path = "" & frmLogin.ReportsPath & "\Accounts\RptSalarySumm.rpt"
                    If MonthBtn.Checked = True Then 'By Month 
                        Flag = False
                        If RadioButton16.Checked = True Then ' All Dept 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        ElseIf RadioButton19.Checked = True Then ' By Main Dept
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        ElseIf RadioButton9.Checked = True Then ' By Section 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

                        ElseIf RadioButton8.Checked = True Then ' By Designation 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        End If
                    ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                        If RadioButton16.Checked = True Then ' All Dept 
                            If TextBox1.Text.Length = 0 Then
                                Flag = True
                            Else
                                Flag = False
                            End If
                            If TextBox2.Text = "" Then
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                            Else
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                            End If
                        ElseIf RadioButton19.Checked = True Then ' Dept 
                            If TextBox1.Text.Length = 0 Then
                                Flag = True
                            Else
                                Flag = False
                            End If
                            If TextBox2.Text = "" Then
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                            Else
                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                            End If
                        ElseIf RadioButton9.Checked = True Then ' Section 
                            If TextBox1.Text.Length = 0 Then
                                Flag = True
                            Else
                                Flag = False
                            End If
                            If TextBox2.Text = "" Then
                                Filter = Prdvalue & " And " & EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                            Else
                                Filter = Prdvalue & " And " & EmpStatus & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                            End If
                        ElseIf RadioButton8.Checked = True Then ' Desig 
                            If TextBox1.Text.Length = 0 Then
                                Flag = True
                            Else
                                Flag = False
                            End If
                            If TextBox2.Text = "" Then

                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                            Else

                                Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "'  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & "  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                            End If
                        End If
                    ElseIf MonthndShift.Checked = True Then ' By shift 
                        Flag = False
                        If RadioButton16.Checked = True Then ' All Dept 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        ElseIf RadioButton19.Checked = True Then ' By Main Dept
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        ElseIf RadioButton9.Checked = True Then ' By Section 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        ElseIf RadioButton8.Checked = True Then ' By Designation 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        End If
                    ElseIf MonthndBrnch.Checked = True Then ' By Branch 
                        Flag = False
                        If RadioButton16.Checked = True Then ' All Dept 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        ElseIf RadioButton19.Checked = True Then ' By Main Dept
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        ElseIf RadioButton9.Checked = True Then ' By Section 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        ElseIf RadioButton8.Checked = True Then ' By Designation 
                            Filter = Prdvalue & " And " & EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
                        End If
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
                Dim MangPath As String = "" & frmLogin.ReportsPath & "\Accounts\rptAccSalarySlip.rpt"
                Dim LabourPath As String = "" & frmLogin.ReportsPath & "\Accounts\rptAccSalaryEmail.rpt"
                Dim RptPath As String = ""
                'Dim FromTime As DateTime
                'Dim ToTime As DateTime

                ArrList.Clear()
                LBArrList.Clear()
                Dim Grade As String = ""

                Dim PDFPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Salary Slips PDF\"
                If Directory.Exists(PDFPath) Then
                Else
                    Directory.CreateDirectory(PDFPath)
                End If
                Dim EmailLogPath As String = "" & frmLogin.ReportsPath & "\Accounts\Email Log\ Slip Log " & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day & ""
                If Directory.Exists(EmailLogPath) Then
                Else
                    Directory.CreateDirectory(EmailLogPath)
                End If
                Dim IpAddress = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString
                Dim US = frmLogin.UserName
                dgResult = MessageBox.Show("Are You sure you want To send salary slips via email?", "Exclamation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If dgResult = DialogResult.Yes Then
                    If MonthndCedBtn.Checked = True Then
                        Me.View_Rpt_Acc_SalarySlipEmailTableAdapter.FillBy(Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, TextBox1.Text, TextBox2.Text)
                    ElseIf MonthBtn.Checked = True Then
                        Me.View_Rpt_Acc_SalarySlipEmailTableAdapter.Fill(Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                    End If
                    If Me.View_Rpt_Acc_SalarySlipEmailBindingSource.Count > 0 Then
                        'FromTime = Now
                        'Me.View_Rpt_Acc_SalarySlipEmailBindingSource.Filter = "CardNo= 158"
                        ToolStripProgressBar1.Maximum = View_Rpt_Acc_SalarySlipEmailBindingSource.Count - 1
                        For i As Integer = 0 To Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail.Count - 1
                            CardNo = Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item(0)
                            Grade = Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item("Grade").ToString.Trim

                            If Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item(2) IsNot DBNull.Value Then
                                If Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item(2) <> "" Then
                                    Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} = " & CardNo & " And {View_Rpt_Acc_PreSalary.EmpStatus}"
                                    ToAddress = Me.DSSalaryTrans.View_Rpt_Acc_SalarySlipEmail(i).Item(2)
                                    If Grade = "E-1" Or Grade = "E-2" Or Grade = "E-3" Or Grade = "M-1" Or Grade = "M-2" Or Grade = "M-3" Or Grade = "M-4" Or Grade = "M-5" Then
                                        RptPath = "" & frmLogin.ReportsPath & "\Accounts\rptAccSalarySlip.rpt"
                                    Else
                                        RptPath = "" & frmLogin.ReportsPath & "\Accounts\rptAccSalaryEmail.rpt"
                                    End If
                                    If frmReportViewerObj.ViewReport(0, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, RptPath, PDFPath, CardNo, Filter, Param) Then
                                        If SendMail(CardNo, PDFPath, ToAddress, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) Then
                                            'LogFileWriter(PDFPath & "Email Log File Creation Date " & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day, "Salary Slip of Card Number = " & CardNo & " Sent to Email Address = " & ToAddress & "")
                                            LogFileWriter(EmailLogPath & "Email Log File Creation Date " & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day, "Salary Slip of Card Number = " & CardNo & " Sender UserName:" & US & "  Sender IP Address:" & IpAddress & " Sent to Email Address = " & ToAddress & "")
                                        Else
                                            LogFileWriter(EmailLogPath & "Email Error Log Files" & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day, "Card No.= " & CardNo & " Sender UserName:" & US & "  Sender IP Address:" & IpAddress & " Error Mail Sending Failed ")
                                            'MsgBox("Mail Sending Failed")
                                        End If
                                    Else
                                        LogFileWriter(EmailLogPath & "Error Email Log File.txt" & DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day, "Card No. = " & CardNo & " Sender UserName:" & US & "  Sender IP Address:" & IpAddress & " Error Export to PDF Failed")
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
                            Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} IN [" & GetCardsInString() & "]"
                            If frmReportViewerObj.ViewReport(1, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, "" & frmLogin.ReportsPath & "\Accounts\rptAccSalarySlip.rpt", PDFPath, CardNo, Filter, Param) Then
                            Else
                                'MsgBox("Export to PDF Failed")
                            End If
                        End If
                        If LBArrList.Count > 0 Then
                            Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} IN [" & GetCardsInString1() & "]"
                            If frmReportViewerObj.ViewReport(1, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, "" & frmLogin.ReportsPath & "\Accounts\rptAccSalarySlipNightShift.rpt", PDFPath, CardNo, Filter, Param) Then
                            Else
                                'MsgBox("Export to PDF Failed")
                            End If
                        End If
                        MsgBox("Done")



                    End If

                End If
            End If


            If RadioButton2.Checked Then
                Path = "" & frmLogin.ReportsPath & "\Accounts\RptSalaryTransferLetter.rpt"
                Flag = False
                If RadioButton16.Checked = True Then ' All Dept 
                    Filter = EmpStatus & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
                ElseIf RadioButton19.Checked = True Then ' By Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
                ElseIf RadioButton9.Checked = True Then ' By Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""

                ElseIf RadioButton8.Checked = True Then ' By Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
                End If
            End If



            ''''''


            If RadioButton3.Checked Then
                Path = "" & frmLogin.ReportsPath & "\Accounts\RptsalaryreclistBanks.rpt"
                Flag = False
                If RadioButton16.Checked = True Then ' All Dept 
                    Filter = EmpStatus & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
                ElseIf RadioButton19.Checked = True Then ' By Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
                ElseIf RadioButton9.Checked = True Then ' By Section 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""

                ElseIf RadioButton8.Checked = True Then ' By Designation 
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} = '" & DesigNameComboBox.Text & "' And  Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Year & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Transfer' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""
                End If
            End If

            'If RadioButton5.Checked Then
            '    Path = "" & frmLogin.ReportsPath & "\Accounts\RptTempAdvTransferLetterSP.rpt"
            '    Flag = False
            '    If RadioButton16.Checked = True Then ' All Dept 
            '        Filter = "{View_Rpt_Acc_ShortTermAdvances.TransactionDate} in #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Acc_PreSalary.BankAccNo} <> 'null'   And {View_Rpt_Acc_PreSalary.PaymentMode} = 'Transfer' And  {View_Rpt_Acc_PreSalary.BankID} = " & BankComboBox.SelectedValue & ""

            '    End If
            'End If

            If Flag = True Then
                MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Flag = False
                Obj.LoadSalaryReports(Path, Filter, Param)
            End If
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
        Dim MailBody As String = "Please find attached here with salary slip of current month. Your Salary will be transferred in your account on dated " & DateTimePicker2.Value.Date & "." & vbCrLf & "In case of any query please contact Finance Department Forward Sports (Pvt) Ltd. at Extention Nos. 209, 210" & vbCrLf & "Regards," & vbCrLf & "Manager Finance, " & vbCrLf & "Forward Sports (Pvt) Ltd."
        Try
            Dim MyMessage As New MailMessage("ERP Scheduled Mail <no-reply@forward.pk>", ToAddress, "Online Salary Slip - Card No. " & CardNo, MailBody)
            Dim MyAttachements As New Attachment(pdfPath & "Salary_Slip_Card_No=" & CardNo & "_Month=" & MyMonth & "_Year=" & MyYear & ".pdf")
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

    Private Sub OtherBtn_CheckedChanged(sender As Object, e As EventArgs) Handles OtherBtn.CheckedChanged
        GroupBox7.Enabled = True
        GroupBox3.Enabled = True
        CheckBox1.Enabled = False
        GroupBox9.Enabled = False

        If OtherBtn.Checked = True Then
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
            GroupBox8.Enabled = False
            GroupBox2.Enabled = False
            GroupBox4.Enabled = False
        Else
            GroupBox8.Enabled = True
            GroupBox2.Enabled = True
            GroupBox4.Enabled = True
        End If
        Me.DateTimePicker2.Visible = True
        Me.Label4.Visible = True
        MonthndShift.Enabled = False
        MonthndBrnch.Enabled = False
        BankComboBox.Enabled = False
        Button1.Text = "Send Email"
        If RadioButton5.Checked Then
            Button1.Text = "SMS Salary"
            Me.DateTimePicker2.Visible = False
            Me.Label4.Visible = False
        End If
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

    Private Sub SalaryRecivingBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SalaryRecivingBtn.CheckedChanged
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

    Private Sub SalarySlipBTn_CheckedChanged(sender As Object, e As EventArgs) Handles SalarySlipBTn.CheckedChanged
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
            GroupBox8.Enabled = False
        Else
            'GroupBox7.Enabled = False
            GroupBox8.Enabled = True
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

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        CheckBox1.Enabled = False
        GroupBox9.Enabled = True

        'If RadioButton1.Checked = True Then

        GroupBox2.Enabled = False
        GroupBox4.Enabled = False
        If RadioButton3.Checked Then
            GroupBox7.Enabled = True
            Me.TextBox1.Enabled = False
            Me.TextBox2.Enabled = False
            BranchNameComboBox.Enabled = False
            BankComboBox.Enabled = True
            GroupBox8.Enabled = False
        Else
            GroupBox8.Enabled = True
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

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        CheckBox1.Enabled = False
        GroupBox5.Enabled = True
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        CheckBox1.Enabled = False
        GroupBox9.Enabled = True

        'If RadioButton1.Checked = True Then

        GroupBox2.Enabled = False
        GroupBox4.Enabled = False
        If RadioButton5.Checked Then
            GroupBox7.Enabled = True
            Me.TextBox1.Enabled = False
            Me.TextBox2.Enabled = False
            BranchNameComboBox.Enabled = False
            BankComboBox.Enabled = True
            GroupBox8.Enabled = False
        Else
            'GroupBox7.Enabled = False
            GroupBox8.Enabled = True
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