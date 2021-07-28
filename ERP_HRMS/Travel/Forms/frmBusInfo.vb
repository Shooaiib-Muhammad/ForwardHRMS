Public Class frmBusInfo

    Private Sub Tbl_Bus_OwnerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.Tbl_Bus_OwnerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSBusInfo)

    End Sub

    Private Sub frmBusInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Tbl_Bus_Route_InfoTableAdapter.Fill(Me.DSBusInfo.tbl_Bus_Route_Info)
        Me.Tbl_Bus_Comp_InfoTableAdapter.Fill(Me.DSBusInfo.tbl_Bus_Comp_Info)
        Me.Tbl_Bus_OwnerTableAdapter.Fill(Me.DSBusInfo.tbl_Bus_Owner)
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        Try
            Me.ValidateChildren()
            Me.Tbl_Bus_Comp_InfoBindingSource.EndEdit()
            Me.Tbl_Bus_Comp_InfoTableAdapter.Update(Me.DSBusInfo.tbl_Bus_Comp_Info)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Bus_Comp_InfoDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_Comp_InfoDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Bus_Comp_InfoDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bus_Comp_InfoDataGridView.DataError

    End Sub

    Private Sub Tbl_Bus_Comp_InfoDataGridView_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles Tbl_Bus_Comp_InfoDataGridView.EditingControlShowing
        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub
End Class