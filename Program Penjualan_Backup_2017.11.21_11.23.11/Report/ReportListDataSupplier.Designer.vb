Partial Class ReportListDataSupplier
    
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
        Dim TableGroup16 As Telerik.Reporting.TableGroup = New Telerik.Reporting.TableGroup()
        Dim Group1 As Telerik.Reporting.Group = New Telerik.Reporting.Group()
        Dim ReportParameter1 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter2 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter3 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim ReportParameter4 As Telerik.Reporting.ReportParameter = New Telerik.Reporting.ReportParameter()
        Dim StyleRule1 As Telerik.Reporting.Drawing.StyleRule = New Telerik.Reporting.Drawing.StyleRule()
        Me.groupFooterSection1 = New Telerik.Reporting.GroupFooterSection()
        Me.groupHeaderSection1 = New Telerik.Reporting.GroupHeaderSection()
        Me.Table1 = New Telerik.Reporting.Table()
        Me.TextBox13 = New Telerik.Reporting.TextBox()
        Me.TextBox14 = New Telerik.Reporting.TextBox()
        Me.TextBox15 = New Telerik.Reporting.TextBox()
        Me.TextBox8 = New Telerik.Reporting.TextBox()
        Me.TextBox9 = New Telerik.Reporting.TextBox()
        Me.TextBox11 = New Telerik.Reporting.TextBox()
        Me.TextBox16 = New Telerik.Reporting.TextBox()
        Me.pageHeaderSection1 = New Telerik.Reporting.PageHeaderSection()
        Me.Panel3 = New Telerik.Reporting.Panel()
        Me.TextBox6 = New Telerik.Reporting.TextBox()
        Me.TextBox3 = New Telerik.Reporting.TextBox()
        Me.TextBox2 = New Telerik.Reporting.TextBox()
        Me.Panel2 = New Telerik.Reporting.Panel()
        Me.TextBox5 = New Telerik.Reporting.TextBox()
        Me.TextBox4 = New Telerik.Reporting.TextBox()
        Me.TextBox1 = New Telerik.Reporting.TextBox()
        Me.Panel1 = New Telerik.Reporting.Panel()
        Me.PictureBox1 = New Telerik.Reporting.PictureBox()
        Me.detail = New Telerik.Reporting.DetailSection()
        Me.Table2 = New Telerik.Reporting.Table()
        Me.TextBox17 = New Telerik.Reporting.TextBox()
        Me.TextBox18 = New Telerik.Reporting.TextBox()
        Me.TextBox19 = New Telerik.Reporting.TextBox()
        Me.TextBox20 = New Telerik.Reporting.TextBox()
        Me.TextBox21 = New Telerik.Reporting.TextBox()
        Me.TextBox22 = New Telerik.Reporting.TextBox()
        Me.TextBox23 = New Telerik.Reporting.TextBox()
        Me.SqlDataSource1 = New Telerik.Reporting.SqlDataSource()
        Me.pageFooterSection1 = New Telerik.Reporting.PageFooterSection()
        Me.TextBox29 = New Telerik.Reporting.TextBox()
        Me.ReportHeaderSection1 = New Telerik.Reporting.ReportHeaderSection()
        Me.TextBox12 = New Telerik.Reporting.TextBox()
        Me.TextBox10 = New Telerik.Reporting.TextBox()
        Me.TextBox7 = New Telerik.Reporting.TextBox()
        Me.logo = New Telerik.Reporting.SqlDataSource()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'groupFooterSection1
        '
        Me.groupFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.13229165971279144R)
        Me.groupFooterSection1.Name = "groupFooterSection1"
        '
        'groupHeaderSection1
        '
        Me.groupHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.0R)
        Me.groupHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table1})
        Me.groupHeaderSection1.Name = "groupHeaderSection1"
        '
        'Table1
        '
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.0217711925506592R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.5418150424957275R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.4311985969543457R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.5432429313659668R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.3191561698913574R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.3096528053283691R)))
        Me.Table1.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.8330638408660889R)))
        Me.Table1.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(1.0R)))
        Me.Table1.Body.SetCellContent(0, 1, Me.TextBox13)
        Me.Table1.Body.SetCellContent(0, 5, Me.TextBox14)
        Me.Table1.Body.SetCellContent(0, 6, Me.TextBox15)
        Me.Table1.Body.SetCellContent(0, 4, Me.TextBox8)
        Me.Table1.Body.SetCellContent(0, 3, Me.TextBox9)
        Me.Table1.Body.SetCellContent(0, 2, Me.TextBox11)
        Me.Table1.Body.SetCellContent(0, 0, Me.TextBox16)
        TableGroup1.Name = "Group4"
        TableGroup3.Name = "Group3"
        TableGroup4.Name = "Group2"
        TableGroup5.Name = "Group1"
        Me.Table1.ColumnGroups.Add(TableGroup1)
        Me.Table1.ColumnGroups.Add(TableGroup2)
        Me.Table1.ColumnGroups.Add(TableGroup3)
        Me.Table1.ColumnGroups.Add(TableGroup4)
        Me.Table1.ColumnGroups.Add(TableGroup5)
        Me.Table1.ColumnGroups.Add(TableGroup6)
        Me.Table1.ColumnGroups.Add(TableGroup7)
        Me.Table1.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.Table1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox8, Me.TextBox9, Me.TextBox11, Me.TextBox16})
        Me.Table1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.Table1.Name = "Table1"
        TableGroup8.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup8.Name = "DetailGroup"
        Me.Table1.RowGroups.Add(TableGroup8)
        Me.Table1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.999898910522461R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.Table1.Style.Font.Bold = True
        Me.Table1.Style.Font.Name = "Calibri"
        Me.Table1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.Table1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        '
        'TextBox13
        '
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5418145656585693R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox13.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox13.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox13.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox13.Value = "ID Supplier"
        '
        'TextBox14
        '
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3096528053283691R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox14.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox14.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox14.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox14.Value = "HP / Telp"
        '
        'TextBox15
        '
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.833064079284668R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox15.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox15.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox15.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox15.Value = "Terdaftar Tanggal"
        '
        'TextBox8
        '
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3191559314727783R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox8.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox8.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox8.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox8.StyleName = ""
        Me.TextBox8.Value = "Daerah / Kota"
        '
        'TextBox9
        '
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.5432429313659668R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox9.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox9.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox9.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox9.StyleName = ""
        Me.TextBox9.Value = "Alamat"
        '
        'TextBox11
        '
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4311988353729248R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox11.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox11.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox11.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox11.StyleName = ""
        Me.TextBox11.Value = "Nama Supplier"
        '
        'TextBox16
        '
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0217710733413696R), Telerik.Reporting.Drawing.Unit.Cm(1.0R))
        Me.TextBox16.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox16.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox16.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox16.StyleName = ""
        Me.TextBox16.Value = "No"
        '
        'pageHeaderSection1
        '
        Me.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(3.5R)
        Me.pageHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Panel3, Me.TextBox3, Me.TextBox2, Me.Panel2, Me.TextBox1, Me.Panel1})
        Me.pageHeaderSection1.Name = "pageHeaderSection1"
        '
        'Panel3
        '
        Me.Panel3.Docking = Telerik.Reporting.DockingStyle.Bottom
        Me.Panel3.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox6})
        Me.Panel3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(2.9999997615814209R))
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.0R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        '
        'TextBox6
        '
        Me.TextBox6.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.20000016689300537R))
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(20.0R), Telerik.Reporting.Drawing.Unit.Cm(0.079999998211860657R))
        Me.TextBox6.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox6.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(1.0R)
        Me.TextBox6.Value = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.5001997947692871R), Telerik.Reporting.Drawing.Unit.Cm(2.2999002933502197R))
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.499499320983887R), Telerik.Reporting.Drawing.Unit.Cm(0.69979941844940186R))
        Me.TextBox3.Style.Font.Name = "Calibri"
        Me.TextBox3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(14.0R)
        Me.TextBox3.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox3.Value = "= Parameters.per_tanggal.Value"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.5001997947692871R), Telerik.Reporting.Drawing.Unit.Cm(1.2000999450683594R))
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.499499320983887R), Telerik.Reporting.Drawing.Unit.Cm(1.0996003150939941R))
        Me.TextBox2.Style.Font.Bold = True
        Me.TextBox2.Style.Font.Name = "Calibri"
        Me.TextBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(16.0R)
        Me.TextBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox2.Value = "LIST DATA SUPPLIER"
        '
        'Panel2
        '
        Me.Panel2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox5, Me.TextBox4})
        Me.Panel2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(15.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.0R), Telerik.Reporting.Drawing.Unit.Cm(2.9996998310089111R))
        '
        'TextBox5
        '
        Me.TextBox5.Format = "{0:dd-MM-yy (HH:mm)}"
        Me.TextBox5.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.9002004861831665R), Telerik.Reporting.Drawing.Unit.Cm(0.0001000221527647227R))
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0996992588043213R), Telerik.Reporting.Drawing.Unit.Cm(0.49999994039535522R))
        Me.TextBox5.Style.Font.Name = "Calibri"
        Me.TextBox5.Value = "= Now()"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.00010012308484874666R))
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.8999999761581421R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox4.Style.Font.Name = "Calibri"
        Me.TextBox4.Value = "Printed on :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(4.5001997947692871R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(10.499499320983887R), Telerik.Reporting.Drawing.Unit.Cm(1.1999000310897827R))
        Me.TextBox1.Style.Font.Bold = True
        Me.TextBox1.Style.Font.Name = "Calibri"
        Me.TextBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(20.0R)
        Me.TextBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center
        Me.TextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        Me.TextBox1.Value = "= Parameters.nama_perusahaan.Value"
        '
        'Panel1
        '
        Me.Panel1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.PictureBox1})
        Me.Panel1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.5R), Telerik.Reporting.Drawing.Unit.Cm(3.0R))
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.699999988079071R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.PictureBox1.MimeType = ""
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0R), Telerik.Reporting.Drawing.Unit.Cm(3.0R))
        Me.PictureBox1.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch
        Me.PictureBox1.Value = "= Fields.logo_perusahaan"
        '
        'detail
        '
        Me.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R)
        Me.detail.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.Table2})
        Me.detail.Name = "detail"
        '
        'Table2
        '
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(1.0217711925506592R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.5418150424957275R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.4311985969543457R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(4.5432429313659668R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.3191561698913574R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(3.3096528053283691R)))
        Me.Table2.Body.Columns.Add(New Telerik.Reporting.TableBodyColumn(Telerik.Reporting.Drawing.Unit.Cm(2.8330638408660889R)))
        Me.Table2.Body.Rows.Add(New Telerik.Reporting.TableBodyRow(Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R)))
        Me.Table2.Body.SetCellContent(0, 1, Me.TextBox17)
        Me.Table2.Body.SetCellContent(0, 5, Me.TextBox18)
        Me.Table2.Body.SetCellContent(0, 6, Me.TextBox19)
        Me.Table2.Body.SetCellContent(0, 4, Me.TextBox20)
        Me.Table2.Body.SetCellContent(0, 3, Me.TextBox21)
        Me.Table2.Body.SetCellContent(0, 2, Me.TextBox22)
        Me.Table2.Body.SetCellContent(0, 0, Me.TextBox23)
        TableGroup9.Name = "Group4"
        TableGroup11.Name = "Group3"
        TableGroup12.Name = "Group2"
        TableGroup13.Name = "Group1"
        Me.Table2.ColumnGroups.Add(TableGroup9)
        Me.Table2.ColumnGroups.Add(TableGroup10)
        Me.Table2.ColumnGroups.Add(TableGroup11)
        Me.Table2.ColumnGroups.Add(TableGroup12)
        Me.Table2.ColumnGroups.Add(TableGroup13)
        Me.Table2.ColumnGroups.Add(TableGroup14)
        Me.Table2.ColumnGroups.Add(TableGroup15)
        Me.Table2.DataSource = Me.SqlDataSource1
        Me.Table2.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.Table2.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23})
        Me.Table2.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.Table2.Name = "Table2"
        TableGroup16.Groupings.Add(New Telerik.Reporting.Grouping(Nothing))
        TableGroup16.Name = "DetailGroup"
        Me.Table2.RowGroups.Add(TableGroup16)
        Me.Table2.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.999898910522461R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.Table2.Style.Font.Name = "Calibri"
        Me.Table2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10.0R)
        Me.Table2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left
        Me.Table2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle
        '
        'TextBox17
        '
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5418148040771484R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox17.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox17.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox17.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox17.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox17.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox17.Value = "= Fields.id_supplier"
        '
        'TextBox18
        '
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.3096528053283691R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox18.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox18.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox18.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox18.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox18.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox18.Value = "= Fields.telp"
        '
        'TextBox19
        '
        Me.TextBox19.Format = "{0:dd MMM yy}"
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.833064079284668R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox19.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox19.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox19.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox19.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox19.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox19.Value = "= Fields.terdaftar_bln"
        '
        'TextBox20
        '
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3191561698913574R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox20.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox20.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox20.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox20.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox20.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox20.StyleName = ""
        Me.TextBox20.Value = "= Fields.asal"
        '
        'TextBox21
        '
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.5432429313659668R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox21.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox21.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox21.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox21.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox21.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox21.StyleName = ""
        Me.TextBox21.Value = "= Fields.alamat"
        '
        'TextBox22
        '
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.4311985969543457R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox22.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox22.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox22.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox22.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox22.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox22.StyleName = ""
        Me.TextBox22.Value = "= Fields.nama"
        '
        'TextBox23
        '
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.0217711925506592R), Telerik.Reporting.Drawing.Unit.Cm(0.60000002384185791R))
        Me.TextBox23.Style.BorderColor.Default = System.Drawing.Color.Silver
        Me.TextBox23.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.Solid
        Me.TextBox23.Style.BorderWidth.Default = Telerik.Reporting.Drawing.Unit.Point(0.75R)
        Me.TextBox23.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox23.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(4.0R)
        Me.TextBox23.StyleName = ""
        Me.TextBox23.Value = "= RowNumber()"
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionString = "Program_Penjualan_V2.My.MySettings.TokoConnectionString"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        Me.SqlDataSource1.Parameters.AddRange(New Telerik.Reporting.SqlDataSourceParameter() {New Telerik.Reporting.SqlDataSourceParameter("@asal", System.Data.DbType.[String], "=Parameters.kota.Value")})
        Me.SqlDataSource1.SelectCommand = "SELECT        id_supplier, nama, alamat, asal, telp, terdaftar_bln" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         " & _
    "   tabel_supplier" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE        (asal LIKE @asal) AND (terhapus = 'N')"
        '
        'pageFooterSection1
        '
        Me.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(0.5R)
        Me.pageFooterSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox29})
        Me.pageFooterSection1.Name = "pageFooterSection1"
        '
        'TextBox29
        '
        Me.TextBox29.Docking = Telerik.Reporting.DockingStyle.Fill
        Me.TextBox29.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(19.999898910522461R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.TextBox29.Style.Font.Name = "Calibri"
        Me.TextBox29.Value = "Page {PageNumber} of {PageCount}"
        '
        'ReportHeaderSection1
        '
        Me.ReportHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Cm(1.0R)
        Me.ReportHeaderSection1.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.TextBox12, Me.TextBox10, Me.TextBox7})
        Me.ReportHeaderSection1.Name = "ReportHeaderSection1"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.9001002311706543R), Telerik.Reporting.Drawing.Unit.Cm(0.021242646500468254R))
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5998003482818604R), Telerik.Reporting.Drawing.Unit.Cm(0.57875746488571167R))
        Me.TextBox12.Style.Font.Name = "Calibri"
        Me.TextBox12.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox12.Value = "= IIf(Parameters.kota.Value=""%"",""Semua"", Parameters.kota.Value)"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.5002002716064453R), Telerik.Reporting.Drawing.Unit.Cm(0.0R))
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(0.39969983696937561R), Telerik.Reporting.Drawing.Unit.Cm(0.59979945421218872R))
        Me.TextBox10.Style.Font.Name = "Calibri"
        Me.TextBox10.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox10.Value = ":"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.0R), Telerik.Reporting.Drawing.Unit.Cm(0.00020064989803358912R))
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5R), Telerik.Reporting.Drawing.Unit.Cm(0.59979945421218872R))
        Me.TextBox7.Style.Font.Name = "Calibri"
        Me.TextBox7.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11.0R)
        Me.TextBox7.Value = "Daerah / Kota"
        '
        'logo
        '
        Me.logo.ConnectionString = "Program_Penjualan_V2.My.MySettings.TokoConnectionString"
        Me.logo.Name = "logo"
        Me.logo.SelectCommand = "SELECT  logo_perusahaan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM     tabel_perusahaan"
        '
        'ReportListDataSupplier
        '
        Me.DataSource = Me.logo
        Group1.GroupFooter = Me.groupFooterSection1
        Group1.GroupHeader = Me.groupHeaderSection1
        Group1.Name = "group1"
        Me.Groups.AddRange(New Telerik.Reporting.Group() {Group1})
        Me.Items.AddRange(New Telerik.Reporting.ReportItemBase() {Me.groupHeaderSection1, Me.groupFooterSection1, Me.pageHeaderSection1, Me.detail, Me.pageFooterSection1, Me.ReportHeaderSection1})
        Me.Name = "ReportListDataSupplier"
        Me.PageSettings.Landscape = False
        Me.PageSettings.Margins = New Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R), Telerik.Reporting.Drawing.Unit.Cm(0.5R))
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        ReportParameter1.AllowNull = True
        ReportParameter1.Name = "nama_perusahaan"
        ReportParameter2.AllowNull = True
        ReportParameter2.Name = "per_tanggal"
        ReportParameter3.AllowNull = True
        ReportParameter3.Name = "kota"
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
        Me.Width = Telerik.Reporting.Drawing.Unit.Cm(19.999898910522461R)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents pageHeaderSection1 As Telerik.Reporting.PageHeaderSection
    Friend WithEvents detail As Telerik.Reporting.DetailSection
    Friend WithEvents pageFooterSection1 As Telerik.Reporting.PageFooterSection
    Friend WithEvents Panel3 As Telerik.Reporting.Panel
    Friend WithEvents TextBox6 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox3 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox2 As Telerik.Reporting.TextBox
    Friend WithEvents Panel2 As Telerik.Reporting.Panel
    Friend WithEvents TextBox5 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox4 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox1 As Telerik.Reporting.TextBox
    Friend WithEvents Panel1 As Telerik.Reporting.Panel
    Friend WithEvents ReportHeaderSection1 As Telerik.Reporting.ReportHeaderSection
    Friend WithEvents groupHeaderSection1 As Telerik.Reporting.GroupHeaderSection
    Friend WithEvents groupFooterSection1 As Telerik.Reporting.GroupFooterSection
    Friend WithEvents TextBox12 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox10 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox7 As Telerik.Reporting.TextBox
    Friend WithEvents Table1 As Telerik.Reporting.Table
    Friend WithEvents TextBox13 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox14 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox15 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox8 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox9 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox11 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox16 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox29 As Telerik.Reporting.TextBox
    Friend WithEvents Table2 As Telerik.Reporting.Table
    Friend WithEvents TextBox17 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox18 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox19 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox20 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox21 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox22 As Telerik.Reporting.TextBox
    Friend WithEvents TextBox23 As Telerik.Reporting.TextBox
    Friend WithEvents SqlDataSource1 As Telerik.Reporting.SqlDataSource
    Friend WithEvents PictureBox1 As Telerik.Reporting.PictureBox
    Friend WithEvents logo As Telerik.Reporting.SqlDataSource
End Class