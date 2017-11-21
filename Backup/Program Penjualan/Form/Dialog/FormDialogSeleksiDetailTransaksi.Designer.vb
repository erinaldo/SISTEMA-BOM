<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDialogSeleksiDetailTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDialogSeleksiDetailTransaksi))
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(3, 3)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Customer"
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(3, 33)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(44, 18)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "Periode"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.RadDropDownList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDropDownList1.Location = New System.Drawing.Point(3, 3)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(117, 18)
        Me.RadDropDownList1.TabIndex = 2
        '
        'RadDateTimePicker1
        '
        Me.RadDateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RadDateTimePicker1.Location = New System.Drawing.Point(3, 3)
        Me.RadDateTimePicker1.Name = "RadDateTimePicker1"
        Me.RadDateTimePicker1.Size = New System.Drawing.Size(106, 19)
        Me.RadDateTimePicker1.TabIndex = 3
        Me.RadDateTimePicker1.TabStop = False
        Me.RadDateTimePicker1.Text = "03/09/2014"
        Me.RadDateTimePicker1.Value = New Date(2014, 9, 3, 22, 51, 48, 769)
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(115, 3)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(22, 18)
        Me.RadLabel3.TabIndex = 4
        Me.RadLabel3.Text = "s/d"
        '
        'RadDateTimePicker2
        '
        Me.RadDateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RadDateTimePicker2.Location = New System.Drawing.Point(152, 3)
        Me.RadDateTimePicker2.Name = "RadDateTimePicker2"
        Me.RadDateTimePicker2.Size = New System.Drawing.Size(107, 19)
        Me.RadDateTimePicker2.TabIndex = 5
        Me.RadDateTimePicker2.TabStop = False
        Me.RadDateTimePicker2.Text = "03/09/2014"
        Me.RadDateTimePicker2.Value = New Date(2014, 9, 3, 22, 51, 48, 769)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel1.Controls.Add(Me.RadDateTimePicker1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadDateTimePicker2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RadLabel3, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(73, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(262, 25)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.50575!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.49425!))
        Me.TableLayoutPanel2.Controls.Add(Me.RadLabel4, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadDropDownList1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(73, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(321, 24)
        Me.TableLayoutPanel2.TabIndex = 7
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(126, 3)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(55, 18)
        Me.RadLabel4.TabIndex = 3
        Me.RadLabel4.Text = "Customer"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 327.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.RadLabel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RadLabel2, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.RadButton1, 1, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(10, 12)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(397, 100)
        Me.TableLayoutPanel3.TabIndex = 8
        '
        'RadButton1
        '
        Me.RadButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton1.Location = New System.Drawing.Point(318, 64)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(76, 33)
        Me.RadButton1.TabIndex = 8
        Me.RadButton1.Text = "OK"
        Me.RadButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'FormDialogSeleksiDetailTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 122)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDialogSeleksiDetailTransaksi"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDialogSeleksiDetailTransaksi"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

