Public Class ClassTest

    Private Sub ClassTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
        Try
            ClaimsEdit.Show()



        Catch ex As Exception
            MsgBox(ex.ToString, , ex.Message)
        End Try
    End Sub
End Class