Imports Telerik.WinControls

Public Class FormInputIDManual

    Public Property KodeBarangFix As String
    Public Property TipeBarang As String

    Public Property StatusBarang As StatusKodeBarang

    Enum StatusKodeBarang
        Baru
        Lama
    End Enum
    Enum StateForm
        StateCheck
        StateOK
    End Enum

    Private StatesForm As StateForm
    Private KodeTipe As String


    Private Sub FormInputIDManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatesForm = StateForm.StateCheck
        RadMaskedEditBox1.Focus()
        RadMaskedEditBox1.SelectionLength = 0
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        If StatesForm = StateForm.StateCheck Then
            If RadMaskedEditBox1.Text.Contains(" ") Then
                RadMessageBox.Show("Kode barang belum terisi sempurna. Harap isi kode barang dengan benar.", "Kode Barang Tidak Lengkap", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Else
                status_tipebarang.Text = Tabel_tipe_barangTableAdapter1.ScalarQueryLihatTipe(RadMaskedEditBox1.Text.Substring(0, 3)) & ""
                If status_tipebarang.Text = "" Then
                    status_tipebarang.Text = "Tipe Barang"
                    status_status.Text = "ID Barang yg anda inputkan tidak sesuai dengan Tipe Barang apapun !"
                    RadMaskedEditBox1.Focus()
                    RadMaskedEditBox1.SelectionLength = 0
                Else
                    Using dt = Tabel_barangTableAdapter1.GetDataByKodeBarang(RadMaskedEditBox1.Text)
                        If dt.Count = 0 Then
                            status_status.Text = "ID Barang belum ada, gunakan ID Barang Baru ?"
                            RadButton1.Text = "Enter"
                            RadMaskedEditBox1.Enabled = False
                            StatesForm = StateForm.StateOK
                            StatusBarang = StatusKodeBarang.Baru
                        Else
                            status_status.Text = "ID Barang sudah ada, gunakan ID Barang Lama ?"
                            RadButton1.Text = "Enter"
                            RadMaskedEditBox1.Enabled = False
                            StatesForm = StateForm.StateOK
                            StatusBarang = StatusKodeBarang.Lama
                        End If
                    End Using
                End If
            End If
        ElseIf StatesForm = StateForm.StateOK Then
            KodeBarangFix = RadMaskedEditBox1.Text
            TipeBarang = status_tipebarang.Text
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            Me.Close()
        End If
    End Sub

    Private Sub RadLabel4_Click(sender As Object, e As EventArgs) Handles RadLabel4.Click
        RadMaskedEditBox1.Text = "   -      "
        status_status.Text = "Status"
        status_tipebarang.Text = "Tipe Barang"
        StatesForm = StateForm.StateCheck
        RadMaskedEditBox1.Enabled = True
        RadButton1.Text = "Check"
        RadMaskedEditBox1.Focus()
        RadMaskedEditBox1.SelectionLength = 0
    End Sub
End Class