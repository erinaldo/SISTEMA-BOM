<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLapTransaksiPenjualan
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewHyperlinkColumn1 As Telerik.WinControls.UI.GridViewHyperlinkColumn = New Telerik.WinControls.UI.GridViewHyperlinkColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewHyperlinkColumn2 As Telerik.WinControls.UI.GridViewHyperlinkColumn = New Telerik.WinControls.UI.GridViewHyperlinkColumn()
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewSummaryItem1 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem2 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim GridViewSummaryItem3 As Telerik.WinControls.UI.GridViewSummaryItem = New Telerik.WinControls.UI.GridViewSummaryItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLapTransaksiPenjualan))
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim FilterDescriptor1 As Telerik.WinControls.Data.FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor()
        Dim FilterDescriptor2 As Telerik.WinControls.Data.FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor()
        Me.Panel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.TabeltransbarangkeluarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TokoDataSet = New Program_Penjualan_V2.tokoDataSet()
        Me.Panel2 = New Telerik.WinControls.UI.RadPanel()
        Me.RadCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.Label5 = New Telerik.WinControls.UI.RadLabel()
        Me.Sales_ComboBox = New Telerik.WinControls.UI.RadDropDownList()
        Me.Label4 = New Telerik.WinControls.UI.RadLabel()
        Me.Label3 = New Telerik.WinControls.UI.RadLabel()
        Me.Customer_ComboBox = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Akhir_DateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Awal_DateTimePicker = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.Label2 = New Telerik.WinControls.UI.RadLabel()
        Me.Label1 = New Telerik.WinControls.UI.RadLabel()
        Me.Button3 = New Telerik.WinControls.UI.RadButton()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.Tabel_customerTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerTableAdapter()
        Me.Tabel_salesTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_salesTableAdapter()
        Me.TabelcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabel_trans_barang_keluarTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_trans_barang_keluarTableAdapter()
        Me.Tabel_barang_keluarTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barang_keluarTableAdapter()
        Me.Tabel_invoice_keluarTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_invoice_keluarTableAdapter()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabeltransbarangkeluarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.RadCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sales_ComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_ComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_ComboBox.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_ComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Akhir_DateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Awal_DateTimePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(991, 616)
        Me.Panel1.TabIndex = 0
        '
        'RadGridView1
        '
        Me.RadGridView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.Color.Black
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(12, 111)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowDeleteRow = False
        Me.RadGridView1.MasterTemplate.AllowEditRow = False
        Me.RadGridView1.MasterTemplate.AutoGenerateColumns = False
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.HeaderText = "No"
        GridViewDecimalColumn1.Name = "no"
        GridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        GridViewDecimalColumn1.Width = 34
        GridViewHyperlinkColumn1.EnableExpressionEditor = False
        GridViewHyperlinkColumn1.FieldName = "invoice"
        GridViewHyperlinkColumn1.HeaderText = "Invoice"
        GridViewHyperlinkColumn1.IsAutoGenerated = True
        GridViewHyperlinkColumn1.Name = "invoice"
        GridViewHyperlinkColumn1.Width = 139
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "nama"
        GridViewTextBoxColumn1.HeaderText = "Nama Customer"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "nama"
        GridViewTextBoxColumn1.Width = 120
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "sales"
        GridViewTextBoxColumn2.HeaderText = "Sales"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "sales"
        GridViewTextBoxColumn2.Width = 105
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "tipe_penjualan"
        GridViewTextBoxColumn3.HeaderText = "Tipe"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "tipe_penjualan"
        GridViewTextBoxColumn3.Width = 45
        GridViewDecimalColumn2.DataType = GetType(Double)
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "hutang_lama"
        GridViewDecimalColumn2.FormatString = "{0:N2}"
        GridViewDecimalColumn2.HeaderText = "Hutang Lama"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.Name = "hutang_lama"
        GridViewDecimalColumn2.Width = 99
        GridViewDecimalColumn3.DataType = GetType(Double)
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "belanja"
        GridViewDecimalColumn3.FormatString = "{0:N2}"
        GridViewDecimalColumn3.HeaderText = "Total Penjualan"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.Name = "belanja"
        GridViewDecimalColumn3.Width = 120
        GridViewHyperlinkColumn2.DataType = GetType(Double)
        GridViewHyperlinkColumn2.EnableExpressionEditor = False
        GridViewHyperlinkColumn2.FieldName = "retur"
        GridViewHyperlinkColumn2.FormatString = "{0:N2}"
        GridViewHyperlinkColumn2.HeaderText = "Total Retur"
        GridViewHyperlinkColumn2.Name = "retur"
        GridViewHyperlinkColumn2.ReadOnly = False
        GridViewHyperlinkColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewHyperlinkColumn2.Width = 91
        GridViewDecimalColumn4.DataType = GetType(Double)
        GridViewDecimalColumn4.EnableExpressionEditor = False
        GridViewDecimalColumn4.FieldName = "pembayaran"
        GridViewDecimalColumn4.FormatString = "{0:N2}"
        GridViewDecimalColumn4.HeaderText = "Total Bayar"
        GridViewDecimalColumn4.IsAutoGenerated = True
        GridViewDecimalColumn4.Name = "pembayaran"
        GridViewDecimalColumn4.Width = 120
        GridViewDecimalColumn5.DataType = GetType(Double)
        GridViewDecimalColumn5.EnableExpressionEditor = False
        GridViewDecimalColumn5.FieldName = "hutang_baru"
        GridViewDecimalColumn5.FormatString = "{0:N2}"
        GridViewDecimalColumn5.HeaderText = "Hutang Baru"
        GridViewDecimalColumn5.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewDecimalColumn5.IsAutoGenerated = True
        GridViewDecimalColumn5.Name = "hutang_baru"
        GridViewDecimalColumn5.Width = 83
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "id_customer"
        GridViewTextBoxColumn4.HeaderText = "ID Customer"
        GridViewTextBoxColumn4.IsVisible = False
        GridViewTextBoxColumn4.Name = "id_customer"
        GridViewTextBoxColumn4.Width = 48
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewHyperlinkColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewHyperlinkColumn2, GridViewDecimalColumn4, GridViewDecimalColumn5, GridViewTextBoxColumn4})
        Me.RadGridView1.MasterTemplate.DataSource = Me.TabeltransbarangkeluarBindingSource
        Me.RadGridView1.MasterTemplate.EnableGrouping = False
        Me.RadGridView1.MasterTemplate.EnableSorting = False
        GridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem1.FormatString = "{0:N2}"
        GridViewSummaryItem1.Name = "belanja"
        GridViewSummaryItem2.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem2.FormatString = "{0:N2}"
        GridViewSummaryItem2.Name = "retur"
        GridViewSummaryItem3.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum
        GridViewSummaryItem3.FormatString = "{0:N2}"
        GridViewSummaryItem3.Name = "pembayaran"
        Me.RadGridView1.MasterTemplate.SummaryRowsBottom.Add(New Telerik.WinControls.UI.GridViewSummaryRowItem(New Telerik.WinControls.UI.GridViewSummaryItem() {GridViewSummaryItem1, GridViewSummaryItem2, GridViewSummaryItem3}))
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadGridView1.ShowGroupPanel = False
        Me.RadGridView1.Size = New System.Drawing.Size(967, 452)
        Me.RadGridView1.TabIndex = 30
        Me.RadGridView1.Text = "RadGridView1"
        '
        'TabeltransbarangkeluarBindingSource
        '
        Me.TabeltransbarangkeluarBindingSource.DataMember = "tabel_trans_barang_keluar"
        Me.TabeltransbarangkeluarBindingSource.DataSource = Me.TokoDataSet
        '
        'TokoDataSet
        '
        Me.TokoDataSet.DataSetName = "tokoDataSet"
        Me.TokoDataSet.EnforceConstraints = False
        Me.TokoDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.TokoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadCheckBox3)
        Me.Panel2.Controls.Add(Me.RadCheckBox2)
        Me.Panel2.Controls.Add(Me.RadCheckBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Sales_ComboBox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Customer_ComboBox)
        Me.Panel2.Controls.Add(Me.Akhir_DateTimePicker)
        Me.Panel2.Controls.Add(Me.Awal_DateTimePicker)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(967, 93)
        Me.Panel2.TabIndex = 29
        '
        'RadCheckBox3
        '
        Me.RadCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadCheckBox3.Location = New System.Drawing.Point(678, 60)
        Me.RadCheckBox3.Name = "RadCheckBox3"
        Me.RadCheckBox3.Size = New System.Drawing.Size(87, 18)
        Me.RadCheckBox3.TabIndex = 39
        Me.RadCheckBox3.Text = "Order Barang"
        Me.RadCheckBox3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadCheckBox2
        '
        Me.RadCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadCheckBox2.Location = New System.Drawing.Point(624, 60)
        Me.RadCheckBox2.Name = "RadCheckBox2"
        Me.RadCheckBox2.Size = New System.Drawing.Size(48, 18)
        Me.RadCheckBox2.TabIndex = 38
        Me.RadCheckBox2.Text = "Retail"
        Me.RadCheckBox2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'RadCheckBox1
        '
        Me.RadCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RadCheckBox1.Location = New System.Drawing.Point(568, 60)
        Me.RadCheckBox1.Name = "RadCheckBox1"
        Me.RadCheckBox1.Size = New System.Drawing.Size(50, 18)
        Me.RadCheckBox1.TabIndex = 37
        Me.RadCheckBox1.Text = "Grosir"
        Me.RadCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button1.Location = New System.Drawing.Point(874, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 93)
        Me.Button1.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(465, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 18)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Tipe Penjualan"
        '
        'Sales_ComboBox
        '
        Me.Sales_ComboBox.AllowShowFocusCues = False
        Me.Sales_ComboBox.AutoCompleteDisplayMember = Nothing
        Me.Sales_ComboBox.AutoCompleteValueMember = Nothing
        Me.Sales_ComboBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.Sales_ComboBox.Location = New System.Drawing.Point(568, 32)
        Me.Sales_ComboBox.Name = "Sales_ComboBox"
        Me.Sales_ComboBox.Size = New System.Drawing.Size(121, 20)
        Me.Sales_ComboBox.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(465, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Sales"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(465, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Customer"
        '
        'Customer_ComboBox
        '
        Me.Customer_ComboBox.AutoFilter = True
        Me.Customer_ComboBox.AutoSizeDropDownToBestFit = True
        Me.Customer_ComboBox.DisplayMember = "id_customer"
        Me.Customer_ComboBox.DropDownSizingMode = Telerik.WinControls.UI.SizingMode.RightBottom
        '
        'Customer_ComboBox.NestedRadGridView
        '
        Me.Customer_ComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.Customer_ComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.Customer_ComboBox.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Customer_ComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Customer_ComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Customer_ComboBox.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowColumnReorder = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowColumnResize = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowDeleteRow = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowDragToGroup = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowEditRow = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.AllowRowResize = False
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "id_customer"
        GridViewTextBoxColumn5.HeaderText = "ID Customer"
        GridViewTextBoxColumn5.Name = "id_customer"
        GridViewTextBoxColumn5.VisibleInColumnChooser = False
        GridViewTextBoxColumn5.Width = 100
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "nama"
        GridViewTextBoxColumn6.HeaderText = "Nama Customer"
        GridViewTextBoxColumn6.Name = "nama"
        GridViewTextBoxColumn6.VisibleInColumnChooser = False
        GridViewTextBoxColumn6.Width = 140
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "asal"
        GridViewTextBoxColumn7.HeaderText = "Kota"
        GridViewTextBoxColumn7.Name = "asal"
        GridViewTextBoxColumn7.Width = 140
        Me.Customer_ComboBox.EditorControl.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7})
        Me.Customer_ComboBox.EditorControl.MasterTemplate.EnableFiltering = True
        Me.Customer_ComboBox.EditorControl.MasterTemplate.EnableGrouping = False
        Me.Customer_ComboBox.EditorControl.MasterTemplate.EnableSorting = False
        FilterDescriptor1.PropertyName = "id_customer"
        FilterDescriptor2.PropertyName = "nama"
        Me.Customer_ComboBox.EditorControl.MasterTemplate.FilterDescriptors.AddRange(New Telerik.WinControls.Data.FilterDescriptor() {FilterDescriptor1, FilterDescriptor2})
        Me.Customer_ComboBox.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.Customer_ComboBox.EditorControl.Name = "NestedRadGridView"
        Me.Customer_ComboBox.EditorControl.ReadOnly = True
        Me.Customer_ComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Customer_ComboBox.EditorControl.ShowGroupPanel = False
        Me.Customer_ComboBox.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.Customer_ComboBox.EditorControl.TabIndex = 0
        Me.Customer_ComboBox.Location = New System.Drawing.Point(568, 6)
        Me.Customer_ComboBox.Name = "Customer_ComboBox"
        Me.Customer_ComboBox.Size = New System.Drawing.Size(121, 20)
        Me.Customer_ComboBox.TabIndex = 33
        Me.Customer_ComboBox.TabStop = False
        Me.Customer_ComboBox.Text = "< Semua >"
        '
        'Akhir_DateTimePicker
        '
        Me.Akhir_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Akhir_DateTimePicker.Location = New System.Drawing.Point(121, 47)
        Me.Akhir_DateTimePicker.Name = "Akhir_DateTimePicker"
        Me.Akhir_DateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.Akhir_DateTimePicker.TabIndex = 29
        Me.Akhir_DateTimePicker.TabStop = False
        Me.Akhir_DateTimePicker.Text = "14/05/2013"
        Me.Akhir_DateTimePicker.Value = New Date(2013, 5, 14, 0, 0, 0, 0)
        '
        'Awal_DateTimePicker
        '
        Me.Awal_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Awal_DateTimePicker.Location = New System.Drawing.Point(121, 19)
        Me.Awal_DateTimePicker.Name = "Awal_DateTimePicker"
        Me.Awal_DateTimePicker.Size = New System.Drawing.Size(137, 20)
        Me.Awal_DateTimePicker.TabIndex = 28
        Me.Awal_DateTimePicker.TabStop = False
        Me.Awal_DateTimePicker.Text = "14/05/2013"
        Me.Awal_DateTimePicker.Value = New Date(2013, 5, 14, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Sampai Tanggal"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Dari Tanggal"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(766, 569)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 42)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Cetak"
        Me.Button3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(886, 569)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 42)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Selesai"
        Me.Button2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Tabel_customerTableAdapter
        '
        Me.Tabel_customerTableAdapter.ClearBeforeFill = True
        '
        'Tabel_salesTableAdapter
        '
        Me.Tabel_salesTableAdapter.ClearBeforeFill = True
        '
        'TabelcustomerBindingSource
        '
        Me.TabelcustomerBindingSource.DataMember = "tabel_customer"
        Me.TabelcustomerBindingSource.DataSource = Me.TokoDataSet
        '
        'Tabel_trans_barang_keluarTableAdapter
        '
        Me.Tabel_trans_barang_keluarTableAdapter.ClearBeforeFill = True
        '
        'Tabel_barang_keluarTableAdapter
        '
        Me.Tabel_barang_keluarTableAdapter.ClearBeforeFill = True
        '
        'Tabel_invoice_keluarTableAdapter1
        '
        Me.Tabel_invoice_keluarTableAdapter1.ClearBeforeFill = True
        '
        'FormLapTransaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 616)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormLapTransaksiPenjualan"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Transaksi Penjualan"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabeltransbarangkeluarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.RadCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sales_ComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_ComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_ComboBox.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_ComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Akhir_DateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Awal_DateTimePicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Button3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Sales_ComboBox As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Customer_ComboBox As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Label5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Akhir_DateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Awal_DateTimePicker As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents Label2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Tabel_customerTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerTableAdapter
    Friend WithEvents Tabel_salesTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_salesTableAdapter
    Friend WithEvents TokoDataSet As Program_Penjualan_V2.tokoDataSet
    Friend WithEvents TabeltransbarangkeluarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabel_trans_barang_keluarTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_trans_barang_keluarTableAdapter
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TabelcustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RadCheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox3 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadCheckBox2 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Tabel_barang_keluarTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barang_keluarTableAdapter
    Friend WithEvents Tabel_invoice_keluarTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_invoice_keluarTableAdapter
End Class
