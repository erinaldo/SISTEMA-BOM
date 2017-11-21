Imports System.Windows.Forms
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports System.Configuration

Public Class FormDialogLogin

    Private configreader As StreamReader
    Private configwriter As StreamWriter

    Dim first_error As Boolean = False
    Private Function cek() As Boolean
        Try
            If (Tabel_userTableAdapter.CekIDTersedia(TextBox_Username.Text, TextBox_Password.Text) = 1) Then
                Using dt As DataTable = Tabel_userTableAdapter.GetDataByIDandPass(TextBox_Username.Text, TextBox_Password.Text)
                    StatusID = CStr(dt.Rows(0).Item("id"))
                    StatusHakAkses = CStr(dt.Rows(0).Item("hak_user"))
                End Using
                first_error = False
                Return True
            End If
        Catch ex As Exception
            RadMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            TextBox_Username.Text = ""
            TextBox_Password.Text = ""
            TextBox_Username.Focus()
            first_error = True
        End Try
        Return False
    End Function

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'tutup form ketika tombol cancel ditekan
        Me.Close()
    End Sub

    Private Sub DialogLogin_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        FormUtama = New FormMain
        ReadConfig()
        ChangeTheme(Tema)
        'CekDirektori()
    End Sub

    Friend Sub CekDirektori()
        If IsServer = True Then
            If System.IO.Directory.Exists(My.Settings.FolderNota & "\NotaPenjualan\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString) = False Then
                System.IO.Directory.CreateDirectory(My.Settings.FolderNota & "\NotaPenjualan\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString)
            End If
            If System.IO.Directory.Exists(My.Settings.FolderNota & "\NotaOrderBarang\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString) = False Then
                System.IO.Directory.CreateDirectory(My.Settings.FolderNota & "\NotaOrderBarang\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString)
            End If
            If System.IO.Directory.Exists(My.Settings.FolderNota & "\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString) = False Then
                System.IO.Directory.CreateDirectory(My.Settings.FolderNota & "\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString)
            End If
        End If
    End Sub

    Private Sub login()
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        'Try
        Dim cek_dulu As Boolean = cek()
        If cek_dulu = True And first_error = False Then
            FormUtama.Label_StatusID.Text = StatusID
            FormUtama.Label_StatusHak.Text = "as " & StatusHakAkses
            Me.tabel_log.InsertQuery(StatusID, "Login", "Login")
            Me.Hide()
            FormUtama.ShowDialog()
            FormUtama.Dispose()
            CobaBersihkanMemori()
            Me.Close()
        ElseIf cek_dulu = False And first_error = False Then
            Telerik.WinControls.RadMessageBox.Show("Username dan password yang Anda masukkan salah. Silahkan hubungi administrator untuk dapat login", "Program Penjualan", MessageBoxButtons.OK, RadMessageIcon.Info)
            TextBox_Username.Text = ""
            TextBox_Password.Text = ""
            TextBox_Username.Focus()
        End If
        ' Catch ex As Exception
        'Telerik.WinControls.RadMessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, RadMessageIcon.Error)
        'TextBox_Username.Text = ""
        'TextBox_Password.Text = ""
        'TextBox_Username.Focus()
        'End Try
        first_error = False
        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Me.Close()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        login()
    End Sub

    Private Sub TextBox_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub cek_customer()
        If CInt(Tabel_customerTableAdapter.ScalarQueryReturnID("C-000-000")) = 0 Then
            Tabel_customerTableAdapter.InsertQuery("C-000-000", "Cash", "Cash", "Cash", CStr(0), 0, "Cash", CDate("0100-1-1"))
        End If
    End Sub

    Private Sub cek_sales()
        If Tabel_salesTableAdapter1.ScalarQueryReturnNama("< Kasir >") = 0 Then
            Tabel_salesTableAdapter1.InsertQuery("< Kasir >", "Kasir", Now, CStr(0), Now, "N")
        End If
    End Sub

    Private Sub cek_user()
        If CInt(Me.Tabel_userTableAdapter.cekID("admin", "")) = 0 Then
            Me.Tabel_userTableAdapter.InsertQuery("admin", "admin", "Owner")
        End If
    End Sub

    Private Sub cek_supplier()
        Using tbl_supplier As New tokoDataSetTableAdapters.tabel_supplierTableAdapter
            If CInt(tbl_supplier.CekSupplier) = 0 Then
                tbl_supplier.InsertQuery("S-000-000", "< Supplier >", "Supplier", "Supplier", "-", "Data supplier bawaaan", Now)
            End If
        End Using
    End Sub

    Private Sub cek_preferennsi_penjualan()
        Using tbl_preferensi_penjualan As New tokoDataSetTableAdapters.tabel_preferensi_penjualanTableAdapter
            If CInt(tbl_preferensi_penjualan.CekKetersediaan) = 0 Then
                tbl_preferensi_penjualan.InsertData(1, "C-000-000", "< Kasir >", "Harap diisi terlebih dahulu", "Harap diisi terlebih dahulu")
            End If
        End Using
    End Sub

    Private Sub cek_preferennsi_order()
        Using tbl_preferensi_order As New tokoDataSetTableAdapters.tabel_preferensi_orderTableAdapter
            If CInt(tbl_preferensi_order.CekKetersediaan) = 0 Then
                tbl_preferensi_order.InsertData(1, "C-000-000", "< Kasir >")
            End If
        End Using
    End Sub

    Private Sub cek_preferennsi_brgmasuk()
        Using tbl_preferensi_brgmasuk As New tokoDataSetTableAdapters.tabel_preferensi_brgmasukTableAdapter
            If CInt(tbl_preferensi_brgmasuk.CekKetersediaan) = 0 Then
                tbl_preferensi_brgmasuk.InsertData(1, "S-000-000")
            End If
        End Using
    End Sub



    Private Sub FormDialogLogin_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            cek_customer()
            cek_sales()
            cek_user()
            cek_supplier()
            cek_preferennsi_penjualan()
            cek_preferennsi_order()
            cek_preferennsi_brgmasuk()
            Using dt As DataTable = Tabel_userTableAdapter.GetData()
                For i = 0 To dt.Rows.Count - 1
                    TextBox_Username.Items.Add(dt.Rows(i).Item("id").ToString)
                Next
                TextBox_Username.Text = ""
            End Using
        Catch ex As Exception
            Telerik.WinControls.RadMessageBox.Show("Aplikasi belum terhubung ke Database  Server atau perangkat jaringan anda bermasalah !!", "Tidak Bisa Terhubung ke Server", MessageBoxButtons.OK, RadMessageIcon.Error)
            Me.Close()
        End Try
        If My.Settings.Server = "-1" Then
            CreateConfig()

        End If
    End Sub
End Class
