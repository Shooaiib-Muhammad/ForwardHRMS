Imports System.IO
Public Class frmTraing
    Private Sub Tbl_EMS_Traing_HeadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_EMS_Traing_HeadBindingNavigatorSaveItem.Click
        Try


            Me.Validate()
            Me.Tbl_EMS_TraingBindingSource.EndEdit()

            Me.Tbl_EMS_TraingTableAdapter.Update(Me.DSEMS.tbl_EMS_Traing)
            MsgBox("Record has been Saved!")
            Dim postion As Integer = Tbl_EMS_TraingBindingSource.Position
            Loadreoard()
            Tbl_EMS_TraingBindingSource.Position = postion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmTraing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = Now.Year
        While i >= 1970
            cmbYear.Items.Add(i)
            i -= 1
        End While
        cmbYear.SelectedIndex = 0
        Me.Tbl_EMS_Traing_HeadTableAdapter.Fill(Me.DSEMS.tbl_EMS_Traing_Head)
        Loadreoard()
    End Sub
    Private Sub Loadreoard()
        Me.Tbl_EMS_TraingTableAdapter.Fill(Me.DSEMS.tbl_EMS_Traing, cmbYear.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If FileSize(OpenFileDialog1.FileName) <= 50 Then
                    AttSheetBox1.ImageLocation = OpenFileDialog1.FileName
                Else
                    MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function FileSize(ByVal FilePath As String)
        Dim FileInfor As New FileInfo(FilePath)
        Dim FileLength As Long = FileInfor.Length / 1024
        Return FileLength
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If FileSize(OpenFileDialog1.FileName) <= 50 Then
                    PictureBox1.ImageLocation = OpenFileDialog1.FileName
                Else
                    MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If FileSize(OpenFileDialog1.FileName) <= 50 Then
                    PictureBox2.ImageLocation = OpenFileDialog1.FileName
                Else
                    MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If FileSize(OpenFileDialog1.FileName) <= 50 Then
                    PictureBox3.ImageLocation = OpenFileDialog1.FileName
                Else
                    MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            OpenFileDialog1.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.wmf;*.png|All Files(*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If FileSize(OpenFileDialog1.FileName) <= 50 Then
                    PictureBox5.ImageLocation = OpenFileDialog1.FileName
                Else
                    MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " KB] Is Greater Than 50 KB", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PatialRecDateMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PatialRecDateMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub PatialRecDateMaskedTextBox_Enter(sender As Object, e As EventArgs) Handles PatialRecDateMaskedTextBox.Enter
        If PatialRecDateMaskedTextBox.Text = "  /  /" Then
            PatialRecDateMaskedTextBox.Text = Now.Date
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Filter As String = ""
        Dim Path As String = ""
        Dim Param As String = ""
        Dim Obj As New UtilityClass()
        Path = "\\server\ERPFGReports$\EMS\RptTrainingMange.rpt"

        Filter = "Year({tbl_EMS_Traing.TDateTime} )=" & cmbYear.Text & "and {tbl_EMS_Traing_Head.TrainType}='" & Me.ClientIDComboBox.Text & "' and {tbl_EMS_Traing.TID}=" & Me.TIDLabel1.Text & ""
        Obj.LoadReports(Path, Filter, Param)
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        Loadreoard()
    End Sub

    Private Sub ClientIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClientIDComboBox.SelectedIndexChanged
        Loadreoard()
    End Sub
End Class