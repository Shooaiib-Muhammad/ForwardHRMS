Public Class frmDeductions

    Private Sub frmDeductions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Hrm_Emp_Info_H2TableAdapter.Fill(Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H2)
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.HRMDBDataSet1.tbl_Acc_FinancialPeriod)
        Me.Tbl_Hrm_Emp_Info_H1TableAdapter.Fill(Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H1)
        Me.Tbl_Acc_FinancialPeriodBindingSource.MoveLast()
        FillPAdvDeductions()
    End Sub

    Private Sub Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Acc_PAdvDeductionsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Acc_PAdvDeductionsBindingSource.EndEdit()
            Me.Tbl_Acc_PAdvDeductionsTableAdapter.Update(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Acc_PAdvDeductionsDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_PAdvDeductionsDataGridView.CellEnter
        Dim Obj As New UtilityClass
        If e.ColumnIndex = 3 Then
            If Tbl_Acc_PAdvDeductionsDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Acc_PAdvDeductionsDataGridView(3, e.RowIndex).Value = Now.Date
            End If
        ElseIf e.ColumnIndex = 4 Then
            If Tbl_Acc_PAdvDeductionsDataGridView(3, e.RowIndex).Value IsNot DBNull.Value Then
                Dim TransDate As Date = CType(Tbl_Acc_PAdvDeductionsDataGridView(3, e.RowIndex).Value, Date)
                Tbl_Acc_PAdvDeductionsDataGridView(4, e.RowIndex).Value = Obj.ReturnFP(TransDate.Month, TransDate.Year)
            End If
        ElseIf e.ColumnIndex = 5 Then
            If Tbl_Acc_PAdvDeductionsDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                Tbl_Acc_PAdvDeductionsDataGridView(5, e.RowIndex).ReadOnly = False
            Else
                Tbl_Acc_PAdvDeductionsDataGridView(5, e.RowIndex).ReadOnly = True
            End If
        End If
    End Sub

    Private Sub Tbl_Acc_PAdvDeductionsDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Acc_PAdvDeductionsDataGridView.DataError

    End Sub

    Private Sub Tbl_Acc_PAdvDeductionsDataGridView_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_PAdvDeductionsDataGridView.CellLeave
        Dim Ret As Integer
        If e.ColumnIndex = 2 Then
            Ret = Me.View_Rpt_Acc_PAdvLedgerTableAdapter.Fill(Me.DSLongTermAdv.View_Rpt_Acc_PAdvLedger, Tbl_Acc_PAdvDeductionsDataGridView(1, e.RowIndex).Value)
            If Ret = 0 Then
                'MsgBox("There is no Advance for The Selected Employee")
                Tbl_Acc_PAdvDeductionsDataGridView(0, e.RowIndex).Value = DBNull.Value
                Tbl_Acc_PAdvDeductionsDataGridView(1, e.RowIndex).Value = DBNull.Value
                Tbl_Acc_PAdvDeductionsDataGridView(2, e.RowIndex).Value = DBNull.Value
                Tbl_Acc_PAdvDeductionsDataGridView(3, e.RowIndex).Value = DBNull.Value
            Else
                If Me.DSLongTermAdv.View_Rpt_Acc_PAdvLedger(0).Item(4) = 0 Then
                    MsgBox("The Selected Employee have Paid All of his/her Advance Amount")
                    Tbl_Acc_PAdvDeductionsDataGridView(0, e.RowIndex).Value = DBNull.Value
                    Tbl_Acc_PAdvDeductionsDataGridView(1, e.RowIndex).Value = DBNull.Value
                    Tbl_Acc_PAdvDeductionsDataGridView(2, e.RowIndex).Value = DBNull.Value
                    Tbl_Acc_PAdvDeductionsDataGridView(3, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If

    End Sub

    Private Sub Tbl_Acc_PAdvDeductionsDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_PAdvDeductionsDataGridView.RowEnter
        If Tbl_Acc_PAdvDeductionsDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.HRMDBDataSet1.View_Rpt_Acc_AllEmployees, Tbl_Acc_PAdvDeductionsDataGridView(1, e.RowIndex).Value)
            Me.Tbl_Acc_PAdvDeductions1TableAdapter.Fill(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions1, Tbl_Acc_PAdvDeductionsDataGridView(1, e.RowIndex).Value)
            Me.Tbl_Acc_PermanentAdvances1TableAdapter.Fill(Me.DSLongTermAdv.tbl_Acc_PermanentAdvances1, Tbl_Acc_PAdvDeductionsDataGridView(1, e.RowIndex).Value)
            Label10.Text = Val(AdvSumLabel1.Text) - Val(TotalDedLabel1.Text)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Panel4.Enabled = False
            FillPAdvDeductions()
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Panel4.Enabled = True
            Label4.Enabled = True
            CardNoComboBox.Enabled = True

            Label6.Enabled = False
            DateTimePicker1.Enabled = False
            Label7.Enabled = False
            FinancialPeriodComboBox.Enabled = False
            Label5.Enabled = False
            DateTimePicker2.Enabled = False
            FillByPAdvDeductions()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Panel4.Enabled = True
            Label6.Enabled = True
            DateTimePicker1.Enabled = True
            Label5.Enabled = True
            DateTimePicker2.Enabled = True

            Label4.Enabled = False
            CardNoComboBox.Enabled = False
            Label7.Enabled = False
            FinancialPeriodComboBox.Enabled = False
            FillBy1PAdvDeductions()
        End If
    End Sub

    Private Sub FillPAdvDeductions()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.Fill(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FillByPAdvDeductions()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions, CardNoComboBox.SelectedValue) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FillBy1PAdvDeductions()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy1(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions, DateTimePicker1.Value.Date, DateTimePicker2.Value.Date) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FillByFP()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy2(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions, FinancialPeriodComboBox.SelectedValue) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByDescNormal()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy3(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByDescClosing()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy4(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByDescALeaves()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy5(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByDescDedAsBonus()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy6(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByDescZeroDed()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy7(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub FilterByDescOthers()
        If Me.Tbl_Acc_PAdvDeductionsTableAdapter.FillBy8(Me.DSLongTermAdv.tbl_Acc_PAdvDeductions) > 0 Then
        Else
            ClearLabels()
        End If
    End Sub

    Private Sub CardNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardNoComboBox.SelectedIndexChanged
        FillByPAdvDeductions()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        FillBy1PAdvDeductions()
    End Sub

    Private Sub ClearLabels()
        CardNoLabel1.Text = ""
        NameLabel1.Text = ""
        DesigNameLabel1.Text = ""
        DeptNameLabel1.Text = ""
        AdvSumLabel1.Text = ""
        TotalDedLabel1.Text = ""
        Label10.Text = ""
        EmpStatusCheckBox.CheckState = CheckState.Indeterminate
        PictureBox1.Image = Nothing

    End Sub

    Private Sub FinancialPeriodComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancialPeriodComboBox.SelectedIndexChanged
        FillByFP()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Panel4.Enabled = True
            Label7.Enabled = True
            FinancialPeriodComboBox.Enabled = True

            Label4.Enabled = False
            CardNoComboBox.Enabled = False
            Label6.Enabled = False
            DateTimePicker1.Enabled = False
            Label5.Enabled = False
            DateTimePicker2.Enabled = False
            FillByFP()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            Panel4.Enabled = False
            FilterByDescNormal()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Panel4.Enabled = False
            FilterByDescClosing()
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            Panel4.Enabled = False
            FilterByDescALeaves()
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            Panel4.Enabled = False
            FilterByDescDedAsBonus()
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked Then
            Panel4.Enabled = False
            FilterByDescZeroDed()
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked Then
            Panel4.Enabled = False
            FilterByDescOthers()
        End If
    End Sub

    Private Sub Tbl_Acc_PAdvDeductionsBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles Tbl_Acc_PAdvDeductionsBindingNavigator.RefreshItems

    End Sub
End Class