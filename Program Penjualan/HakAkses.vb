Public Class HakAkses
    Public Sub New()
    End Sub
    Public Property SettingCounter As SettingCounter = New SettingCounter
    Public Property ManagementDB As ManajemenDB = New ManajemenDB
    Public Property LogActivity As Boolean = New Boolean
    Public Property CustomerAndSupplier As CustomerSupplier = New CustomerSupplier
    Public Property Product As Produk = New Produk
    Public Property PenjualanAndBarangMasuk As PenjualanBarangMasuk = New PenjualanBarangMasuk
    Public Property Laporan As Laporan = New Laporan
    Public Property TutupCounter As Boolean = New Boolean
End Class

Public Class SettingCounter
    Public Sub New()
    End Sub
    Public Property UbahInfoPerusahaan As Boolean
    Property TambahSales As Boolean
    Property EditHapusSales As Boolean
    Property TambahTipeBarang As Boolean
    Property EditHapusTipeBarang As Boolean
    Property SettingLabel As Boolean
    Property Tema As Boolean
    Property ClientServer As Boolean
End Class

Public Class ManajemenDB
    Public Sub New()
    End Sub
    Property BackupDB As Boolean
    Property RestoreDB As Boolean
    Property ExportDB As Boolean
    Property ImportDB As Boolean
End Class

Public Class CustomerSupplier
    Public Sub New()
    End Sub
    Property TambahCustomer As Boolean
    Property LihatDataCustomer As Boolean
    Property EditCustomer As Boolean
    Property PrintDataCustomer As Boolean
    Property TambahSupplier As Boolean
    Property LihatDataSupplier As Boolean
    Property EditSupplier As Boolean
    Property PrintDataSupplier As Boolean
End Class

Public Class Produk
    Public Sub New()
    End Sub
    Property LihatDataProduk As Boolean
    Property EditDataProduk As Boolean
    Property PrintDataProduk As Boolean
    Property LihatProfit As Boolean
    Property LihatTotalPersediaan As Boolean
    Property CetakLabel As Boolean
    Property EditModalTerjualProfit As Boolean
End Class

Public Class PenjualanBarangMasuk
    Public Sub New()
    End Sub
    Property PenjualanNormal As Boolean
    Property PenjualanFast As Boolean
    Property PenjualanOrder As Boolean
    Property BarangMasuk As Boolean
    Property TipePenjualanGrosir As Boolean
    Property TipePenjualanRetail As Boolean
    Property DiskonPenjualan As Boolean
    Property ReturPenjualan As Boolean
    Property HutangCustomer As Boolean
    Property JualLebihStok As Boolean
End Class

Public Class Laporan
    Public Sub New()
    End Sub
    Property LaporanPenjualanHarian As Boolean
    Property LaporanDetailPenjualan As Boolean
    Property LaporanPenjualanAll As Boolean
    Property LaporanPenjualanFilter As Boolean
    Property LaporanProfit As Boolean
    Property LaporanBarangMasukAll As Boolean
    Property LaporanBarangMasukFilter As Boolean
    Property LaporanHutangCustomer As Boolean
    Property LaporanBestSellerProfit As Boolean
    Property CetakLaporan As Boolean
    Property SeleksiTanggalLaporan As Boolean
End Class

