Public Class cardprinting


    Dim Filter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass
    Private Sub Tbl_HRM_GradeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_GradeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSHRM)

    End Sub

    Private Sub cardprinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Grade' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_GradeTableAdapter.Fill(Me.DSHRM.tbl_HRM_Grade)

    End Sub

    Private Sub MainDeptandSection_CheckedChanged(sender As Object, e As EventArgs) Handles MainDeptandSection.CheckedChanged
        DesigNameComboBox.Enabled = False
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = True
    End Sub

    Private Sub MainDept_CheckedChanged(sender As Object, e As EventArgs) Handles MainDept.CheckedChanged
        DesigNameComboBox.Enabled = False
        DeptNameComboBox.Enabled = True
        SectionNameComboBox.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbSelectCard.SelectedIndex >= 0 Then
            lstCards.Items.Add(cmbSelectCard.SelectedValue)
            lstCards.SelectedIndex = lstCards.Items.Count - 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lstCards.Items.Count > 0 Then
            If lstCards.SelectedIndex >= 0 Then
                lstCards.Items.RemoveAt(lstCards.SelectedIndex)
                lstCards.SelectedIndex = lstCards.Items.Count - 1
            End If
        End If
    End Sub

    Private Sub btnRptShow_Click(sender As Object, e As EventArgs) Handles btnRptShow.Click

        If RadioButton1.Checked = True And Frontside.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\EmpCrdFSRpt.rpt"
            If AllDept.Checked = True Then ' All EMp
                If AllButton.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "]"
                ElseIf MainDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "]"
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "]"
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "] "
                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                If AllButton.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "] And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "]  And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Dept.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Section.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "] And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Designation.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "] And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                End If

            End If
        End If
            If RadioButton1.Checked = True And BackSide.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\EmpCrdBSRpt.rpt"
            If AllDept.Checked = True Then ' All Emp
                If AllButton.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "]"
                ElseIf MainDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "]"
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "]"
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "] "
                End If
            ElseIf ByBranch.Checked = True Then ' By Branch
                If AllButton.Checked = True Then
                    Filter = "{tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "] And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf MainDept.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And  {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "]  And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf MainDeptandSection.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Emp_Info.DeptID} = " & DeptNameComboBox.SelectedValue & " And {tbl_HRM_Emp_Info.SectionID} = " & SectionNameComboBox.SelectedValue & "  And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "] And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                ElseIf Deigantionbtn.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Info.EmpStatus} = True And   {tbl_HRM_Emp_Info.DesignationID} = " & DesigNameComboBox.SelectedValue & "  And {tbl_HRM_Grade.GradeName} In  [" & GetCardsInString() & "] And {tbl_HRM_Emp_Info.BranchID} = " & BranchNameComboBox.SelectedValue & ""
                End If

            End If
        End If

            Obj.LoadReports(Path, Filter, Param)
    End Sub
    Private Function GetCardsInString() As String
        Dim Str As String = ""
        Dim Grade As String
        For i As Integer = 0 To lstCards.Items.Count - 1
            If i = 0 Then
                Grade = "'" & lstCards.Items.Item(i).ToString() & "'"
                Str = Str & Grade

            Else
                Grade = "'" & lstCards.Items.Item(i).ToString() & "'"
                Str = Str & ", " & Grade
            End If
        Next
        Return Str
    End Function



    Private Sub Deigantionbtn_CheckedChanged(sender As Object, e As EventArgs) Handles Deigantionbtn.CheckedChanged
        DesigNameComboBox.Enabled = True
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
    End Sub

    Private Sub AllButton_CheckedChanged(sender As Object, e As EventArgs) Handles AllButton.CheckedChanged
        DesigNameComboBox.Enabled = False
        DeptNameComboBox.Enabled = False
        SectionNameComboBox.Enabled = False
    End Sub

    Private Sub AllDept_CheckedChanged_1(sender As Object, e As EventArgs) Handles AllDept.CheckedChanged
        BranchNameComboBox.Enabled = False
        Me.AcceptButton = Button1
    End Sub

    Private Sub ByBranch_CheckedChanged(sender As Object, e As EventArgs) Handles ByBranch.CheckedChanged
        BranchNameComboBox.Enabled = True
        Me.AcceptButton = Button1
    End Sub
End Class