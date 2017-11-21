Public Class FormDetailHarian

    Private Property laba As Object
    Friend uc(0) As UserControl1
    Private Sub FormDetailHarian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DivKoefisien = DivCoef._1 Then
        '    For i = 1 To 3
        '        RadGridView1.Columns(i).FormatString = "{0:N2}"
        '    Next
        'Else
        '    For i = 1 To 3
        '        RadGridView1.Columns(i).FormatString = "{0:N0}"
        '    Next
        'End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If SettingAuthority.Laporan.CetakLaporan = True Then
            Using FilterPeriode As New FormFilterPeriode
                FilterPeriode.Text = "Laporan Penjualan Harian"
                FilterPeriode.Jenis = "Penjualan"
                FilterPeriode.BY = "Sales"
                FilterPeriode.RadDateTimePicker1.Value = CDate(tgltoday)
                FilterPeriode.RadDateTimePicker2.Value = CDate(tgltoday)
                FilterPeriode.ShowDialog()
                FilterPeriode.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub FormDetailHarian_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Using dt As DataTable = Me.Tabel_salesTableAdapter1.GetDataFilterN
            ReDim Preserve uc(dt.Rows.Count - 1)
            For i = 0 To dt.Rows.Count - 1
                uc(i) = New UserControl1()
                uc(i).nama_sales = CStr(dt.Rows(i).Item("nama"))
                Dim tab As Telerik.WinControls.UI.RadPageViewPage = New Telerik.WinControls.UI.RadPageViewPage(CStr(dt.Rows(i).Item("nama")))
                uc(i).Dock = DockStyle.Fill
                Dim ct As Control = uc(i)
                tab.Controls.Add(uc(i))
                'For n = 2 To 4
                '    If DivKoefisien = DivCoef._1 Then
                '        uc(i).RadGridView1.Columns(n).FormatString = "{0:N2}"
                '    Else
                '        uc(i).RadGridView1.Columns(n).FormatString = "{0:N0}"
                '    End If
                'Next
                uc(i).Tabel_detail_harianTableAdapter.Fill(uc(i).TokoDataSet.tabel_detail_harian, uc(i).nama_sales, tgltoday)
                uc(i).hitung_total()
                MetroTabControl1.Pages.Add(tab)
                RadGridView1.Rows.Add(uc(i).nama_sales, ubahtocurrencybyDiv(uc(i).penjualan), ubahtocurrencybyDiv(uc(i).retur), ubahtocurrencybyDiv(uc(i).pembayaran))
            Next
        End Using
    End Sub


    Private Sub RadGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles RadGridView1.SelectionChanged
        MetroTabControl1.SelectedPage = MetroTabControl1.Pages(RadGridView1.CurrentRow.Index)
    End Sub

End Class