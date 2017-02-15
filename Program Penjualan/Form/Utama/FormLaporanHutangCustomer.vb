Public Class FormLaporanHutangCustomer

    Private Sub FormLaporanHutangCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_hutangcustomer' table. You can move, or remove it, as needed.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 4 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellClick
        If e.ColumnIndex = RadGridView1.Columns("detail").Index And e.RowIndex = RadGridView1.CurrentRow.Index Then
            Using LaporanDetailHutangCustomer As New FormLaporanDetailHutangCustomer
                LaporanDetailHutangCustomer.id_customer = CStr(RadGridView1.Rows(e.RowIndex).Cells("id_customer").Value)
                LaporanDetailHutangCustomer.ShowDialog()
                LaporanDetailHutangCustomer.Dispose()
                CobaBersihkanMemori()
            End Using
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If SettingAuthority.Laporan.CetakLaporan = True Then
            Using CetakLaporanHutangCustomer As New FormCetakLaporanHutangCustomer
                CetakLaporanHutangCustomer.ShowDialog()
                CetakLaporanHutangCustomer.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub cari()
        If RadTextBox1.Text = "" Then
            Me.Tabel_hutangcustomerTableAdapter.FillB(Me.TokoDataSet.tabel_hutangcustomer)
        Else
            Me.Tabel_hutangcustomerTableAdapter.FillBBy(Me.TokoDataSet.tabel_hutangcustomer, "%" & RadTextBox1.Text & "%", "%" & RadTextBox1.Text & "%")
        End If
    End Sub

    Private Sub RadTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RadTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cari()
        End If
    End Sub

    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButton1.Click
        cari()
    End Sub

    Private Sub FormLaporanHutangCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.Tabel_hutangcustomerTableAdapter.FillB(Me.TokoDataSet.tabel_hutangcustomer)
    End Sub
End Class