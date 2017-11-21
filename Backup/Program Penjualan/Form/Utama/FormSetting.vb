Imports Telerik.WinControls

Public Class FormSetting
    Dim status_tipe As String = ""
    Dim load_complete As Boolean = False

    Private Sub FormSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.RadPageView_Setting.Pages.Item(5).Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        If RadPageView_Setting.SelectedPage Is Pages_SetAdmin Or RadPageView_Setting.SelectedPage Is Pages_SetAuthority Then
            If RadPageView_Setting.SelectedPage Is Pages_SetAdmin Then
                Me.Text = "Setting Admin"
            Else
                Me.Text = "Setting Authority"
            End If
            For i = 0 To Me.RadPageView_Setting.Pages.Count - 1
                If i <> 6 Or i <> 7 Then
                    Me.RadPageView_Setting.Pages.Item(i).Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
                End If
            Next
            Me.Tabel_userTableAdapter.Fill(Me.TokoDataSet1.tabel_user)
            ComboBox_hak_user.SelectedIndex = ComboBox_hak_user.Items(1).RowIndex
            load_SetAuthority()
        Else
            For i = 0 To Me.RadPageView_Setting.Pages.Count - 1
                If i = 6 Or i = 7 Then
                    Me.RadPageView_Setting.Pages.Item(i).Item.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
                End If
            Next
            Isi_data_perusahaan()
            Me.Tabel_salesTableAdapter.FillByFix(Me.TokoDataSet1.tabel_sales)
            Me.Tabel_tipe_barangTableAdapter.Fill(Me.TokoDataSet1.tabel_tipe_barang)
            load_theme()
            load_set_label()
            load_tabel_enkripsi()
            load_client_server()
            LoadPreferensiPenjualan()
            LoadPreferensiOrder()
            LoadPreferensiBrgMasuk()
            If SettingAuthority.SettingCounter.UbahInfoPerusahaan = False Then
                RadPageView_Setting.Pages.Item(0).Item.Visibility = ElementVisibility.Collapsed
            End If
            If SettingAuthority.SettingCounter.SettingLabel = False Then
                RadPageView_Setting.Pages.Item(3).Item.Visibility = ElementVisibility.Collapsed
            End If
        End If
        Me.load_complete = True
    End Sub

    Private Sub load_client_server()
        'load ip address
        Dim host As Net.IPHostEntry
        Dim hostname As String
        Dim ips(1) As String
        hostname = My.Computer.Name
        host = Net.Dns.GetHostEntry(hostname)
        Dim i = 0
        For Each ip As Net.IPAddress In host.AddressList
            If ip.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                ips(i) = ip.ToString
                i = i + 1
            End If
        Next
        RadLabel36.Text = ips(0).ToString()
        'load server atau bukan
        If IsServer = True Then
            RadRadioButton1.ToggleState = Enumerations.ToggleState.On
            RadRadioButton2.ToggleState = Enumerations.ToggleState.Off
            RadSpinEditor1.Value = pecah_ip(Server, 0)
            RadSpinEditor2.Value = pecah_ip(Server, 1)
            RadSpinEditor3.Value = pecah_ip(Server, 2)
            RadSpinEditor4.Value = pecah_ip(Server, 3)
        Else
            RadRadioButton1.ToggleState = Enumerations.ToggleState.Off
            RadRadioButton2.ToggleState = Enumerations.ToggleState.On
            RadSpinEditor1.Value = pecah_ip(Server, 0)
            RadSpinEditor2.Value = pecah_ip(Server, 1)
            RadSpinEditor3.Value = pecah_ip(Server, 2)
            RadSpinEditor4.Value = pecah_ip(Server, 3)
        End If
        'load folder 
        'If IsServer = True Then
        RadBrowseEditor1.Value = My.Settings.FolderNota.ToString
        'Else
        '    RadBrowseEditor1.Value = "//" & Server & "\" & My.Settings.FolderNota.ToString
        'End If

    End Sub

    Private Function pecah_ip(ByVal ip_address As String, ByVal indeks_ke As Integer) As Integer
        Dim temp_arr() As String = ip_address.Split(CChar("."))
        Return CInt(temp_arr(indeks_ke))
    End Function

    Private Sub load_tabel_enkripsi()
        Dim tabel_enkripsi As tokoDataSetTableAdapters.tabel_enkripsiTableAdapter = New tokoDataSetTableAdapters.tabel_enkripsiTableAdapter
        Dim dt As DataTable = tabel_enkripsi.GetData()
        If CDec(dt.Rows(0).Item("div")) = 1 Then
            EnkripsiTabelDivDropDownList.SelectedIndex = 0
        ElseIf CDec(dt.Rows(0).Item("div")) = 1000 Then
            EnkripsiTabelDivDropDownList.SelectedIndex = 1
        End If
        EnkripsiTabelDivDropDownList.SelectedValue = dt.Rows(0).Item("div")
        EnkripsiTabel05.Text = dt.Rows(0).Item("0,5").ToString
        EnkripsiTabel0.Text = dt.Rows(0).Item("0").ToString
        EnkripsiTabel1.Text = dt.Rows(0).Item("1").ToString
        EnkripsiTabel2.Text = dt.Rows(0).Item("2").ToString
        EnkripsiTabel3.Text = dt.Rows(0).Item("3").ToString
        EnkripsiTabel4.Text = dt.Rows(0).Item("4").ToString
        EnkripsiTabel5.Text = dt.Rows(0).Item("5").ToString
        EnkripsiTabel6.Text = dt.Rows(0).Item("6").ToString
        EnkripsiTabel7.Text = dt.Rows(0).Item("7").ToString
        EnkripsiTabel8.Text = dt.Rows(0).Item("8").ToString
        EnkripsiTabel9.Text = dt.Rows(0).Item("9").ToString
    End Sub


    Private Sub load_set_label()
        RadCheckBox1.Checked = SettingLabel.StatNamaPerusahaan
        RadCheckBox2.Checked = SettingLabel.LogoPerusahaan
        RadCheckBox3.Checked = SettingLabel.NamaBarang
        RadCheckBox4.Checked = SettingLabel.IDBarang
        RadCheckBox5.Checked = SettingLabel.Barcode
        RadCheckBox6.Checked = SettingLabel.HargaGrosirEnkripsi
        RadCheckBox7.Checked = SettingLabel.HargaRetail
        RadTextBox5.Text = SettingLabel.NamaPerusahaan
    End Sub

    Private Sub load_theme()
        If ThemeResolutionService.ApplicationThemeName = "TelerikMetro" Then
            RadioThemeMetroGreen.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Office2010Black" Then
            RadioThemeOffice2010Black.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue" Then
            RadioThemeMetroBlue.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Office2010Blue" Then
            RadioThemeOffice2010Blue.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Office2010Silver" Then
            RadioThemeOffice2010Silver.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Aqua" Then
            RadioThemeAqua.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Breeze" Then
            RadioThemeBreeze.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Desert" Then
            RadioThemeDesert.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light" Then
            RadioThemeVS2012Light.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Office2013Light" Then
            RadioThemeOffice2013Light.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Windows7" Then
            RadioThemeWindows7.IsChecked = True
        ElseIf ThemeResolutionService.ApplicationThemeName = "Windows8" Then
            RadioThemeWindows8.IsChecked = True
        End If
    End Sub

    Private Sub load_SetAuthority()
        Using dt2 As DataTable = Tabel_set_authorityTableAdapter.GetDataByTipeAuthority("Manager")
            Using dt3 As DataTable = Tabel_set_authorityTableAdapter.GetDataByTipeAuthority("Cashier 1st")
                Using dt4 As DataTable = Tabel_set_authorityTableAdapter.GetDataByTipeAuthority("Cashier 2nd")
                    Using dt5 As DataTable = Tabel_set_authorityTableAdapter.GetDataByTipeAuthority("Cashier 3rd")
                        'Isi set Authority untuk Owner
                        'MessageBox.Show(dt1.Rows(0).Item(1))
                        Dim l = 1
                        For i = 0 To 7
                            Select Case i
                                Case 0
                                    For j = 0 To 7
                                        RadTreeView2.Nodes.Item(i).Nodes(j).Checked = CBool(dt2.Rows(0).Item(l))
                                        RadTreeView3.Nodes.Item(i).Nodes(j).Checked = CBool(dt3.Rows(0).Item(l))
                                        RadTreeView4.Nodes.Item(i).Nodes(j).Checked = CBool(dt4.Rows(0).Item(l))
                                        RadTreeView5.Nodes.Item(i).Nodes(j).Checked = CBool(dt5.Rows(0).Item(l))
                                        l = l + 1
                                    Next
                                Case 1
                                    For j = 0 To 3
                                        RadTreeView2.Nodes.Item(i).Nodes(j).Checked = CBool(dt2.Rows(0).Item(l))
                                        RadTreeView3.Nodes.Item(i).Nodes(j).Checked = CBool(dt3.Rows(0).Item(l))
                                        RadTreeView4.Nodes.Item(i).Nodes(j).Checked = CBool(dt4.Rows(0).Item(l))
                                        RadTreeView5.Nodes.Item(i).Nodes(j).Checked = CBool(dt5.Rows(0).Item(l))
                                        l = l + 1
                                    Next
                                Case 2
                                    RadTreeView2.Nodes.Item(i).Checked = CBool(dt2.Rows(0).Item(l))
                                    RadTreeView3.Nodes.Item(i).Checked = CBool(dt3.Rows(0).Item(l))
                                    RadTreeView4.Nodes.Item(i).Checked = CBool(dt4.Rows(0).Item(l))
                                    RadTreeView5.Nodes.Item(i).Checked = CBool(dt5.Rows(0).Item(l))
                                    l = l + 1
                                Case 3
                                    For j = 0 To 7
                                        RadTreeView2.Nodes.Item(i).Nodes(j).Checked = CBool(dt2.Rows(0).Item(l))
                                        RadTreeView3.Nodes.Item(i).Nodes(j).Checked = CBool(dt3.Rows(0).Item(l))
                                        RadTreeView4.Nodes.Item(i).Nodes(j).Checked = CBool(dt4.Rows(0).Item(l))
                                        RadTreeView5.Nodes.Item(i).Nodes(j).Checked = CBool(dt5.Rows(0).Item(l))
                                        l = l + 1
                                    Next
                                Case 4
                                    For j = 0 To 6
                                        RadTreeView2.Nodes.Item(i).Nodes(j).Checked = CBool(dt2.Rows(0).Item(l))
                                        RadTreeView3.Nodes.Item(i).Nodes(j).Checked = CBool(dt3.Rows(0).Item(l))
                                        RadTreeView4.Nodes.Item(i).Nodes(j).Checked = CBool(dt4.Rows(0).Item(l))
                                        RadTreeView5.Nodes.Item(i).Nodes(j).Checked = CBool(dt5.Rows(0).Item(l))
                                        l = l + 1
                                    Next
                                Case 5
                                    For j = 0 To 9
                                        RadTreeView2.Nodes.Item(i).Nodes(j).Checked = CBool(dt2.Rows(0).Item(l))
                                        RadTreeView3.Nodes.Item(i).Nodes(j).Checked = CBool(dt3.Rows(0).Item(l))
                                        RadTreeView4.Nodes.Item(i).Nodes(j).Checked = CBool(dt4.Rows(0).Item(l))
                                        RadTreeView5.Nodes.Item(i).Nodes(j).Checked = CBool(dt5.Rows(0).Item(l))
                                        l = l + 1
                                    Next
                                Case 6
                                    For j = 0 To 10
                                        RadTreeView2.Nodes.Item(i).Nodes(j).Checked = CBool(dt2.Rows(0).Item(l))
                                        RadTreeView3.Nodes.Item(i).Nodes(j).Checked = CBool(dt3.Rows(0).Item(l))
                                        RadTreeView4.Nodes.Item(i).Nodes(j).Checked = CBool(dt4.Rows(0).Item(l))
                                        RadTreeView5.Nodes.Item(i).Nodes(j).Checked = CBool(dt5.Rows(0).Item(l))
                                        l = l + 1
                                    Next
                                Case 7
                                    RadTreeView2.Nodes.Item(i).Checked = CBool(dt2.Rows(0).Item(l))
                                    RadTreeView3.Nodes.Item(i).Checked = CBool(dt3.Rows(0).Item(l))
                                    RadTreeView4.Nodes.Item(i).Checked = CBool(dt4.Rows(0).Item(l))
                                    RadTreeView5.Nodes.Item(i).Checked = CBool(dt5.Rows(0).Item(l))
                            End Select
                        Next
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Isi_data_perusahaan()
        Using dt As DataTable = Me.Tabel_perusahaanTableAdapter.GetData()
            TextBox_nama_toko.Text = dt.Rows(0).Item("nama_toko").ToString
            RichTextBox_Kota.Text = dt.Rows(0).Item("alamat").ToString
            RichTextBox_Alamat.Text = dt.Rows(0).Item("alamat_lengkap").ToString
            TextBox_telp.Text = dt.Rows(0).Item("telp").ToString
            RichTextBox_catatan.Text = dt.Rows(0).Item("catatan").ToString
            RichTextBox_catatankaki.Text = dt.Rows(0).Item("catatan_kaki").ToString

            Dim pl() As Byte = CType(dt.Rows(0).Item("logo_perusahaan"), Byte())
            Using gambarLogo As New System.IO.MemoryStream(pl)
                If pl.Length <> 0 Then
                    PictureLogo.BackgroundImage = System.Drawing.Image.FromStream(gambarLogo)
                End If
            End Using

            Dim pp() As Byte = CType(dt.Rows(0).Item("pemilik_foto"), Byte())
            Using gambarPemilik As New System.IO.MemoryStream(pp)
                If pp.Length <> 0 Then
                    PicturePemilik.BackgroundImage = System.Drawing.Image.FromStream(gambarPemilik)
                End If
            End Using

            RadTextBox1.Text = CStr(dt.Rows(0).Item("pemilik_nama"))
            RadTextBox2.Text = CStr(dt.Rows(0).Item("pemilik_alamat"))
            RadTextBox3.Text = CStr(dt.Rows(0).Item("pemilik_telp"))
            RadTextBox4.Text = CStr(dt.Rows(0).Item("pemilik_catatan"))
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim retur As String = "Tidak"
        Dim hutangC As String = "Tidak"
        Dim tipe_grosir As String = "Tidak"
        Dim tipe_retail As String = "Tidak"

        Using logostream As New System.IO.MemoryStream()
            PictureLogo.BackgroundImage.Save(logostream, System.Drawing.Imaging.ImageFormat.Png)
            Dim logoImage() As Byte = logostream.GetBuffer()

            Using pemilikstream As New System.IO.MemoryStream()
                PicturePemilik.BackgroundImage.Save(pemilikstream, System.Drawing.Imaging.ImageFormat.Png)
                Dim pemilikImage() As Byte = pemilikstream.GetBuffer()

                Try
                    Me.Tabel_perusahaanTableAdapter.UpdateQuery(TextBox_nama_toko.Text, RichTextBox_Alamat.Text, RichTextBox_Kota.Text, TextBox_telp.Text, RichTextBox_catatan.Text, RichTextBox_catatankaki.Text, RadTextBox2.Text, RadTextBox4.Text, RadTextBox1.Text, RadTextBox3.Text, pemilikImage, logoImage)
                    NamaToko = TextBox_nama_toko.Text
                    CatatanHeader = RichTextBox_catatan.Text
                    CatatanKaki = RichTextBox_catatankaki.Text
                    LogoPerusahaan = logoImage
                    Using pl As New System.IO.MemoryStream(LogoPerusahaan)
                        FormUtama.PictureBox1.BackgroundImage = System.Drawing.Image.FromStream(pl)
                    End Using
                    Telerik.WinControls.RadMessageBox.Show("Info Perusahaan berhasil disimpan.", "Update Info Perusahaan", MessageBoxButtons.OK, RadMessageIcon.Info)
                Catch ex As Exception
                    Telerik.WinControls.RadMessageBox.Show(ex.Message, "Update Info Perusahaan", MessageBoxButtons.OK, RadMessageIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonBaru_SetAdmin.Click
        Button2.Enabled = True
        Button3.Enabled = True
        TextBox_nama_id.Enabled = True
        ComboBox_hak_user.Enabled = True
        TextBox_password.Enabled = True
        TextBox_confirm.Enabled = True
        ButtonBaru_SetAdmin.Enabled = False
        ButtonHapus_SetAdmin.Enabled = False
        ButtonEdit_SetAdmin.Enabled = False
        RadLabel20.Text = "Baru"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox_nama_id.Text = "" Or TextBox_password.Text = "" Or
            TextBox_confirm.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show("Semua data harus diisi.", "Setting", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            TextBox_nama_id.Select()
        ElseIf TextBox_password.Text <> TextBox_confirm.Text Then
            Telerik.WinControls.RadMessageBox.Show("Isi password dan konfirm password yang dimasukkan harus sama.", "Setting", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
        ElseIf CInt(Tabel_userTableAdapter.cekID(TextBox_nama_id.Text.ToString, id_lama)) = 1 Then
            If TextBox_nama_id.Text <> "admin" Then
                Telerik.WinControls.RadMessageBox.Show("Nama / ID " + TextBox_nama_id.Text + " sudah ada. Harap ganti dengan nama / id yang baru.", "Setting", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            End If
        Else
            If RadLabel20.Text = "Edit" Then
                Me.Tabel_userTableAdapter.UpdateQuery(TextBox_nama_id.Text, TextBox_password.Text, ComboBox_hak_user.Text, id_lama)
            Else
                Me.Tabel_userTableAdapter.InsertQuery(TextBox_nama_id.Text.ToString, _
                                                                TextBox_confirm.Text.ToString, _
                                                                ComboBox_hak_user.SelectedItem.Text.ToString)
            End If

            Me.Tabel_userTableAdapter.Fill(Me.TokoDataSet1.tabel_user)
            Button2.Enabled = False
            Button3.Enabled = False
            TextBox_nama_id.Enabled = False
            TextBox_nama_id.Text = ""
            ComboBox_hak_user.Enabled = False
            ComboBox_hak_user.SelectedItem.Text = ComboBox_hak_user.Items(1).Text
            TextBox_password.Enabled = False
            TextBox_password.Text = ""
            TextBox_confirm.Enabled = False
            TextBox_confirm.Text = ""
            ButtonBaru_SetAdmin.Enabled = True
            ButtonHapus_SetAdmin.Enabled = True
            ButtonEdit_SetAdmin.Enabled = True
            RadLabel20.Text = ""
            id_lama = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button3.Enabled = False
        TextBox_nama_id.Enabled = False
        TextBox_nama_id.Text = ""
        ComboBox_hak_user.Enabled = False
        ComboBox_hak_user.Text = ComboBox_hak_user.Items(1).Text
        TextBox_password.Enabled = False
        TextBox_password.Text = ""
        TextBox_confirm.Enabled = False
        TextBox_confirm.Text = ""
        ButtonBaru_SetAdmin.Enabled = True
        ButtonHapus_SetAdmin.Enabled = True
        ButtonEdit_SetAdmin.Enabled = True
        RadLabel20.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonHapus_SetAdmin.Click
        If DataGridView_user.Rows(DataGridView_user.CurrentRow.Index).Cells(0).Value.ToString <> StatusID Then
            If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yakin ingin menghapus user dengan nama / ID " + _
                                  DataGridView_user.Rows(DataGridView_user.CurrentRow.Index).Cells(0).Value.ToString + _
                                  " ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Me.Tabel_userTableAdapter.DeleteQuery(DataGridView_user.Rows(DataGridView_user.CurrentRow.Index).Cells(0).Value.ToString)
                Me.Tabel_userTableAdapter.Fill(Me.TokoDataSet1.tabel_user)
            End If
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button_Batal_TipeBrg.Click
        Panel6.Enabled = False
        Button_baru_tipe.Enabled = True
        Button_edit_tipe.Enabled = True
        Button_hapus_tipe.Enabled = True
        Label_Tipe_Barang.Text = ""
        TextBox_tipe_brg.Text = ""
        TextBox_kode_tipe.Text = ""
        RichTextBox_keterangan.Text = ""
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button_hapus_tipe.Click
        If SettingAuthority.SettingCounter.EditHapusTipeBarang = True Then
            If DataGridView_tipe_barang.Rows.Count <> 0 Then
                If Telerik.WinControls.RadMessageBox.Show("Perhatian! Harap berhati-hati menghapus data tipe barang karena akan berpengaruh keseluruh sistem. Kerusakan akan kehilangan data tidak dapat diperbaiki." + vbNewLine + vbNewLine + _
                                          "Apakah Anda yakin ingin menghapus tipe barang " + DataGridView_tipe_barang.Rows(DataGridView_tipe_barang.CurrentCell.RowIndex).Cells(0).Value.ToString + " dari database?", _
                                            "Program Penjualan", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        Me.Tabel_tipe_barangTableAdapter.DeleteQuery(DataGridView_tipe_barang.Rows(DataGridView_tipe_barang.CurrentCell.RowIndex).Cells(0).Value.ToString)
                    Catch ex As Exception
                        Telerik.WinControls.RadMessageBox.Show(ex.Message, "Setting", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                    End Try
                    Me.Tabel_tipe_barangTableAdapter.Fill(Me.TokoDataSet1.tabel_tipe_barang)
                End If
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button13.Enabled = True
        Button14.Enabled = True
        Button15.Enabled = True
        nama_sales_TextBox.Text = ""
        alamat_sales_RichTextBox.Text = ""
        tgl_lahir_DateTimePicker.Value = CDate(tgltoday)
        no_hp_sales_TextBox.Text = ""
        Panel7.Enabled = False
        Label_Sales.Text = ""
    End Sub

    Dim status_sales As String

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If nama_sales_TextBox.Text.ToString = "" And alamat_sales_RichTextBox.Text.ToString = "" And tgl_lahir_DateTimePicker.Value.ToShortDateString = "" And no_hp_sales_TextBox.Text.ToString = "" Then
            Telerik.WinControls.RadMessageBox.Show("Semua data harus diisi.", "Setting", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
        Else
            If status_sales = "Tambah" Then
                If CBool(Me.Tabel_salesTableAdapter.ScalarQueryNamaForReplace(nama_sales_TextBox.Text)) Then
                    Me.Tabel_salesTableAdapter.UpdateQuery(nama_sales_TextBox.Text, alamat_sales_RichTextBox.Text, tgl_lahir_DateTimePicker.Value, no_hp_sales_TextBox.Text, "N", nama_sales_TextBox.Text)
                    Me.Tabel_salesTableAdapter.FillByFix(Me.TokoDataSet1.tabel_sales)
                    Telerik.WinControls.RadMessageBox.Show("Data Sales berhasil disimpan.", "Sukses", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Button13.Enabled = True
                    Button14.Enabled = True
                    Button15.Enabled = True
                    nama_sales_TextBox.Text = ""
                    alamat_sales_RichTextBox.Text = ""
                    tgl_lahir_DateTimePicker.Value = CDate(tgltoday)
                    no_hp_sales_TextBox.Text = ""
                    Panel7.Enabled = False
                    Label_Sales.Text = ""
                Else
                    Me.Tabel_salesTableAdapter.InsertQuery(nama_sales_TextBox.Text, alamat_sales_RichTextBox.Text, tgl_lahir_DateTimePicker.Value, no_hp_sales_TextBox.Text, CDate(tgltoday), "N")
                    Me.Tabel_salesTableAdapter.FillByFix(Me.TokoDataSet1.tabel_sales)
                    Telerik.WinControls.RadMessageBox.Show("Data Sales berhasil disimpan.", "Sukses", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Button13.Enabled = True
                    Button14.Enabled = True
                    Button15.Enabled = True
                    nama_sales_TextBox.Text = ""
                    alamat_sales_RichTextBox.Text = ""
                    tgl_lahir_DateTimePicker.Value = CDate(tgltoday)
                    no_hp_sales_TextBox.Text = ""
                    Panel7.Enabled = False
                    Label_Sales.Text = ""
                End If
            Else
                If CInt(Me.Tabel_salesTableAdapter.ScalarQueryNamaForReplace(nama_sales_TextBox.Text)) = 1 Then
                    'Telerik.WinControls.RadMessageBox.Show("Nama sales sudah ada.", nama_sales_TextBox.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                    'nama_sales_TextBox.Focus()
                Else
                    Me.Tabel_salesTableAdapter.UpdateQuery(nama_sales_TextBox.Text, alamat_sales_RichTextBox.Text, tgl_lahir_DateTimePicker.Value, no_hp_sales_TextBox.Text, "N", temp_nama_sales)
                    Me.Tabel_salesTableAdapter.FillByFix(Me.TokoDataSet1.tabel_sales)
                    Telerik.WinControls.RadMessageBox.Show("Data Sales berhasil disimpan.", "Sukses", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Button13.Enabled = True
                    Button14.Enabled = True
                    Button15.Enabled = True
                    nama_sales_TextBox.Text = ""
                    alamat_sales_RichTextBox.Text = ""
                    tgl_lahir_DateTimePicker.Value = CDate(tgltoday)
                    no_hp_sales_TextBox.Text = ""
                    Panel7.Enabled = False
                    Label_Sales.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If SettingAuthority.SettingCounter.EditHapusSales = True Then
            If DataGridView_sales.RowCount <> 0 Then
                If DataGridView_sales.Rows(DataGridView_sales.CurrentRow.Index).Cells(0).Value.ToString <> "< Kasir >" Then
                    If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yakin ingin menghapus data sales dengan nama sales " + DataGridView_sales.Rows(DataGridView_sales.CurrentCell.RowIndex).Cells(0).Value.ToString + _
                                          " ?", "Program Penjualan", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        Me.Tabel_salesTableAdapter.Terhapus_Query(CStr(DataGridView_sales.Rows(DataGridView_sales.CurrentCell.RowIndex).Cells(0).Value))
                        Me.Tabel_salesTableAdapter.FillByFix(Me.TokoDataSet1.tabel_sales)
                    End If
                End If
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub Button_baru_tipe_Click(sender As Object, e As EventArgs) Handles Button_baru_tipe.Click
        If SettingAuthority.SettingCounter.TambahTipeBarang = True Then
            If Panel6.Enabled = False Then
                Panel6.Enabled = True
                Button_edit_tipe.Enabled = False
                Button_hapus_tipe.Enabled = False
                Me.status_tipe = "Baru"
                Label_Tipe_Barang.Text = status_tipe
                TextBox_tipe_brg.Select()
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private temp_tipe As String = ""
    Private temp_kode_tipe As String = ""
    Private Sub Button_edit_tipe_Click(sender As Object, e As EventArgs) Handles Button_edit_tipe.Click
        If SettingAuthority.SettingCounter.EditHapusTipeBarang = True Then
            If Panel6.Enabled = False Then
                If DataGridView_tipe_barang.RowCount <> 0 Then
                    Panel6.Enabled = True
                    Button_baru_tipe.Enabled = False
                    Button_hapus_tipe.Enabled = False
                    Me.status_tipe = "Edit"
                    Label_Tipe_Barang.Text = status_tipe
                    TextBox_tipe_brg.Text = DataGridView_tipe_barang.Rows(DataGridView_tipe_barang.CurrentCell.RowIndex).Cells(0).Value.ToString
                    Me.temp_tipe = TextBox_tipe_brg.Text
                    Me.temp_kode_tipe = TextBox_kode_tipe.Text
                    TextBox_kode_tipe.Text = DataGridView_tipe_barang.Rows(DataGridView_tipe_barang.CurrentCell.RowIndex).Cells(1).Value.ToString
                    RichTextBox_keterangan.Text = DataGridView_tipe_barang.Rows(DataGridView_tipe_barang.CurrentCell.RowIndex).Cells(2).Value.ToString
                    TextBox_tipe_brg.Select()
                End If
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub proses_save_tipe_barang()
        Try
            If status_tipe = "Baru" Then
                If Tabel_tipe_barangTableAdapter.ScalarQueryTerhapus_by_tipe(TextBox_tipe_brg.Text) = "Y" Then
                    Me.Tabel_tipe_barangTableAdapter.UpdateQuery1(TextBox_kode_tipe.Text, RichTextBox_keterangan.Text, TextBox_tipe_brg.Text)
                Else
                    Me.Tabel_tipe_barangTableAdapter.InsertQuery(TextBox_tipe_brg.Text, TextBox_kode_tipe.Text, RichTextBox_keterangan.Text)
                End If
            ElseIf status_tipe = "Edit" Then
                Me.Tabel_tipe_barangTableAdapter.UpdateQuery(TextBox_tipe_brg.Text, TextBox_kode_tipe.Text, RichTextBox_keterangan.Text, temp_tipe)
            End If
            Me.Tabel_tipe_barangTableAdapter.Fill(Me.TokoDataSet1.tabel_tipe_barang)
            Telerik.WinControls.RadMessageBox.Show("Tipe Barang berhasil disimpan.", "Sukses", MessageBoxButtons.OK, RadMessageIcon.Info)
            Panel6.Enabled = False
            Button_baru_tipe.Enabled = True
            Button_edit_tipe.Enabled = True
            Button_hapus_tipe.Enabled = True
            Label_Tipe_Barang.Text = ""
            TextBox_tipe_brg.Text = ""
            TextBox_kode_tipe.Text = ""
            RichTextBox_keterangan.Text = ""
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Setting", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
        End Try
    End Sub


    Private Sub Button10_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button10.Click
        If TextBox_tipe_brg.Text <> "" And TextBox_kode_tipe.Text <> "" And RichTextBox_keterangan.Text <> "" Then
            If status_tipe = "Edit" Then
                If CInt(Me.Tabel_tipe_barangTableAdapter.ScalarQuery2_tipe(TextBox_tipe_brg.Text, temp_tipe)) = 1 Then
                    Telerik.WinControls.RadMessageBox.Show("Tipe barang yang diinput sudah ada.", TextBox_tipe_brg.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                    TextBox_tipe_brg.Focus()
                Else
                    If CInt(Me.Tabel_tipe_barangTableAdapter.ScalarQuery2_kode_tipe1(TextBox_kode_tipe.Text, temp_kode_tipe)) = 1 Then
                        Telerik.WinControls.RadMessageBox.Show("Kode tipe barang yang diinput sudah ada.", TextBox_kode_tipe.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                        TextBox_kode_tipe.Focus()
                    Else
                        proses_save_tipe_barang()
                    End If
                End If
            ElseIf status_tipe = "Baru" Then
                If CInt(Me.Tabel_tipe_barangTableAdapter.ScalarQuery_tipe(TextBox_tipe_brg.Text)) = 1 Then
                    Telerik.WinControls.RadMessageBox.Show("Tipe barang yang diinput sudah ada.", TextBox_tipe_brg.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                    TextBox_tipe_brg.Focus()
                Else
                    If CInt(Me.Tabel_tipe_barangTableAdapter.ScalarQuery_kode_tipe(TextBox_kode_tipe.Text)) = 1 Then
                        If CInt(Me.Tabel_tipe_barangTableAdapter.ScalarQuery_kode_tipe_terhapus(TextBox_kode_tipe.Text)) = 1 Then
                            Telerik.WinControls.RadMessageBox.Show("Kode tipe barang yang diinput sudah ada.", TextBox_kode_tipe.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                            TextBox_kode_tipe.Focus()
                        Else
                            If CInt(Me.Tabel_tipe_barangTableAdapter.ScalarQueryTipe2(TextBox_tipe_brg.Text)) = 0 Then
                                Telerik.WinControls.RadMessageBox.Show("Kode tipe barang yang diinput sudah ada.", TextBox_kode_tipe.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                                TextBox_kode_tipe.Focus()
                            Else
                                proses_save_tipe_barang()
                            End If
                        End If
                    Else
                        proses_save_tipe_barang()
                    End If
                    'proses_save_tipe_barang()
                End If
            End If
        Else
            Telerik.WinControls.RadMessageBox.Show("Data yang diiput tidak boleh ada yang kosong.", "Tipe Barang", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If SettingAuthority.SettingCounter.TambahSales = True Then
            If Panel7.Enabled = False Then
                Panel7.Enabled = True
                Button14.Enabled = False
                Button13.Enabled = False
                Me.status_sales = "Tambah"
                Label_Sales.Text = status_sales
                nama_sales_TextBox.Select()
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private temp_nama_sales As String = ""
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If SettingAuthority.SettingCounter.EditHapusSales = True Then
            If Panel7.Enabled = False Then
                If DataGridView_sales.RowCount <> 0 Then
                    If DataGridView_sales.Rows(DataGridView_sales.CurrentRow.Index).Cells(0).Value.ToString <> "< Kasir >" Then
                        Panel7.Enabled = True
                        Button15.Enabled = False
                        Button13.Enabled = False
                        Me.status_sales = "Edit"
                        Label_Sales.Text = status_sales
                        nama_sales_TextBox.Text = CStr(DataGridView_sales.Rows(DataGridView_sales.CurrentCell.RowIndex).Cells(0).Value)
                        temp_nama_sales = nama_sales_TextBox.Text
                        alamat_sales_RichTextBox.Text = CStr(DataGridView_sales.Rows(DataGridView_sales.CurrentCell.RowIndex).Cells(1).Value)
                        tgl_lahir_DateTimePicker.Value = CDate(DataGridView_sales.Rows(DataGridView_sales.CurrentCell.RowIndex).Cells(2).Value)
                        no_hp_sales_TextBox.Text = CStr(DataGridView_sales.Rows(DataGridView_sales.CurrentCell.RowIndex).Cells(3).Value)
                        nama_sales_TextBox.Select()
                    End If
                End If
            End If
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub nama_sales_TextBox_Leave(sender As Object, e As EventArgs) Handles nama_sales_TextBox.Leave
        If status_sales = "Edit" Then
            If CInt(Me.Tabel_salesTableAdapter.ScalarQueryNama_forEdit(nama_sales_TextBox.Text, temp_nama_sales)) = 1 Then
                Telerik.WinControls.RadMessageBox.Show("Nama sales yang diinput sudah ada.", nama_sales_TextBox.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                nama_sales_TextBox.Focus()
            End If
        ElseIf status_sales = "Tambah" Then
            If CInt(Me.Tabel_salesTableAdapter.ScalarQueryNama(nama_sales_TextBox.Text)) = 1 Then
                Telerik.WinControls.RadMessageBox.Show("Nama sales yang diinput sudah ada.", nama_sales_TextBox.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                nama_sales_TextBox.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox_tipe_brg_Leave(sender As Object, e As EventArgs) Handles TextBox_tipe_brg.Leave
        Me.TextBox_tipe_brg.Text = CapitalizeEachWord(TextBox_tipe_brg.Text)
    End Sub

    Private Sub TextBox_kode_tipe_Leave(sender As Object, e As EventArgs) Handles TextBox_kode_tipe.Leave
        If TextBox_kode_tipe.TextLength < 3 Then
            Telerik.WinControls.RadMessageBox.Show("Panjang kode tipe tidak boleh kurang dari 3 karakter.", TextBox_kode_tipe.Text, MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            TextBox_kode_tipe.Focus()
            TextBox_tipe_brg.Select(TextBox_kode_tipe.TextLength, 0)
        End If
    End Sub

    Private Sub RadioThemeVS2012_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadioThemeVS2012Light.ToggleStateChanged, RadioThemeOffice2010Silver.ToggleStateChanged, RadioThemeOffice2010Blue.ToggleStateChanged, RadioThemeOffice2010Black.ToggleStateChanged, RadioThemeMetroGreen.ToggleStateChanged, RadioThemeMetroBlue.ToggleStateChanged, RadioThemeDesert.ToggleStateChanged, RadioThemeBreeze.ToggleStateChanged, RadioThemeAqua.ToggleStateChanged, RadioThemeVS2012Dark.ToggleStateChanged, RadioThemeOffice2013Light.ToggleStateChanged, RadioThemeWindows7.ToggleStateChanged, RadioThemeWindows8.ToggleStateChanged
        If RadioThemeMetroBlue.IsChecked = True Then
            Tema = "TelerikMetroBlue"
        ElseIf RadioThemeOffice2010Black.IsChecked = True Then
            Tema = "Office2010Black"
        ElseIf RadioThemeMetroGreen.IsChecked = True Then
            Tema = "TelerikMetro"
        ElseIf RadioThemeOffice2010Blue.IsChecked = True Then
            Tema = "Office2010Blue"
        ElseIf RadioThemeOffice2010Silver.IsChecked = True Then
            Tema = "Office2010Silver"
        ElseIf RadioThemeAqua.IsChecked = True Then
            Tema = "Aqua"
        ElseIf RadioThemeBreeze.IsChecked = True Then
            Tema = "Breeze"
        ElseIf RadioThemeDesert.IsChecked = True Then
            Tema = "Desert"
        ElseIf RadioThemeVS2012Light.IsChecked = True Then
            Tema = "VisualStudio2012Light"
        ElseIf RadioThemeVS2012Dark.IsChecked = True Then
            Tema = "VisualStudio2012Dark"
        ElseIf RadioThemeOffice2013Light.IsChecked = True Then
            Tema = "Office2013Light"
        ElseIf RadioThemeWindows7.IsChecked = True Then
            Tema = "Windows7"
        ElseIf RadioThemeWindows8.IsChecked = True Then
            Tema = "Windows8"
        End If
        ChangeTheme(Tema)
        SimpanConfig(Tema, Server, IsServer)
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        'MessageBox.Show(RadTreeView2.Nodes(0).Nodes(0).Checked)
        Try
            Tabel_set_authorityTableAdapter.UpdateQuery(RadTreeView2.Nodes(0).Nodes(0).Checked, _
                                                        RadTreeView2.Nodes(0).Nodes(1).Checked, _
                                                        RadTreeView2.Nodes(0).Nodes(2).Checked, _
                                                        RadTreeView2.Nodes(0).Nodes(3).Checked, _
                                                        RadTreeView2.Nodes(0).Nodes(4).Checked, _
                                                        RadTreeView2.Nodes(0).Nodes(5).Checked, _
                                                        RadTreeView2.Nodes(0).Nodes(6).Checked, _
                                                        RadTreeView2.Nodes(0).Nodes(7).Checked, _
                                                        RadTreeView2.Nodes(1).Nodes(0).Checked, _
                                                        RadTreeView2.Nodes(1).Nodes(1).Checked, _
                                                        RadTreeView2.Nodes(1).Nodes(2).Checked, _
                                                        RadTreeView2.Nodes(1).Nodes(3).Checked, _
                                                        RadTreeView2.Nodes(2).Checked, _
                                                        RadTreeView2.Nodes(3).Nodes(0).Checked, _
                                                        RadTreeView2.Nodes(3).Nodes(1).Checked, _
                                                        RadTreeView2.Nodes(3).Nodes(2).Checked, _
                                                        RadTreeView2.Nodes(3).Nodes(3).Checked, _
                                                        RadTreeView2.Nodes(3).Nodes(4).Checked, _
                                                        RadTreeView2.Nodes(3).Nodes(5).Checked, _
                                                        RadTreeView2.Nodes(3).Nodes(6).Checked, _
                                                        RadTreeView2.Nodes(3).Nodes(7).Checked, _
                                                        RadTreeView2.Nodes(4).Nodes(0).Checked, _
                                                        RadTreeView2.Nodes(4).Nodes(1).Checked, _
                                                        RadTreeView2.Nodes(4).Nodes(2).Checked, _
                                                        RadTreeView2.Nodes(4).Nodes(3).Checked, _
                                                        RadTreeView2.Nodes(4).Nodes(4).Checked, _
                                                        RadTreeView2.Nodes(4).Nodes(5).Checked, _
                                                        RadTreeView2.Nodes(4).Nodes(6).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(0).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(1).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(2).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(3).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(4).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(5).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(6).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(7).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(8).Checked, _
                                                        RadTreeView2.Nodes(5).Nodes(9).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(0).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(1).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(2).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(3).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(4).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(5).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(6).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(7).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(8).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(9).Checked, _
                                                        RadTreeView2.Nodes(6).Nodes(10).Checked, _
                                                        RadTreeView2.Nodes(7).Checked, _
                                                        "Manager")
            Tabel_set_authorityTableAdapter.UpdateQuery(RadTreeView3.Nodes(0).Nodes(0).Checked, _
                                                        RadTreeView3.Nodes(0).Nodes(1).Checked, _
                                                        RadTreeView3.Nodes(0).Nodes(2).Checked, _
                                                        RadTreeView3.Nodes(0).Nodes(3).Checked, _
                                                        RadTreeView3.Nodes(0).Nodes(4).Checked, _
                                                        RadTreeView3.Nodes(0).Nodes(5).Checked, _
                                                        RadTreeView3.Nodes(0).Nodes(6).Checked, _
                                                        RadTreeView3.Nodes(0).Nodes(7).Checked, _
                                                        RadTreeView3.Nodes(1).Nodes(0).Checked, _
                                                        RadTreeView3.Nodes(1).Nodes(1).Checked, _
                                                        RadTreeView3.Nodes(1).Nodes(2).Checked, _
                                                        RadTreeView3.Nodes(1).Nodes(3).Checked, _
                                                        RadTreeView3.Nodes(2).Checked, _
                                                        RadTreeView3.Nodes(3).Nodes(0).Checked, _
                                                        RadTreeView3.Nodes(3).Nodes(1).Checked, _
                                                        RadTreeView3.Nodes(3).Nodes(2).Checked, _
                                                        RadTreeView3.Nodes(3).Nodes(3).Checked, _
                                                        RadTreeView3.Nodes(3).Nodes(4).Checked, _
                                                        RadTreeView3.Nodes(3).Nodes(5).Checked, _
                                                        RadTreeView3.Nodes(3).Nodes(6).Checked, _
                                                        RadTreeView3.Nodes(3).Nodes(7).Checked, _
                                                        RadTreeView3.Nodes(4).Nodes(0).Checked, _
                                                        RadTreeView3.Nodes(4).Nodes(1).Checked, _
                                                        RadTreeView3.Nodes(4).Nodes(2).Checked, _
                                                        RadTreeView3.Nodes(4).Nodes(3).Checked, _
                                                        RadTreeView3.Nodes(4).Nodes(4).Checked, _
                                                        RadTreeView3.Nodes(4).Nodes(5).Checked, _
                                                        RadTreeView3.Nodes(4).Nodes(6).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(0).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(1).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(2).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(3).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(4).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(5).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(6).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(7).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(8).Checked, _
                                                        RadTreeView3.Nodes(5).Nodes(9).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(0).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(1).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(2).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(3).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(4).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(5).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(6).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(7).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(8).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(9).Checked, _
                                                        RadTreeView3.Nodes(6).Nodes(10).Checked, _
                                                        RadTreeView3.Nodes(7).Checked, _
                                                        "Cashier 1st")
            Tabel_set_authorityTableAdapter.UpdateQuery(RadTreeView4.Nodes(0).Nodes(0).Checked, _
                                                        RadTreeView4.Nodes(0).Nodes(1).Checked, _
                                                        RadTreeView4.Nodes(0).Nodes(2).Checked, _
                                                        RadTreeView4.Nodes(0).Nodes(3).Checked, _
                                                        RadTreeView4.Nodes(0).Nodes(4).Checked, _
                                                        RadTreeView4.Nodes(0).Nodes(5).Checked, _
                                                        RadTreeView4.Nodes(0).Nodes(6).Checked, _
                                                        RadTreeView4.Nodes(0).Nodes(7).Checked, _
                                                        RadTreeView4.Nodes(1).Nodes(0).Checked, _
                                                        RadTreeView4.Nodes(1).Nodes(1).Checked, _
                                                        RadTreeView4.Nodes(1).Nodes(2).Checked, _
                                                        RadTreeView4.Nodes(1).Nodes(3).Checked, _
                                                        RadTreeView4.Nodes(2).Checked, _
                                                        RadTreeView4.Nodes(3).Nodes(0).Checked, _
                                                        RadTreeView4.Nodes(3).Nodes(1).Checked, _
                                                        RadTreeView4.Nodes(3).Nodes(2).Checked, _
                                                        RadTreeView4.Nodes(3).Nodes(3).Checked, _
                                                        RadTreeView4.Nodes(3).Nodes(4).Checked, _
                                                        RadTreeView4.Nodes(3).Nodes(5).Checked, _
                                                        RadTreeView4.Nodes(3).Nodes(6).Checked, _
                                                        RadTreeView4.Nodes(3).Nodes(7).Checked, _
                                                        RadTreeView4.Nodes(4).Nodes(0).Checked, _
                                                        RadTreeView4.Nodes(4).Nodes(1).Checked, _
                                                        RadTreeView4.Nodes(4).Nodes(2).Checked, _
                                                        RadTreeView4.Nodes(4).Nodes(3).Checked, _
                                                        RadTreeView4.Nodes(4).Nodes(4).Checked, _
                                                        RadTreeView4.Nodes(4).Nodes(5).Checked, _
                                                        RadTreeView4.Nodes(4).Nodes(6).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(0).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(1).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(2).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(3).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(4).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(5).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(6).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(7).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(8).Checked, _
                                                        RadTreeView4.Nodes(5).Nodes(9).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(0).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(1).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(2).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(3).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(4).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(5).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(6).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(7).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(8).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(9).Checked, _
                                                        RadTreeView4.Nodes(6).Nodes(10).Checked, _
                                                        RadTreeView4.Nodes(7).Checked, _
                                                        "Cashier 2nd")
            Tabel_set_authorityTableAdapter.UpdateQuery(RadTreeView5.Nodes(0).Nodes(0).Checked, _
                                                        RadTreeView5.Nodes(0).Nodes(1).Checked, _
                                                        RadTreeView5.Nodes(0).Nodes(2).Checked, _
                                                        RadTreeView5.Nodes(0).Nodes(3).Checked, _
                                                        RadTreeView5.Nodes(0).Nodes(4).Checked, _
                                                        RadTreeView5.Nodes(0).Nodes(5).Checked, _
                                                        RadTreeView5.Nodes(0).Nodes(6).Checked, _
                                                        RadTreeView5.Nodes(0).Nodes(7).Checked, _
                                                        RadTreeView5.Nodes(1).Nodes(0).Checked, _
                                                        RadTreeView5.Nodes(1).Nodes(1).Checked, _
                                                        RadTreeView5.Nodes(1).Nodes(2).Checked, _
                                                        RadTreeView5.Nodes(1).Nodes(3).Checked, _
                                                        RadTreeView5.Nodes(2).Checked, _
                                                        RadTreeView5.Nodes(3).Nodes(0).Checked, _
                                                        RadTreeView5.Nodes(3).Nodes(1).Checked, _
                                                        RadTreeView5.Nodes(3).Nodes(2).Checked, _
                                                        RadTreeView5.Nodes(3).Nodes(3).Checked, _
                                                        RadTreeView5.Nodes(3).Nodes(4).Checked, _
                                                        RadTreeView5.Nodes(3).Nodes(5).Checked, _
                                                        RadTreeView5.Nodes(3).Nodes(6).Checked, _
                                                        RadTreeView5.Nodes(3).Nodes(7).Checked, _
                                                        RadTreeView5.Nodes(4).Nodes(0).Checked, _
                                                        RadTreeView5.Nodes(4).Nodes(1).Checked, _
                                                        RadTreeView5.Nodes(4).Nodes(2).Checked, _
                                                        RadTreeView5.Nodes(4).Nodes(3).Checked, _
                                                        RadTreeView5.Nodes(4).Nodes(4).Checked, _
                                                        RadTreeView5.Nodes(4).Nodes(5).Checked, _
                                                        RadTreeView5.Nodes(4).Nodes(6).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(0).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(1).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(2).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(3).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(4).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(5).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(6).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(7).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(8).Checked, _
                                                        RadTreeView5.Nodes(5).Nodes(9).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(0).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(1).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(2).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(3).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(4).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(5).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(6).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(7).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(8).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(9).Checked, _
                                                        RadTreeView5.Nodes(6).Nodes(10).Checked, _
                                                        RadTreeView5.Nodes(7).Checked, _
                                                        "Cashier 3rd")
            RadMessageBox.Show("Simpan set Authority berhasil.", "Set Authority", MessageBoxButtons.OK, RadMessageIcon.Info)
            FormUtama.cek_Authority()
        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Set Authority", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub RadTreeView1_NodeCheckedChanging(sender As Object, e As UI.RadTreeViewCancelEventArgs) Handles RadTreeView1.NodeCheckedChanging
        e.Cancel = True
    End Sub

    Private Sub RadTreeView2_NodeCheckedChanged(sender As Object, e As UI.TreeNodeCheckedEventArgs) Handles RadTreeView2.NodeCheckedChanged, RadTreeView3.NodeCheckedChanged, RadTreeView4.NodeCheckedChanged, RadTreeView5.NodeCheckedChanged
        If load_complete = True Then
            RadButton1.Enabled = True
        End If
    End Sub

    Private Sub RadCheckBox1_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox1.ToggleStateChanged
        If RadCheckBox1.Checked = True Then
            RadLabel14.Visible = True
        Else
            RadLabel14.Visible = False
        End If
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadCheckBox2_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox2.ToggleStateChanged
        If RadCheckBox2.Checked = True Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadCheckBox3_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox3.ToggleStateChanged
        If RadCheckBox3.Checked = True Then
            RadLabel15.Visible = True
        Else
            RadLabel15.Visible = False
        End If
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadCheckBox4_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox4.ToggleStateChanged
        If RadCheckBox4.Checked = True Then
            RadLabel16.Visible = True
        Else
            RadLabel16.Visible = False
        End If
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadCheckBox5_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox5.ToggleStateChanged
        If RadCheckBox5.Checked = True Then
            PictureBox2.Visible = True
        Else
            PictureBox2.Visible = False
        End If
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadCheckBox6_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox6.ToggleStateChanged
        If RadCheckBox6.Checked = True Then
            RadLabel17.Visible = True
        Else
            RadLabel17.Visible = False
        End If
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadCheckBox7_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles RadCheckBox7.ToggleStateChanged
        If RadCheckBox7.Checked = True Then
            RadLabel18.Visible = True
        Else
            RadLabel18.Visible = False
        End If
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadTextBox5_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox5.TextChanged
        Me.RadLabel14.Text = Me.RadTextBox5.Text
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Try
            'Settng Label
            Me.Tabe_set_labelTableAdapter.UpdateQuery(RadTextBox5.Text, RadCheckBox2.Checked, RadCheckBox3.Checked, RadCheckBox4.Checked, RadCheckBox5.Checked, RadCheckBox6.Checked, RadCheckBox7.Checked, RadCheckBox1.Checked, 1)
            NamaTokoShort = RadTextBox5.Text
            SettingLabel.StatNamaPerusahaan = RadCheckBox1.Checked
            SettingLabel.LogoPerusahaan = RadCheckBox2.Checked
            SettingLabel.NamaBarang = RadCheckBox3.Checked
            SettingLabel.IDBarang = RadCheckBox4.Checked
            SettingLabel.Barcode = RadCheckBox5.Checked
            SettingLabel.HargaGrosirEnkripsi = RadCheckBox6.Checked
            SettingLabel.HargaRetail = RadCheckBox7.Checked
            SettingLabel.NamaPerusahaan = RadTextBox5.Text
            RadButton4.Enabled = False
            'Tabel Enkripsi
            Dim tabel_enkripsi As tokoDataSetTableAdapters.tabel_enkripsiTableAdapter = New tokoDataSetTableAdapters.tabel_enkripsiTableAdapter
            tabel_enkripsi.UpdateQuery(CInt(EnkripsiTabelDivDropDownList.Text), EnkripsiTabel05.Text, EnkripsiTabel0.Text, EnkripsiTabel1.Text, EnkripsiTabel2.Text, EnkripsiTabel3.Text, EnkripsiTabel4.Text, EnkripsiTabel5.Text, EnkripsiTabel6.Text, EnkripsiTabel7.Text, EnkripsiTabel8.Text, EnkripsiTabel9.Text)
            load_tabel_enkripsi()
            LoadDivKoefisien()
            'Dialog Konfirmasi sukses
            Telerik.WinControls.RadMessageBox.Show("Setting Label tersimpan. Harap Restart", "Simpan Setting Label", MessageBoxButtons.OK, RadMessageIcon.Info)
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Simpan Setting Label", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Dim direktori_pemilik As String
    Private Sub PicturePemilik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicturePemilik.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            direktori_pemilik = OpenFileDialog1.FileName
            PicturePemilik.Text = ""
            PicturePemilik.BackgroundImage = System.Drawing.Image.FromFile(direktori_pemilik)
        End If
    End Sub

    Private Sub PicturePemilik_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicturePemilik.MouseEnter
        CType(Me.PicturePemilik.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 4.0!
    End Sub

    Private Sub PicturePemilik_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PicturePemilik.MouseLeave
        CType(PicturePemilik.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 1.0!
    End Sub

    Dim direktori_logo As String = ""
    Private Sub PictureLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureLogo.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            direktori_logo = OpenFileDialog1.FileName
            PictureLogo.Text = ""
            PictureLogo.BackgroundImage = System.Drawing.Image.FromFile(direktori_logo)
        End If
    End Sub

    Private Sub PictureLogo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureLogo.MouseEnter
        CType(Me.PictureLogo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 4.0!
    End Sub

    Private Sub PictureLogo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureLogo.MouseLeave
        CType(PictureLogo.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Width = 1.0!
    End Sub

    Private Sub RichTextBox_catatan_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox_catatan.Enter
        RichTextBox_catatan.Location = New System.Drawing.Point(15, 190)
        RichTextBox_catatan.Size = New System.Drawing.Size(264, 90)
        Label8.Visible = False
    End Sub

    Private Sub RichTextBox_catatan_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox_catatan.Leave
        RichTextBox_catatan.Location = New System.Drawing.Point(112, 190)
        RichTextBox_catatan.Size = New System.Drawing.Size(167, 90)
        Label8.Visible = True
    End Sub

    Private Sub RichTextBox_catatankaki_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox_catatankaki.Enter
        RichTextBox_catatankaki.Location = New System.Drawing.Point(15, 286)
        RichTextBox_catatankaki.Size = New System.Drawing.Size(264, 90)
        Label9.Visible = False
    End Sub

    Private Sub RichTextBox_catatankaki_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox_catatankaki.Leave
        RichTextBox_catatankaki.Location = New System.Drawing.Point(112, 286)
        RichTextBox_catatankaki.Size = New System.Drawing.Size(167, 90)
        Label9.Visible = True
    End Sub

    Private id_lama As String = ""
    Private Sub ButtonEdit_SetAdmin_Click(sender As System.Object, e As System.EventArgs) Handles ButtonEdit_SetAdmin.Click
        id_lama = CStr(DataGridView_user.Rows(DataGridView_user.CurrentRow.Index).Cells(0).Value)
        TextBox_nama_id.Text = CStr(DataGridView_user.Rows(DataGridView_user.CurrentRow.Index).Cells(0).Value)
        If TextBox_nama_id.Text = "admin" Then
            TextBox_nama_id.Enabled = False
            ComboBox_hak_user.Enabled = False
        Else
            TextBox_nama_id.Enabled = True
            ComboBox_hak_user.Enabled = True
        End If
        ComboBox_hak_user.Text = CStr(DataGridView_user.Rows(DataGridView_user.CurrentRow.Index).Cells(2).Value)
        Button2.Enabled = True
        Button3.Enabled = True
        ButtonBaru_SetAdmin.Enabled = False
        ButtonHapus_SetAdmin.Enabled = False
        ButtonEdit_SetAdmin.Enabled = False
        TextBox_password.Enabled = True
        TextBox_confirm.Enabled = True
        RadLabel20.Text = "Edit"
    End Sub

    Private Sub TabControl1_SelectedPageChanging(sender As System.Object, e As Telerik.WinControls.UI.RadPageViewCancelEventArgs) Handles RadPageView_Setting.SelectedPageChanging
        If e.Page.Name = "Pages_Theme" Then
            If SettingAuthority.SettingCounter.Tema = False Then
                aksesdenied()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub EnkripsiTabelDiv_TextChanged(sender As System.Object, e As System.EventArgs) Handles EnkripsiTabel9.TextChanged, EnkripsiTabel8.TextChanged, EnkripsiTabel7.TextChanged, EnkripsiTabel6.TextChanged, EnkripsiTabel5.TextChanged, EnkripsiTabel4.TextChanged, EnkripsiTabel3.TextChanged, EnkripsiTabel2.TextChanged, EnkripsiTabel1.TextChanged, EnkripsiTabel05.TextChanged, EnkripsiTabel0.TextChanged
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub

    Private Sub RadRadioButton1_ToggleStateChanged(sender As System.Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles RadRadioButton1.ToggleStateChanged, RadRadioButton2.ToggleStateChanged
        If RadRadioButton1.IsChecked = True Then
            TableLayoutPanel6.Enabled = False
        Else
            TableLayoutPanel6.Enabled = True
        End If
    End Sub

    Private Sub RadButton2_Click(sender As System.Object, e As System.EventArgs) Handles RadButton2.Click
        With My.Settings
            If RadRadioButton1.IsChecked = True Then
                .IsServer = True
            Else
                .IsServer = False
            End If
            .Server = RadSpinEditor1.Value.ToString & "." & RadSpinEditor2.Value.ToString & "." & RadSpinEditor3.Value.ToString & "." & RadSpinEditor4.Value.ToString
            .FolderNota = RadBrowseEditor1.Value
            .Save()
        End With
        IsServer = My.Settings.IsServer
        Server = My.Settings.Server
    End Sub


    Private Sub Preferences_Penjualan_RadButton_Save_Click(sender As Object, e As EventArgs) Handles Preferences_Penjualan_RadButton_Save.Click
        Try
            Using tabel_preferensipenjualanTableAdapter = New tokoDataSetTableAdapters.tabel_preferensi_penjualanTableAdapter
                Dim AutoPrint As String = ""
                If Preferences_Penjualan_RadRadioButton_PenjualanSmall.IsChecked = True Then
                    AutoPrint = "AutoSmall"
                ElseIf Preferences_Penjualan_RadRadioButton_PenjualanNormal.IsChecked = True Then
                    AutoPrint = "AutoBig"
                ElseIf Preferences_Penjualan_RadRadioButton_PenjualanManual.IsChecked = True Then
                    AutoPrint = "Manual"
                End If
                tabel_preferensipenjualanTableAdapter.UpdateQuery(Preferences_Penjualan_RadDropDownList_IDCustomer.Text, _
                                                                  Preferences_Penjualan_RadDropDownList_Sales.Text, _
                                                                  AutoPrint, _
                                                                  Preferences_Penjualan_RadSpinEditor_1.Value, _
                                                                  Preferences_Penjualan_RadSpinEditor_2.Value, _
                                                                  Preferences_Penjualan_RadSpinEditor_3.Value, _
                                                                  Preferences_Penjualan_RadSpinEditor_4.Value, _
                                                                  Preferences_Penjualan_RadCheckBox_AutoDiskon.Checked, _
                                                                  Preferences_Penjualan_RadSpinEditor_Auto.Value, _
                                                                  Preferences_Penjualan_RadTextBox_Header.Text, _
                                                                  Preferences_Penjualan_RadTextBox_Footer.Text)
                LoadPreferensiPenjualanFromDatabase()
                RadMessageBox.Show("Penyimpanan Setting Preferensi Penjualan berhasil!", "Setting Preferensi Penjualan", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString, "Setting Preferensi Penjualan", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub LoadPreferensiPenjualan()
        Using tabel_customerTableAdapter = New tokoDataSetTableAdapters.tabel_customerTableAdapter
            Using dt As DataTable = tabel_customerTableAdapter.GetData()
                If dt.Rows.Count > 0 Then
                    Preferences_Penjualan_RadDropDownList_IDCustomer.Items.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        Preferences_Penjualan_RadDropDownList_IDCustomer.Items.Add(dt.Rows(i).Item("id_customer"))
                    Next
                End If
                Preferences_Penjualan_RadDropDownList_IDCustomer.Text = SettingPreferensi.Penjualan.IDCustomer
            End Using
        End Using

        Using tabel_salesTableAdapter = New tokoDataSetTableAdapters.tabel_salesTableAdapter
            Using dt As DataTable = tabel_salesTableAdapter.GetData()
                If dt.Rows.Count > 0 Then
                    Preferences_Penjualan_RadDropDownList_Sales.Items.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        Preferences_Penjualan_RadDropDownList_Sales.Items.Add(dt.Rows(i).Item("nama"))
                    Next
                End If
                Preferences_Penjualan_RadDropDownList_Sales.Text = SettingPreferensi.Penjualan.Sales
            End Using
        End Using

        Select Case SettingPreferensi.Penjualan.AutoPrint
            Case "AutoSmall"
                Preferences_Penjualan_RadRadioButton_PenjualanSmall.IsChecked = True
            Case "AutoBig"
                Preferences_Penjualan_RadRadioButton_PenjualanNormal.IsChecked = True
            Case "Manual"
                Preferences_Penjualan_RadRadioButton_PenjualanManual.IsChecked = True
        End Select

        Preferences_Penjualan_RadSpinEditor_1.Value = SettingPreferensi.Penjualan.Diskon1
        Preferences_Penjualan_RadSpinEditor_2.Value = SettingPreferensi.Penjualan.Diskon2
        Preferences_Penjualan_RadSpinEditor_3.Value = SettingPreferensi.Penjualan.Diskon3
        Preferences_Penjualan_RadSpinEditor_4.Value = SettingPreferensi.Penjualan.Diskon4

        Preferences_Penjualan_RadCheckBox_AutoDiskon.Checked = SettingPreferensi.Penjualan.IsAutoDiskon
        Preferences_Penjualan_RadSpinEditor_Auto.Value = SettingPreferensi.Penjualan.AutoDiskon

        Preferences_Penjualan_RadTextBox_Header.Text = SettingPreferensi.Penjualan.HeaderSmallNota
        Preferences_Penjualan_RadTextBox_Footer.Text = SettingPreferensi.Penjualan.FooterSmallNota
    End Sub

    Private Sub LoadPreferensiOrder()
        Using tabel_customerTableAdapter = New tokoDataSetTableAdapters.tabel_customerTableAdapter
            Using dt As DataTable = tabel_customerTableAdapter.GetDataOrderSpecial()
                If dt.Rows.Count > 0 Then
                    Preferences_Order_RadDropDownList_IDCustomer.Items.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        Preferences_Order_RadDropDownList_IDCustomer.Items.Add(dt.Rows(i).Item("id_customer"))
                    Next
                End If
                Preferences_Order_RadDropDownList_IDCustomer.Text = SettingPreferensi.Order.IDCustomer
            End Using
        End Using

        Using tabel_salesTableAdapter = New tokoDataSetTableAdapters.tabel_salesTableAdapter
            Using dt As DataTable = tabel_salesTableAdapter.GetData()
                If dt.Rows.Count > 0 Then
                    Preferences_Order_RadDropDownList_Sales.Items.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        Preferences_Order_RadDropDownList_Sales.Items.Add(dt.Rows(i).Item("nama"))
                    Next
                End If
                Preferences_Order_RadDropDownList_Sales.Text = SettingPreferensi.Order.Sales
            End Using
        End Using

        If SettingPreferensi.Order.Nota = "Big" Then
            Preferences_Order_RadRadioButton_BigNota.IsChecked = True
        Else
            Preferences_Order_RadRadioButton_Simple.IsChecked = True
        End If
    End Sub

    Private Sub LoadPreferensiBrgMasuk()
        Using tabel_supplierTableAdapter = New tokoDataSetTableAdapters.tabel_supplierTableAdapter
            Using dt As DataTable = tabel_supplierTableAdapter.GetData()
                If dt.Rows.Count > 0 Then
                    Preferences_BrgMasuk_RadDropDownList_IDSupplier.Items.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        Preferences_BrgMasuk_RadDropDownList_IDSupplier.Items.Add(dt.Rows(i).Item("id_supplier"))
                    Next
                End If
                Preferences_BrgMasuk_RadDropDownList_IDSupplier.Text = SettingPreferensi.BarangMasuk.IDSupplier
            End Using
        End Using

        If SettingPreferensi.BarangMasuk.AutoTipeBarang = "Semua" Then
            Preferences_BrgMasuk_RadRadioButton_Semua.IsChecked = True
        Else
            Preferences_BrgMasuk_RadRadioButton_Tertentu.IsChecked = True
        End If

        Using tabel_tipe_barangTableAdapter = New tokoDataSetTableAdapters.tabel_tipe_barangTableAdapter
            Using dt As DataTable = tabel_tipe_barangTableAdapter.GetData()
                If dt.Rows.Count > 0 Then
                    Preferences_BrgMasuk_RadAutoCompleteBox_Tertentu.AutoCompleteItems.Clear()
                    For i = 0 To dt.Rows.Count - 1
                        Preferences_BrgMasuk_RadAutoCompleteBox_Tertentu.AutoCompleteItems.Add(dt.Rows(i).Item("tipe"))
                    Next
                End If
                Preferences_BrgMasuk_RadAutoCompleteBox_Tertentu.Text = SettingPreferensi.BarangMasuk.Tertentu & ""
            End Using
        End Using

        If SettingPreferensi.BarangMasuk.IsiHargaRetail = "Manual" Then
            Preferences_BrgMasuk_RadRadioButton_Manual.IsChecked = True
        Else
            Preferences_BrgMasuk_RadRadioButton_HRetail.IsChecked = True
        End If

        Preferences_BrgMasuk_RadSpinEditor_AutoRetail.Value = SettingPreferensi.BarangMasuk.AutoRetail
        
        If SettingPreferensi.BarangMasuk.KertasLabel = "A4" Then
            Preferences_BrgMasuk_RadRadioButton_KertasLbl_A4.IsChecked = True
        Else
            Preferences_BrgMasuk_RadRadioButton_KertasLbl_Dbl.IsChecked = True
        End If

    End Sub

    Private Sub Preferences_Penjualan_RadCheckBox_AutoDiskon_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles Preferences_Penjualan_RadCheckBox_AutoDiskon.ToggleStateChanged
        If Preferences_Penjualan_RadCheckBox_AutoDiskon.Checked = True Then
            Preferences_Penjualan_RadSpinEditor_Auto.Enabled = True
        Else
            Preferences_Penjualan_RadSpinEditor_Auto.Enabled = False
        End If
    End Sub

    Private Sub Preferences_BrgMasuk_RadRadioButton_HRetail_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles Preferences_BrgMasuk_RadRadioButton_HRetail.ToggleStateChanged
        If Preferences_BrgMasuk_RadRadioButton_HRetail.IsChecked = False Then
            Preferences_BrgMasuk_RadSpinEditor_AutoRetail.Enabled = False
        Else
            Preferences_BrgMasuk_RadSpinEditor_AutoRetail.Enabled = True
        End If
    End Sub

    Private Sub Preferences_BrgMasuk_RadRadioButton_Tertentu_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles Preferences_BrgMasuk_RadRadioButton_Tertentu.ToggleStateChanged
        If Preferences_BrgMasuk_RadRadioButton_Tertentu.IsChecked = False Then
            Preferences_BrgMasuk_RadAutoCompleteBox_Tertentu.Enabled = False
        Else
            Preferences_BrgMasuk_RadAutoCompleteBox_Tertentu.Enabled = True
        End If
    End Sub

    Private Sub Preferences_Order_RadButton_Save_Click(sender As Object, e As EventArgs) Handles Preferences_Order_RadButton_Save.Click
        Try
            Using tabel_preferensi_orderTableAdapter = New tokoDataSetTableAdapters.tabel_preferensi_orderTableAdapter
                Dim Nota As String = ""
                If Preferences_Order_RadRadioButton_BigNota.IsChecked = True Then
                    Nota = "Big"
                ElseIf Preferences_Order_RadRadioButton_Simple.IsChecked = True Then
                    Nota = "Simple"
                End If
                tabel_preferensi_orderTableAdapter.UpdateQuery(Preferences_Order_RadDropDownList_IDCustomer.Text, _
                                                                  Preferences_Order_RadDropDownList_Sales.Text, _
                                                                  Nota)
                LoadPreferensiOrderFromDatabase()
                RadMessageBox.Show("Penyimpanan Setting Preferensi Order berhasil!", "Setting Preferensi Order", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString, "Setting Preferensi Order", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub Preferences_BrgMasuk_RadButton_Save_Click(sender As Object, e As EventArgs) Handles Preferences_BrgMasuk_RadButton_Save.Click
        Try
            Using tabel_preferensi_brgmasukTableAdapter = New tokoDataSetTableAdapters.tabel_preferensi_brgmasukTableAdapter
                Dim AutoTipeBarang As String = ""
                If Preferences_BrgMasuk_RadRadioButton_Semua.IsChecked = True Then
                    AutoTipeBarang = "Semua"
                ElseIf Preferences_BrgMasuk_RadRadioButton_Tertentu.IsChecked = True Then
                    AutoTipeBarang = "Tertentu"
                End If

                Dim IsiHargaRetail As String = ""
                If Preferences_BrgMasuk_RadRadioButton_Manual.IsChecked = True Then
                    IsiHargaRetail = "Manual"
                ElseIf Preferences_BrgMasuk_RadRadioButton_HRetail.IsChecked = True Then
                    IsiHargaRetail = "Auto"
                End If

                Dim KertasLabel As String = ""
                If Preferences_BrgMasuk_RadRadioButton_KertasLbl_A4.IsChecked = True Then
                    KertasLabel = "A4"
                ElseIf Preferences_BrgMasuk_RadRadioButton_KertasLbl_Dbl.IsChecked = True Then
                    KertasLabel = "DoubleLine"
                End If
                tabel_preferensi_brgmasukTableAdapter.UpdateQuery(Preferences_BrgMasuk_RadDropDownList_IDSupplier.Text, _
                                                                  AutoTipeBarang, _
                                                                  Preferences_BrgMasuk_RadAutoCompleteBox_Tertentu.Text, _
                                                                  IsiHargaRetail, _
                                                                  Preferences_BrgMasuk_RadSpinEditor_AutoRetail.Value, _
                                                                  KertasLabel)
                LoadPreferensiBarangMasukFromDatabase()
                RadMessageBox.Show("Penyimpanan Setting Preferensi Barang Masuk berhasil!", "Setting Preferensi Barang Masuk", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Using
        Catch ex As Exception
            RadMessageBox.Show(ex.Message.ToString, "Setting Preferensi Barang Masuk", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub Preferences_BrgMasuk_RadRadioButton_KertasLbl_A4_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles Preferences_BrgMasuk_RadRadioButton_KertasLbl_A4.ToggleStateChanged
        If Preferences_BrgMasuk_RadRadioButton_KertasLbl_A4.IsChecked = True Then
            Preferences_BrgMasuk_RadRadioButton_KertasLbl_Dbl.IsChecked = False
        End If
    End Sub

    Private Sub Preferences_BrgMasuk_RadRadioButton_KertasLbl_DblLine_ToggleStateChanged(sender As Object, args As UI.StateChangedEventArgs) Handles Preferences_BrgMasuk_RadRadioButton_KertasLbl_Dbl.ToggleStateChanged
        If Preferences_BrgMasuk_RadRadioButton_KertasLbl_Dbl.IsChecked = True Then
            Preferences_BrgMasuk_RadRadioButton_KertasLbl_A4.IsChecked = False
        End If
    End Sub

    Private Sub EnkripsiTabelDivDropDownList_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles EnkripsiTabelDivDropDownList.SelectedIndexChanged
        If RadButton4.Enabled = False And load_complete = True Then
            RadButton4.Enabled = True
        End If
    End Sub
End Class