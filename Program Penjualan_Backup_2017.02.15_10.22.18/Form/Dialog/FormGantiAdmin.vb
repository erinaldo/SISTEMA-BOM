Public Class FormGantiAdmin

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        login()
    End Sub

    Private Sub login()
        Using dt As DataTable = Me.Tabel_userTableAdapter1.GetDataByIDandPass(RadTextBox1.Text, RadTextBox2.Text)
            If dt.Rows.Count <> 0 Then
                StatusID = CStr(dt.Rows(0).Item("id"))
                StatusHakAkses = CStr(dt.Rows(0).Item("hak_user"))
                FormUtama.Label_StatusID.Text = StatusID
                FormUtama.Label_StatusHak.Text = "as " & StatusHakAkses
                FormUtama.cek_Authority()
                Me.Close()
            Else
                Telerik.WinControls.RadMessageBox.Show("Password yang diinputkan salah!!", "Ganti Admin Gagal", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Exclamation)
                RadTextBox2.Text = ""
                RadTextBox1.Text = ""
                RadTextBox1.Focus()
            End If
        End Using
    End Sub

    Private Sub FormGantiAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using dt As DataTable = Me.Tabel_userTableAdapter1.GetDataExceptID(StatusID)
            For i = 0 To dt.Rows.Count - 1
                RadTextBox1.Items.Add(dt.Rows(i).Item("id").ToString)
            Next
            RadTextBox1.Text = "Masukkan Username"
        End Using
    End Sub

    Private Sub RadTextBox2_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RadTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class
