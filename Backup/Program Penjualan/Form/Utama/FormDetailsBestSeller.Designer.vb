<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailsBestSeller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDetailsBestSeller))
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Me.Panel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.DataGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.TabeldetailbestsellerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TokoDataSet = New Program_Penjualan_V2.tokoDataSet()
        Me.Tabel_detail_bestsellerTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_detail_bestsellerTableAdapter()
        Me.Tabel_tipe_barangTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_tipe_barangTableAdapter()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabeldetailbestsellerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.RadButton2)
        Me.Panel1.Controls.Add(Me.RadButton1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 280)
        Me.Panel1.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 3)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(58, 18)
        Me.RadLabel1.TabIndex = 4
        Me.RadLabel1.Text = "RadLabel1"
        '
        'RadButton2
        '
        Me.RadButton2.Image = CType(resources.GetObject("RadButton2.Image"), System.Drawing.Image)
        Me.RadButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadButton2.Location = New System.Drawing.Point(459, 240)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(96, 31)
        Me.RadButton2.TabIndex = 3
        Me.RadButton2.Text = "Print"
        Me.RadButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadButton1
        '
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadButton1.Location = New System.Drawing.Point(572, 240)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(96, 31)
        Me.RadButton1.TabIndex = 2
        Me.RadButton1.Text = "Selesai"
        Me.RadButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'DataGridView1
        '
        Me.DataGridView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.DataGridView1.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        '
        'DataGridView1
        '
        Me.DataGridView1.MasterTemplate.AllowAddNewRow = False
        Me.DataGridView1.MasterTemplate.AutoGenerateColumns = False
        Me.DataGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "No"
        GridViewTextBoxColumn1.Name = "no"
        GridViewTextBoxColumn1.Width = 32
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "kode_barang"
        GridViewTextBoxColumn2.HeaderText = "Kode Barang"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "kode_barang"
        GridViewTextBoxColumn2.Width = 95
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "nama_barang"
        GridViewTextBoxColumn3.HeaderText = "Nama Barang"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "nama_barang"
        GridViewTextBoxColumn3.Width = 138
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "terjual"
        GridViewDecimalColumn1.FormatString = "{0:N0}"
        GridViewDecimalColumn1.HeaderText = "Qty (pcs)"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.Name = "terjual"
        GridViewDecimalColumn1.ThousandsSeparator = True
        GridViewDecimalColumn1.Width = 58
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "profit"
        GridViewDecimalColumn2.FormatString = "{0:N2}"
        GridViewDecimalColumn2.HeaderText = "Profit (Rp)"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.Name = "profit"
        GridViewDecimalColumn2.ThousandsSeparator = True
        GridViewDecimalColumn2.Width = 121
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "penjualan"
        GridViewDecimalColumn3.FormatString = "{0:N2}"
        GridViewDecimalColumn3.HeaderText = "Penjualan (Rp)"
        GridViewDecimalColumn3.Name = "penjualan"
        GridViewDecimalColumn3.ThousandsSeparator = True
        GridViewDecimalColumn3.Width = 134
        GridViewDecimalColumn4.DataType = GetType(Integer)
        GridViewDecimalColumn4.EnableExpressionEditor = False
        GridViewDecimalColumn4.FieldName = "stok_barang"
        GridViewDecimalColumn4.FormatString = "{0:N2}"
        GridViewDecimalColumn4.HeaderText = "Stok (pcs)"
        GridViewDecimalColumn4.Name = "stok_barang"
        GridViewDecimalColumn4.ThousandsSeparator = True
        GridViewDecimalColumn4.Width = 64
        Me.DataGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewDecimalColumn4})
        Me.DataGridView1.MasterTemplate.DataSource = Me.TabeldetailbestsellerBindingSource
        Me.DataGridView1.MasterTemplate.EnableSorting = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.ShowGroupPanel = False
        Me.DataGridView1.Size = New System.Drawing.Size(656, 207)
        Me.DataGridView1.TabIndex = 1
        Me.DataGridView1.Text = "RadGridView1"
        '
        'TabeldetailbestsellerBindingSource
        '
        Me.TabeldetailbestsellerBindingSource.DataMember = "tabel_detail_bestseller"
        Me.TabeldetailbestsellerBindingSource.DataSource = Me.TokoDataSet
        '
        'TokoDataSet
        '
        Me.TokoDataSet.DataSetName = "tokoDataSet"
        Me.TokoDataSet.EnforceConstraints = False
        Me.TokoDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.TokoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'Tabel_detail_bestsellerTableAdapter
        '
        Me.Tabel_detail_bestsellerTableAdapter.ClearBeforeFill = True
        '
        'Tabel_tipe_barangTableAdapter1
        '
        Me.Tabel_tipe_barangTableAdapter1.ClearBeforeFill = True
        '
        'FormDetailsBestSeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 280)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDetailsBestSeller"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Best Seller Tipe"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabeldetailbestsellerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents DataGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TabeldetailbestsellerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TokoDataSet As Program_Penjualan_V2.tokoDataSet
    Friend WithEvents Tabel_detail_bestsellerTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_detail_bestsellerTableAdapter
    Friend WithEvents Tabel_tipe_barangTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_tipe_barangTableAdapter
End Class
