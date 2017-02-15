Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class ReportDetailHutangCustomer
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Dim formatangka As String
        If DivKoefisien = DivCoef._1 Then
            formatangka = "{0:N2}"
        Else
            formatangka = "{0:N0}"
        End If
        TextBox14.Format = formatangka
        TextBox16.Format = formatangka
        TextBox25.Format = formatangka
        TextBox21.Format = formatangka
        TextBox23.Format = formatangka
        TextBox17.Format = formatangka
        TextBox35.Format = formatangka
        TextBox36.Format = formatangka
        TextBox37.Format = formatangka
    End Sub
End Class