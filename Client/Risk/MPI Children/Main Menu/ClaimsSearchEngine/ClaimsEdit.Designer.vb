'Imports NullableDateTimePicker
'Imports MultiComboControl
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClaimsEdit
    '  Inherits System.Windows.Forms.Form
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ClaimNumberLabel As System.Windows.Forms.Label
        Dim PhotoIDReceivedLabel As System.Windows.Forms.Label
        Dim BillReceivedLabel As System.Windows.Forms.Label
        Dim InteractionNotesReceivedLabel As System.Windows.Forms.Label
        Dim SDateTimeSimReplacedLabel As System.Windows.Forms.Label
        Dim CaseManagerLabel As System.Windows.Forms.Label
        Dim CaseManagerLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClaimsEdit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.LodgedDateLabel = New System.Windows.Forms.Label()
        Me.Cla_InsuranceTypeLabel = New System.Windows.Forms.Label()
        Me.SchemeIDLabel = New System.Windows.Forms.Label()
        Me.IMEINumberLabel = New System.Windows.Forms.Label()
        Me.PurchaseDateLabel = New System.Windows.Forms.Label()
        Me.MobilePhoneNumberLabel = New System.Windows.Forms.Label()
        Me.InsuranceDateLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GivenNameLabel = New System.Windows.Forms.Label()
        Me.FamilyNameLabel = New System.Windows.Forms.Label()
        Me.AccountNumberLabel = New System.Windows.Forms.Label()
        Me.CompanyNameLabel = New System.Windows.Forms.Label()
        Me.CustomerEmailLabel = New System.Windows.Forms.Label()
        Me.Cla_LodgerFirstNameLabel = New System.Windows.Forms.Label()
        Me.Cla_LodgerLastNameLabel = New System.Windows.Forms.Label()
        Me.Cla_LodgerRelationshipLabel = New System.Windows.Forms.Label()
        Me.LastPersonGivenNameLabel = New System.Windows.Forms.Label()
        Me.LastPersonFamilyNameLabel = New System.Windows.Forms.Label()
        Me.PhoneDealerLabel = New System.Windows.Forms.Label()
        Me.ContactNumberLabel = New System.Windows.Forms.Label()
        Me.ContactNumber2Label = New System.Windows.Forms.Label()
        Me.PostalAddress1Label = New System.Windows.Forms.Label()
        Me.PostalSuburbLabel = New System.Windows.Forms.Label()
        Me.FaxNumberLabel = New System.Windows.Forms.Label()
        Me.PostalPostcodeLabel = New System.Windows.Forms.Label()
        Me.Cla_PostalStateLabel = New System.Windows.Forms.Label()
        Me.Cla_LodgerHasAuthorityLabel = New System.Windows.Forms.Label()
        Me.Cla_LodgerAccountHolderNoEnglishLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PhoneDealelPostCodeLabel = New System.Windows.Forms.Label()
        Me.Cla_PhoneDealerStateLabel = New System.Windows.Forms.Label()
        Me.Cla_TerminalIdLabel = New System.Windows.Forms.Label()
        Me.CancelInsuranceFlagLabel = New System.Windows.Forms.Label()
        Me.Cla_DeclineReasonLabel = New System.Windows.Forms.Label()
        Me.LossTypeLabel = New System.Windows.Forms.Label()
        Me.Cla_DeliverPersonLabel = New System.Windows.Forms.Label()
        Me.DeliveryAddress1Label = New System.Windows.Forms.Label()
        Me.DeliverySuburbLabel = New System.Windows.Forms.Label()
        Me.Cla_DeliveryStateLabel = New System.Windows.Forms.Label()
        Me.DeliveryPostcodeLabel = New System.Windows.Forms.Label()
        Me.RepairReplaceCashIndicatorLabel = New System.Windows.Forms.Label()
        Me.Cla_ReplacePhone_sup_idLabel = New System.Windows.Forms.Label()
        Me.Cla_ReplacePhone_sup_idLabel1 = New System.Windows.Forms.Label()
        Me.ReplaceCostLabel = New System.Windows.Forms.Label()
        Me.Cla_ReplacePhoneRRPLabel = New System.Windows.Forms.Label()
        Me.Cla_FreightCostTypeLabel = New System.Windows.Forms.Label()
        Me.Cla_DoNotOrderLabel = New System.Windows.Forms.Label()
        Me.OUseSupplierLabel = New System.Windows.Forms.Label()
        Me.OSupplierNameLabel = New System.Windows.Forms.Label()
        Me.OPhoneLabel = New System.Windows.Forms.Label()
        Me.SimCardFlagLabel = New System.Windows.Forms.Label()
        Me.Cla_SimCardPreviousFlagLabel = New System.Windows.Forms.Label()
        Me.Cla_SimCardTypeLabel = New System.Windows.Forms.Label()
        Me.Cla_ReplaceSIMCard_sup_idLabel = New System.Windows.Forms.Label()
        Me.SimcardCostLabel = New System.Windows.Forms.Label()
        Me.AccOtherDescrLabel = New System.Windows.Forms.Label()
        Me.Cla_AccProductCodeLabel = New System.Windows.Forms.Label()
        Me.AccLeatherCaseLabel = New System.Windows.Forms.Label()
        Me.RepairerLabel = New System.Windows.Forms.Label()
        Me.Cla_RepairerJobNoLabel = New System.Windows.Forms.Label()
        Me.RepairCostLabel = New System.Windows.Forms.Label()
        Me.UnauthorisedCallsLabel = New System.Windows.Forms.Label()
        Me.Cla_ShortfallUpgradeCostLabel = New System.Windows.Forms.Label()
        Me.ExcessLabel = New System.Windows.Forms.Label()
        Me.CashSettleAmountLabel = New System.Windows.Forms.Label()
        Me.Cla_RepairConsignmentNoLabel = New System.Windows.Forms.Label()
        Me.Cla_SimCardNumberLabel = New System.Windows.Forms.Label()
        Me.NewIMEINumberLabel = New System.Windows.Forms.Label()
        Me.LetterRec_IMEILabel = New System.Windows.Forms.Label()
        Me.LetterRec_DamagedLabel = New System.Windows.Forms.Label()
        Me.ExcessLabel1 = New System.Windows.Forms.Label()
        Me.GSTLabel = New System.Windows.Forms.Label()
        Me.TotalClaimCostLabel = New System.Windows.Forms.Label()
        Me.TotalCostLessGSTLabel = New System.Windows.Forms.Label()
        Me.ReplaceVarianceCostLabel = New System.Windows.Forms.Label()
        Me.CCNameLabel = New System.Windows.Forms.Label()
        Me.CCNumberLabel = New System.Windows.Forms.Label()
        Me.Cla_CCDateEnteredLabel = New System.Windows.Forms.Label()
        Me.Cla_RepairReceiptNoLabel = New System.Windows.Forms.Label()
        Me.CCExpiryMonthYearLabel = New System.Windows.Forms.Label()
        Me.Cla_CCAmountLabel = New System.Windows.Forms.Label()
        Me.CCExpiryYearLabel = New System.Windows.Forms.Label()
        Me.Cla_BPayRequiredLabel = New System.Windows.Forms.Label()
        Me.Cla_BPayNumberLabel = New System.Windows.Forms.Label()
        Me.Cla_PhoneAccessoriesPaidTo2Label = New System.Windows.Forms.Label()
        Me.Cla_PhoneAccessoriesPaidTo3Label = New System.Windows.Forms.Label()
        Me.Cla_PhoneAccessoriesPaidTo4Label = New System.Windows.Forms.Label()
        Me.Cla_PhoneAccessoriesPaidToLabel = New System.Windows.Forms.Label()
        Me.Cla_SimCardPaidToLabel = New System.Windows.Forms.Label()
        Me.Cla_RepairerPaidToLabel = New System.Windows.Forms.Label()
        Me.Cla_OtherPaidToLabel = New System.Windows.Forms.Label()
        Me.Cla_PaidFullLabel = New System.Windows.Forms.Label()
        Me.Cla_RepairerPaidTo2Label = New System.Windows.Forms.Label()
        Me.Cla_OtherPaidTo2Label = New System.Windows.Forms.Label()
        Me.Cla_OutstandingAmountLabel = New System.Windows.Forms.Label()
        Me.ReplaceCostLabel1 = New System.Windows.Forms.Label()
        Me.FreightCostLabel = New System.Windows.Forms.Label()
        Me.AccLeatherCaseLabel1 = New System.Windows.Forms.Label()
        Me.SimcardCostLabel1 = New System.Windows.Forms.Label()
        Me.ReplaceCostLabel2 = New System.Windows.Forms.Label()
        Me.UnauthorisedCallsLabel1 = New System.Windows.Forms.Label()
        Me.Cla_ShortfallUpgradeCostLabel1 = New System.Windows.Forms.Label()
        Me.ReplaceVarianceCostLabel1 = New System.Windows.Forms.Label()
        Me.AccOtherLabel = New System.Windows.Forms.Label()
        Me.CashSettleAmountLabel1 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.LetterRec_IPhoneDamageLabel = New System.Windows.Forms.Label()
        Me.TblClaimBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RiskDataSet = New Risk.RiskDataSet()
        Me.ClaimNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UndockButton = New System.Windows.Forms.Button()
        Me.LodgedDateTextBox = New System.Windows.Forms.TextBox()
        Me.ClaimDetailsTabControl = New System.Windows.Forms.TabControl()
        Me.ClaimantDetailsTabPage = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxOISstore = New System.Windows.Forms.ComboBox()
        Me.Cla_TerminalIdTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneDealerStateTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneDealelPostCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SuburbMultiColumnCombo = New Risk.MultiColumnCombo()
        Me.PhoneDealer_TPostcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cla_LodgerAccountHolderNoEnglishCheckBox = New System.Windows.Forms.CheckBox()
        Me.Cla_LodgerHasAuthorityCheckBox = New System.Windows.Forms.CheckBox()
        Me.CopyAddressButton = New System.Windows.Forms.Button()
        Me.PostalSuburbMultiColumnCombo = New Risk.MultiColumnCombo()
        Me.Postal_TPostcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cla_PostalStateTextBox = New System.Windows.Forms.TextBox()
        Me.PostalPostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.FaxNumberTextBox = New System.Windows.Forms.TextBox()
        Me.PostalAddress2TextBox = New System.Windows.Forms.TextBox()
        Me.PostalAddress1TextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumber2TextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PhoneDealerTextBox = New System.Windows.Forms.TextBox()
        Me.LastPersonFamilyNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastPersonGivenNameTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_LodgerRelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_LodgerLastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_LodgerFirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CustomerEmailTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FamilyNameTextBox = New System.Windows.Forms.TextBox()
        Me.GivenNameTextBox = New System.Windows.Forms.TextBox()
        Me.TitleComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.PolicyNumberTextBox = New System.Windows.Forms.TextBox()
        Me.InsuranceDateTextBox = New System.Windows.Forms.TextBox()
        Me.PurchaseDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.WarningNoteTextBox = New System.Windows.Forms.TextBox()
        Me.CancelInsuranceFlagComboBox = New System.Windows.Forms.ComboBox()
        Me.YesNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckClaimMobileNumberButton = New System.Windows.Forms.Button()
        Me.CheckClaimFamilyNameButton = New System.Windows.Forms.Button()
        Me.Cla_InsuranceTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.SchemeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TblSchemeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMEINumberTextBox = New System.Windows.Forms.TextBox()
        Me.MobilePhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ClaimDetailsTabPage = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.ComboBoxClosedReason = New System.Windows.Forms.ComboBox()
        Me.OpenLetterReportButton = New System.Windows.Forms.Button()
        Me.CaseManagerComboBox = New System.Windows.Forms.ComboBox()
        Me.CaseManagerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeclinedStatusDateTextBox = New System.Windows.Forms.TextBox()
        Me.ApprovedStatusDateTextBox = New System.Windows.Forms.TextBox()
        Me.MoreInfoStatusDateTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateDateTextBox = New System.Windows.Forms.TextBox()
        Me.CancelledStatusDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Cla_DeclineReasonComboBox = New System.Windows.Forms.ComboBox()
        Me.TLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeclinedUseridTextBox = New System.Windows.Forms.TextBox()
        Me.ApprovedUseridTextBox = New System.Windows.Forms.TextBox()
        Me.CancelledUseridTextBox = New System.Windows.Forms.TextBox()
        Me.MoreInfoUseridTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateUserIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.DeliveryPostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_DeliveryStateTextBox = New System.Windows.Forms.TextBox()
        Me.DeliverySuburbMultiColumnCombo = New Risk.MultiColumnCombo()
        Me.Delivery_TPostcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryAddress2TextBox = New System.Windows.Forms.TextBox()
        Me.DeliveryAddress1TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_DeliverPersonTextBox = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.SDateTimeSimReplacedTextBox = New System.Windows.Forms.TextBox()
        Me.InteractionNotesReceivedCheckBox = New System.Windows.Forms.CheckBox()
        Me.BillReceivedCheckBox = New System.Windows.Forms.CheckBox()
        Me.PhotoIDReceivedCheckBox = New System.Windows.Forms.CheckBox()
        Me.LossDateTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_ProofOfPurchaseCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Cla_IMEINotBlockedReasonTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_IMEIBlockedCheckBox = New System.Windows.Forms.CheckBox()
        Me.PoliceReportNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Cla_ProofOfForcibleEntryCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ExampleCircumstancesButton = New System.Windows.Forms.Button()
        Me.LossTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.DamageTypeTextBox = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SettlementDetailsTabPage = New System.Windows.Forms.TabPage()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.ChequePaymentDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.IsProcessedChequeCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.ChequeSupplierNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ChequeNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.ChequeAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.CopyAccountHoldersButton = New System.Windows.Forms.Button()
        Me.ReturnToAddressCheckBox = New System.Windows.Forms.CheckBox()
        Me.RemittanceLayoutCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.PostCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Street3TextBox = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Street1TextBox = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.RemittanceDeliveryTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.PayeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddresseeNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Street2TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.EFTPaymentDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.IsProcessedEFTCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.AccountNameTextBox = New System.Windows.Forms.TextBox()
        Me.BSBNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AccountNameLabel = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.EFTPaymentAmountTextBox = New System.Windows.Forms.TextBox()
        Me.EFTAccountNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.cla_IMEIDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.NewIMEINumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Cla_RepairConsignmentNoTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_SimCardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.CashSettleAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ExcessTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_ShortfallUpgradeCostTextBox = New System.Windows.Forms.TextBox()
        Me.UnauthorisedCallsTextBox = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.RepairCostTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_RepairerJobNoTextBox = New System.Windows.Forms.TextBox()
        Me.RepairerComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.AccOtherDescrTextBox = New System.Windows.Forms.TextBox()
        Me.AccOtherTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_AccProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_AccOtherProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.AccLeatherCaseTextBox = New System.Windows.Forms.TextBox()
        Me.OSupplierNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Cla_ReplaceSIMCard_SuppliersCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SimCardProductCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_SimCardTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.SimcardCostTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_ReplaceSimCardIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_ReplaceSIMCard_sup_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_SimCardPreviousFlagComboBox = New System.Windows.Forms.ComboBox()
        Me.SimCardFlagComboBox = New System.Windows.Forms.ComboBox()
        Me.OUseSupplierCheckBox = New System.Windows.Forms.CheckBox()
        Me.Cla_DoNotOrderCheckBox = New System.Windows.Forms.CheckBox()
        Me.FreightCostTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_FreightCostTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.FreightCostTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Cla_ReplacePhoneRRPTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_ReplacePhone_SuppliersCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ReplaceCostTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_ReplacePhone_sup_idComboBox = New System.Windows.Forms.ComboBox()
        Me.ReplacementPhone_TSupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReplacePhoneIDMultiColumnCombo = New Risk.MultiColumnCombo()
        Me.PhonePriceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReplacePhoneIDTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_ReplacePhone_sup_idTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentPhoneIDMultiColumnCombo = New Risk.MultiColumnCombo()
        Me.Current_TblPhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label32 = New System.Windows.Forms.Label()
        Me.RepairReplaceCashIndicatorComboBox = New System.Windows.Forms.ComboBox()
        Me.DeclarationAndNotesTabPage = New System.Windows.Forms.TabPage()
        Me.LetterRec_IPhoneDamageTextBox = New System.Windows.Forms.TextBox()
        Me.AddNewNotationButton = New System.Windows.Forms.Button()
        Me.TblClaimNoteDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LetterRec_DamagedTextBox = New System.Windows.Forms.TextBox()
        Me.LetterRec_IMEITextBox = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.DiaryEntryTextBox = New System.Windows.Forms.TextBox()
        Me.DiaryDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCancelled = New System.Windows.Forms.TextBox()
        Me.CorrectInfoFlagComboBox = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.PaymentsTabPage = New System.Windows.Forms.TabPage()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.CashSettleAmountTextBox1 = New System.Windows.Forms.TextBox()
        Me.AccOtherTextBox1 = New System.Windows.Forms.TextBox()
        Me.ReplaceVarianceCostTextBox1 = New System.Windows.Forms.TextBox()
        Me.Cla_ShortfallUpgradeCostTextBox1 = New System.Windows.Forms.TextBox()
        Me.UnauthorisedCallsTextBox1 = New System.Windows.Forms.TextBox()
        Me.ReplaceCostTextBox2 = New System.Windows.Forms.TextBox()
        Me.SimcardCostTextBox1 = New System.Windows.Forms.TextBox()
        Me.AccLeatherCaseTextBox1 = New System.Windows.Forms.TextBox()
        Me.FreightCostTextBox1 = New System.Windows.Forms.TextBox()
        Me.ReplaceCostTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Cla_OtherPaidToDate2TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_RepairerPaidToDate2TextBox = New System.Windows.Forms.TextBox()
        Me.sCla_OtherPaidToDateTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_RepairerPaidToDateTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_SimCardPaidToDateTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesPaidDate4TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesPaidDate3TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesPaidDate2TextBox = New System.Windows.Forms.TextBox()
        Me.PaidStatusDateTextBox = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Cla_OutstandingAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_OtherInvoiceNo2AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_RepairerInvoiceNo2AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_OtherInvoiceNo2TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_RepairerInvoiceNo2TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_OtherPaidTo2ComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_RepairerPaidTo2ComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_PaidBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PaidBalanceLabel = New System.Windows.Forms.Label()
        Me.Cla_OtherInvoiceNo1AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_RepairerInvoiceNo1AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_SimCardInvoiceNo1AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_OtherInvoiceNo1TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_RepairerInvoiceNo1TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_SimCardInvoiceNo1TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesInvoiceNo4AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesInvoiceNo3AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesInvoiceNo2AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesInvoiceNo1AmtTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesInvoiceNo4TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_PhoneAccessoriesInvoiceNo3TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_InvoiceNo2TextBox = New System.Windows.Forms.TextBox()
        Me.Cla_InvoiceNo1TextBox = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Cla_PaidFullComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_OtherPaidToComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_RepairerPaidToComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_SimCardPaidToComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_PhoneAccessoriesPaidToComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox = New System.Windows.Forms.ComboBox()
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Cla_CCDateEnteredTextBox = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Cla_BPayNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.CCExpiryYearNullableMaskedTextBox = New Risk.NullableMaskedTextBox()
        Me.CCExpiryMonthYearNullableMaskedTextBox = New Risk.NullableMaskedTextBox()
        Me.Cla_BPayRequiredCheckBox = New System.Windows.Forms.CheckBox()
        Me.Cla_CCAmountTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_BPayNumberSeedTextBox = New System.Windows.Forms.TextBox()
        Me.CCNameTextBox = New System.Windows.Forms.TextBox()
        Me.Cla_RepairReceiptNoTextBox = New System.Windows.Forms.TextBox()
        Me.CCNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.ExcessTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox()
        Me.GSTTextBox = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TotalCostlessGSTTextBox = New System.Windows.Forms.TextBox()
        Me.ReplaceVarianceCostTextBox = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TotalCostLessGSTTextBox1 = New System.Windows.Forms.TextBox()
        Me.TotalClaimCostTextBox = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.AuditTabPage = New System.Windows.Forms.TabPage()
        Me.TblAuditDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblAuditBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RefLetteReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClaimNoteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Replace_TblPhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Risk.RiskDataSetTableAdapters.TableAdapterManager()
        Me.T_LookupTableAdapter = New Risk.RiskDataSetTableAdapters.t_LookupTableAdapter()
        Me.Ref_LetteReportsTableAdapter = New Risk.RiskDataSetTableAdapters.ref_LetteReportsTableAdapter()
        Me.TblClaimNoteTableAdapter = New Risk.RiskDataSetTableAdapters.tblClaimNoteTableAdapter()
        Me.TblAuditTableAdapter = New Risk.RiskDataSetTableAdapters.tblAuditTableAdapter()
        Me.ExitDoorwayButton1 = New Risk.ExitDoorwayButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CaseManagerTextBox = New System.Windows.Forms.TextBox()
        Me.SaveRefreshButton = New System.Windows.Forms.Button()
        Me.NoteType = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextNoteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAdded = New System.Windows.Forms.DataGridViewTextBoxColumn()
        ClaimNumberLabel = New System.Windows.Forms.Label()
        PhotoIDReceivedLabel = New System.Windows.Forms.Label()
        BillReceivedLabel = New System.Windows.Forms.Label()
        InteractionNotesReceivedLabel = New System.Windows.Forms.Label()
        SDateTimeSimReplacedLabel = New System.Windows.Forms.Label()
        CaseManagerLabel = New System.Windows.Forms.Label()
        CaseManagerLabel1 = New System.Windows.Forms.Label()
        CType(Me.TblClaimBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClaimDetailsTabControl.SuspendLayout()
        Me.ClaimantDetailsTabPage.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PhoneDealer_TPostcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Postal_TPostcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.YesNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClaimDetailsTabPage.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.CaseManagerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel20.SuspendLayout()
        CType(Me.Delivery_TPostcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SettlementDetailsTabPage.SuspendLayout()
        Me.Panel22.SuspendLayout()
        Me.Panel21.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.FreightCostTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReplacementPhone_TSupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhonePriceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Current_TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeclarationAndNotesTabPage.SuspendLayout()
        CType(Me.TblClaimNoteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.PaymentsTabPage.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.AuditTabPage.SuspendLayout()
        CType(Me.TblAuditDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAuditBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RefLetteReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClaimNoteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Replace_TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClaimNumberLabel
        '
        ClaimNumberLabel.AutoSize = True
        ClaimNumberLabel.Location = New System.Drawing.Point(243, 9)
        ClaimNumberLabel.Name = "ClaimNumberLabel"
        ClaimNumberLabel.Size = New System.Drawing.Size(72, 13)
        ClaimNumberLabel.TabIndex = 1
        ClaimNumberLabel.Text = "Claim Number"
        '
        'PhotoIDReceivedLabel
        '
        PhotoIDReceivedLabel.AutoSize = True
        PhotoIDReceivedLabel.Location = New System.Drawing.Point(130, 214)
        PhotoIDReceivedLabel.Name = "PhotoIDReceivedLabel"
        PhotoIDReceivedLabel.Size = New System.Drawing.Size(98, 13)
        PhotoIDReceivedLabel.TabIndex = 27
        PhotoIDReceivedLabel.Text = "Photo IDReceived:"
        '
        'BillReceivedLabel
        '
        BillReceivedLabel.AutoSize = True
        BillReceivedLabel.Location = New System.Drawing.Point(156, 237)
        BillReceivedLabel.Name = "BillReceivedLabel"
        BillReceivedLabel.Size = New System.Drawing.Size(72, 13)
        BillReceivedLabel.TabIndex = 28
        BillReceivedLabel.Text = "Bill Received:"
        '
        'InteractionNotesReceivedLabel
        '
        InteractionNotesReceivedLabel.AutoSize = True
        InteractionNotesReceivedLabel.Location = New System.Drawing.Point(88, 263)
        InteractionNotesReceivedLabel.Name = "InteractionNotesReceivedLabel"
        InteractionNotesReceivedLabel.Size = New System.Drawing.Size(140, 13)
        InteractionNotesReceivedLabel.TabIndex = 29
        InteractionNotesReceivedLabel.Text = "Interaction Notes Received:"
        '
        'SDateTimeSimReplacedLabel
        '
        SDateTimeSimReplacedLabel.AutoSize = True
        SDateTimeSimReplacedLabel.Location = New System.Drawing.Point(92, 291)
        SDateTimeSimReplacedLabel.Name = "SDateTimeSimReplacedLabel"
        SDateTimeSimReplacedLabel.Size = New System.Drawing.Size(128, 13)
        SDateTimeSimReplacedLabel.TabIndex = 30
        SDateTimeSimReplacedLabel.Text = "Date Time Sim Replaced:"
        '
        'CaseManagerLabel
        '
        CaseManagerLabel.AutoSize = True
        CaseManagerLabel.Location = New System.Drawing.Point(303, 111)
        CaseManagerLabel.Name = "CaseManagerLabel"
        CaseManagerLabel.Size = New System.Drawing.Size(79, 13)
        CaseManagerLabel.TabIndex = 30
        CaseManagerLabel.Text = "Case Manager:"
        '
        'CaseManagerLabel1
        '
        CaseManagerLabel1.AutoSize = True
        CaseManagerLabel1.Location = New System.Drawing.Point(236, 37)
        CaseManagerLabel1.Name = "CaseManagerLabel1"
        CaseManagerLabel1.Size = New System.Drawing.Size(79, 13)
        CaseManagerLabel1.TabIndex = 375
        CaseManagerLabel1.Text = "Case Manager:"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(428, 12)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(37, 13)
        Me.StatusLabel.TabIndex = 3
        Me.StatusLabel.Text = "Status"
        '
        'LodgedDateLabel
        '
        Me.LodgedDateLabel.AutoSize = True
        Me.LodgedDateLabel.Location = New System.Drawing.Point(583, 12)
        Me.LodgedDateLabel.Name = "LodgedDateLabel"
        Me.LodgedDateLabel.Size = New System.Drawing.Size(69, 13)
        Me.LodgedDateLabel.TabIndex = 5
        Me.LodgedDateLabel.Text = "Date Lodged"
        '
        'Cla_InsuranceTypeLabel
        '
        Me.Cla_InsuranceTypeLabel.AutoSize = True
        Me.Cla_InsuranceTypeLabel.Location = New System.Drawing.Point(39, 15)
        Me.Cla_InsuranceTypeLabel.Name = "Cla_InsuranceTypeLabel"
        Me.Cla_InsuranceTypeLabel.Size = New System.Drawing.Size(81, 13)
        Me.Cla_InsuranceTypeLabel.TabIndex = 0
        Me.Cla_InsuranceTypeLabel.Text = "Insurance Type"
        '
        'SchemeIDLabel
        '
        Me.SchemeIDLabel.AutoSize = True
        Me.SchemeIDLabel.Location = New System.Drawing.Point(57, 42)
        Me.SchemeIDLabel.Name = "SchemeIDLabel"
        Me.SchemeIDLabel.Size = New System.Drawing.Size(60, 13)
        Me.SchemeIDLabel.TabIndex = 2
        Me.SchemeIDLabel.Text = "Scheme ID"
        '
        'IMEINumberLabel
        '
        Me.IMEINumberLabel.AutoSize = True
        Me.IMEINumberLabel.Location = New System.Drawing.Point(51, 69)
        Me.IMEINumberLabel.Name = "IMEINumberLabel"
        Me.IMEINumberLabel.Size = New System.Drawing.Size(66, 13)
        Me.IMEINumberLabel.TabIndex = 4
        Me.IMEINumberLabel.Text = "IMEINumber"
        '
        'PurchaseDateLabel
        '
        Me.PurchaseDateLabel.AutoSize = True
        Me.PurchaseDateLabel.Location = New System.Drawing.Point(15, 96)
        Me.PurchaseDateLabel.Name = "PurchaseDateLabel"
        Me.PurchaseDateLabel.Size = New System.Drawing.Size(105, 13)
        Me.PurchaseDateLabel.TabIndex = 6
        Me.PurchaseDateLabel.Text = "Insurance Start Date"
        '
        'MobilePhoneNumberLabel
        '
        Me.MobilePhoneNumberLabel.AutoSize = True
        Me.MobilePhoneNumberLabel.Location = New System.Drawing.Point(404, 44)
        Me.MobilePhoneNumberLabel.Name = "MobilePhoneNumberLabel"
        Me.MobilePhoneNumberLabel.Size = New System.Drawing.Size(112, 13)
        Me.MobilePhoneNumberLabel.TabIndex = 8
        Me.MobilePhoneNumberLabel.Text = "Mobile Phone Number"
        '
        'InsuranceDateLabel
        '
        Me.InsuranceDateLabel.AutoSize = True
        Me.InsuranceDateLabel.Location = New System.Drawing.Point(382, 71)
        Me.InsuranceDateLabel.Name = "InsuranceDateLabel"
        Me.InsuranceDateLabel.Size = New System.Drawing.Size(134, 13)
        Me.InsuranceDateLabel.TabIndex = 10
        Me.InsuranceDateLabel.Text = "Last Transaction (Bill) Date"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(0, 21)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(27, 13)
        Me.TitleLabel.TabIndex = 20
        Me.TitleLabel.Text = "Title"
        '
        'GivenNameLabel
        '
        Me.GivenNameLabel.AutoSize = True
        Me.GivenNameLabel.Location = New System.Drawing.Point(91, 21)
        Me.GivenNameLabel.Name = "GivenNameLabel"
        Me.GivenNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.GivenNameLabel.TabIndex = 21
        Me.GivenNameLabel.Text = "First Name"
        '
        'FamilyNameLabel
        '
        Me.FamilyNameLabel.AutoSize = True
        Me.FamilyNameLabel.Location = New System.Drawing.Point(262, 21)
        Me.FamilyNameLabel.Name = "FamilyNameLabel"
        Me.FamilyNameLabel.Size = New System.Drawing.Size(49, 13)
        Me.FamilyNameLabel.TabIndex = 22
        Me.FamilyNameLabel.Text = "Surname"
        '
        'AccountNumberLabel
        '
        Me.AccountNumberLabel.AutoSize = True
        Me.AccountNumberLabel.Location = New System.Drawing.Point(3, 66)
        Me.AccountNumberLabel.Name = "AccountNumberLabel"
        Me.AccountNumberLabel.Size = New System.Drawing.Size(64, 13)
        Me.AccountNumberLabel.TabIndex = 23
        Me.AccountNumberLabel.Text = "Account No"
        '
        'CompanyNameLabel
        '
        Me.CompanyNameLabel.AutoSize = True
        Me.CompanyNameLabel.Location = New System.Drawing.Point(3, 92)
        Me.CompanyNameLabel.Name = "CompanyNameLabel"
        Me.CompanyNameLabel.Size = New System.Drawing.Size(51, 13)
        Me.CompanyNameLabel.TabIndex = 24
        Me.CompanyNameLabel.Text = "Company"
        '
        'CustomerEmailLabel
        '
        Me.CustomerEmailLabel.AutoSize = True
        Me.CustomerEmailLabel.Location = New System.Drawing.Point(3, 117)
        Me.CustomerEmailLabel.Name = "CustomerEmailLabel"
        Me.CustomerEmailLabel.Size = New System.Drawing.Size(76, 13)
        Me.CustomerEmailLabel.TabIndex = 25
        Me.CustomerEmailLabel.Text = "CustomerEmail"
        '
        'Cla_LodgerFirstNameLabel
        '
        Me.Cla_LodgerFirstNameLabel.AutoSize = True
        Me.Cla_LodgerFirstNameLabel.Location = New System.Drawing.Point(7, 173)
        Me.Cla_LodgerFirstNameLabel.Name = "Cla_LodgerFirstNameLabel"
        Me.Cla_LodgerFirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.Cla_LodgerFirstNameLabel.TabIndex = 27
        Me.Cla_LodgerFirstNameLabel.Text = "First Name"
        '
        'Cla_LodgerLastNameLabel
        '
        Me.Cla_LodgerLastNameLabel.AutoSize = True
        Me.Cla_LodgerLastNameLabel.Location = New System.Drawing.Point(173, 173)
        Me.Cla_LodgerLastNameLabel.Name = "Cla_LodgerLastNameLabel"
        Me.Cla_LodgerLastNameLabel.Size = New System.Drawing.Size(49, 13)
        Me.Cla_LodgerLastNameLabel.TabIndex = 28
        Me.Cla_LodgerLastNameLabel.Text = "Surname"
        '
        'Cla_LodgerRelationshipLabel
        '
        Me.Cla_LodgerRelationshipLabel.AutoSize = True
        Me.Cla_LodgerRelationshipLabel.Location = New System.Drawing.Point(7, 222)
        Me.Cla_LodgerRelationshipLabel.Name = "Cla_LodgerRelationshipLabel"
        Me.Cla_LodgerRelationshipLabel.Size = New System.Drawing.Size(151, 13)
        Me.Cla_LodgerRelationshipLabel.TabIndex = 29
        Me.Cla_LodgerRelationshipLabel.Text = "Relationship to account holder"
        '
        'LastPersonGivenNameLabel
        '
        Me.LastPersonGivenNameLabel.AutoSize = True
        Me.LastPersonGivenNameLabel.Location = New System.Drawing.Point(7, 295)
        Me.LastPersonGivenNameLabel.Name = "LastPersonGivenNameLabel"
        Me.LastPersonGivenNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.LastPersonGivenNameLabel.TabIndex = 30
        Me.LastPersonGivenNameLabel.Text = "First Name"
        '
        'LastPersonFamilyNameLabel
        '
        Me.LastPersonFamilyNameLabel.AutoSize = True
        Me.LastPersonFamilyNameLabel.Location = New System.Drawing.Point(173, 295)
        Me.LastPersonFamilyNameLabel.Name = "LastPersonFamilyNameLabel"
        Me.LastPersonFamilyNameLabel.Size = New System.Drawing.Size(49, 13)
        Me.LastPersonFamilyNameLabel.TabIndex = 31
        Me.LastPersonFamilyNameLabel.Text = "Surname"
        '
        'PhoneDealerLabel
        '
        Me.PhoneDealerLabel.AutoSize = True
        Me.PhoneDealerLabel.Location = New System.Drawing.Point(373, 427)
        Me.PhoneDealerLabel.Name = "PhoneDealerLabel"
        Me.PhoneDealerLabel.Size = New System.Drawing.Size(32, 13)
        Me.PhoneDealerLabel.TabIndex = 32
        Me.PhoneDealerLabel.Text = "Shop"
        Me.PhoneDealerLabel.Visible = False
        '
        'ContactNumberLabel
        '
        Me.ContactNumberLabel.AutoSize = True
        Me.ContactNumberLabel.Location = New System.Drawing.Point(461, 14)
        Me.ContactNumberLabel.Name = "ContactNumberLabel"
        Me.ContactNumberLabel.Size = New System.Drawing.Size(93, 13)
        Me.ContactNumberLabel.TabIndex = 35
        Me.ContactNumberLabel.Text = "Contact Number 1"
        '
        'ContactNumber2Label
        '
        Me.ContactNumber2Label.AutoSize = True
        Me.ContactNumber2Label.Location = New System.Drawing.Point(461, 40)
        Me.ContactNumber2Label.Name = "ContactNumber2Label"
        Me.ContactNumber2Label.Size = New System.Drawing.Size(93, 13)
        Me.ContactNumber2Label.TabIndex = 36
        Me.ContactNumber2Label.Text = "Contact Number 2"
        '
        'PostalAddress1Label
        '
        Me.PostalAddress1Label.AutoSize = True
        Me.PostalAddress1Label.Location = New System.Drawing.Point(477, 66)
        Me.PostalAddress1Label.Name = "PostalAddress1Label"
        Me.PostalAddress1Label.Size = New System.Drawing.Size(77, 13)
        Me.PostalAddress1Label.TabIndex = 37
        Me.PostalAddress1Label.Text = "Postal Address"
        '
        'PostalSuburbLabel
        '
        Me.PostalSuburbLabel.AutoSize = True
        Me.PostalSuburbLabel.Location = New System.Drawing.Point(513, 117)
        Me.PostalSuburbLabel.Name = "PostalSuburbLabel"
        Me.PostalSuburbLabel.Size = New System.Drawing.Size(41, 13)
        Me.PostalSuburbLabel.TabIndex = 39
        Me.PostalSuburbLabel.Text = "Suburb"
        '
        'FaxNumberLabel
        '
        Me.FaxNumberLabel.AutoSize = True
        Me.FaxNumberLabel.Location = New System.Drawing.Point(689, 14)
        Me.FaxNumberLabel.Name = "FaxNumberLabel"
        Me.FaxNumberLabel.Size = New System.Drawing.Size(61, 13)
        Me.FaxNumberLabel.TabIndex = 40
        Me.FaxNumberLabel.Text = "FaxNumber"
        '
        'PostalPostcodeLabel
        '
        Me.PostalPostcodeLabel.AutoSize = True
        Me.PostalPostcodeLabel.Location = New System.Drawing.Point(589, 146)
        Me.PostalPostcodeLabel.Name = "PostalPostcodeLabel"
        Me.PostalPostcodeLabel.Size = New System.Drawing.Size(52, 13)
        Me.PostalPostcodeLabel.TabIndex = 41
        Me.PostalPostcodeLabel.Text = "Postcode"
        '
        'Cla_PostalStateLabel
        '
        Me.Cla_PostalStateLabel.AutoSize = True
        Me.Cla_PostalStateLabel.Location = New System.Drawing.Point(707, 146)
        Me.Cla_PostalStateLabel.Name = "Cla_PostalStateLabel"
        Me.Cla_PostalStateLabel.Size = New System.Drawing.Size(55, 13)
        Me.Cla_PostalStateLabel.TabIndex = 42
        Me.Cla_PostalStateLabel.Text = "State/Dist"
        '
        'Cla_LodgerHasAuthorityLabel
        '
        Me.Cla_LodgerHasAuthorityLabel.AutoSize = True
        Me.Cla_LodgerHasAuthorityLabel.Location = New System.Drawing.Point(370, 314)
        Me.Cla_LodgerHasAuthorityLabel.Name = "Cla_LodgerHasAuthorityLabel"
        Me.Cla_LodgerHasAuthorityLabel.Size = New System.Drawing.Size(159, 13)
        Me.Cla_LodgerHasAuthorityLabel.TabIndex = 45
        Me.Cla_LodgerHasAuthorityLabel.Text = "Lodger has been given authority"
        '
        'Cla_LodgerAccountHolderNoEnglishLabel
        '
        Me.Cla_LodgerAccountHolderNoEnglishLabel.AutoSize = True
        Me.Cla_LodgerAccountHolderNoEnglishLabel.Location = New System.Drawing.Point(575, 314)
        Me.Cla_LodgerAccountHolderNoEnglishLabel.Name = "Cla_LodgerAccountHolderNoEnglishLabel"
        Me.Cla_LodgerAccountHolderNoEnglishLabel.Size = New System.Drawing.Size(194, 13)
        Me.Cla_LodgerAccountHolderNoEnglishLabel.TabIndex = 46
        Me.Cla_LodgerAccountHolderNoEnglishLabel.Text = "Account Holder does not speak English"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Suburb"
        '
        'PhoneDealelPostCodeLabel
        '
        Me.PhoneDealelPostCodeLabel.AutoSize = True
        Me.PhoneDealelPostCodeLabel.Location = New System.Drawing.Point(726, 407)
        Me.PhoneDealelPostCodeLabel.Name = "PhoneDealelPostCodeLabel"
        Me.PhoneDealelPostCodeLabel.Size = New System.Drawing.Size(52, 13)
        Me.PhoneDealelPostCodeLabel.TabIndex = 50
        Me.PhoneDealelPostCodeLabel.Text = "Postcode"
        Me.PhoneDealelPostCodeLabel.Visible = False
        '
        'Cla_PhoneDealerStateLabel
        '
        Me.Cla_PhoneDealerStateLabel.AutoSize = True
        Me.Cla_PhoneDealerStateLabel.Location = New System.Drawing.Point(663, 407)
        Me.Cla_PhoneDealerStateLabel.Name = "Cla_PhoneDealerStateLabel"
        Me.Cla_PhoneDealerStateLabel.Size = New System.Drawing.Size(32, 13)
        Me.Cla_PhoneDealerStateLabel.TabIndex = 52
        Me.Cla_PhoneDealerStateLabel.Text = "State"
        Me.Cla_PhoneDealerStateLabel.Visible = False
        '
        'Cla_TerminalIdLabel
        '
        Me.Cla_TerminalIdLabel.AutoSize = True
        Me.Cla_TerminalIdLabel.Location = New System.Drawing.Point(789, 408)
        Me.Cla_TerminalIdLabel.Name = "Cla_TerminalIdLabel"
        Me.Cla_TerminalIdLabel.Size = New System.Drawing.Size(56, 13)
        Me.Cla_TerminalIdLabel.TabIndex = 54
        Me.Cla_TerminalIdLabel.Text = "TerminalId"
        Me.Cla_TerminalIdLabel.Visible = False
        '
        'CancelInsuranceFlagLabel
        '
        Me.CancelInsuranceFlagLabel.AutoSize = True
        Me.CancelInsuranceFlagLabel.ForeColor = System.Drawing.Color.Red
        Me.CancelInsuranceFlagLabel.Location = New System.Drawing.Point(588, 96)
        Me.CancelInsuranceFlagLabel.Name = "CancelInsuranceFlagLabel"
        Me.CancelInsuranceFlagLabel.Size = New System.Drawing.Size(202, 13)
        Me.CancelInsuranceFlagLabel.TabIndex = 15
        Me.CancelInsuranceFlagLabel.Text = "Cancel Insurance if 2 claims in 12 months"
        '
        'Cla_DeclineReasonLabel
        '
        Me.Cla_DeclineReasonLabel.AutoSize = True
        Me.Cla_DeclineReasonLabel.Location = New System.Drawing.Point(297, 86)
        Me.Cla_DeclineReasonLabel.Name = "Cla_DeclineReasonLabel"
        Me.Cla_DeclineReasonLabel.Size = New System.Drawing.Size(83, 13)
        Me.Cla_DeclineReasonLabel.TabIndex = 15
        Me.Cla_DeclineReasonLabel.Text = "Decline Reason"
        '
        'LossTypeLabel
        '
        Me.LossTypeLabel.AutoSize = True
        Me.LossTypeLabel.Location = New System.Drawing.Point(410, 33)
        Me.LossTypeLabel.Name = "LossTypeLabel"
        Me.LossTypeLabel.Size = New System.Drawing.Size(71, 13)
        Me.LossTypeLabel.TabIndex = 6
        Me.LossTypeLabel.Text = "Circumstance"
        '
        'Cla_DeliverPersonLabel
        '
        Me.Cla_DeliverPersonLabel.AutoSize = True
        Me.Cla_DeliverPersonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cla_DeliverPersonLabel.Location = New System.Drawing.Point(17, 81)
        Me.Cla_DeliverPersonLabel.Name = "Cla_DeliverPersonLabel"
        Me.Cla_DeliverPersonLabel.Size = New System.Drawing.Size(188, 13)
        Me.Cla_DeliverPersonLabel.TabIndex = 24
        Me.Cla_DeliverPersonLabel.Text = "Name of  Person signing for the phone"
        '
        'DeliveryAddress1Label
        '
        Me.DeliveryAddress1Label.AutoSize = True
        Me.DeliveryAddress1Label.Location = New System.Drawing.Point(269, 81)
        Me.DeliveryAddress1Label.Name = "DeliveryAddress1Label"
        Me.DeliveryAddress1Label.Size = New System.Drawing.Size(86, 13)
        Me.DeliveryAddress1Label.TabIndex = 25
        Me.DeliveryAddress1Label.Text = "Delivery Address"
        '
        'DeliverySuburbLabel
        '
        Me.DeliverySuburbLabel.AutoSize = True
        Me.DeliverySuburbLabel.Location = New System.Drawing.Point(554, 100)
        Me.DeliverySuburbLabel.Name = "DeliverySuburbLabel"
        Me.DeliverySuburbLabel.Size = New System.Drawing.Size(41, 13)
        Me.DeliverySuburbLabel.TabIndex = 27
        Me.DeliverySuburbLabel.Text = "Suburb"
        '
        'Cla_DeliveryStateLabel
        '
        Me.Cla_DeliveryStateLabel.AutoSize = True
        Me.Cla_DeliveryStateLabel.Location = New System.Drawing.Point(554, 121)
        Me.Cla_DeliveryStateLabel.Name = "Cla_DeliveryStateLabel"
        Me.Cla_DeliveryStateLabel.Size = New System.Drawing.Size(32, 13)
        Me.Cla_DeliveryStateLabel.TabIndex = 28
        Me.Cla_DeliveryStateLabel.Text = "State"
        '
        'DeliveryPostcodeLabel
        '
        Me.DeliveryPostcodeLabel.AutoSize = True
        Me.DeliveryPostcodeLabel.Location = New System.Drawing.Point(730, 124)
        Me.DeliveryPostcodeLabel.Name = "DeliveryPostcodeLabel"
        Me.DeliveryPostcodeLabel.Size = New System.Drawing.Size(39, 13)
        Me.DeliveryPostcodeLabel.TabIndex = 29
        Me.DeliveryPostcodeLabel.Text = "PCode"
        '
        'RepairReplaceCashIndicatorLabel
        '
        Me.RepairReplaceCashIndicatorLabel.AutoSize = True
        Me.RepairReplaceCashIndicatorLabel.Location = New System.Drawing.Point(5, 9)
        Me.RepairReplaceCashIndicatorLabel.Name = "RepairReplaceCashIndicatorLabel"
        Me.RepairReplaceCashIndicatorLabel.Size = New System.Drawing.Size(290, 13)
        Me.RepairReplaceCashIndicatorLabel.TabIndex = 1
        Me.RepairReplaceCashIndicatorLabel.Text = "Replace, Repair, Cash or Unauthorised Calls or Sick/Injured"
        '
        'Cla_ReplacePhone_sup_idLabel
        '
        Me.Cla_ReplacePhone_sup_idLabel.AutoSize = True
        Me.Cla_ReplacePhone_sup_idLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_ReplacePhone_sup_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cla_ReplacePhone_sup_idLabel.Location = New System.Drawing.Point(5, 73)
        Me.Cla_ReplacePhone_sup_idLabel.Name = "Cla_ReplacePhone_sup_idLabel"
        Me.Cla_ReplacePhone_sup_idLabel.Size = New System.Drawing.Size(121, 13)
        Me.Cla_ReplacePhone_sup_idLabel.TabIndex = 4
        Me.Cla_ReplacePhone_sup_idLabel.Text = "Replacement Phone"
        '
        'Cla_ReplacePhone_sup_idLabel1
        '
        Me.Cla_ReplacePhone_sup_idLabel1.AutoSize = True
        Me.Cla_ReplacePhone_sup_idLabel1.Location = New System.Drawing.Point(3, 102)
        Me.Cla_ReplacePhone_sup_idLabel1.Name = "Cla_ReplacePhone_sup_idLabel1"
        Me.Cla_ReplacePhone_sup_idLabel1.Size = New System.Drawing.Size(66, 13)
        Me.Cla_ReplacePhone_sup_idLabel1.TabIndex = 8
        Me.Cla_ReplacePhone_sup_idLabel1.Text = "Supp/Model"
        '
        'ReplaceCostLabel
        '
        Me.ReplaceCostLabel.AutoSize = True
        Me.ReplaceCostLabel.Location = New System.Drawing.Point(41, 128)
        Me.ReplaceCostLabel.Name = "ReplaceCostLabel"
        Me.ReplaceCostLabel.Size = New System.Drawing.Size(28, 13)
        Me.ReplaceCostLabel.TabIndex = 12
        Me.ReplaceCostLabel.Text = "Cost"
        '
        'Cla_ReplacePhoneRRPLabel
        '
        Me.Cla_ReplacePhoneRRPLabel.AutoSize = True
        Me.Cla_ReplacePhoneRRPLabel.Location = New System.Drawing.Point(39, 152)
        Me.Cla_ReplacePhoneRRPLabel.Name = "Cla_ReplacePhoneRRPLabel"
        Me.Cla_ReplacePhoneRRPLabel.Size = New System.Drawing.Size(30, 13)
        Me.Cla_ReplacePhoneRRPLabel.TabIndex = 14
        Me.Cla_ReplacePhoneRRPLabel.Text = "RRP"
        '
        'Cla_FreightCostTypeLabel
        '
        Me.Cla_FreightCostTypeLabel.AutoSize = True
        Me.Cla_FreightCostTypeLabel.Location = New System.Drawing.Point(6, 175)
        Me.Cla_FreightCostTypeLabel.Name = "Cla_FreightCostTypeLabel"
        Me.Cla_FreightCostTypeLabel.Size = New System.Drawing.Size(63, 13)
        Me.Cla_FreightCostTypeLabel.TabIndex = 17
        Me.Cla_FreightCostTypeLabel.Text = "Freight Cost"
        '
        'Cla_DoNotOrderLabel
        '
        Me.Cla_DoNotOrderLabel.AutoSize = True
        Me.Cla_DoNotOrderLabel.Location = New System.Drawing.Point(350, 175)
        Me.Cla_DoNotOrderLabel.Name = "Cla_DoNotOrderLabel"
        Me.Cla_DoNotOrderLabel.Size = New System.Drawing.Size(70, 13)
        Me.Cla_DoNotOrderLabel.TabIndex = 20
        Me.Cla_DoNotOrderLabel.Text = "Do Not Order"
        '
        'OUseSupplierLabel
        '
        Me.OUseSupplierLabel.AutoSize = True
        Me.OUseSupplierLabel.Location = New System.Drawing.Point(32, 208)
        Me.OUseSupplierLabel.Name = "OUseSupplierLabel"
        Me.OUseSupplierLabel.Size = New System.Drawing.Size(94, 13)
        Me.OUseSupplierLabel.TabIndex = 22
        Me.OUseSupplierLabel.Text = "Use other Supplier"
        '
        'OSupplierNameLabel
        '
        Me.OSupplierNameLabel.AutoSize = True
        Me.OSupplierNameLabel.Location = New System.Drawing.Point(32, 230)
        Me.OSupplierNameLabel.Name = "OSupplierNameLabel"
        Me.OSupplierNameLabel.Size = New System.Drawing.Size(76, 13)
        Me.OSupplierNameLabel.TabIndex = 24
        Me.OSupplierNameLabel.Text = "Supplier Name"
        '
        'OPhoneLabel
        '
        Me.OPhoneLabel.AutoSize = True
        Me.OPhoneLabel.Location = New System.Drawing.Point(32, 256)
        Me.OPhoneLabel.Name = "OPhoneLabel"
        Me.OPhoneLabel.Size = New System.Drawing.Size(104, 13)
        Me.OPhoneLabel.TabIndex = 26
        Me.OPhoneLabel.Text = "Replacement Phone"
        '
        'SimCardFlagLabel
        '
        Me.SimCardFlagLabel.AutoSize = True
        Me.SimCardFlagLabel.Location = New System.Drawing.Point(5, 14)
        Me.SimCardFlagLabel.Name = "SimCardFlagLabel"
        Me.SimCardFlagLabel.Size = New System.Drawing.Size(135, 13)
        Me.SimCardFlagLabel.TabIndex = 29
        Me.SimCardFlagLabel.Text = "Do you require a SIMCard?"
        Me.SimCardFlagLabel.Visible = False
        '
        'Cla_SimCardPreviousFlagLabel
        '
        Me.Cla_SimCardPreviousFlagLabel.AutoSize = True
        Me.Cla_SimCardPreviousFlagLabel.Location = New System.Drawing.Point(19, 38)
        Me.Cla_SimCardPreviousFlagLabel.MaximumSize = New System.Drawing.Size(120, 30)
        Me.Cla_SimCardPreviousFlagLabel.Name = "Cla_SimCardPreviousFlagLabel"
        Me.Cla_SimCardPreviousFlagLabel.Size = New System.Drawing.Size(118, 30)
        Me.Cla_SimCardPreviousFlagLabel.TabIndex = 31
        Me.Cla_SimCardPreviousFlagLabel.Text = "Have you already received a replacement SIMCard?"
        Me.Cla_SimCardPreviousFlagLabel.Visible = False
        '
        'Cla_SimCardTypeLabel
        '
        Me.Cla_SimCardTypeLabel.AutoSize = True
        Me.Cla_SimCardTypeLabel.Location = New System.Drawing.Point(7, 8)
        Me.Cla_SimCardTypeLabel.Name = "Cla_SimCardTypeLabel"
        Me.Cla_SimCardTypeLabel.Size = New System.Drawing.Size(114, 13)
        Me.Cla_SimCardTypeLabel.TabIndex = 32
        Me.Cla_SimCardTypeLabel.Text = "Replacement SIMCard"
        '
        'Cla_ReplaceSIMCard_sup_idLabel
        '
        Me.Cla_ReplaceSIMCard_sup_idLabel.AutoSize = True
        Me.Cla_ReplaceSIMCard_sup_idLabel.Location = New System.Drawing.Point(56, 38)
        Me.Cla_ReplaceSIMCard_sup_idLabel.Name = "Cla_ReplaceSIMCard_sup_idLabel"
        Me.Cla_ReplaceSIMCard_sup_idLabel.Size = New System.Drawing.Size(66, 13)
        Me.Cla_ReplaceSIMCard_sup_idLabel.TabIndex = 34
        Me.Cla_ReplaceSIMCard_sup_idLabel.Text = "Supp/Model"
        '
        'SimcardCostLabel
        '
        Me.SimcardCostLabel.AutoSize = True
        Me.SimcardCostLabel.Location = New System.Drawing.Point(93, 63)
        Me.SimcardCostLabel.Name = "SimcardCostLabel"
        Me.SimcardCostLabel.Size = New System.Drawing.Size(28, 13)
        Me.SimcardCostLabel.TabIndex = 36
        Me.SimcardCostLabel.Text = "Cost"
        '
        'AccOtherDescrLabel
        '
        Me.AccOtherDescrLabel.AutoSize = True
        Me.AccOtherDescrLabel.Location = New System.Drawing.Point(24, 13)
        Me.AccOtherDescrLabel.Name = "AccOtherDescrLabel"
        Me.AccOtherDescrLabel.Size = New System.Drawing.Size(112, 13)
        Me.AccOtherDescrLabel.TabIndex = 38
        Me.AccOtherDescrLabel.Text = "Accessory Description"
        '
        'Cla_AccProductCodeLabel
        '
        Me.Cla_AccProductCodeLabel.AutoSize = True
        Me.Cla_AccProductCodeLabel.Location = New System.Drawing.Point(64, 39)
        Me.Cla_AccProductCodeLabel.Name = "Cla_AccProductCodeLabel"
        Me.Cla_AccProductCodeLabel.Size = New System.Drawing.Size(72, 13)
        Me.Cla_AccProductCodeLabel.TabIndex = 39
        Me.Cla_AccProductCodeLabel.Text = "Product Code"
        '
        'AccLeatherCaseLabel
        '
        Me.AccLeatherCaseLabel.AutoSize = True
        Me.AccLeatherCaseLabel.Location = New System.Drawing.Point(56, 65)
        Me.AccLeatherCaseLabel.Name = "AccLeatherCaseLabel"
        Me.AccLeatherCaseLabel.Size = New System.Drawing.Size(80, 13)
        Me.AccLeatherCaseLabel.TabIndex = 41
        Me.AccLeatherCaseLabel.Text = "Accessory Cost"
        '
        'RepairerLabel
        '
        Me.RepairerLabel.AutoSize = True
        Me.RepairerLabel.Location = New System.Drawing.Point(93, 9)
        Me.RepairerLabel.Name = "RepairerLabel"
        Me.RepairerLabel.Size = New System.Drawing.Size(47, 13)
        Me.RepairerLabel.TabIndex = 0
        Me.RepairerLabel.Text = "Repairer"
        '
        'Cla_RepairerJobNoLabel
        '
        Me.Cla_RepairerJobNoLabel.AutoSize = True
        Me.Cla_RepairerJobNoLabel.Location = New System.Drawing.Point(99, 42)
        Me.Cla_RepairerJobNoLabel.Name = "Cla_RepairerJobNoLabel"
        Me.Cla_RepairerJobNoLabel.Size = New System.Drawing.Size(41, 13)
        Me.Cla_RepairerJobNoLabel.TabIndex = 2
        Me.Cla_RepairerJobNoLabel.Text = "Job No"
        '
        'RepairCostLabel
        '
        Me.RepairCostLabel.AutoSize = True
        Me.RepairCostLabel.Location = New System.Drawing.Point(78, 73)
        Me.RepairCostLabel.Name = "RepairCostLabel"
        Me.RepairCostLabel.Size = New System.Drawing.Size(62, 13)
        Me.RepairCostLabel.TabIndex = 4
        Me.RepairCostLabel.Text = "Repair Cost"
        '
        'UnauthorisedCallsLabel
        '
        Me.UnauthorisedCallsLabel.AutoSize = True
        Me.UnauthorisedCallsLabel.Location = New System.Drawing.Point(45, 7)
        Me.UnauthorisedCallsLabel.Name = "UnauthorisedCallsLabel"
        Me.UnauthorisedCallsLabel.Size = New System.Drawing.Size(95, 13)
        Me.UnauthorisedCallsLabel.TabIndex = 0
        Me.UnauthorisedCallsLabel.Text = "Unauthorised Calls"
        '
        'Cla_ShortfallUpgradeCostLabel
        '
        Me.Cla_ShortfallUpgradeCostLabel.AutoSize = True
        Me.Cla_ShortfallUpgradeCostLabel.Location = New System.Drawing.Point(63, 44)
        Me.Cla_ShortfallUpgradeCostLabel.Name = "Cla_ShortfallUpgradeCostLabel"
        Me.Cla_ShortfallUpgradeCostLabel.Size = New System.Drawing.Size(69, 13)
        Me.Cla_ShortfallUpgradeCostLabel.TabIndex = 2
        Me.Cla_ShortfallUpgradeCostLabel.Text = "Upgrade Amt"
        '
        'ExcessLabel
        '
        Me.ExcessLabel.AutoSize = True
        Me.ExcessLabel.Location = New System.Drawing.Point(99, 73)
        Me.ExcessLabel.Name = "ExcessLabel"
        Me.ExcessLabel.Size = New System.Drawing.Size(41, 13)
        Me.ExcessLabel.TabIndex = 4
        Me.ExcessLabel.Text = "Excess"
        '
        'CashSettleAmountLabel
        '
        Me.CashSettleAmountLabel.AutoSize = True
        Me.CashSettleAmountLabel.Location = New System.Drawing.Point(8, 109)
        Me.CashSettleAmountLabel.Name = "CashSettleAmountLabel"
        Me.CashSettleAmountLabel.Size = New System.Drawing.Size(192, 13)
        Me.CashSettleAmountLabel.TabIndex = 6
        Me.CashSettleAmountLabel.Text = "Cash Settle OR Other Supplier Amount:"
        '
        'Cla_RepairConsignmentNoLabel
        '
        Me.Cla_RepairConsignmentNoLabel.AutoSize = True
        Me.Cla_RepairConsignmentNoLabel.Location = New System.Drawing.Point(78, 14)
        Me.Cla_RepairConsignmentNoLabel.Name = "Cla_RepairConsignmentNoLabel"
        Me.Cla_RepairConsignmentNoLabel.Size = New System.Drawing.Size(62, 13)
        Me.Cla_RepairConsignmentNoLabel.TabIndex = 9
        Me.Cla_RepairConsignmentNoLabel.Text = "Consign No"
        '
        'Cla_SimCardNumberLabel
        '
        Me.Cla_SimCardNumberLabel.AutoSize = True
        Me.Cla_SimCardNumberLabel.Location = New System.Drawing.Point(51, 44)
        Me.Cla_SimCardNumberLabel.Name = "Cla_SimCardNumberLabel"
        Me.Cla_SimCardNumberLabel.Size = New System.Drawing.Size(89, 13)
        Me.Cla_SimCardNumberLabel.TabIndex = 11
        Me.Cla_SimCardNumberLabel.Text = "Sim Card Number"
        '
        'NewIMEINumberLabel
        '
        Me.NewIMEINumberLabel.AutoSize = True
        Me.NewIMEINumberLabel.Location = New System.Drawing.Point(46, 13)
        Me.NewIMEINumberLabel.Name = "NewIMEINumberLabel"
        Me.NewIMEINumberLabel.Size = New System.Drawing.Size(94, 13)
        Me.NewIMEINumberLabel.TabIndex = 13
        Me.NewIMEINumberLabel.Text = "New IMEI Number"
        '
        'LetterRec_IMEILabel
        '
        Me.LetterRec_IMEILabel.AutoSize = True
        Me.LetterRec_IMEILabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetterRec_IMEILabel.ForeColor = System.Drawing.Color.Blue
        Me.LetterRec_IMEILabel.Location = New System.Drawing.Point(729, 258)
        Me.LetterRec_IMEILabel.Name = "LetterRec_IMEILabel"
        Me.LetterRec_IMEILabel.Size = New System.Drawing.Size(70, 13)
        Me.LetterRec_IMEILabel.TabIndex = 32
        Me.LetterRec_IMEILabel.Text = "IMEI Letter"
        '
        'LetterRec_DamagedLabel
        '
        Me.LetterRec_DamagedLabel.AutoSize = True
        Me.LetterRec_DamagedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetterRec_DamagedLabel.ForeColor = System.Drawing.Color.Blue
        Me.LetterRec_DamagedLabel.Location = New System.Drawing.Point(729, 284)
        Me.LetterRec_DamagedLabel.Name = "LetterRec_DamagedLabel"
        Me.LetterRec_DamagedLabel.Size = New System.Drawing.Size(97, 13)
        Me.LetterRec_DamagedLabel.TabIndex = 33
        Me.LetterRec_DamagedLabel.Text = "Damaged Letter"
        '
        'ExcessLabel1
        '
        Me.ExcessLabel1.AutoSize = True
        Me.ExcessLabel1.Location = New System.Drawing.Point(11, 16)
        Me.ExcessLabel1.Name = "ExcessLabel1"
        Me.ExcessLabel1.Size = New System.Drawing.Size(41, 13)
        Me.ExcessLabel1.TabIndex = 0
        Me.ExcessLabel1.Text = "Excess"
        '
        'GSTLabel
        '
        Me.GSTLabel.AutoSize = True
        Me.GSTLabel.Location = New System.Drawing.Point(191, 42)
        Me.GSTLabel.Name = "GSTLabel"
        Me.GSTLabel.Size = New System.Drawing.Size(50, 13)
        Me.GSTLabel.TabIndex = 4
        Me.GSTLabel.Text = "less GST"
        '
        'TotalClaimCostLabel
        '
        Me.TotalClaimCostLabel.AutoSize = True
        Me.TotalClaimCostLabel.Location = New System.Drawing.Point(518, 42)
        Me.TotalClaimCostLabel.Name = "TotalClaimCostLabel"
        Me.TotalClaimCostLabel.Size = New System.Drawing.Size(112, 13)
        Me.TotalClaimCostLabel.TabIndex = 12
        Me.TotalClaimCostLabel.Text = "Total Cost less excess"
        '
        'TotalCostLessGSTLabel
        '
        Me.TotalCostLessGSTLabel.AutoSize = True
        Me.TotalCostLessGSTLabel.Location = New System.Drawing.Point(518, 69)
        Me.TotalCostLessGSTLabel.Name = "TotalCostLessGSTLabel"
        Me.TotalCostLessGSTLabel.Size = New System.Drawing.Size(146, 13)
        Me.TotalCostLessGSTLabel.TabIndex = 14
        Me.TotalCostLessGSTLabel.Text = "Total Cost less excess && GST"
        '
        'ReplaceVarianceCostLabel
        '
        Me.ReplaceVarianceCostLabel.AutoSize = True
        Me.ReplaceVarianceCostLabel.Location = New System.Drawing.Point(807, 42)
        Me.ReplaceVarianceCostLabel.Name = "ReplaceVarianceCostLabel"
        Me.ReplaceVarianceCostLabel.Size = New System.Drawing.Size(88, 13)
        Me.ReplaceVarianceCostLabel.TabIndex = 16
        Me.ReplaceVarianceCostLabel.Text = "Variance Amount"
        '
        'CCNameLabel
        '
        Me.CCNameLabel.AutoSize = True
        Me.CCNameLabel.Location = New System.Drawing.Point(46, 15)
        Me.CCNameLabel.Name = "CCNameLabel"
        Me.CCNameLabel.Size = New System.Drawing.Size(78, 13)
        Me.CCNameLabel.TabIndex = 18
        Me.CCNameLabel.Text = "Account Name"
        '
        'CCNumberLabel
        '
        Me.CCNumberLabel.AutoSize = True
        Me.CCNumberLabel.Location = New System.Drawing.Point(25, 41)
        Me.CCNumberLabel.Name = "CCNumberLabel"
        Me.CCNumberLabel.Size = New System.Drawing.Size(99, 13)
        Me.CCNumberLabel.TabIndex = 20
        Me.CCNumberLabel.Text = "Credit Card Number"
        '
        'Cla_CCDateEnteredLabel
        '
        Me.Cla_CCDateEnteredLabel.AutoSize = True
        Me.Cla_CCDateEnteredLabel.Location = New System.Drawing.Point(54, 68)
        Me.Cla_CCDateEnteredLabel.Name = "Cla_CCDateEnteredLabel"
        Me.Cla_CCDateEnteredLabel.Size = New System.Drawing.Size(70, 13)
        Me.Cla_CCDateEnteredLabel.TabIndex = 22
        Me.Cla_CCDateEnteredLabel.Text = "Date Entered"
        '
        'Cla_RepairReceiptNoLabel
        '
        Me.Cla_RepairReceiptNoLabel.AutoSize = True
        Me.Cla_RepairReceiptNoLabel.Location = New System.Drawing.Point(8, 93)
        Me.Cla_RepairReceiptNoLabel.Name = "Cla_RepairReceiptNoLabel"
        Me.Cla_RepairReceiptNoLabel.Size = New System.Drawing.Size(116, 13)
        Me.Cla_RepairReceiptNoLabel.TabIndex = 24
        Me.Cla_RepairReceiptNoLabel.Text = "Receipt No/Bpay Date"
        '
        'CCExpiryMonthYearLabel
        '
        Me.CCExpiryMonthYearLabel.AutoSize = True
        Me.CCExpiryMonthYearLabel.Location = New System.Drawing.Point(284, 41)
        Me.CCExpiryMonthYearLabel.Name = "CCExpiryMonthYearLabel"
        Me.CCExpiryMonthYearLabel.Size = New System.Drawing.Size(68, 13)
        Me.CCExpiryMonthYearLabel.TabIndex = 26
        Me.CCExpiryMonthYearLabel.Text = "Expiry Month"
        '
        'Cla_CCAmountLabel
        '
        Me.Cla_CCAmountLabel.AutoSize = True
        Me.Cla_CCAmountLabel.Location = New System.Drawing.Point(309, 68)
        Me.Cla_CCAmountLabel.Name = "Cla_CCAmountLabel"
        Me.Cla_CCAmountLabel.Size = New System.Drawing.Size(43, 13)
        Me.Cla_CCAmountLabel.TabIndex = 26
        Me.Cla_CCAmountLabel.Text = "Amount"
        '
        'CCExpiryYearLabel
        '
        Me.CCExpiryYearLabel.AutoSize = True
        Me.CCExpiryYearLabel.Location = New System.Drawing.Point(441, 41)
        Me.CCExpiryYearLabel.Name = "CCExpiryYearLabel"
        Me.CCExpiryYearLabel.Size = New System.Drawing.Size(29, 13)
        Me.CCExpiryYearLabel.TabIndex = 26
        Me.CCExpiryYearLabel.Text = "Year"
        '
        'Cla_BPayRequiredLabel
        '
        Me.Cla_BPayRequiredLabel.AutoSize = True
        Me.Cla_BPayRequiredLabel.Location = New System.Drawing.Point(723, 19)
        Me.Cla_BPayRequiredLabel.Name = "Cla_BPayRequiredLabel"
        Me.Cla_BPayRequiredLabel.Size = New System.Drawing.Size(78, 13)
        Me.Cla_BPayRequiredLabel.TabIndex = 27
        Me.Cla_BPayRequiredLabel.Text = "BPay Required"
        '
        'Cla_BPayNumberLabel
        '
        Me.Cla_BPayNumberLabel.AutoSize = True
        Me.Cla_BPayNumberLabel.Location = New System.Drawing.Point(723, 64)
        Me.Cla_BPayNumberLabel.Name = "Cla_BPayNumberLabel"
        Me.Cla_BPayNumberLabel.Size = New System.Drawing.Size(72, 13)
        Me.Cla_BPayNumberLabel.TabIndex = 29
        Me.Cla_BPayNumberLabel.Text = "BPay Number"
        '
        'Cla_PhoneAccessoriesPaidTo2Label
        '
        Me.Cla_PhoneAccessoriesPaidTo2Label.AutoSize = True
        Me.Cla_PhoneAccessoriesPaidTo2Label.Location = New System.Drawing.Point(11, 59)
        Me.Cla_PhoneAccessoriesPaidTo2Label.Name = "Cla_PhoneAccessoriesPaidTo2Label"
        Me.Cla_PhoneAccessoriesPaidTo2Label.Size = New System.Drawing.Size(87, 13)
        Me.Cla_PhoneAccessoriesPaidTo2Label.TabIndex = 0
        Me.Cla_PhoneAccessoriesPaidTo2Label.Text = "Phone/Access 2"
        '
        'Cla_PhoneAccessoriesPaidTo3Label
        '
        Me.Cla_PhoneAccessoriesPaidTo3Label.AutoSize = True
        Me.Cla_PhoneAccessoriesPaidTo3Label.Location = New System.Drawing.Point(11, 88)
        Me.Cla_PhoneAccessoriesPaidTo3Label.Name = "Cla_PhoneAccessoriesPaidTo3Label"
        Me.Cla_PhoneAccessoriesPaidTo3Label.Size = New System.Drawing.Size(87, 13)
        Me.Cla_PhoneAccessoriesPaidTo3Label.TabIndex = 2
        Me.Cla_PhoneAccessoriesPaidTo3Label.Text = "Phone/Access 3"
        '
        'Cla_PhoneAccessoriesPaidTo4Label
        '
        Me.Cla_PhoneAccessoriesPaidTo4Label.AutoSize = True
        Me.Cla_PhoneAccessoriesPaidTo4Label.Location = New System.Drawing.Point(11, 116)
        Me.Cla_PhoneAccessoriesPaidTo4Label.Name = "Cla_PhoneAccessoriesPaidTo4Label"
        Me.Cla_PhoneAccessoriesPaidTo4Label.Size = New System.Drawing.Size(87, 13)
        Me.Cla_PhoneAccessoriesPaidTo4Label.TabIndex = 4
        Me.Cla_PhoneAccessoriesPaidTo4Label.Text = "Phone/Access 4"
        '
        'Cla_PhoneAccessoriesPaidToLabel
        '
        Me.Cla_PhoneAccessoriesPaidToLabel.AutoSize = True
        Me.Cla_PhoneAccessoriesPaidToLabel.Location = New System.Drawing.Point(11, 30)
        Me.Cla_PhoneAccessoriesPaidToLabel.Name = "Cla_PhoneAccessoriesPaidToLabel"
        Me.Cla_PhoneAccessoriesPaidToLabel.Size = New System.Drawing.Size(87, 13)
        Me.Cla_PhoneAccessoriesPaidToLabel.TabIndex = 6
        Me.Cla_PhoneAccessoriesPaidToLabel.Text = "Phone/Access 1"
        '
        'Cla_SimCardPaidToLabel
        '
        Me.Cla_SimCardPaidToLabel.AutoSize = True
        Me.Cla_SimCardPaidToLabel.Location = New System.Drawing.Point(4, 144)
        Me.Cla_SimCardPaidToLabel.Name = "Cla_SimCardPaidToLabel"
        Me.Cla_SimCardPaidToLabel.Size = New System.Drawing.Size(99, 13)
        Me.Cla_SimCardPaidToLabel.TabIndex = 8
        Me.Cla_SimCardPaidToLabel.Text = "Sim Card / Salvage"
        '
        'Cla_RepairerPaidToLabel
        '
        Me.Cla_RepairerPaidToLabel.AutoSize = True
        Me.Cla_RepairerPaidToLabel.Location = New System.Drawing.Point(13, 173)
        Me.Cla_RepairerPaidToLabel.Name = "Cla_RepairerPaidToLabel"
        Me.Cla_RepairerPaidToLabel.Size = New System.Drawing.Size(47, 13)
        Me.Cla_RepairerPaidToLabel.TabIndex = 10
        Me.Cla_RepairerPaidToLabel.Text = "Repairer"
        '
        'Cla_OtherPaidToLabel
        '
        Me.Cla_OtherPaidToLabel.AutoSize = True
        Me.Cla_OtherPaidToLabel.Location = New System.Drawing.Point(13, 204)
        Me.Cla_OtherPaidToLabel.Name = "Cla_OtherPaidToLabel"
        Me.Cla_OtherPaidToLabel.Size = New System.Drawing.Size(72, 13)
        Me.Cla_OtherPaidToLabel.TabIndex = 12
        Me.Cla_OtherPaidToLabel.Text = "Excess/Other"
        '
        'Cla_PaidFullLabel
        '
        Me.Cla_PaidFullLabel.AutoSize = True
        Me.Cla_PaidFullLabel.Location = New System.Drawing.Point(18, 241)
        Me.Cla_PaidFullLabel.Name = "Cla_PaidFullLabel"
        Me.Cla_PaidFullLabel.Size = New System.Drawing.Size(57, 13)
        Me.Cla_PaidFullLabel.TabIndex = 14
        Me.Cla_PaidFullLabel.Text = "Partial/Full"
        '
        'Cla_RepairerPaidTo2Label
        '
        Me.Cla_RepairerPaidTo2Label.AutoSize = True
        Me.Cla_RepairerPaidTo2Label.Location = New System.Drawing.Point(518, 173)
        Me.Cla_RepairerPaidTo2Label.Name = "Cla_RepairerPaidTo2Label"
        Me.Cla_RepairerPaidTo2Label.Size = New System.Drawing.Size(62, 13)
        Me.Cla_RepairerPaidTo2Label.TabIndex = 56
        Me.Cla_RepairerPaidTo2Label.Text = "Repairer (2)"
        '
        'Cla_OtherPaidTo2Label
        '
        Me.Cla_OtherPaidTo2Label.AutoSize = True
        Me.Cla_OtherPaidTo2Label.Location = New System.Drawing.Point(518, 204)
        Me.Cla_OtherPaidTo2Label.Name = "Cla_OtherPaidTo2Label"
        Me.Cla_OtherPaidTo2Label.Size = New System.Drawing.Size(87, 13)
        Me.Cla_OtherPaidTo2Label.TabIndex = 57
        Me.Cla_OtherPaidTo2Label.Text = "Excess/Other (2)"
        '
        'Cla_OutstandingAmountLabel
        '
        Me.Cla_OutstandingAmountLabel.AutoSize = True
        Me.Cla_OutstandingAmountLabel.Location = New System.Drawing.Point(863, 256)
        Me.Cla_OutstandingAmountLabel.Name = "Cla_OutstandingAmountLabel"
        Me.Cla_OutstandingAmountLabel.Size = New System.Drawing.Size(85, 13)
        Me.Cla_OutstandingAmountLabel.TabIndex = 64
        Me.Cla_OutstandingAmountLabel.Text = "Outstanding Amt"
        '
        'ReplaceCostLabel1
        '
        Me.ReplaceCostLabel1.AutoSize = True
        Me.ReplaceCostLabel1.Location = New System.Drawing.Point(1005, 19)
        Me.ReplaceCostLabel1.Name = "ReplaceCostLabel1"
        Me.ReplaceCostLabel1.Size = New System.Drawing.Size(68, 13)
        Me.ReplaceCostLabel1.TabIndex = 27
        Me.ReplaceCostLabel1.Text = "ReplaceCost"
        '
        'FreightCostLabel
        '
        Me.FreightCostLabel.AutoSize = True
        Me.FreightCostLabel.Location = New System.Drawing.Point(1013, 45)
        Me.FreightCostLabel.Name = "FreightCostLabel"
        Me.FreightCostLabel.Size = New System.Drawing.Size(60, 13)
        Me.FreightCostLabel.TabIndex = 28
        Me.FreightCostLabel.Text = "FreightCost"
        '
        'AccLeatherCaseLabel1
        '
        Me.AccLeatherCaseLabel1.AutoSize = True
        Me.AccLeatherCaseLabel1.Location = New System.Drawing.Point(987, 71)
        Me.AccLeatherCaseLabel1.Name = "AccLeatherCaseLabel1"
        Me.AccLeatherCaseLabel1.Size = New System.Drawing.Size(86, 13)
        Me.AccLeatherCaseLabel1.TabIndex = 29
        Me.AccLeatherCaseLabel1.Text = "AccLeatherCase"
        '
        'SimcardCostLabel1
        '
        Me.SimcardCostLabel1.AutoSize = True
        Me.SimcardCostLabel1.Location = New System.Drawing.Point(1007, 97)
        Me.SimcardCostLabel1.Name = "SimcardCostLabel1"
        Me.SimcardCostLabel1.Size = New System.Drawing.Size(66, 13)
        Me.SimcardCostLabel1.TabIndex = 30
        Me.SimcardCostLabel1.Text = "SimcardCost"
        '
        'ReplaceCostLabel2
        '
        Me.ReplaceCostLabel2.AutoSize = True
        Me.ReplaceCostLabel2.Location = New System.Drawing.Point(1011, 123)
        Me.ReplaceCostLabel2.Name = "ReplaceCostLabel2"
        Me.ReplaceCostLabel2.Size = New System.Drawing.Size(62, 13)
        Me.ReplaceCostLabel2.TabIndex = 31
        Me.ReplaceCostLabel2.Text = "Repair Cost"
        '
        'UnauthorisedCallsLabel1
        '
        Me.UnauthorisedCallsLabel1.AutoSize = True
        Me.UnauthorisedCallsLabel1.Location = New System.Drawing.Point(978, 148)
        Me.UnauthorisedCallsLabel1.Name = "UnauthorisedCallsLabel1"
        Me.UnauthorisedCallsLabel1.Size = New System.Drawing.Size(95, 13)
        Me.UnauthorisedCallsLabel1.TabIndex = 32
        Me.UnauthorisedCallsLabel1.Text = "Unauthorised Calls"
        '
        'Cla_ShortfallUpgradeCostLabel1
        '
        Me.Cla_ShortfallUpgradeCostLabel1.AutoSize = True
        Me.Cla_ShortfallUpgradeCostLabel1.Location = New System.Drawing.Point(961, 174)
        Me.Cla_ShortfallUpgradeCostLabel1.Name = "Cla_ShortfallUpgradeCostLabel1"
        Me.Cla_ShortfallUpgradeCostLabel1.Size = New System.Drawing.Size(112, 13)
        Me.Cla_ShortfallUpgradeCostLabel1.TabIndex = 33
        Me.Cla_ShortfallUpgradeCostLabel1.Text = "Shortfall/Upgrade Amt"
        '
        'ReplaceVarianceCostLabel1
        '
        Me.ReplaceVarianceCostLabel1.AutoSize = True
        Me.ReplaceVarianceCostLabel1.Location = New System.Drawing.Point(985, 199)
        Me.ReplaceVarianceCostLabel1.Name = "ReplaceVarianceCostLabel1"
        Me.ReplaceVarianceCostLabel1.Size = New System.Drawing.Size(88, 13)
        Me.ReplaceVarianceCostLabel1.TabIndex = 34
        Me.ReplaceVarianceCostLabel1.Text = "Variance Amount"
        '
        'AccOtherLabel
        '
        Me.AccOtherLabel.AutoSize = True
        Me.AccOtherLabel.Location = New System.Drawing.Point(1021, 225)
        Me.AccOtherLabel.Name = "AccOtherLabel"
        Me.AccOtherLabel.Size = New System.Drawing.Size(52, 13)
        Me.AccOtherLabel.TabIndex = 35
        Me.AccOtherLabel.Text = "AccOther"
        '
        'CashSettleAmountLabel1
        '
        Me.CashSettleAmountLabel1.AutoSize = True
        Me.CashSettleAmountLabel1.Location = New System.Drawing.Point(979, 251)
        Me.CashSettleAmountLabel1.Name = "CashSettleAmountLabel1"
        Me.CashSettleAmountLabel1.Size = New System.Drawing.Size(94, 13)
        Me.CashSettleAmountLabel1.TabIndex = 36
        Me.CashSettleAmountLabel1.Text = "CashSettleAmount"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(643, 154)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(44, 13)
        Me.Label55.TabIndex = 74
        Me.Label55.Text = "Paid To"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(756, 152)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(54, 13)
        Me.Label56.TabIndex = 75
        Me.Label56.Text = "Paid Date"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(960, 152)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(43, 13)
        Me.Label57.TabIndex = 77
        Me.Label57.Text = "Amount"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(863, 149)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(47, 13)
        Me.Label58.TabIndex = 76
        Me.Label58.Text = "Invoices"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(454, 7)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(43, 13)
        Me.Label59.TabIndex = 81
        Me.Label59.Text = "Amount"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(350, 7)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(47, 13)
        Me.Label60.TabIndex = 80
        Me.Label60.Text = "Invoices"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(248, 7)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(54, 13)
        Me.Label61.TabIndex = 79
        Me.Label61.Text = "Paid Date"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(135, 7)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(44, 13)
        Me.Label62.TabIndex = 78
        Me.Label62.Text = "Paid To"
        '
        'LetterRec_IPhoneDamageLabel
        '
        Me.LetterRec_IPhoneDamageLabel.AutoSize = True
        Me.LetterRec_IPhoneDamageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LetterRec_IPhoneDamageLabel.ForeColor = System.Drawing.Color.Blue
        Me.LetterRec_IPhoneDamageLabel.Location = New System.Drawing.Point(730, 235)
        Me.LetterRec_IPhoneDamageLabel.Name = "LetterRec_IPhoneDamageLabel"
        Me.LetterRec_IPhoneDamageLabel.Size = New System.Drawing.Size(83, 13)
        Me.LetterRec_IPhoneDamageLabel.TabIndex = 40
        Me.LetterRec_IPhoneDamageLabel.Text = "Iphone Letter"
        '
        'TblClaimBindingSource
        '
        Me.TblClaimBindingSource.DataSource = GetType(Risk.Claim)
        '
        'RiskDataSet
        '
        Me.RiskDataSet.DataSetName = "RiskDataSet"
        Me.RiskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClaimNumberTextBox
        '
        Me.ClaimNumberTextBox.BackColor = System.Drawing.Color.Black
        Me.ClaimNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "ClaimNumber", True))
        Me.ClaimNumberTextBox.ForeColor = System.Drawing.Color.Yellow
        Me.ClaimNumberTextBox.Location = New System.Drawing.Point(321, 9)
        Me.ClaimNumberTextBox.Name = "ClaimNumberTextBox"
        Me.ClaimNumberTextBox.ReadOnly = True
        Me.ClaimNumberTextBox.Size = New System.Drawing.Size(88, 20)
        Me.ClaimNumberTextBox.TabIndex = 2
        '
        'StatusTextBox
        '
        Me.StatusTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(472, 9)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(91, 20)
        Me.StatusTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 26)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "Mobile Phone Claims"
        '
        'UndockButton
        '
        Me.UndockButton.Location = New System.Drawing.Point(880, -1)
        Me.UndockButton.Name = "UndockButton"
        Me.UndockButton.Size = New System.Drawing.Size(58, 23)
        Me.UndockButton.TabIndex = 372
        Me.UndockButton.Text = "Undock"
        Me.UndockButton.UseVisualStyleBackColor = True
        Me.UndockButton.Visible = False
        '
        'LodgedDateTextBox
        '
        Me.LodgedDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LodgedDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sLodgedDate", True))
        Me.LodgedDateTextBox.Location = New System.Drawing.Point(658, 9)
        Me.LodgedDateTextBox.Name = "LodgedDateTextBox"
        Me.LodgedDateTextBox.ReadOnly = True
        Me.LodgedDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LodgedDateTextBox.TabIndex = 373
        '
        'ClaimDetailsTabControl
        '
        Me.ClaimDetailsTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClaimDetailsTabControl.Controls.Add(Me.ClaimantDetailsTabPage)
        Me.ClaimDetailsTabControl.Controls.Add(Me.ClaimDetailsTabPage)
        Me.ClaimDetailsTabControl.Controls.Add(Me.SettlementDetailsTabPage)
        Me.ClaimDetailsTabControl.Controls.Add(Me.DeclarationAndNotesTabPage)
        Me.ClaimDetailsTabControl.Controls.Add(Me.PaymentsTabPage)
        Me.ClaimDetailsTabControl.Controls.Add(Me.AuditTabPage)
        Me.ClaimDetailsTabControl.Location = New System.Drawing.Point(8, 60)
        Me.ClaimDetailsTabControl.Name = "ClaimDetailsTabControl"
        Me.ClaimDetailsTabControl.SelectedIndex = 0
        Me.ClaimDetailsTabControl.Size = New System.Drawing.Size(1113, 670)
        Me.ClaimDetailsTabControl.TabIndex = 374
        '
        'ClaimantDetailsTabPage
        '
        Me.ClaimantDetailsTabPage.AutoScroll = True
        Me.ClaimantDetailsTabPage.AutoScrollMargin = New System.Drawing.Size(20, 20)
        Me.ClaimantDetailsTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.ClaimantDetailsTabPage.Controls.Add(Me.Label3)
        Me.ClaimantDetailsTabPage.Controls.Add(Me.Panel2)
        Me.ClaimantDetailsTabPage.Controls.Add(Me.Panel1)
        Me.ClaimantDetailsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ClaimantDetailsTabPage.Margin = New System.Windows.Forms.Padding(0)
        Me.ClaimantDetailsTabPage.Name = "ClaimantDetailsTabPage"
        Me.ClaimantDetailsTabPage.Size = New System.Drawing.Size(1105, 644)
        Me.ClaimantDetailsTabPage.TabIndex = 0
        Me.ClaimantDetailsTabPage.Text = "Claimant Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Account Holder Details"
        '
        'Panel2
        '
        Me.Panel2.AutoScrollMargin = New System.Drawing.Size(10, 10)
        Me.Panel2.Controls.Add(Me.ComboBoxOISstore)
        Me.Panel2.Controls.Add(Me.Cla_TerminalIdLabel)
        Me.Panel2.Controls.Add(Me.Cla_TerminalIdTextBox)
        Me.Panel2.Controls.Add(Me.Cla_PhoneDealerStateLabel)
        Me.Panel2.Controls.Add(Me.Cla_PhoneDealerStateTextBox)
        Me.Panel2.Controls.Add(Me.PhoneDealelPostCodeLabel)
        Me.Panel2.Controls.Add(Me.PhoneDealelPostCodeTextBox)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.SuburbMultiColumnCombo)
        Me.Panel2.Controls.Add(Me.Cla_LodgerAccountHolderNoEnglishLabel)
        Me.Panel2.Controls.Add(Me.Cla_LodgerAccountHolderNoEnglishCheckBox)
        Me.Panel2.Controls.Add(Me.Cla_LodgerHasAuthorityLabel)
        Me.Panel2.Controls.Add(Me.Cla_LodgerHasAuthorityCheckBox)
        Me.Panel2.Controls.Add(Me.CopyAddressButton)
        Me.Panel2.Controls.Add(Me.PostalSuburbMultiColumnCombo)
        Me.Panel2.Controls.Add(Me.Cla_PostalStateLabel)
        Me.Panel2.Controls.Add(Me.Cla_PostalStateTextBox)
        Me.Panel2.Controls.Add(Me.PostalPostcodeLabel)
        Me.Panel2.Controls.Add(Me.PostalPostcodeTextBox)
        Me.Panel2.Controls.Add(Me.FaxNumberLabel)
        Me.Panel2.Controls.Add(Me.FaxNumberTextBox)
        Me.Panel2.Controls.Add(Me.PostalSuburbLabel)
        Me.Panel2.Controls.Add(Me.PostalAddress2TextBox)
        Me.Panel2.Controls.Add(Me.PostalAddress1Label)
        Me.Panel2.Controls.Add(Me.PostalAddress1TextBox)
        Me.Panel2.Controls.Add(Me.ContactNumber2Label)
        Me.Panel2.Controls.Add(Me.ContactNumber2TextBox)
        Me.Panel2.Controls.Add(Me.ContactNumberLabel)
        Me.Panel2.Controls.Add(Me.ContactNumberTextBox)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.PhoneDealerLabel)
        Me.Panel2.Controls.Add(Me.PhoneDealerTextBox)
        Me.Panel2.Controls.Add(Me.LastPersonFamilyNameLabel)
        Me.Panel2.Controls.Add(Me.LastPersonFamilyNameTextBox)
        Me.Panel2.Controls.Add(Me.LastPersonGivenNameLabel)
        Me.Panel2.Controls.Add(Me.LastPersonGivenNameTextBox)
        Me.Panel2.Controls.Add(Me.Cla_LodgerRelationshipLabel)
        Me.Panel2.Controls.Add(Me.Cla_LodgerRelationshipTextBox)
        Me.Panel2.Controls.Add(Me.Cla_LodgerLastNameLabel)
        Me.Panel2.Controls.Add(Me.Cla_LodgerLastNameTextBox)
        Me.Panel2.Controls.Add(Me.Cla_LodgerFirstNameLabel)
        Me.Panel2.Controls.Add(Me.Cla_LodgerFirstNameTextBox)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.CustomerEmailLabel)
        Me.Panel2.Controls.Add(Me.CustomerEmailTextBox)
        Me.Panel2.Controls.Add(Me.CompanyNameLabel)
        Me.Panel2.Controls.Add(Me.CompanyNameTextBox)
        Me.Panel2.Controls.Add(Me.AccountNumberLabel)
        Me.Panel2.Controls.Add(Me.AccountNumberTextBox)
        Me.Panel2.Controls.Add(Me.FamilyNameLabel)
        Me.Panel2.Controls.Add(Me.FamilyNameTextBox)
        Me.Panel2.Controls.Add(Me.GivenNameLabel)
        Me.Panel2.Controls.Add(Me.GivenNameTextBox)
        Me.Panel2.Controls.Add(Me.TitleLabel)
        Me.Panel2.Controls.Add(Me.TitleComboBox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(19, 245)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(888, 447)
        Me.Panel2.TabIndex = 18
        '
        'ComboBoxOISstore
        '
        Me.ComboBoxOISstore.FormattingEnabled = True
        Me.ComboBoxOISstore.Items.AddRange(New Object() {"", "Yes", "No"})
        Me.ComboBoxOISstore.Location = New System.Drawing.Point(354, 349)
        Me.ComboBoxOISstore.Name = "ComboBoxOISstore"
        Me.ComboBoxOISstore.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxOISstore.TabIndex = 56
        '
        'Cla_TerminalIdTextBox
        '
        Me.Cla_TerminalIdTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_TerminalIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_TerminalId", True))
        Me.Cla_TerminalIdTextBox.Location = New System.Drawing.Point(784, 424)
        Me.Cla_TerminalIdTextBox.Name = "Cla_TerminalIdTextBox"
        Me.Cla_TerminalIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_TerminalIdTextBox.TabIndex = 55
        Me.Cla_TerminalIdTextBox.Visible = False
        '
        'Cla_PhoneDealerStateTextBox
        '
        Me.Cla_PhoneDealerStateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_PhoneDealerStateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PhoneDealerState", True))
        Me.Cla_PhoneDealerStateTextBox.Location = New System.Drawing.Point(657, 424)
        Me.Cla_PhoneDealerStateTextBox.Name = "Cla_PhoneDealerStateTextBox"
        Me.Cla_PhoneDealerStateTextBox.Size = New System.Drawing.Size(53, 20)
        Me.Cla_PhoneDealerStateTextBox.TabIndex = 51
        Me.Cla_PhoneDealerStateTextBox.Visible = False
        '
        'PhoneDealelPostCodeTextBox
        '
        Me.PhoneDealelPostCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PhoneDealelPostCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "PhoneDealelPostCode", True))
        Me.PhoneDealelPostCodeTextBox.Location = New System.Drawing.Point(726, 424)
        Me.PhoneDealelPostCodeTextBox.Name = "PhoneDealelPostCodeTextBox"
        Me.PhoneDealelPostCodeTextBox.Size = New System.Drawing.Size(52, 20)
        Me.PhoneDealelPostCodeTextBox.TabIndex = 53
        Me.PhoneDealelPostCodeTextBox.Visible = False
        '
        'SuburbMultiColumnCombo
        '
        Me.SuburbMultiColumnCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SuburbMultiColumnCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SuburbMultiColumnCombo.ColumnWidths = "300;75;75"
        Me.SuburbMultiColumnCombo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "DealerID", True))
        Me.SuburbMultiColumnCombo.DataSource = Me.PhoneDealer_TPostcodeBindingSource
        Me.SuburbMultiColumnCombo.DisplayMember = "Display"
        Me.SuburbMultiColumnCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SuburbMultiColumnCombo.DropDownWidth = 460
        Me.SuburbMultiColumnCombo.FormattingEnabled = True
        Me.SuburbMultiColumnCombo.Location = New System.Drawing.Point(6, 388)
        Me.SuburbMultiColumnCombo.Name = "SuburbMultiColumnCombo"
        Me.SuburbMultiColumnCombo.Size = New System.Drawing.Size(300, 21)
        Me.SuburbMultiColumnCombo.TabIndex = 48
        Me.SuburbMultiColumnCombo.ValueMember = "sPostCodeID"
        '
        'PhoneDealer_TPostcodeBindingSource
        '
        Me.PhoneDealer_TPostcodeBindingSource.DataSource = GetType(Risk.PostCode)
        '
        'Cla_LodgerAccountHolderNoEnglishCheckBox
        '
        Me.Cla_LodgerAccountHolderNoEnglishCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "cla_LodgerAccountHolderNoEnglish", True))
        Me.Cla_LodgerAccountHolderNoEnglishCheckBox.Location = New System.Drawing.Point(775, 309)
        Me.Cla_LodgerAccountHolderNoEnglishCheckBox.Name = "Cla_LodgerAccountHolderNoEnglishCheckBox"
        Me.Cla_LodgerAccountHolderNoEnglishCheckBox.Size = New System.Drawing.Size(16, 24)
        Me.Cla_LodgerAccountHolderNoEnglishCheckBox.TabIndex = 47
        Me.Cla_LodgerAccountHolderNoEnglishCheckBox.UseVisualStyleBackColor = True
        '
        'Cla_LodgerHasAuthorityCheckBox
        '
        Me.Cla_LodgerHasAuthorityCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "cla_LodgerHasAuthority", True))
        Me.Cla_LodgerHasAuthorityCheckBox.Location = New System.Drawing.Point(535, 309)
        Me.Cla_LodgerHasAuthorityCheckBox.Name = "Cla_LodgerHasAuthorityCheckBox"
        Me.Cla_LodgerHasAuthorityCheckBox.Size = New System.Drawing.Size(21, 24)
        Me.Cla_LodgerHasAuthorityCheckBox.TabIndex = 46
        Me.Cla_LodgerHasAuthorityCheckBox.UseVisualStyleBackColor = True
        '
        'CopyAddressButton
        '
        Me.CopyAddressButton.Location = New System.Drawing.Point(589, 203)
        Me.CopyAddressButton.Name = "CopyAddressButton"
        Me.CopyAddressButton.Size = New System.Drawing.Size(167, 51)
        Me.CopyAddressButton.TabIndex = 45
        Me.CopyAddressButton.Text = "Copy Postal Address >> to 'Claim Details' - Delivery Address"
        Me.CopyAddressButton.UseVisualStyleBackColor = True
        '
        'PostalSuburbMultiColumnCombo
        '
        Me.PostalSuburbMultiColumnCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PostalSuburbMultiColumnCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PostalSuburbMultiColumnCombo.ColumnWidths = "300;75;75"
        Me.PostalSuburbMultiColumnCombo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "PostalID", True))
        Me.PostalSuburbMultiColumnCombo.DataSource = Me.Postal_TPostcodeBindingSource
        Me.PostalSuburbMultiColumnCombo.DisplayMember = "Display"
        Me.PostalSuburbMultiColumnCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.PostalSuburbMultiColumnCombo.DropDownWidth = 460
        Me.PostalSuburbMultiColumnCombo.FormattingEnabled = True
        Me.PostalSuburbMultiColumnCombo.Location = New System.Drawing.Point(554, 114)
        Me.PostalSuburbMultiColumnCombo.Name = "PostalSuburbMultiColumnCombo"
        Me.PostalSuburbMultiColumnCombo.Size = New System.Drawing.Size(300, 21)
        Me.PostalSuburbMultiColumnCombo.TabIndex = 44
        Me.PostalSuburbMultiColumnCombo.ValueMember = "sPostCodeID"
        '
        'Postal_TPostcodeBindingSource
        '
        Me.Postal_TPostcodeBindingSource.DataSource = GetType(Risk.PostCode)
        '
        'Cla_PostalStateTextBox
        '
        Me.Cla_PostalStateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_PostalStateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PostalState", True))
        Me.Cla_PostalStateTextBox.Location = New System.Drawing.Point(704, 166)
        Me.Cla_PostalStateTextBox.Name = "Cla_PostalStateTextBox"
        Me.Cla_PostalStateTextBox.Size = New System.Drawing.Size(65, 20)
        Me.Cla_PostalStateTextBox.TabIndex = 43
        '
        'PostalPostcodeTextBox
        '
        Me.PostalPostcodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PostalPostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "PostalPostcode", True))
        Me.PostalPostcodeTextBox.Location = New System.Drawing.Point(589, 166)
        Me.PostalPostcodeTextBox.Name = "PostalPostcodeTextBox"
        Me.PostalPostcodeTextBox.Size = New System.Drawing.Size(52, 20)
        Me.PostalPostcodeTextBox.TabIndex = 42
        '
        'FaxNumberTextBox
        '
        Me.FaxNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.FaxNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "FaxNumber", True))
        Me.FaxNumberTextBox.Location = New System.Drawing.Point(754, 11)
        Me.FaxNumberTextBox.Name = "FaxNumberTextBox"
        Me.FaxNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FaxNumberTextBox.TabIndex = 41
        '
        'PostalAddress2TextBox
        '
        Me.PostalAddress2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PostalAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "PostalAddress2", True))
        Me.PostalAddress2TextBox.Location = New System.Drawing.Point(554, 89)
        Me.PostalAddress2TextBox.Name = "PostalAddress2TextBox"
        Me.PostalAddress2TextBox.Size = New System.Drawing.Size(172, 20)
        Me.PostalAddress2TextBox.TabIndex = 39
        '
        'PostalAddress1TextBox
        '
        Me.PostalAddress1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PostalAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "PostalAddress1", True))
        Me.PostalAddress1TextBox.Location = New System.Drawing.Point(554, 63)
        Me.PostalAddress1TextBox.Name = "PostalAddress1TextBox"
        Me.PostalAddress1TextBox.Size = New System.Drawing.Size(172, 20)
        Me.PostalAddress1TextBox.TabIndex = 38
        '
        'ContactNumber2TextBox
        '
        Me.ContactNumber2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ContactNumber2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "ContactNumber2", True))
        Me.ContactNumber2TextBox.Location = New System.Drawing.Point(554, 37)
        Me.ContactNumber2TextBox.Name = "ContactNumber2TextBox"
        Me.ContactNumber2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactNumber2TextBox.TabIndex = 37
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(554, 11)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactNumberTextBox.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(342, 15)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Has there been any OIS store involvement in this process?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 270)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 15)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Regular user of the phone."
        '
        'PhoneDealerTextBox
        '
        Me.PhoneDealerTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PhoneDealerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "PhoneDealer", True))
        Me.PhoneDealerTextBox.Location = New System.Drawing.Point(406, 424)
        Me.PhoneDealerTextBox.Name = "PhoneDealerTextBox"
        Me.PhoneDealerTextBox.Size = New System.Drawing.Size(247, 20)
        Me.PhoneDealerTextBox.TabIndex = 33
        Me.PhoneDealerTextBox.Visible = False
        '
        'LastPersonFamilyNameTextBox
        '
        Me.LastPersonFamilyNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LastPersonFamilyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "LastPersonFamilyName", True))
        Me.LastPersonFamilyNameTextBox.Location = New System.Drawing.Point(170, 311)
        Me.LastPersonFamilyNameTextBox.Name = "LastPersonFamilyNameTextBox"
        Me.LastPersonFamilyNameTextBox.Size = New System.Drawing.Size(194, 20)
        Me.LastPersonFamilyNameTextBox.TabIndex = 32
        '
        'LastPersonGivenNameTextBox
        '
        Me.LastPersonGivenNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LastPersonGivenNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "LastPersonGivenName", True))
        Me.LastPersonGivenNameTextBox.Location = New System.Drawing.Point(6, 311)
        Me.LastPersonGivenNameTextBox.Name = "LastPersonGivenNameTextBox"
        Me.LastPersonGivenNameTextBox.Size = New System.Drawing.Size(156, 20)
        Me.LastPersonGivenNameTextBox.TabIndex = 31
        '
        'Cla_LodgerRelationshipTextBox
        '
        Me.Cla_LodgerRelationshipTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_LodgerRelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_LodgerRelationship", True))
        Me.Cla_LodgerRelationshipTextBox.Location = New System.Drawing.Point(3, 238)
        Me.Cla_LodgerRelationshipTextBox.Name = "Cla_LodgerRelationshipTextBox"
        Me.Cla_LodgerRelationshipTextBox.Size = New System.Drawing.Size(322, 20)
        Me.Cla_LodgerRelationshipTextBox.TabIndex = 30
        '
        'Cla_LodgerLastNameTextBox
        '
        Me.Cla_LodgerLastNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_LodgerLastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_LodgerLastName", True))
        Me.Cla_LodgerLastNameTextBox.Location = New System.Drawing.Point(168, 189)
        Me.Cla_LodgerLastNameTextBox.Name = "Cla_LodgerLastNameTextBox"
        Me.Cla_LodgerLastNameTextBox.Size = New System.Drawing.Size(199, 20)
        Me.Cla_LodgerLastNameTextBox.TabIndex = 29
        '
        'Cla_LodgerFirstNameTextBox
        '
        Me.Cla_LodgerFirstNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_LodgerFirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_LodgerFirstName", True))
        Me.Cla_LodgerFirstNameTextBox.Location = New System.Drawing.Point(3, 189)
        Me.Cla_LodgerFirstNameTextBox.Name = "Cla_LodgerFirstNameTextBox"
        Me.Cla_LodgerFirstNameTextBox.Size = New System.Drawing.Size(159, 20)
        Me.Cla_LodgerFirstNameTextBox.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Authorised person / contact point"
        '
        'CustomerEmailTextBox
        '
        Me.CustomerEmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CustomerEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CustomerEmail", True))
        Me.CustomerEmailTextBox.ForeColor = System.Drawing.Color.Blue
        Me.CustomerEmailTextBox.Location = New System.Drawing.Point(88, 114)
        Me.CustomerEmailTextBox.Name = "CustomerEmailTextBox"
        Me.CustomerEmailTextBox.Size = New System.Drawing.Size(364, 20)
        Me.CustomerEmailTextBox.TabIndex = 26
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(88, 89)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(364, 20)
        Me.CompanyNameTextBox.TabIndex = 25
        '
        'AccountNumberTextBox
        '
        Me.AccountNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.AccountNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "AccountNumber", True))
        Me.AccountNumberTextBox.Location = New System.Drawing.Point(88, 63)
        Me.AccountNumberTextBox.Name = "AccountNumberTextBox"
        Me.AccountNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccountNumberTextBox.TabIndex = 24
        '
        'FamilyNameTextBox
        '
        Me.FamilyNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.FamilyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "FamilyName", True))
        Me.FamilyNameTextBox.Location = New System.Drawing.Point(253, 37)
        Me.FamilyNameTextBox.Name = "FamilyNameTextBox"
        Me.FamilyNameTextBox.Size = New System.Drawing.Size(199, 20)
        Me.FamilyNameTextBox.TabIndex = 23
        '
        'GivenNameTextBox
        '
        Me.GivenNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.GivenNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "GivenName", True))
        Me.GivenNameTextBox.Location = New System.Drawing.Point(88, 37)
        Me.GivenNameTextBox.Name = "GivenNameTextBox"
        Me.GivenNameTextBox.Size = New System.Drawing.Size(159, 20)
        Me.GivenNameTextBox.TabIndex = 22
        '
        'TitleComboBox
        '
        Me.TitleComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "Title", True))
        Me.TitleComboBox.FormattingEnabled = True
        Me.TitleComboBox.Items.AddRange(New Object() {"Mr", "Mrs", "Ms", "Miss", "Dr"})
        Me.TitleComboBox.Location = New System.Drawing.Point(3, 37)
        Me.TitleComboBox.Name = "TitleComboBox"
        Me.TitleComboBox.Size = New System.Drawing.Size(79, 21)
        Me.TitleComboBox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(368, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Are you the Account Holder? If no, who is the Account Holder?"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label93)
        Me.Panel1.Controls.Add(Me.PolicyNumberTextBox)
        Me.Panel1.Controls.Add(Me.InsuranceDateTextBox)
        Me.Panel1.Controls.Add(Me.PurchaseDateTextBox)
        Me.Panel1.Controls.Add(Me.Label65)
        Me.Panel1.Controls.Add(Me.WarningNoteTextBox)
        Me.Panel1.Controls.Add(Me.CancelInsuranceFlagLabel)
        Me.Panel1.Controls.Add(Me.CancelInsuranceFlagComboBox)
        Me.Panel1.Controls.Add(Me.CheckClaimMobileNumberButton)
        Me.Panel1.Controls.Add(Me.CheckClaimFamilyNameButton)
        Me.Panel1.Controls.Add(Me.Cla_InsuranceTypeComboBox)
        Me.Panel1.Controls.Add(Me.Cla_InsuranceTypeLabel)
        Me.Panel1.Controls.Add(Me.SchemeIDComboBox)
        Me.Panel1.Controls.Add(Me.SchemeIDLabel)
        Me.Panel1.Controls.Add(Me.IMEINumberTextBox)
        Me.Panel1.Controls.Add(Me.IMEINumberLabel)
        Me.Panel1.Controls.Add(Me.InsuranceDateLabel)
        Me.Panel1.Controls.Add(Me.PurchaseDateLabel)
        Me.Panel1.Controls.Add(Me.MobilePhoneNumberLabel)
        Me.Panel1.Controls.Add(Me.MobilePhoneNumberTextBox)
        Me.Panel1.Location = New System.Drawing.Point(19, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(930, 200)
        Me.Panel1.TabIndex = 17
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(404, 16)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(75, 13)
        Me.Label93.TabIndex = 59
        Me.Label93.Text = "Policy Number"
        '
        'PolicyNumberTextBox
        '
        Me.PolicyNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PolicyNumberTextBox.Location = New System.Drawing.Point(525, 13)
        Me.PolicyNumberTextBox.Name = "PolicyNumberTextBox"
        Me.PolicyNumberTextBox.Size = New System.Drawing.Size(116, 20)
        Me.PolicyNumberTextBox.TabIndex = 60
        '
        'InsuranceDateTextBox
        '
        Me.InsuranceDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.InsuranceDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sInsuranceDate", True))
        Me.InsuranceDateTextBox.Location = New System.Drawing.Point(525, 68)
        Me.InsuranceDateTextBox.Name = "InsuranceDateTextBox"
        Me.InsuranceDateTextBox.Size = New System.Drawing.Size(116, 20)
        Me.InsuranceDateTextBox.TabIndex = 58
        '
        'PurchaseDateTextBox
        '
        Me.PurchaseDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PurchaseDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sPurchaseDate", True))
        Me.PurchaseDateTextBox.Location = New System.Drawing.Point(126, 91)
        Me.PurchaseDateTextBox.Name = "PurchaseDateTextBox"
        Me.PurchaseDateTextBox.Size = New System.Drawing.Size(245, 20)
        Me.PurchaseDateTextBox.TabIndex = 57
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Red
        Me.Label65.Location = New System.Drawing.Point(14, 140)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(118, 20)
        Me.Label65.TabIndex = 56
        Me.Label65.Text = "Warning Note"
        '
        'WarningNoteTextBox
        '
        Me.WarningNoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "WarningNote", True))
        Me.WarningNoteTextBox.Location = New System.Drawing.Point(146, 125)
        Me.WarningNoteTextBox.Multiline = True
        Me.WarningNoteTextBox.Name = "WarningNoteTextBox"
        Me.WarningNoteTextBox.Size = New System.Drawing.Size(738, 65)
        Me.WarningNoteTextBox.TabIndex = 51
        '
        'CancelInsuranceFlagComboBox
        '
        Me.CancelInsuranceFlagComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CancelInsuranceFlagComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "CancelInsuranceFlag", True))
        Me.CancelInsuranceFlagComboBox.DataSource = Me.YesNoBindingSource
        Me.CancelInsuranceFlagComboBox.DisplayMember = "YesNo"
        Me.CancelInsuranceFlagComboBox.FormattingEnabled = True
        Me.CancelInsuranceFlagComboBox.Location = New System.Drawing.Point(794, 93)
        Me.CancelInsuranceFlagComboBox.Name = "CancelInsuranceFlagComboBox"
        Me.CancelInsuranceFlagComboBox.Size = New System.Drawing.Size(114, 21)
        Me.CancelInsuranceFlagComboBox.TabIndex = 16
        Me.CancelInsuranceFlagComboBox.ValueMember = "TrueFalse"
        '
        'YesNoBindingSource
        '
        Me.YesNoBindingSource.DataSource = GetType(Risk.YesNo)
        '
        'CheckClaimMobileNumberButton
        '
        Me.CheckClaimMobileNumberButton.ForeColor = System.Drawing.Color.Red
        Me.CheckClaimMobileNumberButton.Location = New System.Drawing.Point(775, 12)
        Me.CheckClaimMobileNumberButton.Name = "CheckClaimMobileNumberButton"
        Me.CheckClaimMobileNumberButton.Size = New System.Drawing.Size(89, 35)
        Me.CheckClaimMobileNumberButton.TabIndex = 14
        Me.CheckClaimMobileNumberButton.Text = "Check Claim - Mobile Number"
        Me.CheckClaimMobileNumberButton.UseVisualStyleBackColor = True
        '
        'CheckClaimFamilyNameButton
        '
        Me.CheckClaimFamilyNameButton.ForeColor = System.Drawing.Color.Red
        Me.CheckClaimFamilyNameButton.Location = New System.Drawing.Point(673, 12)
        Me.CheckClaimFamilyNameButton.Name = "CheckClaimFamilyNameButton"
        Me.CheckClaimFamilyNameButton.Size = New System.Drawing.Size(89, 35)
        Me.CheckClaimFamilyNameButton.TabIndex = 13
        Me.CheckClaimFamilyNameButton.Text = "Check Claim - Family Name"
        Me.CheckClaimFamilyNameButton.UseVisualStyleBackColor = True
        '
        'Cla_InsuranceTypeComboBox
        '
        Me.Cla_InsuranceTypeComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_InsuranceTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_InsuranceType", True))
        Me.Cla_InsuranceTypeComboBox.FormattingEnabled = True
        Me.Cla_InsuranceTypeComboBox.Items.AddRange(New Object() {"", "Post Paid", "Pre Paid", "Extended Warranty"})
        Me.Cla_InsuranceTypeComboBox.Location = New System.Drawing.Point(126, 12)
        Me.Cla_InsuranceTypeComboBox.Name = "Cla_InsuranceTypeComboBox"
        Me.Cla_InsuranceTypeComboBox.Size = New System.Drawing.Size(245, 21)
        Me.Cla_InsuranceTypeComboBox.TabIndex = 1
        '
        'SchemeIDComboBox
        '
        Me.SchemeIDComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SchemeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "sSchemeID", True))
        Me.SchemeIDComboBox.DataSource = Me.TblSchemeBindingSource
        Me.SchemeIDComboBox.DisplayMember = "SchemeName"
        Me.SchemeIDComboBox.FormattingEnabled = True
        Me.SchemeIDComboBox.Location = New System.Drawing.Point(126, 39)
        Me.SchemeIDComboBox.Name = "SchemeIDComboBox"
        Me.SchemeIDComboBox.Size = New System.Drawing.Size(245, 21)
        Me.SchemeIDComboBox.TabIndex = 3
        Me.SchemeIDComboBox.ValueMember = "sSchemeID"
        '
        'TblSchemeBindingSource
        '
        Me.TblSchemeBindingSource.DataSource = GetType(Risk.Scheme)
        '
        'IMEINumberTextBox
        '
        Me.IMEINumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.IMEINumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "IMEINumber", True))
        Me.IMEINumberTextBox.Location = New System.Drawing.Point(126, 66)
        Me.IMEINumberTextBox.Name = "IMEINumberTextBox"
        Me.IMEINumberTextBox.Size = New System.Drawing.Size(245, 20)
        Me.IMEINumberTextBox.TabIndex = 5
        '
        'MobilePhoneNumberTextBox
        '
        Me.MobilePhoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MobilePhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "MobilePhoneNumber", True))
        Me.MobilePhoneNumberTextBox.Location = New System.Drawing.Point(525, 41)
        Me.MobilePhoneNumberTextBox.Name = "MobilePhoneNumberTextBox"
        Me.MobilePhoneNumberTextBox.Size = New System.Drawing.Size(116, 20)
        Me.MobilePhoneNumberTextBox.TabIndex = 9
        '
        'ClaimDetailsTabPage
        '
        Me.ClaimDetailsTabPage.AutoScroll = True
        Me.ClaimDetailsTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.ClaimDetailsTabPage.Controls.Add(Me.Panel6)
        Me.ClaimDetailsTabPage.Controls.Add(Me.Panel5)
        Me.ClaimDetailsTabPage.Controls.Add(Me.Panel4)
        Me.ClaimDetailsTabPage.Controls.Add(Me.Label9)
        Me.ClaimDetailsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.ClaimDetailsTabPage.Name = "ClaimDetailsTabPage"
        Me.ClaimDetailsTabPage.Size = New System.Drawing.Size(1105, 644)
        Me.ClaimDetailsTabPage.TabIndex = 1
        Me.ClaimDetailsTabPage.Text = "Claim Details"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label92)
        Me.Panel6.Controls.Add(Me.ComboBoxClosedReason)
        Me.Panel6.Controls.Add(Me.OpenLetterReportButton)
        Me.Panel6.Controls.Add(CaseManagerLabel)
        Me.Panel6.Controls.Add(Me.CaseManagerComboBox)
        Me.Panel6.Controls.Add(Me.DeclinedStatusDateTextBox)
        Me.Panel6.Controls.Add(Me.ApprovedStatusDateTextBox)
        Me.Panel6.Controls.Add(Me.MoreInfoStatusDateTextBox)
        Me.Panel6.Controls.Add(Me.UpdateDateTextBox)
        Me.Panel6.Controls.Add(Me.CancelledStatusDateTextBox)
        Me.Panel6.Controls.Add(Me.Label30)
        Me.Panel6.Controls.Add(Me.Cla_DeclineReasonLabel)
        Me.Panel6.Controls.Add(Me.Cla_DeclineReasonComboBox)
        Me.Panel6.Controls.Add(Me.DeclinedUseridTextBox)
        Me.Panel6.Controls.Add(Me.ApprovedUseridTextBox)
        Me.Panel6.Controls.Add(Me.CancelledUseridTextBox)
        Me.Panel6.Controls.Add(Me.MoreInfoUseridTextBox)
        Me.Panel6.Controls.Add(Me.UpdateUserIDTextBox)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Location = New System.Drawing.Point(16, 535)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(920, 147)
        Me.Panel6.TabIndex = 23
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(13, 108)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(79, 13)
        Me.Label92.TabIndex = 35
        Me.Label92.Text = "Closed Reason"
        '
        'ComboBoxClosedReason
        '
        Me.ComboBoxClosedReason.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBoxClosedReason.FormattingEnabled = True
        Me.ComboBoxClosedReason.Items.AddRange(New Object() {" ", "Closed – No Customer Contact", "Closed – Claim Opened in Error", "Closed – Insufficient Info", "Withdrawn – Handset Found", "Withdrawn – Alternate Repair", "Withdrawn – VHA Upgrade", "Withdrawn - Other"})
        Me.ComboBoxClosedReason.Location = New System.Drawing.Point(97, 105)
        Me.ComboBoxClosedReason.Name = "ComboBoxClosedReason"
        Me.ComboBoxClosedReason.Size = New System.Drawing.Size(176, 21)
        Me.ComboBoxClosedReason.TabIndex = 34
        '
        'OpenLetterReportButton
        '
        Me.OpenLetterReportButton.Location = New System.Drawing.Point(601, 62)
        Me.OpenLetterReportButton.Name = "OpenLetterReportButton"
        Me.OpenLetterReportButton.Size = New System.Drawing.Size(286, 37)
        Me.OpenLetterReportButton.TabIndex = 32
        Me.OpenLetterReportButton.Text = "Preview Letter Report"
        Me.OpenLetterReportButton.UseVisualStyleBackColor = True
        '
        'CaseManagerComboBox
        '
        Me.CaseManagerComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CaseManagerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CaseManager", True))
        Me.CaseManagerComboBox.DataSource = Me.CaseManagerBindingSource
        Me.CaseManagerComboBox.DisplayMember = "CaseManager"
        Me.CaseManagerComboBox.FormattingEnabled = True
        Me.CaseManagerComboBox.Location = New System.Drawing.Point(389, 108)
        Me.CaseManagerComboBox.Name = "CaseManagerComboBox"
        Me.CaseManagerComboBox.Size = New System.Drawing.Size(176, 21)
        Me.CaseManagerComboBox.TabIndex = 31
        '
        'CaseManagerBindingSource
        '
        Me.CaseManagerBindingSource.DataSource = GetType(Risk.CaseManager)
        '
        'DeclinedStatusDateTextBox
        '
        Me.DeclinedStatusDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeclinedStatusDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sDeclinedStatusDate", True))
        Me.DeclinedStatusDateTextBox.Location = New System.Drawing.Point(389, 49)
        Me.DeclinedStatusDateTextBox.Name = "DeclinedStatusDateTextBox"
        Me.DeclinedStatusDateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.DeclinedStatusDateTextBox.TabIndex = 30
        '
        'ApprovedStatusDateTextBox
        '
        Me.ApprovedStatusDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ApprovedStatusDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sApprovedStatusDate", True))
        Me.ApprovedStatusDateTextBox.Location = New System.Drawing.Point(389, 15)
        Me.ApprovedStatusDateTextBox.Name = "ApprovedStatusDateTextBox"
        Me.ApprovedStatusDateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.ApprovedStatusDateTextBox.TabIndex = 29
        '
        'MoreInfoStatusDateTextBox
        '
        Me.MoreInfoStatusDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MoreInfoStatusDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sMoreInfoStatusDate", True))
        Me.MoreInfoStatusDateTextBox.Location = New System.Drawing.Point(97, 50)
        Me.MoreInfoStatusDateTextBox.Name = "MoreInfoStatusDateTextBox"
        Me.MoreInfoStatusDateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.MoreInfoStatusDateTextBox.TabIndex = 28
        Me.MoreInfoStatusDateTextBox.Visible = False
        '
        'UpdateDateTextBox
        '
        Me.UpdateDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UpdateDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sUpdateDate", True))
        Me.UpdateDateTextBox.Location = New System.Drawing.Point(97, 15)
        Me.UpdateDateTextBox.Name = "UpdateDateTextBox"
        Me.UpdateDateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.UpdateDateTextBox.TabIndex = 27
        Me.UpdateDateTextBox.Visible = False
        '
        'CancelledStatusDateTextBox
        '
        Me.CancelledStatusDateTextBox.BackColor = System.Drawing.Color.White
        Me.CancelledStatusDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCancelledStatusDate", True))
        Me.CancelledStatusDateTextBox.Location = New System.Drawing.Point(97, 79)
        Me.CancelledStatusDateTextBox.Name = "CancelledStatusDateTextBox"
        Me.CancelledStatusDateTextBox.Size = New System.Drawing.Size(93, 20)
        Me.CancelledStatusDateTextBox.TabIndex = 26
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Blue
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(598, 15)
        Me.Label30.MaximumSize = New System.Drawing.Size(300, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(299, 30)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = "REMEMBER All Unable to Renew, Decline and Cash Settlement letters need to be save" &
    "d"
        '
        'Cla_DeclineReasonComboBox
        '
        Me.Cla_DeclineReasonComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_DeclineReasonComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "cla_DeclineReason", True))
        Me.Cla_DeclineReasonComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_DeclineReason", True))
        Me.Cla_DeclineReasonComboBox.DataSource = Me.TLookupBindingSource
        Me.Cla_DeclineReasonComboBox.DisplayMember = "lu_Value"
        Me.Cla_DeclineReasonComboBox.FormattingEnabled = True
        Me.Cla_DeclineReasonComboBox.Location = New System.Drawing.Point(389, 79)
        Me.Cla_DeclineReasonComboBox.Name = "Cla_DeclineReasonComboBox"
        Me.Cla_DeclineReasonComboBox.Size = New System.Drawing.Size(176, 21)
        Me.Cla_DeclineReasonComboBox.TabIndex = 16
        Me.Cla_DeclineReasonComboBox.ValueMember = "lu_Value"
        '
        'TLookupBindingSource
        '
        Me.TLookupBindingSource.DataMember = "t_Lookup"
        Me.TLookupBindingSource.DataSource = Me.RiskDataSet
        '
        'DeclinedUseridTextBox
        '
        Me.DeclinedUseridTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DeclinedUseridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "DeclinedUserid", True))
        Me.DeclinedUseridTextBox.Location = New System.Drawing.Point(501, 49)
        Me.DeclinedUseridTextBox.Name = "DeclinedUseridTextBox"
        Me.DeclinedUseridTextBox.ReadOnly = True
        Me.DeclinedUseridTextBox.Size = New System.Drawing.Size(64, 20)
        Me.DeclinedUseridTextBox.TabIndex = 15
        '
        'ApprovedUseridTextBox
        '
        Me.ApprovedUseridTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ApprovedUseridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "ApprovedUserid", True))
        Me.ApprovedUseridTextBox.Location = New System.Drawing.Point(501, 15)
        Me.ApprovedUseridTextBox.Name = "ApprovedUseridTextBox"
        Me.ApprovedUseridTextBox.ReadOnly = True
        Me.ApprovedUseridTextBox.Size = New System.Drawing.Size(64, 20)
        Me.ApprovedUseridTextBox.TabIndex = 14
        '
        'CancelledUseridTextBox
        '
        Me.CancelledUseridTextBox.BackColor = System.Drawing.Color.White
        Me.CancelledUseridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CancelledUserid", True))
        Me.CancelledUseridTextBox.Location = New System.Drawing.Point(209, 79)
        Me.CancelledUseridTextBox.Name = "CancelledUseridTextBox"
        Me.CancelledUseridTextBox.ReadOnly = True
        Me.CancelledUseridTextBox.Size = New System.Drawing.Size(64, 20)
        Me.CancelledUseridTextBox.TabIndex = 13
        '
        'MoreInfoUseridTextBox
        '
        Me.MoreInfoUseridTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MoreInfoUseridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "MoreInfoUserid", True))
        Me.MoreInfoUseridTextBox.Location = New System.Drawing.Point(209, 49)
        Me.MoreInfoUseridTextBox.Name = "MoreInfoUseridTextBox"
        Me.MoreInfoUseridTextBox.ReadOnly = True
        Me.MoreInfoUseridTextBox.Size = New System.Drawing.Size(64, 20)
        Me.MoreInfoUseridTextBox.TabIndex = 12
        Me.MoreInfoUseridTextBox.Visible = False
        '
        'UpdateUserIDTextBox
        '
        Me.UpdateUserIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.UpdateUserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "UpdateUserID", True))
        Me.UpdateUserIDTextBox.Location = New System.Drawing.Point(209, 15)
        Me.UpdateUserIDTextBox.Name = "UpdateUserIDTextBox"
        Me.UpdateUserIDTextBox.ReadOnly = True
        Me.UpdateUserIDTextBox.Size = New System.Drawing.Size(64, 20)
        Me.UpdateUserIDTextBox.TabIndex = 11
        Me.UpdateUserIDTextBox.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(305, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Declined Date"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(301, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Approved Date"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Closed Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "More Info Date"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Last Updated"
        Me.Label10.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel20)
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Controls.Add(Me.DeliveryPostcodeLabel)
        Me.Panel5.Controls.Add(Me.DeliveryPostcodeTextBox)
        Me.Panel5.Controls.Add(Me.Cla_DeliveryStateLabel)
        Me.Panel5.Controls.Add(Me.Cla_DeliveryStateTextBox)
        Me.Panel5.Controls.Add(Me.DeliverySuburbMultiColumnCombo)
        Me.Panel5.Controls.Add(Me.DeliverySuburbLabel)
        Me.Panel5.Controls.Add(Me.DeliveryAddress2TextBox)
        Me.Panel5.Controls.Add(Me.DeliveryAddress1Label)
        Me.Panel5.Controls.Add(Me.DeliveryAddress1TextBox)
        Me.Panel5.Controls.Add(Me.Cla_DeliverPersonLabel)
        Me.Panel5.Controls.Add(Me.Cla_DeliverPersonTextBox)
        Me.Panel5.Location = New System.Drawing.Point(16, 355)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(920, 172)
        Me.Panel5.TabIndex = 22
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel20.Controls.Add(Me.Label66)
        Me.Panel20.Controls.Add(Me.Label64)
        Me.Panel20.Controls.Add(Me.Label31)
        Me.Panel20.Controls.Add(Me.Label28)
        Me.Panel20.Location = New System.Drawing.Point(14, 3)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(865, 75)
        Me.Panel20.TabIndex = 32
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(6, 48)
        Me.Label66.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(709, 26)
        Me.Label66.TabIndex = 4
        Me.Label66.Text = "Likewize Services also advise if you provide an address that is unattended your p" &
    "ackage may be sent to the local depot and you will need to arrange collection at" &
    " your own cost and time."
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(6, 35)
        Me.Label64.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(368, 13)
        Me.Label64.TabIndex = 3
        Me.Label64.Text = "Can you please confirm that the address we have is the best delivery option?"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(6, 22)
        Me.Label31.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(743, 26)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Likewize Services will not be responsible for any packages once they are signed f" &
    "or at your location. Please note that the package can be signed for by any perso" &
    "n at the nominated location."
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 9)
        Me.Label28.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(541, 13)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "We require an address where the phone can be delivered and signed for by courier " &
    "during 9 - 5 Monday to Friday."
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Navy
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Yellow
        Me.Label29.Location = New System.Drawing.Point(101, 144)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(668, 14)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "I have confirmed the customers delivery address && handset details prior to colle" &
    "cting the excess - Leave notes in Claim"
        '
        'DeliveryPostcodeTextBox
        '
        Me.DeliveryPostcodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DeliveryPostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "DeliveryPostcode", True))
        Me.DeliveryPostcodeTextBox.Location = New System.Drawing.Point(779, 121)
        Me.DeliveryPostcodeTextBox.Name = "DeliveryPostcodeTextBox"
        Me.DeliveryPostcodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DeliveryPostcodeTextBox.TabIndex = 30
        '
        'Cla_DeliveryStateTextBox
        '
        Me.Cla_DeliveryStateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_DeliveryStateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_DeliveryState", True))
        Me.Cla_DeliveryStateTextBox.Location = New System.Drawing.Point(601, 121)
        Me.Cla_DeliveryStateTextBox.Name = "Cla_DeliveryStateTextBox"
        Me.Cla_DeliveryStateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_DeliveryStateTextBox.TabIndex = 29
        '
        'DeliverySuburbMultiColumnCombo
        '
        Me.DeliverySuburbMultiColumnCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.DeliverySuburbMultiColumnCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DeliverySuburbMultiColumnCombo.ColumnWidths = "300;75;75"
        Me.DeliverySuburbMultiColumnCombo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "DeliveryID", True))
        Me.DeliverySuburbMultiColumnCombo.DataSource = Me.Delivery_TPostcodeBindingSource
        Me.DeliverySuburbMultiColumnCombo.DisplayMember = "Display"
        Me.DeliverySuburbMultiColumnCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DeliverySuburbMultiColumnCombo.DropDownWidth = 460
        Me.DeliverySuburbMultiColumnCombo.FormattingEnabled = True
        Me.DeliverySuburbMultiColumnCombo.Location = New System.Drawing.Point(601, 97)
        Me.DeliverySuburbMultiColumnCombo.Name = "DeliverySuburbMultiColumnCombo"
        Me.DeliverySuburbMultiColumnCombo.Size = New System.Drawing.Size(278, 21)
        Me.DeliverySuburbMultiColumnCombo.TabIndex = 28
        Me.DeliverySuburbMultiColumnCombo.ValueMember = "sPostCodeID"
        '
        'Delivery_TPostcodeBindingSource
        '
        Me.Delivery_TPostcodeBindingSource.DataSource = GetType(Risk.PostCode)
        '
        'DeliveryAddress2TextBox
        '
        Me.DeliveryAddress2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DeliveryAddress2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "DeliveryAddress2", True))
        Me.DeliveryAddress2TextBox.Location = New System.Drawing.Point(246, 118)
        Me.DeliveryAddress2TextBox.Name = "DeliveryAddress2TextBox"
        Me.DeliveryAddress2TextBox.Size = New System.Drawing.Size(297, 20)
        Me.DeliveryAddress2TextBox.TabIndex = 27
        '
        'DeliveryAddress1TextBox
        '
        Me.DeliveryAddress1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DeliveryAddress1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "DeliveryAddress1", True))
        Me.DeliveryAddress1TextBox.Location = New System.Drawing.Point(246, 97)
        Me.DeliveryAddress1TextBox.Name = "DeliveryAddress1TextBox"
        Me.DeliveryAddress1TextBox.Size = New System.Drawing.Size(297, 20)
        Me.DeliveryAddress1TextBox.TabIndex = 26
        '
        'Cla_DeliverPersonTextBox
        '
        Me.Cla_DeliverPersonTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_DeliverPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_DeliverPerson", True))
        Me.Cla_DeliverPersonTextBox.Location = New System.Drawing.Point(7, 97)
        Me.Cla_DeliverPersonTextBox.Multiline = True
        Me.Cla_DeliverPersonTextBox.Name = "Cla_DeliverPersonTextBox"
        Me.Cla_DeliverPersonTextBox.Size = New System.Drawing.Size(222, 41)
        Me.Cla_DeliverPersonTextBox.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label38)
        Me.Panel4.Controls.Add(SDateTimeSimReplacedLabel)
        Me.Panel4.Controls.Add(Me.SDateTimeSimReplacedTextBox)
        Me.Panel4.Controls.Add(InteractionNotesReceivedLabel)
        Me.Panel4.Controls.Add(Me.InteractionNotesReceivedCheckBox)
        Me.Panel4.Controls.Add(BillReceivedLabel)
        Me.Panel4.Controls.Add(Me.BillReceivedCheckBox)
        Me.Panel4.Controls.Add(PhotoIDReceivedLabel)
        Me.Panel4.Controls.Add(Me.PhotoIDReceivedCheckBox)
        Me.Panel4.Controls.Add(Me.LossDateTextBox)
        Me.Panel4.Controls.Add(Me.Cla_ProofOfPurchaseCheckBox)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.Cla_IMEINotBlockedReasonTextBox)
        Me.Panel4.Controls.Add(Me.Cla_IMEIBlockedCheckBox)
        Me.Panel4.Controls.Add(Me.PoliceReportNumberTextBox)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Cla_ProofOfForcibleEntryCheckBox)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.ExampleCircumstancesButton)
        Me.Panel4.Controls.Add(Me.LossTypeLabel)
        Me.Panel4.Controls.Add(Me.LossTypeComboBox)
        Me.Panel4.Controls.Add(Me.DamageTypeTextBox)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Location = New System.Drawing.Point(16, 29)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(920, 318)
        Me.Panel4.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(112, 146)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(696, 26)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = resources.GetString("Label18.Text")
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(14, 62)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(680, 26)
        Me.Label38.TabIndex = 32
        Me.Label38.Text = "Lost/Stolen: Can you please explain in full detail from the last time that you re" &
    "member physically seeing the phone up until the point you realised " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that the ph" &
    "one was missing."
        '
        'SDateTimeSimReplacedTextBox
        '
        Me.SDateTimeSimReplacedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SDateTimeSimReplacedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sDateTimeSimReplaced", True))
        Me.SDateTimeSimReplacedTextBox.Location = New System.Drawing.Point(234, 288)
        Me.SDateTimeSimReplacedTextBox.Name = "SDateTimeSimReplacedTextBox"
        Me.SDateTimeSimReplacedTextBox.Size = New System.Drawing.Size(146, 20)
        Me.SDateTimeSimReplacedTextBox.TabIndex = 31
        '
        'InteractionNotesReceivedCheckBox
        '
        Me.InteractionNotesReceivedCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.InteractionNotesReceivedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "InteractionNotesReceived", True))
        Me.InteractionNotesReceivedCheckBox.Location = New System.Drawing.Point(234, 258)
        Me.InteractionNotesReceivedCheckBox.Name = "InteractionNotesReceivedCheckBox"
        Me.InteractionNotesReceivedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.InteractionNotesReceivedCheckBox.TabIndex = 30
        Me.InteractionNotesReceivedCheckBox.UseVisualStyleBackColor = False
        '
        'BillReceivedCheckBox
        '
        Me.BillReceivedCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BillReceivedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "BillReceived", True))
        Me.BillReceivedCheckBox.Location = New System.Drawing.Point(234, 232)
        Me.BillReceivedCheckBox.Name = "BillReceivedCheckBox"
        Me.BillReceivedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.BillReceivedCheckBox.TabIndex = 29
        Me.BillReceivedCheckBox.UseVisualStyleBackColor = False
        '
        'PhotoIDReceivedCheckBox
        '
        Me.PhotoIDReceivedCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhotoIDReceivedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "PhotoIDReceived", True))
        Me.PhotoIDReceivedCheckBox.Location = New System.Drawing.Point(234, 209)
        Me.PhotoIDReceivedCheckBox.Name = "PhotoIDReceivedCheckBox"
        Me.PhotoIDReceivedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PhotoIDReceivedCheckBox.TabIndex = 28
        Me.PhotoIDReceivedCheckBox.UseVisualStyleBackColor = False
        '
        'LossDateTextBox
        '
        Me.LossDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LossDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sLossDate", True))
        Me.LossDateTextBox.Location = New System.Drawing.Point(280, 6)
        Me.LossDateTextBox.Name = "LossDateTextBox"
        Me.LossDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LossDateTextBox.TabIndex = 24
        '
        'Cla_ProofOfPurchaseCheckBox
        '
        Me.Cla_ProofOfPurchaseCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_ProofOfPurchaseCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "cla_ProofOfPurchase", True))
        Me.Cla_ProofOfPurchaseCheckBox.ForeColor = System.Drawing.Color.Blue
        Me.Cla_ProofOfPurchaseCheckBox.Location = New System.Drawing.Point(602, 258)
        Me.Cla_ProofOfPurchaseCheckBox.Name = "Cla_ProofOfPurchaseCheckBox"
        Me.Cla_ProofOfPurchaseCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.Cla_ProofOfPurchaseCheckBox.TabIndex = 1
        Me.Cla_ProofOfPurchaseCheckBox.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 7.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(626, 254)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(251, 11)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "Date IMEI Blocked and by which Service Provider."
        '
        'Cla_IMEINotBlockedReasonTextBox
        '
        Me.Cla_IMEINotBlockedReasonTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_IMEINotBlockedReasonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_IMEINotBlockedReason", True))
        Me.Cla_IMEINotBlockedReasonTextBox.Location = New System.Drawing.Point(535, 234)
        Me.Cla_IMEINotBlockedReasonTextBox.Name = "Cla_IMEINotBlockedReasonTextBox"
        Me.Cla_IMEINotBlockedReasonTextBox.Size = New System.Drawing.Size(312, 20)
        Me.Cla_IMEINotBlockedReasonTextBox.TabIndex = 25
        '
        'Cla_IMEIBlockedCheckBox
        '
        Me.Cla_IMEIBlockedCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_IMEIBlockedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "cla_IMEIBlocked", True))
        Me.Cla_IMEIBlockedCheckBox.ForeColor = System.Drawing.Color.Blue
        Me.Cla_IMEIBlockedCheckBox.Location = New System.Drawing.Point(510, 234)
        Me.Cla_IMEIBlockedCheckBox.Name = "Cla_IMEIBlockedCheckBox"
        Me.Cla_IMEIBlockedCheckBox.Size = New System.Drawing.Size(19, 24)
        Me.Cla_IMEIBlockedCheckBox.TabIndex = 3
        Me.Cla_IMEIBlockedCheckBox.UseVisualStyleBackColor = False
        '
        'PoliceReportNumberTextBox
        '
        Me.PoliceReportNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PoliceReportNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "PoliceReportNumber", True))
        Me.PoliceReportNumberTextBox.Location = New System.Drawing.Point(562, 207)
        Me.PoliceReportNumberTextBox.Name = "PoliceReportNumberTextBox"
        Me.PoliceReportNumberTextBox.Size = New System.Drawing.Size(285, 20)
        Me.PoliceReportNumberTextBox.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Blue
        Me.Label26.Location = New System.Drawing.Point(425, 262)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(171, 15)
        Me.Label26.TabIndex = 24
        Me.Label26.Text = "Proof of Purchase Obtained?"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Blue
        Me.Label25.Location = New System.Drawing.Point(425, 238)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 15)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "IMEI Blocked"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(425, 209)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 15)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "Police Report Number"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(425, 184)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(422, 17)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "A Police Report must be lodged for all lost/stolen phones"
        '
        'Cla_ProofOfForcibleEntryCheckBox
        '
        Me.Cla_ProofOfForcibleEntryCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_ProofOfForcibleEntryCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "cla_ProofOfForcibleEntry", True))
        Me.Cla_ProofOfForcibleEntryCheckBox.ForeColor = System.Drawing.Color.Blue
        Me.Cla_ProofOfForcibleEntryCheckBox.Location = New System.Drawing.Point(234, 182)
        Me.Cla_ProofOfForcibleEntryCheckBox.Name = "Cla_ProofOfForcibleEntryCheckBox"
        Me.Cla_ProofOfForcibleEntryCheckBox.Size = New System.Drawing.Size(20, 24)
        Me.Cla_ProofOfForcibleEntryCheckBox.TabIndex = 19
        Me.Cla_ProofOfForcibleEntryCheckBox.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(35, 184)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(193, 30)
        Me.Label20.TabIndex = 12
        Me.Label20.Text = "CRIMINAL OFFENCE – Was HCPR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "obtained?"
        '
        'ExampleCircumstancesButton
        '
        Me.ExampleCircumstancesButton.Location = New System.Drawing.Point(775, 35)
        Me.ExampleCircumstancesButton.Name = "ExampleCircumstancesButton"
        Me.ExampleCircumstancesButton.Size = New System.Drawing.Size(90, 70)
        Me.ExampleCircumstancesButton.TabIndex = 8
        Me.ExampleCircumstancesButton.Text = "Example Circumstances"
        Me.ExampleCircumstancesButton.UseVisualStyleBackColor = True
        Me.ExampleCircumstancesButton.Visible = False
        '
        'LossTypeComboBox
        '
        Me.LossTypeComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LossTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "LossType", True))
        Me.LossTypeComboBox.FormattingEnabled = True
        Me.LossTypeComboBox.Items.AddRange(New Object() {"", "Breakdown", "Impact", "Liquid", "Lost", "Stolen", "Vandalism", "Manufacturers Fault", "Wear and Tear", "Extended Warranty"})
        Me.LossTypeComboBox.Location = New System.Drawing.Point(487, 30)
        Me.LossTypeComboBox.Name = "LossTypeComboBox"
        Me.LossTypeComboBox.Size = New System.Drawing.Size(222, 21)
        Me.LossTypeComboBox.TabIndex = 7
        '
        'DamageTypeTextBox
        '
        Me.DamageTypeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.DamageTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "DamageType", True))
        Me.DamageTypeTextBox.Location = New System.Drawing.Point(3, 91)
        Me.DamageTypeTextBox.Multiline = True
        Me.DamageTypeTextBox.Name = "DamageTypeTextBox"
        Me.DamageTypeTextBox.Size = New System.Drawing.Size(759, 48)
        Me.DamageTypeTextBox.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(14, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(351, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Damage: Can you please explain in full detail how this damage occurred?"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 9)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(270, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "What date was the mobile phone lost/stolen/damaged?"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 15)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Circumstances of Loss"
        '
        'SettlementDetailsTabPage
        '
        Me.SettlementDetailsTabPage.AutoScroll = True
        Me.SettlementDetailsTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.SettlementDetailsTabPage.Controls.Add(Me.Panel22)
        Me.SettlementDetailsTabPage.Controls.Add(Me.Panel21)
        Me.SettlementDetailsTabPage.Controls.Add(Me.Panel16)
        Me.SettlementDetailsTabPage.Controls.Add(Me.Panel18)
        Me.SettlementDetailsTabPage.Controls.Add(Me.Panel3)
        Me.SettlementDetailsTabPage.Controls.Add(Me.Panel11)
        Me.SettlementDetailsTabPage.Controls.Add(Me.Panel10)
        Me.SettlementDetailsTabPage.Controls.Add(Me.Panel7)
        Me.SettlementDetailsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.SettlementDetailsTabPage.Name = "SettlementDetailsTabPage"
        Me.SettlementDetailsTabPage.Size = New System.Drawing.Size(1105, 644)
        Me.SettlementDetailsTabPage.TabIndex = 2
        Me.SettlementDetailsTabPage.Text = "Settlement Details"
        '
        'Panel22
        '
        Me.Panel22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel22.Controls.Add(Me.ChequePaymentDateTextBox)
        Me.Panel22.Controls.Add(Me.Label88)
        Me.Panel22.Controls.Add(Me.IsProcessedChequeCheckBox)
        Me.Panel22.Controls.Add(Me.Label90)
        Me.Panel22.Controls.Add(Me.Label69)
        Me.Panel22.Controls.Add(Me.Label70)
        Me.Panel22.Controls.Add(Me.Label71)
        Me.Panel22.Controls.Add(Me.ChequeSupplierNumberTextBox)
        Me.Panel22.Controls.Add(Me.ChequeNumberTextBox)
        Me.Panel22.Controls.Add(Me.Label72)
        Me.Panel22.Controls.Add(Me.Label74)
        Me.Panel22.Controls.Add(Me.ChequeAmountTextBox)
        Me.Panel22.Location = New System.Drawing.Point(611, 496)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(348, 167)
        Me.Panel22.TabIndex = 55
        '
        'ChequePaymentDateTextBox
        '
        Me.ChequePaymentDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChequePaymentDateTextBox.Location = New System.Drawing.Point(213, 113)
        Me.ChequePaymentDateTextBox.Name = "ChequePaymentDateTextBox"
        Me.ChequePaymentDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ChequePaymentDateTextBox.TabIndex = 53
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.ForeColor = System.Drawing.Color.Blue
        Me.Label88.Location = New System.Drawing.Point(245, 135)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(69, 13)
        Me.Label88.TabIndex = 52
        Me.Label88.Text = "*dd/mm/yyyy"
        '
        'IsProcessedChequeCheckBox
        '
        Me.IsProcessedChequeCheckBox.AutoSize = True
        Me.IsProcessedChequeCheckBox.Location = New System.Drawing.Point(213, 148)
        Me.IsProcessedChequeCheckBox.Name = "IsProcessedChequeCheckBox"
        Me.IsProcessedChequeCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.IsProcessedChequeCheckBox.TabIndex = 51
        Me.IsProcessedChequeCheckBox.UseVisualStyleBackColor = True
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(54, 149)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(156, 13)
        Me.Label90.TabIndex = 50
        Me.Label90.Text = "Already Process This Payment?"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(39, 8)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(147, 15)
        Me.Label69.TabIndex = 46
        Me.Label69.Text = "Cheque Payment Details"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(93, 113)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(114, 13)
        Me.Label70.TabIndex = 45
        Me.Label70.Text = "Cheque Payment Date"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(3, 88)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(204, 13)
        Me.Label71.TabIndex = 44
        Me.Label71.Text = "Cash Settle OR Other Supplier Amount ($)"
        '
        'ChequeSupplierNumberTextBox
        '
        Me.ChequeSupplierNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChequeSupplierNumberTextBox.Location = New System.Drawing.Point(213, 35)
        Me.ChequeSupplierNumberTextBox.Name = "ChequeSupplierNumberTextBox"
        Me.ChequeSupplierNumberTextBox.Size = New System.Drawing.Size(126, 20)
        Me.ChequeSupplierNumberTextBox.TabIndex = 39
        '
        'ChequeNumberTextBox
        '
        Me.ChequeNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChequeNumberTextBox.Location = New System.Drawing.Point(213, 61)
        Me.ChequeNumberTextBox.Name = "ChequeNumberTextBox"
        Me.ChequeNumberTextBox.Size = New System.Drawing.Size(126, 20)
        Me.ChequeNumberTextBox.TabIndex = 40
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(97, 38)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(85, 13)
        Me.Label72.TabIndex = 38
        Me.Label72.Text = "Supplier Number"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(98, 63)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(84, 13)
        Me.Label74.TabIndex = 39
        Me.Label74.Text = "Cheque Number"
        '
        'ChequeAmountTextBox
        '
        Me.ChequeAmountTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChequeAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChequeAmountTextBox.Location = New System.Drawing.Point(213, 87)
        Me.ChequeAmountTextBox.Name = "ChequeAmountTextBox"
        Me.ChequeAmountTextBox.ShortcutsEnabled = False
        Me.ChequeAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ChequeAmountTextBox.TabIndex = 41
        '
        'Panel21
        '
        Me.Panel21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel21.Controls.Add(Me.CopyAccountHoldersButton)
        Me.Panel21.Controls.Add(Me.ReturnToAddressCheckBox)
        Me.Panel21.Controls.Add(Me.RemittanceLayoutCodeTextBox)
        Me.Panel21.Controls.Add(Me.Label87)
        Me.Panel21.Controls.Add(Me.Label86)
        Me.Panel21.Controls.Add(Me.EmailTextBox)
        Me.Panel21.Controls.Add(Me.Label85)
        Me.Panel21.Controls.Add(Me.FaxTextBox)
        Me.Panel21.Controls.Add(Me.Label84)
        Me.Panel21.Controls.Add(Me.StateComboBox)
        Me.Panel21.Controls.Add(Me.PostCodeTextBox)
        Me.Panel21.Controls.Add(Me.Label83)
        Me.Panel21.Controls.Add(Me.CountryTextBox)
        Me.Panel21.Controls.Add(Me.Label82)
        Me.Panel21.Controls.Add(Me.Street3TextBox)
        Me.Panel21.Controls.Add(Me.Label81)
        Me.Panel21.Controls.Add(Me.Street1TextBox)
        Me.Panel21.Controls.Add(Me.Label80)
        Me.Panel21.Controls.Add(Me.RemittanceDeliveryTypeComboBox)
        Me.Panel21.Controls.Add(Me.Label73)
        Me.Panel21.Controls.Add(Me.Label75)
        Me.Panel21.Controls.Add(Me.Label76)
        Me.Panel21.Controls.Add(Me.PayeeNameTextBox)
        Me.Panel21.Controls.Add(Me.AddresseeNameTextBox)
        Me.Panel21.Controls.Add(Me.Label77)
        Me.Panel21.Controls.Add(Me.Label78)
        Me.Panel21.Controls.Add(Me.Label79)
        Me.Panel21.Controls.Add(Me.Street2TextBox)
        Me.Panel21.Controls.Add(Me.CityTextBox)
        Me.Panel21.Location = New System.Drawing.Point(3, 426)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(594, 237)
        Me.Panel21.TabIndex = 54
        '
        'CopyAccountHoldersButton
        '
        Me.CopyAccountHoldersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyAccountHoldersButton.ForeColor = System.Drawing.Color.Red
        Me.CopyAccountHoldersButton.Location = New System.Drawing.Point(213, 3)
        Me.CopyAccountHoldersButton.Name = "CopyAccountHoldersButton"
        Me.CopyAccountHoldersButton.Size = New System.Drawing.Size(369, 30)
        Me.CopyAccountHoldersButton.TabIndex = 48
        Me.CopyAccountHoldersButton.Text = "Get R-Details From'Claimant Details' - Account Holders Details"
        Me.CopyAccountHoldersButton.UseVisualStyleBackColor = True
        '
        'ReturnToAddressCheckBox
        '
        Me.ReturnToAddressCheckBox.AutoSize = True
        Me.ReturnToAddressCheckBox.BackColor = System.Drawing.SystemColors.Control
        Me.ReturnToAddressCheckBox.Location = New System.Drawing.Point(448, 197)
        Me.ReturnToAddressCheckBox.Name = "ReturnToAddressCheckBox"
        Me.ReturnToAddressCheckBox.Size = New System.Drawing.Size(115, 17)
        Me.ReturnToAddressCheckBox.TabIndex = 65
        Me.ReturnToAddressCheckBox.Text = "Return To Address"
        Me.ReturnToAddressCheckBox.UseVisualStyleBackColor = False
        '
        'RemittanceLayoutCodeTextBox
        '
        Me.RemittanceLayoutCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RemittanceLayoutCodeTextBox.Location = New System.Drawing.Point(141, 198)
        Me.RemittanceLayoutCodeTextBox.Name = "RemittanceLayoutCodeTextBox"
        Me.RemittanceLayoutCodeTextBox.Size = New System.Drawing.Size(51, 20)
        Me.RemittanceLayoutCodeTextBox.TabIndex = 64
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(6, 198)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(124, 13)
        Me.Label87.TabIndex = 63
        Me.Label87.Text = "Remittance Layout Code"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(66, 173)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(32, 13)
        Me.Label86.TabIndex = 61
        Me.Label86.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTextBox.Location = New System.Drawing.Point(141, 170)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(205, 20)
        Me.EmailTextBox.TabIndex = 62
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(413, 173)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(24, 13)
        Me.Label85.TabIndex = 59
        Me.Label85.Text = "Fax"
        '
        'FaxTextBox
        '
        Me.FaxTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FaxTextBox.Location = New System.Drawing.Point(448, 173)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(134, 20)
        Me.FaxTextBox.TabIndex = 60
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(87, 151)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(43, 13)
        Me.Label84.TabIndex = 58
        Me.Label84.Text = "Country"
        '
        'StateComboBox
        '
        Me.StateComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Items.AddRange(New Object() {"ACT", "NSW", "VIC", "SA", "QLD", "WA", "NT", "TAS"})
        Me.StateComboBox.Location = New System.Drawing.Point(448, 146)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(79, 21)
        Me.StateComboBox.TabIndex = 57
        '
        'PostCodeTextBox
        '
        Me.PostCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PostCodeTextBox.Location = New System.Drawing.Point(448, 119)
        Me.PostCodeTextBox.Name = "PostCodeTextBox"
        Me.PostCodeTextBox.Size = New System.Drawing.Size(79, 20)
        Me.PostCodeTextBox.TabIndex = 56
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(370, 145)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(32, 13)
        Me.Label83.TabIndex = 54
        Me.Label83.Text = "State"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CountryTextBox.Location = New System.Drawing.Point(141, 145)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.ReadOnly = True
        Me.CountryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CountryTextBox.TabIndex = 55
        Me.CountryTextBox.Text = "AUSTRALIA"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(370, 95)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(44, 13)
        Me.Label82.TabIndex = 53
        Me.Label82.Text = "Street 3"
        '
        'Street3TextBox
        '
        Me.Street3TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Street3TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Street3TextBox.Location = New System.Drawing.Point(448, 92)
        Me.Street3TextBox.Name = "Street3TextBox"
        Me.Street3TextBox.ShortcutsEnabled = False
        Me.Street3TextBox.Size = New System.Drawing.Size(134, 20)
        Me.Street3TextBox.TabIndex = 52
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(370, 45)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(44, 13)
        Me.Label81.TabIndex = 50
        Me.Label81.Text = "Street 1"
        '
        'Street1TextBox
        '
        Me.Street1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Street1TextBox.Location = New System.Drawing.Point(448, 41)
        Me.Street1TextBox.Name = "Street1TextBox"
        Me.Street1TextBox.Size = New System.Drawing.Size(134, 20)
        Me.Street1TextBox.TabIndex = 51
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(1, 41)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(129, 13)
        Me.Label80.TabIndex = 49
        Me.Label80.Text = "Remittance Delivery Type"
        '
        'RemittanceDeliveryTypeComboBox
        '
        Me.RemittanceDeliveryTypeComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RemittanceDeliveryTypeComboBox.FormattingEnabled = True
        Me.RemittanceDeliveryTypeComboBox.Items.AddRange(New Object() {"EMAIL", "POST", "NONE"})
        Me.RemittanceDeliveryTypeComboBox.Location = New System.Drawing.Point(141, 39)
        Me.RemittanceDeliveryTypeComboBox.Name = "RemittanceDeliveryTypeComboBox"
        Me.RemittanceDeliveryTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.RemittanceDeliveryTypeComboBox.TabIndex = 48
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(65, 9)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(116, 15)
        Me.Label73.TabIndex = 46
        Me.Label73.Text = "Remittance Details"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(370, 122)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(56, 13)
        Me.Label75.TabIndex = 45
        Me.Label75.Text = "Post Code"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(370, 69)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(44, 13)
        Me.Label76.TabIndex = 44
        Me.Label76.Text = "Street 2"
        '
        'PayeeNameTextBox
        '
        Me.PayeeNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PayeeNameTextBox.Location = New System.Drawing.Point(141, 66)
        Me.PayeeNameTextBox.Name = "PayeeNameTextBox"
        Me.PayeeNameTextBox.Size = New System.Drawing.Size(205, 20)
        Me.PayeeNameTextBox.TabIndex = 39
        '
        'AddresseeNameTextBox
        '
        Me.AddresseeNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddresseeNameTextBox.Location = New System.Drawing.Point(141, 92)
        Me.AddresseeNameTextBox.Name = "AddresseeNameTextBox"
        Me.AddresseeNameTextBox.Size = New System.Drawing.Size(205, 20)
        Me.AddresseeNameTextBox.TabIndex = 40
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(62, 66)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(68, 13)
        Me.Label77.TabIndex = 38
        Me.Label77.Text = "Payee Name"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(106, 122)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(24, 13)
        Me.Label78.TabIndex = 41
        Me.Label78.Text = "City"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(42, 95)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(88, 13)
        Me.Label79.TabIndex = 39
        Me.Label79.Text = "Addressee Name"
        '
        'Street2TextBox
        '
        Me.Street2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Street2TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Street2TextBox.Location = New System.Drawing.Point(448, 66)
        Me.Street2TextBox.Name = "Street2TextBox"
        Me.Street2TextBox.ShortcutsEnabled = False
        Me.Street2TextBox.Size = New System.Drawing.Size(134, 20)
        Me.Street2TextBox.TabIndex = 41
        '
        'CityTextBox
        '
        Me.CityTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CityTextBox.Location = New System.Drawing.Point(141, 119)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(205, 20)
        Me.CityTextBox.TabIndex = 42
        '
        'Panel16
        '
        Me.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel16.Controls.Add(Me.EFTPaymentDateTextBox)
        Me.Panel16.Controls.Add(Me.Label50)
        Me.Panel16.Controls.Add(Me.Label91)
        Me.Panel16.Controls.Add(Me.IsProcessedEFTCheckBox)
        Me.Panel16.Controls.Add(Me.Label89)
        Me.Panel16.Controls.Add(Me.Label68)
        Me.Panel16.Controls.Add(Me.Label67)
        Me.Panel16.Controls.Add(Me.Label17)
        Me.Panel16.Controls.Add(Me.AccountNameTextBox)
        Me.Panel16.Controls.Add(Me.BSBNumberTextBox)
        Me.Panel16.Controls.Add(Me.AccountNameLabel)
        Me.Panel16.Controls.Add(Me.Label22)
        Me.Panel16.Controls.Add(Me.Label43)
        Me.Panel16.Controls.Add(Me.EFTPaymentAmountTextBox)
        Me.Panel16.Controls.Add(Me.EFTAccountNumberTextBox)
        Me.Panel16.Location = New System.Drawing.Point(3, 306)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(594, 110)
        Me.Panel16.TabIndex = 50
        '
        'EFTPaymentDateTextBox
        '
        Me.EFTPaymentDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EFTPaymentDateTextBox.Location = New System.Drawing.Point(369, 83)
        Me.EFTPaymentDateTextBox.Name = "EFTPaymentDateTextBox"
        Me.EFTPaymentDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EFTPaymentDateTextBox.TabIndex = 52
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.ForeColor = System.Drawing.Color.Blue
        Me.Label50.Location = New System.Drawing.Point(470, 87)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(69, 13)
        Me.Label50.TabIndex = 51
        Me.Label50.Text = "*dd/mm/yyyy"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.ForeColor = System.Drawing.Color.Blue
        Me.Label91.Location = New System.Drawing.Point(225, 59)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(82, 13)
        Me.Label91.TabIndex = 50
        Me.Label91.Text = "*6-Digit BSB No"
        '
        'IsProcessedEFTCheckBox
        '
        Me.IsProcessedEFTCheckBox.AutoSize = True
        Me.IsProcessedEFTCheckBox.Location = New System.Drawing.Point(528, 35)
        Me.IsProcessedEFTCheckBox.Name = "IsProcessedEFTCheckBox"
        Me.IsProcessedEFTCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.IsProcessedEFTCheckBox.TabIndex = 49
        Me.IsProcessedEFTCheckBox.UseVisualStyleBackColor = True
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(369, 36)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(156, 13)
        Me.Label89.TabIndex = 48
        Me.Label89.Text = "Already Process This Payment?"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(125, 7)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(127, 15)
        Me.Label68.TabIndex = 46
        Me.Label68.Text = "EFT Payment Details"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(257, 85)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(97, 13)
        Me.Label67.TabIndex = 45
        Me.Label67.Text = "EFT Payment Date"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(366, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 13)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Settlement Amount ($)"
        '
        'AccountNameTextBox
        '
        Me.AccountNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AccountNameTextBox.Location = New System.Drawing.Point(125, 34)
        Me.AccountNameTextBox.Name = "AccountNameTextBox"
        Me.AccountNameTextBox.Size = New System.Drawing.Size(243, 20)
        Me.AccountNameTextBox.TabIndex = 39
        '
        'BSBNumberTextBox
        '
        Me.BSBNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BSBNumberTextBox.Location = New System.Drawing.Point(125, 59)
        Me.BSBNumberTextBox.Name = "BSBNumberTextBox"
        Me.BSBNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BSBNumberTextBox.TabIndex = 40
        '
        'AccountNameLabel
        '
        Me.AccountNameLabel.AutoSize = True
        Me.AccountNameLabel.Location = New System.Drawing.Point(16, 34)
        Me.AccountNameLabel.Name = "AccountNameLabel"
        Me.AccountNameLabel.Size = New System.Drawing.Size(78, 13)
        Me.AccountNameLabel.TabIndex = 38
        Me.AccountNameLabel.Text = "Account Name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(7, 82)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(87, 13)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Account Number"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(67, 59)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(28, 13)
        Me.Label43.TabIndex = 39
        Me.Label43.Text = "BSB"
        '
        'EFTPaymentAmountTextBox
        '
        Me.EFTPaymentAmountTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EFTPaymentAmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EFTPaymentAmountTextBox.Location = New System.Drawing.Point(482, 59)
        Me.EFTPaymentAmountTextBox.Name = "EFTPaymentAmountTextBox"
        Me.EFTPaymentAmountTextBox.ShortcutsEnabled = False
        Me.EFTPaymentAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EFTPaymentAmountTextBox.TabIndex = 41
        '
        'EFTAccountNumberTextBox
        '
        Me.EFTAccountNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EFTAccountNumberTextBox.Location = New System.Drawing.Point(125, 82)
        Me.EFTAccountNumberTextBox.Name = "EFTAccountNumberTextBox"
        Me.EFTAccountNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EFTAccountNumberTextBox.TabIndex = 42
        '
        'Panel18
        '
        Me.Panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel18.Controls.Add(Me.cla_IMEIDateTextBox)
        Me.Panel18.Controls.Add(Me.Label19)
        Me.Panel18.Controls.Add(Me.NewIMEINumberTextBox)
        Me.Panel18.Controls.Add(Me.NewIMEINumberLabel)
        Me.Panel18.Controls.Add(Me.Label36)
        Me.Panel18.Location = New System.Drawing.Point(612, 390)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(335, 98)
        Me.Panel18.TabIndex = 49
        '
        'cla_IMEIDateTextBox
        '
        Me.cla_IMEIDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cla_IMEIDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_IMEIDate", True))
        Me.cla_IMEIDateTextBox.Location = New System.Drawing.Point(146, 36)
        Me.cla_IMEIDateTextBox.Name = "cla_IMEIDateTextBox"
        Me.cla_IMEIDateTextBox.Size = New System.Drawing.Size(145, 20)
        Me.cla_IMEIDateTextBox.TabIndex = 50
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(594, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "NOTE: When entering a replacement IMEI and or SIM the IMEI/SIM date needs to be p" &
    "laced as the following business day.’"
        '
        'NewIMEINumberTextBox
        '
        Me.NewIMEINumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NewIMEINumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "NewIMEINumber", True))
        Me.NewIMEINumberTextBox.Location = New System.Drawing.Point(146, 10)
        Me.NewIMEINumberTextBox.Name = "NewIMEINumberTextBox"
        Me.NewIMEINumberTextBox.Size = New System.Drawing.Size(145, 20)
        Me.NewIMEINumberTextBox.TabIndex = 14
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(63, 39)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(77, 13)
        Me.Label36.TabIndex = 16
        Me.Label36.Text = "IMEI/Sim Date"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Cla_RepairConsignmentNoTextBox)
        Me.Panel3.Controls.Add(Me.Cla_RepairConsignmentNoLabel)
        Me.Panel3.Controls.Add(Me.Cla_SimCardNumberTextBox)
        Me.Panel3.Controls.Add(Me.Cla_SimCardNumberLabel)
        Me.Panel3.Location = New System.Drawing.Point(612, 306)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 73)
        Me.Panel3.TabIndex = 48
        '
        'Cla_RepairConsignmentNoTextBox
        '
        Me.Cla_RepairConsignmentNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairConsignmentNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_RepairConsignmentNo", True))
        Me.Cla_RepairConsignmentNoTextBox.Location = New System.Drawing.Point(146, 11)
        Me.Cla_RepairConsignmentNoTextBox.Name = "Cla_RepairConsignmentNoTextBox"
        Me.Cla_RepairConsignmentNoTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Cla_RepairConsignmentNoTextBox.TabIndex = 10
        '
        'Cla_SimCardNumberTextBox
        '
        Me.Cla_SimCardNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_SimCardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_SimCardNumber", True))
        Me.Cla_SimCardNumberTextBox.Location = New System.Drawing.Point(146, 41)
        Me.Cla_SimCardNumberTextBox.Name = "Cla_SimCardNumberTextBox"
        Me.Cla_SimCardNumberTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Cla_SimCardNumberTextBox.TabIndex = 12
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.CashSettleAmountTextBox)
        Me.Panel11.Controls.Add(Me.CashSettleAmountLabel)
        Me.Panel11.Controls.Add(Me.ExcessLabel)
        Me.Panel11.Controls.Add(Me.ExcessTextBox)
        Me.Panel11.Controls.Add(Me.Cla_ShortfallUpgradeCostLabel)
        Me.Panel11.Controls.Add(Me.Cla_ShortfallUpgradeCostTextBox)
        Me.Panel11.Controls.Add(Me.UnauthorisedCallsLabel)
        Me.Panel11.Controls.Add(Me.UnauthorisedCallsTextBox)
        Me.Panel11.Controls.Add(Me.Label35)
        Me.Panel11.Location = New System.Drawing.Point(612, 110)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(335, 186)
        Me.Panel11.TabIndex = 47
        '
        'CashSettleAmountTextBox
        '
        Me.CashSettleAmountTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CashSettleAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCashSettleAmount", True))
        Me.CashSettleAmountTextBox.Location = New System.Drawing.Point(206, 106)
        Me.CashSettleAmountTextBox.Name = "CashSettleAmountTextBox"
        Me.CashSettleAmountTextBox.Size = New System.Drawing.Size(85, 20)
        Me.CashSettleAmountTextBox.TabIndex = 7
        '
        'ExcessTextBox
        '
        Me.ExcessTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExcessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sExcess", True))
        Me.ExcessTextBox.Location = New System.Drawing.Point(146, 70)
        Me.ExcessTextBox.Name = "ExcessTextBox"
        Me.ExcessTextBox.Size = New System.Drawing.Size(145, 20)
        Me.ExcessTextBox.TabIndex = 5
        '
        'Cla_ShortfallUpgradeCostTextBox
        '
        Me.Cla_ShortfallUpgradeCostTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_ShortfallUpgradeCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_ShortfallUpgradeCost", True))
        Me.Cla_ShortfallUpgradeCostTextBox.Location = New System.Drawing.Point(146, 41)
        Me.Cla_ShortfallUpgradeCostTextBox.Name = "Cla_ShortfallUpgradeCostTextBox"
        Me.Cla_ShortfallUpgradeCostTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Cla_ShortfallUpgradeCostTextBox.TabIndex = 3
        '
        'UnauthorisedCallsTextBox
        '
        Me.UnauthorisedCallsTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnauthorisedCallsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sUnauthorisedCalls", True))
        Me.UnauthorisedCallsTextBox.Location = New System.Drawing.Point(146, 4)
        Me.UnauthorisedCallsTextBox.Name = "UnauthorisedCallsTextBox"
        Me.UnauthorisedCallsTextBox.Size = New System.Drawing.Size(145, 20)
        Me.UnauthorisedCallsTextBox.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(3, 145)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(313, 13)
        Me.Label35.TabIndex = 8
        Me.Label35.Text = "Note: This is the Amount displayed on the Cash Settlement Letter"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.RepairCostLabel)
        Me.Panel10.Controls.Add(Me.RepairCostTextBox)
        Me.Panel10.Controls.Add(Me.Cla_RepairerJobNoLabel)
        Me.Panel10.Controls.Add(Me.Cla_RepairerJobNoTextBox)
        Me.Panel10.Controls.Add(Me.RepairerLabel)
        Me.Panel10.Controls.Add(Me.RepairerComboBox)
        Me.Panel10.Location = New System.Drawing.Point(612, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(335, 99)
        Me.Panel10.TabIndex = 46
        '
        'RepairCostTextBox
        '
        Me.RepairCostTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.RepairCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sRepairCost", True))
        Me.RepairCostTextBox.Location = New System.Drawing.Point(146, 70)
        Me.RepairCostTextBox.Name = "RepairCostTextBox"
        Me.RepairCostTextBox.Size = New System.Drawing.Size(145, 20)
        Me.RepairCostTextBox.TabIndex = 5
        '
        'Cla_RepairerJobNoTextBox
        '
        Me.Cla_RepairerJobNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_RepairerJobNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_RepairerJobNo", True))
        Me.Cla_RepairerJobNoTextBox.Location = New System.Drawing.Point(146, 39)
        Me.Cla_RepairerJobNoTextBox.Name = "Cla_RepairerJobNoTextBox"
        Me.Cla_RepairerJobNoTextBox.Size = New System.Drawing.Size(145, 20)
        Me.Cla_RepairerJobNoTextBox.TabIndex = 3
        '
        'RepairerComboBox
        '
        Me.RepairerComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RepairerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "Repairer", True))
        Me.RepairerComboBox.FormattingEnabled = True
        Me.RepairerComboBox.Items.AddRange(New Object() {"", "Mobizone", "Digimob", "FMM", "FONEBIZ", "Roadhound"})
        Me.RepairerComboBox.Location = New System.Drawing.Point(146, 6)
        Me.RepairerComboBox.Name = "RepairerComboBox"
        Me.RepairerComboBox.Size = New System.Drawing.Size(145, 21)
        Me.RepairerComboBox.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.TextBox1)
        Me.Panel7.Controls.Add(Me.OPhoneLabel)
        Me.Panel7.Controls.Add(Me.OPhoneTextBox)
        Me.Panel7.Controls.Add(Me.OSupplierNameLabel)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.OSupplierNameTextBox)
        Me.Panel7.Controls.Add(Me.Label34)
        Me.Panel7.Controls.Add(Me.OUseSupplierLabel)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.OUseSupplierCheckBox)
        Me.Panel7.Controls.Add(Me.Cla_DoNotOrderLabel)
        Me.Panel7.Controls.Add(Me.Cla_DoNotOrderCheckBox)
        Me.Panel7.Controls.Add(Me.FreightCostTextBox)
        Me.Panel7.Controls.Add(Me.Cla_FreightCostTypeLabel)
        Me.Panel7.Controls.Add(Me.Cla_FreightCostTypeComboBox)
        Me.Panel7.Controls.Add(Me.Label33)
        Me.Panel7.Controls.Add(Me.Cla_ReplacePhoneRRPLabel)
        Me.Panel7.Controls.Add(Me.Cla_ReplacePhoneRRPTextBox)
        Me.Panel7.Controls.Add(Me.Cla_ReplacePhone_SuppliersCodeTextBox)
        Me.Panel7.Controls.Add(Me.ReplaceCostLabel)
        Me.Panel7.Controls.Add(Me.ReplaceCostTextBox)
        Me.Panel7.Controls.Add(Me.Cla_ReplacePhone_sup_idComboBox)
        Me.Panel7.Controls.Add(Me.ReplacePhoneIDMultiColumnCombo)
        Me.Panel7.Controls.Add(Me.Cla_ReplacePhone_sup_idLabel1)
        Me.Panel7.Controls.Add(Me.ReplacePhoneIDTextBox)
        Me.Panel7.Controls.Add(Me.Cla_ReplacePhone_sup_idLabel)
        Me.Panel7.Controls.Add(Me.Cla_ReplacePhone_sup_idTextBox)
        Me.Panel7.Controls.Add(Me.CurrentPhoneIDMultiColumnCombo)
        Me.Panel7.Controls.Add(Me.Label32)
        Me.Panel7.Controls.Add(Me.RepairReplaceCashIndicatorLabel)
        Me.Panel7.Controls.Add(Me.RepairReplaceCashIndicatorComboBox)
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(594, 291)
        Me.Panel7.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "ReplacementPhoneMakeModel", True))
        Me.TextBox1.Location = New System.Drawing.Point(202, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 28
        '
        'OPhoneTextBox
        '
        Me.OPhoneTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "oPhone", True))
        Me.OPhoneTextBox.Location = New System.Drawing.Point(171, 253)
        Me.OPhoneTextBox.Name = "OPhoneTextBox"
        Me.OPhoneTextBox.ReadOnly = True
        Me.OPhoneTextBox.Size = New System.Drawing.Size(237, 20)
        Me.OPhoneTextBox.TabIndex = 27
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Controls.Add(Me.AccOtherDescrTextBox)
        Me.Panel9.Controls.Add(Me.AccOtherTextBox)
        Me.Panel9.Controls.Add(Me.Cla_AccProductCodeTextBox)
        Me.Panel9.Controls.Add(Me.AccOtherDescrLabel)
        Me.Panel9.Controls.Add(Me.AccLeatherCaseLabel)
        Me.Panel9.Controls.Add(Me.Cla_AccProductCodeLabel)
        Me.Panel9.Controls.Add(Me.Cla_AccOtherProductCodeTextBox)
        Me.Panel9.Controls.Add(Me.AccLeatherCaseTextBox)
        Me.Panel9.Location = New System.Drawing.Point(232, 93)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(594, 100)
        Me.Panel9.TabIndex = 44
        Me.Panel9.Visible = False
        '
        'AccOtherDescrTextBox
        '
        Me.AccOtherDescrTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.AccOtherDescrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "AccOtherDescr", True))
        Me.AccOtherDescrTextBox.Location = New System.Drawing.Point(146, 10)
        Me.AccOtherDescrTextBox.Name = "AccOtherDescrTextBox"
        Me.AccOtherDescrTextBox.Size = New System.Drawing.Size(264, 20)
        Me.AccOtherDescrTextBox.TabIndex = 39
        '
        'AccOtherTextBox
        '
        Me.AccOtherTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.AccOtherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sAccOther", True))
        Me.AccOtherTextBox.Location = New System.Drawing.Point(252, 62)
        Me.AccOtherTextBox.Name = "AccOtherTextBox"
        Me.AccOtherTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccOtherTextBox.TabIndex = 43
        '
        'Cla_AccProductCodeTextBox
        '
        Me.Cla_AccProductCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_AccProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_AccProductCode", True))
        Me.Cla_AccProductCodeTextBox.Location = New System.Drawing.Point(146, 36)
        Me.Cla_AccProductCodeTextBox.Name = "Cla_AccProductCodeTextBox"
        Me.Cla_AccProductCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_AccProductCodeTextBox.TabIndex = 40
        '
        'Cla_AccOtherProductCodeTextBox
        '
        Me.Cla_AccOtherProductCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_AccOtherProductCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_AccOtherProductCode", True))
        Me.Cla_AccOtherProductCodeTextBox.Location = New System.Drawing.Point(252, 36)
        Me.Cla_AccOtherProductCodeTextBox.Name = "Cla_AccOtherProductCodeTextBox"
        Me.Cla_AccOtherProductCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_AccOtherProductCodeTextBox.TabIndex = 41
        '
        'AccLeatherCaseTextBox
        '
        Me.AccLeatherCaseTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.AccLeatherCaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sAccLeatherCase", True))
        Me.AccLeatherCaseTextBox.Location = New System.Drawing.Point(146, 62)
        Me.AccLeatherCaseTextBox.Name = "AccLeatherCaseTextBox"
        Me.AccLeatherCaseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccLeatherCaseTextBox.TabIndex = 42
        '
        'OSupplierNameTextBox
        '
        Me.OSupplierNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OSupplierNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "oSupplierName", True))
        Me.OSupplierNameTextBox.Location = New System.Drawing.Point(171, 227)
        Me.OSupplierNameTextBox.Name = "OSupplierNameTextBox"
        Me.OSupplierNameTextBox.ReadOnly = True
        Me.OSupplierNameTextBox.Size = New System.Drawing.Size(237, 20)
        Me.OSupplierNameTextBox.TabIndex = 25
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(25, 230)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(390, 15)
        Me.Label34.TabIndex = 28
        Me.Label34.Text = "Were there any Accessories stolen/lost/damaged with your phone?"
        Me.Label34.Visible = False
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.Panel19)
        Me.Panel8.Controls.Add(Me.Cla_SimCardPreviousFlagLabel)
        Me.Panel8.Controls.Add(Me.SimCardFlagLabel)
        Me.Panel8.Controls.Add(Me.Cla_SimCardPreviousFlagComboBox)
        Me.Panel8.Controls.Add(Me.SimCardFlagComboBox)
        Me.Panel8.Location = New System.Drawing.Point(277, 59)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(594, 162)
        Me.Panel8.TabIndex = 2
        Me.Panel8.Visible = False
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Cla_ReplaceSIMCard_SuppliersCodeTextBox)
        Me.Panel19.Controls.Add(Me.SimCardProductCodeTextBox)
        Me.Panel19.Controls.Add(Me.SimcardCostLabel)
        Me.Panel19.Controls.Add(Me.Cla_SimCardTypeComboBox)
        Me.Panel19.Controls.Add(Me.SimcardCostTextBox)
        Me.Panel19.Controls.Add(Me.Cla_SimCardTypeLabel)
        Me.Panel19.Controls.Add(Me.Cla_ReplaceSimCardIDComboBox)
        Me.Panel19.Controls.Add(Me.Cla_ReplaceSIMCard_sup_idLabel)
        Me.Panel19.Controls.Add(Me.Cla_ReplaceSIMCard_sup_idComboBox)
        Me.Panel19.Location = New System.Drawing.Point(15, 69)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(426, 88)
        Me.Panel19.TabIndex = 50
        Me.Panel19.Visible = False
        '
        'Cla_ReplaceSIMCard_SuppliersCodeTextBox
        '
        Me.Cla_ReplaceSIMCard_SuppliersCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_ReplaceSIMCard_SuppliersCode", True))
        Me.Cla_ReplaceSIMCard_SuppliersCodeTextBox.Location = New System.Drawing.Point(282, 60)
        Me.Cla_ReplaceSIMCard_SuppliersCodeTextBox.Name = "Cla_ReplaceSIMCard_SuppliersCodeTextBox"
        Me.Cla_ReplaceSIMCard_SuppliersCodeTextBox.ReadOnly = True
        Me.Cla_ReplaceSIMCard_SuppliersCodeTextBox.Size = New System.Drawing.Size(135, 20)
        Me.Cla_ReplaceSIMCard_SuppliersCodeTextBox.TabIndex = 38
        '
        'SimCardProductCodeTextBox
        '
        Me.SimCardProductCodeTextBox.Location = New System.Drawing.Point(282, 5)
        Me.SimCardProductCodeTextBox.Name = "SimCardProductCodeTextBox"
        Me.SimCardProductCodeTextBox.ReadOnly = True
        Me.SimCardProductCodeTextBox.Size = New System.Drawing.Size(135, 20)
        Me.SimCardProductCodeTextBox.TabIndex = 34
        '
        'Cla_SimCardTypeComboBox
        '
        Me.Cla_SimCardTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_SimCardType", True))
        Me.Cla_SimCardTypeComboBox.Enabled = False
        Me.Cla_SimCardTypeComboBox.FormattingEnabled = True
        Me.Cla_SimCardTypeComboBox.Location = New System.Drawing.Point(131, 5)
        Me.Cla_SimCardTypeComboBox.Name = "Cla_SimCardTypeComboBox"
        Me.Cla_SimCardTypeComboBox.Size = New System.Drawing.Size(145, 21)
        Me.Cla_SimCardTypeComboBox.TabIndex = 33
        '
        'SimcardCostTextBox
        '
        Me.SimcardCostTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SimcardCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sSimcardCost", True))
        Me.SimcardCostTextBox.Location = New System.Drawing.Point(131, 60)
        Me.SimcardCostTextBox.Name = "SimcardCostTextBox"
        Me.SimcardCostTextBox.Size = New System.Drawing.Size(145, 20)
        Me.SimcardCostTextBox.TabIndex = 37
        '
        'Cla_ReplaceSimCardIDComboBox
        '
        Me.Cla_ReplaceSimCardIDComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_ReplaceSimCardIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_ReplaceSimCardID", True))
        Me.Cla_ReplaceSimCardIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "cla_ReplaceSimCardID", True))
        Me.Cla_ReplaceSimCardIDComboBox.FormattingEnabled = True
        Me.Cla_ReplaceSimCardIDComboBox.Location = New System.Drawing.Point(282, 35)
        Me.Cla_ReplaceSimCardIDComboBox.Name = "Cla_ReplaceSimCardIDComboBox"
        Me.Cla_ReplaceSimCardIDComboBox.Size = New System.Drawing.Size(135, 21)
        Me.Cla_ReplaceSimCardIDComboBox.TabIndex = 36
        '
        'Cla_ReplaceSIMCard_sup_idComboBox
        '
        Me.Cla_ReplaceSIMCard_sup_idComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Cla_ReplaceSIMCard_sup_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "cla_ReplaceSIMCard_sup_id", True))
        Me.Cla_ReplaceSIMCard_sup_idComboBox.FormattingEnabled = True
        Me.Cla_ReplaceSIMCard_sup_idComboBox.Location = New System.Drawing.Point(131, 35)
        Me.Cla_ReplaceSIMCard_sup_idComboBox.Name = "Cla_ReplaceSIMCard_sup_idComboBox"
        Me.Cla_ReplaceSIMCard_sup_idComboBox.Size = New System.Drawing.Size(145, 21)
        Me.Cla_ReplaceSIMCard_sup_idComboBox.TabIndex = 35
        '
        'Cla_SimCardPreviousFlagComboBox
        '
        Me.Cla_SimCardPreviousFlagComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "Cla_SimCardPreviousFlag", True))
        Me.Cla_SimCardPreviousFlagComboBox.DataSource = Me.YesNoBindingSource
        Me.Cla_SimCardPreviousFlagComboBox.DisplayMember = "YesNo"
        Me.Cla_SimCardPreviousFlagComboBox.FormattingEnabled = True
        Me.Cla_SimCardPreviousFlagComboBox.Location = New System.Drawing.Point(146, 38)
        Me.Cla_SimCardPreviousFlagComboBox.Name = "Cla_SimCardPreviousFlagComboBox"
        Me.Cla_SimCardPreviousFlagComboBox.Size = New System.Drawing.Size(49, 21)
        Me.Cla_SimCardPreviousFlagComboBox.TabIndex = 32
        Me.Cla_SimCardPreviousFlagComboBox.ValueMember = "TrueFalse"
        Me.Cla_SimCardPreviousFlagComboBox.Visible = False
        '
        'SimCardFlagComboBox
        '
        Me.SimCardFlagComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "SimCardFlag", True))
        Me.SimCardFlagComboBox.DataSource = Me.YesNoBindingSource
        Me.SimCardFlagComboBox.DisplayMember = "YesNo"
        Me.SimCardFlagComboBox.FormattingEnabled = True
        Me.SimCardFlagComboBox.Location = New System.Drawing.Point(146, 11)
        Me.SimCardFlagComboBox.Name = "SimCardFlagComboBox"
        Me.SimCardFlagComboBox.Size = New System.Drawing.Size(49, 21)
        Me.SimCardFlagComboBox.TabIndex = 30
        Me.SimCardFlagComboBox.ValueMember = "TrueFalse"
        Me.SimCardFlagComboBox.Visible = False
        '
        'OUseSupplierCheckBox
        '
        Me.OUseSupplierCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OUseSupplierCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "oUseSupplier", True))
        Me.OUseSupplierCheckBox.Location = New System.Drawing.Point(9, 203)
        Me.OUseSupplierCheckBox.Name = "OUseSupplierCheckBox"
        Me.OUseSupplierCheckBox.Size = New System.Drawing.Size(29, 24)
        Me.OUseSupplierCheckBox.TabIndex = 23
        Me.OUseSupplierCheckBox.UseVisualStyleBackColor = False
        '
        'Cla_DoNotOrderCheckBox
        '
        Me.Cla_DoNotOrderCheckBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_DoNotOrderCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "cla_DoNotOrder", True))
        Me.Cla_DoNotOrderCheckBox.Location = New System.Drawing.Point(427, 170)
        Me.Cla_DoNotOrderCheckBox.Name = "Cla_DoNotOrderCheckBox"
        Me.Cla_DoNotOrderCheckBox.Size = New System.Drawing.Size(22, 24)
        Me.Cla_DoNotOrderCheckBox.TabIndex = 21
        Me.Cla_DoNotOrderCheckBox.UseVisualStyleBackColor = False
        '
        'FreightCostTextBox
        '
        Me.FreightCostTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FreightCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sFreightCost", True))
        Me.FreightCostTextBox.Location = New System.Drawing.Point(202, 172)
        Me.FreightCostTextBox.Name = "FreightCostTextBox"
        Me.FreightCostTextBox.ReadOnly = True
        Me.FreightCostTextBox.Size = New System.Drawing.Size(69, 20)
        Me.FreightCostTextBox.TabIndex = 20
        '
        'Cla_FreightCostTypeComboBox
        '
        Me.Cla_FreightCostTypeComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_FreightCostTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "Cla_FreightCostType", True))
        Me.Cla_FreightCostTypeComboBox.DataSource = Me.FreightCostTypeBindingSource
        Me.Cla_FreightCostTypeComboBox.DisplayMember = "FreightType"
        Me.Cla_FreightCostTypeComboBox.FormattingEnabled = True
        Me.Cla_FreightCostTypeComboBox.Location = New System.Drawing.Point(71, 172)
        Me.Cla_FreightCostTypeComboBox.Name = "Cla_FreightCostTypeComboBox"
        Me.Cla_FreightCostTypeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_FreightCostTypeComboBox.TabIndex = 12
        Me.Cla_FreightCostTypeComboBox.ValueMember = "FreightType"
        '
        'FreightCostTypeBindingSource
        '
        Me.FreightCostTypeBindingSource.DataSource = GetType(Risk.FreightCostType)
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(199, 152)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(213, 13)
        Me.Label33.TabIndex = 16
        Me.Label33.Text = "Note: Freight Costs Stored in Supplier Table"
        '
        'Cla_ReplacePhoneRRPTextBox
        '
        Me.Cla_ReplacePhoneRRPTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_ReplacePhoneRRPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_ReplacePhoneRRP", True))
        Me.Cla_ReplacePhoneRRPTextBox.Enabled = False
        Me.Cla_ReplacePhoneRRPTextBox.Location = New System.Drawing.Point(71, 149)
        Me.Cla_ReplacePhoneRRPTextBox.Name = "Cla_ReplacePhoneRRPTextBox"
        Me.Cla_ReplacePhoneRRPTextBox.ReadOnly = True
        Me.Cla_ReplacePhoneRRPTextBox.Size = New System.Drawing.Size(122, 20)
        Me.Cla_ReplacePhoneRRPTextBox.TabIndex = 15
        '
        'Cla_ReplacePhone_SuppliersCodeTextBox
        '
        Me.Cla_ReplacePhone_SuppliersCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_ReplacePhone_SuppliersCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_ReplacePhone_SuppliersCode", True))
        Me.Cla_ReplacePhone_SuppliersCodeTextBox.Location = New System.Drawing.Point(202, 125)
        Me.Cla_ReplacePhone_SuppliersCodeTextBox.Name = "Cla_ReplacePhone_SuppliersCodeTextBox"
        Me.Cla_ReplacePhone_SuppliersCodeTextBox.ReadOnly = True
        Me.Cla_ReplacePhone_SuppliersCodeTextBox.Size = New System.Drawing.Size(299, 20)
        Me.Cla_ReplacePhone_SuppliersCodeTextBox.TabIndex = 14
        '
        'ReplaceCostTextBox
        '
        Me.ReplaceCostTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReplaceCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sReplaceCost", True))
        Me.ReplaceCostTextBox.Enabled = False
        Me.ReplaceCostTextBox.Location = New System.Drawing.Point(71, 125)
        Me.ReplaceCostTextBox.Name = "ReplaceCostTextBox"
        Me.ReplaceCostTextBox.ReadOnly = True
        Me.ReplaceCostTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ReplaceCostTextBox.TabIndex = 13
        '
        'Cla_ReplacePhone_sup_idComboBox
        '
        Me.Cla_ReplacePhone_sup_idComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_ReplacePhone_sup_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "sCla_ReplacePhone_sup_id", True))
        Me.Cla_ReplacePhone_sup_idComboBox.DataSource = Me.ReplacementPhone_TSupplierBindingSource
        Me.Cla_ReplacePhone_sup_idComboBox.DisplayMember = "sup_Name"
        Me.Cla_ReplacePhone_sup_idComboBox.FormattingEnabled = True
        Me.Cla_ReplacePhone_sup_idComboBox.Location = New System.Drawing.Point(71, 99)
        Me.Cla_ReplacePhone_sup_idComboBox.Name = "Cla_ReplacePhone_sup_idComboBox"
        Me.Cla_ReplacePhone_sup_idComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_ReplacePhone_sup_idComboBox.TabIndex = 10
        Me.Cla_ReplacePhone_sup_idComboBox.ValueMember = "sSup_id"
        '
        'ReplacementPhone_TSupplierBindingSource
        '
        Me.ReplacementPhone_TSupplierBindingSource.DataSource = GetType(Risk.Supplier)
        '
        'ReplacePhoneIDMultiColumnCombo
        '
        Me.ReplacePhoneIDMultiColumnCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReplacePhoneIDMultiColumnCombo.ColumnWidths = "200;75;75;150;50;20;100"
        Me.ReplacePhoneIDMultiColumnCombo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "sReplacePhoneID", True))
        Me.ReplacePhoneIDMultiColumnCombo.DataSource = Me.PhonePriceBindingSource
        Me.ReplacePhoneIDMultiColumnCombo.DisplayMember = "PhDesc1"
        Me.ReplacePhoneIDMultiColumnCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ReplacePhoneIDMultiColumnCombo.DropDownWidth = 680
        Me.ReplacePhoneIDMultiColumnCombo.FormattingEnabled = True
        Me.ReplacePhoneIDMultiColumnCombo.Location = New System.Drawing.Point(202, 99)
        Me.ReplacePhoneIDMultiColumnCombo.Name = "ReplacePhoneIDMultiColumnCombo"
        Me.ReplacePhoneIDMultiColumnCombo.Size = New System.Drawing.Size(299, 21)
        Me.ReplacePhoneIDMultiColumnCombo.TabIndex = 11
        Me.ReplacePhoneIDMultiColumnCombo.ValueMember = "sPhoneID"
        '
        'PhonePriceBindingSource
        '
        Me.PhonePriceBindingSource.DataMember = "SupplierPhones"
        Me.PhonePriceBindingSource.DataSource = Me.TblClaimBindingSource
        '
        'ReplacePhoneIDTextBox
        '
        Me.ReplacePhoneIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ReplacePhoneIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "ReplacePhoneID", True))
        Me.ReplacePhoneIDTextBox.Location = New System.Drawing.Point(456, 70)
        Me.ReplacePhoneIDTextBox.Name = "ReplacePhoneIDTextBox"
        Me.ReplacePhoneIDTextBox.ReadOnly = True
        Me.ReplacePhoneIDTextBox.Size = New System.Drawing.Size(45, 20)
        Me.ReplacePhoneIDTextBox.TabIndex = 7
        '
        'Cla_ReplacePhone_sup_idTextBox
        '
        Me.Cla_ReplacePhone_sup_idTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_ReplacePhone_sup_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_ReplacePhone_sup_id", True))
        Me.Cla_ReplacePhone_sup_idTextBox.Location = New System.Drawing.Point(155, 70)
        Me.Cla_ReplacePhone_sup_idTextBox.Name = "Cla_ReplacePhone_sup_idTextBox"
        Me.Cla_ReplacePhone_sup_idTextBox.ReadOnly = True
        Me.Cla_ReplacePhone_sup_idTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Cla_ReplacePhone_sup_idTextBox.TabIndex = 5
        '
        'CurrentPhoneIDMultiColumnCombo
        '
        Me.CurrentPhoneIDMultiColumnCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CurrentPhoneIDMultiColumnCombo.ColumnWidths = "150;200;150"
        Me.CurrentPhoneIDMultiColumnCombo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "sCurrentPhoneID", True))
        Me.CurrentPhoneIDMultiColumnCombo.DataSource = Me.Current_TblPhoneBindingSource
        Me.CurrentPhoneIDMultiColumnCombo.DisplayMember = "PhDesc"
        Me.CurrentPhoneIDMultiColumnCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CurrentPhoneIDMultiColumnCombo.DropDownWidth = 510
        Me.CurrentPhoneIDMultiColumnCombo.FormattingEnabled = True
        Me.CurrentPhoneIDMultiColumnCombo.Location = New System.Drawing.Point(230, 39)
        Me.CurrentPhoneIDMultiColumnCombo.Name = "CurrentPhoneIDMultiColumnCombo"
        Me.CurrentPhoneIDMultiColumnCombo.Size = New System.Drawing.Size(271, 21)
        Me.CurrentPhoneIDMultiColumnCombo.TabIndex = 4
        Me.CurrentPhoneIDMultiColumnCombo.ValueMember = "sPhoneID"
        '
        'Current_TblPhoneBindingSource
        '
        Me.Current_TblPhoneBindingSource.DataSource = GetType(Risk.Phone)
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(5, 34)
        Me.Label32.MaximumSize = New System.Drawing.Size(200, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(187, 26)
        Me.Label32.TabIndex = 3
        Me.Label32.Text = "What was the make and model of the phone that was lost/stolen/damaged?"
        '
        'RepairReplaceCashIndicatorComboBox
        '
        Me.RepairReplaceCashIndicatorComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.RepairReplaceCashIndicatorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "RepairReplaceCashIndicator", True))
        Me.RepairReplaceCashIndicatorComboBox.FormattingEnabled = True
        Me.RepairReplaceCashIndicatorComboBox.Items.AddRange(New Object() {"", "Replace", "Repair", "RepairRep", "Cash", "Refurbished"})
        Me.RepairReplaceCashIndicatorComboBox.Location = New System.Drawing.Point(333, 6)
        Me.RepairReplaceCashIndicatorComboBox.Name = "RepairReplaceCashIndicatorComboBox"
        Me.RepairReplaceCashIndicatorComboBox.Size = New System.Drawing.Size(168, 21)
        Me.RepairReplaceCashIndicatorComboBox.TabIndex = 2
        '
        'DeclarationAndNotesTabPage
        '
        Me.DeclarationAndNotesTabPage.AutoScroll = True
        Me.DeclarationAndNotesTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.LetterRec_IPhoneDamageLabel)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.LetterRec_IPhoneDamageTextBox)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.AddNewNotationButton)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.TblClaimNoteDataGridView)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.Label42)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.LetterRec_DamagedLabel)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.LetterRec_DamagedTextBox)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.LetterRec_IMEILabel)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.LetterRec_IMEITextBox)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.Label41)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.DiaryEntryTextBox)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.DiaryDateTextBox)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.Label40)
        Me.DeclarationAndNotesTabPage.Controls.Add(Me.Panel13)
        Me.DeclarationAndNotesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DeclarationAndNotesTabPage.Name = "DeclarationAndNotesTabPage"
        Me.DeclarationAndNotesTabPage.Size = New System.Drawing.Size(1105, 644)
        Me.DeclarationAndNotesTabPage.TabIndex = 3
        Me.DeclarationAndNotesTabPage.Text = "Declaration and Notes"
        '
        'LetterRec_IPhoneDamageTextBox
        '
        Me.LetterRec_IPhoneDamageTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LetterRec_IPhoneDamageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sletterRec_IPhoneDamage", True))
        Me.LetterRec_IPhoneDamageTextBox.Location = New System.Drawing.Point(853, 232)
        Me.LetterRec_IPhoneDamageTextBox.Name = "LetterRec_IPhoneDamageTextBox"
        Me.LetterRec_IPhoneDamageTextBox.Size = New System.Drawing.Size(82, 20)
        Me.LetterRec_IPhoneDamageTextBox.TabIndex = 41
        '
        'AddNewNotationButton
        '
        Me.AddNewNotationButton.Location = New System.Drawing.Point(659, 324)
        Me.AddNewNotationButton.Name = "AddNewNotationButton"
        Me.AddNewNotationButton.Size = New System.Drawing.Size(110, 23)
        Me.AddNewNotationButton.TabIndex = 40
        Me.AddNewNotationButton.Text = "Add New Notation"
        Me.AddNewNotationButton.UseVisualStyleBackColor = True
        '
        'TblClaimNoteDataGridView
        '
        Me.TblClaimNoteDataGridView.AllowUserToAddRows = False
        Me.TblClaimNoteDataGridView.AllowUserToDeleteRows = False
        Me.TblClaimNoteDataGridView.AllowUserToOrderColumns = True
        Me.TblClaimNoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblClaimNoteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoteType, Me.Edit, Me.Note, Me.TextNoteID, Me.DateAdded})
        Me.TblClaimNoteDataGridView.Location = New System.Drawing.Point(20, 353)
        Me.TblClaimNoteDataGridView.Name = "TblClaimNoteDataGridView"
        Me.TblClaimNoteDataGridView.ReadOnly = True
        Me.TblClaimNoteDataGridView.RowTemplate.Height = 50
        Me.TblClaimNoteDataGridView.Size = New System.Drawing.Size(905, 220)
        Me.TblClaimNoteDataGridView.TabIndex = 39
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(20, 321)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(70, 15)
        Me.Label42.TabIndex = 35
        Me.Label42.Text = "Claim Note"
        '
        'LetterRec_DamagedTextBox
        '
        Me.LetterRec_DamagedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LetterRec_DamagedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sLetterRec_Damaged", True))
        Me.LetterRec_DamagedTextBox.Location = New System.Drawing.Point(853, 281)
        Me.LetterRec_DamagedTextBox.Name = "LetterRec_DamagedTextBox"
        Me.LetterRec_DamagedTextBox.Size = New System.Drawing.Size(82, 20)
        Me.LetterRec_DamagedTextBox.TabIndex = 34
        '
        'LetterRec_IMEITextBox
        '
        Me.LetterRec_IMEITextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LetterRec_IMEITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sLetterRec_IMEI", True))
        Me.LetterRec_IMEITextBox.Location = New System.Drawing.Point(853, 255)
        Me.LetterRec_IMEITextBox.Name = "LetterRec_IMEITextBox"
        Me.LetterRec_IMEITextBox.Size = New System.Drawing.Size(82, 20)
        Me.LetterRec_IMEITextBox.TabIndex = 33
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(106, 235)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(71, 15)
        Me.Label41.TabIndex = 32
        Me.Label41.Text = "Diary Entry"
        '
        'DiaryEntryTextBox
        '
        Me.DiaryEntryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "DiaryEntry", True))
        Me.DiaryEntryTextBox.Location = New System.Drawing.Point(106, 255)
        Me.DiaryEntryTextBox.Multiline = True
        Me.DiaryEntryTextBox.Name = "DiaryEntryTextBox"
        Me.DiaryEntryTextBox.Size = New System.Drawing.Size(608, 46)
        Me.DiaryEntryTextBox.TabIndex = 31
        '
        'DiaryDateTextBox
        '
        Me.DiaryDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sDiaryDate", True))
        Me.DiaryDateTextBox.Location = New System.Drawing.Point(20, 255)
        Me.DiaryDateTextBox.Name = "DiaryDateTextBox"
        Me.DiaryDateTextBox.Size = New System.Drawing.Size(69, 20)
        Me.DiaryDateTextBox.TabIndex = 30
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(20, 235)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(69, 15)
        Me.Label40.TabIndex = 29
        Me.Label40.Text = "Diary Date"
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label2)
        Me.Panel13.Controls.Add(Me.txtCancelled)
        Me.Panel13.Controls.Add(Me.CorrectInfoFlagComboBox)
        Me.Panel13.Controls.Add(Me.Label39)
        Me.Panel13.Controls.Add(Me.Panel12)
        Me.Panel13.Location = New System.Drawing.Point(18, 3)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(933, 223)
        Me.Panel13.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(685, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Insurance Cancelled"
        '
        'txtCancelled
        '
        Me.txtCancelled.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCancelled.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sletterRec_IPhoneDamage", True))
        Me.txtCancelled.Location = New System.Drawing.Point(835, 207)
        Me.txtCancelled.Name = "txtCancelled"
        Me.txtCancelled.Size = New System.Drawing.Size(82, 20)
        Me.txtCancelled.TabIndex = 45
        '
        'CorrectInfoFlagComboBox
        '
        Me.CorrectInfoFlagComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CorrectInfoFlagComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblClaimBindingSource, "CorrectInfoFlag", True))
        Me.CorrectInfoFlagComboBox.DataSource = Me.YesNoBindingSource
        Me.CorrectInfoFlagComboBox.DisplayMember = "YesNo"
        Me.CorrectInfoFlagComboBox.FormattingEnabled = True
        Me.CorrectInfoFlagComboBox.Location = New System.Drawing.Point(387, 186)
        Me.CorrectInfoFlagComboBox.Name = "CorrectInfoFlagComboBox"
        Me.CorrectInfoFlagComboBox.Size = New System.Drawing.Size(60, 21)
        Me.CorrectInfoFlagComboBox.TabIndex = 4
        Me.CorrectInfoFlagComboBox.ValueMember = "TrueFalse"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(14, 167)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(486, 40)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "Has the customer accepted the above legal declaration and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " confirmed the claim d" &
    "escription is correct?’"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Label21)
        Me.Panel12.Controls.Add(Me.Label37)
        Me.Panel12.Location = New System.Drawing.Point(18, 5)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(889, 168)
        Me.Panel12.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(66, 9)
        Me.Label21.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(636, 20)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Do you declare that the information you have supplied is true in every respect?"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(66, 38)
        Me.Label37.MaximumSize = New System.Drawing.Size(750, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(746, 120)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = resources.GetString("Label37.Text")
        '
        'PaymentsTabPage
        '
        Me.PaymentsTabPage.AutoScroll = True
        Me.PaymentsTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.PaymentsTabPage.Controls.Add(Me.TotalTextBox)
        Me.PaymentsTabPage.Controls.Add(Me.TotalLabel)
        Me.PaymentsTabPage.Controls.Add(Me.CashSettleAmountLabel1)
        Me.PaymentsTabPage.Controls.Add(Me.CashSettleAmountTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.AccOtherLabel)
        Me.PaymentsTabPage.Controls.Add(Me.AccOtherTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.ReplaceVarianceCostLabel1)
        Me.PaymentsTabPage.Controls.Add(Me.ReplaceVarianceCostTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.Cla_ShortfallUpgradeCostLabel1)
        Me.PaymentsTabPage.Controls.Add(Me.Cla_ShortfallUpgradeCostTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.UnauthorisedCallsLabel1)
        Me.PaymentsTabPage.Controls.Add(Me.UnauthorisedCallsTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.ReplaceCostLabel2)
        Me.PaymentsTabPage.Controls.Add(Me.ReplaceCostTextBox2)
        Me.PaymentsTabPage.Controls.Add(Me.SimcardCostLabel1)
        Me.PaymentsTabPage.Controls.Add(Me.SimcardCostTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.AccLeatherCaseLabel1)
        Me.PaymentsTabPage.Controls.Add(Me.AccLeatherCaseTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.FreightCostLabel)
        Me.PaymentsTabPage.Controls.Add(Me.FreightCostTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.ReplaceCostLabel1)
        Me.PaymentsTabPage.Controls.Add(Me.ReplaceCostTextBox1)
        Me.PaymentsTabPage.Controls.Add(Me.Panel17)
        Me.PaymentsTabPage.Controls.Add(Me.Panel15)
        Me.PaymentsTabPage.Controls.Add(Me.Panel14)
        Me.PaymentsTabPage.Controls.Add(Me.Label49)
        Me.PaymentsTabPage.Controls.Add(Me.Label48)
        Me.PaymentsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.PaymentsTabPage.Name = "PaymentsTabPage"
        Me.PaymentsTabPage.Size = New System.Drawing.Size(1105, 644)
        Me.PaymentsTabPage.TabIndex = 4
        Me.PaymentsTabPage.Text = "Payments"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sTotalClaimCostIncGST", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(1079, 274)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 39
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(963, 277)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(110, 13)
        Me.TotalLabel.TabIndex = 38
        Me.TotalLabel.Text = "Total (GST Inclusive):"
        '
        'CashSettleAmountTextBox1
        '
        Me.CashSettleAmountTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCashSettleAmount", True))
        Me.CashSettleAmountTextBox1.Location = New System.Drawing.Point(1079, 248)
        Me.CashSettleAmountTextBox1.Name = "CashSettleAmountTextBox1"
        Me.CashSettleAmountTextBox1.ReadOnly = True
        Me.CashSettleAmountTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CashSettleAmountTextBox1.TabIndex = 37
        '
        'AccOtherTextBox1
        '
        Me.AccOtherTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sAccOther", True))
        Me.AccOtherTextBox1.Location = New System.Drawing.Point(1079, 222)
        Me.AccOtherTextBox1.Name = "AccOtherTextBox1"
        Me.AccOtherTextBox1.ReadOnly = True
        Me.AccOtherTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.AccOtherTextBox1.TabIndex = 36
        '
        'ReplaceVarianceCostTextBox1
        '
        Me.ReplaceVarianceCostTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sReplaceVarianceCost", True))
        Me.ReplaceVarianceCostTextBox1.Location = New System.Drawing.Point(1079, 196)
        Me.ReplaceVarianceCostTextBox1.Name = "ReplaceVarianceCostTextBox1"
        Me.ReplaceVarianceCostTextBox1.ReadOnly = True
        Me.ReplaceVarianceCostTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ReplaceVarianceCostTextBox1.TabIndex = 35
        '
        'Cla_ShortfallUpgradeCostTextBox1
        '
        Me.Cla_ShortfallUpgradeCostTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_ShortfallUpgradeCost", True))
        Me.Cla_ShortfallUpgradeCostTextBox1.Location = New System.Drawing.Point(1079, 171)
        Me.Cla_ShortfallUpgradeCostTextBox1.Name = "Cla_ShortfallUpgradeCostTextBox1"
        Me.Cla_ShortfallUpgradeCostTextBox1.ReadOnly = True
        Me.Cla_ShortfallUpgradeCostTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Cla_ShortfallUpgradeCostTextBox1.TabIndex = 34
        '
        'UnauthorisedCallsTextBox1
        '
        Me.UnauthorisedCallsTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sUnauthorisedCalls", True))
        Me.UnauthorisedCallsTextBox1.Location = New System.Drawing.Point(1079, 145)
        Me.UnauthorisedCallsTextBox1.Name = "UnauthorisedCallsTextBox1"
        Me.UnauthorisedCallsTextBox1.ReadOnly = True
        Me.UnauthorisedCallsTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.UnauthorisedCallsTextBox1.TabIndex = 33
        '
        'ReplaceCostTextBox2
        '
        Me.ReplaceCostTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sReplaceCost", True))
        Me.ReplaceCostTextBox2.Location = New System.Drawing.Point(1079, 120)
        Me.ReplaceCostTextBox2.Name = "ReplaceCostTextBox2"
        Me.ReplaceCostTextBox2.ReadOnly = True
        Me.ReplaceCostTextBox2.Size = New System.Drawing.Size(100, 20)
        Me.ReplaceCostTextBox2.TabIndex = 32
        '
        'SimcardCostTextBox1
        '
        Me.SimcardCostTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sSimcardCost", True))
        Me.SimcardCostTextBox1.Location = New System.Drawing.Point(1079, 94)
        Me.SimcardCostTextBox1.Name = "SimcardCostTextBox1"
        Me.SimcardCostTextBox1.ReadOnly = True
        Me.SimcardCostTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SimcardCostTextBox1.TabIndex = 31
        '
        'AccLeatherCaseTextBox1
        '
        Me.AccLeatherCaseTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sAccLeatherCase", True))
        Me.AccLeatherCaseTextBox1.Location = New System.Drawing.Point(1079, 68)
        Me.AccLeatherCaseTextBox1.Name = "AccLeatherCaseTextBox1"
        Me.AccLeatherCaseTextBox1.ReadOnly = True
        Me.AccLeatherCaseTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.AccLeatherCaseTextBox1.TabIndex = 30
        '
        'FreightCostTextBox1
        '
        Me.FreightCostTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sFreightCost", True))
        Me.FreightCostTextBox1.Location = New System.Drawing.Point(1079, 42)
        Me.FreightCostTextBox1.Name = "FreightCostTextBox1"
        Me.FreightCostTextBox1.ReadOnly = True
        Me.FreightCostTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.FreightCostTextBox1.TabIndex = 29
        '
        'ReplaceCostTextBox1
        '
        Me.ReplaceCostTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sReplaceCost", True))
        Me.ReplaceCostTextBox1.Location = New System.Drawing.Point(1079, 16)
        Me.ReplaceCostTextBox1.Name = "ReplaceCostTextBox1"
        Me.ReplaceCostTextBox1.ReadOnly = True
        Me.ReplaceCostTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ReplaceCostTextBox1.TabIndex = 28
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Cla_OtherPaidToDate2TextBox)
        Me.Panel17.Controls.Add(Me.Cla_RepairerPaidToDate2TextBox)
        Me.Panel17.Controls.Add(Me.sCla_OtherPaidToDateTextBox)
        Me.Panel17.Controls.Add(Me.Cla_RepairerPaidToDateTextBox)
        Me.Panel17.Controls.Add(Me.Cla_SimCardPaidToDateTextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidDate4TextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidDate3TextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidDate2TextBox)
        Me.Panel17.Controls.Add(Me.PaidStatusDateTextBox)
        Me.Panel17.Controls.Add(Me.Label63)
        Me.Panel17.Controls.Add(Me.Label59)
        Me.Panel17.Controls.Add(Me.Label60)
        Me.Panel17.Controls.Add(Me.Label61)
        Me.Panel17.Controls.Add(Me.Label62)
        Me.Panel17.Controls.Add(Me.Label57)
        Me.Panel17.Controls.Add(Me.Label58)
        Me.Panel17.Controls.Add(Me.Label56)
        Me.Panel17.Controls.Add(Me.Label55)
        Me.Panel17.Controls.Add(Me.Cla_OutstandingAmountLabel)
        Me.Panel17.Controls.Add(Me.Cla_OutstandingAmountTextBox)
        Me.Panel17.Controls.Add(Me.Cla_OtherInvoiceNo2AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_RepairerInvoiceNo2AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_OtherInvoiceNo2TextBox)
        Me.Panel17.Controls.Add(Me.Cla_RepairerInvoiceNo2TextBox)
        Me.Panel17.Controls.Add(Me.Cla_OtherPaidTo2ComboBox)
        Me.Panel17.Controls.Add(Me.Cla_OtherPaidTo2Label)
        Me.Panel17.Controls.Add(Me.Cla_RepairerPaidTo2Label)
        Me.Panel17.Controls.Add(Me.Cla_RepairerPaidTo2ComboBox)
        Me.Panel17.Controls.Add(Me.Cla_PaidBalanceTextBox)
        Me.Panel17.Controls.Add(Me.Cla_PaidBalanceLabel)
        Me.Panel17.Controls.Add(Me.Cla_OtherInvoiceNo1AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_RepairerInvoiceNo1AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_SimCardInvoiceNo1AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_OtherInvoiceNo1TextBox)
        Me.Panel17.Controls.Add(Me.Cla_RepairerInvoiceNo1TextBox)
        Me.Panel17.Controls.Add(Me.Cla_SimCardInvoiceNo1TextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesInvoiceNo4AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesInvoiceNo3AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesInvoiceNo2AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesInvoiceNo1AmtTextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesInvoiceNo4TextBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesInvoiceNo3TextBox)
        Me.Panel17.Controls.Add(Me.Cla_InvoiceNo2TextBox)
        Me.Panel17.Controls.Add(Me.Cla_InvoiceNo1TextBox)
        Me.Panel17.Controls.Add(Me.Label54)
        Me.Panel17.Controls.Add(Me.Cla_PaidFullLabel)
        Me.Panel17.Controls.Add(Me.Cla_PaidFullComboBox)
        Me.Panel17.Controls.Add(Me.Cla_OtherPaidToLabel)
        Me.Panel17.Controls.Add(Me.Cla_OtherPaidToComboBox)
        Me.Panel17.Controls.Add(Me.Cla_RepairerPaidToLabel)
        Me.Panel17.Controls.Add(Me.Cla_RepairerPaidToComboBox)
        Me.Panel17.Controls.Add(Me.Cla_SimCardPaidToLabel)
        Me.Panel17.Controls.Add(Me.Cla_SimCardPaidToComboBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidToLabel)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidToComboBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidTo4Label)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidTo4ComboBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidTo3Label)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidTo3ComboBox)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidTo2Label)
        Me.Panel17.Controls.Add(Me.Cla_PhoneAccessoriesPaidTo2ComboBox)
        Me.Panel17.Location = New System.Drawing.Point(28, 312)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(1078, 326)
        Me.Panel17.TabIndex = 27
        '
        'Cla_OtherPaidToDate2TextBox
        '
        Me.Cla_OtherPaidToDate2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_OtherPaidToDate2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_OtherPaidToDate2", True))
        Me.Cla_OtherPaidToDate2TextBox.Location = New System.Drawing.Point(741, 201)
        Me.Cla_OtherPaidToDate2TextBox.Name = "Cla_OtherPaidToDate2TextBox"
        Me.Cla_OtherPaidToDate2TextBox.Size = New System.Drawing.Size(94, 20)
        Me.Cla_OtherPaidToDate2TextBox.TabIndex = 91
        '
        'Cla_RepairerPaidToDate2TextBox
        '
        Me.Cla_RepairerPaidToDate2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairerPaidToDate2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_RepairerPaidToDate2", True))
        Me.Cla_RepairerPaidToDate2TextBox.Location = New System.Drawing.Point(740, 170)
        Me.Cla_RepairerPaidToDate2TextBox.Name = "Cla_RepairerPaidToDate2TextBox"
        Me.Cla_RepairerPaidToDate2TextBox.Size = New System.Drawing.Size(94, 20)
        Me.Cla_RepairerPaidToDate2TextBox.TabIndex = 90
        '
        'sCla_OtherPaidToDateTextBox
        '
        Me.sCla_OtherPaidToDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.sCla_OtherPaidToDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_OtherPaidToDate", True))
        Me.sCla_OtherPaidToDateTextBox.Location = New System.Drawing.Point(232, 201)
        Me.sCla_OtherPaidToDateTextBox.Name = "sCla_OtherPaidToDateTextBox"
        Me.sCla_OtherPaidToDateTextBox.Size = New System.Drawing.Size(94, 20)
        Me.sCla_OtherPaidToDateTextBox.TabIndex = 89
        '
        'Cla_RepairerPaidToDateTextBox
        '
        Me.Cla_RepairerPaidToDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairerPaidToDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_RepairerPaidToDate", True))
        Me.Cla_RepairerPaidToDateTextBox.Location = New System.Drawing.Point(232, 170)
        Me.Cla_RepairerPaidToDateTextBox.Name = "Cla_RepairerPaidToDateTextBox"
        Me.Cla_RepairerPaidToDateTextBox.Size = New System.Drawing.Size(94, 20)
        Me.Cla_RepairerPaidToDateTextBox.TabIndex = 88
        '
        'Cla_SimCardPaidToDateTextBox
        '
        Me.Cla_SimCardPaidToDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_SimCardPaidToDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_SimCardPaidToDate", True))
        Me.Cla_SimCardPaidToDateTextBox.Location = New System.Drawing.Point(232, 142)
        Me.Cla_SimCardPaidToDateTextBox.Name = "Cla_SimCardPaidToDateTextBox"
        Me.Cla_SimCardPaidToDateTextBox.Size = New System.Drawing.Size(94, 20)
        Me.Cla_SimCardPaidToDateTextBox.TabIndex = 87
        '
        'Cla_PhoneAccessoriesPaidDate4TextBox
        '
        Me.Cla_PhoneAccessoriesPaidDate4TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesPaidDate4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_PhoneAccessoriesPaidDate4", True))
        Me.Cla_PhoneAccessoriesPaidDate4TextBox.Location = New System.Drawing.Point(232, 113)
        Me.Cla_PhoneAccessoriesPaidDate4TextBox.Name = "Cla_PhoneAccessoriesPaidDate4TextBox"
        Me.Cla_PhoneAccessoriesPaidDate4TextBox.Size = New System.Drawing.Size(94, 20)
        Me.Cla_PhoneAccessoriesPaidDate4TextBox.TabIndex = 86
        '
        'Cla_PhoneAccessoriesPaidDate3TextBox
        '
        Me.Cla_PhoneAccessoriesPaidDate3TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesPaidDate3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_PhoneAccessoriesPaidDate3", True))
        Me.Cla_PhoneAccessoriesPaidDate3TextBox.Location = New System.Drawing.Point(232, 85)
        Me.Cla_PhoneAccessoriesPaidDate3TextBox.Name = "Cla_PhoneAccessoriesPaidDate3TextBox"
        Me.Cla_PhoneAccessoriesPaidDate3TextBox.Size = New System.Drawing.Size(94, 20)
        Me.Cla_PhoneAccessoriesPaidDate3TextBox.TabIndex = 85
        '
        'Cla_PhoneAccessoriesPaidDate2TextBox
        '
        Me.Cla_PhoneAccessoriesPaidDate2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesPaidDate2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_PhoneAccessoriesPaidDate2", True))
        Me.Cla_PhoneAccessoriesPaidDate2TextBox.Location = New System.Drawing.Point(232, 56)
        Me.Cla_PhoneAccessoriesPaidDate2TextBox.Name = "Cla_PhoneAccessoriesPaidDate2TextBox"
        Me.Cla_PhoneAccessoriesPaidDate2TextBox.Size = New System.Drawing.Size(94, 20)
        Me.Cla_PhoneAccessoriesPaidDate2TextBox.TabIndex = 84
        '
        'PaidStatusDateTextBox
        '
        Me.PaidStatusDateTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PaidStatusDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sPaidStatusDate", True))
        Me.PaidStatusDateTextBox.Location = New System.Drawing.Point(232, 27)
        Me.PaidStatusDateTextBox.Name = "PaidStatusDateTextBox"
        Me.PaidStatusDateTextBox.Size = New System.Drawing.Size(94, 20)
        Me.PaidStatusDateTextBox.TabIndex = 83
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Red
        Me.Label63.Location = New System.Drawing.Point(856, 280)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(174, 13)
        Me.Label63.TabIndex = 82
        Me.Label63.Text = "NEVER TYPE IN THIS FIELD"
        Me.Label63.Visible = False
        '
        'Cla_OutstandingAmountTextBox
        '
        Me.Cla_OutstandingAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_OutstandingAmount", True))
        Me.Cla_OutstandingAmountTextBox.Enabled = False
        Me.Cla_OutstandingAmountTextBox.Location = New System.Drawing.Point(954, 253)
        Me.Cla_OutstandingAmountTextBox.Name = "Cla_OutstandingAmountTextBox"
        Me.Cla_OutstandingAmountTextBox.ReadOnly = True
        Me.Cla_OutstandingAmountTextBox.Size = New System.Drawing.Size(73, 20)
        Me.Cla_OutstandingAmountTextBox.TabIndex = 65
        '
        'Cla_OtherInvoiceNo2AmtTextBox
        '
        Me.Cla_OtherInvoiceNo2AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_OtherInvoiceNo2AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_OtherInvoiceNo2Amt", True))
        Me.Cla_OtherInvoiceNo2AmtTextBox.Location = New System.Drawing.Point(950, 201)
        Me.Cla_OtherInvoiceNo2AmtTextBox.Name = "Cla_OtherInvoiceNo2AmtTextBox"
        Me.Cla_OtherInvoiceNo2AmtTextBox.Size = New System.Drawing.Size(71, 20)
        Me.Cla_OtherInvoiceNo2AmtTextBox.TabIndex = 64
        '
        'Cla_RepairerInvoiceNo2AmtTextBox
        '
        Me.Cla_RepairerInvoiceNo2AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairerInvoiceNo2AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_RepairerInvoiceNo2Amt", True))
        Me.Cla_RepairerInvoiceNo2AmtTextBox.Location = New System.Drawing.Point(950, 170)
        Me.Cla_RepairerInvoiceNo2AmtTextBox.Name = "Cla_RepairerInvoiceNo2AmtTextBox"
        Me.Cla_RepairerInvoiceNo2AmtTextBox.Size = New System.Drawing.Size(71, 20)
        Me.Cla_RepairerInvoiceNo2AmtTextBox.TabIndex = 63
        '
        'Cla_OtherInvoiceNo2TextBox
        '
        Me.Cla_OtherInvoiceNo2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_OtherInvoiceNo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_OtherInvoiceNo2", True))
        Me.Cla_OtherInvoiceNo2TextBox.Location = New System.Drawing.Point(843, 201)
        Me.Cla_OtherInvoiceNo2TextBox.Name = "Cla_OtherInvoiceNo2TextBox"
        Me.Cla_OtherInvoiceNo2TextBox.Size = New System.Drawing.Size(101, 20)
        Me.Cla_OtherInvoiceNo2TextBox.TabIndex = 62
        '
        'Cla_RepairerInvoiceNo2TextBox
        '
        Me.Cla_RepairerInvoiceNo2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairerInvoiceNo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_RepairerInvoiceNo2", True))
        Me.Cla_RepairerInvoiceNo2TextBox.Location = New System.Drawing.Point(843, 170)
        Me.Cla_RepairerInvoiceNo2TextBox.Name = "Cla_RepairerInvoiceNo2TextBox"
        Me.Cla_RepairerInvoiceNo2TextBox.Size = New System.Drawing.Size(101, 20)
        Me.Cla_RepairerInvoiceNo2TextBox.TabIndex = 61
        '
        'Cla_OtherPaidTo2ComboBox
        '
        Me.Cla_OtherPaidTo2ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_OtherPaidTo2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_OtherPaidTo2", True))
        Me.Cla_OtherPaidTo2ComboBox.FormattingEnabled = True
        Me.Cla_OtherPaidTo2ComboBox.Items.AddRange(New Object() {"", "Risk"})
        Me.Cla_OtherPaidTo2ComboBox.Location = New System.Drawing.Point(615, 201)
        Me.Cla_OtherPaidTo2ComboBox.Name = "Cla_OtherPaidTo2ComboBox"
        Me.Cla_OtherPaidTo2ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_OtherPaidTo2ComboBox.TabIndex = 58
        '
        'Cla_RepairerPaidTo2ComboBox
        '
        Me.Cla_RepairerPaidTo2ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairerPaidTo2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_RepairerPaidTo2", True))
        Me.Cla_RepairerPaidTo2ComboBox.FormattingEnabled = True
        Me.Cla_RepairerPaidTo2ComboBox.Items.AddRange(New Object() {"", "Mobizone", "Digimob", "FMM", "FONEBIZ", "Roadhound"})
        Me.Cla_RepairerPaidTo2ComboBox.Location = New System.Drawing.Point(614, 170)
        Me.Cla_RepairerPaidTo2ComboBox.Name = "Cla_RepairerPaidTo2ComboBox"
        Me.Cla_RepairerPaidTo2ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_RepairerPaidTo2ComboBox.TabIndex = 57
        '
        'Cla_PaidBalanceTextBox
        '
        Me.Cla_PaidBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PaidBalance", True))
        Me.Cla_PaidBalanceTextBox.Location = New System.Drawing.Point(428, 241)
        Me.Cla_PaidBalanceTextBox.Multiline = True
        Me.Cla_PaidBalanceTextBox.Name = "Cla_PaidBalanceTextBox"
        Me.Cla_PaidBalanceTextBox.Size = New System.Drawing.Size(290, 41)
        Me.Cla_PaidBalanceTextBox.TabIndex = 56
        '
        'Cla_PaidBalanceLabel
        '
        Me.Cla_PaidBalanceLabel.AutoSize = True
        Me.Cla_PaidBalanceLabel.Location = New System.Drawing.Point(294, 241)
        Me.Cla_PaidBalanceLabel.MaximumSize = New System.Drawing.Size(100, 0)
        Me.Cla_PaidBalanceLabel.Name = "Cla_PaidBalanceLabel"
        Me.Cla_PaidBalanceLabel.Size = New System.Drawing.Size(96, 26)
        Me.Cla_PaidBalanceLabel.TabIndex = 55
        Me.Cla_PaidBalanceLabel.Text = "If partial, what has not been paid?"
        '
        'Cla_OtherInvoiceNo1AmtTextBox
        '
        Me.Cla_OtherInvoiceNo1AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_OtherInvoiceNo1AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_OtherInvoiceNo1Amt", True))
        Me.Cla_OtherInvoiceNo1AmtTextBox.Location = New System.Drawing.Point(442, 201)
        Me.Cla_OtherInvoiceNo1AmtTextBox.Name = "Cla_OtherInvoiceNo1AmtTextBox"
        Me.Cla_OtherInvoiceNo1AmtTextBox.Size = New System.Drawing.Size(67, 20)
        Me.Cla_OtherInvoiceNo1AmtTextBox.TabIndex = 54
        '
        'Cla_RepairerInvoiceNo1AmtTextBox
        '
        Me.Cla_RepairerInvoiceNo1AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairerInvoiceNo1AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_RepairerInvoiceNo1Amt", True))
        Me.Cla_RepairerInvoiceNo1AmtTextBox.Location = New System.Drawing.Point(442, 170)
        Me.Cla_RepairerInvoiceNo1AmtTextBox.Name = "Cla_RepairerInvoiceNo1AmtTextBox"
        Me.Cla_RepairerInvoiceNo1AmtTextBox.Size = New System.Drawing.Size(67, 20)
        Me.Cla_RepairerInvoiceNo1AmtTextBox.TabIndex = 53
        '
        'Cla_SimCardInvoiceNo1AmtTextBox
        '
        Me.Cla_SimCardInvoiceNo1AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_SimCardInvoiceNo1AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_SimCardInvoiceNo1Amt", True))
        Me.Cla_SimCardInvoiceNo1AmtTextBox.Location = New System.Drawing.Point(442, 142)
        Me.Cla_SimCardInvoiceNo1AmtTextBox.Name = "Cla_SimCardInvoiceNo1AmtTextBox"
        Me.Cla_SimCardInvoiceNo1AmtTextBox.Size = New System.Drawing.Size(67, 20)
        Me.Cla_SimCardInvoiceNo1AmtTextBox.TabIndex = 52
        '
        'Cla_OtherInvoiceNo1TextBox
        '
        Me.Cla_OtherInvoiceNo1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_OtherInvoiceNo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_OtherInvoiceNo1", True))
        Me.Cla_OtherInvoiceNo1TextBox.Location = New System.Drawing.Point(332, 201)
        Me.Cla_OtherInvoiceNo1TextBox.Name = "Cla_OtherInvoiceNo1TextBox"
        Me.Cla_OtherInvoiceNo1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_OtherInvoiceNo1TextBox.TabIndex = 51
        '
        'Cla_RepairerInvoiceNo1TextBox
        '
        Me.Cla_RepairerInvoiceNo1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairerInvoiceNo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_RepairerInvoiceNo1", True))
        Me.Cla_RepairerInvoiceNo1TextBox.Location = New System.Drawing.Point(332, 170)
        Me.Cla_RepairerInvoiceNo1TextBox.Name = "Cla_RepairerInvoiceNo1TextBox"
        Me.Cla_RepairerInvoiceNo1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_RepairerInvoiceNo1TextBox.TabIndex = 50
        '
        'Cla_SimCardInvoiceNo1TextBox
        '
        Me.Cla_SimCardInvoiceNo1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_SimCardInvoiceNo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_SimCardInvoiceNo1", True))
        Me.Cla_SimCardInvoiceNo1TextBox.Location = New System.Drawing.Point(332, 141)
        Me.Cla_SimCardInvoiceNo1TextBox.Name = "Cla_SimCardInvoiceNo1TextBox"
        Me.Cla_SimCardInvoiceNo1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_SimCardInvoiceNo1TextBox.TabIndex = 49
        '
        'Cla_PhoneAccessoriesInvoiceNo4AmtTextBox
        '
        Me.Cla_PhoneAccessoriesInvoiceNo4AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesInvoiceNo4AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_PhoneAccessoriesInvoiceNo4Amt", True))
        Me.Cla_PhoneAccessoriesInvoiceNo4AmtTextBox.Location = New System.Drawing.Point(442, 113)
        Me.Cla_PhoneAccessoriesInvoiceNo4AmtTextBox.Name = "Cla_PhoneAccessoriesInvoiceNo4AmtTextBox"
        Me.Cla_PhoneAccessoriesInvoiceNo4AmtTextBox.Size = New System.Drawing.Size(67, 20)
        Me.Cla_PhoneAccessoriesInvoiceNo4AmtTextBox.TabIndex = 41
        '
        'Cla_PhoneAccessoriesInvoiceNo3AmtTextBox
        '
        Me.Cla_PhoneAccessoriesInvoiceNo3AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesInvoiceNo3AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_PhoneAccessoriesInvoiceNo3Amt", True))
        Me.Cla_PhoneAccessoriesInvoiceNo3AmtTextBox.Location = New System.Drawing.Point(442, 85)
        Me.Cla_PhoneAccessoriesInvoiceNo3AmtTextBox.Name = "Cla_PhoneAccessoriesInvoiceNo3AmtTextBox"
        Me.Cla_PhoneAccessoriesInvoiceNo3AmtTextBox.Size = New System.Drawing.Size(67, 20)
        Me.Cla_PhoneAccessoriesInvoiceNo3AmtTextBox.TabIndex = 40
        '
        'Cla_PhoneAccessoriesInvoiceNo2AmtTextBox
        '
        Me.Cla_PhoneAccessoriesInvoiceNo2AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesInvoiceNo2AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_PhoneAccessoriesInvoiceNo2Amt", True))
        Me.Cla_PhoneAccessoriesInvoiceNo2AmtTextBox.Location = New System.Drawing.Point(442, 56)
        Me.Cla_PhoneAccessoriesInvoiceNo2AmtTextBox.Name = "Cla_PhoneAccessoriesInvoiceNo2AmtTextBox"
        Me.Cla_PhoneAccessoriesInvoiceNo2AmtTextBox.Size = New System.Drawing.Size(67, 20)
        Me.Cla_PhoneAccessoriesInvoiceNo2AmtTextBox.TabIndex = 39
        '
        'Cla_PhoneAccessoriesInvoiceNo1AmtTextBox
        '
        Me.Cla_PhoneAccessoriesInvoiceNo1AmtTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesInvoiceNo1AmtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_PhoneAccessoriesInvoiceNo1Amt", True))
        Me.Cla_PhoneAccessoriesInvoiceNo1AmtTextBox.Location = New System.Drawing.Point(442, 27)
        Me.Cla_PhoneAccessoriesInvoiceNo1AmtTextBox.Name = "Cla_PhoneAccessoriesInvoiceNo1AmtTextBox"
        Me.Cla_PhoneAccessoriesInvoiceNo1AmtTextBox.Size = New System.Drawing.Size(67, 20)
        Me.Cla_PhoneAccessoriesInvoiceNo1AmtTextBox.TabIndex = 38
        '
        'Cla_PhoneAccessoriesInvoiceNo4TextBox
        '
        Me.Cla_PhoneAccessoriesInvoiceNo4TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesInvoiceNo4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PhoneAccessoriesInvoiceNo4", True))
        Me.Cla_PhoneAccessoriesInvoiceNo4TextBox.Location = New System.Drawing.Point(332, 113)
        Me.Cla_PhoneAccessoriesInvoiceNo4TextBox.Name = "Cla_PhoneAccessoriesInvoiceNo4TextBox"
        Me.Cla_PhoneAccessoriesInvoiceNo4TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_PhoneAccessoriesInvoiceNo4TextBox.TabIndex = 37
        '
        'Cla_PhoneAccessoriesInvoiceNo3TextBox
        '
        Me.Cla_PhoneAccessoriesInvoiceNo3TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesInvoiceNo3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PhoneAccessoriesInvoiceNo3", True))
        Me.Cla_PhoneAccessoriesInvoiceNo3TextBox.Location = New System.Drawing.Point(332, 85)
        Me.Cla_PhoneAccessoriesInvoiceNo3TextBox.Name = "Cla_PhoneAccessoriesInvoiceNo3TextBox"
        Me.Cla_PhoneAccessoriesInvoiceNo3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_PhoneAccessoriesInvoiceNo3TextBox.TabIndex = 36
        '
        'Cla_InvoiceNo2TextBox
        '
        Me.Cla_InvoiceNo2TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_InvoiceNo2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_InvoiceNo2", True))
        Me.Cla_InvoiceNo2TextBox.Location = New System.Drawing.Point(332, 56)
        Me.Cla_InvoiceNo2TextBox.Name = "Cla_InvoiceNo2TextBox"
        Me.Cla_InvoiceNo2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_InvoiceNo2TextBox.TabIndex = 35
        '
        'Cla_InvoiceNo1TextBox
        '
        Me.Cla_InvoiceNo1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_InvoiceNo1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_InvoiceNo1", True))
        Me.Cla_InvoiceNo1TextBox.Location = New System.Drawing.Point(332, 27)
        Me.Cla_InvoiceNo1TextBox.Name = "Cla_InvoiceNo1TextBox"
        Me.Cla_InvoiceNo1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_InvoiceNo1TextBox.TabIndex = 34
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(12, 7)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(77, 15)
        Me.Label54.TabIndex = 33
        Me.Label54.Text = "Paid Details"
        '
        'Cla_PaidFullComboBox
        '
        Me.Cla_PaidFullComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PaidFull", True))
        Me.Cla_PaidFullComboBox.FormattingEnabled = True
        Me.Cla_PaidFullComboBox.Items.AddRange(New Object() {"Full", "Partial"})
        Me.Cla_PaidFullComboBox.Location = New System.Drawing.Point(105, 238)
        Me.Cla_PaidFullComboBox.Name = "Cla_PaidFullComboBox"
        Me.Cla_PaidFullComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_PaidFullComboBox.TabIndex = 15
        '
        'Cla_OtherPaidToComboBox
        '
        Me.Cla_OtherPaidToComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_OtherPaidToComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_OtherPaidTo", True))
        Me.Cla_OtherPaidToComboBox.FormattingEnabled = True
        Me.Cla_OtherPaidToComboBox.Items.AddRange(New Object() {"", "Risk"})
        Me.Cla_OtherPaidToComboBox.Location = New System.Drawing.Point(105, 201)
        Me.Cla_OtherPaidToComboBox.Name = "Cla_OtherPaidToComboBox"
        Me.Cla_OtherPaidToComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_OtherPaidToComboBox.TabIndex = 13
        '
        'Cla_RepairerPaidToComboBox
        '
        Me.Cla_RepairerPaidToComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairerPaidToComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_RepairerPaidTo", True))
        Me.Cla_RepairerPaidToComboBox.FormattingEnabled = True
        Me.Cla_RepairerPaidToComboBox.Items.AddRange(New Object() {"", "Mobizone", "Digimob", "FMM", "FONEBIZ", "Roadhound"})
        Me.Cla_RepairerPaidToComboBox.Location = New System.Drawing.Point(105, 170)
        Me.Cla_RepairerPaidToComboBox.Name = "Cla_RepairerPaidToComboBox"
        Me.Cla_RepairerPaidToComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_RepairerPaidToComboBox.TabIndex = 11
        '
        'Cla_SimCardPaidToComboBox
        '
        Me.Cla_SimCardPaidToComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_SimCardPaidToComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_SimCardPaidTo", True))
        Me.Cla_SimCardPaidToComboBox.FormattingEnabled = True
        Me.Cla_SimCardPaidToComboBox.Items.AddRange(New Object() {"", "Allphones", "BP", "Cash", "Hutch", "RH", "Salvage"})
        Me.Cla_SimCardPaidToComboBox.Location = New System.Drawing.Point(105, 141)
        Me.Cla_SimCardPaidToComboBox.Name = "Cla_SimCardPaidToComboBox"
        Me.Cla_SimCardPaidToComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_SimCardPaidToComboBox.TabIndex = 9
        '
        'Cla_PhoneAccessoriesPaidToComboBox
        '
        Me.Cla_PhoneAccessoriesPaidToComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesPaidToComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PhoneAccessoriesPaidTo", True))
        Me.Cla_PhoneAccessoriesPaidToComboBox.FormattingEnabled = True
        Me.Cla_PhoneAccessoriesPaidToComboBox.Items.AddRange(New Object() {"", "Allphones", "Bank Transfer", "BP", "Cash", "EFT", "RH", "Telstra", "Virgin", "BS", "JB HIFI", "Freight", "VHA", "Quantum", "FOS", "Other"})
        Me.Cla_PhoneAccessoriesPaidToComboBox.Location = New System.Drawing.Point(105, 27)
        Me.Cla_PhoneAccessoriesPaidToComboBox.Name = "Cla_PhoneAccessoriesPaidToComboBox"
        Me.Cla_PhoneAccessoriesPaidToComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_PhoneAccessoriesPaidToComboBox.TabIndex = 7
        '
        'Cla_PhoneAccessoriesPaidTo4ComboBox
        '
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PhoneAccessoriesPaidTo4", True))
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox.FormattingEnabled = True
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox.Items.AddRange(New Object() {"", "Allphones", "Bank Transfer", "BP", "Cash", "EFT", "RH", "Telstra", "Virgin", "BS", "JB HIFI", "Freight", "VHA", "Quantum", "FOS", "Other"})
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox.Location = New System.Drawing.Point(105, 113)
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox.Name = "Cla_PhoneAccessoriesPaidTo4ComboBox"
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_PhoneAccessoriesPaidTo4ComboBox.TabIndex = 5
        '
        'Cla_PhoneAccessoriesPaidTo3ComboBox
        '
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PhoneAccessoriesPaidTo3", True))
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox.FormattingEnabled = True
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox.Items.AddRange(New Object() {"", "Allphones", "Bank Transfer", "BP", "Cash", "EFT", "RH", "Telstra", "Virgin", "BS", "JB HIFI", "Freight", "VHA", "Quantum", "FOS", "Other"})
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox.Location = New System.Drawing.Point(105, 85)
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox.Name = "Cla_PhoneAccessoriesPaidTo3ComboBox"
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_PhoneAccessoriesPaidTo3ComboBox.TabIndex = 3
        '
        'Cla_PhoneAccessoriesPaidTo2ComboBox
        '
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_PhoneAccessoriesPaidTo2", True))
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox.FormattingEnabled = True
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox.Items.AddRange(New Object() {"", "Allphones", "Bank Transfer", "BP", "Cash", "EFT", "RH", "Telstra", "Virgin", "BS", "JB HIFI", "Freight", "VHA", "Quantum", "FOS", "Other"})
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox.Location = New System.Drawing.Point(105, 56)
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox.Name = "Cla_PhoneAccessoriesPaidTo2ComboBox"
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Cla_PhoneAccessoriesPaidTo2ComboBox.TabIndex = 1
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Cla_CCDateEnteredTextBox)
        Me.Panel15.Controls.Add(Me.Label52)
        Me.Panel15.Controls.Add(Me.Label53)
        Me.Panel15.Controls.Add(Me.Cla_BPayNumberTextBox)
        Me.Panel15.Controls.Add(Me.Cla_BPayNumberLabel)
        Me.Panel15.Controls.Add(Me.Label51)
        Me.Panel15.Controls.Add(Me.CCExpiryYearNullableMaskedTextBox)
        Me.Panel15.Controls.Add(Me.CCExpiryMonthYearNullableMaskedTextBox)
        Me.Panel15.Controls.Add(Me.CCExpiryYearLabel)
        Me.Panel15.Controls.Add(Me.Cla_BPayRequiredCheckBox)
        Me.Panel15.Controls.Add(Me.Cla_BPayRequiredLabel)
        Me.Panel15.Controls.Add(Me.Cla_CCAmountTextBox)
        Me.Panel15.Controls.Add(Me.Cla_CCAmountLabel)
        Me.Panel15.Controls.Add(Me.CCExpiryMonthYearLabel)
        Me.Panel15.Controls.Add(Me.CCNameLabel)
        Me.Panel15.Controls.Add(Me.Cla_BPayNumberSeedTextBox)
        Me.Panel15.Controls.Add(Me.Cla_RepairReceiptNoLabel)
        Me.Panel15.Controls.Add(Me.CCNameTextBox)
        Me.Panel15.Controls.Add(Me.Cla_RepairReceiptNoTextBox)
        Me.Panel15.Controls.Add(Me.CCNumberTextBox)
        Me.Panel15.Controls.Add(Me.CCNumberLabel)
        Me.Panel15.Controls.Add(Me.Cla_CCDateEnteredLabel)
        Me.Panel15.Location = New System.Drawing.Point(28, 163)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(923, 143)
        Me.Panel15.TabIndex = 26
        '
        'Cla_CCDateEnteredTextBox
        '
        Me.Cla_CCDateEnteredTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_CCDateEnteredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sCla_CCDateEntered", True))
        Me.Cla_CCDateEnteredTextBox.Location = New System.Drawing.Point(138, 65)
        Me.Cla_CCDateEnteredTextBox.Name = "Cla_CCDateEnteredTextBox"
        Me.Cla_CCDateEnteredTextBox.Size = New System.Drawing.Size(120, 20)
        Me.Cla_CCDateEnteredTextBox.TabIndex = 92
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Yellow
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Blue
        Me.Label52.Location = New System.Drawing.Point(11, 113)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(907, 15)
        Me.Label52.TabIndex = 32
        Me.Label52.Text = "                                  You MUST confirm the customers delivery address" &
    " && handset details prior to collecting the excess!                             " &
    "     "
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Blue
        Me.Label53.Location = New System.Drawing.Point(358, 93)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(518, 17)
        Me.Label53.TabIndex = 33
        Me.Label53.Text = "Note: When keying in an amount do not use a decimal. eg $125.00 key as 12500"
        '
        'Cla_BPayNumberTextBox
        '
        Me.Cla_BPayNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_BPayNumber", True))
        Me.Cla_BPayNumberTextBox.Location = New System.Drawing.Point(801, 61)
        Me.Cla_BPayNumberTextBox.Name = "Cla_BPayNumberTextBox"
        Me.Cla_BPayNumberTextBox.Size = New System.Drawing.Size(110, 20)
        Me.Cla_BPayNumberTextBox.TabIndex = 30
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(723, 41)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(111, 13)
        Me.Label51.TabIndex = 31
        Me.Label51.Text = "Biller Code:     908285"
        '
        'CCExpiryYearNullableMaskedTextBox
        '
        Me.CCExpiryYearNullableMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CCExpiryYearNullableMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CCExpiryYear", True))
        Me.CCExpiryYearNullableMaskedTextBox.Location = New System.Drawing.Point(476, 38)
        Me.CCExpiryYearNullableMaskedTextBox.Mask = "00"
        Me.CCExpiryYearNullableMaskedTextBox.Name = "CCExpiryYearNullableMaskedTextBox"
        Me.CCExpiryYearNullableMaskedTextBox.Size = New System.Drawing.Size(67, 20)
        Me.CCExpiryYearNullableMaskedTextBox.TabIndex = 27
        Me.CCExpiryYearNullableMaskedTextBox.Value = Nothing
        '
        'CCExpiryMonthYearNullableMaskedTextBox
        '
        Me.CCExpiryMonthYearNullableMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CCExpiryMonthYearNullableMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CCExpiryMonthYear", True))
        Me.CCExpiryMonthYearNullableMaskedTextBox.Location = New System.Drawing.Point(360, 38)
        Me.CCExpiryMonthYearNullableMaskedTextBox.Mask = "00"
        Me.CCExpiryMonthYearNullableMaskedTextBox.Name = "CCExpiryMonthYearNullableMaskedTextBox"
        Me.CCExpiryMonthYearNullableMaskedTextBox.Size = New System.Drawing.Size(67, 20)
        Me.CCExpiryMonthYearNullableMaskedTextBox.TabIndex = 28
        Me.CCExpiryMonthYearNullableMaskedTextBox.Value = Nothing
        '
        'Cla_BPayRequiredCheckBox
        '
        Me.Cla_BPayRequiredCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblClaimBindingSource, "cla_BPayRequired", True))
        Me.Cla_BPayRequiredCheckBox.Location = New System.Drawing.Point(810, 14)
        Me.Cla_BPayRequiredCheckBox.Name = "Cla_BPayRequiredCheckBox"
        Me.Cla_BPayRequiredCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.Cla_BPayRequiredCheckBox.TabIndex = 28
        Me.Cla_BPayRequiredCheckBox.UseVisualStyleBackColor = True
        '
        'Cla_CCAmountTextBox
        '
        Me.Cla_CCAmountTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Cla_CCAmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "scla_CCAmount", True))
        Me.Cla_CCAmountTextBox.Location = New System.Drawing.Point(358, 64)
        Me.Cla_CCAmountTextBox.Name = "Cla_CCAmountTextBox"
        Me.Cla_CCAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cla_CCAmountTextBox.TabIndex = 27
        '
        'Cla_BPayNumberSeedTextBox
        '
        Me.Cla_BPayNumberSeedTextBox.BackColor = System.Drawing.Color.Red
        Me.Cla_BPayNumberSeedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_BPayNumberSeed", True))
        Me.Cla_BPayNumberSeedTextBox.Location = New System.Drawing.Point(464, 65)
        Me.Cla_BPayNumberSeedTextBox.Name = "Cla_BPayNumberSeedTextBox"
        Me.Cla_BPayNumberSeedTextBox.Size = New System.Drawing.Size(90, 20)
        Me.Cla_BPayNumberSeedTextBox.TabIndex = 27
        Me.Cla_BPayNumberSeedTextBox.Visible = False
        '
        'CCNameTextBox
        '
        Me.CCNameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CCNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CCName", True))
        Me.CCNameTextBox.Location = New System.Drawing.Point(138, 12)
        Me.CCNameTextBox.Name = "CCNameTextBox"
        Me.CCNameTextBox.Size = New System.Drawing.Size(405, 20)
        Me.CCNameTextBox.TabIndex = 19
        '
        'Cla_RepairReceiptNoTextBox
        '
        Me.Cla_RepairReceiptNoTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cla_RepairReceiptNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "cla_RepairReceiptNo", True))
        Me.Cla_RepairReceiptNoTextBox.Location = New System.Drawing.Point(138, 90)
        Me.Cla_RepairReceiptNoTextBox.Name = "Cla_RepairReceiptNoTextBox"
        Me.Cla_RepairReceiptNoTextBox.Size = New System.Drawing.Size(214, 20)
        Me.Cla_RepairReceiptNoTextBox.TabIndex = 25
        '
        'CCNumberTextBox
        '
        Me.CCNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CCNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CCNumber", True))
        Me.CCNumberTextBox.Location = New System.Drawing.Point(138, 38)
        Me.CCNumberTextBox.Name = "CCNumberTextBox"
        Me.CCNumberTextBox.Size = New System.Drawing.Size(120, 20)
        Me.CCNumberTextBox.TabIndex = 21
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.ExcessTextBox1)
        Me.Panel14.Controls.Add(Me.ExcessLabel1)
        Me.Panel14.Controls.Add(Me.Label44)
        Me.Panel14.Controls.Add(Me.TotalCostTextBox)
        Me.Panel14.Controls.Add(Me.GSTTextBox)
        Me.Panel14.Controls.Add(Me.GSTLabel)
        Me.Panel14.Controls.Add(Me.Label45)
        Me.Panel14.Controls.Add(Me.ReplaceVarianceCostLabel)
        Me.Panel14.Controls.Add(Me.TotalCostlessGSTTextBox)
        Me.Panel14.Controls.Add(Me.ReplaceVarianceCostTextBox)
        Me.Panel14.Controls.Add(Me.Label46)
        Me.Panel14.Controls.Add(Me.TotalCostLessGSTLabel)
        Me.Panel14.Controls.Add(Me.Label47)
        Me.Panel14.Controls.Add(Me.TotalCostLessGSTTextBox1)
        Me.Panel14.Controls.Add(Me.TotalClaimCostTextBox)
        Me.Panel14.Controls.Add(Me.TotalClaimCostLabel)
        Me.Panel14.Location = New System.Drawing.Point(28, 7)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(923, 100)
        Me.Panel14.TabIndex = 24
        '
        'ExcessTextBox1
        '
        Me.ExcessTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sExcess", True))
        Me.ExcessTextBox1.Location = New System.Drawing.Point(68, 13)
        Me.ExcessTextBox1.Name = "ExcessTextBox1"
        Me.ExcessTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.ExcessTextBox1.TabIndex = 1
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(11, 42)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(55, 13)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Total Cost"
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sTotalClaimCostIncGST", True))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(68, 39)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.ReadOnly = True
        Me.TotalCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalCostTextBox.TabIndex = 3
        '
        'GSTTextBox
        '
        Me.GSTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sGST", True))
        Me.GSTTextBox.Location = New System.Drawing.Point(247, 39)
        Me.GSTTextBox.Name = "GSTTextBox"
        Me.GSTTextBox.ReadOnly = True
        Me.GSTTextBox.Size = New System.Drawing.Size(65, 20)
        Me.GSTTextBox.TabIndex = 5
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(344, 42)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(55, 13)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "Total Cost"
        '
        'TotalCostlessGSTTextBox
        '
        Me.TotalCostlessGSTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sTotalClaimCostExGST", True))
        Me.TotalCostlessGSTTextBox.Location = New System.Drawing.Point(405, 39)
        Me.TotalCostlessGSTTextBox.Name = "TotalCostlessGSTTextBox"
        Me.TotalCostlessGSTTextBox.ReadOnly = True
        Me.TotalCostlessGSTTextBox.Size = New System.Drawing.Size(65, 20)
        Me.TotalCostlessGSTTextBox.TabIndex = 7
        '
        'ReplaceVarianceCostTextBox
        '
        Me.ReplaceVarianceCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sReplaceVarianceCost", True))
        Me.ReplaceVarianceCostTextBox.Location = New System.Drawing.Point(801, 69)
        Me.ReplaceVarianceCostTextBox.Name = "ReplaceVarianceCostTextBox"
        Me.ReplaceVarianceCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReplaceVarianceCostTextBox.TabIndex = 17
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(11, 62)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 13)
        Me.Label46.TabIndex = 8
        Me.Label46.Text = "(GST Inclusive)"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(344, 62)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(83, 13)
        Me.Label47.TabIndex = 9
        Me.Label47.Text = "(GST Exclusive)"
        '
        'TotalCostLessGSTTextBox1
        '
        Me.TotalCostLessGSTTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sTotalCostLessGST", True))
        Me.TotalCostLessGSTTextBox1.Location = New System.Drawing.Point(674, 66)
        Me.TotalCostLessGSTTextBox1.Name = "TotalCostLessGSTTextBox1"
        Me.TotalCostLessGSTTextBox1.ReadOnly = True
        Me.TotalCostLessGSTTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TotalCostLessGSTTextBox1.TabIndex = 15
        '
        'TotalClaimCostTextBox
        '
        Me.TotalClaimCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "sTotalClaimCost", True))
        Me.TotalClaimCostTextBox.Location = New System.Drawing.Point(674, 39)
        Me.TotalClaimCostTextBox.Name = "TotalClaimCostTextBox"
        Me.TotalClaimCostTextBox.ReadOnly = True
        Me.TotalClaimCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalClaimCostTextBox.TabIndex = 13
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Yellow
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Blue
        Me.Label49.Location = New System.Drawing.Point(25, 128)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(878, 15)
        Me.Label49.TabIndex = 11
        Me.Label49.Text = "Excess payment can be paid by Visa, Mastercard or Bankcard ONLY otherwise we exce" &
    "pt Bpay or Money Orders - NO CHEQUES or CASH"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Yellow
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Blue
        Me.Label48.Location = New System.Drawing.Point(25, 110)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(473, 15)
        Me.Label48.TabIndex = 10
        Me.Label48.Text = "We wish to advise that there is an excess that is applicable to your claim."
        '
        'AuditTabPage
        '
        Me.AuditTabPage.BackColor = System.Drawing.SystemColors.Control
        Me.AuditTabPage.Controls.Add(Me.TblAuditDataGridView)
        Me.AuditTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AuditTabPage.Name = "AuditTabPage"
        Me.AuditTabPage.Size = New System.Drawing.Size(1105, 644)
        Me.AuditTabPage.TabIndex = 5
        Me.AuditTabPage.Text = "Audit"
        '
        'TblAuditDataGridView
        '
        Me.TblAuditDataGridView.AllowUserToAddRows = False
        Me.TblAuditDataGridView.AllowUserToDeleteRows = False
        Me.TblAuditDataGridView.AutoGenerateColumns = False
        Me.TblAuditDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblAuditDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblAuditDataGridView.DataSource = Me.TblAuditBindingSource
        Me.TblAuditDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblAuditDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.TblAuditDataGridView.Name = "TblAuditDataGridView"
        Me.TblAuditDataGridView.ReadOnly = True
        Me.TblAuditDataGridView.Size = New System.Drawing.Size(1105, 644)
        Me.TblAuditDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "audId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "audId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "audClaimNumber"
        Me.DataGridViewTextBoxColumn2.HeaderText = "audClaimNumber"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "audDetails"
        Me.DataGridViewTextBoxColumn3.HeaderText = "audDetails"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "audUser"
        Me.DataGridViewTextBoxColumn4.HeaderText = "audUser"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "audDateTime"
        Me.DataGridViewTextBoxColumn5.HeaderText = "audDateTime"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'TblAuditBindingSource
        '
        Me.TblAuditBindingSource.DataMember = "tblAudit"
        Me.TblAuditBindingSource.DataSource = Me.RiskDataSet
        '
        'RefLetteReportsBindingSource
        '
        Me.RefLetteReportsBindingSource.DataMember = "ref_LetteReports"
        Me.RefLetteReportsBindingSource.DataSource = Me.RiskDataSet
        '
        'TblClaimNoteBindingSource
        '
        Me.TblClaimNoteBindingSource.DataMember = "tblClaimNote"
        Me.TblClaimNoteBindingSource.DataSource = Me.RiskDataSet
        '
        'Replace_TblPhoneBindingSource
        '
        Me.Replace_TblPhoneBindingSource.DataMember = "tblPhone"
        Me.Replace_TblPhoneBindingSource.DataSource = Me.RiskDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.NewClaimTableAdapter = Nothing
        Me.TableAdapterManager.ref_LetteReportsTableAdapter = Nothing
        Me.TableAdapterManager.t_LookupTableAdapter = Nothing
        Me.TableAdapterManager.t_PostcodeTableAdapter = Nothing
        Me.TableAdapterManager.t_SimCardTypeTableAdapter = Nothing
        Me.TableAdapterManager.t_SupplierTableAdapter = Nothing
        Me.TableAdapterManager.tblAuditTableAdapter = Nothing
        Me.TableAdapterManager.tblClaimNoteTableAdapter = Nothing
        Me.TableAdapterManager.tblClaimTableAdapter = Nothing
        Me.TableAdapterManager.tblPhoneTableAdapter = Nothing
        Me.TableAdapterManager.tblPriceTableAdapter = Nothing
        Me.TableAdapterManager.tblSchemeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Risk.RiskDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_LookupTableAdapter
        '
        Me.T_LookupTableAdapter.ClearBeforeFill = True
        '
        'Ref_LetteReportsTableAdapter
        '
        Me.Ref_LetteReportsTableAdapter.ClearBeforeFill = True
        '
        'TblClaimNoteTableAdapter
        '
        Me.TblClaimNoteTableAdapter.ClearBeforeFill = True
        '
        'TblAuditTableAdapter
        '
        Me.TblAuditTableAdapter.ClearBeforeFill = True
        '
        'ExitDoorwayButton1
        '
        Me.ExitDoorwayButton1.Image = CType(resources.GetObject("ExitDoorwayButton1.Image"), System.Drawing.Image)
        Me.ExitDoorwayButton1.Location = New System.Drawing.Point(804, 37)
        Me.ExitDoorwayButton1.Name = "ExitDoorwayButton1"
        Me.ExitDoorwayButton1.Size = New System.Drawing.Size(38, 30)
        Me.ExitDoorwayButton1.TabIndex = 375
        Me.ExitDoorwayButton1.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataMember = ""
        Me.ErrorProvider1.DataSource = Me.TblClaimBindingSource
        '
        'CaseManagerTextBox
        '
        Me.CaseManagerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClaimBindingSource, "CaseManager", True))
        Me.CaseManagerTextBox.Location = New System.Drawing.Point(321, 34)
        Me.CaseManagerTextBox.Name = "CaseManagerTextBox"
        Me.CaseManagerTextBox.ReadOnly = True
        Me.CaseManagerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CaseManagerTextBox.TabIndex = 376
        '
        'SaveRefreshButton
        '
        Me.SaveRefreshButton.Location = New System.Drawing.Point(851, 28)
        Me.SaveRefreshButton.Name = "SaveRefreshButton"
        Me.SaveRefreshButton.Size = New System.Drawing.Size(75, 50)
        Me.SaveRefreshButton.TabIndex = 377
        Me.SaveRefreshButton.Text = "Save && Refresh"
        Me.SaveRefreshButton.UseVisualStyleBackColor = True
        '
        'NoteType
        '
        Me.NoteType.DataPropertyName = "NoteType"
        Me.NoteType.HeaderText = "NoteType"
        Me.NoteType.Items.AddRange(New Object() {"", "Status Update", "Price Update", "More Information Required", "Comments", "Reason for Decline", "Variance in total amount of claim"})
        Me.NoteType.Name = "NoteType"
        Me.NoteType.ReadOnly = True
        Me.NoteType.Visible = False
        Me.NoteType.Width = 200
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Text = "Edit"
        Me.Edit.Width = 50
        '
        'Note
        '
        Me.Note.DataPropertyName = "Note"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Note.DefaultCellStyle = DataGridViewCellStyle1
        Me.Note.HeaderText = "Note"
        Me.Note.Name = "Note"
        Me.Note.ReadOnly = True
        Me.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Note.Width = 480
        '
        'TextNoteID
        '
        Me.TextNoteID.DataPropertyName = "TextNoteID"
        Me.TextNoteID.HeaderText = "TextNoteID"
        Me.TextNoteID.Name = "TextNoteID"
        Me.TextNoteID.ReadOnly = True
        Me.TextNoteID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TextNoteID.Visible = False
        '
        'DateAdded
        '
        Me.DateAdded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DateAdded.DataPropertyName = "DateAdded"
        Me.DateAdded.HeaderText = "Note Date"
        Me.DateAdded.Name = "DateAdded"
        Me.DateAdded.ReadOnly = True
        '
        'ClaimsEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1133, 742)
        Me.Controls.Add(Me.SaveRefreshButton)
        Me.Controls.Add(CaseManagerLabel1)
        Me.Controls.Add(Me.CaseManagerTextBox)
        Me.Controls.Add(Me.ExitDoorwayButton1)
        Me.Controls.Add(Me.ClaimDetailsTabControl)
        Me.Controls.Add(Me.LodgedDateTextBox)
        Me.Controls.Add(Me.UndockButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ClaimNumberLabel)
        Me.Controls.Add(Me.ClaimNumberTextBox)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.LodgedDateLabel)
        Me.Name = "ClaimsEdit"
        Me.Text = "ClaimsEdit"
        CType(Me.TblClaimBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RiskDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClaimDetailsTabControl.ResumeLayout(False)
        Me.ClaimantDetailsTabPage.ResumeLayout(False)
        Me.ClaimantDetailsTabPage.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PhoneDealer_TPostcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Postal_TPostcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.YesNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchemeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClaimDetailsTabPage.ResumeLayout(False)
        Me.ClaimDetailsTabPage.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.CaseManagerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel20.ResumeLayout(False)
        Me.Panel20.PerformLayout()
        CType(Me.Delivery_TPostcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.SettlementDetailsTabPage.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.FreightCostTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReplacementPhone_TSupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhonePriceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Current_TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeclarationAndNotesTabPage.ResumeLayout(False)
        Me.DeclarationAndNotesTabPage.PerformLayout()
        CType(Me.TblClaimNoteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.PaymentsTabPage.ResumeLayout(False)
        Me.PaymentsTabPage.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.AuditTabPage.ResumeLayout(False)
        CType(Me.TblAuditDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAuditBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RefLetteReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClaimNoteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Replace_TblPhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RiskDataSet As Risk.RiskDataSet
    Friend WithEvents TblClaimBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TableAdapterManager As Risk.RiskDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClaimNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UndockButton As System.Windows.Forms.Button
    Friend WithEvents LodgedDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClaimDetailsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents ClaimantDetailsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ClaimDetailsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents SettlementDetailsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents DeclarationAndNotesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents PaymentsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AuditTabPage As System.Windows.Forms.TabPage
    Friend WithEvents IMEINumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SchemeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_InsuranceTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MobilePhoneNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GivenNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomerEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FamilyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PhoneDealerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastPersonFamilyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastPersonGivenNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_LodgerRelationshipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_LodgerLastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_LodgerFirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FaxNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalAddress2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalAddress1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumber2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PostalStateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalPostcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Postal_TPostcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PostalSuburbMultiColumnCombo As Risk.MultiColumnCombo
    Friend WithEvents CopyAddressButton As System.Windows.Forms.Button
    Friend WithEvents Cla_LodgerAccountHolderNoEnglishCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Cla_LodgerHasAuthorityCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SuburbMultiColumnCombo As Risk.MultiColumnCombo
    Friend WithEvents Cla_TerminalIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneDealerStateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneDealelPostCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneDealer_TPostcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CheckClaimMobileNumberButton As System.Windows.Forms.Button
    Friend WithEvents CheckClaimFamilyNameButton As System.Windows.Forms.Button
    Friend WithEvents CancelInsuranceFlagComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DeclinedUseridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApprovedUseridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelledUseridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MoreInfoUseridTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateUserIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_DeclineReasonComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TLookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_LookupTableAdapter As Risk.RiskDataSetTableAdapters.t_LookupTableAdapter
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DamageTypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LossTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ExampleCircumstancesButton As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Cla_ProofOfForcibleEntryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Cla_IMEIBlockedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PoliceReportNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Cla_IMEINotBlockedReasonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_ProofOfPurchaseCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DeliveryAddress2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliveryAddress1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_DeliverPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliverySuburbMultiColumnCombo As Risk.MultiColumnCombo
    Friend WithEvents Delivery_TPostcodeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents DeliveryPostcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_DeliveryStateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RefLetteReportsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ref_LetteReportsTableAdapter As Risk.RiskDataSetTableAdapters.ref_LetteReportsTableAdapter
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents RepairReplaceCashIndicatorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Current_TblPhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurrentPhoneIDMultiColumnCombo As Risk.MultiColumnCombo
    Friend WithEvents Cla_ReplacePhone_sup_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Replace_TblPhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReplacePhoneIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReplacePhoneIDMultiColumnCombo As Risk.MultiColumnCombo
    Friend WithEvents PhonePriceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReplacementPhone_TSupplierBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cla_ReplacePhone_sup_idComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ReplaceCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Cla_ReplacePhoneRRPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_ReplacePhone_SuppliersCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_FreightCostTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OUseSupplierCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Cla_DoNotOrderCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FreightCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SimCardFlagComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents OPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OSupplierNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_SimCardPreviousFlagComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Cla_SimCardTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SimCardProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_ReplaceSIMCard_sup_idComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_ReplaceSimCardIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SimcardCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccOtherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccLeatherCaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_AccOtherProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_AccProductCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccOtherDescrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_ReplaceSIMCard_SuppliersCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents RepairerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Cla_ShortfallUpgradeCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnauthorisedCallsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepairCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairerJobNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairConsignmentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CashSettleAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExcessTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents NewIMEINumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_SimCardNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CorrectInfoFlagComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents LetterRec_DamagedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LetterRec_IMEITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents DiaryEntryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiaryDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TblClaimNoteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClaimNoteTableAdapter As Risk.RiskDataSetTableAdapters.tblClaimNoteTableAdapter
    Friend WithEvents TblClaimNoteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddNewNotationButton As System.Windows.Forms.Button
    Friend WithEvents TotalCostlessGSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ExcessTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents ReplaceVarianceCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalCostLessGSTTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TotalClaimCostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Cla_RepairReceiptNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Cla_CCAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CCExpiryYearNullableMaskedTextBox As Risk.NullableMaskedTextBox
    Friend WithEvents CCExpiryMonthYearNullableMaskedTextBox As Risk.NullableMaskedTextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Cla_BPayNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_BPayRequiredCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Cla_BPayNumberSeedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents Cla_PhoneAccessoriesPaidTo4ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_PhoneAccessoriesPaidTo3ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_PhoneAccessoriesPaidTo2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_OtherPaidToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_RepairerPaidToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_SimCardPaidToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_PhoneAccessoriesPaidToComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Cla_PaidFullComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_InvoiceNo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_InvoiceNo1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesInvoiceNo4AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesInvoiceNo3AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesInvoiceNo2AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesInvoiceNo1AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesInvoiceNo4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesInvoiceNo3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_OtherInvoiceNo1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairerInvoiceNo1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_SimCardInvoiceNo1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_SimCardInvoiceNo1AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairerPaidTo2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Cla_PaidBalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PaidBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_OtherInvoiceNo1AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairerInvoiceNo1AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_OutstandingAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_OtherInvoiceNo2AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairerInvoiceNo2AmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_OtherInvoiceNo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairerInvoiceNo2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_OtherPaidTo2ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FreightCostTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ReplaceCostTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents CashSettleAmountTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AccOtherTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ReplaceVarianceCostTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cla_ShortfallUpgradeCostTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents UnauthorisedCallsTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ReplaceCostTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents SimcardCostTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents AccLeatherCaseTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TblSchemeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAuditBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblAuditTableAdapter As Risk.RiskDataSetTableAdapters.tblAuditTableAdapter
    Friend WithEvents TblAuditDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LetterRec_IPhoneDamageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ExitDoorwayButton1 As Risk.ExitDoorwayButton
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents YesNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FreightCostTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CancelledStatusDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LossDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeclinedStatusDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApprovedStatusDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MoreInfoStatusDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UpdateDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cla_IMEIDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaidStatusDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_OtherPaidToDate2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairerPaidToDate2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents sCla_OtherPaidToDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_RepairerPaidToDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_SimCardPaidToDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesPaidDate4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesPaidDate3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_PhoneAccessoriesPaidDate2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents LodgedDateLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_InsuranceTypeLabel As System.Windows.Forms.Label
    Friend WithEvents SchemeIDLabel As System.Windows.Forms.Label
    Friend WithEvents IMEINumberLabel As System.Windows.Forms.Label
    Friend WithEvents PurchaseDateLabel As System.Windows.Forms.Label
    Friend WithEvents MobilePhoneNumberLabel As System.Windows.Forms.Label
    Friend WithEvents InsuranceDateLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents GivenNameLabel As System.Windows.Forms.Label
    Friend WithEvents FamilyNameLabel As System.Windows.Forms.Label
    Friend WithEvents AccountNumberLabel As System.Windows.Forms.Label
    Friend WithEvents CompanyNameLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerEmailLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_LodgerFirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_LodgerLastNameLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_LodgerRelationshipLabel As System.Windows.Forms.Label
    Friend WithEvents LastPersonGivenNameLabel As System.Windows.Forms.Label
    Friend WithEvents LastPersonFamilyNameLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneDealerLabel As System.Windows.Forms.Label
    Friend WithEvents ContactNumberLabel As System.Windows.Forms.Label
    Friend WithEvents ContactNumber2Label As System.Windows.Forms.Label
    Friend WithEvents PostalAddress1Label As System.Windows.Forms.Label
    Friend WithEvents PostalSuburbLabel As System.Windows.Forms.Label
    Friend WithEvents FaxNumberLabel As System.Windows.Forms.Label
    Friend WithEvents PostalPostcodeLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_PostalStateLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_LodgerHasAuthorityLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_LodgerAccountHolderNoEnglishLabel As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PhoneDealelPostCodeLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_PhoneDealerStateLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_TerminalIdLabel As System.Windows.Forms.Label
    Friend WithEvents CancelInsuranceFlagLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_DeclineReasonLabel As System.Windows.Forms.Label
    Friend WithEvents LossTypeLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_DeliverPersonLabel As System.Windows.Forms.Label
    Friend WithEvents DeliveryAddress1Label As System.Windows.Forms.Label
    Friend WithEvents DeliverySuburbLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_DeliveryStateLabel As System.Windows.Forms.Label
    Friend WithEvents DeliveryPostcodeLabel As System.Windows.Forms.Label
    Friend WithEvents RepairReplaceCashIndicatorLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_ReplacePhone_sup_idLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_ReplacePhone_sup_idLabel1 As System.Windows.Forms.Label
    Friend WithEvents ReplaceCostLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_ReplacePhoneRRPLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_FreightCostTypeLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_DoNotOrderLabel As System.Windows.Forms.Label
    Friend WithEvents OUseSupplierLabel As System.Windows.Forms.Label
    Friend WithEvents OSupplierNameLabel As System.Windows.Forms.Label
    Friend WithEvents OPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents SimCardFlagLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_SimCardPreviousFlagLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_SimCardTypeLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_ReplaceSIMCard_sup_idLabel As System.Windows.Forms.Label
    Friend WithEvents SimcardCostLabel As System.Windows.Forms.Label
    Friend WithEvents AccOtherDescrLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_AccProductCodeLabel As System.Windows.Forms.Label
    Friend WithEvents AccLeatherCaseLabel As System.Windows.Forms.Label
    Friend WithEvents RepairerLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_RepairerJobNoLabel As System.Windows.Forms.Label
    Friend WithEvents RepairCostLabel As System.Windows.Forms.Label
    Friend WithEvents UnauthorisedCallsLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_ShortfallUpgradeCostLabel As System.Windows.Forms.Label
    Friend WithEvents ExcessLabel As System.Windows.Forms.Label
    Friend WithEvents CashSettleAmountLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_RepairConsignmentNoLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_SimCardNumberLabel As System.Windows.Forms.Label
    Friend WithEvents NewIMEINumberLabel As System.Windows.Forms.Label
    Friend WithEvents LetterRec_IMEILabel As System.Windows.Forms.Label
    Friend WithEvents LetterRec_DamagedLabel As System.Windows.Forms.Label
    Friend WithEvents ExcessLabel1 As System.Windows.Forms.Label
    Friend WithEvents GSTLabel As System.Windows.Forms.Label
    Friend WithEvents TotalClaimCostLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCostLessGSTLabel As System.Windows.Forms.Label
    Friend WithEvents ReplaceVarianceCostLabel As System.Windows.Forms.Label
    Friend WithEvents CCNameLabel As System.Windows.Forms.Label
    Friend WithEvents CCNumberLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_CCDateEnteredLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_RepairReceiptNoLabel As System.Windows.Forms.Label
    Friend WithEvents CCExpiryMonthYearLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_CCAmountLabel As System.Windows.Forms.Label
    Friend WithEvents CCExpiryYearLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_BPayRequiredLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_BPayNumberLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_PhoneAccessoriesPaidTo2Label As System.Windows.Forms.Label
    Friend WithEvents Cla_PhoneAccessoriesPaidTo3Label As System.Windows.Forms.Label
    Friend WithEvents Cla_PhoneAccessoriesPaidTo4Label As System.Windows.Forms.Label
    Friend WithEvents Cla_PhoneAccessoriesPaidToLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_SimCardPaidToLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_RepairerPaidToLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_OtherPaidToLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_PaidFullLabel As System.Windows.Forms.Label
    Friend WithEvents Cla_RepairerPaidTo2Label As System.Windows.Forms.Label
    Friend WithEvents Cla_OtherPaidTo2Label As System.Windows.Forms.Label
    Friend WithEvents Cla_OutstandingAmountLabel As System.Windows.Forms.Label
    Friend WithEvents ReplaceCostLabel1 As System.Windows.Forms.Label
    Friend WithEvents FreightCostLabel As System.Windows.Forms.Label
    Friend WithEvents AccLeatherCaseLabel1 As System.Windows.Forms.Label
    Friend WithEvents SimcardCostLabel1 As System.Windows.Forms.Label
    Friend WithEvents ReplaceCostLabel2 As System.Windows.Forms.Label
    Friend WithEvents UnauthorisedCallsLabel1 As System.Windows.Forms.Label
    Friend WithEvents Cla_ShortfallUpgradeCostLabel1 As System.Windows.Forms.Label
    Friend WithEvents ReplaceVarianceCostLabel1 As System.Windows.Forms.Label
    Friend WithEvents AccOtherLabel As System.Windows.Forms.Label
    Friend WithEvents CashSettleAmountLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents LetterRec_IPhoneDamageLabel As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents WarningNoteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PhotoIDReceivedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SDateTimeSimReplacedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InteractionNotesReceivedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BillReceivedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CaseManagerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CaseManagerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents OpenLetterReportButton As System.Windows.Forms.Button
    Friend WithEvents CaseManagerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaveRefreshButton As System.Windows.Forms.Button
    Friend WithEvents InsuranceDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PurchaseDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cla_CCDateEnteredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCancelled As System.Windows.Forms.TextBox
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents IsProcessedEFTCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents AccountNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BSBNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccountNameLabel As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents EFTPaymentAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EFTAccountNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents IsProcessedChequeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents ChequeSupplierNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChequeNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents ChequeAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents CopyAccountHoldersButton As System.Windows.Forms.Button
    Friend WithEvents ReturnToAddressCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents RemittanceLayoutCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents FaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents StateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PostCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Street3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Street1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents RemittanceDeliveryTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents PayeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddresseeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Street2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents EFTPaymentDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChequePaymentDateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label92 As Label
    Friend WithEvents ComboBoxClosedReason As ComboBox
    Friend WithEvents Label93 As Label
    Friend WithEvents PolicyNumberTextBox As TextBox
    Friend WithEvents ComboBoxOISstore As ComboBox
    Friend WithEvents NoteType As DataGridViewComboBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Note As DataGridViewTextBoxColumn
    Friend WithEvents TextNoteID As DataGridViewTextBoxColumn
    Friend WithEvents DateAdded As DataGridViewTextBoxColumn
End Class
