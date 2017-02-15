Partial Class ReportLabel
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportLabel))
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.PanelLabel = New Telerik.Reporting.Panel()
        Me.KodebarangBarcode = New Telerik.Reporting.Barcode()
        Me.NamaBarang = New Telerik.Reporting.TextBox()
        Me.HRetail = New Telerik.Reporting.TextBox()
        Me.LogoPerusahaan = New Telerik.Reporting.PictureBox()
        Me.NamaPerusahaan = New Telerik.Reporting.TextBox()
        Me.HGrosir = New Telerik.Reporting.TextBox()
        Me.KodeBarang = New Telerik.Reporting.TextBox()
        Me.PageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(4.0R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PanelLabel})
        Me.detail.KeepTogether = True
        Me.detail.Name = "detail"
        Me.detail.PageBreak = CType((Telerik.Reporting.PageBreak.Before Or Telerik.Reporting.PageBreak.After), Telerik.Reporting.PageBreak)
        Me.detail.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.None
        '
        'PanelLabel
        '
        Me.PanelLabel.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.KodebarangBarcode, Me.NamaBarang, Me.HRetail, Me.LogoPerusahaan, Me.NamaPerusahaan, Me.HGrosir, Me.KodeBarang})
        Me.PanelLabel.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.PanelLabel.Name = "PanelLabel"
        Me.PanelLabel.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(4.0R))
        Me.PanelLabel.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.PanelLabel.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid
        Me.PanelLabel.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.5R)
        Me.PanelLabel.Style.Visible = False
        '
        'KodebarangBarcode
        '
        Me.KodebarangBarcode.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(1.6000000238418579R))
        Me.KodebarangBarcode.Name = "KodebarangBarcode"
        Me.KodebarangBarcode.ShowText = False
        Me.KodebarangBarcode.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.KodebarangBarcode.Stretch = True
        Me.KodebarangBarcode.Style.Font.Name = "Tahoma"
        Me.KodebarangBarcode.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.KodebarangBarcode.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.KodebarangBarcode.Symbology = Telerik.Reporting.Barcode.SymbologyType.Code128
        Me.KodebarangBarcode.Value = "BAM-000000"
        '
        'NamaBarang
        '
        Me.NamaBarang.CanGrow = False
        Me.NamaBarang.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(2.6002001762390137R))
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(0.800000011920929R))
        Me.NamaBarang.Style.Font.Name = "Tahoma"
        Me.NamaBarang.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.NamaBarang.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.NamaBarang.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.NamaBarang.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Top
        Me.NamaBarang.Value = "Nama Barang Pedas Dijalan Medan Merdeka"
        '
        'HRetail
        '
        Me.HRetail.CanGrow = False
        Me.HRetail.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(3.3999998569488525R))
        Me.HRetail.Name = "HRetail"
        Me.HRetail.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.6000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.40000036358833313R))
        Me.HRetail.Style.Font.Bold = True
        Me.HRetail.Style.Font.Name = "Tahoma"
        Me.HRetail.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.5R)
        Me.HRetail.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.HRetail.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.HRetail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.HRetail.Value = "Rp. 2.000"
        '
        'LogoPerusahaan
        '
        Me.LogoPerusahaan.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R))
        Me.LogoPerusahaan.MimeType = "image/png"
        Me.LogoPerusahaan.Name = "LogoPerusahaan"
        Me.LogoPerusahaan.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.LogoPerusahaan.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.LogoPerusahaan.Value = CType(resources.GetObject("LogoPerusahaan.Value"), Object)
        '
        'NamaPerusahaan
        '
        Me.NamaPerusahaan.CanGrow = False
        Me.NamaPerusahaan.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R))
        Me.NamaPerusahaan.Name = "NamaPerusahaan"
        Me.NamaPerusahaan.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.NamaPerusahaan.Style.Font.Name = "Tahoma"
        Me.NamaPerusahaan.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.NamaPerusahaan.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.NamaPerusahaan.Value = "PT MJ"
        '
        'HGrosir
        '
        Me.HGrosir.CanGrow = False
        Me.HGrosir.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.0R), Telerik.Reporting.Drawing.Unit.Cm(1.2000000476837158R))
        Me.HGrosir.Name = "HGrosir"
        Me.HGrosir.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.90000015497207642R), Telerik.Reporting.Drawing.Unit.Cm(0.39979997277259827R))
        Me.HGrosir.Style.Font.Name = "Tahoma"
        Me.HGrosir.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(7.0R)
        Me.HGrosir.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.HGrosir.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.HGrosir.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.HGrosir.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.HGrosir.Value = "YA"
        '
        'KodeBarang
        '
        Me.KodeBarang.CanGrow = False
        Me.KodeBarang.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Cm(1.2000000476837158R))
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.6997997760772705R), Telerik.Reporting.Drawing.Unit.Cm(0.39979997277259827R))
        Me.KodeBarang.Style.Font.Name = "Tahoma"
        Me.KodeBarang.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.KodeBarang.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.KodeBarang.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.KodeBarang.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.KodeBarang.Value = "BAM-000000"
        '
        'PageHeaderSection1
        '
        Me.PageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.PageHeaderSection1.Name = "PageHeaderSection1"
        '
        'ReportLabel
        '
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.detail, Me.PageHeaderSection1})
        Me.Name = "ReportLabel"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(210.0R), Telerik.Reporting.Drawing.Unit.Mm(295.0R))
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.200000762939453R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    'Friend lebar_detail As Double
    Public WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents PageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents PanelLabel As Telerik.Reporting.Panel
    Friend WithEvents KodebarangBarcode As Telerik.Reporting.Barcode
    Friend WithEvents NamaBarang As Telerik.Reporting.TextBox
    Friend WithEvents HRetail As Telerik.Reporting.TextBox
    Friend WithEvents LogoPerusahaan As Telerik.Reporting.PictureBox
    Friend WithEvents NamaPerusahaan As Telerik.Reporting.TextBox
    Friend WithEvents HGrosir As Telerik.Reporting.TextBox
    Friend WithEvents KodeBarang As Telerik.Reporting.TextBox
End Class