<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDialogLogin
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Catch ex As Exception

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDialogLogin))
        Me.Panel1 = New Telerik.WinControls.UI.RadPanel()
        Me.TextBox_Password = New Telerik.WinControls.UI.RadTextBox()
        Me.TextBox_Username = New Telerik.WinControls.UI.RadDropDownList()
        Me.MetroButton2 = New Telerik.WinControls.UI.RadButton()
        Me.MetroButton1 = New Telerik.WinControls.UI.RadButton()
        Me.MetroLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.label_username = New Telerik.WinControls.UI.RadLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TokoDataSet = New Program_Penjualan_V2.tokoDataSet()
        Me.Tabel_userTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_userTableAdapter()
        Me.tabel_log = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_logTableAdapter()
        Me.Tabel_customerTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerTableAdapter()
        Me.Tabel_salesTableAdapter1 = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_salesTableAdapter()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TextBox_Password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox_Username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.label_username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox_Password)
        Me.Panel1.Controls.Add(Me.TextBox_Username)
        Me.Panel1.Controls.Add(Me.MetroButton2)
        Me.Panel1.Controls.Add(Me.MetroButton1)
        Me.Panel1.Controls.Add(Me.MetroLabel2)
        Me.Panel1.Controls.Add(Me.label_username)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(414, 146)
        Me.Panel1.TabIndex = 0
        '
        'TextBox_Password
        '
        Me.TextBox_Password.Location = New System.Drawing.Point(193, 52)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.NullText = "Masukkan Password"
        Me.TextBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TextBox_Password.Size = New System.Drawing.Size(198, 20)
        Me.TextBox_Password.TabIndex = 2
        '
        'TextBox_Username
        '
        Me.TextBox_Username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBox_Username.Location = New System.Drawing.Point(193, 22)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.NullText = "Masukkan Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(198, 20)
        Me.TextBox_Username.TabIndex = 1
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(316, 85)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 36)
        Me.MetroButton2.TabIndex = 21
        Me.MetroButton2.Text = "Batal"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(235, 85)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 36)
        Me.MetroButton1.TabIndex = 20
        Me.MetroButton1.Text = "OK"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Location = New System.Drawing.Point(119, 57)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(53, 18)
        Me.MetroLabel2.TabIndex = 19
        Me.MetroLabel2.Text = "Password"
        '
        'label_username
        '
        Me.label_username.Location = New System.Drawing.Point(119, 22)
        Me.label_username.Name = "label_username"
        Me.label_username.Size = New System.Drawing.Size(56, 18)
        Me.label_username.TabIndex = 18
        Me.label_username.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(22, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 88)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'TokoDataSet
        '
        Me.TokoDataSet.DataSetName = "tokoDataSet"
        Me.TokoDataSet.EnforceConstraints = False
        Me.TokoDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.TokoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabel_userTableAdapter
        '
        Me.Tabel_userTableAdapter.ClearBeforeFill = True
        '
        'tabel_log
        '
        Me.tabel_log.ClearBeforeFill = True
        '
        'Tabel_customerTableAdapter
        '
        Me.Tabel_customerTableAdapter.ClearBeforeFill = True
        '
        'Tabel_salesTableAdapter1
        '
        Me.Tabel_salesTableAdapter1.ClearBeforeFill = True
        '
        'FormDialogLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 146)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDialogLogin"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Silahkan login terlebih dahulu"
        Me.ThemeName = "TelerikMetroBlue"
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TextBox_Password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox_Username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.label_username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Telerik.WinControls.UI.RadPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Tabel_userTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_userTableAdapter
    Friend WithEvents TokoDataSet As Program_Penjualan_V2.tokoDataSet
    Friend WithEvents MetroLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents label_username As Telerik.WinControls.UI.RadLabel
    Friend WithEvents MetroButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents MetroButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TextBox_Password As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TextBox_Username As Telerik.WinControls.UI.RadDropDownList
    Friend tabel_log As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_logTableAdapter
    Friend WithEvents Tabel_customerTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_customerTableAdapter
    Friend WithEvents Tabel_salesTableAdapter1 As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_salesTableAdapter
End Class
