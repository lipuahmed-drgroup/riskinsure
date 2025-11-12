Imports DGVCopyNS.DGVCopyClass
Public Class ReconB



    Private Sub ReconB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            Me.ReconBTableAdapter.Fill(Me.ReconciliationDataSet.ReconB, StartDate, EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "ReconB_Load()")
        End Try
    End Sub

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(UndockButton, Me)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(ReconBDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class