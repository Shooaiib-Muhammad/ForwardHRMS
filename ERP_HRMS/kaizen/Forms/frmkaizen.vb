Imports System.Net.Mail
Imports System.IO
Public Class frmkaizen
    Dim SuperStatus As Boolean = False
    Private Sub Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Hrm_kaizen_activity_recordBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSet6)
            Dim postion As Integer = Tbl_Hrm_kaizen_activity_recordBindingSource.Position
            LoardRecord()
            'Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.Fill(Me.DataSet6.tbl_Hrm_kaizen_activity_record)
            Tbl_Hrm_kaizen_activity_recordBindingSource.Position = postion
            MsgBox("Records Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmkaizen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet6.View_Rpt_Acc_AllEmployees_ActiveSalary1' table. You can move, or remove it, as needed.
        Me.View_Rpt_Acc_AllEmployees_ActiveSalary1TableAdapter.Fill(Me.DataSet6.View_Rpt_Acc_AllEmployees_ActiveSalary1)
        Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.Fill(Me.DataSet6.View_Rpt_Acc_AllEmployees_ActiveSalary)
        'TODO: This line of code loads data into the 'DataSet6.tbl_Hrm_kaizen_activity_record' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.Fill(Me.DataSet6.tbl_Hrm_kaizen_activity_record)
        Panel1.Enabled = False
        Button3.Enabled = False
        If frmLogin.DeptID = 1 Or frmLogin.UserID = 41 Or frmLogin.UserID = 86 Then
            SuperStatus = True
        Else
            SuperStatus = False
        End If

        If SuperStatus = True Then
            LockBtn.Visible = True
            GroupBox1.Enabled = True
            CheckBox1.Enabled = True
            TextBox6.Enabled = True
            TextBox2.ReadOnly = False
            If CheckBox1.CheckState = CheckState.Checked Then
                Panel3.Enabled = True
            Else
                Panel3.Enabled = False
            End If

        Else
            LockBtn.Visible = False
            GroupBox1.Enabled = False
            CheckBox1.Enabled = False
            TextBox6.Enabled = False
            Panel3.Enabled = False
            TextBox2.ReadOnly = True
        End If
        DateTimePicker1.Value = Now.Date.AddMonths(-1)
        DateTimePicker2.Value = Now.Date.AddMonths(6)
        LoardRecord()
        Me.Tbl_Hrm_kaizen_activity_recordBindingSource.MoveLast()
        If frmLogin.UserID = 41 Or frmLogin.UserID = 86 Then 'Asaad /Tehmeena
            TextBox6.Visible = True
            Label12.Visible = True
        Else
            TextBox6.Visible = False
            Label12.Visible = False
        End If
    End Sub
    Private Sub LoardRecord()
        Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.FillBy1(Me.DataSet6.tbl_Hrm_kaizen_activity_record, DateTimePicker1.Value.Date, DateTimePicker2.Value)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.DataSet6.tbl_Hrm_kaizen_activity_record(Me.DataSet6.tbl_Hrm_kaizen_activity_record.Count - 1).Item(4) IsNot DBNull.Value Then
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.EmpPicPictureBox.Image.Save(SaveFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim dgResults As DialogResult

        If btnBrowse.Text = "Clear Image" Then
            dgResults = MessageBox.Show("Are you sure! You want to clear image?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dgResults = Windows.Forms.DialogResult.Yes Then
                Try
                    Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.ClearBefore(Val(KARIDLabel1.Text))
                    MsgBox("Image Cleared")
                    Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.FillBy(Me.DataSet6.tbl_Hrm_kaizen_activity_record, Val(KARIDLabel1.Text))
                    btnBrowse.Text = "Upload Image"
                    Button1.Enabled = False
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf btnBrowse.Text = "Upload Image" Then
            Try
                OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
                OpenFileDialog1.FilterIndex = 1
                If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    '    EmpPicPictureBox.ImageLocation = OpenFileDialog1.FileName
                    '    btnBrowse.Text = "Save Now"
                    If FileSize(OpenFileDialog1.FileName) <= 50 Then
                        EmpPicPictureBox.ImageLocation = OpenFileDialog1.FileName
                        btnBrowse.Text = "Save Now"
                    Else
                        MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Try
                Me.Validate()
                Me.Tbl_Hrm_kaizen_activity_recordBindingSource.EndEdit()
                Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.Update(Me.DataSet6.tbl_Hrm_kaizen_activity_record)
                MsgBox("Image Saved")
                btnBrowse.Text = "Clear Image"
                Button1.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Function FileSize(ByVal FilePath As String)
        Dim FileInfor As New FileInfo(FilePath)
        Dim FileLength As Long = FileInfor.Length / 1024
        Return FileLength
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.DataSet6.tbl_Hrm_kaizen_activity_record(Me.DataSet6.tbl_Hrm_kaizen_activity_record.Count - 1).Item(6) IsNot DBNull.Value Then
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.PictureBox1.Image.Save(SaveFileDialog1.FileName)
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse1.Click
        Dim dgResults As DialogResult

        If btnBrowse1.Text = "Clear Image" Then
            dgResults = MessageBox.Show("Are you sure! You want to clear image?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dgResults = Windows.Forms.DialogResult.Yes Then
                Try
                    Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.ClearAfter(Val(KARIDLabel1.Text))
                    MsgBox("Image Cleared")
                    Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.FillBy(Me.DataSet6.tbl_Hrm_kaizen_activity_record, Val(KARIDLabel1.Text))
                    btnBrowse1.Text = "Upload Image"
                    Button1.Enabled = False
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf btnBrowse1.Text = "Upload Image" Then
            Try
                OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
                OpenFileDialog1.FilterIndex = 1
                If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    '    EmpPicPictureBox.ImageLocation = OpenFileDialog1.FileName
                    '    btnBrowse.Text = "Save Now"
                    If FileSize(OpenFileDialog1.FileName) <= 50 Then
                        PictureBox1.ImageLocation = OpenFileDialog1.FileName
                        btnBrowse1.Text = "Save Now"
                    Else
                        MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Try
                Me.Validate()
                Me.Tbl_Hrm_kaizen_activity_recordBindingSource.EndEdit()
                Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.Update(Me.DataSet6.tbl_Hrm_kaizen_activity_record)
                MsgBox("Image Saved")
                btnBrowse1.Text = "Clear Image"
                Button1.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ResetImageButton()
        Try
            If Me.DataSet6.tbl_Hrm_kaizen_activity_record(Me.Tbl_Hrm_kaizen_activity_recordBindingSource.Position).Item(4) Is DBNull.Value Then
                btnBrowse.Text = "Upload Image"
            Else
                btnBrowse.Text = "Clear Image"
            End If
        Catch ex As Exception
            btnBrowse.Text = "Upload Image"
        End Try
        Try

            If Me.DataSet6.tbl_Hrm_kaizen_activity_record(Me.Tbl_Hrm_kaizen_activity_recordBindingSource.Position).Item(6) Is DBNull.Value Then
                btnBrowse1.Text = "Upload Image"
            Else
                btnBrowse1.Text = "Clear Image"
            End If
        Catch ex As Exception
            btnBrowse1.Text = "Upload Image"
        End Try

    End Sub

    Private Sub Tbl_Hrm_kaizen_activity_recordBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_kaizen_activity_recordBindingSource.PositionChanged
        ResetImageButton()
        SubmitStatus()

        If CheckBox1.CheckState = CheckState.Checked Then
            If SuperStatus = True Then
                Panel3.Enabled = True
            Else
                Panel3.Enabled = False
            End If
        Else
            Panel3.Enabled = False

        End If


    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dgResults As DialogResult
        dgResults = MsgBox("This Kaizen Activity Record going to be Submit after that you have not any right to edit . Are you want ready for that..?", MsgBoxStyle.YesNo)
        If dgResults = Windows.Forms.DialogResult.Yes Then
            Try
                Me.Validate()
                Me.Tbl_Hrm_kaizen_activity_recordBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataSet6)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.UpdateStatus(1, Val(KARIDLabel1.Text))
            SubmitStatus()
            SendMail()
            'MsgBox("Successfully Submitted")
        End If
    End Sub
    Private Sub SubmitStatus()
        If SuperStatus = True Then
            Panel1.Enabled = True
            Button3.Enabled = True
        Else
            If Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.CheckStatus(Val(KARIDLabel1.Text)) = True Then
                Panel1.Enabled = False
                Button3.Enabled = False
                LockBtn.Text = "Unlock"
            Else
                Panel1.Enabled = True
                Button3.Enabled = True
                LockBtn.Text = "Lock"
            End If

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
        Dim MailBody As String = "Dear Asaad," & vbNewLine & "        Please review the Below Detail which is Submitted by the User ID: " & frmLogin.UserName & " and By Employee Name:" & FNameLabel1.Text & " Date and Time: " & Now & " Remarks if any:" & Remarks & "" & vbNewLine & " " & vbCrLf & "In case of any query contact IT Department Forward Gear (Pvt) Ltd." & vbNewLine & " " & vbNewLine & "" & vbNewLine & " *Please do not reply to this message via E-mail. This address is automated and handled  by  Asad Ali IT Dept. Forward Gear."
        Try
            Dim MyMessage As New MailMessage("ERP Scheduled Mail <no-reply@fgear.pk>", address, "Kaizen Activity " & MaskedTextBox1.Text, MailBody)
            'Dim MyAttachements As New Attachment(PDFPath & "Kaizen Activity=" & CardNoComboBox.Text & "_" & MaskedTextBox1.Text & ".pdf")
            'MyMessage.Attachments.Add(MyAttachements)
            Dim EMailID As String = Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.EmailID(Val(CardNoComboBox.Text))
            MyMessage.CC.Add(EMailID)
            MyMessage.CC.Add("fgme1@veer.pk")
            Dim emailClient As New SmtpClient("192.168.20.200")
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



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Obj As New UtilityClass
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Path = "\\server\myreports$\HRMSG\HR\Rpt_Kaizen_updated.rpt"
        Filter = "{tbl_Hrm_kaizen_activity_record.KARID} =" & Val(KARIDLabel1.Text) & ""

        Obj.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub MaskedTextBox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles MaskedTextBox2.Enter
        If MaskedTextBox2.Text = "  /  /" Then

            MaskedTextBox2.Text = Now.Date

        End If
    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub LockBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockBtn.Click
        Dim dgResults As DialogResult
        If LockBtn.Text = "Lock" Then
            dgResults = MsgBox("This Kaizen Activity Record going to be Lockafter that you have not any right to edit . Are you want ready for that..?", MsgBoxStyle.YesNo)
            If dgResults = Windows.Forms.DialogResult.Yes Then
                Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.UpdateStatus(1, Val(KARIDLabel1.Text))
                SubmitStatus()
                LockBtn.Text = "Unlock"
                MsgBox("Successfully Locked")
            End If
        ElseIf LockBtn.Text = "Unlock" Then
            Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.UpdateStatus(0, Val(KARIDLabel1.Text))
            SubmitStatus()
            LockBtn.Text = "Lock"
            MsgBox("Successfully Unlocked")
        End If

    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            If Me.txtSearch.TextLength = 0 Then
                Tbl_Hrm_kaizen_activity_recordBindingSource.RemoveFilter()

            Else

                'View_Pro_PO_Auto_PlaningMainBindingSource.Filter = "ArticleNo=" & Val(txtSearch.Text)
                Tbl_Hrm_kaizen_activity_recordBindingSource.Filter = String.Format("KarCode Like '*" & txtSearch.Text) & "*'"

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Panel1.Enabled = True
        Button3.Enabled = True
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel3.Enabled = True
        Else
            Panel3.Enabled = False

        End If
    End Sub

    Private Sub txtSName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSName.Click

    End Sub

    Private Sub txtSName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                'View_Pro_PO_Auto_PlaningMainBindingSource.Filter = "ArticleNo=" & Val(txtSearch.Text)
                Tbl_Hrm_kaizen_activity_recordBindingSource.Filter = String.Format("Title Like '*" & txtSName.Text) & "*'"
                CMSEmpInfo.Text = ""
                CMSEmpInfo.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        Tbl_Hrm_kaizen_activity_recordBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Tbl_Hrm_kaizen_activity_recordBindingSource.RemoveFilter()
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Tbl_Hrm_kaizen_activity_recordBindingSource.Filter = "KARID=" & Val(ToolStripTextBox1.Text)
                'Tbl_Hrm_kaizen_activity_recordBindingSource.Filter = String.Format("KARID Like '*" & ToolStripTextBox1.Text) & "*'"
                ContextMenuStrip1.Text = ""
                ContextMenuStrip1.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Panel6.Enabled = True
        Else
            Panel6.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoardRecord()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoardRecord()
    End Sub
End Class