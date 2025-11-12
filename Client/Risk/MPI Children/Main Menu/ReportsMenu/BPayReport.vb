Imports DGVCopyNS.DGVCopyClass
Public Class BPayReport

    Private Sub BPayReportBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BPayReportBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BPayReportBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReportsDataSet)

    End Sub

    Private Sub BPayReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.MdiParent = mdiParentForm
        FillData()
    End Sub
    Private Sub FillData()
        Try
            Me.BPayReportTableAdapter.Fill(Me.ReportsDataSet.BPayReport)
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

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(BPayReportDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class