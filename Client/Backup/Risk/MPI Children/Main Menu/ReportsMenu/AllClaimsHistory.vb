Imports DGVCopyNS.DGVCopyClass
Public Class AllClaimsHistory

    Private Sub AllClaimsHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = mdiParentForm
        FillData()
    End Sub
    Private Sub FillData()
        Try
            Me.AllClaimsHistoryTableAdapter.Fill(Me.ReportsDataSet.AllClaimsHistory, CDate(Me.StartDate), CDate(Me.EndDate))
        Catch ex As Exception
            MsgBox(ex.Message, , "FillData()")
        End Try
    End Sub
    Private StartDate
    Private EndDate
    Public Shadows Sub Showdialog(ByVal StartDate, ByVal EndDate)
        If StartDate = Nothing Or EndDate = Nothing Then
            MsgBox("Please Enter Start and End dates", , Me.Text)
            Return
        End If
        Me.StartDate = StartDate
        Me.EndDate = EndDate
        MyBase.ShowDialog()
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
            DGVCopy(AllClaimsHistoryDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class