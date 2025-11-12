Partial Class RiskUIConfig

    Public Shared Function getRiskUIConfigVarValue(ByVal strClassName As String, ByVal strObjectName As String, ByVal strVarName As String) As String
        Return getRiskUIConfig("where ClassName = '" + strClassName + "' and ObjectName = '" + strObjectName + "' and VarName = '" + strVarName + "'", "")(0).VarValue
    End Function

    'Public Shared Function getRiskUIConfig(ByVal strClassName As String, ByVal strObjectName As String, ByVal strVarName As String) As RiskUIConfig '()
    '    Return getRiskUIConfig("where ClassName = '" + strClassName + "' and ObjectName = '" + strObjectName + "' and VarName = '" + strVarName + "'", "")(0)
    'End Function

    'Public Shared Function getRiskUIConfig(ByVal strClassName As String, ByVal strObjectName As String, ByVal strVarName As String) As RiskUIConfig()
    '    Dim RiskUIConfig(0) As RiskUIConfig
    '    RiskUIConfig(0) = New RiskUIConfig
    '    Dim connectionString As String = "DSN=Risk"
    '    Dim connection = New Odbc.OdbcConnection(connectionString)
    '    Dim selectStatement As String _
    '    = "Select * " _
    '    & "from tblRiskUIConfig " _
    '    & "where ClassName = '" + strClassName + "' and ObjectName = '" + strObjectName + "' and VarName = '" + strVarName + "'"
    '    Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
    '    Try
    '        connection.Open()
    '        Dim reader As Odbc.OdbcDataReader _
    '        = selectCommand.ExecuteReader()
    '        Dim i = -1
    '        While reader.Read
    '            i += 1
    '            ReDim Preserve RiskUIConfig(i)
    '            RiskUIConfig(i) = New RiskUIConfig
    '            RiskUIConfig(i).mConfigID = nInteger(reader("ConfigID"))
    '            RiskUIConfig(i).mClassName = nString(reader("ClassName"))
    '            RiskUIConfig(i).mObjectName = nString(reader("ObjectName"))
    '            RiskUIConfig(i).mVarName = nString(reader("VarName"))
    '            RiskUIConfig(i).mVarValue = nString(reader("VarValue"))
    '            RiskUIConfig(i).mDisable = nBoolean(reader("Disable"))
    '        End While
    '        reader.Close()
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        connection.Close()
    '    End Try
    '    Return RiskUIConfig
    'End Function


End Class
