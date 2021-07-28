Public Class FrmBloodDoner
    Private Sub FrmBloodDoner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BloodDoner.View_Blood_Doner' table. You can move, or remove it, as needed.
        Try
            Me.View_Blood_DonerTableAdapter.Fill(Me.BloodDoner.View_Blood_Doner)
        Catch ex As Exception

        End Try

    End Sub
End Class