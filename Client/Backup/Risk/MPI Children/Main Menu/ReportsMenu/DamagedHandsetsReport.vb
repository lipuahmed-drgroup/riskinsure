Imports DGVCopyNS.DGVCopyClass
Public Class DamagedHandsetsReport

    Private Sub DamagedHandsetsReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.MdiParent = mdiParentForm
        FillData()
    End Sub
    Private Sub FillData()
        Try
            Me.DamagedHandsets_ReportTableAdapter.Fill(Me.ReportsDataSet.DamagedHandsets_Report)
        Catch ex As Exception
            MsgBox(ex.Message, , "FillData()")
        End Try
    End Sub
    Private mdiParentForm = Risk_Insure_Claims_Management_System
    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        If Not Me.MdiParent Is Nothing Then
            Me.MdiParent = Nothing
            Me.UndockButton.Text = "Dock"
        Else
            Me.MdiParent = mdiParentForm
            Me.UndockButton.Text = "Undock"
        End If
    End Sub

    Private Sub DamagedHandsets_ReportBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamagedHandsets_ReportBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DamagedHandsets_ReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReportsDataSet)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(DamagedHandsets_ReportDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class