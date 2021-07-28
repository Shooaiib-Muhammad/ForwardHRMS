Public Class frmPayRollShortLeave
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.Tbl_PayRoll_ShortLeavesTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, New System.Nullable(Of Date)(CType(LeaveDateToolStripTextBox.Text, Date)), New System.Nullable(Of Date)(CType(LeaveDate1ToolStripTextBox.Text, Date)))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim Time1, Time2 As DateTime
        Time1 = Format(CDate(DateTimePicker1.Text), "dd/MM/yyyy hh:mm tt")
        Time2 = Format(CDate(DateTimePicker2.Text), "dd/MM/yyyy hh:mm tt")

        Try
            Me.Tbl_PayRoll_ShortLeavesTableAdapter.Insert(Me.EmpIDLabel1.Text, Me.CardNoComboBox.Text, Time1.Date, Time1, Time2, ShiftIDLabel.Text, Nothing, 1049, Nothing)
        Catch ex As Exception

        End Try

        Try
            Me.Tbl_PayRoll_ShortLeavesTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker3.Value.Date, Me.DateTimePicker3.Value.Date)
        Catch ex As Exception

        End Try
        Me.Tbl_PayRoll_ShortLeavesBindingSource.MoveLast()
    End Sub

    Private Sub frmPayRollShortLeave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_HRM_Card2TableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Card2)
        Catch ex As Exception

        End Try


        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Leave_Reason' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Leave_ReasonTableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Leave_Reason)
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_PayRoll_ShortLeaves' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSPayRoll.tbl_HRM_Shift)

        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Card1' table. You can move, or remove it, as needed.
        Try
            'Me.Tbl_HRM_Card1TableAdapter.FillBy(Me.DSPayRoll.tbl_HRM_Card1)
        Catch ex As Exception

        End Try


        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Card' table. You can move, or remove it, as needed.

        Try
            Me.Tbl_HRM_CardTableAdapter.FillBy(Me.DSPayRoll.tbl_HRM_Card)
        Catch ex As Exception

        End Try
        Try
            Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, EmpIDLabel1.Text)
        Catch ex As Exception

        End Try
        Try
            Me.Tbl_PayRoll_ShortLeavesTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker3.Value.Date, Me.DateTimePicker3.Value.Date)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_HRM_CardBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_CardBindingSource.PositionChanged
        Try
            Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, EmpIDLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        Try
            Me.Tbl_PayRoll_ShortLeavesTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker3.Value.Date, Me.DateTimePicker3.Value.Date)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Tbl_PayRoll_ShortLeavesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_PayRoll_ShortLeavesDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.CellEnter
        If Tbl_PayRoll_ShortLeavesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
            Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(Tbl_PayRoll_ShortLeavesDataGridView(1, e.RowIndex).Value))
        Else
            'ClearLabels()

        End If
    End Sub

    Private Sub Tbl_PayRoll_ShortLeavesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_PayRoll_ShortLeavesDataGridView.DataError

    End Sub

    Private Sub ToolStripButton20_Click(sender As Object, e As EventArgs) Handles ToolStripButton20.Click
        Try
            Me.Validate()
            Me.Tbl_PayRoll_ShortLeavesBindingSource.EndEdit()
            Me.Tbl_PayRoll_ShortLeavesTableAdapter.Update(Me.DSPayRoll.tbl_PayRoll_ShortLeaves)
            Try
                Me.Tbl_PayRoll_ShortLeavesTableAdapter.Fill(Me.DSPayRoll.tbl_PayRoll_ShortLeaves, Me.DateTimePicker3.Value.Date, Me.DateTimePicker3.Value.Date)
            Catch ex As Exception

            End Try
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class