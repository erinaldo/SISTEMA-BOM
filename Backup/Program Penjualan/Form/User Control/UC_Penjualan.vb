Imports Telerik.WinControls.Data

Public Class UC_Penjualan

    Public Enum TipePenjualan
        BigNota
        SmallNota
        Order
    End Enum
    Property tipe As TipePenjualan
    Private Property adadidb As Boolean

    Public Sub tutup_penjualan()
        If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yakin ingin menutup transaksi Penjualan ini?", "Perhatian", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) _
           = DialogResult.Yes Then
            Me.Tabel_status_transaksiTableAdapter.InsertQuery(CDate(tgltoday), "Penjualan-" & tipe.ToString, "Gagal")
            FormUtama.RadLabel7.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%Small%"))
            FormUtama.RadLabel11.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%Big%"))
            FormUtama.RadLabel13.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%Order%"))
            FormUtama.RadLabel15.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%Barang%"))
            FormUtama.RadLabel17.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%"))
            If tipe = TipePenjualan.BigNota Then
                FormUtama.uc_pf(CInt(FormUtama.TabControl1.SelectedPage.Text.Replace("Penjualan (Big Nota) ", "")) - 1).Dispose()
                FormUtama.tabpages_penjualanfast(CInt(FormUtama.TabControl1.SelectedPage.Text.Replace("Penjualan (Big Nota) ", "")) - 1).Dispose()
            ElseIf tipe = TipePenjualan.Order Then
                FormUtama.uc_po(CInt(FormUtama.TabControl1.SelectedPage.Text.Replace("Penjualan (Order Barang) ", "")) - 1).Dispose()
                FormUtama.tabpages_penjualanorder(CInt(FormUtama.TabControl1.SelectedPage.Text.Replace("Penjualan (Order Barang) ", "")) - 1).Dispose()
            Else
                FormUtama.uc_p(CInt(FormUtama.TabControl1.SelectedPage.Text.Replace("Penjualan (Small Nota) ", "")) - 1).Dispose()
                FormUtama.tabpages_penjualan(CInt(FormUtama.TabControl1.SelectedPage.Text.Replace("Penjualan (Small Nota) ", "")) - 1).Dispose()
            End If
        End If
        CobaBersihkanMemori()
    End Sub

    Private Sub Button_Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_Cancel.Click
        tutup_penjualan()
    End Sub

    Public Sub ControlToBayarTextBox()
        If tipe = TipePenjualan.Order Then
            bayar_TextBox_order.Focus()
        Else
            bayar_TextBox.Focus()
        End If
    End Sub
    Public Sub eksekusi()
        If id_customer_TextBox.Text = "C-000-000" Then
            If totalRp_hutangbaru_Label.Text <> "LUNAS" Then
                Telerik.WinControls.RadMessageBox.Show("ID C-000-000 tidak boleh ada hutang atau piutang.")
                If tipe = TipePenjualan.Order Then
                    bayar_TextBox_order.Text = CStr(0)
                    bayar_TextBox_order.Focus()
                Else
                    bayar_TextBox.Text = CStr(0)
                    bayar_TextBox.Focus()
                End If
            Else
                Lakukan()
            End If
        Else
            Lakukan()
        End If
    End Sub

    Private Sub Lakukan()
        If Telerik.WinControls.RadMessageBox.Show("Apakah anda yakin ingin  melanjutkan transaksi Penjualan ini ?", "Konfirmasi", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = DialogResult.Yes Then
            Dim status_konvert As String = convert_kuota()
            If status_konvert = "ada" Then
                bayar_TextBox.Text = "0"
                totalRp_hutangbaru_Label.Text = "0"
                bayar_TextBox.Focus()
                hitung_total()
            ElseIf status_konvert = "gk ada" Then
                'Try
                proses_transaksi()
                'Catch ex As Exception
                ' Telerik.WinControls.RadMessageBox.Show(ex.Message, "Transaksi Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                ' End Try
            Else
                'skip
            End If
        End If
    End Sub

    Private Sub Button_Yes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_Yes.Click
        eksekusi()
    End Sub

    Private Sub proses_transaksi()
        Dim l As Boolean = True
        If l = True Then
            l = l And tambah_invoice()
        End If
        If l = True Then
            For i = 0 To Grid_Penjualan.RowCount - 1
                If CType(Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value, Integer) <> 0 Then
                    If l = True Then
                        l = l And update_barang_penjualan(i)
                    End If
                    If l = True Then
                        l = l And tambah_barang_keluar(i)
                    End If
                End If
            Next
        End If
        If l = True Then
            For i = 0 To fr_retur.RadGridView1.RowCount - 1
                If CType(fr_retur.RadGridView1.Rows(i).Cells("qty").Value, Integer) <> 0 Then
                    If l = True Then
                        l = l And update_barang_retur(i)
                    End If
                    If l = True Then
                        l = l And tambah_retur(i)
                    End If
                End If
            Next
        End If
        If l = True Then
            update_hutang()
        End If
        If l = False Then
            Telerik.WinControls.RadMessageBox.Show("Transaksi gagal, data tidak dapat disimpan pada database.", "Penjualan", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        Else
            Me.Tabel_status_transaksiTableAdapter.InsertQuery(CDate(tgltoday), "Penjualan-" & tipe.ToString, "Berhasil")
            FormUtama.RadLabel10.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%Small%"))
            FormUtama.RadLabel12.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%Big%"))
            FormUtama.RadLabel14.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%Order%"))
            FormUtama.RadLabel16.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%Barang%"))
            FormUtama.RadLabel18.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%"))
            'Telerik.WinControls.RadMessageBox.Show("Transaksi sukses, data telah tersimpan pada database.", "Barang Masuk", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            cetakNota()
            FormUtama.TabControl1.Pages.Remove(FormUtama.TabControl1.SelectedPage)
        End If
        'FormUtama.load_detail_harian()
    End Sub

    Private Sub cetakNota()
        Dim rows As Integer = CInt(Me.Tabel_barang_keluarTableAdapter.ScalarQuery(Label_Invoice.Text))

        If tipe = TipePenjualan.BigNota Then
            'If SettingPreferensi.Penjualan.AutoPrint = "AutoBig" Then
            '    Using ReportNotaPenjualan1 As New ReportNotaPenjualan
            '        ReportNotaPenjualan1.ReportParameters("invoice").Value = Label_Invoice.Text
            '        ReportNotaPenjualan1.ReportParameters("banyak").Value = banyak
            '        Dim instanceReportSource1 As New Telerik.Reporting.InstanceReportSource()
            '        instanceReportSource1.ReportDocument = ReportNotaPenjualan1
            '        Dim reportproses As New Telerik.Reporting.Processing.ReportProcessor
            '        Dim printsetting As New System.Drawing.Printing.PrinterSettings
            '        Dim standardPrintController As New System.Drawing.Printing.StandardPrintController
            '        reportproses.PrintController = standardPrintController
            '        reportproses.PrintReport(instanceReportSource1, printsetting)
            '    End Using
            'Else
            '    Using CetakNotaPenjualan As New FormCetakNotaPenjualan
            '        CetakNotaPenjualan.ExtraOrdinary = False
            '        CetakNotaPenjualan.invoice = Label_Invoice.Text
            '        CetakNotaPenjualan.banyak = banyak
            '        CetakNotaPenjualan.Kota = KotaToko
            '        CetakNotaPenjualan.ShowDialog()
            '        CetakNotaPenjualan.Dispose()
            '    End Using
            'End If
            Using CetakNotaPenjualan As New FormCetakNotaPenjualan
                CetakNotaPenjualan.ExtraOrdinary = False
                CetakNotaPenjualan.invoice = Label_Invoice.Text
                CetakNotaPenjualan.banyak = BanyakBarisNota(rows)
                CetakNotaPenjualan.Kota = KotaToko
                CetakNotaPenjualan.ShowDialog()
                CetakNotaPenjualan.Dispose()
            End Using
        ElseIf tipe = TipePenjualan.SmallNota Then
            'If SettingPreferensi.Penjualan.AutoPrint = "AutoSmall" Then
            '    Using CetakNotaPenjualanSmall As New FormCetakNotaPenjualanSmall
            '        CetakNotaPenjualanSmall.invoice = Label_Invoice.Text
            '        CetakNotaPenjualanSmall.ShowDialog()
            '        CetakNotaPenjualanSmall.Dispose()
            '        'ReportNotaPenjualanSmall1.ReportParameters("invoice").Value = Label_Invoice.Text
            '        'Dim instanceReportSource1 As New Telerik.Reporting.InstanceReportSource()
            '        'instanceReportSource1.ReportDocument = ReportNotaPenjualanSmall1
            '        'Dim reportproses As New Telerik.Reporting.Processing.ReportProcessor
            '        'Dim printsetting As New System.Drawing.Printing.PrinterSettings
            '        'Dim standardPrintController As New System.Drawing.Printing.StandardPrintController
            '        'reportproses.PrintController = standardPrintController
            '        'reportproses.PrintReport(instanceReportSource1, printsetting)
            '    End Using
            'Else
            '    Using CetakNotaPenjualanSmall As New FormCetakNotaPenjualanSmall
            '        CetakNotaPenjualanSmall.invoice = Label_Invoice.Text
            '        CetakNotaPenjualanSmall.ShowDialog()
            '        CetakNotaPenjualanSmall.Dispose()
            '    End Using
            'End If
            Using CetakNotaPenjualanSmall As New FormCetakNotaPenjualanSmall
                CetakNotaPenjualanSmall.invoice = Label_Invoice.Text
                CetakNotaPenjualanSmall.ShowDialog()
                CetakNotaPenjualanSmall.Dispose()
            End Using
        Else
            If SettingPreferensi.Order.Nota = "Simple" Then
                Using FormCetakNotaOrderSimple As New FormCetakNotaOrderSimple
                    'CetakNotaOrder.ExtraOrdinary = False
                    FormCetakNotaOrderSimple.invoice = Label_Invoice.Text
                    FormCetakNotaOrderSimple.ShowDialog()
                    FormCetakNotaOrderSimple.Dispose()
                End Using
            Else
                Using CetakNotaOrder As New FormCetakNotaOrder
                    'CetakNotaOrder.ExtraOrdinary = False
                    CetakNotaOrder.invoice = Label_Invoice.Text
                    CetakNotaOrder.banyak = BanyakBarisNota(rows) + 1
                    CetakNotaOrder.ShowDialog()
                    CetakNotaOrder.Dispose()
                End Using
            End If
        End If
        CobaBersihkanMemori()
    End Sub

    Private Function cek_lebih_kuota(ByVal indeks As Integer) As Boolean
        If CInt(Grid_Penjualan.Rows(indeks).Cells("qtyDbGridViewTextBox").Value) > Tabel_barangTableAdapter.ScalarQueryStokBarang(CStr(Grid_Penjualan.Rows(indeks).Cells("kodeDbGridViewTextBox").Value)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function convert_kuota() As String
        Dim balik As String = "gk ada"
        Dim a(Grid_Penjualan.RowCount, 5) As String
        Dim counter As Integer = 0
        For i As Integer = 0 To Grid_Penjualan.RowCount - 1
            If cek_lebih_kuota(i) = True Then
                a(i, 0) = CStr(i)
                a(i, 1) = CStr(Grid_Penjualan.Rows(i).Cells("kodeDbGridViewTextBox").Value)
                a(i, 2) = CStr(Grid_Penjualan.Rows(i).Cells("namaDbGridViewTextBox").Value)
                a(i, 3) = CStr(Tabel_barangTableAdapter.ScalarQueryStokBarang(CStr(Grid_Penjualan.Rows(i).Cells("kodeDbGridViewTextBox").Value)))
                a(i, 4) = CStr(Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value)
                counter += 1
            End If
        Next
        If counter <> 0 Then
            Dim dialogperingatan As FormDialogPeringatanPenjualan = New FormDialogPeringatanPenjualan
            dialogperingatan.n = Grid_Penjualan.RowCount
            dialogperingatan.array = a
            Dim status_dialogresult As DialogResult = dialogperingatan.ShowDialog()
            If status_dialogresult = DialogResult.Cancel Then
                For i = Grid_Penjualan.RowCount - 1 To 0 Step -1
                    If a(i, 0) <> vbNullString Then
                        If Grid_Penjualan.Rows(i).Cells("kodeDbGridViewTextBox").Value.ToString = a(i, 1) Then
                            'Grid_Penjualan.BeginEdit(False)
                            Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value = Tabel_barangTableAdapter.ScalarQueryStokBarang(CStr(Grid_Penjualan.Rows(i).Cells("kodeDbGridViewTextBox").Value))
                            Grid_Penjualan.Rows(i).Cells("subtotalDbGridViewTextBox").Value = CInt(Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value) * CInt(Grid_Penjualan.Rows(i).Cells("hargaDbGridViewTextBox").Value)
                            If (CInt(Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value) <= 0) Then
                                'MessageBox.Show("Hapus " & i & " " & Grid_Penjualan.Item("qtyDbGridViewTextBox", i).Value)
                                Grid_Penjualan.Rows.RemoveAt(i)
                                'Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value = 0
                            End If
                            balik = "ada"
                            'Grid_Penjualan.EndEdit()
                        End If
                    End If
                Next

            ElseIf status_dialogresult = DialogResult.Abort Then
                Return "Abort"
            Else
                'skip
            End If
        End If
        Return balik
    End Function

    Private Function update_barang_penjualan(ByVal indeks As Integer) As Boolean
        Try
            If tipe <> TipePenjualan.Order Then
                Me.Tabel_barangTableAdapter.UpdateQueryStokJual(CInt(Grid_Penjualan.Rows(indeks).Cells("qtyDbGridViewTextBox").Value), CInt(Grid_Penjualan.Rows(indeks).Cells("qtyDbGridViewTextBox").Value), _
                                                        CInt(Grid_Penjualan.Rows(indeks).Cells("labaDBGrid").Value), CStr(Grid_Penjualan.Rows(indeks).Cells("kodeDbGridViewTextBox").Value))
            Else
                Me.Tabel_barangTableAdapter.UpdateQueryStokJual(CInt(Grid_Penjualan.Rows(indeks).Cells("qtyDbGridViewTextBox").Value), 0, _
                                                        CInt(Grid_Penjualan.Rows(indeks).Cells("labaDBGrid").Value), CStr(Grid_Penjualan.Rows(indeks).Cells("kodeDbGridViewTextBox").Value))
            End If

            If CInt(Tabel_barangTableAdapter.ScalarQueryStokNol(Grid_Penjualan.Rows(indeks).Cells("kodeDbGridViewTextBox").Value.ToString)) = 0 Then
                Me.Tabel_barangTableAdapter.UpdateQueryUnTerhapus(CStr(Grid_Penjualan.Rows(indeks).Cells("kodeDbGridViewTextBox").Value))
            End If
            Return True
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Penjualan-Update Barang Penjualan", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
            Return False
        End Try
    End Function

    Private Function update_barang_retur(ByVal indeks As Integer) As Boolean
        Try
            If tipe <> TipePenjualan.Order Then
                Me.Tabel_barangTableAdapter.UpdateQueryStokRetur(CInt(fr_retur.RadGridView1.Rows(indeks).Cells("qty").Value), CInt(fr_retur.RadGridView1.Rows(indeks).Cells("qty").Value), (0 - CInt(fr_retur.RadGridView1.Rows(indeks).Cells("labarugi").Value)), CStr(fr_retur.RadGridView1.Rows(indeks).Cells("id_barang").Value))
            Else
                Me.Tabel_barangTableAdapter.UpdateQueryStokRetur(CInt(fr_retur.RadGridView1.Rows(indeks).Cells("qty").Value), 0, (0 - CInt(fr_retur.RadGridView1.Rows(indeks).Cells("labarugi").Value)), CStr(fr_retur.RadGridView1.Rows(indeks).Cells("id_barang").Value))
            End If

            If Tabel_barangTableAdapter.ScalarQueryStokNol(CStr(fr_retur.RadGridView1.Rows(indeks).Cells("id_barang").Value)) = 0 Then
                Me.Tabel_barangTableAdapter.UpdateQueryUnTerhapus(CStr(fr_retur.RadGridView1.Rows(indeks).Cells("id_barang").Value))
            End If
            Return True
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Penjualan-Update Barang Retur", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
            Return False
        End Try
    End Function

    Private Function tambah_invoice() As Boolean
        Dim hutang As Double = 0
        If totalRp_hutangbaru_Label.Text = "LUNAS" Then
            hutang = 0
        Else
            hutang = totalRp_hutangbaru_Label.Text
        End If
        ' Try
        If tipe = TipePenjualan.SmallNota Then
            Me.Tabel_invoice_keluarTableAdapter.InsertQueryInvoiceKeluar(Label_Invoice.Text, _
                                                                         id_customer_TextBox.Text, _
                                                                         nama_sales_ComboBox.Text, _
                                                                         tipe_penjualan, _
                                                                         CDbl(ubahAwalbeforeDiv(totalRp_jual_Label.Text)), _
                                                                         CInt(Total_Stok_Label.Text), _
                                                                         CDbl(ubahAwalbeforeDiv(totalRp_retur_Label.Text)), _
                                                                         CInt(stok_retur_Label.Text), _
                                                                         CDbl(ubahAwalbeforeDiv(bayar_TextBox.Text)), _
                                                                         CDbl(ubahAwalbeforeDiv(profit_label.Text)), _
                                                                         CDbl(ubahAwalbeforeDiv(rugi_label.Text)), _
                                                                         CDbl(ubahAwalbeforeDiv(totalRp_HutangLama_Label.Text)), _
                                                                         ubahAwalbeforeDiv(hutang), _
                                                                         CDbl(ubahAwalbeforeDiv(totalRp_diskon_Label.Text)), _
                                                                         1)
        Else
            Me.Tabel_invoice_keluarTableAdapter.InsertQueryInvoiceKeluar(Label_Invoice.Text, _
                                                                         id_customer_TextBox.Text, _
                                                                         nama_sales_ComboBox.Text, _
                                                                         tipe_penjualan, _
                                                                         CDbl(ubahAwalbeforeDiv(totalRp_jual_Label.Text)), _
                                                                         CInt(Total_Stok_Label.Text), _
                                                                         CDbl(ubahAwalbeforeDiv(totalRp_retur_Label.Text)), _
                                                                         CInt(stok_retur_Label.Text), _
                                                                         CDbl(ubahAwalbeforeDiv(bayar_TextBox.Text)), _
                                                                         CDbl(ubahAwalbeforeDiv(profit_label.Text)), _
                                                                         CDbl(ubahAwalbeforeDiv(rugi_label.Text)), _
                                                                         CDbl(ubahAwalbeforeDiv(totalRp_HutangLama_Label.Text)), _
                                                                         ubahAwalbeforeDiv(hutang), _
                                                                         CDbl(ubahAwalbeforeDiv(totalRp_diskon_Label.Text)), _
                                                                         0)
        End If
        Return True
        'Catch ex As Exception
        '  Telerik.WinControls.RadMessageBox.Show(ex.Message, "Penjualan-Tambah Invoice", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        '  Return False
        ' End Try
    End Function

    Private Function tambah_retur(ByVal indeks As Integer) As Boolean
        Try
            Me.Tabel_barang_returTableAdapter.InsertQuery(CStr(fr_retur.RadGridView1.Rows(indeks).Cells("id_barang").Value), CInt(fr_retur.RadGridView1.Rows(indeks).Cells("qty").Value), Label_Invoice.Text, CInt(fr_retur.RadGridView1.Rows(indeks).Cells("harga_jual").Value), (0 - CInt(fr_retur.RadGridView1.Rows(indeks).Cells("labarugi").Value)))
            Return True
        Catch ex As Exception
            Return False
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Penjualan-Tambah Retur", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        End Try
    End Function

    Private Function tambah_barang_keluar(ByVal indeks As Integer) As Boolean
        Try
            If tipe = TipePenjualan.Order Then
                Me.Tabel_barang_keluarTableAdapter.InsertQueryBarangKeluar(CStr(Grid_Penjualan.Rows(indeks).Cells("kodeDbGridViewTextBox").Value), CInt(Grid_Penjualan.Rows(indeks).Cells("qtyDbGridViewTextBox").Value), Label_Invoice.Text, CInt(Grid_Penjualan.Rows(indeks).Cells("harga_negoDbGridViewTextBox").Value), CInt(Grid_Penjualan.Rows(indeks).Cells("labaDBGrid").Value), CInt(Grid_Penjualan.Rows(indeks).Cells("diskonDbGridViewTextBox").Value), "Y")
            Else
                Me.Tabel_barang_keluarTableAdapter.InsertQueryBarangKeluar(CStr(Grid_Penjualan.Rows(indeks).Cells("kodeDbGridViewTextBox").Value), CInt(Grid_Penjualan.Rows(indeks).Cells("qtyDbGridViewTextBox").Value), Label_Invoice.Text, CInt(Grid_Penjualan.Rows(indeks).Cells("harga_negoDbGridViewTextBox").Value), CInt(Grid_Penjualan.Rows(indeks).Cells("labaDBGrid").Value), CInt(Grid_Penjualan.Rows(indeks).Cells("diskonDbGridViewTextBox").Value), "N")
            End If
            Return True
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Penjualan-Tambah Barang Keluar", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
            Return False
        End Try
    End Function

    Private Function update_hutang() As Boolean
        Dim hutang As Double = 0
        If totalRp_hutangbaru_Label.Text = "LUNAS" Then
            hutang = 0
        Else
            hutang = CDbl(ubahAwalbeforeDiv(totalRp_hutangbaru_Label.Text))
        End If
        Try
            Me.Tabel_customerTableAdapter.UpdateQueryHutang(hutang, id_customer_TextBox.Text)
            Return True
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Penjualan-Update Hutang", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
            Return False
        End Try
    End Function

    Private Function tipe_penjualan() As String
        If RadioGrosir.IsChecked = True Then
            Return "Grosir"
        Else
            If tipe = TipePenjualan.Order Then
                Return "Order Barang"
            Else
                Return "Retail"
            End If
        End If
    End Function

    Dim load_complete As Boolean = False
    Dim fr_retur As FormReturPenjualan

    Private Sub UC_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim GridViewComboBoxColumn1 As Telerik.WinControls.UI.GridViewComboBoxColumn = New Telerik.WinControls.UI.GridViewComboBoxColumn
            GridViewComboBoxColumn1.DataSource = New String() {"0", SettingPreferensi.Penjualan.Diskon1, SettingPreferensi.Penjualan.Diskon2, SettingPreferensi.Penjualan.Diskon3, SettingPreferensi.Penjualan.Diskon4}
            GridViewComboBoxColumn1.EnableExpressionEditor = False
            GridViewComboBoxColumn1.FilteringMode = Telerik.WinControls.UI.GridViewFilteringMode.DisplayMember
            GridViewComboBoxColumn1.FormatString = "{0} %"
            GridViewComboBoxColumn1.HeaderText = "%"
            GridViewComboBoxColumn1.Name = "persent"
            GridViewComboBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
            GridViewComboBoxColumn1.Width = 43
            Grid_Penjualan.Columns.Add(GridViewComboBoxColumn1)

            Label_Invoice.Text = cekInvoice()
            increase_temp(Label_Invoice.Text)
            pilih_tipe_penjualan()
            If tipe = TipePenjualan.BigNota Or tipe = TipePenjualan.SmallNota Then
                Panel2.Visible = False
                If RadioGrosir.IsChecked = True Then
                    Grid_Penjualan.Columns("harga_grosir_tertampil").IsVisible = False
                    Grid_Penjualan.Columns("harga_retail_tertampil").IsVisible = False
                End If
            ElseIf tipe = TipePenjualan.Order Then
                Panel2.Visible = False
                Label2.Text = "(O)"
                RadioGrosir.Visible = False
                Label20.Visible = False
                TableLayoutPanel_Normal.Visible = False
                TableLayoutPanel_Order.Location = New System.Drawing.Point(741, 159)
                TableLayoutPanel_Order.Visible = True
                Grid_Penjualan.Columns("hargamodalDBGridview").IsVisible = True
                Grid_Penjualan.Columns("harga_grosirDBGridView").IsVisible = True
                Grid_Penjualan.Columns("diskonDbGridViewTextBox").IsVisible = False
                Grid_Penjualan.Columns("persent").IsVisible = False
                Grid_Penjualan.Columns("harga_grosir_tertampil").IsVisible = False
                Grid_Penjualan.Columns("harga_retail_tertampil").IsVisible = False
                Grid_Penjualan.Columns("hargaDbGridViewTextBox").HeaderText = "Harga Retail"
                Grid_Penjualan.Columns.Move(7, 5)
                Me.Grid_Penjualan.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
            End If
            Me.load_complete = True
            fr_retur = New FormReturPenjualan
            Dim idFd As FilterDescriptor = New FilterDescriptor("id_customer", FilterOperator.Contains, Nothing)
            Me.id_customer_TextBox.MultiColumnComboBoxElement.EditorControl.FilterDescriptors.Add(idFd)
            Dim namaFd As FilterDescriptor = New FilterDescriptor("nama_customer", FilterOperator.Contains, Nothing)
            Me.id_customer_TextBox.MultiColumnComboBoxElement.EditorControl.FilterDescriptors.Add(namaFd)
            Me.id_customer_TextBox.MultiColumnComboBoxElement.EditorControl.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or
            If SettingAuthority.PenjualanAndBarangMasuk.TipePenjualanGrosir = False Then
                RadioGrosir.Enabled = False
                Label20.Enabled = False
            End If
            If SettingAuthority.PenjualanAndBarangMasuk.TipePenjualanRetail = False Then
                If tipe <> TipePenjualan.Order Then
                    RadiorRetail.Enabled = False
                    Label2.Enabled = False
                End If
            End If
            If SettingAuthority.PenjualanAndBarangMasuk.DiskonPenjualan = False Then
                Grid_Penjualan.Columns("diskonDbGridViewTextBox").ReadOnly = True
                Grid_Penjualan.Columns("hargaDbGridViewTextBox").ReadOnly = True
                Grid_Penjualan.Columns("persent").ReadOnly = True
                HRetail_TextBox.Enabled = False
            End If
            If tipe = TipePenjualan.Order Then
                id_customer_TextBox.Text = SettingPreferensi.Order.IDCustomer
                nama_sales_ComboBox.Text = SettingPreferensi.Order.Sales
            Else
                id_customer_TextBox.Text = SettingPreferensi.Penjualan.IDCustomer
                nama_sales_ComboBox.Text = SettingPreferensi.Penjualan.Sales
            End If
            RadPanel1.Focus()
            RadiorRetail.IsChecked = True
            ID_Barang_TextBox.Focus()
    End Sub

    Private Function cekInvoice() As String
        Dim z As String = ""
        If tipe = TipePenjualan.Order Then
            z = "OB"
        Else
            z = "PN"
        End If
        Dim cki As String = Tabel_temp_keluarTableAdapter.cekMaxInvoice(z & "-" & tglNiHari_YMD & "%")
        If cki Is vbNullString Then
            If tipe = TipePenjualan.Order Then
                Return "OB-" & tglNiHari_YMD & "-0001"
            Else
                Return "PN-" & tglNiHari_YMD & "-0001"
            End If
        Else
            If tipe = TipePenjualan.Order Then
                cki = cki.Replace("OB", "")
                cki = cki.Replace("-", "")
                Dim i As Integer = CType(cki, Integer) + 1
                Dim c As String = i.ToString.Insert(0, "OB-")
                Return c.Insert(9, "-")
            Else
                cki = cki.Replace("PN", "")
                cki = cki.Replace("-", "")
                Dim i As Integer = CType(cki, Integer) + 1
                Dim c As String = i.ToString.Insert(0, "PN-")
                Return c.Insert(9, "-")
            End If
        End If
    End Function

    Private Sub increase_temp(ByVal invoice As String)
        Try
            Tabel_temp_keluarTableAdapter.IncreaseTemp(invoice)
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Penjualan", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub pilih_tipe_penjualan()
        If RadiorRetail.IsChecked = True Then
            HGrosir_TextBox.Enabled = False
            HRetail_TextBox.Enabled = True
            If tipe = TipePenjualan.Order Then
                label_tipepenjualan.Text = "Order Barang"
            Else
                label_tipepenjualan.Text = "Retail"
            End If
        ElseIf RadioGrosir.IsChecked = True Then
            HGrosir_TextBox.Enabled = True
            HRetail_TextBox.Enabled = False
            label_tipepenjualan.Text = "Grosir"
        End If
    End Sub

    Dim F6_F7 As Boolean = False
    Private Sub ID_Barang_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ID_Barang_TextBox.KeyDown
        If e.KeyCode = Keys.F12 Then
            id_customer_TextBox.MultiColumnComboBoxElement.ClosePopup()
        End If
        If e.KeyCode = Keys.F2 Then
            Using DialogCariBarangPenjualan As New FormDialogCariBarangPenjualan
                If RadiorRetail.IsChecked = True Then
                    DialogCariBarangPenjualan.status = Label2.Text
                Else
                    DialogCariBarangPenjualan.status = Label20.Text
                End If
                DialogCariBarangPenjualan.ShowDialog()
                ID_Barang_TextBox.Text = DialogCariBarangPenjualan.id_barang.ToString
                DialogCariBarangPenjualan.Dispose()
                CobaBersihkanMemori()
            End Using
        ElseIf e.KeyCode = Keys.F6 Then
            If Grid_Penjualan.Rows.Count <> 0 Then
                F6_F7 = True
                Grid_Penjualan.CurrentRow = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1)
                Grid_Penjualan.CurrentColumn = Grid_Penjualan.Columns(3)
                edit_cell()
            End If
        ElseIf e.KeyCode = Keys.F7 And RadioGrosir.IsChecked = False Then
            If Grid_Penjualan.Rows.Count <> 0 Then
                F6_F7 = True
                Grid_Penjualan.CurrentRow = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1)
                Grid_Penjualan.CurrentColumn = Grid_Penjualan.Columns(8)
                edit_cell()
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            If Grid_Penjualan.Rows.Count <> 0 Then
                Grid_Penjualan.CurrentRow = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1)
                Grid_Penjualan.CurrentColumn = Grid_Penjualan.Columns(6)
                edit_cell()
            End If
        End If

        If tipe = TipePenjualan.BigNota Or tipe = TipePenjualan.SmallNota Then
            If e.KeyCode = Keys.Enter And adadidb = True Then
                addtotablepenjualan()
                hitung_total()
                RadiorRetail.Enabled = False
                RadioGrosir.Enabled = False
                id_customer_TextBox.Enabled = False
                nama_sales_ComboBox.Enabled = False
            End If
        ElseIf tipe = TipePenjualan.Order Then
            If e.KeyCode = Keys.Enter And adadidb = True Then
                addtotablepenjualan()
                hitung_total()
                RadiorRetail.Enabled = False
                RadioGrosir.Enabled = False
                id_customer_TextBox.Enabled = False
                nama_sales_ComboBox.Enabled = False
            End If
        End If
    End Sub

    Dim db_stok As Integer = 0
    Dim db_h_retail As Double = 0
    Dim harga_modal As Double = 0
    Private Sub ID_Barang_TextBox_TextChanged(sender As Object, e As EventArgs) Handles ID_Barang_TextBox.TextChanged
        If ID_Barang_TextBox.Text = "   -      " Then
            HRetail_TextBox.Enabled = False
            Quantity_TextBox.Enabled = False
        Else
            HRetail_TextBox.Enabled = True
            Quantity_TextBox.Enabled = True
        End If
        Using dt As DataTable = Me.Tabel_barangTableAdapter.GetDataByKodeBarang(ID_Barang_TextBox.Text)
            If dt.Rows.Count <> 0 Then
                NamaBrg_TextBox.Text = CStr(dt.Rows(0).Item("nama_barang"))
                Me.db_stok = CInt(dt.Rows(0).Item("stok_barang"))
                Me.db_h_retail = CDbl(dt.Rows(0).Item("harga_retail"))
                Me.harga_modal = CDbl(dt.Rows(0).Item("harga_modal"))
                HGrosir_TextBox.Text = ubahtocurrency(CStr(dt.Rows(0).Item("harga_grosir")))
                HRetail_TextBox.Text = ubahtocurrency(CStr(db_h_retail))
                'If tipe <> "Small Nota" Then
                '    Quantity_TextBox.Text = "1"
                'Else
                '    Quantity_TextBox.Text = "0"
                'End If
                st_hretail = True
                Button_Tambah.Enabled = True
                Quantity_TextBox.Enabled = True
                'HRetail_TextBox.Enabled = True
                HGrosir_TextBox.Enabled = True
                adadidb = True

                If cek_di_table(CStr(dt.Rows(0).Item("kode_barang"))) <> "nothing" Then
                    RadioGrosir.Enabled = False
                    RadiorRetail.Enabled = False
                    HRetail_TextBox.Enabled = False
                    HGrosir_TextBox.Enabled = False
                    Quantity_TextBox.Focus()
                Else
                    If RadiorRetail.IsChecked = True Then
                        HRetail_TextBox.Enabled = True
                        HGrosir_TextBox.Enabled = False
                        HRetail_TextBox.Focus()
                    Else
                        HGrosir_TextBox.Enabled = True
                        HRetail_TextBox.Enabled = False
                        Quantity_TextBox.Focus()
                    End If
                End If

            Else
                NamaBrg_TextBox.Text = ""
                HGrosir_TextBox.Text = "0"
                HRetail_TextBox.Text = "0"
                Me.db_stok = CInt("0")
                'Me.db_h_retail = "0"
                Button_Tambah.Enabled = False
                Quantity_TextBox.Enabled = False
                HRetail_TextBox.Enabled = False
                HGrosir_TextBox.Enabled = False
                adadidb = False
            End If
        End Using
    End Sub

    Dim st_hretail As Boolean = False
    Private Sub HRetail_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Quantity_TextBox.KeyPress, HRetail_TextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub bayar_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bayar_TextBox.KeyPress
        If (Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or _
            (e.KeyChar = ","c And Not bayar_TextBox.Text.Contains(",") And bayar_TextBox.SelectionStart > 0) Or _
            (e.KeyChar = "-"c And Not bayar_TextBox.Text.Contains("-") And bayar_TextBox.SelectionStart = 0)) And _
            DivKoefisien = DivCoef._1 Then
            e.Handled = False
        ElseIf (Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or _
            (e.KeyChar = "-"c And Not bayar_TextBox.Text.Contains("-") And bayar_TextBox.SelectionStart = 0)) And _
        DivKoefisien = DivCoef._1000 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub bayar_TextBox_order_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles bayar_TextBox_order.KeyPress
        If (Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or _
            (e.KeyChar = ","c And Not bayar_TextBox_order.Text.Contains(",") And bayar_TextBox_order.SelectionStart > 0) Or _
            (e.KeyChar = "-"c And Not bayar_TextBox_order.Text.Contains("-") And bayar_TextBox_order.SelectionStart = 0)) And _
            DivKoefisien = DivCoef._1 Then
        ElseIf (Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or _
            (e.KeyChar = "-"c And Not bayar_TextBox_order.Text.Contains("-") And bayar_TextBox_order.SelectionStart = 0)) And _
            DivKoefisien = DivCoef._1000 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Quantity_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Quantity_TextBox.TextChanged, HRetail_TextBox.TextChanged
        Dim qty, harga As Double
        If Quantity_TextBox.Text = "" Then
            qty = 0
            Me.Quantity_TextBox.Text = CStr(qty)
        Else
            qty = CDbl(Quantity_TextBox.Text)
        End If
        If RadioGrosir.IsChecked = True Then
            If HGrosir_TextBox.Text = "" Then
                harga = 0
            Else
                harga = CDbl(HGrosir_TextBox.Text)
            End If
            SubTotal_TextBox.Text = CStr(qty * harga)
        ElseIf RadiorRetail.IsChecked = True Then
            If HRetail_TextBox.Text = "" Then
                harga = 0
                Me.HRetail_TextBox.Text = CStr(harga)
            Else
                harga = CDbl(HRetail_TextBox.Text.Replace(".", ""))
            End If
            SubTotal_TextBox.Text = ubahtocurrencybyDiv(CStr(qty * harga))
        End If
    End Sub

    Private Sub HRetail_TextBox_Leave(sender As Object, e As EventArgs) Handles HRetail_TextBox.Leave
        If st_hretail = True Then
            If HRetail_TextBox.Text <> "" Then
                If CDbl(HRetail_TextBox.Text) < CDbl(HGrosir_TextBox.Text) Then
                    Telerik.WinControls.RadMessageBox.Show("Tidak boleh lebih kecil dari harga grosir. Harga minimum yang diperbolehkan adalah Rp " & HGrosir_TextBox.Text, "Harga Retail", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                    HRetail_TextBox.Text = CStr(db_h_retail)
                    HRetail_TextBox.Focus()
                    HRetail_TextBox.SelectAll()
                ElseIf CDbl(HRetail_TextBox.Text) > db_h_retail Then
                    Telerik.WinControls.RadMessageBox.Show("Tidak boleh lebih besar dari harga retail pada database. Harga maksimum yang diperbolehkan adalah Rp " & db_h_retail, "Harga Retail", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                    HRetail_TextBox.Text = CStr(db_h_retail)
                    HRetail_TextBox.Focus()
                    HRetail_TextBox.SelectAll()
                End If
            Else
                HRetail_TextBox.Focus()
                HRetail_TextBox.Text = "0"
            End If
        End If
    End Sub

    Private Sub Button_Tambah_Click(sender As Object, e As EventArgs) Handles Button_Tambah.Click
        addtotablepenjualan()
        hitung_total()
        RadiorRetail.Enabled = False
        RadioGrosir.Enabled = False
        id_customer_TextBox.Enabled = False
        nama_sales_ComboBox.Enabled = False
    End Sub

    Private Sub addtotablepenjualan()
        If (Quantity_TextBox.Text <> "0") Then
            Dim cek As String = ""
            Dim harga, harga_db, profit As Double
            Dim AutoDiskonPersen As Integer = 0
            If RadioGrosir.IsChecked = True Then
                harga = CInt(HGrosir_TextBox.Text)
                harga_db = harga
            ElseIf RadiorRetail.IsChecked = True Then
                If tipe <> TipePenjualan.Order Then
                    If SettingPreferensi.Penjualan.IsAutoDiskon = True Then
                        AutoDiskonPersen = SettingPreferensi.Penjualan.AutoDiskon
                        harga_db = db_h_retail
                        Dim diskonmaks As Double = Math.Round(((harga_db - CInt(HGrosir_TextBox.Text)) / harga_db) * 100, 1)
                        If AutoDiskonPersen > diskonmaks Then
                            harga = harga_db - (harga_db * (diskonmaks / 100))
                            'AutoDiskonValue = (harga_db * (diskonmaks / 100))
                            AutoDiskonPersen = diskonmaks
                        Else
                            harga = harga_db - (harga_db * AutoDiskonPersen / 100)
                            'AutoDiskonValue = (harga_db * AutoDiskonPersen / 100)
                        End If
                    Else
                        harga = CInt(HRetail_TextBox.Text)
                        harga_db = db_h_retail
                    End If
                Else
                    harga = harga_modal
                    'harga_db = harga_modal
                    harga_db = db_h_retail
                End If
            End If
            profit = (harga - harga_modal) * CInt(Quantity_TextBox.Text)
            cek = cek_di_table(ID_Barang_TextBox.Text)
            If cek_di_table(ID_Barang_TextBox.Text) = "nothing" Then
                If tipe = TipePenjualan.Order Then
                    Grid_Penjualan.Rows.Add("",
                                        ID_Barang_TextBox.Text, _
                                        NamaBrg_TextBox.Text, _
                                        CInt(Quantity_TextBox.Text), _
                                        harga_modal, _
                                        CDbl(Quantity_TextBox.Text) * harga, _
                                        CInt(HGrosir_TextBox.Text),
                                        harga_db, _
                                        (harga_db - harga), _
                                        harga, _
                                        profit, _
                                        CInt(HGrosir_TextBox.Text), _
                                        enkripsi_simple(CInt(HGrosir_TextBox.Text)), _
                                        harga_db, _
                                        AutoDiskonPersen)
                Else
                    Grid_Penjualan.Rows.Add("",
                                        ID_Barang_TextBox.Text, _
                                        NamaBrg_TextBox.Text, _
                                        CInt(Quantity_TextBox.Text), _
                                        harga_modal, _
                                        CInt(HGrosir_TextBox.Text),
                                        harga, _
                                        CDbl(Quantity_TextBox.Text) * harga, _
                                        (harga_db - harga), _
                                        harga, _
                                        profit, _
                                        harga_db, _
                                        enkripsi_simple(CInt(HGrosir_TextBox.Text)), _
                                        harga_db, _
                                        AutoDiskonPersen)
                End If
                RecentAct_Label_No.Text = "No." & Grid_Penjualan.Rows.Count.ToString
                RecentAct_Label_KodeBrg.Text = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1).Cells("kodeDbGridViewTextBox").Value.ToString
                RecentAct_Label_NamaBrg.Text = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1).Cells("namaDbGridViewTextBox").Value.ToString
                RecentAct_Label_Qty.Text = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1).Cells("qtyDbGridViewTextBox").Value.ToString
                RecentAct_Label_Cross.Text = "X"
                RecentAct_Label_Refresh.Text = "Refresh"
                If tipe = TipePenjualan.Order Then
                    RecentAct_Label_Harga.Text = ubahtocurrencybyDiv(Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1).Cells("hargamodalDBGridview").Value.ToString)
                Else
                    RecentAct_Label_Harga.Text = ubahtocurrencybyDiv(Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1).Cells("hargaDbGridViewTextBox").Value.ToString)
                End If
            Else
                Grid_Penjualan.Rows(CInt(cek)).Cells("qtyDbGridViewTextBox").Value = CInt(Grid_Penjualan.Rows(CInt(cek)).Cells("qtyDbGridViewTextBox").Value) + CInt(Quantity_TextBox.Text)
                If tipe <> TipePenjualan.Order Then
                    Grid_Penjualan.Rows(CInt(cek)).Cells("subtotalDbGridViewTextBox").Value = CInt(Grid_Penjualan.Rows(CInt(cek)).Cells("qtyDbGridViewTextBox").Value) * CInt(Grid_Penjualan.Rows(CInt(cek)).Cells("hargaDbGridViewTextBox").Value)
                Else
                    Grid_Penjualan.Rows(CInt(cek)).Cells("subtotalDbGridViewTextBox").Value = CInt(Grid_Penjualan.Rows(CInt(cek)).Cells("qtyDbGridViewTextBox").Value) * CInt(Grid_Penjualan.Rows(CInt(cek)).Cells("hargamodalDBGridview").Value)
                End If
                Grid_Penjualan.Rows(CInt(cek)).Cells("labaDBGrid").Value = (CInt(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("harga_negoDbGridViewTextBox").Value) - (CInt(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("hargamodalDBGridview").Value))) * CInt(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("qtyDbGridViewTextBox").Value)

                RecentAct_Label_No.Text = "No." & CInt(cek) + 1
                RecentAct_Label_KodeBrg.Text = Grid_Penjualan.Rows(CInt(cek)).Cells("kodeDbGridViewTextBox").Value.ToString
                RecentAct_Label_NamaBrg.Text = Grid_Penjualan.Rows(CInt(cek)).Cells("namaDbGridViewTextBox").Value.ToString
                RecentAct_Label_Qty.Text = Grid_Penjualan.Rows(CInt(cek)).Cells("qtyDbGridViewTextBox").Value.ToString
                RecentAct_Label_Cross.Text = "X"
                RecentAct_Label_Refresh.Text = "Refresh"
                If tipe = TipePenjualan.Order Then
                    RecentAct_Label_Harga.Text = ubahtocurrencybyDiv(Grid_Penjualan.Rows(CInt(cek)).Cells("hargamodalDBGridview").Value.ToString)
                Else
                    RecentAct_Label_Harga.Text = ubahtocurrencybyDiv(Grid_Penjualan.Rows(CInt(cek)).Cells("hargaDbGridViewTextBox").Value.ToString)
                End If
            End If

            ID_Barang_TextBox.Text = "   -      "
            Quantity_TextBox.Text = "1"
            SubTotal_TextBox.Text = "0"
            Button_Tambah.Enabled = False
            ID_Barang_TextBox.Focus()
            ID_Barang_TextBox.SelectionLength = 0
        Else
            Telerik.WinControls.RadMessageBox.Show("Tidak boleh nol.", "Quantity", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            Quantity_TextBox.Focus()
        End If
    End Sub

    Private Function cek_di_table(ByVal cek As String) As String
        If Grid_Penjualan.Rows.Count <> 0 Then
            For i = 0 To Grid_Penjualan.Rows.Count - 1
                If Grid_Penjualan.Rows(i).Cells("kodeDbGridViewTextBox").Value.ToString = cek Then
                    Return CStr(i)
                End If
            Next
        End If
        Return "nothing"
    End Function

    Private Sub Grid_Penjualan_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 0 Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub id_sales_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles nama_sales_ComboBox.SelectedIndexChanged
        If Me.load_complete = True Then
            If (RadiorRetail.IsChecked = True Or RadioGrosir.IsChecked = True) And nama_sales_ComboBox.Text <> "< Pilih Sales >" And id_customer_TextBox.Text <> "< Pilih Customer >" Then
                Panel1.Enabled = True
                TableLayoutPanel_Normal.Enabled = True
                TableLayoutPanel_Order.Enabled = True
                ID_Barang_TextBox.Focus()
                ID_Barang_TextBox.SelectionLength = 0
            End If
        End If
    End Sub

    Private Sub bayar_TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles bayar_TextBox.TextChanged
        hitung_bayar()
    End Sub

    Private Sub hitung_bayar()
        Dim jumlah As Double = 0
        If bayar_TextBox.Text = "-" Then
            Exit Sub
        End If
        If tipe <> TipePenjualan.Order Then
            If bayar_TextBox.Text <> "" Then
                Button_Yes.Enabled = True
                jumlah = CDbl(ubahAwalbeforeDiv(bayar_TextBox.Text)) - CDbl(ubahAwalbeforeDiv(totalRp_all_Label.Text))
                If jumlah < 0 Then
                    Label11.Text = "Hutang Baru"
                    Label19.Text = ": Rp"
                    totalRp_hutangbaru_Label.Text = ubahtocurrencybyDiv((0 - jumlah).ToString)
                ElseIf jumlah > 0 Then
                    Label11.Text = "Hutang Baru"
                    Label19.Text = ": Rp"
                    totalRp_hutangbaru_Label.Text = ubahtocurrencybyDiv((0 - jumlah).ToString)
                Else
                    Label11.Text = ""
                    Label19.Text = ""
                    totalRp_hutangbaru_Label.Text = "LUNAS"
                End If
            Else
                Button_Yes.Enabled = False
            End If
        Else
            If bayar_TextBox_order.Text <> "" Then
                Button_Yes.Enabled = True
                jumlah = CDbl(ubahAwalbeforeDiv(bayar_TextBox_order.Text)) - CDbl(ubahAwalbeforeDiv(totalRp_all_Label_order.Text))
                If jumlah < 0 Then
                    Label11_order.Text = "Hutang Baru"
                    Label19_order.Text = ": Rp"
                    totalRp_hutangbaru_Label_order.Text = ubahtocurrencybyDiv((0 - jumlah).ToString)
                    totalRp_hutangbaru_Label.Text = ubahtocurrencybyDiv((0 - jumlah).ToString)
                ElseIf jumlah > 0 Then
                    Label11_order.Text = "Hutang Baru"
                    Label19_order.Text = ": Rp"
                    totalRp_hutangbaru_Label_order.Text = ubahtocurrencybyDiv((0 - jumlah).ToString)
                    totalRp_hutangbaru_Label.Text = ubahtocurrencybyDiv((0 - jumlah).ToString)
                Else
                    Label11_order.Text = ""
                    Label19_order.Text = ""
                    totalRp_hutangbaru_Label_order.Text = "LUNAS"
                    totalRp_hutangbaru_Label.Text = "LUNAS"
                End If
            Else
                Button_Yes.Enabled = False
            End If
        End If
        If SettingAuthority.PenjualanAndBarangMasuk.HutangCustomer = False Then
            Dim hutangbaru As Integer = 0
            If totalRp_hutangbaru_Label.Text <> "LUNAS" Then
                hutangbaru = CInt(ubahAwalbeforeDiv(totalRp_hutangbaru_Label.Text))
            End If
            If hutangbaru > 0 Then
                Button_Yes.Enabled = False
            ElseIf hutangbaru <= 0 Then
                'Button_Yes.Enabled = True
            End If
        Else
            'Button_Yes.Enabled = True
        End If
    End Sub

    Friend Sub hitung_total()
        Dim total_harga As Double = 0
        Dim diskon As Double = 0
        Dim total_stok As Integer = 0
        Dim profit As Double = 0
        Dim rugi As Double = 0
        For i As Integer = 0 To Grid_Penjualan.RowCount - 1
            If tipe <> TipePenjualan.Order Then
                diskon = diskon + (CDbl(Grid_Penjualan.Rows(i).Cells("diskonDbGridViewTextBox").Value) * CDbl(Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value))
                total_harga = total_harga + (CDbl(Grid_Penjualan.Rows(i).Cells("harga_retail_tertampil").Value) * CDbl(Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value))
            Else
                total_harga = total_harga + (CDbl(Grid_Penjualan.Rows(i).Cells("hargamodalDBGridview").Value) * CDbl(Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value))
            End If
            total_stok = total_stok + CInt(Grid_Penjualan.Rows(i).Cells("qtyDbGridViewTextBox").Value)
            profit = profit + CDbl(Grid_Penjualan.Rows(i).Cells("labaDBGrid").Value)
        Next
        For i = 0 To fr_retur.RadGridView1.Rows.Count - 1
            rugi = rugi + (0 - CDbl(fr_retur.RadGridView1.Rows(i).Cells("labarugi").Value))
        Next
        totalRp_harga_Label.Text = ubahtocurrencybyDiv(CStr(total_harga))
        totalRp_harga_Label_order.Text = ubahtocurrencybyDiv(CStr(total_harga))
        totalRp_diskon_Label.Text = ubahtocurrencybyDiv(CStr(diskon))

        totalRp_jual_Label.Text = ubahtocurrencybyDiv(CStr(total_harga) - diskon)
        Total_Stok_Label.Text = FormatNumber(CStr(total_stok), 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)

        If tipe = TipePenjualan.Order Then
            totalRp_all_Label.Text = ubahtocurrency(CStr(CDbl(totalRp_jual_Label.Text) + CDbl(totalRp_HutangLama_Label.Text) - CDbl(totalRp_retur_Label_order.Text)))
            totalRp_all_Label_order.Text = ubahtocurrency(CStr(CDbl(totalRp_jual_Label.Text) + CDbl(totalRp_HutangLama_Label.Text) - CDbl(totalRp_retur_Label_order.Text)))
        Else
            totalRp_all_Label.Text = ubahtocurrency(CStr(CDbl(totalRp_jual_Label.Text) + CDbl(totalRp_HutangLama_Label.Text) - CDbl(totalRp_retur_Label.Text)))
            'total_all_Label_order.Text = ubahtocurrency(CDbl(total_jual_Label.Text) + CDbl(HutangLama_Label.Text) - CDbl(retur_Label.Text))
        End If

        profit_label.Text = ubahtocurrencybyDiv(profit)
        rugi_label.Text = ubahAwalbeforeDiv(rugi)
        hitung_bayar()
    End Sub

    Private Sub proced_retur()
        If RadioGrosir.IsChecked Then
            fr_retur.status = Label20.Text
        ElseIf RadiorRetail.IsChecked Then
            fr_retur.status = Label2.Text
        End If
        fr_retur.st_penjualan = tipe
        fr_retur.Invoice = Label_Invoice.Text
        fr_retur.ID_Customer = id_customer_TextBox.Text
        fr_retur.Nama_Customer = nama_customer_Label.Text
        fr_retur.Sales = nama_sales_ComboBox.Text
        fr_retur.ShowDialog()
        If fr_retur.RadGridView1.Rows.Count > 0 Then
            RadiorRetail.Enabled = False
            RadioGrosir.Enabled = False
            id_customer_TextBox.Enabled = False
            nama_sales_ComboBox.Enabled = False
        End If
        totalRp_retur_Label.Text = ubahtocurrencybyDiv(fr_retur.total_subtotal)
        totalRp_retur_Label_order.Text = ubahtocurrencybyDiv(fr_retur.total_subtotal)
        stok_retur_Label.Text = fr_retur.stok_retur
        hitung_total()
    End Sub

    Private Sub Button_Retur_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_Retur.Click
        If SettingAuthority.PenjualanAndBarangMasuk.ReturPenjualan = True Then
            proced_retur()
        Else
            FormDialogPassword.tipe = FormDialogPassword.tipekonfirmasi.ReturPenjualan
            If FormDialogPassword.ShowDialog() = DialogResult.Yes Then
                proced_retur()
            End If
        End If
    End Sub

    Private Sub HRetail_TextBox_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles HRetail_TextBox.KeyUp
        If Char.IsNumber(ChrW(e.KeyValue)) = True Or e.KeyCode = Keys.Back Then
            If HRetail_TextBox.Text <> "" Then
                HRetail_TextBox.Text = HRetail_TextBox.Text.Replace(".", "")
                HRetail_TextBox.Text = FormatNumber(HRetail_TextBox.Text, 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
                HRetail_TextBox.Select(HRetail_TextBox.Text.Length, 0)
            End If
        End If
    End Sub

    Private Sub HGrosir_TextBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Quantity_TextBox.KeyDown, Button_Tambah.KeyDown
        If e.KeyCode = Keys.Enter Then
            addtotablepenjualan()
            hitung_total()
            RadiorRetail.Enabled = False
            RadioGrosir.Enabled = False
            id_customer_TextBox.Enabled = False
            nama_sales_ComboBox.Enabled = False
        End If
    End Sub

    Private Sub ID_Barang_TextBox_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ID_Barang_TextBox.Enter
        If ID_Barang_TextBox.Text = "   -      " Then
            HRetail_TextBox.Enabled = False
            Quantity_TextBox.Enabled = False
        Else
            HRetail_TextBox.Enabled = True
            Quantity_TextBox.Enabled = True
        End If
    End Sub

    Dim temp As String

    Private Sub Grid_Penjualan_RowsRemoved(ByVal sender As Object, ByVal e As DataGridViewRowsRemovedEventArgs)
        hitung_total()
    End Sub

    Dim namaCustomer, asalCustomer As String
    Private Sub id_customer_TextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles id_customer_TextBox.TextChanged
        If Me.load_complete = True Then
            'If complete_id_customer = True Or id_customer_TextBox.Text = "C-000-000" Then
            Using dt As DataTable = Me.Tabel_customerTableAdapter.GetData_based_id_customer(id_customer_TextBox.Text)
                If dt.Rows.Count <> 0 Then
                    Me.namaCustomer = CStr(dt.Rows(0).Item("nama"))
                    Me.asalCustomer = CStr(dt.Rows(0).Item("asal"))

                    nama_customer_Label.Text = namaCustomer & " di " & asalCustomer

                    totalRp_HutangLama_Label.Text = ubahtocurrencybyDiv(CStr(dt.Rows(0).Item("hutang_lama")))
                    totalRp_HutangLama_Label_order.Text = ubahtocurrencybyDiv(CStr(dt.Rows(0).Item("hutang_lama")))
                Else
                    nama_customer_Label.Text = ""
                    totalRp_HutangLama_Label.Text = "0"
                    totalRp_HutangLama_Label_order.Text = "0"
                End If
                'If (RadiorRetail.IsChecked = True Or RadioGrosir.IsChecked = True) And nama_sales_ComboBox.Text <> "< Pilih Sales >" And id_customer_TextBox.Text <> "< Pilih Customer >" Then
                '    Panel1.Enabled = True
                '    TableLayoutPanel2.Enabled = True
                '    ID_Barang_TextBox.Focus()
                'End If
            End Using
            'End If
        End If
    End Sub

    Private Sub edit_cell()
        If Grid_Penjualan.Rows.Count <> 0 Then
            If (Grid_Penjualan.CurrentCell.ColumnIndex = 3) Or (Grid_Penjualan.CurrentCell.ColumnIndex = 6 And RadiorRetail.IsChecked = True) Or (Grid_Penjualan.CurrentCell.ColumnIndex = 8 And RadiorRetail.IsChecked = True) Or (Grid_Penjualan.CurrentCell.ColumnIndex = 14 And RadiorRetail.IsChecked = True) Then
                Me.temp = CStr(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells(Grid_Penjualan.CurrentCell.ColumnIndex).Value)
                Grid_Penjualan.BeginEdit()
            End If
        End If
    End Sub

    Private Sub Quantity_TextBox_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Quantity_TextBox.Enter
        Quantity_TextBox.SelectAll()
    End Sub

    Private Sub HRetail_TextBox_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles HRetail_TextBox.Enter
        HRetail_TextBox.SelectAll()
    End Sub

    Private Sub Grid_Penjualan_CellContentDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        edit_cell()
    End Sub

    Private Sub RadiorRetail_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadiorRetail.ToggleStateChanged
        pilih_tipe_penjualan()
        If nama_sales_ComboBox.Text <> "< Pilih Sales >" And id_customer_TextBox.Text <> "< Pilih Customer >" And (RadiorRetail.IsChecked = True Or RadioGrosir.IsChecked = True) Then
            Panel1.Enabled = True
            TableLayoutPanel_Normal.Enabled = True
            TableLayoutPanel_Order.Enabled = True
            ID_Barang_TextBox.Focus()
            ID_Barang_TextBox.SelectionLength = 0
        Else
            Panel1.Enabled = False
            TableLayoutPanel_Normal.Enabled = False
            TableLayoutPanel_Order.Enabled = False
            ID_Barang_TextBox.Focus()
            ID_Barang_TextBox.SelectionLength = 0
        End If
    End Sub

    Private Sub RadioGrosir_ToggleStateChanged(ByVal sender As Object, ByVal args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadioGrosir.ToggleStateChanged
        If RadioGrosir.IsChecked = True Then
            Grid_Penjualan.Columns("harga_retail_tertampil").IsVisible = False
            Grid_Penjualan.Columns("harga_grosir_tertampil").IsVisible = False
        Else
            Grid_Penjualan.Columns("harga_retail_tertampil").IsVisible = True
            Grid_Penjualan.Columns("harga_grosir_tertampil").IsVisible = True
        End If

        pilih_tipe_penjualan()
        If nama_sales_ComboBox.Text <> "< Pilih Sales >" And id_customer_TextBox.Text <> "< Pilih Customer >" And (RadiorRetail.IsChecked = True Or RadioGrosir.IsChecked = True) Then
            Panel1.Enabled = True
            TableLayoutPanel_Normal.Enabled = True
            TableLayoutPanel_Order.Enabled = True
            ID_Barang_TextBox.Focus()
        Else
            Panel1.Enabled = False
            TableLayoutPanel_Normal.Enabled = False
            TableLayoutPanel_Order.Enabled = False
            ID_Barang_TextBox.Focus()
        End If
    End Sub


    Private Sub Grid_Penjualan_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Grid_Penjualan.CellDoubleClick
        edit_cell()
    End Sub

    Private Sub Grid_Penjualan_CellEndEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Grid_Penjualan.CellEndEdit
        If Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value IsNot Nothing Then
            Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString.Replace("-", "")
        End If

        If Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells(Grid_Penjualan.CurrentCell.ColumnIndex).Value Is Nothing Then
            Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells(Grid_Penjualan.CurrentCell.ColumnIndex).Value = 0
        End If

        If (e.ColumnIndex >= 4 And e.ColumnIndex <= 13) And e.ColumnIndex <> 12 Then
            If DivKoefisien = DivCoef._1 Then
                Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl((Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) * 1000
            End If
        End If

        'Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells(Grid_Penjualan.CurrentCell.ColumnIndex).Value = ubahtocurrency(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells(Grid_Penjualan.CurrentCell.ColumnIndex).Value)
        If e.ColumnIndex = Grid_Penjualan.Rows(e.RowIndex).Cells("qtyDbGridViewTextBox").ColumnInfo.Index Then
            If Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells(Grid_Penjualan.CurrentCell.ColumnIndex).Value.ToString = "0" And Grid_Penjualan.CurrentCell.ColumnIndex = 3 Then
                If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yakin ingin menghapus data ini ?", Grid_Penjualan.CurrentRow.Cells("kodeDbGridViewTextBox").Value.ToString, MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = DialogResult.Yes Then
                    Grid_Penjualan.Rows.RemoveAt(Grid_Penjualan.CurrentCell.RowIndex)
                Else
                    Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp
                End If
            End If
        End If

        If Grid_Penjualan.Rows.Count <> 0 Then
            'jika diubah kolom diskon
            If e.ColumnIndex = Grid_Penjualan.Columns("diskonDbGridViewTextBox").Index Then
                If Grid_Penjualan.Rows(e.RowIndex).Cells("diskonDbGridViewTextBox").Value.ToString.Length <= 7 Then
                    If (CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value) - CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("diskonDbGridViewTextBox").Value)) < CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_grosirDBGridView").Value) Then
                        Telerik.WinControls.RadMessageBox.Show("Diskon maksimum = " & "Rp. " & ubahtocurrencybyDiv(CStr(CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value) - CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_grosirDBGridview").Value))), "DISKON", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                        If e.ColumnIndex = Grid_Penjualan.CurrentCell.ColumnIndex Then
                            Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp
                        End If
                    Else
                        Grid_Penjualan.Rows(e.RowIndex).Cells("harga_negoDbGridViewTextBox").Value = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value) - CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("diskonDbGridViewTextBox").Value)
                        Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value = Grid_Penjualan.Rows(e.RowIndex).Cells("harga_negoDbGridViewTextBox").Value
                        Grid_Penjualan.Rows(e.RowIndex).Cells("persent").Value = Math.Round(((CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("diskonDbGridViewTextBox").Value) / CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value)) * 100), 1)
                    End If
                Else
                    Telerik.WinControls.RadMessageBox.Show("Tidak dapat menampung lebih dari 7 digit angka")
                    Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp
                End If
            End If

            'jika diubah kolom persen
            If e.ColumnIndex = Grid_Penjualan.Columns("persent").Index Then
                Dim diskonmaks As Double = Math.Floor((CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_retail_tertampil").Value) - CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_grosirDBGridview").Value)) / CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_retail_tertampil").Value) * 1000) * 0.1
               If CDbl(Grid_Penjualan.Rows(e.RowIndex).Cells("persent").Value) < 100 Then
                    If CDbl(Grid_Penjualan.Rows(e.RowIndex).Cells("persent").Value) > diskonmaks Then
                        Grid_Penjualan.Rows(e.RowIndex).Cells("harga_negoDbGridViewTextBox").Value = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_retail_tertampil").Value) - (CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_retail_tertampil").Value) * (diskonmaks / 100))
                        Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value = Grid_Penjualan.Rows(e.RowIndex).Cells("harga_negoDbGridViewTextBox").Value
                        Grid_Penjualan.Rows(e.RowIndex).Cells("diskonDbGridViewTextBox").Value = (CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_retail_tertampil").Value) * (diskonmaks / 100))
                        Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = diskonmaks
                    Else
                        Grid_Penjualan.Rows(e.RowIndex).Cells("harga_negoDbGridViewTextBox").Value = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_retail_tertampil").Value) - (CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_retail_tertampil").Value) * CDbl(Grid_Penjualan.Rows(e.RowIndex).Cells("persent").Value) / 100)
                        Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value = Grid_Penjualan.Rows(e.RowIndex).Cells("harga_negoDbGridViewTextBox").Value
                        Grid_Penjualan.Rows(e.RowIndex).Cells("diskonDbGridViewTextBox").Value = (CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_retail_tertampil").Value) * CDbl(Grid_Penjualan.Rows(e.RowIndex).Cells("persent").Value) / 100)
                    End If
                Else
                    Telerik.WinControls.RadMessageBox.Show("Tidak boleh lebih besar dari 100 persen")
                    Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp
                End If
            End If

            'jika diubah kolom harga
            If e.ColumnIndex = Grid_Penjualan.Columns("hargaDbGridViewTextBox").Index Then
                If Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value.ToString.Length <= 7 Then
                    Dim diskon_maks As Integer = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value) - CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_grosirDBGridview").Value)
                    If CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value) < CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value) - diskon_maks Then
                        Telerik.WinControls.RadMessageBox.Show("Harga jual minimum = " & "Rp. " & ubahtocurrencybyDiv(CStr(CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value) - diskon_maks)), "Harga Jual", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                        If e.ColumnIndex = Grid_Penjualan.CurrentCell.ColumnIndex Then
                            'Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value)
                            Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp
                        End If
                    ElseIf CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value) > CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_grosirDBGridview").Value) + diskon_maks Then
                        Telerik.WinControls.RadMessageBox.Show("Harga jual maksimum = " & "Rp. " & ubahtocurrencybyDiv(CStr(CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harga_grosirDBGridview").Value) + diskon_maks)), "Harga Jual", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                        If e.ColumnIndex = Grid_Penjualan.CurrentCell.ColumnIndex Then
                            'Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value)
                            Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp
                        End If
                    Else
                        Grid_Penjualan.Rows(e.RowIndex).Cells("harga_negoDbGridViewTextBox").Value = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value)
                        Grid_Penjualan.Rows(e.RowIndex).Cells("diskonDbGridViewTextBox").Value = (CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value) - CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value))
                        Grid_Penjualan.Rows(e.RowIndex).Cells("persent").Value = Math.Round(((((CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value) - CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("hargaDbGridViewTextBox").Value))) / CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value)) * 100), 1)
                        ' Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value)
                    End If
                Else
                    Telerik.WinControls.RadMessageBox.Show("Tidak dapat menampung lebih dari 7 digit angka")
                    'Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CInt(Grid_Penjualan.Rows(e.RowIndex).Cells("harganegodefault").Value)
                    Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp
                End If
            End If
        End If



        If Grid_Penjualan.Rows.Count <> 0 Then
            If Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("qtyDbGridViewTextBox").Value.ToString.Length <= 4 Then
                If tipe <> TipePenjualan.Order Then
                    Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("subtotalDbGridViewTextBox").Value = CDbl(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("qtyDbGridViewTextBox").Value) * CDbl(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("hargaDbGridViewTextBox").Value)
                Else
                    Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("subtotalDbGridViewTextBox").Value = CDbl(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("qtyDbGridViewTextBox").Value) * CDbl(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("hargamodalDBGridview").Value)
                End If
                Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("labaDBGrid").Value = CDbl(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("qtyDbGridViewTextBox").Value) * (CDbl(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("harga_negoDbGridViewTextBox").Value) - (CDbl(Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("hargamodalDBGridview").Value)))

            Else
                Telerik.WinControls.RadMessageBox.Show("Tidak dapat menampung lebih dari 4 digit angka")
                Grid_Penjualan.Rows(Grid_Penjualan.CurrentCell.RowIndex).Cells("qtyDbGridViewTextBox").Value = temp
            End If
        End If

        hitung_total()
        If F6_F7 = True Then
            ID_Barang_TextBox.Focus()
            ID_Barang_TextBox.SelectionLength = 0
        End If
        If Grid_Penjualan.CurrentColumn Is Grid_Penjualan.Columns(6) Then
            ID_Barang_TextBox.Focus()
            ID_Barang_TextBox.SelectionLength = 0
        End If
        F6_F7 = False
    End Sub

    Private Sub Grid_Penjualan_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles Grid_Penjualan.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If RadiorRetail.IsChecked = True Then
            If e.ColumnIndex = Grid_Penjualan.Columns("harga_grosir_tertampil").Index Then
                e.CellElement.ForeColor = Color.DarkGray
            End If
            If e.ColumnIndex = Grid_Penjualan.Columns("harga_retail_tertampil").Index Then
                e.CellElement.ForeColor = Color.DarkGray
            End If
        End If
        If (e.ColumnIndex >= 4 And e.ColumnIndex <= 13) And e.ColumnIndex <> 12 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub Grid_Penjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_Penjualan.KeyDown
        If Grid_Penjualan.Rows.Count <> 0 Then
            If e.KeyCode = Keys.F5 Then
                edit_cell()
            ElseIf e.KeyCode = Keys.Delete Then
                If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yakin ingin menghapus data ini ?", CStr(Grid_Penjualan.CurrentRow.Cells("kodeDbGridViewTextBox").Value), MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = DialogResult.Yes Then
                    Grid_Penjualan.Rows.RemoveAt(Grid_Penjualan.CurrentCell.RowIndex)
                    hitung_total()
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                Grid_Penjualan.CurrentRow = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1)
                Grid_Penjualan.CurrentColumn = Grid_Penjualan.Columns(3)
                edit_cell()
            ElseIf e.KeyCode = Keys.F7 And RadioGrosir.IsChecked = False Then
                Grid_Penjualan.CurrentRow = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1)
                Grid_Penjualan.CurrentColumn = Grid_Penjualan.Columns(8)
                edit_cell()
            ElseIf e.KeyCode = Keys.F8 Then
                Grid_Penjualan.CurrentRow = Grid_Penjualan.Rows(Grid_Penjualan.Rows.Count - 1)
                Grid_Penjualan.CurrentColumn = Grid_Penjualan.Columns(6)
                edit_cell()
            End If
        End If
    End Sub

    Private Sub Grid_Penjualan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Grid_Penjualan.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.F5) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Grid_Penjualan_UserAddedRow(sender As Object, e As Telerik.WinControls.UI.GridViewRowEventArgs) Handles Grid_Penjualan.UserAddedRow
        If RadiorRetail.IsChecked = True Then
            RadioGrosir.Enabled = False
        ElseIf RadioGrosir.IsChecked = True Then
            RadiorRetail.Enabled = False
        End If
        hitung_total()
    End Sub

    Private Sub Grid_Penjualan_UserDeletedRow(sender As Object, e As Telerik.WinControls.UI.GridViewRowEventArgs) Handles Grid_Penjualan.UserDeletedRow
        If RadiorRetail.IsChecked = True Then
            RadioGrosir.Enabled = False
        ElseIf RadioGrosir.IsChecked = True Then
            RadiorRetail.Enabled = False
        End If
        hitung_total()
    End Sub

    Private Sub nama_sales_ComboBox_PopupOpening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles nama_sales_ComboBox.PopupOpening
        Using dt = Me.Tabel_salesTableAdapter.GetDataFilterN()
            nama_sales_ComboBox.Items.Clear()
            'nama_sales_ComboBox.Text = "< Pilih Sales >"
            For i As Integer = 0 To dt.Rows.Count - 1
                nama_sales_ComboBox.Items.Add(dt.Rows(i).Item("nama").ToString)
            Next
            nama_sales_ComboBox.Text = nama_sales_ComboBox.Items(0).Text
        End Using
    End Sub

    'Dim complete_id_customer As Boolean = False
    Private Sub id_customer_TextBox_Enter(sender As Object, e As EventArgs) Handles id_customer_TextBox.Enter
        If tipe = TipePenjualan.Order Then
            Using dt As DataTable = Tabel_customerTableAdapter.GetDataOrderSpecial()
                id_customer_TextBox.MultiColumnComboBoxElement.Rows.Clear()
                For i = 0 To dt.Rows.Count - 1
                    id_customer_TextBox.MultiColumnComboBoxElement.Rows.Add(dt.Rows(i).Item("id_customer"), dt.Rows(i).Item("nama"), dt.Rows(i).Item("asal"))
                Next
                id_customer_TextBox.Text = CStr(id_customer_TextBox.MultiColumnComboBoxElement.Rows(0).Cells(0).Value)
                'complete_id_customer = True
            End Using
        Else
            Using dt As DataTable = Tabel_customerTableAdapter.GetData()
                id_customer_TextBox.MultiColumnComboBoxElement.Rows.Clear()
                For i = 0 To dt.Rows.Count - 1
                    id_customer_TextBox.MultiColumnComboBoxElement.Rows.Add(dt.Rows(i).Item("id_customer"), dt.Rows(i).Item("nama"), dt.Rows(i).Item("asal"))
                Next
                id_customer_TextBox.Text = CStr(id_customer_TextBox.MultiColumnComboBoxElement.Rows(0).Cells(0).Value)
                'complete_id_customer = True
            End Using
        End If
    End Sub

    Private Sub id_customer_TextBox_Leave(sender As Object, e As EventArgs) Handles id_customer_TextBox.Leave
        If id_customer_TextBox.Text = "" Then
            id_customer_TextBox.Text = CStr(id_customer_TextBox.MultiColumnComboBoxElement.Rows(0).Cells(0).Value)
        End If
        'complete_id_customer = False
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        If SettingAuthority.PenjualanAndBarangMasuk.ReturPenjualan = True Then
            proced_retur()
        Else
            FormDialogPassword.tipe = FormDialogPassword.tipekonfirmasi.ReturPenjualan
            If FormDialogPassword.ShowDialog() = DialogResult.Yes Then
                proced_retur()
            End If
        End If
    End Sub

    Private Sub bayar_TextBox_order_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bayar_TextBox_order.TextChanged
        hitung_bayar()
        bayar_TextBox.Text = bayar_TextBox_order.Text
    End Sub

    Private Sub RecentAct_Label_Refresh_Click(sender As Object, e As EventArgs) Handles RecentAct_Label_Refresh.Click
        RecentAct_Label_No.Text = ""
        RecentAct_Label_KodeBrg.Text = ""
        RecentAct_Label_NamaBrg.Text = ""
        RecentAct_Label_Qty.Text = ""
        RecentAct_Label_Cross.Text = ""
        RecentAct_Label_Refresh.Text = ""
        RecentAct_Label_Harga.Text = ""
    End Sub

    Private Sub Grid_Penjualan_RowsChanged(sender As Object, e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles Grid_Penjualan.RowsChanged
        If Grid_Penjualan.Rows.Count > 0 Then
            bayar_TextBox.Enabled = True
            bayar_TextBox_order.Enabled = True
        Else
            bayar_TextBox.Enabled = False
            bayar_TextBox_order.Enabled = False
        End If
    End Sub

    Private Sub Grid_Penjualan_ContextMenuOpening(sender As Object, e As Telerik.WinControls.UI.ContextMenuOpeningEventArgs) Handles Grid_Penjualan.ContextMenuOpening
        If tipe = TipePenjualan.Order Then
            If Grid_Penjualan.CurrentCell.ColumnIndex = Grid_Penjualan.Columns("hargaDbGridViewTextBox").Index Or _
                Grid_Penjualan.CurrentCell.ColumnIndex = Grid_Penjualan.Columns("qtyDbGridViewTextBox").Index Then
                e.ContextMenu.Items(1).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            End If
        Else
            If Grid_Penjualan.CurrentCell.ColumnIndex = Grid_Penjualan.Columns("hargaDbGridViewTextBox").Index Or _
                Grid_Penjualan.CurrentCell.ColumnIndex = Grid_Penjualan.Columns("qtyDbGridViewTextBox").Index Or _
                Grid_Penjualan.CurrentCell.ColumnIndex = Grid_Penjualan.Columns("persent").Index Then
                e.ContextMenu.Items(1).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            End If
        End If
    End Sub

    Private Sub ButtonNotaCheck_Click(sender As Object, e As EventArgs) Handles ButtonNotaCheck.Click
        If Grid_Penjualan.Rows.Count > 0 Then
            Using tabel_temp_checking As New tokoDataSetTableAdapters.tabel_temp_checkingTableAdapter
                Dim customer() As String = nama_customer_Label.Text.Split(" di ")
                Dim harga = Function(_tipe As TipePenjualan, baris As Integer)
                                If _tipe = TipePenjualan.Order Then
                                    Return Grid_Penjualan.Rows(baris).Cells(4).Value
                                Else
                                    Return Grid_Penjualan.Rows(baris).Cells(6).Value()
                                End If
                            End Function
                For i = 0 To Grid_Penjualan.Rows.Count - 1
                    tabel_temp_checking.InsertQuery(Label_Invoice.Text, _
                                                    Grid_Penjualan.Rows(i).Cells(1).Value, _
                                                    Grid_Penjualan.Rows(i).Cells(2).Value, _
                                                    Grid_Penjualan.Rows(i).Cells(3).Value, _
                                                    harga(tipe, i), _
                                                    tipe_penjualan().Substring(0, 1), _
                                                    nama_sales_ComboBox.Text, _
                                                    customer(0), _
                                                    customer(2))


                Next

                Using FormCetak As New FormCetakNotaChecking
                    FormCetak.Invoice = Label_Invoice.Text
                    FormCetak.ShowDialog()
                End Using

                tabel_temp_checking.DeleteQuery(Label_Invoice.Text)
            End Using
        End If
    End Sub

    Public Sub refreshAftrDivUpdate()
        For i = 0 To Grid_Penjualan.Rows.Count - 1
            Grid_Penjualan.Rows(i).Cells(0).Value = ""
        Next
        hitung_total()
    End Sub


    Private Sub Grid_Penjualan_CellBeginEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellCancelEventArgs) Handles Grid_Penjualan.CellBeginEdit
        If (e.ColumnIndex >= 4 And e.ColumnIndex <= 13) And e.ColumnIndex <> 12 Then
            If DivKoefisien = DivCoef._1 Then
                Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl((Grid_Penjualan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) / 1000
            End If
        End If
    End Sub

    Private Sub Grid_Penjualan_CellEditorInitialized(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles Grid_Penjualan.CellEditorInitialized
        Dim spineditor As Telerik.WinControls.UI.GridSpinEditor = TryCast(Me.Grid_Penjualan.ActiveEditor, Telerik.WinControls.UI.GridSpinEditor)
        If spineditor IsNot Nothing Then
            If e.ColumnIndex >= 4 And e.ColumnIndex <= 13 And e.ColumnIndex <> 12 Then
                spineditor.DecimalPlaces = Desimal()
            End If
        End If
    End Sub
End Class
