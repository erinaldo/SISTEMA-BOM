Public Class UserControl1

    Public Property nama_sales As String
    Public Property pembayaran As Double = 0
    Public Property penjualan As Double = 0
    Public Property retur As Double = 0

    Public Sub hitung_total()
        If RadGridView1.RowCount <> 0 Then
            For i = 0 To RadGridView1.RowCount - 1
                penjualan += CDbl(RadGridView1.Rows(i).Cells("belanja").Value)
                retur += CDbl(RadGridView1.Rows(i).Cells("retur").Value)
                pembayaran += CDbl(RadGridView1.Rows(i).Cells("pembayaran").Value)
            Next
        End If
    End Sub

    Private Sub MasterTemplate_ViewCellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.ViewCellFormatting
        If TypeOf e.CellElement Is Telerik.WinControls.UI.GridSummaryCellElement Then
            e.CellElement.TextAlignment = ContentAlignment.MiddleRight
            e.CellElement.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
            If e.CellElement.Value <> "" Then
                e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
            End If
        End If
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellClick
        If e.ColumnIndex = 0 And RadGridView1.RowCount <> 0 Then
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
                    'CetakNotaOrder.ExtraOrdinary = True
                    CetakNotaOrder.Text = "Nota Order " & e.Value.ToString
                    CetakNotaOrder.invoice = CStr(e.Value)
                    CetakNotaOrder.banyak = BanyakBarisNota(rows) + 1
                    CetakNotaOrder.ShowDialog()
                    CetakNotaOrder.Dispose()
                    CobaBersihkanMemori()
                End Using
            End If
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Then 
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub
End Class
