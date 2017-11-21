<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahSupplier))
        Me.Panel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel2 = New Telerik.WinControls.UI.RadPanel()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.RichTextBox_keterangan = New Telerik.WinControls.UI.RadTextBox()
        Me.TextBox_telp = New Telerik.WinControls.UI.RadTextBox()
        Me.TextBox_kota = New Telerik.WinControls.UI.RadTextBox()
        Me.TextBox_Alamat = New Telerik.WinControls.UI.RadTextBox()
        Me.TextBox_Nama = New Telerik.WinControls.UI.RadTextBox()
        Me.Label6 = New Telerik.WinControls.UI.RadLabel()
        Me.Label5 = New Telerik.WinControls.UI.RadLabel()
        Me.Label4 = New Telerik.WinControls.UI.RadLabel()
        Me.Label3 = New Telerik.WinControls.UI.RadLabel()
        Me.CheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.TextBox_bln = New Telerik.WinControls.UI.RadTextBox()
        Me.Label8 = New Telerik.WinControls.UI.RadLabel()
        Me.TextBox_ID = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label1 = New Telerik.WinControls.UI.RadLabel()
        Me.Label22 = New Telerik.WinControls.UI.RadLabel()
        Me.Tabel_supplierTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_supplierTableAdapter()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RichTextBox_keterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_telp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_kota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_Alamat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_Nama, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_bln, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_ID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.TextBox_bln)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox_ID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 345)
        Me.Panel1.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel1.Location = New System.Drawing.Point(12, 85)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(36, 18)
        Me.RadLabel1.TabIndex = 74
        Me.RadLabel1.Text = "Nama"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.RichTextBox_keterangan)
        Me.Panel2.Controls.Add(Me.TextBox_telp)
        Me.Panel2.Controls.Add(Me.TextBox_kota)
        Me.Panel2.Controls.Add(Me.TextBox_Alamat)
        Me.Panel2.Controls.Add(Me.TextBox_Nama)
        Me.Panel2.Location = New System.Drawing.Point(115, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(282, 258)
        Me.Panel2.TabIndex = 73
        CType(Me.Panel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor2 = System.Drawing.Color.Transparent
        CType(Me.Panel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor3 = System.Drawing.Color.Transparent
        CType(Me.Panel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor4 = System.Drawing.Color.Transparent
        CType(Me.Panel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(99, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "OK"
        Me.Button2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(191, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Cancel"
        Me.Button1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RichTextBox_keterangan
        '
        Me.RichTextBox_keterangan.AutoSize = False
        Me.RichTextBox_keterangan.Location = New System.Drawing.Point(13, 132)
        Me.RichTextBox_keterangan.MaxLength = 50
        Me.RichTextBox_keterangan.Multiline = True
        Me.RichTextBox_keterangan.Name = "RichTextBox_keterangan"
        Me.RichTextBox_keterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RichTextBox_keterangan.Size = New System.Drawing.Size(253, 73)
        Me.RichTextBox_keterangan.TabIndex = 76
        Me.RichTextBox_keterangan.TabStop = True
        '
        'TextBox_telp
        '
        Me.TextBox_telp.Location = New System.Drawing.Point(13, 100)
        Me.TextBox_telp.MaxLength = 15
        Me.TextBox_telp.Name = "TextBox_telp"
        Me.TextBox_telp.Size = New System.Drawing.Size(198, 20)
        Me.TextBox_telp.TabIndex = 74
        Me.TextBox_telp.TabStop = True
        '
        'TextBox_kota
        '
        Me.TextBox_kota.Location = New System.Drawing.Point(12, 68)
        Me.TextBox_kota.MaxLength = 15
        Me.TextBox_kota.Name = "TextBox_kota"
        Me.TextBox_kota.Size = New System.Drawing.Size(199, 20)
        Me.TextBox_kota.TabIndex = 73
        Me.TextBox_kota.TabStop = True
        '
        'TextBox_Alamat
        '
        Me.TextBox_Alamat.Location = New System.Drawing.Point(12, 36)
        Me.TextBox_Alamat.MaxLength = 30
        Me.TextBox_Alamat.Name = "TextBox_Alamat"
        Me.TextBox_Alamat.Size = New System.Drawing.Size(198, 20)
        Me.TextBox_Alamat.TabIndex = 72
        Me.TextBox_Alamat.TabStop = True
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Location = New System.Drawing.Point(11, 4)
        Me.TextBox_Nama.MaxLength = 15
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(198, 20)
        Me.TextBox_Nama.TabIndex = 71
        Me.TextBox_Nama.TabStop = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(12, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 18)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Catatan"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(12, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "HP / No Telp"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Kota / Daerah"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Alamat"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Location = New System.Drawing.Point(276, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 18)
        Me.CheckBox1.TabIndex = 54
        Me.CheckBox1.Text = "Generate"
        Me.CheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'TextBox_bln
        '
        Me.TextBox_bln.Enabled = False
        Me.TextBox_bln.Location = New System.Drawing.Point(126, 17)
        Me.TextBox_bln.Name = "TextBox_bln"
        Me.TextBox_bln.Size = New System.Drawing.Size(118, 20)
        Me.TextBox_bln.TabIndex = 53
        Me.TextBox_bln.TabStop = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(12, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Terdaftar Tanggal"
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Enabled = False
        Me.TextBox_ID.Location = New System.Drawing.Point(127, 49)
        Me.TextBox_ID.Mask = ">L-000-000"
        Me.TextBox_ID.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_ID.TabIndex = 39
        Me.TextBox_ID.TabStop = True
        Me.TextBox_ID.Text = "_-___-___"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "ID Supplier"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(276, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(26, 26)
        Me.Label22.TabIndex = 72
        Me.Label22.Visible = False
        '
        'Tabel_supplierTableAdapter1
        '
        Me.Tabel_supplierTableAdapter1.ClearBeforeFill = True
        '
        'FormTambahSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 345)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTambahSupplier"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Supplier"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RichTextBox_keterangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox_telp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox_kota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox_Alamat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox_Nama, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox_bln, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox_ID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents CheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents TextBox_bln As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TextBox_ID As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Tabel_supplierTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_supplierTableAdapter
    Friend WithEvents Label22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RichTextBox_keterangan As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_telp As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_kota As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_Alamat As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_Nama As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class
