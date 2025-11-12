Imports nsDataClass
Public Class RiskUIConfigDB
    Inherits DataClass

#Region "SQL Columns"
    Protected mConfigID As Integer?
    Public ReadOnly Property sConfigID() As String
        Get
            Return strInt(mConfigID)
        End Get
    End Property

    Protected mClassName As String
    Public Property ClassName() As String
        Get
            Return mClassName
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                mClassName = ""
            Else
                If value.length > 255 Then
                    Throw New Exception("Value exceeds maximum Length")
                Else
                    mClassName = value
                End If
            End If
        End Set
    End Property

    Protected mObjectName As String
    Public Property ObjectName() As String
        Get
            Return mObjectName
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                mObjectName = ""
            Else
                If value.length > 255 Then
                    Throw New Exception("Value exceeds maximum Length")
                Else
                    mObjectName = value
                End If
            End If
        End Set
    End Property

    Protected mVarName As String
    Public Property VarName() As String
        Get
            Return mVarName
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                mVarName = ""
            Else
                If value.length > 255 Then
                    Throw New Exception("Value exceeds maximum Length")
                Else
                    mVarName = value
                End If
            End If
        End Set
    End Property

    Protected mVarValue As String
    Public Property VarValue() As String
        Get
            Return mVarValue
        End Get
        Set(ByVal value As String)
            If value Is Nothing Then
                mVarValue = ""
            Else
                If value.length > 255 Then
                    Throw New Exception("Value exceeds maximum Length")
                Else
                    mVarValue = value
                End If
            End If
        End Set
    End Property

    Protected mDisable As Boolean?
    Public Property Disable() As Boolean?
        Get
            Return mDisable
        End Get
        Set(ByVal value As Boolean?)
            mDisable = value
        End Set
    End Property

#End Region





    Public Sub SaveData()
        updateRiskUIConfig()
    End Sub





#Region "Data Persistance"
#Region "Update"
    Public Function updateRiskUIConfig()
        Dim connectionString As String = "DSN=Risk"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim updateStatement As String = "Update tblRiskUIConfig SET " _
        & "ClassName = ?, " _
        & "ObjectName = ?, " _
        & "VarName = ?, " _
        & "VarValue = ?, " _
        & "Disable = ? " _
        & "where ConfigID like ?"



        Dim updateCommand As New Odbc.OdbcCommand(updateStatement, connection)

        updateCommand.Parameters.AddWithValue("@ClassName", nString(Me.mClassName))
        updateCommand.Parameters.AddWithValue("@ObjectName", nString(Me.mObjectName))
        updateCommand.Parameters.AddWithValue("@VarName", nString(Me.mVarName))
        updateCommand.Parameters.AddWithValue("@VarValue", nString(Me.mVarValue))
        updateCommand.Parameters.AddWithValue("@Disable", nBoolean(Me.mDisable))
        updateCommand.Parameters.AddWithValue("@ConfigID", nInteger(Me.mConfigID))
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




Public Class RiskUIConfig
    Inherits RiskUIConfigDB
#Region "Data Persistance"
#Region "Select"
    Public Shared Function getRiskUIConfig(ByVal ConfigID As Integer) As RiskUIConfig
        Dim RiskUIConfig As New RiskUIConfig
        Dim connectionString As String = "DSN=Risk"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblRiskUIConfig " _
        & "where ConfigID = '" + ConfigID.tostring + "'"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            If reader.Read Then
                RiskUIConfig.mConfigID = nInteger(reader("ConfigID"))
                RiskUIConfig.mClassName = nString(reader("ClassName"))
                RiskUIConfig.mObjectName = nString(reader("ObjectName"))
                RiskUIConfig.mVarName = nString(reader("VarName"))
                RiskUIConfig.mVarValue = nString(reader("VarValue"))
                RiskUIConfig.mDisable = nBoolean(reader("Disable"))
            Else
                RiskUIConfig = New RiskUIConfig()
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return RiskUIConfig
    End Function

    Public Shared Function getRiskUIConfig(ByVal strWhereClause As String, ByVal strOrderByClause As String) As RiskUIConfig()
        Dim RiskUIConfig(0) As RiskUIConfig
        RiskUIConfig(0) = New RiskUIConfig
        Dim connectionString As String = "DSN=Risk"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblRiskUIConfig " _
        & strWhereClause + " " + strOrderByClause
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            Dim i = -1
            While reader.Read
                i += 1
                ReDim Preserve RiskUIConfig(i)
                RiskUIConfig(i) = New RiskUIConfig
                RiskUIConfig(i).mConfigID = nInteger(reader("ConfigID"))
                RiskUIConfig(i).mClassName = nString(reader("ClassName"))
                RiskUIConfig(i).mObjectName = nString(reader("ObjectName"))
                RiskUIConfig(i).mVarName = nString(reader("VarName"))
                RiskUIConfig(i).mVarValue = nString(reader("VarValue"))
                RiskUIConfig(i).mDisable = nBoolean(reader("Disable"))
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return RiskUIConfig
    End Function
#End Region
#End Region
End Class