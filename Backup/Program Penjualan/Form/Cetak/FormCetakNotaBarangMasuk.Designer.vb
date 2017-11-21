<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakNotaBarangMasuk
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
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Me.ReportNotaMasuk1 = New Program_Penjualan_V2.ReportNotaMasuk()
        Me.tabel_nota_masukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TokoDataSet = New Program_Penjualan_V2.tokoDataSet()
        Me.TabelnotamasukBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabel_nota_masukTableAdapter = New Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_nota_masukTableAdapter()
        Me.TabelnotamasukBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        CType(Me.ReportNotaMasuk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabel_nota_masukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelnotamasukBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabelnotamasukBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportNotaMasuk1
        '
        Me.ReportNotaMasuk1.Name = "ReportUjiCoba"
        '
        'tabel_nota_masukBindingSource
        '
        Me.tabel_nota_masukBindingSource.DataMember = "tabel_nota_masuk"
        Me.tabel_nota_masukBindingSource.DataSource = Me.TokoDataSet
        '
        'TokoDataSet
        '
        Me.TokoDataSet.DataSetName = "tokoDataSet"
        Me.TokoDataSet.EnforceConstraints = False
        Me.TokoDataSet.Locale = New System.Globalization.CultureInfo("en-US")
        Me.TokoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'TabelnotamasukBindingSource
        '
        Me.TabelnotamasukBindingSource.DataMember = "tabel_nota_masuk"
        Me.TabelnotamasukBindingSource.DataSource = Me.TokoDataSet
        '
        'Tabel_nota_masukTableAdapter
        '
        Me.Tabel_nota_masukTableAdapter.ClearBeforeFill = True
        '
        'TabelnotamasukBindingSource1
        '
        Me.TabelnotamasukBindingSource1.DataMember = "tabel_nota_masuk"
        Me.TabelnotamasukBindingSource1.DataSource = Me.TokoDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        InstanceReportSource1.ReportDocument = Me.ReportNotaMasuk1
        Me.ReportViewer1.ReportSource = InstanceReportSource1
        Me.ReportViewer1.Size = New System.Drawing.Size(748, 427)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
        '
        'FormCetakNotaBarangMasuk
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(748, 427)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormCetakNotaBarangMasuk"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Nota Barang Masuk"
        CType(Me.ReportNotaMasuk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabel_nota_masukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelnotamasukBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabelnotamasukBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TokoDataSet As Program_Penjualan_V2.tokoDataSet
    Friend WithEvents TabelnotamasukBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabel_nota_masukTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_nota_masukTableAdapter
    Friend WithEvents tabel_nota_masukBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabelnotamasukBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents ReportNotaMasuk1 As Program_Penjualan_V2.ReportNotaMasuk
End Class
