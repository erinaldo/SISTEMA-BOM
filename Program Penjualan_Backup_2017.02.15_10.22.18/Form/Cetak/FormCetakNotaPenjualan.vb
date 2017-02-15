Public Class FormCetakNotaPenjualan
    Public Property invoice As String
    Public Property banyak As Integer

    Public Property Kota As String

    Public Property ExtraOrdinary As Boolean

    Private Sub FormCetakNotaPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakNotaPenjualan_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ReportNotaPenjualan1.ReportParameters("div").Value = DivKoefisien
        ReportNotaPenjualan1.ReportParameters("invoice").Value = invoice
        ReportNotaPenjualan1.ReportParameters("banyak").Value = banyak
        ReportViewer1.RefreshReport()
        If ExtraOrdinary = False Then
            If SettingPreferensi.Penjualan.AutoPrint = "AutoBig" Then
                Dim reportproses As New Telerik.Reporting.Processing.ReportProcessor
                Dim printsetting As New System.Drawing.Printing.PrinterSettings
                Dim standardPrintController As New System.Drawing.Printing.StandardPrintController
                reportproses.PrintController = standardPrintController
                reportproses.PrintReport(Me.ReportViewer1.ReportSource, printsetting)
            ElseIf SettingPreferensi.Penjualan.AutoPrint = "AutoSmall" Then
                Dim reportproses As New Telerik.Reporting.Processing.ReportProcessor
                reportproses.PrintReport(Me.ReportViewer1.ReportSource, Nothing)
            End If
        End If
    End Sub
End Class