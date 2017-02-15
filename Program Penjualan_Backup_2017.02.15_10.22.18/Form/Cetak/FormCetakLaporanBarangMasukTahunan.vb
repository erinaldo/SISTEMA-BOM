Public Class FormCetakLaporanBarangMasukTahunan

    Public Property Tanggal As Date
    Private Sub FormCetakLaporanBarangMasukTahunan_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ReportTransaksiBarangMasukTahunan1.ReportParameters("div").Value = DivKoefisien
        Me.ReportTransaksiBarangMasukTahunan1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportTransaksiBarangMasukTahunan1.ReportParameters("per_tanggal").Value = "PERIODE " & " " & Year(Tanggal)
        Me.ReportTransaksiBarangMasukTahunan1.ReportParameters("tanggal").Value = Format(Tanggal, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
