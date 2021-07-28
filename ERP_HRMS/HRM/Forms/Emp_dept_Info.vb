Public Class Emp_dept_Info
    Private Sub Emp_dept_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Dept)
        Tbl_HRM_DeptBindingNavigatorSaveItem.Enabled = False
        Tbl_HRM_SectionBindingNavigatorSaveItem.Enabled = False


        Dim s As String = "one,two,three"

        ' Split string based on comma
        Dim words As String() = s.Split(New Char() {","c})

        ' Use For Each loop over words and display them

        Dim word As String
        For Each word In words
            Console.WriteLine(word)
        Next

    End Sub
    Private Sub Tbl_HRM_SectionDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_SectionDataGridView.CellContentClick
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        CancelToolStripButton.Visible = True
        ToolStripButton1.Enabled = False
        Tbl_HRM_SectionBindingNavigatorSaveItem.Enabled = True
        EditToolStripButton.Enabled = False
        Tbl_HRM_SectionDataGridView.ReadOnly = False
    End Sub

    Private Sub Tbl_HRM_SectionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_HRM_SectionBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_SectionBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_SectionBindingSource.EndEdit()
            Me.Tbl_HRM_SectionTableAdapter.Update(Me.DSHRM.tbl_HRM_Section)
            Me.Tbl_HRM_SectionTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Section)
            Me.Tbl_HRM_SectionBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Sectionflag = True
            Tbl_HRM_SectionBindingNavigatorSaveItem.Enabled = False
            CancelToolStripButton.Visible = False
            Tbl_HRM_SectionDataGridView.ReadOnly = True
            ToolStripButton1.Enabled = True
            EditToolStripButton.Enabled = True
        Catch ex As Exception
            Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tbl_HRM_SectionBindingNavigatorSaveItem.Enabled = False
            CancelToolStripButton.Visible = False
            Tbl_HRM_SectionDataGridView.ReadOnly = True
            ToolStripButton1.Enabled = True
            EditToolStripButton.Enabled = True
        End Try
    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        ToolStripButton1.Enabled = False
        Tbl_HRM_SectionDataGridView.ReadOnly = False
        EditToolStripButton.Enabled = False
        Tbl_HRM_SectionBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_SectionBindingSource.Position
        Tbl_HRM_SectionTableAdapter.FillBy(DSHRM.tbl_HRM_Section)
        Tbl_HRM_SectionBindingSource.Position = postion
        Tbl_HRM_SectionDataGridView.ReadOnly = True
        ToolStripButton1.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_SectionBindingNavigatorSaveItem.Enabled = False
        EditToolStripButton.Enabled = True
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        StatusCheckBox.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_DeptBindingNavigatorSaveItem.Enabled = True
        ToolStripButton2.Enabled = False
        HODNameTextBox.ReadOnly = False
        ToolStripButton7.Visible = True
        DeptNameTextBox.ReadOnly = False
    End Sub

    Private Sub Tbl_HRM_DeptBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_DeptBindingNavigatorSaveItem.Click
        Try
            Dim s As String = HODNameTextBox.Text
            Dim parts As String() = s.Split(New Char() {","c})
            Dim part As String

            For Each part In parts
                frmEmpManagment.HODNameComboBox.Items.Add(part)
                'ListBox1.Items.Add(part(0))
                'MsgBox(part(0))
            Next
        Catch ex As Exception
        End Try
        Dim j As Int16 = Me.Tbl_HRM_DeptBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_DeptBindingSource.EndEdit()
            Me.Tbl_HRM_DeptTableAdapter.Update(Me.DSHRM.tbl_HRM_Dept)
            Me.Tbl_HRM_DeptTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Dept)
            Me.Tbl_HRM_DeptBindingSource.Position = j



            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Deptflag = True
            Tbl_HRM_DeptBindingNavigatorSaveItem.Enabled = False
            StatusCheckBox.Enabled = False
            CancelToolStripButton.Visible = False
            BindingNavigatorAddNewItem.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton7.Visible = False
            HODNameTextBox.ReadOnly = True

            DeptNameTextBox.ReadOnly = True


        Catch ex As Exception
            Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Tbl_HRM_DeptBindingNavigatorSaveItem.Enabled = False
            StatusCheckBox.Enabled = False
            CancelToolStripButton.Visible = False
            BindingNavigatorAddNewItem.Enabled = True
            ToolStripButton2.Enabled = True
            ToolStripButton7.Visible = False
            HODNameTextBox.ReadOnly = True

            DeptNameTextBox.ReadOnly = True
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ToolStripButton2.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
        HODNameTextBox.ReadOnly = False
        ToolStripButton7.Visible = True
        DeptNameTextBox.ReadOnly = False
        StatusCheckBox.Enabled = True
        Tbl_HRM_DeptBindingNavigatorSaveItem.Enabled = True

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim postion As Integer = Tbl_HRM_DeptBindingSource.Position
        Tbl_HRM_DeptTableAdapter.FillBy(DSHRM.tbl_HRM_Dept)
        Tbl_HRM_DeptBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        DeptNameTextBox.ReadOnly = True
        HODNameTextBox.ReadOnly = True
        ToolStripButton7.Visible = False
        Tbl_HRM_DeptBindingNavigatorSaveItem.Enabled = False
        ToolStripButton2.Enabled = True
        StatusCheckBox.Enabled = False
    End Sub

    Private Sub Tbl_HRM_SectionDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_SectionDataGridView.DataError
    End Sub

    Private Sub HODNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HODNameTextBox.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Tbl_HRM_SectionDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_SectionDataGridView.CellEnter

    End Sub
End Class