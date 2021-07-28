Imports System.Data.OleDb
Imports System.Data
'Imports Microsoft.Office.Core
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Net
Public Class frmAutoAttConnEntry
    'Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
    '    If RadioButton1.Checked = True Then
    '        Me.DateTimePicker1.Enabled = False
    '    End If
    'End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            Me.DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Me.DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim LineIn As String
        Dim MyAttTime As DateTime
        Dim MyCardNo As Integer
        Dim oRead As StreamReader


        Dim FP As String
        Dim Utility_Obj As New UtilityClass()
        Dim dgResult As DialogResult
        'On Error GoTo ErrorHandler

        If tbFilePath.Text = "Browse attendance log file here to upload (Only txt files)" Then
            MsgBox("File Not Browsed")
        Else
            If File.Exists(tbFilePath.Text) Then
                oRead = File.OpenText(tbFilePath.Text)
                ToolStripProgressBar1.Maximum = 1
                ToolStripProgressBar1.Value = 0
                dgResult = MessageBox.Show("Are You sure you want to save attendance log file in database? As well you have selected proper IN/OUT status.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If dgResult = 6 Then
                    While oRead.Peek <> -1
                        ToolStripProgressBar1.Maximum += 1
                        LineIn = oRead.ReadLine()

                        'If RadioButton1.Checked = True Then
                        '    MyAttTime = CType(LineIn.Substring(LineIn.IndexOf("[") + 1, LineIn.IndexOf("]") - LineIn.IndexOf("[") - 1), Date)
                        '    MyCardNo = CType(LineIn.Substring(LineIn.IndexOf("[", LineIn.IndexOf("]") + 1) + 1, LineIn.IndexOf("]", LineIn.IndexOf("]") + 1) - LineIn.IndexOf("[", LineIn.IndexOf("]") + 1) - 1), Integer)
                        If RadioButton2.Checked = True Then
                            MyAttTime = CType(DateTimePicker1.Text, Date)
                            MyCardNo = CType(LineIn.Substring(1, 4), Integer)
                        ElseIf RadioButton3.Checked = True Then
                            MyAttTime = CType(DateTimePicker1.Text, Date)
                            Try
                                MyCardNo = CType(LineIn.Trim, Integer)
                            Catch ex As Exception
                                MsgBox("Error Found")
                                GoTo ErrorHandler
                            End Try
                        End If

                        If Me.View_Active_CardsTableAdapter.Fill(Me.DSPayRoll.View_Active_Cards, MyCardNo) = 1 Then

                            If Me.View_All_EmployeesTableAdapter.Fill(Me.DSPayRoll.View_All_Employees, Val(Me.DSPayRoll.View_Active_Cards(0).Item("EmpID"))) > 0 Then
                                If MyAttTime.Date >= Me.DSPayRoll.View_All_Employees.Rows(0).Item("DateOfJoning") Then
                                    FP = Utility_Obj.ReturnFP(MyAttTime.Month, MyAttTime.Year)
                                    Dim ShiftST As DateTime
                                    Dim ShiftET As DateTime
                                    Dim BreakST As DateTime
                                    Dim BreakET As DateTime



                                    Dim Night As Boolean = Me.DSPayRoll.View_All_Employees.Rows(0).Item("NightAndFriday")
                                    Dim Day As Boolean = Me.DSPayRoll.View_All_Employees.Rows(0).Item("FridayBreakStatus")
                                    'MsgBox()

                                    If WeekdayName(Weekday(MyAttTime)) = "Friday" Then
                                        If Day = True Then '''' For All SHif
                                            ShiftST = DateAdd(DateInterval.Minute, 0, Me.DSPayRoll.View_All_Employees(0).Item("ShiftST"))
                                            ShiftET = DateAdd(DateInterval.Minute, 30, Me.DSPayRoll.View_All_Employees(0).Item("ShiftET"))
                                            BreakST = DateAdd(DateInterval.Minute, 30, Me.DSPayRoll.View_All_Employees(0).Item("BreakST"))
                                            BreakET = DateAdd(DateInterval.Minute, 60, Me.DSPayRoll.View_All_Employees(0).Item("BreakET"))
                                        ElseIf Night = True Then  '' For Night Shift
                                            ShiftST = DateAdd(DateInterval.Minute, 30, Me.DSPayRoll.View_All_Employees(0).Item("ShiftST"))
                                            ShiftET = DateAdd(DateInterval.Minute, 30, Me.DSPayRoll.View_All_Employees(0).Item("ShiftET"))
                                            BreakST = DateAdd(DateInterval.Minute, 30, Me.DSPayRoll.View_All_Employees(0).Item("BreakST"))
                                            BreakET = DateAdd(DateInterval.Minute, 30, Me.DSPayRoll.View_All_Employees(0).Item("BreakET"))
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


                                    Me.Tbl_Hrm_Cont_AttTableAdapter.Insert(Me.DSPayRoll.View_Active_Cards(0).Item("CardNo"), Me.DSPayRoll.View_Active_Cards(0).Item("EmpID"), MyAttTime.Date, MyAttTime, Nothing, True, Me.DSPayRoll.View_All_Employees(0).Item("ShiftID"), Nothing, ShiftST, ShiftET, BreakST, BreakET, FP, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                                    'Me.Tbl_Hrm_Emp_AttTableAdapter.Insert(Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H1(0).Item("CardNo"), MyAttTime.Date, MyAttTime, Nothing, Nothing, True, True, Me.DSDisplayEI.View_Display_EmpInfo(0).Item("ShiftID"), IpAddr, Me.DSDisplayEI.View_Display_EmpInfo(0).Item("SStartTime"), Me.DSDisplayEI.View_Display_EmpInfo(0).Item("SEndTime"), Me.DSDisplayEI.View_Display_EmpInfo(0).Item("SBreakStartTime"), Me.DSDisplayEI.View_Display_EmpInfo(0).Item("SBreakEndTime"), Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H1(0).Item("EmpId"), FP, Now, Me.DSDisplayEI.View_Display_EmpInfo(0).Item("JTEmpID"))
                                Else
                                    'MsgBox("Attendance Before Joining Date Is Not Allowed at Card Number " & MyCardNo & " from excel sheet, Please note this card number if you required")
                                End If

                            End If
                        Else
                            MsgBox("No employee registered at Card Number " & MyCardNo & " from excel sheet, Please note this card number if you required")
                        End If
ErrorHandler:
                        ToolStripProgressBar1.Value += 1
                    End While
                    oRead.Close()
                    MsgBox("Record Saved Successfully")
                    ToolStripProgressBar1.Value = 0
                End If
            Else
                MsgBox("File Not Found")
            End If
        End If
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
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

    Private Sub frmAutoAttEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



End Class