Public Class FormCetakLaporanBestSellerDetail
    Property awal As String
    Property akhir As String
    Property tipe As String
    Property kode_tipe As String
    Private Sub FormCetakLaporanBestSellerDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanBestSellerDetail_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportLaporanBestSellerTipeBarang1.ReportParameters("div").Value = DivKoefisien
        Me.ReportLaporanBestSellerTipeBarang1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportLaporanBestSellerTipeBarang1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportLaporanBestSellerTipeBarang1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd 00:00")
        Me.ReportLaporanBestSellerTipeBarang1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd 23:59")
        Me.ReportLaporanBestSellerTipeBarang1.ReportParameters("id_barang").Value = kode_tipe
        Me.ReportLaporanBestSellerTipeBarang1.ReportParameters("tipe_barang").Value = tipe
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
