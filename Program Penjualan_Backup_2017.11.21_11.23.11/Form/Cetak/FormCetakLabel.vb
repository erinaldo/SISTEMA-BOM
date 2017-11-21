Imports Telerik.Reporting.Drawing

Public Class FormCetakLabel

    Public Property _label_ As UC_BarangMasuk._Label()

    Private Sub FormLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub inisiasi()
        Dim PanelLabel As Telerik.Reporting.Panel
        Dim KodebarangBarcode As Telerik.Reporting.Barcode
        Dim NamaBarang As Telerik.Reporting.TextBox
        Dim HRetail As Telerik.Reporting.TextBox
        Dim LogoPerusahaan As Telerik.Reporting.PictureBox
        Dim NamaPerusahaan As Telerik.Reporting.TextBox
        Dim HGrosir As Telerik.Reporting.TextBox
        Dim KodeBarang As Telerik.Reporting.TextBox

        If SettingPreferensi.BarangMasuk.KertasLabel = "A4" Then
            ReportLabel1.PageSettings.PaperKind = Printing.PaperKind.Custom
            ReportLabel1.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210.0R), Telerik.Reporting.Drawing.Unit.Mm(295.0R))
        Else
            ReportLabel1.PageSettings.PaperKind = Printing.PaperKind.A4
            ReportLabel1.PageSettings.Landscape = True
            ReportLabel1.Width = ReportLabel1.PageSettings.PaperSize.Height
            ReportLabel1.PageSettings.Margins = New MarginsU(Unit.Cm(0.0R), Unit.Cm(0.0R), Unit.Cm(9.2R), Unit.Cm(7.8R))
            'ReportLabel1.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210.0R), Telerik.Reporting.Drawing.Unit.Mm(80.0R))
            'ReportLabel1.Width = Unit.Cm(6.4R)
        End If

        Dim pos_X As Double = 0.0R
        Dim pos_Y As Double = 0.0R
        'MessageBox.Show(_label_.Length)
        For i = 0 To _label_.Length - 1
            For j = 0 To _label_(i).N - 1
                If Unit.Cm(pos_X + 3.2R) > ReportLabel1.Width Then
                    pos_X = 0.0R
                    pos_Y += 4.0R
                End If
                '
                'NamaBarang
                '
                NamaBarang = New Telerik.Reporting.TextBox
                NamaBarang.CanGrow = False
                NamaBarang.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(2.6002001762390137R))
                NamaBarang.Name = "NamaBarang"
                NamaBarang.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
                NamaBarang.Style.Font.Name = "Tahoma"
                NamaBarang.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
                NamaBarang.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
                NamaBarang.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
                NamaBarang.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
                If SettingLabel.NamaBarang = True Then
                    NamaBarang.Value = _label_(i).nm_brg
                End If
                '
                'Kode Barang
                '
                KodeBarang = New Telerik.Reporting.TextBox
                KodeBarang.CanGrow = False
                KodeBarang.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Cm(1.2000000476837158R))
                KodeBarang.Name = "KodeBarang"
                KodeBarang.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6997997760772705R), Telerik.Reporting.Drawing.Unit.Cm(0.39979997277259827R))
                KodeBarang.Style.Font.Name = "Tahoma"
                KodeBarang.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
                KodeBarang.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
                KodeBarang.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
                KodeBarang.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
                If SettingLabel.Barcode = True Then
                    KodeBarang.Value = _label_(i).lbl_kode
                End If
                '
                'HRetail
                '
                HRetail = New Telerik.Reporting.TextBox
                HRetail.CanGrow = False
                HRetail.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(3.3999998569488525R))
                HRetail.Name = "HRetail"
                HRetail.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.40000036358833313R))
                HRetail.Style.Font.Bold = True
                HRetail.Style.Font.Name = "Tahoma"
                HRetail.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
                HRetail.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
                HRetail.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
                HRetail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
                If SettingLabel.HargaRetail = True Then
                    HRetail.Value = "Rp " & ubahtocurrencybyDiv(_label_(i).h_retail)
                End If
                '
                'NamaPerusahaan
                '
                NamaPerusahaan = New Telerik.Reporting.TextBox
                NamaPerusahaan.CanGrow = False
                NamaPerusahaan.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R))
                NamaPerusahaan.Name = "NamaPerusahaan"
                NamaPerusahaan.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
                NamaPerusahaan.Style.Font.Name = "Tahoma"
                NamaPerusahaan.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
                NamaPerusahaan.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
                If SettingLabel.StatNamaPerusahaan = True Then
                    NamaPerusahaan.Value = _label_(i).nama_perusahaan
                End If
                '
                'HGrosir
                '
                HGrosir = New Telerik.Reporting.TextBox
                HGrosir.CanGrow = False
                HGrosir.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(1.2000000476837158R))
                HGrosir.Name = "HGrosir"
                HGrosir.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.90000015497207642R), Telerik.Reporting.Drawing.Unit.Cm(0.39979997277259827R))
                HGrosir.Style.Font.Name = "Tahoma"
                HGrosir.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
                HGrosir.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
                HGrosir.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
                HGrosir.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
                HGrosir.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
                If SettingLabel.HargaGrosirEnkripsi = True Then
                    HGrosir.Value = enkripsi_simple(CInt(_label_(i).h_grosir))
                End If
                '
                'KodebarangBarcode
                '
                KodebarangBarcode = New Telerik.Reporting.Barcode
                KodebarangBarcode.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(1.6000000238418579R))
                KodebarangBarcode.Name = "KodebarangBarcode"
                KodebarangBarcode.ShowText = False
                KodebarangBarcode.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
                KodebarangBarcode.Stretch = True
                KodebarangBarcode.Style.Font.Name = "Tahoma"
                KodebarangBarcode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
                KodebarangBarcode.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
                KodebarangBarcode.Symbology = Telerik.Reporting.Barcode.SymbologyType.Code128
                If SettingLabel.Barcode = True Then
                    KodebarangBarcode.Value = _label_(i).lbl_kode
                End If
                '
                'LogoPerusahaan
                '
                LogoPerusahaan = New Telerik.Reporting.PictureBox
                LogoPerusahaan.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R))
                LogoPerusahaan.MimeType = "image/png"
                LogoPerusahaan.Name = "LogoPerusahaan"
                LogoPerusahaan.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
                LogoPerusahaan.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
                If SettingLabel.LogoPerusahaan = True Then
                    LogoPerusahaan.Value = _label_(i).gambar
                End If
                '
                PanelLabel = New Telerik.Reporting.Panel
                PanelLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X), Telerik.Reporting.Drawing.Unit.Cm(pos_Y))
                PanelLabel.Name = "PanelLabel" & j
                PanelLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2R), Telerik.Reporting.Drawing.Unit.Cm(4.0R))
                If SettingPreferensi.BarangMasuk.KertasLabel = "A4" Then
                    PanelLabel.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dashed
                    PanelLabel.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dashed
                End If
                PanelLabel.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Dashed
                PanelLabel.Style.BorderStyle.Right = Telerik.Reporting.Drawing.BorderType.Dashed
                PanelLabel.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
                PanelLabel.Items.AddRange(New Telerik.Reporting.ReportItemBase() {KodebarangBarcode, NamaBarang, HRetail, LogoPerusahaan, NamaPerusahaan, HGrosir, KodeBarang})
                ReportLabel1.detail.Items.Add(PanelLabel)
                pos_X += 3.2R
            Next
        Next

        ReportViewer1.RefreshReport()
    End Sub

    'Private Sub backup()
    '    'For i = 0 To _label_.Length - 1
    '    '    Dim ucLabel As UC_Label
    '    '    ucLabel = New UC_Label()
    '    '    ucLabel.Dock = DockStyle.Fill
    '    '    ucLabel.teks = _label_(i).lbl_kode
    '    '    ucLabel.banyak = _label_(i).N
    '    '    ucLabel.nama_perusahaan = _label_(i).nm_perusahaan
    '    '    ucLabel.nama_barang = _label_(i).nm_brg
    '    '    Dim tabpage As TabPage = New TabPage(_label_(i).lbl_kode)
    '    '    tabpage.Controls.Add(ucLabel)
    '    '    MetroTabControl1.TabPages.Add(tabpage)
    '    'Next

    '    Dim pos As Double
    '    Dim pos_X_shape As Double
    '    Dim pos_Y_shape As Double = 0.2R
    '    For j = 0 To _label_.Length - 1

    '        pos = 4.7R
    '        pos_X_shape = 0.0R

    '        Dim N As Integer = _label_(j).N
    '        Dim shape_square(N - 1) As Telerik.Reporting.Panel
    '        Dim label_barcode(N - 1) As Telerik.Reporting.TextBox
    '        Dim label_nama_barang(N - 1) As Telerik.Reporting.TextBox
    '        Dim label_id_barang(N - 1) As Telerik.Reporting.TextBox
    '        Dim label_harga_retail(N - 1) As Telerik.Reporting.TextBox

    '        Dim batas As Telerik.Reporting.TextBox
    '        batas = New Telerik.Reporting.TextBox
    '        batas.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y_shape - 0.2R))
    '        batas.Name = "batas"
    '        batas.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.0R), Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R))
    '        batas.Style.BorderColor.Top = System.Drawing.SystemColors.Highlight
    '        batas.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Double
    '        batas.Style.BorderWidth.Default = Unit.Point(2)
    '        batas.Value = ""


    '        For i = 0 To N - 1
    '            If Unit.Cm(pos) > ReportLabel1.Width Then
    '                pos = 9.4R
    '                pos_X_shape = 0.0R
    '                'atur posisi untuk kotak
    '                pos_Y_shape += 2.7R

    '            Else
    '                pos += 4.7R
    '            End If
    '            'Untuk membuat label nama brg
    '            label_nama_barang(i) = New Telerik.Reporting.TextBox
    '            label_nama_barang(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.7R), Telerik.Reporting.Drawing.Unit.Cm(0.2R))
    '            label_nama_barang(i).Name = "LabelPerusahaan" & i
    '            label_nama_barang(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5R), Telerik.Reporting.Drawing.Unit.Cm(0.4R))
    '            label_nama_barang(i).Style.Font.Name = "Segoe UI"
    '            label_nama_barang(i).Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
    '            label_nama_barang(i).Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
    '            label_nama_barang(i).Value = _label_(j).nm_brg
    '            'Untuk membuat label id barang
    '            label_id_barang(i) = New Telerik.Reporting.TextBox
    '            label_id_barang(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.7R), Telerik.Reporting.Drawing.Unit.Cm(1.7R))
    '            label_id_barang(i).Name = "LabelNamaBrg" & i
    '            label_id_barang(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5R), Telerik.Reporting.Drawing.Unit.Cm(0.4R))
    '            label_id_barang(i).Style.Font.Name = "Segoe UI"
    '            label_id_barang(i).Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
    '            label_id_barang(i).Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
    '            label_id_barang(i).Value = _label_(j).id_barang
    '            'Untuk membuat label barcodenya
    '            label_barcode(i) = New Telerik.Reporting.TextBox
    '            label_barcode(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.7R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
    '            label_barcode(i).Name = "Labelbarcode" & i
    '            label_barcode(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5R), Telerik.Reporting.Drawing.Unit.Cm(1.1R))
    '            label_barcode(i).Style.Font.Name = "Code 128"
    '            label_barcode(i).Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(35.0R)
    '            label_barcode(i).Style.VerticalAlign = VerticalAlign.Bottom
    '            label_barcode(i).Value = _label_(j).lbl_kode
    '            'Untuk membuat harga retail
    '            label_harga_retail(i) = New Telerik.Reporting.TextBox
    '            label_harga_retail(i).Angle = 90.0R
    '            label_harga_retail(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.05R), Telerik.Reporting.Drawing.Unit.Cm(0.2R))
    '            label_harga_retail(i).Name = "label_harga_retail" & i
    '            label_harga_retail(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.4R), Telerik.Reporting.Drawing.Unit.Cm(1.9R))
    '            label_harga_retail(i).Style.Font.Name = "Segoe UI"
    '            label_harga_retail(i).Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
    '            label_harga_retail(i).Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
    '            label_harga_retail(i).Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
    '            label_harga_retail(i).Value = "Rp " & ubahtocurrency(_label_(j).h_retail)
    '            'Untuk membuat kotak
    '            shape_square(i) = New Telerik.Reporting.Panel
    '            shape_square(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X_shape), Telerik.Reporting.Drawing.Unit.Cm(pos_Y_shape))
    '            shape_square(i).Name = "ShapeSquare" & i
    '            shape_square(i).Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
    '            'shape_square(i).ShapeType = New Telerik.Reporting.Drawing.Shapes.PolygonShape(4, 45.0R, 0)
    '            shape_square(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.5R), Telerik.Reporting.Drawing.Unit.Cm(2.4R))
    '            'shape_square(i).Stretch = True
    '            pos_X_shape += 4.7R

    '            'shape_square(i).Items.Add(shape_square(i))
    '            shape_square(i).Items.Add(label_barcode(i))
    '            shape_square(i).Items.Add(label_nama_barang(i))
    '            shape_square(i).Items.Add(label_id_barang(i))
    '            shape_square(i).Items.Add(label_harga_retail(i))

    '        Next
    '        ReportLabel1.detail.Items.AddRange(shape_square)
    '        ReportLabel1.detail.Items.Add(batas)

    '        'atur posisi untuk kotak
    '        pos_Y_shape += 3.2R
    '        'atur posisi untuk label nama perusahaan

    '    Next

    '    Dim teks_header As Telerik.Reporting.TextBox
    '    teks_header = New Telerik.Reporting.TextBox
    '    teks_header.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
    '    teks_header.Name = "NamaBarang1"
    '    teks_header.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.0R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
    '    teks_header.Style.Color = System.Drawing.SystemColors.Highlight
    '    teks_header.Style.Font.Bold = True
    '    teks_header.Style.Font.Name = "Segoe UI Light"
    '    teks_header.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
    '    teks_header.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
    '    teks_header.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
    '    teks_header.Value = "Label Barang"
    '    ReportLabel1.PageHeaderSection1.Items.Add(teks_header)

    '    ReportViewer1.RefreshReport()
    'End Sub

    Private Sub FormCetakLabel_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        inisiasi()
    End Sub
End Class