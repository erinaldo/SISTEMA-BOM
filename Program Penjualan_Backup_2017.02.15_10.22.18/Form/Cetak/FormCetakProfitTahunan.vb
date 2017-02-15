Public Class FormCetakProfitTahunan
    Public Property Tanggal As Date

    Private Sub FormCetakProfitTahunan_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ReportProfitTahunan1.ReportParameters("div").Value = DivKoefisien
        Me.ReportProfitTahunan1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportProfitTahunan1.ReportParameters("per_tanggal").Value = "PERIODE " & " " & Year(Tanggal)
        Me.ReportProfitTahunan1.ReportParameters("tanggal").Value = Format(Tanggal, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FormCetakProfitTahunan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
