<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalysisRptViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer5 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewer5
        '
        Me.CrystalReportViewer5.ActiveViewIndex = -1
        Me.CrystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer5.DisplayGroupTree = False
        Me.CrystalReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer5.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer5.Name = "CrystalReportViewer5"
        Me.CrystalReportViewer5.SelectionFormula = ""
        Me.CrystalReportViewer5.Size = New System.Drawing.Size(1110, 756)
        Me.CrystalReportViewer5.TabIndex = 0
        Me.CrystalReportViewer5.ViewTimeSelectionFormula = ""
        '
        'AnalysisRptViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 756)
        Me.Controls.Add(Me.CrystalReportViewer5)
        Me.Name = "AnalysisRptViewer"
        Me.Text = "AnalysisRptViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer5 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
