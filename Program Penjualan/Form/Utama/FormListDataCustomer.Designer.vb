<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListDataCustomer
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim FilterDescriptor1 As Telerik.WinControls.Data.FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor()
        Dim FilterDescriptor2 As Telerik.WinControls.Data.FilterDescriptor = New Telerik.WinControls.Data.FilterDescriptor()
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormListDataCustomer))
        Me.Panel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.TabelcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TokoDataSet = New Program_Penjualan_V2.tokoDataSet()
        Me.Panel2 = New Telerik.WinControls.UI.RadPanel()
        Me.ID_ComboBox = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.Daerah_ComboBox = New Telerik.WinControls.UI.RadDropDownList()
        Me.Thn_ComboBox = New Telerik.WinControls.UI.RadDropDownList()
        Me.Bln_ComboBox = New Telerik.WinControls.UI.RadDropDownList()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.Label3 = New Telerik.WinControls.UI.RadLabel()
        Me.Label2 = New Telerik.WinControls.UI.RadLabel()
        Me.Label1 = New Telerik.WinControls.UI.RadLabel()
        Me.Label4 = New Telerik.WinControls.UI.RadLabel()
        Me.Button3 = New Telerik.WinControls.UI.RadButton()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.Tabel_customerTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerTableAdapter()
        Me.Tabel_customerDistinctTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerDistinctTableAdapter()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.ID_ComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_ComboBox.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_ComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Daerah_ComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Thn_ComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bln_ComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadGridView1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1066, 559)
        Me.Panel1.TabIndex = 0
        '
        'RadGridView1
        '
        Me.RadGridView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadGridView1.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.Color.Black
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(12, 89)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowDeleteRow = False
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.HeaderText = "No"
        GridViewDecimalColumn1.Name = "no"
        GridViewDecimalColumn1.ReadOnly = True
        GridViewDecimalColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewDecimalColumn1.Width = 44
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "id_customer"
        GridViewTextBoxColumn1.HeaderText = "ID Customer"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "id_customer"
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn1.Width = 120
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "nama"
        GridViewTextBoxColumn2.HeaderText = "Nama Customer"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "nama"
        GridViewTextBoxColumn2.Width = 178
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "alamat"
        GridViewTextBoxColumn3.HeaderText = "Alamat"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "alamat"
        GridViewTextBoxColumn3.Width = 233
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "asal"
        GridViewTextBoxColumn4.HeaderText = "Daerah / Kota"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "asal"
        GridViewTextBoxColumn4.Width = 110
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "telp"
        GridViewTextBoxColumn5.HeaderText = "Telp / HP"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "telp"
        GridViewTextBoxColumn5.Width = 127
        GridViewDecimalColumn2.DataType = GetType(Integer)
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "hutang_lama"
        GridViewDecimalColumn2.FormatString = "{0:N0}"
        GridViewDecimalColumn2.HeaderText = "Hutang"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.IsVisible = False
        GridViewDecimalColumn2.Name = "hutang_lama"
        GridViewDecimalColumn2.ReadOnly = True
        GridViewDecimalColumn2.Width = 62
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "catatan"
        GridViewTextBoxColumn6.HeaderText = "catatan"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.IsVisible = False
        GridViewTextBoxColumn6.Name = "catatan"
        GridViewDateTimeColumn1.EnableExpressionEditor = False
        GridViewDateTimeColumn1.FieldName = "terdaftar_bln"
        GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        GridViewDateTimeColumn1.FormatString = "{0:dd MMMM yyyy}"
        GridViewDateTimeColumn1.HeaderText = "Terdaftar Tanggal"
        GridViewDateTimeColumn1.IsAutoGenerated = True
        GridViewDateTimeColumn1.Name = "terdaftar_bln"
        GridViewDateTimeColumn1.ReadOnly = True
        GridViewDateTimeColumn1.Width = 132
        GridViewCommandColumn1.DefaultText = "Cetak Kartu"
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.HeaderText = "Cetak Kartu"
        GridViewCommandColumn1.Name = "cetak_kartu"
        GridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        GridViewCommandColumn1.UseDefaultText = True
        GridViewCommandColumn1.Width = 85
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewDecimalColumn2, GridViewTextBoxColumn6, GridViewDateTimeColumn1, GridViewCommandColumn1})
        Me.RadGridView1.MasterTemplate.DataSource = Me.TabelcustomerBindingSource
        Me.RadGridView1.MasterTemplate.EnableGrouping = False
        Me.RadGridView1.MasterTemplate.EnableSorting = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadGridView1.ShowGroupPanel = False
        Me.RadGridView1.Size = New System.Drawing.Size(1042, 410)
        Me.RadGridView1.TabIndex = 24
        Me.RadGridView1.Text = "RadGridView1"
        '
        'TabelcustomerBindingSource
        '
        Me.TabelcustomerBindingSource.DataMember = "tabel_customer"
        Me.TabelcustomerBindingSource.DataSource = Me.TokoDataSet
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
        Me.Panel2.Controls.Add(Me.ID_ComboBox)
        Me.Panel2.Controls.Add(Me.Daerah_ComboBox)
        Me.Panel2.Controls.Add(Me.Thn_ComboBox)
        Me.Panel2.Controls.Add(Me.Bln_ComboBox)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1042, 71)
        Me.Panel2.TabIndex = 23
        '
        'ID_ComboBox
        '
        Me.ID_ComboBox.AutoFilter = True
        Me.ID_ComboBox.AutoSizeDropDownHeight = True
        Me.ID_ComboBox.AutoSizeDropDownToBestFit = True
        '
        'ID_ComboBox.NestedRadGridView
        '
        Me.ID_ComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.ID_ComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.ID_ComboBox.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ID_ComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ID_ComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ID_ComboBox.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.ID_ComboBox.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.ID_ComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.ID_ComboBox.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.ID_ComboBox.EditorControl.MasterTemplate.AllowColumnReorder = False
        Me.ID_ComboBox.EditorControl.MasterTemplate.AllowColumnResize = False
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "id"
        GridViewTextBoxColumn7.HeaderText = "ID Customer"
        GridViewTextBoxColumn7.Name = "id"
        GridViewTextBoxColumn7.Width = 113
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "nama"
        GridViewTextBoxColumn8.HeaderText = "Nama Customer"
        GridViewTextBoxColumn8.Name = "nama"
        GridViewTextBoxColumn8.Width = 172
        Me.ID_ComboBox.EditorControl.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn7, GridViewTextBoxColumn8})
        Me.ID_ComboBox.EditorControl.MasterTemplate.EnableFiltering = True
        Me.ID_ComboBox.EditorControl.MasterTemplate.EnableGrouping = False
        FilterDescriptor1.PropertyName = "id"
        FilterDescriptor2.PropertyName = "nama"
        Me.ID_ComboBox.EditorControl.MasterTemplate.FilterDescriptors.AddRange(New Telerik.WinControls.Data.FilterDescriptor() {FilterDescriptor1, FilterDescriptor2})
        Me.ID_ComboBox.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.ID_ComboBox.EditorControl.Name = "NestedRadGridView"
        Me.ID_ComboBox.EditorControl.ReadOnly = True
        Me.ID_ComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ID_ComboBox.EditorControl.ShowGroupPanel = False
        Me.ID_ComboBox.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.ID_ComboBox.EditorControl.TabIndex = 0
        Me.ID_ComboBox.Location = New System.Drawing.Point(115, 10)
        Me.ID_ComboBox.Name = "ID_ComboBox"
        Me.ID_ComboBox.Size = New System.Drawing.Size(158, 20)
        Me.ID_ComboBox.TabIndex = 34
        '
        'Daerah_ComboBox
        '
        Me.Daerah_ComboBox.AllowShowFocusCues = False
        Me.Daerah_ComboBox.AutoCompleteDisplayMember = Nothing
        Me.Daerah_ComboBox.AutoCompleteValueMember = Nothing
        Me.Daerah_ComboBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.Daerah_ComboBox.Location = New System.Drawing.Point(115, 41)
        Me.Daerah_ComboBox.Name = "Daerah_ComboBox"
        Me.Daerah_ComboBox.Size = New System.Drawing.Size(158, 20)
        Me.Daerah_ComboBox.TabIndex = 33
        '
        'Thn_ComboBox
        '
        Me.Thn_ComboBox.AllowShowFocusCues = False
        Me.Thn_ComboBox.AutoCompleteDisplayMember = Nothing
        Me.Thn_ComboBox.AutoCompleteValueMember = Nothing
        Me.Thn_ComboBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.Thn_ComboBox.Location = New System.Drawing.Point(643, 43)
        Me.Thn_ComboBox.Name = "Thn_ComboBox"
        Me.Thn_ComboBox.Size = New System.Drawing.Size(77, 20)
        Me.Thn_ComboBox.TabIndex = 32
        Me.Thn_ComboBox.Visible = False
        '
        'Bln_ComboBox
        '
        Me.Bln_ComboBox.AllowShowFocusCues = False
        Me.Bln_ComboBox.AutoCompleteDisplayMember = Nothing
        Me.Bln_ComboBox.AutoCompleteValueMember = Nothing
        Me.Bln_ComboBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        RadListDataItem1.Text = "< semua >"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "Januari"
        RadListDataItem2.TextWrap = True
        RadListDataItem3.Text = "Februari"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Text = "Maret"
        RadListDataItem4.TextWrap = True
        RadListDataItem5.Text = "April"
        RadListDataItem5.TextWrap = True
        RadListDataItem6.Text = "Mei"
        RadListDataItem6.TextWrap = True
        RadListDataItem7.Text = "Juni"
        RadListDataItem7.TextWrap = True
        RadListDataItem8.Text = "Juli"
        RadListDataItem8.TextWrap = True
        RadListDataItem9.Text = "Agustus"
        RadListDataItem9.TextWrap = True
        RadListDataItem10.Text = "September"
        RadListDataItem10.TextWrap = True
        RadListDataItem11.Text = "Oktober"
        RadListDataItem11.TextWrap = True
        RadListDataItem12.Text = "November"
        RadListDataItem12.TextWrap = True
        RadListDataItem13.Text = "Desember"
        RadListDataItem13.TextWrap = True
        Me.Bln_ComboBox.Items.Add(RadListDataItem1)
        Me.Bln_ComboBox.Items.Add(RadListDataItem2)
        Me.Bln_ComboBox.Items.Add(RadListDataItem3)
        Me.Bln_ComboBox.Items.Add(RadListDataItem4)
        Me.Bln_ComboBox.Items.Add(RadListDataItem5)
        Me.Bln_ComboBox.Items.Add(RadListDataItem6)
        Me.Bln_ComboBox.Items.Add(RadListDataItem7)
        Me.Bln_ComboBox.Items.Add(RadListDataItem8)
        Me.Bln_ComboBox.Items.Add(RadListDataItem9)
        Me.Bln_ComboBox.Items.Add(RadListDataItem10)
        Me.Bln_ComboBox.Items.Add(RadListDataItem11)
        Me.Bln_ComboBox.Items.Add(RadListDataItem12)
        Me.Bln_ComboBox.Items.Add(RadListDataItem13)
        Me.Bln_ComboBox.Location = New System.Drawing.Point(479, 42)
        Me.Bln_ComboBox.Name = "Bln_ComboBox"
        Me.Bln_ComboBox.Size = New System.Drawing.Size(158, 20)
        Me.Bln_ComboBox.TabIndex = 31
        Me.Bln_ComboBox.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button1.Location = New System.Drawing.Point(968, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 71)
        Me.Button1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Daerah / Kota"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "ID Customer"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Terdaftar Bulan"
        Me.Label1.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 538)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 18)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tekan [Delete] untuk hapus               Tekan [F5] untuk edit"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(862, 505)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 42)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Cetak"
        Me.Button3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(970, 505)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 42)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Selesai"
        Me.Button2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Tabel_customerTableAdapter
        '
        Me.Tabel_customerTableAdapter.ClearBeforeFill = True
        '
        'Tabel_customerDistinctTableAdapter
        '
        Me.Tabel_customerDistinctTableAdapter.ClearBeforeFill = True
        '
        'FormListDataCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 559)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormListDataCustomer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Data Customer"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ID_ComboBox.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_ComboBox.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_ComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Daerah_ComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Thn_ComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bln_ComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Label4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Button3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Panel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Daerah_ComboBox As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Thn_ComboBox As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents Bln_ComboBox As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ID_ComboBox As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents TokoDataSet As Program_Penjualan_V2.tokoDataSet
    Friend WithEvents TabelcustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabel_customerTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerTableAdapter
    Friend WithEvents Tabel_customerDistinctTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerDistinctTableAdapter
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
End Class
