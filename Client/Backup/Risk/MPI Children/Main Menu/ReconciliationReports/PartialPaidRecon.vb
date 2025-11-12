Imports DGVCopyNS.DGVCopyClass
Public Class PartialPaidRecon

    Private Sub PartialPaidRecon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = MdiParentForm
        Try
            Me.PartialPaidReconTableAdapter.Fill(Me.ReconciliationDataSet.PartialPaidRecon)
        Catch ex As Exception
            MsgBox(ex.Message, , "PartialPaidRecon_Load()")
        End Try

    End Sub
    Private MdiParentForm = Risk_Insure_Claims_Management_System
    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        If Not Me.MdiParent Is Nothing Then
            Me.MdiParent = Nothing
            UndockButton.Text = "Dock"
        Else
            Me.MdiParent = MdiParentForm
            UndockButton.Text = "Undock"
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(PartialPaidReconDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class