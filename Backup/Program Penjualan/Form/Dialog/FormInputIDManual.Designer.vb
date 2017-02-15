<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInputIDManual
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
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadMaskedEditBox1 = New Telerik.WinControls.UI.RadMaskedEditBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.status_status = New Telerik.WinControls.UI.RadLabel()
        Me.status_tipebarang = New Telerik.WinControls.UI.RadLabel()
        Me.Tabel_tipe_barangTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_tipe_barangTableAdapter()
        Me.Tabel_barangTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barangTableAdapter()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadMaskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.status_status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.status_tipebarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = False
        Me.RadLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadLabel1.Location = New System.Drawing.Point(3, 3)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(70, 31)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "ID Barang"
        Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadMaskedEditBox1
        '
        Me.RadMaskedEditBox1.AutoSize = False
        Me.RadMaskedEditBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.RadMaskedEditBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadMaskedEditBox1.Location = New System.Drawing.Point(3, 3)
        Me.RadMaskedEditBox1.Mask = "LLL-000000"
        Me.RadMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.Standard
        Me.RadMaskedEditBox1.Name = "RadMaskedEditBox1"
        Me.RadMaskedEditBox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.RadMaskedEditBox1.Size = New System.Drawing.Size(160, 24)
        Me.RadMaskedEditBox1.TabIndex = 1
        Me.RadMaskedEditBox1.TabStop = False
        Me.RadMaskedEditBox1.Text = "   -      "
        '
        'RadButton1
        '
        Me.RadButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadButton1.Location = New System.Drawing.Point(169, 3)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(56, 24)
        Me.RadButton1.TabIndex = 2
        Me.RadButton1.Text = "Check"
        '
        'RadLabel2
        '
        Me.RadLabel2.AutoSize = False
        Me.RadLabel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadLabel2.Location = New System.Drawing.Point(3, 40)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(70, 31)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Tipe Barang"
        Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadLabel3
        '
        Me.RadLabel3.AutoSize = False
        Me.RadLabel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadLabel3.Location = New System.Drawing.Point(3, 77)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(70, 31)
        Me.RadLabel3.TabIndex = 4
        Me.RadLabel3.Text = "Status"
        Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.97298!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.02703!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadMaskedEditBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadButton1, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(79, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(228, 30)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.51613!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.48387!))
        Me.TableLayoutPanel2.Controls.Add(Me.status_status, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.status_tipebarang, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.RadLabel1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadLabel3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadLabel2, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(310, 111)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'status_status
        '
        Me.status_status.AutoSize = False
        Me.status_status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.status_status.Location = New System.Drawing.Point(79, 77)
        Me.status_status.Name = "status_status"
        Me.status_status.Size = New System.Drawing.Size(228, 31)
        Me.status_status.TabIndex = 7
        Me.status_status.Text = "Status"
        Me.status_status.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'status_tipebarang
        '
        Me.status_tipebarang.AutoSize = False
        Me.status_tipebarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.status_tipebarang.Location = New System.Drawing.Point(79, 40)
        Me.status_tipebarang.Name = "status_tipebarang"
        Me.status_tipebarang.Size = New System.Drawing.Size(228, 31)
        Me.status_tipebarang.TabIndex = 6
        Me.status_tipebarang.Text = "Tipe Barang"
        Me.status_tipebarang.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Tabel_tipe_barangTableAdapter1
        '
        Me.Tabel_tipe_barangTableAdapter1.ClearBeforeFill = True
        '
        'Tabel_barangTableAdapter1
        '
        Me.Tabel_barangTableAdapter1.ClearBeforeFill = True
        '
        'RadLabel4
        '
        Me.RadLabel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 6.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel4.Location = New System.Drawing.Point(286, 124)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(38, 15)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "Refresh"
        '
        'FormInputIDManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 142)
        Me.Controls.Add(Me.RadLabel4)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormInputIDManual"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input ID Manual"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadMaskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.status_status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.status_tipebarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadMaskedEditBox1 As Telerik.WinControls.UI.RadMaskedEditBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents status_status As Telerik.WinControls.UI.RadLabel
    Friend WithEvents status_tipebarang As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Tabel_tipe_barangTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_tipe_barangTableAdapter
    Friend WithEvents Tabel_barangTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_barangTableAdapter
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
End Class
