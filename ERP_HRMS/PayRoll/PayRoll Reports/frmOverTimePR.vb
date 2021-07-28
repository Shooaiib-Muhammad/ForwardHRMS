Public Class frmOverTimePR
    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioTravel.CheckedChanged
        RadioButton4.Enabled = True
        GroupBox5.Enabled = True

        RadioByDate.Checked = True
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDateCard.CheckedChanged
        CatagoryNameComboBox.Enabled = False

        If RadioDateCard.Checked = True Then
            Frmcard.Enabled = True
            tocard.Enabled = True
            RadioDeptAll.Checked = True
        Else
            Frmcard.Enabled = False
            tocard.Enabled = False
        End If
    End Sub

    Private Sub Radio_OT_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_OT.CheckedChanged
        RadioButton4.Enabled = True
        RadioByDate.Checked = True
        GroupBox5.Enabled = True
        If Radio_OT.Checked = True Then

            OT_Type.Enabled = True
        Else

            OT_Type.Enabled = False

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Param As String = ""
        Dim Path As String = ""
        Dim Obj As New UtilityClass
        Dim EmpStatus As String


        If Radio_OT.Checked = True Or RadioDTA.Checked = True Or RadioTravel.Checked = True Or Radio_Meal.Checked = True Or RadioButton5.Checked = True Or PndStatus.Checked = True Or NormalExtraSpecial.Checked = True Or PTPaymentDetails.Checked = True Or RadioButton8.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.empstatus} = True "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.empstatus} = false "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.cardno} > 0 "
            End If
        End If

        If RadioButton6.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.empstatus} = true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.empstatus} = false "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.cardno} > 0 "
            End If
        End If

        If RadioButton1.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_OT_Management_Final.empstatus} = true "
            ElseIf NonActiveBtn.Checked = True Then
                EmpStatus = "{View_OT_Management_Final.empstatus} = false "
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_OT_Management_Final.cardno} > 0 "
            End If
        End If


        If Radio_OT.Checked = True Then ' OT Rpt
            If OT_Type.Text = "Over Time" Then ' Normal
                Path = "" & frmLogin.ReportsPath & "\PayRoll\rptNormlOT.rpt"
                If RadioByDate.Checked = True Then 'by Date
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Em
                        Filter = EmpStatus & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dep
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioDateCard.Checked = True ' By date and card No 
                    If RadioDeptAll.Checked = True Then ' By Emp
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If

                    ElseIf MainDept.Checked = True Then ' main Dept
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                    ElseIf Section.Checked = True Then ' Section Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                    ElseIf DesigBTn.Checked = True ' Desig Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    End If
                ElseIf RadioSpecial.Checked = True Then ' By Special FIlter 
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


                ElseIf ByBranch.Checked = True Then '  then By Branch 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dep
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton4.Checked = True Then   ' By category


                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If



            ElseIf OT_Type.Text = "Extra" Then '' Extra Report 
                Path = "" & frmLogin.ReportsPath & "\PayRoll\rptextraOT.rpt"
                If RadioByDate.Checked = True Then 'by Date
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioDateCard.Checked = True ' By date and card No 
                    If RadioDeptAll.Checked = True Then ' By Emp
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If

                    ElseIf MainDept.Checked = True Then ' main Dept
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True ' Desig Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    End If
                ElseIf RadioSpecial.Checked = True Then ' By Special FIlter 
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


                ElseIf ByBranch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton4.Checked = True Then   ' By category


                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If


            ElseIf OT_Type.Text = "Special" Then
                Path = "" & frmLogin.ReportsPath & "\PayRoll\rptspecialOT.rpt"
                If RadioByDate.Checked = True Then 'by Date
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By date and card No 
                    If RadioDeptAll.Checked = True Then ' By Emp
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If

                    ElseIf MainDept.Checked = True Then ' main Dept
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True ' Desig Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    End If
                ElseIf RadioSpecial.Checked = True Then  ' By Special FIlter 
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


                ElseIf ByBranch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf RadioButton4.Checked = True Then   ' By category


                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID} = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If


        End If



        If RadioButton8.Checked = True Then ' Overtim Details 
            If OT_Type.Text = "Over Time" Then ' Normal
                Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccOverTimeDatewise.rpt"
                If RadioByDate.Checked = True Then 'by Date
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioDateCard.Checked = True ' By date and card No 
                    If RadioDeptAll.Checked = True Then ' By Emp
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If

                    ElseIf MainDept.Checked = True Then ' main Dept
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True ' Desig Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    End If
                ElseIf RadioSpecial.Checked = True Then ' By Special FIlter 
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


                ElseIf ByBranch.Checked = True Then '  then By Branch 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton4.Checked = True Then ' By category
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                End If
            ElseIf OT_Type.Text = "Extra" Then
                Path = "" & frmLogin.ReportsPath & "\PayRoll\OverAllPerCalOT.rpt"
                If RadioByDate.Checked = True Then 'by Date
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioDateCard.Checked = True ' By date and card No 
                    If RadioDeptAll.Checked = True Then ' By Emp
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If

                    ElseIf MainDept.Checked = True Then ' main Dept
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True ' Desig Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    End If
                ElseIf RadioSpecial.Checked = True Then ' By Special FIlter 
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


                ElseIf ByBranch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                    End If
                ElseIf RadioButton4.Checked = True Then ' By category
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SubDept1} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf OT_Type.Text = "Special" Then
                Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccOverTimeDatewiseSpecial.rpt"
                If RadioByDate.Checked = True Then 'by Date
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioDateCard.Checked = True Then ' By date and card No 
                    If RadioDeptAll.Checked = True Then ' By Emp
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If

                    ElseIf MainDept.Checked = True Then ' main Dept
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                        'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True ' Desig Wise
                        If Frmcard.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If tocard.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    End If
                ElseIf RadioSpecial.Checked = True Then  ' By Special FIlter 
                    Flag = False
                    Dim Str As String = ""
                    For i As Integer = 0 To lstCards.Items.Count - 1
                        If i = 0 Then
                            Str = Str & lstCards.Items.Item(i).ToString
                        Else
                            Str = Str & ", " & lstCards.Items.Item(i).ToString()
                        End If
                    Next
                    Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


                ElseIf ByBranch.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf ByShift.Checked = True Then ' By Shift 
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf RadioButton4.Checked = True Then ' By category
                    Flag = False
                    If RadioDeptAll.Checked = True Then ' By Emp
                        Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf MainDept.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf Section.Checked = True Then ' Section Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf DesigBTn.Checked = True Then ' Desig Wise
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If

            End If
        End If





        If RadioButton2.Checked = True Then ' Pending overtime Status 
            Path = "" & frmLogin.ReportsPath & "\PayRoll\PendingOT.rpt"
            If RadioByDate.Checked = True Then ' by Date
                If RadioDeptAll.Checked = True Then ' All EMp
                    Flag = False
                    Filter = " {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True 'mani Dept
                    Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True ' Section Wise
                    Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True '  Deig Wise 
                    Filter = "{View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioDateCard.Checked = True 'by card 
                If RadioDeptAll.Checked = True Then ' ALl Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf MainDept.Checked = True ' Main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf Section.Checked = True ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DesigBTn.Checked = True ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = "{View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then ' Special Filter
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = " ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And  {View_Att_DayGroup.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"


            ElseIf ByShift.Checked = True ' by Shift
                'Filter = Empstatus & " And {View_Rpt_Acc_PreSalary.ETID} = " & EmploymentNameComboBox.SelectedValue & " And {View_Att_DayGroup.ShiftID} = " & ShiftNameComboBox.SelectedValue & ""
                If RadioDeptAll.Checked = True Then ' All Emp
                    Flag = False
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True ' Main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True ' Desig Wise
                    Filter = " {View_Rpt_Acc_PreSalary.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                If RadioDeptAll.Checked = True Then ' All Emp
                    Flag = False
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True ' Main Dept
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True ' Desig Wise
                    Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "

                End If
            ElseIf RadioButton4.Checked = True Then ' By category 
                If RadioDeptAll.Checked = True Then ' All EMp
                    Flag = False
                    Filter = " {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True 'mani Dept
                    Filter = "{View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True ' Section Wise
                    Filter = "{View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True '  Deig Wise 
                    Filter = "{View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If




        If NormalExtraSpecial.Checked = True Then ' AllCalculation 
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptNESOT.rpt"
            If RadioByDate.Checked = True Then ' by Date
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioDateCard.Checked = True Then ' by card
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In '" & Frmcard.Text & "' To '" & Frmcard.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In '" & Frmcard.Text & "' To '" & tocard.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If


            ElseIf RadioSpecial.Checked = True Then ' By Speciall Filter
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"



            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf ByShift.Checked = True Then ' By Shift
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton4.Checked = True Then ' By Category 
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If
        End If




        If RadioDTA.Checked = True Then ' Daily Travling Rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccDTACardWise.rpt"
            Param = "FromDate=#" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "#&ToDate=#" & Format(DateTimePicker2.Value, "dd/MM/yyyy") & "#"

            If RadioByDate.Checked = True Then ' By date
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf RadioDateCard.Checked = True Then ' By card
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then  ' Special Filter
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And  {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_EmpAttRecord_DAAttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf DesigBTn.Checked = True Then ' Desig Wise

                End If
            ElseIf ByShift.Checked = True Then   ' By shiftss
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                ElseIf MainDept.Checked = True Then  '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then  ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton4.Checked = True Then ' By category 
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            End If
        End If








        If RadioTravel.Checked = True Then ' Daily Travling Allowance Summary Rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccTravelAllowenceSummery.rpt"
            Param = "FromDate=#" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "#&ToDate=#" & Format(DateTimePicker2.Value, "dd/MM/yyyy") & "#"

            If RadioByDate.Checked = True Then ' By date
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                ElseIf MainDept.Checked = True Then  '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                End If
            ElseIf RadioDateCard.Checked = True Then ' By card
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And  {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then ' Special Filter
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And  {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"


            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                End If 'd//yyyy
            ElseIf ByShift.Checked = True Then    ' By shiftss
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                End If
            ElseIf RadioButton4.Checked = True Then ' By Category 
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "  And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                ElseIf MainDept.Checked = True Then  '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} >= {?FromDate} And {View_Rpt_PayRoll_EmpAttRecord_DA.AttDate} <= {?ToDate}"
                End If
            End If
        End If




        If Radio_Meal.Checked = True Then ' Daily Meal Allowance Rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccMealAllowencePayment.rpt"
            'Param = "FromDate=#" & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "#&ToDate=#" & Format(DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year


            '{tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} And {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}
            If RadioByDate.Checked = True Then ' By date
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                End If
            ElseIf RadioDateCard.Checked = True ' By card
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                    Else
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then ' Special Filter
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And  {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"


            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                End If
            ElseIf ByShift.Checked = True Then ' By shiftss
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                End If
            ElseIf RadioButton4.Checked = True Then ' By category 
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "'  And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And {View_Rpt_Acc_PreSalary.DesigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} >= {?FromDate} and {tbl_Acc_ExtraOverTime_Transactions.OTDate} <= {?ToDate}"

                End If
            End If

        End If


        If PTPaymentDetails.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccOTReceiving4Extra.rpt"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year
            If RadioByDate.Checked = True Then 'by Date
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & "And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & "And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                End If
            ElseIf RadioDateCard.Checked = True ' By date and card No 
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                    Else

                        Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                    Else

                        Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                    End If
                    'Filter = Empstatus & " And  {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                    Else

                        Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf DesigBTn.Checked = True ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                    Else

                        Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then ' By Special FIlter 
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & "And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"


            ElseIf ByBranch.Checked = True Then ' By Branch 
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & "And  {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                End If
            ElseIf RadioButton4.Checked = True Then ' by catagory

                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & "  And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & "  And   {View_Rpt_Acc_PreSalary.EmpcatagoryID}  = " & CatagoryNameComboBox.SelectedValue & "And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} in {?FromDate} to {?ToDate}"
                End If
            End If
        End If

        'Over Al Pre caculation 




        If PndStatus.Checked = True Then


            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptOTMail.rpt"
            If RadioByDate.Checked = True Then 'by Date
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioDateCard.Checked = True Then ' By date and card No 
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then ' By Special FIlter 
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


            ElseIf ByBranch.Checked = True Then ' By Branch 
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.Branchname} = '" & BranchNameComboBox.Text & "' And  {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.Branchname}= '" & BranchNameComboBox.Text & "' and {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Rpt_Acc_PreSalary.Branchname}= '" & BranchNameComboBox.Text & "' and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5'])  And  Not({View_Rpt_Acc_PreSalary.GradeAnd {View_Rpt_Acc_PreSalary.Branchname}= '" & BranchNameComboBox.Text & "' and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf ByShift.Checked = True Then ' By Shift 
                Flag = False
                If RadioDeptAll.Checked = True Then ' By Emp
                    Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Att_DayGroup.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Att_DayGroup.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & "And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5'])  And  {View_Att_DayGroup.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And  Not({View_Rpt_Acc_PreSalary.Grade} in ['E-1', 'E-2', 'E-3', 'M-1', 'M-2', 'M-3', 'M-4', 'M-5']) And {View_Att_DayGroup.shiftID}= " & ShiftNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.desigName} = '" & DesigNameComboBox.Text & "' And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If
            End If

        End If


        If RadioButton1.Checked = True Then ''''''''Management Rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptManagerOT.rpt"
            If RadioByDate.Checked = True Then ' By date
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And  {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.SectionID} = " & NameComboBox.SelectedValue & "  And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_OT_Management_Final.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                End If
            ElseIf RadioDateCard.Checked = True Then ' By card
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_OT_Management_Final.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                    Else
                        Filter = EmpStatus & " And  {View_OT_Management_Final.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And  {View_OT_Management_Final.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                    Else

                        Filter = EmpStatus & " And {View_OT_Management_Final.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_OT_Management_Final.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.SectionID} = " & NameComboBox.SelectedValue & "   And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                    Else

                        Filter = EmpStatus & " And {View_OT_Management_Final.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.SectionID} = " & NameComboBox.SelectedValue & "   And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_OT_Management_Final.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_OT_Management_Final.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                    Else

                        Filter = EmpStatus & " And {View_OT_Management_Final.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_OT_Management_Final.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then ' Special Filter
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And  ({View_OT_Management_Final.CardNo}  in [" & Str & "]) And  {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"


            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_OT_Management_Final.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_OT_Management_Final.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_OT_Management_Final.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.SectionID} = " & NameComboBox.SelectedValue & "   And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_OT_Management_Final.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_OT_Management_Final.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                End If
            ElseIf ByShift.Checked = True Then ' By shiftss
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_OT_Management_Final.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And  {View_OT_Management_Final.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And{View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_OT_Management_Final.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_OT_Management_Final.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_OT_Management_Final.SectionID} = " & NameComboBox.SelectedValue & "   And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And  {View_OT_Management_Final.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_OT_Management_Final.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_OT_Management_Final.AttDate} IN Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") To Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")"

                End If
            End If

        End If


        If RadioButton5.Checked = True Then ' Overtime Payment Summary 
            Path = "" & frmLogin.ReportsPath & "\PayRoll\rptAccOTPaymentSummary.rpt"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year

            If RadioByDate.Checked = True Then ' By date
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & "And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & ""

                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & "And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# "

                End If
            ElseIf RadioDateCard.Checked = True ' By card
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & NameComboBox.SelectedValue & "   And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & NameComboBox.SelectedValue & "   And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_PreSalary.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.SectionName} = '" & NameComboBox.Text & "' And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then ' Special Filter
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And  ({View_Rpt_Acc_PreSalary.CardNo}  in [" & Str & "]) And  {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"


            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & NameComboBox.SelectedValue & "   And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            ElseIf ByShift.Checked = True Then ' By shiftss
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And{tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & NameComboBox.SelectedValue & "   And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {tbl_Acc_ExtraOverTime_Transactions.OTDate} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                End If
            End If
        End If





        If RadioButton6.Checked = True Then ' Overtime Per calculation 
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptNSOTHCal.rpt"

            If RadioByDate.Checked = True Then ' By date
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                    'Filter = EmpStatus & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & " And {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " "
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & "And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Extra_Special.Month}= " & DateTimePicker1.Value.Month & " And {View_Emp_Extra_Special.Year}= " & DateTimePicker1.Value.Year & " "

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & "And {View_Emp_Extra_Special.Month}= " & DateTimePicker1.Value.Month & " And {View_Emp_Extra_Special.Year}= " & DateTimePicker1.Value.Year & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & ""

                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & "And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {View_Emp_Extra_Special.Month}= " & DateTimePicker1.Value.Month & " And {View_Emp_Extra_Special.Year}= " & DateTimePicker1.Value.Year & " "

                End If
            ElseIf RadioDateCard.Checked = True ' By card
                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                    Else
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then
                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_AttListForOT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "   And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""

                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""

                    End If
                    'Filter = Empstatus & " And  {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.SectionName} = '" & NameComboBox.Text & "' And {View_Emp_Extra_Special.Month} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                    Else

                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                    End If
                End If

            ElseIf RadioSpecial.Checked = True Then ' Special Filter
                Flag = False
                Dim Str As String = ""
                For i As Integer = 0 To lstCards.Items.Count - 1
                    If i = 0 Then
                        Str = Str & lstCards.Items.Item(i).ToString
                    Else
                        Str = Str & ", " & lstCards.Items.Item(i).ToString()
                    End If
                Next
                Filter = EmpStatus & " And  ({View_Rpt_Acc_AllEmployees.CardNo}  in [" & Str & "]) And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""


            ElseIf ByBranch.Checked = True Then ' By Branch
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""

                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " and {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "   And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " and  {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""

                End If
            ElseIf ByShift.Checked = True Then ' By shiftss
                Flag = False
                If RadioDeptAll.Checked = True Then ' All EMp
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.shiftID}= " & ShiftNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""

                ElseIf MainDept.Checked = True Then '  Main Dept
                    Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "   And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.shiftID}= " & ShiftNameComboBox.SelectedValue & " and {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigNameComboBox.SelectedValue & " And  {View_Emp_Extra_Special.Year} = " & DateTimePicker1.Value.Year & " And {View_Emp_Extra_Special.Month} = " & DateTimePicker1.Value.Month & ""

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



    Private Sub Tbl_HRM_DesignationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_DesignationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)

    End Sub

    Private Sub frmOverTimePR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_Comp_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_EmpCatagory' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_EmpCatagoryTableAdapter.Fill(Me.DSHRM.tbl_HRM_EmpCatagory)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Card' table. You can move, or remove it, as needed.


        Try
            Me.Tbl_HRM_CardTableAdapter.FillBy(Me.DSPayRoll.tbl_HRM_Card)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        If (Me.Tbl_Comp_InfoTableAdapter.FillBy(Me.DSUser.tbl_Comp_Info)) > 0 Then
            OT_Type.Items.Add("Over Time")
            'OT_Type.Items.Add("Extra")
            RadioButton1.Visible = False
            PndStatus.Visible = False
            RadioButton6.Visible = False
            RadioButton2.Visible = False
            NormalExtraSpecial.Visible = False
        Else
            PndStatus.Visible = True
            OT_Type.Items.Add("Over Time")
            OT_Type.Items.Add("Extra")
            OT_Type.Items.Add("Special")
            RadioButton1.Visible = True
            RadioButton6.Visible = True
            RadioButton2.Visible = True
            NormalExtraSpecial.Visible = True
        End If
    End Sub

    Private Sub RadioSpecial_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSpecial.CheckedChanged
        Me.AcceptButton = btnAdd
        CatagoryNameComboBox.Enabled = False
        If RadioSpecial.Checked = True Then
            SpecialFilterBox.Enabled = True
            DeptPanel.Enabled = False
            RadioDeptAll.Checked = True
        Else
            SpecialFilterBox.Enabled = False
            DeptPanel.Enabled = True

        End If
    End Sub





    Private Sub RadioDeptAll_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDeptAll.CheckedChanged

    End Sub

    Private Sub ByBranch_CheckedChanged(sender As Object, e As EventArgs) Handles ByBranch.CheckedChanged
        CatagoryNameComboBox.Enabled = False

        If ByBranch.Checked = True Then
            BranchNameComboBox.Enabled = True
            RadioDeptAll.Checked = True
        Else
            BranchNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub ByShift_CheckedChanged(sender As Object, e As EventArgs) Handles ByShift.CheckedChanged
        CatagoryNameComboBox.Enabled = False

        If ByShift.Checked = True Then
            ShiftNameComboBox.Enabled = True
            RadioDeptAll.Checked = True
        Else
            ShiftNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub MainDept_CheckedChanged(sender As Object, e As EventArgs) Handles MainDept.CheckedChanged
        If MainDept.Checked = True Then
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

    Private Sub DesigBTn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBTn.CheckedChanged
        If DesigBTn.Checked = True Then
            DesigNameComboBox.Enabled = True
        Else
            DesigNameComboBox.Enabled = False
        End If
    End Sub



    Private Sub RadioByDate_CheckedChanged(sender As Object, e As EventArgs) Handles RadioByDate.CheckedChanged
        RadioDeptAll.Checked = True
        CatagoryNameComboBox.Enabled = False
    End Sub

    Private Sub PndStatus_CheckedChanged(sender As Object, e As EventArgs) Handles PndStatus.CheckedChanged
        RadioButton4.Enabled = False
        GroupBox5.Enabled = False
        RadioByDate.Checked = True
    End Sub

    Private Sub PTPaymentDetails_CheckedChanged(sender As Object, e As EventArgs) Handles PTPaymentDetails.CheckedChanged
        RadioButton4.Enabled = False
        GroupBox5.Enabled = True
        RadioByDate.Checked = True
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        RadioButton4.Enabled = True
        GroupBox5.Enabled = True
        RadioByDate.Checked = True
        If RadioButton8.Checked = True Then
            OT_Type.Enabled = True

        Else
            OT_Type.Enabled = False

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        GroupBox5.Enabled = True
        RadioButton4.Enabled = False
        RadioByDate.Checked = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        RadioByDate.Checked = True
        GroupBox5.Enabled = False

        RadioButton4.Enabled = True

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        CatagoryNameComboBox.Enabled = True

    End Sub

    Private Sub NormalExtraSpecial_CheckedChanged(sender As Object, e As EventArgs) Handles NormalExtraSpecial.CheckedChanged
        RadioButton4.Enabled = True
        GroupBox5.Enabled = True
        RadioByDate.Checked = True
    End Sub

    Private Sub RadioDTA_CheckedChanged(sender As Object, e As EventArgs) Handles RadioDTA.CheckedChanged
        RadioButton4.Enabled = True
        GroupBox5.Enabled = True
        RadioByDate.Checked = True
    End Sub

    Private Sub Radio_Meal_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Meal.CheckedChanged
        RadioButton4.Enabled = True
        RadioByDate.Checked = True
        GroupBox5.Enabled = True
    End Sub

    Private Sub Frmcard_TextChanged(sender As Object, e As EventArgs) Handles Frmcard.TextChanged

    End Sub

    Private Sub Frmcard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Frmcard.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tocard_TextChanged(sender As Object, e As EventArgs) Handles tocard.TextChanged

    End Sub

    Private Sub tocard_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tocard.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        GroupBox5.Enabled = True
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        GroupBox5.Enabled = True
        If RadioButton6.Checked = True Then
            RadioByDate.Text = "By Month "
            Label1.Text = "Selected Month:"
            DateTimePicker1.CustomFormat = "MMM, yyyy"
            Label2.Visible = False
            DateTimePicker2.Visible = False
        Else
            RadioByDate.Text = "By Date"
            Label1.Text = "From Date: "
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            Label2.Visible = True
            DateTimePicker2.Visible = True
        End If
    End Sub

    Private Sub cmbSelectCard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectCard.SelectedIndexChanged

    End Sub

    Private Sub lstCards_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCards.SelectedIndexChanged

    End Sub
End Class