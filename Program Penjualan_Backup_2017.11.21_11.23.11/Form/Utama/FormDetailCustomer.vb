Public Class FormDetailCustomer

    Shared Property id As String

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub fill_date_combo()
        Dim mindate As String
        mindate = Me.Tabel_invoice_keluarTableAdapter.ScalarQueryMinDate_by_IDCustomer(id).ToString + ""
        If mindate <> "" Then
            Me.Awal_DateTimePicker.MinDate = CDate(mindate)
            Me.Akhir_DateTimePicker.MinDate = CDate(mindate)
            'Me.Awal_DateTimePicker.MaxDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
            'Me.Akhir_DateTimePicker.MaxDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
            Me.Awal_DateTimePicker.Value = CDate(mindate)
            Me.Akhir_DateTimePicker.Value = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        Else
            Me.Awal_DateTimePicker.MinDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
            Me.Akhir_DateTimePicker.MinDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
            Me.Awal_DateTimePicker.MaxDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
            Me.Akhir_DateTimePicker.MaxDate = New Date(Date.Now.Year, Date.Now.Month, Date.Now.Day)
        End If
    End Sub

    Private Sub fill_other_details()
        Dim dt As DataTable = New DataTable()
        dt = Me.Tabel_customerTableAdapter.GetData_based_id_customer(id)
        Label_Nama.Text = dt.Rows(0).Item("nama").ToString
        Label_ID.Text = dt.Rows(0).Item("id_customer").ToString
        Label_Alamat.Text = dt.Rows(0).Item("alamat").ToString
        Label_hutang.Text = dt.Rows(0).Item("hutang_lama").ToString
        Label_Kota.Text = dt.Rows(0).Item("asal").ToString
        Label_Telp.Text = dt.Rows(0).Item("telp").ToString
        Label_terdaftar.Text = CType(dt.Rows(0).Item("terdaftar_bln"), Date).ToShortDateString
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 0 Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Awal_DateTimePicker_ValueChanged(sender As Object, e As EventArgs)
        Me.Tabel_invoice_keluarTableAdapter.FillByIDCustomer_and_Tgl(Me.TokoDataSet.tabel_invoice_keluar, Label_ID.Text, Awal_DateTimePicker.Value, Akhir_DateTimePicker.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'FormCetakDetailCustomer.id = Label_ID.Text
        'FormCetakDetailCustomer.nama = Label_Nama.Text
        'FormCetakDetailCustomer.alamat = Label_Alamat.Text
        'FormCetakDetailCustomer.asal = Label_Kota.Text
        'FormCetakDetailCustomer.telp = Label_Telp.Text
        'FormCetakDetailCustomer.terdaftar_tgl = Label_terdaftar.Text
        'FormCetakDetailCustomer.hutang = Label_hutang.Text
        'FormCetakDetailCustomer.awal = Awal_DateTimePicker.Value
        'FormCetakDetailCustomer.akhir = Akhir_DateTimePicker.Value
        'FormCetakDetailCustomer.ShowDialog()
        'FormCetakDetailCustomer.Dispose()
    End Sub

    
    Private Sub FormDetailCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_invoice_keluar' table. You can move, or remove it, as needed.
        'Me.Tabel_invoice_keluarTableAdapter.Fill(Me.TokoDataSet.tabel_invoice_keluar)
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_invoice_keluar' table. You can move, or remove it, as needed.
        fill_other_details()
        fill_date_combo()
      
        Me.Tabel_invoice_keluarTableAdapter.FillByID_Customer(Me.TokoDataSet.tabel_invoice_keluar, Label_ID.Text)
    End Sub

    Private Sub FormDetailCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DivKoefisien = DivCoef._1 Then
        '    For i = 6 To 14
        '        If i = 6 Or i = 8 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Then
        '            RadGridView1.Columns(i).FormatString = "{0:N2}"
        '        End If
        '    Next
        'Else
        '    For i = 6 To 14
        '        If i = 6 Or i = 8 Or i = 10 Or i = 11 Or i = 12 Or i = 13 Or i = 14 Then
        '            RadGridView1.Columns(i).FormatString = "{0:N0}"
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 6 Or e.ColumnIndex = 8 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Or e.ColumnIndex = 13 Or e.ColumnIndex = 14 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub
End Class