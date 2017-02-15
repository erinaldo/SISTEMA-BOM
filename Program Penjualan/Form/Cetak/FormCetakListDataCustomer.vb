Public Class FormCetakListDataCustomer
    Public Property hutang As String = "%"
    Public Property asal As String

    Private Sub FormCetakListDataCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakListDataCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.LaporanListDataCustomer1.ReportParameters("div").Value = DivKoefisien
        Me.LaporanListDataCustomer1.ReportParameters("nama_perusahaan").Value = NamaToko.ToUpper
        Me.LaporanListDataCustomer1.ReportParameters("hutang").Value = hutang
        Me.LaporanListDataCustomer1.ReportParameters("per_tanggal").Value = "PER " & Date.Now.Date.Day & " " & AngkaToBulan(Date.Now.Date.Month).ToUpper & " " & Date.Now.Year
        Me.LaporanListDataCustomer1.ReportParameters("kota").Value = asal
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
