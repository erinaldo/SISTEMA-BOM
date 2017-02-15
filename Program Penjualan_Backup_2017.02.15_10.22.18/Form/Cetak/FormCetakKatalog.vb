Imports Telerik.Reporting.Drawing

Public Class FormCetakKatalog

    Public Property katalog As UC_BarangMasuk.for_katalog()

    Private Sub FormKatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pos As Double = 0.0R
        Dim pos_X As Double = 0
        Dim pos_Y As Double = 0
        Dim N As Integer = katalog.Length
        Dim panel(N) As Telerik.Reporting.Panel
        Dim picture(N) As Telerik.Reporting.PictureBox
        Dim teks_keterangan(N) As Telerik.Reporting.TextBox
        Dim teksbox_kotak12(N) As Telerik.Reporting.TextBox
        Dim shape1(N) As Telerik.Reporting.Shape
        Dim shape2(N) As Telerik.Reporting.Shape
        Dim shape3(N) As Telerik.Reporting.Shape
        Dim teks_namabrg(N) As Telerik.Reporting.TextBox
        Dim teks_valnamabrg(N) As Telerik.Reporting.TextBox
        Dim teks_hargabrg(N) As Telerik.Reporting.TextBox
        Dim teks_valhargabrg(N) As Telerik.Reporting.TextBox
        For i = 0 To N - 1
            If Unit.Cm(pos) > ReportLabel1.Width Then
                pos = 10.0R
                pos_Y += 8.8R
                pos_X = 0.0R
            Else
                pos += 10.0R
            End If

            shape3(i) = New Telerik.Reporting.Shape
            shape3(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 4.7R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 4.2R))
            shape3(i).Name = "Shape3" & i
            shape3(i).ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
            shape3(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9R), Telerik.Reporting.Drawing.Unit.Cm(0.2R))
            shape3(i).Stretch = True
            shape3(i).Style.BorderColor.Top = System.Drawing.Color.Silver
            shape3(i).Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
            shape3(i).Style.Color = System.Drawing.Color.Transparent
            shape3(i).Style.LineColor = System.Drawing.Color.Black
            shape3(i).Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid

            teks_valhargabrg(i) = New Telerik.Reporting.TextBox
            teks_valhargabrg(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 5.0R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 3.3R))
            teks_valhargabrg(i).Name = "TextBox2" & i
            teks_valhargabrg(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
            teks_valhargabrg(i).Style.Color = System.Drawing.SystemColors.Highlight
            teks_valhargabrg(i).Style.Font.Name = "Segoe UI"
            teks_valhargabrg(i).Style.LineColor = System.Drawing.Color.Black
            teks_valhargabrg(i).Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
            teks_valhargabrg(i).Value = CStr(katalog(i).harga)

            teks_hargabrg(i) = New Telerik.Reporting.TextBox
            teks_hargabrg(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 4.7R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 2.6R))
            teks_hargabrg(i).Name = "TextBox4" & i
            teks_hargabrg(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9R), Telerik.Reporting.Drawing.Unit.Cm(0.7R))
            teks_hargabrg(i).Style.Color = System.Drawing.SystemColors.Highlight
            teks_hargabrg(i).Style.Font.Bold = True
            teks_hargabrg(i).Style.Font.Name = "Segoe UI Light"
            teks_hargabrg(i).Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
            teks_hargabrg(i).Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
            teks_hargabrg(i).Value = "Harga Barang"

            shape1(i) = New Telerik.Reporting.Shape
            shape1(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 4.7R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 2.3R))
            shape1(i).Name = "Shape1" & i
            shape1(i).ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
            shape1(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9R), Telerik.Reporting.Drawing.Unit.Cm(0.2R))
            shape1(i).Stretch = True
            shape1(i).Style.BorderColor.Top = System.Drawing.Color.Silver
            shape1(i).Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
            shape1(i).Style.Color = System.Drawing.Color.Transparent
            shape1(i).Style.LineColor = System.Drawing.Color.Black
            shape1(i).Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid

            teks_valnamabrg(i) = New Telerik.Reporting.TextBox
            teks_valnamabrg(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 4.9998998641967773R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 1.3999998569488525R))
            teks_valnamabrg(i).Name = "TextBox3" & i
            teks_valnamabrg(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.6R), Telerik.Reporting.Drawing.Unit.Cm(0.6R))
            teks_valnamabrg(i).Style.Color = System.Drawing.SystemColors.Highlight
            teks_valnamabrg(i).Style.Font.Name = "Segoe UI"
            teks_valnamabrg(i).Style.LineColor = System.Drawing.Color.Black
            teks_valnamabrg(i).Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
            teks_valnamabrg(i).Value = katalog(i).nama_brg

            teks_namabrg(i) = New Telerik.Reporting.TextBox
            teks_namabrg(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 4.7000002861022949R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 0.69979959726333618R))
            teks_namabrg(i).Name = "TextBox1" & i
            teks_namabrg(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9R), Telerik.Reporting.Drawing.Unit.Cm(0.7R))
            teks_namabrg(i).Style.Color = System.Drawing.SystemColors.Highlight
            teks_namabrg(i).Style.Font.Bold = True
            teks_namabrg(i).Style.Font.Name = "Segoe UI Light"
            teks_namabrg(i).Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
            teks_namabrg(i).Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
            teks_namabrg(i).Value = "Nama Barang"

            shape2(i) = New Telerik.Reporting.Shape
            shape2(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 4.7R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 0.4R))
            shape2(i).Name = "Shape2" & i
            shape2(i).ShapeType = New Telerik.Reporting.Drawing.Shapes.LineShape(Telerik.Reporting.Drawing.Shapes.LineDirection.EW)
            shape2(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.9R), Telerik.Reporting.Drawing.Unit.Cm(0.2R))
            shape2(i).Stretch = True
            shape2(i).Style.BorderColor.Top = System.Drawing.Color.Silver
            shape2(i).Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
            shape2(i).Style.Color = System.Drawing.Color.Transparent
            shape2(i).Style.LineColor = System.Drawing.Color.Black
            shape2(i).Style.LineStyle = Telerik.Reporting.Drawing.LineStyle.Solid

            teksbox_kotak12(i) = New Telerik.Reporting.TextBox
            teksbox_kotak12(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 0.4R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 5.4R))
            teksbox_kotak12(i).Name = "TextBox12" & i
            teksbox_kotak12(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(8.21R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
            teksbox_kotak12(i).Style.BorderColor.Default = System.Drawing.Color.Silver
            teksbox_kotak12(i).Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
            teksbox_kotak12(i).Value = " "

            teks_keterangan(i) = New Telerik.Reporting.TextBox
            teks_keterangan(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 0.4), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 4.7R))
            teks_keterangan(i).Name = "teks_keterangan" & i
            teks_keterangan(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9R), Telerik.Reporting.Drawing.Unit.Cm(0.7R))
            teks_keterangan(i).Style.Color = System.Drawing.SystemColors.Highlight
            teks_keterangan(i).Style.Font.Bold = True
            teks_keterangan(i).Style.Font.Name = "Segoe UI Light"
            teks_keterangan(i).Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
            teks_keterangan(i).Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
            teks_keterangan(i).Value = "Keterangan  :"

            picture(i) = New Telerik.Reporting.PictureBox
            picture(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X + 0.4R), Telerik.Reporting.Drawing.Unit.Cm(pos_Y + 0.4R))
            picture(i).MimeType = "image/png"
            picture(i).Name = "picture" & i
            picture(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0R), Telerik.Reporting.Drawing.Unit.Cm(4.0R))
            picture(i).Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
            picture(i).Style.BorderColor.Default = System.Drawing.Color.Silver
            picture(i).Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
            picture(i).Value = katalog(i).gambar

            panel(i) = New Telerik.Reporting.Panel
            panel(i).Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(pos_X), Telerik.Reporting.Drawing.Unit.Cm(pos_Y))
            panel(i).Name = "Panel1" & i
            panel(i).Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.0R), Telerik.Reporting.Drawing.Unit.Cm(8.3R))
            panel(i).Style.BorderColor.Default = System.Drawing.Color.Silver
            panel(i).Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
            pos_X += 10.0R

            ReportLabel1.detail.Items.Add(panel(i))
            ReportLabel1.detail.Items.Add(picture(i))
            ReportLabel1.detail.Items.Add(teks_keterangan(i))
            ReportLabel1.detail.Items.Add(teksbox_kotak12(i))
            ReportLabel1.detail.Items.Add(shape1(i))
            ReportLabel1.detail.Items.Add(shape2(i))
            ReportLabel1.detail.Items.Add(shape3(i))
            ReportLabel1.detail.Items.Add(teks_namabrg(i))
            ReportLabel1.detail.Items.Add(teks_valnamabrg(i))
            ReportLabel1.detail.Items.Add(teks_hargabrg(i))
            ReportLabel1.detail.Items.Add(teks_valhargabrg(i))
        Next

        Dim teks_header As Telerik.Reporting.TextBox
        teks_header = New Telerik.Reporting.TextBox
        teks_header.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        teks_header.Name = "TextBox11"
        teks_header.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.0R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        teks_header.Style.Color = System.Drawing.SystemColors.Highlight
        teks_header.Style.Font.Bold = True
        teks_header.Style.Font.Name = "Segoe UI Light"
        teks_header.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        teks_header.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        teks_header.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        teks_header.Value = "Katalog Barang"
        ReportLabel1.PageHeaderSection1.Items.Add(teks_header)

        ReportViewer1.RefreshReport()
    End Sub
End Class