Public Class frmContPayment
    Private Sub Tbl_HRM_TranDateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_TranDateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSCont)

    End Sub

    Private Sub frmContPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSCont.View_Emp_Info' table. You can move, or remove it, as needed.
        Me.View_Emp_InfoTableAdapter.Fill(Me.DSCont.View_Emp_Info)
        'TODO: This line of code loads data into the 'DSCont.View_Emp_Info_New' table. You can move, or remove it, as needed.
        Me.View_Emp_Info_NewTableAdapter.Fill(Me.DSCont.View_Emp_Info_New)
        'TODO: This line of code loads data into the 'DSCont.tbl_Cont_Payment' table. You can move, or remove it, as needed.
        Me.Tbl_Cont_PaymentTableAdapter.Fill(Me.DSCont.tbl_Cont_Payment)
        'TODO: This line of code loads data into the 'DSCont.tbl_HRM_TranDate' table. You can move, or remove it, as needed.
        If Me.Tbl_HRM_TranDateTableAdapter.FillBy(Me.DSCont.tbl_HRM_TranDate, Now.Date) > 0 Then
            Me.Tbl_HRM_TranDateTableAdapter.Fill(Me.DSCont.tbl_HRM_TranDate, Now.Date.AddDays(-240))
        Else
            Me.Tbl_HRM_TranDateTableAdapter.Insert(Now.Date)
            Me.Tbl_HRM_TranDateTableAdapter.Fill(Me.DSCont.tbl_HRM_TranDate, Now.Date.AddDays(-240))
        End If
        Me.Tbl_HRM_TranDateBindingSource.MoveLast()

    End Sub

    Private Sub Tbl_Cont_PaymentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Cont_PaymentDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Cont_PaymentDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Cont_PaymentDataGridView.DataError

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.Validate()
            Me.Tbl_Cont_PaymentBindingSource.EndEdit()
            Me.Tbl_Cont_PaymentTableAdapter.Update(Me.DSCont.tbl_Cont_Payment)
            Me.Tbl_Cont_PaymentTableAdapter.Fill(Me.DSCont.tbl_Cont_Payment)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Cont_PaymentDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Cont_PaymentDataGridView.CellEnter
        '#01/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "#
        If e.ColumnIndex = 2 Then
            If Me.Tbl_Cont_PaymentDataGridView(1, e.RowIndex).Value Is DBNull.Value Then
            Else
                If Me.Tbl_Cont_PaymentDataGridView(2, e.RowIndex).Value Is DBNull.Value Then
                    Me.Tbl_Cont_PaymentDataGridView(2, e.RowIndex).Value = CDate("#01/" & CDate(Me.DateNameLabel1.Text).Month & "/" & CDate(Me.DateNameLabel1.Text).Year & "#")
                End If
            End If
            End If
    End Sub

    Private Sub Tbl_Cont_PaymentDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Cont_PaymentDataGridView.EditingControlShowing

        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class