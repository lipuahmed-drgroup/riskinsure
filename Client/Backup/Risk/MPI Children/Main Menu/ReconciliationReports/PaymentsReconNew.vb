Imports DGVCopyNS.DGVCopyClass
Public Class PaymentsReconNew

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(UndockButton, Me)
    End Sub

    Private Sub PaymentsReconNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            Me.ReconPaymentsNEWTableAdapter.Fill(Me.ReconciliationDataSet.ReconPaymentsNEW, StartDate, EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "PaymentsReconNew_Load()")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(ReconPaymentsNEWDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class