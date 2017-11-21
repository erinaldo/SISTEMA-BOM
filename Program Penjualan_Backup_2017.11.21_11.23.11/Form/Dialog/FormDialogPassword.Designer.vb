<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDialogPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDialogPassword))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.Tabel_user_via_set_authorityTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_user_via_set_authorityTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 81)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.RadDropDownList1.Location = New System.Drawing.Point(129, 12)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.NullText = "Masukkan Username"
        Me.RadDropDownList1.Size = New System.Drawing.Size(185, 20)
        Me.RadDropDownList1.TabIndex = 5
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Location = New System.Drawing.Point(129, 38)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.NullText = "Masukkan Password"
        Me.RadTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RadTextBox1.Size = New System.Drawing.Size(185, 20)
        Me.RadTextBox1.TabIndex = 6
        '
        'RadButton1
        '
        Me.RadButton1.Image = CType(resources.GetObject("RadButton1.Image"), System.Drawing.Image)
        Me.RadButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadButton1.Location = New System.Drawing.Point(235, 64)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(79, 29)
        Me.RadButton1.TabIndex = 7
        '
        'Tabel_user_via_set_authorityTableAdapter1
        '
        Me.Tabel_user_via_set_authorityTableAdapter1.ClearBeforeFill = True
        '
        'FormDialogPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 109)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadTextBox1)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDialogPassword"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDialogPassword"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Tabel_user_via_set_authorityTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_user_via_set_authorityTableAdapter
End Class

