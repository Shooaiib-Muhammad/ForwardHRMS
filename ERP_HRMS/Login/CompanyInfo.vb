Public Class CompanyInfo
    Private Sub Tbl_Comp_InfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CompanyInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSUser.tbl_Comp_Info' table. You can move, or remove it, as needed.
        Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
        Tbl_Comp_InfoBindingNavigatorSaveItem.Enabled = False
        If Me.Tbl_Comp_InfoBindingSource.Count > 0 Then
            BindingNavigatorAddNewItem.Enabled = False
        End If
    End Sub



    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim TheSize As Long = Long.Parse(My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Length)

        LogoPictureBox.ImageLocation = OpenFileDialog1.FileName

    End Sub

    Private Sub Tbl_Comp_InfoBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Tbl_Comp_InfoBindingNavigatorSaveItem.Click
        Try
            Me.ValidateChildren()

            Me.Tbl_Comp_InfoBindingSource.EndEdit()
            Me.Tbl_Comp_InfoTableAdapter.Update(Me.DSUser.tbl_Comp_Info)
            Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)

            MessageBox.Show("Company Information has been Added ", "Insertion Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CancelToolStripButton.Visible = False
            SignTextBox.Enabled = False
            EditToolStripButton.Enabled = True
            Tbl_Comp_InfoBindingNavigatorSaveItem.Enabled = False
            'BindingNavigatorAddNewItem.Enabled = True
            CompanyNameTextBox.ReadOnly = False
            CompanyStartYearTextBox.Enabled = False
            EmailAddressTextBox.Enabled = False
            PhoneNoMaskedTextBox.Enabled = False
            SalayTypeComboBox.Enabled = False
            OverTimeTypeComboBox.Enabled = False
            AddressTextBox.Enabled = False
            GroupBox1.Enabled = False
            Button1.Enabled = False
            PEESIFIXTextBox.Enabled = False
            EOBIFixTextBox.Enabled = False
            BuffetMealDedTextBox.Enabled = False
            LabourMealDedTextBox.Enabled = False
            btnOpenFile.Enabled = False
            tbFilePath.ReadOnly = True
            GroupBox1.Enabled = False
            PerDayTravel.ReadOnly = True
            Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
            Try
                frmLogin.ReportsPath = Me.DSUser.tbl_Comp_Info.Rows(0).Item("ReportsPath")
            Catch ex As Exception
                MsgBox("Report Path Missing,Kindly update it to view reports.")
            End Try
        Catch ex As Exception
            Me.Tbl_Comp_InfoTableAdapter.Fill(Me.DSUser.tbl_Comp_Info)
            CancelToolStripButton.Visible = False
            SignTextBox.Enabled = False
            EditToolStripButton.Enabled = True
            Tbl_Comp_InfoBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorAddNewItem.Enabled = True
            CompanyNameTextBox.ReadOnly = False
            CompanyStartYearTextBox.Enabled = False
            EmailAddressTextBox.Enabled = False
            PhoneNoMaskedTextBox.Enabled = False
            SalayTypeComboBox.Enabled = False
            OverTimeTypeComboBox.Enabled = False
            AddressTextBox.Enabled = False
            GroupBox1.Enabled = False
            Button1.Enabled = False
            PEESIFIXTextBox.Enabled = False
            EOBIFixTextBox.Enabled = False
            BuffetMealDedTextBox.Enabled = False
            LabourMealDedTextBox.Enabled = False
            btnOpenFile.Enabled = False
            tbFilePath.ReadOnly = True
            PerDayTravel.ReadOnly = True
        End Try

        If AnnualLeavesCheckBox.Checked = True Then
            frmMain.ToolStripMenuItem34.Visible = True
        Else
            frmMain.ToolStripMenuItem34.Visible = False

        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim TheSize As Long = Long.Parse(My.Computer.FileSystem.GetFileInfo(OpenFileDialog1.FileName).Length)
            'If TheSize < 20000 Then
            '    MessageBox.Show("Selected Pic Size is Large Plese Select pic with in the Size of 20 Kb ", "Picture Size Exceed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End If
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_Comp_InfoBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        CompanyNameTextBox.ReadOnly = False
        SignTextBox.ReadOnly = False
        CompanyStartYearTextBox.ReadOnly = False
        EmailAddressTextBox.ReadOnly = False
        PhoneNoMaskedTextBox.ReadOnly = False
        SalayTypeComboBox.Enabled = True
        OverTimeTypeComboBox.Enabled = True
        AddressTextBox.ReadOnly = False
        GroupBox1.Enabled = True
        Button1.Enabled = True
        PEESIFIXTextBox.ReadOnly = False
        EOBIFixTextBox.ReadOnly = False
        BuffetMealDedTextBox.ReadOnly = False
        LabourMealDedTextBox.ReadOnly = False
        btnOpenFile.Enabled = True
        tbFilePath.ReadOnly = False
        GroupBox1.Enabled = True
        PerDayTravel.ReadOnly = False
    End Sub

    Private Sub CancelToolStripButton_Click(sender As Object, e As EventArgs) Handles CancelToolStripButton.Click
        Dim postion As Integer = Tbl_Comp_InfoBindingSource.Position
        Tbl_Comp_InfoTableAdapter.Fill(DSUser.tbl_Comp_Info)
        Tbl_Comp_InfoBindingSource.Position = postion
        'BindingNavigatorAddNewItem.Enabled = True
        EditToolStripButton.Enabled = True
        CancelToolStripButton.Visible = False
        Tbl_Comp_InfoBindingNavigatorSaveItem.Enabled = False
        CompanyNameTextBox.ReadOnly = True
        CompanyStartYearTextBox.ReadOnly = True
        EmailAddressTextBox.ReadOnly = True
        PhoneNoMaskedTextBox.ReadOnly = True
        SalayTypeComboBox.Enabled = False
        OverTimeTypeComboBox.Enabled = False
        AddressTextBox.ReadOnly = True
        GroupBox1.Enabled = False
        Button1.Enabled = False
        SignTextBox.ReadOnly = True
        PEESIFIXTextBox.ReadOnly = True
        EOBIFixTextBox.ReadOnly = True
        BuffetMealDedTextBox.ReadOnly = True
        LabourMealDedTextBox.ReadOnly = True
        btnOpenFile.Enabled = False
        tbFilePath.ReadOnly = True
        GroupBox1.Enabled = False

        If AnnualLeavesCheckBox.Checked = True Then
            frmMain.ToolStripMenuItem34.Visible = True
        Else
            frmMain.ToolStripMenuItem34.Visible = False

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub EditToolStripButton_Click(sender As Object, e As EventArgs) Handles EditToolStripButton.Click
        CancelToolStripButton.Visible = True
        EditToolStripButton.Enabled = False
        Tbl_Comp_InfoBindingNavigatorSaveItem.Enabled = True
        'BindingNavigatorAddNewItem.Enabled = False
        CompanyNameTextBox.ReadOnly = False
        SignTextBox.ReadOnly = False
        CompanyStartYearTextBox.ReadOnly = False
        EmailAddressTextBox.ReadOnly = False
        PhoneNoMaskedTextBox.ReadOnly = False
        SalayTypeComboBox.Enabled = True
        OverTimeTypeComboBox.Enabled = True
        AddressTextBox.ReadOnly = False
        GroupBox1.Enabled = True
        Button1.Enabled = True
        PEESIFIXTextBox.ReadOnly = False
        EOBIFixTextBox.ReadOnly = False
        BuffetMealDedTextBox.ReadOnly = False
        LabourMealDedTextBox.ReadOnly = False
        btnOpenFile.Enabled = True
        tbFilePath.ReadOnly = False
        btnOpenFile.Enabled = True
        tbFilePath.ReadOnly = False
        GroupBox1.Enabled = True
        PerDayTravel.ReadOnly = False
    End Sub

    Private Sub CompanyNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompanyNameTextBox.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CompanyStartYearTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CompanyStartYearTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub PEESIFIXTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PEESIFIXTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub

    Private Sub EOBIFixTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EOBIFixTextBox.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True

        End If
    End Sub



    Private Sub SignTextBox_TextChanged(sender As Object, e As EventArgs) Handles SignTextBox.TextChanged

    End Sub

    Private Sub SignTextBox_GotFocus(sender As Object, e As EventArgs) Handles SignTextBox.GotFocus
        If Me.SignTextBox.Text.Length = 2 Then
            MessageBox.Show("Only One Character is Accepted Please Enter Only One character", "SIngle Character Accpted", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        End If
    End Sub

    Private Sub PhoneNoMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PhoneNoMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click

        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop
        FolderBrowserDialog1.SelectedPath = "C:\"
        FolderBrowserDialog1.Description = "Select Application Reports Files Path"
        FolderBrowserDialog1.ShowDialog()

    End Sub



    Private Sub FolderBrowserDialog1_Disposed(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        tbFilePath.Text = FolderBrowserDialog1.SelectedPath.ToString
    End Sub
End Class