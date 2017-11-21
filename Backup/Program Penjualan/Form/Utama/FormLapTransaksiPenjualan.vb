Imports Telerik.WinControls.UI

Public Class FormLapTransaksiPenjualan
    Dim penjualan_total, bayar_total, retur_total As Integer

    Private Sub FormLapTransaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SettingAuthority.Laporan.SeleksiTanggalLaporan = False Then
            Awal_DateTimePicker.Enabled = False
            Akhir_DateTimePicker.Enabled = False
        End If
    End Sub

    Private Sub fill_tanggal()
        Dim mindate As String
        mindate = Me.Tabel_trans_barang_keluarTableAdapter.ScalarQueryMinDate().ToString
        If mindate = "" Then
            mindate = tgltoday
        End If
        Me.Awal_DateTimePicker.MinDate = CDate(mindate)
        'Me.Awal_DateTimePicker.MaxDate = tgltoday
        Me.Awal_DateTimePicker.Value = CDate(tgltoday)
        Me.Akhir_DateTimePicker.MinDate = CDate(mindate)
        'Me.Akhir_DateTimePicker.MaxDate = tgltoday
        Me.Akhir_DateTimePicker.Value = CDate(tgltoday)
    End Sub

    Private Sub fill_customer()
        Using dt As DataTable = Me.Tabel_customerTableAdapter.GetDataSortByNama()
            Customer_ComboBox.MultiColumnComboBoxElement.Rows.Add("< Semua >", "", "")
            For i = 0 To dt.Rows.Count - 1
                Customer_ComboBox.MultiColumnComboBoxElement.Rows.Add(dt.Rows(i).Item("id_customer"), dt.Rows(i).Item("nama"))
            Next
            Customer_ComboBox.SelectedIndex = 0
        End Using
    End Sub

    Private Sub fill_sales()
        Using dt As DataTable = Me.Tabel_salesTableAdapter.GetData()
            Sales_ComboBox.Items.Add("< Semua >")
            For i = 0 To dt.Rows.Count - 1
                Sales_ComboBox.Items.Add(dt.Rows(i).Item("nama").ToString)
            Next
            Sales_ComboBox.SelectedIndex = 0
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cari()
    End Sub

    Private Sub cari()
        Dim idS_customer As String = Customer_ComboBox.Text
        Dim nama_sales As String = Sales_ComboBox.SelectedItem.Text
        Dim tipe_jual1 As String = RadCheckBox1.Text
        Dim tipe_jual2 As String = RadCheckBox2.Text
        Dim tipe_jual3 As String = RadCheckBox3.Text
        If idS_customer = "< Semua >" Then
            idS_customer = "%"
        End If
        If nama_sales = "< Semua >" Then
            nama_sales = "%"
        End If
        If RadCheckBox1.Checked = False Then
            tipe_jual1 = ""
        End If
        If RadCheckBox2.Checked = False Then
            tipe_jual2 = ""
        End If
        If RadCheckBox3.Checked = False Then
            tipe_jual3 = ""
        End If
        Me.Tabel_trans_barang_keluarTableAdapter.FillByFilter(Me.TokoDataSet.tabel_trans_barang_keluar, nama_sales, tipe_jual1, tipe_jual2, tipe_jual3, idS_customer, CDate(Awal_DateTimePicker.Value.ToShortDateString & " 00:00"), CDate(Akhir_DateTimePicker.Value.ToShortDateString & " 23:59"))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SettingAuthority.Laporan.CetakLaporan = True Then
            Dim idS_customer As String = Customer_ComboBox.Text
            Dim nama_sales As String = Sales_ComboBox.SelectedItem.Text
            Dim tipe_jual1 As String = RadCheckBox1.Text
            Dim tipe_jual2 As String = RadCheckBox2.Text
            Dim tipe_jual3 As String = RadCheckBox3.Text
            Dim nama_customer As String
            If Customer_ComboBox.Text = "< Semua >" Then
                idS_customer = "%"
                nama_customer = ""
            Else
                nama_customer = CStr(Tabel_customerTableAdapter.ScalarQueryReturnNama(idS_customer))
            End If
            If Sales_ComboBox.SelectedItem.Text = "< Semua >" Then
                nama_sales = "%"
            End If
            If RadCheckBox1.Checked = False Then
                tipe_jual1 = ""
            End If
            If RadCheckBox2.Checked = False Then
                tipe_jual2 = ""
            End If
            If RadCheckBox3.Checked = False Then
                tipe_jual3 = ""
            End If
            Using CetakLaporanTransaksiPenjualan As New FormCetakLaporanTransaksiPenjualan
                CetakLaporanTransaksiPenjualan.id_customer = idS_customer
                CetakLaporanTransaksiPenjualan.nama_customer = nama_customer
                CetakLaporanTransaksiPenjualan.nama_sales = nama_sales
                CetakLaporanTransaksiPenjualan.tipe1 = tipe_jual1
                CetakLaporanTransaksiPenjualan.tipe2 = tipe_jual2
                CetakLaporanTransaksiPenjualan.tipe3 = tipe_jual3
                CetakLaporanTransaksiPenjualan.awal = Awal_DateTimePicker.Value.ToShortDateString & " 00:00"
                CetakLaporanTransaksiPenjualan.akhir = Akhir_DateTimePicker.Value.ToShortDateString & " 23:59"
                CetakLaporanTransaksiPenjualan.ShowDialog()
                CetakLaporanTransaksiPenjualan.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 4 Then
            e.CellElement.Text = (e.CellElement.Text).Substring(0, 1)
        End If
        If e.ColumnIndex >= 5 And e.ColumnIndex <= 9 Then
            If e.ColumnIndex = RadGridView1.Columns("retur").Index Then
                e.CellElement.Font = New Font("Segoe UI", 8.25, FontStyle.Underline)
            End If
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Dim loadcustomer As Boolean = False
    Private Sub Customer_ComboBox_Enter(sender As Object, e As EventArgs) Handles Customer_ComboBox.Enter
        If loadcustomer = False Then
            Using dt As DataTable = Me.Tabel_customerTableAdapter.GetDataB()
                Customer_ComboBox.MultiColumnComboBoxElement.Rows.Add("< Semua >")
                For i = 0 To dt.Rows.Count - 1
                    Customer_ComboBox.MultiColumnComboBoxElement.Rows.Add(dt.Rows(i).Item("id_customer"), dt.Rows(i).Item("nama"), dt.Rows(i).Item("asal"))
                Next
                Customer_ComboBox.SelectedIndex = 0
                loadcustomer = True
            End Using
        End If
    End Sub

    Private Sub Customer_ComboBox_Leave(sender As Object, e As EventArgs) Handles Customer_ComboBox.Leave
        If Customer_ComboBox.Text = "" Then
            Customer_ComboBox.Text = "< Semua >"
        End If
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellClick
        If e.ColumnIndex = 1 And e.RowIndex >= 0 Then
            Dim rows As Integer = CInt(Me.Tabel_barang_keluarTableAdapter.ScalarQuery(CStr(e.Value)))
            If e.Value.ToString.StartsWith("PN") Then
                If Tabel_invoice_keluarTableAdapter1.CekIsSmallByInvoice(CStr(e.Value)) = 0 Then
                    Using CetakNotaPenjualan As New FormCetakNotaPenjualan
                        CetakNotaPenjualan.ExtraOrdinary = True
                        CetakNotaPenjualan.Text = "Nota Penjualan " & e.Value.ToString
                        CetakNotaPenjualan.invoice = CStr(e.Value)
                        CetakNotaPenjualan.banyak = BanyakBarisNota(rows)
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
                If SettingPreferensi.Order.Nota = "Big" Then
                    Using CetakNotaOrder As New FormCetakNotaOrder
                        CetakNotaOrder.AutoPrint = False
                        CetakNotaOrder.Text = "Nota Order " & e.Value.ToString
                        CetakNotaOrder.invoice = CStr(e.Value)
                        CetakNotaOrder.banyak = BanyakBarisNota(rows) + 1
                        CetakNotaOrder.ShowDialog()
                        CetakNotaOrder.Dispose()
                        CobaBersihkanMemori()
                    End Using
                Else
                    Using CetakNotaPenjualanSmall As New FormCetakNotaOrderSimple
                        CetakNotaPenjualanSmall.AutoPrint = False
                        CetakNotaPenjualanSmall.invoice = CStr(e.Value)
                        CetakNotaPenjualanSmall.ShowDialog()
                        CetakNotaPenjualanSmall.Dispose()
                    End Using
                End If
            End If
        ElseIf e.ColumnIndex = RadGridView1.Columns("retur").Index And e.RowIndex >= 0 Then
            Using FormCetakRetur As New FormCetakNotaRetur
                FormCetakRetur.Invoice = RadGridView1.Rows(e.RowIndex).Cells("invoice").Value
                FormCetakRetur.Text = "Form Retur"
                FormCetakRetur.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub FormLapTransaksiPenjualan_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        fill_tanggal()
        'fill_customer()
        Me.Customer_ComboBox.EditorControl.MasterTemplate.FilterDescriptors.LogicalOperator = Telerik.WinControls.Data.FilterLogicalOperator.Or
        fill_sales()
        Me.RadGridView1.MasterTemplate.ShowTotals = True
        Me.RadGridView1.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom
        cari()
    End Sub

    Private Sub RadGridView1_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles RadGridView1.ViewCellFormatting
        If TypeOf e.CellElement Is Telerik.WinControls.UI.GridSummaryCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            e.CellElement.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
            If e.CellElement.Value <> "" Then
                e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
            End If
        End If
        'If TypeOf e.CellElement Is Telerik.WinControls.UI.GridCellElement And Not TypeOf e.CellElement Is Telerik.WinControls.UI.GridHeaderCellElement Then
        '    If e.ColumnIndex = RadGridView1.Columns("retur").Index And e.CellElement.Text <> "" Then
        '        e.CellElement.Text = FormatNumber(e.CellElement.Text, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        'End If
    End Sub
End Class