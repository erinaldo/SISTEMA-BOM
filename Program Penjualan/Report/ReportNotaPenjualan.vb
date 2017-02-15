Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class ReportNotaPenjualan
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
        TextBox18.Format = formatangka
        TextBox34.Format = formatangka
        TextBox36.Format = formatangka
        TextBox37.Format = formatangka
        TextBox39.Format = formatangka
        TextBox38.Format = formatangka
        TextBox41.Format = formatangka
    End Sub
    
End Class