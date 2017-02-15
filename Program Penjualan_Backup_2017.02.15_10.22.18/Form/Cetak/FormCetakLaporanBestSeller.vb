Public Class FormCetakLaporanBestSeller
    Property awal As String
    Property akhir As String

    Private Sub FormCetakLaporanBestSeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanBestSeller_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportLaporanBestSeller1.ReportParameters("div").Value = DivKoefisien
        Me.ReportLaporanBestSeller1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportLaporanBestSeller1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportLaporanBestSeller1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd 00:00")
        Me.ReportLaporanBestSeller1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd 23:59")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
