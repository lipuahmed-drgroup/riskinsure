Public Class ClaimsEdit

#Region "Form Settings"
    Public Shared Cancelled_Color As Color ' = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(192, Byte), Integer))
    Public Shared Paid_Color As Color ' =  System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
    Public Shared Declined_Color As Color ' = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(204, Byte), Integer))
    Public Shared Default_Color As Color ' = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
    Public Shared Correct_Password As String ' = "zulu"
#End Region 'Form Settings

#Region "Form Controls"

    Private WithEvents mClaim As Claim
    Private ClaimNumber As String
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
            GSTRegisteredFlagComboBox.DataSource = YesNo.YesNos
            ' - FreightType
            Cla_FreightCostTypeComboBox.DataSource = FreightCostType.FreightCostTypes

        Catch ex As Exception
            MsgBox(ex.ToString, , "FillTables()")
        End Try

    End Sub




    Public Sub SetClaimNumber(ByVal ClaimNumberValue As String)
        Me.ClaimNumber = ClaimNumberValue
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



    End Sub

    Private Sub ClaimsEdit_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        '    mClaim.isSaving = True
        SaveClaim()
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



    Private Sub SaveRefreshButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveRefreshButton.Click
        SaveClaim()
    End Sub
End Class 'ClaimsEdit

