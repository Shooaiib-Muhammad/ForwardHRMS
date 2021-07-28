Public Class frmEmpMealAtt


    Private Sub frmEmpMealAtt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMealAtt.tbl_Hrm_Emp_Info_H' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_Emp_Info_HTableAdapter.Fill(Me.DSMealAtt.tbl_Hrm_Emp_Info_H)
        Me.Tbl_HRM_Emp_Att_MealTableAdapter.Fill(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker1.Value.ToShortDateString())




    End Sub

    Private Sub CardNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If RadioButton2.Checked Then
            Try
                Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.CardNoComboBox.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf RadioButton3.Checked Then
            Try
                Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy1(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text, Me.CardNoComboBox.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'If RadioButton2.Checked = True Then
        '    FillByCard()
        'ElseIf RadioButton3.Checked = True Then
        '    FillByCardAndDate()
        'ElseIf RadioButton4.Checked = True Then
        '    FillByCardAndDateRange()
        'End If
    End Sub
    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSMealAtt.View_Rpt_Acc_AllEmployees, CType(EmpIDToolStripTextBox.Text, Integer))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub Tbl_Hrm_Emp_AttDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView.CellEnter
        If e.ColumnIndex = 2 Then
            If Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value = Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex - 1).Value
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value = Now.Date
                End Try
            End If
        End If
    End Sub
    Private Sub Tbl_Hrm_Emp_AttDataGridView_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView.RowEnter
        If Tbl_Hrm_Emp_AttDataGridView(3, e.RowIndex).Value IsNot DBNull.Value Then
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSMealAtt.View_Rpt_Acc_AllEmployees, Val(Tbl_Hrm_Emp_AttDataGridView(3, e.RowIndex).Value))
        End If
    End Sub

    Private Sub Tbl_Hrm_Emp_AttDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView.CellContentClick

    End Sub
    Private Sub Tbl_Hrm_Emp_AttDataGridView_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView.CellLeave
        Dim Count As Integer
        'Dim IPAddress As String = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        Dim FPeriod As String = Nothing
        If e.ColumnIndex > 1 Then
            If Me.Tbl_Hrm_Emp_AttDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
                Try
                    Count = Me.Tbl_Hrm_Emp_Info_HTableAdapter.FillBy(Me.DSMealAtt.tbl_Hrm_Emp_Info_H, Val(Me.Tbl_Hrm_Emp_AttDataGridView(1, e.RowIndex).Value))
                    If Count = 1 Then
                        If Me.Tbl_Hrm_Emp_AttDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                            Me.Tbl_Hrm_Emp_AttDataGridView(3, e.RowIndex).Value = Me.DSMealAtt.tbl_Hrm_Emp_Info_H(0).Item("EmpID")
                            Me.Tbl_Hrm_Emp_AttDataGridView(6, e.RowIndex).Value = Now
                        End If
                    Else
                        'MsgBox("No Employee Active At this Card No")
                        Me.Tbl_Hrm_Emp_AttDataGridView(0, e.RowIndex).Value = DBNull.Value
                        Me.Tbl_Hrm_Emp_AttDataGridView(1, e.RowIndex).Value = DBNull.Value
                        Me.Tbl_Hrm_Emp_AttDataGridView(2, e.RowIndex).Value = DBNull.Value
                        Exit Sub
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try

            End If
        ElseIf e.ColumnIndex = 4 Then
            'Me.Tbl_Hrm_Emp_AttDataGridView.Rows(0).Index = e.RowIndex + 1
        End If

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_Emp_Att_MealBindingSource.EndEdit()
            Me.Tbl_HRM_Emp_Att_MealTableAdapter.Update(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal)
            MsgBox("Record Saved Successfully")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EnableDisable(ByVal cd As Boolean, ByVal dt1 As Boolean, ByVal dt2 As Boolean)
        Me.DateTimePicker1.Enabled = dt1
        Me.CardNoComboBox.Enabled = cd
        Me.DateTimePicker2.Enabled = dt2
        Me.DateTimePicker3.Enabled = dt2
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        EnableDisable(False, True, False)
        Try

            Me.Tbl_HRM_Emp_Att_MealTableAdapter.Fill(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker1.Value.ToShortDateString())
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub ClearLabels()
        CardNoLabel1.Text = "" ' car5d 
        NameLabel1.Text = "" ' name 
        DesigNameLabel1.Text = "" ' Designation 
        DeptNameLabel1.Text = "" ' Dept
        EmpStatusCheckBox.CheckState = CheckState.Indeterminate
        SectionNameLabel1.Text = "" 'Section
        EmpPicPictureBox.Image = Nothing ' Image 
        Label10.Text = "" ' Grade


    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        EnableDisable(True, False, False)
        Try
            Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.CardNoComboBox.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        EnableDisable(True, False, True)
        Try
            Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy1(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker2.Value.ToShortDateString(), Me.DateTimePicker3.Value.ToShortDateString(), Me.CardNoComboBox.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub rbtShowByDateRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadionButton4.CheckedChanged
        EnableDisable(False, False, True)
        Try
            Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy2(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker2.Value.ToShortDateString(), Me.DateTimePicker3.Value.ToShortDateString())
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If RadioButton1.Checked Then
            EnableDisable(False, True, False)
            Try
                Me.Tbl_HRM_Emp_Att_MealTableAdapter.Fill(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker1.Value.ToShortDateString())
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If RadioButton3.Checked Then
            Try
                Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy1(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker2.Value.ToShortDateString(), Me.DateTimePicker3.Value.ToShortDateString(), Me.CardNoComboBox.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf RadionButton4.Checked Then
            Try
                Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy2(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker2.Value.ToShortDateString(), Me.DateTimePicker3.Value.ToShortDateString())
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        If RadioButton3.Checked Then
            Try
                Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy1(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker2.Value.ToShortDateString(), Me.DateTimePicker3.Value.ToShortDateString(), Me.CardNoComboBox.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf RadionButton4.Checked Then
            Try
                Me.Tbl_HRM_Emp_Att_MealTableAdapter.FillBy2(Me.DSMealAtt.tbl_HRM_Emp_Att_Meal, Me.DateTimePicker2.Value.ToShortDateString(), Me.DateTimePicker3.Value.ToShortDateString())
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Tbl_Hrm_Emp_AttDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Hrm_Emp_AttDataGridView.DataError

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click


    End Sub
End Class