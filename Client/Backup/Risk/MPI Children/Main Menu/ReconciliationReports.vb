Public Class ReconciliationReports
    Private Sub ReconciliationReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MdiParentForm
    End Sub
    Private MdiParentForm = Risk_Insure_Claims_Management_System

    Private Function StartDate()
        Return Me.StartDate_TextBox.Text
    End Function
    Private Function EndDate()
        Return Me.EndDate_TextBox.Text
    End Function

    Private Sub ReconBButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconBButton.Click
        ReconB.showdialog(StartDate, EndDate)
    End Sub

    Private Sub ReconDigiMobButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconDigiMobButton.Click
        ReconDigiMob.showdialog(StartDate, EndDate)
    End Sub

    Private Sub ReconBrightpointButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReconBrightpointButton.Click
        ReconBrightpoint.showdialog(StartDate, EndDate)
    End Sub

    Private Sub LossDateReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LossDateReportButton.Click
        LossDateReport.showdialog(StartDate, EndDate)
    End Sub

    Private Sub LossDateReportFinanceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LossDateReportFinanceButton.Click
        LossDateReportFinance.showdialog(StartDate, EndDate)
    End Sub

    Private Sub PaymentsReconButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsReconButton.Click
        PaymentsRecon.showdialog(StartDate, EndDate)
    End Sub

    Private Sub PartialPaidReconButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartialPaidReconButton.Click
        PartialPaidRecon.ShowDialog()
    End Sub

    Private Sub OutstandingClaimsReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OutstandingClaimsReportButton.Click
        OutstandingClaimsReport.showdialog(StartDate, EndDate)
    End Sub

    Private Sub ExpensesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpensesButton.Click
        Expenses.showdialog(StartDate, EndDate)
    End Sub
    Private Sub LossDateReportFinanceNewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LossDateReportFinanceNewButton.Click
        LossDateReportFinanceNew.showdialog(StartDate, EndDate)
    End Sub

    Private Sub PaymentsReconNEWButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentsReconNEWButton.Click
        PaymentsReconNew.showdialog(StartDate, EndDate)
    End Sub

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        If Not Me.MdiParent Is Nothing Then
            Me.MdiParent = Nothing
            UndockButton.Text = "Dock"
        Else
            Me.MdiParent = MdiParentForm
            UndockButton.Text = "Undock"
        End If
    End Sub
End Class