Public Class FormBestSeller
    Property status As String

    Private load_complete As Boolean = False

    Private Sub FormBestSeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_bestSeller' table. You can move, or remove it, as needed.
        Me.Text = status
    End Sub

    Private Sub filter()
        If status = "Best Seller" Then
            Me.Tabel_bestSellerTableAdapter.Fill(Me.TokoDataSet.tabel_bestSeller, CDate(RadDateTimePicker1.Value.ToShortDateString & " 00:00"), CDate(RadDateTimePicker2.Value.ToShortDateString & " 23:59"))
        Else
            Me.Tabel_bestSellerTableAdapter.FillByMostProfit(Me.TokoDataSet.tabel_bestSeller, CDate(RadDateTimePicker1.Value.ToShortDateString & " 00:00"), CDate(RadDateTimePicker2.Value.ToShortDateString & " 23:59"))
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
        If e.ColumnIndex = 3 Or e.ColumnIndex = 4 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellClick
        If RadGridView1.Rows.Count > 0 Then
            If e.ColumnIndex = 1 And e.RowIndex = RadGridView1.CurrentCell.RowIndex Then
                Using DetailBestSeller As New FormDetailsBestSeller
                    DetailBestSeller.Tipe = CStr(RadGridView1.Rows(e.RowIndex).Cells(1).Value)
                    DetailBestSeller.Status = status
                    DetailBestSeller.Awal = RadDateTimePicker1.Value.ToShortDateString & " 00:00"
                    DetailBestSeller.Akhir = RadDateTimePicker2.Value.ToShortDateString & " 23:59"
                    DetailBestSeller.Text = "Details " + Me.Text + " Tipe Barang : " + DetailBestSeller.Tipe
                    DetailBestSeller.ShowDialog()
                    DetailBestSeller.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        filter()
    End Sub

    Private Sub RadDateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles RadDateTimePicker1.ValueChanged
        If load_complete = True Then
            filter()
        End If
    End Sub

    Private Sub RadDateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles RadDateTimePicker2.ValueChanged
        If load_complete = True Then
            filter()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If status = "Best Seller" Then
        Using CetakBestSeller As New FormCetakLaporanBestSeller
            CetakBestSeller.awal = RadDateTimePicker1.Value.ToShortDateString
            CetakBestSeller.akhir = RadDateTimePicker2.Value.ToShortDateString
            CetakBestSeller.ShowDialog()
            CetakBestSeller.Dispose()
            CobaBersihkanMemori()
        End Using
        'Else

        'End If
    End Sub

    Private Sub FormBestSeller_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        RadDateTimePicker1.Value = CDate("1/" & Date.Now.Month & "/" & Date.Now.Year)
        RadDateTimePicker2.Value = CDate(Date.DaysInMonth(Date.Now.Year, Date.Now.Month) & "/" & Date.Now.Month & "/" & Date.Now.Year)
        filter()
        Me.load_complete = True
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Using CetakLaporanMostProfit As New FormCetakLaporanMostProfit
            CetakLaporanMostProfit.awal = RadDateTimePicker1.Value.ToShortDateString
            CetakLaporanMostProfit.akhir = RadDateTimePicker2.Value.ToShortDateString
            CetakLaporanMostProfit.ShowDialog()
            CetakLaporanMostProfit.Dispose()
            CobaBersihkanMemori()
        End Using
    End Sub
End Class