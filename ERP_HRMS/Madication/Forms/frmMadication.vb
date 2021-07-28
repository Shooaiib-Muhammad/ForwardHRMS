Public Class frmMadication
    Private Sub frmMadication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_ID4' table. You can move, or remove it, as needed.
        Me.View_Treatment_ID4TableAdapter.Fill(Me.DSMedication.View_Treatment_ID4)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_ID3' table. You can move, or remove it, as needed.
        Me.View_Treatment_ID3TableAdapter.Fill(Me.DSMedication.View_Treatment_ID3)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_ID2' table. You can move, or remove it, as needed.
        Me.View_Treatment_ID2TableAdapter.Fill(Me.DSMedication.View_Treatment_ID2)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_ID1' table. You can move, or remove it, as needed.
        Me.View_Treatment_ID1TableAdapter.Fill(Me.DSMedication.View_Treatment_ID1)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_ID' table. You can move, or remove it, as needed.
        Me.View_Treatment_IDTableAdapter.Fill(Me.DSMedication.View_Treatment_ID)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Med_Item' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_Med_ItemTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Med_Item)
        'TODO: This line of code loads data into the 'DSMedication.View_Refer_To' table. You can move, or remove it, as needed.
        Me.View_Refer_ToTableAdapter.Fill(Me.DSMedication.View_Refer_To)
        'TODO: This line of code loads data into the 'DSMedication.View_Refer_To' table. You can move, or remove it, as needed.
        Me.View_Refer_ToTableAdapter.Fill(Me.DSMedication.View_Refer_To)
        'TODO: This line of code loads data into the 'DSMedication.View_Recommended_Test_4' table. You can move, or remove it, as needed.
        Me.View_Recommended_Test_4TableAdapter.Fill(Me.DSMedication.View_Recommended_Test_4)
        'TODO: This line of code loads data into the 'DSMedication.View_Recommended_Test_3' table. You can move, or remove it, as needed.
        Me.View_Recommended_Test_3TableAdapter.Fill(Me.DSMedication.View_Recommended_Test_3)
        'TODO: This line of code loads data into the 'DSMedication.View_Recommended_Test_2' table. You can move, or remove it, as needed.
        Me.View_Recommended_Test_2TableAdapter.Fill(Me.DSMedication.View_Recommended_Test_2)
        'TODO: This line of code loads data into the 'DSMedication.View_Recommended_Test_1' table. You can move, or remove it, as needed.
        Me.View_Recommended_Test_1TableAdapter.Fill(Me.DSMedication.View_Recommended_Test_1)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Medication' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_MedicationTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Medication)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_Category_5' table. You can move, or remove it, as needed.
        Me.View_Treatment_Category_5TableAdapter.Fill(Me.DSMedication.View_Treatment_Category_5)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_Category_4' table. You can move, or remove it, as needed.
        Me.View_Treatment_Category_4TableAdapter.Fill(Me.DSMedication.View_Treatment_Category_4)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_Category_3' table. You can move, or remove it, as needed.
        Me.View_Treatment_Category_3TableAdapter.Fill(Me.DSMedication.View_Treatment_Category_3)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_Category_2' table. You can move, or remove it, as needed.
        Me.View_Treatment_Category_2TableAdapter.Fill(Me.DSMedication.View_Treatment_Category_2)
        'TODO: This line of code loads data into the 'DSMedication.View_Treatment_Category_1' table. You can move, or remove it, as needed.
        Me.View_Treatment_Category_1TableAdapter.Fill(Me.DSMedication.View_Treatment_Category_1)
        'TODO: This line of code loads data into the 'DSMedication.View_Recommended_Test_4' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DSMedication.View_Diagnosis_Category_5' table. You can move, or remove it, as needed.
        Me.View_Diagnosis_Category_5TableAdapter.Fill(Me.DSMedication.View_Diagnosis_Category_5)
        'TODO: This line of code loads data into the 'DSMedication.View_Diagnosis_Category_4' table. You can move, or remove it, as needed.
        Me.View_Diagnosis_Category_4TableAdapter.Fill(Me.DSMedication.View_Diagnosis_Category_4)
        'TODO: This line of code loads data into the 'DSMedication.View_Diagnosis_Category_3' table. You can move, or remove it, as needed.
        Me.View_Diagnosis_Category_3TableAdapter.Fill(Me.DSMedication.View_Diagnosis_Category_3)

        'TODO: This line of code loads data into the 'DSMedication.View_Diagnosis_Category_2' table. You can move, or remove it, as needed.
        Me.View_Diagnosis_Category_2TableAdapter.Fill(Me.DSMedication.View_Diagnosis_Category_2)
        'TODO: This line of code loads data into the 'DSMedication.View_Diagnosis_Category_1' table. You can move, or remove it, as needed.
        Me.View_Diagnosis_Category_1TableAdapter.Fill(Me.DSMedication.View_Diagnosis_Category_1)
        'TODO: This line of code loads data into the 'DSMedication.tbl_HRM_Emp_Info' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_Emp_InfoTableAdapter.Fill(Me.DSMedication.tbl_HRM_Emp_Info)
        LoardRecord()
        Try
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSMedication.View_Rpt_Acc_AllEmployees, CType(cardNo.Text, Integer))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
        leaves()
        Clear()
    End Sub
    Private Sub Clear()
        ComboDiagnose1.Text = ""
        ComboDiagnose2.Text = ""
        ComboDiagnose3.Text = ""
        ComboDiagnose4.Text = ""
        ComboDiagnose5.Text = ""
        ComboTreatment1.Text = ""
        ComboTreatment2.Text = ""
        ComboTreatment3.Text = ""
        ComboTreatment4.Text = ""

        ComboTreatment5.Text = ""
        ComboTest2.Text = ""
        ComboTest3.Text = ""
        ComboTest4.Text = ""

        ComboTest1.Text = ""
        ComboReferTo.Text = ""
        SeverityComboBox.Text = ""
        SeverityComboBox.Text = ""
        LeaveCombo.Text = ""
        TextQty1.Text = ""
        TextQty2.Text = ""
        TextQty3.Text = ""
        TextQty4.Text = ""
        TextQty5.Text = ""


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDiagnose1.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        MaskedTextBox1.Text = DateTimePicker1.Text
    End Sub

    'Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
    '    If MaskedTextBox1.Text = "  -  -" Then
    '        MaskedTextBox1.Text = DateTimePicker1.Text
    '    End If
    'End Sub



    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub cardNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cardNo.SelectedIndexChanged
        Try
            Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSMedication.View_Rpt_Acc_AllEmployees, CType(cardNo.Text, Integer))
        Catch ex As System.Exception
            'System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try
        leaves()
        Clear()
    End Sub

    Private Sub Tbl_HRM_Emp_InfoBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_Emp_InfoBindingSource.PositionChanged

    End Sub
    Private Function StartDate() As DateTime
        Dim DOJ As DateTime = DateOfJoinging.Text
        Dim ConStart As DateTime
        ConStart = CType(DOJ.Day & "/" & DOJ.Month & "/" & Now.Date.Year, Date)
        If ConStart < Now.Date Then
            'If ConStart < DateTime.Now.AddDays(-32) Then
            ConStart = ConStart
        Else
            ConStart = CType(DOJ.Day & "/" & DOJ.Month & "/" & Now.Date.Year - 1, Date)
        End If
        Return ConStart
    End Function
    Private Function EndDate() As DateTime
        Dim EOCDate As DateTime
        Dim ContractStartDate As DateTime = StartDate()
        EOCDate = AddOneYearToDate(ContractStartDate)
        Return EOCDate
    End Function
    Private Function AddOneYearToDate(ByVal ReceivingDate As Date)
        Dim ReturnDate As Date
        If IsLeapYear(ReceivingDate.Year) Then
            If ReceivingDate.Month >= 1 And ReceivingDate.Month <= 2 Then
                ReturnDate = DateAdd(DateInterval.Day, 365, ReceivingDate)
            Else
                ReturnDate = DateAdd(DateInterval.Day, 364, ReceivingDate)
            End If
        ElseIf IsLeapYear(ReceivingDate.Year + 1) Then
            If ReceivingDate.Month >= 1 And ReceivingDate.Month <= 2 Then
                ReturnDate = DateAdd(DateInterval.Day, 364, ReceivingDate)
            Else
                ReturnDate = DateAdd(DateInterval.Day, 365, ReceivingDate)
            End If
        Else
            ReturnDate = DateAdd(DateInterval.Day, 364, ReceivingDate)
        End If
        Return ReturnDate

    End Function
    Private Function IsLeapYear(ByVal yyy As Int16) As Boolean
        Dim IsLeap As Boolean
        If (yyy Mod 4 = 0) And (yyy Mod 100 <> 0 Or yyy Mod 400 = 0) Then
            IsLeap = True
        Else
            IsLeap = False
        End If
        Return IsLeap
    End Function
    Private Sub leaves()
        Try
            Me.Tbl_PayRoll_LongLeavesTableAdapter.Fill(Me.DSMedication.tbl_PayRoll_LongLeaves, StartDate, EndDate, CType(cardNo.SelectedValue, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Tbl_PayRoll_LongLeavesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_PayRoll_LongLeavesDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_PayRoll_LongLeavesDataGridView.DataError

    End Sub






    Private Sub LoardRecord()
        Try
            Me.View_MadicationTableAdapter.Fill(Me.DSMedication.View_Madication, New System.Nullable(Of Date)(CType(Now.Date, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim nextvisit As Date
        ''nextvisit = MaskedTextBox1.Text
        'If MaskedTextBox1.Text = "  -  -" Then
        '    nextvisit = Nothing
        'Else
        '    nextvisit = MaskedTextBox1.Text
        'End If
        If ComboDiagnose1.Text = "" Then
            ComboDiagnose1.Text = Nothing
        End If
        If ComboDiagnose2.Text = "" Then
            ComboDiagnose2.Text = Nothing
        End If
        If ComboDiagnose3.Text = "" Then
            ComboDiagnose3.Text = Nothing
        End If
        If ComboDiagnose4.Text = "" Then
            ComboDiagnose4.Text = Nothing
        End If
        If ComboDiagnose5.Text = "" Then
            ComboDiagnose5.Text = Nothing
        End If
        If ComboTest1.Text = "" Then
            ComboTest1.Text = Nothing
        End If
        If ComboTest2.Text = "" Then
            ComboTest2.Text = Nothing
        End If
        If ComboTest3.Text = "" Then
            ComboTest3.Text = Nothing
        End If
        If ComboTest4.Text = "" Then
            ComboTest4.Text = Nothing
        End If
        If ComboTreatment1.Text = "" Then
            ComboTreatment1.SelectedValue = 0
        End If
        If ComboTreatment2.Text = "" Then
            ComboTreatment2.SelectedValue = 0
        End If
        If ComboTreatment3.Text = "" Then
            ComboTreatment3.SelectedValue = 0
        End If
        If ComboTreatment4.Text = "" Then
            ComboTreatment4.SelectedValue = 0
        End If
        If ComboTreatment5.Text = "" Then
            ComboTreatment5.SelectedValue = 0
        End If
        If TextQty1.Text = "" Then
            TextQty1.Text = 0
        End If
        If TextQty2.Text = "" Then
            TextQty2.Text = 0
        End If
        If TextQty3.Text = "" Then
            TextQty3.Text = 0
        End If
        If TextQty4.Text = "" Then
            TextQty4.Text = 0
        End If
        If TextQty5.Text = "" Then
            TextQty5.Text = 0
        End If
        If SeverityComboBox.Text = "" Then
            MsgBox("please Enter Severity")
        Else

            'If MaskedTextBox1.Text = "  -  -" Then
            '    nextvisit = Nothing
            'Else
            '    nextvisit = MaskedTextBox1.Text
            'End If
            If MaskedTextBox1.Text = "  /  /" Then
                Me.Tbl_HRM_Emp_MedicationTableAdapter.Insert(cardNo.SelectedValue, Val(Agelabel.Text), Now.Date, Now, ComboDiagnose1.Text, ComboDiagnose2.Text, ComboDiagnose3.Text, ComboDiagnose4.Text, ComboDiagnose5.Text, Nothing, Nothing, Nothing, Nothing, Nothing, ComboTest1.Text, ComboTest2.Text, ComboTest3.Text, ComboTest4.Text, SeverityComboBox.Text, Nothing, ComboReferTo.Text, Nothing, TextQty1.Text, TextQty2.Text, TextQty3.Text, TextQty4.Text, TextQty5.Text, ComboDes1.Text, ComboDes2.Text, ComboDes3.Text, ComboDes4.Text, ComboDes5.Text, LeaveCombo.Text, ComboTreatment1.SelectedValue, ComboTreatment2.SelectedValue, ComboTreatment3.SelectedValue, ComboTreatment4.SelectedValue, ComboTreatment5.SelectedValue)
            Else
                Me.Tbl_HRM_Emp_MedicationTableAdapter.Insert(cardNo.SelectedValue, Val(Agelabel.Text), Now.Date, Now, ComboDiagnose1.Text, ComboDiagnose2.Text, ComboDiagnose3.Text, ComboDiagnose4.Text, ComboDiagnose5.Text, Nothing, Nothing, Nothing, Nothing, Nothing, ComboTest1.Text, ComboTest2.Text, ComboTest3.Text, ComboTest4.Text, SeverityComboBox.Text, Nothing, ComboReferTo.Text, MaskedTextBox1.Text, TextQty1.Text, TextQty2.Text, TextQty3.Text, TextQty4.Text, TextQty5.Text, ComboDes1.Text, ComboDes2.Text, ComboDes3.Text, ComboDes4.Text, ComboDes5.Text, LeaveCombo.Text, ComboTreatment1.SelectedValue, ComboTreatment2.SelectedValue, ComboTreatment3.SelectedValue, ComboTreatment4.SelectedValue, ComboTreatment5.SelectedValue)
            End If

            LoardRecord()
            MessageBox.Show("Record Successfully Saved ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()



        End If
    End Sub



    Private Sub View_MadicationDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles View_MadicationDataGridView.CellEnter

    End Sub

    Private Sub View_MadicationDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles View_MadicationDataGridView.CellContentClick
        If e.ColumnIndex = 7 Then
            Dim Obj As New UtilityClass
            Dim Filter As String = ""
            Dim Path As String = ""
            Dim Param As String = ""
            Path = "" & frmLogin.ReportsPath & "\HR\Medication\PatientSlip.rpt"
            Dim SlipNo As Integer = View_MadicationDataGridView("SrNo", e.RowIndex).Value
            Filter = "{tbl_HRM_Emp_Medication.SrNo} = " & SlipNo & ""
            Obj.LoadCardReports(Path, Filter, Param)
        ElseIf e.ColumnIndex = 8 Then
            Dim DialogRes As DialogResult
            DialogRes = MessageBox.Show("Are you Sure you want To delete selected Record", "Undo Termination", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If DialogRes = 6 Then
                Try
                    Me.Tbl_HRM_Emp_MedicationTableAdapter.DeleteQuery(View_MadicationDataGridView("SrNo", e.RowIndex).Value)
                    'View_MadicationBindingSource.RemoveCurrent()
                    MsgBox("Record Deleted")
                    LoardRecord()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
    End Sub

    Private Sub View_MadicationDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles View_MadicationDataGridView.DataError

    End Sub
End Class