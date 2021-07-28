Imports System.Data.Odbc
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Security.Cryptography
Public Class UtilityClass
    Public Function ReturnFP(ByVal MyMonth As Integer, ByVal MyYear As Integer) As String
        Dim FPeriod As String = ""
        Dim FP_Year As String

        Dim Con As New OdbcConnection("Dsn=HRMS")
        Dim Cmd As New OdbcCommand()
        Dim DataReaderForFP As OdbcDataReader

        Cmd.Connection = Con
        Cmd.CommandText = "Select FinancialPeriod from tbl_Acc_FinancialPeriod"
        Cmd.CommandType = CommandType.Text

        Con.Open()
        DataReaderForFP = Cmd.ExecuteReader()

        If DataReaderForFP.HasRows Then
            While (DataReaderForFP.Read)
                Select Case (MyMonth)
                    Case 1 To 6
                        FP_Year = DataReaderForFP.GetString(0).Substring(11, 4)
                        If FP_Year = MyYear Then
                            FPeriod = DataReaderForFP.GetString(0)
                        End If
                    Case Else
                        FP_Year = DataReaderForFP.GetString(0).Substring(3, 4)
                        If FP_Year = MyYear Then
                            FPeriod = DataReaderForFP.GetString(0)
                        End If
                End Select
            End While
        End If

        DataReaderForFP.Close()
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Cmd.Dispose()
        Con.Dispose()

        Return FPeriod

    End Function

    Public Sub LoadReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim frmHalfDaysViewObj As New FrmRptViewer
        If ChildWindowOpen("FrmRptViewer") = False Then
            Try
                frmHalfDaysViewObj.ViewReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            frmHalfDaysViewObj.MdiParent = frmMain
            frmHalfDaysViewObj.Show()
        End If
    End Sub
    Public Sub LoadDateWiseReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim frmAnalysisViewObj As New DateWiseRptViewer

        If ChildWindowOpen("DateWiseRptViewer") = False Then
            Try
                frmAnalysisViewObj.ViewReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            frmAnalysisViewObj.MdiParent = frmMain
            frmAnalysisViewObj.Show()
        End If
    End Sub
    Public Sub LoadSalaryReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim frmSalaryViewObj As New SalaryReportViewer

        If ChildWindowOpen("SalaryReportViewer") = False Then
            Try
                frmSalaryViewObj.ViewSalaryReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            frmSalaryViewObj.MdiParent = frmMain
            frmSalaryViewObj.Show()
        End If
    End Sub
    Public Sub LoadAdvReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim frmSAdvViewObj As New AdvncRptViewer

        If ChildWindowOpen("AdvncRptViewer") = False Then
            Try
                frmSAdvViewObj.ViewAdvanceReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            frmSAdvViewObj.MdiParent = frmMain
            frmSAdvViewObj.Show()
        End If
    End Sub
    Public Sub LoadAllowanceReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim frmSAdvViewObj As New AllREpViewer

        If ChildWindowOpen("AllREpViewer") = False Then
            Try
                frmSAdvViewObj.ViewReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            frmSAdvViewObj.MdiParent = frmMain
            frmSAdvViewObj.Show()
        End If
    End Sub
    Public Sub LoadDeptReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim DeptRptsViewObj As New FrmDeptWiseViewer

        If ChildWindowOpen("FrmDeptWiseViewer") = False Then
            Try
                DeptRptsViewObj.ViewDeptReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DeptRptsViewObj.MdiParent = frmMain
            DeptRptsViewObj.Show()
        End If
    End Sub
    Public Sub LoadCardReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim DeptRptsViewObj As New EmpCardViewer

        If ChildWindowOpen("EmpCardViewer") = False Then
            Try
                DeptRptsViewObj.ViewCardReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            DeptRptsViewObj.MdiParent = frmMain
            DeptRptsViewObj.Show()
        End If
    End Sub
    Public Sub LoadAnalysisReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim ViewAnalysisObj As New AnalysisRptViewer
        If ChildWindowOpen("AnalysisRptViewer") = False Then
            Try
                ViewAnalysisObj.ViewAnalysisReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ViewAnalysisObj.MdiParent = frmMain
            ViewAnalysisObj.Show()
        End If
    End Sub
    Public Sub LoadMISCReports(ByVal Path As String, ByVal Filter As String, ByVal Param As String)
        Dim ViewMISCObj As New MISCRptViewer
        If ChildWindowOpen("MISCRptViewer") = False Then
            Try
                ViewMISCObj.ViewMISCReport(Path, Filter, Param)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ViewMISCObj.MdiParent = frmMain
            ViewMISCObj.Show()
        End If
    End Sub


    Function ChildWindowOpen(ByVal childWindow As String)
        For Each f As Form In frmMain.MdiChildren
            If f.Name = childWindow Then
                f.WindowState = FormWindowState.Maximized
                Return True
            End If
        Next
        Return False
    End Function


    Public Function GetLastDayInMonth(ByVal dtDate As Date) As Date
        'This is very good piece of code that returns Last Day of a particular month
        Return DateAdd(DateInterval.Day, (DateAdd(DateInterval.Month, 1, dtDate)).Day * -1, DateAdd(DateInterval.Month, 1, dtDate))
    End Function

    Public Function ResetDate() As Date
        Dim NowDate As Date = Now.Date
        NowDate = NowDate.Subtract(New TimeSpan(NowDate.Day - 1, 0, 0, 0))
        Return NowDate
    End Function

    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider
    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function
    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = MD5Hash(100)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
        Try
            DES.Key = MD5Hash(100)
            DES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MessageBox.Show("Invalid Key", "Decryption Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Function
End Class
