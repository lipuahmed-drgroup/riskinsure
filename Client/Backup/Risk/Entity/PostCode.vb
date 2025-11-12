Partial Class PostCode

#Region "Data Persistance"

    Public Shared Function getPostCode() As PostCode()
        Dim PostCode(0) As PostCode
        PostCode(0) = New PostCode
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from t_Postcode " _
        & "order by Locality Asc, State Asc, Pcode Asc, Country Asc, PostCodeID Asc"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = selectCommand.ExecuteReader
            Dim i = -1
            While reader.Read
                i += 1
                ReDim Preserve PostCode(i)
                PostCode(i) = New PostCode
                PostCode(i).mPcode = nString(reader("Pcode"))
                PostCode(i).mLocality = nString(reader("Locality"))
                PostCode(i).mState = nString(reader("State"))
                PostCode(i).mCountry = nString(reader("Country"))
                PostCode(i).mPostCodeID = nInteger(reader("PostCodeID"))


                '    PostCode(i).mDisplay = PostCode(i).mLocality + " " + PostCode(i).mState + " " + PostCode(i).mPcode


            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return PostCode
    End Function

    'Public Shared Function getPostCode(ByVal Locality As String, _
    '                                   ByVal PCode As String, _
    '                                   ByVal State As String) As PostCode
    '    Dim PostCode As New PostCode
    '    Dim connectionString As String = "DSN=RISK"
    '    Dim connection = New Odbc.OdbcConnection(connectionString)
    '    Dim selectStatement As String _
    '    = "Select * " _
    '    & "from t_Postcode " _
    '    & "where Pcode = '" + PCode + "'" _
    '    & " and Locality = '" + Locality + "'" _
    '    & " and State = '" + State + "'"
    '    Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
    '    Try
    '        connection.Open()
    '        Dim reader As Odbc.OdbcDataReader _
    '        = selectCommand.ExecuteReader()
    '        If reader.Read Then
    '            PostCode.mPcode = nString(reader("Pcode"))
    '            PostCode.mLocality = nString(reader("Locality"))
    '            PostCode.mState = nString(reader("State"))
    '            PostCode.mCountry = nString(reader("Country"))
    '            PostCode.mPostCodeID = nInteger(reader("PostCodeID"))
    '        Else
    '            PostCode = New PostCode()
    '        End If
    '        reader.Close()
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        connection.Close()
    '    End Try
    '    Return PostCode
    'End Function

    Public Shared Function getPostCode(ByVal Locality As String, _
                                   ByVal PCode As String, _
                                   ByVal State As String) As PostCode
        Dim PostCode As New PostCode
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from t_Postcode " _
        & "where Pcode = '" + PCode + "'" _
        & " and Locality = ?" _
        & " and State = '" + State + "'"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@Locality", nString(Locality))
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = selectCommand.ExecuteReader()
            If reader.Read Then
                PostCode.mPcode = nString(reader("Pcode"))
                PostCode.mLocality = nString(reader("Locality"))
                PostCode.mState = nString(reader("State"))
                PostCode.mCountry = nString(reader("Country"))
                PostCode.mPostCodeID = nInteger(reader("PostCodeID"))
            Else
                PostCode = New PostCode()
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return PostCode
    End Function

    Public Shared Function getPostCode(ByVal country As String) As PostCode()
        Return getPostCode("where country = '" + country + "'", Nothing)
    End Function


#End Region

    Private Shared mPostCodes() As PostCode = getPostCode() 'Storage for array of postcodes
    'Private Shared mAusPostCodes() As PostCode = getPostCode("AUS")
    'Private Shared mNzPostCodes() As PostCode = getPostCode("NZ")

    Public Shared ReadOnly Property PostCodes() As PostCode()
        Get
            Return mPostCodes
        End Get
    End Property

    'Public Shared ReadOnly Property AusPostCodes() As PostCode()
    '    Get
    '        Return mAusPostCodes
    '    End Get
    'End Property

    'Public Shared ReadOnly Property NzPostCodes() As PostCode()
    '    Get
    '        Return mNzPostCodes
    '    End Get
    'End Property

    Public ReadOnly Property Display() As String 'Display for databinds
        Get
            Dim out As String = Me.mLocality + " " + Me.mState + " " + Me.mPcode
            Return out
        End Get
    End Property

    Public ReadOnly Property Item(ByVal Index As Integer) As String 'Output array of columns
        Get
            Dim i(2) As String
            i(0) = Me.Locality
            i(1) = Me.State
            i(2) = Me.Pcode
            Return i(Index)
        End Get
    End Property

End Class
