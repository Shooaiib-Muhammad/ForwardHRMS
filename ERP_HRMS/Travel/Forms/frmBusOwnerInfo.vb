Imports System.IO

Public Class frmBusOwnerInfo

    Private Sub Tbl_Bus_OwnerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbl_Bus_OwnerBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.Tbl_Bus_OwnerBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DSBusInfo)
            MsgBox("Record Saved Successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmBusOwnerInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSBusInfo.tbl_Bus_Owner' table. You can move, or remove it, as needed.
        Me.Tbl_Bus_OwnerTableAdapter.Fill(Me.DSBusInfo.tbl_Bus_Owner)
        PicButtonText()
    End Sub

    Private Sub Tbl_Bus_OwnerDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tbl_Bus_OwnerDataGridView.CellContentClick

    End Sub

    Private Sub Tbl_Bus_OwnerDataGridView_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles Tbl_Bus_OwnerDataGridView.DataError

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Function FileSize(ByVal FilePath As String)
        Dim FileInfor As New FileInfo(FilePath)
        Dim FileLength As Long = FileInfor.Length / 1024
        Return FileLength
    End Function
    Sub PicButtonText()
        If Me.ArtSnapPictureBox.Image Is Nothing Then
            btnUploadPic.Text = "Upload Image"
            btnUploadPic.ForeColor = Color.DarkGreen
        Else
            btnUploadPic.Text = "Clear Image"
            btnUploadPic.ForeColor = Color.DarkRed
        End If
    End Sub
    Private Sub btnUploadPic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadPic.Click
        If btnUploadPic.Text = "Upload Image" Then
            Me.OpenFileDialog1.Filter = "JPG Images|*.jpg|BMP Images|*.bmp|All Files|*.*"
            Me.OpenFileDialog1.FilterIndex = 1
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If FileSize(OpenFileDialog1.FileName) <= 150 Then
                    ArtSnapPictureBox.Image = Image.FromFile(Me.OpenFileDialog1.FileName)
                    Me.btnUploadPic.Text = "Clear Image"
                    Me.btnUploadPic.ForeColor = Color.DarkRed
                Else
                    MsgBox("Image Size [" & FileSize(OpenFileDialog1.FileName) & " Kb] Is Greater Than 150 Kb", MsgBoxStyle.Information)
                End If
            End If
        Else
            Me.ArtSnapPictureBox.Image = Nothing
            Me.btnUploadPic.Text = "Upload Image"
            Me.btnUploadPic.ForeColor = Color.DarkGreen
        End If
    End Sub

    Private Sub Tbl_Bus_OwnerBindingSource_PositionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tbl_Bus_OwnerBindingSource.PositionChanged
        PicButtonText()
    End Sub

    Private Sub SearchModelName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchModelName.Click

    End Sub

    Private Sub SearchModelName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchModelName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Tbl_Bus_OwnerBindingSource.Filter = " OwnerName like '%" & SearchModelName.Text & "%'"
            Me.SearchModelName.Text = ""
            Me.CMModelName.Hide()
        End If
    End Sub

    Private Sub RFModelName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RFModelName.Click
        Me.Tbl_Bus_OwnerBindingSource.RemoveFilter()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.ArtSnapPictureBox.Image.Save(SaveFileDialog1.FileName)
        End If
    End Sub
End Class