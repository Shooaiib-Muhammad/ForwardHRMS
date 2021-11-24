Public Class frmLeavesPR

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Param As String = ""
        Dim Path As String = ""
        Dim Obj As New UtilityClass
        Dim EmpStatus As String

        If LeavBtn.Checked = True Or RadioButton18.Checked = True Or RadioButton2.Checked = True Or RadioButton5.Checked = True Or RadioButton8.Checked = True Then

            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_PayRoll_EmpInfo.empstatus} = true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_PayRoll_EmpInfo.empstatus} = false "
            ElseIf RadioButton4.Checked = True Then
                EmpStatus = "({View_Rpt_PayRoll_EmpInfo.empstatus} = True or {View_Rpt_PayRoll_EmpInfo.empstatus} = False)"
            End If
        End If


        If DetlLeavRcd.Checked = True Or RadioButton3.Checked = True Or RadioButton32.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.empstatus} = true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.empstatus} = false "
            ElseIf RadioButton4.Checked = True Then
                EmpStatus = "({View_Rpt_Acc_PreSalary.empstatus} = True or {View_Rpt_Acc_PreSalary.empstatus} = False)"
            End If
        End If

        If RadioButton7.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_PayRoll_EmpInfo.EmpStatus} = true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_PayRoll_EmpInfo.EmpStatus} = false "
            ElseIf RadioButton4.Checked = True Then
                EmpStatus = "({View_Rpt_PayRoll_EmpInfo.EmpStatus} = True or {View_Rpt_PayRoll_EmpInfo.EmpStatus} = False)"
            End If
        End If


        If DetlLeavRcd.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollLeavesByYear.rpt"

            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus

                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                End If
            ElseIf RadioDateCard.Checked = True Then ' By Card Number
                If AllEMp.Checked = True Then ' By Emp
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True "
                    End If

                ElseIf ByDept.Checked = True Then ' main Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                    End If
                    'Filter = " {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True "
                    End If
                    'Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                    End If
                End If

            ElseIf Specialbtn.Checked = True Then
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Rpt_Acc_PreSalary.EmpStatus}=True"


            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.EmpStatus}=True"
                End If

            End If
        End If

        If RadioButton8.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollLongLeavesSum.rpt"
            Param = "FromDate=#" & Format(StrtTime.Value, "dd/MM/yyyy") & "#&ToDate=#" & Format(EndTime.Value, "dd/MM/yyyy") & "#"
            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Absent' and {View_Rpt_PayRoll_LongLeaveSum.LeaveDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"

                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Absent' and {View_Rpt_PayRoll_LongLeaveSum.LeaveDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#And {View_Rpt_PayRoll_EmpInfo.DeptID} =" & DeptNameComboBox.SelectedValue & " "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Absent' and {View_Rpt_PayRoll_LongLeaveSum.LeaveDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Absent' and {View_Rpt_PayRoll_LongLeaveSum.LeaveDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#  And {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' "
                End If

            End If

        End If
        If RadioButton10.Checked = True Then '' Employee Leaves
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptLeaveFormat.rpt"
            'Param = "FromDate=#" & Format(StrtTime.Value, "dd/MM/yyyy") & "#&ToDate=#" & Format(EndTime.Value, "dd/MM/yyyy") & "#"
            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = "{View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"

                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = "{View_PayRoll_Leave_Detail.FromDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_PayRoll_Leave_Detail.DeptName} ='" & DeptNameComboBox.Text & "'"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = "{View_PayRoll_Leave_Detail.FromDate}in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_PayRoll_Leave_Detail.DeptName} ='" & DeptNameComboBox.Text & "' And {View_PayRoll_Leave_Detail.SectionName} = '" & NameComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = "{View_PayRoll_Leave_Detail.FromDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#  And {View_PayRoll_Leave_Detail.DesigName}  = '" & DesigNameComboBox.Text & "' "
                End If

            ElseIf RadioDateCard.Checked = True Then
                If AllEMp.Checked = True Then ' By Emp
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_PayRoll_Leave_Detail.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & "And {View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_PayRoll_Leave_Detail.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf ByDept.Checked = True Then ' main Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_PayRoll_Leave_Detail.DeptName} ='" & DeptNameComboBox.Text & "'  And  {View_PayRoll_Leave_Detail.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " {View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_PayRoll_Leave_Detail.DeptName} ='" & DeptNameComboBox.Text & "'   And  {View_PayRoll_Leave_Detail.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = " {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_PayRoll_Leave_Detail.DeptName} ='" & DeptNameComboBox.Text & "' And {View_PayRoll_Leave_Detail.SectionName} = '" & NameComboBox.Text & "'  And  {View_PayRoll_Leave_Detail.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_PayRoll_Leave_Detail.DeptName} ='" & DeptNameComboBox.Text & "' And {View_PayRoll_Leave_Detail.SectionName} = '" & NameComboBox.Text & "'   And  {View_PayRoll_Leave_Detail.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & "  And {View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = " {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_PayRoll_Leave_Detail.DesigName}  = '" & DesigNameComboBox.Text & "' And  {View_PayRoll_Leave_Detail.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_PayRoll_Leave_Detail.DesigName}  = '" & DesigNameComboBox.Text & "' And  {View_PayRoll_Leave_Detail.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_PayRoll_Leave_Detail.FromDate} in #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            End If
        End If


        If RadioButton7.Checked = True Then '''' Dailly leaves
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollLongLeavesNEW.rpt"

            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"

                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioDateCard.Checked = True Then ' By Card Number
                If AllEMp.Checked = True Then ' By Emp
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & "And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf ByDept.Checked = True Then ' main Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = " {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & "  And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = " {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    End If
                End If

            ElseIf Specialbtn.Checked = True Then
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"


            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                End If

            End If
        End If







        '''''''''' HERE
        If RadioButton5.Checked Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollLongLeaves.rpt"


            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                End If
            ElseIf RadioDateCard.Checked = True Then ' By Card Number
                If AllEMp.Checked = True Then ' By Emp
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    End If

                ElseIf ByDept.Checked = True Then ' main Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  "
                    End If
                    'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    End If
                    'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  "
                    End If
                End If

            ElseIf Specialbtn.Checked = True Then
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  "


            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'   "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'   "
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'   "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'   "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'   "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                End If

            End If

        End If








        '''''''''''' End Here



        If LeavBtn.Checked = True Then ' Leave Btn
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollLongLeaves.rpt"
            If L_Type.Text = "All" Then ' All Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'   "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'"
                    End If

                End If
            ElseIf L_Type.Text = "Casual" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "Sick" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "M1" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "M2" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "Special" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If


            ElseIf L_Type.Text = "Annual" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "Factory Duty" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "OTAL" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "Suspended" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "Compensatory" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            ElseIf L_Type.Text = "Absent" Then ' casual Leave 

                If RadioByDate.Checked = True Then ' By date 
                    Flag = False
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "'  And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By Card Number
                    If AllEMp.Checked = True Then ' By Emp
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If

                    ElseIf ByDept.Checked = True Then ' main Dept
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                        'Filter =  EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        If frmcardtxt.Text.Length = 0 Then
                            Flag = True

                        Else
                            Flag = False
                        End If
                        If Tocardtxt.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                        End If
                    End If

                ElseIf Specialbtn.Checked = True Then
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "


                ElseIf BrnchBtn.Checked = True Then ' By Branch 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If AllEMp.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf ByDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "'  "
                    ElseIf Desig.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod} = '" & FinancialPeriodComboBox.Text & "' And {View_Rpt_PayRoll_LongLeaveSum.leaveType}='" & L_Type.Text & "' "
                    End If

                End If
            End If
        End If




        'If RadioButton30.Checked = True Then ' Annual Record
        '    Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollLongLeavesErrorFP.rpt"
        '    Flag = False
        '    If AllEMp.Checked = True Then ' By Emp
        '        Filter = "{View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod}='" & Me.FinancialPeriodComboBox.Text & "' and {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Annual'"
        '    ElseIf ByDept.Checked = True Then ' main Dept
        '        Filter = "{View_Rpt_PayRoll_EmpInfo.DeptID}=" & DeptNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod}='" & Me.FinancialPeriodComboBox.Text & "' and {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Annual' "
        '    ElseIf Section.Checked = True Then ' Section Wise
        '        Filter = "{View_Rpt_PayRoll_EmpInfo.DeptID}=" & DeptNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_EmpInfo.SectionID}=" & NameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod}='" & Me.FinancialPeriodComboBox.Text & "' and {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Annual'"
        '    ElseIf Desig.Checked = True Then ' Desig Wise
        '        Filter = "{View_Rpt_PayRoll_EmpInfo.DesigID}=" & DesigNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.FinancialPeriod}='" & Me.FinancialPeriodComboBox.Text & "' and {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Annual'"
        '    End If
        'End If



        'If RadioButton9.Checked = True Then ' Monthlly REcord for Annual Leave 
        '    Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollLongLeavesError.rpt"
        '    Flag = False
        '    If AllEMp.Checked = True Then ' By Emp
        '        Filter = "{View_Rpt_PayRoll_LongLeaveSum.LeaveYear} = " & StrtTime.Value.Year & " and {View_Rpt_PayRoll_LongLeaveSum.LeaveMonth} = " & StrtTime.Value.Month & " and {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Annual'"
        '    ElseIf ByDept.Checked = True Then ' main Dept
        '        Filter = "{View_Rpt_PayRoll_EmpInfo.DeptID}=" & DeptNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.LeaveYear} = " & StrtTime.Value.Year & " and {View_Rpt_PayRoll_LongLeaveSum.LeaveMonth} = " & StrtTime.Value.Month & " and {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Annual'"
        '    ElseIf Section.Checked = True Then ' Section Wise
        '        Filter = "{View_Rpt_PayRoll_EmpInfo.DeptID}=" & DeptNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_EmpInfo.SectionID}=" & NameComboBox.SelectedValue & " And {View_Rpt_PayRoll_LongLeaveSum.LeaveYear} = " & StrtTime.Value.Year & " and {View_Rpt_PayRoll_LongLeaveSum.LeaveMonth} = " & StrtTime.Value.Month & " and {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Annual'"
        '    ElseIf Desig.Checked = True Then ' Desig Wise
        '        Filter = "{View_Rpt_PayRoll_EmpInfo.DesigID}=" & DesigNameComboBox.SelectedValue & " And  {View_Rpt_PayRoll_LongLeaveSum.LeaveYear} = " & StrtTime.Value.Year & " and {View_Rpt_PayRoll_LongLeaveSum.LeaveMonth} = " & StrtTime.Value.Month & " and {View_Rpt_PayRoll_LongLeaveSum.LeaveType} = 'Annual'"
        '    End If
        'End If

        'If RadioButton31.Checked = True Then '' paid Annual leave 
        '    Path = "" & frmLogin.ReportsPath & "\PayRoll\rptpaidAnnualLeavesFP.rpt"
        '    Flag = False
        '    If AllEMp.Checked = True Then ' By Emp
        '        Filter = "{View_Rpt_Acc_ActiveAnnualLeaves.FinancialPeriod}='" & Me.FinancialPeriodComboBox.Text & "'"
        '    ElseIf ByDept.Checked = True Then ' main Dept
        '        Filter = "{View_Rpt_Acc_PreSalary.DeptID}=" & Me.DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveAnnualLeaves.FinancialPeriod}='" & Me.FinancialPeriodComboBox.Text & "'"
        '    ElseIf Section.Checked = True Then ' Section Wise
        '        Filter = "{View_Rpt_Acc_PreSalary.SubDept1ID}=" & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID}=" & Me.DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveAnnualLeaves.FinancialPeriod}='" & Me.FinancialPeriodComboBox.Text & "'"
        '    ElseIf Desig.Checked = True Then ' Desig Wise
        '        Filter = "{View_Rpt_Acc_PreSalary.DesignationID}=" & DesigNameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveAnnualLeaves.FinancialPeriod}='" & Me.FinancialPeriodComboBox.Text & "'"
        '    End If
        'End If




        If RadioButton32.Checked = True Then  '' Monthly paid Annual Leave
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptpaidAnnualLeaves.rpt"
            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {@Year}=" & Me.StrtTime.Value.Year & "And {@Month}=" & Me.StrtTime.Value.Month & ""
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID}=" & Me.DeptNameComboBox.SelectedValue & " And {@Year}=" & Me.StrtTime.Value.Year & "And {@Month}=" & Me.StrtTime.Value.Month & ""
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.SubDept1ID}=" & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID}=" & Me.DeptNameComboBox.SelectedValue & " And {@Year}=" & Me.StrtTime.Value.Year & "And {@Month}=" & Me.StrtTime.Value.Month & ""
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID}=" & DesigNameComboBox.SelectedValue & " And  {@Year}=" & Me.StrtTime.Value.Year & "And {@Month}=" & Me.StrtTime.Value.Month & ""
                End If
            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {@Year}=" & Me.StrtTime.Value.Year & "And {@Month}=" & Me.StrtTime.Value.Month & " And {View_Rpt_Acc_PreSalary.BranchID}=" & Me.BranchNameComboBox.SelectedValue & " "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID}=" & Me.DeptNameComboBox.SelectedValue & " And {@Year}=" & Me.StrtTime.Value.Year & "And {@Month}=" & Me.StrtTime.Value.Month & " And {View_Rpt_Acc_PreSalary.BranchID}=" & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.SubDept1ID}=" & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptID}=" & Me.DeptNameComboBox.SelectedValue & " And {@Year}=" & Me.StrtTime.Value.Year & "And {@Month}=" & Me.StrtTime.Value.Month & " And {View_Rpt_Acc_PreSalary.BranchID}=" & Me.BranchNameComboBox.SelectedValue & ""
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesignationID}=" & DesigNameComboBox.SelectedValue & " And  {@Year}=" & Me.StrtTime.Value.Year & "And {@Month}=" & Me.StrtTime.Value.Month & " And {View_Rpt_Acc_PreSalary.BranchID}=" & Me.BranchNameComboBox.SelectedValue & ""
                End If
            End If

        End If



        If ShtleavBtn.Checked = True Then ' Short leave 
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptDailyShortleave.rpt"
            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = "{View_Att_DayGroup.LeaveDate}  In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_HR_Info.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate}  In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#  "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_HR_Info.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_HR_Info.Subdept1} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate}  In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_HR_Info.desigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate}  In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                End If
            ElseIf RadioDateCard.Checked = True Then ' By Card Number
                If AllEMp.Checked = True Then ' By Emp
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And{View_Att_DayGroup.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Att_DayGroup.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                    End If

                ElseIf ByDept.Checked = True Then ' main Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_Rpt_HR_Info.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Att_DayGroup.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                    Else

                        Filter = "{View_Rpt_HR_Info.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                    End If
                    'Filter = " {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_Rpt_HR_Info.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_HR_Info.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                    Else

                        Filter = "{View_Rpt_HR_Info.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_HR_Info.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                    End If
                    'Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_Rpt_HR_Info.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Att_DayGroup.LeaveDate}In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                    Else

                        Filter = "{View_Rpt_HR_Info.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                    End If
                End If

            ElseIf Specialbtn.Checked = True Then
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = "({View_Rpt_HR_Info.CardNo}  in [" & Str & "]) And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "


            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = "{View_Rpt_HR_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_HR_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_HR_Info.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_HR_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_HR_Info.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_HR_Info.Subdept1} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_HR_Info.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_HR_Info.desigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = "{View_Rpt_HR_Info.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_HR_Info.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_HR_Info.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_HR_Info.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_HR_Info.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_HR_Info.Subdept1} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_HR_Info.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_HR_Info.desigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.LeaveDate} In #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "# To #" & Format(Me.EndTime.Value, "MM/dd/yyyy") & "# "
                End If

            End If
        End If

        If RadioButton18.Checked = True Then ' Monthlly Emp Report
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptEmpRecord(MonthWise).rpt"
            Param = "Month=" & StrtTime.Value.Month & "&Year=" & StrtTime.Value.Year & ""
            If RadioDateCard.Checked = True Then ' card 

                If AllEMp.Checked = True Then
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & ""

                    Else

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "

                    End If
                ElseIf ByDept.Checked = True Then ' Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If frmcardtxt.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & ""

                    Else

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "

                    End If
                ElseIf Section.Checked = True Then ' Section
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If frmcardtxt.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & ""

                    Else

                        Filter = EmpStatus & " And   {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "

                    End If
                ElseIf Desig.Checked = True Then ' Desig+ CardNo
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If frmcardtxt.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "

                    Else


                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & ""

                    End If
                End If
            ElseIf ByShift.Checked = True Then ' by Shift
                Flag = False
                Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
                If AllEMp.Checked = True Then
                    Flag = False ' Shift + late Commers 
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.ShiftID} = " & ShiftNameComboBox.SelectedValue & " "
                ElseIf ByDept.Checked = True Then ' Shift + Dept
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' "
                ElseIf Section.Checked = True Then ' Shift + Section
                    Filter = EmpStatus & " And   {View_Rpt_PayRoll_EmpInfo.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Sectionname} = '" & NameComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' shift+ Desig
                    Filter = EmpStatus & " And  { {View_Rpt_PayRoll_EmpInfo.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' "

                End If
            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' All 

                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf ByDept.Checked = True Then ' Dept
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And   {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' "
                ElseIf Section.Checked = True Then ' Section
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And    {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Sectionname} = '" & NameComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' Desig
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And    {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' "
                End If
            End If
        End If

        If EmpAnual.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptEmpRecord.rpt"
            Param = "FP=" & Me.FinancialPeriodComboBox.Text & ""
            If RadioDateCard.Checked = True Then '' card range
                If AllEMp.Checked = True Then
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then
                        Filter = "   {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "
                    Else
                        Filter = " {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If
                ElseIf ByDept.Checked = True Then  ' Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then
                        Filter = "{View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & ""
                    Else
                        Filter = "{View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "

                    End If
                ElseIf Section.Checked = True Then  ' Section
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then
                        Filter = " {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & ""
                    Else
                        Filter = "  {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If
                ElseIf Desig.Checked = True Then ' Desig+ CardNo
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then
                        Filter = "  {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "
                    Else
                        Filter = "  {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "

                    End If
                End If
            ElseIf BrnchBtn.Checked = True Then ' By Branch
                Flag = False
                If AllEMp.Checked = True Then
                    Filter = "  {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf ByDept.Checked = True Then  ' Dept
                    Filter = "{View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf Section.Checked = True Then  ' Section
                    Filter = "  {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_EmpInfo.SubDept1} = '" & NameComboBox.Text & "' "

                ElseIf Desig.Checked = True Then ' Desig+ CardNo
                    Filter = "  {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_EmpInfo.DesigName} = '" & DesigNameComboBox.Text & "' "

                End If

            End If
        End If
        If RadioButton2.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollCompensatoryLeave.rpt"
            If ActiveBtn.Checked Then

            End If
            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "'  "
                End If
            ElseIf RadioDateCard.Checked = True Then ' By Card Number
                If AllEMp.Checked = True Then ' By Emp
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & "  "
                    Else

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If

                ElseIf ByDept.Checked = True Then ' main Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & ""
                    Else

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If
                    'Filter = " {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "
                    Else

                        Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.subdept1} = '" & NameComboBox.Text & "' And  {View_Rpt_HR_Info.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If
                    'Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "
                    Else

                        Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_PayRoll_EmpInfo.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If
                End If

            ElseIf Specialbtn.Checked = True Then
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And  ({View_Rpt_PayRoll_EmpInfo.CardNo}  in [" & Str & "]) "


            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "' "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' "
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.DeptName} ='" & DeptNameComboBox.Text & "'"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And   {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpInfo.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpInfo.Subdept1} = '" & NameComboBox.Text & "'"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And  {View_Rpt_PayRoll_EmpInfo.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpInfo.desigName} = '" & DesigNameComboBox.Text & "' "
                End If

            End If
        End If

        If RadioButton3.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptPayRollLeavesSumry4Audit.rpt"

            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                End If
            ElseIf RadioDateCard.Checked = True Then ' By Card Number
                If AllEMp.Checked = True Then ' By Emp
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Leave_Sum.FinancialPeriod}{View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' "
                    End If

                ElseIf ByDept.Checked = True Then ' main Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' "
                    End If
                    'Filter = " {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' "
                    End If
                    'Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                    Else

                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                    End If
                End If

            ElseIf Specialbtn.Checked = True Then
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"


            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Leave_Sum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "'"
                End If

            End If
        End If


        If RadioButton1.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccEmpGoingonLeaves.rpt"

            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = "{View_Rpt_Acc_PreSalary.Empstatus}= True And {@Mon} =" & StrtTime.Value.Month & " and {@Allegible} > 0.00 "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "'  And {@Mon} =" & StrtTime.Value.Month & " and {@Allegible} > 0.00 "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {@Mon} =" & StrtTime.Value.Month & "and {@Allegible} > 0.00  "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "'  And {@Mon} =" & StrtTime.Value.Month & "and {@Allegible} > 0.00  "
                End If
            ElseIf RadioDateCard.Checked = True Then ' By Card Number
                If AllEMp.Checked = True Then ' By Emp
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "
                    Else

                        Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If

                ElseIf ByDept.Checked = True Then ' main Dept
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "
                    Else

                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If
                    'Filter = " {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "
                    Else

                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If
                    'Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Desig.Checked = True Then ' Desig Wise
                    If frmcardtxt.Text.Length = 0 Then
                        Flag = True

                    Else
                        Flag = False
                    End If
                    If Tocardtxt.Text = "" Then

                        Filter = "{View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & frmcardtxt.Text & " "
                    Else

                        Filter = "{View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & frmcardtxt.Text & " To " & Tocardtxt.Text & " "
                    End If
                End If

            ElseIf Specialbtn.Checked = True Then
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = "({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) "


            ElseIf BrnchBtn.Checked = True Then ' By Branch 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' "
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If AllEMp.Checked = True Then ' By Emp
                    Filter = "{View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " "
                ElseIf ByDept.Checked = True Then ' main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' "
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = " {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' "
                ElseIf Desig.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' "
                End If

            End If
            Param = "MyDate=" & StrtTime.Value.Date & ""

        End If





        If RadioButton6.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptLeavesSummary.rpt"




            Param = "@FromDate=" & StrtTime.Value.Date & "&@ToDate=" & EndTime.Value.Date & ""
            If RadioByDate.Checked = True Then ' By date 

                If AllEMp.Checked = True Then ' By Emp
                    Flag = False

                ElseIf ByDept.Checked = True Then ' main Dept
                    Flag = False
                    Filter = "{DeptLeavesDetail;1.deptname} ='" & DeptNameComboBox.Text & "'"
                End If
            Else ByShift.Checked = True
                If AllEMp.Checked = True Then ' By Emp
                    Flag = False

                    Filter = "{DeptLeavesDetail;1.Shiftid} =" & ShiftNameComboBox.SelectedValue & ""
                ElseIf ByDept.Checked = True Then ' main Dept
                    Flag = False
                    Filter = "{DeptLeavesDetail;1.deptname} ='" & DeptNameComboBox.Text & "' And {DeptLeavesDetail;1.Shiftid} =" & ShiftNameComboBox.SelectedValue & ""
                End If
            End If


        End If
        If RadioButton9.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptMonthLeaveSummary.rpt"
            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                Filter = "{View_Emp_MonthLeaveData.LeaveMonth} in DateTime (" & StrtTime.Value.Year & ", " & StrtTime.Value.Month & ", 01, 00, 00, 00) to DateTime (" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", 01, 00, 00, 00)"

            End If
        End If
        If RadioButton11.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\Rpt_PayRoll_Info.rpt"
            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                Filter = "{View_Payroll_Information.SalaryMonth} = #" & Format(Me.StrtTime.Value, "MM/dd/yyyy") & "#"

            End If
        End If
        If RadioButton12.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\Rpt_Monthly_leave.rpt"
            If RadioByDate.Checked = True Then ' By date 
                Flag = False
                Filter = "{tbl_PayRoll_LongLeaves_Manual.LeaveMonth} In #" & Format(Me.StrtTime.Value, "dd/MM/yyyy") & "# To #" & Format(Me.EndTime.Value, "dd/MM/yyyy") & "# "

            End If
        End If

        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Flag = False
            Obj.LoadDateWiseReports(Path, Filter, Param)
        End If

    End Sub
    Private Flag As Boolean = False

    Private Sub SelectFP()
        'Here Obj.ReturnFP() function is a utility function that returns financial period by providing Year and Month
        Dim Obj As New UtilityClass()
        If Obj.ReturnFP(StrtTime.Value.Month, StrtTime.Value.Year) <> Nothing Then
            FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(StrtTime.Value.Month, StrtTime.Value.Year)
        Else
            MsgBox("Selected year was beyond the running financial period")
            StrtTime.Value = Now.Date
        End If
    End Sub

    Private Sub frmLeavesPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_Comp_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSPayRoll.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Branches' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_BranchesTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Branches)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_PayRoll_Shifts' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_PayRoll_ShiftsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_PayRoll_Shifts)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Emp_Info_H1' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Emp_Info_H1)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_SubDept1' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Departments' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Emp_Info_H1' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Emp_Info_H1)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Branches' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_BranchesTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Branches)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_PayRoll_Shifts' table. You can move, or remove it, as needed.
        Me.Tbl_PayRoll_ShiftsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_PayRoll_Shifts)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_SubDept1' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Departments' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)
        Try
            SelectFP()
        Catch ex As Exception

        End Try
        If (Me.Tbl_Comp_InfoTableAdapter.FillBy(Me.DSUser.tbl_Comp_Info)) > 0 Then
            'L_Type.Items.Add("All")
            L_Type.Items.Add("Absent")
            L_Type.Items.Add("Annual")
            L_Type.Items.Add("Casual")
            L_Type.Items.Add("Factory Duty")
            L_Type.Items.Add("M1")
            L_Type.Items.Add("M2")
            L_Type.Items.Add("Sick")
            L_Type.Items.Add("Suspended")
            L_Type.Items.Add("Rest Day")
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton6.Visible = False
            RadioButton7.Visible = False
        Else
            L_Type.Items.Add("All")
            L_Type.Items.Add("Absent")
            L_Type.Items.Add("Annual")
            L_Type.Items.Add("Casual")
            L_Type.Items.Add("Factory Duty")
            L_Type.Items.Add("M1")
            L_Type.Items.Add("M2")
            L_Type.Items.Add("Sick")
            L_Type.Items.Add("Suspended")
            L_Type.Items.Add("Compensatory")
            L_Type.Items.Add("OTAL")
            L_Type.Items.Add("Special")
            RadioButton2.Visible = True
            RadioButton3.Visible = True
            RadioButton6.Visible = True
            RadioButton7.Visible = True
        End If
    End Sub



    Private Sub ShtleavBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ShtleavBtn.CheckedChanged
        If ShtleavBtn.Checked = True Then
            Specialbtn.Enabled = False
            FinancialPeriodComboBox.Enabled = False
            GroupBox5.Enabled = False
        Else
            Specialbtn.Enabled = True
            FinancialPeriodComboBox.Enabled = True
            GroupBox5.Enabled = True
        End If
        GroupBox1.Enabled = True
    End Sub

    Private Sub RadioByDate_CheckedChanged(sender As Object, e As EventArgs) Handles RadioByDate.CheckedChanged
        AllEMp.Checked = True

    End Sub

    Private Sub LeavBtn_CheckedChanged(sender As Object, e As EventArgs) Handles LeavBtn.CheckedChanged
        If LeavBtn.Checked = True Then
            L_Type.Enabled = True
        Else
            L_Type.Enabled = False

        End If
        RadioByDate.Checked = True
        GroupBox1.Enabled = True
    End Sub

    Private Sub RadioDateCard_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDateCard.CheckedChanged
        If RadioDateCard.Checked = True Then
            frmcardtxt.Enabled = True
            Tocardtxt.Enabled = True
            AllEMp.Checked = True
        Else
            frmcardtxt.Enabled = False
            Tocardtxt.Enabled = False
        End If
    End Sub

    Private Sub Specialbtn_CheckedChanged(sender As Object, e As EventArgs) Handles Specialbtn.CheckedChanged

        Me.AcceptButton = btnAdd

        If Specialbtn.Checked = True Then
            SpecialFilterBox.Enabled = True
            DeptPanel.Enabled = False
            AllEMp.Checked = True
        Else
            SpecialFilterBox.Enabled = False
            DeptPanel.Enabled = True

        End If
    End Sub

    Private Sub BrnchBtn_CheckedChanged(sender As Object, e As EventArgs) Handles BrnchBtn.CheckedChanged
        If BrnchBtn.Checked = True Then
            BranchNameComboBox.Enabled = True
            AllEMp.Checked = True
        Else
            BranchNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub ByShift_CheckedChanged(sender As Object, e As EventArgs) Handles ByShift.CheckedChanged
        If ByShift.Checked = True Then
            ShiftNameComboBox.Enabled = True
            AllEMp.Checked = True
        Else
            ShiftNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub ByDept_CheckedChanged(sender As Object, e As EventArgs) Handles ByDept.CheckedChanged
        If ByDept.Checked = True Then
            DeptNameComboBox.Enabled = True
        Else
            DeptNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub Section_CheckedChanged(sender As Object, e As EventArgs) Handles Section.CheckedChanged
        If Section.Checked = True Then
            DeptNameComboBox.Enabled = True
            NameComboBox.Enabled = True
        Else
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False
        End If
    End Sub

    Private Sub Desig_CheckedChanged(sender As Object, e As EventArgs) Handles Desig.CheckedChanged
        If Desig.Checked = True Then
            DesigNameComboBox.Enabled = True
        Else
            DesigNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            If lstCards.Items.Count < 100 Then
                lstCards.Items.Add(cmbSelectCard.SelectedValue)
                lstCards.SelectedIndex = lstCards.Items.Count - 1
                cmbSelectCard.Text = ""
                cmbSelectCard.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstCards.Items.Count > 0 Then
            If lstCards.SelectedIndex >= 0 Then
                lstCards.Items.RemoveAt(lstCards.SelectedIndex)
                lstCards.SelectedIndex = lstCards.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        filterByMonth()
        GroupBox1.Enabled = True
        If RadioButton18.Checked = True Then
            RadioDateCard.Text = "By Month"
        Else
            RadioDateCard.Text = "By Card Range"
        End If
    End Sub
    Private Sub filterByMonth()
        If RadioButton18.Checked = True Or RadioButton32.Checked = True Then
            StrtTime.CustomFormat = "MMM.yyyy"
            Label1.Text = "Select Month "
            StrtTime.Enabled = True
            EndTime.Enabled = False
            FinancialPeriodComboBox.Enabled = False
            RadioByDate.Enabled = False
            Specialbtn.Enabled = False
            RadioDateCard.Checked = True
        Else
            EndTime.Enabled = True
            StrtTime.CustomFormat = "dd/MM/yyyy"
            Label1.Text = "From Date: "
            FinancialPeriodComboBox.Enabled = True
            RadioByDate.Enabled = True
            Specialbtn.Enabled = True
            RadioByDate.Checked = False
        End If
    End Sub

    Private Sub EmpAnual_CheckedChanged(sender As Object, e As EventArgs) Handles EmpAnual.CheckedChanged
        GroupBox1.Enabled = True
        If EmpAnual.Checked = True Then
            RadioDateCard.Checked = True
            RadioByDate.Enabled = False
            Specialbtn.Enabled = False
            BrnchBtn.Enabled = True
            ByShift.Enabled = False
            StrtTime.Enabled = False
            EndTime.Enabled = False
        Else
            RadioByDate.Checked = True
            RadioByDate.Enabled = True
            Specialbtn.Enabled = True
            BrnchBtn.Enabled = False
            ByShift.Enabled = True
            StrtTime.Enabled = True
            EndTime.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            StrtTime.CustomFormat = "MMM, yyyy"
            Label1.Text = "Select Month:"
            EndTime.Visible = True
            EndTime.Enabled = False
            GroupBox5.Enabled = False
        Else
            StrtTime.CustomFormat = "dd/MM/yyyy"
            Label1.Text = "From Date:"
            EndTime.Visible = True
            GroupBox5.Enabled = True
        End If
        GroupBox1.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            FinancialPeriodComboBox.Enabled = False
            StrtTime.Enabled = False
            EndTime.Enabled = False
            RadioByDate.Text = "All"
        Else
            FinancialPeriodComboBox.Enabled = True
            StrtTime.Enabled = True
            EndTime.Enabled = True
            RadioByDate.Text = "By Date"
        End If
        GroupBox1.Enabled = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            StrtTime.Enabled = False
            EndTime.Enabled = False
            RadioByDate.Enabled = False
            RadioDateCard.Checked = True
        Else

            RadioByDate.Enabled = True
            StrtTime.Enabled = True
            EndTime.Enabled = True
        End If
        GroupBox1.Enabled = True
    End Sub

    Private Sub DetlLeavRcd_CheckedChanged(sender As Object, e As EventArgs) Handles DetlLeavRcd.CheckedChanged
        If DetlLeavRcd.Checked = True Then
            StrtTime.Enabled = False
            EndTime.Enabled = False
            FinancialPeriodComboBox.Enabled = False
            RadioByDate.Text = "All"
            RadioByDate.Enabled = False
            RadioDateCard.Checked = True
        Else
            StrtTime.Enabled = True
            EndTime.Enabled = True
            FinancialPeriodComboBox.Enabled = True
            RadioByDate.Text = "By Date"
            RadioByDate.Enabled = True
        End If

        GroupBox1.Enabled = True
    End Sub

    Private Sub frmcardtxt_TextChanged(sender As Object, e As EventArgs) Handles frmcardtxt.TextChanged

    End Sub

    Private Sub frmcardtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles frmcardtxt.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Tocardtxt_TextChanged(sender As Object, e As EventArgs) Handles Tocardtxt.TextChanged

    End Sub

    Private Sub Tocardtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tocardtxt.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs)
        GroupBox1.Enabled = False
        filterByMonth()
        RadioByDate.Checked = True
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs)
        GroupBox1.Enabled = False
        RadioByDate.Checked = True


    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs)
        RadioByDate.Checked = True
        GroupBox1.Enabled = False

    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        'GroupBox1.Enabled = False
        If RadioButton32.Checked = True Then
            StrtTime.CustomFormat = "MMM.yyyy"
            Label1.Text = "Select Month "
            StrtTime.Enabled = True
            EndTime.Enabled = False
            FinancialPeriodComboBox.Enabled = False
            Specialbtn.Enabled = False
            RadioDateCard.Checked = True
            RadioByDate.Enabled = True
            RadioDateCard.Enabled = False
            Specialbtn.Enabled = False
            BrnchBtn.Enabled = True
            ByShift.Enabled = False
        Else
            EndTime.Enabled = True
            StrtTime.CustomFormat = "dd/MM/yyyy"
            Label1.Text = "From Date: "
            FinancialPeriodComboBox.Enabled = True
            RadioByDate.Enabled = True
            Specialbtn.Enabled = True
            BrnchBtn.Enabled = True
            ByShift.Enabled = True
            RadioDateCard.Enabled = True
        End If
        'filterByMonth()
        RadioByDate.Checked = True
    End Sub

    Private Sub DeptPanel_Paint(sender As Object, e As PaintEventArgs) Handles DeptPanel.Paint

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        'If RadioButton5.Checked = True Then
        '    L_Type.Enabled = False
        'Else
        '    L_Type.Enabled = True

        'End If
        'GroupBox1.Enabled = True
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            RadioDateCard.Enabled = False
            Specialbtn.Enabled = False
            BrnchBtn.Enabled = False
            ByShift.Enabled = True
            Section.Enabled = False
            Desig.Enabled = False
            GroupBox5.Enabled = False
            FinancialPeriodComboBox.Enabled = False
        Else

            FinancialPeriodComboBox.Enabled = True
            GroupBox5.Enabled = True
            RadioDateCard.Enabled = True
            Specialbtn.Enabled = True
            BrnchBtn.Enabled = True
            ByShift.Enabled = False
            Section.Enabled = True
            Desig.Enabled = True
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            GroupBox5.Enabled = True
            FinancialPeriodComboBox.Enabled = False
        Else
            GroupBox5.Enabled = False
            FinancialPeriodComboBox.Enabled = True
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        'GroupBox1.Enabled = False
        If RadioButton8.Checked = True Then
            'StrtTime.CustomFormat = "MMM.yyyy"
            'Label1.Text = "Select Month "
            StrtTime.Enabled = True
            EndTime.Enabled = True
            FinancialPeriodComboBox.Enabled = False
            Specialbtn.Enabled = False
            RadioDateCard.Checked = True
            RadioByDate.Enabled = True
            RadioDateCard.Enabled = False
            Specialbtn.Enabled = False
            BrnchBtn.Enabled = False
            ByShift.Enabled = False

        Else
            EndTime.Enabled = False
            StrtTime.Enabled = False
            'StrtTime.CustomFormat = "dd/MM/yyyy"
            'Label1.Text = "From Date: "
            FinancialPeriodComboBox.Enabled = True
            RadioByDate.Enabled = True
            Specialbtn.Enabled = True
            BrnchBtn.Enabled = True
            ByShift.Enabled = True
            RadioDateCard.Enabled = True
        End If
        'filterByMonth()
        RadioByDate.Checked = True
    End Sub

    Private Sub RadioButton9_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            RadioDateCard.Enabled = False
            RadioByDate.Enabled = True
            Specialbtn.Enabled = False
            BrnchBtn.Enabled = False
            ByShift.Enabled = False
            DeptPanel.Enabled = False
        Else
            RadioDateCard.Enabled = True
            RadioByDate.Enabled = False
            Specialbtn.Enabled = True
            BrnchBtn.Enabled = True
            ByShift.Enabled = True
            DeptPanel.Enabled = True
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            Specialbtn.Enabled = False
            BrnchBtn.Enabled = False
            ByShift.Enabled = False
            RadioByDate.Enabled = True
            RadioDateCard.Enabled = True
        Else
            RadioByDate.Enabled = True
            RadioDateCard.Enabled = True
            Specialbtn.Enabled = True
            BrnchBtn.Enabled = True
            ByShift.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            StrtTime.CustomFormat = "MMM, yyyy"
            Label1.Text = "Select Month:"
            EndTime.Visible = True
            EndTime.Enabled = False
            GroupBox5.Enabled = False
        Else
            StrtTime.CustomFormat = "dd/MM/yyyy"
            Label1.Text = "From Date:"
            EndTime.Visible = True
            GroupBox5.Enabled = True
        End If
    End Sub
End Class