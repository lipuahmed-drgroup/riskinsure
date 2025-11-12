Imports DGVCopyNS.DGVCopyClass
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class PaymentsRecon

    Private Sub PaymentsRecon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            'Me.ReconPaymentsTableAdapter.Fill(Me.ReconciliationDataSet.ReconPayments, StartDate, EndDate)
            BindGrid()
        Catch ex As Exception
            MsgBox(ex.Message, , "PaymentsRecon_Load()")
        End Try
    End Sub


    Private Sub BindGrid()

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString


        Dim sqlString As String = "SELECT tblClaim.MobilePhoneNumber, tblScheme.SchemeName, tblClaim.ClaimNumber, tblClaim.PaidStatusDate, tblClaim.cla_PhoneAccessoriesPaidTo, " & _
        "ReplaceCost, FreightCost, RepairCost, UnauthorisedCalls, cla_ShortfallUpgradeCost, Excess," & _
        "tblClaim.cla_InvoiceNo1, tblClaim.cla_PhoneAccessoriesInvoiceNo1Amt, tblClaim.cla_PhoneAccessoriesPaidTo2, tblClaim.cla_InvoiceNo2," & _
        "tblClaim.cla_PhoneAccessoriesInvoiceNo2Amt, tblClaim.cla_PhoneAccessoriesPaidTo3, tblClaim.cla_PhoneAccessoriesInvoiceNo3," & _
        "tblClaim.cla_PhoneAccessoriesInvoiceNo3Amt, tblClaim.cla_PhoneAccessoriesPaidTo4, tblClaim.cla_PhoneAccessoriesInvoiceNo4," & _
        "tblClaim.cla_PhoneAccessoriesInvoiceNo4Amt, tblClaim.cla_PhoneAccessoriesInvoiceNo5, tblClaim.cla_PhoneAccessoriesInvoiceNo5Amt," & _
        "tblClaim.cla_PhoneAccessoriesInvoiceNo6, tblClaim.cla_PhoneAccessoriesInvoiceNo6Amt, tblClaim.cla_SimCardPaidTo, tblClaim.cla_SimCardPaidToDate," & _
        "tblClaim.cla_SimCardInvoiceNo1, tblClaim.cla_SimCardInvoiceNo1Amt, tblClaim.cla_RepairerPaidTo, tblClaim.cla_RepairerPaidToDate," & _
        "tblClaim.cla_RepairerInvoiceNo1, tblClaim.cla_RepairerInvoiceNo1Amt, tblClaim.cla_RepairerInvoiceNo2, tblClaim.cla_RepairerInvoiceNo2Amt," & _
        "tblClaim.cla_RepairerInvoiceNo3, tblClaim.cla_RepairerInvoiceNo3Amt, tblClaim.cla_OtherPaidTo, tblClaim.cla_OtherPaidToDate, tblClaim.cla_OtherInvoiceNo1," & _
        "tblClaim.cla_OtherInvoiceNo1Amt, tblClaim.cla_OtherInvoiceNo2, tblClaim.cla_OtherInvoiceNo2Amt, tblClaim.cla_OtherInvoiceNo3, tblClaim.cla_OtherInvoiceNo3Amt," & _
        "tblClaim.LossDate, tblClaim.cla_PostalState, tblClaim.LodgedDate, tblClaim.Status, tblClaim.LossType, tblClaim.cla_TerminalId" & _
        " FROM { oj tblClaim LEFT OUTER JOIN" & _
        " tblScheme ON tblClaim.SchemeID = tblScheme.SchemeID }" & _
        " WHERE (tblClaim.PaidStatusDate BETWEEN '" + CDate(StartDate).ToString("MM/dd/yyyy hh:mm tt") + "' AND  '" + CDate(EndDate).ToString("MM/dd/yyyy hh:mm tt") + "')"








        'cla_ReplacePhone_sup_id = " + supplierID.ToString() + " AND ApprovedStatusDate between '" + CDate(TextBox1.Text).ToString("MM/dd/yyyy hh:mm tt") + "'  and '" + CDate(TextBox2.Text).ToString("MM/dd/yyyy hh:mm tt") + "'"

        Using con As New OdbcConnection(constring)
            Using cmd As New OdbcCommand(sqlString, con)

                cmd.CommandType = CommandType.Text

                Using sda As New OdbcDataAdapter(cmd)

                    Using ds As New DataSet()
                        sda.Fill(ds)
                        ReconPaymentsBindingSource.DataSource = ds.Tables(0)
                        ReconPaymentsBindingNavigator.BindingSource = ReconPaymentsBindingSource
                        ReconPaymentsDataGridView.DataSource = ReconPaymentsBindingSource
                        con.Close()
                    End Using
                End Using

            End Using
        End Using
    End Sub

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(UndockButton, Me)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(ReconPaymentsDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class