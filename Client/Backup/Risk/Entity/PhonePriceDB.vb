Imports nsDataClass
Public Class PhonePriceDB
    Inherits DataClass

#Region "SQL Columns"
    Protected mPhDesc1 As String
    Public Property PhDesc1() As String
        Get
            Return mPhDesc1
        End Get
        Set(ByVal value As String)
            mPhDesc1 = value
        End Set
    End Property

    Protected mPrice As Decimal?
    Public Property sPrice() As String
        Get
            Return strDec(mPrice)
        End Get
        Set(ByVal value As String)
            mPrice = strDec(value)
        End Set
    End Property

    Protected mRRP As Decimal?
    Public Property sRRP() As String
        Get
            Return strDec(mRRP)
        End Get
        Set(ByVal value As String)
            mRRP = strDec(value)
        End Set
    End Property

    Protected mPrc_SuppliersCode As String
    Public Property Prc_SuppliersCode() As String
        Get
            Return mPrc_SuppliersCode
        End Get
        Set(ByVal value As String)
            mPrc_SuppliersCode = value
        End Set
    End Property

    Protected mPhoneID As Integer?
    Public ReadOnly Property sPhoneID() As String
        Get
            Return strInt(mPhoneID)
        End Get
    End Property

    Protected mSup_id As Integer?
    Public Property sSup_id() As String
        Get
            Return strInt(mSup_id)
        End Get
        Set(ByVal value As String)
            mSup_id = strInt(value)
        End Set
    End Property
    Public Property Sup_id() As Integer
        Get
            Return mSup_id
        End Get
        Set(ByVal value As Integer)
            mSup_id = value
        End Set
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

#End Region





    'Public Sub SaveData()
    '    updatePhonePrice()
    'End Sub





#Region "Data Persistance"
#Region "Update"
    'Public Function updatePhonePrice()
    '    Dim connectionString As String = "DSN=RISK"
    '    Dim connection = New Odbc.OdbcConnection(connectionString)
    '    Dim updateStatement As String = "Update temp_ SET " _
    '    & "PhDesc1 = ?, " _
    '    & "Price = ?, " _
    '    & "RRP = ?, " _
    '    & "Prc_SuppliersCode = ?, " _
    '    & "Sup_id = ?, " _
    '    & "Sup_Name = ? " _
    '    & "where PhoneID like ?"



    '    Dim updateCommand As New Odbc.OdbcCommand(updateStatement, connection)

    '    updateCommand.Parameters.AddWithValue("@PhDesc1", nString(Me.mPhDesc1))
    '    updateCommand.Parameters.AddWithValue("@Price", nDecimal(Me.mPrice))
    '    updateCommand.Parameters.AddWithValue("@RRP", nDecimal(Me.mRRP))
    '    updateCommand.Parameters.AddWithValue("@Prc_SuppliersCode", nString(Me.mPrc_SuppliersCode))
    '    updateCommand.Parameters.AddWithValue("@Sup_id", nInteger(Me.mSup_id))
    '    updateCommand.Parameters.AddWithValue("@Sup_Name", nString(Me.mSup_Name))
    '    updateCommand.Parameters.AddWithValue("@PhoneID", nInteger(Me.mPhoneID))
    '    Try
    '        connection.Open()
    '        Dim count As Integer = UpdateCommand.ExecuteNonQuery
    '        If count > 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Odbc.OdbcException
    '        Throw ex
    '    Finally
    '        connection.Close()
    '    End Try
    '    commitUpdate(connection, updateCommand)
    'End Function
#End Region
#Region "Add"
#End Region
#Region "Delete"
#End Region
#End Region





End Class




Public Class PhonePrice
    Inherits PhonePriceDB
#Region "Data Persistance"
#Region "Select"
    'Public Shared Function getPhonePrice(ByVal PhoneID As Integer) As PhonePrice
    '    Dim PhonePrice As New PhonePrice
    '    Dim connectionString As String = "DSN=RISK"
    '    Dim connection = New Odbc.OdbcConnection(connectionString)
    '    Dim selectStatement As String _
    '    = "Select * " _
    '    & "from temp_ " _
    '    & "where PhoneID = '" + PhoneID + "'"
    '    Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
    '    Try
    '        connection.Open()
    '        Dim reader As Odbc.OdbcDataReader _
    '        = SelectCommand.ExecuteReader()
    '        If reader.Read Then
    '            PhonePrice.mPhDesc1 = nString(reader("PhDesc1"))
    '            PhonePrice.mPrice = nDecimal(reader("Price"))
    '            PhonePrice.mRRP = nDecimal(reader("RRP"))
    '            PhonePrice.mprc_SuppliersCode = nString(reader("prc_SuppliersCode"))
    '            PhonePrice.mPhoneID = nInteger(reader("PhoneID"))
    '            PhonePrice.msup_id = nInteger(reader("sup_id"))
    '            PhonePrice.msup_Name = nString(reader("sup_Name"))
    '        Else
    '            PhonePrice = New PhonePrice()
    '        End If
    '        reader.Close()
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        connection.Close()
    '    End Try
    '    Return PhonePrice
    'End Function

    Public Shared Function getPhonePrice(ByVal strWhereClause As String, ByVal strOrderByClause As String) As PhonePrice()
        Dim PhonePrice(0) As PhonePrice
        PhonePrice(0) = New PhonePrice
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "SELECT tblPhone.Make + ' ' + tblPhone.Model + ' ' + tblPhone.ImportColour AS PhDesc1, tblPrice.Price, tblPrice.prc_SuppliersRRP AS RRP, tblPrice.prc_SuppliersCode, tblPrice.PhoneID, t_Supplier.sup_id, t_Supplier.sup_Name " _
        & "FROM t_Supplier inner join tblPrice on t_Supplier.sup_ReplacementPhoneSchemeId = tblPrice.SchemeID inner join tblPhone on tblPrice.PhoneID = tblPhone.PhoneID " _
        & strWhereClause + " " + strOrderByClause

        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            Dim i = -1
            While reader.Read
                i += 1
                ReDim Preserve PhonePrice(i)
                PhonePrice(i) = New PhonePrice
                PhonePrice(i).mPhDesc1 = nString(reader("PhDesc1"))
                PhonePrice(i).mPrice = nDecimal(reader("Price"))
                PhonePrice(i).mRRP = nDecimal(reader("RRP"))
                PhonePrice(i).mprc_SuppliersCode = nString(reader("prc_SuppliersCode"))
                PhonePrice(i).mPhoneID = nInteger(reader("PhoneID"))
                PhonePrice(i).msup_id = nInteger(reader("sup_id"))
                PhonePrice(i).msup_Name = nString(reader("sup_Name"))
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return PhonePrice
    End Function
#End Region
#End Region
End Class
