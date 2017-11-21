Public Class FormCetakProfitSales
    Property awal As String
    Property akhir As String
    Private Sub FormCetakProfitSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakProfitSales_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportProfitSales1.ReportParameters("div").Value = DivKoefisien
        Me.ReportProfitSales1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportProfitSales1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportProfitSales1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd")
        Me.ReportProfitSales1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
