Public Class FormCetakNotaOrder
    Public Property invoice As String
    Public Property banyak As Integer

    Property AutoPrint As Boolean = True


    ' Public Property ExtraOrdinary As Boolean

    Private Sub FormCetakNotaOrder_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        ReportNotaOrderBarang1.ReportParameters("div").Value = DivKoefisien
        ReportNotaOrderBarang1.ReportParameters("invoice").Value = invoice
        ReportNotaOrderBarang1.ReportParameters("banyak").Value = banyak - 2
        ReportViewer1.RefreshReport()

        If AutoPrint = True Then
            Dim reportproses As New Telerik.Reporting.Processing.ReportProcessor
            reportproses.PrintReport(Me.ReportViewer1.ReportSource, Nothing)
        End If
        'If ExtraOrdinary = False Then
        '    If IsServer = True Then
        '        SaveReport(ReportNotaOrderBarang1, My.Settings.FolderNota & "\NotaOrderBarang\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & invoice & ".pdf")
        '    Else
        '        SaveReport(ReportNotaOrderBarang1, "//" & Server & "\" & My.Settings.FolderNota & "\NotaOrderBarang\" & Date.Now.Year.ToString & "\" & Date.Now.Month.ToString & "\" & Date.Now.Day.ToString & "\" & invoice & ".pdf")
        '    End If
        'End If
    End Sub

    Private Sub FormCetakNotaOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
