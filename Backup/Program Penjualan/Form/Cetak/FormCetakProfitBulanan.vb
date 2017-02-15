Public Class FormCetakProfitBulanan
    Public Property Awal As Date
    Public Property Akhir As Date

    Private Sub FormCetakProfitBulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakProfitBulanan_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim periode As String = ""
        If Format(Awal, "MM-dd") = "01-01" And Format(Akhir, "MM-dd") = "12-31" Then
            periode = "PERIODE " & " " & Year(Awal)
        Else
            periode = "PERIODE " & AngkaToBulan(Month(Awal)).ToUpper & " " & Year(Awal)
        End If
        Me.ReportProfitBulanan1.ReportParameters("div").Value = DivKoefisien
        Me.ReportProfitBulanan1.ReportParameters("nama_perusahaan").Value = NamaToko
        Me.ReportProfitBulanan1.ReportParameters("per_tanggal").Value = periode
        Me.ReportProfitBulanan1.ReportParameters("awal").Value = Format(Awal, "yyyy-MM-dd")
        Me.ReportProfitBulanan1.ReportParameters("akhir").Value = Format(Akhir, "yyyy-MM-dd")
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
