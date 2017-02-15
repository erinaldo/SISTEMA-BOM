Public Class FormCetakListDataSupplier

    Public Property asal As String
    Public Property nama_perusahaan As String

    Private Sub FormCetakListDataSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakListDataSupplier_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportListDataSupplier1.ReportParameters("div").Value = DivKoefisien
        Me.ReportListDataSupplier1.ReportParameters("nama_perusahaan").Value = NamaToko.ToUpper
        Me.ReportListDataSupplier1.ReportParameters("kota").Value = asal
        Me.ReportListDataSupplier1.ReportParameters("per_tanggal").Value = "PER " & Date.Now.Date.Day & " " & AngkaToBulan(Date.Now.Date.Month).ToUpper & " " & Date.Now.Year
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
