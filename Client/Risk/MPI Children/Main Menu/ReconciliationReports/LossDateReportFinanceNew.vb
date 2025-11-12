Imports DGVCopyNS.DGVCopyClass
Public Class LossDateReportFinanceNew

    Private Sub LossDateReportFinanceNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            Me.LossDateReportFinanceNewTableAdapter.Fill(Me.ReconciliationDataSet.LossDateReportFinanceNew, StartDate, EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "LossDateReportFinanceNew_Load()")
        End Try
    End Sub

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(UndockButton, Me)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(LossDateReportFinanceNewDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class