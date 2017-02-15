Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class ReportNotaMasuk

    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Dim formatangka As String
        If DivKoefisien = DivCoef._1 Then
            formatangka = "{0:N2}"
        Else
            formatangka = "{0:N0}"
        End If
        TextBox21.Format = formatangka
        TextBox22.Format = formatangka
        TextBox19.Format = formatangka
        TextBox20.Format = formatangka
        TextBox37.Format = formatangka
    End Sub

    Private Sub TextBox21_Disposed(sender As Object, e As EventArgs) Handles TextBox21.Disposed

    End Sub
End Class