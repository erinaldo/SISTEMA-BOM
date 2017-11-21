Public Class FormCetakNotaRetur

    Public Property Invoice As Object

    Private Sub FormCetakNotaRetur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportNotaRetur1.ReportParameters("div").Value = DivKoefisien
        ReportNotaRetur1.ReportParameters("invoice").Value = Invoice
        ReportViewer1.RefreshReport()
    End Sub
End Class
