Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.UI
Imports System.Configuration
Imports Telerik.WinControls
Imports Telerik.Reporting.Processing
Imports System.IO

Module ModuleProgramPenjualan
    Public FormUtama As FormMain
    Public stringconnect As String = CStr(My.MySettings.Default("tokoConnectionString"))
    Public AquaTheme As Themes.AquaTheme = New Themes.AquaTheme
    Public VisualStudioLightTheme As Themes.VisualStudio2012LightTheme = New Themes.VisualStudio2012LightTheme
    Public VisualStudioBlackTheme As Themes.VisualStudio2012DarkTheme = New Themes.VisualStudio2012DarkTheme
    Public MetroBlueTheme As Themes.TelerikMetroBlueTheme = New Themes.TelerikMetroBlueTheme
    Public MetroGreenTheme As Themes.TelerikMetroTheme = New Themes.TelerikMetroTheme
    Public BreezeTheme As Themes.BreezeTheme = New Themes.BreezeTheme
    Public DesertTheme As Themes.DesertTheme = New Themes.DesertTheme
    Public Office2010BlackTheme As Themes.Office2010BlackTheme = New Themes.Office2010BlackTheme
    Public Office2010BlueTheme As Themes.Office2010BlueTheme = New Themes.Office2010BlueTheme
    Public Office2010SilverTheme As Themes.Office2010SilverTheme = New Themes.Office2010SilverTheme
    Public Office2013LightTheme As Themes.Office2013LightTheme = New Themes.Office2013LightTheme
    Public Windows7Theme As Themes.Windows7Theme = New Themes.Windows7Theme
    Public Windows8Theme As Themes.Windows8Theme = New Themes.Windows8Theme
    Public Property DivKoefisien As DivCoef
    Public Property NamaToko As String
    Public Property Tema As String
    Public Property Server As String
    Public Property IsServer As Boolean
    Public Property KotaToko As String
    Public Property AlamatLengkapToko As String
    Public Property NopeToko As String
    Public Property CatatanKaki As String
    Public Property CatatanHeader As String
    Public Property LogoPerusahaan As Byte()
    Public Property NamaTokoShort As String
    Public Property SettingAuthority As HakAkses = New HakAkses
    Public Property SettingLabel As SetLabel = New SetLabel
    Public Property SettingPreferensi As SetPreferensi = New SetPreferensi

    Public connect As MySqlConnection
    Public Property StatusHakAkses As String
    Public Property StatusID As String
    Public tglNiHari_YMD As String = Date.Today.Year.ToString().Substring(2) + fix(Date.Today.Month.ToString()) + fix(Date.Today.Day.ToString())
    Public tgltoday As String = Date.Today.Year.ToString() + "-" + fix(Date.Today.Month.ToString()) + "-" + fix(Date.Today.Day.ToString())
    Public bulanToday As String = AngkaToBulan(Date.Today.Month)
    Public Sub inisiasi_tema()

    End Sub

    Private Function fix(ByVal s As String) As String
        Select Case s.ToString().Length
            Case 1
                Return "0" + s
            Case 2
                Return "" + s
            Case Else
                Return s
        End Select
    End Function

    Public Function BulanToAngka(ByVal s As String) As String
        Select Case s
            Case "Januari"
                Return "01"
            Case "Februari"
                Return "02"
            Case "Maret"
                Return "03"
            Case "April"
                Return "04"
            Case "Mei"
                Return "05"
            Case "Juni"
                Return "06"
            Case "Juli"
                Return "07"
            Case "Agustus"
                Return "08"
            Case "September"
                Return "09"
            Case "Oktober"
                Return "10"
            Case "November"
                Return "11"
            Case "Desember"
                Return "12"
        End Select
        Return ""
    End Function

    Public Function AngkaToBulan(ByVal b As Integer) As String
        Select Case b
            Case 1
                Return "Januari"
            Case 2
                Return "Februari"
            Case 3
                Return "Maret"
            Case 4
                Return "April"
            Case 5
                Return "Mei"
            Case 6
                Return "Juni"
            Case 7
                Return "Juli"
            Case 8
                Return "Agustus"
            Case 9
                Return "September"
            Case 10
                Return "Oktober"
            Case 11
                Return "November"
            Case 12
                Return "Desember"
        End Select
        Return ""
    End Function

    Public Function ubahtocurrency(ByVal format_awal As String) As String
        If DivKoefisien = DivCoef._1 Then
            Return FormatNumber(format_awal, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        Else
            Return FormatNumber(format_awal, 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        End If
    End Function

    Public Function ubahtocurrencybyDiv(ByVal format_awal As String) As String
        If DivKoefisien = DivCoef._1 Then
            Return FormatNumber(CDbl(format_awal) / 1000, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        Else
            Return FormatNumber(format_awal, 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        End If
    End Function

    Public Function ubahAwalbeforeDiv(ByVal format_awal As String)
        If DivKoefisien = DivCoef._1 Then
            Return FormatNumber((format_awal * 1000), 0, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        End If
        Return format_awal
    End Function

    Public Function Desimal()
        If DivKoefisien = DivCoef._1 Then
            Return 2
        Else
            Return 0
        End If
    End Function

    Public Function CapitalizeEachWord(ByVal teksbox As String) As String
        Dim kata As Char() = teksbox.ToCharArray()
        Dim fix As String = ""
        For i = 0 To kata.Length - 1
            If i = 0 Then
                kata(i) = CChar(kata(i).ToString.ToUpper)
            End If
            If i <> 0 Then
                If kata(i - 1) = " " Then
                    kata(i) = CChar(kata(i).ToString.ToUpper)
                Else
                    kata(i) = CChar(kata(i).ToString.ToLower)
                End If
            End If
            fix = fix + kata(i)
        Next
        Return fix
    End Function

    Public Function toBoolean(ByVal n As Integer) As Boolean
        If n = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function toInt(ByVal s As Boolean) As Short
        If s = True Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Sub aksesdenied()
        RadMessageBox.Show(StatusHakAkses & " tidak mempunyai hak.", "Akses ditolak", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
    End Sub

    Public Function enkripsi_simple(ByVal harga_grosir As Integer) As String
        Dim tabel_enkripsi As tokoDataSetTableAdapters.tabel_enkripsiTableAdapter = New tokoDataSetTableAdapters.tabel_enkripsiTableAdapter
        Dim dt As DataTable = tabel_enkripsi.GetData()
        Dim pn As String = CStr((harga_grosir / 1000))
        'MessageBox.Show(pn)
        Dim arr() As Char = pn.ToCharArray
        'MessageBox.Show(arr.Length)
        Dim ct As String = ""
        Dim koma As Boolean = False
        Dim selesai As Boolean = False
        For i = 0 To arr.Length - 1
            If selesai = False Then
                'MessageBox.Show(i & " - " & arr(i) & " " & selesai)
                If arr(i) = "." Then
                    koma = True
                End If
                'MessageBox.Show("koma" & koma)
                If koma = True Then
                    If arr(i) = "5" Then
                        ct = ct + dt.Rows(0).Item("0,5").ToString
                        selesai = True
                    ElseIf arr(i) <> "." Then
                        selesai = True
                    End If
                Else
                    Select Case arr(i)
                        Case CChar("0")
                            ct = ct + dt.Rows(0).Item("0").ToString
                        Case CChar("1")
                            ct = ct + dt.Rows(0).Item("1").ToString
                        Case CChar("2")
                            ct = ct + dt.Rows(0).Item("2").ToString
                        Case CChar("3")
                            ct = ct + dt.Rows(0).Item("3").ToString
                        Case CChar("4")
                            ct = ct + dt.Rows(0).Item("4").ToString
                        Case CChar("5")
                            ct = ct + dt.Rows(0).Item("5").ToString
                        Case CChar("6")
                            ct = ct + dt.Rows(0).Item("6").ToString
                        Case CChar("7")
                            ct = ct + dt.Rows(0).Item("7").ToString
                        Case CChar("8")
                            ct = ct + dt.Rows(0).Item("8").ToString
                        Case CChar("9")
                            ct = ct + dt.Rows(0).Item("9").ToString
                    End Select
                End If
            End If
        Next
        Return ct
    End Function

    Public Sub CreateConfig()
        My.Settings.Server = System.Net.Dns.GetHostName
        Server = My.Settings.Server
        My.Settings.Save()
    End Sub

    Public Sub ChangeTheme(ByVal theme As String)
        Select Case theme
            Case "TelerikMetro"
                ThemeResolutionService.ApplicationThemeName = "TelerikMetro"
                FormUtama.Panel3.BackColor = System.Drawing.Color.FromArgb(145, 185, 11)
            Case "Office2010Black"
                ThemeResolutionService.ApplicationThemeName = "Office2010Black"
                FormUtama.Panel3.BackColor = Color.White
            Case "TelerikMetroBlue"
                ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue"
                FormUtama.Panel3.BackColor = System.Drawing.Color.FromArgb(114, 209, 255)
            Case "Office2010Blue"
                ThemeResolutionService.ApplicationThemeName = "Office2010Blue"
                FormUtama.Panel3.BackColor = Color.Transparent
            Case "Office2010Silver"
                ThemeResolutionService.ApplicationThemeName = "Office2010Silver"
                FormUtama.Panel3.BackColor = Color.Transparent
            Case "Aqua"
                ThemeResolutionService.ApplicationThemeName = "Aqua"
                FormUtama.Panel3.BackColor = Color.Transparent
            Case "Breeze"
                ThemeResolutionService.ApplicationThemeName = "Breeze"
                FormUtama.Panel3.BackColor = Color.Transparent
            Case "Desert"
                ThemeResolutionService.ApplicationThemeName = "Desert"
                FormUtama.Panel3.BackColor = Color.Transparent
            Case "VisualStudio2012Light"
                ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light"
                FormUtama.Panel3.BackColor = Color.Transparent
            Case "VisualStudio2012Dark"
                ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark"
                FormUtama.Panel3.BackColor = Color.White
            Case "Office2013Light"
                ThemeResolutionService.ApplicationThemeName = "Office2013Light"
                FormUtama.Panel3.BackColor = Color.White
            Case "Windows7"
                ThemeResolutionService.ApplicationThemeName = "Windows7"
                FormUtama.Panel3.BackColor = Color.White
            Case "Windows8"
                ThemeResolutionService.ApplicationThemeName = "Windows8"
                FormUtama.Panel3.BackColor = Color.White
        End Select
    End Sub

    Public Sub ReadConfig()
        Server = My.Settings.Server
        Tema = My.Settings.Tema
        IsServer = My.Settings.IsServer
    End Sub

    Public Sub SimpanConfig(ByVal newtheme As String, ByVal newserver As String, ByVal newisserver As Boolean)
        With My.Settings
            .Server = newserver
            .IsServer = newisserver
            .Tema = newtheme
            .Save()
        End With
    End Sub

    Public Sub SaveReport(report As Telerik.Reporting.Report, fileName As String)
        Dim reportProcessor As New ReportProcessor()
        Dim instanceReportSource As New Telerik.Reporting.InstanceReportSource()
        instanceReportSource.ReportDocument = report
        Dim result As RenderingResult = reportProcessor.RenderReport("PDF", instanceReportSource, Nothing)
        Do
            Try
                Using fs As New FileStream(fileName, FileMode.Create)
                    fs.Write(result.DocumentBytes, 0, result.DocumentBytes.Length)
                End Using
                Exit Do
            Catch ex As Exception
                If RadMessageBox.Show("Apakah " & fileName & " sedang digunakan? Pastikan tidak ada proses yang menggunakan file tersebut. Dan coba lagi", "File tidak dapat disimpan", MessageBoxButtons.RetryCancel, RadMessageIcon.Error) = DialogResult.Cancel Then
                    Exit Do
                End If
            End Try
        Loop
    End Sub

    Public Sub CobaBersihkanMemori()
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    'Private tabel_preferensi_penjualanTableAdapter As Program_Penjualan_V2.tokoDataSetTableAdapters.tabel_preferensi_penjualanTableAdapter
    Public Sub LoadPreferensiPenjualanFromDatabase()
        Using tabel_preferensi_penjualanTableAdapter = New tokoDataSetTableAdapters.tabel_preferensi_penjualanTableAdapter
            Using dt As DataTable = tabel_preferensi_penjualanTableAdapter.GetData
                If dt.Rows.Count > 0 Then
                    SettingPreferensi.Penjualan.IDCustomer = dt.Rows(0).Item("id_customer")
                    SettingPreferensi.Penjualan.Sales = dt.Rows(0).Item("sales")
                    SettingPreferensi.Penjualan.AutoPrint = dt.Rows(0).Item("autoprint")
                    SettingPreferensi.Penjualan.Diskon1 = dt.Rows(0).Item("diskon1")
                    SettingPreferensi.Penjualan.Diskon2 = dt.Rows(0).Item("diskon2")
                    SettingPreferensi.Penjualan.Diskon3 = dt.Rows(0).Item("diskon3")
                    SettingPreferensi.Penjualan.Diskon4 = dt.Rows(0).Item("diskon4")
                    SettingPreferensi.Penjualan.IsAutoDiskon = dt.Rows(0).Item("isautodiskon")
                    SettingPreferensi.Penjualan.AutoDiskon = dt.Rows(0).Item("diskonauto")
                    SettingPreferensi.Penjualan.HeaderSmallNota = dt.Rows(0).Item("headersmall") & ""
                    SettingPreferensi.Penjualan.FooterSmallNota = dt.Rows(0).Item("footersmall") & ""
                End If
            End Using
        End Using
    End Sub

    Public Sub LoadPreferensiBarangMasukFromDatabase()
        Using tabel_preferensi_brgmasukTableAdapter = New tokoDataSetTableAdapters.tabel_preferensi_brgmasukTableAdapter
            Using dt As DataTable = tabel_preferensi_brgmasukTableAdapter.GetData
                If dt.Rows.Count > 0 Then
                    SettingPreferensi.BarangMasuk.IDSupplier = dt.Rows(0).Item("id_supplier")
                    SettingPreferensi.BarangMasuk.AutoTipeBarang = dt.Rows(0).Item("autotipebarang")
                    SettingPreferensi.BarangMasuk.Tertentu = dt.Rows(0).Item("tertentu") & ""
                    SettingPreferensi.BarangMasuk.IsiHargaRetail = dt.Rows(0).Item("isihargaretail")
                    SettingPreferensi.BarangMasuk.AutoRetail = dt.Rows(0).Item("autoretail")
                    SettingPreferensi.BarangMasuk.KertasLabel = dt.Rows(0).Item("kertaslabel")
                End If
            End Using
        End Using
    End Sub

    Public Sub LoadPreferensiOrderFromDatabase()
        Using tabel_preferensi_orderTableAdapter = New tokoDataSetTableAdapters.tabel_preferensi_orderTableAdapter
            Using dt As DataTable = tabel_preferensi_orderTableAdapter.GetData
                If dt.Rows.Count > 0 Then
                    SettingPreferensi.Order.IDCustomer = dt.Rows(0).Item("id_customer")
                    SettingPreferensi.Order.Sales = dt.Rows(0).Item("sales")
                    SettingPreferensi.Order.Nota = dt.Rows(0).Item("nota")
                End If
            End Using
        End Using
    End Sub

    Public Sub LoadDivKoefisien()
        Using tabel_enkripsi As tokoDataSetTableAdapters.tabel_enkripsiTableAdapter = New tokoDataSetTableAdapters.tabel_enkripsiTableAdapter
            Using dt As DataTable = tabel_enkripsi.GetData()
                DivKoefisien = CInt(dt.Rows(0).Item("div"))
            End Using
        End Using
    End Sub

    Enum DivCoef
        _1 = 1
        _1000 = 1000
    End Enum


    Public Function BanyakBarisNota(rows As Integer)
        Dim banyak As Integer = 0
        Dim N As Integer = rows \ 25
        If rows <= (N * 25) + 17 Then
            banyak = (17 + (25 * N)) - rows
        Else
            N += 1
            banyak = (17 + (25 * N)) - rows
        End If
        Return banyak
    End Function

End Module

Public Class SetPreferensi
    Public Property Penjualan As New SettingPreferensiPenjualan
    Public Property BarangMasuk As New SettingPreferensiBrgMasuk
    Public Property Order As New SettingPreferensiOrder
End Class

Public Class SettingPreferensiPenjualan
    Property IDCustomer As String
    Property Sales As String
    Property AutoPrint As String
    Property Diskon1 As Integer
    Property Diskon2 As Integer
    Property Diskon3 As Integer
    Property Diskon4 As Integer
    Property IsAutoDiskon As Boolean
    Property AutoDiskon As Integer
    Property HeaderSmallNota As String
    Property FooterSmallNota As String

End Class

Public Class SettingPreferensiBrgMasuk
    Property IDSupplier As String
    Property AutoTipeBarang As String
    Property Tertentu As String
    Property IsiHargaRetail As String
    Property AutoRetail As Integer
    Property KertasLabel As String
End Class

Public Class SettingPreferensiOrder
    Property IDCustomer As String
    Property Sales As String
    Property Nota As String
End Class

Public Class SetLabel
    Public Property StatNamaPerusahaan As Boolean
    Public Property LogoPerusahaan As Boolean
    Public Property NamaBarang As Boolean
    Public Property IDBarang As Boolean
    Public Property Barcode As Boolean
    Public Property HargaGrosirEnkripsi As Boolean
    Public Property HargaRetail As Boolean
    Public Property NamaPerusahaan As String
End Class

