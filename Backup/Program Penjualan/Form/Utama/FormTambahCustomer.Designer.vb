<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTambahCustomer))
        Me.Panel1 = New Telerik.WinControls.UI.RadPanel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Panel2 = New Telerik.WinControls.UI.RadPanel()
        Me.Button2 = New Telerik.WinControls.UI.RadButton()
        Me.Button1 = New Telerik.WinControls.UI.RadButton()
        Me.Keterangan_RichTextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.Hutang_TextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.Telp_TextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.Kota_TextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.Alamat_TextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.Nama_TextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.CheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
        Me.Terdaftar_Bln_TextBox = New Telerik.WinControls.UI.RadTextBox()
        Me.Label8 = New Telerik.WinControls.UI.RadLabel()
        Me.Label7 = New Telerik.WinControls.UI.RadLabel()
        Me.Label6 = New Telerik.WinControls.UI.RadLabel()
        Me.Label5 = New Telerik.WinControls.UI.RadLabel()
        Me.Label4 = New Telerik.WinControls.UI.RadLabel()
        Me.Label3 = New Telerik.WinControls.UI.RadLabel()
        Me.ID_Customer_TextBox = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.Label1 = New Telerik.WinControls.UI.RadLabel()
        Me.Label22 = New Telerik.WinControls.UI.RadLabel()
        Me.Tabel_customerTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerTableAdapter()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Keterangan_RichTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hutang_TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Telp_TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kota_TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alamat_TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Nama_TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Terdaftar_Bln_TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID_Customer_TextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Terdaftar_Bln_TextBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ID_Customer_TextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 361)
        Me.Panel1.TabIndex = 0
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 76)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(36, 18)
        Me.RadLabel1.TabIndex = 90
        Me.RadLabel1.Text = "Nama"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Keterangan_RichTextBox)
        Me.Panel2.Controls.Add(Me.Hutang_TextBox)
        Me.Panel2.Controls.Add(Me.Telp_TextBox)
        Me.Panel2.Controls.Add(Me.Kota_TextBox)
        Me.Panel2.Controls.Add(Me.Alamat_TextBox)
        Me.Panel2.Controls.Add(Me.Nama_TextBox)
        Me.Panel2.Location = New System.Drawing.Point(122, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 279)
        Me.Panel2.TabIndex = 0
        CType(Me.Panel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor2 = System.Drawing.Color.Transparent
        CType(Me.Panel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor3 = System.Drawing.Color.Transparent
        CType(Me.Panel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor4 = System.Drawing.Color.Transparent
        CType(Me.Panel2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.Transparent
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(87, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 33)
        Me.Button2.TabIndex = 100
        Me.Button2.Text = "OK"
        Me.Button2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(180, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 33)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Cancel"
        Me.Button1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Keterangan_RichTextBox
        '
        Me.Keterangan_RichTextBox.AutoSize = False
        Me.Keterangan_RichTextBox.Location = New System.Drawing.Point(7, 160)
        Me.Keterangan_RichTextBox.MaxLength = 50
        Me.Keterangan_RichTextBox.Multiline = True
        Me.Keterangan_RichTextBox.Name = "Keterangan_RichTextBox"
        Me.Keterangan_RichTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Keterangan_RichTextBox.Size = New System.Drawing.Size(253, 76)
        Me.Keterangan_RichTextBox.TabIndex = 98
        '
        'Hutang_TextBox
        '
        Me.Hutang_TextBox.Location = New System.Drawing.Point(7, 128)
        Me.Hutang_TextBox.MaxLength = 10
        Me.Hutang_TextBox.Name = "Hutang_TextBox"
        Me.Hutang_TextBox.Size = New System.Drawing.Size(198, 20)
        Me.Hutang_TextBox.TabIndex = 97
        Me.Hutang_TextBox.Text = "0"
        Me.Hutang_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Telp_TextBox
        '
        Me.Telp_TextBox.Location = New System.Drawing.Point(7, 96)
        Me.Telp_TextBox.MaxLength = 15
        Me.Telp_TextBox.Name = "Telp_TextBox"
        Me.Telp_TextBox.Size = New System.Drawing.Size(198, 20)
        Me.Telp_TextBox.TabIndex = 96
        '
        'Kota_TextBox
        '
        Me.Kota_TextBox.Location = New System.Drawing.Point(7, 64)
        Me.Kota_TextBox.MaxLength = 15
        Me.Kota_TextBox.Name = "Kota_TextBox"
        Me.Kota_TextBox.Size = New System.Drawing.Size(198, 20)
        Me.Kota_TextBox.TabIndex = 95
        '
        'Alamat_TextBox
        '
        Me.Alamat_TextBox.Location = New System.Drawing.Point(7, 32)
        Me.Alamat_TextBox.MaxLength = 30
        Me.Alamat_TextBox.Name = "Alamat_TextBox"
        Me.Alamat_TextBox.Size = New System.Drawing.Size(198, 20)
        Me.Alamat_TextBox.TabIndex = 94
        '
        'Nama_TextBox
        '
        Me.Nama_TextBox.Location = New System.Drawing.Point(7, 0)
        Me.Nama_TextBox.MaxLength = 15
        Me.Nama_TextBox.Name = "Nama_TextBox"
        Me.Nama_TextBox.Size = New System.Drawing.Size(198, 20)
        Me.Nama_TextBox.TabIndex = 93
        '
        'CheckBox1
        '
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(282, 42)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(66, 18)
        Me.CheckBox1.TabIndex = 89
        Me.CheckBox1.Text = "Generate"
        Me.CheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
        '
        'Terdaftar_Bln_TextBox
        '
        Me.Terdaftar_Bln_TextBox.Enabled = False
        Me.Terdaftar_Bln_TextBox.Location = New System.Drawing.Point(133, 10)
        Me.Terdaftar_Bln_TextBox.Name = "Terdaftar_Bln_TextBox"
        Me.Terdaftar_Bln_TextBox.Size = New System.Drawing.Size(115, 20)
        Me.Terdaftar_Bln_TextBox.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 18)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Terdaftar Tanggal"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 18)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Catatan"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 18)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Hutang Lama"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "HP / No Telp"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Kota / Daerah"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Alamat"
        '
        'ID_Customer_TextBox
        '
        Me.ID_Customer_TextBox.Location = New System.Drawing.Point(133, 42)
        Me.ID_Customer_TextBox.Mask = ">L-000-000"
        Me.ID_Customer_TextBox.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.ID_Customer_TextBox.Name = "ID_Customer_TextBox"
        Me.ID_Customer_TextBox.Size = New System.Drawing.Size(143, 20)
        Me.ID_Customer_TextBox.TabIndex = 74
        Me.ID_Customer_TextBox.TabStop = False
        Me.ID_Customer_TextBox.Text = "_-___-___"
        Me.ID_Customer_TextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "ID Customer"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 18)
        Me.Label22.TabIndex = 0
        '
        'Tabel_customerTableAdapter
        '
        Me.Tabel_customerTableAdapter.ClearBeforeFill = True
        '
        'FormTambahCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 361)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormTambahCustomer"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Customer"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Keterangan_RichTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hutang_TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Telp_TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kota_TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alamat_TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Nama_TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Terdaftar_Bln_TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID_Customer_TextBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents CheckBox1 As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents Terdaftar_Bln_TextBox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Label8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ID_Customer_TextBox As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents Label1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Label22 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Panel2 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents Keterangan_RichTextBox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Hutang_TextBox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Telp_TextBox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Kota_TextBox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Alamat_TextBox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Nama_TextBox As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents Tabel_customerTableAdapter As tokoDataSetTableAdapters.tabel_customerTableAdapter
    Friend WithEvents Button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
End Class
