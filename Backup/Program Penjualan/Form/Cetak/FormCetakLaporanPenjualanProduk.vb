Public Class FormCetakLaporanPenjualanProduk
    Property awal As String
    Property akhir As String

    Private Sub FormCetakLaporanPenjualanProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanPenjualanProduk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportTransaksiPenjualanByProduk1.ReportParameters("div").Value = DivKoefisien
        Me.ReportTransaksiPenjualanByProduk1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportTransaksiPenjualanByProduk1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportTransaksiPenjualanByProduk1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd")
        Me.ReportTransaksiPenjualanByProduk1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
