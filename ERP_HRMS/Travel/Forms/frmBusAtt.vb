Public Class frmBusAtt

    Private Sub Tbl_Bus_AttBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Bus_AttBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Bus_AttBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSBusAtt)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmBusAtt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Bus_Comp_Info1TableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Comp_Info1)
        Me.Tbl_Bus_Comp_InfoTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Comp_Info)
        Try
            Me.Tbl_Bus_AttTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Tbl_Bus_AttDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_AttDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Bus_AttDataGridView_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_AttDataGridView.CellEnter
        If e.ColumnIndex >= 3 Then
            If Me.Tbl_Bus_AttDataGridView(3, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Bus_AttDataGridView(3, e.RowIndex).Value = Me.Tbl_Bus_AttDataGridView(3, e.RowIndex - 1).Value
                Catch ex As Exception
                    Me.Tbl_Bus_AttDataGridView(3, e.RowIndex).Value = Now.Date
                End Try
            End If
            If Me.Tbl_Bus_AttDataGridView(4, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Bus_AttDataGridView(4, e.RowIndex).Value = Me.Tbl_Bus_AttDataGridView(4, e.RowIndex - 1).Value
                Catch ex As Exception
                    Me.Tbl_Bus_AttDataGridView(4, e.RowIndex).Value = Now
                End Try
            End If

            If Me.Tbl_Bus_AttDataGridView(6, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Bus_AttDataGridView(6, e.RowIndex).Value = Me.DSBusAtt.tbl_Bus_Comp_Info.Rows(0).Item("SStartTime")
                Catch ex As Exception
                    'Me.Tbl_Bus_AttDataGridView(4, e.RowIndex).Value = Now
                End Try
            End If

            If Me.Tbl_Bus_AttDataGridView(7, e.RowIndex).Value Is DBNull.Value Then
                Try
                    Me.Tbl_Bus_AttDataGridView(7, e.RowIndex).Value = Me.DSBusAtt.tbl_Bus_Comp_Info.Rows(0).Item("SEndTime")
                Catch ex As Exception
                    'Me.Tbl_Bus_AttDataGridView(4, e.RowIndex).Value = Now
                End Try
            End If
        End If
    End Sub

    Private Sub Tbl_Bus_AttDataGridView_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_AttDataGridView.CellLeave
        'If e.ColumnIndex > 0 Then
        '    Try
        '        Me.Tbl_Bus_Comp_Info_DAtaTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Comp_Info_DAta, Val(Me.Tbl_Bus_AttDataGridView(1, e.RowIndex).Value))
        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Private Sub Tbl_Bus_AttDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bus_AttDataGridView.DataError

    End Sub

    Private Sub Tbl_Bus_AttDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Bus_AttDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub Tbl_Bus_AttDataGridView_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_AttDataGridView.RowEnter
        If Me.Tbl_Bus_AttDataGridView(1, e.RowIndex).Value IsNot DBNull.Value Then
            Try
                Me.Tbl_Bus_Comp_Info_DAtaTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Comp_Info_DAta, Val(Me.Tbl_Bus_AttDataGridView(1, e.RowIndex).Value))
            Catch ex As Exception
            End Try
        End If
        '    Try
        '        Me.Tbl_Bus_Comp_Info_DAtaTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Comp_Info_DAta, Val(Me.Tbl_Bus_AttDataGridView(1, e.RowIndex).Value))
        '    Catch ex As Exception

        '    End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        If RadioButton1.Checked Then
            Try
                Me.Tbl_Bus_AttTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker1.Text)
            Catch ex As Exception
            End Try
        End If
      
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If RadioButton3.Checked Then
            Try
                Me.Tbl_Bus_AttTableAdapter.FillBy1(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text, CardNoComboBox.SelectedValue)
            Catch ex As Exception
            End Try
        ElseIf RadioButton4.Checked Then
            Try
                Me.Tbl_Bus_AttTableAdapter.FillBy2(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text)
            Catch ex As Exception
            End Try
        End If
       
    End Sub

    Private Sub Tbl_Bus_Comp_Info1BindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Bus_Comp_Info1BindingSource.PositionChanged
        If RadioButton2.Checked Then
            Try
                Me.Tbl_Bus_AttTableAdapter.FillBy(Me.DSBusAtt.tbl_Bus_Att, Me.CardNoComboBox.SelectedValue)
            Catch ex As Exception

            End Try
        ElseIf RadioButton3.Checked Then
            Try
                Me.Tbl_Bus_AttTableAdapter.FillBy1(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text, CardNoComboBox.SelectedValue)
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub EnableDisable(ByVal dt As Boolean, ByVal Card As Boolean, ByVal dt1 As Boolean, ByVal dt2 As Boolean)
        Me.DateTimePicker1.Enabled = dt
        Me.CardNoComboBox.Enabled = Card
        Me.DateTimePicker2.Enabled = dt1
        Me.DateTimePicker3.Enabled = dt2
    End Sub
    
    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        If RadioButton3.Checked Then
            Try
                Me.Tbl_Bus_AttTableAdapter.FillBy1(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text, CardNoComboBox.SelectedValue)
            Catch ex As Exception
            End Try
        ElseIf RadioButton4.Checked Then
            Try
                Me.Tbl_Bus_AttTableAdapter.FillBy2(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text)
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        EnableDisable(True, False, False, False)
        Try
            Me.Tbl_Bus_AttTableAdapter.Fill(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker1.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        EnableDisable(False, True, False, False)
        Try
            Me.Tbl_Bus_AttTableAdapter.FillBy(Me.DSBusAtt.tbl_Bus_Att, Me.CardNoComboBox.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        EnableDisable(False, True, True, True)
        Try
            Me.Tbl_Bus_AttTableAdapter.FillBy1(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text, CardNoComboBox.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rbtShowByDateRange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        EnableDisable(False, False, True, True)
        Try
            Me.Tbl_Bus_AttTableAdapter.FillBy2(Me.DSBusAtt.tbl_Bus_Att, Me.DateTimePicker2.Text, Me.DateTimePicker3.Text)
        Catch ex As Exception
        End Try
    End Sub
End Class