
Imports System.Net.Mail
Imports System.IO




Public Class frmBonusReports

    Private Sub frmBonusReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSBonus.tbl_Acc_BonusNo' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_BonusNoTableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusNo)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Bank' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BankTableAdapter.Fill(Me.DSHRM.tbl_HRM_Bank)
        'TODO: This line of code loads data into the 'DSDeptsForPayrollReport.tbl_Hrm_Designations' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_DesignationsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Designations)
        'TODO: This line of code loads data into the 'DSBonus.tbl_Acc_BonusTransactions' table. You can move, or remove it, as needed.
        'Me.tbl_Acc_BonusTransactionsTableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusTransactions)
        'TODO: This line of code loads data into the 'DSBonus.tbl_Acc_BonusNoSettings1' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_BonusNoSettings1TableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusNoSettings1)
        'Me.tbl_Acc_BonusTransactions1TableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusTransactions1)
        'Me.Tbl_Acc_BonusNoSettings1TableAdapter.Fill(Me.DSBonus.tbl_Acc_BonusNoSettings1)
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSBonus.tbl_Acc_FinancialPeriod)
        'Me.Tbl_Hrm_SubDept2TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept2)
        Me.Tbl_Hrm_SubDept1TableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_SubDept1)
        Me.Tbl_Hrm_DepartmentsTableAdapter.Fill(Me.DSDeptsForPayrollReport.tbl_Hrm_Departments)

        Try
            SelectFP()
        Catch ex As Exception

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
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton7.Checked = True Then
            Panel5.Enabled = True
        Else
            Panel5.Enabled = False

        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged

        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = False
        NameComboBox1.Enabled = False

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged

        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = True
        NameComboBox1.Enabled = False

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        DeptNameComboBox.Enabled = False
        NameComboBox1.Enabled = True
        NameComboBox.Enabled = False

    End Sub



    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'If RadioButton2.Checked = True Then
        '    BonusNoComboBox.Enabled = True
        'Else
        '    BonusNoComboBox.Enabled = False
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim Obj As New UtilityClass()

        Dim EmpStatus As String


        If RadioButton3.Checked = True Or RadioButton12.Checked = True Or RadioButton4.Checked = True Or RadioButton2.Checked = True Or RadioButton13.Checked = True Or RadioButton1.Checked = True Or RadioButton11.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus}=True"
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus}=False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_AllEmployees.EmpStatus}=True or  {View_Rpt_Acc_AllEmployees.EmpStatus}=False"
            End If
        End If




        If RadioButton12.Checked = True Then
            If ActiveBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus}=True"
            ElseIf NonActivrBtn.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus}=False"
            ElseIf AllEmp.Checked = True Then
                EmpStatus = "{View_Rpt_Acc_PreSalary.EmpStatus}=True or  {View_Rpt_Acc_AllEmployees.EmpStatus}=False"
            End If
        End If

        If RadioButton1.Checked = True Then ' Bonus Transaction Unpid 
            Path = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusTransUnpaid.rpt"
            If RadioButton14.Checked = True Then ' With Out payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "

                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range

                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                        Else
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DesignationID} = " & NameComboBox1.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        Else

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DesignationID} = " & NameComboBox1.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                        End If
                    End If


                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    End If
                End If
            ElseIf RadioButton15.Checked = True Then ' Payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "' "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "' "
                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range
                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    End If
                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = False And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    End If
                End If

            End If
        End If


        If RadioButton11.Checked = True Then ' Bonus Transaction Paid 
            Path = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusTranspaid.rpt"
            If RadioButton14.Checked = True Then ' With Out payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = True And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  "

                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range

                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  "
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  "
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "   And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                        Else
                            Filter = EmpStatus & "  And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                        Else

                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                        End If
                    End If


                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 "
                    End If
                End If
            ElseIf RadioButton15.Checked = True Then ' Payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "' "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "' "
                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range
                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    End If
                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.PaidUnpaidStatus} = true And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {tbl_Acc_BonusTransactions.DueAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    End If
                End If

            End If
        End If


        If RadioButton2.Checked = True Then ' Bonus Summary
            Path = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusSum.rpt"
            If RadioButton14.Checked = True Then ' With Out payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  "

                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range

                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  "
                        Else
                            Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  "
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = " & NameComboBox1.SelectedValue & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = " & NameComboBox1.SelectedValue & "  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                        End If
                    End If


                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 "
                    End If
                End If
            ElseIf RadioButton15.Checked = True Then ' Payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "' "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "' "
                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range
                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0  And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    End If
                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_BDistributionSum.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_BDistributionSum.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_BDistributionSum.DueAmt} > 0 And {View_Rpt_Acc_BDistributionSum.PaymentMode} = '" & ComboBox1.Text & "'"
                    End If
                End If

            End If
        End If




        If RadioButton3.Checked = True Then ' Bonus Receiving List 

            If CheckBox1.CheckState = CheckState.Checked Then
                Path = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusSlipnightShift.rpt"
            Else
                Path = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusSlipNormalShift.rpt"
            End If




            If RadioButton14.Checked = True Then ' With Out payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And {@RoundedAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "

                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range

                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        End If
                    End If


                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    End If
                End If
            ElseIf RadioButton15.Checked = True Then ' Payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "' "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "' "
                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range
                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    End If
                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    End If
                End If

            End If
        End If



        If RadioButton4.Checked = True Then ' Bonus Receiving Slip 
            Path = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusReceivingSlip.rpt"
            If RadioButton14.Checked = True Then ' With Out payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  @RoundedAmt > 0  "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "

                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range

                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  "
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then

                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        Else

                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                        End If
                    End If


                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 "
                    End If
                End If
            ElseIf RadioButton15.Checked = True Then ' Payment Mode 
                If RadioButton5.Checked = True Then ' All 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "' "
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "' "
                    End If
                ElseIf RadioButton6.Checked = True Then ' By card Range
                    If RadioButton7.Checked = True Then ' All Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton10.Checked = True ' Dept 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0  And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton9.Checked = True ' Section 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    ElseIf RadioButton8.Checked = True ' Desig 
                        If TextBox1.Text.Length = 0 Then
                            Flag = True
                        Else
                            Flag = False
                        End If
                        If TextBox2.Text = "" Then
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        Else
                            Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                        End If
                    End If
                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False
                    If RadioButton7.Checked = True Then ' All Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    ElseIf RadioButton8.Checked = True Then ' Designation
                        Filter = EmpStatus & " And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {@RoundedAmt} > 0 And {tbl_Acc_BonusTransactions.PaymentMode} = '" & ComboBox1.Text & "'"
                    End If
                End If

            End If
        End If


        If RadioButton13.Checked = True Then ' permanent Advance Ded Aganst Bonus
            Path = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusDistribution.rpt"

            If RadioButton5.Checked = True Then ' All 
                Flag = False
                If RadioButton7.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And {@NetAmount} > 0 "
                ElseIf RadioButton10.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                ElseIf RadioButton9.Checked = True Then ' Section 
                    Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID}= " & NameComboBox.SelectedValue & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                ElseIf RadioButton8.Checked = True Then ' Designation
                    Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""

                End If
            ElseIf RadioButton6.Checked = True Then ' By card Range

                If RadioButton7.Checked = True Then ' All Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    End If
                ElseIf RadioButton10.Checked = True ' Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    Else
                        Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    End If
                ElseIf RadioButton9.Checked = True ' Section 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    Else
                        Filter = EmpStatus & "  And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    End If
                ElseIf RadioButton8.Checked = True ' Desig 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then

                        Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                    Else

                        Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DesignationID} = '" & NameComboBox1.Text & "'  And   {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                    End If
                End If


            ElseIf RadioButton18.Checked = True Then ' By Branch 
                Flag = False
                If RadioButton7.Checked = True Then ' All Dept
                    Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & "  > 0"
                ElseIf RadioButton10.Checked = True Then ' main Dept
                    Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DeptID}= " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                ElseIf RadioButton9.Checked = True Then ' Section 
                    Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " "
                ElseIf RadioButton8.Checked = True Then ' Designation
                    Filter = EmpStatus & " And  {@AmountDedAsLTA} > 0 And {View_Rpt_Acc_AllEmployees.DesignationID}= " & NameComboBox1.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {@NetAmount} > 0 And {tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {tbl_Acc_BonusTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & ""
                End If
            End If


        End If


        If RadioButton12.Checked = True Then '  Bonus Bank Transfer 
            If BankNameComboBox.Text = "HABIB METROPOLITAN" Then
                Path = "\\dbserver\erpReports$\HRMS\Accounts\BonusListHabibMetro.rpt"
                If RadioButton5.Checked = True Then ' By month  
                    Flag = False
                    If RadioButton7.Checked = True Then   ' All Dept

                        Filter = EmpStatus & " And {View_Rpt_Acc_ActiveSalaryTransactions.PaymentMode} = 'Tranfer' And   {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation 
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    End If


                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False

                    If RadioButton7.Checked = True Then   ' All Dept

                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.DesignationID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf BankNameComboBox.Text = "MEEZAN BANK" Then
                Path = "\\dbserver\erpReports$\HRMS\Accounts\BonusListMeezanbank.rpt"
                If RadioButton5.Checked = True Then ' By month  
                    Flag = False
                    If RadioButton7.Checked = True Then   ' All Dept

                        Filter = EmpStatus & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation 
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    End If


                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False

                    If RadioButton7.Checked = True Then   ' All Dept

                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.DesignationID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    End If
                End If
            ElseIf BankNameComboBox.Text = "UNITED BANK LIMITED" Then
                Path = "\\dbserver\erpReports$\HRMS\Accounts\BonusListUBL.rpt"
                If RadioButton5.Checked = True Then ' By month  
                    Flag = False
                    If RadioButton7.Checked = True Then   ' All Dept

                        Filter = EmpStatus & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation 
                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.DesignationID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    End If


                ElseIf RadioButton18.Checked = True Then ' By Branch 
                    Flag = False

                    If RadioButton7.Checked = True Then   ' All Dept

                        Filter = EmpStatus & " And  {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""

                    ElseIf RadioButton10.Checked = True Then ' main Dept
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton9.Checked = True Then ' Section 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    ElseIf RadioButton8.Checked = True Then ' Designation 
                        Filter = EmpStatus & " And {View_Rpt_Acc_PreSalary.BranchID}= " & BranchNameComboBox.SelectedValue & " And   {View_Rpt_Acc_PreSalary.DesignationID} = " & NameComboBox.SelectedValue & "  And  {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' and {View_Rpt_Acc_ActiveSalaryTransactions.BonusNo} = " & BonusNoComboBox.SelectedValue & " And  {View_Rpt_Acc_PreSalary.BankID} = " & BankNameComboBox.SelectedValue & ""
                    End If
                End If
            End If

        End If








        If RadioButton16.Checked Then

            Dim dgResult As DialogResult
            Dim frmReportViewerObj As New frmReportViewer()
            Dim ExportFlag As Integer = 0
            Dim ErrorCount As Integer = 0
            Dim CardNo As Integer
            Dim ToAddress As String = Nothing
            Dim MangPath As String = "\\DBserver\ERPReports$\HRMS\Accounts\rptAccSalarySlip.rpt"
            Dim LabourPath As String = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusReceivingSlip.rpt"
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
            dgResult = MessageBox.Show("Are You sure you want to send salary slips via email?", "Exclamation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dgResult = DialogResult.Yes Then
                If Me.View_Rpt_Bonus_SlipEmailTableAdapter.Fill(Me.DSBonus.View_Rpt_Bonus_SlipEmail, FinancialPeriodComboBox.Text) > 0 Then
                    'FromTime = Now
                    'Me.View_Rpt_Acc_SalarySlipEmailBindingSource.Filter = "CardNo=158"
                    ToolStripProgressBar1.Maximum = View_Rpt_Bonus_SlipEmailBindingSource.Count - 1
                    For i As Integer = 0 To Me.DSBonus.View_Rpt_Bonus_SlipEmail.Count - 1
                        CardNo = Me.DSBonus.View_Rpt_Bonus_SlipEmail(i).Item(0)
                        Grade = Me.DSBonus.View_Rpt_Bonus_SlipEmail(i).Item("Grade").ToString.Trim

                        If Me.DSBonus.View_Rpt_Bonus_SlipEmail(i).Item(2) IsNot DBNull.Value Then
                            If Me.DSBonus.View_Rpt_Bonus_SlipEmail(i).Item(2) <> "" Then
                                Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {View_Rpt_Acc_ActiveSalaryTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} = " & CardNo & " And {View_Rpt_Acc_PreSalary.EmpStatus}"
                                ToAddress = Me.DSBonus.View_Rpt_Bonus_SlipEmail(i).Item(2)
                                If Grade = "E-1" Or Grade = "E-2" Or Grade = "E-3" Or Grade = "M-1" Or Grade = "M-2" Or Grade = "M-3" Or Grade = "M-4" Or Grade = "M-5" Then
                                    RptPath = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusReceivingSlip.rpt"
                                Else
                                    RptPath = "\\dbserver\erpReports$\HRMS\Accounts\rptBonusReceivingSlip.rpt"
                                End If
                                If frmReportViewerObj.ViewReport(0, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, RptPath, PDFPath, CardNo, Filter, Param) Then
                                    If SendMail(CardNo, PDFPath, ToAddress, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) Then
                                        LogFileWriter(PDFPath & "Email Log File Creation Date " & DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day, "Salary Slip of Card Number = " & CardNo & " Sent to Email Address = " & ToAddress & "")
                                    Else
                                        LogFileWriter(PDFPath & "Email Error Log Files" & DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day, "Card No. = " & CardNo & " Error Mail Sending Failed ")
                                        'MsgBox("Mail Sending Failed")
                                    End If
                                Else
                                    LogFileWriter(PDFPath & "Error Email Log File.txt" & DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day, "Card No. = " & CardNo & " Error Export to PDF Failed")
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
                        If frmReportViewerObj.ViewReport(1, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, "\\dbserver\erpReports$\HRMS\Accounts\rptBonusReceivingSlip.rpt", PDFPath, CardNo, Filter, Param) Then
                        Else
                            'MsgBox("Export to PDF Failed")
                        End If
                    End If
                    If LBArrList.Count > 0 Then
                        Filter = "{tbl_Acc_BonusTransactions.FinancialPeriod} = '" & FinancialPeriodComboBox.SelectedValue & "' And {tbl_Acc_BonusTransactions.TransactionState} = 'Normal' And Year({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Rpt_Acc_ActiveSalaryTransactions.SalaryMonth}) = " & DateTimePicker1.Value.Month & " And {View_Rpt_Acc_PreSalary.CardNo} IN [" & GetCardsInString1() & "]"
                        If frmReportViewerObj.ViewReport(1, DateTimePicker1.Value.Month, DateTimePicker1.Value.Year, "\\dbserver\erpReports$\HRMS\Accounts\rptBonusReceivingSlip.rpt", PDFPath, CardNo, Filter, Param) Then
                        Else
                            'MsgBox("Export to PDF Failed")
                        End If
                    End If
                    MsgBox("Done")



                End If

            End If
        End If














        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Flag = False
            Obj.LoadSalaryReports(Path, Filter, Param)
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
        Dim MailBody As String = "Please find attached here with salary slip of current month. Your Salary will be transferred in your account on dated " & DateTimePicker1.Value.Date & "." & vbCrLf & "In case of any query please contact Finance Department Forward Sports (Pvt) Ltd. at Extention Nos. 209, 210" & vbCrLf & "Regards," & vbCrLf & "Manager Finance, " & vbCrLf & "Forward Sports (Pvt) Ltd."
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
    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged, RadioButton14.CheckedChanged

    End Sub

    Private Sub RadioButton7_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        NameComboBox1.Enabled = False

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        DateTimePicker1.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            BankNameComboBox.Enabled = True
            GroupBox4.Enabled = False
            RadioButton6.Enabled = False
        Else
            BankNameComboBox.Enabled = False
            GroupBox4.Enabled = True
            RadioButton6.Enabled = True
        End If
        DateTimePicker1.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        DateTimePicker1.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            GroupBox4.Enabled = False
        Else
            GroupBox4.Enabled = True
        End If
        DateTimePicker1.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        'If RadioButton16.Checked = True Then
        '    GroupBox9.Visible = True
        'Else
        '    GroupBox9.Visible = False
        'End If
        DateTimePicker1.Visible = True
        Label5.Visible = True
    End Sub


End Class