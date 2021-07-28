Public Class frmRptEmpEvaluation

    Private Sub frmRptEmpEvaluation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        'TODO: This line of code loads data into the 'DSEmpEvaluation.tbl_Emp_Evaluation_Head' table. You can move, or remove it, as needed.
        Me.Tbl_Emp_Evaluation_HeadTableAdapter.Fill(Me.DSEmpEvaluation.tbl_Emp_Evaluation_Head)
        Me.Tbl_Emp_Evaluation_HeadBindingSource.Sort = "EvalID DESC"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Path As String = ""
        Dim Filter As String = ""
        Dim obj As New UtilityClass
        'If RadioButton1.Checked Then
        '    Path = "\\server\myreports$\HRMS\HR\EmpSpecialReports\rptEmpEvalDetail.rpt"
        '    If CheckBox1.CheckState = CheckState.Indeterminate Then
        '        Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & ""
        '    ElseIf CheckBox1.CheckState = CheckState.Checked Then
        '        Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & "And {View_Rpt_Acc_PreSalary.Status}"
        '    ElseIf CheckBox1.CheckState = CheckState.Unchecked Then
        '        Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & "And not {View_Rpt_Acc_PreSalary.Status}"
        '    End If
        'ElseIf RadioButton2.Checked Then
        Path = "\\server\myreports$\HRMS\HR\EmpSpecialReports\rptEmpEvalForm.rpt"

        If All.Checked = True Then '' All Btn
            Flag = False
            If AllDept.Checked = True Then ' All dept
                Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & ""
            ElseIf DepBTn.Checked = True Then '' by dept
                Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & Me.DeptNameComboBox.Text & "' "
            ElseIf SecBtn.Checked = True Then ' by Sections
                Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & Me.DeptNameComboBox.Text & "'  and  {View_Rpt_Acc_PreSalary.SubDept2} = = '" & Me.SectionNameComboBox.Text & "'"
            ElseIf DesigBtn.Checked = True Then '' by desgignation
                Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DesigName} = '" & Me.DesigNameComboBox.Text & "'"
            End If

        ElseIf BBtn.Checked = True Then '' by Grade
            Flag = False
            If AllDept.Checked = True Then ' All dept
                Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.Grade} =   '" & Me.GradeNameComboBox.Text & "' "
            ElseIf DepBTn.Checked = True Then '' by dept
                Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & Me.DeptNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.Grade} =   '" & Me.GradeNameComboBox.Text & "' "
            ElseIf SecBtn.Checked = True Then ' by Sections
                Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & Me.DeptNameComboBox.Text & "'  and  {View_Rpt_Acc_PreSalary.SubDept2} = = '" & Me.SectionNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.Grade} =   '" & Me.GradeNameComboBox.Text & "'"
            ElseIf DesigBtn.Checked = True Then '' by desgignation
                Filter = "{View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DesigName} = '" & Me.DesigNameComboBox.Text & "' And {View_Rpt_Acc_PreSalary.Grade} =   '" & Me.GradeNameComboBox.Text & "'"
            End If
        ElseIf GBtn.Checked = True Then '' by Card

            If AllDept.Checked = True Then ' All dept
                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo}  In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & ""
                Else
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " "
                End If

            ElseIf DepBTn.Checked = True Then '' by dept
                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo}  In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & "  and {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & Me.DeptNameComboBox.Text & "' "
                Else
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & Me.DeptNameComboBox.Text & "'  "
                End If

            ElseIf SecBtn.Checked = True Then ' by Sections
                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo}  In " & TextBox1.Text & " To " & TextBox1.Text & " And  {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DeptName} = '" & Me.DeptNameComboBox.Text & "'  and  {View_Rpt_Acc_PreSalary.SubDept2} = = '" & Me.SectionNameComboBox.Text & "'"
                Else
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.DeptName} = '" & Me.DeptNameComboBox.Text & "'  "
                End If
               
            ElseIf DesigBtn.Checked = True Then '' by desgignation

                If TextBox1.Text.Length = 0 Then
                    Flag = True
                Else
                    Flag = False
                End If
                If TextBox2.Text = "" Then
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo}  In " & TextBox1.Text & " To " & TextBox1.Text & "  And {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DesigName} = '" & Me.DesigNameComboBox.Text & "'"
                Else
                    Filter = "{View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " And {View_Rpt_Acc_PreSalary.EvalID} = " & Me.BusNoComboBox.SelectedValue & " and {View_Rpt_Acc_PreSalary.DesigName} = '" & Me.DesigNameComboBox.Text & "'"
                End If
            End If
        End If

        'End If
        If Flag = True Then
            MessageBox.Show("Start Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            obj.LoadReports(Path, Filter, "")
        End If

    End Sub
    Dim Flag As Boolean = False


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            Me.CheckBox1.Enabled = True
        ElseIf RadioButton2.Checked Then
            Me.CheckBox1.Enabled = False
        End If

    End Sub

    Private Sub DepBTn_CheckedChanged(sender As Object, e As EventArgs) Handles DepBTn.CheckedChanged
        If DepBTn.Checked = True Then
            DeptNameComboBox.Enabled = True
            SectionNameComboBox.Enabled = False
            DesigNameComboBox.Enabled = False
        Else
            DeptNameComboBox.Enabled = False
            SectionNameComboBox.Enabled = False
            DesigNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub SecBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SecBtn.CheckedChanged
        If SecBtn.Checked = True Then
            DeptNameComboBox.Enabled = True
            SectionNameComboBox.Enabled = True
            DesigNameComboBox.Enabled = False
        Else
            DeptNameComboBox.Enabled = False
            SectionNameComboBox.Enabled = False
            DesigNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        If DesigBtn.Checked = True Then
            DeptNameComboBox.Enabled = False
            SectionNameComboBox.Enabled = False
            DesigNameComboBox.Enabled = True
        Else
            DeptNameComboBox.Enabled = False
            SectionNameComboBox.Enabled = False
            DesigNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub AllDept_CheckedChanged(sender As Object, e As EventArgs) Handles AllDept.CheckedChanged
        If AllDept.Checked = True Then
            DeptNameComboBox.Enabled = False
            SectionNameComboBox.Enabled = False
            DesigNameComboBox.Enabled = False
        Else
            DeptNameComboBox.Enabled = False
            SectionNameComboBox.Enabled = False
            DesigNameComboBox.Enabled = False
        End If
    End Sub


    Private Sub BBtn_CheckedChanged(sender As Object, e As EventArgs) Handles BBtn.CheckedChanged
        If BBtn.Checked = True Then
            GradeNameComboBox.Enabled = True
        Else
            GradeNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub GBtn_CheckedChanged(sender As Object, e As EventArgs) Handles GBtn.CheckedChanged
        If GBtn.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        End If
    End Sub
End Class