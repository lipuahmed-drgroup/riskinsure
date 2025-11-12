Imports DGVCopyNS.DGVCopyClass
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Odbc

Public Class LossDateReport

    Private Sub UndockButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndockButton.Click
        MdiButtonClick(UndockButton, Me)
    End Sub

    Private Sub BindGrid()

        Dim constring As String = System.Configuration.ConfigurationManager.ConnectionStrings("Risk.My.MySettings.RiskConnectionString").ConnectionString
        Dim sqlString As String = " SELECT tblClaim.IMEINumber,  tblClaim.ClaimNumber, tblScheme.SchemeName, tblClaim.Status, tblClaim.RepairReplaceCashIndicator, COUNT(tblClaim.ClaimNumber) AS CountOfClaimNumber,  " & _
             "               SUM(tblClaim.Excess) AS SumOfExcess, SUM(tblClaim.TotalClaimCost) AS SumOfTotalClaimCost, SUM(tblClaim.TotalCostLessGST) AS SumOfTotalCostLessGST,  " & _
              "              tblClaim.LossDate, tblClaim.CurrentPhoneID, tblPhone.Make + ' ' + tblPhone.Model AS ReplacePhoneID, tblClaim.ContactNumber, tblClaim.GivenName,  " & _
                            " tblClaim.FamilyName, tblClaim.cla_IMEIBlocked  " & _
   " FROM            { oj { oj tblClaim LEFT OUTER JOIN  " & _
     "                       tblPhone ON tblClaim.ReplacePhoneID = tblPhone.PhoneID } LEFT OUTER JOIN  " & _
      "                      tblScheme ON tblClaim.SchemeID = tblScheme.SchemeID }  " & _
   " GROUP BY tblClaim.IMEINumber, tblClaim.ClaimNumber, tblScheme.SchemeName, tblClaim.Status, tblClaim.RepairReplaceCashIndicator, tblClaim.LossDate, tblClaim.CurrentPhoneID,  " & _
     "                       tblClaim.ContactNumber, tblClaim.GivenName, tblClaim.FamilyName, tblClaim.cla_IMEIBlocked, tblPhone.Make + ' ' + tblPhone.Model  " & _
           " HAVING        (tblClaim.LossDate BETWEEN '" + CDate(StartDate).ToString("MM/dd/yyyy hh:mm tt") + "' AND  '" + CDate(EndDate).ToString("MM/dd/yyyy hh:mm tt") + "')"


        Using con As New OdbcConnection(constring)
            Using cmd As New OdbcCommand(sqlString, con)

                cmd.CommandType = CommandType.Text

                Using sda As New OdbcDataAdapter(cmd)

                    Using ds As New DataSet()
                        sda.Fill(ds)

                        LossDateReportBindingSource.DataSource = ds.Tables(0)
                        LossDateReportBindingNavigator.BindingSource = LossDateReportBindingSource
                        LossDateReportDataGridView.DataSource = LossDateReportBindingSource

                        con.Close()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub LossDateReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SetMdi(Me)
        Try
            BindGrid()
            ' Me.LossDateReportTableAdapter.Fill(Me.ReconciliationDataSet.LossDateReport, StartDate, EndDate)
        Catch ex As Exception
            MsgBox(ex.Message, , "LossDateReport_Load()")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            DGVCopy(LossDateReportDataGridView)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class