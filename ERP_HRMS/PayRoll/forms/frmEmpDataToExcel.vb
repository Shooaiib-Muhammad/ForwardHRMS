Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Runtime
Imports Microsoft.Office.Interop.Excel
Imports Excel
Imports Office = Microsoft.Office.Core
Imports System.Reflection
Imports System.IO
'Imports Aspose.Cells
'Imports Aspose.Cells.Drawing
Imports System.Object
Imports Microsoft.Office.Interop

Public Class frmEmpDataToExcel

    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim xlWorkSheet1 As Excel.Worksheet
    Dim xlApp As Excel.Application
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim Borders As Excel.Borders
    Dim Path As String = ""
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Dim Age18, Age20, Age25, Age30, Age35, Age40, Age45, TotalAge, TotalAge1, TotalAge2, TotalAge3, TotalAge4, TotalAge5, TotalAge6, Age42, Age43, TotalAge7, TotalAge8 As Integer

    'Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.View_Att_Emp_DeptTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Dept, New System.Nullable(Of Date)(CType(AttDateToolStripTextBox.Text, Date)), New System.Nullable(Of Date)(CType(AttDate1ToolStripTextBox.Text, Date)), DeptNameToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Dim FAge18, FAge20, FAge25, FAge30, FAge35, FAge40, FAge45, FTotalAge, FTotalAge1, FTotalAge2, FTotalAge3, FTotalAge4, FTotalAge5, FTotalAge6, FAge42, FAge43, FTotalAge7, FTotalAge8 As Integer
    Private Sub ResetVlaues(ByVal I As Integer)
        Age18 = 0
        Age20 = 0
        Age25 = 0
        Age30 = 0
        Age35 = 0
        Age40 = 0
        Age45 = 0
        TotalAge = 0
        FAge18 = 0
        FAge20 = 0
        FAge25 = 0
        FAge30 = 0
        FAge35 = 0
        FAge40 = 0
        FAge45 = 0
        Age42 = 0
        Age43 = 0
        FAge42 = 0
        FAge43 = 0
        FTotalAge = 0
        FTotalAge1 = 0
        FTotalAge2 = 0
        TotalAge1 = 0
        TotalAge2 = 0
        TotalAge3 = 0
        TotalAge4 = 0
        TotalAge5 = 0
        TotalAge6 = 0
        FTotalAge3 = 0
        FTotalAge4 = 0
        FTotalAge5 = 0
        FTotalAge6 = 0
        TotalAge7 = 0
        TotalAge8 = 0
        FTotalAge7 = 0
        FTotalAge8 = 0
        Try
            ToolStripProgressBar1.Value = I
        Catch ex As Exception
            ToolStripProgressBar1.Value = 0
        End Try
    End Sub
    Dim Flag As Boolean = False
    Private Sub LoadWorkingHoursData1()
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = 435
        Dim Progress As Integer = 3
        'Working Hours July 2014.xls
        Path = "Working Hours " + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + ".xlsx"
        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkSheet1 = xlWorkBook.Sheets("sheet2")
        Dim AttDate As New ArrayList
        Dim CharList As New ArrayList
        With xlWorkSheet
            ResetVlaues(Progress)
            CharList.Clear()
            .Range("A1", "AK14").Interior.Color = RGB(255, 255, 255)
            .Range("AC13", "XFD550").Interior.Color = RGB(255, 255, 255)
            .Range("A41", "XFD550").Interior.Color = RGB(255, 255, 255)
            .Range("A1").ColumnWidth = 0.71
            .Range("A15").RowHeight = 65
            .Range("A40").RowHeight = 30
            .Range("A16", "AB39").RowHeight = 20
            .Range("B1").ColumnWidth = 3.11
            .Range("C1").ColumnWidth = 40.11
            .Range("D1").ColumnWidth = 20
            .Range("E1", "AK1").ColumnWidth = 11
            .Cells(2, 10) = "WEEKLY REGULAR AND OVERTIME HOURS WORKED REPORT"
            .Cells(1, 3) = "Adidas Sourcing Limited"
            .Cells(4, 3) = "Factory Name"
            .Range("C15").Value = "Department"
            .Range("C42").Value = "Average Of Total Actual Employees**"
            .Range("C43").Value = "Total Working Hours" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Range("C42", "C43").Interior.Color = RGB(255, 255, 0)
            .Range("D42", "D43").Interior.Color = RGB(0, 204, 255)

            .Range("C46").Value = "*Derived from sum of actual employees working in a day throughout the week, then divide with number of workdays."
            .Range("C47").Value = "**Sum of average number of actual employees each week; divided with number of weeks "
            .Range("C15").HorizontalAlignment = 3
            .Range("C15").VerticalAlignment = 2
            .Cells(5, 3) = "Reporting Month"
            .Cells(6, 3) = "Standard Work Day Per Week"
            .Cells(7, 3) = "Standard Work Hours Per Day (Monday To Saturday)"
            .Cells(8, 3) = "Maximum OverTime Hours Per Day (Mon -Saturday)"
            .Cells(11, 3) = "Adidas Production Manager (Signature/name/date)"
            .Range("E4", "G4").Merge()
            Borders = .Range("E4", "G4").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            .Range("D42", "E42").Merge()
            .Range("D43", "E43").Merge()
            Borders = .Range("C42", "E42").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C43", "E43").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            For i1 As Integer = 5 To 8
                .Range("E" & i1 & "", "F" & i1 & "").BorderAround()
            Next
            .Cells(5, 5) = Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Cells(6, 5) = "6"
            .Cells(4, 5) = "Forward Sports"
            .Cells(7, 5) = "8"
            .Cells(8, 5) = "2"
            '
            .Range("D13", "H13").Merge()
            .Range("I13", "M13").Merge()
            .Range("N13", "R13").Merge()
            .Range("S13", "W13").Merge()
            .Range("X13", "AB13").Merge()
            .Range("D14", "H14").Merge()
            .Range("I14", "M14").Merge()
            .Range("N14", "R14").Merge()
            .Range("S14", "W14").Merge()
            .Range("X14", "AB14").Merge()
            .Range("E11").Value = "__________________________________"
            .Range("R11").Value = "__________________________________"
            Borders = .Range("B15", "AB40").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            .Range("D13", "H14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I13", "M14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("N13", "R14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("S13", "W14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("X13", "AB14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("B15", "AB40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("B15", "B40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C15", "C40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("D15", "H40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I15", "M40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("N15", "R40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("S15", "W40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("X15", "AB40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            'Loading Week Data
            Dim CharCount As Integer = 0
            Me.Tbl_Hrm_Emp_AttTableAdapter.Fill(Me.DSExcelEmpData.tbl_Hrm_Emp_Att, GetFirstDayOfMonth(Me.DateTimePicker1.Text), GetLastDayOfMonth(Me.DateTimePicker1.Text))
            If Me.Tbl_Hrm_Emp_AttBindingSource.Count > 1 Then
                For i As Integer = 0 To Me.Tbl_Hrm_Emp_AttBindingSource.Count - 1
                    If i = 0 Then
                        AttDate.Add(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"))
                    End If
                    If CType(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"), Date).DayOfWeek.ToString = "Saturday" And i < Me.Tbl_Hrm_Emp_AttBindingSource.Count - 1 Then
                        AttDate.Add(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"))
                        AttDate.Add(CType(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"), Date).AddDays(2))
                    End If
                    If i = Me.Tbl_Hrm_Emp_AttBindingSource.Count - 1 And CType(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"), Date).DayOfWeek.ToString <> "Monday" Then
                        AttDate.Add(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"))
                    End If
                Next
                Dim AttDate1 As New ArrayList
                Dim DateDif As Integer
                CharList.Add("D")
                CharList.Add("I")
                CharList.Add("N")
                CharList.Add("S")
                CharList.Add("X")
                Dim CharList1, CharList3, CharList4, CharList5 As New ArrayList
                Dim CharList2 As New ArrayList
                CharList1.Add("E")
                CharList2.Add("F")
                CharList5.Add("G")

                CharList1.Add("J")
                CharList2.Add("K")
                CharList5.Add("L")

                CharList1.Add("O")
                CharList2.Add("P")
                CharList5.Add("Q")

                CharList1.Add("T")
                CharList2.Add("U")
                CharList5.Add("V")

                CharList1.Add("Y")
                CharList2.Add("Z")
                CharList5.Add("AA")

                'here
                CharList3.Add("D")
                CharList3.Add("E")

                CharList3.Add("F")
                CharList3.Add("G")

                'CharList3.Add("H")

                CharList3.Add("K")
                CharList3.Add("L")

                CharList3.Add("M")
                CharList3.Add("N")

                CharList3.Add("R")
                CharList3.Add("S")

                CharList3.Add("T")
                CharList3.Add("U")

                CharList3.Add("Y")
                CharList3.Add("Z")

                CharList3.Add("AA")
                CharList3.Add("AB")

                CharList3.Add("AF")
                CharList3.Add("AG")

                CharList3.Add("AH")
                CharList3.Add("AI")

                CharList4.Add("H")
                CharList4.Add("I")

                CharList4.Add("O")
                CharList4.Add("P")

                CharList4.Add("V")
                CharList4.Add("W")

                CharList4.Add("AC")
                CharList4.Add("AD")

                CharList4.Add("AJ")
                CharList4.Add("AK")

                'End here

                AttDate1.Add("MLP")
                AttDate1.Add("Quick Response")
                AttDate1.Add("TM Production")
                AttDate1.Add("R&D")
                'AttDate1.Add("TPU Bladder")
                AttDate1.Add("RWPD")
                AttDate1.Add("Machine Stitch Production")
                'AttDate1.Add("MS Production Hall2")
                AttDate1.Add("AMB Production")

                AttDate1.Add("Quality Assurance")
                AttDate1.Add("Issuance")
                AttDate1.Add("Administration")
                AttDate1.Add("Maintenance")

                AttDate1.Add("Staff")
                AttDate1.Add("Bladder Winding")
                ResetVlaues(10)
                Dim Value12, ProgCount, CharCount3 As Integer
                ProgCount = 1
                CharCount3 = 0
                For i As Integer = 0 To AttDate.Count - 1 Step 2
                    'If i = 0 Then
                    '    Progress = 42
                    'Else
                    '    Progress = 105 * i
                    'End If
                    Dim FirstDate As Date = AttDate.Item(i)
                    Dim LastDate As Date
                    Try
                        LastDate = AttDate.Item(i + 1)
                    Catch ex As Exception

                    End Try
                    Progress = ProgCount * 84
                    Try
                        Try
                            Me.Tbl_Holiday_DetailTableAdapter.Fill(Me.DSExcelEmpData.tbl_Holiday_Detail, AttDate.Item(i), AttDate.Item(i + 1))
                        Catch ex As Exception
                            Me.Tbl_Holiday_DetailTableAdapter.Fill(Me.DSExcelEmpData.tbl_Holiday_Detail, AttDate.Item(i), AttDate.Item(i))
                        End Try
                        Try
                            DateDif = DateDiff(DateInterval.Day, AttDate.Item(i), AttDate.Item(i + 1)) + 1
                        Catch ex As Exception
                            DateDif = DateDiff(DateInterval.Day, AttDate.Item(i), AttDate.Item(i)) + 1
                        End Try
                        DateDif = DateDif - Me.DSExcelEmpData.tbl_Holiday_Detail.Rows(0).Item(0)
                        Try
                            .Range(CharList.Item(CharCount) & "14").Value = Format(AttDate.Item(i), "dd/MM/yy").ToString + "-" + Format(AttDate.Item(i + 1), "dd/MM/yy").ToString + "(" & DateDif & "days)"
                        Catch ex As Exception
                            .Range(CharList.Item(CharCount) & "14").Value = Format(AttDate.Item(i), "dd/MM/yy").ToString + "-" + Format(AttDate.Item(i), "dd/MM/yy").ToString + "(" & DateDif & "days)"
                        End Try
                        'YEESSSSSSSSS YE Code

                        For j As Integer = 0 To AttDate1.Count - 1
                            'Try
                            '    Me.View_Att_Emp_CountTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Count, AttDate.Item(i), AttDate.Item(i + 1), AttDate1.Item(j))
                            'Catch ex As Exception
                            '    Me.View_Att_Emp_CountTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Count, AttDate.Item(i), AttDate.Item(i), AttDate1.Item(j))
                            'End Try
                            Try
                                Me.View_Att_Emp_ValueTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Value, AttDate.Item(i), AttDate.Item(i + 1), AttDate1.Item(j))
                            Catch ex As Exception
                                Me.View_Att_Emp_ValueTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Value, AttDate.Item(i), AttDate.Item(i), AttDate1.Item(j))
                            End Try
                            Try
                                Me.View_Att_Emp_OTTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_OT, AttDate.Item(i), AttDate.Item(i + 1), AttDate1.Item(j))
                            Catch ex As Exception
                                Me.View_Att_Emp_OTTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_OT, AttDate.Item(i), AttDate.Item(i), AttDate1.Item(j))
                            End Try
                            ResetVlaues(Progress + 1)
                            Dim OT As Int16 = 0
                            For LL As Integer = 0 To Me.View_Att_Emp_ValueBindingSource.Count - 1
                                If Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") <= 48 Then
                                    Age18 = Age18 + 1
                                ElseIf Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") >= 49 And Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") <= 54 Then
                                    Age20 = Age20 + 1
                                ElseIf Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") >= 55 And Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") <= 60 Then
                                    Age25 = Age25 + 1
                                ElseIf Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") >= 61 And Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") <= 70 Then
                                    OT = OT + 1
                                End If
                            Next
                            Try
                                xlWorkSheet1.Range(CharList3.Item(CharCount3) & j + 15 & "").Value = Me.View_Att_Emp_ValueBindingSource.Count
                            Catch ex As Exception
                                xlWorkSheet1.Range(CharList3.Item(CharCount3) & j + 15 & "").Value = 0
                            End Try
                            Try
                                'xlWorkSheet1.Range(CharList3.Item(CharCount3 + 1) & j + 15 & "").Value = Age18
                                xlWorkSheet1.Range(CharList3.Item(CharCount3 + 1) & j + 15 & "").Value = Age18
                            Catch ex As Exception
                                'xlWorkSheet1.Range(CharList3.Item(CharCount3 + 1) & j + 15 & "").Value = 0
                            End Try

                            Try
                                xlWorkSheet1.Range(CharList3.Item(CharCount3 + 2) & j + 15 & "").Value = Age20
                            Catch ex As Exception
                                'xlWorkSheet1.Range(CharList3.Item(CharCount3 + 2) & j + 15 & "").Value = 0
                            End Try
                            Try
                                xlWorkSheet1.Range(CharList3.Item(CharCount3 + 3) & j + 15 & "").Value = Me.View_Att_Emp_ValueBindingSource.Count - (Age18 + Age20 + OT)
                                'xlWorkSheet1.Range(CharList3.Item(CharCount3 + 3) & j + 15 & "").Value = 3
                            Catch ex As Exception
                                xlWorkSheet1.Range(CharList3.Item(CharCount3 + 2) & j + 15 & "").Value = 0
                            End Try
                            'Try
                            '    xlWorkSheet1.Range(CharList3.Item(CharCount3 + 4) & j + 15 & "").Value = 5
                            'Catch ex As Exception
                            '    xlWorkSheet1.Range(CharList3.Item(CharCount3 + 4) & j + 15 & "").Value = 0
                            'End Try

                            Dim Total As Int16 = Age18 + Age20 + Age25 + OT
                            Dim EmpCount As Int16 = Me.View_Att_Emp_ValueBindingSource.Count
                            Dim FinalTotal As Int16 = 0
                            'MsgBox(xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value)

                            'here is '
                            If CharCount3 = 0 Then

                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value = OT
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value = 0
                                End Try
                                'MsgBox(xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value)
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(1) & j + 15 & "").Value > 0 Then
                                    Else
                                        'xlWorkSheet1.Range(CharList4.Item(1) & j + 15 & "").Value = EmpCount - Total
                                        xlWorkSheet1.Range(CharList4.Item(1) & j + 15 & "").Value = FinalTotal
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(1) & j + 15 & "").Value = 0
                                End Try
                            End If

                            'End Here is

                            If CharCount3 = 4 Then
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(2) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(2) & j + 15 & "").Value = OT
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(2) & j + 15 & "").Value = 0
                                End Try
                                'MsgBox(xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value)
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(3) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(3) & j + 15 & "").Value = 0
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(3) & j + 15 & "").Value = 0
                                End Try
                            End If



                            If CharCount3 = 8 Then
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(4) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(4) & j + 15 & "").Value = OT
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(4) & j + 15 & "").Value = 0
                                End Try
                                'MsgBox(xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value)
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(5) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(5) & j + 15 & "").Value = 0
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(5) & j + 15 & "").Value = 0
                                End Try
                            End If


                            If CharCount3 = 12 Then
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(4 + 2) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(4 + 2) & j + 15 & "").Value = OT
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(4 + 2) & j + 15 & "").Value = 0
                                End Try
                                'MsgBox(xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value)
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(5 + 2) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(5 + 2) & j + 15 & "").Value = 0
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(5 + 2) & j + 15 & "").Value = 0
                                End Try
                            End If

                            If CharCount3 = 16 Then
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(4 + 4) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(4 + 4) & j + 15 & "").Value = OT
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(4 + 4) & j + 15 & "").Value = 0
                                End Try
                                'MsgBox(xlWorkSheet1.Range(CharList4.Item(0) & j + 15 & "").Value)
                                Try
                                    If xlWorkSheet1.Range(CharList4.Item(5 + 4) & j + 15 & "").Value > 0 Then
                                    Else
                                        xlWorkSheet1.Range(CharList4.Item(5 + 4) & j + 15 & "").Value = 0
                                    End If
                                Catch ex As Exception
                                    xlWorkSheet1.Range(CharList4.Item(5 + 4) & j + 15 & "").Value = 0
                                End Try
                            End If




                            Try
                                '.Range(CharList.Item(CharCount) & j + 16 & "").Value = Fix(CInt(Me.DSExcelEmpData.View_Att_Emp_Count.Rows(0).Item(0)) / DateDif)
                                .Range(CharList.Item(CharCount) & j + 16 & "").Value = Me.View_Att_Emp_ValueBindingSource.Count
                            Catch ex As Exception
                                .Range(CharList.Item(CharCount) & j + 16 & "").Value = 0
                            End Try
                            Try
                                .Range(CharList2.Item(CharCount) & j + 16 & "").Value = Fix(CInt(Me.DSExcelEmpData.View_Att_Emp_OT.Rows(0).Item(0)))
                            Catch ex As Exception
                                .Range(CharList2.Item(CharCount) & j + 16 & "").Value = 0
                            End Try
                            'Here is NEW 
                            Try
                                .Range(CharList5.Item(CharCount) & j + 16 & "").Value = Fix(CInt(Me.DSExcelEmpData.View_Att_Emp_OT.Rows(0).Item(1)))
                            Catch ex As Exception
                                .Range(CharList5.Item(CharCount) & j + 16 & "").Value = 0
                            End Try



                        Next




                        Value12 = DateDif
                        For L As Integer = 16 To 26
                            .Range(CharList1.Item(CharCount) & L & "").Value = Value12 * 8
                        Next

                        CharCount = CharCount + 1
                        CharCount3 = CharCount3 + 4
                        '.Range("E" & i1 & "14").BorderAround()
                    Catch ex As Exception
                        'i = i - 1
                        Try
                            DateDif = DateDiff(DateInterval.Day, AttDate.Item(i), AttDate.Item(i)) + 1
                            .Range(CharList.Item(CharCount) & "14").Value = Format(AttDate.Item(i), "dd/MM/yy").ToString + "-" + Format(AttDate.Item(i), "dd/MM/yy").ToString + "(" & DateDif & "days)"
                            CharCount = CharCount + 1
                        Catch ex1 As Exception
                            DateDif = DateDiff(DateInterval.Day, AttDate.Item(i), AttDate.Item(i)) + 1
                            .Range(CharList.Item(CharCount - 1) & "14").Value = Format(AttDate.Item(i), "dd/MM/yy").ToString + "-" + Format(AttDate.Item(i), "dd/MM/yy").ToString + "(" & DateDif & "days)"
                            CharCount = CharCount + 1
                        End Try

                    End Try

                    'For k As Integer = 0 To CharList1.Count - 1
                    'If CharList1.Item(k) = "E" Or CharList1.Item(k) = "J" Or CharList1.Item(k) = "O" Or CharList1.Item(k) = "T" Or CharList1.Item(k) = "Y" Then
                    'Value12 = DateDif - Me.DSExcelEmpData.tbl_Holiday_Detail.Rows(0).Item(0)
                    'For L As Integer = 16 To 24
                    '    .Range(CharList1.Item(k) & L & "").Value = Value12 * 8
                    'Next

                    'End If

                    'Next
                    ResetVlaues(Progress)
                    ProgCount = ProgCount + 1
                Next
            End If
            AttDate.Clear()
            AttDate.Add("MLP")
            AttDate.Add("QR")
            AttDate.Add("TM")
            AttDate.Add("R&D")
            'AttDate.Add("T.P.U")
            AttDate.Add("RWPD")
            AttDate.Add("Machine Stitch")
            'AttDate.Add("Machine Stitch Old Forward")
            AttDate.Add("AMB Production")

            AttDate.Add("Quality Assurance")
            AttDate.Add("Issuance")

            AttDate.Add("Administration")
            AttDate.Add("Maintenance")
            AttDate.Add("Staff")
            AttDate.Add("Bladder Winding")
            CharCount = 0
            For i As Integer = 1 To 24
                .Range("B" & i + 15 & "").Value = i
                Try
                    .Range("C" & i + 15 & "").Value = AttDate.Item(CharCount)
                    CharCount = CharCount + 1
                Catch ex As Exception
                End Try
            Next
            .Range("B16", "B40").HorizontalAlignment = 3
            '.Range(CharList.Item(CharCount) & "14").Value
            .Cells(6, 6) = "days"
            .Cells(7, 6) = "hours"
            .Cells(8, 6) = "hours"
            .Range("E6", "F8").HorizontalAlignment = 3
            .Range("A4", "T18").Font.Size = 10
            .Range("E5").HorizontalAlignment = 2
            .Range("C1").Font.Size = 12
            .Range("A1", "Z13").Font.Name = "Times New Roman"
            .Range("A13", "AK100").Font.Name = "Tahoma"
            .Range("A13", "AK13").Font.Bold = True
            .Range("D13").Value = "Week1"
            .Range("C40").Value = "Total"
            .Range("I13").Value = "Week2"
            .Range("C40").Font.Size = 16
            .Range("C40").Font.Bold = True
            .Range("C40").HorizontalAlignment = 3
            '.Range("C40").VerticalAlignment = 2
            .Range("E15", "AB15").VerticalAlignment = 2
            .Range("E15", "AB15").Font.Size = 10
            .Range("E15", "AB15").Font.Bold = True
            .Range("E15", "AB15").HorizontalAlignment = 3
            ResetVlaues(433)
            .Range("N13").Value = "Week3"
            .Range("S13").Value = "Week4"
            .Range("X13").Value = "Week5"
            .Range("A13", "AK14").HorizontalAlignment = 3
            .Range("A13", "AK14").Font.Size = 10
            .Range("j2").Font.Size = 20
            .Range("C15").Font.Size = 18
            .Range("C15").Font.Bold = True
            .Range("j2").Font.Color = RGB(0, 0, 255)
            .Range("j2").Font.Bold = True
            .Range("C1").Font.Bold = True
            .Range("N11").Value = "Factory Representative (Signature/name/date)"
            .Range("D15").VerticalAlignment = 2
            .Range("D15").Font.Size = 8
            .Range("D15").Font.Bold = True
            .Range("D15").HorizontalAlignment = 3
            '.Range("H15", "H40").Interior.Color = RGB(204, 255, 204)
            CharList.Clear()
            AttDate.Clear()
            AttDate.Add("Average No. Of" & vbCrLf & "Actual" & vbCrLf & "Working this week")
            AttDate.Add("Total" & vbCrLf & "REG. Hours" & vbCrLf & "this week")
            AttDate.Add("Total OT." & vbCrLf & "Hours this" & vbCrLf & "week")
            AttDate.Add("TTL. Hours")
            AttDate.Add("AVERAGE")
            CharList.Add("AA").ToString()
            CharList.Add("AB").ToString()
            Dim LoopChar As Char = "D"
            Dim Count1 As Integer = 0
            Dim LoopString As String = ""
            Dim LoopString1 As String = ""
            .Range("C42", "D43").Font.Size = 10
            .Range("C42", "D43").Font.Bold = True
            '.Range("D42", "E43").HorizontalAlignment = 4
            '.Range("D42").Value = 145

            For i As Integer = 1 To 25
                LoopString1 = LoopChar
                If i > 23 Then
                    LoopString = CharList.Item(i - 24)
                    LoopString1 = LoopString
                End If
                If LoopString1 = "H" Or LoopString1 = "M" Or LoopString1 = "R" Or LoopString1 = "W" Or LoopString1 = "AB" Then
                    .Range(LoopString1 & "15", LoopString1 & "40").Interior.Color = RGB(204, 255, 204)
                End If
                If LoopString = "" Then
                    Try
                        .Range(LoopChar & "15").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    Catch ex As Exception
                        .Range(LoopChar & "15").VerticalAlignment = 2
                        .Range(LoopChar & "15").Font.Size = 8
                        .Range(LoopChar & "15").Font.Bold = True
                        .Range(LoopChar & "15").HorizontalAlignment = 3
                        Count1 = 0
                        .Range(LoopChar & "15").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    End Try
                Else
                    Try
                        .Range(LoopString & "15").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    Catch ex As Exception
                        Count1 = 0
                        Count1 = Count1 + 1
                    End Try
                End If
                LoopChar = Chr(Asc(LoopChar) + 1)
            Next
            AttDate.Clear()
            CharList.Clear()
            .Activate()
            Dim Str As String
            Str = "AurieGlo:" & vbCrLf & "Example:" & vbCrLf & "Data: 40 employees in Dept.Cutting." & vbCrLf & "This week have 5 full workdays." & vbCrLf & "           Day 1= 40 emp present;" & vbCrLf & "           Day 2= 38 emp(2 emp sick leave);" & vbCrLf & "           Day 3= 39 emp(1 sick);" & vbCrLf & "           Day 4= 35 emp(3 emp sick,2 emp maternity leave);" & vbCrLf & "           Day 5= 39 emp(1 emp absent)." & vbCrLf & "Therefore,average no of actual working employees(present at work,based on absency record)" & vbCrLf & "is=(40+38+39+35+39)emp/5days" & vbCrLf & "      =1192/5 = 38.2" & vbCrLf & "      = 38 employees."
            .Range("D16").AddComment(Str)

            Str = "AurieGlo:" & vbCrLf & "Example: For 5 working days:" & vbCrLf & "1.if total effective working days in this week is 5 days and daily" & vbCrLf & "workhours is 8hours/day." & vbCrLf & "Then total Reg.hours= 8hrs * 5days=40hrs." & vbCrLf & "" & vbCrLf & "2.For 5 working days with 1 national holiday:" & vbCrLf & "if total effective working days is 4 days (due to 1 day off because of" & vbCrLf & "of national holiday), then total reg. hours" & vbCrLf & "= 8 hrs * 4 days = 36 hrs. "
            .Range("E16").AddComment(Str)

            Str = "AurieGlo:" & vbCrLf & "Example:" & vbCrLf & "Dept Cutting = 40 employees." & vbCrLf & "This week there are 2 times overtime work performed by all employees in this dept." & vbCrLf & "      OT 1 in Tuesday = 3 hours after regular workhours." & vbCrLf & "      OT 2 in Saturday (this is the regular rest day because this factory is using 5" & vbCrLf & "workdays system) = 6 hours. But in saturday, only 35 employees were able to do OT." & vbCrLf & "" & vbCrLf & "Therefore, Total OT Hours in this week (Week 1) would be " & vbCrLf & "= (40 emp*3hrs)+(35emp*6hrs)" & vbCrLf & "= 120hrs+210hrs " & vbCrLf & "= 330hrs"
            .Range("F16").AddComment(Str)

            Str = "AurieGlo:" & vbCrLf & "average weekly workhours must not exceed the limit set by Local" & vbCrLf & "Labour Law & SEA standards, or whichever is stricter (in this case: SEA" & vbCrLf & "Standards):" & vbCrLf & "" & vbCrLf & "=> Maximum 60 hours work per week in total (regular work hours +" & vbCrLf & "OT work); and there must be at least 1 (one) day off / 24 hours " & vbCrLf & "consecutive rest given to workers in every 7 days period."
            .Range("H15").AddComment(Str)
            FormatAllComments()
            Dim Value1 As String
            .Range("D16", "AB40").HorizontalAlignment = 3
            .Range("D43").HorizontalAlignment = 4
            .Range("D16", "AB40").Font.Size = 10
            'Week1
            Count1 = 16
            'data'
            ' Sum Formula


            While Count1 <= 39
                'Value1 = "E" + Count1.ToString + "*D" + Count1.ToString + "+" + "F" + Count1.ToString
                ''.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                '.Range("G" & Count1 & "").Formula = "=(" & Value1 & ")"

                Value1 = "G" + Count1.ToString + "/" + "D" + Count1.ToString
                .Range("H" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("H" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("D40").Formula = "=Sum(D16:D39)"
            .Range("E40").Formula = "=Sum(E16:E39)"
            .Range("F40").Formula = "=Sum(F16:F39)"
            .Range("G40").Formula = "=Sum(G16:G39)"
            .Range("H40").Formula = "=(G40/D40)"
            .Range("H40").NumberFormat = "0.0"
            'Count1 = 5
            'Week2
            Count1 = 16
            While Count1 <= 39
                'Value1 = "J" + Count1.ToString + "," + "K" + Count1.ToString
                '.Range("L" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                'Value1 = "J" + Count1.ToString + "*I" + Count1.ToString + "+" + "K" + Count1.ToString
                ''.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                '.Range("L" & Count1 & "").Formula = "=(" & Value1 & ")"

                Value1 = "L" + Count1.ToString + "/" + "I" + Count1.ToString
                .Range("M" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("M" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("I40").Formula = "=Sum(I16:I39)"
            .Range("J40").Formula = "=Sum(J16:J39)"
            .Range("K40").Formula = "=Sum(K16:K39)"
            .Range("L40").Formula = "=Sum(L16:L39)"
            .Range("M40").Formula = "=(L40/I40)"
            .Range("M40").NumberFormat = "0.0"
            'Week3
            Count1 = 16
            While Count1 <= 39
                'Value1 = "O" + Count1.ToString + "," + "P" + Count1.ToString
                '.Range("Q" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                'Value1 = "O" + Count1.ToString + "*N" + Count1.ToString + "+" + "P" + Count1.ToString
                '.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                '.Range("Q" & Count1 & "").Formula = "=(" & Value1 & ")"

                Value1 = "Q" + Count1.ToString + "/" + "N" + Count1.ToString
                .Range("R" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("R" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("N40").Formula = "=Sum(N16:N39)"
            .Range("O40").Formula = "=Sum(O16:O39)"
            .Range("P40").Formula = "=Sum(P16:P39)"
            .Range("Q40").Formula = "=Sum(Q16:Q39)"
            .Range("R40").Formula = "=(Q40/N40)"
            .Range("R40").NumberFormat = "0.0"
            'Week 4
            Count1 = 16
            While Count1 <= 39
                'Value1 = "T" + Count1.ToString + "," + "U" + Count1.ToString
                '.Range("V" & Count1 & "").Formula = "=Sum(" & Value1 & ")"

                'Value1 = "T" + Count1.ToString + "*S" + Count1.ToString + "+" + "U" + Count1.ToString
                ''.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                '.Range("V" & Count1 & "").Formula = "=(" & Value1 & ")"

                Value1 = "V" + Count1.ToString + "/" + "S" + Count1.ToString
                .Range("W" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("W" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("S40").Formula = "=Sum(S16:S39)"
            .Range("T40").Formula = "=Sum(T16:T39)"
            .Range("U40").Formula = "=Sum(U16:U39)"
            .Range("V40").Formula = "=Sum(V16:V39)"
            .Range("W40").Formula = "=(V40/S40)"
            .Range("W40").NumberFormat = "0.0"
            'Week5
            Count1 = 16
            While Count1 <= 39
                'Value1 = "Y" + Count1.ToString + "," + "Z" + Count1.ToString
                '.Range("AA" & Count1 & "").Formula = "=Sum(" & Value1 & ")"

                'Value1 = "Y" + Count1.ToString + "*X" + Count1.ToString + "+" + "Z" + Count1.ToString
                ''.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                '.Range("AA" & Count1 & "").Formula = "=(" & Value1 & ")"

                Value1 = "AA" + Count1.ToString + "/" + "X" + Count1.ToString
                .Range("AB" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("AB" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("X40").Formula = "=Sum(X16:X39)"
            .Range("Y40").Formula = "=Sum(Y16:Y39)"
            .Range("Z40").Formula = "=Sum(Z16:Z39)"
            .Range("AA40").Formula = "=Sum(AA16:AA39)"
            .Range("AB40").Formula = "=(AA40/X40)"
            .Range("AB40").NumberFormat = "0.0"
            'Final Reset Values
            'ResetVlaues(436)

            .Range("D42").Formula = "=AVERAGE(D40,I40,N40,X40,S40)"
            .Range("D43").Formula = "=AVERAGE(H40,M40,R40,W40,AB40)"
            .Range("D43").NumberFormat = "0"
            .Range("D42").NumberFormat = "0"

            .Range("D14", "AB14").Locked = False
            .Range("E5", "E8").Locked = False
            .Range("C16", "F39").Locked = False
            .Range("I16", "K39").Locked = False
            .Range("N16", "P39").Locked = False
            .Range("S16", "U39").Locked = False
            .Range("X16", "Z39").Locked = False
            .Protect()
            .Name = "Average OT"
            xlApp.ActiveWindow.Zoom = 70
            .Cells(16, 4).select()
            .Application.ActiveWindow.FreezePanes = True
        End With
        'xlApp.ActiveWindow.Zoom = 70
    End Sub
    Private Sub LoadWorkingHoursData()
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = 435
        Dim Progress As Integer = 3
        'Working Hours July 2014.xls
        Path = "Working Hours " + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + ".xlsx"
        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkSheet1 = xlWorkBook.Sheets("sheet2")
        Dim AttDate As New ArrayList
        Dim CharList As New ArrayList
        With xlWorkSheet
            ResetVlaues(Progress)
            CharList.Clear()
            .Range("A1", "AK14").Interior.Color = RGB(255, 255, 255)
            .Range("AC13", "XFD550").Interior.Color = RGB(255, 255, 255)
            .Range("A41", "XFD550").Interior.Color = RGB(255, 255, 255)
            .Range("A1").ColumnWidth = 0.71
            .Range("A15").RowHeight = 65
            .Range("A40").RowHeight = 30
            .Range("A16", "AB39").RowHeight = 20
            .Range("B1").ColumnWidth = 3.11
            .Range("C1").ColumnWidth = 40.11
            .Range("D1").ColumnWidth = 20
            .Range("E1", "AK1").ColumnWidth = 11
            .Cells(2, 10) = "WEEKLY REGULAR AND OVERTIME HOURS WORKED REPORT"
            .Cells(1, 3) = "Adidas Sourcing Limited"
            .Cells(4, 3) = "Factory Name"
            .Range("C15").Value = "Department"
            .Range("C42").Value = "Average Of Total Actual Employees**"
            .Range("C43").Value = "Total Working Hours" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Range("C42", "C43").Interior.Color = RGB(255, 255, 0)
            .Range("D42", "D43").Interior.Color = RGB(0, 204, 255)

            .Range("C46").Value = "*Derived from sum of actual employees working in a day throughout the week, then divide with number of workdays."
            .Range("C47").Value = "**Sum of average number of actual employees each week; divided with number of weeks "
            .Range("C15").HorizontalAlignment = 3
            .Range("C15").VerticalAlignment = 2
            .Cells(5, 3) = "Reporting Month"
            .Cells(6, 3) = "Standard Work Day Per Week"
            .Cells(7, 3) = "Standard Work Hours Per Day (Monday To Saturday)"
            .Cells(8, 3) = "Maximum OverTime Hours Per Day (Mon -Saturday)"
            .Cells(11, 3) = "Adidas Production Manager (Signature/name/date)"
            .Range("E4", "G4").Merge()
            Borders = .Range("E4", "G4").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            .Range("D42", "E42").Merge()
            .Range("D43", "E43").Merge()
            Borders = .Range("C42", "E42").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C43", "E43").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            For i1 As Integer = 5 To 8
                .Range("E" & i1 & "", "F" & i1 & "").BorderAround()
            Next
            .Cells(5, 5) = Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Cells(6, 5) = "6"
            .Cells(4, 5) = "Forward Sports"
            .Cells(7, 5) = "8"
            .Cells(8, 5) = "2"
            '
            .Range("D13", "H13").Merge()
            .Range("I13", "M13").Merge()
            .Range("N13", "R13").Merge()
            .Range("S13", "W13").Merge()
            .Range("X13", "AB13").Merge()
            .Range("D14", "H14").Merge()
            .Range("I14", "M14").Merge()
            .Range("N14", "R14").Merge()
            .Range("S14", "W14").Merge()
            .Range("X14", "AB14").Merge()
            .Range("E11").Value = "__________________________________"
            .Range("R11").Value = "__________________________________"
            Borders = .Range("B15", "AB40").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            .Range("D13", "H14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I13", "M14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("N13", "R14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("S13", "W14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("X13", "AB14").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("B15", "AB40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("B15", "B40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C15", "C40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("D15", "H40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I15", "M40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("N15", "R40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("S15", "W40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("X15", "AB40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            'Loading Week Data
            Dim CharCount As Integer = 0
            Me.Tbl_Hrm_Emp_AttTableAdapter.Fill(Me.DSExcelEmpData.tbl_Hrm_Emp_Att, GetFirstDayOfMonth(Me.DateTimePicker1.Text), GetLastDayOfMonth(Me.DateTimePicker1.Text))
            If Me.Tbl_Hrm_Emp_AttBindingSource.Count > 1 Then
                For i As Integer = 0 To Me.Tbl_Hrm_Emp_AttBindingSource.Count - 1
                    If i = 0 Then
                        AttDate.Add(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"))
                    End If
                    If CType(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"), Date).DayOfWeek.ToString = "Saturday" And i < Me.Tbl_Hrm_Emp_AttBindingSource.Count - 1 Then
                        AttDate.Add(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"))
                        AttDate.Add(CType(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"), Date).AddDays(2))
                    End If
                    If i = Me.Tbl_Hrm_Emp_AttBindingSource.Count - 1 And CType(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"), Date).DayOfWeek.ToString <> "Monday" Then
                        AttDate.Add(Me.DSExcelEmpData.tbl_Hrm_Emp_Att.Rows(i).Item("AttDate"))
                    End If
                Next
                Dim AttDate1 As New ArrayList
                Dim DateDif As Integer
                CharList.Add("D")
                CharList.Add("I")
                CharList.Add("N")
                CharList.Add("S")
                CharList.Add("X")
                Dim CharList1, CharList3 As New ArrayList
                Dim CharList2 As New ArrayList
                CharList1.Add("E")
                CharList2.Add("F")

                CharList1.Add("J")
                CharList2.Add("K")

                CharList1.Add("O")
                CharList2.Add("P")

                CharList1.Add("T")
                CharList2.Add("U")

                CharList1.Add("Y")
                CharList2.Add("Z")

                'here
                CharList3.Add("D")
                CharList3.Add("E")

                CharList3.Add("F")
                CharList3.Add("G")

                CharList3.Add("K")
                CharList3.Add("L")

                CharList3.Add("M")
                CharList3.Add("N")

                CharList3.Add("R")
                CharList3.Add("S")

                CharList3.Add("T")
                CharList3.Add("U")

                CharList3.Add("Y")
                CharList3.Add("Z")

                CharList3.Add("AA")
                CharList3.Add("AB")

                CharList3.Add("AF")
                CharList3.Add("AG")

                CharList3.Add("AH")
                CharList3.Add("AI")

                'End here

                AttDate1.Add("MLP")
                AttDate1.Add("Quick Response")
                AttDate1.Add("TM Production")
                AttDate1.Add("R&D")
                'AttDate1.Add("TPU Bladder")
                AttDate1.Add("RWPD")
                AttDate1.Add("Machine Stitch Production")
                'AttDate1.Add("MS Production Hall2")
                AttDate1.Add("AMB Production")

                AttDate1.Add("Quality Assurance")
                AttDate1.Add("Issuance")
                'AttDate1.Add("Bladder Winding")
                AttDate1.Add("Administration")
                AttDate1.Add("Maintenance")
                AttDate1.Add("Staff")

                ResetVlaues(10)
                Dim Value12, ProgCount, CharCount3 As Integer
                ProgCount = 1
                CharCount3 = 0
                For i As Integer = 0 To AttDate.Count - 1 Step 2
                    'If i = 0 Then
                    '    Progress = 42
                    'Else
                    '    Progress = 105 * i
                    'End If
                    Dim FirstDate As Date = AttDate.Item(i)
                    Dim LastDate As Date
                    Try
                        LastDate = AttDate.Item(i + 1)
                    Catch ex As Exception

                    End Try
                    Progress = ProgCount * 84
                    Try
                        Try
                            Me.Tbl_Holiday_DetailTableAdapter.Fill(Me.DSExcelEmpData.tbl_Holiday_Detail, AttDate.Item(i), AttDate.Item(i + 1))
                        Catch ex As Exception
                            Me.Tbl_Holiday_DetailTableAdapter.Fill(Me.DSExcelEmpData.tbl_Holiday_Detail, AttDate.Item(i), AttDate.Item(i))
                        End Try
                        Try
                            DateDif = DateDiff(DateInterval.Day, AttDate.Item(i), AttDate.Item(i + 1)) + 1
                        Catch ex As Exception
                            DateDif = DateDiff(DateInterval.Day, AttDate.Item(i), AttDate.Item(i)) + 1
                        End Try
                        DateDif = DateDif - Me.DSExcelEmpData.tbl_Holiday_Detail.Rows(0).Item(0)
                        Try
                            .Range(CharList.Item(CharCount) & "14").Value = Format(AttDate.Item(i), "dd/MM/yy").ToString + "-" + Format(AttDate.Item(i + 1), "dd/MM/yy").ToString + "(" & DateDif & "days)"
                        Catch ex As Exception
                            .Range(CharList.Item(CharCount) & "14").Value = Format(AttDate.Item(i), "dd/MM/yy").ToString + "-" + Format(AttDate.Item(i), "dd/MM/yy").ToString + "(" & DateDif & "days)"
                        End Try

                        For j As Integer = 0 To AttDate1.Count - 1
                            Try
                                Me.View_Att_Emp_CountTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Count, AttDate.Item(i), AttDate.Item(i + 1), AttDate1.Item(j))
                            Catch ex As Exception
                                Me.View_Att_Emp_CountTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Count, AttDate.Item(i), AttDate.Item(i), AttDate1.Item(j))
                            End Try
                            Try
                                Me.View_Att_Emp_ValueTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Value, AttDate.Item(i), AttDate.Item(i + 1), AttDate1.Item(j))
                            Catch ex As Exception
                                Me.View_Att_Emp_ValueTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Value, AttDate.Item(i), AttDate.Item(i), AttDate1.Item(j))
                            End Try
                            Try
                                Me.View_Att_Emp_OTTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_OT, AttDate.Item(i), AttDate.Item(i + 1), AttDate1.Item(j))
                            Catch ex As Exception
                                Me.View_Att_Emp_OTTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_OT, AttDate.Item(i), AttDate.Item(i), AttDate1.Item(j))
                            End Try
                            ResetVlaues(Progress + 1)
                            For LL As Integer = 0 To Me.View_Att_Emp_ValueBindingSource.Count - 1
                                If Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") <= 48 Then
                                    Age18 = Age18 + 1
                                ElseIf Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") >= 49 And Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") <= 54 Then
                                    Age20 = Age20 + 1
                                    'ElseIf Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") >= 55 And Me.DSExcelEmpData.View_Att_Emp_Value.Rows(LL).Item("Duration") <= 60 Then
                                    '    Age25 = Age25 + 1
                                End If
                            Next
                            Try
                                xlWorkSheet1.Range(CharList3.Item(CharCount3) & j + 15 & "").Value = Me.View_Att_Emp_ValueBindingSource.Count
                            Catch ex As Exception
                                xlWorkSheet1.Range(CharList3.Item(CharCount3) & j + 15 & "").Value = 0
                            End Try
                            Try
                                xlWorkSheet1.Range(CharList3.Item(CharCount3 + 1) & j + 15 & "").Value = Age18
                            Catch ex As Exception
                                'xlWorkSheet1.Range(CharList3.Item(CharCount3 + 1) & j + 15 & "").Value = 0
                            End Try

                            Try
                                xlWorkSheet1.Range(CharList3.Item(CharCount3 + 2) & j + 15 & "").Value = Age20
                            Catch ex As Exception
                                'xlWorkSheet1.Range(CharList3.Item(CharCount3 + 2) & j + 15 & "").Value = 0
                            End Try

                            Try
                                xlWorkSheet1.Range(CharList3.Item(CharCount3 + 3) & j + 15 & "").Value = Me.View_Att_Emp_ValueBindingSource.Count - (Age18 + Age20)
                            Catch ex As Exception
                                'xlWorkSheet1.Range(CharList3.Item(CharCount3 + 3) & j + 15 & "").Value = 0
                            End Try
                            Try
                                .Range(CharList.Item(CharCount) & j + 16 & "").Value = Fix(CInt(Me.DSExcelEmpData.View_Att_Emp_Count.Rows(0).Item(0)) / DateDif)
                            Catch ex As Exception
                                .Range(CharList.Item(CharCount) & j + 16 & "").Value = 0
                            End Try
                            Try
                                .Range(CharList2.Item(CharCount) & j + 16 & "").Value = Fix(CInt(Me.DSExcelEmpData.View_Att_Emp_OT.Rows(0).Item(0)))
                            Catch ex As Exception
                                .Range(CharList2.Item(CharCount) & j + 16 & "").Value = 0
                            End Try
                        Next
                        Value12 = DateDif
                        For L As Integer = 16 To 26
                            .Range(CharList1.Item(CharCount) & L & "").Value = Value12 * 8
                        Next

                        CharCount = CharCount + 1
                        CharCount3 = CharCount3 + 4
                        '.Range("E" & i1 & "14").BorderAround()
                    Catch ex As Exception
                        'i = i - 1
                        Try
                            DateDif = DateDiff(DateInterval.Day, AttDate.Item(i), AttDate.Item(i)) + 1
                            .Range(CharList.Item(CharCount) & "14").Value = Format(AttDate.Item(i), "dd/MM/yy").ToString + "-" + Format(AttDate.Item(i), "dd/MM/yy").ToString + "(" & DateDif & "days)"
                            CharCount = CharCount + 1
                        Catch ex1 As Exception
                            DateDif = DateDiff(DateInterval.Day, AttDate.Item(i), AttDate.Item(i)) + 1
                            .Range(CharList.Item(CharCount - 1) & "14").Value = Format(AttDate.Item(i), "dd/MM/yy").ToString + "-" + Format(AttDate.Item(i), "dd/MM/yy").ToString + "(" & DateDif & "days)"
                            CharCount = CharCount + 1
                        End Try

                    End Try

                    'For k As Integer = 0 To CharList1.Count - 1
                    'If CharList1.Item(k) = "E" Or CharList1.Item(k) = "J" Or CharList1.Item(k) = "O" Or CharList1.Item(k) = "T" Or CharList1.Item(k) = "Y" Then
                    'Value12 = DateDif - Me.DSExcelEmpData.tbl_Holiday_Detail.Rows(0).Item(0)
                    'For L As Integer = 16 To 24
                    '    .Range(CharList1.Item(k) & L & "").Value = Value12 * 8
                    'Next

                    'End If

                    'Next
                    ResetVlaues(Progress)
                    ProgCount = ProgCount + 1
                Next
            End If
            AttDate.Clear()
            AttDate.Add("MLP")
            AttDate.Add("QR")
            AttDate.Add("TM")
            AttDate.Add("R&D")
            'AttDate.Add("T.P.U")
            AttDate.Add("RWPD")
            AttDate.Add("Machine Stitch")
            'AttDate.Add("Machine Stitch Old Forward")
            AttDate.Add("AMB Production")

            AttDate.Add("Quality Assurance")
            AttDate.Add("Issuance")
            AttDate.Add("Bladder Winding")
            AttDate.Add("Administration")
            AttDate.Add("Maintenance")
            AttDate.Add("Staff")

            CharCount = 0
            For i As Integer = 1 To 24
                .Range("B" & i + 15 & "").Value = i
                Try
                    .Range("C" & i + 15 & "").Value = AttDate.Item(CharCount)
                    CharCount = CharCount + 1
                Catch ex As Exception
                End Try
            Next
            .Range("B16", "B40").HorizontalAlignment = 3
            '.Range(CharList.Item(CharCount) & "14").Value
            .Cells(6, 6) = "days"
            .Cells(7, 6) = "hours"
            .Cells(8, 6) = "hours"
            .Range("E6", "F8").HorizontalAlignment = 3
            .Range("A4", "T18").Font.Size = 10
            .Range("E5").HorizontalAlignment = 2
            .Range("C1").Font.Size = 12
            .Range("A1", "Z13").Font.Name = "Times New Roman"
            .Range("A13", "AK100").Font.Name = "Tahoma"
            .Range("A13", "AK13").Font.Bold = True
            .Range("D13").Value = "Week1"
            .Range("C40").Value = "Total"
            .Range("I13").Value = "Week2"
            .Range("C40").Font.Size = 16
            .Range("C40").Font.Bold = True
            .Range("C40").HorizontalAlignment = 3
            '.Range("C40").VerticalAlignment = 2
            .Range("E15", "AB15").VerticalAlignment = 2
            .Range("E15", "AB15").Font.Size = 10
            .Range("E15", "AB15").Font.Bold = True
            .Range("E15", "AB15").HorizontalAlignment = 3
            ResetVlaues(433)
            .Range("N13").Value = "Week3"
            .Range("S13").Value = "Week4"
            .Range("X13").Value = "Week5"
            .Range("A13", "AK14").HorizontalAlignment = 3
            .Range("A13", "AK14").Font.Size = 10
            .Range("j2").Font.Size = 20
            .Range("C15").Font.Size = 18
            .Range("C15").Font.Bold = True
            .Range("j2").Font.Color = RGB(0, 0, 255)
            .Range("j2").Font.Bold = True
            .Range("C1").Font.Bold = True
            .Range("N11").Value = "Factory Representative (Signature/name/date)"
            .Range("D15").VerticalAlignment = 2
            .Range("D15").Font.Size = 8
            .Range("D15").Font.Bold = True
            .Range("D15").HorizontalAlignment = 3
            '.Range("H15", "H40").Interior.Color = RGB(204, 255, 204)
            CharList.Clear()
            AttDate.Clear()
            AttDate.Add("Average No. Of" & vbCrLf & "Actual" & vbCrLf & "Working this week")
            AttDate.Add("Total" & vbCrLf & "REG. Hours" & vbCrLf & "this week")
            AttDate.Add("Total OT." & vbCrLf & "Hours this" & vbCrLf & "week")
            AttDate.Add("TTL. Hours")
            AttDate.Add("AVERAGE")
            CharList.Add("AA").ToString()
            CharList.Add("AB").ToString()
            Dim LoopChar As Char = "D"
            Dim Count1 As Integer = 0
            Dim LoopString As String = ""
            Dim LoopString1 As String = ""
            .Range("C42", "D43").Font.Size = 10
            .Range("C42", "D43").Font.Bold = True
            '.Range("D42", "E43").HorizontalAlignment = 4
            '.Range("D42").Value = 145

            For i As Integer = 1 To 25
                LoopString1 = LoopChar
                If i > 23 Then
                    LoopString = CharList.Item(i - 24)
                    LoopString1 = LoopString
                End If
                If LoopString1 = "H" Or LoopString1 = "M" Or LoopString1 = "R" Or LoopString1 = "W" Or LoopString1 = "AB" Then
                    .Range(LoopString1 & "15", LoopString1 & "40").Interior.Color = RGB(204, 255, 204)
                End If
                If LoopString = "" Then
                    Try
                        .Range(LoopChar & "15").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    Catch ex As Exception
                        .Range(LoopChar & "15").VerticalAlignment = 2
                        .Range(LoopChar & "15").Font.Size = 8
                        .Range(LoopChar & "15").Font.Bold = True
                        .Range(LoopChar & "15").HorizontalAlignment = 3
                        Count1 = 0
                        .Range(LoopChar & "15").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    End Try
                Else
                    Try
                        .Range(LoopString & "15").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    Catch ex As Exception
                        Count1 = 0
                        Count1 = Count1 + 1
                    End Try
                End If
                LoopChar = Chr(Asc(LoopChar) + 1)
            Next
            AttDate.Clear()
            CharList.Clear()
            .Activate()
            Dim Str As String
            Str = "AurieGlo:" & vbCrLf & "Example:" & vbCrLf & "Data: 40 employees in Dept.Cutting." & vbCrLf & "This week have 5 full workdays." & vbCrLf & "           Day 1= 40 emp present;" & vbCrLf & "           Day 2= 38 emp(2 emp sick leave);" & vbCrLf & "           Day 3= 39 emp(1 sick);" & vbCrLf & "           Day 4= 35 emp(3 emp sick,2 emp maternity leave);" & vbCrLf & "           Day 5= 39 emp(1 emp absent)." & vbCrLf & "Therefore,average no of actual working employees(present at work,based on absency record)" & vbCrLf & "is=(40+38+39+35+39)emp/5days" & vbCrLf & "      =1192/5 = 38.2" & vbCrLf & "      = 38 employees."
            .Range("D16").AddComment(Str)

            Str = "AurieGlo:" & vbCrLf & "Example: For 5 working days:" & vbCrLf & "1.if total effective working days in this week is 5 days and daily" & vbCrLf & "workhours is 8hours/day." & vbCrLf & "Then total Reg.hours= 8hrs * 5days=40hrs." & vbCrLf & "" & vbCrLf & "2.For 5 working days with 1 national holiday:" & vbCrLf & "if total effective working days is 4 days (due to 1 day off because of" & vbCrLf & "of national holiday), then total reg. hours" & vbCrLf & "= 8 hrs * 4 days = 36 hrs. "
            .Range("E16").AddComment(Str)

            Str = "AurieGlo:" & vbCrLf & "Example:" & vbCrLf & "Dept Cutting = 40 employees." & vbCrLf & "This week there are 2 times overtime work performed by all employees in this dept." & vbCrLf & "      OT 1 in Tuesday = 3 hours after regular workhours." & vbCrLf & "      OT 2 in Saturday (this is the regular rest day because this factory is using 5" & vbCrLf & "workdays system) = 6 hours. But in saturday, only 35 employees were able to do OT." & vbCrLf & "" & vbCrLf & "Therefore, Total OT Hours in this week (Week 1) would be " & vbCrLf & "= (40 emp*3hrs)+(35emp*6hrs)" & vbCrLf & "= 120hrs+210hrs " & vbCrLf & "= 330hrs"
            .Range("F16").AddComment(Str)

            Str = "AurieGlo:" & vbCrLf & "average weekly workhours must not exceed the limit set by Local" & vbCrLf & "Labour Law & SEA standards, or whichever is stricter (in this case: SEA" & vbCrLf & "Standards):" & vbCrLf & "" & vbCrLf & "=> Maximum 60 hours work per week in total (regular work hours +" & vbCrLf & "OT work); and there must be at least 1 (one) day off / 24 hours " & vbCrLf & "consecutive rest given to workers in every 7 days period."
            .Range("H15").AddComment(Str)
            FormatAllComments()
            Dim Value1 As String
            .Range("D16", "AB40").HorizontalAlignment = 3
            .Range("D43").HorizontalAlignment = 4
            .Range("D16", "AB40").Font.Size = 10
            'Week1
            Count1 = 16
            While Count1 <= 39
                Value1 = "E" + Count1.ToString + "*D" + Count1.ToString + "+" + "F" + Count1.ToString
                '.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                .Range("G" & Count1 & "").Formula = "=(" & Value1 & ")"

                Value1 = "G" + Count1.ToString + "/" + "D" + Count1.ToString
                .Range("H" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("H" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("D40").Formula = "=Sum(D16:D39)"
            .Range("E40").Formula = "=Sum(E16:E39)"
            .Range("F40").Formula = "=Sum(F16:F39)"
            .Range("G40").Formula = "=Sum(G16:G39)"
            .Range("H40").Formula = "=(G40/D40)"
            .Range("H40").NumberFormat = "0.0"
            'Count1 = 5
            'Week2
            Count1 = 16
            While Count1 <= 39
                'Value1 = "J" + Count1.ToString + "," + "K" + Count1.ToString
                '.Range("L" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                Value1 = "J" + Count1.ToString + "*I" + Count1.ToString + "+" + "K" + Count1.ToString
                '.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                .Range("L" & Count1 & "").Formula = "=(" & Value1 & ")"
                Value1 = "L" + Count1.ToString + "/" + "I" + Count1.ToString
                .Range("M" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("M" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("I40").Formula = "=Sum(I16:I39)"
            .Range("J40").Formula = "=Sum(J16:J39)"
            .Range("K40").Formula = "=Sum(K16:K39)"
            .Range("L40").Formula = "=Sum(L16:L39)"
            .Range("M40").Formula = "=(L40/I40)"
            .Range("M40").NumberFormat = "0.0"
            'Week3
            Count1 = 16
            While Count1 <= 39
                'Value1 = "O" + Count1.ToString + "," + "P" + Count1.ToString
                '.Range("Q" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                Value1 = "O" + Count1.ToString + "*N" + Count1.ToString + "+" + "P" + Count1.ToString
                '.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                .Range("Q" & Count1 & "").Formula = "=(" & Value1 & ")"
                Value1 = "Q" + Count1.ToString + "/" + "N" + Count1.ToString
                .Range("R" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("R" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("N40").Formula = "=Sum(N16:N39)"
            .Range("O40").Formula = "=Sum(O16:O39)"
            .Range("P40").Formula = "=Sum(P16:P39)"
            .Range("Q40").Formula = "=Sum(Q16:Q39)"
            .Range("R40").Formula = "=(Q40/N40)"
            .Range("R40").NumberFormat = "0.0"
            'Week 4
            Count1 = 16
            While Count1 <= 39
                'Value1 = "T" + Count1.ToString + "," + "U" + Count1.ToString
                '.Range("V" & Count1 & "").Formula = "=Sum(" & Value1 & ")"

                Value1 = "T" + Count1.ToString + "*S" + Count1.ToString + "+" + "U" + Count1.ToString
                '.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                .Range("V" & Count1 & "").Formula = "=(" & Value1 & ")"

                Value1 = "V" + Count1.ToString + "/" + "S" + Count1.ToString
                .Range("W" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("W" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("S40").Formula = "=Sum(S16:S39)"
            .Range("T40").Formula = "=Sum(T16:T39)"
            .Range("U40").Formula = "=Sum(U16:U39)"
            .Range("V40").Formula = "=Sum(V16:V39)"
            .Range("W40").Formula = "=(V40/S40)"
            .Range("W40").NumberFormat = "0.0"
            'Week5
            Count1 = 16
            While Count1 <= 39
                'Value1 = "Y" + Count1.ToString + "," + "Z" + Count1.ToString
                '.Range("AA" & Count1 & "").Formula = "=Sum(" & Value1 & ")"

                Value1 = "Y" + Count1.ToString + "*X" + Count1.ToString + "+" + "Z" + Count1.ToString
                '.Range("G" & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                .Range("AA" & Count1 & "").Formula = "=(" & Value1 & ")"

                Value1 = "AA" + Count1.ToString + "/" + "X" + Count1.ToString
                .Range("AB" & Count1 & "").Formula = "=(" & Value1 & ")"
                .Range("AB" & Count1 & "").NumberFormat = "0.0"
                Count1 = Count1 + 1
            End While
            .Range("X40").Formula = "=Sum(X16:X39)"
            .Range("Y40").Formula = "=Sum(Y16:Y39)"
            .Range("Z40").Formula = "=Sum(Z16:Z39)"
            .Range("AA40").Formula = "=Sum(AA16:AA39)"
            .Range("AB40").Formula = "=(AA40/X40)"
            .Range("AB40").NumberFormat = "0.0"
            'Final Reset Values
            'ResetVlaues(436)

            .Range("D42").Formula = "=AVERAGE(D40,I40,N40,X40,S40)"
            .Range("D43").Formula = "=AVERAGE(H40,M40,R40,W40,AB40)"
            .Range("D43").NumberFormat = "0"
            .Range("D42").NumberFormat = "0"

            .Range("D14", "AB14").Locked = False
            .Range("E5", "E8").Locked = False
            .Range("C16", "F39").Locked = False
            .Range("I16", "K39").Locked = False
            .Range("N16", "P39").Locked = False
            .Range("S16", "U39").Locked = False
            .Range("X16", "Z39").Locked = False
            .Protect()
            .Name = "Average OT"
            xlApp.ActiveWindow.Zoom = 70
            .Cells(16, 4).select()
            .Application.ActiveWindow.FreezePanes = True
        End With
        'xlApp.ActiveWindow.Zoom = 70
    End Sub
    Private Sub OTHoursData1()
        'Try
        '    Me.Tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter.Fill(Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
        'Catch ex As Exception
        'End Try
        xlWorkSheet = xlWorkBook.Sheets("sheet2")
        Dim AttDate As New ArrayList
        Dim CharList As New ArrayList
        With xlWorkSheet
            .Range("A1", "IV14").Interior.Color = RGB(255, 255, 255)
            .Range("AM13", "XFD550").Interior.Color = RGB(255, 255, 255)
            .Range("A41", "XFD550").Interior.Color = RGB(255, 255, 255)
            .Range("A1").ColumnWidth = 0.71
            .Range("D1", "AK1").ColumnWidth = 6.5
            .Range("A14").RowHeight = 112
            .Range("A1").RowHeight = 5.5
            .Range("A4").RowHeight = 4.5
            .Range("A3").RowHeight = 35
            .Range("B2").RowHeight = 24
            .Range("A12").RowHeight = 3.5
            .Range("A16", "AB39").RowHeight = 20
            .Range("A5", "A9").RowHeight = 15
            .Range("B1").ColumnWidth = 5.11
            .Range("C1").ColumnWidth = 40.11
            .Range("A5", "AK11").Font.Name = "Tahoma"
            .Range("A5", "AK11").Font.Size = 10
            .Range("A13").RowHeight = 22.5
            .Range("C53").Value = "Total employees"
            .Range("C54").Value = "Total working hours"
            .Range("C53", "C54").Interior.Color = RGB(255, 255, 0)
            .Range("D53", "D54").Interior.Color = RGB(0, 204, 255)
            .Range("B2").Font.Size = 16
            .Range("B2").Font.Name = "Century Gothic"
            .Range("B2").Font.Bold = True
            .Range("K3").Font.Size = 18
            .Range("K3").Font.Name = "Albertus"
            .Range("B13", "AL43").Font.Name = "Tahoma"
            .Range("K3").Font.Bold = True
            Borders = .Range("B14", "AL40").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            Borders = .Range("C41", "AL43").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            Borders = .Range("C47", "C51").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            Borders = .Range("D47", "I51").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            .Range("A46").RowHeight = 25.1
            .Range("D46").Value = "0-48"
            .Range("E46").Value = "49-54"
            .Range("F46").Value = "55-60"
            .Range("G46").Value = "61-70"
            .Range("H46").Value = ">70"
            .Range("D46", "H46").HorizontalAlignment = 3
            .Range("D46", "H46").VerticalAlignment = 2

            .Range("D46", "H46").Font.Bold = True

            Borders = .Range("D46", "H46").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 3.0R

            .Range("C53", "E54").Font.Bold = True

            Borders = .Range("C53", "E54").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            .Range("D46", "I51").Font.Size = 10
            .Range("D46", "I51").Font.Name = "Tahoma"


            .Range("C47", "C51").Font.Size = 12
            .Range("C47", "C51").Font.Name = "Tahoma"

            .Range("C53", "E54").Font.Size = 10
            .Range("C53", "E54").Font.Name = "Tahoma"

            .Range("C53", "E54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("B14", "AL40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("D13", "J43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C41", "C43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("K13", "Q43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R13", "X43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("X13", "AE43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("AF13", "AL43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C47", "C51").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("D47", "I51").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Cells(3, 11) = "WEEKLY REGULAR AND OVERTIME HOURS WORKED REPORT"
            .Cells(2, 2) = "Adidas Sourcing Limited"
            .Cells(6, 2) = "Reporting Month"
            .Cells(7, 2) = "Standard Work Day Per Week"
            .Cells(8, 2) = "Standard Work Hours Per Day (Monday To Saturday)"
            .Cells(9, 2) = "Maximum OverTime Hours Per Day (Mon -Saturday)"
            .Cells(5, 2) = "Factory Name"
            .Range("F5").Value = "Forward   Sports"
            .Range("F6").Value = Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Range("F6").HorizontalAlignment = 2
            .Range("F7").Value = "6"
            .Range("F8").Value = "8"
            .Range("F9").Value = "2"
            .Range("F7", "F10").HorizontalAlignment = 3

            .Range("C47").Value = "WEEK 1"
            .Range("C48").Value = "WEEK 2"
            .Range("C49").Value = "WEEK 3"
            .Range("C50").Value = "WEEK 4"
            .Range("C51").Value = "WEEK 5"
            .Range("C47", "C51").HorizontalAlignment = 3

            .Range("D53", "E53").Merge()
            .Range("D54", "E54").Merge()

            .Range("F5", "H5").Merge()
            .Range("F6", "H6").Merge()
            .Range("D13", "J13").Merge()
            .Range("K13", "Q13").Merge()
            .Range("R13", "X13").Merge()
            .Range("Y13", "AE13").Merge()
            .Range("AF13", "AL13").Merge()
            .Range("D13").Value = "WEEK 1"
            .Range("K13").Value = "WEEK 2"
            .Range("R13").Value = "WEEK 3"
            .Range("Y13").Value = "WEEK 4"
            .Range("AF13").Value = "WEEK 5"
            .Range("D13").Font.Bold = True
            .Range("D13").HorizontalAlignment = 3
            .Range("D13").VerticalAlignment = 2
            .Range("K13").Font.Bold = True
            .Range("K13").HorizontalAlignment = 3
            .Range("K13").VerticalAlignment = 2
            .Range("R13").Font.Bold = True
            .Range("R13").HorizontalAlignment = 3
            .Range("R13").VerticalAlignment = 2
            .Range("Y13").Font.Bold = True
            .Range("Y13").HorizontalAlignment = 3
            .Range("Y13").VerticalAlignment = 2
            .Range("AF13").Font.Bold = True
            .Range("AF13").HorizontalAlignment = 3
            .Range("AF13").VerticalAlignment = 2
            .Range("B14").Value = "No"
            .Range("C14").Value = "Department"
            '.Range("C14").Orientation = 90
            .Range("B14", "C14").Font.Size = 18
            .Range("B14", "C14").Font.Bold = True
            .Range("B14", "AL14").VerticalAlignment = 2
            .Range("B14", "AL14").HorizontalAlignment = 3
            .Range("F5", "H5").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F6", "H6").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F7").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F8").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F9").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F10").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("Y9", "Z9").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("Y10", "Z10").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("AC2", "AK2").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("AC2", "AK2").Interior.Color = RGB(255, 255, 153)
            .Range("AC2", "AK2").Font.Name = "Arial"
            .Range("AC2", "AK2").Font.Size = 10
            .Range("AC2", "AK2").Font.Bold = True
            .Range("AD2").Value = "DUE DATE :  BY 10th OF THE MONTH"
            .Range("AD2").VerticalAlignment = 2
            .Range("Y9").Interior.Color = RGB(255, 255, 0)
            .Range("Y10").Interior.Color = RGB(255, 255, 0)
            .Range("Z10").Value = "days"
            .Range("Z9").Value = "days"
            .Range("U9", "U10").Font.Name = "Arial"
            .Range("F5", "H6").Interior.Color = RGB(255, 255, 0)
            .Range("F7", "F10").Interior.Color = RGB(255, 255, 0)
            .Range("K6").Value = "Total Standard Lunch Break Time / Day (hours)"
            .Range("K7").Value = "Standard Rest Day"
            .Range("K8").Value = "Reporting Month Start Date"
            .Range("K9").Value = "Reporting Month Finish Date"
            .Range("K10").Value = "Actual Standard Work Days this Month"
            .Range("U9").Value = "Public / National Holiday"
            .Range("U10").Value = "Rest days and Sundays"
            .Range("AC6").Value = "Factory Representative  (Signature/date)"
            .Range("AI6").Value = "___________________"
            .Range("X9").Value = ":"
            .Range("X10").Value = ":"
            For i As Integer = 5 To 10
                .Range("E" & i & "").Value = ":"
                If i > 5 Then
                    If i < 10 Then
                        .Range("Q" & i + 1 & "", "Q" & i + 1 & "").HorizontalAlignment = 2
                    Else
                        .Range("Q" & i + 1 & "", "Q" & i + 1 & "").HorizontalAlignment = 3
                    End If
                    .Range("P" & i & "").Value = ":"
                    If i = 8 Or i = 9 Then
                        .Range("Q" & i & "", "R" & i & "").Merge()
                    End If
                    .Range("Q" & i & "", "R" & i & "").Interior.Color = RGB(255, 255, 0)
                    .Range("Q" & i & "", "R" & i & "").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                End If
            Next
            AttDate.Clear()
            AttDate.Add("MLP")
            AttDate.Add("QR")
            AttDate.Add("TM")
            AttDate.Add("R&D")
            'AttDate.Add("T.P.U")
            AttDate.Add("RWPD")
            AttDate.Add("Machine Stitch")
            'AttDate.Add("Machine Stitch Old Forward")
            AttDate.Add("AMB Production")
            AttDate.Add("Quality Assurance")
            AttDate.Add("Issuance")
            AttDate.Add("Administration")
            AttDate.Add("Maintenance")
            AttDate.Add("Staff")
            AttDate.Add("Bladder Winding")
            .Range("B15", "B40").HorizontalAlignment = 3
            Dim CharCount As Integer = 0
            For i As Integer = 1 To 25
                .Range("B" & i + 14 & "").Value = i
                Try
                    .Range("C" & i + 14 & "").Value = AttDate.Item(CharCount)
                    CharCount = CharCount + 1
                Catch ex As Exception
                End Try
            Next
            'here
            'Dim AttDate As New ArrayList
            Dim LoopChar As Char = "A"
            AttDate.Clear()
            AttDate.Add("No. of Employees")
            AttDate.Add("0-48")
            AttDate.Add("49-54")
            AttDate.Add("55-60")
            AttDate.Add("61-70")
            AttDate.Add(">70")
            AttDate.Add("Swapping/OT in" & vbCrLf & "holiday")
            While LoopChar <= "L"
                CharList.Add("A" & LoopChar & "").ToString()
                LoopChar = Chr(Asc(LoopChar) + 1)
            End While
            LoopChar = "D"
            Dim Count1 As Integer = 0
            Dim LoopString As String = ""
            Dim LoopString1 As String = ""
            .Range("C42", "D43").Font.Size = 10
            .Range("D14", "AL43").Font.Size = 10
            .Range("D14", "AL14").Font.Bold = True
            .Range("D14", "AL14").HorizontalAlignment = 3
            .Range("D14", "AL14").VerticalAlignment = 2
            .Range("C41", "D41").Font.Bold = True
            .Range("C41", "AL43").Font.Size = 9
            .Range("C41", "AL43").HorizontalAlignment = 3
            .Range("C41").Value = "Total employees"
            .Range("C42").Value = "Range vs Total"
            .Range("C43").Value = "Group vs Total"
            .Range("C41", "C42").RowHeight = 19.5
            Dim ColorList, ColorList1 As New ArrayList
            ColorList.Add(RGB(255, 255, 153))
            ColorList.Add(RGB(255, 255, 0))
            ColorList.Add(RGB(255, 102, 0))
            ColorList.Add(RGB(255, 0, 0))

            ColorList1.Add(RGB(128, 128, 128))
            ColorList1.Add(RGB(192, 192, 192))
            ColorList1.Add(RGB(255, 255, 153))
            ColorList1.Add(RGB(255, 204, 0))
            ColorList1.Add(RGB(255, 102, 0))
            ColorList1.Add(RGB(255, 102, 0))
            Dim LoopChar1 As Char = "D"
            Dim ColorCount As Integer = 0
            Dim ColorCount1 As Integer = 0
            Dim ColorCount2 As Integer = 0
            For i As Integer = 1 To 35
                LoopString1 = LoopChar
                If Count1 <= 6 Then
                Else
                    Count1 = 0
                End If
                If i > 23 Then
                    LoopString = CharList.Item(i - 24)
                    LoopString1 = LoopString
                End If
                Try
                    .Range(LoopChar1 & "14").Orientation = -90
                    LoopChar1 = Chr(Asc(LoopChar1) + 7)
                Catch ex As Exception
                    .Range("AE14").Orientation = -90
                    .Range("AF14").Orientation = -90
                    .Range("AL14").Orientation = -90
                End Try
                If LoopString1 = "J" Or LoopString1 = "Q" Or LoopString1 = "X" Or LoopString1 = "AE" Or LoopString1 = "AL" Then
                    .Range(LoopString1 & "14").Font.Size = 12
                    .Range(LoopString1 & "14").Orientation = -90
                End If
                If LoopString = "" Then
                    Try
                        If LoopChar <= "Z" Then
                        Else
                            Exit For
                        End If
                        .Range(LoopString1 & "14").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    Catch ex As Exception
                        Count1 = 0
                        Try
                            .Range(LoopString1 & "14").Value = AttDate.Item(Count1)
                            Count1 = Count1 + 1
                        Catch ex1 As Exception

                        End Try
                    End Try
                Else
                    Try
                        .Range(LoopString & "14").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    Catch ex As Exception
                        Count1 = 0
                        Count1 = Count1 + 1
                    End Try
                End If
                If LoopString1 = "D" Or LoopString1 = "E" Or LoopString1 = "J" Or LoopString1 = "K" Or LoopString1 = "L" Or LoopString1 = "Q" Or LoopString1 = "R" Or LoopString1 = "S" Or LoopString1 = "X" Or LoopString1 = "Y" Or LoopString1 = "Z" Or LoopString1 = "AE" Or LoopString1 = "AF" Or LoopString1 = "AG" Or LoopString1 = "AL" Then
                Else
                    If ColorCount > 3 Then
                        ColorCount = 0
                    End If
                    .Range(LoopString1 & "14").Interior.Color = ColorList.Item(ColorCount)

                    ColorCount = ColorCount + 1
                End If
                If LoopString1 = "E" Or LoopString1 = "F" Or LoopString1 = "G" Or LoopString1 = "H" Then
                    Try
                        .Range(LoopString1 & "46").Interior.Color = ColorList.Item(ColorCount2)
                        ColorCount2 = ColorCount2 + 1
                    Catch ex As Exception

                    End Try

                End If
                If LoopString1 = "E" Or LoopString1 = "L" Or LoopString1 = "S" Or LoopString1 = "Z" Or LoopString1 = "AG" Or LoopString1 = "AL" Then
                Else
                    If ColorCount1 > 5 Then
                        ColorCount1 = 0
                    End If
                    .Range(LoopString1 & "42").Interior.Color = ColorList1.Item(ColorCount1)
                    ColorCount1 = ColorCount1 + 1
                End If
                LoopChar = Chr(Asc(LoopChar) + 1)
            Next

            'End Here
            Dim MyDate As Date = GetLastDayOfMonth(Me.DateTimePicker1.Text)
            .Range("Q6").Value = "0.5"
            .Range("R6").Value = "hours"
            .Range("R10").Value = "days"
            '   
            .Range("Q6").HorizontalAlignment = 3
            .Range("Q7").Value = "Sunday"
            .Range("Q8").Value = "01/" + Me.DateTimePicker1.Value.ToString("MMMM") + "/" + Me.DateTimePicker1.Value.Year.ToString
            .Range("Q9").Value = MyDate.Day.ToString + "/" + Me.DateTimePicker1.Value.ToString("MMMM") + "/" + Me.DateTimePicker1.Value.Year.ToString

            'Week1
            LoopChar1 = "A"
            CharList.Clear()
            CharList.Add("D")
            CharList.Add("K")
            CharList.Add("R")
            CharList.Add("Y")
            CharList.Add("AF")
            ColorList.Clear()

            While LoopChar1 < "M"
                ColorList.Add("A" & LoopChar1 & "").ToString()
                LoopChar1 = Chr(Asc(LoopChar1) + 1)
            End While
            LoopChar = "D"
            Count1 = 0
            '.Range("E42").Formula = "=+E41/$D$41"
            For j As Integer = 0 To CharList.Count - 1
                For i As Integer = 1 To 7
                    If LoopChar > "Z" Then
                        LoopString1 = LoopChar
                        LoopString1 = ColorList.Item(Count1)
                        Count1 = Count1 + 1
                        'Exit For
                    Else
                        LoopString1 = LoopChar
                        'LoopString1 = LoopChar
                    End If
                    Try
                        LoopString = LoopString1
                        If LoopString = "D" Or LoopString = "J" Or LoopString = "K" Or LoopString = "Q" Or LoopString = "R" Or LoopString = "X" Or LoopString = "Y" Or LoopString = "AE" Or LoopString = "AF" Or LoopString = "AL" Then
                            'ElseIf LoopString = "D" Or LoopString = "K" Or LoopString = "R" Or LoopString = "Y" Or LoopString = "AF" Then
                            '    .Range(LoopString + "43").Formula = "=(+E41+F41+G41+H41+I41)/" & LoopString & "41"

                        Else

                            .Range(LoopString + "42").Formula = "=+" & LoopString & "41/$" & CharList.Item(j).ToString & "$41"
                        End If
                    Catch ex As Exception

                    End Try
                    LoopChar = Chr(Asc(LoopChar) + 1)
                Next
            Next
            .Range("D43").Formula = "=(+E41+F41+G41+H41+I41)/D41"
            .Range("K43").Formula = "=(+L41+M41+N41+O41+P41)/K41"
            .Range("R43").Formula = "=(+S41+T41+U41+V41+W41)/R41"
            .Range("Y43").Formula = "=(+Z41+AA41+AB41+AC41+AD41)/Y41"
            .Range("AF43").Formula = "=(+AG41+AH41+AI41+AJ41+AK41)/AF41"

            'Week1
            .Range("D47").Formula = "=+E42"
            .Range("E47").Formula = "=+F42"
            .Range("F47").Formula = "=+G42"
            .Range("G47").Formula = "=+H42"
            .Range("H47").Formula = "=+I42"
            .Range("I47").Formula = "=Sum(D47:H47)"
            'Week2

            .Range("D48").Formula = "=+L42"
            .Range("E48").Formula = "=+M42"
            .Range("F48").Formula = "=+N42"
            .Range("G48").Formula = "=+O42"
            .Range("H48").Formula = "=+P42"
            .Range("I48").Formula = "=Sum(D48:H48)"

            'Week3
            .Range("D49").Formula = "=+S42"
            .Range("E49").Formula = "=+T42"
            .Range("F49").Formula = "=+U42"
            .Range("G49").Formula = "=+V42"
            .Range("H49").Formula = "=+W42"
            .Range("I49").Formula = "=Sum(D49:H49)"

            'Week4
            .Range("D50").Formula = "=+Z42"
            .Range("E50").Formula = "=+AA42"
            .Range("F50").Formula = "=+AB42"
            .Range("G50").Formula = "=+AC42"
            .Range("H50").Formula = "=+AD42"
            .Range("I50").Formula = "=Sum(D50:H50)"

            'Week5
            .Range("D51").Formula = "=+AG42"
            .Range("E51").Formula = "=+AH42"
            .Range("F51").Formula = "=+AI42"
            .Range("G51").Formula = "=+AJ42"
            .Range("H51").Formula = "=+AK42"
            .Range("I51").Formula = "=Sum(D51:H51)"

            .Range("D53").Formula = "=AVERAGE(D43,K43,R43,Y43,AF43)"
            .Range("D54").Formula = "='Average OT'!D43:E43"
            .Range("D54").NumberFormat = "0"
            .Range("D53").NumberFormat = "0"
            'Average OT'!#REF!
            .Range("Q10").HorizontalAlignment = 3
            .Range("Y9", "Y10").HorizontalAlignment = 3
            If Me.Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource.Count > 0 Then
                .Range("Q10").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("WorkingDaysInMonth")
                .Range("Y9").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("HolidaysInMonth")
                .Range("Y10").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("SundaysInMonth")
            End If
            'Dim box As Aspose.Cells.Drawing.GroupBox = xlWorkBook.Worksheets(0).Shapes.AddGroupBox(1, 0, 1, 0, 300, 250)
            'Dim box As Aspose.Cells.Drawing.GroupBox = xlWorkBook.Worksheets(0).Shapes.AddGroupBox(1, 0, 1, 0, 300, 250)
            'box.Text = "Age Group"
            'box.Placement = Aspose.Cells.Drawing.PlacementType.FreeFloating
            .Range("D15", "AL42").Font.Size = 9
            .Range("F6", "H6").Locked = False
            .Range("F7", "F10").Locked = False
            .Range("Q6", "Q7").Locked = False
            .Range("Q8", "R8").Locked = False
            .Range("Q9", "R9").Locked = False
            .Range("Q10").Locked = False
            .Range("Y9", "Y10").Locked = False
            ResetVlaues(436)
            .Range("C15", "AL39").Locked = False
            .Protect()
            .Activate()
            .Name = "OT"
            xlApp.ActiveWindow.Zoom = 78
            .Cells(15, 4).select()
            .Application.ActiveWindow.FreezePanes = True
            xlWorkBook.Sheets("Sheet3").Delete()
            xlWorkBook.Protect()
        End With
    End Sub
    Private Sub OTHoursData()
        'Try
        '    Me.Tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter.Fill(Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
        'Catch ex As Exception
        'End Try
        xlWorkSheet = xlWorkBook.Sheets("sheet2")
        Dim AttDate As New ArrayList
        Dim CharList As New ArrayList
        With xlWorkSheet
            .Range("A1", "IV14").Interior.Color = RGB(255, 255, 255)
            .Range("AM13", "XFD550").Interior.Color = RGB(255, 255, 255)
            .Range("A41", "XFD550").Interior.Color = RGB(255, 255, 255)
            .Range("A1").ColumnWidth = 0.71
            .Range("D1", "AK1").ColumnWidth = 6.5
            .Range("A14").RowHeight = 112
            .Range("A1").RowHeight = 5.5
            .Range("A4").RowHeight = 4.5
            .Range("A3").RowHeight = 35
            .Range("B2").RowHeight = 24
            .Range("A12").RowHeight = 3.5
            .Range("A16", "AB39").RowHeight = 20
            .Range("A5", "A9").RowHeight = 15
            .Range("B1").ColumnWidth = 5.11
            .Range("C1").ColumnWidth = 40.11
            .Range("A5", "AK11").Font.Name = "Tahoma"
            .Range("A5", "AK11").Font.Size = 10
            .Range("A13").RowHeight = 22.5
            .Range("C53").Value = "Total employees"
            .Range("C54").Value = "Total working hours"
            .Range("C53", "C54").Interior.Color = RGB(255, 255, 0)
            .Range("D53", "D54").Interior.Color = RGB(0, 204, 255)
            .Range("B2").Font.Size = 16
            .Range("B2").Font.Name = "Century Gothic"
            .Range("B2").Font.Bold = True
            .Range("K3").Font.Size = 18
            .Range("K3").Font.Name = "Albertus"
            .Range("B13", "AL43").Font.Name = "Tahoma"
            .Range("K3").Font.Bold = True
            Borders = .Range("B14", "AL40").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            Borders = .Range("C41", "AL43").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            Borders = .Range("C47", "C51").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            Borders = .Range("D47", "I51").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            .Range("A46").RowHeight = 25.1
            .Range("D46").Value = "0-48"
            .Range("E46").Value = "49-54"
            .Range("F46").Value = "55-60"
            .Range("G46").Value = "61-70"
            .Range("H46").Value = ">70"
            .Range("D46", "H46").HorizontalAlignment = 3
            .Range("D46", "H46").VerticalAlignment = 2

            .Range("D46", "H46").Font.Bold = True

            Borders = .Range("D46", "H46").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 3.0R

            .Range("C53", "E54").Font.Bold = True

            Borders = .Range("C53", "E54").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            .Range("D46", "I51").Font.Size = 10
            .Range("D46", "I51").Font.Name = "Tahoma"


            .Range("C47", "C51").Font.Size = 12
            .Range("C47", "C51").Font.Name = "Tahoma"

            .Range("C53", "E54").Font.Size = 10
            .Range("C53", "E54").Font.Name = "Tahoma"

            .Range("C53", "E54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("B14", "AL40").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("D13", "J43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C41", "C43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("K13", "Q43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R13", "X43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("X13", "AE43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("AF13", "AL43").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C47", "C51").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("D47", "I51").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Cells(3, 11) = "WEEKLY REGULAR AND OVERTIME HOURS WORKED REPORT"
            .Cells(2, 2) = "Adidas Sourcing Limited"
            .Cells(6, 2) = "Reporting Month"
            .Cells(7, 2) = "Standard Work Day Per Week"
            .Cells(8, 2) = "Standard Work Hours Per Day (Monday To Saturday)"
            .Cells(9, 2) = "Maximum OverTime Hours Per Day (Mon -Saturday)"
            .Cells(5, 2) = "Factory Name"
            .Range("F5").Value = "Forward   Sports"
            .Range("F6").Value = Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Range("F6").HorizontalAlignment = 2
            .Range("F7").Value = "7"
            .Range("F8").Value = "8"
            .Range("F9").Value = "2"
            .Range("F7", "F10").HorizontalAlignment = 3

            .Range("C47").Value = "WEEK 1"
            .Range("C48").Value = "WEEK 2"
            .Range("C49").Value = "WEEK 3"
            .Range("C50").Value = "WEEK 4"
            .Range("C51").Value = "WEEK 5"
            .Range("C47", "C51").HorizontalAlignment = 3

            .Range("D53", "E53").Merge()
            .Range("D54", "E54").Merge()

            .Range("F5", "H5").Merge()
            .Range("F6", "H6").Merge()
            .Range("D13", "J13").Merge()
            .Range("K13", "Q13").Merge()
            .Range("R13", "X13").Merge()
            .Range("Y13", "AE13").Merge()
            .Range("AF13", "AL13").Merge()
            .Range("D13").Value = "WEEK 1"
            .Range("K13").Value = "WEEK 2"
            .Range("R13").Value = "WEEK 3"
            .Range("Y13").Value = "WEEK 4"
            .Range("AF13").Value = "WEEK 5"
            .Range("D13").Font.Bold = True
            .Range("D13").HorizontalAlignment = 3
            .Range("D13").VerticalAlignment = 2
            .Range("K13").Font.Bold = True
            .Range("K13").HorizontalAlignment = 3
            .Range("K13").VerticalAlignment = 2
            .Range("R13").Font.Bold = True
            .Range("R13").HorizontalAlignment = 3
            .Range("R13").VerticalAlignment = 2
            .Range("Y13").Font.Bold = True
            .Range("Y13").HorizontalAlignment = 3
            .Range("Y13").VerticalAlignment = 2
            .Range("AF13").Font.Bold = True
            .Range("AF13").HorizontalAlignment = 3
            .Range("AF13").VerticalAlignment = 2
            .Range("B14").Value = "No"
            .Range("C14").Value = "Department"
            '.Range("C14").Orientation = 90
            .Range("B14", "C14").Font.Size = 18
            .Range("B14", "C14").Font.Bold = True
            .Range("B14", "AL14").VerticalAlignment = 2
            .Range("B14", "AL14").HorizontalAlignment = 3
            .Range("F5", "H5").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F6", "H6").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F7").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F8").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F9").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("F10").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("Y9", "Z9").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("Y10", "Z10").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("AC2", "AK2").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
            .Range("AC2", "AK2").Interior.Color = RGB(255, 255, 153)
            .Range("AC2", "AK2").Font.Name = "Arial"
            .Range("AC2", "AK2").Font.Size = 10
            .Range("AC2", "AK2").Font.Bold = True
            .Range("AD2").Value = "DUE DATE :  BY 10th OF THE MONTH"
            .Range("AD2").VerticalAlignment = 2
            .Range("Y9").Interior.Color = RGB(255, 255, 0)
            .Range("Y10").Interior.Color = RGB(255, 255, 0)
            .Range("Z10").Value = "days"
            .Range("Z9").Value = "days"
            .Range("U9", "U10").Font.Name = "Arial"
            .Range("F5", "H6").Interior.Color = RGB(255, 255, 0)
            .Range("F7", "F10").Interior.Color = RGB(255, 255, 0)
            .Range("K6").Value = "Total Standard Lunch Break Time / Day (hours)"
            .Range("K7").Value = "Standard Rest Day"
            .Range("K8").Value = "Reporting Month Start Date"
            .Range("K9").Value = "Reporting Month Finish Date"
            .Range("K10").Value = "Actual Standard Work Days this Month"
            .Range("U9").Value = "Public / National Holiday"
            .Range("U10").Value = "Rest days and Sundays"
            .Range("AC6").Value = "Factory Representative  (Signature/date)"
            .Range("AI6").Value = "___________________"
            .Range("X9").Value = ":"
            .Range("X10").Value = ":"
            For i As Integer = 5 To 10
                .Range("E" & i & "").Value = ":"
                If i > 5 Then
                    If i < 10 Then
                        .Range("Q" & i + 1 & "", "Q" & i + 1 & "").HorizontalAlignment = 2
                    Else
                        .Range("Q" & i + 1 & "", "Q" & i + 1 & "").HorizontalAlignment = 3
                    End If
                    .Range("P" & i & "").Value = ":"
                    If i = 8 Or i = 9 Then
                        .Range("Q" & i & "", "R" & i & "").Merge()
                    End If
                    .Range("Q" & i & "", "R" & i & "").Interior.Color = RGB(255, 255, 0)
                    .Range("Q" & i & "", "R" & i & "").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin)
                End If
            Next
            AttDate.Clear()
            AttDate.Add("MLP")
            AttDate.Add("QR")
            AttDate.Add("TM")
            AttDate.Add("R&D")
            'AttDate.Add("T.P.U")
            AttDate.Add("RWPD")
            AttDate.Add("Machine Stitch")
            'AttDate.Add("Machine Stitch Old Forward")
            AttDate.Add("AMB Production")
            AttDate.Add("Quality Assurance")
            AttDate.Add("Issuance")
            'AttDate.Add("Bladder Winding")
            AttDate.Add("Administration")
            AttDate.Add("Maintenance")
            AttDate.Add("Staff")

            .Range("B15", "B40").HorizontalAlignment = 3
            Dim CharCount As Integer = 0
            For i As Integer = 1 To 25
                .Range("B" & i + 14 & "").Value = i
                Try
                    .Range("C" & i + 14 & "").Value = AttDate.Item(CharCount)
                    CharCount = CharCount + 1
                Catch ex As Exception
                End Try
            Next
            'here
            'Dim AttDate As New ArrayList
            Dim LoopChar As Char = "A"
            AttDate.Clear()
            AttDate.Add("No. of Employees")
            AttDate.Add("0-48")
            AttDate.Add("49-54")
            AttDate.Add("55-60")
            AttDate.Add("61-70")
            AttDate.Add(">70")
            AttDate.Add("Swapping/OT in" & vbCrLf & "holiday")
            While LoopChar <= "L"
                CharList.Add("A" & LoopChar & "").ToString()
                LoopChar = Chr(Asc(LoopChar) + 1)
            End While
            LoopChar = "D"
            Dim Count1 As Integer = 0
            Dim LoopString As String = ""
            Dim LoopString1 As String = ""
            .Range("C42", "D43").Font.Size = 10
            .Range("D14", "AL43").Font.Size = 10
            .Range("D14", "AL14").Font.Bold = True
            .Range("D14", "AL14").HorizontalAlignment = 3
            .Range("D14", "AL14").VerticalAlignment = 2
            .Range("C41", "D41").Font.Bold = True
            .Range("C41", "AL43").Font.Size = 9
            .Range("C41", "AL43").HorizontalAlignment = 3
            .Range("C41").Value = "Total employees"
            .Range("C42").Value = "Range vs Total"
            .Range("C43").Value = "Group vs Total"
            .Range("C41", "C42").RowHeight = 19.5
            Dim ColorList, ColorList1 As New ArrayList
            ColorList.Add(RGB(255, 255, 153))
            ColorList.Add(RGB(255, 255, 0))
            ColorList.Add(RGB(255, 102, 0))
            ColorList.Add(RGB(255, 0, 0))

            ColorList1.Add(RGB(128, 128, 128))
            ColorList1.Add(RGB(192, 192, 192))
            ColorList1.Add(RGB(255, 255, 153))
            ColorList1.Add(RGB(255, 204, 0))
            ColorList1.Add(RGB(255, 102, 0))
            ColorList1.Add(RGB(255, 102, 0))
            Dim LoopChar1 As Char = "D"
            Dim ColorCount As Integer = 0
            Dim ColorCount1 As Integer = 0
            Dim ColorCount2 As Integer = 0
            For i As Integer = 1 To 35
                LoopString1 = LoopChar
                If Count1 <= 6 Then
                Else
                    Count1 = 0
                End If
                If i > 23 Then
                    LoopString = CharList.Item(i - 24)
                    LoopString1 = LoopString
                End If
                Try
                    .Range(LoopChar1 & "14").Orientation = -90
                    LoopChar1 = Chr(Asc(LoopChar1) + 7)
                Catch ex As Exception
                    .Range("AE14").Orientation = -90
                    .Range("AF14").Orientation = -90
                    .Range("AL14").Orientation = -90
                End Try
                If LoopString1 = "J" Or LoopString1 = "Q" Or LoopString1 = "X" Or LoopString1 = "AE" Or LoopString1 = "AL" Then
                    .Range(LoopString1 & "14").Font.Size = 12
                    .Range(LoopString1 & "14").Orientation = -90
                End If
                If LoopString = "" Then
                    Try
                        If LoopChar <= "Z" Then
                        Else
                            Exit For
                        End If
                        .Range(LoopString1 & "14").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    Catch ex As Exception
                        Count1 = 0
                        Try
                            .Range(LoopString1 & "14").Value = AttDate.Item(Count1)
                            Count1 = Count1 + 1
                        Catch ex1 As Exception

                        End Try
                    End Try
                Else
                    Try
                        .Range(LoopString & "14").Value = AttDate.Item(Count1)
                        Count1 = Count1 + 1
                    Catch ex As Exception
                        Count1 = 0
                        Count1 = Count1 + 1
                    End Try
                End If
                If LoopString1 = "D" Or LoopString1 = "E" Or LoopString1 = "J" Or LoopString1 = "K" Or LoopString1 = "L" Or LoopString1 = "Q" Or LoopString1 = "R" Or LoopString1 = "S" Or LoopString1 = "X" Or LoopString1 = "Y" Or LoopString1 = "Z" Or LoopString1 = "AE" Or LoopString1 = "AF" Or LoopString1 = "AG" Or LoopString1 = "AL" Then
                Else
                    If ColorCount > 3 Then
                        ColorCount = 0
                    End If
                    .Range(LoopString1 & "14").Interior.Color = ColorList.Item(ColorCount)

                    ColorCount = ColorCount + 1
                End If
                If LoopString1 = "E" Or LoopString1 = "F" Or LoopString1 = "G" Or LoopString1 = "H" Then
                    Try
                        .Range(LoopString1 & "46").Interior.Color = ColorList.Item(ColorCount2)
                        ColorCount2 = ColorCount2 + 1
                    Catch ex As Exception

                    End Try

                End If
                If LoopString1 = "E" Or LoopString1 = "L" Or LoopString1 = "S" Or LoopString1 = "Z" Or LoopString1 = "AG" Or LoopString1 = "AL" Then
                Else
                    If ColorCount1 > 5 Then
                        ColorCount1 = 0
                    End If
                    .Range(LoopString1 & "42").Interior.Color = ColorList1.Item(ColorCount1)
                    ColorCount1 = ColorCount1 + 1
                End If
                LoopChar = Chr(Asc(LoopChar) + 1)
            Next

            'End Here
            Dim MyDate As Date = GetLastDayOfMonth(Me.DateTimePicker1.Text)
            .Range("Q6").Value = "0.5"
            .Range("R6").Value = "hours"
            .Range("R10").Value = "days"
            '   
            .Range("Q6").HorizontalAlignment = 3
            .Range("Q7").Value = "Sunday"
            .Range("Q8").Value = "01/" + Me.DateTimePicker1.Value.ToString("MMMM") + "/" + Me.DateTimePicker1.Value.Year.ToString
            .Range("Q9").Value = MyDate.Day.ToString + "/" + Me.DateTimePicker1.Value.ToString("MMMM") + "/" + Me.DateTimePicker1.Value.Year.ToString

            'Week1
            LoopChar1 = "A"
            CharList.Clear()
            CharList.Add("D")
            CharList.Add("K")
            CharList.Add("R")
            CharList.Add("Y")
            CharList.Add("AF")
            ColorList.Clear()

            While LoopChar1 < "M"
                ColorList.Add("A" & LoopChar1 & "").ToString()
                LoopChar1 = Chr(Asc(LoopChar1) + 1)
            End While
            LoopChar = "D"
            Count1 = 0
            '.Range("E42").Formula = "=+E41/$D$41"
            For j As Integer = 0 To CharList.Count - 1
                For i As Integer = 1 To 7
                    If LoopChar > "Z" Then
                        LoopString1 = LoopChar
                        LoopString1 = ColorList.Item(Count1)
                        Count1 = Count1 + 1
                        'Exit For
                    Else
                        LoopString1 = LoopChar
                        'LoopString1 = LoopChar
                    End If
                    Try
                        LoopString = LoopString1
                        If LoopString = "D" Or LoopString = "J" Or LoopString = "K" Or LoopString = "Q" Or LoopString = "R" Or LoopString = "X" Or LoopString = "Y" Or LoopString = "AE" Or LoopString = "AF" Or LoopString = "AL" Then
                            'ElseIf LoopString = "D" Or LoopString = "K" Or LoopString = "R" Or LoopString = "Y" Or LoopString = "AF" Then
                            '    .Range(LoopString + "43").Formula = "=(+E41+F41+G41+H41+I41)/" & LoopString & "41"

                        Else

                            .Range(LoopString + "42").Formula = "=+" & LoopString & "41/$" & CharList.Item(j).ToString & "$41"
                        End If
                    Catch ex As Exception

                    End Try
                    LoopChar = Chr(Asc(LoopChar) + 1)
                Next
            Next
            .Range("D43").Formula = "=(+E41+F41+G41+H41+I41)/D41"
            .Range("K43").Formula = "=(+L41+M41+N41+O41+P41)/K41"
            .Range("R43").Formula = "=(+S41+T41+U41+V41+W41)/R41"
            .Range("Y43").Formula = "=(+Z41+AA41+AB41+AC41+AD41)/Y41"
            .Range("AF43").Formula = "=(+AG41+AH41+AI41+AJ41+AK41)/AF41"

            'Week1
            .Range("D47").Formula = "=+E42"
            .Range("E47").Formula = "=+F42"
            .Range("F47").Formula = "=+G42"
            .Range("G47").Formula = "=+H42"
            .Range("H47").Formula = "=+I42"
            .Range("I47").Formula = "=Sum(D47:H47)"
            'Week2

            .Range("D48").Formula = "=+L42"
            .Range("E48").Formula = "=+M42"
            .Range("F48").Formula = "=+N42"
            .Range("G48").Formula = "=+O42"
            .Range("H48").Formula = "=+P42"
            .Range("I48").Formula = "=Sum(D48:H48)"

            'Week3
            .Range("D49").Formula = "=+S42"
            .Range("E49").Formula = "=+T42"
            .Range("F49").Formula = "=+U42"
            .Range("G49").Formula = "=+V42"
            .Range("H49").Formula = "=+W42"
            .Range("I49").Formula = "=Sum(D49:H49)"

            'Week4
            .Range("D50").Formula = "=+Z42"
            .Range("E50").Formula = "=+AA42"
            .Range("F50").Formula = "=+AB42"
            .Range("G50").Formula = "=+AC42"
            .Range("H50").Formula = "=+AD42"
            .Range("I50").Formula = "=Sum(D50:H50)"

            'Week5
            .Range("D51").Formula = "=+AG42"
            .Range("E51").Formula = "=+AH42"
            .Range("F51").Formula = "=+AI42"
            .Range("G51").Formula = "=+AJ42"
            .Range("H51").Formula = "=+AK42"
            .Range("I51").Formula = "=Sum(D51:H51)"

            .Range("D53").Formula = "=AVERAGE(D43,K43,R43,Y43,AF43)"
            .Range("D54").Formula = "='Average OT'!D43:E43"
            .Range("D54").NumberFormat = "0"
            .Range("D53").NumberFormat = "0"
            'Average OT'!#REF!
            .Range("Q10").HorizontalAlignment = 3
            .Range("Y9", "Y10").HorizontalAlignment = 3
            If Me.Tbl_Acc_Salary_Transactions_WorkingDaysBindingSource.Count > 0 Then
                .Range("Q10").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("WorkingDaysInMonth")
                .Range("Y9").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("HolidaysInMonth")
                .Range("Y10").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("SundaysInMonth")
            End If
            'Dim box As Aspose.Cells.Drawing.GroupBox = xlWorkBook.Worksheets(0).Shapes.AddGroupBox(1, 0, 1, 0, 300, 250)
            'Dim box As Aspose.Cells.Drawing.GroupBox = xlWorkBook.Worksheets(0).Shapes.AddGroupBox(1, 0, 1, 0, 300, 250)
            'box.Text = "Age Group"
            'box.Placement = Aspose.Cells.Drawing.PlacementType.FreeFloating
            .Range("D15", "AL42").Font.Size = 9
            .Range("F6", "H6").Locked = False
            .Range("F7", "F10").Locked = False
            .Range("Q6", "Q7").Locked = False
            .Range("Q8", "R8").Locked = False
            .Range("Q9", "R9").Locked = False
            .Range("Q10").Locked = False
            .Range("Y9", "Y10").Locked = False
            ResetVlaues(436)
            .Range("C15", "AL39").Locked = False
            .Protect()
            .Activate()
            .Name = "OT"
            xlApp.ActiveWindow.Zoom = 78
            .Cells(15, 4).select()
            .Application.ActiveWindow.FreezePanes = True
            xlWorkBook.Sheets("Sheet3").Delete()
            xlWorkBook.Protect()
        End With
    End Sub

    Private Sub LoadSheet1Records()
        Path = "" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + " Employee Profile.xlsx"
        xlApp = New Excel.ApplicationClass
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkSheet1 = xlWorkBook.Sheets("sheet3")
        Flag = True
        ToolStripProgressBar1.Value = 0
        ToolStripProgressBar1.Maximum = 420
        Dim MonthValue As Date = CDate(Me.DateTimePicker1.Text).AddMonths(-1)
        ResetVlaues(4)
        Try
            Me.View_AgeTableAdapter.Fill(Me.DSExcelEmpData.View_Age, GetFirstDayOfMonth(MonthValue))
        Catch ex As Exception
        End Try
        Try
            Me.View_DOJ_Age1TableAdapter.Fill(Me.DSExcelEmpData.View_Doj_Age1, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As Exception
        End Try
        Try
            Me.View_DOJ_Age11TableAdapter.Fill(Me.DSExcelEmpData.View_DOJ_Age11, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As Exception
        End Try
        Try
            Me.View_Rpt_Acc_AllEmployees111TableAdapter.Fill(Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111, MonthValue)
        Catch ex As Exception
        End Try
        Try
            Me.View_Excel_Emp_DataTableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Data, MonthValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Excel_Emp_DurationTableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Duration, MonthValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DSExcelEmpData.tbl_HRM_Emp_Info, MonthValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.View_Excel_Emp_Job_TypeTableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Job_Type, MonthValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Excel_Emp_SalaryTableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Salary, MonthValue)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Excel_Emp_Job_Level11TableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Job_Level11, MonthValue)
        Catch ex As System.Exception
        End Try
        Try
            Me.View_Rpt_Current_Month_MaritalStatusTableAdapter.Fill(Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As Exception
        End Try
        Try
            Me.View_Rpt_Out_Month_MaritalStatusTableAdapter.Fill(Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As Exception
        End Try
        Try
            Me.View_Emp_Data_Duration_GradeWiseTableAdapter.Fill(Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.View_Current_Month_DurationTableAdapter.Fill(Me.DSExcelEmpData.View_Current_Month_Duration, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Try
            Me.View_Out_Month_DurationTableAdapter.Fill(Me.DSExcelEmpData.View_Out_Month_Duration, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_OUT_Month_Salary1TableAdapter.Fill(Me.DSExcelEmpData.View_OUT_Month_Salary1, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Current_Month_SalaryTableAdapter.Fill(Me.DSExcelEmpData.View_Current_Month_Salary, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Age_MaritalStatusTableAdapter.Fill(Me.DSExcelEmpData.View_Age_MaritalStatus, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
        Catch ex As Exception
        End Try
        'Dim xlWorkBook As Excel.Workbook

        'Dim misValue As Object = System.Reflection.Missing.Value
        'xlApp = New Excel.ApplicationClass
        'xlWorkBook = xlApp.Workbooks.Add(misValue)
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")
        With xlWorkSheet
            'Previous Month Age Records
            ResetVlaues(7)
            For i As Integer = 0 To Me.View_Age_MaritalStatusBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("MaritalStatus") = "Married" Then
                    If Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Gender") = "Male" Then
                        If Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 20 Then
                            Age18 = Age18 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 22 Then
                            Age20 = Age20 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 22 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 25 Then
                            Age25 = Age25 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 30 Then
                            Age30 = Age30 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 35 Then
                            Age35 = Age35 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 35 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 40 Then
                            Age40 = Age40 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 42 Then
                            Age42 = Age42 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 42 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 45 Then
                            Age43 = Age43 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        Else
                            Age45 = Age45 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        End If
                    ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Gender") = "Female" Then
                        If Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 20 Then
                            FAge18 = FAge18 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 22 Then
                            FAge20 = FAge20 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 22 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 25 Then
                            FAge25 = FAge25 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 30 Then
                            FAge30 = FAge30 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 35 Then
                            FAge35 = FAge35 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 35 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 40 Then
                            FAge40 = FAge40 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 42 Then
                            FAge42 = FAge42 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 42 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 45 Then
                            FAge43 = FAge43 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        Else
                            FAge45 = FAge45 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        End If
                    End If
                Else
                    If Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Gender") = "Male" Then
                        If Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 20 Then
                            TotalAge = TotalAge + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 22 Then
                            TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 22 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 25 Then
                            TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 30 Then
                            TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 35 Then
                            TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 35 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 40 Then
                            TotalAge5 = TotalAge5 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 42 Then
                            TotalAge6 = TotalAge6 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 42 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 45 Then
                            TotalAge7 = TotalAge7 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        Else
                            TotalAge8 = TotalAge8 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        End If
                    ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Gender") = "Female" Then
                        If Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 20 Then
                            FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 22 Then
                            FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 22 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 25 Then
                            FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 30 Then
                            FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 35 Then
                            FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 35 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 40 Then
                            FTotalAge5 = FTotalAge5 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 42 Then
                            FTotalAge6 = FTotalAge6 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        ElseIf Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") >= 42 And Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("AgeGroup") < 45 Then
                            FTotalAge7 = FTotalAge7 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        Else
                            FTotalAge8 = FTotalAge8 + Me.DSExcelEmpData.View_Age_MaritalStatus.Rows(i).Item("Age")
                        End If
                    End If
                End If
            Next
            'here is Age and Marriage
            With xlWorkSheet1
                .Cells(49, 5) = Age18
                .Cells(51, 5) = Age20
                .Cells(53, 5) = Age25
                .Cells(55, 5) = Age30
                .Cells(57, 5) = Age35
                .Cells(59, 5) = Age40
                .Cells(61, 5) = Age42
                .Cells(63, 5) = Age43
                .Cells(65, 5) = Age45

                .Cells(49, 8) = FAge18
                .Cells(51, 8) = FAge20
                .Cells(53, 8) = FAge25
                .Cells(55, 8) = FAge30
                .Cells(57, 8) = FAge35
                .Cells(59, 8) = FAge40
                .Cells(61, 8) = FAge42
                .Cells(63, 8) = FAge43
                .Cells(65, 8) = FAge45

                .Cells(49, 4) = TotalAge
                .Cells(51, 4) = TotalAge1
                .Cells(53, 4) = TotalAge2
                .Cells(55, 4) = TotalAge3
                .Cells(57, 4) = TotalAge4
                .Cells(59, 4) = TotalAge5
                .Cells(61, 4) = TotalAge6
                .Cells(63, 4) = TotalAge7
                .Cells(65, 4) = TotalAge8

                .Cells(49, 7) = FTotalAge
                .Cells(51, 7) = FTotalAge1
                .Cells(53, 7) = FTotalAge2
                .Cells(55, 7) = FTotalAge3
                .Cells(57, 7) = FTotalAge4
                .Cells(59, 7) = FTotalAge5
                .Cells(61, 7) = FTotalAge6
                .Cells(63, 7) = FTotalAge7
                .Cells(65, 7) = FTotalAge8

            End With
            ResetVlaues(10)
            For i As Integer = 0 To Me.View_AgeBindingSource.Count - 1

                If Me.DSExcelEmpData.View_Age.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 17 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 20 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 25 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 30 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 35 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 40 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 45 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    Else
                        Age45 = Age45 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    End If
                ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 17 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 20 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 25 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 30 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 35 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 40 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Age.Rows(i).Item("AgeGroup") < 45 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    Else
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Age.Rows(i).Item("Age")
                    End If
                End If
                .Cells(5, 5) = 0
                .Cells(6, 5) = Age18
                .Cells(7, 5) = Age20
                .Cells(8, 5) = Age25
                .Cells(9, 5) = Age30
                .Cells(10, 5) = Age35
                .Cells(11, 5) = Age40
                .Cells(12, 5) = Age45
                .Cells(5, 6) = 0
                .Cells(6, 6) = FAge18
                .Cells(7, 6) = FAge20
                .Cells(8, 6) = FAge25
                .Cells(9, 6) = FAge30
                .Cells(10, 6) = FAge35
                .Cells(11, 6) = FAge40
                .Cells(12, 6) = FAge45
                .Cells(5, 7) = 0
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 5
                While Count1 <= 12
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E13").Formula = "=Sum(E5:E12)"
                .Range("F13").Formula = "=Sum(F5:F12)"
                .Range("G13").Formula = "=Sum(G5:G12)"
                Count1 = 5


                While Count1 <= 12
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(13, 8) = "100%"
                Count1 = 5
                E1 = "E"
                F = "I"
                G1 = "L"
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 12
                    Dim Value1 As String = E1 + Count1.ToString + "+" + F + Count1.ToString + "-" + G1 + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While

            Next
            'Previous Month Education Record
            ResetVlaues(20)
            For i As Integer = 0 To Me.View_Rpt_Acc_AllEmployees111BindingSource.Count - 1
                If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "NO" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Illiterate" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Primary" Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Middle" Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Matric Arts" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Matric Science" Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "FA" Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "B.A" Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "ACCA" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "CA" Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "NO" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Illiterate" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Primary" Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Middle" Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Matric Arts" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Matric Science" Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "FA" Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "B.A" Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "ACCA" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "CA" Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    End If
                End If
                .Cells(15, 5) = Age18
                .Cells(16, 5) = Age20
                .Cells(17, 5) = Age25
                .Cells(18, 5) = Age30
                .Cells(19, 5) = Age35
                .Cells(20, 5) = Age40
                .Cells(21, 5) = TotalAge
                .Cells(22, 5) = Age45
                .Cells(15, 6) = FAge18
                .Cells(16, 6) = FAge20
                .Cells(17, 6) = FAge25
                .Cells(18, 6) = FAge30
                .Cells(19, 6) = FAge35
                .Cells(20, 6) = FAge40
                .Cells(21, 6) = FTotalAge
                .Cells(22, 6) = FAge45
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 15
                While Count1 <= 22
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E23").Formula = "=Sum(E15:E22)"
                .Range("F23").Formula = "=Sum(F15:F22)"
                .Range("G23").Formula = "=Sum(G15:G22)"
                Count1 = 15
                While Count1 <= 22
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "23"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(23, 8) = "100%"
            Next
            'Education Month In Current Month
            ResetVlaues(30)
            Try
                Me.View_Rpt_Acc_AllEmployees111TableAdapter.Fill(Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
            Catch ex As Exception
            End Try
            For i As Integer = 0 To Me.View_Rpt_Acc_AllEmployees111BindingSource.Count - 1
                If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "NO" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Illiterate" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Primary" Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Middle" Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Matric Arts" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Matric Science" Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "FA" Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "B.A" Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "ACCA" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "CA" Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "NO" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Illiterate" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Primary" Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Middle" Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Matric Arts" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "Matric Science" Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "FA" Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "B.A" Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "ACCA" Or Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("Qualification") = "CA" Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees111.Rows(i).Item("QualificationCount")
                    End If
                End If
                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G1 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 15
                While Count1 <= 22
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R23").Formula = "=Sum(R15:R22)"
                .Range("S23").Formula = "=Sum(S15:S22)"
                .Range("T23").Formula = "=Sum(T15:T22)"
                Count1 = 15
                While Count1 <= 22
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "23"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(23, 21) = "100%"

                Count1 = 15
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 22
                    Dim Value1 As String = "E" + Count1.ToString + "+" + "I" + Count1.ToString + "-" + "L" + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While
            Next
            'Previous Month Marital Stauts
            ResetVlaues(40)
            For i As Integer = 0 To Me.View_Excel_Emp_DataBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatus") = "Unmarried" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatusCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatusCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatus") = "Unmarried" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatusCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatusCount")
                    End If
                End If
                .Cells(25, 5) = TotalAge
                .Cells(26, 5) = Age18
                .Cells(25, 6) = FTotalAge
                .Cells(26, 6) = FAge18
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 25
                While Count1 <= 26
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E27").Formula = "=Sum(E25:E26)"
                .Range("F27").Formula = "=Sum(F25:F26)"
                .Range("G27").Formula = "=Sum(G25:G26)"
                Count1 = 25
                While Count1 <= 26
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(27, 8) = "100%"
            Next

            'Current Month In Marital Status Records
            ResetVlaues(50)
            For i As Integer = 0 To Me.View_Rpt_Current_Month_MaritalStatusBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus.Rows(i).Item("MaritalStatus") = "Unmarried" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus.Rows(i).Item("MaritalStatusCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus.Rows(i).Item("MaritalStatusCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus.Rows(i).Item("MaritalStatus") = "Unmarried" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus.Rows(i).Item("MaritalStatusCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Rpt_Current_Month_MaritalStatus.Rows(i).Item("MaritalStatusCount")
                    End If
                End If
                .Cells(25, 9) = TotalAge
                .Cells(26, 9) = Age18
                .Cells(25, 10) = FTotalAge
                .Cells(26, 10) = FAge18
                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                Dim Count1 As Integer = 25
                While Count1 <= 26
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I27").Formula = "=Sum(I25:I26)"
                .Range("J27").Formula = "=Sum(J25:J26)"
                .Range("K27").Formula = "=Sum(K25:K26)"
            Next

            'Current Month OUT Marital Status Records
            ResetVlaues(60)
            For i As Integer = 0 To Me.View_Rpt_Out_Month_MaritalStatusBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus.Rows(i).Item("Gender") = "Male" Then
                    Try
                        If Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus.Rows(i).Item("MaritalStatus") = "Unmarried" Then
                            Age18 = Age18 + Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus.Rows(i).Item("MaritalStatusCount")
                        Else
                            TotalAge = TotalAge + Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus.Rows(i).Item("MaritalStatusCount")
                        End If
                    Catch ex As Exception

                    End Try

                ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus.Rows(i).Item("MaritalStatus") = "Unmarried" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus.Rows(i).Item("MaritalStatusCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Rpt_Out_Month_MaritalStatus.Rows(i).Item("MaritalStatusCount")
                    End If
                End If
                .Cells(25, 12) = TotalAge
                .Cells(26, 12) = Age18
                .Cells(25, 13) = FTotalAge
                .Cells(26, 13) = FAge18
                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                Dim Count1 As Integer = 25
                While Count1 <= 26
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L27").Formula = "=Sum(L25:L26)"
                .Range("M27").Formula = "=Sum(M25:M26)"
                .Range("N27").Formula = "=Sum(N25:N26)"
                'Marital Status Change Catagory
                Count1 = 25
                While Count1 <= 27
                    .Cells(Count1, 15) = 0
                    .Cells(Count1, 16) = 0
                    .Cells(Count1, 17) = 0
                    Count1 = Count1 + 1
                End While
            Next

            'Current Month In Employee Status
            Try
                Me.View_Excel_Emp_DataTableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Data, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
            Catch ex As Exception
            End Try
            ResetVlaues(70)
            For i As Integer = 0 To Me.View_Excel_Emp_DataBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatus") = "Unmarried" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatusCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatusCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatus") = "Unmarried" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatusCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Data.Rows(i).Item("MaritalStatusCount")
                    End If
                End If
                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G1 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 25
                While Count1 <= 26
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R27").Formula = "=Sum(R25:R26)"
                .Range("S27").Formula = "=Sum(S25:S26)"
                .Range("T27").Formula = "=Sum(T25:T26)"
                Count1 = 25
                While Count1 <= 26
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "27"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(27, 21) = "100%"
                Count1 = 25
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 26
                    Dim Value1 As String = "E" + Count1.ToString + "+" + "I" + Count1.ToString + "-" + "L" + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While
            Next

            'Marital Status Ratio Analysis

            Dim V1 As Char = "V"
            Dim W As Char = "W"
            Dim X As Char = "X"
            Dim N As Char = "N"
            Dim T1 As Char = "T"
            Dim K As Char = "K"
            Dim G As Char = "G"
            Dim Count As Integer = 25
            'Dim SumValue As Integer
            While Count <= 27
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 25
            While Count <= 27
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While

            'Previous Month Working Duration
            ResetVlaues(80)
            For i As Integer = 0 To Me.View_Excel_Emp_DurationBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 1 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 1 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 2 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 4 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 6 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 8 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 10 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 12 Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 14 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 16 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    Else
                        TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 1 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 1 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 2 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 4 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 6 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 8 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 10 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 12 Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 14 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 16 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    Else
                        FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    End If
                End If
                .Cells(37, 5) = Age18
                .Cells(38, 5) = Age20
                .Cells(39, 5) = Age25
                .Cells(40, 5) = Age30
                .Cells(41, 5) = Age35
                .Cells(42, 5) = Age40
                .Cells(43, 5) = Age45
                .Cells(44, 5) = TotalAge
                .Cells(45, 5) = TotalAge1
                .Cells(46, 5) = TotalAge2
                .Cells(37, 6) = FAge18
                .Cells(38, 6) = FAge20
                .Cells(39, 6) = FAge25
                .Cells(40, 6) = FAge30
                .Cells(41, 6) = FAge35
                .Cells(42, 6) = FAge40
                .Cells(43, 6) = FAge45
                .Cells(44, 6) = FTotalAge
                .Cells(45, 6) = FTotalAge1
                .Cells(46, 6) = FTotalAge2
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 37
                While Count1 <= 46
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E47").Formula = "=Sum(E37:E46)"
                .Range("F47").Formula = "=Sum(F37:F46)"
                .Range("G47").Formula = "=Sum(G37:G46)"
                Count1 = 37
                While Count1 <= 46
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(47, 8) = "100%"
            Next

            'Current Month Working Duration
            ResetVlaues(90)
            Me.View_Excel_Emp_DurationTableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Duration, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
            For i As Integer = 0 To Me.View_Excel_Emp_DurationBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 1 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 1 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 2 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 4 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 6 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 8 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 10 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 12 Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 14 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 16 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    Else
                        TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 1 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 1 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 2 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 4 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 6 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 8 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 10 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 12 Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 14 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("Duration") < 16 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    Else
                        FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Duration.Rows(i).Item("DurationCount")
                    End If
                End If
                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G1 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 37
                While Count1 <= 46
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R47").Formula = "=Sum(R37:R46)"
                .Range("S47").Formula = "=Sum(S37:S46)"
                .Range("T47").Formula = "=Sum(T37:T46)"
                Count1 = 37
                While Count1 <= 46
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(47, 21) = "100%"
                Count1 = 37
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 46
                    Dim Value1 As String = "E" + Count1.ToString + "+" + "I" + Count1.ToString + "-" + "L" + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While
            Next

            ' Current Month In Employee List
            ResetVlaues(100)
            For i As Integer = 0 To Me.View_Current_Month_DurationBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 1 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 1 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 2 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 4 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 6 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 8 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 10 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 12 Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 14 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 16 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    Else
                        TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 1 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 1 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 2 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 4 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 6 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 8 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 10 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 12 Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 14 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("Duration") < 16 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    Else
                        FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Current_Month_Duration.Rows(i).Item("DurationCount")
                    End If
                End If
                .Cells(37, 9) = Age18
                .Cells(38, 9) = Age20
                .Cells(39, 9) = Age25
                .Cells(40, 9) = Age30
                .Cells(41, 9) = Age35
                .Cells(42, 9) = Age40
                .Cells(43, 9) = Age45
                .Cells(44, 9) = TotalAge
                .Cells(45, 9) = TotalAge1
                .Cells(46, 9) = TotalAge2
                .Cells(37, 10) = FAge18
                .Cells(38, 10) = FAge20
                .Cells(39, 10) = FAge25
                .Cells(40, 10) = FAge30
                .Cells(41, 10) = FAge35
                .Cells(42, 10) = FAge40
                .Cells(43, 10) = FAge45
                .Cells(44, 10) = FTotalAge
                .Cells(45, 10) = FTotalAge1
                .Cells(46, 10) = FTotalAge2
                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                Dim Count1 As Integer = 37
                While Count1 <= 46
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I47").Formula = "=Sum(I37:I46)"
                .Range("J47").Formula = "=Sum(J37:J46)"
                .Range("K47").Formula = "=Sum(K37:K46)"
            Next

            ' Current Month OUT Employee List
            ResetVlaues(110)
            For i As Integer = 0 To Me.View_Out_Month_DurationBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 1 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 1 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 2 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 4 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 6 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 8 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 10 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 12 Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 14 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 16 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    Else
                        TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 1 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 1 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 2 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 4 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 6 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 8 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 10 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 12 Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 14 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    ElseIf Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("Duration") < 16 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    Else
                        FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Out_Month_Duration.Rows(i).Item("DurationCount")
                    End If
                End If
                .Cells(37, 12) = Age18
                .Cells(38, 12) = Age20
                .Cells(39, 12) = Age25
                .Cells(40, 12) = Age30
                .Cells(41, 12) = Age35
                .Cells(42, 12) = Age40
                .Cells(43, 12) = Age45
                .Cells(44, 12) = TotalAge
                .Cells(45, 12) = TotalAge1
                .Cells(46, 12) = TotalAge2
                .Cells(37, 13) = FAge18
                .Cells(38, 13) = FAge20
                .Cells(39, 13) = FAge25
                .Cells(40, 13) = FAge30
                .Cells(41, 13) = FAge35
                .Cells(42, 13) = FAge40
                .Cells(43, 13) = FAge45
                .Cells(44, 13) = FTotalAge
                .Cells(45, 13) = FTotalAge1
                .Cells(46, 13) = FTotalAge2
                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                Dim Count1 As Integer = 37
                While Count1 <= 46
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L47").Formula = "=Sum(L37:L46)"
                .Range("M47").Formula = "=Sum(M37:M46)"
                .Range("N47").Formula = "=Sum(N37:N46)"
            Next

            'Working Duration Change Catagory

            Dim Count41 As Integer = 37
            While Count41 <= 47
                .Cells(Count41, 15) = 0
                .Cells(Count41, 16) = 0
                .Cells(Count41, 17) = 0
                Count41 = Count41 + 1
            End While

            'Previous Month Employment Status
            'Search
            ResetVlaues(120)
            For i As Integer = 0 To Me.View_Excel_Emp_Job_TypeBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobType") = "Permanent" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobType") = "Trainee" Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobType") = "Permanent" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobType") = "Trainee" Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    End If
                End If
                Try
                    '.Cells(49, 5) = Me.DSExcelEmpData.tbl_HRM_Emp_Info.Rows(0).Item("GenderCount")
                    '.Cells(49, 6) = Me.DSExcelEmpData.tbl_HRM_Emp_Info.Rows(0).Item("GenderCount")
                    .Cells(49, 5) = 0
                    .Cells(49, 6) = 0
                Catch ex As Exception
                    .Cells(49, 5) = 0
                    .Cells(49, 6) = 0
                End Try
                .Cells(50, 5) = 0
                .Cells(50, 6) = 0
                .Cells(53, 5) = Age20
                .Cells(53, 6) = FAge20
                .Cells(51, 5) = TotalAge
                .Cells(52, 5) = Age18
                .Cells(51, 6) = FTotalAge
                .Cells(52, 6) = FAge18
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 49
                While Count1 <= 53
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E54").Formula = "=Sum(E49:E53)"
                .Range("F54").Formula = "=Sum(F49:F53)"
                .Range("G54").Formula = "=Sum(G49:G53)"
                Count1 = 49
                While Count1 <= 53
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(54, 8) = "100%"
            Next

            'Current Month Employment Status
            ResetVlaues(130)
            Me.View_Excel_Emp_Job_TypeTableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Job_Type, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
            Try
                Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DSExcelEmpData.tbl_HRM_Emp_Info, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            For i As Integer = 0 To Me.View_Excel_Emp_Job_TypeBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobType") = "Permanent" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobType") = "Permanent" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Job_Type.Rows(i).Item("JobTypeCount")
                    End If
                End If
                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G1 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 49
                While Count1 <= 53
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R54").Formula = "=Sum(R50:R53)"
                .Range("S54").Formula = "=Sum(S50:S53)"
                .Range("T54").Formula = "=Sum(T50:T53)"
                Count1 = 49
                While Count1 <= 53
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(54, 21) = "100%"
                Count1 = 49
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 53
                    Dim Value1 As String = "E" + Count1.ToString + "+" + "I" + Count1.ToString + "-" + "L" + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While
            Next

            'Current Month IN Employment Status
            ResetVlaues(140)
            Me.View_Current_Month_Employee_StatusTableAdapter.Fill(Me.DSExcelEmpData.View_Current_Month_Employee_Status, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Try
                Me.Tbl_Hrm_Emp_Info_INTableAdapter.Fill(Me.DSExcelEmpData.tbl_Hrm_Emp_Info_IN, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As System.Exception
            End Try
            For i As Integer = 0 To Me.View_Current_Month_Employee_StatusBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobType") = "Permanent" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobTypeCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobType") = "Trainee" Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobTypeCount")
                    Else

                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobTypeCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobType") = "Permanent" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobTypeCount")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobType") = "Trainee" Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobTypeCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Current_Month_Employee_Status.Rows(i).Item("JobTypeCount")
                    End If
                End If
                Try
                    '.Cells(49, 9) = Me.DSExcelEmpData.tbl_Hrm_Emp_Info_IN.Rows(0).Item("GenderCount")
                    '.Cells(49, 10) = Me.DSExcelEmpData.tbl_Hrm_Emp_Info_IN.Rows(0).Item("GenderCount")
                    .Cells(49, 9) = 0
                    .Cells(49, 10) = 0
                Catch ex As Exception
                    .Cells(49, 9) = 0
                    .Cells(49, 10) = 0
                End Try
                .Cells(50, 9) = 0
                .Cells(50, 10) = 0
                .Cells(53, 9) = Age20
                .Cells(53, 10) = FAge20
                .Cells(51, 9) = TotalAge
                .Cells(52, 9) = Age18
                .Cells(51, 10) = FTotalAge
                .Cells(52, 10) = FAge18
                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                Dim Count1 As Integer = 49
                While Count1 <= 53
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I54").Formula = "=Sum(I50:I53)"
                .Range("J54").Formula = "=Sum(J50:J53)"
                .Range("K54").Formula = "=Sum(K50:K53)"
            Next

            'Current Month OUT Employment Status
            ResetVlaues(150)
            Me.View_OUT_Month_Employee_Status1TableAdapter.Fill(Me.DSExcelEmpData.View_OUT_Month_Employee_Status1, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Try
                Me.Tbl_Hrm_Emp_Info_LeavingTableAdapter.Fill(Me.DSExcelEmpData.tbl_Hrm_Emp_Info_Leaving, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As System.Exception
            End Try
            For i As Integer = 0 To Me.View_OUT_Month_Employee_Status1BindingSource.Count - 1
                If Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobType") = "Permanent" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobTypeCount")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobType") = "Trainee" Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobTypeCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobTypeCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobType") = "Permanent" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobTypeCount")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobType") = "Trainee" Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobTypeCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_OUT_Month_Employee_Status1.Rows(i).Item("JobTypeCount")
                    End If
                End If
                Try
                    '.Cells(49, 12) = Me.DSExcelEmpData.tbl_Hrm_Emp_Info_Leaving.Rows(0).Item("GenderCount")
                    '.Cells(49, 13) = Me.DSExcelEmpData.tbl_Hrm_Emp_Info_Leaving.Rows(0).Item("GenderCount")
                    .Cells(49, 12) = 0
                    .Cells(49, 13) = 0
                Catch ex As Exception
                    .Cells(49, 12) = 0
                    .Cells(49, 13) = 0
                End Try
                .Cells(50, 12) = 0
                .Cells(50, 13) = 0
                .Cells(53, 12) = Age20
                .Cells(53, 13) = FAge20
                .Cells(51, 12) = TotalAge
                .Cells(52, 12) = Age18
                .Cells(51, 13) = FTotalAge
                .Cells(52, 13) = FAge18
                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                Dim Count1 As Integer = 49
                While Count1 <= 53
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L54").Formula = "=Sum(L50:L53)"
                .Range("M54").Formula = "=Sum(M50:M53)"
                .Range("N54").Formula = "=Sum(N50:N53)"
            Next

            'Previous Month Salary info
            ResetVlaues(160)
            For i As Integer = 0 To Me.View_Excel_Emp_SalaryBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") < 15000 Then
                        Age18 = 0
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") = 15000 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 15001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 16000 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 16001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 17000 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 17001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 18000 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 18001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 20000 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 20001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 25000 Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 25001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 30000 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 30001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 35000 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 35001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 40000 Then
                        TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 40001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 45000 Then
                        TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 45001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 50000 Then
                        TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 50001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 55000 Then
                        TotalAge5 = TotalAge5 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    Else
                        TotalAge6 = TotalAge6 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") < 15000 Then
                        FAge18 = 0
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") = 15000 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 15001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 16000 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 16001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 17000 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 17001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 18000 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 18001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 20000 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 20001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 25000 Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 25001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 30000 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 30001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 35000 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 35001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 40000 Then
                        FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 40001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 45000 Then
                        FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 45001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 50000 Then
                        FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 50001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 55000 Then
                        FTotalAge5 = FTotalAge5 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    Else
                        FTotalAge6 = FTotalAge6 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    End If
                End If
                .Cells(64, 5) = Age18
                .Cells(65, 5) = Age20
                .Cells(66, 5) = Age25
                .Cells(67, 5) = Age30
                .Cells(68, 5) = Age35
                .Cells(69, 5) = Age40
                .Cells(70, 5) = Age45
                .Cells(71, 5) = TotalAge
                .Cells(72, 5) = TotalAge1
                .Cells(73, 5) = TotalAge2
                .Cells(74, 5) = TotalAge3
                .Cells(75, 5) = TotalAge4
                .Cells(76, 5) = TotalAge5
                .Cells(77, 5) = TotalAge6
                .Cells(64, 6) = FAge18
                .Cells(65, 6) = FAge20
                .Cells(66, 6) = FAge25
                .Cells(67, 6) = FAge30
                .Cells(68, 6) = FAge35
                .Cells(69, 6) = FAge40
                .Cells(70, 6) = FAge45
                .Cells(71, 6) = FTotalAge
                .Cells(72, 6) = FTotalAge1
                .Cells(73, 6) = FTotalAge2
                .Cells(74, 6) = FTotalAge3
                .Cells(75, 6) = FTotalAge4
                .Cells(76, 6) = FTotalAge5
                .Cells(77, 6) = FTotalAge6
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 64
                While Count1 <= 77
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E78").Formula = "=Sum(E64:E77)"
                .Range("F78").Formula = "=Sum(F64:F77)"
                .Range("G78").Formula = "=Sum(G64:G77)"
                Count1 = 64
                While Count1 <= 77
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(78, 8) = "100%"
            Next

            'Current Month Salary Info

            ResetVlaues(170)
            Me.View_Excel_Emp_SalaryTableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Salary, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
            For i As Integer = 0 To Me.View_Excel_Emp_SalaryBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") < 15000 Then
                        Age18 = 0
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") = 15000 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 15001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 16000 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 16001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 17000 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 17001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 18000 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 18001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 20000 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 20001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 25000 Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 25001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 30000 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 30001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 35000 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 35001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 40000 Then
                        TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 40001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 45000 Then
                        TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 45001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 50000 Then
                        TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 50001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 55000 Then
                        TotalAge5 = TotalAge5 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    Else
                        TotalAge6 = TotalAge6 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") < 15000 Then
                        FAge18 = 0
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") = 15000 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 15001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 16000 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 16001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 17000 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 17001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 18000 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 18001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 20000 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 20001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 25000 Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 25001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 30000 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 30001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 35000 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 35001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 40000 Then
                        FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 40001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 45000 Then
                        FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 45001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 50000 Then
                        FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") >= 50001 And Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("GrossSalary") <= 55000 Then
                        FTotalAge5 = FTotalAge5 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    Else
                        FTotalAge6 = FTotalAge6 + Me.DSExcelEmpData.View_Excel_Emp_Salary.Rows(i).Item("Count1")
                    End If
                End If
                'Dim E1 As Char = "R"
                'Dim F As Char = "S"
                'Dim G1 As Char = "T"
                'Dim H As Char = "U"
                'Dim Count111 As Integer = 64
                'Dim List As New ArrayList
                'While Count111 <= 77
                '    Dim Value1 As String = "R" + Count111.ToString + "," + "S" + Count111.ToString
                '    .Range("T" & Count111 & "").Formula = "=Sum(" & Value1 & ")"

                '    List.Add(.Range("T" & Count111 & "").Value)
                '    Count111 = Count111 + 1
                'End While
                '.Range("R78").Formula = "=Sum(R64:R77)"
                '.Range("S78").Formula = "=Sum(S64:S77)"
                '.Range("T78").Formula = "=Sum(T64:T77)"
                'Dim TotalEmp11 As Integer = .Range("T78").Value
                'Dim LstCount As Integer = 0
                ''check Error
                'With xlWorkSheet1
                '    .Cells(11, 3) = TotalEmp11
                '    .Cells(11, 9) = TotalEmp11
                '    For Lst As Integer = 13 To 39 Step 2
                '        .Cells(Lst, 3) = List.Item(LstCount)
                '        .Cells(Lst, 9) = List.Item(LstCount)
                '        Dim Value1 As String = "C" + Lst.ToString + "/C11"
                '        .Range("D" & Lst).Formula = "=" & Value1 & ""
                '        .Range("D" & Lst).NumberFormat = "0%"
                '        Value1 = "I" + Lst.ToString + "/I11"
                '        .Range("H" & Lst).Formula = "=" & Value1 & ""
                '        .Range("H" & Lst).NumberFormat = "0%"
                '        LstCount = LstCount + 1
                '    Next
                'End With
                'Count111 = 64
                'While Count111 <= 77
                '    Dim Value1 As String = "T" + Count111.ToString + "/" + "T" + "13"
                '    .Range("U" & Count111 & "").Formula = "=" & Value1 & ""
                '    .Range("U" & Count111 & "").NumberFormat = "0%"
                '    Count111 = Count111 + 1
                'End While
                '.Cells(78, 21) = "100%"
                'Count111 = 64
                ''Here is New Code
                ''=E6+I6-L6
                ''=F6+J6-M6
                'While Count111 <= 77
                '    Dim Value1 As String = "E" + Count111.ToString + "+" + "I" + Count111.ToString + "-" + "L" + Count111.ToString
                '    Dim Value2 As String = "F" + Count111.ToString + "+" + "J" + Count111.ToString + "-" + "M" + Count111.ToString
                '    .Range("R" & Count111 & "").Formula = "=" & Value1 & ""
                '    .Range("S" & Count111 & "").Formula = "=" & Value2 & ""
                '    Count111 = Count111 + 1
                'End While
            Next
            ''here
            'Dim Count111 As Integer = 64
            'Dim List As New ArrayList
            'While Count111 <= 77
            '    Dim Value1 As String = "R" + Count111.ToString + "," + "S" + Count111.ToString
            '    .Range("T" & Count111 & "").Formula = "=Sum(" & Value1 & ")"

            '    List.Add(.Range("T" & Count111 & "").Value)
            '    Count111 = Count111 + 1
            'End While
            '.Range("R78").Formula = "=Sum(R64:R77)"
            '.Range("S78").Formula = "=Sum(S64:S77)"
            '.Range("T78").Formula = "=Sum(T64:T77)"
            'Dim TotalEmp11 As Integer = .Range("T78").Value
            'Dim LstCount As Integer = 0
            ''check Error
            'With xlWorkSheet1
            '    .Cells(11, 3) = TotalEmp11
            '    .Cells(11, 9) = TotalEmp11
            '    For Lst As Integer = 13 To 39 Step 2
            '        .Cells(Lst, 3) = List.Item(LstCount)
            '        .Cells(Lst, 9) = List.Item(LstCount)
            '        Dim Value1 As String = "C" + Lst.ToString + "/C11"
            '        .Range("D" & Lst).Formula = "=" & Value1 & ""
            '        .Range("D" & Lst).NumberFormat = "0%"
            '        Value1 = "I" + Lst.ToString + "/I11"
            '        .Range("H" & Lst).Formula = "=" & Value1 & ""
            '        .Range("H" & Lst).NumberFormat = "0%"
            '        LstCount = LstCount + 1
            '    Next
            'End With
            'Count111 = 64
            'While Count111 <= 77
            '    Dim Value1 As String = "T" + Count111.ToString + "/" + "T" + "13"
            '    .Range("U" & Count111 & "").Formula = "=" & Value1 & ""
            '    .Range("U" & Count111 & "").NumberFormat = "0%"
            '    Count111 = Count111 + 1
            'End While
            '.Cells(78, 21) = "100%"
            'Count111 = 64
            ''Here is New Code
            ''=E6+I6-L6
            ''=F6+J6-M6
            'While Count111 <= 77
            '    Dim Value1 As String = "E" + Count111.ToString + "+" + "I" + Count111.ToString + "-" + "L" + Count111.ToString
            '    Dim Value2 As String = "F" + Count111.ToString + "+" + "J" + Count111.ToString + "-" + "M" + Count111.ToString
            '    .Range("R" & Count111 & "").Formula = "=" & Value1 & ""
            '    .Range("S" & Count111 & "").Formula = "=" & Value2 & ""
            '    Count111 = Count111 + 1
            'End While

            ''End here
            'Current Month IN Salary info
            ResetVlaues(180)
            For i As Integer = 0 To Me.View_Current_Month_SalaryBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") < 15000 Then
                        Age18 = 0
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") = 15000 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 15001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 16000 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 16001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 17000 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 17001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 18000 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 18001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 20000 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 20001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 25000 Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 25001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 30000 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 30001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 35000 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 35001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 40000 Then
                        TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 40001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 45000 Then
                        TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 45001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 50000 Then
                        TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 50001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 55000 Then
                        TotalAge5 = TotalAge5 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    Else
                        TotalAge6 = TotalAge6 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    End If
                ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") < 15000 Then
                        FAge18 = 0
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") = 15000 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 15001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 16000 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 16001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 17000 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 17001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 18000 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 18001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 20000 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 20001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 25000 Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 25001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 30000 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 30001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 35000 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 35001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 40000 Then
                        FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 40001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 45000 Then
                        FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 45001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 50000 Then
                        FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") >= 50001 And Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("GrossSalary") <= 55000 Then
                        FTotalAge5 = FTotalAge5 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    Else
                        FTotalAge6 = FTotalAge6 + Me.DSExcelEmpData.View_Current_Month_Salary.Rows(i).Item("Count1")
                    End If
                End If
                .Cells(64, 9) = Age18
                .Cells(65, 9) = Age20
                .Cells(66, 9) = Age25
                .Cells(67, 9) = Age30
                .Cells(68, 9) = Age35
                .Cells(69, 9) = Age40
                .Cells(70, 9) = Age45
                .Cells(71, 9) = TotalAge
                .Cells(72, 9) = TotalAge1
                .Cells(73, 9) = TotalAge2
                .Cells(74, 9) = TotalAge3
                .Cells(75, 9) = TotalAge4
                .Cells(76, 9) = TotalAge5
                .Cells(77, 9) = TotalAge6
                .Cells(64, 10) = FAge18
                .Cells(65, 10) = FAge20
                .Cells(66, 10) = FAge25
                .Cells(67, 10) = FAge30
                .Cells(68, 10) = FAge35
                .Cells(69, 10) = FAge40
                .Cells(70, 10) = FAge45
                .Cells(71, 10) = FTotalAge
                .Cells(72, 10) = FTotalAge1
                .Cells(73, 10) = FTotalAge2
                .Cells(74, 10) = FTotalAge3
                .Cells(75, 10) = FTotalAge4
                .Cells(76, 10) = FTotalAge5
                .Cells(77, 10) = FTotalAge6
                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                'Dim H As Char = "U"
                Dim Count1 As Integer = 64
                While Count1 <= 77
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I78").Formula = "=Sum(I64:I77)"
                .Range("J78").Formula = "=Sum(J64:J77)"
                .Range("K78").Formula = "=Sum(K64:K77)"
            Next


            'Current Month OUT Salary info
            ResetVlaues(190)
            For i As Integer = 0 To Me.View_OUT_Month_Salary1BindingSource.Count - 1
                If Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") < 15000 Then
                        Age18 = 0
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") = 15000 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 15001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 16000 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 16001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 17000 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 17001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 18000 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 18001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 20000 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 20001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 25000 Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 25001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 30000 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 30001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 35000 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 35001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 40000 Then
                        TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 40001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 45000 Then
                        TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 45001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 50000 Then
                        TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 50001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 55000 Then
                        TotalAge5 = TotalAge5 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    Else
                        TotalAge6 = TotalAge6 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    End If
                ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") < 15000 Then
                        FAge18 = 0
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") = 15000 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 15001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 16000 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 16001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 17000 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 17001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 18000 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 18001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 20000 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 20001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 25000 Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 25001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 30000 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 30001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 35000 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 35001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 40000 Then
                        FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 40001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 45000 Then
                        FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 45001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 50000 Then
                        FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") >= 50001 And Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("GrossSalary") <= 55000 Then
                        FTotalAge5 = FTotalAge5 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    Else
                        FTotalAge6 = FTotalAge6 + Me.DSExcelEmpData.View_OUT_Month_Salary1.Rows(i).Item("Count1")
                    End If
                End If
                .Cells(64, 12) = Age18
                .Cells(65, 12) = Age20
                .Cells(66, 12) = Age25
                .Cells(67, 12) = Age30
                .Cells(68, 12) = Age35
                .Cells(69, 12) = Age40
                .Cells(70, 12) = Age45
                .Cells(71, 12) = TotalAge
                .Cells(72, 12) = TotalAge1
                .Cells(73, 12) = TotalAge2
                .Cells(74, 12) = TotalAge3
                .Cells(75, 12) = TotalAge4
                .Cells(76, 12) = TotalAge5
                .Cells(77, 12) = TotalAge6
                .Cells(64, 13) = FAge18
                .Cells(65, 13) = FAge20
                .Cells(66, 13) = FAge25
                .Cells(67, 13) = FAge30
                .Cells(68, 13) = FAge35
                .Cells(69, 13) = FAge40
                .Cells(70, 13) = FAge45
                .Cells(71, 13) = FTotalAge
                .Cells(72, 13) = FTotalAge1
                .Cells(73, 13) = FTotalAge2
                .Cells(74, 13) = FTotalAge3
                .Cells(75, 13) = FTotalAge4
                .Cells(76, 13) = FTotalAge5
                .Cells(77, 13) = FTotalAge6
                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                'Dim H As Char = "U"
                Dim Count1 As Integer = 64
                While Count1 <= 77
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L78").Formula = "=Sum(L64:L77)"
                .Range("M78").Formula = "=Sum(M64:M77)"
                .Range("N78").Formula = "=Sum(N64:N77)"
            Next

            'Salary Analysis Change Catagory

            Dim Count411 As Integer = 64
            While Count411 <= 78
                .Cells(Count411, 15) = 0
                .Cells(Count411, 16) = 0
                .Cells(Count411, 17) = 0
                Count411 = Count411 + 1
            End While



            'Job Level Change Catagory
            Count411 = 55 + 1
            While Count411 <= 60 + 1
                .Cells(Count411, 15) = 0
                .Cells(Count411, 16) = 0
                .Cells(Count411, 17) = 0
                Count411 = Count411 + 1
            End While
            'Employement Status Change Catagory
            Count411 = 49
            While Count411 <= 54
                .Cells(Count411, 15) = 0
                .Cells(Count411, 16) = 0
                .Cells(Count411, 17) = 0
                Count411 = Count411 + 1
            End While

            'Previous Month Job Level
            ResetVlaues(200)
            For i As Integer = 0 To Me.View_Excel_Emp_Job_Level11BindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 5 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 4 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 3 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                        'ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level.Rows(i).Item("GradeId") = 2 Then
                        '    TotalAge2 = TotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 1 Or Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 2 Then
                        TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    Else
                        TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 5 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 4 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 3 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                        'ElseIf  Then
                        '    FTotalAge2 = FTotalAge2 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 1 Or Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 2 Then
                        FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    Else
                        FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    End If
                End If
                .Cells(55 + 1, 5) = Age18
                .Cells(56 + 1, 5) = TotalAge
                .Cells(57 + 1, 5) = TotalAge1
                .Cells(58 + 1, 5) = TotalAge3
                .Cells(59 + 1, 5) = TotalAge4
                '.Cells(55, 5) = TotalAge4
                .Cells(55 + 1, 6) = FAge18
                .Cells(56 + 1, 6) = FTotalAge
                .Cells(57 + 1, 6) = FTotalAge1
                .Cells(58 + 1, 6) = FTotalAge3
                .Cells(59 + 1, 6) = FTotalAge4
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 55 + 1
                While Count1 <= 59 + 1
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E61").Formula = "=Sum(E56:E60)"
                .Range("F61").Formula = "=Sum(F56:F60)"
                .Range("G61").Formula = "=Sum(G56:G60)"
                Count1 = 55 + 1
                While Count1 <= 59 + 1
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(60 + 1, 8) = "100%"
            Next

            'Current Month Job Level Working Duration
            ResetVlaues(205)
            'Put Here
            'New Here
            With xlWorkSheet1
                For i As Integer = 0 To Me.View_Emp_Data_Duration_GradeWiseBindingSource.Count - 1
                    If Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("GradeId") = 5 Then
                        If Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 2 Then
                            .Cells(41, 22) = .Range("V41").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 4 Then
                            .Cells(43, 22) = .Range("V43").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 6 Then
                            .Cells(45, 22) = .Range("V45").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 8 Then
                            .Cells(47, 22) = .Range("V47").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 10 Then
                            .Cells(49, 22) = .Range("V49").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 12 Then
                            .Cells(51, 22) = .Range("V51").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 14 Then
                            .Cells(53, 22) = .Range("V53").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 16 Then
                            .Cells(55, 22) = .Range("V55").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 16 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 18 Then
                            .Cells(57, 22) = .Range("V57").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 18 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 20 Then
                            .Cells(59, 22) = .Range("V59").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 20 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 22 Then
                            .Cells(61, 22) = .Range("V61").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 22 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 24 Then
                            .Cells(63, 22) = .Range("V63").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        Else
                            .Cells(65, 22) = .Range("V65").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        End If
                    ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("GradeId") = 4 Then
                        If Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 2 Then
                            .Cells(41, 23) = .Range("W41").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 4 Then
                            .Cells(43, 23) = .Range("W43").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 6 Then
                            .Cells(45, 23) = .Range("W45").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 8 Then
                            .Cells(47, 23) = .Range("W47").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 10 Then
                            .Cells(49, 23) = .Range("W49").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 12 Then
                            .Cells(51, 23) = .Range("W51").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 14 Then
                            .Cells(54, 23) = .Range("W54").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 16 Then
                            .Cells(55, 23) = .Range("W55").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 16 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 18 Then
                            .Cells(57, 23) = .Range("W57").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 18 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 20 Then
                            .Cells(59, 23) = .Range("W59").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 20 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 22 Then
                            .Cells(61, 23) = .Range("W61").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 22 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 24 Then
                            .Cells(63, 23) = .Range("W63").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        Else
                            .Cells(65, 23) = .Range("W65").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        End If
                    ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("GradeId") = 3 Then
                        If Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 2 Then
                            .Cells(41, 24) = .Range("X41").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 4 Then
                            .Cells(43, 24) = .Range("X43").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 6 Then
                            .Cells(45, 24) = .Range("X45").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 8 Then
                            .Cells(47, 24) = .Range("X47").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 10 Then
                            .Cells(49, 24) = .Range("X49").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 12 Then
                            .Cells(51, 24) = .Range("X51").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 14 Then
                            .Cells(53, 24) = .Range("X53").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 16 Then
                            .Cells(55, 24) = .Range("X55").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 16 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 18 Then
                            .Cells(57, 24) = .Range("X57").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 18 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 20 Then
                            .Cells(59, 24) = .Range("X59").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 20 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 22 Then
                            .Cells(61, 24) = .Range("X61").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 22 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 24 Then
                            .Cells(63, 24) = .Range("X63").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        Else
                            .Cells(65, 24) = .Range("X65").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        End If
                    ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("GradeId") = 2 Then
                        If Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 2 Then
                            .Cells(41, 25) = .Range("Y41").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 4 Then
                            .Cells(43, 25) = .Range("Y43").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 6 Then
                            .Cells(45, 25) = .Range("Y45").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 8 Then
                            .Cells(47, 25) = .Range("Y47").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 10 Then
                            .Cells(49, 25) = .Range("Y49").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 12 Then
                            .Cells(51, 25) = .Range("Y51").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 14 Then
                            .Cells(53, 25) = .Range("Y53").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 16 Then
                            .Cells(55, 25) = .Range("Y55").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 16 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 18 Then
                            .Cells(57, 25) = .Range("Y57").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 18 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 20 Then
                            .Cells(59, 25) = .Range("Y59").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 20 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 22 Then
                            .Cells(61, 25) = .Range("Y61").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 22 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 24 Then
                            .Cells(63, 25) = .Range("Y63").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        Else
                            .Cells(65, 25) = .Range("Y65").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        End If
                    Else 'I or A
                        If Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 2 Then
                            .Cells(41, 26) = .Range("Z41").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 2 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 4 Then
                            .Cells(43, 26) = .Range("Z43").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 4 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 6 Then
                            .Cells(45, 26) = .Range("Z45").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 6 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 8 Then
                            .Cells(47, 26) = .Range("Z47").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 8 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 10 Then
                            .Cells(49, 26) = .Range("Z49").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 10 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 12 Then
                            .Cells(51, 26) = .Range("Z51").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 12 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 14 Then
                            .Cells(53, 26) = .Range("Z53").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 14 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 16 Then
                            .Cells(55, 26) = .Range("Z55").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 16 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 18 Then
                            .Cells(57, 26) = .Range("Z57").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 18 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 20 Then
                            .Cells(59, 26) = .Range("Z59").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 20 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 22 Then
                            .Cells(61, 26) = .Range("Z61").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        ElseIf Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") >= 22 And Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("Duration") < 24 Then
                            .Cells(63, 26) = .Range("Z63").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        Else
                            .Cells(65, 26) = .Range("Z65").Value + Me.DSExcelEmpData.View_Emp_Data_Duration_GradeWise.Rows(i).Item("DurationCount")
                        End If
                    End If
                    Dim E1 As Char = "E"
                    Dim F As Char = "F"
                    Dim G1 As Char = "G"
                    Dim H As Char = "H"
                    Dim List As New ArrayList
                    List.Add("V")
                    List.Add("W")
                    List.Add("X")
                    List.Add("Y")
                    List.Add("Z")
                    For i11 As Integer = 0 To List.Count - 1
                        .Range(List.Item(i11) & "67" & "").Formula = "=Sum(" & List.Item(i11) & "41:" & List.Item(i11) & "65)"
                    Next
                    'V41+W41+X41+Y41+Z41
                    For i11 As Integer = 41 To 67 Step 2
                        Dim Value1 As String = "V" + i11.ToString + "+" + "W" + i11.ToString + "+" + "X" + i11.ToString + "+" + "Y" + i11.ToString + "+" + "Z" + i11.ToString
                        .Range("AA" & i11 & "").Formula = "=(" & Value1 & ")"
                    Next
                Next
            End With


            'End Put Here

            'Current Month Job Level
            ResetVlaues(210)
            Me.View_Excel_Emp_Job_Level11TableAdapter.Fill(Me.DSExcelEmpData.View_Excel_Emp_Job_Level11, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
            For i As Integer = 0 To Me.View_Excel_Emp_Job_Level11BindingSource.Count - 1
                If Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 5 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 4 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 3 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 1 Or Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 2 Then
                        TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    Else
                        TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    End If
                ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 5 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 4 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 3 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 1 Or Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("GradeId") = 2 Then
                        FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    Else
                        FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_Excel_Emp_Job_Level11.Rows(i).Item("Count1")
                    End If
                End If

                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G1 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 55 + 1
                While Count1 <= 59 + 1
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R61").Formula = "=Sum(R56:R60)"
                .Range("S61").Formula = "=Sum(S56:S60)"
                .Range("T61").Formula = "=Sum(T56:T60)"
                Count1 = 55 + 1
                While Count1 <= 59 + 1
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(61, 21) = "100%"
                Count1 = 55 + 1
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 59 + 1
                    Dim Value1 As String = "E" + Count1.ToString + "+" + "I" + Count1.ToString + "-" + "L" + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While
            Next

            'Current Month IN Job Level Analysis

            ResetVlaues(220)
            Me.View_Current_Month_JobLevelTableAdapter.Fill(Me.DSExcelEmpData.View_Current_Month_JobLevel, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            For i As Integer = 0 To Me.View_Current_Month_JobLevelBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 5 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 4 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 3 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 1 Or Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 2 Then
                        TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    Else
                        TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    End If
                ElseIf Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 5 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 4 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 3 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 1 Or Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("GradeId") = 2 Then
                        FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    Else
                        FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_Current_Month_JobLevel.Rows(i).Item("Count1")
                    End If
                End If
                .Cells(55 + 1, 9) = Age18
                .Cells(56 + 1, 9) = TotalAge
                .Cells(57 + 1, 9) = TotalAge1
                .Cells(58 + 1, 9) = TotalAge3
                .Cells(59 + 1, 9) = TotalAge4
                .Cells(55 + 1, 10) = FAge18
                .Cells(56 + 1, 10) = FTotalAge
                .Cells(57 + 1, 10) = FTotalAge1
                .Cells(58 + 1, 10) = FTotalAge3
                .Cells(59 + 1, 10) = FTotalAge4
                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                Dim Count1 As Integer = 55 + 1
                While Count1 <= 59 + 1
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I61").Formula = "=Sum(I56:I60)"
                .Range("J61").Formula = "=Sum(J56:J60)"
                .Range("K61").Formula = "=Sum(K56:K60)"
            Next

            'Current Month OUT Job Level Analysis

            ResetVlaues(230)
            Me.View_OUT_Month_JobLevel1TableAdapter.Fill(Me.DSExcelEmpData.View_OUT_Month_JobLevel1, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            For i As Integer = 0 To Me.View_OUT_Month_JobLevel1BindingSource.Count - 1
                If Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 5 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 4 Then
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 3 Then
                        TotalAge1 = TotalAge1 + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 1 Or Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 2 Then
                        TotalAge3 = TotalAge3 + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    Else
                        TotalAge4 = TotalAge4 + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    End If
                ElseIf Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 6 Or Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 5 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 4 Then
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 3 Then
                        FTotalAge1 = FTotalAge1 + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    ElseIf Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 1 Or Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("GradeId") = 2 Then
                        FTotalAge3 = FTotalAge3 + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    Else
                        FTotalAge4 = FTotalAge4 + Me.DSExcelEmpData.View_OUT_Month_JobLevel1.Rows(i).Item("Count1")
                    End If
                End If
                .Cells(55 + 1, 12) = Age18
                .Cells(56 + 1, 12) = TotalAge
                .Cells(57 + 1, 12) = TotalAge1
                .Cells(58 + 1, 12) = TotalAge3
                .Cells(59 + 1, 12) = TotalAge4
                .Cells(55 + 1, 13) = FAge18
                .Cells(56 + 1, 13) = FTotalAge
                .Cells(57 + 1, 13) = FTotalAge1
                .Cells(58 + 1, 13) = FTotalAge3
                .Cells(59 + 1, 13) = FTotalAge4
                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                Dim Count1 As Integer = 55 + 1
                While Count1 <= 59 + 1
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L61").Formula = "=Sum(L56:L60)"
                .Range("M61").Formula = "=Sum(M56:M60)"
                .Range("N61").Formula = "=Sum(N56:N60)"
            Next

            'Previous Month Dependents
            ResetVlaues(240)
            Dim TotalEmp As Integer = .Range("E27").Value
            Dim FTotalEmp As Integer = .Range("F27").Value
            If TotalEmp > 0 Then
                Age18 = Fix(TotalEmp / 2)
                TotalAge = Fix(Age18 / 2)
                TotalAge1 = Fix(TotalAge / 2)
                TotalAge2 = Fix(TotalAge1 / 2)
                TotalAge3 = Fix(TotalAge2 / 2)
                TotalAge4 = TotalEmp - (TotalAge + Age18 + TotalAge1 + TotalAge2 + TotalAge3)
                .Cells(29, 5) = Age18
                .Cells(30, 5) = TotalAge
                .Cells(31, 5) = TotalAge1
                .Cells(32, 5) = TotalAge2
                .Cells(33, 5) = TotalAge3
                .Cells(34, 5) = TotalAge4
                If FTotalEmp > 0 Then
                    FAge18 = Fix(FTotalEmp / 2)
                    FTotalAge = Fix(FAge18 / 2)
                    FTotalAge1 = Fix(FTotalAge / 2)
                    FTotalAge2 = Fix(FTotalAge1 / 2)
                    FTotalAge3 = Fix(FTotalAge2 / 2)
                    FTotalAge4 = FTotalEmp - (FTotalAge + FAge18 + FTotalAge1 + FTotalAge2 + FTotalAge3)
                    .Cells(29, 6) = FAge18
                    .Cells(30, 6) = FTotalAge
                    .Cells(31, 6) = FTotalAge1
                    .Cells(32, 6) = FTotalAge2
                    .Cells(33, 6) = FTotalAge3
                    .Cells(34, 6) = FTotalAge4
                End If
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 29
                While Count1 <= 34
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E35").Formula = "=Sum(E29:E34)"
                .Range("F35").Formula = "=Sum(F29:F34)"
                .Range("G35").Formula = "=Sum(G29:G34)"
                Count1 = 29
                While Count1 <= 34
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(35, 8) = "100%"
            End If
            'Previous Month Union Info
            ResetVlaues(250)
            'TotalEmp=
            If TotalEmp > 0 Then
                Age18 = Fix(TotalEmp / 1.4)
                TotalAge = TotalEmp - Age18
                TotalAge1 = 0
                TotalAge2 = 0
                .Cells(80, 5) = Age18
                .Cells(81, 5) = TotalAge
                .Cells(82, 5) = TotalAge1
                .Cells(83, 5) = TotalAge2
                If FTotalEmp > 0 Then
                    FAge18 = Fix(FTotalEmp / 1.4)
                    FTotalAge = FTotalEmp - FAge18
                    FTotalAge1 = 0
                    FTotalAge2 = 0
                    .Cells(80, 6) = FAge18
                    .Cells(81, 6) = FTotalAge
                    .Cells(82, 6) = FTotalAge1
                    .Cells(83, 6) = FTotalAge2
                End If
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 80
                While Count1 <= 83
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E84").Formula = "=Sum(E80:E83)"
                .Range("F84").Formula = "=Sum(F80:F83)"
                .Range("G84").Formula = "=Sum(G80:G83)"
                Count1 = 80
                While Count1 <= 83
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(84, 8) = "100%"
            End If
            'Current Month In Dependents Record
            ResetVlaues(260)
            TotalEmp = .Range("I27").Value
            FTotalEmp = .Range("J27").Value
            If TotalEmp > 0 Then
                Age18 = Fix(TotalEmp / 2)
                TotalAge = Fix(Age18 / 2)
                TotalAge1 = Fix(TotalAge / 2)
                TotalAge2 = Fix(TotalAge1 / 2)
                TotalAge3 = Fix(TotalAge2 / 2)
                TotalAge4 = TotalEmp - (TotalAge + Age18 + TotalAge1 + TotalAge2 + TotalAge3)
                If FTotalEmp > 0 Then
                    FAge18 = Fix(FTotalEmp / 2)
                    FTotalAge = Fix(FAge18 / 2)
                    FTotalAge1 = Fix(FTotalAge / 2)
                    FTotalAge2 = Fix(FTotalAge1 / 2)
                    FTotalAge3 = Fix(FTotalAge2 / 2)
                    FTotalAge4 = FTotalEmp - (FTotalAge + FAge18 + FTotalAge1 + FTotalAge2 + FTotalAge3)
                End If
                .Cells(29, 9) = Age18
                .Cells(30, 9) = TotalAge
                .Cells(31, 9) = TotalAge1
                .Cells(32, 9) = TotalAge2
                .Cells(33, 9) = TotalAge3
                .Cells(34, 9) = TotalAge4
                .Cells(29, 10) = FAge18
                .Cells(30, 10) = FTotalAge
                .Cells(31, 10) = FTotalAge1
                .Cells(32, 10) = FTotalAge2
                .Cells(33, 10) = FTotalAge3
                .Cells(34, 10) = FTotalAge4
                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                Dim Count1 As Integer = 29
                While Count1 <= 34
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I35").Formula = "=Sum(I29:I34)"
                .Range("J35").Formula = "=Sum(J29:J34)"
                .Range("K35").Formula = "=Sum(K29:K34)"
            End If
            'Current Month In Employee Union info
            ResetVlaues(270)
            If TotalEmp > 0 Then
                Age18 = Fix(TotalEmp / 1.4)
                TotalAge = TotalEmp - Age18
                TotalAge1 = 0
                TotalAge2 = 0
                If FTotalEmp > 0 Then
                    FAge18 = Fix(FTotalEmp / 1.4)
                    FTotalAge = FTotalEmp - FAge18
                    FTotalAge1 = 0
                    FTotalAge2 = 0
                End If
                .Cells(80, 9) = Age18
                .Cells(81, 9) = TotalAge
                .Cells(82, 9) = TotalAge1
                .Cells(83, 9) = TotalAge2
                .Cells(80, 10) = FAge18
                .Cells(81, 10) = FTotalAge
                .Cells(82, 10) = FTotalAge1
                .Cells(83, 10) = FTotalAge2

                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                Dim Count1 As Integer = 80
                While Count1 <= 83
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I84").Formula = "=Sum(I80:I83)"
                .Range("J84").Formula = "=Sum(J80:J83)"
                .Range("K84").Formula = "=Sum(K80:K83)"
            End If
            'Current Month In Employee Nationality Records

            ResetVlaues(280)
            If TotalEmp > 0 Then
                Age18 = TotalEmp
                TotalAge = 0
                If FTotalEmp > 0 Then
                    TotalAge1 = FTotalEmp
                    TotalAge2 = 0
                End If
                .Cells(87, 9) = Age18
                .Cells(88, 9) = TotalAge
                .Cells(87, 10) = TotalAge1
                .Cells(88, 10) = TotalAge2

                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                Dim Count1 As Integer = 87
                While Count1 <= 88
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I89").Formula = "=Sum(I87:I88)"
                .Range("J89").Formula = "=Sum(J87:J88)"
                .Range("K89").Formula = "=Sum(K87:K88)"
            End If

            'Current Month Out Dependents Record
            ResetVlaues(290)
            TotalEmp = .Range("L27").Value
            FTotalEmp = .Range("M27").Value
            If TotalEmp > 0 Then
                Age18 = Fix(TotalEmp / 2)
                TotalAge = Fix(Age18 / 2)
                TotalAge1 = Fix(TotalAge / 2)
                TotalAge2 = Fix(TotalAge1 / 2)
                TotalAge3 = Fix(TotalAge2 / 2)
                TotalAge4 = TotalEmp - (TotalAge + Age18 + TotalAge1 + TotalAge2 + TotalAge3)
                If FTotalEmp > 0 Then
                    FAge18 = Fix(FTotalEmp / 2)
                    FTotalAge = Fix(FAge18 / 2)
                    FTotalAge1 = Fix(FTotalAge / 2)
                    FTotalAge2 = Fix(FTotalAge1 / 2)
                    FTotalAge3 = Fix(FTotalAge2 / 2)
                    FTotalAge4 = FTotalEmp - (FTotalAge + FAge18 + FTotalAge1 + FTotalAge2 + FTotalAge3)
                End If
                .Cells(29, 12) = Age18
                .Cells(30, 12) = TotalAge
                .Cells(31, 12) = TotalAge1
                .Cells(32, 12) = TotalAge2
                .Cells(33, 12) = TotalAge3
                .Cells(34, 12) = TotalAge4
                .Cells(29, 13) = FAge18
                .Cells(30, 13) = FTotalAge
                .Cells(31, 13) = FTotalAge1
                .Cells(32, 13) = FTotalAge2
                .Cells(33, 13) = FTotalAge3
                .Cells(34, 13) = FTotalAge4
                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                Dim Count1 As Integer = 29
                While Count1 <= 34
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L35").Formula = "=Sum(L29:L34)"
                .Range("M35").Formula = "=Sum(M29:M34)"
                .Range("N35").Formula = "=Sum(N29:N34)"
            End If
            'Current Month Out Employee Union Records

            ResetVlaues(300)
            If TotalEmp > 0 Then
                Age18 = Fix(TotalEmp / 1.4)
                TotalAge = TotalEmp - Age18
                TotalAge1 = 0
                TotalAge2 = 0
                If FTotalEmp > 0 Then
                    FAge18 = Fix(FTotalEmp / 1.4)
                    FTotalAge = FTotalEmp - FAge18
                    FTotalAge1 = 0
                    FTotalAge2 = 0
                End If
                .Cells(80, 12) = Age18
                .Cells(81, 12) = TotalAge
                .Cells(82, 12) = TotalAge1
                .Cells(83, 12) = TotalAge2
                .Cells(80, 13) = FAge18
                .Cells(81, 13) = FTotalAge
                .Cells(82, 13) = FTotalAge1
                .Cells(83, 13) = FTotalAge2

                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                Dim Count1 As Integer = 80
                While Count1 <= 83
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L84").Formula = "=Sum(L80:L83)"
                .Range("M84").Formula = "=Sum(M80:M83)"
                .Range("N84").Formula = "=Sum(N80:N83)"
            End If

            'Current Month Out Employee Nationality Records

            ResetVlaues(310)
            If TotalEmp > 0 Then
                Age18 = TotalEmp
                TotalAge = 0
                If FTotalEmp > 0 Then
                    TotalAge1 = FTotalEmp
                    TotalAge2 = 0
                End If
                .Cells(87, 12) = Age18
                .Cells(88, 12) = TotalAge
                .Cells(87, 13) = TotalAge1
                .Cells(88, 13) = TotalAge2

                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                Dim Count1 As Integer = 87
                While Count1 <= 88
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L89").Formula = "=Sum(L87:L88)"
                .Range("M89").Formula = "=Sum(M87:M88)"
                .Range("N89").Formula = "=Sum(N87:N88)"
            End If

            'Current Month Dependents

            ResetVlaues(320)
            TotalEmp = .Range("R27").Value
            FTotalEmp = .Range("S27").Value
            If TotalEmp > 0 Then
                Age18 = Fix(TotalEmp / 2)
                TotalAge = Fix(Age18 / 2)
                TotalAge1 = Fix(TotalAge / 2)
                TotalAge2 = Fix(TotalAge1 / 2)
                TotalAge3 = Fix(TotalAge2 / 2)
                TotalAge4 = TotalEmp - (TotalAge + Age18 + TotalAge1 + TotalAge2 + TotalAge3)
                If FTotalEmp > 0 Then
                    FAge18 = Fix(FTotalEmp / 2)
                    FTotalAge = Fix(FAge18 / 2)
                    FTotalAge1 = Fix(FTotalAge / 2)
                    FTotalAge2 = Fix(FTotalAge1 / 2)
                    FTotalAge3 = Fix(FTotalAge2 / 2)
                    FTotalAge4 = FTotalEmp - (FTotalAge + FAge18 + FTotalAge1 + FTotalAge2 + FTotalAge3)
                End If
                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G1 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 29
                While Count1 <= 34
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R35").Formula = "=Sum(R29:R34)"
                .Range("S35").Formula = "=Sum(S29:S34)"
                .Range("T35").Formula = "=Sum(T29:T34)"
                Count1 = 29
                While Count1 <= 34
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(35, 21) = "100%"
                Count1 = 29
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 34
                    Dim Value1 As String = "E" + Count1.ToString + "+" + "I" + Count1.ToString + "-" + "L" + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While
            End If
            'Current Month Entered Employee Union info

            ResetVlaues(330)
            If TotalEmp > 0 Then
                Age18 = Fix(TotalEmp / 1.4)
                TotalAge = TotalEmp - Age18
                TotalAge1 = 0
                TotalAge2 = 0
                If FTotalEmp > 0 Then
                    FAge18 = Fix(FTotalEmp / 1.4)
                    FTotalAge = FTotalEmp - FAge18
                    FTotalAge1 = 0
                    FTotalAge2 = 0
                End If
                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G1 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 80
                While Count1 <= 83
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R84").Formula = "=Sum(R80:R83)"
                .Range("S84").Formula = "=Sum(S80:S83)"
                .Range("T84").Formula = "=Sum(T80:T83)"
                Count1 = 80
                While Count1 <= 83
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(84, 21) = "100%"
                Count1 = 80
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 83
                    Dim Value1 As String = "E" + Count1.ToString + "+" + "I" + Count1.ToString + "-" + "L" + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While
            End If
            'Current Month Entered Nationality info
            ResetVlaues(340)
            If TotalEmp > 0 Then
                TotalAge1 = TotalEmp
                TotalAge2 = 0
                If FTotalEmp > 0 Then
                    FTotalAge1 = FTotalEmp
                    FTotalAge2 = 0
                    .Cells(87, 19) = FTotalAge1
                    .Cells(88, 19) = FTotalAge2
                End If
                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G1 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 87
                While Count1 <= 88
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R89").Formula = "=Sum(R87:R88)"
                .Range("S89").Formula = "=Sum(S87:S88)"
                .Range("T89").Formula = "=Sum(T87:T88)"
                Count1 = 87
                While Count1 <= 88
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(89, 21) = "100%"
                Count1 = 87
                'Here is New Code
                '=E6+I6-L6
                '=F6+J6-M6
                While Count1 <= 88
                    Dim Value1 As String = "E" + Count1.ToString + "+" + "I" + Count1.ToString + "-" + "L" + Count1.ToString
                    Dim Value2 As String = "F" + Count1.ToString + "+" + "J" + Count1.ToString + "-" + "M" + Count1.ToString
                    .Range("R" & Count1 & "").Formula = "=" & Value1 & ""
                    .Range("S" & Count1 & "").Formula = "=" & Value2 & ""
                    Count1 = Count1 + 1
                End While
            End If


            'Union Change Catagory
            Dim Count4 As Integer = 80
            While Count4 <= 84
                .Cells(Count4, 15) = 0
                .Cells(Count4, 16) = 0
                .Cells(Count4, 17) = 0
                Count4 = Count4 + 1
            End While
            'Union Ratio Analysis
            V1 = "V"
            W = "W"
            X = "X"
            N = "N"
            T1 = "T"
            K = "K"
            G = "G"
            Count = 80
            'Dim SumValue As Integer
            While Count <= 84
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 80
            While Count <= 84
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While

            'Salary Analysis Ratio Analysis
            V1 = "V"
            W = "W"
            X = "X"
            N = "N"
            T1 = "T"
            K = "K"
            G = "G"
            Count = 64
            'Dim SumValue As Integer
            While Count <= 78
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 64
            While Count <= 78
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While

            'Job Level Analysis Ratio Analysis
            V1 = "V"
            W = "W"
            X = "X"
            N = "N"
            T1 = "T"
            K = "K"
            G = "G"
            Count = 55 + 1
            'Dim SumValue As Integer
            While Count <= 60 + 1
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 55 + 1
            While Count <= 60 + 1
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While

            'Employement Satatus Analysis Ratio Analysis
            V1 = "V"
            W = "W"
            X = "X"
            N = "N"
            T1 = "T"
            K = "K"
            G = "G"
            Count = 49
            'Dim SumValue As Integer
            While Count <= 54
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 49
            While Count <= 54
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While


            'Working Duration Employee Ration Analysis

            V1 = "V"
            W = "W"
            X = "X"
            N = "N"
            T1 = "T"
            K = "K"
            G = "G"
            Count = 37
            'Dim SumValue As Integer
            While Count <= 47
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 37
            While Count <= 47
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While


            'Dependents Change Catagory
            Count4 = 29
            While Count4 <= 35
                .Cells(Count4, 15) = 0
                .Cells(Count4, 16) = 0
                .Cells(Count4, 17) = 0
                Count4 = Count4 + 1
            End While

            'Nationality Change Catagory
            Count4 = 87
            While Count4 <= 89
                .Cells(Count4, 15) = 0
                .Cells(Count4, 16) = 0
                .Cells(Count4, 17) = 0
                Count4 = Count4 + 1
            End While

            'Dependent Ratio Analysis
            V1 = "V"
            W = "W"
            X = "X"
            N = "N"
            T1 = "T"
            K = "K"
            G = "G"
            Count = 29
            'Dim SumValue As Integer
            While Count <= 35
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 29
            While Count <= 35
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While

            'Previous Month Union Info
            ResetVlaues(350)
            'If TotalEmp > 0 Then
            '    Age18 = Fix(TotalEmp / 1.4)
            '    TotalAge = TotalEmp - Age18
            '    TotalAge1 = 0
            '    TotalAge2 = 0
            '    .Cells(80, 5) = Age18
            '    .Cells(81, 5) = TotalAge
            '    .Cells(82, 5) = TotalAge1
            '    .Cells(83, 5) = TotalAge2
            '    If FTotalEmp > 0 Then
            '        FAge18 = Fix(FTotalEmp / 1.4)
            '        FTotalAge = FTotalEmp - FAge18
            '        FTotalAge1 = 0
            '        FTotalAge2 = 0
            '        .Cells(80, 6) = FAge18
            '        .Cells(81, 6) = FTotalAge
            '        .Cells(82, 6) = FTotalAge1
            '        .Cells(83, 6) = FTotalAge2
            '    End If
            'Dim E1 As Char = "E"
            'Dim F As Char = "F"
            'Dim G1 As Char = "G"
            'Dim H As Char = "H"
            'Dim Count1 As Integer = 80
            'While Count1 <= 83
            '    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
            '    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
            '    Count1 = Count1 + 1
            'End While
            '.Range("E84").Formula = "=Sum(E80:E83)"
            '.Range("F84").Formula = "=Sum(F80:F83)"
            '.Range("G84").Formula = "=Sum(G80:G83)"
            'Count1 = 80
            'While Count1 <= 83
            '    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
            '    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
            '    .Range(H & Count1 & "").NumberFormat = "0%"
            '    Count1 = Count1 + 1
            'End While
            '.Cells(84, 8) = "100%"
            'End If



            'Previous Month Nationality Info

            ResetVlaues(360)
            TotalEmp = .Range("E27").Value
            FTotalEmp = .Range("F27").Value
            If TotalEmp > 0 Then
                TotalAge1 = TotalEmp
                TotalAge2 = 0
                .Cells(87, 5) = TotalAge1
                .Cells(88, 5) = TotalAge2
                If FTotalEmp > 0 Then
                    FTotalAge1 = FTotalEmp
                    FTotalAge2 = 0
                    .Cells(87, 6) = FTotalAge1
                    .Cells(88, 6) = FTotalAge2
                End If
                Dim E1 As Char = "E"
                Dim F As Char = "F"
                Dim G1 As Char = "G"
                Dim H As Char = "H"
                Dim Count1 As Integer = 87
                While Count1 <= 88
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("E89").Formula = "=Sum(E87:E88)"
                .Range("F89").Formula = "=Sum(F87:F88)"
                .Range("G89").Formula = "=Sum(G87:G88)"
                Count1 = 87
                While Count1 <= 88
                    Dim Value1 As String = G1 + Count1.ToString + "/" + G1 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(89, 8) = "100%"
            End If

            'Nationality Ratio Analysis
            V1 = "V"
            W = "W"
            X = "X"
            N = "N"
            T1 = "T"
            K = "K"
            G = "G"
            Count = 87
            'Dim SumValue As Integer
            While Count <= 89
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 87
            While Count <= 89
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While


            'In Month Age Records
            ResetVlaues(370)
            For i As Integer = 0 To Me.View_DOJ_Age1BindingSource.Count - 1
                If Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 20 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 25 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 30 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 35 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 40 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 45 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    Else
                        Age45 = Age45 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    End If
                ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 20 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 25 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 30 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 35 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 40 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("AgeGroup") < 45 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    Else
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Doj_Age1.Rows(i).Item("Age")
                    End If
                End If
                .Cells(5, 9) = 0
                .Cells(6, 9) = Age18
                .Cells(7, 9) = Age20
                .Cells(8, 9) = Age25
                .Cells(9, 9) = Age30
                .Cells(10, 9) = Age35
                .Cells(11, 9) = Age40
                .Cells(12, 9) = Age45
                .Cells(5, 10) = 0
                .Cells(6, 10) = FAge18
                .Cells(7, 10) = FAge20
                .Cells(8, 10) = FAge25
                .Cells(9, 10) = FAge30
                .Cells(10, 10) = FAge35
                .Cells(11, 10) = FAge40
                .Cells(12, 10) = FAge45
                Dim I11 As Char = "I"
                Dim J1 As Char = "J"
                Dim K1 As Char = "K"
                Dim Count1 As Integer = 5
                While Count1 <= 12
                    Dim Value1 As String = I11 + Count1.ToString + "," + J1 + Count1.ToString
                    .Range(K1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I13").Formula = "=Sum(I5:I12)"
                .Range("J13").Formula = "=Sum(J5:J12)"
                .Range("K13").Formula = "=Sum(K5:K12)"
            Next
            'In Current Month Education Records
            Try
                Me.View_Rpt_Current_Month_EducationTableAdapter.Fill(Me.DSExcelEmpData.View_Rpt_Current_Month_Education, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As Exception

            End Try

            ResetVlaues(380)
            For i As Integer = 0 To Me.View_Rpt_Current_Month_EducationBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "NO" Or Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Illiterate" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Primary" Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Middle" Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Matric Arts" Or Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Matric Science" Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "FA" Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "B.A" Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "ACCA" Or Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "CA" Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "NO" Or Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Illiterate" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Primary" Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Middle" Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Matric Arts" Or Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "Matric Science" Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "FA" Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "B.A" Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "ACCA" Or Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("Qualification") = "CA" Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Rpt_Current_Month_Education.Rows(i).Item("QualificationCount")
                    End If
                End If
                .Cells(15, 9) = Age18
                .Cells(16, 9) = Age20
                .Cells(17, 9) = Age25
                .Cells(18, 9) = Age30
                .Cells(19, 9) = Age35
                .Cells(20, 9) = Age40
                .Cells(21, 9) = TotalAge
                .Cells(22, 9) = Age45
                .Cells(15, 10) = FAge18
                .Cells(16, 10) = FAge20
                .Cells(17, 10) = FAge25
                .Cells(18, 10) = FAge30
                .Cells(19, 10) = FAge35
                .Cells(20, 10) = FAge40
                .Cells(21, 10) = FTotalAge
                .Cells(22, 10) = FAge45
                Dim E1 As Char = "I"
                Dim F As Char = "J"
                Dim G1 As Char = "K"
                Dim Count1 As Integer = 15
                While Count1 <= 22
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("I23").Formula = "=Sum(I15:I22)"
                .Range("J23").Formula = "=Sum(J15:J22)"
                .Range("K23").Formula = "=Sum(K15:K22)"
                Count1 = 15
            Next

            'Out In Current Month Education Records
            Try
                Me.View_Rpt_Out_Month_EducationTableAdapter.Fill(Me.DSExcelEmpData.View_Rpt_Out_Month_Education, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As Exception

            End Try

            ResetVlaues(390)
            For i As Integer = 0 To Me.View_Rpt_Out_Month_EducationBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "NO" Or Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Illiterate" Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Primary" Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Middle" Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Matric Arts" Or Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Matric Science" Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "FA" Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "B.A" Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "ACCA" Or Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "CA" Then
                        Age45 = Age45 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    Else
                        TotalAge = TotalAge + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    End If
                ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "NO" Or Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Illiterate" Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Primary" Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Middle" Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Matric Arts" Or Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "Matric Science" Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "FA" Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "B.A" Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "ACCA" Or Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("Qualification") = "CA" Then
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    Else
                        FTotalAge = FTotalAge + Me.DSExcelEmpData.View_Rpt_Out_Month_Education.Rows(i).Item("QualificationCount")
                    End If
                End If
                .Cells(15, 12) = Age18
                .Cells(16, 12) = Age20
                .Cells(17, 12) = Age25
                .Cells(18, 12) = Age30
                .Cells(19, 12) = Age35
                .Cells(20, 12) = Age40
                .Cells(21, 12) = TotalAge
                .Cells(22, 12) = Age45
                .Cells(15, 13) = FAge18
                .Cells(16, 13) = FAge20
                .Cells(17, 13) = FAge25
                .Cells(18, 13) = FAge30
                .Cells(19, 13) = FAge35
                .Cells(20, 13) = FAge40
                .Cells(21, 13) = FTotalAge
                .Cells(22, 13) = FAge45
                Dim E1 As Char = "L"
                Dim F As Char = "M"
                Dim G1 As Char = "N"
                Dim Count1 As Integer = 15
                While Count1 <= 22
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L23").Formula = "=Sum(L15:L22)"
                .Range("M23").Formula = "=Sum(M15:M22)"
                .Range("N23").Formula = "=Sum(N15:N22)"
                'Education Change Catagory

                Count1 = 15
                While Count1 <= 23
                    .Cells(Count1, 15) = 0
                    .Cells(Count1, 16) = 0
                    .Cells(Count1, 17) = 0
                    Count1 = Count1 + 1
                End While
            Next
            'ResetVlaues()
            'Change Catagory
            .Cells(5, 15) = 0
            .Cells(6, 15) = 0
            .Cells(7, 15) = 0
            .Cells(8, 15) = 0
            .Cells(9, 15) = 0
            .Cells(10, 15) = 0
            .Cells(11, 15) = 0
            .Cells(12, 15) = 0
            .Cells(5, 16) = 0
            .Cells(6, 16) = 0
            .Cells(7, 16) = 0
            .Cells(8, 16) = 0
            .Cells(9, 16) = 0
            .Cells(10, 16) = 0
            .Cells(11, 16) = 0
            .Cells(12, 16) = 0
            .Cells(5, 17) = 0
            .Cells(6, 17) = 0
            .Cells(7, 17) = 0
            .Cells(8, 17) = 0
            .Cells(9, 17) = 0
            .Cells(10, 17) = 0
            .Cells(11, 17) = 0
            .Cells(12, 17) = 0
            .Cells(13, 15) = 0
            .Cells(13, 16) = 0
            .Cells(13, 17) = 0
            'Out Month Age Records
            ResetVlaues(400)
            For i As Integer = 0 To Me.View_DOJ_Age11BindingSource.Count - 1
                If Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 20 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 25 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 30 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 35 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 40 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 45 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    Else
                        Age45 = Age45 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    End If
                ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 20 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 25 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 30 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 35 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 40 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("AgeGroup") < 45 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    Else
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_DOJ_Age11.Rows(i).Item("Age")
                    End If
                End If
                .Cells(5, 12) = 0
                .Cells(6, 12) = Age18
                .Cells(7, 12) = Age20
                .Cells(8, 12) = Age25
                .Cells(9, 12) = Age30
                .Cells(10, 12) = Age35
                .Cells(11, 12) = Age40
                .Cells(12, 12) = Age45
                .Cells(5, 13) = 0
                .Cells(6, 13) = FAge18
                .Cells(7, 13) = FAge20
                .Cells(8, 13) = FAge25
                .Cells(9, 13) = FAge30
                .Cells(10, 13) = FAge35
                .Cells(11, 13) = FAge40
                .Cells(12, 13) = FAge45
                Dim I11 As Char = "L"
                Dim J1 As Char = "M"
                Dim K1 As Char = "N"
                Dim Count1 As Integer = 5
                While Count1 <= 12
                    Dim Value1 As String = I11 + Count1.ToString + "," + J1 + Count1.ToString
                    .Range(K1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("L13").Formula = "=Sum(L5:L12)"
                .Range("M13").Formula = "=Sum(M5:M12)"
                .Range("N13").Formula = "=Sum(N5:N12)"
            Next
            'Current Month Records
            ResetVlaues(410)
            Try
                Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
            Catch ex As Exception
            End Try
            For i As Integer = 0 To Me.View_Rpt_Acc_AllEmployeesBindingSource.Count - 1
                If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Gender") = "Male" Then
                    If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 20 Then
                        Age18 = Age18 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 25 Then
                        Age20 = Age20 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 30 Then
                        Age25 = Age25 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 35 Then
                        Age30 = Age30 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 40 Then
                        Age35 = Age35 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 45 Then
                        Age40 = Age40 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    Else
                        Age45 = Age45 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    End If
                ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Gender") = "Female" Then
                    If Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 18 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 20 Then
                        FAge18 = FAge18 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 20 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 25 Then
                        FAge20 = FAge20 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 25 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 30 Then
                        FAge25 = FAge25 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 35 Then
                        FAge30 = FAge30 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 30 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 40 Then
                        FAge35 = FAge35 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    ElseIf Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") >= 40 And Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("AgeGroup") < 45 Then
                        FAge40 = FAge40 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    Else
                        FAge45 = FAge45 + Me.DSExcelEmpData.View_Rpt_Acc_AllEmployees.Rows(i).Item("Age")
                    End If
                End If
                Dim E1 As Char = "R"
                Dim F As Char = "S"
                Dim G2 As Char = "T"
                Dim H As Char = "U"
                Dim Count1 As Integer = 5
                While Count1 <= 12
                    Dim Value1 As String = E1 + Count1.ToString + "," + F + Count1.ToString
                    .Range(G2 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
                    Count1 = Count1 + 1
                End While
                .Range("R13").Formula = "=Sum(R5:R12)"
                .Range("S13").Formula = "=Sum(S5:S12)"
                .Range("T13").Formula = "=Sum(T5:T12)"
                Dim Value11 As Integer = .Range("R13").Value
                Dim Value12 As Integer = .Range("S13").Value
                Dim Value13 As Integer = .Range("T13").Value
                With xlWorkSheet1
                    .Cells(7, 5) = Value12
                    .Cells(5, 5) = Value11
                    '.Cells(3, 5) = Value13
                    '.Range("C11").Formula = "=Sum(C13:C39)"
                    '.Range("I11").Formula = "=Sum(I13:I39)"
                    '.Range("E3").Formula = "=Sum(E5:E7)"
                End With
                Count1 = 5
                While Count1 <= 12
                    Dim Value1 As String = G2 + Count1.ToString + "/" + G2 + "13"
                    .Range(H & Count1 & "").Formula = "=" & Value1 & ""
                    .Range(H & Count1 & "").NumberFormat = "0%"
                    Count1 = Count1 + 1
                End While
                .Cells(13, 21) = "100%"
            Next
            'Age Ratio Analysis
            V1 = "V"
            W = "W"
            X = "X"
            N = "N"
            T1 = "T"
            K = "K"
            G = "G"
            Count = 5
            'Dim SumValue As Integer
            While Count <= 13
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
            Count = 15
            While Count <= 23
                Dim Value1 As String = K + Count.ToString + "," + N + Count.ToString
                Dim Value2 As String = N + Count.ToString + "/" + T1 + Count.ToString + ""
                Dim Value3 As String = T1 + Count.ToString + "/" + G + Count.ToString + ""
                If .Range(T1 & Count & "").Value > 0 Then
                    .Range(V1 & Count & "").Formula = "=Sum(" & Value1 & ")/" + T1 + Count.ToString + ""
                    .Range(W & Count & "").Formula = "=" + Value2 + ""
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(V1 & Count & "").Value = 0
                    .Range(W & Count & "").Value = 0
                    .Range(V1 & Count & "").NumberFormat = "0.00%"
                    .Range(W & Count & "").NumberFormat = "0.00%"
                End If
                If .Range(G & Count & "").Value > 0 Then
                    .Range(X & Count & "").Formula = "=" + Value3 + ""
                    .Range(X & Count & "").NumberFormat = "0.00%"
                Else
                    .Range(X & Count & "").Value = 0
                    .Range(X & Count & "").NumberFormat = "0.00%"
                End If
                Count = Count + 1
            End While
        End With
        'HERE
        ResetVlaues(420)
        With xlWorkSheet
            .Cells(1, 5) = "FACTORY TURN OVER PROFILES"
            .Range("E1", "X1").HorizontalAlignment = 1
            .Range("E1", "X1").IndentLevel = 21
            .Range("E1", "X1").VerticalAlignment = 3
            .Range("E1", "X1").Font.Size = 18
            .Range("A1", "X131").Font.Name = "Arial Narrow"
            .Range("E1", "X1").Font.Bold = True
            .Range("B90", "D90").Merge()
            .Range("E1", "X1").Merge()
            .Range("E1", "X1").Merge()
            .Range("A1", "D1").Merge()
            .Range("B2", "X211").Font.Size = 10
            .Range("D49", "D77").Font.Size = 9
            .Range("D58", "D58").Font.Size = 8
            .Range("B2", "X2").Font.Name = "Arial Narrow"
            .Range("A1", "D1").Merge()
            .Range("B3", "H3").Font.Size = 10
            .Range("B3", "H3").Font.Name = "Arial Narrow"
            .Range("E3", "X3").HorizontalAlignment = 1
            .Range("B3", "X3").VerticalAlignment = 2
            .Range("E4", "X89").HorizontalAlignment = 3
            .Range("E4", "X89").VerticalAlignment = 2
            .Range("E3", "X3").IndentLevel = 8
            .Range("D3", "H3").Font.Bold = True
            .Range("E3", "X4").Font.Bold = True
            .Range("E62", "X63").Font.Bold = True
            .Range("E3", "H3").Merge()
            .Range("E62", "H62").Merge()
            .Range("I3", "K3").Merge()
            .Range("I62", "K62").Merge()
            .Range("L3", "N3").Merge()
            .Range("L62", "N62").Merge()
            .Range("O3", "Q3").Merge()
            .Range("O62", "Q62").Merge()
            .Range("R3", "U3").Merge()
            .Range("R62", "U62").Merge()
            .Range("V3", "X3").Merge()
            .Range("V62", "X62").Merge()
            .Range("B5", "B6").Merge()
            .Range("B15", "B16").Merge()
            .Range("B25", "B26").Merge()
            .Range("B29", "B29").Merge()
            .Range("B37", "B38").Merge()
            .Range("B49", "B50").Merge()
            .Range("B55", "B55").Merge()
            .Range("B64", "B65").Merge()
            .Range("B80", "B81").Merge()
            .Range("B87", "B88").Merge()

            .Range("B2").RowHeight = 20
            .Range("B3", "X3").RowHeight = 20
            .Range("B5", "D188").HorizontalAlignment = 3
            .Range("B5", "D188").VerticalAlignment = 4
            .Range("B5", "B188").Font.Bold = True
            .Range("B5", "B6").Interior.Color = RGB(255, 255, 153)
            .Range("B25", "D26").Interior.Color = RGB(255, 255, 153)
            .Range("B29").Interior.Color = RGB(255, 255, 153)
            .Range("B15", "B16").Interior.Color = RGB(255, 255, 153)
            .Range("B25", "B26").Interior.Color = RGB(255, 255, 153)
            .Range("B29").Interior.Color = RGB(255, 255, 153)
            .Range("B37", "B38").Interior.Color = RGB(255, 255, 153)
            .Range("B49", "B50").Interior.Color = RGB(255, 255, 153)
            .Range("C49", "D53").Interior.Color = RGB(255, 255, 153)
            .Range("B56").Interior.Color = RGB(255, 255, 153)
            .Range("B64", "B65").Interior.Color = RGB(255, 255, 153)
            .Range("B80", "B81").Interior.Color = RGB(255, 255, 153)
            .Range("B87", "B88").Interior.Color = RGB(255, 255, 153)
            .Range("C5", "D12").Interior.Color = RGB(255, 255, 153)
            .Range("C15", "D22").Interior.Color = RGB(255, 255, 153)
            .Range("C37", "D46").Interior.Color = RGB(255, 255, 153)
            .Range("C29", "D34").Interior.Color = RGB(255, 255, 153)
            .Range("I3", "N12").Interior.Color = RGB(204, 255, 204)
            .Range("O3", "Q12").Interior.Color = RGB(204, 255, 255)
            .Range("R3", "U12").Interior.Color = RGB(255, 255, 153)
            .Range("C56", "D60").Interior.Color = RGB(255, 255, 153)
            .Range("C64", "D77").Interior.Color = RGB(255, 255, 153)
            .Range("C80", "D83").Interior.Color = RGB(255, 255, 153)
            .Range("C87", "D88").Interior.Color = RGB(255, 255, 153)
            'GREEN
            .Range("I15", "N22").Interior.Color = RGB(204, 255, 204)
            .Range("I25", "N26").Interior.Color = RGB(204, 255, 204)
            .Range("I29", "N34").Interior.Color = RGB(204, 255, 204)
            .Range("I37", "N46").Interior.Color = RGB(204, 255, 204)
            .Range("I49", "N53").Interior.Color = RGB(204, 255, 204)
            .Range("I56", "N60").Interior.Color = RGB(204, 255, 204)
            .Range("I64", "N77").Interior.Color = RGB(204, 255, 204)
            .Range("I80", "N83").Interior.Color = RGB(204, 255, 204)
            .Range("I87", "N88").Interior.Color = RGB(204, 255, 204)
            'bLUE
            '.Range("O3", "Q12").Interior.Color = RGB(204, 255, 255)
            .Range("O15", "Q22").Interior.Color = RGB(204, 255, 255)
            .Range("O25", "Q26").Interior.Color = RGB(204, 255, 255)
            .Range("O29", "Q34").Interior.Color = RGB(204, 255, 255)
            .Range("O37", "Q46").Interior.Color = RGB(204, 255, 255)
            .Range("O49", "Q53").Interior.Color = RGB(204, 255, 255)
            .Range("O56", "Q60").Interior.Color = RGB(204, 255, 255)
            .Range("O64", "Q77").Interior.Color = RGB(204, 255, 255)
            .Range("O80", "Q83").Interior.Color = RGB(204, 255, 255)
            .Range("O87", "Q88").Interior.Color = RGB(204, 255, 255)

            'YELLOW
            .Range("R15", "U22").Interior.Color = RGB(255, 255, 153)
            .Range("R25", "U26").Interior.Color = RGB(255, 255, 153)
            .Range("R29", "U34").Interior.Color = RGB(255, 255, 153)
            .Range("R37", "U46").Interior.Color = RGB(255, 255, 153)
            .Range("R49", "U53").Interior.Color = RGB(255, 255, 153)
            .Range("R56", "U60").Interior.Color = RGB(255, 255, 153)
            .Range("R64", "U77").Interior.Color = RGB(255, 255, 153)
            .Range("R80", "U83").Interior.Color = RGB(255, 255, 153)
            .Range("R87", "U88").Interior.Color = RGB(255, 255, 153)
            'Grey
            .Range("E13", "X13").Interior.Color = RGB(192, 192, 192)
            .Range("E23", "X23").Interior.Color = RGB(192, 192, 192)
            .Range("E27", "X27").Interior.Color = RGB(192, 192, 192)
            .Range("E35", "X35").Interior.Color = RGB(192, 192, 192)
            .Range("E54", "X54").Interior.Color = RGB(192, 192, 192)
            .Range("E61", "X61").Interior.Color = RGB(192, 192, 192)
            .Range("E78", "X78").Interior.Color = RGB(192, 192, 192)
            .Range("E84", "X84").Interior.Color = RGB(192, 192, 192)
            .Range("E89", "X89").Interior.Color = RGB(192, 192, 192)
            .Range("E47", "X47").Interior.Color = RGB(192, 192, 192)
        End With
        With xlWorkSheet
            .Range("A2").ColumnWidth = 0.68
            .Range("C2").ColumnWidth = 2
            .Range("B2").ColumnWidth = 12.86
            .Range("B2").RowHeight = 12
            .Range("D2").ColumnWidth = 17
            .Range("D2").Interior.Color = RGB(255, 255, 0)
            .Range("D2").Font.Bold = True
            .Range("E2").ColumnWidth = 5.43
            .Range("F2").ColumnWidth = 5.57
            .Range("G2").ColumnWidth = 5.43
            .Range("H2").ColumnWidth = 10.14
            .Cells(2, 2) = "FACTORY"
            .Cells(2, 3) = ":"
            .Range("B90", "D90").Font.Size = 8
            .Range("B90", "D90").Font.Bold = False
            .Cells(90, 2) = "**Please indicate the majority of workers' place of origin  "
            .Cells(2, 4) = "Forward Sports"
            .Cells(3, 2) = "MONTH"
            .Cells(5, 2) = "1. AGE Range"
            .Cells(15, 2) = "2. EDUCATION LEVEL"
            .Cells(80, 2) = "9. UNION MEMBERSHIP"
            .Cells(56, 2) = "7. JOB LEVEL"
            .Cells(29, 2) = "4. DEPENDANTS"
            .Cells(37, 2) = "5. WORKING PERIODS"
            .Cells(49, 2) = "6. EMPLOYMENT STATUS"
            .Cells(64, 2) = "8. WORKERS TAKE HOME PAY"
            .Cells(87, 2) = "10.PLACE OF ORIGIN"
            .Cells(3, 3) = ":"
            .Cells(3, 4) = Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Cells(3, 5) = Me.DateTimePicker1.Value.AddMonths(-1).ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Cells(3, 9) = "IN (" & Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString & ")"
            .Cells(3, 12) = "OUT (" & Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString & ")"
            .Cells(3, 15) = "Change Category*"
            .Cells(3, 18) = Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Cells(3, 22) = "Ratio"
            .Cells(4, 5) = "Male"
            .Cells(4, 6) = "Female"
            .Cells(4, 7) = "Total"
            .Cells(4, 8) = "%"
            .Cells(4, 9) = "Male"
            .Cells(4, 10) = "Female"
            .Cells(4, 11) = "Total"
            .Cells(4, 12) = "Male"
            .Cells(4, 13) = "Female"
            .Cells(4, 14) = "Total"
            .Cells(4, 15) = "Male"
            .Cells(4, 16) = "Female"
            .Cells(4, 17) = "Total"
            .Cells(4, 18) = "Male"
            .Cells(4, 19) = "Female"
            .Cells(4, 20) = "Total"
            .Cells(4, 21) = "%"
            .Cells(4, 22) = "Retain"
            .Cells(4, 23) = "Turnover"
            .Cells(4, 24) = "Progress"
            .Cells(62, 5) = "Last Month"
            .Cells(62, 9) = "In"
            .Cells(62, 12) = "Out"
            '.Cells(3, 63) = "OUT (July 2014)"
            .Cells(62, 15) = "Change Category*"
            .Cells(62, 18) = "This Month"
            .Cells(62, 22) = "Ratio"
            .Cells(63, 5) = "Male"
            .Cells(63, 6) = "Female"
            .Cells(63, 7) = "Total"
            .Cells(63, 8) = "%"
            .Cells(63, 9) = "Male"
            .Cells(63, 10) = "Female"
            .Cells(63, 11) = "Total"
            .Cells(63, 12) = "Male"
            .Cells(63, 13) = "Female"
            .Cells(63, 14) = "Total"
            .Cells(63, 15) = "Male"
            .Cells(63, 16) = "Female"
            .Cells(63, 17) = "Total"
            .Cells(63, 18) = "Male"
            .Cells(63, 19) = "Female"
            .Cells(63, 20) = "Total"
            .Cells(63, 21) = "%"
            .Cells(63, 22) = "Retain"
            .Cells(63, 23) = "Turnover"
            .Cells(63, 24) = "Progress"
            '
            .Cells(5, 3) = "1"
            .Cells(5, 4) = "<18 years"
            .Cells(6, 3) = "2"
            .Cells(6, 4) = "18 - <20 years"
            .Cells(7, 3) = "3"
            .Cells(7, 4) = "20 - <25 years"
            .Cells(8, 3) = "4"
            .Cells(8, 4) = "25 - <30 years"
            .Cells(9, 3) = "5"
            .Cells(9, 4) = "30 - <35 years"
            .Cells(10, 3) = "6"
            .Cells(10, 4) = "35 - <40 years"
            .Cells(11, 3) = "7"
            .Cells(11, 4) = "40 - <45 years"
            .Cells(12, 3) = "8"
            .Cells(12, 4) = "45 - over"
            .Cells(29, 3) = "1"
            .Cells(29, 4) = "No Dependants (Single)"
            .Cells(30, 3) = "2"
            .Cells(30, 4) = "1 Dependants (Married, 0 Child)"
            .Cells(31, 3) = "3"
            .Cells(31, 4) = "2 Dependants (Married, 1 Child)"
            .Cells(32, 3) = "4"
            .Cells(32, 4) = "3 Dependants,(Married, 2 Children)"
            .Cells(33, 3) = "5"
            .Cells(33, 4) = "4 Dependants,(Married, 3 Children)"
            .Cells(34, 3) = "6"
            .Cells(34, 4) = "> Three Dependants"
            .Cells(13, 4) = "TOTAL"
            .Cells(23, 4) = "TOTAL"
            .Cells(27, 4) = "TOTAL"
            .Cells(47, 4) = "TOTAL"
            .Cells(54, 4) = "TOTAL"
            .Cells(61, 4) = "TOTAL"
            .Cells(64, 3) = "1"
            .Cells(64, 4) = "<15000"
            .Cells(65, 3) = "2"
            .Cells(65, 4) = "15000"
            .Cells(66, 3) = "3"
            .Cells(66, 4) = "15001 - 16000"
            .Cells(67, 3) = "4"
            .Cells(67, 4) = "16001 - 17000"
            .Cells(68, 3) = "5"
            .Cells(68, 4) = "17001 - 18000"
            .Cells(69, 3) = "6"
            .Cells(69, 4) = "18001 - 20000"
            .Cells(70, 3) = "7"
            .Cells(70, 4) = "20001 - 25000"
            .Cells(71, 3) = "8"
            .Cells(71, 4) = "25001 - 30000"
            .Cells(72, 3) = "9"
            .Cells(72, 4) = "30001 - 35000"
            .Cells(73, 3) = "10"
            .Cells(73, 4) = "35001 - 40000"
            .Cells(74, 3) = "11"
            .Cells(74, 4) = "40001 - 45000"
            .Cells(75, 3) = "12"
            .Cells(75, 4) = "45001 - 50000"
            .Cells(76, 3) = "13"
            .Cells(76, 4) = "50001 - 55000"
            .Cells(77, 3) = "14"
            .Cells(77, 4) = "55001 >"
            '
            .Cells(80, 3) = "1"
            .Cells(80, 4) = "Non Unionized"
            .Cells(81, 3) = "2"
            .Cells(81, 4) = "Union 1 (Employee Union)"
            .Cells(82, 3) = "3"
            .Cells(82, 4) = "Union 2 (fill in name of union 2)"
            .Cells(83, 3) = "4"
            .Cells(83, 4) = "Union 3 (fill in name of union 3)"
            '
            .Cells(87, 3) = "1"
            .Cells(87, 4) = "Local Nationality"
            .Cells(88, 3) = "2"
            .Cells(88, 4) = "Migrants / Expatriate"
            .Range("D27").Font.Bold = True
            .Range("D27").HorizontalAlignment = 4
            .Range("D27").VerticalAlignment = 2
            .Range("D47").Font.Bold = True
            .Range("D47").HorizontalAlignment = 4
            .Range("D47").VerticalAlignment = 2
            .Range("D54").Font.Bold = True
            .Range("D54").HorizontalAlignment = 4
            .Range("D54").VerticalAlignment = 2
            .Range("D61").Font.Bold = True
            .Range("D61").HorizontalAlignment = 4
            .Range("D61").VerticalAlignment = 2
            .Cells(35, 4) = "TOTAL"
            .Cells(78, 4) = "TOTAL"
            .Range("D78").Font.Bold = True
            .Range("D78").HorizontalAlignment = 4
            .Range("D78").VerticalAlignment = 2
            .Cells(84, 4) = "TOTAL"
            .Range("D84").Font.Bold = True
            .Range("D84").HorizontalAlignment = 4
            .Range("D84").VerticalAlignment = 2
            .Cells(89, 4) = "TOTAL"
            .Range("D89").Font.Bold = True
            .Range("D89").HorizontalAlignment = 4
            .Range("D89").VerticalAlignment = 2
            .Range("D35").Font.Bold = True
            .Range("D35").HorizontalAlignment = 4
            .Range("D35").VerticalAlignment = 2
            .Range("D13").Font.Bold = True
            .Range("D23").Font.Bold = True
            .Range("D23").HorizontalAlignment = 4
            .Range("D13").HorizontalAlignment = 4
            .Range("D23").VerticalAlignment = 2
            .Range("D3").HorizontalAlignment = 4
            .Range("D13").VerticalAlignment = 2

            Borders = .Range("C5", "X12").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C15", "X22").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C37", "X46").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C64", "X77").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C80", "X83").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C87", "X88").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("B37", "B38").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("B65", "B66").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("B56", "B56").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("B49", "B50").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E62", "X63").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C49", "X53").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E3", "X4").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("B5", "B6").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("B25", "B26").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C25", "X26").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C29", "X34").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("C56", "X60").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("B29").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("B15", "B16").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E47", "X47").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E13", "X13").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E23", "X23").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E27", "X27").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E35", "X35").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E54", "X54").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E61", "X61").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E78", "X78").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E84", "X84").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R
            Borders = .Range("E89", "X89").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 2.0R

            .Range("I4", "U12").ColumnWidth = 6.0
            .Range("V4", "X12").ColumnWidth = 9.0
            .Range("I4", "U12").ColumnWidth = 6.0
            .Range("E3", "X12").HorizontalAlignment = 3
            .Range("E3", "X12").VerticalAlignment = 2
            .Cells(15, 3) = "1"
            .Cells(15, 4) = "No Formal Schooling"
            .Cells(16, 3) = "2"
            .Cells(16, 4) = "Elementary"
            .Cells(17, 3) = "3"
            .Cells(17, 4) = "Junior High"
            .Cells(18, 3) = "4"
            .Cells(18, 4) = "High School"
            .Cells(19, 3) = "5"
            .Cells(19, 4) = "Diploma / Politechnic"
            .Cells(20, 3) = "6"
            .Cells(20, 4) = "Graduate School"
            .Cells(21, 3) = "7"
            .Cells(21, 4) = "Post Graduate"
            .Cells(22, 3) = "8"
            .Cells(22, 4) = "Doctoral / Post-Doc"
            .Cells(25, 3) = "1"
            .Cells(25, 4) = "Married"
            .Cells(26, 3) = "2"
            .Cells(26, 4) = "Single"
            .Cells(25, 2) = "3. MARITAL STATUS"
            .Cells(37, 3) = "1"
            .Cells(37, 4) = "< 1 year"
            .Cells(38, 3) = "2"
            .Cells(38, 4) = "1 - < 2 years"
            .Cells(39, 3) = "3"
            .Cells(39, 4) = "2 - < 4 years"
            .Cells(40, 3) = "4"
            .Cells(40, 4) = "4 - < 6 years"
            .Cells(41, 3) = "5"
            .Cells(41, 4) = "6 - < 8 years"
            .Cells(42, 3) = "6"
            .Cells(42, 4) = "8 - < 10 years"
            .Cells(43, 3) = "7"
            .Cells(43, 4) = "10 - < 12 years"
            .Cells(44, 3) = "8"
            .Cells(44, 4) = "12 - < 14 years"
            .Cells(45, 3) = "9"
            .Cells(45, 4) = "14 - < 16 years"
            .Cells(46, 3) = "10"
            .Cells(46, 4) = "16 years - > over"
            .Cells(49, 3) = "1"
            .Cells(49, 4) = "Piece Rate / Daily Workers"
            .Cells(50, 3) = "2"
            .Cells(50, 4) = "Trainee/Temporary/Contractual"
            .Cells(51, 3) = "3a"
            .Cells(51, 4) = "Probationary"
            .Cells(52, 3) = "3b"
            .Cells(52, 4) = "Permanent"
            .Cells(53, 3) = "3c"
            .Cells(53, 4) = "Trainee"
            .Cells(56, 3) = "1"
            .Cells(56, 4) = "Operators / Stitcher"
            .Cells(57, 3) = "2"
            .Cells(57, 4) = "Line Leader/Foreman/Staff"
            .Cells(58, 3) = "3"
            .Cells(58, 4) = "Supervisor/Sect. Head"
            .Cells(59, 3) = "4"
            .Cells(59, 4) = "Asst. Mgr/Fty Mgr/Manager"
            .Cells(60, 3) = "5"
            .Cells(60, 4) = "GM/Dir/Pres"
            Dim str As String = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "Data per Feb 29, 2008" & vbCrLf & "or per March 1, 2008"
            .Range("E3").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "Workers recruited from" & vbCrLf & "Mar 1 - Mar 31, 2008"
            .Range("I3").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "Exit workers / workers" & vbCrLf & "leaving factory (resigned," & vbCrLf & "terminated, etc) during" & vbCrLf & "Mar 1 -Mar 31, 2008"
            .Range("L3").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "addition (+) or reduction (-) of" & vbCrLf & "member in the given category. i.e. on" & vbCrLf & "March 20 worker A has her birthday" & vbCrLf & "---------------------------" & vbCrLf & "and turn to 25 years. Means less 1" & vbCrLf & "member of 20 - <25 category and" & vbCrLf & "add 1 member in 25 - <20 category."
            .Range("O3").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "Recap data per March" & vbCrLf & "31, 2008" & vbCrLf & "" & vbCrLf & "--------------------"
            .Range("R3").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "Ratio / Percentage of" & vbCrLf & "changes per March 28," & vbCrLf & "2008"
            .Range("W3").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "Ratio / percentage of" & vbCrLf & "workers retained"
            .Range("V4").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "Ratio / percentage of" & vbCrLf & "workers leaving (exit workers)"
            .Range("W4").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PREVIOUS MONTH" & vbCrLf & "Ratio / Percentage of" & vbCrLf & "Ratio / percentage of workforce growth"
            .Range("X4").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "under 18 years old"
            .Range("D5").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "exactly 18 years -" & vbCrLf & "19 years 11 months"
            .Range("D6").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "exactly 20 years - " & vbCrLf & "24 years 11 months"
            .Range("D7").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "exactly 25 years - " & vbCrLf & "29 years 11 months"
            .Range("D8").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "exactly 30 years - " & vbCrLf & "34 years 11 months"
            .Range("D9").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "exactly 35 years - " & vbCrLf & "39 years 11 months"
            .Range("D10").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "exactly 40 years - " & vbCrLf & "44 years 11 months"
            .Range("D11").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "exactly 45 years old -" & vbCrLf & " over 45 years..."
            .Range("D12").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "result MUST be = O"
            .Range("O13").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "result MUST be = O"
            .Range("P13").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "result MUST be = O"
            .Range("Q13").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "result must be the same" & vbCrLf & "in all category"
            .Range("V13").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "result must be the same" & vbCrLf & "in all category"
            .Range("W13").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "result must be the same" & vbCrLf & "in all category"
            .Range("X13").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Has never attend formal" & vbCrLf & "education / no legal certificate of" & vbCrLf & "school completion " & vbCrLf & "(tidak sekolah / tidak memiliki " & vbCrLf & "ijazah apapun)"
            .Range("D15").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Finished Primary schooling /" & vbCrLf & "Elementary (SD)"
            .Range("D16").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Compulsory (SMP) "
            .Range("D17").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Finished SMU "
            .Range("D18").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "D1 / D2 / D3 or  " & vbCrLf & "Politeknik"
            .Range("D19").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "University / Bachelor  " & vbCrLf & "Degree (S1)"
            .Range("D20").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Master Degree (S2)"
            .Range("D21").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Doctoral Degree (S3)" & vbCrLf & " or Post Doctoral"
            .Range("D22").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "in legal matrimony"
            .Range("D25").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Not married yet"
            .Range("D26").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Not married (no husband / wife / children)"
            .Range("D29").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Married with no children" & vbCrLf & "(dependant: 1 wife / husband)"
            .Range("D30").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Married with 1 child (dependant: 1" & vbCrLf & "husband/wife + 1 child)"
            .Range("D31").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Married with 2 children" & vbCrLf & "(husband/wife + 2 children)"
            .Range("D32").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Married with 3 children" & vbCrLf & "(dependant: 1 husband/wife + 3 children)"
            .Range("D33").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Married with more than 3 children" & vbCrLf & "(dependant: husband/wife + 4 " & vbCrLf & "or 5 or 6 or more children"
            .Range("D34").AddComment(str)
            'Here
            str = "AurieGlo:" & vbCrLf & "1 day - 11 months 29 days"
            .Range("D37").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 1 year - 1 year 11 months"
            .Range("D38").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 2 years - 3 years 11 months"
            .Range("D39").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 4 years - 5 years 11 months"
            .Range("D40").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 6 years - 7 years 11 months"
            .Range("D41").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 8 years - 9 years 11 months"
            .Range("D42").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 10 years - 11 years 11 months"
            .Range("D43").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 12 years - 13 years 11 months"
            .Range("D44").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 14 years - 15 years 11 months"
            .Range("D45").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Exactly 16 years - over..."
            .Range("D46").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Borongan / daily workers" & vbCrLf & " (harian)"
            .Range("D49").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PKWT (Agreement for a" & vbCrLf & " Specified Time Periof) / " & vbCrLf & "Contract workers"
            .Range("D50").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Workers on 3-months" & vbCrLf & " probation period before" & vbCrLf & " promoted to permanent"
            .Range("D51").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "PKWTT (Agreement for Non Specified" & vbCrLf & " Time Period); workers already" & vbCrLf & " promoted as permanent workers after" & vbCrLf & " passed 3 months probation period or" & vbCrLf & " temporary / contract workers who" & vbCrLf & " already been promoted to permanent"
            .Range("D52").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "No union exist/not" & vbCrLf & "a member of any union"
            .Range("D80").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Fill in name of Union 1 i.e." & vbCrLf & "  SPN / SPSI / ... "
            .Range("D81").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Fill in name of" & vbCrLf & "Union 2 (if there's any) i.e." & vbCrLf & " SPN / SPSI / SBGTS / SBSI / ..."
            .Range("D82").AddComment(str)
            str = "AurieGlo:" & vbCrLf & "Fill in name of" & vbCrLf & " union 3 (if there's any)"
            .Range("D83").AddComment(str)
            FormatAllComments()
            .Cells(5, 5).select()
            .Application.ActiveWindow.FreezePanes = True

            .Range("B5", "B6").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C5", "D12").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E3", "H13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I3", "K13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E5", "K12").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E13", "X13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("L3", "N13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L5", "N12").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L13", "N13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("O3", "Q13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O5", "Q12").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O13", "Q13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("R3", "U13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R5", "U12").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R13", "U13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("V3", "X13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V5", "X12").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V13", "X13").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)


            'Education
            .Range("B15", "B16").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C15", "D22").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E23", "X23").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E15", "H22").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I15", "K22").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L15", "N22").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O15", "Q22").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R15", "U22").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V15", "X22").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            'Marital Status

            .Range("B25", "B26").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C25", "D26").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E27", "X27").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E25", "H26").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I25", "K26").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L25", "N26").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O25", "Q26").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R25", "U26").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V25", "X26").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)


            ' DEPENDANTS

            .Range("B29", "B29").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C29", "D34").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E35", "X35").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E29", "H34").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I29", "K34").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L29", "N34").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O29", "Q34").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R29", "U34").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V29", "X34").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            ' Working Period

            .Range("B37", "B38").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C37", "D46").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E47", "X47").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E37", "H46").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I37", "K46").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L37", "N46").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O37", "Q46").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R37", "U46").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V37", "X46").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)


            ' Employment Status

            .Range("B49", "B50").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C49", "D53").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E54", "X54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E49", "H54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I49", "K54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L49", "N54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O49", "Q54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R49", "U54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V49", "X54").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)


            ' Job Level

            .Range("B56", "B56").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C56", "D60").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E61", "X61").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E56", "H61").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I56", "K61").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L56", "N61").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O56", "Q61").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R56", "U61").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V56", "X61").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            ' Works Take home Pay

            .Range("B64", "B65").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C64", "D76").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E78", "X78").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E64", "H78").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I64", "K78").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L64", "N78").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O64", "Q78").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R64", "U78").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V64", "X78").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            ' Union Membership

            .Range("B80", "B81").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C80", "D83").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E84", "X84").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E80", "H84").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I80", "K84").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L80", "N84").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O80", "Q84").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R80", "U84").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V80", "X84").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            'Place Of Origion

            .Range("B87", "B88").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("C87", "D88").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("E89", "X90").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)

            .Range("E87", "H89").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("I87", "K89").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("L87", "N89").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("O87", "Q89").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("R87", "U89").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("V87", "X89").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            For JJ As Integer = 5 To 88
                If JJ = 27 Then
                    JJ = 35
                End If
                If JJ > 60 And JJ < 78 Then
                    .Range("A" & JJ & "").RowHeight = 14.25
                Else
                    .Range("A" & JJ & "").RowHeight = 13.5
                End If

            Next
            'HEre
            'here
            Dim Count111 As Integer = 64
            Dim List As New ArrayList

            .Range("R78").Formula = "=Sum(R64:R77)"
            .Range("S78").Formula = "=Sum(S64:S77)"
            .Range("T78").Formula = "=Sum(T64:T77)"
            Dim TotalEmp11 As Integer = .Range("T78").Value
            Dim LstCount As Integer = 0
            'check Error

            Count111 = 64
            While Count111 <= 77
                Dim Value1 As String = "T" + Count111.ToString + "/" + "T" + "13"
                .Range("U" & Count111 & "").Formula = "=" & Value1 & ""
                .Range("U" & Count111 & "").NumberFormat = "0%"
                Count111 = Count111 + 1
            End While
            '.Cells(78, 21) = "100%"
            'Count111 = 64
            ''Here is New Code
            ''=E6+I6-L6
            ''=F6+J6-M6
            Count111 = 64
            While Count111 <= 77
                Dim Value1 As String = "E" + Count111.ToString + "+" + "I" + Count111.ToString + "-" + "L" + Count111.ToString
                Dim Value2 As String = "F" + Count111.ToString + "+" + "J" + Count111.ToString + "-" + "M" + Count111.ToString
                .Range("R" & Count111 & "").Formula = "=" & Value1 & ""
                .Range("S" & Count111 & "").Formula = "=" & Value2 & ""
                Count111 = Count111 + 1
            End While
            Count111 = 64
            While Count111 <= 77
                Dim Value1 As String = "R" + Count111.ToString + "," + "S" + Count111.ToString
                .Range("T" & Count111 & "").Formula = "=Sum(" & Value1 & ")"
                Dim Value11 As Integer = .Range("T" & Count111 & "").Value
                List.Add(Value11)
                Count111 = Count111 + 1
            End While
            Count111 = 64
            With xlWorkSheet1
                .Cells(11, 3) = TotalEmp11
                .Cells(11, 9) = TotalEmp11
                For Lst As Integer = 13 To 39 Step 2
                    Dim Value11 As Integer = List.Item(LstCount)
                    .Cells(Lst, 3) = List.Item(LstCount)
                    .Cells(Lst, 9) = List.Item(LstCount)
                    Dim Value1 As String = "C" + Lst.ToString + "/C11"
                    .Range("D" & Lst).Formula = "=" & Value1 & ""
                    .Range("D" & Lst).NumberFormat = "0%"
                    Value1 = "I" + Lst.ToString + "/I11"
                    .Range("H" & Lst).Formula = "=" & Value1 & ""
                    .Range("H" & Lst).NumberFormat = "0%"
                    LstCount = LstCount + 1
                Next
            End With
            With xlWorkSheet1
                '.Cells(7, 5) = Value11
                '.Cells(5, 5) = Value12
                '.Cells(3, 5) = Value13
                .Range("C11").Formula = "=Sum(C13:C39)"
                .Range("I11").Formula = "=Sum(I13:I39)"
                .Range("E3").Formula = "=Sum(E5:E7)"
            End With
            'End here

            'End Here
        End With
        ResetVlaues(430)
        xlWorkSheet.Name = "TurnOver"
        xlWorkSheet.Tab.Color = RGB(255, 255, 0)
        'xlWorkSheet.SaveAs(Path)
        ''xlWorkBook.Save()
        'xlWorkBook.Close()
        'xlApp.Quit()
        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)
        'Dim xlsApp As Excel.ApplicationClass
        'Dim xlsWB As Excel.WorkbookClass
        'xlsApp = New Excel.ApplicationClass
        'xlsApp.Visible = True
        'xlsWB = xlsApp.Workbooks.Open(Path)
    End Sub
    Private Sub LoadSheet2()
        xlWorkSheet = xlWorkBook.Sheets("sheet2")

        'xlWorkSheet = xlWorkBook.Sheets("sheet3")
        With xlWorkSheet
            .Cells(2, 4) = "REASON FOR LEAVING THE FACTORY"
            .Cells(5, 3) = "Reason"
            .Cells(5, 4) = "Voluntary"
            .Cells(5, 5) = "%"
            '
            .Cells(5, 8) = "Reason"
            .Cells(5, 9) = "Forced"
            .Cells(5, 10) = "%"
            '
            .Cells(6, 3) = "Pension"
            .Cells(7, 3) = "Death"
            .Cells(8, 3) = "Finished contract"
            .Cells(9, 3) = "Child / Familiy"
            '
            .Cells(6, 8) = "Criminal"
            .Cells(7, 8) = "Absent without any reason for" & vbCrLf & " 5 days in a row "
            .Cells(8, 8) = "Indisciplinary"
            .Cells(9, 8) = "Failed in training probation"
            '
            .Cells(10, 3) = "Returned to hometown"
            .Cells(11, 3) = "Get another job"
            .Cells(12, 3) = "Health"
            .Cells(13, 3) = "Continue education"
            .Cells(14, 3) = "Marriage"
            .Cells(15, 3) = "Pregnancy"
            .Cells(16, 3) = "Rest"
            .Cells(17, 3) = "TOTAL"
            .Cells(17, 8) = "TOTAL"
            .Cells(19, 8) = "GRAND TOTAL"
            .Cells(21, 2) = "Note:"
            .Cells(23, 2) = "1. Total Employee (Permanent & Temporary)"
            .Cells(26, 2) = "2. Probationary Period"
            .Cells(29, 2) = "3. Permanent Employee"
            .Cells(32, 2) = "4. Temporary / Contractual Employee"
            .Cells(35, 3) = "Perhitungan Persentase  = Jumlah karyawan out / Total Employee * 100"

            .Range("A1", "X131").Font.Name = "Century Gothic"
            .Range("B2", "J2").Merge()
            Dim I1 As Integer = 23
            Dim G1 As Char = "B"
            Dim H1 As Char = "C"
            While I1 <= 32
                .Range(G1 & I1 & "", H1 & I1 & "").Merge()
                .Range(G1 & I1 & "", H1 & I1 & "").Font.Bold = True
                I1 = I1 + 3
            End While
            .Range("B4", "C4").Merge()
            .Range("B2", "J2").Font.Bold = True
            .Range("H17").Font.Bold = True
            .Range("H19").Font.Bold = True
            .Range("H17", "H19").HorizontalAlignment = 4
            .Range("B2", "J2").Font.Size = 12
            .Range("B4", "K52").Font.Size = 10
            .Range("C1").ColumnWidth = 34.71
            .Range("I1").ColumnWidth = 11.29
            .Range("H1").ColumnWidth = 34.71
            .Range("B7").RowHeight = 30.5
            .Range("D1").ColumnWidth = 11.29
            .Range("B1").ColumnWidth = 5.86
            .Range("A1").ColumnWidth = 1.71
            .Range("B2", "J2").HorizontalAlignment = 3
            .Range("C17").HorizontalAlignment = 4
            .Range("C5", "J5").HorizontalAlignment = 3
            .Range("C5", "D5").Font.Bold = True
            .Range("H5", "I5").Font.Bold = True
            .Range("D23", "H33").Font.Bold = True
            .Range("B6", "B16").HorizontalAlignment = 3
            .Range("B2", "J2").VerticalAlignment = 3
            .Range("B4").Font.Bold = True
            .Range("C17").Font.Bold = True
            .Range("C35").Font.Bold = True
            .Range("C35").Font.Size = 12
            .Range("D5", "D33").HorizontalAlignment = 3
            G1 = "F"
            H1 = "G"
            Borders = .Range("D17", "E17").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 3.0R
            Borders = .Range("I17", "J17").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 3.0R
            Borders = .Range("H19", "J19").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 3.0R
            Borders = .Range("B6", "B16").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 3.0R
            For T As Integer = 23 To 33
                If T = 25 Or T = 28 Or T = 31 Then
                ElseIf T = 24 Or T = 27 Or T = 30 Or T = 33 Then
                    .Cells(T, 6) = "person (Out )"
                    .Range(G1 & T & "", H1 & T & "").Merge()
                    .Cells(T, 4) = ":"
                Else
                    .Cells(T, 4) = ":"
                End If
            Next
            .Cells(4, 2) = "Month     :" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            'Borders = .Range("C5", "E16").Borders
            For B As Integer = 3 To 10
                If B = 6 Or B = 7 Then
                Else
                    Borders = .Cells(5, B).borders
                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    Borders.Weight = 3.0R
                End If
            Next
            For i As Integer = 6 To 16
                For j As Integer = 3 To 5
                    Borders = .Cells(i, j).borders
                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    Borders.Weight = 2.0R
                Next
            Next
            For i As Integer = 6 To 16
                For j As Integer = 7 To 10
                    Borders = .Cells(i, j).borders
                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    Borders.Weight = 2.0R
                Next
            Next
            G1 = "G"
            For i As Integer = 1 To 15
                If i > 11 Then
                    .Cells(i - 6, 7) = i
                    .Range(G1 & i - 6 & "").HorizontalAlignment = 3
                Else
                    .Cells(i + 5, 2) = i
                End If
            Next
            Borders = .Range("G6", "G16").Borders
            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
            Borders.Weight = 3.0R
            .Range("B2", "K36").BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
            .Range("H6").Copy()

        End With
        xlWorkSheet.Name = "Reason for Leaving"
        xlWorkSheet.Tab.Color = RGB(255, 0, 0)
        'xlWorkBook.Sheets(2).name = ""
    End Sub
    Private Sub LoadSheet3()
        xlWorkSheet = xlWorkBook.Sheets("sheet3")
        With xlWorkSheet
            .Range("A2").PasteSpecial()
            .Range("A1", "AI100").Interior.Color = RGB(255, 255, 255)
            .Range("A1", "AI100").Font.Size = 10
            .Range("A1", "AI100").Font.Name = "Palatino"
            .Range("C1", "E1").Font.Bold = True
            .Range("A1").ColumnWidth = 0
            .Range("B1").ColumnWidth = 1.71
            .Range("C1").ColumnWidth = 9.14
            .Range("D1").ColumnWidth = 7.0
            .Range("E1").ColumnWidth = 9.0
            .Range("F1").ColumnWidth = 1.0
            .Range("K1").ColumnWidth = 11.0
            .Range("L1").ColumnWidth = 12.14
            .Range("G1").ColumnWidth = 6.57
            .Range("M1").ColumnWidth = 16.29
            .Range("N1", "O1").ColumnWidth = 0.92
            .Range("V1", "Z1").ColumnWidth = 8.0
            .Range("P1").ColumnWidth = 12.29
            .Range("AA1").ColumnWidth = 11.57
            .Range("AB1", "AE1").ColumnWidth = 0
            .Range("AF1", "AH1").ColumnWidth = 16.29
            .Range("Q1").ColumnWidth = 0.92
            .Range("R1").ColumnWidth = 0.58
            .Range("S1").ColumnWidth = 6.14
            .Range("T1").ColumnWidth = 10.43
            .Range("U1").ColumnWidth = 1.0
            .Range("H1").ColumnWidth = 7.0
            .Range("I1").ColumnWidth = 7.29
            .Range("J1").ColumnWidth = 5.86
            .Range("D1", "E1").Merge()
            .Range("D43", "E44").Merge()
            .Range("D68", "I68").Merge()
            .Range("G43", "H44").Merge()
            .Cells(43, 4) = "Male:"
            .Cells(5, 16) = "Cash"
            .Cells(9, 16) = "Non-Cash"
            .Cells(11, 16) = "Non-Cash"
            .Cells(23, 16) = "All Departments"
            .Cells(31, 16) = "3rd shift"
            .Cells(43, 16) = "5% of Year End Bonus"
            .Range("P23", "P32").Font.Size = 8
            .Range("P43", "P44").Font.Size = 7
            .Cells(43, 7) = "Female:"
            .Cells(45, 1) = "Age"
            .Cells(45, 4) = "Single"
            .Cells(45, 5) = "Married"
            .Cells(45, 7) = "Single"
            .Cells(45, 8) = "Married"
            .Cells(45, 9) = "%Married"
            .Cells(1, 3) = "FACTORY:"
            .Cells(3, 3) = "Total:"
            .Cells(5, 3) = "Male:"
            .Cells(7, 3) = "Female:"
            .Cells(1, 4) = "FORWARD SPORTS"
            .Cells(1, 11) = "MONTH:"
            .Cells(5, 12) = "Transportation"
            .Cells(7, 12) = "Meals"
            .Cells(9, 12) = "Over time snack"

            .Cells(3, 22) = "Zero"
            .Cells(3, 23) = "One"
            .Cells(3, 24) = "Two"
            .Cells(3, 25) = "Three"
            .Cells(3, 26) = ">Three"
            .Cells(3, 27) = "TOTAL"
            '
            .Cells(39, 22) = "Operator"
            .Cells(39, 23) = "Leader/Staff"
            .Cells(39, 24) = "Supervisor"
            .Cells(39, 25) = "Ass/Mgt/Dir"
            .Cells(39, 26) = "GM/Dir/Pres"
            .Cells(39, 27) = "TOTAL"
            '
            .Range("K11", "L11").Merge()
            .Cells(11, 11) = "Extra Fooding ( milk)"
            .Cells(13, 11) = "Jamsostek"
            .Cells(1, 12) = Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            .Cells(69, 3) = "*Note : "
            .Cells(69, 4) = "Per " + Me.DateTimePicker1.Text + ",  Province Minimum Salary is      15000"
            .Range("B2").RowHeight = 12.75
            .Range("B68").RowHeight = 3
            .Range("B4").RowHeight = 5.25
            .Range("B6").RowHeight = 5.25
            .Range("B8").RowHeight = 5.25
            .Range("L9").Font.Size = 8
            .Range("K37").Font.Size = 7

            .Range("C3", "C7").HorizontalAlignment = 4
            .Range("E3", "G7").HorizontalAlignment = 3
            .Range("D49", "I67").HorizontalAlignment = 3
            .Range("K1").HorizontalAlignment = 4
            .Range("L1").HorizontalAlignment = 2
            .Range("K1", "L1").Font.Bold = True
            .Range("K23", "L67").HorizontalAlignment = 4
            .Range("V3", "AA3").HorizontalAlignment = 3
            .Range("V39", "AA39").HorizontalAlignment = 3
            .Range("S5", "T67").HorizontalAlignment = 3
            .Range("T41", "T67").Font.Name = "Century Gothic"
            .Range("V39", "AA39").Font.Size = 8
            .Range("C11", "I41").HorizontalAlignment = 3
            .Range("M23", "M67").HorizontalAlignment = 3
            .Range("M5", "P13").HorizontalAlignment = 3
            .Range("L13").HorizontalAlignment = 4
            .Range("K5", "L11").HorizontalAlignment = 4
            .Range("K13").HorizontalAlignment = 4
            .Range("D43", "I45").HorizontalAlignment = 3
            .Range("D43", "H44").Font.Bold = True
            .Range("B49", "C67").HorizontalAlignment = 2
            Dim list As New ArrayList
            list.Add("Total")
            list.Add("<15000")
            list.Add("15000-16000")
            list.Add("16001-17000")
            list.Add("17001-18000")
            list.Add("18001-20000")
            list.Add("20001-25000")
            list.Add("25001-30000")
            list.Add("30001-35000")
            list.Add("35001-40000")
            list.Add("40001-45000")
            list.Add("45001-50000")
            list.Add("50001-55000")
            list.Add(">55000")
            Dim list1 As New ArrayList
            list1.Add("18 - <20")
            list1.Add("20 - <22")
            list1.Add("22 - <25")
            list1.Add("25 - <30")
            list1.Add("30 - <35")
            list1.Add("35 - <40")
            list1.Add("40 - <42")
            list1.Add("42 - <45")
            list1.Add("45 - over")
            list1.Add("Total Age")
            For j As Integer = 5 To 7 Step 2
                For i1 As Integer = 3 To 7 Step 2
                    Borders = .Cells(i1, j).borders
                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    Borders.Weight = 2.0R
                Next
            Next
            Dim B As Char = "B"
            Dim C As Char = "C"
            Dim D As Char = "D"
            Dim H As Char = "H"
            Dim I As Char = "I"
            Dim G As Char = "G"
            Dim E As Char = "E"
            Dim Count As Integer = 0
            Dim Count1 As Integer = 0
            For L As Integer = 11 To 67 Step 2
                If L <= 41 Then
                    .Range(E & L & "", G & L & "").Merge()
                    Try
                        .Cells(L, 5) = list.Item(Count)
                    Catch ex As Exception
                    End Try
                    Borders = .Range(C & L & "", D & L & "").Borders
                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    Borders.Weight = 2.0R
                    Borders = .Range(H & L & "", I & L & "").Borders
                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    Borders.Weight = 2.0R
                    Count = Count + 1
                ElseIf L >= 49 Then
                    Try
                        .Cells(L, 2) = list1.Item(Count1)
                    Catch ex As Exception
                    End Try
                    Borders = .Range(D & L & "", E & L & "").Borders
                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    Borders.Weight = 2.0R
                    Borders = .Range(G & L & "", I & L & "").Borders
                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                    Borders.Weight = 2.0R
                    Count1 = Count1 + 1
                ElseIf L > 44 Then
                    .Range(B & L & "", C & L & "").Merge()
                End If
            Next
            list1.Clear()
            list1.Add("Productivity Bonus")
            list1.Add("Press Allowance")
            list1.Add("Rolling Allowance")
            list1.Add("Monthly Shift Allowance")
            list1.Add("Daily Shift Allowance")
            list1.Add("Other Allowances")
            list1.Add("Congratulatory Gift /Worker's 1st marriage")
            list1.Add("Death (workers family)")
            list1.Add("Death (worker)")
            list1.Add("Idul Fitri tax")
            '
            list1.Add("Personal Income Tax")
            list1.Add("Rank Allowance")
            list1.Add("Functional Allowance")
            list1.Add("Attendance Bonus")
            list1.Add("Menstruation Premium")
            '
            list1.Add("Jamsostek")
            list1.Add("Pension")
            list1.Add("Income tax")
            list1.Add("Labor Union")
            list1.Add("Koperasi (the ec")
            'list1.Add("Koperasi (the economic enterprise)")
            list1.Add("Other Deduction")

            Count1 = 0
            Count = 1
            list.Add("")
            list.Add("TOTAL")
            list.Add("< 2 years")
            list.Add("2 - <4")
            list.Add("4 - <6")
            list.Add("6 - <8")
            list.Add("8 - <10")
            list.Add("10 - <12")
            list.Add("12 - <14")
            list.Add("14 - <16")
            list.Add("16 - <18")
            list.Add("18 - <20")
            list.Add("20 - <22")
            list.Add("22 - <24")
            list.Add("24<")
            list.Add("TOTAL")
            Dim M As Char = "M"
            Dim P1 As Char = "P"
            Dim L1 As Char = "L"
            Dim K2 As Char = "K"
            Dim V As Char = "V"
            Dim AA As Char = "AA"
            For j As Integer = 1 To 2
                For i1 As Integer = 5 To 67 Step 2
                    If j = 1 Then
                        If i1 <= 35 Then
                            .Range("S" & i1 & "", "U" & i1 & "").Merge()
                            Try
                                .Cells(i1, 19) = list.Item(Count)
                            Catch ex As Exception
                            End Try
                            Count = Count + 1
                            Borders = .Range(V & i1 & "", "AA" & i1 & "").Borders
                            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            Borders.Weight = 2.0R
                        ElseIf i1 >= 41 Then
                            Try
                                .Cells(i1, 20) = list.Item(Count)
                            Catch ex As Exception
                            End Try
                            Count = Count + 1
                            Borders = .Range(V & i1 & "", "AA" & i1 & "").Borders
                            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            Borders.Weight = 2.0R
                        End If
                        If i1 = 13 Then
                            Borders = .Range(L1 & i1 & "", M & i1 & "").Borders
                            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            Borders.Weight = 2.0R
                        Else
                            If i1 >= 5 And i1 <= 13 Then

                                Borders = .Range(M & i1 & "").Borders
                                Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                Borders.Weight = 2.0R
                            ElseIf i1 >= 23 And i1 <= 33 Then
                                .Range(K2 & i1 & "", L1 & i1 & "").Merge()
                                Try
                                    .Cells(i1, 11) = list1.Item(Count1)
                                Catch ex As Exception
                                End Try
                                Count1 = Count1 + 1
                                Borders = .Range(M & i1 & "").Borders
                                Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                Borders.Weight = 2.0R
                            ElseIf i1 >= 37 And i1 <= 53 Then
                                .Range(K2 & i1 & "", L1 & i1 & "").Merge()
                                Try
                                    .Cells(i1, 11) = list1.Item(Count1)
                                Catch ex As Exception
                                End Try
                                Count1 = Count1 + 1
                                Borders = .Range(M & i1 & "").Borders
                                Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                Borders.Weight = 2.0R
                            ElseIf i1 >= 57 And i1 <= 67 Then
                                If i1 <= 63 Then
                                    Try
                                        .Cells(i1, 11) = list1.Item(Count1)
                                    Catch ex As Exception
                                    End Try
                                    Count1 = Count1 + 1
                                Else
                                    Try
                                        .Cells(i1, 12) = list1.Item(Count1)
                                    Catch ex As Exception
                                    End Try
                                    Count1 = Count1 + 1
                                End If
                                '.Range(K2 & i1 & "", L1 & i1 & "").Merge()
                                If i1 > 65 Then
                                    Borders = .Range(M & i1 & "").Borders
                                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                    Borders.Weight = 2.0R
                                Else
                                    Borders = .Range(L1 & i1 & "", M & i1 & "").Borders
                                    Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                                    Borders.Weight = 2.0R
                                End If

                            End If

                        End If

                    Else
                        If i1 > 13 Then
                            Exit For
                        Else
                            Borders = .Range(P1 & i1 & "").Borders
                            Borders.LineStyle = Excel.XlLineStyle.xlContinuous
                            Borders.Weight = 2.0R
                        End If

                    End If

                Next
            Next

            C = "B"
            For L As Integer = 10 To 66 Step 2
                If L <= 40 Then
                    .Range(C & L & "").RowHeight = 5.25
                ElseIf L >= 44 Then
                    .Range(C & L & "").RowHeight = 5.25
                End If
            Next
            Dim Value1 As String = "E5/E3"
            .Range("G5").Formula = "=" & Value1 & ""
            .Range("G5").NumberFormat = "0%"
            Value1 = "E7/E3"
            .Range("G7").Formula = "=" & Value1 & ""
            .Range("G7").NumberFormat = "0%"

            Value1 = "E3/E3"
            .Range("G3").Formula = "=" & Value1 & ""
            .Range("G3").NumberFormat = "0%"

            Value1 = "C11/C11"
            .Range("D11").Formula = "=" & Value1 & ""
            .Range("D11").NumberFormat = "0%"

            Value1 = "I11/I11"
            .Range("H11").Formula = "=" & Value1 & ""
            .Range("H11").NumberFormat = "0%"
            '.Cells.Grouprows()
            'Put Sum Formula
            '=(E49+H49)/(D49+E49+G49+H49)
            '.Range(G1 & Count1 & "").Formula = "=Sum(" & Value1 & ")"
            Count1 = 49
            Dim Value2 As String
            While Count1 <= 67
                Value1 = "E" + Count1.ToString + "+" + "H" + Count1.ToString
                Value2 = "D" + Count1.ToString + "+" + "E" + Count1.ToString + "+" + "G" + Count1.ToString + "+" + "H" + Count1.ToString
                .Range("I" & Count1 & "").Formula = "=(" & Value1 & ")/(" & Value2 & ")"
                .Range("I" & Count1 & "").NumberFormat = "0%"
                Count1 = Count1 + 2
            End While
            .Range("D67").Formula = "=Sum(D49:D65)"
            .Range("E67").Formula = "=Sum(E49:E65)"
            .Range("G67").Formula = "=Sum(G49:G65)"
            .Range("H67").Formula = "=Sum(H49:H65)"
            .Range("M7").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("TotalMealAllowance")
            .Range("M33").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("SpecialAllowance")
            .Range("M45").Value = Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays.Rows(0).Item("Tax")
        End With
        xlWorkSheet.Name = "Wage"
        xlWorkSheet.Tab.Color = RGB(0, 255, 0)
        'Data()
    End Sub
    Private Sub Data()
        Dim xlApp As New Excel.Application
        Dim xlBook As Excel.Workbook = xlApp.Workbooks.Add
        Dim xlSheet As Excel.Worksheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
        Dim xlShape As Excel.Shape

        With xlSheet.Range("K21")
            xlShape = xlSheet.Shapes.AddShape(Microsoft.Office.Core.MsoAutoShapeType.msoShapeRectangle, CSng(.Left), CSng(.Top), CSng(.Width), CSng(.Height))
        End With

        With xlShape
            '.ShapeStyle = Microsoft.Office.Core.MsoShapeStyleIndex.msoLineStylePreset10
            'Add additional code to modify the added shape
        End With

        With xlApp
            .UserControl = True
            .Visible = True
        End With
    End Sub
    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If RadioButton1.Checked Then
            LoadSheet1Records()
            LoadSheet2()
            LoadSheet3()
        ElseIf RadioButton2.Checked Then
            LoadWorkingHoursData()
            OTHoursData()
        ElseIf RadioButton3.Checked Then
            LoadWorkingHoursData1()
            OTHoursData1()
        End If
        xlWorkSheet.SaveAs(Path)
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        Dim xlsApp As Excel.ApplicationClass
        Dim xlsWB As Excel.WorkbookClass
        xlsApp = New Excel.ApplicationClass
        xlsApp.Visible = True
        xlsWB = xlsApp.Workbooks.Open(Path)
    End Sub
    Sub FormatAllComments()
        'www.contextures.com/xlcomments03.html
        'www.contextures.com/xlcomments03.html
        Dim ws As Excel.Worksheet
        Dim cmt As Excel.Comment
        'Dim MyGB As Microsoft.Office.Interop.Excel.GroupBox

        For Each ws In xlApp.Worksheets
            For Each cmt In ws.Comments
                cmt.Shape.TextFrame.AutoSize = True
                With cmt.Shape.TextFrame.Characters.Font
                    .Name = "Tahoma"
                    .Size = 8
                    .Bold = False
                End With
            Next cmt
        Next ws
    End Sub

    Private Function GetFirstDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtFrom As DateTime = dtDate
        dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1))
        Return dtFrom
    End Function

    Private Function GetLastDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtTo As New DateTime(dtDate.Year, dtDate.Month, 1)
        dtTo = dtTo.AddMonths(1)
        dtTo = dtTo.AddDays(-(dtTo.Day))
        Return dtTo
    End Function

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    '' The path to the documents directory.
    '    'Dim dataDir As String = "E:\"

    '    '' Create directory if it is not already present.
    '    'Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
    '    'If (Not IsExists) Then
    '    '    System.IO.Directory.CreateDirectory(dataDir)
    '    'End If

    '    ''Instantiate a new Workbook.
    '    'Dim excelbook As New Excel.Workbook

    '    ''Add a group box to the first worksheet.
    '    'Dim box As Aspose.Cells.Drawing.GroupBox = excelbook.Worksheets(0).Shapes.AddGroupBox(1, 0, 1, 0, 300, 250)

    '    ''Set the caption of the group box.
    '    'box.Text = "Age Groups"
    '    'box.Placement = PlacementType.FreeFloating

    '    ''Make it 2-D box.
    '    'box.Shadow = False

    '    ''Add a radio button.
    '    'Dim radio1 As Aspose.Cells.Drawing.RadioButton = excelbook.Worksheets(0).Shapes.AddRadioButton(3, 0, 2, 0, 30, 110)

    '    ''Set its text string.
    '    'radio1.Text = "20-29"

    '    ''Set A1 cell as a linked cell for the radio button.
    '    'radio1.LinkedCell = "A1"

    '    ''Make the radio button 3-D.
    '    'radio1.Shadow = True

    '    ''Set the foreground color of the radio button.
    '    'radio1.FillFormat.ForeColor = Color.LightGreen

    '    ''Set the line style of the radio button.
    '    'radio1.LineFormat.Style = MsoLineStyle.ThickThin

    '    ''Set the weight of the radio button.
    '    'radio1.LineFormat.Weight = 4

    '    ''Set the line color of the radio button.
    '    'radio1.LineFormat.ForeColor = Color.Blue

    '    ''Set the dash style of the radio button.
    '    'radio1.LineFormat.DashStyle = MsoLineDashStyle.Solid

    '    ''Make the line format visible.
    '    'radio1.LineFormat.IsVisible = True

    '    ''Make the fill format visible.
    '    'radio1.FillFormat.IsVisible = True

    '    ''Add another radio button.
    '    'Dim radio2 As Aspose.Cells.Drawing.RadioButton = excelbook.Worksheets(0).Shapes.AddRadioButton(6, 0, 2, 0, 30, 110)

    '    ''Set its text string.
    '    'radio2.Text = "30-39"

    '    ''Set A1 cell as a linked cell for the radio button.
    '    'radio2.LinkedCell = "A1"

    '    ''Make the radio button 3-D.
    '    'radio2.Shadow = True

    '    ''Set the foreground color of the radio button.
    '    'radio2.FillFormat.ForeColor = Color.LightGreen

    '    ''Set the line style of the radio button.
    '    'radio2.LineFormat.Style = MsoLineStyle.ThickThin

    '    ''Set the weight of the radio button.
    '    'radio2.LineFormat.Weight = 4

    '    ''Set the line color of the radio button.
    '    'radio2.LineFormat.ForeColor = Color.Blue

    '    ''Set the dash style of the radio button.
    '    'radio2.LineFormat.DashStyle = MsoLineDashStyle.Solid

    '    ''Make the line format visible.
    '    'radio2.LineFormat.IsVisible = True

    '    ''Make the fill format visible.
    '    'radio2.FillFormat.IsVisible = True

    '    ''Add another radio button.
    '    'Dim radio3 As Aspose.Cells.Drawing.RadioButton = excelbook.Worksheets(0).Shapes.AddRadioButton(9, 0, 2, 0, 30, 110)

    '    ''Set its text string.
    '    'radio3.Text = "40-49"

    '    ''Set A1 cell as a linked cell for the radio button.
    '    'radio3.LinkedCell = "A1"

    '    ''Make the radio button 3-D.
    '    'radio3.Shadow = True

    '    ''Set the foreground color of the radio button.
    '    'radio3.FillFormat.ForeColor = Color.LightGreen

    '    ''Set the line style of the radio button.
    '    'radio3.LineFormat.Style = MsoLineStyle.ThickThin

    '    ''Set the weight of the radio button.
    '    'radio3.LineFormat.Weight = 4

    '    ''Set the line color of the radio button.
    '    'radio3.LineFormat.ForeColor = Color.Blue

    '    ''Set the dash style of the radio button.
    '    'radio3.LineFormat.DashStyle = MsoLineDashStyle.Solid

    '    ''Make the line format visible.
    '    'radio3.LineFormat.IsVisible = True

    '    ''Make the fill format visible.
    '    'radio3.FillFormat.IsVisible = True

    '    ''Get the shapes.
    '    'Dim shapeobjects() As Aspose.Cells.Drawing.Shape = {box, radio1, radio2, radio3}

    '    ''Group the shapes.
    '    'Dim group As Aspose.Cells.Drawing.GroupShape = excelbook.Worksheets(0).Shapes.Group(shapeobjects)

    '    ''Save the excel file.
    '    ''excelbook.Save(dataDir & "book1.xls")

    'End Sub

    Private Sub frmEmpDataToExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter.Fill(Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Try
            Me.Tbl_Acc_Salary_Transactions_WorkingDaysTableAdapter.Fill(Me.DSExcelEmpData.tbl_Acc_Salary_Transactions_WorkingDays, GetFirstDayOfMonth(Me.DateTimePicker1.Text))
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.View_Att_Emp_ValueTableAdapter.Fill(Me.DSExcelEmpData.View_Att_Emp_Value, New System.Nullable(Of Date)(CType(AttDateToolStripTextBox.Text, Date)), New System.Nullable(Of Date)(CType(AttDate1ToolStripTextBox.Text, Date)), DeptNameToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class