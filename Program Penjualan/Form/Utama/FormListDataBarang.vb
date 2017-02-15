Public Class FormListDataBarang
    Dim new_value As String = ""
    Dim old_value As String = ""

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormListDataBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_barang' table. You can move, or remove it, as needed.
        'Me.Tabel_barangTableAdapter.Fill(Me.TokoDataSet.tabel_barang)
        If SettingAuthority.Product.LihatProfit = False Then
            RadGridView1.Columns(11).IsVisible = False
        End If
        If SettingAuthority.Product.LihatTotalPersediaan = False Then
            TableLayoutPanel1.Visible = False
        End If
        If SettingAuthority.Product.EditModalTerjualProfit = True Then
            RadGridView1.Columns(5).ReadOnly = False
            RadGridView1.Columns(10).ReadOnly = False
            RadGridView1.Columns(11).ReadOnly = False
        End If
    End Sub


    Private Sub fill_tipe_combobox()
        Using dt As DataTable = Tabel_tipe_barangTableAdapter.GetData()
            Tipe_ComboBox.Items.Add("< Semua >")
            For i = 0 To dt.Rows.Count - 1
                Tipe_ComboBox.Items.Add(dt.Rows(i).Item("tipe").ToString)
            Next
            If Tipe_ComboBox.Items.Count <> 0 Then
                Tipe_ComboBox.SelectedIndex = Tipe_ComboBox.Items(0).RowIndex
            End If
        End Using
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 0 Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cari()
    End Sub

    Private Sub cari()
        Dim tipe As String = Tipe_ComboBox.SelectedItem.Text
        If tipe = "< Semua >" Then
            tipe = "%"
        End If
        Me.Tabel_barangTableAdapter.FillByFilter_Tipe(Me.TokoDataSet.tabel_barang, tipe, "%" & RadTextBox1.Text & "%")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SettingAuthority.Product.PrintDataProduk = True Then
            Dim tipe_barang As String = Tipe_ComboBox.SelectedItem.Text
            If tipe_barang = "< Semua >" Then
                tipe_barang = "%"
            End If
            Using CetakListDataProduk As New FormCetakListDataProduk
                CetakListDataProduk.tipe_barang = tipe_barang
                CetakListDataProduk.idnama = "%" & RadTextBox1.Text & "%"
                CetakListDataProduk.ShowDialog()
                CetakListDataProduk.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub MasterTemplate_KeyDown(sender As Object, e As KeyEventArgs) Handles RadGridView1.KeyDown
        If RadGridView1.RowCount <> 0 Then
            If SettingAuthority.Product.EditDataProduk = True Then
                If e.KeyCode = Keys.Delete Then
                    If RadGridView1.CurrentRow.Cells("stok_barang").Value.ToString = "0" Then
                        If Telerik.WinControls.RadMessageBox.Show("Menghapus data pada tabel ini akan menghapus seluruh data yang berhubungan dengan data ini." & "Apakah Anda yakin ingin menghapus produk dengan ID " & RadGridView1.CurrentRow.Cells("kode_barang").Value.ToString & " " & RadGridView1.CurrentRow.Cells("nama_barang").Value.ToString & " ? ", "Peringantan Konfirmasi Hapus Produk", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                            Me.Tabel_barangTableAdapter.DeleteQuerySpecial(CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                            RadGridView1.CurrentRow.Delete()
                            'cari()
                        End If
                    End If
                End If
                If e.KeyCode = Keys.F5 Then
                    If RadGridView1.CurrentCell.ColumnIndex = 2 Or RadGridView1.CurrentCell.ColumnIndex = 4 Or (RadGridView1.CurrentCell.ColumnIndex >= 6 And RadGridView1.CurrentCell.ColumnIndex <= 7) Or RadGridView1.CurrentCell.ColumnIndex = 12 Then
                        RadGridView1.BeginEdit()
                    End If
                End If
            End If
            If SettingAuthority.Product.EditModalTerjualProfit = True Then
                If RadGridView1.CurrentCell.ColumnIndex = 5 Or RadGridView1.CurrentCell.ColumnIndex = 10 Or RadGridView1.CurrentCell.ColumnIndex = 11 Then
                    RadGridView1.BeginEdit()
                End If
            End If
        End If
    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        If RadGridView1.Rows.Count <> 0 Then
            If SettingAuthority.Product.EditDataProduk = True Then
                If e.ColumnIndex = 2 Or e.ColumnIndex = 4 Or (e.ColumnIndex >= 6 And e.ColumnIndex <= 7) Or e.ColumnIndex = 12 Then
                    RadGridView1.BeginEdit()
                End If
            End If
            If SettingAuthority.Product.EditModalTerjualProfit = True Then
                If e.ColumnIndex = 5 Or e.ColumnIndex = 10 Or e.ColumnIndex = 11 Then
                    RadGridView1.BeginEdit()
                End If
            End If
        End If
    End Sub

    Dim stok_total As Double = 0
    Dim grosir_total As Double = 0
    Dim retail_total As Double = 0
    Private Sub RadGridView1_RowsChanged(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles RadGridView1.RowsChanged
        stok_total = 0
        grosir_total = 0
        retail_total = 0
        For i = 0 To RadGridView1.Rows.Count - 1
            stok_total += CDbl(RadGridView1.Rows(i).Cells("stok_barang").Value) * CDbl(RadGridView1.Rows(i).Cells("harga_modal").Value)
            grosir_total += CDbl(RadGridView1.Rows(i).Cells("stok_barang").Value) * CDbl(RadGridView1.Rows(i).Cells("harga_grosir").Value)
            retail_total += CDbl(RadGridView1.Rows(i).Cells("stok_barang").Value) * CDbl(RadGridView1.Rows(i).Cells("harga_retail").Value)
        Next
        RadLabel3.Text = "Rp  " & ubahtocurrencybyDiv(CStr(stok_total))
        RadLabel7.Text = "Rp  " & ubahtocurrencybyDiv(CStr(grosir_total))
        RadLabel8.Text = "Rp  " & ubahtocurrencybyDiv(CStr(retail_total))
    End Sub

    Private Sub FormListDataBarang_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        fill_tipe_combobox()
        RadTextBox1.Focus()
    End Sub

    Private Sub RadGridView1_SortChanged(sender As Object, e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles RadGridView1.SortChanged
        If RadGridView1.Rows.Count > 0 Then
            For i = 0 To RadGridView1.Rows.Count - 1
                RadGridView1.MasterView.Rows(i).Cells("no").Value = i + 1
            Next
        End If
    End Sub

    Private Sub RadGridView1_ContextMenuOpening(sender As Object, e As Telerik.WinControls.UI.ContextMenuOpeningEventArgs) Handles RadGridView1.ContextMenuOpening
        If RadGridView1.CurrentCell.ColumnIndex = 2 Or RadGridView1.CurrentCell.ColumnIndex = 4 Or RadGridView1.CurrentCell.ColumnIndex = 6 Or RadGridView1.CurrentCell.ColumnIndex = 7 Then
            e.ContextMenu.Items(1).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.CellElement.ColumnInfo.Name = "no" Then
            e.CellElement.Text = (e.CellElement.RowIndex + 1).ToString()
        End If
        If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 10 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub RadGridView1_CellBeginEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellCancelEventArgs) Handles RadGridView1.CellBeginEdit
        If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 10 Then
            If DivKoefisien = DivCoef._1 Then
                RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl((RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) / 1000
            End If
        End If

        old_value = CStr(RadGridView1.CurrentCell.Value)
    End Sub

    Private Sub RadGridView1_CellEndEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellEndEdit
        Me.new_value = CStr(RadGridView1.CurrentCell.Value)

        If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 10 Then
            If DivKoefisien = DivCoef._1 Then
                RadGridView1.CurrentCell.Value = CDbl((RadGridView1.CurrentCell.Value)) * 1000
            End If
        End If

        If Me.new_value <> Me.old_value Then
            If Telerik.WinControls.RadMessageBox.Show("Apakah Anda ingin mengubah data dari " & Me.old_value & " menjadi " & Me.new_value & " ?", "Konfirmasi Perubahan Data", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Select Case e.ColumnIndex
                    Case 2
                        Try
                            Me.Tabel_barangTableAdapter.UpdateQueryNamaBarang(Me.new_value, CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 4
                        Try
                            Me.Tabel_barangTableAdapter.UpdateQueryStok2(CInt(Me.new_value), CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 5
                        Try
                            Me.Tabel_barangTableAdapter.UpdateQueryHargaModal(CInt(Me.new_value), CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 6
                        Try
                            Me.Tabel_barangTableAdapter.UpdateQueryHargaGrosir(CInt(Me.new_value), CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 7
                        Try
                            Me.Tabel_barangTableAdapter.UpdateQueryHargaRetail(CInt(Me.new_value), CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 10
                        Try
                            Me.Tabel_barangTableAdapter.UpdateQueryTerjual(CInt(Me.new_value), CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 11
                        Try
                            Me.Tabel_barangTableAdapter.UpdateQueryProfit(Me.new_value, CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 12
                        Try
                            Me.Tabel_barangTableAdapter.UpdateQueryKeterangan(Me.new_value, CStr(RadGridView1.CurrentRow.Cells("kode_barang").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                End Select
            Else
                RadGridView1.CurrentCell.Value = old_value
            End If
        End If
    End Sub

    Private Sub RadGridView1_CellEditorInitialized(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellEditorInitialized
        Dim spineditor As Telerik.WinControls.UI.GridSpinEditor = TryCast(Me.RadGridView1.ActiveEditor, Telerik.WinControls.UI.GridSpinEditor)
        If spineditor IsNot Nothing Then
            If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 10 Then
                spineditor.DecimalPlaces = Desimal()
            End If
        End If
    End Sub
End Class