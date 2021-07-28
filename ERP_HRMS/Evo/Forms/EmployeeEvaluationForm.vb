Imports System.Net.Mail
Imports System.IO
Public Class EmployeeEvaluationForm
    Dim flag As Boolean = True

    Private Function MyDate(ByVal MyMonth As Integer, ByVal MyYear As Integer)
        Dim MyDate1 As New Date(MyYear, MyMonth, 1)
        Return MyDate1
    End Function

    Private Sub EmployeeEvaluationForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        flag = False
    End Sub

    Private Sub EmployeeEvaluationForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down Then
            Tbl_Hrm_Emp_InfoBindingSource.Position += 1
        ElseIf e.KeyCode = Keys.Up Then
            Tbl_Hrm_Emp_InfoBindingSource.Position -= 1
        End If
    End Sub
    Private Sub EmployeeEvaluationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSEmpEval.View_Rpt_Acc_PreSalary' table. You can move, or remove it, as needed.
        Me.View_Rpt_Acc_PreSalaryTableAdapter.Fill(Me.DSEmpEval.View_Rpt_Acc_PreSalary)
        'TODO: This line of code loads data into the 'DSEmpEval.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSEmpEval.tbl_Acc_FinancialPeriod)
        Dim i As Integer = Now.Year
        While i >= 1970
            cmbYear.Items.Add(i)
            i -= 1
        End While
        cmbYear.SelectedIndex = 0
        cmbMonth.SelectedIndex = Now.Month - 1
        If frmLogin.DeptID = 1 Or frmLogin.UserID = 41 Or frmLogin.UserID = 52 Then ' Nida/Asaad
            CheckBox2.Enabled = True
            Button4.Visible = True
            Button5.Visible = True
            GroupBox6.Enabled = True
            LinkLabel1.Enabled = True

        Else
            LinkLabel1.Enabled = False
            GroupBox6.Enabled = False
            Button4.Visible = False
            CheckBox2.Enabled = False
            Button5.Visible = False
        End If
        If frmLogin.UserID = 1 Or frmLogin.UserID = 2 Then 'IT Admin
            TextBox1.ReadOnly = False
            TextBox2.ReadOnly = False
            TextBox3.ReadOnly = False
        Else
            TextBox1.ReadOnly = True
            TextBox2.ReadOnly = True
            TextBox3.ReadOnly = True
        End If
        SelectFP()
        deptData()
        Me.Tbl_Hrm_Emp_InfoTableAdapter.FillBy(Me.DSEmpEval.tbl_Hrm_Emp_Info)
        MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)
    End Sub
    Private Sub deptData()
        If frmLogin.DeptID = 1 Or frmLogin.UserID = 52 Or frmLogin.UserID = 41 Then 'Nida/Assad
            Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
        ElseIf frmLogin.UserID = 55 Then 'Hassan Idrees
            'Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 18) 'ME & CI
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByMECI(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'ME & CI
            'Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 11) 'ME & CI
        ElseIf frmLogin.UserID = 58 Then 'Salaman HR
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 7) 'HR
        ElseIf frmLogin.UserID = 59 Then 'Chief Accountant
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 1) 'Accounts
        ElseIf frmLogin.UserID = 62 Then 'Shazia
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 6) 'Imports/Export
        ElseIf frmLogin.UserID = 53 Then 'Development
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDev(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'Development
        ElseIf frmLogin.UserID = 56 Then 'Ihsan
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByVirtual(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'virtualization
        ElseIf frmLogin.UserID = 63 Then 'Sumera
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByCost(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'Cost
        ElseIf frmLogin.UserID = 54 Then 'Mohsin
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByGSD(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'GSD
        ElseIf frmLogin.UserID = 65 Then 'Salman
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 10) 'Material Management
        ElseIf frmLogin.UserID = 66 Then 'Audit Supervisor
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 3) 'Audit
        ElseIf frmLogin.UserID = 69 Then 'farhan
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 14) 'Production
            'Me.Tbl_Hrm_EmpEvalTableAdapter.FillByPlanning(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'Planning
        ElseIf frmLogin.UserID = 67 Then 'Nomia
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByLabel(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'Label
        ElseIf frmLogin.UserID = 33 Then 'Saga Shakeeb Zia
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillBySaga(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'Saga Shakeeb Zia
        ElseIf frmLogin.UserID = 68 Then 'Malik
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 2) 'Malik
        ElseIf frmLogin.UserID = 80 Then 'Raheel
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByCompliance(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'Bilal
        ElseIf frmLogin.UserID = 79 Then 'Saba 
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 13) 'Printing
        ElseIf frmLogin.UserID = 78 Then 'Cutting
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 4) 'Cutting
        ElseIf frmLogin.UserID = 82 Then 'Packing & Dispatch
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 12) 'Packing & Dispatch
        ElseIf frmLogin.UserID = 81 Then 'Quality Assurance
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByDept(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), 15) 'Quality Assurance
        ElseIf frmLogin.UserID = 83 Then 'Data Analysis
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillByData(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) 'Data Analysis
        End If
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
        loadData()

        If CheckBox2.Checked = True Then
            cardNoComboBox.Enabled = True
            Label2.Enabled = True
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillBy(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), cardNoComboBox.SelectedValue)
        Else
            cardNoComboBox.Enabled = False
            Label2.Enabled = False
            deptData()
            'Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
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
       
    End Sub
    Private Function GetLastDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtTo As New DateTime(dtDate.Year, dtDate.Month, 1)
        dtTo = dtTo.AddMonths(1)
        dtTo = dtTo.AddDays(-(dtTo.Day))
        Return dtTo
    End Function


    Private Sub Tbl_Hrm_EmpEvalDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            Me.ValidateChildren()
            Me.Tbl_Hrm_EmpEvalBindingSource.EndEdit()
            Me.Tbl_Hrm_EmpEvalTableAdapter.Update(Me.DSEmpEval.tbl_Hrm_EmpEval)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Hrm_EmpEvalDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub Tbl_Hrm_EmpEvalDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs)
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
            loadData()
            Me.Tbl_Hrm_EmpEvalTableAdapter.FillBy(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), cardNoComboBox.SelectedValue)
        ElseIf CheckBox2.Checked = False Then
            Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
            loadData()
        End If

    End Sub

    Private Sub Tbl_Hrm_EmpEvalDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
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



    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        If ComboBox2.SelectedIndex = 5 Then 'Always
            Label10.Text = 3

        ElseIf ComboBox2.SelectedIndex = 4 Then 'Mostly
            Label10.Text = 2
        ElseIf ComboBox2.SelectedIndex = 3 Then 'Often
            Label10.Text = 1
        ElseIf ComboBox2.SelectedIndex = 2 Then 'Rare
            Label10.Text = 0
        ElseIf ComboBox2.SelectedIndex = 1 Then 'Never
            Label10.Text = -1
        ElseIf ComboBox2.SelectedIndex = 0 Then 'Blank
            Label10.Text = ""
        End If
        Job_Knowledge()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = 1 Then 'Never
            Label11.Text = -1
        ElseIf ComboBox3.SelectedIndex = 2 Then 'Rare
            Label11.Text = 0
        ElseIf ComboBox3.SelectedIndex = 3 Then 'Often
            Label11.Text = 1
        ElseIf ComboBox3.SelectedIndex = 4 Then 'Mostly
            Label11.Text = 2
        ElseIf ComboBox3.SelectedIndex = 5 Then 'Always
            Label11.Text = 3
        ElseIf ComboBox3.SelectedIndex = 0 Then 'Blank
            Label11.Text = ""
        End If
        Job_Knowledge()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 1 Then
            Label12.Text = -1
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Label12.Text = 0
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Label12.Text = 1
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Label12.Text = 2
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Label12.Text = 3
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Label12.Text = ""
        End If
        Job_Knowledge()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedIndex = 1 Then
            Label13.Text = -1
        ElseIf ComboBox4.SelectedIndex = 2 Then
            Label13.Text = 0
        ElseIf ComboBox4.SelectedIndex = 3 Then
            Label13.Text = 1
        ElseIf ComboBox4.SelectedIndex = 4 Then
            Label13.Text = 2
        ElseIf ComboBox4.SelectedIndex = 5 Then
            Label13.Text = 3
        ElseIf ComboBox4.SelectedIndex = 0 Then
            Label13.Text = ""
        End If
        Job_Knowledge()
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox7.SelectedIndexChanged
        If ComboBox7.SelectedIndex = 1 Then
            Label15.Text = -1
        ElseIf ComboBox7.SelectedIndex = 2 Then
            Label15.Text = 0
        ElseIf ComboBox7.SelectedIndex = 3 Then
            Label15.Text = 1
        ElseIf ComboBox7.SelectedIndex = 4 Then
            Label15.Text = 2
        ElseIf ComboBox7.SelectedIndex = 5 Then
            Label15.Text = 3
        ElseIf ComboBox7.SelectedIndex = 0 Then
            Label15.Text = ""
        End If
        Tasks_Achievement()
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        If ComboBox6.SelectedIndex = 1 Then
            Label16.Text = -1
        ElseIf ComboBox6.SelectedIndex = 2 Then
            Label16.Text = 0
        ElseIf ComboBox6.SelectedIndex = 3 Then
            Label16.Text = 1
        ElseIf ComboBox6.SelectedIndex = 4 Then
            Label16.Text = 2
        ElseIf ComboBox6.SelectedIndex = 5 Then
            Label16.Text = 3
        ElseIf ComboBox6.SelectedIndex = 0 Then
            Label16.Text = ""
        End If
        Tasks_Achievement()
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        If ComboBox8.SelectedIndex = 1 Then
            Label17.Text = -1
        ElseIf ComboBox8.SelectedIndex = 2 Then
            Label17.Text = 0
        ElseIf ComboBox8.SelectedIndex = 3 Then
            Label17.Text = 1
        ElseIf ComboBox8.SelectedIndex = 4 Then
            Label17.Text = 2
        ElseIf ComboBox8.SelectedIndex = 5 Then
            Label17.Text = 3
        ElseIf ComboBox8.SelectedIndex = 0 Then
            Label17.Text = ""
        End If
        Tasks_Achievement()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.SelectedIndex = 1 Then
            Label18.Text = -1
        ElseIf ComboBox5.SelectedIndex = 2 Then
            Label18.Text = 0
        ElseIf ComboBox5.SelectedIndex = 3 Then
            Label18.Text = 1
        ElseIf ComboBox5.SelectedIndex = 4 Then
            Label18.Text = 2
        ElseIf ComboBox5.SelectedIndex = 5 Then
            Label18.Text = 3
        ElseIf ComboBox5.SelectedIndex = 0 Then
            Label18.Text = ""
        End If
        Tasks_Achievement()
    End Sub



    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        If ComboBox10.SelectedIndex = 1 Then
            Label7.Text = -1
        ElseIf ComboBox10.SelectedIndex = 2 Then
            Label7.Text = 0
        ElseIf ComboBox10.SelectedIndex = 3 Then
            Label7.Text = 1
        ElseIf ComboBox10.SelectedIndex = 4 Then
            Label7.Text = 2
        ElseIf ComboBox10.SelectedIndex = 5 Then
            Label7.Text = 3
        ElseIf ComboBox10.SelectedIndex = 0 Then
            Label7.Text = ""
        End If
        Job_Attitude()
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        If ComboBox12.SelectedIndex = 1 Then
            Label6.Text = -1
        ElseIf ComboBox12.SelectedIndex = 2 Then
            Label6.Text = 0
        ElseIf ComboBox12.SelectedIndex = 3 Then
            Label6.Text = 1
        ElseIf ComboBox12.SelectedIndex = 4 Then
            Label6.Text = 2
        ElseIf ComboBox12.SelectedIndex = 5 Then
            Label6.Text = 3
        ElseIf ComboBox12.SelectedIndex = 0 Then
            Label6.Text = ""
        End If
        Job_Attitude()
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        If ComboBox9.SelectedIndex = 1 Then
            Label4.Text = -1
        ElseIf ComboBox9.SelectedIndex = 2 Then
            Label4.Text = 0
        ElseIf ComboBox9.SelectedIndex = 3 Then
            Label4.Text = 1
        ElseIf ComboBox9.SelectedIndex = 4 Then
            Label4.Text = 2
        ElseIf ComboBox9.SelectedIndex = 5 Then
            Label4.Text = 3
        ElseIf ComboBox9.SelectedIndex = 0 Then
            Label4.Text = ""
        End If
        Job_Attitude()
    End Sub
    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        If ComboBox11.SelectedIndex = 1 Then 'Never
            Label31.Text = -1
        ElseIf ComboBox11.SelectedIndex = 2 Then 'Rare
            Label31.Text = 0
        ElseIf ComboBox11.SelectedIndex = 3 Then 'Often
            Label31.Text = 1
        ElseIf ComboBox11.SelectedIndex = 4 Then 'Mostly
            Label31.Text = 2
        ElseIf ComboBox11.SelectedIndex = 5 Then 'Always
            Label31.Text = 3
        ElseIf ComboBox11.SelectedIndex = 0 Then 'Blank
            Label31.Text = ""
        End If
        Job_Knowledge()
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox14.SelectedIndexChanged
        If ComboBox14.SelectedIndex = 1 Then 'Never
            Label35.Text = -1
        ElseIf ComboBox14.SelectedIndex = 2 Then 'Rare
            Label35.Text = 0
        ElseIf ComboBox14.SelectedIndex = 3 Then 'Often
            Label35.Text = 1
        ElseIf ComboBox14.SelectedIndex = 4 Then 'Mostly
            Label35.Text = 2
        ElseIf ComboBox14.SelectedIndex = 5 Then 'Always
            Label35.Text = 3
        ElseIf ComboBox14.SelectedIndex = 0 Then 'Blank
            Label35.Text = ""
        End If
        Job_Attitude()
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox15.SelectedIndexChanged
        If ComboBox15.SelectedIndex = 1 Then 'Never
            Label41.Text = -1
        ElseIf ComboBox15.SelectedIndex = 2 Then 'Rare
            Label41.Text = 0
        ElseIf ComboBox15.SelectedIndex = 3 Then 'Often
            Label41.Text = 1
        ElseIf ComboBox15.SelectedIndex = 4 Then 'Mostly
            Label41.Text = 2
        ElseIf ComboBox15.SelectedIndex = 5 Then 'Always
            Label41.Text = 3
        ElseIf ComboBox15.SelectedIndex = 0 Then 'Blank
            Label41.Text = ""
        End If
        Job_Attitude()
    End Sub

    Private Sub ComboBox13_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox13.SelectedIndexChanged
        If ComboBox13.SelectedIndex = 1 Then 'Never
            Label33.Text = -1
        ElseIf ComboBox13.SelectedIndex = 2 Then 'Rare
            Label33.Text = 0
        ElseIf ComboBox13.SelectedIndex = 3 Then 'Often
            Label33.Text = 1
        ElseIf ComboBox13.SelectedIndex = 4 Then 'Mostly
            Label33.Text = 2
        ElseIf ComboBox13.SelectedIndex = 5 Then 'Always
            Label33.Text = 3
        ElseIf ComboBox13.SelectedIndex = 0 Then 'Blank
            Label33.Text = ""
        End If
        Tasks_Achievement()
    End Sub

    Private Sub ComboBox16_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox16.SelectedIndexChanged
        If ComboBox16.SelectedIndex = 1 Then 'Never
            Label43.Text = -1
        ElseIf ComboBox16.SelectedIndex = 2 Then 'Rare
            Label43.Text = 0
        ElseIf ComboBox16.SelectedIndex = 3 Then 'Often
            Label43.Text = 1
        ElseIf ComboBox16.SelectedIndex = 4 Then 'Mostly
            Label43.Text = 2
        ElseIf ComboBox16.SelectedIndex = 5 Then 'Always
            Label43.Text = 3
        ElseIf ComboBox16.SelectedIndex = 0 Then 'Blank
            Label43.Text = ""
        End If
        Tasks_Achievement()
    End Sub

    Private Sub ComboBox17_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox17.SelectedIndexChanged
        If ComboBox17.SelectedIndex = 1 Then 'Never
            Label45.Text = -1
        ElseIf ComboBox17.SelectedIndex = 2 Then 'Rare
            Label45.Text = 0
        ElseIf ComboBox17.SelectedIndex = 3 Then 'Often
            Label45.Text = 1
        ElseIf ComboBox17.SelectedIndex = 4 Then 'Mostly
            Label45.Text = 2
        ElseIf ComboBox17.SelectedIndex = 5 Then 'Always
            Label45.Text = 3
        ElseIf ComboBox17.SelectedIndex = 0 Then 'Blank
            Label45.Text = ""
        End If
        Tasks_Achievement()
    End Sub

    Private Sub ComboBox21_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox21.SelectedIndexChanged
        If ComboBox21.SelectedIndex = 1 Then 'Never
            Label53.Text = -1
        ElseIf ComboBox21.SelectedIndex = 2 Then 'Rare
            Label53.Text = 0
        ElseIf ComboBox21.SelectedIndex = 3 Then 'Often
            Label53.Text = 1
        ElseIf ComboBox21.SelectedIndex = 4 Then 'Mostly
            Label53.Text = 2
        ElseIf ComboBox21.SelectedIndex = 5 Then 'Always
            Label53.Text = 3
        ElseIf ComboBox21.SelectedIndex = 0 Then 'Blank
            Label53.Text = ""
        End If
        Supervisory_skills()
    End Sub

    Private Sub ComboBox20_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox20.SelectedIndexChanged
        If ComboBox20.SelectedIndex = 1 Then 'Never
            Label54.Text = -1
        ElseIf ComboBox20.SelectedIndex = 2 Then 'Rare
            Label54.Text = 0
        ElseIf ComboBox20.SelectedIndex = 3 Then 'Often
            Label54.Text = 1
        ElseIf ComboBox20.SelectedIndex = 4 Then 'Mostly
            Label54.Text = 2
        ElseIf ComboBox20.SelectedIndex = 5 Then 'Always
            Label54.Text = 3
        ElseIf ComboBox20.SelectedIndex = 0 Then 'Blank
            Label54.Text = ""
        End If
        Supervisory_skills()
    End Sub

    Private Sub ComboBox22_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox22.SelectedIndexChanged
        If ComboBox22.SelectedIndex = 1 Then 'Never
            Label55.Text = -1
        ElseIf ComboBox22.SelectedIndex = 2 Then 'Rare
            Label55.Text = 0
        ElseIf ComboBox22.SelectedIndex = 3 Then 'Often
            Label55.Text = 1
        ElseIf ComboBox22.SelectedIndex = 4 Then 'Mostly
            Label55.Text = 2
        ElseIf ComboBox22.SelectedIndex = 5 Then 'Always
            Label55.Text = 3
        ElseIf ComboBox22.SelectedIndex = 0 Then 'Blank
            Label55.Text = ""
        End If
        Supervisory_skills()
    End Sub

    Private Sub ComboBox19_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox19.SelectedIndexChanged
        If ComboBox19.SelectedIndex = 1 Then 'Never
            Label56.Text = -1
        ElseIf ComboBox19.SelectedIndex = 2 Then 'Rare
            Label56.Text = 0
        ElseIf ComboBox19.SelectedIndex = 3 Then 'Often
            Label56.Text = 1
        ElseIf ComboBox19.SelectedIndex = 4 Then 'Mostly
            Label56.Text = 2
        ElseIf ComboBox19.SelectedIndex = 5 Then 'Always
            Label56.Text = 3
        ElseIf ComboBox19.SelectedIndex = 0 Then 'Blank
            Label56.Text = ""
        End If
        Supervisory_skills()
    End Sub

    Private Sub ComboBox18_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox18.SelectedIndexChanged
        If ComboBox18.SelectedIndex = 1 Then 'Never
            Label47.Text = -1
        ElseIf ComboBox18.SelectedIndex = 2 Then 'Rare
            Label47.Text = 0
        ElseIf ComboBox18.SelectedIndex = 3 Then 'Often
            Label47.Text = 1
        ElseIf ComboBox18.SelectedIndex = 4 Then 'Mostly
            Label47.Text = 2
        ElseIf ComboBox18.SelectedIndex = 5 Then 'Always
            Label47.Text = 3
        ElseIf ComboBox18.SelectedIndex = 0 Then 'Blank
            Label47.Text = ""
        End If
        Supervisory_skills()
    End Sub
    Private Sub Job_Knowledge()
        Label70.Text = Val(Label10.Text) + Val(Label11.Text) + Val(Label12.Text) + Val(Label13.Text) + Val(Label31.Text)
    End Sub
    Private Sub Job_Attitude()
        Label71.Text = Val(Label7.Text) + Val(Label6.Text) + Val(Label4.Text) + Val(Label35.Text) + Val(Label41.Text)
    End Sub
    Private Sub Tasks_Achievement()
        Label72.Text = Val(Label15.Text) + Val(Label16.Text) + Val(Label17.Text) + Val(Label18.Text) + Val(Label33.Text) + Val(Label43.Text) + Val(Label45.Text)
    End Sub
    Private Sub Supervisory_skills()
        Label73.Text = Val(Label53.Text) + Val(Label54.Text) + Val(Label55.Text) + Val(Label56.Text) + Val(Label47.Text)
    End Sub

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Obj As New UtilityClass
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim cardNo As Integer = CardLabel.Text
        'If cardNo = 46 Or cardNo = 52 Or cardNo = 60 Or cardNo = 117 Or cardNo = 121 Or cardNo = 128 Or cardNo = 210 Or cardNo = 218 Or cardNo = 236 Or cardNo = 242 Or cardNo = 274 Or cardNo = 280 Or cardNo = 290 Or cardNo = 313 Or cardNo = 334 Or cardNo = 335 Or cardNo = 408 Or cardNo = 492 Then
        '    Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpEval_Result_marksheet_Updated.rpt"
        'Else
        Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpEval_Result_marksheet_Updated_Staff.rpt"
        'End If
        'If GroupBox6.Enabled = True Then
        '    Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpEval_Result_marksheet_Updated.rpt"
        'Else
        '    Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpEval_Result_marksheet_Updated_Staff.rpt"
        'End If

        Filter = "{View_Rpt_HR_EmpEval_Grid.ETRID} = " & Val(CardNo1.Text) & ""
        Obj.LoadReports(Path, Filter, Param)
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Dim Obj As New UtilityClass
    '    Dim Filter As String = ""
    '    Dim Path As String = ""
    '    Dim Param As String = ""
    '    Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpEval_marksheet.rpt"
    '    Filter = "{View_Rpt_HR_EmpEval_Grid.ETRID} = " & Val(CardNo.Text) & ""
    '    Obj.LoadReports(Path, Filter, Param)
    'End Sub


    Private Sub Tbl_Hrm_EmpEvalBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_EmpEvalBindingSource.PositionChanged
        ResetRecord()

    End Sub
    Private Sub ResetRecord()
        If ComboBox2.Text = "" Then
            Label10.Text = 0
        End If
        'If Me.DSEmpEval.tbl_Hrm_EmpEval(0).Item(10) Is DBNull.Value Then
        '    MealAllowanceLabel2.Text = 0
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
            Dim dgResults As DialogResult
            dgResults = MsgBox("This Employee Evaluation Record going to be Submit after that you have not any right to edit . Are you want ready for that..?", MsgBoxStyle.YesNo)
            If dgResults = Windows.Forms.DialogResult.Yes Then

                'Me.Tbl_Hrm_EmpEvalTableAdapter.UpdateStatus(1, Val(CardNo1.Text))
                SubmitStatus()
                'SendMail()

            End If
        Else
            MsgBox("Remarks Must be enter before submit ")
        End If


    End Sub
    Private Function SendMail()
        Dim frmReportViewerObj As New frmReportViewer()
        Dim Bool As Boolean = True
        Dim Params As String = ""
        Dim filter As String = "{View_Rpt_HR_EmpEval_Grid.ETRID} = " & Val(CardNo1.Text) & ""
        Dim PDFPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Employees Evaluation PDF\"
        If Directory.Exists(PDFPath) Then
        Else
            Directory.CreateDirectory(PDFPath)
        End If
        If frmReportViewerObj.ViewReport(2, cmbMonth.SelectedIndex + 1, cmbYear.Text, "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpEval_Result_marksheet.rpt", PDFPath, CardLabel.Text, filter, Params) Then

            Dim EMailID As String = Me.View_Rpt_Acc_PreSalaryTableAdapter.EMailID(Val(CardLabel.Text))
            If EMailID = "" Then
                Return MsgBox("Email Does Not found,Please Contact IT Administrator")
                Exit Function

            End If
            Dim Remarks As String = InputBox("Enter The Remarks", "Reason")
            'Dim address As String = "Asad@fgear.pk"
            Dim address As String = EMailID
            Dim MailBody As String = "Dear " & FNameLabel1.Text & ", " & vbNewLine & "        Please review attach file which is Submitted by the Dept Head: " & frmLogin.UserName & " Date and Time: " & Now & " Remarks if any:" & Remarks & "" & vbNewLine & " " & vbCrLf & "In case of any query contact IT Department Forward Gear (Pvt) Ltd." & vbNewLine & " " & vbNewLine & "" & vbNewLine & " *Please do not reply to this message via E-mail. This address is automated and handled  by  Asad Ali IT Dept. Forward Gear."
            Try
                Dim MyMessage As New MailMessage("ERP Scheduled Mail <no-reply@fgear.pk>", address, "Employees Evaluation" & FNameLabel1.Text, MailBody)
                Dim MyAttachements As New Attachment(PDFPath & "Employees_Evaluation_Report_Card_No=" & CardLabel.Text & "_Month=" & cmbMonth.SelectedIndex + 1 & "_Year=" & cmbYear.Text & ".pdf")
                MyMessage.Attachments.Add(MyAttachements)
                'MyMessage.CC.Add(EMailID)
                Dim emailClient As New SmtpClient("192.168.20.200")
                emailClient.Send(MyMessage)

                MsgBox("Successfully Submitted")
                Bool = True
            Catch ex As Exception
                Bool = False
                MsgBox("Please Contact IT Administrator")
            End Try
            Return Bool
        Else
            MsgBox("Export to PDF Failed")
        End If
        Return Bool
    End Function
    Private Sub SubmitStatus()

        If Me.Tbl_Hrm_EmpEvalTableAdapter.CheckStatus(Val(CardNo1.Text)) = True Then
            Panel3.Enabled = False
            Button3.Enabled = False

        Else
            Panel3.Enabled = True
            Button3.Enabled = True

        End If
        'Dim returnNo As Integer = Me.Tbl_Hrm_EmpEvalTableAdapter.CheckKaizen(Val(CardNo.Text))
        If Me.Tbl_Hrm_EmpEvalTableAdapter.CheckKaizen(Val(CardNo1.Text)) > 0 Then
            Label21.BackColor = Color.Gainsboro
            Label22.BackColor = Color.Gainsboro
            Label30.BackColor = Color.Gainsboro
            Label39.BackColor = Color.Gainsboro
            Label36.BackColor = Color.Gainsboro
            Label24.BackColor = Color.Gainsboro
            Label32.BackColor = Color.Gainsboro
            Label51.BackColor = Color.Gainsboro

        Else
            Label21.BackColor = Color.Red
            Label22.BackColor = Color.Red
            Label30.BackColor = Color.Red
            Label39.BackColor = Color.Red
            Label36.BackColor = Color.Red
            Label24.BackColor = Color.Red
            Label32.BackColor = Color.Red
            Label51.BackColor = Color.Red

        End If

    End Sub
    Private Sub loadData()
        Dim SalaryMon As New Date(cmbYear.Text, cmbMonth.SelectedIndex + 1, 1)
        Dim LastDate As Date = GetLastDayOfMonth(SalaryMon)
        'Dim StartDate As New DateTime((Now.Date).Year, (Now.Date).Month, 1)
        Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval_Self_Assessment, SalaryMon, LastDate)

    End Sub

    Private Sub CardNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CardNo1.TextChanged
        SubmitStatus()
        'loadData()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SendMailToAll()
        If CheckBox2.Checked = True Then

            Me.Tbl_Hrm_EmpEvalTableAdapter.FillBy(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text), cardNoComboBox.SelectedValue)
        ElseIf CheckBox2.Checked = False Then
            Me.Tbl_Hrm_EmpEvalTableAdapter.Fill(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
        End If
    End Sub
    Private Function SendMailToAll()
        Dim frmReportViewerObj As New frmReportViewer()
        Dim Bool As Boolean = True
        Dim Params As String = ""
        Dim Path As String = ""
        'Dim filter1 As String = "{View_Rpt_HR_EmpEval_Grid.ETRID} = " & Val(CardNo.Text) & ""
        Dim PDFPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Employees Evaluation PDF\"
        If Directory.Exists(PDFPath) Then
        Else
            Directory.CreateDirectory(PDFPath)
        End If
        If Me.Tbl_Hrm_EmpEvalTableAdapter.FillByEmailID(Me.DSEmpEval.tbl_Hrm_EmpEval, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)) > 0 Then
            For i As Integer = 0 To Me.DSEmpEval.tbl_Hrm_EmpEval.Count - 1
                Dim CardNo As Integer = Me.DSEmpEval.tbl_Hrm_EmpEval(i).Item("CardNo")
                Dim Name As String = Me.DSEmpEval.tbl_Hrm_EmpEval(i).Item("Fname")
                Dim address As String = Me.DSEmpEval.tbl_Hrm_EmpEval(i).Item("EmailAddress")
                Dim filter As String = "{View_Rpt_HR_EmpEval_Grid.ETRID} = " & Val(Me.DSEmpEval.tbl_Hrm_EmpEval(i).Item("ETRID")) & ""
                'Me.Tbl_Hrm_EmpEvalTableAdapter.UpdateStatus(1, CardNo)
                If CardNo = 46 Or CardNo = 52 Or CardNo = 60 Or CardNo = 117 Or CardNo = 121 Or CardNo = 128 Or CardNo = 210 Or CardNo = 218 Or CardNo = 236 Or CardNo = 242 Or CardNo = 274 Or CardNo = 280 Or CardNo = 290 Or CardNo = 313 Or CardNo = 334 Or CardNo = 335 Or CardNo = 408 Or CardNo = 492 Then
                    Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpEval_Result_marksheet_Updated.rpt"
                Else
                    Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpEval_Result_marksheet_Updated_Staff.rpt"
                End If
                If frmReportViewerObj.ViewReport(2, cmbMonth.SelectedIndex + 1, cmbYear.Text, Path, PDFPath, CardNo, filter, Params) Then

                    'Dim EMailID As String = Me.View_Rpt_Acc_PreSalaryTableAdapter.EMailID(Val(CardLabel.Text))
                    'If EMailID = "" Then
                    '    Return MsgBox("Email Does Not found,Please Contact IT Administrator")
                    '    Exit Function
                    'End If
                    'Dim address As String = "Asad@fgear.pk"
                    Dim HtmlMessage As AlternateView = AlternateView.CreateAlternateViewFromString("<span style=""font-weight: bold; padding-left: 5px;padding-right:5px"">Dear " & Name & "</span> <br> &nbsp;&nbsp;&nbsp;&nbsp; Please review attach file which is Submitted by the Dept Head:" & frmLogin.UserName & " Date and Time: " & Now & "<br><br><br><span style=""font-weight: I; color:green;font-size:14; padding-left: 5px;padding-right:5px"">Please do not reply to this message via E-mail. This address is automated and handled  by  Asad Ali IT Dept. Forward Gear.</span>", Nothing, "text/html")

                    'Dim MailBody As String = "Dear " & Name & ", " & vbNewLine & "        Please review attach file which is Submitted by the Dept Head: " & frmLogin.UserName & " Date and Time: " & Now & " " & vbNewLine & " " & vbCrLf & "In case of any query contact IT Department Forward Gear (Pvt) Ltd." & vbNewLine & " " & vbNewLine & "" & vbNewLine & " *Please do not reply to this message via E-mail. This address is automated and handled  by  Asad Ali IT Dept. Forward Gear."
                    Try
                        Dim MyMessage As New MailMessage("ERP Scheduled Mail <no-reply@fgear.pk>", address, "Employees Evaluation" & Name, Nothing)
                        Dim MyAttachements As New Attachment(PDFPath & "Employees_Evaluation_Report_Card_No=" & CardNo & "_Month=" & cmbMonth.SelectedIndex + 1 & "_Year=" & cmbYear.Text & ".pdf")
                        MyMessage.AlternateViews.Add(HtmlMessage)
                        MyMessage.Attachments.Add(MyAttachements)
                        'MyMessage.CC.Add(EMailID)
                        Dim emailClient As New SmtpClient("192.168.20.200")
                        emailClient.Send(MyMessage)



                    Catch ex As Exception
                        Bool = False
                        MsgBox("Please Contact IT Administrator")
                    End Try

                Else
                    MsgBox("Export to PDF Failed")
                End If

            Next
            Me.Tbl_Hrm_EmpEvalTableAdapter.UpdateStatus(1, MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text))
            MsgBox("Successfully Submitted")
            Bool = True
        End If
        Return Bool
    End Function

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim Obj As New UtilityClass
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        'Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_Eval_Summary_Updated.rpt"
        Path = "\\server\hrms$\HR\Evaluation\EmpEval_Result_Summary.rpt"
        Filter = "{tbl_Hrm_EmpEval.EvalMonth} = Date(" & cmbYear.SelectedItem & ", " & cmbMonth.SelectedIndex + 1 & ", " & 1 & ")"
        'Filter = "{View_Rpt_HR_EmpEval_Grid.EvalMonth} = " & Val(CardNo.Text) & ""

        Obj.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub DSEmpEvalBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DSEmpEvalBindingSource.CurrentChanged

    End Sub


    Private Sub BindingNavigatorPositionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorPositionItem.Click

    End Sub

    Private Sub BindingNavigatorPositionItem_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BindingNavigatorPositionItem.TextChanged
        'loadData()
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox1.Leave
        Dim Remarks As String
        If TextBox1.Text.Length < 9 And flag = True Then
            If Label70.Text >= 13 Then
                Remarks = InputBox("Person has achieved excellent marks in JOB Knowledge. You are required to quote some example of his work as a supporting evidance or any other reason", "Reason", )
                'Dim Remarks As String = InputBox("Enter The Remarks", "Reason")
                Remarks = Trim(Remarks)
                If Remarks.ToString.Length > 10 Then
                    TextBox1.Text = Remarks
                Else
                    MsgBox("Must be 10 characters")
                    ComboBox11.SelectedIndex = 2
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Hrm_EmpEvalBindingSource.EndEdit()
            Me.Tbl_Hrm_EmpEvalTableAdapter.Update(Me.DSEmpEval.tbl_Hrm_EmpEval)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label70.Click

    End Sub

   
    Private Sub GroupBox3_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Leave
        Dim Remarks As String
        If TextBox3.Text.Length < 9 And flag = True Then
            If Label71.Text >= 13 Then
                Remarks = InputBox("Person has achieved excellent marks in Job Attitude. You are required to quote some example of his work as a supporting evidance or any other reason", "Reason", )
                'Dim Remarks As String = InputBox("Enter The Remarks", "Reason")
                Remarks = Trim(Remarks)
                If Remarks.ToString.Length > 10 Then
                    TextBox3.Text = Remarks
                Else
                    MsgBox("Must be 10 characters")
                    ComboBox15.SelectedIndex = 2
                End If
            End If
        End If
    End Sub

    Private Sub GroupBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Leave
        Dim Remarks As String
        If TextBox2.Text.Length < 9 And flag = True Then
            If Label72.Text >= 18 Then
                Remarks = InputBox("Person has achieved excellent marks in Tasks Achievement. You are required to quote some example of his work as a supporting evidance or any other reason", "Reason", )

                Remarks = Trim(Remarks)
                If Remarks.ToString.Length > 10 Then
                    TextBox2.Text = Remarks
                Else
                    MsgBox("Must be 10 characters")
                    ComboBox17.SelectedIndex = 2
                End If
            End If
        End If
    End Sub


    Private Sub GroupBox6_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox6.Leave
        Dim Remarks As String
        If TextBox4.Text.Length < 9 And flag = True Then
            If Label73.Text >= 13 Then
                Remarks = InputBox("Person has achieved excellent marks in Supervisory skills. You are required to quote some example of his work as a supporting evidance or any other reason", "Reason", )
                Remarks = Trim(Remarks)
                If Remarks.ToString.Length > 10 Then
                    TextBox4.Text = Remarks
                Else
                    MsgBox("Must be 10 characters")
                    ComboBox18.SelectedIndex = 2
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj As New UtilityClass
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Path = "\\server\myreports$\HRMSG\HR\EmployeesProfile\Rpt_HR_EmpDept_Progress.rpt"
        Filter = "{View_Rpt_HR_EmpEval_Grid.EvalMonth} = Date(" & cmbYear.SelectedItem & ", " & cmbMonth.SelectedIndex + 1 & ", " & 1 & ") And {View_Emp_Info_W_Pic.SectionID}  = " & Val(TextBox5.Text) & ""
        Obj.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class