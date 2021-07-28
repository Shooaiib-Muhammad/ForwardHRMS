Public Class frmConAttCorrection
    Private Sub frmAttCorrection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAttCorection.View_Att' table. You can move, or remove it, as needed.
        Try
            Me.View_AttTableAdapter.FillBy(Me.DSAttCorection.View_Att, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Me.View_AttTableAdapter.FillBy(Me.DSAttCorection.View_Att, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Try
            Me.View_AttTableAdapter.FillBy(Me.DSAttCorection.View_Att, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub View_AttDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_AttDataGridView.CellContentClick
        If e.ColumnIndex = 6 Then
            Dim dgResult As DialogResult = MessageBox.Show("Are You Sure Want To Delete Selected Recoed ", "Delete", MessageBoxButtons.YesNo)
            If dgResult = 6 Then
                Me.View_AttTableAdapter.DeleteQuery1(Me.View_AttDataGridView(0, e.RowIndex).Value)
                Try
                    Me.View_AttTableAdapter.FillBy(Me.DSAttCorection.View_Att, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
                Catch ex As Exception

                End Try
            End If
        End If


    End Sub

    Private Sub View_AttDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_AttDataGridView.DataError

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure To Delete All Entries", "Delete", MessageBoxButtons.YesNo)
        If dgResult = 6 Then
            For i As Int16 = 0 To Me.View_AttDataGridView.RowCount - 1
                Me.View_AttTableAdapter.DeleteQuery1(Me.View_AttDataGridView(0, i).Value)
            Next
            Try
                Me.View_AttTableAdapter.FillBy(Me.DSAttCorection.View_Att, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class