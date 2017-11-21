<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFilterPeriode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFilterPeriode))
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(12, 48)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(70, 18)
        Me.RadLabel2.TabIndex = 1
        Me.RadLabel2.Text = "Dari Tanggal"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(12, 81)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(86, 18)
        Me.RadLabel3.TabIndex = 2
        Me.RadLabel3.Text = "Sampai Tanggal"
        '
        'RadDateTimePicker1
        '
        Me.RadDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RadDateTimePicker1.Location = New System.Drawing.Point(106, 48)
        Me.RadDateTimePicker1.Name = "RadDateTimePicker1"
        Me.RadDateTimePicker1.Size = New System.Drawing.Size(156, 20)
        Me.RadDateTimePicker1.TabIndex = 3
        Me.RadDateTimePicker1.TabStop = True
        Me.RadDateTimePicker1.Text = "20/08/2013"
        Me.RadDateTimePicker1.Value = New Date(2013, 8, 20, 17, 55, 31, 112)
        '
        'RadDateTimePicker2
        '
        Me.RadDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RadDateTimePicker2.Location = New System.Drawing.Point(106, 79)
        Me.RadDateTimePicker2.Name = "RadDateTimePicker2"
        Me.RadDateTimePicker2.Size = New System.Drawing.Size(156, 20)
        Me.RadDateTimePicker2.TabIndex = 4
        Me.RadDateTimePicker2.TabStop = True
        Me.RadDateTimePicker2.Text = "20/08/2013"
        Me.RadDateTimePicker2.Value = New Date(2013, 8, 20, 17, 55, 31, 112)
        '
        'RadButton1
        '
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.RadButton1.Location = New System.Drawing.Point(185, 114)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(77, 38)
        Me.RadButton1.TabIndex = 5
        Me.RadButton1.Text = "OK"
        Me.RadButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'FormFilterPeriode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 164)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadDateTimePicker2)
        Me.Controls.Add(Me.RadDateTimePicker1)
        Me.Controls.Add(Me.RadLabel3)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.RadLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFilterPeriode"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Periode"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDateTimePicker1 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadDateTimePicker2 As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
End Class

