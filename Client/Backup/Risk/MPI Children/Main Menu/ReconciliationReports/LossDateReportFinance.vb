Imports DGVCopyNS.DGVCopyClass
Public Class LossDateReportFinance

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(UndockButton, Me)
    End Sub

    Private Sub LossDateReportFinance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            Me.LossDateReportFinanceTableAdapter.Fill(Me.ReconciliationDataSet.LossDateReportFinance, StartDate, EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "LossDateReportFinance_Load()")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(LossDateReportFinanceDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class