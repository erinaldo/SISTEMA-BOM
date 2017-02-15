Public Class FormCetakLaporanTransaksiPenjualan
    Public Property id_customer As String
    Public Property nama_customer As String
    Public Property nama_sales As String
    Public Property tipe1 As String
    Public Property tipe2 As String
    Public Property tipe3 As String
    Public Property akhir As String
    Public Property awal As String

    Private Sub FormCetakLaporanTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanTransaksiPenjualan_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ReportTransaksiPenjualan1.ReportParameters("div").Value = DivKoefisien
        ReportTransaksiPenjualan1.ReportParameters("nama_perusahaan").Value = NamaToko
        ReportTransaksiPenjualan1.ReportParameters("customer").Value = id_customer
        ReportTransaksiPenjualan1.ReportParameters("nama_customer").Value = nama_customer
        ReportTransaksiPenjualan1.ReportParameters("sales").Value = nama_sales
        ReportTransaksiPenjualan1.ReportParameters("tipe_penjualan1").Value = tipe1
        ReportTransaksiPenjualan1.ReportParameters("tipe_penjualan2").Value = tipe2
        ReportTransaksiPenjualan1.ReportParameters("tipe_penjualan3").Value = tipe3
        ReportTransaksiPenjualan1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd 00:00")
        ReportTransaksiPenjualan1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd 23:59")
        ReportTransaksiPenjualan1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
