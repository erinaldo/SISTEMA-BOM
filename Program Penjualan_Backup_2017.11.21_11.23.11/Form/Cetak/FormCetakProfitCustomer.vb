Public Class FormCetakProfitCustomer

    Public Property akhir As String

    Public Property awal As String

    Private Sub FormCetakProfitCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakProfitCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportProfitCustomer1.ReportParameters("div").Value = DivKoefisien
        Me.ReportProfitCustomer1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportProfitCustomer1.ReportParameters("per_tanggal").Value = "PER " & Format(CDate(awal).Date, "dd MMM yy").ToUpper & " - " & Format(CDate(akhir).Date, "dd MMM yy").ToUpper
        Me.ReportProfitCustomer1.ReportParameters("awal").Value = Format(CDate(awal).Date, "yyyy-MM-dd")
        Me.ReportProfitCustomer1.ReportParameters("akhir").Value = Format(CDate(akhir).Date, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
