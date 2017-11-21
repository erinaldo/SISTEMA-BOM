Public Class FormFilterBulanan
    Property Jenis As String
    Private Sub FormFilterBulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 12
            BulanRadDropDownList1.Items.Add(AngkaToBulan(i))
        Next
        BulanRadDropDownList1.SelectedIndex = 0
        For i = Date.Now.Year To Date.Now.Year - 20 Step -1
            ThnRadDropDownList1.Items.Add(i.ToString)
            TahunRadDropDownList2.Items.Add(i.ToString)
        Next
        ThnRadDropDownList1.SelectedIndex = 0
        TahunRadDropDownList2.SelectedIndex = 0
    End Sub

    Private Sub RadButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton1.Click
        Dim awal As Date
        Dim akhir As Date
        If RadioButton1.Checked = True Then
            awal = New Date(CInt(ThnRadDropDownList1.SelectedItem.Text), CInt(BulanToAngka(BulanRadDropDownList1.SelectedItem.Text)), 1)
            akhir = New Date(CInt(ThnRadDropDownList1.SelectedItem.Text), CInt(BulanToAngka(BulanRadDropDownList1.SelectedItem.Text)), Date.DaysInMonth(CInt(ThnRadDropDownList1.SelectedItem.Text), CInt(BulanToAngka(BulanRadDropDownList1.SelectedItem.Text))))
        Else
            awal = New Date(CInt(TahunRadDropDownList2.SelectedItem.Text), 1, 1)
            akhir = New Date(CInt(TahunRadDropDownList2.SelectedItem.Text), 12, Date.DaysInMonth(CInt(TahunRadDropDownList2.SelectedItem.Text), 12))
        End If

        Me.Hide()

        If RadioButton1.Checked = True Then
            If Jenis = "Penjualan" Then
                Using CetakPenjualanBulanan As New FormCetakLaporanPenjualanBulanan
                    CetakPenjualanBulanan.Awal = awal
                    CetakPenjualanBulanan.Akhir = akhir
                    CetakPenjualanBulanan.ShowDialog()

                    CetakPenjualanBulanan.Dispose()
                    CobaBersihkanMemori()
                End Using
            ElseIf Jenis = "Barang Masuk" Then
                Using CetakBarangMasukBulanan As New FormCetakLaporanBarangMasukBulanan
                    CetakBarangMasukBulanan.Awal = awal
                    CetakBarangMasukBulanan.Akhir = akhir
                    CetakBarangMasukBulanan.ShowDialog()
                    'Me.Hide()
                    CetakBarangMasukBulanan.Dispose()
                    CobaBersihkanMemori()
                End Using
            ElseIf Jenis = "Profit" Then
                Using CetakProfitBulanan As New FormCetakProfitBulanan
                    CetakProfitBulanan.Awal = awal
                    CetakProfitBulanan.Akhir = akhir
                    CetakProfitBulanan.ShowDialog()
                    'Me.Hide()
                    CetakProfitBulanan.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
        Else
            If Jenis = "Penjualan" Then
                Using CetakPenjualanTahunan As New FormCetakLaporanPenjualanTahunan
                    CetakPenjualanTahunan.Tanggal = awal
                    CetakPenjualanTahunan.ShowDialog()

                    CetakPenjualanTahunan.Dispose()
                    CobaBersihkanMemori()
                End Using
            ElseIf Jenis = "Barang Masuk" Then
                Using CetakBarangMasukTahunan As New FormCetakLaporanBarangMasukTahunan
                    CetakBarangMasukTahunan.Tanggal = awal
                    CetakBarangMasukTahunan.ShowDialog()
                    'Me.Hide()
                    CetakBarangMasukTahunan.Dispose()
                    CobaBersihkanMemori()
                End Using
            ElseIf Jenis = "Profit" Then
                Using CetakProfitTahunan As New FormCetakProfitTahunan
                    CetakProfitTahunan.Tanggal = awal
                    CetakProfitTahunan.ShowDialog()
                    'Me.Hide()
                    CetakProfitTahunan.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
        End If
        

        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TahunRadDropDownList2.Enabled = False
            BulanRadDropDownList1.Enabled = True
            ThnRadDropDownList1.Enabled = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TahunRadDropDownList2.Enabled = True
            BulanRadDropDownList1.Enabled = False
            ThnRadDropDownList1.Enabled = False
        End If
    End Sub
End Class
