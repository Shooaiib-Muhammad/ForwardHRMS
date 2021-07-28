
Public Class frmManageSalary

    Private Sub frmManageSalary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            LoadSalary()
        ElseIf e.KeyCode = Keys.S And e.Control Then
            Addflag = False
            Try
                SaveData()
                MsgBox("Record Saved")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    'Dim IPAddress2 As String
    Private Sub frmManageSalary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSManageSalary.tbl_Comp_Info)
        Me.Tbl_Hrm_Emp_Info_HTableAdapter.Fill(Me.DSManageSalary.tbl_Hrm_Emp_Info_H)
        Me.Tbl_ApprovingAthorityTableAdapter.Fill(Me.DSManageSalary.tbl_ApprovingAthority)
        Try
            Me.View_Rpt_Acc_DesigGradeDeptTableAdapter.Fill(Me.DSManageSalary.View_Rpt_Acc_DesigGradeDept)
        Catch ex As Exception
        End Try
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.DSManageSalary.tbl_Acc_FinancialPeriod)
        'IPAddress = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        'IPAddress2 = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
        LoadBioData()
        KeyPreview = True
        Loadflag = True
    End Sub

    Private Sub Tbl_Hrm_Emp_Info_HBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_Emp_Info_HBindingSource.PositionChanged
        LoadBioData()
    End Sub

    Private Sub LoadBioData()
        Me.Tbl_Hrm_Emp_InfoTableAdapter.Fill(Me.DSManageSalary.tbl_Hrm_Emp_Info, Val(CardNoLabel2.Text))
        Me.Tbl_Hrm_Emp_InfoBindingSource.Position = Me.Tbl_Hrm_Emp_InfoBindingSource.Count - 1
        LoadSalary()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Addflag = False
        Try
            SaveData()
            MsgBox("Record Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim Loadflag As Boolean = False
    Private Sub Tbl_Acc_SalaryDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.CellValueChanged
        If Loadflag = True Then
            If e.ColumnIndex = 9 Or e.ColumnIndex = 11 Or e.ColumnIndex = 14 Or e.ColumnIndex = 17 Or e.ColumnIndex = 15 Then
            Else
                Me.Tbl_Acc_SalaryDataGridView(19, e.RowIndex).Value = frmLogin.UserID
                'Me.Tbl_Acc_SalaryDataGridView(20, e.RowIndex).Value = IPAddress2
                'Me.Tbl_Acc_SalaryDataGridView(21, e.RowIndex).Value = frmLogin.LoginId
            End If
        End If
    End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Acc_SalaryDataGridView.DataError

    End Sub
    Private Sub ReadOnlyContents(ByVal i As Boolean, ByVal j As Boolean)
        Tbl_Acc_SalaryDataGridView.Columns(1).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(0).ReadOnly = True
        Tbl_Acc_SalaryDataGridView.Columns(2).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(3).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(4).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(5).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(6).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(7).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(8).ReadOnly = False
        Tbl_Acc_SalaryDataGridView.Columns(9).ReadOnly = False
        Tbl_Acc_SalaryDataGridView.Columns(10).ReadOnly = False
        Tbl_Acc_SalaryDataGridView.Columns(11).ReadOnly = False
        Tbl_Acc_SalaryDataGridView.Columns(12).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(13).ReadOnly = True
        Tbl_Acc_SalaryDataGridView.Columns(14).ReadOnly = j
        Tbl_Acc_SalaryDataGridView.Columns(15).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(16).ReadOnly = i
        Tbl_Acc_SalaryDataGridView.Columns(17).ReadOnly = False
        Tbl_Acc_SalaryDataGridView.Columns(18).ReadOnly = False
    End Sub
    Private Sub Tbl_Acc_SalaryDataGridView_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.CellEnter
        If Addflag = True Then
            If Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(2, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(3, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(4, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(6, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(16, e.RowIndex).Value Is DBNull.Value Or Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value Is DBNull.Value Then
                ReadOnlyContents(False, False)
            Else
                ReadOnlyContents(True, False)
            End If
        Else
            ReadOnlyContents(True, False)
        End If

        If Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value Is DBNull.Value Then
            Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).ReadOnly = False
        ElseIf Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value = False Then
            Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).ReadOnly = False
        Else
            Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).ReadOnly = True
        End If
        If Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value Is DBNull.Value Then

        End If
        If e.ColumnIndex = 1 Then 'Salary
            If Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex = 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value = CInt(Me.BasicSalaryLabel1.Text)
                    ElseIf e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex - 1).Value
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 2 Then 'Tax
            If Me.Tbl_Acc_SalaryDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(2, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(2, e.RowIndex - 1).Value
                    Else
                        Me.Tbl_Acc_SalaryDataGridView(2, e.RowIndex).Value = 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 3 Then 'Rent
            If Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex - 1).Value
                    Else
                        Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).Value = 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 4 Then 'EOBI
            If Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex = 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).Value = CInt(Me.EOBILabel1.Text)
                    ElseIf e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex - 1).Value
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 5 Then 'Travel
            If Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex - 1).Value
                    Else
                        Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value = 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 6 Then 'Edu
            If Me.Tbl_Acc_SalaryDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(6, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(6, e.RowIndex - 1).Value
                    Else
                        Me.Tbl_Acc_SalaryDataGridView(6, e.RowIndex).Value = 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 7 Then 'Special
            If Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex - 1).Value
                    Else
                        Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value = 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 8 Then 'Meal
            If Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex = 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value = Val(Me.MealLabel1.Text)
                    ElseIf e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex - 1).Value
                        'Else
                        '    Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value = 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 9 Then 'Pay-Mode
            If Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex = 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).Value = "Cash"
                    ElseIf e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex - 1).Value
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 10 Then 'PAdv Ded Rate
            If Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex - 1).Value
                    Else
                        Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value = 0
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 11 Then  'Approved By
            If Me.Tbl_Acc_SalaryDataGridView(11, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(11, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(11, e.RowIndex - 1).Value
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 12 Then  'FP
            If Me.Tbl_Acc_SalaryDataGridView(12, e.RowIndex).Value Is DBNull.Value Then
                Dim obj As New UtilityClass
                Dim FP As String = obj.ReturnFP(Now.Month, Now.Year)
                If FP <> "" Then
                    Me.Tbl_Acc_SalaryDataGridView(12, e.RowIndex).Value = FP
                Else
                    Me.Tbl_Acc_SalaryDataGridView(12, e.RowIndex).Value = "Jul2009-Jun2010"
                End If
            End If
        ElseIf e.ColumnIndex = 13 Then  'Activation Date
            If Me.Tbl_Acc_SalaryDataGridView(13, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Acc_SalaryDataGridView(13, e.RowIndex).Value = Now.Date
            End If
        ElseIf e.ColumnIndex = 15 Then  'Activation Status
            If Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value Is DBNull.Value Then
                Rowflag = True
            ElseIf Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value = False Then
                Rowflag = True
            Else
                Rowflag = False
            End If
            If Rowflag = True Then
                Try
                    If e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value = True
                        Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex - 1).Value = False
                    Else
                        Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value = True
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    'If Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value Is DBNull.Value Then
                    'If Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value = True Then
                    'Me.Tbl_Acc_SalaryDataGridView(19, e.RowIndex).Value = frmLogin.UserID
                    'Me.Tbl_Acc_SalaryDataGridView(20, e.RowIndex).Value = IPAddress2
                    'Me.Tbl_Acc_SalaryDataGridView(21, e.RowIndex).Value = frmLogin.LoginId
                    'End If
                    'End If
                Catch ex As Exception

                End Try
            End If
            '
        ElseIf e.ColumnIndex = 16 Then  'Union Fund
            If Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex = 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).Value = 0
                    ElseIf e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex - 1).Value
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '
        ElseIf e.ColumnIndex = 17 Then  'PESSI Status
            If Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).Value Is DBNull.Value Then
                Try
                    If e.RowIndex = 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).Value = True
                    ElseIf e.RowIndex > 0 Then
                        Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex - 1).Value
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf e.ColumnIndex = 18 Then  'Increment Status
            If Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex).Value = "Annual"
            End If
            Try
                If RadioButton2.Checked Then
                    SaveData()
                    Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).Dispose()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If

    End Sub
    Dim Rowflag As Boolean = False
    Private Sub SaveData()
        Try
            Me.Validate()
            Me.Tbl_Acc_SalaryBindingSource.EndEdit()
            Me.Tbl_Acc_SalaryTableAdapter.Update(Me.DSManageSalary.tbl_Acc_Salary)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Hrm_Emp_InfoBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Hrm_Emp_InfoBindingSource.PositionChanged
        LoadSalary()
    End Sub

    Private Sub LoadSalary()
        Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.DSManageSalary.tbl_Acc_Salary, Val(EmpIDLabel1.Text))
        If CardStatusCheckBox.Checked = False Or EmpStatusCheckBox.Checked = False Then
            Me.Tbl_Acc_SalaryDataGridView.ReadOnly = True
            BindingNavigatorAddNewItem.Enabled = False
            SaveToolStripButton.Enabled = False
        Else
            Me.Tbl_Acc_SalaryDataGridView.ReadOnly = False
            BindingNavigatorAddNewItem.Enabled = True
            SaveToolStripButton.Enabled = True
        End If
    End Sub
    Dim Addflag As Boolean = False
    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        Addflag = True
    End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.CellContentClick
        If e.ColumnIndex = 15 Then
            
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Me.Tbl_Acc_SalaryBindingSource.RemoveCurrent()
    End Sub
End Class