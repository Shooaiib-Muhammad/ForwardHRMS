Public Class FrmReset
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSUser)

    End Sub

    Private Sub FrmReset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.Users' table. You can move, or remove it, as needed.

        Me.UsersTableAdapter.Fill(Me.DSUser.Users)
        Try
            If FrmUserMgt.NewLoginname.Length > 0 Then
                Dim index1 As Integer = 0
                For i As Integer = 0 To Me.UsersBindingSource.Count - 1
                    If Me.DSUser.Users(i).Item("LoginName").Equals(FrmUserMgt.NewLoginname) Then
                        index1 = i
                        Exit For
                    End If
                Next
                Me.UsersBindingSource.Position = index1


            End If
            FrmUserMgt.NewLoginname = ""
        Catch ex As Exception

        End Try
        Me.TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Status As Boolean
        If CheckBox1.CheckState = CheckState.Checked Then
            Status = 1
        Else
            Status = 0
        End If
        Try
            If frmResetPWd.ValidPassword(TextBox1.Text) = True Then
                'Me.UsersTableAdapter.UpdateQuery(UtilityClass.Encrypt(TextBox1.Text, 100), Now.Date, Status, LoginNameComboBox.SelectedValue)
                Me.UsersTableAdapter.UpdateQuery(TextBox1.Text, Now.Date, Status, LoginNameComboBox.SelectedValue)
                MsgBox("New password Assign Successfully")
                Me.TextBox1.Text = Nothing
                Me.TextBox1.Focus()
            Else
                MsgBox("Password Should Be Alpha Numeric Combination")
                Me.TextBox1.Text = Nothing
                Me.TextBox1.Focus()

            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class