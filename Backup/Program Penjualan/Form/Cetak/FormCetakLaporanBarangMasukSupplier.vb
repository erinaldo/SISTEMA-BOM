Public Class FormCetakLaporanBarangMasukSupplier

    Public Property awal As String
    Public Property akhir As String

    Private Sub FormCetakLaporanBarangMasukSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanBarangMasukSupplier_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportTransaksiBarangMasukSupplier1.ReportParameters("div").Value = DivKoefisien
        Me.ReportTransaksiBarangMasukSupplier1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportTransaksiBarangMasukSupplier1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy") & " - " & Format(CDate(akhir).Date, "dd MMM yy")
        Me.ReportTransaksiBarangMasukSupplier1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd")
        Me.ReportTransaksiBarangMasukSupplier1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
