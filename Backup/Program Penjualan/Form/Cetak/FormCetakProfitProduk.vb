Public Class FormCetakProfitProduk
    Property awal As String
    Property akhir As String
    Private Sub FormCetakProfitProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakProfitProduk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportProfitProduk1.ReportParameters("div").Value = DivKoefisien
        Me.ReportProfitProduk1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportProfitProduk1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportProfitProduk1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd")
        Me.ReportProfitProduk1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
