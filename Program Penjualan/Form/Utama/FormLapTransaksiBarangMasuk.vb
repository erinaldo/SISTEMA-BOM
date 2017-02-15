Public Class FormLapTransaksiBarangMasuk

    Private Sub FormListBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DivKoefisien = DivCoef._1 Then
        '    RadGridView_brg_msk.Columns(5).FormatString = "{0:N2}"
        '    RadGridView_brg_msk.SummaryRowsBottom.Item(0).Item(1).FormatString = "{0:N2}"
        'Else
        '    RadGridView_brg_msk.Columns(5).FormatString = "{0:N0}"
        '    RadGridView_brg_msk.SummaryRowsBottom.Item(0).Item(1).FormatString = "{0:N0}"
        'End If
        If SettingAuthority.Laporan.SeleksiTanggalLaporan = False Then
            Awal_DateTimePicker.Enabled = False
            Akhir_DateTimePicker.Enabled = False
        End If
    End Sub

    Private Sub Cari_Button_Click(sender As Object, e As EventArgs) Handles Cari_Button.Click
        cari()
    End Sub

    Private Sub cari()
        Dim supplier As String = ""
        If Supplier_ComboBox.Text = "< Semua >" Then
            supplier = "%"
        ElseIf Supplier_ComboBox.Text = "< Order >" Then
            supplier = "Order%"
        Else
            supplier = Supplier_ComboBox.Text
        End If
        Me.Tabel_trans_brg_mskTableAdapter.FillByID_Supplier_and_Between_tgl_update(Me.TokoDataSet.tabel_trans_brg_msk, supplier, CType(Awal_DateTimePicker.Value.ToShortDateString & " 00:00", Date?), CType(Akhir_DateTimePicker.Value.ToShortDateString & " 23:59", Date?))
        'MessageBox.Show(Awal_DateTimePicker.Value)
        'hitung_total()
    End Sub

    Private Sub hitung_total()
        Dim jumlah_qty As Double = 0
        Dim jumlah_pembelian As Double = 0
        If RadGridView_brg_msk.Rows.Count > 0 Then
            For i = 0 To RadGridView_brg_msk.Rows.Count - 1
                jumlah_qty += RadGridView_brg_msk.Rows(i).Cells("total_masuk").Value
                jumlah_pembelian += RadGridView_brg_msk.Rows(i).Cells("total_pembelian").Value
            Next
        End If
        'RadGridView2.Rows.Clear()
        'RadGridView2.Rows.Add(Nothing, "", "", "", jumlah_qty, jumlah_pembelian)
        ' MessageBox.Show(RadGridView_brg_msk.Rows.Count)
    End Sub

    Private Sub isi_supplier()
        Using dt As DataTable = Me.Tabel_supplierTableAdapter.GetDataB()
            Supplier_ComboBox.MultiColumnComboBoxElement.Rows.Add("< Semua >", "", "")
            Supplier_ComboBox.MultiColumnComboBoxElement.Rows.Add("< Order >", "", "")
            For i = 0 To dt.Rows.Count - 1
                Supplier_ComboBox.MultiColumnComboBoxElement.Rows.Add(dt.Rows(i).Item("id_supplier"), dt.Rows(i).Item("nama"), dt.Rows(i).Item("asal"))
            Next
            Supplier_ComboBox.Text = "< Semua >"
        End Using
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SettingAuthority.Laporan.CetakLaporan = True Then
            Dim supplier As String = Supplier_ComboBox.Text
            Dim nama As String
            If supplier = "< Semua >" Then
                supplier = "%"
                nama = ""
            ElseIf supplier = "< Order >" Then
                supplier = "Order%"
                nama = "Order"
            Else
                nama = Tabel_supplierTableAdapter.ScalarQueryReturnNama(supplier)
            End If
            Using CetakLaporanTransaksiBarangMasuk As New FormCetakLaporanTransaksiBarangMasuk
                CetakLaporanTransaksiBarangMasuk.supplier = supplier
                CetakLaporanTransaksiBarangMasuk.namasupplier = nama
                CetakLaporanTransaksiBarangMasuk.awal = Awal_DateTimePicker.Value.ToShortDateString
                CetakLaporanTransaksiBarangMasuk.akhir = Akhir_DateTimePicker.Value.ToShortDateString
                CetakLaporanTransaksiBarangMasuk.ShowDialog()
                CetakLaporanTransaksiBarangMasuk.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub


    Dim loadsuppier As Boolean = False
    Private Sub Supplier_ComboBox_Enter(sender As Object, e As EventArgs) Handles Supplier_ComboBox.Enter
        If loadsuppier = False Then
            isi_supplier()
            loadsuppier = True
        End If
    End Sub

    Private Sub Supplier_ComboBox_Leave(sender As Object, e As EventArgs) Handles Supplier_ComboBox.Leave
        If Supplier_ComboBox.Text = "" Then
            Supplier_ComboBox.Text = "< Semua >"
        End If
    End Sub

    Private Sub FormLapTransaksiBarangMasuk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim tgl As String = Me.Tabel_trans_brg_mskTableAdapter.ScalarQueryMinDate().ToString
        If tgl = "" Then
            tgl = tgltoday
        End If
        Me.Awal_DateTimePicker.MaxDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        Me.Awal_DateTimePicker.MinDate = CDate(CDate(tgl).ToShortDateString)
        Me.Awal_DateTimePicker.Value = CDate(tgltoday)
        Me.Akhir_DateTimePicker.MaxDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        Me.Akhir_DateTimePicker.MinDate = CDate(CDate(tgl).ToShortDateString)
        Me.Akhir_DateTimePicker.Value = CDate(tgltoday)
        Me.Supplier_ComboBox.EditorControl.MasterTemplate.FilterDescriptors.LogicalOperator = Telerik.WinControls.Data.FilterLogicalOperator.Or
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_invoice_masuk' table. You can move, or remove it, as needed.
        'Me.Tabel_trans_brg_mskTableAdapter.FillByID_Supplier_and_Between_tgl_update(Me.TokoDataSet.tabel_trans_brg_msk, supplier + "%", Awal_DateTimePicker.Value.ToShortDateString, Akhir_DateTimePicker.Value.ToShortDateString)
        cari()
    End Sub

    Private Sub RadGridView2_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView_brg_msk.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 5 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub RadGridView_brg_msk_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView_brg_msk.CellClick
        If e.ColumnIndex = 1 Then
            Using CetakNotaBarangMasuk As New FormCetakNotaBarangMasuk
                CetakNotaBarangMasuk.Text = "Nota Barang Masuk " & e.Value.ToString
                'CetakNotaBarangMasuk.ExtraOrdinary = True
                CetakNotaBarangMasuk.Invoice = CStr(e.Value)
                'FormCetakNotaBarangMasuk.Banyak = banyak
                CetakNotaBarangMasuk.Kota = KotaToko
                CetakNotaBarangMasuk.ShowDialog()
                CetakNotaBarangMasuk.Dispose()
                CobaBersihkanMemori()
            End Using
            'Try
            '    If IsServer = True Then
            '        System.Diagnostics.Process.Start(My.Settings.FolderNota & "\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & e.Value.ToString & ".pdf")
            '    Else
            '        System.Diagnostics.Process.Start("//" & Server & "\" & My.Settings.FolderNota & "\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & e.Value.ToString & ".pdf")
            '    End If
            'Catch ex As Exception
            '    If IsServer = True Then
            '        MessageBox.Show("File " & My.Settings.FolderNota & "\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & e.Value.ToString & ".pdf" & "tidak dapat ditemukan!", "File tidak bisa dibuka", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    Else
            '        MessageBox.Show("File " & "//" & Server & "\" & My.Settings.FolderNota & "\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & e.Value.ToString & ".pdf" & "tidak dapat ditemukan!", "File tidak bisa dibuka", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '    End If
            'End Try
        End If
    End Sub

    Private Sub RadGridView_brg_msk_ViewCellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView_brg_msk.ViewCellFormatting
        If TypeOf e.CellElement Is Telerik.WinControls.UI.GridSummaryCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            e.CellElement.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
            If e.CellElement.Value.ToString <> "" And e.Column.Name = "total_pembelian" Then
                e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
            End If
        End If
    End Sub
End Class