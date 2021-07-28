Public Class CanteenRepots
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Private Sub CanteenRepots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

    End Sub
    Dim Flag As Boolean = False

    Private Sub btnRptShow_Click(sender As Object, e As EventArgs) Handles btnRptShow.Click


        If DailyMeal.Checked = True Then ' Daily meal Att
            Path = "" & frmLogin.ReportsPath & "\Canteen\RptDailyCanteenAttendence.rpt"
            If AllButton.Checked = True Then ' All 
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ") "
                ElseIf MainDept.Checked = True Then ' Main Dept
                    Filter = " {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                End If
            ElseIf CardRange.Checked = True Then ' By card Range 
                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    Else
                        Filter = "{View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    Else
                        Filter = "{View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    Else
                        Filter = "{View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    Else
                        Filter = "{View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    End If
                End If

            ElseIf byShift.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ") "


                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                End If
            ElseIf RadioButton5.Checked = True Then '' By Device number 
                Flag = False

                If AllDept.Checked = True Then ' All Dept
                    Filter = "{View_Att_DayGroup.DeviceNo} = '" & TextBox3.Text & "'  And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ") "
                ElseIf MainDept.Checked = True Then ' Main Dept
                    Filter = "{View_Att_DayGroup.DeviceNo} = '" & TextBox3.Text & "' And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = "{View_Att_DayGroup.DeviceNo} = '" & TextBox3.Text & "' And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{View_Att_DayGroup.DeviceNo} = '" & TextBox3.Text & "'  And {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                End If


            ElseIf RadioButton6.Checked = True '' By device and Shift
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And  {View_Att_DayGroup.DeviceNo} = '" & TextBox3.Text & "'  And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ") "
            ElseIf MainDept.Checked = True Then ' Main Dept
                Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And  {View_Att_DayGroup.DeviceNo} = '" & TextBox3.Text & "' And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
            ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And  {View_Att_DayGroup.DeviceNo} = '" & TextBox3.Text & "' And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
            ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And  {View_Att_DayGroup.DeviceNo} = '" & TextBox3.Text & "'  And {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
            End If

        End If

        End If

        'Filter = "{View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ") And {View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & ""


        If RadioButton5.Checked = True Then ' Daily meal Att
            Path = "" & frmLogin.ReportsPath & "\Canteen\RptDailyCanteenAttendence.rpt"
            If AllButton.Checked = True Then ' All 
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ") "


                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                End If

            ElseIf CardRange.Checked = True Then ' By card Range 

                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    Else
                        Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    Else
                        Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    Else
                        Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    Else
                        Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {View_Rpt_HR_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                    End If
                End If
            ElseIf byShift.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ") "


                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_HR_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_HR_Info.SectionID} = " & SectionNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{View_Att_DayGroup.DeviceNo}=" & Me.TextBox3.Text & " And {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_HR_Info.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate} in DateTime(" & starttime.Value.Year & ", " & starttime.Value.Month & ", " & starttime.Value.Day & ") to DateTime(" & EndTime.Value.Year & ", " & EndTime.Value.Month & ", " & EndTime.Value.Day & ")"
                End If

            End If














        End If













        If MealSummary.Checked = True Then   ' Meal Summary monthlly
            Path = "" & frmLogin.ReportsPath & "\Canteen\MealAttendanceSummary.rpt"
            If AllButton.Checked = True Then ' All 
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                End If

            ElseIf CardRange.Checked = True Then ' By card Range 

                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                    End If
                End If
            ElseIf byShift.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "'  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""


                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & ""
                End If

            End If
        End If


        If ManaSummary.Checked = True Then ' Management Buffet Report
            Path = "" & frmLogin.ReportsPath & "\Canteen\MealAttendanceSummary.rpt"
            If AllButton.Checked = True Then ' All 
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed} "
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                End If

            ElseIf CardRange.Checked = True Then ' By card Range 

                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed} "
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & "And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                    End If
                End If
            ElseIf byShift.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "'  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"


                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} ={tbl_Comp_Info.BuffetMealDed}"
                End If

            End If
        End If



        If RadioButton1.Checked = True Then 'Labour Meal  Report
            Path = "" & frmLogin.ReportsPath & "\Canteen\MealAttendanceSummary.rpt"
            If AllButton.Checked = True Then ' All 
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & "  And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & "And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                End If

            ElseIf CardRange.Checked = True Then ' By card Range 

                If AllDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & "And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & "And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                    End If

                ElseIf MainDept.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & "And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                    End If

                ElseIf MainDeptandSection.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "   And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                    End If

                ElseIf Deigantionbtn.Checked = True Then
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False

                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                    Else
                        Filter = "{View_Rpt_Acc_Pre_Salary1.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                    End If
                End If
            ElseIf byShift.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "'  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"


                ElseIf MainDept.Checked = True Then ' Main Dept

                    Filter = " {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                ElseIf MainDeptandSection.Checked = True Then ' MAni Secttion
                    Filter = " {@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_Pre_Salary1.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                ElseIf Deigantionbtn.Checked = True Then ' ' Designation
                    Filter = "{@Shift} = '" & ShiftNameComboBox.Text & "' And {View_Rpt_Acc_Pre_Salary1.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Emp_Meal_Attendance.Month} = " & Me.starttime.Value.Month & " And {View_Emp_Meal_Attendance.Year} = " & Me.starttime.Value.Year & " And {View_Rpt_Acc_Pre_Salary1.ConteenDeduct} = {tbl_Comp_Info.LabourMealDed}"
                End If

            End If
        End If


        If RadioButton3.Checked = True Then '' Canteen Deduction
            Path = "" & frmLogin.ReportsPath & "\Accounts\Allowanceanddeduction\RptcanteenDed.rpt"
            If AllButton.Checked = True Then ' All 
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                ElseIf MainDept.Checked = True Then ' Main Dept 
                    Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                ElseIf MainDeptandSection.Checked = True Then ' Section 
                    Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                End If

            ElseIf CardRange.Checked = True Then ' By card range 
                If AllDept.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                    Else
                        Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ") "
                    End If

                ElseIf MainDept.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                    End If

                ElseIf MainDeptandSection.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And   {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And  {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                    End If

                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And  {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ") "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ") "
                    End If
                End If
            ElseIf byShift.Checked = True Then ' By shift
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {@Shift} = '" & ShiftNameComboBox.Text & "' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ") "
                ElseIf MainDept.Checked = True Then ' Main Dept 
                    Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                ElseIf MainDeptandSection.Checked = True Then ' Section 
                    Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & ShiftNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    Filter = " {@CanteenDed} > 0 And {tbl_Acc_Salary_Transactions.TransactionState} = 'Normal' And {View_Rpt_Acc_PreSalary.DesignationID} = " & DesigNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "' And (Month({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Month & " And Year({tbl_Acc_Salary_Transactions.SalaryMonth}) = " & starttime.Value.Year & ")"
                End If

            End If

        End If

        If RadioButton4.Checked = True Then '' Meal Allowance
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptcanteenDed.rpt"
            If AllButton.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = "{@CanteenDed} > 0.00   "
                ElseIf MainDept.Checked = True Then ' Main Dept 
                    Filter = " {@CanteenDed} > 0.00 And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' Section 
                    Filter = " {@CanteenDed} > 0.00 And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    Filter = " {@CanteenDed} > 0.00 And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                If AllDept.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & ""
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDeptandSection.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.MealAllowance} > 0 And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                End If
            ElseIf byShift.Checked = True Then ' By shift 
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And {@Shift} = '" & ShiftNameComboBox.Text & "' "
                ElseIf MainDept.Checked = True Then ' Main Dept 
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "'"
                ElseIf MainDeptandSection.Checked = True Then ' Section 
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "' "
                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "' "
                End If

            End If
        End If

        If RadioButton2.Checked = True Then '' Meal Allowance is 0 and Canteen is 0
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptcanteenDed.rpt"
            If AllButton.Checked = True Then
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  "
                ElseIf MainDept.Checked = True Then ' Main Dept 
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0 And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then ' Section 
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0 And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                End If

            ElseIf CardRange.Checked = True Then
                If AllDept.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = "{View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And  {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDept.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & ""
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf MainDeptandSection.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And   {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0 And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If
                End If
            ElseIf byShift.Checked = True Then ' By shift 
                Flag = False
                If AllDept.Checked = True Then ' All Dept
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And {@Shift} = '" & ShiftNameComboBox.Text & "' "
                ElseIf MainDept.Checked = True Then ' Main Dept 
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "'"
                ElseIf MainDeptandSection.Checked = True Then ' Section 
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "' "
                ElseIf Deigantionbtn.Checked = True Then ' Desig
                    Filter = " {View_Rpt_Acc_PreSalary.MealAllowance} = 0 And {View_Rpt_Acc_PreSalary.ConteenDeduct} = 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {@Shift} = '" & ShiftNameComboBox.Text & "' "
                End If

            End If
        End If
        If RadioButton7.Checked = True Then ''Canteen Deducation EMployee List
            Path = "" & frmLogin.ReportsPath & "\Canteen\CanteenEmployeelist.rpt"
            Filter = "{View_Rpt_Acc_AllEmployees.ConteenDeduct}=" & Me.TextBox4.Text & " "
        End If

        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If

    End Sub

    Private Sub MainDept_CheckedChanged(sender As Object, e As EventArgs) Handles MainDept.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub AllDept_CheckedChanged(sender As Object, e As EventArgs) Handles AllDept.CheckedChanged

        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub MainDeptandSection_CheckedChanged(sender As Object, e As EventArgs) Handles MainDeptandSection.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub Deigantionbtn_CheckedChanged(sender As Object, e As EventArgs) Handles Deigantionbtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = True
    End Sub

    Private Sub CardRange_CheckedChanged(sender As Object, e As EventArgs) Handles CardRange.CheckedChanged
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        ShiftNameComboBox.Enabled = False

    End Sub

    Private Sub AllButton_CheckedChanged(sender As Object, e As EventArgs) Handles AllButton.CheckedChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        ShiftNameComboBox.Enabled = False
    End Sub

    Private Sub byShift_CheckedChanged(sender As Object, e As EventArgs) Handles byShift.CheckedChanged
        TextBox1.Enabled = False
        TextBox2.Enabled = False

        ShiftNameComboBox.Enabled = True
    End Sub

    Private Sub MealSummary_CheckedChanged(sender As Object, e As EventArgs) Handles MealSummary.CheckedChanged

        If MealSummary.Checked = True Then
            EndTime.Visible = False
            Label4.Visible = False
            RadioButton5.Enabled = False
            Label5.Text = "Select Month"
            AllButton.Checked = True
            RadioButton6.Enabled = False
        Else
            EndTime.Visible = True
            Label4.Visible = True
            RadioButton5.Enabled = True
            Label5.Text = "Start Date:"
            RadioButton6.Enabled = True
        End If



    End Sub

    Private Sub ManaSummary_CheckedChanged(sender As Object, e As EventArgs) Handles ManaSummary.CheckedChanged
        If ManaSummary.Checked = True Then
            EndTime.Visible = False
            Label4.Visible = False
            RadioButton5.Enabled = False
            Label5.Text = "Select Month"
            AllButton.Checked = True
            RadioButton6.Enabled = False
        Else
            EndTime.Visible = True
            Label4.Visible = True
            RadioButton5.Enabled = True
            Label5.Text = "Start Date:"
            RadioButton6.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DailyMeal_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            EndTime.Visible = False
            Label4.Visible = False
            RadioButton5.Enabled = False
            Label5.Text = "Select Month"
            AllButton.Checked = True
            RadioButton6.Enabled = False
        Else
            EndTime.Visible = True
            Label4.Visible = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            Label5.Text = "Start Date:"
        End If
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

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Label5.Text = "Select Month"
            Label4.Visible = False
            EndTime.Visible = False
            starttime.CustomFormat = "MMM, yyyy"
            RadioButton5.Enabled = False
            AllButton.Checked = True
            RadioButton6.Enabled = False
        Else
            Label5.Text = "Start Date:"
            Label4.Visible = True
            EndTime.Visible = True
            starttime.CustomFormat = "dd/MM/yyyy"
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            starttime.Enabled = False
            EndTime.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            AllButton.Checked = True
        Else
            starttime.Enabled = True
            EndTime.Enabled = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            starttime.Enabled = False
            EndTime.Enabled = False
            RadioButton5.Enabled = False
            AllButton.Checked = True
            RadioButton6.Enabled = False
        Else
            starttime.Enabled = True
            EndTime.Enabled = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
        End If
    End Sub

    Private Sub DailyMeal_CheckedChanged_1(sender As Object, e As EventArgs) Handles DailyMeal.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextBox3.Enabled = True
            ShiftNameComboBox.Enabled = True
        Else
            TextBox3.Enabled = False
            ShiftNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            AllButton.Enabled = False
            CardRange.Enabled = False
            byShift.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton8.Enabled = True
            RadioButton8.Checked = True
        Else
            AllButton.Enabled = True
            CardRange.Enabled = True
            byShift.Enabled = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton8.Enabled = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False

        End If
    End Sub

End Class