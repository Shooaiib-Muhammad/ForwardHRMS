Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Office.Core
Imports System.IO
Imports Microsoft.VisualBasic
Public Class CanteenAttendanceUploading
    Dim GlobalPathStr As String
    Private Sub frmAutoAttendanceUploading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAutoAtt.tbl_Hrm_Emp_Att1' table. You can move, or remove it, as needed.
        'Me.Tbl_Hrm_Emp_Att1TableAdapter.Fill(Me.DSAutoAtt.tbl_Hrm_Emp_Att1)
        'TODO: This line of code loads data into the 'DSAutoAtt.tbl_HRM_Emp_Att_Meal' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_Emp_Att_MealTableAdapter.Fill(Me.DSAutoAtt.tbl_HRM_Emp_Att_Meal)
    End Sub
    Dim Count As Integer
    Dim dgResult As DialogResult
    Dim PathReader As StreamReader

    Dim obj As New UtilityClass
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Value As Integer = 0
        ToolStripProgressBar1.Value = 0
        If Directory.Exists("C:\Excel Attendance Log Files") Then
        Else
            Directory.CreateDirectory("C:\Excel Attendance Log Files")
        End If
        Dim FP As String = Nothing
        If DataGridView1.RowCount > 0 Then
            FilePath = "C:\Excel Attendance Log Files\ Dated " & Now.Year & "-" & Now.Month & "-" & Now.Day & ".txt"
            Dim AttTime As DateTime
            ToolStripProgressBar1.Maximum = TotalRowLabel.Text
            dgResult = MessageBox.Show("Are You Sure Want to save Excel Attendance file in database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dgResult = 6 Then
                For i As Integer = 0 To Me.DataGridView1.RowCount - 1
                    'If Me.View_Display_EmpInfoTableAdapter.FillBy(DSDisplayEI.View_Display_EmpInfo, Me.DataGridView1(0, i).Value) > 0 Then
                    'Try
                    'Me.Tbl_HRM_Emp_Att_MealTableAdapter.Insert(Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("EmpId"), Me.DataGridView1(0, i).Value, CDate(Me.DataGridView1(1, i).Value).ToShortDateString, Now.Date, Nothing, Now, Nothing, 1)

                    'If Me.View_Att_EmpVerifyTableAdapter.Fill(Me.DSDisplayEI.View_Att_EmpVerify, Me.DataGridView1(0, i).Value) > 0 Then

                    If Me.View_Display_EmpInfoTableAdapter.FillBy(DSDisplayEI.View_Display_EmpInfo, Me.DataGridView1(0, i).Value) > 0 Then
                        If CDate(Me.DataGridView1(1, i).Value).ToShortDateString >= Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("DateOfJoning") Then 'Check DOJ
                            AttTime = Me.DataGridView1(1, i).Value
                            FP = obj.ReturnFP(AttTime.Month, AttTime.Year)
                            Dim Ip As String = "192.168.30." + Me.DataGridView1(2, i).Value.ToString
                            Try
                                'If RadioButton1.Checked Then
                                '    Me.Tbl_Hrm_Emp_Att1TableAdapter.Insert(Me.DataGridView1(0, i).Value, CDate(Me.DataGridView1(1, i).Value).ToShortDateString, AttTime, Nothing, Nothing, False, True, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("ShiftID"), Ip, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("EmpId"), FP, Nothing, Nothing, Now)
                                'ElseIf RadioButton2.Checked Then
                                Dim AttDate As Date
                                If AttTime < DateAdd(DateInterval.Minute, -120, DateTime.Parse(AttTime.ToShortDateString() & " " & Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime").ToShortTimeString())) Then
                                    'Out With 1 day Less
                                    AttDate = DateAdd(DateInterval.Day, -1, AttTime.Date)
                                Else
                                    AttDate = CDate(Me.DataGridView1(1, i).Value).ToShortDateString
                                End If
                                '''
                                'FridayBreakStatus
                                Dim SHiftST As DateTime
                                Dim ShiftET As DateTime
                                Dim BreakST As DateTime
                                Dim BreakET As DateTime
                                'If WeekdayName(Weekday(AttDate1)) = "Friday" And Me.DSPayRoll.View_All_Employees(0).Item("FridayBreakStatus") = True Then
                                '    ShiftET = DateAdd(DateInterval.Minute, 30, ShiftET)
                                '    BreakST = DateAdd(DateInterval.Minute, 30, BreakST)
                                '    BreakET = DateAdd(DateInterval.Minute, 60, BreakET)
                                'End If
                                'If WeekdayName(Weekday(AttDate)) = "Friday" And Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("FridayBreakStatus") = 1 Then
                                '    ShiftET = DateAdd(DateInterval.Minute, 30, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime"))
                                '    BreakST = DateAdd(DateInterval.Minute, 30, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime"))
                                '    BreakET = DateAdd(DateInterval.Minute, 60, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime"))
                                'Else
                                '    ShiftET = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime")
                                '    BreakST = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime")
                                '    BreakET = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime")
                                'End If


                                Dim Night As Boolean = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("NightAndFriday")
                                Dim Day As Boolean = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("FridayBreakStatus")
                                'MsgBox()

                                If WeekdayName(Weekday(AttDate)) = "Friday" Then
                                    If Day = True Then '''' For All SHif
                                        SHiftST = DateAdd(DateInterval.Minute, 0, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime"))
                                        ShiftET = DateAdd(DateInterval.Minute, 15, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime"))
                                        BreakST = DateAdd(DateInterval.Minute, 0, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime"))
                                        BreakET = DateAdd(DateInterval.Minute, 15, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime"))
                                    ElseIf Night = True Then  '' For Night Shift
                                        SHiftST = DateAdd(DateInterval.Minute, 30, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime"))
                                        ShiftET = DateAdd(DateInterval.Minute, 30, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime"))
                                        BreakST = DateAdd(DateInterval.Minute, 30, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime"))
                                        BreakET = DateAdd(DateInterval.Minute, 30, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime"))
                                    Else
                                        SHiftST = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime")
                                        ShiftET = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime")
                                        BreakST = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime")
                                        BreakET = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime")
                                    End If
                                Else
                                    SHiftST = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime")
                                    ShiftET = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime")
                                    BreakST = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime")
                                    BreakET = Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime")
                                End If

                                Me.Tbl_Hrm_Emp_Att1TableAdapter.Insert(Me.DataGridView1(0, i).Value, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("EmpId"), AttDate, AttTime, Nothing, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("ShiftID"), SHiftST, ShiftET, BreakST, BreakET, FP, Now, Me.DataGridView1(2, i).Value.ToString)

                                'End If
                                If Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("ExpiryDate") >= AttTime.ToShortDateString Then
                                    PaintGrid(0, i, Color.DarkGreen, Color.White)
                                    PaintGrid(1, i, Color.DarkGreen, Color.White)
                                    PaintGrid(2, i, Color.DarkGreen, Color.White)
                                Else
                                    ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(0, i).Value & "] , Message: [Employee Card has been Expired]")
                                    PaintGrid(0, i, Color.Red, Color.White)
                                    PaintGrid(1, i, Color.Red, Color.White)
                                    PaintGrid(2, i, Color.Red, Color.White)
                                End If
                            Catch ex As Exception
                                ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(0, i).Value & "] , Message:[" & ex.Message & "]")
                                PaintGrid(0, i, Color.Red, Color.White)
                                PaintGrid(1, i, Color.Red, Color.White)
                                PaintGrid(2, i, Color.Red, Color.White)
                            End Try
                        Else
                            ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(0, i).Value & "] , Message:[Attendance Before Joining Date Is Not Allowed]")
                            PaintGrid(0, i, Color.Red, Color.White)
                            PaintGrid(1, i, Color.Red, Color.White)
                            PaintGrid(2, i, Color.Red, Color.White)
                        End If
                    Else
                            ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & Me.DataGridView1(0, i).Value & "] , Message:[This Card No.is not Registered]")
                        PaintGrid(0, i, Color.Red, Color.White)
                        PaintGrid(1, i, Color.Red, Color.White)
                        PaintGrid(2, i, Color.Red, Color.White)
                    End If

                    'End If
                    ToolStripProgressBar1.Value = i
            Next
                MsgBox("Record Saved Successfully")
                ToolStripProgressBar1.Value = 0
            End If
        End If
    End Sub
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
    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        OpenFileDialog2.Filter = "Microsoft Office Excel WorkSheet(*.xls;)|*.xls;|All Files(*.*)|*.*"
        OpenFileDialog2.FilterIndex = 1
        'MsgBox(OpenFileDialog2.ShowDialog)
        If OpenFileDialog2.ShowDialog = 1 Then
            DataGridView1.DataSource = Nothing
            GlobalPathStr = OpenFileDialog2.FileName
            tbFilePath.Text = GlobalPathStr
            If GlobalPathStr <> "" Then
                Dim R As Integer = 1
                If R = 1 Then
                    Try
                        Dim OledbConStr, ExcelQurey As String
                        OledbConStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & GlobalPathStr & ";Extended Properties=Excel 8.0;"
                        'OledbConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GlobalPathStr & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=2"""
                        Dim OledbCon As New OleDb.OleDbConnection(OledbConStr)
                        ExcelQurey = "SELECT CardNO ,DateTime ,LocationID from [Sheet 1$]"
                        Dim LoadExcelAdopter As New OleDbDataAdapter(ExcelQurey, OledbCon)
                        Dim ExcelDs As New DataSet
                        LoadExcelAdopter.Fill(ExcelDs)
                        DataGridView1.DataSource = ExcelDs.Tables(0)
                        DataGridView1.AllowUserToAddRows = False
                        DataGridView1.AllowUserToDeleteRows = False
                        TotalRowLabel.Text = DataGridView1.RowCount
                        DataGridView1.EnableHeadersVisualStyles = False
                        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.White
                        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
                        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font(Control.DefaultFont, FontStyle.Bold)
                        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        For i As Int16 = 0 To DataGridView1.ColumnCount - 1
                            For j As Int16 = 0 To DataGridView1.RowCount - 1
                                If DataGridView1(i, j).Value Is DBNull.Value Then
                                Else
                                    PaintGrid(i, j, Color.Sienna, Color.Wheat)
                                End If
                            Next
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                ToolStripProgressBar1.Value = 0
            End If
        End If
    End Sub
    Sub PaintGrid(ByVal i As Int16, ByVal j As Int16, ByVal BackColor As System.Drawing.Color, ByVal ForeColored As System.Drawing.Color)
        Me.DataGridView1(i, j).Style.BackColor = BackColor
        Me.DataGridView1(i, j).Style.ForeColor = ForeColored
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class