Partial Class tokoDataSet
    Partial Class tabel_preferensi_brgmasukDataTable

        Private Sub tabel_preferensi_brgmasukDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.noColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class tabel_trans_barang_masukDataTable

        Private Sub tabel_trans_barang_masukDataTable_tabel_trans_barang_masukRowChanging(sender As Object, e As tabel_trans_barang_masukRowChangeEvent) Handles Me.tabel_trans_barang_masukRowChanging

        End Sub

    End Class

End Class

Namespace tokoDataSetTableAdapters
    
    Partial Class tabel_detail_bestsellerTableAdapter

    End Class

    Partial Public Class tabel_tipe_barangTableAdapter
    End Class
End Namespace
