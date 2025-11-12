Public Class ExitDoorwayButton
    Inherits Button
    Public Sub New()
        MyBase.New()
        MyBase.Image = My.Resources.ExitDoorway
        MyBase.Width = 38
        MyBase.Height = 30
    End Sub
    Private Sub ButtonClicked() Handles Me.Click
        Risk_Insure_Claims_Management_System.ActiveMdiChild.Close()
    End Sub
End Class 'Added Phase One Amendments
