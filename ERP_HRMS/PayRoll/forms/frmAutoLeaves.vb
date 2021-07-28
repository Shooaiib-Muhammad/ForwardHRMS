Imports System.IO
Public Class frmAutoLeaves
    Dim objLongLeave As New frmPayrollManagment
    Dim Obj_FP As New UtilityClass
    Dim flag As Boolean = False
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Public Sub FormClose()
        Me.Close()
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.LeaveTypeComboBox.Text = "" Then
            MsgBox("First Select Leave Type To Continue", MsgBoxStyle.Information)
        Else
            Dim Leaves_Status As Double = 0

            If Paid.Checked = True Then
                If CheckBox1.Checked = True Then
                    Leaves_Status = 1
                Else
                    Leaves_Status = 0.5
                End If
            ElseIf Unpaid.Checked = True
                Leaves_Status = 0
            End If
            If RadioButton2.Checked = True Then 'For Multipale
                'If Me.LeaveTypeComboBox.Text = "Compensatory" Or Me.LeaveTypeComboBox.Text = "Casual" Or Me.LeaveTypeComboBox.Text = "M1" Or Me.LeaveTypeComboBox.Text = "Sick" Or Me.LeaveTypeComboBox.Text = "Special" Then
                Dim MyCard As Integer
                Dim FRead As StreamReader
                If tbFilePath.Text = "Browse Leave text File here to upload (Only txt files)".Trim Then
                    MsgBox("No File Selected", MsgBoxStyle.Critical)
                Else
                    Dim dgResult As New DialogResult
                    dgResult = MessageBox.Show("Are You sure  want to Enter Auto Leaves? As well you have selected proper Halfday/Fullday status.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If dgResult = 6 Then
                        Dim LType As String = Me.LeaveTypeComboBox.Text
                        Dim FP As String = Obj_FP.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                        FRead = File.OpenText(tbFilePath.Text)
                        While FRead.Peek <> -1
                            Try
                                MyCard = FRead.ReadLine()
                                If Me.View_All_EmployeesTableAdapter.SelectQuery(MyCard) = Nothing Then
                                    Continue While


                                Else
                                    Dim ActiveCard As Integer = Me.View_All_EmployeesTableAdapter.SelectQuery(MyCard)
                                    If Me.Tbl_Hrm_Emp_AttTableAdapter.EMPAtt(Format(DateTimePicker1.Value, "dd/MM/yy"), ActiveCard) > 0 And RadioButton2.Checked = True And CheckBox1.CheckState = CheckState.Checked Then
                                        Continue While
                                    Else
                                        If Me.Tbl_PayRoll_LongLeavesTableAdapter.FillBy2(DSPayRoll.tbl_PayRoll_LongLeaves, Format(DateTimePicker1.Value, "dd/MM/yy"), MyCard) > 0 Then
                                            'If Me.Tbl_PayRoll_LongLeavesTableAdapter.LongLeave(Format(DateTimePicker1.Value, "dd/MM/yy"), ActiveCard) > 0 Then
                                            'objLongLeave.Tbl_PayRoll_LongLeavesTableAdapter.UpdateLeave(LType, Leaves_Status, ActiveCard, Format(DateTimePicker1.Value, "dd/MM/yy"))
                                            Me.Tbl_PayRoll_LongLeavesTableAdapter.DeleteQuery(Me.DSPayRoll.tbl_PayRoll_LongLeaves.Rows(0).Item("LLID"))
                                            'Continue While

                                        End If
                                        Dim AgainstLeave As String = Nothing
                                        If LType = "Compensatory" Then
                                            If Me.Tbl_PayRoll_LongLeavesTableAdapter.DateLeave(ActiveCard) Is Nothing Then
                                                AgainstLeave = Nothing
                                            Else
                                                AgainstLeave = Me.Tbl_PayRoll_LongLeavesTableAdapter.DateLeave(ActiveCard).ToString
                                            End If
                                        End If
                                        If LType = "Annual" Then
                                            If Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.SelectQuery(ActiveCard, FP) Is Nothing Then
                                                objLongLeave.InsertRecord(LType, ActiveCard, Format(DateTimePicker1.Value, "dd/MM/yy"), Format(DateTimePicker1.Value, "dd/MM/yy"), 1, Leaves_Status, AgainstLeave, True, FP)
                                            Else

                                            End If
                                        Else
                                            If CheckBox1.Checked Then
                                                objLongLeave.InsertRecord(LType, ActiveCard, Format(DateTimePicker1.Value, "dd/MM/yy"), Format(DateTimePicker1.Value, "dd/MM/yy"), 1, Leaves_Status, AgainstLeave, True, FP)
                                            Else
                                                objLongLeave.InsertRecord(LType, ActiveCard, Format(DateTimePicker1.Value, "dd/MM/yy"), Format(DateTimePicker1.Value, "dd/MM/yy"), 0.5, Leaves_Status, AgainstLeave, True, FP)
                                            End If
                                        End If

                                    End If
                                End If
                            Catch ex As Exception
                                'tbFilePath.Text = "Browse Leave text File here to upload (Only txt files)"
                                Me.Close()
                            End Try
                        End While
                        frmPayrollManagment.flag1 = True
                        tbFilePath.Text = "Browse Leave text File here to upload (Only txt files)"
                        FRead.Close()
                        Me.Close()
                    End If
                End If
                'End If
            ElseIf RadioButton1.Checked = True Then 'For Individual Card

                Dim FromDate, ToDate As Date
                FromDate = Format(DateTimePicker1.Value, "dd/MM/yy")
                ToDate = Format(DateTimePicker2.Value, "dd/MM/yy")
                If DateDiff(DateInterval.Day, FromDate, ToDate) > 1 Then
                    If Me.LeaveTypeComboBox.Text <> Nothing Then
                        'Me.Tbl_Hrm_Emp_AttTableAdapter1.Fill(Me.DSLongLeaves.tbl_Hrm_Emp_Att, Format(DateTimePicker1.Value, "dd/MM/yy"), Format(DateTimePicker2.Value, "dd/MM/yy"), Me.CardNoComboBox.SelectedValue)
                        Me.Tbl_Hrm_Emp_AttTableAdapter.FillBy(Me.DSPayRoll.tbl_Hrm_Emp_Att, Format(DateTimePicker1.Value, "dd/MM/yy"), Format(DateTimePicker2.Value, "dd/MM/yy"), Me.CardNoComboBox.Text, Me.CardNoComboBox.Text)
                        'Me.Tbl_Hrm_Emp_Att1TableAdapter.Fill(Me.DSpayroll.tbl_Hrm_Emp_Att1, Format(DateTimePicker1.Value, "dd/MM/yy"), Format(DateTimePicker2.Value, "dd/MM/yy"), Me.CardNoComboBox.SelectedValue)
                        If Me.Tbl_Hrm_Emp_AttBindingSource.Count > 0 Then
                            MsgBox("Employees Leaves Can't be Saved, Because Employee have Rolled his/her Attendance between the Selected Date Range")
                            flag = False
                        Else
                            Dim FP As String = Obj_FP.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
                            If LeaveTypeComboBox.Text = "Annual" Then
                                If Me.Tbl_Acc_AnnualLeaveTransactionsTableAdapter.SelectQuery(Me.CardNoComboBox.SelectedValue, FP) Is Nothing Then
                                    flag = True
                                    objLongLeave.InsertRecord(LeaveTypeComboBox.Text, Me.CardNoComboBox.SelectedValue, Format(Me.DateTimePicker1.Value, "dd/MM/yy"), Format(DateTimePicker2.Value, "dd/MM/yy"), 1, Leaves_Status, Nothing, False, FP)
                                    frmPayrollManagment.flag = True
                                Else
                                    MsgBox("Employees Leaves Can't be Saved, Because Employee has been Payed Annual Leaves", MsgBoxStyle.Critical)
                                    flag = False
                                End If
                            Else
                                flag = True
                                objLongLeave.InsertRecord(LeaveTypeComboBox.Text, Me.CardNoComboBox.SelectedValue, Format(Me.DateTimePicker1.Value, "dd/MM/yy"), Format(DateTimePicker2.Value, "dd/MM/yy"), 1, Leaves_Status, Nothing, False, FP)
                                frmPayrollManagment.flag = True
                            End If
                        End If
                    Else
                        MsgBox("Select Leave Type To Continue")
                        flag = False
                    End If
                Else
                    MsgBox("Date Difference Should be Greater Than 1")
                    flag = False
                End If
            End If
        End If
    End Sub


    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Text Files(*.txt;)|*.txt;"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            If OpenFileDialog1.FileName.Trim() <> "" Then
                If UCase(OpenFileDialog1.FileName.Trim().Substring(OpenFileDialog1.FileName.Trim().LastIndexOf(".") + 1)) = "TXT" Then
                    tbFilePath.Text = OpenFileDialog1.FileName.Trim()
                Else
                    MessageBox.Show("Open TXT File only")
                End If
            Else
                MessageBox.Show("No File Selected")
            End If
        End If
    End Sub

    'Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
    '    If CheckBox2.Checked Then
    '        btnBrowse.Enabled = True
    '        CardNoComboBox.Enabled = False
    '        DateTimePicker2.Enabled = False
    '        Me.CheckBox1.Enabled = True
    '    Else
    '        btnBrowse.Enabled = False
    '        CardNoComboBox.Enabled = True
    '        DateTimePicker2.Enabled = True
    '        Me.CheckBox1.Enabled = False
    '    End If
    'End Sub
    Private Sub Seletion()
        If RadioButton2.Checked = True Then
            btnBrowse.Enabled = True
            CardNoComboBox.Enabled = False
            DateTimePicker2.Enabled = False
            Me.CheckBox1.Enabled = True
        Else
            btnBrowse.Enabled = False
            CardNoComboBox.Enabled = True
            DateTimePicker2.Enabled = True
            Me.CheckBox1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Full Day"
        Else
            CheckBox1.Text = "Half Day"
        End If
    End Sub

    Private Sub frmAutoLeaves_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If flag = True Then

        End If
        Me.Hide()
    End Sub



    Private Sub frmAutoLeaves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Card' table. You can move, or remove it, as needed.



        Try
            Me.Tbl_HRM_CardTableAdapter.FillBy(Me.DSPayRoll.tbl_HRM_Card)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Seletion()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Seletion()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class