Public Class FormCetakListDataProduk
    Property tipe_barang As String
    Property idnama As String

    Private Sub FormCetakListDataProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakListDataProduk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportListDataProduk1.ReportParameters("div").Value = DivKoefisien
        Me.ReportListDataProduk1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportListDataProduk1.ReportParameters("tipe_barang").Value = tipe_barang
        Me.ReportListDataProduk1.ReportParameters("idnama").Value = idnama
        Me.ReportListDataProduk1.ReportParameters("per_tanggal").Value = "PER   " & Date.Today.Date.Day & " " & AngkaToBulan(Date.Today.Date.Month).ToUpper & " " & Date.Today.Date.Year
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class