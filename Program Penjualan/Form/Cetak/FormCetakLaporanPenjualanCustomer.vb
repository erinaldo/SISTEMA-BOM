Public Class FormCetakLaporanPenjualanCustomer
    Property awal As String
    Property akhir As String

    Private Sub FormCetakLaporanPenjualanCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanPenjualanCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportTransaksiPenjualanByCustomer1.ReportParameters("div").Value = DivKoefisien
        Me.ReportTransaksiPenjualanByCustomer1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportTransaksiPenjualanByCustomer1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy") & " - " & Format(CDate(akhir).Date, "dd MMM yy")
        Me.ReportTransaksiPenjualanByCustomer1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd")
        Me.ReportTransaksiPenjualanByCustomer1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
