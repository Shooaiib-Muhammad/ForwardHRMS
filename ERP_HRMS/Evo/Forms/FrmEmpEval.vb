Public Class FrmEmpEval

    Private Function MyDate(ByVal MyMonth As Integer, ByVal MyYear As Integer)
        Dim MyDate1 As New Date(MyYear, MyMonth, 1)
        Return MyDate1
    End Function

    Private Sub FrmEmpEval_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_InfoBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_InfoBindingSource.Position -= 1
        End If
    End Sub
    Private Sub FrmEmpEval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSEmpEval.tbl_Hrm_EmpEval_Month' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_EmpEval_MonthTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval_Month)
        If frmLogin.DeptID = 1 Or frmLogin.UserID = 18 Then
            CheckBox1.Visible = True
        Else : CheckBox1.Visible = False
        End If
        'TODO: This line of code loads data into the 'DSEmpEval.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSEmpEval.tbl_Acc_FinancialPeriod)

        Dim i As Integer = Now.Year
        While i >= 1970
            cmbYear.Items.Add(i)
            i -= 1
        End While
        cmbYear.SelectedIndex = 0
        cmbMonth.SelectedIndex = Now.Month - 1

        SelectFP()
        Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
        Me.Tbl_Hrm_Emp_InfoTableAdapter.FillBy(Me.DSEmpEval.tbl_Hrm_Emp_Info)
        MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)
    End Sub


    Private Sub FinancialPeriodComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancialPeriodComboBox.SelectedIndexChanged
        Dim Obj As New UtilityClass()
        If FinancialPeriodComboBox.SelectedValue <> Nothing Then
            If FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(cmbMonth.SelectedIndex + 1, cmbYear.SelectedItem) Then
            Else
                MsgBox("Invalid financial period as per selected month or year")
                FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(cmbMonth.SelectedIndex + 1, cmbYear.SelectedItem)
            End If
        End If
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        SelectFP()
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        SelectFP()
        If CheckBox2.Checked = True Then
            cardNoComboBox.Enabled = True
            Label2.Enabled = True
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillBy(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), cardNoComboBox.SelectedValue)
        Else
            cardNoComboBox.Enabled = False
            Label2.Enabled = False
            Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
        End If
    End Sub
    Private Sub SelectFP()
        Dim Obj As New UtilityClass()

        If cmbMonth.SelectedIndex >= 0 And cmbYear.SelectedIndex >= 0 Then
            If Obj.ReturnFP(cmbMonth.SelectedIndex + 1, cmbYear.SelectedItem) <> Nothing Then
                FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(cmbMonth.SelectedIndex + 1, cmbYear.SelectedItem)
            Else
                MsgBox("Selected year was beyond the running financial period")
                cmbYear.SelectedIndex = 0
                cmbMonth.SelectedIndex = Now.Month - 1
            End If
        End If
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Hrm_EmpEvalBindingSource.EndEdit()
            Me.Tbl_Hrm_EmpEvalTableAdapter.Update(Me.DSEmpEval.tbl_Hrm_EmpEval)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function GetLastDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtTo As New DateTime(dtDate.Year, dtDate.Month, 1)
        dtTo = dtTo.AddMonths(1)
        dtTo = dtTo.AddDays(-(dtTo.Day))
        Return dtTo
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SalaryMon As New Date(cmbYear.Text, cmbMonth.SelectedIndex + 1, 1)
        Dim LastDate As Date = GetLastDayOfMonth(SalaryMon)
        Dim StartDate As DateTime
        'Dim StartDate As Date = "01/06/2016"
        'Dim StartDate As Date = "01/12/2016"
        Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy(Me.DSEmpEval.tbl_Acc_Salary_Transactions, SalaryMon)
        Dim NoticeNo As Integer = 0
        Dim Latecoming As Integer = 0
        Dim Department As Integer = 0
        Dim Month As Integer = Me.cmbMonth.SelectedIndex + 1
        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You want to Load a record in Grid...? Wait For Few Minutes Its take some time to load data", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dgResult = Windows.Forms.DialogResult.Yes Then
            ToolStripProgressBar1.Maximum = Me.Tbl_Acc_Salary_TransactionsBindingSource.Count
            ToolStripProgressBar1.Value = 0
            For i As Integer = 0 To Me.Tbl_Acc_Salary_TransactionsBindingSource.Count - 1
                Dim Atd As Integer = 0
                Dim Absent As Decimal
                'If Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(31) = Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(22) Then
                '    Atd = 10
                'ElseIf Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(18) = 1 Then
                '    Atd = 5
                'Else
                '    Atd = 0
                'End If
                If Me.Tbl_Hrm_EmpEvalTableAdapter.EvalMonth(Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1)) Is Nothing Then
                    StartDate = Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item("DateOfJoning")
                    'Me.Tbl_Hrm_EmpEval_MonthTableAdapter.Insert(StartDate, Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1), Nothing, True)
                Else
                    StartDate = Me.Tbl_Hrm_EmpEvalTableAdapter.EvalMonth(Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1))
                End If


                Absent = Val(Me.Tbl_Hrm_EmpEvalTableAdapter.Absentees(Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1), StartDate, LastDate, "01/12/2017", "31/12/2017"))
                'Absent = Val(Me.Tbl_Hrm_EmpEvalTableAdapter.Absentees(Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1), StartDate, LastDate))
                Latecoming = Val(Me.Tbl_Hrm_EmpEvalTableAdapter.LateQuery1(Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1), StartDate, LastDate, "01/12/2017", "31/12/2017"))

                'Latecoming = Val(Me.Tbl_Hrm_EmpEvalTableAdapter.LateQuery(Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1), StartDate, LastDate))

                'Absent = Val(Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(21) + Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(15) + Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(14) + Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(13) + Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(12))
                Department = Val(Me.Tbl_Hrm_EmpEvalTableAdapter.DeptID(Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1)))
                'Absent = Val(Absent) ' total Absentees
                NoticeNo = Val(Me.Tbl_Hrm_EmpEvalTableAdapter.NoticesQuery(StartDate, LastDate, Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1)))
                'Me.Tbl_Hrm_EmpEvalTableAdapter.UpdateAbsent(Latecoming, NoticeNo, Absent, Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1), SalaryMon)

                Me.Tbl_Hrm_EmpEvalTableAdapter.Insert(Me.FinancialPeriodComboBox.Text, SalaryMon, Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(1), Atd, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, NoticeNo, Latecoming, Absent, Nothing, Me.DSEmpEval.tbl_Acc_Salary_Transactions.Rows(i).Item(35), False, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, True, Nothing, True, Nothing, Nothing, True, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Department, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                ToolStripProgressBar1.Value += 1
            Next
        End If
        MsgBox("Record Loaded Successfully")
        ToolStripProgressBar1.Value = 0
        Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
        CheckBox1.Checked = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Tbl_Hrm_EmpEvalDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Hrm_EmpEvalDataGridView.CellEnter
        Try
            Me.ValidateChildren()
            Me.Tbl_Hrm_EmpEvalBindingSource.EndEdit()
            Me.Tbl_Hrm_EmpEvalTableAdapter.Update(Me.DSEmpEval.tbl_Hrm_EmpEval)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Hrm_EmpEvalDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Hrm_EmpEvalDataGridView.DataError

    End Sub

    Private Sub Tbl_Hrm_EmpEvalDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Hrm_EmpEvalDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        End If
    End Sub


    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            cardNoComboBox.Enabled = True
            Label2.Enabled = True
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillBy(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), cardNoComboBox.SelectedValue)
        Else
            cardNoComboBox.Enabled = False
            Label2.Enabled = False
            Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
        End If
    End Sub

    Private Sub cardNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardNoComboBox.SelectedIndexChanged
        If CheckBox2.Checked = True Then
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillBy(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), cardNoComboBox.SelectedValue)
        ElseIf CheckBox2.Checked = False Then
            Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
        End If
    End Sub

    Private Sub Tbl_Hrm_EmpEvalDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Hrm_EmpEvalDataGridView.CellContentClick
        If e.ColumnIndex = 18 Then
            Try
                Me.ValidateChildren()
                Me.Tbl_Hrm_EmpEvalBindingSource.EndEdit()
                Me.Tbl_Hrm_EmpEvalTableAdapter.Update(Me.DSEmpEval.tbl_Hrm_EmpEval)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            cardNoComboBox.Focus()
        End If
    End Sub
End Class