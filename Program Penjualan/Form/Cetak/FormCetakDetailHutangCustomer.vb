Public Class FormCetakDetailHutangCustomer

    Public Property id_customer As String
    Public Property nama_customer As String
    Public Property akhir As String
    Public Property awal As String
    Public Property hutang As String

    Private Sub FormCetakDetailHutangCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakDetailHutangCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportDetailHutangCustomer1.ReportParameters("div").Value = DivKoefisien
        Me.ReportDetailHutangCustomer1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportDetailHutangCustomer1.ReportParameters("nama_customer").Value = nama_customer
        Me.ReportDetailHutangCustomer1.ReportParameters("id_customer").Value = id_customer
        Me.ReportDetailHutangCustomer1.ReportParameters("hutang").Value = hutang
        Me.ReportDetailHutangCustomer1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportDetailHutangCustomer1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd 00:00")
        Me.ReportDetailHutangCustomer1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd 23:59")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
