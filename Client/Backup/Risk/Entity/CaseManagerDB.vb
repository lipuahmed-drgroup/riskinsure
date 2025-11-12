Imports nsDataClass
Public Class CaseManagerDB
    Inherits DataClass

#Region "SQL Columns"
    Protected mId As Integer?
    Public ReadOnly Property sId() As String
        Get
            Return strInt(mId)
        End Get
    End Property

    Protected mCaseManager As String
    Public Property CaseManager() As String
        Get
            Return mCaseManager
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                mCaseManager = ""
            Else
                If value.length > 50 Then
                    Throw New Exception("Value exceeds maximum Length")
                Else
                    mCaseManager = value
                End If
            End If
        End Set
    End Property

#End Region





    Public Sub SaveData()
        updateCaseManager()
    End Sub





#Region "Data Persistance"
#Region "Update"
    Public Function updateCaseManager()
        Dim connectionString As String = "DSN=Risk"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim updateStatement As String = "Update tblCaseManager SET " _
        & "CaseManager = ? " _
        & "where Id like ?"



        Dim updateCommand As New Odbc.OdbcCommand(updateStatement, connection)

        updateCommand.Parameters.AddWithValue("@CaseManager", nString(Me.mCaseManager))
        updateCommand.Parameters.AddWithValue("@Id", nInteger(Me.mId))
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




Public Class CaseManager
    Inherits CaseManagerDB
#Region "Data Persistance"
#Region "Select"
    Public Shared Function getCaseManager(ByVal Id As Integer) As CaseManager
        Dim CaseManager As New CaseManager
        Dim connectionString As String = "DSN=Risk"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblCaseManager " _
        & "where Id = '" + Id.tostring + "'"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            If reader.Read Then
                CaseManager.mid = nInteger(reader("id"))
                CaseManager.mCaseManager = nString(reader("CaseManager"))
            Else
                CaseManager = New CaseManager()
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return CaseManager
    End Function

    Public Shared Function getCaseManager(ByVal strWhereClause As String, ByVal strOrderByClause As String) As CaseManager()
        Dim CaseManager(0) As CaseManager
        CaseManager(0) = New CaseManager
        Dim connectionString As String = "DSN=Risk"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblCaseManager " _
        & strWhereClause + " " + strOrderByClause
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            Dim i = -1
            While reader.Read
                i += 1
                ReDim Preserve CaseManager(i)
                CaseManager(i) = New CaseManager
                CaseManager(i).mid = nInteger(reader("id"))
                CaseManager(i).mCaseManager = nString(reader("CaseManager"))
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return CaseManager
    End Function
#End Region
#End Region
End Class