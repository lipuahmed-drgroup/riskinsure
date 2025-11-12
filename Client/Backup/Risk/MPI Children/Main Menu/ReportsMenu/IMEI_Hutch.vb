Imports DGVCopyNS.DGVCopyClass
Public Class IMEI_Hutch

    Private Sub IMEI_Hutch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.IMEI_ReportsTableAdapter.Hutch_Fill(Me.ReportsDataSet.IMEI_Reports, CDate(Me.StartDate), CDate(Me.EndDate))
        Catch ex As Exception
            MsgBox(ex.Message, , "IMEI_Hutch_Load")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(IMEI_ReportsDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class