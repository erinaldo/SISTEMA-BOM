Public Class FormCetakLaporanMostProfit

    Property awal As String
    Property akhir As String
    Private Sub FormCetakLaporanMostProfit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormCetakLaporanMostProfit_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ReportLaporanMostProfit1.ReportParameters("div").Value = DivKoefisien
        Me.ReportLaporanMostProfit1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportLaporanMostProfit1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportLaporanMostProfit1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd 00:00")
        Me.ReportLaporanMostProfit1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd 23:59")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
