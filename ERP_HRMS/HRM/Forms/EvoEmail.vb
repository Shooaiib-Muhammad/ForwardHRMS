
Imports System.Net.Mail
Imports System.IO

Public Class EvoEmail
    Private Sub Tbl_HRM_DeptBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_DeptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EMail)

    End Sub

    Private Sub EvoEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EMail.USers' table. You can move, or remove it, as needed.
        Me.USersTableAdapter.Fill(Me.EMail.USers)
        'TODO: This line of code loads data into the 'EMail.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.EMail.tbl_HRM_Dept)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dgResult As DialogResult
        ''Dim frmReportViewerObj As New frmReportViewer()
        Dim ExportFlag As Integer = 0
        Dim ErrorCount As Integer = 0
        Dim CardNo As Integer
        Dim ToAddress As String = Nothing
        ''Dim msg As String
        Dim username As String
        Dim Pwd As String
        ''Dim Email As String
        ''username = Me.USersTableAdapter.Fill(Me.EMail.USers)
        ''username = Me.USersTableAdapter.USers(i).Item(1)


        ''msg "Your User is ''"
        dgResult = MessageBox.Show("Are You sure you want to send user name and Password through email?", "User name and Password ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dgResult = DialogResult.Yes Then
            For i As Integer = 0 To Me.USersBindingSource.Count - 1
                'For i As Integer = 0 To Me.EMail.USers.Count - 1
                username = Me.USersDataGridView(1, i).Value
                Pwd = Me.USersDataGridView(2, i).Value
                ''ToAddress = "Arooma.Hameed@gmail.com"
                ToAddress = Me.USersDataGridView(3, i).Value
                If SendMail(username, Pwd, ToAddress) Then
                    MessageBox.Show("Your Email Has Been Send Successfully", "Email Send Successfully ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ''MessageBox.(" ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    ''MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Your Email Has Been not been Sent Successfully ", "Email Send Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Next


        End If
    End Sub
    Private Function SendMail(ByVal username As String, ByVal Pwd As String, ByVal ToAddress As String) As Boolean
        Dim Bool As Boolean = True

        Dim MailBody As String = " Dear " & username & "   " & vbCrLf & " Your Username for Evaluation is " & username & " and Password is " & Pwd & " " & vbCrLf & " Please Select Your Relevent Department for Login  " & vbCrLf & " Login link for Evaluation is http://server/Evo " & vbCrLf & " In case of any query please contact Information Technology Department Forward Sports (Pvt) Ltd. at Extention Nos. 230, 231" & vbCrLf & "Regards," & vbCrLf & "IT Manager, " & vbCrLf & "Forward Sports (Pvt) Ltd."
        Try
            Dim MyMessage As New MailMessage("Username and Password for Evaluation  <no-reply@forward.pk>", ToAddress, "Evaluation Details  ", MailBody)
            '' Dim MyAttachements As New Attachment(pdfPath & "Salary_Slip_Card_No=" & CardNo & "_Month=" & MyMonth & "_Year=" & MyYear & ".pdf")
            '' MyMessage.Attachments.Add(MyAttachements)

            Dim emailClient As New SmtpClient("192.168.10.200")
            emailClient.Send(MyMessage)
            Bool = True
        Catch ex As Exception
            Bool = False
        End Try
        Return Bool
        'Return True

    End Function

    Private Sub USersDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles USersDataGridView.CellContentClick

    End Sub

    Private Sub USersDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles USersDataGridView.CellEnter

    End Sub
End Class