Public Class emp_card_info
    Private Sub Tbl_HRM_CardBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_HRM_CardBindingNavigatorSaveItem.Click
        Dim j As Int16 = Me.Tbl_HRM_CardBindingSource.Position
        Try
            Me.ValidateChildren()
            Me.Tbl_HRM_CardBindingSource.EndEdit()
            Me.Tbl_HRM_CardTableAdapter.Update(Me.DSHRM.tbl_HRM_Card)
            Me.Tbl_HRM_CardTableAdapter.FillBy1(Me.DSHRM.tbl_HRM_Card)
            Me.Tbl_HRM_CardBindingSource.Position = j
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmEmpManagment.Cardflag = True
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorCancel.Visible = False
            Tbl_HRM_CardBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_CardDataGridView.ReadOnly = True
        Catch ex As Exception
            Me.Tbl_HRM_CardTableAdapter.FillBy1(Me.DSHRM.tbl_HRM_Card)
            MessageBox.Show("No Record Saved ", "Insertion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorCancel.Visible = False
            Tbl_HRM_CardBindingNavigatorSaveItem.Enabled = False
            Tbl_HRM_CardDataGridView.ReadOnly = True
        End Try
    End Sub
    Private Sub Tbl_HRM_CardDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_CardDataGridView.CellContentClick
    End Sub
    Private Sub Tbl_HRM_CardDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_HRM_CardDataGridView.DataError
    End Sub
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Tbl_HRM_CardBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
        Tbl_HRM_CardDataGridView.ReadOnly = False
        BindingNavigatorCancel.Visible = True
        BindingNavigatorAddNewItem.Enabled = False
    End Sub
    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs)
        BindingNavigatorCancel.Visible = True
        BindingNavigatorAddNewItem.Enabled = False
        Tbl_HRM_CardBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_CardDataGridView.ReadOnly = False
    End Sub
    Private Sub BindingNavigatorCancel_Click(sender As Object, e As EventArgs) Handles BindingNavigatorCancel.Click
        Dim postion As Integer = Tbl_HRM_CardBindingSource.Position
        Tbl_HRM_CardTableAdapter.Fill(DSHRM.tbl_HRM_Card)
        Tbl_HRM_CardBindingSource.Position = postion
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorCancel.Visible = False
        Tbl_HRM_CardBindingNavigatorSaveItem.Enabled = True
        Tbl_HRM_CardDataGridView.ReadOnly = True
        Tbl_HRM_CardBindingNavigatorSaveItem.Enabled = False
    End Sub
    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        Tbl_HRM_CardBindingNavigatorSaveItem.Enabled = True
    End Sub
    Private Sub Tbl_HRM_CardDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_HRM_CardDataGridView.CellEnter
        If e.ColumnIndex = 0 Then
            Me.Tbl_HRM_CardDataGridView(0, e.RowIndex).ReadOnly = True

            Try
                Me.Tbl_HRM_CardDataGridView(0, e.RowIndex).Value = Me.Tbl_HRM_CardDataGridView(0, e.RowIndex - 1).Value + 1
            Catch ex As Exception
                Me.Tbl_HRM_CardDataGridView(0, e.RowIndex).Value = 1
            End Try
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("Empty Fields Not Accepted", "Field Empty Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Dim CardNo As Integer = Val(TextBox1.Text)
        For i As Integer = Val(TextBox1.Text) To Val(Me.TextBox2.Text)
            Try
                Me.Tbl_HRM_CardTableAdapter.Insert(CardNo, False)
            Catch ex As Exception
            End Try
            CardNo = CardNo + 1
        Next
        Me.Tbl_HRM_CardTableAdapter.FillBy1(Me.DSHRM.tbl_HRM_Card)
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim CardNo As Int16 = Val(TextBox1.Text)
            For i As Int16 = Val(TextBox1.Text) To Val(Me.TextBox2.Text)
                Try
                    Me.Tbl_HRM_CardTableAdapter.Insert(CardNo, False)
                Catch ex As Exception
                End Try
                CardNo = CardNo + 1
            Next
            Me.Tbl_HRM_CardTableAdapter.Fill(Me.DSHRM.tbl_HRM_Card)
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub
    Private Sub emp_card_info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_HRM_CardTableAdapter.FillBy1(Me.DSHRM.tbl_HRM_Card)
        Tbl_HRM_CardBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
