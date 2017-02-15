Public Class FormDialogSeleksiDetailTransaksi

    Public Property Jenis As Jenis2
    Public Enum Jenis2
        PenjualanDanOrder
        Retur
        BarangMasuk
    End Enum
    Private Sub FormDialogSeleksiDetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Jenis = Jenis2.PenjualanDanOrder Then
            Me.Text = "Detail Penjualan & Order"
            Using ts As New tokoDataSetTableAdapters.tabel_customerTableAdapter
                Using dt As DataTable = ts.GetData
                    RadDropDownList1.Items.Clear()
                    If dt.Rows.Count > 0 Then
                        For i = 0 To dt.Rows.Count - 1
                            RadDropDownList1.Items.Add(dt.Rows(i).Item(0))
                        Next
                        RadDropDownList1.SelectedIndex = 0
                    End If
                End Using
            End Using
        ElseIf Jenis = Jenis2.Retur Then
            Me.Text = "Detail Retur"
            Using ts As New tokoDataSetTableAdapters.tabel_customerTableAdapter
                Using dt As DataTable = ts.GetData
                    RadDropDownList1.Items.Clear()
                    If dt.Rows.Count > 0 Then
                        For i = 0 To dt.Rows.Count - 1
                            RadDropDownList1.Items.Add(dt.Rows(i).Item(0))
                        Next
                        RadDropDownList1.SelectedIndex = 0
                    End If
                End Using
            End Using
        ElseIf Jenis = Jenis2.BarangMasuk Then
            Me.Text = "Detail Barang Masuk"
            RadLabel1.Text = "Supplier"
            RadLabel4.Text = "Supplier"
            Using ts As New tokoDataSetTableAdapters.tabel_supplierTableAdapter
                Using dt As DataTable = ts.GetData
                    RadDropDownList1.Items.Clear()
                    If dt.Rows.Count > 0 Then
                        For i = 0 To dt.Rows.Count - 1
                            RadDropDownList1.Items.Add(dt.Rows(i).Item(0))
                        Next
                        RadDropDownList1.SelectedIndex = 0
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Sub RadDropDownList1_TextChanged(sender As Object, e As EventArgs) Handles RadDropDownList1.TextChanged
        If Jenis = Jenis2.BarangMasuk Then
            Using ds As New tokoDataSetTableAdapters.tabel_supplierTableAdapter
                If RadDropDownList1.Items.Count > 0 Then
                    Using dt As DataTable = ds.GetData_based_id_supplier(RadDropDownList1.Text)
                        If dt.Rows.Count > 0 Then
                            RadLabel4.Text = dt.Rows(0).Item("nama") & " di " & dt.Rows(0).Item("asal")
                        End If
                    End Using
                End If
            End Using
        Else
            Using ds As New tokoDataSetTableAdapters.tabel_customerTableAdapter
                If RadDropDownList1.Items.Count > 0 Then
                    Using dt As DataTable = ds.GetData_based_id_customer(RadDropDownList1.Text)
                        If dt.Rows.Count > 0 Then
                            RadLabel4.Text = dt.Rows(0).Item("nama") & " di " & dt.Rows(0).Item("asal")
                        End If
                    End Using
                End If
            End Using
        End If
    End Sub
End Class
