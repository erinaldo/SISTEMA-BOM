Imports Program_Penjualan_V2.UC_BarangMasuk

Public Class FormReturPenjualan

    Property total_subtotal As Double = 0
    Property stok_retur As Double = 0
    Property st_penjualan As UC_Penjualan.TipePenjualan
    Property status As String
    Private db_h_grosir As Integer = 0
    Private db_h_retail As Integer = 0
    Private db_h_modal As Integer = 0
    Dim F6_F7 As Boolean = False

    Property Invoice As String

    Property ID_Customer As String

    Property Nama_Customer As String

    Property Sales As String

    Private Sub ID_Barang_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ID_Barang_TextBox.KeyDown
        If e.KeyCode = Keys.F2 Then
            Using DialogCariBarangPenjualan As New FormDialogCariBarangPenjualan
                DialogCariBarangPenjualan.status = status
                If DialogCariBarangPenjualan.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ID_Barang_TextBox.Text = DialogCariBarangPenjualan.id_barang
                End If
                DialogCariBarangPenjualan.Dispose()
            End Using
            CobaBersihkanMemori()
        ElseIf e.KeyCode = Keys.F6 Then
            If RadGridView1.Rows.Count <> 0 Then
                RadGridView1.CurrentRow = RadGridView1.Rows(RadGridView1.Rows.Count - 1)
                RadGridView1.CurrentColumn = RadGridView1.Columns(3)
                F6_F7 = True
                RadGridView1.BeginEdit()
            End If
        ElseIf e.KeyCode = Keys.F7 Then
            If RadGridView1.Rows.Count <> 0 Then
                RadGridView1.CurrentRow = RadGridView1.Rows(RadGridView1.Rows.Count - 1)
                RadGridView1.CurrentColumn = RadGridView1.Columns(4)
                F6_F7 = True
                RadGridView1.BeginEdit()
            End If
        End If
    End Sub

    Private Function cek_di_table(ByVal cek As String) As String
        If RadGridView1.Rows.Count <> 0 Then
            For i = 0 To RadGridView1.Rows.Count - 1
                If RadGridView1.Rows(i).Cells("id_barang").Value.ToString = cek Then
                    Return CStr(i)
                End If
            Next
        End If
        Return "nothing"
    End Function

    Private Sub add_to_table()
        Dim cek As String = ""
        cek = cek_di_table(ID_Barang_TextBox.Text)
        If cek = "nothing" Then
            RadGridView1.Rows.Add("", _
                                      ID_Barang_TextBox.Text, _
                                      NamaBarang_TextBox.Text, _
                                      CDbl(Qty_TextBox.Text), _
                                      CDbl(HargaJual_TextBox.Text), _
                                      CDbl(Subtotal_TextBox.Text), _
                                      CDbl((0 - CDbl(Qty_TextBox.Text) * (CDbl(HargaJual_TextBox.Text) - db_h_modal))), _
                                      CDbl(db_h_modal), _
                                      db_h_retail, _
                                      db_h_grosir)
            RadLabelNo.Text = "No. " & RadGridView1.Rows.Count
            RadLabelKodeBarang.Text = ID_Barang_TextBox.Text
            RadLabelNamaBarang.Text = NamaBarang_TextBox.Text
            RadLabelQty.Text = CDbl(Qty_TextBox.Text)
            RadLabelX.Text = "X"
            RadLabelHargaJual.Text = ubahtocurrencybyDiv(HargaJual_TextBox.Text)
        Else
            RadGridView1.Rows(CInt(cek)).Cells("qty").Value = CInt(RadGridView1.Rows(CInt(cek)).Cells("qty").Value) + CInt(Qty_TextBox.Text)
            RadGridView1.Rows(CInt(cek)).Cells("subtotal").Value = CInt(RadGridView1.Rows(CInt(cek)).Cells("qty").Value) * CInt(RadGridView1.Rows(CInt(cek)).Cells("harga_jual").Value)
            RadGridView1.Rows(CInt(cek)).Cells("labarugi").Value = CInt(RadGridView1.Rows(CInt(cek)).Cells("qty").Value) * (CInt(RadGridView1.Rows(CInt(cek)).Cells("harga_modal").Value) - CInt(RadGridView1.Rows(CInt(cek)).Cells("harga_jual").Value))

            RadLabelNo.Text = "No. " & cek + 1
            RadLabelKodeBarang.Text = RadGridView1.Rows(CInt(cek)).Cells("id_barang").Value
            RadLabelNamaBarang.Text = RadGridView1.Rows(CInt(cek)).Cells("nama_barang").Value
            RadLabelQty.Text = RadGridView1.Rows(CInt(cek)).Cells("qty").Value
            RadLabelX.Text = "X"
            RadLabelHargaJual.Text = ubahtocurrencybyDiv(RadGridView1.Rows(CInt(cek)).Cells("harga_jual").Value)
        End If
        ID_Barang_TextBox.Text = "   -      "
        HargaJual_TextBox.Text = CStr(0)
        Qty_TextBox.Text = CStr(1)
        Button1.Enabled = False
        ID_Barang_TextBox.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        add_to_table()
        hitung_total()
    End Sub

    Private Sub ID_Barang_TextBox_TextChanged(sender As Object, e As EventArgs) Handles ID_Barang_TextBox.TextChanged
        Using dt As DataTable = Me.Tabel_barangTableAdapter.GetDataByKodeBarang(ID_Barang_TextBox.Text)
            If dt.Rows.Count <> 0 Then
                NamaBarang_TextBox.Text = CStr(dt.Rows(0).Item("nama_barang"))
                db_h_modal = CInt(dt.Rows(0).Item("harga_modal"))
                If status = "(G)" Then
                    db_h_retail = CInt(dt.Rows(0).Item("harga_retail"))
                    db_h_grosir = CInt(dt.Rows(0).Item("harga_grosir"))
                    If st_penjualan <> UC_Penjualan.TipePenjualan.Order Then
                        HargaJual_TextBox.Text = ubahtocurrency(CStr(db_h_grosir))
                    Else
                        HargaJual_TextBox.Text = ubahtocurrency(CStr(db_h_modal))
                    End If
                    HargaJual_TextBox.Enabled = False
                Else
                    db_h_retail = CInt(dt.Rows(0).Item("harga_retail"))
                    db_h_grosir = CInt(dt.Rows(0).Item("harga_grosir"))
                    If st_penjualan <> UC_Penjualan.TipePenjualan.Order Then
                        HargaJual_TextBox.Text = ubahtocurrency(CStr(db_h_retail))
                    Else
                        HargaJual_TextBox.Text = ubahtocurrency(CStr(db_h_modal))
                    End If
                    HargaJual_TextBox.Enabled = True
                End If
                Button1.Enabled = True

                Qty_TextBox.Enabled = True
                If HargaJual_TextBox.Enabled = False Then
                    Qty_TextBox.Focus()
                Else
                    HargaJual_TextBox.Focus()
                End If
            Else
                Button1.Enabled = False
                db_h_grosir = 0
                db_h_retail = 0
                db_h_modal = 0
                NamaBarang_TextBox.Text = ""
                HargaJual_TextBox.Text = "0"
                Qty_TextBox.Text = "1"
                HargaJual_TextBox.Enabled = False
                Qty_TextBox.Enabled = False
            End If
        End Using
    End Sub

    Private Sub HargaJual_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Qty_TextBox.KeyPress, HargaJual_TextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Qty_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Qty_TextBox.TextChanged
        If Qty_TextBox.Text = "" Then
            Qty_TextBox.Text = "0"
        End If
        hitung_sub_total()
    End Sub

    Private Sub HargaJual_TextBox_TextChanged(sender As Object, e As EventArgs) Handles HargaJual_TextBox.TextChanged
        If HargaJual_TextBox.Text = "" Then
            HargaJual_TextBox.Text = "0"
        End If
        hitung_sub_total()
    End Sub

    Private Sub hitung_sub_total()
        Dim qty As Double = 0
        Dim harga As Double = 0
        If Qty_TextBox.Text <> "" Then
            qty = CType(Qty_TextBox.Text, Double)
        End If
        If HargaJual_TextBox.Text <> "" Then
            harga = CType(HargaJual_TextBox.Text, Double)
        End If
        Subtotal_TextBox.Text = ubahtocurrency((qty * harga).ToString)
    End Sub

    Private Sub FormReturPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshRecent()
        Me.HargaJual_TextBox.Text = CStr(0)
        Me.Qty_TextBox.Text = CStr(1)
        If status = "(G)" Then
            HargaJual_TextBox.Enabled = False
        Else
            RadGridView1.Columns("harga_jual").ReadOnly = False
        End If
        If st_penjualan = UC_Penjualan.TipePenjualan.BigNota Or st_penjualan = UC_Penjualan.TipePenjualan.SmallNota Then
            Panel3.Visible = False
            If st_penjualan = UC_Penjualan.TipePenjualan.Order Then
                RadGridView1.Columns("harga_jual").ReadOnly = True
            End If
        Else
            Panel3.Visible = False
        End If
        F6_F7 = False
        Me.ID_Barang_TextBox.Text = ""
        Me.ID_Barang_TextBox.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub hitung_total()
        total_subtotal = 0
        stok_retur = 0
        For i = 0 To RadGridView1.RowCount - 1
            total_subtotal = total_subtotal + CType(RadGridView1.Rows(i).Cells(5).Value, Double)
            stok_retur = stok_retur + CType(RadGridView1.Rows(i).Cells("qty").Value, Double)
        Next
    End Sub

    Private Sub HargaJual_TextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles HargaJual_TextBox.KeyUp
        If Char.IsNumber(ChrW(e.KeyValue)) = True Or e.KeyCode = Keys.Back Then
            If HargaJual_TextBox.Text <> "" Then
                HargaJual_TextBox.Text = HargaJual_TextBox.Text.Replace(".", "")
                HargaJual_TextBox.Text = FormatNumber(HargaJual_TextBox.Text, 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
                HargaJual_TextBox.Select(HargaJual_TextBox.Text.Length, 0)
            End If
        End If
    End Sub

    Private Sub RadGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles RadGridView1.KeyDown
        If RadGridView1.Rows.Count <> 0 Then
            If e.KeyCode = Keys.F5 Then
                If RadGridView1.CurrentCell.ColumnIndex = 3 Then
                    RadGridView1.BeginEdit()
                ElseIf RadGridView1.CurrentCell.ColumnIndex = 4 And st_penjualan <> UC_Penjualan.TipePenjualan.Order Then
                    RadGridView1.BeginEdit()
                End If
            ElseIf e.KeyCode = Keys.Delete Then
                If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yaking ingin menghapus data ini ?", RadGridView1.CurrentRow.Cells("id_barang").Value.ToString, MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    RadGridView1.Rows.RemoveAt(RadGridView1.CurrentCell.RowIndex)
                End If
            ElseIf e.KeyCode = Keys.F6 Then
                RadGridView1.CurrentRow = RadGridView1.Rows(RadGridView1.Rows.Count - 1)
                RadGridView1.CurrentColumn = RadGridView1.Columns(3)
                RadGridView1.BeginEdit()
            ElseIf e.KeyCode = Keys.F7 Then
                If st_penjualan <> UC_Penjualan.TipePenjualan.Order Then
                    RadGridView1.CurrentRow = RadGridView1.Rows(RadGridView1.Rows.Count - 1)
                    RadGridView1.CurrentColumn = RadGridView1.Columns(4)
                    RadGridView1.BeginEdit()
                End If
            End If
        End If
    End Sub

    Private Sub FormReturPenjualan_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Hjual_Enter = False Then
                If Button1.Enabled = True Then
                    add_to_table()
                    hitung_total()
                End If
            End If
        End If
    End Sub

    Private Sub HargaJual_TextBox_Leave(sender As Object, e As EventArgs) Handles HargaJual_TextBox.Leave
        If status = "(R)" Then
            If CInt(HargaJual_TextBox.Text) > db_h_retail Then
                Telerik.WinControls.RadMessageBox.Show("Tidak boleh lebih besar harga retail. Harga maksimum yang diperbolehkan adalah Rp " & ubahtocurrencybyDiv(CStr(db_h_retail)), "Harga Jual", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                HargaJual_TextBox.Text = ubahtocurrency(CStr(db_h_retail))
                HargaJual_TextBox.Focus()
            ElseIf CInt(HargaJual_TextBox.Text) < db_h_grosir Then
                Telerik.WinControls.RadMessageBox.Show("Tidak boleh lebih kecil harga grosir. Harga minimum yang diperbolehkan adalah Rp " & ubahtocurrencybyDiv(CStr(db_h_grosir)), "Harga Jual", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                HargaJual_TextBox.Text = ubahtocurrency(CStr(db_h_retail))
                HargaJual_TextBox.Focus()
            End If
        End If
        Hjual_Enter = False
    End Sub


    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        If e.ColumnIndex = 3 Then
            RadGridView1.BeginEdit()
        ElseIf e.ColumnIndex = 4 And st_penjualan <> UC_Penjualan.TipePenjualan.Order Then
            RadGridView1.BeginEdit()
        End If
    End Sub

    Private Sub RadGridView1_RowsChanged(sender As Object, e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles RadGridView1.RowsChanged
        hitung_total()
    End Sub

    Dim temp_grid_cell As Integer = 0
    Private Sub RadGridView1_CellEndEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellEndEdit
        If e.ColumnIndex >= 4 And e.ColumnIndex <= 9 Then
            RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl((RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) * 1000
        End If

        If CInt(RadGridView1.Rows(e.RowIndex).Cells("qty").Value) = 0 Then
            If Telerik.WinControls.RadMessageBox.Show("Apakah Anda yakin ingin menghapus list ini?", "Konfirmasi", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                RadGridView1.Rows.RemoveAt(RadGridView1.CurrentCell.RowIndex)
            Else
                RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp_grid_cell
            End If
        End If
        If status = "(R)" And e.ColumnIndex = RadGridView1.Columns("harga_jual").Index Then
            If CInt(e.Value) > CInt(RadGridView1.Rows(e.RowIndex).Cells("colum_db_hretail").Value) Then
                Telerik.WinControls.RadMessageBox.Show("Tidak boleh lebih besar harga retail. Harga maksimum yang diperbolehkan adalah Rp " & ubahtocurrencybyDiv(CStr(RadGridView1.Rows(e.RowIndex).Cells("colum_db_hretail").Value)), "Harga Jual", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp_grid_cell
            ElseIf CInt(e.Value) < CInt(RadGridView1.Rows(e.RowIndex).Cells("colum_db_hgrosir").Value) Then
                Telerik.WinControls.RadMessageBox.Show("Tidak boleh lebih kecil harga grosir. Harga minimum yang diperbolehkan adalah Rp " & ubahtocurrencybyDiv(CStr(RadGridView1.Rows(e.RowIndex).Cells("colum_db_hgrosir").Value)), "Harga Jual", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = temp_grid_cell
            End If
        End If
        If RadGridView1.RowCount <> 0 And e.Value IsNot Nothing Then
            RadGridView1.Rows(e.RowIndex).Cells("subtotal").Value = CInt(RadGridView1.Rows(e.RowIndex).Cells("qty").Value) * CInt(RadGridView1.Rows(e.RowIndex).Cells("harga_jual").Value)
            RadGridView1.Rows(e.RowIndex).Cells("labarugi").Value = CInt(RadGridView1.Rows(e.RowIndex).Cells("qty").Value) * (CInt(RadGridView1.Rows(e.RowIndex).Cells("harga_modal").Value) - CInt(RadGridView1.Rows(e.RowIndex).Cells("harga_jual").Value))
        End If
        If F6_F7 = True Then
            ID_Barang_TextBox.Focus()
        End If
        hitung_total()
        temp_grid_cell = 0
        F6_F7 = False
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex >= 4 And e.ColumnIndex <= 9 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Dim Hjual_Enter As Boolean = False
    Private Sub HargaJual_TextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HargaJual_TextBox.Enter
        Hjual_Enter = True
    End Sub

    Private Sub MasterTemplate_CellBeginEdit(ByVal sender As System.Object, ByVal e As Telerik.WinControls.UI.GridViewCellCancelEventArgs) Handles RadGridView1.CellBeginEdit
        temp_grid_cell = CInt(RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
        If e.ColumnIndex >= 4 And e.ColumnIndex <= 9 Then
            RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = CDbl((RadGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)) / 1000
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If RadGridView1.Rows.Count > 0 Then
            Dim _label_(CInt(RadGridView1.Rows.Count) - 1) As _Label
            For i = 0 To RadGridView1.Rows.Count - 1
                _label_(i).N = CInt(RadGridView1.Rows(i).Cells("qty").Value)
                _label_(i).lbl_kode = CStr(RadGridView1.Rows(i).Cells("id_barang").Value)
                _label_(i).id_barang = CStr(RadGridView1.Rows(i).Cells("id_barang").Value)
                _label_(i).nm_brg = CStr(RadGridView1.Rows(i).Cells("nama_barang").Value)
                _label_(i).h_grosir = CStr(RadGridView1.Rows(i).Cells("colum_db_hgrosir").Value)
                _label_(i).h_retail = CStr(RadGridView1.Rows(i).Cells("colum_db_hretail").Value)
                _label_(i).nama_perusahaan = NamaTokoShort
                Using gambarLogo As New System.IO.MemoryStream(LogoPerusahaan)
                    _label_(i).gambar = Image.FromStream(gambarLogo)
                End Using
            Next
            Using CetakLabel As New FormCetakLabel
                CetakLabel._label_ = _label_
                CetakLabel.ShowDialog()
                CetakLabel.Dispose()
            End Using
            CobaBersihkanMemori()
        End If
    End Sub

    Private Sub FormReturPenjualan_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Telerik.WinControls.RadMessageBox.Show("Apakah Anda ingin menyimpan Nota Retur ini ?", "Simpan Nota Retur", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If RadGridView1.Rows.Count > 0 Then
                Using tabel_temp_retur As New tokoDataSetTableAdapters.tabel_temp_returTableAdapter
                    For i = 0 To RadGridView1.Rows.Count - 1
                        tabel_temp_retur.InsertQuery(Invoice, CInt(RadGridView1.Rows(i).Cells("qty").Value), RadGridView1.Rows(i).Cells("id_barang").Value.ToString, RadGridView1.Rows(i).Cells("nama_barang").Value.ToString, CInt(RadGridView1.Rows(i).Cells("harga_jual").Value))
                    Next
                    Using ReportReturToPDF As New ReportNotaReturToPDF
                        ReportReturToPDF.ReportParameters("div").Value = DivKoefisien
                        ReportReturToPDF.ReportParameters("invoice").Value = Invoice
                        ReportReturToPDF.ReportParameters("sales").Value = Sales
                        ReportReturToPDF.ReportParameters("customer_id").Value = ID_Customer
                        ReportReturToPDF.ReportParameters("status").Value = status
                        If Not FileIO.FileSystem.DirectoryExists(My.Settings.FolderNota) Then
                            FileIO.FileSystem.CreateDirectory(My.Settings.FolderNota)
                        End If
                        SaveReport(ReportReturToPDF, My.Settings.FolderNota & "\" & Invoice & " " & Nama_Customer & ".pdf")
                    End Using
                    tabel_temp_retur.DeleteQuery(Invoice)
                End Using
            End If
        End If
    End Sub

    Private Sub RadLabel1_Click(sender As Object, e As EventArgs) Handles RadLabel1.Click
        RefreshRecent()
    End Sub

    Public Sub RefreshRecent()
        RadLabelNo.Text = ""
        RadLabelNamaBarang.Text = ""
        RadLabelKodeBarang.Text = ""
        RadLabelQty.Text = ""
        RadLabelX.Text = ""
        RadLabelHargaJual.Text = ""
    End Sub

    Private Sub RadGridView1_ContextMenuOpening(sender As Object, e As Telerik.WinControls.UI.ContextMenuOpeningEventArgs) Handles RadGridView1.ContextMenuOpening
        If RadGridView1.CurrentCell.ColumnIndex = 3 Or RadGridView1.CurrentCell.ColumnIndex = 4 Then
            e.ContextMenu.Items(1).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        End If
    End Sub

    Private Sub RadGridView1_CellEditorInitialized(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellEditorInitialized
        Dim spineditor As Telerik.WinControls.UI.GridSpinEditor = TryCast(Me.RadGridView1.ActiveEditor, Telerik.WinControls.UI.GridSpinEditor)
        If spineditor IsNot Nothing Then
            If e.ColumnIndex >= 4 And e.ColumnIndex <= 9 Then
                spineditor.DecimalPlaces = Desimal()
            End If
        End If
    End Sub
End Class