Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Office.Core
Imports System.IO
Imports Microsoft.VisualBasic
Public Class frmSalaryUpgrade



    Dim oStreamWriter As StreamWriter
    Dim GlobalPathStr As String
    'Private Sub Tbl_HRM_CardBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.Tbl_HRM_CardBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.DSAdvance)

    'End Sub



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
                            Excelquery = "SELECT CardNo,Amt from [Sheet1$]"
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
        Dim ExcelAmt As Integer
        'Dim EOBI As String
        Dim Returns As Integer
        Dim Effecteddate As Date = DateTimePicker5.Text
        LoadCount = Me.DataGridView1.RowCount

        If LoadCount = 0 Then
            MsgBox("Select Valid Excel File and Then Continue")
        Else
            Dim DResult As DialogResult = MessageBox.Show("Are You Sure About The Action!", "Salary Upgrade", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If DResult = 6 Then
                For i As Integer = 0 To LoadCount - 1
                    ExcelCard = Me.DataGridView1(0, i).Value
                    ExcelAmt = Me.DataGridView1(1, i).Value
                    Dim obj As New UtilityClass
                    Dim FP As String = obj.ReturnFP(Now.Date.Month, Now.Date.Year)

                    Try
                        Returns = Me.Salary_UpgradeTableAdapter.Fill(Me.UpGradeSalary.Salary_Upgrade, ExcelCard)
                    Catch ex As Exception
                    End Try
                    If Returns = 1 Then
                        Dim SalId As Integer = Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("SalID")

                        Me.Tbl_Acc_SalaryTableAdapter.Insert(Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("EmpID"), ExcelAmt, Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("MealAllowance"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("TravelAllowance"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("EducationAllowance"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("SpecialAllowance"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("EOBI"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("TaxDeduction"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("RentDeduction"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("ConteenDeduct"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("UnionFund"), 0, Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("PaymentMode"), Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("PESSICont"), 3, "Annual", FP, Effecteddate, Nothing, Now.Date, True, Nothing, Nothing, Me.UpGradeSalary.Salary_Upgrade.Rows(0).Item("Accommodation"), 0)
                        Me.Salary_UpgradeTableAdapter.UpdateQuery(SalId)
                        PaintGrid(0, i, Color.DarkGreen, Color.White)
                        PaintGrid(1, i, Color.DarkGreen, Color.White)
                    Else
                        PaintGrid(0, i, Color.Red, Color.White)
                        PaintGrid(1, i, Color.Red, Color.White)

                    End If
                Next

                MsgBox("Record Saved")
            End If
        End If
    End Sub
    Sub PaintGrid(ByVal i As Int16, ByVal j As Int16, ByVal BackColor As System.Drawing.Color, ByVal ForeColored As System.Drawing.Color)

        Me.DataGridView1(i, j).Style.BackColor = BackColor
        Me.DataGridView1(i, j).Style.ForeColor = ForeColored


    End Sub




    Sub Total1()
        Dim Total As Integer = 0
        Dim Count As Int16 = Me.DataGridView1.RowCount
        Try
            For j As Int16 = 0 To Count - 1
                Total = Total + DataGridView1(1, j).Value
            Next
        Catch ex As Exception

        End Try

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

    'Dim TabFlag As Boolean = False

    Private Sub frmGradeUpG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UpGradeSalary.tbl_Acc_Salary' table. You can move, or remove it, as needed.


        'Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.UpGradeSalary.tbl_Acc_Salary)
        'TODO: This line of code loads data into the 'UpGradeSalary._Salary_Upgrade' table. You can move, or remove it, as needed.



        Try
            Me.Salary_UpgradeTableAdapter.Fill(Me.UpGradeSalary.Salary_Upgrade, EmpIDLabel1.Text)
        Catch ex As Exception

            End Try
        'TODO: This line of code loads data into the 'DSDept.tbl_HRM_Grade' table. You can move, or remove it, as needed.



    End Sub


End Class