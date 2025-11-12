Partial Class Scheme

#Region "Data Persistance"

    Public Shared Function getScheme() As Scheme()
        Return getScheme("where output = 1", "order by SchemeName Asc")
    End Function

#End Region

    Private Shared mScheme() As Scheme = getScheme()
    Public Shared ReadOnly Property Schemes() As Scheme()
        Get
            Return mScheme
        End Get
    End Property

End Class
