Public Class Class_Utility
    Function ChildWindowOpen(ByVal childWindow As String)
        'Opens child forms in parent form
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.WindowState = FormWindowState.Maximized
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub LoadReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        'This function is used to open reports
        Dim Obj_frmRptPO As New frmRptViewer
        If ChildWindowOpen("frmRptViewer") = False Then
            Try
                Obj_frmRptPO.ViewReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Obj_frmRptPO.MdiParent = frmMain
            Obj_frmRptPO.Show()
        End If
    End Sub

    Public Sub PrintReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String, ByVal Optional noOfCopies As Int16 = 1)
        'This function is used to open reports
        Dim Obj_frmRptPO As New FrmRptViewer

        Try
            Obj_frmRptPO.PrintReport(Path, Filter, Param, noOfCopies)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class

