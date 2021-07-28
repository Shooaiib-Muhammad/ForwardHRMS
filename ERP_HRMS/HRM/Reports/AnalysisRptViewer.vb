Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine


Public Class AnalysisRptViewer

    Friend Function ViewAnalysisReport(ByVal sReportName As String, Optional ByVal sSelectionFormula As String = "", Optional ByVal param As String = "") As Boolean
        Dim crReportDocument As New ReportDocument
        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer
        Dim intCounter As Integer

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions = Nothing
        Dim crParameterFieldDefinition As ParameterFieldDefinition = Nothing
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        Try
            crReportDocument.Load(sReportName)
            crReportDocument.Refresh()

            crParameterFieldDefinitions = crReportDocument.DataDefinition.ParameterFields
            intCounter = crReportDocument.DataDefinition.ParameterFields.Count

            If intCounter = 1 Then
                If InStr(crReportDocument.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
                    intCounter = 0
                End If
            End If

            If intCounter > 0 And Trim(param) <> "" Then
                strParValPair = param.Split("&")
                For index = 0 To UBound(strParValPair)
                    If InStr(strParValPair(index), "=") > 0 Then
                        strVal = strParValPair(index).Split("=")
                        For j As Integer = 0 To UBound(strVal)
                            If j = 0 Then
                                crParameterFieldDefinition = crParameterFieldDefinitions.Item(strVal(j).Trim)
                                crParameterValues = crParameterFieldDefinition.CurrentValues
                            ElseIf j = 1 Then
                                If strVal(j).Contains("/") Then
                                    If strVal(j).Split("/").Length = 3 Then
                                        crParameterDiscreteValue.Value = CType(strVal(j), Date)
                                    Else
                                        crParameterDiscreteValue.Value = strVal(j)
                                    End If
                                ElseIf IsNumeric(strVal(j)) Then
                                    crParameterDiscreteValue.Value = CType(strVal(j), Double)
                                Else
                                    crParameterDiscreteValue.Value = strVal(j)
                                End If
                            End If
                        Next
                    End If
                    crParameterValues.Clear()
                    crParameterValues.Add(crParameterDiscreteValue)
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
                Next
            End If

            If sSelectionFormula.Length > 0 Then
                crReportDocument.RecordSelectionFormula = sSelectionFormula
            End If
            CrystalReportViewer5.ReportSource = crReportDocument
            CrystalReportViewer5.Show()
            Return True
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function




    Private Sub AnalysisRptViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer5.RefreshReport()
    End Sub

    Private Sub CrystalReportViewer5_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer5.Load

    End Sub
End Class