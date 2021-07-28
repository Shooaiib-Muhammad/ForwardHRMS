Public Class Emp_Qualfication_Info
    Private Sub Emp_Qualfication_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Qualfication' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_QualficationTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Qualfication)
        Tbl_HRM_QualficationBindingNavigatorSaveItem.Enabled = False
    End Sub
    Private Sub Tbl_HRM_QualficationBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_QualficationBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_QualficationBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_QualficationBindingSource.EndEdit()
            Me.Tbl_HRM_QualficationTableAdapter.Update(Me.DSHRM.tbl_HRM_Qualfication)
            Me.Tbl_HRM_QualficationTableAdapter.FillBy(Me.DSHRM.tbl_HRM_Qualfication)
            Me.Tbl_HRM_QualficationBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Qualficationflag = True
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            AddToolStripButton.Enabled = True
            Tbl_HRM_QualficationBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_QualficationDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_HRM_QualficationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Qualfication)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BindingNavigatorAddNewItem.Enabled = True
            CancelToolStripButton.Visible = False
            AddToolStripButton.Enabled = True
            Tbl_HRM_QualficationBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_QualficationDataGridView.ReadOnly = True
        End Try
    End Sub
    Private Sub Tbl_HRM_QualficationDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_QualficationDataGridView.CellContentClick

    End Sub
    Private Sub Tbl_HRM_QualficationDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_QualficationDataGridView.DataError

    End Sub
    Private Sub AddToolStripButton_Click(sender As Object, e As EventArgs) Handles AddToolStripButton.Click
        BindingNavigatorAddNewItem.Enabled = False
        AddToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_QualficationBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_QualficationDataGridView.ReadOnly = False
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_QualficationBindingNavigatorSaveItem.Enabled = True
        AddToolStripButton.Enabled = False
        CancelToolStripButton.Visible = True
        Tbl_HRM_QualficationDataGridView.ReadOnly = False
    End Sub
    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_HRM_QualficationBindingSource.Position
        Tbl_HRM_QualficationTableAdapter.FillBy(DSHRM.tbl_HRM_Qualfication)
        Tbl_HRM_QualficationBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_HRM_QualficationBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_QualficationDataGridView.ReadOnly = True
        Tbl_HRM_QualficationBindingNavigatorSaveItem.Enabled = False
        AddToolStripButton.Enabled = True
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        Tbl_HRM_QualficationBindingNavigatorSaveItem.Enabled = True
    End Sub

    Private Sub Tbl_HRM_QualficationDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_QualficationDataGridView.CellEnter
        Me.Tbl_HRM_QualficationDataGridView(0, e.RowIndex).ReadOnly = True
        Try
            Me.Tbl_HRM_QualficationDataGridView(0, e.RowIndex).Value = Me.Tbl_HRM_QualficationDataGridView(0, e.RowIndex - 1).Value + 1
        Catch ex As Exception
            Me.Tbl_HRM_QualficationDataGridView(0, e.RowIndex).Value = 1
        End Try
    End Sub
End Class