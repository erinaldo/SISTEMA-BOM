Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class ReportLaporanProfit
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Dim formatangka As String
        If DivKoefisien = DivCoef._1 Then
            formatangka = "{0:N2}"
        Else
            formatangka = "{0:N0}"
        End If
        TextBox32.Format = formatangka
        TextBox34.Format = formatangka
        TextBox27.Format = formatangka
        TextBox28.Format = formatangka
        TextBox30.Format = formatangka
        TextBox41.Format = formatangka
        TextBox42.Format = formatangka
        TextBox43.Format = formatangka
        TextBox44.Format = formatangka
        TextBox45.Format = formatangka
    End Sub
End Class