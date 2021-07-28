Public Class frmKAIZENReports

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Param As String = ""
        Dim Path As String = ""
        If RadioButton1.Checked = True Then
            Filter = "{tbl_Hrm_kaizen_activity_record.Approved} and {tbl_Hrm_kaizen_activity_record.NotShared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            'Filter = "{View_Rpt_Kaizen_Monthly.Month2} in " & DTPicker1.Value.Month & " to " & DateTimePicker1.Value.Month & " and {View_Rpt_Kaizen_Monthly.Year} in " & DTPicker1.Value.Year & " to " & DateTimePicker1.Value.Year & ""
            Path = "\\server\myreports$\HRMSG\HR\Kaizen\RptMonthlyLO.rpt"
        ElseIf RadioButton2.Checked = True Then
            Filter = "{View_Rpt_Kaizen_Monthly.Month2} in " & DTPicker1.Value.Month & " to " & DateTimePicker1.Value.Month & " and {View_Rpt_Kaizen_Monthly.Year} in " & DTPicker1.Value.Year & " to " & DateTimePicker1.Value.Year & ""
            'Filter = "{tbl_Hrm_kaizen_activity_record.Approved} and {tbl_Hrm_kaizen_activity_record.NotShared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            Path = "\\server\myreports$\HRMSG\HR\Kaizen\Rpt_Monthly_Kaizen.rpt"
        ElseIf RadioButton3.Checked = True Then
            If radioapproved.Checked = True And RadioInternal.Checked = True Then
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and Not ISNULL({tbl_Hrm_kaizen_activity_record.AfterADetail}) and {tbl_Hrm_kaizen_activity_record.Approved} and {tbl_Hrm_kaizen_activity_record.Shared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            ElseIf radioapproved.Checked = True And RadioOverAll.Checked = True Then
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and Not ISNULL({tbl_Hrm_kaizen_activity_record.AfterADetail}) and {tbl_Hrm_kaizen_activity_record.Approved} and {tbl_Hrm_kaizen_activity_record.NotShared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            ElseIf RadioNotApproved.Checked = True And RadioInternal.Checked = True Then
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and Not ISNULL({tbl_Hrm_kaizen_activity_record.AfterADetail}) and {tbl_Hrm_kaizen_activity_record.NotApproved} and {tbl_Hrm_kaizen_activity_record.Shared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            ElseIf RadioNotApproved.Checked = True And RadioOverAll.Checked = True Then
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and Not ISNULL({tbl_Hrm_kaizen_activity_record.AfterADetail}) and {tbl_Hrm_kaizen_activity_record.NotApproved} and {tbl_Hrm_kaizen_activity_record.NotShared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            End If
            'Filter = "{tbl_Hrm_kaizen_activity_record.Approved} and {tbl_Hrm_kaizen_activity_record.NotShared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            Path = "\\server\myreports$\HRMSG\HR\Kaizen\KaizenSavingSummary.rpt"
        ElseIf RadioButton4.Checked = True Then
            Filter = "{tbl_Hrm_kaizen_activity_record.KARCode} in [" & GetCardsInString() & "]"
            Path = "\\server\myreports$\HRMSG\HR\Rpt_Kaizen.rpt"
        ElseIf RadioButton5.Checked = True Then
            Filter = "{View_Rpt_HR_EmpEval_Grid.EvalMonth} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            Path = "\\server\myreports$\HRMSG\HR\Kaizen\Rpt_Kaizen_EmpEval_Result_BY_Catagory.rpt"
        ElseIf RadioButton6.Checked = True Then
            If radioapproved.Checked = True And RadioInternal.Checked = True Then
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and {tbl_Hrm_kaizen_activity_record.Approved} and {tbl_Hrm_kaizen_activity_record.Shared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            ElseIf radioapproved.Checked = True And RadioOverAll.Checked = True Then
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and  {tbl_Hrm_kaizen_activity_record.Approved} and {tbl_Hrm_kaizen_activity_record.NotShared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            ElseIf RadioNotApproved.Checked = True And RadioInternal.Checked = True Then
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and {tbl_Hrm_kaizen_activity_record.NotApproved} and {tbl_Hrm_kaizen_activity_record.Shared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            ElseIf RadioNotApproved.Checked = True And RadioOverAll.Checked = True Then
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and  {tbl_Hrm_kaizen_activity_record.NotApproved} and {tbl_Hrm_kaizen_activity_record.NotShared} and {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            Else
                Filter = "not ({View_Rpt_Acc_AllEmployees_ActiveSalary.EmpID} in [2291, 707]) and  {tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            End If
            'Filter = "{tbl_Hrm_kaizen_activity_record.KaizenDate} in DateTime(" & DTPicker1.Value.Year & ", " & DTPicker1.Value.Month & ", " & DTPicker1.Value.Day & ") to DateTime(" & DateTimePicker1.Value.Year & ", " & DateTimePicker1.Value.Month & ", " & DateTimePicker1.Value.Day & ")"
            Path = "\\server\myreports$\HRMSG\HR\Rpt_Kaizen_LandScape.rpt"
        End If
        Dim Obj As New UtilityClass()
        Obj.LoadReports(Path, Filter, Param)
    End Sub
    Private Function GetCardsInString() As String
        Dim Str As String = ""
        Dim KCode As String
        For i As Integer = 0 To lstCards.Items.Count - 1
            If i = 0 Then
                Kcode = "'" & lstCards.Items.Item(i).ToString & "'"
                Str = Str & Kcode

            Else
                Kcode = "'" & lstCards.Items.Item(i).ToString & "'"
                Str = Str & "," & KCode
            End If
        Next
        Return Str
    End Function

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub Tbl_Hrm_kaizen_activity_recordBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Tbl_Hrm_kaizen_activity_recordBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSKAIZENRpt)

    End Sub

    Private Sub frmKAIZENReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSKAIZENRpt.tbl_Hrm_kaizen_activity_record' table. You can move, or remove it, as needed.
        Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.Fill(Me.DSKAIZENRpt.tbl_Hrm_kaizen_activity_record)
        

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If cmbSelectCard.SelectedIndex >= 0 Then
            lstCards.Items.Add(cmbSelectCard.SelectedValue)
            lstCards.SelectedIndex = lstCards.Items.Count - 1
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If lstCards.Items.Count > 0 Then
            If lstCards.SelectedIndex >= 0 Then
                lstCards.Items.RemoveAt(lstCards.SelectedIndex)
                lstCards.SelectedIndex = lstCards.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub cmbSelectCard_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelectCard.SelectedIndexChanged
       
    End Sub

    
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub
End Class