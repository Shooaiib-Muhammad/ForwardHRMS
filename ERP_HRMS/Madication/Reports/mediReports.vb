Public Class mediReports
    Dim Filter As String = ""
    Dim DeptFilter As String = ""
    Dim Path As String = ""
    Dim Param As String = ""
    Dim Obj As New UtilityClass

    Private Sub mediReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Med_Item' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Med_Item_Head' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Med_Item_HeadTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item_Head)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Medication_Rec_Head' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Medication_Rec_HeadTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication_Rec_Head)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)

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

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            Tocrd.Enabled = True
            FrmCrd.Enabled = True
        Else
            Tocrd.Enabled = False
            FrmCrd.Enabled = False
        End If
    End Sub

    Private Sub RptViewer_Click(sender As Object, e As EventArgs) Handles RptViewer.Click
        If RadioButton1.Checked = True Then ' Medication Slip

            Path = "" & frmLogin.ReportsPath & "\HR\Medication\PatientSlip.rpt"
            If byDaterange.Checked = True Then '' By Date range
                Flag = False
                If RadioDeptAll.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate}  In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton9.Checked = True '' By Card range
                If RadioDeptAll.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = " {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If


                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "'  And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "'  And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "'  And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If
                End If




            End If
        End If



        If RadioButton4.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\Medication\MedicineLedger.rpt"
            If byDaterange.Checked = True Then '' By Date range
                Flag = False

                Filter = "{View_Medi_Ledger.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton10.Checked = True
                Filter = "{View_Medi_Ledger.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item_Head.L1Name} =  '" & L1IDComboBox.Text & "'"

            ElseIf ByMedican.Checked = True

                Filter = "{View_Medi_Ledger.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item.L2Name}=  '" & ComboBox1.Text & "'"

            End If
        End If



        If RadioButton12.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\Medication\MedicineBalance.rpt"
            If byDaterange.Checked = True Then '' By Date range
                Flag = False

                Filter = "{View_Medi_Ledger.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton10.Checked = True
                Filter = "{View_Medi_Ledger.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item_Head.L1Name} =  '" & L1IDComboBox.Text & "'"

            ElseIf ByMedican.Checked = True

                Filter = "{View_Medi_Ledger.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item.L2Name}=  '" & ComboBox1.Text & "'"

            End If
        End If
        If RadioButton2.Checked = True Then '' transaction IN 
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\Medication\MedicationIn.rpt"
            If byDaterange.Checked = True Then '' By Date range


                Filter = "{tbl_HRM_Emp_Medication_IN.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton10.Checked = True
                Filter = "{tbl_HRM_Emp_Medication_IN.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item_Head.L1Name}=  '" & L1IDComboBox.Text & "'"

            ElseIf ByMedican.Checked = True

                Filter = "{tbl_HRM_Emp_Medication_IN.TranDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item.L2Name}=  '" & ComboBox1.Text & "'"

            End If
        End If


        If RadioButton3.Checked = True Then '' transaction IN 
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\Medication\MedicationOUT.rpt"
            If byDaterange.Checked = True Then '' By Date range


                Filter = "{View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton10.Checked = True
                Filter = "{View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item_Head.L1Name}='" & L1IDComboBox.Text & "' "


            ElseIf ByMedican.Checked = True

                Filter = "{View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Medi_TransOut_Union.L2Name}='" & ComboBox1.Text & "' "

            End If
        End If

        If RadioButton5.Checked = True Then ' patient Appointment

            Path = "" & frmLogin.ReportsPath & "\HR\Medication\incomingpatient.rpt"
            If byDaterange.Checked = True Then '' By Date range
                Flag = False
                If RadioDeptAll.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit}  In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton9.Checked = True '' By Card range
                If RadioDeptAll.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = " {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If


                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "'  And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "'  And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "'  And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If
                End If


            ElseIf ByMedican.Checked = True
                Flag = False
                If RadioDeptAll.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit}  In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {tbl_HRM_Emp_Medication.NextVisit} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If

            End If
        End If








        If RadioButton6.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\Medication\Medicinecategory.rpt"
            Flag = False
            If byDaterange.Checked = True Then
                Filter = ""
            ElseIf ByCatagery.Checked = True Then ''ByCatagery


                Filter = "{tbl_HRM_Emp_Medication_Rec_Head.MadicationHead}= '" & MadicationHeadComboBox.Text & "'"
            End If
        End If





        If RadioButton7.Checked = True Then '' Employee Against medicans


            If byDaterange.Checked = True Then '' By Date range
                Path = "" & frmLogin.ReportsPath & "\HR\Medication\Employeeagainstmedicine.rpt"
                Flag = False
                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate}  In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton9.Checked = True '' By Card range
                Path = "" & frmLogin.ReportsPath & "\HR\Medication\Employeeagainstmedicinehistory.rpt"
                If RadioDeptAll.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = " {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If


                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "'  And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "'  And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "'  And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If
                End If

            ElseIf RadioButton10.Checked = True
                Path = "" & frmLogin.ReportsPath & "\HR\Medication\Employeeagainstmedicine.rpt"
                Flag = False
                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item_Head.L1Name}= '" & L1IDComboBox.Text & "'"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate}  In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item_Head.L1Name}= '" & L1IDComboBox.Text & "' "
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# {tbl_HRM_Emp_Med_Item_Head.L1Name}= '" & L1IDComboBox.Text & "'"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {tbl_HRM_Emp_Med_Item_Head.L1Name}= '" & L1IDComboBox.Text & "'"
                End If
            ElseIf ByMedican.Checked = True
                Path = "" & frmLogin.ReportsPath & "\HR\Medication\Employeeagainstmedicine.rpt"
                Flag = False
                If RadioDeptAll.Checked = True Then
                    Filter = "{View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Medi_TransOut_Union.L2Name}= '" & ComboBox1.Text & "'"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate}  In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Medi_TransOut_Union.L2Name}= '" & ComboBox1.Text & "'"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Medi_TransOut_Union.L2Name}= '" & ComboBox1.Text & "'"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {View_Medi_TransOut_Union.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And {View_Medi_TransOut_Union.L2Name}= '" & ComboBox1.Text & "'"
                End If

            End If
        End If







        If RadioButton8.Checked = True Then
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\Medication\MedicineChart.rpt"
            If byDaterange.Checked = True Then
                Filter = "{tbl_HRM_Emp_Med_Item_Head.L1ID} > 0"
            ElseIf RadioButton10.Checked = True Then ''prd Code

                Filter = "{tbl_HRM_Emp_Med_Item_Head.L1ID} = " & L1IDComboBox.SelectedValue & ""
            ElseIf ByMedican.Checked = True
                Filter = "{tbl_HRM_Emp_Med_Item.L2Name} = '" & ComboBox1.Text & "'"
            End If
        End If




        If RadioButton11.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\Medication\PatientVisitRecord.rpt"
            If byDaterange.Checked = True Then '' By Date range
                Flag = False
                If RadioDeptAll.Checked = True Then
                    Filter = "{tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf MainDeptBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate}  In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf SectBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBtn.Checked = True Then
                    Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "#"
                End If
            ElseIf RadioButton9.Checked = True '' By Card range
                If RadioDeptAll.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = " {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf MainDeptBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If


                ElseIf SectBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "'  And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DeptName} = '" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_AllEmployees.SectionName}  = '" & NameComboBox.Text & "'  And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If

                ElseIf DesigBtn.Checked = True Then
                    If FrmCrd.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If Tocrd.Text = "" Then
                        Filter = "{View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "'  And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & FrmCrd.Text & " "
                    Else
                        Filter = " {View_Rpt_Acc_AllEmployees.DesigName} = '" & DesigComboBox.Text & "' And {tbl_HRM_Emp_Medication.CheckDate} In #" & Format(Me.MonthPicker.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# And  {View_Rpt_Acc_AllEmployees.CardNo} In " & FrmCrd.Text & " To " & Tocrd.Text & " "
                    End If
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        byDaterange.Checked = True

        If RadioButton2.Checked = True Then
            Panel2.Enabled = False
            RadioButton9.Enabled = False
            ByMedican.Enabled = True
            RadioButton10.Enabled = True

            byDaterange.Enabled = True
        Else
            byDaterange.Enabled = False
            ByMedican.Enabled = False
            Panel2.Enabled = True
            ByMedican.Enabled = False
            RadioButton9.Enabled = True
            RadioButton10.Enabled = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        byDaterange.Checked = True

        If RadioButton3.Checked = True Then
            Panel2.Enabled = False
            RadioButton9.Enabled = False
            ByMedican.Enabled = True
            RadioButton10.Enabled = True
            byDaterange.Enabled = True
        Else
            byDaterange.Enabled = False
            ByMedican.Enabled = False
            Panel2.Enabled = True
            ByMedican.Enabled = False
            RadioButton9.Enabled = True
            RadioButton10.Enabled = False

        End If
    End Sub


    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        byDaterange.Checked = True
        If RadioButton6.Checked = True Then
            byDaterange.Enabled = True
            RadioButton9.Enabled = False
            Panel2.Enabled = False
            ByCatagery.Enabled = True
            byDaterange.Text = "All"
            MonthPicker.Enabled = False
            DateTimePicker1.Enabled = False
            RadioButton10.Enabled = False
        Else
            byDaterange.Text = "By Date Range"
            ByCatagery.Enabled = False
            byDaterange.Enabled = True
            RadioButton9.Enabled = True
            Panel2.Enabled = True
            MonthPicker.Enabled = True
            DateTimePicker1.Enabled = True
            RadioButton10.Enabled = True
        End If
    End Sub

    Private Sub ByCatagery_CheckedChanged(sender As Object, e As EventArgs) Handles ByCatagery.CheckedChanged
        If ByCatagery.Checked = True Then
            MadicationHeadComboBox.Enabled = True
        Else
            MadicationHeadComboBox.Enabled = False

        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        byDaterange.Checked = True
        If RadioButton8.Checked = True Then
            byDaterange.Enabled = True
            RadioButton9.Enabled = False
            Panel2.Enabled = False
            RadioButton10.Enabled = True
            byDaterange.Text = "All"
            MonthPicker.Enabled = False
            DateTimePicker1.Enabled = False
            ByCatagery.Enabled = False
            ByMedican.Enabled = True
        Else
            byDaterange.Text = "By Date Range"
            RadioButton10.Enabled = False
            byDaterange.Enabled = True
            RadioButton9.Enabled = True
            Panel2.Enabled = True
            MonthPicker.Enabled = True
            DateTimePicker1.Enabled = True
            ByMedican.Enabled = False

        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            L1IDComboBox.Enabled = True
        Else
            L1IDComboBox.Enabled = False
        End If
    End Sub

    Private Sub ByMedican_CheckedChanged(sender As Object, e As EventArgs) Handles ByMedican.CheckedChanged
        If ByMedican.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        byDaterange.Checked = True
        If RadioButton4.Checked = True Then
            byDaterange.Enabled = True
            ByMedican.Enabled = True
            RadioButton10.Enabled = True
            RadioButton9.Enabled = False
        Else
            ByMedican.Enabled = False
            byDaterange.Enabled = False
            RadioButton10.Enabled = True
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        byDaterange.Checked = True
        If RadioButton5.Checked = True Then
            byDaterange.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Enabled = False

        Else
            byDaterange.Enabled = False
            RadioButton9.Enabled = False
            RadioButton10.Enabled = False

        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        byDaterange.Checked = True

        If RadioButton7.Checked = True Then
            byDaterange.Enabled = True
            RadioButton9.Enabled = True
            ByMedican.Enabled = True
            RadioButton10.Enabled = True

        Else
            byDaterange.Enabled = False
            RadioButton9.Enabled = False
            ByMedican.Enabled = False
            RadioButton10.Enabled = False

        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        byDaterange.Checked = True
        If RadioButton11.Checked = True Then
            byDaterange.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Enabled = False


        Else
            byDaterange.Enabled = False
            RadioButton9.Enabled = False
            RadioButton10.Enabled = False


        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            byDaterange.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Enabled = False

        Else
            byDaterange.Enabled = False
            RadioButton9.Enabled = False
            RadioButton10.Enabled = False

        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        byDaterange.Checked = True
        If RadioButton12.Checked = True Then
            byDaterange.Enabled = True
            ByMedican.Enabled = True
            RadioButton10.Enabled = True
            RadioButton9.Enabled = False
        Else
            ByMedican.Enabled = False
            byDaterange.Enabled = False
            RadioButton10.Enabled = True
        End If
    End Sub
End Class