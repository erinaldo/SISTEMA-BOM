Public Class FormCetakNotaReturPDF

    Property Invoice As Object

    Property Sales As Object

    Property IDCustomer As Object

    Property Status As String

    Private Sub FormCetaNotaReturPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportNotaReturToPDF1.ReportParameters("div").Value = DivKoefisien
        ReportNotaReturToPDF1.ReportParameters("invoice").Value = Invoice
        ReportNotaReturToPDF1.ReportParameters("sales").Value = Sales
        ReportNotaReturToPDF1.ReportParameters("customer_id").Value = IDCustomer
        ReportNotaReturToPDF1.ReportParameters("status").Value = status
        ReportViewer1.RefreshReport()
    End Sub
End Class
