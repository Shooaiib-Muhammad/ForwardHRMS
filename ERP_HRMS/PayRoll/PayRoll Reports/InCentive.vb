Public Class InCentive
    Private Sub InCentive_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Filter As String = ""
        Dim Param As String = ""
        Dim Path As String = ""
        Dim Obj As New UtilityClass
        If RadioButton30.Checked = True Then ' Main Unit MS
            Path = "" & frmLogin.ReportsPath & "\Incentive\IncentiveMSNewForward.rpt"
            Filter = "Year({View_Emp_Incentive.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Emp_Incentive.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""
        End If
        If MAinQA.Checked = True Then ' Main Unit QA
            Path = "" & frmLogin.ReportsPath & "\Incentive\IncentiveQANewForward.rpt"
            Filter = "Year({View_Emp_Incentive.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Emp_Incentive.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

        End If

        If F3.Checked = True Then ' F3  MS TM
            Path = "" & frmLogin.ReportsPath & "\Incentive\IncentiveFUnit3.rpt"
            Filter = "Year({View_Emp_Incentive.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Emp_Incentive.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

        End If
        If F3QA.Checked = True Then ' F3 QA 
            Path = "" & frmLogin.ReportsPath & "\Incentive\IncentiveFUnit3QA.rpt"
            Filter = "Year({View_Emp_Incentive.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Emp_Incentive.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

        End If
        If F6.Checked = True Then ' F6 Bllander Widing
            Path = "" & frmLogin.ReportsPath & "\Incentive\IncentiveFUnit6.rpt"
            Filter = "Year({View_Emp_Incentive.SalaryMonth})= " & DateTimePicker1.Value.Year & " And Month({View_Emp_Incentive.SalaryMonth}) = " & DateTimePicker1.Value.Month & ""

        End If
        Obj.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub F3_CheckedChanged(sender As Object, e As EventArgs) Handles F3.CheckedChanged

    End Sub


End Class