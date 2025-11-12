Imports DGVCopyNS.DGVCopyClass
Public Class ClaimsHistory

    Private StartDate
    Private EndDate
    Private SupplierID
    Public Shadows Sub showdialog(ByVal StartDate, ByVal EndDate, ByVal SupplierID)
        If StartDate = Nothing Or EndDate = Nothing Then
            MsgBox("Please Enter Start and End dates and Supplier", , Me.Text)
            Return
        End If
        Me.StartDate = StartDate
        Me.EndDate = EndDate
        Me.SupplierID = SupplierID
        MyBase.ShowDialog()
    End Sub



    Private Sub ClaimsHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.MdiParent = mdiParentForm
        FillData()
    End Sub

    Private Sub FillData()
        Try
            Me.ClaimsHistoryTableAdapter.Fill(Me.ReportsDataSet.ClaimsHistory, CDate(Me.StartDate), CDate(Me.EndDate), CDec(Me.SupplierID))
        Catch ex As System.Exception
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
            DGVCopy(ClaimsHistoryDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class