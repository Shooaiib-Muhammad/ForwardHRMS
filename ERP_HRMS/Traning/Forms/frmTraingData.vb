Imports System.IO
Public Class frmTraingData

    'Private Sub Clock1_TimeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock1.TimeChanged
    '    Me.Clock1.UtcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)
    'End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Tbl_Traing_CategoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Traing_CategoryBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Traing_CategoryBindingSource.EndEdit()
            Me.Tbl_Traing_CategoryTableAdapter.Update(Me.DSTraingData.tbl_Traing_Category)
            MsgBox("Records Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmTraingData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSTraingData.tbl_Traing_Category_Title_Sub' table. You can move, or remove it, as needed.
        Me.Tbl_Traing_Category_Title_SubTableAdapter.Fill(Me.DSTraingData.tbl_Traing_Category_Title_Sub)
        'TODO: This line of code loads data into the 'DSTraingData.tbl_Traing_Category_Title' table. You can move, or remove it, as needed.
        Me.Tbl_Traing_Category_TitleTableAdapter.Fill(Me.DSTraingData.tbl_Traing_Category_Title)
        'TODO: This line of code loads data into the 'DSTraingData.tbl_Traing_Category' table. You can move, or remove it, as needed.
        Me.Tbl_Traing_CategoryTableAdapter.Fill(Me.DSTraingData.tbl_Traing_Category)

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim dgResults As DialogResult

        If btnBrowse.Text = "Clear Image" Then
            dgResults = MessageBox.Show("Are you sure! You want to clear image?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dgResults = Windows.Forms.DialogResult.Yes Then
                Try
                    Me.Tbl_Traing_Category_TitleTableAdapter.ClearVisual(Val(TitleIDLabel1.Text))
                    MsgBox("Image Cleared")
                    Me.Tbl_Traing_Category_TitleTableAdapter.Fill(Me.DSTraingData.tbl_Traing_Category_Title)
                    'Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.FillBy(Me.DataSet6.tbl_Hrm_kaizen_activity_record, Val(KARIDLabel1.Text))
                    btnBrowse.Text = "Upload Image"

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf btnBrowse.Text = "Upload Image" Then
            Try
                OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
                OpenFileDialog1.FilterIndex = 1
                If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    '    EmpPicPictureBox.ImageLocation = OpenFileDialog1.FileName
                    '    btnBrowse.Text = "Save Now"
                    If FileSize(OpenFileDialog1.FileName) <= 50 Then
                        PictureBox3.ImageLocation = OpenFileDialog1.FileName
                        btnBrowse.Text = "Save Now"
                    Else
                        MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Try
                Me.Validate()
                Me.Tbl_Traing_Category_TitleBindingSource.EndEdit()
                Me.Tbl_Traing_Category_TitleTableAdapter.Update(Me.DSTraingData.tbl_Traing_Category_Title)
                MsgBox("Image Saved")
                btnBrowse.Text = "Clear Image"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Function FileSize(ByVal FilePath As String)
        Dim FileInfor As New FileInfo(FilePath)
        Dim FileLength As Long = FileInfor.Length / 1024
        Return FileLength
    End Function

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try
            Me.Validate()
            Me.Tbl_Traing_Category_TitleBindingSource.EndEdit()
            Me.Tbl_Traing_Category_TitleTableAdapter.Update(Me.DSTraingData.tbl_Traing_Category_Title)
            MsgBox("Records Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        Try
            Me.Validate()
            Me.Tbl_Traing_Category_Title_SubBindingSource.EndEdit()
            Me.Tbl_Traing_Category_Title_SubTableAdapter.Update(Me.DSTraingData.tbl_Traing_Category_Title_Sub)
            MsgBox("Records Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnBrowse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse1.Click
        Dim dgResults As DialogResult

        If btnBrowse1.Text = "Clear Image" Then
            dgResults = MessageBox.Show("Are you sure! You want to clear image?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If dgResults = Windows.Forms.DialogResult.Yes Then
                Try
                    Me.Tbl_Traing_Category_Title_SubTableAdapter.ClearVisual(Val(SubIDLabel1.Text))
                    MsgBox("Image Cleared")
                    Me.Tbl_Traing_Category_Title_SubTableAdapter.Fill(Me.DSTraingData.tbl_Traing_Category_Title_Sub)
                    'Me.Tbl_Hrm_kaizen_activity_recordTableAdapter.FillBy(Me.DataSet6.tbl_Hrm_kaizen_activity_record, Val(KARIDLabel1.Text))
                    btnBrowse1.Text = "Upload Image"

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        ElseIf btnBrowse1.Text = "Upload Image" Then
            Try
                OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
                OpenFileDialog1.FilterIndex = 1
                If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    '    EmpPicPictureBox.ImageLocation = OpenFileDialog1.FileName
                    '    btnBrowse1.Text = "Save Now"
                    If FileSize(OpenFileDialog1.FileName) <= 50 Then
                        PictureBox1.ImageLocation = OpenFileDialog1.FileName
                        btnBrowse1.Text = "Save Now"
                    Else
                        MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                    End If
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            Try
                Me.Validate()
                Me.Tbl_Traing_Category_Title_SubBindingSource.EndEdit()
                Me.Tbl_Traing_Category_Title_SubTableAdapter.Update(Me.DSTraingData.tbl_Traing_Category_Title_Sub)
                MsgBox("Image Saved")
                btnBrowse1.Text = "Clear Image"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ResetImageButton()
        Try
            If Me.DSTraingData.tbl_Traing_Category_Title(Me.Tbl_Traing_Category_TitleBindingSource.Position + 1).Item(4) Is DBNull.Value Then
                btnBrowse.Text = "Upload Image"
            Else
                btnBrowse.Text = "Clear Image"
            End If
        Catch ex As Exception
            btnBrowse.Text = "Upload Image"
        End Try
        Try

            If Me.DSTraingData.tbl_Traing_Category_Title_Sub(Me.Tbl_Traing_Category_Title_SubBindingSource.Position + 1).Item(5) Is DBNull.Value Then
                btnBrowse1.Text = "Upload Image"

            Else
                btnBrowse1.Text = "Clear Image"
            End If
        Catch ex As Exception
            btnBrowse1.Text = "Upload Image"
        End Try
    End Sub

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub Tbl_Traing_Category_Title_SubBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Traing_Category_Title_SubBindingSource.PositionChanged
        ResetImageButton()
    End Sub

    Private Sub Tbl_Traing_Category_TitleBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Traing_Category_TitleBindingSource.PositionChanged
        ResetImageButton()
    End Sub

    Private Sub Tbl_Traing_CategoryBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Traing_CategoryBindingSource.PositionChanged
        ResetImageButton()
    End Sub
End Class