Imports Telerik.WinControls.Data

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_BarangMasuk
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_BarangMasuk))
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Label_Total_Pembelian = New System.Windows.Forms.Label()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.Button9 = New Telerik.WinControls.UI.RadButton()
        Me.Button_Selesai = New Telerik.WinControls.UI.RadButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_kodemanual = New Telerik.WinControls.UI.RadButton()
        Me.TextBox_Stok_Tambah = New Telerik.WinControls.UI.RadTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox_TipeBrg = New Telerik.WinControls.UI.RadDropDownList()
        Me.TextBox_KodeBrg = New Telerik.WinControls.UI.RadTextBox()
        Me.Button_kodeauto = New Telerik.WinControls.UI.RadButton()
        Me.Button_kodesearch = New Telerik.WinControls.UI.RadButton()
        Me.TextBox_NamaBrg = New Telerik.WinControls.UI.RadTextBox()
        Me.TextBox_Stok_Awal = New Telerik.WinControls.UI.RadTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button10 = New Telerik.WinControls.UI.RadButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label_Stok_Masuk = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label_Invoice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label_name_supplier = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_tambah = New Telerik.WinControls.UI.RadButton()
        Me.Button_reset = New Telerik.WinControls.UI.RadButton()
        Me.TextBox_HargaModal = New Telerik.WinControls.UI.RadTextBox()
        Me.TextBox_HargaGrosir = New Telerik.WinControls.UI.RadTextBox()
        Me.TextBox_HargaRetail = New Telerik.WinControls.UI.RadTextBox()
        Me.RichTextBox_Keterangan = New Telerik.WinControls.UI.RadTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TokoDataSet = New Program_Penjualan_V2.tokoDataSet()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Tabel_barangTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barangTableAdapter()
        Me.Tabel_supplierTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_supplierTableAdapter()
        Me.Tabel_temp_masukTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_temp_masukTableAdapter()
        Me.Tabel_supplierTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_supplierTableAdapter()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabel_status_transaksiTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_status_transaksiTableAdapter()
        Me.Tabel_barangTableAdapter_1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barang1TableAdapter()
        Me.Tabel_invoice_masukTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_invoice_masukTableAdapter()
        Me.Tabel_barang_masukTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barang_masukTableAdapter()
        Me.Tabel_tipe_barangTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_tipe_barangTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.object_40b1b343_6c89_46cd_80aa_bd76fe331378 = New Telerik.WinControls.RootRadElement()
        Me.RadMultiColumnComboBox2 = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_Selesai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Button_kodemanual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_Stok_Tambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBox_TipeBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_KodeBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_kodeauto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_kodesearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_NamaBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_Stok_Awal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_tambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button_reset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_HargaModal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_HargaGrosir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_HargaRetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RichTextBox_Keterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox2.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RadPanel1
        '
        Me.RadPanel1.BackColor = System.Drawing.Color.White
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Controls.Add(Me.DataGridView1)
        Me.RadPanel1.Controls.Add(Me.Label_Total_Pembelian)
        Me.RadPanel1.Controls.Add(Me.Button2)
        Me.RadPanel1.Controls.Add(Me.Button9)
        Me.RadPanel1.Controls.Add(Me.Button_Selesai)
        Me.RadPanel1.Controls.Add(Me.Panel1)
        Me.RadPanel1.Controls.Add(Me.Button10)
        Me.RadPanel1.Controls.Add(Me.Label17)
        Me.RadPanel1.Controls.Add(Me.Label_Stok_Masuk)
        Me.RadPanel1.Controls.Add(Me.Label61)
        Me.RadPanel1.Controls.Add(Me.Label_Invoice)
        Me.RadPanel1.Controls.Add(Me.Label4)
        Me.RadPanel1.Controls.Add(Me.label_name_supplier)
        Me.RadPanel1.Controls.Add(Me.Label22)
        Me.RadPanel1.Controls.Add(Me.Label1)
        Me.RadPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPanel1.Location = New System.Drawing.Point(0, 0)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(1008, 550)
        Me.RadPanel1.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = True
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.ForeColor = System.Drawing.Color.Black
        Me.RadLabel1.Location = New System.Drawing.Point(717, 46)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(88, 13)
        Me.RadLabel1.TabIndex = 84
        Me.RadLabel1.Text = "Total Pembelian"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.DataGridView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView1.Location = New System.Drawing.Point(12, 230)
        '
        'DataGridView1
        '
        Me.DataGridView1.MasterTemplate.AllowAddNewRow = False
        Me.DataGridView1.MasterTemplate.AllowColumnChooser = False
        Me.DataGridView1.MasterTemplate.AllowColumnReorder = False
        Me.DataGridView1.MasterTemplate.AllowColumnResize = False
        Me.DataGridView1.MasterTemplate.AllowDeleteRow = False
        Me.DataGridView1.MasterTemplate.AllowDragToGroup = False
        Me.DataGridView1.MasterTemplate.AllowRowResize = False
        Me.DataGridView1.MasterTemplate.AutoGenerateColumns = False
        GridViewTextBoxColumn1.AllowGroup = False
        GridViewTextBoxColumn1.AllowResize = False
        GridViewTextBoxColumn1.AllowSort = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "No"
        GridViewTextBoxColumn1.Name = "no"
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn1.VisibleInColumnChooser = False
        GridViewTextBoxColumn1.Width = 40
        GridViewTextBoxColumn2.AllowGroup = False
        GridViewTextBoxColumn2.AllowResize = False
        GridViewTextBoxColumn2.AllowSort = False
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "ID Barang"
        GridViewTextBoxColumn2.Name = "kode"
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn2.VisibleInColumnChooser = False
        GridViewTextBoxColumn2.Width = 130
        GridViewTextBoxColumn3.AllowGroup = False
        GridViewTextBoxColumn3.AllowResize = False
        GridViewTextBoxColumn3.AllowSort = False
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "Nama Barang"
        GridViewTextBoxColumn3.Name = "nama"
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewTextBoxColumn3.VisibleInColumnChooser = False
        GridViewTextBoxColumn3.Width = 210
        GridViewTextBoxColumn4.AllowGroup = False
        GridViewTextBoxColumn4.AllowResize = False
        GridViewTextBoxColumn4.AllowSort = False
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.HeaderText = "Stok Baru"
        GridViewTextBoxColumn4.Name = "stok"
        GridViewTextBoxColumn4.VisibleInColumnChooser = False
        GridViewTextBoxColumn4.Width = 90
        GridViewTextBoxColumn5.AllowGroup = False
        GridViewTextBoxColumn5.AllowResize = False
        GridViewTextBoxColumn5.AllowSort = False
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.HeaderText = "Harga Modal"
        GridViewTextBoxColumn5.Name = "harga_modal"
        GridViewTextBoxColumn5.ReadOnly = True
        GridViewTextBoxColumn5.VisibleInColumnChooser = False
        GridViewTextBoxColumn5.Width = 100
        GridViewTextBoxColumn6.AllowGroup = False
        GridViewTextBoxColumn6.AllowResize = False
        GridViewTextBoxColumn6.AllowSort = False
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.HeaderText = "Total Stok"
        GridViewTextBoxColumn6.Name = "total_stok"
        GridViewTextBoxColumn6.ReadOnly = True
        GridViewTextBoxColumn6.VisibleInColumnChooser = False
        GridViewTextBoxColumn6.Width = 100
        GridViewTextBoxColumn7.AllowGroup = False
        GridViewTextBoxColumn7.AllowResize = False
        GridViewTextBoxColumn7.AllowSort = False
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.HeaderText = "Harga Grosir"
        GridViewTextBoxColumn7.Name = "harga_grosir"
        GridViewTextBoxColumn7.ReadOnly = True
        GridViewTextBoxColumn7.VisibleInColumnChooser = False
        GridViewTextBoxColumn7.Width = 100
        GridViewTextBoxColumn8.AllowGroup = False
        GridViewTextBoxColumn8.AllowResize = False
        GridViewTextBoxColumn8.AllowSort = False
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.HeaderText = "Harga Retail"
        GridViewTextBoxColumn8.Name = "harga_retail"
        GridViewTextBoxColumn8.ReadOnly = True
        GridViewTextBoxColumn8.VisibleInColumnChooser = False
        GridViewTextBoxColumn8.Width = 100
        GridViewTextBoxColumn9.AllowGroup = False
        GridViewTextBoxColumn9.AllowResize = False
        GridViewTextBoxColumn9.AllowSort = False
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.HeaderText = "Tanggal Update"
        GridViewTextBoxColumn9.IsVisible = False
        GridViewTextBoxColumn9.Name = "tgl"
        GridViewTextBoxColumn9.VisibleInColumnChooser = False
        GridViewTextBoxColumn9.Width = 80
        GridViewCommandColumn1.AllowResize = False
        GridViewCommandColumn1.AllowSort = False
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.HeaderText = "Cetak Label"
        GridViewCommandColumn1.Name = "label_cetak"
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.VisibleInColumnChooser = False
        GridViewCommandColumn1.Width = 90
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.HeaderText = "Tipe Barang"
        GridViewTextBoxColumn10.IsVisible = False
        GridViewTextBoxColumn10.Name = "tipe_barang"
        GridViewTextBoxColumn10.Width = 72
        GridViewTextBoxColumn11.EnableExpressionEditor = False
        GridViewTextBoxColumn11.HeaderText = "Keterangan"
        GridViewTextBoxColumn11.IsVisible = False
        GridViewTextBoxColumn11.Name = "keterangan"
        GridViewTextBoxColumn11.Width = 77
        Me.DataGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewCommandColumn1, GridViewTextBoxColumn10, GridViewTextBoxColumn11})
        Me.DataGridView1.MasterTemplate.EnableGrouping = False
        Me.DataGridView1.MasterTemplate.EnableSorting = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.Size = New System.Drawing.Size(977, 274)
        Me.DataGridView1.TabIndex = 16
        Me.DataGridView1.TabStop = False
        '
        'Label_Total_Pembelian
        '
        Me.Label_Total_Pembelian.AutoSize = True
        Me.Label_Total_Pembelian.BackColor = System.Drawing.Color.Transparent
        Me.Label_Total_Pembelian.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Total_Pembelian.ForeColor = System.Drawing.Color.Black
        Me.Label_Total_Pembelian.Location = New System.Drawing.Point(877, 46)
        Me.Label_Total_Pembelian.Name = "Label_Total_Pembelian"
        Me.Label_Total_Pembelian.Size = New System.Drawing.Size(16, 13)
        Me.Label_Total_Pembelian.TabIndex = 81
        Me.Label_Total_Pembelian.Text = "0 "
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(754, 510)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 32)
        Me.Button2.TabIndex = 18
        Me.Button2.TabStop = False
        Me.Button2.Text = "Cetak Label"
        Me.Button2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.Location = New System.Drawing.Point(630, 510)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(118, 32)
        Me.Button9.TabIndex = 19
        Me.Button9.TabStop = False
        Me.Button9.Text = "Cetak Katalog"
        Me.Button9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.Visible = False
        '
        'Button_Selesai
        '
        Me.Button_Selesai.Enabled = False
        Me.Button_Selesai.Image = CType(resources.GetObject("Button_Selesai.Image"), System.Drawing.Image)
        Me.Button_Selesai.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button_Selesai.Location = New System.Drawing.Point(875, 510)
        Me.Button_Selesai.Name = "Button_Selesai"
        Me.Button_Selesai.Size = New System.Drawing.Size(114, 32)
        Me.Button_Selesai.TabIndex = 17
        Me.Button_Selesai.TabStop = False
        Me.Button_Selesai.Text = "Selesai"
        Me.Button_Selesai.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Selesai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button_kodemanual)
        Me.Panel1.Controls.Add(Me.TextBox_Stok_Tambah)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ComboBox_TipeBrg)
        Me.Panel1.Controls.Add(Me.TextBox_KodeBrg)
        Me.Panel1.Controls.Add(Me.Button_kodeauto)
        Me.Panel1.Controls.Add(Me.Button_kodesearch)
        Me.Panel1.Controls.Add(Me.TextBox_NamaBrg)
        Me.Panel1.Controls.Add(Me.TextBox_Stok_Awal)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 138)
        Me.Panel1.TabIndex = 1
        '
        'Button_kodemanual
        '
        Me.Button_kodemanual.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.Button_kodemanual.Location = New System.Drawing.Point(354, 17)
        Me.Button_kodemanual.Name = "Button_kodemanual"
        Me.Button_kodemanual.Size = New System.Drawing.Size(46, 35)
        Me.Button_kodemanual.TabIndex = 6
        Me.Button_kodemanual.Text = "Manual"
        '
        'TextBox_Stok_Tambah
        '
        Me.TextBox_Stok_Tambah.Location = New System.Drawing.Point(331, 84)
        Me.TextBox_Stok_Tambah.MaxLength = 4
        Me.TextBox_Stok_Tambah.Name = "TextBox_Stok_Tambah"
        Me.TextBox_Stok_Tambah.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.TextBox_Stok_Tambah.Size = New System.Drawing.Size(121, 17)
        Me.TextBox_Stok_Tambah.TabIndex = 9
        Me.TextBox_Stok_Tambah.Text = "0"
        Me.TextBox_Stok_Tambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(268, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Stok Baru"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(11, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Tipe Barang"
        '
        'ComboBox_TipeBrg
        '
        Me.ComboBox_TipeBrg.AllowShowFocusCues = False
        Me.ComboBox_TipeBrg.AutoCompleteDisplayMember = Nothing
        Me.ComboBox_TipeBrg.AutoCompleteValueMember = Nothing
        Me.ComboBox_TipeBrg.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ComboBox_TipeBrg.Location = New System.Drawing.Point(107, 5)
        Me.ComboBox_TipeBrg.Name = "ComboBox_TipeBrg"
        Me.ComboBox_TipeBrg.Size = New System.Drawing.Size(183, 20)
        Me.ComboBox_TipeBrg.TabIndex = 3
        Me.ComboBox_TipeBrg.Text = "< Pilih Tipe >"
        '
        'TextBox_KodeBrg
        '
        Me.TextBox_KodeBrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox_KodeBrg.Enabled = False
        Me.TextBox_KodeBrg.Location = New System.Drawing.Point(107, 32)
        Me.TextBox_KodeBrg.Name = "TextBox_KodeBrg"
        Me.TextBox_KodeBrg.ReadOnly = True
        Me.TextBox_KodeBrg.Size = New System.Drawing.Size(184, 20)
        Me.TextBox_KodeBrg.TabIndex = 4
        '
        'Button_kodeauto
        '
        Me.Button_kodeauto.Enabled = False
        Me.Button_kodeauto.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Button_kodeauto.Location = New System.Drawing.Point(302, 17)
        Me.Button_kodeauto.Name = "Button_kodeauto"
        Me.Button_kodeauto.Size = New System.Drawing.Size(46, 35)
        Me.Button_kodeauto.TabIndex = 5
        Me.Button_kodeauto.Text = "Auto"
        '
        'Button_kodesearch
        '
        Me.Button_kodesearch.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Button_kodesearch.Location = New System.Drawing.Point(406, 17)
        Me.Button_kodesearch.Name = "Button_kodesearch"
        Me.Button_kodesearch.Size = New System.Drawing.Size(46, 35)
        Me.Button_kodesearch.TabIndex = 7
        Me.Button_kodesearch.Text = "Search"
        '
        'TextBox_NamaBrg
        '
        Me.TextBox_NamaBrg.Location = New System.Drawing.Point(106, 58)
        Me.TextBox_NamaBrg.MaxLength = 30
        Me.TextBox_NamaBrg.Name = "TextBox_NamaBrg"
        Me.TextBox_NamaBrg.Size = New System.Drawing.Size(346, 20)
        Me.TextBox_NamaBrg.TabIndex = 8
        '
        'TextBox_Stok_Awal
        '
        Me.TextBox_Stok_Awal.Enabled = False
        Me.TextBox_Stok_Awal.Location = New System.Drawing.Point(107, 84)
        Me.TextBox_Stok_Awal.Name = "TextBox_Stok_Awal"
        Me.TextBox_Stok_Awal.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Stok_Awal.TabIndex = 33
        Me.TextBox_Stok_Awal.TabStop = False
        Me.TextBox_Stok_Awal.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(11, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "ID Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Nama Barang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Stok Lama"
        '
        'Button10
        '
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.Location = New System.Drawing.Point(12, 510)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(114, 32)
        Me.Button10.TabIndex = 20
        Me.Button10.TabStop = False
        Me.Button10.Text = "Batal"
        Me.Button10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(12, 214)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(185, 13)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Data Barang masuk [F5] untuk Edit"
        '
        'Label_Stok_Masuk
        '
        Me.Label_Stok_Masuk.AutoSize = True
        Me.Label_Stok_Masuk.BackColor = System.Drawing.Color.Transparent
        Me.Label_Stok_Masuk.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Stok_Masuk.ForeColor = System.Drawing.Color.Black
        Me.Label_Stok_Masuk.Location = New System.Drawing.Point(877, 25)
        Me.Label_Stok_Masuk.Name = "Label_Stok_Masuk"
        Me.Label_Stok_Masuk.Size = New System.Drawing.Size(16, 13)
        Me.Label_Stok_Masuk.TabIndex = 69
        Me.Label_Stok_Masuk.Text = "0 "
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(715, 25)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(109, 13)
        Me.Label61.TabIndex = 68
        Me.Label61.Text = "Total Barang Masuk"
        '
        'Label_Invoice
        '
        Me.Label_Invoice.AutoSize = True
        Me.Label_Invoice.BackColor = System.Drawing.Color.Transparent
        Me.Label_Invoice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Invoice.ForeColor = System.Drawing.Color.Black
        Me.Label_Invoice.Location = New System.Drawing.Point(801, 3)
        Me.Label_Invoice.Name = "Label_Invoice"
        Me.Label_Invoice.Size = New System.Drawing.Size(77, 15)
        Me.Label_Invoice.TabIndex = 67
        Me.Label_Invoice.Text = "1208050001"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(717, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 15)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "INVOICE"
        '
        'label_name_supplier
        '
        Me.label_name_supplier.AutoSize = True
        Me.label_name_supplier.BackColor = System.Drawing.Color.Transparent
        Me.label_name_supplier.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name_supplier.ForeColor = System.Drawing.Color.Black
        Me.label_name_supplier.Location = New System.Drawing.Point(119, 40)
        Me.label_name_supplier.Name = "label_name_supplier"
        Me.label_name_supplier.Size = New System.Drawing.Size(52, 13)
        Me.label_name_supplier.TabIndex = 65
        Me.label_name_supplier.Text = "no name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(11, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 13)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Nama Supplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "ID Supplier"
        '
        'Button_tambah
        '
        Me.Button_tambah.Enabled = False
        Me.Button_tambah.Image = CType(resources.GetObject("Button_tambah.Image"), System.Drawing.Image)
        Me.Button_tambah.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button_tambah.Location = New System.Drawing.Point(442, 77)
        Me.Button_tambah.Name = "Button_tambah"
        Me.Button_tambah.Size = New System.Drawing.Size(60, 60)
        Me.Button_tambah.TabIndex = 14
        '
        'Button_reset
        '
        Me.Button_reset.Image = CType(resources.GetObject("Button_reset.Image"), System.Drawing.Image)
        Me.Button_reset.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button_reset.Location = New System.Drawing.Point(472, -1)
        Me.Button_reset.Name = "Button_reset"
        Me.Button_reset.Size = New System.Drawing.Size(30, 30)
        Me.Button_reset.TabIndex = 15
        Me.Button_reset.TabStop = False
        '
        'TextBox_HargaModal
        '
        Me.TextBox_HargaModal.Location = New System.Drawing.Point(112, 6)
        Me.TextBox_HargaModal.MaxLength = 10
        Me.TextBox_HargaModal.Name = "TextBox_HargaModal"
        Me.TextBox_HargaModal.Size = New System.Drawing.Size(184, 20)
        Me.TextBox_HargaModal.TabIndex = 10
        Me.TextBox_HargaModal.Text = "0"
        Me.TextBox_HargaModal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_HargaGrosir
        '
        Me.TextBox_HargaGrosir.Location = New System.Drawing.Point(112, 32)
        Me.TextBox_HargaGrosir.MaxLength = 10
        Me.TextBox_HargaGrosir.Name = "TextBox_HargaGrosir"
        Me.TextBox_HargaGrosir.Size = New System.Drawing.Size(184, 20)
        Me.TextBox_HargaGrosir.TabIndex = 11
        Me.TextBox_HargaGrosir.Text = "0"
        Me.TextBox_HargaGrosir.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_HargaRetail
        '
        Me.TextBox_HargaRetail.Location = New System.Drawing.Point(112, 58)
        Me.TextBox_HargaRetail.MaxLength = 10
        Me.TextBox_HargaRetail.Name = "TextBox_HargaRetail"
        Me.TextBox_HargaRetail.Size = New System.Drawing.Size(184, 20)
        Me.TextBox_HargaRetail.TabIndex = 12
        Me.TextBox_HargaRetail.Text = "0"
        Me.TextBox_HargaRetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RichTextBox_Keterangan
        '
        Me.RichTextBox_Keterangan.AutoSize = False
        Me.RichTextBox_Keterangan.Location = New System.Drawing.Point(112, 84)
        Me.RichTextBox_Keterangan.MaxLength = 50
        Me.RichTextBox_Keterangan.Multiline = True
        Me.RichTextBox_Keterangan.Name = "RichTextBox_Keterangan"
        Me.RichTextBox_Keterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RichTextBox_Keterangan.Size = New System.Drawing.Size(186, 38)
        Me.RichTextBox_Keterangan.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(17, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Harga Modal"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(17, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 44
        Me.Label13.Text = "Harga Grosir"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(17, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "Harga Retail"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(17, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Keterangan"
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "tabel_supplier"
        Me.BindingSource3.DataSource = Me.TokoDataSet
        '
        'TokoDataSet
        '
        Me.TokoDataSet.DataSetName = "tokoDataSet"
        Me.TokoDataSet.EnforceConstraints = False
        Me.TokoDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.TokoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(911, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 25)
        Me.Label21.TabIndex = 77
        Me.Label21.Text = "pcs"
        '
        'Tabel_barangTableAdapter
        '
        Me.Tabel_barangTableAdapter.ClearBeforeFill = True
        '
        'Tabel_supplierTableAdapter
        '
        Me.Tabel_supplierTableAdapter.ClearBeforeFill = True
        '
        'Tabel_temp_masukTableAdapter
        '
        Me.Tabel_temp_masukTableAdapter.ClearBeforeFill = True
        '
        'Tabel_supplierTableAdapter1
        '
        Me.Tabel_supplierTableAdapter1.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tabel_supplier"
        Me.BindingSource2.DataSource = Me.TokoDataSet
        '
        'Tabel_status_transaksiTableAdapter
        '
        Me.Tabel_status_transaksiTableAdapter.ClearBeforeFill = True
        '
        'Tabel_barangTableAdapter_1
        '
        Me.Tabel_barangTableAdapter_1.ClearBeforeFill = True
        '
        'Tabel_invoice_masukTableAdapter
        '
        Me.Tabel_invoice_masukTableAdapter.ClearBeforeFill = True
        '
        'Tabel_barang_masukTableAdapter
        '
        Me.Tabel_barang_masukTableAdapter.ClearBeforeFill = True
        '
        'Tabel_tipe_barangTableAdapter
        '
        Me.Tabel_tipe_barangTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tabel_supplier"
        Me.BindingSource1.DataSource = Me.TokoDataSet
        '
        'object_40b1b343_6c89_46cd_80aa_bd76fe331378
        '
        Me.object_40b1b343_6c89_46cd_80aa_bd76fe331378.Name = "object_40b1b343_6c89_46cd_80aa_bd76fe331378"
        Me.object_40b1b343_6c89_46cd_80aa_bd76fe331378.StretchHorizontally = True
        Me.object_40b1b343_6c89_46cd_80aa_bd76fe331378.StretchVertically = True
        Me.object_40b1b343_6c89_46cd_80aa_bd76fe331378.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadMultiColumnComboBox2
        '
        Me.RadMultiColumnComboBox2.AutoFilter = True
        Me.RadMultiColumnComboBox2.AutoSizeDropDownHeight = True
        Me.RadMultiColumnComboBox2.AutoSizeDropDownToBestFit = True
        Me.RadMultiColumnComboBox2.DisplayMember = "id_supplier"
        '
        'RadMultiColumnComboBox2.NestedRadGridView
        '
        Me.RadMultiColumnComboBox2.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.RadMultiColumnComboBox2.EditorControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadMultiColumnComboBox2.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.RadMultiColumnComboBox2.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadMultiColumnComboBox2.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadMultiColumnComboBox2.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate.AllowColumnChooser = False
        GridViewTextBoxColumn12.EnableExpressionEditor = False
        GridViewTextBoxColumn12.FieldName = "id_supplier"
        GridViewTextBoxColumn12.HeaderText = "ID Supplier"
        GridViewTextBoxColumn12.Name = "id_supplier"
        GridViewTextBoxColumn12.Width = 147
        GridViewTextBoxColumn13.EnableExpressionEditor = False
        GridViewTextBoxColumn13.FieldName = "nama_supplier"
        GridViewTextBoxColumn13.HeaderText = "Nama Supplier"
        GridViewTextBoxColumn13.Name = "nama_supplier"
        GridViewTextBoxColumn13.Width = 177
        GridViewTextBoxColumn14.EnableExpressionEditor = False
        GridViewTextBoxColumn14.FieldName = "asal"
        GridViewTextBoxColumn14.HeaderText = "Kota Supplier"
        GridViewTextBoxColumn14.Name = "kota_supplier"
        Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14})
        Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate.EnableFiltering = True
        Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate.EnableGrouping = False
        Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.RadMultiColumnComboBox2.EditorControl.Name = "NestedRadGridView"
        Me.RadMultiColumnComboBox2.EditorControl.ReadOnly = True
        Me.RadMultiColumnComboBox2.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadMultiColumnComboBox2.EditorControl.ShowGroupPanel = False
        Me.RadMultiColumnComboBox2.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.RadMultiColumnComboBox2.EditorControl.TabIndex = 0
        Me.RadMultiColumnComboBox2.Location = New System.Drawing.Point(120, 14)
        Me.RadMultiColumnComboBox2.Name = "RadMultiColumnComboBox2"
        Me.RadMultiColumnComboBox2.Size = New System.Drawing.Size(183, 20)
        Me.RadMultiColumnComboBox2.TabIndex = 98
        Me.RadMultiColumnComboBox2.TabStop = False
        Me.RadMultiColumnComboBox2.Text = "< Pilih Supplier >"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button_tambah)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Button_reset)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.RichTextBox_Keterangan)
        Me.Panel2.Controls.Add(Me.TextBox_HargaRetail)
        Me.Panel2.Controls.Add(Me.TextBox_HargaGrosir)
        Me.Panel2.Controls.Add(Me.TextBox_HargaModal)
        Me.Panel2.Location = New System.Drawing.Point(486, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 138)
        Me.Panel2.TabIndex = 2
        '
        'UC_BarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadMultiColumnComboBox2)
        Me.Controls.Add(Me.RadPanel1)
        Me.Name = "UC_BarangMasuk"
        Me.Size = New System.Drawing.Size(1008, 550)
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(false)
        Me.RadPanel1.PerformLayout
        CType(Me.DataGridView1.MasterTemplate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Button2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Button9,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Button_Selesai,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.Button_kodemanual,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox_Stok_Tambah,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComboBox_TipeBrg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox_KodeBrg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Button_kodeauto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Button_kodesearch,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox_NamaBrg,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox_Stok_Awal,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Button10,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Button_tambah,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Button_reset,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox_HargaModal,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox_HargaGrosir,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TextBox_HargaRetail,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RichTextBox_Keterangan,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BindingSource3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TokoDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BindingSource2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadMultiColumnComboBox2.EditorControl.MasterTemplate,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadMultiColumnComboBox2.EditorControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RadMultiColumnComboBox2,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TabelsupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents no As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents kode As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents nama As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents stok As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents harga_modal As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents total_stok As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents harga_grosir As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents harga_retail As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents tgl As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents label_cetak As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents tipe_barang As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents keterangan As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents direktorigambar As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents filename As Telerik.WinControls.UI.GridViewTextBoxColumn
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TokoDataSet As Program_Penjualan_V2.tokoDataSet
    Friend WithEvents Label_Total_Pembelian As System.Windows.Forms.Label
    Friend WithEvents label_name_supplier As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button9 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Button_tambah As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button_Selesai As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox_Stok_Tambah As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button_reset As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox_TipeBrg As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents TextBox_KodeBrg As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Button_kodeauto As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button_kodesearch As Telerik.WinControls.UI.RadButton
    Friend WithEvents TextBox_NamaBrg As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_Stok_Awal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_HargaModal As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_HargaGrosir As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_HargaRetail As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RichTextBox_Keterangan As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button10 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label_Stok_Masuk As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_Invoice As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Tabel_barangTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barangTableAdapter
    Friend WithEvents Tabel_supplierTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_supplierTableAdapter
    Friend WithEvents Tabel_temp_masukTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_temp_masukTableAdapter
    Friend WithEvents Tabel_supplierTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_supplierTableAdapter
    Friend WithEvents Tabel_status_transaksiTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_status_transaksiTableAdapter
    Friend WithEvents Tabel_barangTableAdapter_1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barang1TableAdapter
    Friend WithEvents Tabel_invoice_masukTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_invoice_masukTableAdapter
    Friend WithEvents Tabel_barang_masukTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barang_masukTableAdapter
    Friend WithEvents Tabel_tipe_barangTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_tipe_barangTableAdapter
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents object_40b1b343_6c89_46cd_80aa_bd76fe331378 As Telerik.WinControls.RootRadElement
    Friend WithEvents RadLabel1 As System.Windows.Forms.Label
    Friend WithEvents RadMultiColumnComboBox2 As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents Button_kodemanual As Telerik.WinControls.UI.RadButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
