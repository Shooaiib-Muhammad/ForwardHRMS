﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpCardViewer
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
        Me.CrystalReportViewer4 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CrystalReportViewer4
        '
        Me.CrystalReportViewer4.ActiveViewIndex = -1
        Me.CrystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer4.DisplayGroupTree = False
        Me.CrystalReportViewer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer4.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer4.Name = "CrystalReportViewer4"
        Me.CrystalReportViewer4.SelectionFormula = ""
        Me.CrystalReportViewer4.Size = New System.Drawing.Size(824, 694)
        Me.CrystalReportViewer4.TabIndex = 0
        Me.CrystalReportViewer4.ViewTimeSelectionFormula = ""
        '
        'EmpCardViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 694)
        Me.Controls.Add(Me.CrystalReportViewer4)
        Me.Name = "EmpCardViewer"
        Me.Text = "EmpCardViewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer4 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
