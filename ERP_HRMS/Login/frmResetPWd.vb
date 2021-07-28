Public Class frmResetPWd


    Private Sub frmResetPWd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.Users' table. You can move, or remove it, as needed.

        'Try
        '    Me.UsersTableAdapter.FillBy2(Me.DSUser.Users, frmLogin.UserID)
        'Catch ex As Exception

        'End Try
        Orignalpassword.Text = frmLogin.UserPassword
        newpwd.Focus()
        LoginNameTextBox.Text = frmLogin.UserName

        MaskedTextBox1.Text = Date.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserId As Int16 = frmLogin.UserID

        If Orignalpassword.Text = "" AndAlso newpwd.Text = "" AndAlso confirmpwd.Text = "" Then
            Label5.Visible = True
            Label6.Visible = True
            Label4.Visible = True
        ElseIf Orignalpassword.Text = "" Then
            Label5.Visible = True
        ElseIf Orignalpassword.Text = "" And confirmpwd.Text = ""
            Label5.Visible = True
            Label4.Visible = True
        ElseIf newpwd.Text = "" And confirmpwd.Text = "" Then
            Label6.Visible = True
            Label4.Visible = True
        ElseIf confirmpwd.Text = "" Then
            Label4.Visible = True
        ElseIf Orignalpassword.Text = newpwd.Text Then
            Label8.Visible = True
        ElseIf Orignalpassword.Text = confirmpwd.Text Then
            Label8.Visible = True

        ElseIf newpwd.Text = confirmpwd.Text Then

            If Me.UsersTableAdapter.checkoldpwdQuery(UserId, UtilityClass.Encrypt(Orignalpassword.Text, 100)) > 0 Then
                If ValidPassword(newpwd.Text) = True Then
                    If UsersTableAdapter.UpdateQuery(UtilityClass.Encrypt(newpwd.Text, 100), Now.Date, 0, UserId) > 0 Then
                        MessageBox.Show("Your Password Has Been Updated Successfully", "Successfuly Updated ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        newpwd.Clear()
                        confirmpwd.Clear()

                        Me.Close()


                    Else
                        MessageBox.Show("No password is Updated", "Not Update ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        newpwd.Clear()
                        confirmpwd.Clear()
                        'Orignalpassword.Clear()
                        newpwd.Focus()

                    End If
                Else
                    MessageBox.Show("Please Used Combination of Special and Capital Characters in Password Field", "Used Complex Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    newpwd.Clear()
                    confirmpwd.Clear()
                    'Orignalpassword.Clear()
                    newpwd.Focus()
                End If
            Else
                MessageBox.Show("Old password is Not Match", "Password Not Match ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Orignalpassword.Clear()
                newpwd.Clear()
                confirmpwd.Clear()
                newpwd.Focus()


            End If
        Else
            MessageBox.Show("New and Confirm password is Not Match", "Fields Miss Match", MessageBoxButtons.OK, MessageBoxIcon.Error)
            newpwd.Clear()
            confirmpwd.Clear()

            newpwd.Focus()
        End If
    End Sub
    Public Shared Function ValidPassword(myPassword As String) As Boolean
        If myPassword.Length < 8 Then Return False
        If Not myPassword.Any(Function(c) Char.IsDigit(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsLower(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsUpper(c)) Then Return False
        'If Not myPassword.Any Then
        Return True
    End Function
End Class