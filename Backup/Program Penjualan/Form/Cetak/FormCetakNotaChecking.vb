Public Class FormCetakNotaChecking
    Property Invoice As String

    Private Sub FormCetakNotaChecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportNotaChecking1.ReportParameters("div").Value = DivKoefisien
        Me.ReportNotaChecking1.ReportParameters("invoice").Value = Invoice
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
