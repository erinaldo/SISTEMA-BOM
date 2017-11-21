Public Class FormCetakLaporanProfit
    Property nama_sales As String
    Property nama_customer As String
    Property tipe_penjualan1 As String
    Property tipe_penjualan2 As String
    Property tipe_penjualan3 As String
    Property awal As String
    Property akhir As String
    Property id_customer As String

    Private Sub FormCetakLaporanProfit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakLaporanProfit_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportLaporanProfit1.ReportParameters("div").Value = DivKoefisien
        Me.ReportLaporanProfit1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportLaporanProfit1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportLaporanProfit1.ReportParameters("namacustomer").Value = nama_customer
        Me.ReportLaporanProfit1.ReportParameters("idcustomer").Value = id_customer
        Me.ReportLaporanProfit1.ReportParameters("namasales").Value = nama_sales
        Me.ReportLaporanProfit1.ReportParameters("tipepenjualan1").Value = tipe_penjualan1
        Me.ReportLaporanProfit1.ReportParameters("tipepenjualan2").Value = tipe_penjualan2
        Me.ReportLaporanProfit1.ReportParameters("tipepenjualan3").Value = tipe_penjualan3
        Me.ReportLaporanProfit1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd 00:00")
        Me.ReportLaporanProfit1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd 23:59")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
