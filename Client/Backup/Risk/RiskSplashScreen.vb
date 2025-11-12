Public NotInheritable Class RiskSplashScreen



    Private Sub RiskSplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim RiskLogo_PictureBox As New PictureBox
        With RiskLogo_PictureBox
            .Image = New Bitmap("loading.png")
            .Width = RiskLogo_PictureBox.Image.Width
            .Height = RiskLogo_PictureBox.Image.Height
            Me.Width = .Width
            Me.Height = .Height
        End With
        Me.Controls.Add(RiskLogo_PictureBox)

    End Sub

End Class
