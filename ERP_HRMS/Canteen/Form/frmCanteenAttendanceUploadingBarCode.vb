Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Office.Core
Imports System.IO
Imports Microsoft.VisualBasic
Public Class frmCanteenAttendanceUploadingBarCode
    Dim GlobalPathStr As String
    Private Sub frmAutoAttendanceUploading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Dim Count As Integer
    Dim dgResult As DialogResult
    Dim PathReader As StreamReader

    Dim obj As New UtilityClass
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Value As Integer = 0
        Dim CardNo As Int16
        ToolStripProgressBar1.Value = 0
        If Directory.Exists("C:\Excel Meal Attendance Log Files") Then
        Else
            Directory.CreateDirectory("C:\Excel Meal Attendance Log Files")
        End If
        Dim MyDate As DateTime
        Dim FP As String = Nothing
        If DataGridView1.RowCount > 0 Then
            FilePath = "C:\Excel Meal Attendance Log Files\ Dated " & Now.Year & "-" & Now.Month & "-" & Now.Day & ".txt"
            ToolStripProgressBar1.Maximum = TotalRowLabel.Text
            dgResult = MessageBox.Show("Are You Sure Want to save Excel Attendance file in database?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If dgResult = 6 Then
                For i As Integer = 0 To Me.DataGridView1.RowCount - 1
                    'CardNo = Me.DataGridView1(0, i).Value)
                    Try


                        'MyDate = CType(Me.DataGridView1(0, i).Value.Substring(0, 19), DateTime)

                        'MyDate = Format(CDate(MyDate), "dd/MM/yyyy hh:mm tt")
                        CardNo = Me.DataGridView1(0, i).Value.ToString.Substring(1, 5)

                    Catch ex As Exception
                        ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "],  Message:[" & ex.Message & "]")
                        Continue For
                    End Try


                    If Me.View_Display_EmpInfoTableAdapter.FillBy(DSDisplayEI.View_Display_EmpInfo, CardNo) > 0 Then

                        Try
                            Dim AttDate As Date = CDate(Me.DateTimePicker1.Text)
                            'AttDate = CDate(MyDate).ToShortDateString

                            Me.Tbl_HRM_Emp_Att_MealTableAdapter1.Insert(Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("EmpId"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("cardno"), AttDate, Now.Date, Nothing, 1, Nothing, "Excel", Nothing)
                            'Mebl_Hrm_Emp_Att1TableAdapter.Insert(Me.DataGridView1(0, i).Value, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("EmpId"), AttDate, AttTime, Nothing, Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("ShiftID"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SStartTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SEndTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakStartTime"), Me.DSDisplayEI.View_Display_EmpInfo.Rows(0).Item("SBreakEndTime"), FP, Now, Me.DataGridView1(2, i).Value.ToString)
                            PaintGrid(0, i, Color.DarkGreen, Color.White)
                            PaintGrid(1, i, Color.DarkGreen, Color.White)
                            'End If
                        Catch ex As Exception
                            ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & CardNo & "] , Message:[" & ex.Message & "]")
                            PaintGrid(0, i, Color.Red, Color.White)
                            PaintGrid(1, i, Color.Red, Color.White)

                        End Try
                    Else
                        ErrorFileWriter(FilePath, "Log Write Time: [" & Now & "], CardNo: [" & CardNo & "] , Message:[This Card No.is not Registered]")
                        PaintGrid(0, i, Color.Red, Color.White)
                        PaintGrid(1, i, Color.Red, Color.White)

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
                        ExcelQurey = "SELECT CardNO  from [Sheet1$]"
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
        Try
            Me.DataGridView1(i, j).Style.BackColor = BackColor
            Me.DataGridView1(i, j).Style.ForeColor = ForeColored
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class