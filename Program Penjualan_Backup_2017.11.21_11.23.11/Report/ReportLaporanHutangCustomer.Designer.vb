Partial Class ReportLaporanHutangCustomer
    
    'NOTE: The following procedure is required by the telerik Reporting Designer
    'It can be modified using the telerik Reporting Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim TableGroup1 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup2 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup3 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup4 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup5 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup6 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup7 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup8 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup9 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup10 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup11 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup12 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup13 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup14 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim TableGroup15 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportLaporanHutangCustomer))
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Table2 = New Telerik.Reporting.Table()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox24 = New Telerik.Reporting.TextBox()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.TextBox37 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource2 = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection1
        '
        Me.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.groupFooterSection1.Name = "groupFooterSection1"
        '
        'groupHeaderSection1
        '
        Me.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045R)
        Me.groupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.groupHeaderSection1.Name = "groupHeaderSection1"
        Me.groupHeaderSection1.PrintOnEveryPage = True
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(0.9999997615814209R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.4999997615814209R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.5R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.0999999046325684R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.1999995708465576R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.1999995708465576R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(1.0R)))
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox10)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox11)
        Me.Table1.Body.SetCellContent(0, 5, Me.TextBox12)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox7)
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox8)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox19)
        TableGroup2.Name = "Group2"
        TableGroup3.Name = "Group1"
        TableGroup4.Name = "group"
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.ColumnGroups.Add(TableGroup6)
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox7, Me.TextBox8, Me.TextBox19})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.Table1.Name = "Table1"
        TableGroup7.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup7.Name = "DetailGroup"
        Me.Table1.RowGroups.Add(TableGroup7)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        '
        'TextBox10
        '
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox10.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox10.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox10.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox10.Style.Font.Bold = True
        Me.TextBox10.Style.Font.Name = "Calibri"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox10.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox10.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox10.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox10.Value = "No"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox11.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox11.Style.Font.Bold = True
        Me.TextBox11.Style.Font.Name = "Calibri"
        Me.TextBox11.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox11.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox11.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox11.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox11.Value = "Jumlah Hutang (Rp)"
        '
        'TextBox12
        '
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.2000000476837158R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox12.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox12.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox12.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox12.Style.Font.Bold = True
        Me.TextBox12.Style.Font.Name = "Calibri"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox12.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox12.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox12.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox12.Value = "Transaksi Terakhir"
        '
        'TextBox7
        '
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox7.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox7.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox7.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox7.Style.Font.Bold = True
        Me.TextBox7.Style.Font.Name = "Calibri"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox7.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox7.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox7.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox7.StyleName = ""
        Me.TextBox7.Value = "Nama Customer"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox8.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox8.Style.Font.Bold = True
        Me.TextBox8.Style.Font.Name = "Calibri"
        Me.TextBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox8.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox8.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox8.StyleName = ""
        Me.TextBox8.Value = "ID Customer"
        '
        'TextBox19
        '
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.0999999046325684R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox19.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox19.Style.Font.Bold = True
        Me.TextBox19.Style.Font.Name = "Calibri"
        Me.TextBox19.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox19.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox19.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox19.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox19.StyleName = ""
        Me.TextBox19.Value = "Kota"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.0R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel3, Me.Panel1, Me.TextBox3, Me.TextBox2, Me.TextBox1, Me.Panel2})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'Panel3
        '
        Me.Panel3.Docking = Telerik.Reporting.DockingStyle.Bottom
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.499899864196777R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.20000016689300537R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.5R), Telerik.Reporting.Drawing.Unit.Cm(0.079999998211860657R))
        Me.TextBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox6.Value = ""
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(0.0001000221527647227R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.7998998761177063R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(2.5R))
        Me.PictureBox1.Value = "= Fields.logo_perusahaan"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.00029993057251R), Telerik.Reporting.Drawing.Unit.Cm(1.8003008365631104R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4994001388549805R), Telerik.Reporting.Drawing.Unit.Cm(0.69979941844940186R))
        Me.TextBox3.Style.Font.Name = "Calibri"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "= Parameters.per_tanggal.Value"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.00029993057251R), Telerik.Reporting.Drawing.Unit.Cm(1.0003999471664429R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4994001388549805R), Telerik.Reporting.Drawing.Unit.Cm(0.79980027675628662R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Calibri"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "LAPORAN HUTANG CUSTOMER"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.00029993057251R), Telerik.Reporting.Drawing.Unit.Cm(0.00020004430552944541R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.4994001388549805R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Calibri"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Parameters.nama_perusahaan.Value"
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox4, Me.TextBox5})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(11.499699592590332R), Telerik.Reporting.Drawing.Unit.Cm(0.00020024616969749331R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.0000996589660645R), Telerik.Reporting.Drawing.Unit.Cm(2.4995994567871094R))
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.7000994682312012R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox4.Style.Font.Name = "Calibri"
        Me.TextBox4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox4.Value = "Printed on :"
        '
        'TextBox5
        '
        Me.TextBox5.Format = "{0:dd-MM-yy (HH:mm)}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.700299859046936R), Telerik.Reporting.Drawing.Unit.Cm(0.000099921220680698752R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.299799919128418R), Telerik.Reporting.Drawing.Unit.Cm(0.49999994039535522R))
        Me.TextBox5.Style.Font.Name = "Calibri"
        Me.TextBox5.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox5.Value = "= Now()"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(2.6000006198883057R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table2, Me.TextBox18})
        Me.detail.Name = "detail"
        '
        'Table2
        '
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(0.99999982118606567R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.4999995231628418R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.4999997615814209R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.0999999046325684R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.1999995708465576R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.1999998092651367R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R)))
        Me.Table2.Body.SetCellContent(0, 0, Me.TextBox9)
        Me.Table2.Body.SetCellContent(0, 4, Me.TextBox13)
        Me.Table2.Body.SetCellContent(0, 5, Me.TextBox14)
        Me.Table2.Body.SetCellContent(0, 2, Me.TextBox15)
        Me.Table2.Body.SetCellContent(0, 1, Me.TextBox16)
        Me.Table2.Body.SetCellContent(1, 4, Me.TextBox20)
        Me.Table2.Body.SetCellContent(1, 5, Me.TextBox21)
        Me.Table2.Body.SetCellContent(0, 3, Me.TextBox24)
        Me.Table2.Body.SetCellContent(1, 0, Me.TextBox17, 1, 4)
        TableGroup9.Name = "Group2"
        TableGroup10.Name = "Group1"
        TableGroup11.Name = "group2"
        Me.Table2.ColumnGroups.Add(TableGroup8)
        Me.Table2.ColumnGroups.Add(TableGroup9)
        Me.Table2.ColumnGroups.Add(TableGroup10)
        Me.Table2.ColumnGroups.Add(TableGroup11)
        Me.Table2.ColumnGroups.Add(TableGroup12)
        Me.Table2.ColumnGroups.Add(TableGroup13)
        Me.Table2.DataSource = Me.SqlDataSource1
        Me.Table2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox9, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox20, Me.TextBox21, Me.TextBox24, Me.TextBox17})
        Me.Table2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.00020024616969749331R))
        Me.Table2.Name = "Table2"
        TableGroup14.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup14.Name = "DetailGroup"
        TableGroup15.Name = "Group3"
        Me.Table2.RowGroups.Add(TableGroup14)
        Me.Table2.RowGroups.Add(TableGroup15)
        Me.Table2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.499999046325684R), Telerik.Reporting.Drawing.Unit.Cm(1.2000000476837158R))
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0000001192092896R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox9.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox9.Style.Font.Bold = False
        Me.TextBox9.Style.Font.Name = "Calibri"
        Me.TextBox9.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox9.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox9.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox9.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox9.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox9.Value = "= RowNumber()"
        '
        'TextBox13
        '
        Me.TextBox13.Format = "{0:N2}"
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox13.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox13.Style.Font.Bold = False
        Me.TextBox13.Style.Font.Name = "Calibri"
        Me.TextBox13.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox13.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox13.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox13.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox13.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox13.Value = "= IIf(Parameters.div.Value=1, Fields.hutang_lama*0.001,Fields.hutang_lama)"
        '
        'TextBox14
        '
        Me.TextBox14.Format = "{0:D}"
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox14.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox14.Style.Font.Bold = False
        Me.TextBox14.Style.Font.Name = "Calibri"
        Me.TextBox14.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox14.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox14.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox14.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox14.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox14.Value = "= Fields.transaksi_terakhir"
        '
        'TextBox15
        '
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4999997615814209R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox15.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox15.Style.Font.Bold = False
        Me.TextBox15.Style.Font.Name = "Calibri"
        Me.TextBox15.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox15.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox15.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox15.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox15.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox15.StyleName = ""
        Me.TextBox15.Value = "= Fields.nama"
        '
        'TextBox16
        '
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox16.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox16.Style.Font.Bold = False
        Me.TextBox16.Style.Font.Name = "Calibri"
        Me.TextBox16.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox16.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox16.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox16.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox16.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox16.StyleName = ""
        Me.TextBox16.Value = "= Fields.id_customer"
        '
        'TextBox20
        '
        Me.TextBox20.Format = "{0:N2}"
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox20.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox20.Style.Font.Bold = True
        Me.TextBox20.Style.Font.Name = "Calibri"
        Me.TextBox20.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox20.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox20.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox20.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox20.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox20.StyleName = ""
        Me.TextBox20.Value = "=IIf(Parameters.div.Value=1,SUM(Fields.hutang_lama)*0.001,SUM(Fields.hutang_lama)" & _
    ")"
        '
        'TextBox21
        '
        Me.TextBox21.Format = "{0}"
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.1999998092651367R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox21.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox21.Style.Font.Bold = True
        Me.TextBox21.Style.Font.Name = "Calibri"
        Me.TextBox21.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox21.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox21.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox21.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox21.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox21.StyleName = ""
        '
        'TextBox24
        '
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.1000001430511475R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox24.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox24.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox24.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox24.Style.Font.Name = "Calibri"
        Me.TextBox24.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox24.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox24.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox24.StyleName = ""
        Me.TextBox24.Value = "= Fields.asal"
        '
        'TextBox17
        '
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(9.09999942779541R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox17.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox17.Style.Font.Bold = True
        Me.TextBox17.Style.Font.Name = "Calibri"
        Me.TextBox17.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(12.0R)
        Me.TextBox17.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox17.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox17.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right
        Me.TextBox17.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox17.StyleName = ""
        Me.TextBox17.Value = "TOTAL"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Program_Penjualan_V2.My.MySettings.TokoConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.SelectCommand = resources.GetString("SqlDataSource1.SelectCommand")
        '
        'TextBox18
        '
        Me.TextBox18.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R), Telerik.Reporting.Drawing.Unit.Cm(2.0000007152557373R))
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.499698638916016R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox18.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None
        Me.TextBox18.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox18.Style.Font.Bold = False
        Me.TextBox18.Style.Font.Name = "Calibri"
        Me.TextBox18.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.TextBox18.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.TextBox18.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox18.StyleName = ""
        Me.TextBox18.Value = "*catatan : jika jumlah hutang minus, maka ""Perusahaan"" yang berhutang pada custom" & _
    "er"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.pageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox37})
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'TextBox37
        '
        Me.TextBox37.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.TextBox37.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.499899864196777R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox37.Style.Font.Name = "Calibri"
        Me.TextBox37.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9.0R)
        Me.TextBox37.Value = "Page {PageNumber} of {PageCount}"
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionString = "Program_Penjualan_V2.My.MySettings.TokoConnectionString"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        Me.SqlDataSource2.SelectCommand = "SELECT  logo_perusahaan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     tabel_perusahaan"
        '
        'ReportLaporanHutangCustomer
        '
        Me.DataSource = Me.SqlDataSource2
        Group1.GroupFooter = Me.groupFooterSection1
        Group1.GroupHeader = Me.groupHeaderSection1
        Group1.Name = "group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection1, Me.groupFooterSection1, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1})
        Me.Name = "ReportLaporanHutangCustomer"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.PageSettings.PaperSize = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(16.5R), Telerik.Reporting.Drawing.Unit.Cm(21.5R))
        ReportParameter1.AllowNull = True
        ReportParameter1.Name = "nama_perusahaan"
        ReportParameter2.AllowNull = True
        ReportParameter2.Name = "per_tanggal"
        ReportParameter3.Name = "div"
        ReportParameter3.Type = Telerik.Reporting.ReportParameterType.[Integer]
        Me.ReportParameters.Add(ReportParameter1)
        Me.ReportParameters.Add(ReportParameter2)
        Me.ReportParameters.Add(ReportParameter3)
        Me.Style.BackgroundColor = System.Drawing.Color.White
        StyleRule1.Selectors.AddRange(New Telerik.Reporting.Drawing.ISelector() {New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.TextItemBase)), New Telerik.Reporting.Drawing.TypeSelector(GetType(Telerik.Reporting.HtmlTextBox))})
        StyleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        StyleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2.0R)
        Me.StyleSheet.AddRange(New Telerik.Reporting.Drawing.StyleRule() {StyleRule1})
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(15.499899864196777R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents groupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents Table2 As Telerik.Reporting.Table
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox37 As Telerik.Reporting.TextBox
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents SqlDataSource2 As Telerik.Reporting.SqlDataSource
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox24 As Telerik.Reporting.TextBox
End Class