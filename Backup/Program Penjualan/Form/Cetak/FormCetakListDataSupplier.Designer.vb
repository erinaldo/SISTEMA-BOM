﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakListDataSupplier
    Inherits Telerik.WinControls.UI.RadForm

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
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Me.ReportListDataSupplier1 = New Program_Penjualan_V2.ReportListDataSupplier()
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        CType(Me.ReportListDataSupplier1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportListDataSupplier1
        '
        Me.ReportListDataSupplier1.Name = "ReportListDataSupplier"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        InstanceReportSource1.ReportDocument = Me.ReportListDataSupplier1
        Me.ReportViewer1.ReportSource = InstanceReportSource1
        Me.ReportViewer1.Size = New System.Drawing.Size(820, 489)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
        '
        'FormCetakListDataSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 489)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormCetakListDataSupplier"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak List Data Supplier"
        CType(Me.ReportListDataSupplier1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents ReportListDataSupplier1 As Program_Penjualan_V2.ReportListDataSupplier
End Class

