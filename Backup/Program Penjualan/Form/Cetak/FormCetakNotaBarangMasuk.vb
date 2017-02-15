Public Class FormCetakNotaBarangMasuk
    Public Property Invoice As String
    'Shared Property Banyak As Integer
    Public Property Kota As String

    'Public Property ExtraOrdinary As Boolean

    Private Sub FormCetakNotaBarangMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub FormCetakNotaBarangMasuk_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.ReportNotaMasuk1.ReportParameters("div").Value = DivKoefisien
        Me.ReportNotaMasuk1.ReportParameters("invoice").Value = Invoice
        'Me.ReportNotaMasuk1.ReportParameters("banyak").Value = Banyak
       Me.ReportViewer1.RefreshReport()
        'If ExtraOrdinary = False Then
        '    If IsServer = True Then
        '        SaveReport(ReportNotaMasuk1, My.Settings.FolderNota & "\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & Invoice & ".pdf")
        '    Else
        '        SaveReport(ReportNotaMasuk1, "//" & Server & "\Data\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & Invoice & ".pdf")
        '    End If
        'End If
        'If IsServer = True Then
        '    SaveReport(ReportNotaMasuk1, My.Settings.FolderNota & "\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & Invoice & ".pdf")
        'Else
        '    SaveReport(ReportNotaMasuk1, "//" & Server & "\Data\NotaMasuk\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & Invoice & ".pdf")
        'End If

    End Sub
End Class