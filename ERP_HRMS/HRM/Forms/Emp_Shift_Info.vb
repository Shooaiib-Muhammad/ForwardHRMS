Public Class Emp_Shift_Info


    Private Sub Emp_Shift_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Shift' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_ShiftTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Shift)
        Tbl_HRM_ShiftBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub Tbl_HRM_ShiftBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_ShiftBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_ShiftBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_ShiftBindingSource.EndEdit()
            Me.Tbl_HRM_ShiftTableAdapter.Update(Me.DSHRM.tbl_HRM_Shift)
            Me.Tbl_HRM_ShiftTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Shift)
            Me.Tbl_HRM_ShiftBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Shiftflag = True
            Tbl_HRM_ShiftBindingNavigatorSaveItem.Enabled = False
            CancelToolStripButton.Visible = False
            ShiftNameTextBox.ReadOnly = True
            BindingNavigatorAddNewItem.Enabled = True
            EditToolStripButton.Enabled = True
            ShiftNameTextBox.ReadOnly = False
            ShiftSTDateTimePicker.Enabled = False
            ShiftETDateTimePicker.Enabled = False
            BreakSTDateTimePicker.Enabled = False
            BreakETDateTimePicker.Enabled = False
            StatusCheckBox.Enabled = False
            ComboBox1.Enabled = False
            GroupBox1.Enabled = False
            'FridayBreakStatusCheckBox.Enabled = False
        Catch ex As Exception
            Me.Tbl_HRM_ShiftTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Shift)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tbl_HRM_ShiftBindingNavigatorSaveItem.Enabled = False
            CancelToolStripButton.Visible = False
            ShiftNameTextBox.ReadOnly = True
            BindingNavigatorAddNewItem.Enabled = True
            EditToolStripButton.Enabled = True
            ShiftSTDateTimePicker.Enabled = False
            ShiftETDateTimePicker.Enabled = False
            BreakSTDateTimePicker.Enabled = False
            BreakETDateTimePicker.Enabled = False
            ComboBox1.Enabled = False
            StatusCheckBox.Enabled = False
            GroupBox1.Enabled = False
            'FridayBreakStatusCheckBox.Enabled = False
        End Try
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        BindingNavigatorAddNewItem.Enabled = False
        EditToolStripButton.Enabled = False
        Tbl_HRM_ShiftBindingNavigatorSaveItem.Enabled = True
        ShiftNameTextBox.ReadOnly = False
        ShiftSTDateTimePicker.Enabled = True
        ShiftETDateTimePicker.Enabled = True
        BreakSTDateTimePicker.Enabled = True
        ComboBox1.Enabled = True
        GroupBox1.Enabled = True
        'FridayBreakStatusCheckBox.Enabled = True
        BreakETDateTimePicker.Enabled = True
        StatusCheckBox.Enabled = True
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_ShiftBindingSource.Position
        Tbl_HRM_ShiftTableAdapter.FillBy(DSHRM.tbl_HRM_Shift)
        Tbl_HRM_ShiftBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        ShiftSTDateTimePicker.Enabled = False
        ShiftETDateTimePicker.Enabled = False
        BreakSTDateTimePicker.Enabled = False
        BreakETDateTimePicker.Enabled = False
        StatusCheckBox.Enabled = False
        ComboBox1.Enabled = False
        GroupBox1.Enabled = False
        'FridayBreakStatusCheckBox.Enabled = False
        CancelToolStripButton.Visible = False
        Tbl_HRM_ShiftBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
        ShiftNameTextBox.ReadOnly = True

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        CancelToolStripButton.Visible = True
        GroupBox1.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_ShiftBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        ShiftNameTextBox.ReadOnly = False
        ShiftSTDateTimePicker.Enabled = True
        ShiftETDateTimePicker.Enabled = True
        BreakSTDateTimePicker.Enabled = True
        BreakETDateTimePicker.Enabled = True
        ComboBox1.Enabled = True
        'FridayBreakStatusCheckBox.Enabled = True
        StatusCheckBox.Enabled = True
    End Sub


End Class