Imports System.Windows.Forms
Public Class FormDialogPeringatanPenjualan
    Property n As Integer
    Public array(n, 5) As String
    Dim tekan_tombol As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_ProsesForce.Click
        If SettingAuthority.PenjualanAndBarangMasuk.JualLebihStok = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            tekan_tombol = True
            Me.Close()
        Else
            Dim DialogPassword As New FormDialogPassword
            DialogPassword.tipe = FormDialogPassword.tipekonfirmasi.JualLebihStok
            If DialogPassword.ShowDialog = Windows.Forms.DialogResult.Yes Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                tekan_tombol = True
                DialogPassword.Dispose()
                CobaBersihkanMemori()
                Me.Close()
            End If
            DialogPassword.Dispose()
            CobaBersihkanMemori()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_QyMax.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        tekan_tombol = True
        Me.Close()
    End Sub

    Private Sub DialogPeringatanPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To n - 1
            If array(i, 1) <> vbNullString Then
                DataGridView1.Rows.Add(array(i, 0), array(i, 1), array(i, 2), array(i, 3), array(i, 4))
            End If
        Next
    End Sub

    Private Sub FormDialogPeringatanPenjualan_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If tekan_tombol = False Then
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End If
    End Sub
End Class
