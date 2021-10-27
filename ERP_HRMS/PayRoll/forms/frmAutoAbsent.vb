Public Class frmAutoAbsent
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You want to Generate Auto Absent ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dgResult = 6 Then
            Dim date1 As Int16 = DateDiff(DateInterval.Day, DateTimePicker1.Value, Me.DateTimePicker2.Value)
            Dim NewDate As Date
            Dim FP As String
            Dim obj As New UtilityClass
            For k As Int16 = 0 To date1
                '"#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#"
                NewDate = Me.DateTimePicker1.Value.AddDays(k)
                NewDate = "#" & NewDate.Day & "/" & NewDate.Month & "/" & NewDate.Year & "#"

                FP = obj.ReturnFP(NewDate.Month, NewDate.Year)
                Try
                    Me.MissingAttendence1TableAdapter.Fill(Me.DataSet8.MissingAttendence1, NewDate.Year, NewDate.Month, NewDate.Day)
                Catch ex As System.Exception
                    'System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
                For t As Int16 = 0 To Me.MissingAttendence1BindingSource.Count - 1
                    If NewDate >= Me.DataSet8.MissingAttendence1.Rows(t).Item("DateOfJoning") Then
                        Try
                            Me.MissingAttendence1TableAdapter.InsertQuery(Me.DataSet8.MissingAttendence1.Rows(t).Item("EmpID"), FP, NewDate)
                        Catch ex As Exception

                        End Try

                    End If
                Next

            Next
            MsgBox("Record Saved Successfully")


        End If

    End Sub
End Class