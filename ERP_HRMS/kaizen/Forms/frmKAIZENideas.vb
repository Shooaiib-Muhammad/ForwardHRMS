Imports System.Net.Mail
Imports System.IO
Public Class frmKAIZENideas

    Private Sub Tbl_Hrm_kaizen_IdeasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.Validate()
            Me.Tbl_Hrm_kaizen_IdeasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSet6)
            MsgBox("Record Saved.")
            SaveToolStripButton.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            CancelEdit1.Visible = False
            GroupBox2.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmKAIZENideas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet6.View_Rpt_Acc_AllEmployees_ActiveSalary' table. You can move, or remove it, as needed.
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.Fill(Me.DataSet6.View_Rpt_Acc_AllEmployees_ActiveSalary)
        'TODO: This line of code loads data into the 'DataSet6.tbl_Hrm_kaizen_Ideas' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_kaizen_IdeasTableAdapter.Fill(Me.DataSet6.tbl_Hrm_kaizen_Ideas)
        If frmLogin.UserID = 86 Or frmLogin.UserID = 41 Or frmLogin.DeptID = 1 Then
            GroupBox1.Enabled = True
            Me.Tbl_Hrm_kaizen_IdeasTableAdapter.Fill(Me.DataSet6.tbl_Hrm_kaizen_Ideas)
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    'Private Sub Clock1_TimeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock1.TimeChanged
    '    Me.Clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)
    'End Sub

    Private Sub Edit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit1.Click
        SaveToolStripButton.Enabled = True
        CancelEdit1.Visible = True
        GroupBox2.Enabled = True
        If frmLogin.UserID = 39 Or frmLogin.DeptID = 1 Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        SaveToolStripButton.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        CancelEdit1.Visible = True
        GroupBox2.Enabled = True
        If frmLogin.UserID = 39 Or frmLogin.DeptID = 1 Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub CancelEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelEdit1.Click
        Dim position As Integer = Tbl_Hrm_kaizen_IdeasBindingSource.Position
        Tbl_Hrm_kaizen_IdeasTableAdapter.Fill(DataSet6.tbl_Hrm_kaizen_Ideas)
        Tbl_Hrm_kaizen_IdeasBindingSource.Position = position
        BindingNavigatorAddNewItem.Enabled = True
        Edit1.Enabled = True
        SaveToolStripButton.Enabled = False
        CancelEdit1.Visible = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dgResults As DialogResult
        dgResults = MsgBox("This Kaizen Idea going to be Submit after that you have not any right to edit . Are you want ready for that..?", MsgBoxStyle.YesNo)
        If dgResults = Windows.Forms.DialogResult.Yes Then
            'Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.UpdateStatus(1, Val(KARIDLabel1.Text))
            'SubmitStatus()
            Try
                Me.Validate()
                Me.Tbl_Hrm_kaizen_IdeasBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSet6)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            SendMail()
            'MsgBox("Successfully Submitted")
        End If
    End Sub
    Private Function SendMail()
        Dim Bool As Boolean = True
        Dim Remarks As String = InputBox("Enter The Remarks", "Reason")
        'If Reason.ToString.Length > 10 Then
        'Dim PDFPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Kaizen Activity Record\"
        'If Directory.Exists(PDFPath) Then
        'Else
        '    Directory.CreateDirectory(PDFPath)
        'End If
        'Dim address As String = "Asad@fgear.pk"
        Dim address As String = "Asaad@fgear.pk"
        Dim MailBody As String = "Dear Asaad," & vbNewLine & "        Please review the Below Detail which is Submitted by the User ID: " & frmLogin.UserName & " and By Employee Name:" & FNameLabel1.Text & " Date and Time: " & Now & " Idea: " & IdeaTextBox.Text & " Detail: " & DescriptionTextBox.Text & " Remarks if any:" & Remarks & "" & vbNewLine & " " & vbCrLf & "In case of any query contact IT Department Forward Gear (Pvt) Ltd." & vbNewLine & " " & vbNewLine & "" & vbNewLine & " *Please do not reply to this message via E-mail. This address is automated and handled  by  Asad Ali IT Dept. Forward Gear."
        Try
            Dim MyMessage As New MailMessage("ERP Scheduled Mail <no-reply@fgear.pk>", address, "Kaizen Ideas" & IdeaTextBox.Text, MailBody)
            'Dim MyAttachements As New Attachment(PDFPath & "Kaizen Activity=" & CardNoComboBox.Text & "_" & MaskedTextBox1.Text & ".pdf")
            'MyMessage.Attachments.Add(MyAttachements)
            Dim EMailID As String = Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.EmailID(Val(CardNoComboBox.Text))
            MyMessage.CC.Add(EMailID)
            Dim emailClient As New SmtpClient("192.168.20.200")
            MyMessage.CC.Add("fgme1@veer.pk")
            MyMessage.Bcc.Add("asad@veer.pk")
            emailClient.Send(MyMessage)

            MsgBox("Successfully Submitted")
        Catch ex As Exception
            Bool = False
            MsgBox("Please Contact IT Administrator")
        End Try

        'Else
        'MsgBox("It's not enough reason ,You need to be try again")
        'End If
        Return Bool
    End Function

    Private Sub IdeaDateMaskedTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdeaDateMaskedTextBox.Enter
        If IdeaDateMaskedTextBox.Text = "  /  /" Then

            IdeaDateMaskedTextBox.Text = Now.Date

        End If
    End Sub
End Class