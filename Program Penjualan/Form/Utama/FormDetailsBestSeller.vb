Public Class FormDetailsBestSeller
    Property Tipe As String
    Property Status As String
    Property Awal As String
    Property Akhir As String
    Private Sub FormDetailsBestSeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i = 4 To 5
        '    If DivKoefisien = DivCoef._1 Then
        '        DataGridView1.Columns(i).FormatString = "{0:N2}"
        '    Else
        '        DataGridView1.Columns(i).FormatString = "{0:N0}"
        '    End If
        'Next
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Close()
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If SettingAuthority.Laporan.CetakLaporan = True Then
            Dim kode_tipe As String = Me.Tabel_tipe_barangTableAdapter1.ScalarQueryReturnKodeTipe(tipe)
            Using CetakLaporanBestSeller As New FormCetakLaporanBestSellerDetail
                CetakLaporanBestSeller.awal = Awal
                CetakLaporanBestSeller.akhir = Akhir
                CetakLaporanBestSeller.tipe = Tipe
                CetakLaporanBestSeller.kode_tipe = kode_tipe
                CetakLaporanBestSeller.ShowDialog()
                CetakLaporanBestSeller.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub FormDetailsBestSeller_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        RadLabel1.Text = "Periode " & Format(CDate(Awal).Date, "dd MMMM yyyy") & " sampai " & Format(CDate(Akhir).Date, "dd MMMM yyyy")
        If Status = "Most Profit" Then
            Me.Tabel_detail_bestsellerTableAdapter.FillByMostProfit(Me.TokoDataSet.tabel_detail_bestseller, CDate(Awal), CDate(Akhir), Tipe)
        Else
            Me.Tabel_detail_bestsellerTableAdapter.Fill(Me.TokoDataSet.tabel_detail_bestseller, CDate(Awal), CDate(Akhir), Tipe)
        End If
    End Sub
End Class