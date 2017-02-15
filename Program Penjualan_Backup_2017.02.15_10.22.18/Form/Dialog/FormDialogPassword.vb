Public Class FormDialogPassword
    Enum tipekonfirmasi
        ReturPenjualan = 0
        JualLebihStok = 1
        Keluar = 2
    End Enum
    Property tipe As New tipekonfirmasi
    Private klik As Boolean = False
    Private Sub FormDialogPassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_user()
        RadTextBox1.Text = ""
    End Sub

    Private Sub load_user()
        RadDropDownList1.Items.Clear()
        If tipe = tipekonfirmasi.ReturPenjualan Then
            Using dt = Tabel_user_via_set_authorityTableAdapter1.GetDataByWithReturPenjualan()
                For i = 0 To dt.Rows.Count - 1
                    RadDropDownList1.Items.Add(dt.Rows(i).Item("id").ToString)
                Next
            End Using
        ElseIf tipe = tipekonfirmasi.JualLebihStok Then
            Using dt = Tabel_user_via_set_authorityTableAdapter1.GetDataByWithJualLebihStok()
                For i = 0 To dt.Rows.Count - 1
                    RadDropDownList1.Items.Add(dt.Rows(i).Item("id").ToString)
                Next
            End Using
        Else
            Using dt = Tabel_user_via_set_authorityTableAdapter1.GetDataByTutupCounter()
                For i = 0 To dt.Rows.Count - 1
                    RadDropDownList1.Items.Add(dt.Rows(i).Item("id").ToString)
                Next
            End Using
        End If
    End Sub

    Private Sub login()
        Try
            Using dt = Tabel_user_via_set_authorityTableAdapter1.GetDataBy(RadDropDownList1.Text, RadTextBox1.Text)
                If dt.Rows.Count = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.Yes
                    klik = True
                    Me.Close()
                Else
                    Telerik.WinControls.RadMessageBox.Show("Username atau Password yang dimasukkan salah!!!", "Peringatan", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Exclamation)
                    RadDropDownList1.Text = ""
                    RadTextBox1.Text = ""
                    RadDropDownList1.SelectAllText()
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadButton1_Click(sender As System.Object, e As System.EventArgs) Handles RadButton1.Click
        login()
    End Sub

    Private Sub FormDialogPassword_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If klik = False Then
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If
    End Sub

    Private Sub RadTextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RadTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class
