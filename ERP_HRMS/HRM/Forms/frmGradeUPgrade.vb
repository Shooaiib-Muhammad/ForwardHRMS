Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Office.Core
Imports System.IO
Imports Microsoft.VisualBasic
Public Class frmGradeUpG1



    Dim oStreamWriter As StreamWriter
    Dim GlobalPathStr As String
    Private Sub Tbl_HRM_CardBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_CardBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSAdvance)

    End Sub



    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        'This function opens excel file, update and load into table adapter
        Dim Excelquery As String
        Dim OLEDBConString As String
        Dim OpenFileDialog2 As New OpenFileDialog

        OpenFileDialog2.Filter = "Microsoft Office Excel WorkSheet(*.xls;)|*.xls;|All Files(*.*)|*.*"
        OpenFileDialog2.FilterIndex = 1

        If OpenFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            DataGridView1.DataSource = Nothing
            GlobalPathStr = OpenFileDialog2.FileName.Trim()
            tbFilePath.Text = GlobalPathStr
            'Me.Label12.Text = Nothing
            If GlobalPathStr <> "" Then
                Dim FileExt1 As String = GlobalPathStr.Substring(GlobalPathStr.LastIndexOf(".") + 1)
                If UCase(FileExt1) = "XLS" Or UCase(FileExt1) = "XLSX" Then
                    'Dim result As Int16 = ModifyExcelRecords(GlobalPathStr)
                    Dim result As Integer = 1
                    If result = 1 Then
                        Try
                            OLEDBConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & GlobalPathStr & ";Extended Properties=Excel 8.0;"
                            'OLEDBConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GlobalPathStr & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=2"""
                            'OLEDBConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GlobalPathStr & ";Extended Properties=""Excel 12.0;HDR=Yes;IMEX=2"""
                            Excelquery = "SELECT CardNo,Grade from [Sheet1$]"
                            'Excelquery = "SELECT CardNo,EOBI from [Sheet3$]"
                            Dim LoadExcelAdapter As New OleDbDataAdapter(Excelquery, OLEDBConString)
                            Dim DSLoadExcel As DataSet = New DataSet()
                            LoadExcelAdapter.Fill(DSLoadExcel)
                            DataGridView1.DataSource = DSLoadExcel.Tables(0)
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    ElseIf result = 0 Then
                        MessageBox.Show("Invalid Excel File Selected")
                    End If
                Else
                    MessageBox.Show("Open Excel File only")
                End If
            Else
                MessageBox.Show("No File Selected")
            End If
        End If
    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim LoadCount As Integer
        Dim ExcelCard As Integer
        Dim ExcelGrade As String
        'Dim EOBI As String
        Dim Returns As Integer
        Dim ReturnsGrade As Integer
        LoadCount = Me.DataGridView1.RowCount

        If LoadCount = 0 Then
            MsgBox("Select Valid Excel File and Then Continue")
        Else
            Dim DResult As DialogResult = MessageBox.Show("Are You Sure About The Action!", "Grade Upgrade", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If DResult = 6 Then
                For i As Integer = 0 To LoadCount - 1
                    ExcelCard = Me.DataGridView1(0, i).Value
                    ExcelGrade = Me.DataGridView1(1, i).Value

                    'EOBI = Me.DataGridView1(1, i).Value
                    Try
                        Returns = Me.Tbl_Hrm_Emp_Info_H1TableAdapter.FillBy1(Me.DSAdvance.Tbl_Hrm_Emp_Info_H1, ExcelCard)
                    Catch ex As Exception
                    End Try
                    If Returns = 1 Then
                        ReturnsGrade = Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSDept.tbl_HRM_Grade, ExcelGrade)
                        If ReturnsGrade = 1 Then
                            If Me.DSAdvance.Tbl_Hrm_Emp_Info_H1(0).Item("CardNo") = ExcelCard Then
                                Me.Tbl_HRM_GradeTableAdapter.UpdateQuery(Me.DSDept.tbl_HRM_Grade(0).Item("GradeID"), DateTimePicker5.Text, ExcelCard)
                                PaintGrid(0, i, Color.DarkGreen, Color.White)
                                PaintGrid(1, i, Color.DarkGreen, Color.White)
                            Else
                                PaintGrid(0, i, Color.Red, Color.White)
                                PaintGrid(1, i, Color.Red, Color.White)
                            End If
                        Else
                            PaintGrid(0, i, Color.Red, Color.White)
                            PaintGrid(1, i, Color.Red, Color.White)
                        End If

                    End If
                Next
                'Me.Tbl_Acc_ShortTermAdvances11TableAdapter.Fill(Me.DSAdvance.tbl_Acc_ShortTermAdvances11, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
                MsgBox("Record Saved")
            End If
        End If
    End Sub
    Sub PaintGrid(ByVal i As Int16, ByVal j As Int16, ByVal BackColor As System.Drawing.Color, ByVal ForeColored As System.Drawing.Color)

        Me.DataGridView1(i, j).Style.BackColor = BackColor
        Me.DataGridView1(i, j).Style.ForeColor = ForeColored


    End Sub










    'Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
    '    Try
    '        Me.Validate()
    '        Me.Tbl_Acc_ShortTermAdvances11BindingSource.EndEdit()
    '        Me.Tbl_Acc_ShortTermAdvances11TableAdapter.Update(Me.DSAdvance.tbl_Acc_ShortTermAdvances11)
    '        'LoadTemAdvData()
    '        MsgBox("Record Saved Successfully")
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Sub Total1()
        Dim Total As Integer = 0
        Dim Count As Int16 = Me.DataGridView1.RowCount
        Try
            For j As Int16 = 0 To Count - 1
                Total = Total + DataGridView1(1, j).Value
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
        'Label12.Text = Total
        'Label12.Text = FormatNumber(Total, 0, TriState.True, TriState.False, TriState.True)
        '()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Total1()

    End Sub

    Private Sub DataGridView1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        'Total1()
    End Sub

    Private Sub DataGridView1_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowLeave
        Total1()
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        Total1()
    End Sub















    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.View_Acc_Fin_Ded_VouchersTableAdapter.Fill(Me.DSAdvance.View_Acc_Fin_Ded_Vouchers, CType(Param1ToolStripTextBox.Text, Decimal), CType(Param2ToolStripTextBox.Text, Decimal))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Dim TabFlag As Boolean = False

    Private Sub frmGradeUpG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSDept.tbl_HRM_Grade' table. You can move, or remove it, as needed.


    End Sub
End Class