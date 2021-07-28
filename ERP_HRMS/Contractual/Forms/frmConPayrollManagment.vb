Public Class frmConPayrollManagment
    Public Shared flag1 As Boolean
    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    '    TabControl1.SelectedTab = TabPage1
    '    Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    'End Sub

    'Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
    '    TabControl1.SelectedTab = TabPage5
    'End Sub

    'Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
    '    TabControl1.SelectedTab = TabPage2
    'End Sub
    'Private Sub LinkLabel1_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
    '    Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    'End Sub
    'Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
    '    Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
    'End Sub
    'Private Sub LinkLabel2_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel2.MouseEnter
    '    Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    'End Sub
    'Private Sub LinkLabel2_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel2.MouseLeave
    '    Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
    'End Sub
    'Private Sub LinkLabel3_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel3.MouseEnter
    '    Me.LinkLabel3.BackColor = System.Drawing.SystemColors.MenuHighlight
    'End Sub

    'Private Sub LinkLabel3_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel3.MouseLeave
    '    Me.LinkLabel3.BackColor = System.Drawing.SystemColors.ActiveCaption
    'End Sub

    'Private Sub LinkLabel4_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel4.MouseEnter
    '    Me.LinkLabel4.BackColor = System.Drawing.SystemColors.MenuHighlight
    'End Sub

    'Private Sub LinkLabel4_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel4.MouseLeave
    '    Me.LinkLabel4.BackColor = System.Drawing.SystemColors.ActiveCaption
    'End Sub

    'Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
    '    TabControl1.SelectedTab = TabPage3
    'End Sub
    Private Sub loadReocrd()
        Try


            If RadioButton2.Checked = True Then 'Filter By Date Range
                    FillByDateRange()
                ElseIf RadioButton1.Checked = True Then 'Filter By Single Date
                    FillByCardRange()
                ElseIf RadioButton3.Checked = True Then 'Filter By Card and Date Range
                    FillByCardAndDateRange()
                    'ElseIf RadioButton4.Checked = True Then 'Filter By Card, Date and Time Range

                ElseIf RadioButton6.Checked = True Then 'Filter By Single Card, Single Date
                    FillByCardAndDate()
                ElseIf RadioButton5.Checked = True Then 'Filter By Shift and  Date Range
                    FillByShiftDate()
                'ElseIf RadioButton4.Checked = True Then 'Filter By Date and time Range
                '    FillByDateTime()
            End If

            'DataGridViewTextBoxColumn1.Visible = False





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then 'By Date
            CardNoComboBox.Enabled = False
            CardNoComboBox1.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            DateTimePicker3.Enabled = False
            DateTimePicker4.Enabled = False
            'loadReocrd()
        End If
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then

            CardNoComboBox.Enabled = False
            CardNoComboBox1.Enabled = False


            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False


            DateTimePicker3.Enabled = False
            DateTimePicker4.Enabled = False

            loadReocrd()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then

            CardNoComboBox.Enabled = True
            CardNoComboBox1.Enabled = False


            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False


            DateTimePicker3.Enabled = False
            DateTimePicker4.Enabled = False

            DateTimePicker1.Focus()
            loadReocrd()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then

            CardNoComboBox.Enabled = True
            CardNoComboBox1.Enabled = True


            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True


            DateTimePicker3.Enabled = False
            DateTimePicker4.Enabled = False

            loadReocrd()
        End If
    End Sub



    Public Shared Shiftflag As Boolean = False

    Private Sub frmPayrollManagment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPayRoll.View_All_Cont' table. You can move, or remove it, as needed.
        'Me.View_All_ContTableAdapter.Fill(Me.DSPayRoll.View_All_Cont)
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Shift1' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Shift1TableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Shift1)

        Try
            Me.Tbl_HRM_Card2TableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Card2)
        Catch ex As Exception

        End Try


        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Leave_Reason' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Leave_ReasonTableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Leave_Reason)
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_PayRoll_ShortLeaves' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Shift)

        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Card1' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_HRM_Card1TableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Card1)
        Catch ex As Exception

        End Try


        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Card' table. You can move, or remove it, as needed.

        Try
            Me.Tbl_HRM_CardTableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Card)
        Catch ex As Exception

        End Try
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSPayRoll.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'DSPayRoll.View_All_Employees' table. You can move, or remove it, as needed.

        Loadflag = True
    End Sub

    Private Sub Tbl_Hrm_Emp_AttDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub



    Private Sub Tbl_Hrm_Emp_AttDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Cont_AttDataGridView.CellEndEdit
        If e.ColumnIndex = 7 Then
            If Me.Tbl_Hrm_Cont_AttDataGridView(7, e.RowIndex).Value IsNot DBNull.Value Then
                Dim ShiftID As Integer = Me.Tbl_Hrm_Cont_AttDataGridView(7, e.RowIndex).Value
                If Me.Tbl_HRM_ShiftTableAdapter.FillBy(Me.DSPayRoll.tbl_HRM_Shift, ShiftID) = 1 Then
                    Dim selecteddate As Date = Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value
                    Dim ShiftST As DateTime = Me.DSPayRoll.tbl_HRM_Shift(0).Item(2)
                    Dim ShiftET As DateTime = Me.DSPayRoll.tbl_HRM_Shift(0).Item(3)
                    Dim ShiftBST As DateTime = Me.DSPayRoll.tbl_HRM_Shift(0).Item(4)
                    Dim ShiftBET As DateTime = Me.DSPayRoll.tbl_HRM_Shift(0).Item(5)
                    ''Me.DSPayRoll.View_All_Employees(0).Item("FridayBreakStatus")
                    If WeekdayName(Weekday(selecteddate)) = "Friday" Then
                        If CType(Me.DSPayRoll.tbl_HRM_Shift(0).Item("FridayBreakStatus"), Boolean) = True Then '''' For All SHif
                            ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                            ShiftBST = DateAdd(DateInterval.Minute, 30, ShiftBST)
                            ShiftBET = DateAdd(DateInterval.Minute, 60, ShiftBET)
                        ElseIf CType(Me.DSPayRoll.tbl_HRM_Shift(0).Item("NightAndFriday"), Boolean) = True Then  '' For Night Shift
                            ShiftST = DateAdd(DateInterval.Minute, 30, ShiftST)
                            ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                            ShiftBST = DateAdd(DateInterval.Minute, 30, ShiftBST)
                            ShiftBET = DateAdd(DateInterval.Minute, 30, ShiftBET)
                        Else
                            ShiftST = Me.DSPayRoll.tbl_HRM_Shift(0).Item(2)
                            ShiftET = Me.DSPayRoll.tbl_HRM_Shift(0).Item(3)
                            ShiftBST = Me.DSPayRoll.tbl_HRM_Shift(0).Item(4)
                            ShiftBET = Me.DSPayRoll.tbl_HRM_Shift(0).Item(5)

                        End If
                    Else

                        ShiftST = Me.DSPayRoll.tbl_HRM_Shift(0).Item(2)
                        ShiftET = Me.DSPayRoll.tbl_HRM_Shift(0).Item(3)
                        ShiftBST = Me.DSPayRoll.tbl_HRM_Shift(0).Item(4)
                        ShiftBET = Me.DSPayRoll.tbl_HRM_Shift(0).Item(5)
                    End If

                    Me.Tbl_Hrm_Cont_AttDataGridView(9, e.RowIndex).Value = Me.DSPayRoll.tbl_HRM_Shift(0).Item(2)
                    Me.Tbl_Hrm_Cont_AttDataGridView(10, e.RowIndex).Value = ShiftET
                    Me.Tbl_Hrm_Cont_AttDataGridView(11, e.RowIndex).Value = ShiftBST
                    Me.Tbl_Hrm_Cont_AttDataGridView(12, e.RowIndex).Value = ShiftBET


                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Hrm_Emp_AttDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs)
        'If Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then

        '    Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value))

        'Else
        '    ClearLabels()
        'End If
    End Sub
    Private Sub ClearLabels()
        CardNoLabel1.Text = "" ' car5d 
        NameLabel1.Text = "" ' name 
        DesigNameLabel1.Text = "" ' Designation 
        DeptNameLabel1.Text = "" ' Dept
        EmpStatusCheckBox.CheckState = CheckState.Indeterminate
        Label13.Text = "" 'Section
        PictureBox1.Image = Nothing ' Image 
        Label20.Text = "" ' Grade
        Label16.Text = "" ' DOJ
        'Label21.Text = "" ''Casual label

        'Label31.Text = "" ' Medical Label

    End Sub

    Private Sub Tbl_Hrm_Cont_AttDataGridView_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Cont_AttDataGridView.CellLeave
        Dim Count As Integer
        Dim FPeriod As String = Nothing
        If e.ColumnIndex = 3 Then
            If Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
                'Dim card As Integer = Me.Tbl_Hrm_Emp_AttDataGridView(1, e.RowIndex).Value
                Try

                    Count = Me.View_All_ContTableAdapter.FillBy(Me.DSPayRoll.View_All_Cont, Val(Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex).Value))
                Catch ex As Exception
                    Count = Me.View_All_ContTableAdapter.FillBy(Me.DSPayRoll.View_All_Cont, Val(Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex).Value))

                End Try
                If Count = 1 Then
                    If Me.Tbl_Hrm_Cont_AttDataGridView(6, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Hrm_Cont_AttDataGridView(7, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Hrm_Cont_AttDataGridView(8, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Hrm_Cont_AttDataGridView(9, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Hrm_Cont_AttDataGridView(10, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Hrm_Cont_AttDataGridView(11, e.RowIndex).Value Is DBNull.Value And Me.Tbl_Hrm_Cont_AttDataGridView(12, e.RowIndex).Value Is DBNull.Value Then

                        Me.Tbl_Hrm_Cont_AttDataGridView(6, e.RowIndex).Value = True
                        Me.Tbl_Hrm_Cont_AttDataGridView(2, e.RowIndex).Value = Me.DSPayRoll.View_All_Cont(0).Item("EmpID") 'EmpID
                        Me.Tbl_Hrm_Cont_AttDataGridView(7, e.RowIndex).Value = Me.DSPayRoll.View_All_Cont(0).Item("ShiftID") 'Shift ID
                        Dim ShiftID As Integer = Me.DSPayRoll.View_All_Cont(0).Item("ShiftID")
                        Dim SelectedDate As Date = Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value
                        'Dim AttDate1 As Date = Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value
                        Dim ShiftST As DateTime = Me.DSPayRoll.View_All_Cont(0).Item("ShiftST")
                        Dim ShiftET As DateTime = Me.DSPayRoll.View_All_Cont(0).Item("ShiftET")
                        Dim ShiftBST As DateTime = Me.DSPayRoll.View_All_Cont(0).Item("BreakST")
                        Dim ShiftBET As DateTime = Me.DSPayRoll.View_All_Cont(0).Item("BreakET")
                        'Dim ShiftBreak As Int16 = Me.DSPayRoll.View_All_Employees(0).Item("FridayBreakStatus")
                        Dim Night As Boolean = Me.DSPayRoll.View_All_Cont.Rows(0).Item("NightAndFriday")
                        Dim Day As Boolean = Me.DSPayRoll.View_All_Cont.Rows(0).Item("FridayBreakStatus")
                        'MsgBox()

                        If WeekdayName(Weekday(SelectedDate)) = "Friday" Then
                            If Day = True Then '''' For All SHif
                                ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                                ShiftBST = DateAdd(DateInterval.Minute, 30, ShiftBST)
                                ShiftBET = DateAdd(DateInterval.Minute, 60, ShiftBET)
                            ElseIf Night = True Then  '' For Night Shift
                                ShiftST = DateAdd(DateInterval.Minute, 30, ShiftST)
                                ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                                ShiftBST = DateAdd(DateInterval.Minute, 30, ShiftBST)
                                ShiftBET = DateAdd(DateInterval.Minute, 30, ShiftBET)
                            Else
                                ShiftST = Me.DSPayRoll.View_All_Cont(0).Item("ShiftST")
                                ShiftET = Me.DSPayRoll.View_All_Cont(0).Item("ShiftET")
                                ShiftBST = Me.DSPayRoll.View_All_Cont(0).Item("BreakST")
                                ShiftBET = Me.DSPayRoll.View_All_Cont(0).Item("BreakET")
                            End If
                        Else
                            ShiftST = Me.DSPayRoll.View_All_Cont(0).Item("ShiftST")
                            ShiftET = Me.DSPayRoll.View_All_Cont(0).Item("ShiftET")
                            ShiftBST = Me.DSPayRoll.View_All_Cont(0).Item("BreakST")
                            ShiftBET = Me.DSPayRoll.View_All_Cont(0).Item("BreakET")
                        End If


                        'Me.Tbl_Hrm_Emp_AttDataGridView(9, e.RowIndex).Value = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                        Me.Tbl_Hrm_Cont_AttDataGridView(9, e.RowIndex).Value = ShiftST
                        Me.Tbl_Hrm_Cont_AttDataGridView(10, e.RowIndex).Value = ShiftET
                        Me.Tbl_Hrm_Cont_AttDataGridView(11, e.RowIndex).Value = ShiftBST
                        Me.Tbl_Hrm_Cont_AttDataGridView(12, e.RowIndex).Value = ShiftBET

                        'Dim Obj As New UtilityClass()
                        'FPeriod = Obj.ReturnFP(SelectedDate.Month, SelectedDate.Year)
                        'Me.Tbl_Hrm_Emp_AttDataGridView(13, e.RowIndex).Value = FPeriod
                        ''Me.Tbl_Hrm_Emp_AttDataGridView(18, e.RowIndex).Value = Now

                    End If
                Else
                    MsgBox("No Employee Active At this Card No")
                    Me.Tbl_Hrm_Cont_AttDataGridView(0, e.RowIndex).Value = DBNull.Value
                    Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex).Value = DBNull.Value
                    Me.Tbl_Hrm_Cont_AttDataGridView(2, e.RowIndex).Value = DBNull.Value
                    Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value = DBNull.Value
                    Exit Sub
                End If
            End If
            'ElseIf e.ColumnIndex = 4 Then
            '    Dim AttendTime As DateTime = Me.Tbl_Hrm_Emp_AttDataGridView(4, e.RowIndex).Value
            '    Dim AttDate As DateTime = CDate(Me.Tbl_Hrm_Emp_AttDataGridView(3, e.RowIndex).Value).ToShortDateString
            '    Dim countAtt As Integer
            '    countAtt = Me.Tbl_Hrm_Emp_AttTableAdapter.DuplicateAtt(Tbl_Hrm_Emp_AttDataGridView(1, e.RowIndex).Value, AttDate, AttendTime)
            '    If countAtt > 0 Then
            '        MsgBox("Employees Attendence Can't be marked, Because employee have Enroll his/her attendence on selected date")
            '        'Me.Tbl_Hrm_Emp_AttDataGridView(0, e.RowIndex).Value = DBNull.Value
            '        'Me.Tbl_Hrm_Emp_AttDataGridView(1, e.RowIndex).Value = DBNull.Value
            '        'Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value = DBNull.Value
            '        'Me.Tbl_Hrm_Emp_AttDataGridView(3, e.RowIndex).Value = DBNull.Value
            '        'Me.Tbl_Hrm_Emp_AttDataGridView(4, e.RowIndex).Value = DBNull.Value
            '        Exit Sub

            '    End If
        End If

    End Sub

    Private Sub Tbl_Hrm_Cont_AttDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Cont_AttDataGridView.CellEnter
        Dim dat As String = Nothing
        Dim tim As String = Nothing
        Dim Card As String = Nothing
        Dim Obj As UtilityClass = New UtilityClass
        If e.ColumnIndex > 3 Then
            If Me.Tbl_Hrm_Cont_AttDataGridView(13, e.RowIndex).Value Is DBNull.Value Then
                If Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value IsNot DBNull.Value Then
                    Dim FromDate As Date = Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value
                    Try
                        Me.Tbl_Hrm_Cont_AttDataGridView(13, e.RowIndex).Value = Obj.ReturnFP(FromDate.Month, FromDate.Year)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
        If RadioButton2.Checked = True Then 'Filter By Date Range 
            If e.ColumnIndex = 3 Then
                If Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                    If e.RowIndex = 0 Then
                        dat = CDate(DateTimePicker1.Text).ToShortDateString()
                    ElseIf e.RowIndex > 0 Then
                        dat = Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex - 1).Value
                    End If
                    Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value = dat
                End If
            ElseIf e.ColumnIndex = 4 Then
                If Me.Tbl_Hrm_Cont_AttDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                    If e.RowIndex = 0 Then
                        tim = Format(CDate(DateTimePicker1.Text), "dd/MM/yyyy hh:mm tt")
                        tim = DateAdd(DateInterval.Hour, 8, CDate(tim))

                    ElseIf e.RowIndex > 0 Then
                        tim = Format(Me.Tbl_Hrm_Cont_AttDataGridView(4, e.RowIndex - 1).Value, "dd/MM/yyyy hh:mm tt")
                    End If
                    Me.Tbl_Hrm_Cont_AttDataGridView(4, e.RowIndex).Value = tim
                End If


            End If
        ElseIf RadioButton1.Checked = True Or RadioButton3.Checked = True Or RadioButton6.Checked = True Then
            If e.ColumnIndex = 1 Then
                If Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
                    If e.RowIndex = 0 Then
                        Card = CardNoComboBox.SelectedValue
                    ElseIf e.RowIndex > 0 Then
                        Card = Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex - 1).Value
                    End If
                    Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex).Value = Card
                End If
            ElseIf e.ColumnIndex = 3 Then
                If Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                    If e.RowIndex = 0 Then
                        dat = CDate(DateTimePicker1.Text).ToShortDateString()
                    ElseIf e.RowIndex > 0 Then
                        dat = Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex - 1).Value
                    End If
                    Me.Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value = dat
                End If
            ElseIf e.ColumnIndex = 4 Then
                If Me.Tbl_Hrm_Cont_AttDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                    If e.RowIndex = 0 Then
                        tim = Format(CDate(DateTimePicker1.Text), "dd/MM/yyyy hh:mm tt")
                        tim = DateAdd(DateInterval.Hour, 8, CDate(tim))
                        'Dim MyDate As Date = DateTimePicker1.Value.AddHours(8)
                        ''tim = DateAdd(DateInterval.Hour, 8, Format(MyDate, "dd/MM/yyyy hh:mm tt"))
                        'Dim TimeDate As DateTime = CDate(DateTimePicker1.Value.AddHours(8))
                        ''tim = DateAdd(DateInterval.Hour, 8, tim)
                        'tim = Format(MyDate, "dd/MM/yyyy hh:mm tt")
                    ElseIf e.RowIndex > 0 Then
                        tim = Format(Me.Tbl_Hrm_Cont_AttDataGridView(4, e.RowIndex - 1).Value, "dd/MM/yyyy hh:mm tt")
                    End If
                    Me.Tbl_Hrm_Cont_AttDataGridView(4, e.RowIndex).Value = tim
                End If

            End If

        End If

        Try
            If Tbl_Hrm_Cont_AttDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
                Me.View_All_ContTableAdapter.Fill(Me.DSPayRoll.View_All_Cont, Val(Me.Tbl_Hrm_Cont_AttDataGridView(2, e.RowIndex).Value))
            Else
                ClearLabels()
            End If
        Catch ex As Exception
            'Error Handle for Null EmpID during Duplicate Attendence
        End Try

    End Sub
    Private Sub FillByDateRange()
        Dim Ret As Integer
        Ret = Me.Tbl_Hrm_Cont_AttTableAdapter.Fill(Me.DSPayRoll.tbl_Hrm_Cont_Att, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString())
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardAndDateRange()
        Dim Ret As Integer
        Ret = Me.Tbl_Hrm_Cont_AttTableAdapter.FillBy(Me.DSPayRoll.tbl_Hrm_Cont_Att, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString(), CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardRange() 'Singel date
        Dim Ret As Integer
        Ret = Me.Tbl_Hrm_Cont_AttTableAdapter.FillBy1(Me.DSPayRoll.tbl_Hrm_Cont_Att, Me.DateTimePicker1.Value.ToShortDateString())
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardAndDate()
        Dim Ret As Integer
        Ret = Me.Tbl_Hrm_Cont_AttTableAdapter.FillBy2(Me.DSPayRoll.tbl_Hrm_Cont_Att, CardNoComboBox.SelectedValue, Me.DateTimePicker1.Value.ToShortDateString())
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByShiftDate()
        Dim Ret As Integer
        Ret = Me.Tbl_Hrm_Cont_AttTableAdapter.FillBy4(Me.DSPayRoll.tbl_Hrm_Cont_Att, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString(), ShiftNameComboBox.SelectedValue)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByDateTime()
        Dim Ret As Integer
        Ret = Me.Tbl_Hrm_Cont_AttTableAdapter.FillBy5(Me.DSPayRoll.tbl_Hrm_Cont_Att, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub

    Private Sub Tbl_Hrm_Cont_AttDataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Tbl_Hrm_Cont_AttDataGridView.CellBeginEdit
        If e.ColumnIndex = 4 Then
            If Me.Tbl_Hrm_Cont_AttDataGridView(4, e.RowIndex).Value IsNot DBNull.Value Then
                Me.Tbl_Hrm_Cont_AttDataGridView(6, e.RowIndex).Value = True
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loadReocrd()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loadReocrd()
    End Sub

    Private Sub CardNoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CardNoComboBox.SelectedIndexChanged

        loadReocrd()
        CardNoComboBox1.Text = CardNoComboBox.Text
    End Sub

    Private Sub CardNoComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CardNoComboBox1.SelectedIndexChanged
        loadReocrd()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        loadReocrd()
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        loadReocrd()
    End Sub
    Private Sub SaveNow()
        Me.Validate()
        Me.Tbl_Hrm_Cont_AttBindingSource.EndEdit()
        Me.Tbl_Hrm_Cont_AttTableAdapter.Update(DSPayRoll.tbl_Hrm_Cont_Att)
    End Sub



    'Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
    '    Try
    '        SaveNow()

    '        MsgBox("Record Saved")

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub Tbl_Hrm_Emp_AttDataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView1.RowEnter
    '    If Tbl_Hrm_Emp_AttDataGridView1(4, e.RowIndex).Value IsNot DBNull.Value Then 'EMP ID
    '        Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(Tbl_Hrm_Emp_AttDataGridView1(4, e.RowIndex).Value))
    '    Else
    '        ClearLabels()
    '    End If
    'End Sub

    'Private Sub Tbl_Hrm_Emp_AttDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView1.CellContentClick
    '    Try
    '        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value IsNot DBNull.Value Then
    '            If e.ColumnIndex = 5 Then 'Normal



    '                If Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value Is DBNull.Value Then
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex + 1).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex + 1).Value = False
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex - 1).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex - 1).Value = False
    '                    End If
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = True
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = False
    '                    SaveNow()
    '                Else
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = False Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex + 1).Value = True
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex + 1).Value = False
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex - 1).Value = True
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex - 1).Value = False
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = False
    '                        SaveNow()
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = True Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex + 1).Value = False
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex + 1).Value = False
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex - 1).Value = False
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex - 1).Value = False
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = False
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value = False
    '                        SaveNow()
    '                    End If
    '                End If
    '            ElseIf e.ColumnIndex = 6 Then 'Extra
    '                If Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value Is DBNull.Value Then
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex + 1).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex + 1).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex + 1).Value = False
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex - 1).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex - 1).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex - 1).Value = False
    '                    End If
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = True
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value = True
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = False
    '                    SaveNow()
    '                Else
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value = False Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex + 1).Value = True
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex + 1).Value = True
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex + 1).Value = False
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex - 1).Value = True
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex - 1).Value = True
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex - 1).Value = False
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value = True
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = False
    '                        SaveNow()
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value = True Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex + 1).Value = False
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex - 1).Value = False
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value = False
    '                        SaveNow()
    '                    End If
    '                End If
    '            ElseIf e.ColumnIndex = 7 Then 'Special
    '                If Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value Is DBNull.Value Then
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex + 1).Value = False
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex + 1).Value = False
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex + 1).Value = True
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex - 1).Value = False
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex - 1).Value = False
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex - 1).Value = True
    '                    End If
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = False
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value = False
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = True
    '                    SaveNow()
    '                Else
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = False Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex + 1).Value = False
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex + 1).Value = False
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex + 1).Value = True
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex - 1).Value = False
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex - 1).Value = False
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex - 1).Value = True
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(5, e.RowIndex).Value = False
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(6, e.RowIndex).Value = False
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = True
    '                        SaveNow()
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = True Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex + 1).Value = False
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex - 1).Value = False
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(7, e.RowIndex).Value = False
    '                        SaveNow()
    '                    End If
    '                End If
    '            End If

    '            If e.ColumnIndex = 8 Then 'DTA
    '                If Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex).Value Is DBNull.Value Then
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex + 1).Value = True
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex - 1).Value = True
    '                    End If
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex).Value = True
    '                    SaveNow()
    '                Else
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex).Value = False Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex + 1).Value = True
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex - 1).Value = True
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex).Value = True
    '                        SaveNow()
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex).Value = True Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex + 1).Value = False
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex - 1).Value = False
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(8, e.RowIndex).Value = False
    '                        SaveNow()
    '                    End If
    '                End If
    '            End If
    '            If e.ColumnIndex = 9 Then 'SOTPayment 
    '                If Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex).Value Is DBNull.Value Then
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex + 1).Value = True

    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex - 1).Value = True

    '                    End If
    '                    Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex).Value = True

    '                    SaveNow()
    '                Else
    '                    If Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex).Value = False Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex + 1).Value = True
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex - 1).Value = True
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex).Value = True
    '                        SaveNow()
    '                    ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex).Value = True Then
    '                        If Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex + 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex + 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex + 1).Value = False
    '                        ElseIf Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(1, e.RowIndex - 1).Value And Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView1(2, e.RowIndex - 1).Value Then
    '                            Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex - 1).Value = False
    '                        End If
    '                        Me.Tbl_Hrm_Emp_AttDataGridView1(9, e.RowIndex).Value = False
    '                        SaveNow()
    '                    End If
    '                End If
    '            End If

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick

    '    If MessageBox.Show("Are you Sure Want To Enter Auto Over Time Entry?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        PartialMod()
    '    End If
    'End Sub
    'Private Sub PartialMod()
    '    If ChildWindowOpen("frmAutoOTEntry") = False Then
    '        Dim objPartialQty As New frmAutoOTEntry
    '        frmAutoOTEntry.Size = New System.Drawing.Size(381, 131)
    '        objPartialQty.Show()
    '    End If
    'End Sub
    Public Shared Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In frmConPayrollManagment.MdiChildren
            'For Each f As Form In frmLongLeaves.MdiChildren
            If f.Name = childWindow Then
                f.Focus()
                Return True
            End If
        Next
        Return False
    End Function
    Public Shared flag As Boolean = False
    Public Shared OTDate As Date
    'Private Sub Tbl_PayRoll_LongLeavesDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.CellEnter
    '    Dim Count As Integer
    '    Dim Obj As UtilityClass = New UtilityClass()
    '    Dim TotalDays As Int16



    '    If e.ColumnIndex = 8 Then
    '        Try
    '            TotalDays = Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value
    '        Catch ex As Exception
    '            TotalDays = 0
    '        End Try

    '        If Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "Compensatory" And Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value = 1 And TotalDays = 1 Then
    '            If Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
    '                MsgBox("Select Card No. to Continue")
    '            Else
    '                If Me.Tbl_PayRoll_LongLeavesDataGridView(8, e.RowIndex).Value Is DBNull.Value Then
    '                    If Me.Tbl_PayRoll_LongLeavesTableAdapter.DateLeave(CInt(Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value)) = Nothing Then
    '                        MsgBox("This Card No has no Any Compensatory Leave Balance")
    '                    Else
    '                        Me.Tbl_PayRoll_LongLeavesDataGridView(8, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesTableAdapter.DateLeave(CInt(Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value))
    '                    End If
    '                End If
    '            End If
    '        Else
    '            'MsgBox("Select Compensatory Leave Type and Enter propery Total Days and Payable Days to Continue")
    '        End If



    '    End If






    'If e.ColumnIndex = 4 Then



    '        Try

    '            Count = Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value)) ' Active Employees 
    '        Catch ex As Exception
    '            Count = Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(-55)) ' InActive Employees 

    '        End Try
    '        If Count = 1 Then
    '            'Financial Period Column
    '            If Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
    '                If Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value IsNot DBNull.Value Then
    '                    Dim FromDate As Date = Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value
    '                    Try
    '                        Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value = Obj.ReturnFP(FromDate.Month, FromDate.Year)
    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)
    '                    End Try
    '                End If
    '            End If
    '        Else
    '            MsgBox("Employee is InActive Can't Paid Leaves ")

    '        End If
    '    ElseIf e.ColumnIndex = 2 Then
    '        'Leave Type Column
    '        If Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
    '            Try
    '                Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "Casual"
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    '        End If
    '    ElseIf e.ColumnIndex = 3 Then
    '        'From Date Column
    '        If Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
    '            If Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
    '                If Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "Annual" Then
    '                    MsgBox("You are not allowed to add Annual Leaves here")
    '                    Me.Tbl_PayRoll_LongLeavesDataGridView(0, e.RowIndex).Value = Nothing
    '                    Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value = Nothing
    '                    Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = Nothing
    '                    Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value = Nothing
    '                Else
    '                    Try
    '                        Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value = Now.ToShortDateString()
    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)
    '                    End Try

    '                End If
    '            End If
    '        End If
    '    ElseIf e.ColumnIndex = 5 Then
    '        'Total Leaves Column
    '        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
    '            Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value = 1
    '        End If
    '    ElseIf e.ColumnIndex = 6 Then
    '        'Paid Leaves Column
    '        Dim RowCount As Integer
    '        Dim CasualPaidSum As Double
    '        Dim MedicalPaidSum As Double
    '        Dim MyMonth As Integer

    '        MyMonth = CType(Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value, Date).Month
    '        Label21.Text = ""
    '        Label31.Text = ""
    '        'If Me.View_Rpt_Acc_AllEmployeesTableAdapter.FillBy(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value) = 1 Then
    '        '    JTEmpID = Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees(0).Item(8)
    '        'End If
    '        If Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
    '            If Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
    '                If Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "Casual" Then 'casual check

    '                    RowCount = Me.View_Rpt_PayRoll_PaidCasualSumTableAdapter.Fill(Me.DSPayRoll.View_Rpt_PayRoll_PaidCasualSum, Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value, Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value)
    '                    'RowCount = Me.View_Rpt_PayRoll_PaidLeaveSumTableAdapter.FillBy(Me.DSLongLeaves.View_Rpt_PayRoll_PaidLeaveSum, Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value, JTEmpID)
    '                    If RowCount = 0 Then
    '                        Label21.Text = 0
    '                        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value <= ApplicableLeaves(MyMonth) Then
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value
    '                        Else
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = ApplicableLeaves(MyMonth)
    '                        End If
    '                    Else
    '                        'CasualPaidSum = Me.DSLongLeaves.View_Rpt_PayRoll_PaidLeaveSum.Rows(0).Item(2)
    '                        CasualPaidSum = Me.DSPayRoll.View_Rpt_PayRoll_PaidCasualSum.Rows(0).Item(2)
    '                        Label21.Text = CasualPaidSum
    '                        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value <= (ApplicableLeaves(MyMonth) - CasualPaidSum) Then
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value
    '                        Else
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = (ApplicableLeaves(MyMonth) - CasualPaidSum)
    '                        End If
    '                    End If
    '                ElseIf Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "M1" Or Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "Sick" Then  'M1 and Sick check
    '                    RowCount = Me.View_Rpt_PayRoll_PaidMadicalSumTableAdapter.Fill(Me.DSPayRoll.View_Rpt_PayRoll_PaidMadicalSum, Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value, Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value)
    '                    If RowCount = 0 Then
    '                        Label31.Text = 0
    '                        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value <= ApplicableLeaves(MyMonth) Then
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value
    '                        Else
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = ApplicableLeaves(MyMonth)
    '                        End If
    '                    Else
    '                        MedicalPaidSum = Me.DSPayRoll.View_Rpt_PayRoll_PaidMadicalSum.Rows(0).Item(2)
    '                        Label31.Text = MedicalPaidSum
    '                        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value <= (ApplicableLeaves(MyMonth) - MedicalPaidSum) Then
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value
    '                        Else
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = (ApplicableLeaves(MyMonth) - MedicalPaidSum)
    '                        End If
    '                    End If
    '                End If
    '            ElseIf Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = 0 Then
    '                If Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "Casual" Then
    '                    RowCount = Me.View_Rpt_PayRoll_PaidCasualSumTableAdapter.Fill(Me.DSPayRoll.View_Rpt_PayRoll_PaidCasualSum, Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value, Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value)
    '                    If RowCount = 0 Then
    '                        Label21.Text = 0
    '                        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value <= ApplicableLeaves(MyMonth) Then
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value
    '                        Else
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = ApplicableLeaves(MyMonth)
    '                        End If
    '                    Else
    '                        CasualPaidSum = Me.DSPayRoll.View_Rpt_PayRoll_PaidCasualSum.Rows(0).Item(2)
    '                        Label21.Text = CasualPaidSum
    '                        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value <= (ApplicableLeaves(MyMonth) - CasualPaidSum) Then
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value
    '                        Else
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = (ApplicableLeaves(MyMonth) - CasualPaidSum)
    '                        End If
    '                    End If
    '                ElseIf Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "M1" Or Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = "Sick" Then
    '                    RowCount = Me.View_Rpt_PayRoll_PaidMadicalSumTableAdapter.Fill(Me.DSPayRoll.View_Rpt_PayRoll_PaidMadicalSum, Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value, Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value)
    '                    If RowCount = 0 Then
    '                        Label31.Text = 0
    '                        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value <= ApplicableLeaves(MyMonth) Then
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value
    '                        Else
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = ApplicableLeaves(MyMonth)
    '                        End If
    '                    Else
    '                        MedicalPaidSum = Me.DSPayRoll.View_Rpt_PayRoll_PaidMadicalSum.Rows(0).Item(2)
    '                        Label31.Text = MedicalPaidSum
    '                        If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value <= (ApplicableLeaves(MyMonth) - MedicalPaidSum) Then
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value
    '                        Else
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(7, e.RowIndex).Value = (ApplicableLeaves(MyMonth) - MedicalPaidSum)
    '                        End If
    '                    End If
    '                End If
    '                'check Probation Period

    '            End If
    '        End If
    '        Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value)
    '        Dim probation As DateTime
    '        Try
    '            probation = Me.DSPayRoll.View_All_Employees.Rows(0).Item("DateOfPermanent")
    '        Catch ex As Exception
    '            MsgBox("Employees probation period missing")
    '        End Try

    '        Dim leavedate As DateTime = CType(Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value, Date)
    '        If leavedate <= probation Then
    '            MsgBox("Employees Leaves Can't be paid, Because employee in probation period")
    '            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = 0
    '        End If
    '    ElseIf e.ColumnIndex = 7 Then
    '        If Me.Tbl_PayRoll_LongLeavesDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
    '            If Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value And Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value IsNot DBNull.Value Then
    '                If Me.Tbl_Hrm_Emp_AttTableAdapter.FillBy3(Me.DSPayRoll.tbl_Hrm_Emp_Att, Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value, Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value) > 0 Then
    '                    If Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value - Math.Truncate(Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value) = 0.5 Then
    '                        Try
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(7, e.RowIndex).Value = Now.ToShortDateString()
    '                        Catch ex As Exception
    '                            MsgBox(ex.Message)
    '                        End Try
    '                    Else
    '                        MsgBox("Employees Leaves Can't be Saved, Because employee have Enroll his/her attendence on selected date")
    '                        Try
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(0, e.RowIndex).Value = Nothing
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value = Nothing
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value = Nothing
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value = Nothing
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value = Nothing
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value = Nothing
    '                            Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value = Nothing
    '                        Catch ex As Exception
    '                            'MsgBox(ex.Message)
    '                        End Try
    '                    End If
    '                Else
    '                    Try
    '                        Me.Tbl_PayRoll_LongLeavesDataGridView(7, e.RowIndex).Value = Now.ToShortDateString()
    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)
    '                    End Try
    '                End If
    '                'Ret = 0
    '            End If
    '        End If
    '    End If

    'End Sub

    Public Sub InsertRecord(ByVal LeaveType As String, ByVal AutoCardNo As Integer, ByVal AutoFromDate As Date, ByVal ToDate As Date, ByVal Leave As Double, ByVal Leave_Status As Double, ByVal AgainstDate As String, ByVal CheckBox2 As Boolean, ByVal FP As String)
        If CheckBox2 = True Then
            If LeaveType = "Compensatory" Or LeaveType = "Casual" Or LeaveType = "M1" Or LeaveType = "Sick" Or LeaveType = "Special" Then
                'CardNo = AutoCardNo
                'FromDate = AutoFromDate
                'EndDate = ToDate
                If AgainstDate = Nothing Then
                    Me.Tbl_PayRoll_LongLeavesTableAdapter.Insert(AutoCardNo, FP, LeaveType, AutoFromDate, Leave, Leave_Status, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                Else
                    'Me.Tbl_PayRoll_LongLeavesTableAdapter.Insert(AutoCardNo, LeaveType, AutoFromDate, ToDate, Leave, Leave, Now.Date, FP, False, Nothing)
                End If
            End If
        Else
            Dim DayNo As Integer = DateDiff(DateInterval.Day, AutoFromDate, ToDate)
            If DayNo > 1 Then
                If AutoCardNo <> Nothing Then
                    For i As Integer = 0 To DayNo
                        AutoFromDate.AddDays(i)
                        If AutoFromDate.AddDays(i).ToString("dddd").Trim <> "Sunday".Trim Then
                            'CardNo = AutoCardNo
                            'FromDate = AutoFromDate
                            'EndDate = ToDate
                            Me.Tbl_PayRoll_LongLeavesTableAdapter.Insert(AutoCardNo, FP, LeaveType, AutoFromDate.AddDays(i), Leave, Leave_Status, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                        End If
                    Next
                Else
                    MsgBox("Card Not Selected")
                End If
            End If
        End If

    End Sub
    Private Function ApplicableLeaves(ByVal MyMon As Integer) As Integer
        Dim LeavesApply As Integer
        If MyMon = 7 Then
            LeavesApply = 1
        ElseIf MyMon = 8 Then
            LeavesApply = 2
        ElseIf MyMon = 9 Then
            LeavesApply = 3
        ElseIf MyMon = 10 Then
            LeavesApply = 4
        ElseIf MyMon = 11 Then
            LeavesApply = 5
        ElseIf MyMon = 12 Then
            LeavesApply = 6
        ElseIf MyMon = 1 Then
            LeavesApply = 7
        ElseIf MyMon = 2 Then
            LeavesApply = 8
        ElseIf MyMon = 3 Then
            LeavesApply = 9
        ElseIf MyMon = 4 Or MyMon = 5 Or MyMon = 6 Then
            LeavesApply = 10
        End If
        Return LeavesApply
    End Function

    'Private Sub Tbl_PayRoll_LongLeavesDataGridView_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.RowLeave
    '    If Me.Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value And Me.Tbl_PayRoll_LongLeavesDataGridView(2, e.RowIndex).Value IsNot DBNull.Value And Me.Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value IsNot DBNull.Value And Me.Tbl_PayRoll_LongLeavesDataGridView(5, e.RowIndex).Value IsNot DBNull.Value And Me.Tbl_PayRoll_LongLeavesDataGridView(6, e.RowIndex).Value IsNot DBNull.Value Then
    '        Try
    '            Me.Validate()
    '            Me.Tbl_PayRoll_LongLeavesBindingSource.EndEdit()
    '            Me.Tbl_PayRoll_LongLeavesTableAdapter.Update(Me.DSPayRoll.tbl_PayRoll_LongLeaves)
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub
    Private Sub FillByDateRange1()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_LongLeavesTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_LongLeaves, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString())
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardAndDateRange1()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_LongLeavesTableAdapter.FillBy(Me.DSPayRoll.tbl_PayRoll_LongLeaves, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString(), CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardRange1()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_LongLeavesTableAdapter.FillBy1(Me.DSPayRoll.tbl_PayRoll_LongLeaves, Me.DateTimePicker1.Value.ToShortDateString())
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardAndDate1()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_LongLeavesTableAdapter.FillBy2(Me.DSPayRoll.tbl_PayRoll_LongLeaves, Me.DateTimePicker1.Value.ToShortDateString(), CardNoComboBox.SelectedValue)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByShiftDate1()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_LongLeavesTableAdapter.FillBy4(Me.DSPayRoll.tbl_PayRoll_LongLeaves, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString(), ShiftNameComboBox.SelectedValue)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub

    'Private Sub Tbl_PayRoll_LongLeavesDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.RowEnter

    '    If Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
    '        Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value))
    '        Me.Tbl_PayRoll_LongLeaves_CasualTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_LongLeaves_Casual, Val(Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value), Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value)
    '        Me.Tbl_PayRoll_LongLeaves_SickTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_LongLeaves_Sick, Val(Tbl_PayRoll_LongLeavesDataGridView(1, e.RowIndex).Value), Me.Tbl_PayRoll_LongLeavesDataGridView(4, e.RowIndex).Value)

    '    Else
    '        ClearLabels()

    '    End If
    'End Sub

    'Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
    '    Try
    '        Me.Validate()
    '        Me.Tbl_PayRoll_LongLeavesBindingSource.EndEdit()
    '        Me.Tbl_PayRoll_LongLeavesTableAdapter.Update(Me.DSPayRoll.tbl_PayRoll_LongLeaves)
    '        MsgBox("Record Saved")

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
    '    'If TabControl1.SelectedTab.Text = "Manual Attendance" Or TabControl1.SelectedTab.Text = "Over Time" Then
    '    If Me.TabControl1.SelectedTab.Text = "Leaves Management" Then
    '        LeavcounPanel.Enabled = True
    '        RadioButton4.Enabled = False
    '    ElseIf Me.TabControl1.SelectedTab.Text = "Over Time"
    '        Me.Tbl_PayRoll_LongLeaves_CasualTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_LongLeaves_Casual, 1, "22")
    '        Me.Tbl_PayRoll_LongLeaves_SickTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_LongLeaves_Sick, 1, "22")
    '        RadioButton4.Enabled = True
    '        LeavcounPanel.Enabled = False
    '    Else
    '        Me.Tbl_PayRoll_LongLeaves_CasualTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_LongLeaves_Casual, 1, "22")
    '        Me.Tbl_PayRoll_LongLeaves_SickTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_LongLeaves_Sick, 1, "22")
    '        RadioButton4.Enabled = False
    '        LeavcounPanel.Enabled = False
    '    End If
    '    'ElseIf TabControl1.SelectedTab.Text = "" Then

    '    'End If
    '    loadReocrd()
    'End Sub

    'Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click

    '    If MessageBox.Show("Are you Sure Want To Enter Leave Entry?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
    '        AutoLeavesMod()
    '    End If
    'End Sub
    Private Sub AutoLeavesMod()
        If ChildWindowOpen("frmAutoLeaves") = False Then
            Dim objPartialQty As New frmAutoLeaves
            frmAutoLeaves.Size = New System.Drawing.Size(381, 131)
            objPartialQty.Show()

        End If
    End Sub

    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        If MessageBox.Show("Are you Sure Want To Enter Leave Entry?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            AutoAttTextToDB()
        End If
    End Sub
    Private Sub AutoAttTextToDB()
        If ChildWindowOpen("frmAutoAttConnEntry") = False Then
            Dim objPartialQty As New frmAutoAttConnEntry
            frmAutoAttConnEntry.Size = New System.Drawing.Size(800, 600)
            objPartialQty.Show()

        End If
    End Sub

    'Private Sub Tbl_PayRoll_ShortLeavesDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.CellEnter


    '    If Tbl_PayRoll_ShortLeavesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
    '        Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(Tbl_PayRoll_ShortLeavesDataGridView(1, e.RowIndex).Value))
    '    Else
    '        ClearLabels()

    '    End If

    '    If e.ColumnIndex = 3 Then
    '        If Tbl_PayRoll_ShortLeavesDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
    '            Tbl_PayRoll_ShortLeavesDataGridView(3, e.RowIndex).Value = Now.Date

    '        End If
    '    ElseIf e.ColumnIndex = 4 Then
    '        If Tbl_PayRoll_ShortLeavesDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
    '            Tbl_PayRoll_ShortLeavesDataGridView(4, e.RowIndex).Value = Now

    '        End If
    '    ElseIf e.ColumnIndex = 5 Then
    '        If Tbl_PayRoll_ShortLeavesDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
    '            Tbl_PayRoll_ShortLeavesDataGridView(5, e.RowIndex).Value = Now.AddHours(2)

    '        End If
    '    End If

    'End Sub

    'Private Sub Tbl_PayRoll_ShortLeavesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.CellContentClick

    'End Sub

    'Private Sub Tbl_PayRoll_ShortLeavesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.DataError

    'End Sub

    'Private Sub Tbl_PayRoll_ShortLeavesDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.EditingControlShowing
    '    If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
    '        CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
    '        CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
    '        CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    '    End If
    'End Sub

    'Private Sub Tbl_PayRoll_LongLeavesDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.EditingControlShowing
    '    'If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
    '    '    CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
    '    '    CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
    '    '    CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    '    'End If
    'End Sub

    'Private Sub Tbl_Hrm_Emp_AttDataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView1.EditingControlShowing
    '    If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
    '        CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
    '        CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
    '        CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
    '    End If
    'End Sub

    Private Sub Tbl_Hrm_Cont_AttDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Hrm_Cont_AttDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub
    Private Sub FillByDateRange2()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_ShortLeavesTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString())
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardAndDateRange2()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_ShortLeavesTableAdapter.FillBy(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString(), CardNoComboBox.SelectedValue, CardNoComboBox1.SelectedValue)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardRange2()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_ShortLeavesTableAdapter.FillBy1(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker1.Value.ToShortDateString())
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByCardAndDate2()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_ShortLeavesTableAdapter.FillBy2(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker1.Value.ToShortDateString(), CardNoComboBox.SelectedValue)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub
    Private Sub FillByShiftDate2()
        Dim Ret As Integer
        Ret = Me.Tbl_PayRoll_ShortLeavesTableAdapter.FillBy4(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker1.Value.ToShortDateString(), Me.DateTimePicker2.Value.ToShortDateString(), ShiftNameComboBox.SelectedValue)
        If Ret = 0 Then
            ClearLabels()
        End If
    End Sub

    'Private Sub Tbl_PayRoll_ShortLeavesDataGridView_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.CellLeave
    '    Dim Count As Integer
    '    Dim FPeriod As String = Nothing
    '    If e.ColumnIndex = 3 Then
    '        If Me.Tbl_PayRoll_ShortLeavesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
    '            Count = Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(Me.Tbl_PayRoll_ShortLeavesDataGridView(1, e.RowIndex).Value))
    '            If Count = 1 Then
    '                If Me.Tbl_PayRoll_ShortLeavesDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
    '                    Me.Tbl_PayRoll_ShortLeavesDataGridView(6, e.RowIndex).Value = Me.DSPayRoll.View_All_Employees(0).Item("ShiftID") 'Shift ID

    '                End If
    '                If Me.Tbl_PayRoll_ShortLeavesDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
    '                    Me.Tbl_PayRoll_ShortLeavesDataGridView(2, e.RowIndex).Value = Me.DSPayRoll.View_All_Employees(0).Item("CardNo") 'card No
    '                End If
    '            Else
    '                MsgBox("No Employee Active At this Card No")
    '                Me.Tbl_PayRoll_ShortLeavesDataGridView(0, e.RowIndex).Value = DBNull.Value
    '                Me.Tbl_PayRoll_ShortLeavesDataGridView(1, e.RowIndex).Value = DBNull.Value
    '                Me.Tbl_PayRoll_ShortLeavesDataGridView(2, e.RowIndex).Value = DBNull.Value
    '                Me.Tbl_PayRoll_ShortLeavesDataGridView(3, e.RowIndex).Value = DBNull.Value
    '                Me.Tbl_PayRoll_ShortLeavesDataGridView(4, e.RowIndex).Value = DBNull.Value
    '                Exit Sub
    '            End If
    '        End If
    '    End If
    'End Sub





    Private Sub Tbl_Hrm_Cont_AttDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Hrm_Cont_AttDataGridView.DataError

    End Sub



    'Private Sub Tbl_Hrm_Emp_AttDataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView1.DataError

    'End Sub



    'Private Sub Tbl_PayRoll_LongLeavesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.DataError

    'End Sub

    'Private Sub Tbl_PayRoll_ShortLeavesDataGridView_DataError_1(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.DataError

    'End Sub

    Private Sub Tbl_Hrm_Emp_AttBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Hrm_Emp_AttBindingNavigatorSaveItem.Click
        'Dim postion As Integer = Tbl_Hrm_Emp_AttBindingSource.Position
        'Tbl_Hrm_Emp_AttTableAdapter.Update(Me.DSPayRoll.tbl_Hrm_Emp_Att)
        'Tbl_Hrm_Emp_AttBindingSource.Position = postion
        Try
            Me.Validate()
            Me.Tbl_Hrm_Cont_AttBindingSource.EndEdit()
            Me.Tbl_Hrm_Cont_AttTableAdapter.Update(Me.DSPayRoll.tbl_Hrm_Cont_Att)

            'Me.TableAdapterManager.UpdateAll(Me.DSPayRoll)
            MsgBox("Record Saved")

            loadReocrd()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub ToolStripButton20_Click(sender As Object, e As EventArgs) Handles ToolStripButton20.Click
    '    Try
    '        Me.Validate()

    '        Me.Tbl_PayRoll_ShortLeavesBindingSource.EndEdit()
    '        Me.Tbl_PayRoll_ShortLeavesTableAdapter.Update(Me.DSPayRoll.tbl_PayRoll_ShortLeaves)
    '        'Me.TableAdapterManager.UpdateAll(Me.DSPayRoll)
    '        MsgBox("Record Saved")
    '        loadReocrd()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub Tbl_PayRoll_LongLeavesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.CellContentClick

    'End Sub

    Private Sub Tbl_Hrm_Cont_AttDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Cont_AttDataGridView.CellContentClick
        If RadioButton3.Checked = True Or RadioButton6.Checked = True Then
            If Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Hrm_Cont_AttDataGridView(1, e.RowIndex).Value = CardNoComboBox.Text
            End If
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            CardNoComboBox.Enabled = False
            CardNoComboBox1.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True
            DateTimePicker3.Enabled = False
            DateTimePicker4.Enabled = False
            ShiftNameComboBox.Enabled = True
            loadReocrd()
        Else
            ShiftNameComboBox.Enabled = False
        End If
    End Sub





    Private Sub ShiftNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ShiftNameComboBox.SelectedIndexChanged
        loadReocrd()
    End Sub

    'Private Sub CardNoComboBox_Click(sender As Object, e As EventArgs) Handles CardNoComboBox.Click
    '    If CardNoComboBox.SelectedText <> "" Then
    '        Me.View_All_EmployeesTableAdapter.FillBy(Me.DSPayRoll.View_All_Employees, Val(CardNoComboBox.Text))
    '    End If
    'End Sub

    'Private Sub CardNoComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles CardNoComboBox.SelectedValueChanged
    '    If CardNoComboBox.Text <> "" Then
    '        Me.View_All_EmployeesTableAdapter.FillBy(Me.DSPayRoll.View_All_Employees, Val(CardNoComboBox.Text))
    '    End If
    'End Sub



    'Private Sub CardNoComboBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CardNoComboBox.KeyDown
    '    If RadioButton6.Checked = True Then
    '        If e.KeyCode = Keys.Enter Then
    '            If CardNoComboBox.Text <> "" Then
    '                Me.View_All_EmployeesTableAdapter.FillBy(Me.DSPayRoll.View_All_Employees, Val(CardNoComboBox.Text))
    '            End If
    '        End If
    '    End If
    'End Sub
    Dim Loadflag As Boolean = flag
    Private Sub Tbl_Hrm_Cont_AttDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_Cont_AttDataGridView.CellValueChanged
        If Loadflag = True Then
            If e.ColumnIndex = 4 Then
                Try
                    If Tbl_Hrm_Cont_AttDataGridView(3, e.RowIndex).Value >= Me.View_All_EmployeesTableAdapter.DOJ(Me.Tbl_Hrm_Cont_AttDataGridView(2, e.RowIndex).Value) Then
                    Else
                        MsgBox("Attendance Before Joining Date Is Not Allowed", MsgBoxStyle.Critical)
                        Try
                            Me.Tbl_Hrm_Cont_AttBindingSource.ResetBindings(True)
                            Me.Tbl_Hrm_Cont_AttBindingSource.RemoveCurrent()
                        Catch ex As Exception
                        End Try
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    'Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click

    'End Sub

    'Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)
    '    If RadioButton4.Checked = True Then
    '        CardNoComboBox.Enabled = False
    '        CardNoComboBox1.Enabled = False
    '        DateTimePicker1.Enabled = True
    '        DateTimePicker2.Enabled = True
    '        DateTimePicker3.Enabled = False
    '        DateTimePicker4.Enabled = False
    '        loadReocrd()
    '        DateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt"
    '        DateTimePicker2.CustomFormat = "dd/MM/yyyy hh:mm tt"
    '    Else
    '        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    '        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
    '    End If
    'End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    'Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.Tbl_Hrm_Cont_AttTableAdapter.Fill(Me.DSPayRoll.tbl_Hrm_Cont_Att, New System.Nullable(Of Date)(CType(AttDateToolStripTextBox.Text, Date)), New System.Nullable(Of Date)(CType(AttDate1ToolStripTextBox.Text, Date)))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub








    'Private Sub Tbl_PayRoll_LongLeavesDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.CellValueChanged
    '    If Loadflag = True Then
    '        If e.ColumnIndex = 4 Then
    '            Try
    '                If Tbl_PayRoll_LongLeavesDataGridView(3, e.RowIndex).Value >= Me.View_All_EmployeesTableAdapter.DOJ(Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value) Then
    '                Else
    '                    MsgBox("Attendance Before Joining Date Is Not Allowed", MsgBoxStyle.Critical)
    '                    Try
    '                        Me.Tbl_Hrm_Emp_AttBindingSource.ResetBindings(True)
    '                        Me.Tbl_Hrm_Emp_AttBindingSource.RemoveCurrent()
    '                    Catch ex As Exception
    '                    End Try
    '                End If
    '            Catch ex As Exception
    '            End Try
    '        End If
    '    End If
    'End Sub
End Class