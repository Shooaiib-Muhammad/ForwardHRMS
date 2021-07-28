<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MISCRptViewer
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
        Me.CrystalReportViewer6 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewer6
        '
        Me.CrystalReportViewer6.ActiveViewIndex = -1
        Me.CrystalReportViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer6.DisplayGroupTree = False
        Me.CrystalReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer6.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer6.Name = "CrystalReportViewer6"
        Me.CrystalReportViewer6.SelectionFormula = ""
        Me.CrystalReportViewer6.Size = New System.Drawing.Size(1284, 739)
        Me.CrystalReportViewer6.TabIndex = 0
        Me.CrystalReportViewer6.ViewTimeSelectionFormula = ""
        '
        'MISCRptViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 739)
        Me.Controls.Add(Me.CrystalReportViewer6)
        Me.Name = "MISCRptViewer"
        Me.Text = "MISCRptViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer6 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
