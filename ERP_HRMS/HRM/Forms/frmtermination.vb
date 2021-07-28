Public Class frmtermination
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmtermination_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
    Private Sub Load()
        Try
            Me.View_All_Terminnated_EmployeeTableAdapter.Fill(Me.Termination.View_All_Terminnated_Employee, New System.Nullable(Of Date)(CType(DateTimePicker1.Text, Date)), New System.Nullable(Of Date)(CType(DateTimePicker2.Text, Date)))
        Catch ex As System.Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Load()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Load()
    End Sub

    Private Sub View_All_Terminnated_EmployeeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_All_Terminnated_EmployeeDataGridView.CellContentClick
        If e.ColumnIndex = 16 Then
            If Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value Is DBNull.Value Then
                Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value = True
                Me.View_All_Terminnated_EmployeeDataGridView.Item(17, e.RowIndex).Value = Now.Date
            Else
                If Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value = False Then
                    Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value = True
                    Me.View_All_Terminnated_EmployeeDataGridView.Item(17, e.RowIndex).Value = Now.Date
                Else
                    Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value = False
                    Me.View_All_Terminnated_EmployeeDataGridView.Item(17, e.RowIndex).Value = DBNull.Value
                End If
            End If

        End If
        If e.ColumnIndex = 18 Then
            Dim path, Filter As String
            Dim obj As New Class_Utility
            path = "" & frmLogin.ReportsPath & "\Accounts\Terminationletter.rpt"
            Filter = "{View_Rpt_Acc_InActiveEmployees.CardNo} = " & Me.View_All_Terminnated_EmployeeDataGridView.Item(1, e.RowIndex).Value & ""
            obj.LoadReports(path, Filter, "")
        End If
    End Sub

    Private Sub View_All_Terminnated_EmployeeDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles View_All_Terminnated_EmployeeDataGridView.CellEnter


        If e.ColumnIndex = 16 Then
            If Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value Is DBNull.Value Then
                Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value = True
                Me.View_All_Terminnated_EmployeeDataGridView.Item(17, e.RowIndex).Value = Now.Date
            Else
                If Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value = False Then
                    Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value = True
                    Me.View_All_Terminnated_EmployeeDataGridView.Item(17, e.RowIndex).Value = Now.Date
                Else
                    Me.View_All_Terminnated_EmployeeDataGridView.Item(16, e.RowIndex).Value = False
                    Me.View_All_Terminnated_EmployeeDataGridView.Item(17, e.RowIndex).Value = DBNull.Value
                End If
            End If
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Validate()
            Me.View_All_Terminnated_EmployeeBindingSource.EndEdit()
            Me.View_All_Terminnated_EmployeeTableAdapter.Update(Termination.View_All_Terminnated_Employee)
            Load()
            MsgBox("Payment Status Has Been Active of Selected Employee")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_All_Terminnated_EmployeeBindingSource.Filter = "Cardno=" & Me.ToolStripTextBox1.Text & ""
            Me.ContextMenuStrip1.Hide()
        End If
    End Sub



    Private Sub View_All_Terminnated_EmployeeDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_All_Terminnated_EmployeeDataGridView.DataError

    End Sub

    Private Sub frmtermination_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control And e.KeyCode = Keys.S Then
            Dim k As Int16 = Me.View_All_Terminnated_EmployeeBindingSource.Position
            Try
                Me.Validate()
                Me.View_All_Terminnated_EmployeeBindingSource.EndEdit()
                Me.View_All_Terminnated_EmployeeTableAdapter.Update(Termination.View_All_Terminnated_Employee)
                Load()
                Me.View_All_Terminnated_EmployeeBindingSource.Position = k
                MsgBox("Payment Status Has Been Active of Selected Employee")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RemoveFilterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveFilterToolStripMenuItem1.Click
        Me.View_All_Terminnated_EmployeeBindingSource.RemoveFilter()
    End Sub

    Private Sub ActivePaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivePaymentToolStripMenuItem.Click
        Me.View_All_Terminnated_EmployeeBindingSource.Filter = "PaymentStatus=" & True & ""
        Me.ContextMenuStrip1.Hide()
    End Sub

    Private Sub InActivePaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InActivePaymentToolStripMenuItem.Click
        Me.View_All_Terminnated_EmployeeBindingSource.Filter = "PaymentStatus=" & False & ""
        Me.ContextMenuStrip1.Hide()
    End Sub

    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click

    End Sub

    Private Sub ToolStripTextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.View_All_Terminnated_EmployeeBindingSource.Filter = "DeptName Like '%" & Me.ToolStripTextBox2.Text & "%'"
            ToolStripTextBox2.Text = ""
            Me.ContextMenuStrip1.Hide()
        End If
    End Sub
End Class