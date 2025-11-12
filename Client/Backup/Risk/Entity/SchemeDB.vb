Imports nsDataClass
Public Class SchemeDB
    Inherits DataClass

#Region "SQL Columns"
    Protected mSchemeID As Integer?
    Public ReadOnly Property sSchemeID() As String
        Get
            Return strInt(mSchemeID)
        End Get
    End Property

    Protected mSchemeName As String
    Public Property SchemeName() As String
        Get
            Return mSchemeName
        End Get
        Set(ByVal value As String)
            mSchemeName = value
        End Set
    End Property

    Protected mSimCardPrice As Decimal?
    Public Property sSimCardPrice() As String
        Get
            Return strDec(mSimCardPrice)
        End Get
        Set(ByVal value As String)
            mSimCardPrice = strDec(value)
        End Set
    End Property

    Protected mFreightPhoneSim As Decimal?
    Public Property sFreightPhoneSim() As String
        Get
            Return strDec(mFreightPhoneSim)
        End Get
        Set(ByVal value As String)
            mFreightPhoneSim = strDec(value)
        End Set
    End Property

    Protected mFreightPhoneOnly As Decimal?
    Public Property sFreightPhoneOnly() As String
        Get
            Return strDec(mFreightPhoneOnly)
        End Get
        Set(ByVal value As String)
            mFreightPhoneOnly = strDec(value)
        End Set
    End Property

    Protected mFreightSimOnly As Decimal?
    Public Property sFreightSimOnly() As String
        Get
            Return strDec(mFreightSimOnly)
        End Get
        Set(ByVal value As String)
            mFreightSimOnly = strDec(value)
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

    Protected mCountry As String
    Public Property Country() As String
        Get
            Return mCountry
        End Get
        Set(ByVal value As String)
            mCountry = value
        End Set
    End Property

    Protected mSch_sup_id As Integer?
    Public Property sSch_sup_id() As String
        Get
            Return strInt(mSch_sup_id)
        End Get
        Set(ByVal value As String)
            mSch_sup_id = strInt(value)
        End Set
    End Property
    Public Property Sch_sup_id() As Integer
        Get
            Return mSch_sup_id
        End Get
        Set(ByVal value As Integer)
            mSch_sup_id = value
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
        updateScheme()
    End Sub





#Region "Data Persistance"
#Region "Update"
    Public Function updateScheme()
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim updateStatement As String = "Update tblScheme SET " _
        & "SchemeName = ?, " _
        & "SimCardPrice = ?, " _
        & "FreightPhoneSim = ?, " _
        & "FreightPhoneOnly = ?, " _
        & "FreightSimOnly = ?, " _
        & "UpdateDate = ?, " _
        & "UpdateUserID = ?, " _
        & "Country = ?, " _
        & "Sch_sup_id = ?, " _
        & "Keep = ?, " _
        & "Output = ? " _
        & "where SchemeID like ?"



        Dim updateCommand As New Odbc.OdbcCommand(updateStatement, connection)

        updateCommand.Parameters.AddWithValue("@SchemeName", nString(Me.mSchemeName))
        updateCommand.Parameters.AddWithValue("@SimCardPrice", nDecimal(Me.mSimCardPrice))
        updateCommand.Parameters.AddWithValue("@FreightPhoneSim", nDecimal(Me.mFreightPhoneSim))
        updateCommand.Parameters.AddWithValue("@FreightPhoneOnly", nDecimal(Me.mFreightPhoneOnly))
        updateCommand.Parameters.AddWithValue("@FreightSimOnly", nDecimal(Me.mFreightSimOnly))
        updateCommand.Parameters.AddWithValue("@UpdateDate", nDate(Me.mUpdateDate))
        updateCommand.Parameters.AddWithValue("@UpdateUserID", nString(Me.mUpdateUserID))
        updateCommand.Parameters.AddWithValue("@Country", nString(Me.mCountry))
        updateCommand.Parameters.AddWithValue("@Sch_sup_id", nInteger(Me.mSch_sup_id))
        updateCommand.Parameters.AddWithValue("@Keep", nBoolean(Me.mKeep))
        updateCommand.Parameters.AddWithValue("@Output", nBoolean(Me.mOutput))
        updateCommand.Parameters.AddWithValue("@SchemeID", nInteger(Me.mSchemeID))
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




Public Class Scheme
    Inherits SchemeDB
#Region "Data Persistance"
#Region "Select"
    Public Shared Function getScheme(ByVal SchemeID As Integer) As Scheme
        Dim Scheme As New Scheme
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblScheme " _
        & "where SchemeID = '" + SchemeID.ToString + "'"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            If reader.Read Then
                Scheme.mSchemeID = nInteger(reader("SchemeID"))
                Scheme.mSchemeName = nString(reader("SchemeName"))
                Scheme.mSimCardPrice = nDecimal(reader("SimCardPrice"))
                Scheme.mFreightPhoneSim = nDecimal(reader("FreightPhoneSim"))
                Scheme.mFreightPhoneOnly = nDecimal(reader("FreightPhoneOnly"))
                Scheme.mFreightSimOnly = nDecimal(reader("FreightSimOnly"))
                Scheme.mUpdateDate = nDate(reader("UpdateDate"))
                Scheme.mUpdateUserID = nString(reader("UpdateUserID"))
                Scheme.mCountry = nString(reader("Country"))
                Scheme.msch_sup_id = nInteger(reader("sch_sup_id"))
                Scheme.mKeep = nBoolean(reader("Keep"))
                Scheme.mOutput = nBoolean(reader("Output"))
            Else
                Scheme = New Scheme()
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return Scheme
    End Function

    Public Shared Function getScheme(ByVal strWhereClause As String, ByVal strOrderByClause As String) As Scheme()
        Dim Scheme(0) As Scheme
        Scheme(0) = New Scheme
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblScheme " _
        & strWhereClause + " " + strOrderByClause
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            Dim i = -1
            While reader.Read
                i += 1
                ReDim Preserve Scheme(i)
                Scheme(i) = New Scheme
                Scheme(i).mSchemeID = nInteger(reader("SchemeID"))
                Scheme(i).mSchemeName = nString(reader("SchemeName"))
                Scheme(i).mSimCardPrice = nDecimal(reader("SimCardPrice"))
                Scheme(i).mFreightPhoneSim = nDecimal(reader("FreightPhoneSim"))
                Scheme(i).mFreightPhoneOnly = nDecimal(reader("FreightPhoneOnly"))
                Scheme(i).mFreightSimOnly = nDecimal(reader("FreightSimOnly"))
                Scheme(i).mUpdateDate = nDate(reader("UpdateDate"))
                Scheme(i).mUpdateUserID = nString(reader("UpdateUserID"))
                Scheme(i).mCountry = nString(reader("Country"))
                Scheme(i).msch_sup_id = nInteger(reader("sch_sup_id"))
                Scheme(i).mKeep = nBoolean(reader("Keep"))
                Scheme(i).mOutput = nBoolean(reader("Output"))
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return Scheme
    End Function
#End Region
#End Region
End Class