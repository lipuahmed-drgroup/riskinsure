Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class ClaimsEdit

#Region "Form Settings"
    Public Shared Cancelled_Color As Color ' = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(192, Byte), Integer))
    Public Shared Paid_Color As Color ' =  System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
    Public Shared Declined_Color As Color ' = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
    Public Shared Default_Color As Color ' = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    Public Shared Correct_Password As String ' = ""
    Public Shared Payment_Admin As String ' = ""

#End Region 'Form Settings

#Region "Form Controls"

    Private WithEvents mClaim As Claim
    Private ClaimNumber As String

    Private paymentDate As Date

    Private Sub UpdateData()
        '------ Update any new fileds data using this method; just change update script
        'ComboBoxOISstore.Text


        Dim sqlString As String
        sqlString = " Update tblClaim" &
                    " Set cla_ClosedReason ='" & Me.ComboBoxClosedReason.Text & "', PolicyNumber ='" & Me.PolicyNumberTextBox.Text & "', hasOISstore='" & Me.ComboBoxOISstore.Text & "'" &
                    " Where ClaimNumber ='" & Me.ClaimNumber & "'"

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString
        Try
            Using con As New OdbcConnection(constring)
                Using cmd As New OdbcCommand(sqlString, con)
                    con.Open()
                    cmd.CommandType = CommandType.Text
                    cmd.ExecuteNonQuery()
                    con.Close()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub SaveClaim()
        Dim Before_String As String = ""
        Dim After_String As String = ""
        Try
            Me.Validate()
            'testReplacement()
            'Me.TblClaimBindingSource.EndEdit()
            'testReplacement()
        Catch ex As Exception
            MsgBox(ex.Message, , "Save Error")
        End Try

        Try
            If Not mClaim Is Nothing Then

                UpdateData()

                If Not mClaim.ClaimNumber = "" And Not mClaim.ClaimNumber = CStr(0) And Not mClaim.ClaimNumber Is Nothing Then
                    Dim cta = New RiskDataSetTableAdapters.tblClaimTableAdapter
                    cta.ClaimUpdate(Me.mClaim.ClaimNumber, Before_String)
                    mClaim.SaveData()
                    cta.ClaimUpdate(Me.mClaim.ClaimNumber, After_String)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, , "TblClaimBindingNavigatorSaveItem_Click")
        End Try

        If Before_String = After_String Then
            'No changed Made
        Else
            Try
                WriteAudit("Changed")
                Me.TblAuditTableAdapter.Fill(Me.RiskDataSet.tblAudit, Me.ClaimNumberTextBox.Text)
            Catch ex As Exception
                MsgBox(ex.ToString, , "TblClaimBindingNavigatorSaveItem_Click,WriteAudit")
            End Try
        End If


        Try
            If Not mClaim Is Nothing Then
                Dim ClaimNumberValue = Me.mClaim.ClaimNumber
                Me.mClaim = Claim.getClaim(ClaimNumberValue, True)
                Me.TblClaimBindingSource.DataSource = Me.mClaim
            End If

        Catch ex As Exception
            MsgBox(ex.ToString, , "SetClaimNumber(VALUE)")
        End Try
    End Sub


    Private Sub WriteAudit(ByVal Details As String)
        TblAuditTableAdapter.Insert(Me.ClaimNumberTextBox.Text, Details, Risk_Insure_Claims_Management_System.UserName, Now)
    End Sub

    Private Sub ClaimsEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TblClaimNoteDataGridView.AutoGenerateColumns = False
        TblClaimNoteDataGridView.DataSource = Me.TblClaimNoteBindingSource
        FillTables()

    End Sub

    Private Sub AutoValidateProcedure_AddHandlers()
        For Each tabControlObject In Me.Controls
            If TypeOf tabControlObject Is TabControl Then
                Dim tabControl = CType(tabControlObject, TabControl)
                For Each tabPageObject In tabControl.Controls
                    If TypeOf tabPageObject Is TabPage Then
                        Dim tabPage = CType(tabPageObject, TabPage)
                        For Each panelObject In tabPage.Controls
                            If TypeOf panelObject Is Panel Then
                                Dim panel = CType(panelObject, Panel)
                                For Each obj In panel.Controls
                                    If TypeOf obj Is ComboBox Then
                                        Dim comboBox = CType(obj, ComboBox)
                                        AddHandler comboBox.DropDownClosed, AddressOf AutoValidateProcedure
                                    ElseIf TypeOf obj Is CheckBox Then
                                        Dim checkBox = CType(obj, CheckBox)
                                        AddHandler checkBox.Click, AddressOf AutoValidateProcedure
                                        AddHandler checkBox.KeyPress, AddressOf AutoValidateProcedure
                                    ElseIf TypeOf obj Is NullableDateTimePicker Then
                                        Dim ndttp = CType(obj, NullableDateTimePicker)
                                        '  AddHandler ndttp.TextChanged, AddressOf AutoValidateProcedure
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub AutoValidateProcedure() 'Handles Me.Controls.MultiColumnCombos
        Windows.Forms.SendKeys.Send(vbTab)
    End Sub

    Private Sub FillTables() 'OnLoad Event
        Try

            Me.TblSchemeBindingSource.DataSource = Scheme.Schemes
            Me.Current_TblPhoneBindingSource.DataSource = Phone.Phones
            Me.ReplacementPhone_TSupplierBindingSource.DataSource = Supplier.Suppliers


            Me.Ref_LetteReportsTableAdapter.Fill(Me.RiskDataSet.ref_LetteReports)
            Me.T_LookupTableAdapter.Fill(Me.RiskDataSet.t_Lookup)


            Postal_TPostcodeBindingSource.DataSource = PostCode.PostCodes
            Delivery_TPostcodeBindingSource.DataSource = PostCode.PostCodes
            PhoneDealer_TPostcodeBindingSource.DataSource = PostCode.PostCodes

            CaseManagerBindingSource.DataSource = CaseManager.CaseManagers


            'BindData() - YesNo
            CancelInsuranceFlagComboBox.DataSource = YesNo.YesNos
            SimCardFlagComboBox.DataSource = YesNo.YesNos
            Cla_SimCardPreviousFlagComboBox.DataSource = YesNo.YesNos
            CorrectInfoFlagComboBox.DataSource = YesNo.YesNos
            'GSTRegisteredFlagComboBox.DataSource = YesNo.YesNos
            ' - FreightType
            Cla_FreightCostTypeComboBox.DataSource = FreightCostType.FreightCostTypes

        Catch ex As Exception
            MsgBox(ex.ToString, , "FillTables()")
        End Try

    End Sub

    Private Sub FillPaymentData()

        Using con As New OdbcConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString)

            AccountNameTextBox.Text = ""
            BSBNumberTextBox.Text = ""
            EFTAccountNumberTextBox.Text = ""
            EFTPaymentAmountTextBox.Text = ""
            EFTPaymentDateTextBox.Text = ""
            IsProcessedEFTCheckBox.Checked = False

            ChequeAmountTextBox.Text = ""
            ChequeNumberTextBox.Text = ""
            ChequeSupplierNumberTextBox.Text = ""
            ChequePaymentDateTextBox.Text = ""
            IsProcessedChequeCheckBox.Checked = False


            Try

                Dim dtPayment As DataTable
                Dim adpPayment As New System.Data.Odbc.OdbcDataAdapter

                Dim sql As String = " SELECT ClaimNumber,PaymentDate,RecordType,SupplierNumber,PaymentAmount,LodgementReference,BSBNumber,AccountNumber,AccountName, IsProcessed " & _
                                "FROM dbo.tblPayment WHERE ClaimNumber='" & Me.ClaimNumber & "' AND RecordType='E' "
                con.Open()
                adpPayment = New Odbc.OdbcDataAdapter(sql, con)
                dtPayment = New DataTable()
                adpPayment.Fill(dtPayment)

                If dtPayment.Rows.Count > 0 Then
                    AccountNameTextBox.Text = dtPayment.Rows(0)("AccountName").ToString()
                    BSBNumberTextBox.Text = dtPayment.Rows(0)("BSBNumber").ToString()
                    EFTAccountNumberTextBox.Text = dtPayment.Rows(0)("AccountNumber").ToString()
                    EFTPaymentAmountTextBox.Text = CDbl(dtPayment.Rows(0)("PaymentAmount").ToString()).ToString("N2")


                    If dtPayment.Rows(0)("PaymentDate").ToString() <> "" Then
                        EFTPaymentDateTextBox.Text = CDate(dtPayment.Rows(0)("PaymentDate")).ToString("dd/MM/yyyy")
                    End If

                    'EFTPaymentDateTextBox.Text = dtPayment.Rows(0)("PaymentDate").ToString()


                    IsProcessedEFTCheckBox.Checked = CBool(dtPayment.Rows(0)("IsProcessed"))
                End If

                sql = " SELECT ClaimNumber,RecordType,ChequeNumber,PaymentAmount,SupplierNumber,PaymentDate,IsProcessed " & _
                                "FROM dbo.tblChequePayment WHERE ClaimNumber='" & Me.ClaimNumber & "' AND RecordType='C' "

                adpPayment = New Odbc.OdbcDataAdapter(sql, con)
                dtPayment = New DataTable()
                adpPayment.Fill(dtPayment)

                If dtPayment.Rows.Count > 0 Then
                    ChequeAmountTextBox.Text = CDbl(dtPayment.Rows(0)("PaymentAmount").ToString()).ToString("N2")
                    ChequeNumberTextBox.Text = dtPayment.Rows(0)("ChequeNumber").ToString()
                    ChequeSupplierNumberTextBox.Text = dtPayment.Rows(0)("SupplierNumber").ToString()

                    If dtPayment.Rows(0)("PaymentDate").ToString() <> "" Then
                        ChequePaymentDateTextBox.Text = CDate(dtPayment.Rows(0)("PaymentDate")).ToString("dd/MM/yyyy")
                    End If

                    'ChequePaymentDateTextBox.Text = dtPayment.Rows(0)("PaymentDate").ToString()

                    IsProcessedChequeCheckBox.Checked = CBool(dtPayment.Rows(0)("IsProcessed"))
                End If

                con.Close()


            Catch ex As Exception
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                MsgBox(ex.Message, , "FillPhoneData()")


            End Try
        End Using

    End Sub

    Private Sub FillRemittanceData()

        Using con As New OdbcConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString)

            ' RemittanceDeliveryTypeComboBox.Text = ""
            PayeeNameTextBox.Text = ""
            AddresseeNameTextBox.Text = ""
            Street1TextBox.Text = ""
            Street2TextBox.Text = ""
            Street3TextBox.Text = ""
            CityTextBox.Text = ""
            'StateComboBox.Text = ""
            PostCodeTextBox.Text = ""
            'CountryTextBox.Text = ""
            FaxTextBox.Text = ""
            EmailTextBox.Text = ""
            RemittanceLayoutCodeTextBox.Text = ""
            ReturnToAddressCheckBox.Checked = False

            Try

                Dim dtRemittance As DataTable
                Dim adpRemittance As New System.Data.Odbc.OdbcDataAdapter

                Dim sql As String = " SELECT RemittanceDeliveryType ,PayeeName ,AddresseName ,Street1 ,Street2 ,Street3 ,City ,[State] ,PostCode,Country,Fax,Email,RemittanceLayoutCode,ReturnToAddressIdentifier " &
                                    " FROM dbo.tblRemittanceRecord WHERE ClaimNumber='" & Me.ClaimNumber & "' AND RecordType='R' "
                con.Open()
                adpRemittance = New Odbc.OdbcDataAdapter(sql, con)
                dtRemittance = New DataTable()
                adpRemittance.Fill(dtRemittance)

                If dtRemittance.Rows.Count > 0 Then
                    RemittanceDeliveryTypeComboBox.SelectedIndex = RemittanceDeliveryTypeComboBox.FindStringExact(dtRemittance.Rows(0)("RemittanceDeliveryType").ToString().Trim())


                    PayeeNameTextBox.Text = dtRemittance.Rows(0)("PayeeName").ToString()
                    AddresseeNameTextBox.Text = dtRemittance.Rows(0)("AddresseName").ToString()

                    Street1TextBox.Text = dtRemittance.Rows(0)("Street1").ToString()
                    Street2TextBox.Text = dtRemittance.Rows(0)("Street2").ToString()
                    Street3TextBox.Text = dtRemittance.Rows(0)("Street3").ToString()

                    CityTextBox.Text = dtRemittance.Rows(0)("City").ToString()
                    StateComboBox.SelectedIndex = StateComboBox.FindStringExact(dtRemittance.Rows(0)("State").ToString())
                    PostCodeTextBox.Text = dtRemittance.Rows(0)("PostCode").ToString()
                    'CountryTextBox.Text = dtRemittance.Rows(0)("Country").ToString()
                    FaxTextBox.Text = dtRemittance.Rows(0)("Fax").ToString()

                    EmailTextBox.Text = dtRemittance.Rows(0)("Email").ToString()
                    RemittanceLayoutCodeTextBox.Text = dtRemittance.Rows(0)("RemittanceLayoutCode").ToString()
                    ReturnToAddressCheckBox.Checked = Boolean.Parse(dtRemittance.Rows(0)("ReturnToAddressIdentifier").ToString())

                    ' RemittanceProcessDateTextBox.Text = dtRemittance.Rows(0)("RemittanceProcessDate").ToString()
                End If

                con.Close()

            Catch ex As Exception
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                MsgBox(ex.Message, , "FillPhoneData()")


            End Try
        End Using

    End Sub


    Private Sub FillMiscellaneousData()
        Using con As New OdbcConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString)

            Try
                Dim dtMiscData As DataTable
                Dim adpRemittance As New System.Data.Odbc.OdbcDataAdapter

                Dim sql As String = " SELECT cla_ClosedReason, PolicyNumber, hasOISstore " &
                                    " FROM dbo.tblClaim WHERE ClaimNumber='" & Me.ClaimNumber & "'"
                con.Open()
                adpRemittance = New Odbc.OdbcDataAdapter(sql, con)
                dtMiscData = New DataTable()
                adpRemittance.Fill(dtMiscData)

                If dtMiscData.Rows.Count > 0 Then
                    ComboBoxClosedReason.SelectedIndex = ComboBoxClosedReason.FindStringExact(dtMiscData.Rows(0)("cla_ClosedReason").ToString().Trim())
                    Me.PolicyNumberTextBox.Text = dtMiscData.Rows(0)("PolicyNumber").ToString()
                    ComboBoxOISstore.SelectedIndex = ComboBoxOISstore.FindStringExact(dtMiscData.Rows(0)("hasOISstore").ToString().Trim())

                End If

                con.Close()
            Catch ex As Exception
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                MsgBox(ex.Message, , "FillMiscellaneousData()")

            End Try
        End Using
    End Sub


    Public Sub SetClaimNumber(ByVal ClaimNumberValue As String)
        Me.ClaimNumber = ClaimNumberValue

        FillPaymentData()
        FillRemittanceData()
        FillMiscellaneousData()

        SaveClaim()
        If Me.ClaimNumber = "" Then
            Try
                Throw New Exception("No Claim Selected")
            Catch ex As Exception
                MsgBox(ex.ToString, , "SetClaimNumber(NULL)")
            End Try
        Else
            Try
                Me.mClaim = Claim.getClaim(ClaimNumberValue, True)
                Me.TblClaimBindingSource.DataSource = Me.mClaim
            Catch ex As Exception
                MsgBox(ex.ToString, , "SetClaimNumber(VALUE)")
            End Try
        End If
        Me.BringToFront()
        AutoValidateProcedure_AddHandlers()
    End Sub

#End Region 'Form Controls

#Region "Event Handlers"

#Region "Status"

    Private Sub StatusTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusTextBox.TextChanged
        Dim Changed_Color As Color = Me.Default_Color
        If Not StatusTextBox.Text = "" Then
            Dim Status As String
            Status = StatusTextBox.Text
            Me.Text = "Claim Number: " & mClaim.ClaimNumber & " for " & mClaim.GivenName & " " & mClaim.FamilyName
            If Status = "Cancelled" Then
                Call LockPhone()
                Changed_Color = Cancelled_Color
            ElseIf Status = "Paid" Then
                Call LockPhone()
                Changed_Color = Paid_Color
            ElseIf Status = "Declined" Then
                Call LockPhone()
                Changed_Color = Declined_Color
            Else
                Call UnlockPhone()
                Changed_Color = Default_Color
            End If
            BackColor = Changed_Color
            For Each i In ClaimDetailsTabControl.TabPages
                i.backcolor = Changed_Color
            Next
        End If
    End Sub

    Private Sub LockPhone()
        ReplacePhoneIDMultiColumnCombo.Enabled = False
        Cla_ReplacePhone_sup_idComboBox.Enabled = False
        CurrentPhoneIDMultiColumnCombo.Enabled = False

        OUseSupplierCheckBox.Enabled = False
        OSupplierNameTextBox.Enabled = False
        OPhoneTextBox.Enabled = False

        ReplaceCostTextBox.Enabled = False
        FreightCostTextBox.Enabled = False
    End Sub

    Private Sub UnlockPhone()
        ReplacePhoneIDMultiColumnCombo.Enabled = True
        Cla_ReplacePhone_sup_idComboBox.Enabled = True
        CurrentPhoneIDMultiColumnCombo.Enabled = True

        OUseSupplierCheckBox.Enabled = True
        OSupplierNameTextBox.Enabled = True
        OPhoneTextBox.Enabled = True

        ReplaceCostTextBox.Enabled = True
        FreightCostTextBox.Enabled = True
    End Sub

#End Region '*Status - Possible move to Class (low priority)*

#Region "Button Clicks"

    Private Sub CopyAddressButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
                                        Handles CopyAddressButton.Click
        mClaim.CopyAddress()
        RefreshFromLocalVar()
    End Sub

    Private Sub CheckClaimFamilyNameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckClaimFamilyNameButton.Click
        ClaimList.ShowDialog(, Me.FamilyNameTextBox.Text)
    End Sub

    Private Sub CheckClaimMobileNumberButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckClaimMobileNumberButton.Click
        ClaimList.ShowDialog(Me.MobilePhoneNumberTextBox.Text, )
    End Sub

    'Private Sub PreviewLetterReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviewLetterReportButton.Click
    '    If Not Me.SelectLetterMultiColumnCombo.Text = "" Then
    '        SaveClaim()
    '        ReportViewer.ShowDialog(Me.SelectLetterMultiColumnCombo.Text)
    '    Else
    '        MsgBox("No Letter Nominated in Drop Down List")
    '    End If
    'End Sub

#End Region 'Button Clicks - No Class change needed

#Region "Close & Saves"

    Private Sub AuditTabPage_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditTabPage.Enter
        SaveClaim()

        ' Added by Lipu: 10/03/2016
        SavePaymentData()
        SaveChequePaymentData()
        SaveRemittanceRecord()

    End Sub

    Private Sub ClaimsEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '    mClaim.isSaving = True
        SaveClaim()


        ' Added by Lipu: 10/03/2016
        SavePaymentData()
        SaveChequePaymentData()
        SaveRemittanceRecord()

        If Not Risk_Insure_Claims_Management_System.IsClosing Then
            SetClaimNumber(0)
            Me.ClaimDetailsTabControl.SelectedTab = Me.ClaimantDetailsTabPage
            Me.SendToBack()
            e.Cancel = True
        End If
        '   mClaim.isSaving = False
        ClaimsSearchEngine.WindowState = FormWindowState.Maximized
    End Sub

#End Region 'Close & Saves - No Class change needed

#Region "Claim Notes"

    Private Sub ClaimNumberTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClaimNumberTextBox.TextChanged
        Try
            If Not ClaimNumberTextBox.Text = "" Then
                Me.TblClaimNoteTableAdapter.FillBy(Me.RiskDataSet.tblClaimNote, ClaimNumberTextBox.Text)
                WriteAudit("Viewed")
                Me.TblAuditTableAdapter.Fill(Me.RiskDataSet.tblAudit, Me.ClaimNumberTextBox.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblClaimNoteDataGridView.CellClick
        Try
            Dim NoteID As Integer = Nothing
            Dim ValidUser As Boolean = False
            If Not e.ColumnIndex < 0 Then
                If TblClaimNoteDataGridView.Columns(e.ColumnIndex).Name = "Edit" Then
                    Try
                        NoteID = TblClaimNoteDataGridView.Rows(e.RowIndex).Cells("TextNoteID").Value
                    Catch arg_ex As ArgumentOutOfRangeException
                    Catch ex As Exception
                        MsgBox(ex.ToString, , "DataGridView1_CellClick")
                    End Try
                End If
                If Not NoteID = Nothing Then
                    ValidUser = ValidateUser()
                End If
                If ValidUser Then
                    EditNote.ShowDialog(Me.ClaimNumberTextBox.Text, True, NoteID)
                    ClaimNumberTextBox_TextChanged(sender, e)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, , "DataGridView1_CellClick")
        End Try
    End Sub

    Private Function ValidateUser() As Boolean
        Dim strMsg = "This form is used only by the ''Data Administrator''." & vbCrLf & vbLf & "Please key the ''Edit Notations'' password to allow access."
        Dim strInput = InputBox(Prompt:=strMsg, Title:="Special Password")
        If strInput = Correct_Password Then
            Return True
        Else
            MsgBox("Incorrect Password!" & vbCrLf & vbLf & "You are not allowed access to the ''Edit Notations Form''.", vbCritical, "Invalid Password")
            Return False
        End If
    End Function

    Private Sub AddNewNotationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewNotationButton.Click
        EditNote.ShowDialog(Me.ClaimNumberTextBox.Text)
        ClaimNumberTextBox_TextChanged(sender, e) 'Refresh Note List
    End Sub

#End Region '***Claim Notes - Evaluation of Class Design Required***

#Region "Zoom Form"

    Private Sub DamageTypeTextBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DamageTypeTextBox.DoubleClick
        Zoom_Form.ShowDialog(DamageTypeTextBox)
    End Sub

    Private Sub DiaryEntryTextBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiaryEntryTextBox.DoubleClick
        Zoom_Form.ShowDialog(DiaryEntryTextBox)
    End Sub

#End Region 'Zoom Form - No Class change needed

#Region "Binding Source Data Error"

    Private Sub TblClaimBindingSource_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.BindingManagerDataErrorEventArgs) Handles TblClaimBindingSource.DataError
        MsgBox(e.Exception.Message, , "TblClaimBindingSource_DataError")
    End Sub

#End Region 'Binding Source Data Error - No Class change needed

#Region "Address"

    Private Sub LookupPostcode(ByVal Postcode As String)
        PostCode_Lookup.Showdialog(Postcode)
    End Sub

    Private Sub PostalPostCode_Changed() Handles mClaim.PostalPostCode_Changed
        LookupPostcode(mClaim.PostalPostcode)
    End Sub

    Private Sub DeliveryPostCode_Changed() Handles mClaim.DeliveryPostCode_Changed
        LookupPostcode(mClaim.DeliveryPostcode)
    End Sub

    Private Sub DealerPostCode_Changed() Handles mClaim.DealerPostCode_Changed
        LookupPostcode(mClaim.PhoneDealelPostCode)
    End Sub

#End Region 'Address - FULL OOP  - No change required

#Region "oUseSupplier"

    Private Sub oUseOtherSupplier_True() Handles mClaim.oUseOtherSupplier_True
        Cla_ReplacePhone_sup_idComboBox.Enabled = False
        ReplacePhoneIDMultiColumnCombo.Enabled = False
        ReplaceCostTextBox.ReadOnly = False
        ReplaceCostTextBox.Enabled = True
        Cla_ReplacePhoneRRPTextBox.ReadOnly = False
        Cla_ReplacePhoneRRPTextBox.Enabled = True 'Phase One Amendments
        Cla_FreightCostTypeComboBox.Enabled = False
        FreightCostTextBox.Enabled = True
        FreightCostTextBox.ReadOnly = False
        OSupplierNameTextBox.Enabled = True
        OPhoneTextBox.Enabled = True
        OSupplierNameTextBox.ReadOnly = False 'Phase Two Amendments
        OPhoneTextBox.ReadOnly = False 'Phase Two Amendments
    End Sub

    Private Sub oUseOtherSupplier_False() Handles mClaim.oUseOtherSupplier_False
        Cla_ReplacePhone_sup_idComboBox.Enabled = True
        ReplacePhoneIDMultiColumnCombo.Enabled = True
        ReplaceCostTextBox.ReadOnly = True
        ReplaceCostTextBox.Enabled = False
        Cla_ReplacePhoneRRPTextBox.ReadOnly = True
        Cla_ReplacePhoneRRPTextBox.Enabled = False 'Phase One Amendments
        Cla_FreightCostTypeComboBox.Enabled = True
        FreightCostTextBox.Enabled = False
        FreightCostTextBox.ReadOnly = True
        OSupplierNameTextBox.Enabled = False
        OPhoneTextBox.Enabled = False
        OSupplierNameTextBox.ReadOnly = True 'Phase Two Amendments
        OPhoneTextBox.ReadOnly = True 'Phase Two Amendments
    End Sub



#End Region 'oUseSupplier - FULL OOP  - No change required

#End Region 'Event Handlers


#Region "Basic Command (Save)"

    Private Sub RefreshFromLocalVar()
        TblClaimBindingSource.ResetBindings(False)
    End Sub
#End Region ' Basic Command (Save)


    Public Shared DefaultReportPath As String '= IO.Directory.GetCurrentDirectory + "\Crystal\Risk_Letters\Risk_Letters\Crystal"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLetterReportButton.Click
        Dim FILE = New OpenFileDialog With {.Filter = "Report files (*.rpt)|*.rpt|All files (*.*)|*.*", .InitialDirectory = DefaultReportPath} ', .DefaultExt = "*.rpt"}
        FILE.ShowDialog()
        SaveClaim()

        If FILE.SafeFileName.Length > 1 Then
            ReportViewer.ShowDialog(FILE.FileName)
        End If

        'If FILE.SafeFileName.Length > 1 Then
        '    ReportViewer.ShowDialog(FILE.SafeFileName.Substring(0, FILE.SafeFileName.Length - 4))
        'End If

    End Sub

    Private Sub SavePaymentData()

        If ClaimNumberTextBox.Text = "" Then
            Return
        End If

        Try
            If EFTPaymentDateTextBox.Text.Trim() <> "" Then
                Me.paymentDate = EFTPaymentDateTextBox.Text

                If Me.paymentDate < "1900-01-01" Or Me.paymentDate > "2100-01-01" Then
                    MsgBox("This is not a valid EFT payment date.", , "EFT Payment")
                    Return
                End If

            End If
        Catch ex As Exception
            MsgBox("This is not a valid EFT payment date.", , "EFT Payment")
            Return
        End Try

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString
        Try

            Using con As New OdbcConnection(constring)
                Using cmd As New OdbcCommand("{? = CALL dbo.Payment(?, ?, ?, ?, ?, ?, ?,?)}", con)

                    cmd.CommandType = CommandType.StoredProcedure

                    Dim prm As OdbcParameter = cmd.Parameters.Add("@RETURN_VALUE", OdbcType.Int)
                    prm.Direction = ParameterDirection.ReturnValue

                    Dim ClaimNumber As OdbcParameter = cmd.Parameters.Add("@ClaimNumber", OdbcType.VarChar, 50)
                    ClaimNumber.Value = ClaimNumberTextBox.Text

                    Dim EFTSupplierNumber As OdbcParameter = cmd.Parameters.Add("@EFTSupplierNumber", OdbcType.VarChar, 50)
                    EFTSupplierNumber.Value = ""

                    Dim AccountName As OdbcParameter = cmd.Parameters.Add("@AccountName", OdbcType.VarChar, 50)
                    AccountName.Value = AccountNameTextBox.Text

                    Dim BSBNumber As OdbcParameter = cmd.Parameters.Add("@BSBNumber", OdbcType.VarChar, 20)
                    BSBNumber.Value = BSBNumberTextBox.Text

                    Dim AccountNumber As OdbcParameter = cmd.Parameters.Add("@AccountNumber", OdbcType.VarChar, 20)
                    AccountNumber.Value = EFTAccountNumberTextBox.Text

                    Dim EFTPaymentAmount As OdbcParameter = cmd.Parameters.Add("@EFTPaymentAmount", OdbcType.Double)

                    If EFTPaymentAmountTextBox.Text = "" Then
                        EFTPaymentAmount.Value = 0
                    Else
                        EFTPaymentAmount.Value = EFTPaymentAmountTextBox.Text
                    End If

                    Dim EFTPaymentDate As OdbcParameter = cmd.Parameters.Add("@EFTPaymentDate", OdbcType.DateTime)

                    If EFTPaymentDateTextBox.Text.Trim() = "" Then
                        EFTPaymentDate.Value = DBNull.Value
                    Else
                        EFTPaymentDate.Value = Me.paymentDate
                    End If

                    'If EFTPaymentDateTextBox.Text = "  /  /" Then
                    '    'EFTPaymentDate.Value = "1900-01-01"
                    '    EFTPaymentDate.Value = DBNull.Value
                    'Else
                    '    EFTPaymentDate.Value = DateTime.Parse(EFTPaymentDateTextBox.Text)
                    'End If

                    Dim IsProcessed As OdbcParameter = cmd.Parameters.Add("@IsProcessed", OdbcType.Bit)
                    IsProcessed.Value = IsProcessedEFTCheckBox.Checked

                    con.Open()
                    cmd.ExecuteNonQuery()

                    con.Close()
                End Using
            End Using

        Catch ex As Exception
            'MessageBox.Show("Error while Saving Payment Data!!! " & ex.ToString())

            Try
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("V:\Mobile Claims\PAYMENT\ERROR\VMA\errLog_" & Risk_Insure_Claims_Management_System.UserName & ".txt", True)
                file.WriteLine("Start Time: " & DateTime.Now.ToString())
                file.WriteLine("Claim No: " & ClaimNumberTextBox.Text &
                               ", Payment Date: " & EFTPaymentDateTextBox.Text &
                               ", Account Name: " & AccountNameTextBox.Text &
                               ", Account No: " & EFTAccountNumberTextBox.Text &
                               ", BSB: " & BSBNumberTextBox.Text &
                               ", Amount: " & EFTPaymentAmountTextBox.Text
                               )
                file.WriteLine("Error while Saving Payment Data!!! ")
                file.WriteLine(ex.ToString())
                file.WriteLine()
                file.Close()
            Catch ex1 As Exception
            End Try


        End Try
    End Sub

    Private Sub SaveChequePaymentData()

        If ClaimNumberTextBox.Text = "" Then
            Return
        End If

        Try
            If ChequePaymentDateTextBox.Text.Trim() <> "" Then
                Me.paymentDate = ChequePaymentDateTextBox.Text

                If Me.paymentDate < "1900-01-01" Or Me.paymentDate > "2099-01-01" Then
                    MsgBox("This is not a valid cheque payment date.", , "cheque Payment")
                    Return
                End If
            End If
        Catch ex As Exception
            MsgBox("This is not a valid cheque payment date.", , "cheque Payment")
            Return
        End Try

        'If Not ChequeAmountTextBox.Text = "" And Not ChequeAmountTextBox.Text = ".00" And Not ChequeAmountTextBox.Text = "0.00" Then
        '    If Not RemittanceDeliveryTypeComboBox.Text = "POST" Then
        '        MsgBox("Select Remittance Delivery Type as POST")
        '        Return
        '    End If
        'End If

        'MsgBox(ChequePaymentDateTextBox.Text & "Mask date")

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString
        Try
            Using con As New OdbcConnection(constring)
                Using cmd As New OdbcCommand("{? = CALL dbo.ChequePayment(?, ?, ?, ?, ?, ?)}", con)

                    cmd.CommandType = CommandType.StoredProcedure

                    Dim prm As OdbcParameter = cmd.Parameters.Add("@RETURN_VALUE", OdbcType.Int)
                    prm.Direction = ParameterDirection.ReturnValue

                    Dim ClaimNumber As OdbcParameter = cmd.Parameters.Add("@ClaimNumber", OdbcType.VarChar, 50)
                    ClaimNumber.Value = ClaimNumberTextBox.Text

                    Dim ChequePaymentDate As OdbcParameter = cmd.Parameters.Add("@ChequePaymentDate", OdbcType.DateTime)


                    If ChequePaymentDateTextBox.Text.Trim() = "" Then
                        ChequePaymentDate.Value = DBNull.Value
                        ' MsgBox(ChequePaymentDate.Value & "Mask date value")

                    Else
                        ChequePaymentDate.Value = Me.paymentDate
                    End If


                    Dim ChequeSupplierNumber As OdbcParameter = cmd.Parameters.Add("@ChequeSupplierNumber", OdbcType.VarChar, 20)
                    ChequeSupplierNumber.Value = ChequeSupplierNumberTextBox.Text

                    Dim ChequeNumber As OdbcParameter = cmd.Parameters.Add("@ChequeNumber", OdbcType.VarChar, 50)
                    ChequeNumber.Value = ChequeNumberTextBox.Text

                    Dim ChequePaymentAmount As OdbcParameter = cmd.Parameters.Add("@ChequePaymentAmount", OdbcType.Double)

                    If ChequeAmountTextBox.Text = "" Then
                        ChequePaymentAmount.Value = 0
                    Else
                        ChequePaymentAmount.Value = ChequeAmountTextBox.Text
                    End If

                    Dim IsProcessed As OdbcParameter = cmd.Parameters.Add("@IsProcessed", OdbcType.Bit)
                    IsProcessed.Value = IsProcessedChequeCheckBox.Checked

                    con.Open()
                    cmd.ExecuteNonQuery()

                    con.Close()
                End Using
            End Using

        Catch ex As Exception
            'MessageBox.Show("Error while Saving Cheque Payment Data!!! " & ex.ToString())

            Try
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("V:\Mobile Claims\PAYMENT\ERROR\VMA\errLog_" & Risk_Insure_Claims_Management_System.UserName & ".txt", True)
                file.WriteLine("Start Time: " & DateTime.Now.ToString())
                file.WriteLine("Claim No: " & ClaimNumberTextBox.Text &
                               ", Payment Date: " & ChequePaymentDateTextBox.Text &
                               ", Cheque Number: " & ChequeNumberTextBox.Text &
                               ", Amount: " & ChequeAmountTextBox.Text)

                file.WriteLine("Error while Saving Cheque Payment Data!!!")
                file.WriteLine(ex.ToString())
                file.WriteLine()
                file.Close()
            Catch ex1 As Exception

            End Try
        End Try
    End Sub

    Private Sub SaveRemittanceRecord()

        If ClaimNumberTextBox.Text = "" Then
            Return
        End If

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString

        Try
            Using con As New OdbcConnection(constring)
                Using cmd As New OdbcCommand("{? = CALL dbo.RemittanceRecord(?, ?, ?, ?, ?, ?, ?, ?, ?,?,?,?,?,?,?)}", con)

                    cmd.CommandType = CommandType.StoredProcedure

                    Dim prm As OdbcParameter = cmd.Parameters.Add("@RETURN_VALUE", OdbcType.Int)
                    prm.Direction = ParameterDirection.ReturnValue

                    Dim ClaimNumber As OdbcParameter = cmd.Parameters.Add("@ClaimNumber", OdbcType.NVarChar, 8)
                    ClaimNumber.Value = ClaimNumberTextBox.Text

                    Dim RemittanceDeliveryType As OdbcParameter = cmd.Parameters.Add("@RemittanceDeliveryType", OdbcType.VarChar, 50)
                    RemittanceDeliveryType.Value = RemittanceDeliveryTypeComboBox.Text

                    Dim PayeeName As OdbcParameter = cmd.Parameters.Add("@PayeeName", OdbcType.VarChar, 100)
                    PayeeName.Value = PayeeNameTextBox.Text


                    Dim AddresseName As OdbcParameter = cmd.Parameters.Add("@AddresseName", OdbcType.VarChar, 100)
                    AddresseName.Value = AddresseeNameTextBox.Text

                    Dim Street1 As OdbcParameter = cmd.Parameters.Add("@Street1", OdbcType.VarChar, 40)
                    Street1.Value = Street1TextBox.Text

                    Dim Street2 As OdbcParameter = cmd.Parameters.Add("@Street2", OdbcType.VarChar, 40)
                    Street2.Value = Street2TextBox.Text

                    Dim Street3 As OdbcParameter = cmd.Parameters.Add("@Street3", OdbcType.VarChar, 40)
                    Street3.Value = Street3TextBox.Text

                    Dim City As OdbcParameter = cmd.Parameters.Add("@City", OdbcType.VarChar, 50)
                    City.Value = CityTextBox.Text


                    Dim State As OdbcParameter = cmd.Parameters.Add("@State", OdbcType.VarChar, 10)
                    State.Value = StateComboBox.Text

                    Dim PostCode As OdbcParameter = cmd.Parameters.Add("@PostCode", OdbcType.VarChar, 20)
                    PostCode.Value = PostCodeTextBox.Text

                    Dim Country As OdbcParameter = cmd.Parameters.Add("@Country", OdbcType.VarChar, 50)
                    Country.Value = CountryTextBox.Text


                    Dim Fax As OdbcParameter = cmd.Parameters.Add("@Fax", OdbcType.VarChar, 20)
                    Fax.Value = FaxTextBox.Text

                    Dim Email As OdbcParameter = cmd.Parameters.Add("@Email", OdbcType.VarChar, 128)
                    Email.Value = EmailTextBox.Text

                    Dim RemittanceLayoutCode As OdbcParameter = cmd.Parameters.Add("@RemittanceLayoutCode", OdbcType.VarChar, 2)
                    RemittanceLayoutCode.Value = RemittanceLayoutCodeTextBox.Text

                    Dim ReturnToAddressIdentifier As OdbcParameter = cmd.Parameters.Add("@ReturnToAddressIdentifier", OdbcType.Bit)
                    ReturnToAddressIdentifier.Value = ReturnToAddressCheckBox.Checked

                   
                    con.Open()
                    cmd.ExecuteNonQuery()

                    con.Close()
                End Using
            End Using

        Catch ex As Exception
            'MessageBox.Show("Error while Saving Remittance Data!!! " & ex.ToString())
            Try
                Dim file As System.IO.StreamWriter
                file = My.Computer.FileSystem.OpenTextFileWriter("V:\Mobile Claims\PAYMENT\ERROR\VMA\errLog_" & Risk_Insure_Claims_Management_System.UserName & ".txt", True)
                file.WriteLine("Start Time: " & DateTime.Now.ToString())
                file.WriteLine("Claim No: " & ClaimNumberTextBox.Text)
                file.WriteLine("Error While Saving Remittance Data!!! ")
                file.WriteLine(ex.ToString())
                file.WriteLine()
                file.Close()
            Catch ex1 As Exception

            End Try


        End Try
    End Sub

    Private Sub SaveRefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRefreshButton.Click
        SaveClaim()

        ' Added by Lipu: 09/03/2016
        SavePaymentData()
        SaveChequePaymentData()
        SaveRemittanceRecord()
    End Sub

    Private Sub EFTAmountTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EFTPaymentAmountTextBox.KeyPress


        If DirectCast(sender, TextBox).Text.Length > 6 Then
            If e.KeyChar = ControlChars.Back Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
        End If

        If ((e.KeyChar = ".") And (DirectCast(sender, TextBox).Text.IndexOf(".") > -1)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ChequeAmountTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChequeAmountTextBox.KeyPress

        If DirectCast(sender, TextBox).Text.Length > 6 Then
            If e.KeyChar = ControlChars.Back Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

        If Char.IsControl(e.KeyChar) = False And Char.IsDigit(e.KeyChar) = False And e.KeyChar <> "." Then
            e.Handled = True
        End If

        If ((e.KeyChar = ".") And (DirectCast(sender, TextBox).Text.IndexOf(".") > -1)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BSBNumberTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BSBNumberTextBox.KeyPress
        If e.KeyChar = ControlChars.Back Then
            e.Handled = False
        ElseIf (Char.IsDigit(e.KeyChar)) And DirectCast(sender, TextBox).Text.Length < 6 Then
            e.Handled = False
        Else
            e.Handled = True
            BSBNumberTextBox.Text = BSBNumberTextBox.Text.Replace("-", "")
        End If
    End Sub

    Private Sub BSBNumberTextBox_Leave(sender As Object, e As EventArgs) Handles BSBNumberTextBox.Leave

        If DirectCast(sender, TextBox).Text.Length > 0 And DirectCast(sender, TextBox).Text.Length < 6 Then
            DirectCast(sender, TextBox).Focus()
            MsgBox("Please enter 6 digits BSB No or keep it empty")
        End If

        If DirectCast(sender, TextBox).Text.Length > 3 And DirectCast(sender, TextBox).Text.IndexOf("-") = -1 Then
            DirectCast(sender, TextBox).Text = DirectCast(sender, TextBox).Text.Insert(3, "-")
        End If
    End Sub

    Private Sub EFTPaymentAmountTextBox_Leave(sender As Object, e As EventArgs) Handles EFTPaymentAmountTextBox.Leave

        Dim TextBox = DirectCast(sender, TextBox)
        If TextBox.Text.IndexOf(".") > -1 Then
            If TextBox.Text.Substring(TextBox.Text.IndexOf(".")).Length >= 3 Then
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.IndexOf(".") + 3)
            End If

            If TextBox.Text.Substring(TextBox.Text.IndexOf(".")).Length = 2 Then
                TextBox.Text = TextBox.Text & "0"
            End If
            If TextBox.Text.Substring(TextBox.Text.IndexOf(".")).Length = 1 Then
                TextBox.Text = TextBox.Text & "00"
            End If
        Else
            TextBox.Text = TextBox.Text & ".00"
        End If

        Try
            If Convert.ToDouble(TextBox.Text) > 1999.99 Then
                MessageBox.Show(" EFT amount should not exceed $1999.99", "$Amount")
                EFTPaymentAmountTextBox.Focus()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ChequeAmountTextBox_Leave(sender As Object, e As EventArgs) Handles ChequeAmountTextBox.Leave
        Dim TextBox = DirectCast(sender, TextBox)
        If TextBox.Text.IndexOf(".") > -1 Then
            If TextBox.Text.Substring(TextBox.Text.IndexOf(".")).Length >= 3 Then
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.IndexOf(".") + 3)
            End If

            If TextBox.Text.Substring(TextBox.Text.IndexOf(".")).Length = 2 Then
                TextBox.Text = TextBox.Text & "0"
            End If
            If TextBox.Text.Substring(TextBox.Text.IndexOf(".")).Length = 1 Then
                TextBox.Text = TextBox.Text & "00"
            End If
        Else
            TextBox.Text = TextBox.Text & ".00"
        End If


        Try
            If Convert.ToDouble(TextBox.Text) > 1999.99 Then
                MessageBox.Show(" Cheque amount should not exceed $1999.99", "$Amount")
                ChequeAmountTextBox.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BSBNumberTextBox_Enter(sender As Object, e As EventArgs) Handles BSBNumberTextBox.Enter
        If BSBNumberTextBox.Text.Length > 3 Then
            BSBNumberTextBox.Text = BSBNumberTextBox.Text.Remove(3, 1)
        End If
    End Sub
    Private Sub ClaimDetailsTabPage_Click(sender As Object, e As EventArgs) Handles ClaimDetailsTabPage.Click

    End Sub

    Private Sub ExcessLabel_Click(sender As Object, e As EventArgs) Handles ExcessLabel.Click

    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click

    End Sub

    Private Sub CopyAccountHoldersButton_Click(sender As Object, e As EventArgs) Handles CopyAccountHoldersButton.Click

        PayeeNameTextBox.Text = TitleComboBox.Text & " " & GivenNameTextBox.Text & " " & FamilyNameTextBox.Text
        AddresseeNameTextBox.Text = TitleComboBox.Text & " " & GivenNameTextBox.Text & " " & FamilyNameTextBox.Text
        Street1TextBox.Text = PostalAddress1TextBox.Text
        Street2TextBox.Text = PostalAddress2TextBox.Text

        StateComboBox.SelectedIndex = StateComboBox.FindStringExact(Cla_PostalStateTextBox.Text)
        PostCodeTextBox.Text = PostalPostcodeTextBox.Text

        Dim i As Integer = 0
        Try
            i = PostalSuburbMultiColumnCombo.Text.Substring(0, PostalSuburbMultiColumnCombo.Text.LastIndexOf(" ")).LastIndexOf(" ")
        Catch ex As Exception
            i = 0
        End Try

        CityTextBox.Text = PostalSuburbMultiColumnCombo.Text.Substring(0, i)

        FaxTextBox.Text = FaxNumberTextBox.Text
        EmailTextBox.Text = CustomerEmailTextBox.Text

        ' MsgBox("Postal Address Copied to Delivery Address")
    End Sub

    'Private Sub EFTPaymentDateTextBox_Leave(sender As Object, e As EventArgs) Handles EFTAccountNumberTextBox.Leave

    '    If DirectCast(sender, MaskedTextBox).Text.Replace("/", "").Trim().Length = 0 Then
    '        Return
    '    End If

    '    Dim dateValue As Date
    '    Dim enAU As New System.Globalization.CultureInfo("en-AU") 'dd/MM/yyyy

    '    If (DateTime.TryParseExact(DirectCast(sender, MaskedTextBox).Text, "dd/MM/yyyy", enAU, Globalization.DateTimeStyles.None, dateValue)) Then
    '        If (DateTime.Parse(DirectCast(sender, MaskedTextBox).Text)) < "01/01/1900" Then
    '            MsgBox(DirectCast(sender, MaskedTextBox).Text & " is not a valid date. Date should be greater than 01/01/1900")
    '            DirectCast(sender, MaskedTextBox).Focus()
    '        End If
    '    Else
    '        MsgBox(DirectCast(sender, MaskedTextBox).Text & " is not a valid date. Correct date format is: dd/MM/yyyy")
    '        DirectCast(sender, MaskedTextBox).Focus()
    '    End If

    'End Sub

    'Private Sub ChequePaymentDateTextBox_Leave(sender As Object, e As EventArgs)
    '    If DirectCast(sender, MaskedTextBox).Text.Replace("/", "").Trim().Length = 0 Then
    '        Return
    '    End If

    '    Dim dateValue As Date
    '    Dim enAU As New System.Globalization.CultureInfo("en-AU") 'dd/MM/yyyy

    '    If (DateTime.TryParseExact(DirectCast(sender, MaskedTextBox).Text, "dd/MM/yyyy", enAU, Globalization.DateTimeStyles.None, dateValue)) Then
    '        If (DateTime.Parse(DirectCast(sender, MaskedTextBox).Text)) < "01/01/1900" Then
    '            MsgBox(DirectCast(sender, MaskedTextBox).Text & " is not a valid date. Date should be greater than 01/01/1900")
    '            DirectCast(sender, MaskedTextBox).Focus()
    '        End If
    '    Else
    '        MsgBox(DirectCast(sender, MaskedTextBox).Text & " is not a valid date. Correct date format is: dd/MM/yyyy")
    '        DirectCast(sender, MaskedTextBox).Focus()
    '    End If
    'End Sub

    Private Sub EFTPaymentDateTextBox_Leave(sender As Object, e As EventArgs) Handles EFTPaymentDateTextBox.Leave
        Try
            If EFTPaymentDateTextBox.Text.Trim() <> "" Then
                Me.paymentDate = EFTPaymentDateTextBox.Text

                If Me.paymentDate < "1900-01-01" Or Me.paymentDate > "2100-01-01" Then
                    MsgBox("This is not a valid EFT payment date.", , "EFT Payment")
                    EFTPaymentDateTextBox.Focus()
                End If

            End If
        Catch ex As Exception
            MsgBox("This is not a valid EFT payment date.", , "EFT Payment")
            EFTPaymentDateTextBox.Focus()
        End Try
    End Sub

    Private Sub ChequePaymentDateTextBox_Leave(sender As Object, e As EventArgs) Handles ChequePaymentDateTextBox.Leave
        Try
            If ChequePaymentDateTextBox.Text.Trim() <> "" Then
                Me.paymentDate = ChequePaymentDateTextBox.Text

                If Me.paymentDate < "1900-01-01" Or Me.paymentDate > "2099-01-01" Then
                    MsgBox("This is not a valid cheque payment date.", , "cheque Payment")
                    ChequePaymentDateTextBox.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox("This is not a valid cheque payment date.", , "cheque Payment")
            ChequePaymentDateTextBox.Focus()
        End Try
    End Sub

    Private Function PaymentAdminUser() As Boolean
        Dim strMsg = "This form is used only by the ''Data Administrator''." & vbCrLf & vbLf & "Please key the ''Payment Process Option'' password to allow access."
        Dim strInput = InputBox(Prompt:=strMsg, Title:="Special Password")
        If strInput = Payment_Admin Then
            Return True
        Else
            MsgBox("Incorrect Password!" & vbCrLf & vbLf & "You are not allowed to modify the ''Payment Process Option''.", vbCritical, "Invalid Password")
            Return False
        End If
    End Function

    Private Sub IsProcessedEFTCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsProcessedEFTCheckBox.Click
        If IsProcessedEFTCheckBox.Checked = False Then
            If PaymentAdminUser() Then
                IsProcessedEFTCheckBox.Checked = False
            Else
                IsProcessedEFTCheckBox.Checked = True
            End If
        End If
    End Sub

    Private Sub IsProcessedChequeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsProcessedChequeCheckBox.Click
        If IsProcessedChequeCheckBox.Checked = False Then
            If PaymentAdminUser() Then
                IsProcessedChequeCheckBox.Checked = False
            Else
                IsProcessedChequeCheckBox.Checked = True
            End If
        End If
    End Sub
End Class 'ClaimsEdit

