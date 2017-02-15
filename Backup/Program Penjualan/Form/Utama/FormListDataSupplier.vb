Public Class FormListDataSupplier

    Dim old_value As String
    Dim new_value As String
    Dim load_complete As Boolean = False

    Private Sub FormListDataSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_supplier' table. You can move, or remove it, as needed.
        
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Filter()
    End Sub

    Private Sub Filter()
        Dim thn As String = Thn_ComboBox.SelectedItem.Text
        Dim bln As String = BulanToAngka(Bln_ComboBox.SelectedItem.Text)
        Dim id_supplier As String = ID_MultiComboBox.Text
        Dim kota_asal As String = Daerah_Kota_ComboBox.SelectedItem.Text
        If Thn_ComboBox.SelectedItem.Text = "< semua >" Then
            thn = "%"
        End If
        If Bln_ComboBox.SelectedItem.Text = "< semua >" Then
            bln = "%"
        End If
        Dim tgl As String = thn + "-" + bln + "-%"
        If id_supplier = "< semua >" Then
            id_supplier = "%"
        End If
        If kota_asal = "< semua >" Then
            kota_asal = "%"
        End If
        Me.Tabel_supplierTableAdapter.FillByCariFilter(TokoDataSet.tabel_supplier, id_supplier, kota_asal, tgl)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SettingAuthority.CustomerAndSupplier.PrintDataSupplier = True Then
            Dim asal As String = Daerah_Kota_ComboBox.SelectedItem.Text
            If asal = "< semua >" Then
                asal = "%"
            End If
            Using CetakListDataSupplier As New FormCetakListDataSupplier
                CetakListDataSupplier.asal = asal
                CetakListDataSupplier.ShowDialog()
                CetakListDataSupplier.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellClick
        If e.ColumnIndex = 8 And e.RowIndex = RadGridView1.CurrentCell.RowIndex Then
            Using DetailSupplier As New FormDetailSupplier
                DetailSupplier.id = RadGridView1.Rows(RadGridView1.CurrentCell.RowIndex).Cells("id_supplier").Value.ToString()
                DetailSupplier.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
    End Sub

    Private Sub RadGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles RadGridView1.KeyDown
        If RadGridView1.Rows.Count <> 0 Then
            If SettingAuthority.CustomerAndSupplier.EditSupplier = True Then
                If e.KeyCode = Keys.Delete Then
                    If Telerik.WinControls.RadMessageBox.Show("Menghapus data pada tabel ini akan menghapus seluruh data yang berhubungan dengan data ini." & "Apakah Anda yakin ingin menghapus supplier dengan ID : " + RadGridView1.Rows(RadGridView1.CurrentCell.RowIndex).Cells("id_supplier").Value.ToString & " " & _
                                              RadGridView1.Rows(RadGridView1.CurrentCell.RowIndex).Cells("nama").Value.ToString, "Peringatan Konfirmasi Hapus Supplier", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                        Try
                            Me.Tabel_supplierTableAdapter.DeleteQuery(CStr(RadGridView1.CurrentRow.Cells("id_supplier").Value))
                            Filter()
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show("Tidak dapat menghapus supplier : " & ex.Message, "Hapus Supplier", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                        End Try
                    End If
                End If
                If e.KeyCode = Keys.F5 Then
                    RadGridView1.BeginEdit()
                End If
            Else
                'aksesdenied()
            End If
        End If
    End Sub

    Private Sub RadGridView1_CellBeginEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellCancelEventArgs) Handles RadGridView1.CellBeginEdit
        Me.old_value = RadGridView1.CurrentCell.Text
    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        If SettingAuthority.CustomerAndSupplier.EditSupplier = True Then
            If RadGridView1.Rows.Count <> 0 Then
                If e.ColumnIndex >= 2 And e.ColumnIndex <= 5 Or e.ColumnIndex = 7 Then
                    RadGridView1.BeginEdit()
                End If
            End If
        End If
    End Sub

    Private Sub RadGridView1_CellEndEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellEndEdit
        Me.new_value = RadGridView1.CurrentCell.Text
        If old_value <> new_value Then
            If Telerik.WinControls.RadMessageBox.Show("Apakah Anda ingin mengubah data dari " & old_value & " menjadi " & new_value & " ?", "Konfirmasi Perubahaan Data", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Select Case e.ColumnIndex
                    Case 2
                        Try
                            Me.Tabel_supplierTableAdapter.UpdateQueryNamaSupplier(Me.new_value, CStr(RadGridView1.CurrentRow.Cells("id_supplier").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 3
                        Try
                            Me.Tabel_supplierTableAdapter.UpdateQueryAlamatSupplier(Me.new_value, CStr(RadGridView1.CurrentRow.Cells("id_supplier").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 4
                        Try
                            Me.Tabel_supplierTableAdapter.UpdateQueryAsalSupplier(Me.new_value, CStr(RadGridView1.CurrentRow.Cells("id_supplier").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 5
                        Try
                            Me.Tabel_supplierTableAdapter.UpdateQueryTelpSupplier(Me.new_value, CStr(RadGridView1.CurrentRow.Cells("id_supplier").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 6
                        Try
                            Me.Tabel_supplierTableAdapter.UpdateQueryCatatanSupplier(Me.new_value, CStr(RadGridView1.CurrentRow.Cells("id_supplier").Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                End Select
            Else
                RadGridView1.CurrentCell.Text = Me.old_value
            End If
        End If
        Me.new_value = ""
        Me.old_value = ""
    End Sub

    Private Sub Bln_ComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles Bln_ComboBox.SelectedIndexChanged, Thn_ComboBox.SelectedIndexChanged, Daerah_Kota_ComboBox.SelectedIndexChanged
        If load_complete = True Then
            Filter()
        End If
    End Sub

    Private Sub FormListDataSupplier_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Using dt As DataTable = Me.Tabel_supplieDistinctAsalTableAdapter.GetData()
            Using dta As DataTable = Me.Tabel_supplierTableAdapter.GetData()
                ID_MultiComboBox.MultiColumnComboBoxElement.Rows.Add("< semua >")
                For i = 0 To dta.Rows.Count - 1
                    ID_MultiComboBox.MultiColumnComboBoxElement.Rows.Add(dta.Rows(i).Item(0), dta.Rows(i).Item(1))
                Next
                Daerah_Kota_ComboBox.Items.Clear()
                Daerah_Kota_ComboBox.Items.Add("< semua >")
                For i As Integer = 0 To dt.Rows.Count - 1
                    Daerah_Kota_ComboBox.Items.Add(dt.Rows(i).Item(0).ToString)
                Next
                Thn_ComboBox.Items.Clear()
                Thn_ComboBox.Items.Add("< semua >")
                For i As Integer = Date.Today.Year To Date.Today.Year - 30 Step -1
                    Thn_ComboBox.Items.Add(i.ToString)
                Next
                Thn_ComboBox.SelectedIndex = 0
                ID_MultiComboBox.SelectedIndex = 0
                Daerah_Kota_ComboBox.SelectedIndex = 0
                Bln_ComboBox.SelectedIndex = 0
                'Filter()
                Me.load_complete = True
            End Using
            Me.ID_MultiComboBox.EditorControl.MasterTemplate.FilterDescriptors.LogicalOperator = Telerik.WinControls.Data.FilterLogicalOperator.Or
        End Using
    End Sub

    Private Sub RadGridView1_ContextMenuOpening(sender As Object, e As Telerik.WinControls.UI.ContextMenuOpeningEventArgs) Handles RadGridView1.ContextMenuOpening
        If RadGridView1.CurrentCell.ColumnIndex = 2 Or RadGridView1.CurrentCell.ColumnIndex = 3 Or RadGridView1.CurrentCell.ColumnIndex = 4 Or RadGridView1.CurrentCell.ColumnIndex = 5 Then
            e.ContextMenu.Items(1).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        End If
    End Sub
End Class