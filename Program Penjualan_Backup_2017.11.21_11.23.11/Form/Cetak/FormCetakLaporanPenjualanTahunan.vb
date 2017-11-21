Public Class FormCetakLaporanPenjualanTahunan
    Public Property Tanggal As Date

    Private Sub FormCetakLaporanPenjualanTahunan_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ReportTransaksiPenjualanTahunan1.ReportParameters("div").Value = DivKoefisien
        Me.ReportTransaksiPenjualanTahunan1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportTransaksiPenjualanTahunan1.ReportParameters("per_tanggal").Value = "PERIODE " & " " & Year(Tanggal)
        Me.ReportTransaksiPenjualanTahunan1.ReportParameters("tanggal").Value = Format(Tanggal, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FormCetakLaporanPenjualanTahunan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
