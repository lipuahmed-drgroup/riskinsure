Imports nsDataClass
Public Class SupplierDB
    Inherits DataClass

#Region "SQL Columns"
    Protected mSup_id As Integer?
    Public ReadOnly Property sSup_id() As String
        Get
            Return strInt(mSup_id)
        End Get
    End Property

    Protected mSup_Name As String
    Public Property Sup_Name() As String
        Get
            Return mSup_Name
        End Get
        Set(ByVal value As String)
            mSup_Name = value
        End Set
    End Property

    Protected mSup_ReplacementPhoneSchemeId As Integer?
    Public Property sSup_ReplacementPhoneSchemeId() As String
        Get
            Return strInt(mSup_ReplacementPhoneSchemeId)
        End Get
        Set(ByVal value As String)
            mSup_ReplacementPhoneSchemeId = strInt(value)
        End Set
    End Property
    Public Property Sup_ReplacementPhoneSchemeId() As Integer
        Get
            Return mSup_ReplacementPhoneSchemeId
        End Get
        Set(ByVal value As Integer)
            mSup_ReplacementPhoneSchemeId = value
        End Set
    End Property

    Protected mSup_ReplacementSIMCardSchemeId As Integer?
    Public Property sSup_ReplacementSIMCardSchemeId() As String
        Get
            Return strInt(mSup_ReplacementSIMCardSchemeId)
        End Get
        Set(ByVal value As String)
            mSup_ReplacementSIMCardSchemeId = strInt(value)
        End Set
    End Property
    Public Property Sup_ReplacementSIMCardSchemeId() As Integer
        Get
            Return mSup_ReplacementSIMCardSchemeId
        End Get
        Set(ByVal value As Integer)
            mSup_ReplacementSIMCardSchemeId = value
        End Set
    End Property

    Protected mKeep As Boolean?
    Public Property Keep() As Boolean?
        Get
            Return mKeep
        End Get
        Set(ByVal value As Boolean?)
            mKeep = value
        End Set
    End Property

    Protected mSup_SimCardPrice As Decimal?
    Public Property sSup_SimCardPrice() As String
        Get
            Return strDec(mSup_SimCardPrice)
        End Get
        Set(ByVal value As String)
            mSup_SimCardPrice = strDec(value)
        End Set
    End Property

    Protected mSup_FreightPhoneSim As Decimal?
    Public Property sSup_FreightPhoneSim() As String
        Get
            Return strDec(mSup_FreightPhoneSim)
        End Get
        Set(ByVal value As String)
            mSup_FreightPhoneSim = strDec(value)
        End Set
    End Property

    Protected mSup_FreightPhoneOnly As Decimal?
    Public Property sSup_FreightPhoneOnly() As String
        Get
            Return strDec(mSup_FreightPhoneOnly)
        End Get
        Set(ByVal value As String)
            mSup_FreightPhoneOnly = strDec(value)
        End Set
    End Property

    Protected mSup_FreightSimOnly As Decimal?
    Public Property sSup_FreightSimOnly() As String
        Get
            Return strDec(mSup_FreightSimOnly)
        End Get
        Set(ByVal value As String)
            mSup_FreightSimOnly = strDec(value)
        End Set
    End Property

    Protected mOutput As Boolean?
    Public Property Output() As Boolean?
        Get
            Return mOutput
        End Get
        Set(ByVal value As Boolean?)
            mOutput = value
        End Set
    End Property



#End Region





    Public Sub SaveData()
        updateSupplier()
    End Sub





#Region "Data Persistance"
#Region "Update"
    Public Function updateSupplier()
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim updateStatement As String = "Update t_Supplier SET " _
        & "Sup_Name = ?, " _
        & "Sup_ReplacementPhoneSchemeId = ?, " _
        & "Sup_ReplacementSIMCardSchemeId = ?, " _
        & "Keep = ?, " _
        & "Sup_SimCardPrice = ?, " _
        & "Sup_FreightPhoneSim = ?, " _
        & "Sup_FreightPhoneOnly = ?, " _
        & "Sup_FreightSimOnly = ?, " _
        & "Output = ? " _
        & "where sup_id like ?"



        Dim updateCommand As New Odbc.OdbcCommand(updateStatement, connection)

        updateCommand.Parameters.AddWithValue("@Sup_Name", nString(Me.mSup_Name))
        updateCommand.Parameters.AddWithValue("@Sup_ReplacementPhoneSchemeId", nInteger(Me.mSup_ReplacementPhoneSchemeId))
        updateCommand.Parameters.AddWithValue("@Sup_ReplacementSIMCardSchemeId", nInteger(Me.mSup_ReplacementSIMCardSchemeId))
        updateCommand.Parameters.AddWithValue("@Keep", nBoolean(Me.mKeep))
        updateCommand.Parameters.AddWithValue("@Sup_SimCardPrice", nDecimal(Me.mSup_SimCardPrice))
        updateCommand.Parameters.AddWithValue("@Sup_FreightPhoneSim", nDecimal(Me.mSup_FreightPhoneSim))
        updateCommand.Parameters.AddWithValue("@Sup_FreightPhoneOnly", nDecimal(Me.mSup_FreightPhoneOnly))
        updateCommand.Parameters.AddWithValue("@Sup_FreightSimOnly", nDecimal(Me.mSup_FreightSimOnly))
        updateCommand.Parameters.AddWithValue("@Output", nBoolean(Me.mOutput))
        updateCommand.Parameters.AddWithValue("@sup_id", nInteger(Me.msup_id))
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




Public Class Supplier
    Inherits SupplierDB
#Region "Data Persistance"
#Region "Select"
    Public Shared Function getSupplier(ByVal sup_id As Integer) As Supplier
        Dim Supplier As New Supplier
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from t_Supplier " _
        & "where sup_id = '" + sup_id.ToString + "'"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            If reader.Read Then
                Supplier.msup_id = nInteger(reader("sup_id"))
                Supplier.msup_Name = nString(reader("sup_Name"))
                Supplier.msup_ReplacementPhoneSchemeId = nInteger(reader("sup_ReplacementPhoneSchemeId"))
                Supplier.msup_ReplacementSIMCardSchemeId = nInteger(reader("sup_ReplacementSIMCardSchemeId"))
                Supplier.mKeep = nBoolean(reader("Keep"))
                Supplier.mSup_SimCardPrice = nDecimal(reader("Sup_SimCardPrice"))
                Supplier.mSup_FreightPhoneSim = nDecimal(reader("Sup_FreightPhoneSim"))
                Supplier.mSup_FreightPhoneOnly = nDecimal(reader("Sup_FreightPhoneOnly"))
                Supplier.mSup_FreightSimOnly = nDecimal(reader("Sup_FreightSimOnly"))
                Supplier.mOutput = nBoolean(reader("Output"))
            Else
                Supplier = New Supplier()
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return Supplier
    End Function

    Public Shared Function getSupplier(ByVal strWhereClause As String, ByVal strOrderByClause As String) As Supplier()
        Dim Supplier(0) As Supplier
        Supplier(0) = New Supplier
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from t_Supplier " _
        & strWhereClause + " " + strOrderByClause
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            Dim i = -1
            While reader.Read
                i += 1
                ReDim Preserve Supplier(i)
                Supplier(i) = New Supplier
                Supplier(i).msup_id = nInteger(reader("sup_id"))
                Supplier(i).msup_Name = nString(reader("sup_Name"))
                Supplier(i).msup_ReplacementPhoneSchemeId = nInteger(reader("sup_ReplacementPhoneSchemeId"))
                Supplier(i).msup_ReplacementSIMCardSchemeId = nInteger(reader("sup_ReplacementSIMCardSchemeId"))
                Supplier(i).mKeep = nBoolean(reader("Keep"))
                Supplier(i).mSup_SimCardPrice = nDecimal(reader("Sup_SimCardPrice"))
                Supplier(i).mSup_FreightPhoneSim = nDecimal(reader("Sup_FreightPhoneSim"))
                Supplier(i).mSup_FreightPhoneOnly = nDecimal(reader("Sup_FreightPhoneOnly"))
                Supplier(i).mSup_FreightSimOnly = nDecimal(reader("Sup_FreightSimOnly"))
                Supplier(i).mOutput = nBoolean(reader("Output"))
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return Supplier
    End Function
#End Region
#End Region
End Class