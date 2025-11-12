Imports System.Data.Odbc

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
        'Me.WindowState = FormWindowState.Maximized
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

    Private Sub FindClaimButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindClaimButton.Click, StateComboBox.TextChanged, StatusComboBox.TextChanged, SuburbComboBox.TextChanged

        RefreshTa()

    End Sub


    Friend Sub RefreshTa()

        Try
            Me.ta.Fill(Me.RiskDataSet.ClaimSearch, ClaimNoTextBox.Text, MobileNoTextBox.Text, FamilyNameTextBox.Text, GivenNameTextBox.Text, SuburbComboBox.Text, StatusComboBox.Text, StateComboBox.Text, LocalAddressTextBox.Text, EmailAddressTextBox.Text)

        Catch ex As Exception
            MsgBox(ex.Message, , "FindClaimButton_Click()")
        End Try
    End Sub



    'Private Sub SearchData()
    '    Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString

    '    Using con As New OdbcConnection(constring)

    '        Using cmd As New OdbcCommand("{? = CALL dbo.ClaimSearch(?, ?, ?, ?, ?, ?, ?, ?,?)}", con)

    '            cmd.CommandType = CommandType.StoredProcedure

    '            Dim prm As OdbcParameter = cmd.Parameters.Add("@RETURN_VALUE", OdbcType.Int)
    '            prm.Direction = ParameterDirection.ReturnValue

    '            Dim ClaimNumber As OdbcParameter = cmd.Parameters.Add("@ClaimNumber", OdbcType.VarChar, 50)
    '            ClaimNumber.Value = ClaimNoTextBox.Text

    '            Dim MobilePhoneNumber As OdbcParameter = cmd.Parameters.Add("@MobilePhoneNumber", OdbcType.VarChar, 50)
    '            MobilePhoneNumber.Value = MobileNoTextBox.Text

    '            Dim FamilyName As OdbcParameter = cmd.Parameters.Add("@FamilyName", OdbcType.VarChar, 250)
    '            FamilyName.Value = FamilyNameTextBox.Text

    '            Dim GivenName As OdbcParameter = cmd.Parameters.Add("@GivenName", OdbcType.VarChar, 250)
    '            GivenName.Value = GivenNameTextBox.Text


    '            Dim PostalSuburb As OdbcParameter = cmd.Parameters.Add("@PostalSuburb", OdbcType.VarChar, 50)
    '            PostalSuburb.Value = SuburbComboBox.Text

    '            Dim Status As OdbcParameter = cmd.Parameters.Add("@Status", OdbcType.VarChar, 50)
    '            Status.Value = StatusComboBox.Text


    '            Dim cla_PostalState As OdbcParameter = cmd.Parameters.Add("@cla_PostalState", OdbcType.VarChar, 50)
    '            cla_PostalState.Value = StateComboBox.Text

    '            Dim PostalAddress1 As OdbcParameter = cmd.Parameters.Add("@PostalAddress1", OdbcType.VarChar, 50)
    '            PostalAddress1.Value = LocalAddressTextBox.Text




    '            Dim Email As OdbcParameter = cmd.Parameters.Add("@EmailAddress", OdbcType.VarChar, 100)
    '            Email.Value = EmailAddressTextBox.Text


    '            Using sda As New OdbcDataAdapter(cmd)

    '                Using ds As New DataSet()
    '                    sda.Fill(ds)
    '                    TblClaimBindingSource.DataSource = ds.Tables(0)
    '                    TblClaimDataGridView.DataSource = TblClaimBindingSource
    '                    TblClaimBindingNavigator.BindingSource = TblClaimBindingSource

    '                    con.Close()
    '                End Using
    '            End Using

    '        End Using

    '    End Using
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
        EmailAddressTextBox.Text = ""
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
        Else
            ' {... statements...}
        End If


    End Sub




End Class