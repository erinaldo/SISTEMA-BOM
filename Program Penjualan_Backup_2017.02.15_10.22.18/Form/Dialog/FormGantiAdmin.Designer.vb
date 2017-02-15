<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGantiAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGantiAdmin))
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.Tabel_userTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_userTableAdapter()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton1
        '
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton1.Location = New System.Drawing.Point(267, 93)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(79, 29)
        Me.RadButton1.TabIndex = 2
        '
        'RadTextBox2
        '
        Me.RadTextBox2.Location = New System.Drawing.Point(127, 62)
        Me.RadTextBox2.Name = "RadTextBox2"
        Me.RadTextBox2.NullText = "Masukkan Password"
        Me.RadTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RadTextBox2.Size = New System.Drawing.Size(219, 20)
        Me.RadTextBox2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'RadTextBox1
        '
        Me.RadTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RadTextBox1.Location = New System.Drawing.Point(127, 27)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "Masukkan Username"
        Me.RadTextBox1.Size = New System.Drawing.Size(219, 20)
        Me.RadTextBox1.TabIndex = 0
        '
        'Tabel_userTableAdapter1
        '
        Me.Tabel_userTableAdapter1.ClearBeforeFill = True
        '
        'FormGantiAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 134)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadTextBox2)
        Me.Controls.Add(Me.RadButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormGantiAdmin"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ganti Admin"
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadTextBox2 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tabel_userTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_userTableAdapter
    Private WithEvents RadTextBox1 As Telerik.WinControls.UI.RadDropDownList
End Class

