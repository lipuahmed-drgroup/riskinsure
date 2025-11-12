Public Structure YesNo
    Private m_YesNo As String
    Private m_TrueFalse As Boolean?

    Public Sub New(ByVal YesNo As String, ByVal TrueFalse As Boolean?)
        m_YesNo = YesNo
        m_TrueFalse = TrueFalse
    End Sub
    Public ReadOnly Property YesNo() As String
        Get
            Return m_YesNo
        End Get
    End Property
    Public ReadOnly Property TrueFalse() As Boolean?
        Get
            Return m_TrueFalse
        End Get
    End Property
    Public Shared ReadOnly Property YesNos() As YesNo()
        Get
            Dim yn(2) As YesNo
            yn(0) = New YesNo("", Nothing)
            yn(1) = New YesNo("Yes", True)
            yn(2) = New YesNo("No", False)
            Return yn
        End Get
    End Property
End Structure