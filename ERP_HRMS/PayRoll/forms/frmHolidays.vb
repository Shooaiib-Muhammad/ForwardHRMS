Public Class frmHolidays
    Private Sub Tbl_Hrm_HolidaysBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Hrm_HolidaysBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Hrm_HolidaysBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSPayRoll)
            MsgBox("Record Saved")
            Tbl_Hrm_HolidaysDataGridView.ReadOnly = True
            CancelToolStripButton.Visible = False
            Tbl_Hrm_HolidaysBindingNavigatorSaveItem.Enabled = True
            EditToolStripButton.Enabled = True
            BindingNavigatorAddNewItem.Enabled = True
            Me.Tbl_Hrm_HolidaysTableAdapter.Fill(Me.DSPayRoll.tbl_Hrm_Holidays)
        Catch ex As Exception
            MsgBox("Record Not Saved")
        End Try

    End Sub

    Private Sub frmHolidays_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSPayRoll.tbl_Hrm_Holidays' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_HolidaysTableAdapter.Fill(Me.DSPayRoll.tbl_Hrm_Holidays)

    End Sub

    Private Sub Tbl_Hrm_HolidaysDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_HolidaysDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Hrm_HolidaysDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Hrm_HolidaysDataGridView.DataError

    End Sub

    Private Sub Tbl_Hrm_HolidaysDataGridView_ControlAdded(sender As Object, e As ControlEventArgs) Handles Tbl_Hrm_HolidaysDataGridView.ControlAdded

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Tbl_Hrm_HolidaysDataGridView.ReadOnly = False
        CancelToolStripButton.Visible = True
        Tbl_Hrm_HolidaysBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        Tbl_Hrm_HolidaysDataGridView.ReadOnly = False
        CancelToolStripButton.Visible = True
        Tbl_Hrm_HolidaysBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Hrm_HolidaysBindingSource.Position
        Tbl_Hrm_HolidaysTableAdapter.Fill(DSPayRoll.tbl_Hrm_Holidays)
        Tbl_Hrm_HolidaysBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        Tbl_Hrm_HolidaysDataGridView.ReadOnly = True
        CancelToolStripButton.Visible = False
        Tbl_Hrm_HolidaysBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True



    End Sub

    Private Sub Tbl_Hrm_HolidaysDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Hrm_HolidaysDataGridView.CellEnter
        If e.ColumnIndex = 1 Then

            If Me.Tbl_Hrm_HolidaysDataGridView(1, e.RowIndex).Value Is DBNull.Value Then

                Try
                    Me.Tbl_Hrm_HolidaysDataGridView(1, e.RowIndex).Value = Now.Date
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub
End Class