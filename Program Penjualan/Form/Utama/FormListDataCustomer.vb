Public Class FormListDataCustomer

    Dim old_value, new_value As String

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub FormListDataCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_customer' table. You can move, or remove it, as needed.
        'Me.Tabel_customerTableAdapter.Fill(Me.TokoDataSet.tabel_customer)
        
    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 0 Then
            e.Value = e.RowIndex + 1
        End If
        If e.ColumnIndex = 9 Then
            e.Value = "Details"
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filter()
    End Sub

    Private Sub filter()
        Dim thn As String = Thn_ComboBox.SelectedItem.Text
        Dim bln As String = BulanToAngka(Bln_ComboBox.SelectedItem.Text)
        Dim id As String = ID_ComboBox.Text
        Dim daerah As String = Daerah_ComboBox.SelectedItem.Text
        If Thn_ComboBox.SelectedItem.Text = "< semua >" Then
            thn = "%"
        End If
        If Bln_ComboBox.SelectedItem.Text = "< semua >" Then
            bln = "%"
        End If
        If ID_ComboBox.Text = "< semua >" Then
            id = "%"
        End If
        If Daerah_ComboBox.SelectedItem.Text = "< semua >" Then
            daerah = "%"
        End If
        Dim tgl As String = thn + "-" + bln + "-%"

        Me.Tabel_customerTableAdapter.FillByCariFilter(TokoDataSet.tabel_customer, id, daerah, tgl)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If SettingAuthority.CustomerAndSupplier.PrintDataCustomer = True Then
            Dim asal As String = Daerah_ComboBox.SelectedItem.Text
            If asal = "< semua >" Then
                asal = "%"
            End If
            Using CetakListDataCustomer As New FormCetakListDataCustomer
                CetakListDataCustomer.asal = asal
                CetakListDataCustomer.ShowDialog()
                CetakListDataCustomer.Dispose()
                CobaBersihkanMemori()
            End Using
        Else
            aksesdenied()
        End If
    End Sub

    Private Sub RadGridView1_CellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellClick
        If e.ColumnIndex = 9 And e.RowIndex = RadGridView1.CurrentCell.RowIndex Then
            'FormDetailCustomer.id = RadGridView1.Rows(RadGridView1.CurrentCell.RowIndex).Cells("id_customer").Value.ToString()
            'FormDetailCustomer.ShowDialog()
        End If
    End Sub

    Private Sub RadGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles RadGridView1.KeyDown
        If RadGridView1.Rows.Count <> 0 Then
            If SettingAuthority.CustomerAndSupplier.EditCustomer = True Then
                If e.KeyCode = Keys.Delete Then
                    If RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells(1).Value.ToString <> "C-000-000" Then
                        If RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells("hutang_lama").Value.ToString = "0" Then
                            If Telerik.WinControls.RadMessageBox.Show("Menghapus data pada tabel ini akan menghapus seluruh data yang berhubungan dengan data ini." & "Apakah Anda yakin ingin menghapus customer dengan ID : " + RadGridView1.Rows(RadGridView1.CurrentCell.RowIndex).Cells("id_customer").Value.ToString & " " & _
                                RadGridView1.Rows(RadGridView1.CurrentCell.RowIndex).Cells("nama").Value.ToString, "Peringatan Konfirmasi Hapus Customer", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                                Try
                                    Me.Tabel_customerTableAdapter.DeleteQuery(CStr(RadGridView1.Rows(RadGridView1.CurrentCell.RowIndex).Cells("id_customer").Value))
                                    filter()
                                Catch ex As Exception
                                    Telerik.WinControls.RadMessageBox.Show("Tidak bisa menghapus customer : " & ex.Message, "Hapus Customer", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info)
                                End Try
                            End If
                        End If
                    End If
                ElseIf e.KeyCode = Keys.F5 Then
                    If RadGridView1.Rows(RadGridView1.CurrentRow.Index).Cells(1).Value.ToString <> "C-000-000" Then
                        RadGridView1.BeginEdit()
                    End If
                End If
            Else
                'aksesdenied()
            End If
        End If
    End Sub

    Private Sub RadGridView1_CellFormatting(sender As Object, e As Telerik.WinControls.UI.CellFormattingEventArgs) Handles RadGridView1.CellFormatting
        If e.ColumnIndex = 0 Then
            e.CellElement.Text = CStr(e.RowIndex + 1)
        End If
    End Sub

    Private Sub RadGridView1_CellEndEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellEndEdit
        Me.new_value = RadGridView1.CurrentCell.Text
        If new_value <> old_value Then
            If Telerik.WinControls.RadMessageBox.Show("Apakah Anda ingin mengubah data dari " & Me.old_value & " menjadi " & Me.new_value & " ?", "Konfirmasi Perubahaan Data", MessageBoxButtons.YesNo, Telerik.WinControls.RadMessageIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Select Case e.ColumnIndex
                    Case 2
                        Try
                            Me.Tabel_customerTableAdapter.UpdateQueryNamaCustomer(Me.new_value, CStr(RadGridView1.CurrentRow.Cells(1).Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 3
                        Try
                            Me.Tabel_customerTableAdapter.UpdateQueryAlamatCustomer(Me.new_value, CStr(RadGridView1.CurrentRow.Cells(1).Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 4
                        Try
                            Me.Tabel_customerTableAdapter.UpdateQueryKotaCustomer(Me.new_value, CStr(RadGridView1.CurrentRow.Cells(1).Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                    Case 5
                        Try
                            Me.Tabel_customerTableAdapter.UpdateQueryTelpCustomer(Me.new_value, CStr(RadGridView1.CurrentRow.Cells(1).Value))
                        Catch ex As Exception
                            Telerik.WinControls.RadMessageBox.Show(ex.Message, "Perubahaan Data Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Error)
                        End Try
                End Select
            Else
                RadGridView1.CurrentCell.Text = Me.old_value
            End If
        End If
        Me.old_value = ""
        Me.new_value = ""
    End Sub

    Private Sub RadGridView1_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles RadGridView1.CellDoubleClick
        If SettingAuthority.CustomerAndSupplier.EditCustomer = True Then
            If RadGridView1.Rows.Count <> 0 Then
                If e.ColumnIndex >= 2 And e.ColumnIndex <= 5 Then
                    If RadGridView1.Rows(e.RowIndex).Cells(1).Value.ToString <> "C-000-000" Then
                        RadGridView1.BeginEdit()
                    End If
                End If
            End If
        Else
            'aksesdenied()
        End If
    End Sub

    Private Sub RadGridView1_CellBeginEdit(sender As Object, e As Telerik.WinControls.UI.GridViewCellCancelEventArgs) Handles RadGridView1.CellBeginEdit
        Me.old_value = RadGridView1.CurrentCell.Text
    End Sub

    Private Sub FormListDataCustomer_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Using dt As DataTable = Me.Tabel_customerDistinctTableAdapter.GetData()
            Using dta As DataTable = Me.Tabel_customerTableAdapter.GetData()
                ID_ComboBox.MultiColumnComboBoxElement.Rows.Add("< semua >")
                For i As Integer = 0 To dta.Rows.Count - 1
                    ID_ComboBox.MultiColumnComboBoxElement.Rows.Add(dta.Rows(i).Item(0).ToString, dta.Rows(i).Item(1).ToString)
                Next
                Daerah_ComboBox.Items.Clear()
                Daerah_ComboBox.Items.Add("< semua >")
                For i As Integer = 0 To dt.Rows.Count - 1
                    Daerah_ComboBox.Items.Add(dt.Rows(i).Item(0).ToString)
                Next
                Thn_ComboBox.Items.Clear()
                Thn_ComboBox.Items.Add("< semua >")
                For i As Integer = Date.Today.Year To Date.Today.Year - 30 Step -1
                    Thn_ComboBox.Items.Add(i.ToString)
                Next
                Thn_ComboBox.SelectedIndex = Thn_ComboBox.Items(0).RowIndex
                ID_ComboBox.SelectedIndex = 0
                Daerah_ComboBox.SelectedIndex = Daerah_ComboBox.Items(0).RowIndex
                Bln_ComboBox.SelectedIndex = Bln_ComboBox.Items(0).RowIndex
            End Using
            Me.ID_ComboBox.EditorControl.MasterTemplate.FilterDescriptors.LogicalOperator = Telerik.WinControls.Data.FilterLogicalOperator.Or
        End Using
    End Sub

    Private Sub RadGridView1_ContextMenuOpening(sender As Object, e As Telerik.WinControls.UI.ContextMenuOpeningEventArgs) Handles RadGridView1.ContextMenuOpening
        If RadGridView1.CurrentCell.ColumnIndex = 2 Or RadGridView1.CurrentCell.ColumnIndex = 3 Or RadGridView1.CurrentCell.ColumnIndex = 4 Or RadGridView1.CurrentCell.ColumnIndex = 5 Then
            e.ContextMenu.Items(1).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
        End If
    End Sub
End Class