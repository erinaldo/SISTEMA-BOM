Public Class FormFilterPeriode
    Property Jenis As String
    Property BY As String

    Private Sub FormFilterPeriode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.Text <> "Laporan Penjualan Harian" Then
            Me.RadDateTimePicker1.Value = CDate("1/" & Date.Now.Month & "/" & Date.Now.Year)
            Me.RadDateTimePicker2.Value = CDate(Date.DaysInMonth(Date.Now.Year, Date.Now.Month) & "/" & Date.Now.Month & "/" & Date.Now.Year)
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Me.Hide()
        'FormUtama.Show()
        If Jenis = "Penjualan" Then
            If BY = "Customer" Then
                Using CetakLaporanPenjualanCustomer = New FormCetakLaporanPenjualanCustomer
                    CetakLaporanPenjualanCustomer.awal = RadDateTimePicker1.Value.ToShortDateString
                    CetakLaporanPenjualanCustomer.akhir = RadDateTimePicker2.Value.ToShortDateString
                    CetakLaporanPenjualanCustomer.ShowDialog()
                    CetakLaporanPenjualanCustomer.Dispose()
                    CobaBersihkanMemori()
                End Using
            ElseIf BY = "Sales" Then
                Using CetakLaporanPenjualanSales As New FormCetakLaporanPenjualanSales
                    CetakLaporanPenjualanSales.awal = RadDateTimePicker1.Value.ToShortDateString
                    CetakLaporanPenjualanSales.akhir = RadDateTimePicker2.Value.ToShortDateString
                    CetakLaporanPenjualanSales.ShowDialog()
                    'Me.Hide()
                    CetakLaporanPenjualanSales.Dispose()
                    CobaBersihkanMemori()
                End Using
            ElseIf BY = "Produk" Then
                Using CetakLaporanPenjualanProduk As New FormCetakLaporanPenjualanProduk
                    CetakLaporanPenjualanProduk.awal = RadDateTimePicker1.Value.ToShortDateString
                    CetakLaporanPenjualanProduk.akhir = RadDateTimePicker2.Value.ToShortDateString
                    CetakLaporanPenjualanProduk.ShowDialog()
                    'Me.Hide()
                    CetakLaporanPenjualanProduk.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
        ElseIf Jenis = "Barang Masuk" Then
            If BY = "Supplier" Then
                Using CetakLaporanBarangMasukSupplier As New FormCetakLaporanBarangMasukSupplier
                    CetakLaporanBarangMasukSupplier.awal = RadDateTimePicker1.Value.ToShortDateString
                    CetakLaporanBarangMasukSupplier.akhir = RadDateTimePicker2.Value.ToShortDateString
                    CetakLaporanBarangMasukSupplier.ShowDialog()
                    'Me.Hide()
                    CetakLaporanBarangMasukSupplier.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
        ElseIf Jenis = "Profit" Then
            If BY = "Customer" Then
                Using CetakProfitCustomer As New FormCetakProfitCustomer
                    CetakProfitCustomer.awal = RadDateTimePicker1.Value.ToShortDateString
                    CetakProfitCustomer.akhir = RadDateTimePicker2.Value.ToShortDateString
                    CetakProfitCustomer.ShowDialog()
                    'Me.Hide()
                    CetakProfitCustomer.Dispose()
                    CobaBersihkanMemori()
                End Using
            ElseIf BY = "Sales" Then
                Using CetakProfitSales As New FormCetakProfitSales
                    CetakProfitSales.awal = RadDateTimePicker1.Value.ToShortDateString
                    CetakProfitSales.akhir = RadDateTimePicker2.Value.ToShortDateString
                    CetakProfitSales.ShowDialog()
                    'Me.Hide()
                    CetakProfitSales.Dispose()
                    CobaBersihkanMemori()
                End Using
            ElseIf BY = "Produk" Then
                Using CetakProfitProduk As New FormCetakProfitProduk
                    CetakProfitProduk.awal = RadDateTimePicker1.Value.ToShortDateString
                    CetakProfitProduk.akhir = RadDateTimePicker2.Value.ToShortDateString
                    CetakProfitProduk.ShowDialog()
                    'Me.Hide()
                    CetakProfitProduk.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
        End If
        Me.Close()
    End Sub
End Class
