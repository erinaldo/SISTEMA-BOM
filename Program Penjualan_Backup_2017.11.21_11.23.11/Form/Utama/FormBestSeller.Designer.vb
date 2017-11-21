<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBestSeller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBestSeller))
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewHyperlinkColumn1 As Telerik.WinControls.UI.GridViewHyperlinkColumn = New Telerik.WinControls.UI.GridViewHyperlinkColumn()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Me.Panel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadPanel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.TabelbestSellerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TokoDataSet = New Program_Penjualan_V2.tokoDataSet()
        Me.Tabel_bestSellerTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_bestSellerTableAdapter()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadPanel1.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelbestSellerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadButton2)
        Me.Panel1.Controls.Add(Me.RadPanel1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.RadGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 324)
        Me.Panel1.TabIndex = 0
        '
        'RadButton2
        '
        Me.RadButton2.Image = CType(resources.GetObject("RadButton2.Image"), System.Drawing.Image)
        Me.RadButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadButton2.Location = New System.Drawing.Point(271, 287)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(115, 32)
        Me.RadButton2.TabIndex = 6
        Me.RadButton2.Text = "Most Profit"
        Me.RadButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadPanel1
        '
        Me.RadPanel1.Controls.Add(Me.RadButton1)
        Me.RadPanel1.Controls.Add(Me.RadDateTimePicker2)
        Me.RadPanel1.Controls.Add(Me.RadLabel2)
        Me.RadPanel1.Controls.Add(Me.RadDateTimePicker1)
        Me.RadPanel1.Controls.Add(Me.RadLabel1)
        Me.RadPanel1.Location = New System.Drawing.Point(12, 6)
        Me.RadPanel1.Name = "RadPanel1"
        Me.RadPanel1.Size = New System.Drawing.Size(587, 39)
        Me.RadPanel1.TabIndex = 5
        '
        'RadButton1
        '
        Me.RadButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton1.Location = New System.Drawing.Point(535, 0)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(52, 39)
        Me.RadButton1.TabIndex = 4
        '
        'RadDateTimePicker2
        '
        Me.RadDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RadDateTimePicker2.Location = New System.Drawing.Point(310, 8)
        Me.RadDateTimePicker2.Name = "RadDateTimePicker2"
        Me.RadDateTimePicker2.Size = New System.Drawing.Size(133, 20)
        Me.RadDateTimePicker2.TabIndex = 3
        Me.RadDateTimePicker2.TabStop = False
        Me.RadDateTimePicker2.Value = New Date(CType(0, Long))
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(218, 8)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(86, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "Sampai Tanggal"
        '
        'RadDateTimePicker1
        '
        Me.RadDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RadDateTimePicker1.Location = New System.Drawing.Point(79, 6)
        Me.RadDateTimePicker1.Name = "RadDateTimePicker1"
        Me.RadDateTimePicker1.Size = New System.Drawing.Size(133, 20)
        Me.RadDateTimePicker1.TabIndex = 1
        Me.RadDateTimePicker1.TabStop = False
        Me.RadDateTimePicker1.Value = New Date(CType(0, Long))
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(3, 6)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Dari Tanggal"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button2.Location = New System.Drawing.Point(513, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 32)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Selesai"
        Me.Button2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(392, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 32)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Best Seller"
        Me.Button1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadGridView1
        '
        Me.RadGridView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.Color.Black
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(12, 51)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        Me.RadGridView1.MasterTemplate.AutoGenerateColumns = False
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "No"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "no"
        GridViewTextBoxColumn1.Width = 83
        GridViewHyperlinkColumn1.EnableExpressionEditor = False
        GridViewHyperlinkColumn1.FieldName = "tipe_barang"
        GridViewHyperlinkColumn1.HeaderText = "Tipe Barang"
        GridViewHyperlinkColumn1.Name = "tipe_barang"
        GridViewHyperlinkColumn1.Width = 122
        GridViewDecimalColumn1.DecimalPlaces = 0
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "terjual"
        GridViewDecimalColumn1.FormatString = "{0:N0}"
        GridViewDecimalColumn1.HeaderText = "Qty /pcs"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.Name = "terjual_total"
        GridViewDecimalColumn1.ThousandsSeparator = True
        GridViewDecimalColumn1.Width = 79
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "profit_total"
        GridViewDecimalColumn2.HeaderText = "Profit"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.Name = "profit_total"
        GridViewDecimalColumn2.ThousandsSeparator = True
        GridViewDecimalColumn2.Width = 128
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "penjualan"
        GridViewDecimalColumn3.HeaderText = "Penjualan"
        GridViewDecimalColumn3.Name = "penjualan"
        GridViewDecimalColumn3.ThousandsSeparator = True
        GridViewDecimalColumn3.Width = 128
        GridViewDecimalColumn4.DecimalPlaces = 0
        GridViewDecimalColumn4.EnableExpressionEditor = False
        GridViewDecimalColumn4.FieldName = "stok"
        GridViewDecimalColumn4.FormatString = "{0:N0}"
        GridViewDecimalColumn4.HeaderText = "Stok"
        GridViewDecimalColumn4.Name = "stok"
        GridViewDecimalColumn4.ThousandsSeparator = True
        GridViewDecimalColumn4.Width = 114
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewHyperlinkColumn1, GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewDecimalColumn4})
        Me.RadGridView1.MasterTemplate.DataSource = Me.TabelbestSellerBindingSource
        Me.RadGridView1.MasterTemplate.EnableGrouping = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadGridView1.ShowGroupPanel = False
        Me.RadGridView1.Size = New System.Drawing.Size(587, 230)
        Me.RadGridView1.TabIndex = 2
        Me.RadGridView1.Text = "RadGridView1"
        '
        'TabelbestSellerBindingSource
        '
        Me.TabelbestSellerBindingSource.DataMember = "tabel_bestSeller"
        Me.TabelbestSellerBindingSource.DataSource = Me.TokoDataSet
        '
        'TokoDataSet
        '
        Me.TokoDataSet.DataSetName = "tokoDataSet"
        Me.TokoDataSet.EnforceConstraints = False
        Me.TokoDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.TokoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'Tabel_bestSellerTableAdapter
        '
        Me.Tabel_bestSellerTableAdapter.ClearBeforeFill = True
        '
        'FormBestSeller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 324)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormBestSeller"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Best Seller & Most Profit"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadPanel1.ResumeLayout(False)
        Me.RadPanel1.PerformLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelbestSellerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TokoDataSet As Program_Penjualan_V2.tokoDataSet
    Friend WithEvents TabelbestSellerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabel_bestSellerTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_bestSellerTableAdapter
    Friend WithEvents Panel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadPanel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents RadDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
End Class
