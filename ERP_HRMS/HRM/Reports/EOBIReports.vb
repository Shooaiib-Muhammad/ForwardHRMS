Public Class EOBIReports
    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Private Sub EOBIReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSUser.tbl_Acc_FinancialPeriod)
        'TODO: This line of code loads data into the 'HRMDBDataset1.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Try
            SelectFP()

        Catch ex As Exception

        End Try

    End Sub
    Dim Flag As Boolean = False
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click


        If RadioButton1.Checked = True Then
            If StatusTextBox.Text = True Then
                Path = "" & frmLogin.ReportsPath & "\HR\RptEOBINew.rpt"
            Else
                Path = "" & frmLogin.ReportsPath & "\HR\RptEOBI.rpt"
            End If
            If TextBox1.Text.Length = 0 Then
                Flag = True
            Else
                Flag = False
            End If
            If TextBox2.Text = "" Then
                Filter = " {View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} ='" & FinancialPeriodComboBox.Text & "' And {tbl_Hrm_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & ""
            Else
                Filter = "{View_Rpt_Acc_ActiveSalaryTransactions.FinancialPeriod} ='" & FinancialPeriodComboBox.Text & "' And {tbl_HRM_Emp_Info.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
            End If

        End If

        If Flag = True Then
            MessageBox.Show("Start Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If
    End Sub
    Private Sub SelectFP()
        'Here Obj.ReturnFP() function is a utility function that returns financial period by providing Year and Month
        Dim Obj As New UtilityClass()
        If Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year) <> Nothing Then
            FinancialPeriodComboBox.SelectedValue = Obj.ReturnFP(DateTimePicker1.Value.Month, DateTimePicker1.Value.Year)
        Else
            MsgBox("Selected year was beyond the running financial period")
            DateTimePicker1.Value = Now.Date
        End If
    End Sub
    Private Sub Tbl_Acc_FinancialPeriodBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Acc_FinancialPeriodBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSUser)

    End Sub
End Class