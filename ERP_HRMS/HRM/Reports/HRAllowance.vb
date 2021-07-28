Public Class HRAllowance
    Private Sub HRAllowance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Branch' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_BranchTableAdapter.Fill(Me.DSHRM.tbl_HRM_Branch)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim Obj As New UtilityClass()
        Dim EmpStatus As String

        'Path = "" & frmLogin.ReportsPath & "\HR\ActiveUflist.rpt"



        If SPcAll.Checked = True Then '' Special Allowance
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptSpecialAll.rpt"
            If All.Checked = True Then
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@SpecialAllowance} > 0 "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@SpecialAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = "  {@SpecialAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@SpecialAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@SpecialAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {@SpecialAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@SpecialAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@SpecialAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@SpecialAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@SpecialAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  {@SpecialAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And {@SpecialAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@SpecialAllowance} > 0  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@SpecialAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@SpecialAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@SpecialAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If


        ElseIf MealAll.Checked = True Then '' Meal Allowance
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\MealAllowance.rpt"
            If All.Checked = True Then
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@MealAllowance} > 0  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {@MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  {@MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And {@MealAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then ' By branch 
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@MealAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If

            '' Union Fund


        ElseIf RadioButton3.Checked = True Then '' Travel Allowance
            Path = "" & frmLogin.ReportsPath & "\HR\ActiveUflist.rpt"
            If All.Checked = True Then ' All 
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {Active_UF_list.UnionFund} > 0 "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {Active_UF_list.UnionFund} > 0  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {Active_UF_list.UnionFund} > 0  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {Active_UF_list.UnionFund} > 0  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then ' By card range 
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {Active_UF_list.UnionFund} > 0  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = "{Active_UF_list.UnionFund} > 0 And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {Active_UF_list.UnionFund} > 0  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {Active_UF_list.UnionFund} > 0  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {Active_UF_list.UnionFund} > 0  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {Active_UF_list.UnionFund} > 0  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigComboBox.SelectedValue & "  And  {Active_UF_list.UnionFund} > 0  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigComboBox.SelectedValue & "  And {Active_UF_list.UnionFund} > 0  And  {View_Rpt_Acc_AllEmployees.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then ' By Branch
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {Active_UF_list.UnionFund} > 0  And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {Active_UF_list.UnionFund} > 0  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {Active_UF_list.UnionFund} > 0  And {View_Rpt_Acc_AllEmployees.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_AllEmployees.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {Active_UF_list.UnionFund} > 0  And {View_Rpt_Acc_AllEmployees.DesignationID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_AllEmployees.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If










            ''' End Union Fund





        ElseIf TravelBtn.Checked = True Then '' Travel Allowance
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptTravelAll.rpt"
            If All.Checked = True Then ' All 
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@TravelAllowance} > 0  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@TravelAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@TravelAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@TravelAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then ' By card range 
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@TravelAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {@TravelAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@TravelAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@TravelAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@TravelAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@TravelAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  {@TravelAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And {@TravelAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then ' By Branch
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@TravelAllowance} > 0  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@TravelAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@TravelAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@TravelAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If
        ElseIf EduAll.Checked = True Then '' Education Allowance
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptEduAll.rpt"
            If All.Checked = True Then ' All 
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@EduAllowance} > 0  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@EduAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@EduAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@EduAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then ' By card range 
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@EduAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {@EduAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@EduAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@EduAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@EduAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@EduAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  {@EduAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And {@EduAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then ' By Branch
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@EduAllowance} > 0  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@EduAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@EduAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@EduAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If

        ElseIf AccAllow.Checked = True Then '' Accomodation Allowance
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptAccAll.rpt"
            If All.Checked = True Then ' All 
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@AccAllowance} > 0  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@AccAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@AccAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@AccAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then ' By card range 
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@AccAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {@AccAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@AccAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@AccAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@AccAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@AccAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  {@AccAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And {@AccAllowance} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then ' By Branch
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@AccAllowance} > 0  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@AccAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@AccAllowance} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@AccAllowance} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If

        End If





        If TxtBtn.Checked = True Then '' Tex Deduction
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptTaxDedd.rpt"
            If All.Checked = True Then ' All 
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@TexDed} > 0  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@TexDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@TexDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@TexDed} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then ' By card range 
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@TexDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {@TexDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@TexDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@TexDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@TexDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@TexDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  {@TexDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And {@TexDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then ' By Branch
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@TexDed} > 0  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@TexDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@TexDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@TexDed} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If

        ElseIf RebtBtn.Checked = True Then '' Rent Deduction
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptRentDed.rpt"
            If All.Checked = True Then ' All 
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@rentDed} > 0  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@rentDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@rentDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@rentDed} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then ' By card range 
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@rentDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {@rentDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@rentDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@rentDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@rentDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@rentDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  {@rentDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And {@rentDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then ' By Branch
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@rentDed} > 0  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@rentDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@rentDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@rentDed} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If
        ElseIf CantBtn.Checked = True Then '' Canteen Deduction
            Path = "" & frmLogin.ReportsPath & "\HR\Allowanceanddeduction\RptcanteenDed.rpt"
            If All.Checked = True Then ' All 
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@CanteenDed} > 0  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@CanteenDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@CanteenDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@CanteenDed} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  "
                End If

            ElseIf CrdRange.Checked = True Then ' By card range 
                If RadioButton1.Checked = True Then ' All Dept
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {@CanteenDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {@CanteenDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And  {@CanteenDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {@CanteenDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & " "
                    End If

                ElseIf SectBtn.Checked = True Then ' Section

                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And   {@CanteenDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & "  And  {@CanteenDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If

                ElseIf DesigBtn.Checked = True Then ' Desig
                    If TextBox1.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If TextBox2.Text = "" Then
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And  {@CanteenDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox1.Text & "  "
                    Else
                        Filter = " {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & "  And {@CanteenDed} > 0  And  {View_Rpt_Acc_PreSalary.CardNo} In " & TextBox1.Text & " To " & TextBox2.Text & "  "
                    End If
                End If
            ElseIf RadioButton2.Checked = True Then ' By Branch
                Flag = False
                If RadioButton1.Checked = True Then ' All Dept
                    Filter = " {@CanteenDed} > 0  And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & "  "
                ElseIf MainDeptBtn.Checked = True Then ' Main Dept 
                    Filter = " {@CanteenDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf SectBtn.Checked = True Then ' Section 
                    Filter = " {@CanteenDed} > 0  And {View_Rpt_Acc_PreSalary.DeptID} = " & DeptNameComboBox.SelectedValue & "  And {View_Rpt_Acc_PreSalary.SubDept1ID} = " & NameComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                ElseIf DesigBtn.Checked = True Then ' Desig
                    Filter = " {@CanteenDed} > 0  And {View_Rpt_Acc_PreSalary.DesigID} = " & DesigComboBox.SelectedValue & " And {View_Rpt_Acc_PreSalary.BranchID} = " & BranchNameComboBox.SelectedValue & " "
                End If

            End If


        End If






        If Flag = True Then
            MessageBox.Show("Start Card Number Is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If
    End Sub
    Dim Flag As Boolean = False

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        DesigComboBox.Enabled = False
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
    End Sub

    Private Sub MainDeptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles MainDeptBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = False
        DesigComboBox.Enabled = False
    End Sub

    Private Sub SectBtn_CheckedChanged(sender As Object, e As EventArgs) Handles SectBtn.CheckedChanged
        DeptNameComboBox.Enabled = True
        NameComboBox.Enabled = True
        DesigComboBox.Enabled = False
    End Sub

    Private Sub DesigBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBtn.CheckedChanged
        DeptNameComboBox.Enabled = False
        NameComboBox.Enabled = False
        DesigComboBox.Enabled = True
    End Sub

    Private Sub All_CheckedChanged(sender As Object, e As EventArgs) Handles All.CheckedChanged
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub CrdRange_CheckedChanged(sender As Object, e As EventArgs) Handles CrdRange.CheckedChanged
        If CrdRange.Checked = True Then
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        Else
            TextBox1.Enabled = False
            TextBox2.Enabled = False

        End If
        BranchNameComboBox.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        BranchNameComboBox.Enabled = True
    End Sub

    Private Sub CantBtn_CheckedChanged(sender As Object, e As EventArgs) Handles CantBtn.CheckedChanged

    End Sub


End Class