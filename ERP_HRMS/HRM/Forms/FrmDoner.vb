Public Class FrmDoner
    Private Sub FrmDoner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodDoner.tbl_HRMS_Blood_Doner' table. You can move, or remove it, as needed.
        Me.Tbl_HRMS_Blood_DonerTableAdapter.Fill(Me.BloodDoner.tbl_HRMS_Blood_Doner)
        'TODO: This line of code loads data into the 'BloodDoner.View_Blood_Receiver' table. You can move, or remove it, as needed.
        Me.View_Blood_ReceiverTableAdapter.Fill(Me.BloodDoner.View_Blood_Receiver)
        'TODO: This line of code loads data into the 'BloodDoner.View_Blood_Doner' table. You can move, or remove it, as needed.
        Me.View_Blood_DonerTableAdapter.Fill(Me.BloodDoner.View_Blood_Doner)
        Try
            Me.View_HRMS_Blood_DonerTableAdapter.Fill(Me.BloodDoner.View_HRMS_Blood_Doner, CType(Label27.Text, Integer))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label11.Text = "Not Set" Or Label11.Text = Nothing Then
            MsgBox("Blood Group is Not Assign")
        Else
            If Label27.Text = Label28.Text Then
                MsgBox("Doner and Receiver is Not Same Persons")
            Else
                Try
                    Tbl_HRMS_Blood_DonerTableAdapter.Insert(Val(Label27.Text), Now.Date, CType(Label11.Text, String), Nothing, Nothing, Val(Label28.Text))
                    MsgBox("Data Has Been saved Successfuly")
                    Me.View_HRMS_Blood_DonerTableAdapter.Fill(Me.BloodDoner.View_HRMS_Blood_Doner, CType(Label27.Text, Integer))


                Catch ex As Exception

                End Try
            End If

        End If


    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Tbl_HRMS_Blood_DonerBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRMS_Blood_DonerBindingSource.PositionChanged
        Try
            Me.View_HRMS_Blood_DonerTableAdapter.Fill(Me.BloodDoner.View_HRMS_Blood_Doner, CType(Label27.Text, Integer))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub View_HRMS_Blood_DonerDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_HRMS_Blood_DonerDataGridView.CellContentClick
        If e.ColumnIndex = 7 Then

            Dim TransID As Int32 = Me.View_HRMS_Blood_DonerDataGridView.Item(6, e.RowIndex).Value

            Try
                Tbl_HRMS_Blood_DonerTableAdapter.DeleteQuery(TransID)
                Me.View_HRMS_Blood_DonerTableAdapter.Fill(Me.BloodDoner.View_HRMS_Blood_Doner, CType(Label27.Text, Integer))
                MsgBox("Transaction is Undo Sucessfully")
            Catch ex As Exception
            End Try
        End If


    End Sub
End Class