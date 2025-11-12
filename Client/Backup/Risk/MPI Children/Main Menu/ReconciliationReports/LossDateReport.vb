Imports DGVCopyNS.DGVCopyClass
Public Class LossDateReport

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(UndockButton, Me)
    End Sub

    Private Sub LossDateReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            Me.LossDateReportTableAdapter.Fill(Me.ReconciliationDataSet.LossDateReport, StartDate, EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "LossDateReport_Load()")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(LossDateReportDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class