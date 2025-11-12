Imports DGVCopyNS.DGVCopyClass
Public Class OutstandingClaimsReport

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(UndockButton, Me)
    End Sub

    Private Sub OutstandingClaimsReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            Me.OutstandingClaimsReportTableAdapter.Fill(Me.ReconciliationDataSet.OutstandingClaimsReport, StartDate, EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "OutstandingClaimsReport_Load()")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(OutstandingClaimsReportDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class