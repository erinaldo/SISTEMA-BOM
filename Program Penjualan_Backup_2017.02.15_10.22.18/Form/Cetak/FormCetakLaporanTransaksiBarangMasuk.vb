Public Class FormCetakLaporanTransaksiBarangMasuk
    Property supplier As String
    Property namasupplier As String
    Property awal As String
    Property akhir As String

    Private Sub FormCetakLaporanTransaksiBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanTransaksiBarangMasuk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportTransaksiBarangMasuk1.ReportParameters("div").Value = DivKoefisien
        Me.ReportTransaksiBarangMasuk1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportTransaksiBarangMasuk1.ReportParameters("nama_supplier").Value = namasupplier
        Me.ReportTransaksiBarangMasuk1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportTransaksiBarangMasuk1.ReportParameters("supplier").Value = supplier
        Me.ReportTransaksiBarangMasuk1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd 00:00")
        Me.ReportTransaksiBarangMasuk1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd 23:59")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
