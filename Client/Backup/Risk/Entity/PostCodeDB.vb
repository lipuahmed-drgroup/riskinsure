Imports nsDataClass
Public Class PostCodeDB
    Inherits DataClass

#Region "SQL Columns"
    Protected mPcode As String
    Public Property Pcode() As String
        Get
            Return mPcode
        End Get
        Set(ByVal value As String)
            mPcode = value
        End Set
    End Property

    Protected mLocality As String
    Public Property Locality() As String
        Get
            Return mLocality
        End Get
        Set(ByVal value As String)
            mLocality = value
        End Set
    End Property

    Protected mState As String
    Public Property State() As String
        Get
            Return mState
        End Get
        Set(ByVal value As String)
            mState = value
        End Set
    End Property

    Protected mCountry As String
    Public Property Country() As String
        Get
            Return mCountry
        End Get
        Set(ByVal value As String)
            mCountry = value
        End Set
    End Property

    Protected mPostCodeID As Integer?
    Public ReadOnly Property sPostCodeID() As String
        Get
            Return strInt(mPostCodeID)
        End Get
    End Property

#End Region





    Public Sub SaveData()
        updatePostCode()
    End Sub





#Region "Data Persistance"
#Region "Update"
    Public Function updatePostCode()
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim updateStatement As String = "Update t_Postcode SET " _
        & "Pcode = ?, " _
        & "Locality = ?, " _
        & "State = ?, " _
        & "Country = ? " _
        & "where PostCodeID like ?"



        Dim updateCommand As New Odbc.OdbcCommand(updateStatement, connection)

        updateCommand.Parameters.AddWithValue("@Pcode", nString(Me.mPcode))
        updateCommand.Parameters.AddWithValue("@Locality", nString(Me.mLocality))
        updateCommand.Parameters.AddWithValue("@State", nString(Me.mState))
        updateCommand.Parameters.AddWithValue("@Country", nString(Me.mCountry))
        updateCommand.Parameters.AddWithValue("@PostCodeID", nInteger(Me.mPostCodeID))
        Try
            connection.Open()
            Dim count As Integer = UpdateCommand.ExecuteNonQuery
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Odbc.OdbcException
            Throw ex
        Finally
            connection.Close()
        End Try
        commitUpdate(connection, updateCommand)
    End Function
#End Region
#Region "Add"
#End Region
#Region "Delete"
#End Region
#End Region





End Class




Public Class PostCode
    Inherits PostCodeDB
#Region "Data Persistance"
#Region "Select"
    Public Shared Function getPostCode(ByVal PostCodeID As Integer) As PostCode
        Dim PostCode As New PostCode
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from t_Postcode " _
        & "where PostCodeID = '" + PostCodeID.ToString + "'"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
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

    Public Shared Function getPostCode(ByVal strWhereClause As String, ByVal strOrderByClause As String) As PostCode()
        Dim PostCode(0) As PostCode
        PostCode(0) = New PostCode
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from t_Postcode " _
        & strWhereClause + " " + strOrderByClause
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
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
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return PostCode
    End Function
#End Region
#End Region
End Class