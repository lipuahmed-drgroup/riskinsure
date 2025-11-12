Partial Class Phone
#Region "Data Persistance"

    Public Shared Function getPhone() As Phone()
        Return getPhone(Nothing, "order by Make asc, Model asc")
    End Function

#End Region

    Private Shared mPhones As Phone() = getPhone()
    Public Shared ReadOnly Property Phones() As Phone()
        Get
            Return mPhones
        End Get
    End Property

    Public ReadOnly Property PhDesc() As String
        Get
            Return Me.Make + " " + Me.Model
        End Get
    End Property

    Public ReadOnly Property Item(ByVal Index As Integer) As String 'Output array of columns
        Get
            Dim i(2) As String
            i(0) = Me.Make
            i(1) = Me.Model
            i(2) = Me.ImportColour
            Return i(Index)
        End Get
    End Property

End Class
