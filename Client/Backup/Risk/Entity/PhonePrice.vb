Partial Class PhonePriceDB
    Protected Overloads Function strDec(ByVal value As Decimal?) As String
        If value.HasValue Then
            Return value.ToString
        Else
            Return "0"
        End If
    End Function
End Class

Partial Class PhonePrice

#Region "Data Persistance"

    Public Shared Function getPhonePrice(ByVal PhoneID As Integer, ByVal supID As Integer) As PhonePrice
        Dim PhonePrice As New PhonePrice
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "SELECT tblPhone.Make + ' ' + tblPhone.Model + ' ' + tblPhone.ImportColour AS PhDesc1, tblPrice.Price, tblPrice.prc_SuppliersRRP AS RRP, tblPrice.prc_SuppliersCode, tblPrice.PhoneID, t_Supplier.sup_id, t_Supplier.sup_Name " _
        & "FROM t_Supplier inner join tblPrice on t_Supplier.sup_ReplacementPhoneSchemeId = tblPrice.SchemeID inner join tblPhone on tblPrice.PhoneID = tblPhone.PhoneID " _
        & "where tblPrice.PhoneID = " + PhoneID.ToString + " and sup_id = " + supID.ToString _
        & "ORDER BY PhDesc1, tblPrice.PhoneID"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = selectCommand.ExecuteReader()
            If reader.Read Then
                PhonePrice.mPhDesc1 = nString(reader("PhDesc1"))
                PhonePrice.mPrice = nDecimal(reader("Price"))
                PhonePrice.mRRP = nDecimal(reader("RRP"))
                PhonePrice.mPrc_SuppliersCode = nString(reader("prc_SuppliersCode"))
                PhonePrice.mPhoneID = nInteger(reader("PhoneID"))
                PhonePrice.mSup_id = nInteger(reader("sup_id"))
                PhonePrice.mSup_Name = nString(reader("sup_Name"))
            Else
                PhonePrice = New PhonePrice()
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return PhonePrice
    End Function

#End Region

    Public Shared Function getPhonePrice(ByVal supID As Integer) As PhonePrice()
        Return getPhonePrice("where sup_id = " + supID.ToString, "ORDER BY PhDesc1, tblPrice.PhoneID")
    End Function

    Public ReadOnly Property Item(ByVal Index As Integer) As String 'Output array of columns
        Get
            Dim i(6) As String
            i(0) = Me.PhDesc1
            i(1) = Me.sPrice
            i(2) = Me.sRRP
            i(3) = Me.Prc_SuppliersCode
            i(4) = Me.sPhoneID
            i(5) = Me.sSup_id
            i(6) = Me.Sup_Name
            Return i(Index)
        End Get
    End Property

End Class
