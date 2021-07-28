Public Class FrmTransout
    Private Declare Function SQLConfigDataSource Lib "ODBCCP32.DLL" (ByVal hwndParent As Integer, ByVal fRequest As Integer, ByVal lpszDriver As String, ByVal lpszAttributes As String) As Integer

    Dim PaymentMode, TranType, InvoiceNo As String
    Dim MaxInvoiceID As String
    Dim Qty As Double = 1
    Dim MyIP As String = Nothing
    Private Sub Tbl_HRM_TranDateBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_HRM_TranDateBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSint)

    End Sub



    Private Sub FrmTransout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSint.tbl_Shop_Inv_ID' table. You can move, or remove it, as needed.
        'Me.Tbl_Shop_Inv_IDTableAdapter.Fill(Me.DSint.tbl_Shop_Inv_ID)
        Try

            MyIP = System.Net.Dns.Resolve(Environment.MachineName).AddressList(0).ToString()
            Label24.Text = MyIP
            'TODO: This line of code loads data into the 'DSint.tbl_Acc_ShortTermAdvances' table. You can move, or remove it, as needed.
            'Me.Tbl_Acc_ShortTermAdvancesTableAdapter.Fill(Me.DSint.tbl_Acc_ShortTermAdvances)
            ''TODO: This line of code loads data into the 'DSint.tbl_Shop_Tran_Invoice' table. You can move, or remove it, as needed.
            'Me.Tbl_Shop_Tran_InvoiceTableAdapter.Fill(Me.DSint.tbl_Shop_Tran_Invoice)
            ''TODO: This line of code loads data into the 'DSint.tbl_Acc_Salary' table. You can move, or remove it, as needed.
            'Me.Tbl_Acc_SalaryTableAdapter.Fill(Me.DSint.tbl_Acc_Salary)
            'TODO: This line of code loads data into the 'DSint.tbl_Shop_Item_NEW' table. You can move, or remove it, as needed.
            '  Me.Tbl_Shop_Item_NEWTableAdapter.Fill(Me.DSint.tbl_Shop_Item_NEW)
            'Me.View_CardTableAdapter.Fill(Me.DSint.View_Card)
            'TODO: This line of code loads data into the 'DSint.tbl_Shop_Item' table. You can move, or remove it, as needed.
            Me.Tbl_Shop_ItemTableAdapter.FillBy1(Me.DSint.tbl_Shop_Item)
            'TODO: This line of code loads data into the 'DSint.View_Rpt_Acc_AllEmployees' table. You can move, or remove it, as needed.

            If Me.Tbl_HRM_TranDateTableAdapter.Fill(Me.DSint.tbl_HRM_TranDate, Now.Date) > 0 Then
                Me.Tbl_HRM_TranDateTableAdapter.Fill(Me.DSint.tbl_HRM_TranDate, Now.Date.AddDays(0))
            Else
                Me.Tbl_HRM_TranDateTableAdapter.Insert(Now.Date)
                Me.Tbl_HRM_TranDateTableAdapter.Fill(Me.DSint.tbl_HRM_TranDate, Now.Date.AddDays(0))
            End If
            Tbl_HRM_TranDateBindingSource.MoveLast()
            Try
                'Me.View_Tran_OutTableAdapter.Fill(Me.DSint.View_Tran_Out, Me.Label2.Text)
            Catch ex As Exception

            End Try
            Me.TextBox1.TabIndex = 0

            Me.TextBox1.Focus()
            'TODO: This line of code loads data into the 'DSint.tbl_HRM_TranDate' table. You can move, or remove it, as needed.
            Clearlabel()
            clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'DateValue = DateTime.Parse(DateNameLabel1.Text)
        'RadioButton3.ForeColor = Color.DarkGreen
        'RadioButton1.ForeColor = Color.DarkGreen

    End Sub
    Sub GridContentsTotal()
        Dim Target, TotalTarget As Double

        For i As Integer = 0 To Me.Tbl_Shop_Tran_OutDataGridView.RowCount - 1
            Try
                Target = Me.Tbl_Shop_Tran_OutDataGridView(16, i).Value
            Catch ex As Exception
                Target = 0
            End Try
            'Try
            '    Actual = Me.Tbl_PC_CuttingDataGridView(7, i).Value
            'Catch ex As Exception
            '    Actual = 0
            'End Try
            TotalTarget += Target

        Next
        Me.lblPentaTarget.Text = TotalTarget

    End Sub
    Private Sub Clearlabel()
        'TextBox1.Text = ""
        'NameLabel1.Text = ""
        'DesigNameLabel1.Text = ""
        'Label13.Text = ""
        'Label16.Text = ""
        'DeptNameLabel1.Text = ""
        'EmpStatusCheckBox.CheckState = CheckState.Indeterminate
        'PictureBox1.Image = Nothing
        TextQty1.Text = 0
        price.Text = 0
        'Label11.Text = ""
    End Sub

    Private Sub Tbl_Shop_Tran_OutDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_Tran_OutDataGridView.CellContentClick
        If e.ColumnIndex = 18 Then
            If Me.Tbl_Shop_Tran_OutDataGridView(17, e.RowIndex).Value = False Then

                Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You want to Delete Entry", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
                If dgResult = 6 Then
                    Try
                        If RadioButton3.Checked Then
                            Me.CardNoLabel1.Text = 0
                        End If
                        Me.View_Tran_OutTableAdapter.DeleteQuery(Me.Tbl_Shop_Tran_OutDataGridView(1, e.RowIndex).Value)
                        Try
                            FairPrice = Me.Tbl_Acc_SalaryTableAdapter.FairPrice(Me.Label14.Text, Now.Month, Now.Year)
                        Catch ex As Exception
                            FairPrice = 0
                        End Try
                        If CardNoLabel1.Text > 0 Then
                            If BasicSalary.Text <= 30000 Then
                                Limt = 6000
                            Else
                                Limt = 10000
                            End If
                            Limt = Limt - FairPrice
                            CreditLimtTxt.Text = Limt

                        End If

                        Try

                            Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.CardNoLabel1.Text, MyIP)
                        Catch ex As Exception

                        End Try
                        MsgBox("Transaction Deleted")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If

            Else
                MsgBox("Sale Entry Locked So Undo Fail", MsgBoxStyle.Critical)
            End If


        End If
    End Sub

    Private Sub Tbl_Shop_Tran_OutDataGridView_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_Tran_OutDataGridView.CellEnter
        If Me.Tbl_Shop_Tran_OutDataGridView(17, e.RowIndex).Value = True Then
            Me.Tbl_Shop_Tran_OutDataGridView.ReadOnly = True
        Else
            Me.Tbl_Shop_Tran_OutDataGridView.ReadOnly = False
        End If
    End Sub

    Private Sub Tbl_Shop_Tran_OutDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Tbl_Shop_Tran_OutDataGridView.DataError

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.Tbl_Shop_Tran_OutBindingSource.EndEdit()
            Me.Tbl_Shop_Tran_OutTableAdapter.Update(Me.DSint.tbl_Shop_Tran_Out)
            Try
                Me.Tbl_Shop_Tran_OutTableAdapter.FillBy(Me.DSint.tbl_Shop_Tran_Out, Val(Label2.Text))
            Catch ex As Exception

            End Try

            MsgBox("Data Saved Successfully")
            Clearlabel()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Tbl_HRM_TranDateBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles Tbl_HRM_TranDateBindingSource.PositionChanged
        Try
            Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, TextBox1.Text, MyIP)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Tbl_Shop_Tran_OutDataGridView_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles Tbl_Shop_Tran_OutDataGridView.EditingControlShowing


        If TypeOf e.Control Is DataGridViewComboBoxEditingControl Then
            CType(e.Control, ComboBox).DropDownStyle = ComboBoxStyle.DropDown
            CType(e.Control, ComboBox).AutoCompleteSource = AutoCompleteSource.ListItems
            CType(e.Control, ComboBox).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 1 Then
            Try
                Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.TextBox1.Text, MyIP)

            Catch ex As Exception
            End Try

            Me.lblPentaTarget.Text = 0
            'ElseIf TextBox1.Text.Length > 1 And TextBox1.Text.Length <= 5 And RadioButton5.Checked Then

            '    Dim CardNo = TextBox1.Text
            '    Me.AcceptButton = Nothing
            '    Try

            '        If Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSint.View_Rpt_Acc_AllEmployees, CardNo) > 0 Then
            '            TextBox1.Text = Nothing
            '            TextBox2.Focus()
            '        Else
            '            ClearEmployeeData()
            '        End If
            '    Catch ex As Exception

            '    End Try
        ElseIf TextBox1.Text.Length = 8 And RadioButton6.Checked Then
            Dim CardNo = TextBox1.Text.Substring(1, 5)
            Me.AcceptButton = Nothing
            Try

                If Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSint.View_Rpt_Acc_AllEmployees, CardNo) > 0 Then
                    TextBox1.Text = Nothing
                    TextBox2.Focus()
                Else
                    ClearEmployeeData()
                End If
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub ClearEmployeeData()
        Me.NameLabel1.Text = Nothing
        Me.DesigNameLabel1.Text = Nothing
        Me.DeptNameLabel1.Text = Nothing
        Me.Label16.Text = Nothing
        Me.Label13.Text = Nothing
        Me.CardNoLabel1.Text = Nothing
        PictureBox1.Image = Nothing


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        'If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
        '    e.Handled = True
        'End If


        'Try
        '    Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSint.View_Rpt_Acc_AllEmployees, Val(TextBox1.Text))
        'Catch ex As Exception

        'End Try
    End Sub
    Private Sub clear()
        TextBox2.Text = ""
        'ComboTreatment1.Text = ""
        'Label11.Text = ""
        Label1.Text = ""
        TextQty1.Text = 0
        price.Text = 0
        Label15.Text = ""
        'RadioButton1.Checked = True
        'RadioButton4.Checked = True
    End Sub
    Dim Limt, FairPrice As Int16

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CardNoLabel1.Text = "" And RadioButton4.Checked Then
            MsgBox("Please Enter Card No")

        Else
            If Val(TextQty1.Text) > 0 And ComboTreatment1.Text.Length > 0 Then
                Dim Qty As Double = Val(TextQty1.Text)

                If RadioButton1.Checked Then
                    TranType = "Sale"
                ElseIf RadioButton2.Checked Then
                    TranType = "Sale Retrun"
                    Qty = Qty * -1
                End If
                If RadioButton3.Checked Then
                    PaymentMode = "Cash"
                ElseIf RadioButton4.Checked Then
                    PaymentMode = "Credit"
                End If
                InvoiceNo = "FS-" + Me.CardNoLabel1.Text.ToString + "-" + Label2.Text.ToString
                LoardTerms()
                If Me.RadioButton4.Checked Then
                    Try
                        FairPrice = Me.Tbl_Acc_SalaryTableAdapter.FairPrice(Me.Label14.Text, Now.Month, Now.Year)
                    Catch ex As Exception
                        FairPrice = 0
                    End Try
                    If BasicSalary.Text <= 30000 Then
                        Limt = 6000
                    Else
                        Limt = 10000
                    End If
                    Limt = Limt - FairPrice
                    CreditLimtTxt.Text = Limt
                    Try
                        'Tbl_Shop_Tran_OutTableAdapter.Insert(Val(Label2.Text), Val(TextBox1.Text), Val(Label14.Text), ComboTreatment1.SelectedValue, Val(price.Text), Label11.Text, Qty, PaymentMode, Nothing, Nothing, Nothing, Me.NameLabel1.Text, Qty * Val(price.Text), TranType, InvoiceNo)
                        If Limt >= Val(TextQty1.Text) * Val(price.Text) Then
                            Tbl_Shop_Tran_OutTableAdapter.Insert(Val(Label2.Text), Val(CardNoLabel1.Text), Val(Label14.Text), ComboTreatment1.SelectedValue, Val(price.Text), Label11.Text, Qty, PaymentMode, Now, Nothing, Nothing, Me.NameLabel1.Text, Val(Label15.Text), TranType, InvoiceNo, False, Val(PurchasePriceLabel.Text), CType(Me.DateNameLabel1.Text, Date).Month, CType(Me.DateNameLabel1.Text, Date).Year, 0, MyIP)
                            Try
                                FairPrice = Me.Tbl_Acc_SalaryTableAdapter.FairPrice(Me.Label14.Text, Now.Month, Now.Year)
                            Catch ex As Exception
                                FairPrice = 0
                            End Try
                            If BasicSalary.Text <= 30000 Then
                                Limt = 6000
                            Else
                                Limt = 10000
                            End If
                            Limt = Limt - FairPrice
                            CreditLimtTxt.Text = Limt

                            Try
                                Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.CardNoLabel1.Text, MyIP)
                            Catch ex As Exception

                            End Try

                            Try
                                'Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSint.View_Rpt_Acc_AllEmployees, 0)
                            Catch ex As Exception
                            End Try
                            Me.Tbl_Shop_ItemTableAdapter.FillBy1(Me.DSint.tbl_Shop_Item)
                            Me.TextBox2.Text = 0
                            'TextBox1.Text = ""
                            Me.TextBox2.Focus()

                            'MsgBox("Data Saved Successfully")
                            Clearlabel()
                        ElseIf Qty < 0 Then
                            Tbl_Shop_Tran_OutTableAdapter.Insert(Val(Label2.Text), Val(CardNoLabel1.Text), Val(Label14.Text), ComboTreatment1.SelectedValue, Val(price.Text), Label11.Text, Qty, PaymentMode, Now, Nothing, Nothing, Me.NameLabel1.Text, Val(Label15.Text), TranType, InvoiceNo, False, Val(PurchasePriceLabel.Text), CType(Me.DateNameLabel1.Text, Date).Month, CType(Me.DateNameLabel1.Text, Date).Year, 0, MyIP)
                            Try
                                FairPrice = Me.Tbl_Acc_SalaryTableAdapter.FairPrice(Me.Label14.Text, Now.Month, Now.Year)
                            Catch ex As Exception
                                FairPrice = 0
                            End Try
                            If BasicSalary.Text <= 30000 Then
                                Limt = 6000
                            Else
                                Limt = 10000
                            End If
                            Limt = Limt - FairPrice
                            CreditLimtTxt.Text = Limt

                            Try
                                Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.CardNoLabel1.Text, MyIP)
                            Catch ex As Exception

                            End Try
                        Else

                            MsgBox("Purchase Limit Ended", MsgBoxStyle.Critical)
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                ElseIf RadioButton3.Checked Then
                    If Qty <> 0 Then
                        Try
                            'Tbl_Shop_Tran_OutTableAdapter.Insert(Val(Label2.Text), Val(TextBox1.Text), Val(Label14.Text), ComboTreatment1.SelectedValue, Val(price.Text), Label11.Text, Qty, PaymentMode, Nothing, Nothing, Nothing, Me.NameLabel1.Text, Qty * Val(price.Text), TranType, InvoiceNo)
                            Tbl_Shop_Tran_OutTableAdapter.Insert(Val(Label2.Text), 0, Nothing, ComboTreatment1.SelectedValue, Val(price.Text), Label11.Text, Qty, PaymentMode, Now, Nothing, Nothing, Me.NameLabel1.Text, Val(Label15.Text), TranType, InvoiceNo, False, Val(PurchasePriceLabel.Text), CType(Me.DateNameLabel1.Text, Date).Month, CType(Me.DateNameLabel1.Text, Date).Year, 0, MyIP)
                            Try
                                Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.TextBox1.Text, MyIP)
                            Catch ex As Exception

                            End Try

                            Try
                                'Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSint.View_Rpt_Acc_AllEmployees, 0)
                            Catch ex As Exception
                            End Try
                            Me.Tbl_Shop_ItemTableAdapter.FillBy1(Me.DSint.tbl_Shop_Item)
                            Me.TextBox2.Text = 0
                            'TextBox1.Text = ""
                            Me.TextBox2.Focus()

                            'MsgBox("Data Saved Successfully")
                            Clearlabel()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                    End If

                End If
            Else
                MsgBox("Enter Sale Qty or Select Item To Continue ")
            End If
            TextBox2.Focus()
            clear()
        End If


    End Sub
    Private Sub LoardTerms()
        Qty = Val(TextQty1.Text)
        If RadioButton1.Checked Then
            TranType = "Sale"
        ElseIf RadioButton2.Checked Then
            TranType = "Sale Retrun"
            Qty = Qty * -1
        End If
        Try
            If RadioButton3.Checked Then
                PaymentMode = "Cash"
                InvoiceNo = "FS-INT-" + "CASH" + "-" + Label2.Text.ToString + Me.Tbl_Shop_Inv_IDTableAdapter.MaxID.ToString
            ElseIf RadioButton4.Checked Then
                PaymentMode = "Credit"
                InvoiceNo = "FS-INT-" + Me.CardNoLabel1.Text.ToString + "-" + Label2.Text.ToString + Me.Tbl_Shop_Inv_IDTableAdapter.MaxID.ToString
            End If
        Catch ex As Exception
            InvoiceNo = "FS-INT-" + Me.CardNoLabel1.Text.ToString + "-" + Label2.Text.ToString + "444"
        End Try


    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If RadioButton5.Checked Then
            Try
                Me.View_Rpt_Acc_AllEmployeesTableAdapter.Fill(Me.DSint.View_Rpt_Acc_AllEmployees, Val(TextBox1.Text))
            Catch ex As Exception

            End Try
        End If


        'If TextBox1.Text = 0 Or Me.TextBox1.Text = Nothing Then
        '    Try
        '        Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, 0)
        '    Catch ex As Exception
        '    End Try
        'Else
        'Try
        '    If Me.View_Invoice_NoTableAdapter.Fill(Me.DSint.View_Invoice_No, Me.TextBox1.Text, Me.Label2.Text) > 0 And RadioButton2.Checked = False Then
        '        Me.Button1.Enabled = False
        '    Else
        '        Me.Button1.Enabled = True
        '    End If
        'Catch ex As System.Exception

        'End Try




        Try
            Try
                FairPrice = Me.Tbl_Acc_SalaryTableAdapter.FairPrice(Me.Label14.Text, Now.Month, Now.Year)
            Catch ex As Exception
                FairPrice = 0
            End Try
            If BasicSalary.Text <= 30000 Then
                Limt = 6000
            Else
                Limt = 10000
            End If
            Limt = Limt - FairPrice
            CreditLimtTxt.Text = Limt
        Catch ex As Exception

        End Try



        Try
            If RadioButton3.Checked Then
                Me.CardNoLabel1.Text = 0
            End If
            Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.CardNoLabel1.Text, MyIP)
        Catch ex As Exception
        End Try
        'End If
        LoardPayable()
    End Sub
    Private Sub LoardPayable()


        'Try
        '    'AdvanceTxt.Text = Me.Tbl_Acc_SalaryTableAdapter.Advance(Val(Label14.Text), Now.Month, Now.Year)
        '    'GrossSalaryTxt.Text = Me.Tbl_Acc_SalaryTableAdapter.GrossSalary(Val(Label14.Text))
        '    'AttDaysLabel.Text = Me.Tbl_Acc_SalaryTableAdapter.AttDays(Val(Label14.Text), Now.Month, Now.Year)
        '    'ParmentAdv.Text = Me.Tbl_Acc_SalaryTableAdapter.PAdvDeduct(Val(Label14.Text))
        '    'CreditLimtTxt.Text = Int((GrossSalaryTxt.Text / 26 * AttDaysLabel.Text) - AdvanceTxt.Text - ParmentAdv.Text)

        '    'AdvanceTxt.Text = Me.Tbl_Acc_SalaryTableAdapter.Advance(Now.Month, Now.Year, Val(Label14.Text))
        '    AdvanceTxt.Text = 0
        '    GrossSalaryTxt.Text = Me.Tbl_Acc_SalaryTableAdapter.GrossSalary(Val(Label14.Text))
        '    AttDaysLabel.Text = Me.Tbl_Acc_SalaryTableAdapter.AttDays(Val(Label14.Text), Now.Month, Now.Year)
        '    ParmentAdv.Text = Me.Tbl_Acc_SalaryTableAdapter.PAdvDeduct(Val(Label14.Text))
        '    Dim totalPurchase = 0
        '    Try
        '        AdvanceTxt.Text = Me.Tbl_Acc_SalaryTableAdapter.FairPrice(Me.Label14.Text, Now.Month, Now.Year)
        '    Catch ex As Exception
        '        AdvanceTxt.Text = 0
        '    End Try


        '    'If Val(TextBox1.Text) = 331 Or Val(TextBox1.Text) = 392 Or Val(TextBox1.Text) = 501 Or Val(TextBox1.Text) = 322 Then
        '    '    CreditLimtTxt.Text = Int(15000 - AdvanceTxt.Text - ParmentAdv.Text)
        '    'Else
        '    '    CreditLimtTxt.Text = Int((GrossSalaryTxt.Text / 26 * AttDaysLabel.Text) - AdvanceTxt.Text - ParmentAdv.Text)
        '    'End If
        '    If CType(Label16.Text, Date) <= Now.Date.AddMonths(-6) Then

        '        CreditLimtTxt.Text = Int(10000 - AdvanceTxt.Text - totalPurchase)
        '    Else
        '        CreditLimtTxt.Text = 0
        '        CreditLimtTxt.Text = Int((GrossSalaryTxt.Text / 26 * AttDaysLabel.Text) - AdvanceTxt.Text - ParmentAdv.Text)
        '    End If
        '    'CreditLimtTxt.Text = Int(10000 - AdvanceTxt.Text)
        'Catch ex As Exception
        '    CreditLimtTxt.Text = 0
        'End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EmpStatusCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EmpStatusCheckBox.CheckedChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        If TextBox2.TextLength >= 1 Then
            Me.Tbl_Shop_ItemTableAdapter.FillBy(Me.DSint.tbl_Shop_Item, Me.TextBox2.Text)
            Me.AcceptButton = Button1
        Else


            Me.Tbl_Shop_ItemTableAdapter.FillBy1(Me.DSint.tbl_Shop_Item)
        End If
        TextQty1.Text = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CardNoLabel1.Text = "" Then
            MsgBox("Enter Card No. to Continue")
            Me.TextBox1.Focus()
        Else
            LoardTerms()

            'If (Val(CreditLimtTxt.Text) >= Val(lblPentaTarget.Text) And PaymentMode = "Credit") Or PaymentMode = "Cash" Then



            For k As Int16 = 0 To Me.Tbl_Shop_Tran_OutDataGridView.RowCount - 1
                Me.Tbl_Shop_Tran_OutDataGridView(17, k).Value = True
            Next
            SaveData()

            Me.Tbl_Shop_Tran_InvoiceTableAdapter.Insert(Val(Label2.Text), Val(Label14.Text), InvoiceNo, 1, TranType, PaymentMode, lblPentaTarget.Text, Now.Date, Nothing)
            MaxInvoiceID = Me.Tbl_Shop_Tran_InvoiceTableAdapter.Maxvalue()
            Dim invoiceID As String = InvoiceNo + "-" + MaxInvoiceID
            If PaymentMode = "Credit" Then
                'Me.Tbl_Acc_ShortTermAdvancesTableAdapter.Insert(Val(Label14.Text), lblPentaTarget.Text, Now.Date, Nothing, Now, "Cash Deducted Against fair price shop Invoice # " & invoiceID & "")
            End If
            Me.View_Tran_OutTableAdapter.UpdateInvocie(invoiceID, InvoiceNo)
            Me.Tbl_Shop_Tran_InvoiceTableAdapter.UpdateInvoice(invoiceID, InvoiceNo)

            LoardPayable()
            If CheckBox1.Checked = True Then
                printReport(invoiceID)
            End If

            'Dim obj As New Class_Utility
            'Dim Filter As String = ""
            'Dim Path As String
            'Filter = "{View_HRMS_FairShop_OUT.CardNo} = " & TextBox1.Text & " And {View_HRMS_FairShop_OUT.DayNo} = " & Me.Label2.Text & " And {View_HRMS_FairShop_OUT.LockStatus}  And {View_HRMS_FairShop_OUT.InvoiceID} = " & MaxInvoiceID & ""
            'Path = "" & frmLogin.ReportsPath & "\HR\ShopFG\FairShopInvoice.rpt"
            ''Filter = "{View_HRMS_FairShop_OUT.CardNo} = " & TextBox1.Text & " And {View_HRMS_FairShop_OUT.DayNo} = " & Me.Label2.Text & " And {View_HRMS_FairShop_OUT.LockStatus}"
            'TextBox1.Text = Nothing
            'Me.TextBox1.Focus()
            'obj.LoadReports(Path, Filter, "")
            'Else
            '    MsgBox("Employee " & NameLabel1.Text & " Is not Eligible ,Credit limit has been Exceeded!")
            'End If
        End If
        RadioButton1.Checked = True
        RadioButton4.Checked = True
        ClearEmployeeData()
    End Sub
    Private Sub printReport(InvoiceID1 As String)
        Dim obj As New Class_Utility
        Dim Filter As String = ""
        Dim Path As String
        Path = "" & frmLogin.ReportsPath & "\HR\Shopint\FairShopInvoice.rpt"
        Filter = "{View_HRMS_FairShop_OUT.InvoiceNo} = '" & InvoiceID1 & "' And {View_HRMS_FairShop_OUT.DayNo} = " & Me.Label2.Text & " And {View_HRMS_FairShop_OUT.LockStatus}"
        'Filter = "{View_HRMS_FairShop_OUT.CardNo} = " & TextBox1.Text & " And {View_HRMS_FairShop_OUT.DayNo} = " & Me.Label2.Text & " And {View_HRMS_FairShop_OUT.LockStatus}"
        If RadioButton3.Checked Then
            TextBox1.Text = 0
            Me.TextBox2.Focus()
        Else
            TextBox1.Text = Nothing
            Me.TextBox1.Focus()
        End If

        obj.PrintReports(Path, Filter, "", 2)
    End Sub
    Private Sub SaveData()
        Try
            Me.Validate()
            Me.View_Tran_OutBindingSource.EndEdit()
            Me.View_Tran_OutTableAdapter.Update(Me.DSint.View_Tran_Out)
            Try
                Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.TextBox1.Text, MyIP)
            Catch ex As Exception

            End Try
            Clearlabel()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SaveData()
        MsgBox("Data Saved Successfully")
    End Sub

    Private Sub Tbl_Shop_Tran_OutDataGridView_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles Tbl_Shop_Tran_OutDataGridView.RowsAdded
        GridContentsTotal()
    End Sub

    Private Sub Tbl_Shop_Tran_OutDataGridView_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles Tbl_Shop_Tran_OutDataGridView.RowLeave
        GridContentsTotal()
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Try
            Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.TextBox1.Text, MyIP)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dgResult As DialogResult = MessageBox.Show("Are You Sure, You want to Cancel Sale Transactions", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If dgResult = 6 Then
            For k As Int16 = 0 To Me.Tbl_Shop_Tran_OutDataGridView.RowCount - 1
                If Me.Tbl_Shop_Tran_OutDataGridView(17, k).Value = True Then
                Else
                    Me.View_Tran_OutTableAdapter.DeleteQuery(Me.Tbl_Shop_Tran_OutDataGridView(0, k).Value)
                End If
            Next
            Try
                Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.TextBox1.Text, MyIP)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub TextQty1_TextChanged(sender As Object, e As EventArgs) Handles TextQty1.TextChanged
        Label15.Text = Val(TextQty1.Text) * Val(price.Text)
    End Sub


    Private Sub price_TextChanged(sender As Object, e As EventArgs) Handles price.TextChanged
        Label15.Text = Val(TextQty1.Text) * Val(price.Text)
    End Sub

    Private Sub price_GotFocus(sender As Object, e As EventArgs) Handles price.GotFocus
        Label15.Text = Val(TextQty1.Text) * Val(price.Text)
    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus
        Label15.Text = Val(TextQty1.Text) * Val(price.Text)
    End Sub

    Private Sub ComboTreatment1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTreatment1.SelectedIndexChanged
        TextQty1.Text = 1

        'Label15.Text = Val(TextQty1.Text) * Val(price.Text)



    End Sub

    Private Sub TextBox1_SystemColorsChanged(sender As Object, e As EventArgs) Handles TextBox1.SystemColorsChanged

    End Sub


    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged, RadioButton5.CheckedChanged
        If RadioButton6.Checked Then
            Me.TextBox1.UseSystemPasswordChar = True
            Me.TextBox1.Clear()
            Me.TextBox1.Focus()
        ElseIf RadioButton5.Checked Then
            TextBox1.UseSystemPasswordChar = False
            Me.TextBox1.Clear()
            Me.TextBox1.Focus()
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged, RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Me.TextBox1.Enabled = False
            RadioButton3.ForeColor = Color.DarkGreen
            RadioButton4.ForeColor = Color.Black
            Me.TextBox1.Text = 0
            Me.View_Tran_OutTableAdapter.FillBy(Me.DSint.View_Tran_Out, Me.Label2.Text, Me.TextBox1.Text, MyIP)
            Me.TextBox2.Focus()
            ClearEmployeeData()
            Me.CardNoLabel1.Text = 0
        ElseIf RadioButton4.Checked Then
            RadioButton3.ForeColor = Color.Black
            RadioButton4.ForeColor = Color.DarkGreen
            Me.TextBox1.Enabled = True
            Me.TextBox1.Text = ""
            Me.TextBox1.Focus()
        End If


    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton1.ForeColor = Color.DarkGreen
            RadioButton2.ForeColor = Color.Black
            Try
                If Me.View_Invoice_NoTableAdapter.Fill(Me.DSint.View_Invoice_No, Me.TextBox1.Text, Me.Label2.Text) > 0 Then
                    Me.Button1.Enabled = False
                Else
                    Me.Button1.Enabled = True
                End If
            Catch ex As Exception
                Me.Button1.Enabled = True
            End Try

        ElseIf RadioButton2.Checked Then
            Me.Button1.Enabled = True
            RadioButton1.ForeColor = Color.Black
            RadioButton2.ForeColor = Color.DarkGreen
        End If
    End Sub

End Class