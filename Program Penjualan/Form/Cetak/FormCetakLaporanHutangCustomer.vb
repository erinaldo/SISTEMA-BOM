Public Class FormCetakLaporanHutangCustomer

    Private Sub FormCetakLaporanHutangCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanHutangCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportLaporanHutangCustomer1.ReportParameters("div").Value = DivKoefisien
        Me.ReportLaporanHutangCustomer1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportLaporanHutangCustomer1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(tgltoday), "dd MMMM yyyy").ToUpper
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
