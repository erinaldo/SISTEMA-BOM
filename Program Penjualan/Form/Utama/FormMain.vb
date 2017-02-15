Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

'Imports ComponentFactory..Toolkit

Public Class FormMain
    Friend uc_p(0) As UC_Penjualan
    Friend tabpages_penjualan(0) As Telerik.WinControls.UI.RadPageViewPage
    Friend uc_pf(0) As UC_Penjualan
    Friend tabpages_penjualanfast(0) As Telerik.WinControls.UI.RadPageViewPage
    Friend uc_po(0) As UC_Penjualan
    Friend tabpages_penjualanorder(0) As Telerik.WinControls.UI.RadPageViewPage
    Friend uc_b(0) As UC_BarangMasuk
    Friend tabpages_brg_masuk(0) As Telerik.WinControls.UI.RadPageViewPage
    Dim pn As Integer = 0
    Dim pf As Integer = 0
    Dim po As Integer = 0

    Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " v." & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
    End Sub
    Private Sub FormMain_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'BackgroundWorker2.RunWorkerAsync()
        cek_Perusahaan()
        cek_Authority()
        cek_status_transakasi()
        load_set_label()
        LoadPreferensiPenjualanFromDatabase()
        LoadPreferensiOrderFromDatabase()
        LoadPreferensiBarangMasukFromDatabase()
        LoadDivKoefisien()
        'BackgroundWorker1.RunWorkerAsync()
        'fitur load session ditunda dulu
        'loadsessions()
        Dim host As Net.IPHostEntry
        Dim hostname As String
        Dim ips(1) As String
        hostname = My.Computer.Name
        host = Net.Dns.GetHostEntry(hostname)
        'Label2.Text = "Kasir " & host.AddressList(1).ToString
        Dim i = 0
        For Each ip As Net.IPAddress In host.AddressList
            If ip.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                ips(i) = ip.ToString
                i = i + 1
            End If
        Next
        Label2.Text = "KASIR " & get_last_number_ip(ips(0))
        load_detail_harian()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using modepenjualan As New FormModePenjualan
            Select Case modepenjualan.ShowDialog
                Case Windows.Forms.DialogResult.OK
                    tabpenjualan_normal()
                Case Windows.Forms.DialogResult.Retry
                    tabpenjualan_fast()
                Case Windows.Forms.DialogResult.Ignore
                    tabpenjualan_order()
                Case Else
                    'MessageBox.Show("Gak Kebaca")
            End Select
            modepenjualan.Dispose()
            CobaBersihkanMemori()
        End Using
        
    End Sub

    Private Sub tabpenjualan_normal()
        If SettingAuthority.PenjualanAndBarangMasuk.PenjualanNormal = True Then
            If uc_p.Length - 1 < pn Then
                ReDim Preserve uc_p(UBound(uc_p) + 1)
                ReDim Preserve tabpages_penjualan(UBound(tabpages_penjualan) + 1)
            End If
            tabpages_penjualan(pn) = New Telerik.WinControls.UI.RadPageViewPage
            tabpages_penjualan(pn).AutoScroll = True
            tabpages_penjualan(pn).BackColor = Color.White
            uc_p(pn) = New UC_Penjualan()
            uc_p(pn).tipe = UC_Penjualan.TipePenjualan.SmallNota
            tabpages_penjualan(pn).Controls.Add(uc_p(pn))
            tabpages_penjualan(pn).Text = "Penjualan (Small Nota) " & pn + 1
            TabControl1.Pages.Add(tabpages_penjualan(pn))
            TabControl1.SelectedPage = tabpages_penjualan(pn)
            pn += 1
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub tabpenjualan_fast()
        If SettingAuthority.PenjualanAndBarangMasuk.PenjualanFast = True Then
            If uc_pf.Length - 1 < pf Then
                ReDim Preserve uc_pf(UBound(uc_pf) + 1)
                ReDim Preserve tabpages_penjualanfast(UBound(tabpages_penjualanfast) + 1)
            End If
            tabpages_penjualanfast(pf) = New Telerik.WinControls.UI.RadPageViewPage
            tabpages_penjualanfast(pf).AutoScroll = True
            tabpages_penjualanfast(pf).BackColor = Color.White
            uc_pf(pf) = New UC_Penjualan()
            uc_pf(pf).tipe = UC_Penjualan.TipePenjualan.BigNota
            tabpages_penjualanfast(pf).Controls.Add(uc_pf(pf))
            tabpages_penjualanfast(pf).Text = "Penjualan (Big Nota) " & pf + 1
            TabControl1.Pages.Add(tabpages_penjualanfast(pf))
            TabControl1.SelectedPage = tabpages_penjualanfast(pf)
            pf += 1
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub tabpenjualan_order()
        If SettingAuthority.PenjualanAndBarangMasuk.PenjualanOrder = True Then
            If uc_po.Length - 1 < po Then
                ReDim Preserve uc_po(UBound(uc_po) + 1)
                ReDim Preserve tabpages_penjualanorder(UBound(tabpages_penjualanorder) + 1)
            End If
            tabpages_penjualanorder(po) = New Telerik.WinControls.UI.RadPageViewPage
            tabpages_penjualanorder(po).AutoScroll = True
            tabpages_penjualanorder(po).BackColor = Color.White
            uc_po(po) = New UC_Penjualan()
            uc_po(po).tipe = UC_Penjualan.TipePenjualan.Order
            tabpages_penjualanorder(po).Controls.Add(uc_po(po))
            tabpages_penjualanorder(po).Text = "Penjualan (Order Barang) " & po + 1
            TabControl1.Pages.Add(tabpages_penjualanorder(po))
            TabControl1.SelectedPage = tabpages_penjualanorder(po)
            po += 1
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub loadsessions()
        Dim c() = IO.Directory.GetFiles("Sessions")
        'MessageBox.Show(c.Count)
        For Each ia In c
            'MessageBox.Show(ia)
            Dim s As String
            Dim i As Integer = 0
            Dim mulai As Boolean = False

            Dim databm(8, 0) As String
            Dim datapn(10, 0) As String
            Dim IDSupllier As String = ""
            Dim IDCustomer As String = ""
            Dim NamaSales As String = ""
            Using read As New IO.StreamReader(ia)
                Dim index As Integer = 0
                While Not read.EndOfStream
                    s = read.ReadLine
                    'MessageBox.Show(s)

                    'If ia.Contains("BM") Then
                    '    If Sesi.GetName(s) = "IDSupplier" Then
                    '        IDSupllier = Sesi.GetValue(s)
                    '    End If
                    '    If Sesi.IsSection(s) Then
                    '        mulai = True
                    '        i = 0
                    '        If CInt(Sesi.GetSection(s)) <> 0 Then
                    '            ReDim Preserve databm(8, CInt(Sesi.GetSection(s)))
                    '        End If
                    '    End If
                    '    If mulai = True And Not Sesi.IsSection(s) And Not Sesi.GetName(s) = "IDSupplier" Then
                    '        databm(i, index) = Sesi.GetValue(s)
                    '        'MessageBox.Show(i & " " & index & " " & data(i, index))
                    '        i = i + 1
                    '        If i = 9 Then
                    '            mulai = False
                    '            index = index + 1
                    '        End If
                    '    End If
                    'Else
                    '    If Sesi.IsSection(s) Then

                    '    End If
                    'End If


                End While
                If ia.Contains("BM") Then
                    tabbarangmasuk(True, ia.Replace("Sessions", "").Replace("\", "").Replace(".txt", ""), IDSupllier, databm)
                End If
            End Using
            FileIO.FileSystem.DeleteFile(ia)
        Next
    End Sub

    Private Sub load_set_label()
        Using dt As DataTable = Me.Tabe_set_labelTableAdapter1.GetData()
            SettingLabel.StatNamaPerusahaan = CBool(dt.Rows(0).Item("stat_nama_perusahaan"))
            SettingLabel.LogoPerusahaan = CBool(dt.Rows(0).Item("logo_perusahaan"))
            SettingLabel.NamaBarang = CBool(dt.Rows(0).Item("nama_barang"))
            SettingLabel.IDBarang = CBool(dt.Rows(0).Item("id_barang"))
            SettingLabel.Barcode = CBool(dt.Rows(0).Item("barcode"))
            SettingLabel.HargaGrosirEnkripsi = CBool(dt.Rows(0).Item("harga_grosir"))
            SettingLabel.HargaRetail = CBool(dt.Rows(0).Item("harga_retail"))
            SettingLabel.NamaPerusahaan = CStr(dt.Rows(0).Item("nama_perusahaan"))
            NamaTokoShort = SettingLabel.NamaPerusahaan
        End Using
    End Sub

    Public Sub load_detail_harian()
        Using dt As DataTable = Me.Tabel_Harian.GetDataBy(tgltoday)
            If dt.Rows(0).Item(0).ToString <> "" And dt.Rows(0).Item(1).ToString <> "" Then
                FormMainLabelPenjualanHarianLabel.Text = ubahtocurrencybyDiv(dt.Rows(0).Item(0))
                FormMainLabelReturHarianLabel.Text = ubahtocurrencybyDiv(dt.Rows(0).Item(1))
                FormMainLabelPendapatanHarianLabel.Text = ubahtocurrencybyDiv(dt.Rows(0).Item(2))
            End If
        End Using
    End Sub

    Private Sub cek_status_transakasi()
        RadLabel10.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryBerhasil(CDate(tgltoday), "%Small%"))
        RadLabel12.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryBerhasil(CDate(tgltoday), "%Big%"))
        RadLabel16.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryBerhasil(CDate(tgltoday), "%Order%"))
        RadLabel14.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryBerhasil(CDate(tgltoday), "%Barang%"))
        RadLabel18.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryBerhasil(CDate(tgltoday), "%"))

        RadLabel7.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryGagal(CDate(tgltoday), "%Small%"))
        RadLabel11.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryGagal(CDate(tgltoday), "%Big%"))
        RadLabel13.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryGagal(CDate(tgltoday), "%Order%"))
        RadLabel15.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryGagal(CDate(tgltoday), "%Barang%"))
        RadLabel17.Text = CStr(Me.Tabel_status_transaksiTableAdapter1.ScalarQueryGagal(CDate(tgltoday), "%"))
    End Sub

    Private Sub cek_Perusahaan()
        Using dt As DataTable = Me.Tabel_perusahaanTableAdapter1.GetData()
            NamaToko = CStr(dt.Rows(0).Item("nama_toko"))
            KotaToko = CStr(dt.Rows(0).Item("alamat"))
            AlamatLengkapToko = CStr(dt.Rows(0).Item("alamat_lengkap"))
            NopeToko = CStr(dt.Rows(0).Item("telp"))
            CatatanKaki = CStr(dt.Rows(0).Item("catatan_kaki"))
            CatatanHeader = CStr(dt.Rows(0).Item("Catatan"))
            LogoPerusahaan = CType(dt.Rows(0).Item("logo_perusahaan"), Byte())
            Using gambarLogo As New System.IO.MemoryStream(LogoPerusahaan)
                Me.PictureBox1.BackgroundImage = System.Drawing.Image.FromStream(gambarLogo)
            End Using
        End Using
        Me.RadPanel3.Text = NamaToko
    End Sub

    Public Sub cek_Authority()

        Using dt As DataTable = Me.Tabel_set_authorityTableAdapter.GetDataByTipeAuthority(StatusHakAkses)
            'Setting Counter
            SettingAuthority.SettingCounter.UbahInfoPerusahaan = CBool(dt.Rows(0).Item("infoperusahaan"))
            SettingAuthority.SettingCounter.TambahSales = CBool(dt.Rows(0).Item("tambahsales"))
            SettingAuthority.SettingCounter.EditHapusSales = CBool(dt.Rows(0).Item("editsales"))
            SettingAuthority.SettingCounter.TambahTipeBarang = CBool(dt.Rows(0).Item("tambahtipe"))
            SettingAuthority.SettingCounter.EditHapusTipeBarang = CBool(dt.Rows(0).Item("edittipe"))
            SettingAuthority.SettingCounter.SettingLabel = CBool(dt.Rows(0).Item("settinglabel"))
            SettingAuthority.SettingCounter.Tema = CBool(dt.Rows(0).Item("tema"))
            SettingAuthority.SettingCounter.ClientServer = CBool(dt.Rows(0).Item("clientserver"))
            'Manajemen DB
            SettingAuthority.ManagementDB.BackupDB = CBool(dt.Rows(0).Item("backupdb"))
            SettingAuthority.ManagementDB.RestoreDB = CBool(dt.Rows(0).Item("restoredb"))
            SettingAuthority.ManagementDB.ExportDB = CBool(dt.Rows(0).Item("exportdb"))
            SettingAuthority.ManagementDB.ImportDB = CBool(dt.Rows(0).Item("importdb"))
            'Log Activity
            SettingAuthority.LogActivity = CBool(dt.Rows(0).Item("logactivity"))
            'Customer & Supplier
            SettingAuthority.CustomerAndSupplier.TambahCustomer = CBool(dt.Rows(0).Item("tambahcustomer"))
            SettingAuthority.CustomerAndSupplier.LihatDataCustomer = CBool(dt.Rows(0).Item("lihatdatacustomer"))
            SettingAuthority.CustomerAndSupplier.EditCustomer = CBool(dt.Rows(0).Item("editcustomer"))
            SettingAuthority.CustomerAndSupplier.PrintDataCustomer = CBool(dt.Rows(0).Item("printcustomer"))
            SettingAuthority.CustomerAndSupplier.TambahSupplier = CBool(dt.Rows(0).Item("tambahsupplier"))
            SettingAuthority.CustomerAndSupplier.LihatDataSupplier = CBool(dt.Rows(0).Item("lihatlistdatasupplier"))
            SettingAuthority.CustomerAndSupplier.EditSupplier = CBool(dt.Rows(0).Item("editsupplier"))
            SettingAuthority.CustomerAndSupplier.PrintDataSupplier = CBool(dt.Rows(0).Item("printsupplier"))
            'Produk
            SettingAuthority.Product.LihatDataProduk = CBool(dt.Rows(0).Item("lihatproduk"))
            SettingAuthority.Product.EditDataProduk = CBool(dt.Rows(0).Item("editproduk"))
            SettingAuthority.Product.PrintDataProduk = CBool(dt.Rows(0).Item("printproduk"))
            SettingAuthority.Product.LihatProfit = CBool(dt.Rows(0).Item("lihatprofit"))
            SettingAuthority.Product.LihatTotalPersediaan = CBool(dt.Rows(0).Item("lihattotalpersediaan"))
            SettingAuthority.Product.CetakLabel = CBool(dt.Rows(0).Item("cetaklabel"))
            SettingAuthority.Product.EditModalTerjualProfit = CBool(dt.Rows(0).Item("editmodalterjualprofit"))
            'Penjualan & Barang Masuk
            SettingAuthority.PenjualanAndBarangMasuk.PenjualanNormal = CBool(dt.Rows(0).Item("penjualannormal"))
            SettingAuthority.PenjualanAndBarangMasuk.PenjualanFast = CBool(dt.Rows(0).Item("penjualanfast"))
            SettingAuthority.PenjualanAndBarangMasuk.PenjualanOrder = CBool(dt.Rows(0).Item("penjualanorder"))
            SettingAuthority.PenjualanAndBarangMasuk.BarangMasuk = CBool(dt.Rows(0).Item("barangmasuk"))
            SettingAuthority.PenjualanAndBarangMasuk.TipePenjualanGrosir = CBool(dt.Rows(0).Item("tipegrosir"))
            SettingAuthority.PenjualanAndBarangMasuk.TipePenjualanRetail = CBool(dt.Rows(0).Item("tiperetail"))
            SettingAuthority.PenjualanAndBarangMasuk.DiskonPenjualan = CBool(dt.Rows(0).Item("diskonpenjualan"))
            SettingAuthority.PenjualanAndBarangMasuk.ReturPenjualan = CBool(dt.Rows(0).Item("returpenjualan"))
            SettingAuthority.PenjualanAndBarangMasuk.HutangCustomer = CBool(dt.Rows(0).Item("hutangcustomer"))
            SettingAuthority.PenjualanAndBarangMasuk.JualLebihStok = CBool(dt.Rows(0).Item("juallebihstok"))
            'Laporan
            SettingAuthority.Laporan.LaporanPenjualanHarian = CBool(dt.Rows(0).Item("laporanpenjualanharian"))
            SettingAuthority.Laporan.LaporanDetailPenjualan = CBool(dt.Rows(0).Item("laporandetailpenjualanharian"))
            SettingAuthority.Laporan.LaporanPenjualanAll = CBool(dt.Rows(0).Item("laporanpenjualanall"))
            SettingAuthority.Laporan.LaporanPenjualanFilter = CBool(dt.Rows(0).Item("laporanpenjualanfilter"))
            SettingAuthority.Laporan.LaporanProfit = CBool(dt.Rows(0).Item("laporanprofit"))
            SettingAuthority.Laporan.LaporanBarangMasukAll = CBool(dt.Rows(0).Item("laporanbrgmasukall"))
            SettingAuthority.Laporan.LaporanBarangMasukFilter = CBool(dt.Rows(0).Item("laporanbrgmasukfilter"))
            SettingAuthority.Laporan.LaporanHutangCustomer = CBool(dt.Rows(0).Item("laporanhutangcustomer"))
            SettingAuthority.Laporan.LaporanBestSellerProfit = CBool(dt.Rows(0).Item("laporanbestseller"))
            SettingAuthority.Laporan.CetakLaporan = CBool(dt.Rows(0).Item("printlaporan"))
            SettingAuthority.Laporan.SeleksiTanggalLaporan = CBool(dt.Rows(0).Item("seleksitanggallaporan"))
            'Exit
            SettingAuthority.TutupCounter = CBool(dt.Rows(0).Item("tutupcounter"))
        End Using

        If SettingAuthority.Laporan.LaporanPenjualanHarian = False Then
            Panel_lapHarian.Visible = False
        Else
            Panel_lapHarian.Visible = True
        End If
    End Sub

    Private Sub simpan_sesi()
        'If TabControl1.Pages.Item(i).Text.Contains("Barang Masuk") Then
        '    For j = 0 To uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.RowCount - 1
        '        Sesi.SaveSessionBrgMasuk(j, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).Label_Invoice.Text, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).RadMultiColumnComboBox2.Text, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("kode").Value, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("nama").Value, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("tipe_barang").Value, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("total_stok").Value, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("stok").Value, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("harga_modal").Value, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("harga_grosir").Value, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("harga_retail").Value, _
        '                                 uc_b(CInt(TabControl1.Pages.Item(i).Text.Replace("Barang Masuk ", "")) - 1).DataGridView1.Rows(j).Cells("keterangan").Value)
        '    Next
        'ElseIf TabControl1.Pages.Item(i).Text.Contains("Small Nota") Then
        '    For j = 0 To uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.RowCount - 1
        '        Sesi.SaveSessionPenjualan(j, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Label_Invoice.Text, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(1).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(2).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(3).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(4).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(5).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(6).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(7).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(8).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(9).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(10).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(11).Value, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).id_customer_TextBox.Text, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).nama_sales_ComboBox.Text, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).label_tipepenjualan.Text, _
        '                                  uc_p(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).tipe)
        '    Next
        'ElseIf TabControl1.Pages.Item(i).Text.Contains("Big Nota") Then
        '    For j = 0 To uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.RowCount - 1
        '        Sesi.SaveSessionPenjualan(j, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Label_Invoice.Text, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(1).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(2).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(3).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(4).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(5).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(6).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(7).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(8).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(9).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(10).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(11).Value, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).id_customer_TextBox.Text, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).nama_sales_ComboBox.Text, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).label_tipepenjualan.Text, _
        '                                  uc_pf(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).tipe)
        '    Next
        'ElseIf TabControl1.Pages.Item(i).Text.Contains("Order") Then
        '    For j = 0 To uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.RowCount - 1
        '        Sesi.SaveSessionPenjualan(j, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Label_Invoice.Text, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(1).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(2).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(3).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(4).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(5).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(6).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(7).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(8).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(9).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(10).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Grid_Penjualan.Rows(j).Cells(11).Value, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).id_customer_TextBox.Text, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).nama_sales_ComboBox.Text, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).label_tipepenjualan.Text, _
        '                                  uc_po(CInt(TabControl1.Pages.Item(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).tipe)
        '    Next
        'End If
    End Sub

    Private Sub ProsesSebelumKeluar()
        Try
            For i As Integer = 0 To TabControl1.Pages.Count - 1
                Me.Tabel_status_transaksiTableAdapter1.InsertQuery(CDate(tgltoday), "F-" + TabControl1.Pages.Item(i).Text, "Gagal")

                'simpan_sesi()

            Next
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Program Penjualan", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        End Try
        Me.Tabel_logTableAdapter1.InsertQuery(Label_StatusID.Text, "Logout", "Logout")
    End Sub

    Private Sub FormMain_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SettingAuthority.TutupCounter = False Then
            FormDialogPassword.tipe = FormDialogPassword.tipekonfirmasi.Keluar
            Dim hasil As DialogResult = FormDialogPassword.ShowDialog()
            If hasil = Windows.Forms.DialogResult.Yes Then
                Dim resullt = Telerik.WinControls.RadMessageBox.Show("Apakah Anda ingin menutup aplikasi ini?", "Program Penjualan", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question)
                If resullt = Windows.Forms.DialogResult.No Then
                    e.Cancel = True
                Else
                    ProsesSebelumKeluar()
                End If
            Else
                e.Cancel = True
            End If
        Else
            Dim resullt = Telerik.WinControls.RadMessageBox.Show("Apakah Anda ingin menutup aplikasi ini?", "Program Penjualan", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question)
            If resullt = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                ProsesSebelumKeluar()
            End If
        End If
    End Sub

    Private Sub FormMain_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
        'Application.Exit()
    End Sub

    Dim bm As Integer = 0
    Private Sub Button3_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        If SettingAuthority.PenjualanAndBarangMasuk.BarangMasuk = True Then
            tabbarangmasuk()
        Else
            aksesdenied()
        End If
    End Sub

    Private Overloads Sub tabbarangmasuk()
        If uc_b.Length - 1 < bm Then
            ReDim Preserve uc_b(UBound(uc_b) + 1)
            ReDim Preserve tabpages_brg_masuk(UBound(tabpages_brg_masuk) + 1)
        End If
        tabpages_brg_masuk(bm) = New Telerik.WinControls.UI.RadPageViewPage()
        tabpages_brg_masuk(bm).AutoScroll = True
        tabpages_brg_masuk(bm).BackColor = Color.White
        uc_b(bm) = New UC_BarangMasuk()
        tabpages_brg_masuk(bm).Controls.Add(uc_b(bm))
        tabpages_brg_masuk(bm).Text = "Barang Masuk " & bm + 1
        TabControl1.Pages.Add(tabpages_brg_masuk(bm))
        TabControl1.SelectedPage = tabpages_brg_masuk(bm)
        bm += 1
    End Sub

    Private Overloads Sub tabbarangmasuk(ByVal IsSession As Boolean, ByVal Invoice As String, ByVal IDSupplier As String, ByVal Data(,) As String)
        If uc_b.Length - 1 < bm Then
            ReDim Preserve uc_b(UBound(uc_b) + 1)
            ReDim Preserve tabpages_brg_masuk(UBound(tabpages_brg_masuk) + 1)
        End If
        tabpages_brg_masuk(bm) = New Telerik.WinControls.UI.RadPageViewPage()
        tabpages_brg_masuk(bm).AutoScroll = True
        tabpages_brg_masuk(bm).BackColor = Color.White
        uc_b(bm) = New UC_BarangMasuk()
        uc_b(bm).AdaSession = IsSession
        If IsSession = True Then
            uc_b(bm).Label_Invoice.Text = Invoice
            uc_b(bm).RadMultiColumnComboBox2.Text = IDSupplier
            For i = 0 To Data.GetUpperBound(1)
                uc_b(bm).DataGridView1.Rows.Add("", Data(0, i), Data(1, i), Data(2, i), Data(3, i), Data(4, i), Data(5, i), Data(6, i), tgltoday, "Cetak", Data(7, i), Data(8, i), "")
            Next
        End If
        tabpages_brg_masuk(bm).Controls.Add(uc_b(bm))
        tabpages_brg_masuk(bm).Text = "Barang Masuk " & bm + 1
        TabControl1.Pages.Add(tabpages_brg_masuk(bm))
        TabControl1.SelectedPage = tabpages_brg_masuk(bm)
        bm += 1
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        If SettingAuthority.Laporan.LaporanPenjualanFilter = True Then
            Using FormLaporanTransaksiBarangMasuk As New FormLapTransaksiBarangMasuk
                FormLaporanTransaksiBarangMasuk.ShowDialog()
                FormLaporanTransaksiBarangMasuk.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        If SettingAuthority.Laporan.LaporanPenjualanAll = True Then
            Using FormLaporanTransaksiPenjualan As New FormLapTransaksiPenjualan
                FormLaporanTransaksiPenjualan.ShowDialog()
                FormLaporanTransaksiPenjualan.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        If SettingAuthority.Laporan.LaporanDetailPenjualan = True Then
            Using FormHarianDetail As New FormDetailHarian
                FormHarianDetail.ShowDialog()
                FormHarianDetail.Dispose()
                CobaBersihkanMemori()
            End Using
            CobaBersihkanMemori()
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub RadButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton4.Click
        tabpenjualan_normal()
    End Sub

    Private Sub RadButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton1.Click
        tabpenjualan_fast()
    End Sub

    Private Sub RadButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton2.Click
        tabpenjualan_order()
    End Sub

    Private Sub RadButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RadButton3.Click
        If SettingAuthority.PenjualanAndBarangMasuk.BarangMasuk = True Then
            tabbarangmasuk()
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemSetAuthority_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemSetAuthority.Click
        If StatusHakAkses = "Owner" Then
            Using Settings As New FormSetting
                Settings.RadPageView_Setting.SelectedPage = Settings.Pages_SetAuthority
                Settings.ShowDialog()
                Settings.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemSetAdmin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemSetAdmin.Click
        If StatusHakAkses = "Owner" Then
            Using Settings As New FormSetting
                Settings.RadPageView_Setting.SelectedPage = Settings.Pages_SetAdmin
                Settings.ShowDialog()
                Settings.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemPerusahaan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemPerusahaan.Click
        If SettingAuthority.SettingCounter.UbahInfoPerusahaan = True Then
            Using Settings As New FormSetting
                Settings.RadPageView_Setting.SelectedPage = Settings.Pages_Perusahaan
                Settings.ShowDialog()
                Settings.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemSales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemSales.Click
        Using Settings As New FormSetting
            Settings.RadPageView_Setting.SelectedPage = Settings.Pages_Sales
            Settings.ShowDialog()
            Settings.Dispose()
            CobaBersihkanMemori()
        End Using
    End Sub

    Private Sub MenuItemTipeBarang_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemTipeBarang.Click
        Using Settings As New FormSetting
            Settings.RadPageView_Setting.SelectedPage = Settings.Pages_TipeBrg
            Settings.ShowDialog()
            Settings.Dispose()
            CobaBersihkanMemori()
        End Using
    End Sub

    Private Sub MenuItemSetingLabel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemSetingLabel.Click
        If SettingAuthority.SettingCounter.SettingLabel = True Then
            Using Settings As New FormSetting
                Dim DivTemp As DivCoef = DivKoefisien
                Settings.RadPageView_Setting.SelectedPage = Settings.Pages_SettingLabel
                Settings.ShowDialog()
                Settings.Dispose()
                CobaBersihkanMemori()

                If DivTemp <> DivKoefisien Then
                    For Each UC In uc_p
                        If Not UC Is Nothing Then
                            UC.refreshAftrDivUpdate()
                        End If
                    Next

                    For Each UC In uc_pf
                        If Not UC Is Nothing Then
                            If Not UC Is Nothing Then
                                UC.refreshAftrDivUpdate()
                            End If
                        End If
                    Next

                    For Each UC In uc_po
                        If Not UC Is Nothing Then
                            If Not UC Is Nothing Then
                                UC.refreshAftrDivUpdate()
                            End If
                        End If
                    Next
                End If

            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemExit.Click
        Me.Close()
    End Sub

    Private Sub MenuItemLogActivity_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLogActivity.Click
        If SettingAuthority.LogActivity = True Then
            Using LogAktivitas As New FormLogAktivitas
                LogAktivitas.ShowDialog()
                LogAktivitas.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemTambahCustomer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemTambahCustomer.Click
        If SettingAuthority.CustomerAndSupplier.TambahCustomer = True Then
            Using TambahCustomer As New FormTambahCustomer
                TambahCustomer.ShowDialog()
                TambahCustomer.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemDataCustomer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemDataCustomer.Click
        If SettingAuthority.CustomerAndSupplier.LihatDataCustomer = True Then
            Using ListDataCustomer As New FormListDataCustomer
                ListDataCustomer.ShowDialog()
                ListDataCustomer.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemBackupDatabase_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemBackupDatabase.Click
        If SettingAuthority.ManagementDB.BackupDB = True Then
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim constring As String = Program_Penjualan_V2.My.Settings.TokoConnectionString
                Using conn As MySqlConnection = New MySqlConnection(constring)
                    Using cmd As MySqlCommand = New MySqlCommand()
                        Using mb As MySqlBackup = New MySqlBackup(cmd)
                            cmd.Connection = conn
                            conn.Open()
                            mb.ExportToFile(SaveFileDialog1.FileName)
                            conn.Close()
                        End Using
                    End Using
                End Using
                System.Windows.Forms.Cursor.Current = Cursors.Default
                Telerik.WinControls.RadMessageBox.Show("Sukses Backup Database", "BackUp Database", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemRestoreDatabase_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemRestoreDatabase.Click
        If SettingAuthority.ManagementDB.RestoreDB = True Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                Dim constring As String = Program_Penjualan_V2.My.Settings.TokoConnectionString
                Using conn As MySqlConnection = New MySqlConnection(constring)
                    Using cmd As MySqlCommand = New MySqlCommand()
                        Using mb As MySqlBackup = New MySqlBackup(cmd)
                            cmd.Connection = conn
                            conn.Open()
                            mb.ImportFromFile(OpenFileDialog1.FileName)
                            conn.Close()
                        End Using
                    End Using
                End Using
                System.Windows.Forms.Cursor.Current = Cursors.Default
                Telerik.WinControls.RadMessageBox.Show("Sukse Restore Database", "Restore Database", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemExportToExcel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemExportToExcel.Click
        If SettingAuthority.ManagementDB.ExportDB = True Then
            'isi kode 
            Dim dgv As DataTable = Me.Tabel_barangTableAdapter1.GetData()
            Dim rowsTotal, colsTotal As Short
            Dim I, j, iC As Short
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Dim xlApp As New Excel.Application

            Try
                Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
                Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
                xlApp.Visible = True
                xlApp.WindowState = Excel.XlWindowState.xlMaximized
                rowsTotal = CShort(dgv.Rows.Count - 1)
                colsTotal = CShort(dgv.Columns.Count - 5)

                With (excelWorksheet)
                    .Cells.Select()
                    .Cells.Delete()
                    For iC = 0 To colsTotal
                        .Cells(1, iC + 1).Value = dgv.Columns(iC).Caption
                    Next

                    For I = 0 To rowsTotal
                        For j = 0 To colsTotal
                            .Cells(I + 2, j + 1).value = dgv.Rows(I).Item(j).ToString()
                        Next (j)
                    Next (I)

                    .Rows("1:1").Font.FontStyle = "Bold"
                    .Rows("1:1").Font.Size = 10
                    .Cells.Columns.AutoFit()
                    .Cells.Select()
                    .Cells.EntireColumn.AutoFit()
                    .Cells(1, 1).Select()
                End With
            Catch ex As Exception
                Telerik.WinControls.RadMessageBox.Show("Export Excel Error " & ex.Message, "Excell Error", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
            Finally
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
                xlApp = Nothing

            End Try

        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemImportFromExcel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemImportFromExcel.Click
        If SettingAuthority.ManagementDB.ImportDB = True Then
            'isi kode
            If OpenFileDialog2.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim xlApp As New Excel.Application
                Dim xlworkbook As Excel.Workbook = xlApp.Workbooks.Open(OpenFileDialog2.FileName)
                Dim xlworksheet As Excel.Worksheet = CType(xlworkbook.Worksheets(1), Excel.Worksheet)
                Dim excelRange As Excel.Range = xlworksheet.UsedRange
                Dim valueArray As Object(,) = CType(excelRange.Value2, Object(,))
                Try
                    For i = 2 To valueArray.GetUpperBound(0)
                        Tabel_barangTableAdapter1.InsertQueryFromBackup(CStr(valueArray(i, 1)), CStr(valueArray(i, 2)), CStr(valueArray(i, 3)), CInt(valueArray(i, 4)), CInt(valueArray(i, 5)), CInt(valueArray(i, 6)), CInt(valueArray(i, 7)), valueArray(i, 8).ToString & "", Date.Now, 0, 0)
                    Next
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString, "Import From Excell")
                End Try
                xlApp.Workbooks.Close()
                xlApp.Quit()
                xlApp = Nothing
                Telerik.WinControls.RadMessageBox.Show("Import data sukses.", "Import From Excell", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemTambahSupplier_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemTambahSupplier.Click
        If SettingAuthority.CustomerAndSupplier.TambahSupplier = True Then
            Using TambahSupplier As New FormTambahSupplier
                TambahSupplier.ShowDialog()
                TambahSupplier.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemDataSupplier_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemDataSupplier.Click
        If SettingAuthority.CustomerAndSupplier.LihatDataSupplier = True Then
            Using ListDataSupplier As New FormListDataSupplier
                ListDataSupplier.ShowDialog()
                ListDataSupplier.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemDataProduk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemDataProduk.Click
        If SettingAuthority.Product.LihatDataProduk = True Then
            Using ListDataBarang As New FormListDataBarang
                ListDataBarang.ShowDialog()
                ListDataBarang.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemCetakLabel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemCetakLabel.Click
        If SettingAuthority.Product.CetakLabel Then
            Using LihatCetakLabel As New FormLihatCetakLabel
                LihatCetakLabel.ShowDialog()
                LihatCetakLabel.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemLapPenjualanAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapPenjualanAll.Click
        If SettingAuthority.Laporan.LaporanPenjualanAll = True Then
            Using LapTransaksiPenjualan As New FormLapTransaksiPenjualan
                LapTransaksiPenjualan.ShowDialog()
                LapTransaksiPenjualan.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemLapPenjualanBulanan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapPenjualanBulanan.Click
        If SettingAuthority.Laporan.LaporanPenjualanFilter = True Then
            Using FilterBulanan As New FormFilterBulanan
                FilterBulanan.Jenis = "Penjualan"
                FilterBulanan.Text = "Laporan Penjualan Bulanan"
                FilterBulanan.ShowDialog()
                FilterBulanan.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemLapProfitBulanan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapProfitBulanan.Click
        If SettingAuthority.Laporan.LaporanProfit = True Then
            Using FilterBulanan As New FormFilterBulanan
                FilterBulanan.Jenis = "Profit"
                FilterBulanan.Text = "Laporan Profit Bulanan"
                FilterBulanan.ShowDialog()
                FilterBulanan.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapBarangMasukBln_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapBarangMasukBln.Click
        If SettingAuthority.Laporan.LaporanBarangMasukFilter = True Then
            Using FilterBulanan As New FormFilterBulanan
                FilterBulanan.Jenis = "Barang Masuk"
                FilterBulanan.Text = "Lapoaran Barang Masuk Bulanan"
                FilterBulanan.ShowDialog()
                FilterBulanan.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapPenjualanCustomer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapPenjualanCustomer.Click
        If SettingAuthority.Laporan.LaporanPenjualanFilter = True Then
            Using FilterPeriode As New FormFilterPeriode
                FilterPeriode.Text = "Laporan Penjualan By Customer"
                FilterPeriode.Jenis = "Penjualan"
                FilterPeriode.BY = "Customer"
                FilterPeriode.ShowDialog()
                FilterPeriode.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapPenjualanSales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapPenjualanSales.Click
        If SettingAuthority.Laporan.LaporanPenjualanFilter = True Then
            Using FilterPeriode As New FormFilterPeriode
                FilterPeriode.Text = "Laporan Penjualan By Sales"
                FilterPeriode.Jenis = "Penjualan"
                FilterPeriode.BY = "Sales"
                FilterPeriode.ShowDialog()
                FilterPeriode.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapPenjualanProduk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapPenjualanProduk.Click
        If SettingAuthority.Laporan.LaporanPenjualanFilter = True Then
            Using FilterPeriode As New FormFilterPeriode
                FilterPeriode.Text = "Laporan Penjualan By Produk"
                FilterPeriode.Jenis = "Penjualan"
                FilterPeriode.BY = "Produk"
                FilterPeriode.ShowDialog()
                FilterPeriode.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapBarangMasukAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapBarangMasukAll.Click
        If SettingAuthority.Laporan.LaporanBarangMasukAll = True Then
            Using LapTransaksiBarangMasuk As New FormLapTransaksiBarangMasuk
                LapTransaksiBarangMasuk.ShowDialog()
                LapTransaksiBarangMasuk.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapBarangMasukSupp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapBarangMasukSupp.Click
        If SettingAuthority.Laporan.LaporanPenjualanFilter = True Then
            Using FilterPeriode As New FormFilterPeriode
                FilterPeriode.Text = "Laporan Barang Masuk By Supplier"
                FilterPeriode.Jenis = "Barang Masuk"
                FilterPeriode.BY = "Supplier"
                FilterPeriode.ShowDialog()
                FilterPeriode.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemHutangCustomer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemHutangCustomer.Click
        If SettingAuthority.Laporan.LaporanHutangCustomer = True Then
            Using LaporanHutangCustomer As New FormLaporanHutangCustomer
                LaporanHutangCustomer.ShowDialog()
                LaporanHutangCustomer.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub




    Private Sub MenuItemLapProfitAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapProfitAll.Click
        If SettingAuthority.Laporan.LaporanProfit = True Then
            Using LaporanProfit As New FormLaporanProfit
                LaporanProfit.ShowDialog()
                LaporanProfit.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapProfitCustomer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapProfitCustomer.Click
        If SettingAuthority.Laporan.LaporanProfit = True Then
            Using FilterPeriode As New FormFilterPeriode
                FilterPeriode.Jenis = "Profit"
                FilterPeriode.BY = "Customer"
                FilterPeriode.ShowDialog()
                FilterPeriode.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapProfitSales_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapProfitSales.Click
        If SettingAuthority.Laporan.LaporanProfit = True Then
            Using FilterPeriode As New FormFilterPeriode
                FilterPeriode.Jenis = "Profit"
                FilterPeriode.BY = "Sales"
                FilterPeriode.ShowDialog()
                FilterPeriode.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemLapProfitProduk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemLapProfitProduk.Click
        If SettingAuthority.Laporan.LaporanProfit = True Then
            Using FilterPeriode As New FormFilterPeriode
                FilterPeriode.Jenis = "Profit"
                FilterPeriode.BY = "Produk"
                FilterPeriode.ShowDialog()
                FilterPeriode.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If

    End Sub

    Private Sub MenuItemGantiAdmin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemGantiAdmin.Click
        Using GantiAdmin As New FormGantiAdmin
            GantiAdmin.ShowDialog()
            GantiAdmin.Dispose()
            CobaBersihkanMemori()
        End Using
    End Sub

    Private Sub MenuItemTema_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItemTema.Click
        If SettingAuthority.SettingCounter.Tema = True Then
            Using Settings As New FormSetting
                Settings.RadPageView_Setting.SelectedPage = Settings.Pages_Theme
                Settings.ShowDialog()
                Settings.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub TabControl1_PageRemoved(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadPageViewEventArgs) Handles TabControl1.PageRemoved

        If TabControl1.Pages.Count = 0 Then

            ReDim uc_b(0)
            ReDim tabpages_brg_masuk(0)
            bm = 0

            ReDim uc_p(0)
            ReDim tabpages_penjualan(0)
            pn = 0

            ReDim uc_pf(0)
            ReDim tabpages_penjualanfast(0)
            pf = 0

            ReDim uc_po(0)
            ReDim tabpages_penjualanorder(0)
            po = 0

        Else
            For i = 0 To TabControl1.Pages.Count - 1
                If TabControl1.Pages(i).Text.Contains("Penjualan") Then
                    If TabControl1.Pages(i).Text.Contains("Small Nota") Then
                        If uc_p(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).id_customer_TextBox.Enabled = False Then
                            uc_p(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).totalRp_HutangLama_Label.Text = ubahtocurrencybyDiv(CStr(uc_p(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Tabel_customerTableAdapter.ScalarQueryReturnHutangLama(uc_p(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).id_customer_TextBox.Text)))
                            uc_p(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).totalRp_HutangLama_Label_order.Text = ubahtocurrencybyDiv(CStr(uc_p(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).Tabel_customerTableAdapter.ScalarQueryReturnHutangLama(uc_p(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).id_customer_TextBox.Text)))
                            uc_p(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Small Nota) ", "")) - 1).hitung_total()
                        End If
                    ElseIf TabControl1.Pages(i).Text.Contains("Big Nota") Then
                        If uc_pf(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).id_customer_TextBox.Enabled = False Then
                            uc_pf(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).totalRp_HutangLama_Label.Text = ubahtocurrencybyDiv(CStr(uc_pf(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Tabel_customerTableAdapter.ScalarQueryReturnHutangLama(uc_pf(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).id_customer_TextBox.Text)))
                            uc_pf(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).totalRp_HutangLama_Label_order.Text = ubahtocurrencybyDiv(CStr(uc_pf(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).Tabel_customerTableAdapter.ScalarQueryReturnHutangLama(uc_pf(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).id_customer_TextBox.Text)))
                            uc_pf(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Big Nota) ", "")) - 1).hitung_total()
                        End If
                    ElseIf TabControl1.Pages(i).Text.Contains("Order") Then
                        If uc_po(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).id_customer_TextBox.Enabled = False Then
                            uc_po(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).totalRp_HutangLama_Label.Text = ubahtocurrencybyDiv(CStr(uc_po(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Tabel_customerTableAdapter.ScalarQueryReturnHutangLama(uc_po(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).id_customer_TextBox.Text)))
                            uc_po(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).totalRp_HutangLama_Label_order.Text = ubahtocurrencybyDiv(CStr(uc_po(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).Tabel_customerTableAdapter.ScalarQueryReturnHutangLama(uc_po(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).id_customer_TextBox.Text)))
                            uc_po(CInt(TabControl1.Pages(i).Text.Replace("Penjualan (Order Barang) ", "")) - 1).hitung_total()
                        End If
                    End If
                Else

                End If
            Next
        End If
        load_detail_harian()
        CobaBersihkanMemori()
    End Sub

    Private Sub FormMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyData = Keys.F10 Then
            e.SuppressKeyPress = True
        End If
        If TabControl1.Pages.Count <> 0 Then
            If e.KeyCode = Keys.Escape Then
                If TabControl1.SelectedPage.Text.Contains("Penjualan") Then
                    If TabControl1.SelectedPage.Text.Contains("Small Nota") Then
                        uc_p(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Small Nota) ", "")) - 1).tutup_penjualan()
                    ElseIf TabControl1.SelectedPage.Text.Contains("Big Nota") Then
                        uc_pf(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Big Nota) ", "")) - 1).tutup_penjualan()
                    Else
                        uc_po(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Order Barang) ", "")) - 1).tutup_penjualan()
                    End If
                Else
                    uc_b(CInt(TabControl1.SelectedPage.Text.Replace("Barang Masuk ", "")) - 1).tutup_barangmasuk()
                End If
            ElseIf e.KeyCode = Keys.End Then
                If TabControl1.SelectedPage.Text.Contains("Penjualan") Then
                    If TabControl1.SelectedPage.Text.Contains("Small Nota") Then
                        If uc_p(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Small Nota) ", "")) - 1).Button_Yes.Enabled = True Then
                            uc_p(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Small Nota) ", "")) - 1).eksekusi()
                        Else
                            uc_p(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Small Nota) ", "")) - 1).ControlToBayarTextBox()
                        End If
                    ElseIf TabControl1.SelectedPage.Text.Contains("Big Nota") Then
                        If uc_pf(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Big Nota) ", "")) - 1).Button_Yes.Enabled = True Then
                            uc_pf(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Big Nota) ", "")) - 1).eksekusi()
                        Else
                            uc_pf(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Big Nota) ", "")) - 1).ControlToBayarTextBox()
                        End If
                    Else
                        If uc_po(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Order Barang) ", "")) - 1).Button_Yes.Enabled = True Then
                            uc_po(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Order Barang) ", "")) - 1).eksekusi()
                        Else
                            uc_po(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Order Barang) ", "")) - 1).ControlToBayarTextBox()
                        End If
                    End If
                Else
                    If uc_b(CInt(TabControl1.SelectedPage.Text.Replace("Barang Masuk ", "")) - 1).Button_Selesai.Enabled = True Then
                        uc_b(CInt(TabControl1.SelectedPage.Text.Replace("Barang Masuk ", "")) - 1).eksekusi()
                    End If
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                If TabControl1.SelectedPage.Text.Contains("Penjualan") Then
                    'If TabControl1.SelectedPage.Text.Contains("Small Nota") Then
                    '    If uc_p(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Small Nota) ", "")) - 1).Button_Yes.Enabled = True Then
                    '        uc_p(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Small Nota) ", "")) - 1).eksekusi()
                    '    End If
                    'ElseIf TabControl1.SelectedPage.Text.Contains("Big Nota") Then
                    '    If uc_pf(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Big Nota) ", "")) - 1).Button_Yes.Enabled = True Then
                    '        uc_pf(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Big Nota) ", "")) - 1).eksekusi()
                    '    End If
                    'Else
                    '    If uc_po(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Order Barang) ", "")) - 1).Button_Yes.Enabled = True Then
                    '        uc_po(CInt(TabControl1.SelectedPage.Text.Replace("Penjualan (Order Barang) ", "")) - 1).eksekusi()
                    '    End If
                    'End If
                Else
                    uc_b(CInt(TabControl1.SelectedPage.Text.Replace("Barang Masuk ", "")) - 1).F6_BarangMasuk()
                End If
            End If
        End If

        If e.KeyCode = Keys.F9 Then
            tabpenjualan_normal()
        ElseIf e.KeyCode = Keys.F10 Then
            tabpenjualan_fast()
        ElseIf e.KeyCode = Keys.F11 Then
            tabpenjualan_order()
        ElseIf e.KeyCode = Keys.F12 Then
            tabbarangmasuk()
        End If
    End Sub


    

    Private Function get_last_number_ip(ByVal ip As String) As String
        Dim temp As Char() = ip.ToCharArray()
        Dim str As String = ""
        Dim stops As Boolean = False
        For i = ip.Length - 1 To 0 Step -1
            If temp(i) <> "." And stops = False Then
                str = temp(i) + str
            Else
                stops = True
            End If
        Next
        Return str
    End Function


    Private Sub RadMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles RadMenuItem2.Click
        Try
            If IsServer = True Then
                System.Diagnostics.Process.Start("Tutorial.pdf")

            Else
                System.Diagnostics.Process.Start("//" & Server & "\Tutorial.pdf")
            End If
        Catch ex As Exception
            If IsServer = True Then
                MessageBox.Show("File " & "Tutorial.pdf" & " tidak dapat ditemukan!", "File tidak bisa dibuka", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("File " & "//" & Server & "\Tutorial.pdf" & " tidak dapat ditemukan!", "File tidak bisa dibuka", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try
    End Sub

    Private Sub MenuItemClientServer_Click(sender As System.Object, e As System.EventArgs) Handles MenuItemClientServer.Click
        If SettingAuthority.SettingCounter.ClientServer = True Then
            Using Setting As New FormSetting
                Setting.RadPageView_Setting.SelectedPage = Setting.Pages_ClientServer
                Setting.ShowDialog()
                Setting.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MenuItemBSellnBProfit_Click(sender As Object, e As EventArgs) Handles MenuItemBSellnBProfit.Click
        If SettingAuthority.Laporan.LaporanBestSellerProfit = True Then
            Using BestSeller As New FormBestSeller
                BestSeller.status = "Best Seller"
                BestSeller.ShowDialog()
                BestSeller.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub


    Private Sub MenuItemPreferensi_Click(sender As Object, e As EventArgs) Handles MenuItemPreferensi.Click
        Using Setting As New FormSetting
            Setting.RadPageView_Setting.SelectedPage = Setting.Pages_Preferences
            Setting.ShowDialog()
            Setting.Dispose()
            CobaBersihkanMemori()
        End Using
    End Sub

    Private Sub MenuLaporanDetailPenjualan_Click(sender As Object, e As EventArgs) Handles MenuLaporanDetailPenjualan.Click
        Using FormDialogSeleksi As New FormDialogSeleksiDetailTransaksi
            FormDialogSeleksi.Jenis = FormDialogSeleksiDetailTransaksi.Jenis2.PenjualanDanOrder
            FormDialogSeleksi.ShowDialog()
        End Using
    End Sub

    Private Sub MenuLaporanDetailRetur_Click(sender As Object, e As EventArgs) Handles MenuLaporanDetailRetur.Click
        Using FormDialogSeleksi As New FormDialogSeleksiDetailTransaksi
            FormDialogSeleksi.Jenis = FormDialogSeleksiDetailTransaksi.Jenis2.Retur
            FormDialogSeleksi.ShowDialog()
        End Using
    End Sub

    Private Sub MenuLaporanDetailBrgMasuk_Click(sender As Object, e As EventArgs) Handles MenuLaporanDetailBrgMasuk.Click
        Using FormDialogSeleksi As New FormDialogSeleksiDetailTransaksi
            FormDialogSeleksi.Jenis = FormDialogSeleksiDetailTransaksi.Jenis2.BarangMasuk
            FormDialogSeleksi.ShowDialog()
        End Using
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        cek_Perusahaan()

    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        Me.RadPanel3.Text = NamaToko
    End Sub
End Class
