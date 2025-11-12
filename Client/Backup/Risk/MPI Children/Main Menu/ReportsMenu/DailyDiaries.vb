Imports DGVCopyNS.DGVCopyClass
Public Class DailyDiaries

    Private Sub DailyDiariesDataGridView_RowLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DailyDiariesDataGridView.RowLeave
        Me.Validate()
        Me.DailyDiariesBindingSource.EndEdit()
        Try
            Me.TableAdapterManager.UpdateAll(ReportsDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, , "DailyDiariesDataGridView_RowLeave")
        End Try

    End Sub

    Private Sub DailyDiaries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DailyDiariesTableAdapter.Fill(Me.ReportsDataSet.DailyDiaries, CDate(Me.StartDate), CDate(Me.EndDate))
        Catch ex As System.Exception
            MsgBox(ex.Message, , "DailyDiaries_Load")
        End Try
    End Sub

    Private StartDate
    Private EndDate
    Public Shadows Sub showdialog(ByVal StartDate, ByVal EndDate)
        If StartDate = Nothing Or EndDate = Nothing Then
            MsgBox("Please Enter Start and End dates", , Me.Text)
            Return
        End If
        Me.StartDate = StartDate
        Me.EndDate = EndDate
        MyBase.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(DailyDiariesDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class