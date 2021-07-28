Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Office.Core
Imports System.IO
Imports Microsoft.VisualBasic
Public Class frmShiftUpgrade



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
                            Excelquery = "SELECT CardNo,ShiftID from [Sheet1$]"
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
        Dim ExcelShiftID As Integer
        'Dim EOBI As String
        Dim Returns As Integer

        LoadCount = Me.DataGridView1.RowCount

        If LoadCount = 0 Then
            MsgBox("Select Valid Excel File and Then Continue")
        Else
            Dim DResult As DialogResult = MessageBox.Show("Are You Sure About The Action!", "Salary Upgrade", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If DResult = 6 Then
                For i As Integer = 0 To LoadCount - 1
                    ExcelCard = Me.DataGridView1(0, i).Value
                    ExcelShiftID = Me.DataGridView1(1, i).Value
                    Dim obj As New UtilityClass

                    Try
                        Returns = Me.Tbl_HRm_Shift_InfoTableAdapter.Fill(Me.UpGradeSalary.tbl_HRm_Shift_Info, ExcelCard)
                    Catch ex As Exception
                    End Try
                    If Returns = 1 Then

                        Tbl_HRm_Shift_InfoTableAdapter.UpdateQuery(ExcelShiftID, DateTimePicker5.Text, ExcelCard)

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
        Try
            Me.View_Card_InfoTableAdapter.Fill(Me.DSAdvance.View_Card_Info)
        Catch ex As Exception

        End Try
        Try
            Me.DataTable1TableAdapter.Fill(Me.DSAdvance.DataTable1, Me.CardNoLabel4.Text)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_GradeTableAdapter1.Fill(Me.DSHRM.tbl_HRM_Grade)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_JobType' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_JobTypeTableAdapter.Fill(Me.DSHRM.tbl_HRM_JobType)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Card' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_CardTableAdapter1.Fill(Me.DSHRM.tbl_HRM_Card)
        'TODO: This line of code loads data into the 'UpGradeSalary.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_ShiftTableAdapter1.Fill(Me.UpGradeSalary.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'UpGradeSalary.tbl_HRM_Emp_Info' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.UpGradeSalary.tbl_HRM_Emp_Info)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.Fill(Me.DSHRM.tbl_HRM_Shift)
        'TODO: This line of code loads data into the 'UpGradeSalary.tbl_HRm_Shift_Info' table. You can move, or remove it, as needed.
        'Me.Tbl_HRm_Shift_InfoTableAdapter.FillBy(Me.UpGradeSalary.tbl_HRm_Shift_Info, CardNoLabel1.Text)
        'TODO:   This line of code loads data into the 'UpGradeSalary.tbl_Acc_Salary' table. You can move, or remove it, as needed.


        'Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.UpGradeSalary.tbl_Acc_Salary)
        'TODO: This line of code loads data into the 'UpGradeSalary._Salary_Upgrade' table. You can move, or remove it, as needed.



        'Try
        '    Me.Salary_UpgradeTableAdapter.Fill(Me.UpGradeSalary.Salary_Upgrade, EmpIDLabel1.Text)
        'Catch ex As Exception

        'End Try
        'TODO: This line of code loads data into the 'DSDept.tbl_HRM_Grade' table. You can move, or remove it, as needed.



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TabControl1.SelectedTab = TabPage1
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TabControl1.SelectedTab = TabPage2
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Try
            Me.DataTable1TableAdapter.Fill(Me.DSAdvance.DataTable1, Me.CardNoLabel4.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel2_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel2.MouseEnter
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub LinkLabel2_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel2.MouseLeave
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub View_Card_InfoBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles View_Card_InfoBindingSource.PositionChanged
        Try
            Me.DataTable1TableAdapter.Fill(Me.DSAdvance.DataTable1, Me.CardNoLabel4.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabControl1_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseClick
        Try
            Me.View_Card_InfoTableAdapter.Fill(Me.DSAdvance.View_Card_Info)
        Catch ex As Exception

        End Try
        Try
            Me.DataTable1TableAdapter.Fill(Me.DSAdvance.DataTable1, Me.CardNoLabel4.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab.Text = "Manage Shift By Card" Then
            Label6.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label12.Visible = False
            Try
                'Me.View_Card_InfoTableAdapter.Fill(Me.DSAdvance.View_Card_Info)
            Catch ex As Exception

            End Try
            Try
                Me.DataTable1TableAdapter.Fill(Me.DSAdvance.DataTable1, Me.CardNoLabel4.Text)
            Catch ex As Exception

            End Try
        Else
            Label6.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label12.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataTable1TableAdapter.UpdateQuery(SHiftComboBox.SelectedValue, Now.Date, AttLockStatusCheckBox.CheckState, CardNoComboBox.SelectedValue)
        'MsgBox("Shift has Been Updated ")

        Try
            Me.DataTable1TableAdapter.Fill(Me.DSAdvance.DataTable1, Me.CardNoLabel4.Text)
        Catch ex As Exception

        End Try
        MsgBox("Record Saved Successfully")
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class