Partial Class CaseManager
    ' Private Shared mCaseManagers() As CaseManager = getCaseManager("", "")
    Public Shared ReadOnly Property CaseManagers() As CaseManager()
        Get
            Return getCaseManager("", "")
        End Get
    End Property
    Public Function updateCaseManager()
        Dim connectionString As String = "DSN=Risk"
        Dim connection = New Odbc.OdbcConnection(connectionString)

        Dim Statement As String
        Dim Command As Odbc.OdbcCommand

        If Me.sId Is Nothing Or Me.sId = "" Then 'insert
            Statement = "Insert into tblCaseManager values(?)"
            Command = New Odbc.OdbcCommand(Statement, connection)
            Command.Parameters.AddWithValue("@CaseManager", nString(Me.mCaseManager))
        Else 'update
            Statement = "Update tblCaseManager SET " _
        & "CaseManager = ? " _
        & "where Id like ?"
            Command = New Odbc.OdbcCommand(Statement, connection)
            Command.Parameters.AddWithValue("@CaseManager", nString(Me.mCaseManager))
            Command.Parameters.AddWithValue("@Id", nInteger(Me.mId))
        End If
        commitUpdate(connection, Command)
    End Function

    Public Shared Function DeleteCaseManager(ByVal Id As Integer)
        Dim connectionString As String = "DSN=Risk"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim Statement As String
        Dim Command As Odbc.OdbcCommand
        Statement = "Delete from tblCaseManager where id like ?"
        Command = New Odbc.OdbcCommand(Statement, connection)
        Command.Parameters.AddWithValue("@Id", nInteger(Id))
        commitUpdate(connection, Command)
    End Function
End Class