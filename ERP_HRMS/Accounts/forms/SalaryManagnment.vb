
Imports System.ComponentModel

Public Class SalaryManagnment
    Dim FPeriod As String = Nothing
    Dim Obj As New UtilityClass()

    Private Sub SalaryManagnment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Bank' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BankTableAdapter.Fill(Me.DSHRM.tbl_HRM_Bank)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_App_Authority' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_App_AuthorityTableAdapter.Fill(Me.DSHRM.tbl_HRM_App_Authority)
        'TODO: This line of code loads data into the 'ACCDS.tbl_HRM_Card' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_HRM_CardTableAdapter.Fill(Me.ACCDS.tbl_HRM_Card)
        Catch ex As Exception

        End Try

        'TODO: This line of code loads data into the 'ACCDS.tbl_Acc_FinancialPeriod' table. You can move, or remove it, as needed.
        Me.Tbl_Acc_FinancialPeriodTableAdapter.Fill(Me.ACCDS.tbl_Acc_FinancialPeriod)
        Try
            Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.ACCDS.tbl_Acc_Salary)
        Catch ex As Exception

        End Try

        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
        Catch ex As Exception

        End Try

        If frmLogin.DeptID = 5 Then
            BindingNavigatorAddNewItem.Enabled = False
        Else
            BindingNavigatorAddNewItem.Enabled = True
        End If
        LoadData()
        frmEmpManagment.Salaryflag = True

    End Sub
    Private Sub LoadData()
        Try
            Me.DataTable1TableAdapter.Fill(Me.ACCDS.DataTable1, Me.CardNoLabel2.Text)
        Catch ex As Exception
        End Try
        Try
            Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.ACCDS.tbl_Acc_Salary)
        Catch ex As Exception

        End Try

        If CardStatusCheckBox.Checked = True Then
            saveBtn.Enabled = True
        Else
            saveBtn.Enabled = False
        End If

        If frmLogin.DeptID = 3 Or frmLogin.DeptID = 1 Then
            BindingNavigatorAddNewItem.Enabled = True
            Tbl_Acc_SalaryBindingNavigatorSaveItem.Enabled = True
        Else
            BindingNavigatorAddNewItem.Enabled = False
            Tbl_Acc_SalaryBindingNavigatorSaveItem.Enabled = False
        End If
    End Sub
    Private Sub Tbl_Acc_SalaryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub




    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub Tbl_Acc_SalaryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Acc_SalaryBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_Acc_SalaryBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Acc_SalaryBindingSource.EndEdit()
            Me.Tbl_Acc_SalaryTableAdapter.Update(Me.ACCDS.tbl_Acc_Salary)
            Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.ACCDS.tbl_Acc_Salary)

            Me.Tbl_Acc_SalaryBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'BindingNavigatorAddNewItem.Enabled = True

            'CancelToolStripButton.Visible = False

        Catch ex As Exception
            Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.ACCDS.tbl_Acc_Salary)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'BindingNavigatorAddNewItem.Enabled = True

            'CancelToolStripButton.Visible = False

        End Try
    End Sub

    Private Sub BranchNameLabel_Click(sender As Object, e As EventArgs)

    End Sub
    Dim Addflag As Boolean = False
    Private Sub Tbl_Acc_SalaryDataGridView_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Acc_SalaryDataGridView.DataError

    End Sub



    Private Sub BindingNavigatorAddNewItem_Click_1(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        'BindingNavigatorAddNewItem.Enabled = False
        'CancelToolStripButton.Visible = True

        Tbl_Acc_SalaryDataGridView.ReadOnly = False
        Addflag = True

    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs)
        'Dim postion As Integer = Tbl_Acc_SalaryBindingSource.Position
        'Tbl_Acc_SalaryTableAdapter.Fill(ACCDS.tbl_Acc_Salary)
        'Tbl_Acc_SalaryBindingSource.Position = postion
        'BindingNavigatorAddNewItem.Enabled = True
        'CancelToolStripButton.Visible = False
        'BindingNavigatorAddNewItem.Enabled = True


    End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.CellEnter
        Try
            'Tbl_Acc_SalaryDataGridView(6, e.RowIndex).Value = Val(Tbl_Acc_SalaryDataGridView(0, e.RowIndex).Value) + Val(Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value) + Val(Tbl_Acc_SalaryDataGridView(2, e.RowIndex).Value * 26) + (Tbl_Acc_SalaryDataGridView(3, e.RowIndex).Value) + Val(Tbl_Acc_SalaryDataGridView(4, e.RowIndex).Value) + (Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value)



        Catch ex As Exception
        End Try

        Try
            'Tbl_Acc_SalaryDataGridView(12, e.RowIndex).Value = Val(Tbl_Acc_SalaryDataGridView(6, e.RowIndex).Value) - Val(Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value) - Val(Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value) - Val(Tbl_Acc_SalaryDataGridView(9, e.RowIndex).Value) - Val(Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value) - Val(Tbl_Acc_SalaryDataGridView(11, e.RowIndex).Value)
        Catch ex As Exception

        End Try




        If Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).Value Is DBNull.Value Or
  Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value Is DBNull.Value Or
 Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).Value Is DBNull.Value Or
 Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).Value Is DBNull.Value Or
Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value Is DBNull.Value Or
Me.Tbl_Acc_SalaryDataGridView(6, e.RowIndex).Value Is DBNull.Value Or
Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value Is DBNull.Value Or
 Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value Is DBNull.Value Or
   Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).Value Is DBNull.Value Or
Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value Is DBNull.Value Or
Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).Value Is DBNull.Value Or
Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).Value Is DBNull.Value Then


            Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(6, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(20, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).ReadOnly = False
            Me.Tbl_Acc_SalaryDataGridView(14, e.RowIndex).ReadOnly = False
        Else

            Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(6, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(14, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex).ReadOnly = True
            Me.Tbl_Acc_SalaryDataGridView(20, e.RowIndex).ReadOnly = True
        End If
        If e.ColumnIndex = 0 Then

            If Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex - 1).Value
                Catch ex As Exception
                End Try
            End If
        End If
        If e.ColumnIndex = 1 Then
            If Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex - 1).Value

                Catch ex As Exception

                End Try
            End If
        End If
        If e.ColumnIndex = 2 Then
            If Me.Tbl_Acc_SalaryDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(2, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(2, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(2, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If
        End If
        If e.ColumnIndex = 3 Then
            If Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(3, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If
        End If
        If e.ColumnIndex = 4 Then
            If Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(4, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If
        End If
        If e.ColumnIndex = 5 Then
            If Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If
        End If
        'If e.ColumnIndex = 6 Then
        '    If Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
        '        Try
        '            Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).ReadOnly = False
        '            'Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex - 1).Value
        '        Catch ex As Exception

        '        End Try
        '    Else
        '        Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).ReadOnly = False
        '    End If
        'End If
        If e.ColumnIndex = 7 Then
            If Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(7, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If
        End If
        If e.ColumnIndex = 8 Then
            If Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(8, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If
        End If
        If e.ColumnIndex = 9 Then
            If Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(9, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If
        End If
        If e.ColumnIndex = 10 Then
            If Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If

        End If
        If e.ColumnIndex = 11 Then
            If Me.Tbl_Acc_SalaryDataGridView(11, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(11, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(11, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(11, e.RowIndex - 1).Value
                Catch ex As Exception

                End Try
            End If

        End If
        'If e.ColumnIndex = 12 Then
        '    If Me.Tbl_Acc_SalaryDataGridView(12, e.RowIndex).Value Is DBNull.Value Then
        '        Try
        '            Me.Tbl_Acc_SalaryDataGridView(12, e.RowIndex).ReadOnly = True
        '            Me.Tbl_Acc_SalaryDataGridView(12, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(12, e.RowIndex - 1).Value
        '        Catch ex As Exception

        '        End Try

        '    End If
        'End If
        If e.ColumnIndex = 13 Then
            If Me.Tbl_Acc_SalaryDataGridView(13, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(13, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(13, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(13, e.RowIndex - 1).Value
                    '      
                Catch ex As Exception

                End Try

            End If
        End If
        If e.ColumnIndex = 14 Then
            If Me.Tbl_Acc_SalaryDataGridView(14, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(14, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(14, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(14, e.RowIndex - 1).Value
                    '  
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If
        If e.ColumnIndex = 15 Then
            If Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value Is DBNull.Value Then
                Try

                    FPeriod = Obj.ReturnFP(Now.Month, Now.Year)
                    Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(15, e.RowIndex).Value = FPeriod
                Catch ex As Exception

                End Try

            End If
        End If
        If e.ColumnIndex = 16 Then
            If Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(16, e.RowIndex).Value = Now.Date
                Catch ex As Exception

                End Try

            End If
            If Me.Tbl_Acc_SalaryDataGridView(22, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(22, e.RowIndex).Value = frmLogin.UserID
                Catch ex As Exception

                End Try

            End If

        End If




        If e.ColumnIndex = 17 Then
            If Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).ReadOnly = False
                    Me.Tbl_Acc_SalaryDataGridView(17, e.RowIndex).Value = Now.Date
                Catch ex As Exception

                End Try

            End If
        End If
        If e.ColumnIndex = 18 Then
            If Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex).ReadOnly = True
                Try

                    Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex - 1).Value = False
                    Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex).Value = True

                Catch ex As Exception
                    Me.Tbl_Acc_SalaryDataGridView(18, e.RowIndex).Value = True
                End Try

            End If
            End If
        'If e.ColumnIndex = 19 Then
        '    If Me.Tbl_Acc_SalaryDataGridView(19, e.RowIndex).Value Is DBNull.Value Then
        '        Try
        '            Me.Tbl_Acc_SalaryDataGridView(19, e.RowIndex).ReadOnly = False
        '            Me.Tbl_Acc_SalaryDataGridView(19, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(19, e.RowIndex - 1).Value
        '        Catch ex As Exception

        '        End Try
        '    Else
        '        Me.Tbl_Acc_SalaryDataGridView(19, e.RowIndex).ReadOnly = True
        '    End If
        'End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Me.Tbl_HRM_CardBindingSource.Filter = "CardStatus=True"
        LoadData()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Me.Tbl_HRM_CardBindingSource.Filter = "CardStatus=false"
        LoadData()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If Me.Tbl_HRM_CardBindingSource.Filter = "CardStatus=false" Then

            saveBtn.Enabled = False
        Else
            saveBtn.Enabled = True

        End If
        Me.Tbl_HRM_CardBindingSource.RemoveFilter()
        LoadData()

    End Sub

    Private Sub Tbl_HRM_CardBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_CardBindingSource.PositionChanged
        LoadData()


        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, Me.CardNoLabel2.Text)
        Catch ex As Exception

        End Try



    End Sub

    Private Sub DateOfPermanentLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccJobTypeComboBox_DockChanged(sender As Object, e As EventArgs) Handles AccJobTypeComboBox.DockChanged
        Me.Tbl_HRM_Emp_InfoBindingSource.EndEdit()
        Me.Tbl_HRM_Emp_InfoTableAdapter.Update(Me.DSHRM.tbl_HRM_Emp_Info)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, CType(CardNoToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSHRM.tbl_HRM_Emp_Info, CType(CardNoToolStripTextBox.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Acc_SalaryDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Try
            Me.DataTable1TableAdapter.UpdateQuery(AccJobTypeComboBox.SelectedItem, BankNameComboBox.SelectedValue, BankAccountNOTextBox.Text, EmailAddressTextBox.Text, EmpIDLabel1.Text)
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EmpName_KeyDown(sender As Object, e As KeyEventArgs) Handles EmpName.KeyDown
        If e.KeyCode = Keys.Enter Then
            'FilterRecords(0)
            If EmpName.Text.Length = 0 Then
                MsgBox("Invalid String was Given for Search")
            Else
                FilterRecords(0, EmpName.Text)
            End If

            'Me.DataTable1BindingSource.Filter = "Name Like '%" & Me.EmpName.Text & "%'"

            EmpName.Clear()
            CMSEmpInfo.Hide()
        End If
    End Sub

    Private Sub Navigation_EmpInfoHead()
        Dim CardValue As Integer = 0

        If DataTable1BindingNavigator.BindingSource.Equals(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource) Then
            If CardNoLabel3.Text <> "" Then
                CardValue = Val(CardNoLabel3.Text)
            End If
        Else
            If CardNoLabel2.Text <> "" Then
                CardValue = Val(CardNoLabel2.Text)
            End If
        End If
        If Me.DataTable1TableAdapter.Fill(Me.ACCDS.DataTable1, CardValue) > 0 Then
            Me.DataTable1BindingSource.Position = Me.DataTable1BindingSource.Count
        End If

    End Sub
    Private Sub FilterRecords(ByVal Flag As Integer, ByVal SearchingString As String)
        Dim Res As Integer = 0
        If DataTable1BindingNavigator.BindingSource.Equals(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource) Then
            MsgBox("For a New Search, Refresh Data")
        Else
            If Flag = 0 Then
                Res = Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter1.Fill(Me.ACCDS.View_Rpt_HR_EmpData_ActiveNonActive, SearchingString)
                'CMSEmpInfo.Text = ""
                'CMSEmpInfo.Hide()
            ElseIf Flag = 1 Then
                Res = Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter1.FillBy(Me.ACCDS.View_Rpt_HR_EmpData_ActiveNonActive, SearchingString)
            ElseIf Flag = 2 Then
                'Res = Me.View_Rpt_HR_EmpData_ActiveNonActiveTableAdapter.FillBy1(Me.DSHRM.View_Rpt_HR_EmpData_ActiveNonActive, SearchingString)
                'CMSSearchNIC.Text = ""
                'CMSSearchNIC.Hide()
            End If
            If Res = 0 Then
                MsgBox("No Match Found")
            Else
                Me.Tbl_HRM_CardTableAdapter.FillBy(Me.ACCDS.tbl_HRM_Card, Val(CardNoLabel3.Text))
                DataTable1BindingNavigator.BindingSource = Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource
                'LoadAtFormLoad()
                Navigation_EmpInfoHead()
                'Navigation_EmpInfo(Val(EmpIDLabel2.Text))
                Try
                    Me.DataTable1TableAdapter.Fill(Me.ACCDS.DataTable1, Me.EmpIDLabel2.Text)
                Catch ex As Exception

                End Try

            End If
        End If

    End Sub

    Private Sub RefreshNow()
        Dim LocalCard As Integer
        If DataTable1BindingNavigator.BindingSource.Equals(Me.View_Rpt_HR_EmpData_ActiveNonActiveBindingSource) Then
            LocalCard = Val(CardNoLabel3.Text)
        Else
            LocalCard = Val(CardNoLabel2.Text)
        End If
        Try
            DataTable1BindingNavigator.BindingSource = Me.Tbl_HRM_CardBindingSource
            Me.Tbl_HRM_CardTableAdapter.Fill(Me.ACCDS.tbl_HRM_Card)
            Navigation_EmpInfoHead()
            'If Me.Tbl_Hrm_Emp_Inf       o1TableAdapter.FillBy(Me.DSEmpData.tbl_Hrm_Emp_Info1, LocalCard) > 0 Then
            '    Navigation_EmpInfo(Me.Tbl_HRM_Emp_InfoTableAdapter.MaxEmpID(LocalCard))
            'End If
            Me.CardNoComboBox.SelectedValue = LocalCard
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub RemoveFilterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveFilterToolStripMenuItem1.Click
        RefreshNow()
    End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.RowEnter
        'Try
        '    Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).Value + Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value - +Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value
        'Catch ex As Exception

        'End Try

    End Sub

    'Private Sub Tbl_Acc_SalaryDataGridView_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.RowLeave
    '    Try
    '        Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).Value + Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value - +Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub Tbl_Acc_SalaryDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles Tbl_Acc_SalaryDataGridView.RowsAdded
    '    Try
    '        Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).Value + Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value - +Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.CellValueChanged
        'Try
        '    Me.Tbl_Acc_SalaryDataGridView(10, e.RowIndex).Value = Me.Tbl_Acc_SalaryDataGridView(0, e.RowIndex).Value + Me.Tbl_Acc_SalaryDataGridView(1, e.RowIndex).Value - Me.Tbl_Acc_SalaryDataGridView(5, e.RowIndex).Value
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub Tbl_Acc_SalaryDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Acc_SalaryDataGridView.CellEndEdit

    End Sub

    Private Sub CardNoLabel2_Click(sender As Object, e As EventArgs) Handles CardNoLabel2.Click

    End Sub

    Private Sub CardNoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CardNoComboBox.SelectedIndexChanged

    End Sub

    Private Sub EmpIDLabel2_Click(sender As Object, e As EventArgs) Handles EmpIDLabel2.Click

    End Sub

    Private Sub EmpName_Click(sender As Object, e As EventArgs) Handles EmpName.Click

    End Sub
End Class