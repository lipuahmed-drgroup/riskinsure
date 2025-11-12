Imports DGVCopyNS.DGVCopyClass
Public Class ReconDigiMob


    Private Sub ReconDigiMob_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            Me.ReconDigiMobTableAdapter.Fill(Me.ReconciliationDataSet.ReconDigiMob, StartDate, EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "ReconDigiMob_Load()")
        End Try
    End Sub

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(Me.UndockButton, Me)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(ReconDigiMobDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class