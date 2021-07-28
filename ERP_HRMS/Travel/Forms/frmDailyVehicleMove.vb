Public Class frmDailyVehicleMove

    Private Sub Tbl_Sec_Vehicle_HeadBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Sec_Vehicle_HeadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSMisSec)

    End Sub

    Private Sub frmDailyVehicleMove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Vehicle' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_VehicleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle)
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Driver' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_DriverTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Driver)
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Vehicle_Enteries' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DSMisSec.tbl_Sec_Vehicle_Head' table. You can move, or remove it, as needed.
        Me.Tbl_Sec_Vehicle_HeadTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle_Head, Now.Date.AddDays(-12))
        Me.Tbl_Sec_Vehicle_HeadBindingSource.MoveLast()
        Try
            Me.Tbl_Sec_Vehicle_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle_Enteries, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Dim i As Integer = Me.Tbl_Sec_Vehicle_EnteriesBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_Sec_Vehicle_EnteriesBindingSource.EndEdit()
            Me.Tbl_Sec_Vehicle_EnteriesTableAdapter.Update(Me.DSMisSec.tbl_Sec_Vehicle_Enteries)
            Try
                Me.Tbl_Sec_Vehicle_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle_Enteries, Me.DayNoLabel1.Text)
            Catch ex As Exception
            End Try
            Me.Tbl_Sec_Vehicle_EnteriesBindingSource.Position = i
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CancelToolStripButton.Visible = False
        BindingNavigatorDeleteItem.Enabled = True
        'Tbl_Sec_Vehicle_EnteriesDataGridView.ReadOnly = True
        EditToolStripButton.Enabled = True
        SaveToolStripButton.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
    End Sub

    Private Sub Tbl_Sec_Vehicle_EnteriesDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_Vehicle_EnteriesDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Sec_Vehicle_EnteriesDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_Vehicle_EnteriesDataGridView.CellEnter
        If e.ColumnIndex = 4 Then
            If Me.Tbl_Sec_Vehicle_EnteriesDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Sec_Vehicle_EnteriesDataGridView(4, e.RowIndex).Value = Now
            End If
        End If
        If e.ColumnIndex = 6 Then
            If Me.Tbl_Sec_Vehicle_EnteriesDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Me.Tbl_Sec_Vehicle_EnteriesDataGridView(6, e.RowIndex).Value = Now
            End If
        End If
        If e.ColumnIndex >= 8 Then
            Try
                Me.Tbl_Sec_Vehicle_EnteriesDataGridView(8, e.RowIndex).Value = CDbl(Me.Tbl_Sec_Vehicle_EnteriesDataGridView(7, e.RowIndex).Value) - CDbl(Me.Tbl_Sec_Vehicle_EnteriesDataGridView(5, e.RowIndex).Value)
            Catch ex As Exception
            End Try
        End If
        
    End Sub

    Private Sub Tbl_Sec_Vehicle_EnteriesDataGridView_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_Vehicle_EnteriesDataGridView.CellValueChanged
        'If e.ColumnIndex >= 8 Then
        Try
            'Me.Tbl_Sec_Vehicle_EnteriesDataGridView(8, e.RowIndex).Value = CDbl(Me.Tbl_Sec_Vehicle_EnteriesDataGridView(5, e.RowIndex).Value) - CDbl(Me.Tbl_Sec_Vehicle_EnteriesDataGridView(7, e.RowIndex).Value)
        Catch ex As Exception
        End Try
        'End If
    End Sub

    Private Sub Tbl_Sec_Vehicle_EnteriesDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Sec_Vehicle_EnteriesDataGridView.DataError

    End Sub

    Private Sub Tbl_Sec_Vehicle_EnteriesDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Sec_Vehicle_EnteriesDataGridView.EditingControlShowing

        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If

    End Sub

    Private Sub Tbl_Sec_Vehicle_HeadBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Sec_Vehicle_HeadBindingSource.PositionChanged
        Try
            Me.Tbl_Sec_Vehicle_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle_Enteries, Me.DayNoLabel1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Sec_Vehicle_EnteriesDataGridView_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Sec_Vehicle_EnteriesDataGridView.RowLeave
        Try
            Me.ValidateChildren()
            Me.Tbl_Sec_Vehicle_EnteriesBindingSource.EndEdit()
            Me.Tbl_Sec_Vehicle_EnteriesTableAdapter.Update(Me.DSMisSec.tbl_Sec_Vehicle_Enteries)
            'Try
            '    Me.Tbl_Sec_Vehicle_EnteriesTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle_Enteries, Me.DayNoLabel1.Text)
            'Catch ex As Exception
            'End Try
            'Me.Tbl_Sec_Vehicle_EnteriesBindingSource.Position = i
            'MsgBox("Record Saved Successfully")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        'CancelToolStripButton.Visible = True
        'EditToolStripButton.Enabled = False
        'SaveToolStripButton.Enabled = True
        'EditToolStripButton.Enabled = False
        'Tbl_Sec_Vehicle_EnteriesDataGridView.ReadOnly = False
        'BindingNavigatorDeleteItem.Enabled = False
        'BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripButton.Click
        'CancelToolStripButton.Visible = True
        'BindingNavigatorDeleteItem.Enabled = False
        'Tbl_Sec_Vehicle_EnteriesDataGridView.ReadOnly = False
        'EditToolStripButton.Enabled = False
        'SaveToolStripButton.Enabled = True
        'BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelToolStripButton.Click
        'Dim postion As Integer = Tbl_Sec_Vehicle_EnteriesBindingSource.Position
        'Tbl_Sec_VehicleTableAdapter.Fill(Me.DSMisSec.tbl_Sec_Vehicle)
        'Tbl_Sec_Vehicle_EnteriesBindingSource.Position = postion
        'Tbl_Sec_Vehicle_EnteriesDataGridView.ReadOnly = True
        'BindingNavigatorDeleteItem.Enabled = True
        'CancelToolStripButton.Visible = False
        'SaveToolStripButton.Enabled = False
        'EditToolStripButton.Enabled = True
        'BindingNavigatorAddNewItem.Enabled = True
    End Sub
End Class