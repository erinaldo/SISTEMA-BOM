Public Class FormCetakNotaOrderSimple
    Public Property invoice As String

    Property AutoPrint As Boolean = True

    Private Sub FormCetakNotaOrderSimple_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ReportNotaOrderSimple1.ReportParameters("div").Value = DivKoefisien
        ReportNotaOrderSimple1.ReportParameters("invoice").Value = invoice
        ReportViewer1.RefreshReport()

        If AutoPrint = True Then
            Dim reportproses As New Telerik.Reporting.Processing.ReportProcessor
            reportproses.PrintReport(Me.ReportViewer1.ReportSource, Nothing)
        End If
    End Sub

    Private Sub FormCetakNotaOrderSimple_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
