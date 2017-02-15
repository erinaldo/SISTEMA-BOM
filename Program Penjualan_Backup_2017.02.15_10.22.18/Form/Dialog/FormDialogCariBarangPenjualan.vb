Imports System.Windows.Forms

Public Class FormDialogCariBarangPenjualan

    Public Property id_barang As String = ""
    Public Property status As String = ""

    Private Sub DialogCariBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            pilihdata()
        End If
    End Sub

    Private Sub DialogCariBarangPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If DivKoefisien = DivCoef._1 Then
        '    DataGridView1.Columns(4).FormatString = "{0:N2}"
        '    DataGridView1.Columns(5).FormatString = "{0:N2}"
        '    DataGridView1.Columns(6).FormatString = "{0:N2}"
        '    DataGridView1.Columns(10).FormatString = "{0:N2}"
        'Else
        '    DataGridView1.Columns(4).FormatString = "{0:N0}"
        '    DataGridView1.Columns(5).FormatString = "{0:N0}"
        '    DataGridView1.Columns(6).FormatString = "{0:N0}"
        '    DataGridView1.Columns(10).FormatString = "{0:N0}"
        'End If
        If status = "(O)" Then
            DataGridView1.Columns("harga_modal").IsVisible = True
            'DataGridView1.Columns("harga_grosir").IsVisible = False
            DataGridView1.Columns("harga_retail").IsVisible = False
        ElseIf status = "(R)" Then
            'DataGridView1.Columns("harga_grosir").IsVisible = False
        ElseIf status = "(G)" Then
            DataGridView1.Columns("harga_retail").IsVisible = False
        End If
    End Sub

    Private Sub pilihdata()
        If DataGridView1.RowCount <> 0 Then
            'If Not CInt(DataGridView1.Item("StokbarangDataGridViewTextBoxColumn", DataGridView1.CurrentCell.RowIndex).Value) <= 0 Then
            id_barang = DataGridView1.CurrentView.GridViewElement.CurrentRow.Cells(0).Value.ToString
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            'Else
            ' Telerik.WinControls.RadMessageBox.Show("Tidak bisa menambahkan karena barang yang ingin dijual saat ini " & DataGridView1.Item("StokbarangDataGridViewTextBoxColumn", DataGridView1.CurrentCell.RowIndex).Value & " tidak mencukupi.", "Stok Tidak Mencukupi", MessageBoxButtons.OK)
            'End If
        End If
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'pilihdata()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        pilihdata()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If DataGridView1.Rows.Count <> 0 Then
            If e.KeyCode = Keys.Up Then
                e.SuppressKeyPress = True
                If DataGridView1.CurrentRow.Index <> 0 Then
                    DataGridView1.CurrentRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index - 1)
                Else
                    DataGridView1.CurrentRow = DataGridView1.Rows(DataGridView1.Rows.Count - 1)
                End If
            ElseIf e.KeyCode = Keys.Down Then
                e.SuppressKeyPress = True
                If DataGridView1.CurrentRow.Index <> DataGridView1.Rows.Count - 1 Then
                    DataGridView1.CurrentRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index + 1)
                Else
                    DataGridView1.CurrentRow = DataGridView1.Rows(0)
                End If
            End If
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If TextBox1.Text = "" Then
            TokoDataSet.Clear()
        Else
            Me.Tabel_barangTableAdapter.FillByCari(Me.TokoDataSet.tabel_barang, "%" & TextBox1.Text & "%")
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub
End Class
