Imports System.Data.OleDb
Imports System.IO
Public Class frmAttAcessToDBOld
    Dim OStremWriter As StreamWriter
    Dim FilePath As String = "C:\Access Attendance Log Files\ Dated " & Now.Year & "-" & Now.Month & "-" & Now.Day & ".txt"
    Dim AttendTime As DateTime
    Dim AttDate1 As DateTime
    Dim DecviceNo As Integer
    Dim cardNo As Integer
    Dim FP As String
    Dim GridRowCount As Integer
    Dim obj As New UtilityClass
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim FilePath As String = Nothing
        If Directory.Exists("C:\Access Attendance Log Files") Then
        Else
            Directory.CreateDirectory("C:\Access Attendance Log Files")
        End If

        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure Want to Transfer Access Attendance To DB ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dgResult = 6 Then
            If TabControl1.SelectedTab.Text = "ZkTeco" Then
                zkteco()

            ElseIf TabControl1.SelectedTab.Text = "Anviz" Then
                Anviz()

            End If

        End If
    End Sub
    Private Sub zkteco()

        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum += 1
        ToolStripProgressBar1.Maximum = Me.DataGridView1.RowCount
        For i As Integer = 0 To Me.DataGridView1.RowCount - 1

            AttendTime = Format(CDate(Me.DataGridView1(2, i).Value), "dd/MM/yyyy hh:mm tt")
            AttDate1 = CDate(Me.DataGridView1(1, i).Value).ToShortDateString
            DecviceNo = Me.DataGridView1(3, i).Value
            cardNo = Me.DataGridView1(0, i).Value

            Try
                Me.View_All_EmployeesTableAdapter.FillBy(Me.DSPayRoll.View_All_Employees, cardNo)
            Catch ex As Exception

            End Try
            If Me.DSPayRoll.View_All_Employees.Rows(0).Item("SuspendStatus") = True Then
                ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & cardNo & "] , Message: [Employee Is suspended]")
                Me.DataGridView1(4, i).Value = "Employee Is suspended Can't Paid leaved"

            Else
                If Me.View_All_EmployeesBindingSource.Count > 0 Then
                    FP = obj.ReturnFP(AttendTime.Month, AttendTime.Year)
                    If AttendTime < DateAdd(DateInterval.Minute, -120, DateTime.Parse(AttendTime.ToShortDateString() & " " & Me.DSPayRoll.View_All_Employees(0).Item("ShiftST").ToShortTimeString())) Then
                        'Out With 1 day Less
                        AttDate1 = DateAdd(DateInterval.Day, -1, AttendTime.Date)
                    Else
                        AttDate1 = AttDate1
                    End If
                    Dim ShiftST As DateTime = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                    Dim ShiftET As DateTime = Me.DSPayRoll.View_All_Employees(0).Item("ShiftET")
                    Dim Shift As Integer = Me.DSPayRoll.View_All_Employees(0).Item("ShiftID")
                    Dim BreakST As DateTime = Me.DSPayRoll.View_All_Employees(0).Item("BreakST")
                    Dim BreakET As DateTime = Me.DSPayRoll.View_All_Employees(0).Item("BreakET")
                    'If WeekdayName(Weekday(AttDate1)) = "Friday" And Me.DSPayRoll.View_All_Employees(0).Item("FridayBreakStatus") = 1 Then
                    '    ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                    '    BreakST = DateAdd(DateInterval.Minute, 30, BreakST)
                    '    BreakET = DateAdd(DateInterval.Minute, 60, BreakET)
                    'End If


                    Dim Night As Boolean = Me.DSPayRoll.View_All_Employees.Rows(0).Item("NightAndFriday")
                    Dim Day As Boolean = Me.DSPayRoll.View_All_Employees.Rows(0).Item("FridayBreakStatus")
                    'MsgBox()

                    If WeekdayName(Weekday(AttDate1)) = "Friday" Then
                        If Day = True Then '''' For All SHif
                            ShiftET = DateAdd(DateInterval.Minute, 15, ShiftET)
                            BreakST = DateAdd(DateInterval.Minute, 0, BreakST)
                            BreakET = DateAdd(DateInterval.Minute, 15, BreakET)
                        ElseIf Night = True Then  '' For Night Shift
                            ShiftST = DateAdd(DateInterval.Minute, 30, ShiftST)
                            ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                            BreakST = DateAdd(DateInterval.Minute, 30, BreakST)
                            BreakET = DateAdd(DateInterval.Minute, 30, BreakET)
                        Else
                            ShiftST = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                            ShiftET = Me.DSPayRoll.View_All_Employees(0).Item("ShiftET")
                            BreakST = Me.DSPayRoll.View_All_Employees(0).Item("BreakST")
                            BreakET = Me.DSPayRoll.View_All_Employees(0).Item("BreakET")
                        End If
                    Else
                        ShiftST = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                        ShiftET = Me.DSPayRoll.View_All_Employees(0).Item("ShiftET")
                        BreakST = Me.DSPayRoll.View_All_Employees(0).Item("BreakST")
                        BreakET = Me.DSPayRoll.View_All_Employees(0).Item("BreakET")
                    End If


                    Try
                        Dim countAtt As Integer
                        countAtt = Me.Tbl_Hrm_Emp_AttTableAdapter.DuplicateAtt(Me.DSPayRoll.View_All_Employees(0).Item("CardNo"), AttDate1, AttendTime)
                        If countAtt = 0 Then
                            Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.DSPayRoll.View_All_Employees(0).Item("CardNo"), Me.DSPayRoll.View_All_Employees(0).Item("EmpID"), AttDate1, AttendTime, Nothing, Nothing, Shift, Nothing, Me.DSPayRoll.View_All_Employees(0).Item("ShiftST"), ShiftET, BreakST, BreakET, FP, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DecviceNo)
                            Me.DataGridView1(4, i).Value = "Successfully Mark Attendence"
                        Else
                            Me.DataGridView1(4, i).Value = "Already Attendence Mark"
                        End If
                        PaintGrid(0, i, Color.DarkGreen, Color.White)
                        PaintGrid(1, i, Color.DarkGreen, Color.White)
                        PaintGrid(2, i, Color.DarkGreen, Color.White)
                        PaintGrid(3, i, Color.DarkGreen, Color.White)
                        PaintGrid(4, i, Color.DarkGreen, Color.White)
                        If Me.DSPayRoll.View_All_Employees.Rows(0).Item("EndDate") < AttendTime.ToShortDateString Then
                            ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & cardNo & "] , Message: [Employee Card has been Expired]")
                            'Me.CHECKINOUTDataGridView(4, 0).Value = "Employee Card has been Expired"
                            Me.DataGridView1(4, i).Value = "Employee Card has been Expired"
                        End If
                    Catch ex As Exception
                        ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & cardNo & "] , Message:[" & ex.Message & "]")
                        PaintGrid(0, i, Color.Red, Color.White)
                        PaintGrid(1, i, Color.Red, Color.White)
                        PaintGrid(2, i, Color.Red, Color.White)
                        PaintGrid(3, i, Color.Red, Color.White)
                        PaintGrid(4, i, Color.Red, Color.White)
                        Me.DataGridView1(4, i).Value = "" & ex.Message & ""
                    End Try
                Else
                    Me.DataGridView1(4, i).Value = "No Employee Active At this Card No"
                End If
            End If
            ToolStripProgressBar1.Value += 1
        Next
        MsgBox("Attendance Successfully Transfer to DB...! 'for Error check Error file'")
        ToolStripProgressBar1.Value = 0
    End Sub
    Private Sub Anviz()
        ToolStripProgressBar2.Value = 0
        ToolStripProgressBar2.Maximum += 1
        ToolStripProgressBar2.Maximum = Me.CHECKINOUTDataGridView.RowCount
        For i As Integer = 0 To Me.CHECKINOUTDataGridView.RowCount - 1
            AttendTime = Format(CDate(Me.CHECKINOUTDataGridView(2, i).Value), "dd/MM/yyyy hh:mm tt")
            AttDate1 = CDate(Me.CHECKINOUTDataGridView(1, i).Value).ToShortDateString
            DecviceNo = Me.CHECKINOUTDataGridView(3, i).Value
            cardNo = Me.CHECKINOUTDataGridView(0, i).Value

            Try
                Me.View_All_EmployeesTableAdapter.FillBy(Me.DSPayRoll.View_All_Employees, cardNo)
            Catch ex As Exception

            End Try
            If Me.DSPayRoll.View_All_Employees.Rows(0).Item("SuspendStatus") = True Then
                ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & cardNo & "] , Message: [Employee Is suspended]")
                Me.DataGridView1(4, i).Value = "Employee Is suspended Can't Paid leaved"

            Else
                If Me.View_All_EmployeesBindingSource.Count > 0 Then

                    FP = obj.ReturnFP(AttendTime.Month, AttendTime.Year)
                    If AttendTime < DateAdd(DateInterval.Minute, -120, DateTime.Parse(AttendTime.ToShortDateString() & " " & Me.DSPayRoll.View_All_Employees(0).Item("ShiftST").ToShortTimeString())) Then
                        'Out With 1 day Less
                        AttDate1 = DateAdd(DateInterval.Day, -1, AttendTime.Date)
                    Else
                        AttDate1 = AttDate1
                    End If
                    Dim ShiftST As DateTime = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                    Dim ShiftET As DateTime = Me.DSPayRoll.View_All_Employees(0).Item("ShiftET")
                    Dim Shift As Integer = Me.DSPayRoll.View_All_Employees(0).Item("ShiftID")
                    Dim BreakST As DateTime = Me.DSPayRoll.View_All_Employees(0).Item("BreakST")
                    Dim BreakET As DateTime = Me.DSPayRoll.View_All_Employees(0).Item("BreakET")
                    'If WeekdayName(Weekday(AttDate1)) = "Friday" And Me.DSPayRoll.View_All_Employees(0).Item("FridayBreakStatus") = 1 Then
                    '    ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                    '    BreakST = DateAdd(DateInterval.Minute, 30, BreakST)
                    '    BreakET = DateAdd(DateInterval.Minute, 60, BreakET)
                    'End If


                    Dim Night As Boolean = Me.DSPayRoll.View_All_Employees.Rows(0).Item("NightAndFriday")
                    Dim Day As Boolean = Me.DSPayRoll.View_All_Employees.Rows(0).Item("FridayBreakStatus")
                    'MsgBox()

                    If WeekdayName(Weekday(AttDate1)) = "Friday" Then
                        If Day = True Then '''' For All SHif
                            ShiftET = DateAdd(DateInterval.Minute, 15, ShiftET)
                            BreakST = DateAdd(DateInterval.Minute, 0, BreakST)
                            BreakET = DateAdd(DateInterval.Minute, 15, BreakET)
                        ElseIf Night = True Then  '' For Night Shift
                            ShiftST = DateAdd(DateInterval.Minute, 30, ShiftST)
                            ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                            BreakST = DateAdd(DateInterval.Minute, 30, BreakST)
                            BreakET = DateAdd(DateInterval.Minute, 30, BreakET)

                        Else
                            ShiftST = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                            ShiftET = Me.DSPayRoll.View_All_Employees(0).Item("ShiftET")
                            BreakST = Me.DSPayRoll.View_All_Employees(0).Item("BreakST")
                            BreakET = Me.DSPayRoll.View_All_Employees(0).Item("BreakET")
                        End If
                    Else
                        ShiftST = Me.DSPayRoll.View_All_Employees(0).Item("ShiftST")
                        ShiftET = Me.DSPayRoll.View_All_Employees(0).Item("ShiftET")
                        BreakST = Me.DSPayRoll.View_All_Employees(0).Item("BreakST")
                        BreakET = Me.DSPayRoll.View_All_Employees(0).Item("BreakET")
                    End If
                    Try
                        Dim countAtt As Integer
                        countAtt = Me.Tbl_Hrm_Emp_AttTableAdapter.DuplicateAtt(Me.DSPayRoll.View_All_Employees(0).Item("CardNo"), AttDate1, AttendTime)
                        If countAtt = 0 Then
                            Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.DSPayRoll.View_All_Employees(0).Item("CardNo"), Me.DSPayRoll.View_All_Employees(0).Item("EmpID"), AttDate1, AttendTime, Nothing, True, Shift, Nothing, Me.DSPayRoll.View_All_Employees(0).Item("ShiftST"), ShiftET, BreakST, BreakET, FP, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, DecviceNo)
                            Me.CHECKINOUTDataGridView(4, i).Value = "Successfully Mark Attendence"

                        Else
                            Me.CHECKINOUTDataGridView(4, i).Value = "Already Attendence Mark"

                        End If
                        PaintGrid(0, i, Color.DarkGreen, Color.White)
                        PaintGrid(1, i, Color.DarkGreen, Color.White)
                        PaintGrid(2, i, Color.DarkGreen, Color.White)
                        PaintGrid(3, i, Color.DarkGreen, Color.White)
                        PaintGrid(4, i, Color.DarkGreen, Color.White)

                        If Me.DSPayRoll.View_All_Employees.Rows(0).Item("EndDate") < AttendTime.ToShortDateString Then
                            ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & cardNo & "] , Message: [Employee Card has been Expired]")
                            Me.CHECKINOUTDataGridView(4, 0).Value = "Employee Card has been Expired"
                        End If
                    Catch ex As Exception
                        ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & cardNo & "] , Message:[" & ex.Message & "]")
                        PaintGrid(0, i, Color.Red, Color.White)
                        PaintGrid(1, i, Color.Red, Color.White)
                        PaintGrid(2, i, Color.Red, Color.White)
                        PaintGrid(3, i, Color.Red, Color.White)
                        PaintGrid(4, i, Color.Red, Color.White)
                        Me.CHECKINOUTDataGridView(4, i).Value = "" & ex.Message & ""
                    End Try
                Else
                    Me.CHECKINOUTDataGridView(4, i).Value = "No Employee Active At this Card No"
                End If
            End If
            ToolStripProgressBar2.Value += 1
        Next
        MsgBox("Attendance Successfully Transfer to DB...! 'for Error check Error file'")
        ToolStripProgressBar2.Value = 0
    End Sub



    Private Sub frmAttAcessToDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_Att_DeviceTableAdapter.FillBy(Me.DSPayRoll.tbl_Att_Device)
        verify()

    End Sub

    Private Sub verify()
        Dim DateValue As String = Me.DateTimePicker1.Value.ToString
        Dim DateValue1 As String = Me.DateTimePicker2.Value.ToString
        Dim DivNO As String = ""
        Dim NewDivNo As String = Nothing
        If RadioButton1.Checked = True Or RadioButton3.Checked = True Then
            Me.Tbl_Att_DeviceSpecial_NewTableAdapter.Fill(Me.DSDevice.tbl_Att_DeviceSpecial_New)
            If Me.Tbl_Att_DeviceSpecial_NewBindingSource.Count > 0 Then
                Dim Ret As Integer = Me.Tbl_Att_DeviceSpecial_NewBindingSource.Count
                For i As Integer = 0 To Ret - 1
                    NewDivNo = Me.DSDevice.tbl_Att_DeviceSpecial_New(i).Item("DeviceNo")
                    If DivNO.Length = 0 Then
                        DivNO = "'" & NewDivNo & "'"
                    Else
                        DivNO = DivNO & ", '" & NewDivNo & "'"
                    End If
                Next

            End If


        End If

        Try
            If TabControl1.SelectedTab.Text = "ZkTeco" Then
                Label14.Text = "C:\Program Files (x86)\Att\att2000.mdb"
                If RadioButton4.Checked = True Then 'By Divice No:

                    ComboBox1.Enabled = True
                    Me.CHECKINOUTTableAdapter.FillBy(Me.Att2000DataSet.CHECKINOUT, Me.ComboBox1.Text, Me.DateTimePicker1.Value.ToString, Me.DateTimePicker2.Value.ToString)
                ElseIf RadioButton3.Checked Then 'All Record
                    ComboBox1.Enabled = False
                    Me.CHECKINOUTTableAdapter.Fill(Me.Att2000DataSet.CHECKINOUT, Me.DateTimePicker1.Value.ToString, Me.DateTimePicker2.Value.ToString)
                    Me.CHECKINOUTBindingSource.Filter = "AttTime>='" & DateValue & "'And AttTime <='" & DateValue1 & "'AND (NOT (DeviceNo IN (" & DivNO & ")))"

                ElseIf RadioButton1.Checked Then 'Special Devices
                    ComboBox1.Enabled = False
                    Me.CHECKINOUTTableAdapter.Fill(Me.Att2000DataSet.CHECKINOUT, Me.DateTimePicker1.Value.ToString, Me.DateTimePicker2.Value.ToString)
                    Me.CHECKINOUTBindingSource.Filter = "AttTime >='" & DateValue & "'And AttTime <='" & DateValue1 & "'And (DeviceNo IN (" & DivNO & "))"

                End If
            ElseIf TabControl1.SelectedTab.Text = "Anviz" Then
                Label14.Text = "C:\standard\Att2003.mdb"
                If RadioButton4.Checked = True Then 'By Divice No:

                    ComboBox1.Enabled = True
                    Me.CheckinoutTableAdapter1.FillBy(Me.Att2003DataSet.Checkinout, Me.ComboBox1.Text, Me.DateTimePicker1.Value.ToString, Me.DateTimePicker2.Value.ToString)
                ElseIf RadioButton3.Checked Then 'All Record
                    ComboBox1.Enabled = False
                    Me.CheckinoutTableAdapter1.Fill(Me.Att2003DataSet.Checkinout, Me.DateTimePicker1.Value.ToString, Me.DateTimePicker2.Value.ToString)
                    Me.CheckinoutBindingSource1.Filter = "CheckTime>='" & DateValue & "'And CheckTime<='" & DateValue1 & "'AND (NOT (DeviceNo IN (" & DivNO & ")))"

                ElseIf RadioButton1.Checked Then 'Special Devices
                    ComboBox1.Enabled = False
                    Me.CheckinoutTableAdapter1.Fill(Me.Att2003DataSet.Checkinout, Me.DateTimePicker1.Value.ToString, Me.DateTimePicker2.Value.ToString)
                    Me.CheckinoutBindingSource1.Filter = "CheckTime >='" & DateValue & "'And CheckTime<='" & DateValue1 & "'And (DeviceNo IN (" & DivNO & "))"
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

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
    Sub PaintGrid(ByVal i As Int16, ByVal j As Int16, ByVal BackColor As System.Drawing.Color, ByVal ForeColored As System.Drawing.Color)
        If TabControl1.SelectedTab.Text = "ZkTeco" Then
            Me.DataGridView1(i, j).Style.BackColor = BackColor
            Me.DataGridView1(i, j).Style.ForeColor = ForeColored
        ElseIf TabControl1.SelectedTab.Text = "Anviz" Then
            Me.CHECKINOUTDataGridView(i, j).Style.BackColor = BackColor
            Me.CHECKINOUTDataGridView(i, j).Style.ForeColor = ForeColored
        End If

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TabControl1.SelectedTab = TabPage1
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TabControl1.SelectedTab = TabPage2
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel1_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub LinkLabel2_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel2.MouseEnter
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel2_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel2.MouseLeave
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        verify()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        verify()
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        verify()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
        'verify()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        verify()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        verify()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        verify()
    End Sub
End Class