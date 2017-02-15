Public Class FormLogAktivitas

    Private Sub FormLogAktivitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoDataSet.tabel_log' table. You can move, or remove it, as needed.


    End Sub

    Private Sub FormLogAktivitas_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.Tabel_logTableAdapter.Fill(Me.TokoDataSet.tabel_log)
    End Sub
End Class
