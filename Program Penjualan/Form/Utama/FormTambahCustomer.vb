Public Class FormTambahCustomer

    Private Sub cek_ID()
        If Not ID_Customer_TextBox.Text.Contains("_") And complete Then
            Select Case Tabel_customerTableAdapter.CK_ID_Customer(ID_Customer_TextBox.Text)
                Case 1
                    Telerik.WinControls.RadMessageBox.Show("ID Customer " & ID_Customer_TextBox.Text & " yang diisikan telah ada. Harap ganti dengan ID yang lain.", "Tidak Boleh Sama", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                    Panel2.Enabled = False
                    ID_Customer_TextBox.Focus()
                Case Else
                    Panel2.Enabled = True
            End Select
        ElseIf ID_Customer_TextBox.Text.Contains("_") And complete Then
            Panel2.Enabled = False
            ID_Customer_TextBox.Focus()
        End If
    End Sub

    Private Function id_tersedia() As String
        Dim id_customer As String = CStr(Me.Tabel_customerTableAdapter.MaxIDCustomer)
        Dim id_1 As Integer = CType(id_customer.Substring(2, 3), Integer)
        Dim id_2 As Integer = CType(id_customer.Substring(6), Integer)
        If id_2 + 1 > 999 Then
            id_1 += 1
            id_2 = 0
        Else
            id_2 += 1
        End If
        Return "C-" & id_customer_string(CStr(id_1)) & "-" & id_customer_string(CStr(id_2))
    End Function

    Private Function id_customer_string(ByVal id As String) As String
        Select Case id.Count
            Case 1
                id = "00" & id
            Case 2
                id = "0" & id
        End Select
        Return id
    End Function

    Dim complete As Boolean = False
    Private Sub FormTambahCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Terdaftar_Bln_TextBox.Text = Date.Now.Day & " " & bulanToday & " " & Date.Now.Year
        ID_Customer_TextBox.Text = id_tersedia()
        complete = True
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If ID_Customer_TextBox.Text = "" Or Nama_TextBox.Text = "" Or Alamat_TextBox.Text = "" Or Kota_TextBox.Text = "" Or Telp_TextBox.Text = "" Or Hutang_TextBox.Text = "" Then
            Telerik.WinControls.RadMessageBox.Show("Semua data harus diisi.", "Tambah Customer", MessageBoxButtons.OK)
        Else
            Try
                Me.Tabel_customerTableAdapter.InsertQuery(ID_Customer_TextBox.Text, Nama_TextBox.Text, Alamat_TextBox.Text, Kota_TextBox.Text, Telp_TextBox.Text, _
                                                                   ubahAwalbeforeDiv(Hutang_TextBox.Text), Keterangan_RichTextBox.Text, CDate(tgltoday))
                Telerik.WinControls.RadMessageBox.Show("Input data dengan id customer = " & ID_Customer_TextBox.Text & " telah berhasil", "Sukses", MessageBoxButtons.OK)
                Me.Close()

            Catch ex As Exception
                Telerik.WinControls.RadMessageBox.Show(ex.Message, "", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Telp_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Telp_TextBox.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Hutang_TextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Hutang_TextBox.KeyPress
        If (Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or _
             (e.KeyChar = ","c And Not Hutang_TextBox.Text.Contains(",") And Hutang_TextBox.SelectionStart > 0) Or _
             (e.KeyChar = "-"c And Not Hutang_TextBox.Text.Contains("-") And Hutang_TextBox.SelectionStart = 0)) And _
             DivKoefisien = DivCoef._1 Then
        ElseIf (Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Convert.ToChar(Keys.Back) Or _
            (e.KeyChar = "-"c And Not Hutang_TextBox.Text.Contains("-") And Hutang_TextBox.SelectionStart = 0)) And _
            DivKoefisien = DivCoef._1000 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Hutang_TextBox_Enter(sender As Object, e As EventArgs) Handles Hutang_TextBox.Enter
        Me.Hutang_TextBox.Select(Hutang_TextBox.Text.Length, 0)
    End Sub

    Private Sub CheckBox1_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles CheckBox1.ToggleStateChanged
        If CheckBox1.Checked = True Then
            ID_Customer_TextBox.Enabled = False
            Panel2.Enabled = True
            ID_Customer_TextBox.Text = id_tersedia()
        Else
            ID_Customer_TextBox.Enabled = True
            ID_Customer_TextBox.Focus()
        End If
    End Sub

    Private Sub Keterangan_RichTextBox_Leave(sender As Object, e As EventArgs) Handles Keterangan_RichTextBox.Leave
        Me.Keterangan_RichTextBox.Text = CapitalizeEachWord(Keterangan_RichTextBox.Text)
    End Sub

    Private Sub Nama_TextBox_Leave(sender As Object, e As EventArgs) Handles Nama_TextBox.Leave
        Me.Nama_TextBox.Text = CapitalizeEachWord(Nama_TextBox.Text)
    End Sub

    Private Sub Alamat_TextBox_Leave(sender As Object, e As EventArgs) Handles Alamat_TextBox.Leave
        Me.Alamat_TextBox.Text = CapitalizeEachWord(Alamat_TextBox.Text)
    End Sub

    Private Sub Kota_TextBox_Leave(sender As Object, e As EventArgs) Handles Kota_TextBox.Leave
        Me.Kota_TextBox.Text = CapitalizeEachWord(Kota_TextBox.Text)
    End Sub

    Private Sub ID_Customer_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID_Customer_TextBox.TextChanged
        cek_ID()
    End Sub

    Private Sub Hutang_TextBox_Leave(sender As Object, e As EventArgs) Handles Hutang_TextBox.Leave
        Me.Hutang_TextBox.Text = ubahtocurrency(Me.Hutang_TextBox.Text)
    End Sub
End Class