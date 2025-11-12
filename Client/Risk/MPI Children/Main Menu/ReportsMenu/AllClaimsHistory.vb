Imports DGVCopyNS.DGVCopyClass
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class AllClaimsHistory

    Private StartDate
    Private EndDate
    Private Sub AllClaimsHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            BindGrid()
        Catch ex As Exception
            MsgBox(ex.Message, , "AllClaimsHistory_Load()")
        End Try
    End Sub

    Private Sub BindGrid()

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString


        Dim sqlString As String = "  SELECT tblClaim.MobilePhoneNumber, tblScheme.SchemeName, " &
                           " tblClaim.FamilyName + ', ' + tblClaim.GivenName AS Name1, " &
                           " Status, " &
                           " tblClaim.ClaimNumber, tblClaim.LodgedDate, tblClaim.LossDate, " &
                           " tblClaim.RepairReplaceCashIndicator AS ClaimType, " &
                           " tblClaim.LossType, " &
                           " tblClaim.TotalClaimCost AS TotalCostLessExcess, " &
                           " tblClaim.cla_PostalState, " &
                           " tblClaim.cla_OtherPaidTo AS [ExcessPaidTo1], tblClaim.cla_OtherPaidToDate AS [Date1], " &
                           " tblClaim.cla_OtherInvoiceNo1 AS [ExcessPaidTo2],  " &
                           " tblClaim.cla_OtherInvoiceNo1Amt AS [Date2], tblClaim.cla_IMEIBlocked AS IMEIBlocked, tblClaim.IMEINumber,   " &
                           " tblClaim.cla_IMEINotBlockedReason AS IMEINotBlockedReason, tblClaim.PurchaseDate, tblClaim.PhoneDealer, " &
                           " tblClaim.PostalSuburb as Suburb, " &
                           " tblClaim.DeliverySuburb , " &
                           " tblClaim.cla_ProofOfPurchase AS ProofOfPurchase, " &
                           " CASE WHEN CurrentPhoneID is not null AND CurrentPhoneID>0 " &
                           " THEN (SELECT Make + ' ' + MODEL FROM tblPhone WHERE PhoneID = CurrentPhoneID ) " &
                           " ELSE '' END AS CurrentPhoneInfo, " &
                           " tblPhone.Make + ' ' + tblPhone.Model AS ReplacePhoneID, " &
                           " t_Supplier.sup_Name as Supplier, " &
                           " tblScheme.sch_sup_id, tblClaim.InsuranceDate, CaseManager, " &
                           " tblClaim.Repairer, tblClaim.PaidStatusDate " &
                           " FROM tblScheme  INNER JOIN tblClaim " &
                           " ON tblScheme.SchemeID = tblClaim.SchemeID LEFT OUTER JOIN tblPhone " &
                           " ON tblClaim.ReplacePhoneID = tblPhone.PhoneID " &
                           " LEFT OUTER JOIN t_Supplier ON tblClaim.cla_ReplacePhone_sup_id = t_Supplier.sup_id " &
                           " WHERE (tblClaim.LodgedDate BETWEEN '" + CDate(StartDate).ToString("MM/dd/yyyy hh:mm tt") + "' AND  '" + CDate(EndDate).ToString("MM/dd/yyyy hh:mm tt") + "') " &
                           " AND (tblClaim.Status LIKE 'More Info' " &
                           " OR tblClaim.Status LIKE 'Paid' " &
                           " OR tblClaim.Status LIKE 'Approved' " &
                           " OR tblClaim.Status LIKE 'Closed' " &
                           " OR tblClaim.Status LIKE 'Declined') "


        Using con As New OdbcConnection(constring)
            Using cmd As New OdbcCommand(sqlString, con)
                cmd.CommandType = CommandType.Text
                Using sda As New OdbcDataAdapter(cmd)

                    Using ds As New DataSet()
                        sda.Fill(ds)

                        AllClaimsHistoryBindingSource.DataSource = ds.Tables(0)
                        AllClaimsHistoryBindingNavigator.BindingSource = AllClaimsHistoryBindingSource
                        AllClaimsHistoryDataGridView.DataSource = AllClaimsHistoryBindingSource

                        con.Close()
                    End Using
                End Using

            End Using
        End Using
    End Sub

    Public Shadows Sub Showdialog(ByVal StartDate, ByVal EndDate)
        If StartDate = Nothing Or EndDate = Nothing Then
            MsgBox("Please Enter Start and End dates", , Me.Text)
            Return
        End If
        Me.StartDate = StartDate
        Me.EndDate = EndDate
        MyBase.ShowDialog()
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

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(AllClaimsHistoryDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class