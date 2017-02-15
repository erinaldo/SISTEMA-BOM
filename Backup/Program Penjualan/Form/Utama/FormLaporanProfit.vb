Imports Telerik.WinControls.UI

Public Class FormLaporanProfit

    Private Sub FormLaporanLabaRugi_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ''Me.Tabel_laba_rugiTableAdapter.Fill(Me.TokoDataSet.tabel_laba_rugi)
        'For i = 5 To 9
        '    If DivKoefisien = DivCoef._1 Then
        '        RadGridView1.Columns(i).FormatString = "{0:N2}"
        '    Else
        '        RadGridView1.Columns(i).FormatString = "{0:N0}"
        '    End If
        'Next
    End Sub

    Private Sub inisiasi_tanggal_range()
        Dim mindate As String
        mindate = Me.Tabel_laba_rugiTableAdapter.ScalarQueryMinDate().ToString
        Me.awaldate_DateTimePicker.MinDate = CDate(mindate)
        'Me.awaldate_DateTimePicker.MaxDate = tgltoday
        Me.awaldate_DateTimePicker.Value = CDate(tgltoday)
        Me.akhirdate_DateTimePicker.MinDate = CDate(mindate)
        'Me.akhirdate_DateTimePicker.MaxDate = tgltoday
        Me.akhirdate_DateTimePicker.Value = CDate(tgltoday)
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 0 Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub inisiasi_customer()
        'Dim dt As DataTable
        'dt = Me.Tabel_customerTableAdapter.GetData()
        'Customer_Combobox.Items.Clear()
        'Customer_Combobox.Items.Add("< Semua >")
        'If dt.Rows.Count <> 0 Then
        '    For i As Integer = 0 To dt.Rows.Count - 1
        '        Customer_Combobox.Items.Add(dt.Rows(i).Item("nama").ToString)
        '    Next
        'End If
        'Customer_Combobox.SelectedIndex = 0
    End Sub

    Private Sub inisiai_sales()
        Using dt As DataTable = Me.Tabel_salesTableAdapter.GetData()
            Sales_Combobox.Items.Clear()
            Sales_Combobox.Items.Add("< Semua >")
            If dt.Rows.Count <> 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Sales_Combobox.Items.Add(dt.Rows(i).Item("nama").ToString)
                Next
            End If
            Sales_Combobox.SelectedIndex = 0
        End Using
    End Sub

    Private Sub FilterCari_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FilterCari_Button.Click
        cari()
    End Sub

    Private Sub cari()
        Dim idcustomer As String = Customer_Combobox.Text
        Dim tipe1 As String = RadCheckBox1.Text
        Dim tipe2 As String = RadCheckBox2.Text
        Dim tipe3 As String = RadCheckBox3.Text
        If idcustomer = "< Semua >" Then
            idcustomer = "%"
        End If
        Dim namasales As String = Sales_Combobox.SelectedItem.Text
        If namasales = "< Semua >" Then
            namasales = "%"
        End If
        If RadCheckBox1.Checked = False Then
            tipe1 = ""
        End If
        If RadCheckBox2.Checked = False Then
            tipe2 = ""
        End If
        If RadCheckBox3.Checked = False Then
            tipe3 = ""
        End If
        Me.Tabel_laba_rugiTableAdapter.FillByFilter(Me.TokoDataSet.tabel_laba_rugi, idcustomer, namasales, tipe1, tipe2, tipe3, CDate(awaldate_DateTimePicker.Value.ToShortDateString & " 00:00"), CDate(akhirdate_DateTimePicker.Value.ToShortDateString & " 23:59"))
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If SettingAuthority.Laporan.CetakLaporan = True Then
            Dim idcustomer As String = Customer_Combobox.Text
            Dim namacustomer As String
            Dim tipe1 As String = RadCheckBox1.Text
            Dim tipe2 As String = RadCheckBox2.Text
            Dim tipe3 As String = RadCheckBox3.Text
            If idcustomer = "< Semua >" Then
                idcustomer = "%"
                namacustomer = "%"
            Else
                namacustomer = CStr(Tabel_customerTableAdapter.ScalarQueryReturnNama(idcustomer))
            End If
            Dim namasales As String = Sales_Combobox.SelectedItem.Text
            If namasales = "< Semua >" Then
                namasales = "%"
            End If
            If RadCheckBox1.Checked = False Then
                tipe1 = ""
            End If
            If RadCheckBox2.Checked = False Then
                tipe2 = ""
            End If
            If RadCheckBox3.Checked = False Then
                tipe3 = ""
            End If
            Dim awal As Date = CDate(awaldate_DateTimePicker.Value.ToShortDateString)
            Dim akhir As Date = CDate(akhirdate_DateTimePicker.Value.ToShortDateString)
            Using CetakLaporanProfit As New FormCetakLaporanProfit
                CetakLaporanProfit.nama_customer = namacustomer
                CetakLaporanProfit.id_customer = idcustomer
                CetakLaporanProfit.nama_sales = namasales
                CetakLaporanProfit.tipe_penjualan1 = tipe1
                CetakLaporanProfit.tipe_penjualan2 = tipe2
                CetakLaporanProfit.tipe_penjualan3 = tipe3
                CetakLaporanProfit.awal = CStr(awal)
                CetakLaporanProfit.akhir = CStr(akhir)
                CetakLaporanProfit.ShowDialog()
                CetakLaporanProfit.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 4 Then
            e.CellElement.Text = e.CellElement.Text.Substring(0, 1)
        End If
        If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Dim loadcustomer As Boolean = False
    Private Sub Customer_Combobox_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Customer_Combobox.Enter
        If loadcustomer = False Then
            Customer_Combobox.MultiColumnComboBoxElement.Rows.Add("< Semua >")
            Using dt As DataTable = Me.Tabel_customerTableAdapter.GetDataB()
                For i = 0 To dt.Rows.Count - 1
                    Customer_Combobox.MultiColumnComboBoxElement.Rows.Add(dt.Rows(i).Item("id_customer"), dt.Rows(i).Item("nama"), dt.Rows(i).Item("asal"))
                Next
                Customer_Combobox.SelectedIndex = 0
            End Using
            loadcustomer = True
        End If
    End Sub

    Private Sub Customer_Combobox_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Customer_Combobox.Leave
        If Customer_Combobox.Text = "" Then
            Customer_Combobox.Text = "< Semua >"
        End If
    End Sub

    Private Sub FormLaporanLabaRugi_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        inisiasi_tanggal_range()
        'inisiasi_customer()
        inisiai_sales()
        Me.Customer_Combobox.EditorControl.MasterTemplate.FilterDescriptors.LogicalOperator = Telerik.WinControls.Data.FilterLogicalOperator.Or

        Me.RadGridView1.SummaryRowsBottom.Add(New GridViewSummaryRowItem(New GridViewSummaryItem() {New GridViewSummaryItem("belanja", "{0:N0}", GridAggregateFunction.Sum), New GridViewSummaryItem("profit", "{0:N0}", GridAggregateFunction.Sum), New GridViewSummaryItem("retur", "{0:N0}", GridAggregateFunction.Sum), New GridViewSummaryItem("rugi", "{0:N0}", GridAggregateFunction.Sum), New GridViewSummaryItem("laba_kotor", "{0:N0}", GridAggregateFunction.Sum)}))
        Me.RadGridView1.MasterTemplate.ShowTotals = True
        Me.RadGridView1.MasterView.SummaryRows(0).PinPosition = PinnedRowPosition.Bottom
        cari()
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridView1.CellClick
        If e.ColumnIndex = 1 And e.RowIndex >= 0 Then
            Dim rows As Integer = CInt(Me.Tabel_barang_keluarTableAdapter.ScalarQuery(CStr(e.Value)))

            If e.Value.ToString.StartsWith("PN") Then
                If Tabel_invoice_keluarTableAdapter1.CekIsSmallByInvoice(CStr(e.Value)) = 0 Then
                    Using CetakNotaPenjualan As New FormCetakNotaPenjualan
                        CetakNotaPenjualan.ExtraOrdinary = True
                        CetakNotaPenjualan.Text = "Nota Penjualan " & e.Value.ToString
                        CetakNotaPenjualan.invoice = CStr(e.Value)
                        CetakNotaPenjualan.banyak = BanyakBarisNota(rows)
                        CetakNotaPenjualan.Kota = KotaToko
                        CetakNotaPenjualan.ShowDialog()
                        CetakNotaPenjualan.Dispose()
                        CobaBersihkanMemori()
                    End Using
                Else
                    Using CetakNotaPenjualanSmall As New FormCetakNotaPenjualanSmall
                        CetakNotaPenjualanSmall.ExtraOrdinary = True
                        CetakNotaPenjualanSmall.Text = "Nota Penjualan " & e.Value.ToString
                        CetakNotaPenjualanSmall.invoice = CStr(e.Value)
                        CetakNotaPenjualanSmall.ShowDialog()
                        CetakNotaPenjualanSmall.Dispose()
                        CobaBersihkanMemori()
                    End Using
                End If
            Else
                Using CetakNotaOrder As New FormCetakNotaOrder
                    CetakNotaOrder.AutoPrint = False
                    CetakNotaOrder.Text = "Nota Order " & e.Value.ToString
                    CetakNotaOrder.invoice = CStr(e.Value)
                    CetakNotaOrder.banyak = BanyakBarisNota(rows) + 1
                    CetakNotaOrder.ShowDialog()
                    CetakNotaOrder.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
        ElseIf e.ColumnIndex = RadGridView1.Columns("retur").Index And e.RowIndex >= 0 Then
            Using FormCetakRetur As New FormCetakNotaRetur
                FormCetakRetur.Invoice = RadGridView1.Rows(e.RowIndex).Cells("invoice").Value
                FormCetakRetur.Text = "Form Retur"
                FormCetakRetur.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub RadGridView1_ViewCellFormatting(sender As Object, e As CellFormattingEventArgs) Handles RadGridView1.ViewCellFormatting
        If TypeOf e.CellElement Is Telerik.WinControls.UI.GridSummaryCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            e.CellElement.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
            If e.CellElement.Value <> "" Then
                e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
            End If
        End If
        'If TypeOf e.CellElement Is Telerik.WinControls.UI.GridCellElement And Not TypeOf e.CellElement Is Telerik.WinControls.UI.GridHeaderCellElement Then
        '    If e.ColumnIndex = RadGridView1.Columns("retur").Index And e.CellElement.Text <> "" Then
        '        e.CellElement.Text = FormatNumber(e.CellElement.Text, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        '    End If
        'End If
    End Sub
End Class