Public Class IMEI

    Private m_StartDate
    Private m_EndDate
    Public Shadows Sub showdialog(ByVal StartDate, ByVal EndDate)
        If StartDate = Nothing Or EndDate = Nothing Then
            MsgBox("Please Enter Start and End dates", , Me.Text)
            Return
        End If
        Me.m_StartDate = StartDate
        Me.m_EndDate = EndDate
        MyBase.ShowDialog()
    End Sub

    Protected ReadOnly Property StartDate()
        Get
            Return Me.m_StartDate
        End Get
    End Property

    Protected ReadOnly Property EndDate()
        Get
            Return Me.m_EndDate
        End Get
    End Property

End Class