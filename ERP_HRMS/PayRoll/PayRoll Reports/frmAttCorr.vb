Public Class frmAttCorr
    Private Sub Tbl_HRM_DeptBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_DeptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)

    End Sub

    Private Sub AttCorr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_Hrm_Employment' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_EmploymentTableAdapter.Fill(Me.DSHRM.tbl_Hrm_Employment)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        Try
            Me.Tbl_Hrm_HolidaysTableAdapter.Fill(Me.DSCalculateSalary.tbl_Hrm_Holidays, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        OTMinutes.Text = (CalculateWorkingDays() + Val(HolidayCountLabel2.Text)) * 2

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        DesigNameComboBox.Enabled = True
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged
        If RadioButton31.Checked = True Then
            TextBox3.Enabled = True
            TextBox4.Enabled = True

        Else
            TextBox3.Enabled = False
            TextBox4.Enabled = False
        End If
    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        If RadioButton32.Checked = True Then
            ShiftNameComboBox.Enabled = True

        Else
            ShiftNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub ByBranch_CheckedChanged(sender As Object, e As EventArgs) Handles ByBranch.CheckedChanged
        If ByBranch.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            BranchNameComboBox.Enabled = True
            ShiftNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
            ShiftNameComboBox.Enabled = False
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Me.Tbl_Hrm_HolidaysTableAdapter.Fill(Me.DSCalculateSalary.tbl_Hrm_Holidays, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        OTMinutes.Text = (CalculateWorkingDays() + Val(HolidayCountLabel2.Text)) * 2
    End Sub
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Filter As String = ""
        Dim Param As String = ""
        Dim Path As String = ""
        Dim Obj As New UtilityClass




        If RadioButton4.Checked = True Then ' Error Att Correction Report
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptEmpAttCorrSumm.rpt"
            If RadioButton30.Checked = True Then ' By date
                Flag = False
                If RadioButton13.Checked = True Then ' AlL Emp

                    Filter = "{@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26 and {View_Emp_Final_Att_Record.CardNo} < 50000"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept Wise
                    Filter = "{@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {@PayableDays} > 26 and {View_Emp_Final_Att_Record.CardNo} < 50000"
                ElseIf RadioButton7.Checked = True Then 'Section Wise 

                    Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26 and {View_Emp_Final_Att_Record.CardNo} < 50000"
                ElseIf RadioButton2.Checked = True Then ' Desig Wise 

                    Filter = " {View_Emp_Final_Att_Record.DesigName} = '" & DesigNameComboBox.Text & "' and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)  And {@PayableDays} > 26 and {View_Emp_Final_Att_Record.CardNo} < 50000"
                End If
            ElseIf RadioButton31.Checked = True 'By card 
                If RadioButton13.Checked = True Then ' All Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "  {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"
                    Else
                        Filter = " {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26 "
                    End If
                ElseIf RadioButton6.Checked = True ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "And  {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)And {@PayableDays} > 26 and {View_Emp_Final_Att_Record.CardNo} < 50000"
                    Else
                        Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26 and {View_Emp_Final_Att_Record.CardNo} < 50000"
                    End If
                ElseIf RadioButton7.Checked = True ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)  And {@PayableDays} > 26  and {View_Emp_Final_Att_Record.CardNo} < 50000"
                    Else
                        Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)  And {@PayableDays} > 26  and {View_Emp_Final_Att_Record.CardNo} < 50000"
                    End If
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "  {View_Emp_Final_Att_Record.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)  And {@PayableDays} > 26 "
                    Else
                        Filter = "  {View_Emp_Final_Att_Record.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "  And  {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"
                    End If
                End If
            ElseIf RadioButton32.Checked = True 'by Shift
                If RadioButton13.Checked = True Then ' All  Emp
                    Flag = False
                    Filter = " {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {@PayableDays} > 26 "
                ElseIf RadioButton6.Checked = True ' MAin Dept
                    Filter = "  {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {@PayableDays} > 26"
                ElseIf RadioButton7.Checked = True ' Section Wise
                    Filter = " {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.SubDept1ID}= " & SectionNameComboBox.SelectedValue & " and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)And {@PayableDays} > 26 "
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    Filter = "  {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.DesigName} = '" & DesigNameComboBox.Text & "' And {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"

                End If
            ElseIf ByBranch.Checked = True Then ' By branch
                If RadioButton13.Checked = True Then ' All Emp
                    Flag = False
                    Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {@PayableDays} > 26"
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = " {View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"
                ElseIf RadioButton7.Checked = True ' Section Wise
                    Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & "   And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & "   And {View_Emp_Final_Att_Record.SubDept1ID}  = " & SectionNameComboBox.SelectedValue & "and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    Filter = " {View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & "     And {View_Emp_Final_Att_Record.Designame}  = '" & DesigNameComboBox.Text & "' And  {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"

                End If
            ElseIf RadioButton3.Checked = True Then ' By Branch And SHift
                If RadioButton13.Checked = True Then ' All Emp
                    Flag = False
                    Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {@PayableDays} > 26 "
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & "    And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"
                ElseIf RadioButton7.Checked = True ' Section Wise
                    Filter = " {View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & "    And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & "   And {View_Emp_Final_Att_Record.SubDept1ID}  = " & SectionNameComboBox.SelectedValue & " And  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & "     And {View_Emp_Final_Att_Record.Designame}  = '" & DesigNameComboBox.Text & "'  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@PayableDays} > 26"

                End If
            End If
        End If






        If RadioButton10.Checked = True Then ' Overtime  Correction Report
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptEmpAttCorrSumm.rpt"
            If RadioButton30.Checked = True Then ' By date
                Flag = False
                If RadioButton13.Checked = True Then ' AlL Emp


                    Filter = "{@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton6.Checked = True ' MAin Dept Wise

                    Filter = "{@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton7.Checked = True 'Section Wise


                    Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton2.Checked = True ' Desig Wise 

                    Filter = " {View_Emp_Final_Att_Record.DesigName} = '" & DesigNameComboBox.Text & "' and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)And {@OverTimeHours} >= " & Me.OTMinutes.Text & " "

                End If

            ElseIf RadioButton31.Checked = True 'By card 
                If RadioButton13.Checked = True Then ' All Emp

                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "  {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""
                    Else
                        Filter = " {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & " "
                    End If
                ElseIf RadioButton6.Checked = True ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And{@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""
                    Else
                        Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""
                    End If
                ElseIf RadioButton7.Checked = True ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)And {@OverTimeHours} >= " & Me.OTMinutes.Text & " "
                    Else
                        Filter = " {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & "  "
                    End If
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "  {View_Emp_Final_Att_Record.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "   And {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""
                    Else
                        Filter = "  {View_Emp_Final_Att_Record.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Emp_Final_Att_Record.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & " "
                    End If
                End If
            ElseIf RadioButton32.Checked = True 'by Shift
                Flag = False
                If RadioButton13.Checked = True Then ' All  Emp

                    Filter = " {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & "  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton6.Checked = True ' MAin Dept

                    Filter = "  {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton7.Checked = True ' Section Wise

                    Filter = " {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.SubDept1ID}= " & SectionNameComboBox.SelectedValue & "  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & " And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton2.Checked = True ' Desig Wise

                    Filter = "  {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.DesigName} = '" & DesigNameComboBox.Text & "' and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                End If
            ElseIf ByBranch.Checked = True Then ' By branch
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                    Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & "  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton6.Checked = True Then ' MAin Dept

                    Filter = " {View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & "  {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton7.Checked = True ' Section Wise

                    Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & "   And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & "   And {View_Emp_Final_Att_Record.SubDept1ID}  = " & SectionNameComboBox.SelectedValue & "and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                ElseIf RadioButton2.Checked = True ' Desig Wise

                    Filter = " {View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & "     And {View_Emp_Final_Att_Record.Designame}  = '" & DesigNameComboBox.Text & "'  and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""
                End If

            ElseIf RadioButton3.Checked = True Then ' By Shift and Branch 
                Flag = False
                If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & "and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)  And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                    ElseIf RadioButton6.Checked = True Then ' MAin Dept

                        Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & "    And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & " and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00) And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                    ElseIf RadioButton7.Checked = True ' Section Wise

                        Filter = " {View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & "    And {View_Emp_Final_Att_Record.DeptID}  = " & DeptNameComboBox.SelectedValue & "    And {View_Emp_Final_Att_Record.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " and {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                    ElseIf RadioButton2.Checked = True ' Desig Wise

                        Filter = "{View_Emp_Final_Att_Record.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Emp_Final_Att_Record.ShiftID} = " & ShiftNameComboBox.SelectedValue & "     And {View_Emp_Final_Att_Record.Designame}  = '" & DesigNameComboBox.Text & "' And {@MyDate} = DateTime (" & Me.DateTimePicker1.Value.Year & ", " & Me.DateTimePicker1.Value.Month & ", 01, 00, 00, 00)And {@OverTimeHours} >= " & Me.OTMinutes.Text & ""

                    End If
                End If
            End If





        If RadioButton5.Checked = True Then ' Leaves Correction Report
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptAttendanceLeaveError.rpt"
            If RadioButton30.Checked = True Then ' By date
                Flag = False
                If RadioButton13.Checked = True Then ' AlL Emp

                    Filter = "{View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton6.Checked = True ' MAin Dept Wise
                    Filter = "{View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & " And {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & ""
                ElseIf RadioButton7.Checked = True 'Section Wise

                    Filter = " {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.Subdept1ID} = " & SectionNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton2.Checked = True ' Desig Wise 

                    Filter = " {View_Rpt_Acc_AllEmployees.DesigID} = " & DesigNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                End If
            ElseIf RadioButton31.Checked = True 'By card 
                If RadioButton13.Checked = True Then ' All Emp
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    End If
                ElseIf RadioButton6.Checked = True ' Main Dept
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "   And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "  And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    End If
                ElseIf RadioButton7.Checked = True ' Section Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "   And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & SectionNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "  And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & " "
                    End If
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    If TextBox3.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox4.Text = "" Then
                        Filter = "  {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                    Else
                        Filter = "  {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & " "
                    End If
                End If
            ElseIf RadioButton32.Checked = True 'by Shift
                If RadioButton13.Checked = True Then ' All  Emp
                    Flag = False
                    Filter = " {View_Rpt_Acc_AllEmployees.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton6.Checked = True ' MAin Dept
                    Filter = "  {View_Rpt_Acc_AllEmployees.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & "And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton7.Checked = True ' Section Wise
                    Filter = " {View_Rpt_Acc_AllEmployees.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & SectionNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    Filter = "  {View_Rpt_Acc_AllEmployees.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.DesigID}  = " & DesigNameComboBox.SelectedValue & "  And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""

                End If
            ElseIf ByBranch.Checked = True Then ' By branch
                If RadioButton13.Checked = True Then ' All Emp
                    Flag = False
                    Filter = "{View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = " {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton7.Checked = True ' Section Wise
                    Filter = "{View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "   And {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & "   And {View_Rpt_Acc_AllEmployees.SubDept1ID}  = " & SectionNameComboBox.SelectedValue & "  And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    Filter = " {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DesigID}  = " & DesigNameComboBox.SelectedValue & "  And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""

                End If
            ElseIf RadioButton3.Checked = True Then
                If RadioButton13.Checked = True Then ' All Emp
                    Flag = False
                    Filter = "{View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.ShiftID} = " & ShiftNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton6.Checked = True Then ' MAin Dept
                    Filter = "{View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.ShiftID} = " & ShiftNameComboBox.SelectedValue & "    And {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & "And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton7.Checked = True ' Section Wise
                    Filter = " {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.ShiftID} = " & ShiftNameComboBox.SelectedValue & "    And {View_Rpt_Acc_AllEmployees.DeptID}  = " & DeptNameComboBox.SelectedValue & "   And {View_Rpt_Acc_AllEmployees.SubDept1ID}  = " & SectionNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    Filter = "{View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.ShiftID} = " & ShiftNameComboBox.SelectedValue & "     And {View_Rpt_Acc_AllEmployees.DesigID}  = " & DesigNameComboBox.SelectedValue & " And  {View_Emp_AttLeave_Error.Month} = " & Me.DateTimePicker1.Value.Month & " and {View_Emp_AttLeave_Error.Year} = " & Me.DateTimePicker1.Value.Year & ""

                End If
            End If
        End If


        ''' Attt Error Report 
        ''' 







        If ErrorBtn.Checked = True Then 'Attendence error  rpt
            Path = "" & frmLogin.ReportsPath & "\PayRoll\RptAttendanceError.rpt"

            If RadioButton30.Checked = True Then 'by Date
                Flag = False
                If DurationComboBox.Text = "Count Not Equal to 2" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = " {View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & "))"
                    ElseIf RadioButton6.Checked = True Then ' All EMp
                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And   ({@Duration} in 0 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                    ElseIf RadioButton7.Checked = True Then ' Section wise
                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And   ({@Duration} in 0 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & " "
                    ElseIf RadioButton2.Checked = True Then ' Desigtion Wise
                        Filter = " {View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And    ({@Duration} in 0 to 360) And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " "
                    End If
                ElseIf DurationComboBox.Text = "Between 0 to 3:40" Then
                    If RadioButton13.Checked = True Then ' All EMp

                        Filter = " ({@Duration} in 0 to 220)  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' All EMp
                        Filter = " ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section wise
                        Filter = " ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = "  ({@Duration} in 0 to 220)   And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Between 3:41 to 6:00" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = " ({@Duration} in 221 to 360) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Main Dept 
                        Filter = " ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section Wise
                        Filter = " ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = "  ({@Duration} in 221 to 360)  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Between 6:01 to 8:00" Then
                    If RadioButton13.Checked = True Then  ' Al  EMp

                        Filter = " ({@Duration} in 361 to 480) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Main Dept
                        Filter = " ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True   ' Section Wise
                        Filter = " ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = "  ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Greater then 8:00" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = " ({@Duration} > 480) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Dept Wise
                        Filter = " ({@Duration} > 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section Wise
                        Filter = " ({@Duration} > 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = "  ({@Duration} > 480)  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf RadioButton31.Checked = True ' by Card Range 

                If RadioButton13.Checked = True Then ' All Emp
                    If DurationComboBox.Text = "Count Not Equal to 2" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    ElseIf DurationComboBox.Text = "Between 0 to 3:40" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 0 to 220) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = " ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    ElseIf DurationComboBox.Text = "Between 3:41 to 6:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = " ({@Duration} in 221 to 360)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    ElseIf DurationComboBox.Text = "Between 6:01 to 8:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 361 to 480)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = " ({@Duration} in 361 to 480)   And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    ElseIf DurationComboBox.Text = "Greater then 8:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} > 480)    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = " ({@Duration} > 480)    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If

                    End If
                ElseIf RadioButton6.Checked = True ' Main Dept
                    If DurationComboBox.Text = "Count Not Equal to 2" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                        Else
                            Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Between 0 to 3:40" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 0 to 220) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = " ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    ElseIf DurationComboBox.Text = "Between 3:41 to 6:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = " ({@Duration} in 221 to 360)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    ElseIf DurationComboBox.Text = "Between 6:01 to 8:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 361 to 480)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = " ({@Duration} in 361 to 480)   And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If
                    ElseIf DurationComboBox.Text = "Greater then 8:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} > 480)    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        Else
                            Filter = " ({@Duration} > 480)    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                        End If

                    End If
                ElseIf RadioButton7.Checked = True ' Section Wise 
                    If DurationComboBox.Text = "Count Not Equal to 2" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & "))    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & " "
                        Else
                            Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & "And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Between 0 to 3:40" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 0 to 220) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        Else
                            Filter = " ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Between 3:41 to 6:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        Else
                            Filter = " ({@Duration} in 221 to 360)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Between 6:01 to 8:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 361 to 480)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        Else
                            Filter = " ({@Duration} in 361 to 480)   And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Greater then 8:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} > 480)    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        Else
                            Filter = " ({@Duration} > 480)    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                        End If

                    End If
                ElseIf RadioButton2.Checked = True ' Desig Wise
                    If DurationComboBox.Text = "Count Not Equal to 2" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & "  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " "
                        Else
                            Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & "))   And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Between 0 to 3:40" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 0 to 220) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        Else
                            Filter = " ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Between 3:41 to 6:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & " # And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        Else
                            Filter = " ({@Duration} in 221 to 360)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Between 6:01 to 8:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} in 361 to 480)  And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        Else
                            Filter = " ({@Duration} in 361 to 480)   And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        End If
                    ElseIf DurationComboBox.Text = "Greater then 8:00" Then
                        If TextBox3.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox4.Text = "" Then
                            Filter = " ({@Duration} > 480)    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox3.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        Else
                            Filter = " ({@Duration} > 480)    And {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox3.Text & " To " & TextBox4.Text & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                        End If

                    End If
                End If

            ElseIf RadioButton32.Checked = True Then 'by Shift
                Flag = False
                If DurationComboBox.Text = "Count Not Equal to 2" Then
                    If RadioButton13.Checked = True Then ' All EMp

                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & ""
                    ElseIf RadioButton6.Checked = True ' All EMp
                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                    ElseIf RadioButton7.Checked = True ' Section wise
                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And  {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                ElseIf DurationComboBox.Text = "Between 0 to 3:40" Then
                    If RadioButton13.Checked = True Then ' All EMp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 0 to 220)  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' All EMp
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 0 to 220)   And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Between 3:41 to 6:00" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 221 to 360) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Main Dept 
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And     ({@Duration} in 221 to 360)  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Between 6:01 to 8:00" Then
                    If RadioButton13.Checked = True Then  ' Al  EMp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 361 to 480) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Main Dept
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True   ' Section Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Greater then 8:00" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} > 480) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Dept Wise
                        Filter = " ({@Duration} > 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} > 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And    ({@Duration} > 480)  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                If DurationComboBox.Text = "Count Not Equal to 2" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                    ElseIf RadioButton6.Checked = True ' All EMp
                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                    ElseIf RadioButton7.Checked = True ' Section wise
                        Filter = "{View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & " "
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                ElseIf DurationComboBox.Text = "Between 0 to 3:40" Then
                    If RadioButton13.Checked = True Then ' All EMp

                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 0 to 220)  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' All EMp
                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section wise
                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 0 to 220)   And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Between 3:41 to 6:00" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 221 to 360) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Main Dept 
                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section Wise
                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 221 to 360)  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Between 6:01 to 8:00" Then
                    If RadioButton13.Checked = True Then  ' Al  EMp

                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 361 to 480) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Main Dept
                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True   ' Section Wise
                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Greater then 8:00" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} > 480) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Dept Wise
                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} > 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section Wise
                        Filter = "{View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} > 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} > 480)  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf RadioButton3.Checked = True Then ' By ShiftA nd Branch 
                Flag = False
                If DurationComboBox.Text = "Count Not Equal to 2" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & "))"
                    ElseIf RadioButton6.Checked = True ' All EMp
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & ""
                    ElseIf RadioButton7.Checked = True ' Section wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & ""
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_PreSalary.EmpStatus} = True And (({@Duration} >= 0 And {@Duration} < 360) or {@Duration} < 0 or {View_Att_DayGroup.Count} = 1 or {View_Att_DayGroup.Count} = 3 or {View_Att_DayGroup.Count} = 4 or {View_Att_DayGroup.Count} = 5 or {View_Att_DayGroup.Count} = 6 or {View_Att_DayGroup.Count} = 7 or {View_Att_DayGroup.Count} = 8) and ({View_Att_DayGroup.AttDate} in Date(" & DateTimePicker1.Value.Year & " , " & DateTimePicker1.Value.Month & " , " & DateTimePicker1.Value.Day & ") to Date(" & DateTimePicker2.Value.Year & " , " & DateTimePicker2.Value.Month & " , " & DateTimePicker2.Value.Day & ")) And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & ""
                    End If
                ElseIf DurationComboBox.Text = "Between 0 to 3:40" Then
                    If RadioButton13.Checked = True Then ' All EMp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 0 to 220)  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' All EMp
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 0 to 220)  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 0 to 220)   And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Between 3:41 to 6:00" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 221 to 360) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Main Dept 
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 221 to 360) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 221 to 360)  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Between 6:01 to 8:00" Then
                    If RadioButton13.Checked = True Then  ' Al  EMp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 361 to 480) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Main Dept
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True   ' Section Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} in 361 to 480) And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                ElseIf DurationComboBox.Text = "Greater then 8:00" Then
                    If RadioButton13.Checked = True Then ' All Emp

                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} > 480) And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton6.Checked = True ' Dept Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} > 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton7.Checked = True ' Section Wise
                        Filter = "{View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And  ({@Duration} > 480) And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    ElseIf RadioButton2.Checked = True ' Desigtion Wise
                        Filter = " {View_Att_DayGroup.SHiftID}=" & ShiftNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  And ({@Duration} > 480)  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigNameComboBox.SelectedValue & " And {View_Att_DayGroup.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            End If
        End If



        ''''''''''






















        If Flag = True Then

            If RadioButton31.Checked = True Then
                MessageBox.Show("Card Number is Missing ", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Plese Enter  Overtime  ", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If



        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If


    End Sub
    Dim Flag As Boolean = False
    Dim Flagg As Boolean = False

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
        DesigNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        DateTimePicker1.CustomFormat = "MMM, yyyy"
        Label1.Text = "Select Month:"
        Label5.Visible = False
        DateTimePicker2.Visible = False

        RadioButton30.Text = "By Month"
        If RadioButton10.Checked = True Then
            OTMinutes.Enabled = True
        Else
            OTMinutes.Enabled = False
        End If
    End Sub

    Private Sub ErrorBtn_CheckedChanged(sender As Object, e As EventArgs) Handles ErrorBtn.CheckedChanged
        RadioButton30.Text = "By Date:"

        If ErrorBtn.Checked = True Then
            DurationComboBox.Enabled = True
            DateTimePicker1.CustomFormat = "dd/MM/yyyy"
            Label1.Text = "From Date:"
            Label5.Visible = True
            DateTimePicker2.Visible = True
        Else
            DurationComboBox.Enabled = False
            DateTimePicker1.CustomFormat = "MMM , yyyy"
            Label1.Text = "Select Month:"
            Label5.Visible = False
            DateTimePicker2.Visible = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        DateTimePicker1.CustomFormat = "MMM, yyyy"
        Label1.Text = "Select Month:"
        Label5.Visible = False
        DateTimePicker2.Visible = False
        RadioButton30.Text = "By Month"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        DateTimePicker1.CustomFormat = "MMM, yyyy"
        Label1.Text = "Select Month:"
        Label5.Visible = False
        DateTimePicker2.Visible = False
        RadioButton30.Text = "By Month"
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
End Class