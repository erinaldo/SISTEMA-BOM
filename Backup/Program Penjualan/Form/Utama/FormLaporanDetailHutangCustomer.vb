Public Class FormLaporanDetailHutangCustomer

    Property id_customer As String
    Private Sub FormLaporanDetailHutangCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i = 2 To 14
        '    If i = 2 Or i = 7 Or i = 9 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Then
        '        If DivKoefisien = DivCoef._1 Then
        '            RadGridView1.Columns(i).FormatString = "{0:N2}"
        '        Else
        '            RadGridView1.Columns(i).FormatString = "{0:N0}"
        '        End If
        '    End If
        'Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 2 Or e.ColumnIndex = 7 Or e.ColumnIndex = 9 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Or e.ColumnIndex = 13 Or e.ColumnIndex = 14 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SettingAuthority.Laporan.CetakLaporan = True Then
            Using CetakDetailHutangCustomer As New FormCetakDetailHutangCustomer
                CetakDetailHutangCustomer.id_customer = id_customer_label.Text
                CetakDetailHutangCustomer.nama_customer = nama_customer_label.Text
                CetakDetailHutangCustomer.awal = AwalDateTimePicker.Value.ToShortDateString
                CetakDetailHutangCustomer.akhir = AkhirDateTimePicker.Value.ToShortDateString
                CetakDetailHutangCustomer.hutang = hutang_label.Text
                CetakDetailHutangCustomer.ShowDialog()
                CetakDetailHutangCustomer.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub RadGridView1_CellClick(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellClick
        If e.ColumnIndex = 1 Then
            Dim rows As Integer = CInt(Me.Tabel_barang_keluarTableAdapter.ScalarQuery(CStr(e.Value)))
            Dim banyak As Integer = 0
            Dim N As Integer = rows \ 23
            If rows <= (N * 23) + 13 Then
                banyak = (13 + (23 * N)) - rows
            Else
                N += 1
                banyak = (13 + (23 * N)) - rows
            End If
            If e.Value.ToString.StartsWith("PN") Then
                If Tabel_invoice_keluarTableAdapter1.CekIsSmallByInvoice(CStr(e.Value)) = 0 Then
                    Using CetakNotaPenjualan As New FormCetakNotaPenjualan
                        CetakNotaPenjualan.ExtraOrdinary = True
                        CetakNotaPenjualan.Text = "Nota Penjualan " & e.Value.ToString
                        CetakNotaPenjualan.invoice = CStr(e.Value)
                        CetakNotaPenjualan.banyak = banyak
                        CetakNotaPenjualan.Kota = KotaToko
                        CetakNotaPenjualan.ShowDialog()
                        CetakNotaPenjualan.Dispose()
                        CobaBersihkanMemori()
                    End Using
                Else
                    Using CetakNotaPenjualanSmall As New FormCetakNotaPenjualanSmall
                        CetakNotaPenjualanSmall.ExtraOrdinary = True
                        CetakNotaPenjualanSmall.Text = "Nota Penjualan " & e.Value.ToString
                        CetakNotaPenjualanSmall.invoice = CStr(e.Value)
                        CetakNotaPenjualanSmall.ShowDialog()
                        CetakNotaPenjualanSmall.Dispose()
                        CobaBersihkanMemori()
                    End Using
                End If
            Else
                Using CetakNotaOrder As New FormCetakNotaOrder
                    'CetakNotaOrder.ExtraOrdinary = True
                    CetakNotaOrder.Text = "Nota Order " & e.Value.ToString
                    CetakNotaOrder.invoice = CStr(e.Value)
                    CetakNotaOrder.banyak = banyak + 1
                    CetakNotaOrder.ShowDialog()
                    CetakNotaOrder.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
            'Try
            '    If IsServer = True Then
            '        If e.Value.ToString.Contains("OB") Then
            '            System.Diagnostics.Process.Start(My.Settings.FolderNota & "\NotaOrderBarang\" & e.Value.ToString & ".pdf")
            '        Else
            '            System.Diagnostics.Process.Start(My.Settings.FolderNota & "\NotaPenjualan\" & e.Value.ToString & ".pdf")
            '        End If
            '    Else
            '        If e.Value.ToString.Contains("OB") Then
            '            System.Diagnostics.Process.Start("//" & Server & "\" & My.Settings.FolderNota & "\NotaOrderBarang\" & e.Value.ToString & ".pdf")
            '        Else
            '            System.Diagnostics.Process.Start("//" & Server & "\" & My.Settings.FolderNota & "\NotaPenjualan\" & e.Value.ToString & ".pdf")
            '        End If
            '    End If
            'Catch ex As Exception
            '    If IsServer = True Then
            '        If e.Value.ToString.Contains("OB") Then
            '            MessageBox.Show("File " & My.Settings.FolderNota & "\NotaOrderBarang\" & e.Value.ToString & ".pdf" & " tidak dapat ditemukan!", "File tidak bisa dibuka", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Else
            '            MessageBox.Show("File " & My.Settings.FolderNota & "\NotaPenjualan\" & e.Value.ToString & ".pdf" & " tidak dapat ditemukan!", "File tidak bisa dibuka", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        End If
            '    Else
            '        If e.Value.ToString.Contains("OB") Then
            '            MessageBox.Show("File " & "//" & Server & "\" & My.Settings.FolderNota & "\NotaOrderBarang\" & e.Value.ToString & ".pdf" & " tidak dapat ditemukan!", "File tidak bisa dibuka", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Else
            '            MessageBox.Show("File " & "//" & Server & "\" & My.Settings.FolderNota & "\NotaPenjualan\" & e.Value.ToString & ".pdf" & " tidak dapat ditemukan!", "File tidak bisa dibuka", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        End If
            '    End If
            'End Try
        End If
    End Sub

    Public Sub cari()
        Me.Tabel_invoice_keluarTableAdapter.FillByIDCustomer_and_Tgl(Me.TokoDataSet.tabel_invoice_keluar, id_customer, CDate(AwalDateTimePicker.Value.ToShortDateString & " 00:00"), CDate(AkhirDateTimePicker.Value.ToShortDateString & " 23:59"))
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        cari()
    End Sub

    Private Sub FormLaporanDetailHutangCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_invoice_keluar' table. You can move, or remove it, as needed.
        Dim min_date As Date = CDate(Me.Tabel_invoice_keluarTableAdapter.ScalarQueryMinDate_by_IDCustomer(id_customer))
        'Me.AwalDateTimePicker.MaxDate = tgltoday
        Me.AwalDateTimePicker.MinDate = min_date
        Me.AwalDateTimePicker.Value = min_date
        'Me.AkhirDateTimePicker.MaxDate = tgltoday
        Me.AkhirDateTimePicker.MinDate = min_date
        Me.AkhirDateTimePicker.Value = CDate(tgltoday)
        Using dt As DataTable = Me.Tabel_customerTableAdapter.GetData_based_id_customer(id_customer)
            id_customer_label.Text = CStr(dt.Rows(0).Item("id_customer"))
            nama_customer_label.Text = CStr(dt.Rows(0).Item("nama"))
            alamat_customer_label.Text = CStr(dt.Rows(0).Item("alamat"))
            daerah_kota_label.Text = CStr(dt.Rows(0).Item("asal"))
            telp_label.Text = CStr(dt.Rows(0).Item("telp"))
            hutang_label.Text = ubahtocurrencybyDiv(CStr(dt.Rows(0).Item("hutang_lama")))
            terdaftar_label.Text = CStr(dt.Rows(0).Item("terdaftar_bln"))
        End Using
        cari()

    End Sub
End Class