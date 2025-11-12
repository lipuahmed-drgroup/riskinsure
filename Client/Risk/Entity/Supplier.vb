Partial Class Supplier

#Region "Data Persistance"

    Public Shared Function getSupplier() As Supplier()
        Dim subQuery As String = "" _
        & "SELECT DISTINCT sup_id " _
        & "FROM dbo.tblPhone " _
        & "INNER JOIN dbo.tblPrice " _
        & "ON dbo.tblPhone.PhoneID = dbo.tblPrice.PhoneID " _
        & "INNER JOIN dbo.t_Supplier " _
        & "ON dbo.tblPrice.SchemeID = dbo.t_Supplier.sup_ReplacementPhoneSchemeId"
        Return getSupplier("where output = 1 and sup_id in (" + subQuery + ")", "order by sup_Name Asc")
    End Function

#End Region


    Private Shared mSuppliers() As Supplier = getSupplier()
    Public Shared ReadOnly Property Suppliers() As Supplier()
        Get
            Return mSuppliers
        End Get
    End Property



End Class
