Imports System.Net.Mail
Imports System.IO
Imports System.Text.RegularExpressions
Imports System
Imports System.Linq
Imports GemBox.Email
Imports GemBox.Email.Calendar
Imports WindowsFormsCalendar
Public Class EmployeeGrievanceSystem
    Dim flag As Boolean = True
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim ToEMailID As String = ""
    Dim CcEMailID As String = ""
    Dim Submit As Boolean = False
    Dim GSubject As String = ""

    Private Function MyDate(ByVal MyMonth As Integer, ByVal MyYear As Integer)
        Dim MyDate1 As New Date(MyYear, MyMonth, 1)
        Return MyDate1
    End Function

    Private Sub EmployeeGrievanceSystem_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        flag = False
    End Sub

    Private Sub EmployeeGrievanceSystem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.Down Then
        '    Tbl_Hrm_Emp_InfoBindingSource.Position += 1
        'ElseIf e.KeyCode = Keys.Up Then
        '    Tbl_Hrm_Emp_InfoBindingSource.Position -= 1
        'End If
    End Sub


    Private Sub ClearLabels()
        'lblName.Text = "" ' car5d 
        'Label10.Text = "" ' name 
        'DOJLabel.Text = "" ' Designation 
        'lblDept.Text = "" ' Dept
        ''EmpStatusCheckBox.CheckState = CheckState.Indeterminate
        'lblSec.Text = "" 'Section
        'LogoPictureBox1.Image = Nothing ' Image 
        'lblDesig.Text = "" ' Grade


    End Sub

    Private Sub FinancialPeriodComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancialPeriodComboBox.SelectedIndexChanged
        Dim Obj As New UtilityClass()
        If FinancialPeriodComboBox.SelectedValue <> Nothing Then
            If FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(cmbMonth.SelectedIndex + 1, cmbYear.SelectedItem) Then
            Else
                MsgBox("Invalid financial period as per selected month or year")
                FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(cmbMonth.SelectedIndex + 1, cmbYear.SelectedItem)
            End If
        End If

    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        SelectFP()
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged

        SelectFP()
        LoardRecord()
    End Sub
    Private Sub SelectFP()
        Dim Obj As New UtilityClass()

        If cmbMonth.SelectedIndex >= 0 And cmbYear.SelectedIndex >= 0 Then
            If Obj.ReturnFP(cmbMonth.SelectedIndex + 1, cmbYear.SelectedItem) <> Nothing Then
                FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(cmbMonth.SelectedIndex + 1, cmbYear.SelectedItem)
            Else
                MsgBox("Selected year was beyond the running financial period")
                cmbYear.SelectedIndex = 0
                cmbMonth.SelectedIndex = Now.Month - 1
            End If
        End If

    End Sub
    Private Sub LoardRecord()
        Try
            ClearLabels()
            Dim Before As New Date(cmbYear.Text, cmbMonth.SelectedIndex + 1, 1)
            Dim After As Date = GetLastDayOfMonth(Before)
            Dim postion As Integer = Tbl_EAP_GrievanceBindingSource.Position
            Tbl_EAP_GrievanceTableAdapter.FillBy(Me.DSGrievance.tbl_EAP_Grievance, Before, After)
            Tbl_EAP_GrievanceBindingSource.Position = postion
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function GetLastDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtTo As New DateTime(dtDate.Year, dtDate.Month, 1)
        dtTo = dtTo.AddMonths(1)
        dtTo = dtTo.AddDays(-(dtTo.Day))
        Return dtTo
    End Function

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox1_Enter(sender As Object, e As EventArgs) Handles MaskedTextBox1.Enter
        If MaskedTextBox1.Text = "  /  /" Then
            MaskedTextBox1.Text = Now.Date
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim dgResults As DialogResult
        If btnBrowse.Text = "Clear Image" Then
            dgResults = MessageBox.Show("Are you sure! You want to clear image?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dgResults = Windows.Forms.DialogResult.Yes Then
                Try
                    Me.Tbl_EAP_GrievanceTableAdapter.VisualClear(Val(Label6.Text))
                    MsgBox("Image Cleared")
                    LoardRecord()
                    'Me.Tbl_EAP_GrievanceTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance)
                    'Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.FillBy(Me.DataSet6.tbl_Hrm_kaizen_activity_record, Val(KARIDLabel1.Text))
                    btnBrowse.Text = "Upload Image"

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
                    If FileSize(OpenFileDialog1.FileName) <= 1000 Then
                        PictureBox3.ImageLocation = OpenFileDialog1.FileName
                        btnBrowse.Text = "Save Now"
                    Else
                        MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 1000 KB", MsgBoxStyle.Information)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Try
                Try
                    Me.ValidateChildren()
                    Me.Tbl_EAP_GrievanceBindingSource.EndEdit()
                    Me.Tbl_EAP_GrievanceTableAdapter.Update(Me.DSGrievance.tbl_EAP_Grievance)
                    MsgBox("Record Saved Successfully")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LoardRecord()
                'Me.Tbl_EAP_GrievanceTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance)
                MsgBox("Image Saved")
                btnBrowse.Text = "Clear Image"
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

    Private Sub EmployeeGrievanceSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSGrievance.View_Emp_Name3' table. You can move, or remove it, as needed.
        'Me.View_Emp_Name3TableAdapter.Fill(Me.DSGrievance.View_Emp_Name3)
        ''TODO: This line of code loads data into the 'DSGrievance.View_Emp_Name2' table. You can move, or remove it, as needed.
        'Me.View_Emp_Name2TableAdapter.Fill(Me.DSGrievance.View_Emp_Name2)
        ''TODO: This line of code loads data into the 'DSGrievance.View_Emp_Name1' table. You can move, or remove it, as needed.
        'Me.View_Emp_Name1TableAdapter.Fill(Me.DSGrievance.View_Emp_Name1)
        ''TODO: This line of code loads data into the 'DSGrievance.View_Emp_Name' table. You can move, or remove it, as needed.
        'Me.View_Emp_NameTableAdapter.Fill(Me.DSGrievance.View_Emp_Name)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_HRM_Section3' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Section3TableAdapter.Fill(Me.DSGrievance.tbl_HRM_Section3)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_HRM_Section2' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Section2TableAdapter.Fill(Me.DSGrievance.tbl_HRM_Section2)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_HRM_Section1' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Section1TableAdapter.Fill(Me.DSGrievance.tbl_HRM_Section1)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSGrievance.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSGrievance.View_Rpt_Acc_AllEmployees' table. You can move, or remove it, as needed.
        Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSGrievance.View_Rpt_Acc_AllEmployees)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_EAP_Grievance_Category' table. You can move, or remove it, as needed.
        Me.Tbl_EAP_Grievance_CategoryTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance_Category)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_EAP_Grievance_Category_Head' table. You can move, or remove it, as needed.
        Me.Tbl_EAP_Grievance_Category_HeadTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance_Category_Head)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_EAP_Grievance' table. You can move, or remove it, as needed.
        'Me.Tbl_EAP_GrievanceTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance)

        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSEmpEval.tbl_Acc_FinancialPeriod)
        Dim i As Integer = Now.Year
        While i >= 2018
            cmbYear.Items.Add(i)
            i -= 1
        End While
        cmbYear.SelectedIndex = 0
        cmbMonth.SelectedIndex = Now.Month - 1

        SelectFP()


        MyDate(cmbMonth.SelectedIndex + 1, cmbYear.Text)
        ClearLabels()
        SubmitStatus()
        'Button2.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Obj As New UtilityClass
        Path = "" & frmLogin.ReportsPath & "\HR\Gerivance.rpt"
        Filter = "{View_Rpt_Gerivance.GSID} = " & Label6.Text & ""

        Obj.LoadCardReports(Path, Filter, Param)
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If GrievanceSubjectTextBox.Text = "" Then
            MsgBox("Please Enter Greivance Subject")
        Else
            Try
                SaveRecord()
                If ComboStatus.SelectedIndex = 0 And Tbl_EAP_GrievanceTableAdapter.CheckStatus(Val(Label6.Text)) = True Then
                    SubmitGrievance("Grievance Completed")
                End If

                LoardRecord()
                MsgBox("Record Saved Successfully")
                GSubject = ""
                'BindingNavigatorAddNewItem.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
                'BindingNavigatorAddNewItem.Enabled = False
            End Try

        End If


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Button2.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
    End Sub









    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Trim(GrievanceSubjectTextBox.Text) = "" Then
            MessageBox.Show("Grievance Subject must be Enter")
            Submit = False
        ElseIf Trim(ComboBox1.Text) = "" Then
            MessageBox.Show("Grievance Category must be Enter")
            Submit = False
        ElseIf Trim(ComboBox4.Text) = "" Then
            MessageBox.Show("Grievance must be have Severity")
            Submit = False
        ElseIf Trim(ComboBox2.Text) = "" Then
            MessageBox.Show("Grievance Sub Category must be Enter")
            Submit = False
        ElseIf MaskedTextBox1.Text = "  /  /" Then
            MessageBox.Show("Grievance Date must be Enter")
            Submit = False
        ElseIf Trim(ComboBox3.Text) = "" Then
            MessageBox.Show("Grievance Person must be Enter")
            Submit = False
        ElseIf Trim(ComboBox5.Text) = "" Then
            MessageBox.Show("Min Single Department  must be Related To")
            Submit = False
        ElseIf Trim(ComboBox10.Text) = "" Then
            MessageBox.Show("Min Single person  must be Assigned To")
            Submit = False
        ElseIf Trim(ComboBox16.Text) = "" Then
            MessageBox.Show("Grievance  must be Assigned By Position")
            Submit = False
        ElseIf Trim(ComboBox17.Text) = "" Then
            MessageBox.Show("Grievance  must be Assigned By Person")
            Submit = False
        ElseIf Trim(ComboBox6.Text) = "" Then
            MessageBox.Show("Grievance  must be have some Duration ")
            Submit = False
        ElseIf Trim(ComboBox7.Text) = "" Then
            MessageBox.Show("Grievance  must be have some Status")
            Submit = False
        Else

            Submit = True
        End If
        SaveRecord()
        If Submit = True Then
            SubmitGrievance("Grievance Launch")
        End If
    End Sub
    Private Sub SubmitGrievance(Subject As String)
        Dim dgResults As DialogResult
        Dim frmReportViewerObj As New frmReportViewer()

        dgResults = MsgBox("This Grievance going to be Submit. Are you want ready for that..?", MsgBoxStyle.YesNo)
        If dgResults = 6 Then
            Dim PDFPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Grievance\"
            If Directory.Exists(PDFPath) Then
            Else
                Directory.CreateDirectory(PDFPath)
            End If
            Path = "" & frmLogin.ReportsPath & "\HR\Gerivance.rpt"
            Filter = "{View_Rpt_Gerivance.GSID} = " & Label6.Text & ""
            If frmReportViewerObj.ViewReport(2, Nothing, Nothing, Path, PDFPath, Label6.Text, Filter, Param) Then
                GSubject = Subject
                If SendMail() Then
                    Me.Tbl_EAP_GrievanceTableAdapter.UpdateStatus(1, Val(Label6.Text))
                    SubmitStatus()
                Else
                    MsgBox("Mail Sending Failed")

                End If
            Else
                MsgBox("Export to PDF Failed")

            End If
            'SendMail()
            'MsgBox("Successfully Submitted")
        End If
    End Sub
    Private Sub SaveRecord()
        Me.ValidateChildren()
        Me.Tbl_EAP_GrievanceBindingSource.EndEdit()
        Me.Tbl_EAP_GrievanceTableAdapter.Update(Me.DSGrievance.tbl_EAP_Grievance)

    End Sub
    Private Function SendMail()
        Dim Bool As Boolean = True

        Dim Remarks As String = InputBox("Enter The Remarks", "Reason")
        'If Reason.ToString.Length > 10 Then
        Dim PDFPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Grievance\"
        If Directory.Exists(PDFPath) Then
        Else
            Directory.CreateDirectory(PDFPath)
        End If
        If emailaddresscheck(EmailID.Text) = True Then
            ToEMailID = EmailID.Text
        End If

        If ComboBox17.SelectedIndex = 0 Then
            CcEMailID = "saeedmahr@forward.pk"
        ElseIf ComboBox17.SelectedIndex = 1 Then
            CcEMailID = "saleem@forward.pk"
        ElseIf ComboBox17.SelectedIndex = 2 Then
            CcEMailID = "majorshahid@forward.pk"

        ElseIf ComboBox17.SelectedIndex = 2 Then
            CcEMailID = "kashifnajeeb@forward.pk"

        End If

        'Dim address As String = "Asaad@fgear.pk"
        'Dim EMailID As String = Me.View_Rpt_Acc_AllEmployees_ActiveSalaryTableAdapter.EmailID(Val(Label19.Text))
        'Dim Comment1 As String = Me.Tbl_Hrm_EmpEvalTableAdapter.Comment1(cardNo.Text)
        'Dim Comment2 As String = Me.Tbl_Hrm_EmpEvalTableAdapter.Comment2(cardNo.Text)
        'Dim PlainMessage As AlternateView = AlternateView.CreateAlternateViewFromString("Hello, plain text", Nothing, "text/plain")
        Dim HtmlMessage As AlternateView = AlternateView.CreateAlternateViewFromString("<span style=""font-weight: bold; padding-left: 5px;padding-right:5px"">Dear " & AssignedTo.Text & " </span> <br> &nbsp;&nbsp;&nbsp;&nbsp; Please review the Below Detail which is Submitted by the User ID: " & frmLogin.UserName & " Date and Time: " & Now & "<br><span style=""font-weight: bold; padding-left: 5px;padding-right:5px""> Assigned By :</span>" & ComboBox17.Text & "<br><span style=""font-weight: bold; padding-left: 5px;padding-right:5px""> <br><span style=""font-weight: bold; padding-left: 20px;padding-right:5px"">Remarks if any:</span> <span style=""font-weight: bold; color:red; padding-left: 20px;padding-right:5px"">" & Remarks & "</span><br><br><br><span style=""font-weight: I; color:green;font-size:14; padding-left: 5px;padding-right:5px"">Please do not reply to this message via E-mail. This address is automated and handled  by  Asad Ali IT Dept. Forward Group.</span>", Nothing, "text/html")
        'Dim MailBody As String = "Dear " & FNameLabel1.Text & "," & vbNewLine & "        Please review the Below Detail which is Submitted by the User ID: " & frmLogin.UserName & " Date and Time: " & Now & " " & vbCrLf & " Comment1 if any :" & Comment1 & " " & vbCrLf & " Comment2 if any :" & Comment2 & " " & vbCrLf & " Remarks if any:" & Remarks & "" & vbNewLine & " " & vbCrLf & "In case of any query contact IT Department Forward Gear (Pvt) Ltd." & vbNewLine & " " & vbNewLine & "" & vbNewLine & " *Please do not reply to this message via E-mail. This address is automated and handled  by  Asad Ali IT Dept. Forward Gear."
        Try
            Dim MyMessage As New MailMessage("ERP Scheduled Mail <no-reply@veer.pk>", ToEMailID, "" & GSubject & " of Card No : " & Label6.Text & "  Report ", Nothing)
            Dim MyAttachements As New Attachment(PDFPath & "Grienvance # " & Label6.Text & ".pdf")
            MyMessage.Attachments.Add(MyAttachements)
            'MyMessage.AlternateViews.Add(PlainMessage)
            MyMessage.AlternateViews.Add(HtmlMessage)
            MyMessage.CC.Add(CcEMailID)
            If emailaddresscheck(EmailID1.Text) = True Then
                MyMessage.CC.Add(EmailID1.Text)
            End If
            If emailaddresscheck(EmailID2.Text) = True Then
                MyMessage.CC.Add(EmailID2.Text)
            End If
            If emailaddresscheck(EmailID3.Text) = True Then
                MyMessage.CC.Add(EmailID3.Text)
            End If

            MyMessage.Bcc.Add("Shoaib@forward.pk")
            MyMessage.Bcc.Add("Iqbal@forward.pk")

            '' Create new calendar.
            'Dim calendar As New Calendar()
            'Dim ev As New [Event]()
            'ev.Organizer = Message.Sender
            'ev.Name = "GemBox Meeting Request"
            'ev.Start = New DateTime(2018, 1, 10, 9, 0, 0, DateTimeKind.Utc)
            'ev.End = New DateTime(2018, 1, 12, 18, 0, 0, DateTimeKind.Utc)
            'ev.Attendees.Add(Message.To.First)
            'calendar.Events.Add(ev)

            '' Add calendar to the mail message.
            'Message.Calendars.Add(calendar)


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
    Private Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function

    Private Sub Tbl_EAP_GrievanceBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_EAP_GrievanceBindingSource.PositionChanged
        SubmitStatus()
    End Sub
    Private Sub SubmitStatus()
        If Tbl_EAP_GrievanceTableAdapter.CheckStatus(Val(Label6.Text)) = True Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            GroupBox5.Enabled = False
            Button3.Enabled = False

        Else
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
            GroupBox5.Enabled = True
            Button3.Enabled = True
        End If
        If ComboStatus.Text = "Completed" Then
            GroupBox6.Enabled = False
            GroupBox7.Enabled = False
        Else
            GroupBox6.Enabled = True
            GroupBox7.Enabled = True
        End If

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboStatus.SelectedIndexChanged

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tbl_HRM_Section1BindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_Section1BindingSource.PositionChanged
        Try
            Me.View_Emp_Name1TableAdapter.Fill(Me.DSGrievance.View_Emp_Name1, ComboBox12.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_HRM_Section3BindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_Section3BindingSource.PositionChanged
        Try
            Me.View_Emp_Name3TableAdapter.Fill(Me.DSGrievance.View_Emp_Name3, ComboBox18.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_HRM_SectionBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_SectionBindingSource.PositionChanged
        Try
            Me.View_Emp_NameTableAdapter.Fill(Me.DSGrievance.View_Emp_Name, ComboBox5.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_HRM_Section2BindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_Section2BindingSource.PositionChanged
        Try
            Me.View_Emp_Name2TableAdapter.Fill(Me.DSGrievance.View_Emp_Name2, ComboBox15.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub
End Class