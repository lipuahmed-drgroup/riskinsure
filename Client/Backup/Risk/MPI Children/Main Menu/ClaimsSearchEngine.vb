Public Class ClaimsSearchEngine

    Private Sub ClaimsSearchEngine_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated


        Try

            'Me.ta.Fill(Me.RiskDataSet.tblClaim_Search, ClaimNoTextBox.Text, MobileNoTextBox.Text, FamilyNameTextBox.Text, GivenNameTextBox.Text, SuburbComboBox.Text, StatusComboBox.Text, StateComboBox.Text, LocalAddressTextBox.Text)
            'Catch Ex_constraint As ConstraintException
            'Do Nothing
        Catch ex As Exception
            MsgBox(ex.Message, , "ClaimsSearchEngine_Activated()")
        End Try



    End Sub





    Private Sub TblClaimBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TblClaimBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblClaimBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RiskDataSet)

    End Sub

    Private Sub ClaimsSearchEngine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.WindowState = FormWindowState.Maximized
        Me.StatusListTableAdapter.Fill(Me.RiskDataSet.StatusList)
        Me.StateListTableAdapter.Fill(Me.RiskDataSet.StateList)
        Me.SuburbListTableAdapter.Fill(Me.RiskDataSet.SuburbList)

        Me.MdiParent = mdiParentForm

        TblClaimDataGridView.AutoGenerateColumns = False
        'TblClaimDataGridView.DataSource = TblClaimBindingSource

        'Me.TblClaimTableAdapter.Fill(Me.RiskDataSet.tblClaim)
        'Me.TblClaimTableAdapter.Search_Fill(Me.RiskDataSet.tblClaim)
        DateLabel.Text = FormatDateTime(Date.Now, DateFormat.LongDate)



        'tb.DataSource = RiskDataSet.tblClaim_Search
        tb.DataSource = RiskDataSet.ClaimSearch
        TblClaimDataGridView.DataSource = tb

        TblClaimBindingNavigator.BindingSource = tb


    End Sub

    'Private ta As New RiskDataSetTableAdapters.tblClaim_SearchTableAdapter
    Private ta As New RiskDataSetTableAdapters.ClaimSearchTableAdapter
    Private tb As BindingSource = New BindingSource



    Private Sub FindClaimButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindClaimButton.Click
        '  Dim searchString As String = ""

        'AddSearch(ClaimNoTextBox, "ClaimNumber", searchString)
        'AddSearch(MobileNoTextBox, "MobilePhoneNumber", searchString)
        'AddSearch(FamilyNameTextBox, "FamilyName", searchString)
        'AddSearch(GivenNameTextBox, "GivenName", searchString)
        'AddSearch(SuburbComboBox, "PostalSuburb", searchString)
        'AddSearch(StateComboBox, "cla_PostalState", searchString)
        'AddSearch(StatusComboBox, "Status", searchString)
        'AddSearch(LocalAddressTextBox, "PostalAddress1", searchString)
        'Try
        '    TblClaimBindingSource.Filter = searchString
        'Catch ex As Exception
        '    MsgBox("Error in search criteria")
        'End Try

        RefreshTa()
 


    End Sub


    Friend Sub RefreshTa()

        Try
            ' Me.ta.FillBy(Me.RiskDataSet.tblClaim_Search, ClaimNoTextBox.Text, MobileNoTextBox.Text, FamilyNameTextBox.Text, GivenNameTextBox.Text, SuburbComboBox.Text, StatusComboBox.Text, StateComboBox.Text, LocalAddressTextBox.Text)
            Me.ta.Fill(Me.RiskDataSet.ClaimSearch, ClaimNoTextBox.Text, MobileNoTextBox.Text, FamilyNameTextBox.Text, GivenNameTextBox.Text, SuburbComboBox.Text, StatusComboBox.Text, StateComboBox.Text, LocalAddressTextBox.Text)

            'Me.ta.Fill(Me.RiskDataSet.tblClaim_Search, ClaimNoTextBox.Text, MobileNoTextBox.Text, FamilyNameTextBox.Text, GivenNameTextBox.Text, SuburbComboBox.Text, StatusComboBox.Text, StateComboBox.Text, LocalAddressTextBox.Text)
            'Catch Ex_constraint As ConstraintException
            'Do Nothing
        Catch ex As Exception
            MsgBox(ex.Message, , "FindClaimButton_Click()")
        End Try

    End Sub

    'Private Sub AddSearch(ByVal SearchValue As Object, ByVal searchField As String, ByRef searchString As String)
    '    If Not SearchValue.Text = "" Then
    '        If Not searchString = "" Then
    '            searchString += " and "
    '        End If
    '        searchString += searchField + " like '%" + SearchValue.Text + "%'"
    '    End If
    'End Sub



    Private Sub RunSearchQuery(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then
            FindClaimButton_Click(Nothing, Nothing)
        ElseIf e.KeyChar = Chr(Keys.Escape) Then
            ClearCriteriaButton_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub LocalAddressTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SuburbComboBox.KeyPress, StatusComboBox.KeyPress, StateComboBox.KeyPress, MyBase.KeyPress, MobileNoTextBox.KeyPress, LocalAddressTextBox.KeyPress, GivenNameTextBox.KeyPress, FamilyNameTextBox.KeyPress, ClaimNoTextBox.KeyPress
        RunSearchQuery(e)
    End Sub


    Private Sub ClearCriteriaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearCriteriaButton.Click
        ClaimNoTextBox.Text = ""
        MobileNoTextBox.Text = ""
        FamilyNameTextBox.Text = ""
        GivenNameTextBox.Text = ""
        SuburbComboBox.Text = ""
        StateComboBox.Text = ""
        StatusComboBox.Text = ""
        LocalAddressTextBox.Text = ""
        FindClaimButton_Click(Nothing, Nothing)

    End Sub

    Private Sub TblClaimDataGridView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblClaimDataGridView.CellDoubleClick
        Dim ClaimNumberValue As String = TblClaimDataGridView(ClaimNumber.Index, TblClaimDataGridView.CurrentRow.Index).Value
        ClaimsEdit.SetClaimNumber(ClaimNumberValue)
        ClaimsEdit.Show()
        ClaimsEdit.BringToFront()


    End Sub
    Private mdiParentForm = Risk_Insure_Claims_Management_System
    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        If Not Me.MdiParent Is Nothing Then
            Me.MdiParent = Nothing
            Me.UndockButton.Text = "Dock"
        Else
            Me.MdiParent = mdiParentForm
            Me.UndockButton.Text = "Undock"
        End If
    End Sub




    Private Sub AddNewClaimButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewClaimButton.Click
        Dim LResponse As Integer

        LResponse = MsgBox("Do you wish to continue adding a new claim?", vbYesNo, "Add New Claim")

        If LResponse = vbYes Then

            Dim NewClaim As New RiskDataSetTableAdapters.NewClaimTableAdapter
            Dim NewClaimNumber As String = NewClaim.NewClaim

            ClaimsEdit.SetClaimNumber(NewClaimNumber)
            ClaimsEdit.Show()
            ClaimsEdit.BringToFront()
            'Me.RefreshTa()



            'Me.TblClaimTableAdapter.Fill(Me.RiskDataSet.tblClaim)
        Else
            ' {... statements...}
        End If


    End Sub


    Private Sub AddNewClaimButton_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddNewClaimButton.DoubleClick





    End Sub


End Class