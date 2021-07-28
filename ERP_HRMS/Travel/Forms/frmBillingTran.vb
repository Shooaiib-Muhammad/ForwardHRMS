Public Class frmBillingTran
    Dim Sunday, FinalWorkingDays As Integer

    Private Sub frmBillingTran_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.Control) Then
            SaveRecord()
        End If
    End Sub
    Private Sub frmBillingTran_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSTranCalc.tbl_Comp_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSTranCalc.tbl_Comp_Info)
        LoadData()
        Try
            Me.View_Bus_Bill_TransTableAdapter.Fill(Me.DSTranCalc.View_Bus_Bill_Trans, FirstDayOfMonth(Me.DateTimePicker2.Text))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Me.View_BUS_InfoTableAdapter.Fill(Me.DSTranCalc.View_BUS_Info)
        Sunday = DateTime.DaysInMonth(DateTimePicker2.Value.Year, DateTimePicker2.Value.Month) - CalculateWorkingDays()
        KeyPreview = True
    End Sub
    Private Sub LoadData()
        Sunday = DateTime.DaysInMonth(DateTimePicker2.Value.Year, DateTimePicker2.Value.Month) - CalculateWorkingDays()
        Try
            Me.Tbl_Bus_FineTableAdapter.Fill(Me.DSTranCalc.tbl_Bus_Fine, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_Bus_Leave_EntryTableAdapter.Fill(Me.DSTranCalc.tbl_Bus_Leave_Entry, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_Hrm_HolidaysTableAdapter.Fill(Me.DSTranCalc.tbl_Hrm_Holidays, Me.DateTimePicker2.Value.Month, Me.DateTimePicker2.Value.Year)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_Bus_AddAmountTableAdapter.Fill(Me.DSTranCalc.tbl_Bus_AddAmount, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.Tbl_Bus_TempAdvTableAdapter.Fill(Me.DSTranCalc.tbl_Bus_TempAdv, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_BUS_ATT_GroupTableAdapter.Fill(Me.DSTranCalc.View_BUS_ATT_Group, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.View_Bust_Att_OTTableAdapter.Fill(Me.DSTranCalc.View_Bust_Att_OT, FirstDayOfMonth(DateTimePicker2.Text), LastDayOfMonth(DateTimePicker2.Text))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function FirstDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Return New DateTime(sourceDate.Year, sourceDate.Month, 1)
    End Function
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function

    Private Function CalculateWorkingDays() As Integer
        Dim NoOfDaysinMonth As Integer
        Dim j As Int16
        Dim c As Int16 = 0
        NoOfDaysinMonth = DateTime.DaysInMonth(DateTimePicker2.Value.Year, DateTimePicker2.Value.Month)
        For j = 1 To NoOfDaysinMonth
            Dim MyWeekDay = Weekday(CType(j & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year, Date))
            If MyWeekDay = 1 Then
                'Do nothing if weekday is Sunday
            Else
                c += 1
            End If
        Next
        Return c
    End Function

   
    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        LoadData()
        Try
            Me.View_Bus_Bill_TransTableAdapter.Fill(Me.DSTranCalc.View_Bus_Bill_Trans, FirstDayOfMonth(Me.DateTimePicker2.Text))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveRecord()
    End Sub
    Private Sub SaveRecord()
        If Me.Tbl_Bus_Bill_TransTableAdapter.Fill(Me.DSTranCalc.tbl_Bus_Bill_Trans, BusCardNoComboBox.SelectedValue, FirstDayOfMonth(Me.DateTimePicker2.Text)) > 0 Then
            MsgBox("Already Bill Saved", MsgBoxStyle.Critical)
        Else
            Dim MonthDay As Integer = LastDayOfMonth(DateTimePicker2.Text).Day
            FinalWorkingDays = MonthDay - (Sunday + Val(HolidayCountLabel1.Text))
            Dim Leaves As Double = Val(Me.PaidLabel1.Text)
            Dim PayableDays As Double = 26 - (FinalWorkingDays - (Val(AttCountLabel1.Text) + Leaves))
            If PayableDays > 26 Then
                PayableDays = 26
            End If
            Dim PayalbeAmount As Double = (Val(FareLabel1.Text / 26) * PayableDays)
            Dim Fine As Integer = Val(Me.FineLabel1.Text)
            Dim TempAdv As Integer = Val(Me.TemAmtLabel1.Text)
            Dim OTAmt As Integer = Val(OTCountLabel1.Text) * Val(BUSOTLabel1.Text)
            Dim AddAmt As Integer = Val(AddAmountLabel1.Text)
            Dim TotalAddAmt As Integer = PayalbeAmount + OTAmt + AddAmt
            Dim TotalSubAmt As Integer = Fine + TempAdv
            Dim FinalPayableAmt As Integer = PayalbeAmount + OTAmt + AddAmt - (Fine + TempAdv)
            If PayableDays > 0 Then
                Me.Tbl_Bus_Bill_TransTableAdapter.Insert(Me.BusCardNoComboBox.SelectedValue, Val(Me.FareLabel1.Text), Val(BUSOTLabel1.Text), FinalWorkingDays, Val(HolidayCountLabel1.Text), Sunday, PayableDays, PayalbeAmount, Val(OTCountLabel1.Text), OTAmt, AddAmt, Fine, TempAdv, TotalAddAmt, TotalSubAmt, FinalPayableAmt, FirstDayOfMonth(Me.DateTimePicker2.Text), Now.Date, Nothing, MonthDay, Val(AttCountLabel1.Text), False, Leaves)
                Try
                    Me.View_Bus_Bill_TransTableAdapter.Fill(Me.DSTranCalc.View_Bus_Bill_Trans, FirstDayOfMonth(Me.DateTimePicker2.Text))
                Catch ex As System.Exception
                    'System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Else
                MsgBox("Value Over flow.......", MsgBoxStyle.Information)
            End If
          
        End If
    End Sub
 
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Dim btnMsg As DialogResult = MessageBox.Show("Are you Sure Want To Lock Bill of Selected Month?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        If btnMsg = Windows.Forms.DialogResult.Yes Then
            Me.View_Bus_Bill_TransTableAdapter.UpdateQuery(FirstDayOfMonth(Me.DateTimePicker2.Text))
            Try
                Me.View_Bus_Bill_TransTableAdapter.Fill(Me.DSTranCalc.View_Bus_Bill_Trans, FirstDayOfMonth(Me.DateTimePicker2.Text))
            Catch ex As System.Exception
                'System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub View_Bus_Bill_TransDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles View_Bus_Bill_TransDataGridView.CellContentClick
        If e.ColumnIndex = 18 Then
            If Me.View_Bus_Bill_TransDataGridView(17, e.RowIndex).Value = True Then
                MsgBox("Bill has been Locked So Undo Fail", MsgBoxStyle.Critical)
            Else
                Dim btnMsg As DialogResult = MessageBox.Show("Are you Sure Want To Undo Bill of Selected Bus?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                If btnMsg = Windows.Forms.DialogResult.Yes Then
                    Me.View_Bus_Bill_TransTableAdapter.DeleteQuery(Me.View_Bus_Bill_TransDataGridView(0, e.RowIndex).Value)
                    Try
                        Me.View_Bus_Bill_TransTableAdapter.Fill(Me.DSTranCalc.View_Bus_Bill_Trans, FirstDayOfMonth(Me.DateTimePicker2.Text))
                    Catch ex As System.Exception
                        'System.Windows.Forms.MessageBox.Show(ex.Message)
                    End Try
                End If
            End If
        End If
      
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim obj As New Class_Utility
        If RadioButton1.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptBillTrasDetail.rpt", "{View_Bus_Bill_Tran.Month} = " & Me.DateTimePicker2.Value.Month & " and {View_Bus_Bill_Tran.Year} = " & Me.DateTimePicker2.Value.Year & "", "")
        ElseIf RadioButton2.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptTransportBillAccNEW.rpt", "{@Month} = " & Me.DateTimePicker2.Value.Month & " and {@Year} = " & Me.DateTimePicker2.Value.Year & "", "")
        End If

    End Sub

    Private Sub BusCardNoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusCardNoComboBox.SelectedIndexChanged

    End Sub

End Class