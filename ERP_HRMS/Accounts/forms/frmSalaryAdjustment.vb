Public Class frmSalaryAdjustment
    Private FP As String
    Private DtYear As Integer
    Private DtMonth As Integer

    Private Sub frmSalaryAdjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Card' table. You can move, or remove it, as needed.

        Me.Tbl_Hrm_Emp_Info_HTableAdapter.Fill(Me.DSSalaryAdjustment.tbl_Hrm_Emp_Info_H)
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)
        Dim Obj As New UtilityClass()
        DateTimePicker1.Value = DateAdd(DateInterval.Month, -1, Obj.ResetDate())
        DtYear = DateTimePicker1.Value.Year
        DtMonth = DateTimePicker1.Value.Month
        LoadEmpInfo()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are you sure, you want to save the adjustment", "Warning", MessageBoxButtons.YesNo)
        If dgResult = 6 Then
            Try
                'Me.Tbl_Acc_Salary_TransactionsTableAdapter.InsertQuery(Val(EmpIDLabel1.Text), Val(GrossSalaryLabel2.Text), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Val(MealAllowanceLabel2.Text), PaymentModeLabel1.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Val(lblFullDays.Text), Val(lblHalfDay.Text), Val(OTHours.Text), Val(lblOverTimePayable.Text), Nothing, Nothing, Val(lblTotalDay.Text), Val(lblMealPayable.Text), CalculatePerDaySal(Val(GrossSalaryLabel2.Text)), Val(lblDueSal.Text), Val(lblFinalSalary.Text), 0, Val(lblFinalSalary.Text), FP, "#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#", Nothing, Nothing, Nothing, Nothing, Nothing, Now.Date, "Adjustment", True, False)

                MsgBox("Record Saved")
                LoadEmpInfo()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Tbl_Hrm_Emp_Info_HBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_Emp_Info_HBindingSource.PositionChanged
        LoadEmpInfo()
    End Sub

    Private Sub LoadEmpInfo()
        'Load Employees Records
        ClearTextBoxes()
        AssignZerosToNewValues()

        If DtYear <> DateTimePicker1.Value.Year Then
            btnSave.Enabled = False
            Label12.Text = "Adjustment not recommended for the month you have selected, because adjustments only recommended for one month prior to the current month."
            TextBoxEnableDisable(False)
        Else
            If DtMonth <> DateTimePicker1.Value.Month Then
                btnSave.Enabled = False
                Label12.Text = "Adjustment not recommended for the month you have selected, because adjustments only recommended for one month prior to the current month."
                TextBoxEnableDisable(False)
            Else
                If Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DSSalaryAdjustment.tbl_Hrm_Emp_Info, Val(CardNoLabel1.Text)) = 1 Then
                    LoadRecord()
                Else
                    Label12.Text = "No Active Employee Found At Selected Card"
                    btnSave.Enabled = False
                    TextBoxEnableDisable(False)
                End If
            End If
        End If

    End Sub

    Private Sub LoadRecord()
        Dim Obj As New UtilityClass()
        FP = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        If FP <> "" Then
            btnSave.Enabled = True
            Label12.Text = ""
            If Me.Tbl_Acc_Salary_TransactionsTableAdapter.Fill(Me.DSSalaryAdjustment.tbl_Acc_Salary_Transactions, Val(EmpIDLabel1.Text), FP, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month) = 1 Then
                If Me.Tbl_Acc_Salary_TransactionsTableAdapter.FillBy(Me.DSSalaryAdjustment.tbl_Acc_Salary_Transactions, Val(EmpIDLabel1.Text), FP, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month) > 0 Then
                    Label12.ForeColor = Color.Red
                    Label12.Text = "Employees Adjustment have already been Calculated, so it is not recommended to calculate more than one adjustments in a single month"
                    btnSave.Enabled = False
                    TextBoxEnableDisable(False)
                    CardNoComboBox.Focus()
                Else
                    Me.Tbl_Acc_Salary_TransactionsTableAdapter.Fill(Me.DSSalaryAdjustment.tbl_Acc_Salary_Transactions, Val(EmpIDLabel1.Text), FP, DateTimePicker1.Value.Year, DateTimePicker1.Value.Month)
                    Label12.Text = ""
                    btnSave.Enabled = True
                    TextBoxEnableDisable(True)
                    FullDaysTextBox.Focus()
                    CalculateRecord()
                End If
            Else
                Label12.ForeColor = Color.Red
                Label12.Text = "Either Salary not calculated for The selected employee OR Salary calculated but not paid to the employee"
                btnSave.Enabled = False
                TextBoxEnableDisable(False)
                CardNoComboBox.Focus()
            End If
        Else
            btnSave.Enabled = False
            Label12.Text = "Financial Period not found in database for the Selected month, Please contact IT department to inform the situation"
        End If

    End Sub

    Private Sub TextBoxEnableDisable(ByVal Status As Boolean)
        FullDaysTextBox.Enabled = Status
        HalfDaysTextBox.Enabled = Status
        OverTimeHoursTextBox.Enabled = Status
        AmountTextBox.Enabled = Status
    End Sub

    Private Sub ClearTextBoxes()
        FullDaysTextBox.Clear()
        HalfDaysTextBox.Clear()
        OverTimeHoursTextBox.Clear()
        AmountTextBox.Clear()
    End Sub

    Private Sub AssignZerosToNewValues()
        If lblFullDays.Text = "" Then
            lblFullDays.Text = 0
        End If
        If lblHalfDay.Text = "" Then
            lblHalfDay.Text = 0
        End If
        If lblTotalDay.Text = "" Then
            lblTotalDay.Text = 0
        End If
        If OTHours.Text = "" Then
            OTHours.Text = 0
        End If
        If lblOverTimePayable.Text = "" Then
            lblOverTimePayable.Text = 0
        End If
        If lblMealPayable.Text = "" Then
            lblMealPayable.Text = 0
        End If
        If lblAmt.Text = "" Then
            lblAmt.Text = 0
        End If
        If lblFinalSalary.Text = "" Then
            lblFinalSalary.Text = 0
        End If
        If lblDueSal.Text = "" Then
            lblDueSal.Text = 0
        End If

    End Sub

    Private Sub CalculateRecord()
        'Calculates salary adjustments
        If (Val(lblFullDays.Text) + (Val(lblHalfDay.Text) / 2)) > 26 Then
            lblTotalDay.Text = 26
        Else
            lblTotalDay.Text = Val(lblFullDays.Text) + (Val(lblHalfDay.Text) / 2)
        End If

        lblMealPayable.Text = Math.Round(Val(MealAllowanceLabel2.Text) * Val(lblTotalDay.Text))
        lblOverTimePayable.Text = Math.Round((Val(OTHours.Text) * CalculatePerHourSalary(Val(GrossSalaryLabel2.Text))) * 2)
        lblDueSal.Text = Math.Round(Val(lblTotalDay.Text) * CalculatePerDaySal(Val(GrossSalaryLabel2.Text))) + Val(lblAmt.Text)
        lblFinalSalary.Text = Val(lblMealPayable.Text) + Val(lblOverTimePayable.Text) + Val(lblDueSal.Text)

        If Val(lblFinalSalary.Text) = 0 Then
            btnSave.Enabled = False
            Label12.Text = "Adjustment with 'Final Amount' zero is not recommended"
        Else
            btnSave.Enabled = True
            Label12.Text = ""
        End If
    End Sub

    Private Function CalculatePerDaySal(ByVal sal As Double) As Double
        Dim PerDaySal As Double = Math.Round(sal / 26, 2)
        Return PerDaySal
    End Function

    Private Function CalculatePerHourSalary(ByVal sal1 As Double) As Double
        Dim PerHalfHourSalary As Double = Math.Round(sal1 / 26 / 8, 2)
        Return PerHalfHourSalary
    End Function

    Private Sub FullDaysTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullDaysTextBox.TextChanged
        If FullDaysTextBox.Text = "" Then
            btnSave.Enabled = True
            Label12.Text = ""
            lblFullDays.Text = Math.Truncate(Val(FullDaysTextBox.Text))
            CalculateRecord()
        Else
            If IsNumeric(FullDaysTextBox.Text) = True Then
                btnSave.Enabled = True
                Label12.Text = ""
                lblFullDays.Text = Math.Truncate(Val(FullDaysTextBox.Text))
                CalculateRecord()
            Else
                btnSave.Enabled = False
                Label12.Text = "Error: Numeric Value Required"
                lblFullDays.Text = 0
                CalculateRecord()
            End If
        End If

    End Sub

    Private Sub HalfDaysTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HalfDaysTextBox.TextChanged
        If HalfDaysTextBox.Text = "" Then
            btnSave.Enabled = True
            Label12.Text = ""
            lblHalfDay.Text = Math.Truncate(Val(HalfDaysTextBox.Text))
            CalculateRecord()
        Else
            If IsNumeric(HalfDaysTextBox.Text) = True Then
                btnSave.Enabled = True
                Label12.Text = ""
                lblHalfDay.Text = Math.Truncate(Val(HalfDaysTextBox.Text))
                CalculateRecord()
            Else
                btnSave.Enabled = False
                Label12.Text = "Error: Numeric Value Required"
                lblHalfDay.Text = 0
                CalculateRecord()
            End If
        End If

    End Sub

    Private Sub OverTimeHoursTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverTimeHoursTextBox.TextChanged
        If OverTimeHoursTextBox.Text = "" Then
            btnSave.Enabled = True
            Label12.Text = ""
            OTHours.Text = Math.Round(Val(OverTimeHoursTextBox.Text), 1)
            CalculateRecord()
        Else
            If IsNumeric(OverTimeHoursTextBox.Text) = True Then
                btnSave.Enabled = True
                Label12.Text = ""
                OTHours.Text = Math.Round(Val(OverTimeHoursTextBox.Text), 1)
                CalculateRecord()
            Else
                btnSave.Enabled = False
                Label12.Text = "Error: Numeric Value Required"
                OTHours.Text = 0
                CalculateRecord()
            End If
        End If

    End Sub

    Private Sub AmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AmountTextBox.TextChanged
        If AmountTextBox.Text = "" Then
            btnSave.Enabled = True
            Label12.Text = ""
            lblAmt.Text = Math.Truncate(Val(AmountTextBox.Text))
            CalculateRecord()
        Else
            If IsNumeric(AmountTextBox.Text) = True Then
                btnSave.Enabled = True
                Label12.Text = ""
                lblAmt.Text = Math.Truncate(Val(AmountTextBox.Text))
                CalculateRecord()
            Else
                btnSave.Enabled = False
                Label12.Text = "Error: Numeric Value Required"
                lblAmt.Text = 0
                CalculateRecord()
            End If
        End If

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadEmpInfo()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadEmpInfo()
    End Sub

End Class