Option Strict On

Partial Class ClaimDB

    Protected Overloads Shared Function strDec(ByVal value As Decimal?) As String
        Return FormatCurrency(value.ToString, 2, TriState.True)
    End Function 'Format of textbox access to Decimal based fields
    Protected Overloads Shared Function strDate(ByVal value As Date?) As String 'Method to convert date? into string
        If value.HasValue Then
            Return Format(value, "d MMM yyyy")
        Else
            Return ""
        End If
    End Function 'Format of textbox access to Date fields
    Protected Overloads Shared Function strDec_Real(ByVal value As Decimal?) As String
        Return FormatPercent(value)
    End Function 'Format of textbox access to Decimal based fields
    Protected Overloads Shared Function strInt(ByVal value As Integer?) As String
        If value.HasValue Then
            Return value.ToString
        Else
            Return "0"
        End If
    End Function

End Class

Partial Class Claim

    Private mUserID As String = Risk_Insure_Claims_Management_System.UserName

#Region "Replace Phone"

    Private mSupplierPhones() As PhonePrice
    'Public Event UpdateLocality(ByVal country As String)

    Public ReadOnly Property SupplierPhones() As PhonePrice()
        Get
            Return mSupplierPhones
        End Get
    End Property

    Public Sub InitializeChildren()
        mSupplierPhones = PhonePrice.getPhonePrice(CInt(MyBase.sCla_ReplacePhone_sup_id))
    End Sub

    Public Shadows Property sSchemeID() As String
        Get
            'If MyBase.sSchemeID = "" Then
            '    RaiseEvent UpdateLocality("")
            'Else
            '    RaiseEvent UpdateLocality(Scheme.getScheme(CInt(MyBase.sSchemeID)).Country)
            'End If
            Return MyBase.sSchemeID
        End Get
        Set(ByVal value As String)
            MyBase.sSchemeID = value
            If value = "" Then
                Me.sReplacePhoneID = "0"
                Me.sSimcardCost = "0"
                '    RaiseEvent UpdateLocality("")
                'Else
                '    RaiseEvent UpdateLocality(Scheme.getScheme(CInt(value)).Country)
            End If
        End Set
    End Property

    Public Shadows Property sReplacePhoneID() As String 'Replace Phone PhonePrice
        Get
            Return MyBase.sReplacePhoneID
        End Get
        Set(ByVal value As String)
            MyBase.sReplacePhoneID = value
            Dim phone = PhonePrice.getPhonePrice(MyBase.ReplacePhoneID, MyBase.Cla_ReplacePhone_sup_id)
            MyBase.sReplaceCost = phone.sPrice
            MyBase.sCla_ReplacePhoneRRP = phone.sRRP
            MyBase.Cla_ReplacePhone_SuppliersCode = phone.Prc_SuppliersCode
        End Set
    End Property

    Public Shadows Property sCla_ReplacePhone_sup_id() As String 'Replace Phone Supplier
        Get
            Return MyBase.sCla_ReplacePhone_sup_id
        End Get
        Set(ByVal value As String)
            mSupplierPhones = PhonePrice.getPhonePrice(CInt(value))
            MyBase.sCla_ReplacePhone_sup_id = value
            mFreightCost = getFreightCost()
        End Set
    End Property

    Public Shared Function getClaim(ByVal ClaimNumberValue As String, ByVal initializeChildren As Boolean) As Claim
        Dim claim = getClaim(ClaimNumberValue)
        If initializeChildren Then
            claim.InitializeChildren()
        End If
        Return claim
    End Function

    Public Function getFreightCost() As Decimal?
        Dim s = Supplier.getSupplier(CInt(strInt(mCla_ReplacePhone_sup_id)))
        If MyBase.mCla_FreightCostType = "Phone & Sim" Then
            Return CDec(s.sSup_FreightPhoneSim)
        ElseIf MyBase.mCla_FreightCostType = "Phone Only" Then
            Return CDec(s.sSup_FreightPhoneOnly)
        ElseIf MyBase.mCla_FreightCostType = "Sim Only" Then
            Return CDec(s.sSup_FreightSimOnly)
        Else
            Return 0
        End If
    End Function

    Public Shadows Property Cla_FreightCostType() As String
        Get
            Return MyBase.Cla_FreightCostType
        End Get
        Set(ByVal value As String)
            MyBase.Cla_FreightCostType = value
            mFreightCost = getFreightCost()
        End Set
    End Property

    Public ReadOnly Property ReplacementPhoneMakeModel() As String
        Get
            Return Phone.getPhone(MyBase.ReplacePhoneID).PhDesc
        End Get
    End Property

#End Region 'Replace Phone

#Region "Status"

    Public Shadows ReadOnly Property Status() As String
        Get
            Dim out As String
            If Not (DeclinedStatusDate.HasValue Or CancelledStatusDate.HasValue Or ApprovedStatusDate.HasValue) Then
                out = "More Info"
            Else
                If DeclinedStatusDate >= minDateOrValue(MoreInfoStatusDate) _
                And DeclinedStatusDate >= minDateOrValue(CancelledStatusDate) _
                And DeclinedStatusDate >= minDateOrValue(PaidStatusDate) _
                And DeclinedStatusDate >= minDateOrValue(ApprovedStatusDate) Then
                    out = "Declined"
                ElseIf CancelledStatusDate >= minDateOrValue(MoreInfoStatusDate) _
                And CancelledStatusDate >= minDateOrValue(PaidStatusDate) _
                And CancelledStatusDate >= minDateOrValue(ApprovedStatusDate) Then
                    out = "Cancelled"
                ElseIf PaidStatusDate >= minDateOrValue(MoreInfoStatusDate) _
                And PaidStatusDate >= minDateOrValue(ApprovedStatusDate) Then
                    out = "Paid"
                ElseIf ApprovedStatusDate >= minDateOrValue(MoreInfoStatusDate) Then
                    out = "Approved"
                Else
                    out = "More Info"
                End If
            End If
            MyBase.Status = out
            Return out
        End Get
    End Property

    Private Function minDateOrValue(ByVal inDate As Date?) As Date
        If inDate.HasValue Then
            Return CDate(inDate)
        Else
            Return Date.MinValue
        End If
    End Function

    Public Shadows Property sUpdateDate() As String
        Get
            Return MyBase.sUpdateDate
        End Get
        Set(ByVal value As String)
            MyBase.sUpdateDate = value
            If Not value = "" Then
                UpdateUserID = mUserID
            Else
                ' UpdateUserID = Nothing
                UpdateUserID = ""
            End If
        End Set
    End Property

    Public Shadows Property sDeclinedStatusDate() As String
        Get
            Return MyBase.sDeclinedStatusDate
        End Get
        Set(ByVal value As String)
            MyBase.sDeclinedStatusDate = value
            If Not value = "" Then
                DeclinedUserid = mUserID
            Else
                '  DeclinedUserid = Nothing
                DeclinedUserid = ""
            End If
        End Set
    End Property


    Public Shadows Property sMoreInfoStatusDate() As String
        Get
            Return MyBase.sMoreInfoStatusDate
        End Get
        Set(ByVal value As String)
            MyBase.sMoreInfoStatusDate = value
            If Not value = "" Then
                MoreInfoUserid = mUserID
            Else
                ' MoreInfoUserid = Nothing
                MoreInfoUserid = ""
            End If
        End Set
    End Property

    Public Shadows Property sCancelledStatusDate() As String
        Get
            Return MyBase.sCancelledStatusDate
        End Get
        Set(ByVal value As String)
            MyBase.sCancelledStatusDate = value
            If Not value = "" Then
                CancelledUserid = mUserID
            Else
                'CancelledUserid = Nothing
                CancelledUserid = ""


            End If
        End Set
    End Property

    '   Public isSaving As Boolean = False
    Public Shadows Property sApprovedStatusDate() As String
        Get
            Return MyBase.sApprovedStatusDate
        End Get
        Set(ByVal value As String)
            If Not value = "" Then
                If Not MyBase.ApprovedStatusDate.HasValue Or Not MyBase.sApprovedStatusDate = value Then
                    If Not Cla_ProofOfPurchase Then
                        MsgBox("Proof of Purchase is not ticked." & vbCrLf & _
                               vbCrLf & "Please check if it is required.", vbExclamation, "Warning")
                    End If
                End If
            End If

            MyBase.sApprovedStatusDate = value
            If Not value = "" Then
                ApprovedUserid = mUserID
            Else
                ' ApprovedUserid = Nothing
                ApprovedUserid = ""
            End If

        End Set
    End Property

    Public Shadows Property sPaidStatusDate() As String
        Get
            Return MyBase.sPaidStatusDate
        End Get
        Set(ByVal value As String)
            If Not value = "" And Not value = MyBase.sPaidStatusDate Then
                PaidUserid = mUserID
            End If
            MyBase.sPaidStatusDate = value
        End Set
    End Property

    Public Shadows Property sExcessPaidStatusDate() As String
        Get
            Return MyBase.sExcessPaidStatusDate
        End Get
        Set(ByVal value As String)
            If Not value = "" And Not value = MyBase.sExcessPaidStatusDate Then
                PaidUserid = mUserID
            End If
            MyBase.sExcessPaidStatusDate = value
        End Set
    End Property

    Public Shadows Property sRepairerPaidStatusDate() As String
        Get
            Return MyBase.sRepairerPaidStatusDate
        End Get
        Set(ByVal value As String)
            If Not value = "" And Not value = MyBase.sRepairerPaidStatusDate Then
                PaidUserid = mUserID
            End If
            MyBase.sRepairerPaidStatusDate = value
        End Set
    End Property

    Public Shadows Property scla_SimCardPaidToDate() As String
        Get
            Return MyBase.sCla_SimCardPaidToDate
        End Get
        Set(ByVal value As String)
            If Not value = "" And Not value = MyBase.sCla_SimCardPaidToDate Then
                PaidUserid = mUserID
            End If
            MyBase.sCla_SimCardPaidToDate = value
        End Set
    End Property

    Public Shadows Property scla_RepairerPaidToDate() As String
        Get
            Return MyBase.sCla_RepairerPaidToDate
        End Get
        Set(ByVal value As String)
            If Not value = "" And Not value = MyBase.sCla_RepairerPaidToDate Then
                PaidUserid = mUserID
            End If
            MyBase.sCla_RepairerPaidToDate = value
        End Set
    End Property

    Public Shadows Property scla_OtherPaidToDate() As String
        Get
            Return MyBase.sCla_OtherPaidToDate
        End Get
        Set(ByVal value As String)
            If Not value = "" And Not value = MyBase.sCla_OtherPaidToDate Then
                PaidUserid = mUserID
            End If
            MyBase.sCla_OtherPaidToDate = value
        End Set
    End Property





    Public Shadows Property UpdateDate() As Date?
        Get
            Return MyBase.UpdateDate
        End Get
        Set(ByVal value As Date?)
            MyBase.UpdateDate = value
            If value.HasValue Then
                UpdateUserID = mUserID
            Else
                UpdateUserID = Nothing
            End If
        End Set
    End Property

    Public Shadows Property DeclinedStatusDate() As Date?
        Get
            Return MyBase.DeclinedStatusDate
        End Get
        Set(ByVal value As Date?)
            MyBase.DeclinedStatusDate = value
            If value.HasValue Then
                DeclinedUserid = mUserID
            Else
                DeclinedUserid = Nothing
            End If
        End Set
    End Property


    Public Shadows Property MoreInfoStatusDate() As Date?
        Get
            Return MyBase.MoreInfoStatusDate
        End Get
        Set(ByVal value As Date?)
            MyBase.MoreInfoStatusDate = value
            If value.HasValue Then
                MoreInfoUserid = mUserID
            Else
                MoreInfoUserid = Nothing
            End If
        End Set
    End Property

    Public Shadows Property CancelledStatusDate() As Date?
        Get
            Return MyBase.CancelledStatusDate
        End Get
        Set(ByVal value As Date?)
            MyBase.CancelledStatusDate = value
            If value.HasValue Then
                CancelledUserid = mUserID
            Else
                CancelledUserid = Nothing
            End If
        End Set
    End Property

    '   Public isSaving As Boolean = False
    Public Shadows Property ApprovedStatusDate() As Date?
        Get
            Return MyBase.ApprovedStatusDate
        End Get
        Set(ByVal value As Date?)
            If value.HasValue Then
                If Not MyBase.ApprovedStatusDate.HasValue Or Not MyBase.ApprovedStatusDate = value Then
                    If Not Cla_ProofOfPurchase Then
                        MsgBox("Proof of Purchase is not ticked." & vbCrLf & _
                               vbCrLf & "Please check if it is required.", vbExclamation, "Warning")
                    End If
                End If
            End If

            MyBase.ApprovedStatusDate = value
            If value.HasValue Then
                ApprovedUserid = mUserID
            Else
                ApprovedUserid = Nothing
            End If

        End Set
    End Property

    Public Shadows Property PaidStatusDate() As Date?
        Get
            Return MyBase.PaidStatusDate
        End Get
        Set(ByVal value As Date?)
            If value.HasValue And Not value = MyBase.PaidStatusDate Then
                PaidUserid = mUserID
            End If
            MyBase.PaidStatusDate = value
        End Set
    End Property

    Public Shadows Property ExcessPaidStatusDate() As Date?
        Get
            Return MyBase.ExcessPaidStatusDate
        End Get
        Set(ByVal value As Date?)
            If value.HasValue And Not value = MyBase.ExcessPaidStatusDate Then
                PaidUserid = mUserID
            End If
            MyBase.ExcessPaidStatusDate = value
        End Set
    End Property

    Public Shadows Property RepairerPaidStatusDate() As Date?
        Get
            Return MyBase.RepairerPaidStatusDate
        End Get
        Set(ByVal value As Date?)
            If value.HasValue And Not value = MyBase.RepairerPaidStatusDate Then
                PaidUserid = mUserID
            End If
            MyBase.RepairerPaidStatusDate = value
        End Set
    End Property

    Public Shadows Property cla_SimCardPaidToDate() As Date?
        Get
            Return MyBase.Cla_SimCardPaidToDate
        End Get
        Set(ByVal value As Date?)
            If value.HasValue And Not value = MyBase.Cla_SimCardPaidToDate Then
                PaidUserid = mUserID
            End If
            MyBase.Cla_SimCardPaidToDate = value
        End Set
    End Property

    Public Shadows Property cla_RepairerPaidToDate() As Date?
        Get
            Return MyBase.Cla_RepairerPaidToDate
        End Get
        Set(ByVal value As Date?)
            If value.HasValue And Not value = MyBase.Cla_RepairerPaidToDate Then
                PaidUserid = mUserID
            End If
            MyBase.Cla_RepairerPaidToDate = value
        End Set
    End Property

    Public Shadows Property cla_OtherPaidToDate() As Date?
        Get
            Return MyBase.Cla_OtherPaidToDate
        End Get
        Set(ByVal value As Date?)
            If value.HasValue And Not value = MyBase.Cla_OtherPaidToDate Then
                PaidUserid = mUserID
            End If
            MyBase.Cla_OtherPaidToDate = value
        End Set
    End Property

#End Region 'Status

#Region "TotalClaimCost"

    Public Event oUseOtherSupplier_True()
    Public Event oUseOtherSupplier_False()

    Public Shadows ReadOnly Property sTotalClaimCost() As String
        Get
            Dim total As Decimal = 0
            If RepairReplaceCashIndicator = "" Or Status = "Declined" Then
                total = 0
            Else
                total = CDec(sTotalClaimCostIncGST) - CDec(sExcess)
            End If
            MyBase.sTotalClaimCost = total.ToString 'Persists total to DB
            Return strDec(total)
        End Get
    End Property

    Public Shadows ReadOnly Property sTotalCostLessGST() As String
        Get
            Dim total As Decimal = 0
            If RepairReplaceCashIndicator = "" Or Status = "Declined" Then
                total = 0
            Else
                total = CDec(sTotalClaimCostIncGST) - CDec(sExcess) - CDec(sGST)
            End If
            MyBase.sTotalCostLessGST = total.ToString 'Persists total to DB
            Return strDec(total)
        End Get
    End Property

    Public Shadows Property oUseSupplier() As Boolean?
        Get
            Dim out As Boolean
            If MyBase.OUseSupplier.HasValue Then
                out = CBool(MyBase.OUseSupplier)
                If MyBase.OUseSupplier Then RaiseEvent oUseOtherSupplier_True() Else RaiseEvent oUseOtherSupplier_False()
            Else
                out = False
                RaiseEvent oUseOtherSupplier_False()
            End If
            Return out
        End Get
        Set(ByVal value As Boolean?)
            Dim out As Boolean = If(value.HasValue And mOUseSupplier.HasValue, If(Not value = mOUseSupplier, True, False), False)
            If out Then
                Me.sCla_ReplacePhone_sup_id = "0"
                Me.sReplacePhoneID = "0"
                If value Then RaiseEvent oUseOtherSupplier_True() Else RaiseEvent oUseOtherSupplier_False()
            End If
            MyBase.OUseSupplier = value
        End Set
    End Property

    Public ReadOnly Property sTotalClaimCostIncGST() As String
        Get
            Return strDec(mReplaceCost + _
                        mFreightCost + _
                        mAccLeatherCase + _
                        mSimcardCost + _
                        mRepairCost + _
                        mUnauthorisedCalls + _
                        mCla_ShortfallUpgradeCost + _
                        mReplaceVarianceCost + _
                        mAccOther + _
                        mCashSettleAmount)

        End Get
    End Property

    Public ReadOnly Property sTotalClaimCostExGST() As String
        Get
            Return strDec(CDec(Me.sTotalClaimCostIncGST) - mGST)
        End Get
    End Property

    Public Shadows ReadOnly Property sGST() As String
        Get
            Dim gst As Decimal = 0
            If RepairReplaceCashIndicator = "" Or Status = "Declined" Then
                gst = 0
            Else
                gst = CDec(Math.Round(CDec(sTotalClaimCostIncGST) / 11, 2))
            End If
            MyBase.sGST = gst.ToString
            Return strDec(gst)
        End Get
    End Property

    Public Shadows ReadOnly Property sCla_OutstandingAmount() As String
        Get
            Dim total As Decimal = 0
            total = CDec(CDec(sTotalClaimCost) - _
            (mCla_PhoneAccessoriesInvoiceNo1Amt _
            + mCla_PhoneAccessoriesInvoiceNo2Amt _
            + mCla_PhoneAccessoriesInvoiceNo3Amt _
            + mCla_PhoneAccessoriesInvoiceNo4Amt _
            + mCla_PhoneAccessoriesInvoiceNo5Amt _
            + mCla_PhoneAccessoriesInvoiceNo6Amt _
            + mCla_RepairerInvoiceNo1Amt _
            + mCla_RepairerInvoiceNo2Amt _
            + mCla_RepairerInvoiceNo3Amt _
            + mCla_OtherInvoiceNo1Amt _
            + mCla_OtherInvoiceNo2Amt _
            + mCla_OtherInvoiceNo3Amt _
            + mCla_SimCardInvoiceNo1Amt))
            MyBase.sCla_OutstandingAmount = total.ToString
            Return strDec(total)
        End Get
    End Property

#End Region 'TotalClaimCost

#Region "InputTaxCredit"

    Public Shadows Property sInputTaxCredit() As String
        Get
            Return MyBase.sInputTaxCredit
        End Get
        Set(ByVal value As String)
            MyBase.sInputTaxCredit = CStr(CDec(value) / 100)
        End Set
    End Property
#End Region 'InputTaxCredit

#Region "BPay Number"

    Public Shadows ReadOnly Property Cla_BPayNumber() As String
        Get
            If Cla_BPayRequired And MyBase.Cla_BPayNumber = Nothing Then
                SetBPayNumber()
            End If
            Return MyBase.Cla_BPayNumber
        End Get
    End Property

    Public Sub SetBPayNumber()
        Dim BPayNumber As String = Me.sCla_BPayNumberSeed
        Dim i As Integer
        Dim liDigitMod As Integer
        Dim liWeighting As Integer
        Dim liBPayNumber As Integer
        liWeighting = 2
        For i = 1 To Len(BPayNumber)
            liDigitMod = CInt((CDbl(Mid(BPayNumber, i, 1)) Mod 10) * liWeighting)
            If liDigitMod > 9 Then
                liDigitMod = CInt(Microsoft.VisualBasic.Left(CStr(liDigitMod), 1)) + CInt(Microsoft.VisualBasic.Right(CStr(liDigitMod), 1))
            End If
            liBPayNumber = liBPayNumber + liDigitMod
            If liWeighting = 2 Then
                liWeighting = 1
            Else
                liWeighting = 2
            End If
        Next i
        liBPayNumber = liBPayNumber Mod 10
        If liBPayNumber <> 0 Then liBPayNumber = 10 - liBPayNumber
        MyBase.Cla_BPayNumber = BPayNumber & liBPayNumber
    End Sub

#End Region 'BPay Number

#Region "Address"

#Region "Copy Address"

    Public Sub CopyAddress()
        Cla_DeliverPerson = Title + " " + GivenName + " " + FamilyName
        DeliveryAddress1 = PostalAddress1
        DeliveryAddress2 = PostalAddress2
        DeliverySuburb = PostalSuburb
        Cla_DeliveryState = Cla_PostalState
        DeliveryPostcode = PostalPostcode
        MsgBox("Postal Address Copied to Delivery Address")
    End Sub

#End Region 'Provides a method to copy all information from postal address to delivery address

#Region "Address ID Properties"

    Public Property PostalID() As String
        Get
            Dim p = PostCode.getPostCode(Me.mPostalSuburb, Me.mPostalPostcode, Me.Cla_PostalState)
            Return p.sPostCodeID
        End Get
        Set(ByVal value As String)
            Dim p = PostCode.getPostCode(CInt(value))
            Me.mPostalSuburb = p.Locality
            Me.mPostalPostcode = p.Pcode
            Me.mCla_PostalState = p.State
            DeliveryID = value
        End Set
    End Property

    Public Property DeliveryID() As String
        Get
            Dim p = PostCode.getPostCode(Me.mDeliverySuburb, Me.mDeliveryPostcode, Me.Cla_DeliveryState)
            Return p.sPostCodeID
        End Get
        Set(ByVal value As String)
            Dim p = PostCode.getPostCode(CInt(value))
            Me.mDeliverySuburb = p.Locality
            Me.mDeliveryPostcode = p.Pcode
            Me.Cla_DeliveryState = p.State
        End Set
    End Property

    Public Property DealerID() As String
        Get
            Dim p = PostCode.getPostCode(Me.mSuburb, Me.mPhoneDealelPostCode, Me.Cla_PhoneDealerState)
            Return p.sPostCodeID
        End Get
        Set(ByVal value As String)
            Dim p = PostCode.getPostCode(CInt(value))
            Me.mSuburb = p.Locality
            Me.mPhoneDealelPostCode = p.Pcode
            Me.Cla_PhoneDealerState = p.State
        End Set
    End Property

#End Region 'On Changing ID set values

#Region "PostCode Changed Event Handler"

    'Events to launch locality window
    Public Event PostalPostCode_Changed()
    Public Event DeliveryPostCode_Changed()
    Public Event DealerPostCode_Changed()

    Public Shadows Property PostalPostcode() As String
        Get
            Return MyBase.PostalPostcode
        End Get
        Set(ByVal value As String)
            Dim valueChanged = Not value = MyBase.PostalPostcode
            MyBase.PostalPostcode = value
            If valueChanged Then RaiseEvent PostalPostCode_Changed()
        End Set
    End Property

    Public Shadows Property DeliveryPostcode() As String
        Get
            Return MyBase.DeliveryPostcode
        End Get
        Set(ByVal value As String)
            Dim valueChanged = Not value = MyBase.DeliveryPostcode
            MyBase.DeliveryPostcode = value
            If valueChanged Then RaiseEvent DeliveryPostCode_Changed()
        End Set
    End Property

    Public Shadows Property PhoneDealelPostCode() As String
        Get
            Return MyBase.PhoneDealelPostCode
        End Get
        Set(ByVal value As String)
            Dim valueChanged = Not value = MyBase.PhoneDealelPostCode
            MyBase.PhoneDealelPostCode = value
            If valueChanged Then RaiseEvent DealerPostCode_Changed()
        End Set
    End Property

#End Region 'On postcode change -> raise events -> launch locality window




#Region "Old Properties"

    'Public Event PostalSuburb_Changed()
    'Public Event DealerSuburb_Changed()
    'Public Event DeliverySuburb_Changed()

    'Public Shadows Property PostalSuburb() As String
    '    Get
    '        Return MyBase.PostalSuburb
    '    End Get
    '    Set(ByVal value As String)
    '        MyBase.PostalSuburb = value
    '        'RaiseEvent PostalSuburb_Changed()
    '        DeliverySuburb = value
    '    End Set
    'End Property

    'Public Shadows Property Suburb() As String 'Dealer Suburb
    '    Get
    '        Return MyBase.Suburb
    '    End Get
    '    Set(ByVal value As String)
    '        MyBase.Suburb = value
    '        RaiseEvent DealerSuburb_Changed()
    '    End Set
    'End Property

    'Public Shadows Property DeliverySuburb() As String 'Delivery Suburb
    '    Get
    '        Return MyBase.DeliverySuburb
    '    End Get
    '    Set(ByVal value As String)
    '        MyBase.DeliverySuburb = value
    '        RaiseEvent DeliverySuburb_Changed()
    '    End Set
    'End Property

#Region "Postal Address"

    'Public Shadows Property PostalAddress1() As String
    '    Get
    '        Return MyBase.PostalAddress1
    '    End Get
    '    Set(ByVal value As String)
    '        MyBase.PostalAddress1 = value
    '        DeliveryAddress1 = value
    '    End Set
    'End Property

    'Public Shadows Property PostalAddress2() As String
    '    Get
    '        Return MyBase.PostalAddress2
    '    End Get
    '    Set(ByVal value As String)
    '        MyBase.PostalAddress2 = value
    '        DeliveryAddress2 = value
    '    End Set
    'End Property

    'Public Shadows Property PostalPostcode() As String
    '    Get
    '        Return MyBase.PostalPostcode
    '    End Get
    '    Set(ByVal value As String)
    '        MyBase.PostalPostcode = value
    '        DeliveryPostcode = value
    '    End Set
    'End Property

    'Public Shadows Property cla_PostalState() As String
    '    Get
    '        Return MyBase.Cla_PostalState
    '    End Get
    '    Set(ByVal value As String)
    '        MyBase.Cla_PostalState = value
    '        Cla_DeliveryState = value
    '    End Set
    'End Property

#End Region 'Postal Address

#End Region 'Old Properties

#End Region 'Address copy, set address values from ID, provide event to launch locality window

#Region "bDatesOK"
    Public Shadows Property LossDate() As Date?
        Get
            Return MyBase.LossDate
        End Get
        Set(ByVal value As Date?)
            MyBase.LossDate = value
            'If value < InsuranceDate Then
            '    MsgBox("Loss Date is before the commencement of Insurance")
            'ElseIf value > Date.Now Then
            '    MyBase.LossDate = Date.Now
            'Else
            '    MyBase.LossDate = value
            'End If
        End Set
    End Property

    Public Shadows Property InsuranceDate() As Date?
        Get
            Return MyBase.InsuranceDate
        End Get
        Set(ByVal value As Date?)
            MyBase.InsuranceDate = value
            'If LossDate < value Then
            '    MsgBox("Loss Date is before the commencement of Insurance")
            'Else
            '    MyBase.InsuranceDate = value
            'End If
        End Set
    End Property

#End Region 'bDatesOK

#Region "Credit Card Amount / 100"

    Public Shadows Property sCla_CCAmount() As String
        Get
            'Return strDec(mCla_CCAmount) - Phase 3
            Return CInt(mCla_CCAmount).ToString

        End Get
        Set(ByVal value As String)
            'mCla_CCAmount = CDec(strDec(value) / 100) - Phase 3
            If value = "" Then
                mCla_CCAmount = 0
            Else
                mCla_CCAmount = CDec(CInt((value)))
            End If
        End Set
    End Property
#End Region

#Region "PoliceReport"

    Public Shadows Property PoliceReportNumber() As String
        Get
            Return mPoliceReportNumber
        End Get
        Set(ByVal value As String)
            Dim l As Integer = 0
            If value.Count > 25 Then
                MsgBox("Police Report Number cannot exceed 25 characters and has been truncated")
                l = 25
            Else
                l = value.Count
            End If
            mPoliceReportNumber = value.Substring(0, l)
            'mPoliceReportNumber = value
        End Set
    End Property

#End Region 'Police Report


    Public Shadows Property DamageType() As String
        Get
            Return mDamageType
        End Get
        Set(ByVal value As String)
            If value.Length > 4000 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                If value.Length > mDamageType.Length Then
                    'MsgBox("I am going to read back your claim description verbatim followed by a legal declaration that you agree to the circumstance obtained by you today. You will need to respond with yes or no to the declaration.")
                End If
                mDamageType = value
            End If
        End Set
    End Property

    Public Shadows Property sDateTimeSimReplaced() As String
        Get
            '  Return strDate(mDateTimeSimReplaced)
            If mDateTimeSimReplaced.HasValue Then
                Return CStr(mDateTimeSimReplaced)
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            '   mDateTimeSimReplaced = strDate(value)
            If value = "" Then
                mDateTimeSimReplaced = Nothing
            Else
                mDateTimeSimReplaced = CType(value, Date?)
            End If
        End Set
    End Property


End Class
