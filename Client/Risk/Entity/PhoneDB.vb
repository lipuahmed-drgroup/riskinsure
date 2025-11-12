Imports nsDataClass
Public Class PhoneDB
    Inherits DataClass

#Region "SQL Columns"
    Protected mPhoneID As Integer?
    Public ReadOnly Property sPhoneID() As String
        Get
            Return strInt(mPhoneID)
        End Get
    End Property

    Protected mMake As String
    Public Property Make() As String
        Get
            Return mMake
        End Get
        Set(ByVal value As String)
            mMake = value
        End Set
    End Property

    Protected mModel As String
    Public Property Model() As String
        Get
            Return mModel
        End Get
        Set(ByVal value As String)
            mModel = value
        End Set
    End Property

    Protected mMakersCode As String
    Public Property MakersCode() As String
        Get
            Return mMakersCode
        End Get
        Set(ByVal value As String)
            mMakersCode = value
        End Set
    End Property

    Protected mDescription As String
    Public Property Description() As String
        Get
            Return mDescription
        End Get
        Set(ByVal value As String)
            mDescription = value
        End Set
    End Property

    Protected mUpdateDate As Date?
    Public Property UpdateDate() As Date?
        Get
            Return mUpdateDate
        End Get
        Set(ByVal value As Date?)
            mUpdateDate = value
        End Set
    End Property
    Public Property sUpdateDate() As String
        Get
            Return strDate(mUpdateDate)
        End Get
        Set(ByVal value As String)
            mUpdateDate = strDate(value)
        End Set
    End Property

    Protected mUpdateUserID As String
    Public Property UpdateUserID() As String
        Get
            Return mUpdateUserID
        End Get
        Set(ByVal value As String)
            mUpdateUserID = value
        End Set
    End Property

    Protected mImportColour As String
    Public Property ImportColour() As String
        Get
            Return mImportColour
        End Get
        Set(ByVal value As String)
            mImportColour = value
        End Set
    End Property

    Protected mImportModel As String
    Public Property ImportModel() As String
        Get
            Return mImportModel
        End Get
        Set(ByVal value As String)
            mImportModel = value
        End Set
    End Property

#End Region





    Public Sub SaveData()
        updatePhone()
    End Sub





#Region "Data Persistance"
#Region "Update"
    Public Function updatePhone()
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim updateStatement As String = "Update tblPhone SET " _
        & "Make = ?, " _
        & "Model = ?, " _
        & "MakersCode = ?, " _
        & "Description = ?, " _
        & "UpdateDate = ?, " _
        & "UpdateUserID = ?, " _
        & "ImportColour = ?, " _
        & "ImportModel = ? " _
        & "where PhoneID like ?"



        Dim updateCommand As New Odbc.OdbcCommand(updateStatement, connection)

        updateCommand.Parameters.AddWithValue("@Make", nString(Me.mMake))
        updateCommand.Parameters.AddWithValue("@Model", nString(Me.mModel))
        updateCommand.Parameters.AddWithValue("@MakersCode", nString(Me.mMakersCode))
        updateCommand.Parameters.AddWithValue("@Description", nString(Me.mDescription))
        updateCommand.Parameters.AddWithValue("@UpdateDate", nDate(Me.mUpdateDate))
        updateCommand.Parameters.AddWithValue("@UpdateUserID", nString(Me.mUpdateUserID))
        updateCommand.Parameters.AddWithValue("@ImportColour", nString(Me.mImportColour))
        updateCommand.Parameters.AddWithValue("@ImportModel", nString(Me.mImportModel))
        updateCommand.Parameters.AddWithValue("@PhoneID", nInteger(Me.mPhoneID))
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




Public Class Phone
    Inherits PhoneDB
#Region "Data Persistance"
#Region "Select"
    Public Shared Function getPhone(ByVal PhoneID As Integer) As Phone
        Dim Phone As New Phone
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblPhone " _
        & "where PhoneID = '" + PhoneID.ToString + "'"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            If reader.Read Then
                Phone.mPhoneID = nInteger(reader("PhoneID"))
                Phone.mMake = nString(reader("Make"))
                Phone.mModel = nString(reader("Model"))
                Phone.mMakersCode = nString(reader("MakersCode"))
                Phone.mDescription = nString(reader("Description"))
                Phone.mUpdateDate = nDate(reader("UpdateDate"))
                Phone.mUpdateUserID = nString(reader("UpdateUserID"))
                Phone.mImportColour = nString(reader("ImportColour"))
                Phone.mImportModel = nString(reader("ImportModel"))
            Else
                Phone = New Phone()
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return Phone
    End Function

    Public Shared Function getPhone(ByVal strWhereClause As String, ByVal strOrderByClause As String) As Phone()
        Dim Phone(0) As Phone
        Phone(0) = New Phone
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblPhone " _
        & strWhereClause + " " + strOrderByClause
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            Dim i = -1
            While reader.Read
                i += 1
                ReDim Preserve Phone(i)
                Phone(i) = New Phone
                Phone(i).mPhoneID = nInteger(reader("PhoneID"))
                Phone(i).mMake = nString(reader("Make"))
                Phone(i).mModel = nString(reader("Model"))
                Phone(i).mMakersCode = nString(reader("MakersCode"))
                Phone(i).mDescription = nString(reader("Description"))
                Phone(i).mUpdateDate = nDate(reader("UpdateDate"))
                Phone(i).mUpdateUserID = nString(reader("UpdateUserID"))
                Phone(i).mImportColour = nString(reader("ImportColour"))
                Phone(i).mImportModel = nString(reader("ImportModel"))
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return Phone
    End Function
#End Region
#End Region
End Class