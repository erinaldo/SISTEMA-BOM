Public Class FormCetakLaporanPenjualanSales
    Property awal As String
    Property akhir As String

    Private Sub FormCetakLaporanPenjualanBySales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanPenjualanSales_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportTransaksiPenjualanSales1.ReportParameters("div").Value = DivKoefisien
        Me.ReportTransaksiPenjualanSales1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportTransaksiPenjualanSales1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportTransaksiPenjualanSales1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd")
        Me.ReportTransaksiPenjualanSales1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
