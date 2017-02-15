Partial Class ReportNotaPenjualanSmall

    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim FormattingRule1 As Telerik.Reporting.Drawing.FormattingRule = New Telerik.Reporting.Drawing.FormattingRule()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportNotaPenjualanSmall))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection = New Telerik.Reporting.GroupFooterSection()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox26 = New Telerik.Reporting.TextBox()
        Me.TextBox27 = New Telerik.Reporting.TextBox()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.TextBox30 = New Telerik.Reporting.TextBox()
        Me.TextBox32 = New Telerik.Reporting.TextBox()
        Me.TextBox33 = New Telerik.Reporting.TextBox()
        Me.TextBox35 = New Telerik.Reporting.TextBox()
        Me.TextBox36 = New Telerik.Reporting.TextBox()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.TextBox40 = New Telerik.Reporting.TextBox()
        Me.TextBox41 = New Telerik.Reporting.TextBox()
        Me.TextBox38 = New Telerik.Reporting.TextBox()
        Me.TextBox28 = New Telerik.Reporting.TextBox()
        Me.TextBox31 = New Telerik.Reporting.TextBox()
        Me.TextBox39 = New Telerik.Reporting.TextBox()
        Me.TextBox42 = New Telerik.Reporting.TextBox()
        Me.TextBox46 = New Telerik.Reporting.TextBox()
        Me.TextBox47 = New Telerik.Reporting.TextBox()
        Me.TextBox48 = New Telerik.Reporting.TextBox()
        Me.TextBox34 = New Telerik.Reporting.TextBox()
        Me.TextBox25 = New Telerik.Reporting.TextBox()
        Me.TextBox49 = New Telerik.Reporting.TextBox()
        Me.TextBox50 = New Telerik.Reporting.TextBox()
        Me.groupHeaderSection = New Telerik.Reporting.GroupHeaderSection()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox44 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.List1 = New Telerik.Reporting.List()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection
        '
        Me.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(6.0001978874206543R)
        Me.groupFooterSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox23, Me.TextBox24, Me.TextBox26, Me.TextBox27, Me.TextBox29, Me.TextBox30, Me.TextBox32, Me.TextBox33, Me.TextBox35, Me.TextBox36, Me.TextBox37, Me.TextBox40, Me.TextBox41, Me.TextBox38, Me.TextBox28, Me.TextBox31, Me.TextBox39, Me.TextBox42, Me.TextBox46, Me.TextBox47, Me.TextBox48, Me.TextBox34, Me.TextBox25, Me.TextBox49, Me.TextBox50})
        Me.groupFooterSection.Name = "groupFooterSection"
        Me.groupFooterSection.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted
        '
        'TextBox23
        '
        Me.TextBox23.CanGrow = False
        Me.TextBox23.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Cm(0.10000035166740417R))
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5000002384185791R), Telerik.Reporting.Drawing.Unit.Cm(0.39999881386756897R))
        Me.TextBox23.Style.Font.Name = "Calibri"
        Me.TextBox23.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox23.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox23.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox23.Value = "Qty : {Fields.qty_belanja} pcs"
        '
        'TextBox24
        '
        Me.TextBox24.CanGrow = False
        Me.TextBox24.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8002002239227295R), Telerik.Reporting.Drawing.Unit.Cm(0.10000035166740417R))
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5624932050704956R), Telerik.Reporting.Drawing.Unit.Cm(0.39999881386756897R))
        Me.TextBox24.Style.Font.Name = "Calibri"
        Me.TextBox24.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox24.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.Value = "Price"
        '
        'TextBox26
        '
        Me.TextBox26.CanGrow = False
        Me.TextBox26.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8002002239227295R), Telerik.Reporting.Drawing.Unit.Cm(0.90019804239273071R))
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5624932050704956R), Telerik.Reporting.Drawing.Unit.Cm(0.399800181388855R))
        Me.TextBox26.Style.Font.Name = "Calibri"
        Me.TextBox26.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox26.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox26.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox26.Value = "RR"
        '
        'TextBox27
        '
        Me.TextBox27.CanGrow = False
        Me.TextBox27.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8002002239227295R), Telerik.Reporting.Drawing.Unit.Cm(0.50019878149032593R))
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5624932050704956R), Telerik.Reporting.Drawing.Unit.Cm(0.39979937672615051R))
        Me.TextBox27.Style.Font.Name = "Calibri"
        Me.TextBox27.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox27.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox27.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox27.Value = "HL"
        '
        'TextBox29
        '
        Me.TextBox29.CanGrow = False
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8002002239227295R), Telerik.Reporting.Drawing.Unit.Cm(1.5003993511199951R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5624932050704956R), Telerik.Reporting.Drawing.Unit.Cm(0.39959913492202759R))
        Me.TextBox29.Style.Font.Name = "Calibri"
        Me.TextBox29.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox29.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox29.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox29.Value = "Total"
        '
        'TextBox30
        '
        Me.TextBox30.CanGrow = False
        Me.TextBox30.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8032922744750977R), Telerik.Reporting.Drawing.Unit.Cm(1.9001983404159546R))
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5624932050704956R), Telerik.Reporting.Drawing.Unit.Cm(0.39979937672615051R))
        Me.TextBox30.Style.Font.Name = "Calibri"
        Me.TextBox30.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox30.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox30.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox30.Value = "Cash"
        '
        'TextBox32
        '
        Me.TextBox32.CanGrow = False
        Me.TextBox32.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8002002239227295R), Telerik.Reporting.Drawing.Unit.Cm(2.5003986358642578R))
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.5624932050704956R), Telerik.Reporting.Drawing.Unit.Cm(0.39959993958473206R))
        Me.TextBox32.Style.Font.Name = "Calibri"
        Me.TextBox32.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox32.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox32.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox32.Value = "Balance"
        '
        'TextBox33
        '
        Me.TextBox33.CanGrow = False
        Me.TextBox33.Format = "{0:N2}"
        Me.TextBox33.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3628935813903809R), Telerik.Reporting.Drawing.Unit.Cm(0.10000000149011612R))
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.969998836517334R), Telerik.Reporting.Drawing.Unit.Cm(0.39999881386756897R))
        Me.TextBox33.Style.Font.Name = "Calibri"
        Me.TextBox33.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox33.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox33.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox33.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox33.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox33.Value = "= IIf(Parameters.div.Value=1,Fields.belanja *0.001,Fields.belanja )"
        '
        'TextBox35
        '
        Me.TextBox35.CanGrow = False
        Me.TextBox35.Format = "{0:N2}"
        Me.TextBox35.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3659858703613281R), Telerik.Reporting.Drawing.Unit.Cm(0.50019878149032593R))
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9669063091278076R), Telerik.Reporting.Drawing.Unit.Cm(0.39979934692382813R))
        Me.TextBox35.Style.Font.Name = "Calibri"
        Me.TextBox35.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox35.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox35.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox35.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox35.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox35.Value = "= IIf(Parameters.div.Value=1,Fields.hutang_lama*0.001,Fields.hutang_lama)"
        '
        'TextBox36
        '
        Me.TextBox36.CanGrow = False
        Me.TextBox36.Format = "{0:N2}"
        Me.TextBox36.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3659858703613281R), Telerik.Reporting.Drawing.Unit.Cm(0.90019804239273071R))
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9669063091278076R), Telerik.Reporting.Drawing.Unit.Cm(0.399800181388855R))
        Me.TextBox36.Style.Font.Name = "Calibri"
        Me.TextBox36.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox36.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox36.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox36.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox36.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox36.Value = "= IIf(Parameters.div.Value=1,Fields.retur*0.001,Fields.retur)"
        '
        'TextBox37
        '
        Me.TextBox37.CanGrow = False
        Me.TextBox37.Format = "{0:N2}"
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3659858703613281R), Telerik.Reporting.Drawing.Unit.Cm(1.5003993511199951R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9669063091278076R), Telerik.Reporting.Drawing.Unit.Cm(0.39959913492202759R))
        Me.TextBox37.Style.Font.Name = "Calibri"
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox37.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox37.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox37.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox37.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox37.Value = "= IIf(Parameters.div.Value=1,((Fields.belanja  - Fields.retur) + Fields.hutang_la" & _
    "ma)*0.001,((Fields.belanja  - Fields.retur) + Fields.hutang_lama))"
        '
        'TextBox40
        '
        Me.TextBox40.CanGrow = False
        Me.TextBox40.Format = "{0:N2}"
        Me.TextBox40.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3659858703613281R), Telerik.Reporting.Drawing.Unit.Cm(1.9086679220199585R))
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9638137817382812R), Telerik.Reporting.Drawing.Unit.Cm(0.39133009314537048R))
        Me.TextBox40.Style.Font.Name = "Calibri"
        Me.TextBox40.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox40.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox40.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox40.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox40.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox40.Value = "= IIf(Parameters.div.Value=1,Fields.pembayaran*0.001,Fields.pembayaran)"
        '
        'TextBox41
        '
        Me.TextBox41.CanGrow = False
        Me.TextBox41.Format = "{0:N2}"
        Me.TextBox41.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3690786361694336R), Telerik.Reporting.Drawing.Unit.Cm(2.5003986358642578R))
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9638137817382812R), Telerik.Reporting.Drawing.Unit.Cm(0.39960020780563354R))
        Me.TextBox41.Style.Font.Name = "Calibri"
        Me.TextBox41.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox41.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox41.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox41.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox41.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox41.Value = "= IIf(Parameters.div.Value=1,Fields.hutang_baru*0.001,Fields.hutang_baru)"
        '
        'TextBox38
        '
        Me.TextBox38.CanGrow = False
        Me.TextBox38.Format = "{0:N0}"
        Me.TextBox38.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.2999997138977051R), Telerik.Reporting.Drawing.Unit.Cm(1.3001989126205444R))
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2318193912506104R), Telerik.Reporting.Drawing.Unit.Cm(0.19999980926513672R))
        Me.TextBox38.Style.Font.Name = "Calibri"
        Me.TextBox38.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox38.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox38.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox38.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox38.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox38.Value = "...................................."
        '
        'TextBox28
        '
        Me.TextBox28.CanGrow = False
        Me.TextBox28.Format = "{0:N0}"
        Me.TextBox28.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.2999997138977051R), Telerik.Reporting.Drawing.Unit.Cm(2.3001987934112549R))
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.2347116470336914R), Telerik.Reporting.Drawing.Unit.Cm(0.19999980926513672R))
        Me.TextBox28.Style.Font.Name = "Calibri"
        Me.TextBox28.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox28.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox28.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox28.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox28.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox28.Value = "...................................."
        '
        'TextBox31
        '
        Me.TextBox31.CanGrow = False
        Me.TextBox31.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(4.8000001907348633R))
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R))
        Me.TextBox31.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox31.Style.Font.Name = "Calibri"
        Me.TextBox31.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox31.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox31.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox31.Value = ""
        '
        'TextBox39
        '
        Me.TextBox39.CanGrow = True
        Me.TextBox39.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.26528850197792053R), Telerik.Reporting.Drawing.Unit.Cm(5.0001988410949707R))
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.2347111701965332R), Telerik.Reporting.Drawing.Unit.Cm(0.49999997019767761R))
        Me.TextBox39.Style.Font.Name = "Calibri"
        Me.TextBox39.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox39.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox39.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox39.Value = "= Parameters.footer.Value"
        '
        'TextBox42
        '
        Me.TextBox42.CanGrow = False
        Me.TextBox42.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.26528850197792053R), Telerik.Reporting.Drawing.Unit.Cm(5.5001974105834961R))
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.234710693359375R), Telerik.Reporting.Drawing.Unit.Cm(0.49999997019767761R))
        Me.TextBox42.Style.Font.Name = "Calibri"
        Me.TextBox42.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox42.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox42.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox42.Value = "-------"
        '
        'TextBox46
        '
        Me.TextBox46.CanGrow = False
        Me.TextBox46.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(2.9999983310699463R))
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.6999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox46.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Dotted
        Me.TextBox46.Style.Font.Name = "Calibri"
        Me.TextBox46.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox46.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox46.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox46.Value = ""
        '
        'TextBox47
        '
        Me.TextBox47.CanGrow = False
        Me.TextBox47.Format = "{0:N2}"
        Me.TextBox47.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.0627927780151367R), Telerik.Reporting.Drawing.Unit.Cm(3.4999988079071045R))
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.969998836517334R), Telerik.Reporting.Drawing.Unit.Cm(0.39999881386756897R))
        Me.TextBox47.Style.Font.Name = "Calibri"
        Me.TextBox47.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox47.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox47.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox47.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox47.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox47.Value = "= IIf(Parameters.div.Value=1,(Fields.belanja + Fields.diskon)*0.001,(Fields.belanj" & _
    "a + Fields.diskon))"
        '
        'TextBox48
        '
        Me.TextBox48.CanGrow = False
        Me.TextBox48.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.50020015239715576R), Telerik.Reporting.Drawing.Unit.Cm(3.5001981258392334R))
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9624930620193481R), Telerik.Reporting.Drawing.Unit.Cm(0.39999881386756897R))
        Me.TextBox48.Style.Font.Name = "Calibri"
        Me.TextBox48.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox48.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox48.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox48.Value = "Normal Price"
        '
        'TextBox34
        '
        Me.TextBox34.CanGrow = False
        Me.TextBox34.Format = "{0:N2}"
        Me.TextBox34.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.0627927780151367R), Telerik.Reporting.Drawing.Unit.Cm(3.9064857959747314R))
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9669063091278076R), Telerik.Reporting.Drawing.Unit.Cm(0.40476030111312866R))
        Me.TextBox34.Style.Font.Name = "Calibri"
        Me.TextBox34.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox34.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox34.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox34.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox34.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox34.Value = "= IIf(Parameters.div.Value=1,Fields.diskon*0.001,Fields.diskon)"
        '
        'TextBox25
        '
        Me.TextBox25.CanGrow = False
        Me.TextBox25.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.50020015239715576R), Telerik.Reporting.Drawing.Unit.Cm(3.9003975391387939R))
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.9624930620193481R), Telerik.Reporting.Drawing.Unit.Cm(0.39979937672615051R))
        Me.TextBox25.Style.Font.Bold = True
        Me.TextBox25.Style.Font.Name = "Calibri"
        Me.TextBox25.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox25.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox25.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox25.Value = "Discount"
        '
        'TextBox49
        '
        Me.TextBox49.CanGrow = False
        Me.TextBox49.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4628934860229492R), Telerik.Reporting.Drawing.Unit.Cm(3.5001981258392334R))
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.59969937801361084R), Telerik.Reporting.Drawing.Unit.Cm(0.39999881386756897R))
        Me.TextBox49.Style.Font.Name = "Calibri"
        Me.TextBox49.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox49.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox49.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox49.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox49.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox49.Value = ": Rp"
        '
        'TextBox50
        '
        Me.TextBox50.CanGrow = False
        Me.TextBox50.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.4628934860229492R), Telerik.Reporting.Drawing.Unit.Cm(3.9003975391387939R))
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.59969937801361084R), Telerik.Reporting.Drawing.Unit.Cm(0.39999881386756897R))
        Me.TextBox50.Style.Font.Name = "Calibri"
        Me.TextBox50.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox50.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox50.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox50.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox50.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox50.Value = ": Rp"
        '
        'groupHeaderSection
        '
        Me.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.7999999523162842R)
        Me.groupHeaderSection.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox44, Me.TextBox12})
        Me.groupHeaderSection.Name = "groupHeaderSection"
        Me.groupHeaderSection.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.26528862118721008R), Telerik.Reporting.Drawing.Unit.Cm(1.1999002695083618R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.3345122337341309R), Telerik.Reporting.Drawing.Unit.Cm(0.49999997019767761R))
        Me.TextBox4.Style.Font.Name = "Calibri"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox4.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox4.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox4.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox4.Value = "CUSTOMER : {Fields.nama} di {Fields.asal}"
        '
        'TextBox44
        '
        Me.TextBox44.Format = "{0:dddd, dd MMM yyyy (HH:mm)}"
        Me.TextBox44.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.29979974031448364R), Telerik.Reporting.Drawing.Unit.Cm(0.59990090131759644R))
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.30000114440918R), Telerik.Reporting.Drawing.Unit.Cm(0.49999997019767761R))
        Me.TextBox44.Style.Font.Name = "Calibri"
        Me.TextBox44.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox44.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox44.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox44.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox44.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox44.Value = "= Fields.tgl_update"
        '
        'TextBox12
        '
        Me.TextBox12.CanGrow = True
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.26528850197792053R), Telerik.Reporting.Drawing.Unit.Cm(0.099700525403022766R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.3345127105712891R), Telerik.Reporting.Drawing.Unit.Cm(0.49999997019767761R))
        Me.TextBox12.Style.Font.Name = "Calibri"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox12.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox12.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox12.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox12.Value = "{Parameters.invoice.Value} ({Substr(Fields.tipe_penjualan,0,1)}) / {Fields.nama_s" & _
    "ales}"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(2.3000996112823486R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.PictureBox1})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        Me.pageHeaderSection1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Dotted
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.4000996351242065R), Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0999002456665039R), Telerik.Reporting.Drawing.Unit.Cm(0.5999000072479248R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Calibri"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.TextBox1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Fields.nama_toko"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.4000996351242065R), Telerik.Reporting.Drawing.Unit.Cm(0.60019975900650024R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0999002456665039R), Telerik.Reporting.Drawing.Unit.Cm(0.49980032444000244R))
        Me.TextBox2.Style.Font.Name = "Calibri"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.0R)
        Me.TextBox2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "{Fields.alamat_lengkap}, {Fields.alamat}"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000004172325134R), Telerik.Reporting.Drawing.Unit.Cm(1.1001999378204346R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(1.2000000476837158R))
        Me.TextBox3.Style.Font.Name = "Calibri"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox3.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox3.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "= Parameters.header.Value"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.29979979991912842R), Telerik.Reporting.Drawing.Unit.Cm(0.0001000221527647227R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.1000999212265015R), Telerik.Reporting.Drawing.Unit.Cm(1.0999000072479248R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.PictureBox1.Value = "= Fields.logo_perusahaan"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1000007390975952R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.List1})
        Me.detail.KeepTogether = False
        Me.detail.Name = "detail"
        '
        'List1
        '
        Me.List1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(6.2999005317687988R)))
        Me.List1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.89990031719207764R)))
        Me.List1.Body.SetCellContent(0, 0, Me.Panel1)
        TableGroup1.Name = "ColumnGroup"
        Me.List1.ColumnGroups.Add(TableGroup1)
        Me.List1.DataSource = Me.SqlDataSource1
        Me.List1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel1})
        Me.List1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.List1.Name = "List1"
        TableGroup2.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup2.Name = "DetailGroup"
        Me.List1.RowGroups.Add(TableGroup2)
        Me.List1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.2999005317687988R), Telerik.Reporting.Drawing.Unit.Cm(0.89990031719207764R))
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22})
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(6.2999005317687988R), Telerik.Reporting.Drawing.Unit.Cm(0.89990031719207764R))
        '
        'TextBox13
        '
        Me.TextBox13.CanGrow = False
        Me.TextBox13.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R), Telerik.Reporting.Drawing.Unit.Cm(0.11917122453451157R))
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1998999118804932R), Telerik.Reporting.Drawing.Unit.Cm(0.40000015497207642R))
        Me.TextBox13.Style.Font.Name = "Calibri"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox13.Value = "= Fields.kode_barang"
        '
        'TextBox14
        '
        Me.TextBox14.CanGrow = False
        Me.TextBox14.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.2001998424530029R), Telerik.Reporting.Drawing.Unit.Cm(0.11897098273038864R))
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0996999740600586R), Telerik.Reporting.Drawing.Unit.Cm(0.40000015497207642R))
        Me.TextBox14.Style.Font.Name = "Calibri"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom
        Me.TextBox14.Value = "= Fields.nama_barang"
        '
        'TextBox15
        '
        Me.TextBox15.CanGrow = False
        Me.TextBox15.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.51917147636413574R))
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.20000000298023224R), Telerik.Reporting.Drawing.Unit.Cm(0.2997995913028717R))
        Me.TextBox15.Style.Font.Name = "Calibri"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.Value = ""
        '
        'TextBox16
        '
        Me.TextBox16.CanGrow = False
        Me.TextBox16.CanShrink = False
        Me.TextBox16.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.20020014047622681R), Telerik.Reporting.Drawing.Unit.Cm(0.51917147636413574R))
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.59969973564147949R), Telerik.Reporting.Drawing.Unit.Cm(0.29979956150054932R))
        Me.TextBox16.Style.Font.Name = "Calibri"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox16.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox16.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.Value = "= Fields.stok_keluar"
        '
        'TextBox17
        '
        Me.TextBox17.CanGrow = False
        Me.TextBox17.Format = "{0:N2}"
        Me.TextBox17.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.3327922821044922R), Telerik.Reporting.Drawing.Unit.Cm(0.51917147636413574R))
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R))
        Me.TextBox17.Style.Font.Name = "Calibri"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox17.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox17.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.Value = "= IIf(Parameters.div.Value=1,(Fields.stok_keluar * Fields.harga_jual)*0.001,(Field" & _
    "s.stok_keluar * Fields.harga_jual))"
        '
        'TextBox18
        '
        Me.TextBox18.CanGrow = False
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.80009973049163818R), Telerik.Reporting.Drawing.Unit.Cm(0.51917147636413574R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.29980009794235229R), Telerik.Reporting.Drawing.Unit.Cm(0.2997995913028717R))
        Me.TextBox18.Style.Font.Name = "Calibri"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox18.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox18.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox18.Value = "@"
        '
        'TextBox19
        '
        Me.TextBox19.CanGrow = False
        Me.TextBox19.Format = "{0:N2}"
        Me.TextBox19.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.1000995635986328R), Telerik.Reporting.Drawing.Unit.Cm(0.51917147636413574R))
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.3998003005981445R), Telerik.Reporting.Drawing.Unit.Cm(0.2997995913028717R))
        Me.TextBox19.Style.Font.Name = "Calibri"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox19.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox19.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox19.Value = "= IIf(Parameters.div.Value=1,Fields.harga_jual*0.001,Fields.harga_jual)"
        '
        'TextBox20
        '
        Me.TextBox20.CanGrow = False
        Me.TextBox20.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5001001358032227R), Telerik.Reporting.Drawing.Unit.Cm(0.51917147636413574R))
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.69979989528656006R), Telerik.Reporting.Drawing.Unit.Cm(0.2997995913028717R))
        Me.TextBox20.Style.Color = System.Drawing.Color.Transparent
        Me.TextBox20.Style.Font.Name = "Calibri"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox20.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox20.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.Style.Visible = True
        Me.TextBox20.Value = "{IIf(Fields.diskon = 0, """", ""(disc :"")}"
        '
        'TextBox21
        '
        Me.TextBox21.CanGrow = False
        FormattingRule1.Filters.Add(New Telerik.Reporting.Filter("=Fields.diskon", Telerik.Reporting.FilterOperator.Equal, "0"))
        FormattingRule1.Style.Color = System.Drawing.Color.White
        FormattingRule1.Style.Visible = True
        Me.TextBox21.ConditionalFormatting.AddRange(New Telerik.Reporting.Drawing.FormattingRule() {FormattingRule1})
        Me.TextBox21.Format = "{0:N0}"
        Me.TextBox21.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.2001001834869385R), Telerik.Reporting.Drawing.Unit.Cm(0.51917147636413574R))
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0R), Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896R))
        Me.TextBox21.Style.Color = System.Drawing.Color.Transparent
        Me.TextBox21.Style.Font.Name = "Calibri"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox21.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox21.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.Style.Visible = True
        Me.TextBox21.Value = "= Fields.diskon"
        '
        'TextBox22
        '
        Me.TextBox22.CanGrow = False
        Me.TextBox22.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.2003002166748047R), Telerik.Reporting.Drawing.Unit.Cm(0.51917147636413574R))
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R), Telerik.Reporting.Drawing.Unit.Cm(0.2997995913028717R))
        Me.TextBox22.Style.Color = System.Drawing.Color.Transparent
        Me.TextBox22.Style.Font.Name = "Calibri"
        Me.TextBox22.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8.0R)
        Me.TextBox22.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox22.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(0.0R)
        Me.TextBox22.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox22.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox22.Value = "{IIf(Fields.diskon = 0, """", "")"")}"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Program_Penjualan_V2.My.MySettings.TokoConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@invoice", System.Data.DbType.[String], "=Parameters.invoice.Value")})
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionString = "Program_Penjualan_V2.My.MySettings.TokoConnectionString"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@invoice", System.Data.DbType.[String], "=Parameters.invoice.Value")})
        Me.SqlDataSource2.SelectCommand = resources.GetString("SqlDataSource2.SelectCommand")
        '
        'ReportNotaPenjualanSmall
        '
        Me.DataSource = Me.SqlDataSource2
        Group1.GroupFooter = Me.groupFooterSection
        Group1.GroupHeader = Me.groupHeaderSection
        Group1.Name = "group"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection, Me.groupFooterSection, Me.pageHeaderSection1, Me.detail})
        Me.Name = "ReportNotaMasukSmall"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(3.0R), Telerik.Reporting.Drawing.Unit.Mm(4.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R), Telerik.Reporting.Drawing.Unit.Mm(3.0R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Mm(74.0R), Telerik.Reporting.Drawing.Unit.Mm(297.0R))
        ReportParameter1.AllowNull = True
        ReportParameter1.Name = "invoice"
        ReportParameter2.AllowNull = True
        ReportParameter2.Name = "header"
        ReportParameter3.AllowNull = True
        ReportParameter3.Name = "footer"
        ReportParameter4.Name = "div"
        ReportParameter4.Type = Telerik.Reporting.ReportParameterType.[Integer]
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.ReportParameters.Add(ReportParameter4)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(6.6999001502990723R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents groupHeaderSection As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents groupFooterSection As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents List1 As Telerik.Reporting.List
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox26 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox27 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox30 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox32 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox33 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox35 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox36 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox40 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox41 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox38 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox28 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox31 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox39 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox42 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox44 As Telerik.Reporting.TextBox
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents TextBox46 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox47 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox48 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox34 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox25 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox49 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox50 As Telerik.Reporting.TextBox
End Class