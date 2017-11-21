Public Class FormLihatCetakLabel
    Dim load_complete As Boolean = False

    Private Sub FormLihatCetakLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_barang' table. You can move, or remove it, as needed.
        'Me.Tabel_barangTableAdapter.Fill(Me.TokoDataSet.tabel_barang)
        
    End Sub

    Private Sub fill_tipe_barang()
        Using dt As DataTable = Me.Tabel_tipe_barangTableAdapter.GetData()
            RadDropDownList1.Items.Clear()
            RadDropDownList1.Items.Add("< semua >")
            For i = 0 To dt.Rows.Count - 1
                RadDropDownList1.Items.Add(dt.Rows(i).Item("tipe").ToString)
            Next
            RadDropDownList1.SelectedIndex = 0
        End Using
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        filter()
    End Sub

    Private Sub filter()
        Dim tipe As String = RadDropDownList1.SelectedItem.Text
        If tipe = "< semua >" Then
            tipe = "%"
        End If
        Dim id_nama As String = "%" & RadTextBox1.Text & "%"
        Me.Tabel_barangTableAdapter.FillByFilter_Tipe(Me.TokoDataSet.tabel_barang, tipe, id_nama)
    End Sub

    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RadTextBox1.TextChanged
        filter()
    End Sub

    Private Sub RadDropDownList1_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles RadDropDownList1.SelectedIndexChanged
        If load_complete = True Then
            filter()
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        If RadGridView1.Rows.Count <> 0 Then
            Dim hitungjumlah = Function()
                                   Dim jumlah As Integer = 0
                                   For i = 0 To RadGridView1.Rows.Count - 1
                                       If CBool(RadGridView1.Rows(i).Cells("pilih").Value) = True Then
                                           jumlah += RadGridView1.Rows(i).Cells("jumlah").Value
                                       End If
                                   Next
                                   Return jumlah
                               End Function
            If hitungjumlah() <> 0 Then
                Dim count As Integer = 0
                For i = 0 To RadGridView1.Rows.Count - 1
                    If CBool(RadGridView1.Rows(i).Cells("pilih").Value) = True Then
                        count += 1
                    End If
                Next
                Dim label(count - 1) As UC_BarangMasuk._Label
                Dim label_indeks As Integer = count
                'MessageBox.Show(count)
                Dim indeks As Integer = 0
                For i = 0 To RadGridView1.Rows.Count - 1
                    If CBool(RadGridView1.Rows(i).Cells("pilih").Value) = True Then
                        label(indeks) = New UC_BarangMasuk._Label
                        label(indeks).N = CInt(RadGridView1.Rows(i).Cells("jumlah").Value)
                        label(indeks).lbl_kode = CStr(RadGridView1.Rows(i).Cells("kode_barang").Value)
                        label(indeks).id_barang = CStr(RadGridView1.Rows(i).Cells("kode_barang").Value)
                        label(indeks).nm_brg = CStr(RadGridView1.Rows(i).Cells("nama_barang").Value)
                        label(indeks).h_grosir = CStr(RadGridView1.Rows(i).Cells("harga_grosir").Value)
                        label(indeks).h_retail = CStr(RadGridView1.Rows(i).Cells("harga_retail").Value)
                        label(indeks).nama_perusahaan = NamaTokoShort
                        Using gambarLogo As New System.IO.MemoryStream(LogoPerusahaan)
                            label(indeks).gambar = Image.FromStream(gambarLogo)
                        End Using
                        indeks += 1
                    End If
                Next
                If count <> 0 Then
                    Using CetakLabel As New FormCetakLabel
                        CetakLabel._label_ = label
                        CetakLabel.ShowDialog()
                        CetakLabel.Dispose()
                        CobaBersihkanMemori()
                    End Using
                End If
                label = Nothing
            End If
        End If
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellClick
        If RadGridView1.Rows.Count <> 0 Then
            RadGridView1.BeginEdit()
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 7 Or e.ColumnIndex = 11 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub FormLihatCetakLabel_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        fill_tipe_barang()
        Me.load_complete = True
    End Sub
End Class
