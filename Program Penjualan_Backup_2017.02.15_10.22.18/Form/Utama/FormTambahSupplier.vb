Public Class FormTambahSupplier
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox_ID.Text = "" Or TextBox_Nama.Text = "" Or TextBox_Alamat.Text = "" Or TextBox_kota.Text = "" Or TextBox_telp.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show("Semua data harus diisi.", "Tambah Supplier", MessageBoxButtons.OK)
        Else
            Try
                Me.Tabel_supplierTableAdapter1.InsertQuery(TextBox_ID.Text, TextBox_Nama.Text, TextBox_Alamat.Text, TextBox_kota.Text, TextBox_telp.Text, _
                                                                    RichTextBox_keterangan.Text, CType(tgltoday, Date?))
                Telerik.WinControls.RadMessageBox.Show("Input data dengan id supplier = " & TextBox_ID.Text & " telah berhasil", "Sukses", MessageBoxButtons.OK)
                Me.Close()

            Catch ex As Exception
                Telerik.WinControls.RadMessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub FormTambahSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_bln.Text = Date.Now.Day & " " & bulanToday & " " & Date.Now.Year
        TextBox_ID.Text = id_tersedia()
    End Sub

    Private Function id_tersedia() As String
        Dim id_supplier As String = Me.Tabel_supplierTableAdapter1.MaxIDSupplier
        If id_supplier IsNot vbNullString Then
            Dim id_1 As Integer = CType(id_supplier.Substring(2, 3), Integer)
            Dim id_2 As Integer = CType(id_supplier.Substring(6), Integer)
            If id_2 + 1 > 999 Then
                id_1 += 1
                id_2 = 0
            Else
                id_2 += 1
            End If
            Return "S-" & id_supp_string(CStr(id_1)) & "-" & id_supp_string(CStr(id_2))
        Else
            Return "S-000-001"
        End If

    End Function

    Private Function id_supp_string(ByVal id As String) As String
        Select Case id.Count
            Case 1
                id = "00" & id
            Case 2
                id = "0" & id
        End Select
        Return id
    End Function

    Private Sub TextBox_ID_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ID.TextChanged
        cek_ID()
    End Sub

    Private Sub cek_ID()
        If TextBox_ID.Text <> "" Then
            Select Case CInt(Tabel_supplierTableAdapter1.CK_ID_SUpplier(TextBox_ID.Text))
                Case 1
                    Telerik.WinControls.RadMessageBox.Show("ID Supplier yang diisikan telah ada. Harap ganti dengan ID yang lain.", "Tidak Boleh Sama", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                    Panel2.Enabled = False
                    TextBox_ID.Focus()
                Case Else
                    Panel2.Enabled = True
            End Select
        End If
    End Sub

    Private Sub TextBox_hutang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_telp.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CheckBox1_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckBox1.ToggleStateChanged
        If CheckBox1.Checked = True Then
            TextBox_ID.Enabled = False
            Panel2.Enabled = True
            TextBox_ID.Text = id_tersedia()
        Else
            TextBox_ID.Enabled = True
            TextBox_ID.Focus()
            cek_ID()
        End If
    End Sub

    Private Sub TextBox_Alamat_Leave(sender As Object, e As EventArgs) Handles TextBox_Alamat.Leave
        Me.TextBox_Alamat.Text = CapitalizeEachWord(TextBox_Alamat.Text)
    End Sub

    Private Sub TextBox_Nama_Leave(sender As Object, e As EventArgs) Handles TextBox_Nama.Leave
        Me.TextBox_Nama.Text = CapitalizeEachWord(TextBox_Nama.Text)
    End Sub

    Private Sub TextBox_kota_Leave(sender As Object, e As EventArgs) Handles TextBox_kota.Leave
        Me.TextBox_kota.Text = CapitalizeEachWord(TextBox_kota.Text)
    End Sub

    Private Sub RichTextBox_keterangan_Leave(sender As Object, e As EventArgs) Handles RichTextBox_keterangan.Leave
        Me.RichTextBox_keterangan.Text = CapitalizeEachWord(RichTextBox_keterangan.Text)
    End Sub
End Class