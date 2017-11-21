Imports Telerik.WinControls.UI
Imports System.IO
Imports Telerik.WinControls.Data

Public Class UC_BarangMasuk

    Public Property AdaSession As Boolean = False

    Private Function record_brg_masuk(ByVal indeks As Integer) As Boolean
        Try
            Tabel_barang_masukTableAdapter.InsertQueryBarangMasuk(CStr(DataGridView1.Rows(indeks).Cells("kode").Value), CInt(DataGridView1.Rows(indeks).Cells("stok").Value), Label_Invoice.Text)

            Return True
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Program Penjualan - Record Barang Masuk", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        End Try
        Return False
    End Function

    Private Sub increase_temp(ByVal invoice As String)
        Try
            Tabel_temp_masukTableAdapter.IncreaseTemp(invoice)
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Program Penjualan - Invoice Increment", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        End Try
    End Sub

    Private Function cek_kode(ByVal indeks As Integer) As Boolean
        Using dt As DataTable = Tabel_barangTableAdapter_1.GetData(DataGridView1.Rows(indeks).Cells("kode").Value.ToString)
            If dt.Rows.Count > 0 Then
                If DataGridView1.Rows(indeks).Cells("kode").Value.ToString = dt.Rows(0).Item("kode_barang").ToString Then
                    Return True
                Else
                    Return False
                End If
            End If
            Return False
        End Using
    End Function

    Private Function tambah_data(ByVal indeks As Integer) As Boolean
        Try
            If cek_kode(indeks) = False Then
                Tabel_barangTableAdapter.InsertBarangBaru(DataGridView1.Rows(indeks).Cells("kode").Value.ToString, _
                                                        DataGridView1.Rows(indeks).Cells("nama").Value.ToString, _
                                                        DataGridView1.Rows(indeks).Cells("tipe_barang").Value.ToString, _
                                                        CType(DataGridView1.Rows(indeks).Cells("stok").Value, Integer), _
                                                        CType(DataGridView1.Rows(indeks).Cells("harga_modal").Value, Double), _
                                                        CType(DataGridView1.Rows(indeks).Cells("harga_grosir").Value, Double), _
                                                        CType(DataGridView1.Rows(indeks).Cells("harga_retail").Value.ToString, Double), _
                                                        DataGridView1.Rows(indeks).Cells("keterangan").Value.ToString, _
                                                        CDate(tgltoday), _
                                                        0, 0)
            Else
                Tabel_barangTableAdapter.UpdateQueryStok(CType(DataGridView1.Rows(indeks).Cells("stok").Value.ToString, Integer), _
                                                 DataGridView1.Rows(indeks).Cells("kode").Value.ToString)

                If Tabel_barangTableAdapter.ScalarQueryStokNol(DataGridView1.Rows(indeks).Cells("kode").Value.ToString) = 0 Then
                    Me.Tabel_barangTableAdapter.UpdateQueryUnTerhapus(DataGridView1.Rows(indeks).Cells("kode").Value.ToString)
                End If
            End If
                Return True
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Barang Masuk - Proses Penambahan Data", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        End Try
        Return False
    End Function

    Private Function cekInvoice() As String
        Dim cki As String = CStr(Tabel_temp_masukTableAdapter.cekMaxinvoice("BM-" & tglNiHari_YMD & "%"))
        If cki Is vbNullString Then
            Return "BM-" & tglNiHari_YMD & "-0001"
        Else
            cki = cki.Replace("BM", "")
            cki = cki.Replace("-", "")
            Dim i As Integer = CType(cki, Integer) + 1
            Dim c As String = i.ToString.Insert(0, "BM-")
            Return c.Insert(9, "-")
        End If
    End Function

    Private Sub UC_BarangMasuk_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If AdaSession = False Then
            Label_Invoice.Text = cekInvoice()
            increase_temp(Label_Invoice.Text)
        End If
        force_tipe = False
        'cek_combo_tipebrg()
        Panel1.Enabled = False
        Panel2.Enabled = False
        Dim idFd As FilterDescriptor = New FilterDescriptor("id_supplier", FilterOperator.Contains, Nothing)
        Me.RadMultiColumnComboBox2.MultiColumnComboBoxElement.EditorControl.FilterDescriptors.Add(idFd)
        Dim namaFd As FilterDescriptor = New FilterDescriptor("nama_supplier", FilterOperator.Contains, Nothing)
        Me.RadMultiColumnComboBox2.MultiColumnComboBoxElement.EditorControl.FilterDescriptors.Add(namaFd)
        Me.RadMultiColumnComboBox2.MultiColumnComboBoxElement.EditorControl.FilterDescriptors.LogicalOperator = FilterLogicalOperator.Or
        'End
        SetAwal()
    End Sub


    Dim IsiTertentu As String()
    Private Sub SetAwal()
        TextBox1.Focus()
        RadMultiColumnComboBox2.Text = SettingPreferensi.BarangMasuk.IDSupplier
        If SettingPreferensi.BarangMasuk.Tertentu <> "" Then
            IsiTertentu = SettingPreferensi.BarangMasuk.Tertentu.Split(",")
        End If
    End Sub

    Private Sub cek_combo_tipebrg()
        Using dt As DataTable = Tabel_tipe_barangTableAdapter.GetData()
            ComboBox_TipeBrg.Items.Add("< Pilih Tipe >")
            For n As Integer = 0 To dt.Rows.Count - 1
                ComboBox_TipeBrg.Items.Add(dt.Rows(n).Item(0).ToString)
            Next
            ComboBox_TipeBrg.SelectedIndex = 0
        End Using
    End Sub

    Private Function cek_tersedia() As Boolean
        Using dt1 As DataTable = Tabel_barangTableAdapter_1.GetData(TextBox_KodeBrg.Text.ToString)
            If dt1.Rows.Count = 0 Then
                TextBox_NamaBrg.Text = ""
                TextBox_Stok_Awal.Text = "0"
                TextBox_Stok_Tambah.Text = "0"
                TextBox_HargaModal.Text = "0"
                TextBox_HargaGrosir.Text = "0"
                TextBox_HargaRetail.Text = "0"
                RichTextBox_Keterangan.Text = ""
                Return False
            Else
                TextBox_NamaBrg.Text = dt1.Rows(0).Item("nama_barang").ToString()
                TextBox_Stok_Awal.Text = dt1.Rows(0).Item("stok_barang").ToString()
                TextBox_HargaModal.Text = ubahtocurrencybyDiv(dt1.Rows(0).Item("harga_modal").ToString())
                TextBox_HargaGrosir.Text = ubahtocurrencybyDiv(dt1.Rows(0).Item("harga_grosir").ToString())
                TextBox_HargaRetail.Text = ubahtocurrencybyDiv(dt1.Rows(0).Item("harga_retail").ToString())
                ComboBox_TipeBrg.Text = (dt1.Rows(0).Item("tipe_barang").ToString)
                RichTextBox_Keterangan.Text = dt1.Rows(0).Item("keterangan").ToString()
                Return True
            End If
        End Using
    End Function

    Private ck As Boolean

    Private Sub TextBox_KodeBrg_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_KodeBrg.TextChanged
        ck = cek_tersedia()
        If ck = True Then
            ComboBox_TipeBrg.Enabled = False
            TextBox_NamaBrg.Enabled = False
            TextBox_HargaModal.Enabled = False
            TextBox_HargaGrosir.Enabled = False
            TextBox_HargaRetail.Enabled = False
            RichTextBox_Keterangan.Enabled = False
        Else
            ComboBox_TipeBrg.Enabled = True
            TextBox_NamaBrg.Enabled = True
            TextBox_HargaModal.Enabled = True
            TextBox_HargaGrosir.Enabled = True
            TextBox_HargaRetail.Enabled = True
            RichTextBox_Keterangan.Enabled = True
            If TextBox_KodeBrg.Text <> "" Then
                TextBox_NamaBrg.Focus()
            End If
        End If
        If TextBox_KodeBrg.Text = "" Then
            Button_tambah.Enabled = False
        Else
            Button_tambah.Enabled = True
        End If
    End Sub

    Private Sub proses_transaksi()
        Dim l As Boolean = True
        For indeks As Integer = 0 To DataGridView1.RowCount - 1
            If l = True Then
                l = l And tambah_data(indeks)
            Else
                Continue For
            End If
        Next
        If l = True Then
            l = l And tambah_invoice_masuk()
        End If
        For indeks As Integer = 0 To DataGridView1.RowCount - 1
            If l = True Then
                l = l And record_brg_masuk(indeks)
            End If
        Next
        If l = True Then
            Me.Tabel_status_transaksiTableAdapter.InsertQuery(CDate(tgltoday), "Barang Masuk", "Berhasil")
            FormUtama.RadLabel10.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%Small%"))
            FormUtama.RadLabel12.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%Big%"))
            FormUtama.RadLabel14.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%Order%"))
            FormUtama.RadLabel16.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%Barang%"))
            FormUtama.RadLabel18.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryBerhasil(CDate(tgltoday), "%"))
            'Telerik.WinControls.RadMessageBox.Show("Transaksi sukses, data telah tersimpan pada database.", "Barang Masuk", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            cetakNota()
            FormUtama.TabControl1.Pages.Remove(FormUtama.TabControl1.SelectedPage)
        Else
            Telerik.WinControls.RadMessageBox.Show("Transaksi gagal, data tidak dapat disimpan pada database.", "Barang Masuk - ProsesTransaksi", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Exclamation)
        End If
    End Sub

    Public Sub eksekusi()
        If Telerik.WinControls.RadMessageBox.Show("Apakah anda yakin ingin   melanjutkan transaksi Barang Masuk ini ?", "Konfirmasi", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = DialogResult.Yes Then
            proses_transaksi()
        End If
    End Sub

    Private Sub ButtonSelesai(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Selesai.Click
        Try
            eksekusi()
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Transaksi Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        End Try
    End Sub

    Public Sub tutup_barangmasuk()
        If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yakin ingin menutup tab Barang Masuk ini?", "Perhatian", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) _
            = DialogResult.Yes Then
            Me.Tabel_status_transaksiTableAdapter.InsertQuery(CDate(tgltoday), "Barang Masuk", "Gagal")
            FormUtama.RadLabel7.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%Small%"))
            FormUtama.RadLabel11.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%Big%"))
            FormUtama.RadLabel13.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%Order%"))
            FormUtama.RadLabel15.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%Barang%"))
            FormUtama.RadLabel17.Text = CStr(Me.Tabel_status_transaksiTableAdapter.ScalarQueryGagal(CDate(tgltoday), "%"))
            FormUtama.uc_b(CInt(FormUtama.TabControl1.SelectedPage.Text.Replace("Barang Masuk ", "")) - 1).Dispose()
            FormUtama.tabpages_brg_masuk(CInt(FormUtama.TabControl1.SelectedPage.Text.Replace("Barang Masuk ", "")) - 1).Dispose()
        End If
        CobaBersihkanMemori()
    End Sub

    Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
        tutup_barangmasuk()
    End Sub

    Structure for_katalog
        Dim nama_brg As String
        Dim harga As Integer
        Dim gambar As Object
    End Structure

    Private Sub Button9_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button9.Click
        Dim katalog(DataGridView1.RowCount - 1) As for_katalog
        For i = 0 To DataGridView1.RowCount - 1
            katalog(i).nama_brg = CStr(DataGridView1.Rows(i).Cells("nama").Value)
            katalog(i).harga = CInt(DataGridView1.Rows(i).Cells("harga_retail").Value)
            'katalog(i).gambar = Global.Program_Penjualan_V2.My.Resources.apple6
        Next
        Using CetakKatalog As New FormCetakKatalog
            CetakKatalog.katalog = katalog
            CetakKatalog.ShowDialog()
            CetakKatalog.Dispose()
        End Using
        CobaBersihkanMemori()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button_kodesearch.Click
        Using DialogCariBarangBrgMasuk As New FormDialogCariBarangBrgMasuk
            If DialogCariBarangBrgMasuk.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                TextBox_KodeBrg.Text = DialogCariBarangBrgMasuk.kode_brg
                DialogCariBarangBrgMasuk.Dispose()
                TextBox_Stok_Tambah.Focus()
            End If
        End Using
        CobaBersihkanMemori()
    End Sub

    Private Sub Button7_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button_tambah.Click
        If TextBox_NamaBrg.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show("Nama barang tidak boleh kosong.", "", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            TextBox_NamaBrg.Focus()
        ElseIf TextBox_Stok_Tambah.Text = "0" Then
            Telerik.WinControls.RadMessageBox.Show("Stok baru tidak boleh 0.", "", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            TextBox_Stok_Tambah.Focus()
        ElseIf TextBox_HargaModal.Text = "0" Then
            Telerik.WinControls.RadMessageBox.Show("Harga modal tidak boleh 0.", "", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            TextBox_HargaModal.Focus()
        ElseIf TextBox_HargaGrosir.Text = "0" Then
            Telerik.WinControls.RadMessageBox.Show("Harga grosir tidak boleh 0.", "", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            TextBox_HargaGrosir.Focus()
        ElseIf TextBox_HargaRetail.Text = "0" Then
            Telerik.WinControls.RadMessageBox.Show("Harga retail tidak boleh 0.", "", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            TextBox_HargaRetail.Focus()
        Else
            Dim cek As String = cek_di_table(TextBox_KodeBrg.Text)
            If cek = "nothing" Then
                DataGridView1.Rows.Add("", _
                                              TextBox_KodeBrg.Text, _
                                              TextBox_NamaBrg.Text, _
                                              TextBox_Stok_Tambah.Text, _
                                              ubahAwalbeforeDiv(TextBox_HargaModal.Text), _
                                              CInt(TextBox_Stok_Awal.Text) + CInt(TextBox_Stok_Tambah.Text), _
                                              ubahAwalbeforeDiv(TextBox_HargaGrosir.Text), _
                                              ubahAwalbeforeDiv(TextBox_HargaRetail.Text), _
                                              tgltoday.ToString(), _
                                              "Cetak", _
                                              ComboBox_TipeBrg.Text, _
                                              RichTextBox_Keterangan.Text)
            Else
                DataGridView1.Rows(CInt(cek)).Cells("stok").Value = CInt(DataGridView1.Rows(CInt(cek)).Cells("stok").Value) + CInt(TextBox_Stok_Tambah.Text)
                DataGridView1.Rows(CInt(cek)).Cells("total_stok").Value = CInt(DataGridView1.Rows(CInt(cek)).Cells("total_stok").Value) + CInt(TextBox_Stok_Tambah.Text)
            End If
            ComboBox_TipeBrg.Text = "< Pilih Tipe >"
            ComboBox_TipeBrg.Focus()
            Button_Selesai.Enabled = True
            Button9.Enabled = True
            Button2.Enabled = True
            Label_Stok_Masuk.Text = CStr(jlh_masuk())
            RadMultiColumnComboBox2.Enabled = False
            TextBox_KodeBrg.Text = ""
            Button_kodeauto.Enabled = False
            ComboBox_TipeBrg.Focus()
        End If
    End Sub

    Private Function jlh_masuk() As Integer
        Dim hasil As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            hasil = hasil + CType(DataGridView1.Rows(i).Cells("stok").Value, Integer)
        Next
        Return hasil
    End Function

    Private Sub hitung_all()
        Dim total As Double = 0
        Dim jl As Integer = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            jl = jl + (CInt(DataGridView1.Rows(i).Cells("stok").Value))
            total += ((CDbl(DataGridView1.Rows(i).Cells("stok").Value) * CDbl(DataGridView1.Rows(i).Cells("harga_modal").Value)))
        Next
        'TextBox_Jlh_Stok_Dibeli.Text = jl
        'TextBox_Pembelian.Text = total
        'Dim total_all As Double
        'total_all = total + CType(TextBox_Hutang.Text, Double)
        Label_Total_Pembelian.Text = ubahtocurrencybyDiv(total.ToString)
        Label_Stok_Masuk.Text = CStr(jlh_masuk())
        'TextBox_Lunas.Text = CType(textBox_Pembayaran.Text, Double) - total_all
    End Sub

    Private Sub TextBox_Stok_Tambah_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_Stok_Tambah.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or (e.KeyChar = "-"c And Not TextBox_Stok_Tambah.Text.Contains("-") And TextBox_Stok_Tambah.SelectionStart = 0) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_HargaModal_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_HargaModal.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or (e.KeyChar = ","c And Not TextBox_HargaModal.Text.Contains(",") And TextBox_HargaModal.SelectionStart > 0) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_HargaGrosir_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_HargaGrosir.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or (e.KeyChar = ","c And Not TextBox_HargaGrosir.Text.Contains(",") And TextBox_HargaGrosir.SelectionStart > 0) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox_HargaRetail_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_HargaRetail.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or (e.KeyChar = ","c And Not TextBox_HargaRetail.Text.Contains(",") And TextBox_HargaRetail.SelectionStart > 0) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_kodeauto.Click
        isiKodeBarang()
        Dim n, str As String
        Dim cek As String = cek_pada_table_2(Me.kode_tipe)
        If cek <> "nothing" Then
            n = CStr(CInt(cek) + 1)
            Select Case n.ToString().Length
                Case 1
                    str = "00000" & n
                Case 2
                    str = "0000" & n
                Case 3
                    str = "000" & n
                Case 4
                    str = "00" & n
                Case 5
                    str = "0" & n
                Case Else
                    str = n
            End Select
            TextBox_KodeBrg.Text = kode_tipe & "-" & str
        End If
    End Sub

    Private Function cek_pada_table_2(ByVal cek As String) As String
        Dim temp As String = "nothing"
        Dim temp_str As Integer = 0
        Dim l = Me.Tabel_barangTableAdapter.ScalarQueryKodeBarangMax(kode_tipe & "%") & ""
        If l <> "" Then
            temp_str = CInt(Me.Tabel_barangTableAdapter.ScalarQueryKodeBarangMax(kode_tipe & "%").ToString.Substring(4))
        End If
        If DataGridView1.Rows.Count <> 0 Then
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells("kode").Value.ToString.Substring(0, 3) = cek Then
                    If temp_str < CInt(DataGridView1.Rows(i).Cells("kode").Value.ToString.Substring(4)) Then
                        temp_str = CInt(DataGridView1.Rows(i).Cells("kode").Value.ToString.Substring(4))
                        temp = CStr(temp_str)
                    End If
                End If
            Next
        Else
        End If
        Return temp
    End Function

    'Dim temp_str As Integer = 0
    Private Sub isiKodeBarang()
        Dim str As String
        Dim n As Integer

        If Me.Tabel_barangTableAdapter.ScalarQueryKodeBarangMax(kode_tipe & "%") <> vbNullString Then
            str = Me.Tabel_barangTableAdapter.ScalarQueryKodeBarangMax(kode_tipe & "%").ToString.Substring(4)
            'temp_str = CInt(str)
            n = CInt(str) + 1
            Select Case n.ToString().Length
                Case 1
                    str = "00000" & n
                Case 2
                    str = "0000" & n
                Case 3
                    str = "000" & n
                Case 4
                    str = "00" & n
                Case 5
                    str = "0" & n
                Case Else
                    str = CStr(n)
            End Select
            TextBox_KodeBrg.Text = kode_tipe & "-" & str
        Else
            TextBox_KodeBrg.Text = kode_tipe & "-000001"
        End If
    End Sub

    Private kode_tipe As String
    Private force_tipe As Boolean
    Private Sub ComboBox_TipeBrg_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboBox_TipeBrg.SelectedIndexChanged
        'If force_tipe = False Then
        Dim tipe_brg As String
        If ComboBox_TipeBrg.Items.Count <> 0 Then
            tipe_brg = ComboBox_TipeBrg.SelectedItem.Text.ToString
        Else
            tipe_brg = ""
        End If
        Using dt As DataTable = Tabel_tipe_barangTableAdapter.GetDataKodeTipe(tipe_brg)
            If dt.Rows.Count <> 0 Then
                Me.kode_tipe = dt.Rows(0).Item(1).ToString
            End If
            If ComboBox_TipeBrg.Items.Count <> 0 Then
                If ComboBox_TipeBrg.SelectedItem.Text = "< Pilih Tipe >" Then
                    Button_kodeauto.Enabled = False
                    TextBox_KodeBrg.Text = ""
                Else
                    If SettingPreferensi.BarangMasuk.AutoTipeBarang = "Tertentu" Then
                        Button_kodeauto.Enabled = False
                        For i = 0 To IsiTertentu.Count - 1
                            If ComboBox_TipeBrg.SelectedItem.Text = IsiTertentu(i) Then
                                Button_kodeauto.Enabled = True
                                TextBox_KodeBrg.Text = ""
                                Exit For
                            End If
                        Next
                    Else
                        Button_kodeauto.Enabled = True
                        TextBox_KodeBrg.Text = ""
                    End If
                End If
            Else
                Button_kodeauto.Enabled = False
                TextBox_KodeBrg.Text = ""
            End If
        End Using
        'End If
    End Sub

    Dim alamatSupplier As String = "none"
    Dim asalSupplier As String = "none"

    Private Sub cetakNota()
        'Dim rows As Integer = Me.Tabel_barang_masukTableAdapter.ScalarQuery(Label_Invoice.Text)
        'Dim banyak As Integer
        'Dim N As Integer = rows \ 23
        'If rows <= (N * 23) + 21 Then
        '    banyak = (21 + (23 * N)) - rows
        'Else
        '    N += 1
        '    banyak = (21 + (23 * N)) - rows
        'End If
        Using CetakNotaBarangMasuk As New FormCetakNotaBarangMasuk
            'CetakNotaBarangMasuk.ExtraOrdinary = False
            CetakNotaBarangMasuk.Invoice = Label_Invoice.Text
            'FormCetakNotaBarangMasuk.Banyak = banyak
            CetakNotaBarangMasuk.Kota = KotaToko
            CetakNotaBarangMasuk.ShowDialog()
            CetakNotaBarangMasuk.Dispose()
        End Using
        CobaBersihkanMemori()
    End Sub

    Private Function tambah_invoice_masuk() As Boolean
        Try
            Me.Tabel_invoice_masukTableAdapter.InsertQueryInvoiceMasuk(Label_Invoice.Text, RadMultiColumnComboBox2.Text, CType(Label_Total_Pembelian.Text, Double), CType(Label_Stok_Masuk.Text, Integer))
            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function

    Private Sub Label_Total_Pembelian_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Label_Total_Pembelian.TextChanged
        'Me.Label_Total_Pembelian.Text = FormatNumber(Label_Total_Pembelian.Text, 0, , , TriState.UseDefault)
    End Sub

    Private Function cek_di_table(ByVal cek As String) As String
        If DataGridView1.Rows.Count <> 0 Then
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells("kode").Value.ToString = cek Then
                    Return CStr(i)
                End If
            Next
        End If
        Return "nothing"
    End Function

    Structure _Label
        Dim N As Integer
        Dim lbl_kode As String
        Dim id_barang As String
        Dim nm_brg As String
        Dim h_grosir As String
        Dim h_retail As String
        Dim nama_perusahaan As String
        Dim gambar As Object
    End Structure

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Dim _label_(CInt(DataGridView1.Rows.Count) - 1) As _Label
        For i = 0 To DataGridView1.Rows.Count - 1
            _label_(i).N = CInt(DataGridView1.Rows(i).Cells("stok").Value.ToString.Replace("-", ""))
            _label_(i).lbl_kode = CStr(DataGridView1.Rows(i).Cells("kode").Value)
            _label_(i).id_barang = CStr(DataGridView1.Rows(i).Cells("kode").Value)
            _label_(i).nm_brg = CStr(DataGridView1.Rows(i).Cells("nama").Value)
            _label_(i).h_grosir = CStr(DataGridView1.Rows(i).Cells("harga_grosir").Value)
            _label_(i).h_retail = CStr(DataGridView1.Rows(i).Cells("harga_retail").Value)
            _label_(i).nama_perusahaan = NamaTokoShort
            Using gambarLogo As New System.IO.MemoryStream(LogoPerusahaan)
                _label_(i).gambar = Image.FromStream(gambarLogo)
            End Using
        Next
        Using CetakLabel As New FormCetakLabel
            CetakLabel._label_ = _label_
            CetakLabel.ShowDialog()
            CetakLabel.Dispose()
        End Using
        CobaBersihkanMemori()
    End Sub

    Public Sub F6_BarangMasuk()
        If DataGridView1.Rows.Count <> 0 Then
            DataGridView1.CurrentRow = DataGridView1.Rows(DataGridView1.Rows.Count - 1)
            DataGridView1.CurrentColumn = DataGridView1.Columns(3)
            edit_cell()
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles DataGridView1.KeyDown
        If DataGridView1.RowCount <> 0 Then
            If e.KeyCode = Keys.Delete Then
                If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yakin ingin menghapus data ini ?", DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells("kode").Value.ToString, MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = DialogResult.Yes Then
                    DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
                End If
            ElseIf e.KeyCode = Keys.F5 Then
                edit_cell()
            ElseIf e.KeyCode = Keys.F6 Then
                F6_BarangMasuk()
            End If
        End If
    End Sub

    Private Sub edit_cell()
        If DataGridView1.CurrentCell.ColumnIndex = 3 Then
            DataGridView1.BeginEdit()
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        edit_cell()
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As GridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        'edit_cell()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As GridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 9 Then
            If e.RowIndex >= 0 Then
                Using CetakLabel As New FormCetakLabel
                    Dim _label_(0) As _Label
                    _label_(0).N = CInt(DataGridView1.Rows(e.RowIndex).Cells("stok").Value.ToString.Replace("-", ""))
                    _label_(0).lbl_kode = CStr(DataGridView1.Rows(e.RowIndex).Cells("kode").Value)
                    _label_(0).nm_brg = CStr(DataGridView1.Rows(e.RowIndex).Cells("nama").Value)
                    _label_(0).id_barang = CStr(DataGridView1.Rows(e.RowIndex).Cells("kode").Value)
                    _label_(0).h_grosir = CStr(DataGridView1.Rows(e.RowIndex).Cells("harga_grosir").Value)
                    _label_(0).h_retail = CStr(DataGridView1.Rows(e.RowIndex).Cells("harga_retail").Value)
                    _label_(0).nama_perusahaan = NamaTokoShort
                    Using gambarLogo As New System.IO.MemoryStream(LogoPerusahaan)
                        _label_(0).gambar = Image.FromStream(gambarLogo)
                        CetakLabel._label_ = _label_
                    End Using
                    CetakLabel.ShowDialog()
                    CetakLabel.Dispose()
                End Using
                CobaBersihkanMemori()
            End If
        End If
    End Sub

    Private Sub DataGridView1_RowsChanged(ByVal sender As Object, ByVal e As GridViewCollectionChangedEventArgs) Handles DataGridView1.RowsChanged
        hitung_all()
    End Sub


    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As CellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.CellElement.ColumnInfo.Name = "no" Then
            e.CellElement.Text = CStr(e.CellElement.RowIndex + 1)
        End If
        If e.ColumnIndex = 4 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub TextBox_NamaBrg_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_NamaBrg.Leave
        TextBox_NamaBrg.Text = CapitalizeEachWord(TextBox_NamaBrg.Text)
    End Sub

    Private Sub Button_reset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_reset.Click
        TextBox_KodeBrg.Text = ""
        ComboBox_TipeBrg.SelectedIndex = 0
        ComboBox_TipeBrg.Focus()
    End Sub

    Private Sub ComboBox_TipeBrg_PopupOpening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ComboBox_TipeBrg.PopupOpening
        ComboBox_TipeBrg.Items.Clear()
        ComboBox_TipeBrg.Text = "< Pilih Tipe >"
        Using dt As DataTable = Tabel_tipe_barangTableAdapter.GetData()
            ComboBox_TipeBrg.Items.Add("< Pilih Tipe >")
            For n As Integer = 0 To dt.Rows.Count - 1
                ComboBox_TipeBrg.Items.Add(dt.Rows(n).Item(0).ToString)
            Next
        End Using
    End Sub

    Private Sub TextBox_Stok_Tambah_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_Stok_Tambah.Enter
        TextBox_Stok_Tambah.SelectAll()
    End Sub

    Private Sub TextBox_HargaModal_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_HargaModal.Enter
        TextBox_HargaModal.SelectAll()
    End Sub

    Private Sub TextBox_HargaGrosir_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_HargaGrosir.Enter
        TextBox_HargaGrosir.SelectAll()
    End Sub

    Private Sub TextBox_HargaRetail_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_HargaRetail.Enter
        If SettingPreferensi.BarangMasuk.IsiHargaRetail = "Auto" Then
            If TextBox_HargaGrosir.Text <> "" Or TextBox_HargaGrosir.Text <> "0" Then
                TextBox_HargaRetail.Text = CInt(CInt(TextBox_HargaGrosir.Text) + ((CInt(TextBox_HargaGrosir.Text) * SettingPreferensi.BarangMasuk.AutoRetail) / 100))
            End If
        End If
        TextBox_HargaRetail.SelectAll()
    End Sub

    Private Sub RichTextBox_Keterangan_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles RichTextBox_Keterangan.Leave
        Me.RichTextBox_Keterangan.Text = CapitalizeEachWord(Me.RichTextBox_Keterangan.Text)
    End Sub

    Private Sub TextBox_Stok_Tambah_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_Stok_Tambah.Leave
        If TextBox_Stok_Tambah.Text = "" Then
            Me.TextBox_Stok_Tambah.Text = "0"
        End If
        Me.TextBox_Stok_Awal.Text = ubahtocurrency(TextBox_Stok_Awal.Text)
    End Sub

    Private Sub TextBox_HargaModal_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_HargaModal.Leave
        If TextBox_HargaModal.Text = "" Then
            Me.TextBox_HargaModal.Text = "0"
        End If
        Me.TextBox_HargaModal.Text = ubahtocurrency(TextBox_HargaModal.Text)
    End Sub

    Private Sub TextBox_HargaGrosir_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_HargaGrosir.Leave
        If TextBox_HargaGrosir.Text = "" Then
            Me.TextBox_HargaGrosir.Text = "0"
        End If
        Me.TextBox_HargaGrosir.Text = ubahtocurrency(TextBox_HargaGrosir.Text)
    End Sub

    Private Sub TextBox_HargaRetail_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_HargaRetail.Leave
        If TextBox_HargaRetail.Text = "" Then
            Me.TextBox_HargaRetail.Text = "0"
        End If
        Me.TextBox_HargaRetail.Text = ubahtocurrency(TextBox_HargaRetail.Text)
    End Sub

    Private Sub TextBox_NamaBrg_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox_NamaBrg.Enter
        If TextBox_KodeBrg.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show("ID barang harus dipilih terlebih dahulu")
            'Button_kodelama.Select()
        End If
    End Sub

    Private Sub TextBox_NamaBrg_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox_NamaBrg.KeyPress
        If TextBox_KodeBrg.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show("ID barang harus dipilih terlebih dahulu")
            e.Handled = True
        End If
    End Sub

    Dim sementara As Integer = 0
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As GridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If e.ColumnIndex = 4 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            If DivKoefisien = DivCoef._1 Then
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl((DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) * 1000
            End If
        End If

        If CInt(e.Value) = 0 Then
            If Telerik.WinControls.RadMessageBox.Show("Apakah Anda ingin menghapus data ini ?", DataGridView1.Rows(e.RowIndex).Cells("kode").Value.ToString, MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = DialogResult.Yes Then
                DataGridView1.Rows(e.RowIndex).Delete()
            Else
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = sementara
            End If
        End If
        DataGridView1.CurrentRow.Cells("total_stok").Value = (CInt(DataGridView1.CurrentRow.Cells("total_stok").Value) - sementara) + CInt(DataGridView1.CurrentRow.Cells("stok").Value)
        'End If
        sementara = Nothing
    End Sub

    Private Sub DataGridView1_CellBeginEdit(ByVal sender As Object, ByVal e As GridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        sementara = CInt(DataGridView1.CurrentRow.Cells(3).Value)
        If e.ColumnIndex = 4 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            If DivKoefisien = DivCoef._1 Then
                DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl((DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) / 1000
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles DataGridView1.CellEditorInitialized
        Dim spineditor As Telerik.WinControls.UI.GridSpinEditor = TryCast(Me.DataGridView1.ActiveEditor, Telerik.WinControls.UI.GridSpinEditor)
        If spineditor IsNot Nothing Then
            If e.ColumnIndex = 4 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
                spineditor.DecimalPlaces = Desimal()
            End If
        End If
    End Sub

    'Dim complete_load_radmulti2 As Boolean = False
    Private Sub RadMultiColumnComboBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMultiColumnComboBox2.Enter
        Using dt As DataTable = Tabel_supplierTableAdapter.GetData()
            RadMultiColumnComboBox2.MultiColumnComboBoxElement.Rows.Clear()
            For i = 0 To dt.Rows.Count - 1
                RadMultiColumnComboBox2.MultiColumnComboBoxElement.Rows.Add(dt.Rows(i).Item("id_supplier"), dt.Rows(i).Item("nama"), dt.Rows(i).Item("asal"))
            Next
            RadMultiColumnComboBox2.Text = "< Pilih Supplier >"
            label_name_supplier.Text = "no_name"
            alamatSupplier = ""
            asalSupplier = ""
            Panel1.Enabled = False
            Panel2.Enabled = False
            'complete_load_radmulti2 = True
        End Using
    End Sub

    Private Sub RadMultiColumnComboBox2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMultiColumnComboBox2.Leave
        If RadMultiColumnComboBox2.Text = "" Then
            RadMultiColumnComboBox2.Text = "< Pilih Supplier >"
        End If
        'complete_load_radmulti2 = False
    End Sub

    Private Sub RadMultiColumnComboBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadMultiColumnComboBox2.TextChanged
        'If complete_load_radmulti2 = True Then
        Using dt As DataTable = Me.Tabel_supplierTableAdapter.GetData_based_id_supplier(RadMultiColumnComboBox2.Text.ToString())
            If dt.Rows.Count <> 0 Then
                alamatSupplier = CStr(dt.Rows(0).Item("alamat"))
                asalSupplier = CStr(dt.Rows(0).Item("asal"))
                label_name_supplier.Text = dt.Rows(0).Item("nama").ToString & " di " & alamatSupplier & " , " & asalSupplier
                Panel1.Enabled = True
                Panel2.Enabled = True
            Else
                label_name_supplier.Text = "no_name"
                alamatSupplier = ""
                asalSupplier = ""
                Panel1.Enabled = False
                Panel2.Enabled = False
            End If
        End Using
        'End If
    End Sub

    Private Sub Button_kodemanual_Click(sender As Object, e As EventArgs) Handles Button_kodemanual.Click

        Using InputIDManual As New FormInputIDManual
            If InputIDManual.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                Dim st As Integer = InputIDManual.StatusBarang
                TextBox_KodeBrg.Text = InputIDManual.KodeBarangFix
                ComboBox_TipeBrg.Text = InputIDManual.TipeBarang
                If st = 0 Then
                    TextBox_NamaBrg.Focus()
                Else
                    TextBox_Stok_Tambah.Focus()
                End If
            End If
        End Using
        CobaBersihkanMemori()
    End Sub
End Class