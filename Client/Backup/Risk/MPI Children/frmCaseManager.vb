Public Class frmCaseManager
    Dim al As AdvancedList(Of CaseManager)
    Private Sub frmCaseManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        al = New AdvancedList(Of CaseManager)

        For Each c In CaseManager.CaseManagers
            al.Add(c)
        Next

        Me.CaseManagerBindingSource.DataSource = al


    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        'For Each c In al
        '    c.SaveData()
        'Next
        UpdateCaseManagers()
        frmCaseManager_Load(sender, e)
    End Sub

    Private markDelete() As Integer
    Private Sub UpdateCaseManagers()
        For Each c In al
            c.updateCaseManager()
        Next
        If Not markDelete Is Nothing Then
            For Each del In markDelete
                CaseManager.DeleteCaseManager(del)
            Next
        End If

        Dim empty() As Integer
        markDelete = empty

    End Sub

    Private Sub Delete(ByVal id As Integer)
        Dim c = 0
        If Not markDelete Is Nothing Then
            c = markDelete.Length
        End If
        ReDim Preserve markDelete(c)
        markDelete(c) = id
    End Sub

    Private Sub CaseManagerDataGridView_UserDeletingRow(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles CaseManagerDataGridView.UserDeletingRow
        Dim val = e.Row.Cells(0).Value
        If Not val = "" And Not val Is Nothing Then
            Delete(val)
        End If
    End Sub

   
End Class