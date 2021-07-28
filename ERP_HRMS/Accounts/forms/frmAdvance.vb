Imports System.Data.OleDb
Imports System.Data
Imports Microsoft.Office.Core
Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic
Public Class frmAdvance
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TabControl1.SelectedTab = TabPage1
        Me.RadioButton4.Enabled = False
        Button2.Enabled = False
        Me.Label2.Text = "From Date"
        Me.Label5.Text = "To Date"
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TabControl1.SelectedTab = TabPage2
        Me.RadioButton4.Enabled = True
        Me.Button2.Enabled = False
        Me.Label2.Text = "From Date"
        Me.Label5.Text = "To Date"
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
    End Sub
    Dim oStreamWriter As StreamWriter
    Dim GlobalPathStr As String
    Private Sub Tbl_HRM_CardBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_CardBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSAdvance)

    End Sub
    Private Sub LoadTemAdvData()
        If TabControl1.SelectedIndex = 0 Then
            Me.RadioButton4.Enabled = False
            If RadioButton1.Checked Then
                Me.Tbl_Acc_ShortTermAdvances11TableAdapter.Card_FillBy(Me.DSAdvance.tbl_Acc_ShortTermAdvances11, Me.CardNoComboBox.SelectedValue, Me.CardNoComboBox1.SelectedValue)
            ElseIf RadioButton2.Checked Then
                Me.Tbl_Acc_ShortTermAdvances11TableAdapter.Fill(Me.DSAdvance.tbl_Acc_ShortTermAdvances11, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
            ElseIf RadioButton3.Checked Then
                Me.Tbl_Acc_ShortTermAdvances11TableAdapter.CardsDate_FillBy(Me.DSAdvance.tbl_Acc_ShortTermAdvances11, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text, Me.CardNoComboBox.SelectedValue, Me.CardNoComboBox1.SelectedValue)
            ElseIf RadioButton6.Checked Then
                Me.Tbl_Acc_ShortTermAdvances11TableAdapter.Card_DateFillBy(Me.DSAdvance.tbl_Acc_ShortTermAdvances11, Me.DateTimePicker1.Text, Me.CardNoComboBox1.SelectedValue)
            End If
        End If
    End Sub
    Private Sub LoadPermAdvData()
        If TabControl1.SelectedIndex = 1 Then
            Me.RadioButton4.Enabled = True
            If RadioButton1.Checked Then
                Me.Tbl_Acc_PermanentAdvancesTableAdapter.Card_FillBy(Me.DSAdvance.tbl_Acc_PermanentAdvances, Me.CardNoComboBox.SelectedValue, Me.CardNoComboBox1.SelectedValue)
            ElseIf RadioButton2.Checked Then
                Me.Tbl_Acc_PermanentAdvancesTableAdapter.Fill(Me.DSAdvance.tbl_Acc_PermanentAdvances, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
            ElseIf RadioButton3.Checked Then
                Me.Tbl_Acc_PermanentAdvancesTableAdapter.CardsDate_FillBy(Me.DSAdvance.tbl_Acc_PermanentAdvances, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text, Me.CardNoComboBox.SelectedValue, Me.CardNoComboBox1.SelectedValue)
            ElseIf RadioButton6.Checked Then
                Me.Tbl_Acc_PermanentAdvancesTableAdapter.Card_DateFillBy(Me.DSAdvance.tbl_Acc_PermanentAdvances, Me.DateTimePicker1.Text, Me.CardNoComboBox1.SelectedValue)
            ElseIf RadioButton4.Checked Then
                Me.Tbl_Acc_PermanentAdvancesTableAdapter.FillBy(Me.DSAdvance.tbl_Acc_PermanentAdvances, ComboBox1.Text)
            End If
        End If
    End Sub
    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        If Me.TabControl1.SelectedTab.Text = "Short Term Advance" Then
            TabFlag = False
            Me.RadioButton4.Enabled = False
            LoadTemAdvData()
        ElseIf Me.TabControl1.SelectedTab.Text = "Long Term Advance" Then
            TabFlag = False
            Me.RadioButton4.Enabled = True
            LoadPermAdvData()
        ElseIf Me.TabControl1.SelectedTab.Text = "Long Term Advances Vouchers" Then

            TabFlag = True
            Me.View_Acc_Fin_Ded_VouchersTableAdapter.Fill(Me.DSAdvance.View_Acc_Fin_Ded_Vouchers, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            PDFPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Auto Permanent Advance Voucher Error"
            If Directory.Exists(PDFPath) Then
            Else
                Directory.CreateDirectory(PDFPath)
            End If
        End If
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
            Me.Label12.Text = Nothing
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
        LoadCount = Me.DataGridView1.RowCount

        If LoadCount = 0 Then
            MsgBox("Select Valid Excel File and Then Continue")
        Else
            Dim DResult As DialogResult = MessageBox.Show("Are You Sure About The Action!", "T Adv. Excel To Database Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If DResult = 6 Then
                For i As Integer = 0 To LoadCount - 1
                    ExcelCard = Me.DataGridView1(0, i).Value
                    ExcelAmt = Me.DataGridView1(1, i).Value
                    'EOBI = Me.DataGridView1(1, i).Value
                    Try
                        Returns = Me.Tbl_Hrm_Emp_Info_H1TableAdapter.FillBy1(Me.DSAdvance.Tbl_Hrm_Emp_Info_H1, ExcelCard)
                    Catch ex As Exception
                    End Try
                    If Returns = 1 Then
                        If Me.DSAdvance.Tbl_Hrm_Emp_Info_H1(0).Item(0) = ExcelCard Then
                            Me.Tbl_Acc_ShortTermAdvancesTableAdapter.Insert(Me.DSAdvance.Tbl_Hrm_Emp_Info_H1(0).Item(1), ExcelAmt, DateTimePicker1.Value.ToShortDateString())
                            'Me.Tbl_Hrm_Emp_Info_H1TableAdapter.UpdateQuery(EOBI, Me.HRMDBDataSet1.tbl_Hrm_Emp_Info_H1(0).Item(1))
                        End If
                    End If
                Next
                Me.Tbl_Acc_ShortTermAdvances11TableAdapter.Fill(Me.DSAdvance.tbl_Acc_ShortTermAdvances11, Me.DateTimePicker1.Text, Me.DateTimePicker2.Text)
                MsgBox("Record Saved")
            End If
        End If
    End Sub
    Private Sub frmAdvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSAdvance.tbl_HRM_Card_New123' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Card_New123TableAdapter.Fill(Me.DSAdvance.tbl_HRM_Card_New123)
        'TODO: This line of code loads data into the 'DSAdvance.tbl_HRM_Card_New123' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_Card_New123TableAdapter.Fill(Me.DSAdvance.tbl_HRM_Card_New123)
        'TODO: This line of code loads data into the 'DSAdvance.tbl_HRM_Card_New' table. You can move, or remove it, as needed.
        'Me.Tbl_HRM_Card_NewTableAdapter.Fill(Me.DSAdvance.tbl_HRM_Card_New)
        'This line of code loads data into the 'DSAdvance.Tbl_Fin_DebitCredit_Entry1' table. You can move, or remove it, as needed.
        'Me.Tbl_Fin_DebitCredit_Entry1TableAdapter.Fill(Me.DSAdvance.Tbl_Fin_DebitCredit_Entry1)
        ''This line of code loads data into the 'DSAdvance.tbl_Fin_DebitCredit_Entry' table. You can move, or remove it, as needed.
        'Me.Tbl_Fin_DebitCredit_EntryTableAdapter.Fill(Me.DSAdvance.tbl_Fin_DebitCredit_Entry)
        'This line of code loads data into the 'DSAdvance.tbl_Acc_FinancialPeriodAdv' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodAdvTableAdapter.Fill(Me.DSAdvance.tbl_Acc_FinancialPeriodAdv)
        Me.Tbl_Acc_BonusNoTableAdapter.Fill(Me.DSAdvance.tbl_Acc_BonusNo)
        Me.Tbl_Acc_FinancialPeriod11TableAdapter.Fill(Me.DSAdvance.tbl_Acc_FinancialPeriod11)
        Me.Tbl_Fin_Layer4_NewTableAdapter.Fill(Me.DSAdvance.tbl_Fin_Layer4_New)
        Try
            Me.Tbl_HRM_CardAdvTableAdapter.Fill(Me.DSAdvance.tbl_HRM_CardAdv)
        Catch ex As Exception

        End Try

        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSAdvance.tbl_Acc_FinancialPeriod)
        Try
            Me.Tbl_HRM_Card11TableAdapter.Fill(Me.DSAdvance.tbl_HRM_Card11)
        Catch ex As Exception

        End Try
        Try
            Me.View_Card_InfoTableAdapter.Fill(Me.DSAdvance.View_Card_Info)
        Catch ex As Exception

        End Try
        Try
            Me.Tbl_HRM_CardTableAdapter.Fill(Me.DSAdvance.tbl_HRM_Card)
        Catch ex As Exception

        End Try

        Me.Button2.Enabled = False
        Try
            Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.Fill(Me.DSAdvance.View_Rpt_HR_EmpData_ActiveNonActive, Me.CardNoLabel3.Text)
        Catch ex As Exception
        End Try
        LoadTemAdvData()
        LoadPermAdvData()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Label3.Enabled = False
            Label4.Enabled = False
            CardNoComboBox.Enabled = False
            CardNoComboBox1.Enabled = False

            Label2.Enabled = True
            Label5.Enabled = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True

            Label6.Enabled = False
            Me.ComboBox1.Enabled = False
            'FillBy()
            LoadTemAdvData()
            LoadPermAdvData()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            Label3.Enabled = True
            Label4.Enabled = True
            CardNoComboBox.Enabled = False
            CardNoComboBox1.Enabled = False

            Label2.Enabled = False
            Label5.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False

            Label6.Enabled = True
            ComboBox1.Enabled = True
            'FillBy2()
            LoadPermAdvData()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Label3.Enabled = True
            Label4.Enabled = True
            CardNoComboBox.Enabled = True
            CardNoComboBox1.Enabled = True

            Label2.Enabled = False
            Label5.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False

            Label6.Enabled = False
            ComboBox1.Enabled = False
            'Fill()
            LoadTemAdvData()
            LoadPermAdvData()
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            Label3.Enabled = True
            Label4.Enabled = False
            CardNoComboBox.Enabled = True
            CardNoComboBox1.Enabled = False

            Label2.Enabled = True
            Label5.Enabled = False
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = False

            Label6.Enabled = False
            ComboBox1.Enabled = False
            'FillBy3()
            LoadTemAdvData()
            LoadPermAdvData()
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Label3.Enabled = True
            Label4.Enabled = True
            CardNoComboBox.Enabled = True
            CardNoComboBox1.Enabled = True

            Label2.Enabled = True
            Label5.Enabled = True
            DateTimePicker1.Enabled = True
            DateTimePicker2.Enabled = True

            Label6.Enabled = False
            ComboBox1.Enabled = False
            'FillBy1()
            LoadTemAdvData()
            LoadPermAdvData()
        End If
    End Sub

    Private Sub Tbl_HRM_CardBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_CardBindingSource.PositionChanged
        Try
            Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.Fill(Me.DSAdvance.View_Rpt_HR_EmpData_ActiveNonActive, Me.CardNoLabel3.Text)
        Catch ex As Exception

        End Try
        LoadTemAdvData()
        LoadPermAdvData()
    End Sub


    Sub TotalAmount()
        Dim k As Integer = 0
        Try
            For j As Int32 = 0 To Me.Tbl_Acc_ShortTermAdvancesDataGridView.RowCount - 1
                k = k + Me.Tbl_Acc_ShortTermAdvancesDataGridView(2, j).Value
            Next
        Catch ex As Exception

        End Try
        'Label9.Text = k
        Label9.Text = FormatNumber(k, 1, TriState.UseDefault, TriState.UseDefault, TriState.True)
    End Sub
    Private Sub Tbl_Acc_ShortTermAdvancesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_ShortTermAdvancesDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Acc_ShortTermAdvancesDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_ShortTermAdvancesDataGridView.RowEnter
        TotalAmount()
        If Tbl_Acc_ShortTermAdvancesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
            Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.Fill(Me.DSAdvance.View_Rpt_HR_EmpData_ActiveNonActive, Val(Tbl_Acc_ShortTermAdvancesDataGridView(1, e.RowIndex).Value))
        End If
    End Sub

    Private Sub Tbl_Acc_ShortTermAdvancesDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles Tbl_Acc_ShortTermAdvancesDataGridView.RowsAdded
        TotalAmount()
    End Sub

    Private Sub Tbl_Acc_ShortTermAdvancesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Acc_ShortTermAdvancesDataGridView.DataError

    End Sub

    Private Sub Tbl_Acc_ShortTermAdvancesDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_ShortTermAdvancesDataGridView.CellEnter
        If e.ColumnIndex = 3 Then
            If Me.Tbl_Acc_ShortTermAdvancesDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
                If Me.Tbl_Acc_ShortTermAdvancesDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_Acc_ShortTermAdvancesDataGridView(3, e.RowIndex).Value = Now.Date
                End If
            End If
        End If
    End Sub

    Private Sub Tbl_Acc_ShortTermAdvancesDataGridView_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_ShortTermAdvancesDataGridView.CellLeave
        TotalAmount()
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.Validate()
            Me.Tbl_Acc_ShortTermAdvances11BindingSource.EndEdit()
            Me.Tbl_Acc_ShortTermAdvances11TableAdapter.Update(Me.DSAdvance.tbl_Acc_ShortTermAdvances11)
            LoadTemAdvData()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception

        End Try
    End Sub

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
        Label12.Text = FormatNumber(Total, 0, TriState.True, TriState.False, TriState.True)
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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If TabFlag = True Then
            Try
                Me.View_Acc_Fin_Ded_VouchersTableAdapter.Fill(Me.DSAdvance.View_Acc_Fin_Ded_Vouchers, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As Exception
            End Try
        Else
            LoadTemAdvData()
            LoadPermAdvData()
        End If

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        LoadTemAdvData()
        LoadPermAdvData()
    End Sub

    Private Sub Tbl_HRM_Card11BindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_Card11BindingSource.PositionChanged
        LoadTemAdvData()
        LoadPermAdvData()
    End Sub

    Private Sub Tbl_Acc_PermanentAdvancesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_PermanentAdvancesDataGridView.CellContentClick
        If RadioButton3.Checked = True Or RadioButton6.Checked = True Then

            If Me.Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value = CardNoComboBox.SelectedValue
            End If
        End If
    End Sub

    Private Sub Tbl_Acc_PermanentAdvancesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Acc_PermanentAdvancesDataGridView.DataError

    End Sub

    Private Sub Tbl_Acc_PermanentAdvancesDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Acc_PermanentAdvancesDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try
            Me.Validate()
            Me.Tbl_Acc_PermanentAdvancesBindingSource.EndEdit()
            Me.Tbl_Acc_PermanentAdvancesTableAdapter.Update(Me.DSAdvance.tbl_Acc_PermanentAdvances)
            LoadPermAdvData()
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Acc_PermanentAdvancesDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_PermanentAdvancesDataGridView.CellEnter
        Dim Obj As New UtilityClass
        If Me.Tbl_Acc_PermanentAdvancesDataGridView(10, e.RowIndex).Value Is DBNull.Value Then
            Tbl_Acc_PermanentAdvancesDataGridView(11, e.RowIndex).ReadOnly = True

            Tbl_Acc_PermanentAdvancesDataGridView(12, e.RowIndex).ReadOnly = True
        Else
            Tbl_Acc_PermanentAdvancesDataGridView(11, e.RowIndex).ReadOnly = False

            Tbl_Acc_PermanentAdvancesDataGridView(12, e.RowIndex).ReadOnly = False
        End If

        If Me.Tbl_Acc_PermanentAdvancesDataGridView(8, e.RowIndex).Value Is DBNull.Value Then
            'Tbl_Acc_PermanentAdvancesDataGridView(9, e.RowIndex).ReadOnly = True

        End If

        If e.ColumnIndex = 9 Then
            If Me.Tbl_Acc_PermanentAdvancesDataGridView(8, e.RowIndex).Value IsNot DBNull.Value Then
                Dim DOJ As Date = CDate(Me.DOJLabel.Text)
                Dim MyDate As Date = "#" & DOJ.Day & "/" & DOJ.Month & "/" & Now.Date.Year & "#"
                If Me.Tbl_Acc_PermanentAdvancesDataGridView(9, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_Acc_PermanentAdvancesDataGridView(9, e.RowIndex).Value = MyDate
                End If
            End If

        End If


        If RadioButton3.Checked = True Or RadioButton6.Checked = True Then

            If Me.Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value = CardNoComboBox.SelectedValue
            End If
        End If
        If e.ColumnIndex = 1 Then
            If Me.Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value = Me.Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try

            End If
        End If
        If e.ColumnIndex = 3 Then
            If Me.Tbl_Acc_PermanentAdvancesDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
                Dim TransDate As Date = Me.Tbl_Acc_PermanentAdvancesDataGridView(2, e.RowIndex).Value
                If Obj.ReturnFP(TransDate.Month, TransDate.Year) <> Nothing Then
                    Me.Tbl_Acc_PermanentAdvancesDataGridView(3, e.RowIndex).Value = Obj.ReturnFP(TransDate.Month, TransDate.Year)
                End If
            Else
                MsgBox("Transaction Date is Missing")
            End If
        ElseIf e.ColumnIndex = 2 Then
            If Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
                If Me.Tbl_Acc_PermanentAdvancesDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_Acc_PermanentAdvancesDataGridView(2, e.RowIndex).Value = Now.Date
                End If
            Else
                MsgBox("Card No is Missing")
            End If


        ElseIf e.ColumnIndex = 10 Then
            If Me.Tbl_Acc_PermanentAdvancesDataGridView(2, e.RowIndex).Value IsNot DBNull.Value Then
                Dim TransDate As Date = Me.Tbl_Acc_PermanentAdvancesDataGridView(2, e.RowIndex).Value
                If Obj.ReturnFP(TransDate.Month, TransDate.Year) <> Nothing Then
                    Me.Tbl_Acc_PermanentAdvancesDataGridView(10, e.RowIndex).Value = Obj.ReturnFP(TransDate.Month, TransDate.Year)
                End If
            Else
                MsgBox("Transaction Date is Missing")
            End If
        End If
    End Sub

    Private Sub Tbl_Acc_PermanentAdvancesDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_PermanentAdvancesDataGridView.RowEnter
        If Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
            Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.Fill(Me.DSAdvance.View_Rpt_HR_EmpData_ActiveNonActive, Val(Tbl_Acc_PermanentAdvancesDataGridView(1, e.RowIndex).Value))
        End If
    End Sub

    Private Sub Tbl_Acc_FinancialPeriodBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_Acc_FinancialPeriodBindingSource.PositionChanged
        LoadPermAdvData()
    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        '    Me.View_Acc_Fin_Ded_VouchersTableAdapter.Fill(Me.DSAdvance.View_Acc_Fin_Ded_Vouchers, CType(Param1ToolStripTextBox.Text, Decimal), CType(Param2ToolStripTextBox.Text, Decimal))
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        TabControl1.SelectedTab = TabPage3
        Me.RadioButton4.Enabled = False
        Me.Button2.Enabled = True
        Me.RadioButton2.Checked = True
        Me.Label2.Text = "Salary Month"
        Me.Label5.Text = "Voucher Date"
        Me.DateTimePicker1.CustomFormat = "MMM, yyyy"
    End Sub
    Dim OStremWriter As StreamWriter
    Dim FilePath As String = Nothing
    'Dim FileFlag As Boolean = False
    Sub ErrorFileWriter(ByVal Path As String, ByVal Str As String)
        If Str <> "" Then
            Try
                OStremWriter = New StreamWriter(Path, True)
                OStremWriter.Write(Str)
                OStremWriter.WriteLine("")
                OStremWriter.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub TotalValue()
        Dim DedAmount, TotalAmount As Integer
        For i As Integer = 0 To Me.View_Acc_Fin_Ded_VouchersDataGridView.RowCount - 1
            DedAmount = Me.View_Acc_Fin_Ded_VouchersDataGridView(5, i).Value
            TotalAmount += DedAmount
        Next
        Label13.Text = TotalAmount
    End Sub
    Dim PDFPath As String
    Dim TabFlag As Boolean = False
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are you sure," & vbCrLf & "You want to Generate [" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + "] Auto Financial Permanent Advance  Voucher Of following Employees?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dgResult = 6 Then
            FilePath = PDFPath + "\Financial Voucher Error" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + ".txt"
            If File.Exists(FilePath) Then
            Else
                File.Create(FilePath).Dispose()
            End If
            ToolStripProgressBar1.Maximum = Me.View_Acc_Fin_Ded_VouchersDataGridView.RowCount - 1
            Dim TotalAmount As Integer = 0
            Dim FyID, TransID, VoucherNo, VDNO As Integer
            Dim Descrip As String = "Recovered From Salary For The M/O " + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString
            If Me.Tbl_Fin_Journal_HeadTableAdapter.Fill(Me.DSAdvance.tbl_Fin_Journal_Head, Me.DateTimePicker2.Text) > 0 Then
                FyID = Me.DSAdvance.tbl_Fin_Journal_Head.Rows(0).Item("FYID")
                TransID = Me.DSAdvance.tbl_Fin_Journal_Head.Rows(0).Item("TransID")
                VoucherNo = Me.Tbl_Fin_DebitCredit_EntryTableAdapter.MaxVoucherNo(FyID, TransID) + 1
                VDNO = Me.Tbl_Fin_DebitCredit_EntryTableAdapter.MaxVDNO(FyID, TransID, VoucherNo)
            End If
            For j As Integer = 0 To Me.View_Acc_Fin_Ded_VouchersDataGridView.RowCount - 1
                If Me.View_Acc_Fin_Ded_VouchersDataGridView(8, j).Value = False Then
                    VDNO = VDNO + 1
                    Try
                        Me.Tbl_Fin_DebitCredit_Entry1TableAdapter.Insert(FyID, TransID, VoucherNo, VDNO, "CRV", Now.Date, Me.View_Acc_Fin_Ded_VouchersDataGridView(3, j).Value.ToString, Nothing, CInt(Me.View_Acc_Fin_Ded_VouchersDataGridView(5, j).Value), Descrip, Nothing, Now.Date, Now.Date, Nothing, True, Nothing, 1)
                        TotalAmount = TotalAmount + CInt(View_Acc_Fin_Ded_VouchersDataGridView(5, j).Value)
                        Me.View_Acc_Fin_Ded_VouchersTableAdapter.UpdateQuery_FinStatus(Me.View_Acc_Fin_Ded_VouchersDataGridView(0, j).Value)
                    Catch ex As Exception
                        ErrorFileWriter(FilePath, "Please Check Already CardNo: [" & Me.View_Acc_Fin_Ded_VouchersDataGridView(1, j).Value & "]  Message: [" + ex.Message + "]")
                    End Try

                    'Me.Tbl_Fin_DebitCredit_Entry1TableAdapter.Insert()

                    'Me.View_Acc_Fin_Ded_VouchersDataGridView(8, j).Value = True
                Else
                    ErrorFileWriter(FilePath, "Please Check Already CardNo:  [" & Me.View_Acc_Fin_Ded_VouchersDataGridView(1, j).Value & "] , Message: [" + Me.DateTimePicker1.Value.ToString("MMMM") + "-" + Me.DateTimePicker1.Value.Year.ToString + " Permanent Advance Deduction Voucher Generated]")
                End If
                Thread.Sleep(90)
                Application.DoEvents()
                ToolStripProgressBar1.Value = j
            Next
            Me.Tbl_Fin_DebitCredit_Entry1TableAdapter.Insert(FyID, TransID, VoucherNo, VDNO + 1, "CRV", Now.Date, "2-09-001-0001", TotalAmount, Nothing, Descrip, Nothing, Now.Date, Now.Date, Nothing, True, Nothing, 1)
            'MsgBox(TotalAmount)
            'MsgBox(VDNO)
            Try
                Me.View_Acc_Fin_Ded_VouchersTableAdapter.Fill(Me.DSAdvance.View_Acc_Fin_Ded_Vouchers, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Year)
            Catch ex As Exception
            End Try
            MsgBox("Permanent Advances Vouchers Entered Successfully,Please Check Error File On Your desktop")
            ToolStripProgressBar1.Value = 0

        End If
    End Sub



    Private Sub View_Acc_Fin_Ded_VouchersDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Acc_Fin_Ded_VouchersDataGridView.CellContentClick

    End Sub

    Private Sub View_Acc_Fin_Ded_VouchersDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles View_Acc_Fin_Ded_VouchersDataGridView.DataError

    End Sub

    Private Sub View_Acc_Fin_Ded_VouchersDataGridView_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Acc_Fin_Ded_VouchersDataGridView.RowEnter
        TotalValue()
    End Sub

    Private Sub View_Acc_Fin_Ded_VouchersDataGridView_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles View_Acc_Fin_Ded_VouchersDataGridView.RowsAdded
        TotalValue()
    End Sub

    Private Sub LinkLabel1_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel1.MouseEnter
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel1_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel1.MouseLeave
        Me.LinkLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub LinkLabel2_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel2.MouseLeave
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub LinkLabel4_MouseLeave(sender As Object, e As EventArgs) Handles LinkLabel4.MouseLeave
        Me.LinkLabel4.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub

    Private Sub LinkLabel2_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel2.MouseEnter
        Me.LinkLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub LinkLabel4_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabel4.MouseEnter
        Me.LinkLabel4.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub CardNoLabel3_Click(sender As Object, e As EventArgs) Handles CardNoLabel3.Click

    End Sub

    Private Sub CardNoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CardNoComboBox.SelectedIndexChanged
        CardNoComboBox1.Text = CardNoComboBox.Text
    End Sub
End Class