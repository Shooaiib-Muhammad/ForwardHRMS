Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReportViewer

    Friend Function ViewReport(ByVal Flag As Integer, ByVal MyMonth As Integer, ByVal MyYear As Integer, ByVal sReportName As String, ByVal PDFPath As String, ByVal CardNo As Integer, Optional ByVal sSelectionFormula As String = "", Optional ByVal param As String = "") As Boolean
        Dim bool As Boolean
        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer
        Dim intCounter As Integer

        Dim crReportDocument As New ReportDocument
        Dim crParameterFieldDefinitions As ParameterFieldDefinitions = Nothing
        Dim crParameterFieldDefinition As ParameterFieldDefinition = Nothing
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()

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
                                    crParameterDiscreteValue.Value = CType(strVal(j), Date)
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

            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = crReportDocument
            CrystalReportViewer1.Refresh()

            If Flag = 0 Then
                CrDiskFileDestinationOptions.DiskFileName = PDFPath & "Salary_Slip_Card_No=" & CardNo & "_Month=" & MyMonth & "_Year=" & MyYear & ".pdf"
            ElseIf Flag = 3 Then
                CrDiskFileDestinationOptions.DiskFileName = PDFPath & "Bonus_Slip_Card_No=" & CardNo & ".pdf"
            ElseIf Flag = 1 Then
                CrDiskFileDestinationOptions.DiskFileName = PDFPath & "Salary_Slip_MissingEmails_Month=" & MyMonth & "_Year=" & MyYear & ".pdf"
            End If
            CrExportOptions = crReportDocument.ExportOptions
            With CrExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptions
                .FormatOptions = CrFormatTypeOptions
            End With
            crReportDocument.Export()
            bool = True
        Catch ex As System.Exception
            MsgBox(ex.Message)
            bool = False
        End Try
        Return bool

    End Function

    Private Sub frmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class