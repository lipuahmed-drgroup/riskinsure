Public Class Zoom_Form
    Private m_Ok As Boolean = False
    Public Shadows Sub ShowDialog(ByRef Input As TextBox)
        Me.TextBox1.Text = Input.Text
        MyBase.ShowDialog()
        If m_Ok Then
            Input.Text = Me.TextBox1.Text
        End If

    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.m_Ok = True
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.m_Ok = False
        Me.Close()
    End Sub
End Class