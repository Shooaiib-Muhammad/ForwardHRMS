Public Class frmAutoCompleteCombo

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength >= 1 Then
            If Me.Tbl_Bus_OwnerTableAdapter.FillBy(Me.DSBusInfo.tbl_Bus_Owner, Me.TextBox1.Text) > 0 Then
                ComboBox1.DataSource = Me.DSBusInfo.tbl_Bus_Owner
                ComboBox1.DisplayMember = Me.DSBusInfo.tbl_Bus_Owner.OwnerNameColumn.ColumnName
                ComboBox1.ValueMember = Me.DSBusInfo.tbl_Bus_Owner.OwnerIDColumn.ColumnName
                ListBox1.DataSource = Me.DSBusInfo.tbl_Bus_Owner
                ListBox1.DisplayMember = Me.DSBusInfo.tbl_Bus_Owner.OwnerNameColumn.ColumnName
                ListBox1.ValueMember = Me.DSBusInfo.tbl_Bus_Owner.OwnerIDColumn.ColumnName

            Else
                ComboBox1.DataSource = Nothing
                ComboBox1.DisplayMember = Nothing
                ComboBox1.ValueMember = Nothing
                ListBox1.DataSource = Nothing
                ListBox1.DisplayMember = Nothing
                ListBox1.ValueMember = Nothing
            End If
        ElseIf TextBox1.TextLength = 0 Then
            ComboBox1.DataSource = Nothing
            ComboBox1.DisplayMember = Nothing
            ComboBox1.ValueMember = Nothing
            ListBox1.DataSource = Nothing
            ListBox1.DisplayMember = Nothing
            ListBox1.ValueMember = Nothing
        End If
    End Sub

    Private Sub Tbl_Bus_OwnerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Bus_OwnerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSBusInfo)

    End Sub

    Private Sub frmAutoCompleteCombo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBusInfo.tbl_Bus_Owner' table. You can move, or remove it, as needed.
        'Me.Tbl_Bus_OwnerTableAdapter.Fill(Me.DSBusInfo.tbl_Bus_Owner)

    End Sub
End Class