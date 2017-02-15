Imports System.Windows.Forms

Public Class FormDialogCariBarangBrgMasuk

    Private Sub DialogCariBarangBrgMasuk_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Property kode_brg As String

    Private Sub DialogCariBarangBrgMasuk_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DataGridView1.RowCount = 0 Then
                Telerik.WinControls.RadMessageBox.Show("Tidak ada data yang dipilih.", "Kesalahan", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
            Else
                transferdata_yangdicari()
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Me.Close()
            End If
        End If
    End Sub

    Private Sub transferdata_yangdicari()
        kode_brg = DataGridView1.CurrentView.GridViewElement.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.RowCount = 0 Then
            Telerik.WinControls.RadMessageBox.Show("Tidak ada data yang dipilih.", "Kesalahan", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
        Else
            transferdata_yangdicari()
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If DataGridView1.Rows.Count <> 0 Then
            If e.KeyCode = Keys.Up Then
                e.SuppressKeyPress = True
                If DataGridView1.CurrentRow.Index <> 0 Then
                    DataGridView1.CurrentRow = DataGridView1.Rows(DataGridView1.Rows.Count - 1)
                Else
                    DataGridView1.CurrentRow = DataGridView1.Rows(DataGridView1.CurrentRow.Index - 1)
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
            Me.Tabel_barangTableAdapter.FillByCari(TokoDataSet.tabel_barang, "%" & TextBox1.Text & "%")
        End If
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 10 Then
            e.CellElement.Text = ubahtocurrencybyDiv(e.CellElement.Value)
        End If
    End Sub
End Class
