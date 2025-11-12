Public Class BaseForm
    Inherits System.Windows.Forms.Form
    Public Shadows Sub Show()
        MdiParent = Risk_Insure_Claims_Management_System
        MyBase.Show()
    End Sub
    Public Shadows Sub ShowDialog()
        MdiParent = Risk_Insure_Claims_Management_System
        MyBase.ShowDialog()
    End Sub
End Class
