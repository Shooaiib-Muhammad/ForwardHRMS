Public Class frmSelfAssessment

    Private Sub Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_EmpEval_Self_AssessmentBindingNavigatorSaveItem.Click
        Try
            UserIDLabel1.Text = Val(Label2.Text)
            Me.Validate()
            Me.Tbl_Hrm_EmpEval_Self_AssessmentBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSemployeeSelfAss)
            MsgBox("Record Saved Successfully")
            loadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSelfAssessment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSemployeeSelfAss.View_Rpt_Acc_AllEmployees' table. You can move, or remove it, as needed.
        Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSemployeeSelfAss.View_Rpt_Acc_AllEmployees)
        loadData()
        'TODO: This line of code loads data into the 'DSemployeeSelfAss.tbl_Hrm_EmpEval_Self_Assessment' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter.Fill(Me.DSemployeeSelfAss.tbl_Hrm_EmpEval_Self_Assessment)
        'Dim LastDate As Date = GetLastDayOfMonth(Now.Date)
        'Dim StartDate As New DateTime((Now.Date).Year, (Now.Date).Month, 1)
        loadData()
        'Me.View_EmpEval_Self_AssessmentTableAdapter.Fill(Me.DSemployeeSelfAss.View_EmpEval_Self_Assessment, StartDate, LastDate)
    End Sub
    Private Sub loadData()
        Dim LastDate As Date = GetLastDayOfMonth(Now.Date)
        Dim StartDate As New DateTime((Now.Date).Year, (Now.Date).Month, 1)
        Label2.Text = Val(frmLogin.UserID)
        If frmLogin.UserID = 57 Or frmLogin.DeptID = 1 Then
            Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter.Fill(Me.DSemployeeSelfAss.tbl_Hrm_EmpEval_Self_Assessment)
            Me.View_EmpEval_Self_AssessmentTableAdapter.Fill(Me.DSemployeeSelfAss.View_EmpEval_Self_Assessment, StartDate, LastDate)
        Else

            Me.Tbl_Hrm_EmpEval_Self_AssessmentTableAdapter.FillBy(Me.DSemployeeSelfAss.tbl_Hrm_EmpEval_Self_Assessment, Val(Label2.Text))
            Me.View_EmpEval_Self_AssessmentTableAdapter.FillBy(Me.DSemployeeSelfAss.View_EmpEval_Self_Assessment, StartDate, LastDate, Val(Label2.Text))


        End If
    End Sub


    Private Function GetLastDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtTo As New DateTime(dtDate.Year, dtDate.Month, 1)
        dtTo = dtTo.AddMonths(1)
        dtTo = dtTo.AddDays(-(dtTo.Day))
        Return dtTo
    End Function

    Private Sub ESALabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESALabel1.Click

    End Sub

    Private Sub ESALabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MaskedTextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox1.Enter
        If MaskedTextBox1.Text = "  /  /" Then

            MaskedTextBox1.Text = Now.Date

        End If
    End Sub

    Private Sub MaskedTextBox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.Enter
        If MaskedTextBox2.Text = "  /  /       :" Then

            MaskedTextBox2.Text = Now

        End If
    End Sub

    Private Sub EffectiveDateMaskedTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles EffectiveDateMaskedTextBox.Enter
        If EffectiveDateMaskedTextBox.Text = "  /  /" Then

            EffectiveDateMaskedTextBox.Text = Now.Date

        End If
    End Sub

   
    Private Sub EffectiveDateMaskedTextBox_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles EffectiveDateMaskedTextBox.MaskInputRejected

    End Sub



    'Private Sub Clock1_TimeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock1.TimeChanged
    '    Me.Clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)
    'End Sub

    Private Sub View_EmpEval_Self_AssessmentDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_EmpEval_Self_AssessmentDataGridView.CellContentClick

    End Sub

    Private Sub View_EmpEval_Self_AssessmentDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_EmpEval_Self_AssessmentDataGridView.DataError

    End Sub

   
    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
End Class