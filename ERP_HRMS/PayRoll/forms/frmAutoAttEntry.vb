Public Class frmAutoAttEntry
    Private Sub frmAutoAttEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAutoAtt.tbl_Hrm_Emp_Att1' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_Emp_Att1TableAdapter.Fill(Me.DSAutoAtt.tbl_Hrm_Emp_Att1)
        'TODO: This line of code loads data into the 'DSAttAdj.View_Adj_Att' table. You can move, or remove it, as needed.
        Try
            Me.View_Adj_AttTableAdapter.Fill(Me.DSAttAdj.View_Adj_Att, Format(Me.StrtTime.Value, "dd/MM/yy"), Format(Me.EndTime.Value, "dd/MM/yy"))
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DSAttAdj.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSAttAdj.tbl_HRM_Shift)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub View_Adj_AttDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_Adj_AttDataGridView.CellContentClick

    End Sub

    Private Sub View_Adj_AttDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_Adj_AttDataGridView.DataError

    End Sub

    Private Sub StrtTime_ValueChanged(sender As Object, e As EventArgs) Handles StrtTime.ValueChanged
        Try
            Me.View_Adj_AttTableAdapter.Fill(Me.DSAttAdj.View_Adj_Att, Format(Me.StrtTime.Value, "dd/MM/yy"), Format(Me.EndTime.Value, "dd/MM/yy"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EndTime_ValueChanged(sender As Object, e As EventArgs) Handles EndTime.ValueChanged
        Try
            Me.View_Adj_AttTableAdapter.Fill(Me.DSAttAdj.View_Adj_Att, Format(Me.StrtTime.Value, "dd/MM/yy"), Format(Me.EndTime.Value, "dd/MM/yy"))
        Catch ex As Exception

        End Try
    End Sub
    Dim obj As New UtilityClass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FP As String
        Dim dgResult As DialogResult = MessageBox.Show("Are You sure you want to save Auto Attendance ? As well you have selected proper Date Range.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dgResult = 6 Then

            For i As Int16 = 0 To Me.View_Adj_AttDataGridView.RowCount - 1
                Me.Tbl_Hrm_Emp_Att1TableAdapter.Insert(View_Adj_AttDataGridView(8, i).Value, View_Adj_AttDataGridView(0, i).Value, View_Adj_AttDataGridView(11, i).Value, View_Adj_AttDataGridView(14, i).Value, False, View_Adj_AttDataGridView(12, i).Value, View_Adj_AttDataGridView(4, i).Value, View_Adj_AttDataGridView(5, i).Value, View_Adj_AttDataGridView(6, i).Value, View_Adj_AttDataGridView(7, i).Value, View_Adj_AttDataGridView(16, i).Value.ToString, Now.Date, Nothing)
            Next
            Try
                Me.View_Adj_AttTableAdapter.Fill(Me.DSAttAdj.View_Adj_Att, Format(Me.StrtTime.Value, "dd/MM/yy"), Format(Me.EndTime.Value, "dd/MM/yy"))
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class