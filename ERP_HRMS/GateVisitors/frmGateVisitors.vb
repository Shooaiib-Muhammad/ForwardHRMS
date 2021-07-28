Public Class frmGateVisitors
    Private Sub Tbl_Gate_VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_Gate_VisitorsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Gate_VisitorsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSVisitors)
            Me.Tbl_Gate_VisitorsTableAdapter.Fill(Me.DSVisitors.tbl_Gate_Visitors, Now.Date)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub frmGateVisitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSVisitors.tbl_Gate_Visitors' table. You can move, or remove it, as needed.

        VisitorCombo.Text = "Local"
        VisitorCombo.Focus()
        DateTimePicker1.Text = Now.Date
    End Sub
    Private Sub LoradRecord()
        Me.Tbl_Gate_VisitorsTableAdapter.Fill(Me.DSVisitors.tbl_Gate_Visitors, DateTimePicker1.Text)
    End Sub


    Private Sub Tbl_Gate_VisitorsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Gate_VisitorsDataGridView.CellContentClick
        Try
            If e.ColumnIndex = 12 Then

                Dim TransID As Integer
                TransID = Me.Tbl_Gate_VisitorsDataGridView("TransID", e.RowIndex).Value
                Me.Tbl_Gate_VisitorsTableAdapter.UpdateOutTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), TransID)
                LoradRecord()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Tbl_Gate_VisitorsDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Gate_VisitorsDataGridView.DataError

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        InTimeTxt.Text = Me.DateTimePicker2.Text
    End Sub

    Private Sub GradeEffectiveDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles InTimeTxt.MaskInputRejected

    End Sub

    Private Sub GradeEffectiveDateMaskedTextBox_GotFocus(sender As Object, e As EventArgs) Handles InTimeTxt.GotFocus
        If InTimeTxt.Text = "  /  /       :" Then
            'If GradeEffectiveDateMaskedTextBox.Text = "  -  -" Then
            'InTimeTxt.Text = TimeOfDay.ToString("dd/MM/yyyy hh:mm tt")
            InTimeTxt.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm")
            'InTimeTxt.Text = Now
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim result As MsgBoxResult = MsgBox("Do you want to save the record", MsgBoxStyle.YesNo)
        'If result = MsgBoxResult.Yes Then
        If InTimeTxt.Text = "" Or CNICTxt.Text = "" Then
            MsgBox("Please Fill the Informaion")
        Else


            Me.Tbl_Gate_VisitorsTableAdapter.Insert(NameTxt.Text, CNICTxt.Text, ContactTxt.Text, AddressTxt.Text, PurposeTxt.Text, CardNoCombo.Text, VisitorCombo.Text, DateTimePicker1.Text, InTimeTxt.Text, Nothing, VehicleNoTextBox.Text)
            Assignzero()
            VisitorCombo.Focus()

            Try
                LoradRecord()
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub NameTxt_TextChanged(sender As Object, e As EventArgs) Handles NameTxt.TextChanged

    End Sub

    Private Sub NameTxt_MouseEnter(sender As Object, e As EventArgs) Handles NameTxt.MouseEnter
        'Try
        '    Me.View_Gate_VisitorsTableAdapter.Fill(Me.DSVisitors.View_Gate_Visitors, CNICTxt.Text)
        '    If Me.View_Gate_VisitorsBindingSource.Count > 0 Then
        '        Assign()
        '    End If

        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try
    End Sub




    Private Sub Assign()
        NameTxt.Text = Me.DSVisitors.View_Gate_Visitors.Rows(0).Item("Name")
        ContactTxt.Text = Me.DSVisitors.View_Gate_Visitors.Rows(0).Item("ContactNo")
        AddressTxt.Text = Me.DSVisitors.View_Gate_Visitors.Rows(0).Item("Address")

    End Sub

    Private Sub Assignzero()
        NameTxt.Text = ""
        ContactTxt.Text = ""
        AddressTxt.Text = ""
        CNICTxt.Text = ""
        VisitorCombo.Text = ""
        PurposeTxt.Text = ""
        InTimeTxt.Text = "  /  /       :"
    End Sub
    Private Sub CNICTxt_TextChanged(sender As Object, e As EventArgs) Handles CNICTxt.TextChanged

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If Me.txtSearch.TextLength = 0 Then
                Tbl_Gate_VisitorsBindingSource.RemoveFilter()
            Else

                'View_Pro_PO_Auto_PlaningMainBindingSource.Filter = "ArticleNo=" & Val(txtSearch.Text)
                Tbl_Gate_VisitorsBindingSource.Filter = String.Format("CardNo Like '*" & txtSearch.Text) & "*'"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub NameTxt_GotFocus(sender As Object, e As EventArgs) Handles NameTxt.GotFocus
        Try
            Me.View_Gate_VisitorsTableAdapter.Fill(Me.DSVisitors.View_Gate_Visitors, CNICTxt.Text)
            If Me.View_Gate_VisitorsBindingSource.Count > 0 Then
                Assign()
            End If

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoradRecord()
    End Sub
End Class