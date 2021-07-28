Imports System.Threading
Public Class frmEmpEvaluation

    Private Sub Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Emp_Evaluation_HeadBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Emp_Evaluation_HeadBindingSource.EndEdit()
            Me.Tbl_Emp_Evaluation_HeadTableAdapter.Update(Me.DSEmpEvaluation.tbl_Emp_Evaluation_Head)
            Me.Tbl_Emp_Evaluation_HeadTableAdapter.Fill(Me.DSEmpEvaluation.tbl_Emp_Evaluation_Head)
            Me.Tbl_Emp_Evaluation_HeadBindingSource.MoveLast()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmEmpEvaluation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataTable1TableAdapter.Fill(Me.DSLongLeaves.DataTable1)
        Me.Tbl_Emp_EvaluationTableAdapter.Fill(Me.DSEmpEvaluation.tbl_Emp_Evaluation)
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSEmpEvaluation.tbl_Acc_FinancialPeriod)
        Me.Tbl_Emp_Evaluation_HeadTableAdapter.Fill(Me.DSEmpEvaluation.tbl_Emp_Evaluation_Head)
        Try
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, Me.EmpIDLabel1.Text)
        Catch ex As Exception
        End Try
        If Me.EvaluationDateTextBox.Text = "  /  /" Then
            Me.EvaluationDateTextBox.Text = Now.Date
        End If
        Me.Tbl_Emp_Evaluation_HeadBindingSource.MoveLast()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Emp_EvaluationBindingSource.EndEdit()
            Me.Tbl_Emp_EvaluationTableAdapter.Update(Me.DSEmpEvaluation.tbl_Emp_Evaluation)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Emp_EvaluationDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Emp_EvaluationDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Emp_EvaluationDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Emp_EvaluationDataGridView.DataError

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim DgResult As DialogResult = MessageBox.Show("Are You Sure Want To Load Employees Record For Evaluation", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Dim LateString, AbsentString, LeaveString, NoticeString As String
        Dim Late, Absent, NoticeId As Integer
        Dim Leave As Double
        'Dim dgResult As DialogResult = MessageBox.Show("Are you sure," & vbCrLf & "You want to Calculate bonus transactions of Bonus No = " & BonusNoLabel2.Text & " for Financial Period = " & FinancialPeriodLabel2.Text & " ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        'If DgResult = 6 Then

        'End If
        If DgResult = 6 Then
            Try
                'Me.Tbl_Emp_DojTableAdapter.Fill(Me.DSEmpEvaluation.tbl_Emp_Doj, CDate(Me.EvaluationDateTextBox.Text).Month, CDate(Me.EvaluationDateTextBox.Text).Year)
                Me.Tbl_Emp_DojTableAdapter.FillBy(Me.DSEmpEvaluation.tbl_Emp_Doj)
            Catch ex As Exception
            End Try
            Me.ToolStripProgressBar1.Maximum = Me.Tbl_Emp_DojBindingSource.Count - 1
            For i As Integer = 0 To Me.Tbl_Emp_DojBindingSource.Count - 1
                Try
                    Me.Tbl_Hrm_Emp_Info_NoticesTableAdapter.Fill(Me.DSEmpEvaluation.tbl_Hrm_Emp_Info_Notices, Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("EmpId"), GetFirstDayOfMonth(CDate(Me.EvaluationDateTextBox.Text)).AddYears(-1), GetFirstDayOfMonth(CDate(Me.EvaluationDateTextBox.Text)))
                    NoticeId = Me.DSEmpEvaluation.tbl_Hrm_Emp_Info_Notices.Rows(0).Item("ID")
                Catch ex As Exception
                    NoticeId = 0
                End Try
                Try
                    Me.Tbl_PayRoll_AbsentsTableAdapter.Fill(Me.DSEmpEvaluation.tbl_PayRoll_Absents, GetFirstDayOfMonth(CDate(Me.EvaluationDateTextBox.Text)).AddYears(-1), GetFirstDayOfMonth(CDate(Me.EvaluationDateTextBox.Text)), Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("EmpId"))
                    Absent = Me.DSEmpEvaluation.tbl_PayRoll_Absents.Rows(0).Item("EmpCount")
                Catch ex As System.Exception
                    Absent = 0
                End Try
                Try
                    Me.Tbl_PayRoll_LeavesTableAdapter.Fill(Me.DSEmpEvaluation.tbl_PayRoll_Leaves, GetFirstDayOfMonth(CDate(Me.EvaluationDateTextBox.Text)).AddYears(-1), GetFirstDayOfMonth(CDate(Me.EvaluationDateTextBox.Text)), Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("EmpId"))
                    Leave = Me.DSEmpEvaluation.tbl_PayRoll_Leaves.Rows(0).Item("EmpCount")
                Catch ex As System.Exception
                    Leave = 0
                End Try
                Try
                    Me.View_Rpt_Acc_MorningShortMinsTableAdapter.Fill(Me.DSEmpEvaluation.View_Rpt_Acc_MorningShortMins, GetFirstDayOfMonth(CDate(Me.EvaluationDateTextBox.Text)).AddYears(-1), GetFirstDayOfMonth(CDate(Me.EvaluationDateTextBox.Text)), Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("EmpId"))
                    Late = Me.DSEmpEvaluation.View_Rpt_Acc_MorningShortMins.Rows(0).Item("MorningShortMins")
                Catch ex As System.Exception
                    Late = 0
                End Try
                If Absent = 0 Then
                    AbsentString = "No Absent  100"
                ElseIf Absent <= 4 Then
                    AbsentString = "Absent < 4  080"
                ElseIf Absent > 4 And Absent <= 8 Then
                    AbsentString = "Absent > 4 and <8  060"
                ElseIf Absent > 8 And Absent <= 12 Then
                    AbsentString = "Absent > 8 and <12  040"
                ElseIf Absent > 12 Then
                    AbsentString = "Absent > 12  020"
                End If
                Late = Late / 60
                If Late <= 8 Then
                    LateString = "Less Than 8 Hrs 100"
                ElseIf Late > 8 And Late <= 24 Then
                    LateString = "Late > 8 and < 24 Hrs 080"
                ElseIf Late > 24 And Late <= 48 Then
                    LateString = "Late > 24 and < 48 Hrs 060"
                ElseIf Late > 48 Then
                    LateString = "Late > 48 Hrs 040"
                End If
                Leave = (Leave / 18) * 100
                If Leave = 0 Then
                    LeaveString = " No Leave in a year 100"
                ElseIf Leave > 0 And Leave <= 25 Then
                    LeaveString = "Avail 25% of total 098"
                ElseIf Leave > 25 And Leave <= 50 Then
                    LeaveString = "Avail 50% of total 095"
                ElseIf Leave > 50 And Leave <= 75 Then
                    LeaveString = "Avail 75% of total 092"
                ElseIf Leave > 75 Then
                    LeaveString = "Avail all legal leaves 090"
                End If
                If NoticeId = 0 Then
                    NoticeString = "No Notice 100"
                ElseIf NoticeId = 1 Then
                    NoticeString = "Verbal 080"
                ElseIf NoticeId = 2 Then
                    NoticeString = "1st Warning 060"
                ElseIf NoticeId = 3 Then
                    NoticeString = "2nd Warning 040"
                ElseIf NoticeId >= 4 Then
                    NoticeString = "3rd Warning 020"
                End If
                'Me.Tbl_Emp_Evaluation1TableAdapter.Insert(EvaluationPeriodTextBox.Text, Me.FinancialPeriodComboBox.Text, Me.EvaluationDateDateTimePicker.Value, Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("EmpID"), "No Leave in a year 100", "Absent < 4  080", "Late > 8 and < 24 Hrs 080", "Verbal 080", Nothing, Nothing, Nothing, 0, Nothing)
                Try
                    Me.Tbl_Emp_Evaluation2TableAdapter.Insert(Me.EavalID.Text, EvaluationPeriodTextBox.Text, Me.FinancialPeriodComboBox.Text, Me.EvaluationDateTextBox.Text, Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("EmpID"), LeaveString, AbsentString, LateString, NoticeString, Nothing, Nothing, Nothing, 0, Nothing, CDate(Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("DOJ")), CInt(Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("GrossSalary")), CDate(Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("EOCDate")), False, Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("Grade").ToString, frmLogin.DeptID, frmLogin.UserID)
                Catch ex As Exception
                End Try
                ToolStripProgressBar1.Value = i
                Thread.Sleep(100)
                Application.DoEvents()
                'Me.Tbl_Emp_EvaluationTableAdapter1.Insert(EvaluationPeriodTextBox.Text, Me.FinancialPeriodComboBox.Text, Me.EvaluationDateDateTimePicker.Value, Me.DSEmpEvaluation.tbl_Emp_Doj.Rows(i).Item("EmpID"), "No Leave in a year 100", "Absent < 4  080", "Late > 8 and < 24 Hrs 080", "Verbal 080", Nothing, Nothing, Nothing, 0, Nothing)
            Next
            Me.Tbl_Emp_EvaluationTableAdapter.Fill(Me.DSEmpEvaluation.tbl_Emp_Evaluation)
            ToolStripProgressBar1.Value = 0
        End If
    End Sub
    Private Function GetFirstDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtFrom As DateTime = dtDate
        dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1))
        Return dtFrom
    End Function

    Private Sub Tbl_Emp_EvaluationDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Emp_EvaluationDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub Tbl_Emp_EvaluationBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Emp_EvaluationBindingSource.PositionChanged
        Try
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, Me.EmpIDLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub
    'Function ChildWindowOpen(ByVal childWindow As String) As Boolean
    '    Try
    '        For Each f As Form In Me.MdiChildren
    '            If f.Name = childWindow Then
    '                f.WindowState = FormWindowState.Maximized
    '                Return True
    '            End If
    '        Next
    '        Return False
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Function
    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        'frmMain.EvaluationReportsToolStripMenuItem_Click(Nothing, Nothing)
        'frmMain.EvaluationReportsToolStripMenuItem_Click(Nothing, Nothing)

    End Sub

    Private Sub ActiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActiveToolStripMenuItem.Click
        Me.Tbl_Emp_EvaluationBindingSource.Filter = "Status=True"
        Me.Tbl_Emp_EvaluationBindingSource.Sort = "TranID ASC"
        Me.CMSSearchNIC.Hide()
    End Sub

    Private Sub NonActiveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NonActiveToolStripMenuItem.Click
        Me.Tbl_Emp_EvaluationBindingSource.Filter = "Status=False"
        Me.Tbl_Emp_EvaluationBindingSource.Sort = "TranID ASC"
        Me.CMSSearchNIC.Hide()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Tbl_Emp_EvaluationBindingSource.RemoveFilter()
        Me.Tbl_Emp_EvaluationBindingSource.Sort = "TranID ASC"
        Me.CMSSearchNIC.Hide()
    End Sub

    Private Sub GradeTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GradeTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Emp_EvaluationBindingSource.Filter = "Grade='" & Me.GradeTextBox.Text & "'"
            Me.Tbl_Emp_EvaluationBindingSource.Sort = "TranID ASC"
            Me.GradeTextBox.Text = ""
            Me.CMSSearchNIC.Hide()
        End If
    End Sub
    Private Sub SalaryGreaterTextbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SalaryGreaterTextbox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Emp_EvaluationBindingSource.Filter = "GrossSalary>=" & Me.SalaryGreaterTextbox.Text & ""
            Me.Tbl_Emp_EvaluationBindingSource.Sort = "TranID ASC"
            Me.SalaryGreaterTextbox.Text = ""
            Me.CMSSearchNIC.Hide()
        End If
    End Sub

    Private Sub SalaryLessEqualTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SalaryLessEqualTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Emp_EvaluationBindingSource.Filter = "GrossSalary<=" & Me.SalaryLessEqualTextBox.Text & ""
            Me.Tbl_Emp_EvaluationBindingSource.Sort = "TranID ASC"
            Me.SalaryLessEqualTextBox.Text = ""
            Me.CMSSearchNIC.Hide()
        End If
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        Dim DgResult As DialogResult = MessageBox.Show("Are You Sure Want To Evaluate All Employees", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If DgResult = 6 Then
            For i As Integer = 0 To Me.Tbl_Emp_EvaluationDataGridView.RowCount - 1
                Me.Tbl_Emp_EvaluationDataGridView(2, i).Value = True
            Next
        End If

    End Sub
End Class