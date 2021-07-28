Public Class FrmShopReports


    Private Sub FrmShopReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSShop.tbl_Shop_Supplier' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_SupplierTableAdapter.Fill(Me.DSShop.tbl_Shop_Supplier)
        'TODO: This line of code loads data into the 'DSShop.tbl_Shop_Item' table. You can move, or remove it, as needed.
        Me.Tbl_Shop_ItemTableAdapter.Fill(Me.DSShop.tbl_Shop_Item)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Designation' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DesignationTableAdapter.Fill(Me.DSHRM.tbl_HRM_Designation)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Section' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_SectionTableAdapter.Fill(Me.DSHRM.tbl_HRM_Section)
        'TODO: This line of code loads data into the 'DSHRM.tbl_HRM_Dept' table. You can move, or remove it, as needed.
        Me.Tbl_HRM_DeptTableAdapter.Fill(Me.DSHRM.tbl_HRM_Dept)
        RadioButton2.Enabled = True
        byCardRange.Enabled = True

        RadioButton3.Enabled = True
    End Sub

    Private Sub MainDept_CheckedChanged(sender As Object, e As EventArgs) Handles MainDept.CheckedChanged
        If MainDept.Checked = True Then
            DeptNameComboBox.Enabled = True
        Else
            DeptNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub Section_CheckedChanged(sender As Object, e As EventArgs) Handles Section.CheckedChanged
        If Section.Checked = True Then
            DeptNameComboBox.Enabled = True
            NameComboBox.Enabled = True
        Else
            DeptNameComboBox.Enabled = False
            NameComboBox.Enabled = False
        End If
    End Sub

    Private Sub DesigBTn_CheckedChanged(sender As Object, e As EventArgs) Handles DesigBTn.CheckedChanged
        If DesigBTn.Checked = True Then
            DesigNameComboBox.Enabled = True
        Else
            DesigNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            PaymentMode.Enabled = True

        Else
            PaymentMode.Enabled = False

        End If
        If RadioButton5.Checked = True Or RadioButton1.Checked = True Or RadioButton8.Checked = True Then
            Frmcard.Enabled = True
            tocard.Enabled = True
        Else
            Frmcard.Enabled = False
            tocard.Enabled = False
        End If


    End Sub





    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        RadioButton3.Checked = True

        If RadioButton5.Checked = True Then
            RadioButton2.Enabled = True
            byCardRange.Enabled = True
            RadioButton14.Enabled = True
            RadioButton3.Enabled = True
            RadioButton15.Enabled = True
        Else
            RadioButton14.Enabled = False
            RadioButton3.Enabled = False
            RadioButton2.Enabled = False
            byCardRange.Enabled = False
            RadioButton15.Enabled = False

        End If
    End Sub

    Private Sub byCardRange_CheckedChanged(sender As Object, e As EventArgs) Handles byCardRange.CheckedChanged
        If byCardRange.Checked = True Then
            Frmcard.Enabled = True
            tocard.Enabled = True

        Else
            Frmcard.Enabled = False
            tocard.Enabled = False


        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton3.Checked = True

        If RadioButton1.Checked = True Then
            RadioButton2.Enabled = True
            byCardRange.Enabled = True

            RadioButton3.Enabled = True
        Else
            RadioButton3.Enabled = False
            RadioButton2.Enabled = False
            byCardRange.Enabled = False

        End If
    End Sub
    Dim Flag As Boolean = False
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim Filter As String = ""
    '    Dim Param As String = ""
    '    Dim Path As String = ""
    '    Dim Obj As New UtilityClass
    '    If Radio_OT.Checked = True Then 'TranSaction In
    '        Flag = False
    '        Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\fairshop_transactionIN.rpt"
    '        If RadioButton3.Checked = True Then '' By Date range


    '            Filter = " {View_HRMS_FairShop_IN.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '        ElseIf RadioButton7.Checked = True

    '            Filter = " {View_HRMS_FairShop_IN.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_HRMS_FairShop_IN.ItemName} ='" & ComboBox1.Text & "'"
    '        ElseIf RadioButton9.Checked = True

    '            Filter = " {View_HRMS_FairShop_IN.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_HRMS_FairShop_IN.SupplierName}  ='" & SupplierNameComboBox.Text & "'"

    '        End If



    '    End If
    '    If RadioButton1.Checked = True Then 'TranSaction OUt
    '        Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\fairshop_transactionOUT.rpt"
    '        If RadioButton3.Checked = True Then '' By Date ranges
    '            Flag = False
    '            If RadioDeptAll.Checked = True Then


    '                Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

    '            ElseIf MainDept.Checked = True Then ' main Dep
    '                Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                Filter = "{View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            ElseIf DesigBTn.Checked = True Then ' Desig Wise
    '                Filter = "{View_HRMS_FairShop_OUT.desigName} = '" & DesigNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            End If

    '        ElseIf RadioButton2.Checked = True ' by Payment MODe



    '            If RadioDeptAll.Checked = True Then ' By Emp
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If

    '            ElseIf MainDept.Checked = True Then ' main Dept
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf DesigBTn.Checked = True ' Desig Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '            End If











    '        ElseIf byCardRange.Checked = True
    '            If RadioDeptAll.Checked = True Then ' By Emp
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If

    '            ElseIf MainDept.Checked = True Then ' main Dept
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = " {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf DesigBTn.Checked = True ' Desig Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '            End If
    '        End If

    '    End If




    '    If RadioButton5.Checked = True Then '' Invoice 
    '        Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\FairShopInvoice.rpt"
    '        If RadioButton3.Checked = True Then '' By Date ranges
    '            Flag = False
    '            If RadioDeptAll.Checked = True Then


    '                Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

    '            ElseIf MainDept.Checked = True Then ' main Dep
    '                Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                Filter = "{View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            ElseIf DesigBTn.Checked = True Then ' Desig Wise
    '                Filter = "{View_HRMS_FairShop_OUT.desigName} = '" & DesigNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            End If

    '        ElseIf RadioButton2.Checked = True ' by Payment MODe

    '            If RadioDeptAll.Checked = True Then ' By Emp
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And   {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If

    '            ElseIf MainDept.Checked = True Then ' main Dept
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And   {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And   {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf DesigBTn.Checked = True ' Desig Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '            End If





    '        ElseIf byCardRange.Checked = True
    '            If RadioDeptAll.Checked = True Then ' By Emp
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If

    '            ElseIf MainDept.Checked = True Then ' main Dept
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = " {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf DesigBTn.Checked = True ' Desig Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '            End If
    '        End If
    '    End If

    '    If RadioButton4.Checked = True Then
    '        Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\RptInvLedger.rpt"
    '        Param = "FirstDate=#" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "#"
    '        If RadioButton3.Checked = True Then '' By Date ranges

    '            Filter = " {View_Inv_Tran_Main.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

    '        ElseIf RadioButton7.Checked = True

    '            Filter = "{View_Inv_Tran_Main.ItemID} = " & ComboBox1.SelectedValue & " And  {View_Inv_Tran_Main.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"




    '        End If
    '    End If

    '    If RadioButton6.Checked = True Then
    '        Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\rptStockBalance.rpt"
    '        'Filter = " {View_Inv_Tran_Main.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

    '    End If



    '    If RadioButton8.Checked = True Then
    '        Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\RptFairShoppaid.rpt"
    '        If RadioButton3.Checked = True Then '' By Date ranges
    '            Flag = False
    '            If RadioDeptAll.Checked = True Then


    '                Filter = "{View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""

    '            ElseIf MainDept.Checked = True Then ' main Dep
    '                Filter = " {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                Filter = "{View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '            ElseIf DesigBTn.Checked = True Then ' Desig Wise
    '                Filter = "{View_Rpt_Acc_ShortTermAdvances.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '            End If

    '        ElseIf RadioButton2.Checked = True ' by Payment MODe




    '            If RadioDeptAll.Checked = True Then ' By Emp
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                Else

    '                    Filter = "{View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                End If

    '            ElseIf MainDept.Checked = True Then ' main Dept
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "{View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                Else

    '                    Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                Else

    '                    Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf DesigBTn.Checked = True ' Desig Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                Else

    '                    Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                End If
    '            End If




    '        ElseIf byCardRange.Checked = True
    '            If RadioDeptAll.Checked = True Then ' By Emp
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                Else

    '                    Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                End If

    '            ElseIf MainDept.Checked = True Then ' main Dept
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                Else

    '                    Filter = "  {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                Else

    '                    Filter = " {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf DesigBTn.Checked = True ' Desig Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_Rpt_Acc_ShortTermAdvances.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                Else

    '                    Filter = "  {View_Rpt_Acc_ShortTermAdvances.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
    '                End If
    '            End If
    '        End If
    '    End If


    '    If RadioButton10.Checked = True Then '' Employee Daily Summary
    '        Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\fairshop_transactionOUTSummary.rpt"
    '        If RadioButton3.Checked = True Then '' By Date ranges
    '            Flag = False
    '            If RadioDeptAll.Checked = True Then


    '                Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

    '            ElseIf MainDept.Checked = True Then ' main Dep
    '                Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                Filter = "{View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            ElseIf DesigBTn.Checked = True Then ' Desig Wise
    '                Filter = "{View_HRMS_FairShop_OUT.desigName} = '" & DesigNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            End If

    '        ElseIf byCardRange.Checked = True Then

    '            If RadioDeptAll.Checked = True Then ' By Emp
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If

    '            ElseIf MainDept.Checked = True Then ' main Dept
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = " {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf DesigBTn.Checked = True Then ' Desig Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '            End If
    '        End If


    '    End If
    '    If RadioButton11.Checked = True Then '' Employee Daily Item Summary
    '        Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\fairshop_transactionOUTItemSummary.rpt"
    '        If RadioButton3.Checked = True Then '' By Date ranges
    '            Flag = False
    '            If RadioDeptAll.Checked = True Then


    '                Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

    '            ElseIf MainDept.Checked = True Then ' main Dep
    '                Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                Filter = "{View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            ElseIf DesigBTn.Checked = True Then ' Desig Wise
    '                Filter = "{View_HRMS_FairShop_OUT.desigName} = '" & DesigNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '            End If

    '        ElseIf byCardRange.Checked = True Then

    '            If RadioDeptAll.Checked = True Then ' By Emp
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If

    '            ElseIf MainDept.Checked = True Then ' main Dept
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf Section.Checked = True Then ' Section Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = " {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '                'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
    '            ElseIf DesigBTn.Checked = True Then ' Desig Wise
    '                If Frmcard.Text.Length = 0 Then
    '                    Flag = True
    '                Else
    '                    Flag = False
    '                End If
    '                If tocard.Text = "" Then

    '                    Filter = "  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                Else

    '                    Filter = "  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
    '                End If
    '            End If
    '        End If


    '    End If












    '    If Flag = True Then
    '        MessageBox.Show("Start Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    Else
    '        Flag = False
    '        Obj.LoadReports(Path, Filter, Param)
    '    End If
    'End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Drive As String = ""

        Dim Filter As String = ""
        Dim Param As String = ""
        Dim Path As String = ""
        Dim Obj As New UtilityClass
        If RadioButton12.Checked = True Then
            Drive = "Shop"
        ElseIf RadioButton13.Checked = True Then
            Drive = "Shopint"

        End If
        If Radio_OT.Checked = True Then 'TranSaction In
            Flag = False
            Path = "" & frmLogin.ReportsPath & "\HR\" & Drive & "\fairshop_transactionIN.rpt"
            If RadioButton3.Checked = True Then '' By Date range


                Filter = " {View_HRMS_FairShop_IN.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            ElseIf RadioButton7.Checked = True Then

                Filter = " {View_HRMS_FairShop_IN.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_HRMS_FairShop_IN.ItemName} ='" & ComboBox1.Text & "'"
            ElseIf RadioButton9.Checked = True Then

                Filter = " {View_HRMS_FairShop_IN.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {View_HRMS_FairShop_IN.SupplierName}  ='" & SupplierNameComboBox.Text & "'"

            End If



        End If
        If RadioButton1.Checked = True Then 'TranSaction OUt
            Path = "" & frmLogin.ReportsPath & "\HR\" & Drive & "\fairshop_transactionOUT.rpt"
            If RadioButton3.Checked = True Then '' By Date ranges
                Flag = False
                If RadioDeptAll.Checked = True Then


                    Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf MainDept.Checked = True Then ' main Dep
                    Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = "{View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = "{View_HRMS_FairShop_OUT.desigName} = '" & DesigNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf RadioButton2.Checked = True Then ' by Payment MODe



                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If











            ElseIf byCardRange.Checked = True Then

                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = " {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            End If

        End If




        If RadioButton5.Checked = True Then '' Invoice 
            Path = "" & frmLogin.ReportsPath & "\HR\" & Drive & "\FairShopInvoice.rpt"
            If RadioButton3.Checked = True Then '' By Date ranges
                Flag = False
                If RadioDeptAll.Checked = True Then


                    Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf MainDept.Checked = True Then ' main Dep
                    Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = "{View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = "{View_HRMS_FairShop_OUT.desigName} = '" & DesigNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf RadioButton2.Checked = True Then ' by Payment MODe

                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And   {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And   {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And   {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'  And  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If





            ElseIf byCardRange.Checked = True Then

                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = " {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            ElseIf RadioButton14.Checked = True Then
                Flag = False
                Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {@Counter} = '" & ComboBox2.Text & "'"
            ElseIf RadioButton15.Checked = True Then
                Flag = False
                Filter = " {View_HRMS_FairShop_OUT.PaymentMode} =  '" & PaymentMode.Text & "'   And {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "# And {@Counter} = '" & ComboBox2.Text & "'"

            End If
        End If

        If RadioButton4.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\" & Drive & "\RptInvLedger.rpt"
            Param = "FirstDate=#" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "#"
            If RadioButton3.Checked = True Then '' By Date ranges

                Filter = " {View_Inv_Tran_Main.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

            ElseIf RadioButton7.Checked = True Then

                Filter = "{View_Inv_Tran_Main.ItemID} = " & ComboBox1.SelectedValue & " And  {View_Inv_Tran_Main.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"




            End If
        End If

        If RadioButton6.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\Shop\rptStockBalance1.rpt"
            'Filter = " {View_Inv_Tran_Main.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

        End If



        If RadioButton8.Checked = True Then
            Path = "" & frmLogin.ReportsPath & "\HR\" & Drive & "\RptFairShoppaid.rpt"
            If RadioButton3.Checked = True Then '' By Date ranges
                Flag = False
                If RadioDeptAll.Checked = True Then


                    Filter = "{View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""

                ElseIf MainDept.Checked = True Then ' main Dep
                    Filter = " {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = "{View_Rpt_Acc_ShortTermAdvances.desigName} = '" & DesigNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                End If

            ElseIf RadioButton2.Checked = True Then ' by Payment MODe
                If PaymentMode.Text = "Cash" Then
                    Path = "" & frmLogin.ReportsPath & "\HR\" & Drive & "\RptFairShoppaidCash.rpt"
                    Frmcard.Text = 0
                End If



                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    Else

                        Filter = "{View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "{View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    Else

                        Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    Else

                        Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    Else

                        Filter = " {View_Rpt_Acc_ShortTermAdvances.PaymentMode} =  '" & PaymentMode.Text & "'  And {View_Rpt_Acc_ShortTermAdvances.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    End If
                End If




            ElseIf byCardRange.Checked = True Then

                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    Else

                        Filter = "{View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    Else

                        Filter = "  {View_Rpt_Acc_ShortTermAdvances.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    Else

                        Filter = " {View_Rpt_Acc_ShortTermAdvances.DeptName} = '" & DeptNameComboBox.Text & "' And {View_Rpt_Acc_ShortTermAdvances.SectionName} = '" & NameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_Rpt_Acc_ShortTermAdvances.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    Else

                        Filter = "  {View_Rpt_Acc_ShortTermAdvances.Designame} ='" & DesigNameComboBox.Text & "' And  {View_Rpt_Acc_ShortTermAdvances.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_Rpt_Acc_ShortTermAdvances.month}=  " & Format(Me.DateTimePicker1.Value.Month) & " and  {View_Rpt_Acc_ShortTermAdvances.Year}=  " & Format(Me.DateTimePicker1.Value.Year) & ""
                    End If
                End If
            End If
        End If

        If RadioButton11.Checked = True Then '' Employee Daily Item Summary
            Path = "" & frmLogin.ReportsPath & "\HR\" & Drive & "\fairshop_transactionOUTItemSummary.rpt"
            If RadioButton3.Checked = True Then '' By Date ranges
                Flag = False
                If RadioDeptAll.Checked = True Then


                    Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf MainDept.Checked = True Then ' main Dep
                    Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = "{View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = "{View_HRMS_FairShop_OUT.desigName} = '" & DesigNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf byCardRange.Checked = True Then

                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = " {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            End If
            If RadioButton7.Checked Then
                Filter = "{View_HRMS_FairShop_OUT.ItemID}=" & ComboBox1.SelectedValue & " And {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
            End If

        End If
        If RadioButton10.Checked = True Then '' Employee Daily Summary
            Path = "" & frmLogin.ReportsPath & "\HR\" & Drive & "\fairshop_transactionOUTSummary.rpt"
            If RadioButton3.Checked = True Then '' By Date ranges
                Flag = False
                If RadioDeptAll.Checked = True Then


                    Filter = " {View_HRMS_FairShop_OUT.DateName} In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"

                ElseIf MainDept.Checked = True Then ' main Dep
                    Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf Section.Checked = True Then ' Section Wise
                    Filter = "{View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    Filter = "{View_HRMS_FairShop_OUT.desigName} = '" & DesigNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                End If

            ElseIf byCardRange.Checked = True Then

                If RadioDeptAll.Checked = True Then ' By Emp
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "{View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If

                ElseIf MainDept.Checked = True Then ' main Dept
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = " {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.DeptName} ='" & DeptNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf Section.Checked = True Then ' Section Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = " {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                    'Filter = Empstatus & " And  {View_HRMS_FairShop_OUT.DeptName} = '" & DeptNameComboBox.Text & "' And {View_HRMS_FairShop_OUT.SectionName} = '" & NameComboBox.Text & "' And {View_HRMS_FairShop_OUT.AttDate}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#""
                ElseIf DesigBTn.Checked = True Then ' Desig Wise
                    If Frmcard.Text.Length = 0 Then
                        Flag = True
                    Else
                        Flag = False
                    End If
                    If tocard.Text = "" Then

                        Filter = "  {View_HRMS_FairShop_OUT.DesigName} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & Frmcard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    Else

                        Filter = "  {View_HRMS_FairShop_OUT.Designame} ='" & DesigNameComboBox.Text & "' And  {View_HRMS_FairShop_OUT.CardNo} In " & Frmcard.Text & " To " & tocard.Text & " And {View_HRMS_FairShop_OUT.DateName}In #" & Format(Me.DateTimePicker1.Value, "MM/dd/yyyy") & "# To #" & Format(Me.DateTimePicker2.Value, "MM/dd/yyyy") & "#"
                    End If
                End If
            End If


        End If












        If Flag = True Then
            MessageBox.Show("Start Card Number is Missing", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Flag = False
            Obj.LoadReports(Path, Filter, Param)
        End If
    End Sub
    Private Sub Radio_OT_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_OT.CheckedChanged
        RadioButton3.Checked = True
        If Radio_OT.Checked = True Then
            RadioButton3.Enabled = True
            RadioButton7.Enabled = True
            RadioButton9.Enabled = True
            DeptPanel.Enabled = False
        Else
            RadioButton9.Enabled = False
            RadioButton3.Enabled = False
            RadioButton7.Enabled = False
            DeptPanel.Enabled = True
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        RadioButton3.Checked = True
        If RadioButton4.Checked = True Then

            RadioButton3.Enabled = True
            DeptPanel.Enabled = False
            RadioButton7.Enabled = True
        Else
            RadioButton3.Enabled = False
            DeptPanel.Enabled = True
            RadioButton7.Enabled = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            GroupBox1.Enabled = False
            DeptPanel.Enabled = False
            GroupBox3.Enabled = False
        Else
            GroupBox1.Enabled = True
            DeptPanel.Enabled = True
            GroupBox3.Enabled = True
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False

        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        RadioButton3.Checked = True
        If RadioButton8.Checked = True Then
            RadioButton2.Enabled = True
            byCardRange.Enabled = True
            DateTimePicker1.CustomFormat = "MMM, yyyy"
            DateTimePicker2.Visible = False
            Label2.Visible = False
            Label1.Text = "Select Month:"
            RadioButton3.Enabled = True
        Else
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            byCardRange.Enabled = False
            DateTimePicker1.CustomFormat = " dd/MM/yyyy"
            Label1.Text = "From Date:"
            DateTimePicker2.Visible = True

            Label2.Visible = True
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            SupplierNameComboBox.Enabled = True

        Else
            SupplierNameComboBox.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Frmcard.Enabled = False
            tocard.Enabled = False
            PaymentMode.Enabled = False
            ComboBox1.Enabled = False
            SupplierNameComboBox.Enabled = False

        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            RadioButton3.Enabled = True
            byCardRange.Enabled = True
            RadioButton2.Enabled = False
            RadioButton7.Enabled = False
            RadioButton9.Enabled = False
        Else
            RadioButton3.Enabled = False
            byCardRange.Enabled = False
            RadioButton2.Enabled = True
            RadioButton7.Enabled = True
            RadioButton9.Enabled = True
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            RadioButton3.Enabled = True
            byCardRange.Enabled = True
            RadioButton2.Enabled = False
            RadioButton7.Enabled = True
            RadioButton9.Enabled = False
        Else
            RadioButton3.Enabled = False
            byCardRange.Enabled = False
            RadioButton2.Enabled = True
            RadioButton7.Enabled = True
            RadioButton9.Enabled = True
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged

        If RadioButton15.Checked = True Then
            ComboBox2.Enabled = True
            PaymentMode.Enabled = True
        Else
            ComboBox2.Enabled = False
            PaymentMode.Enabled = False
        End If
    End Sub
End Class