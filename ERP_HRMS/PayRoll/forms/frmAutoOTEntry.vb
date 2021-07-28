Imports System.Data.OleDb
Imports System.IO
Public Class frmAutoOTEntry
    Dim OStremWriter As StreamWriter
    Dim FilePath As String = Nothing
    Dim countDate As Integer
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Directory.Exists("C:\Over time  Auto Log Files") Then
        Else
            Directory.CreateDirectory("C:\Over time  Auto Log Files")
        End If
        Dim FilePath As String = "C:\Over time  Auto Log Files\ Dated " & Me.DateTimePicker1.Value.Year & "-" & Me.DateTimePicker1.Value.Month & "-" & Me.DateTimePicker1.Value.Day & ".txt"
        If Me.LeaveTypeComboBox.Text = "" Then
            MsgBox("First Select OverTime Type To Continue", MsgBoxStyle.Information)
        Else
            Dim MyCard As Integer
            Dim FRead As StreamReader
            If tbFilePath.Text = "Browse Auto OverTime Entry Text File here To upload (Only txt files)".Trim Then
                MsgBox("No File Selected", MsgBoxStyle.Critical)
            Else
                Dim dgResult As New DialogResult
                dgResult = MessageBox.Show("Are You sure  want to Enter Auto " & Me.LeaveTypeComboBox.Text & " Over Time of " & Me.DateTimePicker1.Text & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dgResult = 6 Then
                    FRead = File.OpenText(tbFilePath.Text)
                    Dim count As Integer = FRead.Peek
                    While FRead.Peek <> -1
                        Try
                            MyCard = FRead.ReadLine()

                            If Me.View_All_EmployeesTableAdapter.SelectQuery(MyCard) = Nothing Then
                                Continue While
                            Else
                                Dim ActiveCard As Integer = Me.View_All_EmployeesTableAdapter.SelectQuery(MyCard)
                                ' Dim return1 As Integer = Me.View_All_EmployeesTableAdapter.FillBy(DSPayRoll.View_All_Employees, MyCard)
                                Dim return1 As Integer = 1
                                If return1 = 1 Then
                                    'If ActiveCard = 227 Then
                                    If Me.Tbl_Hrm_Emp_AttTableAdapter.EMPAtt(Me.DateTimePicker1.Text, ActiveCard) = Nothing Then

                                        'Continue While

                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                        MsgBox("Card No." & MyCard & " Not Swaped ")
                                    Else

                                        'If Me.Tbl_Hrm_Emp_AttTableAdapter.EMPAtt(Me.DateTimePicker1.Text, ActiveCard).HasValue Then
                                        countDate = Me.Tbl_Hrm_Emp_AttTableAdapter.CountAttDate(ActiveCard, Me.DateTimePicker1.Text)

                                            If LeaveTypeComboBox.Text = "Normal".Trim Then
                                                If Active.Checked = True Then
                                                    If countDate = 2 Then
                                                        Me.Tbl_Hrm_Emp_AttTableAdapter.UpdateNormal(1, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                        'Me.Tbl_Hrm_Emp_AttTableAdapter.UpdateOTQuery(Nothing, Nothing, 1, Nothing, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                    Else
                                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                                        MsgBox("Card No." & MyCard & " Not Swaped Due To Attendance Count= " & countDate & "")
                                                    End If
                                                Else
                                                    If countDate = 2 Then
                                                        Me.Tbl_Hrm_Emp_AttTableAdapter.UpdateExtra(0, 0, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                    Else
                                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                                        MsgBox("Card No." & MyCard & " Not Swaped Due To Attendance Count= " & countDate & "")
                                                    End If
                                                End If
                                            ElseIf LeaveTypeComboBox.Text = "Extra".Trim Then
                                                If Active.Checked = True Then
                                                    If countDate = 2 Then
                                                        Me.Tbl_Hrm_Emp_AttTableAdapter.UpdateExtra(1, 1, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                    Else
                                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                                        MsgBox("Card No." & MyCard & " Not Swaped Due To Attendance Count= " & countDate & "")
                                                    End If
                                                Else
                                                    If countDate = 2 Then
                                                        Me.Tbl_Hrm_Emp_AttTableAdapter.DeactiveExtra(0, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                    Else
                                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                                        MsgBox("Card No." & MyCard & " Not Swaped Due To Attendance Count= " & countDate & "")
                                                    End If
                                                End If
                                            ElseIf LeaveTypeComboBox.Text = "Special".Trim Then
                                                If Active.Checked = True Then
                                                    If countDate = 2 Then
                                                        Me.Tbl_Hrm_Emp_AttTableAdapter.UpdateSpecial(0, 0, 1, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                    Else
                                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                                        MsgBox("Card No." & MyCard & " Not Swaped Due To Attendance Count= " & countDate & "")
                                                    End If
                                                Else
                                                    If countDate = 2 Then
                                                        Me.Tbl_Hrm_Emp_AttTableAdapter.UpdateSpecial(Nothing, Nothing, 0, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                    Else
                                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                                        MsgBox("Card No." & MyCard & " Not Swaped Due To Attendance Count= " & countDate & "")
                                                    End If
                                                End If
                                            ElseIf LeaveTypeComboBox.Text = "Travell".Trim Then
                                                If Active.Checked = True Then
                                                    If countDate = 2 Then
                                                        Me.Tbl_Hrm_Emp_AttTableAdapter.UpdateQueryDTA(1, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                    Else
                                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                                        MsgBox("Card No." & MyCard & " Not Swaped Due To Attendance Count= " & countDate & "")
                                                    End If
                                                Else
                                                    If countDate = 2 Then
                                                        Me.Tbl_Hrm_Emp_AttTableAdapter.UpdateQueryDTA(0, MyCard, Me.DateTimePicker1.Text, ActiveCard)
                                                    Else
                                                        ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                                        MsgBox("Card No." & MyCard & " Not Swaped Due To Attendance Count= " & countDate & "")
                                                    End If
                                                End If
                                            End If

                                        'Else
                                        '    ErrorFileWriter(FilePath, "Card No." & MyCard & " Not Swaped on " & Me.DateTimePicker1.Text & " Due To Attendance Count=" & countDate & "")
                                        '    MsgBox("Card No." & MyCard & " Not Swaped ")
                                    End If
                                    Else
                                        MsgBox("Card No." & MyCard & " Not Found or Green Card Colour Status")
                                End If
                            End If
                        Catch ex As Exception
                        End Try
                    End While
                    frmPayrollManagment.flag = True
                    frmPayrollManagment.OTDate = Me.DateTimePicker1.Text
                    'frmManageOverTime.flag = True
                    'frmManageOverTime.OTDate = Me.DateTimePicker1.Text
                    tbFilePath.Text = "Browse Auto OverTime Entry Text File here to upload (Only txt Files)"
                    MsgBox("Record Updated Successfully,If Any Error Check Log file at C:\Over time  Auto Log Files\")
                    FRead.Close()

                End If
            End If
        End If
    End Sub
    Sub ErrorFileWriter(ByVal path As String, ByVal str As String)
        If str <> "" Then
            Try
                OStremWriter = New StreamWriter(path, True)
                OStremWriter.Write(str)
                OStremWriter.WriteLine("")
                OStremWriter.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub frmAutoOTEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_HRM_Card' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_HRM_CardTableAdapter.FillBy(Me.DSPayRoll.tbl_HRM_Card)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class