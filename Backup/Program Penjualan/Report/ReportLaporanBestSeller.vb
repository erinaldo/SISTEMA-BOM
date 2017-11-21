Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class ReportLaporanBestSeller
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Dim formatangka As String
        If DivKoefisien = DivCoef._1 Then
            formatangka = "{0:N2}"
        Else
            formatangka = "{0:N0}"
        End If
        TextBox20.Format = formatangka
        TextBox9.Format = formatangka
        TextBox23.Format = formatangka
        TextBox17.Format = formatangka
    End Sub

End Class