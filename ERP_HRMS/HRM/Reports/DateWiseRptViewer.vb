Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class DateWiseRptViewer


    Friend Function ViewReport(ByVal sReportName As String, Optional ByVal sSelectionFormula As String = "", Optional ByVal param As String = "") As Boolean
        Dim objReport As New ReportDocument
        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer
        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim currValue As CrystalDecisions.Shared.ParameterValues
        Dim intCounter As Integer
        Try
            objReport.Load(sReportName)
            intCounter = objReport.DataDefinition.ParameterFields.Count
            If intCounter = 1 Then
                If InStr(objReport.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
                    intCounter = 0
                End If
            End If
            If intCounter > 0 And Trim(param) <> "" Then
                strParValPair = param.Split("&")
                For index = 0 To UBound(strParValPair)
                    If InStr(strParValPair(index), "=") > 0 Then
                        strVal = strParValPair(index).Split("=")
                        For j As Integer = 0 To UBound(strVal)
                            If j = 1 Then
                                If strVal(j).Contains("/") Then
                                    Dim Dt As Date = CType(strVal(j), Date)
                                    paraValue.Value = Dt
                                Else
                                    paraValue.Value = strVal(j)
                                End If
                            End If
                        Next
                    End If
                    currValue = objReport.DataDefinition.ParameterFields.Item(index).CurrentValues
                    currValue.Clear()
                    currValue.Add(paraValue)
                    objReport.DataDefinition.ParameterFields.Item(index).ApplyCurrentValues(currValue)
                Next
            End If
            If sSelectionFormula.Length > 0 Then
                objReport.RecordSelectionFormula = sSelectionFormula
            End If
            CrystalReportViewer3.ReportSource = Nothing
            CrystalReportViewer3.ReportSource = objReport
            If param = "" Then
                CrystalReportViewer3.RefreshReport()
            End If
            CrystalReportViewer3.Show()
            Return True
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Private Sub AnanysisRptViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CrystalReportViewer3.RefreshReport()
    End Sub

    Private Sub CrystalReportViewer3_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer3.Load

    End Sub
End Class