Public Class FormCetakLaporanPenjualanBulanan
    Property Awal As Date
    Property Akhir As Date
    Private Sub FormCetakLaporanPenjualanBulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanPenjualanBulanan_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim periode As String = ""
        If Format(Awal, "MM-dd") = "01-01" And Format(Akhir, "MM-dd") = "12-31" Then
            periode = "PERIODE " & " " & Year(Awal)
        Else
            periode = "PERIODE " & AngkaToBulan(Month(Awal)).ToUpper & " " & Year(Awal)
        End If
        Me.ReportTransaksiPenjualanBulanan1.ReportParameters("div").Value = DivKoefisien
        Me.ReportTransaksiPenjualanBulanan1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportTransaksiPenjualanBulanan1.ReportParameters("per_tanggal").Value = periode
        Me.ReportTransaksiPenjualanBulanan1.ReportParameters("awal").Value = Format(Awal, "yyyy-MM-dd")
        Me.ReportTransaksiPenjualanBulanan1.ReportParameters("akhir").Value = Format(Akhir, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
