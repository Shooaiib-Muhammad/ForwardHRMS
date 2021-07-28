Public Class change_Password


    Private Sub change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_MIS_User' table. You can move, or remove it, as needed.
        Try
            'Me.Tbl_MIS_UserTableAdapter.Fill(Me.DSUser.tbl_MIS_User)
        Catch ex As Exception

        End Try


        'TODO: This line of code loads data into the 'DSUser.tbl_MIS_User_Dept' table. You can move, or remove it, as needed.
        'Me.Tbl_MIS_User_DeptTableAdapter.Fill(Me.DSUser.tbl_MIS_User_Dept)
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
            'Dim OLDPSWD As String = UtilityClass.Encrypt(Orignalpassword.Text, 100)
            Dim OLDPSWD As String = Orignalpassword.Text
            If Me.Tbl_MIS_UserTableAdapter.checkoldpwdQuery(UserId, OLDPSWD) > 0 Then
                If ValidPassword(newpwd.Text) = True Then
                    'If Tbl_MIS_UserTableAdapter.UpdateQuery(UtilityClass.Encrypt(newpwd.Text, 100), Now.Date, 0, UserId) > 0 Then
                    If Tbl_MIS_UserTableAdapter.UpdateQuery(newpwd.Text, Now.Date, 0, UserId) > 0 Then
                        MessageBox.Show("Your Password Has Been Updated Successfully", "Successfuly Updated ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        newpwd.Clear()
                        confirmpwd.Clear()
                        Orignalpassword.Clear()
                        Me.Close()


                    Else
                        MessageBox.Show("No password is Updated", "Not Update ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        newpwd.Clear()
                        confirmpwd.Clear()
                        Orignalpassword.Clear()


                    End If
                Else
                    MessageBox.Show("Please Used Combination of Special and Capital Characters in Password Field", "Used Complex Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    newpwd.Clear()
                    confirmpwd.Clear()
                    Orignalpassword.Clear()

                End If
            Else
                MessageBox.Show("Old password is Not Match", "Password Not Match ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Orignalpassword.Clear()
                newpwd.Clear()
                confirmpwd.Clear()
                Orignalpassword.Clear()


            End If
        Else
            MessageBox.Show("New and Confirm password is Not Match", "Fields Miss Match", MessageBoxButtons.OK, MessageBoxIcon.Error)
            newpwd.Clear()
            confirmpwd.Clear()
            Orignalpassword.Clear()

        End If
    End Sub






    Function ValidPassword(myPassword As String) As Boolean
        If myPassword.Length < 8 Then Return False
        If Not myPassword.Any(Function(c) Char.IsDigit(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsLower(c)) Then Return False
        If Not myPassword.Any(Function(c) Char.IsUpper(c)) Then Return False
        'If Not myPassword.Any Then
        Return True
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles newpwd.TextChanged

    End Sub

    Private Sub Orignalpassword_Click(sender As Object, e As EventArgs) Handles Orignalpassword.Click, LoginNameTextBox.Click
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
    End Sub

    Private Sub Orignalpassword_TextChanged(sender As Object, e As EventArgs) Handles Orignalpassword.TextChanged, LoginNameTextBox.TextChanged

    End Sub

    Private Sub newpwd_Click(sender As Object, e As EventArgs) Handles newpwd.Click
        Label6.Visible = False
        Label8.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub confirmpwd_Click(sender As Object, e As EventArgs) Handles confirmpwd.Click
        Label4.Visible = False
    End Sub

    Private Sub newpwd_MouseEnter(sender As Object, e As EventArgs) Handles newpwd.MouseEnter
        Label6.Visible = False
        Label8.Visible = False
        Label4.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub confirmpwd_TextChanged(sender As Object, e As EventArgs) Handles confirmpwd.TextChanged

    End Sub

    Private Sub confirmpwd_MouseEnter(sender As Object, e As EventArgs) Handles confirmpwd.MouseEnter
        Label4.Visible = False
        Label8.Visible = False
    End Sub

    Private Sub Orignalpassword_MouseEnter(sender As Object, e As EventArgs) Handles Orignalpassword.MouseEnter, LoginNameTextBox.MouseEnter
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label8.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class