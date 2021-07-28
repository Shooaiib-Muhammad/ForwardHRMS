
Imports System.Net
Imports System.Threading
Public Class frmSMSPortal
    Private Sub Tbl_Hrm_DepartmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Hrm_DepartmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSDeptsForPayrollReport)

    End Sub


    Dim Msg As String
    Dim PHoneNo As String
    Dim url As String

    Private Sub frmSMSPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_SubDept1' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Departments' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)
        SelectFP()
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

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub MonthndCedBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MonthndCedBtn.CheckedChanged
        If MonthndCedBtn.Checked = True Then
            GroupBox7.Enabled = True
        Else
            GroupBox7.Enabled = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flag As Boolean
        Dim dgResult As DialogResult = MessageBox.Show("Are You sure you want To send message . ?", "Exclamation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dgResult = DialogResult.Yes Then
            If MonthBtn.Checked = True Then 'By All  
                flag = False
                If RadioButton16.Checked = True Then ' All Dept 
                    View_Rpt_Acc_PreSalaryTableAdapter.FillByAll(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary)
                ElseIf RadioButton19.Checked = True Then ' By Main Dept
                    View_Rpt_Acc_PreSalaryTableAdapter.Fill(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, DeptNameComboBox.SelectedValue)
                ElseIf RadioButton9.Checked = True Then ' By Section 
                    View_Rpt_Acc_PreSalaryTableAdapter.FillBy(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, NameComboBox.Text, DeptNameComboBox.SelectedValue)

                ElseIf RadioButton8.Checked = True Then ' By Designation 
                    View_Rpt_Acc_PreSalaryTableAdapter.FillBy1(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, DesigNameComboBox.Text)
                End If


            ElseIf MonthndCedBtn.Checked = True Then ' By card range 
                If RadioButton16.Checked = True Then ' All Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Try
                            View_Rpt_Acc_PreSalaryTableAdapter.FillByAllCard(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, TextBox1.Text, TextBox1.Text)
                        Catch ex As Exception

                        End Try

                    Else
                        Try
                            View_Rpt_Acc_PreSalaryTableAdapter.FillByAllCard(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, TextBox1.Text, TextBox2.Text)

                        Catch ex As Exception

                        End Try
                    End If
                ElseIf RadioButton19.Checked = True Then ' Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        View_Rpt_Acc_PreSalaryTableAdapter.FillCard(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, DeptNameComboBox.SelectedValue, TextBox1.Text, TextBox1.Text)
                    Else
                        View_Rpt_Acc_PreSalaryTableAdapter.FillCard(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, DeptNameComboBox.SelectedValue, TextBox1.Text, TextBox2.Text)
                    End If
                ElseIf RadioButton9.Checked = True Then ' Section 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        View_Rpt_Acc_PreSalaryTableAdapter.FillByCard(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, DeptNameComboBox.SelectedValue, NameComboBox.Text, TextBox1.Text, TextBox1.Text)

                    Else
                        View_Rpt_Acc_PreSalaryTableAdapter.FillByCard(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, DeptNameComboBox.SelectedValue, NameComboBox.Text, TextBox1.Text, TextBox2.Text)
                    End If
                ElseIf RadioButton8.Checked = True Then ' Desig 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        View_Rpt_Acc_PreSalaryTableAdapter.FillBy1Card(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, DesigNameComboBox.Text, TextBox1.Text, TextBox1.Text)
                    Else

                        View_Rpt_Acc_PreSalaryTableAdapter.FillBy1Card(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary, DesigNameComboBox.Text, TextBox1.Text, TextBox2.Text)
                    End If
                End If
            End If
            SendSMS()
        End If
    End Sub
    Private Sub SendSMS()
        'Try
        Dim request As HttpWebRequest
            Dim response As HttpWebResponse
            ToolStripProgressBar1.Maximum = Me.View_Rpt_Acc_PreSalaryBindingSource.Count - 1
            For k As Int16 = 0 To Me.View_Rpt_Acc_PreSalaryBindingSource.Count - 1
                If RadioButton1.Checked = True Then
                    Msg = "Dear Employee " & Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("CardNo") & "/" & Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("Name") & "," & vbCrLf & ComposeMsgBox.Text
                ElseIf RadioButton2.Checked = True Then
                LoardRecord(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("EmpID"), FinancialPeriodComboBox.SelectedValue, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                Dim HalfDays As Double = 0
                Try
                    HalfDays = Me.DSCalculateSalary.View_Rpt_PayRoll_EmpAttRecord1.Rows(0).Item("TotalHalfDays")
                Catch ex As Exception
                    HalfDays = 0
                End Try
                If HalfDays = 0 Then
                    HalfDays = 0
                Else
                    HalfDays = Me.DSCalculateSalary.View_Rpt_PayRoll_EmpAttRecord1.Rows(0).Item("TotalHalfDays") / 2
                End If
                Dim FullDay As Integer = 0
                Try
                    FullDay = Val(Me.DSCalculateSalary.View_Rpt_PayRoll_EmpAttRecord.Rows(0).Item("TotalFullDays"))
                Catch ex As Exception
                    FullDay = 0
                End Try
                Dim TotalLeaves As Double = 0
                Try
                    TotalLeaves = Me.DSCalculateSalary.tbl_PayRoll_LongLeaves6.Rows(0).Item("TotalLeaves")
                Catch ex As Exception
                    TotalLeaves = 0
                End Try
                Dim UnpaidLeaves As Double = 0
                Try
                    UnpaidLeaves = Me.DSCalculateSalary.tbl_PayRoll_LongLeaves8.Rows(0).Item("UnPaidLeaves")
                Catch ex As Exception
                    UnpaidLeaves = 0
                End Try
                Dim PaidLeaves As Double = 0
                Try
                    PaidLeaves = Val(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves4.Rows(0).Item("PaidLeaves"))
                Catch ex As Exception
                    PaidLeaves = 0
                End Try
                Dim intSumOfHalfAndFullDays As Double = HalfDays + FullDay
                Dim PayableDays As Double = intSumOfHalfAndFullDays + PaidLeaves
                'Dim PayableDays As Double = intSumOfHalfAndFullDays + Me.DSCalculateSalary.tbl_PayRoll_LongLeaves4.Rows(0).Item("PaidLeaves")
                Dim holioday As Double = Val(Me.DSCalculateSalary.tbl_Hrm_Holidays.Rows(0).Item("HolidayCount"))
                Dim FinalWorkingDays As Double = (CalculateWorkingDays() - Val(Me.DSCalculateSalary.tbl_Hrm_Holidays.Rows(0).Item("HolidayCount")))
                Dim AbsentLeaves As Double = TotalLeaves - (PaidLeaves + UnpaidLeaves)
                'Dim AbsentLeaves As Double = TotalLeaves - (Me.DSCalculateSalary.tbl_PayRoll_LongLeaves4.Rows(0).Item("PaidLeaves") + Me.DSCalculateSalary.tbl_PayRoll_LongLeaves8.Rows(0).Item("UnPaidLeaves"))
                Dim Dayduction As Double = 0
                Try
                    Dayduction = Val(Me.DSCalculateSalary.View_Emp_Deduction_Days.Rows(0).Item("DayDeduction"))
                Catch ex As Exception
                    Dayduction = 0
                End Try
                Dim overtimeHours As Double = 0
                Try
                    overtimeHours = RoundOTHoursMinutes(Val(Me.DSCalculateSalary.View_Rpt_Acc_OverTimeSum.Rows(0).Item("FullMinutesWorked")))
                Catch ex As Exception
                    overtimeHours = 0
                End Try


                Dim intAbsentees As Double = CalculteAbsentees(FinalWorkingDays, intSumOfHalfAndFullDays, 0, PaidLeaves, Dayduction)
                If CType(Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("DOJ"), Date) > CType(1 & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year, Date) Then
                    PayableDays = ((intSumOfHalfAndFullDays + PaidLeaves + holioday) - Dayduction)
                    If PayableDays > 26 Then
                            PayableDays = 26
                        End If
                    Else
                        PayableDays = 26 - intAbsentees
                    End If
                'Msg = "Dear Employee " & Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("CardNo") & "/" & Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("Name") & "," & vbCrLf & " Over Time Hours :" & overtimeHours & "," & vbCrLf & " Paid Leaves:" & PaidLeaves & "," & vbCrLf & " Total Worked Days:" & intSumOfHalfAndFullDays & "," & vbCrLf & " Total Payable Days:" & PayableDays
                Msg = "Dear Employee " & Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("CardNo") & "/" & Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("Name") & vbCrLf & " Paid Leaves:" & PaidLeaves & vbCrLf & " Un Paid Leaves:" & UnpaidLeaves & vbCrLf & " Absent:" & AbsentLeaves & "," & vbCrLf & " Total Payable Days:" & PayableDays
            End If

                'Msg = "Dear Employee " & Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("CardNo") & "/" & Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary.Rows(k).Item("Name") & "," & vbCrLf & "Your salary has been calculated for the month of " & Convert_Date_Str2Int(Me.DateTimePicker1.Value.Month) & "-" & Me.DateTimePicker1.Value.Year & "." & vbCrLf & "Basic Salary:" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("GrossSalary") & " " & vbCrLf & "Payable Days:" & Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("TotalPayableDays") & " " & vbCrLf & "Net Payable Salary:" & CInt(Me.DSDeptsForPayrollReport.View_Emp_Data.Rows(k).Item("PayableSalary")) & " " & vbCrLf & "Thank You."

                PHoneNo = Me.DSDeptsForPayrollReport.View_Rpt_Acc_PreSalary(k).Item("ContactNo").ToString

            url = "https://connect.jazzcmt.com/sendsms_url.html?Username=03051882139&Password=Jazz@1234&From=Fsports&To=" & PHoneNo & " &Message=" & Msg & ""
            request = DirectCast(WebRequest.Create(url), WebRequest)
            'response = DirectCast(request.GetResponse, HttpWebResponse)
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
            MsgBox("successfully sent to following record ! ")
            ToolStripProgressBar1.Value = 0
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Function CalculteAbsentees(ByVal WorkingDays As Double, ByVal DaysWorked As Double, ByVal MaskedDays As Double, ByVal PaidLeaves As Double, ByVal Deductions As Integer) As Double
        Dim Absentees As Double
        Absentees = WorkingDays - (DaysWorked + MaskedDays + PaidLeaves - Deductions)
        If Absentees < 0 Then
            Absentees = 0
        End If
        Return Absentees
    End Function
    Private Function CalculateWorkingDays() As Integer
        Dim NoOfDaysinMonth As Integer
        Dim j As Int16
        Dim c As Int16 = 0
        NoOfDaysinMonth = DateTime.DaysInMonth(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
        For j = 1 To NoOfDaysinMonth
            Dim MyWeekDay = Weekday(CType(j & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year, Date))
            If MyWeekDay = 1 Then
                'Do nothing if weekday is Sunday
            Else
                c += 1
            End If
        Next
        Return c
    End Function
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

    Private Sub RadioEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles RadioEnglish.CheckedChanged
        Switch_Language()
        ComposeMsgBox.RightToLeft = RightToLeft.No
    End Sub

    Private Sub RadioUrdu_CheckedChanged(sender As Object, e As EventArgs) Handles RadioUrdu.CheckedChanged
        Switch_Language()
        ComposeMsgBox.RightToLeft = RightToLeft.Yes
    End Sub
    Private Sub Switch_Language()
        If RadioEnglish.Checked = True Then
            English()
        ElseIf RadioUrdu.Checked = True Then
            Urdu()
        End If
    End Sub

    Public Sub English()
        For Each language As InputLanguage In InputLanguage.InstalledInputLanguages
            If language.Culture.TwoLetterISOLanguageName.Contains("en") = True Then
                InputLanguage.CurrentInputLanguage = language
            End If
        Next
    End Sub
    Public Sub Urdu()
        For Each language As InputLanguage In InputLanguage.InstalledInputLanguages
            If language.Culture.TwoLetterISOLanguageName.Contains("ur") = True Then
                InputLanguage.CurrentInputLanguage = language
            End If
        Next
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            DateTimePicker1.Enabled = True
            FinancialPeriodComboBox.Enabled = True
            ComposeMsgBox.Enabled = False
        Else
            DateTimePicker1.Enabled = False
            FinancialPeriodComboBox.Enabled = False
            ComposeMsgBox.Enabled = True
        End If
    End Sub
    Private Sub LoardRecord(empID As Integer, FP As String, Month As Integer, year As Integer)
        Try
            Me.View_Rpt_Acc_OverTimeSumTableAdapter.Fill(Me.DSCalculateSalary.View_Rpt_Acc_OverTimeSum, empID, year, Month)


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_PayRoll_LongLeaves4TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves4, empID, FP, year, Month)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.View_Rpt_PayRoll_EmpAttRecordTableAdapter.Fill(Me.DSCalculateSalary.View_Rpt_PayRoll_EmpAttRecord, empID, year, Month)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Rpt_PayRoll_EmpAttRecord1TableAdapter.Fill(Me.DSCalculateSalary.View_Rpt_PayRoll_EmpAttRecord1, empID, year, Month)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_Hrm_HolidaysTableAdapter.Fill(Me.DSCalculateSalary.tbl_Hrm_Holidays, Month, year)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Emp_Deduction_DaysTableAdapter.Fill(Me.DSCalculateSalary.View_Emp_Deduction_Days, Month, year, empID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_PayRoll_LongLeaves6TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves6, empID, FP, year, Month)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.Tbl_PayRoll_LongLeaves8TableAdapter.Fill(Me.DSCalculateSalary.tbl_PayRoll_LongLeaves8, empID, FP, year, Month)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function RoundOTHoursMinutes(ByVal OTMinutes As Double) As Double
        'Roung Over Time Minutes
        Dim OTHours As Double
        Dim i As Double
        Dim j As Double
        Dim Diff As Double

        i = Math.Truncate(OTMinutes / 60)
        j = OTMinutes / 60
        Diff = j - i
        Diff = (Math.Truncate(Diff * 100)) / 100
        If Diff >= 0 And Diff <= 0.41 Then '<25 minutes
            OTHours = i
        ElseIf Diff > 0.41 And Diff <= 0.5 Then '>=25 Minutes
            OTHours = i + 0.5
        ElseIf Diff > 0.5 And Diff <= 0.91 Then '<55 Minutes
            OTHours = i + 0.5
        ElseIf Diff > 0.91 And Diff <= 0.99 Then '>=55 Minutes
            OTHours = i + 1
        Else
            OTHours = i
        End If
        Return OTHours

    End Function

    Private Sub FillToolStripButton1_Click(sender As Object, e As EventArgs)


    End Sub


End Class