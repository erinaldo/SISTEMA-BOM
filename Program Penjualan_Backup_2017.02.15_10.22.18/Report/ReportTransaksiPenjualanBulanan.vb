Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class ReportTransaksiPenjualanBulanan
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Dim formatangka As String
        If DivKoefisien = DivCoef._1 Then
            formatangka = "{0:N2}"
        Else
            formatangka = "{0:N0}"
        End If
        TextBox16.Format = formatangka
        TextBox13.Format = formatangka
        TextBox14.Format = formatangka
        TextBox19.Format = formatangka
        TextBox20.Format = formatangka
        TextBox21.Format = formatangka
    End Sub

End Class