Public Class FormDetailSupplier

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Property id As String

    Private Sub FormDetailSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DivKoefisien = DivCoef._1 Then
        '    RadGridView1.Columns(5).FormatString = "{0:N2}"
        'Else
        '    RadGridView1.Columns(5).FormatString = "{0:N0}"
        'End If
    End Sub

    Private Sub fill_tanggal(ByVal id As String)
        Dim mindate As String
        mindate = CStr(Me.Tabel_invoice_masukTableAdapter.ScalarQueryMinDate_by_ID(id))
        'Me.Awal_DateTimePicker.MaxDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        Me.Awal_DateTimePicker.MinDate = CDate(mindate)
        Me.Awal_DateTimePicker.Value = CDate(mindate)
        'Me.Akhir_DateTimePicker.MaxDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        Me.Akhir_DateTimePicker.MinDate = CDate(mindate)
        Me.Akhir_DateTimePicker.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Awal_DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Awal_DateTimePicker.ValueChanged, Akhir_DateTimePicker.ValueChanged
       Me.Tabel_invoice_masukTableAdapter.FillByID_and_Between_Date(Me.TokoDataSet.tabel_invoice_masuk, id, Awal_DateTimePicker.Value, Akhir_DateTimePicker.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'FormCetakDetailSupplier.nama = Label_Nama.Text
        'FormCetakDetailSupplier.id = id
        'FormCetakDetailSupplier.alamat = Label_Alamat.Text
        'FormCetakDetailSupplier.asal = Label_Kota.Text
        'FormCetakDetailSupplier.telp = Label_Telp.Text
        'FormCetakDetailSupplier.terdaftar = Label_terdaftar.Text
        'FormCetakDetailSupplier.awal = Awal_DateTimePicker.Value
        'FormCetakDetailSupplier.akhir = Akhir_DateTimePicker.Value
        'FormCetakDetailSupplier.ShowDialog()
        'FormCetakDetailSupplier.Dispose()
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 5 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub FormDetailSupplier_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_invoice_masuk' table. You can move, or remove it, as needed.
        Dim dt As DataTable = New DataTable()
        dt = Me.Tabel_supplierTableAdapter.GetData_based_id_supplier(id)
        Label_Nama.Text = dt.Rows(0).Item("nama").ToString
        Label_ID.Text = dt.Rows(0).Item("id_supplier").ToString
        fill_tanggal(id)
        Label_Alamat.Text = dt.Rows(0).Item("alamat").ToString
        Label_Kota.Text = dt.Rows(0).Item("asal").ToString
        Label_Telp.Text = dt.Rows(0).Item("telp").ToString
        Label_terdaftar.Text = CType(dt.Rows(0).Item("terdaftar_bln"), Date).ToShortDateString
        dt.Clear()
        dt = Me.Tabel_invoice_masukTableAdapter.GetDataByID_Supplier(Label_ID.Text)
        Me.Tabel_invoice_masukTableAdapter.FillByID_Supplier(Me.TokoDataSet.tabel_invoice_masuk, Label_ID.Text)
    End Sub
End Class