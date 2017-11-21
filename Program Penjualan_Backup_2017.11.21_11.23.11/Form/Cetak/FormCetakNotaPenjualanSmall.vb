Public Class FormCetakNotaPenjualanSmall

    Public Property invoice As String

    Public Property ExtraOrdinary As Boolean = False

    Private Sub FormCetakNotaPenjualanSmall_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormCetakNotaPenjualanSmall_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.ReportNotaPenjualanSmall1.ReportParameters("div").Value = DivKoefisien
        Me.ReportNotaPenjualanSmall1.ReportParameters("invoice").Value = invoice
        Me.ReportNotaPenjualanSmall1.ReportParameters("header").Value = SettingPreferensi.Penjualan.HeaderSmallNota
        Me.ReportNotaPenjualanSmall1.ReportParameters("footer").Value = SettingPreferensi.Penjualan.FooterSmallNota
        ' Me.ReportNotaPenjualanSmall1.ReportParameters("tanggal").Value = Kota & ", " & Format(Date.Now, "dd MMM yyyy (HH:mm)")
        Me.ReportViewer1.RefreshReport()
        If ExtraOrdinary = False Then
            'If IsServer = True Then
            '    SaveReport(ReportNotaPenjualanSmall1, My.Settings.FolderNota & "\NotaPenjualan\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & invoice & ".pdf")
            'Else
            '    SaveReport(ReportNotaPenjualanSmall1, "//" & Server & "\" & My.Settings.FolderNota & "\NotaPenjualan\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & invoice & ".pdf")
            'End If
            If SettingPreferensi.Penjualan.AutoPrint = "AutoSmall" Then
                Dim reportproses As New Telerik.Reporting.Processing.ReportProcessor
                Dim printsetting As New System.Drawing.Printing.PrinterSettings
                Dim standardPrintController As New System.Drawing.Printing.StandardPrintController
                reportproses.PrintController = standardPrintController
                reportproses.PrintReport(Me.ReportViewer1.ReportSource, printsetting)
            ElseIf SettingPreferensi.Penjualan.AutoPrint = "BigNota" Then
                Dim reportproses As New Telerik.Reporting.Processing.ReportProcessor
                Dim printsetting As New System.Drawing.Printing.PrinterSettings
                Dim standardPrintController As New System.Drawing.Printing.StandardPrintController
                reportproses.PrintController = standardPrintController
                reportproses.PrintReport(Me.ReportViewer1.ReportSource, printsetting)
            End If
            'Me.ReportViewer1.PrintReport()
            End If
    End Sub
End Class
