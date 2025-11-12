Imports nsDataClass
Public Class ClaimDB
    Inherits DataClass

#Region "SQL Columns"
    Protected mClaimNumber As String
    Public ReadOnly Property ClaimNumber() As String
        Get
            Return mClaimNumber
        End Get
    End Property

    Protected mStatus As String
    Public Property Status() As String
        Get
            Return mStatus
        End Get
        Set(ByVal value As String)
            If value.length > 9 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mStatus = value
            End If
        End Set
    End Property

    Protected mLodgedDate As Date?
    Public Property LodgedDate() As Date?
        Get
            Return mLodgedDate
        End Get
        Set(ByVal value As Date?)
            mLodgedDate = value
        End Set
    End Property
    Public Property sLodgedDate() As String
        Get
            Return strDate(mLodgedDate)
        End Get
        Set(ByVal value As String)
            mLodgedDate = strDate(value)
        End Set
    End Property

    Protected mAfterHoursFlag As Boolean?
    Public Property AfterHoursFlag() As Boolean?
        Get
            Return mAfterHoursFlag
        End Get
        Set(ByVal value As Boolean?)
            mAfterHoursFlag = value
        End Set
    End Property

    Protected mNESLodger As String
    Public Property NESLodger() As String
        Get
            Return mNESLodger
        End Get
        Set(ByVal value As String)
            If value.length > 30 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mNESLodger = value
            End If
        End Set
    End Property

    Protected mInformationConsentFlag As Boolean?
    Public Property InformationConsentFlag() As Boolean?
        Get
            Return mInformationConsentFlag
        End Get
        Set(ByVal value As Boolean?)
            mInformationConsentFlag = value
        End Set
    End Property

    Protected mSchemeID As Integer?
    Public Property sSchemeID() As String
        Get
            Return strInt(mSchemeID)
        End Get
        Set(ByVal value As String)
            mSchemeID = strInt(value)
        End Set
    End Property
    Public Property SchemeID() As Integer
        Get
            Return mSchemeID
        End Get
        Set(ByVal value As Integer)
            mSchemeID = value
        End Set
    End Property

    Protected mMobilePhoneNumber As String
    Public Property MobilePhoneNumber() As String
        Get
            Return mMobilePhoneNumber
        End Get
        Set(ByVal value As String)
            If value.length > 16 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mMobilePhoneNumber = value
            End If
        End Set
    End Property

    Protected mIMEINumber As String
    Public Property IMEINumber() As String
        Get
            Return mIMEINumber
        End Get
        Set(ByVal value As String)
            If value.length > 15 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mIMEINumber = value
            End If
        End Set
    End Property

    Protected mNewIMEINumber As String
    Public Property NewIMEINumber() As String
        Get
            Return mNewIMEINumber
        End Get
        Set(ByVal value As String)
            If value.length > 15 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mNewIMEINumber = value
            End If
        End Set
    End Property

    Protected mCla_IMEIDate As Date?
    Public Property Cla_IMEIDate() As Date?
        Get
            Return mCla_IMEIDate
        End Get
        Set(ByVal value As Date?)
            mCla_IMEIDate = value
        End Set
    End Property
    Public Property sCla_IMEIDate() As String
        Get
            Return strDate(mCla_IMEIDate)
        End Get
        Set(ByVal value As String)
            mCla_IMEIDate = strDate(value)
        End Set
    End Property

    Protected mInsuranceDate As Date?
    Public Property InsuranceDate() As Date?
        Get
            Return mInsuranceDate
        End Get
        Set(ByVal value As Date?)
            mInsuranceDate = value
        End Set
    End Property
    Public Property sInsuranceDate() As String
        Get
            Return strDate(mInsuranceDate)
        End Get
        Set(ByVal value As String)
            mInsuranceDate = strDate(value)
        End Set
    End Property

    Protected mCompanyName As String
    Public Property CompanyName() As String
        Get
            Return mCompanyName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCompanyName = value
            End If
        End Set
    End Property

    Protected mFamilyName As String
    Public Property FamilyName() As String
        Get
            Return mFamilyName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mFamilyName = value
            End If
        End Set
    End Property

    Protected mGivenName As String
    Public Property GivenName() As String
        Get
            Return mGivenName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mGivenName = value
            End If
        End Set
    End Property

    Protected mTitle As String
    Public Property Title() As String
        Get
            Return mTitle
        End Get
        Set(ByVal value As String)
            If value.length > 10 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mTitle = value
            End If
        End Set
    End Property

    Protected mAccountNumber As String
    Public Property AccountNumber() As String
        Get
            Return mAccountNumber
        End Get
        Set(ByVal value As String)
            If value.length > 15 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mAccountNumber = value
            End If
        End Set
    End Property

    Protected mCla_LodgerLastName As String
    Public Property Cla_LodgerLastName() As String
        Get
            Return mCla_LodgerLastName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_LodgerLastName = value
            End If
        End Set
    End Property

    Protected mCla_LodgerFirstName As String
    Public Property Cla_LodgerFirstName() As String
        Get
            Return mCla_LodgerFirstName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_LodgerFirstName = value
            End If
        End Set
    End Property

    Protected mCla_LodgerRelationship As String
    Public Property Cla_LodgerRelationship() As String
        Get
            Return mCla_LodgerRelationship
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_LodgerRelationship = value
            End If
        End Set
    End Property

    Protected mLastPersonGivenName As String
    Public Property LastPersonGivenName() As String
        Get
            Return mLastPersonGivenName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mLastPersonGivenName = value
            End If
        End Set
    End Property

    Protected mLastPersonFamilyName As String
    Public Property LastPersonFamilyName() As String
        Get
            Return mLastPersonFamilyName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mLastPersonFamilyName = value
            End If
        End Set
    End Property

    Protected mContactNumber As String
    Public Property ContactNumber() As String
        Get
            Return mContactNumber
        End Get
        Set(ByVal value As String)
            If value.length > 20 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mContactNumber = value
            End If
        End Set
    End Property

    Protected mContactNumber2 As String
    Public Property ContactNumber2() As String
        Get
            Return mContactNumber2
        End Get
        Set(ByVal value As String)
            If value.length > 20 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mContactNumber2 = value
            End If
        End Set
    End Property

    Protected mPostalAddress1 As String
    Public Property PostalAddress1() As String
        Get
            Return mPostalAddress1
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mPostalAddress1 = value
            End If
        End Set
    End Property

    Protected mPostalAddress2 As String
    Public Property PostalAddress2() As String
        Get
            Return mPostalAddress2
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mPostalAddress2 = value
            End If
        End Set
    End Property

    Protected mPostalSuburb As String
    Public Property PostalSuburb() As String
        Get
            Return mPostalSuburb
        End Get
        Set(ByVal value As String)
            If value.length > 26 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mPostalSuburb = value
            End If
        End Set
    End Property

    Protected mPostalPostcode As String
    Public Property PostalPostcode() As String
        Get
            Return mPostalPostcode
        End Get
        Set(ByVal value As String)
            If value.length > 6 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mPostalPostcode = value
            End If
        End Set
    End Property

    Protected mPhoneDealer As String
    Public Property PhoneDealer() As String
        Get
            Return mPhoneDealer
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mPhoneDealer = value
            End If
        End Set
    End Property

    Protected mSuburb As String
    Public Property Suburb() As String
        Get
            Return mSuburb
        End Get
        Set(ByVal value As String)
            If value.length > 25 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mSuburb = value
            End If
        End Set
    End Property

    Protected mPhoneDealelPostCode As String
    Public Property PhoneDealelPostCode() As String
        Get
            Return mPhoneDealelPostCode
        End Get
        Set(ByVal value As String)
            If value.length > 6 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mPhoneDealelPostCode = value
            End If
        End Set
    End Property

    Protected mPurchaseDate As Date?
    Public Property PurchaseDate() As Date?
        Get
            Return mPurchaseDate
        End Get
        Set(ByVal value As Date?)
            mPurchaseDate = value
        End Set
    End Property
    Public Property sPurchaseDate() As String
        Get
            Return strDate(mPurchaseDate)
        End Get
        Set(ByVal value As String)
            mPurchaseDate = strDate(value)
        End Set
    End Property

    Protected mLossDate As Date?
    Public Property LossDate() As Date?
        Get
            Return mLossDate
        End Get
        Set(ByVal value As Date?)
            mLossDate = value
        End Set
    End Property
    Public Property sLossDate() As String
        Get
            Return strDate(mLossDate)
        End Get
        Set(ByVal value As String)
            mLossDate = strDate(value)
        End Set
    End Property

    Protected mDamageType As String
    Public Property DamageType() As String
        Get
            Return mDamageType
        End Get
        Set(ByVal value As String)
            If value.length > 4000 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mDamageType = value
            End If
        End Set
    End Property

    Protected mLossType As String
    Public Property LossType() As String
        Get
            Return mLossType
        End Get
        Set(ByVal value As String)
            If value.length > 30 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mLossType = value
            End If
        End Set
    End Property

    Protected mPreviousClaimFlag As Boolean?
    Public Property PreviousClaimFlag() As Boolean?
        Get
            Return mPreviousClaimFlag
        End Get
        Set(ByVal value As Boolean?)
            mPreviousClaimFlag = value
        End Set
    End Property

    Protected mPreviousClaimDate As Date?
    Public Property PreviousClaimDate() As Date?
        Get
            Return mPreviousClaimDate
        End Get
        Set(ByVal value As Date?)
            mPreviousClaimDate = value
        End Set
    End Property
    Public Property sPreviousClaimDate() As String
        Get
            Return strDate(mPreviousClaimDate)
        End Get
        Set(ByVal value As String)
            mPreviousClaimDate = strDate(value)
        End Set
    End Property

    Protected mCancelInsuranceFlag As Boolean?
    Public Property CancelInsuranceFlag() As Boolean?
        Get
            Return mCancelInsuranceFlag
        End Get
        Set(ByVal value As Boolean?)
            mCancelInsuranceFlag = value
        End Set
    End Property

    Protected mSimCardFlag As Boolean?
    Public Property SimCardFlag() As Boolean?
        Get
            Return mSimCardFlag
        End Get
        Set(ByVal value As Boolean?)
            mSimCardFlag = value
        End Set
    End Property

    Protected mCla_SimCardType As String
    Public Property Cla_SimCardType() As String
        Get
            Return mCla_SimCardType
        End Get
        Set(ByVal value As String)
            If value.length > 20 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_SimCardType = value
            End If
        End Set
    End Property

    Protected mCla_SimCardNumber As String
    Public Property Cla_SimCardNumber() As String
        Get
            Return mCla_SimCardNumber
        End Get
        Set(ByVal value As String)
            If value.length > 30 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_SimCardNumber = value
            End If
        End Set
    End Property

    Protected mCla_SimCardPreviousFlag As Boolean?
    Public Property Cla_SimCardPreviousFlag() As Boolean?
        Get
            Return mCla_SimCardPreviousFlag
        End Get
        Set(ByVal value As Boolean?)
            mCla_SimCardPreviousFlag = value
        End Set
    End Property

    Protected mAccLeatherCase As Decimal?
    Public Property sAccLeatherCase() As String
        Get
            Return strDec(mAccLeatherCase)
        End Get
        Set(ByVal value As String)
            mAccLeatherCase = strDec(value)
        End Set
    End Property

    Protected mAccHandsFree As Decimal?
    Public Property sAccHandsFree() As String
        Get
            Return strDec(mAccHandsFree)
        End Get
        Set(ByVal value As String)
            mAccHandsFree = strDec(value)
        End Set
    End Property

    Protected mAccOther As Decimal?
    Public Property sAccOther() As String
        Get
            Return strDec(mAccOther)
        End Get
        Set(ByVal value As String)
            mAccOther = strDec(value)
        End Set
    End Property

    Protected mAccOtherDescr As String
    Public Property AccOtherDescr() As String
        Get
            Return mAccOtherDescr
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mAccOtherDescr = value
            End If
        End Set
    End Property

    Protected mPoliceReportFlag As Boolean?
    Public Property PoliceReportFlag() As Boolean?
        Get
            Return mPoliceReportFlag
        End Get
        Set(ByVal value As Boolean?)
            mPoliceReportFlag = value
        End Set
    End Property

    Protected mPoliceReportNumber As String
    Public Property PoliceReportNumber() As String
        Get
            Return mPoliceReportNumber
        End Get
        Set(ByVal value As String)
            If value.length > 25 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mPoliceReportNumber = value
            End If
        End Set
    End Property

    Protected mCla_UnattendedPublic As Boolean?
    Public Property Cla_UnattendedPublic() As Boolean?
        Get
            Return mCla_UnattendedPublic
        End Get
        Set(ByVal value As Boolean?)
            mCla_UnattendedPublic = value
        End Set
    End Property

    Protected mCla_UnattendedIntentional As Boolean?
    Public Property Cla_UnattendedIntentional() As Boolean?
        Get
            Return mCla_UnattendedIntentional
        End Get
        Set(ByVal value As Boolean?)
            mCla_UnattendedIntentional = value
        End Set
    End Property

    Protected mCla_UnattendedVehicle As Boolean?
    Public Property Cla_UnattendedVehicle() As Boolean?
        Get
            Return mCla_UnattendedVehicle
        End Get
        Set(ByVal value As Boolean?)
            mCla_UnattendedVehicle = value
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
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mUpdateUserID = value
            End If
        End Set
    End Property

    Protected mExcess As Decimal?
    Public Property sExcess() As String
        Get
            Return strDec(mExcess)
        End Get
        Set(ByVal value As String)
            mExcess = strDec(value)
        End Set
    End Property

    Protected mUnauthorisedCalls As Decimal?
    Public Property sUnauthorisedCalls() As String
        Get
            Return strDec(mUnauthorisedCalls)
        End Get
        Set(ByVal value As String)
            mUnauthorisedCalls = strDec(value)
        End Set
    End Property

    Protected mGST As Decimal?
    Public Property sGST() As String
        Get
            Return strDec(mGST)
        End Get
        Set(ByVal value As String)
            mGST = strDec(value)
        End Set
    End Property

    Protected mRepairReplaceCashIndicator As String
    Public Property RepairReplaceCashIndicator() As String
        Get
            Return mRepairReplaceCashIndicator
        End Get
        Set(ByVal value As String)
            If value.length > 18 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mRepairReplaceCashIndicator = value
            End If
        End Set
    End Property

    Protected mCurrentPhoneID As Integer?
    Public Property sCurrentPhoneID() As String
        Get
            Return strInt(mCurrentPhoneID)
        End Get
        Set(ByVal value As String)
            mCurrentPhoneID = strInt(value)
        End Set
    End Property
    Public Property CurrentPhoneID() As Integer
        Get
            Return mCurrentPhoneID
        End Get
        Set(ByVal value As Integer)
            mCurrentPhoneID = value
        End Set
    End Property

    Protected mReplacePhoneID As Integer?
    Public Property sReplacePhoneID() As String
        Get
            Return strInt(mReplacePhoneID)
        End Get
        Set(ByVal value As String)
            mReplacePhoneID = strInt(value)
        End Set
    End Property
    Public Property ReplacePhoneID() As Integer
        Get
            Return mReplacePhoneID
        End Get
        Set(ByVal value As Integer)
            mReplacePhoneID = value
        End Set
    End Property

    Protected mReplaceCost As Decimal?
    Public Property sReplaceCost() As String
        Get
            Return strDec(mReplaceCost)
        End Get
        Set(ByVal value As String)
            mReplaceCost = strDec(value)
        End Set
    End Property

    Protected mReplaceVarianceCost As Decimal?
    Public Property sReplaceVarianceCost() As String
        Get
            Return strDec(mReplaceVarianceCost)
        End Get
        Set(ByVal value As String)
            mReplaceVarianceCost = strDec(value)
        End Set
    End Property

    Protected mSimcardCost As Decimal?
    Public Property sSimcardCost() As String
        Get
            Return strDec(mSimcardCost)
        End Get
        Set(ByVal value As String)
            mSimcardCost = strDec(value)
        End Set
    End Property

    Protected mCla_FreightCostType As String
    Public Property Cla_FreightCostType() As String
        Get
            Return mCla_FreightCostType
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_FreightCostType = value
            End If
        End Set
    End Property

    Protected mFreightCost As Decimal?
    Public Property sFreightCost() As String
        Get
            Return strDec(mFreightCost)
        End Get
        Set(ByVal value As String)
            mFreightCost = strDec(value)
        End Set
    End Property

    Protected mRepairer As String
    Public Property Repairer() As String
        Get
            Return mRepairer
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mRepairer = value
            End If
        End Set
    End Property

    Protected mRepairCost As Decimal?
    Public Property sRepairCost() As String
        Get
            Return strDec(mRepairCost)
        End Get
        Set(ByVal value As String)
            mRepairCost = strDec(value)
        End Set
    End Property

    Protected mAssessmentCost As Decimal?
    Public Property sAssessmentCost() As String
        Get
            Return strDec(mAssessmentCost)
        End Get
        Set(ByVal value As String)
            mAssessmentCost = strDec(value)
        End Set
    End Property

    Protected mCashCost As Decimal?
    Public Property sCashCost() As String
        Get
            Return strDec(mCashCost)
        End Get
        Set(ByVal value As String)
            mCashCost = strDec(value)
        End Set
    End Property

    Protected mDeliveryAddress1 As String
    Public Property DeliveryAddress1() As String
        Get
            Return mDeliveryAddress1
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mDeliveryAddress1 = value
            End If
        End Set
    End Property

    Protected mDeliveryAddress2 As String
    Public Property DeliveryAddress2() As String
        Get
            Return mDeliveryAddress2
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mDeliveryAddress2 = value
            End If
        End Set
    End Property

    Protected mDeliverySuburb As String
    Public Property DeliverySuburb() As String
        Get
            Return mDeliverySuburb
        End Get
        Set(ByVal value As String)
            If value.length > 26 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mDeliverySuburb = value
            End If
        End Set
    End Property

    Protected mDeliveryPostcode As String
    Public Property DeliveryPostcode() As String
        Get
            Return mDeliveryPostcode
        End Get
        Set(ByVal value As String)
            If value.length > 6 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mDeliveryPostcode = value
            End If
        End Set
    End Property

    Protected mCorrectInfoFlag As Boolean?
    Public Property CorrectInfoFlag() As Boolean?
        Get
            Return mCorrectInfoFlag
        End Get
        Set(ByVal value As Boolean?)
            mCorrectInfoFlag = value
        End Set
    End Property

    Protected mMoreInfoStatusDate As Date?
    Public Property MoreInfoStatusDate() As Date?
        Get
            Return mMoreInfoStatusDate
        End Get
        Set(ByVal value As Date?)
            mMoreInfoStatusDate = value
        End Set
    End Property
    Public Property sMoreInfoStatusDate() As String
        Get
            Return strDate(mMoreInfoStatusDate)
        End Get
        Set(ByVal value As String)
            mMoreInfoStatusDate = strDate(value)
        End Set
    End Property

    Protected mMoreInfoUserid As String
    Public Property MoreInfoUserid() As String
        Get
            Return mMoreInfoUserid
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mMoreInfoUserid = value
            End If
        End Set
    End Property

    Protected mCla_InvoiceNo1 As String
    Public Property Cla_InvoiceNo1() As String
        Get
            Return mCla_InvoiceNo1
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_InvoiceNo1 = value
            End If
        End Set
    End Property

    Protected mCla_InvoiceNo2 As String
    Public Property Cla_InvoiceNo2() As String
        Get
            Return mCla_InvoiceNo2
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_InvoiceNo2 = value
            End If
        End Set
    End Property

    Protected mApprovedStatusDate As Date?
    Public Property ApprovedStatusDate() As Date?
        Get
            Return mApprovedStatusDate
        End Get
        Set(ByVal value As Date?)
            mApprovedStatusDate = value
        End Set
    End Property
    Public Property sApprovedStatusDate() As String
        Get
            Return strDate(mApprovedStatusDate)
        End Get
        Set(ByVal value As String)
            mApprovedStatusDate = strDate(value)
        End Set
    End Property

    Protected mApprovedUserid As String
    Public Property ApprovedUserid() As String
        Get
            Return mApprovedUserid
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mApprovedUserid = value
            End If
        End Set
    End Property

    Protected mPaidStatusDate As Date?
    Public Property PaidStatusDate() As Date?
        Get
            Return mPaidStatusDate
        End Get
        Set(ByVal value As Date?)
            mPaidStatusDate = value
        End Set
    End Property
    Public Property sPaidStatusDate() As String
        Get
            Return strDate(mPaidStatusDate)
        End Get
        Set(ByVal value As String)
            mPaidStatusDate = strDate(value)
        End Set
    End Property

    Protected mPaidUserid As String
    Public Property PaidUserid() As String
        Get
            Return mPaidUserid
        End Get
        Set(ByVal value As String)
            If value.length > 10 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mPaidUserid = value
            End If
        End Set
    End Property

    Protected mCla_PaidFull As String
    Public Property Cla_PaidFull() As String
        Get
            Return mCla_PaidFull
        End Get
        Set(ByVal value As String)
            If value.length > 10 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PaidFull = value
            End If
        End Set
    End Property

    Protected mCla_PaidBalance As String
    Public Property Cla_PaidBalance() As String
        Get
            Return mCla_PaidBalance
        End Get
        Set(ByVal value As String)
            If value.length > 255 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PaidBalance = value
            End If
        End Set
    End Property

    Protected mDeclinedStatusDate As Date?
    Public Property DeclinedStatusDate() As Date?
        Get
            Return mDeclinedStatusDate
        End Get
        Set(ByVal value As Date?)
            mDeclinedStatusDate = value
        End Set
    End Property
    Public Property sDeclinedStatusDate() As String
        Get
            Return strDate(mDeclinedStatusDate)
        End Get
        Set(ByVal value As String)
            mDeclinedStatusDate = strDate(value)
        End Set
    End Property

    Protected mDeclinedUserid As String
    Public Property DeclinedUserid() As String
        Get
            Return mDeclinedUserid
        End Get
        Set(ByVal value As String)
            If value.length > 10 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mDeclinedUserid = value
            End If
        End Set
    End Property

    Protected mCancelledStatusDate As Date?
    Public Property CancelledStatusDate() As Date?
        Get
            Return mCancelledStatusDate
        End Get
        Set(ByVal value As Date?)
            mCancelledStatusDate = value
        End Set
    End Property
    Public Property sCancelledStatusDate() As String
        Get
            Return strDate(mCancelledStatusDate)
        End Get
        Set(ByVal value As String)
            mCancelledStatusDate = strDate(value)
        End Set
    End Property

    Protected mCancelledUserid As String
    Public Property CancelledUserid() As String
        Get
            Return mCancelledUserid
        End Get
        Set(ByVal value As String)
            If value.length > 10 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCancelledUserid = value
            End If
        End Set
    End Property

    Protected mCCName As String
    Public Property CCName() As String
        Get
            Return mCCName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCCName = value
            End If
        End Set
    End Property

    Protected mCCNumber As String
    Public Property CCNumber() As String
        Get
            Return mCCNumber
        End Get
        Set(ByVal value As String)
            If value.length > 20 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCCNumber = value
            End If
        End Set
    End Property

    Protected mCCExpiryMonthYear As String
    Public Property CCExpiryMonthYear() As String
        Get
            Return mCCExpiryMonthYear
        End Get
        Set(ByVal value As String)
            If value.length > 5 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCCExpiryMonthYear = value
            End If
        End Set
    End Property

    Protected mTotalClaimCost As Decimal?
    Public Property sTotalClaimCost() As String
        Get
            Return strDec(mTotalClaimCost)
        End Get
        Set(ByVal value As String)
            mTotalClaimCost = strDec(value)
        End Set
    End Property

    Protected mTotalCostLessGST As Decimal?
    Public Property sTotalCostLessGST() As String
        Get
            Return strDec(mTotalCostLessGST)
        End Get
        Set(ByVal value As String)
            mTotalCostLessGST = strDec(value)
        End Set
    End Property

    Protected mDiaryEntry As String
    Public Property DiaryEntry() As String
        Get
            Return mDiaryEntry
        End Get
        Set(ByVal value As String)
            If value.length > 255 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mDiaryEntry = value
            End If
        End Set
    End Property

    Protected mDiaryDate As Date?
    Public Property DiaryDate() As Date?
        Get
            Return mDiaryDate
        End Get
        Set(ByVal value As Date?)
            mDiaryDate = value
        End Set
    End Property
    Public Property sDiaryDate() As String
        Get
            Return strDate(mDiaryDate)
        End Get
        Set(ByVal value As String)
            mDiaryDate = strDate(value)
        End Set
    End Property

    Protected mGSTRegisteredFlag As Boolean?
    Public Property GSTRegisteredFlag() As Boolean?
        Get
            Return mGSTRegisteredFlag
        End Get
        Set(ByVal value As Boolean?)
            mGSTRegisteredFlag = value
        End Set
    End Property

    Protected mInputTaxCredit As Decimal?
    Public Property sInputTaxCredit() As String
        Get
            Return strDec_Real(mInputTaxCredit)
        End Get
        Set(ByVal value As String)
            mInputTaxCredit = strDec_Real(value)
        End Set
    End Property

    Protected mABN As String
    Public Property ABN() As String
        Get
            Return mABN
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mABN = value
            End If
        End Set
    End Property

    Protected mCla_AuthoriseExcess As Boolean?
    Public Property Cla_AuthoriseExcess() As Boolean?
        Get
            Return mCla_AuthoriseExcess
        End Get
        Set(ByVal value As Boolean?)
            mCla_AuthoriseExcess = value
        End Set
    End Property

    Protected mCla_DeliverPerson As String
    Public Property Cla_DeliverPerson() As String
        Get
            Return mCla_DeliverPerson
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_DeliverPerson = value
            End If
        End Set
    End Property

    Protected mCla_DeliverPersonLicense As String
    Public Property Cla_DeliverPersonLicense() As String
        Get
            Return mCla_DeliverPersonLicense
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_DeliverPersonLicense = value
            End If
        End Set
    End Property

    Protected mCla_PostalState As String
    Public Property Cla_PostalState() As String
        Get
            Return mCla_PostalState
        End Get
        Set(ByVal value As String)
            If value.length > 20 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PostalState = value
            End If
        End Set
    End Property

    Protected mCla_PhoneDealerState As String
    Public Property Cla_PhoneDealerState() As String
        Get
            Return mCla_PhoneDealerState
        End Get
        Set(ByVal value As String)
            If value.length > 20 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneDealerState = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesPaidTo As String
    Public Property Cla_PhoneAccessoriesPaidTo() As String
        Get
            Return mCla_PhoneAccessoriesPaidTo
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneAccessoriesPaidTo = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo1Amt As Decimal?
    Public Property sCla_PhoneAccessoriesInvoiceNo1Amt() As String
        Get
            Return strDec(mCla_PhoneAccessoriesInvoiceNo1Amt)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesInvoiceNo1Amt = strDec(value)
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo2Amt As Decimal?
    Public Property sCla_PhoneAccessoriesInvoiceNo2Amt() As String
        Get
            Return strDec(mCla_PhoneAccessoriesInvoiceNo2Amt)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesInvoiceNo2Amt = strDec(value)
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo3 As String
    Public Property Cla_PhoneAccessoriesInvoiceNo3() As String
        Get
            Return mCla_PhoneAccessoriesInvoiceNo3
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneAccessoriesInvoiceNo3 = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo3Amt As Decimal?
    Public Property sCla_PhoneAccessoriesInvoiceNo3Amt() As String
        Get
            Return strDec(mCla_PhoneAccessoriesInvoiceNo3Amt)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesInvoiceNo3Amt = strDec(value)
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo4 As String
    Public Property Cla_PhoneAccessoriesInvoiceNo4() As String
        Get
            Return mCla_PhoneAccessoriesInvoiceNo4
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneAccessoriesInvoiceNo4 = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo4Amt As Decimal?
    Public Property sCla_PhoneAccessoriesInvoiceNo4Amt() As String
        Get
            Return strDec(mCla_PhoneAccessoriesInvoiceNo4Amt)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesInvoiceNo4Amt = strDec(value)
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo5 As String
    Public Property Cla_PhoneAccessoriesInvoiceNo5() As String
        Get
            Return mCla_PhoneAccessoriesInvoiceNo5
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneAccessoriesInvoiceNo5 = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo5Amt As Decimal?
    Public Property sCla_PhoneAccessoriesInvoiceNo5Amt() As String
        Get
            Return strDec(mCla_PhoneAccessoriesInvoiceNo5Amt)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesInvoiceNo5Amt = strDec(value)
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo6 As String
    Public Property Cla_PhoneAccessoriesInvoiceNo6() As String
        Get
            Return mCla_PhoneAccessoriesInvoiceNo6
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneAccessoriesInvoiceNo6 = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesInvoiceNo6Amt As Decimal?
    Public Property sCla_PhoneAccessoriesInvoiceNo6Amt() As String
        Get
            Return strDec(mCla_PhoneAccessoriesInvoiceNo6Amt)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesInvoiceNo6Amt = strDec(value)
        End Set
    End Property

    Protected mCla_SimCardPaidTo As String
    Public Property Cla_SimCardPaidTo() As String
        Get
            Return mCla_SimCardPaidTo
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_SimCardPaidTo = value
            End If
        End Set
    End Property

    Protected mCla_SimCardPaidToDate As Date?
    Public Property Cla_SimCardPaidToDate() As Date?
        Get
            Return mCla_SimCardPaidToDate
        End Get
        Set(ByVal value As Date?)
            mCla_SimCardPaidToDate = value
        End Set
    End Property
    Public Property sCla_SimCardPaidToDate() As String
        Get
            Return strDate(mCla_SimCardPaidToDate)
        End Get
        Set(ByVal value As String)
            mCla_SimCardPaidToDate = strDate(value)
        End Set
    End Property

    Protected mCla_SimCardInvoiceNo1 As String
    Public Property Cla_SimCardInvoiceNo1() As String
        Get
            Return mCla_SimCardInvoiceNo1
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_SimCardInvoiceNo1 = value
            End If
        End Set
    End Property

    Protected mCla_SimCardInvoiceNo1Amt As Decimal?
    Public Property sCla_SimCardInvoiceNo1Amt() As String
        Get
            Return strDec(mCla_SimCardInvoiceNo1Amt)
        End Get
        Set(ByVal value As String)
            mCla_SimCardInvoiceNo1Amt = strDec(value)
        End Set
    End Property

    Protected mCla_RepairerPaidTo As String
    Public Property Cla_RepairerPaidTo() As String
        Get
            Return mCla_RepairerPaidTo
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_RepairerPaidTo = value
            End If
        End Set
    End Property

    Protected mCla_RepairerPaidToDate As Date?
    Public Property Cla_RepairerPaidToDate() As Date?
        Get
            Return mCla_RepairerPaidToDate
        End Get
        Set(ByVal value As Date?)
            mCla_RepairerPaidToDate = value
        End Set
    End Property
    Public Property sCla_RepairerPaidToDate() As String
        Get
            Return strDate(mCla_RepairerPaidToDate)
        End Get
        Set(ByVal value As String)
            mCla_RepairerPaidToDate = strDate(value)
        End Set
    End Property

    Protected mCla_RepairerInvoiceNo1 As String
    Public Property Cla_RepairerInvoiceNo1() As String
        Get
            Return mCla_RepairerInvoiceNo1
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_RepairerInvoiceNo1 = value
            End If
        End Set
    End Property

    Protected mCla_RepairerInvoiceNo1Amt As Decimal?
    Public Property sCla_RepairerInvoiceNo1Amt() As String
        Get
            Return strDec(mCla_RepairerInvoiceNo1Amt)
        End Get
        Set(ByVal value As String)
            mCla_RepairerInvoiceNo1Amt = strDec(value)
        End Set
    End Property

    Protected mCla_RepairerInvoiceNo2 As String
    Public Property Cla_RepairerInvoiceNo2() As String
        Get
            Return mCla_RepairerInvoiceNo2
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_RepairerInvoiceNo2 = value
            End If
        End Set
    End Property

    Protected mCla_RepairerInvoiceNo2Amt As Decimal?
    Public Property sCla_RepairerInvoiceNo2Amt() As String
        Get
            Return strDec(mCla_RepairerInvoiceNo2Amt)
        End Get
        Set(ByVal value As String)
            mCla_RepairerInvoiceNo2Amt = strDec(value)
        End Set
    End Property

    Protected mCla_RepairerInvoiceNo3 As String
    Public Property Cla_RepairerInvoiceNo3() As String
        Get
            Return mCla_RepairerInvoiceNo3
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_RepairerInvoiceNo3 = value
            End If
        End Set
    End Property

    Protected mCla_RepairerInvoiceNo3Amt As Decimal?
    Public Property sCla_RepairerInvoiceNo3Amt() As String
        Get
            Return strDec(mCla_RepairerInvoiceNo3Amt)
        End Get
        Set(ByVal value As String)
            mCla_RepairerInvoiceNo3Amt = strDec(value)
        End Set
    End Property

    Protected mCla_OtherPaidTo As String
    Public Property Cla_OtherPaidTo() As String
        Get
            Return mCla_OtherPaidTo
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_OtherPaidTo = value
            End If
        End Set
    End Property

    Protected mCla_OtherPaidToDate As Date?
    Public Property Cla_OtherPaidToDate() As Date?
        Get
            Return mCla_OtherPaidToDate
        End Get
        Set(ByVal value As Date?)
            mCla_OtherPaidToDate = value
        End Set
    End Property
    Public Property sCla_OtherPaidToDate() As String
        Get
            Return strDate(mCla_OtherPaidToDate)
        End Get
        Set(ByVal value As String)
            mCla_OtherPaidToDate = strDate(value)
        End Set
    End Property

    Protected mCla_OtherInvoiceNo1 As String
    Public Property Cla_OtherInvoiceNo1() As String
        Get
            Return mCla_OtherInvoiceNo1
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_OtherInvoiceNo1 = value
            End If
        End Set
    End Property

    Protected mCla_OtherInvoiceNo1Amt As Decimal?
    Public Property sCla_OtherInvoiceNo1Amt() As String
        Get
            Return strDec(mCla_OtherInvoiceNo1Amt)
        End Get
        Set(ByVal value As String)
            mCla_OtherInvoiceNo1Amt = strDec(value)
        End Set
    End Property

    Protected mCla_OtherInvoiceNo2 As String
    Public Property Cla_OtherInvoiceNo2() As String
        Get
            Return mCla_OtherInvoiceNo2
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_OtherInvoiceNo2 = value
            End If
        End Set
    End Property

    Protected mCla_OtherInvoiceNo2Amt As Decimal?
    Public Property sCla_OtherInvoiceNo2Amt() As String
        Get
            Return strDec(mCla_OtherInvoiceNo2Amt)
        End Get
        Set(ByVal value As String)
            mCla_OtherInvoiceNo2Amt = strDec(value)
        End Set
    End Property

    Protected mCla_OtherInvoiceNo3 As String
    Public Property Cla_OtherInvoiceNo3() As String
        Get
            Return mCla_OtherInvoiceNo3
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_OtherInvoiceNo3 = value
            End If
        End Set
    End Property

    Protected mCla_OtherInvoiceNo3Amt As Decimal?
    Public Property sCla_OtherInvoiceNo3Amt() As String
        Get
            Return strDec(mCla_OtherInvoiceNo3Amt)
        End Get
        Set(ByVal value As String)
            mCla_OtherInvoiceNo3Amt = strDec(value)
        End Set
    End Property

    Protected mCla_AccProductCode As String
    Public Property Cla_AccProductCode() As String
        Get
            Return mCla_AccProductCode
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_AccProductCode = value
            End If
        End Set
    End Property

    Protected mCla_AccOtherProductCode As String
    Public Property Cla_AccOtherProductCode() As String
        Get
            Return mCla_AccOtherProductCode
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_AccOtherProductCode = value
            End If
        End Set
    End Property

    Protected mCla_RepairerJobNo As String
    Public Property Cla_RepairerJobNo() As String
        Get
            Return mCla_RepairerJobNo
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_RepairerJobNo = value
            End If
        End Set
    End Property

    Protected mCla_ShortfallUpgradeCost As Decimal?
    Public Property sCla_ShortfallUpgradeCost() As String
        Get
            Return strDec(mCla_ShortfallUpgradeCost)
        End Get
        Set(ByVal value As String)
            mCla_ShortfallUpgradeCost = strDec(value)
        End Set
    End Property

    Protected mCla_DeliveryState As String
    Public Property Cla_DeliveryState() As String
        Get
            Return mCla_DeliveryState
        End Get
        Set(ByVal value As String)
            If value.length > 20 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_DeliveryState = value
            End If
        End Set
    End Property

    Protected mCCExpiryYear As String
    Public Property CCExpiryYear() As String
        Get
            Return mCCExpiryYear
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCCExpiryYear = value
            End If
        End Set
    End Property

    Protected mCla_CCDateEntered As Date?
    Public Property Cla_CCDateEntered() As Date?
        Get
            Return mCla_CCDateEntered
        End Get
        Set(ByVal value As Date?)
            mCla_CCDateEntered = value
        End Set
    End Property
    Public Property sCla_CCDateEntered() As String
        Get
            Return strDate(mCla_CCDateEntered)
        End Get
        Set(ByVal value As String)
            mCla_CCDateEntered = strDate(value)
        End Set
    End Property

    Protected mCla_CCAmount As Decimal?
    Public Property sCla_CCAmount() As String
        Get
            Return strDec(mCla_CCAmount)
        End Get
        Set(ByVal value As String)
            mCla_CCAmount = strDec(value)
        End Set
    End Property

    Protected mCla_LodgerHasAuthority As Boolean?
    Public Property Cla_LodgerHasAuthority() As Boolean?
        Get
            Return mCla_LodgerHasAuthority
        End Get
        Set(ByVal value As Boolean?)
            mCla_LodgerHasAuthority = value
        End Set
    End Property

    Protected mCla_LodgerAccountHolderNoEnglish As Boolean?
    Public Property Cla_LodgerAccountHolderNoEnglish() As Boolean?
        Get
            Return mCla_LodgerAccountHolderNoEnglish
        End Get
        Set(ByVal value As Boolean?)
            mCla_LodgerAccountHolderNoEnglish = value
        End Set
    End Property

    Protected mCla_DoNotOrder As Boolean?
    Public Property Cla_DoNotOrder() As Boolean?
        Get
            Return mCla_DoNotOrder
        End Get
        Set(ByVal value As Boolean?)
            mCla_DoNotOrder = value
        End Set
    End Property

    Protected mCla_BPayNumberSeed As Integer?
    Public ReadOnly Property sCla_BPayNumberSeed() As String
        Get
            Return strInt(mCla_BPayNumberSeed)
        End Get
    End Property

    Protected mCla_BPayNumber As String
    Public Property Cla_BPayNumber() As String
        Get
            Return mCla_BPayNumber
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_BPayNumber = value
            End If
        End Set
    End Property

    Protected mCla_BPayRequired As Boolean?
    Public Property Cla_BPayRequired() As Boolean?
        Get
            Return mCla_BPayRequired
        End Get
        Set(ByVal value As Boolean?)
            mCla_BPayRequired = value
        End Set
    End Property

    Protected mCla_RepairReceiptNo As String
    Public Property Cla_RepairReceiptNo() As String
        Get
            Return mCla_RepairReceiptNo
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_RepairReceiptNo = value
            End If
        End Set
    End Property

    Protected mCla_RepairConsignmentNo As String
    Public Property Cla_RepairConsignmentNo() As String
        Get
            Return mCla_RepairConsignmentNo
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_RepairConsignmentNo = value
            End If
        End Set
    End Property

    Protected mCla_OutstandingAmount As Decimal?
    Public Property sCla_OutstandingAmount() As String
        Get
            Return strDec(mCla_OutstandingAmount)
        End Get
        Set(ByVal value As String)
            mCla_OutstandingAmount = strDec(value)
        End Set
    End Property

    Protected mCla_PhoneAccessoriesPaidTo2 As String
    Public Property Cla_PhoneAccessoriesPaidTo2() As String
        Get
            Return mCla_PhoneAccessoriesPaidTo2
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneAccessoriesPaidTo2 = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesPaidDate2 As Date?
    Public Property Cla_PhoneAccessoriesPaidDate2() As Date?
        Get
            Return mCla_PhoneAccessoriesPaidDate2
        End Get
        Set(ByVal value As Date?)
            mCla_PhoneAccessoriesPaidDate2 = value
        End Set
    End Property
    Public Property sCla_PhoneAccessoriesPaidDate2() As String
        Get
            Return strDate(mCla_PhoneAccessoriesPaidDate2)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesPaidDate2 = strDate(value)
        End Set
    End Property

    Protected mCla_PhoneAccessoriesPaidTo3 As String
    Public Property Cla_PhoneAccessoriesPaidTo3() As String
        Get
            Return mCla_PhoneAccessoriesPaidTo3
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneAccessoriesPaidTo3 = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesPaidDate3 As Date?
    Public Property Cla_PhoneAccessoriesPaidDate3() As Date?
        Get
            Return mCla_PhoneAccessoriesPaidDate3
        End Get
        Set(ByVal value As Date?)
            mCla_PhoneAccessoriesPaidDate3 = value
        End Set
    End Property
    Public Property sCla_PhoneAccessoriesPaidDate3() As String
        Get
            Return strDate(mCla_PhoneAccessoriesPaidDate3)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesPaidDate3 = strDate(value)
        End Set
    End Property

    Protected mCla_PhoneAccessoriesPaidTo4 As String
    Public Property Cla_PhoneAccessoriesPaidTo4() As String
        Get
            Return mCla_PhoneAccessoriesPaidTo4
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_PhoneAccessoriesPaidTo4 = value
            End If
        End Set
    End Property

    Protected mCla_PhoneAccessoriesPaidDate4 As Date?
    Public Property Cla_PhoneAccessoriesPaidDate4() As Date?
        Get
            Return mCla_PhoneAccessoriesPaidDate4
        End Get
        Set(ByVal value As Date?)
            mCla_PhoneAccessoriesPaidDate4 = value
        End Set
    End Property
    Public Property sCla_PhoneAccessoriesPaidDate4() As String
        Get
            Return strDate(mCla_PhoneAccessoriesPaidDate4)
        End Get
        Set(ByVal value As String)
            mCla_PhoneAccessoriesPaidDate4 = strDate(value)
        End Set
    End Property

    Protected mCla_RepairerPaidTo2 As String
    Public Property Cla_RepairerPaidTo2() As String
        Get
            Return mCla_RepairerPaidTo2
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_RepairerPaidTo2 = value
            End If
        End Set
    End Property

    Protected mCla_RepairerPaidToDate2 As Date?
    Public Property Cla_RepairerPaidToDate2() As Date?
        Get
            Return mCla_RepairerPaidToDate2
        End Get
        Set(ByVal value As Date?)
            mCla_RepairerPaidToDate2 = value
        End Set
    End Property
    Public Property sCla_RepairerPaidToDate2() As String
        Get
            Return strDate(mCla_RepairerPaidToDate2)
        End Get
        Set(ByVal value As String)
            mCla_RepairerPaidToDate2 = strDate(value)
        End Set
    End Property

    Protected mCla_OtherPaidTo2 As String
    Public Property Cla_OtherPaidTo2() As String
        Get
            Return mCla_OtherPaidTo2
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_OtherPaidTo2 = value
            End If
        End Set
    End Property

    Protected mCla_OtherPaidToDate2 As Date?
    Public Property Cla_OtherPaidToDate2() As Date?
        Get
            Return mCla_OtherPaidToDate2
        End Get
        Set(ByVal value As Date?)
            mCla_OtherPaidToDate2 = value
        End Set
    End Property
    Public Property sCla_OtherPaidToDate2() As String
        Get
            Return strDate(mCla_OtherPaidToDate2)
        End Get
        Set(ByVal value As String)
            mCla_OtherPaidToDate2 = strDate(value)
        End Set
    End Property

    Protected mCla_ReplacePhone_sup_id As Integer?
    Public Property sCla_ReplacePhone_sup_id() As String
        Get
            Return strInt(mCla_ReplacePhone_sup_id)
        End Get
        Set(ByVal value As String)
            mCla_ReplacePhone_sup_id = strInt(value)
        End Set
    End Property
    Public Property Cla_ReplacePhone_sup_id() As Integer
        Get
            Return mCla_ReplacePhone_sup_id
        End Get
        Set(ByVal value As Integer)
            mCla_ReplacePhone_sup_id = value
        End Set
    End Property

    Protected mCla_ReplaceSIMCard_sup_id As Integer?
    Public Property sCla_ReplaceSIMCard_sup_id() As String
        Get
            Return strInt(mCla_ReplaceSIMCard_sup_id)
        End Get
        Set(ByVal value As String)
            mCla_ReplaceSIMCard_sup_id = strInt(value)
        End Set
    End Property
    Public Property Cla_ReplaceSIMCard_sup_id() As Integer
        Get
            Return mCla_ReplaceSIMCard_sup_id
        End Get
        Set(ByVal value As Integer)
            mCla_ReplaceSIMCard_sup_id = value
        End Set
    End Property

    Protected mCla_ReplaceSimCardID As Integer?
    Public Property sCla_ReplaceSimCardID() As String
        Get
            Return strInt(mCla_ReplaceSimCardID)
        End Get
        Set(ByVal value As String)
            mCla_ReplaceSimCardID = strInt(value)
        End Set
    End Property
    Public Property Cla_ReplaceSimCardID() As Integer
        Get
            Return mCla_ReplaceSimCardID
        End Get
        Set(ByVal value As Integer)
            mCla_ReplaceSimCardID = value
        End Set
    End Property

    Protected mCla_ReplacePhone_SuppliersCode As String
    Public Property Cla_ReplacePhone_SuppliersCode() As String
        Get
            Return mCla_ReplacePhone_SuppliersCode
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_ReplacePhone_SuppliersCode = value
            End If
        End Set
    End Property

    Protected mCla_ReplaceSIMCard_SuppliersCode As String
    Public Property Cla_ReplaceSIMCard_SuppliersCode() As String
        Get
            Return mCla_ReplaceSIMCard_SuppliersCode
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_ReplaceSIMCard_SuppliersCode = value
            End If
        End Set
    End Property

    Protected mCla_InsuranceType As String
    Public Property Cla_InsuranceType() As String
        Get
            Return mCla_InsuranceType
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_InsuranceType = value
            End If
        End Set
    End Property

    Protected mCla_TerminalId As String
    Public Property Cla_TerminalId() As String
        Get
            Return mCla_TerminalId
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_TerminalId = value
            End If
        End Set
    End Property

    Protected mCla_DateReportedToSP As Date?
    Public Property Cla_DateReportedToSP() As Date?
        Get
            Return mCla_DateReportedToSP
        End Get
        Set(ByVal value As Date?)
            mCla_DateReportedToSP = value
        End Set
    End Property
    Public Property sCla_DateReportedToSP() As String
        Get
            Return strDate(mCla_DateReportedToSP)
        End Get
        Set(ByVal value As String)
            mCla_DateReportedToSP = strDate(value)
        End Set
    End Property

    Protected mCla_ProofOfForcibleEntry As Boolean?
    Public Property Cla_ProofOfForcibleEntry() As Boolean?
        Get
            Return mCla_ProofOfForcibleEntry
        End Get
        Set(ByVal value As Boolean?)
            mCla_ProofOfForcibleEntry = value
        End Set
    End Property

    Protected mCla_ReplacePhoneRRP As Decimal?
    Public Property sCla_ReplacePhoneRRP() As String
        Get
            Return strDec(mCla_ReplacePhoneRRP)
        End Get
        Set(ByVal value As String)
            mCla_ReplacePhoneRRP = strDec(value)
        End Set
    End Property

    Protected mCla_IMEIBlocked As Boolean?
    Public Property Cla_IMEIBlocked() As Boolean?
        Get
            Return mCla_IMEIBlocked
        End Get
        Set(ByVal value As Boolean?)
            mCla_IMEIBlocked = value
        End Set
    End Property

    Protected mCla_DeclineReason As String
    Public Property Cla_DeclineReason() As String
        Get
            Return mCla_DeclineReason
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_DeclineReason = value
            End If
        End Set
    End Property

    Protected mCla_ProofOfPurchase As Boolean?
    Public Property Cla_ProofOfPurchase() As Boolean?
        Get
            Return mCla_ProofOfPurchase
        End Get
        Set(ByVal value As Boolean?)
            mCla_ProofOfPurchase = value
        End Set
    End Property

    Protected mCla_IMEINotBlockedReason As String
    Public Property Cla_IMEINotBlockedReason() As String
        Get
            Return mCla_IMEINotBlockedReason
        End Get
        Set(ByVal value As String)
            If value.length > 255 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCla_IMEINotBlockedReason = value
            End If
        End Set
    End Property

    Protected mDateAdded As Date?
    Public Property DateAdded() As Date?
        Get
            Return mDateAdded
        End Get
        Set(ByVal value As Date?)
            mDateAdded = value
        End Set
    End Property
    Public Property sDateAdded() As String
        Get
            Return strDate(mDateAdded)
        End Get
        Set(ByVal value As String)
            mDateAdded = strDate(value)
        End Set
    End Property

    Protected mCPHID_MIA As Integer?
    Public Property sCPHID_MIA() As String
        Get
            Return strInt(mCPHID_MIA)
        End Get
        Set(ByVal value As String)
            mCPHID_MIA = strInt(value)
        End Set
    End Property
    Public Property CPHID_MIA() As Integer
        Get
            Return mCPHID_MIA
        End Get
        Set(ByVal value As Integer)
            mCPHID_MIA = value
        End Set
    End Property

    Protected mRPHID_MIA As Integer?
    Public Property sRPHID_MIA() As String
        Get
            Return strInt(mRPHID_MIA)
        End Get
        Set(ByVal value As String)
            mRPHID_MIA = strInt(value)
        End Set
    End Property
    Public Property RPHID_MIA() As Integer
        Get
            Return mRPHID_MIA
        End Get
        Set(ByVal value As Integer)
            mRPHID_MIA = value
        End Set
    End Property

    Protected mCustomerEmail As String
    Public Property CustomerEmail() As String
        Get
            Return mCustomerEmail
        End Get
        Set(ByVal value As String)
            If value.length > 100 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCustomerEmail = value
            End If
        End Set
    End Property

    Protected mLetterRec_IMEI As Date?
    Public Property LetterRec_IMEI() As Date?
        Get
            Return mLetterRec_IMEI
        End Get
        Set(ByVal value As Date?)
            mLetterRec_IMEI = value
        End Set
    End Property
    Public Property sLetterRec_IMEI() As String
        Get
            Return strDate(mLetterRec_IMEI)
        End Get
        Set(ByVal value As String)
            mLetterRec_IMEI = strDate(value)
        End Set
    End Property

    Protected mLetterRec_Damaged As Date?
    Public Property LetterRec_Damaged() As Date?
        Get
            Return mLetterRec_Damaged
        End Get
        Set(ByVal value As Date?)
            mLetterRec_Damaged = value
        End Set
    End Property
    Public Property sLetterRec_Damaged() As String
        Get
            Return strDate(mLetterRec_Damaged)
        End Get
        Set(ByVal value As String)
            mLetterRec_Damaged = strDate(value)
        End Set
    End Property

    Protected mCashSettleAmount As Decimal?
    Public Property sCashSettleAmount() As String
        Get
            Return strDec(mCashSettleAmount)
        End Get
        Set(ByVal value As String)
            mCashSettleAmount = strDec(value)
        End Set
    End Property

    Protected mFaxNumber As String
    Public Property FaxNumber() As String
        Get
            Return mFaxNumber
        End Get
        Set(ByVal value As String)
            If value.length > 15 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mFaxNumber = value
            End If
        End Set
    End Property

    Protected mOSupplierName As String
    Public Property OSupplierName() As String
        Get
            Return mOSupplierName
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mOSupplierName = value
            End If
        End Set
    End Property

    Protected mOUseSupplier As Boolean?
    Public Property OUseSupplier() As Boolean?
        Get
            Return mOUseSupplier
        End Get
        Set(ByVal value As Boolean?)
            mOUseSupplier = value
        End Set
    End Property

    Protected mOPhone As String
    Public Property OPhone() As String
        Get
            Return mOPhone
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mOPhone = value
            End If
        End Set
    End Property



    Protected mLetterRec_IPhoneDamage As Date?
    Public Property LetterRec_IPhoneDamage() As Date?
        Get
            Return mLetterRec_IPhoneDamage
        End Get
        Set(ByVal value As Date?)
            mLetterRec_IPhoneDamage = value
        End Set
    End Property
    Public Property sLetterRec_IPhoneDamage() As String
        Get
            Return strDate(mLetterRec_IPhoneDamage)
        End Get
        Set(ByVal value As String)
            mLetterRec_IPhoneDamage = strDate(value)
        End Set
    End Property

    Protected mWarningNote As String
    Public Property WarningNote() As String
        Get
            Return mWarningNote
        End Get
        Set(ByVal value As String)
            If value.length > 255 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mWarningNote = value
            End If
        End Set
    End Property

    Protected mCaseManager As String
    Public Property CaseManager() As String
        Get
            Return mCaseManager
        End Get
        Set(ByVal value As String)
            If value.length > 50 Then
                Throw New Exception("Value exceeds maximum Length")
            Else
                mCaseManager = value
            End If
        End Set
    End Property

    Protected mPhotoIDReceived As Boolean?
    Public Property PhotoIDReceived() As Boolean?
        Get
            Return mPhotoIDReceived
        End Get
        Set(ByVal value As Boolean?)
            mPhotoIDReceived = value
        End Set
    End Property

    Protected mBillReceived As Boolean?
    Public Property BillReceived() As Boolean?
        Get
            Return mBillReceived
        End Get
        Set(ByVal value As Boolean?)
            mBillReceived = value
        End Set
    End Property

    Protected mInteractionNotesReceived As Boolean?
    Public Property InteractionNotesReceived() As Boolean?
        Get
            Return mInteractionNotesReceived
        End Get
        Set(ByVal value As Boolean?)
            mInteractionNotesReceived = value
        End Set
    End Property

    Protected mDateTimeSimReplaced As Date?
    Public Property DateTimeSimReplaced() As Date?
        Get
            Return mDateTimeSimReplaced
        End Get
        Set(ByVal value As Date?)
            mDateTimeSimReplaced = value
        End Set
    End Property
    Public Property sDateTimeSimReplaced() As String
        Get
            Return strDate(mDateTimeSimReplaced)
        End Get
        Set(ByVal value As String)
            mDateTimeSimReplaced = strDate(value)
        End Set
    End Property

#End Region





    Public Sub SaveData()
        updateClaim()
    End Sub





#Region "Data Persistance"
#Region "Update"
    Public Function updateClaim()
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim updateStatement As String = "Update tblClaim SET " _
        & "Status = ?, " _
        & "LodgedDate = ?, " _
        & "AfterHoursFlag = ?, " _
        & "NESLodger = ?, " _
        & "InformationConsentFlag = ?, " _
        & "SchemeID = ?, " _
        & "MobilePhoneNumber = ?, " _
        & "IMEINumber = ?, " _
        & "NewIMEINumber = ?, " _
        & "Cla_IMEIDate = ?, " _
        & "InsuranceDate = ?, " _
        & "CompanyName = ?, " _
        & "FamilyName = ?, " _
        & "GivenName = ?, " _
        & "Title = ?, " _
        & "AccountNumber = ?, " _
        & "Cla_LodgerLastName = ?, " _
        & "Cla_LodgerFirstName = ?, " _
        & "Cla_LodgerRelationship = ?, " _
        & "LastPersonGivenName = ?, " _
        & "LastPersonFamilyName = ?, " _
        & "ContactNumber = ?, " _
        & "ContactNumber2 = ?, " _
        & "PostalAddress1 = ?, " _
        & "PostalAddress2 = ?, " _
        & "PostalSuburb = ?, " _
        & "PostalPostcode = ?, " _
        & "PhoneDealer = ?, " _
        & "Suburb = ?, " _
        & "PhoneDealelPostCode = ?, " _
        & "PurchaseDate = ?, " _
        & "LossDate = ?, " _
        & "DamageType = ?, " _
        & "LossType = ?, " _
        & "PreviousClaimFlag = ?, " _
        & "PreviousClaimDate = ?, " _
        & "CancelInsuranceFlag = ?, " _
        & "SimCardFlag = ?, " _
        & "Cla_SimCardType = ?, " _
        & "Cla_SimCardNumber = ?, " _
        & "Cla_SimCardPreviousFlag = ?, " _
        & "AccLeatherCase = ?, " _
        & "AccHandsFree = ?, " _
        & "AccOther = ?, " _
        & "AccOtherDescr = ?, " _
        & "PoliceReportFlag = ?, " _
        & "PoliceReportNumber = ?, " _
        & "Cla_UnattendedPublic = ?, " _
        & "Cla_UnattendedIntentional = ?, " _
        & "Cla_UnattendedVehicle = ?, " _
        & "UpdateDate = ?, " _
        & "UpdateUserID = ?, " _
        & "Excess = ?, " _
        & "UnauthorisedCalls = ?, " _
        & "GST = ?, " _
        & "RepairReplaceCashIndicator = ?, " _
        & "CurrentPhoneID = ?, " _
        & "ReplacePhoneID = ?, " _
        & "ReplaceCost = ?, " _
        & "ReplaceVarianceCost = ?, " _
        & "SimcardCost = ?, " _
        & "Cla_FreightCostType = ?, " _
        & "FreightCost = ?, " _
        & "Repairer = ?, " _
        & "RepairCost = ?, " _
        & "AssessmentCost = ?, " _
        & "CashCost = ?, " _
        & "DeliveryAddress1 = ?, " _
        & "DeliveryAddress2 = ?, " _
        & "DeliverySuburb = ?, " _
        & "DeliveryPostcode = ?, " _
        & "CorrectInfoFlag = ?, " _
        & "MoreInfoStatusDate = ?, " _
        & "MoreInfoUserid = ?, " _
        & "Cla_InvoiceNo1 = ?, " _
        & "Cla_InvoiceNo2 = ?, " _
        & "ApprovedStatusDate = ?, " _
        & "ApprovedUserid = ?, " _
        & "PaidStatusDate = ?, " _
        & "PaidUserid = ?, " _
        & "Cla_PaidFull = ?, " _
        & "Cla_PaidBalance = ?, " _
        & "DeclinedStatusDate = ?, " _
        & "DeclinedUserid = ?, " _
        & "CancelledStatusDate = ?, " _
        & "CancelledUserid = ?, " _
        & "CCName = ?, " _
        & "CCNumber = ?, " _
        & "CCExpiryMonthYear = ?, " _
        & "TotalClaimCost = ?, " _
        & "TotalCostLessGST = ?, " _
        & "DiaryEntry = ?, " _
        & "DiaryDate = ?, " _
        & "GSTRegisteredFlag = ?, " _
        & "InputTaxCredit = ?, " _
        & "ABN = ?, " _
        & "Cla_AuthoriseExcess = ?, " _
        & "Cla_DeliverPerson = ?, " _
        & "Cla_DeliverPersonLicense = ?, " _
        & "Cla_PostalState = ?, " _
        & "Cla_PhoneDealerState = ?, " _
        & "Cla_PhoneAccessoriesPaidTo = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo1Amt = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo2Amt = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo3 = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo3Amt = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo4 = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo4Amt = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo5 = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo5Amt = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo6 = ?, " _
        & "Cla_PhoneAccessoriesInvoiceNo6Amt = ?, " _
        & "Cla_SimCardPaidTo = ?, " _
        & "Cla_SimCardPaidToDate = ?, " _
        & "Cla_SimCardInvoiceNo1 = ?, " _
        & "Cla_SimCardInvoiceNo1Amt = ?, " _
        & "Cla_RepairerPaidTo = ?, " _
        & "Cla_RepairerPaidToDate = ?, " _
        & "Cla_RepairerInvoiceNo1 = ?, " _
        & "Cla_RepairerInvoiceNo1Amt = ?, " _
        & "Cla_RepairerInvoiceNo2 = ?, " _
        & "Cla_RepairerInvoiceNo2Amt = ?, " _
        & "Cla_RepairerInvoiceNo3 = ?, " _
        & "Cla_RepairerInvoiceNo3Amt = ?, " _
        & "Cla_OtherPaidTo = ?, " _
        & "Cla_OtherPaidToDate = ?, " _
        & "Cla_OtherInvoiceNo1 = ?, " _
        & "Cla_OtherInvoiceNo1Amt = ?, " _
        & "Cla_OtherInvoiceNo2 = ?, " _
        & "Cla_OtherInvoiceNo2Amt = ?, " _
        & "Cla_OtherInvoiceNo3 = ?, " _
        & "Cla_OtherInvoiceNo3Amt = ?, " _
        & "Cla_AccProductCode = ?, " _
        & "Cla_AccOtherProductCode = ?, " _
        & "Cla_RepairerJobNo = ?, " _
        & "Cla_ShortfallUpgradeCost = ?, " _
        & "Cla_DeliveryState = ?, " _
        & "CCExpiryYear = ?, " _
        & "Cla_CCDateEntered = ?, " _
        & "Cla_CCAmount = ?, " _
        & "Cla_LodgerHasAuthority = ?, " _
        & "Cla_LodgerAccountHolderNoEnglish = ?, " _
        & "Cla_DoNotOrder = ?, " _
        & "Cla_BPayNumber = ?, " _
        & "Cla_BPayRequired = ?, " _
        & "Cla_RepairReceiptNo = ?, " _
        & "Cla_RepairConsignmentNo = ?, " _
        & "Cla_OutstandingAmount = ?, " _
        & "Cla_PhoneAccessoriesPaidTo2 = ?, " _
        & "Cla_PhoneAccessoriesPaidDate2 = ?, " _
        & "Cla_PhoneAccessoriesPaidTo3 = ?, " _
        & "Cla_PhoneAccessoriesPaidDate3 = ?, " _
        & "Cla_PhoneAccessoriesPaidTo4 = ?, " _
        & "Cla_PhoneAccessoriesPaidDate4 = ?, " _
        & "Cla_RepairerPaidTo2 = ?, " _
        & "Cla_RepairerPaidToDate2 = ?, " _
        & "Cla_OtherPaidTo2 = ?, " _
        & "Cla_OtherPaidToDate2 = ?, " _
        & "Cla_ReplacePhone_sup_id = ?, " _
        & "Cla_ReplaceSIMCard_sup_id = ?, " _
        & "Cla_ReplaceSimCardID = ?, " _
        & "Cla_ReplacePhone_SuppliersCode = ?, " _
        & "Cla_ReplaceSIMCard_SuppliersCode = ?, " _
        & "Cla_InsuranceType = ?, " _
        & "Cla_TerminalId = ?, " _
        & "Cla_DateReportedToSP = ?, " _
        & "Cla_ProofOfForcibleEntry = ?, " _
        & "Cla_ReplacePhoneRRP = ?, " _
        & "Cla_IMEIBlocked = ?, " _
        & "Cla_DeclineReason = ?, " _
        & "Cla_ProofOfPurchase = ?, " _
        & "Cla_IMEINotBlockedReason = ?, " _
        & "DateAdded = ?, " _
        & "CPHID_MIA = ?, " _
        & "RPHID_MIA = ?, " _
        & "CustomerEmail = ?, " _
        & "LetterRec_IMEI = ?, " _
        & "LetterRec_Damaged = ?, " _
        & "CashSettleAmount = ?, " _
        & "FaxNumber = ?, " _
        & "OSupplierName = ?, " _
        & "OUseSupplier = ?, " _
        & "OPhone = ?, " _
        & "LetterRec_IPhoneDamage = ?, " _
        & "WarningNote = ?, " _
        & "CaseManager = ?, " _
        & "PhotoIDReceived = ?, " _
        & "BillReceived = ?, " _
        & "InteractionNotesReceived = ?, " _
        & "DateTimeSimReplaced = ? " _
        & "where ClaimNumber like ?"



        Dim updateCommand As New Odbc.OdbcCommand(updateStatement, connection)

        updateCommand.Parameters.AddWithValue("@Status", nString(Me.mStatus))
        updateCommand.Parameters.AddWithValue("@LodgedDate", nDate(Me.mLodgedDate))
        updateCommand.Parameters.AddWithValue("@AfterHoursFlag", nBoolean(Me.mAfterHoursFlag))
        updateCommand.Parameters.AddWithValue("@NESLodger", nString(Me.mNESLodger))
        updateCommand.Parameters.AddWithValue("@InformationConsentFlag", nBoolean(Me.mInformationConsentFlag))
        updateCommand.Parameters.AddWithValue("@SchemeID", nInteger(Me.mSchemeID))
        updateCommand.Parameters.AddWithValue("@MobilePhoneNumber", nString(Me.mMobilePhoneNumber))
        updateCommand.Parameters.AddWithValue("@IMEINumber", nString(Me.mIMEINumber))
        updateCommand.Parameters.AddWithValue("@NewIMEINumber", nString(Me.mNewIMEINumber))
        updateCommand.Parameters.AddWithValue("@Cla_IMEIDate", nDate(Me.mCla_IMEIDate))
        updateCommand.Parameters.AddWithValue("@InsuranceDate", nDate(Me.mInsuranceDate))
        updateCommand.Parameters.AddWithValue("@CompanyName", nString(Me.mCompanyName))
        updateCommand.Parameters.AddWithValue("@FamilyName", nString(Me.mFamilyName))
        updateCommand.Parameters.AddWithValue("@GivenName", nString(Me.mGivenName))
        updateCommand.Parameters.AddWithValue("@Title", nString(Me.mTitle))
        updateCommand.Parameters.AddWithValue("@AccountNumber", nString(Me.mAccountNumber))
        updateCommand.Parameters.AddWithValue("@Cla_LodgerLastName", nString(Me.mCla_LodgerLastName))
        updateCommand.Parameters.AddWithValue("@Cla_LodgerFirstName", nString(Me.mCla_LodgerFirstName))
        updateCommand.Parameters.AddWithValue("@Cla_LodgerRelationship", nString(Me.mCla_LodgerRelationship))
        updateCommand.Parameters.AddWithValue("@LastPersonGivenName", nString(Me.mLastPersonGivenName))
        updateCommand.Parameters.AddWithValue("@LastPersonFamilyName", nString(Me.mLastPersonFamilyName))
        updateCommand.Parameters.AddWithValue("@ContactNumber", nString(Me.mContactNumber))
        updateCommand.Parameters.AddWithValue("@ContactNumber2", nString(Me.mContactNumber2))
        updateCommand.Parameters.AddWithValue("@PostalAddress1", nString(Me.mPostalAddress1))
        updateCommand.Parameters.AddWithValue("@PostalAddress2", nString(Me.mPostalAddress2))
        updateCommand.Parameters.AddWithValue("@PostalSuburb", nString(Me.mPostalSuburb))
        updateCommand.Parameters.AddWithValue("@PostalPostcode", nString(Me.mPostalPostcode))
        updateCommand.Parameters.AddWithValue("@PhoneDealer", nString(Me.mPhoneDealer))
        updateCommand.Parameters.AddWithValue("@Suburb", nString(Me.mSuburb))
        updateCommand.Parameters.AddWithValue("@PhoneDealelPostCode", nString(Me.mPhoneDealelPostCode))
        updateCommand.Parameters.AddWithValue("@PurchaseDate", nDate(Me.mPurchaseDate))
        updateCommand.Parameters.AddWithValue("@LossDate", nDate(Me.mLossDate))
        updateCommand.Parameters.AddWithValue("@DamageType", nString(Me.mDamageType))
        updateCommand.Parameters.AddWithValue("@LossType", nString(Me.mLossType))
        updateCommand.Parameters.AddWithValue("@PreviousClaimFlag", nBoolean(Me.mPreviousClaimFlag))
        updateCommand.Parameters.AddWithValue("@PreviousClaimDate", nDate(Me.mPreviousClaimDate))
        updateCommand.Parameters.AddWithValue("@CancelInsuranceFlag", nBoolean(Me.mCancelInsuranceFlag))
        updateCommand.Parameters.AddWithValue("@SimCardFlag", nBoolean(Me.mSimCardFlag))
        updateCommand.Parameters.AddWithValue("@Cla_SimCardType", nString(Me.mCla_SimCardType))
        updateCommand.Parameters.AddWithValue("@Cla_SimCardNumber", nString(Me.mCla_SimCardNumber))
        updateCommand.Parameters.AddWithValue("@Cla_SimCardPreviousFlag", nBoolean(Me.mCla_SimCardPreviousFlag))
        updateCommand.Parameters.AddWithValue("@AccLeatherCase", nDecimal(Me.mAccLeatherCase))
        updateCommand.Parameters.AddWithValue("@AccHandsFree", nDecimal(Me.mAccHandsFree))
        updateCommand.Parameters.AddWithValue("@AccOther", nDecimal(Me.mAccOther))
        updateCommand.Parameters.AddWithValue("@AccOtherDescr", nString(Me.mAccOtherDescr))
        updateCommand.Parameters.AddWithValue("@PoliceReportFlag", nBoolean(Me.mPoliceReportFlag))
        updateCommand.Parameters.AddWithValue("@PoliceReportNumber", nString(Me.mPoliceReportNumber))
        updateCommand.Parameters.AddWithValue("@Cla_UnattendedPublic", nBoolean(Me.mCla_UnattendedPublic))
        updateCommand.Parameters.AddWithValue("@Cla_UnattendedIntentional", nBoolean(Me.mCla_UnattendedIntentional))
        updateCommand.Parameters.AddWithValue("@Cla_UnattendedVehicle", nBoolean(Me.mCla_UnattendedVehicle))
        updateCommand.Parameters.AddWithValue("@UpdateDate", nDate(Me.mUpdateDate))
        updateCommand.Parameters.AddWithValue("@UpdateUserID", nString(Me.mUpdateUserID))
        updateCommand.Parameters.AddWithValue("@Excess", nDecimal(Me.mExcess))
        updateCommand.Parameters.AddWithValue("@UnauthorisedCalls", nDecimal(Me.mUnauthorisedCalls))
        updateCommand.Parameters.AddWithValue("@GST", nDecimal(Me.mGST))
        updateCommand.Parameters.AddWithValue("@RepairReplaceCashIndicator", nString(Me.mRepairReplaceCashIndicator))
        updateCommand.Parameters.AddWithValue("@CurrentPhoneID", nInteger(Me.mCurrentPhoneID))
        updateCommand.Parameters.AddWithValue("@ReplacePhoneID", nInteger(Me.mReplacePhoneID))
        updateCommand.Parameters.AddWithValue("@ReplaceCost", nDecimal(Me.mReplaceCost))
        updateCommand.Parameters.AddWithValue("@ReplaceVarianceCost", nDecimal(Me.mReplaceVarianceCost))
        updateCommand.Parameters.AddWithValue("@SimcardCost", nDecimal(Me.mSimcardCost))
        updateCommand.Parameters.AddWithValue("@Cla_FreightCostType", nString(Me.mCla_FreightCostType))
        updateCommand.Parameters.AddWithValue("@FreightCost", nDecimal(Me.mFreightCost))
        updateCommand.Parameters.AddWithValue("@Repairer", nString(Me.mRepairer))
        updateCommand.Parameters.AddWithValue("@RepairCost", nDecimal(Me.mRepairCost))
        updateCommand.Parameters.AddWithValue("@AssessmentCost", nDecimal(Me.mAssessmentCost))
        updateCommand.Parameters.AddWithValue("@CashCost", nDecimal(Me.mCashCost))
        updateCommand.Parameters.AddWithValue("@DeliveryAddress1", nString(Me.mDeliveryAddress1))
        updateCommand.Parameters.AddWithValue("@DeliveryAddress2", nString(Me.mDeliveryAddress2))
        updateCommand.Parameters.AddWithValue("@DeliverySuburb", nString(Me.mDeliverySuburb))
        updateCommand.Parameters.AddWithValue("@DeliveryPostcode", nString(Me.mDeliveryPostcode))
        updateCommand.Parameters.AddWithValue("@CorrectInfoFlag", nBoolean(Me.mCorrectInfoFlag))
        updateCommand.Parameters.AddWithValue("@MoreInfoStatusDate", nDate(Me.mMoreInfoStatusDate))
        updateCommand.Parameters.AddWithValue("@MoreInfoUserid", nString(Me.mMoreInfoUserid))
        updateCommand.Parameters.AddWithValue("@Cla_InvoiceNo1", nString(Me.mCla_InvoiceNo1))
        updateCommand.Parameters.AddWithValue("@Cla_InvoiceNo2", nString(Me.mCla_InvoiceNo2))
        updateCommand.Parameters.AddWithValue("@ApprovedStatusDate", nDate(Me.mApprovedStatusDate))
        updateCommand.Parameters.AddWithValue("@ApprovedUserid", nString(Me.mApprovedUserid))
        updateCommand.Parameters.AddWithValue("@PaidStatusDate", nDate(Me.mPaidStatusDate))
        updateCommand.Parameters.AddWithValue("@PaidUserid", nString(Me.mPaidUserid))
        updateCommand.Parameters.AddWithValue("@Cla_PaidFull", nString(Me.mCla_PaidFull))
        updateCommand.Parameters.AddWithValue("@Cla_PaidBalance", nString(Me.mCla_PaidBalance))
        updateCommand.Parameters.AddWithValue("@DeclinedStatusDate", nDate(Me.mDeclinedStatusDate))
        updateCommand.Parameters.AddWithValue("@DeclinedUserid", nString(Me.mDeclinedUserid))
        updateCommand.Parameters.AddWithValue("@CancelledStatusDate", nDate(Me.mCancelledStatusDate))
        updateCommand.Parameters.AddWithValue("@CancelledUserid", nString(Me.mCancelledUserid))
        updateCommand.Parameters.AddWithValue("@CCName", nString(Me.mCCName))
        updateCommand.Parameters.AddWithValue("@CCNumber", nString(Me.mCCNumber))
        updateCommand.Parameters.AddWithValue("@CCExpiryMonthYear", nString(Me.mCCExpiryMonthYear))
        updateCommand.Parameters.AddWithValue("@TotalClaimCost", nDecimal(Me.mTotalClaimCost))
        updateCommand.Parameters.AddWithValue("@TotalCostLessGST", nDecimal(Me.mTotalCostLessGST))
        updateCommand.Parameters.AddWithValue("@DiaryEntry", nString(Me.mDiaryEntry))
        updateCommand.Parameters.AddWithValue("@DiaryDate", nDate(Me.mDiaryDate))
        updateCommand.Parameters.AddWithValue("@GSTRegisteredFlag", nBoolean(Me.mGSTRegisteredFlag))
        updateCommand.Parameters.AddWithValue("@InputTaxCredit", nDecimal(Me.mInputTaxCredit))
        updateCommand.Parameters.AddWithValue("@ABN", nString(Me.mABN))
        updateCommand.Parameters.AddWithValue("@Cla_AuthoriseExcess", nBoolean(Me.mCla_AuthoriseExcess))
        updateCommand.Parameters.AddWithValue("@Cla_DeliverPerson", nString(Me.mCla_DeliverPerson))
        updateCommand.Parameters.AddWithValue("@Cla_DeliverPersonLicense", nString(Me.mCla_DeliverPersonLicense))
        updateCommand.Parameters.AddWithValue("@Cla_PostalState", nString(Me.mCla_PostalState))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneDealerState", nString(Me.mCla_PhoneDealerState))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesPaidTo", nString(Me.mCla_PhoneAccessoriesPaidTo))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo1Amt", nDecimal(Me.mCla_PhoneAccessoriesInvoiceNo1Amt))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo2Amt", nDecimal(Me.mCla_PhoneAccessoriesInvoiceNo2Amt))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo3", nString(Me.mCla_PhoneAccessoriesInvoiceNo3))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo3Amt", nDecimal(Me.mCla_PhoneAccessoriesInvoiceNo3Amt))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo4", nString(Me.mCla_PhoneAccessoriesInvoiceNo4))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo4Amt", nDecimal(Me.mCla_PhoneAccessoriesInvoiceNo4Amt))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo5", nString(Me.mCla_PhoneAccessoriesInvoiceNo5))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo5Amt", nDecimal(Me.mCla_PhoneAccessoriesInvoiceNo5Amt))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo6", nString(Me.mCla_PhoneAccessoriesInvoiceNo6))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesInvoiceNo6Amt", nDecimal(Me.mCla_PhoneAccessoriesInvoiceNo6Amt))
        updateCommand.Parameters.AddWithValue("@Cla_SimCardPaidTo", nString(Me.mCla_SimCardPaidTo))
        updateCommand.Parameters.AddWithValue("@Cla_SimCardPaidToDate", nDate(Me.mCla_SimCardPaidToDate))
        updateCommand.Parameters.AddWithValue("@Cla_SimCardInvoiceNo1", nString(Me.mCla_SimCardInvoiceNo1))
        updateCommand.Parameters.AddWithValue("@Cla_SimCardInvoiceNo1Amt", nDecimal(Me.mCla_SimCardInvoiceNo1Amt))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerPaidTo", nString(Me.mCla_RepairerPaidTo))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerPaidToDate", nDate(Me.mCla_RepairerPaidToDate))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerInvoiceNo1", nString(Me.mCla_RepairerInvoiceNo1))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerInvoiceNo1Amt", nDecimal(Me.mCla_RepairerInvoiceNo1Amt))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerInvoiceNo2", nString(Me.mCla_RepairerInvoiceNo2))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerInvoiceNo2Amt", nDecimal(Me.mCla_RepairerInvoiceNo2Amt))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerInvoiceNo3", nString(Me.mCla_RepairerInvoiceNo3))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerInvoiceNo3Amt", nDecimal(Me.mCla_RepairerInvoiceNo3Amt))
        updateCommand.Parameters.AddWithValue("@Cla_OtherPaidTo", nString(Me.mCla_OtherPaidTo))
        updateCommand.Parameters.AddWithValue("@Cla_OtherPaidToDate", nDate(Me.mCla_OtherPaidToDate))
        updateCommand.Parameters.AddWithValue("@Cla_OtherInvoiceNo1", nString(Me.mCla_OtherInvoiceNo1))
        updateCommand.Parameters.AddWithValue("@Cla_OtherInvoiceNo1Amt", nDecimal(Me.mCla_OtherInvoiceNo1Amt))
        updateCommand.Parameters.AddWithValue("@Cla_OtherInvoiceNo2", nString(Me.mCla_OtherInvoiceNo2))
        updateCommand.Parameters.AddWithValue("@Cla_OtherInvoiceNo2Amt", nDecimal(Me.mCla_OtherInvoiceNo2Amt))
        updateCommand.Parameters.AddWithValue("@Cla_OtherInvoiceNo3", nString(Me.mCla_OtherInvoiceNo3))
        updateCommand.Parameters.AddWithValue("@Cla_OtherInvoiceNo3Amt", nDecimal(Me.mCla_OtherInvoiceNo3Amt))
        updateCommand.Parameters.AddWithValue("@Cla_AccProductCode", nString(Me.mCla_AccProductCode))
        updateCommand.Parameters.AddWithValue("@Cla_AccOtherProductCode", nString(Me.mCla_AccOtherProductCode))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerJobNo", nString(Me.mCla_RepairerJobNo))
        updateCommand.Parameters.AddWithValue("@Cla_ShortfallUpgradeCost", nDecimal(Me.mCla_ShortfallUpgradeCost))
        updateCommand.Parameters.AddWithValue("@Cla_DeliveryState", nString(Me.mCla_DeliveryState))
        updateCommand.Parameters.AddWithValue("@CCExpiryYear", nString(Me.mCCExpiryYear))
        updateCommand.Parameters.AddWithValue("@Cla_CCDateEntered", nDate(Me.mCla_CCDateEntered))
        updateCommand.Parameters.AddWithValue("@Cla_CCAmount", nDecimal(Me.mCla_CCAmount))
        updateCommand.Parameters.AddWithValue("@Cla_LodgerHasAuthority", nBoolean(Me.mCla_LodgerHasAuthority))
        updateCommand.Parameters.AddWithValue("@Cla_LodgerAccountHolderNoEnglish", nBoolean(Me.mCla_LodgerAccountHolderNoEnglish))
        updateCommand.Parameters.AddWithValue("@Cla_DoNotOrder", nBoolean(Me.mCla_DoNotOrder))
        updateCommand.Parameters.AddWithValue("@Cla_BPayNumber", nString(Me.mCla_BPayNumber))
        updateCommand.Parameters.AddWithValue("@Cla_BPayRequired", nBoolean(Me.mCla_BPayRequired))
        updateCommand.Parameters.AddWithValue("@Cla_RepairReceiptNo", nString(Me.mCla_RepairReceiptNo))
        updateCommand.Parameters.AddWithValue("@Cla_RepairConsignmentNo", nString(Me.mCla_RepairConsignmentNo))
        updateCommand.Parameters.AddWithValue("@Cla_OutstandingAmount", nDecimal(Me.mCla_OutstandingAmount))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesPaidTo2", nString(Me.mCla_PhoneAccessoriesPaidTo2))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesPaidDate2", nDate(Me.mCla_PhoneAccessoriesPaidDate2))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesPaidTo3", nString(Me.mCla_PhoneAccessoriesPaidTo3))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesPaidDate3", nDate(Me.mCla_PhoneAccessoriesPaidDate3))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesPaidTo4", nString(Me.mCla_PhoneAccessoriesPaidTo4))
        updateCommand.Parameters.AddWithValue("@Cla_PhoneAccessoriesPaidDate4", nDate(Me.mCla_PhoneAccessoriesPaidDate4))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerPaidTo2", nString(Me.mCla_RepairerPaidTo2))
        updateCommand.Parameters.AddWithValue("@Cla_RepairerPaidToDate2", nDate(Me.mCla_RepairerPaidToDate2))
        updateCommand.Parameters.AddWithValue("@Cla_OtherPaidTo2", nString(Me.mCla_OtherPaidTo2))
        updateCommand.Parameters.AddWithValue("@Cla_OtherPaidToDate2", nDate(Me.mCla_OtherPaidToDate2))
        updateCommand.Parameters.AddWithValue("@Cla_ReplacePhone_sup_id", nInteger(Me.mCla_ReplacePhone_sup_id))
        updateCommand.Parameters.AddWithValue("@Cla_ReplaceSIMCard_sup_id", nInteger(Me.mCla_ReplaceSIMCard_sup_id))
        updateCommand.Parameters.AddWithValue("@Cla_ReplaceSimCardID", nInteger(Me.mCla_ReplaceSimCardID))
        updateCommand.Parameters.AddWithValue("@Cla_ReplacePhone_SuppliersCode", nString(Me.mCla_ReplacePhone_SuppliersCode))
        updateCommand.Parameters.AddWithValue("@Cla_ReplaceSIMCard_SuppliersCode", nString(Me.mCla_ReplaceSIMCard_SuppliersCode))
        updateCommand.Parameters.AddWithValue("@Cla_InsuranceType", nString(Me.mCla_InsuranceType))
        updateCommand.Parameters.AddWithValue("@Cla_TerminalId", nString(Me.mCla_TerminalId))
        updateCommand.Parameters.AddWithValue("@Cla_DateReportedToSP", nDate(Me.mCla_DateReportedToSP))
        updateCommand.Parameters.AddWithValue("@Cla_ProofOfForcibleEntry", nBoolean(Me.mCla_ProofOfForcibleEntry))
        updateCommand.Parameters.AddWithValue("@Cla_ReplacePhoneRRP", nDecimal(Me.mCla_ReplacePhoneRRP))
        updateCommand.Parameters.AddWithValue("@Cla_IMEIBlocked", nBoolean(Me.mCla_IMEIBlocked))
        updateCommand.Parameters.AddWithValue("@Cla_DeclineReason", nString(Me.mCla_DeclineReason))
        updateCommand.Parameters.AddWithValue("@Cla_ProofOfPurchase", nBoolean(Me.mCla_ProofOfPurchase))
        updateCommand.Parameters.AddWithValue("@Cla_IMEINotBlockedReason", nString(Me.mCla_IMEINotBlockedReason))
        updateCommand.Parameters.AddWithValue("@DateAdded", nDate(Me.mDateAdded))
        updateCommand.Parameters.AddWithValue("@CPHID_MIA", nInteger(Me.mCPHID_MIA))
        updateCommand.Parameters.AddWithValue("@RPHID_MIA", nInteger(Me.mRPHID_MIA))
        updateCommand.Parameters.AddWithValue("@CustomerEmail", nString(Me.mCustomerEmail))
        updateCommand.Parameters.AddWithValue("@LetterRec_IMEI", nDate(Me.mLetterRec_IMEI))
        updateCommand.Parameters.AddWithValue("@LetterRec_Damaged", nDate(Me.mLetterRec_Damaged))
        updateCommand.Parameters.AddWithValue("@CashSettleAmount", nDecimal(Me.mCashSettleAmount))
        updateCommand.Parameters.AddWithValue("@FaxNumber", nString(Me.mFaxNumber))
        updateCommand.Parameters.AddWithValue("@OSupplierName", nString(Me.mOSupplierName))
        updateCommand.Parameters.AddWithValue("@OUseSupplier", nBoolean(Me.mOUseSupplier))
        updateCommand.Parameters.AddWithValue("@OPhone", nString(Me.mOPhone))
        updateCommand.Parameters.AddWithValue("@LetterRec_IPhoneDamage", nDate(Me.mLetterRec_IPhoneDamage))
        updateCommand.Parameters.AddWithValue("@WarningNote", nString(Me.mWarningNote))
        updateCommand.Parameters.AddWithValue("@CaseManager", nString(Me.mCaseManager))
        updateCommand.Parameters.AddWithValue("@PhotoIDReceived", nBoolean(Me.mPhotoIDReceived))
        updateCommand.Parameters.AddWithValue("@BillReceived", nBoolean(Me.mBillReceived))
        updateCommand.Parameters.AddWithValue("@InteractionNotesReceived", nBoolean(Me.mInteractionNotesReceived))
        updateCommand.Parameters.AddWithValue("@DateTimeSimReplaced", nDate(Me.mDateTimeSimReplaced))
        updateCommand.Parameters.AddWithValue("@ClaimNumber", nString(Me.mClaimNumber))
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




Public Class Claim
    Inherits ClaimDB
#Region "Data Persistance"
#Region "Select"
    Public Shared Function getClaim(ByVal ClaimNumber As String) As Claim
        Dim Claim As New Claim
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblClaim " _
        & "where ClaimNumber = '" + ClaimNumber + "'"
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            If reader.Read Then
                Claim.mClaimNumber = nString(reader("ClaimNumber"))
                Claim.mStatus = nString(reader("Status"))
                Claim.mLodgedDate = nDate(reader("LodgedDate"))
                Claim.mAfterHoursFlag = nBoolean(reader("AfterHoursFlag"))
                Claim.mNESLodger = nString(reader("NESLodger"))
                Claim.mInformationConsentFlag = nBoolean(reader("InformationConsentFlag"))
                Claim.mSchemeID = nInteger(reader("SchemeID"))
                Claim.mMobilePhoneNumber = nString(reader("MobilePhoneNumber"))
                Claim.mIMEINumber = nString(reader("IMEINumber"))
                Claim.mNewIMEINumber = nString(reader("NewIMEINumber"))
                Claim.mcla_IMEIDate = nDate(reader("cla_IMEIDate"))
                Claim.mInsuranceDate = nDate(reader("InsuranceDate"))
                Claim.mCompanyName = nString(reader("CompanyName"))
                Claim.mFamilyName = nString(reader("FamilyName"))
                Claim.mGivenName = nString(reader("GivenName"))
                Claim.mTitle = nString(reader("Title"))
                Claim.mAccountNumber = nString(reader("AccountNumber"))
                Claim.mcla_LodgerLastName = nString(reader("cla_LodgerLastName"))
                Claim.mcla_LodgerFirstName = nString(reader("cla_LodgerFirstName"))
                Claim.mcla_LodgerRelationship = nString(reader("cla_LodgerRelationship"))
                Claim.mLastPersonGivenName = nString(reader("LastPersonGivenName"))
                Claim.mLastPersonFamilyName = nString(reader("LastPersonFamilyName"))
                Claim.mContactNumber = nString(reader("ContactNumber"))
                Claim.mContactNumber2 = nString(reader("ContactNumber2"))
                Claim.mPostalAddress1 = nString(reader("PostalAddress1"))
                Claim.mPostalAddress2 = nString(reader("PostalAddress2"))
                Claim.mPostalSuburb = nString(reader("PostalSuburb"))
                Claim.mPostalPostcode = nString(reader("PostalPostcode"))
                Claim.mPhoneDealer = nString(reader("PhoneDealer"))
                Claim.mSuburb = nString(reader("Suburb"))
                Claim.mPhoneDealelPostCode = nString(reader("PhoneDealelPostCode"))
                Claim.mPurchaseDate = nDate(reader("PurchaseDate"))
                Claim.mLossDate = nDate(reader("LossDate"))
                Claim.mDamageType = nString(reader("DamageType"))
                Claim.mLossType = nString(reader("LossType"))
                Claim.mPreviousClaimFlag = nBoolean(reader("PreviousClaimFlag"))
                Claim.mPreviousClaimDate = nDate(reader("PreviousClaimDate"))
                Claim.mCancelInsuranceFlag = nBoolean(reader("CancelInsuranceFlag"))
                Claim.mSimCardFlag = nBoolean(reader("SimCardFlag"))
                Claim.mcla_SimCardType = nString(reader("cla_SimCardType"))
                Claim.mcla_SimCardNumber = nString(reader("cla_SimCardNumber"))
                Claim.mcla_SimCardPreviousFlag = nBoolean(reader("cla_SimCardPreviousFlag"))
                Claim.mAccLeatherCase = nDecimal(reader("AccLeatherCase"))
                Claim.mAccHandsFree = nDecimal(reader("AccHandsFree"))
                Claim.mAccOther = nDecimal(reader("AccOther"))
                Claim.mAccOtherDescr = nString(reader("AccOtherDescr"))
                Claim.mPoliceReportFlag = nBoolean(reader("PoliceReportFlag"))
                Claim.mPoliceReportNumber = nString(reader("PoliceReportNumber"))
                Claim.mcla_UnattendedPublic = nBoolean(reader("cla_UnattendedPublic"))
                Claim.mcla_UnattendedIntentional = nBoolean(reader("cla_UnattendedIntentional"))
                Claim.mcla_UnattendedVehicle = nBoolean(reader("cla_UnattendedVehicle"))
                Claim.mUpdateDate = nDate(reader("UpdateDate"))
                Claim.mUpdateUserID = nString(reader("UpdateUserID"))
                Claim.mExcess = nDecimal(reader("Excess"))
                Claim.mUnauthorisedCalls = nDecimal(reader("UnauthorisedCalls"))
                Claim.mGST = nDecimal(reader("GST"))
                Claim.mRepairReplaceCashIndicator = nString(reader("RepairReplaceCashIndicator"))
                Claim.mCurrentPhoneID = nInteger(reader("CurrentPhoneID"))
                Claim.mReplacePhoneID = nInteger(reader("ReplacePhoneID"))
                Claim.mReplaceCost = nDecimal(reader("ReplaceCost"))
                Claim.mReplaceVarianceCost = nDecimal(reader("ReplaceVarianceCost"))
                Claim.mSimcardCost = nDecimal(reader("SimcardCost"))
                Claim.mcla_FreightCostType = nString(reader("cla_FreightCostType"))
                Claim.mFreightCost = nDecimal(reader("FreightCost"))
                Claim.mRepairer = nString(reader("Repairer"))
                Claim.mRepairCost = nDecimal(reader("RepairCost"))
                Claim.mAssessmentCost = nDecimal(reader("AssessmentCost"))
                Claim.mCashCost = nDecimal(reader("CashCost"))
                Claim.mDeliveryAddress1 = nString(reader("DeliveryAddress1"))
                Claim.mDeliveryAddress2 = nString(reader("DeliveryAddress2"))
                Claim.mDeliverySuburb = nString(reader("DeliverySuburb"))
                Claim.mDeliveryPostcode = nString(reader("DeliveryPostcode"))
                Claim.mCorrectInfoFlag = nBoolean(reader("CorrectInfoFlag"))
                Claim.mMoreInfoStatusDate = nDate(reader("MoreInfoStatusDate"))
                Claim.mMoreInfoUserid = nString(reader("MoreInfoUserid"))
                Claim.mcla_InvoiceNo1 = nString(reader("cla_InvoiceNo1"))
                Claim.mcla_InvoiceNo2 = nString(reader("cla_InvoiceNo2"))
                Claim.mApprovedStatusDate = nDate(reader("ApprovedStatusDate"))
                Claim.mApprovedUserid = nString(reader("ApprovedUserid"))
                Claim.mPaidStatusDate = nDate(reader("PaidStatusDate"))
                Claim.mPaidUserid = nString(reader("PaidUserid"))
                Claim.mcla_PaidFull = nString(reader("cla_PaidFull"))
                Claim.mcla_PaidBalance = nString(reader("cla_PaidBalance"))
                Claim.mDeclinedStatusDate = nDate(reader("DeclinedStatusDate"))
                Claim.mDeclinedUserid = nString(reader("DeclinedUserid"))
                Claim.mCancelledStatusDate = nDate(reader("CancelledStatusDate"))
                Claim.mCancelledUserid = nString(reader("CancelledUserid"))
                Claim.mCCName = nString(reader("CCName"))
                Claim.mCCNumber = nString(reader("CCNumber"))
                Claim.mCCExpiryMonthYear = nString(reader("CCExpiryMonthYear"))
                Claim.mTotalClaimCost = nDecimal(reader("TotalClaimCost"))
                Claim.mTotalCostLessGST = nDecimal(reader("TotalCostLessGST"))
                Claim.mDiaryEntry = nString(reader("DiaryEntry"))
                Claim.mDiaryDate = nDate(reader("DiaryDate"))
                Claim.mGSTRegisteredFlag = nBoolean(reader("GSTRegisteredFlag"))
                Claim.mInputTaxCredit = nDecimal(reader("InputTaxCredit"))
                Claim.mABN = nString(reader("ABN"))
                Claim.mcla_AuthoriseExcess = nBoolean(reader("cla_AuthoriseExcess"))
                Claim.mcla_DeliverPerson = nString(reader("cla_DeliverPerson"))
                Claim.mcla_DeliverPersonLicense = nString(reader("cla_DeliverPersonLicense"))
                Claim.mcla_PostalState = nString(reader("cla_PostalState"))
                Claim.mcla_PhoneDealerState = nString(reader("cla_PhoneDealerState"))
                Claim.mcla_PhoneAccessoriesPaidTo = nString(reader("cla_PhoneAccessoriesPaidTo"))
                Claim.mcla_PhoneAccessoriesInvoiceNo1Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo1Amt"))
                Claim.mcla_PhoneAccessoriesInvoiceNo2Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo2Amt"))
                Claim.mcla_PhoneAccessoriesInvoiceNo3 = nString(reader("cla_PhoneAccessoriesInvoiceNo3"))
                Claim.mcla_PhoneAccessoriesInvoiceNo3Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo3Amt"))
                Claim.mcla_PhoneAccessoriesInvoiceNo4 = nString(reader("cla_PhoneAccessoriesInvoiceNo4"))
                Claim.mcla_PhoneAccessoriesInvoiceNo4Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo4Amt"))
                Claim.mcla_PhoneAccessoriesInvoiceNo5 = nString(reader("cla_PhoneAccessoriesInvoiceNo5"))
                Claim.mcla_PhoneAccessoriesInvoiceNo5Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo5Amt"))
                Claim.mcla_PhoneAccessoriesInvoiceNo6 = nString(reader("cla_PhoneAccessoriesInvoiceNo6"))
                Claim.mcla_PhoneAccessoriesInvoiceNo6Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo6Amt"))
                Claim.mcla_SimCardPaidTo = nString(reader("cla_SimCardPaidTo"))
                Claim.mcla_SimCardPaidToDate = nDate(reader("cla_SimCardPaidToDate"))
                Claim.mcla_SimCardInvoiceNo1 = nString(reader("cla_SimCardInvoiceNo1"))
                Claim.mcla_SimCardInvoiceNo1Amt = nDecimal(reader("cla_SimCardInvoiceNo1Amt"))
                Claim.mcla_RepairerPaidTo = nString(reader("cla_RepairerPaidTo"))
                Claim.mcla_RepairerPaidToDate = nDate(reader("cla_RepairerPaidToDate"))
                Claim.mcla_RepairerInvoiceNo1 = nString(reader("cla_RepairerInvoiceNo1"))
                Claim.mcla_RepairerInvoiceNo1Amt = nDecimal(reader("cla_RepairerInvoiceNo1Amt"))
                Claim.mcla_RepairerInvoiceNo2 = nString(reader("cla_RepairerInvoiceNo2"))
                Claim.mcla_RepairerInvoiceNo2Amt = nDecimal(reader("cla_RepairerInvoiceNo2Amt"))
                Claim.mcla_RepairerInvoiceNo3 = nString(reader("cla_RepairerInvoiceNo3"))
                Claim.mcla_RepairerInvoiceNo3Amt = nDecimal(reader("cla_RepairerInvoiceNo3Amt"))
                Claim.mcla_OtherPaidTo = nString(reader("cla_OtherPaidTo"))
                Claim.mcla_OtherPaidToDate = nDate(reader("cla_OtherPaidToDate"))
                Claim.mcla_OtherInvoiceNo1 = nString(reader("cla_OtherInvoiceNo1"))
                Claim.mcla_OtherInvoiceNo1Amt = nDecimal(reader("cla_OtherInvoiceNo1Amt"))
                Claim.mcla_OtherInvoiceNo2 = nString(reader("cla_OtherInvoiceNo2"))
                Claim.mcla_OtherInvoiceNo2Amt = nDecimal(reader("cla_OtherInvoiceNo2Amt"))
                Claim.mcla_OtherInvoiceNo3 = nString(reader("cla_OtherInvoiceNo3"))
                Claim.mcla_OtherInvoiceNo3Amt = nDecimal(reader("cla_OtherInvoiceNo3Amt"))
                Claim.mcla_AccProductCode = nString(reader("cla_AccProductCode"))
                Claim.mcla_AccOtherProductCode = nString(reader("cla_AccOtherProductCode"))
                Claim.mcla_RepairerJobNo = nString(reader("cla_RepairerJobNo"))
                Claim.mcla_ShortfallUpgradeCost = nDecimal(reader("cla_ShortfallUpgradeCost"))
                Claim.mcla_DeliveryState = nString(reader("cla_DeliveryState"))
                Claim.mCCExpiryYear = nString(reader("CCExpiryYear"))
                Claim.mcla_CCDateEntered = nDate(reader("cla_CCDateEntered"))
                Claim.mcla_CCAmount = nDecimal(reader("cla_CCAmount"))
                Claim.mcla_LodgerHasAuthority = nBoolean(reader("cla_LodgerHasAuthority"))
                Claim.mcla_LodgerAccountHolderNoEnglish = nBoolean(reader("cla_LodgerAccountHolderNoEnglish"))
                Claim.mcla_DoNotOrder = nBoolean(reader("cla_DoNotOrder"))
                Claim.mcla_BPayNumberSeed = nInteger(reader("cla_BPayNumberSeed"))
                Claim.mcla_BPayNumber = nString(reader("cla_BPayNumber"))
                Claim.mcla_BPayRequired = nBoolean(reader("cla_BPayRequired"))
                Claim.mcla_RepairReceiptNo = nString(reader("cla_RepairReceiptNo"))
                Claim.mcla_RepairConsignmentNo = nString(reader("cla_RepairConsignmentNo"))
                Claim.mcla_OutstandingAmount = nDecimal(reader("cla_OutstandingAmount"))
                Claim.mcla_PhoneAccessoriesPaidTo2 = nString(reader("cla_PhoneAccessoriesPaidTo2"))
                Claim.mcla_PhoneAccessoriesPaidDate2 = nDate(reader("cla_PhoneAccessoriesPaidDate2"))
                Claim.mcla_PhoneAccessoriesPaidTo3 = nString(reader("cla_PhoneAccessoriesPaidTo3"))
                Claim.mcla_PhoneAccessoriesPaidDate3 = nDate(reader("cla_PhoneAccessoriesPaidDate3"))
                Claim.mcla_PhoneAccessoriesPaidTo4 = nString(reader("cla_PhoneAccessoriesPaidTo4"))
                Claim.mcla_PhoneAccessoriesPaidDate4 = nDate(reader("cla_PhoneAccessoriesPaidDate4"))
                Claim.mcla_RepairerPaidTo2 = nString(reader("cla_RepairerPaidTo2"))
                Claim.mcla_RepairerPaidToDate2 = nDate(reader("cla_RepairerPaidToDate2"))
                Claim.mcla_OtherPaidTo2 = nString(reader("cla_OtherPaidTo2"))
                Claim.mcla_OtherPaidToDate2 = nDate(reader("cla_OtherPaidToDate2"))
                Claim.mcla_ReplacePhone_sup_id = nInteger(reader("cla_ReplacePhone_sup_id"))
                Claim.mcla_ReplaceSIMCard_sup_id = nInteger(reader("cla_ReplaceSIMCard_sup_id"))
                Claim.mcla_ReplaceSimCardID = nInteger(reader("cla_ReplaceSimCardID"))
                Claim.mcla_ReplacePhone_SuppliersCode = nString(reader("cla_ReplacePhone_SuppliersCode"))
                Claim.mcla_ReplaceSIMCard_SuppliersCode = nString(reader("cla_ReplaceSIMCard_SuppliersCode"))
                Claim.mcla_InsuranceType = nString(reader("cla_InsuranceType"))
                Claim.mcla_TerminalId = nString(reader("cla_TerminalId"))
                Claim.mcla_DateReportedToSP = nDate(reader("cla_DateReportedToSP"))
                Claim.mcla_ProofOfForcibleEntry = nBoolean(reader("cla_ProofOfForcibleEntry"))
                Claim.mcla_ReplacePhoneRRP = nDecimal(reader("cla_ReplacePhoneRRP"))
                Claim.mcla_IMEIBlocked = nBoolean(reader("cla_IMEIBlocked"))
                Claim.mcla_DeclineReason = nString(reader("cla_DeclineReason"))
                Claim.mcla_ProofOfPurchase = nBoolean(reader("cla_ProofOfPurchase"))
                Claim.mcla_IMEINotBlockedReason = nString(reader("cla_IMEINotBlockedReason"))
                Claim.mDateAdded = nDate(reader("DateAdded"))
                Claim.mCPHID_MIA = nInteger(reader("CPHID_MIA"))
                Claim.mRPHID_MIA = nInteger(reader("RPHID_MIA"))
                Claim.mCustomerEmail = nString(reader("CustomerEmail"))
                Claim.mLetterRec_IMEI = nDate(reader("LetterRec_IMEI"))
                Claim.mLetterRec_Damaged = nDate(reader("LetterRec_Damaged"))
                Claim.mCashSettleAmount = nDecimal(reader("CashSettleAmount"))
                Claim.mFaxNumber = nString(reader("FaxNumber"))
                Claim.moSupplierName = nString(reader("oSupplierName"))
                Claim.moUseSupplier = nBoolean(reader("oUseSupplier"))
                Claim.moPhone = nString(reader("oPhone"))
                Claim.mletterRec_IPhoneDamage = nDate(reader("letterRec_IPhoneDamage"))
                Claim.mWarningNote = nString(reader("WarningNote"))
                Claim.mCaseManager = nString(reader("CaseManager"))
                Claim.mPhotoIDReceived = nBoolean(reader("PhotoIDReceived"))
                Claim.mBillReceived = nBoolean(reader("BillReceived"))
                Claim.mInteractionNotesReceived = nBoolean(reader("InteractionNotesReceived"))
                Claim.mDateTimeSimReplaced = nDate(reader("DateTimeSimReplaced"))
            Else
                Claim = New Claim()
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return Claim
    End Function

    Public Shared Function getClaim(ByVal strWhereClause As String, ByVal strOrderByClause As String) As Claim()
        Dim Claim(0) As Claim
        Claim(0) = New Claim
        Dim connectionString As String = "DSN=RISK"
        Dim connection = New Odbc.OdbcConnection(connectionString)
        Dim selectStatement As String _
        = "Select * " _
        & "from tblClaim " _
        & strWhereClause + " " + strOrderByClause
        Dim selectCommand As New Odbc.OdbcCommand(selectStatement, connection)
        Try
            connection.Open()
            Dim reader As Odbc.OdbcDataReader _
            = SelectCommand.ExecuteReader()
            Dim i = -1
            While reader.Read
                i += 1
                ReDim Preserve Claim(i)
                Claim(i) = New Claim
                Claim(i).mClaimNumber = nString(reader("ClaimNumber"))
                Claim(i).mStatus = nString(reader("Status"))
                Claim(i).mLodgedDate = nDate(reader("LodgedDate"))
                Claim(i).mAfterHoursFlag = nBoolean(reader("AfterHoursFlag"))
                Claim(i).mNESLodger = nString(reader("NESLodger"))
                Claim(i).mInformationConsentFlag = nBoolean(reader("InformationConsentFlag"))
                Claim(i).mSchemeID = nInteger(reader("SchemeID"))
                Claim(i).mMobilePhoneNumber = nString(reader("MobilePhoneNumber"))
                Claim(i).mIMEINumber = nString(reader("IMEINumber"))
                Claim(i).mNewIMEINumber = nString(reader("NewIMEINumber"))
                Claim(i).mcla_IMEIDate = nDate(reader("cla_IMEIDate"))
                Claim(i).mInsuranceDate = nDate(reader("InsuranceDate"))
                Claim(i).mCompanyName = nString(reader("CompanyName"))
                Claim(i).mFamilyName = nString(reader("FamilyName"))
                Claim(i).mGivenName = nString(reader("GivenName"))
                Claim(i).mTitle = nString(reader("Title"))
                Claim(i).mAccountNumber = nString(reader("AccountNumber"))
                Claim(i).mcla_LodgerLastName = nString(reader("cla_LodgerLastName"))
                Claim(i).mcla_LodgerFirstName = nString(reader("cla_LodgerFirstName"))
                Claim(i).mcla_LodgerRelationship = nString(reader("cla_LodgerRelationship"))
                Claim(i).mLastPersonGivenName = nString(reader("LastPersonGivenName"))
                Claim(i).mLastPersonFamilyName = nString(reader("LastPersonFamilyName"))
                Claim(i).mContactNumber = nString(reader("ContactNumber"))
                Claim(i).mContactNumber2 = nString(reader("ContactNumber2"))
                Claim(i).mPostalAddress1 = nString(reader("PostalAddress1"))
                Claim(i).mPostalAddress2 = nString(reader("PostalAddress2"))
                Claim(i).mPostalSuburb = nString(reader("PostalSuburb"))
                Claim(i).mPostalPostcode = nString(reader("PostalPostcode"))
                Claim(i).mPhoneDealer = nString(reader("PhoneDealer"))
                Claim(i).mSuburb = nString(reader("Suburb"))
                Claim(i).mPhoneDealelPostCode = nString(reader("PhoneDealelPostCode"))
                Claim(i).mPurchaseDate = nDate(reader("PurchaseDate"))
                Claim(i).mLossDate = nDate(reader("LossDate"))
                Claim(i).mDamageType = nString(reader("DamageType"))
                Claim(i).mLossType = nString(reader("LossType"))
                Claim(i).mPreviousClaimFlag = nBoolean(reader("PreviousClaimFlag"))
                Claim(i).mPreviousClaimDate = nDate(reader("PreviousClaimDate"))
                Claim(i).mCancelInsuranceFlag = nBoolean(reader("CancelInsuranceFlag"))
                Claim(i).mSimCardFlag = nBoolean(reader("SimCardFlag"))
                Claim(i).mcla_SimCardType = nString(reader("cla_SimCardType"))
                Claim(i).mcla_SimCardNumber = nString(reader("cla_SimCardNumber"))
                Claim(i).mcla_SimCardPreviousFlag = nBoolean(reader("cla_SimCardPreviousFlag"))
                Claim(i).mAccLeatherCase = nDecimal(reader("AccLeatherCase"))
                Claim(i).mAccHandsFree = nDecimal(reader("AccHandsFree"))
                Claim(i).mAccOther = nDecimal(reader("AccOther"))
                Claim(i).mAccOtherDescr = nString(reader("AccOtherDescr"))
                Claim(i).mPoliceReportFlag = nBoolean(reader("PoliceReportFlag"))
                Claim(i).mPoliceReportNumber = nString(reader("PoliceReportNumber"))
                Claim(i).mcla_UnattendedPublic = nBoolean(reader("cla_UnattendedPublic"))
                Claim(i).mcla_UnattendedIntentional = nBoolean(reader("cla_UnattendedIntentional"))
                Claim(i).mcla_UnattendedVehicle = nBoolean(reader("cla_UnattendedVehicle"))
                Claim(i).mUpdateDate = nDate(reader("UpdateDate"))
                Claim(i).mUpdateUserID = nString(reader("UpdateUserID"))
                Claim(i).mExcess = nDecimal(reader("Excess"))
                Claim(i).mUnauthorisedCalls = nDecimal(reader("UnauthorisedCalls"))
                Claim(i).mGST = nDecimal(reader("GST"))
                Claim(i).mRepairReplaceCashIndicator = nString(reader("RepairReplaceCashIndicator"))
                Claim(i).mCurrentPhoneID = nInteger(reader("CurrentPhoneID"))
                Claim(i).mReplacePhoneID = nInteger(reader("ReplacePhoneID"))
                Claim(i).mReplaceCost = nDecimal(reader("ReplaceCost"))
                Claim(i).mReplaceVarianceCost = nDecimal(reader("ReplaceVarianceCost"))
                Claim(i).mSimcardCost = nDecimal(reader("SimcardCost"))
                Claim(i).mcla_FreightCostType = nString(reader("cla_FreightCostType"))
                Claim(i).mFreightCost = nDecimal(reader("FreightCost"))
                Claim(i).mRepairer = nString(reader("Repairer"))
                Claim(i).mRepairCost = nDecimal(reader("RepairCost"))
                Claim(i).mAssessmentCost = nDecimal(reader("AssessmentCost"))
                Claim(i).mCashCost = nDecimal(reader("CashCost"))
                Claim(i).mDeliveryAddress1 = nString(reader("DeliveryAddress1"))
                Claim(i).mDeliveryAddress2 = nString(reader("DeliveryAddress2"))
                Claim(i).mDeliverySuburb = nString(reader("DeliverySuburb"))
                Claim(i).mDeliveryPostcode = nString(reader("DeliveryPostcode"))
                Claim(i).mCorrectInfoFlag = nBoolean(reader("CorrectInfoFlag"))
                Claim(i).mMoreInfoStatusDate = nDate(reader("MoreInfoStatusDate"))
                Claim(i).mMoreInfoUserid = nString(reader("MoreInfoUserid"))
                Claim(i).mcla_InvoiceNo1 = nString(reader("cla_InvoiceNo1"))
                Claim(i).mcla_InvoiceNo2 = nString(reader("cla_InvoiceNo2"))
                Claim(i).mApprovedStatusDate = nDate(reader("ApprovedStatusDate"))
                Claim(i).mApprovedUserid = nString(reader("ApprovedUserid"))
                Claim(i).mPaidStatusDate = nDate(reader("PaidStatusDate"))
                Claim(i).mPaidUserid = nString(reader("PaidUserid"))
                Claim(i).mcla_PaidFull = nString(reader("cla_PaidFull"))
                Claim(i).mcla_PaidBalance = nString(reader("cla_PaidBalance"))
                Claim(i).mDeclinedStatusDate = nDate(reader("DeclinedStatusDate"))
                Claim(i).mDeclinedUserid = nString(reader("DeclinedUserid"))
                Claim(i).mCancelledStatusDate = nDate(reader("CancelledStatusDate"))
                Claim(i).mCancelledUserid = nString(reader("CancelledUserid"))
                Claim(i).mCCName = nString(reader("CCName"))
                Claim(i).mCCNumber = nString(reader("CCNumber"))
                Claim(i).mCCExpiryMonthYear = nString(reader("CCExpiryMonthYear"))
                Claim(i).mTotalClaimCost = nDecimal(reader("TotalClaimCost"))
                Claim(i).mTotalCostLessGST = nDecimal(reader("TotalCostLessGST"))
                Claim(i).mDiaryEntry = nString(reader("DiaryEntry"))
                Claim(i).mDiaryDate = nDate(reader("DiaryDate"))
                Claim(i).mGSTRegisteredFlag = nBoolean(reader("GSTRegisteredFlag"))
                Claim(i).mInputTaxCredit = nDecimal(reader("InputTaxCredit"))
                Claim(i).mABN = nString(reader("ABN"))
                Claim(i).mcla_AuthoriseExcess = nBoolean(reader("cla_AuthoriseExcess"))
                Claim(i).mcla_DeliverPerson = nString(reader("cla_DeliverPerson"))
                Claim(i).mcla_DeliverPersonLicense = nString(reader("cla_DeliverPersonLicense"))
                Claim(i).mcla_PostalState = nString(reader("cla_PostalState"))
                Claim(i).mcla_PhoneDealerState = nString(reader("cla_PhoneDealerState"))
                Claim(i).mcla_PhoneAccessoriesPaidTo = nString(reader("cla_PhoneAccessoriesPaidTo"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo1Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo1Amt"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo2Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo2Amt"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo3 = nString(reader("cla_PhoneAccessoriesInvoiceNo3"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo3Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo3Amt"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo4 = nString(reader("cla_PhoneAccessoriesInvoiceNo4"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo4Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo4Amt"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo5 = nString(reader("cla_PhoneAccessoriesInvoiceNo5"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo5Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo5Amt"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo6 = nString(reader("cla_PhoneAccessoriesInvoiceNo6"))
                Claim(i).mcla_PhoneAccessoriesInvoiceNo6Amt = nDecimal(reader("cla_PhoneAccessoriesInvoiceNo6Amt"))
                Claim(i).mcla_SimCardPaidTo = nString(reader("cla_SimCardPaidTo"))
                Claim(i).mcla_SimCardPaidToDate = nDate(reader("cla_SimCardPaidToDate"))
                Claim(i).mcla_SimCardInvoiceNo1 = nString(reader("cla_SimCardInvoiceNo1"))
                Claim(i).mcla_SimCardInvoiceNo1Amt = nDecimal(reader("cla_SimCardInvoiceNo1Amt"))
                Claim(i).mcla_RepairerPaidTo = nString(reader("cla_RepairerPaidTo"))
                Claim(i).mcla_RepairerPaidToDate = nDate(reader("cla_RepairerPaidToDate"))
                Claim(i).mcla_RepairerInvoiceNo1 = nString(reader("cla_RepairerInvoiceNo1"))
                Claim(i).mcla_RepairerInvoiceNo1Amt = nDecimal(reader("cla_RepairerInvoiceNo1Amt"))
                Claim(i).mcla_RepairerInvoiceNo2 = nString(reader("cla_RepairerInvoiceNo2"))
                Claim(i).mcla_RepairerInvoiceNo2Amt = nDecimal(reader("cla_RepairerInvoiceNo2Amt"))
                Claim(i).mcla_RepairerInvoiceNo3 = nString(reader("cla_RepairerInvoiceNo3"))
                Claim(i).mcla_RepairerInvoiceNo3Amt = nDecimal(reader("cla_RepairerInvoiceNo3Amt"))
                Claim(i).mcla_OtherPaidTo = nString(reader("cla_OtherPaidTo"))
                Claim(i).mcla_OtherPaidToDate = nDate(reader("cla_OtherPaidToDate"))
                Claim(i).mcla_OtherInvoiceNo1 = nString(reader("cla_OtherInvoiceNo1"))
                Claim(i).mcla_OtherInvoiceNo1Amt = nDecimal(reader("cla_OtherInvoiceNo1Amt"))
                Claim(i).mcla_OtherInvoiceNo2 = nString(reader("cla_OtherInvoiceNo2"))
                Claim(i).mcla_OtherInvoiceNo2Amt = nDecimal(reader("cla_OtherInvoiceNo2Amt"))
                Claim(i).mcla_OtherInvoiceNo3 = nString(reader("cla_OtherInvoiceNo3"))
                Claim(i).mcla_OtherInvoiceNo3Amt = nDecimal(reader("cla_OtherInvoiceNo3Amt"))
                Claim(i).mcla_AccProductCode = nString(reader("cla_AccProductCode"))
                Claim(i).mcla_AccOtherProductCode = nString(reader("cla_AccOtherProductCode"))
                Claim(i).mcla_RepairerJobNo = nString(reader("cla_RepairerJobNo"))
                Claim(i).mcla_ShortfallUpgradeCost = nDecimal(reader("cla_ShortfallUpgradeCost"))
                Claim(i).mcla_DeliveryState = nString(reader("cla_DeliveryState"))
                Claim(i).mCCExpiryYear = nString(reader("CCExpiryYear"))
                Claim(i).mcla_CCDateEntered = nDate(reader("cla_CCDateEntered"))
                Claim(i).mcla_CCAmount = nDecimal(reader("cla_CCAmount"))
                Claim(i).mcla_LodgerHasAuthority = nBoolean(reader("cla_LodgerHasAuthority"))
                Claim(i).mcla_LodgerAccountHolderNoEnglish = nBoolean(reader("cla_LodgerAccountHolderNoEnglish"))
                Claim(i).mcla_DoNotOrder = nBoolean(reader("cla_DoNotOrder"))
                Claim(i).mcla_BPayNumberSeed = nInteger(reader("cla_BPayNumberSeed"))
                Claim(i).mcla_BPayNumber = nString(reader("cla_BPayNumber"))
                Claim(i).mcla_BPayRequired = nBoolean(reader("cla_BPayRequired"))
                Claim(i).mcla_RepairReceiptNo = nString(reader("cla_RepairReceiptNo"))
                Claim(i).mcla_RepairConsignmentNo = nString(reader("cla_RepairConsignmentNo"))
                Claim(i).mcla_OutstandingAmount = nDecimal(reader("cla_OutstandingAmount"))
                Claim(i).mcla_PhoneAccessoriesPaidTo2 = nString(reader("cla_PhoneAccessoriesPaidTo2"))
                Claim(i).mcla_PhoneAccessoriesPaidDate2 = nDate(reader("cla_PhoneAccessoriesPaidDate2"))
                Claim(i).mcla_PhoneAccessoriesPaidTo3 = nString(reader("cla_PhoneAccessoriesPaidTo3"))
                Claim(i).mcla_PhoneAccessoriesPaidDate3 = nDate(reader("cla_PhoneAccessoriesPaidDate3"))
                Claim(i).mcla_PhoneAccessoriesPaidTo4 = nString(reader("cla_PhoneAccessoriesPaidTo4"))
                Claim(i).mcla_PhoneAccessoriesPaidDate4 = nDate(reader("cla_PhoneAccessoriesPaidDate4"))
                Claim(i).mcla_RepairerPaidTo2 = nString(reader("cla_RepairerPaidTo2"))
                Claim(i).mcla_RepairerPaidToDate2 = nDate(reader("cla_RepairerPaidToDate2"))
                Claim(i).mcla_OtherPaidTo2 = nString(reader("cla_OtherPaidTo2"))
                Claim(i).mcla_OtherPaidToDate2 = nDate(reader("cla_OtherPaidToDate2"))
                Claim(i).mcla_ReplacePhone_sup_id = nInteger(reader("cla_ReplacePhone_sup_id"))
                Claim(i).mcla_ReplaceSIMCard_sup_id = nInteger(reader("cla_ReplaceSIMCard_sup_id"))
                Claim(i).mcla_ReplaceSimCardID = nInteger(reader("cla_ReplaceSimCardID"))
                Claim(i).mcla_ReplacePhone_SuppliersCode = nString(reader("cla_ReplacePhone_SuppliersCode"))
                Claim(i).mcla_ReplaceSIMCard_SuppliersCode = nString(reader("cla_ReplaceSIMCard_SuppliersCode"))
                Claim(i).mcla_InsuranceType = nString(reader("cla_InsuranceType"))
                Claim(i).mcla_TerminalId = nString(reader("cla_TerminalId"))
                Claim(i).mcla_DateReportedToSP = nDate(reader("cla_DateReportedToSP"))
                Claim(i).mcla_ProofOfForcibleEntry = nBoolean(reader("cla_ProofOfForcibleEntry"))
                Claim(i).mcla_ReplacePhoneRRP = nDecimal(reader("cla_ReplacePhoneRRP"))
                Claim(i).mcla_IMEIBlocked = nBoolean(reader("cla_IMEIBlocked"))
                Claim(i).mcla_DeclineReason = nString(reader("cla_DeclineReason"))
                Claim(i).mcla_ProofOfPurchase = nBoolean(reader("cla_ProofOfPurchase"))
                Claim(i).mcla_IMEINotBlockedReason = nString(reader("cla_IMEINotBlockedReason"))
                Claim(i).mDateAdded = nDate(reader("DateAdded"))
                Claim(i).mCPHID_MIA = nInteger(reader("CPHID_MIA"))
                Claim(i).mRPHID_MIA = nInteger(reader("RPHID_MIA"))
                Claim(i).mCustomerEmail = nString(reader("CustomerEmail"))
                Claim(i).mLetterRec_IMEI = nDate(reader("LetterRec_IMEI"))
                Claim(i).mLetterRec_Damaged = nDate(reader("LetterRec_Damaged"))
                Claim(i).mCashSettleAmount = nDecimal(reader("CashSettleAmount"))
                Claim(i).mFaxNumber = nString(reader("FaxNumber"))
                Claim(i).moSupplierName = nString(reader("oSupplierName"))
                Claim(i).moUseSupplier = nBoolean(reader("oUseSupplier"))
                Claim(i).moPhone = nString(reader("oPhone"))
                Claim(i).mletterRec_IPhoneDamage = nDate(reader("letterRec_IPhoneDamage"))
                Claim(i).mWarningNote = nString(reader("WarningNote"))
                Claim(i).mCaseManager = nString(reader("CaseManager"))
                Claim(i).mPhotoIDReceived = nBoolean(reader("PhotoIDReceived"))
                Claim(i).mBillReceived = nBoolean(reader("BillReceived"))
                Claim(i).mInteractionNotesReceived = nBoolean(reader("InteractionNotesReceived"))
                Claim(i).mDateTimeSimReplaced = nDate(reader("DateTimeSimReplaced"))
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return Claim
    End Function
#End Region
#End Region
End Class