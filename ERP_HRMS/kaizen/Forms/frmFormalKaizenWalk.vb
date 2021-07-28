Public Class frmFormalKaizenWalk

    Private Sub Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_Formal_Kaizen_HeadBindingNavigatorSaveItem.Click
        Try
            UserIDLabel1.Text = Val(Label2.Text)
            Me.Validate()
            Me.Tbl_Hrm_Formal_Kaizen_HeadBindingSource.EndEdit()
            Me.Tbl_Hrm_Formal_Kaizen_HeadTableAdapter.Update(Me.DataSet6.tbl_Hrm_Formal_Kaizen_Head)
            MsgBox("Record Saved")
            loadData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmFormalKaizenWalk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet6.View_Rpt_Acc_PreSalary' table. You can move, or remove it, as needed.
        Me.View_Rpt_Acc_PreSalaryTableAdapter.Fill(Me.DataSet6.View_Rpt_Acc_PreSalary)
        'TODO: This line of code loads data into the 'DataSet6.View_Rpt_Acc_AllEmployees_ActiveSalary' table. You can move, or remove it, as needed.
        'Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.Fill(Me.DataSet6.View_Rpt_Acc_AllEmployees_ActiveSalary)
        'TODO: This line of code loads data into the 'DataSet6.tbl_Hrm_Formal_Kaizen_Detail' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_Formal_Kaizen_DetailTableAdapter.Fill(Me.DataSet6.tbl_Hrm_Formal_Kaizen_Detail)
        'TODO: This line of code loads data into the 'DataSet6.tbl_Hrm_Formal_Kaizen_Head' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_Formal_Kaizen_DetailTableAdapter.Fill(Me.DataSet6.tbl_Hrm_Formal_Kaizen_Detail)
        loadData()
    End Sub
    Private Sub loadData()
        If frmLogin.UserID = 39 Or frmLogin.DeptID = 1 Then
            Me.Tbl_Hrm_Formal_Kaizen_HeadTableAdapter.Fill(Me.DataSet6.tbl_Hrm_Formal_Kaizen_Head)
            'StatusComboBox.Enabled = True
        Else
            Label2.Text = Val(frmLogin.UserID)
            Me.Tbl_Hrm_Formal_Kaizen_HeadTableAdapter.FillBy(Me.DataSet6.tbl_Hrm_Formal_Kaizen_Head, Val(Label2.Text))
            'StatusComboBox.Enabled = False
        End If
    End Sub

    Private Sub Tbl_Hrm_Formal_Kaizen_DetailDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Tbl_Hrm_Formal_Kaizen_DetailDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

  

    Private Sub Tbl_Hrm_Formal_Kaizen_DetailDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.S And e.Control Then
            Try
                Me.Validate()
                Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource.EndEdit()
                Me.Tbl_Hrm_Formal_Kaizen_DetailTableAdapter.Update(Me.DataSet6.tbl_Hrm_Formal_Kaizen_Detail)
                MsgBox("Record Saved")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    'Private Sub Tbl_Hrm_Formal_Kaizen_DetailDataGridView_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If Tbl_Hrm_Formal_Kaizen_DetailDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
    '        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.FillBy(Me.DataSet6.View_Rpt_Acc_AllEmployees_ActiveSalary, Val(Tbl_Hrm_Formal_Kaizen_DetailDataGridView(2, e.RowIndex).Value))
    '    Else
    '        ClearLabels()
    '    End If
    'End Sub
    'Private Sub ClearLabels()
    '    CardNoLabel1.Text = ""
    '    NameLabel1.Text = ""
    '    DesigNameLabel1.Text = ""
    '    DeptNameLabel1.Text = ""
    '    EmpStatusCheckBox.CheckState = CheckState.Indeterminate
    'End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.Tbl_Hrm_Formal_Kaizen_DetailBindingSource.EndEdit()
            Me.Tbl_Hrm_Formal_Kaizen_DetailTableAdapter.Update(Me.DataSet6.tbl_Hrm_Formal_Kaizen_Detail)
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        'Try
        '    FKWIDLabel1.Text = Val(Tbl_Hrm_Formal_Kaizen_HeadTableAdapter.Max + 1)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    'Private Sub Clock1_TimeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock1.TimeChanged
    '    Me.Clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)
    'End Sub
End Class