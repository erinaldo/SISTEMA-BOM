<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilterBulanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFilterBulanan))
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.BulanRadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.ThnRadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TahunRadDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulanRadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThnRadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TahunRadDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 12)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(68, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Pilih Periode"
        '
        'BulanRadDropDownList1
        '
        Me.BulanRadDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.BulanRadDropDownList1.Location = New System.Drawing.Point(161, 47)
        Me.BulanRadDropDownList1.Name = "BulanRadDropDownList1"
        Me.BulanRadDropDownList1.Size = New System.Drawing.Size(117, 20)
        Me.BulanRadDropDownList1.TabIndex = 3
        '
        'ThnRadDropDownList1
        '
        Me.ThnRadDropDownList1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.ThnRadDropDownList1.Location = New System.Drawing.Point(76, 47)
        Me.ThnRadDropDownList1.Name = "ThnRadDropDownList1"
        Me.ThnRadDropDownList1.Size = New System.Drawing.Size(71, 20)
        Me.ThnRadDropDownList1.TabIndex = 4
        '
        'RadButton1
        '
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadButton1.Location = New System.Drawing.Point(203, 133)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(75, 36)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "OK"
        Me.RadButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 50)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(55, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Bulan"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 91)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(57, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Tahun"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TahunRadDropDownList2
        '
        Me.TahunRadDropDownList2.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.TahunRadDropDownList2.Enabled = False
        Me.TahunRadDropDownList2.Location = New System.Drawing.Point(76, 88)
        Me.TahunRadDropDownList2.Name = "TahunRadDropDownList2"
        Me.TahunRadDropDownList2.Size = New System.Drawing.Size(117, 20)
        Me.TahunRadDropDownList2.TabIndex = 8
        '
        'FormFilterBulanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 172)
        Me.Controls.Add(Me.TahunRadDropDownList2)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.ThnRadDropDownList1)
        Me.Controls.Add(Me.BulanRadDropDownList1)
        Me.Controls.Add(Me.RadLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFilterBulanan"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Bulanan"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulanRadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThnRadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TahunRadDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents BulanRadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents ThnRadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TahunRadDropDownList2 As Telerik.WinControls.UI.RadDropDownList
End Class

