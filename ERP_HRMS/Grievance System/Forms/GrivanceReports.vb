Public Class GrivanceReports
    Dim Filter As String = ""
    Dim DeptFilter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Private Sub Tbl_HRM_DeptBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_DeptBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)

    End Sub

    Private Sub GrivanceReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'TODO: This line of code loads data into the 'DSGrievance.tbl_EAP_Grievance_Category_Head' table. You can move, or remove it, as needed.
Me.Tbl_EAP_Grievance_Category_HeadTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance_Category_Head)
        'TODO: This line of code loads data into the 'DSGrievance.tbl_EAP_Grievance_Category' table. You can move, or remove it, as needed.
        Me.Tbl_EAP_Grievance_CategoryTableAdapter.Fill(Me.DSGrievance.tbl_EAP_Grievance_Category)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

    End Sub

    Private Sub RptViewer_Click(sender As Object, e As EventArgs) Handles RptViewer.Click

        If RadioGriev.Checked = True Then


            Path = "" & frmLogin.ReportsPath & "\Gerivance\Gerivance.rpt"
            If All.Checked = True Then
                Flag = False

                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf CrdRange.Checked = True Then

                If RadioDeptAll.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = " {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If


                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If
                End If
            ElseIf ByCatagery.Checked = True Then
                Flag = False


                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "' "
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "'"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "'"
                End If
            End If

        ElseIf RadioGrievSummary.Checked = True Then
            'Param = "FromDate=" & MonthPicker.Value.Day & "/" & MonthPicker.Value.Month & "/" & MonthPicker.Value.Year & "&ToDate=" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Year & ""
            Path = "" & frmLogin.ReportsPath & "\Gerivance\gerivancesummary.rpt"
            If All.Checked = True Then
                Flag = False

                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf CrdRange.Checked = True Then

                If RadioDeptAll.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = " {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If


                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If
                End If
            ElseIf ByCatagery.Checked = True Then
                Flag = False


                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "' "
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "'"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "'"
                End If
            End If


        ElseIf RadioGrievStatus.Checked = True Then

            Path = "" & frmLogin.ReportsPath & "\Gerivance\gerivancestatus.rpt"
            If All.Checked = True Then
                Flag = False

                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                End If
            ElseIf CrdRange.Checked = True Then

                If RadioDeptAll.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = " {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                    Else
                        Filter = " {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "' "
                    Else
                        Filter = " {View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "' "
                    End If


                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "' "
                    Else
                        Filter = " {View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & "  And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "'  And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                    Else
                        Filter = " {View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Gerivance.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                    End If
                End If
            ElseIf ByCatagery.Checked = True Then
                Flag = False


                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "' And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "' "
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "' And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Gerivance.SectionName}  = '" & NameComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "' And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Gerivance.DesigName} = '" & DesigComboBox.Text & "' And {View_Rpt_Gerivance.GrievanceDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#  And {View_Rpt_Gerivance.Category} = '" & BranchNameComboBox.Text & "' And {View_Rpt_Gerivance.GSStatus}='" & ComboStatus.Text & "'"
                End If
            End If

        End If


        If Flag = True Then
            MessageBox.Show("Start Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadAnalysisReports(Path, Filter, Param)
        End If

    End Sub
    Dim Flag As Boolean = False
    Private Sub CrdRange_CheckedChanged(sender As Object, e As EventArgs) Handles CrdRange.CheckedChanged
        If CrdRange.Checked = True Then
            Tocrd.Enabled = True
            FrmCrd.Enabled = True
        Else
            Tocrd.Enabled = False
            FrmCrd.Enabled = False
        End If
    End Sub

    Private Sub MainDeptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MainDeptBtn.CheckedChanged
        If MainDeptBtn.Checked = True Then
            DeptNameComboBox.Enabled = True
        Else
            DeptNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub SectBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SectBtn.CheckedChanged
        If SectBtn.Checked = True Then
            DeptNameComboBox.Enabled = True
            NameComboBox.Enabled = True

        Else
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False

        End If
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        If DesigBtn.Checked = True Then
            DesigComboBox.Enabled = True


        Else

            DesigComboBox.Enabled = False

        End If
    End Sub

    Private Sub ByCatagery_CheckedChanged(sender As Object, e As EventArgs) Handles ByCatagery.CheckedChanged
        If ByCatagery.Checked = True Then
            BranchNameComboBox.Enabled = True
        Else
            BranchNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioGrievStatus_CheckedChanged(sender As Object, e As EventArgs) Handles RadioGrievStatus.CheckedChanged
        If RadioGrievStatus.Checked = True Then
            ComboStatus.Enabled = True
        Else
            ComboStatus.Enabled = False
        End If
    End Sub
End Class