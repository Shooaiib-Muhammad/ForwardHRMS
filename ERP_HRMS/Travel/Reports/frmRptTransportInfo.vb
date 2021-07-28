Public Class frmRptTransportInfo

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim obj As New Class_Utility
        Dim Path As String = ""
        Dim Param As String = ""
        Dim Filter As String = ""
        If RadioButton1.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptDailyBusAttendance.rpt", "{View_BUS_ATT_Group.AttDate} in DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ") to DateTime(" & DateTimePicker2.Value.Year & ", " & DateTimePicker2.Value.Month & ", " & DateTimePicker2.Value.Day & ")", "")
        ElseIf RadioButton4.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptDailyBusAttendance.rpt", "{View_BUS_ATT_Group.AttDate} in DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ") to DateTime(" & DateTimePicker2.Value.Year & ", " & DateTimePicker2.Value.Month & ", " & DateTimePicker2.Value.Day & ")And {View_BUS_ATT_Group.OTStatus}", "")
        ElseIf RadioButton7.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptBusInfo.rpt", "{View_BUS_Info.BusCardNo} >= 1", "")
        ElseIf RadioButton8.Checked Then
            'obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptBusInfo.rpt", "{View_BUS_ATT_Group.EmpCount}<>2", "")
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptDailyBusAttendance.rpt", "{View_BUS_ATT_Group.AttDate} in DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ") to DateTime(" & DateTimePicker2.Value.Year & ", " & DateTimePicker2.Value.Month & ", " & DateTimePicker2.Value.Day & ")And {View_BUS_ATT_Group.EmpCount}<>2", "")
        ElseIf RadioButton2.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptTransportBillAccNEW.rpt", "{@Month} = " & Me.DateTimePicker1.Value.Month & " and {@Year} = " & Me.DateTimePicker1.Value.Year & "", "")
        ElseIf RadioButton3.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptTransportBillAccNEW.rpt", "{@Month} = " & Me.DateTimePicker1.Value.Month & " and {@Year} = " & Me.DateTimePicker1.Value.Year & "And {View_BUS_Payment.BusCardNo} in " & Me.TextBox3.Text & " to " & Me.TextBox4.Text & "", "")
        ElseIf RadioButton5.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptEmpCardForHR.rpt", "{View_BUS_Info.BusCardNo} in " & Me.TextBox3.Text & " to " & Me.TextBox4.Text & "", "")
        ElseIf RadioButton6.Checked Then
            obj.LoadReports("\\Server\Myreports$\HRMS\Bus\RptEmpCardBackForHR.rpt", "{View_BUS_Info.BusCardNo} in " & Me.TextBox3.Text & " to " & Me.TextBox4.Text & "", "")
        ElseIf RadioButton10.Checked Then
            Filter = "({View_Rpt_Acc_PreSalary.CardNo} in " & Val(TextBox3.Text) & " to " & Val(TextBox4.Text) & ") and ({View_Working_Day.AttDate} in {?FromDate} to {?ToDate})And {View_Rpt_Acc_PreSalary.Status}"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@HFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@HToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & ""
            'Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@HFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@HToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@MyYear=" & DateTimePicker1.Value.Year & "&@MyMonth=" & DateTimePicker1.Value.Month
            Path = "\\server\myreports$\HRMS\Bus\rptPayRollEachEmpAtt4Audit.rpt"
            obj.LoadReports(Path, Filter, Param)
        ElseIf RadioButton9.Checked Then
            Filter = "({View_Rpt_Acc_PreSalary.CardNo} in " & Val(TextBox3.Text) & " to " & Val(TextBox4.Text) & ") and ({View_Rpt_PayRoll_InOutDifference.AttDate} in {?FromDate} to {?ToDate})And {View_Rpt_Acc_PreSalary.Status}"
            Param = "FromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&ToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@HFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@HToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@EFromDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & "&@EToDate=" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year & "&@MyYear=" & DateTimePicker1.Value.Year & "&@MyMonth=" & DateTimePicker1.Value.Month
            Path = "\\server\myreports$\HRMS\Bus\rptPayRollAttList4Audit.rpt"
            obj.LoadReports(Path, Filter, Param)
        End If
    End Sub

    Private Sub EnablDisable(ByVal dt As Boolean, ByVal dt1 As Boolean, ByVal Crd As Boolean)
        Me.DateTimePicker1.Enabled = dt
        Me.DateTimePicker2.Enabled = dt1
        Me.TextBox3.Enabled = Crd
        Me.TextBox4.Enabled = Crd
    End Sub
    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged, RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged, RadioButton8.CheckedChanged, RadioButton4.CheckedChanged, RadioButton5.CheckedChanged, RadioButton6.CheckedChanged
        If RadioButton2.Checked Then
            EnablDisable(True, False, False)
        ElseIf RadioButton3.Checked Then
            EnablDisable(True, False, True)
        ElseIf RadioButton5.Checked Or RadioButton6.Checked Then
            EnablDisable(False, False, True)
        ElseIf RadioButton7.Checked Then
            EnablDisable(False, False, False)
        Else
            EnablDisable(True, True, False)
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton10.CheckedChanged, RadioButton9.CheckedChanged
        EnablDisable(True, True, True)
    End Sub

    Private Sub frmRptTransportInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class