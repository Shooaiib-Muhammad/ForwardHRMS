Imports System.Data.OleDb
Imports System.IO
Imports System.Threading
Imports System.Data.Odbc
Imports System.Data

Public Class frmBoofeMealAttendance
    'Dim cn As OdbcConnection = New OdbcConnection("Dsn=dbServerHRM")
    Private Sub frmAttendanceAccessToDB1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBuffetAttendance.tbl_HRM_Emp_Att_Meal' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_Emp_Att_MealTableAdapter1.Fill(Me.DSBuffetAttendance.tbl_HRM_Emp_Att_Meal)
        'TODO: This line of code loads data into the 'DSAccessToDB.View_Meal_Att_Management' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DSAutoAtt.tbl_HRM_Emp_Att_Meal' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_Emp_Att_MealTableAdapter.Fill(Me.DSAutoAtt.tbl_HRM_Emp_Att_Meal)
        'TODO: This line of code loads data into the 'DSAccessToDB.CHECKINOUT_1' table. You can move, or remove it, as needed.
        'Me.CHECKINOUT_1TableAdapter.Fill(Me.DSAccessToDB.CHECKINOUT_1)
        'TODO: This line of code loads data into the 'DSAutoAtt.tbl_Hrm_Emp_Att_Client1_1' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_Emp_Att_Client1_1TableAdapter.Fill(Me.DSAutoAtt.tbl_Hrm_Emp_Att_Client1_1)
        'If RadioButton1.Checked Then
        'Me.CheckinoutTableAdapter.Fill(Me.DSAccessToDB.Checkinout)
        LoadAttendance(1)
        'End If
        'If frmLogin.LoginId = 1 Then
        '    Me.Button2.Visible = True
        'Else
        '    Me.Button2.Visible = False
        'End If
    End Sub
    Dim obj As New UtilityClass
    Dim OStremWriter As StreamWriter
    Dim FilePath As String = Nothing
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
    Dim flag As Boolean = False
    Dim EntryFlag As Boolean = False
    Dim INOUTflag As Boolean = False
    Dim List As New ArrayList
    Function ATT_IN(ByVal Card As Integer, ByVal AttDate As Date, ByVal Fast As Boolean) As Boolean
        Dim Flag1 As Boolean = False
        If Fast = True Then
            If Not List.Contains(Card) Then
                Flag1 = False
                List.Add(Card)
            Else
                Flag1 = True
            End If
        Else
            'If Me.Tbl_Hrm_Emp_Att1TableAdapter.Fill_IN(DSAutoAtt.tbl_Hrm_Emp_Att1, Card, AttDate) > 0 Then
            '    Flag1 = True
            'Else
            '    Flag1 = False
            'End If
        End If
        Return Flag1
        'Return False
    End Function
    Function ATT_OUT(ByVal Card As Integer, ByVal AttDate As Date) As Boolean
        'Dim Flag1 As Boolean = False
        'If Me.Tbl_Hrm_Emp_Att1TableAdapter.Fill_Out(DSAutoAtt.tbl_Hrm_Emp_Att1, Card, AttDate) > 0 Then
        '    Flag1 = True
        'End If
        'Return Flag1
        Return False
    End Function
    'Dim SystemId As Integer = 0
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    If Directory.Exists("C:\Sports Conteen Access Attendance Log Files") Then
    '    Else
    '        Directory.CreateDirectory("C:\Sports Canteen Access Attendance Log Files")
    '    End If
    '    Dim FilePath As String = "C:\Sports Canteen Access Attendance Log Files\ Dated " & Now.Year & "-" & Now.Month & "-" & Now.Day & ".txt"
    '    Dim AttTime, AttTime1 As DateTime
    '    Dim AttDate As Date
    '    Dim FP As String
    '    Dim Value As Integer = 0
    '    ToolStripProgressBar1.Value = 0
    '    Dim dgResult As DialogResult = MessageBox.Show("Are You Sure Want to Transfer Access Attendance To DB ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    '    If dgResult = Windows.Forms.DialogResult.Yes Then
    '        Using cn As OdbcConnection = New OdbcConnection("Dsn=dbServerHRM")
    '            Dim TechCm As New Odbc.OdbcCommand
    '            If cn.State = Data.ConnectionState.Closed Then
    '                Try
    '                    cn.Open()
    '                    TechCm.CommandText = "SET DEADLOCK_PRIORITY LOW"
    '                    TechCm.CommandText = "SET LOCK_TIMEOUT 2000"
    '                    TechCm.Connection = cn
    '                Catch ex As Exception
    '                    'MsgBox("Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department")
    '                    'lblMsg.Text = "Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department"
    '                    'LogFileWriter("C:\Sports Attendance Log Files\Sports Attendance Log File Dated " & Now.Year & "-" & Now.Month & "-" & Now.Day & ".txt", "Log Write Time: [" & Now & "], Message: [Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department]")
    '                    'Exit Sub
    '                End Try
    '            Else
    '                TechCm.CommandText = "SET DEADLOCK_PRIORITY LOW"
    '                TechCm.CommandText = "SET LOCK_TIMEOUT 2000"
    '                TechCm.Connection = cn
    '            End If
    '        End Using

    '        'Dim cn As OleDbConnection = New OdbcConnection("Dsn=dbServerHRM")
    '        'If cn.State = Data.ConnectionState.Closed Then

    '        '    Try
    '        '        cn.Open()
    '        '        Dim TechCm As New Odbc.OdbcCommand
    '        '        TechCm.CommandText = "SET DEADLOCK_PRIORITY LOW"
    '        '        TechCm.CommandText = "SET LOCK_TIMEOUT 2000"
    '        '        TechCm.Connection = cn
    '        '    Catch ex As Exception
    '        '        'MsgBox("Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department")
    '        '        'lblMsg.Text = "Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department"
    '        '        'LogFileWriter("C:\Sports Attendance Log Files\Sports Attendance Log File Dated " & Now.Year & "-" & Now.Month & "-" & Now.Day & ".txt", "Log Write Time: [" & Now & "], Message: [Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department]")
    '        '        'Exit Sub
    '        '    End Try
    '        'End If

    '        ToolStripProgressBar1.Maximum = Me.DataGridView1.RowCount + 1
    '        For i As Integer = 0 To Me.DataGridView1.RowCount - 1
    '            flag = False
    '            ToolStripProgressBar1.PerformStep()
    '            AttTime = Me.DataGridView1(3, i).Value.ToString
    '            If RadioButton1.Checked Then
    '                If ATT_IN(Me.DataGridView1(1, i).Value, CDate(Me.DataGridView1(2, i).Value).ToShortDateString, CheckBox1.CheckState) = True Then
    '                    flag = True
    '                    EntryFlag = False
    '                    PaintGrid(0, i, Color.Maroon, Color.White)
    '                    PaintGrid(1, i, Color.Maroon, Color.White)
    '                    PaintGrid(2, i, Color.Maroon, Color.White)
    '                Else
    '                    If Me.View_Att_EmpVerifyTableAdapter.Fill(Me.DSDisplayEI.View_Att_EmpVerify, Me.DataGridView1(1, i).Value) > 0 Then
    '                        EntryFlag = True
    '                        INOUTflag = True
    '                    Else
    '                        EntryFlag = False
    '                        INOUTflag = True
    '                        ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(1, i).Value & "] , Message: [Card is not Registered]")
    '                        PaintGrid(0, i, Color.Red, Color.White)
    '                        PaintGrid(1, i, Color.Red, Color.White)
    '                        PaintGrid(2, i, Color.Red, Color.White)
    '                    End If
    '                    'AttTime = Me.DataGridView1(3, i).Value
    '                    'If AttTime < DateAdd(DateInterval.Minute, -120, DateTime.Parse(AttTime.ToShortDateString() & " " & Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime").ToShortTimeString())) Then
    '                    '    AttDate = DateAdd(DateInterval.Day, -1, AttTime.Date)
    '                    '    If ATT_IN(Me.DataGridView1(1, i).Value, AttDate) = True Then
    '                    '        flag = True
    '                    '        EntryFlag = False
    '                    '    Else
    '                    '        EntryFlag = True
    '                    '        INOUTflag = True
    '                    '    End If
    '                    'Else
    '                    'End If
    '                End If
    '            ElseIf RadioButton2.Checked Then
    '                If Me.View_Att_EmpVerifyTableAdapter.Fill(Me.DSDisplayEI.View_Att_EmpVerify, Me.DataGridView1(1, i).Value) > 0 Then
    '                    AttTime = Me.DataGridView1(3, i).Value
    '                    If AttTime < DateAdd(DateInterval.Minute, -120, DateTime.Parse(AttTime.ToShortDateString() & " " & Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime").ToShortTimeString())) Then
    '                        'Out With 1 day Less
    '                        AttDate = DateAdd(DateInterval.Day, -1, AttTime.Date)
    '                    Else
    '                        AttDate = CDate(Me.DataGridView1(2, i).Value).ToShortDateString
    '                    End If
    '                    If ATT_OUT(Me.DataGridView1(1, i).Value, AttDate) = True Then
    '                        flag = True
    '                        EntryFlag = False
    '                        PaintGrid(0, i, Color.Maroon, Color.White)
    '                        PaintGrid(1, i, Color.Maroon, Color.White)
    '                        PaintGrid(2, i, Color.Maroon, Color.White)
    '                    Else
    '                        AttTime1 = Me.DataGridView1(3, i).Value
    '                        'If Me.Tbl_Hrm_Emp_Att1TableAdapter.FillBy(Me.DSAutoAtt.tbl_Hrm_Emp_Att1, Me.DataGridView1(1, i).Value, Me.DataGridView1(3, i).Value) > 0 Then
    '                        '    flag = True
    '                        '    EntryFlag = False
    '                        '    PaintGrid(0, i, Color.Maroon, Color.White)
    '                        '    PaintGrid(1, i, Color.Maroon, Color.White)
    '                        '    PaintGrid(2, i, Color.Maroon, Color.White)
    '                        'Else
    '                        EntryFlag = True
    '                        INOUTflag = False
    '                        'End If
    '                    End If
    '                Else
    '                    ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(1, i).Value & "] , Message: [Card is not Registered]")
    '                    PaintGrid(0, i, Color.Red, Color.White)
    '                    PaintGrid(1, i, Color.Red, Color.White)
    '                    PaintGrid(2, i, Color.Red, Color.White)
    '                End If
    '            End If
    '            '
    '            If EntryFlag = True Then
    '                If Me.View_Att_EmpVerifyBindingSource.Count > 0 Then
    '                    'AttTime = Me.DataGridView1(3, i).Value
    '                    AttTime = Format(Me.DataGridView1(3, i).Value, "dd/MM/yyyy hh:mm tt")
    '                    AttDate = CDate(Me.DataGridView1(2, i).Value).ToShortDateString
    '                    'SystemId = Me.CheckinoutTableAdapter.SensorId(AttTime, Me.DataGridView1(1, i).Value)
    '                    FP = obj.ReturnFP(AttTime.Month, AttTime.Year)
    '                    Dim IpNo As Integer = 0 + Me.DataGridView1(5, i).Value
    '                    Dim Ip As String = "192.168.30." + IpNo.ToString
    '                    Try
    '                        flag = False
    '                        If INOUTflag = False Then
    '                            If AttTime < DateAdd(DateInterval.Minute, -120, DateTime.Parse(AttTime.ToShortDateString() & " " & Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime").ToShortTimeString())) Then
    '                                'Out With 1 day Less
    '                                AttDate = DateAdd(DateInterval.Day, -1, AttTime.Date)
    '                            Else
    '                                AttDate = CDate(Me.DataGridView1(2, i).Value).ToShortDateString
    '                            End If
    '                            'Else
    '                            'AttTime = Me.DataGridView1(3, i).Value
    '                            '    If AttTime < DateAdd(DateInterval.Minute, -120, DateTime.Parse(AttTime.ToShortDateString() & " " & Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime").ToShortTimeString())) Then
    '                            '        AttDate = DateAdd(DateInterval.Day, -1, AttTime.Date)
    '                            '        If ATT_IN(Me.DataGridView1(1, i).Value, AttDate) = True Then
    '                            '            flag = True
    '                            '            EntryFlag = False
    '                            '        Else
    '                            '            EntryFlag = True
    '                            '            INOUTflag = True
    '                            '        End If
    '                            '    Else
    '                            '        EntryFlag = True
    '                            '        INOUTflag = True
    '                            '    End If
    '                        End If
    '                        If EntryFlag = True Then
    '                            Dim ShiftET As DateTime = Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SEndTime")
    '                            Dim Shift As Integer = Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("ShiftID")
    '                            Dim BreakST As DateTime = Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SBreakStartTime")
    '                            Dim BreakET As DateTime = Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SBreakEndTime")
    '                            If WeekdayName(Weekday(AttDate)) = "Friday" And Shift = 1 Then
    '                                ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
    '                                BreakST = DateAdd(DateInterval.Minute, 30, BreakST)
    '                                BreakET = DateAdd(DateInterval.Minute, 60, BreakET)
    '                            End If
    '                            Try
    '                                Expflag = False
    '                                'Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.DataGridView1(1, i).Value, AttDate, AttTime, Nothing, Nothing, False, INOUTflag, Shift, Ip, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime"), ShiftET, BreakST, BreakET, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("EmpId"), FP, Nothing, Nothing, Now)
    '                            Catch ex As Exception
    '                                Using cn As OdbcConnection = New OdbcConnection("Dsn=dbServerHRM")
    '                                    Dim TechCm As New Odbc.OdbcCommand
    '                                    If cn.State = Data.ConnectionState.Closed Then
    '                                        Try
    '                                            cn.Open()
    '                                            TechCm.CommandText = "SET DEADLOCK_PRIORITY LOW"
    '                                            TechCm.CommandText = "SET LOCK_TIMEOUT 2000"
    '                                            TechCm.Connection = cn
    '                                        Catch ex2 As Exception
    '                                            'MsgBox("Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department")
    '                                            'lblMsg.Text = "Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department"
    '                                            'LogFileWriter("C:\Sports Attendance Log Files\Sports Attendance Log File Dated " & Now.Year & "-" & Now.Month & "-" & Now.Day & ".txt", "Log Write Time: [" & Now & "], Message: [Connection Error:" & vbCrLf & "No Records Retrieved from DBServer, Either Connection to DBServer have been Broken OR Network have been Disconnected." & vbCrLf & "So Contact Network/Database Administrator in IT Department]")
    '                                            'Exit Sub
    '                                        End Try
    '                                    Else
    '                                        TechCm.CommandText = "SET DEADLOCK_PRIORITY LOW"
    '                                        TechCm.CommandText = "SET LOCK_TIMEOUT 2000"
    '                                        TechCm.Connection = cn
    '                                    End If
    '                                    Try
    '                                        'Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.DataGridView1(1, i).Value, AttDate, AttTime, Nothing, Nothing, False, INOUTflag, Shift, Ip, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime"), ShiftET, BreakST, BreakET, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("EmpId"), FP, Nothing, Nothing, Now)
    '                                    Catch ex3 As Exception
    '                                        Try
    '                                            'Me.Tbl_Hrm_Emp_Att_Client1_1TableAdapter.Insert(Me.DataGridView1(1, i).Value, AttDate, AttTime, Nothing, Nothing, False, INOUTflag, Shift, Ip, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime"), ShiftET, BreakST, BreakET, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("EmpId"), FP, Nothing, Nothing, Now)
    '                                        Catch ex5 As Exception
    '                                            Expflag = True
    '                                            ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(1, i).Value & "] , Message:[" & ex5.Message & "]")
    '                                        End Try
    '                                    End Try
    '                                End Using
    '                            End Try
    '                        End If
    '                        'If RadioButton1.Checked Then
    '                        '    If Me.Tbl_Hrm_Emp_AttTableAdapter.FillBy1_In(DSAutoAtt.tbl_Hrm_Emp_Att, Me.DataGridView1(1, i).Value, CDate(Me.DataGridView1(2, i).Value).ToShortDateString) > 0 Then
    '                        '        flag = True
    '                        '        PaintGrid(0, i, Color.Maroon, Color.White)
    '                        '        PaintGrid(1, i, Color.Maroon, Color.White)
    '                        '        PaintGrid(2, i, Color.Maroon, Color.White)
    '                        '    Else
    '                        '        Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.DataGridView1(1, i).Value, CDate(Me.DataGridView1(2, i).Value).ToShortDateString, AttTime, Nothing, Nothing, False, True, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("ShiftID"), Ip, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime"), Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SEndTime"), Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SBreakStartTime"), Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SBreakEndTime"), Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("EmpId"), FP, Nothing, Nothing, Now)
    '                        '    End If
    '                        'ElseIf RadioButton2.Checked Then
    '                        '    If Me.Tbl_Hrm_Emp_AttTableAdapter.FillBy1_Out(DSAutoAtt.tbl_Hrm_Emp_Att, Me.DataGridView1(1, i).Value, CDate(Me.DataGridView1(2, i).Value).ToShortDateString) > 0 Then
    '                        '        flag = True
    '                        '        PaintGrid(0, i, Color.Maroon, Color.White)
    '                        '        PaintGrid(1, i, Color.Maroon, Color.White)
    '                        '        PaintGrid(2, i, Color.Maroon, Color.White)
    '                        '    Else
    '                        '        Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.DataGridView1(1, i).Value, CDate(Me.DataGridView1(2, i).Value).ToShortDateString, AttTime, Nothing, Nothing, False, False, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("ShiftID"), Ip, Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SStartTime"), Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SEndTime"), Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SBreakStartTime"), Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("SBreakEndTime"), Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("EmpId"), FP, Nothing, Nothing, Now)
    '                        '    End If
    '                        'End If
    '                        If flag = False And Expflag = False Then
    '                            If Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("ExpiryDate") >= AttTime.ToShortDateString Then
    '                                PaintGrid(0, i, Color.DarkGreen, Color.White)
    '                                PaintGrid(1, i, Color.DarkGreen, Color.White)
    '                                PaintGrid(2, i, Color.DarkGreen, Color.White)
    '                            Else
    '                                ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(1, i).Value & "] , Message: [Employee Card has been Expired]")
    '                                PaintGrid(0, i, Color.Red, Color.White)
    '                                PaintGrid(1, i, Color.Red, Color.White)
    '                                PaintGrid(2, i, Color.Red, Color.White)
    '                            End If
    '                        Else
    '                            PaintGrid(0, i, Color.Maroon, Color.White)
    '                            PaintGrid(1, i, Color.Maroon, Color.White)
    '                            PaintGrid(2, i, Color.Maroon, Color.White)
    '                        End If
    '                    Catch ex As Exception
    '                        ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(1, i).Value & "] , Message:[" & ex.Message & "]")
    '                        PaintGrid(0, i, Color.Red, Color.White)
    '                        PaintGrid(1, i, Color.Red, Color.White)
    '                        PaintGrid(2, i, Color.Red, Color.White)
    '                    End Try
    '                End If
    '            End If
    '            If CheckBox1.CheckState = CheckState.Checked Then
    '                Thread.Sleep(2)
    '            Else
    '                Thread.Sleep(12)
    '            End If

    '            Application.DoEvents()
    '        Next
    '        ToolStripProgressBar1.Value = Me.DataGridView1.RowCount
    '        MsgBox("Attendance Transfer from Access To DB Successfully...........", MsgBoxStyle.Information)
    '        ToolStripProgressBar1.Value = 0
    '    End If
    'End Sub
    Dim Expflag As Boolean = False
    Sub PaintGrid(ByVal i As Int16, ByVal j As Int16, ByVal BackColor As System.Drawing.Color, ByVal ForeColored As System.Drawing.Color)
        Me.DataGridView1(i, j).Style.BackColor = BackColor
        Me.DataGridView1(i, j).Style.ForeColor = ForeColored
    End Sub
    Private Sub DateTimePicker1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        LoadAttendance(1)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        LoadAttendance(1)
    End Sub
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Id"></param>
    Private Sub LoadAttendance(ByVal Id As String)
        Try
            Me.View_Meal_Att_Management_NewTableAdapter.Fill(Me.DSBuffetAttendance.View_Meal_Att_Management_New, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        'Dim DateValue As String = Me.DateTimePicker1.Value.ToString
        'Dim DateValue1 As String = Me.DateTimePicker2.Value.ToString
        'If RadioButton3.Checked Then
        '    Me.CHECKINOUT_1BindingSource.Filter = "AttTime >='" & DateValue & "'And AttTime <='" & DateValue1 & "'And DeviceNo<>'" & 52 & "'"
        '    'Me.CheckinoutBindingSource.Filter = "AttTime >='" & DateValue & "'And AttTime <='" & DateValue1 & "'"
        'ElseIf RadioButton4.Checked Then
        '    'If CInt(Id) = 17 Then
        '    '    Me.CheckinoutTableAdapter.FillBy1(Me.DSAccessToDB.Checkinout)
        '    '    Me.CheckinoutBindingSource.Filter = "AttTime >='" & DateValue & "'And AttTime <='" & DateValue1 & "'"
        '    'Else
        '    'Me.CHECKINOUT_1BindingSource.Filter = "AttTime >='" & DateValue & "'And AttTime <='" & DateValue1 & "'And DeviceNo='" & Me.ComboBox1.Text & "'"
        '    Me.CHECKINOUT_1BindingSource.Filter = "AttTime >='" & DateValue & "'And AttTime <='" & DateValue1 & "'And DeviceNo='" & 52 & "'"
        '    'End If
        'End If

    End Sub

    'Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.ComboBox1.Enabled = False
    '    LoadAttendance(1)
    'End Sub

    'Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.ComboBox1.Enabled = True
    '    LoadAttendance(1)
    'End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    LoadAttendance(ComboBox1.Text)
    'End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    'End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        'If RadioButton1.Checked Then
        '    Me.CheckinoutTableAdapter.Fill(Me.DSAccessToDB.Checkinout)
        '    LoadAttendance(1)
        'ElseIf RadioButton2.Checked Then
        '    'If Me.ComboBox1.Text = 17 Then
        '    'Else
        '    'Me.CheckinoutTableAdapter.Fill(Me.DSAccessToDB.Checkinout)
        '    LoadAttendance(1)
        '    'End If

        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure Want to Transfer Meal Attendance To DB ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If dgResult = 6 Then
            Try
                'Me.View_Meal_Att_ManagementTableAdapter.Fill(Me.DSAccessToDB.View_Meal_Att_Management, DateTimePicker1.Text, Me.DateTimePicker2.Text)
            Catch ex As Exception

            End Try
            If Directory.Exists("C:\Sports Canteen Access Attendance Log Files") Then
            Else
                Directory.CreateDirectory("C:\Sports Canteen Access Attendance Log Files")
            End If
            Dim FilePath As String = "C:\Sports Canteen Access Attendance Log Files\ Dated " & Now.Year & "-" & Now.Month & "-" & Now.Day & ".txt"
            ToolStripProgressBar1.Maximum = Me.DataGridView1.RowCount - 1
            For i As Integer = 0 To Me.DataGridView1.RowCount - 1
                If Me.View_Display_EmpInfoTableAdapter.FillBy(DSDisplayEI.View_Display_EmpInfo, Me.DataGridView1(1, i).Value) > 0 Then
                    Try
                        Me.Tbl_HRM_Emp_Att_MealTableAdapter.Insert(Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("EmpId"), Me.DataGridView1(1, i).Value, CDate(Me.DataGridView1(2, i).Value).ToShortDateString, Now.Date, Nothing, Now, Nothing, 1, "Managment Buffet")
                        'If Me.View_Att_EmpVerifyTableAdapter.Fill(Me.DSDisplayEI.View_Att_EmpVerify, Me.DataGridView1(0, i).Value) > 0 Then
                        '    AttTime = Me.DataGridView1(1, i).Value
                        '    FP = obj.ReturnFP(AttTime.Month, AttTime.Year)
                        '    Try
                        '        If RadioButton1.Checked Then
                        'Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.DataGridView1(0, i).Value, CDate(Me.DataGridView1(1, i).Value).ToShortDateString, AttTime, Nothing, Nothing, False, True, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("ShiftID"), "192.168.30.151", Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("EmpId"), FP, Nothing, Nothing, Now)
                        '        ElseIf RadioButton2.Checked Then
                        '            Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.DataGridView1(0, i).Value, CDate(Me.DataGridView1(1, i).Value).ToShortDateString, AttTime, Nothing, Nothing, False, False, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("ShiftID"), "192.168.30.151", Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("EmpId"), FP, Nothing, Nothing, Now)
                        '        End If
                        '        If Me.DSDisplayEI.View_Att_EmpVerify.Rows(0).Item("ExpiryDate") >= AttTime.ToShortDateString Then
                        PaintGrid(0, i, Color.DarkGreen, Color.White)
                        PaintGrid(1, i, Color.DarkGreen, Color.White)
                        PaintGrid(2, i, Color.DarkGreen, Color.White)
                        '        Else
                        '            ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(0, i).Value & "] , Message: [Employee Card has been Expired]")
                        '            PaintGrid(0, i, Color.Red, Color.White)
                        '            PaintGrid(1, i, Color.Red, Color.White)
                        '            PaintGrid(2, i, Color.Red, Color.White)
                        '        End If
                    Catch ex As Exception
                        ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(1, i).Value & "] , Message:[" & ex.Message & "]")
                        PaintGrid(0, i, Color.Red, Color.White)
                        PaintGrid(1, i, Color.Red, Color.White)
                        PaintGrid(2, i, Color.Red, Color.White)
                    End Try
                End If
                'End If
                Thread.Sleep(2)
                Application.DoEvents()
                ToolStripProgressBar1.Value = i
            Next
            MsgBox("Record Saved Successfully")
            ToolStripProgressBar1.Value = 0
        End If
    End Sub

End Class